using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core.Client;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public sealed class NullClientAuthentication : IClientAuthentication
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IClientAuthentication Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x38DF5D0", Offset = "0x38DDFD0", VA = "0x1838DF5D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		private NullClientAuthentication()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x38DF500", Offset = "0x38DDF00", VA = "0x1838DF500", Slot = "4")]
		public Task<string> GenerateToken(CancellationToken ct)
		{
			return (Task<string>)(object)Task.FromResult("");
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x38DF570", Offset = "0x38DDF70", VA = "0x1838DF570")]
		static NullClientAuthentication()
		{
			NullClientAuthentication nullClientAuthentication = new NullClientAuthentication();
			/*Error: Unexpected end of block*/;
		}
	}
}
