using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public class FakeProfile : IProfile
	{
		[Cpp2IlInjected.Token(Token = "0x1700033A")]
		public IProfilePlayer ProfilePlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000D82")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003CProfilePlayer_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D83")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CProfilePlayer_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new FakeProfilePlayer
		{
			MemoryShards = (MapField<int, int>)(object)new MapField<TKey, TValue>()
		};


		[Cpp2IlInjected.Token(Token = "0x1700033B")]
		public IProfileWorld ProfileWorld
		{
			[Cpp2IlInjected.Token(Token = "0x6000D84")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return _003CProfileWorld_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D85")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CProfileWorld_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new FakeProfileWorld();


		[Cpp2IlInjected.Token(Token = "0x1700033C")]
		public string Country
		{
			[Cpp2IlInjected.Token(Token = "0x6000D86")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3060", Offset = "0x2CA1A60", VA = "0x182CA3060", Slot = "6")]
			get
			{
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033D")]
		public DeviceInfo DeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000D87")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3090", Offset = "0x2CA1A90", VA = "0x182CA3090", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_0032
				//IL_001a: Expected I4, but got I8
				DeviceInfo deviceInfo = new DeviceInfo();
				deviceInfo.DeviceID = "fakedeviceid";
				deviceInfo.deviceType_ = DeviceType.Unknown;
				deviceInfo.DeviceName = "fakename";
				deviceInfo.DeviceModel = "";
				return deviceInfo;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033E")]
		public Item HangingOutWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6000D88")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3140", Offset = "0x2CA1B40", VA = "0x182CA3140", Slot = "8")]
			get
			{
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D89")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "9")]
		public bool IsHangingOutWith(Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D8A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2F20", Offset = "0x2CA1920", VA = "0x182CA2F20", Slot = "10")]
		public TimeSpan GetTimer(ProfileTimerType timerType)
		{
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D8B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2F60", Offset = "0x2CA1960", VA = "0x182CA2F60")]
		public FakeProfile()
		{
		}
	}
}
