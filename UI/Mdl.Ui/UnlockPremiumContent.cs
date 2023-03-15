using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004A0")]
	public class UnlockPremiumContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20004A1")]
		public class UnlockPremiumParam : MenuParam
		{
			[Cpp2IlInjected.Token(Token = "0x20004A2")]
			public enum UnlockPremiumDisplayState
			{
				[Cpp2IlInjected.Token(Token = "0x4001851")]
				UnlockPremiumPopup,
				[Cpp2IlInjected.Token(Token = "0x4001852")]
				InGameShopMenu
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001846")]
			public int UnlockPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4001847")]
			public int UnlockPlusPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001848")]
			public Item Currency;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001849")]
			public string EventCurrency;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400184A")]
			public int Offer = -1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400184B")]
			public bool IsNewestEvent = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400184C")]
			public BattlePassSeasonData BattlePassData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400184D")]
			public AssetReferenceTexture BannerRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400184E")]
			public TMP_SpriteAsset CurrencyIconTextRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400184F")]
			public UnlockPremiumDisplayState DisplayState;

			[Cpp2IlInjected.Token(Token = "0x6001E3F")]
			[Cpp2IlInjected.Address(RVA = "0x1362090", Offset = "0x1360A90", VA = "0x181362090")]
			public UnlockPremiumParam()
			{
				//IL_0010: Expected I4, but got I8
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20004A3")]
		public enum UnlockPremiumResult
		{
			[Cpp2IlInjected.Token(Token = "0x4001854")]
			Cancelled = -1,
			[Cpp2IlInjected.Token(Token = "0x4001855")]
			Fail,
			[Cpp2IlInjected.Token(Token = "0x4001856")]
			UnlockSuccess,
			[Cpp2IlInjected.Token(Token = "0x4001857")]
			UnlockAndBuyBundleSuccess,
			[Cpp2IlInjected.Token(Token = "0x4001858")]
			BuyBundleSuccess,
			[Cpp2IlInjected.Token(Token = "0x4001859")]
			RedirectToInGameShop,
			[Cpp2IlInjected.Token(Token = "0x400185A")]
			RedirectToEvents
		}

		[Cpp2IlInjected.Token(Token = "0x20004A4")]
		public delegate void Confirmed(UnlockPremiumResult answer);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001826")]
		[SerializeField]
		[Header("Container")]
		private RectTransform _unlockCostContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001827")]
		[SerializeField]
		private RectTransform _unlockPlusCostContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001828")]
		[SerializeField]
		private RectTransform _buyBundleCostContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001829")]
		[SerializeField]
		[Header("Button")]
		private BaseButton _btnUnlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400182A")]
		[SerializeField]
		private BaseButton _btnUnlockPlus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400182B")]
		[SerializeField]
		private BaseButton _btnBuyBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400182C")]
		[SerializeField]
		private RefreshBuyButton _refreshBtnUnlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400182D")]
		[SerializeField]
		private RefreshBuyButton _refreshBtnUnlockPlus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400182E")]
		[SerializeField]
		private RefreshBuyButton _refreshBtnBuyBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400182F")]
		[SerializeField]
		private ButtonTmPro _btnGetCurrencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001830")]
		[SerializeField]
		private ButtonTmPro _btnEventsRedirect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001831")]
		[SerializeField]
		[Header("Text")]
		private TextBase _message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001832")]
		[SerializeField]
		private TextBase _unlockPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001833")]
		[SerializeField]
		private TextBase _unlockPlusPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001834")]
		[SerializeField]
		private TextBase _unlockPlusOriginalPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001835")]
		[SerializeField]
		private TextBase _buyBundlePrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001836")]
		[SerializeField]
		private TextBase _buyBundleOriginalPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001837")]
		[SerializeField]
		private TextBase _unlockPlusText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001838")]
		[SerializeField]
		private TextBase _unlockText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001839")]
		[SerializeField]
		private TextBase _buyBundleText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400183A")]
		[SerializeField]
		[Header("Image")]
		private AsyncAtlassedIcon _unlockCurrencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400183B")]
		[SerializeField]
		private AsyncAtlassedIcon _unlockPlusCurrencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400183C")]
		[SerializeField]
		private AsyncAtlassedIcon _getCurrencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400183D")]
		[SerializeField]
		private AsyncAtlassedIcon _buyBundleIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400183E")]
		[SerializeField]
		private AsyncAtlassedIcon _banner;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001840")]
		private bool _isInFocus = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001841")]
		private BattlePassSeasonData _battlePassData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001842")]
		private int _currencyOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001843")]
		private UnlockPremiumParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001844")]
		private bool _isPremiumUnlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
		[Cpp2IlInjected.Token(Token = "0x4001845")]
		private bool _isBundlePurchased;

		[Cpp2IlInjected.Token(Token = "0x1400003A")]
		public event Confirmed OnConfirmed
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2C")]
			[Cpp2IlInjected.Address(RVA = "0xCABA10", Offset = "0xCAA410", VA = "0x180CABA10")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001E2D")]
			[Cpp2IlInjected.Address(RVA = "0xCABAB0", Offset = "0xCAA4B0", VA = "0x180CABAB0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E2E")]
		[Cpp2IlInjected.Address(RVA = "0xCAB2F0", Offset = "0xCA9CF0", VA = "0x180CAB2F0")]
		private void Start()
		{
			//Discarded unreachable code: IL_00d3
			Button.ButtonClickedEvent onClick = _btnUnlock.ButtonComponent.m_OnClick;
			UnityAction call = OnUnlockClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnUnlockPlus.ButtonComponent.m_OnClick;
			UnityAction call2 = OnUnlockPlusClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnBuyBundle.ButtonComponent.m_OnClick;
			UnityAction call3 = OnBuyBundleClickHandler;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnEventsRedirect.ButtonComponent.m_OnClick;
			UnityAction call4 = OnEventsRedirectClickHandler;
			onClick4.AddListener(call4);
			if (EventsMenu.Instance._enableBuyMoonstoneBtn)
			{
				Button.ButtonClickedEvent onClick5 = _btnGetCurrencies.ButtonComponent.m_OnClick;
				UnityAction call5 = OnGetCurrenciesClickHandler;
				onClick5.AddListener(call5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E2F")]
		[Cpp2IlInjected.Address(RVA = "0xCAA910", Offset = "0xCA9310", VA = "0x180CAA910")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00d3
			Button.ButtonClickedEvent onClick = _btnUnlock.ButtonComponent.m_OnClick;
			UnityAction call = OnUnlockClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnUnlockPlus.ButtonComponent.m_OnClick;
			UnityAction call2 = OnUnlockPlusClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnBuyBundle.ButtonComponent.m_OnClick;
			UnityAction call3 = OnBuyBundleClickHandler;
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnEventsRedirect.ButtonComponent.m_OnClick;
			UnityAction call4 = OnEventsRedirectClickHandler;
			onClick4.RemoveListener(call4);
			if (EventsMenu.Instance._enableBuyMoonstoneBtn)
			{
				Button.ButtonClickedEvent onClick5 = _btnGetCurrencies.ButtonComponent.m_OnClick;
				UnityAction call5 = OnGetCurrenciesClickHandler;
				onClick5.RemoveListener(call5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E30")]
		[Cpp2IlInjected.Address(RVA = "0xCA9A60", Offset = "0xCA8460", VA = "0x180CA9A60")]
		public unsafe void Init(UnlockPremiumParam param)
		{
			//Discarded unreachable code: IL_02d7, IL_02dc, IL_02f5, IL_036d, IL_0372, IL_038b, IL_03d3
			//IL_01c2: Expected O, but got I4
			//IL_0246: Expected O, but got I4
			//IL_0274: Expected O, but got I4
			//IL_0291: Expected O, but got I4
			string text5 = default(string);
			string text6 = default(string);
			string text7 = default(string);
			bool flag2 = default(bool);
			ItemType itemType = default(ItemType);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			RectTransform component = default(RectTransform);
			List<TMP_SpriteCharacter> list = default(List<TMP_SpriteCharacter>);
			TextMeshProUGUI textComponent = default(TextMeshProUGUI);
			TextBase buyBundleText3 = default(TextBase);
			while (true)
			{
				int num = 0;
				_param = param;
				if (param == null)
				{
					break;
				}
				BattlePassSeasonData battlePassSeasonData = (_battlePassData = param.BattlePassData);
				BattlePassStatesData battlePassStates_ = SystemRoot.Instance.MetaClient.profile.player_.battlePassStates_;
				BattlePassSeasonData battlePassData = _battlePassData;
				MapField<string, BattlePassProgress> progress_ = battlePassStates_.progress_;
				string onlineId_ = battlePassData.onlineId_;
				bool flag = ((MapField<TKey, TValue>)(object)progress_).TryGetValue((TKey)onlineId_, out *(TValue*)num);
				if (flag)
				{
					_isPremiumUnlocked = flag;
					_isBundlePurchased = flag;
				}
				TextBase unlockPrice = _unlockPrice;
				int num2 = 0;
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				string text2 = (unlockPrice.Text = ((int*)num2)->ToString("N0", currentCulture));
				TextBase unlockPlusPrice = _unlockPlusPrice;
				int num3 = 0;
				CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
				string text4 = (unlockPlusPrice.Text = ((int*)num3)->ToString("N0", currentCulture2));
				BattlePassSeasonData battlePassData2 = _battlePassData;
				TextBase buyBundlePrice = _buyBundlePrice;
				int amount_ = battlePassData2.currencyBundlePrice_.amount_;
				int num4 = 0;
				CultureInfo currentCulture3 = CultureInfo.CurrentCulture;
				buyBundlePrice.Text = text5;
				BattlePassSeasonData battlePassData3 = _battlePassData;
				BattlePassSeasonData.Types.Price eventCurrencyIncrementPrice_ = battlePassData3.eventCurrencyIncrementPrice_;
				int currencyBundleAmount_ = battlePassData3.currencyBundleAmount_;
				TextBase buyBundleOriginalPrice = _buyBundleOriginalPrice;
				int num5 = 0;
				CultureInfo currentCulture4 = CultureInfo.CurrentCulture;
				buyBundleOriginalPrice.Text = text6;
				TextBase unlockPlusOriginalPrice = _unlockPlusOriginalPrice;
				int num6 = 0;
				CultureInfo currentCulture5 = CultureInfo.CurrentCulture;
				unlockPlusOriginalPrice.Text = text7;
				if (text7 != null)
				{
					AsyncAtlassedIcon banner = _banner;
				}
				if (flag2)
				{
					int num7 = 0;
					if (itemType == ItemType.Currency)
					{
						int num8 = 0;
						if (flag3)
						{
							AsyncAtlassedIcon unlockCurrencyIcon = _unlockCurrencyIcon;
							AsyncAtlassedIcon unlockPlusCurrencyIcon = _unlockPlusCurrencyIcon;
							AsyncAtlassedIcon getCurrencyIcon = _getCurrencyIcon;
							AsyncAtlassedIcon buyBundleIcon = _buyBundleIcon;
							int num9 = 0;
							ButtonTmPro btnGetCurrencies = _btnGetCurrencies;
							if (flag4)
							{
								continue;
							}
							component = btnGetCurrencies.Label.GetComponent<RectTransform>();
							int num10 = 0;
							Vector2 sizeDelta = component.sizeDelta;
							component.sizeDelta = (Vector2)num10;
							_btnGetCurrencies.Label.StringID = "menu.buy_moonstone_switch";
						}
					}
				}
				GameObject gameObject = _unlockPlusCostContainer.gameObject;
				bool active = !_isPremiumUnlocked;
				gameObject.SetActive(active);
				GameObject gameObject2 = _unlockCostContainer.gameObject;
				bool active2 = !_isPremiumUnlocked;
				gameObject2.SetActive(active2);
				GameObject gameObject3 = _buyBundleCostContainer.gameObject;
				bool active3 = !_isBundlePurchased;
				gameObject3.SetActive(active3);
				int num11 = 0;
				if (component != (UnityEngine.Object)num11)
				{
					TMP_SpriteCharacter tMP_SpriteCharacter = Enumerable.FirstOrDefault<TMP_SpriteCharacter>((IEnumerable<>)list);
					TextBase unlockPlusText = _unlockPlusText;
					string text8 = tMP_SpriteCharacter.m_Name;
					int num12 = 0;
					unlockPlusText.TextComponent.spriteAsset = (TMP_SpriteAsset)num12;
					TextBase buyBundleText = _buyBundleText;
					int num13 = 0;
					textComponent = buyBundleText.TextComponent;
					textComponent.spriteAsset = (TMP_SpriteAsset)num13;
				}
				if (!_isPremiumUnlocked)
				{
					if ((long)TextMeshProUGUI.k_HandleWhiteSpacesMarker > 0 && !_isBundlePurchased)
					{
						_unlockPlusText.StringID = "";
						TextBase unlockPlusText2 = _unlockPlusText;
						Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
						throw new NullReferenceException();
					}
					TextBase unlockText = _unlockText;
				}
				_unlockPlusText.StringID = "menu.shop_starpath_activated";
				_unlockText.StringID = "menu.shop_starpath_activated";
				bool flag5 = !_isBundlePurchased;
				TextBase buyBundleText2 = _buyBundleText;
				if (flag5)
				{
					buyBundleText2.StringID = "";
					buyBundleText3 = _buyBundleText;
					Dictionary<string, object> dictionary2 = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
				buyBundleText3.StringID = "menu.shop_starpath_bundle_purchased";
				break;
			}
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			int currencyOwned = default(int);
			_currencyOwned = currencyOwned;
			UpdateBtnState();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E31")]
		[Cpp2IlInjected.Address(RVA = "0xCAA730", Offset = "0xCA9130", VA = "0x180CAA730")]
		private bool IsEligibleForBundle()
		{
			//Discarded unreachable code: IL_0013
			UnlockPremiumParam param = _param;
			int num = 0;
			return !_isBundlePurchased;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E32")]
		[Cpp2IlInjected.Address(RVA = "0xCA9960", Offset = "0xCA8360", VA = "0x180CA9960")]
		private void GetHardCurrencyAmount()
		{
			//Discarded unreachable code: IL_0042
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			UnlockPremiumParam param = _param;
			ProfilePlayer player_ = profile.player_;
			Item currency = param.Currency;
			int genericCurrencyOnly = 0;
			int num = (_currencyOwned = player_.GetCurrencyAmount(currency, (byte)genericCurrencyOnly != 0));
			UpdateBtnState();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E33")]
		[Cpp2IlInjected.Address(RVA = "0xCAB580", Offset = "0xCA9F80", VA = "0x180CAB580")]
		private void UpdateBtnState()
		{
			//Discarded unreachable code: IL_027e
			UnlockPremiumParam param = _param;
			int unlockPrice = param.UnlockPrice;
			int currencyOwned = _currencyOwned;
			int unlockPlusPrice = param.UnlockPlusPrice;
			int amount_ = param.BattlePassData.currencyBundlePrice_.amount_;
			if (!EventsMenu.Instance._enableBuyMoonstoneBtn || _param.DisplayState == UnlockPremiumParam.UnlockPremiumDisplayState.InGameShopMenu)
			{
				GameObject gameObject = _btnGetCurrencies.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _btnUnlock.gameObject;
				bool active2 = !_isPremiumUnlocked;
				gameObject2.SetActive(active2);
				GameObject gameObject3 = _btnUnlockPlus.gameObject;
				bool active3 = !_isPremiumUnlocked;
				gameObject3.SetActive(active3);
				GameObject gameObject4 = _btnBuyBundle.gameObject;
				if (!_isPremiumUnlocked)
				{
				}
				UnlockPremiumParam param2 = _param;
				int num = 0;
				bool active4 = (_isBundlePurchased ? 1 : 0) == num;
				gameObject4.SetActive(active4);
				UnlockPremiumParam param3 = _param;
				RefreshBuyButton refreshBtnUnlockPlus = _refreshBtnUnlockPlus;
				if (param3.Offer <= 0 || !_isBundlePurchased)
				{
				}
				bool isInsufficient = currencyOwned < unlockPlusPrice;
				bool greyOut = 1 != 0;
				refreshBtnUnlockPlus.GreyOutButton(greyOut, isInsufficient);
				RefreshBuyButton refreshBtnUnlock = _refreshBtnUnlock;
				bool isPremiumUnlocked = _isPremiumUnlocked;
				bool isTransparent = !_isPremiumUnlocked;
				bool isInsufficient2 = currencyOwned < unlockPrice;
				bool greyOut2 = isPremiumUnlocked;
				refreshBtnUnlock.GreyOutButton(greyOut2, isInsufficient2, isTransparent);
				RefreshBuyButton refreshBtnBuyBundle = _refreshBtnBuyBundle;
				if (_param.Offer <= 0 || !_isBundlePurchased)
				{
				}
				bool isTransparent2 = !_isBundlePurchased;
				bool isInsufficient3 = currencyOwned < amount_;
				refreshBtnBuyBundle.GreyOutButton(greyOut2, isInsufficient3, isTransparent2);
			}
			GameObject gameObject5 = _btnGetCurrencies.gameObject;
			int num2 = 0;
			if ((_isPremiumUnlocked ? 1 : 0) != num2)
			{
			}
			if (currencyOwned < unlockPrice)
			{
			}
			bool active5 = currencyOwned < unlockPlusPrice;
			gameObject5.SetActive(active5);
			GameObject gameObject6 = _btnUnlockPlus.gameObject;
			if ((_isPremiumUnlocked ? 1 : 0) != num2)
			{
			}
			UnlockPremiumParam param4 = _param;
			bool active6 = (_isBundlePurchased ? 1 : 0) == num2;
			gameObject6.SetActive(active6);
			GameObject gameObject7 = _btnUnlock.gameObject;
			bool active7 = (_isPremiumUnlocked ? 1 : 0) == num2;
			gameObject7.SetActive(active7);
			GameObject gameObject8 = _btnBuyBundle.gameObject;
			if ((_isPremiumUnlocked ? 1 : 0) == num2)
			{
			}
			UnlockPremiumParam param5 = _param;
			bool active8 = (_isBundlePurchased ? 1 : 0) == num2;
			gameObject8.SetActive(active8);
			GameObject gameObject9 = _btnEventsRedirect.gameObject;
			if (!_isPremiumUnlocked)
			{
			}
			UnlockPremiumParam param6 = _param;
			bool active9 = _isBundlePurchased;
			gameObject9.SetActive(active9);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E34")]
		[Cpp2IlInjected.Address(RVA = "0xCAADB0", Offset = "0xCA97B0", VA = "0x180CAADB0")]
		private void OnUnlockClickHandler()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E35")]
		[Cpp2IlInjected.Address(RVA = "0xCAAF20", Offset = "0xCA9920", VA = "0x180CAAF20")]
		private void OnUnlockPlusClickHandler()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E36")]
		[Cpp2IlInjected.Address(RVA = "0xCAA770", Offset = "0xCA9170", VA = "0x180CAA770")]
		private void OnBuyBundleClickHandler()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E37")]
		[Cpp2IlInjected.Address(RVA = "0xCAAC70", Offset = "0xCA9670", VA = "0x180CAAC70")]
		private void OnGetCurrenciesClickHandler()
		{
			//Discarded unreachable code: IL_0088
			//IL_0011: Expected I4, but got I8
			//IL_005c: Expected I4, but got I8
			//IL_005c: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			InGameShopMenu.InGameShopMenuParam inGameShopMenuParam = new InGameShopMenu.InGameShopMenuParam();
			int num = 0;
			inGameShopMenuParam.TabRedirect = InGameShopMenu.InGameShopTabType.HardCurrency;
			bool activeInHierarchy = UiRoot.Instance.MainMenuBar.gameObject.activeInHierarchy;
			int num2 = 0;
			if (!activeInHierarchy)
			{
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				int num3 = 0;
				int num4 = 0;
				ulong num5 = default(ulong);
				redirection.Redirect(RedirectionType.MenuInGameShop, inGameShopMenuParam, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num5 != 0);
			}
			UiRoot.Instance.MainMenuBar.RedirectFromType(RedirectionType.MenuInGameShop, inGameShopMenuParam);
			this.OnConfirmed?.Invoke(UnlockPremiumResult.RedirectToInGameShop);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E38")]
		[Cpp2IlInjected.Address(RVA = "0xCAABA0", Offset = "0xCA95A0", VA = "0x180CAABA0")]
		private void OnEventsRedirectClickHandler()
		{
			//Discarded unreachable code: IL_006f
			//IL_004f: Expected I4, but got I8
			//IL_004f: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			int num = 0;
			bool activeInHierarchy = UiRoot.Instance.MainMenuBar.gameObject.activeInHierarchy;
			int num2 = 0;
			if (!activeInHierarchy)
			{
				RedirectionManager redirection = UiRoot.Instance.Redirection;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				ulong num6 = default(ulong);
				redirection.Redirect(RedirectionType.MenuEvents, (MenuParam)num5, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num6 != 0);
			}
			else
			{
				MainMenuBar _003CMainMenuBar_003Ek__BackingField = UiRoot.Instance.MainMenuBar;
				int num7 = 0;
				_003CMainMenuBar_003Ek__BackingField.RedirectFromType(RedirectionType.MenuEvents, (MenuParam)num7);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E39")]
		[Cpp2IlInjected.Address(RVA = "0xCA9830", Offset = "0xCA8230", VA = "0x180CA9830")]
		[AsyncStateMachine(typeof(_003CConfirmUnlockTask_003Ed__48))]
		private Task ConfirmUnlockTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3A")]
		[Cpp2IlInjected.Address(RVA = "0xCA95D0", Offset = "0xCA7FD0", VA = "0x180CA95D0")]
		[AsyncStateMachine(typeof(_003CConfirmBuyBundleTask_003Ed__49))]
		private Task ConfirmBuyBundleTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3B")]
		[Cpp2IlInjected.Address(RVA = "0xCA9700", Offset = "0xCA8100", VA = "0x180CA9700")]
		[AsyncStateMachine(typeof(_003CConfirmUnlockPlusTask_003Ed__50))]
		private Task ConfirmUnlockPlusTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3C")]
		[Cpp2IlInjected.Address(RVA = "0xCAA8E0", Offset = "0xCA92E0", VA = "0x180CAA8E0")]
		private void OnCancelClickHandler()
		{
			if (_isInFocus)
			{
				this.OnConfirmed?.Invoke(UnlockPremiumResult.Cancelled);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3D")]
		[Cpp2IlInjected.Address(RVA = "0xCAB090", Offset = "0xCA9A90", VA = "0x180CAB090")]
		public void SetFocus(FocusNavigation focusNav)
		{
			//Discarded unreachable code: IL_00d2
			if (!_btnUnlock.gameObject.activeInHierarchy || _btnUnlock.ButtonComponent.IsInteractable())
			{
			}
			if (!_btnGetCurrencies.gameObject.activeInHierarchy || _btnGetCurrencies.ButtonComponent.IsInteractable())
			{
			}
			if (!_btnUnlockPlus.gameObject.activeInHierarchy || _btnUnlockPlus.ButtonComponent.IsInteractable())
			{
			}
			if (!_btnBuyBundle.gameObject.activeInHierarchy || _btnBuyBundle.ButtonComponent.IsInteractable())
			{
			}
			if (_btnEventsRedirect.gameObject.activeInHierarchy && _btnEventsRedirect.ButtonComponent.IsInteractable())
			{
				FocusNavigationElement component = _btnEventsRedirect.GetComponent<FocusNavigationElement>();
				focusNav.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E3E")]
		[Cpp2IlInjected.Address(RVA = "0xCABA00", Offset = "0xCAA400", VA = "0x180CABA00")]
		public UnlockPremiumContent()
		{
		}
	}
}
