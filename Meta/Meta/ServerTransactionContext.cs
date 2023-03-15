using System;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Server;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A63")]
	public class ServerTransactionContext : ITransactionContext, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400291C")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400291D")]
		private DateTime? UtcNow;

		[Cpp2IlInjected.Token(Token = "0x17000EC9")]
		public DateTime Now
		{
			[Cpp2IlInjected.Token(Token = "0x60059E1")]
			[Cpp2IlInjected.Address(RVA = "0x17748C0", Offset = "0x17732C0", VA = "0x1817748C0", Slot = "4")]
			get
			{
				DateTime? utcNow = UtcNow;
				bool flag = default(bool);
				if (flag)
				{
					ProfilePlayer player_ = profile.player_;
					if (player_ != null)
					{
						TimeSpan timeSpan = player_.debugTimeSkipped_.ToTimeSpan();
					}
					DateTime result = default(DateTime);
					return result;
				}
				ObjectDisposedException ex = new ObjectDisposedException("ServerTransactionContext", "ServerTransactionContext only gives a valid time during a transaction");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ECA")]
		public DateTime LocalNow
		{
			[Cpp2IlInjected.Token(Token = "0x60059E2")]
			[Cpp2IlInjected.Address(RVA = "0x1774700", Offset = "0x1773100", VA = "0x181774700", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0040
				ProfileWorld world_ = profile.world_;
				DateTime? utcNow = UtcNow;
				bool flag = default(bool);
				if (flag)
				{
					ProfilePlayer player_ = profile.player_;
					if (player_ != null)
					{
						TimeSpan timeSpan = player_.debugTimeSkipped_.ToTimeSpan();
					}
					DateTime serverTime = default(DateTime);
					return world_.GetClientLocalTime(serverTime);
				}
				ObjectDisposedException ex = new ObjectDisposedException("ServerTransactionContext", "ServerTransactionContext only gives a valid time during a transaction");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ECB")]
		public bool IsServer
		{
			[Cpp2IlInjected.Token(Token = "0x60059E3")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "6")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059E4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		internal ServerTransactionContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60059E5")]
		[Cpp2IlInjected.Address(RVA = "0x17745E0", Offset = "0x1772FE0", VA = "0x1817745E0")]
		internal ServerTransactionContext PrepareForTransaction(Profile profile, CallContext callContext)
		{
			//Discarded unreachable code: IL_003a
			//IL_0038: Expected O, but got I4
			MetadataCollection _003CRequestMetadata_003Ek__BackingField = callContext.RequestMetadata;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				callContext.RequestMetadata.Add("TransactionTime", utcNow);
			}
			this.profile = profile;
			int num2 = 0;
			UtcNow = (DateTime?)(object)num2;
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x60059E6")]
		[Cpp2IlInjected.Address(RVA = "0x17746F0", Offset = "0x17730F0", VA = "0x1817746F0", Slot = "7")]
		void IDisposable.Dispose()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			UtcNow = (DateTime?)(object)num;
		}
	}
}
