using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000045")]
public class StreamableGridObjectDatabase
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static StreamableGridObjectDatabase _instance = (StreamableGridObjectDatabase)(object)"streamableGridObj.bin";

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static readonly string PlayerDatabaseFilename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private HashSet<int> _streamableItemIds = (HashSet<int>)(object)new HashSet<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private HashSet<int> _nonStreamableWithCarving = (HashSet<int>)(object)new HashSet<T>();

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static StreamableGridObjectDatabase Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1063DE0", Offset = "0x10627E0", VA = "0x181063DE0")]
		get
		{
			//Discarded unreachable code: IL_002c
			StreamableGridObjectDatabase streamableGridObjectDatabase = new StreamableGridObjectDatabase();
			HashSet<int> hashSet = (streamableGridObjectDatabase._streamableItemIds = (HashSet<int>)(object)new HashSet<T>());
			HashSet<int> hashSet2 = (streamableGridObjectDatabase._nonStreamableWithCarving = (HashSet<int>)(object)new HashSet<T>());
			_instance = streamableGridObjectDatabase;
			return _instance;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int SteamableCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1063FA0", Offset = "0x10629A0", VA = "0x181063FA0")]
		get
		{
			//Discarded unreachable code: IL_000c
			return ((HashSet<>)(object)_streamableItemIds)._count;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int NonSteamableWithCarvingCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1063F60", Offset = "0x1062960", VA = "0x181063F60")]
		get
		{
			//Discarded unreachable code: IL_000c
			return ((HashSet<>)(object)_nonStreamableWithCarving)._count;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1063430", Offset = "0x1061E30", VA = "0x181063430")]
	public bool IsStreamableItem(int itemID)
	{
		//Discarded unreachable code: IL_000d
		//IL_000c: Expected O, but got I4
		return ((HashSet<T>)(object)_streamableItemIds).Contains((T)itemID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1063320", Offset = "0x1061D20", VA = "0x181063320")]
	public void AddStreamableItem(int itemID)
	{
		//Discarded unreachable code: IL_000e
		//IL_000c: Expected O, but got I4
		bool flag = ((HashSet<T>)(object)_streamableItemIds).Add((T)itemID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x10633D0", Offset = "0x1061DD0", VA = "0x1810633D0")]
	public bool IsNonStreamableWithCarvingItem(int itemID)
	{
		//Discarded unreachable code: IL_000d
		//IL_000c: Expected O, but got I4
		return ((HashSet<T>)(object)_nonStreamableWithCarving).Contains((T)itemID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x10632C0", Offset = "0x1061CC0", VA = "0x1810632C0")]
	public void AddNonStreamableWithCarvingItem(int itemID)
	{
		//Discarded unreachable code: IL_000e
		//IL_000c: Expected O, but got I4
		bool flag = ((HashSet<T>)(object)_nonStreamableWithCarving).Add((T)itemID);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1063380", Offset = "0x1061D80", VA = "0x181063380")]
	public void ClearAll()
	{
		//Discarded unreachable code: IL_000c
		((HashSet<T>)(object)_streamableItemIds).Clear();
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1063800", Offset = "0x1062200", VA = "0x181063800")]
	public void Load()
	{
		//Discarded unreachable code: IL_0038, IL_00a9
		//IL_0082: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			num++;
		}
		IFileSystem _003CData_003Ek__BackingField2 = FileSystem.Data;
		string text = default(string);
		string message = "StreamableGridObjectDatabase " + text + " file not found";
		int num3 = 0;
		Debug.LogError(message);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1063750", Offset = "0x1062150", VA = "0x181063750")]
	public static void LoadHashSet(HashSet<int> dest, BinaryReader binReader)
	{
		//Discarded unreachable code: IL_0025
		//IL_001f: Expected O, but got I4
		((HashSet<T>)(object)dest).Clear();
		int num = binReader.ReadInt32();
		if (num > 0)
		{
			int num2 = binReader.ReadInt32();
			bool flag = ((HashSet<T>)(object)dest).Add((T)num2);
			while (num != 0)
			{
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1063490", Offset = "0x1061E90", VA = "0x181063490")]
	public void LoadFromByteArray(byte[] data)
	{
		//Discarded unreachable code: IL_0084, IL_008a, IL_0090
		//IL_003a: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		int num = 0;
		MemoryStream memoryStream = new MemoryStream(data);
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		HashSet<int> streamableItemIds = _streamableItemIds;
		((HashSet<T>)(object)streamableItemIds).Clear();
		int num2 = binaryReader.ReadInt32();
		if (num < num2)
		{
			int num3 = binaryReader.ReadInt32();
			bool flag = ((HashSet<T>)(object)streamableItemIds).Add((T)num3);
			num++;
		}
		HashSet<int> nonStreamableWithCarving = _nonStreamableWithCarving;
		((HashSet<T>)(object)nonStreamableWithCarving).Clear();
		int num4 = binaryReader.ReadInt32();
		if (num < num4)
		{
			int num5 = binaryReader.ReadInt32();
			bool flag2 = ((HashSet<T>)(object)nonStreamableWithCarving).Add((T)num5);
			num++;
		}
		num++;
		if (binaryReader != null)
		{
		}
		if (num != 0)
		{
		}
		if (memoryStream == null)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1063D30", Offset = "0x1062730", VA = "0x181063D30")]
	public StreamableGridObjectDatabase()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1063CD0", Offset = "0x10626D0", VA = "0x181063CD0")]
	static StreamableGridObjectDatabase()
	{
		/*Error: Unexpected end of block*/;
	}
}
