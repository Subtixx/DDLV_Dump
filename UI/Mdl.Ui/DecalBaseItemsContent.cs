using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.Avatar;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200074F")]
	[RequiredAllNotNull]
	public class DecalBaseItemsContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AA9")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AAA")]
		[Nulllable]
		public FocusNavigation FocusNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AAB")]
		private ClothingItemData[] _allClothes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002AAC")]
		[SerializeField]
		private Sprite _spriteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002AAD")]
		private IItemData _lastClothesSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002AAE")]
		[SerializeField]
		private LoopVerticalScrollRect _listBaseItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002AB1")]
		[SerializeField]
		private RectTransform _mcItemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002AB2")]
		[SerializeField]
		private AsyncMenu _shoppingCartPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002AB3")]
		[SerializeField]
		private FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002AB4")]
		private bool _initialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4002AB5")]
		private int _lastFocusElem = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002AB6")]
		private WardrobeMenu _wardrobe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002AB7")]
		private Item prevClothingItem = Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4002AB8")]
		private int prevDesignId = -1;

		[Cpp2IlInjected.Token(Token = "0x4002AB9")]
		private const int sortFactorLevel = 1;

		[Cpp2IlInjected.Token(Token = "0x4002ABA")]
		private const int sortFactorUnlocked = 100;

		[Cpp2IlInjected.Token(Token = "0x4002ABB")]
		private const int sortFactorOwned = 1000000;

		[Cpp2IlInjected.Token(Token = "0x170006AE")]
		public IItemData SelectedClothes
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _lastClothesSelected;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AF")]
		public Mdl.Avatar.AvatarCustomization AvatarCustomization
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB7")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarCustomization_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB8")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			internal set
			{
				_003CAvatarCustomization_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B0")]
		public AvatarAppearance Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB9")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EBA")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			internal set
			{
				_003CAvatar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EBB")]
		[Cpp2IlInjected.Address(RVA = "0x15585C0", Offset = "0x1556FC0", VA = "0x1815585C0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0016
			//IL_0009: Expected O, but got I8
			_lastClothesSelected = (IItemData)0;
			AvatarCustomization._historyEnabled = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EBC")]
		[Cpp2IlInjected.Address(RVA = "0x1558590", Offset = "0x1556F90", VA = "0x181558590")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0018
			if ((long)_lastClothesSelected == 0)
			{
				AvatarCustomization._historyEnabled = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EBD")]
		[Cpp2IlInjected.Address(RVA = "0x1558410", Offset = "0x1556E10", VA = "0x181558410")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0065
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listBaseItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listBaseItems).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemDeselect = ((LoopScrollRect)_listBaseItems).m_OnItemDeselect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDeselectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).RemoveListener((UnityAction<>)(object)unityAction3);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EBE")]
		[Cpp2IlInjected.Address(RVA = "0x1557EC0", Offset = "0x15568C0", VA = "0x181557EC0")]
		public void Init()
		{
			//Discarded unreachable code: IL_00dd
			if (_initialized)
			{
				return;
			}
			Profile profile = SystemRoot.Instance.Client.Profile;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ListInventory wardrobe = profile.Wardrobe;
			IEnumerable<ClothingItemData> ownedClothes = (IEnumerable<ClothingItemData>)ItemDatabaseExtensions.GetOwnedClothes(_003CInstance_003Ek__BackingField, wardrobe);
			Func<ClothingItemData, bool> _003C_003E9__25_ = _003C_003Ec._003C_003E9__25_0;
			if (_003C_003E9__25_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ClothingItemData x) => x.canAddDecals_);
			}
			ClothingItemData[] array = (_allClothes = Enumerable.Where<ClothingItemData>((IEnumerable<>)ownedClothes, (Func<, >)(object)_003C_003E9__25_).ToArray<ClothingItemData>());
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listBaseItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listBaseItems).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemDeselect = ((LoopScrollRect)_listBaseItems).m_OnItemDeselect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDeselectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).AddListener((UnityAction<>)(object)unityAction3);
			_initialized = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EBF")]
		[Cpp2IlInjected.Address(RVA = "0x1558600", Offset = "0x1557000", VA = "0x181558600")]
		private void OnItemDataHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_02e7
			//IL_001d: Expected O, but got I4
			//IL_007a: Expected I4, but got I8
			//IL_00ae: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			bool flag = default(bool);
			Character character = default(Character);
			CharacterItemData data = default(CharacterItemData);
			Mdl.Online.Client client = default(Mdl.Online.Client);
			bool flag2 = default(bool);
			bool _003CIsOwned_003Ek__BackingField = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
				int num4 = 0;
				if (!(component != (UnityEngine.Object)num4))
				{
					return;
				}
				ClothingItemData[] allClothes = _allClothes;
				int itemIndex = args.ItemIndex;
				ClothingItemData clothingItemData = (ClothingItemData)(component.ItemData = allClothes[itemIndex]);
				Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
				IItemData itemData = component.ItemData;
				Profile profile = metaClient.profile;
				IHasUnlockConditions unlockConditions = itemData.GetUnlockConditions();
				if (unlockConditions != null)
				{
				}
				component.IsBuyable = true;
				GameObject gameObject = component.AmountAsset.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				if ((component.IsBuyable ? 1 : 0) == num)
				{
					int num5 = 0;
					string arg = LocalizationManager.FromStringID("menu.level_abbr_lvl", (IResolver)num5);
					if (unlockConditions == null)
					{
						goto IL_01ef;
					}
					int level_ = profile.player_.level_;
					if (!flag)
					{
						component.LockedLabelAsset.StringID = "?";
					}
					ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
					if (character != null)
					{
						if (character.IsUnlocked)
						{
							goto IL_01ef;
						}
						TextBase lockedLabelAsset = component.LockedLabelAsset;
						data = character.Data;
						string text = (lockedLabelAsset.StringID = data.displayName_);
					}
					component.LockedLabelAsset.StringID = "C";
					TextBase lockedLabelAsset2 = component.LockedLabelAsset;
					int iD_ = data.iD_;
					string text3 = (lockedLabelAsset2.Text = $"{arg}<br><size=120%>{iD_}");
				}
				ListInventory wardrobe = client.Profile.Wardrobe;
				IItemData itemData2 = component.ItemData;
				if (!flag2)
				{
				}
				component.IsOwned = _003CIsOwned_003Ek__BackingField;
				InventoryItem.InventoryGridItemPurchased onItemPurchased = component.OnItemPurchased;
				InventoryItem.InventoryGridItemPurchased value = OnItemPurchasedHandler;
				Delegate @delegate = Delegate.Remove(onItemPurchased, value);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				component.OnItemPurchased = (InventoryItem.InventoryGridItemPurchased)@delegate;
				InventoryItem.InventoryGridItemPurchased onItemPurchased2 = component.OnItemPurchased;
				InventoryItem.InventoryGridItemPurchased b = OnItemPurchasedHandler;
				Delegate delegate2 = Delegate.Combine(onItemPurchased2, b);
				if ((object)delegate2 != null && (object)delegate2 == null)
				{
					break;
				}
				component.OnItemPurchased = (InventoryItem.InventoryGridItemPurchased)delegate2;
				goto IL_01ef;
				IL_01ef:
				component.IsBuyable = (byte)num != 0;
				component.IsOwned = (byte)num != 0;
				bool flag3 = (component.IsMale = Avatar.IsMale);
				component.RefreshDisplay();
				component.LockedLabelAsset.Text = "";
				component.HideLocked();
				((BaseWardrobeItem)component)._oY = -128f;
				int num6 = ((component.IsSelected = false) ? 1 : 0);
				BaseButton btnCreate = component._btnCreate;
				if ((object)btnCreate != null)
				{
					GameObject gameObject2 = btnCreate.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
				}
				component.Name?.gameObject.SetActive(value: true);
				InventoryItem.DecalItemCreate onDecalItemCreate = component.OnDecalItemCreate;
				InventoryItem.DecalItemCreate value2 = OnSelectBaseHandler;
				Delegate delegate3 = Delegate.Remove(onDecalItemCreate, value2);
				if ((object)delegate3 != null && (object)delegate3 == null)
				{
					break;
				}
				component.OnDecalItemCreate = (InventoryItem.DecalItemCreate)delegate3;
				InventoryItem.DecalItemCreate onDecalItemCreate2 = component.OnDecalItemCreate;
				InventoryItem.DecalItemCreate b2 = OnSelectBaseHandler;
				Delegate delegate4 = Delegate.Combine(onDecalItemCreate2, b2);
				if ((object)delegate4 != null && (object)delegate4 == null)
				{
					break;
				}
				component.OnDecalItemCreate = (InventoryItem.DecalItemCreate)delegate4;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC0")]
		[Cpp2IlInjected.Address(RVA = "0x1559F70", Offset = "0x1558970", VA = "0x181559F70")]
		private void RefreshSelected(InventoryItem item)
		{
			//Discarded unreachable code: IL_006e
			//IL_0010: Expected O, but got I4
			AvatarAppearance avatarAppearance = Avatar;
			int num = 0;
			if (avatarAppearance == (UnityEngine.Object)num)
			{
				return;
			}
			AvatarAppearance avatarAppearance2 = Avatar;
			IItemData itemData = item.ItemData;
			bool flag = default(bool);
			if (!flag)
			{
				int num2 = ((item.IsSelected = false) ? 1 : 0);
				BaseButton btnCreate = item._btnCreate;
				if ((object)btnCreate != null)
				{
					GameObject gameObject = btnCreate.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				item.Name?.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC1")]
		[Cpp2IlInjected.Address(RVA = "0x1559370", Offset = "0x1557D70", VA = "0x181559370")]
		private void OnItemSelectHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_00e1, IL_00e7, IL_00f9
			//IL_0017: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			int num = 0;
			InventoryItem component = args.DisplayObject.GetComponent<InventoryItem>();
			int num2 = 0;
			if (component == (UnityEngine.Object)num2)
			{
				return;
			}
			IItemData itemData = (_lastClothesSelected = component.ItemData);
			component.IsSelected = true;
			component._btnCreate?.gameObject.SetActive(value: true);
			TextBase textBase = component.Name;
			if ((object)textBase != null)
			{
				GameObject gameObject = textBase.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			IItemData itemData2 = component.ItemData;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			IEnumerator enumerator = ((LoopScrollRect)_listBaseItems).m_Content.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num6 = 0;
				InventoryItem inventoryItem = default(InventoryItem);
				flag = inventoryItem != (UnityEngine.Object)num6;
				while (!flag)
				{
				}
				RefreshSelected(inventoryItem);
			}
			if (flag)
			{
			}
			int num7 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC2")]
		[Cpp2IlInjected.Address(RVA = "0x1559AD0", Offset = "0x15584D0", VA = "0x181559AD0")]
		[AsyncStateMachine(typeof(_003COnSelect_003Ed__31))]
		private Task OnSelect(Item item)
		{
			int itemID = item.ItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC3")]
		[Cpp2IlInjected.Address(RVA = "0x1558F00", Offset = "0x1557900", VA = "0x181558F00")]
		private void OnItemDeselectHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_009f
			//IL_000f: Expected O, but got I4
			//IL_000f: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				GameObject gameObject = default(GameObject);
				if (num != 0)
				{
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				if ((object)gameObject != null)
				{
					GameObject gameObject2 = default(GameObject);
					gameObject2.SetActive(value: true);
				}
			}
			if ((IntPtr)_lastClothesSelected != (IntPtr)num)
			{
				ClothingItemData[] allClothes = _allClothes;
				int num3 = 0;
				ClothingItemData clothingItemData = default(ClothingItemData);
				int iD = clothingItemData.ID;
				bool flag2 = default(bool);
				if (flag2)
				{
					if (prevDesignId != -1)
					{
					}
					ClothingItemData[] allClothes2 = _allClothes;
					ClothingItemData clothingItemData2 = default(ClothingItemData);
					int iD2 = clothingItemData2.ID;
					int num4 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
			int num5 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNav = FocusNav;
				SetFocus(focusNav);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC4")]
		[Cpp2IlInjected.Address(RVA = "0x1557B20", Offset = "0x1556520", VA = "0x181557B20")]
		internal bool DeselectCurrentItem()
		{
			//Discarded unreachable code: IL_0023
			int selectedIndex = _listBaseItems.SelectedIndex;
			LoopVerticalScrollRect listBaseItems = _listBaseItems;
			int selectedIndex2 = listBaseItems.SelectedIndex;
			listBaseItems.DeselectIndex(selectedIndex2);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC5")]
		[Cpp2IlInjected.Address(RVA = "0x15582D0", Offset = "0x1556CD0", VA = "0x1815582D0")]
		[AsyncStateMachine(typeof(_003COnDeselect_003Ed__34))]
		private Task OnDeselect(ClothingItemType clothingType, bool loadCurrent, bool mustActivateHistory)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC6")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		internal bool HandleRedirection(RedirectionType redirectionType)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC7")]
		[Cpp2IlInjected.Address(RVA = "0x1559360", Offset = "0x1557D60", VA = "0x181559360")]
		private void OnItemPurchasedHandler([System.Runtime.InteropServices.Optional] IItemData itemData, bool refreshNodes = false)
		{
			RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC8")]
		[Cpp2IlInjected.Address(RVA = "0x155A0A0", Offset = "0x1558AA0", VA = "0x18155A0A0")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_00b3
			//IL_0017: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_00b2: Expected I4, but got I8
			if (!base.gameObject.activeSelf)
			{
				return;
			}
			int num = 0;
			if (focusNavigation == (UnityEngine.Object)num)
			{
				return;
			}
			int selectedIndex = _listBaseItems.SelectedIndex;
			LoopVerticalScrollRect listBaseItems = _listBaseItems;
			int selectedIndex2 = listBaseItems.SelectedIndex;
			InventoryItem component = listBaseItems.GetItemByDataIndex(selectedIndex2).GetComponent<InventoryItem>();
			int num2 = 0;
			if (!(component != (UnityEngine.Object)num2))
			{
				LoopVerticalScrollRect listBaseItems2 = _listBaseItems;
				int firstVisibleItemIndex = listBaseItems2.GetFirstVisibleItemIndex();
				FocusNavigationElement component2 = listBaseItems2.GetItemByDataIndex(firstVisibleItemIndex).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component2);
				return;
			}
			LoopVerticalScrollRect listBaseItems3 = _listBaseItems;
			bool flag = default(bool);
			if (!flag)
			{
				int firstVisibleItemIndex2 = listBaseItems3.GetFirstVisibleItemIndex();
			}
			int lastFocusElem = _lastFocusElem;
			FocusNavigationElement component3 = listBaseItems3.GetItemByDataIndex(lastFocusElem).GetComponent<FocusNavigationElement>();
			_lastFocusElem = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC9")]
		[Cpp2IlInjected.Address(RVA = "0x155A460", Offset = "0x1558E60", VA = "0x18155A460")]
		public void UpdateFilters()
		{
			//Discarded unreachable code: IL_0029
			_mcItemContent.gameObject.SetActive(value: true);
			_listBaseItems.gameObject.SetActive(value: true);
			RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECA")]
		[Cpp2IlInjected.Address(RVA = "0x1559E10", Offset = "0x1558810", VA = "0x181559E10")]
		public void RefreshList()
		{
			//Discarded unreachable code: IL_0075
			LoopVerticalScrollRect listBaseItems = _listBaseItems;
			int num = (listBaseItems.SelectedIndex = ListBase.INVALID_INDEX);
			ClothingItemData[] allClothes = _allClothes;
			Func<ClothingItemData, int> func = (Func<ClothingItemData, int>)(object)(Func<T, TResult>)((ClothingItemData x) => GetPriority(x));
			ClothingItemData[] array = (_allClothes = ((IEnumerable<>)Enumerable.OrderByDescending<ClothingItemData, int>((IEnumerable<>)(object)allClothes, (Func<, >)(object)func)).ToArray<ClothingItemData>());
			ClothingItemData[] allClothes2 = _allClothes;
			LoopVerticalScrollRect listBaseItems2 = _listBaseItems;
			int num2 = (listBaseItems2.totalCount = allClothes2.Length);
			LoopVerticalScrollRect listBaseItems3 = _listBaseItems;
			int offset = 0;
			listBaseItems3.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECB")]
		[Cpp2IlInjected.Address(RVA = "0x15579F0", Offset = "0x15563F0", VA = "0x1815579F0")]
		[AsyncStateMachine(typeof(_003CBuyMissingClothes_003Ed__40))]
		private Task BuyMissingClothes(IItemData selectedItem, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECC")]
		[Cpp2IlInjected.Address(RVA = "0x1559800", Offset = "0x1558200", VA = "0x181559800")]
		private void OnSelectBaseHandler(IItemData selectedItem)
		{
			//Discarded unreachable code: IL_0033
			//IL_0010: Expected O, but got I4
			AvatarAppearance avatarAppearance = Avatar;
			int num = 0;
			if (!(avatarAppearance == (UnityEngine.Object)num))
			{
				ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECD")]
		[Cpp2IlInjected.Address(RVA = "0x1559BE0", Offset = "0x15585E0", VA = "0x181559BE0")]
		private void RedirectMenuDecal(IItemData selectedItem)
		{
			//Discarded unreachable code: IL_00d0
			//IL_0010: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			//IL_00cf: Expected I4, but got I8
			//IL_00cf: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			WardrobeMenu wardrobe = _wardrobe;
			int num = 0;
			if (wardrobe == (UnityEngine.Object)num)
			{
				int num2 = 0;
				WardrobeMenu wardrobeMenu = (_wardrobe = UiRoot.Instance._menuStack.GetMenu<WardrobeMenu>());
			}
			WardrobeMenu wardrobe2 = _wardrobe;
			int num3 = 0;
			if (wardrobe2 != (UnityEngine.Object)num3)
			{
				WardrobeMenu wardrobe3 = _wardrobe;
				int num4 = 0;
				wardrobe3.SetTempToM((LoopVerticalScrollRect)num4).FireAndForgetTask();
				_wardrobe.EditingNewToM();
			}
			int num5 = 0;
			_lastClothesSelected = (IItemData)num5;
			AvatarCustomization._historyEnabled = true;
			DecalMenu.DecalMenuParam decalMenuParam = new DecalMenu.DecalMenuParam();
			decalMenuParam.itemData = selectedItem;
			AvatarAppearance avatarAppearance = (decalMenuParam.Avatar = Avatar);
			int num6 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num7 = 0;
			ulong num8 = default(ulong);
			redirection.Redirect(RedirectionType.MenuDecal, decalMenuParam, (PlayerTaskCollider)num7, (ItemFilterData)num5, (string)num5, (Action)num5, (byte)num5 != 0, (byte)num5 != 0, (byte)num5 != 0, (byte)num8 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECE")]
		[Cpp2IlInjected.Address(RVA = "0x1557BD0", Offset = "0x15565D0", VA = "0x181557BD0")]
		private int GetPriority(IItemData itemData)
		{
			int num = 0;
			ListInventory wardrobe = SystemRoot.Instance.Client.Profile.Wardrobe;
			bool flag = default(bool);
			if (flag)
			{
			}
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			if (itemData.GetUnlockConditions() == null)
			{
				int maxLevel = profile.player_.GetMaxLevel();
				num += 100;
				return num + maxLevel;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECF")]
		[Cpp2IlInjected.Address(RVA = "0x155A4D0", Offset = "0x1558ED0", VA = "0x18155A4D0")]
		public DecalBaseItemsContent()
		{
		}//IL_0010: Expected I4, but got I8
		//IL_002d: Expected I4, but got I8

	}
}
