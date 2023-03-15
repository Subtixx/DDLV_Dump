using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C4A")]
	internal interface IPlayerInteraction
	{
		[Cpp2IlInjected.Token(Token = "0x6003867")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanInteract();

		[Cpp2IlInjected.Token(Token = "0x6003868")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Interact();

		[Cpp2IlInjected.Token(Token = "0x6003869")]
		[Cpp2IlInjected.Address(Slot = "2")]
		InteractPreviewData GetInteractPreviewData();
	}
}
