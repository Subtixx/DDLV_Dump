using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x2000999")]
	public interface IDisplayBuyable
	{
		[Cpp2IlInjected.Token(Token = "0x6002CD7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<StoreBuyItem.Types.Response> BuyItem(DisplaySlotData slotToBuy, CancellationToken ct);
	}
}
