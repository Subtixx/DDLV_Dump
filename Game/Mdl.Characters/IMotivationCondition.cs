using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008AD")]
	public interface IMotivationCondition
	{
		[Cpp2IlInjected.Token(Token = "0x6002826")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IsTrue(GameObject agent, IMotivation currentMotivation);
	}
}
