using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public class CheckEpicLinkingStatus
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public string PlayFabID
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabID_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabID_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			PlayFabError
		}

		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		public enum Status
		{
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			Unchecked,
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			NotLinked,
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			Linked
		}

		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40004EA")]
			public Status Status
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40004EB")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40004EC")]
			public PlayFabErrorCode PlayFabErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x1170B00", Offset = "0x116F500", VA = "0x181170B00")]
			public Result WithPlayFabError(PlayFabErrorCode playfabError)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.PlayFabError;
				PlayFabErrorCode = playfabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CheckEpicLinkingStatus()
		{
		}
	}
}
