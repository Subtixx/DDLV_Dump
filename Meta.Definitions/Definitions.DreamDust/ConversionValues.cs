using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.DreamDust
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public sealed class ConversionValues : IMessage<ConversionValues>, IMessage, IEquatable<ConversionValues>, IDeepCloneable<ConversionValues>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private static readonly MessageParser<ConversionValues> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public const int FurniturePerStarFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private int furniturePerStar_;

		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public const int ClothingPerStarFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private int clothingPerStar_;

		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public const int CharacterFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x17000383")]
		[DebuggerNonUserCode]
		public static MessageParser<ConversionValues> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA6")]
			[Cpp2IlInjected.Address(RVA = "0x327F750", Offset = "0x327E150", VA = "0x18327F750")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000384")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA7")]
			[Cpp2IlInjected.Address(RVA = "0x327F680", Offset = "0x327E080", VA = "0x18327F680")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000385")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA8")]
			[Cpp2IlInjected.Address(RVA = "0x327F7B0", Offset = "0x327E1B0", VA = "0x18327F7B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000386")]
		[DebuggerNonUserCode]
		public int FurniturePerStar
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return furniturePerStar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EAD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				furniturePerStar_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000387")]
		[DebuggerNonUserCode]
		public int ClothingPerStar
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAE")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return clothingPerStar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EAF")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				clothingPerStar_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000388")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB0")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EB1")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConversionValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAA")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public ConversionValues(ConversionValues other)
		{
			int num = (furniturePerStar_ = other.furniturePerStar_);
			int num2 = (clothingPerStar_ = other.clothingPerStar_);
			int num3 = (character_ = other.character_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAB")]
		[Cpp2IlInjected.Address(RVA = "0x327F200", Offset = "0x327DC00", VA = "0x18327F200", Slot = "10")]
		[DebuggerNonUserCode]
		public ConversionValues Clone()
		{
			//Discarded unreachable code: IL_0047
			ConversionValues conversionValues = new ConversionValues();
			int num = (conversionValues.furniturePerStar_ = furniturePerStar_);
			int num2 = (conversionValues.clothingPerStar_ = clothingPerStar_);
			int num3 = (conversionValues.character_ = character_);
			UnknownFieldSet unknownFieldSet = (conversionValues._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conversionValues;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB2")]
		[Cpp2IlInjected.Address(RVA = "0x327F290", Offset = "0x327DC90", VA = "0x18327F290", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)furniturePerStar_ == (IntPtr)typeof(ConversionValues).TypeHandle && (IntPtr)clothingPerStar_ == (IntPtr)typeof(ConversionValues).TypeHandle && (IntPtr)character_ == (IntPtr)typeof(ConversionValues).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB3")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConversionValues other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.furniturePerStar_;
				if (furniturePerStar_ == num)
				{
					int num2 = other.clothingPerStar_;
					if (clothingPerStar_ == num2)
					{
						int num3 = other.character_;
						if (character_ == num3)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB4")]
		[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C20F0", VA = "0x1825C36F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (furniturePerStar_ != 0)
				{
				}
				if (clothingPerStar_ != 0)
				{
				}
				if (character_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB5")]
		[Cpp2IlInjected.Address(RVA = "0x327F510", Offset = "0x327DF10", VA = "0x18327F510", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB6")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (furniturePerStar_ != 0)
			{
				int value = furniturePerStar_;
				output.WriteInt32(value);
			}
			if (clothingPerStar_ != 0)
			{
				int value2 = clothingPerStar_;
				output.WriteInt32(value2);
			}
			if (character_ != 0)
			{
				int value3 = character_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB7")]
		[Cpp2IlInjected.Address(RVA = "0x327F100", Offset = "0x327DB00", VA = "0x18327F100", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = furniturePerStar_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = clothingPerStar_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = character_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB8")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConversionValues other)
		{
			if (other != null)
			{
				int num = other.furniturePerStar_;
				if (num != 0)
				{
					furniturePerStar_ = num;
				}
				int num2 = other.clothingPerStar_;
				if (num2 != 0)
				{
					clothingPerStar_ = num2;
				}
				int num3 = other.character_;
				if (num3 != 0)
				{
					character_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB9")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (furniturePerStar_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (clothingPerStar_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (character_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBA")]
		[Cpp2IlInjected.Address(RVA = "0x327F330", Offset = "0x327DD30", VA = "0x18327F330", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = furniturePerStar_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBB")]
		[Cpp2IlInjected.Address(RVA = "0x327F400", Offset = "0x327DE00", VA = "0x18327F400", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					character_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					clothingPerStar_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				furniturePerStar_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBC")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				character_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBD")]
		[Cpp2IlInjected.Address(RVA = "0x327F570", Offset = "0x327DF70", VA = "0x18327F570")]
		static ConversionValues()
		{
			Func<ConversionValues> func = default(Func<ConversionValues>);
			_parser = (MessageParser<ConversionValues>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
