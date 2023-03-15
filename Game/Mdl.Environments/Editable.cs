using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200063E")]
	public class Editable : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002558")]
		public bool currentGridOnly;

		[Cpp2IlInjected.Token(Token = "0x6001BBD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Editable()
		{
		}
	}
}
