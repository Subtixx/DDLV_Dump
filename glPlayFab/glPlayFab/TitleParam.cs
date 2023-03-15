using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public abstract class TitleParam
	{
		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		public abstract MatcherType MatcherType
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CValue_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x14F8420", Offset = "0x14F6E20", VA = "0x1814F8420", Slot = "5")]
		public virtual bool IsMatch(string pattern)
		{
			return Regex.IsMatch(Value, pattern);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected TitleParam()
		{
		}
	}
}
