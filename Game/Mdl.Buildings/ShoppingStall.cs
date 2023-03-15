using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Characters;
using Mdl.Gestures;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009B4")]
	public class ShoppingStall : Stall
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400358F")]
		public string BuyItemEmployeeEmotion = "Celebrate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4003590")]
		public List<GameObject> Shelves = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4003591")]
		private GameObject[] shelfItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4003592")]
		private CancellationTokenSource ctsAutoRefresh = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4003593")]
		private TapGesture tapGesture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003594")]
		private int _refreshWhileDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4003595")]
		private bool _disableRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4003596")]
		private TaskCompletionSource<bool> waitForEnableTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003599")]
		private bool performingAutoRefresh;

		[Cpp2IlInjected.Token(Token = "0x17000683")]
		public string ShopName
		{
			[Cpp2IlInjected.Token(Token = "0x6002D6F")]
			[Cpp2IlInjected.Address(RVA = "0xF4EE20", Offset = "0xF4D820", VA = "0x180F4EE20")]
			get
			{
				IItemData itemData;
				do
				{
					itemData = base.ItemData;
				}
				while (itemData != null && itemData != null && (object)typeof(StallBuildingItemData).TypeHandle != null);
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000684")]
		internal bool DisableRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6002D70")]
			[Cpp2IlInjected.Address(RVA = "0xE4DF70", Offset = "0xE4C970", VA = "0x180E4DF70")]
			get
			{
				return _disableRefresh;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D71")]
			[Cpp2IlInjected.Address(RVA = "0xF4EFE0", Offset = "0xF4D9E0", VA = "0x180F4EFE0")]
			set
			{
				//IL_002d: Expected I4, but got I8
				if (_disableRefresh == value)
				{
					return;
				}
				_disableRefresh = value;
				if (!value)
				{
					if (_refreshWhileDisabled > 0)
					{
						RefreshShelves();
					}
				}
				else
				{
					_refreshWhileDisabled = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000685")]
		public CurrencyCost RefreshCost
		{
			[Cpp2IlInjected.Token(Token = "0x6002D7F")]
			[Cpp2IlInjected.Address(RVA = "0xF4EB60", Offset = "0xF4D560", VA = "0x180F4EB60")]
			get
			{
				//Discarded unreachable code: IL_0087
				CurrencyCost currencyCost = default(CurrencyCost);
				while (GetShop() != null)
				{
					Profile profile = SystemRoot.Instance.MetaClient.profile;
					GridObject _003CGridObject_003Ek__BackingField = base.GridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField.ItemID;
					}
					Item invalid = Item.Invalid;
					GridObject _003CGridObject_003Ek__BackingField2 = base.GridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField2 != null)
					{
						GridState state_ = _003CGridObject_003Ek__BackingField2.state_;
						if (state_ != null)
						{
							StallData stallData = state_.StallData;
							if (stallData != null && stallData.shopData_ != null)
							{
								goto IL_0079;
							}
						}
					}
					Shop shop = GetShop();
					goto IL_0079;
					IL_0079:
					if (currencyCost == null)
					{
						break;
					}
				}
				return Shop.InvalidRefreshCost;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000686")]
		private ShopData ShopData
		{
			[Cpp2IlInjected.Token(Token = "0x6002D80")]
			[Cpp2IlInjected.Address(RVA = "0xF4EDC0", Offset = "0xF4D7C0", VA = "0x180F4EDC0")]
			get
			{
				//Discarded unreachable code: IL_003b
				StallData stallData;
				do
				{
					GridObject _003CGridObject_003Ek__BackingField = base.GridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField == null)
					{
						break;
					}
					GridState state_ = _003CGridObject_003Ek__BackingField.state_;
					if (state_ == null)
					{
						break;
					}
					stallData = state_.StallData;
				}
				while (stallData != null && stallData.shopData_ != null);
				return GetShop().data_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000070")]
		public event EventHandler<StallShelfInteractionEventArgs> StallShelfInteractionEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002D72")]
			[Cpp2IlInjected.Address(RVA = "0xF4EAC0", Offset = "0xF4D4C0", VA = "0x180F4EAC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002D73")]
			[Cpp2IlInjected.Address(RVA = "0xF4EF40", Offset = "0xF4D940", VA = "0x180F4EF40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000071")]
		public event EventHandler<StallShelfInteractionEventArgs> StallShelfHoverEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002D74")]
			[Cpp2IlInjected.Address(RVA = "0xF4EA20", Offset = "0xF4D420", VA = "0x180F4EA20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002D75")]
			[Cpp2IlInjected.Address(RVA = "0xF4EEA0", Offset = "0xF4D8A0", VA = "0x180F4EEA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D76")]
		[Cpp2IlInjected.Address(RVA = "0xF4E380", Offset = "0xF4CD80", VA = "0x180F4E380", Slot = "4")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_009d
			GridObjectScript gridObjectScript = (base.GridObjectScript = GetComponentInParent<GridObjectScript>());
			CharacterManager characterManager = (base.characterManager = SystemRoot.Instance.GetSystem<CharacterManager>());
			PlayerTaskCollider playerTaskCollider = (base.PlayerTaskCollider = GetComponent<PlayerTaskCollider>());
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
			_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ShopItemsRefreshed value2 = OnShopItemsRefreshed;
			_003CDispatcher_003Ek__BackingField2.OnShopItemsRefreshed += value2;
			GameObject[] array = (shelfItems = new GameObject[((List<>)(object)Shelves)._size]);
			RefreshShelves();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D77")]
		[Cpp2IlInjected.Address(RVA = "0xF4D990", Offset = "0xF4C390", VA = "0x180F4D990")]
		private void OnEnable()
		{
			//IL_0012: Expected O, but got I4
			//IL_001c: Expected O, but got I8
			TaskCompletionSource<bool> taskCompletionSource = waitForEnableTCS;
			if (taskCompletionSource != null)
			{
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)1);
				waitForEnableTCS = (TaskCompletionSource<bool>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D78")]
		[Cpp2IlInjected.Address(RVA = "0xF4D6C0", Offset = "0xF4C0C0", VA = "0x180F4D6C0", Slot = "5")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0095
			//IL_0094: Expected O, but got I8
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.BuildingUnlocked value = OnBuildingUnlocked;
					_003CDispatcher_003Ek__BackingField.OnBuildingUnlocked -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.ShopItemsRefreshed value2 = OnShopItemsRefreshed;
					_003CDispatcher_003Ek__BackingField2.OnShopItemsRefreshed -= value2;
				}
			}
			CancellationTokenSource cancellationTokenSource = ctsAutoRefresh;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				ctsAutoRefresh.Dispose();
				ctsAutoRefresh = (CancellationTokenSource)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D79")]
		[Cpp2IlInjected.Address(RVA = "0xF4D540", Offset = "0xF4BF40", VA = "0x180F4D540", Slot = "6")]
		internal override void Init()
		{
			//Discarded unreachable code: IL_0034
			int _003C_003E1__state = default(int);
			_003CShelfTapDetection_003Ed__24 _003CShelfTapDetection_003Ed__ = new _003CShelfTapDetection_003Ed__24(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShelfTapDetection_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CShelfTapDetection_003Ed__);
			int _003C_003E1__state2 = default(int);
			_003CShelfHoverDetection_003Ed__23 _003CShelfHoverDetection_003Ed__ = new _003CShelfHoverDetection_003Ed__23(_003C_003E1__state2);
			_003C_003E1__state2 = 0;
			_003CShelfHoverDetection_003Ed__._003C_003E4__this = this;
			Coroutine coroutine2 = StartCoroutine(_003CShelfHoverDetection_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7A")]
		[Cpp2IlInjected.Address(RVA = "0xF4E2A0", Offset = "0xF4CCA0", VA = "0x180F4E2A0")]
		[IteratorStateMachine(typeof(_003CShelfHoverDetection_003Ed__23))]
		private IEnumerator ShelfHoverDetection()
		{
			int _003C_003E1__state = default(int);
			_003CShelfHoverDetection_003Ed__23 _003CShelfHoverDetection_003Ed__ = new _003CShelfHoverDetection_003Ed__23(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShelfHoverDetection_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7B")]
		[Cpp2IlInjected.Address(RVA = "0xF4E310", Offset = "0xF4CD10", VA = "0x180F4E310")]
		[IteratorStateMachine(typeof(_003CShelfTapDetection_003Ed__24))]
		private IEnumerator ShelfTapDetection()
		{
			int _003C_003E1__state = default(int);
			_003CShelfTapDetection_003Ed__24 _003CShelfTapDetection_003Ed__ = new _003CShelfTapDetection_003Ed__24(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShelfTapDetection_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7C")]
		[Cpp2IlInjected.Address(RVA = "0xF4D140", Offset = "0xF4BB40", VA = "0x180F4D140")]
		public Shop GetShop()
		{
			if (!string.IsNullOrEmpty(ShopName))
			{
				Client metaClient = SystemRoot.Instance.MetaClient;
				Profile profile = metaClient.profile;
				ProfileWorld world_ = profile.world_;
				if (base.ItemData == null)
				{
				}
				if (metaClient == null)
				{
					goto IL_0056;
				}
				bool flag = default(bool);
				if (flag)
				{
					ProfileWorld world_2 = profile.world_;
					string shopName = ShopName;
					Shop shop = world_2.GetShop(shopName);
				}
			}
			int num = 0;
			goto IL_0056;
			IL_0056:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7D")]
		[Cpp2IlInjected.Address(RVA = "0xF4CE20", Offset = "0xF4B820", VA = "0x180F4CE20")]
		[AsyncStateMachine(typeof(_003CBuyItem_003Ed__26))]
		public Task<ShopBuyItem.Types.Response> BuyItem(GameObject shelf, int amount, CancellationToken ct, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ShopBuyItem.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D7E")]
		[Cpp2IlInjected.Address(RVA = "0xF4E060", Offset = "0xF4CA60", VA = "0x180F4E060")]
		public Task<ShopSellItems.Types.Response> SellItems(List<BackpackItem> items, float sellBonusMultiplier, float sellCapMultiplier, CancellationToken ct)
		{
			//Discarded unreachable code: IL_005b
			//IL_0033: Expected I4, but got O
			Client metaClient = SystemRoot.Instance.MetaClient;
			ShopSellItems.Types.Request request2 = new ShopSellItems.Types.Request();
			IItemData itemData = base.ItemData;
			request2.sellBonusMultiplier_ = sellBonusMultiplier;
			request2.sellCapMultiplier_ = sellCapMultiplier;
			request2.stallItemID_ = (int)request2;
			ShopSellItems.Types.Request request = request2;
			Action<BackpackItem> action = (Action<BackpackItem>)(object)(Action<T>)delegate(BackpackItem x)
			{
				//Discarded unreachable code: IL_0012
				((RepeatedField<T>)(object)request.items_).Add((T)x);
			};
			((List<T>)(object)items).ForEach((Action<>)(object)action);
			TransactionService.TransactionServiceClient transactionService = metaClient.TransactionService;
			Task<ShopSellItems.Types.Response> result = default(Task<ShopSellItems.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D81")]
		[Cpp2IlInjected.Address(RVA = "0xF4D0E0", Offset = "0xF4BAE0", VA = "0x180F4D0E0")]
		public ShopData GetShopData(Shop shop)
		{
			//Discarded unreachable code: IL_0036
			StallData stallData;
			do
			{
				GridObject _003CGridObject_003Ek__BackingField = base.GridObjectScript.GridObject;
				if (_003CGridObject_003Ek__BackingField == null)
				{
					break;
				}
				GridState state_ = _003CGridObject_003Ek__BackingField.state_;
				if (state_ == null)
				{
					break;
				}
				stallData = state_.StallData;
			}
			while (stallData != null && stallData.shopData_ != null);
			return shop.data_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D82")]
		[Cpp2IlInjected.Address(RVA = "0xF4DB20", Offset = "0xF4C520", VA = "0x180F4DB20")]
		public Task<ShopRefresh.Types.Response> RefreshItems(CancellationToken ct, bool force = false, bool buyMissingSoftCurrencyWithHardCurrency = false, bool playerRequested = false)
		{
			//Discarded unreachable code: IL_00b1
			//IL_001f: Expected I4, but got O
			//IL_0046: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			Client metaClient = SystemRoot.Instance.MetaClient;
			ShopRefresh.Types.Request request = new ShopRefresh.Types.Request();
			IItemData itemData = base.ItemData;
			request.stallItemID_ = (int)request;
			request.playerRequested_ = false;
			request.force_ = force;
			request.buyMissingSoftCurrencyWithHardCurrency_ = buyMissingSoftCurrencyWithHardCurrency;
			GridObjectScript gridObjectScript = base.GridObjectScript;
			int num = 0;
			if (gridObjectScript != (UnityEngine.Object)num)
			{
				GridObjectScript gridObjectScript2 = base.GridObjectScript;
				if ((long)gridObjectScript2.GridObject != 0)
				{
					IGrid _003CGrid_003Ek__BackingField = gridObjectScript2.GridScript.Grid;
					int num2 = 0;
					uint num3 = default(uint);
					if (num2 < (int)num3)
					{
						num2 += num2;
						num2++;
					}
					request.gridID_ = (uint?)(object)num2;
					uint iD_ = base.GridObjectScript.GridObject.iD_;
					request.gridObjectID_ = (uint?)(object)num2;
				}
			}
			return (Task<ShopRefresh.Types.Response>)(object)metaClient.TransactionService.ShopRefreshAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D83")]
		[Cpp2IlInjected.Address(RVA = "0xF4CFE0", Offset = "0xF4B9E0", VA = "0x180F4CFE0")]
		public int GetSellCap(float shopSellCapMultiplier)
		{
			//Discarded unreachable code: IL_0025
			Shop shop = GetShop();
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			return shop.GetDailySellLimit(world_, shopSellCapMultiplier);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D84")]
		[Cpp2IlInjected.Address(RVA = "0xF4D410", Offset = "0xF4BE10", VA = "0x180F4D410", Slot = "11")]
		[AsyncStateMachine(typeof(_003CInitShelves_003Ed__35))]
		protected virtual Task InitShelves([Optional] CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D85")]
		[Cpp2IlInjected.Address(RVA = "0xF4D2E0", Offset = "0xF4BCE0", VA = "0x180F4D2E0")]
		[AsyncStateMachine(typeof(_003CInitShelf_003Ed__36))]
		protected Task InitShelf(IItemData itemData, int shelfIndex)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D86")]
		[Cpp2IlInjected.Address(RVA = "0xF4D620", Offset = "0xF4C020", VA = "0x180F4D620")]
		private void OnBuildingUnlocked(Item item, [Optional] List<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0016
			IItemData itemData = base.ItemData;
			if ((object)typeof(Item).TypeHandle != null)
			{
				RefreshShelves();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D87")]
		[Cpp2IlInjected.Address(RVA = "0xF4DA00", Offset = "0xF4C400", VA = "0x180F4DA00")]
		private void OnShopItemsRefreshed(string shopName, Item item, CurrencyCost refreshCost, bool isFreeRefresh)
		{
			//Discarded unreachable code: IL_002a
			string shopName2 = ShopName;
			if (shopName2 == null)
			{
				return;
			}
			if (shopName2 == null)
			{
				IItemData itemData = base.ItemData;
				if (shopName2 == null)
				{
					return;
				}
			}
			if (!performingAutoRefresh)
			{
				RefreshShelves();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D88")]
		[Cpp2IlInjected.Address(RVA = "0xF4DE00", Offset = "0xF4C800", VA = "0x180F4DE00")]
		private void RefreshShelves()
		{
			//Discarded unreachable code: IL_0037
			//IL_001f: Expected O, but got I4
			if (!_disableRefresh && GetShop() != null)
			{
				int num = 0;
				if ((object)this != null)
				{
					ctsAutoRefresh = (CancellationTokenSource)num;
				}
				CancellationTokenSource cancellationTokenSource = (ctsAutoRefresh = new CancellationTokenSource());
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D89")]
		[Cpp2IlInjected.Address(RVA = "0xF4CF90", Offset = "0xF4B990", VA = "0x180F4CF90")]
		private void CancelAutoRefresh()
		{
			//Discarded unreachable code: IL_0005
			if ((object)this == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D8A")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4D130", VA = "0x180F4E730")]
		[AsyncStateMachine(typeof(_003CWaitForNextAutoRefresh_003Ed__42))]
		private Task WaitForNextAutoRefresh(Shop shop, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D8B")]
		[Cpp2IlInjected.Address(RVA = "0xF4E870", Offset = "0xF4D270", VA = "0x180F4E870")]
		public ShoppingStall()
		{
			NeedEmployee = true;
			int num = 0;
			MinDistanceToTeleportEmployee = 10f;
			EmployeeRunKeepDistance = 0.5f;
			base._fadeDurationInSeconds = 0.5f;
			base.navMeshCheckDistance = 0.5f;
			ControlMaps = new int[num];
			ToEnableWhenInteracting = (List<GameObject>)(object)new List<T>();
			ToDisableWhenInteracting = (List<GameObject>)(object)new List<T>();
			((MonoBehaviour)this)._002Ector();
		}
	}
}
