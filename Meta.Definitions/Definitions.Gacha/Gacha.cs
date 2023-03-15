using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x2000723")]
	public sealed class Gacha : IMessage<Gacha>, IMessage, IEquatable<Gacha>, IDeepCloneable<Gacha>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023D9")]
		private static readonly MessageParser<Gacha> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023DA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023DB")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023DC")]
		private string id_ = "";

		[Cpp2IlInjected.Token(Token = "0x40023DD")]
		public const int PullsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40023DE")]
		private static readonly FieldCodec<GachaPull> _repeated_pulls_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023DF")]
		private readonly RepeatedField<GachaPull> pulls_ = (RepeatedField<GachaPull>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001432")]
		[DebuggerNonUserCode]
		public static MessageParser<Gacha> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F2A")]
			[Cpp2IlInjected.Address(RVA = "0x218D6F0", Offset = "0x218C0F0", VA = "0x18218D6F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001433")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F2B")]
			[Cpp2IlInjected.Address(RVA = "0x218D620", Offset = "0x218C020", VA = "0x18218D620")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001434")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F2C")]
			[Cpp2IlInjected.Address(RVA = "0x218D750", Offset = "0x218C150", VA = "0x18218D750", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001435")]
		[DebuggerNonUserCode]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6004F30")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F31")]
			[Cpp2IlInjected.Address(RVA = "0x218D860", Offset = "0x218C260", VA = "0x18218D860")]
			set
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001436")]
		[DebuggerNonUserCode]
		public RepeatedField<GachaPull> Pulls
		{
			[Cpp2IlInjected.Token(Token = "0x6004F32")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return pulls_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2D")]
		[Cpp2IlInjected.Address(RVA = "0x218D440", Offset = "0x218BE40", VA = "0x18218D440")]
		[DebuggerNonUserCode]
		public Gacha()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2E")]
		[Cpp2IlInjected.Address(RVA = "0x218D4E0", Offset = "0x218BEE0", VA = "0x18218D4E0")]
		[DebuggerNonUserCode]
		public Gacha(Gacha other)
		{
			string text = (id_ = other.id_);
			RepeatedField<GachaPull> repeatedField = (pulls_ = (RepeatedField<GachaPull>)(object)((RepeatedField<T>)(object)other.pulls_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2F")]
		[Cpp2IlInjected.Address(RVA = "0x218CA50", Offset = "0x218B450", VA = "0x18218CA50", Slot = "10")]
		[DebuggerNonUserCode]
		public Gacha Clone()
		{
			//Discarded unreachable code: IL_0056
			Gacha gacha = new Gacha();
			gacha.id_ = "";
			RepeatedField<GachaPull> repeatedField = (gacha.pulls_ = (RepeatedField<GachaPull>)(object)new RepeatedField<T>());
			string text = (gacha.id_ = id_);
			RepeatedField<GachaPull> repeatedField2 = (gacha.pulls_ = (RepeatedField<GachaPull>)(object)((RepeatedField<T>)(object)pulls_).Clone());
			UnknownFieldSet unknownFieldSet = (gacha._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gacha;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F33")]
		[Cpp2IlInjected.Address(RVA = "0x218CBB0", Offset = "0x218B5B0", VA = "0x18218CBB0", Slot = "0")]
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
				string text = id_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<GachaPull> repeatedField = pulls_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F34")]
		[Cpp2IlInjected.Address(RVA = "0x218CCA0", Offset = "0x218B6A0", VA = "0x18218CCA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Gacha other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.id_;
				if (!(id_ != text))
				{
					RepeatedField<GachaPull> repeatedField = pulls_;
					RepeatedField<GachaPull> repeatedField2 = other.pulls_;
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

		[Cpp2IlInjected.Token(Token = "0x6004F35")]
		[Cpp2IlInjected.Address(RVA = "0x218CDE0", Offset = "0x218B7E0", VA = "0x18218CDE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0038
			string text = id_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)pulls_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F36")]
		[Cpp2IlInjected.Address(RVA = "0x218D120", Offset = "0x218BB20", VA = "0x18218D120", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F37")]
		[Cpp2IlInjected.Address(RVA = "0x218D180", Offset = "0x218BB80", VA = "0x18218D180", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0044
			if (id_.m_stringLength != 0)
			{
				string value = id_;
				output.WriteString(value);
			}
			RepeatedField<GachaPull> repeatedField = pulls_;
			FieldCodec<GachaPull> repeated_pulls_codec = _repeated_pulls_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_pulls_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F38")]
		[Cpp2IlInjected.Address(RVA = "0x218C880", Offset = "0x218B280", VA = "0x18218C880", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0053
			string text = id_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<GachaPull> repeatedField = pulls_;
			FieldCodec<GachaPull> repeated_pulls_codec = _repeated_pulls_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_pulls_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F39")]
		[Cpp2IlInjected.Address(RVA = "0x218CE60", Offset = "0x218B860", VA = "0x18218CE60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Gacha other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.id_;
				if (text.m_stringLength != 0)
				{
					Id = text;
				}
				RepeatedField<GachaPull> repeatedField = pulls_;
				RepeatedField<GachaPull> repeatedField2 = other.pulls_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3A")]
		[Cpp2IlInjected.Address(RVA = "0x218CF00", Offset = "0x218B900", VA = "0x18218CF00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0052
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Id = input.ReadString());
				}
				if (num == 18)
				{
					RepeatedField<GachaPull> repeatedField = pulls_;
					FieldCodec<GachaPull> repeated_pulls_codec = _repeated_pulls_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_pulls_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3B")]
		[Cpp2IlInjected.Address(RVA = "0x218CD50", Offset = "0x218B750", VA = "0x18218CD50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = id_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<GachaPull> repeatedField = pulls_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3C")]
		[Cpp2IlInjected.Address(RVA = "0x218D010", Offset = "0x218BA10", VA = "0x18218D010", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					string text = (id_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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

		[Cpp2IlInjected.Token(Token = "0x6004F3D")]
		[Cpp2IlInjected.Address(RVA = "0x218C980", Offset = "0x218B380", VA = "0x18218C980", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull("", "value"));
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<GachaPull> repeatedField = pulls_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3E")]
		[Cpp2IlInjected.Address(RVA = "0x218D270", Offset = "0x218BC70", VA = "0x18218D270")]
		static Gacha()
		{
			Func<Gacha> func = default(Func<Gacha>);
			_parser = (MessageParser<Gacha>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<GachaPull> parser = GachaPull._parser;
			uint num = default(uint);
			_parser = (MessageParser<Gacha>)(object)FieldCodec.ForMessage<GachaPull>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
