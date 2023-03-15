using System.ComponentModel;
using Cpp2IlInjected;
using Mdl.Characters;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[ParadoxNotion.Design.Description("The agent is free to enjoy the village as she likes")]
	[ParadoxNotion.Design.Category("Movement/Pathfinding")]
	public class EnjoyFreeTime : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private IMotivation freeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private MotivationTime motivationTime = new MotivationTime();

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x19DB5E0", Offset = "0x19D9FE0", VA = "0x1819DB5E0", Slot = "9")]
			get
			{
				IMotivation motivation = freeTime;
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

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x19DB180", Offset = "0x19D9B80", VA = "0x1819DB180", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0069
			//IL_0020: Expected O, but got I4
			if ((long)freeTime == 0)
			{
				MotivationConfig freeTimeMotivation = base.CharacterComponent.freeTimeMotivation;
				int num = 0;
				if (freeTimeMotivation != (Object)num)
				{
					IMotivation motivation = (freeTime = base.CharacterComponent.freeTimeMotivation.Instantiate());
				}
				if ((long)freeTime == 0)
				{
					return;
				}
			}
			if (base.CharacterComponent.NavMeshAgentComponent.isOnNavMesh)
			{
				IMotivation motivation2 = freeTime;
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x19DB340", Offset = "0x19D9D40", VA = "0x1819DB340", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_00ac
			if (base.CharacterComponent.debugShouldResetMotivation)
			{
				IMotivation motivation = freeTime;
				GameObject navMeshAgent = base.CharacterComponent.NavMeshAgent;
				IMotivation motivation2 = (freeTime = base.CharacterComponent.freeTimeMotivation.Instantiate());
				base.CharacterComponent.debugShouldResetMotivation = false;
			}
			if (freeTime != null)
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
				if (num2 == 0 && base.CharacterComponent.NavMeshAgentComponent.isOnNavMesh)
				{
					motivationTime.Reset();
					IMotivation motivation3 = freeTime;
					GameObject character2 = base.Character;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			bool supportsAdvancedSorting = ((IBindingListView)this).SupportsAdvancedSorting;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x19DB2D0", Offset = "0x19D9CD0", VA = "0x1819DB2D0", Slot = "16")]
		protected override void OnStop()
		{
			if (freeTime != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x19DB570", Offset = "0x19D9F70", VA = "0x1819DB570")]
		public EnjoyFreeTime()
		{
		}
	}
}
