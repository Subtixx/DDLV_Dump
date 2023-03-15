using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200049F")]
	public class RewardPageIndicator : PageIndicator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001822")]
		[SerializeField]
		protected SpriteAtlasImage _specialPageIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001823")]
		private BattlePassRewardsPage _pageData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001824")]
		private bool _isCurrencyConversionPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001825")]
		private BattlePassUIGameColors _colorConfig;

		[Cpp2IlInjected.Token(Token = "0x170004EC")]
		public BattlePassRewardsPage PageData
		{
			[Cpp2IlInjected.Token(Token = "0x6001E26")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return _pageData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004ED")]
		public bool IsCurrencyConversionPage
		{
			[Cpp2IlInjected.Token(Token = "0x6001E27")]
			[Cpp2IlInjected.Address(RVA = "0x7389C0", Offset = "0x7373C0", VA = "0x1807389C0")]
			get
			{
				return _isCurrencyConversionPage;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E28")]
			[Cpp2IlInjected.Address(RVA = "0xE33090", Offset = "0xE31A90", VA = "0x180E33090")]
			set
			{
				_isCurrencyConversionPage = value;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E29")]
		[Cpp2IlInjected.Address(RVA = "0xE32EE0", Offset = "0xE318E0", VA = "0x180E32EE0", Slot = "4")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0069, IL_0079
			base.RefreshDisplay();
			PageIndicatorColorScheme colors = _colors;
			if (colors == null)
			{
			}
			GameObject gameObject = _pageNumber.gameObject;
			bool active = !_isCurrencyConversionPage;
			gameObject.SetActive(active);
			GameObject gameObject2 = _specialPageIcon.gameObject;
			bool isCurrencyConversionPage = _isCurrencyConversionPage;
			gameObject2.SetActive(isCurrencyConversionPage);
			Image image = _specialPageIcon.Image;
			Image image2 = default(Image);
			Color color = (image2.color = colors.SelectedUnlockedLabelColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E2A")]
		[Cpp2IlInjected.Address(RVA = "0xE32CE0", Offset = "0xE316E0", VA = "0x180E32CE0")]
		public void Init(bool isLocked, int index, int total, BattlePassRewardsPage data, BattlePassUIGameColors colorConfig)
		{
			//Discarded unreachable code: IL_0039
			//IL_0007: Expected O, but got I4
			//IL_000e: Expected O, but got I4
			//IL_0019: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			_pageData = (BattlePassRewardsPage)0;
			_colorConfig = (BattlePassUIGameColors)0;
			_isCurrencyConversionPage = (byte)(int)typeof(PageIndicatorColorScheme).TypeHandle != 0;
			PageIndicatorColorScheme colors = new PageIndicatorColorScheme();
			int num = 0;
			int num2 = 0;
			Init(isLocked, index, total, colors, (string)num2);
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E2B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public RewardPageIndicator()
		{
		}
	}
}
