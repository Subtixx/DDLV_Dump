using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public class Tooltip : PopupBase
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x17F28B0", Offset = "0x17F12B0", VA = "0x1817F28B0")]
		public void SetContent(string tooltip, PointerEventData pointer)
		{
			//Discarded unreachable code: IL_0014
			label.text = tooltip;
			SetPointer(pointer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0", Slot = "4")]
		protected override void DestroySelf()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public Tooltip()
		{
		}
	}
}
