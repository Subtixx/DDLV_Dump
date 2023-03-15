using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000212")]
	public class MouseCursor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000922")]
		public UnityEvent OnMouseEnter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000923")]
		public UnityEvent OnMouseExit;

		[Cpp2IlInjected.Token(Token = "0x6000D11")]
		[Cpp2IlInjected.Address(RVA = "0x1295670", Offset = "0x1294070", VA = "0x181295670")]
		private void Update()
		{
			//Discarded unreachable code: IL_0012
			Transform transform = base.transform;
			int num = 0;
			Vector2 mousePosition = Input.mousePosition;
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D12")]
		[Cpp2IlInjected.Address(RVA = "0x1295650", Offset = "0x1294050", VA = "0x181295650")]
		internal void RefreshDisplay(bool isHovering)
		{
			if (!isHovering)
			{
			}
			OnMouseEnter?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D13")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MouseCursor()
		{
		}
	}
}
