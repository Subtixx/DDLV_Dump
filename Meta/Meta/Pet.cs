using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000892")]
	public sealed class Pet : IMessage<Pet>, IMessage, IEquatable<Pet>, IDeepCloneable<Pet>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002279")]
		private static readonly MessageParser<Pet> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400227A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400227B")]
		public const int PetItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400227C")]
		private int petItemID_;

		[Cpp2IlInjected.Token(Token = "0x17000C1D")]
		[DebuggerNonUserCode]
		public static MessageParser<Pet> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60048BB")]
			[Cpp2IlInjected.Address(RVA = "0x7B1FA0", Offset = "0x7B09A0", VA = "0x1807B1FA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048BC")]
			[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B08D0", VA = "0x1807B1ED0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C1F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B2060", Offset = "0x7B0A60", VA = "0x1807B2060", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C20")]
		[DebuggerNonUserCode]
		public int PetItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60048C1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return petItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60048C2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				petItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C21")]
		public Item PetItem
		{
			[Cpp2IlInjected.Token(Token = "0x60048CE")]
			[Cpp2IlInjected.Address(RVA = "0x7B2000", Offset = "0x7B0A00", VA = "0x1807B2000")]
			get
			{
				long num = Convert.ToInt64((uint)petItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x60048CF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				petItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048BE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Pet()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public Pet(Pet other)
		{
			int num = (petItemID_ = other.petItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B20", Offset = "0x7B0520", VA = "0x1807B1B20", Slot = "10")]
		[DebuggerNonUserCode]
		public Pet Clone()
		{
			//Discarded unreachable code: IL_0029
			Pet pet = new Pet();
			int num = (pet.petItemID_ = petItemID_);
			UnknownFieldSet unknownFieldSet = (pet._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pet;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BA0", Offset = "0x7B05A0", VA = "0x1807B1BA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)petItemID_ == (IntPtr)typeof(Pet).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Pet other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.petItemID_;
				if (petItemID_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C5")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (petItemID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60048C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B1D60", Offset = "0x7B0760", VA = "0x1807B1D60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60048C7")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (petItemID_ != 0)
			{
				int value = petItemID_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60048C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B1A80", Offset = "0x7B0480", VA = "0x1807B1A80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = petItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60048C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Pet other)
		{
			if (other != null)
			{
				int num = other.petItemID_;
				if (num != 0)
				{
					petItemID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (petItemID_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C30", Offset = "0x7B0630", VA = "0x1807B1C30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = petItemID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CE0", Offset = "0x7B06E0", VA = "0x1807B1CE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				petItemID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				petItemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B1DC0", Offset = "0x7B07C0", VA = "0x1807B1DC0")]
		static Pet()
		{
			Func<Pet> func = default(Func<Pet>);
			_parser = (MessageParser<Pet>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
