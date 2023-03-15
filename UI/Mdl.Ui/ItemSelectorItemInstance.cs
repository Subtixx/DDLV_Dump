using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Meta;
using Meta.Missions;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007C0")]
	public class ItemSelectorItemInstance : IItemSelectorItem
	{
		[Cpp2IlInjected.Token(Token = "0x20007C1")]
		private class IconLoader
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002D90")]
			private AsyncAtlassedIcon _icon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002D91")]
			private string _key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002D92")]
			private TaskCompletionSource<bool> _loadIconCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x6003193")]
			[Cpp2IlInjected.Address(RVA = "0xAFCE10", Offset = "0xAFB810", VA = "0x180AFCE10")]
			public IconLoader(AsyncAtlassedIcon icon, string key)
			{
				_icon = icon;
				TaskCompletionSource<bool> taskCompletionSource = (_loadIconCompletionSource = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
				_key = key;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003194")]
			[Cpp2IlInjected.Address(RVA = "0xAFCC60", Offset = "0xAFB660", VA = "0x180AFCC60")]
			[AsyncStateMachine(typeof(_003CLoad_003Ed__4))]
			public Task Load()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003195")]
			[Cpp2IlInjected.Address(RVA = "0xAFCB90", Offset = "0xAFB590", VA = "0x180AFCB90")]
			public void Cancel()
			{
				//Discarded unreachable code: IL_004a
				//IL_0010: Expected O, but got I4
				//IL_0047: Expected O, but got I4
				AsyncAtlassedIcon icon = _icon;
				int num = 0;
				bool flag = icon.SetIcon((string)num);
				AsyncAtlassedIcon icon2 = _icon;
				AsyncAtlassedIcon.ImageLoaded value = OnImageLoaded;
				icon2.OnImageLoaded -= value;
				TaskCompletionSource<bool> loadIconCompletionSource = _loadIconCompletionSource;
				if (loadIconCompletionSource != null)
				{
					int num2 = 0;
					bool flag2 = ((TaskCompletionSource<TResult>)(object)loadIconCompletionSource).TrySetResult((TResult)num2);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6003196")]
			[Cpp2IlInjected.Address(RVA = "0xAFCD60", Offset = "0xAFB760", VA = "0x180AFCD60")]
			private void OnImageLoaded(AsyncAtlassedIcon image)
			{
				//Discarded unreachable code: IL_0028
				//IL_0026: Expected O, but got I4
				AsyncAtlassedIcon.ImageLoaded value = OnImageLoaded;
				image.OnImageLoaded -= value;
				TaskCompletionSource<bool> loadIconCompletionSource = _loadIconCompletionSource;
				if (loadIconCompletionSource != null)
				{
					bool flag = ((TaskCompletionSource<TResult>)(object)loadIconCompletionSource).TrySetResult((TResult)1);
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002D8D")]
		private ItemInstance _item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D8E")]
		private IItemData _itemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D8F")]
		private IconLoader _iconLoader;

		[Cpp2IlInjected.Token(Token = "0x170006F6")]
		public bool CanHaveAdditionalIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600318A")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F7")]
		public bool CanHaveCountIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x600318B")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "5")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F8")]
		public bool AlwaysAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x600318C")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F9")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600318D")]
			[Cpp2IlInjected.Address(RVA = "0x1320BD0", Offset = "0x131F5D0", VA = "0x181320BD0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _item.ItemAmount.amount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FA")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600318E")]
			[Cpp2IlInjected.Address(RVA = "0x1320C00", Offset = "0x131F600", VA = "0x181320C00", Slot = "9")]
			get
			{
				IItemData itemData = _itemData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FB")]
		public ItemType? ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600318F")]
			[Cpp2IlInjected.Address(RVA = "0x1320C50", Offset = "0x131F650", VA = "0x181320C50", Slot = "8")]
			get
			{
				Item item = _item.Item;
				ItemType itemType = default(ItemType);
				int num = (int)itemType;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003190")]
		[Cpp2IlInjected.Address(RVA = "0x1320AB0", Offset = "0x131F4B0", VA = "0x181320AB0")]
		public ItemSelectorItemInstance(ItemInstance item)
		{
			_item = item;
			ItemInstance item2 = _item;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item3 = item2.Item;
			IItemData itemData = default(IItemData);
			_itemData = itemData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003191")]
		[Cpp2IlInjected.Address(RVA = "0x13208E0", Offset = "0x131F2E0", VA = "0x1813208E0", Slot = "10")]
		public bool ShowQuestMarker(IEnumerable<ProfileWorld.FilterInfo> quests)
		{
			if (!_itemData.IsMissionItem())
			{
				ItemInstance item = _item;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item2 = item.Item;
				bool flag = default(bool);
				if (!flag)
				{
					return flag;
				}
				Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
				SeedItemData seedItemData = default(SeedItemData);
				Func<ProfileWorld.FilterInfo, bool> cpp2il__autoParamName__idx_ = (Func<ProfileWorld.FilterInfo, bool>)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo x)
				{
					//Discarded unreachable code: IL_002e
					List<MissionObjective> _003CObjectives_003Ek__BackingField = x.Objectives;
					Func<MissionObjective, bool> func2 = func;
					if (func2 == null)
					{
						func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
						{
							//Discarded unreachable code: IL_0048
							ItemFilter itemFilter_ = obj.itemFilter_;
							Item[] array = new Item[2];
							Item item3 = (array[0] = _item.Item);
							Item item4 = (array[0] = seedItemData.ProducedItem);
							return Enumerable.Any<Item>((IEnumerable<>)itemFilter_.ApplyFilter((IEnumerable<>)(object)array));
						};
					}
					return ((IEnumerable<>)_003CObjectives_003Ek__BackingField).Any<MissionObjective>((Func<, >)(object)func2);
				};
				bool flag2 = ((IEnumerable<>)quests).Any<ProfileWorld.FilterInfo>((Func<, >)(object)cpp2il__autoParamName__idx_);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003192")]
		[Cpp2IlInjected.Address(RVA = "0x13207C0", Offset = "0x131F1C0", VA = "0x1813207C0", Slot = "11")]
		[AsyncStateMachine(typeof(_003CLoadIcon_003Ed__18))]
		public Task LoadIcon(AsyncAtlassedIcon icon, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
