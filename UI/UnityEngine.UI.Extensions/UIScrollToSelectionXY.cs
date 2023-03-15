using System;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Mdl.Ui;
using Rewired;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[AddComponentMenu("UI/Extensions/UI ScrollTo Selection XY")]
	[RequireComponent(typeof(ScrollRect))]
	public class UIScrollToSelectionXY : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public bool specialSelectionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public RectTransform specialSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public bool cellChildSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public float scrollSpeed = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public bool ignoreInputConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public RectTransform layoutListGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private RectTransform _targetScrollObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private bool _scrollToSelection = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private float _fixedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private RectTransform _scrollWindow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private ScrollRect _targetScrollRect;

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xC99670", Offset = "0xC98070", VA = "0x180C99670")]
		private void Start()
		{
			ScrollRect scrollRect = (_targetScrollRect = GetComponent<ScrollRect>());
			RectTransform rectTransform = (_scrollWindow = _targetScrollRect.GetComponent<RectTransform>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xC99700", Offset = "0xC98100", VA = "0x180C99700")]
		private void Update()
		{
			//Discarded unreachable code: IL_0030
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int num3 = 0;
				if (InputDetectionHelper.GetLastControllerType() == ControllerType.Joystick)
				{
					ScrollRectToLevelSelection();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xC990F0", Offset = "0xC97AF0", VA = "0x180C990F0")]
		private void ScrollRectToLevelSelection()
		{
			//Discarded unreachable code: IL_023f
			//IL_0018: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_00d4: Expected O, but got I4
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected F4, but got Unknown
			int num = 0;
			EventSystem current = EventSystem.current;
			ScrollRect targetScrollRect = _targetScrollRect;
			int num2 = 0;
			if (targetScrollRect == (Object)num2)
			{
				return;
			}
			RectTransform rectTransform = layoutListGroup;
			int num3 = 0;
			if (rectTransform == (Object)num3)
			{
				return;
			}
			RectTransform scrollWindow = _scrollWindow;
			int num4 = 0;
			bool flag = scrollWindow == (Object)num4;
			if (flag)
			{
				return;
			}
			if (specialSelectionMode == flag)
			{
				GameObject currentSelected = current.m_CurrentSelected;
				int num5 = 0;
				if (currentSelected != (Object)num5)
				{
					RectTransform component = current.m_CurrentSelected.GetComponent<RectTransform>();
				}
			}
			RectTransform rectTransform2 = specialSelection;
			RectTransform targetScrollObject = _targetScrollObject;
			if (rectTransform2 != targetScrollObject)
			{
				_scrollToSelection = true;
			}
			RectTransform component2 = default(RectTransform);
			if (cellChildSelection && (object)rectTransform2 != null)
			{
				component2 = rectTransform2.transform.parent.GetComponent<RectTransform>();
			}
			int num6 = 0;
			bool flag2 = component2 == (Object)num6;
			if (flag2 || _scrollToSelection == flag2)
			{
				return;
			}
			Transform parent = component2.transform.parent;
			Transform transform = layoutListGroup.transform;
			if (parent != transform)
			{
				return;
			}
			ScrollRect targetScrollRect2 = _targetScrollRect;
			int num7 = 0;
			int num8 = 0;
			ScrollRect targetScrollRect4 = default(ScrollRect);
			if ((targetScrollRect2.m_Vertical ? 1 : 0) != num7)
			{
				Vector2 anchoredPosition = component2.anchoredPosition;
				RectTransform rectTransform3 = layoutListGroup;
				Vector2 anchoredPosition2 = layoutListGroup.anchoredPosition;
				ScrollRect targetScrollRect3 = _targetScrollRect;
				float verticalNormalizedPosition = targetScrollRect3.verticalNormalizedPosition;
				Vector2 sizeDelta = layoutListGroup.sizeDelta;
				int num9 = 0;
				float deltaTime = Time.deltaTime;
				float verticalNormalizedPosition2 = default(float);
				targetScrollRect3.verticalNormalizedPosition = verticalNormalizedPosition2;
				targetScrollRect4 = _targetScrollRect;
				_fixedPosition = 100f;
			}
			if ((targetScrollRect4.m_Horizontal ? 1 : 0) != num7)
			{
				Vector2 anchoredPosition3 = component2.anchoredPosition;
				RectTransform rectTransform4 = layoutListGroup;
				Vector2 anchoredPosition4 = layoutListGroup.anchoredPosition;
				ScrollRect targetScrollRect5 = _targetScrollRect;
				float horizontalNormalizedPosition = targetScrollRect5.horizontalNormalizedPosition;
				Vector2 sizeDelta2 = layoutListGroup.sizeDelta;
				int num10 = 0;
				float deltaTime2 = Time.deltaTime;
				float num11 = ((UIScrollToSelectionXY)anchoredPosition4).scrollSpeed;
				float num13 = (targetScrollRect5.horizontalNormalizedPosition = /*Error near IL_01ec: Stack underflow*/* num11);
				_fixedPosition = 250f;
				if (ignoreInputConditions && ignoreInputConditions)
				{
					ignoreInputConditions = false;
					specialSelectionMode = false;
				}
			}
			if (num7 != num8)
			{
				_scrollToSelection = false;
				ignoreInputConditions = false;
			}
			_targetScrollObject = component2;
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xC997A0", Offset = "0xC981A0", VA = "0x180C997A0")]
		public UIScrollToSelectionXY()
		{
		}
	}
}
