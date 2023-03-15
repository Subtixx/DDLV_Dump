using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DF4")]
	public sealed class MissionObjectivesIdentifier : IMessage<MissionObjectivesIdentifier>, IMessage, IEquatable<MissionObjectivesIdentifier>, IDeepCloneable<MissionObjectivesIdentifier>, IMessageFieldAccessor, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x400388D")]
		private static readonly MessageParser<MissionObjectivesIdentifier> _parser = (MessageParser<MissionObjectivesIdentifier>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionObjectivesIdentifier()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400388E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400388F")]
		public const int StepIndexFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003890")]
		private int stepIndex_;

		[Cpp2IlInjected.Token(Token = "0x4003891")]
		public const int SubStepIndexFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003892")]
		private int subStepIndex_;

		[Cpp2IlInjected.Token(Token = "0x4003893")]
		public const int ObjectiveIndexFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003894")]
		private int objectiveIndex_;

		[Cpp2IlInjected.Token(Token = "0x4003895")]
		public const int PrevAmountFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003896")]
		private int prevAmount_;

		[Cpp2IlInjected.Token(Token = "0x4003897")]
		public const int TargetedItemIDFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003898")]
		private int targetedItemID_;

		[Cpp2IlInjected.Token(Token = "0x17001435")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionObjectivesIdentifier> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60074B1")]
			[Cpp2IlInjected.Address(RVA = "0x1A54870", Offset = "0x1A53270", VA = "0x181A54870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001436")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60074B2")]
			[Cpp2IlInjected.Address(RVA = "0x1A547A0", Offset = "0x1A531A0", VA = "0x181A547A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001437")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60074B3")]
			[Cpp2IlInjected.Address(RVA = "0x1A54930", Offset = "0x1A53330", VA = "0x181A54930", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001438")]
		[DebuggerNonUserCode]
		public int StepIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60074B7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return stepIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074B8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				stepIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001439")]
		[DebuggerNonUserCode]
		public int SubStepIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60074B9")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return subStepIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074BA")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				subStepIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143A")]
		[DebuggerNonUserCode]
		public int ObjectiveIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60074BB")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return objectiveIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074BC")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				objectiveIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143B")]
		[DebuggerNonUserCode]
		public int PrevAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60074BD")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return prevAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074BE")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				prevAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143C")]
		[DebuggerNonUserCode]
		public int TargetedItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60074BF")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return targetedItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074C0")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				targetedItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143D")]
		public Item TargetedItem
		{
			[Cpp2IlInjected.Token(Token = "0x60074CC")]
			[Cpp2IlInjected.Address(RVA = "0x1A548D0", Offset = "0x1A532D0", VA = "0x181A548D0")]
			get
			{
				long num = Convert.ToInt64((uint)targetedItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074B4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MissionObjectivesIdentifier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60074B5")]
		[Cpp2IlInjected.Address(RVA = "0x1A54730", Offset = "0x1A53130", VA = "0x181A54730")]
		[DebuggerNonUserCode]
		public MissionObjectivesIdentifier(MissionObjectivesIdentifier other)
		{
			int num = (stepIndex_ = other.stepIndex_);
			int num2 = (subStepIndex_ = other.subStepIndex_);
			int num3 = (objectiveIndex_ = other.objectiveIndex_);
			int num4 = (prevAmount_ = other.prevAmount_);
			int num5 = (targetedItemID_ = other.targetedItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60074B6")]
		[Cpp2IlInjected.Address(RVA = "0x1A53AC0", Offset = "0x1A524C0", VA = "0x181A53AC0", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionObjectivesIdentifier Clone()
		{
			//Discarded unreachable code: IL_0067
			MissionObjectivesIdentifier missionObjectivesIdentifier = new MissionObjectivesIdentifier();
			int num = (missionObjectivesIdentifier.stepIndex_ = stepIndex_);
			int num2 = (missionObjectivesIdentifier.subStepIndex_ = subStepIndex_);
			int num3 = (missionObjectivesIdentifier.objectiveIndex_ = objectiveIndex_);
			int num4 = (missionObjectivesIdentifier.prevAmount_ = prevAmount_);
			int num5 = (missionObjectivesIdentifier.targetedItemID_ = targetedItemID_);
			UnknownFieldSet unknownFieldSet = (missionObjectivesIdentifier._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionObjectivesIdentifier;
		}

		[Cpp2IlInjected.Token(Token = "0x60074C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A53BC0", Offset = "0x1A525C0", VA = "0x181A53BC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)stepIndex_ == (IntPtr)typeof(MissionObjectivesIdentifier).TypeHandle && (IntPtr)subStepIndex_ == (IntPtr)typeof(MissionObjectivesIdentifier).TypeHandle && (IntPtr)objectiveIndex_ == (IntPtr)typeof(MissionObjectivesIdentifier).TypeHandle && (IntPtr)prevAmount_ == (IntPtr)typeof(MissionObjectivesIdentifier).TypeHandle && (IntPtr)targetedItemID_ == (IntPtr)typeof(MissionObjectivesIdentifier).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60074C2")]
		[Cpp2IlInjected.Address(RVA = "0x1A53B70", Offset = "0x1A52570", VA = "0x181A53B70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionObjectivesIdentifier other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.stepIndex_;
				if (stepIndex_ == num)
				{
					int num2 = other.subStepIndex_;
					if (subStepIndex_ == num2)
					{
						int num3 = other.objectiveIndex_;
						if (objectiveIndex_ == num3)
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
			int num6 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60074C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A53D50", Offset = "0x1A52750", VA = "0x181A53D50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (stepIndex_ != 0)
				{
				}
				if (subStepIndex_ != 0)
				{
				}
				if (objectiveIndex_ != 0)
				{
				}
				if (prevAmount_ != 0)
				{
				}
				if (targetedItemID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60074C4")]
		[Cpp2IlInjected.Address(RVA = "0x1A544C0", Offset = "0x1A52EC0", VA = "0x181A544C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60074C5")]
		[Cpp2IlInjected.Address(RVA = "0x1A54520", Offset = "0x1A52F20", VA = "0x181A54520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008b
			if (stepIndex_ != 0)
			{
				int value = stepIndex_;
				output.WriteInt32(value);
			}
			if (subStepIndex_ != 0)
			{
				int value2 = subStepIndex_;
				output.WriteInt32(value2);
			}
			if (objectiveIndex_ != 0)
			{
				int value3 = objectiveIndex_;
				output.WriteInt32(value3);
			}
			if (prevAmount_ != 0)
			{
				int value4 = prevAmount_;
				output.WriteInt32(value4);
			}
			if (targetedItemID_ != 0)
			{
				int value5 = targetedItemID_;
				output.WriteInt32(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60074C6")]
		[Cpp2IlInjected.Address(RVA = "0x1A53910", Offset = "0x1A52310", VA = "0x181A53910", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = stepIndex_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = subStepIndex_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = objectiveIndex_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				int num8 = prevAmount_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num2 += num9;
				}
				int num10 = targetedItemID_;
				if (num10 != 0)
				{
					int num11 = CodedOutputStream.ComputeInt32Size(num10);
					num11++;
					num2 += num11;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num12 = unknownFields.CalculateSize();
			return num12 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60074C7")]
		[Cpp2IlInjected.Address(RVA = "0x1A53E20", Offset = "0x1A52820", VA = "0x181A53E20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionObjectivesIdentifier other)
		{
			if (other != null)
			{
				int num = other.stepIndex_;
				if (num != 0)
				{
					stepIndex_ = num;
				}
				int num2 = other.subStepIndex_;
				if (num2 != 0)
				{
					subStepIndex_ = num2;
				}
				int num3 = other.objectiveIndex_;
				if (num3 != 0)
				{
					objectiveIndex_ = num3;
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

		[Cpp2IlInjected.Token(Token = "0x60074C8")]
		[Cpp2IlInjected.Address(RVA = "0x1A53EA0", Offset = "0x1A528A0", VA = "0x181A53EA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (objectiveIndex_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (prevAmount_ = input.ReadInt32());
				}
				if (num3 != 40)
				{
					goto IL_007b;
				}
				int num4 = (targetedItemID_ = input.ReadInt32());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (stepIndex_ = input.ReadInt32());
			}
			if (num5 == 16)
			{
				int num6 = (subStepIndex_ = input.ReadInt32());
			}
			goto IL_007b;
			IL_007b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60074C9")]
		[Cpp2IlInjected.Address(RVA = "0x1A53C70", Offset = "0x1A52670", VA = "0x181A53C70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 0 || num == 0 || num == 1)
			{
				int num2 = stepIndex_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60074CA")]
		[Cpp2IlInjected.Address(RVA = "0x1A54310", Offset = "0x1A52D10", VA = "0x181A54310", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0042
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							targetedItemID_ = (int)obj2;
							break;
						}
						case 0:
						{
							object obj = default(object);
							prevAmount_ = (int)obj;
							break;
						}
						}
					}
					else
					{
						object obj3 = default(object);
						objectiveIndex_ = (int)obj3;
					}
				}
				else
				{
					object obj4 = default(object);
					subStepIndex_ = (int)obj4;
				}
			}
			else
			{
				object obj5 = default(object);
				stepIndex_ = (int)obj5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074CB")]
		[Cpp2IlInjected.Address(RVA = "0x1A53A70", Offset = "0x1A52470", VA = "0x181A53A70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022, IL_002c
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				targetedItemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074CD")]
		[Cpp2IlInjected.Address(RVA = "0x1A53B60", Offset = "0x1A52560", VA = "0x181A53B60", Slot = "14")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_0010: Expected I4, but got I8
			prevAmount_ = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60074CE")]
		[Cpp2IlInjected.Address(RVA = "0x1A53F80", Offset = "0x1A52980", VA = "0x181A53F80")]
		public string ObjectiveValidation(MissionObjective obj)
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
					if (_003C_003Ec._003C_003E9__51_0 == null)
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

		[Cpp2IlInjected.Token(Token = "0x60074CF")]
		[Cpp2IlInjected.Address(RVA = "0x1A54620", Offset = "0x1A53020", VA = "0x181A54620")]
		static MissionObjectivesIdentifier()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
