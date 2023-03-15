using Cpp2IlInjected;
using Gameloft.Rpc.Core.Client;
using StoreFrontEnums;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000EFF")]
	public interface IUnityContext
	{
		[Cpp2IlInjected.Token(Token = "0x17001572")]
		bool IsPlatformConsole
		{
			[Cpp2IlInjected.Token(Token = "0x6007BC4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001573")]
		bool IsPlatformXbox
		{
			[Cpp2IlInjected.Token(Token = "0x6007BC5")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001574")]
		bool IsPlatformPlayStation
		{
			[Cpp2IlInjected.Token(Token = "0x6007BC6")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001575")]
		bool IsPlatformSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6007BC7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001576")]
		bool IsForcedOffline
		{
			[Cpp2IlInjected.Token(Token = "0x6007BC9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001577")]
		ForceOfflineReasonFlag ForceOfflineReasonFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6007BCA")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001578")]
		bool IsDebugBuildType
		{
			[Cpp2IlInjected.Token(Token = "0x6007BCB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BC0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string GetAvatarPosition();

		[Cpp2IlInjected.Token(Token = "0x6007BC1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string GetDeviceName();

		[Cpp2IlInjected.Token(Token = "0x6007BC2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string GetPlatformName();

		[Cpp2IlInjected.Token(Token = "0x6007BC3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PlayfabNativeAuth GetRuntimePlayfabNativeAuth();

		[Cpp2IlInjected.Token(Token = "0x6007BC8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AddUnityInterceptor(HostBuilder builderClient);
	}
}
