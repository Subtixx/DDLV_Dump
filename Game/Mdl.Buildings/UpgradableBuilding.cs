using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Ftue.Cutscenes;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Streaming;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009D8")]
	public class UpgradableBuilding : GridObjectStateUser, IPlayerTaskProvider, IStreamableAssetRefToLoadProvider
	{
		[Cpp2IlInjected.Token(Token = "0x20009D9")]
		private enum SignLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x4003677")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4003678")]
			Unlock,
			[Cpp2IlInjected.Token(Token = "0x4003679")]
			Upgrade
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20009DA")]
		public class VisualRefToGameObjectLink
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400367A")]
			public AssetReferenceGameObject LoadedVisual;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400367B")]
			public GameObject GameObjectToActivate;

			[Cpp2IlInjected.Token(Token = "0x6002E37")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public VisualRefToGameObjectLink()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20009DB")]
		private class DisableCollidersScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400367C")]
			private List<Collider> disabledColliders;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400367D")]
			private StreamableAssetRef streamableAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400367E")]
			private AsyncOperationHandle<GameObject> asyncAsset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400367F")]
			private int[] ignoreLayers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4003680")]
			private GameObject[] additionalGameObjects;

			[Cpp2IlInjected.Token(Token = "0x4003681")]
			private static readonly GameObject[] emptyGameObjectArray = new GameObject[0];

			[Cpp2IlInjected.Token(Token = "0x6002E38")]
			[Cpp2IlInjected.Address(RVA = "0x1412F60", Offset = "0x1411960", VA = "0x181412F60")]
			public DisableCollidersScope(StreamableAssetRef streamableAssetRef, params GameObject[] gameObjects)
			{
				//Discarded unreachable code: IL_00dc
				//IL_004d: Expected O, but got I4
				bool flag = default(bool);
				bool flag2 = default(bool);
				GameObject gameObject = default(GameObject);
				while (true)
				{
					disabledColliders = (List<Collider>)(object)new List<T>();
					int[] array = new int[1];
					array[0] = LayerMask.NameToLayer("GardeningSlots");
					ignoreLayers = array;
					base._002Ector();
					streamableAsset = streamableAssetRef;
					StreamableAssetRef streamableAssetRef2 = streamableAsset;
					int num = 0;
					if (!(streamableAssetRef2 != (UnityEngine.Object)num))
					{
						break;
					}
					StreamableAssetRef streamableAssetRef3 = streamableAsset;
					Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnStreamableChanged);
					streamableAssetRef3.add_OnLoadedAssetChanged((Action<>)(object)action);
					StreamableAssetRef streamableAssetRef4 = streamableAsset;
					if (!flag)
					{
						if (!flag2)
						{
							break;
						}
						Action<AsyncOperationHandle<GameObject>> action2 = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnStreamableCompleted);
						Action<AsyncOperationHandle> action3 = (Action<AsyncOperationHandle>)(object)new Action<T>(OnStreamableDestroyed);
					}
					GameObject[] array2 = new GameObject[1];
					if ((object)gameObject == null || (object)gameObject != null)
					{
						array2[0] = gameObject;
						DisableCollidersOn(array2);
						break;
					}
				}
				additionalGameObjects = gameObjects;
				GameObject[] gameObjects2 = additionalGameObjects;
				DisableCollidersOn(gameObjects2);
			}

			[Cpp2IlInjected.Token(Token = "0x6002E39")]
			[Cpp2IlInjected.Address(RVA = "0x1412780", Offset = "0x1411180", VA = "0x181412780")]
			private unsafe void OnStreamableChanged(AsyncOperationHandle<GameObject> obj)
			{
				//Discarded unreachable code: IL_007b
				bool flag = default(bool);
				bool flag2 = default(bool);
				GameObject[] array;
				GameObject gameObject = default(GameObject);
				do
				{
					if (!((AsyncOperationHandle<TObject>*)obj)->IsValid())
					{
						Reset();
						GameObject[] gameObjects = additionalGameObjects;
						DisableCollidersOn(gameObjects);
						if (flag)
						{
							Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnStreamableCompleted);
							Action<AsyncOperationHandle> action2 = (Action<AsyncOperationHandle>)(object)new Action<T>(OnStreamableDestroyed);
						}
						return;
					}
					if (!flag2)
					{
						Action<AsyncOperationHandle<GameObject>> action3 = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnStreamableCompleted);
						Action<AsyncOperationHandle> action4 = (Action<AsyncOperationHandle>)(object)new Action<T>(OnStreamableDestroyed);
						return;
					}
					array = new GameObject[1];
				}
				while ((object)gameObject != null && (object)gameObject == null);
				array[0] = gameObject;
			}

			[Cpp2IlInjected.Token(Token = "0x6002E3A")]
			[Cpp2IlInjected.Address(RVA = "0x1412A70", Offset = "0x1411470", VA = "0x181412A70")]
			private unsafe void OnStreamableCompleted(AsyncOperationHandle<GameObject> obj)
			{
				//Discarded unreachable code: IL_0026
				GameObject[] array;
				GameObject result;
				do
				{
					array = new GameObject[1];
					result = (GameObject)((AsyncOperationHandle<TObject>*)obj)->Result;
				}
				while ((object)result != null && (object)result == null);
				array[0] = result;
				DisableCollidersOn(array);
			}

			[Cpp2IlInjected.Token(Token = "0x6002E3B")]
			[Cpp2IlInjected.Address(RVA = "0x1412B50", Offset = "0x1411550", VA = "0x181412B50")]
			private void OnStreamableDestroyed(AsyncOperationHandle op)
			{
				Reset();
			}

			[Cpp2IlInjected.Token(Token = "0x6002E3C")]
			[Cpp2IlInjected.Address(RVA = "0x1412E40", Offset = "0x1411840", VA = "0x181412E40")]
			public void Update(params GameObject[] gameObjects)
			{
				Reset();
				additionalGameObjects = gameObjects;
				DisableCollidersOn(gameObjects);
			}

			[Cpp2IlInjected.Token(Token = "0x6002E3D")]
			[Cpp2IlInjected.Address(RVA = "0x1412560", Offset = "0x1410F60", VA = "0x181412560", Slot = "4")]
			public void Dispose()
			{
				//IL_0010: Expected O, but got I4
				StreamableAssetRef streamableAssetRef = streamableAsset;
				int num = 0;
				if (streamableAssetRef != (UnityEngine.Object)num)
				{
					StreamableAssetRef streamableAssetRef2 = streamableAsset;
					Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnStreamableChanged);
					streamableAssetRef2.remove_OnLoadedAssetChanged((Action<>)(object)action);
				}
				bool flag = default(bool);
				if (flag)
				{
					Action<AsyncOperationHandle<GameObject>> action2 = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnStreamableCompleted);
					Action<AsyncOperationHandle> action3 = (Action<AsyncOperationHandle>)(object)new Action<T>(OnStreamableDestroyed);
				}
				Reset();
				GameObject[] array = (additionalGameObjects = emptyGameObjectArray);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002E3E")]
			[Cpp2IlInjected.Address(RVA = "0x14122D0", Offset = "0x1410CD0", VA = "0x1814122D0")]
			private void DisableCollidersOn(params GameObject[] gameObjects)
			{
				//Discarded unreachable code: IL_006c
				Func<GameObject, bool> _003C_003E9__12_ = _003C_003Ec._003C_003E9__12_0;
				if (_003C_003E9__12_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GameObject g) => default(bool));
				}
				IEnumerable<GameObject> enumerable = (IEnumerable<GameObject>)Enumerable.Where<GameObject>((IEnumerable<>)(object)gameObjects, (Func<, >)(object)_003C_003E9__12_);
				Action<GameObject> action = (Action<GameObject>)(object)(Action<T>)delegate(GameObject gameObject)
				{
					//Discarded unreachable code: IL_0030
					List<Collider> list2 = disabledColliders;
					int includeInactive = 0;
					Collider[] componentsInChildren = gameObject.GetComponentsInChildren<Collider>((byte)includeInactive != 0);
					Func<Collider, bool> func = (Func<Collider, bool>)(object)(Func<T, TResult>)delegate(Collider c)
					{
						//Discarded unreachable code: IL_0018
						int[] array = ignoreLayers;
						int layer = c.gameObject.layer;
						bool flag = default(bool);
						return !flag;
					};
					IEnumerable<Collider> enumerable2 = (IEnumerable<Collider>)Enumerable.Where<Collider>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
					((List<T>)(object)list2).AddRange((IEnumerable<>)enumerable2);
				};
				MoreLinq.ForEach<GameObject>((IEnumerable<>)enumerable, (Action<>)(object)action);
				List<Collider> list = disabledColliders;
				Action<Collider> action2 = default(Action<Collider>);
				if (_003C_003Ec._003C_003E9__12_2 == null)
				{
					action2 = (Action<Collider>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate
					{
					});
				}
				((List<T>)(object)list).ForEach((Action<>)(object)action2);
			}

			[Cpp2IlInjected.Token(Token = "0x6002E3F")]
			[Cpp2IlInjected.Address(RVA = "0x1412B60", Offset = "0x1411560", VA = "0x181412B60")]
			public void Reset()
			{
				//Discarded unreachable code: IL_0039
				List<Collider> list = disabledColliders;
				Action<Collider> _003C_003E9__13_ = _003C_003Ec._003C_003E9__13_0;
				if (_003C_003E9__13_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate
					{
					};
				}
				((List<T>)(object)list).ForEach((Action<>)(object)_003C_003E9__13_);
				((List<T>)(object)disabledColliders).Clear();
			}

			[Cpp2IlInjected.Token(Token = "0x6002E40")]
			[Cpp2IlInjected.Address(RVA = "0x1412250", Offset = "0x1410C50", VA = "0x181412250")]
			[Conditional("DEBUG_DISABLE_BUILDING_COLLIDERS")]
			private void DebugLog(string message)
			{
				UnityEngine.Debug.Log("DisableCollidersOn: " + message);
			}

			[Cpp2IlInjected.Token(Token = "0x6002E41")]
			[Cpp2IlInjected.Address(RVA = "0x1412F00", Offset = "0x1411900", VA = "0x181412F00")]
			static DisableCollidersScope()
			{
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20009DD")]
		public struct SignUpdateScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003686")]
			private readonly UpgradableBuilding UpgBld;

			[Cpp2IlInjected.Token(Token = "0x6002E49")]
			[Cpp2IlInjected.Address(RVA = "0x14138A0", Offset = "0x14122A0", VA = "0x1814138A0")]
			public SignUpdateScope(UpgradableBuilding upgBld)
			{
				//Discarded unreachable code: IL_000f
				UpgBld = upgBld;
				upgBld.signRefreshing = true;
			}

			[Cpp2IlInjected.Token(Token = "0x6002E4A")]
			[Cpp2IlInjected.Address(RVA = "0x1413880", Offset = "0x1412280", VA = "0x181413880", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400365A")]
		[SerializeField]
		private GameObject upgradeModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400365B")]
		[SerializeField]
		private AssetReference upgradeSignAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400365C")]
		[SerializeField]
		private AssetReference unlockSignAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400365D")]
		[SerializeField]
		private Transform spawnSignPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400365E")]
		private GameObject signModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400365F")]
		[ItemID]
		public int UpgradeSignVisibilityCondition;

		[Cpp2IlInjected.Token(Token = "0x4003660")]
		private static int unlockScroogePanelsCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4003661")]
		[ItemID]
		[SerializeField]
		private int liftCurseCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003662")]
		private ConditionEventHandler curseEventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003663")]
		[SerializeField]
		private PlayerTaskDefinition _unlockedInteractionTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003664")]
		[SerializeField]
		private GameObject uncursedBaseBuilding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003665")]
		[SerializeField]
		private GameObject cursedBuilding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003666")]
		[SerializeField]
		[ItemID]
		private int _castleId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003667")]
		[SerializeField]
		private CustomTimelineCutscene unlockCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003668")]
		[SerializeField]
		private CustomTimelineCutscene upgradeCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003669")]
		[SerializeField]
		public StreamableAssetRef streamableCmp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400366A")]
		[SerializeField]
		private AssetReferenceGameObject uncursedBaseBuildingRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400366B")]
		[SerializeField]
		private AssetReferenceGameObject cursedBuildingRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400366C")]
		[SerializeField]
		private List<VisualRefToGameObjectLink> ActiveVisualEnabler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400366D")]
		private int curLevel = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400366E")]
		private SignLoaded signLoaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400366F")]
		private bool _isBuildingUnlocked = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4003670")]
		private CurseState curseState;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003672")]
		private WeakReference<DisableCollidersScope> weakDisableColliderScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003673")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003674")]
		private bool refreshing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x4003675")]
		private bool signRefreshing;

		[Cpp2IlInjected.Token(Token = "0x1700069A")]
		private Item UpgradeSignVisibilityConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002E09")]
			[Cpp2IlInjected.Address(RVA = "0xD3CE00", Offset = "0xD3B800", VA = "0x180D3CE00")]
			get
			{
				long num = Convert.ToInt64((uint)UpgradeSignVisibilityCondition);
				long num2 = Convert.ToInt64((uint)UpgradeSignVisibilityCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069B")]
		public bool IsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0A")]
			[Cpp2IlInjected.Address(RVA = "0xD3CBC0", Offset = "0xD3B5C0", VA = "0x180D3CBC0")]
			get
			{
				return !_isBuildingUnlocked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC8"), Cpp2IlInjected.Token(Token = "0x4003671")]
		public bool SkipCutscenes
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0B")]
			[Cpp2IlInjected.Address(RVA = "0xD3CD40", Offset = "0xD3B740", VA = "0x180D3CD40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002E0C")]
			[Cpp2IlInjected.Address(RVA = "0xD3CEF0", Offset = "0xD3B8F0", VA = "0x180D3CEF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700069D")]
		public int UpgradeLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0D")]
			[Cpp2IlInjected.Address(RVA = "0xD3CD50", Offset = "0xD3B750", VA = "0x180D3CD50")]
			get
			{
				//Discarded unreachable code: IL_003a
				GridObjectScript gridObjectScript = base.GridObjectScript;
				if ((object)gridObjectScript != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						GridState state_ = _003CGridObject_003Ek__BackingField.state_;
						if (state_ != null)
						{
							IGridStateData stateData = state_.StateData;
						}
					}
				}
				int num = 0;
				if (num != 0 && num != 0)
				{
					return num;
				}
				return -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069E")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0E")]
			[Cpp2IlInjected.Address(RVA = "0xD3CBD0", Offset = "0xD3B5D0", VA = "0x180D3CBD0")]
			get
			{
				//Discarded unreachable code: IL_0034
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				GridObjectScript gridObjectScript = base.GridObjectScript;
				if ((object)gridObjectScript != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField.ItemID;
						int num = 0;
					}
				}
				if (0 == 0)
				{
					Item invalid = Item.Invalid;
				}
				IItemData result = default(IItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E0F")]
		[Cpp2IlInjected.Address(RVA = "0xD3B620", Offset = "0xD3A020", VA = "0x180D3B620", Slot = "5")]
		protected override void Start()
		{
			CheckLock();
			CreateCurseEventHandler();
			base.Start();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E10")]
		[Cpp2IlInjected.Address(RVA = "0xD3ACF0", Offset = "0xD396F0", VA = "0x180D3ACF0", Slot = "6")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0086
			//IL_0063: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
					_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
				}
			}
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			curseEventHandler?.Dispose();
			curseEventHandler = (ConditionEventHandler)num;
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E11")]
		[Cpp2IlInjected.Address(RVA = "0xD3C880", Offset = "0xD3B280", VA = "0x180D3C880")]
		public Task<UpgradeBuilding.Types.Response> UpgradeBuilding(CancellationToken ct)
		{
			//Discarded unreachable code: IL_002b
			GridObjectScript gridObjectScript = base.GridObjectScript;
			GridScript _003CGridScript_003Ek__BackingField = gridObjectScript.GridScript;
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			IGrid _003CGrid_003Ek__BackingField = _003CGridScript_003Ek__BackingField.Grid;
			Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
			Task<UpgradeBuilding.Types.Response> result = default(Task<UpgradeBuilding.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E12")]
		[Cpp2IlInjected.Address(RVA = "0xD3B490", Offset = "0xD39E90", VA = "0x180D3B490")]
		[AsyncStateMachine(typeof(_003CRefresh_003Ed__41))]
		private Task Refresh()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E13")]
		[Cpp2IlInjected.Address(RVA = "0xD3C9D0", Offset = "0xD3B3D0", VA = "0x180D3C9D0")]
		public bool VisibilityUnlocked()
		{
			//Discarded unreachable code: IL_0024
			int itemID = UpgradeSignVisibilityConditionItem.ItemID;
			Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
			Meta.Online.Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E14")]
		[Cpp2IlInjected.Address(RVA = "0xD3A650", Offset = "0xD39050", VA = "0x180D3A650")]
		private Item GetItemFromParent()
		{
			//Discarded unreachable code: IL_0020
			//IL_0010: Expected O, but got I4
			ItemScript component = GetComponent<ItemScript>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				return component.Item;
			}
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E15")]
		[Cpp2IlInjected.Address(RVA = "0xD3A8B0", Offset = "0xD392B0", VA = "0x180D3A8B0")]
		private IBuildingUpgradable GetUpgradableItemData()
		{
			//Discarded unreachable code: IL_000f
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item itemFromParent = GetItemFromParent();
			IBuildingUpgradable result = default(IBuildingUpgradable);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E16")]
		[Cpp2IlInjected.Address(RVA = "0xD3AAC0", Offset = "0xD394C0", VA = "0x180D3AAC0")]
		private void OnBuildingUnlocked(Item building, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_003f
			if ((object)GetItemFromParent() != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
				_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
				CheckLock();
				Refresh().FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E17")]
		[Cpp2IlInjected.Address(RVA = "0xD3AC90", Offset = "0xD39690", VA = "0x180D3AC90")]
		private void OnCurseUpdated(ConditionListener conditionListener)
		{
			Refresh().FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E18")]
		[Cpp2IlInjected.Address(RVA = "0xD39D30", Offset = "0xD38730", VA = "0x180D39D30")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			int itemID = UpgradeSignVisibilityConditionItem.ItemID;
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E19")]
		[Cpp2IlInjected.Address(RVA = "0xD39F20", Offset = "0xD38920", VA = "0x180D39F20")]
		private void DisposeEventHandler()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1A")]
		[Cpp2IlInjected.Address(RVA = "0xD3A9F0", Offset = "0xD393F0", VA = "0x180D3A9F0")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_003b
			//IL_0028: Expected O, but got I8
			if (base.gameObject.activeSelf)
			{
				eventHandler?.Dispose();
				eventHandler = (ConditionEventHandler)0;
				CheckLock();
				Refresh().FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1B")]
		[Cpp2IlInjected.Address(RVA = "0xD39540", Offset = "0xD37F40", VA = "0x180D39540")]
		private void CheckLock()
		{
			//Discarded unreachable code: IL_0104
			//IL_0075: Expected O, but got I4
			Item itemFromParent = GetItemFromParent();
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = (_isBuildingUnlocked = SystemRoot.Instance.MetaClient.profile.world_.IsBuildingUnlocked(itemFromParent));
			}
			int itemID = UpgradeSignVisibilityConditionItem.ItemID;
			Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
			Meta.Online.Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool flag3 = default(bool);
			if (!flag3)
			{
				eventHandler?.Dispose();
				int num = 0;
				eventHandler = (ConditionEventHandler)num;
				int itemID2 = UpgradeSignVisibilityConditionItem.ItemID;
				if (SystemRoot.Instance.MetaClient.Dispatcher != null)
				{
					ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
				}
				ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
				eventHandler = conditionEventHandler;
			}
			if (!_isBuildingUnlocked)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
				_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value2 = OnBuildingUnlocked;
				_003CDispatcher_003Ek__BackingField2.OnBuildingUnlocked += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1C")]
		[Cpp2IlInjected.Address(RVA = "0xD3B240", Offset = "0xD39C40", VA = "0x180D3B240")]
		[AsyncStateMachine(typeof(_003CRefreshModel_003Ed__53))]
		private Task RefreshModel(int level)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1D")]
		[Cpp2IlInjected.Address(RVA = "0xD3A7D0", Offset = "0xD391D0", VA = "0x180D3A7D0", Slot = "9")]
		public object GetStreamableAssetToLoadKey()
		{
			object currentStateVisual = GetCurrentStateVisual();
			RefreshActiveVisualEnabler(currentStateVisual);
			return currentStateVisual;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1E")]
		[Cpp2IlInjected.Address(RVA = "0xD3A050", Offset = "0xD38A50", VA = "0x180D3A050")]
		public object GetCurrentStateVisual()
		{
			bool flag = default(bool);
			BuildingItemType buildingItemType = default(BuildingItemType);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag5 = default(bool);
			UpgradeData upgradeData = default(UpgradeData);
			while (true)
			{
				GridObjectScript gridObjectScript = base.GridObjectScript;
				int num = 0;
				if ((object)gridObjectScript != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						GridState state_ = _003CGridObject_003Ek__BackingField.state_;
						if (state_ != null)
						{
							IGridStateData stateData = state_.StateData;
						}
					}
				}
				if (num != 0)
				{
					continue;
				}
				GridObjectScript gridObjectScript2 = base.GridObjectScript;
				if ((object)gridObjectScript2 != null)
				{
					GridObject _003CGridObject_003Ek__BackingField2 = gridObjectScript2.GridObject;
					if (_003CGridObject_003Ek__BackingField2 != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField2.ItemID;
					}
				}
				if (!flag || buildingItemType != 0)
				{
					refreshing = (byte)num != 0;
					if (streamableCmp.AssetRef.AssetGUID == null)
					{
					}
				}
				if (num == 0)
				{
					flag2 = (_isBuildingUnlocked ? 1 : 0) != num;
				}
				int newLevel = (flag2 ? 1 : 0);
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
					if ((object)client != null && client.MetaClient == null)
					{
					}
				}
				SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField2 != null)
				{
					Mdl.Online.Client client2 = _003CInstance_003Ek__BackingField2.Client;
					if ((object)client2 != null && client2.MetaClient == null)
					{
					}
				}
				int num2 = liftCurseCondition;
				bool flag4 = flag3;
				IBuildingUpgradable upgradableItemData = GetUpgradableItemData();
				if (upgradableItemData != null)
				{
					if (upgradableItemData != null)
					{
					}
					flag5 = upgradableItemData == null;
				}
				if (!flag4)
				{
					while (upgradableItemData == null)
					{
					}
					Func<UpgradeData, bool> func = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData x)
					{
						//Discarded unreachable code: IL_0011
						int num3 = newLevel;
						return x.level_ == num3;
					};
					if (upgradeData == null)
					{
						while ((IntPtr)(_isBuildingUnlocked ? 1 : 0) != (IntPtr)upgradeData)
						{
						}
						if (!flag5 && !uncursedBaseBuildingRef.RuntimeKeyIsValid())
						{
							continue;
						}
					}
				}
				while (curseState == CurseState.Cursed)
				{
				}
				while (flag5)
				{
				}
				if (cursedBuildingRef.RuntimeKeyIsValid())
				{
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1F")]
		[Cpp2IlInjected.Address(RVA = "0xD3AF10", Offset = "0xD39910", VA = "0x180D3AF10")]
		private void RefreshActiveVisualEnabler(object displayedVisual)
		{
			//Discarded unreachable code: IL_0032, IL_0038, IL_003e, IL_0044
			int num = 0;
			if ((IntPtr)ActiveVisualEnabler == (IntPtr)num)
			{
				return;
			}
			bool flag = default(bool);
			if (displayedVisual == null || displayedVisual == null || !flag)
			{
			}
			string value = default(string);
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			List<VisualRefToGameObjectLink> activeVisualEnabler = ActiveVisualEnabler;
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E20")]
		[Cpp2IlInjected.Address(RVA = "0xD3C370", Offset = "0xD3AD70", VA = "0x180D3C370")]
		public unsafe void UpdateModelCS()
		{
			//Discarded unreachable code: IL_0032
			//IL_0012: Expected O, but got I4
			int num = 0;
			StreamableAssetRef streamableAssetRef = streamableCmp;
			int num2 = 0;
			if (!(streamableAssetRef != (UnityEngine.Object)num2))
			{
				UpdateModelCSOld();
			}
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			if (TryGetComponent<ShoppingStall>(out *(ShoppingStall*)num))
			{
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E21")]
		[Cpp2IlInjected.Address(RVA = "0xD3C270", Offset = "0xD3AC70", VA = "0x180D3C270")]
		[AsyncStateMachine(typeof(_003CUpdateModelCSStreamable_003Ed__59))]
		public Task UpdateModelCSStreamable()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E22")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB80", Offset = "0xD3A580", VA = "0x180D3BB80")]
		public void UpdateModelCSOld()
		{
			//Discarded unreachable code: IL_01fb
			//IL_0168: Expected O, but got I4
			//IL_019e: Expected O, but got I4
			//IL_01d0: Expected O, but got I4
			GridObjectScript gridObjectScript = base.GridObjectScript;
			int num = 0;
			if ((object)gridObjectScript != null)
			{
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
				if (_003CGridObject_003Ek__BackingField != null)
				{
					GridState state_ = _003CGridObject_003Ek__BackingField.state_;
					if (state_ != null)
					{
						IGridStateData stateData = state_.StateData;
					}
				}
			}
			BuildingItemType buildingItemType = default(BuildingItemType);
			if (num == 0)
			{
				GridObjectScript gridObjectScript2 = base.GridObjectScript;
				if ((object)gridObjectScript2 != null)
				{
					GridObject _003CGridObject_003Ek__BackingField2 = gridObjectScript2.GridObject;
					if (_003CGridObject_003Ek__BackingField2 != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField2.ItemID;
					}
				}
				bool flag = default(bool);
				if (!flag || buildingItemType != 0)
				{
					refreshing = (byte)num != 0;
					return;
				}
			}
			else if (buildingItemType == BuildingItemType.House)
			{
			}
			bool flag2 = default(bool);
			if (num == 0)
			{
				flag2 = (_isBuildingUnlocked ? 1 : 0) != num;
			}
			int newLevel = (flag2 ? 1 : 0);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Mdl.Online.Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null && client2.MetaClient == null)
				{
				}
			}
			int num2 = liftCurseCondition;
			bool flag3 = default(bool);
			bool flag4 = flag3;
			IBuildingUpgradable upgradableItemData = GetUpgradableItemData();
			bool flag5 = default(bool);
			if (upgradableItemData != null)
			{
				if (upgradableItemData != null)
				{
				}
				flag5 = upgradableItemData == null;
			}
			if (flag4)
			{
				goto IL_01ae;
			}
			if (upgradableItemData != null)
			{
				int num3 = newLevel;
				if (curLevel != num3 || (flag4 ? CurseState.Cursed : CurseState.None) != curseState)
				{
					Func<UpgradeData, bool> func = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData x)
					{
						//Discarded unreachable code: IL_0011
						int num9 = newLevel;
						return x.level_ == num9;
					};
					UpgradeData upgradeData = default(UpgradeData);
					if (upgradeData == null)
					{
						if ((IntPtr)(_isBuildingUnlocked ? 1 : 0) != (IntPtr)upgradeData)
						{
							goto IL_01e3;
						}
						if (!flag5)
						{
							GameObject gameObject = uncursedBaseBuilding;
							int num4 = 0;
							if (!(gameObject != (UnityEngine.Object)num4))
							{
								goto IL_01e3;
							}
						}
					}
					int num5 = default(int);
					if (flag5 && curLevel == -1 && newLevel == 1 && num5 == 1)
					{
						GameObject gameObject2 = uncursedBaseBuilding;
						int num6 = 0;
						if (gameObject2 == (UnityEngine.Object)num6)
						{
							goto IL_01e3;
						}
					}
					string prefabAddress = default(string);
					UpgradeBuildingAssetOld(prefabAddress).FireAndForgetTask();
					goto IL_01ae;
				}
			}
			goto IL_01e3;
			IL_01e3:
			int num7 = (curLevel = newLevel);
			refreshing = false;
			return;
			IL_01ae:
			if (curseState != CurseState.Cursed && !flag5)
			{
				GameObject gameObject3 = cursedBuilding;
				int num8 = 0;
				if (gameObject3 != (UnityEngine.Object)num8)
				{
					GameObject buildingGO = cursedBuilding;
					UpdateModelOld(buildingGO);
				}
			}
			goto IL_01e3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E23")]
		[Cpp2IlInjected.Address(RVA = "0xD3C560", Offset = "0xD3AF60", VA = "0x180D3C560")]
		private void UpdateModelOld(GameObject buildingGO)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(buildingGO == (UnityEngine.Object)num))
			{
				Transform parent = base.transform;
				GameObject newModel = UnityEngine.Object.Instantiate(buildingGO, parent);
				SwapUpgradeModel(newModel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E24")]
		[Cpp2IlInjected.Address(RVA = "0xD39F60", Offset = "0xD38960", VA = "0x180D39F60")]
		private string GetAddressForLevel(int level, RepeatedField<UpgradeData> upgradeData)
		{
			Func<UpgradeData, bool> func = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData x)
			{
				//Discarded unreachable code: IL_001e
				int num = level;
				if (x.level_ > num)
				{
					int num2 = 0;
				}
				string prefabAddress_ = x.prefabAddress_;
				return num == 0;
			};
			UpgradeData upgradeData2 = Enumerable.LastOrDefault<UpgradeData>((IEnumerable<>)(object)upgradeData, (Func<, >)(object)func);
			if (upgradeData2 != null)
			{
				return upgradeData2.prefabAddress_;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E25")]
		[Cpp2IlInjected.Address(RVA = "0xD3B360", Offset = "0xD39D60", VA = "0x180D3B360")]
		[AsyncStateMachine(typeof(_003CRefreshSign_003Ed__64))]
		private Task RefreshSign(int level, RepeatedField<UpgradeData> upgradeData)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E26")]
		[Cpp2IlInjected.Address(RVA = "0xD3B160", Offset = "0xD39B60", VA = "0x180D3B160")]
		private void RefreshDoor()
		{
			//Discarded unreachable code: IL_003b
			//IL_0011: Expected O, but got I4
			EnvironmentDoor componentInChildren = GetComponentInChildren<EnvironmentDoor>(includeInactive: true);
			int num = 0;
			if (!(componentInChildren == (UnityEngine.Object)num))
			{
				if (signLoaded == SignLoaded.Unlock)
				{
					GameObject gameObject = componentInChildren.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				else
				{
					componentInChildren.gameObject.SetActive(value: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E27")]
		[Cpp2IlInjected.Address(RVA = "0xD3B590", Offset = "0xD39F90", VA = "0x180D3B590")]
		private void RemoveSignModel()
		{
			//IL_0024: Expected O, but got I8
			GameObject gameObject = signModel;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			UnityEngine.Object.Destroy(signModel);
			signModel = (GameObject)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E28")]
		[Cpp2IlInjected.Address(RVA = "0xD3A720", Offset = "0xD39120", VA = "0x180D3A720")]
		public int GetLevel()
		{
			//Discarded unreachable code: IL_003a
			GridObjectScript gridObjectScript = base.GridObjectScript;
			if ((object)gridObjectScript != null)
			{
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
				if (_003CGridObject_003Ek__BackingField != null)
				{
					GridState state_ = _003CGridObject_003Ek__BackingField.state_;
					if (state_ != null)
					{
						IGridStateData stateData = state_.StateData;
					}
				}
			}
			int num = 0;
			if (num != 0 && num != 0)
			{
				return num;
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E29")]
		[Cpp2IlInjected.Address(RVA = "0xD3C630", Offset = "0xD3B030", VA = "0x180D3C630")]
		[AsyncStateMachine(typeof(_003CUpgradeBuildingAssetOld_003Ed__68))]
		public Task UpgradeBuildingAssetOld(string prefabAddress)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2A")]
		[Cpp2IlInjected.Address(RVA = "0xD3B650", Offset = "0xD3A050", VA = "0x180D3B650")]
		private void SwapUpgradeModel(GameObject newModel)
		{
			//Discarded unreachable code: IL_0050
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				if (!flag || weakDisableColliderScope == null || flag2)
				{
				}
				upgradeModel = newModel;
				if (weakDisableColliderScope == null || !flag3)
				{
					break;
				}
				GameObject[] array = new GameObject[2];
				GameObject gameObject = base.gameObject;
				if ((object)gameObject == null || (object)gameObject != null)
				{
					array[0] = gameObject;
					if ((object)gameObject != null)
					{
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2B")]
		[Cpp2IlInjected.Address(RVA = "0xD3BA60", Offset = "0xD3A460", VA = "0x180D3BA60")]
		[AsyncStateMachine(typeof(_003CUnlockBuildingFlow_003Ed__70))]
		public Task<UnlockBuilding.Types.Response> UnlockBuildingFlow()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<UnlockBuilding.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2C")]
		[Cpp2IlInjected.Address(RVA = "0xD3C760", Offset = "0xD3B160", VA = "0x180D3C760")]
		[AsyncStateMachine(typeof(_003CUpgradeBuildingFlow_003Ed__71))]
		public Task<UpgradeBuilding.Types.Response> UpgradeBuildingFlow()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<UpgradeBuilding.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2D")]
		[Cpp2IlInjected.Address(RVA = "0xD3A990", Offset = "0xD39390", VA = "0x180D3A990", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			Refresh().FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2E")]
		[Cpp2IlInjected.Address(RVA = "0xD3A810", Offset = "0xD39210", VA = "0x180D3A810", Slot = "8")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__73))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__73(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2F")]
		[Cpp2IlInjected.Address(RVA = "0xD39B50", Offset = "0xD38550", VA = "0x180D39B50")]
		private void CreateCurseEventHandler()
		{
			//IL_001a: Expected O, but got I4
			curseEventHandler?.Dispose();
			int num = 0;
			curseEventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)liftCurseCondition);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnCurseUpdated;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			curseEventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E30")]
		[Cpp2IlInjected.Address(RVA = "0xD39EF0", Offset = "0xD388F0", VA = "0x180D39EF0")]
		private void DisposeCurseEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = curseEventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E31")]
		[Cpp2IlInjected.Address(RVA = "0xD3A880", Offset = "0xD39280", VA = "0x180D3A880")]
		public SignUpdateScope GetUpdateSignScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E32")]
		[Cpp2IlInjected.Address(RVA = "0xD3CBA0", Offset = "0xD3B5A0", VA = "0x180D3CBA0")]
		public UpgradableBuilding()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
