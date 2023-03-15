using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class DebugColorPickerAlphaSlider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		public delegate void OnValueChangedDelegate(float alpha);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		[SerializeField]
		private Image alphaImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		[SerializeField]
		private RectTransform selector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private float m_value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public OnValueChangedDelegate OnValueChanged;

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get
			{
				return m_value;
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x1129490", Offset = "0x1127E90", VA = "0x181129490")]
			set
			{
				//Discarded unreachable code: IL_001d
				m_value = value;
				RectTransform rectTransform = selector;
				RectTransform rectTransform2 = selector;
				float value2 = m_value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public unsafe Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x1129410", Offset = "0x1127E10", VA = "0x181129410")]
			get
			{
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x1129450", Offset = "0x1127E50", VA = "0x181129450")]
			set
			{
				//Discarded unreachable code: IL_0013
				//IL_000d: Expected native int or pointer, but got O
				Image image = alphaImage;
				((Color*)(IntPtr)value)->a = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1129230", Offset = "0x1127C30", VA = "0x181129230")]
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

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x11292A0", Offset = "0x1127CA0", VA = "0x1811292A0", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_006d
			//IL_003e: Expected F4, but got I8
			RectTransform rectTransform = this.rectTransform;
			Vector2 _003Cposition_003Ek__BackingField = eventData.position;
			float y = eventData.position.y;
			Camera pressEventCamera = eventData.pressEventCamera;
			Vector2 sizeDelta = this.rectTransform.sizeDelta;
			RectTransform rectTransform2 = selector;
			ulong num = default(ulong);
			m_value = (long)num;
			RectTransform rectTransform3 = selector;
			float value = m_value;
			OnValueChangedDelegate onValueChanged = OnValueChanged;
			if (onValueChanged != null)
			{
				float value2 = m_value;
				onValueChanged(value2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x11292A0", Offset = "0x1127CA0", VA = "0x1811292A0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_006d
			//IL_003e: Expected F4, but got I8
			RectTransform rectTransform = this.rectTransform;
			Vector2 _003Cposition_003Ek__BackingField = eventData.position;
			float y = eventData.position.y;
			Camera pressEventCamera = eventData.pressEventCamera;
			Vector2 sizeDelta = this.rectTransform.sizeDelta;
			RectTransform rectTransform2 = selector;
			ulong num = default(ulong);
			m_value = (long)num;
			RectTransform rectTransform3 = selector;
			float value = m_value;
			OnValueChangedDelegate onValueChanged = OnValueChanged;
			if (onValueChanged != null)
			{
				float value2 = m_value;
				onValueChanged(value2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugColorPickerAlphaSlider()
		{
		}
	}
}
