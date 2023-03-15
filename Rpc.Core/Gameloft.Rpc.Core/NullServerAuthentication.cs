using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core.Server;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class NullServerAuthentication : IServerAuthentication
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static IServerAuthentication Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x38DFA00", Offset = "0x38DE400", VA = "0x1838DFA00")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		private NullServerAuthentication()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x38DF850", Offset = "0x38DE250", VA = "0x1838DF850", Slot = "5")]
		Task<AuthContext> IServerAuthentication.GetAuthContext(string token, CancellationToken ct)
		{
			return (Task<AuthContext>)(object)Task.FromResult(AuthContext.Unknown);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x38DF940", Offset = "0x38DE340", VA = "0x1838DF940", Slot = "4")]
		Task<bool> IServerAuthentication.Verify(string token, CancellationToken ct)
		{
			return (Task<bool>)(object)Task.FromResult(result: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x38DF9A0", Offset = "0x38DE3A0", VA = "0x1838DF9A0")]
		static NullServerAuthentication()
		{
			NullServerAuthentication nullServerAuthentication = new NullServerAuthentication();
			/*Error: Unexpected end of block*/;
		}
	}
}
