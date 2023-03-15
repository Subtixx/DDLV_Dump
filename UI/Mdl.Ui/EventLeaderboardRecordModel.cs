using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000459")]
	public class EventLeaderboardRecordModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015F4")]
		public FakeLeaderboardRecordModel RawFakeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015F5")]
		public int Rank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015F6")]
		public string PlayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015F7")]
		public int PlayerLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40015F8")]
		public int Score;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015F9")]
		public float ScoreRatio;

		[Cpp2IlInjected.Token(Token = "0x6001C1E")]
		[Cpp2IlInjected.Address(RVA = "0x13FC9A0", Offset = "0x13FB3A0", VA = "0x1813FC9A0")]
		public void Refresh(FakeLeaderboardRecordModel fakeData, float scoreRatio)
		{
			//Discarded unreachable code: IL_0046
			RawFakeData = fakeData;
			string text = (PlayerName = RawFakeData.Player.Name);
			int _003CLevel_003Ek__BackingField = RawFakeData.Player.Level;
			ScoreRatio = scoreRatio;
			PlayerLevel = _003CLevel_003Ek__BackingField;
			Score = _003CLevel_003Ek__BackingField;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C1F")]
		[Cpp2IlInjected.Address(RVA = "0x13FC980", Offset = "0x13FB380", VA = "0x1813FC980")]
		public void Refresh()
		{
			//IL_0012: Expected I4, but got O
			FakeLeaderboardRecordModel rawFakeData = RawFakeData;
			if (rawFakeData != null)
			{
				Score = (int)rawFakeData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C20")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EventLeaderboardRecordModel()
		{
		}
	}
}
