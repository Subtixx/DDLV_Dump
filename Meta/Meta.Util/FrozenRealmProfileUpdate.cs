using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AD4")]
	internal class FrozenRealmProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D6D")]
		[Cpp2IlInjected.Address(RVA = "0x1809070", Offset = "0x1807A70", VA = "0x181809070", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_01bd
			//IL_0090: Expected O, but got I4
			//IL_017c: Expected I4, but got I8
			//IL_018a: Expected I4, but got I8
			bool flag = default(bool);
			bool flag2 = default(bool);
			IEnumerable<JProperty> cpp2il__autoParamName__idx_ = default(IEnumerable<JProperty>);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
			uint num9 = default(uint);
			JToken jToken = default(JToken);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			while (true)
			{
				int num = 0;
				if (!profile.TryGetValue("World", out *(JToken?*)num) || num == 0)
				{
					return;
				}
				int num2 = 0;
				if (num == 0)
				{
					return;
				}
				if (flag && num != 0)
				{
					int num3 = 0;
					if (num != 0 && flag2 && num != 0)
					{
						int num4 = 0;
						if (num != 0)
						{
							JProperty[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<JProperty>();
							int length = array.Length;
							if (num < length)
							{
								JProperty jProperty = array[num];
								int num5 = 0;
								JToken value = jProperty.Value;
								if (value != null)
								{
									int num6 = 0;
									if (value != null && flag3 && string.Equals(Extensions.Value<string>((IEnumerable<>)num), "SceneLayouts/Houses/ElsaHouse/ElsaHouse.json"))
									{
										string name = jProperty._name;
									}
								}
								num++;
							}
						}
					}
				}
				if (flag4 && num != 0)
				{
					int num7 = 0;
					if (num == 0)
					{
					}
				}
				if (flag5 && num != 0)
				{
					int num8 = 0;
					if (num != 0)
					{
						if (enumerator != null)
						{
							if (num < (int)num9)
							{
								num += num;
								if (num != (int)num9)
								{
									num++;
								}
							}
							int num10 = 0;
							if (enumerator == null)
							{
								break;
							}
							if (Extensions.Value<int>((IEnumerable<>)jToken["id"]) != 10000034)
							{
								continue;
							}
							JToken jToken2 = "CharacterStatus_InRealm";
						}
						if (enumerator == null)
						{
						}
					}
				}
				if (flag6 && num != 0)
				{
					int num11 = 0;
					if (num != 0 && flag7 && num != 0)
					{
						int num12 = 0;
						if (num != 0 && flag8 && num != 0)
						{
							int num13 = 0;
							if (num != 0 && flag9 && num != 0)
							{
								int num14 = 0;
								if (num != 0)
								{
									BodyOfWater bodyOfWater = new BodyOfWater();
									bodyOfWater.requestedFishConditionID_ = 2130000339;
									bodyOfWater.requestedFishItemID_ = 31000046;
									ActivityDataLocationFilter activityDataLocationFilter = new ActivityDataLocationFilter();
									activityDataLocationFilter.VillageArea = VillageAreaType.Wetland;
									bodyOfWater.location_ = activityDataLocationFilter;
									JObject jObject = JObject.Parse(bodyOfWater.ToString());
									return;
								}
							}
						}
					}
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D6E")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public FrozenRealmProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
