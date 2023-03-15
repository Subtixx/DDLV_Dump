using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000856")]
	[RequiredAllNotNull]
	[RequireComponent(typeof(RectTransform))]
	public class ProgressHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030F2")]
		public bool IsVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030F3")]
		public RectTransform Container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030F4")]
		public RectTransform Progress;

		[Cpp2IlInjected.Token(Token = "0x60034C3")]
		[Cpp2IlInjected.Address(RVA = "0xE1EA50", Offset = "0xE1D450", VA = "0x180E1EA50")]
		public void Refresh(GameObject progressProvider)
		{
			//Discarded unreachable code: IL_004c
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!(progressProvider == (Object)num) && flag)
			{
				Vector2 sizeDelta = Progress.sizeDelta;
				RectTransform container = Container;
				if (!IsVertical)
				{
					Vector2 sizeDelta2 = container.sizeDelta;
				}
				Vector2 sizeDelta3 = container.sizeDelta;
				Progress.sizeDelta = sizeDelta;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034C4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ProgressHelper()
		{
		}
	}
}
