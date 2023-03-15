using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Shops;
using UnityEngine;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000387")]
	public class GameIAPManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000F31")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void InitializePurchasing(Dictionary<string, string> products)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F32")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD20", Offset = "0x8BB720", VA = "0x1808BCD20")]
		public Task<CRMBuyResult> BuyIAP(string productId, [Optional] CancellationToken ct)
		{
			return (Task<CRMBuyResult>)(object)Task.FromResult(CRMBuyResult.Success);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F33")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GameIAPManager()
		{
		}
	}
}
