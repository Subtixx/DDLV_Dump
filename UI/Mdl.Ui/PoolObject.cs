using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	public class PoolObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public string poolName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public bool isPooled;

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PoolObject()
		{
		}
	}
}
