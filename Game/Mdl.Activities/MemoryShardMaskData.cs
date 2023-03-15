using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B7C")]
	[CreateAssetMenu]
	public class MemoryShardMaskData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003FE0")]
		public Texture2D Mask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003FE1")]
		public Texture2D Outline;

		[Cpp2IlInjected.Token(Token = "0x6003533")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public MemoryShardMaskData()
		{
		}
	}
}
