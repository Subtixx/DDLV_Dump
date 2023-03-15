using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000348")]
	public class BackpackActionList : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000349")]
		public struct ActionItemData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000F73")]
			public bool isInactive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000F74")]
			public string stringID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000F75")]
			public Action action;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F6C")]
		public UnityEvent OnListActionDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F6D")]
		[SerializeField]
		private ListBase _actionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F6E")]
		[SerializeField]
		private RectTransform _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F6F")]
		[SerializeField]
		private CanvasGroup _group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F70")]
		private List<ActionItemData> _actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F71")]
		private Transform _parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F72")]
		private BaseButton _buttonClickedOn;

		[Cpp2IlInjected.Token(Token = "0x1700038A")]
		public RectTransform ContentRectTransform
		{
			[Cpp2IlInjected.Token(Token = "0x60014A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _background;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		public ListBase ActionList
		{
			[Cpp2IlInjected.Token(Token = "0x60014A7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _actionList;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		public List<ActionItemData> Actions
		{
			[Cpp2IlInjected.Token(Token = "0x60014A8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _actions;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A9")]
		[Cpp2IlInjected.Address(RVA = "0x88DC20", Offset = "0x88C620", VA = "0x18088DC20")]
		private void Awake()
		{
			Transform transform = (_parent = base.transform.parent);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014AA")]
		[Cpp2IlInjected.Address(RVA = "0x88DC60", Offset = "0x88C660", VA = "0x18088DC60")]
		public void Init(List<ActionItemData> actions, GameObject target)
		{
			//Discarded unreachable code: IL_019d
			//IL_0012: Expected F4, but got I4
			//IL_002e: Expected O, but got I4
			//IL_008b: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			CanvasGroup group = _group;
			int num = 0;
			int num2 = 0;
			group.alpha = num2;
			_actions = actions;
			int num3 = 0;
			if ((object)target != null)
			{
				BaseButton component = target.GetComponent<BaseButton>();
			}
			_buttonClickedOn = (BaseButton)num3;
			GameObject gameObject = _actionList.gameObject;
			List<ActionItemData> actions2 = _actions;
			if (actions2 == null)
			{
			}
			bool active = Enumerable.Any<ActionItemData>((IEnumerable<>)actions2);
			gameObject.SetActive(active);
			List<ActionItemData> actions3 = _actions;
			if (actions3 == null || !Enumerable.Any<ActionItemData>((IEnumerable<>)actions3))
			{
				return;
			}
			BaseButton buttonClickedOn = _buttonClickedOn;
			int num4 = 0;
			if (buttonClickedOn != (UnityEngine.Object)num4)
			{
				_buttonClickedOn.IgnoreHighlightExit = true;
			}
			List<ActionItemData> actions4 = _actions;
			ListBase actionList = _actionList;
			int num5 = (actionList.TotalCount = ((List<>)(object)actions4)._size);
			_actionList.m_Content.RebuildLayout();
			Transform transform = _actionList.transform;
			if ((object)transform != null)
			{
			}
			int num6 = 0;
			if (target != (UnityEngine.Object)num6)
			{
				Transform parent = target.transform;
				int worldPositionStays = 0;
				transform.SetParent(parent, (byte)worldPositionStays != 0);
				float z = Vector3.zero.z;
				Transform parent2 = _parent;
				transform.SetParent(parent2, worldPositionStays: true);
				if ((object)GetComponentInParent<Menu>().transform != null)
				{
				}
				bool flag = default(bool);
				if (!flag)
				{
					Transform transform2 = target.transform;
					int num7 = 0;
				}
			}
			ListBase actionList2 = _actionList;
			RectTransform background = _background;
			Vector2 vector = (background.anchoredPosition = actionList2.m_Content.anchoredPosition);
			ListBase actionList3 = _actionList;
			RectTransform background2 = _background;
			Vector2 vector2 = (background2.sizeDelta = actionList3.m_Content.sizeDelta);
			_group.alpha = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x60014AB")]
		[Cpp2IlInjected.Address(RVA = "0x88E3C0", Offset = "0x88CDC0", VA = "0x18088E3C0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0028
			ListBase actionList = _actionList;
			int num2 = (actionList.TotalCount = 0);
			OnListActionDisabled?.Invoke();
			ResetButtonClickedOn();
		}

		[Cpp2IlInjected.Token(Token = "0x60014AC")]
		[Cpp2IlInjected.Address(RVA = "0x88E530", Offset = "0x88CF30", VA = "0x18088E530")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0082
			//IL_0041: Expected O, but got I4
			if (_actionList.m_Content.childCount <= 0)
			{
				return;
			}
			ISupportsFocusNavigation focusedElement = focusNavigation._focusedElement;
			int num = 0;
			if (focusedElement != null)
			{
				int num2 = 0;
				if (focusedElement == null)
				{
					throw new InvalidCastException();
				}
				BaseButton buttonClickedOn = default(BaseButton);
				_buttonClickedOn = buttonClickedOn;
			}
			BaseButton buttonClickedOn2 = _buttonClickedOn;
			int num3 = 0;
			if (buttonClickedOn2 != (UnityEngine.Object)num3)
			{
				_buttonClickedOn.IgnoreHighlightExit = true;
			}
			RectTransform content = _actionList.m_Content;
			int index = 0;
			Transform child = content.GetChild(index);
			FocusNavigationElement component = default(FocusNavigationElement);
			if ((object)child != null)
			{
				component = child.GetComponent<FocusNavigationElement>();
			}
			focusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60014AD")]
		[Cpp2IlInjected.Address(RVA = "0x88E0D0", Offset = "0x88CAD0", VA = "0x18088E0D0")]
		public void OnActionItemData(ListBase.ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60014AE")]
		[Cpp2IlInjected.Address(RVA = "0x88E390", Offset = "0x88CD90", VA = "0x18088E390")]
		public void OnActionItemTap(ListBase.ListEventData data)
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = _actionList.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60014AF")]
		[Cpp2IlInjected.Address(RVA = "0x88E410", Offset = "0x88CE10", VA = "0x18088E410")]
		public void ResetButtonClickedOn()
		{
			//Discarded unreachable code: IL_0057
			//IL_0010: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_0056: Expected O, but got I8
			BaseButton buttonClickedOn = _buttonClickedOn;
			int num = 0;
			if (buttonClickedOn != (UnityEngine.Object)num)
			{
				_buttonClickedOn.IgnoreHighlightExit = false;
				_buttonClickedOn.OnHighlightExit();
				BackpackSlotInventoryItem component = _buttonClickedOn.GetComponent<BackpackSlotInventoryItem>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					int selectedOutline = 0;
					component.SetSelectedOutline((byte)selectedOutline != 0);
				}
				_buttonClickedOn = (BaseButton)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014B0")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BackpackActionList()
		{
		}
	}
}
