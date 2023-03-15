using Cpp2IlInjected;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[Category("Mdl")]
	public class IsAttractedToAvatarWithinDuration : MdlConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x11BDD30", Offset = "0x11BC730", VA = "0x1811BDD30", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_0011
			return base.CharacterComponent.AttractedState.IsWithinAttractionTime;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public IsAttractedToAvatarWithinDuration()
		{
		}
	}
}
