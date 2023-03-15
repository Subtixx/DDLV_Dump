using System;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class CustomJsonCodec
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JsonSerializerSettings serializerSettings = new JsonSerializerSettings
		{
			ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
			ContractResolver = new DefaultContractResolver
			{
				NamingStrategy = new CamelCaseNamingStrategy
				{
					OverrideSpecifiedNames = true
				}
			},
			NullValueHandling = NullValueHandling.Ignore
		};

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x40332E0", Offset = "0x4031CE0", VA = "0x1840332E0")]
		public CustomJsonCodec()
		{
		}//Discarded unreachable code: IL_0043


		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4033270", Offset = "0x4031C70", VA = "0x184033270")]
		public string Serialize(object obj)
		{
			JsonSerializerSettings settings = serializerSettings;
			return JsonConvert.SerializeObject(obj, settings);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x16D2570", Offset = "0x16D0F70", VA = "0x1816D2570")]
		public T Deserialize<T>(byte[] bytes, Encoding encoding)
		{
			Type typeFromHandle = typeof(Type);
			int num = 0;
			object obj = Deserialize(bytes, encoding, typeFromHandle);
			if (obj == null || obj != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4032EF0", Offset = "0x40318F0", VA = "0x184032EF0")]
		internal object Deserialize(byte[] bytes, Encoding encoding, Type type)
		{
			//IL_009f: Expected O, but got I4
			Type typeFromHandle = typeof(byte[]);
			if (!((object)type).Equals((object)typeFromHandle))
			{
				Type typeFromHandle2 = typeof(Stream);
				if (!((object)type).Equals((object)typeFromHandle2))
				{
					string @string = encoding.GetString(bytes);
					if (!type.Name.StartsWith("System.Nullable`1[[System.DateTime"))
					{
						Type typeFromHandle3 = typeof(string);
						if (!((object)type).Equals((object)typeFromHandle3) && !type.Name.StartsWith("System.Nullable"))
						{
							JsonSerializerSettings settings = serializerSettings;
							object obj = JsonConvert.DeserializeObject(@string, type, settings);
						}
						object obj2 = Convert.ChangeType(@string, type);
					}
					int num = 0;
					DateTime dateTime = DateTime.Parse(@string, (IFormatProvider)num, DateTimeStyles.RoundtripKind);
				}
				MemoryStream memoryStream = new MemoryStream(bytes);
			}
			throw new NullReferenceException();
		}
	}
}
