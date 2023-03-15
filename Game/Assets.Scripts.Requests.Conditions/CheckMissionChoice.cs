using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Missions;
using Mdl.Systems;
using Meta.Missions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl")]
	[Description("(Ctrl-Shift-P) Branch based on user choice: Choice 1,2,3 or any")]
	public class CheckMissionChoice : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public BBParameter<MissionChoice> choice;

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0xA80A20", Offset = "0xA7F420", VA = "0x180A80A20", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0018
				//IL_000c: Expected I4, but got O
				//IL_0017: Expected O, but got I4
				MissionChoice missionChoice = (MissionChoice)((BBParameter<T>)(object)choice).value;
				return $"DialogChoice is {missionChoice}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xA808C0", Offset = "0xA7F2C0", VA = "0x180A808C0", Slot = "15")]
		protected override bool OnCheck()
		{
			//IL_0031: Expected I4, but got O
			if ((object)SystemRoot.Instance.GetSystem<MissionManager>() != null)
			{
				MissionSlot missionSlot = base.MissionSlot;
				int iD = base.CharacterComponent.Data.ID;
				MissionChoice missionChoice = (MissionChoice)((BBParameter<T>)(object)choice).value;
				bool result = default(bool);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public CheckMissionChoice()
		{
		}
	}
}
