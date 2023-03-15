using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC9")]
	internal class EricVillageRequestsUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D54")]
		[Cpp2IlInjected.Address(RVA = "0x17F7C80", Offset = "0x17F6680", VA = "0x1817F7C80", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_00c3
			//IL_0089: Expected I4, but got I8
			//IL_0097: Expected I4, but got I8
			int num = 0;
			if (!profile.TryGetValue("World", out *(JToken?*)num) || num == 0)
			{
				return;
			}
			int num2 = 0;
			bool flag = default(bool);
			if (num == 0 || !flag || num == 0)
			{
				return;
			}
			int num3 = 0;
			bool flag2 = default(bool);
			if (num == 0 || !flag2 || num == 0)
			{
				return;
			}
			int num4 = 0;
			bool flag3 = default(bool);
			if (num == 0 || !flag3 || num == 0)
			{
				return;
			}
			int num5 = 0;
			bool flag4 = default(bool);
			if (num != 0 && flag4 && num != 0)
			{
				int num6 = 0;
				if (num != 0)
				{
					BodyOfWater bodyOfWater = new BodyOfWater();
					bodyOfWater.requestedFishConditionID_ = 2130000213;
					bodyOfWater.requestedFishItemID_ = 31000043;
					ActivityDataLocationFilter activityDataLocationFilter = new ActivityDataLocationFilter();
					int num7 = (int)(activityDataLocationFilter.VillageArea = VillageAreaType.Beach);
					bodyOfWater.location_ = activityDataLocationFilter;
					JObject jObject = JObject.Parse(bodyOfWater.ToString());
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D55")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public EricVillageRequestsUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
