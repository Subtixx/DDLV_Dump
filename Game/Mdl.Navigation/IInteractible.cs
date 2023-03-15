using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C6E")]
	public interface IInteractible
	{
		[Cpp2IlInjected.Token(Token = "0x600398E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnActivation(GameObject previousInteractible);

		[Cpp2IlInjected.Token(Token = "0x600398F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnDeactivation(GameObject nextInteractible);
	}
}
