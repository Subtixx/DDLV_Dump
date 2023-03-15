using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A53")]
	public class AssetReferenceTexture : AssetReferenceT<Texture2D>
	{
		[Cpp2IlInjected.Token(Token = "0x6003023")]
		[Cpp2IlInjected.Address(RVA = "0xA45830", Offset = "0xA44230", VA = "0x180A45830")]
		public AssetReferenceTexture(string guid)
		{
			((AssetReferenceT<TObject>)(object)this)._002Ector(guid);
		}
	}
}
