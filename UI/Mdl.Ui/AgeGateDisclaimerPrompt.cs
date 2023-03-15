using Cpp2IlInjected;
using Mdl.Utils;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004D5")]
	[RequiredAllNotNull]
	public class AgeGateDisclaimerPrompt : DisclaimerPrompt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001980")]
		[SerializeField]
		private InputTextBase _tfAgeInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001981")]
		[SerializeField]
		private GameObject _tfIncorrectAge;

		[Cpp2IlInjected.Token(Token = "0x4001982")]
		public const string USER_AGE = "UserAge";

		[Cpp2IlInjected.Token(Token = "0x6001F8D")]
		[Cpp2IlInjected.Address(RVA = "0x87D5A0", Offset = "0x87BFA0", VA = "0x18087D5A0", Slot = "39")]
		public override void SetFocus()
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

		[Cpp2IlInjected.Token(Token = "0x6001F8E")]
		[Cpp2IlInjected.Address(RVA = "0x87D350", Offset = "0x87BD50", VA = "0x18087D350", Slot = "40")]
		protected override void OnAcceptButton()
		{
			//Discarded unreachable code: IL_00c3, IL_00c9, IL_00cf, IL_00d5, IL_00db, IL_00e1, IL_00e7, IL_00ed
			int num = int.Parse(((TMP_InputField)_tfAgeInput).m_Text);
			string text = ((TMP_InputField)_tfAgeInput).m_Text;
			if (text.m_stringLength != 0 && !string.Equals(text, "") && num > 0)
			{
				GameObject tfIncorrectAge = _tfIncorrectAge;
				int active = 0;
				tfIncorrectAge.SetActive((byte)active != 0);
				JToken value = true;
				UIAgeGateStorage.Set("DisclaimerAgreed", value);
				JToken value2 = num;
				UIAgeGateStorage.Set("UserAge", value2);
				int num2 = 0;
				bool flag = UIAgeGateStorage.Save();
				_stack.Pop();
				_param?.OnAcceptButton?.Invoke();
			}
			GameObject tfIncorrectAge2 = _tfIncorrectAge;
			tfIncorrectAge2.SetActive(value: true);
			tfIncorrectAge2.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F8F")]
		[Cpp2IlInjected.Address(RVA = "0x87D710", Offset = "0x87C110", VA = "0x18087D710")]
		public AgeGateDisclaimerPrompt()
		{
		}
	}
}
