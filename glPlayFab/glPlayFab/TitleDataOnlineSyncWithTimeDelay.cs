using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class TitleDataOnlineSyncWithTimeDelay : ITitleDataOnlineSyncCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private DateTime LastUpdateTime = DateTime.MinValue;

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000345")]
		public TimeSpan SyncTimeDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB0", Offset = "0x6E44B0", VA = "0x1806E5AB0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public bool RequiresOnlineSync
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x14F8370", Offset = "0x14F6D70", VA = "0x1814F8370", Slot = "4")]
			get
			{
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				DateTime lastUpdateTime = LastUpdateTime;
				TimeSpan timeSpan = utcNow - lastUpdateTime;
				TimeSpan timeSpan2 = SyncTimeDelay;
				return timeSpan > timeSpan2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public bool IsUpToDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x14F82C0", Offset = "0x14F6CC0", VA = "0x1814F82C0", Slot = "5")]
			get
			{
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				DateTime lastUpdateTime = LastUpdateTime;
				TimeSpan timeSpan = utcNow - lastUpdateTime;
				TimeSpan timeSpan2 = SyncTimeDelay;
				return !(timeSpan > timeSpan2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x14F81F0", Offset = "0x14F6BF0", VA = "0x1814F81F0", Slot = "6")]
		public void ConfirmOnlineSync()
		{
			int num = 0;
			DateTime dateTime = (LastUpdateTime = DateTime.UtcNow);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x14F8250", Offset = "0x14F6C50", VA = "0x1814F8250")]
		public TitleDataOnlineSyncWithTimeDelay()
		{
		}
	}
}
