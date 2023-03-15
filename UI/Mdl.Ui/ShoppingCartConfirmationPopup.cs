using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000507")]
	public class ShoppingCartConfirmationPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000508")]
		public struct CartItemHolder
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001B45")]
			public IItemData ItemData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001B46")]
			public ItemState State;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001B47")]
			public int Amount;

			[Cpp2IlInjected.Token(Token = "0x60020D6")]
			[Cpp2IlInjected.Address(RVA = "0x10E5AE0", Offset = "0x10E44E0", VA = "0x1810E5AE0")]
			public CartItemHolder(IItemData itemData, ItemState state, int amount)
			{
				//IL_0009: Expected O, but got I4
				int num = 0;
				State = (ItemState)num;
				Amount = num;
				ItemData = itemData;
				State = state;
				Amount = amount;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001B25")]
		[SerializeField]
		private ButtonTmPro _btnGive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001B26")]
		[SerializeField]
		private ButtonTmPro _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001B27")]
		[SerializeField]
		private ButtonTmPro _btnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001B28")]
		[SerializeField]
		private float _delayBeforeAllowingInputs = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001B29")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001B2A")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001B2B")]
		[SerializeField]
		private TextBase _tfDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001B2C")]
		[SerializeField]
		private TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001B2D")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001B2E")]
		[SerializeField]
		private RectTransform _mcButtonContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001B2F")]
		[SerializeField]
		[Header("Items")]
		private RectTransform _mcShoppingCartItemsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001B30")]
		private GridLayoutGroup _mcGridLayoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001B31")]
		[SerializeField]
		private ShoppingCartItem _cartItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001B32")]
		[SerializeField]
		private ListBase _itemsListBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001B33")]
		[SerializeField]
		[Header("Sizing")]
		private float _singleRowHeight = 483f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x4001B34")]
		[SerializeField]
		private float _doubleRowHeight = 741f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001B35")]
		[SerializeField]
		private float _paddingWidth = 245f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4001B36")]
		[SerializeField]
		private float _minWidth = 835f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001B37")]
		[SerializeField]
		private float _maxWidth = 1230f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001B38")]
		[SerializeField]
		[Header("Sfxs")]
		private AK.Wwise.Event _confirmSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001B39")]
		[SerializeField]
		private AK.Wwise.Event _cancelSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001B3A")]
		private Dictionary<IItemData, int> _itemsPrices = (Dictionary<IItemData, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001B3B")]
		private Dictionary<(IItemData itemData, ItemState state), int> _selectedItemsAndAmount = (Dictionary<(IItemData itemData, ItemState state), int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001B3C")]
		private List<CartItemHolder> _selectedItemsAndAmountList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001B3D")]
		private bool _checkInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001B3E")]
		private new PlayerNavigation.TemporaryOverrideScope _overrideAllScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001B3F")]
		private int _lastRemovedIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4001B40")]
		private Item _currencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001B41")]
		private bool _notEnoughCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001B42")]
		private CanvasGroup _btnConfirmCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001B43")]
		private bool _inputsAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001B44")]
		private Profile _profile;

		[Cpp2IlInjected.Token(Token = "0x60020C1")]
		[Cpp2IlInjected.Address(RVA = "0x143DC10", Offset = "0x143C610", VA = "0x18143DC10", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0192
			//IL_00a3: Expected O, but got I4
			//IL_00d6: Expected I4, but got O
			bool flag = default(bool);
			while (true)
			{
				int num = ((_inputsAllowed = false) ? 1 : 0);
				base.OnPush(stack, param);
				int num2 = 0;
				UiRoot.Instance.UpdateCursorBehaviorForUI();
				Profile profile = (_profile = SystemRoot.Instance.Client.Profile);
				GridLayoutGroup gridLayoutGroup = (_mcGridLayoutGroup = _mcShoppingCartItemsContent.GetComponent<GridLayoutGroup>());
				CanvasGroup canvasGroup = (_btnConfirmCanvasGroup = _btnConfirm.GetComponent<CanvasGroup>());
				MenuParam menuParam = _menuParam;
				if (menuParam == null)
				{
					break;
				}
				object[] @params = menuParam.Params;
				if (@params.Length == 0)
				{
					break;
				}
				object obj = @params[0];
				if (@params[1] != null)
				{
				}
				_tfDesc.StringID = (string)num;
				object[] params2 = _menuParam.Params;
				int length = params2.Length;
				if (params2[2] != null)
				{
				}
				object obj2 = params2[3];
				_checkInventory = (byte)(int)obj2 != 0;
				GameObject gameObject = _btnGive.gameObject;
				bool checkInventory = _checkInventory;
				gameObject.SetActive(checkInventory);
				GameObject gameObject2 = _btnConfirm.gameObject;
				bool active = (_checkInventory ? 1 : 0) == num;
				gameObject2.SetActive(active);
				if ((_checkInventory ? 1 : 0) != num)
				{
					object[] params3 = _menuParam.Params;
					if (params3.Length > 4)
					{
						if (params3[4] != null)
						{
						}
						TextBase tfTitle = _tfTitle;
					}
				}
				_tfTitle.StringID = "menu.store_purchase_confirm";
				TextBase label = _btnConfirm.Label;
				if (obj == null)
				{
					Dictionary<(IItemData, ItemState), int> dictionary = (Dictionary<(IItemData, ItemState), int>)(object)new Dictionary<TKey, TValue>();
				}
				int num3 = 0;
				if (obj != null)
				{
					_selectedItemsAndAmount = (Dictionary<(IItemData itemData, ItemState state), int>)obj;
					Dictionary<(IItemData, ItemState), int> selectedItemsAndAmount = _selectedItemsAndAmount;
					if (!flag)
					{
					}
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020C2")]
		[Cpp2IlInjected.Address(RVA = "0x143D500", Offset = "0x143BF00", VA = "0x18143D500", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_009b
			base.OnFocusIn();
			RefreshShoppingCart();
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcShoppingCartItemsContent);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				bool flag = default(bool);
				if (!flag)
				{
					PlayerNavigation playerNavigation = default(PlayerNavigation);
					PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (_overrideAllScope = playerNavigation.OverrideAllScope());
				}
				SetFocus();
			}
			base.IsDataUpToDate = true;
			ResizeWindow();
			RectTransform content = _content;
			float z = Vector3.zero.z;
			RectTransform content2 = _content;
			float z2 = Vector3.one.z;
			int _003C_003E1__state = default(int);
			_003CDelayedInputsCoroutine_003Ed__35 _003CDelayedInputsCoroutine_003Ed__ = new _003CDelayedInputsCoroutine_003Ed__35(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDelayedInputsCoroutine_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CDelayedInputsCoroutine_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x60020C3")]
		[Cpp2IlInjected.Address(RVA = "0x143D2E0", Offset = "0x143BCE0", VA = "0x18143D2E0")]
		[IteratorStateMachine(typeof(_003CDelayedInputsCoroutine_003Ed__35))]
		private IEnumerator DelayedInputsCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CDelayedInputsCoroutine_003Ed__35 _003CDelayedInputsCoroutine_003Ed__ = new _003CDelayedInputsCoroutine_003Ed__35(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDelayedInputsCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020C4")]
		[Cpp2IlInjected.Address(RVA = "0x143F050", Offset = "0x143DA50", VA = "0x18143F050")]
		public void ResizeWindow()
		{
			//Discarded unreachable code: IL_0043, IL_0058
			//IL_0057: Expected O, but got I4
			int childCount = _mcShoppingCartItemsContent.childCount;
			_mcGridLayoutGroup.constraintCount = 1;
			int childCount2 = _mcShoppingCartItemsContent.childCount;
			GridLayoutGroup mcGridLayoutGroup = _mcGridLayoutGroup;
			float minWidth = _minWidth;
			RectTransform mcContent = _mcContent;
			float singleRowHeight = _singleRowHeight;
		}

		[Cpp2IlInjected.Token(Token = "0x60020C5")]
		[Cpp2IlInjected.Address(RVA = "0x143EFE0", Offset = "0x143D9E0", VA = "0x18143EFE0")]
		[IteratorStateMachine(typeof(_003CResizeForDoubleRow_003Ed__37))]
		private IEnumerator ResizeForDoubleRow()
		{
			int _003C_003E1__state = default(int);
			_003CResizeForDoubleRow_003Ed__37 _003CResizeForDoubleRow_003Ed__ = new _003CResizeForDoubleRow_003Ed__37(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResizeForDoubleRow_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020C6")]
		[Cpp2IlInjected.Address(RVA = "0x143D3E0", Offset = "0x143BDE0", VA = "0x18143D3E0", Slot = "35")]
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

		[Cpp2IlInjected.Token(Token = "0x60020C7")]
		[Cpp2IlInjected.Address(RVA = "0x143F1F0", Offset = "0x143DBF0", VA = "0x18143F1F0")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0027
			if (_checkInventory)
			{
			}
			FocusNavigationElement component = _btnConfirm.GetComponent<FocusNavigationElement>();
			base.MenuNavigation.FocusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60020C8")]
		[Cpp2IlInjected.Address(RVA = "0x143E1D0", Offset = "0x143CBD0", VA = "0x18143E1D0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__40))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__40 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__40(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020C9")]
		[Cpp2IlInjected.Address(RVA = "0x143F4A0", Offset = "0x143DEA0", VA = "0x18143F4A0")]
		public void onConfirmClickHandler()
		{
			//Discarded unreachable code: IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106, IL_010c
			//IL_00bf: Expected O, but got I4
			int num = 0;
			if ((_inputsAllowed ? 1 : 0) == num)
			{
				return;
			}
			AK.Wwise.Event confirmSfx = _confirmSfx;
			if (confirmSfx != null)
			{
				GameObject gameObject = base.gameObject;
				uint num2 = confirmSfx.Post(gameObject);
			}
			Dictionary<IItemData, int> dictionary = (Dictionary<IItemData, int>)(object)new Dictionary<TKey, TValue>();
			Dictionary<IItemData, int> itemsPrices = _itemsPrices;
			bool flag = default(bool);
			if (flag)
			{
				Client client = default(Client);
				ProfilePlayer player_ = client.Profile.player_;
				throw new NullReferenceException();
			}
			switch (((Dictionary<TKey, TValue>)(object)dictionary).Count)
			{
			default:
				if (dictionary == null)
				{
				}
				break;
			case 0:
				break;
			case 1:
			{
				List<Item> productItems = (List<Item>)(object)new List<T>();
				Dictionary<(IItemData, ItemState), int> selectedItemsAndAmount = _selectedItemsAndAmount;
				Action<KeyValuePair<(IItemData, ItemState), int>> action = (Action<KeyValuePair<(IItemData, ItemState), int>>)(object)(Action<T>)delegate
				{
					//Discarded unreachable code: IL_0008
					List<Item> list = productItems;
				};
				MoreLinq.ForEach<KeyValuePair<(IItemData, ItemState), int>>((IEnumerable<>)selectedItemsAndAmount, (Action<>)(object)action);
				int num3 = 0;
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				NotEnoughCurrencyArgs notEnoughCurrencyArgs = new NotEnoughCurrencyArgs();
				int num4 = 0;
				notEnoughCurrencyArgs.ProductItems = (List<Item>)num4;
				IItemData currencyItemData = default(IItemData);
				notEnoughCurrencyArgs.CurrencyItemData = currencyItemData;
				notEnoughCurrencyArgs.CurrencyAmount = 0;
				Action<bool> action2 = (notEnoughCurrencyArgs.Callback = (Action<bool>)(object)new Action<T>(PurchaseSuccessfulHandler));
				break;
			}
			}
			[Cpp2IlInjected.Token(Token = "0x60020D5")]
			[Cpp2IlInjected.Address(RVA = "0x143F280", Offset = "0x143DC80", VA = "0x18143F280")]
			void PurchaseSuccessfulHandler(bool purchaseSucceed)
			{
				//IL_0023: Expected O, but got I4
				PopSelf();
				((Action<T>)(object)_menuParam?.AnswerAction)?.Invoke((T)purchaseSucceed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020CA")]
		[Cpp2IlInjected.Address(RVA = "0x143F400", Offset = "0x143DE00", VA = "0x18143F400")]
		public void onCancelClickHandler()
		{
			//IL_0047: Expected O, but got I4
			if (!_inputsAllowed)
			{
				return;
			}
			AK.Wwise.Event cancelSfx = _cancelSfx;
			if (cancelSfx != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = cancelSfx.Post(gameObject);
			}
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				Action<int> answerAction = menuParam.AnswerAction;
				if (answerAction != null)
				{
					int num2 = 0;
					answerAction((T)num2);
				}
			}
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60020CB")]
		[Cpp2IlInjected.Address(RVA = "0x143D350", Offset = "0x143BD50", VA = "0x18143D350", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0039
			if (redirectionType == RedirectionType.GamePromptClose || redirectionType == RedirectionType.GamePromptGoBackward)
			{
				Button buttonComponent = _btnCancel.ButtonComponent;
				_btnCancel.ButtonComponent.m_OnClick?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020CC")]
		[Cpp2IlInjected.Address(RVA = "0x143D730", Offset = "0x143C130", VA = "0x18143D730")]
		public void OnItemDataHandler(ListBase.ListEventData arg0)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60020CD")]
		[Cpp2IlInjected.Address(RVA = "0x143CE60", Offset = "0x143B860", VA = "0x18143CE60")]
		private void AddItemPrice(KeyValuePair<(IItemData itemData, ItemState state), int> item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60020CE")]
		[Cpp2IlInjected.Address(RVA = "0x143E820", Offset = "0x143D220", VA = "0x18143E820")]
		private void RemoveCartItem(ShoppingCartItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60020CF")]
		[Cpp2IlInjected.Address(RVA = "0x143EB40", Offset = "0x143D540", VA = "0x18143EB40")]
		private void RemoveItemPrice(CartItemHolder cartItem)
		{
			//Discarded unreachable code: IL_0052, IL_005f, IL_006a, IL_007b, IL_008d, IL_00da
			//IL_002d: Expected O, but got I4
			//IL_0075: Expected I4, but got O
			int num = 0;
			if ((_checkInventory ? 1 : 0) != num)
			{
				ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
			}
			bool flag = default(bool);
			if (flag)
			{
				Item item = (_currencyItem = Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)num).Item);
				Item currencyItem = _currencyItem;
				Dictionary<IItemData, int> itemsPrices = _itemsPrices;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020D0")]
		[Cpp2IlInjected.Address(RVA = "0x143E360", Offset = "0x143CD60", VA = "0x18143E360")]
		private void RefreshShoppingCart()
		{
			//Discarded unreachable code: IL_0068
			//IL_003d: Expected O, but got I4
			int num = 0;
			List<CartItemHolder> list = (_selectedItemsAndAmountList = (List<CartItemHolder>)(object)new List<T>(((Dictionary<TKey, TValue>)(object)_selectedItemsAndAmount).Count));
			Dictionary<(IItemData, ItemState), int> selectedItemsAndAmount = _selectedItemsAndAmount;
			bool flag = default(bool);
			if (flag)
			{
				List<CartItemHolder> selectedItemsAndAmountList = _selectedItemsAndAmountList;
				int num2 = 0;
				int num3 = 0;
				((List<T>)(object)selectedItemsAndAmountList).Add((T)num2);
			}
			int num4 = 0;
			UnityAction<ListBase.ListEventData> unityAction = default(UnityAction<ListBase.ListEventData>);
			if ((long)unityAction != -1)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					string text = default(string);
					object obj = text.Clone();
				}
				MenuNavigation menuNavigation = default(MenuNavigation);
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				MenuNavigation menuNavigation2 = default(MenuNavigation);
				FocusNavigation focusNavigation2 = menuNavigation2.FocusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020D1")]
		[Cpp2IlInjected.Address(RVA = "0x143E250", Offset = "0x143CC50", VA = "0x18143E250")]
		public void RefreshBuyButton()
		{
			//Discarded unreachable code: IL_007e
			_tfPrice.ColorKey = UIGameColors.GameColorName.OffWhite;
			CanvasGroup btnConfirmCanvasGroup = _btnConfirmCanvasGroup;
			if (_notEnoughCurrency)
			{
			}
			btnConfirmCanvasGroup.alpha = 1f;
			ButtonTmPro btnConfirm = _btnConfirm;
			bool flag2 = (btnConfirm.IsActive = !_notEnoughCurrency);
			Selectable selectable = _btnConfirm.Selectable;
			bool flag4 = (selectable.interactable = !_notEnoughCurrency);
			FocusNavigationElement component = _btnConfirm.GetComponent<FocusNavigationElement>();
			bool flag5 = (component.IgnoreThis = _notEnoughCurrency);
		}

		[Cpp2IlInjected.Token(Token = "0x60020D2")]
		[Cpp2IlInjected.Address(RVA = "0x143D430", Offset = "0x143BE30", VA = "0x18143D430", Slot = "24")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0027
			base.OnDestroy();
			ListBase.ListEvents onItemData = _itemsListBase.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60020D3")]
		[Cpp2IlInjected.Address(RVA = "0x143F2F0", Offset = "0x143DCF0", VA = "0x18143F2F0")]
		public ShoppingCartConfirmationPopup()
		{
		}//IL_006c: Expected I4, but got I8

	}
}
