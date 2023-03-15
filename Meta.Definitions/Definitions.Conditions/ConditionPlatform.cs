using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200081F")]
	public sealed class ConditionPlatform : ICondition, IDataValidation, IMessage<ConditionPlatform>, IMessage, IEquatable<ConditionPlatform>, IDeepCloneable<ConditionPlatform>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002869")]
		private static readonly MessageParser<ConditionPlatform> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400286A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400286B")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400286C")]
		private EqualOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x400286D")]
		public const int PlatformFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400286E")]
		private DeviceType platform_;

		[Cpp2IlInjected.Token(Token = "0x170016FB")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD3")]
			[Cpp2IlInjected.Address(RVA = "0x24C7960", Offset = "0x24C6360", VA = "0x1824C7960", Slot = "5")]
			get
			{
				string text = Operations.ToString(operator_);
				DeviceType deviceType = platform_;
				return $"Platform {text} {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FC")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD4")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FD")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionPlatform> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD7")]
			[Cpp2IlInjected.Address(RVA = "0x24C79E0", Offset = "0x24C63E0", VA = "0x1824C79E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD8")]
			[Cpp2IlInjected.Address(RVA = "0x24C7890", Offset = "0x24C6290", VA = "0x1824C7890")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD9")]
			[Cpp2IlInjected.Address(RVA = "0x24C7A40", Offset = "0x24C6440", VA = "0x1824C7A40", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001700")]
		[DebuggerNonUserCode]
		public EqualOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005ADE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001701")]
		[DebuggerNonUserCode]
		public DeviceType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADF")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return platform_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005AE0")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				platform_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AD2")]
		[Cpp2IlInjected.Address(RVA = "0x24C73E0", Offset = "0x24C5DE0", VA = "0x1824C73E0")]
		public unsafe bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
			{
				num += num;
				num++;
			}
			EqualOperator equalOperator = operator_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AD5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AD6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005ADA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionPlatform()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005ADB")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public ConditionPlatform(ConditionPlatform other)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
			EqualOperator equalOperator = (operator_ = other.operator_);
			DeviceType deviceType = (platform_ = other.platform_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005ADC")]
		[Cpp2IlInjected.Address(RVA = "0x24C7350", Offset = "0x24C5D50", VA = "0x1824C7350", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionPlatform Clone()
		{
			//Discarded unreachable code: IL_003c
			//IL_0009: Expected O, but got I4
			int num = 0;
			ConditionPlatform conditionPlatform = default(ConditionPlatform);
			conditionPlatform.DataValidation((DataValidation.Context)num);
			EqualOperator equalOperator = (conditionPlatform.operator_ = operator_);
			DeviceType deviceType = (conditionPlatform.platform_ = platform_);
			UnknownFieldSet unknownFieldSet = (conditionPlatform._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionPlatform;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE1")]
		[Cpp2IlInjected.Address(RVA = "0x24C74D0", Offset = "0x24C5ED0", VA = "0x1824C74D0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionPlatform).TypeHandle && (IntPtr)(void*)(int)platform_ == (IntPtr)typeof(ConditionPlatform).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE2")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionPlatform other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				EqualOperator equalOperator = other.operator_;
				if (operator_ == equalOperator)
				{
					DeviceType deviceType = other.platform_;
					if (platform_ == deviceType)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE3")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (operator_ != 0)
				{
				}
				if (platform_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE4")]
		[Cpp2IlInjected.Address(RVA = "0x24C7720", Offset = "0x24C6120", VA = "0x1824C7720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE5")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0025
			if (operator_ != 0)
			{
			}
			if (platform_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE6")]
		[Cpp2IlInjected.Address(RVA = "0x24C7280", Offset = "0x24C5C80", VA = "0x1824C7280", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				EqualOperator equalOperator = operator_;
				num = 0;
				if (equalOperator != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)equalOperator);
				}
				DeviceType deviceType = platform_;
				if (deviceType != 0)
				{
					int num3 = CodedOutputStream.ComputeEnumSize((int)deviceType);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE7")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionPlatform other)
		{
			if (other != null)
			{
				EqualOperator equalOperator = other.operator_;
				if (equalOperator != 0)
				{
					operator_ = equalOperator;
				}
				DeviceType deviceType = other.platform_;
				if (deviceType != 0)
				{
					platform_ = deviceType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE8")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(operator_ = (EqualOperator)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (int)(platform_ = (DeviceType)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE9")]
		[Cpp2IlInjected.Address(RVA = "0x24C7560", Offset = "0x24C5F60", VA = "0x1824C7560", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				EqualOperator equalOperator = operator_;
			}
			if (fieldNumber == 2)
			{
				DeviceType deviceType = platform_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AEA")]
		[Cpp2IlInjected.Address(RVA = "0x24C7650", Offset = "0x24C6050", VA = "0x1824C7650", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				operator_ = (EqualOperator)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			platform_ = (DeviceType)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AEB")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				operator_ = EqualOperator.Equal;
				break;
			case 2:
				platform_ = DeviceType.Unknown;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AEC")]
		[Cpp2IlInjected.Address(RVA = "0x24C7780", Offset = "0x24C6180", VA = "0x1824C7780")]
		static ConditionPlatform()
		{
			Func<ConditionPlatform> func = default(Func<ConditionPlatform>);
			_parser = (MessageParser<ConditionPlatform>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AED")]
		[Cpp2IlInjected.Address(RVA = "0x24C73E0", Offset = "0x24C5DE0", VA = "0x1824C73E0", Slot = "4")]
		unsafe bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
			{
				num += num;
				num++;
			}
			EqualOperator equalOperator = operator_;
			bool result = default(bool);
			return result;
		}
	}
}
