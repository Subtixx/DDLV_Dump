using Cpp2IlInjected;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000849")]
	public interface IHasTextureReference
	{
		[Cpp2IlInjected.Token(Token = "0x6003499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AssetReferenceTexture GetReference(SpriteType spriteType);
	}
}
