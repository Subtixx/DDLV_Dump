using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008C4")]
	public class UIUtil
	{
		[Cpp2IlInjected.Token(Token = "0x20008C5")]
		public enum FilterColorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x400346E")]
			Trait,
			[Cpp2IlInjected.Token(Token = "0x400346F")]
			Tag,
			[Cpp2IlInjected.Token(Token = "0x4003470")]
			Item,
			[Cpp2IlInjected.Token(Token = "0x4003471")]
			Color,
			[Cpp2IlInjected.Token(Token = "0x4003472")]
			None
		}

		[Cpp2IlInjected.Token(Token = "0x400346C")]
		public static Color TraitColor;

		[Cpp2IlInjected.Token(Token = "0x6003737")]
		[Cpp2IlInjected.Address(RVA = "0xC9B750", Offset = "0xC9A150", VA = "0x180C9B750")]
		public static string Loc(string locKey)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			return LocalizationManager.FromStringID(locKey, (IResolver)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003738")]
		[Cpp2IlInjected.Address(RVA = "0xC9B560", Offset = "0xC99F60", VA = "0x180C9B560")]
		public static string GetTraitStringId(UiTrait.Trait type, int subIndex)
		{
			if (type != 0 && type != 0)
			{
				switch (type)
				{
				default:
					return "";
				case UiTrait.Trait.Mood:
				{
					string text = default(string);
					return "menu.catalog_trait_" + text;
				}
				case UiTrait.Trait.Complexity:
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003739")]
		[Cpp2IlInjected.Address(RVA = "0xC9B330", Offset = "0xC99D30", VA = "0x180C9B330")]
		public static Color32 GetTagColorId(FilterColorTypes type)
		{
			Color32 result = default(Color32);
			if (type != 0 && type != 0 && type != 0 && type != FilterColorTypes.Tag)
			{
				return result;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600373A")]
		[Cpp2IlInjected.Address(RVA = "0xC9B3B0", Offset = "0xC99DB0", VA = "0x180C9B3B0")]
		public static Color32 GetTagColor(TagItem item)
		{
			TagItemType tagItemType = default(TagItemType);
			if (tagItemType <= TagItemType.DominantColor)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				return Color.white;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600373B")]
		[Cpp2IlInjected.Address(RVA = "0xC9B170", Offset = "0xC99B70", VA = "0x180C9B170")]
		public static GameObject GetOverUI(GameObject canvas)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600373C")]
		[Cpp2IlInjected.Address(RVA = "0xC9B100", Offset = "0xC99B00", VA = "0x180C9B100")]
		[IteratorStateMachine(typeof(_003CDelayedActionNextFrame_003Ed__7))]
		public static IEnumerator DelayedActionNextFrame(UnityAction action)
		{
			int _003C_003E1__state = default(int);
			_003CDelayedActionNextFrame_003Ed__7 _003CDelayedActionNextFrame_003Ed__ = new _003CDelayedActionNextFrame_003Ed__7(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDelayedActionNextFrame_003Ed__.action = action;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600373D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UIUtil()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600373E")]
		[Cpp2IlInjected.Address(RVA = "0xC9B760", Offset = "0xC9A160", VA = "0x180C9B760")]
		static UIUtil()
		{
			int num = 0;
		}
	}
}
