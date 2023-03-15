using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x20007B4")]
	public sealed class ChoiceOptionsOneOf : IMessage<ChoiceOptionsOneOf>, IMessage, IEquatable<ChoiceOptionsOneOf>, IDeepCloneable<ChoiceOptionsOneOf>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400268C")]
		private static readonly MessageParser<ChoiceOptionsOneOf> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400268D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400268E")]
		public const int RenamesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400268F")]
		private static readonly FieldCodec<ChoiceRenameOneOf> _repeated_renames_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002690")]
		private readonly RepeatedField<ChoiceRenameOneOf> renames_ = (RepeatedField<ChoiceRenameOneOf>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700156D")]
		[DebuggerNonUserCode]
		public static MessageParser<ChoiceOptionsOneOf> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60054C1")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8D70", Offset = "0x2EB7770", VA = "0x182EB8D70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700156E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60054C2")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8CA0", Offset = "0x2EB76A0", VA = "0x182EB8CA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700156F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60054C3")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8DD0", Offset = "0x2EB77D0", VA = "0x182EB8DD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001570")]
		[DebuggerNonUserCode]
		public RepeatedField<ChoiceRenameOneOf> Renames
		{
			[Cpp2IlInjected.Token(Token = "0x60054C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return renames_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8B20", Offset = "0x2EB7520", VA = "0x182EB8B20")]
		[DebuggerNonUserCode]
		public ChoiceOptionsOneOf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60054C5")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8BA0", Offset = "0x2EB75A0", VA = "0x182EB8BA0")]
		[DebuggerNonUserCode]
		public ChoiceOptionsOneOf(ChoiceOptionsOneOf other)
		{
			RepeatedField<ChoiceRenameOneOf> repeatedField = (renames_ = (RepeatedField<ChoiceRenameOneOf>)(object)((RepeatedField<T>)(object)other.renames_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054C6")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8340", Offset = "0x2EB6D40", VA = "0x182EB8340", Slot = "10")]
		[DebuggerNonUserCode]
		public ChoiceOptionsOneOf Clone()
		{
			//Discarded unreachable code: IL_003b
			ChoiceOptionsOneOf choiceOptionsOneOf = new ChoiceOptionsOneOf();
			RepeatedField<ChoiceRenameOneOf> repeatedField = (choiceOptionsOneOf.renames_ = (RepeatedField<ChoiceRenameOneOf>)(object)new RepeatedField<T>());
			RepeatedField<ChoiceRenameOneOf> repeatedField2 = (choiceOptionsOneOf.renames_ = (RepeatedField<ChoiceRenameOneOf>)(object)((RepeatedField<T>)(object)renames_).Clone());
			UnknownFieldSet unknownFieldSet = (choiceOptionsOneOf._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return choiceOptionsOneOf;
		}

		[Cpp2IlInjected.Token(Token = "0x60054C8")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8470", Offset = "0x2EB6E70", VA = "0x182EB8470", Slot = "0")]
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
				RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054C9")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8550", Offset = "0x2EB6F50", VA = "0x182EB8550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChoiceOptionsOneOf other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
				RepeatedField<ChoiceRenameOneOf> repeatedField2 = other.renames_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)renames_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60054CB")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8830", Offset = "0x2EB7230", VA = "0x182EB8830", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60054CC")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8890", Offset = "0x2EB7290", VA = "0x182EB8890", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
			FieldCodec<ChoiceRenameOneOf> repeated_renames_codec = _repeated_renames_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_renames_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60054CD")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8230", Offset = "0x2EB6C30", VA = "0x182EB8230", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
			FieldCodec<ChoiceRenameOneOf> repeated_renames_codec = _repeated_renames_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_renames_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60054CE")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8660", Offset = "0x2EB7060", VA = "0x182EB8660", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChoiceOptionsOneOf other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
				RepeatedField<ChoiceRenameOneOf> repeatedField2 = other.renames_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054CF")]
		[Cpp2IlInjected.Address(RVA = "0x2EB86E0", Offset = "0x2EB70E0", VA = "0x182EB86E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
					FieldCodec<ChoiceRenameOneOf> repeated_renames_codec = _repeated_renames_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_renames_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054D0")]
		[Cpp2IlInjected.Address(RVA = "0x2EB85E0", Offset = "0x2EB6FE0", VA = "0x182EB85E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60054D1")]
		[Cpp2IlInjected.Address(RVA = "0x2EB87D0", Offset = "0x2EB71D0", VA = "0x182EB87D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60054D2")]
		[Cpp2IlInjected.Address(RVA = "0x2EB82E0", Offset = "0x2EB6CE0", VA = "0x182EB82E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ChoiceRenameOneOf> repeatedField = renames_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054D3")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8950", Offset = "0x2EB7350", VA = "0x182EB8950")]
		static ChoiceOptionsOneOf()
		{
			Func<ChoiceOptionsOneOf> func = default(Func<ChoiceOptionsOneOf>);
			_parser = (MessageParser<ChoiceOptionsOneOf>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ChoiceRenameOneOf> parser = ChoiceRenameOneOf._parser;
			uint num = default(uint);
			_parser = (MessageParser<ChoiceOptionsOneOf>)(object)FieldCodec.ForMessage<ChoiceRenameOneOf>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
