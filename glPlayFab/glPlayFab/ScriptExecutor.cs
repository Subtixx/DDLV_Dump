using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.CloudScriptModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ScriptExecutor : ICloudScriptExecutor, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly HttpClientWithTimeout http = new HttpClientWithTimeout();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private readonly string titleId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private readonly string api;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private readonly string version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private string token;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0", Slot = "5")]
		public void UpdateEntityToken(string newEntityToken)
		{
			token = newEntityToken;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x14F54F0", Offset = "0x14F3EF0", VA = "0x1814F54F0")]
		public ScriptExecutor(string url, int? port, string api, string titleId, ILogger logger, [Optional] string token, [Optional] string version)
		{
			//Discarded unreachable code: IL_0060
			//IL_0021: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			this.api = api;
			this.titleId = (string)0;
			this.logger = (ILogger)0;
			this.token = (string)0;
			this.version = (string)0;
			HttpClientWithTimeout httpClientWithTimeout = http;
			Uri uri = new Uri(url);
			int num = default(int);
			Uri baseAddress = new Uri($"{url}:{num}");
			httpClientWithTimeout.SetBaseAddress(baseAddress);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x14F5390", Offset = "0x14F3D90", VA = "0x1814F5390", Slot = "6")]
		public void Dispose()
		{
			http?.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
		public void SetToken(string entityToken)
		{
			token = entityToken;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x14F56D0", Offset = "0x14F40D0", VA = "0x1814F56D0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CglPlayFab_002DICloudScriptExecutor_002DExecuteFunctionAsync_003Ed__10))]
		Task<PlayFabResult<ExecuteFunctionResult>> ICloudScriptExecutor.ExecuteFunctionAsync(ExecuteFunctionRequest request)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<ExecuteFunctionResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x14F53B0", Offset = "0x14F3DB0", VA = "0x1814F53B0")]
		[AsyncStateMachine(typeof(_003CExecuteFunctionAsync_003Ed__11))]
		public Task<ExecuteFunctionResult> ExecuteFunctionAsync(ExecuteFunctionRequest request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ExecuteFunctionResult>)(object)result;
		}
	}
}
