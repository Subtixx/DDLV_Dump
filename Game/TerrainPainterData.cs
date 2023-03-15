using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000B4")]
[CreateAssetMenu]
public class TerrainPainterData : ScriptableObject
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class TextureEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public Texture2D tex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public float tiling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public Color borderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public float borderColorMultiplier;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TextureEntry()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public TextureEntry[] firstLayerTextures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public TextureEntry[] secondLayerTextures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public TextureEntry[] playerLayerTextures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	[HideInInspector]
	public Texture2DArray firstLayerTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	[HideInInspector]
	public Texture2DArray playerLayerTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	[HideInInspector]
	public Texture2D firstLayerTilesAtlas;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	[HideInInspector]
	public Texture2D playerLayerTilesAtlas;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public RenderTexture splatControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public RenderTexture splatControlIndex;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1070C80", Offset = "0x106F680", VA = "0x181070C80")]
	private Texture2DArray CreateTextureArray(TextureEntry[] tex2DList)
	{
		//IL_0024: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		int num = 0;
		if (tex2DList.Length != 0)
		{
			Texture2D tex = tex2DList[0].tex;
			int num2 = 0;
			if (tex != (UnityEngine.Object)num2)
			{
				int width = tex2DList[0].tex.width;
				int height = tex2DList[0].tex.height;
				int format = (int)tex2DList[0].tex.format;
				Texture2DArray texture2DArray = default(Texture2DArray);
				texture2DArray.filterMode = FilterMode.Bilinear;
				int num3 = (int)(texture2DArray.wrapMode = TextureWrapMode.Repeat);
				int length = tex2DList.Length;
				if (num < length)
				{
					Texture2D tex2 = tex2DList[num].tex;
					int num4 = 0;
					if (tex2 != (UnityEngine.Object)num4)
					{
						int mipmapCount = tex2DList[num].tex.mipmapCount;
						if (num < mipmapCount)
						{
							Texture2D tex3 = tex2DList[num].tex;
							int srcElement = 0;
							Graphics.CopyTexture(tex3, srcElement, num, texture2DArray, num, num);
							num++;
						}
					}
					num++;
				}
			}
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x1070FC0", Offset = "0x106F9C0", VA = "0x181070FC0")]
	public void CreateTextureArrays(int RTSize)
	{
		//Discarded unreachable code: IL_00a5
		//IL_0010: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		RenderTexture renderTexture = splatControlIndex;
		int num = 0;
		if (renderTexture != (UnityEngine.Object)num)
		{
			UnityEngine.Object.Destroy(splatControlIndex);
		}
		int format = default(int);
		int depth = default(int);
		RenderTexture renderTexture2 = new RenderTexture(RTSize, RTSize, depth, (RenderTextureFormat)format);
		format = 0;
		depth = 0;
		splatControlIndex = renderTexture2;
		splatControlIndex.name = "splatControlRTIndex";
		RenderTexture renderTexture3 = splatControl;
		int num2 = 0;
		if (renderTexture3 != (UnityEngine.Object)num2)
		{
			UnityEngine.Object.Destroy(splatControl);
		}
		int depth2 = default(int);
		RenderTexture renderTexture4 = new RenderTexture(RTSize, RTSize, depth2, (RenderTextureFormat)format);
		depth2 = 0;
		splatControl = renderTexture4;
		splatControl.name = "splatControlRT";
		int num3 = 0;
		RenderTexture.SetActive(splatControlIndex);
		RenderTexture renderTexture5 = splatControl;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x10712B0", Offset = "0x106FCB0", VA = "0x1810712B0")]
	private void CreateTextureAtlas(TextureEntry[] tex2DList, ref Texture2D text2D, string name, string path, int size)
	{
		//IL_0022: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		TextureFormat format3;
		int width2;
		if (tex2DList.Length != 0)
		{
			Texture2D tex = tex2DList[0].tex;
			int num = 0;
			if (tex != (UnityEngine.Object)num)
			{
				int width = tex2DList[0].tex.width;
				bool flag = default(bool);
				if (flag)
				{
					TextureFormat format = tex2DList[0].tex.format;
				}
				width2 = tex2DList[0].tex.width;
				TextureFormat format2 = tex2DList[0].tex.format;
				string text = ((Enum)format2).ToString();
				TextureFormat textureFormat = format2;
				string text2 = "tex2DList[0].tex.format: " + text;
				string text3 = default(string);
				string text4 = "texPtr.Length: " + text3;
				format3 = tex2DList[0].tex.format;
				if (format3 <= TextureFormat.DXT1Crunched)
				{
					goto IL_00cb;
				}
				if (format3 != TextureFormat.DXT5Crunched)
				{
					if (format3 == TextureFormat.ETC_RGB4)
					{
						goto IL_00dd;
					}
					if (format3 != TextureFormat.ETC2_RGBA8)
					{
						goto IL_00cb;
					}
				}
				goto IL_00d7;
			}
		}
		throw new NullReferenceException();
		IL_00dd:
		int length = tex2DList.Length;
		int num2 = 0;
		Texture2D tex2 = tex2DList[0].tex;
		int num3 = 0;
		int mipmapCount = tex2.mipmapCount;
		if (num2 >= mipmapCount)
		{
			return;
		}
		int num4 = 0;
		int length2 = tex2DList.Length;
		if (num4 < length2)
		{
			Texture2D tex3 = tex2DList[num4].tex;
			int num5 = 0;
			if (tex3 != (UnityEngine.Object)num5)
			{
				int num6 = num5 * width2;
				int num7 = num4 * width2;
				Texture2D tex4 = tex2DList[num4].tex;
				if (width2 > 0)
				{
					uint num8 = default(uint);
					int num9 = width2 * (int)num8;
					num7 += (int)num8;
					ulong num10 = num10 + (ulong)num9;
					while (width2 != 0)
					{
					}
				}
			}
			num4++;
		}
		width2 -= num3;
		int num11 = width2 * width2;
		ulong num12 = num12 + 1;
		return;
		IL_00d7:
		if (format3 == TextureFormat.DXT1Crunched)
		{
		}
		goto IL_00dd;
		IL_00cb:
		if (format3 != TextureFormat.DXT1)
		{
			if (format3 != TextureFormat.DXT5)
			{
			}
			goto IL_00d7;
		}
		goto IL_00dd;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
	public TerrainPainterData()
	{
	}
}
