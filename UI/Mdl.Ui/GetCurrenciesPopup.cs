using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.InputSystem;
using Mdl.Online;
using Mdl.Platform;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200049B")]
	public class GetCurrenciesPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200049C")]
		public class GetCurrenciesParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400180B")]
			public BattlePassSeasonData BattlePassData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400180C")]
			public bool ShouldDisplayBundle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x400180D")]
			public bool IsEventCurrencyPopup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400180E")]
			public Item CurrencyToUse;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400180F")]
			public Item CurrencyToBuy;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4001810")]
			public int CurrentEventCurrencyAmount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001811")]
			public string EventCurrency;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001812")]
			public bool IsNewestEvent = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001813")]
			public BattlePassUIGameColors ColorConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001814")]
			public AssetReferenceTexture IconRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4001815")]
			public AssetReferenceTexture BuyIconRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4001816")]
			public AssetReferenceTexture GlowRef;

			[Cpp2IlInjected.Token(Token = "0x6001E21")]
			[Cpp2IlInjected.Address(RVA = "0xC26650", Offset = "0xC25050", VA = "0x180C26650")]
			public GetCurrenciesParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40017DA")]
		[SerializeField]
		[Header("Button")]
		private BaseButton _btnAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40017DB")]
		[SerializeField]
		private BaseButton _btnSubstract;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40017DC")]
		[SerializeField]
		private BaseButton _btnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40017DD")]
		[SerializeField]
		private BaseButton _btnBuy;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40017DE")]
		[SerializeField]
		private ButtonTmPro _btnBuyMoonstone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40017DF")]
		[SerializeField]
		private RefreshBuyButton _refreshBtnBuy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40017E0")]
		[SerializeField]
		private ToggleButton _offerButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40017E1")]
		[SerializeField]
		[Header("Text")]
		private TextBase _totalAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40017E2")]
		[SerializeField]
		private TextBase _buyAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40017E3")]
		[SerializeField]
		private TextBase _currentPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40017E4")]
		[SerializeField]
		private TextBase _originalPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40017E5")]
		[SerializeField]
		private TextBase _offerMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40017E6")]
		[SerializeField]
		[Header("Image")]
		private RectTransform _offerContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40017E7")]
		[SerializeField]
		private AsyncAtlassedIcon _buyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40017E8")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40017E9")]
		[SerializeField]
		private AsyncAtlassedIcon _totalAmountIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40017EA")]
		[SerializeField]
		private List<AsyncAtlassedIcon> _glowBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40017EB")]
		[SerializeField]
		private Image _totalAmountBGRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40017EC")]
		[SerializeField]
		private Image _totalAmountBGLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40017ED")]
		private GetCurrenciesParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40017EE")]
		private int amountSelected = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40017EF")]
		private int amountOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40017F0")]
		private int currencyToUseBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x40017F1")]
		private int currencyIncrementPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40017F2")]
		private int currencyIncrement = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x40017F3")]
		private int salePrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40017F4")]
		private int bundleAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40017F5")]
		private int minAmountSelected = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40017F6")]
		private int maxAmountSelected = 1000000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40017F7")]
		private bool _isInFocus = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x195")]
		[Cpp2IlInjected.Token(Token = "0x40017F8")]
		private bool shouldDisplayBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40017F9")]
		private float pricePerUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40017FA")]
		private BattlePassUIGameColors colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40017FB")]
		private float _buttonHeldDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40017FC")]
		private bool _subtractButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AD")]
		[Cpp2IlInjected.Token(Token = "0x40017FD")]
		private bool _addButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AE")]
		[Cpp2IlInjected.Token(Token = "0x40017FE")]
		private bool _isDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40017FF")]
		private int _repetitionAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4001800")]
		private bool _justPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001801")]
		[SerializeField]
		private float _holdDurationBeforePress = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4001802")]
		[SerializeField]
		private float _holdClickRepetitionInterval = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001803")]
		[SerializeField]
		private float _holdClickFastRepetitionInterval = 0.07f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001804")]
		[SerializeField]
		private AK.Wwise.Event _purchaseSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4001805")]
		[SerializeField]
		private Switch _purchaseSuccededSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4001806")]
		[SerializeField]
		private Switch _purchaseFailedSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4001807")]
		[Header("Hold config")]
		protected InputAction _inputActionIncrementStick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4001808")]
		protected InputAction _inputActionDecrementStick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4001809")]
		protected InputAction _inputActionIncrementDpad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400180A")]
		protected InputAction _inputActionDecrementDpad;

		[Cpp2IlInjected.Token(Token = "0x170004E8")]
		private bool UseBundlePromo
		{
			[Cpp2IlInjected.Token(Token = "0x6001E02")]
			[Cpp2IlInjected.Address(RVA = "0xE57890", Offset = "0xE56290", VA = "0x180E57890")]
			get
			{
				if (!shouldDisplayBundle)
				{
					int num = 0;
				}
				int num2 = bundleAmount;
				return amountSelected >= num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E9")]
		private int MaxAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6001E03")]
			[Cpp2IlInjected.Address(RVA = "0xE57820", Offset = "0xE56220", VA = "0x180E57820")]
			get
			{
				int a = currencyIncrement;
				int num = default(int);
				int b = currencyIncrement * num;
				return Mathf.Max(a, b);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EA")]
		private int OriginalPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6001E19")]
			[Cpp2IlInjected.Address(RVA = "0xE57870", Offset = "0xE56270", VA = "0x180E57870")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EB")]
		private int CurrentPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6001E1A")]
			[Cpp2IlInjected.Address(RVA = "0xE577C0", Offset = "0xE561C0", VA = "0x180E577C0")]
			get
			{
				int num = amountSelected;
				if (!shouldDisplayBundle)
				{
				}
				if (num < bundleAmount)
				{
					return num;
				}
				return num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E04")]
		[Cpp2IlInjected.Address(RVA = "0xE56790", Offset = "0xE55190", VA = "0x180E56790", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//IL_0136: Expected O, but got I4
			//IL_015b: Expected O, but got I4
			//IL_017d: Expected O, but got I4
			//IL_019f: Expected O, but got I4
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnCancel.ButtonComponent.m_OnClick;
			UnityAction call = OnCancelClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnBuy.ButtonComponent.m_OnClick;
			UnityAction call2 = OnBuyClickHandler;
			onClick2.AddListener(call2);
			if (EventsMenu.Instance._enableBuyMoonstoneBtn)
			{
				Button.ButtonClickedEvent onClick3 = _btnBuyMoonstone.ButtonComponent.m_OnClick;
				UnityAction call3 = OnGetCurrenciesClickHandler;
				onClick3.AddListener(call3);
			}
			ToggleButton offerButton = _offerButton;
			ToggleButton.OnValueChangedDelegate value = OnOfferButtonClick;
			offerButton.OnValueChanged += value;
			BaseButton btnAdd = _btnAdd;
			BaseButton.OnBaseButtonPress value2 = OnAddPressedHandler;
			btnAdd.OnPress += value2;
			BaseButton btnAdd2 = _btnAdd;
			BaseButton.OnBaseButtonRelease value3 = OnAddReleasedHandler;
			btnAdd2.OnRelease += value3;
			BaseButton btnSubstract = _btnSubstract;
			BaseButton.OnBaseButtonPress value4 = OnSubtractPressedHandler;
			btnSubstract.OnPress += value4;
			BaseButton btnSubstract2 = _btnSubstract;
			BaseButton.OnBaseButtonRelease value5 = OnSubtractReleasedHandler;
			btnSubstract2.OnRelease += value5;
			InputTriggerDown trigger = new InputTriggerDown();
			int num = default(int);
			InputActionBool inputActionIncrementStick = new InputActionBool("[LStick Right]", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			_inputActionIncrementStick = inputActionIncrementStick;
			InputTriggerDown trigger2 = new InputTriggerDown();
			int num3 = default(int);
			InputActionBool inputActionDecrementStick = new InputActionBool("[LStick Left]", trigger2, (InputProvider)num3);
			num3 = 0;
			_inputActionDecrementStick = inputActionDecrementStick;
			InputTriggerDown trigger3 = new InputTriggerDown();
			int num4 = default(int);
			InputActionBool inputActionIncrementDpad = new InputActionBool("[DPad Right]", trigger3, (InputProvider)num4);
			num4 = 0;
			_inputActionIncrementDpad = inputActionIncrementDpad;
			InputTriggerDown trigger4 = new InputTriggerDown();
			int num5 = default(int);
			InputActionBool inputActionDecrementDpad = new InputActionBool("[DPad Left]", trigger4, (InputProvider)num5);
			num5 = 0;
			_inputActionDecrementDpad = inputActionDecrementDpad;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E05")]
		[Cpp2IlInjected.Address(RVA = "0xE56ED0", Offset = "0xE558D0", VA = "0x180E56ED0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0122
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnCancel.ButtonComponent.m_OnClick;
			UnityAction call = OnCancelClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnBuy.ButtonComponent.m_OnClick;
			UnityAction call2 = OnBuyClickHandler;
			onClick2.RemoveListener(call2);
			if (EventsMenu.Instance._enableBuyMoonstoneBtn)
			{
				Button.ButtonClickedEvent onClick3 = _btnBuyMoonstone.ButtonComponent.m_OnClick;
				UnityAction call3 = OnGetCurrenciesClickHandler;
				onClick3.RemoveListener(call3);
			}
			ToggleButton offerButton = _offerButton;
			ToggleButton.OnValueChangedDelegate value = OnOfferButtonClick;
			offerButton.OnValueChanged -= value;
			BaseButton btnAdd = _btnAdd;
			BaseButton.OnBaseButtonPress value2 = OnAddPressedHandler;
			btnAdd.OnPress -= value2;
			BaseButton btnAdd2 = _btnAdd;
			BaseButton.OnBaseButtonRelease value3 = OnAddReleasedHandler;
			btnAdd2.OnRelease -= value3;
			BaseButton btnSubstract = _btnSubstract;
			BaseButton.OnBaseButtonPress value4 = OnSubtractPressedHandler;
			btnSubstract.OnPress -= value4;
			BaseButton btnSubstract2 = _btnSubstract;
			BaseButton.OnBaseButtonRelease value5 = OnSubtractReleasedHandler;
			btnSubstract2.OnRelease -= value5;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E06")]
		[Cpp2IlInjected.Address(RVA = "0xE56170", Offset = "0xE54B70", VA = "0x180E56170", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (GetCurrenciesParam)param;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E07")]
		[Cpp2IlInjected.Address(RVA = "0xCABD40", Offset = "0xCAA740", VA = "0x180CABD40", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E08")]
		[Cpp2IlInjected.Address(RVA = "0xE55520", Offset = "0xE53F20", VA = "0x180E55520", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_04f6
			//IL_0131: Expected F4, but got I4
			//IL_018b: Expected F4, but got I4
			//IL_01d7: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_021e: Expected O, but got I4
			//IL_031d: Expected O, but got I4
			//IL_0380: Expected O, but got I4
			//IL_03a3: Expected O, but got I4
			//IL_0410: Expected O, but got I4
			bool flag2 = default(bool);
			ItemType itemType = default(ItemType);
			bool flag3 = default(bool);
			Client client = default(Client);
			TextBase label = default(TextBase);
			bool flag4 = default(bool);
			ItemType itemType2 = default(ItemType);
			Client client2 = default(Client);
			TextBase offerMessage = default(TextBase);
			string arg = default(string);
			int num27 = default(int);
			bool flag5 = default(bool);
			do
			{
				IL_0000:
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				base.OnFocusIn();
				GetCurrenciesParam param = _param;
				if (param == null)
				{
					break;
				}
				int num4 = (currencyIncrement = param.BattlePassData.eventCurrencyIncrement_);
				int num5 = (currencyIncrementPrice = param.BattlePassData.eventCurrencyIncrementPrice_.amount_);
				int num6 = (salePrice = param.BattlePassData.currencyBundlePrice_.amount_);
				int num7 = (bundleAmount = param.BattlePassData.currencyBundleAmount_);
				bool flag = (shouldDisplayBundle = param.ShouldDisplayBundle);
				BattlePassUIGameColors battlePassUIGameColors = (colorConfig = param.ColorConfig);
				amountSelected = num;
				int num8 = (minAmountSelected = currencyIncrement);
				GetCurrenciesParam param2 = _param;
				if (flag2)
				{
					GetCurrenciesParam param3 = _param;
					if (itemType == ItemType.Currency)
					{
						Item currencyToUse = _param.CurrencyToUse;
						if (flag3)
						{
							AsyncAtlassedIcon buyIcon = _buyIcon;
							ProfilePlayer player_ = client.Profile.player_;
							GetCurrenciesParam param4 = _param;
							int genericCurrencyOnly = 0;
							Item currencyToUse2 = param4.CurrencyToUse;
							int num9 = (currencyToUseBalance = player_.GetCurrencyAmount(currencyToUse2, (byte)genericCurrencyOnly != 0));
							int a = currencyIncrement;
							int num10 = Mathf.FloorToInt(num2);
							int b = currencyIncrement * num10;
							int num11 = (maxAmountSelected = Mathf.Max(a, b));
							if ((shouldDisplayBundle ? 1 : 0) != num)
							{
								int num12 = currencyToUseBalance;
								int num13 = salePrice;
								int num14 = (maxAmountSelected = bundleAmount);
								num12 -= num13;
								num11 = num12;
								int num15 = Mathf.FloorToInt(num2);
								num15 = (maxAmountSelected = num15 + num14);
							}
							if (minAmountSelected > num11)
							{
								minAmountSelected = num11;
							}
							int num16 = 0;
							ButtonTmPro btnBuyMoonstone = _btnBuyMoonstone;
							if (num11 != 32)
							{
								label = btnBuyMoonstone.Label;
								int num17 = 0;
								string text = LocalizationManager.FromStringID("menu.button_common_buy", (IResolver)num17);
								int num18 = 0;
								string text2 = LocalizationManager.FromStringID(text, (IResolver)num18);
								string text4 = (label.Text = text + " " + text2);
							}
							RectTransform component = label.GetComponent<RectTransform>();
							int num19 = 0;
							Vector2 sizeDelta = component.sizeDelta;
							component.sizeDelta = (Vector2)num19;
							_btnBuyMoonstone.Label.StringID = "menu.buy_moonstone_switch";
						}
					}
				}
				int num20 = currencyIncrement;
				if (num20 != 0)
				{
					amountSelected = num20;
					int num21 = minAmountSelected;
					int num22 = maxAmountSelected;
					if (num20 > num22)
					{
						amountSelected = num21;
						amountSelected = num22;
					}
				}
				if ((_param.IsEventCurrencyPopup ? 1 : 0) != num)
				{
					goto IL_034a;
				}
				if (flag4)
				{
					GetCurrenciesParam param5 = _param;
					if (itemType2 == ItemType.Currency)
					{
						ProfilePlayer player_2 = client2.Profile.player_;
						GetCurrenciesParam param6 = _param;
						int genericCurrencyOnly2 = 0;
						Item currencyToBuy = param6.CurrencyToBuy;
						int num23 = (amountOwned = player_2.GetCurrencyAmount(currencyToBuy, (byte)genericCurrencyOnly2 != 0));
						AsyncAtlassedIcon icon = _icon;
						Item currencyToBuy2 = _param.CurrencyToBuy;
						AsyncAtlassedIcon totalAmountIcon = _totalAmountIcon;
						Item currencyToBuy3 = _param.CurrencyToBuy;
						if ((shouldDisplayBundle ? 1 : 0) != num)
						{
							offerMessage = _offerMessage;
							int num24 = 0;
							string text5 = LocalizationManager.FromStringID(offerMessage._stringID, (IResolver)num24);
							int num25 = bundleAmount;
							Item currencyToBuy4 = _param.CurrencyToBuy;
							string text7 = (offerMessage.Text = string.Format(text5, text5, arg));
							goto IL_034a;
						}
					}
				}
				goto IL_03fc;
				IL_034a:
				UIGameColors.GameColorName gameColorName = (UIGameColors.GameColorName)(amountOwned = (int)offerMessage.ColorToApply);
				if ((shouldDisplayBundle ? 1 : 0) == num)
				{
					goto IL_0000;
				}
				TextBase offerMessage2 = _offerMessage;
				int num26 = 0;
				string text8 = LocalizationManager.FromStringID(offerMessage2._stringID, (IResolver)num26);
				num27 = bundleAmount;
				GetCurrenciesParam param7 = _param;
				int num28 = 0;
				string arg2 = LocalizationManager.FromStringID(param7.EventCurrency, (IResolver)num28);
				string text10 = (offerMessage2.Text = string.Format(text8, text8, arg2));
				AssetReferenceTexture iconRef = _param.IconRef;
				if (iconRef == null)
				{
					goto IL_0000;
				}
				_totalAmountIcon.SetIconRef(iconRef);
				AssetReferenceTexture buyIconRef = _param.BuyIconRef;
				if (buyIconRef != null)
				{
					_icon.SetIconRef(buyIconRef);
				}
				goto IL_03fc;
				IL_03fc:
				BattlePassUIGameColors battlePassUIGameColors2 = colorConfig;
				int num29 = 0;
				if (battlePassUIGameColors2 != (UnityEngine.Object)num29)
				{
					Image totalAmountBGLeft = _totalAmountBGLeft;
					Image totalAmountBGRight = _totalAmountBGRight;
					BattlePassUIGameColors battlePassUIGameColors3 = colorConfig;
				}
				List<AsyncAtlassedIcon> glowBg = _glowBg;
				if ((IntPtr)_param.GlowRef == (IntPtr)num)
				{
					break;
				}
				if (flag5)
				{
					AssetReferenceTexture glowRef = _param.GlowRef;
				}
			}
			while (num27 != 0);
			GameObject gameObject = _originalPrice.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _offerContainer.gameObject;
			bool active2 = shouldDisplayBundle;
			gameObject2.SetActive(active2);
			ToggleButton offerButton = _offerButton;
			if (!shouldDisplayBundle)
			{
			}
			int num30 = bundleAmount;
			bool flag7 = (offerButton.IsOn = amountSelected >= num30);
			RefreshPrice();
			RefreshCounterDisplay();
			base.IsDataUpToDate = true;
			int num31 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E09")]
		[Cpp2IlInjected.Address(RVA = "0xE56260", Offset = "0xE54C60", VA = "0x180E56260")]
		private void OnSubtractPressedHandler(BaseButton button)
		{
			if (!_isDisabled)
			{
				float num = (_buttonHeldDuration = _holdDurationBeforePress);
				_subtractButtonPressed = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0A")]
		[Cpp2IlInjected.Address(RVA = "0xE56280", Offset = "0xE54C80", VA = "0x180E56280")]
		private void OnSubtractReleasedHandler(BaseButton button)
		{
			//IL_0012: Expected I4, but got I8
			if (!_isDisabled)
			{
				_repetitionAmount = 0;
				_subtractButtonPressed = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0B")]
		[Cpp2IlInjected.Address(RVA = "0xE55100", Offset = "0xE53B00", VA = "0x180E55100")]
		private void OnAddPressedHandler(BaseButton button)
		{
			if (!_isDisabled)
			{
				float num = (_buttonHeldDuration = _holdDurationBeforePress);
				_addButtonPressed = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0C")]
		[Cpp2IlInjected.Address(RVA = "0xE55120", Offset = "0xE53B20", VA = "0x180E55120")]
		private void OnAddReleasedHandler(BaseButton button)
		{
			//IL_0012: Expected I4, but got I8
			if (!_isDisabled)
			{
				_repetitionAmount = 0;
				_addButtonPressed = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0D")]
		[Cpp2IlInjected.Address(RVA = "0xE565B0", Offset = "0xE54FB0", VA = "0x180E565B0")]
		private void RefreshOfferButton()
		{
			//Discarded unreachable code: IL_002c
			ToggleButton offerButton = _offerButton;
			if (!shouldDisplayBundle)
			{
			}
			int num = bundleAmount;
			bool flag2 = (offerButton.IsOn = amountSelected >= num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0E")]
		[Cpp2IlInjected.Address(RVA = "0xE554D0", Offset = "0xE53ED0", VA = "0x180E554D0", Slot = "35")]
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

		[Cpp2IlInjected.Token(Token = "0x6001E0F")]
		[Cpp2IlInjected.Address(RVA = "0xE550D0", Offset = "0xE53AD0", VA = "0x180E550D0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.MenuNavClose || redirectionType == RedirectionType.GamePromptClose)
			{
				OnCancelClickHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E10")]
		[Cpp2IlInjected.Address(RVA = "0xE56130", Offset = "0xE54B30", VA = "0x180E56130")]
		private void OnOfferButtonClick(bool isOn)
		{
			//Discarded unreachable code: IL_0012
			_originalPrice.gameObject.SetActive(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E11")]
		[Cpp2IlInjected.Address(RVA = "0xE55140", Offset = "0xE53B40", VA = "0x180E55140")]
		private void OnBuyClickHandler()
		{
			if (!_isInFocus)
			{
				return;
			}
			int num = amountSelected;
			if (!shouldDisplayBundle)
			{
			}
			if (num < bundleAmount)
			{
			}
			_isInFocus = false;
			if (currencyToUseBalance < num)
			{
				Switch purchaseFailedSwitch = _purchaseFailedSwitch;
				if (purchaseFailedSwitch != null)
				{
					GameObject value = base.gameObject;
					purchaseFailedSwitch.SetValue(value);
				}
				AK.Wwise.Event purchaseSFX = _purchaseSFX;
				if (purchaseSFX != null)
				{
					GameObject gameObject = base.gameObject;
					uint num2 = purchaseSFX.Post(gameObject);
				}
				CancellationToken cancellationToken = base.CancellationToken;
				int num3 = 0;
			}
			CancellationToken cancellationToken2 = base.CancellationToken;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E12")]
		[Cpp2IlInjected.Address(RVA = "0xE56DB0", Offset = "0xE557B0", VA = "0x180E56DB0")]
		[AsyncStateMachine(typeof(_003CShowGetCurrenciesPopup_003Ed__68))]
		public Task ShowGetCurrenciesPopup(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E13")]
		[Cpp2IlInjected.Address(RVA = "0xE54FD0", Offset = "0xE539D0", VA = "0x180E54FD0")]
		[AsyncStateMachine(typeof(_003CConfirmTask_003Ed__69))]
		private Task ConfirmTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E14")]
		[Cpp2IlInjected.Address(RVA = "0xE55450", Offset = "0xE53E50", VA = "0x180E55450")]
		private void OnCancelClickHandler()
		{
			//Discarded unreachable code: IL_0023
			//IL_001a: Expected O, but got I4
			if (_isInFocus)
			{
				_param.AnswerAction((T)(-1));
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E15")]
		[Cpp2IlInjected.Address(RVA = "0xE550F0", Offset = "0xE53AF0", VA = "0x180E550F0")]
		private void OnAddClickHandler()
		{
			int amount = currencyIncrement;
			AddAmount(amount);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E16")]
		[Cpp2IlInjected.Address(RVA = "0xE56250", Offset = "0xE54C50", VA = "0x180E56250")]
		private void OnSubstractClickHandler()
		{
			int amount = currencyIncrement;
			AddAmount(amount);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E17")]
		[Cpp2IlInjected.Address(RVA = "0xE54F40", Offset = "0xE53940", VA = "0x180E54F40")]
		private void AddAmount(int amount)
		{
			//Discarded unreachable code: IL_0067
			if (amount != 0)
			{
				int num = amountSelected;
				int num2 = minAmountSelected;
				int num3 = maxAmountSelected;
				if (num > num3)
				{
					amountSelected = num2;
					amountSelected = num3;
				}
			}
			ToggleButton offerButton = _offerButton;
			if (!shouldDisplayBundle)
			{
			}
			int num4 = bundleAmount;
			bool flag2 = (offerButton.IsOn = amountSelected >= num4);
			RefreshPrice();
			RefreshCounterDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E18")]
		[Cpp2IlInjected.Address(RVA = "0xE56D70", Offset = "0xE55770", VA = "0x180E56D70")]
		private bool SetNextAmount(int amount)
		{
			//IL_002b: Expected I4, but got I8
			ulong num4 = default(ulong);
			while (amount != 0)
			{
				int num = amountSelected;
				int num2 = minAmountSelected;
				int num3 = maxAmountSelected;
				if (num > num3)
				{
					amountSelected = num2;
					amountSelected = (int)num4;
					break;
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1B")]
		[Cpp2IlInjected.Address(RVA = "0xE56600", Offset = "0xE55000", VA = "0x180E56600")]
		private void RefreshPrice()
		{
			//Discarded unreachable code: IL_0064
			TextBase currentPrice = _currentPrice;
			int num = amountSelected;
			if (!shouldDisplayBundle)
			{
			}
			if (num < bundleAmount)
			{
			}
			int num2 = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = default(string);
			currentPrice.Text = text;
			if (shouldDisplayBundle)
			{
				int num3 = amountSelected;
				TextBase originalPrice = _originalPrice;
				int num4 = 0;
				CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
				string text2 = default(string);
				originalPrice.Text = text2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1C")]
		[Cpp2IlInjected.Address(RVA = "0xE562A0", Offset = "0xE54CA0", VA = "0x180E562A0")]
		private void RefreshCounterDisplay()
		{
			//Discarded unreachable code: IL_0137
			//IL_0117: Expected I4, but got I8
			//IL_0117: Expected I4, but got I8
			TextBase buyAmount = _buyAmount;
			int num = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = default(string);
			buyAmount.Text = text;
			int num2 = amountOwned;
			int num3 = 0;
			TextBase totalAmount = _totalAmount;
			CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
			string text2 = default(string);
			totalAmount.Text = text2;
			if (amountSelected == 0)
			{
			}
			int num4 = maxAmountSelected;
			bool flag = minAmountSelected != num4;
			BaseButton btnAdd = _btnAdd;
			_isDisabled = flag;
			CanvasGroup component = btnAdd.GetComponent<CanvasGroup>();
			CanvasGroup component2 = _btnSubstract.GetComponent<CanvasGroup>();
			if (flag)
			{
			}
			component2.alpha = 0.8f;
			component.alpha = 0.8f;
			Button buttonComponent = _btnAdd.ButtonComponent;
			_btnSubstract.ButtonComponent.interactable = flag;
			buttonComponent.interactable = flag;
			int num5 = currencyToUseBalance;
			int num6 = amountSelected;
			if (!shouldDisplayBundle)
			{
			}
			if (num6 < bundleAmount)
			{
			}
			if (!EventsMenu.Instance._enableBuyMoonstoneBtn)
			{
				RefreshBuyButton refreshBtnBuy = _refreshBtnBuy;
				bool greyOut = num5 < (flag ? 1 : 0);
				ulong num7 = default(ulong);
				refreshBtnBuy.GreyOutButton(greyOut, (byte)num7 != 0, (byte)num7 != 0);
			}
			int num8 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1D")]
		[Cpp2IlInjected.Address(RVA = "0xE56CC0", Offset = "0xE556C0", VA = "0x180E56CC0")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0031
			if (_btnBuy.gameObject.activeInHierarchy)
			{
			}
			FocusNavigationElement component = _btnBuyMoonstone.GetComponent<FocusNavigationElement>();
			base.MenuNavigation.FocusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1E")]
		[Cpp2IlInjected.Address(RVA = "0xE57250", Offset = "0xE55C50", VA = "0x180E57250")]
		private void Update()
		{
			//Discarded unreachable code: IL_02bf
			//IL_00fa: Expected I4, but got I8
			//IL_01b6: Invalid comparison between I4 and F4
			while (!_isDisabled)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[4];
				InputAction inputActionIncrementStick = _inputActionIncrementStick;
				if (inputActionIncrementStick != null && array == null)
				{
					continue;
				}
				array[0] = inputActionIncrementStick;
				InputAction inputActionDecrementStick = _inputActionDecrementStick;
				if (inputActionDecrementStick != null && array == null)
				{
					continue;
				}
				array[1] = inputActionDecrementStick;
				InputAction inputActionIncrementDpad = _inputActionIncrementDpad;
				if (inputActionIncrementDpad != null && array == null)
				{
					continue;
				}
				array[2] = inputActionIncrementDpad;
				InputAction inputActionDecrementDpad = _inputActionDecrementDpad;
				if (inputActionDecrementDpad != null && array == null)
				{
					continue;
				}
				array[3] = inputActionDecrementDpad;
				InputAction.UpdateAll(deltaTime, array);
				bool subtractButtonPressed = _subtractButtonPressed;
				if (!subtractButtonPressed && _addButtonPressed == subtractButtonPressed && _inputActionIncrementStick.IsTriggered == subtractButtonPressed && _inputActionDecrementStick.IsTriggered == subtractButtonPressed && _inputActionIncrementDpad.IsTriggered == subtractButtonPressed && _inputActionDecrementDpad.IsTriggered == subtractButtonPressed)
				{
					_justPressed = subtractButtonPressed;
					if (_repetitionAmount > 0)
					{
						_repetitionAmount = 0;
					}
					float holdDurationBeforePress = _holdDurationBeforePress;
					if (_repetitionAmount == 0)
					{
						break;
					}
					_buttonHeldDuration = holdDurationBeforePress;
				}
				if (_repetitionAmount > 0)
				{
					int num2 = amountSelected;
					if ((num2 == maxAmountSelected && (_addButtonPressed || _inputActionIncrementStick.IsTriggered || _inputActionIncrementDpad.IsTriggered)) || (num2 == minAmountSelected && (subtractButtonPressed || _inputActionDecrementStick.IsTriggered != subtractButtonPressed || _inputActionDecrementDpad.IsTriggered != subtractButtonPressed)))
					{
						break;
					}
				}
				float buttonHeldDuration = _buttonHeldDuration;
				int num3 = 0;
				float deltaTime2 = Time.deltaTime;
				int num4 = 0;
				_buttonHeldDuration = buttonHeldDuration;
				if (!((float)num4 >= buttonHeldDuration))
				{
					if (_justPressed)
					{
						break;
					}
					float holdDurationBeforePress2 = _holdDurationBeforePress;
					if (_justPressed)
					{
						_buttonHeldDuration = holdDurationBeforePress2;
					}
					_justPressed = true;
					if (!_subtractButtonPressed && !_inputActionDecrementStick.IsTriggered && !_inputActionDecrementDpad.IsTriggered)
					{
						if (!_addButtonPressed && !_inputActionIncrementStick.IsTriggered && !_inputActionIncrementDpad.IsTriggered)
						{
							break;
						}
						int amount = currencyIncrement;
						AddAmount(amount);
					}
					int amount2 = currencyIncrement;
					AddAmount(amount2);
				}
				if (_subtractButtonPressed || _inputActionDecrementStick.IsTriggered || _inputActionDecrementDpad.IsTriggered || _addButtonPressed || _inputActionIncrementStick.IsTriggered || _inputActionIncrementDpad.IsTriggered)
				{
					int amount3 = currencyIncrement;
					AddAmount(amount3);
				}
				float num5 = (_buttonHeldDuration = _holdClickRepetitionInterval);
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1F")]
		[Cpp2IlInjected.Address(RVA = "0xE56120", Offset = "0xE54B20", VA = "0x180E56120")]
		private void OnGetCurrenciesClickHandler()
		{
			int num = 0;
			PlatformUtils.OpenInventoryStore();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E20")]
		[Cpp2IlInjected.Address(RVA = "0xE57760", Offset = "0xE56160", VA = "0x180E57760")]
		public GetCurrenciesPopup()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0012: Expected I4, but got I8
		//IL_001b: Expected I4, but got I8
		//IL_0028: Expected I4, but got I8

	}
}
