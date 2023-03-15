using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Missions;
using Mdl.Systems;
using Meta.Missions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	public class GetDialogChoice : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		[BlackboardOnly]
		public BBParameter<MissionChoice> choice;

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x8CB460", Offset = "0x8C9E60", VA = "0x1808CB460", Slot = "9")]
			get
			{
				return "get dialog choice";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x8CB2F0", Offset = "0x8C9CF0", VA = "0x1808CB2F0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0032
			BBParameter<MissionChoice> bBParameter = choice;
			MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
			MissionSlot missionSlot = base.MissionSlot;
			int iD = base.CharacterComponent.Data.ID;
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public GetDialogChoice()
		{
		}
	}
}
