using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Meta.Social;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200064F")]
	public class PhoneNewsFeedTabContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400234F")]
		[SerializeField]
		private PhoneListScroller _listNews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002350")]
		[SerializeField]
		private Image _mcRefreshIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002351")]
		[SerializeField]
		private Button _btnRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002352")]
		[SerializeField]
		private FeedItem _feedPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002353")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002354")]
		private RepeatedField<NewsFeedPost> _feeds = (RepeatedField<NewsFeedPost>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002355")]
		private bool _isConstructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4002356")]
		private bool _isLoading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4002357")]
		private bool _readyToRefresh;

		[Cpp2IlInjected.Token(Token = "0x6002902")]
		[Cpp2IlInjected.Address(RVA = "0x9BAB20", Offset = "0x9B9520", VA = "0x1809BAB20", Slot = "4")]
		public virtual void Show(bool forceRefresh)
		{
			//Discarded unreachable code: IL_0033
			base.gameObject.SetActive(value: true);
			if (!_isConstructed)
			{
				Construct();
			}
			if (forceRefresh)
			{
				CancellationToken cancellationToken = CancellationToken;
				LoadFeedTask(cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002903")]
		[Cpp2IlInjected.Address(RVA = "0x9B9B20", Offset = "0x9B8520", VA = "0x1809B9B20", Slot = "5")]
		protected virtual void Construct()
		{
			//Discarded unreachable code: IL_00e4
			Button btnRefresh = _btnRefresh;
			_isConstructed = true;
			Button.ButtonClickedEvent onClick = btnRefresh.m_OnClick;
			UnityAction call = OnRefreshClickHandler;
			onClick.AddListener(call);
			ListBase.ListEvents onItemData = _listNews.OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			ScrollRect.ScrollRectEvent onValueChanged = ((ScrollRect)_listNews).m_OnValueChanged;
			UnityAction<Vector2> unityAction2 = (UnityAction<Vector2>)(object)new UnityAction<T0>(OnListScrollHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction2);
			PhoneListScroller listNews = _listNews;
			PhoneListScroller.ScrollDelegate b = OnScrollStart;
			PhoneListScroller.ScrollDelegate scrollStart = listNews.ScrollStart;
			Delegate @delegate = Delegate.Combine(scrollStart, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != scrollStart)
				{
				}
				PhoneListScroller listNews2 = _listNews;
				PhoneListScroller.ScrollDelegate b2 = OnScrollEnd;
				PhoneListScroller.ScrollDelegate scrollEnd = listNews2.ScrollEnd;
				Delegate delegate2 = Delegate.Combine(scrollEnd, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != scrollEnd)
					{
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002904")]
		[Cpp2IlInjected.Address(RVA = "0x9BA150", Offset = "0x9B8B50", VA = "0x1809BA150")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00d9
			Button.ButtonClickedEvent onClick = _btnRefresh.m_OnClick;
			UnityAction call = OnRefreshClickHandler;
			onClick.RemoveListener(call);
			ListBase.ListEvents onItemData = _listNews.OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			ScrollRect.ScrollRectEvent onValueChanged = ((ScrollRect)_listNews).m_OnValueChanged;
			UnityAction<Vector2> unityAction2 = (UnityAction<Vector2>)(object)new UnityAction<T0>(OnListScrollHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction2);
			PhoneListScroller listNews = _listNews;
			PhoneListScroller.ScrollDelegate value = OnScrollStart;
			PhoneListScroller.ScrollDelegate scrollStart = listNews.ScrollStart;
			Delegate @delegate = Delegate.Remove(scrollStart, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != scrollStart)
				{
				}
				PhoneListScroller listNews2 = _listNews;
				PhoneListScroller.ScrollDelegate value2 = OnScrollEnd;
				PhoneListScroller.ScrollDelegate scrollEnd = listNews2.ScrollEnd;
				Delegate delegate2 = Delegate.Remove(scrollEnd, value2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != scrollEnd)
					{
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002905")]
		[Cpp2IlInjected.Address(RVA = "0x9BAA90", Offset = "0x9B9490", VA = "0x1809BAA90")]
		private void OnScrollEnd()
		{
			_readyToRefresh = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002906")]
		[Cpp2IlInjected.Address(RVA = "0x9BAAA0", Offset = "0x9B94A0", VA = "0x1809BAAA0")]
		private void OnScrollStart()
		{
			_readyToRefresh = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002907")]
		[Cpp2IlInjected.Address(RVA = "0x9BA7F0", Offset = "0x9B91F0", VA = "0x1809BA7F0")]
		private void OnListScrollHandler(Vector2 arg)
		{
			//Discarded unreachable code: IL_002b, IL_0047, IL_004f
			//IL_002a: Expected O, but got I4
			if (!_isLoading)
			{
				Vector2 anchoredPosition = ((ScrollRect)_listNews).m_Content.anchoredPosition;
				Image mcRefreshIcon = _mcRefreshIcon;
				int num = 0;
				mcRefreshIcon.color = (Color)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002908")]
		[Cpp2IlInjected.Address(RVA = "0x9B9E60", Offset = "0x9B8860", VA = "0x1809B9E60")]
		public void Hide()
		{
			//Discarded unreachable code: IL_003a
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			RepeatedField<NewsFeedPost> feeds = _feeds;
			PhoneListScroller listNews = _listNews;
			int num = (listNews.TotalCount = ((RepeatedField<T>)(object)feeds).Count);
			_listNews.RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x6002909")]
		[Cpp2IlInjected.Address(RVA = "0x9BA020", Offset = "0x9B8A20", VA = "0x1809BA020")]
		[AsyncStateMachine(typeof(_003CLoadFeedTask_003Ed__16))]
		private Task LoadFeedTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600290A")]
		[Cpp2IlInjected.Address(RVA = "0x9BAAB0", Offset = "0x9B94B0", VA = "0x1809BAAB0")]
		private void RefreshNewsFeedList()
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<NewsFeedPost> feeds = _feeds;
			PhoneListScroller listNews = _listNews;
			int num = (listNews.TotalCount = ((RepeatedField<T>)(object)feeds).Count);
			_listNews.RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x600290B")]
		[Cpp2IlInjected.Address(RVA = "0x9BA490", Offset = "0x9B8E90", VA = "0x1809BA490")]
		private void OnItemDataHandler(ListBase.ListEventData args)
		{
			//Discarded unreachable code: IL_00a4
			//IL_0015: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			FeedItem component = args.DisplayObject.GetComponent<FeedItem>();
			int num = 0;
			if (component == (UnityEngine.Object)num)
			{
				return;
			}
			RepeatedField<NewsFeedPost> feeds = _feeds;
			int itemIndex = args.ItemIndex;
			NewsFeedPost newsFeedInfo = (NewsFeedPost)((RepeatedField<T>)(object)feeds)[itemIndex];
			component.RefreshData(newsFeedInfo);
			FeedItem.OnLikePost onLike = component.OnLike;
			FeedItem.OnLikePost value = OnLikeHandler;
			Delegate @delegate = Delegate.Remove(onLike, value);
			int num2 = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				component.OnLike = (FeedItem.OnLikePost)num2;
				FeedItem.OnLikePost onLike2 = component.OnLike;
				FeedItem.OnLikePost b = OnLikeHandler;
				Delegate delegate2 = Delegate.Combine(onLike2, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					component.OnLike = (FeedItem.OnLikePost)delegate2;
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600290C")]
		[Cpp2IlInjected.Address(RVA = "0x9BA680", Offset = "0x9B9080", VA = "0x1809BA680")]
		private void OnLikeHandler(FeedItem post)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600290D")]
		[Cpp2IlInjected.Address(RVA = "0x9B9EF0", Offset = "0x9B88F0", VA = "0x1809B9EF0")]
		[AsyncStateMachine(typeof(_003CLikeTask_003Ed__20))]
		private Task LikeTask(CancellationToken ct, FeedItem post)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600290E")]
		[Cpp2IlInjected.Address(RVA = "0x9BAA20", Offset = "0x9B9420", VA = "0x1809BAA20")]
		private void OnRefreshClickHandler()
		{
			CancellationToken cancellationToken = CancellationToken;
			LoadFeedTask(cancellationToken).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600290F")]
		[Cpp2IlInjected.Address(RVA = "0x9BABE0", Offset = "0x9B95E0", VA = "0x1809BABE0")]
		public PhoneNewsFeedTabContent()
		{
		}
	}
}
