using System.Collections.Generic;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005DD")]
	public abstract class Storage : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40020AB")]
		protected ContainerInventory _containerInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40020AC")]
		protected Keyhole _keyhole;

		[Cpp2IlInjected.Token(Token = "0x170005E3")]
		public ContainerInventory ContainerInventory
		{
			[Cpp2IlInjected.Token(Token = "0x600268F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _containerInventory;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E4")]
		public Keyhole Keyhole
		{
			[Cpp2IlInjected.Token(Token = "0x6002690")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _keyhole;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E5")]
		public bool IsHomeStorage
		{
			[Cpp2IlInjected.Token(Token = "0x6002691")]
			[Cpp2IlInjected.Address(RVA = "0x869910", Offset = "0x868310", VA = "0x180869910")]
			get
			{
				//Discarded unreachable code: IL_0027
				ContainerInventory containerInventory = _containerInventory;
				if (containerInventory == null)
				{
					int num = 0;
				}
				ContainerInventory homeStorage = SystemRoot.Instance.MetaClient.profile.HomeStorage;
				return containerInventory == homeStorage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002692")]
		[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
		public void Init(ContainerInventory containerInventory)
		{
			_containerInventory = containerInventory;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002693")]
		[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
		public void Init(Keyhole keyhole)
		{
			_keyhole = keyhole;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002694")]
		[Cpp2IlInjected.Address(RVA = "0x8698C0", Offset = "0x8682C0", VA = "0x1808698C0", Slot = "4")]
		public virtual Task TransferTo(ContainerInventory destination, int slotIndex)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6002695")]
		[Cpp2IlInjected.Address(RVA = "0x869870", Offset = "0x868270", VA = "0x180869870", Slot = "5")]
		public virtual Task TransferFrom(ContainerInventory origin, int slotIndex)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6002696")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
		public virtual IEnumerable<(Item, ItemState, int, bool)> GetItemsToDisplay()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002697")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "7")]
		public virtual bool HasAvailableSlot()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002698")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
		public virtual int GetEmptySlotIndex()
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002699")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "9")]
		public virtual void SplitStack(int slotIndex, int amount)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600269A")]
		[Cpp2IlInjected.Address(RVA = "0x8697D0", Offset = "0x8681D0", VA = "0x1808697D0", Slot = "10")]
		public virtual Task MoveTo(ContainerInventory inventory, int originSlotIndex, int destinationSlotIndex)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600269B")]
		[Cpp2IlInjected.Address(RVA = "0x869820", Offset = "0x868220", VA = "0x180869820", Slot = "11")]
		public virtual Task MoveTo(Keyhole inventory, int originSlotIndex, int destinationSlotIndex)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600269C")]
		[Cpp2IlInjected.Address(RVA = "0x869780", Offset = "0x868180", VA = "0x180869780", Slot = "12")]
		internal virtual Task MoveFrom(ContainerInventory inventory, int originSlotIndex, int itemIndex)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600269D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected Storage()
		{
		}
	}
}
