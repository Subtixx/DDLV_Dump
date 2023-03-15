using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class CreateDelegateInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000021")]
		public CreateDelegate CreateFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool IsSingleton
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1B58AE0", Offset = "0x1B574E0", VA = "0x181B58AE0")]
		public CreateDelegateInfo(CreateDelegate createFunc, bool isSingleton)
		{
			CreateFunc = createFunc;
			IsSingleton = isSingleton;
		}
	}
}
