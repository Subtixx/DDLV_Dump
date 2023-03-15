using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008A8")]
	[CreateAssetMenu]
	public class MantaRayAnimationConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030C6")]
		public float radiusX = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40030C7")]
		public float radiusZ = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030C8")]
		public int drawSegments = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40030C9")]
		public float hSpeed = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030CA")]
		public float vSpeed = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40030CB")]
		public float maxDepth = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030CC")]
		public bool clockwise;

		[Cpp2IlInjected.Token(Token = "0x600280B")]
		[Cpp2IlInjected.Address(RVA = "0xBBD960", Offset = "0xBBC360", VA = "0x180BBD960")]
		public MantaRayAnimationConfig()
		{
		}//IL_001f: Expected I4, but got I8

	}
}
