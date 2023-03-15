using System.ComponentModel;
using Cpp2IlInjected;
using Mdl.Characters;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[ParadoxNotion.Design.Description("Sets the current motivation for the agent.")]
	[ParadoxNotion.Design.Category("Mdl/AI")]
	public class PlayMotivation : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		[RequiredField]
		public BBParameter<MotivationConfig> motivationConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private IMotivation motivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private MotivationTime motivationTime = new MotivationTime();

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x14BA810", Offset = "0x14B9210", VA = "0x1814BA810", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_003d
			IMotivation motivation = (this.motivation = ((MotivationConfig)((BBParameter<T>)(object)motivationConfig).value).Instantiate());
			if ((long)this.motivation != 0)
			{
				motivationTime.Reset();
				IMotivation motivation2 = this.motivation;
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x14BA960", Offset = "0x14B9360", VA = "0x1814BA960", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_004a
			if (this.motivation != null)
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
					IMotivation motivation = this.motivation;
					GameObject character2 = base.Character;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			string filter = ((IBindingListView)this).Filter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x14BA8F0", Offset = "0x14B92F0", VA = "0x1814BA8F0", Slot = "16")]
		protected override void OnStop()
		{
			if (motivation != null)
			{
				GameObject character = base.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x14BAAA0", Offset = "0x14B94A0", VA = "0x1814BAAA0")]
		public PlayMotivation()
		{
		}
	}
}
