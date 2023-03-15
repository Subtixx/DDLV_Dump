using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008BF")]
	[CreateAssetMenu]
	internal class WaterSpawnConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030F9")]
		[Tooltip("Maximum number of NPCs allowed to spawn across all WaterSpawns using this config")]
		public int MaxNumberOfSpawns = 1;

		[Cpp2IlInjected.Token(Token = "0x6002863")]
		[Cpp2IlInjected.Address(RVA = "0xD4DF40", Offset = "0xD4C940", VA = "0x180D4DF40")]
		public WaterSpawnConfig()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
