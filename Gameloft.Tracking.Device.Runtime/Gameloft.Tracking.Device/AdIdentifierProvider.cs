using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class AdIdentifierProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static AdIdentifierStatus authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AdIdentifierStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x402B4A0", Offset = "0x4029EA0", VA = "0x18402B4A0")]
			get
			{
				AdIdentifierStatus adIdentifierStatus = authorizationStatus;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event EventHandler<AdIdentifierStatus> OnAuthorizationStatusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x402B3A0", Offset = "0x4029DA0", VA = "0x18402B3A0")]
			[CompilerGenerated]
			add
			{
				EventHandler<AdIdentifierStatus> onAuthorizationStatusChanged = AdIdentifierProvider.OnAuthorizationStatusChanged;
				Delegate @delegate = Delegate.Combine(onAuthorizationStatusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAuthorizationStatusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x402B510", Offset = "0x4029F10", VA = "0x18402B510")]
			[CompilerGenerated]
			remove
			{
				EventHandler<AdIdentifierStatus> onAuthorizationStatusChanged = AdIdentifierProvider.OnAuthorizationStatusChanged;
				Delegate @delegate = Delegate.Remove(onAuthorizationStatusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAuthorizationStatusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x402B320", Offset = "0x4029D20", VA = "0x18402B320")]
		static AdIdentifierProvider()
		{
			authorizationStatus = AdIdentifierStatus.Null;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public static void RefreshStatus()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
