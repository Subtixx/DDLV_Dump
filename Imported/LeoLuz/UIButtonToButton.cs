using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace LeoLuz
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RequireComponent(typeof(Rect))]
	public class UIButtonToButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[InputAxesListDropdown(false)]
		public string ButtonName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private bool pressed;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DC72C0", Offset = "0x3DC5CC0", VA = "0x183DC72C0")]
		public void OnDrawGizmosSelected()
		{
			int num = 0;
			Input.Autoconfigure();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DC73E0", Offset = "0x3DC5DE0", VA = "0x183DC73E0")]
		public void Update()
		{
			if (pressed)
			{
				Input.PressButtonMobile(ButtonName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7250", Offset = "0x3DC5C50", VA = "0x183DC7250")]
		public void FixedUpdate()
		{
			if (pressed)
			{
				Input.PressButtonMobile(ButtonName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7310", Offset = "0x3DC5D10", VA = "0x183DC7310", Slot = "6")]
		public virtual void OnPointerDown(PointerEventData data)
		{
			Input.PressButtonDownMobile(ButtonName);
			pressed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7380", Offset = "0x3DC5D80", VA = "0x183DC7380", Slot = "7")]
		public virtual void OnPointerUp(PointerEventData data)
		{
			pressed = false;
			Input.PressButtonUpMobile(ButtonName);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UIButtonToButton()
		{
		}
	}
}
