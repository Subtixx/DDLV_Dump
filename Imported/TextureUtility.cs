using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200003F")]
public class TextureUtility : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static Dictionary<string, Texture> loadedTextures;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DC30F0", Offset = "0x3DC1AF0", VA = "0x183DC30F0")]
	public static Texture LoadTexture(string name)
	{
		//Discarded unreachable code: IL_000c, IL_0010, IL_0019, IL_0021, IL_002b, IL_002d
		Dictionary<string, Texture> dictionary = (Dictionary<string, Texture>)(object)new Dictionary<TKey, TValue>();
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public TextureUtility()
	{
	}
}
