using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AE7")]
	internal class PossessBeforeCraftCookProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D92")]
		[Cpp2IlInjected.Address(RVA = "0x7BD660", Offset = "0x7BC060", VA = "0x1807BD660", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0223, IL_0229, IL_022f, IL_0235, IL_023b, IL_0241, IL_0247, IL_024d, IL_0253, IL_025f, IL_0265, IL_026b, IL_0271, IL_0277
			//IL_0012: Expected O, but got I4
			//IL_0201: Expected O, but got I4
			//IL_020a: Expected O, but got I4
			uint value = default(uint);
			bool flag = default(bool);
			int num6 = default(int);
			ICollection<> collection = default(ICollection<>);
			ICollection<> cpp2il__autoParamName__idx_ = default(ICollection<>);
			bool flag2 = default(bool);
			int num8 = default(int);
			ICollection<> collection2 = default(ICollection<>);
			uint num12 = default(uint);
			GridObject[] array2 = default(GridObject[]);
			ICollection<> cpp2il__autoParamName__idx_2 = default(ICollection<>);
			uint value2 = default(uint);
			bool flag7 = default(bool);
			bool flag10 = default(bool);
			bool flag13 = default(bool);
			bool flag17 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num10;
				if (profile.world_.IsMissionCompleted((Item)num2))
				{
					List<Item> list = (List<Item>)(object)new List<T>();
					long num4 = Convert.ToInt64(value);
					ICollection<ContainerInventory> values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)profile.player_.containerInventories_).get_Values();
					if (values != null)
					{
						if (flag)
						{
							int num5 = 0;
						}
						num3++;
						while (num3 == 0)
						{
						}
					}
					num6++;
					int num7 = 0;
					if (values != null)
					{
					}
					if (num6 != 0)
					{
						num8 = num6 - 1;
					}
					if (collection != null)
					{
						int num9 = 0;
						GridObject[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<GridObject>();
						while (num7 >= array.Length)
						{
						}
						int itemID = array[num7].ItemID;
						if (flag2)
						{
						}
						num7++;
					}
					num8++;
					num10 = 0;
					if (collection != null)
					{
					}
					if (num8 != 0)
					{
						break;
					}
					if (num8 != 0)
					{
						int num11 = num8 - 1;
					}
					if (collection2 != null)
					{
						if (num10 < (int)num12)
						{
							num10 += num10;
							if (num10 == (int)num12)
							{
								goto IL_00f2;
							}
							num10++;
						}
						array2 = ((IEnumerable<>)cpp2il__autoParamName__idx_2).ToArray<GridObject>();
						while (num10 >= array2.Length)
						{
						}
						goto IL_00f2;
					}
					goto IL_010d;
				}
				goto IL_0125;
				IL_0125:
				long num13 = Convert.ToInt64(value2);
				HashSet<string> hashSet = (HashSet<string>)(object)new HashSet<T>();
				bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)"Group08");
				bool flag4 = ((HashSet<T>)(object)hashSet).Add((T)"Group09");
				HashSet<string> hashSet2 = (HashSet<string>)(object)new HashSet<T>();
				bool flag5 = ((HashSet<T>)(object)hashSet2).Add((T)"Group03");
				bool flag6 = ((HashSet<T>)(object)hashSet2).Add((T)"Group04");
				bool flag8 = flag7;
				flag8 = flag7;
				bool flag9 = new HashSet<T>().Add((T)"Group10");
				flag8 = flag10;
				flag8 = flag10;
				HashSet<string> hashSet3 = (HashSet<string>)(object)new HashSet<T>();
				bool flag11 = ((HashSet<T>)(object)hashSet3).Add((T)"Group03");
				bool flag12 = ((HashSet<T>)(object)hashSet3).Add((T)"Group02");
				Profile profile2;
				if (!flag13)
				{
					flag8 = flag13;
					HashSet<string> hashSet4 = (HashSet<string>)(object)new HashSet<T>();
					bool flag14 = ((HashSet<T>)(object)hashSet4).Add((T)"Group03");
					bool flag15 = ((HashSet<T>)(object)hashSet4).Add((T)"Group02");
					bool flag16 = ((HashSet<T>)(object)hashSet4).Add((T)"Group04");
					profile2 = (Profile)0;
					Item itemToCheck = (Item)flag8;
					Profile profile3 = profile2;
					Func<bool> func = (Func<bool>)(object)new Func<TResult>(Condition);
				}
				return;
				IL_00f2:
				int itemID2 = array2[num10].ItemID;
				if (flag17)
				{
				}
				num10++;
				goto IL_010d;
				IL_010d:
				num8++;
				if (collection2 != null)
				{
				}
				if (num8 != 0)
				{
					continue;
				}
				if (num8 == 0)
				{
				}
				goto IL_0125;
				int num14;
				ICollection<Grid> values2;
				uint num16 = default(uint);
				Func<GridObject, bool> func2 = default(Func<GridObject, bool>);
				int itemID3;
				ICollection<> collection3 = default(ICollection<>);
				Func<GridObject, bool> func3 = default(Func<GridObject, bool>);
				int num15;
				int num17;
				[Cpp2IlInjected.Token(Token = "0x6005D98")]
				[Cpp2IlInjected.Address(RVA = "0x10E0EB0", Offset = "0x10DF8B0", VA = "0x1810E0EB0")]
				bool Condition()
				{
					//Discarded unreachable code: IL_0086, IL_008c, IL_0092
					while (true)
					{
						num14 = 0;
						num15 = 0;
						values2 = (ICollection<Grid>)((MapField<TKey, TValue>)(object)profile2.world_.gridCollection_.grids_).get_Values();
						if (values2 == null)
						{
							break;
						}
						if (num15 < (int)num16)
						{
							num15 += num15;
							if (num15 == (int)num16)
							{
								goto IL_0062;
							}
							num15++;
						}
						if (func2 == null)
						{
							func3 = (func2 = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
							{
								itemID3 = x.ItemID;
								throw new NullReferenceException();
							});
						}
						if (Enumerable.FirstOrDefault<GridObject>((IEnumerable<>)collection3, (Func<, >)(object)func3) == null)
						{
							continue;
						}
						num15++;
						goto IL_0062;
						IL_0062:
						func3 += func3;
						num15 += 312;
						break;
					}
					num15++;
					if (values2 != null)
					{
					}
					if (num15 != 0)
					{
					}
					num17 = 0;
					throw new NullReferenceException();
				}
				[Cpp2IlInjected.Token(Token = "0x6005D98")]
				[Cpp2IlInjected.Address(RVA = "0x10E0EB0", Offset = "0x10DF8B0", VA = "0x1810E0EB0")]
				bool Condition()
				{
					//Discarded unreachable code: IL_0086, IL_008c, IL_0092
					while (true)
					{
						num14 = 0;
						num15 = 0;
						values2 = (ICollection<Grid>)((MapField<TKey, TValue>)(object)profile2.world_.gridCollection_.grids_).get_Values();
						if (values2 == null)
						{
							break;
						}
						if (num15 < (int)num16)
						{
							num15 += num15;
							if (num15 == (int)num16)
							{
								goto IL_0062;
							}
							num15++;
						}
						if (func2 == null)
						{
							func3 = (func2 = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
							{
								itemID3 = x.ItemID;
								throw new NullReferenceException();
							});
						}
						if (Enumerable.FirstOrDefault<GridObject>((IEnumerable<>)collection3, (Func<, >)(object)func3) == null)
						{
							continue;
						}
						num15++;
						goto IL_0062;
						IL_0062:
						func3 += func3;
						num15 += 312;
						break;
					}
					num15++;
					if (values2 != null)
					{
					}
					if (num15 != 0)
					{
					}
					num17 = 0;
					throw new NullReferenceException();
				}
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D93")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BCEB0", VA = "0x1807BE4B0")]
		internal static bool SkipStepsIfItemOnTheGrid(Profile profile, Item missionItem, Item itemToCheck, HashSet<string> stepsToSkip)
		{
			//Discarded unreachable code: IL_0032
			//IL_0022: Expected O, but got I4
			int itemID = itemToCheck.ItemID;
			Profile profile2 = profile;
			Item itemToCheck2 = (Item)itemID;
			Func<bool> func = (Func<bool>)(object)new Func<TResult>(Condition);
			bool result = default(bool);
			return result;
			Func<GridObject, bool> func2 = default(Func<GridObject, bool>);
			[Cpp2IlInjected.Token(Token = "0x6005D98")]
			[Cpp2IlInjected.Address(RVA = "0x10E0EB0", Offset = "0x10DF8B0", VA = "0x1810E0EB0")]
			bool Condition()
			{
				//Discarded unreachable code: IL_0086, IL_008c, IL_0092
				ICollection<Grid> values;
				uint num3 = default(uint);
				ICollection<> collection = default(ICollection<>);
				Func<GridObject, bool> func3 = default(Func<GridObject, bool>);
				int num2;
				while (true)
				{
					int num = 0;
					num2 = 0;
					values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)profile.world_.gridCollection_.grids_).get_Values();
					if (values == null)
					{
						break;
					}
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_0062;
						}
						num2++;
					}
					if (func2 == null)
					{
						func3 = (func2 = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
						{
							int itemID2 = x.ItemID;
							throw new NullReferenceException();
						});
					}
					if (Enumerable.FirstOrDefault<GridObject>((IEnumerable<>)collection, (Func<, >)(object)func3) == null)
					{
						continue;
					}
					num2++;
					goto IL_0062;
					IL_0062:
					func3 += func3;
					num2 += 312;
					break;
				}
				num2++;
				if (values != null)
				{
				}
				if (num2 != 0)
				{
				}
				int num4 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D94")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3B0", Offset = "0x7BCDB0", VA = "0x1807BE3B0")]
		internal static bool SkipStepsIfHasItem(Profile profile, Item missionItem, Item itemToCheck, HashSet<string> stepsToSkip)
		{
			//Discarded unreachable code: IL_0032
			//IL_0022: Expected O, but got I4
			int itemID = itemToCheck.ItemID;
			Profile profile2 = profile;
			Item itemToCheck2 = (Item)itemID;
			Func<bool> func = (Func<bool>)(object)(Func<TResult>)delegate
			{
				//Discarded unreachable code: IL_001c
				ProfilePlayer player_ = profile.player_;
				Item item = itemToCheck2;
				return player_.HasItem(item);
			};
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D95")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5B0", Offset = "0x7BCFB0", VA = "0x1807BE5B0")]
		private static bool SkipStepsIf(Profile profile, Item missionItem, HashSet<string> stepsToSkip, Func<bool> condition)
		{
			//IL_0130: Expected I4, but got I8
			MissionSlot missionSlot = default(MissionSlot);
			bool flag = default(bool);
			int num2 = default(int);
			MissionStepData missionStepData = default(MissionStepData);
			Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
			Action<MissionObjective> action = default(Action<MissionObjective>);
			int num3 = default(int);
			Action<MissionObjective> action2 = default(Action<MissionObjective>);
			while (true)
			{
				int num = 0;
				ProfileWorld world_ = profile.world_;
				if (missionSlot == null)
				{
					break;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (!flag || condition() == null || missionSlot.currentStepIndex_ >= num2)
				{
					break;
				}
				int currentStepIndex_ = missionSlot.currentStepIndex_;
				string stepName_ = missionStepData.stepName_;
				if (!((HashSet<T>)(object)stepsToSkip).Contains((T)stepName_))
				{
					break;
				}
				int currentStepIndex_2 = missionSlot.currentStepIndex_;
				int count = ((RepeatedField<T>)(object)missionSlot.missionSteps_).Count;
				if (currentStepIndex_2 < count)
				{
					int currentStepIndex_3 = missionSlot.currentStepIndex_;
					if (!missionSlot.IsValidStepIndex(currentStepIndex_3))
					{
						continue;
					}
				}
				IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)missionSlot.get_AllStepsObjectives();
				if (_003C_003Ec._003C_003E9__3_0 == null)
				{
					func = (Func<MissionObjective, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_0015
						MissionStepStatus status_ = x.status_;
						if (status_ < MissionStepStatus.Ongoing)
						{
							int num4 = 0;
						}
						return status_ <= MissionStepStatus.Completed;
					});
				}
				IEnumerable<MissionObjective> enumerable = (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func);
				if (_003C_003Ec._003C_003E9__3_1 == null)
				{
					action = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_000a
						//IL_0009: Expected I4, but got I8
						x.status_ = MissionStepStatus.Confirmed;
					});
				}
				MoreLinq.ForEach<MissionObjective>((IEnumerable<>)enumerable, (Action<>)(object)action);
				if (missionSlot.currentStepIndex_ < num3)
				{
					IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionSlot.CurrentStep.get_AllObjectives();
					if (_003C_003Ec._003C_003E9__3_2 == null)
					{
						action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
						{
							//Discarded unreachable code: IL_000a
							//IL_0009: Expected I4, but got I8
							x.status_ = MissionStepStatus.Ongoing;
						});
					}
					MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action2);
				}
				missionSlot.state_ = MissionSlotState.Completed;
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D96")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public PossessBeforeCraftCookProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
