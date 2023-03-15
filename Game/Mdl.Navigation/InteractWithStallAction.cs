using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BD1")]
	internal class InteractWithStallAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x6003641")]
		[Cpp2IlInjected.Address(RVA = "0x11B9430", Offset = "0x11B7E30", VA = "0x1811B9430", Slot = "4")]
		[AsyncStateMachine(typeof(_003CStartAction_003Ed__0))]
		public override Task StartAction(PlayerAvatar avatar, PlayerTask task)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003642")]
		[Cpp2IlInjected.Address(RVA = "0x11B9300", Offset = "0x11B7D00", VA = "0x1811B9300", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__1))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003643")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public InteractWithStallAction()
		{
		}
	}
}
