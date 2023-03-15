using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Google.Protobuf.Collections;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2001050")]
	public static class MissionFormula
	{
		[Cpp2IlInjected.Token(Token = "0x4004344")]
		private static Dictionary<int, LootTable> lootTables;

		[Cpp2IlInjected.Token(Token = "0x4004345")]
		private static int minScore;

		[Cpp2IlInjected.Token(Token = "0x4004346")]
		private static int maxScore;

		[Cpp2IlInjected.Token(Token = "0x6008483")]
		[Cpp2IlInjected.Address(RVA = "0x7FEBB0", Offset = "0x7FD5B0", VA = "0x1807FEBB0")]
		private static float CalculateScore(MissionObjective missionStep)
		{
			//Discarded unreachable code: IL_0042
			IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<MissionStepFormulaItemData>(ItemType.Formula);
			Func<MissionStepFormulaItemData, bool> func = (Func<MissionStepFormulaItemData, bool>)(object)(Func<T, TResult>)delegate(MissionStepFormulaItemData formula)
			{
				//Discarded unreachable code: IL_001d
				MissionObjectiveData.CustomStepOneofCase customStepCase = formula.CustomStepCase;
				MissionObjectiveData _003CData_003Ek__BackingField = missionStep.Data;
				return customStepCase == _003CData_003Ek__BackingField.customStepCase_;
			};
			if (Enumerable.FirstOrDefault<MissionStepFormulaItemData>(allByType, (Func<, >)(object)func) == null)
			{
				int num = 0;
			}
			MissionObjective missionObjective = missionStep;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008484")]
		[Cpp2IlInjected.Address(RVA = "0x7FF630", Offset = "0x7FE030", VA = "0x1807FF630")]
		private static bool MustCalculateBringItemScore(MissionObjective missionStep, int stepIndex)
		{
			//Discarded unreachable code: IL_01db, IL_01e3, IL_01fc
			MissionObjectiveData _003CData_003Ek__BackingField = missionStep.Data;
			if (_003CData_003Ek__BackingField.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.BringItem && _003CData_003Ek__BackingField.BringItem.targetItem_.itemToGive_.itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Variable && missionStep.Data.BringItem.targetItem_.itemToGive_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item)
			{
				ItemFilter itemFilter_ = missionStep.itemFilter_;
				if (itemFilter_ != null && itemFilter_.data_.type_ == ItemType.ActivityItem)
				{
					ItemSelector itemToGive = missionStep.Data.BringItem.targetItem_.itemToGive_;
					StepAmount amountToGive = missionStep.Data.BringItem.amountToGive_;
					ActivityItemType activityItemType_ = itemFilter_.data_.activityItemType_;
					if (activityItemType_ == ActivityItemType.Crop)
					{
						IEnumerable<MissionStep> previousSteps = (IEnumerable<MissionStep>)missionStep.MissionSubStep.MissionSlot.GetPreviousSteps(stepIndex);
						Func<MissionStep, IEnumerable<MissionObjective>> _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_6;
						if (_003C_003E9__1_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStep x) => (IEnumerable<MissionObjective>)x.get_AllObjectives());
						}
						IEnumerable<MissionStep> enumerable = (IEnumerable<MissionStep>)Enumerable.SelectMany<MissionStep, MissionObjective>((IEnumerable<>)previousSteps, (Func<, >)(object)_003C_003E9__1_);
					}
					if (activityItemType_ == ActivityItemType.Meal)
					{
						IEnumerable<MissionStep> previousSteps2 = (IEnumerable<MissionStep>)missionStep.MissionSubStep.MissionSlot.GetPreviousSteps(stepIndex);
						Func<MissionStep, IEnumerable<MissionObjective>> _003C_003E9__1_2 = _003C_003Ec._003C_003E9__1_4;
						if (_003C_003E9__1_2 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStep x) => (IEnumerable<MissionObjective>)x.get_AllObjectives());
						}
						IEnumerable<MissionStep> enumerable2 = (IEnumerable<MissionStep>)Enumerable.SelectMany<MissionStep, MissionObjective>((IEnumerable<>)previousSteps2, (Func<, >)(object)_003C_003E9__1_2);
					}
					if (activityItemType_ == (ActivityItemType)1)
					{
						IEnumerable<MissionStep> previousSteps3 = (IEnumerable<MissionStep>)missionStep.MissionSubStep.MissionSlot.GetPreviousSteps(stepIndex);
						Func<MissionStep, IEnumerable<MissionObjective>> _003C_003E9__1_3 = _003C_003Ec._003C_003E9__1_2;
						if (_003C_003E9__1_3 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStep x) => (IEnumerable<MissionObjective>)x.get_AllObjectives());
						}
						IEnumerable<MissionStep> enumerable3 = (IEnumerable<MissionStep>)Enumerable.SelectMany<MissionStep, MissionObjective>((IEnumerable<>)previousSteps3, (Func<, >)(object)_003C_003E9__1_3);
						MissionSlot missionSlot = missionStep.MissionSubStep.MissionSlot;
						Func<MissionStep, IEnumerable<MissionObjective>> func = default(Func<MissionStep, IEnumerable<MissionObjective>>);
						if (_003C_003Ec._003C_003E9__1_0 == null)
						{
							func = (Func<MissionStep, IEnumerable<MissionObjective>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStep x) => (IEnumerable<MissionObjective>)x.get_AllObjectives()));
						}
						IEnumerable<MissionStep> enumerable4 = default(IEnumerable<MissionStep>);
						IEnumerable<MissionStep> cpp2il__autoParamName__idx_ = (IEnumerable<MissionStep>)Enumerable.SelectMany<MissionStep, MissionObjective>((IEnumerable<>)enumerable4, (Func<, >)(object)func);
						Func<MissionObjective, bool> cpp2il__autoParamName__idx_2 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
						{
							if (x.Data.CatchFish != null && x.Data.CatchFish.conditionType_.typesCase_ == CatchFishConditionType.TypesOneofCase.Amount)
							{
								ItemSelector targetItem_ = x.Data.CatchFish.targetItem_;
								ItemSelector other = itemToGive;
								if (targetItem_.Equals(other))
								{
									StepAmount amountToCatch_ = x.Data.CatchFish.conditionType_.Amount.amountToCatch_;
									StepAmount other2 = amountToGive;
									return amountToCatch_.Equals(other2);
								}
							}
							int num = 0;
							throw new NullReferenceException();
						};
						return !((IEnumerable<>)cpp2il__autoParamName__idx_).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_2);
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008485")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6C0", Offset = "0x7FD0C0", VA = "0x1807FE6C0")]
		private static float CalculateBringItemScore(MissionObjective missionStep)
		{
			int num = 0;
			ItemFilter itemFilter_ = missionStep.itemFilter_;
			if (itemFilter_ != null && itemFilter_.data_.type_ == ItemType.ActivityItem)
			{
				MissionObjectiveData missionObjectiveData = new MissionObjectiveData();
				ActivityItemType activityItemType_ = itemFilter_.data_.activityItemType_;
				if (activityItemType_ == ActivityItemType.Crop)
				{
					CustomStepGardeningPlant customStepGardeningPlant = new CustomStepGardeningPlant();
					ItemSelector itemSelector = (customStepGardeningPlant.targetItem_ = missionStep.Data.BringItem.targetItem_.itemToGive_);
					missionObjectiveData.GardeningPlant = customStepGardeningPlant;
					CustomStepGardeningHarvest customStepGardeningHarvest = new CustomStepGardeningHarvest();
					ItemSelector itemSelector2 = (customStepGardeningHarvest.targetItem_ = missionStep.Data.BringItem.targetItem_.itemToGive_);
					missionObjectiveData.GardeningHarvest = customStepGardeningHarvest;
				}
				if (activityItemType_ == ActivityItemType.Meal)
				{
					CustomStepCookMeal customStepCookMeal = new CustomStepCookMeal();
					ItemSelector itemSelector3 = (customStepCookMeal.TargetMealItem = missionStep.Data.BringItem.targetItem_.itemToGive_);
					missionObjectiveData.CookMeal = customStepCookMeal;
				}
				if (missionObjectiveData != null)
				{
					if (missionObjectiveData == null)
					{
						goto IL_0166;
					}
					if (missionObjectiveData != null)
					{
						if (activityItemType_ != (ActivityItemType)1)
						{
							goto IL_0166;
						}
						CustomStepCookMeal customStepCookMeal2 = new CustomStepCookMeal();
						ItemSelector itemSelector4 = (customStepCookMeal2.TargetIngredientItem = missionStep.Data.BringItem.targetItem_.itemToGive_);
					}
					CustomStepCatchFish customStepCatchFish = new CustomStepCatchFish();
					ItemSelector itemSelector5 = (customStepCatchFish.targetItem_ = missionStep.Data.BringItem.targetItem_.itemToGive_);
					CatchFishConditionType catchFishConditionType = new CatchFishConditionType();
					CatchFishConditionAmount catchFishConditionAmount2 = (catchFishConditionType.Amount = new CatchFishConditionAmount());
					customStepCatchFish.conditionType_ = catchFishConditionType;
					missionObjectiveData.CatchFish = customStepCatchFish;
				}
				CustomStepPickUp customStepPickUp2 = (missionObjectiveData.PickUp = new CustomStepPickUp());
			}
			goto IL_0166;
			IL_0166:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008486")]
		[Cpp2IlInjected.Address(RVA = "0x7FED70", Offset = "0x7FD770", VA = "0x1807FED70")]
		public static float CalculateScore(MissionSlot missionSlot)
		{
			//Discarded unreachable code: IL_0047
			int num = 0;
			int num2 = 0;
			int count = ((RepeatedField<T>)(object)missionSlot.missionSteps_).Count;
			if (num < count)
			{
				if (missionSlot.IsValidStepIndex(num))
				{
					IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)missionSlot.missionSteps_)[num]).get_AllObjectives();
					bool flag = default(bool);
					if (allObjectives == null || flag)
					{
					}
					if (allObjectives == null)
					{
					}
				}
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008487")]
		[Cpp2IlInjected.Address(RVA = "0x7FF140", Offset = "0x7FDB40", VA = "0x1807FF140")]
		private unsafe static void InitLootTables()
		{
			//Discarded unreachable code: IL_0069, IL_0091, IL_0097, IL_009d, IL_00a3
			//IL_007a: Expected I4, but got O
			//IL_008b: Expected I4, but got O
			IEnumerable<LootTableItemData> enumerable2;
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num2 = default(uint);
			string s = default(string);
			while (true)
			{
				int num = 0;
				lootTables = (Dictionary<int, LootTable>)(object)new Dictionary<TKey, TValue>();
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Func<LootTableItemData, bool> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
				if (_003C_003E9__7_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((LootTableItemData l) => l.name_.StartsWith("RewardRequest!"));
				}
				enumerable2 = (IEnumerable<LootTableItemData>)Enumerable.Where<LootTableItemData>(enumerable, (Func<, >)(object)_003C_003E9__7_);
				if (enumerable2 == null)
				{
					break;
				}
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						break;
					}
					num++;
				}
				if (int.TryParse(s, out *(int*)num))
				{
					Dictionary<int, LootTable> dictionary = lootTables;
					throw new NullReferenceException();
				}
			}
			if (enumerable2 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008488")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFE0", Offset = "0x7FD9E0", VA = "0x1807FEFE0")]
		private unsafe static LootTable GetLootTable(float score)
		{
			//IL_001b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			InitLootTables();
			int num3 = minScore;
			bool flag = ((Dictionary<TKey, TValue>)(object)lootTables).TryGetValue((TKey)num3, out *(TValue*)num);
			throw new NullReferenceException();
		}
	}
}
