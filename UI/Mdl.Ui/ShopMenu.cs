using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using Meta.Tracking;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006D2")]
	public class ShopMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20006D3")]
		public enum ShopMenuTabs
		{
			[Cpp2IlInjected.Token(Token = "0x4002694")]
			Home,
			[Cpp2IlInjected.Token(Token = "0x4002695")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x4002696")]
			Gem,
			[Cpp2IlInjected.Token(Token = "0x4002697")]
			Gacha,
			[Cpp2IlInjected.Token(Token = "0x4002698")]
			Currency,
			[Cpp2IlInjected.Token(Token = "0x4002699")]
			Length
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400267E")]
		private ShopMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400267F")]
		private ShopMenuTabs _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002680")]
		private List<Item> _currencyItemsRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002681")]
		private List<Item> _currencyItemsLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002682")]
		private Dictionary<ShopMenuTabs, List<ShopProductModel>> _products;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002683")]
		public List<CanvasGroup> McShopTabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002684")]
		public List<SubmenuNotificationButton> McShopTabButtons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002685")]
		[SerializeField]
		private ShopBundleLayoutMaker _bundleLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002686")]
		[SerializeField]
		private ListBase _listCurrencyRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002687")]
		[SerializeField]
		private ListBase _listCurrencyLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002688")]
		[SerializeField]
		private List<ShopContentDefault> _listShopContents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002689")]
		[SerializeField]
		private RedDot _mcRedDotBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400268A")]
		[SerializeField]
		private RedDot _mcRedDotGacha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400268B")]
		private ShopContentDefault _mcCurrentContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400268C")]
		[SerializeField]
		private SlidingPanel _mcSubTabSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400268D")]
		[SerializeField]
		private GameObject _prefabRewardAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400268E")]
		[Space]
		public ShopMenuTabs DefaultTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400268F")]
		[SerializeField]
		private State AudioMenuStateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4002690")]
		[SerializeField]
		private State AudioMenuStateOff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4002691")]
		public UnityEvent OnMenuNavigationBlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4002692")]
		public UnityEvent OnSubMenuTabBlocked;

		[Cpp2IlInjected.Token(Token = "0x6002BC5")]
		[Cpp2IlInjected.Address(RVA = "0x14295C0", Offset = "0x1427FC0", VA = "0x1814295C0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0055
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (ShopMenuParam)param;
				}
			}
			ShopMenuParam param2 = _param;
			if (param2 != null)
			{
				bool flag = (PreventPausingCamera = param2.BlockMenuNavgation);
				bool flag2 = (PreventPausingPlayerNavigation = param2.BlockMenuNavgation);
			}
			base.OnPush(stack, param);
			SystemRoot.Instance.GetSystem<AudioManager>().PushGameState(AudioManager.GameState.MainMenu);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC6")]
		[Cpp2IlInjected.Address(RVA = "0xE1A830", Offset = "0xE19230", VA = "0x180E1A830", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC7")]
		[Cpp2IlInjected.Address(RVA = "0x14293C0", Offset = "0x1427DC0", VA = "0x1814293C0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0018
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			base.OnFocusOut(popAfterFocusOut, animate: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC8")]
		[Cpp2IlInjected.Address(RVA = "0x1429090", Offset = "0x1427A90", VA = "0x181429090", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0172
			int _003C_003E1__state = default(int);
			while (true)
			{
				base.OnFocusIn();
				List<Item> currencyItemsRight = (List<Item>)(object)new List<T>();
				int num = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				int num2 = 0;
				Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
				_currencyItemsRight = currencyItemsRight;
				List<Item> currencyItemsLeft = (List<Item>)(object)new List<T>();
				int num3 = 0;
				Item dreamDustCurrencyItem = CurrencyItem.DreamDustCurrencyItem;
				int num4 = 0;
				Item socialCurrencyItem = CurrencyItem.SocialCurrencyItem;
				_currencyItemsLeft = currencyItemsLeft;
				List<Item> currencyItemsRight2 = _currencyItemsRight;
				ListBase listCurrencyRight = _listCurrencyRight;
				int num5 = (listCurrencyRight.TotalCount = ((List<>)(object)currencyItemsRight2)._size);
				List<Item> currencyItemsLeft2 = _currencyItemsLeft;
				ListBase listCurrencyLeft = _listCurrencyLeft;
				int num6 = (listCurrencyLeft.TotalCount = ((List<>)(object)currencyItemsLeft2)._size);
				ShopMenuParam param = _param;
				if (param != null)
				{
					ShopMenuTabs shopMenuTabs = (DefaultTab = param.ShopMenuTab);
				}
				ShopMenuTabs defaultTab = DefaultTab;
				RefreshTabs(defaultTab);
				int num7 = 0;
				Dictionary<ShopMenuTabs, List<ShopProductModel>> dictionary = (_products = (Dictionary<ShopMenuTabs, List<ShopProductModel>>)(object)FakeData.Instance.GetFakeShopData(true));
				ShopMenuTabs defaultTab2 = DefaultTab;
				RefreshDisplay(defaultTab2);
				((Menu)this).IsDataUpToDate = true;
				_mcSubTabSlider.Show(andOpen: true);
				RefreshRedDots();
				StopAllCoroutines();
				_003COnRepeat_003Ed__40 _003COnRepeat_003Ed__ = new _003COnRepeat_003Ed__40(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003COnRepeat_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003COnRepeat_003Ed__);
				ShopMenuParam param2 = _param;
				if (param2 == null)
				{
					break;
				}
				if (!param2.BlockMenuNavgation)
				{
					continue;
				}
				UnityEvent onMenuNavigationBlocked = OnMenuNavigationBlocked;
				if (onMenuNavigationBlocked != null)
				{
					onMenuNavigationBlocked.Invoke();
					if (_param.BlockSubMenuTab)
					{
						OnSubMenuTabBlocked?.Invoke();
					}
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC9")]
		[Cpp2IlInjected.Address(RVA = "0x1429A10", Offset = "0x1428410", VA = "0x181429A10", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__26))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__26 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__26(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BCA")]
		[Cpp2IlInjected.Address(RVA = "0x142A4A0", Offset = "0x1428EA0", VA = "0x18142A4A0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_006f
			((object)this)._002Ector();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged += value;
			ListBase.ListEvents onItemData = _listCurrencyLeft.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemLeftDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemData2 = _listCurrencyRight.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemRightDataHandler);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BCB")]
		[Cpp2IlInjected.Address(RVA = "0x142A7A0", Offset = "0x14291A0", VA = "0x18142A7A0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0075
			base.UnregisterFocusedListeners();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged -= value;
			ListBase.ListEvents onItemData = _listCurrencyLeft.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemLeftDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemData2 = _listCurrencyRight.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemRightDataHandler);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction2);
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BCC")]
		[Cpp2IlInjected.Address(RVA = "0x14294B0", Offset = "0x1427EB0", VA = "0x1814294B0", Slot = "34")]
		internal override void OnLayoutChange()
		{
			//Discarded unreachable code: IL_0087, IL_0088
			base.OnLayoutChange();
			UnregisterFocusedListeners();
			RegisterFocusedListeners();
			List<Item> currencyItemsLeft = _currencyItemsLeft;
			ListBase listCurrencyLeft = _listCurrencyLeft;
			int num = (listCurrencyLeft.TotalCount = ((List<>)(object)currencyItemsLeft)._size);
			List<Item> currencyItemsRight = _currencyItemsRight;
			ListBase listCurrencyRight = _listCurrencyRight;
			int num2 = (listCurrencyRight.TotalCount = ((List<>)(object)currencyItemsRight)._size);
			ShopMenuTabs selectedTab = _selectedTab;
			RefreshTabs(selectedTab);
			int num3 = 0;
			Dictionary<ShopMenuTabs, List<ShopProductModel>> dictionary = (_products = (Dictionary<ShopMenuTabs, List<ShopProductModel>>)(object)FakeData.Instance.GetFakeShopData(true));
			ShopMenuTabs selectedTab2 = _selectedTab;
			RefreshDisplay(selectedTab2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BCD")]
		[Cpp2IlInjected.Address(RVA = "0x142A210", Offset = "0x1428C10", VA = "0x18142A210")]
		private void RefreshTabs(ShopMenuTabs selectedTab)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BCE")]
		[Cpp2IlInjected.Address(RVA = "0x1429A90", Offset = "0x1428490", VA = "0x181429A90")]
		private void RefreshData()
		{
			int num = 0;
			Dictionary<ShopMenuTabs, List<ShopProductModel>> dictionary = (_products = (Dictionary<ShopMenuTabs, List<ShopProductModel>>)(object)FakeData.Instance.GetFakeShopData(true));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BCF")]
		[Cpp2IlInjected.Address(RVA = "0x1429AD0", Offset = "0x14284D0", VA = "0x181429AD0")]
		public void RefreshDisplay(ShopMenuTabs shopMenuTabs)
		{
			//Discarded unreachable code: IL_00ed
			//IL_00e1: Expected O, but got I4
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			Dictionary<ShopMenuTabs, List<ShopProductModel>> products = _products;
			Dictionary<ShopMenuTabs, List<ShopProductModel>> products2 = _products;
			List<ShopProductModel> list = default(List<ShopProductModel>);
			ShopProductModel shopProductModel = Enumerable.First<ShopProductModel>((IEnumerable<>)list);
			if (shopProductModel != null)
			{
				int num = 0;
				if (shopProductModel != null)
				{
					Dictionary<ShopMenuTabs, List<ShopProductModel>> products3 = _products;
					Predicate<ShopProductModel> predicate = (Predicate<ShopProductModel>)(object)(Predicate<T>)delegate(ShopProductModel x)
					{
						//Discarded unreachable code: IL_0010, IL_0016, IL_0019
						int num3 = 0;
						int num4 = 0;
						if (x != null)
						{
							int num5 = 0;
							if (x != null)
							{
								return true;
							}
						}
						throw new InvalidCastException();
					};
					List<ShopProductModel> list2 = default(List<ShopProductModel>);
					List<ShopProductModel> list3 = (List<ShopProductModel>)(object)((List<T>)(object)list2).FindAll((Predicate<>)(object)predicate);
					throw new NullReferenceException();
				}
			}
			Dictionary<ShopMenuTabs, List<ShopProductModel>> products4 = _products;
			ShopContentDefault mcCurrentContent = _mcCurrentContent;
			List<ShopProductItemCustomizedBundleTemplate> bundleTemplates = _bundleLayout.Template.BundleTemplates;
			List<ShopProductModel> list4 = default(List<ShopProductModel>);
			mcCurrentContent.RefreshData((List<>)(object)list4, (List<>)(object)bundleTemplates);
			_mcCurrentContent.RefreshDisplay();
			if ((long)base.MenuNavigation.FocusNavigation._focusedElement != 0)
			{
				ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num2 = 0;
				focusNavigation.FocusedElement = (ISupportsFocusNavigation)num2;
			}
			int focus = 0;
			SetFocus((byte)focus != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD0")]
		[Cpp2IlInjected.Address(RVA = "0x142A6C0", Offset = "0x14290C0", VA = "0x18142A6C0")]
		private void SetFocus(bool removeFocus = false)
		{
			//Discarded unreachable code: IL_0058
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && (long)base.MenuNavigation.FocusNavigation._focusedElement == 0)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				ShopContentDefault mcCurrentContent = _mcCurrentContent;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				ShopProductItemDefault componentInChildren = mcCurrentContent._mcProductGroupsHolder.GetComponentInChildren<ShopProductItemDefault>();
				focusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD1")]
		[Cpp2IlInjected.Address(RVA = "0x1428A70", Offset = "0x1427470", VA = "0x181428A70")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			ListBase listCurrencyLeft = _listCurrencyLeft;
			int num = 0;
			if (num < listCurrencyLeft._totalCount)
			{
				FreemiumCurrencyItem component = listCurrencyLeft.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>();
				if ((object)component.CurrencyItem == null)
				{
					ListBase listCurrencyLeft2 = _listCurrencyLeft;
					num++;
				}
				Client client = default(Client);
				ProfilePlayer player_ = client.Profile.player_;
				int animatedAmount = default(int);
				component.AnimatedAmount = animatedAmount;
				return;
			}
			ListBase listCurrencyRight = _listCurrencyRight;
			while (num >= listCurrencyRight._totalCount)
			{
			}
			if ((object)listCurrencyRight.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>().CurrencyItem == null)
			{
				ListBase listCurrencyRight2 = _listCurrencyRight;
				num++;
				while ((object)listCurrencyRight2 != null)
				{
				}
			}
			Client client2 = default(Client);
			ProfilePlayer player_2 = client2.Profile.player_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD2")]
		[Cpp2IlInjected.Address(RVA = "0x14297E0", Offset = "0x14281E0", VA = "0x1814297E0")]
		public void OnTabClicked(int tabIndex)
		{
			//Discarded unreachable code: IL_0018
			int num = 0;
			if (TrackingManager.Instance != null)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD3")]
		[Cpp2IlInjected.Address(RVA = "0x1428A40", Offset = "0x1427440", VA = "0x181428A40", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			int focus = 0;
			SetFocus((byte)focus != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD4")]
		[Cpp2IlInjected.Address(RVA = "0xF2E840", Offset = "0xF2D240", VA = "0x180F2E840")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_001e
			AK.Wwise.Event @event = closeSFX;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD5")]
		[Cpp2IlInjected.Address(RVA = "0x1428D30", Offset = "0x1427730", VA = "0x181428D30")]
		private void OnCurrencyItemLeftDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD6")]
		[Cpp2IlInjected.Address(RVA = "0x1428EE0", Offset = "0x14278E0", VA = "0x181428EE0")]
		private void OnCurrencyItemRightDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD7")]
		[Cpp2IlInjected.Address(RVA = "0x1429770", Offset = "0x1428170", VA = "0x181429770")]
		[IteratorStateMachine(typeof(_003COnRepeat_003Ed__40))]
		private IEnumerator OnRepeat()
		{
			int _003C_003E1__state = default(int);
			_003COnRepeat_003Ed__40 _003COnRepeat_003Ed__ = new _003COnRepeat_003Ed__40(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRepeat_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD8")]
		[Cpp2IlInjected.Address(RVA = "0x1429EB0", Offset = "0x14288B0", VA = "0x181429EB0")]
		private void RefreshRedDots()
		{
			//Discarded unreachable code: IL_00ad
			//IL_005f: Expected I4, but got I8
			Dictionary<ShopMenuTabs, List<ShopProductModel>> products = _products;
			Func<ShopProductModel, int> _003C_003E9__41_ = _003C_003Ec._003C_003E9__41_0;
			if (_003C_003E9__41_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ShopProductModel x)
				{
					if (x != null)
					{
						int num7 = 0;
						if (x != null)
						{
							int num8 = 0;
							if (x != null)
							{
								int num9 = 0;
								if (x != null)
								{
									int num10 = default(int);
									if (num10 <= 0)
									{
										goto IL_002b;
									}
									int num11 = 0;
									if (x != null)
									{
										int num12 = 0;
										int result2 = default(int);
										if (x != null)
										{
											return result2;
										}
										throw new InvalidCastException();
									}
								}
							}
							throw new InvalidCastException();
						}
					}
					goto IL_002b;
					IL_002b:
					return 0;
				};
			}
			List<ShopProductModel> list = default(List<ShopProductModel>);
			int num = Enumerable.Sum<ShopProductModel>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__41_);
			RedDot mcRedDotBundle = _mcRedDotBundle;
			GameObject gameObject = mcRedDotBundle.gameObject;
			string text = default(string);
			mcRedDotBundle.TextBase.Text = text;
			ulong num2 = default(ulong);
			_mcRedDotBundle.gameObject.SetActive((byte)num2 != 0);
			Dictionary<ShopMenuTabs, List<ShopProductModel>> products2 = _products;
			Func<ShopProductModel, int> func = default(Func<ShopProductModel, int>);
			if (_003C_003Ec._003C_003E9__41_1 == null)
			{
				func = (Func<ShopProductModel, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ShopProductModel x)
				{
					if (x != null)
					{
						int num4 = 0;
						if (x != null)
						{
							int num5 = 0;
							if (x != null)
							{
								int num6 = 0;
								int result = default(int);
								if (x != null)
								{
									return result;
								}
								throw new InvalidCastException();
							}
							throw new InvalidCastException();
						}
					}
					return 0;
				});
			}
			List<ShopProductModel> list2 = default(List<ShopProductModel>);
			int num3 = Enumerable.Sum<ShopProductModel>((IEnumerable<>)list2, (Func<, >)(object)func);
			GameObject gameObject2 = _mcRedDotGacha.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD9")]
		[Cpp2IlInjected.Address(RVA = "0x1428980", Offset = "0x1427380", VA = "0x181428980", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0058
			switch (redirectionType)
			{
			case RedirectionType.GameTabRight:
				if (_selectedTab >= ShopMenuTabs.Length)
				{
				}
				break;
			case RedirectionType.MenuShopToggle:
			case RedirectionType.MenuNavGoBackward:
			case RedirectionType.GamePopCurrentMenu:
			{
				AK.Wwise.Event @event = closeSFX;
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
				PopSelf();
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BDA")]
		[Cpp2IlInjected.Address(RVA = "0x1428260", Offset = "0x1426C60", VA = "0x181428260")]
		public void DebugPlayRewardAnimation(ItemReward itemReward, GameObject source, bool doTransaction)
		{
			//Discarded unreachable code: IL_015a, IL_0160, IL_0166, IL_016c, IL_0172, IL_0178, IL_0184, IL_0190, IL_0196, IL_019c, IL_01a2, IL_01ae
			//IL_0024: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_00d2: Expected O, but got I4
			//IL_0120: Expected O, but got I4
			FreemiumCurrencyItem freemiumCurrencyItem2 = default(FreemiumCurrencyItem);
			ulong num5 = default(ulong);
			IEnumerator enumerator2 = default(IEnumerator);
			FreemiumCurrencyItem freemiumCurrencyItem4 = default(FreemiumCurrencyItem);
			GameObject gameObject2 = default(GameObject);
			GameObject gameObject3 = default(GameObject);
			Transform transform2 = default(Transform);
			Transform transform3 = default(Transform);
			while (true)
			{
				int num = 0;
				FreemiumCurrencyItem freemiumCurrencyItem = (FreemiumCurrencyItem)num;
				int num2 = 0;
				IEnumerator enumerator = _listCurrencyLeft.m_Content.GetEnumerator();
				if (enumerator != null)
				{
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					freemiumCurrencyItem = freemiumCurrencyItem2;
					FreemiumCurrencyItem freemiumCurrencyItem3 = freemiumCurrencyItem;
					int num4 = 0;
					if (!(freemiumCurrencyItem3 != (UnityEngine.Object)num4))
					{
						continue;
					}
					Item currencyItem = freemiumCurrencyItem.CurrencyItem;
					if ((object)itemReward.Item == null)
					{
						continue;
					}
					GameObject gameObject = freemiumCurrencyItem.mc_icon.gameObject;
				}
				if (num != 0)
				{
				}
				if (num == 0)
				{
					if (num5 == 0)
					{
						if (enumerator2 != null)
						{
							int num6 = 0;
							if (enumerator2 == null)
							{
								break;
							}
							freemiumCurrencyItem = freemiumCurrencyItem4;
							FreemiumCurrencyItem freemiumCurrencyItem5 = freemiumCurrencyItem;
							int num7 = 0;
							if (!(freemiumCurrencyItem5 != (UnityEngine.Object)num7))
							{
								continue;
							}
							Item currencyItem2 = freemiumCurrencyItem.CurrencyItem;
							if ((object)itemReward.Item == null)
							{
								continue;
							}
							gameObject2 = freemiumCurrencyItem.mc_icon.gameObject;
						}
						if ((object)gameObject2 != null)
						{
						}
						if (num != 0)
						{
							continue;
						}
					}
					int num8 = 0;
					if (!(gameObject2 != (UnityEngine.Object)num8))
					{
						return;
					}
					ShopProductItemRewardAnimation component = gameObject3.GetComponent<ShopProductItemRewardAnimation>();
					Transform transform = gameObject2.transform;
					Action action = delegate
					{
						//Discarded unreachable code: IL_0034
						if (doTransaction)
						{
							ItemReward itemReward2 = itemReward;
							ShopMenu shopMenu = this;
							FreemiumCurrencyItem freemiumCurrencyItem6 = freemiumCurrencyItem;
							CancellationToken cancellationToken = shopMenu.CancellationToken;
							shopMenu.DebugDoFakeRewardTransaction(itemReward2, freemiumCurrencyItem6, cancellationToken).FireAndForgetTask();
						}
					};
					if ((object)transform2 != null)
					{
					}
					if ((object)transform != null)
					{
					}
					if ((object)transform3 != null)
					{
					}
					component.Play();
					return;
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BDB")]
		[Cpp2IlInjected.Address(RVA = "0x1428190", Offset = "0x1426B90", VA = "0x181428190")]
		[AsyncStateMachine(typeof(_003CDebugDoFakeRewardTransaction_003Ed__44))]
		private Task DebugDoFakeRewardTransaction(ItemReward itemReward, FreemiumCurrencyItem freemiumCurrencyItem, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BDC")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF70", Offset = "0xE19970", VA = "0x180E1AF70")]
		public ShopMenu()
		{
		}
	}
}
