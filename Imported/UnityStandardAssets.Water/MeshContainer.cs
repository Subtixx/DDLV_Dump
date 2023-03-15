using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class MeshContainer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public Vector3[] vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public Vector3[] normals;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2F174C0", Offset = "0x2F15EC0", VA = "0x182F174C0")]
		public MeshContainer(Mesh m)
		{
			mesh = m;
			Vector3[] array = (vertices = m.vertices);
			Vector3[] array2 = (normals = m.normals);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2F17480", Offset = "0x2F15E80", VA = "0x182F17480")]
		public void Update()
		{
			//Discarded unreachable code: IL_002b
			Mesh mesh = this.mesh;
			Vector3[] array2 = (mesh.vertices = vertices);
			Mesh mesh2 = this.mesh;
			Vector3[] array4 = (mesh2.normals = normals);
		}
	}
}
