using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DCE")]
	public class SocialUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60072E1")]
		[Cpp2IlInjected.Address(RVA = "0x1832AF0", Offset = "0x18314F0", VA = "0x181832AF0")]
		[AsyncStateMachine(typeof(_003CGetOnlineProfileData_003Ed__0))]
		public static Task<OnlineProfile> GetOnlineProfileData(ClientSession clientSession, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<OnlineProfile>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60072E2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SocialUtils()
		{
		}
	}
}
