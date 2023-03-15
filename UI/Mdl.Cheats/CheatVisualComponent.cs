using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	public class CheatVisualComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public string Name;

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CheatVisualComponent()
		{
		}
	}
}
