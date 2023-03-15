using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Scene;
using Gameloft.Localization.Formatter;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000321")]
	public class CollectionTooltipVillageAreaElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000378")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000F0C")]
		public VillageAreaType VillageAreaType
		{
			[Cpp2IlInjected.Token(Token = "0x6001418")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001419")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000379")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4000F0D")]
		public int SceneId
		{
			[Cpp2IlInjected.Token(Token = "0x600141A")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600141B")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600141C")]
		[Cpp2IlInjected.Address(RVA = "0x114EE70", Offset = "0x114D870", VA = "0x18114EE70", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_004d, IL_0061, IL_0080, IL_00a5, IL_00b7
			//IL_0018: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int num = 0;
			if (SceneId == -1)
			{
				VillageAreaType villageAreaType = VillageAreaType;
				string text = ((Enum)villageAreaType).ToString();
				VillageAreaType villageAreaType2 = villageAreaType;
				string text2 = text.ToLower();
			}
			Dictionary<TextType, string> dictionary = base.Texts;
			string text3 = default(string);
			string stringID = "menu.label_village_area_" + text3;
			int num2 = 0;
			string text4 = LocalizationManager.FromStringID(stringID, (IResolver)num2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600141D")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipVillageAreaElementModel()
		{
		}
	}
}
