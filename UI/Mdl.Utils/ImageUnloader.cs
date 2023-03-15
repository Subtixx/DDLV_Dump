using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	public sealed class ImageUnloader : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x1312740", Offset = "0x1311140", VA = "0x181312740")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0021
			//IL_001f: Expected O, but got I4
			Image component = base.gameObject.GetComponent<Image>();
			if ((object)component != null)
			{
				Object.Destroy(component);
				int num = 0;
				component.sprite = (Sprite)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ImageUnloader()
		{
		}
	}
}
