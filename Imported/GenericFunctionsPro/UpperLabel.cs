using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace GenericFunctionsPro
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class UpperLabel : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public string name;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8B0", Offset = "0x8BB2B0", VA = "0x1808BC8B0")]
		public UpperLabel(string name)
		{
			((NativeDisableContainerSafetyRestrictionAttribute)(object)this)._002Ector();
			this.name = name;
			/*Error: Unexpected end of block*/;
		}
	}
}
