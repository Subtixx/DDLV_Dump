using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F23")]
	public static class ProtoFieldDescriptorExt
	{
		[Cpp2IlInjected.Token(Token = "0x6007C81")]
		[Cpp2IlInjected.Address(RVA = "0x148A4C0", Offset = "0x1488EC0", VA = "0x18148A4C0")]
		public static bool IsIntegerLike(this FieldDescriptor self)
		{
			//Discarded unreachable code: IL_000e
			if (self.fieldType != FieldType.Enum)
			{
				int num = 0;
			}
			return true;
		}
	}
}
