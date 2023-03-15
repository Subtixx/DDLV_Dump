using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Ftue;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Assets.Scripts.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CreateAssetMenu]
	public class ItemAcquired : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		[ItemID]
		public int item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private Client _client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private Item _item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private Item _acquiredItem = Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private int _acquiredAmount;

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x11BE540", Offset = "0x11BCF40", VA = "0x1811BE540", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_0231
			//IL_022b: Expected O, but got I4
			_client = client;
			int num = item;
			_item = (Item)"FtueCondition";
			ItemType itemType = default(ItemType);
			if (itemType <= ItemType.Companion)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = _client.Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value = OnCharacterUnlocked;
				_003CDispatcher_003Ek__BackingField.OnCharacterUnlocked -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = _client.Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value2 = OnCharacterUnlocked;
				_003CDispatcher_003Ek__BackingField2.OnCharacterUnlocked += value2;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = _client.Dispatcher;
				ProfileEventDispatcher.BuildingBuilt value3 = OnBuildingBuilt;
				_003CDispatcher_003Ek__BackingField3.OnBuildingBuilt -= value3;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = _client.Dispatcher;
				ProfileEventDispatcher.BuildingBuilt value4 = OnBuildingBuilt;
				_003CDispatcher_003Ek__BackingField4.OnBuildingBuilt += value4;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = _client.Dispatcher;
				ProfileEventDispatcher.ItemAdded value5 = OnItemAdded;
				_003CDispatcher_003Ek__BackingField5.OnItemAdded -= value5;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = _client.Dispatcher;
				ProfileEventDispatcher.ItemAdded value6 = OnItemAdded;
				_003CDispatcher_003Ek__BackingField6.OnItemAdded += value6;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField7 = _client.Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value7 = OnCurrencyChanged;
				_003CDispatcher_003Ek__BackingField7.OnCurrencyChanged -= value7;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField8 = _client.Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value8 = OnCurrencyChanged;
				_003CDispatcher_003Ek__BackingField8.OnCurrencyChanged += value8;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField9 = _client.Dispatcher;
				ProfileEventDispatcher.ToolAdded value9 = OnToolAdded;
				_003CDispatcher_003Ek__BackingField9.OnToolAdded -= value9;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField10 = _client.Dispatcher;
				ProfileEventDispatcher.ToolAdded value10 = OnToolAdded;
				_003CDispatcher_003Ek__BackingField10.OnToolAdded += value10;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField11 = _client.Dispatcher;
				ProfileEventDispatcher.PetUnlocked value11 = OnPetUnlocked;
				_003CDispatcher_003Ek__BackingField11.OnPetUnlocked -= value11;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField12 = _client.Dispatcher;
				ProfileEventDispatcher.PetUnlocked value12 = OnPetUnlocked;
				_003CDispatcher_003Ek__BackingField12.OnPetUnlocked += value12;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField13 = _client.Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value13 = OnMemoryShardAdded;
				_003CDispatcher_003Ek__BackingField13.OnMemoryShardAdded -= value13;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField14 = _client.Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value14 = OnMemoryShardAdded;
				_003CDispatcher_003Ek__BackingField14.OnMemoryShardAdded += value14;
			}
			ItemType itemType2 = default(ItemType);
			Debug.LogError(string.Format("[{0}] {1}: Type \"{2}\" is not supported", "FtueCondition", "ItemAcquired", itemType2));
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x11BE230", Offset = "0x11BCC30", VA = "0x1811BE230", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0107
			Client client = _client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				if (_003CDispatcher_003Ek__BackingField != null)
				{
					ProfileEventDispatcher.CharacterUnlocked value = OnCharacterUnlocked;
					_003CDispatcher_003Ek__BackingField.OnCharacterUnlocked -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = _client.Dispatcher;
					ProfileEventDispatcher.BuildingBuilt value2 = OnBuildingBuilt;
					_003CDispatcher_003Ek__BackingField2.OnBuildingBuilt -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = _client.Dispatcher;
					ProfileEventDispatcher.ItemAdded value3 = OnItemAdded;
					_003CDispatcher_003Ek__BackingField3.OnItemAdded -= value3;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = _client.Dispatcher;
					ProfileEventDispatcher.CurrencyChanged value4 = OnCurrencyChanged;
					_003CDispatcher_003Ek__BackingField4.OnCurrencyChanged -= value4;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = _client.Dispatcher;
					ProfileEventDispatcher.ToolAdded value5 = OnToolAdded;
					_003CDispatcher_003Ek__BackingField5.OnToolAdded -= value5;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField6 = _client.Dispatcher;
					ProfileEventDispatcher.PetUnlocked value6 = OnPetUnlocked;
					_003CDispatcher_003Ek__BackingField6.OnPetUnlocked -= value6;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField7 = _client.Dispatcher;
					ProfileEventDispatcher.MemoryShardAdded value7 = OnMemoryShardAdded;
					_003CDispatcher_003Ek__BackingField7.OnMemoryShardAdded -= value7;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x11BEC00", Offset = "0x11BD600", VA = "0x1811BEC00", Slot = "5")]
		protected override bool _IsTrue()
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(Item).TypeHandle == null)
			{
				return (byte)(int)typeof(Item).TypeHandle != 0;
			}
			return _acquiredAmount > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x11BE180", Offset = "0x11BCB80", VA = "0x1811BE180")]
		private void OnCharacterUnlocked(Item characterItem)
		{
			//IL_0010: Expected I4, but got I8
			_acquiredItem = characterItem;
			_acquiredAmount = 1;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x11BE180", Offset = "0x11BCB80", VA = "0x1811BE180")]
		private void OnBuildingBuilt(Item item)
		{
			//IL_0010: Expected I4, but got I8
			_acquiredItem = item;
			_acquiredAmount = 1;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x11BE1F0", Offset = "0x11BCBF0", VA = "0x1811BE1F0")]
		private void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			_acquiredItem = item;
			_acquiredAmount = amount;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x11BE1C0", Offset = "0x11BCBC0", VA = "0x1811BE1C0")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			_acquiredItem = currencyItem;
			_acquiredAmount = gained;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x11BE180", Offset = "0x11BCB80", VA = "0x1811BE180")]
		private void OnToolAdded(Item toolItem)
		{
			//IL_0010: Expected I4, but got I8
			_acquiredItem = toolItem;
			_acquiredAmount = 1;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x11BE180", Offset = "0x11BCB80", VA = "0x1811BE180")]
		private void OnPetUnlocked(Item petItem, AddDetail detail)
		{
			//IL_0010: Expected I4, but got I8
			_acquiredItem = petItem;
			_acquiredAmount = 1;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x11BE180", Offset = "0x11BCB80", VA = "0x1811BE180")]
		private void OnMemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail)
		{
			//IL_0010: Expected I4, but got I8
			_acquiredItem = memoryShardItem;
			_acquiredAmount = 1;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x11BE1C0", Offset = "0x11BCBC0", VA = "0x1811BE1C0")]
		private void Validate(Item item, int amount)
		{
			_acquiredItem = item;
			_acquiredAmount = amount;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x11BEC90", Offset = "0x11BD690", VA = "0x1811BEC90")]
		public ItemAcquired()
		{
		}
	}
}
