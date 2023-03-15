using Cpp2IlInjected;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000791")]
	public class OpenMenuPlayerTaskData : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B4C")]
		public AssetReference menuToOpen;

		[Cpp2IlInjected.Token(Token = "0x600219A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
		public virtual object[] GetParameters()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600219B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public OpenMenuPlayerTaskData()
		{
		}
	}
}
