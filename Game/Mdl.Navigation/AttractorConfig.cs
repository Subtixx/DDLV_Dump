using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C1E")]
	[CreateAssetMenu]
	public class AttractorConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400438E")]
		[Tooltip("Max distance from which to attract characters")]
		public float maxRange = 3000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400438F")]
		[Tooltip("Max number of characters to attract")]
		public int maxCharacters = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004390")]
		[Tooltip("Time between attempting to attract aquatic characters while attractor is active")]
		public float periodicCheckInterval = 1f;

		[Cpp2IlInjected.Token(Token = "0x6003725")]
		[Cpp2IlInjected.Address(RVA = "0xA47940", Offset = "0xA46340", VA = "0x180A47940")]
		public AttractorConfig()
		{
		}//IL_0014: Expected I4, but got I8

	}
}
