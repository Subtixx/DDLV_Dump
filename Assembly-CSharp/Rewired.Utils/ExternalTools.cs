using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Rewired.Internal;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Platforms.Windows;
using UnityEngine;

namespace Rewired.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExternalTools : IExternalTools
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static Func<object> _getPlatformInitializerDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private bool _isEditorPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private Action<bool> _EditorPausedStateChangedEvent;

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public static Func<object> getPlatformInitializerDelegate
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1E91E40", Offset = "0x1E90840", VA = "0x181E91E40")]
			get
			{
				return _getPlatformInitializerDelegate;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1E91FA0", Offset = "0x1E909A0", VA = "0x181E91FA0")]
			set
			{
				_getPlatformInitializerDelegate = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public bool isEditorPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0", Slot = "63")]
			get
			{
				return _isEditorPaused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public bool UnityInput_IsTouchPressureSupported
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x1E91E30", Offset = "0x1E90830", VA = "0x181E91E30", Slot = "84")]
			get
			{
				int num = 0;
				return Input.touchPressureSupported;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> EditorPausedStateChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1E91D10", Offset = "0x1E90710", VA = "0x181E91D10", Slot = "4")]
			add
			{
				//IL_001e: Expected O, but got I4
				Delegate @delegate = Delegate.Combine(_EditorPausedStateChangedEvent, value);
				int num = 0;
				if ((object)@delegate == null || (object)@delegate != null)
				{
					_EditorPausedStateChangedEvent = (Action<bool>)num;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1E91E80", Offset = "0x1E90880", VA = "0x181E91E80", Slot = "5")]
			remove
			{
				//IL_001e: Expected O, but got I4
				Delegate @delegate = Delegate.Remove(_EditorPausedStateChangedEvent, value);
				int num = 0;
				if ((object)@delegate == null || (object)@delegate != null)
				{
					_EditorPausedStateChangedEvent = (Action<bool>)num;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1E91D90", Offset = "0x1E90790", VA = "0x181E91D90", Slot = "12")]
			[CompilerGenerated]
			add
			{
				Action<uint, bool> xboxOneInput_OnGamepadStateChange = this.XboxOneInput_OnGamepadStateChange;
				Delegate @delegate = Delegate.Combine(xboxOneInput_OnGamepadStateChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != xboxOneInput_OnGamepadStateChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x1E91F00", Offset = "0x1E90900", VA = "0x181E91F00", Slot = "13")]
			[CompilerGenerated]
			remove
			{
				Action<uint, bool> xboxOneInput_OnGamepadStateChange = this.XboxOneInput_OnGamepadStateChange;
				Delegate @delegate = Delegate.Remove(xboxOneInput_OnGamepadStateChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != xboxOneInput_OnGamepadStateChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ExternalTools()
		{
			Destroy();
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public void Destroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E91910", Offset = "0x1E90310", VA = "0x181E91910", Slot = "7")]
		public object GetPlatformInitializer()
		{
			int num = 0;
			return Main.GetPlatformInitializer();
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E918D0", Offset = "0x1E902D0", VA = "0x181E918D0", Slot = "8")]
		public string GetFocusedEditorWindowTitle()
		{
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "9")]
		public bool IsEditorSceneViewFocused()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "10")]
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "64")]
		public int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "11")]
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "14")]
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1E91CD0", Offset = "0x1E906D0", VA = "0x181E91CD0", Slot = "15")]
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "16")]
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		public void XboxOne_Gamepad_UpdatePlugin()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "18")]
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "65")]
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "19")]
		public Vector3 PS4Input_GetLastAcceleration(int id)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "20")]
		public Vector3 PS4Input_GetLastGyro(int id)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1E91950", Offset = "0x1E90350", VA = "0x181E91950", Slot = "21")]
		public Vector4 PS4Input_GetLastOrientation(int id)
		{
			Vector4 zero = Vector4.zero;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E91980", Offset = "0x1E90380", VA = "0x181E91980", Slot = "22")]
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
			touch0x.m_value = (touchNum.m_value = 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E919B0", Offset = "0x1E903B0", VA = "0x181E919B0", Slot = "23")]
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
			//IL_0009: Expected F4, but got I4
			int num = 0;
			touchpixelDensity.m_value = num;
			touchResolutionX.m_value = num;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "24")]
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "25")]
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "26")]
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "27")]
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "28")]
		public void PS4Input_PadResetLightBar(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "29")]
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "30")]
		public void PS4Input_PadResetOrientation(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "31")]
		public bool PS4Input_PadIsConnected(int id)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "66")]
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1068830", Offset = "0x1067230", VA = "0x181068830", Slot = "32")]
		public int PS4Input_GetDeviceClassForHandle(int handle)
		{
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "33")]
		public string PS4Input_GetDeviceClassString(int intValue)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "34")]
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "67")]
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "35")]
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "36")]
		public Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E91950", Offset = "0x1E90350", VA = "0x181E91950", Slot = "37")]
		public Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			Vector4 zero = Vector4.zero;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "68")]
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "38")]
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "39")]
		public bool PS4Input_SpecialIsConnected(int id)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "40")]
		public void PS4Input_SpecialResetLightSphere(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "41")]
		public void PS4Input_SpecialResetOrientation(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "42")]
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "43")]
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "44")]
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "45")]
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "46")]
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "69")]
		public Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "70")]
		public Vector3 PS4Input_AimGetLastGyro(int id)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E91950", Offset = "0x1E90350", VA = "0x181E91950", Slot = "71")]
		public Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			Vector4 zero = Vector4.zero;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "72")]
		public int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "47")]
		public int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "48")]
		public bool PS4Input_AimIsConnected(int id)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "49")]
		public void PS4Input_AimResetLightSphere(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "50")]
		public void PS4Input_AimResetOrientation(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "51")]
		public void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "52")]
		public void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "53")]
		public void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "54")]
		public void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "55")]
		public void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "73")]
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E91920", Offset = "0x1E90320", VA = "0x181E91920", Slot = "74")]
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			float z = Vector3.zero.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "75")]
		public int PS4Input_MoveGetButtons(int id, int index)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "76")]
		public int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "77")]
		public bool PS4Input_MoveIsConnected(int id, int index)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "78")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "79")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "80")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E919E0", Offset = "0x1E903E0", VA = "0x181E919E0", Slot = "81")]
		public IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "82")]
		public int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "83")]
		public int PS4Input_MoveSetVibration(int id, int index, int motor)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1E91820", Offset = "0x1E90220", VA = "0x181E91820", Slot = "56")]
		public unsafe void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
			//IL_000d: Expected O, but got Ref
			//IL_001a: Expected O, but got Ref
			List<int> list = (List<int>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref vids))._items = (T[])(object)new List<T>());
			List<int> list2 = (List<int>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref pids))._items = (T[])(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1068830", Offset = "0x1067230", VA = "0x181068830", Slot = "57")]
		public int GetAndroidAPILevel()
		{
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E91A30", Offset = "0x1E90430", VA = "0x181E91A30", Slot = "58")]
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			if (graphic == null)
			{
			}
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				int num3 = 0;
				int num4 = 0;
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E91B80", Offset = "0x1E90580", VA = "0x181E91B80", Slot = "59")]
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
			//Discarded unreachable code: IL_0012
			if (graphic == null)
			{
			}
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				int num3 = 0;
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1E91A20", Offset = "0x1E90420", VA = "0x181E91A20", Slot = "85")]
		public float UnityInput_GetTouchPressure(ref Touch touch)
		{
			return touch.pressure;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1E91A10", Offset = "0x1E90410", VA = "0x181E91A10", Slot = "86")]
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			return touch.maximumPossiblePressure;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1E91670", Offset = "0x1E90070", VA = "0x181E91670", Slot = "60")]
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			IControllerTemplate result = default(IControllerTemplate);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1E91780", Offset = "0x1E90180", VA = "0x181E91780", Slot = "61")]
		public Type[] GetControllerTemplateTypes()
		{
			return ControllerTemplateFactory._defaultTemplateTypes;
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1E916E0", Offset = "0x1E900E0", VA = "0x181E916E0", Slot = "62")]
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return ControllerTemplateFactory._defaultTemplateInterfaceTypes;
		}
	}
}
