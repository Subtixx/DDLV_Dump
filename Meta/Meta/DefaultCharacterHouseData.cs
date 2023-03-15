using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000812")]
	public sealed class DefaultCharacterHouseData : IMessage<DefaultCharacterHouseData>, IMessage, IEquatable<DefaultCharacterHouseData>, IDeepCloneable<DefaultCharacterHouseData>, IMessageFieldAccessor, IDefaultGridCollectionContainer
	{
		[Cpp2IlInjected.Token(Token = "0x4002034")]
		private static readonly MessageParser<DefaultCharacterHouseData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002035")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002036")]
		public const int DefaultRoomFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002037")]
		private House.Types.Room defaultRoom_;

		[Cpp2IlInjected.Token(Token = "0x4002038")]
		public const int DefaultGridCollectionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002039")]
		private GridCollection defaultGridCollection_;

		[Cpp2IlInjected.Token(Token = "0x17000AFE")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultCharacterHouseData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004354")]
			[Cpp2IlInjected.Address(RVA = "0x1A219F0", Offset = "0x1A203F0", VA = "0x181A219F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004355")]
			[Cpp2IlInjected.Address(RVA = "0x1A21920", Offset = "0x1A20320", VA = "0x181A21920")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B00")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004356")]
			[Cpp2IlInjected.Address(RVA = "0x1A21A50", Offset = "0x1A20450", VA = "0x181A21A50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B01")]
		[DebuggerNonUserCode]
		public House.Types.Room DefaultRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600435B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultRoom_;
			}
			[Cpp2IlInjected.Token(Token = "0x600435C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				defaultRoom_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B02")]
		[DebuggerNonUserCode]
		public GridCollection DefaultGridCollection
		{
			[Cpp2IlInjected.Token(Token = "0x600435D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "14")]
			get
			{
				return defaultGridCollection_;
			}
			[Cpp2IlInjected.Token(Token = "0x600435E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				defaultGridCollection_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004357")]
		[Cpp2IlInjected.Address(RVA = "0x1A21870", Offset = "0x1A20270", VA = "0x181A21870")]
		[DebuggerNonUserCode]
		public DefaultCharacterHouseData()
		{
			//Discarded unreachable code: IL_0032
			//IL_0021: Expected I4, but got I8
			House.Types.Room room = (defaultRoom_ = new House.Types.Room());
			defaultRoom_.flooring_ = 0;
			((MapField<TKey, TValue>)(object)defaultRoom_.wallpapers_).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6004358")]
		[Cpp2IlInjected.Address(RVA = "0x1A21470", Offset = "0x1A1FE70", VA = "0x181A21470")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_002c
			//IL_001b: Expected I4, but got I8
			House.Types.Room room = (defaultRoom_ = new House.Types.Room());
			defaultRoom_.flooring_ = 0;
			((MapField<TKey, TValue>)(object)defaultRoom_.wallpapers_).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6004359")]
		[Cpp2IlInjected.Address(RVA = "0x1A21740", Offset = "0x1A20140", VA = "0x181A21740")]
		[DebuggerNonUserCode]
		public DefaultCharacterHouseData(DefaultCharacterHouseData other)
		{
			//IL_004d: Expected O, but got I4
			House.Types.Room room = (defaultRoom_ = new House.Types.Room());
			House.Types.Room room2 = defaultRoom_;
			int num = (room2.flooring_ = 0);
			((MapField<TKey, TValue>)(object)defaultRoom_.wallpapers_).Clear();
			House.Types.Room room3 = other.defaultRoom_;
			if (room3 != null)
			{
				House.Types.Room room4 = room3.Clone();
			}
			defaultRoom_ = (House.Types.Room)num;
			GridCollection gridCollection = other.defaultGridCollection_;
			GridCollection gridCollection2 = default(GridCollection);
			if (gridCollection != null)
			{
				gridCollection2 = gridCollection.Clone();
			}
			defaultGridCollection_ = gridCollection2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600435A")]
		[Cpp2IlInjected.Address(RVA = "0x1A20F50", Offset = "0x1A1F950", VA = "0x181A20F50", Slot = "10")]
		[DebuggerNonUserCode]
		public DefaultCharacterHouseData Clone()
		{
			//Discarded unreachable code: IL_0085
			//IL_0050: Expected O, but got I4
			DefaultCharacterHouseData defaultCharacterHouseData = new DefaultCharacterHouseData();
			House.Types.Room room = (defaultCharacterHouseData.defaultRoom_ = new House.Types.Room());
			House.Types.Room room2 = defaultCharacterHouseData.defaultRoom_;
			int num = (room2.flooring_ = 0);
			((MapField<TKey, TValue>)(object)defaultCharacterHouseData.defaultRoom_.wallpapers_).Clear();
			House.Types.Room room3 = defaultRoom_;
			if (room3 != null)
			{
				House.Types.Room room4 = room3.Clone();
			}
			defaultCharacterHouseData.defaultRoom_ = (House.Types.Room)num;
			GridCollection gridCollection = defaultGridCollection_;
			GridCollection gridCollection2 = default(GridCollection);
			if (gridCollection != null)
			{
				gridCollection2 = gridCollection.Clone();
			}
			defaultCharacterHouseData.defaultGridCollection_ = gridCollection2;
			UnknownFieldSet unknownFieldSet = (defaultCharacterHouseData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return defaultCharacterHouseData;
		}

		[Cpp2IlInjected.Token(Token = "0x600435F")]
		[Cpp2IlInjected.Address(RVA = "0x1A210B0", Offset = "0x1A1FAB0", VA = "0x181A210B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(defaultRoom_, other) && object.Equals(defaultGridCollection_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004360")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultCharacterHouseData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				House.Types.Room objB = other.defaultRoom_;
				if (object.Equals(defaultRoom_, objB))
				{
					GridCollection objB2 = other.defaultGridCollection_;
					if (object.Equals(defaultGridCollection_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004361")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				House.Types.Room room = defaultRoom_;
				if (room != null)
				{
					int hashCode = room.GetHashCode();
				}
				GridCollection gridCollection = defaultGridCollection_;
				if (gridCollection != null)
				{
					int hashCode2 = gridCollection.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004362")]
		[Cpp2IlInjected.Address(RVA = "0x1A215D0", Offset = "0x1A1FFD0", VA = "0x181A215D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004363")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)defaultRoom_ != 0)
			{
				House.Types.Room value = defaultRoom_;
				output.WriteMessage(value);
			}
			if ((long)defaultGridCollection_ != 0)
			{
				GridCollection value2 = defaultGridCollection_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004364")]
		[Cpp2IlInjected.Address(RVA = "0x1A20E80", Offset = "0x1A1F880", VA = "0x181A20E80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				House.Types.Room room = defaultRoom_;
				num = 0;
				if (room != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(room);
				}
				GridCollection gridCollection = defaultGridCollection_;
				if (gridCollection != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(gridCollection);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004365")]
		[Cpp2IlInjected.Address(RVA = "0x1A21200", Offset = "0x1A1FC00", VA = "0x181A21200", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultCharacterHouseData other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.defaultRoom_ != 0)
			{
				House.Types.Room room = defaultRoom_;
				if (room == null)
				{
					House.Types.Room room2 = (defaultRoom_ = new House.Types.Room());
					House.Types.Room room3 = defaultRoom_;
				}
				House.Types.Room other2 = other.defaultRoom_;
				room.MergeFrom(other2);
			}
			if ((long)other.defaultGridCollection_ != 0)
			{
				GridCollection gridCollection2 = default(GridCollection);
				if (defaultGridCollection_ == null)
				{
					GridCollection gridCollection = (defaultGridCollection_ = new GridCollection());
					gridCollection2 = defaultGridCollection_;
				}
				GridCollection other3 = other.defaultGridCollection_;
				gridCollection2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004366")]
		[Cpp2IlInjected.Address(RVA = "0x1A21330", Offset = "0x1A1FD30", VA = "0x181A21330", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				House.Types.Room room = defaultRoom_;
				if (room == null)
				{
					House.Types.Room room2 = (defaultRoom_ = new House.Types.Room());
				}
				input.ReadMessage(room);
			}
			if (num == 18)
			{
				GridCollection builder = default(GridCollection);
				if (defaultGridCollection_ == null)
				{
					GridCollection gridCollection = (defaultGridCollection_ = new GridCollection());
					builder = defaultGridCollection_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004367")]
		[Cpp2IlInjected.Address(RVA = "0x1A21170", Offset = "0x1A1FB70", VA = "0x181A21170", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				House.Types.Room room = defaultRoom_;
			}
			if (fieldNumber == 2)
			{
				GridCollection gridCollection = defaultGridCollection_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004368")]
		[Cpp2IlInjected.Address(RVA = "0x1A21510", Offset = "0x1A1FF10", VA = "0x181A21510", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					defaultRoom_ = (House.Types.Room)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004369")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600436A")]
		[Cpp2IlInjected.Address(RVA = "0x1A21630", Offset = "0x1A20030", VA = "0x181A21630")]
		static DefaultCharacterHouseData()
		{
			Func<DefaultCharacterHouseData> func = default(Func<DefaultCharacterHouseData>);
			_parser = (MessageParser<DefaultCharacterHouseData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
