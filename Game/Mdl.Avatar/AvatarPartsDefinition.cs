using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Mdl.Utils;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A4C")]
	public static class AvatarPartsDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x4003911")]
		private static List<string> _names = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4003912")]
		private static List<string> _bodyParts;

		[Cpp2IlInjected.Token(Token = "0x4003913")]
		private static List<string> _sections;

		[Cpp2IlInjected.Token(Token = "0x170006AF")]
		public static IReadOnlyList<string> Names
		{
			[Cpp2IlInjected.Token(Token = "0x6003007")]
			[Cpp2IlInjected.Address(RVA = "0x151EF50", Offset = "0x151D950", VA = "0x18151EF50")]
			get
			{
				List<string> names = _names;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B0")]
		public static IReadOnlyList<string> BodyParts
		{
			[Cpp2IlInjected.Token(Token = "0x6003008")]
			[Cpp2IlInjected.Address(RVA = "0x151EEF0", Offset = "0x151D8F0", VA = "0x18151EEF0")]
			get
			{
				List<string> bodyParts = _bodyParts;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B1")]
		public static IReadOnlyList<string> Sections
		{
			[Cpp2IlInjected.Token(Token = "0x6003009")]
			[Cpp2IlInjected.Address(RVA = "0x151EFB0", Offset = "0x151D9B0", VA = "0x18151EFB0")]
			get
			{
				List<string> sections = _sections;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B2")]
		public static string AvatarPartsFile
		{
			[Cpp2IlInjected.Token(Token = "0x600300A")]
			[Cpp2IlInjected.Address(RVA = "0x151EEC0", Offset = "0x151D8C0", VA = "0x18151EEC0")]
			get
			{
				return "avatar_parts.json";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600300B")]
		[Cpp2IlInjected.Address(RVA = "0x151E7E0", Offset = "0x151D1E0", VA = "0x18151E7E0")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitializeAvatarParts()
		{
			//Discarded unreachable code: IL_00bd, IL_00c3, IL_00c9, IL_00cf, IL_00d5, IL_00db
			int num = 0;
			int num2 = 0;
			UnityFileSystem.InitFileSystem();
			JToken jToken = JToken.Parse(FileSystem.Data.ReadAllText("avatar_parts.json"));
			JToken jToken2 = jToken["name"];
			((List<T>)(object)_names).Clear();
			if (jToken2 != null)
			{
				string item = (string?)jToken2;
				((List<T>)(object)_names).Add((T)item);
			}
			if (jToken2 != null)
			{
			}
			JToken jToken3 = jToken["body_part"];
			((List<T>)(object)_bodyParts).Clear();
			if (jToken3 != null)
			{
				string item2 = (string?)jToken3;
				((List<T>)(object)_bodyParts).Add((T)item2);
			}
			if (jToken3 != null)
			{
			}
			JToken jToken4 = jToken["section"];
			((List<T>)(object)_sections).Clear();
			if (jToken4 != null)
			{
				string item3 = (string?)jToken4;
				((List<T>)(object)_sections).Add((T)item3);
			}
			if (jToken4 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600300C")]
		[Cpp2IlInjected.Address(RVA = "0x151E3F0", Offset = "0x151CDF0", VA = "0x18151E3F0")]
		public static string GetFullName(int name, int bodyPart, int section)
		{
			string[] array;
			while (true)
			{
				List<string> names = _names;
				List<string> bodyParts = _bodyParts;
				List<string> sections = _sections;
				array = new string[5];
				List<string> names2 = _names;
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = (string)(object)array;
				if ("__" != null && "__" == null)
				{
					continue;
				}
				array[1] = "__";
				List<string> bodyParts2 = _bodyParts;
				if ((object)typeof(AvatarPartsDefinition).TypeHandle != null && (object)typeof(AvatarPartsDefinition).TypeHandle == null)
				{
					continue;
				}
				array[2] = (string)typeof(AvatarPartsDefinition).TypeHandle;
				if ("__" == null || "__" != null)
				{
					array[3] = "__";
					List<string> sections2 = _sections;
					if ((object)typeof(AvatarPartsDefinition).TypeHandle == null || (object)typeof(AvatarPartsDefinition).TypeHandle != null)
					{
						break;
					}
				}
			}
			array[4] = (string)typeof(AvatarPartsDefinition).TypeHandle;
			string text = string.Concat(array);
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600300D")]
		[Cpp2IlInjected.Address(RVA = "0x151EDD0", Offset = "0x151D7D0", VA = "0x18151EDD0")]
		static AvatarPartsDefinition()
		{
			_names = (List<string>)(object)new List<T>();
			_names = (List<string>)(object)new List<T>();
			/*Error: Unexpected end of block*/;
		}
	}
}
