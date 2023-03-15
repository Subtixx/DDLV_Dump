using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x200078C")]
	public sealed class DurationFieldOptions : IMessage<DurationFieldOptions>, IMessage, IEquatable<DurationFieldOptions>, IDeepCloneable<DurationFieldOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200078D")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200078E")]
			public enum Unit
			{
				[Cpp2IlInjected.Token(Token = "0x40025D9")]
				[OriginalName("Unit_Milliseconds")]
				Milliseconds,
				[Cpp2IlInjected.Token(Token = "0x40025DA")]
				[OriginalName("Unit_Seconds")]
				Seconds,
				[Cpp2IlInjected.Token(Token = "0x40025DB")]
				[OriginalName("Unit_Minutes")]
				Minutes,
				[Cpp2IlInjected.Token(Token = "0x40025DC")]
				[OriginalName("Unit_Hours")]
				Hours,
				[Cpp2IlInjected.Token(Token = "0x40025DD")]
				[OriginalName("Unit_Days")]
				Days
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40025D4")]
		private static readonly MessageParser<DurationFieldOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40025D5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40025D6")]
		public const int DefaultUnitFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025D7")]
		private Types.Unit defaultUnit_;

		[Cpp2IlInjected.Token(Token = "0x17001511")]
		[DebuggerNonUserCode]
		public static MessageParser<DurationFieldOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600532E")]
			[Cpp2IlInjected.Address(RVA = "0x2C4DFD0", Offset = "0x2C4C9D0", VA = "0x182C4DFD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001512")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600532F")]
			[Cpp2IlInjected.Address(RVA = "0x2C4DF00", Offset = "0x2C4C900", VA = "0x182C4DF00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001513")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005330")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E030", Offset = "0x2C4CA30", VA = "0x182C4E030", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001514")]
		[DebuggerNonUserCode]
		public Types.Unit DefaultUnit
		{
			[Cpp2IlInjected.Token(Token = "0x6005334")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return defaultUnit_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005335")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				defaultUnit_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005331")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DurationFieldOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005332")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public DurationFieldOptions(DurationFieldOptions other)
		{
			Types.Unit unit = (defaultUnit_ = other.defaultUnit_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005333")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DB50", Offset = "0x2C4C550", VA = "0x182C4DB50", Slot = "10")]
		[DebuggerNonUserCode]
		public DurationFieldOptions Clone()
		{
			//Discarded unreachable code: IL_0029
			DurationFieldOptions durationFieldOptions = new DurationFieldOptions();
			Types.Unit unit = (durationFieldOptions.defaultUnit_ = defaultUnit_);
			UnknownFieldSet unknownFieldSet = (durationFieldOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return durationFieldOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6005336")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DBD0", Offset = "0x2C4C5D0", VA = "0x182C4DBD0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)defaultUnit_ == (IntPtr)typeof(DurationFieldOptions).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005337")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DurationFieldOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.Unit unit = other.defaultUnit_;
				if (defaultUnit_ == unit)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005338")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (defaultUnit_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005339")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DD90", Offset = "0x2C4C790", VA = "0x182C4DD90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600533A")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_001c
			if (defaultUnit_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600533B")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DAB0", Offset = "0x2C4C4B0", VA = "0x182C4DAB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.Unit unit = defaultUnit_;
				num = 0;
				if (unit != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)unit);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600533C")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DurationFieldOptions other)
		{
			if (other != null)
			{
				Types.Unit unit = other.defaultUnit_;
				if (unit != 0)
				{
					defaultUnit_ = unit;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600533D")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(defaultUnit_ = (Types.Unit)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600533E")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DC60", Offset = "0x2C4C660", VA = "0x182C4DC60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.Unit unit = defaultUnit_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600533F")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DD10", Offset = "0x2C4C710", VA = "0x182C4DD10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				defaultUnit_ = (Types.Unit)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005340")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				defaultUnit_ = Types.Unit.Milliseconds;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005341")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DDF0", Offset = "0x2C4C7F0", VA = "0x182C4DDF0")]
		static DurationFieldOptions()
		{
			Func<DurationFieldOptions> func = default(Func<DurationFieldOptions>);
			_parser = (MessageParser<DurationFieldOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
