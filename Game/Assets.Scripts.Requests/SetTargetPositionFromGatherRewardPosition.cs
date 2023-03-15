using Cpp2IlInjected;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[Description("SetTargetPositionFromGatherRewardPosition")]
	[Category("Mdl/Hangout")]
	public class SetTargetPositionFromGatherRewardPosition : MdlActionTask
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xF4AE00", Offset = "0xF49800", VA = "0x180F4AE00", Slot = "13")]
		protected override void OnExecute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public SetTargetPositionFromGatherRewardPosition()
		{
		}
	}
}
