using Cpp2IlInjected;
using Mdl.Characters;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[Category("Movement/Pathfinding")]
	[Description("The agent is in her realm")]
	public class InRealmAction : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private IMotivation inRealm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private MotivationTime motivationTime = new MotivationTime();

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x11B2D20", Offset = "0x11B1720", VA = "0x1811B2D20", Slot = "9")]
			get
			{
				if (inRealm != null)
				{
					GameObject character = base.Character;
				}
				return base.info;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x11B2A40", Offset = "0x11B1440", VA = "0x1811B2A40", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0061
			//IL_0020: Expected O, but got I4
			if ((long)inRealm == 0)
			{
				MotivationConfig inRealmMotivation = base.CharacterComponent.inRealmMotivation;
				int num = 0;
				if (inRealmMotivation != (Object)num)
				{
					IMotivation motivation = (inRealm = base.CharacterComponent.inRealmMotivation.Instantiate());
				}
				if ((long)inRealm == 0)
				{
					return;
				}
			}
			motivationTime.Reset();
			IMotivation motivation2 = inRealm;
			GameObject character = base.Character;
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x11B2BE0", Offset = "0x11B15E0", VA = "0x1811B2BE0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_0038
			if (inRealm != null)
			{
				float num = motivationTime;
				if ((object)base.Character == null)
				{
					motivationTime.Reset();
					IMotivation motivation = inRealm;
					GameObject character = base.Character;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			BBParameter[] subParameters = ((ISubParametersContainer)this).GetSubParameters();
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x11B2B70", Offset = "0x11B1570", VA = "0x1811B2B70", Slot = "16")]
		protected override void OnStop()
		{
			if (inRealm != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x11B2CB0", Offset = "0x11B16B0", VA = "0x1811B2CB0")]
		public InRealmAction()
		{
		}
	}
}
