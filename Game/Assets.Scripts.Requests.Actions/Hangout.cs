using Cpp2IlInjected;
using Mdl.Characters;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[Category("Movement/Pathfinding")]
	[Description("The agent hangs out with the avatar")]
	public class Hangout : Follow
	{
		[Cpp2IlInjected.Token(Token = "0x17000117")]
		protected override MotivationConfig followMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x154CB20", Offset = "0x154B520", VA = "0x18154CB20", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.CharacterComponent.hangoutMotivation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x154CB00", Offset = "0x154B500", VA = "0x18154CB00")]
		public Hangout()
		{
		}
	}
}
