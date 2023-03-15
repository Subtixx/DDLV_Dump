using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ADB")]
	internal class SavannahUpdateProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D79")]
		[Cpp2IlInjected.Address(RVA = "0x1768950", Offset = "0x1767350", VA = "0x181768950", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_01d3, IL_01d9, IL_01df
			//IL_00ad: Expected O, but got I4
			//IL_0140: Expected O, but got I4
			//IL_015b: Expected O, but got I4
			//IL_0165: Expected I4, but got I8
			//IL_018a: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			IEnumerable<JProperty> enumerable = default(IEnumerable<JProperty>);
			uint num11 = default(uint);
			int num12 = default(int);
			JToken jToken = default(JToken);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			uint num15 = default(uint);
			JToken jToken3 = default(JToken);
			while (true)
			{
				int num = 0;
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
				if (num == 0 || !flag4 || !flag5 || num == 0)
				{
					break;
				}
				int num6 = 0;
				if (num == 0 || !flag6 || num == 0)
				{
					break;
				}
				int num7 = 0;
				if (num == 0)
				{
					break;
				}
				uint num8 = Extensions.Value<uint>((IEnumerable<>)num);
				if (!flag7 || num == 0)
				{
					break;
				}
				int num9 = 0;
				if (num == 0 || !flag8 || num == 0)
				{
					break;
				}
				int num10 = 0;
				if (num == 0)
				{
					break;
				}
				if (enumerable != null)
				{
					if (num < (int)num11)
					{
						num += num;
						if (num == (int)num11)
						{
							goto IL_0100;
						}
						num++;
					}
					num12 = 0;
					while (jToken == null)
					{
					}
					goto IL_0100;
				}
				goto IL_011d;
				IL_011d:
				int num13 = 0;
				if (enumerable != null)
				{
				}
				if (flag9 && num != 0)
				{
					int num14 = 0;
					if (num == 0)
					{
					}
				}
				if (flag10)
				{
					num15 = Extensions.Value<uint>((IEnumerable<>)num);
				}
				GridObject gridObject = new GridObject();
				gridObject.iD_ = num15;
				gridObject.Position = (GridPosition)num13;
				gridObject.orientation_ = GridOrientation.Down;
				GridState gridState = new GridState();
				GardenData gardenData = new GardenData();
				RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
				GardenData.Types.GardeningSlot gardeningSlot = new GardenData.Types.GardeningSlot();
				Timestamp timestamp = (gardeningSlot.lastActivity_ = ((DateTime)num13).ToProto());
				((RepeatedField<T>)(object)slots_).Add((T)gardeningSlot);
				gridState.GardenData = gardenData;
				gridObject.state_ = gridState;
				uint iD_ = gridObject.iD_;
				JObject jObject = JObject.Parse(gridObject.ToString());
				JToken jToken2 = num15 + 1;
				break;
				IL_0100:
				num12 += num12;
				int num16 = 0;
				while (jToken == null)
				{
				}
				if (Extensions.Value<int>((IEnumerable<>)jToken3) != num10)
				{
					continue;
				}
				goto IL_011d;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D7A")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public SavannahUpdateProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
