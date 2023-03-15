using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000932")]
	[CreateAssetMenu]
	internal class IsCritterFedConditionConfig : MotivationConditionConfig
	{
		[Cpp2IlInjected.Token(Token = "0x6002A50")]
		[Cpp2IlInjected.Address(RVA = "0x11BDDB0", Offset = "0x11BC7B0", VA = "0x1811BDDB0", Slot = "4")]
		public override IMotivationCondition Instantiate()
		{
			IsCritterFedCondition isCritterFedCondition = new IsCritterFedCondition(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A51")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public IsCritterFedConditionConfig()
		{
		}
	}
}
