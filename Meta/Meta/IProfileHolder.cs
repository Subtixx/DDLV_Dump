using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200098B")]
	public interface IProfileHolder
	{
		[Cpp2IlInjected.Token(Token = "0x17000E85")]
		Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x60053E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60053E3")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60053E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Reset(Func<Profile, ITransactionContext> createTransactionContext, ProfileEventDispatcher dispatcher, bool actualize);

		[Cpp2IlInjected.Token(Token = "0x60053E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<Profile> Reset(Func<Profile, ITransactionContext> createTransactionContext, ProfileEventDispatcher dispatcher, TimeSpan playerTimeZoneOffset, DeviceInfo deviceInfo, bool isDev, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60053E6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<LoadAndInitProfileResult> Load(Func<Profile, ITransactionContext> createTransactionContext, ProfileEventDispatcher dispatcher, TimeSpan playerTimeZoneOffset, DeviceInfo deviceInfo, bool isDev, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60053E7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task Save(Profile profile, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60053E8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task AskForSave(Profile profile, CancellationToken ct);
	}
}
