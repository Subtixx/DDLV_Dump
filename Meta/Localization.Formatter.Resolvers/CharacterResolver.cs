using System;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Meta;

namespace Localization.Formatter.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CharacterResolver : ScopeResolver
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400001B")]
		private Character Character
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71A4B0", Offset = "0x718EB0", VA = "0x18071A4B0")]
		public CharacterResolver(Character character)
			: base("character")
		{
			Character = character;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71A400", Offset = "0x718E00", VA = "0x18071A400", Slot = "5")]
		public override object Resolve(string key)
		{
			if (key != null && string.Equals(key, "Name"))
			{
				string name_ = Character.Data.name_;
			}
			throw new NullReferenceException();
		}
	}
}
