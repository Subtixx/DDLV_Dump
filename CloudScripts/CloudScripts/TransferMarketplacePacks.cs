using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.EconomyModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public class TransferMarketplacePacks
	{
		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public string SourceEntityToken
			{
				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CSourceEntityToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CSourceEntityToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public string GameloftIdLink
			{
				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CGameloftIdLink_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CGameloftIdLink_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			InvalidSourceEntityToken,
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			MissingGameloftIdLink,
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			GetUserAccountInfoFailed,
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			GameloftIdMismatch,
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			GetInventoryMarketplacePurchasesFailed,
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			NoPacksFound,
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			TransferFailed,
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			ResetFailed,
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public class ServerResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public Result ClientResult = new Result
			{
				Error = Error.Success
			};

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public string SourceEntityId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public List<InventoryItemResponseDto> GrantedItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public List<InventoryItemResponseDto> RemovedItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public List<InventoryItemResponseDto> RollbackItems;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x3930420", Offset = "0x392EE20", VA = "0x183930420")]
			public ServerResult WithError(Error error)
			{
				//Discarded unreachable code: IL_000e
				ClientResult.Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x3930440", Offset = "0x392EE40", VA = "0x183930440")]
			public ServerResult()
			{
			}//Discarded unreachable code: IL_001d
			//IL_000f: Expected I4, but got I8

		}

		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000042")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400045C")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TransferMarketplacePacks()
		{
			((ArraySegment<T>.ArraySegmentEnumerator)this).Dispose();
		}
	}
}
