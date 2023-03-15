using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000617")]
	public class MailTabButton : NavigationBarButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40021DC")]
		public GameObject _redDot;

		[Cpp2IlInjected.Token(Token = "0x60027CF")]
		[Cpp2IlInjected.Address(RVA = "0xF9F770", Offset = "0xF9E170", VA = "0x180F9F770")]
		public void Start()
		{
			//Discarded unreachable code: IL_001c
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnButtonSelected;
			onSelected.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60027D0")]
		[Cpp2IlInjected.Address(RVA = "0xF9F6E0", Offset = "0xF9E0E0", VA = "0x180F9F6E0")]
		public void OnDestroy()
		{
			//Discarded unreachable code: IL_001c
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnButtonSelected;
			onSelected.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60027D1")]
		[Cpp2IlInjected.Address(RVA = "0xF9F6C0", Offset = "0xF9E0C0", VA = "0x180F9F6C0")]
		private void OnButtonSelected()
		{
			//Discarded unreachable code: IL_0008
			base.IsSelected = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60027D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public MailTabButton()
		{
		}
	}
}
