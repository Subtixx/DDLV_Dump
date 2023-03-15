using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002C4")]
	public class TokenStorage
	{
		[Cpp2IlInjected.Token(Token = "0x4001565")]
		private static readonly string TOKEN_STORAGE_FILE = "token.json";

		[Cpp2IlInjected.Token(Token = "0x4001566")]
		private static JObject _json;

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		private static IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x738C50", Offset = "0x737650", VA = "0x180738C50")]
			get
			{
				return Definitions.Util.FileSystem.SaveGlobal;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x13D4E10", Offset = "0x13D3810", VA = "0x1813D4E10")]
		public static void Set(string key, object value)
		{
			//Discarded unreachable code: IL_0014
			JToken value2 = JToken.FromObject(value);
			_json[key] = value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x13D4D60", Offset = "0x13D3760", VA = "0x1813D4D60")]
		public static void Set(string key, JToken value)
		{
			//Discarded unreachable code: IL_000d
			_json[key] = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x175ADA0", Offset = "0x17597A0", VA = "0x18175ADA0")]
		public static T Get<T>(string P_0, [Optional] T defaultValue)
		{
			//Discarded unreachable code: IL_0024
			JObject json = _json;
			if (json != null)
			{
				JProperty jProperty = json.Property(P_0);
				if (jProperty != null)
				{
					JToken jToken = jProperty.Value.CloneToken();
				}
			}
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x13D4870", Offset = "0x13D3270", VA = "0x1813D4870")]
		public static bool Load()
		{
			int num = 0;
			IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			IFileSystem _003CSaveGlobal_003Ek__BackingField2 = Definitions.Util.FileSystem.SaveGlobal;
			string tOKEN_STORAGE_FILE = TOKEN_STORAGE_FILE;
			string text = _003CSaveGlobal_003Ek__BackingField2.ReadAllText(tOKEN_STORAGE_FILE);
			if (!string.IsNullOrEmpty(text))
			{
				TOKEN_STORAGE_FILE = (string)JObject.Parse(text);
				ulong num4 = default(ulong);
				if (num4 != 0)
				{
					goto IL_005a;
				}
			}
			JObject jObject = (JObject)(TOKEN_STORAGE_FILE = (string)new JObject());
			goto IL_005a;
			IL_005a:
			jObject = (JObject)((object)jObject + (object)jObject);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x13D4BA0", Offset = "0x13D35A0", VA = "0x1813D4BA0")]
		public static bool Save()
		{
			//Discarded unreachable code: IL_002d
			int num = 0;
			IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
			string tOKEN_STORAGE_FILE = TOKEN_STORAGE_FILE;
			string text = _json.ToString();
			_003CSaveGlobal_003Ek__BackingField.WriteAllText(tOKEN_STORAGE_FILE, text);
			Debug.LogError(text);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TokenStorage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x13D4F40", Offset = "0x13D3940", VA = "0x1813D4F40")]
		static TokenStorage()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
