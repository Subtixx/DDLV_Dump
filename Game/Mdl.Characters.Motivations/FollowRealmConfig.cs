using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008D3")]
	[CreateAssetMenu]
	internal class FollowRealmConfig : FollowConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400314F")]
		public AnimationClip idleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003150")]
		public AnimationClip walkOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003151")]
		public AnimationClip runOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003152")]
		[HideInInspector]
		public AnimationClip _defaultIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003153")]
		[HideInInspector]
		public AnimationClip _defaultWalk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003154")]
		[HideInInspector]
		public AnimationClip _defaultRun;

		[Cpp2IlInjected.Token(Token = "0x60028BB")]
		[Cpp2IlInjected.Address(RVA = "0x1461630", Offset = "0x1460030", VA = "0x181461630", Slot = "4")]
		public override IMotivation Instantiate()
		{
			new FollowRealm(this).config = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028BC")]
		[Cpp2IlInjected.Address(RVA = "0x14614C0", Offset = "0x145FEC0", VA = "0x1814614C0")]
		public FollowRealmConfig()
		{
			slowDownDistance = 5f;
			keepDistance = 2f;
			stuckCheckInterval = 2f;
			((MotivationConfig)this)._002Ector();
		}
	}
}
