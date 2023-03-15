using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf.Collections;
using Mdl.Grid;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B7B")]
	public class LootPresent : MonoBehaviour, IDefaultGridStateProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17000734")]
		public MultiItemInstance LootPresentData
		{
			[Cpp2IlInjected.Token(Token = "0x600352D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CLootPresentData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600352E")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CLootPresentData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600352F")]
		[Cpp2IlInjected.Address(RVA = "0xBBD100", Offset = "0xBBBB00", VA = "0x180BBD100", Slot = "4")]
		public void InitFromGridState(GridState gridState)
		{
			//IL_002f: Expected O, but got I4
			if (gridState != null)
			{
				AmountWithState itemAmountState = gridState.ItemAmountState;
				if (itemAmountState != null)
				{
					MultiItemInstance lootPresentData = itemAmountState.state_.LootPresentData;
					if (lootPresentData != null)
					{
						MultiItemInstance multiItemInstance = lootPresentData.Clone();
					}
				}
			}
			int num = 0;
			LootPresentData = (MultiItemInstance)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003530")]
		[Cpp2IlInjected.Address(RVA = "0xBBCFB0", Offset = "0xBBB9B0", VA = "0x180BBCFB0", Slot = "5")]
		public bool ForceGridState(ref GridState gridState, ITransactionContext context)
		{
			MultiItemInstance multiItemInstance = LootPresentData;
			if (multiItemInstance != null && ((RepeatedField<T>)(object)multiItemInstance.items_).Count > 0)
			{
				GridState gridState2 = new GridState();
				AmountWithState amountWithState = new AmountWithState();
				ItemState itemState = new ItemState();
				MultiItemInstance multiItemInstance3 = (itemState.LootPresentData = LootPresentData);
				amountWithState.state_ = itemState;
				gridState2.ItemAmountState = amountWithState;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003531")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public void ChangeGridState(GridState gridState, ITransactionContext context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003532")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public LootPresent()
		{
		}
	}
}
