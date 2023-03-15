using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000992")]
	public interface IOnlineAndTransactionAction : ITransactionAction, IOnlineAction
	{
		[Cpp2IlInjected.Token(Token = "0x60053FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> ExecuteAndApply(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct);
	}
}
