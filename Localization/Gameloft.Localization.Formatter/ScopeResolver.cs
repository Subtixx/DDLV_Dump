using System;
using Cpp2IlInjected;

namespace Gameloft.Localization.Formatter
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class ScopeResolver : IResolver
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000006")]
		public string Scope
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		protected ScopeResolver(string scope)
		{
			Scope = scope;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract object Resolve(string key);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x40906F0", Offset = "0x408F0F0", VA = "0x1840906F0", Slot = "4")]
		object IResolver.Resolve(string key)
		{
			(new char[1])[0] = '.';
			string[] array = default(string[]);
			if (array.Length > 1)
			{
				string b = Scope;
				if (string.Equals(array[0], b))
				{
					string key2 = array[1];
					return Resolve(key2);
				}
			}
			throw new NullReferenceException();
		}
	}
}
