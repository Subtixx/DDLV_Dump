using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000488")]
	[CreateAssetMenu]
	public class GridTilesetDef : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CB3")]
		public GameObject[] Tiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CB4")]
		public GameObject TileTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CB5")]
		public int TileSize = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001CB6")]
		public Material material;

		[Cpp2IlInjected.Token(Token = "0x6001418")]
		[Cpp2IlInjected.Address(RVA = "0x1543200", Offset = "0x1541C00", VA = "0x181543200")]
		public GameObject GetTile(int index, Transform transform)
		{
			//IL_0010: Expected O, but got I4
			GameObject tileTemplate = TileTemplate;
			int num = 0;
			if (!(tileTemplate == (UnityEngine.Object)num))
			{
				int num2 = 0;
			}
			GameObject original = Tiles[index];
			int worldPositionStays = 0;
			GameObject gameObject = UnityEngine.Object.Instantiate(original, transform, (byte)worldPositionStays != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001419")]
		[Cpp2IlInjected.Address(RVA = "0x15432F0", Offset = "0x1541CF0", VA = "0x1815432F0")]
		public GridTilesetDef()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
