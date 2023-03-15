using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class DraggedReferenceSourceUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		[SerializeField]
		private UnityEngine.Object m_reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		[SerializeField]
		private UISkin draggedReferenceSkin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		[SerializeField]
		private float holdTime = 0.4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private IEnumerator pointerHeldCoroutine;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public UnityEngine.Object Reference
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return m_reference;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				m_reference = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xF19820", Offset = "0xF18220", VA = "0x180F19820", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0047
			if ((long)pointerHeldCoroutine == 0 && (bool)m_reference)
			{
				int _003C_003E1__state = default(int);
				_003CCreateReferenceItemCoroutine_003Ed__10 _003CCreateReferenceItemCoroutine_003Ed__ = new _003CCreateReferenceItemCoroutine_003Ed__10(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CCreateReferenceItemCoroutine_003Ed__._003C_003E4__this = this;
				_003CCreateReferenceItemCoroutine_003Ed__.eventData = eventData;
				pointerHeldCoroutine = _003CCreateReferenceItemCoroutine_003Ed__;
				IEnumerator routine = pointerHeldCoroutine;
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xF197E0", Offset = "0xF181E0", VA = "0x180F197E0", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
			IEnumerator enumerator = pointerHeldCoroutine;
			if (enumerator != null)
			{
				StopCoroutine(enumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xF197E0", Offset = "0xF181E0", VA = "0x180F197E0", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			IEnumerator enumerator = pointerHeldCoroutine;
			if (enumerator != null)
			{
				StopCoroutine(enumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xF19750", Offset = "0xF18150", VA = "0x180F19750")]
		[IteratorStateMachine(typeof(_003CCreateReferenceItemCoroutine_003Ed__10))]
		private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData)
		{
			int _003C_003E1__state = default(int);
			_003CCreateReferenceItemCoroutine_003Ed__10 _003CCreateReferenceItemCoroutine_003Ed__ = new _003CCreateReferenceItemCoroutine_003Ed__10(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCreateReferenceItemCoroutine_003Ed__._003C_003E4__this = this;
			_003CCreateReferenceItemCoroutine_003Ed__.eventData = eventData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xF19930", Offset = "0xF18330", VA = "0x180F19930")]
		public DraggedReferenceSourceUI()
		{
		}
	}
}
