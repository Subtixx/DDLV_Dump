using Cpp2IlInjected;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002E9")]
	public class SwitchSystemUsernameProvider : ISystemUsernameProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public string SystemUsername
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD6")]
			[Cpp2IlInjected.Address(RVA = "0x106AAA0", Offset = "0x10694A0", VA = "0x18106AAA0", Slot = "4")]
			get
			{
				SwitchUserAccount instance;
				do
				{
					int num = 0;
					instance = SwitchUserAccount.Instance;
				}
				while ((object)instance == null);
				return instance._nickname;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SwitchSystemUsernameProvider()
		{
		}
	}
}
