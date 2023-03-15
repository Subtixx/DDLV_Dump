using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class DraggedReferenceItem : PopupBase, IDragHandler, IEventSystemHandler, IEndDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private UnityEngine.Object m_reference;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public UnityEngine.Object Reference
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return m_reference;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xF18A40", Offset = "0xF17440", VA = "0x180F18A40")]
		public void SetContent(UnityEngine.Object reference, PointerEventData draggingPointer)
		{
			//Discarded unreachable code: IL_003c
			//IL_0017: Expected O, but got I4
			m_reference = reference;
			Text text = label;
			int num = 0;
			string text2 = (text.text = reference.GetNameWithType((Type)num));
			GameObject gameObject = (draggingPointer.pointerDrag = base.gameObject);
			draggingPointer.dragging = true;
			SetPointer(draggingPointer);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xF18940", Offset = "0xF17340", VA = "0x180F18940", Slot = "4")]
		protected override void DestroySelf()
		{
			RuntimeInspectorUtils.PoolDraggedReferenceItem(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xF189A0", Offset = "0xF173A0", VA = "0x180F189A0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_001d
			int _003CpointerId_003Ek__BackingField = pointer.pointerId;
			if (eventData.pointerId == _003CpointerId_003Ek__BackingField)
			{
				RepositionSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xF189E0", Offset = "0xF173E0", VA = "0x180F189E0", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			RuntimeInspectorUtils.PoolDraggedReferenceItem(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public DraggedReferenceItem()
		{
		}
	}
}
