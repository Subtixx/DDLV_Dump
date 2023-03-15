using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008C9")]
	public sealed class StaticBuffData : IMessage<StaticBuffData>, IMessage, IEquatable<StaticBuffData>, IDeepCloneable<StaticBuffData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400237E")]
		private static readonly MessageParser<StaticBuffData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400237F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002380")]
		public const int DefaultDisplayDataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002381")]
		private BuffDisplayData defaultDisplayData_;

		[Cpp2IlInjected.Token(Token = "0x4002382")]
		public const int DisplayDataFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002383")]
		private static readonly FieldCodec<BuffDisplayData> _repeated_displayData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002384")]
		private readonly RepeatedField<BuffDisplayData> displayData_ = (RepeatedField<BuffDisplayData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000CB4")]
		[DebuggerNonUserCode]
		public static MessageParser<StaticBuffData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004B3F")]
			[Cpp2IlInjected.Address(RVA = "0xC05C10", Offset = "0xC04610", VA = "0x180C05C10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B40")]
			[Cpp2IlInjected.Address(RVA = "0xC05B40", Offset = "0xC04540", VA = "0x180C05B40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B41")]
			[Cpp2IlInjected.Address(RVA = "0xC05C70", Offset = "0xC04670", VA = "0x180C05C70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB7")]
		[DebuggerNonUserCode]
		public BuffDisplayData DefaultDisplayData
		{
			[Cpp2IlInjected.Token(Token = "0x6004B45")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultDisplayData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B46")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				defaultDisplayData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CB8")]
		[DebuggerNonUserCode]
		public RepeatedField<BuffDisplayData> DisplayData
		{
			[Cpp2IlInjected.Token(Token = "0x6004B47")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return displayData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B42")]
		[Cpp2IlInjected.Address(RVA = "0xC05AC0", Offset = "0xC044C0", VA = "0x180C05AC0")]
		[DebuggerNonUserCode]
		public StaticBuffData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B43")]
		[Cpp2IlInjected.Address(RVA = "0xC059A0", Offset = "0xC043A0", VA = "0x180C059A0")]
		[DebuggerNonUserCode]
		public StaticBuffData(StaticBuffData other)
		{
			//IL_002e: Expected O, but got I4
			BuffDisplayData buffDisplayData = other.defaultDisplayData_;
			if (buffDisplayData != null)
			{
				BuffDisplayData buffDisplayData2 = buffDisplayData.Clone();
			}
			int num = 0;
			defaultDisplayData_ = (BuffDisplayData)num;
			RepeatedField<BuffDisplayData> repeatedField = (displayData_ = (RepeatedField<BuffDisplayData>)(object)((RepeatedField<T>)(object)other.displayData_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B44")]
		[Cpp2IlInjected.Address(RVA = "0xC04F60", Offset = "0xC03960", VA = "0x180C04F60", Slot = "10")]
		[DebuggerNonUserCode]
		public StaticBuffData Clone()
		{
			//Discarded unreachable code: IL_005c
			//IL_0030: Expected O, but got I4
			StaticBuffData staticBuffData = new StaticBuffData();
			RepeatedField<BuffDisplayData> repeatedField = (staticBuffData.displayData_ = (RepeatedField<BuffDisplayData>)(object)new RepeatedField<T>());
			BuffDisplayData buffDisplayData = defaultDisplayData_;
			if (buffDisplayData != null)
			{
				BuffDisplayData buffDisplayData2 = buffDisplayData.Clone();
			}
			int num = 0;
			staticBuffData.defaultDisplayData_ = (BuffDisplayData)num;
			RepeatedField<BuffDisplayData> repeatedField2 = (staticBuffData.displayData_ = (RepeatedField<BuffDisplayData>)(object)((RepeatedField<T>)(object)displayData_).Clone());
			UnknownFieldSet unknownFieldSet = (staticBuffData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return staticBuffData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B48")]
		[Cpp2IlInjected.Address(RVA = "0xC05160", Offset = "0xC03B60", VA = "0x180C05160", Slot = "0")]
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
				if (object.Equals(defaultDisplayData_, other))
				{
					RepeatedField<BuffDisplayData> repeatedField = displayData_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B49")]
		[Cpp2IlInjected.Address(RVA = "0xC050B0", Offset = "0xC03AB0", VA = "0x180C050B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StaticBuffData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				BuffDisplayData objB = other.defaultDisplayData_;
				if (object.Equals(defaultDisplayData_, objB))
				{
					RepeatedField<BuffDisplayData> repeatedField = displayData_;
					RepeatedField<BuffDisplayData> repeatedField2 = other.displayData_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4A")]
		[Cpp2IlInjected.Address(RVA = "0xC052E0", Offset = "0xC03CE0", VA = "0x180C052E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0033
			BuffDisplayData buffDisplayData = defaultDisplayData_;
			if (buffDisplayData != null)
			{
				int hashCode = buffDisplayData.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)displayData_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4B")]
		[Cpp2IlInjected.Address(RVA = "0xC05680", Offset = "0xC04080", VA = "0x180C05680", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4C")]
		[Cpp2IlInjected.Address(RVA = "0xC056E0", Offset = "0xC040E0", VA = "0x180C056E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if ((long)defaultDisplayData_ != 0)
			{
				BuffDisplayData value = defaultDisplayData_;
				output.WriteMessage(value);
			}
			RepeatedField<BuffDisplayData> repeatedField = displayData_;
			FieldCodec<BuffDisplayData> repeated_displayData_codec = _repeated_displayData_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_displayData_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4D")]
		[Cpp2IlInjected.Address(RVA = "0xC04DE0", Offset = "0xC037E0", VA = "0x180C04DE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			BuffDisplayData buffDisplayData = defaultDisplayData_;
			int num = 0;
			if (buffDisplayData != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(buffDisplayData);
			}
			RepeatedField<BuffDisplayData> repeatedField = displayData_;
			FieldCodec<BuffDisplayData> repeated_displayData_codec = _repeated_displayData_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_displayData_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4E")]
		[Cpp2IlInjected.Address(RVA = "0xC05360", Offset = "0xC03D60", VA = "0x180C05360", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StaticBuffData other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			if ((long)other.defaultDisplayData_ != 0)
			{
				BuffDisplayData buffDisplayData = defaultDisplayData_;
				if (buffDisplayData == null)
				{
					BuffDisplayData buffDisplayData2 = (defaultDisplayData_ = new BuffDisplayData());
				}
				BuffDisplayData other2 = other.defaultDisplayData_;
				buffDisplayData.MergeFrom(other2);
			}
			RepeatedField<BuffDisplayData> repeatedField = displayData_;
			RepeatedField<BuffDisplayData> repeatedField2 = other.displayData_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4F")]
		[Cpp2IlInjected.Address(RVA = "0xC05450", Offset = "0xC03E50", VA = "0x180C05450", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0065
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				BuffDisplayData buffDisplayData = defaultDisplayData_;
				if (buffDisplayData == null)
				{
					BuffDisplayData buffDisplayData2 = (defaultDisplayData_ = new BuffDisplayData());
				}
				input.ReadMessage(buffDisplayData);
			}
			if (num == 18)
			{
				RepeatedField<BuffDisplayData> repeatedField = displayData_;
				FieldCodec<BuffDisplayData> repeated_displayData_codec = _repeated_displayData_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_displayData_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004B50")]
		[Cpp2IlInjected.Address(RVA = "0xC05250", Offset = "0xC03C50", VA = "0x180C05250", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				BuffDisplayData buffDisplayData = defaultDisplayData_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<BuffDisplayData> repeatedField = displayData_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B51")]
		[Cpp2IlInjected.Address(RVA = "0xC055B0", Offset = "0xC03FB0", VA = "0x180C055B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					defaultDisplayData_ = (BuffDisplayData)num;
					return;
				}
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B52")]
		[Cpp2IlInjected.Address(RVA = "0xC04EE0", Offset = "0xC038E0", VA = "0x180C04EE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<BuffDisplayData> repeatedField = displayData_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B53")]
		[Cpp2IlInjected.Address(RVA = "0xC057D0", Offset = "0xC041D0", VA = "0x180C057D0")]
		static StaticBuffData()
		{
			Func<StaticBuffData> func = default(Func<StaticBuffData>);
			_parser = (MessageParser<StaticBuffData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<BuffDisplayData> parser = BuffDisplayData._parser;
			uint num = default(uint);
			_parser = (MessageParser<StaticBuffData>)(object)FieldCodec.ForMessage<BuffDisplayData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
