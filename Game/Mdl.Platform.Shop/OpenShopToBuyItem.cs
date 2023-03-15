using Cpp2IlInjected;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x200031E")]
	public class OpenShopToBuyItem
	{
		[Cpp2IlInjected.Token(Token = "0x200031F")]
		public enum ResultCode
		{
			[Cpp2IlInjected.Token(Token = "0x4001668")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4001669")]
			NoNativeUserLogged,
			[Cpp2IlInjected.Token(Token = "0x400166A")]
			CannotCastToNativeItem,
			[Cpp2IlInjected.Token(Token = "0x400166B")]
			NativeItemInvalid,
			[Cpp2IlInjected.Token(Token = "0x400166C")]
			NotRunningOnNativePlatform,
			[Cpp2IlInjected.Token(Token = "0x400166D")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x2000320")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400166E")]
			public ResultCode ResultCode;

			[Cpp2IlInjected.Token(Token = "0x6000D8E")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithResult(ResultCode code)
			{
				ResultCode = code;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8F")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(ResultCode code)
			{
				ResultCode = code;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000D90")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000321")]
		public class Request
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400166F")]
			public NativeShopItemBase ItemToBuy;

			[Cpp2IlInjected.Token(Token = "0x6000D91")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D8D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public OpenShopToBuyItem()
		{
		}
	}
}
