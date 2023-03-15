using System;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct SemVer : IComparable<SemVer>, IEquatable<SemVer>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const int InvalidVer = -1;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly SemVer Invalid;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const int TotalWidthPerDigit = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly int major;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int minor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly int build;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4114470", Offset = "0x4112E70", VA = "0x184114470")]
			get
			{
				if (minor != -1)
				{
					return build != -1;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x27A6730", Offset = "0x27A5130", VA = "0x1827A6730")]
		public SemVer(int major = 0, int minor = 0, int build = 0)
		{
			this.major = major;
			this.minor = minor;
			this.build = build;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x41142D0", Offset = "0x4112CD0", VA = "0x1841142D0", Slot = "3")]
		public override string ToString()
		{
			int num = minor;
			int num2 = build;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x41140A0", Offset = "0x4112AA0", VA = "0x1841140A0")]
		public string ToStringTwoDigits()
		{
			int num = minor;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4114130", Offset = "0x4112B30", VA = "0x184114130")]
		public string ToStringWithPadding(bool leftPadding, char paddingChar, bool onlyTwoDigits = false)
		{
			//Discarded unreachable code: IL_0075
			string text = default(string);
			if (leftPadding)
			{
				string text2 = text.PadLeft(3, paddingChar);
				int num = minor;
				string text3 = default(string);
				string text4 = text3.PadLeft(3, paddingChar);
				if (onlyTwoDigits)
				{
					goto IL_0056;
				}
				int num2 = build;
				string text5 = default(string);
				string text6 = text5.PadLeft(3, paddingChar);
			}
			string text7 = text.PadRight(3, paddingChar);
			int num3 = minor;
			string text8 = default(string);
			string text9 = text8.PadRight(3, paddingChar);
			if (!onlyTwoDigits)
			{
			}
			goto IL_0056;
			IL_0056:
			int num4 = build;
			string text10 = default(string);
			string text11 = text10.PadRight(3, paddingChar);
			return text7 + text9 + text11;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4114060", Offset = "0x4112A60", VA = "0x184114060")]
		public unsafe int ToIntWithPadding(bool leftPadding, char paddingChar, bool onlyTwoDigits = false)
		{
			int num = 0;
			bool flag = int.TryParse(ToStringWithPadding(leftPadding, paddingChar, onlyTwoDigits), out *(int*)num);
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4114490", Offset = "0x4112E90", VA = "0x184114490")]
		public unsafe static implicit operator string(SemVer version)
		{
			return ((SemVer*)version)->ToString();
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4114380", Offset = "0x4112D80", VA = "0x184114380")]
		public static bool TryParse(string version, out SemVer result)
		{
			SemVer semVer = default(SemVer);
			int num = (result.build = semVer.build);
			if (result.minor != -1)
			{
				return num != -1;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4113E50", Offset = "0x4112850", VA = "0x184113E50")]
		public unsafe static SemVer Parse(string version)
		{
			int num = 0;
			(new char[0])[0] = 'v';
			char[] array = new char[1];
			array[0] = '.';
			string text = default(string);
			string[] array2 = text.Split(array);
			if (array2.Length == 3)
			{
				bool flag = int.TryParse(array2[0], out *(int*)num);
				bool flag2 = int.TryParse(array2[1], out *(int*)num);
				bool flag3 = int.TryParse(array2[2], out *(int*)num);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4113D40", Offset = "0x4112740", VA = "0x184113D40", Slot = "4")]
		public int CompareTo(SemVer other)
		{
			int num = default(int);
			if (num == 0)
			{
				int num2 = minor;
				int num3 = default(int);
				if (num3 == 0)
				{
					int num4 = build;
					int num5 = other.build;
				}
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4113DC0", Offset = "0x41127C0", VA = "0x184113DC0", Slot = "5")]
		public bool Equals(SemVer other)
		{
			int num = default(int);
			if (num == 0)
			{
				int num2 = minor;
				int num3 = default(int);
				if (num3 == 0)
				{
					int num4 = build;
					int num5 = other.build;
				}
			}
			int num6 = default(int);
			return num6 == 0;
		}
	}
}
