using System;
using System.Collections.Generic;
using System.Text;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Systems;
using Mdl.Utils;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x20007F9")]
	public class CullingGroupStreamingManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20007FA")]
		private struct DebugStats
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002CA6")]
			public int loadingCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4002CA7")]
			public int loadedCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002CA8")]
			public int nullCount;

			[Cpp2IlInjected.Token(Token = "0x60023B9")]
			[Cpp2IlInjected.Address(RVA = "0x1196120", Offset = "0x1194B20", VA = "0x181196120")]
			public void Reset()
			{
				nullCount = (loadingCount = 0);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002C87")]
		public string OSDManagerName = "CullingGroupStreamingManager";

		[Cpp2IlInjected.Token(Token = "0x4002C88")]
		public static float Lifetime;

		[Cpp2IlInjected.Token(Token = "0x4002C89")]
		public static float InstantUnload = 0f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C8A")]
		private float _firstBand = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C8B")]
		private float _secondBand = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002C8C")]
		private int _loadsPerSecond = 60;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002C8D")]
		private int _maxConcurrentLoads = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002C8E")]
		private Camera targetCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002C8F")]
		private PendingLoads toLoad = new PendingLoads(256);

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002C90")]
		private (int index, float time, float distance)[] toRemove = new(int, float, float)[256];

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002C91")]
		private int toRemoveCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002C92")]
		private BoundingSphere[] boundingSpheres = new BoundingSphere[256];

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002C93")]
		private ICullable[] cullables = new ICullable[256];

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002C94")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4002C95")]
		private float timeSpent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002C96")]
		private CullingGroup group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002C97")]
		public StreamingManagerConfig.StreamingLimitMethod Limiter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4002C98")]
		public int ConfiguredLoadsPerSecond = 60;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002C99")]
		public int ConfiguredMaxConcurrentLoads = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4002C9A")]
		public int ConfiguredBoostedMaxConcurrentLoads = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002C9B")]
		private float[] _distanceBands;

		[Cpp2IlInjected.Token(Token = "0x4002C9C")]
		private static readonly ProfilerMarker s_markerCheckPending;

		[Cpp2IlInjected.Token(Token = "0x4002C9D")]
		private static readonly ProfilerMarker s_markerUpdateLoad;

		[Cpp2IlInjected.Token(Token = "0x4002C9E")]
		private static readonly ProfilerMarker s_markerGetLimitCount;

		[Cpp2IlInjected.Token(Token = "0x4002C9F")]
		private static readonly ProfilerMarker s_markerUpdateLoadCullable;

		[Cpp2IlInjected.Token(Token = "0x4002CA0")]
		private static readonly ProfilerMarker s_markerUpdateUnload;

		[Cpp2IlInjected.Token(Token = "0x4002CA1")]
		private static readonly ProfilerMarker s_markerForceLoad;

		[Cpp2IlInjected.Token(Token = "0x4002CA2")]
		private static readonly ProfilerMarker s_markerLoadPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002CA3")]
		private Func<float, int> LoadLimitingMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002CA4")]
		private int boostCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4002CA5")]
		private DebugStats dbgStats;

		[Cpp2IlInjected.Token(Token = "0x17000503")]
		public int PendingLoadCount
		{
			[Cpp2IlInjected.Token(Token = "0x600238F")]
			[Cpp2IlInjected.Address(RVA = "0x110A660", Offset = "0x1109060", VA = "0x18110A660")]
			get
			{
				//Discarded unreachable code: IL_000c
				return toLoad.ReadyCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000504")]
		public ICullable[] Cullables
		{
			[Cpp2IlInjected.Token(Token = "0x6002390")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return cullables;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000505")]
		public int CullableCount
		{
			[Cpp2IlInjected.Token(Token = "0x6002391")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000506")]
		public float LoadDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6002392")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return _firstBand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000507")]
		public float UnLoadDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6002393")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get
			{
				return _secondBand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000508")]
		public int LoadsPerSecond
		{
			[Cpp2IlInjected.Token(Token = "0x6002394")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return _loadsPerSecond;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000509")]
		public Camera TargetCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6002395")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return targetCamera;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002396")]
		[Cpp2IlInjected.Address(RVA = "0x1107F20", Offset = "0x1106920", VA = "0x181107F20")]
		private (float, bool) LoadPriority(int i)
		{
			//IL_0054: Expected F4, but got I4
			ICullable[] array = cullables;
			ICullable cullable = array[i];
			if (array == null)
			{
			}
			ICullable cullable2 = cullables[i];
			ICullable cullable3 = cullables[i];
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			float a = default(float);
			float num2 = Mathf.Max(a, num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002397")]
		[Cpp2IlInjected.Address(RVA = "0x1107C30", Offset = "0x1106630", VA = "0x181107C30")]
		public void InitWithConfig(StreamingManagerConfig parentConfig, StreamingManagerConfig.Data configData)
		{
			//Discarded unreachable code: IL_00d7
			PendingLoads pendingLoads = toLoad;
			Func<int, (float, bool)> func = (pendingLoads.UpdatePriorityCallback = (Func<int, (float, bool)>)(object)new Func<T, TResult>(LoadPriority));
			StreamingManagerConfig.StreamingLimitMethod streamingLimitMethod = (Limiter = configData.LimitMethod);
			int num = (ConfiguredLoadsPerSecond = configData.LoadsPerSecond);
			int num2 = (ConfiguredMaxConcurrentLoads = configData.MaxConcurrentLoads);
			int num3 = (ConfiguredBoostedMaxConcurrentLoads = configData.BoostedMaxConcurrentLoads);
			if (!configData.SyncWithFarClip)
			{
				float num4 = (_firstBand = configData.MustBeLoadedDistance);
			}
			if (!parentConfig.UseDynamicFarClipCulling)
			{
				float num5 = (_firstBand = parentConfig.ForcedFarClipLoadDistance);
			}
			float[] layerCullDistances = GraphicSettings.CurrentGraphicSettingsData.LayerCullDistances;
			float num6 = layerCullDistances[0];
			int num7 = 0;
			float num8 = layerCullDistances[2];
			float num9 = default(float);
			num6 = num9;
			num9 = (_firstBand = num6);
			_secondBand = num6;
			InitCullingGroupAndTargetCamera();
			ResetLoadLimit();
			UpdateDistanceBands();
		}

		[Cpp2IlInjected.Token(Token = "0x6002398")]
		[Cpp2IlInjected.Address(RVA = "0x11094B0", Offset = "0x1107EB0", VA = "0x1811094B0")]
		public void ResetLoadLimit()
		{
			int num = (_loadsPerSecond = ConfiguredLoadsPerSecond);
			int num2 = (_maxConcurrentLoads = ConfiguredMaxConcurrentLoads);
			Func<float, int> func = (LoadLimitingMethod = (Func<float, int>)(object)new Func<T, TResult>(LimitConcurrentLoads));
			if (Limiter == StreamingManagerConfig.StreamingLimitMethod.LoadsPerSecond)
			{
				Func<float, int> func2 = (LoadLimitingMethod = (Func<float, int>)(object)new Func<T, TResult>(LimitStartLoadsPerSecond));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002399")]
		[Cpp2IlInjected.Address(RVA = "0x1109810", Offset = "0x1108210", VA = "0x181109810")]
		public void StartBoostLoadLimit()
		{
			int num = (_loadsPerSecond = ConfiguredLoadsPerSecond);
			int num2 = (_maxConcurrentLoads = ConfiguredBoostedMaxConcurrentLoads);
		}

		[Cpp2IlInjected.Token(Token = "0x600239A")]
		[Cpp2IlInjected.Address(RVA = "0x1109830", Offset = "0x1108230", VA = "0x181109830")]
		public void StopBoostLoadLimit()
		{
			ResetLoadLimit();
		}

		[Cpp2IlInjected.Token(Token = "0x600239B")]
		[Cpp2IlInjected.Address(RVA = "0x1106C80", Offset = "0x1105680", VA = "0x181106C80")]
		protected void Awake()
		{
			//Discarded unreachable code: IL_0026
			InitCullingGroupAndTargetCamera();
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			PlayerAvatar.AvatarTeleported value = OnAvatarTeleported;
			avatar.OnAvatarTeleported += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600239C")]
		[Cpp2IlInjected.Address(RVA = "0x1107980", Offset = "0x1106380", VA = "0x181107980")]
		private void InitCullingGroupAndTargetCamera()
		{
			//Discarded unreachable code: IL_00cf
			//IL_009b: Expected O, but got I4
			Camera camera = (targetCamera = SystemRoot.Instance._playerCamera);
			if ((long)group == 0)
			{
				CullingGroup cullingGroup = new CullingGroup();
				Camera camera3 = (cullingGroup.targetCamera = targetCamera);
				group = cullingGroup;
				CullingGroup cullingGroup2 = group;
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				cullingGroup2.SetDistanceReferencePoint_InternalTransform(_003Ctransform_003Ek__BackingField);
				CullingGroup cullingGroup3 = group;
				CullingGroup.StateChanged onStateChanged = cullingGroup3.onStateChanged;
				CullingGroup.StateChanged b = OnStateChange;
				Delegate @delegate = Delegate.Combine(onStateChanged, b);
				int num = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				cullingGroup3.onStateChanged = (CullingGroup.StateChanged)num;
				UpdateDistanceBands();
				CullingGroup cullingGroup4 = group;
				BoundingSphere[] array = boundingSpheres;
				cullingGroup4.SetBoundingSpheres(array);
				CullingGroup cullingGroup5 = group;
				int boundingSphereCount = 0;
				cullingGroup5.SetBoundingSphereCount(boundingSphereCount);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600239D")]
		[Cpp2IlInjected.Address(RVA = "0x11096D0", Offset = "0x11080D0", VA = "0x1811096D0")]
		public void SetDistanceReferencePoint(Transform transform)
		{
			group?.SetDistanceReferencePoint_InternalTransform(transform);
		}

		[Cpp2IlInjected.Token(Token = "0x600239E")]
		[Cpp2IlInjected.Address(RVA = "0x11081C0", Offset = "0x1106BC0", VA = "0x1811081C0")]
		private void OnAvatarTeleported(Vector3 position, PlayerAvatar.AvatarTeleportedReason reason)
		{
			if (reason == PlayerAvatar.AvatarTeleportedReason.PlayerInitialPosition || reason == PlayerAvatar.AvatarTeleportedReason.Movement)
			{
				ForceAllUpdateStateChange();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600239F")]
		[Cpp2IlInjected.Address(RVA = "0x11081E0", Offset = "0x1106BE0", VA = "0x1811081E0")]
		protected void OnDestroy()
		{
			//Discarded unreachable code: IL_0053
			//IL_0013: Expected O, but got I4
			//IL_0013: Expected O, but got I4
			//IL_0052: Expected O, but got I8
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				PlayerAvatar.AvatarTeleported value = OnAvatarTeleported;
				avatar.OnAvatarTeleported -= value;
			}
			CullingGroup cullingGroup = group;
			if (cullingGroup != null)
			{
				cullingGroup.Dispose();
				group = (CullingGroup)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023A0")]
		[Cpp2IlInjected.Address(RVA = "0x1108860", Offset = "0x1107260", VA = "0x181108860")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00de
			ICullable[] array4 = default(ICullable[]);
			uint distanceIndex2 = default(uint);
			while ((long)group != 0)
			{
				int[] array = new int[256];
				ICullable[] array2 = cullables;
				int num = 0;
				if (num < array2.Length)
				{
					CullingGroup cullingGroup = group;
					int distanceIndex = 0;
					if (cullingGroup.QueryIndices(distanceIndex, array, num) > 0)
					{
						int num2 = array[num];
						ICullable[] array3 = cullables;
						ICullable cullable = array3[num2];
						if (array3 == null)
						{
							ICullable cullable2 = cullables[num2];
						}
						num++;
					}
					array4 = cullables;
				}
				CullingGroup cullingGroup2 = group;
				if (num >= array4.Length)
				{
					break;
				}
				if (cullingGroup2.QueryIndices((int)distanceIndex2, array, num) > 0)
				{
					ICullable[] array5 = cullables;
					int num3 = array[num];
					ICullable cullable3 = array5[num3];
					if (num == 0)
					{
						toLoad.EnqueueUnique(num3);
					}
					num++;
				}
				if (cullables == null)
				{
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023A1")]
		[Cpp2IlInjected.Address(RVA = "0x11083E0", Offset = "0x1106DE0", VA = "0x1811083E0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0060
			if ((long)group == 0)
			{
				return;
			}
			toLoad.Reset();
			int num = (toRemoveCount = 0);
			if (count > num)
			{
				ICullable[] array = cullables;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (num != 0)
				{
					ICullable[] array2 = cullables;
				}
				num++;
			}
			CullingGroup cullingGroup = group;
			int num3 = ((cullingGroup.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60023A2")]
		[Cpp2IlInjected.Address(RVA = "0x1109D20", Offset = "0x1108720", VA = "0x181109D20")]
		protected void UpdateDistanceBands()
		{
			//Discarded unreachable code: IL_0066
			//IL_0045: Expected F4, but got I8
			if ((long)group != 0)
			{
				float[] array = new float[3];
				float firstBand = _firstBand;
				int length = array.Length;
				array[0] = firstBand;
				float num = (array[0] = _secondBand);
				array[1] = 2.139095E+09f;
				_distanceBands = array;
				CullingGroup cullingGroup = group;
				float[] distanceBands = _distanceBands;
				cullingGroup.SetBoundingDistances(distanceBands);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023A3")]
		[Cpp2IlInjected.Address(RVA = "0x1109E10", Offset = "0x1108810", VA = "0x181109E10")]
		private void Update()
		{
			//Discarded unreachable code: IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4
			//IL_0033: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			uint num5 = default(uint);
			uint num6 = default(uint);
			int num;
			while (true)
			{
				num = 0;
				int num2 = 0;
				float deltaTime = Time.deltaTime;
				PendingLoads pendingLoads = toLoad;
				int num3 = 0;
				if (!pendingLoads.UpdateAndCheckForPending())
				{
					break;
				}
				Func<float, int> loadLimitingMethod = LoadLimitingMethod;
				if (loadLimitingMethod == null)
				{
					break;
				}
				int num4 = (int)loadLimitingMethod((T)num3);
				IEnumerable<int> enumerable = (IEnumerable<int>)toLoad.Dequeue(num4);
				if (enumerable != null)
				{
					if (num < (int)num5)
					{
						num += num;
						if (num == (int)num5)
						{
							continue;
						}
						num++;
					}
					ICullable cullable = cullables[(object)enumerable];
					if (num < (int)num6)
					{
						num += num;
						num++;
					}
					num += 424;
				}
				if (enumerable == null)
				{
				}
				break;
			}
			int num7 = 0;
			if (cullables == null)
			{
				float lifetime = Lifetime;
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60023A4")]
		[Cpp2IlInjected.Address(RVA = "0x1107890", Offset = "0x1106290", VA = "0x181107890")]
		private float GetCurrentDistance(int index)
		{
			if (index < count)
			{
				BoundingSphere[] array = boundingSpheres;
				Transform transform = targetCamera.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float result = default(float);
				return result;
			}
			int num = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023A5")]
		[Cpp2IlInjected.Address(RVA = "0x1107780", Offset = "0x1106180", VA = "0x181107780")]
		private int GetCurrentDistanceIndex(int index)
		{
			//Discarded unreachable code: IL_0037
			if (index < count)
			{
				float distanceMinusRadius = GetCurrentDistance(index);
				float[] distanceBands = _distanceBands;
				Predicate<float> predicate = (Predicate<float>)(object)(Predicate<T>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
				int result = default(int);
				return result;
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60023A6")]
		[Cpp2IlInjected.Address(RVA = "0x1107580", Offset = "0x1105F80", VA = "0x181107580")]
		private void ForceAllUpdateStateChange()
		{
			//Discarded unreachable code: IL_0064
			int num = 0;
			if (count <= num)
			{
				return;
			}
			if (num < count)
			{
				float distanceMinusRadius = GetCurrentDistance(num);
				float[] distanceBands = _distanceBands;
				Predicate<float> predicate = (Predicate<float>)(object)(Predicate<T>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
				ICullable cullable = cullables[num];
				float instantUnload = InstantUnload;
				int currentDistanceIndex = default(int);
				DoStateChange(num, currentDistanceIndex, isVisible: true, instantUnload);
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60023A7")]
		[Cpp2IlInjected.Address(RVA = "0x1109010", Offset = "0x1107A10", VA = "0x181109010")]
		private void OnStateChange(CullingGroupEvent evt)
		{
			float lifetime = Lifetime;
		}

		[Cpp2IlInjected.Token(Token = "0x60023A8")]
		[Cpp2IlInjected.Address(RVA = "0x1106FE0", Offset = "0x11059E0", VA = "0x181106FE0")]
		private void DoStateChange(int index, int currentDistanceIndex, bool isVisible, float unloadDelay)
		{
			//Discarded unreachable code: IL_014d
			int index2 = index;
			ICullable cullable = cullables[index];
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				PlayerAvatar avatar = _003CInstance_003Ek__BackingField._avatar;
				int num = 0;
				if ((object)avatar != null)
				{
					bool flag = (avatar._isTeleportedAtInitialPosition ? 1 : 0) == num;
				}
			}
			if ((object)_003CInstance_003Ek__BackingField == null || (object)_003CInstance_003Ek__BackingField != null)
			{
				return;
			}
			if ((IntPtr)currentDistanceIndex != (IntPtr)_003CInstance_003Ek__BackingField)
			{
				(int, float, float)[] array = toRemove;
				Predicate<(int, float, float)> predicate = (Predicate<(int, float, float)>)(object)(Predicate<T>)delegate
				{
					int num9 = index2;
					bool result = default(bool);
					return result;
				};
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					ICullable[] array2 = cullables;
					int num2 = index2;
					ICullable cullable2 = array2[num2];
					int index3 = index2;
					int num3 = 0;
					float currentDistance = GetCurrentDistance(index3);
					int num4 = index2;
					int num5 = 0;
				}
				PendingLoads pendingLoads = toLoad;
				int id = index2;
				pendingLoads.Remove(id);
				if ((object)_003CInstance_003Ek__BackingField == null)
				{
					PendingLoads pendingLoads2 = toLoad;
					int id2 = index2;
					pendingLoads2.EnqueueUnique(id2);
				}
				PendingLoads pendingLoads3 = toLoad;
				int id3 = index2;
				pendingLoads3.Remove(id3);
				if ((object)_003CInstance_003Ek__BackingField == null)
				{
					ICullable[] array3 = cullables;
					int num6 = index2;
					ICullable cullable3 = array3[num6];
				}
			}
			ICullable[] array4 = cullables;
			int num7 = index2;
			ICullable cullable4 = array4[num7];
			ICullable[] array5 = cullables;
			int num8 = index2;
			ICullable cullable5 = array5[num8];
		}

		[Cpp2IlInjected.Token(Token = "0x60023A9")]
		[Cpp2IlInjected.Address(RVA = "0x11067D0", Offset = "0x11051D0", VA = "0x1811067D0")]
		public bool AddAsset(ICullable cullable)
		{
			ICullable[] array = cullables;
			Predicate<ICullable> predicate = (Predicate<ICullable>)(object)(Predicate<T>)((ICullable x) => x == cullable);
			ICullable cullable2 = cullable;
			ICullable cullable3 = cullable;
			int num = 0;
			CullingGroup cullingGroup = group;
			BoundingSphere[] array2 = boundingSpheres;
			cullingGroup.SetBoundingSpheres(array2);
			CullingGroup cullingGroup2 = group;
			int boundingSphereCount = count;
			cullingGroup2.SetBoundingSphereCount(boundingSphereCount);
			Transform transform = targetCamera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				PlayerAvatar avatar = _003CInstance_003Ek__BackingField._avatar;
				if ((object)avatar != null)
				{
					int num2 = 0;
					bool isTeleportedAtInitialPosition = avatar._isTeleportedAtInitialPosition;
					float num3 = default(float);
					if (!(_firstBand <= num3))
					{
						ICullable[] array3 = cullables;
						int num4 = count;
						ICullable cullable4 = array3[num4];
						return true;
					}
				}
			}
			Debug.LogWarning("Attempted to cullable to distance culling but it was already registered");
			int num5 = default(int);
			ICullable cullable5 = cullables[num5];
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023AA")]
		[Cpp2IlInjected.Address(RVA = "0x11090E0", Offset = "0x1107AE0", VA = "0x1811090E0")]
		public bool RemoveAsset(ICullable cullableToRemove)
		{
			//IL_00e9: Expected O, but got I4
			ICullable[] array = cullables;
			Predicate<ICullable> predicate = (Predicate<ICullable>)(object)(Predicate<T>)((ICullable x) => x == cullableToRemove);
			int num = default(int);
			int index = num;
			ICullable cullable = cullableToRemove;
			int num2 = 0;
			string message = default(string);
			Debug.LogWarning(message);
			int num3 = 0;
			ICullable[] array2 = cullables;
			CullingGroup cullingGroup = group;
			int boundingSphereCount = count;
			cullingGroup.SetBoundingSphereCount(boundingSphereCount);
			PendingLoads pendingLoads = toLoad;
			int id = index;
			pendingLoads.Remove(id);
			(int, float, float)[] array3 = toRemove;
			Predicate<(int, float, float)> predicate2 = (Predicate<(int, float, float)>)(object)(Predicate<T>)delegate
			{
				int num8 = index;
				bool result2 = default(bool);
				return result2;
			};
			int num4 = index;
			int num5 = count;
			if (num4 != num5)
			{
				toLoad.UpdateID(num5, num4);
			}
			(int, float, float)[] array4 = toRemove;
			Predicate<(int, float, float)> predicate3 = (Predicate<(int, float, float)>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_000e
				int num7 = count;
				bool result = default(bool);
				return result;
			};
			(int, float, float)[] array5 = toRemove;
			int num6 = index;
			((ValueTuple<, , >[])(object)array5)[0] = (ValueTuple<, , >)num6;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023AB")]
		[Cpp2IlInjected.Address(RVA = "0x11095B0", Offset = "0x1107FB0", VA = "0x1811095B0")]
		public void Reset()
		{
			//IL_0062: Expected O, but got I4
			int num = 0;
			DebugOnScreenText instance = DebugOnScreenText.Instance;
			DebugOnScreenText.AddOnScreenText value = OnScreenDebugText;
			instance.OnAddOnScreenText -= value;
			int num2 = 0;
			if (count > num2)
			{
				ICullable[] array = cullables;
				num2++;
			}
			PendingLoads pendingLoads = toLoad;
			count = num2;
			toRemoveCount = num2;
			pendingLoads.Reset();
			group.Dispose();
			group = (CullingGroup)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023AC")]
		[Cpp2IlInjected.Address(RVA = "0x1109840", Offset = "0x1108240", VA = "0x181109840")]
		public void UpdateAssetTransform(ICullable cullableToRemove)
		{
			//Discarded unreachable code: IL_0031, IL_003b
			ICullable[] array = cullables;
			Predicate<ICullable> predicate = (Predicate<ICullable>)(object)(Predicate<T>)((ICullable x) => x == cullableToRemove);
			ICullable cullable = cullableToRemove;
			string message = default(string);
			Debug.LogWarning(message);
		}

		[Cpp2IlInjected.Token(Token = "0x60023AD")]
		[Cpp2IlInjected.Address(RVA = "0x1650000", Offset = "0x164EA00", VA = "0x181650000")]
		private void AddToBack<T>(ref T[] array, ref int count, T element)
		{
			//Discarded unreachable code: IL_0008
			count.m_value = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60023AE")]
		[Cpp2IlInjected.Address(RVA = "0x1650310", Offset = "0x164ED10", VA = "0x181650310")]
		private void EraseSwapBack<T>(ref T[] array, ref int count, int index)
		{
			//Discarded unreachable code: IL_0003
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60023AF")]
		[Cpp2IlInjected.Address(RVA = "0x1108580", Offset = "0x1106F80", VA = "0x181108580")]
		private void OnDrawGizmosSelected()
		{
			//Discarded unreachable code: IL_00c6
			int[] array = new int[count];
			CullingGroup cullingGroup = group;
			int num = 0;
			int firstIndex = 0;
			int distanceIndex = 0;
			int num2 = cullingGroup.QueryIndices(distanceIndex, array, firstIndex);
			Color green = Color.green;
			if (num2 > 0)
			{
				BoundingSphere[] array2 = boundingSpheres;
				int num3 = array[num];
				num += num;
				num++;
			}
			CullingGroup cullingGroup2 = group;
			int firstIndex2 = 0;
			num2 = cullingGroup2.QueryIndices(1, array, firstIndex2);
			Color yellow = Color.yellow;
			if (num2 > 0)
			{
				BoundingSphere[] array3 = boundingSpheres;
				int num4 = array[num];
				num += num;
				num++;
			}
			CullingGroup cullingGroup3 = group;
			int firstIndex3 = 0;
			int num5 = cullingGroup3.QueryIndices(2, array, firstIndex3);
			Color red = Color.red;
			if (num5 > 0)
			{
				BoundingSphere[] array4 = boundingSpheres;
				int num6 = array[num];
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023B0")]
		[Cpp2IlInjected.Address(RVA = "0x1109C30", Offset = "0x1108630", VA = "0x181109C30")]
		private void UpdateDebugStats()
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			if (count > num)
			{
				if (cullables[num] == null || num == 0 || num == 0)
				{
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023B1")]
		[Cpp2IlInjected.Address(RVA = "0x11096F0", Offset = "0x11080F0", VA = "0x1811096F0")]
		public void SetOSDEnable(bool isEnable)
		{
			//Discarded unreachable code: IL_0057
			int num = 0;
			DebugOnScreenText instance = DebugOnScreenText.Instance;
			if (!isEnable)
			{
				DebugOnScreenText.AddOnScreenText value = OnScreenDebugText;
				instance.OnAddOnScreenText -= value;
				return;
			}
			DebugOnScreenText.AddOnScreenText value2 = OnScreenDebugText;
			instance.OnAddOnScreenText -= value2;
			int num2 = 0;
			DebugOnScreenText instance2 = DebugOnScreenText.Instance;
			DebugOnScreenText.AddOnScreenText value3 = OnScreenDebugText;
			instance2.OnAddOnScreenText += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x60023B2")]
		[Cpp2IlInjected.Address(RVA = "0x1108B40", Offset = "0x1107540", VA = "0x181108B40")]
		private void OnScreenDebugText(StringBuilder dest)
		{
			//Discarded unreachable code: IL_016e
			//IL_0049: Expected O, but got I4
			//IL_00d9: Expected O, but got I4
			//IL_00fc: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			object[] array;
			int readyCount;
			while (true)
			{
				int num = 0;
				if (count > num)
				{
					if (cullables[num] == null || num == 0 || num == 0)
					{
					}
					num++;
				}
				int nullCount = dbgStats.nullCount;
				if (nullCount > 0)
				{
					string oSDManagerName = OSDManagerName;
					string value = $"{oSDManagerName} has {nullCount} null counts, this is is a bug in code.";
					StringBuilder stringBuilder = dest.AppendLine(value);
				}
				array = new object[5];
				string oSDManagerName2 = OSDManagerName;
				if (oSDManagerName2 != null && array == null)
				{
					continue;
				}
				array[0] = oSDManagerName2;
				float firstBand = _firstBand;
				if (array != null && array == null)
				{
					continue;
				}
				array[1] = array;
				float secondBand = _secondBand;
				if (array != null && array == null)
				{
					continue;
				}
				array[2] = array;
				readyCount = toLoad.ReadyCount;
				if (readyCount == 0 || readyCount != 0)
				{
					array[3] = readyCount;
					int num2 = toRemoveCount;
					readyCount = num2;
					if (num2 == 0 || num2 != 0)
					{
						break;
					}
				}
			}
			array[4] = readyCount;
			string value2 = string.Format("{0} LoadDist:{1} UnloadDist:{2} toLoad:{3} toRemove:{4}", array);
			StringBuilder stringBuilder2 = dest.AppendLine(value2);
			string value3 = OSDManagerName + " loaded/loading/total : ";
			StringBuilder stringBuilder3 = dest.Append(value3);
			int loadedCount = dbgStats.loadedCount;
			DebugStats debugStats = dbgStats;
			readyCount = loadedCount;
			int num3 = count;
			string value4 = $"{readyCount:D6}/{loadedCount:D6}/{loadedCount}";
			StringBuilder stringBuilder4 = dest.AppendLine(value4);
		}

		[Cpp2IlInjected.Token(Token = "0x60023B3")]
		[Cpp2IlInjected.Address(RVA = "0x1106DA0", Offset = "0x11057A0", VA = "0x181106DA0")]
		public void DebugUpdateAllBoundingSphere()
		{
			//Discarded unreachable code: IL_0057
			int num = 0;
			if (count > num)
			{
				BoundingSphere[] array = boundingSpheres;
				ICullable cullable = cullables[num];
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				BoundingSphere[] array2 = boundingSpheres;
				ICullable cullable2 = cullables[num];
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023B4")]
		[Cpp2IlInjected.Address(RVA = "0x1109AE0", Offset = "0x11084E0", VA = "0x181109AE0")]
		private void UpdateBoundingSphere(int index)
		{
			//Discarded unreachable code: IL_0032
			if (index < count)
			{
				BoundingSphere[] array = boundingSpheres;
				ICullable cullable = cullables[index];
				BoundingSphere[] array2 = boundingSpheres;
				ICullable cullable2 = cullables[index];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023B5")]
		[Cpp2IlInjected.Address(RVA = "0x1107EE0", Offset = "0x11068E0", VA = "0x181107EE0")]
		private int LimitStartLoadsPerSecond(float dt)
		{
			timeSpent = dt;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023B6")]
		[Cpp2IlInjected.Address(RVA = "0x1107E90", Offset = "0x1106890", VA = "0x181107E90")]
		private int LimitConcurrentLoads(float _)
		{
			//Discarded unreachable code: IL_000d
			StreamingStateInfo instance = StreamingStateInfo.Instance;
			return _maxConcurrentLoads;
		}

		[Cpp2IlInjected.Token(Token = "0x60023B7")]
		[Cpp2IlInjected.Address(RVA = "0x110A520", Offset = "0x1108F20", VA = "0x18110A520")]
		public CullingGroupStreamingManager()
		{
		}//IL_002b: Expected I4, but got I8
		//IL_0034: Expected I4, but got I8
		//IL_0086: Expected I4, but got I8
		//IL_008f: Expected I4, but got I8
		//IL_0099: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x60023B8")]
		[Cpp2IlInjected.Address(RVA = "0x110A2B0", Offset = "0x1108CB0", VA = "0x18110A2B0")]
		static CullingGroupStreamingManager()
		{
			//IL_0006: Expected F4, but got I4
			//IL_0027: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_006b: Expected O, but got I
			//IL_008d: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_00d1: Expected O, but got I
			//IL_00ec: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("GroupUpdateCheckPending", categoryId, (MarkerFlags)flags, metadataCount);
			int num2 = 0;
			s_markerCheckPending = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker("GroupUpdateLoad", categoryId2, (MarkerFlags)flags2, metadataCount2);
			int num3 = 0;
			s_markerUpdateLoad = (ProfilerMarker)(long)intPtr2;
			int flags3 = 0;
			int metadataCount3 = 0;
			ushort categoryId3 = default(ushort);
			IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker("GroupGetLimit", categoryId3, (MarkerFlags)flags3, metadataCount3);
			int num4 = 0;
			s_markerGetLimitCount = (ProfilerMarker)(long)intPtr3;
			int flags4 = 0;
			int metadataCount4 = 0;
			ushort categoryId4 = default(ushort);
			IntPtr intPtr4 = ProfilerUnsafeUtility.CreateMarker("GroupActualLoad", categoryId4, (MarkerFlags)flags4, metadataCount4);
			int num5 = 0;
			s_markerUpdateLoadCullable = (ProfilerMarker)(long)intPtr4;
			int flags5 = 0;
			int metadataCount5 = 0;
			ushort categoryId5 = default(ushort);
			IntPtr intPtr5 = ProfilerUnsafeUtility.CreateMarker("GroupUpdateUnload", categoryId5, (MarkerFlags)flags5, metadataCount5);
			int num6 = 0;
			s_markerUpdateUnload = (ProfilerMarker)(long)intPtr5;
			int flags6 = 0;
			int metadataCount6 = 0;
			ushort categoryId6 = default(ushort);
			IntPtr intPtr6 = ProfilerUnsafeUtility.CreateMarker("GroupForceLoad", categoryId6, (MarkerFlags)flags6, metadataCount6);
			int num7 = 0;
			s_markerForceLoad = (ProfilerMarker)(long)intPtr6;
			int flags7 = 0;
			int metadataCount7 = 0;
			ushort categoryId7 = default(ushort);
			s_markerLoadPriority = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("GroupLoadPriority", categoryId7, (MarkerFlags)flags7, metadataCount7);
		}
	}
}
