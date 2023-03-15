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
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using Meta.Online;
using Meta.Social;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000647")]
	public class PhoneMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000648")]
		public class PhoneMenuParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400233A")]
			public int DefaultTab;

			[Cpp2IlInjected.Token(Token = "0x60028F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public PhoneMenuParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000649")]
		public class PhoneCategoryData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400233B")]
			public Sprite icon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400233C")]
			public Sprite selectedIcon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400233D")]
			public PhoneCategory category;

			[Cpp2IlInjected.Token(Token = "0x60028F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PhoneCategoryData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200064A")]
		public enum PhoneCategory
		{
			[Cpp2IlInjected.Token(Token = "0x400233F")]
			NewsFeed,
			[Cpp2IlInjected.Token(Token = "0x4002340")]
			DesighChallenge,
			[Cpp2IlInjected.Token(Token = "0x4002341")]
			Vote,
			[Cpp2IlInjected.Token(Token = "0x4002342")]
			Search,
			[Cpp2IlInjected.Token(Token = "0x4002343")]
			Profile
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400232A")]
		[SerializeField]
		private ListBase _categoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400232B")]
		[SerializeField]
		private PhoneCategoryData[] _categoryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400232C")]
		[SerializeField]
		private PhoneNewsFeedTabContent _mcNewsFeedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400232D")]
		[SerializeField]
		private PhoneSearchTabContent _mcSearchContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400232E")]
		[SerializeField]
		private PhoneProfileTabContent _mcProfileContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400232F")]
		[SerializeField]
		private SlidingPanel _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002330")]
		[SerializeField]
		private AudioManager.Location location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002331")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002332")]
		[SerializeField]
		private ListBase _listCurrencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002333")]
		[SerializeField]
		private Image _categorySelectedBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002334")]
		[SerializeField]
		private RedDot _mcProfileNotification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002335")]
		[SerializeField]
		private AsyncMenu _wardrobemenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002336")]
		private PhoneMenuParam _phoneMenuParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4002338")]
		private int defaultTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002339")]
		[SerializeField]
		private TextBase _tfVersion;

		[Cpp2IlInjected.Token(Token = "0x17000625")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x138"), Cpp2IlInjected.Token(Token = "0x4002337")]
		public bool ForceUpdateOnFocusIn
		{
			[Cpp2IlInjected.Token(Token = "0x60028E0")]
			[Cpp2IlInjected.Address(RVA = "0x9B9B00", Offset = "0x9B8500", VA = "0x1809B9B00")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60028E1")]
			[Cpp2IlInjected.Address(RVA = "0x9B9B10", Offset = "0x9B8510", VA = "0x1809B9B10")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x60028E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B91B0", Offset = "0x9B7BB0", VA = "0x1809B91B0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_013e
			//IL_00f2: Expected O, but got I4
			RefreshVersionInfo();
			ListBase.ListEvents onItemData = _categoryList.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategorItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemSelect = _categoryList.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategorItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemDeselect = _categoryList.m_OnItemDeselect;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategorItemSelectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).AddListener((UnityAction<>)(object)unityAction3);
			ListBase.ListEvents onItemData2 = _listCurrencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction4);
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.AddListener(call);
			PhoneProfileTabContent mcProfileContent = _mcProfileContent;
			PhoneProfileTabContent.RefreshRequestedDelegate refreshRequested = mcProfileContent.RefreshRequested;
			PhoneProfileTabContent.RefreshRequestedDelegate b = RefreshNotification;
			Delegate @delegate = Delegate.Combine(refreshRequested, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				mcProfileContent.RefreshRequested = (PhoneProfileTabContent.RefreshRequestedDelegate)num;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
				_003CDispatcher_003Ek__BackingField.OnCurrencyChanged += value;
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value2 = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged += value2;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B9650", Offset = "0x9B8050", VA = "0x1809B9650", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_013e
			//IL_00f2: Expected O, but got I4
			RefreshVersionInfo();
			ListBase.ListEvents onItemData = _categoryList.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategorItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemSelect = _categoryList.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategorItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemDeselect = _categoryList.m_OnItemDeselect;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCategorItemSelectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).RemoveListener((UnityAction<>)(object)unityAction3);
			ListBase.ListEvents onItemData2 = _listCurrencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction4);
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.RemoveListener(call);
			PhoneProfileTabContent mcProfileContent = _mcProfileContent;
			PhoneProfileTabContent.RefreshRequestedDelegate refreshRequested = mcProfileContent.RefreshRequested;
			PhoneProfileTabContent.RefreshRequestedDelegate value = RefreshNotification;
			Delegate @delegate = Delegate.Remove(refreshRequested, value);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				mcProfileContent.RefreshRequested = (PhoneProfileTabContent.RefreshRequestedDelegate)num;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
				_003CDispatcher_003Ek__BackingField.OnCurrencyChanged -= value2;
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value3 = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged -= value3;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B89C0", Offset = "0x9B73C0", VA = "0x1809B89C0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_002f
			SystemRoot.Instance.GetSystem<PlayerNavigation>().ResumeSystem();
			SystemRoot.Instance.GetSystem<AudioManager>().PopLocation();
			base.OnPop();
			SystemRoot.Instance.StopSystem<Mdl.Avatar.AvatarCustomization>();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8430", Offset = "0x9B6E30", VA = "0x1809B8430", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0125
			int num;
			string[] array;
			while (true)
			{
				base.OnFocusIn();
				_slider.Show(andOpen: true);
				_listCurrencyItems.GetComponent<SlidingPanel>()?.Show(andOpen: true);
				num = 0;
				int num2 = defaultTab;
				ListBase categoryList = _categoryList;
				int num3 = num2 - 1;
				categoryList.SelectedIndex = num;
				array = new string[0];
				if ("Heart" != null && "Heart" == null)
				{
					continue;
				}
				array[0] = "Heart";
				if ("Ticket" == null || "Ticket" != null)
				{
					array[1] = "Ticket";
					if ("Gem" == null || "Gem" != null)
					{
						break;
					}
				}
			}
			array[2] = "Gem";
			string[] currencyNames = array;
			ListBase listCurrencyItems = _listCurrencyItems;
			List<IItemData> list = (List<IItemData>)(object)Enumerable.ToList<IItemData>(ItemDatabase.Instance.GetAllByType(ItemType.Currency));
			Predicate<IItemData> predicate = (Predicate<IItemData>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_000d
				//IL_000d: Expected I4, but got O
				string[] array2 = currencyNames;
				return (byte)(int)typeof(IItemData).TypeHandle != 0;
			};
			int num4 = (listCurrencyItems.TotalCount = ((List<T>)(object)list).FindAll((Predicate<>)(object)predicate)._size);
			base.IsDataUpToDate = true;
			if ((ForceUpdateOnFocusIn ? 1 : 0) != num)
			{
				ForceUpdateOnFocusIn = (byte)num != 0;
			}
			CancellationToken cancellationToken = base.CancellationToken;
			int num5 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E6")]
		[Cpp2IlInjected.Address(RVA = "0x9B9040", Offset = "0x9B7A40", VA = "0x1809B9040")]
		private void RefreshNotification()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8F20", Offset = "0x9B7920", VA = "0x1809B8F20")]
		[AsyncStateMachine(typeof(_003CRefreshNotificationTask_003Ed__27))]
		private Task RefreshNotificationTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60028E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8EA0", Offset = "0x9B78A0", VA = "0x1809B8EA0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__28))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__28 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__28(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B90", Offset = "0x9B7590", VA = "0x1809B8B90", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_011d
			base.OnPush(stack, param);
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			AudioManager.Location location = this.location;
			system.PushLocation(location);
			PhoneNewsFeedTabContent mcNewsFeedContent = _mcNewsFeedContent;
			CancellationToken cancellationToken = (mcNewsFeedContent.CancellationToken = base.CancellationToken);
			GameObject gameObject = _mcNewsFeedContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			PhoneProfileTabContent mcProfileContent = _mcProfileContent;
			CancellationToken cancellationToken2 = (mcProfileContent.CancellationToken = base.CancellationToken);
			GameObject gameObject2 = _mcProfileContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			PhoneSearchTabContent mcSearchContent = _mcSearchContent;
			CancellationToken cancellationToken3 = (mcSearchContent.CancellationToken = base.CancellationToken);
			GameObject gameObject3 = _mcSearchContent.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			PhoneCategoryData[] categoryData = _categoryData;
			ListBase categoryList = _categoryList;
			int num = (categoryList.TotalCount = categoryData.Length);
			if (param != null)
			{
				if ((object)"{il2cpp array field local35->}" == (object)typeof(PhoneMenuParam).TypeHandle)
				{
				}
				int num2 = 0;
				if (param != null)
				{
					int num3 = 0;
					_phoneMenuParam = (PhoneMenuParam)param;
					int num4 = (defaultTab = _phoneMenuParam.DefaultTab);
				}
			}
			_tfVersion.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60028EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B7DA0", Offset = "0x9B67A0", VA = "0x1809B7DA0")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_004a
			ListBase listCurrencyItems = _listCurrencyItems;
			int num = 0;
			if (num < listCurrencyItems._totalCount)
			{
				FreemiumCurrencyItem component = listCurrencyItems.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>();
				if ((object)component.CurrencyItem == null)
				{
					ListBase listCurrencyItems2 = _listCurrencyItems;
					num++;
				}
				Mdl.Online.Client client = default(Mdl.Online.Client);
				ProfilePlayer player_ = client.Profile.player_;
				int animatedAmount = default(int);
				component.AnimatedAmount = animatedAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void RefreshVersionInfo()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnConnectionModeChanged(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F30", Offset = "0x9B6930", VA = "0x1809B7F30")]
		private void OnCurrencyItemDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028EE")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnCloseClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60028EF")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A00", Offset = "0x9B6400", VA = "0x1809B7A00")]
		private void OnCategorItemSelectHandler(ListBase.ListEventData args)
		{
			//Discarded unreachable code: IL_0154
			//IL_0015: Expected O, but got I4
			//IL_012d: Expected F4, but got I8
			PhoneCategoryItem component = args.DisplayObject.GetComponent<PhoneCategoryItem>();
			int num = 0;
			if (component == (UnityEngine.Object)num)
			{
				return;
			}
			int num2 = 0;
			VibrationsManager.TriggerSelection();
			ListBase categoryList = _categoryList;
			int itemIndex = args.ItemIndex;
			int selectedIndex = categoryList.SelectedIndex;
			SpriteAtlasImage icon = component._icon;
			bool flag = (component._isSelected = itemIndex == selectedIndex);
			PhoneCategoryData categoryData = component._categoryData;
			if (itemIndex == selectedIndex)
			{
			}
			string text2 = (icon.ImageAddress = categoryData.icon.name);
			if (!component._isSelected)
			{
				PhoneCategory category = component._categoryData.category;
				if (category != 0)
				{
					if (category == PhoneCategory.NewsFeed || category == PhoneCategory.NewsFeed)
					{
						return;
					}
					switch (category)
					{
					case PhoneCategory.DesighChallenge:
					{
						GameObject gameObject = _mcProfileContent.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						return;
					}
					default:
						return;
					case PhoneCategory.NewsFeed:
						break;
					}
				}
				PhoneNewsFeedTabContent mcNewsFeedContent = _mcNewsFeedContent;
				GameObject gameObject2 = mcNewsFeedContent.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				RepeatedField<NewsFeedPost> feeds = mcNewsFeedContent._feeds;
				PhoneListScroller listNews = mcNewsFeedContent._listNews;
				int num3 = (listNews.TotalCount = ((RepeatedField<T>)(object)feeds).Count);
				mcNewsFeedContent._listNews.RefreshList();
				return;
			}
			RectTransform rectTransform = default(RectTransform);
			Transform transform = rectTransform.transform;
			int num4 = 0;
			ulong num5 = default(ulong);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform, (float)(long)num5, 0.25f, (byte)num4 != 0);
			if ((object)transform != null)
			{
				while ((object)transform == null)
				{
				}
				while ((object)transform == null)
				{
				}
				if ((object)transform != null)
				{
					while ((long)transform != 1)
					{
					}
				}
			}
			IEnumerator enumerator = transform.GetEnumerator();
		}

		[Cpp2IlInjected.Token(Token = "0x60028F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B78C0", Offset = "0x9B62C0", VA = "0x1809B78C0")]
		private void OnCategorItemDataHandler(ListBase.ListEventData args)
		{
			//Discarded unreachable code: IL_0087
			//IL_0015: Expected O, but got I4
			PhoneCategoryItem component = args.DisplayObject.GetComponent<PhoneCategoryItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int itemIndex = args.ItemIndex;
				if (itemIndex == 1)
				{
				}
				bool flag = (component.IsUnlocked = itemIndex != 2);
				PhoneCategoryData[] categoryData = _categoryData;
				int itemIndex2 = args.ItemIndex;
				PhoneCategoryData phoneCategoryData = categoryData[itemIndex2];
				component.RefreshDisplay(phoneCategoryData);
				PhoneCategoryData[] categoryData2 = _categoryData;
				int itemIndex3 = args.ItemIndex;
				if (categoryData2[itemIndex3].category == PhoneCategory.Profile)
				{
					RedDot redDot = (_mcProfileNotification = component._notificationAsset);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028F1")]
		[Cpp2IlInjected.Address(RVA = "0x9B7870", Offset = "0x9B6270", VA = "0x1809B7870", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0028
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GamePopCurrentMenu)
			{
				_btnClose.m_OnClick?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B9AF0", Offset = "0x9B84F0", VA = "0x1809B9AF0")]
		public PhoneMenu()
		{
		}
	}
}
