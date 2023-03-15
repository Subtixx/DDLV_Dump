using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class AsyncAuthentication : IClientAuthentication
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public delegate Task<string> GenerateTokenAsync(CancellationToken ct);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private GenerateTokenAsync generateTokenAsync;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public AsyncAuthentication(GenerateTokenAsync generateTokenAsync)
		{
			this.generateTokenAsync = generateTokenAsync;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x38D9590", Offset = "0x38D7F90", VA = "0x1838D9590", Slot = "4")]
		Task<string> IClientAuthentication.GenerateToken(CancellationToken ct)
		{
			//Discarded unreachable code: IL_000d
			return (Task<string>)(object)generateTokenAsync(ct);
		}
	}
}
