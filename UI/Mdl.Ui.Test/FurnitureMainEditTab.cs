using System.Xml;
using Cpp2IlInjected;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x200092C")]
	internal class FurnitureMainEditTab : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400361E")]
		[SerializeField]
		private Tab _tab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400361F")]
		[SerializeField]
		private Text _label;

		[Cpp2IlInjected.Token(Token = "0x170007F5")]
		public Tab Tab
		{
			[Cpp2IlInjected.Token(Token = "0x60039C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _tab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039C8")]
		[Cpp2IlInjected.Address(RVA = "0x887740", Offset = "0x886140", VA = "0x180887740")]
		public void Init(string label)
		{
			//Discarded unreachable code: IL_000d
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)_label).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x60039C9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FurnitureMainEditTab()
		{
		}
	}
}
