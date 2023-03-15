using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006E8")]
	[CreateAssetMenu]
	public class ObjectPOIConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002892")]
		[Tooltip("Chance of interrupting a character in percentage")]
		public float stimulusSoloProbability = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002893")]
		[Tooltip("Weight to be added for this POI when choosing it.")]
		public int weightBonus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002894")]
		[Tooltip("The distance around the object for a character to stand")]
		public float radius = 1f;

		[Cpp2IlInjected.Token(Token = "0x6001EB6")]
		[Cpp2IlInjected.Address(RVA = "0xF039F0", Offset = "0xF023F0", VA = "0x180F039F0")]
		public ObjectPOIConfig()
		{
		}
	}
}
