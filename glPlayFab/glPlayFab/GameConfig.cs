using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class GameConfig : BaseConfig
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public override Type ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x102EE10", Offset = "0x102D810", VA = "0x18102EE10", Slot = "6")]
			get
			{
				return typeof(GameConfig);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public override ConfigType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "7")]
			get
			{
				return ConfigType.gameconfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GameConfig()
		{
		}
	}
}
