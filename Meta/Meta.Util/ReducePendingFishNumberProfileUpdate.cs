using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AD0")]
	internal class ReducePendingFishNumberProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D62")]
		[Cpp2IlInjected.Address(RVA = "0x5C5FE0", Offset = "0x5C49E0", VA = "0x1805C5FE0", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_01ab, IL_01b1, IL_01b7, IL_01bd, IL_01c3, IL_01c9, IL_01cf, IL_01d5, IL_01db, IL_01e1, IL_01e7, IL_01ed, IL_01f3
			int num;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			Func<JProperty, PendingFish> func = default(Func<JProperty, PendingFish>);
			IEnumerable<JProperty> enumerable = default(IEnumerable<JProperty>);
			IEnumerable<JProperty> enumerable2 = default(IEnumerable<JProperty>);
			int villageAreaType = default(int);
			IEnumerable<> enumerable3 = default(IEnumerable<>);
			JToken jToken = default(JToken);
			Village.Types.VillageArea villageArea = default(Village.Types.VillageArea);
			Func<BodyOfWater, bool> func3 = default(Func<BodyOfWater, bool>);
			do
			{
				num = 0;
				if (!profile.TryGetValue("World", out *(JToken?*)num) || num == 0)
				{
					break;
				}
				int num2 = 0;
				if (num == 0 || !flag || num == 0)
				{
					break;
				}
				int num3 = 0;
				if (num == 0 || !flag2 || num == 0)
				{
					break;
				}
				int num4 = 0;
				if (num == 0 || !flag3 || num == 0)
				{
					break;
				}
				int num5 = 0;
				if (num == 0)
				{
					break;
				}
				Func<JProperty, uint> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
				if (_003C_003E9__0_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((JProperty x) => uint.Parse(x._name));
				}
				if (_003C_003Ec._003C_003E9__0_1 == null)
				{
					func = (Func<JProperty, PendingFish>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(JProperty x)
					{
						//Discarded unreachable code: IL_000e
						string text2 = x.Value.ToString();
						PendingFish result2 = default(PendingFish);
						return result2;
					});
				}
				Dictionary<JProperty, uint> dictionary = (Dictionary<JProperty, uint>)(object)Enumerable.ToDictionary<JProperty, uint, PendingFish>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__0_, (Func<, >)(object)func);
				if (enumerable2 != null)
				{
					_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
					CS_0024_003C_003E8__locals0.villageAreaType = (VillageAreaType)villageAreaType;
					Func<FishSpawningInVillageRecurringEventItemData, bool> func2 = (Func<FishSpawningInVillageRecurringEventItemData, bool>)(object)(Func<T, TResult>)delegate(FishSpawningInVillageRecurringEventItemData x)
					{
						//Discarded unreachable code: IL_0021
						OptionalField location_ = x.location_;
						if (!location_.useField_)
						{
							int num8 = 0;
						}
						return location_.VillageArea == CS_0024_003C_003E8__locals0.villageAreaType;
					};
					FishSpawningInVillageRecurringEventItemData fishSpawningInVillageRecurringEventItemData = Enumerable.FirstOrDefault<FishSpawningInVillageRecurringEventItemData>(enumerable3, (Func<, >)(object)func2);
					while (fishSpawningInVillageRecurringEventItemData == null)
					{
					}
					string text = jToken.ToString();
					RepeatedField<BodyOfWater> bodiesOfWater_ = villageArea.bodiesOfWater_;
					if (_003C_003Ec._003C_003E9__0_3 == null)
					{
						func3 = (Func<BodyOfWater, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BodyOfWater x) => (IntPtr)x.requestedFishItemID_ == (IntPtr)"{il2cpp field on {'constant11' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}"));
					}
					int num6 = Enumerable.Count<BodyOfWater>((IEnumerable<>)(object)bodiesOfWater_, (Func<, >)(object)func3);
					int maxNumberOfPendingFishes_ = fishSpawningInVillageRecurringEventItemData.maxNumberOfPendingFishes_;
					maxNumberOfPendingFishes_ = num6;
					ActivityDataLocationFilter activityDataLocationFilter = new ActivityDataLocationFilter();
					VillageAreaType villageAreaType3 = (activityDataLocationFilter.VillageArea = CS_0024_003C_003E8__locals0.villageAreaType);
					ActivityDataLocationFilter pendingFishLocationFilter = activityDataLocationFilter;
					Func<KeyValuePair<uint, PendingFish>, bool> func4 = (Func<KeyValuePair<uint, PendingFish>, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000b
						int num7 = 0;
						ActivityDataLocationFilter activityDataLocationFilter2 = pendingFishLocationFilter;
						bool result = default(bool);
						return result;
					};
					KeyValuePair<uint, PendingFish>[] array = Enumerable.Where<KeyValuePair<uint, PendingFish>>((IEnumerable<>)dictionary, (Func<, >)(object)func4).ToArray<KeyValuePair<uint, PendingFish>>();
					if (maxNumberOfPendingFishes_ < array.Length)
					{
						_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = (_003C_003Ec__DisplayClass0_0)(object)((object)CS_0024_003C_003E8__locals0 + (object)CS_0024_003C_003E8__locals0);
						maxNumberOfPendingFishes_++;
					}
				}
				if (enumerable2 != null)
				{
				}
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D63")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ReducePendingFishNumberProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
