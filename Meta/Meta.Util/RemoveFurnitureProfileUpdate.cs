using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC6")]
	internal abstract class RemoveFurnitureProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AF7")]
		private readonly Item[] furnitureItemsToDelete;

		[Cpp2IlInjected.Token(Token = "0x6005D4F")]
		[Cpp2IlInjected.Address(RVA = "0x5C7440", Offset = "0x5C5E40", VA = "0x1805C7440")]
		protected RemoveFurnitureProfileUpdate(Item[] furnitureItemsToDelete)
		{
			((BattlePassReward)(object)this)._002Ector();
			this.furnitureItemsToDelete = furnitureItemsToDelete;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D50")]
		[Cpp2IlInjected.Address(RVA = "0x5C7A50", Offset = "0x5C6450", VA = "0x1805C7A50", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d
			int num = 0;
			Item[] array = furnitureItemsToDelete;
			int num2 = 0;
			ProfileUpdateCommonMethods.RemoveItemsInListInventory(profile, (uint)num2, (IEnumerable<>)(object)array);
			Item[] array2 = furnitureItemsToDelete;
			ProfileUpdateCommonMethods.RemoveItemsInCollections(profile, (IEnumerable<>)(object)array2);
			if (!profile.TryGetValue("World", out *(JToken?*)num) || num == 0)
			{
				return;
			}
			int num3 = 0;
			bool flag = default(bool);
			if (num == 0 || !flag || num == 0)
			{
				return;
			}
			int num4 = 0;
			bool flag2 = default(bool);
			if (num == 0 || !flag2 || num == 0)
			{
				return;
			}
			int num5 = 0;
			if (num == 0)
			{
				return;
			}
			IEnumerable<JProperty> enumerable = default(IEnumerable<JProperty>);
			if (enumerable != null)
			{
				int num6 = 0;
				int num7 = 0;
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				while (num == 0)
				{
				}
				int num8 = 0;
				while (num == 0)
				{
				}
				IEnumerable<JProperty> cpp2il__autoParamName__idx_ = default(IEnumerable<JProperty>);
				JProperty[] array3 = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<JProperty>();
				if (num < array3.Length)
				{
					JProperty jProperty = array3[num];
					if (jProperty.Value == null)
					{
					}
					int num9 = 0;
					Item[] array4 = furnitureItemsToDelete;
					JToken jToken = default(JToken);
					long num10 = Convert.ToInt64((uint)Extensions.Value<int>((IEnumerable<>)jToken));
					bool flag4 = default(bool);
					if (flag4)
					{
						string name = jProperty._name;
					}
					num++;
				}
			}
			if (enumerable == null)
			{
			}
		}
	}
}
