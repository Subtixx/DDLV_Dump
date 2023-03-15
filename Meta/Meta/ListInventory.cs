using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class ListInventory : IMessage<ListInventory>, IMessage, IEquatable<ListInventory>, IDeepCloneable<ListInventory>, IMessageFieldAccessor, IMessageOneofAccessor, IInventory, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum SubTypeRestrictionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			CompatibleFurnitureTypes = 4,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			CompatibleClothingTypes = 5
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000030")]
			public sealed class Data : IMessage<Data>, IMessage, IEquatable<Data>, IDeepCloneable<Data>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				private static readonly MessageParser<Data> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public const int AmountFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				[DebuggerNonUserCode]
				public static MessageParser<Data> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0x1E394F0", Offset = "0x1E37EF0", VA = "0x181E394F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0x1E39470", Offset = "0x1E37E70", VA = "0x181E39470")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0x1E39550", Offset = "0x1E37F50", VA = "0x181E39550", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Data()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public Data(Data other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x1E390C0", Offset = "0x1E37AC0", VA = "0x181E390C0", Slot = "10")]
				[DebuggerNonUserCode]
				public Data Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x1E39140", Offset = "0x1E37B40", VA = "0x181E39140", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Data other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x1E39300", Offset = "0x1E37D00", VA = "0x181E39300", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x1E39020", Offset = "0x1E37A20", VA = "0x181E39020", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Data other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x1E391D0", Offset = "0x1E37BD0", VA = "0x181E391D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x1E39280", Offset = "0x1E37C80", VA = "0x181E39280", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000032")]
			public sealed class FurnitureRestrictionList : IMessage<FurnitureRestrictionList>, IMessage, IEquatable<FurnitureRestrictionList>, IDeepCloneable<FurnitureRestrictionList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				private static readonly MessageParser<FurnitureRestrictionList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public const int ListFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				private static readonly FieldCodec<FurnitureItemType> _repeated_list_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				private readonly RepeatedField<FurnitureItemType> list_;

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				[DebuggerNonUserCode]
				public static MessageParser<FurnitureRestrictionList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0x1E3B540", Offset = "0x1E39F40", VA = "0x181E3B540")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0x1E3B4C0", Offset = "0x1E39EC0", VA = "0x181E3B4C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0x1E3B5A0", Offset = "0x1E39FA0", VA = "0x181E3B5A0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				[DebuggerNonUserCode]
				public RepeatedField<FurnitureItemType> List
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B340", Offset = "0x1E39D40", VA = "0x181E3B340")]
				[DebuggerNonUserCode]
				public FurnitureRestrictionList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B3C0", Offset = "0x1E39DC0", VA = "0x181E3B3C0")]
				[DebuggerNonUserCode]
				public FurnitureRestrictionList(FurnitureRestrictionList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AB10", Offset = "0x1E39510", VA = "0x181E3AB10", Slot = "10")]
				[DebuggerNonUserCode]
				public FurnitureRestrictionList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AC40", Offset = "0x1E39640", VA = "0x181E3AC40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AD20", Offset = "0x1E39720", VA = "0x181E3AD20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FurnitureRestrictionList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B000", Offset = "0x1E39A00", VA = "0x181E3B000", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x1E3B060", Offset = "0x1E39A60", VA = "0x181E3B060", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AA00", Offset = "0x1E39400", VA = "0x181E3AA00", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AF20", Offset = "0x1E39920", VA = "0x181E3AF20", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FurnitureRestrictionList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AE30", Offset = "0x1E39830", VA = "0x181E3AE30", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x1E3ADB0", Offset = "0x1E397B0", VA = "0x181E3ADB0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AFA0", Offset = "0x1E399A0", VA = "0x181E3AFA0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x1E3AAB0", Offset = "0x1E394B0", VA = "0x181E3AAB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000034")]
			public sealed class ClothingRestrictionList : IMessage<ClothingRestrictionList>, IMessage, IEquatable<ClothingRestrictionList>, IDeepCloneable<ClothingRestrictionList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				private static readonly MessageParser<ClothingRestrictionList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public const int ListFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				private static readonly FieldCodec<ClothingItemType> _repeated_list_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				private readonly RepeatedField<ClothingItemType> list_;

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				[DebuggerNonUserCode]
				public static MessageParser<ClothingRestrictionList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x1E38F00", Offset = "0x1E37900", VA = "0x181E38F00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0x1E38E80", Offset = "0x1E37880", VA = "0x181E38E80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x1E38F60", Offset = "0x1E37960", VA = "0x181E38F60", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				[DebuggerNonUserCode]
				public RepeatedField<ClothingItemType> List
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x1E38D00", Offset = "0x1E37700", VA = "0x181E38D00")]
				[DebuggerNonUserCode]
				public ClothingRestrictionList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x1E38D80", Offset = "0x1E37780", VA = "0x181E38D80")]
				[DebuggerNonUserCode]
				public ClothingRestrictionList(ClothingRestrictionList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x1E384D0", Offset = "0x1E36ED0", VA = "0x181E384D0", Slot = "10")]
				[DebuggerNonUserCode]
				public ClothingRestrictionList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x1E38690", Offset = "0x1E37090", VA = "0x181E38690", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x1E38600", Offset = "0x1E37000", VA = "0x181E38600", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ClothingRestrictionList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x1E389C0", Offset = "0x1E373C0", VA = "0x181E389C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x1E38A20", Offset = "0x1E37420", VA = "0x181E38A20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x1E383C0", Offset = "0x1E36DC0", VA = "0x181E383C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x1E387F0", Offset = "0x1E371F0", VA = "0x181E387F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ClothingRestrictionList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x1E38870", Offset = "0x1E37270", VA = "0x181E38870", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x1E38770", Offset = "0x1E37170", VA = "0x181E38770", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x1E38960", Offset = "0x1E37360", VA = "0x181E38960", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x1E38470", Offset = "0x1E36E70", VA = "0x181E38470", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly MessageParser<ListInventory> _parser = (MessageParser<ListInventory>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ListInventory()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private uint iD_;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public const int InventoryFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly MapField<int, Types.Data>.Codec _map_inventory_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly MapField<int, Types.Data> inventory_ = (MapField<int, Types.Data>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public const int CompatibleItemTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private ItemType compatibleItemType_;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public const int CompatibleFurnitureTypesFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public const int CompatibleClothingTypesFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private object subTypeRestrictions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private SubTypeRestrictionsOneofCase subTypeRestrictionsCase_;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[DebuggerNonUserCode]
		public static MessageParser<ListInventory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x18AA2A0", Offset = "0x18A8CA0", VA = "0x1818AA2A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x18AA1D0", Offset = "0x18A8BD0", VA = "0x1818AA1D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x18AA300", Offset = "0x18A8D00", VA = "0x1818AA300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		[DebuggerNonUserCode]
		public uint ID
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[DebuggerNonUserCode]
		public MapField<int, Types.Data> Inventory
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return inventory_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[DebuggerNonUserCode]
		public ItemType CompatibleItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return compatibleItemType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				compatibleItemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		[DebuggerNonUserCode]
		public Types.FurnitureRestrictionList CompatibleFurnitureTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x18AA170", Offset = "0x18A8B70", VA = "0x1818AA170")]
			get
			{
				int num = 0;
				if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
				{
					object obj = subTypeRestrictions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x18AA450", Offset = "0x18A8E50", VA = "0x1818AA450")]
			set
			{
				subTypeRestrictions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[DebuggerNonUserCode]
		public Types.ClothingRestrictionList CompatibleClothingTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x18AA110", Offset = "0x18A8B10", VA = "0x1818AA110")]
			get
			{
				int num = 0;
				if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
				{
					object obj = subTypeRestrictions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x18AA410", Offset = "0x18A8E10", VA = "0x1818AA410")]
			set
			{
				subTypeRestrictions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[DebuggerNonUserCode]
		public SubTypeRestrictionsOneofCase SubTypeRestrictionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return subTypeRestrictionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x18A9E90", Offset = "0x18A8890", VA = "0x1818A9E90")]
		[DebuggerNonUserCode]
		public ListInventory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x18A9F10", Offset = "0x18A8910", VA = "0x1818A9F10")]
		[DebuggerNonUserCode]
		public ListInventory(ListInventory other)
		{
			//IL_008e: Expected I4, but got O
			uint num = (iD_ = other.iD_);
			MapField<int, Types.Data> mapField = (inventory_ = (MapField<int, Types.Data>)(object)((MapField<TKey, TValue>)(object)other.inventory_).Clone());
			ItemType itemType = (compatibleItemType_ = other.compatibleItemType_);
			SubTypeRestrictionsOneofCase subTypeRestrictionsOneofCase = other.subTypeRestrictionsCase_;
			if (subTypeRestrictionsOneofCase == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
			{
				SubTypeRestrictionsOneofCase subTypeRestrictionsOneofCase2 = other.subTypeRestrictionsCase_;
				if (other.subTypeRestrictions_ == null)
				{
					throw new InvalidCastException();
				}
				Types.FurnitureRestrictionList furnitureRestrictionList = default(Types.FurnitureRestrictionList);
				subTypeRestrictions_ = furnitureRestrictionList;
			}
			if (subTypeRestrictionsOneofCase == SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
			{
				SubTypeRestrictionsOneofCase subTypeRestrictionsOneofCase3 = other.subTypeRestrictionsCase_;
				if (other.subTypeRestrictions_ == null)
				{
					throw new InvalidCastException();
				}
				Types.ClothingRestrictionList clothingRestrictionList = default(Types.ClothingRestrictionList);
				subTypeRestrictions_ = clothingRestrictionList;
				subTypeRestrictionsCase_ = (SubTypeRestrictionsOneofCase)clothingRestrictionList;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A70", Offset = "0x18A6470", VA = "0x1818A7A70", Slot = "10")]
		[DebuggerNonUserCode]
		public ListInventory Clone()
		{
			return new ListInventory(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearSubTypeRestrictions()
		{
			//IL_0010: Expected O, but got I4
			subTypeRestrictions_ = (subTypeRestrictionsCase_ = SubTypeRestrictionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x18A7E40", Offset = "0x18A6840", VA = "0x1818A7E40", Slot = "0")]
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
				if ((IntPtr)(int)iD_ == (IntPtr)typeof(ListInventory).TypeHandle)
				{
					MapField<int, Types.Data> mapField = inventory_;
					bool flag = default(bool);
					Types.FurnitureRestrictionList objB = default(Types.FurnitureRestrictionList);
					if (flag && compatibleItemType_ == (flag ? ItemType.Character : ItemType.None) && object.Equals(CompatibleFurnitureTypes, objB))
					{
						Types.ClothingRestrictionList objB2 = default(Types.ClothingRestrictionList);
						bool flag2 = object.Equals(CompatibleClothingTypes, objB2);
						if (flag2 && subTypeRestrictionsCase_ == (flag2 ? ((SubTypeRestrictionsOneofCase)1) : SubTypeRestrictionsOneofCase.None))
						{
							return object.Equals(_unknownFields, objB2);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x18A7FA0", Offset = "0x18A69A0", VA = "0x1818A7FA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ListInventory other)
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
					MapField<int, Types.Data> mapField = inventory_;
					MapField<int, Types.Data> mapField2 = other.inventory_;
					if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
					{
						ItemType itemType = other.compatibleItemType_;
						if (compatibleItemType_ == itemType)
						{
							Types.FurnitureRestrictionList compatibleFurnitureTypes = CompatibleFurnitureTypes;
							Types.FurnitureRestrictionList compatibleFurnitureTypes2 = other.CompatibleFurnitureTypes;
							if (object.Equals(compatibleFurnitureTypes, compatibleFurnitureTypes2))
							{
								Types.ClothingRestrictionList compatibleClothingTypes = CompatibleClothingTypes;
								Types.ClothingRestrictionList compatibleClothingTypes2 = other.CompatibleClothingTypes;
								if (object.Equals(compatibleClothingTypes, compatibleClothingTypes2))
								{
									SubTypeRestrictionsOneofCase subTypeRestrictionsOneofCase = other.subTypeRestrictionsCase_;
									if (subTypeRestrictionsCase_ == subTypeRestrictionsOneofCase)
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x18A84E0", Offset = "0x18A6EE0", VA = "0x1818A84E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0076
			do
			{
				uint num = iD_;
				int num2 = 0;
				if (num != 0)
				{
				}
				int hashCode = ((MapField<TKey, TValue>)(object)inventory_).GetHashCode();
				if (compatibleItemType_ != 0)
				{
				}
			}
			while (subTypeRestrictionsCase_ != SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes);
			object obj = subTypeRestrictions_;
			if (obj != null)
			{
				int hashCode2 = obj.GetHashCode();
				if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
				{
					object obj2 = subTypeRestrictions_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode3 = obj2.GetHashCode();
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode4 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x18A9920", Offset = "0x18A8320", VA = "0x1818A9920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x18A9A60", Offset = "0x18A8460", VA = "0x1818A9A60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0099
			SubTypeRestrictionsOneofCase subTypeRestrictionsOneofCase;
			do
			{
				if (iD_ != 0)
				{
					uint value = iD_;
					output.WriteUInt32(value);
				}
				MapField<int, Types.Data> mapField = inventory_;
				MapField<int, Types.Data>.Codec map_inventory_codec = _map_inventory_codec;
				((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_inventory_codec);
				if (compatibleItemType_ != 0)
				{
				}
				subTypeRestrictionsOneofCase = subTypeRestrictionsCase_;
				int num = 0;
			}
			while (subTypeRestrictionsOneofCase != SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes);
			if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
			{
				object obj = subTypeRestrictions_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleClothingTypes && subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
			{
				object obj2 = subTypeRestrictions_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x18A7700", Offset = "0x18A6100", VA = "0x1818A7700", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ca
			uint num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			MapField<int, Types.Data> mapField = inventory_;
			MapField<int, Types.Data>.Codec map_inventory_codec = _map_inventory_codec;
			int num4 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_inventory_codec);
			ItemType itemType = compatibleItemType_;
			num2 += num4;
			if (itemType != 0)
			{
				int num5 = CodedOutputStream.ComputeEnumSize((int)itemType);
				num5++;
				num2 += num5;
			}
			if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
			{
				if (subTypeRestrictionsCase_ != SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
				{
				}
				object obj = subTypeRestrictions_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num6 = default(int);
				num2 += num6;
			}
			if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
			{
				if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
				{
					object obj2 = subTypeRestrictions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
				int num7 = default(int);
				num2 += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num2 += num8;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x18A8EB0", Offset = "0x18A78B0", VA = "0x1818A8EB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ListInventory other)
		{
			//Discarded unreachable code: IL_012d
			//IL_00f4: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			uint num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			MapField<int, Types.Data> mapField = inventory_;
			MapField<int, Types.Data> mapField2 = other.inventory_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			ItemType itemType = other.compatibleItemType_;
			if (itemType != 0)
			{
				compatibleItemType_ = itemType;
			}
			if (other.subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
			{
				SubTypeRestrictionsOneofCase subTypeRestrictionsOneofCase = subTypeRestrictionsCase_;
				object obj = default(object);
				if (subTypeRestrictionsOneofCase == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
				{
					obj = subTypeRestrictions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					Types.FurnitureRestrictionList furnitureRestrictionList = (Types.FurnitureRestrictionList)(subTypeRestrictions_ = new Types.FurnitureRestrictionList());
					subTypeRestrictionsCase_ = subTypeRestrictionsOneofCase;
				}
				if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
				{
					object obj2 = subTypeRestrictions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
				{
					object obj3 = other.subTypeRestrictions_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(Types.FurnitureRestrictionList).TypeHandle == 5)
			{
				if (CompatibleClothingTypes == null)
				{
					subTypeRestrictionsCase_ = (SubTypeRestrictionsOneofCase)(subTypeRestrictions_ = new Types.ClothingRestrictionList());
				}
				Types.ClothingRestrictionList compatibleClothingTypes = CompatibleClothingTypes;
				Types.ClothingRestrictionList compatibleClothingTypes2 = other.CompatibleClothingTypes;
				compatibleClothingTypes.MergeFrom(compatibleClothingTypes2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x18A9140", Offset = "0x18A7B40", VA = "0x1818A9140", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0075: Expected I4, but got O
			//IL_00c9: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					int num2 = (int)(compatibleItemType_ = (ItemType)input.ReadInt32());
				}
				if (num == 34)
				{
					Types.FurnitureRestrictionList builder = new Types.FurnitureRestrictionList();
					if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
					{
						if (subTypeRestrictionsCase_ != SubTypeRestrictionsOneofCase.CompatibleFurnitureTypes)
						{
						}
						object obj = subTypeRestrictions_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					subTypeRestrictions_ = builder;
					subTypeRestrictionsCase_ = (SubTypeRestrictionsOneofCase)typeof(Types.FurnitureRestrictionList).TypeHandle;
				}
				if ((long)typeof(Types.FurnitureRestrictionList).TypeHandle != 42)
				{
					goto IL_00fd;
				}
				Types.ClothingRestrictionList builder2 = new Types.ClothingRestrictionList();
				if (subTypeRestrictionsCase_ == SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
				{
					if (subTypeRestrictionsCase_ != SubTypeRestrictionsOneofCase.CompatibleClothingTypes)
					{
					}
					object obj2 = subTypeRestrictions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				subTypeRestrictions_ = builder2;
				subTypeRestrictionsCase_ = (SubTypeRestrictionsOneofCase)typeof(Types.ClothingRestrictionList).TypeHandle;
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (int)(iD_ = (uint)input.ReadInt32());
			}
			if (num3 == 18)
			{
				MapField<int, Types.Data> mapField = inventory_;
				MapField<int, Types.Data>.Codec map_inventory_codec = _map_inventory_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_inventory_codec);
			}
			goto IL_00fd;
			IL_00fd:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x18A83C0", Offset = "0x18A6DC0", VA = "0x1818A83C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0035;
						}
						Types.ClothingRestrictionList compatibleClothingTypes = CompatibleClothingTypes;
					}
					Types.FurnitureRestrictionList compatibleFurnitureTypes = CompatibleFurnitureTypes;
				}
				MapField<int, Types.Data> mapField = inventory_;
			}
			uint num2 = iD_;
			goto IL_0035;
			IL_0035:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x18A9730", Offset = "0x18A8130", VA = "0x1818A9730", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0060
			//IL_0029: Expected O, but got I4
			//IL_0034: Expected I4, but got O
			//IL_004f: Expected I4, but got O
			//IL_0057: Expected I4, but got O
			//IL_005f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0)
					{
						object obj = default(object);
						compatibleItemType_ = (ItemType)obj;
						return;
					}
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							subTypeRestrictions_ = num2;
							subTypeRestrictionsCase_ = (SubTypeRestrictionsOneofCase)typeof(uint).TypeHandle;
							return;
						}
						break;
					}
					default:
						return;
					case 0:
						if (value == null || value != null)
						{
							subTypeRestrictions_ = value;
							subTypeRestrictionsCase_ = (SubTypeRestrictionsOneofCase)typeof(uint).TypeHandle;
							return;
						}
						break;
					}
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			object obj2 = default(object);
			iD_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x18A7930", Offset = "0x18A6330", VA = "0x1818A7930", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0046
			//IL_0021: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num == 0 || num == 1)
						{
							int num2 = 0;
							subTypeRestrictions_ = num2;
							subTypeRestrictionsCase_ = (SubTypeRestrictionsOneofCase)num2;
						}
					}
					else
					{
						int num3 = (int)(compatibleItemType_ = ItemType.None);
					}
					return;
				}
				MapField<int, Types.Data> mapField = inventory_;
			}
			int num4 = (int)(iD_ = 0u);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x18A8690", Offset = "0x18A7090", VA = "0x1818A8690", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "SubTypeRestrictions"))
			{
				SubTypeRestrictionsOneofCase subTypeRestrictionsOneofCase = subTypeRestrictionsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x18A79E0", Offset = "0x18A63E0", VA = "0x1818A79E0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "SubTypeRestrictions"))
			{
				subTypeRestrictions_ = (subTypeRestrictionsCase_ = SubTypeRestrictionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x18A8660", Offset = "0x18A7060", VA = "0x1818A8660")]
		public Types.Data GetInventoryData(Item item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x18A9980", Offset = "0x18A8380", VA = "0x1818A9980")]
		public bool TryGetInventoryData(Item item, out Types.Data data)
		{
			//Discarded unreachable code: IL_0010
			int itemID = item.ItemID;
			MapField<int, Types.Data> mapField = inventory_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x18A7450", Offset = "0x18A5E50", VA = "0x1818A7450")]
		private static Item ApplyVariation(Item item)
		{
			int itemID = item.ItemID;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A5EB0", VA = "0x1818A74B0")]
		private static (Item, int) ApplyVariation(Item item, int amount)
		{
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			bool flag2 = default(bool);
			uint num2 = default(uint);
			if (flag && flag2 && flag2 && num < (int)num2)
			{
				num += num;
				num++;
			}
			num += 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x18A8CA0", Offset = "0x18A76A0", VA = "0x1818A8CA0")]
		public bool HasItem(Item item, int amount)
		{
			//Discarded unreachable code: IL_0010
			int itemID = item.ItemID;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x18A7440", Offset = "0x18A5E40", VA = "0x1818A7440")]
		public void AddItem(Item item, int amount, ProfileEventDispatcher dispatcher, [Optional] AddDetail detail)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x18A7260", Offset = "0x18A5C60", VA = "0x1818A7260")]
		internal void AddItem(Item item, int amount, IPlayerEventDispatcher dispatcher, [Optional] AddDetail detail)
		{
			//Discarded unreachable code: IL_0036
			int itemID = item.ItemID;
			int num = 0;
			MapField<int, Types.Data> mapField = inventory_;
			bool flag = default(bool);
			if (!flag)
			{
				Types.Data data = new Types.Data();
				MapField<int, Types.Data> mapField2 = inventory_;
			}
			uint num2 = default(uint);
			if (dispatcher != null && num < (int)num2)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x18A9590", Offset = "0x18A7F90", VA = "0x1818A9590")]
		public unsafe bool RemoveItem(Item item, int amount, ProfileEventDispatcher dispatcher)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected I4, but got Unknown
			int itemID = item.ItemID;
			int num = 0;
			if (amount > 0)
			{
				MapField<int, Types.Data> mapField = inventory_;
				(Item, int) tuple = default((Item, int));
				Item item2 = (Item)((ValueTuple<, >*)(&tuple))->Item1;
				bool flag = default(bool);
				if (flag)
				{
					flag = (byte)(flag - tuple) != 0;
					uint num2 = default(uint);
					if (dispatcher != null && num < (int)num2)
					{
						num += num;
						num++;
					}
					item2 = (Item)((object)item2 + (object)item2);
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x18A93F0", Offset = "0x18A7DF0", VA = "0x1818A93F0")]
		internal unsafe bool RemoveItem(Item item, int amount, IPlayerEventDispatcher dispatcher)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected I4, but got Unknown
			int itemID = item.ItemID;
			int num = 0;
			if (amount > 0)
			{
				MapField<int, Types.Data> mapField = inventory_;
				(Item, int) tuple = default((Item, int));
				Item item2 = (Item)((ValueTuple<, >*)(&tuple))->Item1;
				bool flag = default(bool);
				if (flag)
				{
					flag = (byte)(flag - tuple) != 0;
					uint num2 = default(uint);
					if (dispatcher != null && num < (int)num2)
					{
						num += num;
						num++;
					}
					item2 = (Item)((object)item2 + (object)item2);
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x18A80D0", Offset = "0x18A6AD0", VA = "0x1818A80D0", Slot = "16")]
		public Dictionary<(Item, ItemState), int> GetAllItems()
		{
			MapField<int, Types.Data> mapField = inventory_;
			Func<KeyValuePair<int, Types.Data>, bool> _003C_003E9__64_ = _003C_003Ec._003C_003E9__64_0;
			if (_003C_003E9__64_ == null)
			{
				bool result = default(bool);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, Types.Data> x) => result);
			}
			IEnumerable<KeyValuePair<int, Types.Data>> enumerable = (IEnumerable<KeyValuePair<int, Types.Data>>)Enumerable.Where<KeyValuePair<int, Types.Data>>((IEnumerable<>)(object)mapField, (Func<, >)(object)_003C_003E9__64_);
			Func<KeyValuePair<int, Types.Data>, (Item, ItemState)> func = default(Func<KeyValuePair<int, Types.Data>, (Item, ItemState)>);
			if (_003C_003Ec._003C_003E9__64_1 == null)
			{
				func = (Func<KeyValuePair<int, Types.Data>, (Item, ItemState)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				});
			}
			Func<KeyValuePair<int, Types.Data>, int> func2 = default(Func<KeyValuePair<int, Types.Data>, int>);
			if (_003C_003Ec._003C_003E9__64_2 == null)
			{
				func2 = (Func<KeyValuePair<int, Types.Data>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			return (Dictionary<(Item, ItemState), int>)(object)Enumerable.ToDictionary<KeyValuePair<int, Types.Data>, (Item, ItemState), int>((IEnumerable<>)enumerable, (Func<, >)(object)func, (Func<, >)(object)func2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x18A8740", Offset = "0x18A7140", VA = "0x1818A8740")]
		public bool HasAllItems(List<Item> items)
		{
			//Discarded unreachable code: IL_001e, IL_0024
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				int num3 = 0;
				num++;
			}
			if (num + 1 != 0)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x18A8920", Offset = "0x18A7320", VA = "0x1818A8920")]
		public bool HasAllItems(List<Item> items, out int amount)
		{
			//Discarded unreachable code: IL_002f, IL_0035, IL_003b
			int num = 0;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			bool flag = default(bool);
			if (flag)
			{
				ulong num2 = num2 + 1;
				throw new NullReferenceException();
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
			ulong num3 = default(ulong);
			return (long)"{il2cpp field on {'constant63' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x0}" >= (long)num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x18A8D60", Offset = "0x18A7760", VA = "0x1818A8D60")]
		public bool IsCompatibleItem(Item item)
		{
			ItemType itemType = default(ItemType);
			if (itemType == compatibleItemType_)
			{
				ItemType itemType2 = default(ItemType);
				switch (itemType2)
				{
				case ItemType.Furniture:
					if (subTypeRestrictionsCase_ == (SubTypeRestrictionsOneofCase)itemType2)
					{
						RepeatedField<FurnitureItemType> list_2 = CompatibleFurnitureTypes.list_;
						bool result2 = default(bool);
						return result2;
					}
					break;
				case ItemType.Clothing:
					if (subTypeRestrictionsCase_ == (SubTypeRestrictionsOneofCase)itemType2)
					{
						RepeatedField<ClothingItemType> list_ = CompatibleClothingTypes.list_;
						bool result = default(bool);
						return result;
					}
					break;
				}
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x18A7AD0", Offset = "0x18A64D0", VA = "0x1818A7AD0", Slot = "17")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0056, IL_005c, IL_0062, IL_0068, IL_006e
			//IL_002c: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			int num = 0;
			MapField<int, Types.Data> mapField = inventory_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				flag = flag4;
				string text = $"Invalid item. {flag} is a variation item. Please remove it and add the amount you wanted in {flag4} if necessary";
			}
			flag = flag2;
			ItemType itemType = compatibleItemType_;
			string message = $"Invalid item. {flag} is not of type {flag2} or not of a compatible subtype";
			context.AddInvalidMemberError(message, "Inventory");
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x18A9C60", Offset = "0x18A8660", VA = "0x1818A9C60")]
		static ListInventory()
		{
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<Types.Data> parser = Types.Data._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<Types.Data>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<ListInventory>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
