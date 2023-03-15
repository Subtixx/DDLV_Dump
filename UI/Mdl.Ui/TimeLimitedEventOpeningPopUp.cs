using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000510")]
	public class TimeLimitedEventOpeningPopUp : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001B59")]
		private TimeLimitedEventOpeningPopUpParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001B5A")]
		[SerializeField]
		private GameObject _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001B5B")]
		[SerializeField]
		private TextBase _tfEventName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001B5C")]
		[SerializeField]
		private TextBase _tfDesc;

		[Cpp2IlInjected.Token(Token = "0x60020F8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60020F9")]
		[Cpp2IlInjected.Address(RVA = "0xE1AEF0", Offset = "0xE198F0", VA = "0x180E1AEF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			base.UnregisterFocusedListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x60020FA")]
		[Cpp2IlInjected.Address(RVA = "0x17F0410", Offset = "0x17EEE10", VA = "0x1817F0410", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param == null)
			{
			}
			int num = 0;
			_param = (TimeLimitedEventOpeningPopUpParam)param;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020FB")]
		[Cpp2IlInjected.Address(RVA = "0x17F0280", Offset = "0x17EEC80", VA = "0x1817F0280", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0077
			base.OnFocusIn();
			TimeLimitedEventOpeningPopUpParam param = _param;
			if (param == null)
			{
				return;
			}
			MegaEventData _003CData_003Ek__BackingField = param.Data;
			if (_003CData_003Ek__BackingField != null)
			{
				TextBase tfEventName = _tfEventName;
				string title_ = _003CData_003Ek__BackingField.title_;
				if (!string.Equals(tfEventName._stringID, title_))
				{
					tfEventName._stringID = title_;
					tfEventName.RefreshText();
				}
				_003C_003Ef__AnonymousType11<float, eEaseType> vars = default(_003C_003Ef__AnonymousType11<float, eEaseType>);
				TweenMax tweenMax = TweenMax.From(_tfDesc.gameObject.GetComponent<TextMeshProUGUI>(), 0.4f, vars, int.MinValue, this);
				_mcContent.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020FC")]
		[Cpp2IlInjected.Address(RVA = "0x17F04C0", Offset = "0x17EEEC0", VA = "0x1817F04C0")]
		private void PlayIntroStep1()
		{
			//Discarded unreachable code: IL_002f
			_003C_003Ef__AnonymousType11<float, eEaseType> vars = default(_003C_003Ef__AnonymousType11<float, eEaseType>);
			TweenMax tweenMax = TweenMax.From(_tfDesc.gameObject.GetComponent<TextMeshProUGUI>(), 0.4f, vars, int.MinValue, this);
			_mcContent.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60020FD")]
		[Cpp2IlInjected.Address(RVA = "0x17F01D0", Offset = "0x17EEBD0", VA = "0x1817F01D0")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			int num2 = 0;
			IMenu top = popupStack.Top;
			if (top != null)
			{
				int num3 = 0;
				if (top != null)
				{
					int num4 = 0;
					UiRoot.Instance._popupStack.Pop();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020FE")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public TimeLimitedEventOpeningPopUp()
		{
		}
	}
}
