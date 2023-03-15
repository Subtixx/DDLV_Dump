using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200062A")]
	public class CastleVisualLevel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024FD")]
		public GameObject[] objectsToDisable;

		[Cpp2IlInjected.Token(Token = "0x6001B51")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CastleVisualLevel()
		{
		}
	}
}
