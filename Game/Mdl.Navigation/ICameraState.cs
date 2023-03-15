using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C2A")]
	public interface ICameraState : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6003761")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task RestoreAsync(CancellationToken ct);
	}
}
