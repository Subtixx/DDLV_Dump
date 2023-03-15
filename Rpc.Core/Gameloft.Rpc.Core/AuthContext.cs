using System;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public sealed class AuthContext
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[field: Cpp2IlInjected.Token(Token = "0x4000002")]
		public static AuthContext Unknown
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x38D9B70", Offset = "0x38D8570", VA = "0x1838D9B70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000003")]
		public string AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000004")]
		public string DeviceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
		public AuthContext(string accountId, string deviceId)
		{
			AccountId = accountId;
			DeviceId = deviceId;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CED590", Offset = "0x1CEBF90", VA = "0x181CED590", Slot = "2")]
		public override int GetHashCode()
		{
			object obj = ((ICloneable)AccountId).Clone();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x38D9AD0", Offset = "0x38D84D0", VA = "0x1838D9AD0")]
		static AuthContext()
		{
			AuthContext authContext = default(AuthContext);
			authContext.AccountId = "";
			authContext.DeviceId = "";
			Unknown = authContext;
			/*Error: Unexpected end of block*/;
		}
	}
}
