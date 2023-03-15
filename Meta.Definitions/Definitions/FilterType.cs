using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class FilterType : IMessage<FilterType>, IMessage, IEquatable<FilterType>, IDeepCloneable<FilterType>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public enum TypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			SegmentId,
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			Conditions
		}

		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly MessageParser<FilterType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public const int SegmentIdFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public const int ConditionsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private object type_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TypeOneofCase typeCase_;

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[DebuggerNonUserCode]
		public static MessageParser<FilterType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x35758C0", Offset = "0x35742C0", VA = "0x1835758C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x35757F0", Offset = "0x35741F0", VA = "0x1835757F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x3575990", Offset = "0x3574390", VA = "0x183575990", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		[DebuggerNonUserCode]
		public string SegmentId
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x3575920", Offset = "0x3574320", VA = "0x183575920")]
			get
			{
				if (typeCase_ == TypeOneofCase.SegmentId)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x3575AA0", Offset = "0x35744A0", VA = "0x183575AA0")]
			set
			{
				//IL_001c: Expected I4, but got I8
				string text = (string)(type_ = ProtoPreconditions.CheckNotNull(value, "value"));
				typeCase_ = TypeOneofCase.SegmentId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x3575790", Offset = "0x3574190", VA = "0x183575790")]
			get
			{
				if (typeCase_ == TypeOneofCase.Conditions)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		[DebuggerNonUserCode]
		public TypeOneofCase TypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return typeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FilterType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x35756A0", Offset = "0x35740A0", VA = "0x1835756A0")]
		[DebuggerNonUserCode]
		public FilterType(FilterType other)
		{
			//IL_003a: Expected I4, but got O
			TypeOneofCase typeOneofCase = other.typeCase_;
			if (typeOneofCase == TypeOneofCase.SegmentId)
			{
				string text = (SegmentId = other.SegmentId);
			}
			if (typeOneofCase == TypeOneofCase.Conditions)
			{
				if (other.type_ == null)
				{
					throw new InvalidCastException();
				}
				ConditionsList conditionsList = default(ConditionsList);
				type_ = conditionsList;
				typeCase_ = (TypeOneofCase)conditionsList;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x3574B50", Offset = "0x3573550", VA = "0x183574B50", Slot = "10")]
		[DebuggerNonUserCode]
		public FilterType Clone()
		{
			//Discarded unreachable code: IL_0051
			//IL_003a: Expected I4, but got O
			FilterType filterType = new FilterType();
			TypeOneofCase typeOneofCase = typeCase_;
			if (typeOneofCase == TypeOneofCase.SegmentId)
			{
				string text = (filterType.SegmentId = SegmentId);
			}
			if (typeOneofCase == TypeOneofCase.Conditions)
			{
				if (type_ == null)
				{
					throw new InvalidCastException();
				}
				ConditionsList conditionsList = default(ConditionsList);
				filterType.type_ = conditionsList;
				filterType.typeCase_ = (TypeOneofCase)conditionsList;
			}
			UnknownFieldSet unknownFieldSet = (filterType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return filterType;
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
			//IL_0010: Expected O, but got I4
			type_ = (typeCase_ = TypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x3574D30", Offset = "0x3573730", VA = "0x183574D30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = default(string);
				if (!(SegmentId != text))
				{
					ConditionsList objB = default(ConditionsList);
					bool flag = object.Equals(Conditions, objB);
					if (flag && typeCase_ == (flag ? TypeOneofCase.SegmentId : TypeOneofCase.None))
					{
						return object.Equals(_unknownFields, objB);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x3574C70", Offset = "0x3573670", VA = "0x183574C70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FilterType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string segmentId = SegmentId;
				string segmentId2 = other.SegmentId;
				if (!(segmentId != segmentId2))
				{
					ConditionsList conditions = Conditions;
					ConditionsList conditions2 = other.Conditions;
					if (object.Equals(conditions, conditions2))
					{
						TypeOneofCase typeOneofCase = other.typeCase_;
						if (typeCase_ == typeOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x3574F10", Offset = "0x3573910", VA = "0x183574F10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005e
			TypeOneofCase typeOneofCase = typeCase_;
			int num = 0;
			if (typeOneofCase == TypeOneofCase.SegmentId)
			{
				if (typeCase_ != TypeOneofCase.SegmentId)
				{
				}
				object obj = type_;
				if (obj != null && obj == null)
				{
					goto IL_0064;
				}
				int hashCode = obj.GetHashCode();
			}
			if (typeOneofCase == TypeOneofCase.Conditions)
			{
				object obj2 = type_;
				if (obj2 == null)
				{
					goto IL_0064;
				}
				int hashCode2 = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
			IL_0064:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x3575450", Offset = "0x3573E50", VA = "0x183575450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x35754B0", Offset = "0x3573EB0", VA = "0x1835754B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0048
			TypeOneofCase typeOneofCase = typeCase_;
			if (typeOneofCase == TypeOneofCase.SegmentId)
			{
				string segmentId = SegmentId;
				output.WriteString(segmentId);
			}
			if (typeOneofCase == TypeOneofCase.Conditions && typeCase_ == TypeOneofCase.Conditions)
			{
				object obj = type_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x3574910", Offset = "0x3573310", VA = "0x183574910", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (typeCase_ == TypeOneofCase.SegmentId)
			{
				if (typeCase_ != TypeOneofCase.SegmentId)
				{
				}
				object obj = type_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (typeCase_ == TypeOneofCase.Conditions)
			{
				if (typeCase_ == TypeOneofCase.Conditions)
				{
					object obj2 = type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num2 = default(int);
				num += num2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x3575260", Offset = "0x3573C60", VA = "0x183575260", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FilterType other)
		{
			if (other == null)
			{
				return;
			}
			if (other.typeCase_ != TypeOneofCase.SegmentId)
			{
				while ((long)typeof(ConditionsList).TypeHandle != 2)
				{
				}
				ConditionsList conditionsList = default(ConditionsList);
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = new ConditionsList();
				}
				ConditionsList conditions = other.Conditions;
				ConditionsList conditionsList3 = default(ConditionsList);
				conditionsList3.MergeFrom(conditions);
				throw new NullReferenceException();
			}
			string text = (SegmentId = other.SegmentId);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x3575100", Offset = "0x3573B00", VA = "0x183575100", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0069: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				string text2 = (SegmentId = input.ReadString());
			}
			if (num == 18)
			{
				ConditionsList builder = new ConditionsList();
				if (typeCase_ == TypeOneofCase.Conditions)
				{
					if (typeCase_ != TypeOneofCase.Conditions)
					{
					}
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				type_ = builder;
				typeCase_ = (TypeOneofCase)typeof(ConditionsList).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x3574E30", Offset = "0x3573830", VA = "0x183574E30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string segmentId = SegmentId;
			}
			if (fieldNumber == 2)
			{
				while (typeCase_ != TypeOneofCase.Conditions)
				{
				}
				object obj = type_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_0037;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
			IL_0037:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x3575370", Offset = "0x3573D70", VA = "0x183575370", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0034: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					SegmentId = (string)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				type_ = value;
				typeCase_ = (TypeOneofCase)typeof(string).TypeHandle;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x3574A70", Offset = "0x3573470", VA = "0x183574A70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_001d: Expected O, but got I4
			switch (fieldNumber)
			{
			case 1:
				SegmentId = "";
				break;
			case 2:
			{
				int num = 0;
				type_ = num;
				typeCase_ = (TypeOneofCase)num;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x3575050", Offset = "0x3573A50", VA = "0x183575050", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				TypeOneofCase typeOneofCase = typeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x3574AE0", Offset = "0x35734E0", VA = "0x183574AE0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				type_ = (typeCase_ = TypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x3575590", Offset = "0x3573F90", VA = "0x183575590")]
		static FilterType()
		{
			Func<FilterType> func = default(Func<FilterType>);
			_parser = (MessageParser<FilterType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
