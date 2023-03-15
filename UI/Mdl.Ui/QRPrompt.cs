using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Mdl.InputSystem;
using Mdl.Ui.Photo;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000678")]
	public class QRPrompt : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400242E")]
		public TextBase title;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400242F")]
		public TextBase subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002430")]
		public TextBase message;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002431")]
		public RectTransform bodyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002432")]
		public RectTransform buttonsAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002433")]
		public List<Button> closeButtons = (List<Button>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002434")]
		public new FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002435")]
		private PromptData _data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002436")]
		public ButtonTmPro buttonTmProPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002437")]
		public RawImage codeimage;

		[Cpp2IlInjected.Token(Token = "0x4002438")]
		public static HttpClient httpClient = new HttpClient();

		[Cpp2IlInjected.Token(Token = "0x4002439")]
		private static bool isFromPhoneMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400243A")]
		[SerializeField]
		private RectTransform popupBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400243B")]
		[SerializeField]
		private GameObject buttonEsc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400243C")]
		[SerializeField]
		private GameObject _keyboardShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400243D")]
		[SerializeField]
		private GameObject _gamepadShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400243E")]
		private InputAction _inputActionInteract;

		[Cpp2IlInjected.Token(Token = "0x60029C6")]
		[Cpp2IlInjected.Address(RVA = "0xE220C0", Offset = "0xE20AC0", VA = "0x180E220C0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0071, IL_007a, IL_0080
			//IL_0017: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num3 = default(int);
			InputActionBool inputActionInteract = new InputActionBool("Interact", trigger, (InputProvider)num3);
			num3 = 0;
			_inputActionInteract = inputActionInteract;
			List<Button> list = closeButtons;
			bool flag = default(bool);
			if (flag)
			{
				UnityAction unityAction = OnCloseButton;
			}
			string _003C_urlDownloadPicture_003Ek__BackingField = PhotoMenu._urlDownloadPicture;
			RawImage rawImage = default(RawImage);
			QRGenerator qRGenerator = default(QRGenerator);
			Texture2D texture2D = (Texture2D)(rawImage.texture = qRGenerator.generateQR(_003C_urlDownloadPicture_003Ek__BackingField));
			Debug.Log("deedoodle QR ~ ~ ~ ~ ~ UpdateQRCode");
			PhotoMenu.Instance.IsUIHidden = true;
			int num4 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60029C7")]
		[Cpp2IlInjected.Address(RVA = "0xE227C0", Offset = "0xE211C0", VA = "0x180E227C0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0042
			float deltaTime;
			InputAction[] array;
			InputAction inputActionInteract;
			do
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[1];
				inputActionInteract = _inputActionInteract;
			}
			while (inputActionInteract != null && array == null);
			array[0] = inputActionInteract;
			InputAction.UpdateAll(deltaTime, array);
			if (_inputActionInteract.IsTriggered)
			{
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029C8")]
		[Cpp2IlInjected.Address(RVA = "0xE20C90", Offset = "0xE1F690", VA = "0x180E20C90")]
		public void Init(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0103, IL_0109, IL_010f, IL_0115, IL_011b, IL_0121, IL_0127
			//IL_00d3: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int width = Screen.width;
			int num6 = 0;
			int height = Screen.height;
			int num7 = 0;
			int num8 = 0;
			_data = (PromptData)(object)param;
			_stack = stack;
			if ((_data.allowClose ? 1 : 0) == num4)
			{
				List<Button> list = closeButtons;
				bool flag = default(bool);
				if (flag)
				{
					int active = 0;
					GameObject gameObject = default(GameObject);
					gameObject.SetActive((byte)active != 0);
				}
			}
			bool flag2 = default(bool);
			if (flag2 && flag2)
			{
				int active2 = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active2 != 0);
			}
			bool flag3 = default(bool);
			if (flag3 && flag3)
			{
				int active3 = 0;
				GameObject gameObject3 = default(GameObject);
				gameObject3.SetActive((byte)active3 != 0);
			}
			bool flag4 = default(bool);
			if (flag4)
			{
				Action<int> answerAction = param.AnswerAction;
				bool flag5 = default(bool);
				if (flag5)
				{
					if (flag5)
					{
						int active4 = 0;
						GameObject gameObject4 = default(GameObject);
						gameObject4.SetActive((byte)active4 != 0);
					}
					RawImage rawImage = default(RawImage);
					int num9 = ((rawImage.enabled = false) ? 1 : 0);
				}
			}
			bool flag7 = default(bool);
			if (flag7)
			{
				Action onPopAction = param.OnPopAction;
			}
			bool flag8 = default(bool);
			if (flag8)
			{
				QRPrompt qRPrompt = (QRPrompt)0;
				ButtonTmPro buttonTmPro = default(ButtonTmPro);
				Button.ButtonClickedEvent onClick = buttonTmPro.ButtonComponent.m_OnClick;
				PromptButtonData button = default(PromptButtonData);
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_001b
					QRPrompt qRPrompt2 = qRPrompt;
					Action onClick2 = button.onClick;
					qRPrompt2.OnClickButton(onClick2);
				};
				onClick.AddListener(call);
				TextBase label = buttonTmPro.Label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029C9")]
		[Cpp2IlInjected.Address(RVA = "0xE217C0", Offset = "0xE201C0", VA = "0x180E217C0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0042
			base.OnPush(stack, param);
			Init(stack, param);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigationElement componentInChildren = GetComponentInChildren<FocusNavigationElement>();
				FocusNavigation.SetFocus(componentInChildren);
				BaseUiRoot.Instance.HideHud();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029CA")]
		[Cpp2IlInjected.Address(RVA = "0xE21700", Offset = "0xE20100", VA = "0x180E21700", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0016
			base.OnPop();
			PhotoMenu _003CInstance_003Ek__BackingField = PhotoMenu.Instance;
			int num = ((_003CInstance_003Ek__BackingField.IsUIHidden = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60029CB")]
		[Cpp2IlInjected.Address(RVA = "0xE21500", Offset = "0xE1FF00", VA = "0x180E21500", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0091, IL_0097, IL_009d, IL_00a3
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				_keyboardShortcut.SetActive(value: true);
				GameObject gamepadShortcut = _gamepadShortcut;
				int active = 0;
				gamepadShortcut.SetActive((byte)active != 0);
				List<Button> list = closeButtons;
				bool flag = default(bool);
				if (flag)
				{
					bool allowClose = _data.allowClose;
					GameObject gameObject = default(GameObject);
					gameObject.SetActive(allowClose);
				}
			}
			FocusNavigationElement componentInChildren = GetComponentInChildren<FocusNavigationElement>();
			FocusNavigation.SetFocus(componentInChildren);
			GameObject keyboardShortcut = _keyboardShortcut;
			int active2 = 0;
			keyboardShortcut.SetActive((byte)active2 != 0);
			_gamepadShortcut.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60029CC")]
		[Cpp2IlInjected.Address(RVA = "0xE213C0", Offset = "0xE1FDC0", VA = "0x180E213C0")]
		private void OnClickButton(Action callback)
		{
			//Discarded unreachable code: IL_0021
			_stack.Pop();
			callback?.Invoke();
			IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x60029CD")]
		[Cpp2IlInjected.Address(RVA = "0xE214B0", Offset = "0xE1FEB0", VA = "0x180E214B0")]
		private void OnCloseButton()
		{
			//Discarded unreachable code: IL_0023
			_stack.Pop();
			_data.onCloseButton?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60029CE")]
		[Cpp2IlInjected.Address(RVA = "0xE21920", Offset = "0xE20320", VA = "0x180E21920")]
		public void SetText(TextBase text, string message)
		{
			//Discarded unreachable code: IL_0011, IL_0019
			GameObject gameObject = text.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60029CF")]
		[Cpp2IlInjected.Address(RVA = "0xE22010", Offset = "0xE20A10", VA = "0x180E22010")]
		public void ShowQRCode()
		{
			//Discarded unreachable code: IL_0022
			Texture2D texture = new QRGenerator().generateQR("https://www.gameloft.com/en/game/dragon-mania-legends");
			codeimage.GetComponent<RawImage>().texture = texture;
		}

		[Cpp2IlInjected.Token(Token = "0x60029D0")]
		[Cpp2IlInjected.Address(RVA = "0xE226D0", Offset = "0xE210D0", VA = "0x180E226D0")]
		private void UpdateQRCode(string pictureUrl)
		{
			//Discarded unreachable code: IL_0028
			Texture2D texture = new QRGenerator().generateQR(pictureUrl);
			codeimage.GetComponent<RawImage>().texture = texture;
			Debug.Log("deedoodle QR ~ ~ ~ ~ ~ UpdateQRCode");
		}

		[Cpp2IlInjected.Token(Token = "0x60029D1")]
		[Cpp2IlInjected.Address(RVA = "0xE20BA0", Offset = "0xE1F5A0", VA = "0x180E20BA0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_004e
			if (redirectionType != RedirectionType.MenuNavGoBackward)
			{
				return;
			}
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num3 = 0;
				if (top == null)
				{
				}
			}
			_stack.Pop();
			_data.onCloseButton?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60029D2")]
		[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20570", VA = "0x180E21B70")]
		public void ShowPopupPhoneMenu()
		{
			//Discarded unreachable code: IL_0078
			//IL_0013: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			PromptData promptData = new PromptData();
			int num = 0;
			string text = (promptData.title = TextUtilities.GetLocalizedText("menu.share_title_phone_menu", (IResolver)num));
			int num2 = 0;
			string text2 = (promptData.subtitle = TextUtilities.GetLocalizedText("menu.share_subtitle", (IResolver)num2));
			promptData.message = "";
			promptData.allowClose = false;
			int num3 = 0;
			string localizedText = TextUtilities.GetLocalizedText("menu.button_common_okay", (IResolver)num3);
			Action action = delegate
			{
				//Discarded unreachable code: IL_0035
				GameObject in_gameObjectID = base.gameObject;
				uint num4 = AkSoundEngine.PostEvent("sfx_ui_select", in_gameObjectID);
				_stack.Pop();
				_data.onCloseButton?.Invoke();
			};
			List<PromptButtonData> buttons = promptData.buttons;
			BaseUiRoot.Instance.ShowSharePrompt(promptData, 1);
		}

		[Cpp2IlInjected.Token(Token = "0x60029D3")]
		[Cpp2IlInjected.Address(RVA = "0xE21DC0", Offset = "0xE207C0", VA = "0x180E21DC0")]
		public void ShowPopupPhotoMode()
		{
			//Discarded unreachable code: IL_0078
			//IL_0013: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			PromptData promptData = new PromptData();
			int num = 0;
			string text = (promptData.title = TextUtilities.GetLocalizedText("menu.share_title_photo_mode", (IResolver)num));
			int num2 = 0;
			string text2 = (promptData.subtitle = TextUtilities.GetLocalizedText("menu.share_subtitle", (IResolver)num2));
			promptData.message = "";
			promptData.allowClose = false;
			int num3 = 0;
			string localizedText = TextUtilities.GetLocalizedText("menu.button_common_okay", (IResolver)num3);
			Action action = delegate
			{
				GameObject in_gameObjectID = base.gameObject;
				uint num4 = AkSoundEngine.PostEvent("sfx_ui_select", in_gameObjectID);
			};
			List<PromptButtonData> buttons = promptData.buttons;
			BaseUiRoot.Instance.ShowSharePrompt(promptData, 1);
		}

		[Cpp2IlInjected.Token(Token = "0x60029D4")]
		[Cpp2IlInjected.Address(RVA = "0xE21990", Offset = "0xE20390", VA = "0x180E21990")]
		[AsyncStateMachine(typeof(_003CShowPopupErrorConnectionPhoneMenu_003Ed__31))]
		public Task ShowPopupErrorConnectionPhoneMenu(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029D5")]
		[Cpp2IlInjected.Address(RVA = "0xE21A70", Offset = "0xE20470", VA = "0x180E21A70")]
		[AsyncStateMachine(typeof(_003CShowPopupErrorConnectionPhotoMode_003Ed__32))]
		public Task ShowPopupErrorConnectionPhotoMode(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029D6")]
		[Cpp2IlInjected.Address(RVA = "0xE228F0", Offset = "0xE212F0", VA = "0x180E228F0")]
		[AsyncStateMachine(typeof(_003CUploadAsync_003Ed__33))]
		public Task UploadAsync(string picturePath, bool fromPhotoMenu)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029D7")]
		[Cpp2IlInjected.Address(RVA = "0xE22A30", Offset = "0xE21430", VA = "0x180E22A30")]
		[AsyncStateMachine(typeof(_003CUploadObject_003Ed__34))]
		public Task UploadObject(string url, string picturePath, bool forConsole = false)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60029D8")]
		[Cpp2IlInjected.Address(RVA = "0xE22BF0", Offset = "0xE215F0", VA = "0x180E22BF0")]
		public QRPrompt()
		{
		}
	}
}
