using Cpp2IlInjected;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[Category("Mdl")]
	public class CanEverBeAttractedToAvatar : MdlConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x12D7A90", Offset = "0x12D6490", VA = "0x1812D7A90", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_000c
			return base.CharacterComponent.IsAquatic;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public CanEverBeAttractedToAvatar()
		{
		}
	}
}
