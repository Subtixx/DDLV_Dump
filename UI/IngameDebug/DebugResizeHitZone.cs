using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class DebugResizeHitZone : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		[SerializeField]
		private RectTransform container;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1552B90", Offset = "0x1551590", VA = "0x181552B90")]
		public void Resize(BaseEventData dat)
		{
			//Discarded unreachable code: IL_002d
			int num = 0;
			if (dat != null)
			{
				RectTransform rectTransform = container;
				RectTransform rectTransform2 = container;
				RectTransform rectTransform3 = container;
				RectTransform rectTransform4 = container;
				RectTransform rectTransform5 = container;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugResizeHitZone()
		{
		}
	}
}
