using System;
using Cpp2IlInjected;
using Google.Protobuf;
using Newtonsoft.Json;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F45")]
	public class ProtobufConverter<T> : JsonConverter where T : IMessage, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6007D28")]
		[Cpp2IlInjected.Address(RVA = "0x37EB260", Offset = "0x37E9C60", VA = "0x1837EB260", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			Type obj = default(Type);
			return ((object)objectType).Equals((object)obj);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D29")]
		[Cpp2IlInjected.Address(RVA = "0x37EB390", Offset = "0x37E9D90", VA = "0x1837EB390", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			//Discarded unreachable code: IL_000d
			if (value == null)
			{
			}
			string value2 = default(string);
			serializer.Serialize(writer, value2);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D2A")]
		[Cpp2IlInjected.Address(RVA = "0x37EB2E0", Offset = "0x37E9CE0", VA = "0x1837EB2E0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007D2B")]
		[Cpp2IlInjected.Address(RVA = "0x188E140", Offset = "0x188CB40", VA = "0x18188E140")]
		public ProtobufConverter()
		{
		}//Discarded unreachable code: IL_0007

	}
}
