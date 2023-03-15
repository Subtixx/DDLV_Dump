using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public class FollowUser
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public string PlayFabId
			{
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public string TitleId
			{
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CTitleId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CTitleId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40004FA")]
			public bool Unfollow
			{
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			InvalidArguments,
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			UserNotFound,
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			FollowerProfileNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			FollowerProfileUpdateFailed,
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000086")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000502")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000334")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FollowUser()
		{
		}
	}
}
