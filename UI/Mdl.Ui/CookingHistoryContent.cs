using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000378")]
	[RequiredAllNotNull]
	public class CookingHistoryContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000379")]
		public delegate void OnCloseDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010D4")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010D5")]
		[SerializeField]
		private LoopVerticalScrollRect _listHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010D6")]
		public OnCloseDelegate OnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40010D7")]
		private bool _forceUpdate = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010D8")]
		private RepeatedField<CookingHistory> _history;

		[Cpp2IlInjected.Token(Token = "0x600162C")]
		[Cpp2IlInjected.Address(RVA = "0x14A7190", Offset = "0x14A5B90", VA = "0x1814A7190")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0041
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.AddListener(call);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listHistory).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnHistoryListItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600162D")]
		[Cpp2IlInjected.Address(RVA = "0x14A7700", Offset = "0x14A6100", VA = "0x1814A7700")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_005d
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.RemoveListener(call);
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listHistory).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnHistoryListItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			int _003C_003E1__state = default(int);
			_003CGotoEnd_003Ed__11 _003CGotoEnd_003Ed__ = new _003CGotoEnd_003Ed__11(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CGotoEnd_003Ed__._003C_003E4__this = this;
			StopCoroutine(_003CGotoEnd_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x600162E")]
		[Cpp2IlInjected.Address(RVA = "0x14A7880", Offset = "0x14A6280", VA = "0x1814A7880")]
		private void OnHistoryListItemDataHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_003e
			//IL_0015: Expected O, but got I4
			CookingHistoryItem component = args.DisplayObject.GetComponent<CookingHistoryItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				RepeatedField<CookingHistory> history = _history;
				int itemIndex = args.ItemIndex;
				CookingHistory cookingHistory = (component.HistoryInfo = (CookingHistory)((RepeatedField<T>)(object)history)[itemIndex]);
				component.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600162F")]
		[Cpp2IlInjected.Address(RVA = "0xF182C0", Offset = "0xF16CC0", VA = "0x180F182C0")]
		private void OnCloseClickHandler()
		{
			OnClose?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001630")]
		[Cpp2IlInjected.Address(RVA = "0x14A7490", Offset = "0x14A5E90", VA = "0x1814A7490")]
		internal void Init()
		{
			//Discarded unreachable code: IL_00d7
			if (_forceUpdate)
			{
				_forceUpdate = false;
				RepeatedField<CookingHistory> repeatedField = (_history = SystemRoot.Instance.MetaClient.profile.player_.cookingHistory_);
				if (((RepeatedField<T>)(object)_history).Count > 8)
				{
					RectTransform content = ((LoopScrollRect)_listHistory).m_Content;
					RectTransform content2 = ((LoopScrollRect)_listHistory).m_Content;
					RectTransform content3 = ((LoopScrollRect)_listHistory).m_Content;
					RectTransform content4 = ((LoopScrollRect)_listHistory).m_Content;
					int num = 0;
					Vector2 vector = (content4.anchoredPosition = Vector2.zero);
				}
				RepeatedField<CookingHistory> history = _history;
				LoopVerticalScrollRect listHistory = _listHistory;
				int num2 = (listHistory.totalCount = ((RepeatedField<T>)(object)history).Count);
				LoopVerticalScrollRect listHistory2 = _listHistory;
				int offset = 0;
				listHistory2.RefillCells(offset);
				RefreshScrollbarVisibility();
				IEnumerator routine = GotoEnd();
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001631")]
		[Cpp2IlInjected.Address(RVA = "0x14A7420", Offset = "0x14A5E20", VA = "0x1814A7420")]
		[IteratorStateMachine(typeof(_003CGotoEnd_003Ed__11))]
		private IEnumerator GotoEnd()
		{
			int _003C_003E1__state = default(int);
			_003CGotoEnd_003Ed__11 _003CGotoEnd_003Ed__ = new _003CGotoEnd_003Ed__11(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CGotoEnd_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001632")]
		[Cpp2IlInjected.Address(RVA = "0x14A72B0", Offset = "0x14A5CB0", VA = "0x1814A72B0")]
		public void ForceUpdate()
		{
			//Discarded unreachable code: IL_0068
			if (!base.gameObject.activeSelf)
			{
				_forceUpdate = true;
				return;
			}
			RepeatedField<CookingHistory> repeatedField = (_history = SystemRoot.Instance.MetaClient.profile.player_.cookingHistory_);
			RepeatedField<CookingHistory> history = _history;
			LoopVerticalScrollRect listHistory = _listHistory;
			int num = (listHistory.totalCount = ((RepeatedField<T>)(object)history).Count);
			LoopVerticalScrollRect listHistory2 = _listHistory;
			int offset = 0;
			listHistory2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6001633")]
		[Cpp2IlInjected.Address(RVA = "0x14A7B60", Offset = "0x14A6560", VA = "0x1814A7B60")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_0055
			//IL_0035: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			if (base.gameObject.activeSelf && ((LoopScrollRect)_listHistory).m_Content.childCount > 0)
			{
				if ((object)GetComponentInParent<MenuNavigation>() != null)
				{
				}
				int num = 0;
				int num2 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
				{
					RectTransform content = ((LoopScrollRect)_listHistory).m_Content;
					int index = 0;
					FocusNavigationElement component = content.GetChild(index).GetComponent<FocusNavigationElement>();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001634")]
		[Cpp2IlInjected.Address(RVA = "0x14A7970", Offset = "0x14A6370", VA = "0x1814A7970")]
		private void RefreshScrollbarVisibility()
		{
			//Discarded unreachable code: IL_0070
			//IL_0022: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			Scrollbar verticalScrollbar = ((LoopScrollRect)_listHistory).m_VerticalScrollbar;
			if ((object)verticalScrollbar != null)
			{
				CanvasGroup component = verticalScrollbar.GetComponent<CanvasGroup>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				((LoopScrollRect)_listHistory).m_Content.RebuildLayout();
				RectTransform content = ((LoopScrollRect)_listHistory).m_Content;
				RectTransform viewport = ((LoopScrollRect)_listHistory).m_Viewport;
				int num3 = 0;
				RectTransform content2 = ((LoopScrollRect)_listHistory).m_Content;
				RectTransform viewport2 = ((LoopScrollRect)_listHistory).m_Viewport;
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001635")]
		[Cpp2IlInjected.Address(RVA = "0x1005F70", Offset = "0x1004970", VA = "0x181005F70")]
		public CookingHistoryContent()
		{
		}
	}
}
