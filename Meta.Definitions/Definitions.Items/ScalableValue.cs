using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200040E")]
	public sealed class ScalableValue : IMessage<ScalableValue>, IMessage, IEquatable<ScalableValue>, IDeepCloneable<ScalableValue>, IMessageFieldAccessor, IScalableValue, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400162C")]
		private static readonly MessageParser<ScalableValue> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400162D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400162E")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400162F")]
		private int value_;

		[Cpp2IlInjected.Token(Token = "0x4001630")]
		public const int ScalingScriptFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001631")]
		private int scalingScript_;

		[Cpp2IlInjected.Token(Token = "0x17000CB7")]
		[DebuggerNonUserCode]
		public static MessageParser<ScalableValue> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003193")]
			[Cpp2IlInjected.Address(RVA = "0x2DB38D0", Offset = "0x2DB22D0", VA = "0x182DB38D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003194")]
			[Cpp2IlInjected.Address(RVA = "0x2DB3800", Offset = "0x2DB2200", VA = "0x182DB3800")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003195")]
			[Cpp2IlInjected.Address(RVA = "0x2DB3930", Offset = "0x2DB2330", VA = "0x182DB3930", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBA")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6003199")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x600319A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				value_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBB")]
		[DebuggerNonUserCode]
		public int ScalingScript
		{
			[Cpp2IlInjected.Token(Token = "0x600319B")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "15")]
			get
			{
				return scalingScript_;
			}
			[Cpp2IlInjected.Token(Token = "0x600319C")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				scalingScript_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003196")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ScalableValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003197")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public ScalableValue(ScalableValue other)
		{
			int num = (value_ = other.value_);
			int num2 = (scalingScript_ = other.scalingScript_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003198")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3380", Offset = "0x2DB1D80", VA = "0x182DB3380", Slot = "10")]
		[DebuggerNonUserCode]
		public ScalableValue Clone()
		{
			//Discarded unreachable code: IL_0037
			ScalableValue scalableValue = new ScalableValue();
			int num = (scalableValue.value_ = value_);
			int num2 = (scalableValue.scalingScript_ = scalingScript_);
			UnknownFieldSet unknownFieldSet = (scalableValue._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return scalableValue;
		}

		[Cpp2IlInjected.Token(Token = "0x600319D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3480", Offset = "0x2DB1E80", VA = "0x182DB3480", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)value_ == (IntPtr)typeof(ScalableValue).TypeHandle && (IntPtr)scalingScript_ == (IntPtr)typeof(ScalableValue).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600319E")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ScalableValue other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.value_;
				if (value_ == num)
				{
					int num2 = other.scalingScript_;
					if (scalingScript_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600319F")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (value_ != 0)
				{
				}
				if (scalingScript_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60031A0")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3690", Offset = "0x2DB2090", VA = "0x182DB3690", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60031A1")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (value_ != 0)
			{
				int value = value_;
				output.WriteInt32(value);
			}
			if (scalingScript_ != 0)
			{
				int value2 = scalingScript_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60031A2")]
		[Cpp2IlInjected.Address(RVA = "0x2DB32B0", Offset = "0x2DB1CB0", VA = "0x182DB32B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = value_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = scalingScript_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60031A3")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ScalableValue other)
		{
			if (other != null)
			{
				int num = other.value_;
				if (num != 0)
				{
					value_ = num;
				}
				int num2 = other.scalingScript_;
				if (num2 != 0)
				{
					scalingScript_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031A4")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (value_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (scalingScript_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031A5")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3510", Offset = "0x2DB1F10", VA = "0x182DB3510", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = value_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031A6")]
		[Cpp2IlInjected.Address(RVA = "0x2DB35D0", Offset = "0x2DB1FD0", VA = "0x182DB35D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				value_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			scalingScript_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x60031A7")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				value_ = 0;
				break;
			case 2:
				scalingScript_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031A8")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3410", Offset = "0x2DB1E10", VA = "0x182DB3410", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001e
			if (scalingScript_ != 0 && context.IsMission)
			{
				context.AddError("Cannot use 'ScalingScript' in Mission");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031A9")]
		[Cpp2IlInjected.Address(RVA = "0x2DB36F0", Offset = "0x2DB20F0", VA = "0x182DB36F0")]
		static ScalableValue()
		{
			Func<ScalableValue> func = default(Func<ScalableValue>);
			_parser = (MessageParser<ScalableValue>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
