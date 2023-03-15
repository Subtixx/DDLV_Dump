using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x200049C")]
	[ExecuteAlways]
	public class TerrainManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D09")]
		public TerrainRect[] terrainRects = new TerrainRect[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D0A")]
		public Texture2DArray groundAlbedo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D0B")]
		public Texture2D terrainLUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D0C")]
		public Vector2 terrainRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D0D")]
		public RectInt terrainRect;

		[Cpp2IlInjected.Token(Token = "0x6001480")]
		[Cpp2IlInjected.Address(RVA = "0x1070AD0", Offset = "0x106F4D0", VA = "0x181070AD0")]
		public void OnEnable()
		{
			//IL_001f: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			Texture2D value = terrainLUT;
			Shader.SetGlobalTexture("_TerrainLUT", value);
			int num = 0;
			Shader.SetGlobalVector("_TerrainLUTScaleOffset", (Vector4)num);
			Vector4 vector = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001481")]
		[Cpp2IlInjected.Address(RVA = "0x1070990", Offset = "0x106F390", VA = "0x181070990")]
		public (int, int) GetTerrainIndices(Vector3 worldPosition)
		{
			float z = worldPosition.z;
			int num = 0;
			int num2 = 0;
			TerrainRect[] array = terrainRects;
			int num3 = 0;
			int length = array.Length;
			bool flag = default(bool);
			if (num < length && !flag)
			{
				num3++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001482")]
		[Cpp2IlInjected.Address(RVA = "0x1070C20", Offset = "0x106F620", VA = "0x181070C20")]
		public TerrainManager()
		{
		}
	}
}
