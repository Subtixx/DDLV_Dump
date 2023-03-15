using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x2000580")]
	public interface IFtueElement
	{
		[Cpp2IlInjected.Token(Token = "0x600189F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ShouldActivateFtue(FtueStep step);

		[Cpp2IlInjected.Token(Token = "0x60018A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task ActivateFtue(FtueStep step, CancellationToken ct);
	}
}
