using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010BB")]
	public sealed class RoyalDutyProgress : IMessage<RoyalDutyProgress>, IMessage, IEquatable<RoyalDutyProgress>, IDeepCloneable<RoyalDutyProgress>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40044E3")]
		private static readonly MessageParser<RoyalDutyProgress> _parser = (MessageParser<RoyalDutyProgress>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new RoyalDutyProgress()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40044E4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40044E5")]
		public const int DutyDayCountFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40044E6")]
		private static readonly MapField<int, int>.Codec _map_dutyDayCount_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40044E7")]
		private readonly MapField<int, int> dutyDayCount_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40044E8")]
		public const int LastResetTimeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40044E9")]
		private Timestamp lastResetTime_;

		[Cpp2IlInjected.Token(Token = "0x40044EA")]
		public const int LastDutyItemIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40044EB")]
		private int lastDutyItemID_;

		[Cpp2IlInjected.Token(Token = "0x40044EC")]
		public const int StepsUsedFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40044ED")]
		private static readonly MapField<int, bool>.Codec _map_stepsUsed_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40044EE")]
		private readonly MapField<int, bool> stepsUsed_ = (MapField<int, bool>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40044EF")]
		public const int CurDutyIndexFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40044F0")]
		private int curDutyIndex_;

		[Cpp2IlInjected.Token(Token = "0x40044F1")]
		public const int DutyLevelsUsedFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40044F2")]
		private static readonly MapField<int, int>.Codec _map_dutyLevelsUsed_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40044F3")]
		private readonly MapField<int, int> dutyLevelsUsed_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17001789")]
		public int TotalDailyDutiesCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60087A4")]
			[Cpp2IlInjected.Address(RVA = "0x1768070", Offset = "0x1766A70", VA = "0x181768070")]
			get
			{
				MapField<int, int> mapField = dutyDayCount_;
				Func<KeyValuePair<int, int>, int> _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_0;
				if (_003C_003E9__1_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return Enumerable.Sum<KeyValuePair<int, int>>((IEnumerable<>)(object)mapField, (Func<, >)(object)_003C_003E9__1_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178A")]
		[DebuggerNonUserCode]
		public static MessageParser<RoyalDutyProgress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60087AC")]
			[Cpp2IlInjected.Address(RVA = "0x1768010", Offset = "0x1766A10", VA = "0x181768010")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60087AD")]
			[Cpp2IlInjected.Address(RVA = "0x1767F40", Offset = "0x1766940", VA = "0x181767F40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60087AE")]
			[Cpp2IlInjected.Address(RVA = "0x17681A0", Offset = "0x1766BA0", VA = "0x1817681A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178D")]
		[DebuggerNonUserCode]
		public MapField<int, int> DutyDayCount
		{
			[Cpp2IlInjected.Token(Token = "0x60087B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return dutyDayCount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178E")]
		[DebuggerNonUserCode]
		public Timestamp LastResetTime
		{
			[Cpp2IlInjected.Token(Token = "0x60087B3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastResetTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x60087B4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastResetTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700178F")]
		[DebuggerNonUserCode]
		public int LastDutyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60087B5")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return lastDutyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60087B6")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				lastDutyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001790")]
		[DebuggerNonUserCode]
		public MapField<int, bool> StepsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x60087B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return stepsUsed_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001791")]
		[DebuggerNonUserCode]
		public int CurDutyIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60087B8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return curDutyIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x60087B9")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				curDutyIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001792")]
		[DebuggerNonUserCode]
		public MapField<int, int> DutyLevelsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x60087BA")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return dutyLevelsUsed_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087A5")]
		[Cpp2IlInjected.Address(RVA = "0x1766D20", Offset = "0x1765720", VA = "0x181766D20")]
		public void IncrementDailyDutyProgress(int dutyID)
		{
			//Discarded unreachable code: IL_0041
			//IL_000c: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected I4, but got Unknown
			//IL_0039: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			if (!((MapField<TKey, TValue>)(object)dutyDayCount_).ContainsKey((TKey)dutyID))
			{
				MapField<int, int> mapField = dutyDayCount_;
				int num = 0;
				((MapField<TKey, TValue>)(object)mapField).Add((TKey)dutyID, (TValue)num);
			}
			MapField<int, int> mapField2 = dutyDayCount_;
			int num2 = ((MapField<TKey, TValue>)(object)mapField2)[(TKey)dutyID] + 1;
			((MapField<TKey, TValue>)(object)mapField2)[(TKey)dutyID] = (TValue)num2;
			lastDutyItemID_ = dutyID;
		}

		[Cpp2IlInjected.Token(Token = "0x60087A6")]
		[Cpp2IlInjected.Address(RVA = "0x1767510", Offset = "0x1765F10", VA = "0x181767510")]
		public void UseDutyWithStep(RoyalDutyItemData selectedDuty)
		{
			//Discarded unreachable code: IL_00c2
			//IL_003a: Expected O, but got I4
			//IL_0058: Expected O, but got I8
			//IL_0058: Expected O, but got I4
			//IL_0067: Expected O, but got I8
			//IL_0067: Expected O, but got I4
			if (((RepeatedField<T>)(object)selectedDuty.stepDifficultyLayers_).Count > 0)
			{
				RepeatedField<DutyStepDifficulty> stepDifficultyLayers_ = selectedDuty.stepDifficultyLayers_;
				int index = 0;
				DutyStepDifficulty dutyStepDifficulty = (DutyStepDifficulty)((RepeatedField<T>)(object)stepDifficultyLayers_)[index];
				MapField<int, bool> mapField = stepsUsed_;
				DutyStepDifficulty.DifficultyStepOneofCase difficultyStepCase_ = dutyStepDifficulty.difficultyStepCase_;
				int num = (int)difficultyStepCase_;
				bool flag = ((MapField<TKey, TValue>)(object)mapField).ContainsKey((TKey)num);
				MapField<int, bool> mapField2 = stepsUsed_;
				if (flag)
				{
					int num2 = (int)difficultyStepCase_;
					ulong num3 = default(ulong);
					((MapField<TKey, TValue>)(object)mapField2)[(TKey)num2] = (TValue)num3;
				}
				int num4 = (int)difficultyStepCase_;
				ulong num5 = default(ulong);
				((MapField<TKey, TValue>)(object)mapField2).Add((TKey)num4, (TValue)num5);
			}
			string[] names = System.Enum.GetNames(typeof(DutyStepDifficulty.DifficultyStepOneofCase));
			MapField<int, bool> mapField3 = stepsUsed_;
			int length = names.Length;
			Func<KeyValuePair<int, bool>, bool> func = default(Func<KeyValuePair<int, bool>, bool>);
			if (_003C_003Ec._003C_003E9__3_0 == null)
			{
				func = (Func<KeyValuePair<int, bool>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			int num6 = Enumerable.Count<KeyValuePair<int, bool>>((IEnumerable<>)(object)mapField3, (Func<, >)(object)func);
			if (length == num6)
			{
				resetStepsUsed();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087A7")]
		[Cpp2IlInjected.Address(RVA = "0x1766E00", Offset = "0x1765800", VA = "0x181766E00")]
		public bool IsStepUsed(RoyalDutyItemData selectedDuty)
		{
			if (((RepeatedField<T>)(object)selectedDuty.stepDifficultyLayers_).Count > 0)
			{
				RepeatedField<DutyStepDifficulty> stepDifficultyLayers_ = selectedDuty.stepDifficultyLayers_;
				int index = 0;
				DutyStepDifficulty dutyStepDifficulty = (DutyStepDifficulty)((RepeatedField<T>)(object)stepDifficultyLayers_)[index];
				MapField<int, bool> mapField = stepsUsed_;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087A8")]
		[Cpp2IlInjected.Address(RVA = "0x1768770", Offset = "0x1767170", VA = "0x181768770")]
		public void resetStepsUsed()
		{
			//Discarded unreachable code: IL_0032, IL_0038
			int num = 0;
			ICollection<int> collection = (ICollection<int>)((MapField<TKey, TValue>)(object)stepsUsed_).get_Keys();
			if (collection != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0029;
					}
					num++;
				}
				MapField<int, bool> mapField = stepsUsed_;
				goto IL_0029;
			}
			goto IL_002d;
			IL_002d:
			if (collection == null)
			{
			}
			return;
			IL_0029:
			collection = (ICollection<int>)(object)((object)collection + (object)collection);
			goto IL_002d;
		}

		[Cpp2IlInjected.Token(Token = "0x60087A9")]
		[Cpp2IlInjected.Address(RVA = "0x17682B0", Offset = "0x1766CB0", VA = "0x1817682B0")]
		public void resetDifficultyLevels([Optional] List<int> dutySlots)
		{
			//Discarded unreachable code: IL_00a3, IL_00a9, IL_00af, IL_00b5, IL_00bb, IL_00c1
			//IL_0092: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (dutySlots != null)
			{
				List<RoyalDutyItemData> list = (List<RoyalDutyItemData>)(object)Enumerable.ToList<RoyalDutyItemData>(ItemDatabase.Instance.GetAllByType<RoyalDutyItemData>(ItemType.DutyAch));
				List<int> list2 = (List<int>)(object)new List<T>();
				MapField<int, int> mapField = dutyLevelsUsed_;
				bool flag = default(bool);
				if (flag)
				{
					int dutyID = num;
					Predicate<RoyalDutyItemData> predicate = (Predicate<RoyalDutyItemData>)(object)(Predicate<T>)delegate(RoyalDutyItemData x)
					{
						//Discarded unreachable code: IL_0011
						int num6 = dutyID;
						return x.iD_ == num6;
					};
					RoyalDutyItemData royalDutyItemData = (RoyalDutyItemData)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
					if (royalDutyItemData != null)
					{
						int num4 = dutyID;
						bool flag2 = default(bool);
						while (flag2)
						{
						}
						int count = ((RepeatedField<T>)(object)royalDutyItemData.stepDifficultyLayers_).Count;
					}
					int num5 = dutyID;
					((List<T>)(object)list2).Add((T)num5);
				}
				bool flag3 = default(bool);
				if (!flag3)
				{
				}
			}
			((MapField<TKey, TValue>)(object)dutyLevelsUsed_).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60087AA")]
		[Cpp2IlInjected.Address(RVA = "0x1766B90", Offset = "0x1765590", VA = "0x181766B90")]
		public unsafe bool GetNextDifficultyLayerLevel(RoyalDutyItemData dutyData, out int nextLevel)
		{
			//Discarded unreachable code: IL_003c
			//IL_001f: Expected O, but got I4
			int num = (nextLevel.m_value = 0);
			MapField<int, int> mapField = dutyLevelsUsed_;
			int iD_ = dutyData.iD_;
			if (((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)iD_, out *(TValue*)num))
			{
				num = (nextLevel.m_value = num + 1);
			}
			int count = ((RepeatedField<T>)(object)dutyData.stepDifficultyLayers_).Count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60087AB")]
		[Cpp2IlInjected.Address(RVA = "0x1766C40", Offset = "0x1765640", VA = "0x181766C40")]
		public unsafe int IncDifficultyLayerLevel(RoyalDutyItemData dutyData)
		{
			//Discarded unreachable code: IL_0047
			//IL_0018: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int num = 0;
			MapField<int, int> mapField = dutyLevelsUsed_;
			int iD_ = dutyData.iD_;
			if (((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)iD_, out *(TValue*)num))
			{
				num++;
			}
			int count = ((RepeatedField<T>)(object)dutyData.stepDifficultyLayers_).Count;
			MapField<int, int> mapField2 = dutyLevelsUsed_;
			int iD_2 = dutyData.iD_;
			((MapField<TKey, TValue>)(object)mapField2)[(TKey)iD_2] = (TValue)num;
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60087AF")]
		[Cpp2IlInjected.Address(RVA = "0x1767C50", Offset = "0x1766650", VA = "0x181767C50")]
		[DebuggerNonUserCode]
		public RoyalDutyProgress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60087B0")]
		[Cpp2IlInjected.Address(RVA = "0x1767D40", Offset = "0x1766740", VA = "0x181767D40")]
		[DebuggerNonUserCode]
		public RoyalDutyProgress(RoyalDutyProgress other)
		{
			//IL_0061: Expected O, but got I4
			MapField<int, int> mapField = (dutyDayCount_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.dutyDayCount_).Clone());
			Timestamp timestamp = other.lastResetTime_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			lastResetTime_ = (Timestamp)num;
			int num2 = (lastDutyItemID_ = other.lastDutyItemID_);
			MapField<int, bool> mapField2 = (stepsUsed_ = (MapField<int, bool>)(object)((MapField<TKey, TValue>)(object)other.stepsUsed_).Clone());
			int num3 = (curDutyIndex_ = other.curDutyIndex_);
			MapField<int, int> mapField3 = (dutyLevelsUsed_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.dutyLevelsUsed_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087B1")]
		[Cpp2IlInjected.Address(RVA = "0x17666C0", Offset = "0x17650C0", VA = "0x1817666C0", Slot = "10")]
		[DebuggerNonUserCode]
		public RoyalDutyProgress Clone()
		{
			return new RoyalDutyProgress(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60087BB")]
		[Cpp2IlInjected.Address(RVA = "0x1766830", Offset = "0x1765230", VA = "0x181766830", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				MapField<int, int> mapField = dutyDayCount_;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = object.Equals(lastResetTime_, other);
					if (flag2 && lastDutyItemID_ == (flag2 ? 1 : 0))
					{
						MapField<int, bool> mapField2 = stepsUsed_;
						bool flag3 = default(bool);
						if (flag3 && curDutyIndex_ == (flag3 ? 1 : 0))
						{
							MapField<int, int> mapField3 = dutyLevelsUsed_;
							bool flag4 = default(bool);
							if (flag4)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087BC")]
		[Cpp2IlInjected.Address(RVA = "0x1766720", Offset = "0x1765120", VA = "0x181766720", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RoyalDutyProgress other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<int, int> mapField = dutyDayCount_;
				MapField<int, int> mapField2 = other.dutyDayCount_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					Timestamp objB = other.lastResetTime_;
					if (object.Equals(lastResetTime_, objB))
					{
						int num = other.lastDutyItemID_;
						if (lastDutyItemID_ == num)
						{
							MapField<int, bool> mapField3 = stepsUsed_;
							MapField<int, bool> mapField4 = other.stepsUsed_;
							if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
							{
								int num2 = other.curDutyIndex_;
								if (curDutyIndex_ == num2)
								{
									MapField<int, int> mapField5 = dutyLevelsUsed_;
									MapField<int, int> mapField6 = other.dutyLevelsUsed_;
									if (((MapField<TKey, TValue>)(object)mapField5).Equals((MapField<, >)(object)mapField6))
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60087BD")]
		[Cpp2IlInjected.Address(RVA = "0x1766AA0", Offset = "0x17654A0", VA = "0x181766AA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0066
			int hashCode = ((MapField<TKey, TValue>)(object)dutyDayCount_).GetHashCode();
			Timestamp timestamp = lastResetTime_;
			if (timestamp != null)
			{
				int hashCode2 = timestamp.GetHashCode();
			}
			if (lastDutyItemID_ != 0)
			{
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)stepsUsed_).GetHashCode();
			if (curDutyIndex_ != 0)
			{
			}
			int hashCode4 = ((MapField<TKey, TValue>)(object)dutyLevelsUsed_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60087BE")]
		[Cpp2IlInjected.Address(RVA = "0x17674B0", Offset = "0x1765EB0", VA = "0x1817674B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60087BF")]
		[Cpp2IlInjected.Address(RVA = "0x17677E0", Offset = "0x17661E0", VA = "0x1817677E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a6
			MapField<int, int> mapField = dutyDayCount_;
			MapField<int, int>.Codec map_dutyDayCount_codec = _map_dutyDayCount_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_dutyDayCount_codec);
			if ((long)lastResetTime_ != 0)
			{
				Timestamp value = lastResetTime_;
				output.WriteMessage(value);
			}
			if (lastDutyItemID_ != 0)
			{
				int value2 = lastDutyItemID_;
				output.WriteInt32(value2);
			}
			MapField<int, bool> mapField2 = stepsUsed_;
			MapField<int, bool>.Codec map_stepsUsed_codec = _map_stepsUsed_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_stepsUsed_codec);
			if (curDutyIndex_ != 0)
			{
				int value3 = curDutyIndex_;
				output.WriteInt32(value3);
			}
			MapField<int, int> mapField3 = dutyLevelsUsed_;
			MapField<int, int>.Codec map_dutyLevelsUsed_codec = _map_dutyLevelsUsed_codec;
			((MapField<TKey, TValue>)(object)mapField3).WriteTo(output, (MapField<, >.Codec)(object)map_dutyLevelsUsed_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60087C0")]
		[Cpp2IlInjected.Address(RVA = "0x17663D0", Offset = "0x1764DD0", VA = "0x1817663D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00d4
			MapField<int, int> mapField = dutyDayCount_;
			MapField<int, int>.Codec map_dutyDayCount_codec = _map_dutyDayCount_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_dutyDayCount_codec);
			Timestamp timestamp = lastResetTime_;
			if (timestamp != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				num2++;
				num += num2;
			}
			int num3 = lastDutyItemID_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			MapField<int, bool> mapField2 = stepsUsed_;
			MapField<int, bool>.Codec map_stepsUsed_codec = _map_stepsUsed_codec;
			int num5 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_stepsUsed_codec);
			int num6 = curDutyIndex_;
			num += num5;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			MapField<int, int> mapField3 = dutyLevelsUsed_;
			MapField<int, int>.Codec map_dutyLevelsUsed_codec = _map_dutyLevelsUsed_codec;
			int num8 = ((MapField<TKey, TValue>)(object)mapField3).CalculateSize((MapField<, >.Codec)(object)map_dutyLevelsUsed_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num8;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num += num9;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60087C1")]
		[Cpp2IlInjected.Address(RVA = "0x1767130", Offset = "0x1765B30", VA = "0x181767130", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RoyalDutyProgress other)
		{
			//Discarded unreachable code: IL_00cb
			if (other == null)
			{
				return;
			}
			MapField<int, int> mapField = dutyDayCount_;
			MapField<int, int> mapField2 = other.dutyDayCount_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			if ((long)other.lastResetTime_ != 0)
			{
				Timestamp timestamp = lastResetTime_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastResetTime_ = new Timestamp());
				}
				Timestamp other2 = other.lastResetTime_;
				timestamp.MergeFrom(other2);
			}
			int num = other.lastDutyItemID_;
			if (num != 0)
			{
				lastDutyItemID_ = num;
			}
			MapField<int, bool> mapField3 = stepsUsed_;
			MapField<int, bool> mapField4 = other.stepsUsed_;
			((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
			int num2 = other.curDutyIndex_;
			if (num2 != 0)
			{
				curDutyIndex_ = num2;
			}
			MapField<int, int> mapField5 = dutyLevelsUsed_;
			MapField<int, int> mapField6 = other.dutyLevelsUsed_;
			((MapField<TKey, TValue>)(object)mapField5).Add((IDictionary<, >)(object)mapField6);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60087C2")]
		[Cpp2IlInjected.Address(RVA = "0x1766ED0", Offset = "0x17658D0", VA = "0x181766ED0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00e1
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 34)
				{
					MapField<int, bool> mapField = stepsUsed_;
					MapField<int, bool>.Codec map_stepsUsed_codec = _map_stepsUsed_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_stepsUsed_codec);
				}
				int num2 = default(int);
				if (num == 40)
				{
					num2 = (curDutyIndex_ = input.ReadInt32());
				}
				if (num2 != 50)
				{
					goto IL_00ca;
				}
				MapField<int, int> mapField2 = dutyLevelsUsed_;
				MapField<int, int>.Codec map_dutyLevelsUsed_codec = _map_dutyLevelsUsed_codec;
				((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_dutyLevelsUsed_codec);
			}
			if (num == 10)
			{
				MapField<int, int> mapField3 = dutyDayCount_;
				MapField<int, int>.Codec map_dutyDayCount_codec = _map_dutyDayCount_codec;
				((MapField<TKey, TValue>)(object)mapField3).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_dutyDayCount_codec);
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (lastResetTime_ == null)
				{
					timestamp = (lastResetTime_ = new Timestamp());
					builder = lastResetTime_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 24)
			{
				int num3 = (lastDutyItemID_ = input.ReadInt32());
			}
			goto IL_00ca;
			IL_00ca:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60087C3")]
		[Cpp2IlInjected.Address(RVA = "0x1766980", Offset = "0x1765380", VA = "0x181766980", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				MapField<int, int> mapField = dutyDayCount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60087C4")]
		[Cpp2IlInjected.Address(RVA = "0x1767280", Offset = "0x1765C80", VA = "0x181767280", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a
			//IL_0017: Expected O, but got I4
			while (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value == null || value != null)
				{
					lastResetTime_ = (Timestamp)num;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087C5")]
		[Cpp2IlInjected.Address(RVA = "0x17665E0", Offset = "0x1764FE0", VA = "0x1817665E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_0009
			if (fieldNumber - 1 > 5)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60087C6")]
		[Cpp2IlInjected.Address(RVA = "0x17679D0", Offset = "0x17663D0", VA = "0x1817679D0")]
		static RoyalDutyProgress()
		{
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<RoyalDutyProgress>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			FieldCodec<int> fieldCodec3 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<bool> fieldCodec4 = (FieldCodec<bool>)(object)FieldCodec.ForBool(16u);
			uint num2 = default(uint);
			_parser = (MessageParser<RoyalDutyProgress>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, (FieldCodec<>)(object)fieldCodec4, num2);
			FieldCodec<int> fieldCodec5 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec6 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num3 = default(uint);
			_parser = (MessageParser<RoyalDutyProgress>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec5, (FieldCodec<>)(object)fieldCodec6, num3);
			/*Error: Unexpected end of block*/;
		}
	}
}
