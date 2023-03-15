using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Grid;
using Mdl.Platform;
using Mdl.Utils;
using Unity.Services.Core.Internal;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x200080B")]
	[ExecuteInEditMode]
	public class StreamableAssetRef : MonoBehaviour, ICullable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002CD5")]
		[NotNull]
		public AssetReferenceGameObject AssetRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002CD6")]
		public Transform prefabInstanceTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002CD7")]
		public Transform StreamingRefPointTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002CD8")]
		public TransformData transformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002CD9")]
		public Material prefabInstanceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002CDA")]
		public int layer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002CDB")]
		public bool IsAlwaysLoaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002CDC")]
		public StreamableAssetRefType AssetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002CDD")]
		private AsyncOperationHandle<GameObject> loadedAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002CE0")]
		private TaskCompletionSource<bool> _waitForLoading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002CE1")]
		public float Height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4002CE2")]
		private bool IsInStreamingMgr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002CE3")]
		private IStreamableAssetRefToLoadProvider _visualAssetToLoadProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002CE4")]
		private GridObjectScript _gridObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002CE5")]
		public object LoadedObjectKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002CE6")]
		private int _lastDistanceIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002CE7")]
		public bool visible;

		[Cpp2IlInjected.Token(Token = "0x17000513")]
		public StreamableAssetRefType CullableAssetType
		{
			[Cpp2IlInjected.Token(Token = "0x60023FC")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "16")]
			get
			{
				return AssetType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000514")]
		public bool IsRefValid
		{
			[Cpp2IlInjected.Token(Token = "0x6002401")]
			[Cpp2IlInjected.Address(RVA = "0x1062E90", Offset = "0x1061890", VA = "0x181062E90")]
			get
			{
				Unity.Services.Core.Internal.DependencyTree tree = ((Unity.Services.Core.Internal.IPackageRegistry)AssetRef).Tree;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000515")]
		public bool IsHandleValid
		{
			[Cpp2IlInjected.Token(Token = "0x6002402")]
			[Cpp2IlInjected.Address(RVA = "0x1062CB0", Offset = "0x10616B0", VA = "0x181062CB0", Slot = "9")]
			get
			{
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000516")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6002403")]
			[Cpp2IlInjected.Address(RVA = "0x1062CF0", Offset = "0x10616F0", VA = "0x181062CF0", Slot = "10")]
			get
			{
				bool flag = default(bool);
				if (!flag)
				{
					return flag;
				}
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000517")]
		public Task WaitForLoading
		{
			[Cpp2IlInjected.Token(Token = "0x6002404")]
			[Cpp2IlInjected.Address(RVA = "0x1062FD0", Offset = "0x10619D0", VA = "0x181062FD0")]
			get
			{
				//Discarded unreachable code: IL_0038
				if (!IsLoaded)
				{
					TaskCompletionSource<bool> waitForLoading = _waitForLoading;
					if (waitForLoading == null)
					{
						TaskCompletionSource<bool> taskCompletionSource = (_waitForLoading = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
						TaskCompletionSource<bool> waitForLoading2 = _waitForLoading;
					}
					Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)waitForLoading).m_task;
				}
				int num = 0;
				return Task.CompletedTask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000518")]
		private bool DebugLoadAll
		{
			[Cpp2IlInjected.Token(Token = "0x6002405")]
			[Cpp2IlInjected.Address(RVA = "0x1062BF0", Offset = "0x10615F0", VA = "0x181062BF0")]
			get
			{
				int num = 0;
				return !GridObjectStreamingManager.HasGridObjectStreamingActive;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000519")]
		public float CullableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6002406")]
			[Cpp2IlInjected.Address(RVA = "0x1062BE0", Offset = "0x10615E0", VA = "0x181062BE0", Slot = "15")]
			get
			{
				return Height;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051A")]
		public CullingGroupStreamingManager GridObjectStreamingMgr
		{
			[Cpp2IlInjected.Token(Token = "0x6002408")]
			[Cpp2IlInjected.Address(RVA = "0x1062C10", Offset = "0x1061610", VA = "0x181062C10")]
			get
			{
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					float height = Height;
					StreamableAssetRefType assetType = AssetType;
					return instance.GetCullingGroupManager(assetType, height);
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051B")]
		private StreamingStateInfo StreamingStateInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6002409")]
			[Cpp2IlInjected.Address(RVA = "0x1062F80", Offset = "0x1061980", VA = "0x181062F80")]
			get
			{
				return StreamingStateInfo.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051C")]
		public bool IsStreaming
		{
			[Cpp2IlInjected.Token(Token = "0x600240A")]
			[Cpp2IlInjected.Address(RVA = "0xEFF390", Offset = "0xEFDD90", VA = "0x180EFF390")]
			get
			{
				return IsInStreamingMgr;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051D")]
		private GridScript GridScript
		{
			[Cpp2IlInjected.Token(Token = "0x600240B")]
			[Cpp2IlInjected.Address(RVA = "0x1062C70", Offset = "0x1061670", VA = "0x181062C70")]
			get
			{
				GridObjectScript gridObj;
				do
				{
					gridObj = _gridObj;
				}
				while ((object)gridObj == null);
				return gridObj.GridScript;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051E")]
		public bool IsNonGridObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600240C")]
			[Cpp2IlInjected.Address(RVA = "0x1062E20", Offset = "0x1061820", VA = "0x181062E20")]
			get
			{
				//IL_0014: Expected O, but got I4
				//IL_0014: Expected O, but got I4
				if ((object)_gridObj != null)
				{
				}
				int num = 0;
				int num2 = 0;
				return (UnityEngine.Object)num == (UnityEngine.Object)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051F")]
		public bool IsStreamingNonGridObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600240D")]
			[Cpp2IlInjected.Address(RVA = "0x1062F20", Offset = "0x1061920", VA = "0x181062F20")]
			get
			{
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					return instance.ActiveConfig.IsStreamingNonGridObject;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000520")]
		public bool IsStreamingLevelComplexityObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600240E")]
			[Cpp2IlInjected.Address(RVA = "0x1062EC0", Offset = "0x10618C0", VA = "0x181062EC0")]
			get
			{
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					return instance.ActiveConfig.IsStreamingLevelComplexity;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000521")]
		public bool IsNonGridObjectsAndStreaming
		{
			[Cpp2IlInjected.Token(Token = "0x600240F")]
			[Cpp2IlInjected.Address(RVA = "0x1062D60", Offset = "0x1061760", VA = "0x181062D60")]
			get
			{
				//IL_0014: Expected O, but got I4
				//IL_0014: Expected O, but got I4
				if ((object)_gridObj != null)
				{
				}
				int num = 0;
				int num2 = 0;
				if ((UnityEngine.Object)num == (UnityEngine.Object)num2)
				{
					GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
					if ((object)instance != null)
					{
						return instance.ActiveConfig.IsStreamingNonGridObject;
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000522")]
		public bool HasStreamingInParentGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6002410")]
			[Cpp2IlInjected.Address(RVA = "0x1062C90", Offset = "0x1061690", VA = "0x181062C90")]
			get
			{
				GridObjectScript gridObj = _gridObj;
				if ((object)gridObj != null)
				{
					GridScript _003CGridScript_003Ek__BackingField = gridObj.GridScript;
					if ((object)_003CGridScript_003Ek__BackingField != null)
					{
						return _003CGridScript_003Ek__BackingField.HasAssetRefStreaming;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000523")]
		public int LastDistanceIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6002420")]
			[Cpp2IlInjected.Address(RVA = "0x9D1840", Offset = "0x9D0240", VA = "0x1809D1840", Slot = "7")]
			get
			{
				return _lastDistanceIndex;
			}
			[Cpp2IlInjected.Token(Token = "0x6002421")]
			[Cpp2IlInjected.Address(RVA = "0xF64F60", Offset = "0xF63960", VA = "0x180F64F60", Slot = "8")]
			set
			{
				_lastDistanceIndex = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000524")]
		public bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x6002422")]
			[Cpp2IlInjected.Address(RVA = "0x1062FC0", Offset = "0x10619C0", VA = "0x181062FC0", Slot = "5")]
			get
			{
				return visible;
			}
			[Cpp2IlInjected.Token(Token = "0x6002423")]
			[Cpp2IlInjected.Address(RVA = "0x1063200", Offset = "0x1061C00", VA = "0x181063200", Slot = "6")]
			set
			{
				//Discarded unreachable code: IL_0031
				visible = value;
				if (GridObjectStreamingManager._instance.ActiveConfig.IsStreamableCulledWithFrustum && IsLoaded)
				{
					bool active = visible;
					GameObject gameObject = default(GameObject);
					gameObject.SetActive(active);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000050")]
		public event Action<AsyncOperationHandle<GameObject>> OnLoadedAssetChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60023FD")]
			[Cpp2IlInjected.Address(RVA = "0x1062AA0", Offset = "0x10614A0", VA = "0x181062AA0")]
			[CompilerGenerated]
			add
			{
				Action<AsyncOperationHandle<GameObject>> onLoadedAssetChanged = this.OnLoadedAssetChanged;
				Delegate @delegate = Delegate.Combine(onLoadedAssetChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLoadedAssetChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60023FE")]
			[Cpp2IlInjected.Address(RVA = "0x10630C0", Offset = "0x1061AC0", VA = "0x1810630C0")]
			[CompilerGenerated]
			remove
			{
				Action<AsyncOperationHandle<GameObject>> onLoadedAssetChanged = this.OnLoadedAssetChanged;
				Delegate @delegate = Delegate.Remove(onLoadedAssetChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLoadedAssetChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000051")]
		public event Action<AsyncOperationHandle<GameObject>> OnLoadedAssetLoadComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60023FF")]
			[Cpp2IlInjected.Address(RVA = "0x1062B40", Offset = "0x1061540", VA = "0x181062B40")]
			[CompilerGenerated]
			add
			{
				Action<AsyncOperationHandle<GameObject>> onLoadedAssetLoadComplete = this.OnLoadedAssetLoadComplete;
				Delegate @delegate = Delegate.Combine(onLoadedAssetLoadComplete, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLoadedAssetLoadComplete)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002400")]
			[Cpp2IlInjected.Address(RVA = "0x1063160", Offset = "0x1061B60", VA = "0x181063160")]
			[CompilerGenerated]
			remove
			{
				Action<AsyncOperationHandle<GameObject>> onLoadedAssetLoadComplete = this.OnLoadedAssetLoadComplete;
				Delegate @delegate = Delegate.Remove(onLoadedAssetLoadComplete, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLoadedAssetLoadComplete)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002407")]
		[Cpp2IlInjected.Address(RVA = "0x10619C0", Offset = "0x10603C0", VA = "0x1810619C0")]
		public bool IsMySceneSupportingStreaming()
		{
			//IL_000f: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
			int num = 0;
			if (!(instance == (UnityEngine.Object)num))
			{
				int handle = base.gameObject.scene.m_Handle;
				Scene scene = GridObjectStreamingManager._instance.gameObject.scene;
				int handle2 = scene.m_Handle;
				if ((object)scene != null)
				{
					goto IL_007c;
				}
				GridObjectStreamingManager instance2 = GridObjectStreamingManager._instance;
				if ((object)instance2 != null && instance2.ActiveConfig.IsStreamingLevelComplexity)
				{
					GameObject gameObject = default(GameObject);
					StreamingSceneConfig component = gameObject.GetComponent<StreamingSceneConfig>();
					int num2 = 0;
					if (component != (UnityEngine.Object)num2 && component.SceneType == StreamingSceneType.LevelComplexity)
					{
						goto IL_007c;
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
			IL_007c:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002411")]
		[Cpp2IlInjected.Address(RVA = "0x1060C30", Offset = "0x105F630", VA = "0x181060C30")]
		private void Awake()
		{
			IStreamableAssetRefToLoadProvider streamableAssetRefToLoadProvider = (_visualAssetToLoadProvider = GetComponent<IStreamableAssetRefToLoadProvider>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002412")]
		[Cpp2IlInjected.Address(RVA = "0x10626C0", Offset = "0x10610C0", VA = "0x1810626C0")]
		[IteratorStateMachine(typeof(_003CStart_003Ed__55))]
		private IEnumerator Start()
		{
			int _003C_003E1__state = default(int);
			_003CStart_003Ed__55 _003CStart_003Ed__ = new _003CStart_003Ed__55(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CStart_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002413")]
		[Cpp2IlInjected.Address(RVA = "0x1061F00", Offset = "0x1060900", VA = "0x181061F00")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0072
			//IL_0019: Expected O, but got I4
			if (IsInStreamingMgr)
			{
				GridObjectScript gridObj = _gridObj;
				int num = 0;
				if (gridObj != (UnityEngine.Object)num)
				{
					GridObjectScript gridObj2 = _gridObj;
					EventHandler value = Update_CullingGroup_BoundingSphere;
					gridObj2.OnTransformUpdate -= value;
				}
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					float height = Height;
					StreamableAssetRefType assetType = AssetType;
					CullingGroupStreamingManager cullingGroupManager = instance.GetCullingGroupManager(assetType, height);
				}
				if (false)
				{
				}
				IsInStreamingMgr = false;
			}
			ReleaseRef();
		}

		[Cpp2IlInjected.Token(Token = "0x6002414")]
		[Cpp2IlInjected.Address(RVA = "0x1060A50", Offset = "0x105F450", VA = "0x181060A50")]
		private void AddToStreaming()
		{
			//Discarded unreachable code: IL_006b
			//IL_0020: Expected O, but got I4
			if (!IsInStreamingMgr)
			{
				IsInStreamingMgr = true;
				GridObjectScript gridObj = _gridObj;
				int num = 0;
				if (gridObj != (UnityEngine.Object)num)
				{
					GridObjectScript gridObj2 = _gridObj;
					EventHandler value = Update_CullingGroup_BoundingSphere;
					gridObj2.OnTransformUpdate += value;
				}
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					float height = Height;
					StreamableAssetRefType assetType = AssetType;
					CullingGroupStreamingManager cullingGroupManager = instance.GetCullingGroupManager(assetType, height);
				}
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002415")]
		[Cpp2IlInjected.Address(RVA = "0x1062570", Offset = "0x1060F70", VA = "0x181062570")]
		private void RemoveFromStreaming()
		{
			//Discarded unreachable code: IL_006c
			//IL_0019: Expected O, but got I4
			if (IsInStreamingMgr)
			{
				GridObjectScript gridObj = _gridObj;
				int num = 0;
				if (gridObj != (UnityEngine.Object)num)
				{
					GridObjectScript gridObj2 = _gridObj;
					EventHandler value = Update_CullingGroup_BoundingSphere;
					gridObj2.OnTransformUpdate -= value;
				}
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					float height = Height;
					StreamableAssetRefType assetType = AssetType;
					CullingGroupStreamingManager cullingGroupManager = instance.GetCullingGroupManager(assetType, height);
				}
				if (false)
				{
				}
				IsInStreamingMgr = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002416")]
		[Cpp2IlInjected.Address(RVA = "0x1060F30", Offset = "0x105F930", VA = "0x181060F30")]
		public object GetObjectKeyToLoad()
		{
			//IL_0028: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			string assetGUID = AssetRef.AssetGUID;
			if (_visualAssetToLoadProvider != null)
			{
			}
			int num = 0;
			if ((object)GraphicSettings.CurrentGraphicSettingsData != null)
			{
			}
			int num2 = 0;
			string assetGUID2 = default(string);
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				PrefabSelectorConfig prefabSelector = GraphicSettings.CurrentGraphicSettingsData.PrefabSelector;
				AssetReferenceGameObject assetRef = AssetRef;
				AssetReferenceGameObject mappedAsset = prefabSelector.GetMappedAsset(assetRef);
				if (mappedAsset != null)
				{
					assetGUID2 = mappedAsset.AssetGUID;
				}
			}
			if (assetGUID2 == null || assetGUID2 == null || assetGUID2.StartsWith("guid:"))
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002417")]
		[Cpp2IlInjected.Address(RVA = "0x1061460", Offset = "0x105FE60", VA = "0x181061460")]
		public AsyncOperationHandle<GameObject> InstantiateRef()
		{
			//Discarded unreachable code: IL_004b, IL_0051, IL_0057, IL_005d, IL_0063, IL_0069, IL_006f, IL_0075
			bool flag = default(bool);
			if (!flag && flag)
			{
				int num = 0;
				bool flag2 = default(bool);
				if (!flag2)
				{
					Vector3 vector = default(Vector3);
					float z = vector.z;
				}
				int num2 = 0;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				if ((object)StreamingStateInfo.Instance == null)
				{
				}
			}
			GameObject gameObject = default(GameObject);
			string text = gameObject.name;
			UnityEngine.Debug.LogError("Error loading Streamable " + text);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002418")]
		[Cpp2IlInjected.Address(RVA = "0x10627C0", Offset = "0x10611C0", VA = "0x1810627C0")]
		[Conditional("DEBUG_STREAMABLE_ASSET_REF_VERBOSE")]
		protected void Verbose(string message, [CallerMemberName] string memberName = "")
		{
			//Discarded unreachable code: IL_008f
			string[] array;
			while (true)
			{
				array = new string[5];
				string text = base.gameObject.name;
				if (text != null && text == null)
				{
					continue;
				}
				array[0] = text;
				if (".StreamableAssetRef." != null && ".StreamableAssetRef." == null)
				{
					continue;
				}
				array[1] = ".StreamableAssetRef.";
				if (memberName != null && ".StreamableAssetRef." == null)
				{
					continue;
				}
				array[2] = memberName;
				if (": " == null || ": " != null)
				{
					array[3] = ": ";
					if (message == null || ": " != null)
					{
						break;
					}
				}
			}
			array[4] = message;
			UnityEngine.Debug.Log(string.Concat(array));
		}

		[Cpp2IlInjected.Token(Token = "0x6002419")]
		[Cpp2IlInjected.Address(RVA = "0x1062740", Offset = "0x1061140", VA = "0x181062740")]
		private void Update_CullingGroup_BoundingSphere(object sender, EventArgs e)
		{
			GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
			if ((object)instance != null)
			{
				float height = Height;
				StreamableAssetRefType assetType = AssetType;
				CullingGroupStreamingManager cullingGroupManager = instance.GetCullingGroupManager(assetType, height);
			}
			if (0 == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600241A")]
		[Cpp2IlInjected.Address(RVA = "0x1061BF0", Offset = "0x10605F0", VA = "0x181061BF0")]
		private unsafe void LoadedAssetCompleted(AsyncOperationHandle<GameObject> obj)
		{
			//Discarded unreachable code: IL_0119
			//IL_0018: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_0104: Expected O, but got I4
			//IL_010f: Expected O, but got I8
			if ((object)StreamingStateInfo.Instance != null)
			{
			}
			Transform transform = prefabInstanceTransform;
			int num = 0;
			if (!(transform != (UnityEngine.Object)num))
			{
				if (!transformData.IsValid)
				{
					goto IL_0064;
				}
				Transform transform2 = ((GameObject)((AsyncOperationHandle<TObject>*)obj)->Result).transform;
				float z = transformData.localScale.z;
			}
			Transform transform3 = ((GameObject)((AsyncOperationHandle<TObject>*)obj)->Result).transform;
			Transform transform4 = prefabInstanceTransform;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			goto IL_0064;
			IL_0064:
			if (transformData.IsValid)
			{
				Material material = prefabInstanceMaterial;
				int num2 = 0;
				if (material != (UnityEngine.Object)num2)
				{
					MeshRenderer[] componentsInChildren = ((GameObject)((AsyncOperationHandle<TObject>*)obj)->Result).GetComponentsInChildren<MeshRenderer>();
					int num3 = 0;
					int num4 = 0;
					int length = componentsInChildren.Length;
					if (num4 < length)
					{
						MeshRenderer meshRenderer = componentsInChildren[num3];
						Material material2 = prefabInstanceMaterial;
						((Renderer)meshRenderer).SetMaterial(material2);
						num3++;
					}
				}
			}
			if (layer != 0)
			{
				GameObject result = (GameObject)((AsyncOperationHandle<TObject>*)obj)->Result;
				int num6 = (result.layer = layer);
			}
			TaskCompletionSource<bool> waitForLoading = _waitForLoading;
			if (waitForLoading != null)
			{
				bool flag = ((TaskCompletionSource<TResult>)(object)waitForLoading).TrySetResult((TResult)1);
			}
			_waitForLoading = (TaskCompletionSource<bool>)0;
			if (this.OnLoadedAssetLoadComplete == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600241B")]
		[Cpp2IlInjected.Address(RVA = "0x1061320", Offset = "0x105FD20", VA = "0x181061320")]
		[AsyncStateMachine(typeof(_003CInstantiateAsync_003Ed__64))]
		public Task<GameObject> InstantiateAsync()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600241C")]
		[Cpp2IlInjected.Address(RVA = "0x1062470", Offset = "0x1060E70", VA = "0x181062470")]
		public void ReleaseRef()
		{
			//IL_0019: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = Addressables.ReleaseInstance((AsyncOperationHandle<>)loadedAsset);
				int num = 0;
				loadedAsset = (AsyncOperationHandle<GameObject>)num;
				((Action<T>)(object)this.OnLoadedAssetChanged)?.Invoke((T)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600241D")]
		[Cpp2IlInjected.Address(RVA = "0x1060BA0", Offset = "0x105F5A0", VA = "0x181060BA0")]
		public bool AreLoadedKeyEquals(object key1, object key2)
		{
			bool flag = default(bool);
			if (key1 != null && key1 != null && key2 != null && key2 != null && flag)
			{
				return true;
			}
			return key1 == key2;
		}

		[Cpp2IlInjected.Token(Token = "0x600241E")]
		[Cpp2IlInjected.Address(RVA = "0x1062190", Offset = "0x1060B90", VA = "0x181062190")]
		public Task<GameObject> ReInstantiateAsync()
		{
			//IL_004d: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				object objectKeyToLoad = GetObjectKeyToLoad();
				object loadedObjectKey = LoadedObjectKey;
				bool flag2 = default(bool);
				if ((loadedObjectKey != null && loadedObjectKey != null && objectKeyToLoad != null && objectKeyToLoad != null && flag2) || loadedObjectKey == objectKeyToLoad)
				{
					bool flag3 = default(bool);
					if (flag3)
					{
					}
					GameObject result = default(GameObject);
					return (Task<GameObject>)(object)Task.FromResult(result);
				}
				int num = 0;
				int num2 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			}
			return (Task<GameObject>)(object)Task.FromResult((GameObject)0);
		}

		[Cpp2IlInjected.Token(Token = "0x600241F")]
		[Cpp2IlInjected.Address(RVA = "0x1060ED0", Offset = "0x105F8D0", VA = "0x181060ED0", Slot = "4")]
		public string GetDebugName()
		{
			//Discarded unreachable code: IL_0018
			string text = base.gameObject.name;
			return "sar:" + text;
		}

		[Cpp2IlInjected.Token(Token = "0x6002424")]
		[Cpp2IlInjected.Address(RVA = "0x1061BD0", Offset = "0x10605D0", VA = "0x181061BD0", Slot = "11")]
		public void Load()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002425")]
		[Cpp2IlInjected.Address(RVA = "0x1062730", Offset = "0x1061130", VA = "0x181062730", Slot = "12")]
		public void Unload(bool fromDisable)
		{
			ReleaseRef();
		}

		[Cpp2IlInjected.Token(Token = "0x6002426")]
		[Cpp2IlInjected.Address(RVA = "0x1061220", Offset = "0x105FC20", VA = "0x181061220", Slot = "13")]
		public Vector3 GetWorldPosition()
		{
			bool flag = default(bool);
			if (flag)
			{
			}
			int num = 0;
			bool flag2 = default(bool);
			if (flag2)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002427")]
		[Cpp2IlInjected.Address(RVA = "0x10611B0", Offset = "0x105FBB0", VA = "0x1810611B0", Slot = "14")]
		public float GetRadius()
		{
			if (GridObjectStreamingManager._instance.ActiveConfig.IsStreamableCulledWithFrustum)
			{
				return Height;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002428")]
		[Cpp2IlInjected.Address(RVA = "0x1062050", Offset = "0x1060A50", VA = "0x181062050")]
		private void OnDrawGizmosSelected()
		{
			//Discarded unreachable code: IL_0040
			Color blue = Color.blue;
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform2 = base.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform transform3 = base.transform;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002429")]
		[Cpp2IlInjected.Address(RVA = "0x1060C80", Offset = "0x105F680", VA = "0x181060C80")]
		public float GetCurrentDistance()
		{
			//IL_0042: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			int num = 0;
			if (Application.isPlaying)
			{
				int num2 = 0;
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					float height = Height;
					StreamableAssetRefType assetType = AssetType;
					CullingGroupStreamingManager cullingGroupManager = instance.GetCullingGroupManager(assetType, height);
				}
				if (num2 != 0)
				{
				}
				int num3 = 0;
				if (!((UnityEngine.Object)num2 == (UnityEngine.Object)num3))
				{
					Transform transform = GridObjectStreamingMgr.targetCamera.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Transform streamingRefPointTransform = StreamingRefPointTransform;
					int num4 = 0;
					if (streamingRefPointTransform != (UnityEngine.Object)num4)
					{
						Transform streamingRefPointTransform2 = StreamingRefPointTransform;
					}
					Transform transform2 = prefabInstanceTransform;
					int num5 = 0;
					if (transform2 != (UnityEngine.Object)num5)
					{
						Transform transform3 = prefabInstanceTransform;
					}
					Transform transform4 = base.transform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					float result = default(float);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600242A")]
		[Cpp2IlInjected.Address(RVA = "0x1062A80", Offset = "0x1061480", VA = "0x181062A80")]
		public StreamableAssetRef()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
