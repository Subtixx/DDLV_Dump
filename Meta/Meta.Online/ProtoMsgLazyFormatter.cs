using System;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F1D")]
	public class ProtoMsgLazyFormatter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003DB1")]
		private readonly IMessage msg;

		[Cpp2IlInjected.Token(Token = "0x4003DB2")]
		private static string[] largeMessages;

		[Cpp2IlInjected.Token(Token = "0x6007C6B")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public ProtoMsgLazyFormatter(IMessage msg)
		{
			this.msg = msg;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C6C")]
		[Cpp2IlInjected.Address(RVA = "0x148A550", Offset = "0x1488F50", VA = "0x18148A550")]
		private static bool IsLargeRequest(string name)
		{
			//Discarded unreachable code: IL_0022
			string[] array = largeMessages;
			Predicate<string> predicate = (Predicate<string>)(object)(Predicate<T>)((string x) => name.Contains(x));
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C6D")]
		[Cpp2IlInjected.Address(RVA = "0x148A670", Offset = "0x1489070", VA = "0x18148A670", Slot = "3")]
		public override string ToString()
		{
			//IL_004c: Expected I4, but got I8
			IMessage message = msg;
			string name = (string)typeof(App).TypeHandle;
			string[] array = largeMessages;
			Predicate<string> predicate = (Predicate<string>)(object)(Predicate<T>)((string x) => name.Contains(x));
			bool flag = default(bool);
			if (!flag)
			{
				IMessage message2 = msg;
				int formatEnumAsIntegers = 0;
				int indented = 0;
				ulong num = default(ulong);
				return message2.ToJSONString(formatDefaultValues: true, (byte)indented != 0, (byte)formatEnumAsIntegers != 0, (int)num);
			}
			IMessage message3 = msg;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007C6E")]
		[Cpp2IlInjected.Address(RVA = "0x148A4F0", Offset = "0x1488EF0", VA = "0x18148A4F0")]
		public static ProtoMsgLazyFormatter Create(IMessage msg)
		{
			ProtoMsgLazyFormatter protoMsgLazyFormatter = default(ProtoMsgLazyFormatter);
			protoMsgLazyFormatter.msg = msg;
			return protoMsgLazyFormatter;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C6F")]
		[Cpp2IlInjected.Address(RVA = "0x148A8E0", Offset = "0x14892E0", VA = "0x18148A8E0")]
		static ProtoMsgLazyFormatter()
		{
			string[] array;
			while (true)
			{
				array = new string[4];
				if ("InitWithServerProfile" != null && "InitWithServerProfile" == null)
				{
					continue;
				}
				array[0] = "InitWithServerProfile";
				if ("LoadProfile" != null && "LoadProfile" == null)
				{
					continue;
				}
				array[1] = "LoadProfile";
				if ("InitProfile" == null || "InitProfile" != null)
				{
					array[2] = "InitProfile";
					if ("Login" == null || "Login" != null)
					{
						break;
					}
				}
			}
			array[3] = "Login";
			largeMessages = array;
			throw new NullReferenceException();
		}
	}
}
