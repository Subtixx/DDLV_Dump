using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct LocId : IEquatable<LocId>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public readonly string TableName
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x8"), Cpp2IlInjected.Token(Token = "0x4000032")]
		public string StringName
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string FullName
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x408F570", Offset = "0x408DF70", VA = "0x18408F570")]
			get
			{
				do
				{
					if ("." != null)
					{
					}
				}
				while (string.IsNullOrEmpty(StringName));
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x408F5E0", Offset = "0x408DFE0", VA = "0x18408F5E0")]
			get
			{
				int num = 0;
				return !string.IsNullOrEmpty(StringName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB1C0", VA = "0x1807BC7C0")]
		private LocId(string tableName, string stringName)
		{
			TableName = tableName;
			StringName = stringName;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x408F2C0", Offset = "0x408DCC0", VA = "0x18408F2C0")]
		public static LocId From(string locId)
		{
			(new char[1])[0] = '.';
			string[] array = default(string[]);
			string text = array[0];
			IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Skip<string>((IEnumerable<>)(object)array, 1);
			string text2 = string.Join(".", (IEnumerable<>)enumerable);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x408F220", Offset = "0x408DC20", VA = "0x18408F220", Slot = "0")]
		public override bool Equals(object obj)
		{
			bool result = default(bool);
			if (obj != null && obj != null)
			{
				return result;
			}
			int num = 0;
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x408F480", Offset = "0x408DE80", VA = "0x18408F480", Slot = "4")]
		bool IEquatable<LocId>.Equals(LocId other)
		{
			if ("." != null)
			{
			}
			string text = StringName;
			if ("." == null)
			{
			}
			if ("." == null)
			{
				string text2 = other.StringName;
				if ("." != null)
				{
				}
			}
			string a = default(string);
			string b = default(string);
			return string.Equals(a, b);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x408F3F0", Offset = "0x408DDF0", VA = "0x18408F3F0", Slot = "2")]
		public override int GetHashCode()
		{
			if ("." != null)
			{
			}
			if (!string.IsNullOrEmpty(StringName))
			{
			}
			string text = default(string);
			object obj = ((ICloneable)text).Clone();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7BC780", Offset = "0x7BB180", VA = "0x1807BC780")]
		public static LocId From(string tableName, string stringName)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
