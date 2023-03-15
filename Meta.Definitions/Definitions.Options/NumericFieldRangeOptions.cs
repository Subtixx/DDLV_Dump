using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000761")]
	public sealed class NumericFieldRangeOptions : IMessage<NumericFieldRangeOptions>, IMessage, IEquatable<NumericFieldRangeOptions>, IDeepCloneable<NumericFieldRangeOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40024BA")]
		private static readonly MessageParser<NumericFieldRangeOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024BB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024BC")]
		public const int UseMinFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024BD")]
		private bool useMin_;

		[Cpp2IlInjected.Token(Token = "0x40024BE")]
		public const int MinFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40024BF")]
		private float min_;

		[Cpp2IlInjected.Token(Token = "0x40024C0")]
		public const int UseMaxFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024C1")]
		private bool useMax_;

		[Cpp2IlInjected.Token(Token = "0x40024C2")]
		public const int MaxFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40024C3")]
		private float max_;

		[Cpp2IlInjected.Token(Token = "0x170014A8")]
		[DebuggerNonUserCode]
		public static MessageParser<NumericFieldRangeOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600517A")]
			[Cpp2IlInjected.Address(RVA = "0x297A690", Offset = "0x2979090", VA = "0x18297A690")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014A9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600517B")]
			[Cpp2IlInjected.Address(RVA = "0x297A5C0", Offset = "0x2978FC0", VA = "0x18297A5C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014AA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600517C")]
			[Cpp2IlInjected.Address(RVA = "0x297A6F0", Offset = "0x29790F0", VA = "0x18297A6F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014AB")]
		[DebuggerNonUserCode]
		public bool UseMin
		{
			[Cpp2IlInjected.Token(Token = "0x6005180")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useMin_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005181")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useMin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014AC")]
		[DebuggerNonUserCode]
		public float Min
		{
			[Cpp2IlInjected.Token(Token = "0x6005182")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
			get
			{
				return min_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005183")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set
			{
				min_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014AD")]
		[DebuggerNonUserCode]
		public bool UseMax
		{
			[Cpp2IlInjected.Token(Token = "0x6005184")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return useMax_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005185")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				useMax_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014AE")]
		[DebuggerNonUserCode]
		public float Max
		{
			[Cpp2IlInjected.Token(Token = "0x6005186")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get
			{
				return max_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005187")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
			set
			{
				max_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005178")]
		[Cpp2IlInjected.Address(RVA = "0x2979E90", Offset = "0x2978890", VA = "0x182979E90")]
		public int InRange(int value)
		{
			//IL_0018: Expected I4, but got O
			if (useMin_)
			{
			}
			if (useMax_)
			{
				return (int)typeof(Math).TypeHandle;
			}
			return value;
		}

		[Cpp2IlInjected.Token(Token = "0x6005179")]
		[Cpp2IlInjected.Address(RVA = "0x2979F60", Offset = "0x2978960", VA = "0x182979F60")]
		public float InRange(float value)
		{
			do
			{
				if (useMin_)
				{
					float num = Math.Max(min_, value);
				}
			}
			while (!useMax_);
			return Math.Min(max_, value);
		}

		[Cpp2IlInjected.Token(Token = "0x600517D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public NumericFieldRangeOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600517E")]
		[Cpp2IlInjected.Address(RVA = "0x297A560", Offset = "0x2978F60", VA = "0x18297A560")]
		[DebuggerNonUserCode]
		public NumericFieldRangeOptions(NumericFieldRangeOptions other)
		{
			bool flag = (useMin_ = other.useMin_);
			float num = (min_ = other.min_);
			bool flag2 = (useMax_ = other.useMax_);
			float num2 = (max_ = other.max_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600517F")]
		[Cpp2IlInjected.Address(RVA = "0x2979860", Offset = "0x2978260", VA = "0x182979860", Slot = "10")]
		[DebuggerNonUserCode]
		public NumericFieldRangeOptions Clone()
		{
			//Discarded unreachable code: IL_0057
			NumericFieldRangeOptions numericFieldRangeOptions = new NumericFieldRangeOptions();
			bool flag = (numericFieldRangeOptions.useMin_ = useMin_);
			float num = (numericFieldRangeOptions.min_ = min_);
			bool flag2 = (numericFieldRangeOptions.useMax_ = useMax_);
			float num2 = (numericFieldRangeOptions.max_ = max_);
			UnknownFieldSet unknownFieldSet = (numericFieldRangeOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return numericFieldRangeOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6005188")]
		[Cpp2IlInjected.Address(RVA = "0x2979A20", Offset = "0x2978420", VA = "0x182979A20", Slot = "0")]
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
				if ((IntPtr)(useMin_ ? 1 : 0) == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (IntPtr)(useMax_ ? 1 : 0) == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005189")]
		[Cpp2IlInjected.Address(RVA = "0x29798F0", Offset = "0x29782F0", VA = "0x1829798F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NumericFieldRangeOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useMin_;
				if (useMin_ == flag)
				{
					bool flag2 = other.useMax_;
					if (useMax_ == flag2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600518A")]
		[Cpp2IlInjected.Address(RVA = "0x2979CA0", Offset = "0x29786A0", VA = "0x182979CA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0050
			//IL_0036: Expected O, but got I4
			bool flag = useMin_;
			if (flag)
			{
			}
			if (flag)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			bool flag2 = useMax_;
			int num = default(int);
			if (flag2)
			{
				num = 0;
			}
			if (flag2)
			{
				int hashCode = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600518B")]
		[Cpp2IlInjected.Address(RVA = "0x297A2F0", Offset = "0x2978CF0", VA = "0x18297A2F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600518C")]
		[Cpp2IlInjected.Address(RVA = "0x297A350", Offset = "0x2978D50", VA = "0x18297A350", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0068
			if (useMin_)
			{
				bool value = useMin_;
				output.WriteBool(value);
			}
			if (output != null)
			{
				float value2 = min_;
				output.WriteFloat(value2);
			}
			if (useMax_)
			{
				bool value3 = useMax_;
				output.WriteBool(value3);
			}
			if (output != null)
			{
				float value4 = max_;
				output.WriteFloat(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600518D")]
		[Cpp2IlInjected.Address(RVA = "0x29797D0", Offset = "0x29781D0", VA = "0x1829797D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (useMax_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x600518E")]
		[Cpp2IlInjected.Address(RVA = "0x297A100", Offset = "0x2978B00", VA = "0x18297A100", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NumericFieldRangeOptions other)
		{
			if (other != null)
			{
				bool flag = other.useMin_;
				if (flag)
				{
					useMin_ = flag;
				}
				float num = other.min_;
				if (flag)
				{
					min_ = num;
				}
				bool flag2 = other.useMax_;
				if (flag2)
				{
					useMax_ = flag2;
				}
				float num2 = other.max_;
				if (flag2)
				{
					max_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600518F")]
		[Cpp2IlInjected.Address(RVA = "0x297A030", Offset = "0x2978A30", VA = "0x18297A030", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0078
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 21)
			{
				if (num == 24)
				{
					bool flag = (useMax_ = input.ReadBool());
				}
				if (num != 37)
				{
					goto IL_0061;
				}
				float num2 = (max_ = input.ReadFloat());
			}
			bool flag2 = default(bool);
			if (num == 8)
			{
				flag2 = (useMin_ = input.ReadBool());
			}
			if (flag2)
			{
				float num3 = (min_ = input.ReadFloat());
			}
			goto IL_0061;
			IL_0061:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005190")]
		[Cpp2IlInjected.Address(RVA = "0x2979BA0", Offset = "0x29785A0", VA = "0x182979BA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0)
			{
				if (num == 1)
				{
					float num2 = max_;
					return typeof(float).TypeHandle;
				}
			}
			else
			{
				bool flag = useMin_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005191")]
		[Cpp2IlInjected.Address(RVA = "0x297A180", Offset = "0x2978B80", VA = "0x18297A180", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0035
			//IL_001b: Expected F4, but got O
			//IL_0023: Expected I4, but got O
			//IL_002b: Expected F4, but got O
			//IL_0034: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj2 = default(object);
						max_ = (float)obj2;
						break;
					}
					case 0:
					{
						object obj = default(object);
						useMax_ = (byte)(int)obj != 0;
						break;
					}
					}
				}
				else
				{
					object obj3 = default(object);
					min_ = (float)obj3;
				}
			}
			else
			{
				object obj4 = default(object);
				useMin_ = (byte)(int)obj4 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005192")]
		[Cpp2IlInjected.Address(RVA = "0x2979830", Offset = "0x2978230", VA = "0x182979830", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0018, IL_0024
			if (fieldNumber == 1)
			{
				max_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005193")]
		[Cpp2IlInjected.Address(RVA = "0x297A450", Offset = "0x2978E50", VA = "0x18297A450")]
		static NumericFieldRangeOptions()
		{
			Func<NumericFieldRangeOptions> func = default(Func<NumericFieldRangeOptions>);
			_parser = (MessageParser<NumericFieldRangeOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
