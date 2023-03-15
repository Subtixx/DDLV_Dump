using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Missions;
using Mdl.Systems;
using Meta.Missions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[Description("(Ctrl-Shift-1-2-3) AcceptMission is also required when used in IntroDialog")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl")]
	public class SetDialogChoice : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public BBParameter<MissionChoice> choice;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xF4A050", Offset = "0xF48A50", VA = "0x180F4A050", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0018
				//IL_000c: Expected I4, but got O
				//IL_0017: Expected O, but got I4
				MissionChoice missionChoice = (MissionChoice)((BBParameter<T>)(object)choice).value;
				return $"SetChoice({missionChoice})";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xF49F20", Offset = "0xF48920", VA = "0x180F49F20", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0026
			//IL_001e: Expected I4, but got O
			MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
			MissionSlot missionSlot = base.MissionSlot;
			MissionChoice missionChoice = (MissionChoice)((BBParameter<T>)(object)choice).value;
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public SetDialogChoice()
		{
		}
	}
}
