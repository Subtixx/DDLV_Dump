using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public static class ServerDataExt
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x14F5B30", Offset = "0x14F4530", VA = "0x1814F5B30")]
		public static bool SetVersion(this IOnlineLiveopsConfig self, IOnlineLiveopsConfig cmp, Type objType, JsonSerializerSettings jsonSerializerSettings)
		{
			if (self != null && cmp != null)
			{
				IOnlineLiveopsConfig onlineLiveopsConfig = CloneForCompare(self, objType, jsonSerializerSettings);
				IOnlineLiveopsConfig onlineLiveopsConfig2 = CloneForCompare(cmp, objType, jsonSerializerSettings);
				string text = default(string);
				string text2 = default(string);
				if (!(text != text2))
				{
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x14F5A50", Offset = "0x14F4450", VA = "0x1814F5A50")]
		private static IOnlineLiveopsConfig CloneForCompare(IOnlineLiveopsConfig value, Type objType, JsonSerializerSettings jsonSerializerSettings)
		{
			string value2 = default(string);
			if (JsonConvert.DeserializeObject(value2, objType, jsonSerializerSettings) != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}
	}
}
