using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ACA")]
	internal class UrsulaHouseInteriorUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D56")]
		[Cpp2IlInjected.Address(RVA = "0x15DCA10", Offset = "0x15DB410", VA = "0x1815DCA10", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			int num = 0;
			bool flag = default(bool);
			if (flag && "World" != null)
			{
				int num2 = 0;
				bool flag2 = default(bool);
				if ("World" != null && flag2 && "BuildingInfos" != null)
				{
					int num3 = 0;
					if ("BuildingInfos" != null)
					{
						bool flag3 = default(bool);
						if (!flag3 || "20000055" == null)
						{
							return;
						}
						int num4 = 0;
						bool flag4 = default(bool);
						if ("20000055" == null || !flag4 || "Room" == null)
						{
							return;
						}
						int num5 = 0;
						if ("Room" == null)
						{
							return;
						}
						JToken jToken = default(JToken);
						uint num6 = jToken.ToObject<uint>();
						int num7 = 0;
						int num8 = 0;
						Func<JToken, uint> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
						JToken jToken2 = default(JToken);
						if (jToken2 == null)
						{
						}
						int num9 = 0;
						if (_003C_003E9__0_ != null)
						{
							if (jToken2 == null)
							{
							}
							int num10 = 0;
						}
						JEnumerable<JToken> jEnumerable = default(JEnumerable<JToken>);
						uint[] array = Enumerable.Select<JToken, uint>((IEnumerable<>)jEnumerable, (Func<, >)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((JToken x) => x.ToObject<uint>()))).ToArray<uint>();
						bool flag5 = default(bool);
						if (!flag5 || "GridCollection" == null)
						{
							return;
						}
						int num11 = 0;
						bool flag6 = default(bool);
						if ("GridCollection" == null || !flag6 || "DiffGrids" == null)
						{
							return;
						}
						int num12 = 0;
						if ("DiffGrids" == null)
						{
							return;
						}
						int length = array.Length;
						if (num < length)
						{
							string text = ((uint*)array[num])->ToString();
							int num13 = 0;
							num++;
						}
						bool flag7 = default(bool);
						string text2 = default(string);
						if (!flag7 || text2 == null)
						{
							return;
						}
						int num14 = 0;
						bool flag8 = default(bool);
						if (text2 == null || !flag8 || "ModifiedObjects" == null)
						{
							return;
						}
						int num15 = 0;
						if ("ModifiedObjects" == null)
						{
							return;
						}
						Func<JProperty, bool> func = default(Func<JProperty, bool>);
						if (_003C_003Ec._003C_003E9__0_1 == null)
						{
							func = (Func<JProperty, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((JProperty x) => x.Value["ItemID"]!.ToObject<uint>() == 40000919));
						}
						IEnumerable<JProperty> enumerable = default(IEnumerable<JProperty>);
						JProperty jProperty = Enumerable.FirstOrDefault<JProperty>((IEnumerable<>)enumerable, (Func<, >)(object)func);
						if (jProperty == null)
						{
							return;
						}
						int num16 = 0;
						JToken value = jProperty.Value;
						int num17 = 0;
						int num18 = 0;
						bool flag9 = default(bool);
						if (flag9 && "State" != null)
						{
							int num19 = 0;
							bool flag10 = default(bool);
							if ("State" != null && flag10 && "SubGrid" != null)
							{
								int num20 = 0;
								if ("SubGrid" != null)
								{
									JToken jToken3 = default(JToken);
									uint num21 = jToken3.ToObject<uint>();
								}
							}
						}
						string name = jProperty._name;
						return;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D57")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public UrsulaHouseInteriorUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
