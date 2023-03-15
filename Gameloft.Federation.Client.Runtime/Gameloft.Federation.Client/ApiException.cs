using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ApiException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x40324B0", Offset = "0x4030EB0", VA = "0x1840324B0")]
		public ApiException(int errorCode, string message, Exception innerException)
			: base(message, innerException)
		{
			_003CErrorCode_003Ek__BackingField = errorCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4032410", Offset = "0x4030E10", VA = "0x184032410")]
		public ApiException(int errorCode, string message, [Optional] object errorContent)
			: base(message)
		{
			_003CErrorCode_003Ek__BackingField = errorCode;
			_003CErrorContent_003Ek__BackingField = errorContent;
			/*Error: Unexpected end of block*/;
		}
	}
}
