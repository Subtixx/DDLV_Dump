using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Federation.Client;

namespace Gameloft.GdidService
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class GdidApi
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000001")]
		public IAsynchronousClient AsynchronousClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000002")]
		public IReadableConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000003")]
		public ExceptionFactory ExceptionFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4132230", Offset = "0x4130C30", VA = "0x184132230")]
		public GdidApi(IReadableConfiguration configuration)
		{
			//IL_002c: Expected O, but got I4
			if (configuration != null)
			{
				Configuration = configuration;
				IReadableConfiguration readableConfiguration = Configuration;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				ApiClient apiClient = (ApiClient)(AsynchronousClient = new ApiClient((string)num));
				int num3 = 0;
				ExceptionFactory exceptionFactory = (ExceptionFactory = ExceptionFactories.Default);
				exceptionFactory += exceptionFactory;
			}
			ArgumentNullException ex = new ArgumentNullException("configuration");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4131F70", Offset = "0x4130970", VA = "0x184131F70", Slot = "6")]
		[AsyncStateMachine(typeof(_003CAssignGlobalIdAsync_003Ed__12))]
		public Task<string> AssignGlobalIdAsync(AssignGlobalIdRequest request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x41320D0", Offset = "0x4130AD0", VA = "0x1841320D0", Slot = "7")]
		[AsyncStateMachine(typeof(_003CAssignGlobalIdWithHttpInfoAsync_003Ed__13))]
		public Task<ApiResponse<string>> AssignGlobalIdWithHttpInfoAsync(AssignGlobalIdRequest request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ApiResponse<string>>)(object)result;
		}
	}
}
