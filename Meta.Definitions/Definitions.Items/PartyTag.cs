using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004B9")]
	public sealed class PartyTag : IMessage<PartyTag>, IMessage, IEquatable<PartyTag>, IDeepCloneable<PartyTag>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001940")]
		private static readonly MessageParser<PartyTag> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001941")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001942")]
		public const int TagFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001943")]
		private int tag_;

		[Cpp2IlInjected.Token(Token = "0x4001944")]
		public const int AnimationFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001945")]
		private CharacterAnimation animation_;

		[Cpp2IlInjected.Token(Token = "0x17000EDA")]
		[DebuggerNonUserCode]
		public static MessageParser<PartyTag> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003A35")]
			[Cpp2IlInjected.Address(RVA = "0x36A9D80", Offset = "0x36A8780", VA = "0x1836A9D80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A36")]
			[Cpp2IlInjected.Address(RVA = "0x36A9CB0", Offset = "0x36A86B0", VA = "0x1836A9CB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A37")]
			[Cpp2IlInjected.Address(RVA = "0x36A9DE0", Offset = "0x36A87E0", VA = "0x1836A9DE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDD")]
		[DebuggerNonUserCode]
		public int Tag
		{
			[Cpp2IlInjected.Token(Token = "0x6003A3B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return tag_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A3C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				tag_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDE")]
		[DebuggerNonUserCode]
		public CharacterAnimation Animation
		{
			[Cpp2IlInjected.Token(Token = "0x6003A3D")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return animation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A3E")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				animation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A38")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PartyTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003A39")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public PartyTag(PartyTag other)
		{
			int num = (tag_ = other.tag_);
			CharacterAnimation characterAnimation = (animation_ = other.animation_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3A")]
		[Cpp2IlInjected.Address(RVA = "0x36A9860", Offset = "0x36A8260", VA = "0x1836A9860", Slot = "10")]
		[DebuggerNonUserCode]
		public PartyTag Clone()
		{
			//Discarded unreachable code: IL_0037
			PartyTag partyTag = new PartyTag();
			int num = (partyTag.tag_ = tag_);
			CharacterAnimation characterAnimation = (partyTag.animation_ = animation_);
			UnknownFieldSet unknownFieldSet = (partyTag._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return partyTag;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A3F")]
		[Cpp2IlInjected.Address(RVA = "0x36A98F0", Offset = "0x36A82F0", VA = "0x1836A98F0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)tag_ == (IntPtr)typeof(PartyTag).TypeHandle && (IntPtr)(void*)(int)animation_ == (IntPtr)typeof(PartyTag).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A40")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PartyTag other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.tag_;
				if (tag_ == num)
				{
					CharacterAnimation characterAnimation = other.animation_;
					if (animation_ == characterAnimation)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A41")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (tag_ != 0)
				{
				}
				if (animation_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A42")]
		[Cpp2IlInjected.Address(RVA = "0x36A9B40", Offset = "0x36A8540", VA = "0x1836A9B40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A43")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (tag_ != 0)
			{
				int value = tag_;
				output.WriteInt32(value);
			}
			if (animation_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A44")]
		[Cpp2IlInjected.Address(RVA = "0x36A9790", Offset = "0x36A8190", VA = "0x1836A9790", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = tag_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				CharacterAnimation characterAnimation = animation_;
				if (characterAnimation != 0)
				{
					int num4 = CodedOutputStream.ComputeEnumSize((int)characterAnimation);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A45")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PartyTag other)
		{
			if (other != null)
			{
				int num = other.tag_;
				if (num != 0)
				{
					tag_ = num;
				}
				CharacterAnimation characterAnimation = other.animation_;
				if (characterAnimation != 0)
				{
					animation_ = characterAnimation;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A46")]
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
					int num2 = (tag_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (int)(animation_ = (CharacterAnimation)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A47")]
		[Cpp2IlInjected.Address(RVA = "0x36A9980", Offset = "0x36A8380", VA = "0x1836A9980", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = tag_;
			}
			if (fieldNumber == 2)
			{
				CharacterAnimation characterAnimation = animation_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A48")]
		[Cpp2IlInjected.Address(RVA = "0x36A9A70", Offset = "0x36A8470", VA = "0x1836A9A70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				tag_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			animation_ = (CharacterAnimation)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A49")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				tag_ = 0;
				break;
			case 2:
				animation_ = CharacterAnimation.None;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A4A")]
		[Cpp2IlInjected.Address(RVA = "0x36A9BA0", Offset = "0x36A85A0", VA = "0x1836A9BA0")]
		static PartyTag()
		{
			Func<PartyTag> func = default(Func<PartyTag>);
			_parser = (MessageParser<PartyTag>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
