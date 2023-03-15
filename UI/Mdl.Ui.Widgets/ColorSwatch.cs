using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000971")]
	public class ColorSwatch : ColorPicker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003801")]
		[SerializeField]
		private Image _image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003802")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003803")]
		public GameObject selected;

		[Cpp2IlInjected.Token(Token = "0x17000812")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003B62")]
			[Cpp2IlInjected.Address(RVA = "0x14A1560", Offset = "0x149FF60", VA = "0x1814A1560", Slot = "4")]
			get
			{
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B63")]
			[Cpp2IlInjected.Address(RVA = "0x14A15A0", Offset = "0x149FFA0", VA = "0x1814A15A0", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_0008
				Image image = _image;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B64")]
		[Cpp2IlInjected.Address(RVA = "0xAE20C0", Offset = "0xAE0AC0", VA = "0x180AE20C0")]
		public ColorSwatch()
		{
		}
	}
}
