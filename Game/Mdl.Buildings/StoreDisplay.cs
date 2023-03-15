using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009D1")]
	public abstract class StoreDisplay : Display, IDisplayBuyable
	{
		[Cpp2IlInjected.Token(Token = "0x6002DF3")]
		[Cpp2IlInjected.Address(RVA = "0xF63FB0", Offset = "0xF629B0", VA = "0x180F63FB0", Slot = "12")]
		[AsyncStateMachine(typeof(_003CBuyItem_003Ed__0))]
		public Task<StoreBuyItem.Types.Response> BuyItem(DisplaySlotData slotToBuy, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<StoreBuyItem.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF4")]
		[Cpp2IlInjected.Address(RVA = "0xF640F0", Offset = "0xF62AF0", VA = "0x180F640F0")]
		protected StoreDisplay()
		{
		}
	}
}
