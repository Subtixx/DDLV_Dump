using System;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Storage;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface IScopeablePersistentStorage : IClosablePersistentStorage, IPersistentStorage, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		EventScope EventScope
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
}
