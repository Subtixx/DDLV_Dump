using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace GenericFunctionsPro
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class LargeHeader : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string color = "white";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int Size;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2F16350", Offset = "0x2F14D50", VA = "0x182F16350")]
		public LargeHeader(string name, string _color = "cyan", int size = 17)
		{
			((NativeDisableUnsafePtrRestrictionAttribute)(object)this)._002Ector();
			this.name = name;
			color = _color;
			Size = size;
		}
	}
}
