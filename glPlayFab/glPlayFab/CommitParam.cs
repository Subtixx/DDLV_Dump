using System.Xml;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public class CommitParam : TitleParam
	{
		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public override MatcherType MatcherType
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xF12970", Offset = "0xF11370", VA = "0x180F12970", Slot = "4")]
			get
			{
				return MatcherType.Commit;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public CommitParam()
		{
			((XmlNamespaceManager)(object)this)._002Ector();
		}
	}
}
