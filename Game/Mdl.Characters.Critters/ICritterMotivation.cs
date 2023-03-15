using Cpp2IlInjected;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000925")]
	internal interface ICritterMotivation : IMotivation
	{
		[Cpp2IlInjected.Token(Token = "0x60029F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanInteractWithAvatar();

		[Cpp2IlInjected.Token(Token = "0x60029F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CanBeFed();
	}
}
