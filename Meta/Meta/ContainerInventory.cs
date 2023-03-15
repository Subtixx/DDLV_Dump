using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class ContainerInventory : IMessage<ContainerInventory>, IMessage, IEquatable<ContainerInventory>, IDeepCloneable<ContainerInventory>, IMessageFieldAccessor, IInventory, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000027")]
			public sealed class Slot : IMessage<Slot>, IMessage, IEquatable<Slot>, IDeepCloneable<Slot>, IMessageFieldAccessor, IItemInstance, IItemWithState, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				private static readonly MessageParser<Slot> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000091")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000093")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public const int StateFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000095")]
				private ItemState state_;

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				[DebuggerNonUserCode]
				public static MessageParser<Slot> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x1F17130", Offset = "0x1F15B30", VA = "0x181F17130")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0x1F170B0", Offset = "0x1F15AB0", VA = "0x181F170B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x1F17190", Offset = "0x1F15B90", VA = "0x181F17190", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "14")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				[DebuggerNonUserCode]
				public ItemState State
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "18")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public Item Item
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
					get
					{
						return default(Item);
					}
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Slot()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x1F17030", Offset = "0x1F15A30", VA = "0x181F17030")]
				[DebuggerNonUserCode]
				public Slot(Slot other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x1F165C0", Offset = "0x1F14FC0", VA = "0x181F165C0", Slot = "10")]
				[DebuggerNonUserCode]
				public Slot Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x1F16970", Offset = "0x1F15370", VA = "0x181F16970", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Slot other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x18C2EE0", Offset = "0x18C18E0", VA = "0x1818C2EE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x1F16E10", Offset = "0x1F15810", VA = "0x181F16E10", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x1F16E70", Offset = "0x1F15870", VA = "0x181F16E70", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x1F16480", Offset = "0x1F14E80", VA = "0x181F16480", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x1F16B00", Offset = "0x1F15500", VA = "0x181F16B00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Slot other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x1F16BE0", Offset = "0x1F155E0", VA = "0x181F16BE0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x1F16A30", Offset = "0x1F15430", VA = "0x181F16A30", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x1F16CF0", Offset = "0x1F156F0", VA = "0x181F16CF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0x1F16670", Offset = "0x1F15070", VA = "0x181F16670", Slot = "19")]
				void IDataValidation.DataValidation(DataValidation.Context context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum CanAddResult
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			InvalidInventory,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			InvalidItem,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			InventoryFull,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			NotInInventory
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly MessageParser<ContainerInventory> _parser = (MessageParser<ContainerInventory>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ContainerInventory()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private uint iD_;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public const int SizeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int size_;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public const int InventoryFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly FieldCodec<Types.Slot> _repeated_inventory_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly RepeatedField<Types.Slot> inventory_ = (RepeatedField<Types.Slot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public const int BelongsToPlayerFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool belongsToPlayer_;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public const int BlockMoveToFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool blockMoveTo_;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const int ParentItemIDFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly FieldCodec<int?> _single_parentItemID_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int? parentItemID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private ContainerInventoryStackData _stackData;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		[DebuggerNonUserCode]
		public static MessageParser<ContainerInventory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1691340", Offset = "0x168FD40", VA = "0x181691340")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1691070", Offset = "0x168FA70", VA = "0x181691070")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1691490", Offset = "0x168FE90", VA = "0x181691490", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		[DebuggerNonUserCode]
		public uint ID
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[DebuggerNonUserCode]
		public int Size
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return size_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				size_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Slot> Inventory
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return inventory_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		[DebuggerNonUserCode]
		public bool BelongsToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return belongsToPlayer_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				belongsToPlayer_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[DebuggerNonUserCode]
		public bool BlockMoveTo
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return blockMoveTo_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				blockMoveTo_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		[DebuggerNonUserCode]
		public int? ParentItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x13AD1D0", Offset = "0x13ABBD0", VA = "0x1813AD1D0")]
			get
			{
				return parentItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4B0", Offset = "0xEFDEB0", VA = "0x180EFF4B0")]
			set
			{
				parentItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ContainerInventoryStackData StackData
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x16913A0", Offset = "0x168FDA0", VA = "0x1816913A0")]
			get
			{
				//Discarded unreachable code: IL_0013
				ContainerInventoryStackData stackData = _stackData;
				if (stackData == null)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				}
				return stackData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int NumberOfItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1691140", Offset = "0x168FB40", VA = "0x181691140")]
			get
			{
				RepeatedField<Types.Slot> repeatedField = inventory_;
				Func<Types.Slot, int> _003C_003E9__60_ = _003C_003Ec._003C_003E9__60_0;
				if (_003C_003E9__60_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.Slot x) => x.amount_);
				}
				return Enumerable.Sum<Types.Slot>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__60_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Item? ParentItem
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1691270", Offset = "0x168FC70", VA = "0x181691270")]
			get
			{
				if ((object)parentItemID_ != null)
				{
					int value = default(int);
					long num = Convert.ToInt64((uint)value);
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x16915A0", Offset = "0x168FFA0", VA = "0x1816915A0")]
			set
			{
				//Discarded unreachable code: IL_0013
				//IL_0012: Expected O, but got I4
				int num = 0;
				Item item = default(Item);
				int itemID = item.ItemID;
				int num2 = 0;
				parentItemID_ = (int?)(object)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1690FF0", Offset = "0x168F9F0", VA = "0x181690FF0")]
		[DebuggerNonUserCode]
		public ContainerInventory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1690ED0", Offset = "0x168F8D0", VA = "0x181690ED0")]
		[DebuggerNonUserCode]
		public ContainerInventory(ContainerInventory other)
		{
			uint num = (iD_ = other.iD_);
			int num2 = (size_ = other.size_);
			RepeatedField<Types.Slot> repeatedField = (inventory_ = (RepeatedField<Types.Slot>)(object)((RepeatedField<T>)(object)other.inventory_).Clone());
			bool flag = (belongsToPlayer_ = other.belongsToPlayer_);
			bool flag2 = (blockMoveTo_ = other.blockMoveTo_);
			int? num3 = (parentItemID_ = other.parentItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x168E700", Offset = "0x168D100", VA = "0x18168E700", Slot = "10")]
		[DebuggerNonUserCode]
		public ContainerInventory Clone()
		{
			//Discarded unreachable code: IL_008b
			ContainerInventory containerInventory = new ContainerInventory();
			RepeatedField<Types.Slot> repeatedField = (containerInventory.inventory_ = (RepeatedField<Types.Slot>)(object)new RepeatedField<T>());
			uint num = (containerInventory.iD_ = iD_);
			int num2 = (containerInventory.size_ = size_);
			RepeatedField<Types.Slot> repeatedField2 = (containerInventory.inventory_ = (RepeatedField<Types.Slot>)(object)((RepeatedField<T>)(object)inventory_).Clone());
			bool flag = (containerInventory.belongsToPlayer_ = belongsToPlayer_);
			bool flag2 = (containerInventory.blockMoveTo_ = blockMoveTo_);
			int? num3 = (containerInventory.parentItemID_ = parentItemID_);
			UnknownFieldSet unknownFieldSet = (containerInventory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return containerInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x168E940", Offset = "0x168D340", VA = "0x18168E940", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_005f: Expected O, but got I4
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
				if ((IntPtr)(int)iD_ == (IntPtr)typeof(ContainerInventory).TypeHandle && (IntPtr)size_ == (IntPtr)typeof(ContainerInventory).TypeHandle)
				{
					RepeatedField<Types.Slot> repeatedField = inventory_;
					bool flag = default(bool);
					if (flag && belongsToPlayer_ == flag && blockMoveTo_ == flag)
					{
						int? num2 = parentItemID_;
						bool flag2 = default(bool);
						bool flag3 = default(bool);
						if (flag2 != flag3)
						{
							return object.Equals(_unknownFields, flag3);
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x168EAA0", Offset = "0x168D4A0", VA = "0x18168EAA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ContainerInventory other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.iD_;
				if (iD_ == num)
				{
					int num2 = other.size_;
					if (size_ == num2)
					{
						RepeatedField<Types.Slot> repeatedField = inventory_;
						RepeatedField<Types.Slot> repeatedField2 = other.inventory_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							bool flag = other.belongsToPlayer_;
							if (belongsToPlayer_ == flag)
							{
								bool flag2 = other.blockMoveTo_;
								if (blockMoveTo_ == flag2)
								{
									int? num3 = parentItemID_;
									int? num4 = other.parentItemID_;
									bool flag3 = (object)num3 == (object)num4;
									if ((object)num3 == (object)num4 != flag3)
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										return object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x168F030", Offset = "0x168DA30", VA = "0x18168F030", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0053
			int num = 0;
			if (iD_ != 0)
			{
			}
			if (size_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)inventory_).GetHashCode();
			if (belongsToPlayer_)
			{
			}
			if (blockMoveTo_)
			{
			}
			int? num2 = parentItemID_;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1690710", Offset = "0x168F110", VA = "0x181690710", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1690AF0", Offset = "0x168F4F0", VA = "0x181690AF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a5
			if (iD_ != 0)
			{
				uint value = iD_;
				output.WriteUInt32(value);
			}
			if (size_ != 0)
			{
				int value2 = size_;
				output.WriteInt32(value2);
			}
			RepeatedField<Types.Slot> repeatedField = inventory_;
			FieldCodec<Types.Slot> repeated_inventory_codec = _repeated_inventory_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_inventory_codec);
			if (belongsToPlayer_)
			{
				bool value3 = belongsToPlayer_;
				output.WriteBool(value3);
			}
			if (blockMoveTo_)
			{
				bool value4 = blockMoveTo_;
				output.WriteBool(value4);
			}
			FieldCodec<int?> single_parentItemID_codec = _single_parentItemID_codec;
			int? value5 = parentItemID_;
			((FieldCodec<T>)(object)single_parentItemID_codec).WriteTagAndValue(output, (T)value5);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x168DDE0", Offset = "0x168C7E0", VA = "0x18168DDE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			uint num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			int num4 = size_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			RepeatedField<Types.Slot> repeatedField = inventory_;
			FieldCodec<Types.Slot> repeated_inventory_codec = _repeated_inventory_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_inventory_codec);
			FieldCodec<int?> single_parentItemID_codec = _single_parentItemID_codec;
			int? value = parentItemID_;
			int num7 = ((FieldCodec<T>)(object)single_parentItemID_codec).CalculateSizeWithTag((T)value);
			repeatedField = (RepeatedField<Types.Slot>)(repeatedField + num7);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<Types.Slot>)(repeatedField + num8);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x168F510", Offset = "0x168DF10", VA = "0x18168F510", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(ContainerInventory other)
		{
			//Discarded unreachable code: IL_00ac
			if (other != null)
			{
				uint num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				int num2 = other.size_;
				if (num2 != 0)
				{
					size_ = num2;
				}
				RepeatedField<Types.Slot> repeatedField = inventory_;
				RepeatedField<Types.Slot> repeatedField2 = other.inventory_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				bool flag = other.belongsToPlayer_;
				if (flag)
				{
					belongsToPlayer_ = flag;
				}
				bool flag2 = other.blockMoveTo_;
				if (flag2)
				{
					blockMoveTo_ = flag2;
				}
				int? num3 = other.parentItemID_;
				if ((IntPtr)(((object)num3 == null) ? 1 : 0) == (IntPtr)(void*)num3)
				{
					int? num4 = (parentItemID_ = other.parentItemID_);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x168F600", Offset = "0x168E000", VA = "0x18168F600", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00bc
			bool flag2 = default(bool);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					break;
				}
				if ((int)num > 26)
				{
					if (num == 32)
					{
						bool flag = (belongsToPlayer_ = input.ReadBool());
					}
					if (num == 40)
					{
						flag2 = (blockMoveTo_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_00a5;
					}
					int? num2 = (int?)((FieldCodec<T>)(object)_single_parentItemID_codec).Read(input);
					if ((IntPtr)(((object)num2 == null) ? 1 : 0) != (IntPtr)(void*)num2)
					{
						continue;
					}
					parentItemID_ = num2;
				}
				if (num == 8)
				{
					num3 = (int)(iD_ = (uint)input.ReadInt32());
				}
				if (num3 == 16)
				{
					num4 = (size_ = input.ReadInt32());
				}
				if (num4 == 26)
				{
					RepeatedField<Types.Slot> repeatedField = inventory_;
					FieldCodec<Types.Slot> repeated_inventory_codec = _repeated_inventory_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_inventory_codec);
				}
				goto IL_00a5;
				IL_00a5:
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x168EEA0", Offset = "0x168D8A0", VA = "0x18168EEA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				uint num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x16904C0", Offset = "0x168EEC0", VA = "0x1816904C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0016, IL_001e, IL_0026, IL_002a, IL_0032
			//IL_000d: Expected I4, but got O
			//IL_0015: Expected I4, but got O
			//IL_001d: Expected I4, but got O
			//IL_0025: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				iD_ = (uint)(int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x168E610", Offset = "0x168D010", VA = "0x18168E610", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0014
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				iD_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x168F290", Offset = "0x168DC90", VA = "0x18168F290")]
		public Types.Slot GetSlot(int position)
		{
			return Enumerable.ElementAtOrDefault<Types.Slot>((IEnumerable<>)(object)inventory_, position);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x168F2E0", Offset = "0x168DCE0", VA = "0x18168F2E0")]
		internal Types.Slot GetSlot(int position, bool mustAdd)
		{
			//Discarded unreachable code: IL_0039
			if (mustAdd)
			{
				int count = ((RepeatedField<T>)(object)inventory_).Count;
				int num = position + 1;
				if (count < num)
				{
					RepeatedField<Types.Slot> repeatedField = inventory_;
					Types.Slot item = new Types.Slot();
					((RepeatedField<T>)(object)repeatedField).Add((T)item);
				}
			}
			return Enumerable.ElementAtOrDefault<Types.Slot>((IEnumerable<>)(object)inventory_, position);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1690770", Offset = "0x168F170", VA = "0x181690770")]
		public bool TryGetSlot(int position, out Types.Slot slot)
		{
			Types.Slot slot2 = Enumerable.ElementAtOrDefault<Types.Slot>((IEnumerable<>)(object)inventory_, position);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x168DDB0", Offset = "0x168C7B0", VA = "0x18168DDB0")]
		public CanAddResult AddItem(Item item, int amount, ProfileEventDispatcher dispatcher, [Optional] ItemState state, [Optional] AddDetail detail)
		{
			int num = 0;
			CanAddResult result = default(CanAddResult);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x168D880", Offset = "0x168C280", VA = "0x18168D880")]
		internal CanAddResult AddItem(Item item, int amount, IPlayerEventDispatcher dispatcher, [Optional] ItemState state, [Optional] AddDetail detail, [Optional] List<int> destinationPositions)
		{
			//Discarded unreachable code: IL_0126
			//IL_00ab: Expected O, but got I4
			//IL_00f3: Expected I4, but got O
			//IL_00fb: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			CanAddResult canAddResult = default(CanAddResult);
			int num3 = default(int);
			if (canAddResult == CanAddResult.Success)
			{
				ContainerInventoryStackData stackData = StackData;
				int count = ((RepeatedField<T>)(object)inventory_).Count;
				if (num < count)
				{
					Types.Slot slot = (Types.Slot)((RepeatedField<T>)(object)inventory_)[num];
					bool flag = default(bool);
					if (flag)
					{
						int amount_ = slot.amount_;
						int num2 = num2 - amount_;
						if (Math.Min(amount, num2) <= 0)
						{
						}
					}
					if (amount <= 0)
					{
						goto IL_0117;
					}
					RepeatedField<Types.Slot> repeatedField = inventory_;
					num++;
				}
				if (amount > 0)
				{
					int count2 = ((RepeatedField<T>)(object)inventory_).Count;
					if (num < count2)
					{
						Types.Slot slot2 = (Types.Slot)((RepeatedField<T>)(object)inventory_)[num];
						if (slot2.ItemID != 0)
						{
							slot2.ItemID = itemID;
							slot2.state_ = (ItemState)num;
							slot2.amount_ = num;
						}
						if (amount <= 0)
						{
							goto IL_0117;
						}
						RepeatedField<Types.Slot> repeatedField2 = inventory_;
						num++;
						while (repeatedField2 != null)
						{
						}
					}
					if (((RepeatedField<T>)(object)inventory_).Count < size_)
					{
						Types.Slot slot3 = new Types.Slot();
						slot3.itemID_ = itemID;
						slot3.amount_ = (int)slot3;
						slot3.state_ = (ItemState)num;
						((RepeatedField<T>)(object)inventory_).Add((T)slot3);
						num3 = ((RepeatedField<T>)(object)inventory_).Count - 1;
					}
				}
				goto IL_0117;
			}
			goto IL_0124;
			IL_0117:
			if (num < num3)
			{
				num += num;
				num++;
			}
			goto IL_0124;
			IL_0124:
			return canAddResult;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1690250", Offset = "0x168EC50", VA = "0x181690250")]
		public bool RemoveItem(Item item, int amount, ProfileEventDispatcher dispatcher, [Optional] ItemState state, InvActionType reason = InvActionType.None)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x168FF30", Offset = "0x168E930", VA = "0x18168FF30")]
		internal bool RemoveItem(Item item, int amount, IPlayerEventDispatcher dispatcher, [Optional] ItemState state, InvActionType reason = InvActionType.None)
		{
			int itemID = item.ItemID;
			if (amount > 0)
			{
				RepeatedField<Types.Slot> repeatedField = inventory_;
				int num = 0;
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				if (num < count)
				{
					Types.Slot slot = (Types.Slot)((RepeatedField<T>)(object)inventory_)[num];
					bool flag = default(bool);
					if (flag)
					{
					}
					RepeatedField<Types.Slot> repeatedField2 = inventory_;
					num++;
				}
				int count2 = ((RepeatedField<T>)(object)inventory_).Count;
				Types.Slot slot2 = (Types.Slot)((RepeatedField<T>)(object)inventory_)[count2];
				count2 = itemID;
				bool flag2 = default(bool);
				if (flag2)
				{
					int amount_ = slot2.amount_;
					count2 = amount;
					Item item2 = (slot2.Item = Item.Invalid);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x168FF20", Offset = "0x168E920", VA = "0x18168FF20")]
		public bool RemoveItem(int position, ProfileEventDispatcher dispatcher, [Optional] int? amountToRemove, InvActionType reason = InvActionType.None)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1690260", Offset = "0x168EC60", VA = "0x181690260")]
		internal bool RemoveItem(int position, IPlayerEventDispatcher dispatcher, [Optional] int? amountToRemove, InvActionType reason = InvActionType.None)
		{
			Types.Slot slot = Enumerable.ElementAtOrDefault<Types.Slot>((IEnumerable<>)(object)inventory_, position);
			if (slot != null && slot.ItemID == 0)
			{
				int amount_ = slot.amount_;
				int itemID = slot.ItemID;
				int amount_2 = slot.amount_;
				ItemState state_ = slot.state_;
				if (slot.amount_ == 0)
				{
					Item item = (slot.Item = Item.Invalid);
				}
				if (dispatcher == null)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x168E5D0", Offset = "0x168CFD0", VA = "0x18168E5D0")]
		public bool CanTransferItem(Item item, int amount)
		{
			//Discarded unreachable code: IL_000f
			ContainerInventoryStackData stackData = StackData;
			int num = default(int);
			return amount <= num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x168E2D0", Offset = "0x168CCD0", VA = "0x18168E2D0")]
		public CanAddResult CanAddItem(Item item, int amount, [Optional] ItemState state, [Optional] InventoryFullResolution inventoryFullResolution)
		{
			int num = 0;
			CanAddResult result = default(CanAddResult);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x168DF90", Offset = "0x168C990", VA = "0x18168DF90")]
		public CanAddResult CanAddItem(Item item, int amount, out int? inventoryFullOverflow, [Optional] ItemState state, [Optional] InventoryFullResolution inventoryFullResolution)
		{
			//IL_0010: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			System.Runtime.CompilerServices.Unsafe.As<int?, Nullable<>>(ref inventoryFullOverflow).value = (T)num;
			bool flag = default(bool);
			if (flag && !blockMoveTo_)
			{
				ContainerInventoryStackData stackData = StackData;
				int num2 = default(int);
				if (num2 != 0)
				{
					RepeatedField<Types.Slot> repeatedField = inventory_;
					int num3 = 0;
					int num4 = 0;
					int count = ((RepeatedField<T>)(object)repeatedField).Count;
					if (num4 < count)
					{
						if (((RepeatedField<T>)(object)repeatedField).Contains((T)num3))
						{
						}
						Types.Slot slot = (Types.Slot)((RepeatedField<T>)(object)inventory_)[num3];
						bool flag2 = default(bool);
						if (flag2)
						{
							int amount_ = slot.amount_;
							amount_ -= num2;
						}
						if (amount <= 0)
						{
							goto IL_00df;
						}
						RepeatedField<Types.Slot> repeatedField2 = inventory_;
						num3++;
					}
					if (amount > 0)
					{
						RepeatedField<Types.Slot> repeatedField3 = inventory_;
						int num5 = 0;
						int num6 = 0;
						int count2 = ((RepeatedField<T>)(object)repeatedField3).Count;
						if (num6 < count2)
						{
							if (((Types.Slot)((RepeatedField<T>)(object)inventory_)[num5]).ItemID != 0)
							{
							}
							if (amount > 0)
							{
								RepeatedField<Types.Slot> repeatedField4 = inventory_;
								num5++;
								while (repeatedField4 != null)
								{
								}
							}
						}
					}
					goto IL_00df;
				}
			}
			goto IL_0108;
			IL_00df:
			int count3 = ((RepeatedField<T>)(object)inventory_).Count;
			if (amount > 0)
			{
				int num7 = size_;
				if (count3 < num7)
				{
					count3++;
				}
			}
			while (amount == 0)
			{
			}
			goto IL_0108;
			IL_0108:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x16907E0", Offset = "0x168F1E0", VA = "0x1816907E0")]
		public bool TryToAddItems(MultiItemInstance items, ProfileEventDispatcher dispatcher, [Optional] InventoryFullResolution inventoryFullResolution)
		{
			//Discarded unreachable code: IL_007c
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int count = ((RepeatedField<T>)(object)items.items_).Count;
			ItemInstance itemInstance;
			if (num3 < count)
			{
				itemInstance = (ItemInstance)((RepeatedField<T>)(object)items.items_)[num2];
				int itemID = itemInstance.Item.ItemID;
				bool flag = default(bool);
				if (flag)
				{
					Item item = itemInstance.Item;
					ItemState state_ = itemInstance.state_;
					int num4 = 0;
					CanAddResult canAddResult = default(CanAddResult);
					if (canAddResult == CanAddResult.Success)
					{
						goto IL_0059;
					}
					num++;
				}
				num2++;
				goto IL_0059;
			}
			goto IL_0077;
			IL_0077:
			return num == 0;
			IL_0059:
			Item item2 = itemInstance.Item;
			ItemState state_2 = itemInstance.state_;
			((RepeatedField<T>)(object)items.items_).RemoveAt(num2);
			goto IL_0077;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x168F3E0", Offset = "0x168DDE0", VA = "0x18168F3E0")]
		public bool HasItem(Item item, int amount, [Optional] ItemState state)
		{
			//Discarded unreachable code: IL_003a
			RepeatedField<Types.Slot> repeatedField = inventory_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num < count)
			{
				Types.Slot slot = (Types.Slot)((RepeatedField<T>)(object)inventory_)[num];
				bool flag = default(bool);
				if (flag)
				{
				}
				RepeatedField<Types.Slot> repeatedField2 = inventory_;
				num++;
			}
			return num >= amount;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x168F160", Offset = "0x168DB60", VA = "0x18168F160")]
		public int GetItemAmount(Item item, [Optional] ItemState state)
		{
			//Discarded unreachable code: IL_0034
			RepeatedField<Types.Slot> repeatedField = inventory_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num < count)
			{
				Types.Slot slot = (Types.Slot)((RepeatedField<T>)(object)inventory_)[num];
				bool flag = default(bool);
				if (flag)
				{
				}
				RepeatedField<Types.Slot> repeatedField2 = inventory_;
				num++;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x168E300", Offset = "0x168CD00", VA = "0x18168E300")]
		public static MoveInContainerInventory.Types.Result CanMoveItemBetweenIntenvories(ContainerInventory source, int sourcePosition, ContainerInventory destination, int? destinationPosition, [Optional] int? amountToMove)
		{
			//Discarded unreachable code: IL_003f, IL_0043, IL_005b, IL_005d, IL_0064
			if (sourcePosition < source.size_)
			{
				Types.Slot slot = Enumerable.ElementAtOrDefault<Types.Slot>((IEnumerable<>)(object)source.inventory_, sourcePosition);
				if (slot != null && slot.ItemID == 0)
				{
					int num = default(int);
					int num2 = default(int);
					if (num < destination.size_ && (source != destination || num2 != sourcePosition) && source != destination)
					{
						int num3 = default(int);
						if (num3 > 0)
						{
						}
						return MoveInContainerInventory.Types.Result.NotEnoughItems;
					}
					return MoveInContainerInventory.Types.Result.InvalidDestinationPosition;
				}
			}
			return MoveInContainerInventory.Types.Result.InvalidSourcePosition;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x168F7F0", Offset = "0x168E1F0", VA = "0x18168F7F0")]
		internal unsafe static MoveInContainerInventory.Types.Result MoveItemBetweenInventories(ContainerInventory source, int sourcePosition, ContainerInventory destination, int? destinationPosition, IPlayerEventDispatcher dispatcher, [Optional] int? amountToMove)
		{
			//Discarded unreachable code: IL_00f7
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected I4, but got Unknown
			//IL_00cc: Expected O, but got I4
			int num = 0;
			MoveInContainerInventory.Types.Result result = ContainerInventory.CanMoveItemBetweenIntenvories(source, sourcePosition, destination, (Nullable<>)destinationPosition, (Nullable<>)destinationPosition);
			if (result == MoveInContainerInventory.Types.Result.Success)
			{
				RepeatedField<Types.Slot> repeatedField = source.inventory_;
				Types.Slot slot = Enumerable.ElementAtOrDefault<Types.Slot>((IEnumerable<>)(object)repeatedField, sourcePosition);
				if (((glPlayFab.Disney.BattlePassReward)(object)repeatedField).Price == 0)
				{
				}
				int num2 = 0;
				int price = ((glPlayFab.Disney.BattlePassReward)(object)repeatedField).Price;
				int[] array = (int[])(object)new List<T>().ToArray();
				int count = ((RepeatedField<T>)(object)destination.inventory_).Count;
				int num3 = default(int);
				int num4 = num3 + 1;
				Types.Slot slot2 = default(Types.Slot);
				if (count < num4)
				{
					RepeatedField<Types.Slot> repeatedField2 = destination.inventory_;
					slot2 = new Types.Slot();
					((RepeatedField<T>)(object)repeatedField2).Add((T)slot2);
				}
				RepeatedField<Types.Slot> repeatedField3 = destination.inventory_;
				Types.Slot slot3 = Enumerable.ElementAtOrDefault<Types.Slot>((IEnumerable<>)(object)repeatedField3, num3);
				bool flag = default(bool);
				int[] array2 = default(int[]);
				if (((glPlayFab.Disney.BattlePassReward)(object)repeatedField3).Price == 0 && flag)
				{
					ContainerInventoryStackData stackData = destination.StackData;
					uint iD = destination.ID;
					int num5 = default(int);
					if ((IntPtr)slot2 != (IntPtr)num5)
					{
						num5 -= slot2;
						((int*)num5)->m_value = num;
						array2 = new int[1];
					}
				}
				uint num6 = default(uint);
				int price2 = default(int);
				((glPlayFab.Disney.BattlePassReward)num6).Price = price2;
				if (num6 != 0)
				{
				}
				((uint*)(int)num6)->m_value = (uint)num;
				array2[0] = num;
				uint num7 = default(uint);
				if (num3 != 0 && num < (int)num7)
				{
					num += num;
					num++;
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x168EBB0", Offset = "0x168D5B0", VA = "0x18168EBB0", Slot = "14")]
		public Dictionary<(Item, ItemState), int> GetAllItems()
		{
			RepeatedField<Types.Slot> repeatedField = inventory_;
			Func<Types.Slot, (Item, ItemState)> _003C_003E9__81_ = _003C_003Ec._003C_003E9__81_0;
			if (_003C_003E9__81_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num3 = 0;
					throw new NullReferenceException();
				};
			}
			IEnumerable<> enumerable = Enumerable.GroupBy<Types.Slot, (Item, ItemState)>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__81_);
			Func<IGrouping<(Item, ItemState), Types.Slot>, (Item, ItemState)> func = default(Func<IGrouping<(Item, ItemState), Types.Slot>, (Item, ItemState)>);
			if (_003C_003Ec._003C_003E9__81_1 == null)
			{
				func = (Func<IGrouping<(Item, ItemState), Types.Slot>, (Item, ItemState)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num != (int)num2)
						{
							num++;
						}
					}
					throw new NullReferenceException();
				});
			}
			Func<IGrouping<(Item, ItemState), Types.Slot>, int> func2 = default(Func<IGrouping<(Item, ItemState), Types.Slot>, int>);
			if (_003C_003Ec._003C_003E9__81_2 == null)
			{
				func2 = (Func<IGrouping<(Item, ItemState), Types.Slot>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(IGrouping<(Item Item, ItemState State), Types.Slot> x)
				{
					Func<Types.Slot, int> _003C_003E9__81_2 = _003C_003Ec._003C_003E9__81_3;
					if (_003C_003E9__81_2 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.Slot y) => y.amount_);
					}
					return Enumerable.Sum<Types.Slot>((IEnumerable<>)x, (Func<, >)(object)_003C_003E9__81_2);
				});
			}
			return (Dictionary<(Item, ItemState), int>)(object)Enumerable.ToDictionary<IGrouping<(Item, ItemState), Types.Slot>, (Item, ItemState), int>(enumerable, (Func<, >)(object)func, (Func<, >)(object)func2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x168E850", Offset = "0x168D250", VA = "0x18168E850", Slot = "15")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003b
			//IL_0032: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			if (((RepeatedField<T>)(object)inventory_).Count > size_)
			{
				int count = ((RepeatedField<T>)(object)inventory_).Count;
				int num = size_;
				string error = $"Inventory ({count}) cannot be larger than Size ({count})";
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1690CC0", Offset = "0x168F6C0", VA = "0x181690CC0")]
		static ContainerInventory()
		{
			MessageParser<Types.Slot> parser = Types.Slot._parser;
			uint num = default(uint);
			_parser = (MessageParser<ContainerInventory>)(object)FieldCodec.ForMessage<Types.Slot>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<ContainerInventory>)(object)FieldCodec.ForStructWrapper<int>(num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
