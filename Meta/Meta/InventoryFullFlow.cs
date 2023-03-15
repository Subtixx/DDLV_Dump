using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A4F")]
	internal static class InventoryFullFlow
	{
		[Cpp2IlInjected.Token(Token = "0x60058E8")]
		[Cpp2IlInjected.Address(RVA = "0x170DCB0", Offset = "0x170C6B0", VA = "0x18170DCB0")]
		public static bool CanCompleteFlow(ContainerInventory inventory, InventoryFullResolution inventoryFullResolution, in Player player)
		{
			bool flag = default(bool);
			if (inventoryFullResolution != null && flag && ((RepeatedField<T>)(object)inventoryFullResolution.positionsToDrop_).Count != 0)
			{
				RepeatedField<int> positionsToDrop_ = inventoryFullResolution.positionsToDrop_;
				Func<int, bool> func = (Func<int, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0017
					//IL_0013: Expected O, but got I8
					ContainerInventory containerInventory = inventory;
					bool flag2 = default(bool);
					if (!flag2)
					{
						return flag2;
					}
					ulong num = default(ulong);
					int price = ((BattlePassReward)num).Price;
					bool result = default(bool);
					return result;
				};
				return ((IEnumerable<>)(object)positionsToDrop_).All<int>((Func<, >)(object)func);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058E9")]
		[Cpp2IlInjected.Address(RVA = "0x170DE20", Offset = "0x170C820", VA = "0x18170DE20")]
		public static bool CompleteFlow(ContainerInventory inventory, InventoryFullResolution inventoryFullResolution, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60058EA")]
		[Cpp2IlInjected.Address(RVA = "0x170DEC0", Offset = "0x170C8C0", VA = "0x18170DEC0")]
		public unsafe static bool CompleteFlow(ContainerInventory inventory, InventoryFullResolution inventoryFullResolution, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_007b, IL_0081, IL_0087
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag && world.Section.gridCollection_.TryGetGrid((uint)num, out *(IGrid*)num))
			{
				RepeatedField<int> positionsToDrop_ = inventoryFullResolution.positionsToDrop_;
				bool flag2 = default(bool);
				if (flag2)
				{
					DropContainerInventoryStack.Types.Response response = new DropContainerInventoryStack.Types.Response();
					DropContainerInventoryStack.Types.Request request = new DropContainerInventoryStack.Types.Request();
					uint num3 = (request.inventoryID_ = inventory.iD_);
					request.inventoryPosition_ = 0;
					request.IgnoreLimits = true;
					response.request_ = request;
					bool flag3 = default(bool);
					while (flag3)
					{
					}
					int num4 = 0;
					num++;
				}
				if (num + 1 == 0)
				{
				}
			}
			throw new NullReferenceException();
		}
	}
}
