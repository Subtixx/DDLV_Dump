using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Mdl.Platform;
using Mdl.Utils;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004DB")]
	[RequiredAllNotNull]
	public class DisclaimerPrompt : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20004DC")]
		public class DisclaimerPromptParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40019B9")]
			public Action OnAcceptButton;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40019BA")]
			public bool ContentOnly;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40019BB")]
			public DisclaimerState MenuState;

			[Cpp2IlInjected.Token(Token = "0x6001FB9")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public DisclaimerPromptParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400199D")]
		protected DisclaimerPromptParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400199E")]
		[SerializeField]
		private CanvasGroup _animatedContentCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400199F")]
		[SerializeField]
		private TextBase _body;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40019A0")]
		[SerializeField]
		protected Button _btnAccept;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40019A1")]
		[SerializeField]
		[Header("Legal Content")]
		protected Button _btnOk;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40019A2")]
		[SerializeField]
		private GameObject _legalContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40019A3")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40019A4")]
		[SerializeField]
		private Transform _scrollRectContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40019A5")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40019A6")]
		[SerializeField]
		[Tooltip("Leave unset to keep the original text")]
		[Header("Text ID")]
		private string _bodyID = "menu.disclaimer_text";

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40019A7")]
		[SerializeField]
		private string _bodyIDPS4 = "menu.disclaimer_text_ps4";

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40019A8")]
		[SerializeField]
		private string _bodyIDPS5 = "menu.disclaimer_text_ps5";

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40019A9")]
		[SerializeField]
		private string _bodyIDSwitch = "menu.disclaimer_text_switch";

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40019AA")]
		[Space]
		[SerializeField]
		private string _eulaTitleID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40019AB")]
		[SerializeField]
		private string _touTitleID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40019AC")]
		[SerializeField]
		private string _privacyTitleID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40019AD")]
		[SerializeField]
		private string _cookiesTitleID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40019AE")]
		[SerializeField]
		private string _parentalInfoTitleID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40019AF")]
		[Space]
		[SerializeField]
		private string _psEulaSpiea = "menu.disclaimer_ps_siea";

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40019B0")]
		[SerializeField]
		private string _psEulaSpiee = "menu.disclaimer_ps_siee";

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40019B1")]
		[SerializeField]
		[Header("Contents")]
		private GameObject _eulaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40019B2")]
		[SerializeField]
		private GameObject _touContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40019B3")]
		[SerializeField]
		private GameObject _privacyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40019B4")]
		[SerializeField]
		private GameObject _cookiesContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40019B5")]
		[SerializeField]
		private GameObject _parentalInfoContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40019B6")]
		[SerializeField]
		[Header("blockers")]
		private GameObject _mainBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40019B7")]
		[SerializeField]
		private GameObject _contentBlocker;

		[Cpp2IlInjected.Token(Token = "0x40019B8")]
		public const string DISCLAIMER_AGREED = "DisclaimerAgreed";

		[Cpp2IlInjected.Token(Token = "0x6001FA6")]
		[Cpp2IlInjected.Address(RVA = "0x12BE420", Offset = "0x12BCE20", VA = "0x1812BE420")]
		private void Awake()
		{
			//Discarded unreachable code: IL_003b
			if (!string.IsNullOrWhiteSpace(_bodyID))
			{
				int num = 0;
				TextBase body = _body;
				RuntimePlatform runtimePlatform = PlatformUtils.GetRuntimePlatform();
				if (runtimePlatform == RuntimePlatform.PS4)
				{
				}
				if (runtimePlatform == RuntimePlatform.Switch)
				{
				}
				if (runtimePlatform == RuntimePlatform.PS5)
				{
				}
				string text = (body.StringID = _bodyID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA7")]
		[Cpp2IlInjected.Address(RVA = "0x12BF4C0", Offset = "0x12BDEC0", VA = "0x1812BF4C0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0012
			UnityAction call = default(UnityAction);
			_btnAccept.m_OnClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA8")]
		[Cpp2IlInjected.Address(RVA = "0x12BF7C0", Offset = "0x12BE1C0", VA = "0x1812BF7C0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0012
			UnityAction call = default(UnityAction);
			_btnAccept.m_OnClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA9")]
		[Cpp2IlInjected.Address(RVA = "0x12BE850", Offset = "0x12BD250", VA = "0x1812BE850", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_008a
			//IL_0063: Expected I4, but got I8
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (DisclaimerPromptParam)param;
				}
			}
			DisclaimerPromptParam param2 = _param;
			if (param2.ContentOnly)
			{
				DisclaimerState menuState = param2.MenuState;
				if (param2.ContentOnly)
				{
					if (param2.ContentOnly)
					{
						if (param2.ContentOnly)
						{
							if (param2.ContentOnly)
							{
								if (menuState != DisclaimerState.EULA)
								{
									param2.MenuState = DisclaimerState.NONE;
								}
								OpenParentalInfo();
							}
							OpenCookiesPolicy();
						}
						OpenPrivacyPolicy();
					}
					OpenTermOfUse();
				}
				OpenEula();
			}
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAA")]
		[Cpp2IlInjected.Address(RVA = "0x12BF5D0", Offset = "0x12BDFD0", VA = "0x1812BF5D0", Slot = "39")]
		public virtual void SetFocus()
		{
			//Discarded unreachable code: IL_0064
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				DisclaimerState menuState = _param.MenuState;
				if (menuState == DisclaimerState.NONE)
				{
				}
				if (menuState <= DisclaimerState.COOKIES)
				{
					FocusNavigationElement component = _btnOk.GetComponent<FocusNavigationElement>();
					base.MenuNavigation?.FocusNavigation?.SetFocus(component);
				}
				BaseUiRoot.Instance.HideHud();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAB")]
		[Cpp2IlInjected.Address(RVA = "0x12BE820", Offset = "0x12BD220", VA = "0x1812BE820", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAC")]
		[Cpp2IlInjected.Address(RVA = "0x12BE730", Offset = "0x12BD130", VA = "0x1812BE730")]
		private void OnClickButton(Action callback)
		{
			//Discarded unreachable code: IL_0021
			_stack.Pop();
			callback?.Invoke();
			IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAD")]
		[Cpp2IlInjected.Address(RVA = "0x12BE5B0", Offset = "0x12BCFB0", VA = "0x1812BE5B0", Slot = "40")]
		protected virtual void OnAcceptButton()
		{
			//Discarded unreachable code: IL_0051
			JToken value = true;
			UILocalStorage.Set("DisclaimerAgreed", value);
			int num = 0;
			bool flag = UILocalStorage.Save();
			_stack.Pop();
			_param?.OnAcceptButton?.Invoke();
			IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAF")]
		[Cpp2IlInjected.Address(RVA = "0x12BF190", Offset = "0x12BDB90", VA = "0x1812BF190")]
		public void OpenTermOfUse()
		{
			//Discarded unreachable code: IL_00c0
			//IL_000e: Expected I4, but got I8
			//IL_004d: Expected F4, but got I4
			_param.MenuState = DisclaimerState.TOU;
			DisclaimerPromptParam param = _param;
			GameObject mainBlocker = _mainBlocker;
			bool active = !param.ContentOnly;
			mainBlocker.SetActive(active);
			DisclaimerPromptParam param2 = _param;
			CanvasGroup animatedContentCG = _animatedContentCG;
			bool contentOnly = param2.ContentOnly;
			animatedContentCG.alpha = (contentOnly ? 1 : 0);
			TextBase title = _title;
			string text = (title.StringID = _touTitleID);
			_contentBlocker.SetActive(value: true);
			_legalContent.SetActive(value: true);
			GameObject touContent = _touContent;
			Transform scrollRectContent = _scrollRectContent;
			GameObject gameObject = UnityEngine.Object.Instantiate(touContent, scrollRectContent);
			int _003C_003E1__state = default(int);
			_003CResetScrollRectPos_003Ed__45 _003CResetScrollRectPos_003Ed__ = new _003CResetScrollRectPos_003Ed__45(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetScrollRectPos_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResetScrollRectPos_003Ed__);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB0")]
		[Cpp2IlInjected.Address(RVA = "0x12BEB80", Offset = "0x12BD580", VA = "0x1812BEB80")]
		public void OpenEula()
		{
			//Discarded unreachable code: IL_0111
			//IL_000e: Expected I4, but got I8
			//IL_004d: Expected F4, but got I4
			//IL_00d0: Expected O, but got I4
			_param.MenuState = DisclaimerState.EULA;
			DisclaimerPromptParam param = _param;
			GameObject mainBlocker = _mainBlocker;
			bool active = !param.ContentOnly;
			mainBlocker.SetActive(active);
			DisclaimerPromptParam param2 = _param;
			CanvasGroup animatedContentCG = _animatedContentCG;
			bool contentOnly = param2.ContentOnly;
			animatedContentCG.alpha = (contentOnly ? 1 : 0);
			TextBase title = _title;
			string text = (title.StringID = _eulaTitleID);
			_contentBlocker.SetActive(value: true);
			_legalContent.SetActive(value: true);
			GameObject eulaContent = _eulaContent;
			Transform scrollRectContent = _scrollRectContent;
			TextBase component = UnityEngine.Object.Instantiate(eulaContent, scrollRectContent).GetComponent<TextBase>();
			int num = 0;
			if ((long)component != 38)
			{
				int num2 = 0;
				if ((long)component != 25)
				{
					goto IL_00ea;
				}
			}
			component.RefreshText();
			string stringID = component._stringID;
			int num3 = 0;
			string text3 = (component.Text = LocalizationManager.FromStringID(stringID, (IResolver)num3) + "\n\n" + "");
			goto IL_00ea;
			IL_00ea:
			int _003C_003E1__state = default(int);
			_003CResetScrollRectPos_003Ed__45 _003CResetScrollRectPos_003Ed__ = new _003CResetScrollRectPos_003Ed__45(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetScrollRectPos_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResetScrollRectPos_003Ed__);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB1")]
		[Cpp2IlInjected.Address(RVA = "0x12BEFC0", Offset = "0x12BD9C0", VA = "0x1812BEFC0")]
		public void OpenPrivacyPolicy()
		{
			//Discarded unreachable code: IL_00c0
			//IL_000e: Expected I4, but got I8
			//IL_004d: Expected F4, but got I4
			_param.MenuState = DisclaimerState.PRIVACY_POLICY;
			DisclaimerPromptParam param = _param;
			GameObject mainBlocker = _mainBlocker;
			bool active = !param.ContentOnly;
			mainBlocker.SetActive(active);
			DisclaimerPromptParam param2 = _param;
			CanvasGroup animatedContentCG = _animatedContentCG;
			bool contentOnly = param2.ContentOnly;
			animatedContentCG.alpha = (contentOnly ? 1 : 0);
			TextBase title = _title;
			string text = (title.StringID = _privacyTitleID);
			_contentBlocker.SetActive(value: true);
			_legalContent.SetActive(value: true);
			GameObject privacyContent = _privacyContent;
			Transform scrollRectContent = _scrollRectContent;
			GameObject gameObject = UnityEngine.Object.Instantiate(privacyContent, scrollRectContent);
			int _003C_003E1__state = default(int);
			_003CResetScrollRectPos_003Ed__45 _003CResetScrollRectPos_003Ed__ = new _003CResetScrollRectPos_003Ed__45(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetScrollRectPos_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResetScrollRectPos_003Ed__);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB2")]
		[Cpp2IlInjected.Address(RVA = "0x12BE9B0", Offset = "0x12BD3B0", VA = "0x1812BE9B0")]
		public void OpenCookiesPolicy()
		{
			//Discarded unreachable code: IL_00c0
			//IL_000e: Expected I4, but got I8
			//IL_004d: Expected F4, but got I4
			_param.MenuState = DisclaimerState.COOKIES;
			DisclaimerPromptParam param = _param;
			GameObject mainBlocker = _mainBlocker;
			bool active = !param.ContentOnly;
			mainBlocker.SetActive(active);
			DisclaimerPromptParam param2 = _param;
			CanvasGroup animatedContentCG = _animatedContentCG;
			bool contentOnly = param2.ContentOnly;
			animatedContentCG.alpha = (contentOnly ? 1 : 0);
			TextBase title = _title;
			string text = (title.StringID = _cookiesTitleID);
			_contentBlocker.SetActive(value: true);
			_legalContent.SetActive(value: true);
			GameObject cookiesContent = _cookiesContent;
			Transform scrollRectContent = _scrollRectContent;
			GameObject gameObject = UnityEngine.Object.Instantiate(cookiesContent, scrollRectContent);
			int _003C_003E1__state = default(int);
			_003CResetScrollRectPos_003Ed__45 _003CResetScrollRectPos_003Ed__ = new _003CResetScrollRectPos_003Ed__45(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetScrollRectPos_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResetScrollRectPos_003Ed__);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB3")]
		[Cpp2IlInjected.Address(RVA = "0x12BEDF0", Offset = "0x12BD7F0", VA = "0x1812BEDF0")]
		public void OpenParentalInfo()
		{
			//Discarded unreachable code: IL_00c0
			//IL_000e: Expected I4, but got I8
			//IL_004d: Expected F4, but got I4
			_param.MenuState = DisclaimerState.PARENTAL_INFO;
			DisclaimerPromptParam param = _param;
			GameObject mainBlocker = _mainBlocker;
			bool active = !param.ContentOnly;
			mainBlocker.SetActive(active);
			DisclaimerPromptParam param2 = _param;
			CanvasGroup animatedContentCG = _animatedContentCG;
			bool contentOnly = param2.ContentOnly;
			animatedContentCG.alpha = (contentOnly ? 1 : 0);
			TextBase title = _title;
			string text = (title.StringID = _parentalInfoTitleID);
			_contentBlocker.SetActive(value: true);
			_legalContent.SetActive(value: true);
			GameObject parentalInfoContent = _parentalInfoContent;
			Transform scrollRectContent = _scrollRectContent;
			GameObject gameObject = UnityEngine.Object.Instantiate(parentalInfoContent, scrollRectContent);
			int _003C_003E1__state = default(int);
			_003CResetScrollRectPos_003Ed__45 _003CResetScrollRectPos_003Ed__ = new _003CResetScrollRectPos_003Ed__45(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetScrollRectPos_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResetScrollRectPos_003Ed__);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB4")]
		[Cpp2IlInjected.Address(RVA = "0x12BF740", Offset = "0x12BE140", VA = "0x1812BF740")]
		public void ShowContent(DisclaimerState menuToShow)
		{
			//Discarded unreachable code: IL_001a, IL_0021, IL_0028, IL_002f, IL_0036
			//IL_0012: Expected I4, but got I8
			if (menuToShow != DisclaimerState.EULA)
			{
				_param.MenuState = DisclaimerState.NONE;
			}
			else
			{
				OpenParentalInfo();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB5")]
		[Cpp2IlInjected.Address(RVA = "0x12BE4A0", Offset = "0x12BCEA0", VA = "0x1812BE4A0")]
		public void ClearContent()
		{
			//Discarded unreachable code: IL_0069
			//IL_000e: Expected I4, but got I8
			_param.MenuState = DisclaimerState.NONE;
			Transform scrollRectContent = _scrollRectContent;
			int index = 0;
			UnityEngine.Object.Destroy(scrollRectContent.GetChild(index).gameObject);
			GameObject legalContent = _legalContent;
			int active = 0;
			legalContent.SetActive((byte)active != 0);
			GameObject contentBlocker = _contentBlocker;
			int active2 = 0;
			contentBlocker.SetActive((byte)active2 != 0);
			if (_param.ContentOnly)
			{
				OnAcceptButton();
			}
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB6")]
		[Cpp2IlInjected.Address(RVA = "0x12BF560", Offset = "0x12BDF60", VA = "0x1812BF560")]
		[IteratorStateMachine(typeof(_003CResetScrollRectPos_003Ed__45))]
		private IEnumerator ResetScrollRectPos()
		{
			int _003C_003E1__state = default(int);
			_003CResetScrollRectPos_003Ed__45 _003CResetScrollRectPos_003Ed__ = new _003CResetScrollRectPos_003Ed__45(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetScrollRectPos_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB7")]
		[Cpp2IlInjected.Address(RVA = "0x12BF360", Offset = "0x12BDD60", VA = "0x1812BF360")]
		public void ProcessEscShortcut()
		{
			//Discarded unreachable code: IL_0096
			//IL_0036: Expected I4, but got I8
			int num = 0;
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
				return;
			}
			int num2 = 0;
			if (Application.platform != RuntimePlatform.OSXPlayer && _param.MenuState <= DisclaimerState.COOKIES)
			{
				_param.MenuState = DisclaimerState.NONE;
				Transform scrollRectContent = _scrollRectContent;
				int index = 0;
				UnityEngine.Object.Destroy(scrollRectContent.GetChild(index).gameObject);
				GameObject legalContent = _legalContent;
				int active = 0;
				legalContent.SetActive((byte)active != 0);
				GameObject contentBlocker = _contentBlocker;
				int active2 = 0;
				contentBlocker.SetActive((byte)active2 != 0);
				if (_param.ContentOnly)
				{
					OnAcceptButton();
				}
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB8")]
		[Cpp2IlInjected.Address(RVA = "0x12BF860", Offset = "0x12BE260", VA = "0x1812BF860")]
		public DisclaimerPrompt()
		{
		}
	}
}
