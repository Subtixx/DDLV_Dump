using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Meta.Grids;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B24")]
	internal static class RewardUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6005E3D")]
		[Cpp2IlInjected.Address(RVA = "0x17656F0", Offset = "0x17640F0", VA = "0x1817656F0")]
		public static bool SpawnRewardOnGrid(Item rewardItem, int rewardAmount, ItemState rewardItemState, Random random, IGrid grid, GridPosition originPosition, int minDistance, int maxDistance, in Player player, in World world, ITransactionContext context, GridSource? source)
		{
			//Discarded unreachable code: IL_01d4
			//IL_001f: Expected O, but got I4
			//IL_0174: Expected I4, but got O
			//IL_017d: Expected I4, but got O
			//IL_0186: Expected I4, but got O
			//IL_018f: Expected I4, but got O
			int itemID = rewardItem.ItemID;
			int num = 0;
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			int num2 = 0;
			CS_0024_003C_003E8__locals0.originPosition = (GridPosition)CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.grid = (IGrid)num2;
			ItemInstance itemInstance = default(ItemInstance);
			if (itemInstance == null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
				}
			}
			int amount_ = itemInstance.amount_;
			Item item = itemInstance.Item;
			int num3 = 0;
			bool flag = default(bool);
			PlaceOnGrid.Types.Request request = default(PlaceOnGrid.Types.Request);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
				uint maxValue = default(uint);
				int num4 = (int)(CS_0024_003C_003E8__locals0.orientation = (GridOrientation)random.Next((int)maxValue));
				int num5 = 0;
				int num6 = (CS_0024_003C_003E8__locals0.minDistanceSq = num4 * num4);
				if (amount_ > 0)
				{
					Func<GridPosition, bool> func = (Func<GridPosition, bool>)(object)new Func<T, TResult>(IsValid);
					int num7 = 0;
					IEnumerable<GridPosition> cpp2il__autoParamName__idx_ = default(IEnumerable<GridPosition>);
					GridPosition[] array = default(GridPosition[]);
					if (((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<GridPosition>().Length == 0)
					{
						IGrid grid2 = CS_0024_003C_003E8__locals0.grid;
						GridPosition originPosition2 = CS_0024_003C_003E8__locals0.originPosition;
						Func<GridPosition, bool> func2 = (Func<GridPosition, bool>)(object)new Func<T, TResult>(IsValid);
						int num8 = 0;
						IEnumerable<GridPosition> cpp2il__autoParamName__idx_2 = default(IEnumerable<GridPosition>);
						int length = ((IEnumerable<>)cpp2il__autoParamName__idx_2).ToArray<GridPosition>().Length;
						if (length == 0)
						{
							uint num9 = num9 + 1;
							while ((int)num9 <= 5)
							{
							}
							if (length == 0)
							{
								GridPosition originPosition3 = CS_0024_003C_003E8__locals0.originPosition;
								Func<GridPosition, bool> func3 = (Func<GridPosition, bool>)(object)new Func<T, TResult>(IsValid);
								int num10 = 0;
								IEnumerable<GridPosition> cpp2il__autoParamName__idx_3 = default(IEnumerable<GridPosition>);
								array = ((IEnumerable<>)cpp2il__autoParamName__idx_3).ToArray<GridPosition>();
							}
						}
					}
					GridPosition originPosition4 = CS_0024_003C_003E8__locals0.originPosition;
					if (array.Length != 0)
					{
					}
					if (CS_0024_003C_003E8__locals0.orientation != 0)
					{
						if (array == null)
						{
							GridState gridState = new GridState();
							AmountWithState amountWithState = new AmountWithState();
							int num11 = 0;
							amountWithState.amount_ = (int?)amountWithState;
							gridState.ItemAmountState = amountWithState;
						}
						int num12 = 0;
						PlaceOnGrid.Types.Response response = new PlaceOnGrid.Types.Response();
						request = new PlaceOnGrid.Types.Request();
						request.gridID_ = (uint)(int)request;
						request.itemID_ = (int)request;
						request.posX_ = (int)request;
						request.posY_ = (int)request;
						GridOrientation gridOrientation = (request.orientation_ = CS_0024_003C_003E8__locals0.orientation);
						GridState gridState_ = default(GridState);
						request.gridState_ = gridState_;
						request.automaticSpawning_ = true;
						request.IgnoreLimits = true;
						response.request_ = request;
						bool flag3 = default(bool);
						if (!flag3)
						{
						}
					}
					num5++;
				}
			}
			return (IntPtr)request == (IntPtr)amount_;
			[Cpp2IlInjected.Token(Token = "0x6005E40")]
			[Cpp2IlInjected.Address(RVA = "0xC92CB0", Offset = "0xC916B0", VA = "0x180C92CB0")]
			bool IsValid(GridPosition position)
			{
				GridPosition originPosition5 = CS_0024_003C_003E8__locals0.originPosition;
				IGrid grid3 = CS_0024_003C_003E8__locals0.grid;
				GridOrientation orientation = CS_0024_003C_003E8__locals0.orientation;
				int num13 = 0;
				uint num14 = default(uint);
				if (num13 < (int)num14)
				{
					num13 += num13;
					num13++;
				}
				int num15 = num15 + 584;
				int num16 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E3E")]
		[Cpp2IlInjected.Address(RVA = "0x1B1E9A0", Offset = "0x1B1D3A0", VA = "0x181B1E9A0")]
		public static T WeightedRandom<T>(IEnumerable<> P_0, Random P_1, Func<, > P_2)
		{
			//Discarded unreachable code: IL_0040, IL_0046
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			object obj = default(object);
			uint num3 = default(uint);
			int num2;
			IEnumerator enumerator = default(IEnumerator);
			do
			{
				int num = 0;
				num2 = 0;
				if (obj != null)
				{
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_0022;
						}
						num2++;
					}
					obj -= num2;
					num2++;
					goto IL_0022;
				}
				goto IL_002a;
				IL_002a:
				num2++;
				if (obj != null)
				{
				}
				continue;
				IL_0022:
				num2 += 312;
				goto IL_002a;
			}
			while (enumerator != null);
			if (num2 != 0)
			{
			}
			throw new NullReferenceException();
		}
	}
}
