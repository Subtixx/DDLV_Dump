using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C15")]
	internal class UseRadioAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x6003703")]
		[Cpp2IlInjected.Address(RVA = "0xD3F470", Offset = "0xD3DE70", VA = "0x180D3F470", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003704")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public UseRadioAction()
		{
		}
	}
}
