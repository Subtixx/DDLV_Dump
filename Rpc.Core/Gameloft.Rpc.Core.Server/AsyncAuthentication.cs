using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class AsyncAuthentication : IServerAuthentication
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public delegate Task<AuthContext> GetContextAsync(string token, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public delegate Task<bool> VerifyAsync(string token, CancellationToken ct);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly GetContextAsync getContextDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly VerifyAsync verifyDelegate;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
		public AsyncAuthentication(GetContextAsync getContextDelegate, VerifyAsync verifyDelegate)
		{
			this.getContextDelegate = getContextDelegate;
			this.verifyDelegate = verifyDelegate;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x38D95B0", Offset = "0x38D7FB0", VA = "0x1838D95B0", Slot = "5")]
		Task<AuthContext> IServerAuthentication.GetAuthContext(string token, CancellationToken ct)
		{
			//Discarded unreachable code: IL_000e
			return (Task<AuthContext>)(object)getContextDelegate(token, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x38D95D0", Offset = "0x38D7FD0", VA = "0x1838D95D0", Slot = "4")]
		Task<bool> IServerAuthentication.Verify(string token, CancellationToken ct)
		{
			//Discarded unreachable code: IL_000e
			return (Task<bool>)(object)verifyDelegate(token, ct);
		}
	}
}
