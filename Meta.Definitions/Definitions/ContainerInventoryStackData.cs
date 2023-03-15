using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class ContainerInventoryStackData : IMessage<ContainerInventoryStackData>, IMessage, IEquatable<ContainerInventoryStackData>, IDeepCloneable<ContainerInventoryStackData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public sealed class ActivityItemTypeStackData : IMessage<ActivityItemTypeStackData>, IMessage, IEquatable<ActivityItemTypeStackData>, IDeepCloneable<ActivityItemTypeStackData>, IMessageFieldAccessor, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private static readonly MessageParser<ActivityItemTypeStackData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public const int ActivityItemTypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				private ActivityItemType activityItemType_;

				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				[DebuggerNonUserCode]
				public static MessageParser<ActivityItemTypeStackData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000277")]
					[Cpp2IlInjected.Address(RVA = "0x29371D0", Offset = "0x2935BD0", VA = "0x1829371D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000278")]
					[Cpp2IlInjected.Address(RVA = "0x2937150", Offset = "0x2935B50", VA = "0x182937150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000279")]
					[Cpp2IlInjected.Address(RVA = "0x2937230", Offset = "0x2935C30", VA = "0x182937230", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				[DebuggerNonUserCode]
				public ActivityItemType ActivityItemType
				{
					[Cpp2IlInjected.Token(Token = "0x600027E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(ActivityItemType);
					}
					[Cpp2IlInjected.Token(Token = "0x600027F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6000280")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000281")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x1EE50B0", Offset = "0x1EE3AB0", VA = "0x181EE50B0")]
				[DebuggerNonUserCode]
				public ActivityItemTypeStackData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x29370F0", Offset = "0x2935AF0", VA = "0x1829370F0")]
				[DebuggerNonUserCode]
				public ActivityItemTypeStackData(ActivityItemTypeStackData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2936AD0", Offset = "0x29354D0", VA = "0x182936AD0", Slot = "10")]
				[DebuggerNonUserCode]
				public ActivityItemTypeStackData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2936D30", Offset = "0x2935730", VA = "0x182936D30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ActivityItemTypeStackData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2936F80", Offset = "0x2935980", VA = "0x182936F80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2936A00", Offset = "0x2935400", VA = "0x182936A00", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ActivityItemTypeStackData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2936DC0", Offset = "0x29357C0", VA = "0x182936DC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2936EB0", Offset = "0x29358B0", VA = "0x182936EB0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2936B60", Offset = "0x2935560", VA = "0x182936B60", Slot = "14")]
				void IDataValidation.DataValidation(DataValidation.Context context)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public sealed class ItemStackData : IMessage<ItemStackData>, IMessage, IEquatable<ItemStackData>, IDeepCloneable<ItemStackData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				private static readonly MessageParser<ItemStackData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				[DebuggerNonUserCode]
				public static MessageParser<ItemStackData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000292")]
					[Cpp2IlInjected.Address(RVA = "0x2945030", Offset = "0x2943A30", VA = "0x182945030")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000293")]
					[Cpp2IlInjected.Address(RVA = "0x2944FB0", Offset = "0x29439B0", VA = "0x182944FB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000294")]
					[Cpp2IlInjected.Address(RVA = "0x2945090", Offset = "0x2943A90", VA = "0x182945090", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000299")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600029A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x600029B")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600029C")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x1EE50B0", Offset = "0x1EE3AB0", VA = "0x181EE50B0")]
				[DebuggerNonUserCode]
				public ItemStackData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x29370F0", Offset = "0x2935AF0", VA = "0x1829370F0")]
				[DebuggerNonUserCode]
				public ItemStackData(ItemStackData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2944BA0", Offset = "0x29435A0", VA = "0x182944BA0", Slot = "10")]
				[DebuggerNonUserCode]
				public ItemStackData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2944C30", Offset = "0x2943630", VA = "0x182944C30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ItemStackData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2944E40", Offset = "0x2943840", VA = "0x182944E40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2944AD0", Offset = "0x29434D0", VA = "0x182944AD0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ItemStackData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2944CC0", Offset = "0x29436C0", VA = "0x182944CC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2944D80", Offset = "0x2943780", VA = "0x182944D80", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private static readonly MessageParser<ContainerInventoryStackData> _parser = (MessageParser<ContainerInventoryStackData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ContainerInventoryStackData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public const int DataFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly FieldCodec<Types.ActivityItemTypeStackData> _repeated_data_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly RepeatedField<Types.ActivityItemTypeStackData> data_ = (RepeatedField<Types.ActivityItemTypeStackData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public const int ItemExceptionsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly FieldCodec<Types.ItemStackData> _repeated_itemExceptions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly RepeatedField<Types.ItemStackData> itemExceptions_ = (RepeatedField<Types.ItemStackData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly Dictionary<ActivityItemType, int> data = (Dictionary<ActivityItemType, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<Item, int> itemExceptions;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public static MessageParser<ContainerInventoryStackData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x327E870", Offset = "0x327D270", VA = "0x18327E870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x327E7A0", Offset = "0x327D1A0", VA = "0x18327E7A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x327E8D0", Offset = "0x327D2D0", VA = "0x18327E8D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ActivityItemTypeStackData> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return data_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ItemStackData> ItemExceptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemExceptions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x327E6A0", Offset = "0x327D0A0", VA = "0x18327E6A0")]
		[DebuggerNonUserCode]
		public ContainerInventoryStackData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x327E4E0", Offset = "0x327CEE0", VA = "0x18327E4E0")]
		[DebuggerNonUserCode]
		public ContainerInventoryStackData(ContainerInventoryStackData other)
		{
			RepeatedField<Types.ActivityItemTypeStackData> repeatedField = (data_ = (RepeatedField<Types.ActivityItemTypeStackData>)(object)((RepeatedField<T>)(object)other.data_).Clone());
			RepeatedField<Types.ItemStackData> repeatedField2 = (itemExceptions_ = (RepeatedField<Types.ItemStackData>)(object)((RepeatedField<T>)(object)other.itemExceptions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x327D470", Offset = "0x327BE70", VA = "0x18327D470", Slot = "10")]
		[DebuggerNonUserCode]
		public ContainerInventoryStackData Clone()
		{
			//Discarded unreachable code: IL_006e
			ContainerInventoryStackData containerInventoryStackData = new ContainerInventoryStackData();
			RepeatedField<Types.ActivityItemTypeStackData> repeatedField = (containerInventoryStackData.data_ = (RepeatedField<Types.ActivityItemTypeStackData>)(object)new RepeatedField<T>());
			RepeatedField<Types.ItemStackData> repeatedField2 = (containerInventoryStackData.itemExceptions_ = (RepeatedField<Types.ItemStackData>)(object)new RepeatedField<T>());
			Dictionary<ActivityItemType, int> dictionary = (containerInventoryStackData.data = (Dictionary<ActivityItemType, int>)(object)new Dictionary<TKey, TValue>());
			RepeatedField<Types.ActivityItemTypeStackData> repeatedField3 = (containerInventoryStackData.data_ = (RepeatedField<Types.ActivityItemTypeStackData>)(object)((RepeatedField<T>)(object)data_).Clone());
			RepeatedField<Types.ItemStackData> repeatedField4 = (containerInventoryStackData.itemExceptions_ = (RepeatedField<Types.ItemStackData>)(object)((RepeatedField<T>)(object)itemExceptions_).Clone());
			UnknownFieldSet unknownFieldSet = (containerInventoryStackData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return containerInventoryStackData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x327D660", Offset = "0x327C060", VA = "0x18327D660", Slot = "0")]
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
				RepeatedField<Types.ActivityItemTypeStackData> repeatedField = data_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<Types.ItemStackData> repeatedField2 = itemExceptions_;
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

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x327D760", Offset = "0x327C160", VA = "0x18327D760", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ContainerInventoryStackData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.ActivityItemTypeStackData> repeatedField = data_;
				RepeatedField<Types.ActivityItemTypeStackData> repeatedField2 = other.data_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<Types.ItemStackData> repeatedField3 = itemExceptions_;
					RepeatedField<Types.ItemStackData> repeatedField4 = other.itemExceptions_;
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

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((RepeatedField<T>)(object)data_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)itemExceptions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x327E100", Offset = "0x327CB00", VA = "0x18327E100", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x327E160", Offset = "0x327CB60", VA = "0x18327E160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			RepeatedField<Types.ActivityItemTypeStackData> repeatedField = data_;
			FieldCodec<Types.ActivityItemTypeStackData> repeated_data_codec = _repeated_data_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_data_codec);
			RepeatedField<Types.ItemStackData> repeatedField2 = itemExceptions_;
			FieldCodec<Types.ItemStackData> repeated_itemExceptions_codec = _repeated_itemExceptions_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemExceptions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x327D310", Offset = "0x327BD10", VA = "0x18327D310", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RepeatedField<Types.ActivityItemTypeStackData> repeatedField = data_;
			FieldCodec<Types.ActivityItemTypeStackData> repeated_data_codec = _repeated_data_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_data_codec);
			RepeatedField<Types.ItemStackData> repeatedField2 = itemExceptions_;
			FieldCodec<Types.ItemStackData> repeated_itemExceptions_codec = _repeated_itemExceptions_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemExceptions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<Types.ActivityItemTypeStackData>)(repeatedField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x327DFB0", Offset = "0x327C9B0", VA = "0x18327DFB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ContainerInventoryStackData other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<Types.ActivityItemTypeStackData> repeatedField = data_;
				RepeatedField<Types.ActivityItemTypeStackData> repeatedField2 = other.data_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<Types.ItemStackData> repeatedField3 = itemExceptions_;
				RepeatedField<Types.ItemStackData> repeatedField4 = other.itemExceptions_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x327DE50", Offset = "0x327C850", VA = "0x18327DE50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005b
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.ActivityItemTypeStackData> repeatedField = data_;
					FieldCodec<Types.ActivityItemTypeStackData> repeated_data_codec = _repeated_data_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_data_codec);
				}
				if (num == 18)
				{
					RepeatedField<Types.ItemStackData> repeatedField2 = itemExceptions_;
					FieldCodec<Types.ItemStackData> repeated_itemExceptions_codec = _repeated_itemExceptions_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemExceptions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x327D820", Offset = "0x327C220", VA = "0x18327D820", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.ActivityItemTypeStackData> repeatedField = data_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.ItemStackData> repeatedField2 = itemExceptions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x327E050", Offset = "0x327CA50", VA = "0x18327E050", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x327D400", Offset = "0x327BE00", VA = "0x18327D400", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.ItemStackData> repeatedField = itemExceptions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x327D8B0", Offset = "0x327C2B0", VA = "0x18327D8B0")]
		public int GetStackAmount(Item item)
		{
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IBackpackItem backpackItem = default(IBackpackItem);
			bool flag = default(bool);
			if (backpackItem != null && flag)
			{
				if (itemExceptions == null)
				{
					RepeatedField<Types.ItemStackData> repeatedField = itemExceptions_;
					Func<Types.ItemStackData, Item> _003C_003E9__36_ = _003C_003Ec._003C_003E9__36_0;
					if (_003C_003E9__36_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Types.ItemStackData x)
						{
							//Discarded unreachable code: IL_000d
							int itemID_ = x.itemID_;
							return (Item)typeof(Item).TypeHandle;
						};
					}
					Func<Types.ItemStackData, int> func = default(Func<Types.ItemStackData, int>);
					if (_003C_003Ec._003C_003E9__36_1 == null)
					{
						func = (Func<Types.ItemStackData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.ItemStackData x) => x.amount_));
					}
					Dictionary<Types.ItemStackData, Item> dictionary = (Dictionary<Types.ItemStackData, Item>)(object)(itemExceptions = (Dictionary<Item, int>)(object)Enumerable.ToDictionary<Types.ItemStackData, Item, int>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__36_, (Func<, >)(object)func));
				}
				bool flag2 = default(bool);
				int amount_ = default(int);
				if (!flag2)
				{
					Dictionary<ActivityItemType, int> dictionary2 = data;
					bool flag3 = default(bool);
					if (!flag3)
					{
						RepeatedField<Types.ActivityItemTypeStackData> repeatedField2 = data_;
						ActivityItemType activityItemType = default(ActivityItemType);
						Func<Types.ActivityItemTypeStackData, bool> func2 = (Func<Types.ActivityItemTypeStackData, bool>)(object)(Func<T, TResult>)((Types.ActivityItemTypeStackData x) => x.activityItemType_ == activityItemType);
						Types.ActivityItemTypeStackData activityItemTypeStackData = Enumerable.FirstOrDefault<Types.ActivityItemTypeStackData>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func2);
						if (activityItemTypeStackData != null)
						{
							amount_ = activityItemTypeStackData.amount_;
						}
						Dictionary<ActivityItemType, int> dictionary3 = data;
						throw new NullReferenceException();
					}
				}
				return amount_;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x327DD80", Offset = "0x327C780", VA = "0x18327DD80")]
		public static bool IsContainerItem(Item item)
		{
			//Discarded unreachable code: IL_000e
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IBackpackItem backpackItem = default(IBackpackItem);
			return backpackItem != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x327E250", Offset = "0x327CC50", VA = "0x18327E250")]
		static ContainerInventoryStackData()
		{
			MessageParser<Types.ActivityItemTypeStackData> parser = Types.ActivityItemTypeStackData._parser;
			uint num = default(uint);
			_parser = (MessageParser<ContainerInventoryStackData>)(object)FieldCodec.ForMessage<Types.ActivityItemTypeStackData>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.ItemStackData> parser2 = Types.ItemStackData._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<ContainerInventoryStackData>)(object)FieldCodec.ForMessage<Types.ItemStackData>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
