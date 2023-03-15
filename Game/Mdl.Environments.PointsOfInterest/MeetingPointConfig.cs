using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006D8")]
	[CreateAssetMenu]
	public class MeetingPointConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002836")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSocialProbability = 25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002837")]
		[Tooltip("Weight to be added for this meeting point when picking a random meeting point")]
		public int weightBonus;

		[Cpp2IlInjected.Token(Token = "0x6001E68")]
		[Cpp2IlInjected.Address(RVA = "0xBC2A80", Offset = "0xBC1480", VA = "0x180BC2A80")]
		public MeetingPointConfig()
		{
		}
	}
}
