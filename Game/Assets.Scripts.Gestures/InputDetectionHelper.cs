using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Platform;
using Meta.Util;
using Rewired;
using UnityEngine;

namespace Assets.Scripts.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	public class InputDetectionHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		public enum InputController
		{
			[Cpp2IlInjected.Token(Token = "0x4000674")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000675")]
			Keyboard,
			[Cpp2IlInjected.Token(Token = "0x4000676")]
			Xbox360,
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			XboxOne,
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			XboxSeries,
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			NintendoSwitch,
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			PlayStation4,
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			PlayStation5
		}

		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public static Dictionary<InputController, string[]> ControlTypeControllersNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private Vector2? _mousePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private bool _isGamepadLocked;

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x11B6280", Offset = "0x11B4C80", VA = "0x1811B6280")]
		public unsafe bool IsControllerInUse(bool useAltShortcuts = false)
		{
			//IL_0190: Expected O, but got I4
			//IL_0198: Expected native int or pointer, but got O
			Func<string, bool> func = default(Func<string, bool>);
			uint num6 = default(uint);
			uint num7 = default(uint);
			ulong num8 = default(ulong);
			while (true)
			{
				int num = 0;
				if (DebugSettings.Settings.forceNoGamepad_)
				{
					break;
				}
				int num2 = 0;
				bool flag = Input.HasGameController();
				int num3 = 0;
				if ((flag ? 1 : 0) - 1 <= 1 || flag)
				{
					string[] array = new string[6];
					if ("LT" != null && "LT" == null)
					{
						continue;
					}
					array[0] = "LT";
					if ("RT" != null && "RT" == null)
					{
						continue;
					}
					array[1] = "RT";
					if ("Left Stick X" != null && "Left Stick X" == null)
					{
						continue;
					}
					array[2] = "Left Stick X";
					if ("Left Stick Y" != null && "Left Stick Y" == null)
					{
						continue;
					}
					array[3] = "Left Stick Y";
					if ("Right Stick X" != null && "Right Stick X" == null)
					{
						continue;
					}
					array[4] = "Right Stick X";
					if ("Right Stick Y" != null && "Right Stick Y" == null)
					{
						continue;
					}
					array[5] = "Right Stick Y";
					if (_003C_003Ec._003C_003E9__4_0 == null)
					{
						func = (Func<string, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(string x)
						{
							//IL_000d: Expected I4, but got O
							float axisRaw = Input.GetAxisRaw(x);
							return (byte)(int)typeof(Input).TypeHandle != 0;
						});
					}
					int num4 = MoreLinq.FindIndex<string>((IEnumerable<>)(object)array, (Func<, >)(object)func);
					int num5 = 0;
					if (Input.anyKeyDown)
					{
						num6++;
						while (num7 == 0)
						{
						}
					}
					if (!_isGamepadLocked)
					{
						if (num8 != 0)
						{
							goto IL_019d;
						}
						int num9 = 0;
						if (!Input.GetMouseButtonDown(0))
						{
							int num10 = 0;
							if (!Input.anyKeyDown)
							{
								bool has_value = ((Nullable<>)_mousePosition).has_value;
								int num11 = 0;
								if (0 == 0)
								{
									goto IL_019d;
								}
								int num12 = 0;
								int num13 = 0;
							}
						}
					}
					bool flag2 = (_isGamepadLocked = num8 == 0);
					if (num8 != 0)
					{
						int num14 = 0;
						_mousePosition = (Vector2?)(object)num14;
						((Nullable<>*)(IntPtr)_mousePosition)->has_value = (byte)num14 != 0;
					}
					goto IL_019d;
				}
				goto IL_01a9;
				IL_019d:
				if (_isGamepadLocked)
				{
					flag = useAltShortcuts;
				}
				goto IL_01a9;
				IL_01a9:
				return flag;
			}
			int num15 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x11B51C0", Offset = "0x11B3BC0", VA = "0x1811B51C0")]
		public static InputController GetController(bool useKeyboardAsController = false)
		{
			//Discarded unreachable code: IL_0130, IL_0136
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			if (!PlatformUtils.IsSteamDeck())
			{
				int num6 = 0;
				ReInput.PlayerHelper players = ReInput.players;
				int playerId = 0;
				Player player = players.GetPlayer(playerId);
				IList<Joystick> joysticks = (IList<Joystick>)player.controllers.get_Joysticks();
				if (joysticks != null || (0 > 1 && (long)joysticks != 13))
				{
					int num7 = 0;
					if ((long)joysticks == 25)
					{
					}
					uint num8 = default(uint);
					if (num8 != 27)
					{
						num8 += 4294967264u;
						if ((int)num8 <= 6)
						{
						}
						int num9 = 0;
						if (GetLastControllerType() == ControllerType.Keyboard)
						{
						}
						uint num10 = default(uint);
						if (num10 == 1 == useKeyboardAsController)
						{
							int num11 = 0;
							if (!GetJoystickName().ToLower().Contains("dualsense"))
							{
								int num12 = 0;
								if ((long)"pro controller" != 32 && GetCurrentController() != ControlType.NintendoSwitch)
								{
									int num13 = 0;
									if (!GetJoystickName().ToLower().Contains("pro controller"))
									{
										IList<Joystick> joysticks2 = (IList<Joystick>)player.controllers.get_Joysticks();
										if (joysticks2 != null)
										{
											Guid empty = Guid.Empty;
											bool flag = default(bool);
											while (!flag)
											{
											}
											Dictionary<InputController, string[]> controlTypeControllersNames = ControlTypeControllersNames;
											bool flag2 = default(bool);
											if (flag2)
											{
												while (!flag2)
												{
												}
												num4++;
											}
											num4++;
											while (num4 == 0)
											{
											}
										}
										int num14 = num14 + 1;
										if (joysticks2 != null)
										{
										}
										if (num14 == 0)
										{
										}
									}
								}
							}
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x11B6250", Offset = "0x11B4C50", VA = "0x1811B6250")]
		public static bool IsConsole()
		{
			int num = 0;
			RuntimePlatform runtimePlatform = PlatformUtils.GetRuntimePlatform();
			if (num > 1 && runtimePlatform != RuntimePlatform.LinuxPlayer)
			{
				return true;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x11B60B0", Offset = "0x11B4AB0", VA = "0x1811B60B0")]
		public static ControllerType GetLastControllerType()
		{
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			if (players != null)
			{
				int playerId = 0;
				Player player = players.GetPlayer(playerId);
				if (player != null)
				{
					Controller lastActiveController = player.controllers.GetLastActiveController();
					if (lastActiveController != null)
					{
						return lastActiveController.type;
					}
				}
			}
			int num2 = 0;
			RuntimePlatform runtimePlatform = PlatformUtils.GetRuntimePlatform();
			if (num2 > 1 && runtimePlatform != RuntimePlatform.LinuxPlayer)
			{
				return ControllerType.Joystick;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x11B58E0", Offset = "0x11B42E0", VA = "0x1811B58E0")]
		[Obsolete]
		public static ControlType GetCurrentController(bool useKeyboardAsController = false)
		{
			//Discarded unreachable code: IL_011c, IL_0122, IL_0128
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			if (DebugSettings.Settings.overrideGamepadControlType_ == (ControlType)num4)
			{
				int num6 = 0;
				if ((DebugSettings.Settings.forceNoGamepad_ ? 1 : 0) == num4)
				{
					int num7 = 0;
					ControllerType lastControllerType = GetLastControllerType();
					if ((lastControllerType == ControllerType.Keyboard || lastControllerType == ControllerType.Mouse) && !useKeyboardAsController)
					{
						goto IL_0116;
					}
				}
			}
			int num8 = 0;
			Player player;
			if ((DebugSettings.Settings.forceNoGamepad_ ? 1 : 0) == num4)
			{
				int num9 = 0;
				if (DebugSettings.Settings.overrideGamepadControlType_ != (ControlType)num4)
				{
					goto IL_010c;
				}
				int num10 = 0;
				ReInput.PlayerHelper players = ReInput.players;
				int playerId = 0;
				player = players.GetPlayer(playerId);
				if (player.controllers.get_Joysticks() != null)
				{
					int num11 = 0;
					RuntimePlatform platform = Application.platform;
					if (platform > RuntimePlatform.XBOX360)
					{
						if (num11 <= 1)
						{
							goto IL_00b9;
						}
						if (platform != RuntimePlatform.XboxOne && platform > (RuntimePlatform)6)
						{
							goto IL_00c0;
						}
					}
					if (platform != RuntimePlatform.PS3)
					{
					}
					goto IL_00b9;
				}
			}
			goto IL_0116;
			IL_010c:
			int num12 = 0;
			DebugSettings settings = DebugSettings.Settings;
			goto IL_0116;
			IL_0116:
			throw new NullReferenceException();
			IL_00c0:
			IList<Joystick> joysticks = (IList<Joystick>)player.controllers.get_Joysticks();
			if (joysticks != null)
			{
				Guid empty = Guid.Empty;
				bool flag = default(bool);
				while (!flag)
				{
				}
				Dictionary<InputController, string[]> controlTypeControllersNames = ControlTypeControllersNames;
				bool flag2 = default(bool);
				if (flag2)
				{
					while (!flag2)
					{
					}
					num4++;
				}
				num4++;
				while (num4 == 0)
				{
				}
			}
			int num13 = num13 + 1;
			if (joysticks != null)
			{
			}
			while (num13 == 0)
			{
			}
			goto IL_010c;
			IL_00b9:
			uint num14 = default(uint);
			if (num14 != 10)
			{
			}
			goto IL_00c0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x11B5F90", Offset = "0x11B4990", VA = "0x1811B5F90")]
		public static string GetJoystickName()
		{
			//Discarded unreachable code: IL_0028
			//IL_0015: Expected O, but got I4
			int num = 0;
			string[] joystickNames = Input.GetJoystickNames();
			ControlType currentController = GetCurrentController(useKeyboardAsController: true);
			string result = ((Enum)currentController).ToString();
			ControlType controlType = currentController;
			if (joystickNames == null || joystickNames.Length != 0)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x11B6970", Offset = "0x11B5370", VA = "0x1811B6970")]
		public static bool IsKeyboard(bool useKeyboardShortcutIndicators)
		{
			InputController controller = GetController(useKeyboardShortcutIndicators);
			if (controller == InputController.None)
			{
				return true;
			}
			return controller == InputController.Keyboard;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x11B6AA0", Offset = "0x11B54A0", VA = "0x1811B6AA0")]
		public static bool IsPs5Controller()
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			return GetJoystickName().ToLower().Contains("dualsense");
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x11B69E0", Offset = "0x11B53E0", VA = "0x1811B69E0")]
		public static bool IsNintendoController()
		{
			//Discarded unreachable code: IL_002d
			int num = 0;
			if (PlatformUtils.GetRuntimePlatform() != RuntimePlatform.Switch && GetCurrentController() != ControlType.NintendoSwitch)
			{
				int num2 = 0;
				return GetJoystickName().ToLower().Contains("pro controller");
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x11B5160", Offset = "0x11B3B60", VA = "0x1811B5160")]
		public static InputController ControlTypeToInputController(ControlType controlType)
		{
			if (controlType <= ControlType.Keyboard)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x11B61F0", Offset = "0x11B4BF0", VA = "0x1811B61F0")]
		public static ControlType InputControllerToControlType(InputController inputController)
		{
			if (inputController <= InputController.PlayStation4)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public InputDetectionHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x11B6B30", Offset = "0x11B5530", VA = "0x1811B6B30")]
		static InputDetectionHelper()
		{
			//Discarded unreachable code: IL_002b, IL_003a, IL_003e, IL_0050, IL_005f, IL_0063, IL_0075, IL_0085, IL_0090, IL_00a5, IL_00b0, IL_00c5, IL_00d0, IL_00e5, IL_00f0, IL_0105, IL_0110, IL_0123, IL_0133, IL_013e, IL_0153, IL_015e, IL_0173, IL_017e, IL_0193, IL_019e, IL_01b3, IL_01be, IL_01d1
			string[] array;
			do
			{
				Dictionary<InputController, string[]> dictionary = (Dictionary<InputController, string[]>)(object)new Dictionary<TKey, TValue>();
				array = new string[1];
			}
			while ("d74a350e-fe8b-4e9e-bbcd-efff16d34115" != null && array == null);
			array[0] = "d74a350e-fe8b-4e9e-bbcd-efff16d34115";
			throw new NullReferenceException();
		}
	}
}
