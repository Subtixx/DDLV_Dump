using System;
using System.Runtime.CompilerServices;
using CloudScripts;
using Cpp2IlInjected;
using Mdl.Platform.Shop;
using Meta.Online;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002AD")]
	public class PlatformInterfaceManager
	{
		[Cpp2IlInjected.Token(Token = "0x400150D")]
		private static PlatformInterfaceManager _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001512")]
		private NativeShopManagerBase _nativeShopManager;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public static PlatformInterfaceManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0xF14350", Offset = "0xF12D50", VA = "0x180F14350")]
			get
			{
				//Discarded unreachable code: IL_0010
				_instance = new PlatformInterfaceManager();
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public INativeNetworkManager NativeNetworkManager
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CNativeNetworkManager_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CNativeNetworkManager_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public ISystemUsernameProvider UsernameProvider
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CUsernameProvider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBC")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CUsernameProvider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public IProfanityFilterer ProfanityFilterer
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CProfanityFilterer_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CProfanityFilterer_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public IPlayerPrefs PlayerPrefs
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayerPrefs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CPlayerPrefs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public NativeShopManagerBase NativeShopManager
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC1")]
			[Cpp2IlInjected.Address(RVA = "0xF14440", Offset = "0xF12E40", VA = "0x180F14440")]
			get
			{
				NativeShopManagerBase nativeShopManager = _nativeShopManager;
				if (nativeShopManager == null)
				{
					CreateNativeShopManager();
				}
				return nativeShopManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		private PlatformInterfaceManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0xF13DB0", Offset = "0xF127B0", VA = "0x180F13DB0")]
		private void CreateNativeShopManager()
		{
			//IL_0043: Expected O, but got I4
			int num = 0;
			int num2 = (int)Application.platform;
			if (num2 > 11 && num2 != 25 && num2 != 27)
			{
				num2 += -32;
				if (num2 > 6)
				{
					goto IL_0032;
				}
			}
			if (num2 <= 8)
			{
				int num3 = 0;
				string pcStore = PlatformUtils.GetPcStore();
			}
			if (num2 != 11)
			{
			}
			goto IL_0032;
			IL_0032:
			int num4 = 0;
			RuntimePlatform platform = Application.platform;
			string text = ((Enum)platform).ToString();
			RuntimePlatform runtimePlatform = platform;
			string nintendoSwitch = RuntimePlatformNames.NintendoSwitch;
			if (!text.Equals(nintendoSwitch))
			{
				string epic = RuntimePlatformNames.Epic;
				if (!text.Equals(epic))
				{
					string steam = RuntimePlatformNames.Steam;
					if (!text.Equals(steam))
					{
						string xBox = RuntimePlatformNames.XBox;
						if (!text.Equals(xBox))
						{
							string windowsStore = RuntimePlatformNames.WindowsStore;
							if (!text.Equals(windowsStore))
							{
								string playstation = RuntimePlatformNames.Playstation;
								if (!text.Equals(playstation))
								{
									string macAppStore = RuntimePlatformNames.MacAppStore;
									if (text.Equals(macAppStore))
									{
										AppleNativeShopManager appleNativeShopManager = (AppleNativeShopManager)(_nativeShopManager = new AppleNativeShopManager());
									}
									return;
								}
								PlaystationNativeShopManager playstationNativeShopManager = new PlaystationNativeShopManager();
							}
						}
						GameCoreNativeShopManager gameCoreNativeShopManager = new GameCoreNativeShopManager();
					}
					SteamNativeShopManager steamNativeShopManager = new SteamNativeShopManager();
				}
				EpicNativeShopManager epicNativeShopManager = new EpicNativeShopManager();
			}
			SwitchNativeShopManager switchNativeShopManager = (SwitchNativeShopManager)(_nativeShopManager = new SwitchNativeShopManager(SwitchNativeShopManager.DDVApplicationID));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static PlatformInterfaceManager()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
