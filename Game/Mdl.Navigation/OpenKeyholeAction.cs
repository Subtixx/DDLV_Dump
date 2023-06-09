using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BD4")]
	internal class OpenKeyholeAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x6003648")]
		[Cpp2IlInjected.Address(RVA = "0xF05CC0", Offset = "0xF046C0", VA = "0x180F05CC0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003649")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public OpenKeyholeAction()
		{
		}
	}
}
