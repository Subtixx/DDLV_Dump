using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[RequireComponent(typeof(CanvasGroup))]
	public class RecordingModeComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private bool _isShown = true;

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		private CanvasGroup CanvasGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7E0", Offset = "0xF391E0", VA = "0x180F3A7E0")]
			get
			{
				return GetComponent<CanvasGroup>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return _isShown;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0xF3A820", Offset = "0xF39220", VA = "0x180F3A820")]
			set
			{
				//Discarded unreachable code: IL_0011
				_isShown = value;
				CanvasGroup component = GetComponent<CanvasGroup>();
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x8CA520", Offset = "0x8C8F20", VA = "0x1808CA520")]
		public RecordingModeComponent()
		{
		}
	}
}
