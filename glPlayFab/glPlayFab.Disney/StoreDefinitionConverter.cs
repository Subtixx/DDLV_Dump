using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	public class StoreDefinitionConverter : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "8")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F58D0", VA = "0x1814F6ED0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			Type typeFromHandle = typeof(StoreDefinition);
			return ((object)objectType).Equals((object)typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x14F6F50", Offset = "0x14F5950", VA = "0x1814F6F50", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jObject = JObject.Load(reader);
			if (Extensions.Value<int>((IEnumerable<>)jObject["Type"]) != 0 && Extensions.Value<int>((IEnumerable<>)jObject["Type"]) != 1 && Extensions.Value<int>((IEnumerable<>)jObject["Type"]) != 2 && Extensions.Value<int>((IEnumerable<>)jObject["Type"]) != 3)
			{
				int num = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x14F70D0", Offset = "0x14F5AD0", VA = "0x1814F70D0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public StoreDefinitionConverter()
		{
		}
	}
}
