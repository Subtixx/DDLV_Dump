using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Characters.Critters;
using Mdl.Systems;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BC8")]
	internal class InteractWithCritterAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x600362C")]
		[Cpp2IlInjected.Address(RVA = "0x11B8710", Offset = "0x11B7110", VA = "0x1811B8710", Slot = "5")]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002a
			base.CanBeResumed = false;
			int immediately = 0;
			task.StopVfx((byte)immediately != 0);
			CritterManager system = SystemRoot.Instance.GetSystem<CritterManager>();
			Critter taskData = task.GetTaskData<Critter>();
			return system.FeedCritterFlow(taskData);
		}

		[Cpp2IlInjected.Token(Token = "0x600362D")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public InteractWithCritterAction()
		{
		}
	}
}
