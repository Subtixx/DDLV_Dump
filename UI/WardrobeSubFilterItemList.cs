using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using glPlayFab.Disney;
using Mdl.Avatar;
using Mdl.Online;
using Mdl.Ui;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x2000063")]
public class WardrobeSubFilterItemList : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[SerializeField]
	public GameObject Header;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[SerializeField]
	private TextBase _headerText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[SerializeField]
	private WardrobeMakeupItem _itemPrefab;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	[SerializeField]
	private InventoryItem _itemPrefabFacialHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	[SerializeField]
	private GridLayoutGroup _gridLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[SerializeField]
	private RectTransform _itemContainer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private AvatarAppearance _avatar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private MakeupColor _makeupColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private DynamicFilterItemData _data;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public MakeupItemType MakeupType;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public RectTransform ItemContainer
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
		get
		{
			return _itemContainer;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public GridLayoutGroup GridLayout
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
		get
		{
			return _gridLayout;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public Mdl.Avatar.AvatarCustomization AvatarCustomization
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
		[CompilerGenerated]
		get
		{
			return _003CAvatarCustomization_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
		[CompilerGenerated]
		internal set
		{
			_003CAvatarCustomization_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public CancellationToken CancellationToken
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
		[CompilerGenerated]
		get
		{
			return _003CCancellationToken_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8E8E60", Offset = "0x8E7860", VA = "0x1808E8E60")]
		[CompilerGenerated]
		internal set
		{
			_003CCancellationToken_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DynamicFilterItemData Data
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8E8E30", Offset = "0x8E7830", VA = "0x1808E8E30")]
		get
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8E8E70", Offset = "0x8E7870", VA = "0x1808E8E70")]
		private set
		{
			string text = (string)(_data = (DynamicFilterItemData)value.Name);
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8E8900", Offset = "0x8E7300", VA = "0x1808E8900")]
	public void SetData(DynamicFilterItemData data, List<MakeupItemData> dataList, List<MakeupItemData> ownedItems, AvatarAppearance avatar, Mdl.Avatar.AvatarCustomization avatarCustomization)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x8E84A0", Offset = "0x8E6EA0", VA = "0x1808E84A0")]
	public void SetData(ClothingItemData[] itemList, AvatarAppearance avatar, Mdl.Avatar.AvatarCustomization avatarCustomization, string displayName = "")
	{
		//Discarded unreachable code: IL_0175
		//IL_0082: Expected O, but got I4
		int num = 0;
		bool flag = default(bool);
		if (flag)
		{
			TextBase headerText = _headerText;
		}
		_avatar = avatar;
		AvatarCustomization = avatarCustomization;
		int num2 = Enumerable.Count<ClothingItemData>((IEnumerable<>)(object)itemList);
		GridLayoutGroup gridLayout = _gridLayout;
		if (num2 > 0)
		{
			InventoryItem itemPrefabFacialHair = _itemPrefabFacialHair;
			RectTransform itemContainer = _itemContainer;
			ClothingItemData itemData = itemList[num];
			InventoryItem item = UnityEngine.Object.Instantiate(itemPrefabFacialHair, itemContainer);
			InventoryItem inventoryItem = item;
			int num3 = 0;
			if (inventoryItem != (UnityEngine.Object)num3)
			{
				item.ItemData = itemData;
				IHasUnlockConditions unlockConditions = item.ItemData.GetUnlockConditions();
				item.IsBuyable = false;
				item.IsOwned = false;
				GameObject gameObject = item.AmountAsset.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Client client = default(Client);
				ListInventory wardrobe = client.Profile.Wardrobe;
				IItemData itemData2 = item.ItemData;
				AvatarAppearance avatar2 = _avatar;
				InventoryItem inventoryItem2 = item;
				bool flag2 = (inventoryItem2.IsMale = avatar2.IsMale);
				item.RefreshDisplay();
				item.HideLocked();
				RefreshSelectedClothes();
				Button.ButtonClickedEvent onClick = item.GetComponent<Button>().m_OnClick;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_0016
					WardrobeSubFilterItemList wardrobeSubFilterItemList = this;
					InventoryItem item2 = item;
					wardrobeSubFilterItemList.OnItemTapHandler(item2);
				};
				onClick.AddListener(call);
			}
			num++;
		}
		RefreshSelectedClothes();
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8E7C10", Offset = "0x8E6610", VA = "0x1808E7C10")]
	private void RefreshSelectedClothes()
	{
		//Discarded unreachable code: IL_0051, IL_0057, IL_005d, IL_0063, IL_006f
		uint num2 = default(uint);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 0;
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			IEnumerator enumerator = _itemContainer.GetEnumerator();
			if (enumerator != null)
			{
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (enumerator == null)
				{
				}
				int num3 = 0;
				if (enumerator == null)
				{
					break;
				}
				while (!flag)
				{
				}
				AvatarAppearance avatar = _avatar;
				flag = flag2;
			}
			if (flag2)
			{
			}
			if (num == 0)
			{
				return;
			}
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8E7530", Offset = "0x8E5F30", VA = "0x1808E7530")]
	private void OnItemTapHandler(InventoryItem item)
	{
		//Discarded unreachable code: IL_003b
		//IL_000f: Expected O, but got I4
		Debug.Log(item);
		int num = 0;
		if (item != (UnityEngine.Object)num)
		{
			IItemData itemData = item.ItemData;
			bool flag = default(bool);
			if (flag)
			{
				Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
				IItemData itemData2 = item.ItemData;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				RefreshSelectedClothes();
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8E7700", Offset = "0x8E6100", VA = "0x1808E7700")]
	public void OnItemTapHandler(WardrobeMakeupItem item)
	{
		//Discarded unreachable code: IL_0036
		//IL_000f: Expected O, but got I4
		Debug.Log(item);
		int num = 0;
		if (item != (UnityEngine.Object)num)
		{
			int iD = item.ItemData.ID;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			RefreshSelected();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8E8390", Offset = "0x8E6D90", VA = "0x1808E8390")]
	[AsyncStateMachine(typeof(_003CSelectMakeupAsync_003Ed__30))]
	private Task SelectMakeupAsync(MakeupItem makeupItem)
	{
		int makeupItemID = makeupItem.MakeupItemID;
		int num = 0;
		Task result = default(Task);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8E8030", Offset = "0x8E6A30", VA = "0x1808E8030")]
	public void RefreshSelected()
	{
		//Discarded unreachable code: IL_005e, IL_0064, IL_006a, IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_0094
		uint num2 = default(uint);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 0;
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			IEnumerator enumerator = _itemContainer.GetEnumerator();
			if (enumerator != null)
			{
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (enumerator == null)
				{
				}
				int num3 = 0;
				if (enumerator == null)
				{
					break;
				}
				if (flag)
				{
					AvatarAppearance avatar = _avatar;
				}
				while (!flag2)
				{
				}
				AvatarAppearance avatar2 = _avatar;
				flag2 = flag3;
			}
			if (flag3)
			{
			}
			if (num == 0)
			{
				return;
			}
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x8E7950", Offset = "0x8E6350", VA = "0x1808E7950")]
	private void OnPurchaseHandler(WardrobeMakeupItem item)
	{
		int num = 0;
		Task asyncTask = default(Task);
		asyncTask.FireAndForgetTask();
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8E7AD0", Offset = "0x8E64D0", VA = "0x1808E7AD0")]
	[AsyncStateMachine(typeof(_003CPurchaseTask_003Ed__33))]
	private Task PurchaseTask(WardrobeMakeupItem item, CancellationToken ct)
	{
		int num = 0;
		Task result = default(Task);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x8E7030", Offset = "0x8E5A30", VA = "0x1808E7030")]
	private void NotifyMakeupColor(MakeupItem item)
	{
		//Discarded unreachable code: IL_0181
		//IL_002f: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		bool flag = default(bool);
		if (flag)
		{
			MakeupColor makeupColor = (_makeupColor = GetComponentInChildren<MakeupColor>());
		}
		int num = 0;
		StartFTUEMenu menu = UiRoot.Instance._menuStack.GetMenu<StartFTUEMenu>();
		int num2 = 0;
		bool flag2 = menu != (UnityEngine.Object)num2;
		int num3 = 0;
		if (flag2)
		{
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			MakeupItemType makeupItemType = default(MakeupItemType);
			int num4 = (int)makeupItemType;
			WardrobeAppearanceContent appearanceContent = menu.GetAppearanceContent();
			WardrobeAppearanceContent appearanceContent2 = menu.GetAppearanceContent();
			int num5 = default(int);
			if (num5 != -1)
			{
				Mdl.Avatar.AvatarCustomization avatarCustomization2 = AvatarCustomization;
			}
			WardrobeAppearanceContent appearanceContent3 = menu.GetAppearanceContent();
			int num6 = default(int);
			num4 = num6;
			if (num6 != -1)
			{
				Mdl.Avatar.AvatarCustomization avatarCustomization3 = AvatarCustomization;
			}
			Mdl.Avatar.AvatarCustomization avatarCustomization4 = AvatarCustomization;
			WardrobeAppearanceContent appearanceContent4 = menu.GetAppearanceContent();
			if ((object)avatarCustomization4 != null)
			{
				AvatarAppearance _003CAvatar_003Ek__BackingField = menu.GetAppearanceContent().Avatar;
				bool flag3 = num5 != -1;
				if ((object)avatarCustomization4 != null)
				{
					AvatarAppearance _003CAvatar_003Ek__BackingField2 = menu.GetAppearanceContent().Avatar;
					bool flag4 = num4 != -1;
				}
			}
		}
		int num7 = 0;
		WardrobeMenu menu2 = UiRoot.Instance._menuStack.GetMenu<WardrobeMenu>();
		int num8 = 0;
		if (!(menu2 != (UnityEngine.Object)num8))
		{
			return;
		}
		Mdl.Avatar.AvatarCustomization avatarCustomization5 = AvatarCustomization;
		MakeupItemType makeupItemType2 = default(MakeupItemType);
		int num9 = (int)makeupItemType2;
		WardrobeAppearanceContent mcAppearanceContent = menu2._mcAppearanceContent;
		WardrobeAppearanceContent mcAppearanceContent2 = menu2._mcAppearanceContent;
		int num10 = default(int);
		num9 = num10;
		if (num10 != -1)
		{
			Mdl.Avatar.AvatarCustomization avatarCustomization6 = AvatarCustomization;
		}
		WardrobeAppearanceContent mcAppearanceContent3 = menu2._mcAppearanceContent;
		int num11 = default(int);
		if (num11 != -1)
		{
			Mdl.Avatar.AvatarCustomization avatarCustomization7 = AvatarCustomization;
		}
		Mdl.Avatar.AvatarCustomization avatarCustomization8 = AvatarCustomization;
		WardrobeAppearanceContent mcAppearanceContent4 = menu2._mcAppearanceContent;
		float num12 = default(float);
		float num13 = num12;
		if ((object)avatarCustomization8 != null)
		{
			AvatarAppearance _003CAvatar_003Ek__BackingField3 = menu2._mcAppearanceContent.Avatar;
			bool flag5 = num9 != -1;
			if ((object)avatarCustomization8 != null)
			{
				AvatarAppearance _003CAvatar_003Ek__BackingField4 = menu2._mcAppearanceContent.Avatar;
				bool flag6 = num11 != -1;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8E7EB0", Offset = "0x8E68B0", VA = "0x1808E7EB0")]
	private void RefreshSelectedInventoryItem(Transform child)
	{
		//Discarded unreachable code: IL_000e
		bool flag = default(bool);
		if (flag)
		{
			AvatarAppearance avatar = _avatar;
			bool flag2 = default(bool);
			flag = flag2;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8E7F70", Offset = "0x8E6970", VA = "0x1808E7F70")]
	private void RefreshSelectedWardrobeItem(Transform child)
	{
		//Discarded unreachable code: IL_0014
		bool flag = default(bool);
		if (flag)
		{
			int price = ((BattlePassReward)(object)child).Price;
			AvatarAppearance avatar = _avatar;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public WardrobeSubFilterItemList()
	{
	}
}
