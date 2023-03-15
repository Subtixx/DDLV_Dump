using System;
using System.Globalization;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200087F")]
	public class RefreshBuyButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003255")]
		[SerializeField]
		private TMP_Text _textAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003256")]
		[SerializeField]
		private CanvasGroup _btnCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003257")]
		[SerializeField]
		private ButtonTmPro _btn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003258")]
		[SerializeField]
		private FocusNavigationElement _focusNavElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003259")]
		[ItemID]
		public int CurrencyId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400325A")]
		[SerializeField]
		[Tooltip("If enabled, we will automatically refresh the button based on the Currency the player has.")]
		private bool _automaticRefresh = true;

		[Cpp2IlInjected.Token(Token = "0x1700078B")]
		public Item CurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x60035AA")]
			[Cpp2IlInjected.Address(RVA = "0xE2EF70", Offset = "0xE2D970", VA = "0x180E2EF70")]
			get
			{
				long num = Convert.ToInt64((uint)CurrencyId);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035AB")]
		[Cpp2IlInjected.Address(RVA = "0xE2ED40", Offset = "0xE2D740", VA = "0x180E2ED40")]
		private void OnEnable()
		{
			if (_automaticRefresh)
			{
				RefreshBuy();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035AC")]
		[Cpp2IlInjected.Address(RVA = "0xE2ED50", Offset = "0xE2D750", VA = "0x180E2ED50")]
		public unsafe void RefreshBuy()
		{
			//Discarded unreachable code: IL_0065
			int num = 0;
			ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
			long num2 = Convert.ToInt64((uint)CurrencyId);
			string text = _textAmount.text;
			int num3 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			bool flag = int.TryParse(text, NumberStyles.Any, invariantCulture, out *(int*)num);
			if (!_textAmount.IsActive())
			{
			}
			bool greyOut = default(bool);
			GreyOutButton(greyOut);
		}

		[Cpp2IlInjected.Token(Token = "0x60035AD")]
		[Cpp2IlInjected.Address(RVA = "0xE2EB80", Offset = "0xE2D580", VA = "0x180E2EB80")]
		public void GreyOutButton(bool greyOut, bool isInsufficient = true, bool isTransparent = true)
		{
			//Discarded unreachable code: IL_0087
			//IL_001c: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			TextBase component = _textAmount.GetComponent<TextBase>();
			CanvasGroup btnCanvasGroup = _btnCanvasGroup;
			int num = 0;
			if (btnCanvasGroup != (UnityEngine.Object)num)
			{
				CanvasGroup btnCanvasGroup2 = _btnCanvasGroup;
				if (isTransparent != greyOut)
				{
				}
				btnCanvasGroup2.alpha = 1f;
			}
			_btn.IsActive = isTransparent;
			_btn.Selectable.interactable = isTransparent;
			FocusNavigationElement focusNavElement = _focusNavElement;
			int num2 = 0;
			if (focusNavElement != (UnityEngine.Object)num2)
			{
				_focusNavElement.IgnoreThis = greyOut;
			}
			_btn.GetComponent<FocusNavigationElement>().IgnoreThis = greyOut;
		}

		[Cpp2IlInjected.Token(Token = "0x60035AE")]
		[Cpp2IlInjected.Address(RVA = "0xE2EF60", Offset = "0xE2D960", VA = "0x180E2EF60")]
		public RefreshBuyButton()
		{
		}
	}
}
