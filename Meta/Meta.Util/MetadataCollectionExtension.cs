using System;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AB5")]
	public static class MetadataCollectionExtension
	{
		[Cpp2IlInjected.Token(Token = "0x6005D01")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E70", Offset = "0x7F3870", VA = "0x1807F4E70")]
		public static bool TryGetBool(this MetadataCollection mc, string key, out bool val)
		{
			//Discarded unreachable code: IL_001f
			bool flag = mc.ContainsKey(key);
			if (flag)
			{
				bool boolean = mc.GetBoolean(key);
			}
			int num = ((val.m_value = false) ? 1 : 0);
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D02")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E00", Offset = "0x7F3800", VA = "0x1807F4E00")]
		public static bool IsTrue(this MetadataCollection mc, string key)
		{
			if (mc.ContainsKey(key))
			{
				return mc.GetBoolean(key);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D03")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F50", Offset = "0x7F3950", VA = "0x1807F4F50")]
		public static bool TryGetInt(this MetadataCollection mc, string key, out int val)
		{
			//Discarded unreachable code: IL_001f
			bool flag = mc.ContainsKey(key);
			if (flag)
			{
				int @int = mc.GetInt(key);
			}
			int num = (val.m_value = 0);
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D04")]
		[Cpp2IlInjected.Address(RVA = "0x7F4FC0", Offset = "0x7F39C0", VA = "0x1807F4FC0")]
		public static bool TryGetString(this MetadataCollection mc, string key, out string val)
		{
			//Discarded unreachable code: IL_0018
			bool flag = mc.ContainsKey(key);
			if (flag)
			{
				string @string = mc.GetString(key);
			}
			int num = 0;
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D05")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EE0", Offset = "0x7F38E0", VA = "0x1807F4EE0")]
		public static bool TryGetDateTime(this MetadataCollection mc, string key, out DateTime val)
		{
			//Discarded unreachable code: IL_001f
			//IL_001d: Expected I8, but got I4
			bool flag = mc.ContainsKey(key);
			if (flag)
			{
				DateTime dateTime = mc.GetDateTime(key);
			}
			int num = 0;
			val.dateData = (ulong)num;
			return flag;
		}
	}
}
