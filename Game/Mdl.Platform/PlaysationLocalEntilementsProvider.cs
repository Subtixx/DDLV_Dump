using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online.Economy;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002C5")]
	public class PlaysationLocalEntilementsProvider : ILocalEntitlementsProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4001567")]
		public static readonly string PlayfabBundleMarketplaceName;

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public string MarketplaceName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C37")]
			[Cpp2IlInjected.Address(RVA = "0xCAFF50", Offset = "0xCAE950", VA = "0x180CAFF50", Slot = "5")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0xCAFE10", Offset = "0xCAE810", VA = "0x180CAFE10", Slot = "4")]
		[AsyncStateMachine(typeof(_003CGetLocallyInstalledEntitlementsAsync_003Ed__3))]
		public Task<List<EntitlementsInfo>> GetLocallyInstalledEntitlementsAsync()
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<List<EntitlementsInfo>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PlaysationLocalEntilementsProvider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0xCAFF00", Offset = "0xCAE900", VA = "0x180CAFF00")]
		static PlaysationLocalEntilementsProvider()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
