using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000881")]
	public class ResetFilterBtnStateHandler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400325C")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400325D")]
		[SerializeField]
		private ButtonTmPro buttonTmPro;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400325E")]
		[SerializeField]
		private FilterItemSelector[] filterItemSelectors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400325F")]
		private bool _btnEnable;

		[Cpp2IlInjected.Token(Token = "0x1700078C")]
		private bool BtnEnable
		{
			[Cpp2IlInjected.Token(Token = "0x60035B2")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return _btnEnable;
			}
			[Cpp2IlInjected.Token(Token = "0x60035B3")]
			[Cpp2IlInjected.Address(RVA = "0xE325A0", Offset = "0xE30FA0", VA = "0x180E325A0")]
			set
			{
				//Discarded unreachable code: IL_0036
				if (value != _btnEnable)
				{
					_btnEnable = value;
					button.interactable = value;
					ButtonTmPro buttonTmPro = this.buttonTmPro;
					bool greyedOut = !_btnEnable;
					buttonTmPro.SetGreyedOut(greyedOut);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035B4")]
		[Cpp2IlInjected.Address(RVA = "0xE32300", Offset = "0xE30D00", VA = "0x180E32300")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_002e
			Button button = this.button;
			bool flag = (button.interactable = _btnEnable);
			ButtonTmPro buttonTmPro = this.buttonTmPro;
			bool greyedOut = !_btnEnable;
			buttonTmPro.SetGreyedOut(greyedOut);
		}

		[Cpp2IlInjected.Token(Token = "0x60035B5")]
		[Cpp2IlInjected.Address(RVA = "0xE324D0", Offset = "0xE30ED0", VA = "0x180E324D0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0063
			FilterItemSelector[] array = filterItemSelectors;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				List<Filter> selectedFilters = array[num].selectedFilters;
				num++;
			}
			if (!_btnEnable)
			{
				Button button = this.button;
				_btnEnable = true;
				button.interactable = true;
				ButtonTmPro buttonTmPro = this.buttonTmPro;
				bool greyedOut = !_btnEnable;
				buttonTmPro.SetGreyedOut(greyedOut);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035B6")]
		[Cpp2IlInjected.Address(RVA = "0xE32300", Offset = "0xE30D00", VA = "0x180E32300")]
		private void ToggleState()
		{
			//Discarded unreachable code: IL_002e
			Button button = this.button;
			bool flag = (button.interactable = _btnEnable);
			ButtonTmPro buttonTmPro = this.buttonTmPro;
			bool greyedOut = !_btnEnable;
			buttonTmPro.SetGreyedOut(greyedOut);
		}

		[Cpp2IlInjected.Token(Token = "0x60035B7")]
		[Cpp2IlInjected.Address(RVA = "0xE32350", Offset = "0xE30D50", VA = "0x180E32350")]
		public void Press()
		{
			//Discarded unreachable code: IL_002e
			//IL_0020: Expected O, but got I4
			buttonTmPro.OnHighlightEnter();
			TweenComponent component = button.GetComponent<TweenComponent>();
			int num = 0;
			if (component != (Object)num)
			{
				int index = 0;
				component.PlayTween(index);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035B8")]
		[Cpp2IlInjected.Address(RVA = "0xE32410", Offset = "0xE30E10", VA = "0x180E32410")]
		public void Release()
		{
			//Discarded unreachable code: IL_002c
			//IL_0020: Expected O, but got I4
			buttonTmPro.OnHighlightExit();
			TweenComponent component = button.GetComponent<TweenComponent>();
			int num = 0;
			if (component != (Object)num)
			{
				component.PlayTween(1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035B9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ResetFilterBtnStateHandler()
		{
		}
	}
}
