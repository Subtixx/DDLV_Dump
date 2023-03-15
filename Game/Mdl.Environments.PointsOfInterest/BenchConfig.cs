using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Characters;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006B3")]
	[CreateAssetMenu]
	public class BenchConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002788")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSoloProbability = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002789")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSocialProbability = 25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400278A")]
		[Tooltip("Weight to be added for this bench when picking a random bench")]
		public int weightBonus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400278B")]
		public List<NpcBodyType> allowedBodyTypes = (List<NpcBodyType>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6001DC3")]
		[Cpp2IlInjected.Address(RVA = "0x163DD20", Offset = "0x163C720", VA = "0x18163DD20")]
		public BenchConfig()
		{
		}
	}
}
