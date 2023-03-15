using System;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public struct NonVillageLocation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		[ItemID]
		public int SceneID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public AssetReferenceTexture AssetReferenceTexture;
	}
}
