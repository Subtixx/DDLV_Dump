using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public class TLEProperties
	{
		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000504")]
		public int MaxTickets
		{
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public string GameType
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CGameType_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CGameType_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public JObject GameData
		{
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CGameData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CGameData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public List<TLEReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CRewards_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CRewards_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TLEProperties()
		{
		}
	}
}
