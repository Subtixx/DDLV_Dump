using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x200089C")]
	public sealed class BlockerData : IGridStateData, IDataValidation, IMessage<BlockerData>, IMessage, IEquatable<BlockerData>, IDeepCloneable<BlockerData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A53")]
		private static readonly MessageParser<BlockerData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A54")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A55")]
		public const int TreasureFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A56")]
		private ItemWithState treasure_;

		[Cpp2IlInjected.Token(Token = "0x17001823")]
		[DebuggerNonUserCode]
		public static MessageParser<BlockerData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006025")]
			[Cpp2IlInjected.Address(RVA = "0x32E8090", Offset = "0x32E6A90", VA = "0x1832E8090")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001824")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006026")]
			[Cpp2IlInjected.Address(RVA = "0x32E7FC0", Offset = "0x32E69C0", VA = "0x1832E7FC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001825")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006027")]
			[Cpp2IlInjected.Address(RVA = "0x32E80F0", Offset = "0x32E6AF0", VA = "0x1832E80F0", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001826")]
		[DebuggerNonUserCode]
		public ItemWithState Treasure
		{
			[Cpp2IlInjected.Token(Token = "0x600602C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return treasure_;
			}
			[Cpp2IlInjected.Token(Token = "0x600602D")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				treasure_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006024")]
		[Cpp2IlInjected.Address(RVA = "0x32E7790", Offset = "0x32E6190", VA = "0x1832E7790", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004a
			if ((object)treasure_.Item == null)
			{
				ItemWithState itemWithState = treasure_;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = itemWithState.Item;
				IItemData itemData = default(IItemData);
				if (itemData == null)
				{
					Item item2 = treasure_.Item;
					string error = $"Treasure item is invalid (deleted?): id={item2}";
					context.AddError(error);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006028")]
		[Cpp2IlInjected.Address(RVA = "0x32E7F50", Offset = "0x32E6950", VA = "0x1832E7F50")]
		[DebuggerNonUserCode]
		public BlockerData()
		{
			ItemWithState itemWithState = (treasure_ = new ItemWithState());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006029")]
		[Cpp2IlInjected.Address(RVA = "0x32E7C30", Offset = "0x32E6630", VA = "0x1832E7C30")]
		private void OnConstruction()
		{
			ItemWithState itemWithState = (treasure_ = new ItemWithState());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600602A")]
		[Cpp2IlInjected.Address(RVA = "0x32E7E80", Offset = "0x32E6880", VA = "0x1832E7E80")]
		[DebuggerNonUserCode]
		public BlockerData(BlockerData other)
		{
			//IL_002e: Expected O, but got I4
			ItemWithState itemWithState = (treasure_ = new ItemWithState());
			ItemWithState itemWithState2 = other.treasure_;
			if (itemWithState2 != null)
			{
				ItemWithState itemWithState3 = itemWithState2.Clone();
			}
			int num = 0;
			treasure_ = (ItemWithState)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600602B")]
		[Cpp2IlInjected.Address(RVA = "0x32E7690", Offset = "0x32E6090", VA = "0x1832E7690", Slot = "11")]
		[DebuggerNonUserCode]
		public BlockerData Clone()
		{
			//Discarded unreachable code: IL_0047
			//IL_0030: Expected O, but got I4
			BlockerData blockerData = new BlockerData();
			ItemWithState itemWithState = (blockerData.treasure_ = new ItemWithState());
			ItemWithState itemWithState2 = treasure_;
			if (itemWithState2 != null)
			{
				ItemWithState itemWithState3 = itemWithState2.Clone();
			}
			int num = 0;
			blockerData.treasure_ = (ItemWithState)num;
			UnknownFieldSet unknownFieldSet = (blockerData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return blockerData;
		}

		[Cpp2IlInjected.Token(Token = "0x600602E")]
		[Cpp2IlInjected.Address(RVA = "0x32E7950", Offset = "0x32E6350", VA = "0x1832E7950", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(treasure_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600602F")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(BlockerData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemWithState objB = other.treasure_;
				if (object.Equals(treasure_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006030")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemWithState itemWithState = treasure_;
				if (itemWithState != null)
				{
					int hashCode = itemWithState.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6006031")]
		[Cpp2IlInjected.Address(RVA = "0x32E7D10", Offset = "0x32E6710", VA = "0x1832E7D10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006032")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)treasure_ != 0)
			{
				ItemWithState value = treasure_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006033")]
		[Cpp2IlInjected.Address(RVA = "0x32E75F0", Offset = "0x32E5FF0", VA = "0x1832E75F0", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemWithState itemWithState = treasure_;
				num = 0;
				if (itemWithState != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemWithState);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006034")]
		[Cpp2IlInjected.Address(RVA = "0x32E7B60", Offset = "0x32E6560", VA = "0x1832E7B60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(BlockerData other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.treasure_ != 0)
			{
				ItemWithState itemWithState = treasure_;
				if (itemWithState == null)
				{
					ItemWithState itemWithState2 = (treasure_ = new ItemWithState());
				}
				ItemWithState other2 = other.treasure_;
				itemWithState.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6006035")]
		[Cpp2IlInjected.Address(RVA = "0x32E7A80", Offset = "0x32E6480", VA = "0x1832E7A80", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemWithState itemWithState = treasure_;
				if (itemWithState == null)
				{
					ItemWithState itemWithState2 = (treasure_ = new ItemWithState());
				}
				input.ReadMessage(itemWithState);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006036")]
		[Cpp2IlInjected.Address(RVA = "0x32E7A00", Offset = "0x32E6400", VA = "0x1832E7A00", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemWithState itemWithState = treasure_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006037")]
		[Cpp2IlInjected.Address(RVA = "0x32E7C90", Offset = "0x32E6690", VA = "0x1832E7C90", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				treasure_ = (ItemWithState)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006038")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006039")]
		[Cpp2IlInjected.Address(RVA = "0x32E7D70", Offset = "0x32E6770", VA = "0x1832E7D70")]
		static BlockerData()
		{
			Func<BlockerData> func = default(Func<BlockerData>);
			_parser = (MessageParser<BlockerData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
