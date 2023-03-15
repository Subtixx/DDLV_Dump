using Cpp2IlInjected;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ACE")]
	internal class VillageObjectLimitRefactoringProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D5F")]
		[Cpp2IlInjected.Address(RVA = "0x15E1A70", Offset = "0x15E0470", VA = "0x1815E1A70", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_0036
			int num = 0;
			if (!profile.TryGetValue("World", out *(JToken?*)num) || num == 0)
			{
				return;
			}
			int num2 = 0;
			bool flag = default(bool);
			if (num != 0 && flag && num != 0)
			{
				int num3 = 0;
				if (num != 0)
				{
					JToken jToken = "Village04ObjectLimit";
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D60")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public VillageObjectLimitRefactoringProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
