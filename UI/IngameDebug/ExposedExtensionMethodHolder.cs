using System;
using System.Reflection;
using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public struct ExposedExtensionMethodHolder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public readonly Type extendedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public readonly MethodInfo method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public readonly RuntimeInspectorButtonAttribute properties;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1580", Offset = "0x9AFF80", VA = "0x1809B1580")]
		public ExposedExtensionMethodHolder(Type extendedType, MethodInfo method, RuntimeInspectorButtonAttribute properties)
		{
			this.extendedType = extendedType;
			this.method = method;
			this.properties = properties;
			/*Error: Unexpected end of block*/;
		}
	}
}
