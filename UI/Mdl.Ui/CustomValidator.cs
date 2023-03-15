using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using TMPro;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200027B")]
	public class CustomValidator : TMP_InputValidator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B45")]
		private Regex _spaces = new Regex("\\s+");

		[Cpp2IlInjected.Token(Token = "0x170002EF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000B44")]
		public bool DoNotAddCharacterToText
		{
			[Cpp2IlInjected.Token(Token = "0x6000FC8")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000FC9")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCA")]
		[Cpp2IlInjected.Address(RVA = "0x111D6A0", Offset = "0x111C0A0", VA = "0x18111D6A0", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			UnicodeCategory unicodeCategory = default(UnicodeCategory);
			if (unicodeCategory != UnicodeCategory.Surrogate)
			{
				string input = default(string);
				string text2 = _spaces.Replace(input, " ");
				string text3 = default(string);
				int stringLength = text3.m_stringLength;
				if (DoNotAddCharacterToText)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCB")]
		[Cpp2IlInjected.Address(RVA = "0x111D890", Offset = "0x111C290", VA = "0x18111D890")]
		public CustomValidator()
		{
		}
	}
}
