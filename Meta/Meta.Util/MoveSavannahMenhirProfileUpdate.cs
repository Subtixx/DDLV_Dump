using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B15")]
	internal class MoveSavannahMenhirProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E0D")]
		[Cpp2IlInjected.Address(RVA = "0x1394C30", Offset = "0x1393630", VA = "0x181394C30", Slot = "5")]
		protected unsafe override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_009e
			//IL_0023: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_009d: Expected O, but got I4
			int num = 0;
			ProfileWorld world_ = profile.world_;
			Village village_ = world_.village_;
			GridCollection gridCollection_ = world_.gridCollection_;
			uint gridID_ = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)village_.areas_)[(TKey)4]).gridID_;
			if (!gridCollection_.TryGetGrid(gridID_, out *(IGrid*)num))
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			FurnitureItemData furnitureItemData = default(FurnitureItemData);
			FurnitureItemData menhirItemData = furnitureItemData;
			Func<GridObject, bool> func = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
			{
				int itemID = x.ItemID;
				int iD = menhirItemData.ID;
				throw new NullReferenceException();
			};
			GridObject gridObject = Enumerable.FirstOrDefault<GridObject>((IEnumerable<>)(object)furnitureItemData, (Func<, >)(object)func);
			if (gridObject != null)
			{
				FurnitureItemData gridEditRestriction = menhirItemData;
				int num2 = 0;
				if (!gridEditRestriction.CanMove(profile, (ITransactionContext)num2) || *(GridPosition*)gridObject.Position == *(GridPosition*)num)
				{
					gridObject.Position = (GridPosition)num;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E0E")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public MoveSavannahMenhirProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
