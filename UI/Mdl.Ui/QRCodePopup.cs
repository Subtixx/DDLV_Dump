using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000363")]
	public class QRCodePopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000364")]
		public enum QRCodeType
		{
			[Cpp2IlInjected.Token(Token = "0x4001068")]
			CookiesPolicy,
			[Cpp2IlInjected.Token(Token = "0x4001069")]
			Eula,
			[Cpp2IlInjected.Token(Token = "0x400106A")]
			TermOfUse,
			[Cpp2IlInjected.Token(Token = "0x400106B")]
			PrivacyPolicy,
			[Cpp2IlInjected.Token(Token = "0x400106C")]
			CustomerCare,
			[Cpp2IlInjected.Token(Token = "0x400106D")]
			Discord
		}

		[Cpp2IlInjected.Token(Token = "0x2000365")]
		public class QRCodePopupParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400106E")]
			public QRCodeType QRCodeType;

			[Cpp2IlInjected.Token(Token = "0x60015AB")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public QRCodePopupParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001060")]
		[SerializeField]
		private string[] _titleStringIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001061")]
		[SerializeField]
		private string[] _urls;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001062")]
		[SerializeField]
		private GameObject[] _qrcodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001063")]
		[SerializeField]
		private TextBase _popupTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001064")]
		[SerializeField]
		private TextBase _url;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001065")]
		[SerializeField]
		private ShortcutIndicator _closeShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001066")]
		private QRCodeType _qrCodeType;

		[Cpp2IlInjected.Token(Token = "0x60015A3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60015A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1AEF0", Offset = "0xE198F0", VA = "0x180E1AEF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			base.UnregisterFocusedListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x60015A5")]
		[Cpp2IlInjected.Address(RVA = "0xE206D0", Offset = "0xE1F0D0", VA = "0x180E206D0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00a7
			//IL_0019: Expected I4, but got O
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					_qrCodeType = (QRCodeType)param;
				}
			}
			string[] titleStringIDs = _titleStringIDs;
			TextBase popupTitle = _popupTitle;
			QRCodeType qrCodeType = _qrCodeType;
			string text2 = (popupTitle.StringID = titleStringIDs[(int)qrCodeType]);
			string[] urls = _urls;
			TextBase url = _url;
			QRCodeType qrCodeType2 = _qrCodeType;
			string text4 = (url.Text = urls[(int)qrCodeType2]);
			GameObject[] qrcodes = _qrcodes;
			QRCodeType qrCodeType3 = _qrCodeType;
			qrcodes[(int)qrCodeType3].SetActive(value: true);
			_closeShortcut.gameObject.SetActive(value: true);
			_closeShortcut.TransformToPreset();
		}

		[Cpp2IlInjected.Token(Token = "0x60015A6")]
		[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x60015A7")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnExitButtonHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60015A8")]
		[Cpp2IlInjected.Address(RVA = "0xE20670", Offset = "0xE1F070", VA = "0x180E20670", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_002b
			PopSelf();
			int num = 0;
			UiRoot.Instance.MainMenuBar?.ShortcutBar?.ToggleCloseMenuShortcutIndicator(toggle: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60015A9")]
		[Cpp2IlInjected.Address(RVA = "0xE20890", Offset = "0xE1F290", VA = "0x180E20890")]
		private void ToggleShortcutIndicator(bool toggle)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			UiRoot.Instance.MainMenuBar?.ShortcutBar?.ToggleCloseMenuShortcutIndicator(toggle);
		}

		[Cpp2IlInjected.Token(Token = "0x60015AA")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public QRCodePopup()
		{
		}
	}
}
