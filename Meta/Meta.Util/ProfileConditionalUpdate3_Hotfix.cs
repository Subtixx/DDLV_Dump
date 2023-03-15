using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B20")]
	internal class ProfileConditionalUpdate3_Hotfix : ProfileConditionalUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E27")]
		[Cpp2IlInjected.Address(RVA = "0x94E500", Offset = "0x94CF00", VA = "0x18094E500")]
		public ProfileConditionalUpdate3_Hotfix()
		{
			((BattlePassReward)(object)this)._002Ector();
			base.updateName = "ProfileUpdate3_Hotfix";
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E28")]
		[Cpp2IlInjected.Address(RVA = "0x94E4E0", Offset = "0x94CEE0", VA = "0x18094E4E0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			base.DoApplyProfile(profile);
			ProfileConditionalUpdate3.FixUniqueHerringIssue(profile);
		}
	}
}
