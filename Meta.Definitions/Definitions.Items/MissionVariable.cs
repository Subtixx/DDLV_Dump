using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000530")]
	public sealed class MissionVariable : IMessage<MissionVariable>, IMessage, IEquatable<MissionVariable>, IDeepCloneable<MissionVariable>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000531")]
		public enum VariableOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001C19")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001C1A")]
			ItemFilter = 2,
			[Cpp2IlInjected.Token(Token = "0x4001C1B")]
			TargetAmount = 4,
			[Cpp2IlInjected.Token(Token = "0x4001C1C")]
			MinWeightRequired = 5,
			[Cpp2IlInjected.Token(Token = "0x4001C1D")]
			MaxWeightRequired = 6,
			[Cpp2IlInjected.Token(Token = "0x4001C1E")]
			MinStarRating = 7
		}

		[Cpp2IlInjected.Token(Token = "0x4001C0D")]
		private static readonly MessageParser<MissionVariable> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001C0E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001C0F")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C10")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001C11")]
		public const int ItemFilterFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001C12")]
		public const int TargetAmountFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001C13")]
		public const int MinWeightRequiredFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001C14")]
		public const int MaxWeightRequiredFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001C15")]
		public const int MinStarRatingFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C16")]
		private object variable_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C17")]
		private VariableOneofCase variableCase_;

		[Cpp2IlInjected.Token(Token = "0x170010B3")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionVariable> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60040A2")]
			[Cpp2IlInjected.Address(RVA = "0x29F0800", Offset = "0x29EF200", VA = "0x1829F0800")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60040A3")]
			[Cpp2IlInjected.Address(RVA = "0x29F0580", Offset = "0x29EEF80", VA = "0x1829F0580")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60040A4")]
			[Cpp2IlInjected.Address(RVA = "0x29F08D0", Offset = "0x29EF2D0", VA = "0x1829F08D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B6")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60040A8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040A9")]
			[Cpp2IlInjected.Address(RVA = "0x29F0B30", Offset = "0x29EF530", VA = "0x1829F0B30")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B7")]
		[DebuggerNonUserCode]
		public ItemFilterData ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60040AA")]
			[Cpp2IlInjected.Address(RVA = "0x29F0650", Offset = "0x29EF050", VA = "0x1829F0650")]
			get
			{
				int num = 0;
				if (variableCase_ == VariableOneofCase.ItemFilter)
				{
					object obj = variable_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FE160", Offset = "0x7FCB60", VA = "0x1807FE160")]
			set
			{
				variable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B8")]
		[DebuggerNonUserCode]
		public float TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60040AC")]
			[Cpp2IlInjected.Address(RVA = "0x29F0860", Offset = "0x29EF260", VA = "0x1829F0860")]
			get
			{
				if (variableCase_ == VariableOneofCase.TargetAmount)
				{
					object obj = variable_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040AD")]
			[Cpp2IlInjected.Address(RVA = "0x29F0BA0", Offset = "0x29EF5A0", VA = "0x1829F0BA0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				variable_ = typeof(float).TypeHandle;
				variableCase_ = VariableOneofCase.TargetAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B9")]
		[DebuggerNonUserCode]
		public float MinWeightRequired
		{
			[Cpp2IlInjected.Token(Token = "0x60040AE")]
			[Cpp2IlInjected.Address(RVA = "0x29F0790", Offset = "0x29EF190", VA = "0x1829F0790")]
			get
			{
				if (variableCase_ == VariableOneofCase.MinWeightRequired)
				{
					object obj = variable_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040AF")]
			[Cpp2IlInjected.Address(RVA = "0x29F0AC0", Offset = "0x29EF4C0", VA = "0x1829F0AC0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				variable_ = typeof(float).TypeHandle;
				variableCase_ = VariableOneofCase.MinWeightRequired;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010BA")]
		[DebuggerNonUserCode]
		public float MaxWeightRequired
		{
			[Cpp2IlInjected.Token(Token = "0x60040B0")]
			[Cpp2IlInjected.Address(RVA = "0x29F06B0", Offset = "0x29EF0B0", VA = "0x1829F06B0")]
			get
			{
				if (variableCase_ == VariableOneofCase.MaxWeightRequired)
				{
					object obj = variable_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040B1")]
			[Cpp2IlInjected.Address(RVA = "0x29F09E0", Offset = "0x29EF3E0", VA = "0x1829F09E0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				variable_ = typeof(float).TypeHandle;
				variableCase_ = VariableOneofCase.MaxWeightRequired;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010BB")]
		[DebuggerNonUserCode]
		public float MinStarRating
		{
			[Cpp2IlInjected.Token(Token = "0x60040B2")]
			[Cpp2IlInjected.Address(RVA = "0x29F0720", Offset = "0x29EF120", VA = "0x1829F0720")]
			get
			{
				if (variableCase_ == VariableOneofCase.MinStarRating)
				{
					object obj = variable_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040B3")]
			[Cpp2IlInjected.Address(RVA = "0x29F0A50", Offset = "0x29EF450", VA = "0x1829F0A50")]
			set
			{
				//IL_0014: Expected I4, but got I8
				variable_ = typeof(float).TypeHandle;
				variableCase_ = VariableOneofCase.MinStarRating;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010BC")]
		[DebuggerNonUserCode]
		public VariableOneofCase VariableCase
		{
			[Cpp2IlInjected.Token(Token = "0x60040B4")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return variableCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60040A5")]
		[Cpp2IlInjected.Address(RVA = "0x29F0530", Offset = "0x29EEF30", VA = "0x1829F0530")]
		[DebuggerNonUserCode]
		public MissionVariable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60040A6")]
		[Cpp2IlInjected.Address(RVA = "0x29F03B0", Offset = "0x29EEDB0", VA = "0x1829F03B0")]
		[DebuggerNonUserCode]
		public MissionVariable(MissionVariable other)
		{
			//IL_0042: Expected I4, but got O
			string text = (name_ = other.name_);
			if (other.variableCase_ <= VariableOneofCase.MinWeightRequired)
			{
				variableCase_ = (VariableOneofCase)(variable_ = other.ItemFilter.Clone());
				float num = (TargetAmount = other.TargetAmount);
				num = (MinWeightRequired = other.MinWeightRequired);
				num = (MaxWeightRequired = other.MaxWeightRequired);
				num = (MinStarRating = other.MinStarRating);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60040A7")]
		[Cpp2IlInjected.Address(RVA = "0x29EF070", Offset = "0x29EDA70", VA = "0x1829EF070", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionVariable Clone()
		{
			//Discarded unreachable code: IL_0091
			//IL_0042: Expected I4, but got O
			MissionVariable missionVariable = new MissionVariable();
			missionVariable.name_ = "";
			string text = (missionVariable.name_ = name_);
			if (variableCase_ <= VariableOneofCase.MinWeightRequired)
			{
				missionVariable.variableCase_ = (VariableOneofCase)(missionVariable.variable_ = ItemFilter.Clone());
				float num = (missionVariable.TargetAmount = TargetAmount);
				num = (missionVariable.MinWeightRequired = MinWeightRequired);
				num = (missionVariable.MaxWeightRequired = MaxWeightRequired);
				num = (missionVariable.MinStarRating = MinStarRating);
			}
			UnknownFieldSet unknownFieldSet = (missionVariable._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionVariable;
		}

		[Cpp2IlInjected.Token(Token = "0x60040B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearVariable()
		{
			//IL_0010: Expected O, but got I4
			variable_ = (variableCase_ = VariableOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60040B6")]
		[Cpp2IlInjected.Address(RVA = "0x29EF480", Offset = "0x29EDE80", VA = "0x1829EF480", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((MissionVariable)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60040B7")]
		[Cpp2IlInjected.Address(RVA = "0x29EF220", Offset = "0x29EDC20", VA = "0x1829EF220", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionVariable other)
		{
			if (other != null && other != this)
			{
				string text = other.name_;
				if (!(name_ != text))
				{
					ItemFilterData itemFilter = ItemFilter;
					ItemFilterData itemFilter2 = other.ItemFilter;
					if (object.Equals(itemFilter, itemFilter2))
					{
						float targetAmount = TargetAmount;
						float targetAmount2 = other.TargetAmount;
						targetAmount = MinWeightRequired;
						targetAmount2 = other.MinWeightRequired;
						targetAmount = MaxWeightRequired;
						targetAmount2 = other.MaxWeightRequired;
						targetAmount = MinStarRating;
						targetAmount2 = other.MinStarRating;
						VariableOneofCase variableOneofCase = other.variableCase_;
						if (variableCase_ == variableOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60040B8")]
		[Cpp2IlInjected.Address(RVA = "0x29EF620", Offset = "0x29EE020", VA = "0x1829EF620", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e8
			//IL_0059: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			while (true)
			{
				string text = name_;
				if (text.m_stringLength != 0)
				{
					int hashCode = text.GetHashCode();
				}
				if (variableCase_ != VariableOneofCase.ItemFilter)
				{
					continue;
				}
				object obj = variable_;
				if (obj == null)
				{
					break;
				}
				int hashCode2 = obj.GetHashCode();
				if (variableCase_ != VariableOneofCase.TargetAmount)
				{
					continue;
				}
				int num = 0;
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				float targetAmount = TargetAmount;
				int hashCode3 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)num);
				if (variableCase_ != VariableOneofCase.MinWeightRequired)
				{
					continue;
				}
				int num2 = 0;
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				targetAmount = MinWeightRequired;
				int hashCode4 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField2).GetHashCode((T)num2);
				if (variableCase_ == VariableOneofCase.MaxWeightRequired)
				{
					int num3 = 0;
					EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField3 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
					targetAmount = MaxWeightRequired;
					int hashCode5 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField3).GetHashCode((T)num3);
					if (variableCase_ == VariableOneofCase.MinStarRating)
					{
						int num4 = 0;
						EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField4 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
						targetAmount = MinStarRating;
						int hashCode6 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField4).GetHashCode((T)num4);
					}
					UnknownFieldSet unknownFields = _unknownFields;
					if (unknownFields != null)
					{
						int hashCode7 = unknownFields.GetHashCode();
					}
					return 1;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60040B9")]
		[Cpp2IlInjected.Address(RVA = "0x29F0080", Offset = "0x29EEA80", VA = "0x1829F0080", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60040BA")]
		[Cpp2IlInjected.Address(RVA = "0x29F00E0", Offset = "0x29EEAE0", VA = "0x1829F00E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00af
			while (true)
			{
				if (name_.m_stringLength != 0)
				{
					string value = name_;
					output.WriteString(value);
				}
				if (variableCase_ != VariableOneofCase.ItemFilter)
				{
					continue;
				}
				if (variableCase_ == VariableOneofCase.ItemFilter)
				{
					object obj = variable_;
					if (obj != null && obj == null)
					{
						break;
					}
				}
				if (variableCase_ != VariableOneofCase.TargetAmount)
				{
					continue;
				}
				float targetAmount = TargetAmount;
				output.WriteFloat(targetAmount);
				if (variableCase_ != VariableOneofCase.MinWeightRequired)
				{
					continue;
				}
				targetAmount = MinWeightRequired;
				output.WriteFloat(targetAmount);
				if (variableCase_ == VariableOneofCase.MaxWeightRequired)
				{
					targetAmount = MaxWeightRequired;
					output.WriteFloat(targetAmount);
					if (variableCase_ == VariableOneofCase.MinStarRating)
					{
						targetAmount = MinStarRating;
						output.WriteFloat(targetAmount);
					}
					_unknownFields?.WriteTo(output);
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60040BB")]
		[Cpp2IlInjected.Address(RVA = "0x29EEDA0", Offset = "0x29ED7A0", VA = "0x1829EEDA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0068
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			if (variableCase_ == VariableOneofCase.ItemFilter)
			{
				if (variableCase_ == VariableOneofCase.ItemFilter)
				{
					object obj = variable_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			VariableOneofCase variableOneofCase = variableCase_;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60040BC")]
		[Cpp2IlInjected.Address(RVA = "0x29EFA90", Offset = "0x29EE490", VA = "0x1829EFA90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionVariable other)
		{
			//Discarded unreachable code: IL_00b9
			//IL_0044: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			if (other.variableCase_ <= VariableOneofCase.MinWeightRequired)
			{
				if (ItemFilter == null)
				{
					variableCase_ = (VariableOneofCase)(variable_ = new ItemFilterData());
				}
				ItemFilterData itemFilter = ItemFilter;
				ItemFilterData itemFilter2 = other.ItemFilter;
				itemFilter.MergeFrom(itemFilter2);
				float num = (TargetAmount = other.TargetAmount);
				num = (MinWeightRequired = other.MinWeightRequired);
				num = (MaxWeightRequired = other.MaxWeightRequired);
				num = (MinStarRating = other.MinStarRating);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60040BD")]
		[Cpp2IlInjected.Address(RVA = "0x29EFC40", Offset = "0x29EE640", VA = "0x1829EFC40", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00b5: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 37)
			{
				if (num == 45)
				{
					float num3 = (MinWeightRequired = input.ReadFloat());
				}
				float num5;
				if (num == 53)
				{
					num5 = (MaxWeightRequired = input.ReadFloat());
				}
				if (num != 61)
				{
					goto IL_00d0;
				}
				num5 = (MinStarRating = input.ReadFloat());
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (Name = input.ReadString());
			}
			if ((long)text2 == 18)
			{
				ItemFilterData builder = new ItemFilterData();
				if (variableCase_ == VariableOneofCase.ItemFilter)
				{
					if (variableCase_ != VariableOneofCase.ItemFilter)
					{
					}
					object obj = variable_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				variable_ = builder;
				variableCase_ = (VariableOneofCase)typeof(ItemFilterData).TypeHandle;
			}
			if ((long)typeof(ItemFilterData).TypeHandle == 37)
			{
				float num8 = (TargetAmount = input.ReadFloat());
			}
			goto IL_00d0;
			IL_00d0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60040BE")]
		[Cpp2IlInjected.Address(RVA = "0x29EF4E0", Offset = "0x29EDEE0", VA = "0x1829EF4E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				string text = name_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60040BF")]
		[Cpp2IlInjected.Address(RVA = "0x29EFE30", Offset = "0x29EE830", VA = "0x1829EFE30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_0029
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				Name = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60040C0")]
		[Cpp2IlInjected.Address(RVA = "0x29EEEF0", Offset = "0x29ED8F0", VA = "0x1829EEEF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0015, IL_0018, IL_001b, IL_001e
			if (fieldNumber - 1 <= 6)
			{
				Name = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60040C1")]
		[Cpp2IlInjected.Address(RVA = "0x29EF9E0", Offset = "0x29EE3E0", VA = "0x1829EF9E0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Variable"))
			{
				VariableOneofCase variableOneofCase = variableCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60040C2")]
		[Cpp2IlInjected.Address(RVA = "0x29EF000", Offset = "0x29EDA00", VA = "0x1829EF000", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Variable"))
			{
				variable_ = (variableCase_ = VariableOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60040C3")]
		[Cpp2IlInjected.Address(RVA = "0x29F02A0", Offset = "0x29EECA0", VA = "0x1829F02A0")]
		static MissionVariable()
		{
			Func<MissionVariable> func = default(Func<MissionVariable>);
			_parser = (MessageParser<MissionVariable>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
