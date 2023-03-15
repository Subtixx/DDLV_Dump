using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000928")]
	internal interface ICritterApproachMotivation : ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.Token(Token = "0x6002A00")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ShouldTrigger(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002A01")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ShouldFlee(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002A02")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ShouldEnterLocomotionAnimationState(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002A03")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CancelFeeding(GameObject agent);
	}
}
