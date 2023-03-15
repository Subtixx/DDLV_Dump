using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface IProfile
	{
		[Cpp2IlInjected.Token(Token = "0x1700032D")]
		IProfilePlayer ProfilePlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000D43")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032E")]
		IProfileWorld ProfileWorld
		{
			[Cpp2IlInjected.Token(Token = "0x6000D44")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032F")]
		string Country
		{
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000330")]
		DeviceInfo DeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000331")]
		Item HangingOutWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IsHangingOutWith(Item item);

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(Slot = "6")]
		TimeSpan GetTimer(ProfileTimerType timerType);
	}
}
