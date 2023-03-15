using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000B96")]
	internal interface IIndexState : IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x600359E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<int> ChooseNewIndex(CancellationToken ct);
	}
}
