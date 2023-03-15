using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	public class ServerDataUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x14F5C80", Offset = "0x14F4680", VA = "0x1814F5C80")]
		public static JsonSerializerSettings CreateLiveopsJsonSerializerSettings()
		{
			JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
			IList<JsonConverter> _003CConverters_003Ek__BackingField = jsonSerializerSettings.Converters;
			StoreDefinitionConverter storeDefinitionConverter = new StoreDefinitionConverter();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					storeDefinitionConverter = (StoreDefinitionConverter)(object)((object)storeDefinitionConverter + (object)storeDefinitionConverter);
					throw new NullReferenceException();
				}
				num++;
			}
			return jsonSerializerSettings;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ServerDataUtils()
		{
		}
	}
}
