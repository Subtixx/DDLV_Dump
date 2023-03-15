using System.Xml;
using Cpp2IlInjected;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	public class CheatTab : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		[SerializeField]
		private Tab _tab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public Tab Tab
		{
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _tab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x1000BF0", Offset = "0xFFF5F0", VA = "0x181000BF0")]
		public void Init(int index, string name, bool isOn)
		{
			//Discarded unreachable code: IL_002e
			base.gameObject.name = name;
			Tab tab = _tab;
			Index = index;
			tab.IsOn = isOn;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)_name).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CheatTab()
		{
		}
	}
}
