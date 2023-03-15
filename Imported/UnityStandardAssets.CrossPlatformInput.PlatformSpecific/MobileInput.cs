using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class MobileInput : VirtualInput
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2F17A40", Offset = "0x2F16440", VA = "0x182F17A40")]
		private void AddButton(string name)
		{
			//Discarded unreachable code: IL_0013
			CrossPlatformInputManager.VirtualButton button = new CrossPlatformInputManager.VirtualButton(name);
			CrossPlatformInputManager.activeInput.RegisterVirtualButton(button);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2F179B0", Offset = "0x2F163B0", VA = "0x182F179B0")]
		private void AddAxes(string name)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(name));
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2F17B30", Offset = "0x2F16530", VA = "0x182F17B30", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002a
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2F18040", Offset = "0x2F16A40", VA = "0x182F18040", Slot = "8")]
		public override void SetButtonDown(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002a
			Dictionary<string, CrossPlatformInputManager.VirtualButton> virtualButtons = m_VirtualButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2F180E0", Offset = "0x2F16AE0", VA = "0x182F180E0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002a
			Dictionary<string, CrossPlatformInputManager.VirtualButton> virtualButtons = m_VirtualButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2F17E50", Offset = "0x2F16850", VA = "0x182F17E50", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002f
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2F17DB0", Offset = "0x2F167B0", VA = "0x182F17DB0", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002f
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2F17EF0", Offset = "0x2F168F0", VA = "0x182F17EF0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002f
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2F17F90", Offset = "0x2F16990", VA = "0x182F17F90", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002b
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2F17BD0", Offset = "0x2F165D0", VA = "0x182F17BD0", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002a
			Dictionary<string, CrossPlatformInputManager.VirtualButton> virtualButtons = m_VirtualButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2F17C70", Offset = "0x2F16670", VA = "0x182F17C70", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002a
			Dictionary<string, CrossPlatformInputManager.VirtualButton> virtualButtons = m_VirtualButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2F17D10", Offset = "0x2F16710", VA = "0x182F17D10", Slot = "5")]
		public override bool GetButton(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0018, IL_002a
			Dictionary<string, CrossPlatformInputManager.VirtualButton> virtualButtons = m_VirtualButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xF0A3C0", Offset = "0xF08DC0", VA = "0x180F0A3C0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2F18180", Offset = "0x2F16B80", VA = "0x182F18180")]
		public MobileInput()
		{
		}
	}
}
