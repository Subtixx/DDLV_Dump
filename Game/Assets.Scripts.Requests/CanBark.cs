using System;
using Cpp2IlInjected;
using Mdl.Characters;
using Meta.Online;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	public class CanBark : MdlConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x12D7960", Offset = "0x12D6360", VA = "0x1812D7960", Slot = "15")]
		protected override bool OnCheck()
		{
			Character characterComponent = base.CharacterComponent;
			if (characterComponent.MetaCharacter.InVillage && !characterComponent.RelaxingBehaviour.Relaxing && !characterComponent.TraversingLink)
			{
				Client client = default(Client);
				DateTime serverTime = client.ServerTime;
				DateTime nextAvatarReaction = characterComponent.nextAvatarReaction;
				return serverTime >= nextAvatarReaction;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public CanBark()
		{
		}
	}
}
