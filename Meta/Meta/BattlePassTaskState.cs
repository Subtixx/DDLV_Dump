using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007DC")]
	public enum BattlePassTaskState
	{
		[Cpp2IlInjected.Token(Token = "0x4001F43")]
		[OriginalName("BattlePassTaskState_None")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4001F44")]
		[OriginalName("BattlePassTaskState_NotStarted")]
		NotStarted,
		[Cpp2IlInjected.Token(Token = "0x4001F45")]
		[OriginalName("BattlePassTaskState_OnGoing")]
		OnGoing,
		[Cpp2IlInjected.Token(Token = "0x4001F46")]
		[OriginalName("BattlePassTaskState_Completed")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x4001F47")]
		[OriginalName("BattlePassTaskState_CurrencyClaimed")]
		CurrencyClaimed
	}
}
