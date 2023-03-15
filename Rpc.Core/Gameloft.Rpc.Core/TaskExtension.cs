using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class TaskExtension
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1753970", Offset = "0x1752370", VA = "0x181753970")]
		[AsyncStateMachine(typeof(_003CWithCancellation_003Ed__0<>))]
		public static Task<T> WithCancellation<T>(this Task<T> task, CancellationToken ct)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<T>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x38E4150", Offset = "0x38E2B50", VA = "0x1838E4150")]
		[AsyncStateMachine(typeof(_003CWithCancellation_003Ed__1))]
		public static Task WithCancellation(this Task task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
