using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000962")]
	[CreateAssetMenu]
	public class SparklesDefinition : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037CF")]
		public ParticleSystem sparklesPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037D0")]
		public float distanceFromCamera = 5f;

		[Cpp2IlInjected.Token(Token = "0x6003B22")]
		[Cpp2IlInjected.Address(RVA = "0x15FE710", Offset = "0x15FD110", VA = "0x1815FE710")]
		public SparklesDefinition()
		{
		}
	}
}
