using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Shops;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Grid;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004E6")]
	public class ItemInfoPopUp : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20004E7")]
		public class ItemInfoPopupParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001A0F")]
			public IItemData ItemData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001A10")]
			public ItemState ItemState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A11")]
			public bool IsRedirectedFromCatalog;

			[Cpp2IlInjected.Token(Token = "0x6002007")]
			[Cpp2IlInjected.Address(RVA = "0xAFCFD0", Offset = "0xAFB9D0", VA = "0x180AFCFD0")]
			public ItemInfoPopupParam(IItemData itemData, ItemState itemState, bool isRedirectedFromCatalog)
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
				ItemData = itemData;
				ItemState = itemState;
				IsRedirectedFromCatalog = isRedirectedFromCatalog;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40019F5")]
		private int _ownedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40019F6")]
		private IItemData _itemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40019F7")]
		private ItemState _itemState;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40019F8")]
		private bool _isRedirectedFromCatalog;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
		[Cpp2IlInjected.Token(Token = "0x40019F9")]
		private bool _isFavorite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40019FA")]
		private int _colorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40019FB")]
		[SerializeField]
		private TextBase _tfItemSetName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40019FC")]
		[SerializeField]
		private TextBase _tfItemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40019FD")]
		[SerializeField]
		private StarComponent _mcStars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40019FE")]
		[SerializeField]
		private AsyncAtlassedIcon _mcCurrencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40019FF")]
		[SerializeField]
		private TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001A00")]
		[SerializeField]
		private ListBase _listTraits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001A01")]
		[SerializeField]
		private TextBase _tfDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001A02")]
		[SerializeField]
		private Button _btnFavorite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001A03")]
		[SerializeField]
		private GameObject _mcIconFavorite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001A04")]
		[SerializeField]
		private TextBase _tfInventoryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001A05")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001A06")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001A07")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001A08")]
		[SerializeField]
		private WardrobeColorComponent _mcColorComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001A09")]
		[SerializeField]
		private GameObject _mcItemImageHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001A0A")]
		[SerializeField]
		private GameObject _requiredForQuestHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001A0B")]
		[SerializeField]
		private ListBase _requiredForQuestList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001A0C")]
		private List<UiTrait> _TraitUIList = (List<UiTrait>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001A0D")]
		private bool _isBuyable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001A0E")]
		private List<ProfileWorld.FilterInfo> _questList;

		[Cpp2IlInjected.Token(Token = "0x6001FF9")]
		[Cpp2IlInjected.Address(RVA = "0xD36970", Offset = "0xD35370", VA = "0x180D36970", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0094
			base.OnPush(stack, param);
			if (param != null)
			{
				int isRedirectedFromCatalog = 0;
				if (param != null)
				{
					_itemData = (IItemData)typeof(ItemInfoPopupParam).TypeHandle;
					_itemState = (ItemState)typeof(ItemInfoPopupParam).TypeHandle;
					_isRedirectedFromCatalog = (byte)isRedirectedFromCatalog != 0;
				}
			}
			RectTransform mcContent = _mcContent;
			float z = Vector3.zero.z;
			_mcContent.gameObject.SetActive(value: true);
			_mcBlocker.gameObject.SetActive(value: true);
			RectTransform mcContent2 = _mcContent;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			Image mcBlocker = _mcBlocker;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFA")]
		[Cpp2IlInjected.Address(RVA = "0xD36910", Offset = "0xD35310", VA = "0x180D36910", Slot = "26")]
		public override void OnPop()
		{
			TweenMax.KillAllByCancelationToken(this);
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFB")]
		[Cpp2IlInjected.Address(RVA = "0xD35EF0", Offset = "0xD348F0", VA = "0x180D35EF0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_020e
			//IL_00bc: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			//IL_0145: Expected O, but got I4
			//IL_0190: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			base.OnFocusIn();
			if ((long)_itemData == 0)
			{
				return;
			}
			Client metaClient = SystemRoot.Instance.MetaClient;
			Profile profile = metaClient.profile;
			if (metaClient != null)
			{
				bool isBuyable = default(bool);
				_isBuyable = isBuyable;
			}
			IItemData itemData = _itemData;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Clothing)
			{
				IItemData itemData2 = _itemData;
				if (itemData2 == null || itemData2 == null)
				{
					goto IL_01a0;
				}
				IEnumerable<Item> enumerable = default(IEnumerable<Item>);
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)enumerable);
				Predicate<Item> predicate = default(Predicate<Item>);
				if (_003C_003Ec._003C_003E9__29_0 == null)
				{
					TagItemType tagItemType2 = default(TagItemType);
					predicate = (Predicate<Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((Item x) => tagItemType2 == TagItemType.DominantColor));
				}
				bool flag = default(bool);
				if (((List<T>)(object)list).Exists((Predicate<>)(object)predicate) && flag)
				{
					List<ClothingItemData> list2 = (List<ClothingItemData>)(object)new List<T>();
					List<Color> list3 = (List<Color>)(object)new List<T>();
					string arg = default(string);
					int num3 = default(int);
					string text = $"{arg}{num3}";
					ClothingItemData clothingItemData = default(ClothingItemData);
					uint selectedIndex = default(uint);
					if (clothingItemData != null)
					{
						List<Item> list4 = (List<Item>)(object)Enumerable.ToList<Item>(ItemDataExtensions.GetItemTags((IHasTags)clothingItemData));
						Predicate<Item> predicate2 = default(Predicate<Item>);
						if (_003C_003Ec._003C_003E9__29_1 == null)
						{
							TagItemType tagItemType = default(TagItemType);
							predicate2 = (Predicate<Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((Item x) => tagItemType == TagItemType.DominantColor));
						}
						Item item = (Item)((List<T>)(object)list4).Find((Predicate<>)(object)predicate2);
						bool flag2 = default(bool);
						uint num6 = default(uint);
						if (flag2)
						{
							ITagData tagData = ItemDatabase.Instance.GetTagData(item);
							int num4 = default(int);
							int num5 = default(int);
							if (num4 == num5)
							{
								selectedIndex = num6 - 1;
							}
							((List<T>)(object)list3).Add((T)num);
							((List<T>)(object)list2).Add((T)clothingItemData);
						}
						num6++;
						int num7 = default(int);
						string text2 = $"{arg}{num7}";
					}
					_mcColorComponent.ColorList = list3;
					_mcColorComponent.Items = list2;
					_mcColorComponent.Init();
					((ColorComponent)_mcColorComponent).list_color.SelectedIndex = (int)selectedIndex;
					ulong num8 = default(ulong);
					_mcColorComponent.gameObject.SetActive((byte)num8 != 0);
				}
			}
			IItemData itemData3 = _itemData;
			RefreshData(itemData3);
			goto IL_01a0;
			IL_01a0:
			IItemData itemData4 = _itemData;
			ProfileWorld world_ = profile.world_;
			IEnumerable<ProfileWorld.FilterInfo> enumerable2 = default(IEnumerable<ProfileWorld.FilterInfo>);
			uint num9 = default(uint);
			List<ProfileWorld.FilterInfo> list5 = (_questList = (List<ProfileWorld.FilterInfo>)(object)Enumerable.ToList<ProfileWorld.FilterInfo>(Enumerable.Take<ProfileWorld.FilterInfo>((IEnumerable<>)enumerable2, (int)num9)));
			List<ProfileWorld.FilterInfo> questList = _questList;
			GameObject requiredForQuestHolder = _requiredForQuestHolder;
			bool active = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)questList);
			requiredForQuestHolder.SetActive(active);
			List<ProfileWorld.FilterInfo> questList2 = _questList;
			ListBase requiredForQuestList = _requiredForQuestList;
			int num10 = (requiredForQuestList.TotalCount = ((List<>)(object)questList2)._size);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFC")]
		[Cpp2IlInjected.Address(RVA = "0xD36B90", Offset = "0xD35590", VA = "0x180D36B90")]
		public void OnQuestItemData(ListBase.ListEventData data)
		{
			//Discarded unreachable code: IL_0028
			QuestFilterItem component = data.DisplayObject.GetComponent<QuestFilterItem>();
			int itemIndex = data.ItemIndex;
			ProfileWorld.FilterInfo filterInfo = Enumerable.ElementAt<ProfileWorld.FilterInfo>((IEnumerable<>)_questList, itemIndex);
			component.Init(filterInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFD")]
		[Cpp2IlInjected.Address(RVA = "0xD37570", Offset = "0xD35F70", VA = "0x180D37570", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0094
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseBtnClicked;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnFavorite.m_OnClick;
			UnityAction call2 = OnFavoriteBtnClicked;
			onClick2.AddListener(call2);
			ListBase.ListEvents onItemData = _listTraits.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnTraitItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemSelect = ((ColorComponent)_mcColorComponent).list_color.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnColorItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFE")]
		[Cpp2IlInjected.Address(RVA = "0xD379C0", Offset = "0xD363C0", VA = "0x180D379C0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0094
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseBtnClicked;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnFavorite.m_OnClick;
			UnityAction call2 = OnFavoriteBtnClicked;
			onClick2.RemoveListener(call2);
			ListBase.ListEvents onItemData = _listTraits.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnTraitItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemSelect = ((ColorComponent)_mcColorComponent).list_color.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnColorItemSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFF")]
		[Cpp2IlInjected.Address(RVA = "0xD35E20", Offset = "0xD34820", VA = "0x180D35E20")]
		private void OnColorItemSelectHandler(ListBase.ListEventData args)
		{
			//Discarded unreachable code: IL_0027
			ClothingItemData clothingItemData = (ClothingItemData)(_itemData = args.DisplayObject.GetComponent<WardrobeColorPickerItem>()._clothingItemData);
			IItemData itemData = _itemData;
			RefreshData(itemData);
		}

		[Cpp2IlInjected.Token(Token = "0x6002000")]
		[Cpp2IlInjected.Address(RVA = "0xD36C30", Offset = "0xD35630", VA = "0x180D36C30")]
		private void OnTraitItemDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002001")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnCloseBtnClicked()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002002")]
		[Cpp2IlInjected.Address(RVA = "0xD35EB0", Offset = "0xD348B0", VA = "0x180D35EB0")]
		private void OnFavoriteBtnClicked()
		{
			//Discarded unreachable code: IL_0020
			GameObject mcIconFavorite = _mcIconFavorite;
			mcIconFavorite.SetActive(_isFavorite = !_isFavorite);
		}

		[Cpp2IlInjected.Token(Token = "0x6002003")]
		[Cpp2IlInjected.Address(RVA = "0xD36DF0", Offset = "0xD357F0", VA = "0x180D36DF0")]
		private unsafe void RefreshData(IItemData itemData)
		{
			//Discarded unreachable code: IL_0126
			//IL_0043: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			int num;
			bool flag = default(bool);
			do
			{
				num = 0;
				if ((_isRedirectedFromCatalog ? 1 : 0) == num)
				{
					ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
				}
				ListInventory fakeCatalog = SystemRoot.Instance.GetSystem<GridEditMode>().fakeCatalog;
				if (!flag)
				{
				}
				_ownedCount = num;
				if (!ItemPriceDatabases.TryGetPrices((Item)num, out *(List<CurrencyCost>*)num))
				{
					_tfPrice.Text = " - ";
				}
			}
			while (Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)num) == null);
			string text = default(string);
			_tfPrice.Text = text;
			if (!_mcCurrencyIcon.SetIcon(text))
			{
				GameObject gameObject = _tfItemSetName.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			TextBase tfItemSetName = _tfItemSetName;
			SetItemData setItemData = default(SetItemData);
			if (setItemData != null)
			{
			}
			string text2 = (tfItemSetName.StringID = setItemData.displayName_);
			TextBase tfItemName = _tfItemName;
			if (setItemData != null)
			{
			}
			tfItemName.StringID = "*NoDisplayName";
			string text3 = default(string);
			_tfInventoryCount.Text = text3;
			GameObject mcIconFavorite = _mcIconFavorite;
			bool isFavorite = _isFavorite;
			mcIconFavorite.SetActive(isFavorite);
			if (text3 != null)
			{
				StarComponent mcStars = _mcStars;
			}
			if (text3 != null)
			{
			}
			AsyncImage component = _mcItemImageHolder.GetComponent<AsyncImage>();
			int num2 = 0;
			component.SetSpriteKey((string)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002004")]
		[Cpp2IlInjected.Address(RVA = "0xD37770", Offset = "0xD36170", VA = "0x180D37770")]
		private void SetTraits(IHasTraits itemData)
		{
			//Discarded unreachable code: IL_00cc
			//IL_0021: Expected I4, but got I8
			//IL_0028: Expected I4, but got O
			//IL_0045: Expected I4, but got I8
			//IL_004c: Expected I4, but got O
			//IL_006c: Expected I4, but got I8
			//IL_0075: Expected I4, but got O
			//IL_0097: Expected I4, but got I8
			//IL_00a0: Expected I4, but got O
			((List<T>)(object)_TraitUIList).Clear();
			List<UiTrait> traitUIList = _TraitUIList;
			UiTrait uiTrait = new UiTrait();
			uiTrait.type = UiTrait.Trait.Complexity;
			uiTrait.SubIndex = (int)uiTrait;
			((List<T>)(object)traitUIList).Add((T)uiTrait);
			List<UiTrait> traitUIList2 = _TraitUIList;
			UiTrait uiTrait2 = new UiTrait();
			uiTrait2.type = UiTrait.Trait.Mood;
			uiTrait2.SubIndex = (int)uiTrait2;
			((List<T>)(object)traitUIList2).Add((T)uiTrait2);
			List<UiTrait> traitUIList3 = _TraitUIList;
			UiTrait uiTrait3 = new UiTrait();
			uiTrait3.type = UiTrait.Trait.Normality;
			uiTrait3.SubIndex = (int)uiTrait3;
			((List<T>)(object)traitUIList3).Add((T)uiTrait3);
			List<UiTrait> traitUIList4 = _TraitUIList;
			UiTrait uiTrait4 = new UiTrait();
			uiTrait4.type = UiTrait.Trait.Sturdiness;
			uiTrait4.SubIndex = (int)uiTrait4;
			((List<T>)(object)traitUIList4).Add((T)uiTrait4);
			List<UiTrait> traitUIList5 = _TraitUIList;
			ListBase listTraits = _listTraits;
			int num = (listTraits.TotalCount = ((List<>)(object)traitUIList5)._size);
		}

		[Cpp2IlInjected.Token(Token = "0x6002005")]
		[Cpp2IlInjected.Address(RVA = "0xD35DD0", Offset = "0xD347D0", VA = "0x180D35DD0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0018
			_btnClose.m_OnClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002006")]
		[Cpp2IlInjected.Address(RVA = "0xD37BC0", Offset = "0xD365C0", VA = "0x180D37BC0")]
		public ItemInfoPopUp()
		{
		}
	}
}
