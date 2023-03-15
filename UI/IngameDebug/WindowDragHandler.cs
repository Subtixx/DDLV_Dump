using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public class WindowDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private const int NON_EXISTING_TOUCH = -98456;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private int pointerId = -98456;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private Vector2 initialTouchPos;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E9260", Offset = "0x8E7C60", VA = "0x1808E9260")]
		private void Awake()
		{
			//IL_0018: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform == null || (object)transform != null)
			{
				rectTransform = (RectTransform)num;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x8E92D0", Offset = "0x8E7CD0", VA = "0x1808E92D0", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (pointerId == -98456)
			{
				int num = (pointerId = eventData.pointerId);
				Vector2 _003Cposition_003Ek__BackingField = eventData.position;
				float y = eventData.position.y;
				RectTransform rectTransform = this.rectTransform;
				Camera pressEventCamera = eventData.pressEventCamera;
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E93C0", Offset = "0x8E7DC0", VA = "0x1808E93C0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0051
			//IL_0050: Expected O, but got I4
			int num = pointerId;
			if (eventData.pointerId == num)
			{
				Vector2 _003Cposition_003Ek__BackingField = eventData.position;
				float y = eventData.position.y;
				RectTransform rectTransform = this.rectTransform;
				Camera pressEventCamera = eventData.pressEventCamera;
				RectTransform rectTransform2 = this.rectTransform;
				int num2 = 0;
				Vector2 anchoredPosition = rectTransform2.anchoredPosition;
				rectTransform2.anchoredPosition = (Vector2)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x8E94F0", Offset = "0x8E7EF0", VA = "0x1808E94F0", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0021
			//IL_0020: Expected I4, but got I8
			int num = pointerId;
			if (eventData.pointerId == num)
			{
				pointerId = -98456;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x8E9520", Offset = "0x8E7F20", VA = "0x1808E9520")]
		public WindowDragHandler()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
