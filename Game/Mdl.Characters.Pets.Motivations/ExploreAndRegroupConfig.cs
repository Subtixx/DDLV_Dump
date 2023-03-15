using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Pets.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008C8")]
	[CreateAssetMenu]
	public class ExploreAndRegroupConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003126")]
		public ExploreConfig explore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003127")]
		public RegroupConfig regroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003128")]
		[Tooltip("The name of the animation layer to use when exploring. Leave it null if there's none")]
		public string exploringLayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003129")]
		[Tooltip("The distance to start regroup")]
		public float farDistance = 12f;

		[Cpp2IlInjected.Token(Token = "0x600289B")]
		[Cpp2IlInjected.Address(RVA = "0x1368F00", Offset = "0x1367900", VA = "0x181368F00", Slot = "4")]
		public override IMotivation Instantiate()
		{
			ExploreAndRegroup exploreAndRegroup = new ExploreAndRegroup(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600289C")]
		[Cpp2IlInjected.Address(RVA = "0x1368F80", Offset = "0x1367980", VA = "0x181368F80")]
		public ExploreAndRegroupConfig()
		{
		}
	}
}
