using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000674")]
	public class GenericPrompt : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002420")]
		public TextBase title;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002421")]
		public TextBase subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002422")]
		public TextBase message;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002423")]
		public RectTransform bodyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002424")]
		public RectTransform buttonsAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002425")]
		public List<Button> closeButtons = (List<Button>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002426")]
		public new FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002427")]
		public ButtonTmPro buttonTmProPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002428")]
		private PromptData _data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002429")]
		private bool _goTostart;

		[Cpp2IlInjected.Token(Token = "0x60029B4")]
		[Cpp2IlInjected.Address(RVA = "0xE54D60", Offset = "0xE53760", VA = "0x180E54D60")]
		private void Start()
		{
			//Discarded unreachable code: IL_0019, IL_001f
			List<Button> list = closeButtons;
			bool flag = default(bool);
			if (flag)
			{
				UnityAction unityAction = OnCloseButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B5")]
		[Cpp2IlInjected.Address(RVA = "0xE541D0", Offset = "0xE52BD0", VA = "0x180E541D0")]
		public void Init(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d
			//IL_00b9: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			_data = (PromptData)(object)param;
			_stack = stack;
			int num7 = 0;
			int num8 = ((_goTostart = false) ? 1 : 0);
			if ((_data.allowClose ? 1 : 0) == num4 && num8 == 0)
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
			if (flag4 && flag4)
			{
				int active4 = 0;
				GameObject gameObject4 = default(GameObject);
				gameObject4.SetActive((byte)active4 != 0);
			}
			bool flag5 = default(bool);
			if (flag5)
			{
				Action onPopAction = param.OnPopAction;
			}
			bool flag6 = default(bool);
			if (flag6)
			{
				GenericPrompt genericPrompt = (GenericPrompt)0;
				ButtonTmPro buttonTmPro = default(ButtonTmPro);
				Button.ButtonClickedEvent onClick = buttonTmPro.ButtonComponent.m_OnClick;
				PromptButtonData button = default(PromptButtonData);
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_001b
					GenericPrompt genericPrompt2 = genericPrompt;
					Action onClick2 = button.onClick;
					genericPrompt2.OnClickButton(onClick2);
				};
				onClick.AddListener(call);
				TextBase label = buttonTmPro.Label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B6")]
		[Cpp2IlInjected.Address(RVA = "0xE54C00", Offset = "0xE53600", VA = "0x180E54C00", Slot = "25")]
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

		[Cpp2IlInjected.Token(Token = "0x60029B7")]
		[Cpp2IlInjected.Address(RVA = "0xE54B70", Offset = "0xE53570", VA = "0x180E54B70", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_002f
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigationElement componentInChildren = GetComponentInChildren<FocusNavigationElement>();
				FocusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B8")]
		[Cpp2IlInjected.Address(RVA = "0xE54900", Offset = "0xE53300", VA = "0x180E54900")]
		private void OnClickButton(Action callback)
		{
			//Discarded unreachable code: IL_0021
			_stack.Pop();
			callback?.Invoke();
			IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B9")]
		[Cpp2IlInjected.Address(RVA = "0xE549F0", Offset = "0xE533F0", VA = "0x180E549F0")]
		private void OnCloseButton()
		{
			//Discarded unreachable code: IL_0056
			if (_goTostart)
			{
				int num = 0;
				UiRoot.Instance.Redirection.StopAndReturnToStartMenu().FireAndForgetTask();
			}
			_stack.Pop();
			_data.onCloseButton?.Invoke();
			if (!_goTostart)
			{
				IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029BA")]
		[Cpp2IlInjected.Address(RVA = "0xE21920", Offset = "0xE20320", VA = "0x180E21920")]
		public void SetText(TextBase text, string message)
		{
			//Discarded unreachable code: IL_0011, IL_0019
			GameObject gameObject = text.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60029BB")]
		[Cpp2IlInjected.Address(RVA = "0xE53F20", Offset = "0xE52920", VA = "0x180E53F20")]
		public void CopyToClipboard()
		{
			//Discarded unreachable code: IL_00aa
			string[] array;
			string text3;
			while (true)
			{
				array = new string[5];
				string text = _data.title;
				if (text != null && array == null)
				{
					continue;
				}
				array[0] = text;
				if ("\n" != null && "\n" == null)
				{
					continue;
				}
				array[1] = "\n";
				string text2 = _data.subtitle;
				if (text2 != null && "\n" == null)
				{
					continue;
				}
				array[2] = text2;
				if ("\n" == null || "\n" != null)
				{
					array[3] = "\n";
					text3 = _data.message;
					if (text3 == null || "\n" != null)
					{
						break;
					}
				}
			}
			array[4] = text3;
			GUIUtility.systemCopyBuffer = string.Concat(array);
		}

		[Cpp2IlInjected.Token(Token = "0x60029BC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60029BD")]
		[Cpp2IlInjected.Address(RVA = "0xE54EC0", Offset = "0xE538C0", VA = "0x180E54EC0")]
		public GenericPrompt()
		{
		}
	}
}
