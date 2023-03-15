using Cpp2IlInjected;
using Definitions;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AFA")]
	internal class SkinInventoryProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DCC")]
		[Cpp2IlInjected.Address(RVA = "0x177CAA0", Offset = "0x177B4A0", VA = "0x18177CAA0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_001f
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				MapField<uint, ListInventory> listInventories_ = profile.player_.listInventories_;
				ProfilePlayer player_ = profile.player_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DCD")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public SkinInventoryProfileUpdate()
		{
			((glPlayFab.Disney.BattlePassReward)(object)this)._002Ector();
		}
	}
}
