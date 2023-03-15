using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public string axisName = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public float axisValue = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public float responseSpeed = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public float returnToCentreSpeed = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private AxisTouchButton m_PairedWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F07C60", Offset = "0x2F06660", VA = "0x182F07C60")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0053
			string text = axisName;
			bool flag = CrossPlatformInputManager.activeInput.AxisExists(text);
			string text2 = axisName;
			if (flag)
			{
				CrossPlatformInputManager.VirtualAxis virtualAxis = (m_Axis = CrossPlatformInputManager.activeInput.VirtualAxisReference(text2));
			}
			CrossPlatformInputManager.VirtualAxis virtualAxis2 = (m_Axis = new CrossPlatformInputManager.VirtualAxis(text2));
			CrossPlatformInputManager.RegisterVirtualAxis(m_Axis);
			FindPairedButton();
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F07A80", Offset = "0x2F06480", VA = "0x182F07A80")]
		private void FindPairedButton()
		{
			//Discarded unreachable code: IL_0053
			Object[] array = Object.FindObjectsOfType(typeof(AxisTouchButton));
			if (array == null)
			{
				return;
			}
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				Object @object = array[num];
				if (length != 0 && array[num] != this)
				{
					Object object2 = (m_PairedWith = (AxisTouchButton)array[num]);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F07C40", Offset = "0x2F06640", VA = "0x182F07C40")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_000c
			m_Axis.Remove();
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2F07E50", Offset = "0x2F06850", VA = "0x182F07E50", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
			//Discarded unreachable code: IL_0047
			//IL_0010: Expected O, but got I4
			AxisTouchButton pairedWith = m_PairedWith;
			int num = 0;
			if (pairedWith == (Object)num)
			{
				FindPairedButton();
			}
			CrossPlatformInputManager.VirtualAxis axis = m_Axis;
			int num2 = 0;
			float target = axisValue;
			float deltaTime = Time.deltaTime;
			float num3 = (axis.m_Value = Mathf.MoveTowards(deltaTime, target, deltaTime));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2F07F30", Offset = "0x2F06930", VA = "0x182F07F30", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
			//Discarded unreachable code: IL_0024
			//IL_0019: Expected F4, but got I4
			CrossPlatformInputManager.VirtualAxis axis = m_Axis;
			int num = 0;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			float num3 = (axis.m_Value = Mathf.MoveTowards(deltaTime, num2, deltaTime));
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2F07F90", Offset = "0x2F06990", VA = "0x182F07F90")]
		public AxisTouchButton()
		{
		}
	}
}
