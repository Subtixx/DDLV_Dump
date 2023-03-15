using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Localization.Formatter
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class DictionaryResolver : IResolver
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000001")]
		private IReadOnlyDictionary<string, object> Dict
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public DictionaryResolver(IReadOnlyDictionary<string, object> dict)
		{
			Dict = dict;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x408B4A0", Offset = "0x4089EA0", VA = "0x18408B4A0", Slot = "4")]
		object IResolver.Resolve(string key)
		{
			IReadOnlyDictionary<string, object> readOnlyDictionary = Dict;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_0021;
				}
				num++;
			}
			if ((object)typeof(Resolver).TypeHandle != null)
			{
			}
			goto IL_0021;
			IL_0021:
			throw new NullReferenceException();
		}
	}
}
