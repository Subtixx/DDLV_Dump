using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public class CollectLootPresent
	{
		[Cpp2IlInjected.Token(Token = "0x200011A")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000099")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000545")]
			public int GameItemId
			{
				[Cpp2IlInjected.Token(Token = "0x6000374")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000375")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011B")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			ItemNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			KeyNotFound,
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			GetInventoryFailed,
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			InvalidChestProperties,
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			GrantChestKeyFailed,
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			GetRewardsMetadataFailed,
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			RewardsFailedToApply,
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x200011C")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000550")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000551")]
			public PlayFabErrorCode PlayFabErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600037A")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public List<(int id, int amount)> Rewards
			{
				[Cpp2IlInjected.Token(Token = "0x600037B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CRewards_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600037C")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CRewards_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x1170AD0", Offset = "0x116F4D0", VA = "0x181170AD0")]
			public Result WithError(Error error)
			{
				//IL_0010: Expected I4, but got I8
				Error = error;
				PlayFabErrorCode = PlayFabErrorCode.Unknown;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x1170AF0", Offset = "0x116F4F0", VA = "0x181170AF0")]
			public Result WithPlayFabError(Error error, PlayFabErrorCode playfabError)
			{
				Error = error;
				PlayFabErrorCode = playfabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectLootPresent()
		{
		}
	}
}
