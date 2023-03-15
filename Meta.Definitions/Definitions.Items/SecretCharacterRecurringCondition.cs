using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000316")]
	public sealed class SecretCharacterRecurringCondition : IMessage<SecretCharacterRecurringCondition>, IMessage, IEquatable<SecretCharacterRecurringCondition>, IDeepCloneable<SecretCharacterRecurringCondition>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000317")]
		public enum ConditionOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000FAF")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000FB0")]
			VegetablesHarvested = 10,
			[Cpp2IlInjected.Token(Token = "0x4000FB1")]
			FruitsHarvested = 11,
			[Cpp2IlInjected.Token(Token = "0x4000FB2")]
			FishesFished = 12,
			[Cpp2IlInjected.Token(Token = "0x4000FB3")]
			MealsCooked = 13,
			[Cpp2IlInjected.Token(Token = "0x4000FB4")]
			TimeSinceLastVisit = 14
		}

		[Cpp2IlInjected.Token(Token = "0x4000F9F")]
		private static readonly MessageParser<SecretCharacterRecurringCondition> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000FA0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000FA1")]
		public const int RequiredFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000FA2")]
		private bool required_;

		[Cpp2IlInjected.Token(Token = "0x4000FA3")]
		public const int AdjustProbabilityFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000FA4")]
		private bool adjustProbability_;

		[Cpp2IlInjected.Token(Token = "0x4000FA5")]
		public const int ProbabilityToAddFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000FA6")]
		private int probabilityToAdd_;

		[Cpp2IlInjected.Token(Token = "0x4000FA7")]
		public const int VegetablesHarvestedFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000FA8")]
		public const int FruitsHarvestedFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000FA9")]
		public const int FishesFishedFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4000FAA")]
		public const int MealsCookedFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4000FAB")]
		public const int TimeSinceLastVisitFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000FAC")]
		private object condition_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000FAD")]
		private ConditionOneofCase conditionCase_;

		[Cpp2IlInjected.Token(Token = "0x170008C6")]
		[DebuggerNonUserCode]
		public static MessageParser<SecretCharacterRecurringCondition> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60023C6")]
			[Cpp2IlInjected.Address(RVA = "0x3843630", Offset = "0x3842030", VA = "0x183843630")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60023C7")]
			[Cpp2IlInjected.Address(RVA = "0x3843410", Offset = "0x3841E10", VA = "0x183843410")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60023C8")]
			[Cpp2IlInjected.Address(RVA = "0x3843760", Offset = "0x3842160", VA = "0x183843760", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C9")]
		[DebuggerNonUserCode]
		public bool Required
		{
			[Cpp2IlInjected.Token(Token = "0x60023CC")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return required_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023CD")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				required_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CA")]
		[DebuggerNonUserCode]
		public bool AdjustProbability
		{
			[Cpp2IlInjected.Token(Token = "0x60023CE")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return adjustProbability_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023CF")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set
			{
				adjustProbability_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CB")]
		[DebuggerNonUserCode]
		public int ProbabilityToAdd
		{
			[Cpp2IlInjected.Token(Token = "0x60023D0")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return probabilityToAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023D1")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				probabilityToAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CC")]
		[DebuggerNonUserCode]
		public int VegetablesHarvested
		{
			[Cpp2IlInjected.Token(Token = "0x60023D2")]
			[Cpp2IlInjected.Address(RVA = "0x38436F0", Offset = "0x38420F0", VA = "0x1838436F0")]
			get
			{
				//Discarded unreachable code: IL_0013
				if (conditionCase_ == ConditionOneofCase.VegetablesHarvested)
				{
					object obj = condition_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60023D3")]
			[Cpp2IlInjected.Address(RVA = "0x38439C0", Offset = "0x38423C0", VA = "0x1838439C0")]
			set
			{
				//IL_0015: Expected I4, but got I8
				condition_ = typeof(int).TypeHandle;
				conditionCase_ = ConditionOneofCase.VegetablesHarvested;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CD")]
		[DebuggerNonUserCode]
		public int FruitsHarvested
		{
			[Cpp2IlInjected.Token(Token = "0x60023D4")]
			[Cpp2IlInjected.Address(RVA = "0x3843550", Offset = "0x3841F50", VA = "0x183843550")]
			get
			{
				//Discarded unreachable code: IL_0013
				if (conditionCase_ == ConditionOneofCase.FruitsHarvested)
				{
					object obj = condition_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60023D5")]
			[Cpp2IlInjected.Address(RVA = "0x38438E0", Offset = "0x38422E0", VA = "0x1838438E0")]
			set
			{
				//IL_0015: Expected I4, but got I8
				condition_ = typeof(int).TypeHandle;
				conditionCase_ = ConditionOneofCase.FruitsHarvested;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CE")]
		[DebuggerNonUserCode]
		public int FishesFished
		{
			[Cpp2IlInjected.Token(Token = "0x60023D6")]
			[Cpp2IlInjected.Address(RVA = "0x38434E0", Offset = "0x3841EE0", VA = "0x1838434E0")]
			get
			{
				//Discarded unreachable code: IL_0013
				if (conditionCase_ == ConditionOneofCase.FishesFished)
				{
					object obj = condition_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60023D7")]
			[Cpp2IlInjected.Address(RVA = "0x3843870", Offset = "0x3842270", VA = "0x183843870")]
			set
			{
				//IL_0015: Expected I4, but got I8
				condition_ = typeof(int).TypeHandle;
				conditionCase_ = ConditionOneofCase.FishesFished;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CF")]
		[DebuggerNonUserCode]
		public int MealsCooked
		{
			[Cpp2IlInjected.Token(Token = "0x60023D8")]
			[Cpp2IlInjected.Address(RVA = "0x38435C0", Offset = "0x3841FC0", VA = "0x1838435C0")]
			get
			{
				//Discarded unreachable code: IL_0013
				if (conditionCase_ == ConditionOneofCase.MealsCooked)
				{
					object obj = condition_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60023D9")]
			[Cpp2IlInjected.Address(RVA = "0x3843950", Offset = "0x3842350", VA = "0x183843950")]
			set
			{
				//IL_0015: Expected I4, but got I8
				condition_ = typeof(int).TypeHandle;
				conditionCase_ = ConditionOneofCase.MealsCooked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D0")]
		[DebuggerNonUserCode]
		public Duration TimeSinceLastVisit
		{
			[Cpp2IlInjected.Token(Token = "0x60023DA")]
			[Cpp2IlInjected.Address(RVA = "0x3843690", Offset = "0x3842090", VA = "0x183843690")]
			get
			{
				int num = 0;
				if (conditionCase_ == ConditionOneofCase.TimeSinceLastVisit)
				{
					object obj = condition_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60023DB")]
			[Cpp2IlInjected.Address(RVA = "0x36A60A0", Offset = "0x36A4AA0", VA = "0x1836A60A0")]
			set
			{
				condition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D1")]
		[DebuggerNonUserCode]
		public ConditionOneofCase ConditionCase
		{
			[Cpp2IlInjected.Token(Token = "0x60023DC")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return conditionCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023C9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SecretCharacterRecurringCondition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60023CA")]
		[Cpp2IlInjected.Address(RVA = "0x38432E0", Offset = "0x3841CE0", VA = "0x1838432E0")]
		[DebuggerNonUserCode]
		public SecretCharacterRecurringCondition(SecretCharacterRecurringCondition other)
		{
			//IL_0068: Expected I4, but got O
			bool flag = (required_ = other.required_);
			bool flag2 = (adjustProbability_ = other.adjustProbability_);
			int num = (probabilityToAdd_ = other.probabilityToAdd_);
			ConditionOneofCase conditionOneofCase = other.conditionCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (other != null)
						{
							if (conditionOneofCase != (ConditionOneofCase)1)
							{
								goto IL_00a8;
							}
							conditionCase_ = (ConditionOneofCase)(condition_ = other.TimeSinceLastVisit.Clone());
						}
						int num2 = (MealsCooked = other.MealsCooked);
					}
					int num3 = (FishesFished = other.FishesFished);
				}
				int num4 = (FruitsHarvested = other.FruitsHarvested);
			}
			int num5 = (VegetablesHarvested = other.VegetablesHarvested);
			goto IL_00a8;
			IL_00a8:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023CB")]
		[Cpp2IlInjected.Address(RVA = "0x3841EC0", Offset = "0x38408C0", VA = "0x183841EC0", Slot = "10")]
		[DebuggerNonUserCode]
		public SecretCharacterRecurringCondition Clone()
		{
			//Discarded unreachable code: IL_00c1
			//IL_006a: Expected I4, but got O
			SecretCharacterRecurringCondition secretCharacterRecurringCondition = new SecretCharacterRecurringCondition();
			bool flag = (secretCharacterRecurringCondition.required_ = required_);
			bool flag2 = (secretCharacterRecurringCondition.adjustProbability_ = adjustProbability_);
			int num = (secretCharacterRecurringCondition.probabilityToAdd_ = probabilityToAdd_);
			ConditionOneofCase conditionOneofCase = conditionCase_;
			if (this != null)
			{
				if (this != null)
				{
					if (this != null)
					{
						if (this != null)
						{
							if (conditionOneofCase != (ConditionOneofCase)1)
							{
								goto IL_00aa;
							}
							secretCharacterRecurringCondition.conditionCase_ = (ConditionOneofCase)(secretCharacterRecurringCondition.condition_ = TimeSinceLastVisit.Clone());
						}
						int num2 = (secretCharacterRecurringCondition.MealsCooked = MealsCooked);
					}
					int num3 = (secretCharacterRecurringCondition.FishesFished = FishesFished);
				}
				int num4 = (secretCharacterRecurringCondition.FruitsHarvested = FruitsHarvested);
			}
			int num5 = (secretCharacterRecurringCondition.VegetablesHarvested = VegetablesHarvested);
			goto IL_00aa;
			IL_00aa:
			UnknownFieldSet unknownFieldSet = (secretCharacterRecurringCondition._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return secretCharacterRecurringCondition;
		}

		[Cpp2IlInjected.Token(Token = "0x60023DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearCondition()
		{
			//IL_0010: Expected O, but got I4
			condition_ = (conditionCase_ = ConditionOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023DE")]
		[Cpp2IlInjected.Address(RVA = "0x3842090", Offset = "0x3840A90", VA = "0x183842090", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(required_ ? 1 : 0) == (IntPtr)typeof(SecretCharacterRecurringCondition).TypeHandle && (IntPtr)(adjustProbability_ ? 1 : 0) == (IntPtr)typeof(SecretCharacterRecurringCondition).TypeHandle && (IntPtr)probabilityToAdd_ == (IntPtr)typeof(SecretCharacterRecurringCondition).TypeHandle)
				{
					int vegetablesHarvested = VegetablesHarvested;
					int num = default(int);
					if (vegetablesHarvested == num)
					{
						vegetablesHarvested = FruitsHarvested;
						int num2 = default(int);
						if (vegetablesHarvested == num2)
						{
							vegetablesHarvested = FishesFished;
							int num3 = default(int);
							if (vegetablesHarvested == num3)
							{
								vegetablesHarvested = MealsCooked;
								int num4 = default(int);
								if (vegetablesHarvested == num4)
								{
									Duration objB = default(Duration);
									bool flag = object.Equals(TimeSinceLastVisit, objB);
									if (flag && conditionCase_ == (flag ? ((ConditionOneofCase)1) : ConditionOneofCase.None))
									{
										return object.Equals(_unknownFields, objB);
									}
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023DF")]
		[Cpp2IlInjected.Address(RVA = "0x3842200", Offset = "0x3840C00", VA = "0x183842200", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SecretCharacterRecurringCondition other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.required_;
				if (required_ == flag)
				{
					bool flag2 = other.adjustProbability_;
					if (adjustProbability_ == flag2)
					{
						int num = other.probabilityToAdd_;
						if (probabilityToAdd_ == num)
						{
							int vegetablesHarvested = VegetablesHarvested;
							int vegetablesHarvested2 = other.VegetablesHarvested;
							if (vegetablesHarvested == vegetablesHarvested2)
							{
								vegetablesHarvested = FruitsHarvested;
								int fruitsHarvested = other.FruitsHarvested;
								if (vegetablesHarvested == fruitsHarvested)
								{
									vegetablesHarvested = FishesFished;
									int fishesFished = other.FishesFished;
									if (vegetablesHarvested == fishesFished)
									{
										vegetablesHarvested = MealsCooked;
										int mealsCooked = other.MealsCooked;
										if (vegetablesHarvested == mealsCooked)
										{
											Duration timeSinceLastVisit = TimeSinceLastVisit;
											Duration timeSinceLastVisit2 = other.TimeSinceLastVisit;
											if (object.Equals(timeSinceLastVisit, timeSinceLastVisit2))
											{
												ConditionOneofCase conditionOneofCase = other.conditionCase_;
												if (conditionCase_ == conditionOneofCase)
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
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023E0")]
		[Cpp2IlInjected.Address(RVA = "0x3842530", Offset = "0x3840F30", VA = "0x183842530", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c7
			bool flag = required_;
			int num = 0;
			if (flag)
			{
			}
			if (adjustProbability_)
			{
			}
			if (probabilityToAdd_ != 0)
			{
			}
			if (conditionCase_ == ConditionOneofCase.VegetablesHarvested)
			{
				if (conditionCase_ != ConditionOneofCase.VegetablesHarvested)
				{
				}
				object obj = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.FruitsHarvested)
			{
				if (conditionCase_ != ConditionOneofCase.FruitsHarvested)
				{
				}
				object obj2 = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.FishesFished)
			{
				if (conditionCase_ != ConditionOneofCase.FishesFished)
				{
				}
				object obj3 = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.MealsCooked)
			{
				if (conditionCase_ != ConditionOneofCase.MealsCooked)
				{
				}
				object obj4 = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.TimeSinceLastVisit)
			{
				object obj5 = condition_;
				if (obj5 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj5.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60023E1")]
		[Cpp2IlInjected.Address(RVA = "0x3842F70", Offset = "0x3841970", VA = "0x183842F70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60023E2")]
		[Cpp2IlInjected.Address(RVA = "0x3842FD0", Offset = "0x38419D0", VA = "0x183842FD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ed
			while (true)
			{
				if (required_)
				{
					bool value = required_;
					output.WriteBool(value);
				}
				if (adjustProbability_)
				{
					bool value2 = adjustProbability_;
					output.WriteBool(value2);
				}
				if (probabilityToAdd_ != 0)
				{
					int value3 = probabilityToAdd_;
					output.WriteInt32(value3);
				}
				if (conditionCase_ != ConditionOneofCase.VegetablesHarvested)
				{
					continue;
				}
				int vegetablesHarvested = VegetablesHarvested;
				output.WriteInt32(vegetablesHarvested);
				if (conditionCase_ != ConditionOneofCase.FruitsHarvested)
				{
					continue;
				}
				int fruitsHarvested = FruitsHarvested;
				output.WriteInt32(fruitsHarvested);
				if (conditionCase_ == ConditionOneofCase.FishesFished)
				{
					int fishesFished = FishesFished;
					output.WriteInt32(fishesFished);
					if (conditionCase_ == ConditionOneofCase.MealsCooked)
					{
						break;
					}
				}
			}
			int mealsCooked = MealsCooked;
			output.WriteInt32(mealsCooked);
			if (conditionCase_ == ConditionOneofCase.TimeSinceLastVisit && conditionCase_ == ConditionOneofCase.TimeSinceLastVisit)
			{
				object obj = condition_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60023E3")]
		[Cpp2IlInjected.Address(RVA = "0x3841A10", Offset = "0x3840410", VA = "0x183841A10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = probabilityToAdd_;
			if (num != 0)
			{
				int num2 = CodedOutputStream.ComputeInt32Size(num);
				num2++;
			}
			int num3 = 0;
			if (conditionCase_ == ConditionOneofCase.VegetablesHarvested)
			{
				if (conditionCase_ != ConditionOneofCase.VegetablesHarvested)
				{
				}
				object obj = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.FruitsHarvested)
			{
				if (conditionCase_ != ConditionOneofCase.FruitsHarvested)
				{
				}
				object obj2 = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.FishesFished)
			{
				if (conditionCase_ != ConditionOneofCase.FishesFished)
				{
				}
				object obj3 = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.MealsCooked)
			{
				if (conditionCase_ != ConditionOneofCase.MealsCooked)
				{
				}
				object obj4 = condition_;
			}
			if (conditionCase_ == ConditionOneofCase.TimeSinceLastVisit && conditionCase_ == ConditionOneofCase.TimeSinceLastVisit)
			{
				object obj5 = condition_;
				if (obj5 != null && obj5 == null)
				{
					goto IL_00c3;
				}
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
			}
			goto IL_00c3;
			IL_00c3:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023E4")]
		[Cpp2IlInjected.Address(RVA = "0x38428C0", Offset = "0x38412C0", VA = "0x1838428C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SecretCharacterRecurringCondition other)
		{
			//Discarded unreachable code: IL_00f4
			//IL_007b: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			bool flag = other.required_;
			if (flag)
			{
				required_ = flag;
			}
			bool flag2 = other.adjustProbability_;
			if (flag2)
			{
				adjustProbability_ = flag2;
			}
			int num = other.probabilityToAdd_;
			if (num != 0)
			{
				probabilityToAdd_ = num;
			}
			ConditionOneofCase conditionOneofCase = other.conditionCase_;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (conditionOneofCase != (ConditionOneofCase)1)
							{
								goto IL_00d4;
							}
							if (TimeSinceLastVisit == null)
							{
								conditionCase_ = (ConditionOneofCase)(condition_ = new Duration());
							}
							Duration timeSinceLastVisit = TimeSinceLastVisit;
							Duration timeSinceLastVisit2 = other.TimeSinceLastVisit;
							timeSinceLastVisit.MergeFrom(timeSinceLastVisit2);
						}
						int num2 = (MealsCooked = other.MealsCooked);
					}
					int num3 = (FishesFished = other.FishesFished);
				}
				int num4 = (FruitsHarvested = other.FruitsHarvested);
			}
			int num5 = (VegetablesHarvested = other.VegetablesHarvested);
			goto IL_00d4;
			IL_00d4:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60023E5")]
		[Cpp2IlInjected.Address(RVA = "0x3842A50", Offset = "0x3841450", VA = "0x183842A50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0080: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 80)
			{
				if ((int)num > 96)
				{
					if (num == 104)
					{
						int num3 = (MealsCooked = input.ReadInt32());
					}
					if (num != 114)
					{
						goto IL_0108;
					}
					Duration builder = new Duration();
					if (conditionCase_ == ConditionOneofCase.TimeSinceLastVisit)
					{
						if (conditionCase_ != ConditionOneofCase.TimeSinceLastVisit)
						{
						}
						object obj = condition_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					condition_ = builder;
					conditionCase_ = (ConditionOneofCase)typeof(Duration).TypeHandle;
				}
				int num5 = default(int);
				if (num == 88)
				{
					num5 = (FruitsHarvested = input.ReadInt32());
				}
				if (num5 != 96)
				{
					goto IL_0108;
				}
				int num7 = (FishesFished = input.ReadInt32());
			}
			int num10 = default(int);
			if ((int)num > 16)
			{
				int num8 = default(int);
				if (num == 24)
				{
					num8 = (probabilityToAdd_ = input.ReadInt32());
				}
				if (num8 != 80)
				{
					goto IL_0108;
				}
				num10 = (VegetablesHarvested = input.ReadInt32());
			}
			bool flag = default(bool);
			if (num10 == 8)
			{
				flag = (required_ = input.ReadBool());
			}
			if (flag)
			{
				bool flag2 = (adjustProbability_ = input.ReadBool());
			}
			goto IL_0108;
			IL_0108:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60023E6")]
		[Cpp2IlInjected.Address(RVA = "0x3842330", Offset = "0x3840D30", VA = "0x183842330", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 13)
			{
				bool flag = required_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023E7")]
		[Cpp2IlInjected.Address(RVA = "0x3842C80", Offset = "0x3841680", VA = "0x183842C80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 13)
			{
				object obj = default(object);
				required_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023E8")]
		[Cpp2IlInjected.Address(RVA = "0x3841D60", Offset = "0x3840760", VA = "0x183841D60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000d, IL_0015, IL_001f, IL_0029, IL_0033, IL_003d, IL_0047
			//IL_001e: Expected I4, but got I8
			//IL_0050: Expected I4, but got I8
			if (fieldNumber <= 13)
			{
				required_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023E9")]
		[Cpp2IlInjected.Address(RVA = "0x3842810", Offset = "0x3841210", VA = "0x183842810", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Condition"))
			{
				ConditionOneofCase conditionOneofCase = conditionCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023EA")]
		[Cpp2IlInjected.Address(RVA = "0x3841E50", Offset = "0x3840850", VA = "0x183841E50", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Condition"))
			{
				condition_ = (conditionCase_ = ConditionOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023EB")]
		[Cpp2IlInjected.Address(RVA = "0x3842020", Offset = "0x3840A20", VA = "0x183842020", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (conditionCase_ == ConditionOneofCase.None)
			{
				context.AddInvalidMemberError("Cannot be None", "Condition");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023EC")]
		[Cpp2IlInjected.Address(RVA = "0x38431D0", Offset = "0x3841BD0", VA = "0x1838431D0")]
		static SecretCharacterRecurringCondition()
		{
			Func<SecretCharacterRecurringCondition> func = default(Func<SecretCharacterRecurringCondition>);
			_parser = (MessageParser<SecretCharacterRecurringCondition>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
