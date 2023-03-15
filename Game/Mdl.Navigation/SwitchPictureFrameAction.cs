using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BF3")]
	internal class SwitchPictureFrameAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x600369B")]
		[Cpp2IlInjected.Address(RVA = "0x106A330", Offset = "0x1068D30", VA = "0x18106A330", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__0))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600369C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A430", Offset = "0xA88E30", VA = "0x180A8A430")]
		public SwitchPictureFrameAction()
		{
		}
	}
}
