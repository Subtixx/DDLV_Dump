using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using Mdl.Grid;
using Mdl.Systems;
using Mdl.Ui;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HudGainItemNotif : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class CritterNotif
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Item collectionSetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int groupIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Item itemAdded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool fromCooking;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CritterNotif()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[Tooltip("If true, will have to call ShowQueuedCritterNotifs() manually to show Critter notifs.")]
	public bool UseCritterQueue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool _canShowCritterQueue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[SerializeField]
	private int MaxNotificationOnScreen = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[SerializeField]
	private RectTransform _containerClothing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[SerializeField]
	private RectTransform _containerFurniture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[SerializeField]
	private RectTransform _containerCritter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[SerializeField]
	private RectTransform _clothingHolder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[SerializeField]
	private RectTransform _furnitureHolder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[SerializeField]
	private RectTransform _critterHolder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[SerializeField]
	private HudNewItem _itemPrefab;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[SerializeField]
	private Transform _trashBin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[SerializeField]
	private HudMenu _hudMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[SerializeField]
	private AK.Wwise.Event _sfxNotif;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[SerializeField]
	private GameObject _audioEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool shouldDisplayNotif = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Coroutine _showHideDelayCoroutine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private bool _scheduleItemNotificationOnNextFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private List<IItemData> _clothingItemToDisplayList = (List<IItemData>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private List<IItemData> _furnitureItemToDisplayList = (List<IItemData>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private List<IItemData> _critterItemToDisplayList = (List<IItemData>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private Queue<CritterNotif> _critterQueue = (Queue<CritterNotif>)(object)new Queue<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private CutsceneSystem cutsceneSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private List<HudNewItem> itemsToHideOnNextFocus = (List<HudNewItem>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private Dictionary<HudNewItem, Tween> hideTweens = (Dictionary<HudNewItem, Tween>)(object)new Dictionary<TKey, TValue>();

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5320", VA = "0x180AF6920")]
	private void Start()
	{
		//Discarded unreachable code: IL_00b5
		//IL_0010: Expected O, but got I4
		HudMenu hudMenu = _hudMenu;
		int num = 0;
		if (hudMenu == (UnityEngine.Object)num)
		{
			int num2 = 0;
			HudMenu hudMenu2 = (_hudMenu = UiRoot.Instance._menuStack.GetMenu<HudMenu>());
		}
		CutsceneSystem cutsceneSystem = (this.cutsceneSystem = SystemRoot.Instance.GetSystem<CutsceneSystem>());
		ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
		ProfileEventDispatcher.CollectionSetUpdated value = OnCollectionSetUpdated;
		_003CDispatcher_003Ek__BackingField.OnCollectionSetUpdated += value;
		int num3 = 0;
		MenuStack menuStack = UiRoot.Instance._menuStack;
		MenuStack.CurrentMenuChanged value2 = OnMenuChange;
		menuStack.OnCurrentMenuChanged += value2;
		int num4 = 0;
		MenuStack popupStack = UiRoot.Instance._popupStack;
		MenuStack.CurrentMenuChanged value3 = OnMenuChange;
		popupStack.OnCurrentMenuChanged += value3;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xAF5830", Offset = "0xAF4230", VA = "0x180AF5830")]
	private void OnEnable()
	{
		if ((long)_showHideDelayCoroutine != 0 || Enumerable.Any<HudNewItem>((IEnumerable<>)itemsToHideOnNextFocus))
		{
			IEnumerator routine = ShowHideDelay();
			Coroutine coroutine = (_showHideDelayCoroutine = StartCoroutine(routine));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xAF5740", Offset = "0xAF4140", VA = "0x180AF5740")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_0047
		int num = 0;
		MenuStack menuStack = UiRoot.Instance._menuStack;
		MenuStack.CurrentMenuChanged value = OnMenuChange;
		menuStack.OnCurrentMenuChanged -= value;
		int num2 = 0;
		MenuStack popupStack = UiRoot.Instance._popupStack;
		MenuStack.CurrentMenuChanged value2 = OnMenuChange;
		popupStack.OnCurrentMenuChanged -= value2;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0xAF58C0", Offset = "0xAF42C0", VA = "0x180AF58C0")]
	private void OnMenuChange(IMenu menu)
	{
		//Discarded unreachable code: IL_00b2
		int num = 0;
		if (menu == null)
		{
			if ((_canShowCritterQueue ? 1 : 0) != num)
			{
				goto IL_0061;
			}
			if (menu == null)
			{
				goto IL_0067;
			}
		}
		int num2 = 0;
		if (menu != null)
		{
			if ((_scheduleItemNotificationOnNextFocus ? 1 : 0) != num && (IntPtr)_showHideDelayCoroutine == (IntPtr)num)
			{
				int num3 = 0;
				if (menu != null && base.gameObject.activeInHierarchy)
				{
					if (!_canShowCritterQueue)
					{
						IEnumerator routine = ShowHideDelay();
						Coroutine coroutine = (_showHideDelayCoroutine = StartCoroutine(routine));
						return;
					}
					goto IL_0061;
				}
				return;
			}
			return;
		}
		goto IL_0067;
		IL_0061:
		ShowQueuedCritterNotifs();
		goto IL_0067;
		IL_0067:
		if ((UseCritterQueue ? 1 : 0) != num && menu != null)
		{
			int num4 = 0;
			if (menu != null)
			{
				_canShowCritterQueue = true;
			}
		}
		Coroutine showHideDelayCoroutine = _showHideDelayCoroutine;
		if (showHideDelayCoroutine != null)
		{
			StopCoroutine(showHideDelayCoroutine);
		}
		Dictionary<HudNewItem, Tween> dictionary = hideTweens;
		bool flag = default(bool);
		if (flag)
		{
			List<HudNewItem> list = itemsToHideOnNextFocus;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xAF60D0", Offset = "0xAF4AD0", VA = "0x180AF60D0")]
	[IteratorStateMachine(typeof(_003CShowHideDelay_003Ed__29))]
	private IEnumerator ShowHideDelay()
	{
		int _003C_003E1__state = default(int);
		_003CShowHideDelay_003Ed__29 _003CShowHideDelay_003Ed__ = new _003CShowHideDelay_003Ed__29(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CShowHideDelay_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xAF4AC0", Offset = "0xAF34C0", VA = "0x180AF4AC0")]
	[IteratorStateMachine(typeof(_003CHideNotificationItems_003Ed__30))]
	private IEnumerator HideNotificationItems()
	{
		int _003C_003E1__state = default(int);
		_003CHideNotificationItems_003Ed__30 _003CHideNotificationItems_003Ed__ = new _003CHideNotificationItems_003Ed__30(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CHideNotificationItems_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xAF4B30", Offset = "0xAF3530", VA = "0x180AF4B30")]
	private void OnCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromCooking)
	{
		//Discarded unreachable code: IL_02c6, IL_02fd, IL_0303, IL_0309, IL_030f, IL_0315, IL_031b, IL_0321, IL_0327, IL_032d, IL_0333, IL_0339, IL_033f, IL_0345
		//IL_001c: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		int itemID = itemAdded.ItemID;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Item itemAdded2 = (Item)itemID;
		ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
		Item item = itemAdded2;
		FurnitureItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<FurnitureItemData>(item);
		ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
		Item item2 = itemAdded2;
		ClothingItemData itemData2 = _003CInstance_003Ek__BackingField2.GetItemData<ClothingItemData>(item2);
		ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
		Item item3 = itemAdded2;
		CritterItemData critterItemData = _003CInstance_003Ek__BackingField3.GetItemData<CritterItemData>(item3);
		if (itemData2 != null)
		{
			List<IItemData> clothingItemToDisplayList = _clothingItemToDisplayList;
			Func<IItemData, bool> cpp2il__autoParamName__idx_ = (Func<IItemData, bool>)(object)(Func<T, TResult>)((IItemData x) => (object)typeof(IItemData).TypeHandle == (object)itemAdded2);
			if (!((IEnumerable<>)clothingItemToDisplayList).Any<IItemData>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				RectTransform containerClothing = _containerClothing;
				List<IItemData> notificationData = (List<IItemData>)(object)this.GetNotificationData(containerClothing);
				Func<IItemData, bool> cpp2il__autoParamName__idx_2 = (Func<IItemData, bool>)(object)(Func<T, TResult>)((IItemData x) => (object)typeof(IItemData).TypeHandle == (object)itemAdded2);
				if (!((IEnumerable<>)notificationData).Any<IItemData>((Func<, >)(object)cpp2il__autoParamName__idx_2))
				{
					Client client = default(Client);
					ListInventory wardrobe = client.profile.Wardrobe;
					IEnumerable<ClothingItemData> enumerable = default(IEnumerable<ClothingItemData>);
					List<ClothingItemData> list = (List<ClothingItemData>)(object)Enumerable.ToList<ClothingItemData>((IEnumerable<>)enumerable);
					bool flag = default(bool);
					if (flag)
					{
						while (num2 == 0)
						{
						}
						int num4 = default(int);
						while (num4 == 0)
						{
						}
						List<IItemData> clothingItemToDisplayList2 = _clothingItemToDisplayList;
						int size = ((List<>)(object)_furnitureItemToDisplayList)._size;
						int size2 = ((List<>)(object)_critterItemToDisplayList)._size;
						size2 += size;
						while (size2 >= MaxNotificationOnScreen)
						{
						}
						((List<T>)(object)clothingItemToDisplayList2).Add((T)num2);
						int forceHudVisible = 0;
						if (!CanShowNotification((byte)forceHudVisible != 0))
						{
							_scheduleItemNotificationOnNextFocus = true;
						}
						ShowNotificationItem();
					}
					num3++;
					if (num3 == 0)
					{
					}
				}
			}
		}
		List<IItemData> notificationData2 = default(List<IItemData>);
		if (itemData != null)
		{
			List<IItemData> furnitureItemToDisplayList = _furnitureItemToDisplayList;
			Func<IItemData, bool> cpp2il__autoParamName__idx_3 = (Func<IItemData, bool>)(object)(Func<T, TResult>)((IItemData x) => (object)typeof(IItemData).TypeHandle == (object)itemAdded2);
			if (!((IEnumerable<>)furnitureItemToDisplayList).Any<IItemData>((Func<, >)(object)cpp2il__autoParamName__idx_3))
			{
				RectTransform containerFurniture = _containerFurniture;
				notificationData2 = (List<IItemData>)(object)this.GetNotificationData(containerFurniture);
				Func<IItemData, bool> cpp2il__autoParamName__idx_4 = (Func<IItemData, bool>)(object)(Func<T, TResult>)((IItemData x) => (object)typeof(IItemData).TypeHandle == (object)itemAdded2);
				if (!((IEnumerable<>)notificationData2).Any<IItemData>((Func<, >)(object)cpp2il__autoParamName__idx_4))
				{
					Client client2 = default(Client);
					ListInventory catalog = client2.profile.Catalog;
					IEnumerable<FurnitureItemData> enumerable2 = default(IEnumerable<FurnitureItemData>);
					List<FurnitureItemData> list2 = (List<FurnitureItemData>)(object)Enumerable.ToList<FurnitureItemData>((IEnumerable<>)enumerable2);
					bool flag2 = default(bool);
					if (flag2)
					{
						while (num2 == 0)
						{
						}
						int num5 = default(int);
						while (num5 == 0)
						{
						}
						int size3 = ((List<>)(object)_clothingItemToDisplayList)._size;
						int size4 = ((List<>)(object)_furnitureItemToDisplayList)._size;
						int size5 = ((List<>)(object)_critterItemToDisplayList)._size;
						size4 += size5;
						size4 += size3;
						while (size4 >= MaxNotificationOnScreen)
						{
						}
						bool flag3 = default(bool);
						if (flag3)
						{
							FurnitureItemType furnitureItemType = default(FurnitureItemType);
							while (furnitureItemType == FurnitureItemType.Door)
							{
							}
						}
						Client client3 = default(Client);
						GridEditMode gridEditMode = default(GridEditMode);
						if (client3.profile.player_.HasHudApparition(32u) && gridEditMode.CanStartEditMode)
						{
							((List<T>)(object)_furnitureItemToDisplayList).Add((T)num2);
							int forceHudVisible2 = 0;
							if (!CanShowNotification((byte)forceHudVisible2 != 0))
							{
								_scheduleItemNotificationOnNextFocus = true;
							}
							ShowNotificationItem();
						}
						num3++;
					}
					if (num3 + 1 == 0)
					{
					}
				}
			}
		}
		if ((long)critterItemData == 0)
		{
			return;
		}
		Func<IItemData, bool> cpp2il__autoParamName__idx_5 = (Func<IItemData, bool>)(object)(Func<T, TResult>)delegate
		{
			//Discarded unreachable code: IL_0015
			CritterItemData critterItemData4 = critterItemData;
			return (IntPtr)typeof(IItemData).TypeHandle == (IntPtr)critterItemData4.befriendingPetRewardItemID_;
		};
		if (!((IEnumerable<>)notificationData2).Any<IItemData>((Func<, >)(object)cpp2il__autoParamName__idx_5))
		{
			Func<IItemData, bool> cpp2il__autoParamName__idx_6 = (Func<IItemData, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0015
				CritterItemData critterItemData3 = critterItemData;
				return (IntPtr)typeof(IItemData).TypeHandle == (IntPtr)critterItemData3.befriendingPetRewardItemID_;
			};
			List<IItemData> cpp2il__autoParamName__idx_7 = default(List<IItemData>);
			if (!((IEnumerable<>)cpp2il__autoParamName__idx_7).Any<IItemData>((Func<, >)(object)cpp2il__autoParamName__idx_6))
			{
				CritterItemData critterItemData2 = critterItemData;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xAF6820", Offset = "0xAF5220", VA = "0x180AF6820")]
	public void ShowQueuedCritterNotifs()
	{
		//Discarded unreachable code: IL_0027
		Item itemAdded = ((CritterNotif)((Queue<T>)(object)_critterQueue).Dequeue()).itemAdded;
		CritterItemData critterItemData = default(CritterItemData);
		ShowOwnedPets(critterItemData);
		Queue<CritterNotif> critterQueue = _critterQueue;
		UseCritterQueue = false;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xAF6490", Offset = "0xAF4E90", VA = "0x180AF6490")]
	private unsafe void ShowOwnedPets(CritterItemData critterItemData)
	{
		//Discarded unreachable code: IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6
		//IL_007d: Expected I4, but got I8
		bool flag = default(bool);
		Item item = default(Item);
		IItemData item2 = default(IItemData);
		ulong num2 = default(ulong);
		while (true)
		{
			int num = 0;
			List<Pet> list = (List<Pet>)(object)Enumerable.ToList<Pet>((IEnumerable<>)(object)SystemRoot.Instance.MetaClient.profile.player_.pets_);
			if (!flag)
			{
				break;
			}
			Item befriendingPetRewardItem = critterItemData.BefriendingPetRewardItem;
			if (!(*(Item*)item == *(Item*)befriendingPetRewardItem))
			{
				continue;
			}
			int size = ((List<>)(object)_clothingItemToDisplayList)._size;
			int size2 = ((List<>)(object)_furnitureItemToDisplayList)._size;
			List<IItemData> critterItemToDisplayList = _critterItemToDisplayList;
			size2 += size;
			if (size2 < MaxNotificationOnScreen)
			{
				((List<T>)(object)critterItemToDisplayList).Add((T)item2);
				if (!CanShowNotification((byte)num2 != 0))
				{
					_scheduleItemNotificationOnNextFocus = true;
				}
				ShowNotificationItem();
			}
			break;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xAF4570", Offset = "0xAF2F70", VA = "0x180AF4570")]
	private bool CanShowNotification(bool forceHudVisible = false)
	{
		HudMenu hudMenu = _hudMenu;
		if (!cutsceneSystem.playingCutscene)
		{
			return shouldDisplayNotif;
		}
		int num = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0xAF5CB0", Offset = "0xAF46B0", VA = "0x180AF5CB0")]
	private void RefreshDisplay(RectTransform container, List<IItemData> itemList)
	{
		//Discarded unreachable code: IL_00f3, IL_0100
		//IL_001a: Expected O, but got I8
		//IL_00b4: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		HudNewItem newItem = (HudNewItem)0;
		int childCount = _trashBin.childCount;
		newItem = UnityEngine.Object.Instantiate(_itemPrefab, container).GetComponent<HudNewItem>();
		newItem = _trashBin.gameObject.GetComponentInChildren<HudNewItem>();
		newItem.transform.parentInternal = container;
		int childCount2 = _containerFurniture.childCount;
		int childCount3 = _containerClothing.childCount;
		int childCount4 = _containerCritter.childCount;
		AK.Wwise.Event sfxNotif = _sfxNotif;
		if (sfxNotif != null)
		{
			GameObject audioEmitter = _audioEmitter;
			int num3 = 0;
			if (audioEmitter != (UnityEngine.Object)num3)
			{
			}
			GameObject gameObject = newItem.gameObject;
			uint num4 = sfxNotif.Post(gameObject);
		}
		HudNewItem hudNewItem = newItem;
		TweenCallback tweenCallback = delegate
		{
			//Discarded unreachable code: IL_0016
			HudGainItemNotif hudGainItemNotif = this;
			HudNewItem item = newItem;
			hudGainItemNotif.HideItem(item);
		};
		Dictionary<HudNewItem, Tween> dictionary = hideTweens;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xAF49E0", Offset = "0xAF33E0", VA = "0x180AF49E0")]
	private void HideItem(HudNewItem item)
	{
		//Discarded unreachable code: IL_004a
		//IL_003b: Expected F4, but got I4
		bool flag = ((Dictionary<TKey, TValue>)(object)hideTweens).Remove((TKey)item);
		if (_hudMenu.IsVisible && !cutsceneSystem.playingCutscene && shouldDisplayNotif)
		{
			int num = 0;
			Tween tween = item.AnimateOut(num);
		}
		else
		{
			((List<T>)(object)itemsToHideOnNextFocus).Add((T)item);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xAF5BD0", Offset = "0xAF45D0", VA = "0x180AF5BD0")]
	private void RebuildLayout()
	{
		//Discarded unreachable code: IL_0051
		LayoutRebuilder.ForceRebuildLayoutImmediate(_containerFurniture);
		LayoutRebuilder.ForceRebuildLayoutImmediate(_containerClothing);
		LayoutRebuilder.ForceRebuildLayoutImmediate(_containerCritter);
		LayoutRebuilder.ForceRebuildLayoutImmediate(_furnitureHolder);
		LayoutRebuilder.ForceRebuildLayoutImmediate(_clothingHolder);
		LayoutRebuilder.ForceRebuildLayoutImmediate(_critterHolder);
		if ((object)_clothingHolder.parent == null)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xAF6140", Offset = "0xAF4B40", VA = "0x180AF6140")]
	internal void ShowNotificationItem()
	{
		//Discarded unreachable code: IL_015b
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		GameObject gameObject = _furnitureHolder.gameObject;
		List<IItemData> furnitureItemToDisplayList = _furnitureItemToDisplayList;
		bool active = _containerFurniture.childCount > 0;
		gameObject.SetActive(active);
		GameObject gameObject2 = _clothingHolder.gameObject;
		List<IItemData> clothingItemToDisplayList = _clothingItemToDisplayList;
		bool active2 = _containerClothing.childCount > 0;
		gameObject2.SetActive(active2);
		GameObject gameObject3 = _critterHolder.gameObject;
		List<IItemData> critterItemToDisplayList = _critterItemToDisplayList;
		bool active3 = _containerCritter.childCount > 0;
		gameObject3.SetActive(active3);
		List<IItemData> furnitureItemToDisplayList2 = _furnitureItemToDisplayList;
		List<IItemData> clothingItemToDisplayList2 = _clothingItemToDisplayList;
		List<IItemData> critterItemToDisplayList2 = _critterItemToDisplayList;
		int childCount = _containerFurniture.childCount;
		int childCount2 = _containerClothing.childCount;
		RectTransform containerCritter = _containerCritter;
		int childCount3 = containerCritter.childCount;
		containerCritter = (RectTransform)(containerCritter + childCount);
		if ((long)(IntPtr)containerCritter < (long)MaxNotificationOnScreen)
		{
			ShortcutIndicator componentInChildren = _furnitureHolder.gameObject.GetComponentInChildren<ShortcutIndicator>();
			bool flag = (componentInChildren.enabled = SystemRoot.Instance.GetSystem<GridEditMode>().CanStartEditMode);
			List<IItemData> furnitureItemToDisplayList3 = _furnitureItemToDisplayList;
			RectTransform containerFurniture = _containerFurniture;
			this.RefreshDisplay(containerFurniture, (List<>)(object)furnitureItemToDisplayList3);
			List<IItemData> clothingItemToDisplayList3 = _clothingItemToDisplayList;
			RectTransform containerClothing = _containerClothing;
			this.RefreshDisplay(containerClothing, (List<>)(object)clothingItemToDisplayList3);
			List<IItemData> critterItemToDisplayList3 = _critterItemToDisplayList;
			RectTransform containerCritter2 = _containerCritter;
			this.RefreshDisplay(containerCritter2, (List<>)(object)critterItemToDisplayList3);
			RebuildLayout();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xAF6070", Offset = "0xAF4A70", VA = "0x180AF6070")]
	public void RemoveNotificationItem(HudNewItem itemToRemove)
	{
		//Discarded unreachable code: IL_0027
		Transform transform = itemToRemove.gameObject.transform;
		Transform transform2 = (transform.parentInternal = _trashBin);
		ShowNotificationItem();
		RebuildLayout();
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xAF45D0", Offset = "0xAF2FD0", VA = "0x180AF45D0")]
	public void ClearHudItemNotif()
	{
		//Discarded unreachable code: IL_00fe
		RectTransform containerClothing = _containerClothing;
		int num = 0;
		int childCount = containerClothing.childCount;
		if (num < childCount)
		{
			UnityEngine.Object.Destroy(_containerClothing.GetChild(num).gameObject);
			RectTransform containerClothing2 = _containerClothing;
			num++;
		}
		int childCount2 = _containerFurniture.childCount;
		if (num < childCount2)
		{
			UnityEngine.Object.Destroy(_containerFurniture.GetChild(num).gameObject);
			RectTransform containerFurniture = _containerFurniture;
			num++;
			while ((object)containerFurniture != null)
			{
			}
		}
		int childCount3 = _containerCritter.childCount;
		if (num < childCount3)
		{
			UnityEngine.Object.Destroy(_containerCritter.GetChild(num).gameObject);
			RectTransform containerCritter = _containerCritter;
			num++;
			while ((object)containerCritter != null)
			{
			}
		}
		GameObject gameObject = _furnitureHolder.gameObject;
		int active = 0;
		gameObject.SetActive((byte)active != 0);
		GameObject gameObject2 = _clothingHolder.gameObject;
		int active2 = 0;
		gameObject2.SetActive((byte)active2 != 0);
		GameObject gameObject3 = _critterHolder.gameObject;
		int active3 = 0;
		gameObject3.SetActive((byte)active3 != 0);
		((List<T>)(object)itemsToHideOnNextFocus).Clear();
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0xAF4880", Offset = "0xAF3280", VA = "0x180AF4880")]
	public List<IItemData> GetNotificationData(RectTransform container)
	{
		//Discarded unreachable code: IL_004f
		//IL_002b: Expected O, but got I4
		List<IItemData> list = (List<IItemData>)(object)new List<T>();
		int num = 0;
		int childCount = container.childCount;
		if (num < childCount)
		{
			HudNewItem component = container.GetChild(num).GetComponent<HudNewItem>();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2)
			{
				IItemData data = container.GetChild(num).GetComponent<HudNewItem>()._data;
				((List<T>)(object)list).Add((T)data);
			}
			num++;
		}
		return list;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xAF4870", Offset = "0xAF3270", VA = "0x180AF4870")]
	public List<IItemData> GetFurnitureNotificationData()
	{
		RectTransform containerFurniture = _containerFurniture;
		return (List<IItemData>)(object)this.GetNotificationData(containerFurniture);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xAF4850", Offset = "0xAF3250", VA = "0x180AF4850")]
	public List<IItemData> GetClothingNotificationData()
	{
		RectTransform containerClothing = _containerClothing;
		return (List<IItemData>)(object)this.GetNotificationData(containerClothing);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0xAF4860", Offset = "0xAF3260", VA = "0x180AF4860")]
	public List<IItemData> GetCritterNotificationData()
	{
		RectTransform containerCritter = _containerCritter;
		return (List<IItemData>)(object)this.GetNotificationData(containerCritter);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xAF6C00", Offset = "0xAF5600", VA = "0x180AF6C00")]
	public HudGainItemNotif()
	{
	}//IL_0009: Expected I4, but got I8

}
