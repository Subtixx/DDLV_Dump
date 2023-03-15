using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public enum AxisOption
		{
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			Both,
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			OnlyHorizontal,
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			OnlyVertical
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int MovementRange = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AxisOption axesToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public string horizontalAxisName = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public string verticalAxisName = "Vertical";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private Vector3 m_StartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private bool m_UseX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private bool m_UseY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2F15E30", Offset = "0x2F14830", VA = "0x182F15E30")]
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
			CrossPlatformInputManager.VirtualAxis virtualAxis = (m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName));
			CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			if (m_UseY)
			{
				CrossPlatformInputManager.VirtualAxis virtualAxis2 = (m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName));
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2F16220", Offset = "0x2F14C20", VA = "0x182F16220")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_001b
			//IL_0015: Expected native int or pointer, but got O
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)m_StartPos)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2F16260", Offset = "0x2F14C60", VA = "0x182F16260")]
		private void UpdateVirtualAxes(Vector3 value)
		{
			//Discarded unreachable code: IL_0021
			if (m_UseX)
			{
				CrossPlatformInputManager.VirtualAxis horizontalVirtualAxis = m_HorizontalVirtualAxis;
			}
			if (m_UseY)
			{
				CrossPlatformInputManager.VirtualAxis verticalVirtualAxis = m_VerticalVirtualAxis;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2F15E30", Offset = "0x2F14830", VA = "0x182F15E30")]
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
			CrossPlatformInputManager.VirtualAxis virtualAxis = (m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName));
			CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			if (m_UseY)
			{
				CrossPlatformInputManager.VirtualAxis virtualAxis2 = (m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName));
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2F15FC0", Offset = "0x2F149C0", VA = "0x182F15FC0", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
			//Discarded unreachable code: IL_0053
			float z = Vector3.zero.z;
			if (m_UseX)
			{
			}
			if (m_UseY)
			{
			}
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			if (m_UseX)
			{
				CrossPlatformInputManager.VirtualAxis horizontalVirtualAxis = m_HorizontalVirtualAxis;
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.m_Value = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2F16170", Offset = "0x2F14B70", VA = "0x182F16170", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
			//Discarded unreachable code: IL_0034
			Transform transform = base.transform;
			float z = m_StartPos.z;
			if (m_UseX)
			{
				CrossPlatformInputManager.VirtualAxis horizontalVirtualAxis = m_HorizontalVirtualAxis;
			}
			if (m_UseY)
			{
				CrossPlatformInputManager.VirtualAxis verticalVirtualAxis = m_VerticalVirtualAxis;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2F15F70", Offset = "0x2F14970", VA = "0x182F15F70")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_002a
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Remove();
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Remove();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2F162E0", Offset = "0x2F14CE0", VA = "0x182F162E0")]
		public Joystick()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
