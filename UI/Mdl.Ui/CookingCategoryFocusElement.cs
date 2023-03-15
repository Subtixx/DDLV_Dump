using System;
using Cpp2IlInjected;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000374")]
	public class CookingCategoryFocusElement : FocusNavigationGroupedElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40010C5")]
		public BaseButton ButtonPageUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40010C6")]
		public BaseButton ButtonPageDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40010C7")]
		public RectMask2D RectMask2D;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40010C8")]
		public FocusNavigationElement StartCookingButton;

		[Cpp2IlInjected.Token(Token = "0x6001617")]
		[Cpp2IlInjected.Address(RVA = "0x14A5C90", Offset = "0x14A4690", VA = "0x1814A5C90", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//Discarded unreachable code: IL_0071
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			if (supportsFocusNavigation != null || (direction == FocusDirection.Down && (IntPtr)(StartCookingButton.IgnoreThis ? 1 : 0) == (IntPtr)supportsFocusNavigation))
			{
				int num = 0;
				int num2 = 0;
				RectTransform rectTransform = RectMask2D.rectTransform;
				Transform transform = default(Transform);
				if ((object)transform != null)
				{
				}
				RectTransform rectTransform2 = RectMask2D.rectTransform;
				RectTransform rectTransform3 = RectMask2D.rectTransform;
				ButtonPageDown.ButtonComponent?.m_OnClick?.Invoke();
			}
			return supportsFocusNavigation;
		}

		[Cpp2IlInjected.Token(Token = "0x6001618")]
		[Cpp2IlInjected.Address(RVA = "0x14A5B90", Offset = "0x14A4590", VA = "0x1814A5B90", Slot = "22")]
		public override void Click(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_0048
			//IL_0010: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			TemplateButton clickButton = ClickButton;
			int num = 0;
			if (!(clickButton != (UnityEngine.Object)num))
			{
				return;
			}
			TemplateButton clickButton2 = ClickButton;
			if (clickButton2._interactable)
			{
				FilterItem component = clickButton2.GetComponent<FilterItem>();
				int num2 = 0;
				bool flag = component != (UnityEngine.Object)num2;
				if (flag && (flag ? 1 : 0) <= (true ? 1 : 0))
				{
					component.Click();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001619")]
		[Cpp2IlInjected.Address(RVA = "0x1404F00", Offset = "0x1403900", VA = "0x181404F00")]
		public CookingCategoryFocusElement()
		{
		}
	}
}
