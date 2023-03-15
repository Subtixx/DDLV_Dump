using System;
using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Events;

namespace Gameloft.Tracking.Pipeline.Standard
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class ConnectivityStatusProvider : IInternetReachabilityStatusProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Tracker tracker;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public InternetReachabilityStatus CurrentStatus
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x28BF3B0", Offset = "0x28BDDB0", VA = "0x1828BF3B0", Slot = "4")]
			get
			{
				ConnectivityType _003CConnectivity_003Ek__BackingField = tracker.Connectivity;
				int num = 0;
				if (_003CConnectivity_003Ek__BackingField != ConnectivityType.Unknown)
				{
					bool flag = _003CConnectivity_003Ek__BackingField == ConnectivityType.NoConnection;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28BF320", Offset = "0x28BDD20", VA = "0x1828BF320")]
		public ConnectivityStatusProvider(Tracker trackerInstance)
		{
			if (trackerInstance != null)
			{
				tracker = trackerInstance;
			}
			ArgumentNullException ex = new ArgumentNullException("trackerInstance");
			/*Error: Unexpected end of block*/;
		}
	}
}
