using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003AB")]
	public sealed class WildCropsSpawningInVillageRecurringEventItemData : IMessage<WildCropsSpawningInVillageRecurringEventItemData>, IMessage, IEquatable<WildCropsSpawningInVillageRecurringEventItemData>, IDeepCloneable<WildCropsSpawningInVillageRecurringEventItemData>, IMessageFieldAccessor, IRecurringEventData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x20003AC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003AD")]
			public sealed class ItemAndWeight : IMessage<ItemAndWeight>, IMessage, IEquatable<ItemAndWeight>, IDeepCloneable<ItemAndWeight>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40012EC")]
				private static readonly MessageParser<ItemAndWeight> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40012ED")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40012EE")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40012EF")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x40012F0")]
				public const int WeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40012F1")]
				private int weight_;

				[Cpp2IlInjected.Token(Token = "0x17000AC1")]
				[DebuggerNonUserCode]
				public static MessageParser<ItemAndWeight> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002B45")]
					[Cpp2IlInjected.Address(RVA = "0x23718B0", Offset = "0x23702B0", VA = "0x1823718B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AC2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002B46")]
					[Cpp2IlInjected.Address(RVA = "0x2371830", Offset = "0x2370230", VA = "0x182371830")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AC3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002B47")]
					[Cpp2IlInjected.Address(RVA = "0x2371910", Offset = "0x2370310", VA = "0x182371910", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AC4")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002B4B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B4C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AC5")]
				[DebuggerNonUserCode]
				public int Weight
				{
					[Cpp2IlInjected.Token(Token = "0x6002B4D")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002B4E")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002B48")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ItemAndWeight()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B49")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public ItemAndWeight(ItemAndWeight other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B4A")]
				[Cpp2IlInjected.Address(RVA = "0x2371420", Offset = "0x236FE20", VA = "0x182371420", Slot = "10")]
				[DebuggerNonUserCode]
				public ItemAndWeight Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B4F")]
				[Cpp2IlInjected.Address(RVA = "0x23714B0", Offset = "0x236FEB0", VA = "0x1823714B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B50")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ItemAndWeight other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B51")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B52")]
				[Cpp2IlInjected.Address(RVA = "0x23716C0", Offset = "0x23700C0", VA = "0x1823716C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B53")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B54")]
				[Cpp2IlInjected.Address(RVA = "0x2371350", Offset = "0x236FD50", VA = "0x182371350", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B55")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ItemAndWeight other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B56")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B57")]
				[Cpp2IlInjected.Address(RVA = "0x2371540", Offset = "0x236FF40", VA = "0x182371540", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B58")]
				[Cpp2IlInjected.Address(RVA = "0x2371600", Offset = "0x2370000", VA = "0x182371600", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B59")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40012CF")]
		private static readonly MessageParser<WildCropsSpawningInVillageRecurringEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40012D0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40012D1")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40012D2")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40012D3")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40012D4")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40012D5")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40012D6")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40012D7")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40012D8")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40012D9")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40012DA")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40012DB")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40012DC")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x40012DD")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40012DE")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x40012DF")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40012E0")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x40012E1")]
		public const int GardenItemIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40012E2")]
		private int gardenItemID_;

		[Cpp2IlInjected.Token(Token = "0x40012E3")]
		public const int NumberOfGardensToSpawnFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40012E4")]
		private int numberOfGardensToSpawn_;

		[Cpp2IlInjected.Token(Token = "0x40012E5")]
		public const int MaximumAmountFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40012E6")]
		private int maximumAmount_;

		[Cpp2IlInjected.Token(Token = "0x40012E7")]
		public const int PossibleItemsFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x40012E8")]
		private static readonly FieldCodec<Types.ItemAndWeight> _repeated_possibleItems_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40012E9")]
		private readonly RepeatedField<Types.ItemAndWeight> possibleItems_ = (RepeatedField<Types.ItemAndWeight>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40012EA")]
		public const int AreaSpecificationFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40012EB")]
		private SpawnRecurringEventAreaSpecification areaSpecification_;

		[Cpp2IlInjected.Token(Token = "0x17000AAF")]
		[DebuggerNonUserCode]
		public static MessageParser<WildCropsSpawningInVillageRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002B15")]
			[Cpp2IlInjected.Address(RVA = "0x17CF5E0", Offset = "0x17CDFE0", VA = "0x1817CF5E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B16")]
			[Cpp2IlInjected.Address(RVA = "0x17CF510", Offset = "0x17CDF10", VA = "0x1817CF510")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B17")]
			[Cpp2IlInjected.Address(RVA = "0x17CF640", Offset = "0x17CE040", VA = "0x1817CF640", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB2")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002B1C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B1D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB3")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002B1E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B1F")]
			[Cpp2IlInjected.Address(RVA = "0x17CF830", Offset = "0x17CE230", VA = "0x1817CF830")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB4")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002B20")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "20")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B21")]
			[Cpp2IlInjected.Address(RVA = "0x17CF750", Offset = "0x17CE150", VA = "0x1817CF750")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB5")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002B22")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B23")]
			[Cpp2IlInjected.Address(RVA = "0x17CF7C0", Offset = "0x17CE1C0", VA = "0x1817CF7C0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB6")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002B24")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "22")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B25")]
			[Cpp2IlInjected.Address(RVA = "0x17CF8A0", Offset = "0x17CE2A0", VA = "0x1817CF8A0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB7")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002B26")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "14")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B27")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB8")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002B28")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B29")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB9")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002B2A")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "16")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B2B")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ABA")]
		[DebuggerNonUserCode]
		public int GardenItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002B2C")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return gardenItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B2D")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				gardenItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ABB")]
		[DebuggerNonUserCode]
		public int NumberOfGardensToSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6002B2E")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return numberOfGardensToSpawn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B2F")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				numberOfGardensToSpawn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ABC")]
		[DebuggerNonUserCode]
		public int MaximumAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6002B30")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get
			{
				return maximumAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B31")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				maximumAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ABD")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ItemAndWeight> PossibleItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002B32")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return possibleItems_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ABE")]
		[DebuggerNonUserCode]
		public SpawnRecurringEventAreaSpecification AreaSpecification
		{
			[Cpp2IlInjected.Token(Token = "0x6002B33")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return areaSpecification_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B34")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				areaSpecification_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ABF")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002B40")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC0")]
		public Item GardenItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002B41")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				int num = gardenItemID_;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B42")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				//IL_0007: Expected I4, but got O
				gardenItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B18")]
		[Cpp2IlInjected.Address(RVA = "0x17CF130", Offset = "0x17CDB30", VA = "0x1817CF130")]
		[DebuggerNonUserCode]
		public WildCropsSpawningInVillageRecurringEventItemData()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B19")]
		[Cpp2IlInjected.Address(RVA = "0x17CE750", Offset = "0x17CD150", VA = "0x1817CE750")]
		private void OnConstruction()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B1A")]
		[Cpp2IlInjected.Address(RVA = "0x17CF280", Offset = "0x17CDC80", VA = "0x1817CF280")]
		[DebuggerNonUserCode]
		public WildCropsSpawningInVillageRecurringEventItemData(WildCropsSpawningInVillageRecurringEventItemData other)
		{
			//IL_00d8: Expected O, but got I4
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			bool flag = other.activeByDefault_;
			int num2 = 0;
			activeByDefault_ = flag;
			RecurringEventIntervalData recurringEventIntervalData2 = other.intervalData_;
			if (recurringEventIntervalData2 != null)
			{
				RecurringEventIntervalData recurringEventIntervalData3 = recurringEventIntervalData2.Clone();
			}
			intervalData_ = (RecurringEventIntervalData)num2;
			bool flag2 = (executeOnAdd_ = other.executeOnAdd_);
			int num3 = (gardenItemID_ = other.gardenItemID_);
			int num4 = (numberOfGardensToSpawn_ = other.numberOfGardensToSpawn_);
			int num5 = (maximumAmount_ = other.maximumAmount_);
			RepeatedField<Types.ItemAndWeight> repeatedField = (possibleItems_ = (RepeatedField<Types.ItemAndWeight>)(object)((RepeatedField<T>)(object)other.possibleItems_).Clone());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification2 = other.areaSpecification_;
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification3 = default(SpawnRecurringEventAreaSpecification);
			if (spawnRecurringEventAreaSpecification2 != null)
			{
				spawnRecurringEventAreaSpecification3 = spawnRecurringEventAreaSpecification2.Clone();
			}
			areaSpecification_ = spawnRecurringEventAreaSpecification3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B1B")]
		[Cpp2IlInjected.Address(RVA = "0x17CDB60", Offset = "0x17CC560", VA = "0x1817CDB60", Slot = "10")]
		[DebuggerNonUserCode]
		public WildCropsSpawningInVillageRecurringEventItemData Clone()
		{
			return new WildCropsSpawningInVillageRecurringEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B35")]
		[Cpp2IlInjected.Address(RVA = "0x17CDD20", Offset = "0x17CC720", VA = "0x1817CDD20", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(WildCropsSpawningInVillageRecurringEventItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && activeByDefault_ == flag4)
								{
									bool flag5 = object.Equals(intervalData_, other);
									if (flag5 && executeOnAdd_ == flag5 && gardenItemID_ == (flag5 ? 1 : 0) && numberOfGardensToSpawn_ == (flag5 ? 1 : 0) && maximumAmount_ == (flag5 ? 1 : 0))
									{
										RepeatedField<Types.ItemAndWeight> repeatedField = possibleItems_;
										bool flag6 = default(bool);
										if (flag6 && object.Equals(areaSpecification_, other))
										{
											return object.Equals(_unknownFields, other);
										}
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

		[Cpp2IlInjected.Token(Token = "0x6002B36")]
		[Cpp2IlInjected.Address(RVA = "0x17CDBC0", Offset = "0x17CC5C0", VA = "0x1817CDBC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WildCropsSpawningInVillageRecurringEventItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									bool flag = other.activeByDefault_;
									if (activeByDefault_ == flag)
									{
										RecurringEventIntervalData objB = other.intervalData_;
										if (object.Equals(intervalData_, objB))
										{
											bool flag2 = other.executeOnAdd_;
											if (executeOnAdd_ == flag2)
											{
												int num2 = other.gardenItemID_;
												if (gardenItemID_ == num2)
												{
													int num3 = other.numberOfGardensToSpawn_;
													if (numberOfGardensToSpawn_ == num3)
													{
														int num4 = other.maximumAmount_;
														if (maximumAmount_ == num4)
														{
															RepeatedField<Types.ItemAndWeight> repeatedField = possibleItems_;
															RepeatedField<Types.ItemAndWeight> repeatedField2 = other.possibleItems_;
															if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
															{
																SpawnRecurringEventAreaSpecification objB2 = other.areaSpecification_;
																if (object.Equals(areaSpecification_, objB2))
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

		[Cpp2IlInjected.Token(Token = "0x6002B37")]
		[Cpp2IlInjected.Address(RVA = "0x17CE080", Offset = "0x17CCA80", VA = "0x1817CE080", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00ef
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (activeByDefault_)
			{
			}
			RecurringEventIntervalData recurringEventIntervalData = intervalData_;
			if (recurringEventIntervalData != null)
			{
				int hashCode5 = recurringEventIntervalData.GetHashCode();
			}
			if (executeOnAdd_)
			{
			}
			if (gardenItemID_ != 0)
			{
			}
			if (numberOfGardensToSpawn_ != 0)
			{
			}
			if (maximumAmount_ != 0)
			{
			}
			int hashCode6 = ((RepeatedField<T>)(object)possibleItems_).GetHashCode();
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = areaSpecification_;
			if (spawnRecurringEventAreaSpecification != null)
			{
				int hashCode7 = spawnRecurringEventAreaSpecification.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B38")]
		[Cpp2IlInjected.Address(RVA = "0x17CEC10", Offset = "0x17CD610", VA = "0x1817CEC10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B39")]
		[Cpp2IlInjected.Address(RVA = "0x17CEC70", Offset = "0x17CD670", VA = "0x1817CEC70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_016b
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (activeByDefault_)
			{
				bool value6 = activeByDefault_;
				output.WriteBool(value6);
			}
			if ((long)intervalData_ != 0)
			{
				RecurringEventIntervalData value7 = intervalData_;
				output.WriteMessage(value7);
			}
			if (executeOnAdd_)
			{
				bool value8 = executeOnAdd_;
				output.WriteBool(value8);
			}
			if (gardenItemID_ != 0)
			{
				int value9 = gardenItemID_;
				output.WriteInt32(value9);
			}
			if (numberOfGardensToSpawn_ != 0)
			{
				int value10 = numberOfGardensToSpawn_;
				output.WriteInt32(value10);
			}
			if (maximumAmount_ != 0)
			{
				int value11 = maximumAmount_;
				output.WriteInt32(value11);
			}
			RepeatedField<Types.ItemAndWeight> repeatedField = possibleItems_;
			FieldCodec<Types.ItemAndWeight> repeated_possibleItems_codec = _repeated_possibleItems_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_possibleItems_codec);
			if ((long)areaSpecification_ != 0)
			{
				SpawnRecurringEventAreaSpecification value12 = areaSpecification_;
				output.WriteMessage(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3A")]
		[Cpp2IlInjected.Address(RVA = "0x17CD6B0", Offset = "0x17CC0B0", VA = "0x1817CD6B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_018a
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			RecurringEventIntervalData recurringEventIntervalData = intervalData_;
			if (recurringEventIntervalData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(recurringEventIntervalData);
				num8++;
				num2 += num8;
			}
			int num9 = gardenItemID_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = numberOfGardensToSpawn_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = maximumAmount_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			RepeatedField<Types.ItemAndWeight> repeatedField = possibleItems_;
			FieldCodec<Types.ItemAndWeight> repeated_possibleItems_codec = _repeated_possibleItems_codec;
			int num15 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_possibleItems_codec);
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = areaSpecification_;
			num2 += num15;
			if (spawnRecurringEventAreaSpecification != null)
			{
				int num16 = CodedOutputStream.ComputeMessageSize(spawnRecurringEventAreaSpecification);
				num16++;
				num2 += num16;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
				num2 += num17;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3B")]
		[Cpp2IlInjected.Address(RVA = "0x17CE250", Offset = "0x17CCC50", VA = "0x1817CE250", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WildCropsSpawningInVillageRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_0192
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			bool flag = other.activeByDefault_;
			if (flag)
			{
				activeByDefault_ = flag;
			}
			if ((long)other.intervalData_ != 0)
			{
				RecurringEventIntervalData recurringEventIntervalData2 = default(RecurringEventIntervalData);
				if (intervalData_ == null)
				{
					RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
					recurringEventIntervalData2 = intervalData_;
				}
				RecurringEventIntervalData other2 = other.intervalData_;
				recurringEventIntervalData2.MergeFrom(other2);
			}
			bool flag2 = other.executeOnAdd_;
			if (flag2)
			{
				executeOnAdd_ = flag2;
			}
			int num2 = other.gardenItemID_;
			if (num2 != 0)
			{
				gardenItemID_ = num2;
			}
			int num3 = other.numberOfGardensToSpawn_;
			if (num3 != 0)
			{
				numberOfGardensToSpawn_ = num3;
			}
			int num4 = other.maximumAmount_;
			if (num4 != 0)
			{
				maximumAmount_ = num4;
			}
			RepeatedField<Types.ItemAndWeight> repeatedField = possibleItems_;
			RepeatedField<Types.ItemAndWeight> repeatedField2 = other.possibleItems_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.areaSpecification_ != 0)
			{
				SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification2 = default(SpawnRecurringEventAreaSpecification);
				if (areaSpecification_ == null)
				{
					SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
					spawnRecurringEventAreaSpecification2 = areaSpecification_;
				}
				SpawnRecurringEventAreaSpecification other3 = other.areaSpecification_;
				spawnRecurringEventAreaSpecification2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3C")]
		[Cpp2IlInjected.Address(RVA = "0x17CE460", Offset = "0x17CCE60", VA = "0x1817CE460", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01a4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 48)
			{
				if ((int)num > 72)
				{
					if ((int)num > 88)
					{
						if (num == 98)
						{
							RepeatedField<Types.ItemAndWeight> repeatedField = possibleItems_;
							FieldCodec<Types.ItemAndWeight> repeated_possibleItems_codec = _repeated_possibleItems_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_possibleItems_codec);
						}
						if (num != 106)
						{
							goto IL_018d;
						}
						SpawnRecurringEventAreaSpecification builder = default(SpawnRecurringEventAreaSpecification);
						if (areaSpecification_ == null)
						{
							SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
							builder = areaSpecification_;
						}
						input.ReadMessage(builder);
					}
					int num2 = default(int);
					if (num == 80)
					{
						num2 = (numberOfGardensToSpawn_ = input.ReadInt32());
					}
					if (num2 != 88)
					{
						goto IL_018d;
					}
					int num3 = (maximumAmount_ = input.ReadInt32());
				}
				RecurringEventIntervalData recurringEventIntervalData = default(RecurringEventIntervalData);
				if (num == 58)
				{
					RecurringEventIntervalData builder2 = default(RecurringEventIntervalData);
					if (intervalData_ == null)
					{
						recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
						builder2 = intervalData_;
					}
					input.ReadMessage(builder2);
				}
				bool flag = default(bool);
				if ((long)recurringEventIntervalData == 64)
				{
					flag = (executeOnAdd_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_018d;
				}
				int num4 = (gardenItemID_ = input.ReadInt32());
			}
			bool flag2 = default(bool);
			if ((int)num > 26)
			{
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 48)
				{
					goto IL_018d;
				}
				flag2 = (activeByDefault_ = input.ReadBool());
			}
			int num5 = default(int);
			if (flag2)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num5 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_018d;
			IL_018d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3D")]
		[Cpp2IlInjected.Address(RVA = "0x17CDEC0", Offset = "0x17CC8C0", VA = "0x1817CDEC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3E")]
		[Cpp2IlInjected.Address(RVA = "0x17CE7E0", Offset = "0x17CD1E0", VA = "0x1817CE7E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0039, IL_003a, IL_003b, IL_003c, IL_003d, IL_0043, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			if (fieldNumber - 1 <= 12)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3F")]
		[Cpp2IlInjected.Address(RVA = "0x17CD9B0", Offset = "0x17CC3B0", VA = "0x1817CD9B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001d
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 12)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B43")]
		[Cpp2IlInjected.Address(RVA = "0x17CDB60", Offset = "0x17CC560", VA = "0x1817CDB60", Slot = "23")]
		IItemData IItemData.Clone()
		{
			WildCropsSpawningInVillageRecurringEventItemData wildCropsSpawningInVillageRecurringEventItemData = new WildCropsSpawningInVillageRecurringEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B44")]
		[Cpp2IlInjected.Address(RVA = "0x17CEF60", Offset = "0x17CD960", VA = "0x1817CEF60")]
		static WildCropsSpawningInVillageRecurringEventItemData()
		{
			Func<WildCropsSpawningInVillageRecurringEventItemData> func = default(Func<WildCropsSpawningInVillageRecurringEventItemData>);
			_parser = (MessageParser<WildCropsSpawningInVillageRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.ItemAndWeight> parser = Types.ItemAndWeight._parser;
			uint num = default(uint);
			_parser = (MessageParser<WildCropsSpawningInVillageRecurringEventItemData>)(object)FieldCodec.ForMessage<Types.ItemAndWeight>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
