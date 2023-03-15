using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000457")]
	public class EventContentLeaderboardModel : EventContentModelBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015EA")]
		public EventLeaderboardRecordModel PlayerRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015EB")]
		public List<EventLeaderboardRecordModel> Records;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015EC")]
		public List<EventLeaderboardRewardModel> Rewards;

		[Cpp2IlInjected.Token(Token = "0x6001C1C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EventContentLeaderboardModel()
		{
		}
	}
}
