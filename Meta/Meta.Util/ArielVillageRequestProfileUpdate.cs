using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Scene;
using glPlayFab.Disney;
using Meta.Grids;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC7")]
	internal class ArielVillageRequestProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D51")]
		[Cpp2IlInjected.Address(RVA = "0x18EAF80", Offset = "0x18E9980", VA = "0x1818EAF80", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_02d9
			//IL_009c: Expected O, but got I4
			//IL_0108: Expected I4, but got I8
			//IL_0116: Expected I4, but got I8
			//IL_014e: Expected O, but got I4
			//IL_01ad: Expected O, but got I4
			//IL_01cd: Expected I4, but got I8
			//IL_01db: Expected I4, but got I8
			//IL_01e6: Expected I4, but got I8
			//IL_01f0: Expected I4, but got I8
			//IL_0223: Expected I4, but got I8
			//IL_0231: Expected I4, but got I8
			//IL_023c: Expected I4, but got I8
			//IL_0246: Expected I4, but got I8
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			IEnumerator<KeyValuePair<string, JToken>> enumerator = default(IEnumerator<KeyValuePair<string, JToken>>);
			uint num7 = default(uint);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			bool flag11 = default(bool);
			bool flag12 = default(bool);
			uint num17 = default(uint);
			bool flag13 = default(bool);
			bool flag14 = default(bool);
			while (true)
			{
				int num = 0;
				if (!profile.TryGetValue("World", out *(JToken?*)num) || num == 0)
				{
					return;
				}
				int num2 = 0;
				if (num == 0 || !flag || num == 0)
				{
					return;
				}
				int num3 = 0;
				if (num == 0)
				{
					return;
				}
				if (flag2 && num != 0)
				{
					int num4 = 0;
					if (num != 0)
					{
						int num5 = 0;
						if (num == 0)
						{
							break;
						}
						if (flag3 && num != 0)
						{
							int num6 = 0;
							if (num != 0)
							{
								if (enumerator != null)
								{
									if (num < (int)num7)
									{
										num += num;
										if (num == (int)num7)
										{
											goto IL_0086;
										}
										num++;
									}
									while (num == 0)
									{
									}
									goto IL_0086;
								}
								goto IL_00ac;
							}
						}
					}
				}
				goto IL_00b1;
				IL_00ac:
				if (enumerator == null)
				{
				}
				goto IL_00b1;
				IL_0086:
				num += num;
				int num8 = 0;
				while (num == 0)
				{
				}
				while (!flag4)
				{
				}
				if (!string.Equals(Extensions.Value<string>((IEnumerable<>)num), "SceneLayouts/Realms/LittleMermaid/LittleMermaidRealm.json"))
				{
					continue;
				}
				goto IL_00ac;
				IL_00b1:
				if (flag5 && num != 0)
				{
					int num9 = 0;
					if (num != 0 && flag6 && num != 0)
					{
						int num10 = 0;
						if (num != 0)
						{
							if (flag7 && num != 0)
							{
								int num11 = 0;
								if (num != 0)
								{
									BodyOfWater bodyOfWater = new BodyOfWater();
									bodyOfWater.requestedFishConditionID_ = 2130000142;
									bodyOfWater.requestedFishItemID_ = 31200258;
									ActivityDataLocationFilter activityDataLocationFilter = new ActivityDataLocationFilter();
									int num12 = (int)(activityDataLocationFilter.VillageArea = VillageAreaType.Beach);
									bodyOfWater.location_ = activityDataLocationFilter;
									JObject jObject = JObject.Parse(bodyOfWater.ToString());
								}
							}
							if (flag8)
							{
								uint num13 = Extensions.Value<uint>((IEnumerable<>)num);
								if (num == 0 || !flag9 || num == 0)
								{
									return;
								}
								int num14 = 0;
								if (num == 0 || !flag10 || num == 0)
								{
									return;
								}
								int num15 = 0;
								if (num == 0 || !flag11 || num == 0)
								{
									return;
								}
								int num16 = 0;
								if (num == 0)
								{
									return;
								}
								if (flag12)
								{
									num17 = Extensions.Value<uint>((IEnumerable<>)num);
								}
								GridObject gridObject = new GridObject();
								gridObject.iD_ = num17;
								gridObject.itemID_ = 31200252;
								gridObject.x_ = 237;
								gridObject.y_ = 114;
								gridObject.orientation_ = GridOrientation.Down;
								JObject jObject2 = JObject.Parse(gridObject.ToString());
								GridObject gridObject2 = new GridObject();
								num17 = (gridObject2.iD_ = num17 + 1);
								gridObject2.itemID_ = 40001258;
								gridObject2.x_ = 227;
								gridObject2.y_ = 97;
								gridObject2.orientation_ = GridOrientation.Down;
								GridState gridState = new GridState();
								KeyholeGridData keyholeGridData = new KeyholeGridData();
								keyholeGridData.KeyholeConfigDataGUID = "8c8e9269-37c8-414f-a507-eeae36322fb8";
								gridState.Keyhole = keyholeGridData;
								gridObject2.state_ = gridState;
								uint iD_ = gridObject2.iD_;
								JObject jObject3 = JObject.Parse(gridObject2.ToString());
								JToken jToken = num17 + 1;
								if (flag13 && num != 0)
								{
									int num18 = 0;
									if (num != 0 && !flag14)
									{
										Keyhole keyhole = new Keyhole();
										keyhole.GUID = "8c8e9269-37c8-414f-a507-eeae36322fb8";
										keyhole.currentLevel_ = num;
										JObject jObject4 = JObject.Parse(keyhole.ToString());
									}
								}
								return;
							}
						}
					}
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D52")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ArielVillageRequestProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
