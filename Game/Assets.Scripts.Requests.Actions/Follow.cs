using System.ComponentModel;
using Cpp2IlInjected;
using Mdl.Characters;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[ParadoxNotion.Design.Category("Movement/Pathfinding")]
	[ParadoxNotion.Design.Description("The agent follows a character around")]
	public class Follow : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private IMotivation follow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private MotivationTime motivationTime = new MotivationTime();

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x1463130", Offset = "0x1461B30", VA = "0x181463130", Slot = "9")]
			get
			{
				IMotivation motivation = follow;
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

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		protected virtual MotivationConfig followMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x1463110", Offset = "0x1461B10", VA = "0x181463110", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.CharacterComponent.followMotivation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x1462AA0", Offset = "0x14614A0", VA = "0x181462AA0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0042
			//IL_001b: Expected O, but got I4
			if ((long)follow == 0)
			{
				MotivationConfig motivationConfig = followMotivation;
				int num = 0;
				if (motivationConfig != (Object)num)
				{
					IMotivation motivation = (follow = followMotivation.Instantiate());
				}
			}
			if (follow != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x1462C30", Offset = "0x1461630", VA = "0x181462C30", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_004a
			if (follow != null)
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
					IMotivation motivation = follow;
					GameObject character2 = base.Character;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			string filter = ((IBindingListView)this).Filter;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x1462BC0", Offset = "0x14615C0", VA = "0x181462BC0", Slot = "16")]
		protected override void OnStop()
		{
			if (follow != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x1463050", Offset = "0x1461A50", VA = "0x181463050")]
		public Follow()
		{
		}
	}
}
