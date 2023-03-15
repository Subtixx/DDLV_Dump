using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000756")]
	public sealed class ItemsSequence : IMessage<ItemsSequence>, IMessage, IEquatable<ItemsSequence>, IDeepCloneable<ItemsSequence>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400249B")]
		private static readonly MessageParser<ItemsSequence> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400249C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400249D")]
		public const int ItemIdsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400249E")]
		private static readonly FieldCodec<int> _repeated_itemIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400249F")]
		private readonly RepeatedField<int> itemIds_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001495")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemsSequence> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005112")]
			[Cpp2IlInjected.Address(RVA = "0x2737220", Offset = "0x2735C20", VA = "0x182737220")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001496")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005113")]
			[Cpp2IlInjected.Address(RVA = "0x2737150", Offset = "0x2735B50", VA = "0x182737150")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001497")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005114")]
			[Cpp2IlInjected.Address(RVA = "0x2737280", Offset = "0x2735C80", VA = "0x182737280", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001498")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6005118")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemIds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005115")]
		[Cpp2IlInjected.Address(RVA = "0x2736FD0", Offset = "0x27359D0", VA = "0x182736FD0")]
		[DebuggerNonUserCode]
		public ItemsSequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005116")]
		[Cpp2IlInjected.Address(RVA = "0x2737050", Offset = "0x2735A50", VA = "0x182737050")]
		[DebuggerNonUserCode]
		public ItemsSequence(ItemsSequence other)
		{
			RepeatedField<int> repeatedField = (itemIds_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemIds_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005117")]
		[Cpp2IlInjected.Address(RVA = "0x2736880", Offset = "0x2735280", VA = "0x182736880", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemsSequence Clone()
		{
			//Discarded unreachable code: IL_003b
			ItemsSequence itemsSequence = new ItemsSequence();
			RepeatedField<int> repeatedField = (itemsSequence.itemIds_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (itemsSequence.itemIds_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)itemIds_).Clone());
			UnknownFieldSet unknownFieldSet = (itemsSequence._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemsSequence;
		}

		[Cpp2IlInjected.Token(Token = "0x6005119")]
		[Cpp2IlInjected.Address(RVA = "0x2736A40", Offset = "0x2735440", VA = "0x182736A40", Slot = "0")]
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
				RepeatedField<int> repeatedField = itemIds_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600511A")]
		[Cpp2IlInjected.Address(RVA = "0x27369B0", Offset = "0x27353B0", VA = "0x1827369B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemsSequence other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = itemIds_;
				RepeatedField<int> repeatedField2 = other.itemIds_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600511B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)itemIds_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600511C")]
		[Cpp2IlInjected.Address(RVA = "0x2736D70", Offset = "0x2735770", VA = "0x182736D70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600511D")]
		[Cpp2IlInjected.Address(RVA = "0x2736DD0", Offset = "0x27357D0", VA = "0x182736DD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = itemIds_;
			FieldCodec<int> repeated_itemIds_codec = _repeated_itemIds_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemIds_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600511E")]
		[Cpp2IlInjected.Address(RVA = "0x2736770", Offset = "0x2735170", VA = "0x182736770", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = itemIds_;
			FieldCodec<int> repeated_itemIds_codec = _repeated_itemIds_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemIds_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600511F")]
		[Cpp2IlInjected.Address(RVA = "0x2736BA0", Offset = "0x27355A0", VA = "0x182736BA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemsSequence other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = itemIds_;
				RepeatedField<int> repeatedField2 = other.itemIds_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005120")]
		[Cpp2IlInjected.Address(RVA = "0x2736C20", Offset = "0x2735620", VA = "0x182736C20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967280u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = itemIds_;
				FieldCodec<int> repeated_itemIds_codec = _repeated_itemIds_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemIds_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005121")]
		[Cpp2IlInjected.Address(RVA = "0x2736B20", Offset = "0x2735520", VA = "0x182736B20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 2)
			{
				RepeatedField<int> repeatedField = itemIds_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005122")]
		[Cpp2IlInjected.Address(RVA = "0x2736D10", Offset = "0x2735710", VA = "0x182736D10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 2)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005123")]
		[Cpp2IlInjected.Address(RVA = "0x2736820", Offset = "0x2735220", VA = "0x182736820", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 2)
			{
				RepeatedField<int> repeatedField = itemIds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005124")]
		[Cpp2IlInjected.Address(RVA = "0x2736E90", Offset = "0x2735890", VA = "0x182736E90")]
		static ItemsSequence()
		{
			Func<ItemsSequence> func = default(Func<ItemsSequence>);
			_parser = (MessageParser<ItemsSequence>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemsSequence>)(object)FieldCodec.ForInt32(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
