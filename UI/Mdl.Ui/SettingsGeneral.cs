using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.Cheats;
using Mdl.Online;
using Mdl.Platform;
using Mdl.Systems;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006A7")]
	public class SettingsGeneral : SettingsMenuPanel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002563")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002564")]
		[SerializeField]
		[Header("Language")]
		private TMP_Dropdown _languageComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002565")]
		[SerializeField]
		private ComboBoxTMP _languageComboBoxTMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002566")]
		[SerializeField]
		private LayoutElement _languageLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002567")]
		[SerializeField]
		private GameObject _languageComboBoxRestartNotice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002568")]
		private Dictionary<string, string> _languages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002569")]
		[SerializeField]
		[Header("User ID")]
		private BaseButton _userIDButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400256A")]
		[SerializeField]
		private TextBase _userIDButtonLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400256B")]
		[SerializeField]
		private TextBase _userID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400256C")]
		[SerializeField]
		private string _showUserIDStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400256D")]
		[SerializeField]
		private string _hideUserIDStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400256E")]
		[SerializeField]
		private int _userIDLabelHeight = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400256F")]
		private bool _isUserIDVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002570")]
		[SerializeField]
		[Header("Save to cloud")]
		private Button _saveToCloudButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002571")]
		[SerializeField]
		private TextBase _saveToCloudStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002572")]
		[SerializeField]
		[Header("Import avatar")]
		private Button _importAvatarButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002573")]
		[SerializeField]
		private AssetReference _importAvatarMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002574")]
		[SerializeField]
		[Header("Reset account / progress")]
		private Button _newGameButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002575")]
		[SerializeField]
		private Button _deleteAccountButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002576")]
		[SerializeField]
		[Header("Promo code")]
		private InputTextBase _promoCodeInputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002577")]
		[SerializeField]
		private BaseButton _claimPromoCodeBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002578")]
		[SerializeField]
		[Header("Other")]
		private float _uiMessageDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002579")]
		[SerializeField]
		private AsyncMenu _popupQRCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400257A")]
		private StartMenu _startMenu;

		[Cpp2IlInjected.Token(Token = "0x17000641")]
		private LocalStorage localStorage
		{
			[Cpp2IlInjected.Token(Token = "0x6002AB9")]
			[Cpp2IlInjected.Address(RVA = "0x12663B0", Offset = "0x1264DB0", VA = "0x1812663B0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance.MetaClient.LocalStorage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000642")]
		private AccountLinkingManager AccLinkMgr
		{
			[Cpp2IlInjected.Token(Token = "0x6002ABA")]
			[Cpp2IlInjected.Address(RVA = "0x85E5A0", Offset = "0x85CFA0", VA = "0x18085E5A0")]
			get
			{
				int num = 0;
				return AccountLinkingManager.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000643")]
		private Profile profile
		{
			[Cpp2IlInjected.Token(Token = "0x6002ABB")]
			[Cpp2IlInjected.Address(RVA = "0x1266470", Offset = "0x1264E70", VA = "0x181266470")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
					if (metaClient != null)
					{
						return metaClient.LocalProfileHolder.profile;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000644")]
		public override FocusNavigationElement FirstFocusNavigationElement
		{
			[Cpp2IlInjected.Token(Token = "0x6002ABC")]
			[Cpp2IlInjected.Address(RVA = "0x1266340", Offset = "0x1264D40", VA = "0x181266340", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_001f
				if (_languageComboBox.gameObject.activeInHierarchy)
				{
				}
				return _userIDButton.GetComponentInChildren<FocusNavigationElement>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABD")]
		[Cpp2IlInjected.Address(RVA = "0x1264CA0", Offset = "0x12636A0", VA = "0x181264CA0")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_01cf
			//IL_0037: Expected O, but got I4
			//IL_01ce: Expected F4, but got I4
			int num = 0;
			StartMenu startMenu = (_startMenu = UiRoot.Instance._menuStack.GetMenu<StartMenu>());
			GameObject gameObject = _newGameButton.gameObject;
			StartMenu startMenu2 = _startMenu;
			int num2 = 0;
			bool active = startMenu2 != (UnityEngine.Object)num2;
			gameObject.SetActive(active);
			TMP_Dropdown.DropdownEvent onValueChanged = _languageComboBox.m_OnValueChanged;
			UnityAction<int> unityAction = (UnityAction<int>)(object)new UnityAction<T0>(OnLanguageChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _newGameButton.m_OnClick;
			UnityAction call = OnNewGamePressed;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _userIDButton.ButtonComponent.m_OnClick;
			UnityAction call2 = OnShowUserIDPressed;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _saveToCloudButton.m_OnClick;
			UnityAction call3 = OnSaveToCloudPressed;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _importAvatarButton.m_OnClick;
			UnityAction call4 = OnImportAvatarPressed;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _claimPromoCodeBtn.ButtonComponent.m_OnClick;
			UnityAction call5 = OnClaimPromoCodePressed;
			onClick5.AddListener(call5);
			TMP_InputField.OnChangeEvent onValueChanged2 = ((TMP_InputField)_promoCodeInputField).m_OnValueChanged;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnPromoCodeValueChanged);
			((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction2);
			int num3 = 0;
			if ((long)unityAction2 != 1)
			{
				int num4 = 0;
				if (unityAction2 != null)
				{
					goto IL_0172;
				}
			}
			GameObject gameObject2 = _importAvatarButton.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			goto IL_0172;
			IL_0172:
			int num5 = 0;
			if ((long)gameObject2 == 1)
			{
				int num6 = 0;
				if (!PlatformUtils.UseSteam())
				{
					int num7 = 0;
					if (!PlatformUtils.UseEpic())
					{
						GameObject gameObject3 = _deleteAccountButton.gameObject;
					}
				}
			}
			GameObject gameObject4 = _deleteAccountButton.gameObject;
			int active3 = 0;
			gameObject4.SetActive((byte)active3 != 0);
			LoadGameSettings();
			int num8 = 0;
			Invoke("SetScrollToTop", num8);
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABE")]
		[Cpp2IlInjected.Address(RVA = "0x1265A40", Offset = "0x1264440", VA = "0x181265A40")]
		private void SetScrollToTop()
		{
			//Discarded unreachable code: IL_0011
			_scrollRect.verticalNormalizedPosition = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABF")]
		[Cpp2IlInjected.Address(RVA = "0x1264930", Offset = "0x1263330", VA = "0x181264930")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_00ff
			TMP_Dropdown.DropdownEvent onValueChanged = _languageComboBox.m_OnValueChanged;
			UnityAction<int> unityAction = (UnityAction<int>)(object)new UnityAction<T0>(OnLanguageChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _newGameButton.m_OnClick;
			UnityAction call = OnNewGamePressed;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _userIDButton.ButtonComponent.m_OnClick;
			UnityAction call2 = OnShowUserIDPressed;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _saveToCloudButton.m_OnClick;
			UnityAction call3 = OnSaveToCloudPressed;
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _importAvatarButton.m_OnClick;
			UnityAction call4 = OnImportAvatarPressed;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _claimPromoCodeBtn.ButtonComponent.m_OnClick;
			UnityAction call5 = OnClaimPromoCodePressed;
			onClick5.RemoveListener(call5);
			TMP_InputField.OnChangeEvent onValueChanged2 = ((TMP_InputField)_promoCodeInputField).m_OnValueChanged;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnPromoCodeValueChanged);
			((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC0")]
		[Cpp2IlInjected.Address(RVA = "0x1264250", Offset = "0x1262C50", VA = "0x181264250", Slot = "5")]
		public override void LoadGameSettings()
		{
			//Discarded unreachable code: IL_01aa
			int num = 0;
			if ((long)"" == 1)
			{
				int num2 = 0;
				if (!PlatformUtils.UseSteam())
				{
					int num3 = 0;
					if (!PlatformUtils.UseEpic())
					{
						GameObject gameObject = _promoCodeInputField.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						GameObject gameObject2 = _claimPromoCodeBtn.gameObject;
						int active2 = 0;
						gameObject2.SetActive((byte)active2 != 0);
					}
				}
			}
			RefreshLanguageComboBox();
			TextBase userID = _userID;
			if (_isUserIDVisible)
			{
				LocalStorage localStorage = this.localStorage;
				if (localStorage != null && ((LocalStorageData)((BaseStorage<DataType>)(object)localStorage).Data).User.OnlineInfo.PlayFabId != null)
				{
				}
			}
			userID.Text = "";
			TextBase userIDButtonLabel = _userIDButtonLabel;
			if (!_isUserIDVisible)
			{
			}
			string text = (userIDButtonLabel.StringID = _hideUserIDStringID);
			UpdateSaveStatus();
			Dictionary<string, string> languages = _languages;
			TMP_Dropdown languageComboBox = _languageComboBox;
			List<string> list = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)languages).get_Keys());
			string languageCode = base.Settings.LanguageCode;
			int num5 = (languageComboBox.value = ((List<T>)(object)list).IndexOf((T)languageCode));
			ComboBoxTMP languageComboBoxTMP = _languageComboBoxTMP;
			bool _003CFontsUnloaded_003Ek__BackingField = FontManager.FontsUnloaded;
			bool flag2 = (languageComboBoxTMP.Interactable = !_003CFontsUnloaded_003Ek__BackingField);
			GameObject languageComboBoxRestartNotice = _languageComboBoxRestartNotice;
			bool active3 = _003CFontsUnloaded_003Ek__BackingField;
			languageComboBoxRestartNotice.SetActive(active3);
			LayoutElement languageLayoutElement = _languageLayoutElement;
			string text2 = ((TMP_InputField)_promoCodeInputField).m_Text;
			BaseButton claimPromoCodeBtn = _claimPromoCodeBtn;
			bool flag4 = (claimPromoCodeBtn.IsActive = 100 == 0);
			Button buttonComponent = _claimPromoCodeBtn.ButtonComponent;
			bool flag6 = (buttonComponent.interactable = !string.IsNullOrEmpty(text2));
			FocusNavigationElement focusNavigationElement = _claimPromoCodeBtn.FocusNavigationElement;
			bool flag7 = (focusNavigationElement.IgnoreThis = string.IsNullOrEmpty(text2));
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC1")]
		[Cpp2IlInjected.Address(RVA = "0x1265880", Offset = "0x1264280", VA = "0x181265880")]
		private void RefreshLanguageComboBox()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC2")]
		[Cpp2IlInjected.Address(RVA = "0x1265320", Offset = "0x1263D20", VA = "0x181265320")]
		private void OnLanguageChangedHandler(int languageIndex)
		{
			//Discarded unreachable code: IL_000e
			GameSettingsSystem settings = base.Settings;
			RefreshLanguageComboBox();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC3")]
		[Cpp2IlInjected.Address(RVA = "0x1265850", Offset = "0x1264250", VA = "0x181265850")]
		public void OnTermOfUsePressed()
		{
			//Discarded unreachable code: IL_0012
			//IL_0011: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int num2 = 0;
			instance.OpenTermOfUse((Action)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC4")]
		[Cpp2IlInjected.Address(RVA = "0x1265190", Offset = "0x1263B90", VA = "0x181265190")]
		public void OnEulaPressed()
		{
			//Discarded unreachable code: IL_0012
			//IL_0011: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int num2 = 0;
			instance.OpenEula((Action)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC5")]
		[Cpp2IlInjected.Address(RVA = "0x1265420", Offset = "0x1263E20", VA = "0x181265420")]
		public void OnPrivacyPolicyPressed()
		{
			//Discarded unreachable code: IL_0012
			//IL_0011: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int num2 = 0;
			instance.OpenPrivacyPolicy((Action)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC6")]
		[Cpp2IlInjected.Address(RVA = "0x1264790", Offset = "0x1263190", VA = "0x181264790")]
		public void OnCookiesPolicyPressed()
		{
			//Discarded unreachable code: IL_0012
			//IL_0011: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int num2 = 0;
			instance.OpenCookiesPolicy((Action)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC7")]
		[Cpp2IlInjected.Address(RVA = "0x12653F0", Offset = "0x1263DF0", VA = "0x1812653F0")]
		public void OnParentalInfoPressed()
		{
			//Discarded unreachable code: IL_0012
			//IL_0011: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int num2 = 0;
			instance.OpenParentalInfo((Action)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC8")]
		[Cpp2IlInjected.Address(RVA = "0x12647F0", Offset = "0x12631F0", VA = "0x1812647F0")]
		public void OnDeleteAccountPressed()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC9")]
		[Cpp2IlInjected.Address(RVA = "0x1264150", Offset = "0x1262B50", VA = "0x181264150")]
		[AsyncStateMachine(typeof(_003CDeleteAccountTask_003Ed__44))]
		private Task DeleteAccountTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACA")]
		[Cpp2IlInjected.Address(RVA = "0x1265A70", Offset = "0x1264470", VA = "0x181265A70")]
		[AsyncStateMachine(typeof(_003CShowPopupErrorConnection_003Ed__45))]
		private Task ShowPopupErrorConnection()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACB")]
		[Cpp2IlInjected.Address(RVA = "0x1264C70", Offset = "0x1263670", VA = "0x181264C70")]
		public void OnDiscordPressed()
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			UiRoot.Instance.OpenDiscord();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACC")]
		[Cpp2IlInjected.Address(RVA = "0x12647C0", Offset = "0x12631C0", VA = "0x1812647C0")]
		public void OnCustomerCarePressed()
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			UiRoot.Instance.OpenCustomerCare();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACD")]
		[Cpp2IlInjected.Address(RVA = "0x12653C0", Offset = "0x1263DC0", VA = "0x1812653C0")]
		public void OnNewGamePressed()
		{
			//Discarded unreachable code: IL_000c
			_startMenu.OnNewGame();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACE")]
		[Cpp2IlInjected.Address(RVA = "0x1265650", Offset = "0x1264050", VA = "0x181265650")]
		public void OnShowUserIDPressed()
		{
			//Discarded unreachable code: IL_00d8
			//IL_00ca: Expected F4, but got I4
			bool isUserIDVisible = _isUserIDVisible;
			TextBase userID = _userID;
			bool flag = (_isUserIDVisible = !isUserIDVisible);
			if (!isUserIDVisible)
			{
				LocalStorage localStorage = this.localStorage;
				if (localStorage != null && ((LocalStorageData)((BaseStorage<DataType>)(object)localStorage).Data).User.OnlineInfo.PlayFabId != null)
				{
				}
			}
			userID.Text = "";
			TextBase userIDButtonLabel = _userIDButtonLabel;
			if (!_isUserIDVisible)
			{
			}
			string text = (userIDButtonLabel.StringID = _hideUserIDStringID);
			Vector2 sizeDelta = _userID.RectTransform.sizeDelta;
			if (_isUserIDVisible)
			{
			}
			VerticalLayoutGroup componentInParent = _userID.GetComponentInParent<VerticalLayoutGroup>();
			RectTransform rectTransform = _userID.RectTransform;
			CanvasGroup component = _userID.GetComponent<CanvasGroup>();
			if (_isUserIDVisible)
			{
			}
			int num = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component, (float)num, 0.1f);
			_userIDButton.Bump();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACF")]
		[Cpp2IlInjected.Address(RVA = "0x12651C0", Offset = "0x1263BC0", VA = "0x1812651C0")]
		private void OnImportAvatarPressed()
		{
			//Discarded unreachable code: IL_003f
			UiRoot instance;
			AssetReference importAvatarMenu;
			object[] array;
			string empty;
			do
			{
				int num = 0;
				instance = UiRoot.Instance;
				importAvatarMenu = _importAvatarMenu;
				array = new object[1];
				empty = string.Empty;
			}
			while (empty != null && array == null);
			array[0] = empty;
			instance.OpenMenu(importAvatarMenu, isPopup: true, waitUntilExit: true, array).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD0")]
		[Cpp2IlInjected.Address(RVA = "0x1265450", Offset = "0x1263E50", VA = "0x181265450")]
		private void OnPromoCodeValueChanged(string arg)
		{
			//Discarded unreachable code: IL_0046
			bool isActive = default(bool);
			_claimPromoCodeBtn.IsActive = isActive;
			Button buttonComponent = _claimPromoCodeBtn.ButtonComponent;
			bool flag2 = (buttonComponent.interactable = !string.IsNullOrEmpty(arg));
			FocusNavigationElement focusNavigationElement = _claimPromoCodeBtn.FocusNavigationElement;
			bool flag3 = (focusNavigationElement.IgnoreThis = string.IsNullOrEmpty(arg));
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD1")]
		[Cpp2IlInjected.Address(RVA = "0x1264600", Offset = "0x1263000", VA = "0x181264600")]
		private void OnClaimPromoCodePressed()
		{
			//Discarded unreachable code: IL_0015
			string text = ((TMP_InputField)_promoCodeInputField).m_Text;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD2")]
		[Cpp2IlInjected.Address(RVA = "0x1264020", Offset = "0x1262A20", VA = "0x181264020")]
		[AsyncStateMachine(typeof(_003CClaimPromoCodeTask_003Ed__53))]
		private Task ClaimPromoCodeTask(string promoCodeId)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD3")]
		[Cpp2IlInjected.Address(RVA = "0x1265500", Offset = "0x1263F00", VA = "0x181265500")]
		private void OnSaveToCloudPressed()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD4")]
		[Cpp2IlInjected.Address(RVA = "0x1266220", Offset = "0x1264C20", VA = "0x181266220")]
		[AsyncStateMachine(typeof(_003CUploadSaveToCloud_003Ed__55))]
		private Task UploadSaveToCloud()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD5")]
		[Cpp2IlInjected.Address(RVA = "0x1265DC0", Offset = "0x12647C0", VA = "0x181265DC0")]
		private void UpdateSaveStatus()
		{
			//Discarded unreachable code: IL_0097, IL_009d, IL_00a3, IL_00a9
			//IL_0045: Expected O, but got I4
			Profile profile = this.profile;
			if (profile != null && (long)profile.gameInfo_ != 0)
			{
				ProfileGameInfo gameInfo_ = this.profile.gameInfo_;
				int num = 0;
				if ((IntPtr)gameInfo_.lastUploadTime_ == (IntPtr)num)
				{
					TextBase saveToCloudStatus = _saveToCloudStatus;
					string text2 = (saveToCloudStatus.Text = LocalizationManager.FromStringID("menu.hud_status_save_to_cloud_never_uploaded", (IResolver)num));
					return;
				}
				DateTime dateTime = this.profile.gameInfo_.modified_.ToDateTime();
				DateTime dateTime2 = this.profile.gameInfo_.lastUploadTime_.ToDateTime();
				if ((object)(dateTime - dateTime2) != null)
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
			}
			TextBase saveToCloudStatus2 = _saveToCloudStatus;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD6")]
		[Cpp2IlInjected.Address(RVA = "0x1265B40", Offset = "0x1264540", VA = "0x181265B40")]
		private void ToggleShortcutIndicator(bool toggle)
		{
			//Discarded unreachable code: IL_006d
			//IL_0011: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int num2 = 0;
			if (!(instance != (UnityEngine.Object)num2))
			{
				return;
			}
			int num3 = 0;
			MainMenuBar _003CMainMenuBar_003Ek__BackingField = UiRoot.Instance.MainMenuBar;
			int num4 = 0;
			if (_003CMainMenuBar_003Ek__BackingField != (UnityEngine.Object)num4)
			{
				int num5 = 0;
				MainMenuShortcutBar shortcutBar = UiRoot.Instance.MainMenuBar.ShortcutBar;
				int num6 = 0;
				if (shortcutBar != (UnityEngine.Object)num6)
				{
					int num7 = 0;
					UiRoot.Instance.MainMenuBar.ShortcutBar.ToggleCloseMenuShortcutIndicator(toggle);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD7")]
		[Cpp2IlInjected.Address(RVA = "0x1266320", Offset = "0x1264D20", VA = "0x181266320")]
		public SettingsGeneral()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
