using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005CE")]
	public sealed class FeatureDevInfo : IMessage<FeatureDevInfo>, IMessage, IEquatable<FeatureDevInfo>, IDeepCloneable<FeatureDevInfo>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001FB3")]
		private static readonly MessageParser<FeatureDevInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FB4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FB5")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FB6")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FB7")]
		public const int IsHiddenFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FB8")]
		private bool isHidden_;

		[Cpp2IlInjected.Token(Token = "0x170012A8")]
		[DebuggerNonUserCode]
		public static MessageParser<FeatureDevInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600485E")]
			[Cpp2IlInjected.Address(RVA = "0x2CA5520", Offset = "0x2CA3F20", VA = "0x182CA5520")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012A9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600485F")]
			[Cpp2IlInjected.Address(RVA = "0x2CA5450", Offset = "0x2CA3E50", VA = "0x182CA5450")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012AA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004860")]
			[Cpp2IlInjected.Address(RVA = "0x2CA5580", Offset = "0x2CA3F80", VA = "0x182CA5580", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012AB")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004864")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004865")]
			[Cpp2IlInjected.Address(RVA = "0x2CA5690", Offset = "0x2CA4090", VA = "0x182CA5690")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012AC")]
		[DebuggerNonUserCode]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x6004866")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return isHidden_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004867")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				isHidden_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004861")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5400", Offset = "0x2CA3E00", VA = "0x182CA5400")]
		[DebuggerNonUserCode]
		public FeatureDevInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004862")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5360", Offset = "0x2CA3D60", VA = "0x182CA5360")]
		[DebuggerNonUserCode]
		public FeatureDevInfo(FeatureDevInfo other)
		{
			string text = (name_ = other.name_);
			bool flag = (isHidden_ = other.isHidden_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004863")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4D00", Offset = "0x2CA3700", VA = "0x182CA4D00", Slot = "10")]
		[DebuggerNonUserCode]
		public FeatureDevInfo Clone()
		{
			//Discarded unreachable code: IL_0042
			FeatureDevInfo featureDevInfo = new FeatureDevInfo();
			featureDevInfo.name_ = "";
			string text = (featureDevInfo.name_ = name_);
			bool flag = (featureDevInfo.isHidden_ = isHidden_);
			UnknownFieldSet unknownFieldSet = (featureDevInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return featureDevInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6004868")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4E50", Offset = "0x2CA3850", VA = "0x182CA4E50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = name_;
				bool flag = default(bool);
				if (!flag && isHidden_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004869")]
		[Cpp2IlInjected.Address(RVA = "0x17C5550", Offset = "0x17C3F50", VA = "0x1817C5550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FeatureDevInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					bool flag = other.isHidden_;
					if (isHidden_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600486A")]
		[Cpp2IlInjected.Address(RVA = "0x17C5740", Offset = "0x17C4140", VA = "0x1817C5740", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0038
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (isHidden_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600486B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA51F0", Offset = "0x2CA3BF0", VA = "0x182CA51F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600486C")]
		[Cpp2IlInjected.Address(RVA = "0x17C5A50", Offset = "0x17C4450", VA = "0x1817C5A50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0046
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			if (isHidden_)
			{
				bool value2 = isHidden_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600486D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4BB0", Offset = "0x2CA35B0", VA = "0x182CA4BB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0037
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600486E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5070", Offset = "0x2CA3A70", VA = "0x182CA5070", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FeatureDevInfo other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				bool flag = other.isHidden_;
				if (flag)
				{
					isHidden_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600486F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4FD0", Offset = "0x2CA39D0", VA = "0x182CA4FD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Name = input.ReadString());
				}
				if (num == 16)
				{
					bool flag = (isHidden_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004870")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4F00", Offset = "0x2CA3900", VA = "0x182CA4F00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = name_;
			}
			if (fieldNumber == 2)
			{
				bool flag = isHidden_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004871")]
		[Cpp2IlInjected.Address(RVA = "0x2CA50E0", Offset = "0x2CA3AE0", VA = "0x182CA50E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (name_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				isHidden_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004872")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4C50", Offset = "0x2CA3650", VA = "0x182CA4C50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				isHidden_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004873")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4DD0", Offset = "0x2CA37D0", VA = "0x182CA4DD0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0020
			string text = name_;
			if ("Please enter a featuredev name" != null)
			{
				context.AddInvalidMemberError("Please enter a featuredev name", "Name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004874")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5250", Offset = "0x2CA3C50", VA = "0x182CA5250")]
		static FeatureDevInfo()
		{
			Func<FeatureDevInfo> func = default(Func<FeatureDevInfo>);
			_parser = (MessageParser<FeatureDevInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
