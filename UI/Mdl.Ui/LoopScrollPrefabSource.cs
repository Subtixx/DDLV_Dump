using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	public class LoopScrollPrefabSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public GameObject prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public string prefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		public int poolSize = 5;

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x13317D0", Offset = "0x13301D0", VA = "0x1813317D0")]
		public LoopScrollPrefabSource()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
