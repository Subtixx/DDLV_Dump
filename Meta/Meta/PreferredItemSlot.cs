using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000820")]
	public sealed class PreferredItemSlot : IMessage<PreferredItemSlot>, IMessage, IEquatable<PreferredItemSlot>, IDeepCloneable<PreferredItemSlot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000821")]
		public class PreferredItemCache
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002075")]
			public readonly Dictionary<Item, List<Item>> ItemsInPool = (Dictionary<Item, List<Item>>)(object)new Dictionary<TKey, TValue>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002076")]
			public readonly Dictionary<Item, HashSet<VillageAreaType>> AllLocationsForItem = (Dictionary<Item, HashSet<VillageAreaType>>)(object)new Dictionary<TKey, TValue>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002077")]
			public readonly Dictionary<Item, PreferredItemDifficulty> LowestDifficultyForItem = (Dictionary<Item, PreferredItemDifficulty>)(object)new Dictionary<TKey, TValue>();

			[Cpp2IlInjected.Token(Token = "0x6004402")]
			[Cpp2IlInjected.Address(RVA = "0x10D4360", Offset = "0x10D2D60", VA = "0x1810D4360")]
			public PreferredItemCache()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400206C")]
		private static readonly MessageParser<PreferredItemSlot> _parser = (MessageParser<PreferredItemSlot>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new PreferredItemSlot()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400206D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400206E")]
		public const int PreferredItemIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400206F")]
		private int preferredItemId_;

		[Cpp2IlInjected.Token(Token = "0x4002070")]
		public const int GiftedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002071")]
		private bool gifted_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002072")]
		public PreferredItemDifficulty Difficulty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002073")]
		public Item PoolItem = Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002074")]
		public List<ActivityItemType> ValidActivityItemTypes;

		[Cpp2IlInjected.Token(Token = "0x17000B22")]
		[DebuggerNonUserCode]
		public static MessageParser<PreferredItemSlot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60043E4")]
			[Cpp2IlInjected.Address(RVA = "0x7C8590", Offset = "0x7C6F90", VA = "0x1807C8590")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B23")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60043E5")]
			[Cpp2IlInjected.Address(RVA = "0x7C84C0", Offset = "0x7C6EC0", VA = "0x1807C84C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B24")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60043E6")]
			[Cpp2IlInjected.Address(RVA = "0x7C8650", Offset = "0x7C7050", VA = "0x1807C8650", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B25")]
		[DebuggerNonUserCode]
		public int PreferredItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60043EA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return preferredItemId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043EB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				preferredItemId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B26")]
		[DebuggerNonUserCode]
		public bool Gifted
		{
			[Cpp2IlInjected.Token(Token = "0x60043EC")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return gifted_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043ED")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				gifted_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B27")]
		public Item PreferredItem
		{
			[Cpp2IlInjected.Token(Token = "0x60043F9")]
			[Cpp2IlInjected.Address(RVA = "0x7C85F0", Offset = "0x7C6FF0", VA = "0x1807C85F0")]
			get
			{
				long num = Convert.ToInt64((uint)preferredItemId_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C6DA0", VA = "0x1807C83A0")]
		[DebuggerNonUserCode]
		public PreferredItemSlot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60043E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C8410", Offset = "0x7C6E10", VA = "0x1807C8410")]
		[DebuggerNonUserCode]
		public PreferredItemSlot(PreferredItemSlot other)
		{
			int num = (preferredItemId_ = other.preferredItemId_);
			bool flag = (gifted_ = other.gifted_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60043E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C41F0", Offset = "0x7C2BF0", VA = "0x1807C41F0", Slot = "10")]
		[DebuggerNonUserCode]
		public PreferredItemSlot Clone()
		{
			//Discarded unreachable code: IL_0046
			PreferredItemSlot preferredItemSlot = new PreferredItemSlot();
			Item item = (preferredItemSlot.PoolItem = Item.Invalid);
			int num = (preferredItemSlot.preferredItemId_ = preferredItemId_);
			bool flag = (preferredItemSlot.gifted_ = gifted_);
			UnknownFieldSet unknownFieldSet = (preferredItemSlot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return preferredItemSlot;
		}

		[Cpp2IlInjected.Token(Token = "0x60043EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4310", Offset = "0x7C2D10", VA = "0x1807C4310", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)preferredItemId_ == (IntPtr)typeof(PreferredItemSlot).TypeHandle && (IntPtr)(gifted_ ? 1 : 0) == (IntPtr)typeof(PreferredItemSlot).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60043EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PreferredItemSlot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.preferredItemId_;
				if (preferredItemId_ == num)
				{
					bool flag = other.gifted_;
					if (gifted_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60043F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (preferredItemId_ != 0)
				{
				}
				if (gifted_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60043F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F40", Offset = "0x7C6940", VA = "0x1807C7F40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60043F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (preferredItemId_ != 0)
			{
				int value = preferredItemId_;
				output.WriteInt32(value);
			}
			if (gifted_)
			{
				bool value2 = gifted_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60043F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C4140", Offset = "0x7C2B40", VA = "0x1807C4140", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = preferredItemId_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60043F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PreferredItemSlot other)
		{
			if (other != null)
			{
				int num = other.preferredItemId_;
				if (num != 0)
				{
					preferredItemId_ = num;
				}
				bool flag = other.gifted_;
				if (flag)
				{
					gifted_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (preferredItemId_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (gifted_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C7170", Offset = "0x7C5B70", VA = "0x1807C7170", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = preferredItemId_;
			}
			if (fieldNumber == 2)
			{
				bool flag = gifted_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60043F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E70", Offset = "0x7C6870", VA = "0x1807C7E70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				preferredItemId_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			gifted_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60043F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				preferredItemId_ = 0;
				break;
			case 2:
				gifted_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C79E0", Offset = "0x7C63E0", VA = "0x1807C79E0")]
		public void SelectItem(Profile profile, List<Item> alreadyAssignedItems, Random random, bool overrideProfiles, PreferredItemCache preferredItemCache)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60043FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C7400", Offset = "0x7C5E00", VA = "0x1807C7400")]
		private static List<Item> GetItemsWithDifficulty(PreferredItemDifficulty difficulty, IEnumerable<Item> items, PreferredItemCache preferredItemCache)
		{
			//Discarded unreachable code: IL_0016, IL_001c, IL_0022
			List<Item> list = (List<Item>)(object)new List<T>();
			if (list != null)
			{
				PreferredItemDifficulty preferredItemDifficulty = default(PreferredItemDifficulty);
				while (preferredItemDifficulty != difficulty)
				{
				}
			}
			if (list != null)
			{
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60043FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C72F0", Offset = "0x7C5CF0", VA = "0x1807C72F0")]
		public static PreferredItemDifficulty GetItemLowestDifficultyArea(Item originalItem, [Optional] PreferredItemCache preferredItemCache)
		{
			//Discarded unreachable code: IL_0037
			int itemID = originalItem.ItemID;
			if (preferredItemCache == null)
			{
				PreferredItemCache preferredItemCache2 = new PreferredItemCache();
			}
			Dictionary<Item, PreferredItemDifficulty> lowestDifficultyForItem = preferredItemCache.LowestDifficultyForItem;
			bool flag = default(bool);
			PreferredItemDifficulty lowestArea = default(PreferredItemDifficulty);
			if (!flag)
			{
				HashSet<VillageAreaType> hashSet = default(HashSet<VillageAreaType>);
				lowestArea = PreferredItemSlot.GetLowestArea((HashSet<>)(object)hashSet);
				Dictionary<Item, PreferredItemDifficulty> lowestDifficultyForItem2 = preferredItemCache.LowestDifficultyForItem;
				throw new NullReferenceException();
			}
			return lowestArea;
		}

		[Cpp2IlInjected.Token(Token = "0x60043FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5170", Offset = "0x7C3B70", VA = "0x1807C5170")]
		public unsafe static HashSet<VillageAreaType> GetAllLocationsForItem(Item originalItem, [Optional] PreferredItemCache preferredItemCache)
		{
			//IL_001f: Expected O, but got I4
			//IL_0256: Expected O, but got I4
			//IL_026f: Expected O, but got I4
			//IL_0271: Expected I4, but got O
			//IL_027f: Expected O, but got I4
			//IL_02c1: Expected O, but got I4
			//IL_02fe: Expected O, but got I4
			//IL_0339: Expected O, but got I4
			bool flag = default(bool);
			ActivityItemType activityItemType = default(ActivityItemType);
			IEnumerable<> enumerable = default(IEnumerable<>);
			RecipeItemData recipeItemData = default(RecipeItemData);
			RecipeItemData.Types.Ingredient ingredient = default(RecipeItemData.Types.Ingredient);
			Func<ICookingIngredient, bool> func = default(Func<ICookingIngredient, bool>);
			Func<ICookingIngredient, bool> func3 = default(Func<ICookingIngredient, bool>);
			RecipeItemData.Types.Ingredient ingredient2 = default(RecipeItemData.Types.Ingredient);
			bool flag2 = default(bool);
			Func<ICookingIngredient, bool> func5 = default(Func<ICookingIngredient, bool>);
			RecipeItemData.Types.Ingredient ingredient3 = default(RecipeItemData.Types.Ingredient);
			Item item2 = default(Item);
			HashSet<VillageAreaType> hashSet6 = default(HashSet<VillageAreaType>);
			int num11 = default(int);
			SeedItemData seedItemData = default(SeedItemData);
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			Predicate<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate2 = default(Predicate<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>);
			Predicate<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight> predicate3 = default(Predicate<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>);
			SpawnRecurringEventAreaSpecification.Types.AreaList areaList = default(SpawnRecurringEventAreaSpecification.Types.AreaList);
			ActivityItemType activityItemType2 = default(ActivityItemType);
			IEnumerable<> enumerable3 = default(IEnumerable<>);
			ActivityItemType activityItemType3 = default(ActivityItemType);
			IEnumerable<> enumerable4 = default(IEnumerable<>);
			ActivityItemType activityItemType4 = default(ActivityItemType);
			ActivityItemType activityItemType5 = default(ActivityItemType);
			IEnumerable<> enumerable5 = default(IEnumerable<>);
			IngredientItemData ingredientItemData = default(IngredientItemData);
			ActivityItemType activityItemType6 = default(ActivityItemType);
			IEnumerable<> enumerable6 = default(IEnumerable<>);
			bool flag5 = default(bool);
			int num13 = default(int);
			while (true)
			{
				int itemID = originalItem.ItemID;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Item originalItem2 = (Item)itemID;
				if (preferredItemCache == null)
				{
					PreferredItemCache preferredItemCache2 = new PreferredItemCache();
				}
				Dictionary<Item, HashSet<VillageAreaType>> allLocationsForItem = preferredItemCache.AllLocationsForItem;
				Item key = originalItem2;
				if (((Dictionary<TKey, TValue>)(object)allLocationsForItem).TryGetValue((TKey)key, out *(TValue*)num))
				{
					continue;
				}
				Item itemToCheck = originalItem2;
				Dictionary<VillageAreaType, int> orderedAreas = (Dictionary<VillageAreaType, int>)(object)ProtoDatabase.Instance.Get<PreferredItemSettings>("PreferredItemSettings").GetOrderedAreas();
				HashSet<VillageAreaType> hashSet = (HashSet<VillageAreaType>)(object)new HashSet<T>();
				if (!flag)
				{
					continue;
				}
				HashSet<VillageAreaType>[] array;
				int num5;
				if (activityItemType == ActivityItemType.Meal)
				{
					Predicate<RecipeItemData> predicate = (Predicate<RecipeItemData>)(object)(Predicate<T>)delegate(RecipeItemData x)
					{
						int resultItemID = x.ResultItemID;
						throw new NullReferenceException();
					};
					if (enumerable == null)
					{
					}
					if (num == 0)
					{
						continue;
					}
					RecipeItemData recipe = recipeItemData;
					if (recipeItemData != null)
					{
						array = new HashSet<VillageAreaType>[((RepeatedField<T>)(object)recipeItemData.ingredients_).Count];
						HashSet<Item> hashSet2 = (HashSet<Item>)(object)new HashSet<T>();
						int i;
						num5 = (i = 0);
						if (num5 < array.Length)
						{
							RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient.ingredientCase_;
							if (ingredient != null)
							{
								if (ingredient != null)
								{
									if (ingredient != null)
									{
										if (ingredientCase_ != RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
										{
											goto IL_0232;
										}
										int num6 = i;
										Func<ICookingIngredient, bool> func2 = func;
										if (func2 == null)
										{
											func = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate(ICookingIngredient x)
											{
												//Discarded unreachable code: IL_0028
												RepeatedField<RecipeItemData.Types.Ingredient> ingredients_3 = recipe.ingredients_;
												int index3 = i;
												Item[] tags = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_3)[index3]).Tags;
												return ItemDataExtensions.HasAllTags((IHasTags)x, (IEnumerable<>)(object)tags);
											};
										}
										HashSet<VillageAreaType> hashSet3 = (HashSet<VillageAreaType>)(object)PreferredItemSlot._003CGetAllLocationsForItem_003Eg__GetAllLocationsForCookingIngredients_007C41_0((Func<, >)(object)func2, preferredItemCache);
										if (hashSet3 != null && hashSet3 == null)
										{
											continue;
										}
									}
									int num7 = i;
									Func<ICookingIngredient, bool> func4 = func3;
									if (func4 == null)
									{
										func3 = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate
										{
											//Discarded unreachable code: IL_0028
											RepeatedField<RecipeItemData.Types.Ingredient> ingredients_2 = recipe.ingredients_;
											int index2 = i;
											Item[] itemsList = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_2)[index2]).ItemsList;
											return Enumerable.Contains<Item>((IEnumerable<>)(object)itemsList, (Item)itemsList);
										};
									}
									HashSet<VillageAreaType> hashSet4 = (HashSet<VillageAreaType>)(object)PreferredItemSlot._003CGetAllLocationsForItem_003Eg__GetAllLocationsForCookingIngredients_007C41_0((Func<, >)(object)func4, preferredItemCache);
									if (hashSet4 != null && hashSet4 == null)
									{
										continue;
									}
								}
								int num8 = i;
								Item? anyItem = (Item?)ingredient2.get_AnyItem();
								if (!flag2)
								{
									goto IL_0232;
								}
								int num9 = i;
								Func<ICookingIngredient, bool> func6 = func5;
								if (func6 == null)
								{
									func5 = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate
									{
										RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = recipe.ingredients_;
										int index = i;
										Item? anyItem2 = (Item?)((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_)[index]).get_AnyItem();
										throw new NullReferenceException();
									};
								}
								HashSet<VillageAreaType> hashSet5 = (HashSet<VillageAreaType>)(object)PreferredItemSlot._003CGetAllLocationsForItem_003Eg__GetAllLocationsForCookingIngredients_007C41_0((Func<, >)(object)func6, preferredItemCache);
								if (hashSet5 != null && hashSet5 == null)
								{
									continue;
								}
							}
							int num10 = i;
							Item? item = (Item?)ingredient3.get_Item();
							int itemID2 = item2.ItemID;
							if (hashSet6 == null || hashSet6 != null)
							{
								break;
							}
							continue;
						}
						goto IL_0232;
					}
				}
				goto IL_0284;
				IL_02df:
				if (num11 == 0)
				{
					continue;
				}
				if (seedItemData != null)
				{
					VillageAreaType villageArea_ = seedItemData.villageArea_;
					bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)villageArea_);
				}
				if (enumerable2 == null)
				{
					continue;
				}
				if ((long)num11 < (long)(IntPtr)enumerable2)
				{
					if (predicate2 == null)
					{
						predicate3 = (predicate2 = (Predicate<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>)(object)(Predicate<T>)delegate(WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight x)
						{
							//Discarded unreachable code: IL_0011
							Item item3 = itemToCheck;
							return (IntPtr)x.itemID_ == (IntPtr)item3;
						});
					}
					if (ProtoExtensions.Exists<WildCropsSpawningInVillageRecurringEventItemData.Types.ItemAndWeight>((RepeatedField<>)num11, (Predicate<>)(object)predicate3))
					{
						RepeatedField<VillageAreaType> areas_ = areaList.areas_;
						((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)(object)areas_);
					}
					num11++;
				}
				goto IL_0354;
				IL_0354:
				if (activityItemType2 == ActivityItemType.Fish)
				{
					if (enumerable3 == null)
					{
						continue;
					}
					if ((long)num11 < (long)(IntPtr)enumerable3)
					{
						num11++;
					}
				}
				if (activityItemType3 == ActivityItemType.Mineral)
				{
					if (enumerable4 == null)
					{
						continue;
					}
					if ((long)num11 < (long)(IntPtr)enumerable4)
					{
						num11++;
					}
				}
				if (activityItemType4 == ActivityItemType.Flower)
				{
					/*Error: Could not find block for branch target IL_0390*/;
				}
				continue;
				IL_0284:
				if (activityItemType5 == ActivityItemType.Ingredient)
				{
					Predicate<IngredientItemData> predicate4 = (Predicate<IngredientItemData>)(object)(Predicate<T>)delegate(IngredientItemData x)
					{
						int iD = x.ID;
						throw new NullReferenceException();
					};
					if (enumerable5 == null)
					{
					}
					if (num11 == 0)
					{
						continue;
					}
					if (ingredientItemData != null)
					{
						if (ingredientItemData.availableInStall_)
						{
							goto IL_02df;
						}
						int num12 = 0;
						bool flag4 = ((HashSet<T>)(object)hashSet).Add((T)num12);
					}
				}
				if (activityItemType6 == ActivityItemType.Crop)
				{
					Predicate<SeedItemData> predicate5 = (Predicate<SeedItemData>)(object)(Predicate<T>)delegate(SeedItemData x)
					{
						Item producedItem = x.ProducedItem;
						throw new NullReferenceException();
					};
					if (enumerable6 != null)
					{
					}
					goto IL_02df;
				}
				goto IL_0354;
				IL_0232:
				if (num5 < array.Length)
				{
					if (array[num5] != null)
					{
						if (flag5 && (long)(IntPtr)((Dictionary<TKey, TValue>)(object)orderedAreas)[(TKey)num3] >= (long)num13)
						{
							continue;
						}
						int num14 = 0;
						if (preferredItemCache != null)
						{
							continue;
						}
						int num15 = (int)((Dictionary<TKey, TValue>)(object)orderedAreas)[(TKey)num3];
					}
					num5++;
				}
				bool flag6 = ((HashSet<T>)(object)hashSet).Add((T)num3);
				num11 = 0;
				goto IL_0284;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60043FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C75C0", Offset = "0x7C5FC0", VA = "0x1807C75C0")]
		private static PreferredItemDifficulty GetLowestArea(HashSet<VillageAreaType> areas)
		{
			//Discarded unreachable code: IL_0049, IL_004f
			int num = 0;
			bool flag = default(bool);
			if (areas != null && flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					VillageAreaType area = VillageAreaType.Beach;
					Predicate<PreferredDifficultyToArea> predicate = (Predicate<PreferredDifficultyToArea>)(object)(Predicate<T>)delegate(PreferredDifficultyToArea y)
					{
						//Discarded unreachable code: IL_0016
						//IL_0015: Expected O, but got I4
						RepeatedField<VillageAreaType> areas_ = y.areas_;
						VillageAreaType villageAreaType = area;
						return ((RepeatedField<T>)(object)areas_).Contains((T)villageAreaType);
					};
					PreferredDifficultyToArea preferredDifficultyToArea = default(PreferredDifficultyToArea);
					bool flag3 = (int)preferredDifficultyToArea.difficulty_ < num;
					while (num == (flag3 ? 1 : 0))
					{
					}
				}
				PreferredItemDifficulty result = default(PreferredItemDifficulty);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60043FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C43A0", Offset = "0x7C2DA0", VA = "0x1807C43A0")]
		private static List<Item> GetAllItemsInPool(Item poolItem)
		{
			//Discarded unreachable code: IL_026f
			uint capacity = default(uint);
			PreferencePoolItemData preferencePoolItemData = default(PreferencePoolItemData);
			IEnumerable<> enumerable = default(IEnumerable<>);
			IEnumerable<> enumerable4 = default(IEnumerable<>);
			Func<ICookingIngredient, Item> func3 = default(Func<ICookingIngredient, Item>);
			IEnumerable<> enumerable7 = default(IEnumerable<>);
			IEnumerable<> enumerable8 = default(IEnumerable<>);
			Func<MealItemData, Item> func5 = default(Func<MealItemData, Item>);
			IEnumerable<> enumerable11 = default(IEnumerable<>);
			Func<MineralItemData, Item> func7 = default(Func<MineralItemData, Item>);
			IEnumerable<> enumerable14 = default(IEnumerable<>);
			Func<ActivityItemData, Item> func9 = default(Func<ActivityItemData, Item>);
			while (true)
			{
				List<Item> list = (List<Item>)(object)new List<T>((int)capacity);
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				PreferencePoolItemData poolItemData = preferencePoolItemData;
				PreferencePoolItemData preferencePoolItemData2 = poolItemData;
				if (preferencePoolItemData2.favoriteFlowers_.inclusions_.inclusionTypeCase_ != 0)
				{
					ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
					Func<FlowerItemData, bool> func = (Func<FlowerItemData, bool>)(object)(Func<T, TResult>)delegate(FlowerItemData x)
					{
						//IL_0059: Expected O, but got I4
						//IL_00cc: Expected O, but got I4
						//IL_0107: Expected O, but got I4
						//IL_0170: Expected O, but got I4
						PreferencePoolItemData.Types.FavoriteFlower.Types.InclusionsFlower inclusions_5 = poolItemData.favoriteFlowers_.inclusions_;
						PreferencePoolItemData.Types.FavoriteFlower.Types.InclusionsFlower.InclusionTypeOneofCase inclusionTypeCase_5 = inclusions_5.inclusionTypeCase_;
						if (inclusionTypeCase_5 != PreferencePoolItemData.Types.FavoriteFlower.Types.InclusionsFlower.InclusionTypeOneofCase.All)
						{
							if (inclusionTypeCase_5 == PreferencePoolItemData.Types.FavoriteFlower.Types.InclusionsFlower.InclusionTypeOneofCase.Custom)
							{
								PreferencePoolItemData.Types.FavoriteFlower.Types.FlowerProperties custom6 = inclusions_5.Custom;
								FlowerItemData flowerItemData = x;
								RepeatedField<int> specificItems_9 = custom6.specificItems_;
								int iD13 = flowerItemData.ID;
								if (((RepeatedField<T>)(object)specificItems_9).Contains((T)iD13))
								{
									goto IL_00d2;
								}
							}
							RepeatedField<int> dominantColor_3 = poolItemData.favoriteFlowers_.inclusions_.Custom.dominantColor_;
							Predicate<int> predicate11 = (Predicate<int>)(object)(Predicate<T>)((int y) => ((RepeatedField<T>)(object)x.tags_).Contains((T)y));
							if (!((RepeatedField<>)(object)dominantColor_3).Any<int>((Predicate<>)(object)predicate11))
							{
								PreferencePoolItemData.Types.FavoriteFlower.Types.FlowerProperties custom7 = poolItemData.favoriteFlowers_.inclusions_.Custom;
								FlowerItemData flowerItemData2 = x;
								RepeatedField<FlowerRarity> rarity_ = custom7.rarity_;
								FlowerRarity rarity_2 = flowerItemData2.rarity_;
								if (!((RepeatedField<T>)(object)rarity_).Contains((T)rarity_2))
								{
									goto IL_017f;
								}
							}
						}
						goto IL_00d2;
						IL_017f:
						throw new NullReferenceException();
						IL_00d2:
						PreferencePoolItemData.Types.FavoriteFlower.Types.FlowerProperties exclusions_5 = poolItemData.favoriteFlowers_.exclusions_;
						FlowerItemData flowerItemData3 = x;
						RepeatedField<int> specificItems_10 = exclusions_5.specificItems_;
						int iD14 = flowerItemData3.ID;
						if (!((RepeatedField<T>)(object)specificItems_10).Contains((T)iD14))
						{
							RepeatedField<int> dominantColor_4 = poolItemData.favoriteFlowers_.exclusions_.dominantColor_;
							Predicate<int> predicate12 = (Predicate<int>)(object)(Predicate<T>)((int y) => ((RepeatedField<T>)(object)x.tags_).Contains((T)y));
							if (!((RepeatedField<>)(object)dominantColor_4).Any<int>((Predicate<>)(object)predicate12))
							{
								PreferencePoolItemData.Types.FavoriteFlower.Types.FlowerProperties exclusions_6 = poolItemData.favoriteFlowers_.exclusions_;
								FlowerItemData flowerItemData4 = x;
								RepeatedField<FlowerRarity> rarity_3 = exclusions_6.rarity_;
								FlowerRarity rarity_4 = flowerItemData4.rarity_;
								if (!((RepeatedField<T>)(object)rarity_3).Contains((T)rarity_4))
								{
									return x.CanGiveItem();
								}
							}
						}
						goto IL_017f;
					};
					IEnumerable<FlowerItemData> enumerable2 = (IEnumerable<FlowerItemData>)Enumerable.Where<FlowerItemData>(enumerable, (Func<, >)(object)func);
					Func<FlowerItemData, Item> _003C_003E9__43_ = _003C_003Ec._003C_003E9__43_1;
					if (_003C_003E9__43_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(FlowerItemData x)
						{
							int iD12 = x.ID;
							throw new NullReferenceException();
						};
					}
					IEnumerable<FlowerItemData> enumerable3 = (IEnumerable<FlowerItemData>)Enumerable.Select<FlowerItemData, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)_003C_003E9__43_);
					((List<T>)(object)list).AddRange((IEnumerable<>)enumerable3);
				}
				if (preferencePoolItemData2.favoriteIngredients_.inclusions_.inclusionTypeCase_ == PreferencePoolItemData.Types.FavoriteIngredient.Types.InclusionsIngredient.InclusionTypeOneofCase.None)
				{
					continue;
				}
				ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
				Func<ICookingIngredient, bool> func2 = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate(ICookingIngredient x)
				{
					//IL_014b: Expected O, but got I4
					PreferencePoolItemData.Types.FavoriteIngredient.Types.InclusionsIngredient inclusions_4 = poolItemData.favoriteIngredients_.inclusions_;
					PreferencePoolItemData.Types.FavoriteIngredient.Types.InclusionsIngredient.InclusionTypeOneofCase inclusionTypeCase_4 = inclusions_4.inclusionTypeCase_;
					if (inclusionTypeCase_4 != PreferencePoolItemData.Types.FavoriteIngredient.Types.InclusionsIngredient.InclusionTypeOneofCase.All)
					{
						if (inclusionTypeCase_4 == PreferencePoolItemData.Types.FavoriteIngredient.Types.InclusionsIngredient.InclusionTypeOneofCase.Custom)
						{
							PreferencePoolItemData.Types.FavoriteIngredient.Types.IngredientProperties custom4 = inclusions_4.Custom;
							ICookingIngredient cookingIngredient = x;
							RepeatedField<int> specificItems_7 = custom4.specificItems_;
							bool flag = default(bool);
							if (flag)
							{
								goto IL_00b2;
							}
						}
						PreferencePoolItemData.Types.FavoriteIngredient.Types.IngredientProperties custom5 = poolItemData.favoriteIngredients_.inclusions_.Custom;
						ICookingIngredient cookingIngredient2 = x;
						RepeatedField<int> ingredientType_ = custom5.ingredientType_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							RepeatedField<int> ingredientTags_ = poolItemData.favoriteIngredients_.inclusions_.Custom.ingredientTags_;
							Predicate<int> predicate9 = (Predicate<int>)(object)(Predicate<T>)delegate
							{
								//Discarded unreachable code: IL_0009
								ICookingIngredient cookingIngredient6 = x;
								bool result5 = default(bool);
								return result5;
							};
							if (!((RepeatedField<>)(object)ingredientTags_).Any<int>((Predicate<>)(object)predicate9))
							{
								goto IL_014c;
							}
						}
					}
					goto IL_00b2;
					IL_014c:
					throw new NullReferenceException();
					IL_00b2:
					PreferencePoolItemData.Types.FavoriteIngredient.Types.IngredientProperties exclusions_3 = poolItemData.favoriteIngredients_.exclusions_;
					ICookingIngredient cookingIngredient3 = x;
					RepeatedField<int> specificItems_8 = exclusions_3.specificItems_;
					bool flag3 = default(bool);
					if (!flag3)
					{
						PreferencePoolItemData.Types.FavoriteIngredient.Types.IngredientProperties exclusions_4 = poolItemData.favoriteIngredients_.exclusions_;
						ICookingIngredient cookingIngredient4 = x;
						RepeatedField<int> ingredientType_2 = exclusions_4.ingredientType_;
						bool flag4 = default(bool);
						if (!flag4)
						{
							RepeatedField<int> ingredientTags_2 = poolItemData.favoriteIngredients_.exclusions_.ingredientTags_;
							Predicate<int> predicate10 = (Predicate<int>)(object)(Predicate<T>)delegate
							{
								//Discarded unreachable code: IL_0009
								ICookingIngredient cookingIngredient5 = x;
								bool result4 = default(bool);
								return result4;
							};
							if (!((RepeatedField<>)(object)ingredientTags_2).Any<int>((Predicate<>)(object)predicate10))
							{
								int num2 = default(int);
								if (x == null)
								{
									num2 = 0;
								}
								if (num2 != 0)
								{
									return ((IItemData)num2).CanGiveItem();
								}
								throw new InvalidCastException();
							}
						}
					}
					goto IL_014c;
				};
				IEnumerable<ICookingIngredient> enumerable5 = (IEnumerable<ICookingIngredient>)Enumerable.Where<ICookingIngredient>(enumerable4, (Func<, >)(object)func2);
				if (_003C_003Ec._003C_003E9__43_5 == null)
				{
					func3 = (Func<ICookingIngredient, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					});
				}
				IEnumerable<ICookingIngredient> enumerable6 = (IEnumerable<ICookingIngredient>)Enumerable.Select<ICookingIngredient, Item>((IEnumerable<>)enumerable5, (Func<, >)(object)func3);
				((List<T>)(object)list).AddRange((IEnumerable<>)enumerable6);
				if (poolItemData.favoriteMeals_.inclusions_.inclusionTypeCase_ == PreferencePoolItemData.Types.FavoriteMeal.Types.InclusionsMeal.InclusionTypeOneofCase.None)
				{
					continue;
				}
				ItemDatabase _003CInstance_003Ek__BackingField4 = ItemDatabase.Instance;
				if (enumerable7 != null && enumerable7 == null)
				{
					break;
				}
				RecipeItemData[] mealRecipes = (RecipeItemData[])(object)enumerable7;
				ItemDatabase _003CInstance_003Ek__BackingField5 = ItemDatabase.Instance;
				Func<MealItemData, bool> func4 = (Func<MealItemData, bool>)(object)(Func<T, TResult>)delegate(MealItemData x)
				{
					//IL_0065: Expected O, but got I4
					//IL_00aa: Expected O, but got I4
					//IL_011d: Expected O, but got I4
					//IL_015d: Expected O, but got I4
					PreferencePoolItemData.Types.FavoriteMeal.Types.InclusionsMeal inclusions_3 = poolItemData.favoriteMeals_.inclusions_;
					PreferencePoolItemData.Types.FavoriteMeal.Types.InclusionsMeal.InclusionTypeOneofCase inclusionTypeCase_3 = inclusions_3.inclusionTypeCase_;
					if (inclusionTypeCase_3 != PreferencePoolItemData.Types.FavoriteMeal.Types.InclusionsMeal.InclusionTypeOneofCase.All)
					{
						if (inclusionTypeCase_3 == PreferencePoolItemData.Types.FavoriteMeal.Types.InclusionsMeal.InclusionTypeOneofCase.Custom)
						{
							PreferencePoolItemData.Types.FavoriteMeal.Types.MealProperties custom2 = inclusions_3.Custom;
							MealItemData mealItemData = x;
							RepeatedField<int> specificItems_5 = custom2.specificItems_;
							int iD8 = mealItemData.ID;
							if (((RepeatedField<T>)(object)specificItems_5).Contains((T)iD8))
							{
								goto IL_00eb;
							}
						}
						PreferencePoolItemData.Types.FavoriteMeal.Types.MealProperties custom3 = poolItemData.favoriteMeals_.inclusions_.Custom;
						MealItemData mealItemData2 = x;
						RepeatedField<int> mealType_ = custom3.mealType_;
						int mealType_2 = mealItemData2.mealType_;
						if (!((RepeatedField<T>)(object)mealType_).Contains((T)mealType_2))
						{
							RepeatedField<int> containsIngredients_ = poolItemData.favoriteMeals_.inclusions_.Custom.containsIngredients_;
							Predicate<RecipeItemData> predicate3 = default(Predicate<RecipeItemData>);
							Predicate<int> predicate4 = (Predicate<int>)(object)(Predicate<T>)delegate
							{
								//Discarded unreachable code: IL_0030
								Predicate<RecipeItemData> predicate8 = predicate3;
								RecipeItemData[] array2 = mealRecipes;
								if (predicate8 == null)
								{
									predicate3 = (Predicate<RecipeItemData>)(object)(Predicate<T>)delegate(RecipeItemData z)
									{
										int resultItemID2 = z.ResultItemID;
										int iD11 = x.ID;
										throw new NullReferenceException();
									};
								}
								bool result3 = default(bool);
								return result3;
							};
							if (!((RepeatedField<>)(object)containsIngredients_).Any<int>((Predicate<>)(object)predicate4))
							{
								goto IL_01a2;
							}
						}
					}
					goto IL_00eb;
					IL_01a2:
					throw new NullReferenceException();
					IL_00eb:
					RepeatedField<int> specificItems_6 = poolItemData.favoriteMeals_.exclusions_.specificItems_;
					int iD9 = x.ID;
					if (!((RepeatedField<T>)(object)specificItems_6).Contains((T)iD9))
					{
						PreferencePoolItemData.Types.FavoriteMeal.Types.MealProperties exclusions_2 = poolItemData.favoriteMeals_.exclusions_;
						MealItemData mealItemData3 = x;
						RepeatedField<int> mealType_3 = exclusions_2.mealType_;
						int mealType_4 = mealItemData3.mealType_;
						if (!((RepeatedField<T>)(object)mealType_3).Contains((T)mealType_4))
						{
							RepeatedField<int> containsIngredients_2 = poolItemData.favoriteMeals_.exclusions_.containsIngredients_;
							Predicate<RecipeItemData> predicate5 = default(Predicate<RecipeItemData>);
							Predicate<int> predicate6 = (Predicate<int>)(object)(Predicate<T>)delegate
							{
								//Discarded unreachable code: IL_0030
								Predicate<RecipeItemData> predicate7 = predicate5;
								RecipeItemData[] array = mealRecipes;
								if (predicate7 == null)
								{
									predicate5 = (Predicate<RecipeItemData>)(object)(Predicate<T>)delegate(RecipeItemData z)
									{
										int resultItemID = z.ResultItemID;
										int iD10 = x.ID;
										throw new NullReferenceException();
									};
								}
								bool result2 = default(bool);
								return result2;
							};
							if (!((RepeatedField<>)(object)containsIngredients_2).Any<int>((Predicate<>)(object)predicate6))
							{
								return x.CanGiveItem();
							}
						}
					}
					goto IL_01a2;
				};
				IEnumerable<MealItemData> enumerable9 = (IEnumerable<MealItemData>)Enumerable.Where<MealItemData>(enumerable8, (Func<, >)(object)func4);
				if (_003C_003Ec._003C_003E9__43_9 == null)
				{
					func5 = (Func<MealItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MealItemData x)
					{
						int iD7 = x.ID;
						throw new NullReferenceException();
					});
				}
				IEnumerable<MealItemData> enumerable10 = (IEnumerable<MealItemData>)Enumerable.Select<MealItemData, Item>((IEnumerable<>)enumerable9, (Func<, >)(object)func5);
				((List<T>)(object)list).AddRange((IEnumerable<>)enumerable10);
				if (poolItemData.favoriteMinerals_.inclusions_.inclusionTypeCase_ == PreferencePoolItemData.Types.FavoriteMineral.Types.InclusionsMineral.InclusionTypeOneofCase.None)
				{
					continue;
				}
				ItemDatabase _003CInstance_003Ek__BackingField6 = ItemDatabase.Instance;
				Func<MineralItemData, bool> func6 = (Func<MineralItemData, bool>)(object)(Func<T, TResult>)delegate(MineralItemData x)
				{
					//IL_0056: Expected O, but got I4
					//IL_00c7: Expected O, but got I4
					PreferencePoolItemData.Types.FavoriteMineral.Types.InclusionsMineral inclusions_2 = poolItemData.favoriteMinerals_.inclusions_;
					PreferencePoolItemData.Types.FavoriteMineral.Types.InclusionsMineral.InclusionTypeOneofCase inclusionTypeCase_2 = inclusions_2.inclusionTypeCase_;
					if (inclusionTypeCase_2 != PreferencePoolItemData.Types.FavoriteMineral.Types.InclusionsMineral.InclusionTypeOneofCase.All)
					{
						if (inclusionTypeCase_2 == PreferencePoolItemData.Types.FavoriteMineral.Types.InclusionsMineral.InclusionTypeOneofCase.Custom)
						{
							PreferencePoolItemData.Types.FavoriteMineral.Types.InclusionsMineral.Types.InclusionCustomMineral custom = inclusions_2.Custom;
							MineralItemData mineralItemData = x;
							RepeatedField<int> specificItems_3 = custom.specificItems_;
							int iD5 = mineralItemData.ID;
							if (((RepeatedField<T>)(object)specificItems_3).Contains((T)iD5))
							{
								goto IL_0092;
							}
						}
						RepeatedField<int> dominantColor_ = poolItemData.favoriteMinerals_.inclusions_.Custom.dominantColor_;
						Predicate<int> predicate = (Predicate<int>)(object)(Predicate<T>)((int y) => ((RepeatedField<T>)(object)x.tags_).Contains((T)y));
						if (!((RepeatedField<>)(object)dominantColor_).Any<int>((Predicate<>)(object)predicate))
						{
							goto IL_012d;
						}
					}
					goto IL_0092;
					IL_0092:
					PreferencePoolItemData.Types.FavoriteMineral.Types.ExclusionsMineral exclusions_ = poolItemData.favoriteMinerals_.exclusions_;
					MineralItemData mineralItemData2 = x;
					RepeatedField<int> specificItems_4 = exclusions_.specificItems_;
					int iD6 = mineralItemData2.ID;
					if (!((RepeatedField<T>)(object)specificItems_4).Contains((T)iD6))
					{
						RepeatedField<int> dominantColor_2 = poolItemData.favoriteMinerals_.exclusions_.dominantColor_;
						Predicate<int> predicate2 = (Predicate<int>)(object)(Predicate<T>)((int y) => ((RepeatedField<T>)(object)x.tags_).Contains((T)y));
						if (!((RepeatedField<>)(object)dominantColor_2).Any<int>((Predicate<>)(object)predicate2) && (!poolItemData.favoriteMinerals_.exclusions_.shiny_ || !x.isShiny_))
						{
							return x.CanGiveItem();
						}
					}
					goto IL_012d;
					IL_012d:
					throw new NullReferenceException();
				};
				IEnumerable<MineralItemData> enumerable12 = (IEnumerable<MineralItemData>)Enumerable.Where<MineralItemData>(enumerable11, (Func<, >)(object)func6);
				if (_003C_003Ec._003C_003E9__43_15 == null)
				{
					func7 = (Func<MineralItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MineralItemData x)
					{
						int iD4 = x.ID;
						throw new NullReferenceException();
					});
				}
				IEnumerable<MineralItemData> enumerable13 = (IEnumerable<MineralItemData>)Enumerable.Select<MineralItemData, Item>((IEnumerable<>)enumerable12, (Func<, >)(object)func7);
				((List<T>)(object)list).AddRange((IEnumerable<>)enumerable13);
				if (poolItemData.favoriteCraftingMaterials_.inclusions_.inclusionTypeCase_ != 0)
				{
					ItemDatabase _003CInstance_003Ek__BackingField7 = ItemDatabase.Instance;
					Func<ActivityItemData, bool> func8 = (Func<ActivityItemData, bool>)(object)(Func<T, TResult>)delegate(ActivityItemData x)
					{
						//Discarded unreachable code: IL_006e
						//IL_003a: Expected O, but got I4
						//IL_0065: Expected O, but got I4
						PreferencePoolItemData.Types.FavoriteCraftingMaterial.Types.InclusionsCraftingMaterial inclusions_ = poolItemData.favoriteCraftingMaterials_.inclusions_;
						PreferencePoolItemData.Types.FavoriteCraftingMaterial.Types.InclusionsCraftingMaterial.InclusionTypeOneofCase inclusionTypeCase_ = inclusions_.inclusionTypeCase_;
						if (inclusionTypeCase_ == PreferencePoolItemData.Types.FavoriteCraftingMaterial.Types.InclusionsCraftingMaterial.InclusionTypeOneofCase.All)
						{
							goto IL_003d;
						}
						if (inclusionTypeCase_ == PreferencePoolItemData.Types.FavoriteCraftingMaterial.Types.InclusionsCraftingMaterial.InclusionTypeOneofCase.Custom)
						{
							RepeatedField<int> specificItems_ = inclusions_.Custom.specificItems_;
							int iD2 = x.ID;
							if (((RepeatedField<T>)(object)specificItems_).Contains((T)iD2))
							{
								goto IL_003d;
							}
						}
						goto IL_0068;
						IL_0068:
						int num = 0;
						goto IL_006b;
						IL_006b:
						bool result = default(bool);
						return result;
						IL_003d:
						RepeatedField<int> specificItems_2 = poolItemData.favoriteCraftingMaterials_.exclusions_.specificItems_;
						int iD3 = x.ID;
						if (((RepeatedField<T>)(object)specificItems_2).Contains((T)iD3))
						{
							goto IL_0068;
						}
						goto IL_006b;
					};
					IEnumerable<ActivityItemData> enumerable15 = (IEnumerable<ActivityItemData>)Enumerable.Where<ActivityItemData>(enumerable14, (Func<, >)(object)func8);
					if (_003C_003Ec._003C_003E9__43_19 == null)
					{
						func9 = (Func<ActivityItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ActivityItemData x)
						{
							int iD = x.ID;
							throw new NullReferenceException();
						});
					}
					IEnumerable<ActivityItemData> enumerable16 = (IEnumerable<ActivityItemData>)Enumerable.Select<ActivityItemData, Item>((IEnumerable<>)enumerable15, (Func<, >)(object)func9);
					((List<T>)(object)list).AddRange((IEnumerable<>)enumerable16);
				}
				return list;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004400")]
		[Cpp2IlInjected.Address(RVA = "0x7C8290", Offset = "0x7C6C90", VA = "0x1807C8290")]
		static PreferredItemSlot()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
