using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Mdl.Utils;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A4D")]
	public static class BlendShapeDefinitions
	{
		[Cpp2IlInjected.Token(Token = "0x4003914")]
		private static List<string> _blendShapes;

		[Cpp2IlInjected.Token(Token = "0x170006B3")]
		public static IReadOnlyList<string> BlendShapes
		{
			[Cpp2IlInjected.Token(Token = "0x600300E")]
			[Cpp2IlInjected.Address(RVA = "0x163FB00", Offset = "0x163E500", VA = "0x18163FB00")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B4")]
		public static string BlendShapeFile
		{
			[Cpp2IlInjected.Token(Token = "0x600300F")]
			[Cpp2IlInjected.Address(RVA = "0x163FAD0", Offset = "0x163E4D0", VA = "0x18163FAD0")]
			get
			{
				return "blend_shapes.json";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003010")]
		[Cpp2IlInjected.Address(RVA = "0x163F780", Offset = "0x163E180", VA = "0x18163F780")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitializeBlendShapes()
		{
			//Discarded unreachable code: IL_0043, IL_0049
			int num = 0;
			int num2 = 0;
			UnityFileSystem.InitFileSystem();
			IEnumerator<JToken> enumerator = (IEnumerator<JToken>)JArray.Parse(FileSystem.Data.ReadAllText("blend_shapes.json")).GetEnumerator();
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num != (int)num3)
					{
						num++;
					}
				}
				string text = text + text;
			}
			if (enumerator == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003011")]
		[Cpp2IlInjected.Address(RVA = "0x163F650", Offset = "0x163E050", VA = "0x18163F650")]
		public static int FindBlendShapeIndex(string blendShape)
		{
			//Discarded unreachable code: IL_001c
			Predicate<string> predicate = (Predicate<string>)(object)(Predicate<T>)delegate(string b)
			{
				string b2 = blendShape;
				return string.Equals(b, b2);
			};
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003012")]
		[Cpp2IlInjected.Address(RVA = "0x163FA50", Offset = "0x163E450", VA = "0x18163FA50")]
		static BlendShapeDefinitions()
		{
			List<string> list = (List<string>)(object)new List<T>();
			/*Error: Unexpected end of block*/;
		}
	}
}
