using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	public static class App
	{
		[Cpp2IlInjected.Token(Token = "0x2000135")]
		public enum RuntimePlatform
		{
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			OSXEditor = 0,
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			OSXPlayer = 1,
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			WindowsPlayer = 2,
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			OSXWebPlayer = 3,
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			OSXDashboardPlayer = 4,
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			WindowsWebPlayer = 5,
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			WindowsEditor = 7,
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			IPhonePlayer = 8,
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			PS3 = 9,
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			XBOX360 = 10,
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			Android = 11,
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			NaCl = 12,
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			LinuxPlayer = 13,
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			FlashPlayer = 15,
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			LinuxEditor = 16,
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			WebGLPlayer = 17,
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			MetroPlayerX86 = 18,
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			WSAPlayerX86 = 18,
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			MetroPlayerX64 = 19,
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			WSAPlayerX64 = 19,
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			MetroPlayerARM = 20,
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			WSAPlayerARM = 20,
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			WP8Player = 21,
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			BB10Player = 22,
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			BlackBerryPlayer = 22,
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			TizenPlayer = 23,
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			PSP2 = 24,
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			PS4 = 25,
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			PSM = 26,
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			XboxOne = 27,
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			SamsungTVPlayer = 28,
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			WiiU = 30,
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			tvOS = 31,
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			Switch = 32,
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			Lumin = 33,
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			Stadia = 34,
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			CloudRendering = 35,
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			GameCoreScarlett = 36,
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			GameCoreXboxSeries = 36,
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			GameCoreXboxOne = 37,
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			PS5 = 38
		}

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		[field: Cpp2IlInjected.Token(Token = "0x400058E")]
		public static bool IsEditor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C57")]
			[Cpp2IlInjected.Address(RVA = "0x26EE680", Offset = "0x26ED080", VA = "0x1826EE680")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C58")]
			[Cpp2IlInjected.Address(RVA = "0x26EE800", Offset = "0x26ED200", VA = "0x1826EE800")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		[field: Cpp2IlInjected.Token(Token = "0x400058F")]
		public static bool IsDebug
		{
			[Cpp2IlInjected.Token(Token = "0x6000C59")]
			[Cpp2IlInjected.Address(RVA = "0x26EE640", Offset = "0x26ED040", VA = "0x1826EE640")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C5A")]
			[Cpp2IlInjected.Address(RVA = "0x26EE7C0", Offset = "0x26ED1C0", VA = "0x1826EE7C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		[field: Cpp2IlInjected.Token(Token = "0x4000590")]
		public static bool HasCheats
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5B")]
			[Cpp2IlInjected.Address(RVA = "0x26EE600", Offset = "0x26ED000", VA = "0x1826EE600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C5C")]
			[Cpp2IlInjected.Address(RVA = "0x26EE780", Offset = "0x26ED180", VA = "0x1826EE780")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		[field: Cpp2IlInjected.Token(Token = "0x4000591")]
		public static RuntimePlatform CurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5D")]
			[Cpp2IlInjected.Address(RVA = "0x26EE5C0", Offset = "0x26ECFC0", VA = "0x1826EE5C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C5E")]
			[Cpp2IlInjected.Address(RVA = "0x26EE740", Offset = "0x26ED140", VA = "0x1826EE740")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		public static string StorePlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5F")]
			[Cpp2IlInjected.Address(RVA = "0x26EE6C0", Offset = "0x26ED0C0", VA = "0x1826EE6C0")]
			[CompilerGenerated]
			get
			{
				return _003CStorePlatform_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C60")]
			[Cpp2IlInjected.Address(RVA = "0x26EE840", Offset = "0x26ED240", VA = "0x1826EE840")]
			[CompilerGenerated]
			private set
			{
				//IL_0006: Expected I4, but got O
				IsEditor = (byte)(int)value != 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000309")]
		public static IUserInfo UserInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000C61")]
			[Cpp2IlInjected.Address(RVA = "0x26EE700", Offset = "0x26ED100", VA = "0x1826EE700")]
			[CompilerGenerated]
			get
			{
				return _003CUserInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C62")]
			[Cpp2IlInjected.Address(RVA = "0x26EE890", Offset = "0x26ED290", VA = "0x1826EE890")]
			[CompilerGenerated]
			private set
			{
				//IL_0006: Expected I4, but got O
				IsEditor = (byte)(int)value != 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x26EE420", Offset = "0x26ECE20", VA = "0x1826EE420")]
		public static void SetInfos(bool isEditor, bool isDebug, bool hasCheats = true, RuntimePlatform runtimePlatform = RuntimePlatform.WindowsPlayer, [Optional] string storePlatform, [Optional] IUserInfo userInfo)
		{
			IsEditor = isEditor;
			IsDebug = isDebug;
			HasCheats = hasCheats;
			CurrentPlatform = runtimePlatform;
			/*Error: Unexpected end of block*/;
		}
	}
}
