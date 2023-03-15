using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class DebugsOnScrollListener : MonoBehaviour, IScrollHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public ScrollRect debugsScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public DebugLogManager debugLogManager;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x15570E0", Offset = "0x1555AE0", VA = "0x1815570E0", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
			//Discarded unreachable code: IL_0014, IL_001c
			float verticalNormalizedPosition = debugsScrollRect.verticalNormalizedPosition;
			DebugLogManager debugLogManager = this.debugLogManager;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x15570C0", Offset = "0x1555AC0", VA = "0x1815570C0", Slot = "5")]
		public void OnBeginDrag(PointerEventData data)
		{
			//Discarded unreachable code: IL_000d
			debugLogManager.snapToBottom = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x15570E0", Offset = "0x1555AE0", VA = "0x1815570E0", Slot = "6")]
		public void OnEndDrag(PointerEventData data)
		{
			//Discarded unreachable code: IL_0014, IL_001c
			float verticalNormalizedPosition = debugsScrollRect.verticalNormalizedPosition;
			DebugLogManager debugLogManager = this.debugLogManager;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x15570C0", Offset = "0x1555AC0", VA = "0x1815570C0")]
		public void OnScrollbarDragStart(BaseEventData data)
		{
			//Discarded unreachable code: IL_000d
			debugLogManager.snapToBottom = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x15570E0", Offset = "0x1555AE0", VA = "0x1815570E0")]
		public void OnScrollbarDragEnd(BaseEventData data)
		{
			//Discarded unreachable code: IL_0014, IL_001c
			float verticalNormalizedPosition = debugsScrollRect.verticalNormalizedPosition;
			DebugLogManager debugLogManager = this.debugLogManager;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1557090", Offset = "0x1555A90", VA = "0x181557090")]
		private bool IsScrollbarAtBottom()
		{
			float verticalNormalizedPosition = debugsScrollRect.verticalNormalizedPosition;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugsOnScrollListener()
		{
		}
	}
}
