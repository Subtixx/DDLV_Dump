using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000736")]
	internal class ColliderRedirection : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029EE")]
		public GameObject Redirection;

		[Cpp2IlInjected.Token(Token = "0x6001FFC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ColliderRedirection()
		{
		}
	}
}
