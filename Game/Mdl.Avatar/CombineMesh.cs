using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A7B")]
	public struct CombineMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40039CB")]
		public SkinnedMeshRenderer smr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40039CC")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40039CD")]
		public bool[] visibleParts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40039CE")]
		public bool splitSkin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40039CF")]
		public bool packVertexColor;

		[Cpp2IlInjected.Token(Token = "0x60030AF")]
		[Cpp2IlInjected.Address(RVA = "0xA8B9A0", Offset = "0xA8A3A0", VA = "0x180A8B9A0")]
		public CombineMesh(SkinnedMeshRenderer smr, Material material, [Optional] bool[] visibleParts, bool splitSkin = false, bool packVertexColor = false)
		{
			this.smr = smr;
			this.material = material;
			this.visibleParts = visibleParts;
			this.splitSkin = false;
			this.packVertexColor = false;
		}
	}
}
