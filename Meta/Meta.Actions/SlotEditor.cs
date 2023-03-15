using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Meta.Missions;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E15")]
	internal class SlotEditor : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17001497")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400390A")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6007664")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007665")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001498")]
		public MissionItemData MissionData
		{
			[Cpp2IlInjected.Token(Token = "0x6007666")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CMissionData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007667")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CMissionData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001499")]
		public MissionSlot MissionSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6007668")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CMissionSlot_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007669")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CMissionSlot_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149A")]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x600766A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600766B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149B")]
		public string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x600766C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CDebugName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600766D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CDebugName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149C")]
		public string MissionName
		{
			[Cpp2IlInjected.Token(Token = "0x600766E")]
			[Cpp2IlInjected.Address(RVA = "0x1781A30", Offset = "0x1780430", VA = "0x181781A30")]
			get
			{
				return ActionsHelper.GetMissionName(MissionItem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x400390F")]
		public int NbNewStep
		{
			[Cpp2IlInjected.Token(Token = "0x600766F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007670")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700149E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4003910")]
		public int NbNewSubStep
		{
			[Cpp2IlInjected.Token(Token = "0x6007671")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007672")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700149F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4003911")]
		public int NbNewObjective
		{
			[Cpp2IlInjected.Token(Token = "0x6007673")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007674")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x44"), Cpp2IlInjected.Token(Token = "0x4003912")]
		public int NbDeletedStep
		{
			[Cpp2IlInjected.Token(Token = "0x6007675")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007676")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4003913")]
		public int NbDeletedSubStep
		{
			[Cpp2IlInjected.Token(Token = "0x6007677")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007678")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4C"), Cpp2IlInjected.Token(Token = "0x4003914")]
		public int NbDeletedObjective
		{
			[Cpp2IlInjected.Token(Token = "0x6007679")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600767A")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4003915")]
		public int PrevCurrentStepIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600767B")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600767C")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x54"), Cpp2IlInjected.Token(Token = "0x4003916")]
		public bool CurrentStepUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x600767D")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600767E")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x55"), Cpp2IlInjected.Token(Token = "0x4003917")]
		public bool ActiveStepDeleted
		{
			[Cpp2IlInjected.Token(Token = "0x600767F")]
			[Cpp2IlInjected.Address(RVA = "0x881950", Offset = "0x880350", VA = "0x180881950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007680")]
			[Cpp2IlInjected.Address(RVA = "0x881A60", Offset = "0x880460", VA = "0x180881A60")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x4003918")]
		public MissionSlotState PrevState
		{
			[Cpp2IlInjected.Token(Token = "0x6007681")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007682")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170014A7")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6007688")]
			[Cpp2IlInjected.Address(RVA = "0x1781440", Offset = "0x177FE40", VA = "0x181781440")]
			get
			{
				//Discarded unreachable code: IL_0171
				//IL_0048: Expected O, but got I4
				//IL_006e: Expected O, but got I4
				//IL_009c: Expected O, but got I4
				//IL_00ca: Expected O, but got I4
				//IL_00f3: Expected O, but got I4
				//IL_012f: Expected O, but got I4
				//IL_0165: Expected O, but got I4
				object[] array;
				bool flag2 = default(bool);
				while (true)
				{
					array = new object[8];
					string missionName = ActionsHelper.GetMissionName(MissionItem);
					if (missionName != null && missionName == null)
					{
						continue;
					}
					array[0] = missionName;
					MissionSlot missionSlot = MissionSlot;
					int num = 0;
					if (missionSlot != null)
					{
						MissionSlotState state_ = missionSlot.state_;
					}
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[1] = num;
					MissionSlot missionSlot2 = MissionSlot;
					if (missionSlot2 != null)
					{
						int currentStepIndex_ = missionSlot2.currentStepIndex_;
					}
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[2] = num;
					MissionSlot missionSlot3 = MissionSlot;
					if (missionSlot3 != null)
					{
						int count = ((RepeatedField<T>)(object)missionSlot3.missionSteps_).Count;
					}
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[3] = num;
					MissionItemData missionItemData = MissionData;
					if (missionItemData != null)
					{
						int count2 = ((RepeatedField<T>)(object)missionItemData.steps_).Count;
					}
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[4] = num;
					MissionSlot missionSlot4 = MissionSlot;
					if (missionSlot4 != null)
					{
						MissionChoice missionChoice_ = missionSlot4.missionChoice_;
					}
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[5] = num;
					Profile profile = Profile;
					if (profile != null)
					{
						ProfileWorld world_ = profile.world_;
						Item item = MissionItem;
						bool flag = world_.IsMissionCompleted(item);
					}
					if (num == 0 || num != 0)
					{
						array[6] = num;
						MissionSlot missionSlot5 = MissionSlot;
						if (missionSlot5 != null)
						{
							MissionItemData data = MissionData;
							flag2 = missionSlot5.IsCompatibleWith(data);
						}
						if (!flag2 || flag2)
						{
							break;
						}
					}
				}
				array[7] = flag2;
				return string.Format("{0}, Slot={1}, CurrentStep={2}/{3}({4}), Choice={5}, Completed={6}, Compatible={7}", array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007683")]
		[Cpp2IlInjected.Address(RVA = "0x17812B0", Offset = "0x177FCB0", VA = "0x1817812B0")]
		private SlotEditor(Item missionItem, Profile profile, string debugName)
		{
			//Discarded unreachable code: IL_006d
			//IL_0014: Expected O, but got I4
			int itemID = missionItem.ItemID;
			PreInit();
			MissionItem = (Item)itemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			MissionItemData missionItemData = default(MissionItemData);
			MissionData = missionItemData;
			ProfileWorld world_ = profile.world_;
			MissionSlot missionSlot = default(MissionSlot);
			MissionSlot = missionSlot;
			Profile = profile;
			DebugName = debugName;
			MissionSlot missionSlot2 = MissionSlot;
			int num = 0;
			if (missionSlot2 != null)
			{
			}
			PrevCurrentStepIndex = num;
			MissionSlotState state_ = default(MissionSlotState);
			if (missionSlot2 != null)
			{
				state_ = missionSlot2.state_;
			}
			PrevState = state_;
		}

		[Cpp2IlInjected.Token(Token = "0x6007684")]
		[Cpp2IlInjected.Address(RVA = "0x177F170", Offset = "0x177DB70", VA = "0x18177F170")]
		public static SlotEditor From(Item missionItem, Profile profile, string debugName)
		{
			//IL_001b: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			int itemID = missionItem.ItemID;
			if (profile != null)
			{
				SlotEditor slotEditor = default(SlotEditor);
				slotEditor.PreInit();
				slotEditor.MissionItem = (Item)itemID;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				MissionItemData missionItemData = default(MissionItemData);
				slotEditor.MissionData = missionItemData;
				ProfileWorld world_ = profile.world_;
				MissionSlot missionSlot = default(MissionSlot);
				slotEditor.MissionSlot = missionSlot;
				slotEditor.Profile = profile;
				slotEditor.DebugName = debugName;
				MissionSlot missionSlot2 = slotEditor.MissionSlot;
				int num = 0;
				if (missionSlot2 != null)
				{
				}
				slotEditor.PrevCurrentStepIndex = num;
				MissionSlotState state_ = default(MissionSlotState);
				if (missionSlot2 != null)
				{
					state_ = missionSlot2.state_;
				}
				slotEditor.PrevState = state_;
				int num2 = default(int);
				if ((long)slotEditor.MissionData != 0)
				{
					if (missionSlot2 != null)
					{
					}
					bool flag = slotEditor.LogSuccess("Done: No active profile slot");
					num2 = 0;
				}
				string text = $"Invalid MissionID={num2}";
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007685")]
		[Cpp2IlInjected.Address(RVA = "0x1780480", Offset = "0x177EE80", VA = "0x181780480", Slot = "4")]
		void IDisposable.Dispose()
		{
			//Discarded unreachable code: IL_0151
			//IL_001c: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			//IL_00fc: Expected O, but got I4
			//IL_00fc: Expected O, but got I4
			List<string> list = (List<string>)(object)new List<T>();
			int num = NbNewStep;
			if (num > 0)
			{
				string item = $"Step +{num}";
				((List<T>)(object)list).Add((T)item);
			}
			int num2 = NbNewSubStep;
			if (num2 > 0)
			{
				string item2 = $"SubStep +{num2}";
				((List<T>)(object)list).Add((T)item2);
			}
			int num3 = NbNewObjective;
			if (num3 > 0)
			{
				string item3 = $"Obj +{num3}";
				((List<T>)(object)list).Add((T)item3);
			}
			int num4 = NbDeletedStep;
			if (num4 > 0)
			{
				string item4 = $"Step -{num4}";
				((List<T>)(object)list).Add((T)item4);
			}
			int num5 = NbDeletedSubStep;
			if (num5 > 0)
			{
				string item5 = $"SubStep -{num5}";
				((List<T>)(object)list).Add((T)item5);
			}
			int num6 = NbDeletedObjective;
			if (num6 > 0)
			{
				string item6 = $"Obj -{num6}";
				((List<T>)(object)list).Add((T)item6);
			}
			if (CurrentStepUpdated)
			{
				int num7 = PrevCurrentStepIndex;
				int currentStepIndex_ = MissionSlot.currentStepIndex_;
				string item7 = $"NewCurrentStep: {num7} => {num7}";
				((List<T>)(object)list).Add((T)item7);
			}
			if (!Enumerable.Any<string>((IEnumerable<>)list))
			{
				MissionSlot missionSlot = MissionSlot;
				MissionItemData data = MissionData;
				if (missionSlot.IsCompatibleWith(data))
				{
					return;
				}
			}
			string text = string.Join(", ", (IEnumerable<>)list);
			string msg = "Result: " + text;
			bool flag = LogSuccess(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x6007686")]
		[Cpp2IlInjected.Address(RVA = "0x177F430", Offset = "0x177DE30", VA = "0x18177F430")]
		public bool LogSuccess(string msg)
		{
			string name = DebugName;
			string info = Info;
			string msg2 = msg + "\n" + info;
			return ActionsHelper.LogSuccess(name, msg2);
		}

		[Cpp2IlInjected.Token(Token = "0x6007687")]
		[Cpp2IlInjected.Address(RVA = "0x177F3B0", Offset = "0x177DDB0", VA = "0x18177F3B0")]
		public bool LogError(string msg)
		{
			string name = DebugName;
			string info = Info;
			string msg2 = msg + "\n" + info;
			return ActionsHelper.LogError(name, msg2);
		}

		[Cpp2IlInjected.Token(Token = "0x6007689")]
		[Cpp2IlInjected.Address(RVA = "0x177D5C0", Offset = "0x177BFC0", VA = "0x18177D5C0")]
		public bool AddStepFromStepID(int stepID, bool canOverrideActive)
		{
			//Discarded unreachable code: IL_003b, IL_0052
			//IL_0047: Expected O, but got I4
			RepeatedField<MissionStepData> steps_ = MissionData.steps_;
			Func<MissionStepData, bool> func = (Func<MissionStepData, bool>)(object)(Func<T, TResult>)delegate(MissionStepData x)
			{
				//Discarded unreachable code: IL_0011
				int num = stepID;
				return x.stepID_ == num;
			};
			int stepIndex = ((RepeatedField<>)(object)steps_).FindIndex<MissionStepData>((Func<, >)(object)func);
			return AddStepFromIndex(stepIndex, canOverrideActive);
		}

		[Cpp2IlInjected.Token(Token = "0x600768A")]
		[Cpp2IlInjected.Address(RVA = "0x177CBE0", Offset = "0x177B5E0", VA = "0x18177CBE0")]
		public bool AddStepFromIndex(int stepIndex, bool canOverrideActive)
		{
			//Discarded unreachable code: IL_02de
			//IL_0085: Expected O, but got I4
			//IL_0282: Expected O, but got I4
			//IL_02c6: Expected O, but got I4
			//IL_02c6: Expected O, but got I4
			//IL_02d3: Expected O, but got I4
			int count = ((RepeatedField<T>)(object)MissionData.steps_).Count;
			if (stepIndex < count)
			{
				int count2 = ((RepeatedField<T>)(object)MissionSlot.missionSteps_).Count;
				int count3 = ((RepeatedField<T>)(object)MissionData.steps_).Count;
				if (count2 + 1 == count3)
				{
					MissionSlot missionSlot = new MissionSlot();
					int num = (int)(missionSlot.state_ = MissionSlotState.Invalid);
					MissionItemData missionItemData = MissionData;
					Item item = MissionItem;
					int count4 = ((RepeatedField<T>)(object)missionSlot.missionSteps_).Count;
					if (stepIndex < count4)
					{
						string msg = $"Preparing to add StepIndex={count4}...";
						bool flag = LogSuccess(msg);
						MissionStep missionStep = (MissionStep)((RepeatedField<T>)(object)missionSlot.missionSteps_)[stepIndex];
						((RepeatedField<T>)(object)MissionSlot.missionSteps_).Insert(stepIndex, (T)missionStep);
						MissionSlot missionSlot2 = MissionSlot;
						if (missionSlot2.state_ == MissionSlotState.OnGoing)
						{
							CurrentStepUpdated = true;
							if (canOverrideActive && !missionSlot2.IsValidStepIndex(stepIndex))
							{
								bool flag2 = LogSuccess("Warning: CanOverrideActive cannot be apply");
							}
							MissionSlot missionSlot3 = MissionSlot;
							IEnumerable<MissionObjective> enumerable = default(IEnumerable<MissionObjective>);
							if (!canOverrideActive)
							{
								IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionStep.get_AllObjectives();
								Action<MissionObjective> action = default(Action<MissionObjective>);
								if (_003C_003Ec._003C_003E9__70_2 == null)
								{
									action = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
									{
										//Discarded unreachable code: IL_000a
										//IL_0009: Expected I4, but got I8
										x.status_ = MissionStepStatus.Confirmed;
									});
								}
								MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action);
								MissionSlot missionSlot4 = MissionSlot;
								if (stepIndex == missionSlot4.currentStepIndex_ && stepIndex > 0)
								{
									IEnumerable<MissionObjective> allObjectives2 = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)MissionSlot.missionSteps_)[num]).get_AllObjectives();
									Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
									if (_003C_003Ec._003C_003E9__70_3 == null)
									{
										func = (Func<MissionObjective, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
										{
											//Discarded unreachable code: IL_0015
											MissionStepStatus status_ = x.status_;
											if (status_ < MissionStepStatus.Ongoing)
											{
												int num3 = 0;
											}
											return status_ <= MissionStepStatus.Completed;
										});
									}
									enumerable = (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)allObjectives2, (Func<, >)(object)func);
									Action<MissionObjective> action2 = default(Action<MissionObjective>);
									if (_003C_003Ec._003C_003E9__70_4 == null)
									{
										action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
										{
											//Discarded unreachable code: IL_000a
											//IL_0009: Expected I4, but got I8
											x.status_ = MissionStepStatus.Confirmed;
										});
									}
									MoreLinq.ForEach<MissionObjective>((IEnumerable<>)enumerable, (Action<>)(object)action2);
									num++;
									MissionSlot missionSlot5 = MissionSlot;
								}
							}
							int num2 = stepIndex + 1;
							MissionStep missionStep2 = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)enumerable, num2);
							if (missionStep2 != null)
							{
								IEnumerable<MissionObjective> allObjectives3 = (IEnumerable<MissionObjective>)missionStep2.get_AllObjectives();
								Action<MissionObjective> action3 = default(Action<MissionObjective>);
								if (_003C_003Ec._003C_003E9__70_0 == null)
								{
									action3 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
									{
										//Discarded unreachable code: IL_000a
										//IL_0009: Expected I4, but got I8
										x.status_ = MissionStepStatus.NotStarted;
									});
								}
								MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives3, (Action<>)(object)action3);
							}
							IEnumerable<MissionObjective> allObjectives4 = (IEnumerable<MissionObjective>)missionStep.get_AllObjectives();
							Action<MissionObjective> action4 = default(Action<MissionObjective>);
							if (_003C_003Ec._003C_003E9__70_1 == null)
							{
								action4 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
								{
									//Discarded unreachable code: IL_000a
									//IL_0009: Expected I4, but got I8
									x.status_ = MissionStepStatus.Ongoing;
								});
							}
							MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives4, (Action<>)(object)action4);
						}
						MissionStepStatus status = ((MissionStep)((RepeatedField<T>)(object)MissionSlot.missionSteps_)[stepIndex]).Status;
						string stepName_ = default(string);
						if (missionStep != null)
						{
							MissionStepData _003CData_003Ek__BackingField = missionStep.Data;
							if (_003CData_003Ek__BackingField != null)
							{
								stepName_ = _003CData_003Ek__BackingField.stepName_;
							}
						}
						string msg2 = $"Done: StepStatus={status}, AddedStep={stepName_}";
						bool flag3 = LogSuccess(msg2);
					}
				}
				int count5 = ((RepeatedField<T>)(object)MissionSlot.missionSteps_).Count;
				MissionItemData missionItemData2 = MissionData;
				count2 = count5;
				int count6 = ((RepeatedField<T>)(object)missionItemData2.steps_).Count;
				string text = $"Incompatible step count (Slot={count2} +1 != Data={count6})";
			}
			string msg3 = $"StepIndex={count} is invalid in MissionData";
			return LogError(msg3);
		}

		[Cpp2IlInjected.Token(Token = "0x600768B")]
		[Cpp2IlInjected.Address(RVA = "0x177FD60", Offset = "0x177E760", VA = "0x18177FD60")]
		public bool RemoveSteps(List<int> stepIndexes)
		{
			//Discarded unreachable code: IL_0037
			//IL_0036: Expected O, but got I4
			Func<int, (int, int, int)> _003C_003E9__71_ = _003C_003Ec._003C_003E9__71_0;
			if (_003C_003E9__71_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num2 = 0;
					/*Error: Unexpected end of block*/;
				};
			}
			List<(int, int, int)> list = (List<(int, int, int)>)(object)Enumerable.ToList<(int, int, int)>(Enumerable.Select<int, (int, int, int)>((IEnumerable<>)stepIndexes, (Func<, >)(object)_003C_003E9__71_));
			int num = 0;
			return this.RemoveSteps((List<>)(object)list, (Func<, , >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600768C")]
		[Cpp2IlInjected.Address(RVA = "0x177FAA0", Offset = "0x177E4A0", VA = "0x18177FAA0")]
		public bool RemoveSteps(List<(int StepIndex, int SubStepIndex, int ObjectiveIndex)> stepsToDelete, [Optional] Func<MissionObjective, int, string> validator)
		{
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			MissionStep missionStep = default(MissionStep);
			uint num3 = default(uint);
			while (true)
			{
				int num = 0;
				bool flag = LogSuccess("Preparing to remove Steps...");
				MissionStep currentStep = MissionSlot.CurrentStep;
				if (currentStep != null)
				{
					MissionStepStatus status = currentStep.Status;
				}
				ActiveStepDeleted = (byte)num != 0;
				int num2 = NbDeletedObjective;
				if (flag2)
				{
					num++;
					num++;
					num++;
				}
				if (num2 == (flag3 ? 1 : 0))
				{
					break;
				}
				if (missionStep != null)
				{
					if (((missionStep.Status > MissionStepStatus.Completed) ? 1u : 0u) == num3)
					{
					}
					break;
				}
			}
			bool flag4 = LogError("Nothing was removed");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600768D")]
		[Cpp2IlInjected.Address(RVA = "0x177E490", Offset = "0x177CE90", VA = "0x18177E490")]
		private bool DeleteStep(int stepIndex)
		{
			//Discarded unreachable code: IL_007a
			//IL_006f: Expected O, but got I4
			MissionStep missionStep = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)MissionSlot.missionSteps_, stepIndex);
			if (missionStep != null)
			{
				((RepeatedField<T>)(object)MissionSlot.missionSteps_).RemoveAt(stepIndex);
				MissionSlot missionSlot = MissionSlot;
				if (missionSlot.currentStepIndex_ == stepIndex)
				{
					ActiveStepDeleted = true;
				}
				string msg = $"Removing Step[{missionSlot}]";
				return LogSuccess(msg);
			}
			int count = ((RepeatedField<T>)(object)MissionSlot.missionSteps_).Count;
			string msg2 = $"Invalid Step[{missionStep}], Count={count}";
			return LogError(msg2);
		}

		[Cpp2IlInjected.Token(Token = "0x600768E")]
		[Cpp2IlInjected.Address(RVA = "0x177E630", Offset = "0x177D030", VA = "0x18177E630")]
		private bool DeleteSubStep(int stepIndex, int subStepIndex)
		{
			//IL_00be: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			object[] array;
			int count2 = default(int);
			while (true)
			{
				MissionStep missionStep = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)MissionSlot.missionSteps_, stepIndex);
				if (missionStep != null)
				{
					MissionSubStep missionSubStep = Enumerable.ElementAtOrDefault<MissionSubStep>((IEnumerable<>)(object)missionStep.subSteps_, stepIndex);
					if (missionSubStep != null)
					{
						if (subStepIndex == 0 && ((RepeatedField<T>)(object)missionStep.subSteps_).Count == 1)
						{
							return DeleteStep(stepIndex);
						}
						((RepeatedField<T>)(object)missionStep.subSteps_).RemoveAt(stepIndex);
						string msg = $"Removing SubStep[{missionSubStep}][{missionSubStep}]";
						bool flag = LogSuccess(msg);
					}
				}
				array = new object[4];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[1] = array;
				int count = ((RepeatedField<T>)(object)MissionSlot.missionSteps_).Count;
				if (count == 0 || count != 0)
				{
					array[2] = count;
					if (missionStep != null)
					{
						count2 = ((RepeatedField<T>)(object)missionStep.subSteps_).Count;
						int num = 0;
					}
					int num2 = 0;
					if (count2 == 0 || count2 != 0)
					{
						break;
					}
				}
			}
			array[3] = count2;
			string msg2 = string.Format("Invalid SubStep[{0}][{1}], Count={2}|{3}", array);
			bool flag2 = LogError(msg2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600768F")]
		[Cpp2IlInjected.Address(RVA = "0x177DC90", Offset = "0x177C690", VA = "0x18177DC90")]
		private bool DeleteObjective(int stepIndex, int subStepIndex, int objectiveIndex, [Optional] Func<MissionObjective, int, string> validator, int validatorIdx = -1)
		{
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_017e: Expected O, but got I4
			//IL_0199: Expected O, but got I4
			bool flag = default(bool);
			bool result = default(bool);
			object[] array2;
			int num2 = default(int);
			int num3 = default(int);
			while (true)
			{
				MissionStep missionStep = Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)MissionSlot.missionSteps_, stepIndex);
				int num = 0;
				if (missionStep != null)
				{
					MissionSubStep missionSubStep = Enumerable.ElementAtOrDefault<MissionSubStep>((IEnumerable<>)(object)missionStep.subSteps_, stepIndex);
					if (missionSubStep != null)
					{
						RepeatedField<MissionObjective> objectives_ = missionSubStep.objectives_;
						MissionObjective missionObjective = Enumerable.ElementAtOrDefault<MissionObjective>((IEnumerable<>)(object)objectives_, stepIndex);
						if (missionObjective != null)
						{
							if (objectives_ != null)
							{
							}
							if (missionObjective != null)
							{
								if (objectiveIndex != 0 || ((RepeatedField<T>)(object)missionSubStep.objectives_).Count == 1)
								{
								}
								((RepeatedField<T>)(object)missionSubStep.objectives_).RemoveAt(stepIndex);
								string text = $"Removing Objective[{flag}][{flag}][{flag}]";
							}
							object[] array = new object[4];
							if (array != null && array == null)
							{
								continue;
							}
							array[0] = array;
							if (array != null && array == null)
							{
								continue;
							}
							array[1] = array;
							if (array == null || array != null)
							{
								array[2] = array;
								if (!flag || array != null)
								{
									array[3] = flag;
									string text2 = string.Format("Invalid Objective[{0}][{1}][{2}] => {3}", array);
									return result;
								}
							}
							continue;
						}
					}
				}
				array2 = new object[6];
				if (array2 != null && array2 == null)
				{
					continue;
				}
				array2[0] = array2;
				if (array2 != null && array2 == null)
				{
					continue;
				}
				array2[1] = array2;
				if (array2 != null && array2 == null)
				{
					continue;
				}
				array2[2] = array2;
				if (num2 != 0 && num2 == 0)
				{
					continue;
				}
				array2[3] = num2;
				if (missionStep != null)
				{
					int count = ((RepeatedField<T>)(object)missionStep.subSteps_).Count;
				}
				if (num == 0 || num != 0)
				{
					array2[4] = num;
					if (num != 0)
					{
					}
					if (num3 == 0 || num3 != 0)
					{
						break;
					}
				}
			}
			array2[5] = num3;
			string text3 = string.Format("Invalid Objective[{0}][{1}][{2}], Count={3}|{4}|{5}", array2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007690")]
		[Cpp2IlInjected.Address(RVA = "0x177FED0", Offset = "0x177E8D0", VA = "0x18177FED0")]
		public bool SetCurrentStep(int newCurrentStepIndex)
		{
			//IL_017e: Expected O, but got I4
			//IL_017e: Expected O, but got I4
			//IL_0199: Expected O, but got I4
			MissionSlot missionSlot = MissionSlot;
			if (missionSlot.state_ == MissionSlotState.OnGoing)
			{
				int count = ((RepeatedField<T>)(object)missionSlot.missionSteps_).Count;
				if (newCurrentStepIndex < count)
				{
					int previousIndex = MissionSlot.currentStepIndex_;
					MissionSlot missionSlot2 = MissionSlot;
					int num2 = default(int);
					if (missionSlot2.currentStepIndex_ != newCurrentStepIndex)
					{
						missionSlot2.currentStepIndex_ = newCurrentStepIndex;
						IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)MissionSlot.get_AllStepsObjectives();
						Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
						if (_003C_003Ec._003C_003E9__76_0 == null)
						{
							func = (Func<MissionObjective, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
							{
								//Discarded unreachable code: IL_0015
								MissionStepStatus status_ = x.status_;
								if (status_ < MissionStepStatus.Ongoing)
								{
									int num4 = 0;
								}
								return status_ <= MissionStepStatus.Confirmed;
							});
						}
						IEnumerable<MissionObjective> enumerable = (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func);
						Action<MissionObjective> action = (Action<MissionObjective>)(object)(Action<T>)delegate(MissionObjective x)
						{
							//Discarded unreachable code: IL_001b
							int currentStepIndex_2 = MissionSlot.currentStepIndex_;
							int num3 = (int)(x.status_ = MissionStepStatus.NotStarted);
						};
						MoreLinq.ForEach<MissionObjective>((IEnumerable<>)enumerable, (Action<>)(object)action);
						int num = previousIndex;
						num++;
						if (num < newCurrentStepIndex)
						{
							if (MissionSlot.IsValidStepIndex(num))
							{
								IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)MissionSlot.missionSteps_)[num]).get_AllObjectives();
								Action<MissionObjective> action2 = default(Action<MissionObjective>);
								if (_003C_003Ec._003C_003E9__76_3 == null)
								{
									action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
									{
										//Discarded unreachable code: IL_000a
										//IL_0009: Expected I4, but got I8
										x.status_ = MissionStepStatus.Confirmed;
									});
								}
								MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action2);
							}
							num++;
						}
						IEnumerable<MissionObjective> allObjectives2 = (IEnumerable<MissionObjective>)MissionSlot.CurrentStep.get_AllObjectives();
						Action<MissionObjective> action3 = default(Action<MissionObjective>);
						if (_003C_003Ec._003C_003E9__76_2 == null)
						{
							action3 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
							{
								//Discarded unreachable code: IL_000a
								//IL_0009: Expected I4, but got I8
								x.status_ = MissionStepStatus.Ongoing;
							});
						}
						MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives2, (Action<>)(object)action3);
						num2 = previousIndex;
					}
					int currentStepIndex_ = MissionSlot.currentStepIndex_;
					string msg = $"Done: {num2} => {num2}";
					return LogSuccess(msg);
				}
				bool flag = default(bool);
				string msg2 = $"Invalid StepIndex={flag}";
				bool flag2 = LogError(msg2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007691")]
		[Cpp2IlInjected.Address(RVA = "0x1780A60", Offset = "0x177F460", VA = "0x181780A60")]
		public bool TryGetObjective(string stepName, out MissionObjective objective)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007692")]
		[Cpp2IlInjected.Address(RVA = "0x1780C90", Offset = "0x177F690", VA = "0x181780C90")]
		private unsafe bool TryGetObjective(string stepName, out MissionObjective objective, out MissionSubStep subStep, out MissionStep step, out int objectiveIndex, out int subStepIndex, out int stepIndex)
		{
			bool flag = default(bool);
			bool flag2;
			while (true)
			{
				int num = 0;
				if (!flag)
				{
					string text = "TryGetObjective " + stepName + " don't exist in data";
				}
				RepeatedField<MissionStep> missionSteps_ = MissionSlot.missionSteps_;
				object[] array = new object[4];
				if (stepName != null && array == null)
				{
					continue;
				}
				array[0] = stepName;
				if (array != null && array == null)
				{
					continue;
				}
				array[1] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[2] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[3] = array;
				string msg = string.Format("TryGetObjective {0} found at idx={1}|{2}|{3}", array);
				flag2 = LogSuccess(msg);
				if ((array != null && !flag2) || (flag2 && !flag2))
				{
					continue;
				}
				((bool*)(flag2 ? 1 : 0))->m_value = flag2;
				if (!flag2 || flag2)
				{
					((bool*)(flag2 ? 1 : 0))->m_value = flag2;
					if (!flag2 || flag2)
					{
						break;
					}
				}
			}
			((bool*)(flag2 ? 1 : 0))->m_value = flag2;
			string msg2 = "TryGetObjective called wth invalid param: stepName=" + stepName;
			return LogError(msg2);
		}

		[Cpp2IlInjected.Token(Token = "0x6007693")]
		[Cpp2IlInjected.Address(RVA = "0x1780840", Offset = "0x177F240", VA = "0x181780840")]
		public bool TryGetObjectiveIndexes(string stepName, out int objectiveIndex, out int subStepIndex, out int stepIndex)
		{
			int num = (objectiveIndex.m_value = (subStepIndex.m_value = 0));
			int count = ((RepeatedField<T>)(object)MissionData.steps_).Count;
			if (num < count)
			{
				RepeatedField<MissionStepData> steps_ = MissionData.steps_;
				subStepIndex.m_value = num;
				MissionStepData missionStepData = default(MissionStepData);
				int count2 = ((RepeatedField<T>)(object)missionStepData.subSteps_).Count;
				if (num < count2)
				{
					RepeatedField<MissionSubStepData> subSteps_ = missionStepData.subSteps_;
					objectiveIndex.m_value = num;
					MissionSubStepData missionSubStepData = default(MissionSubStepData);
					int count3 = ((RepeatedField<T>)(object)missionSubStepData.objectives_).Count;
					if (num < count3)
					{
						RepeatedField<MissionObjectiveData> objectives_ = missionSubStepData.objectives_;
						MissionObjectiveData missionObjectiveData = default(MissionObjectiveData);
						string stepName_ = missionObjectiveData.stepName_;
						if (missionObjectiveData != null)
						{
							goto IL_008b;
						}
					}
				}
				MissionItemData missionItemData = MissionData;
			}
			goto IL_008b;
			IL_008b:
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007694")]
		[Cpp2IlInjected.Address(RVA = "0x1780AB0", Offset = "0x177F4B0", VA = "0x181780AB0")]
		private bool TryGetObjective(int stepIndex, int subStepIndex, int objectiveIndex, out MissionObjective objective)
		{
			//Discarded unreachable code: IL_0064
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			MissionSlot missionSlot = MissionSlot;
			if (missionSlot != null)
			{
				MissionObjective missionObjective = Enumerable.ElementAtOrDefault<MissionObjective>((IEnumerable<>)(object)Enumerable.ElementAtOrDefault<MissionSubStep>((IEnumerable<>)(object)Enumerable.ElementAtOrDefault<MissionStep>((IEnumerable<>)(object)missionSlot.missionSteps_, stepIndex).subSteps_, stepIndex).objectives_, stepIndex);
			}
			int num = 0;
			string msg = $"TryGetObjective {num}|{num}|{num} was found";
			bool flag = LogSuccess(msg);
			string msg2 = $"TryGetObjective {flag}|{flag}|{flag} don't exist in profile";
			return LogError(msg2);
		}

		[Cpp2IlInjected.Token(Token = "0x6007695")]
		[Cpp2IlInjected.Address(RVA = "0x177EA60", Offset = "0x177D460", VA = "0x18177EA60")]
		public bool FixObjectiveTargetAmount(string stepName, int newAmount, [Optional] Func<MissionObjective, string> validator)
		{
			//Discarded unreachable code: IL_009b
			//IL_0055: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			string text = "Objective=" + stepName;
			MissionSlot missionSlot = MissionSlot;
			MissionItemData data = MissionData;
			if (!missionSlot.IsCompatibleWith(data))
			{
				string msg = "Warning: profile/data are not compatible, changing the wrong objective? " + text;
				bool flag2 = LogSuccess(msg);
			}
			int num2 = default(int);
			if (num2 != newAmount)
			{
				string text2 = default(string);
				if (validator != null)
				{
					text2 = (string)validator((T)num);
				}
				if (text2 != null)
				{
					string text3 = $"Done: TargetAmount {text2} => {text2}, {text}";
				}
				string msg2 = (string)num + ", " + text;
				bool flag3 = LogError(msg2);
			}
			string msg3 = "Done: already have right amount, " + text;
			return LogSuccess(msg3);
		}

		[Cpp2IlInjected.Token(Token = "0x6007696")]
		[Cpp2IlInjected.Address(RVA = "0x177ECF0", Offset = "0x177D6F0", VA = "0x18177ECF0")]
		public bool FixObjectiveTargetAmount(int stepIndex, int subStepIndex, int objectiveIndex, int newAmount, [Optional] Func<MissionObjective, string> validator)
		{
			//Discarded unreachable code: IL_008c
			//IL_0015: Expected O, but got I4
			//IL_0015: Expected O, but got I4
			//IL_0015: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			string text = $"Objective={flag}|{flag}|{flag}";
			MissionSlot missionSlot = MissionSlot;
			MissionItemData data = MissionData;
			if (!missionSlot.IsCompatibleWith(data))
			{
				string msg = "Warning: profile/data are not compatible, changing the wrong objective? " + text;
				bool flag2 = LogSuccess(msg);
			}
			string text2 = default(string);
			if (text2 != null)
			{
				string text3 = $"Done: TargetAmount {text2} => {text2}, {text}";
			}
			string msg2 = text2 + ", " + text;
			bool flag3 = LogError(msg2);
			string msg3 = "Done: already have right amount, " + text;
			return LogSuccess(msg3);
		}

		[Cpp2IlInjected.Token(Token = "0x6007697")]
		[Cpp2IlInjected.Address(RVA = "0x177EFA0", Offset = "0x177D9A0", VA = "0x18177EFA0")]
		private bool FixObjectiveTargetAmount(MissionObjective objective, int newAmount, Func<MissionObjective, string> validator, string extraInfo)
		{
			string msg = default(string);
			string msg2 = default(string);
			string msg3 = default(string);
			while (true)
			{
				MissionSlot missionSlot = MissionSlot;
				MissionItemData data = MissionData;
				if (!missionSlot.IsCompatibleWith(data))
				{
					bool flag = LogSuccess(msg);
				}
				if (objective.TargetAmountInt == newAmount)
				{
					break;
				}
				if (validator != null)
				{
					if (validator((T)objective) != null)
					{
						return LogSuccess(msg2);
					}
					bool flag2 = LogError(msg3);
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007698")]
		[Cpp2IlInjected.Address(RVA = "0x177F990", Offset = "0x177E390", VA = "0x18177F990")]
		public bool MoveMissionObjective(string stepName, int fromIndex, int toIndex, [Optional] Func<MissionObjective, string> validator)
		{
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
			string text = "Objective=" + stepName;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007699")]
		[Cpp2IlInjected.Address(RVA = "0x177F4B0", Offset = "0x177DEB0", VA = "0x18177F4B0")]
		private bool MoveMissionObjective(MissionSubStep subStep, int fromIndex, int toIndex, Func<MissionObjective, string> validator, string extraInfo)
		{
			//IL_00de: Expected O, but got I4
			string msg = default(string);
			string text = default(string);
			string msg2 = default(string);
			string msg3 = default(string);
			while (true)
			{
				MissionSlot missionSlot = MissionSlot;
				MissionItemData data = MissionData;
				if (!missionSlot.IsCompatibleWith(data))
				{
					bool flag = LogSuccess(msg);
				}
				if (fromIndex == toIndex)
				{
					break;
				}
				int count = ((RepeatedField<T>)(object)subStep.objectives_).Count;
				int count2 = ((RepeatedField<T>)(object)subStep.objectives_).Count;
				MissionObjective item = (MissionObjective)((RepeatedField<T>)(object)subStep.objectives_)[fromIndex];
				int num = 0;
				if (text != null)
				{
					((RepeatedField<T>)(object)subStep.objectives_).RemoveAt(fromIndex);
					((RepeatedField<T>)(object)subStep.objectives_).Insert(fromIndex, (T)item);
					return LogSuccess(msg2);
				}
				bool flag2 = LogError(msg3);
				object[] array = new object[4];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[1] = array;
				int count3 = ((RepeatedField<T>)(object)subStep.objectives_).Count;
				if (count3 == 0 || count3 != 0)
				{
					array[2] = count3;
					if (count3 != 0)
					{
						string msg4 = string.Format("Invalid FromIndex={0}, ToIndex={1}, count={2}, {3}", array);
						bool flag3 = LogError(msg4);
						break;
					}
				}
			}
			string msg5 = default(string);
			bool flag4 = LogSuccess(msg5);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600769A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void PreInit()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600769B")]
		[Cpp2IlInjected.Address(RVA = "0x177D750", Offset = "0x177C150", VA = "0x18177D750")]
		private void AdvanceStep()
		{
			//Discarded unreachable code: IL_0022
			if (MissionSlot.state_ == MissionSlotState.OnGoing)
			{
				ApplyNewCurrentStep();
				bool flag = LogSuccess("AdvanceStep");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600769C")]
		[Cpp2IlInjected.Address(RVA = "0x177D7C0", Offset = "0x177C1C0", VA = "0x18177D7C0")]
		private void ApplyNewCurrentStep()
		{
			//IL_013b: Expected I4, but got I8
			MissionSlot missionSlot = MissionSlot;
			if (missionSlot.state_ != MissionSlotState.OnGoing)
			{
				return;
			}
			CurrentStepUpdated = true;
			RepeatedField<MissionStep> missionSteps_ = missionSlot.missionSteps_;
			int currentStepIndex_ = missionSlot.currentStepIndex_;
			int count = ((RepeatedField<T>)(object)missionSteps_).Count;
			if (currentStepIndex_ < count)
			{
				MissionSlot missionSlot2 = MissionSlot;
				int currentStepIndex_2 = missionSlot2.currentStepIndex_;
				if (!missionSlot2.IsValidStepIndex(currentStepIndex_2))
				{
					MissionSlot missionSlot3 = MissionSlot;
					MissionSlot missionSlot4 = MissionSlot;
				}
			}
			IEnumerable<MissionObjective> allStepsObjectives = (IEnumerable<MissionObjective>)MissionSlot.get_AllStepsObjectives();
			Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
			if (_003C_003Ec._003C_003E9__88_0 == null)
			{
				func = (Func<MissionObjective, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_0015
					MissionStepStatus status_ = x.status_;
					if (status_ < MissionStepStatus.Ongoing)
					{
						int num = 0;
					}
					return status_ <= MissionStepStatus.Completed;
				});
			}
			IEnumerable<MissionObjective> enumerable = (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)func);
			Action<MissionObjective> action = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__88_1 == null)
			{
				action = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000a
					//IL_0009: Expected I4, but got I8
					x.status_ = MissionStepStatus.Confirmed;
				});
			}
			MoreLinq.ForEach<MissionObjective>((IEnumerable<>)enumerable, (Action<>)(object)action);
			MissionSlot missionSlot5 = MissionSlot;
			RepeatedField<MissionStep> missionSteps_2 = missionSlot5.missionSteps_;
			int currentStepIndex_3 = missionSlot5.currentStepIndex_;
			int count2 = ((RepeatedField<T>)(object)missionSteps_2).Count;
			MissionSlot missionSlot6 = MissionSlot;
			if (currentStepIndex_3 < count2)
			{
				IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionSlot6.CurrentStep.get_AllObjectives();
				Action<MissionObjective> action2 = default(Action<MissionObjective>);
				if (_003C_003Ec._003C_003E9__88_2 == null)
				{
					action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_000a
						//IL_0009: Expected I4, but got I8
						x.status_ = MissionStepStatus.Ongoing;
					});
				}
				MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action2);
				return;
			}
			MissionSlot.state_ = MissionSlotState.Completed;
			MissionItemData data = MissionSlot.Data;
			while (data == null)
			{
			}
			while (data.completedCase_ != MissionItemData.CompletedOneofCase.NoOutro)
			{
			}
			string debugName = DebugName;
			Exception ex = new Exception("[ACTION] " + debugName + " - Deleting last step of mission with NoOutro is not supported yet!");
			/*Error: Unexpected end of block*/;
		}
	}
}
