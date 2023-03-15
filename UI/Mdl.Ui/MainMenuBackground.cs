using System.Xml;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200025C")]
	public class MainMenuBackground : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A9D")]
		public LayoutElement Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A9E")]
		public LayoutElement Right;

		[Cpp2IlInjected.Token(Token = "0x6000F0E")]
		[Cpp2IlInjected.Address(RVA = "0xFA3150", Offset = "0xFA1B50", VA = "0x180FA3150")]
		internal void SetLeftWidth(float width)
		{
			//Discarded unreachable code: IL_0025
			Left.preferredWidth = width;
			Left.minWidth = width;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)Right).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MainMenuBackground()
		{
		}
	}
}
