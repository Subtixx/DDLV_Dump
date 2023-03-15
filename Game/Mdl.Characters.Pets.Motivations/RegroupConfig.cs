using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Pets.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008CB")]
	[CreateAssetMenu]
	public class RegroupConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400313A")]
		public float minSpeed = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400313B")]
		public float maxSpeed = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400313C")]
		public float followTime = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400313D")]
		public float targetDistance = 2f;

		[Cpp2IlInjected.Token(Token = "0x60028A5")]
		[Cpp2IlInjected.Address(RVA = "0xCBD420", Offset = "0xCBBE20", VA = "0x180CBD420", Slot = "4")]
		public override IMotivation Instantiate()
		{
			Regroup regroup = new Regroup(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028A6")]
		[Cpp2IlInjected.Address(RVA = "0xCBD4A0", Offset = "0xCBBEA0", VA = "0x180CBD4A0")]
		public RegroupConfig()
		{
		}
	}
}
