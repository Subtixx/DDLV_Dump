using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200066F")]
	public class DisconnectedControllerPrompt : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400240F")]
		public TextBase title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002410")]
		public TextBase subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002411")]
		public TextBase message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002412")]
		public RectTransform bodyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002413")]
		public RectTransform buttonsAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002414")]
		public List<Button> closeButtons = (List<Button>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002415")]
		public FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002416")]
		[SerializeField]
		private string _playstationControllerStringId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002417")]
		public ButtonTmPro buttonTmProPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002418")]
		private PromptData _data;

		[Cpp2IlInjected.Token(Token = "0x60029A5")]
		[Cpp2IlInjected.Address(RVA = "0xF154B0", Offset = "0xF13EB0", VA = "0x180F154B0")]
		public void Init(PromptData data)
		{
			//Discarded unreachable code: IL_0128
			//IL_0028: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			//IL_0114: Expected O, but got I4
			ReInput.add_ControllerConnectedEvent((Action<>)(object)new Action<T>(OnControllerConnected));
			_data = data;
			TextBase textBase = title;
			int num = 0;
			bool flag = textBase != (UnityEngine.Object)num;
			if (flag)
			{
				TextBase textBase2 = title;
				int num2 = 0;
				if (flag)
				{
					GameObject gameObject = textBase2.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				textBase2.Text = (string)num2;
			}
			TextBase textBase3 = subtitle;
			int num3 = 0;
			bool flag2 = textBase3 != (UnityEngine.Object)num3;
			if (flag2)
			{
				TextBase textBase4 = subtitle;
				if (flag2)
				{
					GameObject gameObject2 = textBase4.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
				}
			}
			TextBase textBase5 = message;
			int num4 = 0;
			bool flag3 = textBase5 != (UnityEngine.Object)num4;
			string text = default(string);
			if (flag3)
			{
				int num5 = 0;
				if (!flag3)
				{
					int num6 = 0;
					if (!flag3)
					{
						goto IL_00de;
					}
				}
				string playstationControllerStringId = _playstationControllerStringId;
				int num7 = 0;
				text = (textBase5._stringID = LocalizationManager.FromStringID(playstationControllerStringId, (IResolver)num7));
				goto IL_00de;
			}
			goto IL_0100;
			IL_00de:
			TextBase textBase6 = message;
			if (text != null)
			{
				GameObject gameObject3 = textBase6.gameObject;
				int active3 = 0;
				gameObject3.SetActive((byte)active3 != 0);
			}
			goto IL_0100;
			IL_0100:
			RectTransform rectTransform = bodyContent;
			int num8 = 0;
			if (rectTransform != (UnityEngine.Object)num8)
			{
				bodyContent.SetTop(1.4E-43f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029A6")]
		[Cpp2IlInjected.Address(RVA = "0xF157F0", Offset = "0xF141F0", VA = "0x180F157F0")]
		private void OnControllerConnected(ControllerStatusChangedEventArgs obj)
		{
			//Discarded unreachable code: IL_000e
			int num = 0;
			UiRoot.Instance.OnControllerConnected(obj);
		}

		[Cpp2IlInjected.Token(Token = "0x60029A7")]
		[Cpp2IlInjected.Address(RVA = "0xE21920", Offset = "0xE20320", VA = "0x180E21920")]
		public void SetText(TextBase text, string message)
		{
			//Discarded unreachable code: IL_0011, IL_0019
			GameObject gameObject = text.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60029A8")]
		[Cpp2IlInjected.Address(RVA = "0xF15820", Offset = "0xF14220", VA = "0x180F15820")]
		public DisconnectedControllerPrompt()
		{
		}
	}
}
