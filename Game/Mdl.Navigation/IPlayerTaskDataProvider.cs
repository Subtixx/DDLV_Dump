using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C75")]
	public interface IPlayerTaskDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6003996")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IPlayerTaskData> GetPlayerTaskData(PlayerTaskDefinition playerTaskDefinition, CancellationToken ct);
	}
}
