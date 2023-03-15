using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Buildings;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002BF")]
	[RequiredAllNotNull]
	public class RemiShopMenu : Menu, IShopMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20002C0")]
		private enum CookingShopStallState
		{
			[Cpp2IlInjected.Token(Token = "0x4000CB2")]
			Selection,
			[Cpp2IlInjected.Token(Token = "0x4000CB3")]
			Sell,
			[Cpp2IlInjected.Token(Token = "0x4000CB4")]
			ShelfInfo
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000CA5")]
		[SerializeField]
		private GardeningStallShelfItemInfoContent _mcShelfItemInfoContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000CA6")]
		[SerializeField]
		private BaseButton _btnShelfInfoCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000CA7")]
		[SerializeField]
		private GardeningStallSelectionContent _mcSelectionContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000CA8")]
		[SerializeField]
		private ButtonTmProIcon _btnRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000CA9")]
		[SerializeField]
		private ButtonTmProIcon _btnUpgrade;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000CAA")]
		[SerializeField]
		private CurrencyContent _mcCurrencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000CAB")]
		[SerializeField]
		[Header("AUDIO")]
		private AK.Wwise.Event selectItemSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000CAC")]
		private ShoppingStall _currentStall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000CAD")]
		private CookingShopStallState _currentState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000CAE")]
		private FocusNavigationElement _focusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000CAF")]
		[SerializeField]
		private AsyncMenu _upgradePopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000CB0")]
		private int _shelfFocusedIndex = -1;

		[Cpp2IlInjected.Token(Token = "0x6001153")]
		[Cpp2IlInjected.Address(RVA = "0xE2F710", Offset = "0xE2E110", VA = "0x180E2F710")]
		private GardeningStallShelvesContent GetGardeningShelvesContent()
		{
			//Discarded unreachable code: IL_0012
			int num = 0;
			return UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
		}

		[Cpp2IlInjected.Token(Token = "0x6001154")]
		[Cpp2IlInjected.Address(RVA = "0xE30FF0", Offset = "0xE2F9F0", VA = "0x180E30FF0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_01b8
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnShelfInfoCancel.ButtonComponent.m_OnClick;
			UnityAction call = OnShelfInfoCancelClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnRefresh.ButtonComponent.m_OnClick;
			UnityAction call2 = OnRefreshClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnUpgrade.ButtonComponent.m_OnClick;
			UnityAction call3 = OnUpgradeClickHandler;
			onClick3.AddListener(call3);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ShopItemsRefreshed value = OnShopItemsRefreshed;
			_003CDispatcher_003Ek__BackingField.OnShopItemsRefreshed += value;
			BaseButton btnShelfInfoCancel = _btnShelfInfoCancel;
			BaseButton.OnBaseButtonPress value2 = OnPress;
			btnShelfInfoCancel.OnPress += value2;
			BaseButton btnAdd = _mcShelfItemInfoContent._btnAdd;
			BaseButton.OnBaseButtonPress value3 = OnPress;
			btnAdd.OnPress += value3;
			BaseButton btnSubtract = _mcShelfItemInfoContent._btnSubtract;
			BaseButton.OnBaseButtonPress value4 = OnPress;
			btnSubtract.OnPress += value4;
			ButtonTmProIcon btnBuy = _mcShelfItemInfoContent._btnBuy;
			BaseButton.OnBaseButtonPress value5 = OnPress;
			btnBuy.OnPress += value5;
			BaseButton btnShelfInfoCancel2 = _btnShelfInfoCancel;
			BaseButton.OnBaseButtonRelease value6 = OnRelease;
			btnShelfInfoCancel2.OnRelease += value6;
			BaseButton btnAdd2 = _mcShelfItemInfoContent._btnAdd;
			BaseButton.OnBaseButtonRelease value7 = OnRelease;
			btnAdd2.OnRelease += value7;
			ButtonTmProIcon btnBuy2 = _mcShelfItemInfoContent._btnBuy;
			BaseButton.OnBaseButtonRelease value8 = OnRelease;
			btnBuy2.OnRelease += value8;
			BaseButton btnSubtract2 = _mcShelfItemInfoContent._btnSubtract;
			BaseButton.OnBaseButtonRelease value9 = OnRelease;
			btnSubtract2.OnRelease += value9;
		}

		[Cpp2IlInjected.Token(Token = "0x6001155")]
		[Cpp2IlInjected.Address(RVA = "0xE31CC0", Offset = "0xE306C0", VA = "0x180E31CC0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_020d
			//IL_008d: Expected O, but got I4
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnShelfInfoCancel.ButtonComponent.m_OnClick;
			UnityAction call = OnShelfInfoCancelClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnRefresh.ButtonComponent.m_OnClick;
			UnityAction call2 = OnRefreshClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnUpgrade.ButtonComponent.m_OnClick;
			UnityAction call3 = OnUpgradeClickHandler;
			onClick3.RemoveListener(call3);
			ShoppingStall currentStall = _currentStall;
			int num = 0;
			if (currentStall != (UnityEngine.Object)num)
			{
				ShoppingStall currentStall2 = _currentStall;
				EventHandler<StallShelfInteractionEventArgs> eventHandler = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfInteraction);
				currentStall2.remove_StallShelfInteractionEvent((EventHandler<>)(object)eventHandler);
				ShoppingStall currentStall3 = _currentStall;
				EventHandler<StallShelfInteractionEventArgs> eventHandler2 = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfHover);
				currentStall3.remove_StallShelfHoverEvent((EventHandler<>)(object)eventHandler2);
			}
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ShopItemsRefreshed value = OnShopItemsRefreshed;
			_003CDispatcher_003Ek__BackingField.OnShopItemsRefreshed -= value;
			BaseButton btnShelfInfoCancel = _btnShelfInfoCancel;
			BaseButton.OnBaseButtonPress value2 = OnPress;
			btnShelfInfoCancel.OnPress -= value2;
			BaseButton btnAdd = _mcShelfItemInfoContent._btnAdd;
			BaseButton.OnBaseButtonPress value3 = OnPress;
			btnAdd.OnPress -= value3;
			BaseButton btnSubtract = _mcShelfItemInfoContent._btnSubtract;
			BaseButton.OnBaseButtonPress value4 = OnPress;
			btnSubtract.OnPress -= value4;
			ButtonTmProIcon btnBuy = _mcShelfItemInfoContent._btnBuy;
			BaseButton.OnBaseButtonPress value5 = OnPress;
			btnBuy.OnPress -= value5;
			BaseButton btnShelfInfoCancel2 = _btnShelfInfoCancel;
			BaseButton.OnBaseButtonRelease value6 = OnRelease;
			btnShelfInfoCancel2.OnRelease -= value6;
			BaseButton btnAdd2 = _mcShelfItemInfoContent._btnAdd;
			BaseButton.OnBaseButtonRelease value7 = OnRelease;
			btnAdd2.OnRelease -= value7;
			ButtonTmProIcon btnBuy2 = _mcShelfItemInfoContent._btnBuy;
			BaseButton.OnBaseButtonRelease value8 = OnRelease;
			btnBuy2.OnRelease -= value8;
			BaseButton btnSubtract2 = _mcShelfItemInfoContent._btnSubtract;
			BaseButton.OnBaseButtonRelease value9 = OnRelease;
			btnSubtract2.OnRelease -= value9;
		}

		[Cpp2IlInjected.Token(Token = "0x6001156")]
		[Cpp2IlInjected.Address(RVA = "0x9B32D0", Offset = "0x9B1CD0", VA = "0x1809B32D0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			base.OnPush(stack, param);
		}

		[Cpp2IlInjected.Token(Token = "0x6001157")]
		[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001158")]
		[Cpp2IlInjected.Address(RVA = "0xE301B0", Offset = "0xE2EBB0", VA = "0x180E301B0", Slot = "28")]
		public override void OnFocusOut(bool popAfterPreFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_001a
			base.OnFocusOut(popAfterPreFocusOut);
			int num = 0;
			UiRoot.Instance._worldCanvas.GardeningShelvesStop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001159")]
		[Cpp2IlInjected.Address(RVA = "0xE30E20", Offset = "0xE2F820", VA = "0x180E30E20", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__19))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__19 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__19(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600115A")]
		[Cpp2IlInjected.Address(RVA = "0xE2FA30", Offset = "0xE2E430", VA = "0x180E2FA30", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0152
			//IL_0028: Expected I4, but got I8
			//IL_003c: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			base.OnFocusIn();
			RectTransform animatedContent = _btnUpgrade.AnimatedContent;
			LayoutRebuilder.ForceRebuildLayoutImmediate(animatedContent);
			GardeningStallSelectionContent mcSelectionContent = _mcSelectionContent;
			_currentState = CookingShopStallState.Selection;
			mcSelectionContent.Show(0.25f);
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				EventHandler<StallShelfInteractionEventArgs> eventHandler = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfInteraction);
				EventHandler<StallShelfInteractionEventArgs> eventHandler2 = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfHover);
			}
			Stall _003CCurrentStall_003Ek__BackingField = SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall;
			if ((object)_003CCurrentStall_003Ek__BackingField == null)
			{
			}
			int num2 = 0;
			_currentStall = (ShoppingStall)_003CCurrentStall_003Ek__BackingField;
			int num3 = 0;
			if (animatedContent != (UnityEngine.Object)num3)
			{
				EventHandler<StallShelfInteractionEventArgs> eventHandler3 = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfInteraction);
				EventHandler<StallShelfInteractionEventArgs> eventHandler4 = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfHover);
			}
			int num4 = 0;
			string shopName = default(string);
			if (animatedContent != (UnityEngine.Object)num4 && !SystemRoot.Instance.MetaClient.profile.world_.GetShop(shopName).Definition.isDispenser_)
			{
				_mcCurrencyContent.Show();
			}
			string text = default(string);
			_btnRefresh.Label.Text = text;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon currencyIcon = _btnRefresh._currencyIcon;
			int num5 = 0;
			WorldUI worldCanvas = UiRoot.Instance._worldCanvas;
			string shopName2 = default(string);
			Shop shop = SystemRoot.Instance.MetaClient.profile.world_.GetShop(shopName2);
			IEnumerator routine = FetchWorldUIReference();
			Coroutine coroutine = StartCoroutine(routine);
			base.IsDataUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600115B")]
		[Cpp2IlInjected.Address(RVA = "0xE30460", Offset = "0xE2EE60", VA = "0x180E30460")]
		private void OnShelfInfoCancelClickHandler()
		{
			//Discarded unreachable code: IL_00ac
			//IL_001b: Expected F4, but got I4
			//IL_002b: Expected O, but got I4
			_mcShelfItemInfoContent.Hide();
			GardeningStallSelectionContent mcSelectionContent = _mcSelectionContent;
			int num = 0;
			mcSelectionContent.Show(num);
			_focusedElement = (FocusNavigationElement)(_currentState = CookingShopStallState.Selection);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num3 = 0;
				RectTransform content = UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>()._listShelves.m_Content;
				int shelfFocusedIndex = _shelfFocusedIndex;
				Transform child = content.GetChild(shelfFocusedIndex);
				StallShelfPriceButton component = child.GetComponent<StallShelfPriceButton>();
				component.IsSelected = false;
				component.OnHighlightExit();
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				FocusNavigationElement component2 = child.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600115C")]
		[Cpp2IlInjected.Address(RVA = "0xE2F990", Offset = "0xE2E390", VA = "0x180E2F990", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0022
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600115D")]
		[Cpp2IlInjected.Address(RVA = "0xE30680", Offset = "0xE2F080", VA = "0x180E30680")]
		public void OnStallShelfHover(object sender, StallShelfInteractionEventArgs e)
		{
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) || _mcShelfItemInfoContent.IsVisible)
			{
				return;
			}
			StallShelfInteractionEventArgs stallShelfInteractionEventArgs = e;
			if (stallShelfInteractionEventArgs != null)
			{
				List<GameObject> shelves = stallShelfInteractionEventArgs.Stall.Shelves;
				Predicate<GameObject> predicate = (Predicate<GameObject>)(object)(Predicate<T>)delegate(GameObject x)
				{
					//Discarded unreachable code: IL_0014
					GameObject _003CShelf_003Ek__BackingField = e.Shelf;
					return x == _003CShelf_003Ek__BackingField;
				};
				int num2 = ((List<T>)(object)shelves).FindIndex((Predicate<>)(object)predicate);
				if (num2 != _shelfFocusedIndex)
				{
					_shelfFocusedIndex = num2;
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					GardeningStallShelvesContent gardeningShelvesContent = GetGardeningShelvesContent();
					if ((object)gardeningShelvesContent != null)
					{
						FocusNavigationElement component = gardeningShelvesContent._listShelves.m_Content.GetChild(num2).GetComponent<FocusNavigationElement>();
					}
				}
				return;
			}
			MenuNavigation menuNavigation = default(MenuNavigation);
			FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600115E")]
		[Cpp2IlInjected.Address(RVA = "0xE30890", Offset = "0xE2F290", VA = "0x180E30890")]
		public void OnStallShelfInteraction(object sender, StallShelfInteractionEventArgs e)
		{
			//Discarded unreachable code: IL_0162
			//IL_006b: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			//IL_010d: Expected O, but got I4
			//IL_0120: Expected I4, but got I8
			StallShelfInteractionEventArgs stallShelfInteractionEventArgs = e;
			Predicate<GameObject> predicate = (Predicate<GameObject>)(object)(Predicate<T>)delegate(GameObject x)
			{
				//Discarded unreachable code: IL_0014
				GameObject _003CShelf_003Ek__BackingField = e.Shelf;
				return x == _003CShelf_003Ek__BackingField;
			};
			int num = default(int);
			_shelfFocusedIndex = num;
			int num2 = 0;
			GardeningStallShelvesContent componentInChildren = UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
			if ((object)componentInChildren != null)
			{
				FocusNavigationElement component = componentInChildren._listShelves.m_Content.GetChild(num).GetComponent<FocusNavigationElement>();
			}
			int num3 = 0;
			int num4 = 0;
			if ((UnityEngine.Object)num3 != (UnityEngine.Object)num4 && base.MenuNavigation.GetFocusElement() != (UnityEngine.Object)num3)
			{
				base.MenuNavigation.FocusNavigation.SetFocus((FocusNavigationElement)num3);
			}
			_mcSelectionContent.Hide();
			int num5 = 0;
			GardeningStallShelvesContent componentInChildren2 = UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
			if ((object)componentInChildren2 != null)
			{
				GameObject gameObject = componentInChildren2._listShelves.m_Content.GetChild(num).gameObject;
			}
			int num6 = 0;
			int num7 = 0;
			bool flag = default(bool);
			if ((UnityEngine.Object)num6 != (UnityEngine.Object)num7 && flag)
			{
				Item item = _mcShelfItemInfoContent._item;
				AK.Wwise.Event @event = selectItemSFX;
				if (@event != null)
				{
					uint num8 = @event.Post((GameObject)num6);
				}
			}
			GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
			_currentState = CookingShopStallState.ShelfInfo;
			mcShelfItemInfoContent.Show(0.1f);
			GardeningStallShelfItemInfoContent mcShelfItemInfoContent2 = _mcShelfItemInfoContent;
			Action action = OnShelfInfoCancelClickHandler;
			int num9 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600115F")]
		[Cpp2IlInjected.Address(RVA = "0xE30260", Offset = "0xE2EC60", VA = "0x180E30260")]
		private void OnRefreshClickHandler()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001160")]
		[Cpp2IlInjected.Address(RVA = "0xE30EA0", Offset = "0xE2F8A0", VA = "0x180E30EA0", Slot = "38")]
		[AsyncStateMachine(typeof(_003CRefreshStall_003Ed__26))]
		public Task<ShopRefresh.Types.Response> RefreshStall(CancellationToken ct, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ShopRefresh.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001161")]
		[Cpp2IlInjected.Address(RVA = "0xE2F7E0", Offset = "0xE2E1E0", VA = "0x180E2F7E0")]
		private void InitRefreshButton()
		{
			//Discarded unreachable code: IL_0032
			CurrencyCost refreshCost = _currentStall.RefreshCost;
			string text = default(string);
			_btnRefresh.Label.Text = text;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon currencyIcon = _btnRefresh._currencyIcon;
		}

		[Cpp2IlInjected.Token(Token = "0x6001162")]
		[Cpp2IlInjected.Address(RVA = "0xE2F9E0", Offset = "0xE2E3E0", VA = "0x180E2F9E0")]
		private void OnExitClickHandler()
		{
			//Discarded unreachable code: IL_001d
			//IL_0015: Expected O, but got I4
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num = 0;
			focusNavigation.SetFocus((FocusNavigationElement)num);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001163")]
		[Cpp2IlInjected.Address(RVA = "0xE30D60", Offset = "0xE2F760", VA = "0x180E30D60")]
		private void OnUpgradeClickHandler()
		{
			//Discarded unreachable code: IL_0038
			BuildingUpgradePopup.BuildingUpgradePopupParam buildingUpgradePopupParam = new BuildingUpgradePopup.BuildingUpgradePopupParam();
			UpgradableBuilding upgradableBuilding = (buildingUpgradePopupParam.UpgradableBuilding = _currentStall.GetComponent<UpgradableBuilding>());
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			AsyncMenu upgradePopup = _upgradePopup;
			menuStack.Push(upgradePopup, buildingUpgradePopupParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6001164")]
		[Cpp2IlInjected.Address(RVA = "0xE30600", Offset = "0xE2F000", VA = "0x180E30600")]
		private void OnShopItemsRefreshed(string shopName, Item item, CurrencyCost refreshCost, bool isFreeRefresh)
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CFetchWorldUIReference_003Ed__32 _003CFetchWorldUIReference_003Ed__ = new _003CFetchWorldUIReference_003Ed__32(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFetchWorldUIReference_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CFetchWorldUIReference_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6001165")]
		[Cpp2IlInjected.Address(RVA = "0xE31510", Offset = "0xE2FF10", VA = "0x180E31510")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_01cf, IL_01db, IL_01e7, IL_01ed, IL_01f3, IL_01f9, IL_0205
			//IL_0017: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_00d0: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_015f: Expected O, but got I4
			bool flag = default(bool);
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			MenuNavigation menuNavigation = default(MenuNavigation);
			bool flag2 = default(bool);
			int num8 = default(int);
			IEnumerator enumerator2 = default(IEnumerator);
			bool flag3 = default(bool);
			int num12 = default(int);
			MenuNavigation menuNavigation2 = default(MenuNavigation);
			while (true)
			{
				int num = 0;
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num2 = 0;
				if (!(focusNavigation != (UnityEngine.Object)num2))
				{
					return;
				}
				int num3 = 0;
				GardeningStallShelvesContent componentInChildren = UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
				if (_currentState != 0)
				{
					continue;
				}
				int num4 = 0;
				if (!(componentInChildren != (UnityEngine.Object)num4) || componentInChildren._listShelves.m_Content.childCount <= 0)
				{
					return;
				}
				FocusNavigationElement focusedElement = _focusedElement;
				int num5 = 0;
				if (focusedElement != (UnityEngine.Object)num5)
				{
					IEnumerator enumerator = componentInChildren._listShelves.m_Content.GetEnumerator();
					if (enumerator != null)
					{
						if (enumerator == null)
						{
						}
						int num6 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						flag = _focusedElement == focusNavigationElement;
						while (!flag)
						{
						}
						FocusNavigationElement focusedElement2 = _focusedElement;
					}
					if (flag)
					{
					}
					if (num != 0)
					{
						throw new NullReferenceException();
					}
				}
				_focusedElement = (FocusNavigationElement)num;
				int num7 = 0;
				if (!((UnityEngine.Object)num != (UnityEngine.Object)num7))
				{
					FocusNavigation focusNavigation2 = base.MenuNavigation.FocusNavigation;
					RectTransform content = componentInChildren._listShelves.m_Content;
					int index = 0;
					FocusNavigationElement component = content.GetChild(index).GetComponent<FocusNavigationElement>();
					focusNavigation2.SetFocus(component);
					return;
				}
				if ((long)menuNavigation.FocusNavigation != 2)
				{
					continue;
				}
				if ((IntPtr)base.MenuNavigation.FocusNavigation._focusedElement != (IntPtr)num && flag2 && num8 > 0)
				{
					FocusNavigationElement focusedElement3 = _focusedElement;
					int num9 = 0;
					if (focusedElement3 == (UnityEngine.Object)num9)
					{
						if (enumerator2 != null)
						{
							if (enumerator2 == null)
							{
							}
							int num10 = 0;
							if (enumerator2 == null)
							{
								break;
							}
							if (base.MenuNavigation.FocusNavigation._focusedElement == null)
							{
							}
							int num11 = 0;
							while (!flag3)
							{
							}
							ISupportsFocusNavigation focusedElement4 = base.MenuNavigation.FocusNavigation._focusedElement;
							if (focusedElement4 != null)
							{
								num12 = 0;
							}
							_focusedElement = (FocusNavigationElement)focusedElement4;
						}
						if (num12 != 0)
						{
						}
						if (num != 0)
						{
							continue;
						}
					}
				}
				Throbber.ThrobberTransactionScope throbberTransactionScope = menuNavigation2._throbberTransactionScope;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001166")]
		[Cpp2IlInjected.Address(RVA = "0xE2F6A0", Offset = "0xE2E0A0", VA = "0x180E2F6A0")]
		[IteratorStateMachine(typeof(_003CFetchWorldUIReference_003Ed__32))]
		private IEnumerator FetchWorldUIReference()
		{
			int _003C_003E1__state = default(int);
			_003CFetchWorldUIReference_003Ed__32 _003CFetchWorldUIReference_003Ed__ = new _003CFetchWorldUIReference_003Ed__32(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFetchWorldUIReference_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001167")]
		[Cpp2IlInjected.Address(RVA = "0xE2F760", Offset = "0xE2E160", VA = "0x180E2F760", Slot = "39")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0030, IL_0038
			//IL_0027: Expected O, but got I4
			GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
			int num = 0;
			if ((mcShelfItemInfoContent.IsVisible ? 1 : 0) == num)
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num2 = 0;
				focusNavigation.SetFocus((FocusNavigationElement)num2);
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
			else
			{
				OnShelfInfoCancelClickHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001168")]
		[Cpp2IlInjected.Address(RVA = "0xE301F0", Offset = "0xE2EBF0", VA = "0x180E301F0")]
		private void OnPress(BaseButton btn)
		{
			//Discarded unreachable code: IL_001f
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)btn.AnimatedContent, 0.9f, 0.2f)).SetEase(Ease.OutCubic);
		}

		[Cpp2IlInjected.Token(Token = "0x6001169")]
		[Cpp2IlInjected.Address(RVA = "0xE303F0", Offset = "0xE2EDF0", VA = "0x180E303F0")]
		private void OnRelease(BaseButton btn)
		{
			//Discarded unreachable code: IL_001f
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)btn.AnimatedContent, 1f, 0.5f)).SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x600116A")]
		[Cpp2IlInjected.Address(RVA = "0xE322E0", Offset = "0xE30CE0", VA = "0x180E322E0")]
		public RemiShopMenu()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
