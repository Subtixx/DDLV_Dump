using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005B0")]
	public sealed class CollectionCrop : IMessage<CollectionCrop>, IMessage, IEquatable<CollectionCrop>, IDeepCloneable<CollectionCrop>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F16")]
		private static readonly MessageParser<CollectionCrop> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F17")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F18")]
		public const int CropTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F19")]
		private CropType cropType_;

		[Cpp2IlInjected.Token(Token = "0x17001263")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionCrop> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600470E")]
			[Cpp2IlInjected.Address(RVA = "0x2EC95A0", Offset = "0x2EC7FA0", VA = "0x182EC95A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001264")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600470F")]
			[Cpp2IlInjected.Address(RVA = "0x2EC94D0", Offset = "0x2EC7ED0", VA = "0x182EC94D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001265")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004710")]
			[Cpp2IlInjected.Address(RVA = "0x2EC9600", Offset = "0x2EC8000", VA = "0x182EC9600", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001266")]
		[DebuggerNonUserCode]
		public CropType CropType
		{
			[Cpp2IlInjected.Token(Token = "0x6004714")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return cropType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004715")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				cropType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004711")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionCrop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004712")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public CollectionCrop(CollectionCrop other)
		{
			CropType cropType = (cropType_ = other.cropType_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004713")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9120", Offset = "0x2EC7B20", VA = "0x182EC9120", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionCrop Clone()
		{
			//Discarded unreachable code: IL_0029
			CollectionCrop collectionCrop = new CollectionCrop();
			CropType cropType = (collectionCrop.cropType_ = cropType_);
			UnknownFieldSet unknownFieldSet = (collectionCrop._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionCrop;
		}

		[Cpp2IlInjected.Token(Token = "0x6004716")]
		[Cpp2IlInjected.Address(RVA = "0x2EC91A0", Offset = "0x2EC7BA0", VA = "0x182EC91A0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)cropType_ == (IntPtr)typeof(CollectionCrop).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004717")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionCrop other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				CropType cropType = other.cropType_;
				if (cropType_ == cropType)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004718")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (cropType_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004719")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9360", Offset = "0x2EC7D60", VA = "0x182EC9360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600471A")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_001c
			if (cropType_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600471B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9080", Offset = "0x2EC7A80", VA = "0x182EC9080", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				CropType cropType = cropType_;
				num = 0;
				if (cropType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)cropType);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600471C")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionCrop other)
		{
			if (other != null)
			{
				CropType cropType = other.cropType_;
				if (cropType != 0)
				{
					cropType_ = cropType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600471D")]
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
					int num2 = (int)(cropType_ = (CropType)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600471E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9230", Offset = "0x2EC7C30", VA = "0x182EC9230", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				CropType cropType = cropType_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600471F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC92E0", Offset = "0x2EC7CE0", VA = "0x182EC92E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				cropType_ = (CropType)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004720")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				cropType_ = CropType.Fruit;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004721")]
		[Cpp2IlInjected.Address(RVA = "0x2EC93C0", Offset = "0x2EC7DC0", VA = "0x182EC93C0")]
		static CollectionCrop()
		{
			Func<CollectionCrop> func = default(Func<CollectionCrop>);
			_parser = (MessageParser<CollectionCrop>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
