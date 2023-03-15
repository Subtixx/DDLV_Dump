using System;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AF0")]
	internal class UpdateInboxMsgExpiration : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DB3")]
		[Cpp2IlInjected.Address(RVA = "0x15DA9D0", Offset = "0x15D93D0", VA = "0x1815DA9D0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0038
			RepeatedField<InboxMessage> inboxMessages_ = profile.player_.inbox_.inboxMessages_;
			Action<InboxMessage> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(InboxMessage x)
				{
					//Discarded unreachable code: IL_006b
					if (x.IsOnline && x.IsClaimable)
					{
						DateTime dateTime = x.deletionDate_.ToDateTime();
						DateTime dateTime2 = x.creationDate_.ToDateTime();
						TimeSpan timeSpan = default(TimeSpan);
						if (dateTime - dateTime2 < timeSpan)
						{
							TimeSpan timeSpan2 = default(TimeSpan);
							Timestamp timestamp = (x.expirationDate_ = (x.creationDate_.ToDateTime() + timeSpan2).ToProto());
							Timestamp timestamp2 = (x.deletionDate_ = x.expirationDate_);
						}
					}
				};
			}
			((RepeatedField<>)(object)inboxMessages_).ForEach<InboxMessage>((Action<>)(object)_003C_003E9__0_);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB4")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public UpdateInboxMsgExpiration()
		{
			((glPlayFab.Disney.BattlePassReward)(object)this)._002Ector();
		}
	}
}
