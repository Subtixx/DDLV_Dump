using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AF4")]
	internal class RedoMotherGothelFixProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DBC")]
		[Cpp2IlInjected.Address(RVA = "0x5C5ED0", Offset = "0x5C48D0", VA = "0x1805C5ED0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0011
			bool flag = new HashSet<T>().Add((T)"Group10");
		}

		[Cpp2IlInjected.Token(Token = "0x6005DBD")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public RedoMotherGothelFixProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
