using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Mdl.Characters;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[Description("HasPendingGatherReward")]
	[Category("Mdl/Hangout")]
	public class HasPendingGatherReward : MdlConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x154D090", Offset = "0x154BA90", VA = "0x18154D090", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_0031
			//IL_0010: Expected O, but got I4
			Character characterComponent = base.CharacterComponent;
			int num = 0;
			if (characterComponent != (Object)num)
			{
				Character characterComponent2 = base.CharacterComponent;
			}
			int num2 = 0;
			Character character = default(Character);
			return ((RepeatedField<T>)(object)character.MetaCharacter.pendingHangoutGatherRewards_).Count > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public HasPendingGatherReward()
		{
		}
	}
}
