using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NPCAnimationObjectSpawner : MonoBehaviour
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct TagObjectPairs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string Tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GameObject ReferenceObject;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public List<TagObjectPairs> TagObjectPairsList;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public NPCAnimationObjectSpawner()
	{
	}
}
