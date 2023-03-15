using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CollectBPTaskCurrency
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class Request : CloudscriptRequestWithCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public string TaskOnlineId
			{
				[Cpp2IlInjected.Token(Token = "0x6000002")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CTaskOnlineId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000003")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CTaskOnlineId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000002")]
			public int TaskIdx
			{
				[Cpp2IlInjected.Token(Token = "0x6000004")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			ConfigNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			InvalidStartOrEndDate,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			InvalidTaskConfig,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			InvalidTaskIndex,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			TaskUnavailable,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			EventEnded,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			SearchCurrencyError,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			GetCurrencyProgressError,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			PremiumPassInactive,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			AlreadyCollected,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			CollectCurrencyFailed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000003")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000010")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000011")]
			public int CurrencyBalance
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectBPTaskCurrency()
		{
		}
	}
}
