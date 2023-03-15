using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000735")]
	public class StoreList : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40029C7")]
		public Action<InventoryItem> OnTapItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40029C8")]
		public Action<InventoryItem> OnBuyTap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40029C9")]
		[SerializeField]
		private GameObject _headerGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40029CA")]
		[SerializeField]
		private TextBase _header;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40029CB")]
		[SerializeField]
		private bool _showHeader = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40029CC")]
		[SerializeField]
		private ListBase _itemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40029CD")]
		[SerializeField]
		private LoopVerticalScrollRect _loopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40029CE")]
		[SerializeField]
		private bool _lockedSelectForOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40029CF")]
		private StoreMenu.StoreItem[] _dataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40029D0")]
		private ListInventory _inventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40029D1")]
		public AvatarAppearance Avatar;

		[Cpp2IlInjected.Token(Token = "0x1700069A")]
		public ItemFilterData ItemFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6002DE7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CItemFilters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DE8")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CItemFilters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069B")]
		public bool ShowHeader
		{
			[Cpp2IlInjected.Token(Token = "0x6002DE9")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return _showHeader;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DEA")]
			[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B930", VA = "0x18086CF30")]
			set
			{
				//Discarded unreachable code: IL_0014
				_showHeader = value;
				_headerGO.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069C")]
		public ListBase ItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6002DEB")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _itemList;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700069D")]
		public LoopVerticalScrollRect LoopScrollRect
		{
			[Cpp2IlInjected.Token(Token = "0x6002DEC")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return _loopScrollRect;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DED")]
		[Cpp2IlInjected.Address(RVA = "0x86BE70", Offset = "0x86A870", VA = "0x18086BE70")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_005a
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_loopScrollRect).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_loopScrollRect).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTap);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			GameObject headerGO = _headerGO;
			bool showHeader = _showHeader;
			headerGO.SetActive(showHeader);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEE")]
		[Cpp2IlInjected.Address(RVA = "0x86BD50", Offset = "0x86A750", VA = "0x18086BD50")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_0041
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_loopScrollRect).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_loopScrollRect).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTap);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEF")]
		[Cpp2IlInjected.Address(RVA = "0x86BC30", Offset = "0x86A630", VA = "0x18086BC30")]
		public void OnDestroy()
		{
			//Discarded unreachable code: IL_0041
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_loopScrollRect).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_loopScrollRect).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTap);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF0")]
		[Cpp2IlInjected.Address(RVA = "0x86CD60", Offset = "0x86B760", VA = "0x18086CD60")]
		public void SetFilter(ItemFilterData itemFilters)
		{
			ItemFilters = itemFilters;
			if (ItemFilters.type_ != ItemType.Clothing)
			{
				ListInventory listInventory = (_inventory = SystemRoot.Instance.MetaClient.profile.Catalog);
			}
			ListInventory wardrobe = SystemRoot.Instance.Client.Profile.Wardrobe;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF1")]
		[Cpp2IlInjected.Address(RVA = "0x86CC70", Offset = "0x86B670", VA = "0x18086CC70")]
		public void SetData(StoreMenu.StoreItem[] dataList)
		{
			//Discarded unreachable code: IL_0076
			if (dataList.Length == 0)
			{
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				_loopScrollRect.ClearCells();
				return;
			}
			base.gameObject.SetActive(value: true);
			_dataList = dataList;
			StoreMenu.StoreItem[] dataList2 = _dataList;
			LoopVerticalScrollRect loopScrollRect = _loopScrollRect;
			int num = (loopScrollRect.totalCount = dataList2.Length);
			LoopVerticalScrollRect loopScrollRect2 = _loopScrollRect;
			int offset = 0;
			loopScrollRect2.RefillCells(offset);
			_loopScrollRect.ResetVerticalValue();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF2")]
		[Cpp2IlInjected.Address(RVA = "0x86BFA0", Offset = "0x86A9A0", VA = "0x18086BFA0")]
		private void OnItemDataHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0316
			//IL_001d: Expected O, but got I4
			//IL_0095: Expected I4, but got I8
			//IL_017e: Expected O, but got I4
			//IL_018d: Expected I4, but got O
			//IL_01e0: Expected O, but got I4
			//IL_023c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
			int num4 = 0;
			Profile profile;
			IHasUnlockConditions unlockConditions;
			if (component != (UnityEngine.Object)num4 && (IntPtr)_dataList != (IntPtr)num)
			{
				Action<InventoryItem> action = (component.BuyAction = (Action<InventoryItem>)(object)new Action<T>(OnBuyTapHandler));
				StoreMenu.StoreItem[] dataList = _dataList;
				int itemIndex = args.ItemIndex;
				IItemData itemData = (component.ItemData = dataList[itemIndex].Item);
				IItemData itemData2 = component.ItemData;
				Client client = default(Client);
				profile = client.profile;
				unlockConditions = itemData2.GetUnlockConditions();
				if (unlockConditions != null)
				{
				}
				component.IsBuyable = true;
				IItemData itemData3 = component.ItemData;
				ListInventory inventory = _inventory;
				component.IsOwned = (byte)num != 0;
				if ((object)Avatar != null)
				{
				}
				bool flag = (component.IsMale = num != 0);
				component.gameObject.SetActive(value: true);
				StoreMenu.StoreItem[] dataList2 = _dataList;
				int itemIndex2 = args.ItemIndex;
				int? num5 = (component._maxPurchasableAmount = dataList2[itemIndex2].Amount);
				if ((component.IsBuyable ? 1 : 0) != num)
				{
					InventoryItem.InventoryGridItemPurchased onItemPurchased = component.OnItemPurchased;
					InventoryItem.InventoryGridItemPurchased value = OnItemPurchasedHandler;
					Delegate @delegate = Delegate.Remove(onItemPurchased, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						component.OnItemPurchased = (InventoryItem.InventoryGridItemPurchased)@delegate;
						InventoryItem.InventoryGridItemPurchased onItemPurchased2 = component.OnItemPurchased;
						InventoryItem.InventoryGridItemPurchased b = OnItemPurchasedHandler;
						Delegate delegate2 = Delegate.Combine(onItemPurchased2, b);
						if ((object)delegate2 == null || (object)delegate2 != null)
						{
							component.OnItemPurchased = (InventoryItem.InventoryGridItemPurchased)delegate2;
							goto IL_016f;
						}
					}
					throw new InvalidCastException();
				}
				goto IL_016f;
			}
			goto IL_02e3;
			IL_02e3:
			if (ItemFilters.type_ != ItemType.Clothing)
			{
				component.HideOwned = false;
				int num6 = ((component.IsSelected = false) ? 1 : 0);
			}
			RefreshSelected(component);
			((BaseWardrobeItem)component)._oY = -128f;
			return;
			IL_016f:
			int num7 = 0;
			string arg = LocalizationManager.FromStringID("menu.level_abbr_lvl", (IResolver)num7);
			if (unlockConditions == null)
			{
				component.IsLocked = (byte)(int)unlockConditions != 0;
				component.HideLocked();
			}
			int level_ = profile.player_.level_;
			bool flag3 = default(bool);
			if (!flag3)
			{
				TextBase lockedLabelAsset = component.LockedLabelAsset;
				component.IsLocked = flag3;
				lockedLabelAsset.StringID = "?";
				component.HideLocked();
			}
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int num8 = 0;
			Mdl.Characters.Character character = default(Mdl.Characters.Character);
			bool isUnlocked = default(bool);
			if (!(character == (UnityEngine.Object)num8))
			{
				isUnlocked = character.IsUnlocked;
				if (isUnlocked)
				{
					component.HideLocked();
				}
				TextBase lockedLabelAsset2 = component.LockedLabelAsset;
				string text = (lockedLabelAsset2.StringID = character.Data.displayName_);
			}
			component.LockedLabelAsset.StringID = "C";
			TextBase lockedLabelAsset3 = component.LockedLabelAsset;
			string text3 = (lockedLabelAsset3.Text = $"{arg}<br><size=120%>{isUnlocked}");
			if (num == 0)
			{
				GameObject gameObject = component.AmountAsset.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			component.IsOwned = false;
			ItemFilterData itemFilterData = ItemFilters;
			RectTransform amountAsset = component.AmountAsset;
			if (itemFilterData.type_ == ItemType.Clothing)
			{
				GameObject gameObject2 = amountAsset.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
			}
			GameObject gameObject3 = default(GameObject);
			gameObject3.SetActive(value: true);
			string text4 = default(string);
			component.AmountTextAsset.Text = text4;
			component.RefreshSizeAmount();
			component.HideLocked();
			component.RefreshDisplay();
			if (_lockedSelectForOwned)
			{
				GameObject gameObject4 = component._tfOwned.gameObject;
				int active3 = 0;
				gameObject4.SetActive((byte)active3 != 0);
			}
			goto IL_02e3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF3")]
		[Cpp2IlInjected.Address(RVA = "0x86C910", Offset = "0x86B310", VA = "0x18086C910")]
		private void OnItemTap(ListEventData args)
		{
			//Discarded unreachable code: IL_0036
			InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
			if (ItemFilters.type_ != ItemType.Furniture || !_lockedSelectForOwned)
			{
				((Action<T>)(object)OnTapItem)?.Invoke((T)component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF4")]
		[Cpp2IlInjected.Address(RVA = "0x86BBE0", Offset = "0x86A5E0", VA = "0x18086BBE0")]
		private void OnBuyTapHandler(InventoryItem item)
		{
			((Action<T>)(object)OnBuyTap)?.Invoke((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF5")]
		[Cpp2IlInjected.Address(RVA = "0x86CBA0", Offset = "0x86B5A0", VA = "0x18086CBA0")]
		private void RefreshSelected(InventoryItem item)
		{
			//Discarded unreachable code: IL_002f
			//IL_0010: Expected O, but got I4
			AvatarAppearance avatar = Avatar;
			int num = 0;
			if (!(avatar == (UnityEngine.Object)num))
			{
				AvatarAppearance avatar2 = Avatar;
				IItemData itemData = item.ItemData;
				bool flag = default(bool);
				bool flag3 = (item.IsSelected = flag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF6")]
		[Cpp2IlInjected.Address(RVA = "0x86C9A0", Offset = "0x86B3A0", VA = "0x18086C9A0")]
		public void RefreshAll()
		{
			//Discarded unreachable code: IL_0040, IL_0052
			//IL_002c: Expected O, but got I4
			IEnumerator enumerator = ((LoopScrollRect)_loopScrollRect).m_Content.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				InventoryItem inventoryItem = default(InventoryItem);
				flag = inventoryItem != (UnityEngine.Object)num3;
				while (!flag)
				{
				}
				RefreshSelected(inventoryItem);
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF7")]
		[Cpp2IlInjected.Address(RVA = "0x86C8F0", Offset = "0x86B2F0", VA = "0x18086C8F0")]
		public void RefreshCells()
		{
			//Discarded unreachable code: IL_000c
			_loopScrollRect.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF8")]
		[Cpp2IlInjected.Address(RVA = "0x86C8F0", Offset = "0x86B2F0", VA = "0x18086C8F0")]
		private void OnItemPurchasedHandler([Optional] IItemData itemData, bool refreshNodes = false)
		{
			//Discarded unreachable code: IL_000c
			_loopScrollRect.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF9")]
		[Cpp2IlInjected.Address(RVA = "0x86BBC0", Offset = "0x86A5C0", VA = "0x18086BBC0")]
		public bool IsEmpty()
		{
			StoreMenu.StoreItem[] dataList = _dataList;
			if (dataList != null)
			{
				return dataList.Length == 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DFA")]
		[Cpp2IlInjected.Address(RVA = "0x86CF20", Offset = "0x86B920", VA = "0x18086CF20")]
		public StoreList()
		{
		}
	}
}
