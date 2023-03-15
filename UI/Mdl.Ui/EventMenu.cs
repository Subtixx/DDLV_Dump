using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Rewards;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000463")]
	public class EventMenu : Menu
	{
		[Cpp2IlInjected.Token(Token = "0x2000464")]
		public enum EventMenuTabs
		{
			[Cpp2IlInjected.Token(Token = "0x4001655")]
			Home,
			[Cpp2IlInjected.Token(Token = "0x4001656")]
			Shop,
			[Cpp2IlInjected.Token(Token = "0x4001657")]
			Leaderboard
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001638")]
		private EventMenuTabs _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001639")]
		private List<Item> _currencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400163A")]
		private MegaEventData _data;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400163B")]
		private EventMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400163C")]
		private Material _matSkyboxOriginal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400163D")]
		private EventContentShopModel _eventShopModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400163E")]
		private EventContentLeaderboardModel _eventLeaderboardModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400163F")]
		private float _menuCanvasScaleFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001640")]
		public Material MatSkyboxAlter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001641")]
		[SerializeField]
		private ListBase _listCurrencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001642")]
		[SerializeField]
		private List<EventContentBase> _listEventContents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001643")]
		[SerializeField]
		private GameObject _mcTabsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001644")]
		[SerializeField]
		private GameObject _mcSelectedTabIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001645")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001646")]
		[SerializeField]
		private TextBase _tfSubtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001647")]
		[SerializeField]
		private UITimer _mcEventTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001648")]
		[SerializeField]
		private GameObject _mcCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001649")]
		[SerializeField]
		private RedDot _mcRedDotShop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400164A")]
		[SerializeField]
		private RedDot _mcRedDotLeaderboard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400164B")]
		[SerializeField]
		private GameObject _mcEnvironment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400164C")]
		private EventContentBase _mcCurrentContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400164D")]
		[SerializeField]
		private GameObject _prefabRewardAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400164E")]
		[Space]
		public EventMenuTabs DefaultTab;

		[Cpp2IlInjected.Token(Token = "0x400164F")]
		private const int StartPosX = -665;

		[Cpp2IlInjected.Token(Token = "0x4001650")]
		private const int IncPosX = 410;

		[Cpp2IlInjected.Token(Token = "0x4001651")]
		private const int BottomPosY = -185;

		[Cpp2IlInjected.Token(Token = "0x4001652")]
		private const int MiddlePosY = 32;

		[Cpp2IlInjected.Token(Token = "0x4001653")]
		private const int TopPosY = 100;

		[Cpp2IlInjected.Token(Token = "0x170004AA")]
		private EventContentShopModel EventShopModel
		{
			[Cpp2IlInjected.Token(Token = "0x6001C52")]
			[Cpp2IlInjected.Address(RVA = "0x1400F80", Offset = "0x13FF980", VA = "0x181400F80")]
			get
			{
				//Discarded unreachable code: IL_005e
				EventContentShopModel eventShopModel = _eventShopModel;
				if (eventShopModel == null)
				{
					EventContentShopModel eventContentShopModel = (_eventShopModel = new EventContentShopModel());
					int num = 0;
					List<ShopProductModel> fakeEventShop = (List<ShopProductModel>)(object)FakeData.Instance.GetFakeEventShop();
					Predicate<ShopProductModel> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
					if (_003C_003E9__11_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(ShopProductModel x)
						{
							if (x != null)
							{
								int num3 = 0;
								if (x == null)
								{
								}
							}
							return true;
						};
					}
					int num2 = ((List<T>)(object)fakeEventShop).RemoveAll((Predicate<>)(object)_003C_003E9__11_);
					_eventShopModel.Products = fakeEventShop;
				}
				return eventShopModel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AB")]
		private EventContentLeaderboardModel EventLeaderboardModel
		{
			[Cpp2IlInjected.Token(Token = "0x6001C53")]
			[Cpp2IlInjected.Address(RVA = "0x1400840", Offset = "0x13FF240", VA = "0x181400840")]
			get
			{
				//Discarded unreachable code: IL_0165, IL_016b, IL_0171, IL_0177, IL_017d, IL_0183, IL_0189, IL_018f, IL_0195
				//IL_0062: Expected O, but got I4
				//IL_0080: Expected I4, but got O
				//IL_00a6: Expected O, but got I4
				if ((object)typeof(_003C_003Ec).TypeHandle == null)
				{
					EventContentLeaderboardModel eventContentLeaderboardModel = (_eventLeaderboardModel = new EventContentLeaderboardModel());
					int num = 0;
					FakeLeaderboardDataModel fakeLeaderboardData = FakeData.Instance.FakeLeaderboardData;
					EventLeaderboardRecordModel eventLeaderboardRecordModel = default(EventLeaderboardRecordModel);
					FakeLeaderboardRecordModel rawFakeData = eventLeaderboardRecordModel.RawFakeData;
					FakeLeaderboardRecordModel _003CFakePlayerRecord_003Ek__BackingField = fakeLeaderboardData.FakePlayerRecord;
					float _003CFakeScoreRatio_003Ek__BackingField = fakeLeaderboardData.FakeScoreRatio;
					rawFakeData.Player = (FakeVirtualPlayerModel)(object)_003CFakePlayerRecord_003Ek__BackingField;
					int stringLength = rawFakeData.Player.Name.m_stringLength;
					rawFakeData.Player = (FakeVirtualPlayerModel)stringLength;
					string _003CName_003Ek__BackingField = rawFakeData.Player.Name;
					List<EventLeaderboardRecordModel> list = (List<EventLeaderboardRecordModel>)(object)new List<T>();
					_003CFakePlayerRecord_003Ek__BackingField.Score = (int)list;
					int size = ((List<>)(object)list)._size;
					List<FakeLeaderboardRecordModel> _003CFakeRecords_003Ek__BackingField = fakeLeaderboardData.FakeRecords;
					bool flag = default(bool);
					if (flag)
					{
						float _003CFakeScoreRatio_003Ek__BackingField2 = fakeLeaderboardData.FakeScoreRatio;
						EventLeaderboardRecordModel eventLeaderboardRecordModel2 = default(EventLeaderboardRecordModel);
						eventLeaderboardRecordModel2.RawFakeData = (FakeLeaderboardRecordModel)0;
						string text = (eventLeaderboardRecordModel2.PlayerName = eventLeaderboardRecordModel2.RawFakeData.Player.Name);
						FakeVirtualPlayerModel _003CPlayer_003Ek__BackingField = eventLeaderboardRecordModel2.RawFakeData.Player;
						int score = (eventLeaderboardRecordModel2.PlayerLevel = _003CPlayer_003Ek__BackingField.Level);
						eventLeaderboardRecordModel2.ScoreRatio = _003CFakeScoreRatio_003Ek__BackingField2;
						eventLeaderboardRecordModel2.Score = score;
						int _003CLevel_003Ek__BackingField = _003CPlayer_003Ek__BackingField.Level;
					}
					if (_003C_003Ec._003C_003E9__13_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EventLeaderboardRecordModel x) => x.Score);
					}
					Func<EventLeaderboardRecordModel, int> func = default(Func<EventLeaderboardRecordModel, int>);
					if (_003C_003Ec._003C_003E9__13_1 == null)
					{
						func = (Func<EventLeaderboardRecordModel, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EventLeaderboardRecordModel x) => x.PlayerLevel));
					}
					IOrderedEnumerable<EventLeaderboardRecordModel> orderedEnumerable = default(IOrderedEnumerable<EventLeaderboardRecordModel>);
					List<EventLeaderboardRecordModel> list2 = (List<EventLeaderboardRecordModel>)(object)Enumerable.ToList<EventLeaderboardRecordModel>((IEnumerable<>)Enumerable.ThenByDescending<EventLeaderboardRecordModel, int>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func));
					List<EventLeaderboardRewardModel> list3 = (List<EventLeaderboardRewardModel>)(object)new List<T>();
					Action<FakeEventLeaderboardRewardModel> action = default(Action<FakeEventLeaderboardRewardModel>);
					((List<T>)(object)fakeLeaderboardData.FakeRewards).ForEach((Action<>)(object)action);
				}
				return (EventContentLeaderboardModel)typeof(_003C_003Ec).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C54")]
		[Cpp2IlInjected.Address(RVA = "0x13FE7C0", Offset = "0x13FD1C0", VA = "0x1813FE7C0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_009a
			base.OnPush(stack, param);
			int num = 0;
			Material material = (_matSkyboxOriginal = RenderSettings.skybox);
			RenderSettings.skybox = MatSkyboxAlter;
			SystemRoot.Instance.PauseSystem<PlayerNavigation>();
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			int num2 = ((playerCamera.enabled = false) ? 1 : 0);
			GameObject mcCamera = _mcCamera;
			int num3 = 0;
			mcCamera.SetActive(value: true);
			if (param != null)
			{
				int num4 = 0;
				if (param != null)
				{
					int num5 = 0;
					_param = (EventMenuParam)param;
				}
			}
			int num6 = 0;
			CanvasScaler component = UiRoot.Instance._menuStack.GetComponent<CanvasScaler>();
			float num7 = (_menuCanvasScaleFactor = component.m_MatchWidthOrHeight);
			component.m_MatchWidthOrHeight = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C55")]
		[Cpp2IlInjected.Address(RVA = "0x13FE5C0", Offset = "0x13FCFC0", VA = "0x1813FE5C0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0074
			base.OnPop();
			RenderSettings.skybox = _matSkyboxOriginal;
			SystemRoot.Instance.ResumeSystem<PlayerNavigation>();
			GameObject mcCamera = _mcCamera;
			int active = 0;
			mcCamera.SetActive((byte)active != 0);
			SystemRoot.Instance._playerCamera.enabled = true;
			int num = 0;
			CanvasScaler component = UiRoot.Instance._menuStack.GetComponent<CanvasScaler>();
			float num2 = (component.m_MatchWidthOrHeight = _menuCanvasScaleFactor);
			UnityEngine.Object.Destroy(_mcEnvironment);
			UnityEngine.Object.Destroy(_mcCamera);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C56")]
		[Cpp2IlInjected.Address(RVA = "0x13FE3E0", Offset = "0x13FCDE0", VA = "0x1813FE3E0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0099
			base.OnFocusIn();
			List<Item> currencyItems = (List<Item>)(object)new List<T>();
			int num = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			int num2 = 0;
			Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			_currencyItems = currencyItems;
			List<Item> currencyItems2 = _currencyItems;
			ListBase listCurrencyItems = _listCurrencyItems;
			int num3 = (listCurrencyItems.TotalCount = ((List<>)(object)currencyItems2)._size);
			LayoutRebuilder.ForceRebuildLayoutImmediate(_listCurrencyItems.m_Content);
			EventMenuTabs defaultTab = DefaultTab;
			RefreshTabs(defaultTab);
			EventMenuParam param = _param;
			if (param != null)
			{
			}
			_data = (MegaEventData)(object)param;
			EventMenuTabs defaultTab2 = DefaultTab;
			RefreshDisplay(defaultTab2);
			base.IsDataUpToDate = true;
			RefreshRedDots();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C57")]
		[Cpp2IlInjected.Address(RVA = "0x869280", Offset = "0x867C80", VA = "0x180869280", Slot = "29")]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			return base.PreFocusOut(popAfterPreFocusOut);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C58")]
		[Cpp2IlInjected.Address(RVA = "0x1400390", Offset = "0x13FED90", VA = "0x181400390", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0040
			((object)this)._002Ector();
			ListBase.ListEvents onItemData = _listCurrencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			int _003C_003E1__state = default(int);
			_003COnRedDotRefresh_003Ed__46 _003COnRedDotRefresh_003Ed__ = new _003COnRedDotRefresh_003Ed__46(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRedDotRefresh_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003COnRedDotRefresh_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C59")]
		[Cpp2IlInjected.Address(RVA = "0x1400720", Offset = "0x13FF120", VA = "0x181400720", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_003e
			base.UnregisterFocusedListeners();
			ListBase.ListEvents onItemData = _listCurrencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			int _003C_003E1__state = default(int);
			_003COnRedDotRefresh_003Ed__46 _003COnRedDotRefresh_003Ed__ = new _003COnRedDotRefresh_003Ed__46(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRedDotRefresh_003Ed__._003C_003E4__this = this;
			StopCoroutine(_003COnRedDotRefresh_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5A")]
		[Cpp2IlInjected.Address(RVA = "0x13FEC30", Offset = "0x13FD630", VA = "0x1813FEC30")]
		private void RefreshData()
		{
			EventMenuParam param = _param;
			if (param != null)
			{
				MegaEventData megaEventData = (_data = param.Data);
			}
			_data = (MegaEventData)(object)param;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5B")]
		[Cpp2IlInjected.Address(RVA = "0x13FF520", Offset = "0x13FDF20", VA = "0x1813FF520")]
		private void RefreshTabs(EventMenuTabs selectedTab)
		{
			//Discarded unreachable code: IL_00e5, IL_00f9, IL_00fe, IL_010c, IL_0131, IL_0137, IL_0149
			//IL_002b: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_00c1: Expected O, but got I4
			//IL_00eb: Expected O, but got I4
			EventTabButton eventTabButton = default(EventTabButton);
			EventMenuTabs selectedTab2 = default(EventMenuTabs);
			bool flag3 = default(bool);
			GameObject gameObject = default(GameObject);
			bool flag4 = default(bool);
			GameObject gameObject2 = default(GameObject);
			while (true)
			{
				int num = 0;
				if (_selectedTab == selectedTab)
				{
					return;
				}
				_selectedTab = selectedTab;
				if ((object)_mcTabsHolder.transform != null)
				{
				}
				((RectTransform)num).RebuildLayout();
				IEnumerator enumerator = _mcTabsHolder.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num4 = 0;
					if (!(eventTabButton != (UnityEngine.Object)num4))
					{
						continue;
					}
					selectedTab2 = _selectedTab;
					bool flag2 = (eventTabButton.IsSelected = selectedTab2 == eventTabButton.Tab);
					while (!eventTabButton._isSelected)
					{
					}
				}
				if (selectedTab2 != 0)
				{
				}
				if (flag3)
				{
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				int num5 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				if (flag4)
				{
					gameObject2.SetActive(value: true);
				}
				int num6 = 0;
				if (eventTabButton != (UnityEngine.Object)num6)
				{
					if ((object)_mcSelectedTabIndicator.transform != null)
					{
					}
					if ((object)eventTabButton.McIcon.transform != null)
					{
					}
					int num7 = 0;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5C")]
		[Cpp2IlInjected.Address(RVA = "0x13FE150", Offset = "0x13FCB50", VA = "0x1813FE150")]
		public static int MegaEventNodePosToY(MegaEventNodePos nodePos)
		{
			while (nodePos == MegaEventNodePos.Bottom || nodePos == MegaEventNodePos.Bottom || nodePos == MegaEventNodePos.Middle)
			{
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5D")]
		[Cpp2IlInjected.Address(RVA = "0x13FE140", Offset = "0x13FCB40", VA = "0x1813FE140")]
		public static int IncrementPosX(int posX)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5E")]
		[Cpp2IlInjected.Address(RVA = "0x13FEC60", Offset = "0x13FD660", VA = "0x1813FEC60")]
		public void RefreshDisplay(EventMenuTabs eventMenuTabs)
		{
			//Discarded unreachable code: IL_0155
			//IL_0140: Expected O, but got I4
			MegaEventData data = _data;
			if (data != null)
			{
				TextBase tfTitle = _tfTitle;
				string text = (tfTitle.Text = data.title_);
				MegaEventData data2 = _data;
				TextBase tfSubtitle = _tfSubtitle;
				string text2 = (tfSubtitle.Text = data2.subtitle_);
				if (eventMenuTabs != 0)
				{
					if (eventMenuTabs != 0)
					{
						if (eventMenuTabs != EventMenuTabs.Shop)
						{
							goto IL_012c;
						}
						int num = 0;
						FakeData.Instance.RefreshFakeLeaderboardRecords();
						EventContentBase mcCurrentContent = _mcCurrentContent;
						EventContentLeaderboardModel eventLeaderboardModel = EventLeaderboardModel;
						mcCurrentContent.RefreshData(eventLeaderboardModel);
					}
					EventContentShopModel eventShopModel = EventShopModel;
				}
				Client client = default(Client);
				DateTime _003CStartTime_003Ek__BackingField = client.profile.player_.megaEventProgress_.StartTime;
				EventContentHomeModel eventContentHomeModel = new EventContentHomeModel();
				List<EventChapterModel> list = (eventContentHomeModel.Chapters = (List<EventChapterModel>)(object)new List<T>());
				int count = ((RepeatedField<T>)(object)_data.chapters_).Count;
				int num2 = 0;
				if (count > 0)
				{
					MegaEventChapterData megaEventChapterData = (MegaEventChapterData)((RepeatedField<T>)(object)_data.chapters_)[num2];
					DateTime dateTime = _data.ChapterOpenTime(_003CStartTime_003Ek__BackingField, num2);
					if (num2 == 0)
					{
					}
					EventChapterModel eventChapterModel = default(EventChapterModel);
					eventChapterModel.PrevChapter = eventChapterModel;
					int num3 = count - 1;
					bool flag = (eventChapterModel.IsPremium = num2 == num3);
					num2++;
				}
				_mcCurrentContent.RefreshData(eventContentHomeModel);
			}
			goto IL_012c;
			IL_012c:
			EventContentBase mcCurrentContent2 = _mcCurrentContent;
			int num4 = 0;
			if (mcCurrentContent2 != (UnityEngine.Object)num4)
			{
				_mcCurrentContent.RefreshDisplay();
			}
			RefreshTimeLimitedEvent();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5F")]
		[Cpp2IlInjected.Address(RVA = "0x13FFB20", Offset = "0x13FE520", VA = "0x1813FFB20")]
		private void RefreshTimeLimitedEvent()
		{
			//IL_00f5: Expected O, but got I4
			//IL_0127: Expected F4, but got I4
			//IL_013e: Expected O, but got I4
			//IL_017f: Expected F4, but got I4
			//IL_0196: Expected O, but got I4
			//IL_01d7: Expected F4, but got I4
			//IL_0227: Expected I4, but got I8
			int num = 0;
			if ((IntPtr)_data != (IntPtr)num)
			{
				DateTime _003CStartTime_003Ek__BackingField = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_.StartTime;
				DateTime _003CEndTime_003Ek__BackingField = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_.EndTime;
				DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
				UITimer mcEventTimer = _mcEventTimer;
				UITimer.TimerEventDelegate value = OnTimeLimitedEventStarted;
				mcEventTimer.TimerComplete -= value;
				UITimer mcEventTimer2 = _mcEventTimer;
				UITimer.TimerEventDelegate value2 = OnTimeLimitedEventEnded;
				mcEventTimer2.TimerComplete -= value2;
				UITimer mcEventTimer3 = _mcEventTimer;
				UITimer.TimerEventDelegate value3 = OnTimeLimitedEventRemoved;
				mcEventTimer3.TimerComplete -= value3;
				MegaEventState state = _data.GetState(serverTime, _003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField);
				if (state != 0)
				{
					if (state != 0)
					{
						if (state != MegaEventState.InProgress)
						{
							goto IL_0249;
						}
						UITimer mcEventTimer4 = _mcEventTimer;
						int num2 = 0;
						string text = (mcEventTimer4.Prefix = LocalizationManager.FromStringID("event.time_collect_rewards", (IResolver)num2) + " ");
						UITimer mcEventTimer5 = _mcEventTimer;
						TimeSpan timeSpan = _003CEndTime_003Ek__BackingField - serverTime;
						int num3 = 0;
						mcEventTimer5.StartTimer(num3);
					}
					UITimer mcEventTimer6 = _mcEventTimer;
					int num4 = 0;
					string text2 = (mcEventTimer6.Prefix = LocalizationManager.FromStringID("event.time_end_in", (IResolver)num4) + " ");
					MegaEventData data = _data;
					UITimer mcEventTimer7 = _mcEventTimer;
					TimeSpan timeSpan2 = data.RewardTime(_003CEndTime_003Ek__BackingField) - serverTime;
					int num5 = 0;
					mcEventTimer7.StartTimer(num5);
				}
				UITimer mcEventTimer8 = _mcEventTimer;
				int num6 = 0;
				string text3 = (mcEventTimer8.Prefix = LocalizationManager.FromStringID("event.time_start_in", (IResolver)num6) + " ");
				MegaEventData data2 = _data;
				UITimer mcEventTimer9 = _mcEventTimer;
				TimeSpan timeSpan3 = data2.OpenTime(_003CStartTime_003Ek__BackingField) - serverTime;
				int num7 = 0;
				mcEventTimer9.StartTimer(num7);
				UITimer mcEventTimer10 = _mcEventTimer;
				UITimer.TimerEventDelegate value4 = OnTimeLimitedEventStarted;
				mcEventTimer10.TimerComplete += value4;
				if ((object)_tfTitle.transform != null)
				{
				}
				if ((object)_mcEventTimer.transform != null)
				{
				}
				int num8 = 0;
				ulong num9 = default(ulong);
				_mcEventTimer.gameObject.SetActive((byte)num9 != 0);
				if ((object)_mcEventTimer._tfTimer.transform != null)
				{
				}
				if ((object)_mcEventTimer.transform == null)
				{
				}
				return;
			}
			goto IL_0249;
			IL_0249:
			_mcEventTimer.StopTimer();
			GameObject gameObject = _mcEventTimer.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C60")]
		[Cpp2IlInjected.Address(RVA = "0x13FF0B0", Offset = "0x13FDAB0", VA = "0x1813FF0B0")]
		private void RefreshRedDots()
		{
			//Discarded unreachable code: IL_010e
			//IL_0061: Expected I4, but got I8
			List<ShopProductModel> products = EventShopModel.Products;
			Func<ShopProductModel, int> _003C_003E9__45_ = _003C_003Ec._003C_003E9__45_0;
			if (_003C_003E9__45_ == null)
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
										int result = default(int);
										if (x != null)
										{
											return result;
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
			int num = Enumerable.Sum<ShopProductModel>((IEnumerable<>)products, (Func<, >)(object)_003C_003E9__45_);
			RedDot mcRedDotShop = _mcRedDotShop;
			GameObject gameObject = mcRedDotShop.gameObject;
			string text = default(string);
			mcRedDotShop.TextBase.Text = text;
			ulong num2 = default(ulong);
			_mcRedDotShop.gameObject.SetActive((byte)num2 != 0);
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			MegaEventProgress megaEventProgress_ = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_;
			if (!megaEventProgress_.IsActive)
			{
				int num3 = 0;
			}
			int num4 = 0;
			MegaEventData megaEventData = FakeData.Instance.MegaEventData;
			DateTime _003CEndTime_003Ek__BackingField = megaEventProgress_.EndTime;
			int num5 = 0;
			DateTime _003CStartTime_003Ek__BackingField = megaEventProgress_.StartTime;
			if (megaEventData.GetState(serverTime, _003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField) == MegaEventState.InRewarding)
			{
				List<EventLeaderboardRewardModel> rewards = EventLeaderboardModel.Rewards;
				Func<EventLeaderboardRewardModel, bool> func = (Func<EventLeaderboardRewardModel, bool>)(object)(Func<T, TResult>)delegate(EventLeaderboardRewardModel x)
				{
					//Discarded unreachable code: IL_0030
					EventLeaderboardRecordModel playerRecord = EventLeaderboardModel.PlayerRecord;
					int rankRangeMin = x.RankRangeMin;
					EventLeaderboardRecordModel playerRecord2 = EventLeaderboardModel.PlayerRecord;
					int rankRangeMax = x.RankRangeMax;
					return !x.HasClaimed;
				};
				int num6 = Enumerable.Count<EventLeaderboardRewardModel>((IEnumerable<>)rewards, (Func<, >)(object)func);
			}
			GameObject gameObject2 = _mcRedDotLeaderboard.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C61")]
		[Cpp2IlInjected.Address(RVA = "0x13FEA30", Offset = "0x13FD430", VA = "0x1813FEA30")]
		[IteratorStateMachine(typeof(_003COnRedDotRefresh_003Ed__46))]
		private IEnumerator OnRedDotRefresh()
		{
			int _003C_003E1__state = default(int);
			_003COnRedDotRefresh_003Ed__46 _003COnRedDotRefresh_003Ed__ = new _003COnRedDotRefresh_003Ed__46(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRedDotRefresh_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C62")]
		[Cpp2IlInjected.Address(RVA = "0x13FEAA0", Offset = "0x13FD4A0", VA = "0x1813FEAA0")]
		public void OnTabClicked(int tabIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001C63")]
		[Cpp2IlInjected.Address(RVA = "0x13FE180", Offset = "0x13FCB80", VA = "0x1813FE180")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num3 = 0;
				if (top != null)
				{
					int num4 = 0;
					UiRoot.Instance._menuStack.Pop();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C64")]
		[Cpp2IlInjected.Address(RVA = "0x13FE230", Offset = "0x13FCC30", VA = "0x1813FE230")]
		private void OnCurrencyItemDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001C65")]
		[Cpp2IlInjected.Address(RVA = "0x13FEBC0", Offset = "0x13FD5C0", VA = "0x1813FEBC0")]
		private void OnTimeLimitedEventStarted(object sender, object param)
		{
			//Discarded unreachable code: IL_0032
			//IL_0031: Expected I4, but got I8
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			RefreshTimeLimitedEvent();
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuEventOpening, (MenuParam)num4, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C66")]
		[Cpp2IlInjected.Address(RVA = "0x13FEAD0", Offset = "0x13FD4D0", VA = "0x1813FEAD0")]
		private void OnTimeLimitedEventEnded(object sender, object param)
		{
			//Discarded unreachable code: IL_001b
			if (_selectedTab == EventMenuTabs.Leaderboard)
			{
				EventContentBase mcCurrentContent = _mcCurrentContent;
				int num = 0;
				int num2 = 0;
			}
			RefreshTimeLimitedEvent();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C67")]
		[Cpp2IlInjected.Address(RVA = "0x13FEBB0", Offset = "0x13FD5B0", VA = "0x1813FEBB0")]
		private void OnTimeLimitedEventRemoved(object sender, object param)
		{
			RefreshTimeLimitedEvent();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C68")]
		[Cpp2IlInjected.Address(RVA = "0x13FDC50", Offset = "0x13FC650", VA = "0x1813FDC50")]
		public void DebugPlayRewardAnimation(ItemReward itemReward, GameObject source, bool doTransaction)
		{
			//Discarded unreachable code: IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0106
			//IL_0024: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			FreemiumCurrencyItem freemiumCurrencyItem2 = default(FreemiumCurrencyItem);
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			Transform transform2 = default(Transform);
			Transform transform3 = default(Transform);
			while (true)
			{
				int num = 0;
				FreemiumCurrencyItem freemiumCurrencyItem = (FreemiumCurrencyItem)num;
				IEnumerator enumerator = _listCurrencyItems.m_Content.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					freemiumCurrencyItem = freemiumCurrencyItem2;
					FreemiumCurrencyItem freemiumCurrencyItem3 = freemiumCurrencyItem;
					int num3 = 0;
					if (!(freemiumCurrencyItem3 != (UnityEngine.Object)num3))
					{
						continue;
					}
					Item currencyItem = freemiumCurrencyItem.CurrencyItem;
					if ((object)itemReward.Item == null)
					{
						continue;
					}
					gameObject = freemiumCurrencyItem.mc_icon.gameObject;
				}
				int num4 = 0;
				if ((object)gameObject != null)
				{
				}
				int num5 = 0;
				if (!(gameObject != (UnityEngine.Object)num5))
				{
					return;
				}
				ShopProductItemRewardAnimation component = gameObject2.GetComponent<ShopProductItemRewardAnimation>();
				Transform transform = gameObject.transform;
				Action action = delegate
				{
					//Discarded unreachable code: IL_0034
					if (doTransaction)
					{
						ItemReward itemReward2 = itemReward;
						EventMenu eventMenu = this;
						FreemiumCurrencyItem freemiumCurrencyItem4 = freemiumCurrencyItem;
						CancellationToken cancellationToken = eventMenu.CancellationToken;
						eventMenu.DebugDoFakeRewardTransaction(itemReward2, freemiumCurrencyItem4, cancellationToken).FireAndForgetTask();
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
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C69")]
		[Cpp2IlInjected.Address(RVA = "0x13FDB80", Offset = "0x13FC580", VA = "0x1813FDB80")]
		[AsyncStateMachine(typeof(_003CDebugDoFakeRewardTransaction_003Ed__54))]
		private Task DebugDoFakeRewardTransaction(ItemReward itemReward, FreemiumCurrencyItem freemiumCurrencyItem, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C6A")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public EventMenu()
		{
		}
	}
}
