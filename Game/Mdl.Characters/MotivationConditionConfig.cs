using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008AC")]
	public abstract class MotivationConditionConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030CF")]
		public bool invert;

		[Cpp2IlInjected.Token(Token = "0x6002824")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract IMotivationCondition Instantiate();

		[Cpp2IlInjected.Token(Token = "0x6002825")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		protected MotivationConditionConfig()
		{
		}
	}
}
