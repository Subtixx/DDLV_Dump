using System;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000493")]
	public class EventRewardItemFocusElement : FocusNavigationGroupedElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40017A4")]
		public BaseButton ButtonNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40017A5")]
		public BaseButton ButtonPrev;

		[Cpp2IlInjected.Token(Token = "0x6001DBF")]
		[Cpp2IlInjected.Address(RVA = "0x1404D50", Offset = "0x1403750", VA = "0x181404D50", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			do
			{
				if (supportsFocusNavigation != null)
				{
					int num = 0;
					if (supportsFocusNavigation != null)
					{
						goto IL_005e;
					}
				}
				if (direction != 0)
				{
					continue;
				}
				if (ButtonPrev.gameObject.activeInHierarchy)
				{
					ButtonPrev.ButtonComponent?.m_OnClick?.Invoke();
					if (base.gameObject.activeInHierarchy && !base.isActiveAndEnabled)
					{
					}
				}
				goto IL_005e;
				IL_005e:
				EventRewardItemFocusElement componentInChildren = GetComponentInChildren<EventRewardItemFocusElement>();
			}
			while (!base.gameObject.activeInHierarchy);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC0")]
		[Cpp2IlInjected.Address(RVA = "0x1404F00", Offset = "0x1403900", VA = "0x181404F00")]
		public EventRewardItemFocusElement()
		{
		}
	}
}
