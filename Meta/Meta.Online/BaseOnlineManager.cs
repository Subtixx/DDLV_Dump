using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E82")]
	public abstract class BaseOnlineManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003AC4")]
		protected readonly OnlineClient onlineClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003AC5")]
		protected CancellationTokenSource configCTS = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x17001514")]
		protected Client client
		{
			[Cpp2IlInjected.Token(Token = "0x60078F6")]
			[Cpp2IlInjected.Address(RVA = "0x18B26F0", Offset = "0x18B10F0", VA = "0x1818B26F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return onlineClient.client;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001515")]
		public abstract double FetchDataIntervalTime
		{
			[Cpp2IlInjected.Token(Token = "0x60078F7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001516")]
		public abstract string LocalFileRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60078F8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001517")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003AC6")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60078F9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60078FA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001518")]
		protected static IFileSystem SaveFileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60078FD")]
			[Cpp2IlInjected.Address(RVA = "0x738FA0", Offset = "0x7379A0", VA = "0x180738FA0")]
			get
			{
				return FileSystem.Save;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60078FB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract Task<bool> Load(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60078FC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract Task FetchAndSave(bool forceSave, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60078FE")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9A20", Offset = "0x1AB8420", VA = "0x181AB9A20")]
		protected BaseOnlineManager(OnlineClient onlineClient)
		{
			//Discarded unreachable code: IL_0030
			this.onlineClient = onlineClient;
			CancellationToken token = configCTS.Token;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60078FF")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9900", Offset = "0x1AB8300", VA = "0x181AB9900")]
		[AsyncStateMachine(typeof(_003CWaitForNextFetchDataCheckAsync_003Ed__17))]
		private Task WaitForNextFetchDataCheckAsync(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007900")]
		[Cpp2IlInjected.Address(RVA = "0x1AB97D0", Offset = "0x1AB81D0", VA = "0x181AB97D0")]
		[AsyncStateMachine(typeof(_003CFetchData_003Ed__18))]
		public Task FetchData(bool forceSave, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
