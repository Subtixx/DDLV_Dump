using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x2000721")]
	public sealed class GachaPull : IMessage<GachaPull>, IMessage, IEquatable<GachaPull>, IDeepCloneable<GachaPull>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023D1")]
		private static readonly MessageParser<GachaPull> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023D2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023D3")]
		public const int TableFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023D4")]
		private static readonly FieldCodec<GachaTable> _repeated_table_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023D5")]
		private readonly RepeatedField<GachaTable> table_ = (RepeatedField<GachaTable>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40023D6")]
		public const int PullsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023D7")]
		private int pulls_;

		[Cpp2IlInjected.Token(Token = "0x1700142D")]
		[DebuggerNonUserCode]
		public static MessageParser<GachaPull> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F12")]
			[Cpp2IlInjected.Address(RVA = "0x218A110", Offset = "0x2188B10", VA = "0x18218A110")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F13")]
			[Cpp2IlInjected.Address(RVA = "0x218A040", Offset = "0x2188A40", VA = "0x18218A040")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F14")]
			[Cpp2IlInjected.Address(RVA = "0x218A170", Offset = "0x2188B70", VA = "0x18218A170", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001430")]
		[DebuggerNonUserCode]
		public RepeatedField<GachaTable> Table
		{
			[Cpp2IlInjected.Token(Token = "0x6004F18")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return table_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001431")]
		[DebuggerNonUserCode]
		public int Pulls
		{
			[Cpp2IlInjected.Token(Token = "0x6004F19")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return pulls_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F1A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				pulls_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F15")]
		[Cpp2IlInjected.Address(RVA = "0x2189EC0", Offset = "0x21888C0", VA = "0x182189EC0")]
		[DebuggerNonUserCode]
		public GachaPull()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F16")]
		[Cpp2IlInjected.Address(RVA = "0x2189F40", Offset = "0x2188940", VA = "0x182189F40")]
		[DebuggerNonUserCode]
		public GachaPull(GachaPull other)
		{
			RepeatedField<GachaTable> repeatedField = (table_ = (RepeatedField<GachaTable>)(object)((RepeatedField<T>)(object)other.table_).Clone());
			int num = (pulls_ = other.pulls_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F17")]
		[Cpp2IlInjected.Address(RVA = "0x21895D0", Offset = "0x2187FD0", VA = "0x1821895D0", Slot = "10")]
		[DebuggerNonUserCode]
		public GachaPull Clone()
		{
			//Discarded unreachable code: IL_004b
			GachaPull gachaPull = new GachaPull();
			RepeatedField<GachaTable> repeatedField = (gachaPull.table_ = (RepeatedField<GachaTable>)(object)new RepeatedField<T>());
			RepeatedField<GachaTable> repeatedField2 = (gachaPull.table_ = (RepeatedField<GachaTable>)(object)((RepeatedField<T>)(object)table_).Clone());
			int num = (gachaPull.pulls_ = pulls_);
			UnknownFieldSet unknownFieldSet = (gachaPull._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gachaPull;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1B")]
		[Cpp2IlInjected.Address(RVA = "0x21897A0", Offset = "0x21881A0", VA = "0x1821897A0", Slot = "0")]
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
				RepeatedField<GachaTable> repeatedField = table_;
				bool flag = default(bool);
				if (flag && pulls_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1C")]
		[Cpp2IlInjected.Address(RVA = "0x2189700", Offset = "0x2188100", VA = "0x182189700", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GachaPull other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<GachaTable> repeatedField = table_;
				RepeatedField<GachaTable> repeatedField2 = other.table_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.pulls_;
					if (pulls_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1D")]
		[Cpp2IlInjected.Address(RVA = "0x18BBB60", Offset = "0x18BA560", VA = "0x1818BBB60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			int hashCode = ((RepeatedField<T>)(object)table_).GetHashCode();
			if (pulls_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1E")]
		[Cpp2IlInjected.Address(RVA = "0x2189BB0", Offset = "0x21885B0", VA = "0x182189BB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1F")]
		[Cpp2IlInjected.Address(RVA = "0x2189C10", Offset = "0x2188610", VA = "0x182189C10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			RepeatedField<GachaTable> repeatedField = table_;
			FieldCodec<GachaTable> repeated_table_codec = _repeated_table_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_table_codec);
			if (pulls_ != 0)
			{
				int value = pulls_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F20")]
		[Cpp2IlInjected.Address(RVA = "0x2189470", Offset = "0x2187E70", VA = "0x182189470", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			RepeatedField<GachaTable> repeatedField = table_;
			FieldCodec<GachaTable> repeated_table_codec = _repeated_table_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_table_codec);
			int num2 = pulls_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F21")]
		[Cpp2IlInjected.Address(RVA = "0x2189950", Offset = "0x2188350", VA = "0x182189950", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GachaPull other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				RepeatedField<GachaTable> repeatedField = table_;
				RepeatedField<GachaTable> repeatedField2 = other.table_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.pulls_;
				if (num != 0)
				{
					pulls_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F22")]
		[Cpp2IlInjected.Address(RVA = "0x21899E0", Offset = "0x21883E0", VA = "0x1821899E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0052
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<GachaTable> repeatedField = table_;
					FieldCodec<GachaTable> repeated_table_codec = _repeated_table_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_table_codec);
				}
				if (num == 16)
				{
					int num2 = (pulls_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F23")]
		[Cpp2IlInjected.Address(RVA = "0x2189880", Offset = "0x2188280", VA = "0x182189880", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<GachaTable> repeatedField = table_;
			}
			if (fieldNumber == 2)
			{
				int num = pulls_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F24")]
		[Cpp2IlInjected.Address(RVA = "0x2189AE0", Offset = "0x21884E0", VA = "0x182189AE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0010
			//IL_000f: Expected I4, but got O
			switch (fieldNumber)
			{
			case 2:
			{
				object obj = default(object);
				pulls_ = (int)obj;
				break;
			}
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F25")]
		[Cpp2IlInjected.Address(RVA = "0x2189560", Offset = "0x2187F60", VA = "0x182189560", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				RepeatedField<GachaTable> repeatedField = table_;
			}
			if (fieldNumber == 2)
			{
				pulls_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F26")]
		[Cpp2IlInjected.Address(RVA = "0x2189CF0", Offset = "0x21886F0", VA = "0x182189CF0")]
		static GachaPull()
		{
			Func<GachaPull> func = default(Func<GachaPull>);
			_parser = (MessageParser<GachaPull>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<GachaTable> parser = GachaTable._parser;
			uint num = default(uint);
			_parser = (MessageParser<GachaPull>)(object)FieldCodec.ForMessage<GachaTable>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
