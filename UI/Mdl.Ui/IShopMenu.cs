using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000593")]
	public interface IShopMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6002482")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ShopRefresh.Types.Response> RefreshStall(CancellationToken ct, bool buyMissingSoftCurrencyWithHardCurrency = false);
	}
}
