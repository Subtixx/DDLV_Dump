using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B19")]
	internal class StorageBlockMoveToProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E16")]
		[Cpp2IlInjected.Address(RVA = "0xC09230", Offset = "0xC07C30", VA = "0x180C09230", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0055
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.VLG_Maui_Basket01 = (Item)CS_0024_003C_003E8__locals0;
			ICollection<ContainerInventory> values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)profile.player_.containerInventories_).get_Values();
			Func<ContainerInventory, bool> func = (Func<ContainerInventory, bool>)(object)(Func<T, TResult>)delegate(ContainerInventory x)
			{
				Item? parentItem = (Item?)x.get_ParentItem();
				Item vLG_Maui_Basket2 = CS_0024_003C_003E8__locals0.VLG_Maui_Basket01;
				if (parentItem != null)
				{
				}
				int num = 0;
				throw new NullReferenceException();
			};
			ContainerInventory containerInventory = Enumerable.FirstOrDefault<ContainerInventory>((IEnumerable<>)values, (Func<, >)(object)func);
			if (containerInventory != null)
			{
				containerInventory.blockMoveTo_ = true;
				Item vLG_Maui_Basket = CS_0024_003C_003E8__locals0.VLG_Maui_Basket01;
				string text = $"[ACTION] BlockMoveTo=true for '{vLG_Maui_Basket}'";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E17")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public StorageBlockMoveToProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
