using System;
using Cpp2IlInjected;
using glPlayFab;
using Mdl.Characters;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[Description("The agent will find a place to sit down")]
	[Category("Movement/Pathfinding")]
	public class DebugForceMotivation : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private MotivationConfig forcedMotivationConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private IMotivation forcedMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private MotivationTime motivationTime = new MotivationTime();

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x16197A0", Offset = "0x16181A0", VA = "0x1816197A0", Slot = "9")]
			get
			{
				IMotivation motivation = forcedMotivation;
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

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x16194A0", Offset = "0x1617EA0", VA = "0x1816194A0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_00c2
			//IL_0053: Expected O, but got I4
			MotivationConfig forcedBehaviour = base.CharacterComponent.GetForcedBehaviour();
			bool flag = forcedMotivationConfig != forcedBehaviour;
			int num = 0;
			if (flag)
			{
				if (forcedMotivation != null)
				{
					GameObject character = base.Character;
				}
				forcedMotivationConfig = forcedBehaviour;
				MotivationConfig motivationConfig = forcedMotivationConfig;
				if ((object)motivationConfig != null)
				{
					IMotivation motivation = motivationConfig.Instantiate();
				}
				forcedMotivation = (IMotivation)num;
				if ((IntPtr)forcedMotivation != (IntPtr)num)
				{
					motivationTime.Reset();
					IMotivation motivation2 = forcedMotivation;
					GameObject character2 = base.Character;
				}
			}
			if (forcedMotivation != null)
			{
				float num2 = motivationTime;
				GameObject character3 = base.Character;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (num == 0)
				{
					motivationTime.Reset();
					IMotivation motivation3 = forcedMotivation;
					GameObject character4 = base.Character;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			string uniqueKey = ((IDataReport)this).UniqueKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1619430", Offset = "0x1617E30", VA = "0x181619430", Slot = "16")]
		protected override void OnStop()
		{
			if (forcedMotivation != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x1619730", Offset = "0x1618130", VA = "0x181619730")]
		public DebugForceMotivation()
		{
		}
	}
}
