using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200076F")]
	public class GUIDNameAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x1700049E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002AD8")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002100")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002101")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8B0", Offset = "0x8BB2B0", VA = "0x1808BC8B0")]
		public GUIDNameAttribute(string name)
		{
			Name = name;
			/*Error: Unexpected end of block*/;
		}
	}
}
