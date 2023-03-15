using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Online;
using Mdl.Systems;
using Meta.Online;
using Meta.Social;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000655")]
	public class PhoneProfileTabContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000656")]
		public delegate void RefreshRequestedDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000657")]
		public class TabInfo
		{
			[Cpp2IlInjected.Token(Token = "0x1700062B")]
			public ButtonTmPro Button
			{
				[Cpp2IlInjected.Token(Token = "0x6002946")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CButton_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6002947")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CButton_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700062C")]
			public Action OnActivation
			{
				[Cpp2IlInjected.Token(Token = "0x6002948")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003COnActivation_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6002949")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003COnActivation_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600294A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public TabInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400236E")]
		public RefreshRequestedDelegate RefreshRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400236F")]
		private bool _isConstructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002370")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002371")]
		[SerializeField]
		private RectTransform _mcPostsFullSizeContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002372")]
		[SerializeField]
		private Button _btnBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002373")]
		[SerializeField]
		private NotificationButton _btnClaim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002374")]
		[SerializeField]
		private ButtonTmPro _btnPosts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002375")]
		[SerializeField]
		private ButtonTmPro _btnFollowee;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002376")]
		[SerializeField]
		private ButtonTmPro _btnFollowing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002377")]
		[SerializeField]
		private ScrollRect _mcPanelScroller;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002378")]
		[SerializeField]
		private RectTransform _mcFollowingContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002379")]
		[SerializeField]
		private RectTransform _mcPostsThumbsListContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400237A")]
		[SerializeField]
		private RectTransform _mcPostsThumbsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400237B")]
		[SerializeField]
		private PhonePlayerItem _playerItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400237C")]
		[SerializeField]
		private PhonePostItem _postItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400237D")]
		[SerializeField]
		private RawImage _mcAvatarPortrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400237E")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400237F")]
		private List<NewsFeedPost> _allPosts = (List<NewsFeedPost>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002380")]
		[SerializeField]
		private LoopVerticalScrollRect _listPosts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002381")]
		[SerializeField]
		private TextBase _tfPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002382")]
		private List<TabInfo> _tabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002383")]
		private ButtonTmPro _selectedTabBtn;

		[Cpp2IlInjected.Token(Token = "0x1700062A")]
		public ButtonTmPro SelectedTabBtn
		{
			[Cpp2IlInjected.Token(Token = "0x6002928")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return _selectedTabBtn;
			}
			[Cpp2IlInjected.Token(Token = "0x6002929")]
			[Cpp2IlInjected.Address(RVA = "0x9BD950", Offset = "0x9BC350", VA = "0x1809BD950")]
			private set
			{
				_selectedTabBtn = value;
				OnTabActivated();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600292A")]
		[Cpp2IlInjected.Address(RVA = "0x9BCD40", Offset = "0x9BB740", VA = "0x1809BCD40", Slot = "4")]
		public virtual void Show(bool forceRefresh)
		{
			//Discarded unreachable code: IL_011e, IL_0158, IL_0214
			//IL_01e7: Expected O, but got I4
			TextBase tfPlayerId;
			string[] array;
			string entityId = default(string);
			string titleId = default(string);
			while (true)
			{
				base.gameObject.SetActive(value: true);
				if (!_isConstructed)
				{
					Construct();
				}
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				tfPlayerId = _tfPlayerId;
				array = new string[5];
				if ("ID: " != null && array == null)
				{
					continue;
				}
				array[0] = "ID: ";
				if (metaOnlineClient != null)
				{
					entityId = metaOnlineClient.EntityId;
					if (entityId != null)
					{
					}
				}
				if ("unknown" != null && entityId == null)
				{
					continue;
				}
				array[1] = "unknown";
				if (" (" != null && " (" == null)
				{
					continue;
				}
				array[2] = " (";
				if (metaOnlineClient != null)
				{
					titleId = metaOnlineClient.TitleId;
					if (titleId != null)
					{
					}
				}
				if ("unknown" == null || titleId != null)
				{
					array[3] = "unknown";
					if (")" == null || ")" != null)
					{
						break;
					}
				}
			}
			array[4] = ")";
			string text2 = (tfPlayerId.Text = string.Concat(array));
			int num = 0;
			FriendManager instance = FriendManager.Instance;
			TextBase label = _btnFollowee.Label;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			int followersCount = instance.FollowersCount;
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600292B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2E0", Offset = "0x9B9CE0", VA = "0x1809BB2E0", Slot = "5")]
		protected virtual void Construct()
		{
			//Discarded unreachable code: IL_018c
			ButtonTmPro btnPosts = _btnPosts;
			_isConstructed = true;
			Button.ButtonClickedEvent onClick = btnPosts.ButtonComponent.m_OnClick;
			UnityAction call = OnPostsClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnFollowing.ButtonComponent.m_OnClick;
			UnityAction call2 = OnFollowingClickedHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnFollowee.ButtonComponent.m_OnClick;
			UnityAction call3 = OnFolloweeClickedHandler;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnClaim.ButtonComponent.m_OnClick;
			UnityAction call4 = OnClaimClickedHandler;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnBack.m_OnClick;
			UnityAction call5 = OnBackClickHandler;
			onClick5.AddListener(call5);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPosts).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPostsItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			List<TabInfo> list = (_tabs = (List<TabInfo>)(object)new List<T>());
			TabInfo tabInfo = new TabInfo();
			ButtonTmPro buttonTmPro = (tabInfo.Button = _btnPosts);
			Action action = (tabInfo.OnActivation = delegate
			{
				//Discarded unreachable code: IL_003d
				_mcPostsThumbsListContent.gameObject.SetActive(value: true);
				GameObject gameObject3 = _mcFollowingContent.gameObject;
				int active3 = 0;
				gameObject3.SetActive((byte)active3 != 0);
				CancellationToken cancellationToken3 = CancellationToken;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			});
			TabInfo tabInfo2 = new TabInfo();
			ButtonTmPro buttonTmPro2 = (tabInfo2.Button = _btnFollowee);
			Action action2 = (tabInfo2.OnActivation = delegate
			{
				//Discarded unreachable code: IL_002c
				GameObject gameObject2 = _mcPostsThumbsListContent.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				CancellationToken cancellationToken2 = CancellationToken;
				int isFollowing = 0;
				LoadFollowData((byte)isFollowing != 0, cancellationToken2).FireAndForgetTask();
			});
			TabInfo tabInfo3 = new TabInfo();
			ButtonTmPro buttonTmPro3 = (tabInfo3.Button = _btnFollowing);
			Action action3 = (tabInfo3.OnActivation = delegate
			{
				//Discarded unreachable code: IL_002a
				GameObject gameObject = _mcPostsThumbsListContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				CancellationToken cancellationToken = CancellationToken;
				LoadFollowData(isFollowing: true, cancellationToken).FireAndForgetTask();
			});
		}

		[Cpp2IlInjected.Token(Token = "0x600292C")]
		[Cpp2IlInjected.Address(RVA = "0x9BBDA0", Offset = "0x9BA7A0", VA = "0x1809BBDA0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00e5
			Button.ButtonClickedEvent onClick = _btnPosts.ButtonComponent.m_OnClick;
			UnityAction call = OnPostsClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnFollowing.ButtonComponent.m_OnClick;
			UnityAction call2 = OnFollowingClickedHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnFollowee.ButtonComponent.m_OnClick;
			UnityAction call3 = OnFolloweeClickedHandler;
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnClaim.ButtonComponent.m_OnClick;
			UnityAction call4 = OnClaimClickedHandler;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnBack.m_OnClick;
			UnityAction call5 = OnBackClickHandler;
			onClick5.RemoveListener(call5);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPosts).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPostsItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600292D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3C0", Offset = "0x9BADC0", VA = "0x1809BC3C0")]
		private void OnPostsClickHandler()
		{
			ButtonTmPro buttonTmPro = (_selectedTabBtn = _btnPosts);
			OnTabActivated();
		}

		[Cpp2IlInjected.Token(Token = "0x600292E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0A0", Offset = "0x9BAAA0", VA = "0x1809BC0A0")]
		private void OnFollowingClickedHandler()
		{
			ButtonTmPro buttonTmPro = (_selectedTabBtn = _btnFollowing);
			OnTabActivated();
		}

		[Cpp2IlInjected.Token(Token = "0x600292F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC070", Offset = "0x9BAA70", VA = "0x1809BC070")]
		private void OnFolloweeClickedHandler()
		{
			ButtonTmPro buttonTmPro = (_selectedTabBtn = _btnFollowee);
			OnTabActivated();
		}

		[Cpp2IlInjected.Token(Token = "0x6002930")]
		[Cpp2IlInjected.Address(RVA = "0x9BC700", Offset = "0x9BB100", VA = "0x1809BC700")]
		private void OnTabActivated()
		{
			//Discarded unreachable code: IL_003d, IL_0043, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			//IL_0012: Expected O, but got I4
			int num = 0;
			ButtonTmPro selectedTabBtn = _selectedTabBtn;
			int num2 = 0;
			if (selectedTabBtn == (UnityEngine.Object)num2)
			{
				return;
			}
			List<TabInfo> tabs = _tabs;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
				int num3 = 0;
				Color white = Color.white;
				Color white2 = Color.white;
				TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
				while ((object)textMeshProUGUI == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002931")]
		[Cpp2IlInjected.Address(RVA = "0x9BB950", Offset = "0x9BA350", VA = "0x1809BB950")]
		[AsyncStateMachine(typeof(_003CLoadFollowData_003Ed__34))]
		private Task LoadFollowData(bool isFollowing, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002932")]
		[Cpp2IlInjected.Address(RVA = "0x9BC240", Offset = "0x9BAC40", VA = "0x1809BC240")]
		private void OnPlayerActionHandler(PhonePlayerItem item)
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002933")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC00", Offset = "0x9BB600", VA = "0x1809BCC00")]
		[AsyncStateMachine(typeof(_003CSearchPlayerActionTask_003Ed__36))]
		private Task SearchPlayerActionTask(PhonePlayerItem playerItem, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002934")]
		[Cpp2IlInjected.Address(RVA = "0x9BBA90", Offset = "0x9BA490", VA = "0x1809BBA90")]
		[AsyncStateMachine(typeof(_003CLoadPostTask_003Ed__37))]
		private Task LoadPostTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002935")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5F0", Offset = "0x9BAFF0", VA = "0x1809BC5F0")]
		private void OnSuggestedClickHandler(int index)
		{
			//Discarded unreachable code: IL_0072
			//IL_004c: Expected O, but got I4
			_mcPostsFullSizeContent.gameObject.SetActive(value: true);
			List<NewsFeedPost> allPosts = _allPosts;
			LoopVerticalScrollRect listPosts = _listPosts;
			int num = (listPosts.totalCount = ((List<>)(object)allPosts)._size);
			RectTransform content = ((LoopScrollRect)_listPosts).m_Content;
			int num2 = 0;
			Vector2 anchoredPosition = content.anchoredPosition;
			content.anchoredPosition = (Vector2)num2;
			_listPosts.RefillCells(index);
			GameObject gameObject = _mcPanelScroller.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002936")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3F0", Offset = "0x9BADF0", VA = "0x1809BC3F0")]
		private void OnPostsItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002937")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0D0", Offset = "0x9BAAD0", VA = "0x1809BC0D0")]
		private void OnLikeHandler(FeedItem post)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002938")]
		[Cpp2IlInjected.Address(RVA = "0x9BB820", Offset = "0x9BA220", VA = "0x1809BB820")]
		[AsyncStateMachine(typeof(_003CLikeTask_003Ed__41))]
		private Task LikeTask(CancellationToken ct, FeedItem post)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002939")]
		[Cpp2IlInjected.Address(RVA = "0x9BBBB0", Offset = "0x9BA5B0", VA = "0x1809BBBB0")]
		private void OnBackClickHandler()
		{
			//Discarded unreachable code: IL_0027
			GameObject gameObject = _mcPostsFullSizeContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_mcPanelScroller.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600293A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600293B")]
		[Cpp2IlInjected.Address(RVA = "0x9BCAE0", Offset = "0x9BB4E0", VA = "0x1809BCAE0")]
		[AsyncStateMachine(typeof(_003CRefreshNotification_003Ed__44))]
		private Task RefreshNotification(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600293C")]
		[Cpp2IlInjected.Address(RVA = "0x9BBC10", Offset = "0x9BA610", VA = "0x1809BBC10")]
		private void OnClaimClickedHandler()
		{
			//Discarded unreachable code: IL_001d
			NotificationButton btnClaim = _btnClaim;
			CancellationToken cancellationToken = CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600293D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1C0", Offset = "0x9B9BC0", VA = "0x1809BB1C0")]
		[AsyncStateMachine(typeof(_003CClaimRewardsTask_003Ed__46))]
		private Task ClaimRewardsTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600293E")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8D0", Offset = "0x9BC2D0", VA = "0x1809BD8D0")]
		public PhoneProfileTabContent()
		{
		}
	}
}
