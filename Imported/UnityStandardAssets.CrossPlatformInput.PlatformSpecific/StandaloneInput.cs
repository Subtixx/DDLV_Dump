using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class StandaloneInput : VirtualInput
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2AA0", Offset = "0x3DC14A0", VA = "0x183DC2AA0", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			if (raw)
			{
				return Input.GetAxisRaw(name);
			}
			return Input.GetAxis(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2BF0", Offset = "0x3DC15F0", VA = "0x183DC2BF0", Slot = "5")]
		public override bool GetButton(string name)
		{
			return Input.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2B30", Offset = "0x3DC1530", VA = "0x183DC2B30", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return Input.GetButtonDown(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2B90", Offset = "0x3DC1590", VA = "0x183DC2B90", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return Input.GetButtonUp(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2E10", Offset = "0x3DC1810", VA = "0x183DC2E10", Slot = "8")]
		public override void SetButtonDown(string name)
		{
			Exception ex = new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2E60", Offset = "0x3DC1860", VA = "0x183DC2E60", Slot = "9")]
		public override void SetButtonUp(string name)
		{
			Exception ex = new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2D20", Offset = "0x3DC1720", VA = "0x183DC2D20", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
			Exception ex = new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2CD0", Offset = "0x3DC16D0", VA = "0x183DC2CD0", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
			Exception ex = new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2D70", Offset = "0x3DC1770", VA = "0x183DC2D70", Slot = "12")]
		public override void SetAxisZero(string name)
		{
			Exception ex = new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2DC0", Offset = "0x3DC17C0", VA = "0x183DC2DC0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
			Exception ex = new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2C50", Offset = "0x3DC1650", VA = "0x183DC2C50", Slot = "14")]
		public override Vector3 MousePosition()
		{
			int num = 0;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2EB0", Offset = "0x3DC18B0", VA = "0x183DC2EB0")]
		public StandaloneInput()
		{
			m_VirtualAxes = (Dictionary<string, CrossPlatformInputManager.VirtualAxis>)(object)new Dictionary<TKey, TValue>();
			m_VirtualButtons = (Dictionary<string, CrossPlatformInputManager.VirtualButton>)(object)new Dictionary<TKey, TValue>();
			m_AlwaysUseVirtual = (List<string>)(object)new List<T>();
			((object)this)._002Ector();
		}
	}
}
