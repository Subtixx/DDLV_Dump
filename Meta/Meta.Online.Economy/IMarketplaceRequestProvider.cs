using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FD1")]
	public interface IMarketplaceRequestProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6007F98")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task GrantAsync(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6007F99")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string GetMarketplaceName();

		[Cpp2IlInjected.Token(Token = "0x6007F9A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<RedeemData>> GetMarketplacesData();

		[Cpp2IlInjected.Token(Token = "0x6007F9B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ServiceLabelData GetServiceLabelData();

		[Cpp2IlInjected.Token(Token = "0x6007F9C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<AuthCodeData> GetAuthCodeAsync();

		[Cpp2IlInjected.Token(Token = "0x6007F9D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string GetDebugInfo();
	}
}
