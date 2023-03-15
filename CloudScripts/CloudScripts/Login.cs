using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class Login
	{
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000038")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000407")]
			public int TwoDigitsGameVersion
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public string DeviceName
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CDeviceName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CDeviceName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			SessionTokenUpdateFailed
		}

		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		public class Result : BaseClientResult
		{
			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400040C")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x392F6D0", Offset = "0x392E0D0", VA = "0x18392F6D0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x3930120", Offset = "0x392EB20", VA = "0x183930120")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Login()
		{
		}
	}
}
