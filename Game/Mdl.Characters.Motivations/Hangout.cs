using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008D8")]
	internal class Hangout : Follow
	{
		[Cpp2IlInjected.Token(Token = "0x60028CB")]
		[Cpp2IlInjected.Address(RVA = "0x154CB10", Offset = "0x154B510", VA = "0x18154CB10")]
		public Hangout(FollowConfig config)
			: base(config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60028CC")]
		[Cpp2IlInjected.Address(RVA = "0x1461D70", Offset = "0x1460770", VA = "0x181461D70", Slot = "19")]
		protected override GameObject GetCharacterToFollow(Character fromCharacter)
		{
			//Discarded unreachable code: IL_0007
			return fromCharacter.Avatar;
		}
	}
}
