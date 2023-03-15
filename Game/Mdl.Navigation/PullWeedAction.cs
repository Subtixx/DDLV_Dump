using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Grid;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BEA")]
	public class PullWeedAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x6003682")]
		[Cpp2IlInjected.Address(RVA = "0xCB9CE0", Offset = "0xCB86E0", VA = "0x180CB9CE0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003683")]
		[Cpp2IlInjected.Address(RVA = "0xCB9E30", Offset = "0xCB8830", VA = "0x180CB9E30")]
		[AsyncStateMachine(typeof(_003CPullWeed_003Ed__1))]
		private Task PullWeed(GridObjectScript gridObjectScript, PlayerAvatar avatar)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003684")]
		[Cpp2IlInjected.Address(RVA = "0xA8A430", Offset = "0xA88E30", VA = "0x180A8A430")]
		public PullWeedAction()
		{
		}
	}
}
