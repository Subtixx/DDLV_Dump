using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008CD")]
	[CreateAssetMenu]
	public class FollowConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003143")]
		[Tooltip("Distance from the target to slow down")]
		public float slowDownDistance = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003144")]
		[Tooltip("Distance from target to stop")]
		public float keepDistance = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003145")]
		[Tooltip("Time in seconds to check if character is immobile")]
		public float stuckCheckInterval = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003146")]
		[Tooltip("How frequently to update the target position/path, in seconds.  0 will evaluate every frame")]
		public float updatePathInterval;

		[Cpp2IlInjected.Token(Token = "0x60028AF")]
		[Cpp2IlInjected.Address(RVA = "0x1461440", Offset = "0x145FE40", VA = "0x181461440", Slot = "4")]
		public override IMotivation Instantiate()
		{
			Follow follow = new Follow(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028B0")]
		[Cpp2IlInjected.Address(RVA = "0x14614C0", Offset = "0x145FEC0", VA = "0x1814614C0")]
		public FollowConfig()
		{
		}
	}
}
