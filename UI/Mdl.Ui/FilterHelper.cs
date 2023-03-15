using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000842")]
	public class FilterHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6003485")]
		[Cpp2IlInjected.Address(RVA = "0x1533300", Offset = "0x1531D00", VA = "0x181533300")]
		public void ShowHighlight(ButtonTmPro button)
		{
			//Discarded unreachable code: IL_0035
			//IL_0009: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			int num = 0;
			if (button != (Object)num && button.Selectable.m_Interactable)
			{
				ResetFilterBtnStateHandler component = button.GetComponent<ResetFilterBtnStateHandler>();
				int num2 = 0;
				if (component != (Object)num2)
				{
					component.Press();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003486")]
		[Cpp2IlInjected.Address(RVA = "0x1533230", Offset = "0x1531C30", VA = "0x181533230")]
		public void RemoveHighlight(ButtonTmPro button)
		{
			//Discarded unreachable code: IL_0027
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (button != (Object)num)
			{
				ResetFilterBtnStateHandler component = button.GetComponent<ResetFilterBtnStateHandler>();
				int num2 = 0;
				if (component != (Object)num2)
				{
					component.Release();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003487")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FilterHelper()
		{
		}
	}
}
