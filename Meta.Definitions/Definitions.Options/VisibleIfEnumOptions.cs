using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x200077B")]
	public sealed class VisibleIfEnumOptions : IMessage<VisibleIfEnumOptions>, IMessage, IEquatable<VisibleIfEnumOptions>, IDeepCloneable<VisibleIfEnumOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002523")]
		private static readonly MessageParser<VisibleIfEnumOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002524")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002525")]
		public const int EnumFieldNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002526")]
		private string enumFieldName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002527")]
		public const int ValidEnumValuesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002528")]
		private static readonly FieldCodec<string> _repeated_validEnumValues_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002529")]
		private readonly RepeatedField<string> validEnumValues_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400252A")]
		public const int InvalidEnumValuesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400252B")]
		private static readonly FieldCodec<string> _repeated_invalidEnumValues_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400252C")]
		private readonly RepeatedField<string> invalidEnumValues_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170014DE")]
		[DebuggerNonUserCode]
		public static MessageParser<VisibleIfEnumOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600527C")]
			[Cpp2IlInjected.Address(RVA = "0x17C5150", Offset = "0x17C3B50", VA = "0x1817C5150")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600527D")]
			[Cpp2IlInjected.Address(RVA = "0x17C5080", Offset = "0x17C3A80", VA = "0x1817C5080")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600527E")]
			[Cpp2IlInjected.Address(RVA = "0x17C51B0", Offset = "0x17C3BB0", VA = "0x1817C51B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E1")]
		[DebuggerNonUserCode]
		public string EnumFieldName
		{
			[Cpp2IlInjected.Token(Token = "0x6005282")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return enumFieldName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005283")]
			[Cpp2IlInjected.Address(RVA = "0x17C52C0", Offset = "0x17C3CC0", VA = "0x1817C52C0")]
			set
			{
				string text = (enumFieldName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E2")]
		[DebuggerNonUserCode]
		public RepeatedField<string> ValidEnumValues
		{
			[Cpp2IlInjected.Token(Token = "0x6005284")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return validEnumValues_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E3")]
		[DebuggerNonUserCode]
		public RepeatedField<string> InvalidEnumValues
		{
			[Cpp2IlInjected.Token(Token = "0x6005285")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return invalidEnumValues_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600527F")]
		[Cpp2IlInjected.Address(RVA = "0x17C4FB0", Offset = "0x17C39B0", VA = "0x1817C4FB0")]
		[DebuggerNonUserCode]
		public VisibleIfEnumOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005280")]
		[Cpp2IlInjected.Address(RVA = "0x17C4E20", Offset = "0x17C3820", VA = "0x1817C4E20")]
		[DebuggerNonUserCode]
		public VisibleIfEnumOptions(VisibleIfEnumOptions other)
		{
			string text = (enumFieldName_ = other.enumFieldName_);
			RepeatedField<string> repeatedField = (validEnumValues_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.validEnumValues_).Clone());
			RepeatedField<string> repeatedField2 = (invalidEnumValues_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.invalidEnumValues_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005281")]
		[Cpp2IlInjected.Address(RVA = "0x17C4330", Offset = "0x17C2D30", VA = "0x1817C4330", Slot = "10")]
		[DebuggerNonUserCode]
		public VisibleIfEnumOptions Clone()
		{
			//Discarded unreachable code: IL_007a
			VisibleIfEnumOptions visibleIfEnumOptions = new VisibleIfEnumOptions();
			visibleIfEnumOptions.enumFieldName_ = "";
			RepeatedField<string> repeatedField = (visibleIfEnumOptions.validEnumValues_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			RepeatedField<string> repeatedField2 = (visibleIfEnumOptions.invalidEnumValues_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			string text = (visibleIfEnumOptions.enumFieldName_ = enumFieldName_);
			RepeatedField<string> repeatedField3 = (visibleIfEnumOptions.validEnumValues_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)validEnumValues_).Clone());
			RepeatedField<string> repeatedField4 = (visibleIfEnumOptions.invalidEnumValues_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)invalidEnumValues_).Clone());
			UnknownFieldSet unknownFieldSet = (visibleIfEnumOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return visibleIfEnumOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6005286")]
		[Cpp2IlInjected.Address(RVA = "0x17C45A0", Offset = "0x17C2FA0", VA = "0x1817C45A0", Slot = "0")]
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
				string text = enumFieldName_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<string> repeatedField = validEnumValues_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<string> repeatedField2 = invalidEnumValues_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005287")]
		[Cpp2IlInjected.Address(RVA = "0x17C44E0", Offset = "0x17C2EE0", VA = "0x1817C44E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(VisibleIfEnumOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.enumFieldName_;
				if (!(enumFieldName_ != text))
				{
					RepeatedField<string> repeatedField = validEnumValues_;
					RepeatedField<string> repeatedField2 = other.validEnumValues_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						RepeatedField<string> repeatedField3 = invalidEnumValues_;
						RepeatedField<string> repeatedField4 = other.invalidEnumValues_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005288")]
		[Cpp2IlInjected.Address(RVA = "0x17C4750", Offset = "0x17C3150", VA = "0x1817C4750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004b
			string text = enumFieldName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)validEnumValues_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)invalidEnumValues_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode3;
		}

		[Cpp2IlInjected.Token(Token = "0x6005289")]
		[Cpp2IlInjected.Address(RVA = "0x17C4B40", Offset = "0x17C3540", VA = "0x1817C4B40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600528A")]
		[Cpp2IlInjected.Address(RVA = "0x17C4BA0", Offset = "0x17C35A0", VA = "0x1817C4BA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			if (enumFieldName_.m_stringLength != 0)
			{
				string value = enumFieldName_;
				output.WriteString(value);
			}
			RepeatedField<string> repeatedField = validEnumValues_;
			FieldCodec<string> repeated_validEnumValues_codec = _repeated_validEnumValues_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_validEnumValues_codec);
			RepeatedField<string> repeatedField2 = invalidEnumValues_;
			FieldCodec<string> repeated_invalidEnumValues_codec = _repeated_invalidEnumValues_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_invalidEnumValues_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600528B")]
		[Cpp2IlInjected.Address(RVA = "0x17C4160", Offset = "0x17C2B60", VA = "0x1817C4160", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			string text = enumFieldName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<string> repeatedField = validEnumValues_;
			FieldCodec<string> repeated_validEnumValues_codec = _repeated_validEnumValues_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_validEnumValues_codec);
			RepeatedField<string> repeatedField2 = invalidEnumValues_;
			FieldCodec<string> repeated_invalidEnumValues_codec = _repeated_invalidEnumValues_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_invalidEnumValues_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<string>)(repeatedField + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600528C")]
		[Cpp2IlInjected.Address(RVA = "0x17C4970", Offset = "0x17C3370", VA = "0x1817C4970", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(VisibleIfEnumOptions other)
		{
			//Discarded unreachable code: IL_0067
			if (other != null)
			{
				string text = other.enumFieldName_;
				if (text.m_stringLength != 0)
				{
					EnumFieldName = text;
				}
				RepeatedField<string> repeatedField = validEnumValues_;
				RepeatedField<string> repeatedField2 = other.validEnumValues_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<string> repeatedField3 = invalidEnumValues_;
				RepeatedField<string> repeatedField4 = other.invalidEnumValues_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600528D")]
		[Cpp2IlInjected.Address(RVA = "0x17C4800", Offset = "0x17C3200", VA = "0x1817C4800", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0071
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (EnumFieldName = input.ReadString());
				}
				if (num == 18)
				{
					RepeatedField<string> repeatedField = validEnumValues_;
					FieldCodec<string> repeated_validEnumValues_codec = _repeated_validEnumValues_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_validEnumValues_codec);
				}
				if (num == 26)
				{
					RepeatedField<string> repeatedField2 = invalidEnumValues_;
					FieldCodec<string> repeated_invalidEnumValues_codec = _repeated_invalidEnumValues_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_invalidEnumValues_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600528E")]
		[Cpp2IlInjected.Address(RVA = "0x17C46B0", Offset = "0x17C30B0", VA = "0x1817C46B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<string> repeatedField = invalidEnumValues_;
				RepeatedField<string> repeatedField2 = validEnumValues_;
				string text = enumFieldName_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600528F")]
		[Cpp2IlInjected.Address(RVA = "0x17C4A20", Offset = "0x17C3420", VA = "0x1817C4A20", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			while (true)
			{
				int num = fieldNumber - 1;
				if (num != 0)
				{
					switch (num)
					{
					case 0:
						continue;
					case 1:
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					}
				}
				break;
			}
			int num2 = 0;
			if (value == null || value != null)
			{
				EnumFieldName = (string)num2;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005290")]
		[Cpp2IlInjected.Address(RVA = "0x17C4290", Offset = "0x17C2C90", VA = "0x1817C4290", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0023
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 1)
				{
					return;
				}
				RepeatedField<string> repeatedField = validEnumValues_;
			}
			EnumFieldName = "";
		}

		[Cpp2IlInjected.Token(Token = "0x6005291")]
		[Cpp2IlInjected.Address(RVA = "0x17C4CC0", Offset = "0x17C36C0", VA = "0x1817C4CC0")]
		static VisibleIfEnumOptions()
		{
			Func<VisibleIfEnumOptions> func = default(Func<VisibleIfEnumOptions>);
			_parser = (MessageParser<VisibleIfEnumOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<VisibleIfEnumOptions>)(object)FieldCodec.ForString(18u);
			_parser = (MessageParser<VisibleIfEnumOptions>)(object)FieldCodec.ForString(26u);
			/*Error: Unexpected end of block*/;
		}
	}
}
