using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public enum AxisOption
		{
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			Both,
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			OnlyHorizontal,
			[Cpp2IlInjected.Token(Token = "0x400027D")]
			OnlyVertical
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public enum ControlStyle
		{
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			Absolute,
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			Relative,
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			Swipe
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public AxisOption axesToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public ControlStyle controlStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public string horizontalAxisName = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public string verticalAxisName = "Vertical";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public float Xsensitivity = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public float Ysensitivity = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private Vector3 m_StartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private Vector2 m_PreviousDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private Vector3 m_JoytickOutput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private bool m_UseX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private bool m_UseY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private bool m_Dragging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private int m_Id = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private Vector2 m_PreviousTouchPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private Vector3 m_Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private Image m_Image;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3AC0", Offset = "0x3DC24C0", VA = "0x183DC3AC0")]
		private void OnEnable()
		{
			bool flag;
			bool useY = default(bool);
			do
			{
				AxisOption axisOption = axesToUse;
				if (axisOption == AxisOption.Both)
				{
				}
				flag = (m_UseX = axisOption == AxisOption.OnlyHorizontal);
				if (axisOption != 0)
				{
					useY = axisOption == AxisOption.OnlyVertical;
				}
				m_UseY = useY;
			}
			while (!flag);
			CrossPlatformInputManager.VirtualAxis virtualAxis = default(CrossPlatformInputManager.VirtualAxis);
			string text = (virtualAxis.name = horizontalAxisName);
			virtualAxis.matchWithInputManager = true;
			m_HorizontalVirtualAxis = virtualAxis;
			CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			if (m_UseY)
			{
				CrossPlatformInputManager.VirtualAxis virtualAxis2 = default(CrossPlatformInputManager.VirtualAxis);
				string text2 = (virtualAxis2.name = verticalAxisName);
				virtualAxis2.matchWithInputManager = true;
				m_VerticalVirtualAxis = virtualAxis2;
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3E00", Offset = "0x3DC2800", VA = "0x183DC3E00")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_002e
			//IL_0028: Expected native int or pointer, but got O
			Image image = (m_Image = GetComponent<Image>());
			Transform transform = m_Image.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)m_Center)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3AC0", Offset = "0x3DC24C0", VA = "0x183DC3AC0")]
		private void CreateVirtualAxes()
		{
			bool flag;
			bool useY = default(bool);
			do
			{
				AxisOption axisOption = axesToUse;
				if (axisOption == AxisOption.Both)
				{
				}
				flag = (m_UseX = axisOption == AxisOption.OnlyHorizontal);
				if (axisOption != 0)
				{
					useY = axisOption == AxisOption.OnlyVertical;
				}
				m_UseY = useY;
			}
			while (!flag);
			CrossPlatformInputManager.VirtualAxis virtualAxis = default(CrossPlatformInputManager.VirtualAxis);
			string text = (virtualAxis.name = horizontalAxisName);
			virtualAxis.matchWithInputManager = true;
			m_HorizontalVirtualAxis = virtualAxis;
			CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			if (m_UseY)
			{
				CrossPlatformInputManager.VirtualAxis virtualAxis2 = default(CrossPlatformInputManager.VirtualAxis);
				string text2 = (virtualAxis2.name = verticalAxisName);
				virtualAxis2.matchWithInputManager = true;
				m_VerticalVirtualAxis = virtualAxis2;
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3EA0", Offset = "0x3DC28A0", VA = "0x183DC3EA0")]
		private unsafe void UpdateVirtualAxes(Vector3 value)
		{
			//Discarded unreachable code: IL_0034
			//IL_0009: Expected native int or pointer, but got O
			//IL_0033: Expected F4, but got I4
			Vector3 vector = default(Vector3);
			float num = (((Vector3*)(IntPtr)value)->z = vector.z);
			if (m_UseX)
			{
				CrossPlatformInputManager.VirtualAxis horizontalVirtualAxis = m_HorizontalVirtualAxis;
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.m_Value = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3D10", Offset = "0x3DC2710", VA = "0x183DC3D10", Slot = "4")]
		public unsafe void OnPointerDown(PointerEventData data)
		{
			//Discarded unreachable code: IL_002d
			//IL_002c: Expected F4, but got I4
			//IL_0027: Expected native int or pointer, but got O
			m_Dragging = true;
			int num = (m_Id = data.pointerId);
			if (controlStyle != 0)
			{
				int num2 = 0;
				((Vector3*)(IntPtr)m_Center)->z = num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3F20", Offset = "0x3DC2920", VA = "0x183DC3F20")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_00c0
			//IL_003c: Expected F4, but got I8
			//IL_0037: Expected native int or pointer, but got O
			//IL_0067: Expected F4, but got I4
			//IL_0062: Expected native int or pointer, but got O
			//IL_00aa: Expected F4, but got I4
			//IL_00bf: Expected F4, but got I4
			if (!m_Dragging)
			{
				return;
			}
			int num = 0;
			int touchCount = Input.touchCount;
			int id = m_Id;
			int num2 = id + 1;
			if (id != -1)
			{
				if (controlStyle == ControlStyle.Swipe)
				{
					ulong num3 = default(ulong);
					((Vector3*)(IntPtr)m_Center)->z = (long)num3;
					int num4 = 0;
					Touch[] touches = Input.touches;
					long num5 = (long)m_Id * 68L;
					Vector2 previousTouchPos = default(Vector2);
					m_PreviousTouchPos = previousTouchPos;
					((Vector2*)(IntPtr)m_PreviousTouchPos)->y = 0f;
				}
				int num6 = 0;
				Touch[] touches2 = Input.touches;
				long num7 = (long)m_Id * 68L;
				int num8 = 0;
				Touch[] touches3 = Input.touches;
				long num9 = (long)m_Id * 68L;
				if (m_UseX)
				{
					m_HorizontalVirtualAxis.m_Value = 0f;
				}
				if (m_UseY)
				{
					m_VerticalVirtualAxis.m_Value = 0f;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3D70", Offset = "0x3DC2770", VA = "0x183DC3D70", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
			//Discarded unreachable code: IL_004d
			//IL_0017: Expected I4, but got I8
			//IL_0037: Expected F4, but got I4
			//IL_004c: Expected F4, but got I4
			m_Dragging = false;
			m_Id = -1;
			float z = Vector3.zero.z;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.m_Value = 0f;
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.m_Value = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C20", Offset = "0x3DC2620", VA = "0x183DC3C20")]
		private void OnDisable()
		{
			if (CrossPlatformInputManager.AxisExists(horizontalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(horizontalAxisName);
			}
			if (CrossPlatformInputManager.AxisExists(verticalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(verticalAxisName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3DC41C0", Offset = "0x3DC2BC0", VA = "0x183DC41C0")]
		public TouchPad()
		{
		}//IL_003c: Expected I4, but got I8

	}
}
