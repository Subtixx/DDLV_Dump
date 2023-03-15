using System;
using System.Collections.Generic;
using System.IO;
using CloudScripts;
using Cpp2IlInjected;
using Definitions;
using EpicSdk.Service;
using Meta.Util;
using Steamworks;
using StoreFrontEnums;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002B1")]
	public static class PlatformUtils
	{
		[Cpp2IlInjected.Token(Token = "0x4001517")]
		private static bool? _useSteam;

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool IsWindowsStore()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0xF14470", Offset = "0xF12E70", VA = "0x180F14470")]
		private static string GetPcStore()
		{
			int num = 0;
			if (!UseSteam())
			{
				int num2 = 0;
				if (!EpicSdkService.UseEpic())
				{
					return RuntimePlatformNames.WindowsDefault;
				}
				return RuntimePlatformNames.Epic;
			}
			return RuntimePlatformNames.Steam;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0xF15040", Offset = "0xF13A40", VA = "0x180F15040")]
		public static bool TryGetRunningStore(out string storeName)
		{
			int num = 0;
			int num2 = (int)Application.platform;
			if (num2 > 11 && num2 != 25 && num2 != 27)
			{
				num2 += -32;
				if (num2 > 6)
				{
					goto IL_0031;
				}
			}
			if (num2 <= 8)
			{
				int num3 = 0;
				string pcStore = GetPcStore();
			}
			if (num2 != 11)
			{
			}
			goto IL_0031;
			IL_0031:
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0xF147B0", Offset = "0xF131B0", VA = "0x180F147B0")]
		public static string GetRunningStore()
		{
			//Discarded unreachable code: IL_003e
			int num = 0;
			int platform = (int)Application.platform;
			int num2 = default(int);
			if (platform > 11)
			{
				switch (platform)
				{
				case 27:
					return "gdk";
				case 25:
					return "psstore";
				}
				platform += -32;
				if (platform <= 6)
				{
					return "switch";
				}
			}
			else
			{
				if (platform <= 8)
				{
					num2 = 0;
					return GetPcStore();
				}
				if (num2 == 11)
				{
					return "googleplay";
				}
			}
			int num3 = 0;
			num3 += num2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0xF14550", Offset = "0xF12F50", VA = "0x180F14550")]
		public static string GetRunningPlatformName(bool allowDebugOverides = false)
		{
			//Discarded unreachable code: IL_003e, IL_0063
			//IL_0062: Expected O, but got I4
			int num = 0;
			int platform = (int)Application.platform;
			if (platform > 11)
			{
				switch (platform)
				{
				case 27:
					return RuntimePlatformNames.XBox;
				case 25:
					return RuntimePlatformNames.Playstation;
				}
				platform += -32;
				if (platform <= 6)
				{
					return RuntimePlatformNames.NintendoSwitch;
				}
			}
			else
			{
				if (platform <= 8)
				{
					int num2 = 0;
					return GetPcStore();
				}
				if ((long)typeof(RuntimePlatformNames).TypeHandle == 11)
				{
					return RuntimePlatformNames.Android;
				}
			}
			int num3 = 0;
			return ((Enum)Application.platform).ToString();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0xF14A10", Offset = "0xF13410", VA = "0x180F14A10")]
		public static PlayfabOriginId GetRuntimePlayfabOriginId()
		{
			//Discarded unreachable code: IL_004e
			int num = 0;
			if (DebugSettings.Settings.overridePlayfabOrigin_ == PlayfabOriginId.Unknown)
			{
				int num2 = 0;
				if (!EpicSdkService.UseEpic())
				{
					int num3 = 0;
					if (!UseSteam())
					{
						int num4 = 0;
						switch (Application.platform)
						{
						default:
						{
							int num5 = 0;
							break;
						}
						case RuntimePlatform.PS4:
						case RuntimePlatform.XboxOne:
							break;
						}
					}
				}
			}
			int num6 = 0;
			return DebugSettings.Settings.overridePlayfabOrigin_;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0xF14900", Offset = "0xF13300", VA = "0x180F14900")]
		public static PlayfabNativeAuth GetRuntimePlayfabNativeAuth()
		{
			int num = 0;
			int num2 = (int)Application.platform;
			if (num2 > 11)
			{
				if (num2 == 25)
				{
				}
				if (num2 != 27)
				{
					num2 += -32;
					if (num2 > 6)
					{
						goto IL_0040;
					}
				}
			}
			int num4 = default(int);
			if (num2 <= 8)
			{
				int num3 = 0;
				if (!EpicSdkService.UseEpic())
				{
					num4 = 0;
					if (!UseSteam())
					{
						goto IL_0040;
					}
				}
			}
			if (num4 != 11)
			{
			}
			goto IL_0040;
			IL_0040:
			int num5 = 0;
			num5 += num5;
			num5 += num5;
			num5 += num5;
			num5 += num5;
			num5 += num5;
			num5 += num5;
			num5 += num5;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0xF148F0", Offset = "0xF132F0", VA = "0x180F148F0")]
		public static RuntimePlatform GetRuntimePlatform()
		{
			int num = 0;
			return Application.platform;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0xF14BA0", Offset = "0xF135A0", VA = "0x180F14BA0")]
		public static bool IsEditor()
		{
			int num = 0;
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WindowsEditor)
			{
				return true;
			}
			return platform == RuntimePlatform.OSXEditor;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0xF14BF0", Offset = "0xF135F0", VA = "0x180F14BF0")]
		public static bool IsPCPlayer()
		{
			int num = 0;
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WindowsPlayer)
			{
				return true;
			}
			return platform == RuntimePlatform.OSXPlayer;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0xF14C20", Offset = "0xF13620", VA = "0x180F14C20")]
		public static bool IsPlaystation()
		{
			int num = 0;
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.PS4)
			{
				return true;
			}
			return platform == RuntimePlatform.PS5;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0xA85170", Offset = "0xA83B70", VA = "0x180A85170")]
		public static bool IsSwitch()
		{
			int num = 0;
			return Application.platform == RuntimePlatform.Switch;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0xF14C80", Offset = "0xF13680", VA = "0x180F14C80")]
		public static bool IsXbox()
		{
			int num = 0;
			RuntimePlatform platform = Application.platform;
			if (platform != RuntimePlatform.XboxOne && platform != RuntimePlatform.GameCoreXboxOne)
			{
				return platform == RuntimePlatform.GameCoreScarlett;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0xF14BD0", Offset = "0xF135D0", VA = "0x180F14BD0")]
		public static bool IsIOS()
		{
			int num = 0;
			return Application.platform == RuntimePlatform.IPhonePlayer;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0xF14B80", Offset = "0xF13580", VA = "0x180F14B80")]
		public static bool IsAndroid()
		{
			int num = 0;
			return Application.platform == RuntimePlatform.Android;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0xF151F0", Offset = "0xF13BF0", VA = "0x180F151F0")]
		public static bool UseSteam()
		{
			//Discarded unreachable code: IL_0047
			int num = 0;
			if (Application.webSecurityEnabled)
			{
				int num2 = 0;
				DebugSettings settings = DebugSettings.Settings;
			}
			int num3 = 0;
			bool flag = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "steam.txt"));
			int num4 = 0;
			string text = default(string);
			Debug.Log("UseSteam Exception " + text);
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0xF14C50", Offset = "0xF13650", VA = "0x180F14C50")]
		public static bool IsSteamDeck()
		{
			//Discarded unreachable code: IL_0016
			int num = 0;
			bool flag = UseSteam();
			if (flag)
			{
				int num2 = 0;
				bool flag2 = SteamUtils.IsSteamRunningOnSteamDeck();
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0xF15180", Offset = "0xF13B80", VA = "0x180F15180")]
		public static bool UseEpic()
		{
			int num = 0;
			return EpicSdkService.UseEpic();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool UseMacAppStore()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool UseAgeGate()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0xF14B40", Offset = "0xF13540", VA = "0x180F14B40")]
		public static bool HasMouse()
		{
			int num = 0;
			RuntimePlatform platform = Application.platform;
			if (platform != RuntimePlatform.WindowsPlayer && platform != RuntimePlatform.OSXPlayer)
			{
				int num2 = 0;
				RuntimePlatform platform2 = Application.platform;
				if (platform2 != RuntimePlatform.WindowsEditor)
				{
					return platform2 == RuntimePlatform.OSXEditor;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0xF15190", Offset = "0xF13B90", VA = "0x180F15190")]
		public static bool UseGraphicSettings()
		{
			int num = 0;
			RuntimePlatform platform = Application.platform;
			if (platform != RuntimePlatform.PS4 && platform != RuntimePlatform.PS5)
			{
				int num2 = 0;
				RuntimePlatform platform2 = Application.platform;
				if (platform2 != RuntimePlatform.XboxOne && platform2 != RuntimePlatform.GameCoreXboxOne && platform2 != RuntimePlatform.GameCoreScarlett)
				{
					int num3 = 0;
					if (Application.platform != RuntimePlatform.Switch)
					{
						int num4 = 0;
						if (Application.platform != RuntimePlatform.IPhonePlayer)
						{
							int num5 = 0;
							return Application.platform != RuntimePlatform.Android;
						}
					}
				}
			}
			int num6 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0xF14F30", Offset = "0xF13930", VA = "0x180F14F30")]
		public static void OpenInventoryStore()
		{
			//Discarded unreachable code: IL_004c
			int num = 0;
			if (!UseSteam())
			{
				int num2 = 0;
				if (EpicSdkService.UseEpic())
				{
					int num3 = 0;
					Application.OpenURL(StoreUrlData.Instance.epicURL_);
				}
			}
			else
			{
				int num4 = 0;
				StoreUrlData instance = StoreUrlData.Instance;
				string steamURL_ = instance.steamURL_;
				bool useSteamOverlay_ = instance.useSteamOverlay_;
				SteamManager.OpenInventoryStore(steamURL_, useSteamOverlay_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0xF14CB0", Offset = "0xF136B0", VA = "0x180F14CB0")]
		public static void OpenEpicMacMoonstoneStore(string catalogID)
		{
			//Discarded unreachable code: IL_0068, IL_006e, IL_0074, IL_007a, IL_0080, IL_0086
			//IL_005b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (!EpicSdkService.UseEpic())
			{
				return;
			}
			int num3 = 0;
			if (Application.platform != 0)
			{
				int num4 = 0;
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					return;
				}
			}
			int num5 = 0;
			IEnumerable<IAPData> all = (IEnumerable<IAPData>)IAPData.GetAll();
			int num8 = default(int);
			if (all != null)
			{
				uint num6 = default(uint);
				if (num < (int)num6)
				{
					num += num;
					if (num == (int)num6)
					{
						goto IL_005b;
					}
					num++;
				}
				int num7 = 0;
				while (num == 0)
				{
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				while (flag)
				{
				}
				num8 = 0;
				Application.OpenURL((string)num);
				goto IL_005b;
			}
			goto IL_0062;
			IL_0062:
			if (all == null)
			{
			}
			return;
			IL_005b:
			num8 += num8;
			goto IL_0062;
		}
	}
}
