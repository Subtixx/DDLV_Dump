using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SharedTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool RunOnlyOnce
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x102F2A0", Offset = "0x102DCA0", VA = "0x18102F2A0")]
		public SharedTask(bool runOnlyOnce = false)
		{
			RunOnlyOnce = runOnlyOnce;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41144A0", Offset = "0x4112EA0", VA = "0x1841144A0")]
		[AsyncStateMachine(typeof(_003CRunTask_003Ed__5))]
		public Task RunTask(Func<Task> func)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class SharedTask<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool RunOnlyOnce
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2145790", Offset = "0x2144190", VA = "0x182145790")]
		public SharedTask(bool runOnlyOnce = false)
		{
			//Discarded unreachable code: IL_000e
			XmlNodeType nodeType = ((XObject)this).NodeType;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2145490", Offset = "0x2143E90", VA = "0x182145490")]
		[AsyncStateMachine(typeof(SharedTask<>._003CRunTask_003Ed__6))]
		public Task<T> RunTask(Func<Task<T>> func)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<T>)(object)result;
		}
	}
}
