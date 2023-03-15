using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x2000559")]
	[CreateAssetMenu]
	internal class FurnitureIconList : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200055A")]
		public struct IconPair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400214F")]
			[Tooltip("Icon used for the signpost in-game")]
			public AssetReferenceTexture2D InGameIcon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002150")]
			[Tooltip("Icon used for the signpost icon selector UI")]
			public AssetReferenceTexture2D UIIcon;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400214E")]
		[FurnitureIconListLabels]
		public IconPair[] IconPairs;

		[Cpp2IlInjected.Token(Token = "0x60017FD")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public FurnitureIconList()
		{
		}
	}
}
