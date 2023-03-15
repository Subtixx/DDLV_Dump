using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BC2")]
	internal class ExitEnvironmentAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x600361E")]
		[Cpp2IlInjected.Address(RVA = "0x1368CB0", Offset = "0x13676B0", VA = "0x181368CB0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600361F")]
		[Cpp2IlInjected.Address(RVA = "0x1368DE0", Offset = "0x13677E0", VA = "0x181368DE0")]
		[AsyncStateMachine(typeof(_003CExitEnvironment_003Ed__1))]
		public static Task ExitEnvironment(PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003620")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public ExitEnvironmentAction()
		{
		}
	}
}
