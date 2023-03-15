using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public class ConfigurationParam : TitleParam
	{
		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public override MatcherType MatcherType
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x8C8560", Offset = "0x8C6F60", VA = "0x1808C8560", Slot = "4")]
			get
			{
				return MatcherType.Config;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ConfigurationParam()
		{
			((EventArgs)(object)this)._002Ector();
		}
	}
}
