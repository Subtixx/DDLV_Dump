using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Meta.Social;
using UnityEngine;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x200038A")]
	public class OnlineProfileComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200038B")]
		public delegate void InboxChanged();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400181D")]
		private DateTime lastInboxCheckTimeStamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400181F")]
		private Task<GetInbox.Types.Response> refreshTask;

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		private Meta.Online.Client client
		{
			[Cpp2IlInjected.Token(Token = "0x6000F39")]
			[Cpp2IlInjected.Address(RVA = "0xF051D0", Offset = "0xF03BD0", VA = "0x180F051D0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public OnlineProfile OnlineProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6000F3A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003COnlineProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000F3B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003COnlineProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public Inbox ProfileInbox
		{
			[Cpp2IlInjected.Token(Token = "0x6000F3E")]
			[Cpp2IlInjected.Address(RVA = "0xF05100", Offset = "0xF03B00", VA = "0x180F05100")]
			get
			{
				//Discarded unreachable code: IL_001a
				return SystemRoot.Instance.MetaClient.profile.player_.inbox_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public bool IsInboxReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000F3F")]
			[Cpp2IlInjected.Address(RVA = "0xF050A0", Offset = "0xF03AA0", VA = "0x180F050A0")]
			get
			{
				//IL_0010: Expected O, but got I4
				DateTime dateTime = lastInboxCheckTimeStamp;
				int num = 0;
				return dateTime != (DateTime)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public bool IsInboxOutdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000F40")]
			[Cpp2IlInjected.Address(RVA = "0xF04F80", Offset = "0xF03980", VA = "0x180F04F80")]
			get
			{
				//IL_0010: Expected O, but got I4
				DateTime dateTime = lastInboxCheckTimeStamp;
				int num = 0;
				if (!(dateTime != (DateTime)num))
				{
					return true;
				}
				int num2 = 0;
				DateTime utcNow = DateTime.UtcNow;
				DateTime dateTime2 = default(DateTime);
				return dateTime2 < utcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event InboxChanged OnInboxChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000F3C")]
			[Cpp2IlInjected.Address(RVA = "0xF04EE0", Offset = "0xF038E0", VA = "0x180F04EE0")]
			[CompilerGenerated]
			add
			{
				InboxChanged onInboxChanged = this.OnInboxChanged;
				Delegate @delegate = Delegate.Combine(onInboxChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInboxChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000F3D")]
			[Cpp2IlInjected.Address(RVA = "0xF05280", Offset = "0xF03C80", VA = "0x180F05280")]
			[CompilerGenerated]
			remove
			{
				InboxChanged onInboxChanged = this.OnInboxChanged;
				Delegate @delegate = Delegate.Remove(onInboxChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInboxChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F41")]
		[Cpp2IlInjected.Address(RVA = "0xF03F90", Offset = "0xF02990", VA = "0x180F03F90")]
		[AsyncStateMachine(typeof(_003CHasUnreadMessages_003Ed__18))]
		public Task<bool> HasUnreadMessages(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F42")]
		[Cpp2IlInjected.Address(RVA = "0xF04BF0", Offset = "0xF035F0", VA = "0x180F04BF0")]
		public void Start()
		{
			//Discarded unreachable code: IL_0033
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.OnlineConnectionChanged value = OnOnlineConnectionChanged;
				metaOnlineClient.OnOnlineConnectionChanged += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F43")]
		[Cpp2IlInjected.Address(RVA = "0xF040D0", Offset = "0xF02AD0", VA = "0x180F040D0", Slot = "4")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_0033
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.OnlineConnectionChanged value = OnOnlineConnectionChanged;
				metaOnlineClient.OnOnlineConnectionChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0xF04280", Offset = "0xF02C80", VA = "0x180F04280")]
		[AsyncStateMachine(typeof(_003COnOnlineConnectionChanged_003Ed__21))]
		private void OnOnlineConnectionChanged(Profile profile, bool isLoggedIn, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0xF04860", Offset = "0xF03260", VA = "0x180F04860")]
		[AsyncStateMachine(typeof(_003CRefreshInbox_003Ed__22))]
		public Task<IList<InboxMessage>> RefreshInbox(CancellationToken ct, bool forceRefresh = false, bool skipRedeem = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<IList<InboxMessage>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0xF03E40", Offset = "0xF02840", VA = "0x180F03E40")]
		[AsyncStateMachine(typeof(_003CGetAllInboxRewards_003Ed__23))]
		public Task<Dictionary<int, int>> GetAllInboxRewards(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Dictionary<int, int>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F47")]
		[Cpp2IlInjected.Address(RVA = "0xF044B0", Offset = "0xF02EB0", VA = "0x180F044B0")]
		[AsyncStateMachine(typeof(_003CReadInboxMessage_003Ed__24))]
		public Task ReadInboxMessage(InboxMessageKey messageKey, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0xF04390", Offset = "0xF02D90", VA = "0x180F04390")]
		[AsyncStateMachine(typeof(_003CReadAllInboxMessages_003Ed__25))]
		public Task ReadAllInboxMessages(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0xF045E0", Offset = "0xF02FE0", VA = "0x180F045E0")]
		[AsyncStateMachine(typeof(_003CReadInboxMessages_003Ed__26))]
		public Task ReadInboxMessages(List<InboxMessageKey> messageKeys, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
		[Cpp2IlInjected.Address(RVA = "0xF03B60", Offset = "0xF02560", VA = "0x180F03B60")]
		[AsyncStateMachine(typeof(_003CClaimInboxMessage_003Ed__27))]
		public Task<ClaimInboxMessages.Types.Result> ClaimInboxMessage(InboxMessageKey messageKey, bool autoClaim, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimInboxMessages.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0xF03A10", Offset = "0xF02410", VA = "0x180F03A10")]
		[AsyncStateMachine(typeof(_003CClaimAllInboxMessages_003Ed__28))]
		public Task<ClaimInboxMessages.Types.Result> ClaimAllInboxMessages(bool autoClaim, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimInboxMessages.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4C")]
		[Cpp2IlInjected.Address(RVA = "0xF03CD0", Offset = "0xF026D0", VA = "0x180F03CD0")]
		[AsyncStateMachine(typeof(_003CClaimInboxMessages_003Ed__29))]
		public Task<ClaimInboxMessages.Types.Result> ClaimInboxMessages(List<InboxMessageKey> messageKeys, bool autoClaim, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimInboxMessages.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4D")]
		[Cpp2IlInjected.Address(RVA = "0xF049D0", Offset = "0xF033D0", VA = "0x180F049D0")]
		public Task<RefundInboxMessages.Types.Result> RefundInboxMessage(InboxMessageKey messageKey, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0016
			List<InboxMessageKey> list = (List<InboxMessageKey>)(object)new List<T>();
			((List<T>)(object)list).Add((T)messageKey);
			return (Task<RefundInboxMessages.Types.Result>)(object)this.RefundInboxMessages((List<>)(object)list, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4E")]
		[Cpp2IlInjected.Address(RVA = "0xF049C0", Offset = "0xF033C0", VA = "0x180F049C0")]
		public Task<RefundInboxMessages.Types.Result> RefundAllInboxMessages(CancellationToken ct)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			return (Task<RefundInboxMessages.Types.Result>)(object)this.RefundInboxMessages((List<>)num, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4F")]
		[Cpp2IlInjected.Address(RVA = "0xF04A90", Offset = "0xF03490", VA = "0x180F04A90")]
		[AsyncStateMachine(typeof(_003CRefundInboxMessages_003Ed__32))]
		public Task<RefundInboxMessages.Types.Result> RefundInboxMessages(List<InboxMessageKey> messageKeys, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<RefundInboxMessages.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F50")]
		[Cpp2IlInjected.Address(RVA = "0xF04DA0", Offset = "0xF037A0", VA = "0x180F04DA0")]
		[AsyncStateMachine(typeof(_003CSyncOnlineCurrencies_003Ed__33))]
		public Task<SyncOnlineCurrencies.Types.Response> SyncOnlineCurrencies(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<SyncOnlineCurrencies.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F51")]
		[Cpp2IlInjected.Address(RVA = "0xF04710", Offset = "0xF03110", VA = "0x180F04710")]
		[AsyncStateMachine(typeof(_003CRefreshInboxInternal_003Ed__34))]
		private Task<bool> RefreshInboxInternal(bool skipRedeem, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F52")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public OnlineProfileComponent()
		{
		}
	}
}
