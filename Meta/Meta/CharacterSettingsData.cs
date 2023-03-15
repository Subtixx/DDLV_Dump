using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008D0")]
	public sealed class CharacterSettingsData : IMessage<CharacterSettingsData>, IMessage, IEquatable<CharacterSettingsData>, IDeepCloneable<CharacterSettingsData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002394")]
		private static readonly MessageParser<CharacterSettingsData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002395")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002396")]
		public const int ProbabilityToBeOutsideFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002397")]
		private int probabilityToBeOutside_;

		[Cpp2IlInjected.Token(Token = "0x4002398")]
		public const int DefaultDiscoveryStatusFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002399")]
		private PreferredItemStatus defaultDiscoveryStatus_;

		[Cpp2IlInjected.Token(Token = "0x17000CC2")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterSettingsData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004B86")]
			[Cpp2IlInjected.Address(RVA = "0x71BB90", Offset = "0x71A590", VA = "0x18071BB90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B87")]
			[Cpp2IlInjected.Address(RVA = "0x71BAC0", Offset = "0x71A4C0", VA = "0x18071BAC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B88")]
			[Cpp2IlInjected.Address(RVA = "0x71BBF0", Offset = "0x71A5F0", VA = "0x18071BBF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC5")]
		[DebuggerNonUserCode]
		public int ProbabilityToBeOutside
		{
			[Cpp2IlInjected.Token(Token = "0x6004B8C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return probabilityToBeOutside_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B8D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				probabilityToBeOutside_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC6")]
		[DebuggerNonUserCode]
		public PreferredItemStatus DefaultDiscoveryStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6004B8E")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return defaultDiscoveryStatus_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B8F")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				defaultDiscoveryStatus_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B89")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CharacterSettingsData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B8A")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public CharacterSettingsData(CharacterSettingsData other)
		{
			int num = (probabilityToBeOutside_ = other.probabilityToBeOutside_);
			PreferredItemStatus preferredItemStatus = (defaultDiscoveryStatus_ = other.defaultDiscoveryStatus_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B8B")]
		[Cpp2IlInjected.Address(RVA = "0x71B5E0", Offset = "0x719FE0", VA = "0x18071B5E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterSettingsData Clone()
		{
			//Discarded unreachable code: IL_0037
			CharacterSettingsData characterSettingsData = new CharacterSettingsData();
			int num = (characterSettingsData.probabilityToBeOutside_ = probabilityToBeOutside_);
			PreferredItemStatus preferredItemStatus = (characterSettingsData.defaultDiscoveryStatus_ = defaultDiscoveryStatus_);
			UnknownFieldSet unknownFieldSet = (characterSettingsData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return characterSettingsData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B90")]
		[Cpp2IlInjected.Address(RVA = "0x71B670", Offset = "0x71A070", VA = "0x18071B670", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)probabilityToBeOutside_ == (IntPtr)typeof(CharacterSettingsData).TypeHandle && (IntPtr)(void*)(int)defaultDiscoveryStatus_ == (IntPtr)typeof(CharacterSettingsData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B91")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterSettingsData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.probabilityToBeOutside_;
				if (probabilityToBeOutside_ == num)
				{
					PreferredItemStatus preferredItemStatus = other.defaultDiscoveryStatus_;
					if (defaultDiscoveryStatus_ == preferredItemStatus)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B92")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (probabilityToBeOutside_ != 0)
				{
				}
				if (defaultDiscoveryStatus_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B93")]
		[Cpp2IlInjected.Address(RVA = "0x71B950", Offset = "0x71A350", VA = "0x18071B950", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B94")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (probabilityToBeOutside_ != 0)
			{
				int value = probabilityToBeOutside_;
				output.WriteInt32(value);
			}
			if (defaultDiscoveryStatus_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B95")]
		[Cpp2IlInjected.Address(RVA = "0x71B510", Offset = "0x719F10", VA = "0x18071B510", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = probabilityToBeOutside_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				PreferredItemStatus preferredItemStatus = defaultDiscoveryStatus_;
				if (preferredItemStatus != 0)
				{
					int num4 = CodedOutputStream.ComputeEnumSize((int)preferredItemStatus);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B96")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterSettingsData other)
		{
			if (other != null)
			{
				int num = other.probabilityToBeOutside_;
				if (num != 0)
				{
					probabilityToBeOutside_ = num;
				}
				PreferredItemStatus preferredItemStatus = other.defaultDiscoveryStatus_;
				if (preferredItemStatus != 0)
				{
					defaultDiscoveryStatus_ = preferredItemStatus;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B97")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (probabilityToBeOutside_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (int)(defaultDiscoveryStatus_ = (PreferredItemStatus)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B98")]
		[Cpp2IlInjected.Address(RVA = "0x71B700", Offset = "0x71A100", VA = "0x18071B700", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = probabilityToBeOutside_;
			}
			if (fieldNumber == 2)
			{
				PreferredItemStatus preferredItemStatus = defaultDiscoveryStatus_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B99")]
		[Cpp2IlInjected.Address(RVA = "0x71B880", Offset = "0x71A280", VA = "0x18071B880", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0011, IL_0017
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				probabilityToBeOutside_ = (int)obj;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B9A")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				probabilityToBeOutside_ = 0;
				break;
			case 2:
				defaultDiscoveryStatus_ = PreferredItemStatus.Unknown;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B9B")]
		[Cpp2IlInjected.Address(RVA = "0x71B9B0", Offset = "0x71A3B0", VA = "0x18071B9B0")]
		static CharacterSettingsData()
		{
			Func<CharacterSettingsData> func = default(Func<CharacterSettingsData>);
			_parser = (MessageParser<CharacterSettingsData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
