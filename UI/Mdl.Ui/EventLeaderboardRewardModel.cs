using Cpp2IlInjected;
using Definitions.Rewards;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000458")]
	public class EventLeaderboardRewardModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015ED")]
		public FakeEventLeaderboardRewardModel RawFakeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015EE")]
		public int RankRangeMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40015EF")]
		public int RankRangeMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015F0")]
		public ItemReward Reward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015F1")]
		public int BackgroundGradientStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40015F2")]
		public int BackgroundGradientEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015F3")]
		public bool HasClaimed;

		[Cpp2IlInjected.Token(Token = "0x6001C1D")]
		[Cpp2IlInjected.Address(RVA = "0x13FD6C0", Offset = "0x13FC0C0", VA = "0x1813FD6C0")]
		public EventLeaderboardRewardModel(FakeEventLeaderboardRewardModel fakeData)
		{
			//Discarded unreachable code: IL_0069
			RawFakeData = fakeData;
			int num = (RankRangeMin = fakeData.RankRangeMin);
			int num2 = (RankRangeMax = fakeData.RankRangeMax);
			int num3 = (BackgroundGradientStart = fakeData.BackgroundGradientStart);
			int num4 = (BackgroundGradientEnd = fakeData.BackgroundGradientEnd);
			int _003CRewardItemId_003Ek__BackingField = fakeData.RewardItemId;
			_003CRewardItemId_003Ek__BackingField = num4;
			ItemReward reward = default(ItemReward);
			Reward = reward;
			bool flag = (HasClaimed = fakeData.HasClaimed);
		}
	}
}
