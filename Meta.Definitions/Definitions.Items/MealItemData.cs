using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003E6")]
	public sealed class MealItemData : IMessage<MealItemData>, IMessage, IEquatable<MealItemData>, IDeepCloneable<MealItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IBackpackItem, ISellable, IGridPlaceableItemData, ICanBeEaten, IDataValidation, IItemStateProvider, IIsMissionItem, IHasExtraGiftFriendship, IItemSellPriceCalculator, IManaRecoveredCalculator, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4001512")]
		private static readonly MessageParser<MealItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001513")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001514")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001515")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001516")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001517")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001518")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001519")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400151A")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400151B")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400151C")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400151D")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400151E")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400151F")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4001520")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001521")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001522")]
		public const int CanBeUsedAsIngredientFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001523")]
		private bool canBeUsedAsIngredient_;

		[Cpp2IlInjected.Token(Token = "0x4001524")]
		public const int CookingIngredientTypeFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001525")]
		private int cookingIngredientType_;

		[Cpp2IlInjected.Token(Token = "0x4001526")]
		public const int StarRatingFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001527")]
		private int starRating_;

		[Cpp2IlInjected.Token(Token = "0x4001528")]
		public const int ManaRecoveredFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001529")]
		private int manaRecovered_;

		[Cpp2IlInjected.Token(Token = "0x400152A")]
		public const int IsMissionItemFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400152B")]
		private bool isMissionItem_;

		[Cpp2IlInjected.Token(Token = "0x400152C")]
		public const int UnsellableFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400152D")]
		private bool unsellable_;

		[Cpp2IlInjected.Token(Token = "0x400152E")]
		public const int MealTypeFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400152F")]
		private int mealType_;

		[Cpp2IlInjected.Token(Token = "0x4001530")]
		public const int ExtraGiftFriendshipFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001531")]
		private int extraGiftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x4001532")]
		public const int VerbOverrideStringIDFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001533")]
		private string verbOverrideStringID_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001534")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001535")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001536")]
		public static readonly Item MealQuestType = (Item)(_parser = (MessageParser<MealItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MealItemData())));

		[Cpp2IlInjected.Token(Token = "0x4001537")]
		public const string FixMealManaRecoveredMenuItem = "Window/Script/Fix Meal ManaRecovered";

		[Cpp2IlInjected.Token(Token = "0x17000C0D")]
		[DebuggerNonUserCode]
		public static MessageParser<MealItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002F3F")]
			[Cpp2IlInjected.Address(RVA = "0x306DD90", Offset = "0x306C790", VA = "0x18306DD90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F40")]
			[Cpp2IlInjected.Address(RVA = "0x306D7E0", Offset = "0x306C1E0", VA = "0x18306D7E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F41")]
			[Cpp2IlInjected.Address(RVA = "0x306DF40", Offset = "0x306C940", VA = "0x18306DF40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C10")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002F46")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F47")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C11")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002F48")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F49")]
			[Cpp2IlInjected.Address(RVA = "0x306E1A0", Offset = "0x306CBA0", VA = "0x18306E1A0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C12")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002F4A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "24")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F4B")]
			[Cpp2IlInjected.Address(RVA = "0x306E0C0", Offset = "0x306CAC0", VA = "0x18306E0C0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C13")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002F4C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F4D")]
			[Cpp2IlInjected.Address(RVA = "0x306E130", Offset = "0x306CB30", VA = "0x18306E130")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C14")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002F4E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F4F")]
			[Cpp2IlInjected.Address(RVA = "0x306E210", Offset = "0x306CC10", VA = "0x18306E210")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C15")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6002F50")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "27")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F51")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C16")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6002F52")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F53")]
			[Cpp2IlInjected.Address(RVA = "0x306E050", Offset = "0x306CA50", VA = "0x18306E050")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C17")]
		[DebuggerNonUserCode]
		public bool CanBeUsedAsIngredient
		{
			[Cpp2IlInjected.Token(Token = "0x6002F54")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return canBeUsedAsIngredient_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F55")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				canBeUsedAsIngredient_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C18")]
		[DebuggerNonUserCode]
		public int CookingIngredientType
		{
			[Cpp2IlInjected.Token(Token = "0x6002F56")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return cookingIngredientType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F57")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				cookingIngredientType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C19")]
		[DebuggerNonUserCode]
		public int StarRating
		{
			[Cpp2IlInjected.Token(Token = "0x6002F58")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return starRating_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F59")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				starRating_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1A")]
		[DebuggerNonUserCode]
		public int ManaRecovered
		{
			[Cpp2IlInjected.Token(Token = "0x6002F5A")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "28")]
			get
			{
				return manaRecovered_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F5B")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				manaRecovered_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1B")]
		[DebuggerNonUserCode]
		public bool IsMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002F5C")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0", Slot = "31")]
			get
			{
				return isMissionItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F5D")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				isMissionItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1C")]
		[DebuggerNonUserCode]
		public bool Unsellable
		{
			[Cpp2IlInjected.Token(Token = "0x6002F5E")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5F0", Offset = "0xE38FF0", VA = "0x180E3A5F0")]
			get
			{
				return unsellable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F5F")]
			[Cpp2IlInjected.Address(RVA = "0x1A7B2C0", Offset = "0x1A79CC0", VA = "0x181A7B2C0")]
			set
			{
				unsellable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1D")]
		[DebuggerNonUserCode]
		public int MealType
		{
			[Cpp2IlInjected.Token(Token = "0x6002F60")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30")]
			get
			{
				return mealType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F61")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				mealType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1E")]
		[DebuggerNonUserCode]
		public int ExtraGiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6002F62")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "32")]
			get
			{
				return extraGiftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F63")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				extraGiftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1F")]
		[DebuggerNonUserCode]
		public string VerbOverrideStringID
		{
			[Cpp2IlInjected.Token(Token = "0x6002F64")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return verbOverrideStringID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F65")]
			[Cpp2IlInjected.Address(RVA = "0x306E280", Offset = "0x306CC80", VA = "0x18306E280")]
			set
			{
				string text = (verbOverrideStringID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C20")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002F66")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F67")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C21")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002F73")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "35")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C22")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6002F74")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C7E0", Offset = "0x1D2B1E0", VA = "0x181D2C7E0", Slot = "36")]
			get
			{
				return !isMissionItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C23")]
		public bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6002F75")]
			[Cpp2IlInjected.Address(RVA = "0x1D2C7F0", Offset = "0x1D2B1F0", VA = "0x181D2C7F0", Slot = "26")]
			get
			{
				return !unsellable_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C24")]
		public Item MealTypeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002F76")]
			[Cpp2IlInjected.Address(RVA = "0x306DD30", Offset = "0x306C730", VA = "0x18306DD30")]
			get
			{
				long num = Convert.ToInt64((uint)mealType_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F77")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				//IL_0007: Expected I4, but got O
				mealType_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C25")]
		public RecipeItemData RecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6002F79")]
			[Cpp2IlInjected.Address(RVA = "0x306DDF0", Offset = "0x306C7F0", VA = "0x18306DDF0")]
			get
			{
				//Discarded unreachable code: IL_002b
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int subItemEnumType = 0;
				IEnumerable<RecipeItemData> allByType = (IEnumerable<RecipeItemData>)_003CInstance_003Ek__BackingField.GetAllByType<RecipeItemData, ActivityDataItemType>(ItemType.ActivityData, (ActivityDataItemType)subItemEnumType);
				Func<RecipeItemData, bool> func = (Func<RecipeItemData, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData x)
				{
					int resultItemID = x.ResultItemID;
					int num = iD_;
					throw new NullReferenceException();
				};
				return Enumerable.FirstOrDefault<RecipeItemData>((IEnumerable<>)allByType, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C26")]
		public bool HasUniqueIngredientCombination
		{
			[Cpp2IlInjected.Token(Token = "0x6002F7A")]
			[Cpp2IlInjected.Address(RVA = "0x306D8B0", Offset = "0x306C2B0", VA = "0x18306D8B0")]
			get
			{
				//Discarded unreachable code: IL_00d4, IL_00da, IL_00e0, IL_00e6, IL_00ec
				//IL_0036: Expected O, but got I4
				//IL_008a: Expected O, but got I4
				//IL_00ae: Expected O, but got I4
				int num2;
				bool flag = default(bool);
				IEnumerable<> enumerable = default(IEnumerable<>);
				IEnumerable<> enumerable2 = default(IEnumerable<>);
				IEnumerable<> enumerable3 = default(IEnumerable<>);
				while (true)
				{
					int num = 0;
					num2 = 0;
					RecipeItemData recipeItemData = RecipeItemData;
					int count = ((RepeatedField<T>)(object)recipeItemData.ingredients_).Count;
					RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = recipeItemData.ingredients_;
					if (!flag)
					{
						break;
					}
					RecipeItemData.Types.Ingredient ingredient = (RecipeItemData.Types.Ingredient)0;
					RecipeItemData.Types.Ingredient ingredient2 = ingredient;
					RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient2.ingredientCase_;
					while (ingredient2 == null)
					{
					}
					if (ingredient2 != null)
					{
						if (ingredient2 != null)
						{
							while (ingredientCase_ != RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
							{
							}
							Func<ICookingIngredient, bool> func = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate(ICookingIngredient x)
							{
								//Discarded unreachable code: IL_004e
								//IL_000e: Expected I4, but got O
								if ((object)typeof(_003C_003Ec).TypeHandle == null)
								{
									return (byte)(int)typeof(_003C_003Ec).TypeHandle != 0;
								}
								RepeatedField<int> list_ = ingredient.TagsList.list_;
								Func<int, Item> func4 = default(Func<int, Item>);
								if (_003C_003Ec._003C_003E9__122_3 == null)
								{
									func4 = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int y) => (Item)typeof(Item).TypeHandle));
								}
								IEnumerable<int> enumerable4 = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)(object)list_, (Func<, >)(object)func4);
								return ItemDataExtensions.HasAllTags((IHasTags)x, (IEnumerable<>)enumerable4);
							};
							if (Enumerable.Count<ICookingIngredient>(enumerable, (Func<, >)(object)func) <= 1)
							{
								continue;
							}
							int num3 = 0;
							num2++;
						}
						Func<ICookingIngredient, bool> func2 = (Func<ICookingIngredient, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass122_0)num2)._003Cget_HasUniqueIngredientCombination_003Eb__1);
						if (Enumerable.Count<ICookingIngredient>(enumerable2, (Func<, >)(object)func2) <= 1)
						{
							continue;
						}
						int num4 = 0;
						num2++;
					}
					Func<ICookingIngredient, bool> func3 = (Func<ICookingIngredient, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass122_0)num2)._003Cget_HasUniqueIngredientCombination_003Eb__0);
					if (Enumerable.Count<ICookingIngredient>(enumerable3, (Func<, >)(object)func3) > 1)
					{
						int num5 = 0;
						num2++;
						break;
					}
				}
				if (num2 + 1 != 0)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F42")]
		[Cpp2IlInjected.Address(RVA = "0x306D470", Offset = "0x306BE70", VA = "0x18306D470")]
		[DebuggerNonUserCode]
		public MealItemData()
		{
			//Discarded unreachable code: IL_0071
			//IL_0065: Expected I4, but got I8
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			GridAreaData gridAreaData2 = gridAreaData_;
			starRating_ = 1;
			gridAreaData2.AcceptedFloorTypesFlag = 5375;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F43")]
		[Cpp2IlInjected.Address(RVA = "0x306BCE0", Offset = "0x306A6E0", VA = "0x18306BCE0")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_0029
			//IL_001d: Expected I4, but got I8
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			GridAreaData gridAreaData2 = gridAreaData_;
			starRating_ = 1;
			gridAreaData2.AcceptedFloorTypesFlag = 5375;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F44")]
		[Cpp2IlInjected.Address(RVA = "0x306D5A0", Offset = "0x306BFA0", VA = "0x18306D5A0")]
		[DebuggerNonUserCode]
		public MealItemData(MealItemData other)
		{
			//IL_0065: Expected I4, but got I8
			//IL_00dd: Expected O, but got I4
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			GridAreaData gridAreaData2 = gridAreaData_;
			starRating_ = 1;
			gridAreaData2.AcceptedFloorTypesFlag = 5375;
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData3 = other.gridAreaData_;
			if (gridAreaData3 != null)
			{
				GridAreaData gridAreaData4 = gridAreaData3.Clone();
			}
			int num2 = 0;
			gridAreaData_ = (GridAreaData)num2;
			string text5 = (description_ = other.description_);
			bool flag = (canBeUsedAsIngredient_ = other.canBeUsedAsIngredient_);
			int num3 = (cookingIngredientType_ = other.cookingIngredientType_);
			int num4 = (starRating_ = other.starRating_);
			int num5 = (manaRecovered_ = other.manaRecovered_);
			bool flag2 = (isMissionItem_ = other.isMissionItem_);
			bool flag3 = (unsellable_ = other.unsellable_);
			int num6 = (mealType_ = other.mealType_);
			int num7 = (extraGiftFriendship_ = other.extraGiftFriendship_);
			string text6 = (verbOverrideStringID_ = other.verbOverrideStringID_);
			uint num8 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F45")]
		[Cpp2IlInjected.Address(RVA = "0x3069DB0", Offset = "0x30687B0", VA = "0x183069DB0", Slot = "10")]
		[DebuggerNonUserCode]
		public MealItemData Clone()
		{
			return new MealItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F68")]
		[Cpp2IlInjected.Address(RVA = "0x306A330", Offset = "0x3068D30", VA = "0x18306A330", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(MealItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && object.Equals(gridAreaData_, other))
								{
									string text5 = description_;
									bool flag5 = default(bool);
									if (!flag5 && canBeUsedAsIngredient_ == flag5 && cookingIngredientType_ == (flag5 ? 1 : 0) && starRating_ == (flag5 ? 1 : 0) && manaRecovered_ == (flag5 ? 1 : 0) && isMissionItem_ == flag5 && unsellable_ == flag5 && mealType_ == (flag5 ? 1 : 0) && extraGiftFriendship_ == (flag5 ? 1 : 0))
									{
										string text6 = verbOverrideStringID_;
										bool flag6 = default(bool);
										if (!flag6 && glotID_ == (flag6 ? 1u : 0u))
										{
											return object.Equals(_unknownFields, other);
										}
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F69")]
		[Cpp2IlInjected.Address(RVA = "0x306A4D0", Offset = "0x3068ED0", VA = "0x18306A4D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MealItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									GridAreaData objB = other.gridAreaData_;
									if (object.Equals(gridAreaData_, objB))
									{
										string text5 = other.description_;
										if (!(description_ != text5))
										{
											bool flag = other.canBeUsedAsIngredient_;
											if (canBeUsedAsIngredient_ == flag)
											{
												int num2 = other.cookingIngredientType_;
												if (cookingIngredientType_ == num2)
												{
													int num3 = other.starRating_;
													if (starRating_ == num3)
													{
														int num4 = other.manaRecovered_;
														if (manaRecovered_ == num4)
														{
															bool flag2 = other.isMissionItem_;
															if (isMissionItem_ == flag2)
															{
																bool flag3 = other.unsellable_;
																if (unsellable_ == flag3)
																{
																	int num5 = other.mealType_;
																	if (mealType_ == num5)
																	{
																		int num6 = other.extraGiftFriendship_;
																		if (extraGiftFriendship_ == num6)
																		{
																			string text6 = other.verbOverrideStringID_;
																			if (!(verbOverrideStringID_ != text6))
																			{
																				uint num7 = other.glotID_;
																				if (glotID_ == num7)
																				{
																					UnknownFieldSet unknownFields = other._unknownFields;
																					return object.Equals(_unknownFields, unknownFields);
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num8 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6A")]
		[Cpp2IlInjected.Address(RVA = "0x306A9A0", Offset = "0x30693A0", VA = "0x18306A9A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0126
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int hashCode5 = gridAreaData.GetHashCode();
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			if (canBeUsedAsIngredient_)
			{
			}
			if (cookingIngredientType_ != 0)
			{
			}
			if (starRating_ != 0)
			{
			}
			if (manaRecovered_ != 0)
			{
			}
			if (isMissionItem_)
			{
			}
			if (unsellable_)
			{
			}
			if (mealType_ != 0)
			{
			}
			if (extraGiftFriendship_ != 0)
			{
			}
			string text6 = verbOverrideStringID_;
			if (text6.m_stringLength != 0)
			{
				int hashCode7 = text6.GetHashCode();
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6B")]
		[Cpp2IlInjected.Address(RVA = "0x306C2D0", Offset = "0x306ACD0", VA = "0x18306C2D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6C")]
		[Cpp2IlInjected.Address(RVA = "0x306CFB0", Offset = "0x306B9B0", VA = "0x18306CFB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01d8
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if ((long)gridAreaData_ != 0)
			{
				GridAreaData value6 = gridAreaData_;
				output.WriteMessage(value6);
			}
			if (description_.m_stringLength != 0)
			{
				string value7 = description_;
				output.WriteString(value7);
			}
			if (canBeUsedAsIngredient_)
			{
				bool value8 = canBeUsedAsIngredient_;
				output.WriteBool(value8);
			}
			if (cookingIngredientType_ != 0)
			{
				int value9 = cookingIngredientType_;
				output.WriteInt32(value9);
			}
			if (starRating_ != 0)
			{
				int value10 = starRating_;
				output.WriteInt32(value10);
			}
			if (manaRecovered_ != 0)
			{
				int value11 = manaRecovered_;
				output.WriteInt32(value11);
			}
			if (isMissionItem_)
			{
				bool value12 = isMissionItem_;
				output.WriteBool(value12);
			}
			if (mealType_ != 0)
			{
				int value13 = mealType_;
				output.WriteInt32(value13);
			}
			if (extraGiftFriendship_ != 0)
			{
				int value14 = extraGiftFriendship_;
				output.WriteInt32(value14);
			}
			if (verbOverrideStringID_.m_stringLength != 0)
			{
				string value15 = verbOverrideStringID_;
				output.WriteString(value15);
			}
			if (unsellable_)
			{
				bool value16 = unsellable_;
				output.WriteBool(value16);
			}
			if (glotID_ != 0)
			{
				uint value17 = glotID_;
				output.WriteUInt32(value17);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6D")]
		[Cpp2IlInjected.Address(RVA = "0x3069810", Offset = "0x3068210", VA = "0x183069810", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01fa
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
				num8++;
				num2 += num8;
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num2 += num9;
			}
			int num10 = cookingIngredientType_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = starRating_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			int num14 = manaRecovered_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			int num16 = mealType_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeInt32Size(num16);
				num17++;
				num2 += num17;
			}
			int num18 = extraGiftFriendship_;
			if (num18 != 0)
			{
				int num19 = CodedOutputStream.ComputeInt32Size(num18);
				num19++;
				num2 += num19;
			}
			string text6 = verbOverrideStringID_;
			if (text6.m_stringLength != 0)
			{
				int num20 = CodedOutputStream.ComputeStringSize(text6);
				num20++;
				num2 += num20;
			}
			uint num21 = glotID_;
			if (num21 != 0)
			{
				int num22 = CodedOutputStream.ComputeUInt32Size(num21);
				num22 += 2;
				num2 += num22;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num23 = unknownFields.CalculateSize();
				num2 += num23;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6E")]
		[Cpp2IlInjected.Address(RVA = "0x306B820", Offset = "0x306A220", VA = "0x18306B820", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MealItemData other)
		{
			//Discarded unreachable code: IL_01c6
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			if ((long)other.gridAreaData_ != 0)
			{
				GridAreaData gridAreaData2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
					gridAreaData2 = gridAreaData_;
				}
				GridAreaData other2 = other.gridAreaData_;
				gridAreaData2.MergeFrom(other2);
			}
			string text5 = other.description_;
			if (text5.m_stringLength != 0)
			{
				Description = text5;
			}
			bool flag = other.canBeUsedAsIngredient_;
			if (flag)
			{
				canBeUsedAsIngredient_ = flag;
			}
			int num2 = other.cookingIngredientType_;
			if (num2 != 0)
			{
				cookingIngredientType_ = num2;
			}
			int num3 = other.starRating_;
			if (num3 != 0)
			{
				starRating_ = num3;
			}
			int num4 = other.manaRecovered_;
			if (num4 != 0)
			{
				manaRecovered_ = num4;
			}
			bool flag2 = other.isMissionItem_;
			if (flag2)
			{
				isMissionItem_ = flag2;
			}
			bool flag3 = other.unsellable_;
			if (flag3)
			{
				unsellable_ = flag3;
			}
			int num5 = other.mealType_;
			if (num5 != 0)
			{
				mealType_ = num5;
			}
			int num6 = other.extraGiftFriendship_;
			if (num6 != 0)
			{
				extraGiftFriendship_ = num6;
			}
			string text6 = other.verbOverrideStringID_;
			if (text6.m_stringLength != 0)
			{
				VerbOverrideStringID = text6;
			}
			uint num7 = other.glotID_;
			if (num7 != 0)
			{
				glotID_ = num7;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6F")]
		[Cpp2IlInjected.Address(RVA = "0x306BA10", Offset = "0x306A410", VA = "0x18306BA10", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01fd
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 64)
			{
				if ((int)num > 96)
				{
					if ((int)num > 112)
					{
						if (num == 122)
						{
							string text2 = (VerbOverrideStringID = input.ReadString());
						}
						bool flag = default(bool);
						if (num == 128)
						{
							flag = (unsellable_ = input.ReadBool());
						}
						if (!flag)
						{
							goto IL_01e6;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 104)
					{
						num3 = (mealType_ = input.ReadInt32());
					}
					if (num3 != 112)
					{
						goto IL_01e6;
					}
					int num4 = (extraGiftFriendship_ = input.ReadInt32());
				}
				bool flag2 = default(bool);
				if ((int)num > 80)
				{
					int num5 = default(int);
					if (num == 88)
					{
						num5 = (manaRecovered_ = input.ReadInt32());
					}
					if (num5 != 96)
					{
						goto IL_01e6;
					}
					flag2 = (isMissionItem_ = input.ReadBool());
				}
				int num6 = default(int);
				if (flag2)
				{
					num6 = (cookingIngredientType_ = input.ReadInt32());
				}
				if (num6 != 80)
				{
					goto IL_01e6;
				}
				int num7 = (starRating_ = input.ReadInt32());
			}
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 34)
			{
				bool flag3 = default(bool);
				if ((int)num > 50)
				{
					string text4 = default(string);
					if (num == 58)
					{
						text4 = (Description = input.ReadString());
					}
					if ((long)text4 != 64)
					{
						goto IL_01e6;
					}
					flag3 = (canBeUsedAsIngredient_ = input.ReadBool());
				}
				string text6 = default(string);
				if (flag3)
				{
					text6 = (PrefabAddress = input.ReadString());
				}
				if ((long)text6 != 50)
				{
					goto IL_01e6;
				}
				GridAreaData builder = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder = gridAreaData_;
				}
				input.ReadMessage(builder);
			}
			string text10 = default(string);
			if ((long)gridAreaData > 18)
			{
				string text8 = default(string);
				if ((long)gridAreaData == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				if ((long)text8 != 34)
				{
					goto IL_01e6;
				}
				text10 = (IconAddress = input.ReadString());
			}
			int num8 = default(int);
			if ((long)text10 == 8)
			{
				num8 = (iD_ = input.ReadInt32());
			}
			if (num8 == 18)
			{
				string text12 = (Name = input.ReadString());
			}
			goto IL_01e6;
			IL_01e6:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002F70")]
		[Cpp2IlInjected.Address(RVA = "0x306A790", Offset = "0x3069190", VA = "0x18306A790", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 15)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
				uint num2 = glotID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F71")]
		[Cpp2IlInjected.Address(RVA = "0x306BD70", Offset = "0x306A770", VA = "0x18306BD70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0034, IL_003c, IL_0044, IL_004c, IL_0054, IL_005c, IL_0064, IL_006c, IL_006d, IL_007a, IL_0092, IL_0098, IL_009e, IL_00a4, IL_00aa, IL_00b0, IL_00b6, IL_00bc, IL_00c2, IL_00c8
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0091: Expected I4, but got O
			if (fieldNumber - 1 <= 15)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F72")]
		[Cpp2IlInjected.Address(RVA = "0x3069BA0", Offset = "0x30685A0", VA = "0x183069BA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e
			//IL_0010: Expected I4, but got I8
			//IL_0030: Expected I4, but got I8
			if (fieldNumber - 1 <= 15)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F78")]
		[Cpp2IlInjected.Address(RVA = "0x306ABF0", Offset = "0x30695F0", VA = "0x18306ABF0", Slot = "30")]
		public ItemState GetItemState(Random random, [Optional] RewardGenerationParameters parameters)
		{
			//Discarded unreachable code: IL_0015
			ItemState itemState = new ItemState();
			MealData mealData2 = (itemState.MealData = new MealData());
			return itemState;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7B")]
		[Cpp2IlInjected.Address(RVA = "0x19C97B0", Offset = "0x19C81B0", VA = "0x1819C97B0")]
		[IteratorStateMachine(typeof(_003CGetLowestIngredients_003Ed__123<>))]
		private IEnumerable<> GetLowestIngredients<T>(RecipeItemData P_0, Func<, > P_1)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7C")]
		[Cpp2IlInjected.Address(RVA = "0x306AF10", Offset = "0x3069910", VA = "0x18306AF10")]
		private IEnumerable<(Item, int)> GetLowestPriceIngredients(RecipeItemData recipeItemData)
		{
			//Discarded unreachable code: IL_0028
			Func<Item, int> _003C_003E9__124_ = _003C_003Ec._003C_003E9__124_0;
			if (_003C_003E9__124_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Item x)
				{
					int itemID = x.ItemID;
					int result = default(int);
					return result;
				};
			}
			return (IEnumerable<(Item, int)>)GetLowestIngredients<int>(recipeItemData, (Func<, >)(object)_003C_003E9__124_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7D")]
		[Cpp2IlInjected.Address(RVA = "0x306AC80", Offset = "0x3069680", VA = "0x18306AC80")]
		private IEnumerable<(Item, int)> GetLowestManaIngredients(RecipeItemData recipeItemData)
		{
			//Discarded unreachable code: IL_0028
			Func<Item, int> _003C_003E9__125_ = _003C_003Ec._003C_003E9__125_0;
			if (_003C_003E9__125_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Item x)
				{
					int itemID = x.ItemID;
					int result = default(int);
					return result;
				};
			}
			return (IEnumerable<(Item, int)>)GetLowestIngredients<int>(recipeItemData, (Func<, >)(object)_003C_003E9__125_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7E")]
		[Cpp2IlInjected.Address(RVA = "0x306ADC0", Offset = "0x30697C0", VA = "0x18306ADC0")]
		private int GetLowestManaRecovered(RecipeItemData recipeItemData)
		{
			//Discarded unreachable code: IL_0031
			Func<Item, int> _003C_003E9__125_ = _003C_003Ec._003C_003E9__125_0;
			if (_003C_003E9__125_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Item x)
				{
					int itemID = x.ItemID;
					int result = default(int);
					return result;
				};
			}
			IEnumerable<> lowestIngredients = GetLowestIngredients<int>(recipeItemData, (Func<, >)(object)_003C_003E9__125_);
			return this.TotalIngredientsManaRecovered(recipeItemData, lowestIngredients);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7F")]
		[Cpp2IlInjected.Address(RVA = "0x306A630", Offset = "0x3069030", VA = "0x18306A630")]
		public int GetDefaultManaRecovered()
		{
			if (isMissionItem_)
			{
				return manaRecovered_;
			}
			RecipeItemData recipeItemData = RecipeItemData;
			Func<Item, int> func = default(Func<Item, int>);
			if (_003C_003Ec._003C_003E9__125_0 == null)
			{
				func = (Func<Item, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Item x)
				{
					int itemID = x.ItemID;
					int result = default(int);
					return result;
				});
			}
			IEnumerable<> lowestIngredients = GetLowestIngredients<int>(recipeItemData, (Func<, >)(object)func);
			return this.TotalIngredientsManaRecovered(recipeItemData, lowestIngredients);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F80")]
		[Cpp2IlInjected.Address(RVA = "0x306C750", Offset = "0x306B150", VA = "0x18306C750")]
		private unsafe int TotalIngredientsValue(RecipeItemData recipeItemData, IEnumerable<(Item item, int value)> ingredientsUsed, Func<CookingData, int> baseSelector, Func<CookingData.Types.RecipeStarResult, int> bonusSelector, Func<CookingData, int> maxSelector)
		{
			//Discarded unreachable code: IL_00fa, IL_0100, IL_0106
			//IL_0020: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			//IL_0037: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			//IL_00d8: Expected I4, but got I8
			Func<RecipeItemData.Types.Ingredient, bool> func2 = default(Func<RecipeItemData.Types.Ingredient, bool>);
			uint num3 = default(uint);
			uint num4 = default(uint);
			bool result = default(bool);
			ulong num6 = default(ulong);
			int num5 = default(int);
			ulong num7 = default(ulong);
			do
			{
				int num = 0;
				if (ProtoDatabase.Instance.TryGet("Cooking", out *(CookingData*)num))
				{
					if (baseSelector != null)
					{
						int num2 = (int)baseSelector((T)num);
					}
					Func<CookingData.Types.RecipeStarResult, bool> func = (Func<CookingData.Types.RecipeStarResult, bool>)(object)(Func<T, TResult>)delegate(CookingData.Types.RecipeStarResult x)
					{
						//Discarded unreachable code: IL_0011
						int num8 = starRating_;
						return x.star_ == num8;
					};
					CookingData.Types.RecipeStarResult recipeStarResult = Enumerable.FirstOrDefault<CookingData.Types.RecipeStarResult>((IEnumerable<>)num, (Func<, >)(object)func);
				}
				RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = recipeItemData.ingredients_;
				if (_003C_003Ec._003C_003E9__128_1 == null)
				{
					func2 = (Func<RecipeItemData.Types.Ingredient, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RecipeItemData.Types.Ingredient x) => x.ingredientCase_ != RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID));
				}
				List<RecipeItemData.Types.Ingredient> list = (List<RecipeItemData.Types.Ingredient>)(object)Enumerable.ToList<RecipeItemData.Types.Ingredient>((IEnumerable<>)Enumerable.OrderBy<RecipeItemData.Types.Ingredient, bool>((IEnumerable<>)(object)ingredients_, (Func<, >)(object)func2));
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (num != 0)
				{
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_00df;
						}
						num++;
					}
					(Item item, int value) ingredient = ((Item item, int value))num;
					Predicate<RecipeItemData.Types.Ingredient> predicate = (Predicate<RecipeItemData.Types.Ingredient>)(object)(Predicate<T>)((RecipeItemData.Types.Ingredient x) => result);
					num5 = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
					if (num5 != -1)
					{
						num6 += num6;
						((List<T>)(object)list).RemoveAt(num5);
					}
					num = (int)((long)num + (long)num6);
					num5 += num5;
					goto IL_00df;
				}
				goto IL_00e6;
				IL_00df:
				num5 += num5;
				goto IL_00e6;
				IL_00e6:
				if (list != null)
				{
				}
			}
			while (num7 != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F81")]
		[Cpp2IlInjected.Address(RVA = "0x306C600", Offset = "0x306B000", VA = "0x18306C600")]
		private int TotalIngredientsSellPrice(RecipeItemData recipeItemData, IEnumerable<(Item item, int price)> ingredientsUsed)
		{
			//Discarded unreachable code: IL_002f
			//IL_002e: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			Func<CookingData.Types.RecipeStarResult, int> _003C_003E9__129_ = _003C_003Ec._003C_003E9__129_0;
			if (_003C_003E9__129_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CookingData.Types.RecipeStarResult x) => x.sellPriceIngredientPercentage_);
			}
			int num = 0;
			int num2 = 0;
			return this.TotalIngredientsValue(recipeItemData, (IEnumerable<>)ingredientsUsed, (Func<, >)num2, (Func<, >)(object)_003C_003E9__129_, (Func<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F82")]
		[Cpp2IlInjected.Address(RVA = "0x306C330", Offset = "0x306AD30", VA = "0x18306C330")]
		private int TotalIngredientsManaRecovered(RecipeItemData recipeItemData, IEnumerable<(Item item, int manaRecovered)> ingredientsUsed)
		{
			//Discarded unreachable code: IL_0069
			Func<CookingData, int> _003C_003E9__130_ = _003C_003Ec._003C_003E9__130_0;
			if (_003C_003E9__130_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CookingData x) => x.baseManaRecovered_);
			}
			Func<CookingData.Types.RecipeStarResult, int> func = default(Func<CookingData.Types.RecipeStarResult, int>);
			if (_003C_003Ec._003C_003E9__130_1 == null)
			{
				func = (Func<CookingData.Types.RecipeStarResult, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CookingData.Types.RecipeStarResult x) => x.manaRecoveredIngredientPercentage_));
			}
			Func<CookingData, int> func2 = default(Func<CookingData, int>);
			if (_003C_003Ec._003C_003E9__130_2 == null)
			{
				func2 = (Func<CookingData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CookingData x) => x.maxManaRecovered_));
			}
			return this.TotalIngredientsValue(recipeItemData, (IEnumerable<>)ingredientsUsed, (Func<, >)(object)_003C_003E9__130_, (Func<, >)(object)func, (Func<, >)(object)func2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F83")]
		[Cpp2IlInjected.Address(RVA = "0x306B310", Offset = "0x3069D10", VA = "0x18306B310", Slot = "33")]
		public unsafe CurrencyCost GetSellPrice(ItemState itemState)
		{
			//IL_0046: Expected O, but got I4
			//IL_00c4: Expected I4, but got O
			//IL_00fa: Expected O, but got I4
			//IL_00fa: Expected O, but got I4
			RecipeItemData recipeItemData = RecipeItemData;
			if (recipeItemData != null)
			{
				if (itemState != null && itemState.stateCase_ == ItemState.StateOneofCase.MealData && ((RepeatedField<T>)(object)itemState.MealData.ingredientsUsed_).Count != 0)
				{
					RepeatedField<int> ingredientsUsed_ = itemState.MealData.ingredientsUsed_;
					Func<int, (Item, int)> func = (Func<int, (Item, int)>)(object)new Func<T, TResult>(CreateItemPriceTuple);
					int num = 0;
					IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, (Item, int)>((IEnumerable<>)(object)ingredientsUsed_, (Func<, >)(object)func);
					Func<(Item, int), int> _003C_003E9__131_ = _003C_003Ec._003C_003E9__131_1;
					if (_003C_003E9__131_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate((Item item, int price) x)
						{
							Item item = (Item)((ValueTuple<, >*)(&x))->Item1;
							/*Error: Unexpected end of block*/;
						};
					}
					IOrderedEnumerable<(Item, int)> orderedEnumerable = (IOrderedEnumerable<(Item, int)>)Enumerable.OrderByDescending<(Item, int), int>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__131_);
				}
				Func<Item, int> _003C_003E9__124_ = _003C_003Ec._003C_003E9__124_0;
				if (_003C_003E9__124_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Item x)
					{
						int itemID2 = x.ItemID;
						int result = default(int);
						return result;
					};
				}
				IEnumerable<> lowestIngredients = GetLowestIngredients<int>(recipeItemData, (Func<, >)(object)_003C_003E9__124_);
				CurrencyCost currencyCost = new CurrencyCost();
				int num2 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				currencyCost.id_ = (int)softCurrencyItem;
				Func<CookingData.Types.RecipeStarResult, int> func2 = default(Func<CookingData.Types.RecipeStarResult, int>);
				if (_003C_003Ec._003C_003E9__129_0 == null)
				{
					func2 = (Func<CookingData.Types.RecipeStarResult, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CookingData.Types.RecipeStarResult x) => x.sellPriceIngredientPercentage_));
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = (currencyCost.amount_ = this.TotalIngredientsValue(recipeItemData, lowestIngredients, (Func<, >)num4, (Func<, >)(object)func2, (Func<, >)num3));
				return currencyCost;
			}
			Exception ex = new Exception("A meal must have a valid recipe");
			/*Error: Unexpected end of block*/;
			[Cpp2IlInjected.Token(Token = "0x6002F8A")]
			[Cpp2IlInjected.Address(RVA = "0x306CE40", Offset = "0x306B840", VA = "0x18306CE40")]
			static (Item, int) CreateItemPriceTuple(int itemID)
			{
				long num6 = Convert.ToInt64((uint)itemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F84")]
		[Cpp2IlInjected.Address(RVA = "0x306B050", Offset = "0x3069A50", VA = "0x18306B050", Slot = "34")]
		public unsafe int GetManaRecovered(ItemState itemState)
		{
			//IL_0055: Expected O, but got I4
			if (!isMissionItem_)
			{
				if (itemState != null && itemState.stateCase_ == ItemState.StateOneofCase.MealData && ((RepeatedField<T>)(object)itemState.MealData.ingredientsUsed_).Count != 0)
				{
					RecipeItemData recipeItemData = RecipeItemData;
					if (recipeItemData != null)
					{
						RepeatedField<int> ingredientsUsed_ = itemState.MealData.ingredientsUsed_;
						Func<int, (Item, int)> func = (Func<int, (Item, int)>)(object)new Func<T, TResult>(CreateItemManaTuple);
						int num = 0;
						IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, (Item, int)>((IEnumerable<>)(object)ingredientsUsed_, (Func<, >)(object)func);
						Func<(Item, int), int> _003C_003E9__132_ = _003C_003Ec._003C_003E9__132_1;
						if (_003C_003E9__132_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate((Item item, int manaRecovered) x)
							{
								Item item = (Item)((ValueTuple<, >*)(&x))->Item1;
								/*Error: Unexpected end of block*/;
							};
						}
						IOrderedEnumerable<(Item, int)> orderedEnumerable = (IOrderedEnumerable<(Item, int)>)Enumerable.OrderByDescending<(Item, int), int>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__132_);
						return this.TotalIngredientsManaRecovered(recipeItemData, (IEnumerable<>)orderedEnumerable);
					}
					Exception ex = new Exception("A meal must have a valid recipe");
					/*Error: Unexpected end of block*/;
				}
				return manaRecovered_;
			}
			return manaRecovered_;
			[Cpp2IlInjected.Token(Token = "0x6002F8B")]
			[Cpp2IlInjected.Address(RVA = "0x306CD90", Offset = "0x306B790", VA = "0x18306CD90")]
			static (Item, int) CreateItemManaTuple(int itemID)
			{
				long num2 = Convert.ToInt64((uint)itemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F85")]
		[Cpp2IlInjected.Address(RVA = "0x3069DB0", Offset = "0x30687B0", VA = "0x183069DB0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MealItemData mealItemData = new MealItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F86")]
		[Cpp2IlInjected.Address(RVA = "0x3069E10", Offset = "0x3068810", VA = "0x183069E10", Slot = "29")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_0072: Expected O, but got I4
			RecipeItemData recipeItemData = RecipeItemData;
			if (recipeItemData != null)
			{
				if (isMissionItem_)
				{
				}
				RecipeItemData recipeItemData2 = RecipeItemData;
				Func<Item, int> _003C_003E9__125_ = _003C_003Ec._003C_003E9__125_0;
				if (_003C_003E9__125_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Item x)
					{
						int itemID = x.ItemID;
						int result = default(int);
						return result;
					};
				}
				IEnumerable<> lowestIngredients = GetLowestIngredients<int>(recipeItemData2, (Func<, >)(object)_003C_003E9__125_);
				int num = this.TotalIngredientsManaRecovered(recipeItemData2, lowestIngredients);
				if (manaRecovered_ != num)
				{
					string message = string.Format("{0} must be set to {1}, please click on \"{2}\"", "ManaRecovered", num, "Window/Script/Fix Meal ManaRecovered");
					context.AddInvalidMemberError(message, "ManaRecovered");
				}
				int num2 = mealType_;
				if ((object)typeof(Item).TypeHandle != null)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
					bool flag = default(bool);
					if (flag)
					{
						int iD = recipeItemData.ID;
						bool flag2 = default(bool);
						if (!flag2)
						{
							context.AddInvalidMemberError("QuestMeal recipe must be listed in Protodatabase.CookingRecipeList (In the quest section)", "MealType");
						}
					}
					if (!isMissionItem_)
					{
						context.AddInvalidMemberError("QuestMeal must be IsMissionItem", "IsMissionItem");
					}
				}
				int acceptedFloorTypesFlag = gridAreaData_.AcceptedFloorTypesFlag;
				bool flag3 = default(bool);
				if (!flag3)
				{
					context.AddError("Floor Type Preset is not set to Light Item.");
				}
				return;
			}
			throw new NullReferenceException();
		}
	}
}
