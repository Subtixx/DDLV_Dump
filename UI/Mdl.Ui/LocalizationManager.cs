using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000853")]
	public static class LocalizationManager
	{
		[Cpp2IlInjected.Token(Token = "0x60034BC")]
		[Cpp2IlInjected.Address(RVA = "0x132F1D0", Offset = "0x132DBD0", VA = "0x18132F1D0")]
		public static string FromStringID(string stringID, Dictionary<string, object> values)
		{
			//IL_0011: Expected O, but got I4
			DictionaryResolver resolver = new DictionaryResolver((IReadOnlyDictionary<, >)values);
			int num = 0;
			return Mdl.LocalizationManager.FromStringID(stringID, resolver, (string)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60034BD")]
		[Cpp2IlInjected.Address(RVA = "0x132F270", Offset = "0x132DC70", VA = "0x18132F270")]
		public static string FromStringID(string stringID, [Optional] IResolver resolver)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			return Mdl.LocalizationManager.FromStringID(stringID, resolver, (string)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60034BE")]
		[Cpp2IlInjected.Address(RVA = "0x132F160", Offset = "0x132DB60", VA = "0x18132F160")]
		public static string FormatText(string text, IResolver resolver)
		{
			return Mdl.LocalizationManager.FormatText(text, resolver);
		}
	}
}
