using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005A4")]
	public sealed class CollectionItemList : IMessage<CollectionItemList>, IMessage, IEquatable<CollectionItemList>, IDeepCloneable<CollectionItemList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001EEC")]
		private static readonly MessageParser<CollectionItemList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001EED")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001EEE")]
		public const int IgnoreFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001EEF")]
		private bool ignore_;

		[Cpp2IlInjected.Token(Token = "0x4001EF0")]
		public const int ItemListFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001EF1")]
		private static readonly FieldCodec<int> _repeated_itemList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001EF2")]
		private readonly RepeatedField<int> itemList_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700124A")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionItemList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004690")]
			[Cpp2IlInjected.Address(RVA = "0x2ED0130", Offset = "0x2ECEB30", VA = "0x182ED0130")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700124B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004691")]
			[Cpp2IlInjected.Address(RVA = "0x2ED0060", Offset = "0x2ECEA60", VA = "0x182ED0060")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700124C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004692")]
			[Cpp2IlInjected.Address(RVA = "0x2ED0190", Offset = "0x2ECEB90", VA = "0x182ED0190", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700124D")]
		[DebuggerNonUserCode]
		public bool Ignore
		{
			[Cpp2IlInjected.Token(Token = "0x6004696")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return ignore_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004697")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				ignore_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700124E")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6004698")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004693")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFEE0", Offset = "0x2ECE8E0", VA = "0x182ECFEE0")]
		[DebuggerNonUserCode]
		public CollectionItemList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004694")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFF60", Offset = "0x2ECE960", VA = "0x182ECFF60")]
		[DebuggerNonUserCode]
		public CollectionItemList(CollectionItemList other)
		{
			bool flag = (ignore_ = other.ignore_);
			RepeatedField<int> repeatedField = (itemList_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemList_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004695")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF660", Offset = "0x2ECE060", VA = "0x182ECF660", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionItemList Clone()
		{
			//Discarded unreachable code: IL_004b
			CollectionItemList collectionItemList = new CollectionItemList();
			RepeatedField<int> repeatedField = (collectionItemList.itemList_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			bool flag = (collectionItemList.ignore_ = ignore_);
			RepeatedField<int> repeatedField2 = (collectionItemList.itemList_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)itemList_).Clone());
			UnknownFieldSet unknownFieldSet = (collectionItemList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionItemList;
		}

		[Cpp2IlInjected.Token(Token = "0x6004699")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF790", Offset = "0x2ECE190", VA = "0x182ECF790", Slot = "0")]
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
				if ((IntPtr)(ignore_ ? 1 : 0) == (IntPtr)typeof(CollectionItemList).TypeHandle)
				{
					RepeatedField<int> repeatedField = itemList_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600469A")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF870", Offset = "0x2ECE270", VA = "0x182ECF870", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionItemList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.ignore_;
				if (ignore_ == flag)
				{
					RepeatedField<int> repeatedField = itemList_;
					RepeatedField<int> repeatedField2 = other.itemList_;
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

		[Cpp2IlInjected.Token(Token = "0x600469B")]
		[Cpp2IlInjected.Address(RVA = "0x78BEE0", Offset = "0x78A8E0", VA = "0x18078BEE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002a
			if (ignore_)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)itemList_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600469C")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFC50", Offset = "0x2ECE650", VA = "0x182ECFC50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600469D")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFCB0", Offset = "0x2ECE6B0", VA = "0x182ECFCB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (ignore_)
			{
				bool value = ignore_;
				output.WriteBool(value);
			}
			RepeatedField<int> repeatedField = itemList_;
			FieldCodec<int> repeated_itemList_codec = _repeated_itemList_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemList_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600469E")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF530", Offset = "0x2ECDF30", VA = "0x182ECF530", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			RepeatedField<int> repeatedField = itemList_;
			FieldCodec<int> repeated_itemList_codec = _repeated_itemList_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemList_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<int>)(repeatedField + num2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600469F")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFAF0", Offset = "0x2ECE4F0", VA = "0x182ECFAF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionItemList other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				bool flag = other.ignore_;
				if (flag)
				{
					ignore_ = flag;
				}
				RepeatedField<int> repeatedField = itemList_;
				RepeatedField<int> repeatedField2 = other.itemList_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046A0")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF9E0", Offset = "0x2ECE3E0", VA = "0x182ECF9E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0057
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (ignore_ = input.ReadBool());
				}
				num += 4294967280u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = itemList_;
				FieldCodec<int> repeated_itemList_codec = _repeated_itemList_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemList_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046A1")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF910", Offset = "0x2ECE310", VA = "0x182ECF910", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = ignore_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<int> repeatedField = itemList_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60046A2")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFB80", Offset = "0x2ECE580", VA = "0x182ECFB80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				ignore_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60046A3")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF5F0", Offset = "0x2ECDFF0", VA = "0x182ECF5F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ignore_ = false;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<int> repeatedField = itemList_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046A4")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFDA0", Offset = "0x2ECE7A0", VA = "0x182ECFDA0")]
		static CollectionItemList()
		{
			Func<CollectionItemList> func = default(Func<CollectionItemList>);
			_parser = (MessageParser<CollectionItemList>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<CollectionItemList>)(object)FieldCodec.ForInt32(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
