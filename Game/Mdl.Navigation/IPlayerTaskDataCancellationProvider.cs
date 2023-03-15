using System.Threading;
using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C76")]
	public interface IPlayerTaskDataCancellationProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6003997")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CancellationToken GetCancellationToken();
	}
}
