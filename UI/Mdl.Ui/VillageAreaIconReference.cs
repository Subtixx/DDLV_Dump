using System;
using Cpp2IlInjected;
using Definitions.Scene;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	public struct VillageAreaIconReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public VillageAreaType Key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public AssetReferenceTexture AssetReferenceTexture;
	}
}
