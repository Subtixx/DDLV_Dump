using System;
using System.Reflection;
using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class ConsoleMethodInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public readonly MethodInfo method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public readonly Type[] parameterTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public readonly object instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public readonly string signature;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x79F820", Offset = "0x79E220", VA = "0x18079F820")]
		public ConsoleMethodInfo(MethodInfo method, Type[] parameterTypes, object instance, string signature)
		{
			//IL_0022: Expected O, but got I4
			this.method = method;
			this.parameterTypes = parameterTypes;
			this.instance = instance;
			this.signature = (string)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x14A3400", Offset = "0x14A1E00", VA = "0x1814A3400")]
		public bool IsValid()
		{
			//Discarded unreachable code: IL_001b
			if (!method.IsStatic)
			{
				if (instance != null)
				{
				}
				int num = 0;
			}
			return true;
		}
	}
}
