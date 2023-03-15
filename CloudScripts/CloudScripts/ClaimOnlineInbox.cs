using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public class ClaimOnlineInbox
	{
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public List<(string Id, string InstanceId)> Items
			{
				[Cpp2IlInjected.Token(Token = "0x6000357")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CItems_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CItems_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010F")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			CannotGetInventory,
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			MailboxKeyNotFound,
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			MissingRecipeLinkId,
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			RewardsFailedToApply,
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			Failed,
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			NoRewardGiven
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000092")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000523")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ClaimOnlineInbox()
		{
		}
	}
}
