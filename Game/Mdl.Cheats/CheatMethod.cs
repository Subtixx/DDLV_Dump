using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200083A")]
	[AttributeUsage(AttributeTargets.Method)]
	public class CheatMethod : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000540")]
		public string DeclarationOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6002516")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDeclarationOrder_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002517")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CDeclarationOrder_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002515")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA90", Offset = "0xA7C490", VA = "0x180A7DA90")]
		public CheatMethod([CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
			//Discarded unreachable code: IL_0026
			string text = file.ToLower();
			int num = 0;
			string text2 = default(string);
			string text3 = (DeclarationOrder = text + "|" + text2);
		}
	}
}
