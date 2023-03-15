using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public class RefundOnlineInbox
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(string Id, string InstanceId)> Items
			{
				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CItems_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CItems_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000113")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			CannotGetInventory,
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			CannotGetKeyConfig,
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			MailboxKeyNotFound,
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			MissingRecipeLinkId,
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			CannotGetRecipeConfig,
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			CannotGetRecipeItems,
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			CannotGetRecipeItemConfigs,
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			RefundFailedToApply,
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			Failed,
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			NoRefundApplied
		}

		[Cpp2IlInjected.Token(Token = "0x2000114")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000094")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000531")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public List<(int Id, int amount)> RefundedItems
			{
				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CRefundedItems_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CRefundedItems_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RefundOnlineInbox()
		{
		}
	}
}
