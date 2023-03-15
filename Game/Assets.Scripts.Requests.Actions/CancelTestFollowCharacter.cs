using Cpp2IlInjected;
using Mdl.Missions;
using Mdl.Systems;
using Meta.Missions;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	public class CancelTestFollowCharacter : MdlActionTask
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x12D7AC0", Offset = "0x12D64C0", VA = "0x1812D7AC0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0025
			MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
			if ((object)system != null)
			{
				MissionSlot missionSlot = base.MissionSlot;
				system.CancelTestFollowCharacter(missionSlot);
			}
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public CancelTestFollowCharacter()
		{
		}
	}
}
