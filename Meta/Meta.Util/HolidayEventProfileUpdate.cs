using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AF9")]
	internal class HolidayEventProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DCA")]
		[Cpp2IlInjected.Address(RVA = "0x1704970", Offset = "0x1703370", VA = "0x181704970", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_01e6
			//IL_0016: Expected O, but got I4
			//IL_002f: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			//IL_006d: Expected O, but got I4
			//IL_0088: Expected I4, but got I8
			//IL_0096: Expected I4, but got I8
			//IL_00cc: Expected O, but got I4
			//IL_00e8: Expected I4, but got I8
			//IL_00f6: Expected I4, but got I8
			//IL_012d: Expected O, but got I4
			//IL_0149: Expected I4, but got I8
			//IL_0157: Expected I4, but got I8
			//IL_0196: Expected O, but got I4
			//IL_01b2: Expected I4, but got I8
			//IL_01c0: Expected I4, but got I8
			RepeatedField<BodyOfWater> bodiesOfWater_ = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)profile.world_.village_.areas_)[(TKey)6]).bodiesOfWater_;
			BodyOfWater bodyOfWater = new BodyOfWater();
			bodyOfWater.requestedFishConditionID_ = 2130000682;
			bodyOfWater.requestedFishItemID_ = 31000056;
			ActivityDataLocationFilter activityDataLocationFilter = new ActivityDataLocationFilter();
			activityDataLocationFilter.VillageArea = VillageAreaType.DarkMountains;
			bodyOfWater.location_ = activityDataLocationFilter;
			((RepeatedField<T>)(object)bodiesOfWater_).Add((T)bodyOfWater);
			RepeatedField<BodyOfWater> bodiesOfWater_2 = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)profile.world_.village_.areas_)[(TKey)4]).bodiesOfWater_;
			BodyOfWater bodyOfWater2 = new BodyOfWater();
			bodyOfWater2.requestedFishConditionID_ = 2130000684;
			bodyOfWater2.requestedFishItemID_ = 31000055;
			ActivityDataLocationFilter activityDataLocationFilter2 = new ActivityDataLocationFilter();
			activityDataLocationFilter2.VillageArea = VillageAreaType.Savannah;
			bodyOfWater2.location_ = activityDataLocationFilter2;
			((RepeatedField<T>)(object)bodiesOfWater_2).Add((T)bodyOfWater2);
			RepeatedField<BodyOfWater> bodiesOfWater_3 = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)profile.world_.village_.areas_)[(TKey)2]).bodiesOfWater_;
			BodyOfWater bodyOfWater3 = new BodyOfWater();
			bodyOfWater3.requestedFishConditionID_ = 2130000683;
			bodyOfWater3.requestedFishItemID_ = 31000054;
			ActivityDataLocationFilter activityDataLocationFilter3 = new ActivityDataLocationFilter();
			activityDataLocationFilter3.VillageArea = VillageAreaType.Meadow;
			bodyOfWater3.location_ = activityDataLocationFilter3;
			((RepeatedField<T>)(object)bodiesOfWater_3).Add((T)bodyOfWater3);
			RepeatedField<BodyOfWater> bodiesOfWater_4 = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)profile.world_.village_.areas_)[(TKey)1]).bodiesOfWater_;
			BodyOfWater bodyOfWater4 = new BodyOfWater();
			bodyOfWater4.requestedFishConditionID_ = 2130000681;
			bodyOfWater4.requestedFishItemID_ = 31000052;
			ActivityDataLocationFilter activityDataLocationFilter4 = new ActivityDataLocationFilter();
			activityDataLocationFilter4.VillageArea = VillageAreaType.Wetland;
			bodyOfWater4.location_ = activityDataLocationFilter4;
			((RepeatedField<T>)(object)bodiesOfWater_4).Add((T)bodyOfWater4);
			MapField<int, Village.Types.VillageArea> areas_ = profile.world_.village_.areas_;
			int num = 0;
			RepeatedField<BodyOfWater> bodiesOfWater_5 = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)areas_)[(TKey)num]).bodiesOfWater_;
			BodyOfWater bodyOfWater5 = new BodyOfWater();
			bodyOfWater5.requestedFishConditionID_ = 2130000679;
			bodyOfWater5.requestedFishItemID_ = 31000053;
			ActivityDataLocationFilter activityDataLocationFilter5 = new ActivityDataLocationFilter();
			int num2 = (int)(activityDataLocationFilter5.VillageArea = VillageAreaType.Beach);
			bodyOfWater5.location_ = activityDataLocationFilter5;
			((RepeatedField<T>)(object)bodiesOfWater_5).Add((T)bodyOfWater5);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DCB")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public HolidayEventProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
