using System.Collections.Generic;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HudCraftingNotif : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[SerializeField]
	private int MaxNotificationOnScreen = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[SerializeField]
	private RectTransform _container;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[SerializeField]
	private HudCraftingNewRecipeItem _recipeItemPrefab;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[SerializeField]
	private Transform _trashBin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[SerializeField]
	private AK.Wwise.Event _sfxNotif;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[SerializeField]
	private GameObject _audioEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private List<CraftingRecipeItemData> _itemToDisplayList = (List<CraftingRecipeItemData>)(object)new List<T>();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF2DC0", VA = "0x180AF43C0")]
	private void Start()
	{
		//Discarded unreachable code: IL_0025
		ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
		ProfileEventDispatcher.CollectionSetUpdated value = OnCollectionSetUpdated;
		_003CDispatcher_003Ek__BackingField.OnCollectionSetUpdated += value;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xAF3CB0", Offset = "0xAF26B0", VA = "0x180AF3CB0")]
	private void OnCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromCooking)
	{
		//Discarded unreachable code: IL_005d, IL_0063, IL_0069, IL_006f, IL_0075, IL_007b, IL_0081
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Profile profile = SystemRoot.Instance.MetaClient.profile;
		Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
		List<CraftingRecipeItemData> availableCraftingRecipes = (List<CraftingRecipeItemData>)(object)profile.GetAvailableCraftingRecipes((ITransactionContext)_003CTransactionContext_003Ek__BackingField);
		bool flag = default(bool);
		bool flag2 = default(bool);
		if (flag && flag2)
		{
			Item item = default(Item);
			while ((object)item == null)
			{
			}
			Client client = default(Client);
			Profile profile2 = client.profile;
			bool flag3 = default(bool);
			while (flag3)
			{
			}
			List<CraftingRecipeItemData> itemToDisplayList = _itemToDisplayList;
			ShowNotificationItem();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0xAF4130", Offset = "0xAF2B30", VA = "0x180AF4130")]
	private void ShowNotificationItem()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0xAF40D0", Offset = "0xAF2AD0", VA = "0x180AF40D0")]
	public void RemoveNotificationItem(HudCraftingNewRecipeItem itemToRemove)
	{
		//Discarded unreachable code: IL_0021
		Transform transform = itemToRemove.gameObject.transform;
		Transform transform2 = (transform.parentInternal = _trashBin);
		ShowNotificationItem();
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xAF44F0", Offset = "0xAF2EF0", VA = "0x180AF44F0")]
	public HudCraftingNotif()
	{
	}//IL_0009: Expected I4, but got I8

}
