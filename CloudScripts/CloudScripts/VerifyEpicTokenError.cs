using System.Net;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class VerifyEpicTokenError
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		public enum ErrorCode
		{
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			ResponseError,
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			ExceptionRaised,
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			Timeout,
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			TokenInactive,
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			ClientIdNotMatch,
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			AccountIdNotMatch,
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000472")]
		public HttpStatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000473")]
		public ErrorCode Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string ErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CErrorMessage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CErrorMessage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000475")]
		public PlayFabErrorCode PlayFabErrorCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public VerifyEpicTokenError()
		{
		}
	}
}
