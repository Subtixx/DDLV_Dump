using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006A2")]
	[CreateAssetMenu]
	public class SettingsGameGuideConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x20006A3")]
		public enum TutoPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x400252D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400252E")]
			GenericGamepad,
			[Cpp2IlInjected.Token(Token = "0x400252F")]
			Xbox360,
			[Cpp2IlInjected.Token(Token = "0x4002530")]
			XboxOne,
			[Cpp2IlInjected.Token(Token = "0x4002531")]
			XboxSeries,
			[Cpp2IlInjected.Token(Token = "0x4002532")]
			PlayStation4,
			[Cpp2IlInjected.Token(Token = "0x4002533")]
			PlayStation5,
			[Cpp2IlInjected.Token(Token = "0x4002534")]
			NintendoSwitch
		}

		[Cpp2IlInjected.Token(Token = "0x20006A4")]
		public enum GameGuideSlide
		{
			[Cpp2IlInjected.Token(Token = "0x4002536")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002537")]
			ThreeC,
			[Cpp2IlInjected.Token(Token = "0x4002538")]
			Collection,
			[Cpp2IlInjected.Token(Token = "0x4002539")]
			Cooking,
			[Cpp2IlInjected.Token(Token = "0x400253A")]
			Crafting,
			[Cpp2IlInjected.Token(Token = "0x400253B")]
			Customization_Clothing,
			[Cpp2IlInjected.Token(Token = "0x400253C")]
			Customization_Furniture,
			[Cpp2IlInjected.Token(Token = "0x400253D")]
			Dreamlight,
			[Cpp2IlInjected.Token(Token = "0x400253E")]
			Energy,
			[Cpp2IlInjected.Token(Token = "0x400253F")]
			EnergyOut,
			[Cpp2IlInjected.Token(Token = "0x4002540")]
			Fishing,
			[Cpp2IlInjected.Token(Token = "0x4002541")]
			Friendship,
			[Cpp2IlInjected.Token(Token = "0x4002542")]
			Garden,
			[Cpp2IlInjected.Token(Token = "0x4002543")]
			House,
			[Cpp2IlInjected.Token(Token = "0x4002544")]
			HowToHouse,
			[Cpp2IlInjected.Token(Token = "0x4002545")]
			Map,
			[Cpp2IlInjected.Token(Token = "0x4002546")]
			MapFastTravel,
			[Cpp2IlInjected.Token(Token = "0x4002547")]
			Mining,
			[Cpp2IlInjected.Token(Token = "0x4002548")]
			MoanaBoat,
			[Cpp2IlInjected.Token(Token = "0x4002549")]
			Quest,
			[Cpp2IlInjected.Token(Token = "0x400254A")]
			QuestTracking,
			[Cpp2IlInjected.Token(Token = "0x400254B")]
			RemoveObstacle,
			[Cpp2IlInjected.Token(Token = "0x400254C")]
			RestaurantOrder,
			[Cpp2IlInjected.Token(Token = "0x400254D")]
			RoyalDuties,
			[Cpp2IlInjected.Token(Token = "0x400254E")]
			Selling,
			[Cpp2IlInjected.Token(Token = "0x400254F")]
			Tools_Camera,
			[Cpp2IlInjected.Token(Token = "0x4002550")]
			Tools_FishingRod,
			[Cpp2IlInjected.Token(Token = "0x4002551")]
			Tools_Pickaxe,
			[Cpp2IlInjected.Token(Token = "0x4002552")]
			Tools_Shovel,
			[Cpp2IlInjected.Token(Token = "0x4002553")]
			Tools_WateringCan,
			[Cpp2IlInjected.Token(Token = "0x4002554")]
			WallEGarden,
			[Cpp2IlInjected.Token(Token = "0x4002555")]
			Hangout,
			[Cpp2IlInjected.Token(Token = "0x4002556")]
			TouchOfMagic1,
			[Cpp2IlInjected.Token(Token = "0x4002557")]
			TouchOfMagic2,
			[Cpp2IlInjected.Token(Token = "0x4002558")]
			TouchOfMagic3,
			[Cpp2IlInjected.Token(Token = "0x4002559")]
			RealTimeSync,
			[Cpp2IlInjected.Token(Token = "0x400255A")]
			StarPath
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20006A5")]
		public class SlideCategory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400255B")]
			public AssetReferenceTexture Icon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400255C")]
			public string DisplayName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400255D")]
			public List<GameGuideSlide> SlideList;

			[Cpp2IlInjected.Token(Token = "0x6002AB6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SlideCategory()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20006A6")]
		public class SlideEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400255E")]
			public TutorialPopupContent Slide;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400255F")]
			public TutoPlatform TutoPlatform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4002560")]
			public GameGuideSlide GameGuideSlide;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002561")]
			[ItemID]
			public int TutorialID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4002562")]
			[HideInInspector]
			public bool canBeShown;

			[Cpp2IlInjected.Token(Token = "0x17000640")]
			public Item TutorialItem
			{
				[Cpp2IlInjected.Token(Token = "0x6002AB7")]
				[Cpp2IlInjected.Address(RVA = "0x1151BD0", Offset = "0x11505D0", VA = "0x181151BD0")]
				get
				{
					long num = Convert.ToInt64((uint)TutorialID);
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002AB8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SlideEntry()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400252A")]
		public List<SlideEntry> AllSlidesList = (List<SlideEntry>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400252B")]
		public List<SlideCategory> SlideCategories = (List<SlideCategory>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6002AB5")]
		[Cpp2IlInjected.Address(RVA = "0x1262790", Offset = "0x1261190", VA = "0x181262790")]
		public SettingsGameGuideConfig()
		{
		}
	}
}
