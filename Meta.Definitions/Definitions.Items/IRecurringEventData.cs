using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000661")]
	public interface IRecurringEventData : IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17001334")]
		bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6004A62")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001335")]
		RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6004A63")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001336")]
		bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6004A64")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
