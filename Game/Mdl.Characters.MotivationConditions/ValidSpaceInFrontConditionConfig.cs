using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x200090A")]
	[CreateAssetMenu]
	internal class ValidSpaceInFrontConditionConfig : MotivationConditionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003247")]
		public float raycastDistance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003248")]
		public float sampleDistance = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x6002980")]
		[Cpp2IlInjected.Address(RVA = "0xD42CC0", Offset = "0xD416C0", VA = "0x180D42CC0", Slot = "4")]
		public override IMotivationCondition Instantiate()
		{
			ValidSpaceInFrontCondition validSpaceInFrontCondition = new ValidSpaceInFrontCondition(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002981")]
		[Cpp2IlInjected.Address(RVA = "0xD42D40", Offset = "0xD41740", VA = "0x180D42D40")]
		public ValidSpaceInFrontConditionConfig()
		{
		}
	}
}
