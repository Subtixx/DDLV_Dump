using System;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class DebugLogEntry : IEquatable<DebugLogEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private const int HASH_NOT_CALCULATED = -623218;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public string logString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public string stackTrace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private string completeLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Sprite logTypeSpriteRepresentation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private int hashValue;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x112F770", Offset = "0x112E170", VA = "0x18112F770")]
		public void Initialize(string logString, string stackTrace, Sprite sprite)
		{
			//IL_001e: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			this.logString = logString;
			this.stackTrace = stackTrace;
			logTypeSpriteRepresentation = sprite;
			count = 1;
			hashValue = -623218;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x112F640", Offset = "0x112E040", VA = "0x18112F640", Slot = "4")]
		public bool Equals(DebugLogEntry other)
		{
			//Discarded unreachable code: IL_002e
			string b = other.logString;
			bool flag = string.Equals(logString, b);
			if (!flag)
			{
				return flag;
			}
			string b2 = other.stackTrace;
			return string.Equals(stackTrace, b2);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x112F7E0", Offset = "0x112E1E0", VA = "0x18112F7E0", Slot = "3")]
		public override string ToString()
		{
			string text = completeLog;
			if (text == null)
			{
				string text2 = stackTrace;
				string text3 = (completeLog = logString + "\n" + text2);
			}
			return text;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x112F6A0", Offset = "0x112E0A0", VA = "0x18112F6A0", Slot = "2")]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0072
			//IL_0019: Expected I4, but got I8
			//IL_0047: Expected I8, but got I4
			int num = hashValue;
			if (num == -623218)
			{
				hashValue = 17;
				string text = logString;
				string text2 = default(string);
				if (text2 + text == null)
				{
				}
				long num2 = (hashValue = logString.GetHashCode()) * 23;
				string text3 = stackTrace;
				string text4 = default(string);
				int hashCode = default(int);
				if (text4 + text3 != null)
				{
					hashCode = stackTrace.GetHashCode();
				}
				hashValue = hashCode;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public DebugLogEntry()
		{
		}
	}
}
