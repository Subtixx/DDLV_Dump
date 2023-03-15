using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000839")]
	public class FakeLeaderboardDataModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000753")]
		public List<FakeLeaderboardRecordModel> FakeRecords
		{
			[Cpp2IlInjected.Token(Token = "0x6003437")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CFakeRecords_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003438")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CFakeRecords_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000754")]
		public List<FakeEventLeaderboardRewardModel> FakeRewards
		{
			[Cpp2IlInjected.Token(Token = "0x6003439")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CFakeRewards_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600343A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CFakeRewards_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000755")]
		public FakeLeaderboardRecordModel FakePlayerRecord
		{
			[Cpp2IlInjected.Token(Token = "0x600343B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CFakePlayerRecord_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600343C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CFakePlayerRecord_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000756")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400308E")]
		public int FakeGodPlayerNum
		{
			[Cpp2IlInjected.Token(Token = "0x600343D")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600343E")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000757")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x400308F")]
		public float FakeLightPlayerRatio
		{
			[Cpp2IlInjected.Token(Token = "0x600343F")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003440")]
			[Cpp2IlInjected.Address(RVA = "0xE3ABE0", Offset = "0xE395E0", VA = "0x180E3ABE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000758")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4003090")]
		public float FakeHardcorePlayerRatio
		{
			[Cpp2IlInjected.Token(Token = "0x6003441")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003442")]
			[Cpp2IlInjected.Address(RVA = "0xDD7740", Offset = "0xDD6140", VA = "0x180DD7740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000759")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4003091")]
		public int FakeScoreMax
		{
			[Cpp2IlInjected.Token(Token = "0x6003443")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003444")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700075A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4003092")]
		public float FakeScoreRatio
		{
			[Cpp2IlInjected.Token(Token = "0x6003445")]
			[Cpp2IlInjected.Address(RVA = "0xA82BB0", Offset = "0xA815B0", VA = "0x180A82BB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003446")]
			[Cpp2IlInjected.Address(RVA = "0xA82CD0", Offset = "0xA816D0", VA = "0x180A82CD0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700075B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4003093")]
		public int FakeVirtualPlayerNum
		{
			[Cpp2IlInjected.Token(Token = "0x6003447")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003448")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003449")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FakeLeaderboardDataModel()
		{
		}
	}
}
