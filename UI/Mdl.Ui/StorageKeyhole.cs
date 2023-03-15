using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Keyholes;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005EB")]
	public class StorageKeyhole : Storage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40020DE")]
		public Event sfxItemPlaced;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40020DF")]
		public Event sfxItemRemoved;

		[Cpp2IlInjected.Token(Token = "0x60026DF")]
		[Cpp2IlInjected.Address(RVA = "0x867ED0", Offset = "0x8668D0", VA = "0x180867ED0", Slot = "4")]
		public override Task TransferTo(ContainerInventory destination, int slotIndex)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E0")]
		[Cpp2IlInjected.Address(RVA = "0x867ED0", Offset = "0x8668D0", VA = "0x180867ED0")]
		[AsyncStateMachine(typeof(_003CTransferToAsync_003Ed__3))]
		private Task TransferToAsync(ContainerInventory destination, int slotIndex)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E1")]
		[Cpp2IlInjected.Address(RVA = "0x867D90", Offset = "0x866790", VA = "0x180867D90", Slot = "5")]
		public override Task TransferFrom(ContainerInventory origin, int slotIndex)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E2")]
		[Cpp2IlInjected.Address(RVA = "0x867D90", Offset = "0x866790", VA = "0x180867D90")]
		[AsyncStateMachine(typeof(_003CTransferFromAsync_003Ed__5))]
		private Task TransferFromAsync(ContainerInventory origin, int slotIndex)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E3")]
		[Cpp2IlInjected.Address(RVA = "0x8674E0", Offset = "0x865EE0", VA = "0x1808674E0", Slot = "6")]
		[IteratorStateMachine(typeof(_003CGetItemsToDisplay_003Ed__6))]
		public override IEnumerable<(Item, ItemState, int, bool)> GetItemsToDisplay()
		{
			new _003CGetItemsToDisplay_003Ed__6(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026E4")]
		[Cpp2IlInjected.Address(RVA = "0x867550", Offset = "0x865F50", VA = "0x180867550", Slot = "7")]
		public override bool HasAvailableSlot()
		{
			//Discarded unreachable code: IL_0033
			RepeatedField<KeyholeContent> content_ = _keyhole.content_;
			Func<KeyholeContent, bool> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
			if (_003C_003E9__7_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(KeyholeContent x)
				{
					int itemID = x.ItemID;
					throw new NullReferenceException();
				};
			}
			return ((IEnumerable<>)(object)content_).Any<KeyholeContent>((Func<, >)(object)_003C_003E9__7_);
		}

		[Cpp2IlInjected.Token(Token = "0x60026E5")]
		[Cpp2IlInjected.Address(RVA = "0x867360", Offset = "0x865D60", VA = "0x180867360", Slot = "8")]
		public override int GetEmptySlotIndex()
		{
			//Discarded unreachable code: IL_0046, IL_0048
			RepeatedField<KeyholeContent> content_ = _keyhole.content_;
			Func<KeyholeContent, bool> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_0;
			if (_003C_003E9__8_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(KeyholeContent x)
				{
					int itemID = x.ItemID;
					throw new NullReferenceException();
				};
			}
			int num = MoreLinq.FindIndex<KeyholeContent>((IEnumerable<>)(object)content_, (Func<, >)(object)_003C_003E9__8_);
			return ((RepeatedField<T>)(object)_keyhole.content_).Count;
		}

		[Cpp2IlInjected.Token(Token = "0x60026E6")]
		[Cpp2IlInjected.Address(RVA = "0x867BB0", Offset = "0x8665B0", VA = "0x180867BB0", Slot = "9")]
		public override void SplitStack(int slotIndex, int amount)
		{
			//Discarded unreachable code: IL_0058
			//IL_0046: Expected O, but got I8
			//IL_0052: Expected O, but got I4
			TransactionService.TransactionServiceClient transactionService = SystemRoot.Instance.MetaClient.TransactionService;
			SwapItemInKeyhole.Types.Request request = new SwapItemInKeyhole.Types.Request();
			string text = (request.SourceKeyholeGUID = _keyhole.gUID_);
			int emptySlotIndex = GetEmptySlotIndex();
			request.sourcePosition_ = slotIndex;
			request.destinationPosition_ = emptySlotIndex;
			ulong num = default(ulong);
			request.amountToMove_ = (int?)(object)num;
			int num2 = 0;
			transactionService.SwapItemInKeyholeAsync(request, (CancellationToken)num2).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60026E7")]
		[Cpp2IlInjected.Address(RVA = "0x867830", Offset = "0x866230", VA = "0x180867830", Slot = "10")]
		public override Task MoveTo(ContainerInventory inventory, int originSlotIndex, int destinationSlotIndex)
		{
			//IL_003b: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			TransactionService.TransactionServiceClient transactionService = SystemRoot.Instance.MetaClient.TransactionService;
			RemoveItemFromKeyhole.Types.Request request = new RemoveItemFromKeyhole.Types.Request();
			string text = (request.SourceKeyholeGUID = _keyhole.gUID_);
			uint iD_ = inventory.iD_;
			int num = 0;
			request.destinationInventoryID_ = (uint?)(object)num;
			request.sourcePosition_ = originSlotIndex;
			request.destinationPosition_ = (int?)(object)num;
			Task<RemoveItemFromKeyhole.Types.Response> task = (Task<RemoveItemFromKeyhole.Types.Response>)(object)transactionService.RemoveItemFromKeyholeAsync(request, (CancellationToken)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026E8")]
		[Cpp2IlInjected.Address(RVA = "0x867690", Offset = "0x866090", VA = "0x180867690", Slot = "12")]
		internal override Task MoveFrom(ContainerInventory inventory, int originSlotIndex, int itemIndex)
		{
			//IL_0046: Expected O, but got I8
			//IL_0052: Expected O, but got I4
			TransactionService.TransactionServiceClient transactionService = SystemRoot.Instance.MetaClient.TransactionService;
			AddItemToKeyhole.Types.Request request = new AddItemToKeyhole.Types.Request();
			uint num = (request.sourceInventoryID_ = inventory.iD_);
			request.sourcePosition_ = originSlotIndex;
			string text = (request.DestinationKeyholeGUID = _keyhole.gUID_);
			ulong num2 = default(ulong);
			request.destinationPosition_ = (int?)(object)num2;
			int num3 = 0;
			Task<AddItemToKeyhole.Types.Response> task = (Task<AddItemToKeyhole.Types.Response>)(object)transactionService.AddItemToKeyholeAsync(request, (CancellationToken)num3);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026E9")]
		[Cpp2IlInjected.Address(RVA = "0x867A00", Offset = "0x866400", VA = "0x180867A00", Slot = "11")]
		public override Task MoveTo(Meta.Keyhole inventory, int originSlotIndex, int destinationSlotIndex)
		{
			//IL_004d: Expected O, but got I4
			int num = 0;
			Task completedTask = Task.CompletedTask;
			TransactionService.TransactionServiceClient transactionService = SystemRoot.Instance.MetaClient.TransactionService;
			SwapItemInKeyhole.Types.Request request = new SwapItemInKeyhole.Types.Request();
			string text = (request.SourceKeyholeGUID = _keyhole.gUID_);
			request.destinationPosition_ = destinationSlotIndex;
			request.sourcePosition_ = originSlotIndex;
			int num2 = 0;
			Task<SwapItemInKeyhole.Types.Response> task = (Task<SwapItemInKeyhole.Types.Response>)(object)transactionService.SwapItemInKeyholeAsync(request, (CancellationToken)num2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60026EA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public StorageKeyhole()
		{
		}
	}
}
