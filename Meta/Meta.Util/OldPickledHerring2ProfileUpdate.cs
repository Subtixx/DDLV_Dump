using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AF3")]
	internal class OldPickledHerring2ProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DBA")]
		[Cpp2IlInjected.Address(RVA = "0x13A1A50", Offset = "0x13A0450", VA = "0x1813A1A50", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_001c
			//IL_001a: Expected O, but got I4
			bool flag = ((RepeatedField<T>)(object)profile.player_.cookbook_.recipes_).Remove((T)2050000218);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DBB")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public OldPickledHerring2ProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
