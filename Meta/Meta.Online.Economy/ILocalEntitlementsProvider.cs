using System.Collections.Generic;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FCD")]
	public interface ILocalEntitlementsProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17001650")]
		string MarketplaceName
		{
			[Cpp2IlInjected.Token(Token = "0x6007F94")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F93")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<EntitlementsInfo>> GetLocallyInstalledEntitlementsAsync();
	}
}
