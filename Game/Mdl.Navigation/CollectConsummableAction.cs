using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Items;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000B99")]
	public class CollectConsummableAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x60035A3")]
		[Cpp2IlInjected.Address(RVA = "0xA8A2E0", Offset = "0xA88CE0", VA = "0x180A8A2E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035A4")]
		[Cpp2IlInjected.Address(RVA = "0xA8A1C0", Offset = "0xA88BC0", VA = "0x180A8A1C0")]
		[AsyncStateMachine(typeof(_003CCollectConsummable_003Ed__1))]
		private Task CollectConsummable(ItemScript itemScript)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035A5")]
		[Cpp2IlInjected.Address(RVA = "0xA8A430", Offset = "0xA88E30", VA = "0x180A8A430")]
		public CollectConsummableAction()
		{
		}
	}
}
