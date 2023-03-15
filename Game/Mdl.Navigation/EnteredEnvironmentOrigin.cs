using Cpp2IlInjected;
using Mdl.Environments;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C44")]
	public class EnteredEnvironmentOrigin : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004488")]
		public BaseEnvironmentDoor Door;

		[Cpp2IlInjected.Token(Token = "0x600384A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EnteredEnvironmentOrigin()
		{
		}
	}
}
