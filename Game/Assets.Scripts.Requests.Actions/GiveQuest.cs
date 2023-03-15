using System.ComponentModel;
using Cpp2IlInjected;
using Mdl.Characters;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[ParadoxNotion.Design.Category("Movement/Pathfinding")]
	[ParadoxNotion.Design.Description("The agent waits at a meeting point for the player")]
	public class GiveQuest : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private IMotivation giveQuest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private MotivationTime motivationTime = new MotivationTime();

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x8CD760", Offset = "0x8CC160", VA = "0x1808CD760", Slot = "9")]
			get
			{
				IMotivation motivation = giveQuest;
				if (motivation != null)
				{
					GameObject character = base.Character;
					int num = 0;
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					IMotivation subMotivation = motivation.SubMotivation;
					character = (GameObject)(object)((object)character + (object)character);
				}
				return base.info;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3E0", Offset = "0x8CBDE0", VA = "0x1808CD3E0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_004c
			//IL_0020: Expected O, but got I4
			if ((long)giveQuest == 0)
			{
				MotivationConfig giveQuestMotivation = base.CharacterComponent.giveQuestMotivation;
				int num = 0;
				if (giveQuestMotivation != (Object)num)
				{
					IMotivation motivation = (giveQuest = base.CharacterComponent.giveQuestMotivation.Instantiate());
				}
			}
			if (giveQuest != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD580", Offset = "0x8CBF80", VA = "0x1808CD580", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_0054, IL_005a, IL_0060
			if ((long)giveQuest != 0)
			{
				IMotivation motivation = giveQuest;
				float num = motivationTime;
				GameObject character = base.Character;
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
				if ((object)character == null)
				{
					motivationTime.Reset();
					IMotivation motivation2 = giveQuest;
					GameObject character2 = base.Character;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			TypeConverter converter = ((ICustomTypeDescriptor)this).GetConverter();
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD510", Offset = "0x8CBF10", VA = "0x1808CD510", Slot = "16")]
		protected override void OnStop()
		{
			if (giveQuest != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD6F0", Offset = "0x8CC0F0", VA = "0x1808CD6F0")]
		public GiveQuest()
		{
		}
	}
}
