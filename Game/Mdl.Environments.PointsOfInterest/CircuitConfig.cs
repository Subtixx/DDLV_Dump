using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006C5")]
	[CreateAssetMenu]
	public class CircuitConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027EC")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSoloProbability = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027ED")]
		[Tooltip("Weight to be added for this circuit when picking a random circuit")]
		public int weightBonus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027EE")]
		[Tooltip("Max number of characters on circuit")]
		public int maxOccupants = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40027EF")]
		[Tooltip("Min distance between characters to start running after each other")]
		public float minChaseDistance = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40027F0")]
		[Tooltip("Max distance between characters to start running after each other")]
		public float maxChaseDistance = 8f;

		[Cpp2IlInjected.Token(Token = "0x6001E0F")]
		[Cpp2IlInjected.Address(RVA = "0xA81030", Offset = "0xA7FA30", VA = "0x180A81030")]
		public CircuitConfig()
		{
		}//IL_0014: Expected I4, but got I8

	}
}
