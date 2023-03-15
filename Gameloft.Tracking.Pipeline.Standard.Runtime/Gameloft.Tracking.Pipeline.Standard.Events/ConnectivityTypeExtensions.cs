using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Events
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ConnectivityTypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28BF3E0", Offset = "0x28BDDE0", VA = "0x1828BF3E0")]
		public static InternetReachabilityStatus ToReachability(this ConnectivityType connectivity)
		{
			do
			{
				int num = 0;
			}
			while (connectivity == ConnectivityType.Unknown);
			bool flag = connectivity == ConnectivityType.NoConnection;
			/*Error: Unexpected end of block*/;
		}
	}
}
