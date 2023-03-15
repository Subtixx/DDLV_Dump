using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000743")]
	internal class DestroyOnEnable : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A10")]
		private bool activated;

		[Cpp2IlInjected.Token(Token = "0x6002056")]
		[Cpp2IlInjected.Address(RVA = "0x16260D0", Offset = "0x1624AD0", VA = "0x1816260D0")]
		private void OnEnable()
		{
			if (activated && !Addressables.ReleaseInstance(base.gameObject))
			{
				Object.Destroy(base.gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002057")]
		[Cpp2IlInjected.Address(RVA = "0x16260C0", Offset = "0x1624AC0", VA = "0x1816260C0")]
		private void OnDisable()
		{
			activated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002058")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DestroyOnEnable()
		{
		}
	}
}
