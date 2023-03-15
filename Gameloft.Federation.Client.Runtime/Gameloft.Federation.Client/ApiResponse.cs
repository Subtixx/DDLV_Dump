using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ApiResponse<T> : IApiResponse
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4000022")]
		public HttpStatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670", Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Multimap<string, string> Headers
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public T Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ErrorText
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "7")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public List<Cookie> Cookies
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "8")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string RawContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "5")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1C9ABE0", Offset = "0x1C995E0", VA = "0x181C9ABE0")]
		public ApiResponse(HttpStatusCode statusCode, Multimap<string, string> headers, T data, string rawContent)
		{
			((ApiResponse<>)(object)this).StatusCode = statusCode;
			throw new NullReferenceException();
		}
	}
}
