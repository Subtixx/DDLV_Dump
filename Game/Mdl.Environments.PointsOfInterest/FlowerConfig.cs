using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006CA")]
	[CreateAssetMenu]
	public class FlowerConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002804")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSoloProbability = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002805")]
		[Tooltip("Weight to be added for this bench when picking a random flower")]
		public int weightBonus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002806")]
		[Tooltip("The distance around the flower for a character to stand")]
		public float radius = 1f;

		[Cpp2IlInjected.Token(Token = "0x6001E2A")]
		[Cpp2IlInjected.Address(RVA = "0xF039F0", Offset = "0xF023F0", VA = "0x180F039F0")]
		public FlowerConfig()
		{
		}
	}
}
