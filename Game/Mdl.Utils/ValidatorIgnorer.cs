using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20006FA")]
	public class ValidatorIgnorer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028DC")]
		public bool ignoreMissingStreamable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40028DD")]
		public bool ignoreNavMeshInStreamable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40028DE")]
		public bool ignoreGrassMask;

		[Cpp2IlInjected.Token(Token = "0x6001F01")]
		[Cpp2IlInjected.Address(RVA = "0xD42FB0", Offset = "0xD419B0", VA = "0x180D42FB0")]
		private void Awake()
		{
			base.hideFlags = HideFlags.DontSaveInBuild;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F02")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ValidatorIgnorer()
		{
		}
	}
}
