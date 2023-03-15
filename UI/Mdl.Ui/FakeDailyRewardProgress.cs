using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006CC")]
	public class FakeDailyRewardProgress
	{
		[Cpp2IlInjected.Token(Token = "0x17000661")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002BB5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BB6")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000662")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002667")]
		public DateTime ExpireDate
		{
			[Cpp2IlInjected.Token(Token = "0x6002BB7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002BB8")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			set;
		} = DateTime.MinValue;


		[Cpp2IlInjected.Token(Token = "0x17000663")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002668")]
		public DateTime LastCollectionDate
		{
			[Cpp2IlInjected.Token(Token = "0x6002BB9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002BBA")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			set;
		} = DateTime.MinValue;


		[Cpp2IlInjected.Token(Token = "0x6002BBB")]
		[Cpp2IlInjected.Address(RVA = "0x1526490", Offset = "0x1524E90", VA = "0x181526490")]
		public FakeDailyRewardProgress()
		{
		}
	}
}
