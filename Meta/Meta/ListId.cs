using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000900")]
	public sealed class ListId : IMessage<ListId>, IMessage, IEquatable<ListId>, IDeepCloneable<ListId>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002474")]
		private static readonly MessageParser<ListId> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002475")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002476")]
		public const int IdsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002477")]
		private static readonly FieldCodec<string> _repeated_ids_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002478")]
		private readonly RepeatedField<string> ids_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000D4F")]
		[DebuggerNonUserCode]
		public static MessageParser<ListId> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E33")]
			[Cpp2IlInjected.Address(RVA = "0x18A70F0", Offset = "0x18A5AF0", VA = "0x1818A70F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D50")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E34")]
			[Cpp2IlInjected.Address(RVA = "0x18A7020", Offset = "0x18A5A20", VA = "0x1818A7020")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D51")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E35")]
			[Cpp2IlInjected.Address(RVA = "0x18A7150", Offset = "0x18A5B50", VA = "0x1818A7150", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D52")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Ids
		{
			[Cpp2IlInjected.Token(Token = "0x6004E39")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return ids_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E36")]
		[Cpp2IlInjected.Address(RVA = "0x18A6EA0", Offset = "0x18A58A0", VA = "0x1818A6EA0")]
		[DebuggerNonUserCode]
		public ListId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E37")]
		[Cpp2IlInjected.Address(RVA = "0x18A6F20", Offset = "0x18A5920", VA = "0x1818A6F20")]
		[DebuggerNonUserCode]
		public ListId(ListId other)
		{
			RepeatedField<string> repeatedField = (ids_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.ids_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E38")]
		[Cpp2IlInjected.Address(RVA = "0x18A6750", Offset = "0x18A5150", VA = "0x1818A6750", Slot = "10")]
		[DebuggerNonUserCode]
		public ListId Clone()
		{
			//Discarded unreachable code: IL_003b
			ListId listId = new ListId();
			RepeatedField<string> repeatedField = (listId.ids_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			RepeatedField<string> repeatedField2 = (listId.ids_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)ids_).Clone());
			UnknownFieldSet unknownFieldSet = (listId._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return listId;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3A")]
		[Cpp2IlInjected.Address(RVA = "0x18A6910", Offset = "0x18A5310", VA = "0x1818A6910", Slot = "0")]
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
				RepeatedField<string> repeatedField = ids_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3B")]
		[Cpp2IlInjected.Address(RVA = "0x18A6880", Offset = "0x18A5280", VA = "0x1818A6880", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ListId other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<string> repeatedField = ids_;
				RepeatedField<string> repeatedField2 = other.ids_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)ids_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3D")]
		[Cpp2IlInjected.Address(RVA = "0x18A6C40", Offset = "0x18A5640", VA = "0x1818A6C40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3E")]
		[Cpp2IlInjected.Address(RVA = "0x18A6CA0", Offset = "0x18A56A0", VA = "0x1818A6CA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<string> repeatedField = ids_;
			FieldCodec<string> repeated_ids_codec = _repeated_ids_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_ids_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3F")]
		[Cpp2IlInjected.Address(RVA = "0x18A6640", Offset = "0x18A5040", VA = "0x1818A6640", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<string> repeatedField = ids_;
			FieldCodec<string> repeated_ids_codec = _repeated_ids_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_ids_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E40")]
		[Cpp2IlInjected.Address(RVA = "0x18A6A70", Offset = "0x18A5470", VA = "0x1818A6A70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ListId other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<string> repeatedField = ids_;
				RepeatedField<string> repeatedField2 = other.ids_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E41")]
		[Cpp2IlInjected.Address(RVA = "0x18A6AF0", Offset = "0x18A54F0", VA = "0x1818A6AF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<string> repeatedField = ids_;
					FieldCodec<string> repeated_ids_codec = _repeated_ids_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ids_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E42")]
		[Cpp2IlInjected.Address(RVA = "0x18A69F0", Offset = "0x18A53F0", VA = "0x1818A69F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<string> repeatedField = ids_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E43")]
		[Cpp2IlInjected.Address(RVA = "0x18A6BE0", Offset = "0x18A55E0", VA = "0x1818A6BE0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004E44")]
		[Cpp2IlInjected.Address(RVA = "0x18A66F0", Offset = "0x18A50F0", VA = "0x1818A66F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<string> repeatedField = ids_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E45")]
		[Cpp2IlInjected.Address(RVA = "0x18A6D60", Offset = "0x18A5760", VA = "0x1818A6D60")]
		static ListId()
		{
			Func<ListId> func = default(Func<ListId>);
			_parser = (MessageParser<ListId>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ListId>)(object)FieldCodec.ForString(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
