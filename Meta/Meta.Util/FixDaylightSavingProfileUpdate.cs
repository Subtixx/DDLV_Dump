using System;
using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B01")]
	internal class FixDaylightSavingProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DD9")]
		[Cpp2IlInjected.Address(RVA = "0x1802060", Offset = "0x1800A60", VA = "0x181802060", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_002e
			DateTime dateTime = profile.gameInfo_.created_.ToDateTime();
			int num = 0;
			if (TimeZoneInfo.Local.IsDaylightSavingTime(dateTime))
			{
				profile.world_.timeZoneOffsetIsDST_ = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DDA")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public FixDaylightSavingProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
