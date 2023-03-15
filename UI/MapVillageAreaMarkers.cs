using System;
using Cpp2IlInjected;
using Definitions.Scene;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000044")]
public class MapVillageAreaMarkers : MonoBehaviour
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct MapVillageAreaMarker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public VillageAreaType AreaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public GameObject Image;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[SerializeField]
	private MapVillageAreaMarker[] _areaMarkers;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x118AB50", Offset = "0x1189550", VA = "0x18118AB50")]
	public void ShowAreaMarker(VillageAreaType biome)
	{
		//Discarded unreachable code: IL_001d
		Func<MapVillageAreaMarker, bool> func = (Func<MapVillageAreaMarker, bool>)(object)(Func<T, TResult>)delegate
		{
			VillageAreaType villageAreaType = biome;
			bool result = default(bool);
			return result;
		};
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public MapVillageAreaMarkers()
	{
	}
}
