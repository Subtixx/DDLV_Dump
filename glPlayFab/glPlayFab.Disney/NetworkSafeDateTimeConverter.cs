using System;
using System.Globalization;
using System.Linq.Expressions.Interpreter;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	public class NetworkSafeDateTimeConverter : DateTimeConverterBase
	{
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private const string DefaultFormat = "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private readonly string[] Iso8601Format;

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x1034080", Offset = "0x1032A80", VA = "0x181034080", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			//Discarded unreachable code: IL_0008
			string value2 = default(string);
			writer.WriteValue(value2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x1033EB0", Offset = "0x10328B0", VA = "0x181033EB0", Slot = "5")]
		public unsafe override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			//Discarded unreachable code: IL_0044
			int num = 0;
			object value = reader.Value;
			if (value != null)
			{
				string s = reader.Value!.ToString();
				int num2 = 0;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				int styles = 0;
				if (!DateTime.TryParse(s, invariantCulture, (DateTimeStyles)styles, out *(DateTime*)num))
				{
					int num3 = 0;
					CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
					bool flag = default(bool);
					if (flag)
					{
					}
				}
			}
			return value;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x1034130", Offset = "0x1032B30", VA = "0x181034130")]
		public NetworkSafeDateTimeConverter()
		{
			//Discarded unreachable code: IL_00c3
			string[] array;
			while (true)
			{
				array = new string[6];
				if ("yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z" != null && "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z" == null)
				{
					continue;
				}
				array[0] = "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z";
				if ("yyyy-MM-dd\\THH:mm:ss\\Z" != null && "yyyy-MM-dd\\THH:mm:ss\\Z" == null)
				{
					continue;
				}
				array[1] = "yyyy-MM-dd\\THH:mm:ss\\Z";
				if ("yyyy-MM-dd\\THH:mm:ssK" != null && "yyyy-MM-dd\\THH:mm:ssK" == null)
				{
					continue;
				}
				array[2] = "yyyy-MM-dd\\THH:mm:ssK";
				if ("yyyy-MM-dd\\THH.mm.ss.FFFFFFF\\Z" != null && "yyyy-MM-dd\\THH.mm.ss.FFFFFFF\\Z" == null)
				{
					continue;
				}
				array[3] = "yyyy-MM-dd\\THH.mm.ss.FFFFFFF\\Z";
				if ("yyyy-MM-dd\\THH.mm.ss\\Z" == null || "yyyy-MM-dd\\THH.mm.ss\\Z" != null)
				{
					array[4] = "yyyy-MM-dd\\THH.mm.ss\\Z";
					if ("yyyy-MM-dd\\THH.mm.ssK" == null || "yyyy-MM-dd\\THH.mm.ssK" != null)
					{
						break;
					}
				}
			}
			array[5] = "yyyy-MM-dd\\THH.mm.ssK";
			Iso8601Format = array;
			((System.Linq.Expressions.Interpreter.LeftShiftInstruction.LeftShiftUInt64)(object)this)._002Ector();
		}
	}
}
