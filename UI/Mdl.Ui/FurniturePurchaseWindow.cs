using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Online;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200072D")]
	public class FurniturePurchaseWindow : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200072E")]
		public delegate void InventoryGridItemPurchased();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400296E")]
		public InventoryGridItemPurchased OnItemPurchased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400296F")]
		public Action OnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002970")]
		[SerializeField]
		private StarComponent _stars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002971")]
		[SerializeField]
		private GameObject _priceBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002972")]
		[SerializeField]
		private AsyncAtlassedIcon _currencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002973")]
		[SerializeField]
		private TextBase _price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002974")]
		[SerializeField]
		private TextBase _purchaseLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002975")]
		[SerializeField]
		private ItemAmountSelector _itemStepper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002976")]
		[SerializeField]
		private BaseButton _purchaseButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002977")]
		[SerializeField]
		private CanvasGroup _purchaseButtonTxtCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002978")]
		[SerializeField]
		private SpriteAtlasImage _purchaseButtonImageLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002979")]
		[SerializeField]
		private SpriteAtlasImage _purchaseButtonImageRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400297A")]
		[SerializeField]
		private CanvasGroup _btnConfirmCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400297B")]
		[SerializeField]
		[Header("Disabled config")]
		private float _disabledBtnBgOpacity = 0.9f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400297C")]
		[SerializeField]
		private float _disabledBtnFgOpacity = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400297D")]
		[SerializeField]
		private AK.Wwise.Event _purchaseSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400297E")]
		[SerializeField]
		private Switch _purchaseSuccededSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400297F")]
		private IItemData _itemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002980")]
		private int _unitPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4002981")]
		[HideInInspector]
		public int CurrentLimitMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002982")]
		[HideInInspector]
		public int CurrentLimitCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002983")]
		private bool _notEnoughCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x4002984")]
		private bool _purchaseLimitReached;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002985")]
		private Item currencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002986")]
		private Profile _profile;

		[Cpp2IlInjected.Token(Token = "0x6002D9A")]
		[Cpp2IlInjected.Address(RVA = "0xE43360", Offset = "0xE41D60", VA = "0x180E43360")]
		public void Awake()
		{
			//IL_0036: Expected O, but got I4
			ItemAmountSelector itemStepper = _itemStepper;
			Action valueChanged = itemStepper.ValueChanged;
			Action b = OnValueChanged;
			Delegate @delegate = Delegate.Combine(valueChanged, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				itemStepper.ValueChanged = (Action)num;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D9B")]
		[Cpp2IlInjected.Address(RVA = "0xE434B0", Offset = "0xE41EB0", VA = "0x180E434B0")]
		public void OnDestroy()
		{
			//IL_0036: Expected O, but got I4
			ItemAmountSelector itemStepper = _itemStepper;
			Action valueChanged = itemStepper.ValueChanged;
			Action value = OnValueChanged;
			Delegate @delegate = Delegate.Remove(valueChanged, value);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				itemStepper.ValueChanged = (Action)num;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D9C")]
		[Cpp2IlInjected.Address(RVA = "0xE43E30", Offset = "0xE42830", VA = "0x180E43E30")]
		public void SetData(IItemData itemData, bool purchaseLimitReached, int? amountMax)
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected I4, but got Unknown
			//IL_009b: Expected O, but got I4
			//IL_0170: Expected I4, but got I8
			int num = 0;
			_itemData = itemData;
			ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
			ItemAmountSelector itemStepper = _itemStepper;
			Action<int?> action = (Action<int?>)(object)new Action<T>(Purchase);
			uint num2 = default(uint);
			itemStepper.Init("", (int)num2, (int)num2, (Nullable<>)amountMax, (Action<>)(object)action, (byte)num != 0, (byte)num != 0);
			ItemAmountSelector itemStepper2 = _itemStepper;
			TextBase purchaseLimit = _purchaseLimit;
			int? amount = itemStepper2._amount;
			if ((object)amount != null)
			{
				int currentLimitCount = CurrentLimitCount;
				currentLimitCount += (_003F?)amount;
			}
			string text = default(string);
			string text2 = default(string);
			string text4 = (purchaseLimit.Text = text + "/" + text2);
			bool flag = default(bool);
			if (flag)
			{
				CurrencyCost currencyCost = Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)num);
				if (currencyCost == null)
				{
					GameObject priceBox = _priceBox;
				}
				Item item = (currencyItem = currencyCost.Item);
				Item item2 = currencyItem;
				ItemAmountSelector itemStepper3 = _itemStepper;
				TextBase price = _price;
				int? amount2 = itemStepper3._amount;
				string text5 = default(string);
				price.Text = text5;
				Client client = default(Client);
				Profile profile = (_profile = client.Profile);
				ProfilePlayer player_2 = _profile.player_;
				Item item3 = currencyItem;
				int genericCurrencyOnly = 0;
				int currencyAmount = player_2.GetCurrencyAmount(item3, (byte)genericCurrencyOnly != 0);
				if ((object)_itemStepper._amount != null)
				{
				}
				bool flag2 = (_notEnoughCurrency = num > currencyAmount);
				_purchaseLimitReached = purchaseLimitReached;
				RefreshBuyButton();
				AsyncAtlassedIcon currencyIcon = _currencyIcon;
				int num3 = (_unitPrice = currencyCost.amount_);
				if ((object)currencyIcon != null)
				{
				}
				ulong num4 = default(ulong);
				_priceBox.SetActive((byte)num4 != 0);
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			}
			StarComponent stars = _stars;
			SetItemData setItemData = default(SetItemData);
			if (setItemData == null)
			{
				GameObject gameObject = stars.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				return;
			}
			GameObject gameObject2 = _stars.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D9D")]
		[Cpp2IlInjected.Address(RVA = "0xE44580", Offset = "0xE42F80", VA = "0x180E44580")]
		public void SetFocus(FocusNavigation focusnav)
		{
			//Discarded unreachable code: IL_001d
			if (!_purchaseLimitReached)
			{
				FocusNavigationElement component = _purchaseButton.GetComponent<FocusNavigationElement>();
				focusnav.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D9E")]
		[Cpp2IlInjected.Address(RVA = "0xE43D80", Offset = "0xE42780", VA = "0x180E43D80")]
		public void ResetUI()
		{
			//Discarded unreachable code: IL_002c
			ItemAmountSelector itemStepper = _itemStepper;
			int currentLimitMax = CurrentLimitMax;
			ItemAmountSelector itemStepper2 = _itemStepper;
			if (currentLimitMax != CurrentLimitCount)
			{
				itemStepper2.EnableButtons();
			}
			else
			{
				itemStepper2.DisableButtons();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D9F")]
		[Cpp2IlInjected.Address(RVA = "0xE43AD0", Offset = "0xE424D0", VA = "0x180E43AD0")]
		public void RefreshBuyButton()
		{
			//Discarded unreachable code: IL_00fe
			_price.ColorKey = UIGameColors.GameColorName.OffWhite;
			if (!_notEnoughCurrency)
			{
			}
			_btnConfirmCanvasGroup.alpha = 1f;
			CanvasGroup purchaseButtonTxtCanvasGroup = _purchaseButtonTxtCanvasGroup;
			float num = (purchaseButtonTxtCanvasGroup.alpha = _disabledBtnFgOpacity);
			Image image = _purchaseButtonImageLeft.Image;
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			UIGameColors gameColors = instance._gameColors;
			UIGameColors gameColors2 = instance._gameColors;
			Image image2 = _purchaseButtonImageRight.Image;
			int num3 = 0;
			UiRoot instance2 = UiRoot.Instance;
			UIGameColors gameColors3 = instance2._gameColors;
			UIGameColors gameColors4 = instance2._gameColors;
			BaseButton purchaseButton = _purchaseButton;
			int num4 = 0;
			if ((_notEnoughCurrency ? 1 : 0) != num4)
			{
			}
			bool flag2 = (purchaseButton.IsActive = (_purchaseLimitReached ? 1 : 0) == num4);
			Selectable selectable = _purchaseButton.Selectable;
			bool interactable = default(bool);
			if (!_notEnoughCurrency)
			{
				interactable = !_purchaseLimitReached;
			}
			selectable.interactable = interactable;
			FocusNavigationElement component = _purchaseButton.GetComponent<FocusNavigationElement>();
			bool flag3 = (component.IgnoreThis = _notEnoughCurrency);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA0")]
		[Cpp2IlInjected.Address(RVA = "0xE43590", Offset = "0xE41F90", VA = "0x180E43590")]
		private void OnValueChanged()
		{
			//Discarded unreachable code: IL_00c5
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
			ItemAmountSelector itemStepper = _itemStepper;
			TextBase purchaseLimit = _purchaseLimit;
			int? amount = itemStepper._amount;
			int num = 0;
			if ((object)amount != null)
			{
				int currentLimitCount = CurrentLimitCount;
				currentLimitCount += (_003F?)amount;
			}
			string text = default(string);
			string text2 = default(string);
			string text4 = (purchaseLimit.Text = text + "/" + text2);
			ItemAmountSelector itemStepper2 = _itemStepper;
			TextBase price = _price;
			int? amount2 = itemStepper2._amount;
			string text5 = default(string);
			price.Text = text5;
			Profile profile = (_profile = SystemRoot.Instance.Client.Profile);
			ProfilePlayer player_ = _profile.player_;
			Item item = currencyItem;
			int genericCurrencyOnly = 0;
			int currencyAmount = player_.GetCurrencyAmount(item, (byte)genericCurrencyOnly != 0);
			if ((object)_itemStepper._amount != null)
			{
			}
			bool flag = (_notEnoughCurrency = num > currencyAmount);
			RefreshBuyButton();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA1")]
		[Cpp2IlInjected.Address(RVA = "0xE43440", Offset = "0xE41E40", VA = "0x180E43440")]
		public void OnClickClose()
		{
			//Discarded unreachable code: IL_0023
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			OnClose?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA2")]
		[Cpp2IlInjected.Address(RVA = "0xE43980", Offset = "0xE42380", VA = "0x180E43980")]
		private void Purchase(int? amount)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA3")]
		[Cpp2IlInjected.Address(RVA = "0xE43880", Offset = "0xE42280", VA = "0x180E43880")]
		[AsyncStateMachine(typeof(_003CPurchaseTask_003Ed__35))]
		private Task PurchaseTask()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnCancelNotEnoughCurrency()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA5")]
		[Cpp2IlInjected.Address(RVA = "0xE43490", Offset = "0xE41E90", VA = "0x180E43490")]
		private void OnCloseNotEnoughCurrency(bool success)
		{
			if (success)
			{
				OnItemPurchased?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DA6")]
		[Cpp2IlInjected.Address(RVA = "0xE445F0", Offset = "0xE42FF0", VA = "0x180E445F0")]
		public FurniturePurchaseWindow()
		{
		}
	}
}
