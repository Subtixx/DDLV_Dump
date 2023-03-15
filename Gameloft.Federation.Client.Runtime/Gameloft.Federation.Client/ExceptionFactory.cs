using System;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}
