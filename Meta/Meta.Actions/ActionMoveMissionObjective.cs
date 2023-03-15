using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DFC")]
	public sealed class ActionMoveMissionObjective : IMessage<ActionMoveMissionObjective>, IMessage, IEquatable<ActionMoveMissionObjective>, IDeepCloneable<ActionMoveMissionObjective>, IMessageFieldAccessor, IAction, IMissionItem, IMissionStepName, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40038B8")]
		private static readonly MessageParser<ActionMoveMissionObjective> _parser = (MessageParser<ActionMoveMissionObjective>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ActionMoveMissionObjective()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038B9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038BA")]
		public const int MissionIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038BB")]
		private int missionID_;

		[Cpp2IlInjected.Token(Token = "0x40038BC")]
		public const int StepNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40038BD")]
		private string stepName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40038BE")]
		public const int FromIndexFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40038BF")]
		private int fromIndex_;

		[Cpp2IlInjected.Token(Token = "0x40038C0")]
		public const int ToIndexFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40038C1")]
		private int toIndex_;

		[Cpp2IlInjected.Token(Token = "0x40038C2")]
		public const int PrevAmountFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40038C3")]
		private int prevAmount_;

		[Cpp2IlInjected.Token(Token = "0x40038C4")]
		public const int TargetedItemIDFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40038C5")]
		private int targetedItemID_;

		[Cpp2IlInjected.Token(Token = "0x17001457")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionMoveMissionObjective> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007536")]
			[Cpp2IlInjected.Address(RVA = "0x1E334C0", Offset = "0x1E31EC0", VA = "0x181E334C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001458")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007537")]
			[Cpp2IlInjected.Address(RVA = "0x1E33120", Offset = "0x1E31B20", VA = "0x181E33120")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001459")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007538")]
			[Cpp2IlInjected.Address(RVA = "0x1E33580", Offset = "0x1E31F80", VA = "0x181E33580", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145A")]
		[DebuggerNonUserCode]
		public int MissionID
		{
			[Cpp2IlInjected.Token(Token = "0x600753C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return missionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600753D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				missionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145B")]
		[DebuggerNonUserCode]
		public string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x600753E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
			get
			{
				return stepName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600753F")]
			[Cpp2IlInjected.Address(RVA = "0x1E33690", Offset = "0x1E32090", VA = "0x181E33690", Slot = "18")]
			set
			{
				string text = (stepName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145C")]
		[DebuggerNonUserCode]
		public int FromIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6007540")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return fromIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007541")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				fromIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145D")]
		[DebuggerNonUserCode]
		public int ToIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6007542")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return toIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007543")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				toIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145E")]
		[DebuggerNonUserCode]
		public int PrevAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6007544")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return prevAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007545")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				prevAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145F")]
		[DebuggerNonUserCode]
		public int TargetedItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6007546")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return targetedItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007547")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				targetedItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001460")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6007553")]
			[Cpp2IlInjected.Address(RVA = "0x1E33460", Offset = "0x1E31E60", VA = "0x181E33460", Slot = "16")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001461")]
		public Item TargetedItem
		{
			[Cpp2IlInjected.Token(Token = "0x6007554")]
			[Cpp2IlInjected.Address(RVA = "0x1E33520", Offset = "0x1E31F20", VA = "0x181E33520")]
			get
			{
				long num = Convert.ToInt64((uint)targetedItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001462")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6007556")]
			[Cpp2IlInjected.Address(RVA = "0x1E331F0", Offset = "0x1E31BF0", VA = "0x181E331F0", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_0080
				//IL_0055: Expected O, but got I4
				//IL_0074: Expected O, but got I4
				object[] array;
				string text = default(string);
				int num2;
				while (true)
				{
					array = new object[4];
					long num = Convert.ToInt64((uint)missionID_);
					if (text != null && text == null)
					{
						continue;
					}
					array[0] = text;
					string text2 = stepName_;
					if (text2 != null && text == null)
					{
						continue;
					}
					array[1] = text2;
					num2 = fromIndex_;
					if (num2 == 0 || num2 != 0)
					{
						array[2] = num2;
						int num3 = toIndex_;
						num2 = num3;
						if (num3 == 0 || num3 != 0)
						{
							break;
						}
					}
				}
				array[3] = num2;
				return string.Format("MoveObjective for {0}:{1} from {2} to {3}", array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007539")]
		[Cpp2IlInjected.Address(RVA = "0x1E33010", Offset = "0x1E31A10", VA = "0x181E33010")]
		[DebuggerNonUserCode]
		public ActionMoveMissionObjective()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600753A")]
		[Cpp2IlInjected.Address(RVA = "0x1E33060", Offset = "0x1E31A60", VA = "0x181E33060")]
		[DebuggerNonUserCode]
		public ActionMoveMissionObjective(ActionMoveMissionObjective other)
		{
			int num = (missionID_ = other.missionID_);
			string text = (stepName_ = other.stepName_);
			int num2 = (fromIndex_ = other.fromIndex_);
			int num3 = (toIndex_ = other.toIndex_);
			int num4 = (prevAmount_ = other.prevAmount_);
			int num5 = (targetedItemID_ = other.targetedItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600753B")]
		[Cpp2IlInjected.Address(RVA = "0x1E31EF0", Offset = "0x1E308F0", VA = "0x181E31EF0", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionMoveMissionObjective Clone()
		{
			//Discarded unreachable code: IL_0082
			ActionMoveMissionObjective actionMoveMissionObjective = new ActionMoveMissionObjective();
			actionMoveMissionObjective.stepName_ = "";
			int num = (actionMoveMissionObjective.missionID_ = missionID_);
			string text = (actionMoveMissionObjective.stepName_ = stepName_);
			int num2 = (actionMoveMissionObjective.fromIndex_ = fromIndex_);
			int num3 = (actionMoveMissionObjective.toIndex_ = toIndex_);
			int num4 = (actionMoveMissionObjective.prevAmount_ = prevAmount_);
			int num5 = (actionMoveMissionObjective.targetedItemID_ = targetedItemID_);
			UnknownFieldSet unknownFieldSet = (actionMoveMissionObjective._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionMoveMissionObjective;
		}

		[Cpp2IlInjected.Token(Token = "0x6007548")]
		[Cpp2IlInjected.Address(RVA = "0x1E322B0", Offset = "0x1E30CB0", VA = "0x181E322B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)missionID_ == (IntPtr)typeof(ActionMoveMissionObjective).TypeHandle)
				{
					string text = stepName_;
					bool flag = default(bool);
					if (!flag && fromIndex_ == (flag ? 1 : 0) && toIndex_ == (flag ? 1 : 0) && prevAmount_ == (flag ? 1 : 0) && targetedItemID_ == (flag ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007549")]
		[Cpp2IlInjected.Address(RVA = "0x1E32390", Offset = "0x1E30D90", VA = "0x181E32390", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionMoveMissionObjective other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.missionID_;
				if (missionID_ == num)
				{
					string text = other.stepName_;
					if (!(stepName_ != text))
					{
						int num2 = other.fromIndex_;
						if (fromIndex_ == num2)
						{
							int num3 = other.toIndex_;
							if (toIndex_ == num3)
							{
								int num4 = other.prevAmount_;
								if (prevAmount_ == num4)
								{
									int num5 = other.targetedItemID_;
									if (targetedItemID_ == num5)
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
			int num6 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600754A")]
		[Cpp2IlInjected.Address(RVA = "0x1E32530", Offset = "0x1E30F30", VA = "0x181E32530", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0059
			if (missionID_ != 0)
			{
			}
			string text = stepName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (fromIndex_ != 0)
			{
			}
			if (toIndex_ != 0)
			{
			}
			if (prevAmount_ != 0)
			{
			}
			if (targetedItemID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600754B")]
		[Cpp2IlInjected.Address(RVA = "0x1E32D60", Offset = "0x1E31760", VA = "0x181E32D60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600754C")]
		[Cpp2IlInjected.Address(RVA = "0x1E32DC0", Offset = "0x1E317C0", VA = "0x181E32DC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a9
			if (missionID_ != 0)
			{
				int value = missionID_;
				output.WriteInt32(value);
			}
			if (stepName_.m_stringLength != 0)
			{
				string value2 = stepName_;
				output.WriteString(value2);
			}
			if (fromIndex_ != 0)
			{
				int value3 = fromIndex_;
				output.WriteInt32(value3);
			}
			if (toIndex_ != 0)
			{
				int value4 = toIndex_;
				output.WriteInt32(value4);
			}
			if (prevAmount_ != 0)
			{
				int value5 = prevAmount_;
				output.WriteInt32(value5);
			}
			if (targetedItemID_ != 0)
			{
				int value6 = targetedItemID_;
				output.WriteInt32(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600754D")]
		[Cpp2IlInjected.Address(RVA = "0x1E31C70", Offset = "0x1E30670", VA = "0x181E31C70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00d8
			int num = missionID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = stepName_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			int num5 = fromIndex_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num2 += num6;
			}
			int num7 = toIndex_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num2 += num8;
			}
			int num9 = prevAmount_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = targetedItemID_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600754E")]
		[Cpp2IlInjected.Address(RVA = "0x1E32720", Offset = "0x1E31120", VA = "0x181E32720", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionMoveMissionObjective other)
		{
			//Discarded unreachable code: IL_009e
			if (other != null)
			{
				int num = other.missionID_;
				if (num != 0)
				{
					missionID_ = num;
				}
				string text = other.stepName_;
				if (text.m_stringLength != 0)
				{
					StepName = text;
				}
				int num2 = other.fromIndex_;
				if (num2 != 0)
				{
					fromIndex_ = num2;
				}
				int num3 = other.toIndex_;
				if (num3 != 0)
				{
					toIndex_ = num3;
				}
				int num4 = other.prevAmount_;
				if (num4 != 0)
				{
					prevAmount_ = num4;
				}
				int num5 = other.targetedItemID_;
				if (num5 != 0)
				{
					targetedItemID_ = num5;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600754F")]
		[Cpp2IlInjected.Address(RVA = "0x1E32620", Offset = "0x1E31020", VA = "0x181E32620", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00aa
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 32)
				{
					int num2 = (toIndex_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 40)
				{
					num3 = (prevAmount_ = input.ReadInt32());
				}
				if (num3 != 48)
				{
					goto IL_0093;
				}
				int num4 = (targetedItemID_ = input.ReadInt32());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (missionID_ = input.ReadInt32());
			}
			string text2 = default(string);
			if (num5 == 18)
			{
				text2 = (StepName = input.ReadString());
			}
			if ((long)text2 == 24)
			{
				int num6 = (fromIndex_ = input.ReadInt32());
			}
			goto IL_0093;
			IL_0093:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6007550")]
		[Cpp2IlInjected.Address(RVA = "0x1E32420", Offset = "0x1E30E20", VA = "0x181E32420", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = missionID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007551")]
		[Cpp2IlInjected.Address(RVA = "0x1E32B50", Offset = "0x1E31550", VA = "0x181E32B50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0017, IL_001f, IL_0027, IL_002f, IL_0035, IL_003b
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				missionID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007552")]
		[Cpp2IlInjected.Address(RVA = "0x1E31E10", Offset = "0x1E30810", VA = "0x181E31E10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				missionID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007555")]
		[Cpp2IlInjected.Address(RVA = "0x1E31B50", Offset = "0x1E30550", VA = "0x181E31B50", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = missionID_;
			Func<MissionObjective, string> func = (Func<MissionObjective, string>)(object)new Func<T, TResult>(ObjectiveValidation);
		}

		[Cpp2IlInjected.Token(Token = "0x6007557")]
		[Cpp2IlInjected.Address(RVA = "0x1E322A0", Offset = "0x1E30CA0", VA = "0x181E322A0", Slot = "19")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_0010: Expected I4, but got I8
			prevAmount_ = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6007558")]
		[Cpp2IlInjected.Address(RVA = "0x1E327C0", Offset = "0x1E311C0", VA = "0x181E327C0")]
		private string ObjectiveValidation(MissionObjective obj)
		{
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			int num = prevAmount_;
			if (num > 0)
			{
				int targetAmountInt = obj.TargetAmountInt;
				if (num != targetAmountInt)
				{
					int targetAmountInt2 = obj.TargetAmountInt;
					int num2 = prevAmount_;
					return $"Previous value was {targetAmountInt2} instead of {targetAmountInt2}";
				}
			}
			int num3 = targetedItemID_;
			bool flag = default(bool);
			if (flag)
			{
				IEnumerable<Item> enumerable = (IEnumerable<Item>)obj.itemFilter_.SelectedItems();
				long num4 = Convert.ToInt64((uint)targetedItemID_);
				bool flag2 = default(bool);
				if (!flag2)
				{
					Item targetedItem = TargetedItem;
					IEnumerable<Item> enumerable2 = (IEnumerable<Item>)obj.itemFilter_.SelectedItems();
					Func<Item, string> func = default(Func<Item, string>);
					if (_003C_003Ec._003C_003E9__61_0 == null)
					{
						string result = default(string);
						func = (Func<Item, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => result));
					}
					IEnumerable<Item> enumerable3 = (IEnumerable<Item>)Enumerable.Select<Item, string>((IEnumerable<>)enumerable2, (Func<, >)(object)func);
					string arg = string.Join(", ", (IEnumerable<>)enumerable3);
					return $"Objective don't target {targetedItem}.. Targets:{arg}";
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007559")]
		[Cpp2IlInjected.Address(RVA = "0x1E31FD0", Offset = "0x1E309D0", VA = "0x181E31FD0", Slot = "20")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0085
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = missionID_;
			bool flag = default(bool);
			if (flag)
			{
				Func<MissionObjectiveData, bool> func = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
				{
					//Discarded unreachable code: IL_0014
					string b = stepName_;
					return string.Equals(x.stepName_, b);
				};
				IEnumerable<MissionObjectiveData> enumerable = default(IEnumerable<MissionObjectiveData>);
				if (Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)enumerable, (Func<, >)(object)func) == null)
				{
					int num2 = missionID_;
					string text = default(string);
					string message = "Cannot found this step in " + text;
					context.AddInvalidMemberError(message, "StepName");
				}
			}
			int num3 = toIndex_;
			if (fromIndex_ == num3)
			{
				context.AddError("FromIndex and ToIndex cannot have same value");
			}
			if (prevAmount_ == 0)
			{
				context.AddInvalidMemberError("Cannot be 0 (use -1 for any value)", "PrevAmount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600755A")]
		[Cpp2IlInjected.Address(RVA = "0x1E32F00", Offset = "0x1E31900", VA = "0x181E32F00")]
		static ActionMoveMissionObjective()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
