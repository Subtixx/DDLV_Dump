using Cpp2IlInjected;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[Category("Mdl")]
	public class IsAttractedToAvatarOnCooldown : MdlConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x11BDD00", Offset = "0x11BC700", VA = "0x1811BDD00", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_0011
			return base.CharacterComponent.AttractedState.IsInCooldown;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public IsAttractedToAvatarOnCooldown()
		{
		}
	}
}
