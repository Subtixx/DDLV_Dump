using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf.Collections;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2001055")]
	public static class MissionUtil
	{
		[Cpp2IlInjected.Token(Token = "0x600849B")]
		[Cpp2IlInjected.Address(RVA = "0x1A69AE0", Offset = "0x1A684E0", VA = "0x181A69AE0")]
		public static int ResolveScalableValue(IScalableValue scalableValue, int level)
		{
			//Discarded unreachable code: IL_0037
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				MissionScalingScript missionScalingScript = default(MissionScalingScript);
				if (missionScalingScript != null && missionScalingScript.scriptsCase_ != 0)
				{
				}
			}
			if (flag)
			{
				ExponentialScalingByLevel exponentialScalingByLevel = default(ExponentialScalingByLevel);
				int startLevel_ = exponentialScalingByLevel.startLevel_;
				int num = Math.Max(startLevel_, level);
				return Math.Min(startLevel_, level);
			}
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600849C")]
		[Cpp2IlInjected.Address(RVA = "0x1A69F50", Offset = "0x1A68950", VA = "0x181A69F50")]
		public static int ResolveWeightList(List<IScalableValue> weigths, Random random, IProfile profile)
		{
			//Discarded unreachable code: IL_002d
			Func<IScalableValue, int> func = (Func<IScalableValue, int>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				IProfile profile2 = profile;
				int result = default(int);
				return result;
			};
			return MissionUtil.ResolveWeightList(Enumerable.ToList<int>(Enumerable.Select<IScalableValue, int>((IEnumerable<>)weigths, (Func<, >)(object)func)), random);
		}

		[Cpp2IlInjected.Token(Token = "0x600849D")]
		[Cpp2IlInjected.Address(RVA = "0x1A69D80", Offset = "0x1A68780", VA = "0x181A69D80")]
		public static int ResolveWeightList(List<int> weights, Random random)
		{
			//Discarded unreachable code: IL_001d
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num2 = 0;
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			num2++;
			uint num4 = num4 + 4;
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600849E")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BB40", Offset = "0x1A6A540", VA = "0x181A6BB40")]
		public static ItemFilterData RunGenerator(MissionItemGenerator generator, Random random, IProfile profile, [Optional] string debugName)
		{
			int num = 0;
			ItemFilterData result = default(ItemFilterData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600849F")]
		[Cpp2IlInjected.Address(RVA = "0x1A6A070", Offset = "0x1A68A70", VA = "0x181A6A070")]
		public static ItemFilterData RunGenerator(MissionItemGenerator generator, Random random, IProfile profile, int randomMask, out int randomCount, [Optional] string debugName)
		{
			//IL_04bf: Expected O, but got I4
			int num4 = default(int);
			int num6 = default(int);
			Func<GeneratorWeightedItemIngredient, int> func = default(Func<GeneratorWeightedItemIngredient, int>);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			IEnumerable<ITagData> enumerable3 = default(IEnumerable<ITagData>);
			bool flag10 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				new _003C_003Ec__DisplayClass4_0().profile = profile;
				ItemFilterData itemFilterData = new ItemFilterData();
				GeneratorItem item_ = generator.item_;
				GeneratorItem.DefinitionsOneofCase definitionsCase_ = item_.definitionsCase_;
				if (definitionsCase_ != 0)
				{
					switch (definitionsCase_)
					{
					default:
						continue;
					case GeneratorItem.DefinitionsOneofCase.Item:
					{
						if (item_.ItemList != null && (long)generator.item_.ItemList.list_ != 0 && ((RepeatedField<T>)(object)generator.item_.ItemList.list_).Count > 0)
						{
							if (!generator.item_.ItemList.useAsFilter_)
							{
								RepeatedField<GeneratorWeightedItem> list_ = generator.item_.ItemList.list_;
								Func<GeneratorWeightedItem, ScalableValue> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_3;
								if (_003C_003E9__4_ == null)
								{
									_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GeneratorWeightedItem x) => x.weight_);
								}
								List<IScalableValue> list = (List<IScalableValue>)(object)Enumerable.ToList<IScalableValue>(Enumerable.Select<GeneratorWeightedItem, ScalableValue>((IEnumerable<>)(object)list_, (Func<, >)(object)_003C_003E9__4_));
								if (num4 == -1)
								{
									continue;
								}
								int num5 = (itemFilterData.item_ = ((GeneratorWeightedItem)((RepeatedField<T>)(object)generator.item_.ItemList.list_)[num4]).item_);
							}
							RepeatedField<int> itemList_ = itemFilterData.itemList_;
							RepeatedField<GeneratorWeightedItem> list_2 = generator.item_.ItemList.list_;
							Func<GeneratorWeightedItem, int> _003C_003E9__4_2 = _003C_003Ec._003C_003E9__4_1;
							if (_003C_003E9__4_2 == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GeneratorWeightedItem x) => x.item_);
							}
							IEnumerable<GeneratorWeightedItem> enumerable = (IEnumerable<GeneratorWeightedItem>)Enumerable.Select<GeneratorWeightedItem, int>((IEnumerable<>)(object)list_2, (Func<, >)(object)_003C_003E9__4_2);
							((RepeatedField<T>)(object)itemList_).AddRange((IEnumerable<>)enumerable);
						}
						if (generator.itemIngredient_.ItemList == null || (long)generator.itemIngredient_.ItemList.list_ == 0 || ((RepeatedField<T>)(object)generator.itemIngredient_.ItemList.list_).Count <= 0)
						{
							continue;
						}
						if (!generator.itemIngredient_.ItemList.useAsFilter_)
						{
							RepeatedField<GeneratorWeightedItemIngredient> list_3 = generator.itemIngredient_.ItemList.list_;
							Func<GeneratorWeightedItemIngredient, ScalableValue> _003C_003E9__4_3 = _003C_003Ec._003C_003E9__4_4;
							if (_003C_003E9__4_3 == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GeneratorWeightedItemIngredient x) => x.weight_);
							}
							List<IScalableValue> list2 = (List<IScalableValue>)(object)Enumerable.ToList<IScalableValue>(Enumerable.Select<GeneratorWeightedItemIngredient, ScalableValue>((IEnumerable<>)(object)list_3, (Func<, >)(object)_003C_003E9__4_3));
							if (num6 == -1)
							{
								continue;
							}
							RepeatedField<GeneratorWeightedItemIngredient> list_4 = generator.itemIngredient_.ItemList.list_;
						}
						RepeatedField<int> itemList_2 = itemFilterData.itemList_;
						RepeatedField<GeneratorWeightedItemIngredient> list_5 = generator.itemIngredient_.ItemList.list_;
						if (_003C_003Ec._003C_003E9__4_2 == null)
						{
							func = (Func<GeneratorWeightedItemIngredient, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GeneratorWeightedItemIngredient x) => x.item_));
						}
						IEnumerable<GeneratorWeightedItemIngredient> enumerable2 = (IEnumerable<GeneratorWeightedItemIngredient>)Enumerable.Select<GeneratorWeightedItemIngredient, int>((IEnumerable<>)(object)list_5, (Func<, >)(object)func);
						break;
					}
					case GeneratorItem.DefinitionsOneofCase.None:
						break;
					}
					if (!flag)
					{
						int item = generator.itemIngredient_.Item;
						if (!flag2)
						{
							continue;
						}
						int item2 = generator.itemIngredient_.Item;
					}
					int num7 = (itemFilterData.item_ = generator.item_.Item);
				}
				ItemType type_ = generator.type_;
				if (type_ == ItemType.None)
				{
					continue;
				}
				itemFilterData.type_ = type_;
				ActivityItemType activityItemType = (itemFilterData.activityItemType_ = generator.activityItemType_);
				CropTypeCondition cropTypeCondition = (itemFilterData.cropType_ = generator.cropType_);
				SeedTypeCondition seedTypeCondition = (itemFilterData.seedType_ = generator.seedType_);
				ScalableValue minUnlockLevel_ = generator.minUnlockLevel_;
				int level = (int)seedTypeCondition;
				int num8 = (itemFilterData.maxUnlockLevel_ = ResolveScalableValue(level: itemFilterData.minUnlockLevel_ = ResolveScalableValue(minUnlockLevel_, level), scalableValue: generator.maxUnlockLevel_));
				int minUnlockLevel_2 = itemFilterData.minUnlockLevel_;
				if (minUnlockLevel_2 > 0 && num8 > 0 && num8 < minUnlockLevel_2)
				{
					itemFilterData.maxUnlockLevel_ = minUnlockLevel_2;
				}
				FlowerRarityCondition flowerRarityCondition = (itemFilterData.flowerRarity_ = generator.flowerRarity_);
				int num9 = (itemFilterData.set_ = generator.set_);
				OptionalField complexity_ = itemFilterData.complexity_;
				OptionalField complexity_2 = generator.complexity_;
				complexity_.MergeFrom(complexity_2);
				OptionalField complexity_3 = itemFilterData.complexity_;
				if (flag3)
				{
					OptionalField complexity_4 = itemFilterData.complexity_;
					int length = Enum.GetNames(typeof(Complexity)).Length;
					int minValue = 0;
					int num10 = random.Next(minValue, length);
				}
				OptionalField mood_ = itemFilterData.mood_;
				OptionalField mood_2 = generator.mood_;
				mood_.MergeFrom(mood_2);
				OptionalField mood_3 = itemFilterData.mood_;
				if (flag4)
				{
					OptionalField mood_4 = generator.mood_;
					int length2 = Enum.GetNames(typeof(Mood)).Length;
					int minValue2 = 0;
					int num11 = random.Next(minValue2, length2);
				}
				OptionalField sturdiness_ = itemFilterData.sturdiness_;
				OptionalField sturdiness_2 = generator.sturdiness_;
				sturdiness_.MergeFrom(sturdiness_2);
				OptionalField sturdiness_3 = itemFilterData.sturdiness_;
				if (flag5)
				{
					OptionalField sturdiness_4 = itemFilterData.sturdiness_;
					int length3 = Enum.GetNames(typeof(Sturdiness)).Length;
					int minValue3 = 0;
					int num12 = random.Next(minValue3, length3);
				}
				OptionalField normality_ = itemFilterData.normality_;
				OptionalField normality_2 = generator.normality_;
				normality_.MergeFrom(normality_2);
				OptionalField normality_3 = itemFilterData.normality_;
				if (flag6)
				{
					OptionalField normality_4 = itemFilterData.normality_;
					int length4 = Enum.GetNames(typeof(Normality)).Length;
					int minValue4 = 0;
					int num13 = random.Next(minValue4, length4);
				}
				bool flag7 = (itemFilterData.requireAtLeastOneTag_ = generator.requireAtLeastOneTag_);
				RepeatedField<TagGroupWithRndOption> tags_ = generator.tags_;
				if (flag8)
				{
					TagGroupWithRndOption tagGroup = (TagGroupWithRndOption)num3;
					TagGroupWithRndOption tagGroupWithRndOption = tagGroup;
					if (!flag9)
					{
						RepeatedField<int> tags_2 = itemFilterData.tags_;
						RepeatedField<int> tags_3 = tagGroup.tags_;
						((RepeatedField<T>)(object)tags_2).AddRange((IEnumerable<>)(object)tags_3);
					}
					Func<ITagData, bool> func2 = (Func<ITagData, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0024
						int num15 = 0;
						uint num16 = default(uint);
						if (num15 < (int)num16)
						{
							num15 += num15;
							num15++;
						}
						int num17 = 0;
						TagGroupWithRndOption tagGroupWithRndOption2 = tagGroup;
						TagItemType tagItemType = default(TagItemType);
						return tagItemType == tagGroupWithRndOption2.tagType_;
					};
					IEnumerable<ITagData> enumerable4 = (IEnumerable<ITagData>)Enumerable.Where<ITagData>((IEnumerable<>)enumerable3, (Func<, >)(object)func2);
					int maxValue = Enumerable.Count<ITagData>((IEnumerable<>)enumerable4);
					int num14 = random.Next(maxValue);
					RepeatedField<int> tags_4 = itemFilterData.tags_;
					ITagData tagData = ((IEnumerable<>)enumerable4).ToArray<ITagData>()[num14];
				}
				if (num == 0)
				{
					OptionalField fishLocation_ = itemFilterData.fishLocation_;
					OptionalField fishLocation_2 = itemFilterData.fishLocation_;
					if (flag10)
					{
						break;
					}
				}
			}
			Func<FishingDataItemData, IEnumerable<VillageAreaType>> func3 = default(Func<FishingDataItemData, IEnumerable<VillageAreaType>>);
			if (_003C_003Ec._003C_003E9__4_6 == null)
			{
				func3 = (Func<FishingDataItemData, IEnumerable<VillageAreaType>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(FishingDataItemData x)
				{
					RepeatedField<VillageAreaType> locations_ = x.locations_;
					throw new NullReferenceException();
				});
			}
			IEnumerable<> enumerable5 = default(IEnumerable<>);
			IEnumerable<VillageAreaType> enumerable6 = (IEnumerable<VillageAreaType>)Enumerable.Distinct<VillageAreaType>(Enumerable.SelectMany<FishingDataItemData, VillageAreaType>(enumerable5, (Func<, >)(object)func3));
			/*Error: Unexpected end of block*/;
		}
	}
}
