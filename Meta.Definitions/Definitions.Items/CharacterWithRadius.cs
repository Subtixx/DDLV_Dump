using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200051B")]
	public sealed class CharacterWithRadius : IMessage<CharacterWithRadius>, IMessage, IEquatable<CharacterWithRadius>, IDeepCloneable<CharacterWithRadius>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001B3D")]
		private static readonly MessageParser<CharacterWithRadius> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B3E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B3F")]
		public const int CharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B40")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x4001B41")]
		public const int RadiusFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001B42")]
		private int radius_;

		[Cpp2IlInjected.Token(Token = "0x17001041")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterWithRadius> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003F4F")]
			[Cpp2IlInjected.Address(RVA = "0x28A4FD0", Offset = "0x28A39D0", VA = "0x1828A4FD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001042")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F50")]
			[Cpp2IlInjected.Address(RVA = "0x28A4F00", Offset = "0x28A3900", VA = "0x1828A4F00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001043")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F51")]
			[Cpp2IlInjected.Address(RVA = "0x28A5030", Offset = "0x28A3A30", VA = "0x1828A5030", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001044")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x6003F55")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F56")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001045")]
		[DebuggerNonUserCode]
		public int Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6003F57")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return radius_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F58")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				radius_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F52")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CharacterWithRadius()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003F53")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public CharacterWithRadius(CharacterWithRadius other)
		{
			int num = (character_ = other.character_);
			int num2 = (radius_ = other.radius_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F54")]
		[Cpp2IlInjected.Address(RVA = "0x28A4AF0", Offset = "0x28A34F0", VA = "0x1828A4AF0", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterWithRadius Clone()
		{
			//Discarded unreachable code: IL_0037
			CharacterWithRadius characterWithRadius = new CharacterWithRadius();
			int num = (characterWithRadius.character_ = character_);
			int num2 = (characterWithRadius.radius_ = radius_);
			UnknownFieldSet unknownFieldSet = (characterWithRadius._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return characterWithRadius;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F59")]
		[Cpp2IlInjected.Address(RVA = "0x28A4B80", Offset = "0x28A3580", VA = "0x1828A4B80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)character_ == (IntPtr)typeof(CharacterWithRadius).TypeHandle && (IntPtr)radius_ == (IntPtr)typeof(CharacterWithRadius).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F5A")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterWithRadius other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.character_;
				if (character_ == num)
				{
					int num2 = other.radius_;
					if (radius_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F5B")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (character_ != 0)
				{
				}
				if (radius_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F5C")]
		[Cpp2IlInjected.Address(RVA = "0x28A4D90", Offset = "0x28A3790", VA = "0x1828A4D90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F5D")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (character_ != 0)
			{
				int value = character_;
				output.WriteInt32(value);
			}
			if (radius_ != 0)
			{
				int value2 = radius_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F5E")]
		[Cpp2IlInjected.Address(RVA = "0x28A4A20", Offset = "0x28A3420", VA = "0x1828A4A20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = character_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = radius_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F5F")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterWithRadius other)
		{
			if (other != null)
			{
				int num = other.character_;
				if (num != 0)
				{
					character_ = num;
				}
				int num2 = other.radius_;
				if (num2 != 0)
				{
					radius_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F60")]
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
					int num2 = (character_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (radius_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F61")]
		[Cpp2IlInjected.Address(RVA = "0x28A4C10", Offset = "0x28A3610", VA = "0x1828A4C10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = character_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F62")]
		[Cpp2IlInjected.Address(RVA = "0x28A4CD0", Offset = "0x28A36D0", VA = "0x1828A4CD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				character_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			radius_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F63")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				character_ = 0;
				break;
			case 2:
				radius_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F64")]
		[Cpp2IlInjected.Address(RVA = "0x28A4DF0", Offset = "0x28A37F0", VA = "0x1828A4DF0")]
		static CharacterWithRadius()
		{
			Func<CharacterWithRadius> func = default(Func<CharacterWithRadius>);
			_parser = (MessageParser<CharacterWithRadius>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
