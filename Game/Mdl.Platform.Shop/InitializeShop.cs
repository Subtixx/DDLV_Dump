using Cpp2IlInjected;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x200031A")]
	public class InitializeShop
	{
		[Cpp2IlInjected.Token(Token = "0x200031B")]
		public enum ResultCode
		{
			[Cpp2IlInjected.Token(Token = "0x4001663")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4001664")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x200031C")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001665")]
			public ResultCode ResultCode;

			[Cpp2IlInjected.Token(Token = "0x6000D89")]
			[Cpp2IlInjected.Address(RVA = "0xE606E0", Offset = "0xE5F0E0", VA = "0x180E606E0")]
			public bool IsSuccess()
			{
				return ResultCode == ResultCode.Success;
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8A")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithResult(ResultCode code)
			{
				ResultCode = code;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200031D")]
		public class Request
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001666")]
			public string country;

			[Cpp2IlInjected.Token(Token = "0x6000D8C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D88")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public InitializeShop()
		{
		}
	}
}
