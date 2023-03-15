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
	[Cpp2IlInjected.Token(Token = "0x20008B2")]
	public class UIAgeGateStorage
	{
		[Cpp2IlInjected.Token(Token = "0x4003421")]
		private static readonly string AGEGATE_LOCAL_STORAGE_FILE = "agegate_storage.json";

		[Cpp2IlInjected.Token(Token = "0x4003422")]
		private static JObject _json;

		[Cpp2IlInjected.Token(Token = "0x170007C1")]
		private static IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60036FE")]
			[Cpp2IlInjected.Address(RVA = "0x738C50", Offset = "0x737650", VA = "0x180738C50")]
			get
			{
				return Definitions.Util.FileSystem.SaveGlobal;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F21540", Offset = "0x3F1FF40", VA = "0x183F21540")]
		public static void Set(string key, object value)
		{
			//Discarded unreachable code: IL_0014
			JToken value2 = JToken.FromObject(value);
			_json[key] = value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003700")]
		[Cpp2IlInjected.Address(RVA = "0x3F21490", Offset = "0x3F1FE90", VA = "0x183F21490")]
		public static void Set(string key, JToken value)
		{
			//Discarded unreachable code: IL_000d
			_json[key] = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6003701")]
		[Cpp2IlInjected.Address(RVA = "0x35C2130", Offset = "0x35C0B30", VA = "0x1835C2130")]
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

		[Cpp2IlInjected.Token(Token = "0x6003702")]
		[Cpp2IlInjected.Address(RVA = "0x3F20D80", Offset = "0x3F1F780", VA = "0x183F20D80")]
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

		[Cpp2IlInjected.Token(Token = "0x6003703")]
		[Cpp2IlInjected.Address(RVA = "0x3F21220", Offset = "0x3F1FC20", VA = "0x183F21220")]
		public static bool Remove(string key)
		{
			//Discarded unreachable code: IL_000c
			return _json.Remove(key);
		}

		[Cpp2IlInjected.Token(Token = "0x6003704")]
		[Cpp2IlInjected.Address(RVA = "0x3F20EF0", Offset = "0x3F1F8F0", VA = "0x183F20EF0")]
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
			string aGEGATE_LOCAL_STORAGE_FILE = AGEGATE_LOCAL_STORAGE_FILE;
			string text = _003CSaveGlobal_003Ek__BackingField2.ReadAllText(aGEGATE_LOCAL_STORAGE_FILE);
			if (!string.IsNullOrEmpty(text))
			{
				AGEGATE_LOCAL_STORAGE_FILE = (string)JObject.Parse(text);
				ulong num4 = default(ulong);
				if (num4 != 0)
				{
					goto IL_005a;
				}
			}
			JObject jObject = (JObject)(AGEGATE_LOCAL_STORAGE_FILE = (string)new JObject());
			goto IL_005a;
			IL_005a:
			jObject = (JObject)((object)jObject + (object)jObject);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003705")]
		[Cpp2IlInjected.Address(RVA = "0x3F212D0", Offset = "0x3F1FCD0", VA = "0x183F212D0")]
		public static bool Save()
		{
			//Discarded unreachable code: IL_002d
			int num = 0;
			IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
			string aGEGATE_LOCAL_STORAGE_FILE = AGEGATE_LOCAL_STORAGE_FILE;
			string text = _json.ToString();
			_003CSaveGlobal_003Ek__BackingField.WriteAllText(aGEGATE_LOCAL_STORAGE_FILE, text);
			Debug.LogError(text);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003706")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UIAgeGateStorage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003707")]
		[Cpp2IlInjected.Address(RVA = "0x3F21670", Offset = "0x3F20070", VA = "0x183F21670")]
		static UIAgeGateStorage()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
