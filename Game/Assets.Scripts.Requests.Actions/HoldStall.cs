using System.ComponentModel;
using Cpp2IlInjected;
using Mdl.Characters;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[ParadoxNotion.Design.Category("Movement/Pathfinding")]
	[ParadoxNotion.Design.Description("The agent goes to his stall")]
	public class HoldStall : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private IMotivation holdStall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private MotivationTime motivationTime = new MotivationTime();

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x1551150", Offset = "0x154FB50", VA = "0x181551150", Slot = "9")]
			get
			{
				IMotivation motivation = holdStall;
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

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x1550E00", Offset = "0x154F800", VA = "0x181550E00", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0061
			//IL_0020: Expected O, but got I4
			if ((long)holdStall == 0)
			{
				MotivationConfig holdStallMotivation = base.CharacterComponent.holdStallMotivation;
				int num = 0;
				if (holdStallMotivation != (Object)num)
				{
					IMotivation motivation = (holdStall = base.CharacterComponent.holdStallMotivation.Instantiate());
				}
				if ((long)holdStall == 0)
				{
					return;
				}
			}
			motivationTime.Reset();
			IMotivation motivation2 = holdStall;
			GameObject character = base.Character;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1550FA0", Offset = "0x154F9A0", VA = "0x181550FA0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_004a
			if (holdStall != null)
			{
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
					IMotivation motivation = holdStall;
					GameObject character2 = base.Character;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			string filter = ((IBindingListView)this).Filter;
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1550F30", Offset = "0x154F930", VA = "0x181550F30", Slot = "16")]
		protected override void OnStop()
		{
			if (holdStall != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x15510E0", Offset = "0x154FAE0", VA = "0x1815510E0")]
		public HoldStall()
		{
		}
	}
}
