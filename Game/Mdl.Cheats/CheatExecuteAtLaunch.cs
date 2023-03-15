using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200083B")]
	[AttributeUsage(AttributeTargets.Method)]
	public class CheatExecuteAtLaunch : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000541")]
		public string DeclarationOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6002519")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDeclarationOrder_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600251A")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CDeclarationOrder_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002518")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4B0", Offset = "0xA7AEB0", VA = "0x180A7C4B0")]
		public CheatExecuteAtLaunch([CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
			//Discarded unreachable code: IL_0026
			string text = file.ToLower();
			int num = 0;
			string text2 = default(string);
			string text3 = (DeclarationOrder = text + "|" + text2);
		}
	}
}
