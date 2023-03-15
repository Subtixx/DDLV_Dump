using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.DataModels;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F9D")]
	public static class OnlineClientProfileExt
	{
		[Cpp2IlInjected.Token(Token = "0x6007EDD")]
		[Cpp2IlInjected.Address(RVA = "0x13A27F0", Offset = "0x13A11F0", VA = "0x1813A27F0")]
		[AsyncStateMachine(typeof(_003CFetchPlayFabFile_003Ed__0))]
		public static Task<(string, OnlineClient.FetchPlayFabFileResult.ResultTypes)> FetchPlayFabFile(this PlayFabDataInstanceAPI dataInst, string filename, [Optional] string checksum, [Optional] ILogger logger, [Optional] EntityKey entityKey, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(string, OnlineClient.FetchPlayFabFileResult.ResultTypes)>)(object)result;
		}
	}
}
