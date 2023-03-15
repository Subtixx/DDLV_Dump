using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class InventoryFullDetails : IMessage<InventoryFullDetails>, IMessage, IEquatable<InventoryFullDetails>, IDeepCloneable<InventoryFullDetails>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static readonly MessageParser<InventoryFullDetails> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public const int ItemsOverflowingFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FieldCodec<ItemInstance> _repeated_itemsOverflowing_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly RepeatedField<ItemInstance> itemsOverflowing_;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public const int UnavailablePositionsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static readonly FieldCodec<int> _repeated_unavailablePositions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly RepeatedField<int> unavailablePositions_;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public static MessageParser<InventoryFullDetails> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x170DB40", Offset = "0x170C540", VA = "0x18170DB40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x170DA70", Offset = "0x170C470", VA = "0x18170DA70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x170DBA0", Offset = "0x170C5A0", VA = "0x18170DBA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemInstance> ItemsOverflowing
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemsOverflowing_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public RepeatedField<int> UnavailablePositions
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return unavailablePositions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x170D8F0", Offset = "0x170C2F0", VA = "0x18170D8F0")]
		[DebuggerNonUserCode]
		public InventoryFullDetails()
		{
			itemsOverflowing_ = (RepeatedField<ItemInstance>)(object)new RepeatedField<T>();
			unavailablePositions_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x170D9B0", Offset = "0x170C3B0", VA = "0x18170D9B0")]
		[DebuggerNonUserCode]
		public InventoryFullDetails(InventoryFullDetails other)
		{
			RepeatedField<ItemInstance> repeatedField = (itemsOverflowing_ = (RepeatedField<ItemInstance>)(object)((RepeatedField<T>)(object)other.itemsOverflowing_).Clone());
			RepeatedField<int> repeatedField2 = (unavailablePositions_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.unavailablePositions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x170CFC0", Offset = "0x170B9C0", VA = "0x18170CFC0", Slot = "10")]
		[DebuggerNonUserCode]
		public InventoryFullDetails Clone()
		{
			//Discarded unreachable code: IL_0041
			InventoryFullDetails inventoryFullDetails = new InventoryFullDetails();
			RepeatedField<ItemInstance> repeatedField = (inventoryFullDetails.itemsOverflowing_ = (RepeatedField<ItemInstance>)(object)((RepeatedField<T>)(object)itemsOverflowing_).Clone());
			RepeatedField<int> repeatedField2 = (inventoryFullDetails.unavailablePositions_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)unavailablePositions_).Clone());
			UnknownFieldSet unknownFieldSet = (inventoryFullDetails._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return inventoryFullDetails;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x170D170", Offset = "0x170BB70", VA = "0x18170D170", Slot = "0")]
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
				RepeatedField<ItemInstance> repeatedField = itemsOverflowing_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<int> repeatedField2 = unavailablePositions_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x170D0B0", Offset = "0x170BAB0", VA = "0x18170D0B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InventoryFullDetails other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ItemInstance> repeatedField = itemsOverflowing_;
				RepeatedField<ItemInstance> repeatedField2 = other.itemsOverflowing_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<int> repeatedField3 = unavailablePositions_;
					RepeatedField<int> repeatedField4 = other.unavailablePositions_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((RepeatedField<T>)(object)itemsOverflowing_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)unavailablePositions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x170D5B0", Offset = "0x170BFB0", VA = "0x18170D5B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x170D610", Offset = "0x170C010", VA = "0x18170D610", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			RepeatedField<ItemInstance> repeatedField = itemsOverflowing_;
			FieldCodec<ItemInstance> repeated_itemsOverflowing_codec = _repeated_itemsOverflowing_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemsOverflowing_codec);
			RepeatedField<int> repeatedField2 = unavailablePositions_;
			FieldCodec<int> repeated_unavailablePositions_codec = _repeated_unavailablePositions_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_unavailablePositions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x170CE60", Offset = "0x170B860", VA = "0x18170CE60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RepeatedField<ItemInstance> repeatedField = itemsOverflowing_;
			FieldCodec<ItemInstance> repeated_itemsOverflowing_codec = _repeated_itemsOverflowing_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemsOverflowing_codec);
			RepeatedField<int> repeatedField2 = unavailablePositions_;
			FieldCodec<int> repeated_unavailablePositions_codec = _repeated_unavailablePositions_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_unavailablePositions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<ItemInstance>)(repeatedField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x170D460", Offset = "0x170BE60", VA = "0x18170D460", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InventoryFullDetails other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<ItemInstance> repeatedField = itemsOverflowing_;
				RepeatedField<ItemInstance> repeatedField2 = other.itemsOverflowing_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<int> repeatedField3 = unavailablePositions_;
				RepeatedField<int> repeatedField4 = other.unavailablePositions_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x170D300", Offset = "0x170BD00", VA = "0x18170D300", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0061
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<ItemInstance> repeatedField = itemsOverflowing_;
					FieldCodec<ItemInstance> repeated_itemsOverflowing_codec = _repeated_itemsOverflowing_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsOverflowing_codec);
				}
				num += 4294967280u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField2 = unavailablePositions_;
				FieldCodec<int> repeated_unavailablePositions_codec = _repeated_unavailablePositions_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_unavailablePositions_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x170D270", Offset = "0x170BC70", VA = "0x18170D270", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ItemInstance> repeatedField = itemsOverflowing_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<int> repeatedField2 = unavailablePositions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x170D500", Offset = "0x170BF00", VA = "0x18170D500", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			switch (fieldNumber)
			{
			default:
				return;
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			case 2:
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x170CF50", Offset = "0x170B950", VA = "0x18170CF50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				RepeatedField<int> repeatedField = unavailablePositions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x170D700", Offset = "0x170C100", VA = "0x18170D700")]
		static InventoryFullDetails()
		{
			Func<InventoryFullDetails> func = default(Func<InventoryFullDetails>);
			_parser = (MessageParser<InventoryFullDetails>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ItemInstance> parser = ItemInstance._parser;
			uint num = default(uint);
			_parser = (MessageParser<InventoryFullDetails>)(object)FieldCodec.ForMessage<ItemInstance>(num, (MessageParser<>)(object)parser);
			_parser = (MessageParser<InventoryFullDetails>)(object)FieldCodec.ForInt32(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
