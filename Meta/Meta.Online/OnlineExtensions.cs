using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FA1")]
	public static class OnlineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6007EE9")]
		[Cpp2IlInjected.Address(RVA = "0x13A8E90", Offset = "0x13A7890", VA = "0x1813A8E90")]
		[AsyncStateMachine(typeof(_003CCreateAndSetScriptExecutor_003Ed__0))]
		public static Task CreateAndSetScriptExecutor(this ClientSession clientSession, OnlineClient onlineClient, OnlineEnvironment envType, [Optional] PlayFabSysHttp sysHttp, [Optional] Serilog.ILogger logger)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
