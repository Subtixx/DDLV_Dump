using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007A7")]
	public class GardeningStallShelvesContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002CF9")]
		[SerializeField]
		private ListBase _listShelves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002CFA")]
		private List<GameObject> _targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002CFB")]
		private Shop _shop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002CFC")]
		private ShopData _shopData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002CFD")]
		private int _currentIndex;

		[Cpp2IlInjected.Token(Token = "0x170006E0")]
		public ListBase ListShelves
		{
			[Cpp2IlInjected.Token(Token = "0x60030F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _listShelves;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002CF8")]
		public bool IsInit
		{
			[Cpp2IlInjected.Token(Token = "0x60030F6")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60030F7")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x60030F8")]
		[Cpp2IlInjected.Address(RVA = "0xE4E1E0", Offset = "0xE4CBE0", VA = "0x180E4E1E0")]
		public void Init(List<GameObject> targets, Shop shop, GridObject gridObject)
		{
			//Discarded unreachable code: IL_009d
			//IL_0057: Expected I4, but got I8
			_targets = targets;
			_shop = shop;
			if (gridObject != null)
			{
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					StallData stallData = state_.StallData;
					if (stallData != null && stallData.shopData_ != null)
					{
						goto IL_0038;
					}
				}
			}
			ShopData data_ = shop.data_;
			goto IL_0038;
			IL_0038:
			_shopData = data_;
			ShopData shopData = _shopData;
			ListBase listShelves = _listShelves;
			_currentIndex = 0;
			int num = (listShelves.TotalCount = ((RepeatedField<T>)(object)shopData.slots_).Count);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ShopItemsRefreshed value = OnShopItemsRefreshed;
			_003CDispatcher_003Ek__BackingField.OnShopItemsRefreshed += value;
			IsInit = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60030F9")]
		[Cpp2IlInjected.Address(RVA = "0xE4E120", Offset = "0xE4CB20", VA = "0x180E4E120")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0021
			ListBase.ListEvents onItemData = _listShelves.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnShelvesListDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60030FA")]
		[Cpp2IlInjected.Address(RVA = "0xE4E3D0", Offset = "0xE4CDD0", VA = "0x180E4E3D0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0069
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.ShopItemsRefreshed value = OnShopItemsRefreshed;
					_003CDispatcher_003Ek__BackingField.OnShopItemsRefreshed -= value;
				}
			}
			ListBase.ListEvents onItemData = _listShelves.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnShelvesListDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60030FB")]
		[Cpp2IlInjected.Address(RVA = "0xE4EAD0", Offset = "0xE4D4D0", VA = "0x180E4EAD0")]
		private void OnShopItemsRefreshed(string shopName, Item item, CurrencyCost refreshCost, bool isFreeRefresh)
		{
			//Discarded unreachable code: IL_0032
			//IL_001e: Expected I4, but got I8
			Shop shop = _shop;
			ShopData shopData = _shopData;
			ListBase listShelves = _listShelves;
			_currentIndex = 0;
			int num = (listShelves.TotalCount = ((RepeatedField<T>)(object)shopData.slots_).Count);
		}

		[Cpp2IlInjected.Token(Token = "0x60030FC")]
		[Cpp2IlInjected.Address(RVA = "0xE4E620", Offset = "0xE4D020", VA = "0x180E4E620")]
		private void OnShelvesListDataHandler(ListBase.ListEventData arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60030FD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GardeningStallShelvesContent()
		{
		}
	}
}
