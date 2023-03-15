using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200076E")]
	public class ProtoAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AD7")]
		public readonly string TypeFilter;

		[Cpp2IlInjected.Token(Token = "0x60020FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8B0", Offset = "0x8BB2B0", VA = "0x1808BC8B0")]
		public ProtoAttribute(string typeFilter)
		{
			TypeFilter = typeFilter;
			/*Error: Unexpected end of block*/;
		}
	}
}
