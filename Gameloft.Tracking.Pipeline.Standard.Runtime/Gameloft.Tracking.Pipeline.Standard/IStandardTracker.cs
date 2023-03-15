using System;
using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Events;

namespace Gameloft.Tracking.Pipeline.Standard
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IStandardTracker : ITracker, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		ConnectivityType Connectivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
}
