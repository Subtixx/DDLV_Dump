using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace LeoLuz
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RequireComponent(typeof(Rect))]
	public class UIButtonToAxis : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[InputAxesListDropdown(false)]
		public string AxisName = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[Range(-1f, 1f)]
		public float Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private float CurrentValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool pressed;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7050", Offset = "0x3DC5A50", VA = "0x183DC7050")]
		public void OnDrawGizmosSelected()
		{
			int num = 0;
			Input.Autoconfigure();
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC71A0", Offset = "0x3DC5BA0", VA = "0x183DC71A0")]
		private void Start()
		{
			Input.RegisterAxisMobile(AxisName);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6FD0", Offset = "0x3DC59D0", VA = "0x183DC6FD0")]
		public void FixedUpdate()
		{
			if (pressed)
			{
				Input.PressButtonMobile(AxisName);
				float value = Value;
				string axisName = AxisName;
				CurrentValue = value;
				Input.SetAxisMobile(axisName, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DC70A0", Offset = "0x3DC5AA0", VA = "0x183DC70A0", Slot = "6")]
		public virtual void OnPointerDown(PointerEventData data)
		{
			Input.PressButtonDownMobile(AxisName);
			float value = Value;
			string axisName = AxisName;
			CurrentValue = value;
			Input.SetAxisMobile(axisName, value);
			pressed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7120", Offset = "0x3DC5B20", VA = "0x183DC7120", Slot = "7")]
		public virtual void OnPointerUp(PointerEventData data)
		{
			//IL_002f: Expected F4, but got I4
			string axisName = AxisName;
			pressed = false;
			Input.PressButtonUpMobile(axisName);
			string axisName2 = AxisName;
			int num = 0;
			CurrentValue = 0f;
			Input.SetAxisMobile(axisName2, num);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7200", Offset = "0x3DC5C00", VA = "0x183DC7200")]
		public UIButtonToAxis()
		{
		}
	}
}
