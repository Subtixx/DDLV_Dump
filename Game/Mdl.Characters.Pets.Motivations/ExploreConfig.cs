using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Pets.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008C9")]
	[CreateAssetMenu]
	public class ExploreConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400312A")]
		public float minSpeed = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400312B")]
		public float maxSpeed = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400312C")]
		public float minDistance = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400312D")]
		public float maxDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400312E")]
		public int minDestinations = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400312F")]
		public int maxDestinations = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003130")]
		public float destinationInterval = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003131")]
		public float minIdleTime = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003132")]
		public float maxIdleTime = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003133")]
		public float maxRotation = 40f;

		[Cpp2IlInjected.Token(Token = "0x600289D")]
		[Cpp2IlInjected.Address(RVA = "0x1369F90", Offset = "0x1368990", VA = "0x181369F90", Slot = "4")]
		public override IMotivation Instantiate()
		{
			Explore explore = new Explore(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600289E")]
		[Cpp2IlInjected.Address(RVA = "0x136A010", Offset = "0x1368A10", VA = "0x18136A010")]
		public ExploreConfig()
		{
		}//IL_0035: Expected I4, but got I8
		//IL_003f: Expected I4, but got I8

	}
}
