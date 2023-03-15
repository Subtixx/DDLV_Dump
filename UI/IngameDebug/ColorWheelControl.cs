using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ColorWheelControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public delegate void OnColorChangedDelegate(Color32 color);

		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private const float RGB_CONST = 2f / (float)Math.PI;

		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private const float G_CONST = (float)Math.PI * 2f / 3f;

		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private const float B_CONST = 4.1887903f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private Color m_color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		[SerializeField]
		private RectTransform SelectorOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		[SerializeField]
		private RectTransform SelectorIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		[SerializeField]
		private WindowDragHandler colorPickerWindow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private float outer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Vector2 inner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private bool draggingOuter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private bool draggingInner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private float halfSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private float halfSizeSqr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private float outerCirclePaddingSqr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private float innerSquareHalfSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private int pointerId = -98765;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public unsafe Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x14A23A0", Offset = "0x14A0DA0", VA = "0x1814A23A0")]
			private set
			{
				//IL_0019: Expected native int or pointer, but got O
				Color color = m_color;
				bool flag = default(bool);
				if (flag)
				{
					float a = Alpha;
					((Color*)(IntPtr)m_color)->a = a;
					if (this.OnColorChanged != null)
					{
						Color32 color2 = m_color;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000285")]
		public float Alpha
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnColorChangedDelegate OnColorChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x14A2260", Offset = "0x14A0C60", VA = "0x1814A2260")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x14A2300", Offset = "0x14A0D00", VA = "0x1814A2300")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x14A15E0", Offset = "0x149FFE0", VA = "0x1814A15E0")]
		private void Awake()
		{
			//IL_0018: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform == null || (object)transform != null)
			{
				rectTransform = (RectTransform)num;
				Image component = GetComponent<Image>();
				Material material = (mat = new Material(component.material));
				Material material3 = (component.material = mat);
				UpdateProperties();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x14A1C90", Offset = "0x14A0690", VA = "0x1814A1C90")]
		private void OnRectTransformDimensionsChange()
		{
			//Discarded unreachable code: IL_0068
			//IL_0010: Expected O, but got I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected F4, but got Unknown
			RectTransform rectTransform = this.rectTransform;
			int num = 0;
			if (!(rectTransform == (UnityEngine.Object)num))
			{
				RectTransform rectTransform2 = this.rectTransform;
				Rect rect = default(Rect);
				float num2 = (halfSize = rect * 0.5f);
				float num3 = num2 * 0.5f;
				halfSizeSqr = num2;
				float num4 = num2 * 0.75f;
				innerSquareHalfSize = num3;
				float num5 = (outerCirclePaddingSqr = num4 * 0.75f);
				UpdateSelectors();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x14A2110", Offset = "0x14A0B10", VA = "0x1814A2110")]
		private void UpdateProperties()
		{
			//Discarded unreachable code: IL_0048
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected F4, but got Unknown
			RectTransform rectTransform = this.rectTransform;
			Rect rect = default(Rect);
			float num = (halfSize = rect * 0.5f);
			float num2 = num * 0.5f;
			halfSizeSqr = num;
			float num3 = num * 0.75f;
			innerSquareHalfSize = num2;
			float num4 = (outerCirclePaddingSqr = num3 * 0.75f);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x14A1D80", Offset = "0x14A0780", VA = "0x1814A1D80")]
		public unsafe void PickColor(Color c)
		{
			//Discarded unreachable code: IL_00aa
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected F4, but got Unknown
			//IL_002c: Expected O, but got F4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected F4, but got Unknown
			//IL_0040: Expected O, but got F4
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected F4, but got Unknown
			//IL_0086: Expected native int or pointer, but got O
			float num = (Alpha = c.a);
			ulong num2 = default(ulong);
			float num3 = (outer = num2 * 2f * (float)Math.PI);
			float num4 = ((ColorWheelControl)num3).halfSize;
			float num5 = /*Error near IL_002d: Stack underflow*/* num4 * 0.85f;
			num5 = num3;
			float num6 = ((ColorWheelControl)num5).halfSize;
			float num7 = /*Error near IL_0041: Stack underflow*/* num6 * 0.85f;
			RectTransform selectorOut = SelectorOut;
			float num8 = halfSize;
			num7 = innerSquareHalfSize;
			RectTransform selectorIn = SelectorIn;
			Color color = m_color;
			bool flag = default(bool);
			if (flag)
			{
				float a = Alpha;
				((Color*)(IntPtr)m_color)->a = a;
				if (this.OnColorChanged != null)
				{
					Color32 color2 = m_color;
				}
			}
			Material material = mat;
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x14A1A70", Offset = "0x14A0470", VA = "0x1814A1A70", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0056
			RectTransform rectTransform = this.rectTransform;
			Vector2 _003Cposition_003Ek__BackingField = eventData.position;
			float y = eventData.position.y;
			Camera pressEventCamera = eventData.pressEventCamera;
			bool flag = default(bool);
			if (flag)
			{
				float num = halfSizeSqr;
				draggingOuter = true;
				float num2 = innerSquareHalfSize;
				draggingInner = true;
				int num3 = (pointerId = eventData.pointerId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x14A1950", Offset = "0x14A0350", VA = "0x1814A1950", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_004a
			int _003CpointerId_003Ek__BackingField = eventData.pointerId;
			if (pointerId == _003CpointerId_003Ek__BackingField)
			{
				Vector2 _003Cposition_003Ek__BackingField = eventData.position;
				float y = eventData.position.y;
				RectTransform rectTransform = this.rectTransform;
				Camera pressEventCamera = eventData.pressEventCamera;
			}
			else
			{
				GameObject gameObject = colorPickerWindow.gameObject;
				WindowDragHandler windowDragHandler = colorPickerWindow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x14A1BA0", Offset = "0x14A05A0", VA = "0x1814A1BA0", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_004b
			//IL_004a: Expected I4, but got I8
			int _003CpointerId_003Ek__BackingField = eventData.pointerId;
			if (pointerId == _003CpointerId_003Ek__BackingField)
			{
				Vector2 _003Cposition_003Ek__BackingField = eventData.position;
				float y = eventData.position.y;
				RectTransform rectTransform = this.rectTransform;
				Camera pressEventCamera = eventData.pressEventCamera;
				draggingOuter = false;
				pointerId = -98765;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x14A1820", Offset = "0x14A0220", VA = "0x1814A1820")]
		private unsafe void GetSelectedColor(Vector2 pointerPos)
		{
			//IL_0034: Expected O, but got F4
			//IL_003b: Expected native int or pointer, but got O
			//IL_0055: Expected F4, but got O
			if (!draggingOuter)
			{
				if (draggingInner)
				{
					float num = innerSquareHalfSize;
					float num2 = innerSquareHalfSize;
					num = num2;
					num = num2;
					float value = default(float);
					float y = Mathf.Clamp(value, num, num);
					inner = (Vector2)num2;
					((Vector2*)(IntPtr)inner)->y = y;
					UpdateColor();
					UpdateSelectors();
					return;
				}
			}
			else
			{
				Vector2 vector = default(Vector2);
				outer = (float)vector;
				UpdateColor();
			}
			UpdateSelectors();
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x14A1FA0", Offset = "0x14A09A0", VA = "0x1814A1FA0")]
		private unsafe void UpdateColor()
		{
			//Discarded unreachable code: IL_004f
			//IL_0033: Expected native int or pointer, but got O
			Material material = mat;
			Color white = Color.white;
			int num = 0;
			Color black = Color.black;
			Color color = m_color;
			bool flag = default(bool);
			if (flag)
			{
				float a = Alpha;
				((Color*)(IntPtr)m_color)->a = a;
				if (this.OnColorChanged != null)
				{
					Color32 color2 = m_color;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x14A1710", Offset = "0x14A0110", VA = "0x1814A1710")]
		private Color GetCurrentBaseColor()
		{
			//IL_001c: Expected F4, but got I4
			//IL_0035: Expected F4, but got I4
			//IL_004e: Expected F4, but got I4
			int num = 0;
			Color white = Color.white;
			int num2 = 0;
			float num3 = default(float);
			float num4 = Mathf.Clamp(num3 * 1.5f, num2, 1f);
			int num5 = 0;
			float num6 = default(float);
			float num7 = Mathf.Clamp(num6 * 1.5f, num5, 1f);
			int num8 = 0;
			float num9 = default(float);
			float num10 = Mathf.Clamp(num9 * 1.5f, num8, 1f);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x14A21A0", Offset = "0x14A0BA0", VA = "0x1814A21A0")]
		private void UpdateSelectors()
		{
			//Discarded unreachable code: IL_0044
			//IL_000b: Expected O, but got F4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected F4, but got Unknown
			//IL_001e: Expected O, but got F4
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected F4, but got Unknown
			float num = ((ColorWheelControl)outer).halfSize;
			float num2 = /*Error near IL_000c: Stack underflow*/* num * 0.85f;
			float num3 = ((ColorWheelControl)outer).halfSize;
			float num4 = /*Error near IL_001f: Stack underflow*/* num3 * 0.85f;
			RectTransform selectorOut = SelectorOut;
			float num5 = halfSize;
			num4 = innerSquareHalfSize;
			RectTransform selectorIn = SelectorIn;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x14A2250", Offset = "0x14A0C50", VA = "0x1814A2250")]
		public ColorWheelControl()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
