using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class LiveopsMetadata : IMessage<LiveopsMetadata>, IMessage, IEquatable<LiveopsMetadata>, IDeepCloneable<LiveopsMetadata>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private static readonly MessageParser<LiveopsMetadata> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public const int MinVersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private string minVersion_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		public static MessageParser<LiveopsMetadata> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2747EB0", Offset = "0x27468B0", VA = "0x182747EB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2747DE0", Offset = "0x27467E0", VA = "0x182747DE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x2747F10", Offset = "0x2746910", VA = "0x182747F10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public string MinVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return minVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x2748020", Offset = "0x2746A20", VA = "0x182748020")]
			set
			{
				string text = (minVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x2747CF0", Offset = "0x27466F0", VA = "0x182747CF0")]
		[DebuggerNonUserCode]
		public LiveopsMetadata()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2747D40", Offset = "0x2746740", VA = "0x182747D40")]
		[DebuggerNonUserCode]
		public LiveopsMetadata(LiveopsMetadata other)
		{
			string text = (minVersion_ = other.minVersion_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x27477E0", Offset = "0x27461E0", VA = "0x1827477E0", Slot = "10")]
		[DebuggerNonUserCode]
		public LiveopsMetadata Clone()
		{
			//Discarded unreachable code: IL_0034
			LiveopsMetadata liveopsMetadata = new LiveopsMetadata();
			liveopsMetadata.minVersion_ = "";
			string text = (liveopsMetadata.minVersion_ = minVersion_);
			UnknownFieldSet unknownFieldSet = (liveopsMetadata._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return liveopsMetadata;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x27478A0", Offset = "0x27462A0", VA = "0x1827478A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = minVersion_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LiveopsMetadata other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.minVersion_;
				if (!(minVersion_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = minVersion_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2747B80", Offset = "0x2746580", VA = "0x182747B80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (minVersion_.m_stringLength != 0)
			{
				string value = minVersion_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x27476B0", Offset = "0x27460B0", VA = "0x1827476B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = minVersion_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x27479D0", Offset = "0x27463D0", VA = "0x1827479D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LiveopsMetadata other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.minVersion_;
				if (text.m_stringLength != 0)
				{
					MinVersion = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2747A30", Offset = "0x2746430", VA = "0x182747A30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (MinVersion = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2747950", Offset = "0x2746350", VA = "0x182747950", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = minVersion_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2747AC0", Offset = "0x27464C0", VA = "0x182747AC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (minVersion_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2747750", Offset = "0x2746150", VA = "0x182747750", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (minVersion_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2747BE0", Offset = "0x27465E0", VA = "0x182747BE0")]
		static LiveopsMetadata()
		{
			Func<LiveopsMetadata> func = default(Func<LiveopsMetadata>);
			_parser = (MessageParser<LiveopsMetadata>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
