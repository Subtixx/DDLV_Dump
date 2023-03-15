using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.Audio;
using Mdl.Platform;
using Mdl.Platform.Shop;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005AE")]
	public class InGameShopMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20005AF")]
		public enum InGameShopTabType
		{
			[Cpp2IlInjected.Token(Token = "0x4001F80")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x4001F81")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x4001F82")]
			TimeLimited,
			[Cpp2IlInjected.Token(Token = "0x4001F83")]
			BattlePass,
			[Cpp2IlInjected.Token(Token = "0x4001F84")]
			HardCurrency,
			[Cpp2IlInjected.Token(Token = "0x4001F85")]
			ItemShop,
			[Cpp2IlInjected.Token(Token = "0x4001F86")]
			GameUpgrades
		}

		[Cpp2IlInjected.Token(Token = "0x20005B0")]
		internal class InGameShopMenuParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001F87")]
			public InGameShopTabType TabRedirect;

			[Cpp2IlInjected.Token(Token = "0x6002554")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public InGameShopMenuParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001F6D")]
		[SerializeField]
		private CurrencyContent _currencyContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001F6E")]
		[SerializeField]
		private InGameShopContent _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001F6F")]
		[SerializeField]
		private RectTransform _onlineContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001F70")]
		[SerializeField]
		private RectTransform _offlineContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001F71")]
		[SerializeField]
		private TextBase _offlineTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001F72")]
		[SerializeField]
		private BaseButton _btnConnect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001F73")]
		[SerializeField]
		private List<InGameShopTab> _tabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001F74")]
		[SerializeField]
		private float _refreshCoolDownPeriod = 600f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4001F75")]
		[SerializeField]
		private int _maxRefreshAttemptPerPeriod = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001F76")]
		private InGameShopTab _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001F77")]
		private FocusNavigationElement _lastFocusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001F78")]
		private List<OnlineStoreData> _storesData = (List<OnlineStoreData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001F79")]
		internal InGameShopMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001F7A")]
		private bool _isStoreDataInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001F7B")]
		private CancellationToken ct;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001F7C")]
		private int _numOfTries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4001F7D")]
		private bool _isCountingCoolDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001F7E")]
		private float _refreshTimePassed;

		[Cpp2IlInjected.Token(Token = "0x170005C9")]
		public static InGameShopMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6002538")]
			[Cpp2IlInjected.Address(RVA = "0x131FB70", Offset = "0x131E570", VA = "0x18131FB70")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002539")]
			[Cpp2IlInjected.Address(RVA = "0x131FBB0", Offset = "0x131E5B0", VA = "0x18131FBB0")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600253A")]
		[Cpp2IlInjected.Address(RVA = "0x131D5E0", Offset = "0x131BFE0", VA = "0x18131D5E0")]
		private void Awake()
		{
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600253B")]
		[Cpp2IlInjected.Address(RVA = "0x131E890", Offset = "0x131D290", VA = "0x18131E890", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_00eb, IL_00f1, IL_00f7
			int num = 0;
			int num2 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value = OnPopupStackChanged;
			popupStack.OnCurrentMenuChanged += value;
			Button.ButtonClickedEvent onClick = _btnConnect.ButtonComponent.m_OnClick;
			UnityAction call = OnConnectClicked;
			onClick.AddListener(call);
			SystemRoot systemRoot = SystemRoot.Instance;
			if ((object)systemRoot != null && systemRoot.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value2 = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged += value2;
			}
			List<InGameShopTab> tabs = _tabs;
			bool flag = default(bool);
			if (flag)
			{
				InGameShopTab.SelectedTab selectedTab = OnTabSelected;
				UnityAction unityAction = OnTabGamepadClicked;
			}
			SystemRoot systemRoot2 = SystemRoot.Instance;
			if ((object)systemRoot2 != null)
			{
				Client metaClient = systemRoot2.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher.CurrencyChanged value3 = default(ProfileEventDispatcher.CurrencyChanged);
					SystemRoot.Instance.MetaClient.Dispatcher.OnCurrencyChanged += value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600253C")]
		[Cpp2IlInjected.Address(RVA = "0x131F4D0", Offset = "0x131DED0", VA = "0x18131F4D0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_00eb, IL_00f1, IL_00f7
			int num = 0;
			int num2 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value = OnPopupStackChanged;
			popupStack.OnCurrentMenuChanged -= value;
			Button.ButtonClickedEvent onClick = _btnConnect.ButtonComponent.m_OnClick;
			UnityAction call = OnConnectClicked;
			onClick.RemoveListener(call);
			SystemRoot systemRoot = SystemRoot.Instance;
			if ((object)systemRoot != null && systemRoot.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value2 = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged -= value2;
			}
			List<InGameShopTab> tabs = _tabs;
			bool flag = default(bool);
			if (flag)
			{
				InGameShopTab.SelectedTab selectedTab = OnTabSelected;
				UnityAction unityAction = OnTabGamepadClicked;
			}
			SystemRoot systemRoot2 = SystemRoot.Instance;
			if ((object)systemRoot2 != null)
			{
				Client metaClient = systemRoot2.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher.CurrencyChanged value3 = default(ProfileEventDispatcher.CurrencyChanged);
					SystemRoot.Instance.MetaClient.Dispatcher.OnCurrencyChanged -= value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600253D")]
		[Cpp2IlInjected.Address(RVA = "0x131E520", Offset = "0x131CF20", VA = "0x18131E520", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_002e
			//IL_001d: Expected O, but got I4
			base.OnPush(stack, param);
			int num = 0;
			if (param != null)
			{
				int num2 = 0;
				if (param != null)
				{
					int num3 = 0;
				}
			}
			_param = (InGameShopMenuParam)num;
			SystemRoot.Instance.GetSystem<AudioManager>().PushGameState(AudioManager.GameState.MainMenu);
		}

		[Cpp2IlInjected.Token(Token = "0x600253E")]
		[Cpp2IlInjected.Address(RVA = "0x131E3B0", Offset = "0x131CDB0", VA = "0x18131E3B0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0049
			//IL_0017: Expected O, but got I4
			InGameShopContent content = _content;
			InGameShopTab currentTab = content._currentTab;
			int num = 0;
			if (currentTab != (UnityEngine.Object)num && content._currentTab._type == InGameShopTabType.HardCurrency)
			{
				int num2 = 0;
				NativeShopManagerBase nativeShopManager = PlatformInterfaceManager.Instance.NativeShopManager;
				int opened = 0;
				nativeShopManager.OnUIShopStatusChanged((byte)opened != 0);
			}
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x600253F")]
		[Cpp2IlInjected.Address(RVA = "0x131E280", Offset = "0x131CC80", VA = "0x18131E280", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_003f
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			_content.UpdateRedDot();
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002540")]
		[Cpp2IlInjected.Address(RVA = "0x131E0C0", Offset = "0x131CAC0", VA = "0x18131E0C0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_004b
			base.OnFocusIn();
			CurrencyContent currencyContainer = _currencyContainer;
			if (currencyContainer.IsVisible)
			{
				int animated = 0;
				currencyContainer.RefreshAllCurrencies((byte)animated != 0);
			}
			currencyContainer.Show();
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			OnlineClient.OnlineStatus _003CCurrentOnlineStatus_003Ek__BackingField = SystemRoot.Instance.MetaClient.OnlineClient.CurrentOnlineStatus;
			CancellationToken cancellationToken = base.CancellationToken;
		}

		[Cpp2IlInjected.Token(Token = "0x6002541")]
		[Cpp2IlInjected.Address(RVA = "0x131FA70", Offset = "0x131E470", VA = "0x18131FA70")]
		private void Update()
		{
			//IL_0012: Expected F4, but got I4
			//IL_003b: Expected F4, but got I4
			if (!_isCountingCoolDown)
			{
				int num = 0;
				_refreshTimePassed = num;
				return;
			}
			int num2 = 0;
			if (!((_refreshTimePassed = Time.deltaTime) <= _refreshCoolDownPeriod))
			{
				int num3 = 0;
				_isCountingCoolDown = false;
				_refreshTimePassed = num3;
				_numOfTries = num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002542")]
		[Cpp2IlInjected.Address(RVA = "0x131DA40", Offset = "0x131C440", VA = "0x18131DA40")]
		private bool IsCoolingDown()
		{
			if (!(_refreshCoolDownPeriod > _refreshTimePassed))
			{
				int num = 0;
			}
			int maxRefreshAttemptPerPeriod = _maxRefreshAttemptPerPeriod;
			return _numOfTries >= maxRefreshAttemptPerPeriod;
		}

		[Cpp2IlInjected.Token(Token = "0x6002543")]
		[Cpp2IlInjected.Address(RVA = "0x131DA70", Offset = "0x131C470", VA = "0x18131DA70")]
		private bool IsRetrieveConfigRequired()
		{
			//Discarded unreachable code: IL_001f
			List<OnlineStoreData> storesData = _storesData;
			if (storesData == null)
			{
				return true;
			}
			int num = 0;
			int num2 = 0;
			List<InGameShopContent.ContentsPerStore> storeTabContents = (List<InGameShopContent.ContentsPerStore>)(object)InGameShopContent.GetStoreTabContents((List<>)(object)storesData, InGameShopTabType.ItemShop, (byte)num2 != 0, (byte)num != 0);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002544")]
		[Cpp2IlInjected.Address(RVA = "0x131DF40", Offset = "0x131C940", VA = "0x18131DF40")]
		public Task OnContentExpired(bool forceFetch = false, bool ignoreCooldown = false, [Optional] int? addDelayMS)
		{
			//IL_0019: Expected O, but got I4
			List<OnlineStoreData> list = (_storesData = (List<OnlineStoreData>)(object)new List<T>());
			int num = 0;
			return this.RetrieveStoreData(forceFetch, ignoreCooldown, (Nullable<>)addDelayMS, (Nullable<>)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002545")]
		[Cpp2IlInjected.Address(RVA = "0x131EE30", Offset = "0x131D830", VA = "0x18131EE30")]
		[AsyncStateMachine(typeof(_003CRetrieveStoreData_003Ed__35))]
		public Task RetrieveStoreData(bool forceFetch = false, bool ignoreCooldown = false, [Optional] int? addDelayMS, [Optional] int? addDelayForSecondFetchMS)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002546")]
		[Cpp2IlInjected.Address(RVA = "0x131E4B0", Offset = "0x131CEB0", VA = "0x18131E4B0")]
		private void OnPopupStackChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_0037
			int num = 0;
			GameObject gameObject = UiRoot.Instance.MainMenuBar.ShortcutBar.gameObject;
			int num2 = 0;
			bool active = UiRoot.Instance._popupStack.Count <= 0;
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6002547")]
		[Cpp2IlInjected.Address(RVA = "0x131D630", Offset = "0x131C030", VA = "0x18131D630")]
		public void CustomEventsFindNext(FocusDirection direction, int input, FocusNavigationElement element, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_0074
			//IL_002e: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || direction != 0)
			{
				return;
			}
			InGameShopTab selectedTab = _selectedTab;
			int num2 = 0;
			if (selectedTab != (UnityEngine.Object)num2)
			{
				InGameShopTab component = element.GetComponent<InGameShopTab>();
				int num3 = 0;
				if (component == (UnityEngine.Object)num3)
				{
					MenuNavigation menuNavigation = base.MenuNavigation;
					InGameShopTab selectedTab2 = _selectedTab;
					FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
					FocusNavigationElement component2 = selectedTab2.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002548")]
		[Cpp2IlInjected.Address(RVA = "0x131D790", Offset = "0x131C190", VA = "0x18131D790", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_010b
			//IL_0095: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			if (redirectionType > RedirectionType.MainMenuGoToMap)
			{
				if (redirectionType == RedirectionType.MainMenuGoToEvents)
				{
					return;
				}
				if (redirectionType == RedirectionType.MainMenuGoToInGameShop)
				{
					goto IL_00f7;
				}
				if (redirectionType != RedirectionType.GamePopCurrentMenu)
				{
					return;
				}
			}
			if (redirectionType == RedirectionType.MenuNavGoBackward)
			{
				bool activeInHierarchy = _offlineContent.gameObject.activeInHierarchy;
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !activeInHierarchy)
				{
					ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
					int num2 = 0;
					if (focusedElement != null)
					{
						int num3 = 0;
						if (focusedElement == null)
						{
						}
					}
					int num4 = 0;
					if ((UnityEngine.Object)num2 == (UnityEngine.Object)num4)
					{
						InGameShopTab selectedTab = _selectedTab;
						int num5 = 0;
						if (selectedTab != (UnityEngine.Object)num5)
						{
							FocusNavigationElement component = _selectedTab.GetComponent<FocusNavigationElement>();
							int num6 = 0;
							if (component != (UnityEngine.Object)num6)
							{
								MenuNavigation menuNavigation = base.MenuNavigation;
								InGameShopTab selectedTab2 = _selectedTab;
								FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
								FocusNavigationElement component2 = selectedTab2.GetComponent<FocusNavigationElement>();
								focusNavigation.SetFocus(component2);
								return;
							}
						}
					}
				}
				goto IL_00f7;
			}
			if ((long)typeof(UnityEngine.Object).TypeHandle > 3)
			{
			}
			return;
			IL_00f7:
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002549")]
		[Cpp2IlInjected.Address(RVA = "0x131E000", Offset = "0x131CA00", VA = "0x18131E000", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_005c
			//IL_004b: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				InGameShopTab selectedTab = _selectedTab;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				if ((object)selectedTab != null)
				{
					FocusNavigationElement component = selectedTab.GetComponent<FocusNavigationElement>();
				}
				int num2 = 0;
				focusNavigation.InitialFocusedElement = (FocusNavigationElement)num2;
			}
			int focusToContent = 0;
			int ignoreLastFocus = 0;
			SetFocus((byte)ignoreLastFocus != 0, (byte)focusToContent != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600254A")]
		[Cpp2IlInjected.Address(RVA = "0x131EF70", Offset = "0x131D970", VA = "0x18131EF70")]
		public void SetFocus(bool ignoreLastFocus = false, bool focusToContent = false)
		{
			//IL_002b: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			if (!_offlineContent.gameObject.activeInHierarchy)
			{
				FocusNavigationElement focusElement = base.MenuNavigation.GetFocusElement();
				int num = 0;
				bool flag = focusElement == (UnityEngine.Object)num;
				if (base.MenuNavigation.GetFocusElement().gameObject.activeInHierarchy)
				{
					FocusNavigationElement focusElement2 = base.MenuNavigation.GetFocusElement();
					int num2 = 0;
					if (focusElement2 != (UnityEngine.Object)num2 && base.MenuNavigation.GetFocusElement().gameObject.activeInHierarchy)
					{
						FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
						FocusNavigationElement focusElement3 = base.MenuNavigation.GetFocusElement();
						focusNavigation.SetFocus(focusElement3);
					}
					return;
				}
				if (!focusToContent)
				{
					InGameShopTab selectedTab = _selectedTab;
					int num3 = 0;
					if (!(selectedTab != (UnityEngine.Object)num3))
					{
						MenuNavigation menuNavigation = base.MenuNavigation;
						FocusNavigationElement componentInChildren = GetComponentInChildren<FocusNavigationElement>();
					}
					FocusNavigationElement componentInChildren2 = GetComponentInChildren<FocusNavigationElement>();
				}
				InGameShopContent content = _content;
				FocusNavigation focusNavigation2 = base.MenuNavigation.FocusNavigation;
				content.SetFocus(focusNavigation2);
			}
			MenuNavigation menuNavigation2 = base.MenuNavigation;
			FocusNavigationElement component = _btnConnect.GetComponent<FocusNavigationElement>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600254B")]
		[Cpp2IlInjected.Address(RVA = "0x131DC00", Offset = "0x131C600", VA = "0x18131DC00")]
		private void OnConnectionModeChangedImpl(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct, bool calledFromTheOnlineCB)
		{
			//Discarded unreachable code: IL_0117
			//IL_0063: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			GameObject gameObject = _offlineContent.gameObject;
			bool flag = default(bool);
			bool active = !flag;
			gameObject.SetActive(active);
			_onlineContent.gameObject.SetActive(flag);
			TextBase offlineTitle = _offlineTitle;
			string onlineStatusSourceNameForLoc = SystemRoot.Instance.MetaOnlineClient.GetOnlineStatusSourceNameForLoc();
			string stringID = "menu.starpath_offline_" + onlineStatusSourceNameForLoc + "_title";
			int num = 0;
			string text2 = (offlineTitle.Text = LocalizationManager.FromStringID(stringID, (IResolver)num));
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int focusToContent = 0;
				int ignoreLastFocus = 0;
				SetFocus((byte)ignoreLastFocus != 0, (byte)focusToContent != 0);
			}
			InGameShopTab selectedTab = _selectedTab;
			int num3 = 0;
			if (selectedTab != (UnityEngine.Object)num3 && _selectedTab._type == InGameShopTabType.HardCurrency && !flag)
			{
				int num4 = 0;
				NativeShopManagerBase nativeShopManager = PlatformInterfaceManager.Instance.NativeShopManager;
				if (nativeShopManager != null)
				{
					int opened = 0;
					nativeShopManager.OnUIShopStatusChanged((byte)opened != 0);
				}
			}
			if (calledFromTheOnlineCB != flag)
			{
				InGameShopContent content = _content;
				List<OnlineStoreData> storesData = _storesData;
				InGameShopTab selectedTab2 = _selectedTab;
				CancellationToken cancellationToken = base.CancellationToken;
				content.Refresh((List<>)(object)storesData, selectedTab2, cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600254C")]
		[Cpp2IlInjected.Address(RVA = "0x131DF20", Offset = "0x131C920", VA = "0x18131DF20")]
		private void OnConnectionModeChanged(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct)
		{
			OnConnectionModeChangedImpl(currentOnlineStatus, ct, calledFromTheOnlineCB: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600254D")]
		[Cpp2IlInjected.Address(RVA = "0x131DAE0", Offset = "0x131C4E0", VA = "0x18131DAE0")]
		private void OnConnectClicked()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600254E")]
		[Cpp2IlInjected.Address(RVA = "0x131E6D0", Offset = "0x131D0D0", VA = "0x18131E6D0")]
		private void OnTabSelected(InGameShopTab tab)
		{
			//IL_0010: Expected O, but got I4
			InGameShopTab selectedTab = _selectedTab;
			int num = 0;
			if (selectedTab != (UnityEngine.Object)num)
			{
				InGameShopTab selectedTab2 = _selectedTab;
				int num2 = ((selectedTab2.Selected = false) ? 1 : 0);
			}
			_selectedTab = tab;
			if (_isStoreDataInitialized)
			{
				List<OnlineStoreData> storesData = _storesData;
				int num3 = 0;
				if (storesData != null)
				{
					int num4 = 0;
					int num5 = 0;
					List<InGameShopContent.ContentsPerStore> storeTabContents = (List<InGameShopContent.ContentsPerStore>)(object)InGameShopContent.GetStoreTabContents((List<>)(object)storesData, InGameShopTabType.ItemShop, (byte)num5 != 0, (byte)num4 != 0);
				}
				if (_selectedTab._type == InGameShopTabType.ItemShop)
				{
					throw new NullReferenceException();
				}
				InGameShopContent content = _content;
				List<OnlineStoreData> storesData2 = _storesData;
				CancellationToken cancellationToken = base.CancellationToken;
				content.Refresh((List<>)(object)storesData2, tab, cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600254F")]
		[Cpp2IlInjected.Address(RVA = "0x131E6C0", Offset = "0x131D0C0", VA = "0x18131E6C0")]
		private void OnTabGamepadClicked()
		{
			SetFocus(ignoreLastFocus: true, focusToContent: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002550")]
		[Cpp2IlInjected.Address(RVA = "0x131FAE0", Offset = "0x131E4E0", VA = "0x18131FAE0")]
		public InGameShopMenu()
		{
		}//IL_0014: Expected I4, but got I8

	}
}
