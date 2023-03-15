using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006F2")]
	[CreateAssetMenu]
	public class VantagePointConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028B8")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSoloProbability = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40028B9")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSocialProbability = 25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40028BA")]
		[Tooltip("Weight to be added for this meeting point when picking a random meeting point")]
		public int weightBonus;

		[Cpp2IlInjected.Token(Token = "0x6001EDD")]
		[Cpp2IlInjected.Address(RVA = "0xD42FC0", Offset = "0xD419C0", VA = "0x180D42FC0")]
		public VantagePointConfig()
		{
		}
	}
}
