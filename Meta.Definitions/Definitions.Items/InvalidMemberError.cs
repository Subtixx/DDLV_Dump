using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000635")]
	public class InvalidMemberError : DataValidationError
	{
		[Cpp2IlInjected.Token(Token = "0x170012F5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400220E")]
		public string MemberName
		{
			[Cpp2IlInjected.Token(Token = "0x60049A1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60049A2")]
		[Cpp2IlInjected.Address(RVA = "0x27BF910", Offset = "0x27BE310", VA = "0x1827BF910")]
		public InvalidMemberError(string message, object owner, string memberName, DataValidation.Context context)
		{
			MemberName = memberName;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049A3")]
		[Cpp2IlInjected.Address(RVA = "0x27BF5D0", Offset = "0x27BDFD0", VA = "0x1827BF5D0", Slot = "3")]
		public override string ToString()
		{
			//Discarded unreachable code: IL_00d8
			string[] array;
			while (true)
			{
				array = new string[7];
				if ("[" != null && "[" == null)
				{
					continue;
				}
				array[0] = "[";
				string text = MemberName;
				if (text != null && "[" == null)
				{
					continue;
				}
				array[1] = text;
				if ("] " != null && "] " == null)
				{
					continue;
				}
				array[2] = "] ";
				string text2 = base.Message;
				if (text2 != null && "] " == null)
				{
					continue;
				}
				array[3] = text2;
				if ("\nContext: " != null && "\nContext: " == null)
				{
					continue;
				}
				array[4] = "\nContext: ";
				string text3 = base.FullStackName;
				if (text3 == null || "\nContext: " != null)
				{
					array[5] = text3;
					if ("\n\n" == null || "\n\n" != null)
					{
						break;
					}
				}
			}
			array[6] = "\n\n";
			return string.Concat(array);
		}
	}
}
