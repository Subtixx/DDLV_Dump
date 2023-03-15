using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class FunctionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public string TitleId
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CTitleId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CTitleId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public string EntityToken
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CEntityToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CEntityToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public string FunctionName
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CFunctionName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CFunctionName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public string RequestString
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CRequestString_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CRequestString_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000265")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public string VersionStr
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CVersionStr_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CVersionStr_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x102EB50", Offset = "0x102D550", VA = "0x18102EB50", Slot = "3")]
		public override string ToString()
		{
			//Discarded unreachable code: IL_00ab
			//IL_0081: Expected O, but got I4
			object[] array;
			string text5;
			while (true)
			{
				array = new object[6];
				string text = TitleId;
				if (text != null && array == null)
				{
					continue;
				}
				array[0] = text;
				string text2 = EntityToken;
				if (text2 != null && array == null)
				{
					continue;
				}
				array[1] = text2;
				string text3 = FunctionName;
				if (text3 != null && array == null)
				{
					continue;
				}
				array[2] = text3;
				string text4 = RequestString;
				if (text4 != null && array == null)
				{
					continue;
				}
				array[3] = text4;
				int num = Version;
				if (num == 0 || num != 0)
				{
					array[4] = num;
					text5 = VersionStr;
					if (text5 == null || num != 0)
					{
						break;
					}
				}
			}
			array[5] = text5;
			return string.Format("TitleId({0}), EntityToken({1}), FunctionName({2}), RequestString({3}), Version({4}), VersionStr({5})", array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FunctionRequest()
		{
		}
	}
}
