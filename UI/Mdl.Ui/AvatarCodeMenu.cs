using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000294")]
	public class AvatarCodeMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000B9E")]
		[SerializeField]
		public GameObject _keyboardIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000B9F")]
		[SerializeField]
		public GameObject _gamepadIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000BA0")]
		[SerializeField]
		private ButtonTmPro buttonAvatarCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000BA1")]
		[SerializeField]
		private TextMeshProUGUI labelAvatarCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000BA2")]
		private bool isShowingCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000BA3")]
		private ProfileTransfer profileTransfer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000BA4")]
		[SerializeField]
		private FocusNavigationElement buttonAvatarfocusNavigation;

		[Cpp2IlInjected.Token(Token = "0x600103E")]
		[Cpp2IlInjected.Address(RVA = "0x8827B0", Offset = "0x8811B0", VA = "0x1808827B0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0030
			//IL_0027: Expected O, but got I4
			ProfileTransfer profileTransfer = (this.profileTransfer = GetComponent<ProfileTransfer>());
			TextBase label = buttonAvatarCode.Label;
			int num = 0;
			string text2 = (label.Text = LocalizationManager.FromStringID("menu.show_avatar_code_button", (IResolver)num));
		}

		[Cpp2IlInjected.Token(Token = "0x600103F")]
		[Cpp2IlInjected.Address(RVA = "0x882950", Offset = "0x881350", VA = "0x180882950")]
		public void pressAvatarCode()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001040")]
		[Cpp2IlInjected.Address(RVA = "0x882850", Offset = "0x881250", VA = "0x180882850")]
		[AsyncStateMachine(typeof(_003CToggleAvatarCode_003Ed__9))]
		private Task ToggleAvatarCode()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001041")]
		[Cpp2IlInjected.Address(RVA = "0x882730", Offset = "0x881130", VA = "0x180882730", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			UiRoot.Instance._menuStack.GetMenu<HudMenu>()?.OnFocusIn();
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001042")]
		[Cpp2IlInjected.Address(RVA = "0x882580", Offset = "0x880F80", VA = "0x180882580")]
		public void Close()
		{
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x6001043")]
		[Cpp2IlInjected.Address(RVA = "0x8825D0", Offset = "0x880FD0", VA = "0x1808825D0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GamePopCurrentMenu)
			{
				AK.Wwise.Event @event = closeSFX;
				if (@event != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001044")]
		[Cpp2IlInjected.Address(RVA = "0x882630", Offset = "0x881030", VA = "0x180882630", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_008a
			//IL_0032: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			if (flag)
			{
				int num2 = 0;
				EventSystem current = EventSystem.current;
				int num3 = 0;
				current.SetSelectedGameObject((GameObject)num3);
				MenuNavigation menuNavigation = base.MenuNavigation;
				if ((object)menuNavigation != null)
				{
					FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
					if ((object)focusNavigation != null)
					{
						FocusNavigationElement focus = buttonAvatarfocusNavigation;
						focusNavigation.SetFocus(focus);
					}
				}
			}
			GameObject keyboardIndicator = _keyboardIndicator;
			bool active = !flag;
			keyboardIndicator.SetActive(active);
			GameObject gamepadIndicator = _gamepadIndicator;
			active = flag;
			gamepadIndicator.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6001045")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public AvatarCodeMenu()
		{
		}
	}
}
