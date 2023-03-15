using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ADE")]
	internal class WallDecalsProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D80")]
		[Cpp2IlInjected.Address(RVA = "0x15E3D70", Offset = "0x15E2770", VA = "0x1815E3D70", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_006d
			int num = 0;
			ProfileWorld world_ = profile.world_;
			bool flag = default(bool);
			if (flag)
			{
				ListInventory decals = profile.player_.Decals;
				bool flag2 = default(bool);
				if (!flag2)
				{
					ListInventory decals2 = profile.player_.Decals;
				}
				flag = flag2;
				ListInventory decals3 = profile.player_.Decals;
				bool flag3 = default(bool);
				if (!flag3)
				{
					ListInventory decals4 = profile.player_.Decals;
				}
				ListInventory decals5 = profile.player_.Decals;
				bool flag4 = default(bool);
				if (!flag4)
				{
					ListInventory decals6 = profile.player_.Decals;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D81")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public WallDecalsProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
