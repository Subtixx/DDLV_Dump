using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Audio;
using Mdl.Grid;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002D8")]
	[RequiredAllNotNull]
	public class CatalogMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20002D9")]
		public enum EditModeState
		{
			[Cpp2IlInjected.Token(Token = "0x4000DA7")]
			NoSelection,
			[Cpp2IlInjected.Token(Token = "0x4000DA8")]
			InventoryOpened,
			[Cpp2IlInjected.Token(Token = "0x4000DA9")]
			ItemSelected
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000D66")]
		public bool IsInEditMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000D67")]
		private CatalogMenuParam _catalogParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000D68")]
		public bool ForceOpenCatalog = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x4000D69")]
		public bool IsPopAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000D6A")]
		private GridEditMode gridEditModeSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000D6B")]
		[SerializeField]
		private Sprite _handPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000D6C")]
		[SerializeField]
		private Sprite _handOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000D6D")]
		[SerializeField]
		private Sprite _handClosedWhite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000D6E")]
		[SerializeField]
		private Sprite _handClosedRed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000D6F")]
		[SerializeField]
		private Sprite _defaultCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000D70")]
		[SerializeField]
		private GameObject _undoButtonsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000D71")]
		[SerializeField]
		private NotificationButton _btnEditModeUndo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000D72")]
		[SerializeField]
		private NotificationButton _fenceRemoveButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000D73")]
		[SerializeField]
		private NotificationButton _removeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000D74")]
		[SerializeField]
		private NotificationButton _replaceButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000D75")]
		[SerializeField]
		private TextBase _replaceNeedsUpgradeLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000D76")]
		[SerializeField]
		private NotificationButton _cancelButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000D77")]
		[SerializeField]
		private NotificationButton _btnEditModeUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000D78")]
		[SerializeField]
		private CatalogContent _inventoryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000D79")]
		[SerializeField]
		private GameObject _rotateControlInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000D7A")]
		[SerializeField]
		private GameObject _rotateControlInfoGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000D7B")]
		[SerializeField]
		private Image _highlightImageUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000D7C")]
		[SerializeField]
		private Image _highlightImageFence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000D7D")]
		[SerializeField]
		private GameObject _undoContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000D7E")]
		[SerializeField]
		private GameObject _objectSelectedButtonContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000D7F")]
		[SerializeField]
		private GameObject _controllerButtonContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000D80")]
		[SerializeField]
		private GameObject _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000D81")]
		[SerializeField]
		private TextBase _tfFilterCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000D82")]
		[SerializeField]
		private GameObject _exitShorcutDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000D83")]
		[SerializeField]
		private RectTransform _furnitureRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000D84")]
		[SerializeField]
		private RectTransform _mcCategoryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000D85")]
		[SerializeField]
		private RectTransform _panelRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000D86")]
		[SerializeField]
		private GameObject _furnitureBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000D87")]
		[SerializeField]
		private CanvasGroup _panelCloseBackShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000D88")]
		[SerializeField]
		private CanvasGroup _panelOpenBackShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000D89")]
		[SerializeField]
		private GameObject _pcShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000D8A")]
		[SerializeField]
		private GameObject _gamepadShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000D8B")]
		[SerializeField]
		private CanvasGroup _menuCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000D8C")]
		[Header("Audio")]
		public AK.Wwise.Event ConfirmDesignChallengeSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000D8D")]
		[SerializeField]
		private Bank catalogEditModeBank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000D8E")]
		[SerializeField]
		private AK.Wwise.Event startCatalogAmb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000D8F")]
		[SerializeField]
		private AK.Wwise.Event stopCatalogAmb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000D90")]
		[SerializeField]
		private RTPC camHeightRTPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000D91")]
		private GameObject audioManGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000D92")]
		private InfoGizmo _houseExpantionGizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000D93")]
		private EditModeState _currentEditModeState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000D94")]
		private MainMenuTabButton currentSideMenuButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000D95")]
		private bool _justFiredPressFence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x241")]
		[Cpp2IlInjected.Token(Token = "0x4000D96")]
		private bool _justFiredPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x242")]
		[Cpp2IlInjected.Token(Token = "0x4000D97")]
		private bool _isExiting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x243")]
		[Cpp2IlInjected.Token(Token = "0x4000D98")]
		private bool _shouldReopen = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000D99")]
		private bool _isOverSideMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x245")]
		[Cpp2IlInjected.Token(Token = "0x4000D9A")]
		private bool _showNewItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000D9B")]
		private InputAction _inputActionInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000D9C")]
		protected InputAction inputActionRemoveWholeFencePress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000D9D")]
		protected InputAction inputActionRemoveWholeFenceReleased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000D9E")]
		protected InputAction inputActionRemoveWholeFence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000D9F")]
		protected InputAction inputActionCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000DA0")]
		protected InputAction inputActionUndoPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000DA1")]
		protected InputAction inputActionUndoRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000DA2")]
		protected InputAction inputActionUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000DA3")]
		private InputAction _inputActionRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000DA4")]
		private InputAction _inputActionLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000DA5")]
		private FocusNavigationElement _lastFocusedElement;

		[Cpp2IlInjected.Token(Token = "0x17000328")]
		public bool IsSomethingOpened
		{
			[Cpp2IlInjected.Token(Token = "0x6001221")]
			[Cpp2IlInjected.Address(RVA = "0xFF6C20", Offset = "0xFF5620", VA = "0x180FF6C20")]
			get
			{
				//IL_0014: Expected O, but got I4
				ItemSelector itemSelector = ItemSelector;
				if ((object)itemSelector != null)
				{
					int num = 0;
					if (itemSelector != (UnityEngine.Object)num)
					{
						return itemSelector.isActiveAndEnabled;
					}
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000329")]
		internal ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6001222")]
			[Cpp2IlInjected.Address(RVA = "0xFF6D90", Offset = "0xFF5790", VA = "0x180FF6D90")]
			get
			{
				int num = 0;
				WorldUI worldCanvas = UiRoot.Instance._worldCanvas;
				Type typeFromHandle = typeof(ItemSelector);
				if ((object)worldCanvas.GetActiveGizmoByType(typeFromHandle) == null)
				{
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032A")]
		private bool IsSomethingSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001223")]
			[Cpp2IlInjected.Address(RVA = "0xFF6CA0", Offset = "0xFF56A0", VA = "0x180FF6CA0")]
			get
			{
				//Discarded unreachable code: IL_0028
				//IL_0015: Expected O, but got I4
				GameObject selectedGameObject = gridEditModeSystem.SelectedGameObject;
				int num = 0;
				if (selectedGameObject != (UnityEngine.Object)num)
				{
					return true;
				}
				Item _003CSelectedWallpaperItem_003Ek__BackingField = gridEditModeSystem.SelectedWallpaperItem;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032B")]
		private CatalogContent CatalogContent
		{
			[Cpp2IlInjected.Token(Token = "0x6001224")]
			[Cpp2IlInjected.Address(RVA = "0x738A00", Offset = "0x737400", VA = "0x180738A00")]
			get
			{
				return _inventoryContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032C")]
		private FocusCursor _focusCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6001225")]
			[Cpp2IlInjected.Address(RVA = "0xFF6ED0", Offset = "0xFF58D0", VA = "0x180FF6ED0")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return UiRoot.Instance.FocusCursor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032D")]
		public bool IsExiting
		{
			[Cpp2IlInjected.Token(Token = "0x6001226")]
			[Cpp2IlInjected.Address(RVA = "0xFF66A0", Offset = "0xFF50A0", VA = "0x180FF66A0")]
			get
			{
				return _isExiting;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032E")]
		private GridObjectScript SelectedGridObject
		{
			[Cpp2IlInjected.Token(Token = "0x600123F")]
			[Cpp2IlInjected.Address(RVA = "0xFF6EA0", Offset = "0xFF58A0", VA = "0x180FF6EA0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032F")]
		private bool IsSelectedObjectRotatable
		{
			[Cpp2IlInjected.Token(Token = "0x6001240")]
			[Cpp2IlInjected.Address(RVA = "0xFF6B30", Offset = "0xFF5530", VA = "0x180FF6B30")]
			get
			{
				//IL_0015: Expected O, but got I4
				GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject;
				int num = 0;
				if (selectedGridObject != (UnityEngine.Object)num)
				{
					GridObject _003CGridObject_003Ek__BackingField = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField.ItemID;
						int itemID2 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
						ItemType itemType = default(ItemType);
						return itemType != ItemType.Trimming;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000330")]
		private bool IsSelectedObjectReplaceable
		{
			[Cpp2IlInjected.Token(Token = "0x6001241")]
			[Cpp2IlInjected.Address(RVA = "0xFF6950", Offset = "0xFF5350", VA = "0x180FF6950")]
			get
			{
				//IL_0015: Expected O, but got I4
				GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject;
				int num = 0;
				if (selectedGridObject != (UnityEngine.Object)num)
				{
					GridObject _003CGridObject_003Ek__BackingField = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField.ItemID;
						int itemID2 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
						ItemType itemType = default(ItemType);
						switch (itemType)
						{
						case ItemType.Building:
						{
							int itemID4 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
							BuildingItemType buildingItemType = default(BuildingItemType);
							return buildingItemType == BuildingItemType.PlayerHouse;
						}
						case ItemType.Furniture:
						{
							int itemID3 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
							FurnitureItemType furnitureItemType = default(FurnitureItemType);
							return furnitureItemType == FurnitureItemType.Door;
						}
						}
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000331")]
		private bool IsSelectedObjectReplaceLocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001242")]
			[Cpp2IlInjected.Address(RVA = "0xFF66B0", Offset = "0xFF50B0", VA = "0x180FF66B0")]
			get
			{
				//IL_0015: Expected O, but got I4
				GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject;
				int num = 0;
				if (selectedGridObject != (UnityEngine.Object)num)
				{
					GridObject _003CGridObject_003Ek__BackingField = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField.ItemID;
						int itemID2 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
						ItemType itemType = default(ItemType);
						if (itemType == ItemType.Building)
						{
							int itemID3 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
							BuildingItemType buildingItemType = default(BuildingItemType);
							if (buildingItemType == BuildingItemType.PlayerHouse)
							{
								int itemID4 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
								bool flag = default(bool);
								if (flag)
								{
									UpgradeState upgradeState_ = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.state_.HouseData.upgradeState_;
									UpgradeData upgradeData = default(UpgradeData);
									return !upgradeData.House.canReplaceWithSkins_;
								}
							}
						}
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000332")]
		private bool HasReplacementsSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001243")]
			[Cpp2IlInjected.Address(RVA = "0xFF6340", Offset = "0xFF4D40", VA = "0x180FF6340")]
			get
			{
				MapField<int, ListInventory.Types.Data> inventory_ = default(MapField<int, ListInventory.Types.Data>);
				Func<KeyValuePair<int, ListInventory.Types.Data>, bool> _003C_003E9__110_ = default(Func<KeyValuePair<int, ListInventory.Types.Data>, bool>);
				if (IsSelectedObjectReplaceable)
				{
					int itemID = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
					ItemType itemType = default(ItemType);
					if (itemType == ItemType.Building)
					{
						GridEditMode gridEditMode = gridEditModeSystem;
						GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)gridEditMode)._selectedGridObject;
						ListInventory fakeBuildingInventory = gridEditMode.fakeBuildingInventory;
						int itemID2 = selectedGridObject.GridObject.ItemID;
						BuildingItemType buildingItemType = default(BuildingItemType);
						if (buildingItemType != BuildingItemType.PlayerHouse)
						{
							goto IL_00d2;
						}
						if (_003C_003Ec._003C_003E9__110_0 != null)
						{
							goto IL_00c6;
						}
						Func<KeyValuePair<int, ListInventory.Types.Data>, bool> func = (Func<KeyValuePair<int, ListInventory.Types.Data>, bool>)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_0007
							int num3 = 0;
							BuildingItemType buildingItemType2 = default(BuildingItemType);
							return buildingItemType2 == BuildingItemType.PlayerHouse;
						};
					}
					if (itemType == ItemType.Furniture)
					{
						GridEditMode gridEditMode2 = gridEditModeSystem;
						GridObjectScript selectedGridObject2 = ((GridObjectGizmoSystem)gridEditMode2)._selectedGridObject;
						ListInventory fakeCatalog = gridEditMode2.fakeCatalog;
						int itemID3 = selectedGridObject2.GridObject.ItemID;
						FurnitureItemType furnitureItemType = default(FurnitureItemType);
						if (furnitureItemType == FurnitureItemType.Door)
						{
							inventory_ = fakeCatalog.inventory_;
							_003C_003E9__110_ = _003C_003Ec._003C_003E9__110_1;
							if (_003C_003E9__110_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
								{
									//Discarded unreachable code: IL_0007
									int num2 = 0;
									FurnitureItemType furnitureItemType2 = default(FurnitureItemType);
									return furnitureItemType2 == FurnitureItemType.Door;
								};
							}
							goto IL_00c6;
						}
					}
				}
				goto IL_00d2;
				IL_00d2:
				int num = 0;
				throw new NullReferenceException();
				IL_00c6:
				if (!((IEnumerable<>)(object)inventory_).Any<KeyValuePair<int, ListInventory.Types.Data>>((Func<, >)(object)_003C_003E9__110_))
				{
				}
				goto IL_00d2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001227")]
		[Cpp2IlInjected.Address(RVA = "0xFF0390", Offset = "0xFEED90", VA = "0x180FF0390")]
		[IteratorStateMachine(typeof(_003COnApplicationFocus_003Ed__77))]
		private IEnumerator OnApplicationFocus(bool isFocus)
		{
			int _003C_003E1__state = default(int);
			_003COnApplicationFocus_003Ed__77 _003COnApplicationFocus_003Ed__ = new _003COnApplicationFocus_003Ed__77(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnApplicationFocus_003Ed__._003C_003E4__this = this;
			_003COnApplicationFocus_003Ed__.isFocus = isFocus;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001228")]
		[Cpp2IlInjected.Address(RVA = "0xFEF480", Offset = "0xFEDE80", VA = "0x180FEF480")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0034
			//IL_0010: Expected O, but got I4
			CatalogContent inventoryContent = _inventoryContent;
			int num = 0;
			if (inventoryContent != (UnityEngine.Object)num)
			{
				SlidingPanel slidingPanel = _inventoryContent.slidingPanel;
				SlidingPanel.SlidingPanelEvent value = DeselectSelectedObject;
				slidingPanel.OnActivateOpenContent += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001229")]
		[Cpp2IlInjected.Address(RVA = "0xFF0960", Offset = "0xFEF360", VA = "0x180FF0960", Slot = "24")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0045
			//IL_001b: Expected O, but got I4
			catalogEditModeBank.Unload();
			CatalogContent inventoryContent = _inventoryContent;
			int num = 0;
			if (inventoryContent != (UnityEngine.Object)num)
			{
				SlidingPanel slidingPanel = _inventoryContent.slidingPanel;
				SlidingPanel.SlidingPanelEvent value = DeselectSelectedObject;
				slidingPanel.OnActivateOpenContent -= value;
			}
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x600122A")]
		[Cpp2IlInjected.Address(RVA = "0xFF33B0", Offset = "0xFF1DB0", VA = "0x180FF33B0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//IL_01a6: Expected O, but got I4
			int newNumber = 0;
			NumberOfItemsInCartChangedEventHandler(newNumber);
			Button.ButtonClickedEvent onClick = _cancelButton.ButtonComponent.m_OnClick;
			UnityAction call = DeselectSelectedObject;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _removeButton.ButtonComponent.m_OnClick;
			UnityAction call2 = RemoveButtonClick;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _replaceButton.ButtonComponent.m_OnClick;
			UnityAction call3 = ReplaceButtonClick;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _fenceRemoveButton.ButtonComponent.m_OnClick;
			UnityAction call4 = RemoveWholeFence;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnEditModeUndo.ButtonComponent.m_OnClick;
			UnityAction call5 = OnUndoEditModeClickHandler;
			onClick5.AddListener(call5);
			Button.ButtonClickedEvent onClick6 = _btnEditModeUndoAll.ButtonComponent.m_OnClick;
			UnityAction call6 = OnUndoAllEditModeClickHandler;
			onClick6.AddListener(call6);
			UnityEvent onOpenContent = _inventoryContent.slidingPanel.OnOpenContent;
			UnityAction call7 = OnPanelOpened;
			onOpenContent.AddListener(call7);
			UnityEvent onCloseContent = _inventoryContent.slidingPanel.OnCloseContent;
			UnityAction call8 = OnPanelClosed;
			onCloseContent.AddListener(call8);
			UnityEvent onPhaseChanged = _inventoryContent.OnPhaseChanged;
			UnityAction unityAction = OnCatalogPhaseChanged;
			onPhaseChanged.AddListener(unityAction);
			CatalogContent inventoryContent = _inventoryContent;
			Action<Item, bool> b = (Action<Item, bool>)(object)new Action<T1, T2>(OnInventoryItemDrag);
			Delegate @delegate = Delegate.Combine(unityAction, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				inventoryContent.OnDragItem = (Action<Item, bool>)num;
				FocusNavigation focusNavigation = base.FocusNavigation;
				FocusNavigation.FocusChanged value = OnFocusChanged;
				focusNavigation.OnFocusChanged += value;
				CatalogContent inventoryContent2 = _inventoryContent;
				Action onStateChange = inventoryContent2.OnStateChange;
				Action b2 = OnCatalogContentStateChange;
				Delegate delegate2 = Delegate.Combine(onStateChange, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					inventoryContent2.OnStateChange = (Action)delegate2;
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600122B")]
		[Cpp2IlInjected.Address(RVA = "0xFF47C0", Offset = "0xFF31C0", VA = "0x180FF47C0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//IL_012b: Expected O, but got I4
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _cancelButton.ButtonComponent.m_OnClick;
			UnityAction call = DeselectSelectedObject;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _removeButton.ButtonComponent.m_OnClick;
			UnityAction call2 = RemoveButtonClick;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _replaceButton.ButtonComponent.m_OnClick;
			UnityAction call3 = ReplaceButtonClick;
			onClick3.RemoveListener(call3);
			_btnEditModeUndo.ButtonComponent.m_OnClick.RemoveAllListeners();
			_btnEditModeUndoAll.ButtonComponent.m_OnClick.RemoveAllListeners();
			_inventoryContent.slidingPanel.OnOpenContent.RemoveAllListeners();
			_inventoryContent.slidingPanel.OnCloseContent.RemoveAllListeners();
			UnityEvent onPhaseChanged = _inventoryContent.OnPhaseChanged;
			UnityAction unityAction = OnCatalogPhaseChanged;
			onPhaseChanged.RemoveListener(unityAction);
			CatalogContent inventoryContent = _inventoryContent;
			Action<Item, bool> value = (Action<Item, bool>)(object)new Action<T1, T2>(OnInventoryItemDrag);
			Delegate @delegate = Delegate.Remove(unityAction, value);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				inventoryContent.OnDragItem = (Action<Item, bool>)num;
				GridEditMode gridEditMode = gridEditModeSystem;
				GridEditMode.NumberOfItemsInCartChangedDelegate value2 = NumberOfItemsInCartChangedEventHandler;
				gridEditMode.NumberOfItemsInCartChangedEvent -= value2;
				FocusNavigation focusNavigation = base.FocusNavigation;
				FocusNavigation.FocusChanged value3 = OnFocusChanged;
				focusNavigation.OnFocusChanged -= value3;
				CatalogContent inventoryContent2 = _inventoryContent;
				Action onStateChange = inventoryContent2.OnStateChange;
				Action value4 = OnCatalogContentStateChange;
				Delegate delegate2 = Delegate.Remove(onStateChange, value4);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					inventoryContent2.OnStateChange = (Action)delegate2;
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600122C")]
		[Cpp2IlInjected.Address(RVA = "0xFF31E0", Offset = "0xFF1BE0", VA = "0x180FF31E0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0084
			//IL_0019: Expected O, but got I4
			int newNumber = 0;
			NumberOfItemsInCartChangedEventHandler(newNumber);
			GridEditMode gridEditMode = gridEditModeSystem;
			int num = 0;
			if (gridEditMode != (UnityEngine.Object)num)
			{
				GridEditMode gridEditMode2 = gridEditModeSystem;
				GridEditMode.NumberOfItemsInCartChangedDelegate value = NumberOfItemsInCartChangedEventHandler;
				gridEditMode2.NumberOfItemsInCartChangedEvent += value;
				GridEditMode gridEditMode3 = gridEditModeSystem;
				Mdl.Systems.System.SystemEvent value2 = GridEditModeStoppedEvent;
				gridEditMode3.SystemStoppedEvent += value2;
			}
			int num2 = 0;
			UnityEvent<bool> onItemSelectorOnOff = UiRoot.Instance.Dispatcher.OnItemSelectorOnOff;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnItemSelectorOnOff);
			((UnityEvent<T0>)(object)onItemSelectorOnOff).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600122D")]
		[Cpp2IlInjected.Address(RVA = "0xFF45F0", Offset = "0xFF2FF0", VA = "0x180FF45F0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0084
			//IL_0019: Expected O, but got I4
			int newNumber = 0;
			NumberOfItemsInCartChangedEventHandler(newNumber);
			GridEditMode gridEditMode = gridEditModeSystem;
			int num = 0;
			if (gridEditMode != (UnityEngine.Object)num)
			{
				GridEditMode gridEditMode2 = gridEditModeSystem;
				GridEditMode.NumberOfItemsInCartChangedDelegate value = NumberOfItemsInCartChangedEventHandler;
				gridEditMode2.NumberOfItemsInCartChangedEvent -= value;
				GridEditMode gridEditMode3 = gridEditModeSystem;
				Mdl.Systems.System.SystemEvent value2 = GridEditModeStoppedEvent;
				gridEditMode3.SystemStoppedEvent -= value2;
			}
			int num2 = 0;
			UnityEvent<bool> onItemSelectorOnOff = UiRoot.Instance.Dispatcher.OnItemSelectorOnOff;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnItemSelectorOnOff);
			((UnityEvent<T0>)(object)onItemSelectorOnOff).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600122E")]
		[Cpp2IlInjected.Address(RVA = "0xFF1AD0", Offset = "0xFF04D0", VA = "0x180FF1AD0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0273
			//IL_0045: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0211: Expected O, but got I4
			//IL_0233: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			Bank bank = catalogEditModeBank;
			int saveDecodedBank = 0;
			int decodeBank = 0;
			bank.Load((byte)decodeBank != 0, (byte)saveDecodedBank != 0);
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			if ((object)system != null)
			{
				GameObject gameObject = system.gameObject;
			}
			audioManGO = (GameObject)(object)system;
			GameObject gameObject2 = audioManGO;
			int num = 0;
			if (gameObject2 != (UnityEngine.Object)num)
			{
				AK.Wwise.Event @event = startCatalogAmb;
				GameObject gameObject3 = audioManGO;
				uint num2 = @event.Post(gameObject3);
				RTPC rTPC = camHeightRTPC;
				Transform transform = SystemRoot.Instance._playerCamera.transform;
			}
			GridEditMode gridEditMode = (gridEditModeSystem = SystemRoot.Instance.GetSystem<GridEditMode>());
			int num3 = 0;
			base.OnPush(stack, param);
			int num4 = 0;
			if (!UiRoot.Instance.ShouldShowNewItem)
			{
				_showNewItem = false;
			}
			int num5 = 0;
			_showNewItem = true;
			UiRoot.Instance.ShouldShowNewItem = false;
			int num6 = 0;
			WorldUI worldCanvas = UiRoot.Instance._worldCanvas;
			Type typeFromHandle = typeof(HouseExpansionInfo);
			InfoGizmo infoGizmo = (_houseExpantionGizmo = worldCanvas.GetGizmoByType(typeFromHandle));
			InfoGizmo houseExpantionGizmo = _houseExpantionGizmo;
			int num7 = 0;
			if (houseExpantionGizmo != (UnityEngine.Object)num7)
			{
				GameObject gameObject4 = _houseExpantionGizmo.gameObject;
				int active = 0;
				gameObject4.SetActive((byte)active != 0);
			}
			if (param != null)
			{
				int num8 = 0;
				if (param != null)
				{
					int num9 = 0;
					if (param == null)
					{
						throw new InvalidCastException();
					}
					_catalogParam = (CatalogMenuParam)param;
					CatalogMenuParam catalogParam = _catalogParam;
					bool isInEditMode = catalogParam.IsInEditMode;
					CatalogContent inventoryContent = _inventoryContent;
					IsInEditMode = isInEditMode;
					bool flag = (ForceOpenCatalog = catalogParam.ForceOpenCatalog);
					ItemFilterData itemFilterData = (inventoryContent.CatalogItemFilters = catalogParam.ItemFilterData);
					CatalogMenuParam catalogParam2 = _catalogParam;
					CatalogContent inventoryContent2 = _inventoryContent;
					ItemFilterData itemFilterData2 = catalogParam2.ItemFilterData;
					if (itemFilterData2 != null)
					{
						int count = ((RepeatedField<T>)(object)itemFilterData2.itemList_).Count;
					}
					int num10 = ((inventoryContent2.IsFilteringLocked = false) ? 1 : 0);
				}
			}
			IsInEditMode = true;
			CatalogContent inventoryContent3 = _inventoryContent;
			GridEditMode gridEditMode3 = (inventoryContent3.GridEditModeSystem = gridEditModeSystem);
			CatalogContent inventoryContent4 = _inventoryContent;
			CancellationToken cancellationToken = (inventoryContent4.CancellationToken = base.CancellationToken);
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num11 = default(int);
			InputActionBool inputActionInteract = new InputActionBool("Interact", trigger, (InputProvider)num11);
			num11 = 0;
			_inputActionInteract = inputActionInteract;
			InputTriggerPressed trigger2 = new InputTriggerPressed();
			int num12 = default(int);
			InputActionBool inputActionRT = new InputActionBool("EditModeCam_Toggle", trigger2, (InputProvider)num12);
			num12 = 0;
			_inputActionRT = inputActionRT;
			InputTriggerPressed trigger3 = new InputTriggerPressed();
			int num13 = default(int);
			InputActionBool inputActionLT = new InputActionBool("[LT]", trigger3, (InputProvider)num13);
			num13 = 0;
			_inputActionLT = inputActionLT;
			_menuCanvasGroup.alpha = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x600122F")]
		[Cpp2IlInjected.Address(RVA = "0xFF0C90", Offset = "0xFEF690", VA = "0x180FF0C90", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0163
			//IL_0052: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_0138: Expected O, but got I4
			base.OnFocusIn();
			_inventoryContent.ForceRefresh = true;
			SlidingPanel slidingPanel = _inventoryContent.slidingPanel;
			bool forceOpenCatalog = ForceOpenCatalog;
			slidingPanel.Show(forceOpenCatalog);
			_furnitureBg.SetActive(value: true);
			ForceOpenCatalog = false;
			InputTriggerReleased trigger = new InputTriggerReleased();
			int num = default(int);
			InputActionBool inputActionBool = new InputActionBool("EditMode_Cancel", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			inputActionCancel = inputActionBool;
			InputTriggerPressed trigger2 = new InputTriggerPressed();
			int num3 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("EditMode_Remove", trigger2, (InputProvider)num3);
			num3 = 0;
			inputActionRemoveWholeFencePress = inputActionBool2;
			InputTriggerReleased trigger3 = new InputTriggerReleased();
			int num4 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("EditMode_Remove", trigger3, (InputProvider)num4);
			num4 = 0;
			inputActionRemoveWholeFenceReleased = inputActionBool3;
			float removeWholeFencePressDelay = gridEditModeSystem._removeWholeFencePressDelay;
			InputTriggerDownWithDelay trigger4 = new InputTriggerDownWithDelay(removeWholeFencePressDelay);
			int num5 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("EditMode_Remove", trigger4, (InputProvider)num5);
			num5 = 0;
			inputActionRemoveWholeFence = inputActionBool4;
			InputTriggerPressed trigger5 = new InputTriggerPressed();
			int num6 = default(int);
			InputActionBool inputActionBool5 = new InputActionBool("EditMode_Undo", trigger5, (InputProvider)num6);
			num6 = 0;
			inputActionUndoPress = inputActionBool5;
			InputTriggerReleased trigger6 = new InputTriggerReleased();
			int num7 = default(int);
			InputActionBool inputActionBool6 = new InputActionBool("EditMode_Undo", trigger6, (InputProvider)num7);
			num7 = 0;
			inputActionUndoRelease = inputActionBool6;
			GridEditMode gridEditMode = gridEditModeSystem;
			InputTriggerDownWithDelay trigger7 = new InputTriggerDownWithDelay(removeWholeFencePressDelay);
			int num8 = default(int);
			InputActionBool inputActionBool7 = new InputActionBool("EditMode_Undo", trigger7, (InputProvider)num8);
			num8 = 0;
			inputActionUndoAll = inputActionBool7;
			int num9 = 0;
			UiRoot.Instance._worldCanvas.RemoveNotEnoughMana();
			gridEditModeSystem.ResetCursorPosition();
		}

		[Cpp2IlInjected.Token(Token = "0x6001230")]
		[Cpp2IlInjected.Address(RVA = "0xFF0120", Offset = "0xFEEB20", VA = "0x180FF0120")]
		private bool IsOverTransform(IEnumerable<RaycastResult> raycastResult, Transform transform)
		{
			//Discarded unreachable code: IL_0022
			Func<RaycastResult, bool> cpp2il__autoParamName__idx_ = (Func<RaycastResult, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_000f
				Transform parent = transform;
				Transform transform2 = default(Transform);
				return transform2.IsChildOf(parent);
			};
			return ((IEnumerable<>)raycastResult).Any<RaycastResult>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x6001231")]
		[Cpp2IlInjected.Address(RVA = "0xFF3E80", Offset = "0xFF2880", VA = "0x180FF3E80")]
		public bool ShouldShowCursor()
		{
			//Discarded unreachable code: IL_0136
			//IL_0052: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			if (!IsSomethingOpened)
			{
				int num = 0;
				InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && _inventoryContent.slidingPanel.IsClosed)
				{
					int num3 = 0;
					if (!(menu != (UnityEngine.Object)num3))
					{
					}
					GridEditMode gridEditMode = gridEditModeSystem;
					List<RaycastResult> eventSystemRaycastResults = (List<RaycastResult>)(object)this.GetEventSystemRaycastResults((Vector2)num3);
					Transform transform = menu.transform;
					bool flag = (_isOverSideMenu = this.IsOverTransform((IEnumerable<>)eventSystemRaycastResults, transform));
					int num4 = 0;
				}
				int num5 = 0;
				Vector2 mousePosition = Input.mousePosition;
				List<RaycastResult> eventSystemRaycastResults2 = (List<RaycastResult>)(object)this.GetEventSystemRaycastResults(mousePosition);
				Transform transform2 = _content.transform;
				if (this.IsOverTransform((IEnumerable<>)eventSystemRaycastResults2, transform2))
				{
				}
				bool flag2 = default(bool);
				if (!flag2)
				{
					int num6 = 0;
				}
				Transform transform3 = default(Transform);
				bool flag3 = this.IsOverTransform((IEnumerable<>)eventSystemRaycastResults2, transform3);
				int num7 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (!instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					int num8 = 0;
					GameObject gameObject = UiRoot.Instance.FocusCursor.gameObject;
					if (flag3)
					{
					}
					int num9 = 0;
					bool isFocused = Application.isFocused;
					gameObject.SetActive(isFocused);
				}
				_isOverSideMenu = flag3;
				while (!flag3)
				{
				}
				int num10 = 0;
				UiRoot instance3 = UiRoot.Instance;
				int useKeyboardAsController3 = 0;
				return !instance3.IsControllerConnected((byte)useKeyboardAsController3 != 0);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001232")]
		[Cpp2IlInjected.Address(RVA = "0xFF2BB0", Offset = "0xFF15B0", VA = "0x180FF2BB0")]
		private void RefreshCursor()
		{
			//Discarded unreachable code: IL_00c1
			//IL_00aa: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				if (!Application.isFocused)
				{
				}
				bool flag = !IsSomethingOpened;
				GridEditMode gridEditMode = gridEditModeSystem;
				int num3 = 0;
				((GridObjectGizmoSystem)gridEditMode).UpdateCursor = flag;
				UiRoot.Instance.FocusCursor.gameObject.SetActive(flag);
				return;
			}
			if (!_inventoryContent.slidingPanel.isOpened)
			{
				int num4 = 0;
				if (Application.isFocused)
				{
					bool isSomethingOpened = IsSomethingOpened;
				}
			}
			int num5 = 0;
			int num6 = 0;
			UiRoot.Instance.FocusCursor.gameObject.SetActive((byte)num5 != 0);
			GridEditMode gridEditMode2 = gridEditModeSystem;
			int num7 = 0;
			if (gridEditMode2 != (UnityEngine.Object)num7)
			{
				((GridObjectGizmoSystem)gridEditModeSystem).UpdateCursor = (byte)num5 != 0;
			}
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001233")]
		[Cpp2IlInjected.Address(RVA = "0xFF15D0", Offset = "0xFEFFD0", VA = "0x180FF15D0")]
		public void OnOpenPanel()
		{
			//Discarded unreachable code: IL_00a1
			//IL_0074: Expected O, but got I4
			if (IsSomethingSelected)
			{
				gridEditModeSystem.UndoLastCommand();
				if (base.gameObject.activeInHierarchy)
				{
					_inventoryContent.ForceUpdateList();
				}
			}
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				GameObject gameObject = UiRoot.Instance.FocusCursor.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GridEditMode gridEditMode = gridEditModeSystem;
				int num3 = 0;
				if (gridEditMode != (UnityEngine.Object)num3)
				{
					((GridObjectGizmoSystem)gridEditModeSystem).UpdateCursor = false;
				}
				SetFocus();
			}
			GameObject furnitureBg = _furnitureBg;
			_shouldReopen = true;
			furnitureBg.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001234")]
		[Cpp2IlInjected.Address(RVA = "0xFF0440", Offset = "0xFEEE40", VA = "0x180FF0440")]
		public void OnClosePanel()
		{
			//Discarded unreachable code: IL_00c0
			//IL_0051: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				GameObject gameObject = UiRoot.Instance.FocusCursor.gameObject;
				int num3 = 0;
				bool isFocused = Application.isFocused;
				gameObject.SetActive(isFocused);
				GridEditMode gridEditMode = gridEditModeSystem;
				int num4 = 0;
				if (gridEditMode != (UnityEngine.Object)num4)
				{
					GridEditMode gridEditMode2 = gridEditModeSystem;
					int num5 = 0;
					bool flag = (((GridObjectGizmoSystem)gridEditMode2).UpdateCursor = Application.isFocused);
				}
				ISupportsFocusNavigation focusedElement = base.FocusNavigation._focusedElement;
				if (focusedElement == null)
				{
				}
				int num6 = 0;
				_lastFocusedElement = (FocusNavigationElement)focusedElement;
				CatalogContent inventoryContent = _inventoryContent;
				FocusNavigationElement focusNavigationElement = (inventoryContent._navigationElement = _lastFocusedElement);
				SetFocus();
			}
			GameObject furnitureBg = _furnitureBg;
			int active = 0;
			furnitureBg.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001235")]
		[Cpp2IlInjected.Address(RVA = "0xFF4CB0", Offset = "0xFF36B0", VA = "0x180FF4CB0")]
		private void Update()
		{
			//IL_0012: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_01d0: Expected O, but got I4
			//IL_022d: Expected O, but got I4
			//IL_02ae: Expected O, but got I4
			//IL_04c5: Expected O, but got I4
			//IL_04e6: Expected O, but got I4
			//IL_04e6: Expected O, but got I4
			//IL_0501: Expected O, but got I4
			//IL_050c: Expected O, but got I4
			//IL_050c: Expected O, but got I4
			//IL_0529: Expected O, but got I4
			//IL_0567: Expected O, but got I4
			//IL_0602: Expected F4, but got I4
			Vector3 vector = default(Vector3);
			CanvasGroup component = default(CanvasGroup);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag5 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			do
			{
				IL_0000:
				int num = 0;
				GameObject gameObject = audioManGO;
				int num2 = 0;
				if (gameObject != (UnityEngine.Object)num2)
				{
					RTPC rTPC = camHeightRTPC;
					Transform transform = SystemRoot.Instance._playerCamera.transform;
					float z = vector.z;
				}
				GridEditMode gridEditMode = gridEditModeSystem;
				int num3 = 0;
				if (gridEditMode != (UnityEngine.Object)num3)
				{
					GridEditMode gridEditMode2 = gridEditModeSystem;
					component = _btnEditModeUndo.GetComponent<CanvasGroup>();
					CanvasGroup component2 = _btnEditModeUndoAll.GetComponent<CanvasGroup>();
					if (!gridEditModeSystem.CanUndoLastCommand)
					{
						component.alpha = 0.5f;
					}
					component.alpha = 1f;
					component2.alpha = 1f;
					bool flag = (component.interactable = gridEditModeSystem.CanUndoLastCommand);
					component2.interactable = flag;
					component.blocksRaycasts = flag;
					component2.blocksRaycasts = flag;
					Item _003CSelectedWallpaperItem_003Ek__BackingField = gridEditModeSystem.SelectedWallpaperItem;
					int num4 = 0;
					if (!flag2)
					{
						if (!UiRoot.Instance.FocusCursor._cursorExtraImage.gameObject.activeSelf)
						{
							goto IL_019f;
						}
						int num5 = 0;
						GameObject gameObject2 = UiRoot.Instance.FocusCursor._cursorExtraImage.gameObject;
						int active = 0;
						gameObject2.SetActive((byte)active != 0);
						int num6 = 0;
						UiRoot.Instance.FocusCursor._cursorExtraImage.Release();
					}
					if (!UiRoot.Instance.FocusCursor._cursorExtraImage.gameObject.activeSelf)
					{
						Item _003CSelectedWallpaperItem_003Ek__BackingField2 = gridEditModeSystem.SelectedWallpaperItem;
						int num7 = 0;
						UiRoot.Instance.FocusCursor._cursorExtraImage.gameObject.SetActive(value: true);
						int num8 = 0;
						AsyncAtlassedIcon cursorExtraImage = UiRoot.Instance.FocusCursor._cursorExtraImage;
					}
					goto IL_019f;
				}
				goto IL_033e;
				IL_0628:
				if (gridEditModeSystem.CanUndoLastCommand && (inputActionUndoAll.IsTriggered ? 1 : 0) != num)
				{
					flag3 = (_justFiredPress ? 1 : 0) == num;
				}
				GameObject gameObject3 = _highlightImageUndoAll.gameObject;
				int active2 = 0;
				gameObject3.SetActive((byte)active2 != 0);
				_highlightImageUndoAll.fillAmount = 1f;
				Image highlightImageUndoAll = _highlightImageUndoAll;
				int complete = 0;
				int num9 = DOTween.Kill(highlightImageUndoAll, (byte)complete != 0);
				if (flag3)
				{
					Transform transform2 = _btnEditModeUndoAll.transform;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_btnEditModeUndoAll.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
				}
				if (!gridEditModeSystem.CanUndoLastCommand)
				{
					continue;
				}
				int num10 = 0;
				UiRoot instance = UiRoot.Instance;
				int ignoreThrobber = 0;
				if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
				{
					if (inputActionUndoAll.IsTriggered || _justFiredPress)
					{
						goto IL_0000;
					}
					Transform transform3 = _btnEditModeUndo.transform;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_btnEditModeUndo.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
					bool flag4 = (_justFiredPress = inputActionUndoAll.IsTriggered);
				}
				continue;
				IL_025a:
				FocusCursor focusCursor = UiRoot.Instance.FocusCursor;
				Sprite handClosedWhite = _handClosedWhite;
				SpriteAtlasImage cursorImage = focusCursor._cursorImage;
				string text2 = (cursorImage.ImageAddress = handClosedWhite.name);
				GridEditMode gridEditMode3 = gridEditModeSystem;
				EditModeState currentEditModeState = _currentEditModeState;
				GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)gridEditMode3)._selectedGridObject;
				int num11 = 0;
				if (!(selectedGridObject != (UnityEngine.Object)num11))
				{
					Item _003CSelectedWallpaperItem_003Ek__BackingField3 = gridEditModeSystem.SelectedWallpaperItem;
					if (!flag5 && (_inventoryContent.slidingPanel.isOpened ? 1 : 0) == num)
					{
						_currentEditModeState = (EditModeState)num;
					}
				}
				_currentEditModeState = EditModeState.ItemSelected;
				if (currentEditModeState != EditModeState.ItemSelected)
				{
					if (currentEditModeState == EditModeState.ItemSelected && (_shouldReopen ? 1 : 0) != num)
					{
						CatalogContent inventoryContent = _inventoryContent;
						if ((inventoryContent.slidingPanel.isOpened ? 1 : 0) == num)
						{
							inventoryContent.ForceRefresh = true;
							_inventoryContent.Toggle();
						}
					}
					if ((_showNewItem ? 1 : 0) != num)
					{
						_currentEditModeState = (EditModeState)num;
						_showNewItem = (byte)num != 0;
					}
					RefreshState();
				}
				goto IL_033e;
				IL_033e:
				int num12 = 0;
				float deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[9];
				InputAction inputAction = inputActionUndoRelease;
				if (inputAction != null && array == null)
				{
					goto IL_0000;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputActionUndoAll;
				if (inputAction2 != null && array == null)
				{
					goto IL_0000;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = inputActionUndoPress;
				if (inputAction3 != null && array == null)
				{
					goto IL_0000;
				}
				array[2] = inputAction3;
				InputAction inputAction4 = inputActionRemoveWholeFencePress;
				if (inputAction4 != null && array == null)
				{
					goto IL_0000;
				}
				array[3] = inputAction4;
				InputAction inputAction5 = inputActionRemoveWholeFenceReleased;
				if (inputAction5 != null && array == null)
				{
					goto IL_0000;
				}
				array[4] = inputAction5;
				InputAction inputAction6 = inputActionRemoveWholeFence;
				if (inputAction6 != null && array == null)
				{
					goto IL_0000;
				}
				array[5] = inputAction6;
				InputAction inputActionInteract = _inputActionInteract;
				if (inputActionInteract != null && array == null)
				{
					goto IL_0000;
				}
				array[6] = inputActionInteract;
				InputAction inputActionRT = _inputActionRT;
				if (inputActionRT != null && array == null)
				{
					goto IL_0000;
				}
				array[7] = inputActionRT;
				InputAction inputActionLT = _inputActionLT;
				if (inputActionLT != null && array == null)
				{
					goto IL_0000;
				}
				array[8] = inputActionLT;
				InputAction.UpdateAll(deltaTime, array);
				FocusNavigation focusNavigation = base.FocusNavigation;
				if (_inputActionRT.IsActuated())
				{
				}
				bool flag6 = (focusNavigation.IsPaused = _inputActionLT.IsActuated());
				if ((_isOverSideMenu ? 1 : 0) == num)
				{
					if (!flag7)
					{
						goto IL_057c;
					}
					int num13 = 0;
				}
				FocusNavigationElement sideMenuButton = GetSideMenuButton();
				int num14 = 0;
				if (component != (UnityEngine.Object)num14)
				{
					if ((object)sideMenuButton != null)
					{
						MainMenuTabButton component3 = sideMenuButton.GetComponent<MainMenuTabButton>();
					}
					if (flag8)
					{
						int num15 = 0;
						if ((UnityEngine.Object)num != (UnityEngine.Object)num15)
						{
							int num16 = 0;
						}
						if ((object)sideMenuButton != null)
						{
							MainMenuTabButton component4 = sideMenuButton.GetComponent<MainMenuTabButton>();
						}
						currentSideMenuButton = (MainMenuTabButton)num;
						int num17 = 0;
						if (!((UnityEngine.Object)num != (UnityEngine.Object)num17))
						{
						}
					}
				}
				if ((_inputActionInteract.IsTriggered ? 1 : 0) != num)
				{
					int num18 = 0;
					if (sideMenuButton != (UnityEngine.Object)num18)
					{
						if (sideMenuButton.GetComponent<MainMenuTabButton>().ShortcutDefinition.RedirectionType == RedirectionType.InventorySideToFurniture)
						{
							goto IL_0000;
						}
						int num19 = 0;
						InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
						int num20 = 0;
						if (menu != (UnityEngine.Object)num20)
						{
							MainMenuTabButton mainMenuTabButton = (menu.CurrentSelection = sideMenuButton.GetComponent<MainMenuTabButton>());
						}
					}
				}
				goto IL_057c;
				IL_019f:
				if ((_isOverSideMenu ? 1 : 0) != num)
				{
					int num21 = 0;
					FocusCursor focusCursor2 = UiRoot.Instance.FocusCursor;
				}
				GridObjectScript selectedGridObject2 = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject;
				int num22 = 0;
				if (selectedGridObject2 != (UnityEngine.Object)num22 && gridEditModeSystem.IsMovingSelectedObject)
				{
					bool canDeselectSelectedObject = gridEditModeSystem.CanDeselectSelectedObject;
					int num23 = 0;
					if (canDeselectSelectedObject)
					{
						goto IL_025a;
					}
					FocusCursor focusCursor3 = UiRoot.Instance.FocusCursor;
				}
				Item _003CSelectedWallpaperItem_003Ek__BackingField4 = gridEditModeSystem.SelectedWallpaperItem;
				if (!flag9)
				{
					GameObject hoveredGameObject = ((GridObjectGizmoSystem)gridEditModeSystem)._hoveredGameObject;
					int num24 = 0;
					bool flag10 = hoveredGameObject != (UnityEngine.Object)num24;
					int num25 = 0;
					if (!flag10)
					{
						FocusCursor focusCursor4 = UiRoot.Instance.FocusCursor;
						Sprite handPointing = _handPointing;
					}
					FocusCursor focusCursor5 = UiRoot.Instance.FocusCursor;
				}
				int num26 = 0;
				goto IL_025a;
				IL_057c:
				if ((inputActionUndoRelease.IsTriggered ? 1 : 0) != num || (inputActionUndoAll.IsTriggered ? 1 : 0) != num)
				{
					goto IL_0628;
				}
				if ((inputActionUndoPress.IsTriggered ? 1 : 0) != num && gridEditModeSystem.CanUndoLastCommand)
				{
					int num27 = 0;
					UiRoot instance2 = UiRoot.Instance;
					int ignoreThrobber2 = 0;
					if (instance2.IsOnTop(this, (byte)ignoreThrobber2 != 0))
					{
						_highlightImageUndoAll.gameObject.SetActive(value: true);
						Image highlightImageUndoAll2 = _highlightImageUndoAll;
						int num28 = 0;
						highlightImageUndoAll2.fillAmount = num28;
						float undoAllPressDelay = gridEditModeSystem._undoAllPressDelay;
						TweenerCore<float, float, FloatOptions> tweenerCore3 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
						goto IL_0628;
					}
				}
			}
			while (inputActionRemoveWholeFenceReleased.IsTriggered || inputActionRemoveWholeFence.IsTriggered || !inputActionRemoveWholeFencePress.IsTriggered);
			_highlightImageFence.gameObject.SetActive(value: true);
			Image highlightImageFence = _highlightImageFence;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001236")]
		[Cpp2IlInjected.Address(RVA = "0xFF4220", Offset = "0xFF2C20", VA = "0x180FF4220")]
		private void StartUndoAllButtonAnim()
		{
			//Discarded unreachable code: IL_0045
			//IL_0021: Expected F4, but got I4
			_highlightImageUndoAll.gameObject.SetActive(value: true);
			Image highlightImageUndoAll = _highlightImageUndoAll;
			int num = 0;
			highlightImageUndoAll.fillAmount = num;
			float undoAllPressDelay = gridEditModeSystem._undoAllPressDelay;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001237")]
		[Cpp2IlInjected.Address(RVA = "0xFF4460", Offset = "0xFF2E60", VA = "0x180FF4460")]
		private void StopUndoAllButtonAnim(bool playBumpAnim)
		{
			//Discarded unreachable code: IL_0075
			GameObject gameObject = _highlightImageUndoAll.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_highlightImageUndoAll.fillAmount = 1f;
			Image highlightImageUndoAll = _highlightImageUndoAll;
			int complete = 0;
			int num = DOTween.Kill(highlightImageUndoAll, (byte)complete != 0);
			if (playBumpAnim)
			{
				Transform transform = _btnEditModeUndoAll.transform;
				int num2 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_btnEditModeUndoAll.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001238")]
		[Cpp2IlInjected.Address(RVA = "0xFF4170", Offset = "0xFF2B70", VA = "0x180FF4170")]
		private void StartFenceButtonAnim()
		{
			//Discarded unreachable code: IL_0045
			//IL_0021: Expected F4, but got I4
			_highlightImageFence.gameObject.SetActive(value: true);
			Image highlightImageFence = _highlightImageFence;
			int num = 0;
			highlightImageFence.fillAmount = num;
			float undoAllPressDelay = gridEditModeSystem._undoAllPressDelay;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageFence, 1f, undoAllPressDelay)).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001239")]
		[Cpp2IlInjected.Address(RVA = "0xFF42D0", Offset = "0xFF2CD0", VA = "0x180FF42D0")]
		private void StopFenceButtonAnim(bool playBumpAnim)
		{
			//Discarded unreachable code: IL_0075
			GameObject gameObject = _highlightImageFence.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_highlightImageFence.fillAmount = 1f;
			Image highlightImageFence = _highlightImageFence;
			int complete = 0;
			int num = DOTween.Kill(highlightImageFence, (byte)complete != 0);
			if (playBumpAnim)
			{
				Transform transform = _fenceRemoveButton.transform;
				int num2 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_fenceRemoveButton.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600123A")]
		[Cpp2IlInjected.Address(RVA = "0xFEF560", Offset = "0xFEDF60", VA = "0x180FEF560")]
		private void BumpUndoButton()
		{
			//Discarded unreachable code: IL_0038
			Transform transform = _btnEditModeUndo.transform;
			int num = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_btnEditModeUndo.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x600123B")]
		[Cpp2IlInjected.Address(RVA = "0xFF39E0", Offset = "0xFF23E0", VA = "0x180FF39E0")]
		public void RemoveWholeFence()
		{
			//Discarded unreachable code: IL_001b
			if (gridEditModeSystem.CanRemoveWholeFence)
			{
				gridEditModeSystem.RemoveWholeFence();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600123C")]
		[Cpp2IlInjected.Address(RVA = "0xFF3990", Offset = "0xFF2390", VA = "0x180FF3990")]
		public void RemoveButtonClick()
		{
			//Discarded unreachable code: IL_001b
			if (gridEditModeSystem.CanRemoveSelectedObject)
			{
				gridEditModeSystem.RemoveSelectedObject();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600123D")]
		[Cpp2IlInjected.Address(RVA = "0xFF3A30", Offset = "0xFF2430", VA = "0x180FF3A30")]
		public void ReplaceButtonClick()
		{
			//Discarded unreachable code: IL_001b
			if (gridEditModeSystem.CanReplaceSelectedObject)
			{
				gridEditModeSystem.ReplaceSelectedObject();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600123E")]
		[Cpp2IlInjected.Address(RVA = "0xFF2DA0", Offset = "0xFF17A0", VA = "0x180FF2DA0")]
		private void RefreshState()
		{
			//Discarded unreachable code: IL_022f
			//IL_016e: Expected O, but got I4
			//IL_01e7: Expected I4, but got I8
			//IL_021c: Expected I4, but got I8
			//IL_022e: Expected I4, but got I8
			bool isSomethingOpened = IsSomethingOpened;
			EditModeState currentEditModeState = _currentEditModeState;
			bool active = !isSomethingOpened;
			if (currentEditModeState != 0)
			{
				switch (currentEditModeState)
				{
				case EditModeState.InventoryOpened:
				{
					_objectSelectedButtonContainer.SetActive(active);
					_controllerButtonContainer.SetActive(active);
					GameObject undoContainer = _undoContainer;
					int active2 = 0;
					undoContainer.SetActive((byte)active2 != 0);
					SlidingPanel slidingPanel = _inventoryContent.slidingPanel;
					if (slidingPanel.isOpened)
					{
						slidingPanel.Close();
					}
					GameObject rotateControlInfo = _rotateControlInfo;
					bool isSelectedObjectRotatable = IsSelectedObjectRotatable;
					rotateControlInfo.SetActive(isSelectedObjectRotatable);
					GameObject rotateControlInfoGP = _rotateControlInfoGP;
					bool isSelectedObjectRotatable2 = IsSelectedObjectRotatable;
					rotateControlInfoGP.SetActive(isSelectedObjectRotatable2);
					GameObject gameObject = _fenceRemoveButton.gameObject;
					bool active3 = gridEditModeSystem.IsInFenceMode();
					gameObject.SetActive(active3);
					GameObject gameObject2 = _removeButton.gameObject;
					bool canRemoveSelectedObject = gridEditModeSystem.CanRemoveSelectedObject;
					gameObject2.SetActive(canRemoveSelectedObject);
					GameObject gameObject3 = _replaceButton.gameObject;
					bool isSelectedObjectReplaceable = IsSelectedObjectReplaceable;
					gameObject3.SetActive(isSelectedObjectReplaceable);
					NotificationButton replaceButton = _replaceButton;
					if (!HasReplacementsSelectedObject)
					{
					}
					bool flag2 = (replaceButton.IsActive = !IsSelectedObjectReplaceLocked);
					Button buttonComponent = _replaceButton.ButtonComponent;
					bool flag3 = (buttonComponent.interactable = ((BaseButton)_replaceButton)._isActive);
					Image background = _replaceButton.Background;
					Color white = Color.white;
					int num = 0;
					background.color = (Color)num;
					GameObject gameObject4 = _replaceNeedsUpgradeLabel.gameObject;
					bool isSelectedObjectReplaceLocked = IsSelectedObjectReplaceLocked;
					gameObject4.SetActive(isSelectedObjectReplaceLocked);
					GameObject exitShorcutDisplay = _exitShorcutDisplay;
					int active4 = 0;
					exitShorcutDisplay.SetActive((byte)active4 != 0);
					GameObject gameObject5 = _panelCloseBackShortcut.gameObject;
					int active5 = 0;
					gameObject5.SetActive((byte)active5 != 0);
					return;
				}
				default:
					return;
				case EditModeState.NoSelection:
					break;
				}
			}
			GameObject objectSelectedButtonContainer = _objectSelectedButtonContainer;
			int active6 = 0;
			objectSelectedButtonContainer.SetActive((byte)active6 != 0);
			_controllerButtonContainer.SetActive(active);
			ulong num2 = default(ulong);
			_undoContainer.SetActive((byte)num2 != 0);
			GameObject rotateControlInfo2 = _rotateControlInfo;
			int active7 = 0;
			rotateControlInfo2.SetActive((byte)active7 != 0);
			GameObject rotateControlInfoGP2 = _rotateControlInfoGP;
			int active8 = 0;
			rotateControlInfoGP2.SetActive((byte)active8 != 0);
			ulong num3 = default(ulong);
			_exitShorcutDisplay.SetActive((byte)num3 != 0);
			ulong num4 = default(ulong);
			_panelCloseBackShortcut.gameObject.SetActive((byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001244")]
		[Cpp2IlInjected.Address(RVA = "0xFF0200", Offset = "0xFEEC00", VA = "0x180FF0200")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_0063
			GridEditMode gridEditMode = gridEditModeSystem;
			int num = 0;
			int width = Screen.width;
			int num2 = 0;
			int height = Screen.height;
			RectTransform component = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
			Vector2 sizeDelta = component.sizeDelta;
			Vector2 sizeDelta2 = component.sizeDelta;
			Vector2 sizeDelta3 = component.sizeDelta;
			Vector2 sizeDelta4 = component.sizeDelta;
			int num3 = 0;
			UiRoot.Instance.FocusCursor._rectTransform.anchoredPosition = sizeDelta;
		}

		[Cpp2IlInjected.Token(Token = "0x6001245")]
		[Cpp2IlInjected.Address(RVA = "0xFF18E0", Offset = "0xFF02E0", VA = "0x180FF18E0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_00c6
			//IL_0032: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			//IL_00c5: Expected F4, but got I4
			if (!_isExiting)
			{
				CancellationToken cancellationToken = base.CancellationToken;
				this.ExitEditModeTask(cancellationToken).FireAndForgetTask();
			}
			base.OnPop();
			InfoGizmo houseExpantionGizmo = _houseExpantionGizmo;
			int num = 0;
			if (houseExpantionGizmo != (UnityEngine.Object)num)
			{
				_houseExpantionGizmo.gameObject.SetActive(value: true);
			}
			int num2 = 0;
			if (UiRoot.Instance.FocusCursor.gameObject.activeSelf)
			{
				int num3 = 0;
				GameObject gameObject = UiRoot.Instance.FocusCursor.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			GameObject gameObject2 = audioManGO;
			int num4 = 0;
			if (gameObject2 != (UnityEngine.Object)num4)
			{
				AK.Wwise.Event @event = stopCatalogAmb;
				GameObject gameObject3 = audioManGO;
				uint num5 = @event.Post(gameObject3);
				RTPC rTPC = camHeightRTPC;
				int num6 = 0;
				rTPC.SetGlobalValue(num6);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001246")]
		[Cpp2IlInjected.Address(RVA = "0xFF2A30", Offset = "0xFF1430", VA = "0x180FF2A30", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__113))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__113 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__113(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001247")]
		[Cpp2IlInjected.Address(RVA = "0xAF0B80", Offset = "0xAEF580", VA = "0x180AF0B80", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			base.OnFocusOut(popAfterFocusOut, animate);
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001248")]
		[Cpp2IlInjected.Address(RVA = "0xFF0600", Offset = "0xFEF000", VA = "0x180FF0600")]
		public void OnConfirmClickHandler()
		{
			//Discarded unreachable code: IL_002b
			int num = 0;
			VibrationsManager.TriggerSelection();
			CancellationToken cancellationToken = base.CancellationToken;
			bool canUndoLastCommand = gridEditModeSystem.CanUndoLastCommand;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num2 = 0;
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001249")]
		[Cpp2IlInjected.Address(RVA = "0xFF0A60", Offset = "0xFEF460", VA = "0x180FF0A60")]
		private void OnExitEditModeClickHandler()
		{
			//Discarded unreachable code: IL_003e
			//IL_001e: Expected O, but got I4
			if (IsInEditMode)
			{
				GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject;
				int num = 0;
				if (selectedGridObject == (UnityEngine.Object)num)
				{
					CancellationToken cancellationToken = base.CancellationToken;
					this.ExitEditModeTask(cancellationToken).FireAndForgetTask();
				}
			}
			else
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600124A")]
		[Cpp2IlInjected.Address(RVA = "0xFEF800", Offset = "0xFEE200", VA = "0x180FEF800")]
		[AsyncStateMachine(typeof(_003CExitEditModeTask_003Ed__117))]
		public Task<bool> ExitEditModeTask(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600124B")]
		[Cpp2IlInjected.Address(RVA = "0xFEF640", Offset = "0xFEE040", VA = "0x180FEF640")]
		[AsyncStateMachine(typeof(_003CConfirmEditModeTask_003Ed__118))]
		public Task<bool> ConfirmEditModeTask(CancellationToken ct, bool confirm)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600124C")]
		[Cpp2IlInjected.Address(RVA = "0xFEFDE0", Offset = "0xFEE7E0", VA = "0x180FEFDE0")]
		private void GridEditModeStoppedEvent(Mdl.Systems.System system)
		{
			//Discarded unreachable code: IL_0033
			if (!IsPopAll)
			{
				if (_stack.Top == null)
				{
				}
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					_stack.Kill(this);
				}
				else
				{
					IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600124D")]
		[Cpp2IlInjected.Address(RVA = "0xFF2850", Offset = "0xFF1250", VA = "0x180FF2850")]
		private void OnUndoEditModeClickHandler()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600124E")]
		[Cpp2IlInjected.Address(RVA = "0xFF2750", Offset = "0xFF1150", VA = "0x180FF2750")]
		[AsyncStateMachine(typeof(_003COnUndoEditModeClickHandlerAsync_003Ed__121))]
		private Task OnUndoEditModeClickHandlerAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600124F")]
		[Cpp2IlInjected.Address(RVA = "0xFF2610", Offset = "0xFF1010", VA = "0x180FF2610")]
		private void OnUndoAllEditModeClickHandler()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001250")]
		[Cpp2IlInjected.Address(RVA = "0xFF2510", Offset = "0xFF0F10", VA = "0x180FF2510")]
		[AsyncStateMachine(typeof(_003COnUndoAllEditModeClickHandlerAsync_003Ed__123))]
		private Task OnUndoAllEditModeClickHandlerAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001251")]
		[Cpp2IlInjected.Address(RVA = "0xFF1060", Offset = "0xFEFA60", VA = "0x180FF1060")]
		private void OnInventoryItemDrag(Item item, bool drag)
		{
			//IL_0027: Expected F4, but got I4
			//IL_0051: Expected O, but got I4
			GridEditMode gridEditMode = gridEditModeSystem;
			GridEditMode gridEditMode2 = gridEditModeSystem;
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				BaseUiRoot.Instance.UiErrorMessage("menu.error_edit_mode_invalid_floor_type", num);
				return;
			}
			SlidingPanel component = _btnEditModeUndo.GetComponent<SlidingPanel>();
			_inventoryContent.slidingPanel.Close();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2 && component.isHidden)
			{
				component.Open();
			}
			int num3 = 0;
			int width = Screen.width;
			int num4 = 0;
			int height = Screen.height;
			bool flag2 = default(bool);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			if (flag2 && furnitureItemType == FurnitureItemType.Landscaping)
			{
				GridEditMode gridEditMode3 = gridEditModeSystem;
				if (drag)
				{
					int num5 = 0;
				}
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			if (drag)
			{
				int num6 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001252")]
		[Cpp2IlInjected.Address(RVA = "0xFEF940", Offset = "0xFEE340", VA = "0x180FEF940")]
		public void ForceUpdateList()
		{
			//Discarded unreachable code: IL_001b
			if (base.gameObject.activeInHierarchy)
			{
				_inventoryContent.ForceUpdateList();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001253")]
		[Cpp2IlInjected.Address(RVA = "0xFF2D70", Offset = "0xFF1770", VA = "0x180FF2D70")]
		public void RefreshNodes()
		{
			//Discarded unreachable code: IL_000c
			_inventoryContent.RefreshNodes();
		}

		[Cpp2IlInjected.Token(Token = "0x6001254")]
		[Cpp2IlInjected.Address(RVA = "0xFF2990", Offset = "0xFF1390", VA = "0x180FF2990")]
		public void OpenPanel()
		{
			//Discarded unreachable code: IL_004e
			CatalogContent inventoryContent = _inventoryContent;
			if (!inventoryContent.slidingPanel.isOpened)
			{
				inventoryContent.ForceRefresh = true;
				_inventoryContent.slidingPanel.Open();
				return;
			}
			ItemFilterData _003CCatalogItemFilters_003Ek__BackingField = inventoryContent.CatalogItemFilters;
			inventoryContent.SetDefaultFilters(_003CCatalogItemFilters_003Ek__BackingField);
			CatalogContent inventoryContent2 = _inventoryContent;
			_inventoryContent.RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x6001255")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void NumberOfItemsInCartChangedEventHandler(int newNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001256")]
		[Cpp2IlInjected.Address(RVA = "0xFF2240", Offset = "0xFF0C40", VA = "0x180FF2240")]
		public void OnShoppingCartClicked()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001257")]
		[Cpp2IlInjected.Address(RVA = "0xFF3D60", Offset = "0xFF2760", VA = "0x180FF3D60")]
		[AsyncStateMachine(typeof(_003CShoppingCartTask_003Ed__130))]
		private Task ShoppingCartTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001258")]
		[Cpp2IlInjected.Address(RVA = "0xFEF790", Offset = "0xFEE190", VA = "0x180FEF790")]
		private void DeselectSelectedObject()
		{
			//Discarded unreachable code: IL_002f
			if (IsSomethingSelected)
			{
				gridEditModeSystem.UndoLastCommand();
				if (base.gameObject.activeInHierarchy)
				{
					_inventoryContent.ForceUpdateList();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001259")]
		[Cpp2IlInjected.Address(RVA = "0xFF1850", Offset = "0xFF0250", VA = "0x180FF1850")]
		private void OnPanelOpened()
		{
			//Discarded unreachable code: IL_004f
			//IL_004e: Expected F4, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			RefreshBackIndicator();
			_exitShorcutDisplay.SetActive(value: true);
			_panelOpenBackShortcut.alpha = 1f;
			CanvasGroup panelCloseBackShortcut = _panelCloseBackShortcut;
			int num2 = 0;
			panelCloseBackShortcut.alpha = num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600125A")]
		[Cpp2IlInjected.Address(RVA = "0xFF1740", Offset = "0xFF0140", VA = "0x180FF1740")]
		private void OnPanelClosed()
		{
			//Discarded unreachable code: IL_007f
			//IL_006a: Expected F4, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			_tfFilterCounter.StringID = "menu.save_and_exit";
			RectTransform component = _tfFilterCounter.GetComponent<RectTransform>();
			int axis = 0;
			component.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, 80f);
			_panelCloseBackShortcut.alpha = 1f;
			CanvasGroup panelOpenBackShortcut = _panelOpenBackShortcut;
			int num2 = 0;
			panelOpenBackShortcut.alpha = num2;
			GameObject exitShorcutDisplay = _exitShorcutDisplay;
			int active = 0;
			exitShorcutDisplay.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600125B")]
		[Cpp2IlInjected.Address(RVA = "0xFF0B60", Offset = "0xFEF560", VA = "0x180FF0B60")]
		public void OnExplicitClose()
		{
			_shouldReopen = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600125C")]
		[Cpp2IlInjected.Address(RVA = "0xFF2AB0", Offset = "0xFF14B0", VA = "0x180FF2AB0")]
		private void RefreshBackIndicator()
		{
			//Discarded unreachable code: IL_003a
			if (_inventoryContent._currentState <= StoreMenu.CatalogStorePhase.Quest)
			{
				_tfFilterCounter.StringID = "menu.catalog_close_panel";
				RectTransform component = _tfFilterCounter.GetComponent<RectTransform>();
				int axis = 0;
				component.SetSizeWithCurrentAnchors((RectTransform.Axis)axis, 400f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600125D")]
		[Cpp2IlInjected.Address(RVA = "0xFF0430", Offset = "0xFEEE30", VA = "0x180FF0430")]
		private void OnCatalogPhaseChanged()
		{
			RefreshBackIndicator();
		}

		[Cpp2IlInjected.Token(Token = "0x600125E")]
		[Cpp2IlInjected.Address(RVA = "0xFF07D0", Offset = "0xFEF1D0", VA = "0x180FF07D0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_00b7
			//IL_0032: Expected O, but got I4
			base.OnControllerChanged();
			RefreshCursor();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				ItemSelector itemSelector = ItemSelector;
				int num2 = 0;
				if (itemSelector != (UnityEngine.Object)num2 && ItemSelector.gameObject.activeSelf)
				{
					_isGamepadHoldAllowed = true;
					ItemSelector itemSelector2 = ItemSelector;
					FocusNavigation focusNavigation = base.FocusNavigation;
					itemSelector2.SetFocus(focusNavigation);
				}
				_isGamepadHoldAllowed = false;
				_pcShortcut.SetActive(value: true);
				GameObject gamepadShortcut = _gamepadShortcut;
				int active = 0;
				gamepadShortcut.SetActive((byte)active != 0);
			}
			else
			{
				SetFocus();
				GameObject pcShortcut = _pcShortcut;
				int active2 = 0;
				pcShortcut.SetActive((byte)active2 != 0);
				_gamepadShortcut.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600125F")]
		[Cpp2IlInjected.Address(RVA = "0xFF3BA0", Offset = "0xFF25A0", VA = "0x180FF3BA0")]
		internal void SetFocus()
		{
			//Discarded unreachable code: IL_00a0
			//IL_0010: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			ItemSelector itemSelector = ItemSelector;
			int num = 0;
			bool flag = itemSelector != (UnityEngine.Object)num;
			if (!flag)
			{
				_isGamepadHoldAllowed = flag;
				SlidingPanel slidingPanel = _inventoryContent.slidingPanel;
				if (!slidingPanel.isOpened && !slidingPanel.IsOpening)
				{
					FocusNavigation focusNavigation = base.FocusNavigation;
					int num2 = 0;
					focusNavigation.RemoveFocus((ISupportsFocusNavigation)num2);
					return;
				}
				FocusNavigationElement lastFocusedElement = _lastFocusedElement;
				int num3 = 0;
				bool flag2 = lastFocusedElement != (UnityEngine.Object)num3;
				CatalogContent inventoryContent = _inventoryContent;
				FocusNavigation focusNavigation2 = base.FocusNavigation;
				inventoryContent.SetFocus(focusNavigation2);
			}
			else
			{
				_isGamepadHoldAllowed = true;
				ItemSelector itemSelector2 = ItemSelector;
				FocusNavigation focusNavigation3 = base.FocusNavigation;
				itemSelector2.SetFocus(focusNavigation3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001260")]
		[Cpp2IlInjected.Address(RVA = "0xFEFEF0", Offset = "0xFEE8F0", VA = "0x180FEFEF0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_00a2
			//IL_002e: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			ItemSelector itemSelector = default(ItemSelector);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				switch (redirectionType)
				{
				case RedirectionType.ToFilter:
					_inventoryContent.OnFilterClickHandler();
					return;
				case RedirectionType.MenuNavGoBackward:
				{
					itemSelector = ItemSelector;
					int num = 0;
					if (!(itemSelector != (UnityEngine.Object)num))
					{
						SlidingPanel slidingPanel = _inventoryContent.slidingPanel;
						if (slidingPanel.isOpened)
						{
							return;
						}
						if (!slidingPanel.IsClosed)
						{
							continue;
						}
						if (!IsSomethingSelected)
						{
							int num2 = 0;
							InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
							int num3 = 0;
							if (!(menu != (UnityEngine.Object)num3))
							{
								continue;
							}
							menu.ShouldPop = true;
						}
					}
					else
					{
						itemSelector.Cancel();
					}
					return;
				}
				}
				while ((long)itemSelector != 917769)
				{
				}
				if (flag && !flag2)
				{
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001261")]
		[Cpp2IlInjected.Address(RVA = "0xFEF990", Offset = "0xFEE390", VA = "0x180FEF990")]
		public unsafe List<RaycastResult> GetEventSystemRaycastResults(Vector2 position)
		{
			//Discarded unreachable code: IL_0036
			//IL_0020: Expected F4, but got I4
			//IL_001b: Expected native int or pointer, but got O
			int num = 0;
			PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
			pointerEventData.position = position;
			((Vector2*)(IntPtr)pointerEventData.position)->y = 0f;
			List<RaycastResult> list = (List<RaycastResult>)(object)new List<T>();
			int num2 = 0;
			EventSystem.current.RaycastAll(pointerEventData, (List<>)(object)list);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6001262")]
		[Cpp2IlInjected.Address(RVA = "0xFEFAA0", Offset = "0xFEE4A0", VA = "0x180FEFAA0")]
		private FocusNavigationElement GetSideMenuButton()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001263")]
		[Cpp2IlInjected.Address(RVA = "0xFF3A80", Offset = "0xFF2480", VA = "0x180FF3A80")]
		public void SendFocusToInventoryTabs(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_0046
			//IL_001f: Expected O, but got I4
			if (direction == FocusDirection.Left)
			{
				int num = 0;
				InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
				int num2 = 0;
				if (menu != (UnityEngine.Object)num2)
				{
					_lastFocusedElement = currentElement;
					FocusNavigation focusNavigation = base.FocusNavigation;
					FocusNavigationElement component = menu.CurrentSelection.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001264")]
		[Cpp2IlInjected.Address(RVA = "0xFF0B70", Offset = "0xFEF570", VA = "0x180FF0B70")]
		private void OnFocusChanged(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0031
			ISupportsFocusNavigation focusedElement = base.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Transform parent = base.transform;
				Transform transform = default(Transform);
				if (transform.IsChildOf(parent))
				{
					_lastFocusedElement = (FocusNavigationElement)focusedElement;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001265")]
		[Cpp2IlInjected.Address(RVA = "0xFF0410", Offset = "0xFEEE10", VA = "0x180FF0410")]
		private void OnCatalogContentStateChange()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001266")]
		[Cpp2IlInjected.Address(RVA = "0xFF1410", Offset = "0xFEFE10", VA = "0x180FF1410")]
		private void OnItemSelectorOnOff(bool isOpened)
		{
			//Discarded unreachable code: IL_0083
			//IL_0041: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				if (!IsSomethingOpened)
				{
					int num2 = 0;
					UiRoot.Instance.UpdateCursorBehaviorForGameplay();
					int num3 = 0;
					_overrideAllScope = (PlayerNavigation.TemporaryOverrideScope)num3;
				}
				bool flag = default(bool);
				if (!flag)
				{
					PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (_overrideAllScope = system.OverrideAllScope());
				}
				int num4 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance2.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				RefreshState();
				RefreshCursor();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001267")]
		[Cpp2IlInjected.Address(RVA = "0xFF23B0", Offset = "0xFF0DB0", VA = "0x180FF23B0")]
		private void OnSomethingOpened()
		{
			//IL_0029: Expected O, but got I4
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			if (!IsSomethingOpened)
			{
				int num = 0;
				UiRoot.Instance.UpdateCursorBehaviorForGameplay();
				int num2 = 0;
				_overrideAllScope = (PlayerNavigation.TemporaryOverrideScope)num2;
				return;
			}
			bool flag = default(bool);
			while (flag)
			{
			}
			PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (_overrideAllScope = system.OverrideAllScope());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001268")]
		[Cpp2IlInjected.Address(RVA = "0xFF6320", Offset = "0xFF4D20", VA = "0x180FF6320")]
		public CatalogMenu()
		{
		}
	}
}
