using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Online;
using Meta.Social;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000661")]
	public class PhoneSearchTabContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000662")]
		public delegate void OnStartSearchDelegate(bool isFinished);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023B4")]
		private bool _isConstructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023B5")]
		[SerializeField]
		private InputTextBase _tfInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023B6")]
		[SerializeField]
		private GameObject _mcLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023B7")]
		[SerializeField]
		private LoopVerticalScrollRect _listPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40023B8")]
		[SerializeField]
		private LoopVerticalScrollRect _listThumbnailSuggested;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40023B9")]
		[SerializeField]
		private ThrobberIcon _mcThrobber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40023BA")]
		[SerializeField]
		private BaseButton _btnReset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40023BB")]
		[SerializeField]
		private Button _btnSuggestedPreviewClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40023BC")]
		[SerializeField]
		private BaseButton _btnRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40023BD")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40023BE")]
		private List<NewsFeedPost> _currentSuggestedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40023BF")]
		private List<FollowData> _lastSearch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40023C0")]
		[SerializeField]
		private RectTransform _mcSeachContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40023C1")]
		[SerializeField]
		private RectTransform _mcSuggestedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40023C2")]
		[SerializeField]
		private LoopVerticalScrollRect _listSuggestedFull;

		[Cpp2IlInjected.Token(Token = "0x600295E")]
		[Cpp2IlInjected.Address(RVA = "0x9BF2E0", Offset = "0x9BDCE0", VA = "0x1809BF2E0", Slot = "4")]
		public virtual void Show(bool forceRefresh)
		{
			//Discarded unreachable code: IL_003f
			base.gameObject.SetActive(value: true);
			if (!_isConstructed)
			{
				Construct();
			}
			_tfInput.text = "";
			CancellationToken cancellationToken = CancellationToken;
			RefreshSuggested(cancellationToken).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600295F")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002960")]
		[Cpp2IlInjected.Address(RVA = "0x9BDA00", Offset = "0x9BC400", VA = "0x1809BDA00", Slot = "5")]
		protected virtual void Construct()
		{
			//Discarded unreachable code: IL_012e
			InputTextBase tfInput = _tfInput;
			_isConstructed = true;
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPlayers).m_OnItemData;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPlayerItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemData2 = ((LoopScrollRect)_listThumbnailSuggested).m_OnItemData;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnSuggestedItemDataHandler);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction3);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listThumbnailSuggested).m_OnItemTap;
			UnityAction<ListEventData> unityAction4 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnSuggestedItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction4);
			Button.ButtonClickedEvent onClick = _btnRefresh.ButtonComponent.m_OnClick;
			UnityAction call = onRefreshClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnReset.ButtonComponent.m_OnClick;
			UnityAction call2 = OnResetClickedHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSuggestedPreviewClose.m_OnClick;
			UnityAction call3 = OnPreviewCloseHandler;
			onClick3.AddListener(call3);
			LoopScrollRect.ListEvents onItemData3 = ((LoopScrollRect)_listSuggestedFull).m_OnItemData;
			UnityAction<ListEventData> unityAction5 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnSuggestesItemDataHandler);
			((UnityEvent<T0>)(object)onItemData3).AddListener((UnityAction<>)(object)unityAction5);
		}

		[Cpp2IlInjected.Token(Token = "0x6002961")]
		[Cpp2IlInjected.Address(RVA = "0x9BDEE0", Offset = "0x9BC8E0", VA = "0x1809BDEE0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0123
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPlayers).m_OnItemData;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPlayerItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemData2 = ((LoopScrollRect)_listThumbnailSuggested).m_OnItemData;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnSuggestedItemDataHandler);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction3);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listThumbnailSuggested).m_OnItemTap;
			UnityAction<ListEventData> unityAction4 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnSuggestedItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction4);
			Button.ButtonClickedEvent onClick = _btnRefresh.ButtonComponent.m_OnClick;
			UnityAction call = onRefreshClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnReset.ButtonComponent.m_OnClick;
			UnityAction call2 = OnResetClickedHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSuggestedPreviewClose.m_OnClick;
			UnityAction call3 = OnPreviewCloseHandler;
			onClick3.RemoveListener(call3);
			LoopScrollRect.ListEvents onItemData3 = ((LoopScrollRect)_listSuggestedFull).m_OnItemData;
			UnityAction<ListEventData> unityAction5 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnSuggestesItemDataHandler);
			((UnityEvent<T0>)(object)onItemData3).RemoveListener((UnityAction<>)(object)unityAction5);
		}

		[Cpp2IlInjected.Token(Token = "0x6002962")]
		[Cpp2IlInjected.Address(RVA = "0x9BE920", Offset = "0x9BD320", VA = "0x1809BE920")]
		private void OnResetClickedHandler()
		{
			//Discarded unreachable code: IL_0011
			_tfInput.text = "";
		}

		[Cpp2IlInjected.Token(Token = "0x6002963")]
		[Cpp2IlInjected.Address(RVA = "0x9BF430", Offset = "0x9BDE30", VA = "0x1809BF430")]
		private void onRefreshClickHandler()
		{
			//Discarded unreachable code: IL_0034
			bool activeSelf = _listPlayers.gameObject.activeSelf;
			CancellationToken cancellationToken = CancellationToken;
			if (!activeSelf)
			{
				Task task = RefreshSuggested(cancellationToken);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002964")]
		[Cpp2IlInjected.Address(RVA = "0x9BE580", Offset = "0x9BCF80", VA = "0x1809BE580")]
		private void OnPlayerItemDataHandler(ListEventData args)
		{
			//IL_0015: Expected O, but got I4
			//IL_00c5: Expected O, but got I4
			PhonePlayerItem component = args.DisplayObject.GetComponent<PhonePlayerItem>();
			int num = 0;
			if (!(component != (UnityEngine.Object)num))
			{
				return;
			}
			PhonePlayerItem.SearchPlayerActionDelegate value = OnSearchPlayerAction;
			PhonePlayerItem.SearchPlayerActionDelegate onSearchPlayerActionClicked = component.OnSearchPlayerActionClicked;
			Delegate @delegate = Delegate.Remove(onSearchPlayerActionClicked, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onSearchPlayerActionClicked)
				{
				}
				PhonePlayerItem.SearchPlayerActionDelegate b = OnSearchPlayerAction;
				PhonePlayerItem.SearchPlayerActionDelegate onSearchPlayerActionClicked2 = component.OnSearchPlayerActionClicked;
				Delegate delegate2 = Delegate.Combine(onSearchPlayerActionClicked2, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onSearchPlayerActionClicked2)
					{
					}
					int itemIndex = args.ItemIndex;
					FollowData followData = (component.PlayerData = Enumerable.ElementAt<FollowData>((IEnumerable<>)_lastSearch, itemIndex));
					HttpImageLoader mcAvatar = component._mcAvatar;
					if ((object)mcAvatar != null)
					{
						string avatar_ = component.PlayerData.avatar_;
						int num2 = 0;
						mcAvatar.LoadImage(avatar_, (Action)num2);
					}
					FollowData playerData = component.PlayerData;
					TextBase tfName = component._tfName;
					string text = (tfName.Text = playerData.displayName_);
					int num3 = 0;
					FriendManager instance = FriendManager.Instance;
					string playfabId_ = component.PlayerData.playfabId_;
					bool flag = instance.IsFollowing(playfabId_);
					BaseButton btnAddRemove = component._btnAddRemove;
					if (!flag)
					{
						btnAddRemove.BackgroundSpriteAtlas.ImageAddress = "icon_friend_add";
						return;
					}
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002965")]
		[Cpp2IlInjected.Address(RVA = "0x9BE970", Offset = "0x9BD370", VA = "0x1809BE970")]
		private void OnSearchPlayerAction(PhonePlayerItem item)
		{
			CancellationToken cancellationToken = CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002966")]
		[Cpp2IlInjected.Address(RVA = "0x9BF090", Offset = "0x9BDA90", VA = "0x1809BF090")]
		[AsyncStateMachine(typeof(_003CSearchPlayerActionTask_003Ed__24))]
		private Task SearchPlayerActionTask(PhonePlayerItem playerItem, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002967")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0")]
		private void OnDisable()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6002968")]
		[Cpp2IlInjected.Address(RVA = "0x9BE290", Offset = "0x9BCC90", VA = "0x1809BE290")]
		private void OnInputTextChanged(string text)
		{
			//Discarded unreachable code: IL_0092
			StopAllCoroutines();
			string text2 = ((TMP_InputField)_tfInput).m_Text;
			BaseButton btnReset = _btnReset;
			if ((object)typeof(MoreAsync).TypeHandle == null)
			{
				btnReset.gameObject.SetActive(value: true);
				GameObject mcLabel = _mcLabel;
				int active = 0;
				mcLabel.SetActive((byte)active != 0);
				int _003C_003E1__state = default(int);
				_003CWaitBeforeSearch_003Ed__27 _003CWaitBeforeSearch_003Ed__ = new _003CWaitBeforeSearch_003Ed__27(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CWaitBeforeSearch_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CWaitBeforeSearch_003Ed__);
			}
			else
			{
				GameObject gameObject = btnReset.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
				_mcLabel.SetActive(value: true);
				CancellationToken cancellationToken = CancellationToken;
				RefreshSuggested(cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002969")]
		[Cpp2IlInjected.Address(RVA = "0x9BF3C0", Offset = "0x9BDDC0", VA = "0x1809BF3C0")]
		[IteratorStateMachine(typeof(_003CWaitBeforeSearch_003Ed__27))]
		private IEnumerator WaitBeforeSearch()
		{
			int _003C_003E1__state = default(int);
			_003CWaitBeforeSearch_003Ed__27 _003CWaitBeforeSearch_003Ed__ = new _003CWaitBeforeSearch_003Ed__27(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitBeforeSearch_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600296A")]
		[Cpp2IlInjected.Address(RVA = "0x9BF1B0", Offset = "0x9BDBB0", VA = "0x1809BF1B0")]
		[AsyncStateMachine(typeof(_003CSearchTask_003Ed__28))]
		private Task SearchTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600296B")]
		[Cpp2IlInjected.Address(RVA = "0x9BEF60", Offset = "0x9BD960", VA = "0x1809BEF60")]
		[AsyncStateMachine(typeof(_003CRefreshSuggested_003Ed__29))]
		private Task RefreshSuggested(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600296C")]
		[Cpp2IlInjected.Address(RVA = "0x9BEAE0", Offset = "0x9BD4E0", VA = "0x1809BEAE0")]
		private void OnSuggestedItemDataHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0052
			//IL_0015: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			PhonePostItem component = args.DisplayObject.GetComponent<PhonePostItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int itemIndex = args.ItemIndex;
				NewsFeedPost newsFeedPost = (component.NewsFeedInfo = Enumerable.ElementAt<NewsFeedPost>((IEnumerable<>)_currentSuggestedList, itemIndex));
				HttpImageLoader mcImage = component._mcImage;
				string url_ = newsFeedPost.url_;
				int num2 = 0;
				mcImage.LoadImage(url_, (Action)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600296D")]
		[Cpp2IlInjected.Address(RVA = "0x9BEBE0", Offset = "0x9BD5E0", VA = "0x1809BEBE0")]
		private void OnSuggestedItemTapHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_009f
			//IL_0015: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			PhonePostItem component = args.DisplayObject.GetComponent<PhonePostItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				GameObject gameObject = _mcSeachContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				_mcSuggestedContent.gameObject.SetActive(value: true);
				RectTransform content = ((LoopScrollRect)_listSuggestedFull).m_Content;
				int num2 = 0;
				Vector2 anchoredPosition = content.anchoredPosition;
				content.anchoredPosition = (Vector2)num2;
				List<NewsFeedPost> currentSuggestedList = _currentSuggestedList;
				LoopVerticalScrollRect listSuggestedFull = _listSuggestedFull;
				int num3 = (listSuggestedFull.totalCount = ((List<>)(object)currentSuggestedList)._size);
				LoopVerticalScrollRect listSuggestedFull2 = _listSuggestedFull;
				int itemIndex = args.ItemIndex;
				listSuggestedFull2.RefillCells(itemIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600296E")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8C0", Offset = "0x9BD2C0", VA = "0x1809BE8C0")]
		private void OnPreviewCloseHandler()
		{
			//Discarded unreachable code: IL_0027
			_mcSeachContent.gameObject.SetActive(value: true);
			GameObject gameObject = _mcSuggestedContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600296F")]
		[Cpp2IlInjected.Address(RVA = "0x9BED60", Offset = "0x9BD760", VA = "0x1809BED60")]
		private void OnSuggestesItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002970")]
		[Cpp2IlInjected.Address(RVA = "0x9BE410", Offset = "0x9BCE10", VA = "0x1809BE410")]
		private void OnLikeHandler(FeedItem post)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002971")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDB0", Offset = "0x9BC7B0", VA = "0x1809BDDB0")]
		[AsyncStateMachine(typeof(_003CLikeTask_003Ed__35))]
		private Task LikeTask(CancellationToken ct, FeedItem post)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002972")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PhoneSearchTabContent()
		{
		}
	}
}
