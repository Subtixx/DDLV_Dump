using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Meta.Grids;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AD7")]
	internal class MoanaRealmGridFailProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D73")]
		[Cpp2IlInjected.Address(RVA = "0x13937B0", Offset = "0x13921B0", VA = "0x1813937B0", Slot = "4")]
		protected override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_0161
			//IL_00d7: Expected O, but got I4
			//IL_0139: Expected I4, but got I8
			int defaultLayoutGridID_ = 0;
			bool flag = default(bool);
			if (!flag || "World" == null)
			{
				return;
			}
			int num = 0;
			bool flag2 = default(bool);
			if ("World" == null || !flag2 || "Realms" == null)
			{
				return;
			}
			int num2 = 0;
			bool flag3 = default(bool);
			if ("Realms" == null || !flag3 || "Worlds!Moana" == null)
			{
				return;
			}
			int num3 = 0;
			bool flag4 = default(bool);
			if ("Worlds!Moana" == null || !flag4 || "GridIDs" == null)
			{
				return;
			}
			int num4 = 0;
			int num5 = default(int);
			bool flag5 = default(bool);
			if ("GridIDs" == null || num5 != 1 || !flag5 || "GridCollection" == null)
			{
				return;
			}
			int num6 = 0;
			bool flag6 = default(bool);
			if ("GridCollection" == null || !flag6 || "DiffGrids" == null)
			{
				return;
			}
			int num7 = 0;
			if ("DiffGrids" == null)
			{
				return;
			}
			int num8 = 0;
			uint num9 = Extensions.Value<uint>((IEnumerable<>)num7);
			bool flag7 = default(bool);
			string text = default(string);
			if (flag7 && text != null)
			{
				int num10 = 0;
				if (text != null)
				{
					JToken jToken = 1;
				}
			}
			bool flag8 = default(bool);
			if (flag8)
			{
			}
			DiffGrid diffGrid = new DiffGrid();
			uint num11 = default(uint);
			diffGrid.iD_ = num11;
			diffGrid.GridDefaultLayoutPath = "SceneLayouts/Realms/Moana/MoanaRealm.json";
			diffGrid.GridDefaultLayoutType = "Meta.DefaultRealmData, Meta";
			diffGrid.defaultLayoutGridID_ = (uint)defaultLayoutGridID_;
			diffGrid.nextGridObjectID_ = 2147483647u;
			JObject jObject = JObject.Parse(diffGrid.ToString());
			JToken jToken2 = num11 + 1;
			JToken jToken3 = diffGrid.iD_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D74")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public MoanaRealmGridFailProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
