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
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002A9")]
	[RequiredAllNotNull]
	public class GardeningStallMenu : Menu, IShopMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20002AA")]
		public enum StallState
		{
			[Cpp2IlInjected.Token(Token = "0x4000C20")]
			Selection,
			[Cpp2IlInjected.Token(Token = "0x4000C21")]
			Sell,
			[Cpp2IlInjected.Token(Token = "0x4000C22")]
			ItemInfo
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000C0A")]
		private StallState _currentState;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000C0B")]
		[SerializeField]
		private Button _btnExitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000C0C")]
		[SerializeField]
		private CurrencyContent[] _mcCurrencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000C0D")]
		[SerializeField]
		private CurrencyContent _mcMainCurrencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000C0E")]
		[SerializeField]
		private Button _btnSellButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000C0F")]
		[SerializeField]
		private ButtonTmProIcon _btnRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000C10")]
		[SerializeField]
		private ButtonTmProIcon _btnUpgrade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000C11")]
		[SerializeField]
		private Button _btnInfoCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000C12")]
		[SerializeField]
		private AK.Wwise.Event _showBuyContentSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000C13")]
		[SerializeField]
		private AsyncMenu _upgradePopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000C14")]
		[SerializeField]
		private GardeningStallSelectionContent _mcSelectionContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000C15")]
		[SerializeField]
		private GardeningStallShelfItemInfoContent _mcShelfItemInfoContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000C16")]
		[SerializeField]
		private StallSellInventory _backpackSellContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000C17")]
		[SerializeField]
		[ItemID]
		private int _currencyCoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000C18")]
		[SerializeField]
		private ShortcutIndicator _backStallIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000C19")]
		[SerializeField]
		public AK.Wwise.Event onClickStallItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000C1A")]
		[SerializeField]
		private SimpleSlide _currencySlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000C1C")]
		private bool _isSell;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000C1D")]
		private FocusNavigationElement _focusedShelfElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000C1E")]
		private int _shelfFocusedIndex = -1;

		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		public ShoppingStall CurrentStall
		{
			[Cpp2IlInjected.Token(Token = "0x60010B4")]
			[Cpp2IlInjected.Address(RVA = "0x738A00", Offset = "0x737400", VA = "0x180738A00")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60010B5")]
			[Cpp2IlInjected.Address(RVA = "0x739E60", Offset = "0x738860", VA = "0x180739E60")]
			[CompilerGenerated]
			private set
			{
				_003CCurrentStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		private bool IsSelling
		{
			[Cpp2IlInjected.Token(Token = "0x60010B6")]
			[Cpp2IlInjected.Address(RVA = "0xE4BC80", Offset = "0xE4A680", VA = "0x180E4BC80")]
			get
			{
				if (_isSell)
				{
					return true;
				}
				return _currentState == StallState.Sell;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010B7")]
		[Cpp2IlInjected.Address(RVA = "0xE4AB60", Offset = "0xE49560", VA = "0x180E4AB60", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0221
			//IL_0089: Expected O, but got I4
			//IL_01b7: Expected O, but got I4
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnExitButton.m_OnClick;
			UnityAction call = OnExitButtonHandler;
			onClick.AddListener(call);
			SlidingPanel slider = _backpackSellContent.Slider;
			SlidingPanel.SlidingPanelEvent value = OnBackPackCancelHandler;
			slider.OnClose += value;
			StallSellInventory backpackSellContent = _backpackSellContent;
			Action onSellComplete = backpackSellContent.OnSellComplete;
			Action b = RefreshCurrencyDisplay;
			Delegate @delegate = Delegate.Combine(onSellComplete, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				backpackSellContent.OnSellComplete = (Action)num;
				GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
				Action onBuyComplete = mcShelfItemInfoContent.OnBuyComplete;
				Action b2 = RefreshCurrencyDisplay;
				Delegate delegate2 = Delegate.Combine(onBuyComplete, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcShelfItemInfoContent.OnBuyComplete = (Action)delegate2;
					GardeningStallShelfItemInfoContent mcShelfItemInfoContent2 = _mcShelfItemInfoContent;
					Action onBuyCancelled = mcShelfItemInfoContent2.OnBuyCancelled;
					Action b3 = UnFocusSelectedEl;
					Delegate delegate3 = Delegate.Combine(onBuyCancelled, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						mcShelfItemInfoContent2.OnBuyCancelled = (Action)delegate3;
						Button.ButtonClickedEvent onClick2 = _btnUpgrade.ButtonComponent.m_OnClick;
						UnityAction call2 = OnUpgradeClickHandler;
						onClick2.AddListener(call2);
						Button.ButtonClickedEvent onClick3 = _btnInfoCancel.m_OnClick;
						UnityAction call3 = OnInfoCancelClickHandler;
						onClick3.AddListener(call3);
						Button.ButtonClickedEvent onClick4 = _btnSellButton.m_OnClick;
						UnityAction call4 = OnSellClickHandler;
						onClick4.AddListener(call4);
						Button.ButtonClickedEvent onClick5 = _btnRefresh.ButtonComponent.m_OnClick;
						UnityAction call5 = OnRefreshClickHandler;
						onClick5.AddListener(call5);
						ShoppingStall shoppingStall = CurrentStall;
						int num2 = 0;
						if (shoppingStall != (UnityEngine.Object)num2)
						{
							ShoppingStall shoppingStall2 = CurrentStall;
							EventHandler<StallShelfInteractionEventArgs> eventHandler = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfInteraction);
							shoppingStall2.add_StallShelfInteractionEvent((EventHandler<>)(object)eventHandler);
							ShoppingStall shoppingStall3 = CurrentStall;
							EventHandler<StallShelfInteractionEventArgs> eventHandler2 = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfHover);
							shoppingStall3.add_StallShelfHoverEvent((EventHandler<>)(object)eventHandler2);
						}
						ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
						ProfileEventDispatcher.ShopItemsRefreshed value2 = OnShopItemsRefreshed;
						_003CDispatcher_003Ek__BackingField.OnShopItemsRefreshed += value2;
						return;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010B8")]
		[Cpp2IlInjected.Address(RVA = "0xE4B5F0", Offset = "0xE49FF0", VA = "0x180E4B5F0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0221
			//IL_0089: Expected O, but got I4
			//IL_01b7: Expected O, but got I4
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnExitButton.m_OnClick;
			UnityAction call = OnExitButtonHandler;
			onClick.RemoveListener(call);
			SlidingPanel slider = _backpackSellContent.Slider;
			SlidingPanel.SlidingPanelEvent value = OnBackPackCancelHandler;
			slider.OnClose -= value;
			StallSellInventory backpackSellContent = _backpackSellContent;
			Action onSellComplete = backpackSellContent.OnSellComplete;
			Action value2 = RefreshCurrencyDisplay;
			Delegate @delegate = Delegate.Remove(onSellComplete, value2);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				backpackSellContent.OnSellComplete = (Action)num;
				GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
				Action onBuyComplete = mcShelfItemInfoContent.OnBuyComplete;
				Action value3 = RefreshCurrencyDisplay;
				Delegate delegate2 = Delegate.Remove(onBuyComplete, value3);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcShelfItemInfoContent.OnBuyComplete = (Action)delegate2;
					GardeningStallShelfItemInfoContent mcShelfItemInfoContent2 = _mcShelfItemInfoContent;
					Action onBuyCancelled = mcShelfItemInfoContent2.OnBuyCancelled;
					Action value4 = UnFocusSelectedEl;
					Delegate delegate3 = Delegate.Remove(onBuyCancelled, value4);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						mcShelfItemInfoContent2.OnBuyCancelled = (Action)delegate3;
						Button.ButtonClickedEvent onClick2 = _btnUpgrade.ButtonComponent.m_OnClick;
						UnityAction call2 = OnUpgradeClickHandler;
						onClick2.RemoveListener(call2);
						Button.ButtonClickedEvent onClick3 = _btnInfoCancel.m_OnClick;
						UnityAction call3 = OnInfoCancelClickHandler;
						onClick3.RemoveListener(call3);
						Button.ButtonClickedEvent onClick4 = _btnSellButton.m_OnClick;
						UnityAction call4 = OnSellClickHandler;
						onClick4.RemoveListener(call4);
						Button.ButtonClickedEvent onClick5 = _btnRefresh.ButtonComponent.m_OnClick;
						UnityAction call5 = OnRefreshClickHandler;
						onClick5.RemoveListener(call5);
						ShoppingStall shoppingStall = CurrentStall;
						int num2 = 0;
						if (shoppingStall != (UnityEngine.Object)num2)
						{
							ShoppingStall shoppingStall2 = CurrentStall;
							EventHandler<StallShelfInteractionEventArgs> eventHandler = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfInteraction);
							shoppingStall2.remove_StallShelfInteractionEvent((EventHandler<>)(object)eventHandler);
							ShoppingStall shoppingStall3 = CurrentStall;
							EventHandler<StallShelfInteractionEventArgs> eventHandler2 = (EventHandler<StallShelfInteractionEventArgs>)(object)new EventHandler<TEventArgs>(OnStallShelfHover);
							shoppingStall3.remove_StallShelfHoverEvent((EventHandler<>)(object)eventHandler2);
						}
						ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
						ProfileEventDispatcher.ShopItemsRefreshed value5 = OnShopItemsRefreshed;
						_003CDispatcher_003Ek__BackingField.OnShopItemsRefreshed -= value5;
						return;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010B9")]
		[Cpp2IlInjected.Address(RVA = "0xE49940", Offset = "0xE48340", VA = "0x180E49940", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//IL_003e: Expected I4, but got O
			base.OnPush(stack, param);
			_isSell = false;
			object[] @params = param.Params;
			int num = 0;
			if (@params != null && @params.Length != 0)
			{
				object obj = @params[0];
				if (obj != null && obj != null)
				{
					object obj2 = obj;
					_isSell = (byte)(int)obj2 != 0;
				}
			}
			StallSellInventory backpackSellContent = _backpackSellContent;
			CancellationToken cancellationToken = (backpackSellContent.CancellationToken = base.CancellationToken);
			Stall stall = SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall;
			if ((object)stall != null)
			{
				int num2 = 0;
			}
			CurrentStall = (ShoppingStall)stall;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010BA")]
		[Cpp2IlInjected.Address(RVA = "0xE48810", Offset = "0xE47210", VA = "0x180E48810")]
		private GardeningStallShelvesContent GetGardeningShelvesContent()
		{
			//Discarded unreachable code: IL_0012
			int num = 0;
			return UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
		}

		[Cpp2IlInjected.Token(Token = "0x60010BB")]
		[Cpp2IlInjected.Address(RVA = "0xE49300", Offset = "0xE47D00", VA = "0x180E49300", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_019d
			//IL_0041: Expected O, but got I4
			//IL_011a: Expected F4, but got I4
			//IL_018e: Expected O, but got I4
			if (_isSell)
			{
				OnSellClickHandler();
			}
			base.OnFocusIn();
			int num = 0;
			UiRoot.Instance._worldCanvas.Show();
			int num2 = 0;
			GardeningStallShelvesContent componentInChildren = UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
			int num3 = 0;
			if (componentInChildren == (UnityEngine.Object)num3 && _currentState != StallState.Sell)
			{
				if (!_isSell)
				{
					AK.Wwise.Event showBuyContentSFX = _showBuyContentSFX;
					if (showBuyContentSFX != null)
					{
						GameObject gameObject = base.gameObject;
						uint num4 = showBuyContentSFX.Post(gameObject);
					}
				}
				int num5 = 0;
				UiRoot instance = UiRoot.Instance;
				ShoppingStall shoppingStall = CurrentStall;
				WorldUI worldCanvas = instance._worldCanvas;
				List<GameObject> shelves = shoppingStall.Shelves;
				Shop shop = shoppingStall.GetShop();
				GridObject _003CGridObject_003Ek__BackingField = ((Stall)CurrentStall).GridObjectScript.GridObject;
				worldCanvas.GardeningShelvesStart((List<>)(object)shelves, shop, _003CGridObject_003Ek__BackingField);
			}
			CurrencyContent[] mcCurrencyContent = _mcCurrencyContent;
			int num6 = 0;
			int num7 = 0;
			int length = mcCurrencyContent.Length;
			if (num7 < length)
			{
				mcCurrencyContent[num6].Show();
				num6++;
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(_btnUpgrade.AnimatedContent);
			GardeningStallSelectionContent mcSelectionContent = _mcSelectionContent;
			int num8 = 0;
			mcSelectionContent.Show(num8);
			CurrencyCost refreshCost = CurrentStall.RefreshCost;
			string text = default(string);
			_btnRefresh.Label.Text = text;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon currencyIcon = _btnRefresh._currencyIcon;
			int _003C_003E1__state = default(int);
			_003CFetchWorldUIReference_003Ed__32 _003CFetchWorldUIReference_003Ed__ = new _003CFetchWorldUIReference_003Ed__32(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFetchWorldUIReference_003Ed__._003C_003E4__this = this;
			_003CFetchWorldUIReference_003Ed__.shelvesContent = componentInChildren;
			Coroutine coroutine = StartCoroutine(_003CFetchWorldUIReference_003Ed__);
			base.IsDataUpToDate = true;
			SimpleSlide currencySlide = _currencySlide;
			int num9 = 0;
			if (currencySlide != (UnityEngine.Object)num9)
			{
				_currencySlide.DoSlideIn();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010BC")]
		[Cpp2IlInjected.Address(RVA = "0xE48520", Offset = "0xE46F20", VA = "0x180E48520")]
		[IteratorStateMachine(typeof(_003CFetchWorldUIReference_003Ed__32))]
		private IEnumerator FetchWorldUIReference(GardeningStallShelvesContent shelvesContent)
		{
			int _003C_003E1__state = default(int);
			_003CFetchWorldUIReference_003Ed__32 _003CFetchWorldUIReference_003Ed__ = new _003CFetchWorldUIReference_003Ed__32(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFetchWorldUIReference_003Ed__._003C_003E4__this = this;
			_003CFetchWorldUIReference_003Ed__.shelvesContent = shelvesContent;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010BD")]
		[Cpp2IlInjected.Address(RVA = "0xE497E0", Offset = "0xE481E0", VA = "0x180E497E0", Slot = "28")]
		public override void OnFocusOut(bool popAfterPreFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0046
			base.OnFocusOut(popAfterPreFocusOut, animate);
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			int num2 = 0;
			UiRoot.Instance._worldCanvas.GardeningShelvesStop();
			int num3 = 0;
			UiRoot.Instance._worldCanvas.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x60010BE")]
		[Cpp2IlInjected.Address(RVA = "0xE4A660", Offset = "0xE49060", VA = "0x180E4A660", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__34))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__34 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__34(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010BF")]
		[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x60010C0")]
		[Cpp2IlInjected.Address(RVA = "0xE49870", Offset = "0xE48270", VA = "0x180E49870")]
		public void OnInfoCancelClickHandler()
		{
			//Discarded unreachable code: IL_0066
			//IL_0019: Expected I4, but got I8
			if (_currentState == StallState.ItemInfo)
			{
				GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
				_currentState = StallState.Selection;
				AK.Wwise.Event hideSFX = mcShelfItemInfoContent._hideSFX;
				mcShelfItemInfoContent.IsVisible = false;
				GameObject gameObject = mcShelfItemInfoContent.gameObject;
				uint num = hideSFX.Post(gameObject);
				GameObject gameObject2 = mcShelfItemInfoContent._mcAnimatedContent.gameObject;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
				_mcSelectionContent.Show(0.25f);
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010C1")]
		[Cpp2IlInjected.Address(RVA = "0xE49B40", Offset = "0xE48540", VA = "0x180E49B40")]
		private void OnRefreshClickHandler()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60010C2")]
		[Cpp2IlInjected.Address(RVA = "0xE4AA10", Offset = "0xE49410", VA = "0x180E4AA10", Slot = "38")]
		[AsyncStateMachine(typeof(_003CRefreshStall_003Ed__38))]
		public Task<ShopRefresh.Types.Response> RefreshStall(CancellationToken ct, bool buyMissingSoftCurrencyWithHardCurrency = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ShopRefresh.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60010C3")]
		[Cpp2IlInjected.Address(RVA = "0xE48E30", Offset = "0xE47830", VA = "0x180E48E30")]
		private void InitRefreshButton()
		{
			//Discarded unreachable code: IL_0032
			CurrencyCost refreshCost = CurrentStall.RefreshCost;
			string text = default(string);
			_btnRefresh.Label.Text = text;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon currencyIcon = _btnRefresh._currencyIcon;
		}

		[Cpp2IlInjected.Token(Token = "0x60010C4")]
		[Cpp2IlInjected.Address(RVA = "0xE49CD0", Offset = "0xE486D0", VA = "0x180E49CD0")]
		private void OnSellClickHandler()
		{
			//Discarded unreachable code: IL_00c8
			//IL_003d: Expected F4, but got I4
			//IL_007b: Expected I4, but got I8
			if (_currentState == StallState.Selection)
			{
				GardeningStallSelectionContent CS_0024_003C_003E8__locals0 = _mcSelectionContent;
				RectTransform mcAnimatedContent = CS_0024_003C_003E8__locals0._mcAnimatedContent;
				int complete = 0;
				int num = DOTween.Kill(mcAnimatedContent, (byte)complete != 0);
				RectTransform mcAnimatedContent2 = CS_0024_003C_003E8__locals0._mcAnimatedContent;
				int num2 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)mcAnimatedContent2, (float)num2, 0.35f)).SetEase(Ease.InBack);
				TweenCallback tweenCallback = delegate
				{
					//Discarded unreachable code: IL_0016
					GameObject gameObject2 = CS_0024_003C_003E8__locals0._mcAnimatedContent.gameObject;
					int active = 0;
					gameObject2.SetActive((byte)active != 0);
				};
				Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				StallSellInventory backpackSellContent = _backpackSellContent;
				_currentState = StallState.Sell;
				backpackSellContent.Slider.Show(andOpen: true);
				AK.Wwise.Event openSFX = _backpackSellContent._openSFX;
				if (openSFX != null)
				{
					GameObject gameObject = base.gameObject;
					uint num3 = openSFX.Post(gameObject);
					StallSellInventory backpackSellContent2 = _backpackSellContent;
				}
				int sellCap = CurrentStall.GetSellCap(1f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010C5")]
		[Cpp2IlInjected.Address(RVA = "0xE4A6E0", Offset = "0xE490E0", VA = "0x180E4A6E0")]
		private void RefreshCurrencyDisplay()
		{
			//Discarded unreachable code: IL_0031
			CurrencyContent[] mcCurrencyContent = _mcCurrencyContent;
			int num = 0;
			int length = mcCurrencyContent.Length;
			if (num < length)
			{
				mcCurrencyContent[num].RefreshDisplay();
				num++;
			}
			RefreshSelectedState();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60010C6")]
		[Cpp2IlInjected.Address(RVA = "0xE4A760", Offset = "0xE49160", VA = "0x180E4A760")]
		private void RefreshSelectedState()
		{
			//Discarded unreachable code: IL_007a, IL_0080, IL_008c
			//IL_001d: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			GardeningStallShelvesContent componentInChildren = UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
			int num3 = 0;
			if (!(componentInChildren != (UnityEngine.Object)num3))
			{
				return;
			}
			ListBase listShelves = componentInChildren._listShelves;
			int num4 = 0;
			if (!(listShelves != (UnityEngine.Object)num4))
			{
				return;
			}
			IEnumerator enumerator = componentInChildren._listShelves.m_Content.GetEnumerator();
			if (enumerator != null)
			{
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					num++;
				}
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				StallShelfPriceButton stallShelfPriceButton = default(StallShelfPriceButton);
				while (!stallShelfPriceButton.IsSelected)
				{
				}
				stallShelfPriceButton.IsSelected = false;
				stallShelfPriceButton.OnHighlightExit();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010C7")]
		[Cpp2IlInjected.Address(RVA = "0xE485B0", Offset = "0xE46FB0", VA = "0x180E485B0")]
		public RectTransform GetCurrentCoinPos()
		{
			//IL_0077: Expected O, but got I4
			CurrencyContent mcMainCurrencyContent = _mcMainCurrencyContent;
			int num = 0;
			if ((object)mcMainCurrencyContent != null)
			{
				ListBase list_currencyItems = mcMainCurrencyContent.list_currencyItems;
				if ((object)list_currencyItems != null)
				{
					RectTransform content = list_currencyItems.m_Content;
					if ((object)content != null)
					{
						int childCount = content.childCount;
					}
				}
				if (num != 0)
				{
					int childCount2 = _mcMainCurrencyContent.list_currencyItems.m_Content.childCount;
					if (num < childCount2)
					{
						FreemiumCurrencyItem component = _mcMainCurrencyContent.list_currencyItems.m_Content.GetChild(num).GetComponent<FreemiumCurrencyItem>();
						int num2 = 0;
						if (component != (UnityEngine.Object)num2)
						{
							Item currencyItem = component.CurrencyItem;
							long num3 = Convert.ToInt64((uint)_currencyCoinType);
						}
						CurrencyContent mcMainCurrencyContent2 = _mcMainCurrencyContent;
						num++;
						Transform transform = default(Transform);
						if ((object)transform == null)
						{
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010C8")]
		[Cpp2IlInjected.Address(RVA = "0xE4A5A0", Offset = "0xE48FA0", VA = "0x180E4A5A0")]
		private void OnUpgradeClickHandler()
		{
			//Discarded unreachable code: IL_0038
			BuildingUpgradePopup.BuildingUpgradePopupParam buildingUpgradePopupParam = new BuildingUpgradePopup.BuildingUpgradePopupParam();
			UpgradableBuilding upgradableBuilding = (buildingUpgradePopupParam.UpgradableBuilding = CurrentStall.GetComponent<UpgradableBuilding>());
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			AsyncMenu upgradePopup = _upgradePopup;
			menuStack.Push(upgradePopup, buildingUpgradePopupParam);
		}

		[Cpp2IlInjected.Token(Token = "0x60010C9")]
		[Cpp2IlInjected.Address(RVA = "0xE48FE0", Offset = "0xE479E0", VA = "0x180E48FE0")]
		private void OnBackPackCancelHandler()
		{
			//Discarded unreachable code: IL_0032
			//IL_0010: Expected I4, but got I8
			//IL_002b: Expected F4, but got I4
			StallSellInventory backpackSellContent = _backpackSellContent;
			_currentState = StallState.Selection;
			backpackSellContent.Slider.Hide();
			GardeningStallSelectionContent mcSelectionContent = _mcSelectionContent;
			int num = 0;
			mcSelectionContent.Show(num);
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60010CA")]
		[Cpp2IlInjected.Address(RVA = "0xE4B1D0", Offset = "0xE49BD0", VA = "0x180E4B1D0")]
		private void SetFocus()
		{
			//IL_002b: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_010f: Expected O, but got I4
			//IL_0129: Expected O, but got I4
			GardeningStallShelvesContent gardeningShelvesContent2;
			int num7;
			do
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					return;
				}
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num2 = 0;
				if (!(focusNavigation != (UnityEngine.Object)num2))
				{
					return;
				}
				StallState currentState = _currentState;
				if (currentState != 0)
				{
					switch (currentState)
					{
					case StallState.Sell:
					{
						GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
						if (mcShelfItemInfoContent.NotEnoughCurrency)
						{
						}
						FocusNavigationElement component = mcShelfItemInfoContent._btnBuy.GetComponent<FocusNavigationElement>();
						base.MenuNavigation.FocusNavigation.SetFocus(component);
						return;
					}
					default:
						return;
					case StallState.Selection:
						break;
					}
					_backpackSellContent.SetFocus();
				}
				GardeningStallShelvesContent gardeningShelvesContent = GetGardeningShelvesContent();
				int num3 = 0;
				if (gardeningShelvesContent == (UnityEngine.Object)num3)
				{
					int num4 = 0;
					UiRoot.Instance._worldCanvas.Show();
					int num5 = 0;
					UiRoot instance2 = UiRoot.Instance;
					ShoppingStall shoppingStall = CurrentStall;
					WorldUI worldCanvas = instance2._worldCanvas;
					List<GameObject> shelves = shoppingStall.Shelves;
					Shop shop = shoppingStall.GetShop();
					GridObject _003CGridObject_003Ek__BackingField = ((Stall)CurrentStall).GridObjectScript.GridObject;
					int num6 = 0;
					worldCanvas.GardeningShelvesStart((List<>)(object)shelves, shop, _003CGridObject_003Ek__BackingField);
				}
				gardeningShelvesContent2 = GetGardeningShelvesContent();
				num7 = 0;
			}
			while (!(gardeningShelvesContent2 != (UnityEngine.Object)num7));
			FocusNavigationElement focusedShelfElement = _focusedShelfElement;
			int num8 = 0;
			if (focusedShelfElement != (UnityEngine.Object)num8)
			{
			}
			RectTransform content = gardeningShelvesContent2._listShelves.m_Content;
			int includeInactive = 0;
			FocusNavigationElement focusNavigationElement = (_focusedShelfElement = content.GetComponentInChildren<FocusNavigationElement>((byte)includeInactive != 0));
			FocusNavigation focusNavigation2 = base.MenuNavigation.FocusNavigation;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010CB")]
		[Cpp2IlInjected.Address(RVA = "0xE4B510", Offset = "0xE49F10", VA = "0x180E4B510")]
		private void UnFocusSelectedEl()
		{
			//Discarded unreachable code: IL_0033
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			FocusNavigationElement focusedShelfElement = _focusedShelfElement;
			int num = 0;
			if (focusedShelfElement != (UnityEngine.Object)num)
			{
				StallShelfPriceButton component = _focusedShelfElement.GetComponent<StallShelfPriceButton>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					component.IsSelected = false;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010CC")]
		[Cpp2IlInjected.Address(RVA = "0xE49180", Offset = "0xE47B80", VA = "0x180E49180")]
		private void OnExitButtonHandler()
		{
			//Discarded unreachable code: IL_0080
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_0077: Expected O, but got I8
			FocusNavigationElement focusedShelfElement = _focusedShelfElement;
			int num = 0;
			if (focusedShelfElement != (UnityEngine.Object)num)
			{
				StallShelfPriceButton component = _focusedShelfElement.GetComponent<StallShelfPriceButton>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					component.IsSelected = false;
				}
			}
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num3 = 0;
			focusNavigation.SetFocus((FocusNavigationElement)num3);
			GameObject gameObject = _backStallIndicator.transform.parent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_focusedShelfElement = (FocusNavigationElement)0;
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60010CD")]
		[Cpp2IlInjected.Address(RVA = "0xE49040", Offset = "0xE47A40", VA = "0x180E49040", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0071
			//IL_0060: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) && _currentState == StallState.Selection)
			{
				_backStallIndicator.transform.parent.gameObject.SetActive(value: true);
				_backStallIndicator.TransformToPreset();
			}
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num2 = 0;
			if (focusNavigation != (UnityEngine.Object)num2)
			{
				RefreshSelectedState();
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010CE")]
		[Cpp2IlInjected.Address(RVA = "0xE49F90", Offset = "0xE48990", VA = "0x180E49F90")]
		public void OnStallShelfHover(object sender, StallShelfInteractionEventArgs e)
		{
			//IL_00cc: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			//IL_00eb: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) || _mcShelfItemInfoContent.IsVisible || _isSell || _currentState == StallState.Sell)
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
					GardeningStallShelvesContent gardeningShelvesContent = GetGardeningShelvesContent();
					if ((object)gardeningShelvesContent != null)
					{
						FocusNavigationElement component = gardeningShelvesContent._listShelves.m_Content.GetChild(num2).GetComponent<FocusNavigationElement>();
					}
					int num3 = 0;
					int num4 = 0;
					GameObject gameObject = default(GameObject);
					if ((UnityEngine.Object)num3 != (UnityEngine.Object)num4 && gameObject.activeInHierarchy)
					{
						base.MenuNavigation.FocusNavigation.SetFocus((FocusNavigationElement)num3);
					}
				}
				return;
			}
			MenuNavigation menuNavigation = default(MenuNavigation);
			FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010CF")]
		[Cpp2IlInjected.Address(RVA = "0xE4A230", Offset = "0xE48C30", VA = "0x180E4A230")]
		public void OnStallShelfInteraction(object sender, StallShelfInteractionEventArgs e)
		{
			//Discarded unreachable code: IL_00f9
			//IL_002e: Expected I4, but got I8
			//IL_00ab: Expected O, but got I4
			if (_isSell || _currentState == StallState.Sell)
			{
				return;
			}
			_currentState = StallState.ItemInfo;
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
			_focusedShelfElement = (FocusNavigationElement)(object)componentInChildren;
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			if (flag && gameObject.activeInHierarchy)
			{
				int num3 = 0;
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				focusNavigation.SetFocus((FocusNavigationElement)num3);
				AK.Wwise.Event @event = onClickStallItem;
				if (@event != null)
				{
					GameObject gameObject2 = focusNavigation.gameObject;
					uint num4 = @event.Post(gameObject2);
				}
			}
			_mcShelfItemInfoContent.Show(0.1f);
			GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
			Action action = OnInfoCancelClickHandler;
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x60010D0")]
		[Cpp2IlInjected.Address(RVA = "0xE49F20", Offset = "0xE48920", VA = "0x180E49F20")]
		private void OnShopItemsRefreshed(string shopName, Item item, CurrencyCost refreshCost, bool isFreeRefresh)
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			GardeningStallShelvesContent componentInChildren = UiRoot.Instance._worldCanvas.GetComponentInChildren<GardeningStallShelvesContent>();
			IEnumerator routine = FetchWorldUIReference(componentInChildren);
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x60010D1")]
		[Cpp2IlInjected.Address(RVA = "0xE48860", Offset = "0xE47260", VA = "0x180E48860", Slot = "39")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//IL_006e: Expected O, but got I4
			//IL_0108: Expected O, but got I4
			//IL_01d6: Expected F4, but got I4
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			if (redirectionType > RedirectionType.GamePromptClose)
			{
				if (redirectionType == RedirectionType.GameClickButtonPlus)
				{
					GardeningStallShelfItemInfoContent mcShelfItemInfoContent = _mcShelfItemInfoContent;
					if (!mcShelfItemInfoContent.IsVisible)
					{
						if (!_backpackSellContent.Slider.isOpened || (object)focusNavigation == null || focusNavigation._focusedElement == null)
						{
							return;
						}
						int num = 0;
						int num2 = 0;
						int num3 = 0;
						InventorySellItem inventorySellItem = default(InventorySellItem);
						if (!(inventorySellItem != (UnityEngine.Object)num3))
						{
							return;
						}
						BaseButton btnAdd = inventorySellItem._btnAdd;
						if (!btnAdd._isActive)
						{
							return;
						}
						Button buttonComponent = btnAdd.ButtonComponent;
					}
					Button buttonComponent2 = mcShelfItemInfoContent._btnAdd.ButtonComponent;
					BaseButton btnAdd2 = _mcShelfItemInfoContent._btnAdd;
				}
				if (redirectionType != RedirectionType.GameClickButtonMinus)
				{
					return;
				}
				GardeningStallShelfItemInfoContent mcShelfItemInfoContent2 = _mcShelfItemInfoContent;
				if (!mcShelfItemInfoContent2.IsVisible)
				{
					if (!_backpackSellContent.Slider.isOpened || (object)focusNavigation == null || focusNavigation._focusedElement == null)
					{
						return;
					}
					int num4 = 0;
					int num5 = 0;
					int num6 = 0;
					InventorySellItem inventorySellItem2 = default(InventorySellItem);
					if (inventorySellItem2 != (UnityEngine.Object)num6)
					{
						BaseButton btnSubtract = inventorySellItem2._btnSubtract;
						if (btnSubtract._isActive)
						{
							Button buttonComponent3 = btnSubtract.ButtonComponent;
							inventorySellItem2._btnSubtract?.ButtonComponent.m_OnClick?.Invoke();
						}
					}
					return;
				}
				Button buttonComponent4 = mcShelfItemInfoContent2._btnSubtract.ButtonComponent;
				BaseButton btnSubtract2 = _mcShelfItemInfoContent._btnSubtract;
			}
			if (redirectionType == RedirectionType.MenuNavGoBackward)
			{
				StallSellInventory backpackSellContent = _backpackSellContent;
				bool flag = default(bool);
				if (backpackSellContent.Slider.isOpened && !backpackSellContent.HasOngoingInventoryAction)
				{
					StallSellInventory backpackSellContent2 = _backpackSellContent;
					int num7 = (int)(_currentState = StallState.Selection);
					backpackSellContent2.Slider.Hide();
					GardeningStallSelectionContent mcSelectionContent = _mcSelectionContent;
					int num8 = 0;
					mcSelectionContent.Show(num8);
					SetFocus();
					OnExitButtonHandler();
				}
				else if (!flag)
				{
					int num9 = 0;
					int num10 = 0;
					int active = 0;
					GameObject gameObject = default(GameObject);
					gameObject.SetActive((byte)active != 0);
				}
				return;
			}
			while (redirectionType != RedirectionType.GamePromptClose)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010D2")]
		[Cpp2IlInjected.Address(RVA = "0xE4BC60", Offset = "0xE4A660", VA = "0x180E4BC60")]
		public GardeningStallMenu()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
