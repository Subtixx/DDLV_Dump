using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200036D")]
	public class CookbookFocusElement : FocusNavigationElement
	{
		[Cpp2IlInjected.Token(Token = "0x60015EB")]
		[Cpp2IlInjected.Address(RVA = "0x14A38F0", Offset = "0x14A22F0", VA = "0x1814A38F0", Slot = "21")]
		public override void Click(ShortcutDefinition shortcut)
		{
			//Discarded unreachable code: IL_0080
			//IL_002c: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			BaseButton infoButton = default(BaseButton);
			if (shortcut.RedirectionType <= (RedirectionType)1)
			{
				if (!InfoButton.gameObject.activeSelf)
				{
				}
				infoButton = InfoButton;
			}
			int num = 0;
			if (infoButton != (Object)num && infoButton.enabled && infoButton.gameObject.activeSelf && infoButton.gameObject.activeInHierarchy)
			{
				Button buttonComponent = infoButton.ButtonComponent;
				int num2 = 0;
				if (buttonComponent != (Object)num2)
				{
					Button buttonComponent2 = infoButton.ButtonComponent;
					infoButton.ButtonComponent.m_OnClick.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015EC")]
		[Cpp2IlInjected.Address(RVA = "0x14A3A90", Offset = "0x14A2490", VA = "0x1814A3A90")]
		public CookbookFocusElement()
		{
		}
	}
}
