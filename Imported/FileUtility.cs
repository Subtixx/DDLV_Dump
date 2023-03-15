using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FileUtility
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Dictionary<string, Texture> loadedTextures;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Dictionary<string, object> loadedFiles;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2F11130", Offset = "0x2F0FB30", VA = "0x182F11130")]
	public static Texture LoadTexture(string name)
	{
		//Discarded unreachable code: IL_0024, IL_0028, IL_0034, IL_003f, IL_004e, IL_005c
		//IL_0059: Expected O, but got I4
		if (!string.Equals(name, ""))
		{
			loadedTextures = (Dictionary<string, Texture>)(object)new Dictionary<TKey, TValue>();
			Dictionary<string, Texture> dictionary = loadedTextures;
			throw new NullReferenceException();
		}
		int num = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2F10F50", Offset = "0x2F0F950", VA = "0x182F10F50")]
	public static object LoadFile(string name)
	{
		//Discarded unreachable code: IL_0016, IL_001a, IL_002d, IL_003b, IL_004b, IL_0057
		loadedTextures = (Dictionary<string, Texture>)(object)new Dictionary<TKey, TValue>();
		Dictionary<string, object> dictionary = loadedFiles;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	public static void OpenFileWithDefaultApplication(string name)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
