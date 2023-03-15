using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Mdl.Utils;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class RegionListUtils : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private static List<string> _ruleList = (List<string>)(object)new List<T>
	{
		(T)"COPPA",
		(T)"OFT_AU_NZ",
		(T)"GDPR",
		(T)"China"
	};

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private static JToken _compliancy;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private static JObject _agegateStorage;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public static string CompliancyFile
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xCBCE40", Offset = "0xCBB840", VA = "0x180CBCE40")]
		get
		{
			return "compliancy.json";
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static string agegate_storageFile
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xCBCE70", Offset = "0xCBB870", VA = "0x180CBCE70")]
		get
		{
			return "agegate_storage.json";
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xCBC6D0", Offset = "0xCBB0D0", VA = "0x180CBC6D0")]
	public static void InitializeRegionListUtils()
	{
		//Discarded unreachable code: IL_006d
		//IL_0042: Expected O, but got I4
		int num = 0;
		UnityFileSystem.InitFileSystem();
		_ruleList = (List<string>)(object)JToken.Parse(FileSystem.Data.ReadAllText("compliancy.json"));
		IFileSystem _003CSaveGlobal_003Ek__BackingField = FileSystem.SaveGlobal;
		int num2 = 0;
		uint num3 = default(uint);
		if (num2 < (int)num3)
		{
			num2 += num2;
			num2++;
		}
		if ("agegate_storage.json" != null)
		{
			_ruleList = (List<string>)num2;
			string text = FileSystem.SaveGlobal.ReadAllText("agegate_storage.json");
			if (!string.IsNullOrEmpty(text))
			{
				_ruleList = (List<string>)(object)JObject.Parse(text);
				int num4 = 0;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0xCBCC70", Offset = "0xCBB670", VA = "0x180CBCC70")]
	public static void Set(string key, JToken value)
	{
		//Discarded unreachable code: IL_000d
		_agegateStorage[key] = value;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B190", Offset = "0x1B19B90", VA = "0x181B1B190")]
	public static T Get<T>(string P_0, [System.Runtime.InteropServices.Optional] T defaultValue)
	{
		//Discarded unreachable code: IL_0024
		JObject agegateStorage = _agegateStorage;
		if (agegateStorage != null)
		{
			JProperty jProperty = agegateStorage.Property(P_0);
			if (jProperty != null)
			{
				JToken jToken = jProperty.Value.CloneToken();
			}
		}
		return defaultValue;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xCBCA90", Offset = "0xCBB490", VA = "0x180CBCA90")]
	public static bool Save()
	{
		//Discarded unreachable code: IL_002b
		int num = 0;
		IFileSystem _003CSaveGlobal_003Ek__BackingField = FileSystem.SaveGlobal;
		string text = _agegateStorage.ToString();
		_003CSaveGlobal_003Ek__BackingField.WriteAllText("agegate_storage.json", text);
		Debug.LogError(text);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xCBC160", Offset = "0xCBAB60", VA = "0x180CBC160")]
	public static int GetUserAge(string countryRegion, string GameTypes)
	{
		//Discarded unreachable code: IL_00d8, IL_00de, IL_00e4
		//IL_0060: Expected O, but got I4
		bool flag = default(bool);
		JToken jToken = default(JToken);
		bool flag2 = default(bool);
		JToken jToken2 = default(JToken);
		string key = default(string);
		int num2 = default(int);
		while (true)
		{
			int num = 0;
			List<string> ruleList = _ruleList;
			if (flag)
			{
				JToken compliancy = _compliancy;
				if (jToken != null)
				{
					string b = (string?)jToken;
					flag2 = string.Equals(countryRegion, b);
					while (!flag2)
					{
					}
				}
				if (jToken != null)
				{
				}
				while (flag2)
				{
				}
			}
			if (flag)
			{
				break;
			}
			JToken compliancy2 = _compliancy;
			int num3 = jToken2[key]!["forbid_ios_tracking_consent"]![num2]!["max_age"]!.ToObject<int>();
			JObject agegateStorage = _agegateStorage;
			if (agegateStorage != null)
			{
				JProperty jProperty = agegateStorage.Property("UserAge");
				if (jProperty != null && jProperty.Value.ToObject<int>() >= num3)
				{
					continue;
				}
			}
			return 0;
		}
		JObject agegateStorage2 = _agegateStorage;
		while (agegateStorage2 == null)
		{
		}
		JProperty jProperty2 = agegateStorage2.Property("UserAge");
		while (jProperty2 == null)
		{
		}
		int num4 = jProperty2.Value.ToObject<int>();
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public RegionListUtils()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xCBCD20", Offset = "0xCBB720", VA = "0x180CBCD20")]
	static RegionListUtils()
	{
		throw new NullReferenceException();
	}
}
