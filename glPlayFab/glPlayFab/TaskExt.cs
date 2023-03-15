using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public static class TaskExt
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1753820", Offset = "0x1752220", VA = "0x181753820")]
		[AsyncStateMachine(typeof(_003CWithCancellation_003Ed__0<>))]
		public static Task<T> WithCancellation<T>(this Task<T> task, CancellationToken ct)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<T>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x14F7110", Offset = "0x14F5B10", VA = "0x1814F7110")]
		[AsyncStateMachine(typeof(_003CWithCancellation_003Ed__1))]
		public static Task WithCancellation(this Task task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
