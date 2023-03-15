using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC4")]
	internal abstract class ProfileConditionalUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AF5")]
		private readonly string updateName;

		[Cpp2IlInjected.Token(Token = "0x6005D4B")]
		[Cpp2IlInjected.Address(RVA = "0x5C7440", Offset = "0x5C5E40", VA = "0x1805C7440")]
		protected ProfileConditionalUpdate(string updateName)
		{
			((BattlePassReward)(object)this)._002Ector();
			this.updateName = updateName;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D4C")]
		[Cpp2IlInjected.Address(RVA = "0x94F4F0", Offset = "0x94DEF0", VA = "0x18094F4F0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
