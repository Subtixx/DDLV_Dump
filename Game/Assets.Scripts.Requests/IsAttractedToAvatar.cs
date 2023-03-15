using Cpp2IlInjected;
using Mdl.Characters;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[Category("Mdl")]
	public class IsAttractedToAvatar : MdlConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x11BDD60", Offset = "0x11BC760", VA = "0x1811BDD60", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_001e
			CharacterAttractedToAvatarState _003CAttractedState_003Ek__BackingField = base.CharacterComponent.AttractedState;
			if (_003CAttractedState_003Ek__BackingField.IsAttracted)
			{
				return true;
			}
			return _003CAttractedState_003Ek__BackingField.IsWithinAttractionTime;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public IsAttractedToAvatar()
		{
		}
	}
}
