using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public class UserIdParam : TitleParam
	{
		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public override MatcherType MatcherType
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x7D4F00", Offset = "0x7D3900", VA = "0x1807D4F00", Slot = "4")]
			get
			{
				return MatcherType.UserId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UserIdParam()
		{
		}
	}
}
