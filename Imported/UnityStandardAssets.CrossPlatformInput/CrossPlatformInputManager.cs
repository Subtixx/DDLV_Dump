using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput.PlatformSpecific;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public static class CrossPlatformInputManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public enum ActiveInputMethod
		{
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			Hardware,
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			Touch
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public class VirtualAxis
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			private float m_Value;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public string name
			{
				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003Cname_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003Cname_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4000245")]
			public bool matchWithInputManager
			{
				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public float GetValue
			{
				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
				get
				{
					return m_Value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public float GetValueRaw
			{
				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
				get
				{
					return m_Value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x3DC74C0", Offset = "0x3DC5EC0", VA = "0x183DC74C0")]
			public VirtualAxis(string name)
			{
				this.name = name;
				matchWithInputManager = true;
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7500", Offset = "0x3DC5F00", VA = "0x183DC7500")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7460", Offset = "0x3DC5E60", VA = "0x183DC7460")]
			public void Remove()
			{
				UnRegisterVirtualAxis(name);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			public void Update(float value)
			{
				m_Value = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public class VirtualButton
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			private int m_LastPressedFrame = -5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			private int m_ReleasedFrame = -5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private bool m_Pressed;

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public string name
			{
				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003Cname_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003Cname_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000247")]
			public bool matchWithInputManager
			{
				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public bool GetButton
			{
				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
				get
				{
					return m_Pressed;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool GetButtonDown
			{
				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x3DC76B0", Offset = "0x3DC60B0", VA = "0x183DC76B0")]
				get
				{
					int lastPressedFrame = m_LastPressedFrame;
					int num = 0;
					int frameCount = Time.frameCount;
					lastPressedFrame -= frameCount;
					return lastPressedFrame == -1;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public bool GetButtonUp
			{
				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x3DC76D0", Offset = "0x3DC60D0", VA = "0x183DC76D0")]
				get
				{
					int releasedFrame = m_ReleasedFrame;
					int num = 0;
					int frameCount = Time.frameCount;
					return releasedFrame == frameCount;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7660", Offset = "0x3DC6060", VA = "0x183DC7660")]
			public VirtualButton(string name)
			{
				//IL_0010: Expected I4, but got I8
				//IL_0020: Expected I4, but got I8
				this.name = name;
				matchWithInputManager = true;
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7600", Offset = "0x3DC6000", VA = "0x183DC7600")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
				//IL_0010: Expected I4, but got I8
				//IL_0020: Expected I4, but got I8
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7550", Offset = "0x3DC5F50", VA = "0x183DC7550")]
			public void Pressed()
			{
				if (!m_Pressed)
				{
					m_Pressed = true;
					int num = 0;
					int num2 = (m_LastPressedFrame = Time.frameCount);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7580", Offset = "0x3DC5F80", VA = "0x183DC7580")]
			public void Released()
			{
				m_Pressed = false;
				int num = 0;
				int num2 = (m_ReleasedFrame = Time.frameCount);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x3DC75A0", Offset = "0x3DC5FA0", VA = "0x183DC75A0")]
			public void Remove()
			{
				UnRegisterVirtualButton(name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static VirtualInput activeInput;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private static VirtualInput s_TouchInput;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static VirtualInput s_HardwareInput;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static Vector3 mousePosition
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x2F092F0", Offset = "0x2F07CF0", VA = "0x182F092F0")]
			get
			{
				VirtualInput virtualInput = activeInput;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2F09220", Offset = "0x2F07C20", VA = "0x182F09220")]
		static CrossPlatformInputManager()
		{
			activeInput = new MobileInput();
			activeInput = new StandaloneInput();
			activeInput = s_HardwareInput;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2F08FB0", Offset = "0x2F079B0", VA = "0x182F08FB0")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
			if (activeInputMethod == ActiveInputMethod.Hardware)
			{
				activeInput = s_HardwareInput;
			}
			if (activeInputMethod == ActiveInputMethod.Touch)
			{
				activeInput = s_TouchInput;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2F08650", Offset = "0x2F07050", VA = "0x182F08650")]
		public static bool AxisExists(string name)
		{
			//Discarded unreachable code: IL_000c
			return activeInput.AxisExists(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2F086D0", Offset = "0x2F070D0", VA = "0x182F086D0")]
		public static bool ButtonExists(string name)
		{
			//Discarded unreachable code: IL_000c
			return activeInput.ButtonExists(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2F08A20", Offset = "0x2F07420", VA = "0x182F08A20")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
			//Discarded unreachable code: IL_000c
			activeInput.RegisterVirtualAxis(axis);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2F08AA0", Offset = "0x2F074A0", VA = "0x182F08AA0")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
			//Discarded unreachable code: IL_000c
			activeInput.RegisterVirtualButton(button);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2F09060", Offset = "0x2F07A60", VA = "0x182F09060")]
		public static void UnRegisterVirtualAxis(string name)
		{
			if (name != null)
			{
				activeInput.UnRegisterVirtualAxis(name);
				return;
			}
			ArgumentNullException ex = new ArgumentNullException("name");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2F09120", Offset = "0x2F07B20", VA = "0x182F09120")]
		public static void UnRegisterVirtualButton(string name)
		{
			//Discarded unreachable code: IL_000c
			activeInput.UnRegisterVirtualButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2F091A0", Offset = "0x2F07BA0", VA = "0x182F091A0")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			//Discarded unreachable code: IL_000c
			return activeInput.VirtualAxisReference(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2F08840", Offset = "0x2F07240", VA = "0x182F08840")]
		public static float GetAxis(string name)
		{
			int raw = 0;
			return GetAxis(name, (byte)raw != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2F08750", Offset = "0x2F07150", VA = "0x182F08750")]
		public static float GetAxisRaw(string name)
		{
			return GetAxis(name, raw: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2F087B0", Offset = "0x2F071B0", VA = "0x182F087B0")]
		private static float GetAxis(string name, bool raw)
		{
			//Discarded unreachable code: IL_000d
			return activeInput.GetAxis(name, raw);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2F089A0", Offset = "0x2F073A0", VA = "0x182F089A0")]
		public static bool GetButton(string name)
		{
			//Discarded unreachable code: IL_000c
			return activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2F088A0", Offset = "0x2F072A0", VA = "0x182F088A0")]
		public static bool GetButtonDown(string name)
		{
			//Discarded unreachable code: IL_000c
			return activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2F08920", Offset = "0x2F07320", VA = "0x182F08920")]
		public static bool GetButtonUp(string name)
		{
			//Discarded unreachable code: IL_000c
			return activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2F08D30", Offset = "0x2F07730", VA = "0x182F08D30")]
		public static void SetButtonDown(string name)
		{
			//Discarded unreachable code: IL_000d
			bool button = activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2F08DB0", Offset = "0x2F077B0", VA = "0x182F08DB0")]
		public static void SetButtonUp(string name)
		{
			//Discarded unreachable code: IL_000d
			bool button = activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2F08BA0", Offset = "0x2F075A0", VA = "0x182F08BA0")]
		public static void SetAxisPositive(string name)
		{
			//Discarded unreachable code: IL_000d
			bool button = activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2F08B20", Offset = "0x2F07520", VA = "0x182F08B20")]
		public static void SetAxisNegative(string name)
		{
			//Discarded unreachable code: IL_000d
			bool button = activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2F08C20", Offset = "0x2F07620", VA = "0x182F08C20")]
		public static void SetAxisZero(string name)
		{
			//Discarded unreachable code: IL_000d
			bool button = activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2F08CA0", Offset = "0x2F076A0", VA = "0x182F08CA0")]
		public static void SetAxis(string name, float value)
		{
			//Discarded unreachable code: IL_000d
			bool button = activeInput.GetButton(name);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2F08E30", Offset = "0x2F07830", VA = "0x182F08E30")]
		public static void SetVirtualMousePositionX(float f)
		{
			//Discarded unreachable code: IL_000c
			activeInput.SetVirtualMousePositionX(f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2F08EB0", Offset = "0x2F078B0", VA = "0x182F08EB0")]
		public static void SetVirtualMousePositionY(float f)
		{
			//Discarded unreachable code: IL_000c
			activeInput.SetVirtualMousePositionY(f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2F08F30", Offset = "0x2F07930", VA = "0x182F08F30")]
		public static void SetVirtualMousePositionZ(float f)
		{
			//Discarded unreachable code: IL_000c
			activeInput.SetVirtualMousePositionZ(f);
		}
	}
}
