using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Mdl.Grid;
using Meta;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B62")]
	public static class GardeningUtil
	{
		[Cpp2IlInjected.Token(Token = "0x60034B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C95B0", Offset = "0x8C7FB0", VA = "0x1808C95B0")]
		public static bool CanHarvest(GardeningSlot gardeningSlot, Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_004a
			HarvestGardeningSlot.Types.Request request = new HarvestGardeningSlot.Types.Request();
			uint num = (request.gridID_ = ((GridObjectStateUser)gardeningSlot).GridObjectScript.GridScript.GridID);
			uint num2 = (request.gridObjectID_ = ((GridObjectStateUser)gardeningSlot).GridObjectScript.GridObject.iD_);
			int num3 = (request.slotIndex_ = gardeningSlot._slotIndex);
			HarvestGardeningSlot.Types.Result result = default(HarvestGardeningSlot.Types.Result);
			return result == HarvestGardeningSlot.Types.Result.Success;
		}

		[Cpp2IlInjected.Token(Token = "0x60034B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B30", Offset = "0x8C8530", VA = "0x1808C9B30")]
		public static List<GardeningSlot> FindHarvestableSlots(List<GardeningSlot> slots, Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0044, IL_004a, IL_0050, IL_0056, IL_005c, IL_0062, IL_0068, IL_006e
			int num = 0;
			List<GardeningSlot> result = (List<GardeningSlot>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				int num3 = 0;
				HarvestGardeningSlot.Types.Request request = new HarvestGardeningSlot.Types.Request();
				uint gridID_ = default(uint);
				request.gridID_ = gridID_;
				request.slotIndex_ = (int)(request.gridObjectID_ = request.gridID_);
				HarvestGardeningSlot.Types.Result result2 = default(HarvestGardeningSlot.Types.Result);
				while (result2 != 0)
				{
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C9E00", Offset = "0x8C8800", VA = "0x1808C9E00")]
		public static List<GardeningSlot> FindHarvestableSlots(Item seedItem, List<GardeningSlot> slots, Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0040
			//IL_0014: Expected O, but got I4
			int itemID = seedItem.ItemID;
			Item seedItem2 = (Item)itemID;
			List<GardeningSlot> list = (List<GardeningSlot>)(object)GardeningUtil.FindHarvestableSlots((List<>)(object)slots, profile, context);
			bool flag = default(bool);
			if (flag)
			{
				Func<GardeningSlot, bool> func = (Func<GardeningSlot, bool>)(object)(Func<T, TResult>)delegate(GardeningSlot s)
				{
					Item plantedSeedItem = s.PlantedSeedItem;
					throw new NullReferenceException();
				};
				List<GardeningSlot> list2 = (List<GardeningSlot>)(object)Enumerable.ToList<GardeningSlot>(Enumerable.Where<GardeningSlot>((IEnumerable<>)list, (Func<, >)(object)func));
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60034B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C9700", Offset = "0x8C8100", VA = "0x1808C9700")]
		public static bool CanPlant(Item seedItem, GardeningSlot gardeningSlot, Profile profile, ITransactionContext context)
		{
			int itemID = seedItem.ItemID;
			PlantSeed.Types.Request request = new PlantSeed.Types.Request();
			uint num = (request.gridID_ = ((GridObjectStateUser)gardeningSlot).GridObjectScript.GridScript.GridID);
			uint num2 = (request.gridObjectID_ = ((GridObjectStateUser)gardeningSlot).GridObjectScript.GridObject.iD_);
			int num3 = (request.slotIndex_ = gardeningSlot._slotIndex);
			request.seedItemID_ = itemID;
			PlantSeed.Types.Result result = default(PlantSeed.Types.Result);
			if (result != 0 && result != PlantSeed.Types.Result.NotEnoughSeeds)
			{
				int num4 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C9F70", Offset = "0x8C8970", VA = "0x1808C9F70")]
		public static List<GardeningSlot> FindPlantableSlots(Item seedItem, List<GardeningSlot> slots, Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0059, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007d, IL_0083
			int itemID = seedItem.ItemID;
			int num = 0;
			List<GardeningSlot> result = (List<GardeningSlot>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				int num3 = 0;
				PlantSeed.Types.Request request = new PlantSeed.Types.Request();
				uint gridID_ = default(uint);
				request.gridID_ = gridID_;
				request.slotIndex_ = (int)(request.gridObjectID_ = (uint)request.seedItemID_);
				request.seedItemID_ = itemID;
				PlantSeed.Types.Result result2 = default(PlantSeed.Types.Result);
				if (result2 != 0)
				{
					while (result2 != PlantSeed.Types.Result.NotEnoughSeeds)
					{
					}
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C9870", Offset = "0x8C8270", VA = "0x1808C9870")]
		public static bool CanWater(GardeningSlot gardeningSlot, Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0036
			uint gridID = ((GridObjectStateUser)gardeningSlot).GridObjectScript.GridScript.GridID;
			GridObject _003CGridObject_003Ek__BackingField = ((GridObjectStateUser)gardeningSlot).GridObjectScript.GridObject;
			int slotIndex = gardeningSlot._slotIndex;
			uint iD_ = _003CGridObject_003Ek__BackingField.iD_;
			return WaterObjects.CanWaterGardeningSlot(gridID, iD_, slotIndex, profile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60034B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CA250", Offset = "0x8C8C50", VA = "0x1808CA250")]
		public static List<GardeningSlot> FindWaterableSlots(List<GardeningSlot> slots, Profile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0013, IL_0019, IL_001f, IL_0025, IL_002b, IL_0031, IL_0037
			int num = 0;
			List<GardeningSlot> result = (List<GardeningSlot>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C9950", Offset = "0x8C8350", VA = "0x1808C9950")]
		public static GardeningSlot FindClosest(List<GardeningSlot> slots, Vector3 position)
		{
			//Discarded unreachable code: IL_001f, IL_0025
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float z2 = position.z;
			}
			throw new NullReferenceException();
		}
	}
}
