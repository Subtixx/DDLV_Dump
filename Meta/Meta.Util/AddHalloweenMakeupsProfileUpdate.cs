using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AED")]
	internal class AddHalloweenMakeupsProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DAA")]
		[Cpp2IlInjected.Address(RVA = "0x18E5180", Offset = "0x18E3B80", VA = "0x1818E5180", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0011
			ListInventory makeup = profile.Makeup;
			int num = 0;
			ListInventory makeup2 = profile.Makeup;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAB")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public AddHalloweenMakeupsProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
