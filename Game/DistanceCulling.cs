using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Grid;
using Mdl.Streaming;
using Mdl.Systems;
using Meta.Grids;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DistanceCulling
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct Cullable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public uint id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public GridScript grid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncOperationHandle<GameObject> handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public bool visible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int lastDistanceIndex;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x137D470", Offset = "0x137BE70", VA = "0x18137D470")]
		public Cullable(uint id, GridScript grid, AsyncOperationHandle<GameObject> handle)
		{
			//IL_0025: Expected I4, but got I8
			this.id = id;
			this.grid = grid;
			visible = false;
			lastDistanceIndex = -1;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct DebugStats
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public int loadingCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int loadedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int nullCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int toLoadCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int toRemoveCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public float firstBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public float secondBand;
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float Lifetime;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float InstantUnload;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static int LoadsPerSecond;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static int MaxConcurrentLoads;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static int BoostedMaxConcurrentLoads;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static bool NoForceLoad;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static StreamingManagerConfig.StreamingLimitMethod Limiter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float firstBand = 20f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public float secondBand = 60f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float[] distanceBands;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Camera targetCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PendingLoads toLoad = new PendingLoads(256);

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private (int index, float time, float distance)[] toRemove = new(int, float, float)[256];

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int toRemoveCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private BoundingSphere[] boundingSpheres = new BoundingSphere[256];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private Cullable[] cullables = new Cullable[256];

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int count;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float timeSpent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private CullingGroup group;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private Func<float, int> LoadLimitingMethod;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int currentLoadsPerSecond = LoadsPerSecond;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int currentMaxConcurrentLoads = MaxConcurrentLoads;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int boostCount;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker s_markerCheckPending;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker s_markerUpdateLoad;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker s_markerGetLimitCount;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker s_markerUpdateLoadCullable;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker s_markerUpdateUnload;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker s_markerForceLoad;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker s_markerLoadPriority;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PendingLoadCount
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x19CF630", Offset = "0x19CE030", VA = "0x1819CF630")]
		get
		{
			//Discarded unreachable code: IL_000c
			return toLoad.ReadyCount;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
		get
		{
			return count;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x19CF070", Offset = "0x19CDA70", VA = "0x1819CF070")]
	public DistanceCulling(float firstBand, float secondBand)
	{
		//Discarded unreachable code: IL_01c9
		//IL_0129: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		Camera camera = (targetCamera = SystemRoot.Instance._playerCamera);
		this.firstBand = firstBand;
		this.secondBand = secondBand;
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
		if ((object)@delegate == null || (object)@delegate != null)
		{
			cullingGroup3.onStateChanged = (CullingGroup.StateChanged)num;
			UpdateDistanceBands();
			CullingGroup cullingGroup4 = group;
			BoundingSphere[] array = boundingSpheres;
			cullingGroup4.SetBoundingSpheres(array);
			CullingGroup cullingGroup5 = group;
			int boundingSphereCount = 0;
			cullingGroup5.SetBoundingSphereCount(boundingSphereCount);
			PendingLoads pendingLoads = toLoad;
			Func<int, (float, bool)> func = (pendingLoads.UpdatePriorityCallback = (Func<int, (float, bool)>)(object)new Func<T, TResult>(LoadPriority));
			ResetLoadLimit();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			PlayerAvatar avatar = default(PlayerAvatar);
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				avatar = _003CInstance_003Ek__BackingField._avatar;
			}
			int num2 = 0;
			if (avatar != (UnityEngine.Object)num2)
			{
				PlayerAvatar avatar2 = SystemRoot.Instance._avatar;
				PlayerAvatar.AvatarTeleported value = OnAvatarTeleported;
				avatar2.OnAvatarTeleported += value;
			}
			return;
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x19CD890", Offset = "0x19CC290", VA = "0x1819CD890")]
	private (float, bool) LoadPriority(int i)
	{
		//IL_003f: Expected F4, but got I4
		Cullable[] array = cullables;
		long num = (long)i * 56L;
		int num2 = 0;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		int num3 = 0;
		float a = default(float);
		float num4 = Mathf.Max(a, num3);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x19CE450", Offset = "0x19CCE50", VA = "0x1819CE450")]
	public void ResetLoadLimit()
	{
		int num = (currentLoadsPerSecond = LoadsPerSecond);
		int num2 = (currentMaxConcurrentLoads = MaxConcurrentLoads);
		Func<float, int> func = (LoadLimitingMethod = (Func<float, int>)(object)new Func<T, TResult>(LimitConcurrentLoads));
		Func<float, int> func2 = (LoadLimitingMethod = (Func<float, int>)(object)new Func<T, TResult>(LimitStartLoadsPerSecond));
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x19CE5C0", Offset = "0x19CCFC0", VA = "0x1819CE5C0")]
	public void StartBoostLoadLimit()
	{
		int num = (currentLoadsPerSecond = LoadsPerSecond);
		int num2 = (currentMaxConcurrentLoads = BoostedMaxConcurrentLoads);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x19CE640", Offset = "0x19CD040", VA = "0x1819CE640")]
	public void StopBoostLoadLimit()
	{
		ResetLoadLimit();
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x19CCCB0", Offset = "0x19CB6B0", VA = "0x1819CCCB0")]
	public void Enable()
	{
		//Discarded unreachable code: IL_00ee
		//IL_00ed: Expected I4, but got I8
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if ((IntPtr)group == (IntPtr)num)
		{
			return;
		}
		int[] array = new int[cullables.Length];
		CullingGroup cullingGroup = group;
		int num4 = 0;
		int firstIndex = 0;
		int distanceIndex = 0;
		if (cullingGroup.QueryIndices(distanceIndex, array, firstIndex) > 0)
		{
			Cullable[] array2 = cullables;
			long num5 = (long)array[num4] * 56L;
			bool flag = default(bool);
			if (!flag)
			{
				int num6 = array[num4];
				Cullable[] array3 = cullables;
				long num7 = (long)num6 * 56L;
				Cullable cullable = default(Cullable);
				array3[2] = cullable;
			}
			num4++;
		}
		CullingGroup cullingGroup2 = group;
		int firstIndex2 = 0;
		if (cullingGroup2.QueryIndices(1, array, firstIndex2) > 0)
		{
			Cullable[] array4 = cullables;
			long num8 = (long)array[num4] * 56L;
			bool flag2 = default(bool);
			if (!flag2)
			{
				PendingLoads pendingLoads = toLoad;
				int id = array[num4];
				pendingLoads.EnqueueUnique(id);
			}
			num4++;
		}
		ulong num9 = default(ulong);
		group.enabled = (byte)num9 != 0;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x19CC490", Offset = "0x19CAE90", VA = "0x1819CC490")]
	public void Disable()
	{
		//Discarded unreachable code: IL_0057
		int num = 0;
		int num2 = 0;
		if ((IntPtr)group == (IntPtr)num2)
		{
			return;
		}
		toLoad.Reset();
		int num3 = (toRemoveCount = 0);
		if (count > num3)
		{
			Cullable[] array = cullables;
			long num4 = (long)num3 * 56L;
			bool flag = default(bool);
			if (flag)
			{
			}
			num3++;
		}
		CullingGroup cullingGroup = group;
		int num5 = ((cullingGroup.enabled = false) ? 1 : 0);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x19CC290", Offset = "0x19CAC90", VA = "0x1819CC290")]
	public void Destroy()
	{
		//Discarded unreachable code: IL_0048
		//IL_0014: Expected O, but got I4
		//IL_0025: Expected O, but got I4
		//IL_0025: Expected O, but got I4
		group.Dispose();
		int num = 0;
		group = (CullingGroup)num;
		if ((object)SystemRoot.Instance != null)
		{
		}
		int num2 = 0;
		if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
		{
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			PlayerAvatar.AvatarTeleported value = OnAvatarTeleported;
			avatar.OnAvatarTeleported -= value;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x19CE790", Offset = "0x19CD190", VA = "0x1819CE790")]
	public void UpdateDistanceBands()
	{
		//Discarded unreachable code: IL_0066
		//IL_0045: Expected F4, but got I8
		if ((long)group != 0)
		{
			float[] array = new float[3];
			float num = firstBand;
			int length = array.Length;
			array[0] = num;
			float num2 = (array[0] = secondBand);
			array[1] = 2.139095E+09f;
			distanceBands = array;
			CullingGroup cullingGroup = group;
			float[] boundingDistances = distanceBands;
			cullingGroup.SetBoundingDistances(boundingDistances);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x19CE870", Offset = "0x19CD270", VA = "0x1819CE870")]
	public void Update()
	{
		//Discarded unreachable code: IL_00bc, IL_00c2, IL_00c8, IL_00ce, IL_00d4, IL_00da, IL_00e0
		//IL_0033: Expected O, but got I4
		//IL_0035: Expected I4, but got O
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I8, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected I8, but got Unknown
		int num = 0;
		int num2 = 0;
		float deltaTime = Time.deltaTime;
		PendingLoads pendingLoads = toLoad;
		int num3 = 0;
		IEnumerable<int> enumerable;
		if (pendingLoads.UpdateAndCheckForPending())
		{
			Func<float, int> loadLimitingMethod = LoadLimitingMethod;
			if (loadLimitingMethod != null)
			{
				int num4 = (int)loadLimitingMethod((T)num3);
				enumerable = (IEnumerable<int>)toLoad.Dequeue(num4);
				if (enumerable != null)
				{
					uint num5 = default(uint);
					if (num < (int)num5)
					{
						num += num;
						if (num == (int)num5)
						{
							goto IL_0063;
						}
						num++;
					}
					Cullable[] array = cullables;
					goto IL_0063;
				}
				goto IL_0087;
			}
		}
		goto IL_008c;
		IL_0087:
		if (enumerable == null)
		{
		}
		goto IL_008c;
		IL_008c:
		if (toRemoveCount > 0)
		{
			int num6 = 0;
			(int, float, float)[] array2 = toRemove;
			Cullable[] array3 = cullables;
			float lifetime = Lifetime;
			(int, float, float)[] array4 = toRemove;
			num++;
		}
		return;
		IL_0063:
		long num7 = enumerable * 56;
		Cullable[] array5 = cullables;
		long num8 = enumerable * 56;
		Cullable cullable = default(Cullable);
		array5[2] = cullable;
		goto IL_0087;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x19CD200", Offset = "0x19CBC00", VA = "0x1819CD200")]
	private int GetCurrentDistanceIndex(int index)
	{
		//Discarded unreachable code: IL_0037
		if (index < count)
		{
			float distanceMinusRadius = GetCurrentDistance(index);
			float[] array = distanceBands;
			Predicate<float> predicate = (Predicate<float>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			int result = default(int);
			return result;
		}
		return -1;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x19CDA60", Offset = "0x19CC460", VA = "0x1819CDA60")]
	private void OnAvatarTeleported(Vector3 position, PlayerAvatar.AvatarTeleportedReason reason)
	{
		//Discarded unreachable code: IL_006e
		if (reason != PlayerAvatar.AvatarTeleportedReason.PlayerInitialPosition && reason != 0)
		{
			return;
		}
		int num = 0;
		if (count <= num)
		{
			return;
		}
		if (num < count)
		{
			float distanceMinusRadius = GetCurrentDistance(num);
			float[] array = distanceBands;
			Predicate<float> predicate = (Predicate<float>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			Cullable[] array2 = cullables;
			long num2 = (long)num * 56L;
			float instantUnload = InstantUnload;
			int currentDistanceIndex = default(int);
			DoStateChange(num, currentDistanceIndex, isVisible: true, instantUnload);
		}
		num++;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x19CD030", Offset = "0x19CBA30", VA = "0x1819CD030")]
	private void ForceAllUpdateStateChange()
	{
		//Discarded unreachable code: IL_0066
		int num = 0;
		if (count <= num)
		{
			return;
		}
		if (num < count)
		{
			float distanceMinusRadius = GetCurrentDistance(num);
			float[] array = distanceBands;
			Predicate<float> predicate = (Predicate<float>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			Cullable[] array2 = cullables;
			long num2 = (long)num * 56L;
			float instantUnload = InstantUnload;
			int currentDistanceIndex = default(int);
			DoStateChange(num, currentDistanceIndex, isVisible: true, instantUnload);
		}
		num++;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x19CDF40", Offset = "0x19CC940", VA = "0x1819CDF40")]
	private void OnStateChange(CullingGroupEvent evt)
	{
		float lifetime = Lifetime;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x19CC620", Offset = "0x19CB020", VA = "0x1819CC620")]
	private void DoStateChange(int index, int currentDistanceIndex, bool isVisible, float unloadDelay)
	{
		//Discarded unreachable code: IL_017f
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected I8, but got Unknown
		SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
		int num = 0;
		if ((object)_003CInstance_003Ek__BackingField != null)
		{
			PlayerAvatar avatar = _003CInstance_003Ek__BackingField._avatar;
			if ((object)avatar != null)
			{
				bool flag = (avatar._isTeleportedAtInitialPosition ? 1 : 0) == num;
			}
		}
		if (num == 0 || num != 0)
		{
			return;
		}
		Cullable[] array = cullables;
		long num2 = (long)index * 56L;
		(int, float, float)[] array2 = toRemove;
		Predicate<(int, float, float)> predicate = (Predicate<(int, float, float)>)(object)(Predicate<T>)delegate
		{
			int num11 = index;
			bool result = default(bool);
			return result;
		};
		bool flag2 = default(bool);
		if (flag2)
		{
			int index2 = index;
			int num3 = 0;
			float currentDistance = GetCurrentDistance(index2);
			index2 = index;
			int num4 = 0;
		}
		PendingLoads pendingLoads = toLoad;
		int id = index;
		pendingLoads.Remove(id);
		if (!flag2)
		{
			PendingLoads pendingLoads2 = toLoad;
			int id2 = index;
			pendingLoads2.EnqueueUnique(id2);
		}
		PendingLoads pendingLoads3 = toLoad;
		int id3 = index;
		pendingLoads3.Remove(id3);
		if (!flag2)
		{
			Cullable[] array3 = cullables;
			long num5 = (long)index * 56L;
			num5 += array3;
		}
		Cullable[] array4 = cullables;
		long num6 = (long)index * 56L;
		Cullable[] array5 = cullables;
		long num7 = (long)index * 56L;
		if (GridObjectStreamingManager._instance.ActiveConfig.IsDistanceCullingCulledWithFrustum)
		{
			Cullable[] array6 = cullables;
			long num8 = (long)index * 56L;
			bool flag3 = default(bool);
			if (flag3)
			{
				Cullable[] array7 = cullables;
				long num9 = (long)index * 56L;
				Cullable[] array8 = cullables;
				long num10 = (long)index * 56L;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x19CB7A0", Offset = "0x19CA1A0", VA = "0x1819CB7A0")]
	public unsafe bool AddAsset(GridObject gridObject, GridScript gridScript, out AsyncOperationHandle<GameObject> loadedAsset)
	{
		//IL_00e0: Expected native int or pointer, but got O
		//IL_00f9: Expected O, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected I8, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		Cullable[] array = cullables;
		Predicate<Cullable> predicate = (Predicate<Cullable>)(object)(Predicate<T>)delegate
		{
			//Discarded unreachable code: IL_0010
			uint iD_ = gridObject.iD_;
			int num11 = 0;
			bool result = default(bool);
			return result;
		};
		GridScript gridScript2 = gridScript;
		int num = 0;
		int num2 = 0;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		int num3 = 0;
		int visible = 0;
		int num4 = 0;
		CullingGroup cullingGroup = group;
		BoundingSphere[] array2 = boundingSpheres;
		cullingGroup.SetBoundingSpheres(array2);
		CullingGroup cullingGroup2 = group;
		int boundingSphereCount = count;
		cullingGroup2.SetBoundingSphereCount(boundingSphereCount);
		Transform transform = targetCamera.transform;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
		SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
		if ((object)_003CInstance_003Ek__BackingField2 != null)
		{
			PlayerAvatar avatar = _003CInstance_003Ek__BackingField2._avatar;
			if ((object)avatar != null)
			{
				bool isTeleportedAtInitialPosition = avatar._isTeleportedAtInitialPosition;
				float num5 = default(float);
				if (!(firstBand <= num5))
				{
					Cullable[] array3 = cullables;
					long num6 = (long)count * 56L;
					((Cullable*)(IntPtr)array3)->visible = (byte)visible != 0;
					int num7 = 0;
					string text = "Attempted to add " + (string)num7 + " to distance culling but it was already registered";
					Debug.LogWarning(text);
					Cullable[] array4 = cullables;
					long num8 = text * 56;
					array4 = (Cullable[])(array4 + num8);
					bool flag = default(bool);
					if (flag)
					{
						goto IL_012a;
					}
				}
			}
		}
		int num9 = 0;
		System.Runtime.CompilerServices.Unsafe.As<AsyncOperationHandle<GameObject>, AsyncOperationHandle<>>(ref loadedAsset).m_InternalOp = (AsyncOperationBase<TObject>)num9;
		goto IL_012a;
		IL_012a:
		Cullable[] array5 = cullables;
		long num10 = (long)num2 * 56L;
		Cullable internalOp = default(Cullable);
		System.Runtime.CompilerServices.Unsafe.As<AsyncOperationHandle<GameObject>, AsyncOperationHandle<>>(ref loadedAsset).m_InternalOp = (AsyncOperationBase<TObject>)internalOp;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x19CBE80", Offset = "0x19CA880", VA = "0x1819CBE80")]
	public void AddLoadedAsset(AsyncOperationHandle<GameObject> loadedAsset, GridObjectScript gridObjectScript, GridScript gridScript)
	{
		//Discarded unreachable code: IL_00cb
		//IL_00c8: Invalid comparison between F4 and I4
		Cullable[] array = cullables;
		Predicate<Cullable> predicate = (Predicate<Cullable>)(object)(Predicate<T>)delegate
		{
			//Discarded unreachable code: IL_0015
			uint iD_ = gridObjectScript.GridObject.iD_;
			int num4 = 0;
			bool result = default(bool);
			return result;
		};
		GridObjectScript gridObjectScript2 = gridObjectScript;
		GameObject gameObject = default(GameObject);
		string name = gameObject.name;
		Debug.LogWarning("Attempted to add " + name + " to distance culling but it was already registered");
		Transform transform = gridObjectScript.transform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
		int num = 0;
		int num2 = 0;
		CullingGroup cullingGroup = group;
		BoundingSphere[] array2 = boundingSpheres;
		cullingGroup.SetBoundingSpheres(array2);
		CullingGroup cullingGroup2 = group;
		int boundingSphereCount = count;
		cullingGroup2.SetBoundingSphereCount(boundingSphereCount);
		Transform transform2 = targetCamera.transform;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		float num3 = default(float);
		if (num3 <= (float)(NoForceLoad ? 1 : 0))
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x19CE010", Offset = "0x19CCA10", VA = "0x1819CE010")]
	public bool RemoveAsset(GridObject gridObject, GridScript gridScript, out AsyncOperationHandle<GameObject> loadedAsset)
	{
		//IL_0063: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_0124: Expected O, but got I4
		_003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass51_0();
		CS_0024_003C_003E8__locals0.gridObject = gridObject;
		CS_0024_003C_003E8__locals0.gridScript = gridScript;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		Cullable[] array = cullables;
		Predicate<Cullable> predicate = (Predicate<Cullable>)(object)(Predicate<T>)delegate
		{
			//Discarded unreachable code: IL_0010
			uint iD_ = CS_0024_003C_003E8__locals0.gridObject.iD_;
			int num8 = 0;
			bool result3 = default(bool);
			return result3;
		};
		int index = default(int);
		CS_0024_003C_003E8__locals0.index = index;
		GridObject gridObject2 = CS_0024_003C_003E8__locals0.gridObject;
		if (gridObject2 != null)
		{
			string text = gridObject2.ToString();
		}
		int num = 0;
		int num2 = 0;
		Debug.LogWarning("Asset " + (string)num + " was not found in distanceCulling");
		int num3 = 0;
		int num4 = 0;
		System.Runtime.CompilerServices.Unsafe.As<AsyncOperationHandle<GameObject>, AsyncOperationHandle<>>(ref loadedAsset).m_InternalOp = (AsyncOperationBase<TObject>)num3;
		Cullable[] array2 = cullables;
		long num5 = (long)num2 * 56L;
		CullingGroup cullingGroup = group;
		int boundingSphereCount = count;
		cullingGroup.SetBoundingSphereCount(boundingSphereCount);
		PendingLoads pendingLoads = toLoad;
		int index2 = CS_0024_003C_003E8__locals0.index;
		pendingLoads.Remove(index2);
		(int, float, float)[] array3 = toRemove;
		Predicate<(int, float, float)> predicate2 = (Predicate<(int, float, float)>)(object)(Predicate<T>)delegate
		{
			int index5 = CS_0024_003C_003E8__locals0.index;
			bool result2 = default(bool);
			return result2;
		};
		int index3 = CS_0024_003C_003E8__locals0.index;
		int num6 = count;
		if (index3 != num6)
		{
			toLoad.UpdateID(num6, index3);
		}
		(int, float, float)[] array4 = toRemove;
		Predicate<(int, float, float)> predicate3 = (Predicate<(int, float, float)>)(object)(Predicate<T>)delegate
		{
			//Discarded unreachable code: IL_000e
			int num7 = CS_0024_003C_003E8__locals0._003C_003E4__this.count;
			bool result = default(bool);
			return result;
		};
		(int, float, float)[] array5 = toRemove;
		int index4 = CS_0024_003C_003E8__locals0.index;
		((ValueTuple<, , >[])(object)array5)[0] = (ValueTuple<, , >)index4;
		Cullable internalOp = default(Cullable);
		System.Runtime.CompilerServices.Unsafe.As<AsyncOperationHandle<GameObject>, AsyncOperationHandle<>>(ref loadedAsset).m_InternalOp = (AsyncOperationBase<TObject>)internalOp;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x19CD310", Offset = "0x19CBD10", VA = "0x1819CD310")]
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

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1650000", Offset = "0x164EA00", VA = "0x181650000")]
	private void AddToBack<T>(ref T[] array, ref int count, T element)
	{
		//Discarded unreachable code: IL_0008
		count.m_value = 0;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1650310", Offset = "0x164ED10", VA = "0x181650310")]
	private void EraseSwapBack<T>(ref T[] array, ref int count, int index)
	{
		//Discarded unreachable code: IL_0003
		int num = 0;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x19CD400", Offset = "0x19CBE00", VA = "0x1819CD400")]
	public static string GetPrettyPrefabAddress(IItemData itemData)
	{
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x19CD4E0", Offset = "0x19CBEE0", VA = "0x1819CD4E0")]
	private AsyncOperationHandle<GameObject> LoadAsset(GridObject gridObject, GridScript gridScript)
	{
		//IL_0009: Expected F4, but got I4
		int num = 0;
		firstBand = num;
		GridObject gridObject2 = (GridObject)(object)gridScript;
		DistanceCulling distanceCulling = (DistanceCulling)(object)gridObject;
		GridObject gridObject3 = gridObject2;
		ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
		int itemID = gridObject3.ItemID;
		GridObject gridObject4 = gridObject2;
		GridScript gridScript2 = default(GridScript);
		GridScript gridScript3 = gridScript2;
		GridObject gridObject5 = gridObject2;
		GridScript gridScript4 = gridScript2;
		GridPosition position = gridObject5.Position;
		GridOrientation orientation_ = gridObject2.orientation_;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Transform transform = gridScript2.transform;
		bool flag = default(bool);
		if (!flag)
		{
			Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnCompleted);
		}
		float num2 = firstBand;
		throw new NullReferenceException();
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1392A40", Offset = "0x1391440", VA = "0x181392A40")]
		unsafe void OnCompleted(AsyncOperationHandle<GameObject> handle)
		{
			//Discarded unreachable code: IL_0049
			GridObjectScript component = ((GameObject)((AsyncOperationHandle<TObject>*)handle)->Result).GetComponent<GridObjectScript>();
			GridObject gridObject6 = gridObject2;
			int editModeResynchronize = 0;
			GridScript gridScript5 = gridScript2;
			component.Init(gridScript5, gridObject6, (byte)editModeResynchronize != 0);
			GridScript gridScript6 = gridScript2;
			DistanceCulling sender = distanceCulling;
			GameObject result = (GameObject)((AsyncOperationHandle<TObject>*)handle)->Result;
			NewGridObjectEventArgs e = default(NewGridObjectEventArgs);
			gridScript6.Sector_NewGridObjectLoadedEvent(sender, e);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x19CDC50", Offset = "0x19CC650", VA = "0x1819CDC50")]
	private void OnDrawGizmosSelected()
	{
		//Discarded unreachable code: IL_00d4
		if ((long)group != 0)
		{
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
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x19CE650", Offset = "0x19CD050", VA = "0x1819CE650")]
	public DebugStats UpdateDebugStats()
	{
		//IL_000b: Expected F4, but got I4
		//IL_0016: Expected F4, but got I4
		//IL_001d: Expected F4, but got I4
		//IL_0024: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		firstBand = num;
		int num3 = 0;
		int num4 = 0;
		firstBand = num2;
		secondBand = num2;
		distanceBands = (float[])num2;
		if ((long)(IntPtr)"{il2cpp array field il2cppMethodInfo->}" > (long)num4)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || !flag2)
			{
			}
			num4++;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x19CD4A0", Offset = "0x19CBEA0", VA = "0x1819CD4A0")]
	private int LimitStartLoadsPerSecond(float dt)
	{
		timeSpent = dt;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x19CD450", Offset = "0x19CBE50", VA = "0x1819CD450")]
	private int LimitConcurrentLoads(float _)
	{
		//Discarded unreachable code: IL_000d
		StreamingStateInfo instance = StreamingStateInfo.Instance;
		return currentMaxConcurrentLoads;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x19CEDA0", Offset = "0x19CD7A0", VA = "0x1819CEDA0")]
	static DistanceCulling()
	{
		//IL_0008: Expected F4, but got I4
		//IL_0037: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_00bf: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00fc: Expected O, but got I
		int num = 0;
		InstantUnload = num;
		NoForceLoad = (byte)num != 0;
		Limiter = (StreamingManagerConfig.StreamingLimitMethod)num;
		int num2 = 0;
		int flags = 0;
		int metadataCount = 0;
		ushort categoryId = default(ushort);
		IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("DistUpdateCheckPending", categoryId, (MarkerFlags)flags, metadataCount);
		int num3 = 0;
		s_markerCheckPending = (ProfilerMarker)(long)intPtr;
		int flags2 = 0;
		int metadataCount2 = 0;
		ushort categoryId2 = default(ushort);
		IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker("DistUpdateLoad", categoryId2, (MarkerFlags)flags2, metadataCount2);
		int num4 = 0;
		s_markerUpdateLoad = (ProfilerMarker)(long)intPtr2;
		int flags3 = 0;
		int metadataCount3 = 0;
		ushort categoryId3 = default(ushort);
		IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker("DistGetLimit", categoryId3, (MarkerFlags)flags3, metadataCount3);
		int num5 = 0;
		s_markerGetLimitCount = (ProfilerMarker)(long)intPtr3;
		int flags4 = 0;
		int metadataCount4 = 0;
		ushort categoryId4 = default(ushort);
		IntPtr intPtr4 = ProfilerUnsafeUtility.CreateMarker("DistActualLoad", categoryId4, (MarkerFlags)flags4, metadataCount4);
		int num6 = 0;
		s_markerUpdateLoadCullable = (ProfilerMarker)(long)intPtr4;
		int flags5 = 0;
		int metadataCount5 = 0;
		ushort categoryId5 = default(ushort);
		IntPtr intPtr5 = ProfilerUnsafeUtility.CreateMarker("DistUpdateUnload", categoryId5, (MarkerFlags)flags5, metadataCount5);
		int num7 = 0;
		s_markerUpdateUnload = (ProfilerMarker)(long)intPtr5;
		int flags6 = 0;
		int metadataCount6 = 0;
		ushort categoryId6 = default(ushort);
		IntPtr intPtr6 = ProfilerUnsafeUtility.CreateMarker("DistForceLoad", categoryId6, (MarkerFlags)flags6, metadataCount6);
		int num8 = 0;
		s_markerForceLoad = (ProfilerMarker)(long)intPtr6;
		int flags7 = 0;
		int metadataCount7 = 0;
		ushort categoryId7 = default(ushort);
		s_markerLoadPriority = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("DistLoadPriority", categoryId7, (MarkerFlags)flags7, metadataCount7);
	}
}
