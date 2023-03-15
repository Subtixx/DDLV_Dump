using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008C0")]
	public class UILocalStorage
	{
		[Cpp2IlInjected.Token(Token = "0x4003461")]
		private static readonly string UI_LOCAL_STORAGE_FILE = "ui_local_storage.json";

		[Cpp2IlInjected.Token(Token = "0x4003462")]
		private static JObject _json;

		[Cpp2IlInjected.Token(Token = "0x170007C2")]
		private static IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x600372A")]
			[Cpp2IlInjected.Address(RVA = "0x738FA0", Offset = "0x7379A0", VA = "0x180738FA0")]
			get
			{
				return Definitions.Util.FileSystem.Save;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600372B")]
		[Cpp2IlInjected.Address(RVA = "0xC97460", Offset = "0xC95E60", VA = "0x180C97460")]
		public static void Set(string key, object value)
		{
			//Discarded unreachable code: IL_0014
			JToken value2 = JToken.FromObject(value);
			_json[key] = value2;
		}

		[Cpp2IlInjected.Token(Token = "0x600372C")]
		[Cpp2IlInjected.Address(RVA = "0xC97590", Offset = "0xC95F90", VA = "0x180C97590")]
		public static void Set(string key, JToken value)
		{
			//Discarded unreachable code: IL_000d
			_json[key] = value;
		}

		[Cpp2IlInjected.Token(Token = "0x600372D")]
		[Cpp2IlInjected.Address(RVA = "0x35C2DF0", Offset = "0x35C17F0", VA = "0x1835C2DF0")]
		public static T Get<T>(string cpp2il__autoParamName__idx_0, [Optional] T defaultValue)
		{
			//Discarded unreachable code: IL_0024
			JObject json = _json;
			if (json != null)
			{
				JProperty jProperty = json.Property(cpp2il__autoParamName__idx_0);
				if (jProperty != null)
				{
					JToken jToken = jProperty.Value.CloneToken();
				}
			}
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x600372E")]
		[Cpp2IlInjected.Address(RVA = "0xC96D50", Offset = "0xC95750", VA = "0x180C96D50")]
		public static bool HasKey(string key)
		{
			//Discarded unreachable code: IL_002d
			IEnumerable<JProperty> cpp2il__autoParamName__idx_ = (IEnumerable<JProperty>)_json.Properties();
			Func<JProperty, bool> cpp2il__autoParamName__idx_2 = (Func<JProperty, bool>)(object)(Func<T, TResult>)delegate(JProperty p)
			{
				//Discarded unreachable code: IL_0014
				string b = key;
				return string.Equals(p._name, b);
			};
			return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<JProperty>((Func<, >)(object)cpp2il__autoParamName__idx_2);
		}

		[Cpp2IlInjected.Token(Token = "0x600372F")]
		[Cpp2IlInjected.Address(RVA = "0xC971F0", Offset = "0xC95BF0", VA = "0x180C971F0")]
		public static bool Remove(string key)
		{
			//Discarded unreachable code: IL_000c
			return _json.Remove(key);
		}

		[Cpp2IlInjected.Token(Token = "0x6003730")]
		[Cpp2IlInjected.Address(RVA = "0xC96EC0", Offset = "0xC958C0", VA = "0x180C96EC0")]
		public static bool Load()
		{
			int num = 0;
			IFileSystem _003CSave_003Ek__BackingField = Definitions.Util.FileSystem.Save;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			IFileSystem _003CSave_003Ek__BackingField2 = Definitions.Util.FileSystem.Save;
			string uI_LOCAL_STORAGE_FILE = UI_LOCAL_STORAGE_FILE;
			string text = _003CSave_003Ek__BackingField2.ReadAllText(uI_LOCAL_STORAGE_FILE);
			if (!string.IsNullOrEmpty(text))
			{
				UI_LOCAL_STORAGE_FILE = (string)JObject.Parse(text);
				ulong num4 = default(ulong);
				if (num4 != 0)
				{
					goto IL_005a;
				}
			}
			JObject jObject = (JObject)(UI_LOCAL_STORAGE_FILE = (string)new JObject());
			goto IL_005a;
			IL_005a:
			jObject = (JObject)((object)jObject + (object)jObject);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003731")]
		[Cpp2IlInjected.Address(RVA = "0xC972A0", Offset = "0xC95CA0", VA = "0x180C972A0")]
		public static bool Save()
		{
			//Discarded unreachable code: IL_002d
			int num = 0;
			IFileSystem _003CSave_003Ek__BackingField = Definitions.Util.FileSystem.Save;
			string uI_LOCAL_STORAGE_FILE = UI_LOCAL_STORAGE_FILE;
			string text = _json.ToString();
			_003CSave_003Ek__BackingField.WriteAllText(uI_LOCAL_STORAGE_FILE, text);
			Debug.LogError(text);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003732")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UILocalStorage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003733")]
		[Cpp2IlInjected.Address(RVA = "0xC97640", Offset = "0xC96040", VA = "0x180C97640")]
		static UILocalStorage()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
