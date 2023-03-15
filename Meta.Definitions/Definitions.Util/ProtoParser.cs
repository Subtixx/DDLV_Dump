using System;
using System.Text;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	public static class ProtoParser
	{
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public static readonly JsonParser JsonParser;

		[Cpp2IlInjected.Token(Token = "0x6000DDB")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FDE0", Offset = "0x2D9E7E0", VA = "0x182D9FDE0")]
		public static bool IsBinaryData(byte[] byteArray)
		{
			//Discarded unreachable code: IL_001a
			if (byteArray.Length == 0)
			{
				return true;
			}
			return (long)"{il2cpp array field byteArray->}" != 123;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDC")]
		[Cpp2IlInjected.Address(RVA = "0x1B14A80", Offset = "0x1B13480", VA = "0x181B14A80")]
		public static T Parse<T>(byte[] P_0) where T : IMessage, new()
		{
			if (!IsBinaryData(P_0))
			{
				int num = 0;
				Encoding uTF = Encoding.UTF8;
				int index = 0;
				int length = P_0.Length;
				string @string = uTF.GetString(P_0, index, length);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDD")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FF50", Offset = "0x2D9E950", VA = "0x182D9FF50")]
		public static IMessage Parse(byte[] byteArray, MessageDescriptor messageDescriptor)
		{
			//Discarded unreachable code: IL_004c
			MessageParser _003CParser_003Ek__BackingField = messageDescriptor.Parser;
			if (byteArray.Length != 0 && (long)"{il2cpp array field byteArray->}" == 123)
			{
				IMessage result = _003CParser_003Ek__BackingField.CreateTemplate();
				int num = 0;
				Encoding uTF = Encoding.UTF8;
				int index = 0;
				int length = byteArray.Length;
				string @string = uTF.GetString(byteArray, index, length);
				return result;
			}
			return _003CParser_003Ek__BackingField.ParseFrom(byteArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDE")]
		[Cpp2IlInjected.Address(RVA = "0x2DA00F0", Offset = "0x2D9EAF0", VA = "0x182DA00F0")]
		public static IMessage Parse(byte[] byteArray, MessageParser messageParser)
		{
			//Discarded unreachable code: IL_0043
			if (byteArray.Length != 0 && (long)"{il2cpp array field byteArray->}" == 123)
			{
				IMessage result = messageParser.CreateTemplate();
				int num = 0;
				Encoding uTF = Encoding.UTF8;
				int index = 0;
				int length = byteArray.Length;
				string @string = uTF.GetString(byteArray, index, length);
				return result;
			}
			return messageParser.ParseFrom(byteArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDF")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FE20", Offset = "0x2D9E820", VA = "0x182D9FE20")]
		public static void Parse(byte[] byteArray, IMessage message)
		{
			//Discarded unreachable code: IL_0032
			if (byteArray.Length != 0 && (long)"{il2cpp array field byteArray->}" == 123)
			{
				int num = 0;
				Encoding uTF = Encoding.UTF8;
				int index = 0;
				int length = byteArray.Length;
				string @string = uTF.GetString(byteArray, index, length);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0240", Offset = "0x2D9EC40", VA = "0x182DA0240")]
		static ProtoParser()
		{
			JsonParser jsonParser = new JsonParser(new JsonParser.Settings(100).WithIgnoreUnknownFields(ignoreUnknownFields: true));
			throw new NullReferenceException();
		}
	}
}
