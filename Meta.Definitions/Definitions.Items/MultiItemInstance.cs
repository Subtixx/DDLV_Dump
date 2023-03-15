using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000281")]
	public sealed class MultiItemInstance : IMessage<MultiItemInstance>, IMessage, IEquatable<MultiItemInstance>, IDeepCloneable<MultiItemInstance>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40009E7")]
		private static readonly MessageParser<MultiItemInstance> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009E8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009E9")]
		public const int ItemsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40009EA")]
		private static readonly FieldCodec<ItemInstance> _repeated_items_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009EB")]
		private readonly RepeatedField<ItemInstance> items_;

		[Cpp2IlInjected.Token(Token = "0x1700054A")]
		[DebuggerNonUserCode]
		public static MessageParser<MultiItemInstance> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60017ED")]
			[Cpp2IlInjected.Address(RVA = "0x29F3FA0", Offset = "0x29F29A0", VA = "0x1829F3FA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017EE")]
			[Cpp2IlInjected.Address(RVA = "0x29F3ED0", Offset = "0x29F28D0", VA = "0x1829F3ED0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017EF")]
			[Cpp2IlInjected.Address(RVA = "0x29F4000", Offset = "0x29F2A00", VA = "0x1829F4000", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054D")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemInstance> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60017F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017F0")]
		[Cpp2IlInjected.Address(RVA = "0x29F3E50", Offset = "0x29F2850", VA = "0x1829F3E50")]
		[DebuggerNonUserCode]
		public MultiItemInstance()
		{
			items_ = (RepeatedField<ItemInstance>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F1")]
		[Cpp2IlInjected.Address(RVA = "0x29F3DC0", Offset = "0x29F27C0", VA = "0x1829F3DC0")]
		[DebuggerNonUserCode]
		public MultiItemInstance(MultiItemInstance other)
		{
			RepeatedField<ItemInstance> repeatedField = (items_ = (RepeatedField<ItemInstance>)(object)((RepeatedField<T>)(object)other.items_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F2")]
		[Cpp2IlInjected.Address(RVA = "0x29F35D0", Offset = "0x29F1FD0", VA = "0x1829F35D0", Slot = "10")]
		[DebuggerNonUserCode]
		public MultiItemInstance Clone()
		{
			//Discarded unreachable code: IL_002e
			MultiItemInstance multiItemInstance = new MultiItemInstance();
			RepeatedField<ItemInstance> repeatedField = (multiItemInstance.items_ = (RepeatedField<ItemInstance>)(object)((RepeatedField<T>)(object)items_).Clone());
			UnknownFieldSet unknownFieldSet = (multiItemInstance._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return multiItemInstance;
		}

		[Cpp2IlInjected.Token(Token = "0x60017F4")]
		[Cpp2IlInjected.Address(RVA = "0x29F3690", Offset = "0x29F2090", VA = "0x1829F3690", Slot = "0")]
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
				RepeatedField<ItemInstance> repeatedField = items_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F5")]
		[Cpp2IlInjected.Address(RVA = "0x29F3770", Offset = "0x29F2170", VA = "0x1829F3770", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MultiItemInstance other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ItemInstance> repeatedField = items_;
				RepeatedField<ItemInstance> repeatedField2 = other.items_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F6")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)items_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60017F7")]
		[Cpp2IlInjected.Address(RVA = "0x29F3AD0", Offset = "0x29F24D0", VA = "0x1829F3AD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60017F8")]
		[Cpp2IlInjected.Address(RVA = "0x29F3B30", Offset = "0x29F2530", VA = "0x1829F3B30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ItemInstance> repeatedField = items_;
			FieldCodec<ItemInstance> repeated_items_codec = _repeated_items_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_items_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60017F9")]
		[Cpp2IlInjected.Address(RVA = "0x29F34C0", Offset = "0x29F1EC0", VA = "0x1829F34C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ItemInstance> repeatedField = items_;
			FieldCodec<ItemInstance> repeated_items_codec = _repeated_items_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_items_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60017FA")]
		[Cpp2IlInjected.Address(RVA = "0x29F3900", Offset = "0x29F2300", VA = "0x1829F3900", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MultiItemInstance other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ItemInstance> repeatedField = items_;
				RepeatedField<ItemInstance> repeatedField2 = other.items_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017FB")]
		[Cpp2IlInjected.Address(RVA = "0x29F3980", Offset = "0x29F2380", VA = "0x1829F3980", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<ItemInstance> repeatedField = items_;
					FieldCodec<ItemInstance> repeated_items_codec = _repeated_items_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_items_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017FC")]
		[Cpp2IlInjected.Address(RVA = "0x29F3880", Offset = "0x29F2280", VA = "0x1829F3880", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ItemInstance> repeatedField = items_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017FD")]
		[Cpp2IlInjected.Address(RVA = "0x29F3A70", Offset = "0x29F2470", VA = "0x1829F3A70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017FE")]
		[Cpp2IlInjected.Address(RVA = "0x29F3570", Offset = "0x29F1F70", VA = "0x1829F3570", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ItemInstance> repeatedField = items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017FF")]
		[Cpp2IlInjected.Address(RVA = "0x29F3800", Offset = "0x29F2200", VA = "0x1829F3800")]
		public static MultiItemInstance From(ItemInstance instance)
		{
			//Discarded unreachable code: IL_0014
			MultiItemInstance multiItemInstance = new MultiItemInstance();
			((RepeatedField<T>)(object)multiItemInstance.items_).Add((T)instance);
			return multiItemInstance;
		}

		[Cpp2IlInjected.Token(Token = "0x6001800")]
		[Cpp2IlInjected.Address(RVA = "0x29F3BF0", Offset = "0x29F25F0", VA = "0x1829F3BF0")]
		static MultiItemInstance()
		{
			Func<MultiItemInstance> func = default(Func<MultiItemInstance>);
			_parser = (MessageParser<MultiItemInstance>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ItemInstance> parser = ItemInstance._parser;
			uint num = default(uint);
			_parser = (MessageParser<MultiItemInstance>)(object)FieldCodec.ForMessage<ItemInstance>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
