using System.Reflection;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008B0")]
	internal class TweenPropertyInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003417")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003418")]
		public PropertyInfo pi;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003419")]
		public object originalValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400341A")]
		public object factor;

		[Cpp2IlInjected.Token(Token = "0x60036FC")]
		[Cpp2IlInjected.Address(RVA = "0x79F820", Offset = "0x79E220", VA = "0x18079F820")]
		public TweenPropertyInfo(string name, PropertyInfo pi, object v1, object v2)
		{
			//IL_0022: Expected O, but got I4
			this.name = name;
			this.pi = pi;
			originalValue = v1;
			factor = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
