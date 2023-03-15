using System;
using Cpp2IlInjected;
using Gameloft.Tracking.Service;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal interface IEtsServiceProtocol : IServiceProtocol, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event OnServiceControlStateHandler OnServiceBan;
	}
}
