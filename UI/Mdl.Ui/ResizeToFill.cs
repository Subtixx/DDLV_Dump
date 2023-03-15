using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	public class ResizeToFill : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		public Canvas canvas;

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0xE325F0", Offset = "0xE30FF0", VA = "0x180E325F0")]
		private void Start()
		{
			//Discarded unreachable code: IL_001f
			//IL_001e: Expected O, but got I4
			RectTransform component = GetComponent<RectTransform>();
			RectTransform component2 = canvas.GetComponent<RectTransform>();
			int num = 0;
			component.sizeDelta = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ResizeToFill()
		{
		}
	}
}
