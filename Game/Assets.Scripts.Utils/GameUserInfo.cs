using Cpp2IlInjected;
using Definitions;
using EpicSdk.Service;
using Mdl.Platform;
using Steamworks;

namespace Assets.Scripts.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	internal class GameUserInfo : IUserInfo
	{
		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x8C1310", Offset = "0x8BFD10", VA = "0x1808C1310", Slot = "4")]
			get
			{
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public string UserIdOtherPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x8C1280", Offset = "0x8BFC80", VA = "0x1808C1280", Slot = "5")]
			get
			{
				int num = 0;
				bool flag = PlatformUtils.UseEpic();
				int num2 = 0;
				if (!flag)
				{
					if (!PlatformUtils.UseSteam())
					{
						return "";
					}
					int num3 = 0;
					CSteamID steamID = SteamUser.GetSteamID();
				}
				EpicSdkService instance = EpicSdkService.Instance;
				if ((object)instance == null || instance.UserId == null)
				{
				}
				return "N/A";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GameUserInfo()
		{
		}
	}
}
