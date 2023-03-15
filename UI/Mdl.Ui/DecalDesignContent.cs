using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.ImageRendering;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000755")]
	[RequiredAllNotNull]
	public class DecalDesignContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AD2")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AD3")]
		[Nulllable]
		public Mdl.Avatar.AvatarCustomization AvatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AD4")]
		[Nulllable]
		public AvatarAppearance Avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002AD5")]
		[Nulllable]
		[SerializeField]
		private GameObject _gamepadIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002AD6")]
		[Nulllable]
		public FocusNavigation FocusNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002AD7")]
		public ClothingDesignsRenderer designRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002AD8")]
		private List<Design> _designs = (List<Design>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002AD9")]
		[Nulllable]
		public DecalBaseItemsContent mcBaseItemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002ADA")]
		private bool _constructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002ADB")]
		[SerializeField]
		private LoopVerticalScrollRect _listDecalItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002ADC")]
		private MapField<int, DesignMap> _decals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002ADD")]
		private List<KeyValuePair<int, int>> _decalsId = (List<KeyValuePair<int, int>>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002ADE")]
		private Dictionary<int, bool> _decalDirtyState = (Dictionary<int, bool>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002ADF")]
		private bool _iconRenderingPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4002AE0")]
		private int _lastFocusElem = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002AE1")]
		private DecalItem _currentHighlightedDecal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002AE2")]
		[SerializeField]
		[Nulllable]
		private GameObject _deleteDecalBtnParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002AE3")]
		private bool _isInCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4002AE4")]
		private bool _isInTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002AE5")]
		private WardrobeMenu _wardrobe;

		[Cpp2IlInjected.Token(Token = "0x6002EDB")]
		[Cpp2IlInjected.Address(RVA = "0x155BB00", Offset = "0x155A500", VA = "0x18155BB00")]
		private bool IsDecalDirty(int decalId)
		{
			Dictionary<int, bool> decalDirtyState = _decalDirtyState;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDC")]
		[Cpp2IlInjected.Address(RVA = "0x155D900", Offset = "0x155C300", VA = "0x18155D900")]
		private void SetDecalDirty(int decalId, bool? newState)
		{
			//Discarded unreachable code: IL_000e, IL_0014, IL_0015
			//IL_000c: Expected O, but got I4
			bool flag = ((Dictionary<TKey, TValue>)(object)_decalDirtyState).Remove((TKey)decalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDD")]
		[Cpp2IlInjected.Address(RVA = "0x155B2C0", Offset = "0x1559CC0", VA = "0x18155B2C0")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0094
			//IL_0072: Expected I4, but got I8
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listDecalItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listDecalItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listDecalItems).m_OnItemSelect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemSelect);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction3);
			_listDecalItems.totalCount = 1;
			LoopVerticalScrollRect listDecalItems = _listDecalItems;
			int offset = 0;
			listDecalItems.RefillCells(offset);
			RefreshScrollBarVisibility();
			_constructed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDE")]
		[Cpp2IlInjected.Address(RVA = "0x155CA70", Offset = "0x155B470", VA = "0x18155CA70")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0065
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listDecalItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listDecalItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listDecalItems).m_OnItemSelect;
			UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemSelect);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction3);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDF")]
		[Cpp2IlInjected.Address(RVA = "0x155CBF0", Offset = "0x155B5F0", VA = "0x18155CBF0")]
		private void OnEnable()
		{
			RenderAll();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE0")]
		[Cpp2IlInjected.Address(RVA = "0x155CC50", Offset = "0x155B650", VA = "0x18155CC50")]
		public void RefreshDecalList(bool shouldUpdateWardrobe = false, bool contentReady = false)
		{
			//Discarded unreachable code: IL_012c, IL_0132, IL_0138, IL_0144
			//IL_0091: Expected I4, but got I8
			//IL_00fb: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			//IL_0126: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			WardrobeMenu wardrobeMenu = default(WardrobeMenu);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (contentReady)
				{
					_iconRenderingPaused = (byte)num2 != 0;
				}
				if ((_constructed ? 1 : 0) == num2)
				{
					LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listDecalItems).m_OnItemData;
					UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemDataHandler);
					((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
					LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listDecalItems).m_OnItemTap;
					UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemTapHandler);
					((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
					LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_listDecalItems).m_OnItemSelect;
					UnityAction<ListEventData> unityAction3 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnDecalItemSelect);
					((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction3);
					_listDecalItems.totalCount = 1;
					LoopVerticalScrollRect listDecalItems = _listDecalItems;
					int offset = 0;
					listDecalItems.RefillCells(offset);
					RefreshScrollBarVisibility();
					_constructed = true;
				}
				MapField<int, DesignMap> mapField = (_decals = (MapField<int, DesignMap>)(object)Avatar.GetDesignMaps());
				((List<T>)(object)_decalsId).Clear();
				((List<T>)(object)_designs).Clear();
				MapField<int, DesignMap> decals = _decals;
				if (flag)
				{
					if (flag2)
					{
						((List<T>)(object)_decalsId).Add((T)num2);
						List<Design> designs = _designs;
					}
					if (num2 != 0)
					{
						break;
					}
				}
				if (num2 == 0)
				{
					int num3 = 0;
					if (wardrobeMenu != (UnityEngine.Object)num3)
					{
						wardrobeMenu.SetTempToM((LoopVerticalScrollRect)num3).FireAndForgetTask();
					}
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE1")]
		[Cpp2IlInjected.Address(RVA = "0x155CC00", Offset = "0x155B600", VA = "0x18155CC00")]
		public void RefreshCells()
		{
			//Discarded unreachable code: IL_001b
			if (base.gameObject.activeInHierarchy)
			{
				_listDecalItems.RefreshCells();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE2")]
		[Cpp2IlInjected.Address(RVA = "0x155D740", Offset = "0x155C140", VA = "0x18155D740")]
		private void RenderAll()
		{
			//Discarded unreachable code: IL_005a
			List<KeyValuePair<int, int>> decalsId = _decalsId;
			LoopVerticalScrollRect listDecalItems = _listDecalItems;
			int size = ((List<>)(object)decalsId)._size;
			size = (listDecalItems.totalCount = size + 1);
			LoopVerticalScrollRect listDecalItems2 = _listDecalItems;
			int offset = 0;
			listDecalItems2.RefillCells(offset);
			_listDecalItems.RefreshCells();
			RefreshScrollBarVisibility();
			_listDecalItems.ForceUpdateBounds();
			_listDecalItems.ForceUpdateScrollbar();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE3")]
		[Cpp2IlInjected.Address(RVA = "0x155BFA0", Offset = "0x155A9A0", VA = "0x18155BFA0")]
		private void OnDecalItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE4")]
		[Cpp2IlInjected.Address(RVA = "0x155BB70", Offset = "0x155A570", VA = "0x18155BB70")]
		private void OnCustomizedItemDelete(DecalItem item)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (item != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE5")]
		[Cpp2IlInjected.Address(RVA = "0x155B6C0", Offset = "0x155A0C0", VA = "0x18155B6C0")]
		[AsyncStateMachine(typeof(_003CDeleteDesignAsync_003Ed__30))]
		private Task DeleteDesignAsync(DecalItem designItem, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE6")]
		[Cpp2IlInjected.Address(RVA = "0x155BD30", Offset = "0x155A730", VA = "0x18155BD30")]
		private void OnCustomizedItemEdit(DecalItem item)
		{
			//Discarded unreachable code: IL_00c9
			//IL_0010: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_00c8: Expected I4, but got I8
			//IL_00c8: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			WardrobeMenu wardrobe = GetWardrobe();
			int num = 0;
			if (wardrobe != (UnityEngine.Object)num)
			{
				WardrobeMenu wardrobe2 = _wardrobe;
				LoopVerticalScrollRect listDecalItems = _listDecalItems;
				Transform child = item.transform;
				int indexOf = listDecalItems.GetIndexOf(child);
				wardrobe2.EditExistingToM(indexOf);
			}
			_iconRenderingPaused = true;
			int _003CId_003Ek__BackingField = item.Id;
			int num2 = 0;
			this.SetDecalDirty(_003CId_003Ek__BackingField, (Nullable<>)num2);
			IItemData itemData = item.ItemData;
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			DecalMenu.DecalMenuParam decalMenuParam = new DecalMenu.DecalMenuParam();
			IItemData itemData2 = (decalMenuParam.itemData = item.ItemData);
			AvatarAppearance avatarAppearance = (decalMenuParam.Avatar = Avatar);
			int num3 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuDecal, decalMenuParam, (PlayerTaskCollider)num4, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE7")]
		[Cpp2IlInjected.Address(RVA = "0x155C4D0", Offset = "0x155AED0", VA = "0x18155C4D0")]
		private unsafe void OnDecalItemTapHandler(ListEventData args)
		{
			//IL_0019: Expected O, but got I4
			bool flag = default(bool);
			ClothingItemType clothingItemType = default(ClothingItemType);
			bool flag2 = default(bool);
			Task asyncTask = default(Task);
			while (true)
			{
				int num = 0;
				DecalItem component = args.DisplayObject.GetComponent<DecalItem>();
				int num2 = 0;
				int num3 = 0;
				if (component == (UnityEngine.Object)num3)
				{
					return;
				}
				if (component.ItemData != null && flag)
				{
					int num4 = (int)clothingItemType;
					if (flag2)
					{
						Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
						IItemData itemData = component.ItemData;
						Mdl.Avatar.AvatarCustomization avatarCustomization2 = AvatarCustomization;
						asyncTask.FireAndForgetTask();
						RefreshSelectedDecals();
					}
					return;
				}
				bool flag3 = ProtoDatabase.Instance.TryGet("ClothingDesign", out *(ClothingDesignData*)num2);
				Profile profile = SystemRoot.Instance.Client.Profile;
				AvatarAppearance avatar = Avatar;
				ProfilePlayer player_ = profile.player_;
				bool _003CIsMale_003Ek__BackingField = avatar.IsMale;
				if ((long)player_.GetDesignCount(_003CIsMale_003Ek__BackingField) >= (long)(IntPtr)ProfilePlayer._map_currencyAmounts_codec)
				{
					break;
				}
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				mcBaseItemContent.gameObject.SetActive(value: true);
				int num5 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					int num6 = 0;
					MenuStack menuStack = UiRoot.Instance._menuStack;
					int num7 = 0;
					IMenu top = menuStack.Top;
					while (top == null)
					{
					}
					int num8 = 0;
					while (top == null)
					{
					}
					break;
				}
			}
			int num9 = 0;
			Task asyncTask2 = default(Task);
			asyncTask2.FireAndForgetTask();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE8")]
		[Cpp2IlInjected.Address(RVA = "0x155B8A0", Offset = "0x155A2A0", VA = "0x18155B8A0")]
		[AsyncStateMachine(typeof(_003CDisplayFullInventoryWarning_003Ed__33))]
		private Task DisplayFullInventoryWarning()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE9")]
		[Cpp2IlInjected.Address(RVA = "0x155C3E0", Offset = "0x155ADE0", VA = "0x18155C3E0")]
		private void OnDecalItemSelect(ListEventData args)
		{
			//Discarded unreachable code: IL_005a
			//IL_0015: Expected O, but got I4
			DecalItem component = args.DisplayObject.GetComponent<DecalItem>();
			int num = 0;
			if (component == (UnityEngine.Object)num)
			{
				return;
			}
			int num2 = (_lastFocusElem = args.ItemIndex);
			if ((long)component.ItemData != 0)
			{
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					FocusNavigation focusNav = FocusNav;
					SetFocus(focusNav);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEA")]
		[Cpp2IlInjected.Address(RVA = "0x155D400", Offset = "0x155BE00", VA = "0x18155D400")]
		private void RefreshSelectedDecals()
		{
			//Discarded unreachable code: IL_005c, IL_0062, IL_0068, IL_006e, IL_0080
			//IL_002c: Expected O, but got I4
			DecalItem decalItem = default(DecalItem);
			bool flag = default(bool);
			while (true)
			{
				IEnumerator enumerator = ((LoopScrollRect)_listDecalItems).m_Content.GetEnumerator();
				if (enumerator != null)
				{
					int num = 0;
					if (enumerator == null)
					{
						break;
					}
					int num2 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num3 = 0;
					if (!(decalItem != (UnityEngine.Object)num3) || decalItem.ItemData == null)
					{
						continue;
					}
					IItemData itemData = decalItem.ItemData;
					AvatarAppearance avatar = Avatar;
					decalItem.IsSelected = flag;
					decalItem.UpdateDeleteBtnActive();
				}
				if (!flag)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEB")]
		[Cpp2IlInjected.Address(RVA = "0x155D6A0", Offset = "0x155C0A0", VA = "0x18155D6A0")]
		private void RefreshSelected(DecalItem item)
		{
			//Discarded unreachable code: IL_001c
			AvatarAppearance avatar = Avatar;
			IItemData itemData = item.ItemData;
			bool isSelected = default(bool);
			item.IsSelected = isSelected;
			item.UpdateDeleteBtnActive();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEC")]
		[Cpp2IlInjected.Address(RVA = "0x155D9C0", Offset = "0x155C3C0", VA = "0x18155D9C0")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_019b, IL_01a0
			//IL_0009: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0134: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			int num = 0;
			if (focusNavigation == (UnityEngine.Object)num)
			{
				return;
			}
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || _isInCoroutine || _isInTask)
			{
				return;
			}
			WardrobeMenu wardrobe = GetWardrobe();
			int num3 = 0;
			if (wardrobe != (UnityEngine.Object)num3)
			{
				bool flag = _wardrobe.IsBackFromNewToM();
				WardrobeMenu wardrobe2 = _wardrobe;
				if (flag)
				{
					goto IL_0117;
				}
				int focusAfterEditExisting = wardrobe2.GetFocusAfterEditExisting();
				if (focusAfterEditExisting != -1)
				{
					_listDecalItems.SelectedIndex = focusAfterEditExisting;
					LoopVerticalScrollRect listDecalItems = _listDecalItems;
					_lastFocusElem = focusAfterEditExisting;
					Transform itemByDataIndex = listDecalItems.GetItemByDataIndex(focusAfterEditExisting);
					int num4 = 0;
					if (!(itemByDataIndex == (UnityEngine.Object)num4))
					{
						int lastVisibleItemIndex = _listDecalItems.GetLastVisibleItemIndex();
						int lastVisibleItemIndex2 = _listDecalItems.GetLastVisibleItemIndex();
						if (focusAfterEditExisting < lastVisibleItemIndex2)
						{
							goto IL_00e0;
						}
					}
					goto IL_017d;
				}
			}
			goto IL_00e0;
			IL_0117:
			int _003C_003E1__state = default(int);
			_003CWaitForIndex_003Ed__38 _003CWaitForIndex_003Ed__ = new _003CWaitForIndex_003Ed__38(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForIndex_003Ed__._003C_003E4__this = this;
			int selectedIndex = default(int);
			_003CWaitForIndex_003Ed__.wardrobe = (WardrobeMenu)selectedIndex;
			_003CWaitForIndex_003Ed__.focusNavigation = focusNavigation;
			Coroutine coroutine = StartCoroutine(_003CWaitForIndex_003Ed__);
			goto IL_0146;
			IL_0146:
			int num5 = 0;
			int num6 = 0;
			LoopVerticalScrollRect listDecalItems2 = default(LoopVerticalScrollRect);
			if (!((UnityEngine.Object)num5 != (UnityEngine.Object)num6))
			{
				int selectedIndex2 = _listDecalItems.SelectedIndex;
				listDecalItems2 = _listDecalItems;
				int num7 = (listDecalItems2.SelectedIndex = LoopScrollRect.INVALID_INDEX);
				goto IL_017d;
			}
			goto IL_0189;
			IL_0189:
			FocusNavigationElement component = listDecalItems2.GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
			return;
			IL_00e0:
			selectedIndex = _listDecalItems.SelectedIndex;
			LoopVerticalScrollRect listDecalItems3 = _listDecalItems;
			int selectedIndex3 = listDecalItems3.SelectedIndex;
			Transform itemByDataIndex2 = listDecalItems3.GetItemByDataIndex(selectedIndex3);
			if ((object)itemByDataIndex2 != null)
			{
				DecalItem component2 = itemByDataIndex2.GetComponent<DecalItem>();
				goto IL_0117;
			}
			goto IL_0146;
			IL_017d:
			ScrollAndFocus(focusNavigation).FireAndForgetTask();
			goto IL_0189;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EED")]
		[Cpp2IlInjected.Address(RVA = "0x155E1D0", Offset = "0x155CBD0", VA = "0x18155E1D0")]
		[IteratorStateMachine(typeof(_003CWaitForIndex_003Ed__38))]
		private IEnumerator WaitForIndex(WardrobeMenu wardrobe, FocusNavigation focusNavigation)
		{
			int _003C_003E1__state = default(int);
			_003CWaitForIndex_003Ed__38 _003CWaitForIndex_003Ed__ = new _003CWaitForIndex_003Ed__38(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForIndex_003Ed__._003C_003E4__this = this;
			_003CWaitForIndex_003Ed__.wardrobe = wardrobe;
			_003CWaitForIndex_003Ed__.focusNavigation = focusNavigation;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEE")]
		[Cpp2IlInjected.Address(RVA = "0x155D7E0", Offset = "0x155C1E0", VA = "0x18155D7E0")]
		[AsyncStateMachine(typeof(_003CScrollAndFocus_003Ed__39))]
		private Task ScrollAndFocus(FocusNavigation focusNavigation)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEF")]
		[Cpp2IlInjected.Address(RVA = "0x155B7F0", Offset = "0x155A1F0", VA = "0x18155B7F0")]
		internal bool DeselectCurrentDecal()
		{
			//Discarded unreachable code: IL_0023
			int selectedIndex = _listDecalItems.SelectedIndex;
			LoopVerticalScrollRect listDecalItems = _listDecalItems;
			int selectedIndex2 = listDecalItems.SelectedIndex;
			listDecalItems.DeselectIndex(selectedIndex2);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF0")]
		[Cpp2IlInjected.Address(RVA = "0x155D210", Offset = "0x155BC10", VA = "0x18155D210")]
		private void RefreshScrollBarVisibility()
		{
			//Discarded unreachable code: IL_0077
			//IL_001a: Expected O, but got I4
			//IL_0051: Expected F4, but got I4
			CanvasGroup component = ((LoopScrollRect)_listDecalItems).m_VerticalScrollbar.GetComponent<CanvasGroup>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				((LoopScrollRect)_listDecalItems).m_Content.RebuildLayout();
				RectTransform content = ((LoopScrollRect)_listDecalItems).m_Content;
				RectTransform viewport = ((LoopScrollRect)_listDecalItems).m_Viewport;
				int num2 = 0;
				component.alpha = num2;
				RectTransform content2 = ((LoopScrollRect)_listDecalItems).m_Content;
				RectTransform viewport2 = ((LoopScrollRect)_listDecalItems).m_Viewport;
				int num3 = ((component.interactable = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF1")]
		[Cpp2IlInjected.Address(RVA = "0x155B9A0", Offset = "0x155A3A0", VA = "0x18155B9A0")]
		public void EditCurrentHighlightedDecal()
		{
			//Discarded unreachable code: IL_002d
			//IL_0010: Expected O, but got I4
			DecalItem currentHighlightedDecal = _currentHighlightedDecal;
			int num = 0;
			if (currentHighlightedDecal != (UnityEngine.Object)num)
			{
				DecalItem currentHighlightedDecal2 = _currentHighlightedDecal;
				if ((long)currentHighlightedDecal2.ItemData != 0)
				{
					OnCustomizedItemEdit(currentHighlightedDecal2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF2")]
		[Cpp2IlInjected.Address(RVA = "0x155B480", Offset = "0x1559E80", VA = "0x18155B480")]
		public void DeleteCurrentHighlightedDecal()
		{
			//Discarded unreachable code: IL_003c
			//IL_0010: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			DecalItem currentHighlightedDecal = _currentHighlightedDecal;
			int num = 0;
			if (!(currentHighlightedDecal != (UnityEngine.Object)num))
			{
				return;
			}
			DecalItem currentHighlightedDecal2 = _currentHighlightedDecal;
			if ((long)currentHighlightedDecal2.ItemData != 0)
			{
				int num2 = 0;
				if (currentHighlightedDecal2 != (UnityEngine.Object)num2)
				{
					int num3 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF3")]
		[Cpp2IlInjected.Address(RVA = "0x155DEF0", Offset = "0x155C8F0", VA = "0x18155DEF0")]
		public void UpdateState(float deltaTime)
		{
			//Discarded unreachable code: IL_00e7
			//IL_0040: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			ISupportsFocusNavigation focusedElement = FocusNav._focusedElement;
			if (focusedElement == null)
			{
				return;
			}
			int num2 = 0;
			int num3 = 0;
			if (focusedElement != null)
			{
			}
			int num4 = 0;
			if ((UnityEngine.Object)num3 != (UnityEngine.Object)num4)
			{
			}
			if ((_gamepadIndicator.gameObject.activeSelf ? 1 : 0) != num3)
			{
				_gamepadIndicator.gameObject.SetActive((byte)num3 != 0);
			}
			int num5 = 0;
			if ((UnityEngine.Object)num3 != (UnityEngine.Object)num5 && _currentHighlightedDecal != (UnityEngine.Object)num3)
			{
				_currentHighlightedDecal = (DecalItem)num3;
			}
			if (!_gamepadIndicator.gameObject.activeInHierarchy)
			{
				return;
			}
			DecalItem currentHighlightedDecal = _currentHighlightedDecal;
			int num6 = 0;
			if (currentHighlightedDecal != (UnityEngine.Object)num6)
			{
				GameObject deleteDecalBtnParent = _deleteDecalBtnParent;
				int num7 = 0;
				if (deleteDecalBtnParent != (UnityEngine.Object)num7)
				{
					DecalItem currentHighlightedDecal2 = _currentHighlightedDecal;
					bool active = default(bool);
					_deleteDecalBtnParent.SetActive(active);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF4")]
		[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
		public LoopVerticalScrollRect GetListDecal()
		{
			return _listDecalItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF5")]
		[Cpp2IlInjected.Address(RVA = "0x155BA40", Offset = "0x155A440", VA = "0x18155BA40")]
		private WardrobeMenu GetWardrobe()
		{
			//Discarded unreachable code: IL_0033
			//IL_0010: Expected O, but got I4
			WardrobeMenu wardrobe = _wardrobe;
			int num = 0;
			if (wardrobe == (UnityEngine.Object)num)
			{
				int num2 = 0;
				WardrobeMenu wardrobeMenu = (_wardrobe = UiRoot.Instance._menuStack.GetMenu<WardrobeMenu>());
			}
			return _wardrobe;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF6")]
		[Cpp2IlInjected.Address(RVA = "0x155E280", Offset = "0x155CC80", VA = "0x18155E280")]
		public DecalDesignContent()
		{
		}//IL_0037: Expected I4, but got I8

	}
}
