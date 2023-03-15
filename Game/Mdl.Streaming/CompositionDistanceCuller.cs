using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x20007F4")]
	public class CompositionDistanceCuller : MonoBehaviour, ICullable
	{
		[Cpp2IlInjected.Token(Token = "0x20007F5")]
		public enum ForceVisibilityType
		{
			[Cpp2IlInjected.Token(Token = "0x4002C76")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002C77")]
			ForceVisible,
			[Cpp2IlInjected.Token(Token = "0x4002C78")]
			ForceNotVisible
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002C63")]
		public Transform RefPointTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C64")]
		public StreamableAssetRefType AssetType = StreamableAssetRefType.SceneVillage04;

		[Cpp2IlInjected.Token(Token = "0x4002C65")]
		private static bool isCullingWithVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C66")]
		private Bounds bounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002C68")]
		[SerializeField]
		private AssetReferenceGameObject LowResModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002C69")]
		[SerializeField]
		private bool LowResModelInstWorldSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002C6A")]
		private AsyncOperationHandle<GameObject> LowResModelHandle;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002C6B")]
		public ForceVisibilityType UserVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002C6D")]
		private MeshRenderer[] _renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002C6E")]
		private LODGroup[] _lodgroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002C6F")]
		private int _renderersOwnedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4002C70")]
		private int _lodgroupsOwnedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002C71")]
		private bool _isInCulingGroupMgr;

		[Cpp2IlInjected.Token(Token = "0x4002C72")]
		public static bool IsVerboseDebug;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4002C73")]
		private int _lastDistanceIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002C74")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x170004EA")]
		public StreamableAssetRefType CullableAssetType
		{
			[Cpp2IlInjected.Token(Token = "0x600234D")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "16")]
			get
			{
				return AssetType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EB")]
		public static bool IsCullingWithVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x600234E")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF40", Offset = "0xA8C940", VA = "0x180A8DF40")]
			get
			{
				return isCullingWithVisibility;
			}
			[Cpp2IlInjected.Token(Token = "0x600234F")]
			[Cpp2IlInjected.Address(RVA = "0xA8E110", Offset = "0xA8CB10", VA = "0x180A8E110")]
			set
			{
				isCullingWithVisibility = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EC")]
		public Vector3 RefPointFromBounds
		{
			[Cpp2IlInjected.Token(Token = "0x6002350")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0B0", Offset = "0xA8CAB0", VA = "0x180A8E0B0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004ED")]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x6002351")]
			[Cpp2IlInjected.Address(RVA = "0xA8DEE0", Offset = "0xA8C8E0", VA = "0x180A8DEE0")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EE")]
		public float CullableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6002352")]
			[Cpp2IlInjected.Address(RVA = "0xA8DDB0", Offset = "0xA8C7B0", VA = "0x180A8DDB0", Slot = "15")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EF")]
		public CullingGroupStreamingManager GridObjectStreamingMgr
		{
			[Cpp2IlInjected.Token(Token = "0x6002353")]
			[Cpp2IlInjected.Address(RVA = "0xA8DE20", Offset = "0xA8C820", VA = "0x180A8DE20")]
			get
			{
				if ((object)GridObjectStreamingManager._instance != null)
				{
					StreamableAssetRefType assetType = AssetType;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					CullingGroupStreamingManager result = default(CullingGroupStreamingManager);
					return result;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F0")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6002354")]
			[Cpp2IlInjected.Address(RVA = "0xA8E000", Offset = "0xA8CA00", VA = "0x180A8E000")]
			get
			{
				if (IsLoadedByCullingGroupMgr && UserVisibility == ForceVisibilityType.None && visible)
				{
					return true;
				}
				return UserVisibility == ForceVisibilityType.ForceVisible;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4002C67")]
		public bool IsLoadedByCullingGroupMgr
		{
			[Cpp2IlInjected.Token(Token = "0x6002355")]
			[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002356")]
			[Cpp2IlInjected.Address(RVA = "0xA15800", Offset = "0xA14200", VA = "0x180A15800")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004F2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x74"), Cpp2IlInjected.Token(Token = "0x4002C6C")]
		public bool CurrentVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x6002357")]
			[Cpp2IlInjected.Address(RVA = "0xA8DE10", Offset = "0xA8C810", VA = "0x180A8DE10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002358")]
			[Cpp2IlInjected.Address(RVA = "0xA8E100", Offset = "0xA8CB00", VA = "0x180A8E100")]
			private set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x170004F3")]
		public int NumRenderers
		{
			[Cpp2IlInjected.Token(Token = "0x6002359")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return _renderersOwnedCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F4")]
		public int NumLODGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600235A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8CAA0", VA = "0x180A8E0A0")]
			get
			{
				return _lodgroupsOwnedCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F5")]
		public static bool IsUsingCompositionDistanceCulling
		{
			[Cpp2IlInjected.Token(Token = "0x600235B")]
			[Cpp2IlInjected.Address(RVA = "0xA8DFA0", Offset = "0xA8C9A0", VA = "0x180A8DFA0")]
			get
			{
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					return instance.ActiveConfig.IsUsingCompositionDistanceCulling;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F6")]
		public bool IsInCulingGroupMgr
		{
			[Cpp2IlInjected.Token(Token = "0x600235C")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEA0", Offset = "0x7D98A0", VA = "0x1807DAEA0")]
			get
			{
				return _isInCulingGroupMgr;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F7")]
		public int LastDistanceIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6002366")]
			[Cpp2IlInjected.Address(RVA = "0xA8E090", Offset = "0xA8CA90", VA = "0x180A8E090", Slot = "7")]
			get
			{
				return _lastDistanceIndex;
			}
			[Cpp2IlInjected.Token(Token = "0x6002367")]
			[Cpp2IlInjected.Address(RVA = "0xA8E170", Offset = "0xA8CB70", VA = "0x180A8E170", Slot = "8")]
			set
			{
				_lastDistanceIndex = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F8")]
		public bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x6002368")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0F0", Offset = "0xA8CAF0", VA = "0x180A8E0F0", Slot = "5")]
			get
			{
				return visible;
			}
			[Cpp2IlInjected.Token(Token = "0x6002369")]
			[Cpp2IlInjected.Address(RVA = "0xA8E180", Offset = "0xA8CB80", VA = "0x180A8E180", Slot = "6")]
			set
			{
				visible = value;
				UpdateVisibility();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F9")]
		public bool IsHandleValid
		{
			[Cpp2IlInjected.Token(Token = "0x600236C")]
			[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0", Slot = "9")]
			get
			{
				return IsLoadedByCullingGroupMgr;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FA")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600236D")]
			[Cpp2IlInjected.Address(RVA = "0xA8DE10", Offset = "0xA8C810", VA = "0x180A8DE10", Slot = "10")]
			get
			{
				return CurrentVisibility;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600235D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D5A0", Offset = "0xA8BFA0", VA = "0x180A8D5A0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0062
			//IL_0028: Expected O, but got I4
			GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
			if ((object)instance != null && instance.ActiveConfig.IsUsingCompositionDistanceCulling)
			{
				CullingGroupStreamingManager gridObjectStreamingMgr = GridObjectStreamingMgr;
				int num = 0;
				if (!(gridObjectStreamingMgr == (UnityEngine.Object)num))
				{
					int includeInactive = 0;
					MeshRenderer[] array = (_renderers = GetComponentsInChildren<MeshRenderer>((byte)includeInactive != 0));
					int includeInactive2 = 0;
					LODGroup[] array2 = (_lodgroups = GetComponentsInChildren<LODGroup>((byte)includeInactive2 != 0));
					bool flag = GridObjectStreamingMgr.AddAsset(this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600235E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D200", Offset = "0xA8BC00", VA = "0x180A8D200")]
		private void OnDestroy()
		{
			UnloadLowResModel();
			if (_isInCulingGroupMgr)
			{
				UnloadLowResModel();
				CullingGroupStreamingManager gridObjectStreamingMgr = GridObjectStreamingMgr;
				if ((object)gridObjectStreamingMgr != null)
				{
					bool flag = gridObjectStreamingMgr.RemoveAsset(this);
				}
				_isInCulingGroupMgr = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600235F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D550", Offset = "0xA8BF50", VA = "0x180A8D550")]
		private void RemoveFromCullingGroupMgr()
		{
			if (_isInCulingGroupMgr)
			{
				UnloadLowResModel();
				CullingGroupStreamingManager gridObjectStreamingMgr = GridObjectStreamingMgr;
				if ((object)gridObjectStreamingMgr != null)
				{
					bool flag = gridObjectStreamingMgr.RemoveAsset(this);
				}
				_isInCulingGroupMgr = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002360")]
		[Cpp2IlInjected.Address(RVA = "0xA8DBB0", Offset = "0xA8C5B0", VA = "0x180A8DBB0")]
		public void UpdateVisibility()
		{
			//Discarded unreachable code: IL_009c
			//IL_0048: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			bool flag = CurrentVisibility;
			bool isVisible = IsVisible;
			if (flag == isVisible)
			{
				return;
			}
			bool isVisible2 = IsVisible;
			int num = 0;
			CurrentVisibility = isVisible2;
			if (_renderersOwnedCount > num)
			{
				MeshRenderer meshRenderer = _renderers[num];
				int num2 = 0;
				if (meshRenderer != (UnityEngine.Object)num2)
				{
					bool flag3 = (meshRenderer.enabled = CurrentVisibility);
				}
				num++;
			}
			if (_lodgroupsOwnedCount > num)
			{
				LODGroup lODGroup = _lodgroups[num];
				int num3 = 0;
				if (lODGroup != (UnityEngine.Object)num3)
				{
					bool flag5 = (lODGroup.enabled = CurrentVisibility);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002361")]
		[Cpp2IlInjected.Address(RVA = "0xA8CF70", Offset = "0xA8B970", VA = "0x180A8CF70")]
		private void LoadLowResModel()
		{
			//Discarded unreachable code: IL_0059
			bool flag = default(bool);
			if (LowResModel.RuntimeKeyIsValid() && !flag)
			{
				GameObject arg = base.gameObject;
				string assetGUID = LowResModel.AssetGUID;
				Debug.Log($"[cdc] LoadLowResModel({arg} : {assetGUID}) InstantiateAsync called");
				string assetGUID2 = LowResModel.AssetGUID;
				Transform transform = base.transform;
				Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnLowResModelInstantiateCompleted);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002362")]
		[Cpp2IlInjected.Address(RVA = "0xA8D450", Offset = "0xA8BE50", VA = "0x180A8D450")]
		private void OnLowResModelInstantiateCompleted(AsyncOperationHandle<GameObject> obj)
		{
			//Discarded unreachable code: IL_0034
			GameObject arg = base.gameObject;
			string assetGUID = LowResModel.AssetGUID;
			Debug.Log($"[cdc] LoadLowResModel({arg} : {assetGUID}) OnLowResModelInstantiateCompleted");
			if (IsLoadedByCullingGroupMgr)
			{
				UnloadLowResModel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002363")]
		[Cpp2IlInjected.Address(RVA = "0xA8D800", Offset = "0xA8C200", VA = "0x180A8D800")]
		private void UnloadLowResModel()
		{
			//Discarded unreachable code: IL_0052
			//IL_0049: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (LowResModel.RuntimeKeyIsValid() && flag && flag2)
			{
				GameObject arg = base.gameObject;
				string assetGUID = LowResModel.AssetGUID;
				Debug.Log($"[cdc] UnloadLowResModel({arg} : {assetGUID}) ReleaseInstance called with result {assetGUID}");
				int num = 0;
				LowResModelHandle = (AsyncOperationHandle<GameObject>)num;
				LowResModelHandle = (AsyncOperationHandle<GameObject>)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002364")]
		[Cpp2IlInjected.Address(RVA = "0xA8DA60", Offset = "0xA8C460", VA = "0x180A8DA60")]
		public void UpdateCache()
		{
			int includeInactive = 0;
			MeshRenderer[] array = (_renderers = GetComponentsInChildren<MeshRenderer>((byte)includeInactive != 0));
			int includeInactive2 = 0;
			LODGroup[] array2 = (_lodgroups = GetComponentsInChildren<LODGroup>((byte)includeInactive2 != 0));
		}

		[Cpp2IlInjected.Token(Token = "0x6002365")]
		[Cpp2IlInjected.Address(RVA = "0xA8C940", Offset = "0xA8B340", VA = "0x180A8C940", Slot = "4")]
		public string GetDebugName()
		{
			//Discarded unreachable code: IL_0018
			string text = base.gameObject.name;
			return "sar:" + text;
		}

		[Cpp2IlInjected.Token(Token = "0x600236A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D1D0", Offset = "0xA8BBD0", VA = "0x180A8D1D0", Slot = "11")]
		public void Load()
		{
			IsLoadedByCullingGroupMgr = true;
			UpdateVisibility();
			UnloadLowResModel();
		}

		[Cpp2IlInjected.Token(Token = "0x600236B")]
		[Cpp2IlInjected.Address(RVA = "0xA8DA20", Offset = "0xA8C420", VA = "0x180A8DA20", Slot = "12")]
		public void Unload(bool fromDisable)
		{
			IsLoadedByCullingGroupMgr = false;
			UpdateVisibility();
			if (!fromDisable)
			{
				LoadLowResModel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600236E")]
		[Cpp2IlInjected.Address(RVA = "0xA8CEB0", Offset = "0xA8B8B0", VA = "0x180A8CEB0", Slot = "13")]
		public Vector3 GetWorldPosition()
		{
			bool flag = default(bool);
			if (flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600236F")]
		[Cpp2IlInjected.Address(RVA = "0xA8C9A0", Offset = "0xA8B3A0", VA = "0x180A8C9A0", Slot = "14")]
		public float GetRadius()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float num = default(float);
			z = num;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002370")]
		[Cpp2IlInjected.Address(RVA = "0xA8C800", Offset = "0xA8B200", VA = "0x180A8C800")]
		public float GetCurrentDistance()
		{
			//IL_001e: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			int num = 0;
			if (Application.isPlaying)
			{
				if ((object)GridObjectStreamingMgr != null)
				{
				}
				int num2 = 0;
				int num3 = 0;
				if (!((UnityEngine.Object)num2 == (UnityEngine.Object)num3))
				{
					Transform transform = GridObjectStreamingMgr.targetCamera.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					float result = default(float);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002371")]
		[Cpp2IlInjected.Address(RVA = "0xA8D250", Offset = "0xA8BC50", VA = "0x180A8D250")]
		private void OnDrawGizmosSelected()
		{
			Color blue = Color.blue;
			Vector3 worldPosition = GetWorldPosition();
			Color yellow = Color.yellow;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002372")]
		[Cpp2IlInjected.Address(RVA = "0xA8CAB0", Offset = "0xA8B4B0", VA = "0x180A8CAB0")]
		public static Bounds GetRenderersBounds(Renderer[] renderers, int count)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (num > 0)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				Vector3 vector5 = default(Vector3);
				float z5 = vector5.z;
				Vector3 vector6 = default(Vector3);
				float z6 = vector6.z;
				num3++;
			}
			int num4 = 0;
			int num5 = 0;
			((UnityEngine.Object)(object)renderers).m_CachedPtr = (IntPtr)num5;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002373")]
		[Cpp2IlInjected.Address(RVA = "0x16CD3C0", Offset = "0x16CBDC0", VA = "0x1816CD3C0")]
		private void RemoveNonNearestChildren<T>(ref T[] array, ref int count)
		{
			//Discarded unreachable code: IL_0021
			int num = 0;
			Type t = default(Type);
			Component componentInParent = GetComponentInParent(t);
			if ((object)componentInParent == null)
			{
			}
			if ((object)componentInParent != null)
			{
				if (!(componentInParent != this))
				{
					num++;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002374")]
		[Cpp2IlInjected.Address(RVA = "0x16CD310", Offset = "0x16CBD10", VA = "0x1816CD310")]
		public static void EraseSwapBack<T>(ref T[] array, ref int count, int index)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002375")]
		[Cpp2IlInjected.Address(RVA = "0xA8DD90", Offset = "0xA8C790", VA = "0x180A8DD90")]
		public CompositionDistanceCuller()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0020: Expected I4, but got I8

	}
}
