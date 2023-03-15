using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000372")]
	public sealed class OverrideScheduleData : IMessage<OverrideScheduleData>, IMessage, IEquatable<OverrideScheduleData>, IDeepCloneable<OverrideScheduleData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400116A")]
		private static readonly MessageParser<OverrideScheduleData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400116B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400116C")]
		public const int ScheduleFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400116D")]
		private ScheduleType schedule_;

		[Cpp2IlInjected.Token(Token = "0x400116E")]
		public const int DontMoveFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400116F")]
		private bool dontMove_;

		[Cpp2IlInjected.Token(Token = "0x4001170")]
		public const int ForceRotationFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4001171")]
		private bool forceRotation_;

		[Cpp2IlInjected.Token(Token = "0x4001172")]
		public const int LocationFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001173")]
		private LocationSource location_;

		[Cpp2IlInjected.Token(Token = "0x4001174")]
		public const int ConditionsFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001175")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x170009CD")]
		[DebuggerNonUserCode]
		public static MessageParser<OverrideScheduleData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60027ED")]
			[Cpp2IlInjected.Address(RVA = "0x36A8140", Offset = "0x36A6B40", VA = "0x1836A8140")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009CE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60027EE")]
			[Cpp2IlInjected.Address(RVA = "0x36A8010", Offset = "0x36A6A10", VA = "0x1836A8010")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009CF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60027EF")]
			[Cpp2IlInjected.Address(RVA = "0x36A81A0", Offset = "0x36A6BA0", VA = "0x1836A81A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D0")]
		[DebuggerNonUserCode]
		public ScheduleType Schedule
		{
			[Cpp2IlInjected.Token(Token = "0x60027F4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return schedule_;
			}
			[Cpp2IlInjected.Token(Token = "0x60027F5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				schedule_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D1")]
		[DebuggerNonUserCode]
		public bool DontMove
		{
			[Cpp2IlInjected.Token(Token = "0x60027F6")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return dontMove_;
			}
			[Cpp2IlInjected.Token(Token = "0x60027F7")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				dontMove_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D2")]
		[DebuggerNonUserCode]
		public bool ForceRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60027F8")]
			[Cpp2IlInjected.Address(RVA = "0x63C0F0", Offset = "0x63AAF0", VA = "0x18063C0F0")]
			get
			{
				return forceRotation_;
			}
			[Cpp2IlInjected.Token(Token = "0x60027F9")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C0", Offset = "0x63ACC0", VA = "0x18063C2C0")]
			set
			{
				forceRotation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D3")]
		[DebuggerNonUserCode]
		public LocationSource Location
		{
			[Cpp2IlInjected.Token(Token = "0x60027FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x60027FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D4")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x60027FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x60027FD")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D5")]
		public bool IsFixedPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002809")]
			[Cpp2IlInjected.Address(RVA = "0x36A80E0", Offset = "0x36A6AE0", VA = "0x1836A80E0")]
			get
			{
				//Discarded unreachable code: IL_001b
				if (dontMove_)
				{
					return true;
				}
				return location_.locationCase_ == LocationSource.LocationOneofCase.Custom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009D6")]
		public bool IsForcedRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600280A")]
			[Cpp2IlInjected.Address(RVA = "0x36A8110", Offset = "0x36A6B10", VA = "0x1836A8110")]
			get
			{
				//Discarded unreachable code: IL_001b
				if (!forceRotation_)
				{
					int num = 0;
				}
				return location_.locationCase_ == LocationSource.LocationOneofCase.Custom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027F0")]
		[Cpp2IlInjected.Address(RVA = "0x36A7F70", Offset = "0x36A6970", VA = "0x1836A7F70")]
		[DebuggerNonUserCode]
		public OverrideScheduleData()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			LocationSource locationSource = (location_ = new LocationSource());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60027F1")]
		[Cpp2IlInjected.Address(RVA = "0x36A7950", Offset = "0x36A6350", VA = "0x1836A7950")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			LocationSource locationSource = (location_ = new LocationSource());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60027F2")]
		[Cpp2IlInjected.Address(RVA = "0x36A7E20", Offset = "0x36A6820", VA = "0x1836A7E20")]
		[DebuggerNonUserCode]
		public OverrideScheduleData(OverrideScheduleData other)
		{
			//IL_006d: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			LocationSource locationSource = (location_ = new LocationSource());
			ScheduleType scheduleType = other.schedule_;
			int num = 0;
			schedule_ = scheduleType;
			bool flag = (dontMove_ = other.dontMove_);
			bool flag2 = (forceRotation_ = other.forceRotation_);
			LocationSource locationSource2 = other.location_;
			if (locationSource2 != null)
			{
				LocationSource locationSource3 = locationSource2.Clone();
			}
			location_ = (LocationSource)num;
			ConditionsList conditionsList2 = other.conditions_;
			ConditionsList conditionsList3 = default(ConditionsList);
			if (conditionsList2 != null)
			{
				conditionsList3 = conditionsList2.Clone();
			}
			conditions_ = conditionsList3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027F3")]
		[Cpp2IlInjected.Address(RVA = "0x36A7070", Offset = "0x36A5A70", VA = "0x1836A7070", Slot = "10")]
		[DebuggerNonUserCode]
		public OverrideScheduleData Clone()
		{
			//Discarded unreachable code: IL_00a4
			//IL_006f: Expected O, but got I4
			OverrideScheduleData overrideScheduleData = new OverrideScheduleData();
			ConditionsList conditionsList = (overrideScheduleData.conditions_ = new ConditionsList());
			LocationSource locationSource = (overrideScheduleData.location_ = new LocationSource());
			ScheduleType scheduleType = schedule_;
			int num = 0;
			overrideScheduleData.schedule_ = scheduleType;
			bool flag = (overrideScheduleData.dontMove_ = dontMove_);
			bool flag2 = (overrideScheduleData.forceRotation_ = forceRotation_);
			LocationSource locationSource2 = location_;
			if (locationSource2 != null)
			{
				LocationSource locationSource3 = locationSource2.Clone();
			}
			overrideScheduleData.location_ = (LocationSource)num;
			ConditionsList conditionsList2 = conditions_;
			ConditionsList conditionsList3 = default(ConditionsList);
			if (conditionsList2 != null)
			{
				conditionsList3 = conditionsList2.Clone();
			}
			overrideScheduleData.conditions_ = conditionsList3;
			UnknownFieldSet unknownFieldSet = (overrideScheduleData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return overrideScheduleData;
		}

		[Cpp2IlInjected.Token(Token = "0x60027FE")]
		[Cpp2IlInjected.Address(RVA = "0x36A72F0", Offset = "0x36A5CF0", VA = "0x1836A72F0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)schedule_ == (IntPtr)typeof(OverrideScheduleData).TypeHandle && (IntPtr)(dontMove_ ? 1 : 0) == (IntPtr)typeof(OverrideScheduleData).TypeHandle && (IntPtr)(forceRotation_ ? 1 : 0) == (IntPtr)typeof(OverrideScheduleData).TypeHandle && object.Equals(location_, other) && object.Equals(conditions_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60027FF")]
		[Cpp2IlInjected.Address(RVA = "0x36A73D0", Offset = "0x36A5DD0", VA = "0x1836A73D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OverrideScheduleData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ScheduleType scheduleType = other.schedule_;
				if (schedule_ == scheduleType)
				{
					bool flag = other.dontMove_;
					if (dontMove_ == flag)
					{
						bool flag2 = other.forceRotation_;
						if (forceRotation_ == flag2)
						{
							LocationSource objB = other.location_;
							if (object.Equals(location_, objB))
							{
								ConditionsList objB2 = other.conditions_;
								if (object.Equals(conditions_, objB2))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002800")]
		[Cpp2IlInjected.Address(RVA = "0x36A75A0", Offset = "0x36A5FA0", VA = "0x1836A75A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (schedule_ != 0)
				{
				}
				if (dontMove_)
				{
				}
				if (forceRotation_)
				{
				}
				LocationSource locationSource = location_;
				if (locationSource != null)
				{
					int hashCode = locationSource.GetHashCode();
				}
				ConditionsList conditionsList = conditions_;
				if (conditionsList != null)
				{
					int hashCode2 = conditionsList.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6002801")]
		[Cpp2IlInjected.Address(RVA = "0x36A7BA0", Offset = "0x36A65A0", VA = "0x1836A7BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002802")]
		[Cpp2IlInjected.Address(RVA = "0x36A7C00", Offset = "0x36A6600", VA = "0x1836A7C00", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007f
			if (schedule_ != 0)
			{
			}
			if (dontMove_)
			{
				bool value = dontMove_;
				output.WriteBool(value);
			}
			if (forceRotation_)
			{
				bool value2 = forceRotation_;
				output.WriteBool(value2);
			}
			if ((long)location_ != 0)
			{
				LocationSource value3 = location_;
				output.WriteMessage(value3);
			}
			if ((long)conditions_ != 0)
			{
				ConditionsList value4 = conditions_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002803")]
		[Cpp2IlInjected.Address(RVA = "0x36A6F00", Offset = "0x36A5900", VA = "0x1836A6F00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ScheduleType scheduleType = schedule_;
				num = 0;
				if (scheduleType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)scheduleType);
					num2++;
				}
				LocationSource locationSource = location_;
				if (locationSource != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(locationSource);
					num3++;
					num += num3;
				}
				ConditionsList conditionsList = conditions_;
				if (conditionsList != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(conditionsList);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002804")]
		[Cpp2IlInjected.Address(RVA = "0x36A7680", Offset = "0x36A6080", VA = "0x1836A7680", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OverrideScheduleData other)
		{
			//Discarded unreachable code: IL_00d3
			if (other == null)
			{
				return;
			}
			ScheduleType scheduleType = other.schedule_;
			if (scheduleType != 0)
			{
				schedule_ = scheduleType;
			}
			bool flag = other.dontMove_;
			if (flag)
			{
				dontMove_ = flag;
			}
			bool flag2 = other.forceRotation_;
			if (flag2)
			{
				forceRotation_ = flag2;
			}
			if ((long)other.location_ != 0)
			{
				LocationSource locationSource2 = default(LocationSource);
				if (location_ == null)
				{
					LocationSource locationSource = (location_ = new LocationSource());
					locationSource2 = location_;
				}
				LocationSource other2 = other.location_;
				locationSource2.MergeFrom(other2);
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					conditionsList2 = conditions_;
				}
				ConditionsList other3 = other.conditions_;
				conditionsList2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002805")]
		[Cpp2IlInjected.Address(RVA = "0x36A77D0", Offset = "0x36A61D0", VA = "0x1836A77D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					bool flag = (forceRotation_ = input.ReadBool());
				}
				LocationSource locationSource = default(LocationSource);
				if (num == 34)
				{
					LocationSource builder = default(LocationSource);
					if (location_ == null)
					{
						locationSource = (location_ = new LocationSource());
						builder = location_;
					}
					input.ReadMessage(builder);
				}
				if ((long)locationSource != 42)
				{
					goto IL_00ad;
				}
				ConditionsList builder2 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					builder2 = conditions_;
				}
				input.ReadMessage(builder2);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(schedule_ = (ScheduleType)input.ReadInt32());
			}
			if (num2 == 16)
			{
				bool flag2 = (dontMove_ = input.ReadBool());
			}
			goto IL_00ad;
			IL_00ad:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002806")]
		[Cpp2IlInjected.Address(RVA = "0x36A7460", Offset = "0x36A5E60", VA = "0x1836A7460", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							ConditionsList conditionsList = conditions_;
						}
						LocationSource locationSource = location_;
					}
					bool flag = forceRotation_;
				}
				bool flag2 = dontMove_;
			}
			ScheduleType scheduleType = schedule_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002807")]
		[Cpp2IlInjected.Address(RVA = "0x36A79E0", Offset = "0x36A63E0", VA = "0x1836A79E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_004b
			//IL_0029: Expected O, but got I4
			//IL_0039: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			//IL_004a: Expected I4, but got O
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
							int num2 = 0;
							if (value == null || value != null)
							{
								conditions_ = (ConditionsList)num2;
								return;
							}
							throw new InvalidCastException();
						}
						default:
							return;
						case 0:
							break;
						}
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
					}
					object obj = default(object);
					forceRotation_ = (byte)(int)obj != 0;
				}
				else
				{
					object obj2 = default(object);
					dontMove_ = (byte)(int)obj2 != 0;
				}
			}
			else
			{
				object obj3 = default(object);
				schedule_ = (ScheduleType)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002808")]
		[Cpp2IlInjected.Address(RVA = "0x36A7020", Offset = "0x36A5A20", VA = "0x1836A7020", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0005
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600280B")]
		[Cpp2IlInjected.Address(RVA = "0x36A71F0", Offset = "0x36A5BF0", VA = "0x1836A71F0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_005f
			if (schedule_ == ScheduleType.SpecificLocation)
			{
				LocationSource locationSource = location_;
				LocationSource.LocationOneofCase locationCase_ = locationSource.locationCase_;
				if ((long)locationSource <= 1 || locationCase_ == LocationSource.LocationOneofCase.Realm)
				{
					string error = $"OverrideSchedule.SpecificLocation don't support {locationSource}";
					context.AddError(error);
				}
				if (forceRotation_ && location_.locationCase_ != LocationSource.LocationOneofCase.Custom)
				{
					context.AddInvalidMemberError("Can be enable only with Custom location", "ForceRotation");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600280C")]
		[Cpp2IlInjected.Address(RVA = "0x36A7D10", Offset = "0x36A6710", VA = "0x1836A7D10")]
		static OverrideScheduleData()
		{
			Func<OverrideScheduleData> func = default(Func<OverrideScheduleData>);
			_parser = (MessageParser<OverrideScheduleData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
