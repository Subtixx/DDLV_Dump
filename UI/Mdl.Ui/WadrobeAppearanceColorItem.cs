using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Utils;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200076D")]
	[RequiredAllNotNull]
	public class WadrobeAppearanceColorItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002B55")]
		[SerializeField]
		private Image _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002B56")]
		[SerializeField]
		public GameObject NoneIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002B57")]
		[SerializeField]
		public GameObject SelectedNoneBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002B58")]
		[SerializeField]
		public GameObject HighlightNoneBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002B59")]
		[SerializeField]
		public GameObject SelectedHighlightNoneBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002B5A")]
		[SerializeField]
		public GameObject VitiligoDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002B5B")]
		public BaseButton Button;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002B5C")]
		public Color Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002B5D")]
		public int Index;

		[Cpp2IlInjected.Token(Token = "0x170006C4")]
		public GameObject Bg
		{
			[Cpp2IlInjected.Token(Token = "0x6002F87")]
			[Cpp2IlInjected.Address(RVA = "0x14D7BB0", Offset = "0x14D65B0", VA = "0x1814D7BB0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _mcBackground.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F88")]
		[Cpp2IlInjected.Address(RVA = "0x14D7B40", Offset = "0x14D6540", VA = "0x1814D7B40")]
		internal void RefreshColor(Color color, int index)
		{
			//Discarded unreachable code: IL_000f
			Image mcBackground = _mcBackground;
			Index = index;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F89")]
		[Cpp2IlInjected.Address(RVA = "0x14D7AA0", Offset = "0x14D64A0", VA = "0x1814D7AA0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0036
			Button.ButtonComponent.m_OnClick.RemoveAllListeners();
			Button.OnHighlightAdded.RemoveAllListeners();
			Button.OnHighlightRemoved.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8A")]
		[Cpp2IlInjected.Address(RVA = "0x14D7B20", Offset = "0x14D6520", VA = "0x1814D7B20")]
		private void OnDisable()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8B")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA0", Offset = "0x88B6A0", VA = "0x18088CCA0")]
		public WadrobeAppearanceColorItem()
		{
		}
	}
}
