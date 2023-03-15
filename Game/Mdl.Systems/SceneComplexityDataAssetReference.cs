using System;
using Cpp2IlInjected;
using UnityEngine.AddressableAssets;

namespace Mdl.Systems
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000965")]
	public class SceneComplexityDataAssetReference : AssetReferenceT<SceneComplexityData>
	{
		[Cpp2IlInjected.Token(Token = "0x6002BA4")]
		[Cpp2IlInjected.Address(RVA = "0xCC9470", Offset = "0xCC7E70", VA = "0x180CC9470")]
		public SceneComplexityDataAssetReference(string guid)
		{
			((AssetReferenceT<TObject>)(object)this)._002Ector(guid);
		}
	}
}
