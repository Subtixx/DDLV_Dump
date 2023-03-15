using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008A9")]
	public abstract class MotivationConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600280C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract IMotivation Instantiate();

		[Cpp2IlInjected.Token(Token = "0x600280D")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		protected MotivationConfig()
		{
		}
	}
}
