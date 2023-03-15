using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	public class LiveopsItemProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000171")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000493")]
		public int MaxUses
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000494")]
		public RefreshUseType RefreshType
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000495")]
		public int RefreshHour
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public string GameType
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CGameType_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CGameType_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public JObject GameData
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CGameData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CGameData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x1033590", Offset = "0x1031F90", VA = "0x181033590")]
		public int GetRefreshUseCount(DateTime utcNow, DateTime lastRefresh)
		{
			TimeSpan timeSpan = utcNow - lastRefresh;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x10334C0", Offset = "0x1031EC0", VA = "0x1810334C0")]
		public DateTime GetRefreshTime(DateTime utcNow)
		{
			int num = 0;
			bool flag = default(bool);
			DateTime result = default(DateTime);
			if (flag)
			{
				return result;
			}
			DateTime result2 = default(DateTime);
			return result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x10333E0", Offset = "0x1031DE0", VA = "0x1810333E0")]
		public DateTime GetPreviousRefreshTime(DateTime utcNow)
		{
			int num = 0;
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			DateTime result = default(DateTime);
			if (dateTime > dateTime2)
			{
				return result;
			}
			return dateTime;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LiveopsItemProperties()
		{
		}
	}
}
