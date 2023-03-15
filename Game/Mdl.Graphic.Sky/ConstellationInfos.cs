using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Sky
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004CE")]
	public class ConstellationInfos
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E24")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E25")]
		public Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E26")]
		public Material stars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E27")]
		public Material image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E28")]
		public Vector3 position;

		[Cpp2IlInjected.Token(Token = "0x600152B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ConstellationInfos()
		{
		}
	}
}
