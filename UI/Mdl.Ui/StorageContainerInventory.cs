using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using Meta.Online;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005DE")]
	public class StorageContainerInventory : Storage
	{
		[Cpp2IlInjected.Token(Token = "0x600269E")]
		[Cpp2IlInjected.Address(RVA = "0x863C60", Offset = "0x862660", VA = "0x180863C60", Slot = "4")]
		public override Task TransferTo(ContainerInventory destination, int slotIndex)
		{
			ContainerInventory containerInventory = _containerInventory;
			return TransferItemSlot(containerInventory, destination, slotIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x600269F")]
		[Cpp2IlInjected.Address(RVA = "0x863B00", Offset = "0x862500", VA = "0x180863B00", Slot = "5")]
		public override Task TransferFrom(ContainerInventory origin, int slotIndex)
		{
			ContainerInventory containerInventory = _containerInventory;
			return TransferItemSlot(origin, containerInventory, slotIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60026A0")]
		[Cpp2IlInjected.Address(RVA = "0x863B20", Offset = "0x862520", VA = "0x180863B20")]
		[AsyncStateMachine(typeof(_003CTransferItemSlot_003Ed__2))]
		private Task TransferItemSlot(ContainerInventory source, ContainerInventory destination, int itemIndex)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026A1")]
		[Cpp2IlInjected.Address(RVA = "0x863600", Offset = "0x862000", VA = "0x180863600", Slot = "6")]
		public override IEnumerable<(Item, ItemState, int, bool)> GetItemsToDisplay()
		{
			return (IEnumerable<(Item, ItemState, int, bool)>)ContainerInventoryExtension.GetItemsToDisplay(_containerInventory);
		}

		[Cpp2IlInjected.Token(Token = "0x60026A2")]
		[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862010", VA = "0x180863610", Slot = "7")]
		public override bool HasAvailableSlot()
		{
			//Discarded unreachable code: IL_0052
			int count = ((RepeatedField<T>)(object)_containerInventory.inventory_).Count;
			ContainerInventory containerInventory = _containerInventory;
			if (count < containerInventory.size_)
			{
			}
			RepeatedField<ContainerInventory.Types.Slot> inventory_ = containerInventory.inventory_;
			Func<ContainerInventory.Types.Slot, bool> cpp2il__autoParamName__idx_ = default(Func<ContainerInventory.Types.Slot, bool>);
			if (_003C_003Ec._003C_003E9__4_0 == null)
			{
				cpp2il__autoParamName__idx_ = (Func<ContainerInventory.Types.Slot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ContainerInventory.Types.Slot x)
				{
					int itemID = x.ItemID;
					throw new NullReferenceException();
				});
			}
			return ((IEnumerable<>)(object)inventory_).Any<ContainerInventory.Types.Slot>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x60026A3")]
		[Cpp2IlInjected.Address(RVA = "0x863480", Offset = "0x861E80", VA = "0x180863480", Slot = "8")]
		public override int GetEmptySlotIndex()
		{
			//Discarded unreachable code: IL_0046
			RepeatedField<ContainerInventory.Types.Slot> inventory_;
			Func<ContainerInventory.Types.Slot, bool> _003C_003E9__5_;
			do
			{
				inventory_ = _containerInventory.inventory_;
				_003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
				if (_003C_003E9__5_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ContainerInventory.Types.Slot x)
					{
						int itemID = x.ItemID;
						throw new NullReferenceException();
					};
				}
			}
			while (MoreLinq.FindIndex<ContainerInventory.Types.Slot>((IEnumerable<>)(object)inventory_, (Func<, >)(object)_003C_003E9__5_) != -1);
			return ((RepeatedField<T>)(object)_containerInventory.inventory_).Count;
		}

		[Cpp2IlInjected.Token(Token = "0x60026A4")]
		[Cpp2IlInjected.Address(RVA = "0x863920", Offset = "0x862320", VA = "0x180863920", Slot = "9")]
		public override void SplitStack(int slotIndex, int amount)
		{
			//Discarded unreachable code: IL_0056
			//IL_003d: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			Client metaClient = SystemRoot.Instance.MetaClient;
			MoveInContainerInventory.Types.Request request = new MoveInContainerInventory.Types.Request();
			uint num = (request.sourceInventoryID_ = _containerInventory.iD_);
			request.sourcePosition_ = slotIndex;
			int emptySlotIndex = GetEmptySlotIndex();
			int num2 = 0;
			request.destinationPosition_ = (int?)(object)num2;
			emptySlotIndex = amount;
			request.amountToMove_ = (int?)(object)num2;
			metaClient.MoveInContainerInventory(request, (CancellationToken)num2).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60026A5")]
		[Cpp2IlInjected.Address(RVA = "0x863790", Offset = "0x862190", VA = "0x180863790", Slot = "11")]
		public override Task MoveTo(Keyhole inventory, int originSlotIndex, int destinationSlotIndex)
		{
			//IL_0038: Expected O, but got I8
			//IL_004b: Expected O, but got I4
			TransactionService.TransactionServiceClient transactionService = SystemRoot.Instance.MetaClient.TransactionService;
			RemoveItemFromKeyhole.Types.Request request = new RemoveItemFromKeyhole.Types.Request();
			string text = (request.SourceKeyholeGUID = inventory.gUID_);
			uint iD_ = _containerInventory.iD_;
			ulong num = default(ulong);
			request.destinationInventoryID_ = (uint?)(object)num;
			request.sourcePosition_ = destinationSlotIndex;
			int num2 = 0;
			Task<RemoveItemFromKeyhole.Types.Response> task = (Task<RemoveItemFromKeyhole.Types.Response>)(object)transactionService.RemoveItemFromKeyholeAsync(request, (CancellationToken)num2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026A6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public StorageContainerInventory()
		{
		}
	}
}
