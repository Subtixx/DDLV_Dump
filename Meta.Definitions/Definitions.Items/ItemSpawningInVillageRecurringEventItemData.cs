using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200039D")]
	public sealed class ItemSpawningInVillageRecurringEventItemData : IMessage<ItemSpawningInVillageRecurringEventItemData>, IMessage, IEquatable<ItemSpawningInVillageRecurringEventItemData>, IDeepCloneable<ItemSpawningInVillageRecurringEventItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IRecurringEventData, IItemData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200039E")]
		public enum ToSpawnOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40012A5")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40012A6")]
			ItemType = 9,
			[Cpp2IlInjected.Token(Token = "0x40012A7")]
			ItemList = 10
		}

		[Cpp2IlInjected.Token(Token = "0x200039F")]
		public enum CustomConditionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40012A9")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40012AA")]
			WeedOverrides = 17
		}

		[Cpp2IlInjected.Token(Token = "0x20003A0")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003A1")]
			public sealed class ItemAndWeightList : IMessage<ItemAndWeightList>, IMessage, IEquatable<ItemAndWeightList>, IDeepCloneable<ItemAndWeightList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40012AB")]
				private static readonly MessageParser<ItemAndWeightList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40012AC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40012AD")]
				public const int ItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40012AE")]
				private static readonly FieldCodec<ItemAndWeight> _repeated_items_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40012AF")]
				private readonly RepeatedField<ItemAndWeight> items_;

				[Cpp2IlInjected.Token(Token = "0x17000A98")]
				[DebuggerNonUserCode]
				public static MessageParser<ItemAndWeightList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002AA4")]
					[Cpp2IlInjected.Address(RVA = "0x2944330", Offset = "0x2942D30", VA = "0x182944330")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A99")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AA5")]
					[Cpp2IlInjected.Address(RVA = "0x29442B0", Offset = "0x2942CB0", VA = "0x1829442B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A9A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AA6")]
					[Cpp2IlInjected.Address(RVA = "0x2944390", Offset = "0x2942D90", VA = "0x182944390", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A9B")]
				[DebuggerNonUserCode]
				public RepeatedField<ItemAndWeight> Items
				{
					[Cpp2IlInjected.Token(Token = "0x6002AAA")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002AA7")]
				[Cpp2IlInjected.Address(RVA = "0x2944130", Offset = "0x2942B30", VA = "0x182944130")]
				[DebuggerNonUserCode]
				public ItemAndWeightList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AA8")]
				[Cpp2IlInjected.Address(RVA = "0x29441B0", Offset = "0x2942BB0", VA = "0x1829441B0")]
				[DebuggerNonUserCode]
				public ItemAndWeightList(ItemAndWeightList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AA9")]
				[Cpp2IlInjected.Address(RVA = "0x2943950", Offset = "0x2942350", VA = "0x182943950", Slot = "10")]
				[DebuggerNonUserCode]
				public ItemAndWeightList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AAB")]
				[Cpp2IlInjected.Address(RVA = "0x2943B10", Offset = "0x2942510", VA = "0x182943B10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AAC")]
				[Cpp2IlInjected.Address(RVA = "0x2943A80", Offset = "0x2942480", VA = "0x182943A80", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ItemAndWeightList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AAD")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AAE")]
				[Cpp2IlInjected.Address(RVA = "0x2943E40", Offset = "0x2942840", VA = "0x182943E40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AAF")]
				[Cpp2IlInjected.Address(RVA = "0x2943EA0", Offset = "0x29428A0", VA = "0x182943EA0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB0")]
				[Cpp2IlInjected.Address(RVA = "0x2943840", Offset = "0x2942240", VA = "0x182943840", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB1")]
				[Cpp2IlInjected.Address(RVA = "0x2943D60", Offset = "0x2942760", VA = "0x182943D60", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ItemAndWeightList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB2")]
				[Cpp2IlInjected.Address(RVA = "0x2943C70", Offset = "0x2942670", VA = "0x182943C70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB3")]
				[Cpp2IlInjected.Address(RVA = "0x2943BF0", Offset = "0x29425F0", VA = "0x182943BF0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB4")]
				[Cpp2IlInjected.Address(RVA = "0x2943DE0", Offset = "0x29427E0", VA = "0x182943DE0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AB5")]
				[Cpp2IlInjected.Address(RVA = "0x29438F0", Offset = "0x29422F0", VA = "0x1829438F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003A3")]
			public sealed class ItemAndWeight : IMessage<ItemAndWeight>, IMessage, IEquatable<ItemAndWeight>, IDeepCloneable<ItemAndWeight>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40012B1")]
				private static readonly MessageParser<ItemAndWeight> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40012B2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40012B3")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40012B4")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x40012B5")]
				public const int WeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40012B6")]
				private int weight_;

				[Cpp2IlInjected.Token(Token = "0x17000A9C")]
				[DebuggerNonUserCode]
				public static MessageParser<ItemAndWeight> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002ABA")]
					[Cpp2IlInjected.Address(RVA = "0x29449B0", Offset = "0x29433B0", VA = "0x1829449B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A9D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002ABB")]
					[Cpp2IlInjected.Address(RVA = "0x2944930", Offset = "0x2943330", VA = "0x182944930")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A9E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002ABC")]
					[Cpp2IlInjected.Address(RVA = "0x2944A10", Offset = "0x2943410", VA = "0x182944A10", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A9F")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002AC1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AC2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA0")]
				[DebuggerNonUserCode]
				public int Weight
				{
					[Cpp2IlInjected.Token(Token = "0x6002AC3")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AC4")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002ABD")]
				[Cpp2IlInjected.Address(RVA = "0x1EE50B0", Offset = "0x1EE3AB0", VA = "0x181EE50B0")]
				[DebuggerNonUserCode]
				public ItemAndWeight()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ABE")]
				[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ABF")]
				[Cpp2IlInjected.Address(RVA = "0x29370F0", Offset = "0x2935AF0", VA = "0x1829370F0")]
				[DebuggerNonUserCode]
				public ItemAndWeight(ItemAndWeight other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC0")]
				[Cpp2IlInjected.Address(RVA = "0x2944520", Offset = "0x2942F20", VA = "0x182944520", Slot = "10")]
				[DebuggerNonUserCode]
				public ItemAndWeight Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC5")]
				[Cpp2IlInjected.Address(RVA = "0x29445B0", Offset = "0x2942FB0", VA = "0x1829445B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC6")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ItemAndWeight other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC7")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC8")]
				[Cpp2IlInjected.Address(RVA = "0x29447C0", Offset = "0x29431C0", VA = "0x1829447C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AC9")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACA")]
				[Cpp2IlInjected.Address(RVA = "0x2944450", Offset = "0x2942E50", VA = "0x182944450", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACB")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ItemAndWeight other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACC")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACD")]
				[Cpp2IlInjected.Address(RVA = "0x2944640", Offset = "0x2943040", VA = "0x182944640", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACE")]
				[Cpp2IlInjected.Address(RVA = "0x2944700", Offset = "0x2943100", VA = "0x182944700", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002ACF")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003A5")]
			public sealed class WeedOverridesData : IMessage<WeedOverridesData>, IMessage, IEquatable<WeedOverridesData>, IDeepCloneable<WeedOverridesData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40012B8")]
				private static readonly MessageParser<WeedOverridesData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40012B9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40012BA")]
				public const int FirstDailyWeedTreasureProbabilityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40012BB")]
				private int firstDailyWeedTreasureProbability_;

				[Cpp2IlInjected.Token(Token = "0x40012BC")]
				public const int WeedLootTableFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40012BD")]
				private int weedLootTable_;

				[Cpp2IlInjected.Token(Token = "0x17000AA1")]
				[DebuggerNonUserCode]
				public static MessageParser<WeedOverridesData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002AD4")]
					[Cpp2IlInjected.Address(RVA = "0x2FFA330", Offset = "0x2FF8D30", VA = "0x182FFA330")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AD5")]
					[Cpp2IlInjected.Address(RVA = "0x2FFA2B0", Offset = "0x2FF8CB0", VA = "0x182FFA2B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AD6")]
					[Cpp2IlInjected.Address(RVA = "0x2FFA390", Offset = "0x2FF8D90", VA = "0x182FFA390", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA4")]
				[DebuggerNonUserCode]
				public int FirstDailyWeedTreasureProbability
				{
					[Cpp2IlInjected.Token(Token = "0x6002ADA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002ADB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA5")]
				[DebuggerNonUserCode]
				public int WeedLootTable
				{
					[Cpp2IlInjected.Token(Token = "0x6002ADC")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002ADD")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002AD7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public WeedOverridesData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AD8")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public WeedOverridesData(WeedOverridesData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AD9")]
				[Cpp2IlInjected.Address(RVA = "0x2FF9EA0", Offset = "0x2FF88A0", VA = "0x182FF9EA0", Slot = "10")]
				[DebuggerNonUserCode]
				public WeedOverridesData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002ADE")]
				[Cpp2IlInjected.Address(RVA = "0x2FF9F30", Offset = "0x2FF8930", VA = "0x182FF9F30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002ADF")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(WeedOverridesData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE0")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE1")]
				[Cpp2IlInjected.Address(RVA = "0x2FFA140", Offset = "0x2FF8B40", VA = "0x182FFA140", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE2")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE3")]
				[Cpp2IlInjected.Address(RVA = "0x2FF9DD0", Offset = "0x2FF87D0", VA = "0x182FF9DD0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE4")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(WeedOverridesData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE5")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE6")]
				[Cpp2IlInjected.Address(RVA = "0x2FF9FC0", Offset = "0x2FF89C0", VA = "0x182FF9FC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE7")]
				[Cpp2IlInjected.Address(RVA = "0x2FFA080", Offset = "0x2FF8A80", VA = "0x182FFA080", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AE8")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003A7")]
			public sealed class SpawnAroundData : IMessage<SpawnAroundData>, IMessage, IEquatable<SpawnAroundData>, IDeepCloneable<SpawnAroundData>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20003A8")]
				public enum ItemSelectionOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x40012C8")]
					None,
					[Cpp2IlInjected.Token(Token = "0x40012C9")]
					GridItemID,
					[Cpp2IlInjected.Token(Token = "0x40012CA")]
					TagItemID
				}

				[Cpp2IlInjected.Token(Token = "0x40012BF")]
				private static readonly MessageParser<SpawnAroundData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40012C0")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40012C1")]
				public const int GridItemIDFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40012C2")]
				public const int TagItemIDFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x40012C3")]
				public const int RadiusFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40012C4")]
				private int radius_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40012C5")]
				private object itemSelection_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40012C6")]
				private ItemSelectionOneofCase itemSelectionCase_;

				[Cpp2IlInjected.Token(Token = "0x17000AA6")]
				[DebuggerNonUserCode]
				public static MessageParser<SpawnAroundData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002AED")]
					[Cpp2IlInjected.Address(RVA = "0x294B750", Offset = "0x294A150", VA = "0x18294B750")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA7")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AEE")]
					[Cpp2IlInjected.Address(RVA = "0x294B5F0", Offset = "0x2949FF0", VA = "0x18294B5F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA8")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002AEF")]
					[Cpp2IlInjected.Address(RVA = "0x294B890", Offset = "0x294A290", VA = "0x18294B890", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AA9")]
				[DebuggerNonUserCode]
				public int GridItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002AF4")]
					[Cpp2IlInjected.Address(RVA = "0x294B670", Offset = "0x294A070", VA = "0x18294B670")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AF5")]
					[Cpp2IlInjected.Address(RVA = "0x294B950", Offset = "0x294A350", VA = "0x18294B950")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAA")]
				[DebuggerNonUserCode]
				public int TagItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002AF6")]
					[Cpp2IlInjected.Address(RVA = "0x294B7B0", Offset = "0x294A1B0", VA = "0x18294B7B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AF7")]
					[Cpp2IlInjected.Address(RVA = "0x294B9C0", Offset = "0x294A3C0", VA = "0x18294B9C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAB")]
				[DebuggerNonUserCode]
				public int Radius
				{
					[Cpp2IlInjected.Token(Token = "0x6002AF8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002AF9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAC")]
				[DebuggerNonUserCode]
				public ItemSelectionOneofCase ItemSelectionCase
				{
					[Cpp2IlInjected.Token(Token = "0x6002AFA")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(ItemSelectionOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAD")]
				public Item? GridItem
				{
					[Cpp2IlInjected.Token(Token = "0x6002B09")]
					[Cpp2IlInjected.Address(RVA = "0x294B6E0", Offset = "0x294A0E0", VA = "0x18294B6E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AAE")]
				public Item? TagItem
				{
					[Cpp2IlInjected.Token(Token = "0x6002B0A")]
					[Cpp2IlInjected.Address(RVA = "0x294B820", Offset = "0x294A220", VA = "0x18294B820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002AF0")]
				[Cpp2IlInjected.Address(RVA = "0x294B3B0", Offset = "0x2949DB0", VA = "0x18294B3B0")]
				[DebuggerNonUserCode]
				public SpawnAroundData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AF1")]
				[Cpp2IlInjected.Address(RVA = "0x294AF90", Offset = "0x2949990", VA = "0x18294AF90")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AF2")]
				[Cpp2IlInjected.Address(RVA = "0x294B470", Offset = "0x2949E70", VA = "0x18294B470")]
				[DebuggerNonUserCode]
				public SpawnAroundData(SpawnAroundData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AF3")]
				[Cpp2IlInjected.Address(RVA = "0x294A630", Offset = "0x2949030", VA = "0x18294A630", Slot = "10")]
				[DebuggerNonUserCode]
				public SpawnAroundData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002AFB")]
				[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
				[DebuggerNonUserCode]
				public void ClearItemSelection()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002AFC")]
				[Cpp2IlInjected.Address(RVA = "0x294A7E0", Offset = "0x29491E0", VA = "0x18294A7E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AFD")]
				[Cpp2IlInjected.Address(RVA = "0x294A8C0", Offset = "0x29492C0", VA = "0x18294A8C0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(SpawnAroundData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AFE")]
				[Cpp2IlInjected.Address(RVA = "0x294AA50", Offset = "0x2949450", VA = "0x18294AA50", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002AFF")]
				[Cpp2IlInjected.Address(RVA = "0x294B170", Offset = "0x2949B70", VA = "0x18294B170", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B00")]
				[Cpp2IlInjected.Address(RVA = "0x294B1D0", Offset = "0x2949BD0", VA = "0x18294B1D0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B01")]
				[Cpp2IlInjected.Address(RVA = "0x294A350", Offset = "0x2948D50", VA = "0x18294A350", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B02")]
				[Cpp2IlInjected.Address(RVA = "0x294AE40", Offset = "0x2949840", VA = "0x18294AE40", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(SpawnAroundData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B03")]
				[Cpp2IlInjected.Address(RVA = "0x294AED0", Offset = "0x29498D0", VA = "0x18294AED0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B04")]
				[Cpp2IlInjected.Address(RVA = "0x294A970", Offset = "0x2949370", VA = "0x18294A970", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002B05")]
				[Cpp2IlInjected.Address(RVA = "0x294B050", Offset = "0x2949A50", VA = "0x18294B050", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B06")]
				[Cpp2IlInjected.Address(RVA = "0x294A4F0", Offset = "0x2948EF0", VA = "0x18294A4F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B07")]
				[Cpp2IlInjected.Address(RVA = "0x294ABA0", Offset = "0x29495A0", VA = "0x18294ABA0", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002B08")]
				[Cpp2IlInjected.Address(RVA = "0x294A5C0", Offset = "0x2948FC0", VA = "0x18294A5C0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002B0B")]
				[Cpp2IlInjected.Address(RVA = "0x294AC50", Offset = "0x2949650", VA = "0x18294AC50")]
				public bool IsItemValid(Item item)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400127D")]
		private static readonly MessageParser<ItemSpawningInVillageRecurringEventItemData> _parser = (MessageParser<ItemSpawningInVillageRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemSpawningInVillageRecurringEventItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400127E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400127F")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001280")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001281")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001282")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001283")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001284")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001285")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001286")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001287")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001288")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001289")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400128A")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x400128B")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400128C")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x400128D")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400128E")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x400128F")]
		public const int ItemTypeFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001290")]
		public const int ItemListFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4001291")]
		public const int MinNumberOfSpawnFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001292")]
		private int minNumberOfSpawn_;

		[Cpp2IlInjected.Token(Token = "0x4001293")]
		public const int MaxNumberOfSpawnFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001294")]
		private int maxNumberOfSpawn_;

		[Cpp2IlInjected.Token(Token = "0x4001295")]
		public const int MaximumAmountFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001296")]
		private int maximumAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001297")]
		public const int RandomOrientationFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001298")]
		private bool randomOrientation_;

		[Cpp2IlInjected.Token(Token = "0x4001299")]
		public const int AreaSpecificationFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400129A")]
		private SpawnRecurringEventAreaSpecification areaSpecification_;

		[Cpp2IlInjected.Token(Token = "0x400129B")]
		public const int SpawnAroundFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400129C")]
		private Types.SpawnAroundData spawnAround_;

		[Cpp2IlInjected.Token(Token = "0x400129D")]
		public const int WeedOverridesFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x400129E")]
		public const int ConditionsFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400129F")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40012A0")]
		private object toSpawn_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40012A1")]
		private ToSpawnOneofCase toSpawnCase_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40012A2")]
		private object customConditions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40012A3")]
		private CustomConditionsOneofCase customConditionsCase_;

		[Cpp2IlInjected.Token(Token = "0x17000A80")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemSpawningInVillageRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002A62")]
			[Cpp2IlInjected.Address(RVA = "0x63F840", Offset = "0x63E240", VA = "0x18063F840")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A81")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002A63")]
			[Cpp2IlInjected.Address(RVA = "0x63F660", Offset = "0x63E060", VA = "0x18063F660")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A82")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002A64")]
			[Cpp2IlInjected.Address(RVA = "0x63F930", Offset = "0x63E330", VA = "0x18063F930", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A83")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002A69")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "19")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A6A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A84")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002A6B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "21")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A6C")]
			[Cpp2IlInjected.Address(RVA = "0x63FC20", Offset = "0x63E620", VA = "0x18063FC20")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A85")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002A6D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "22")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A6E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA70", Offset = "0x63E470", VA = "0x18063FA70")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A86")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002A6F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "23")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A70")]
			[Cpp2IlInjected.Address(RVA = "0x63FAF0", Offset = "0x63E4F0", VA = "0x18063FAF0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A87")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002A71")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "24")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A72")]
			[Cpp2IlInjected.Address(RVA = "0x63FC90", Offset = "0x63E690", VA = "0x18063FC90")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A88")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002A73")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "16")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A74")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A89")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002A75")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "17")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A76")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8A")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002A77")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "18")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A78")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8B")]
		[DebuggerNonUserCode]
		public ItemTypeSelector ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6002A79")]
			[Cpp2IlInjected.Address(RVA = "0x63F7B0", Offset = "0x63E1B0", VA = "0x18063F7B0")]
			get
			{
				int num = 0;
				if (toSpawnCase_ == ToSpawnOneofCase.ItemType)
				{
					object obj = toSpawn_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A7A")]
			[Cpp2IlInjected.Address(RVA = "0x63FBB0", Offset = "0x63E5B0", VA = "0x18063FBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8C")]
		[DebuggerNonUserCode]
		public Types.ItemAndWeightList ItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6002A7B")]
			[Cpp2IlInjected.Address(RVA = "0x63F750", Offset = "0x63E150", VA = "0x18063F750")]
			get
			{
				int num = 0;
				if (toSpawnCase_ == ToSpawnOneofCase.ItemList)
				{
					object obj = toSpawn_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A7C")]
			[Cpp2IlInjected.Address(RVA = "0x63FB70", Offset = "0x63E570", VA = "0x18063FB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8D")]
		[DebuggerNonUserCode]
		public int MinNumberOfSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6002A7D")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return minNumberOfSpawn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A7E")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				minNumberOfSpawn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8E")]
		[DebuggerNonUserCode]
		public int MaxNumberOfSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6002A7F")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return maxNumberOfSpawn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A80")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				maxNumberOfSpawn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8F")]
		[DebuggerNonUserCode]
		public int MaximumAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6002A81")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get
			{
				return maximumAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A82")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				maximumAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A90")]
		[DebuggerNonUserCode]
		public bool RandomOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x6002A83")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return randomOrientation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A84")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				randomOrientation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A91")]
		[DebuggerNonUserCode]
		public SpawnRecurringEventAreaSpecification AreaSpecification
		{
			[Cpp2IlInjected.Token(Token = "0x6002A85")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return areaSpecification_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A86")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				areaSpecification_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A92")]
		[DebuggerNonUserCode]
		public Types.SpawnAroundData SpawnAround
		{
			[Cpp2IlInjected.Token(Token = "0x6002A87")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return spawnAround_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A88")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				spawnAround_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A93")]
		[DebuggerNonUserCode]
		public Types.WeedOverridesData WeedOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x6002A89")]
			[Cpp2IlInjected.Address(RVA = "0x63F8D0", Offset = "0x63E2D0", VA = "0x18063F8D0")]
			get
			{
				int num = 0;
				if (customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
				{
					object obj = customConditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A8A")]
			[Cpp2IlInjected.Address(RVA = "0x63FD20", Offset = "0x63E720", VA = "0x18063FD20")]
			set
			{
				customConditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A94")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6002A8B")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002A8C")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A95")]
		[DebuggerNonUserCode]
		public ToSpawnOneofCase ToSpawnCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002A8D")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return toSpawnCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A96")]
		[DebuggerNonUserCode]
		public CustomConditionsOneofCase CustomConditionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002A8F")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return customConditionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A97")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002A9E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "20")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A65")]
		[Cpp2IlInjected.Address(RVA = "0x63F4E0", Offset = "0x63DEE0", VA = "0x18063F4E0")]
		[DebuggerNonUserCode]
		public ItemSpawningInVillageRecurringEventItemData()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A66")]
		[Cpp2IlInjected.Address(RVA = "0x63E340", Offset = "0x63CD40", VA = "0x18063E340")]
		private void OnConstruction()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A67")]
		[Cpp2IlInjected.Address(RVA = "0x63F050", Offset = "0x63DA50", VA = "0x18063F050")]
		[DebuggerNonUserCode]
		public ItemSpawningInVillageRecurringEventItemData(ItemSpawningInVillageRecurringEventItemData other)
		{
			//IL_00d8: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			//IL_0164: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_01c2: Expected I4, but got O
			//IL_01ce: Expected I4, but got O
			//IL_01d7: Expected O, but got I4
			//IL_01f2: Expected I4, but got I8
			//IL_0217: Expected I4, but got O
			//IL_023a: Expected I4, but got O
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
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
			int num3 = (minNumberOfSpawn_ = other.minNumberOfSpawn_);
			int num4 = (maxNumberOfSpawn_ = other.maxNumberOfSpawn_);
			int num5 = (maximumAmount_ = other.maximumAmount_);
			bool flag3 = (randomOrientation_ = other.randomOrientation_);
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification2 = other.areaSpecification_;
			if (spawnRecurringEventAreaSpecification2 != null)
			{
				SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification3 = spawnRecurringEventAreaSpecification2.Clone();
			}
			areaSpecification_ = (SpawnRecurringEventAreaSpecification)num2;
			Types.SpawnAroundData spawnAroundData = other.spawnAround_;
			if (spawnAroundData != null)
			{
				Types.SpawnAroundData spawnAroundData2 = spawnAroundData.Clone();
			}
			spawnAround_ = (Types.SpawnAroundData)num2;
			ConditionsList conditionsList2 = other.conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			conditions_ = (ConditionsList)num2;
			UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
			if (other.toSpawnCase_ == ToSpawnOneofCase.ItemType)
			{
				ToSpawnOneofCase toSpawnOneofCase = other.toSpawnCase_;
				if (other.toSpawn_ == null)
				{
					throw new InvalidCastException();
				}
				ItemTypeSelector itemTypeSelector = new ItemTypeSelector();
				itemTypeSelector.subType_ = "";
				int num6 = 0;
				itemTypeSelector.itemType_ = (ItemType)"";
				itemTypeSelector.restrictSubType_ = (byte)(int)"" != 0;
				itemTypeSelector.subType_ = (string)num6;
				itemTypeSelector._unknownFields = unknownFieldSet;
				toSpawn_ = itemTypeSelector;
				toSpawnCase_ = ToSpawnOneofCase.ItemType;
			}
			if ((long)unknownFieldSet == 10)
			{
				toSpawnCase_ = (ToSpawnOneofCase)(toSpawn_ = other.ItemList.Clone());
			}
			if (other.customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
			{
				if (other.customConditions_ == null)
				{
					throw new InvalidCastException();
				}
				Types.WeedOverridesData weedOverridesData = default(Types.WeedOverridesData);
				customConditions_ = weedOverridesData;
				customConditionsCase_ = (CustomConditionsOneofCase)weedOverridesData;
			}
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A68")]
		[Cpp2IlInjected.Address(RVA = "0x63CA60", Offset = "0x63B460", VA = "0x18063CA60", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemSpawningInVillageRecurringEventItemData Clone()
		{
			return new ItemSpawningInVillageRecurringEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A8E")]
		[Cpp2IlInjected.Address(RVA = "0x63CA40", Offset = "0x63B440", VA = "0x18063CA40")]
		[DebuggerNonUserCode]
		public void ClearToSpawn()
		{
			int num = (int)(toSpawnCase_ = ToSpawnOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A90")]
		[Cpp2IlInjected.Address(RVA = "0x63C790", Offset = "0x63B190", VA = "0x18063C790")]
		[DebuggerNonUserCode]
		public void ClearCustomConditions()
		{
			//IL_0010: Expected O, but got I4
			customConditions_ = (customConditionsCase_ = CustomConditionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A91")]
		[Cpp2IlInjected.Address(RVA = "0x63D0D0", Offset = "0x63BAD0", VA = "0x18063D0D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ItemSpawningInVillageRecurringEventItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A92")]
		[Cpp2IlInjected.Address(RVA = "0x63CEB0", Offset = "0x63B8B0", VA = "0x18063CEB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemSpawningInVillageRecurringEventItemData other)
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
												ItemTypeSelector itemType = ItemType;
												ItemTypeSelector itemType2 = other.ItemType;
												if (object.Equals(itemType, itemType2))
												{
													Types.ItemAndWeightList itemList = ItemList;
													Types.ItemAndWeightList itemList2 = other.ItemList;
													if (object.Equals(itemList, itemList2))
													{
														int num2 = other.minNumberOfSpawn_;
														if (minNumberOfSpawn_ == num2)
														{
															int num3 = other.maxNumberOfSpawn_;
															if (maxNumberOfSpawn_ == num3)
															{
																int num4 = other.maximumAmount_;
																if (maximumAmount_ == num4)
																{
																	bool flag3 = other.randomOrientation_;
																	if (randomOrientation_ == flag3)
																	{
																		SpawnRecurringEventAreaSpecification objB2 = other.areaSpecification_;
																		if (object.Equals(areaSpecification_, objB2))
																		{
																			Types.SpawnAroundData objB3 = other.spawnAround_;
																			if (object.Equals(spawnAround_, objB3))
																			{
																				Types.WeedOverridesData weedOverrides = WeedOverrides;
																				Types.WeedOverridesData weedOverrides2 = other.WeedOverrides;
																				if (object.Equals(weedOverrides, weedOverrides2))
																				{
																					ConditionsList objB4 = other.conditions_;
																					if (object.Equals(conditions_, objB4))
																					{
																						ToSpawnOneofCase toSpawnOneofCase = other.toSpawnCase_;
																						if (toSpawnCase_ == toSpawnOneofCase)
																						{
																							CustomConditionsOneofCase customConditionsOneofCase = other.customConditionsCase_;
																							if (customConditionsCase_ == customConditionsOneofCase)
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
									}
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A93")]
		[Cpp2IlInjected.Address(RVA = "0x63D350", Offset = "0x63BD50", VA = "0x18063D350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0184
			do
			{
				int num = iD_;
				int num2 = 0;
				if (num != 0)
				{
				}
				string text = name_;
				if (text.m_stringLength != num2)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = displayName_;
				if (text2.m_stringLength != num2)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = iconAddress_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = prefabAddress_;
				if (text4.m_stringLength != num2)
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
			}
			while (toSpawnCase_ != ToSpawnOneofCase.ItemType);
			object obj = toSpawn_;
			if (obj != null)
			{
				int hashCode6 = obj.GetHashCode();
				if (toSpawnCase_ == ToSpawnOneofCase.ItemList)
				{
					object obj2 = toSpawn_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode7 = obj2.GetHashCode();
				}
				if (minNumberOfSpawn_ != 0)
				{
				}
				if (maxNumberOfSpawn_ != 0)
				{
				}
				if (maximumAmount_ != 0)
				{
				}
				if (randomOrientation_)
				{
				}
				SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = areaSpecification_;
				if (spawnRecurringEventAreaSpecification != null)
				{
					int hashCode8 = spawnRecurringEventAreaSpecification.GetHashCode();
				}
				Types.SpawnAroundData spawnAroundData = spawnAround_;
				if (spawnAroundData != null)
				{
					int hashCode9 = spawnAroundData.GetHashCode();
				}
				if (customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
				{
					object obj3 = customConditions_;
					if (obj3 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode10 = obj3.GetHashCode();
				}
				ConditionsList conditionsList = conditions_;
				if (conditionsList != null)
				{
					int hashCode11 = conditionsList.GetHashCode();
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode12 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A94")]
		[Cpp2IlInjected.Address(RVA = "0x63E9F0", Offset = "0x63D3F0", VA = "0x18063E9F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A95")]
		[Cpp2IlInjected.Address(RVA = "0x63EAC0", Offset = "0x63D4C0", VA = "0x18063EAC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0225
			ToSpawnOneofCase toSpawnOneofCase;
			int num;
			do
			{
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
				toSpawnOneofCase = toSpawnCase_;
				num = 0;
			}
			while (toSpawnOneofCase != ToSpawnOneofCase.ItemType);
			if (toSpawnCase_ == ToSpawnOneofCase.ItemType)
			{
				object obj = toSpawn_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (toSpawnCase_ == ToSpawnOneofCase.ItemList && toSpawnCase_ == ToSpawnOneofCase.ItemList)
			{
				object obj2 = toSpawn_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (minNumberOfSpawn_ != num)
			{
				int value9 = minNumberOfSpawn_;
				output.WriteInt32(value9);
			}
			if (maxNumberOfSpawn_ != num)
			{
				int value10 = maxNumberOfSpawn_;
				output.WriteInt32(value10);
			}
			if (maximumAmount_ != num)
			{
				int value11 = maximumAmount_;
				output.WriteInt32(value11);
			}
			if ((randomOrientation_ ? 1 : 0) != num)
			{
				bool value12 = randomOrientation_;
				output.WriteBool(value12);
			}
			if ((IntPtr)areaSpecification_ != (IntPtr)num)
			{
				SpawnRecurringEventAreaSpecification value13 = areaSpecification_;
				output.WriteMessage(value13);
			}
			if ((IntPtr)spawnAround_ != (IntPtr)num)
			{
				Types.SpawnAroundData value14 = spawnAround_;
				output.WriteMessage(value14);
			}
			if (customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides && customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
			{
				object obj3 = customConditions_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
			}
			if ((long)conditions_ != 0)
			{
				ConditionsList value15 = conditions_;
				output.WriteMessage(value15);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A96")]
		[Cpp2IlInjected.Address(RVA = "0x63C2D0", Offset = "0x63ACD0", VA = "0x18063C2D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0240
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
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
			if (toSpawnCase_ == ToSpawnOneofCase.ItemType)
			{
				if (toSpawnCase_ != ToSpawnOneofCase.ItemType)
				{
				}
				object obj = toSpawn_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num9 = default(int);
				num2 += num9;
			}
			if (toSpawnCase_ == ToSpawnOneofCase.ItemList)
			{
				if (toSpawnCase_ != ToSpawnOneofCase.ItemList)
				{
				}
				object obj2 = toSpawn_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num10 = default(int);
				num2 += num10;
			}
			int num11 = minNumberOfSpawn_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = maxNumberOfSpawn_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			int num15 = maximumAmount_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = areaSpecification_;
			if (spawnRecurringEventAreaSpecification != null)
			{
				int num17 = CodedOutputStream.ComputeMessageSize(spawnRecurringEventAreaSpecification);
				num17++;
				num2 += num17;
			}
			Types.SpawnAroundData spawnAroundData = spawnAround_;
			if (spawnAroundData != null)
			{
				int num18 = CodedOutputStream.ComputeMessageSize(spawnAroundData);
				num18 += 2;
				num2 += num18;
			}
			if (customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
			{
				if (customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
				{
					object obj3 = customConditions_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num19 = default(int);
				num2 += num19;
			}
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num20 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num20 += 2;
				num2 += num20;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num21 = unknownFields.CalculateSize();
				num2 += num21;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A97")]
		[Cpp2IlInjected.Address(RVA = "0x63D890", Offset = "0x63C290", VA = "0x18063D890", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemSpawningInVillageRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_0349
			//IL_0221: Expected I4, but got I8
			//IL_02cd: Expected I4, but got O
			//IL_0310: Expected I4, but got O
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
			int num2 = other.minNumberOfSpawn_;
			if (num2 != 0)
			{
				minNumberOfSpawn_ = num2;
			}
			int num3 = other.maxNumberOfSpawn_;
			if (num3 != 0)
			{
				maxNumberOfSpawn_ = num3;
			}
			int num4 = other.maximumAmount_;
			if (num4 != 0)
			{
				maximumAmount_ = num4;
			}
			bool flag3 = other.randomOrientation_;
			if (flag3)
			{
				randomOrientation_ = flag3;
			}
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
			if ((long)other.spawnAround_ != 0)
			{
				Types.SpawnAroundData spawnAroundData2 = default(Types.SpawnAroundData);
				if (spawnAround_ == null)
				{
					Types.SpawnAroundData spawnAroundData = (spawnAround_ = new Types.SpawnAroundData());
					spawnAroundData2 = spawnAround_;
				}
				Types.SpawnAroundData other4 = other.spawnAround_;
				spawnAroundData2.MergeFrom(other4);
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					conditionsList2 = conditions_;
				}
				ConditionsList other5 = other.conditions_;
				conditionsList2.MergeFrom(other5);
			}
			UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
			if (other.toSpawnCase_ == ToSpawnOneofCase.ItemType)
			{
				if (ItemType == null)
				{
					ItemTypeSelector itemTypeSelector = new ItemTypeSelector();
					itemTypeSelector.subType_ = "";
					toSpawn_ = itemTypeSelector;
					toSpawnCase_ = ToSpawnOneofCase.ItemType;
				}
				ItemTypeSelector itemType = ItemType;
				ItemTypeSelector itemType2 = other.ItemType;
				if (itemType2 == null)
				{
					goto IL_02e6;
				}
				ItemType itemType_ = itemType2.itemType_;
				if (itemType_ != 0)
				{
					itemType.itemType_ = itemType_;
				}
				bool restrictSubType_ = itemType2.restrictSubType_;
				if (restrictSubType_)
				{
					itemType.restrictSubType_ = restrictSubType_;
				}
				string subType_ = itemType2.subType_;
				if (subType_.m_stringLength != 0)
				{
					itemType.SubType = subType_;
				}
				UnknownFieldSet unknownFields = itemType2._unknownFields;
				unknownFieldSet = (itemType._unknownFields = UnknownFieldSet.MergeFrom(itemType._unknownFields, unknownFields));
			}
			if ((long)unknownFieldSet == 10)
			{
				if (ItemList == null)
				{
					toSpawnCase_ = (ToSpawnOneofCase)(toSpawn_ = new Types.ItemAndWeightList());
				}
				Types.ItemAndWeightList itemList = ItemList;
				Types.ItemAndWeightList itemList2 = other.ItemList;
				itemList.MergeFrom(itemList2);
			}
			goto IL_02e6;
			IL_02e6:
			if (other.customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
			{
				if (WeedOverrides == null)
				{
					customConditionsCase_ = (CustomConditionsOneofCase)(customConditions_ = new Types.WeedOverridesData());
				}
				Types.WeedOverridesData weedOverrides = WeedOverrides;
				Types.WeedOverridesData weedOverrides2 = other.WeedOverrides;
				weedOverrides.MergeFrom(weedOverrides2);
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6002A98")]
		[Cpp2IlInjected.Address(RVA = "0x63DD60", Offset = "0x63C760", VA = "0x18063DD60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a3: Expected I4, but got O
			//IL_01a8: Expected I4, but got O
			//IL_0271: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 74)
			{
				if ((int)num > 104)
				{
					if ((int)num > 122)
					{
						if (num == 130)
						{
							Types.SpawnAroundData spawnAroundData = spawnAround_;
							if (spawnAroundData == null)
							{
								Types.SpawnAroundData spawnAroundData2 = (spawnAround_ = new Types.SpawnAroundData());
							}
							input.ReadMessage(spawnAroundData);
						}
						if (num == 138)
						{
							Types.WeedOverridesData builder = new Types.WeedOverridesData();
							if (customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
							{
								if (customConditionsCase_ != CustomConditionsOneofCase.WeedOverrides)
								{
								}
								object obj = customConditions_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder);
							customConditions_ = builder;
							customConditionsCase_ = (CustomConditionsOneofCase)typeof(Types.WeedOverridesData).TypeHandle;
						}
						if ((long)typeof(Types.WeedOverridesData).TypeHandle != 146)
						{
							goto IL_0303;
						}
						ConditionsList builder2 = default(ConditionsList);
						if (conditions_ == null)
						{
							ConditionsList conditionsList = (conditions_ = new ConditionsList());
							builder2 = conditions_;
						}
						input.ReadMessage(builder2);
					}
					bool flag = default(bool);
					if (num == 112)
					{
						flag = (randomOrientation_ = input.ReadBool());
					}
					if (!flag)
					{
						goto IL_0303;
					}
					SpawnRecurringEventAreaSpecification builder3 = default(SpawnRecurringEventAreaSpecification);
					if (areaSpecification_ == null)
					{
						SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
						builder3 = areaSpecification_;
					}
					input.ReadMessage(builder3);
				}
				int num3 = default(int);
				if ((int)num > 88)
				{
					int num2 = default(int);
					if (num == 96)
					{
						num2 = (maxNumberOfSpawn_ = input.ReadInt32());
					}
					if (num2 != 104)
					{
						goto IL_0303;
					}
					num3 = (maximumAmount_ = input.ReadInt32());
				}
				if (num3 == 82)
				{
					Types.ItemAndWeightList builder4 = new Types.ItemAndWeightList();
					if (toSpawnCase_ == ToSpawnOneofCase.ItemList)
					{
						if (toSpawnCase_ != ToSpawnOneofCase.ItemList)
						{
						}
						object obj2 = toSpawn_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder4);
					toSpawn_ = builder4;
					toSpawnCase_ = (ToSpawnOneofCase)typeof(Types.ItemAndWeightList).TypeHandle;
				}
				if ((long)typeof(Types.ItemAndWeightList).TypeHandle != 88)
				{
					goto IL_0303;
				}
				int num4 = (minNumberOfSpawn_ = input.ReadInt32());
			}
			bool flag3 = default(bool);
			if ((int)num > 34)
			{
				if ((int)num > 48)
				{
					RecurringEventIntervalData recurringEventIntervalData = default(RecurringEventIntervalData);
					if (num == 58)
					{
						RecurringEventIntervalData builder5 = default(RecurringEventIntervalData);
						if (intervalData_ == null)
						{
							recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
							builder5 = intervalData_;
						}
						input.ReadMessage(builder5);
					}
					bool flag2 = default(bool);
					if ((long)recurringEventIntervalData == 64)
					{
						flag2 = (executeOnAdd_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_0303;
					}
					ItemTypeSelector builder6 = new ItemTypeSelector();
					if (toSpawnCase_ == ToSpawnOneofCase.ItemType)
					{
						if (toSpawnCase_ != ToSpawnOneofCase.ItemType)
						{
						}
						object obj3 = toSpawn_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder6);
					toSpawn_ = builder6;
					toSpawnCase_ = (ToSpawnOneofCase)typeof(ItemTypeSelector).TypeHandle;
				}
				string text2 = default(string);
				if ((long)typeof(ItemTypeSelector).TypeHandle == 42)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				if ((long)text2 != 48)
				{
					goto IL_0303;
				}
				flag3 = (activeByDefault_ = input.ReadBool());
			}
			string text6 = default(string);
			if ((flag3 ? 1 : 0) > (true ? 1 : 0))
			{
				string text4 = default(string);
				if (flag3)
				{
					text4 = (DisplayName = input.ReadString());
				}
				if ((long)text4 != 34)
				{
					goto IL_0303;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text6 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_0303;
			IL_0303:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002A99")]
		[Cpp2IlInjected.Address(RVA = "0x63D130", Offset = "0x63BB30", VA = "0x18063D130", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 17)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9A")]
		[Cpp2IlInjected.Address(RVA = "0x63E410", Offset = "0x63CE10", VA = "0x18063E410", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0015, IL_001c, IL_001d, IL_0021, IL_0028, IL_0029, IL_002d, IL_0034, IL_0035, IL_0039, IL_0040, IL_0041, IL_0042, IL_0046, IL_004b, IL_004c, IL_0050, IL_0054, IL_0055, IL_0059, IL_005d, IL_005e, IL_005f, IL_0060, IL_0061, IL_0062, IL_0066, IL_006a, IL_006e, IL_0072, IL_0076, IL_007a, IL_007b, IL_007f, IL_0083, IL_0089, IL_008f, IL_0095, IL_009b, IL_00a1, IL_00a7, IL_00ad, IL_00b3, IL_00b9, IL_00bf
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 17)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9B")]
		[Cpp2IlInjected.Address(RVA = "0x63C7B0", Offset = "0x63B1B0", VA = "0x18063C7B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0014, IL_0020, IL_002c, IL_0038, IL_0044, IL_004c, IL_0054, IL_0065, IL_006f, IL_0079, IL_0085, IL_008d, IL_00a1
			//IL_005d: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			if (fieldNumber - 1 <= 17)
			{
				int num = (iD_ = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9C")]
		[Cpp2IlInjected.Address(RVA = "0x63D6D0", Offset = "0x63C0D0", VA = "0x18063D6D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null)
			{
				if (string.Equals(oneofName, "ToSpawn"))
				{
					ToSpawnOneofCase toSpawnOneofCase = toSpawnCase_;
				}
				if (string.Equals(oneofName, "CustomConditions"))
				{
					CustomConditionsOneofCase customConditionsOneofCase = customConditionsCase_;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9D")]
		[Cpp2IlInjected.Address(RVA = "0x63C9A0", Offset = "0x63B3A0", VA = "0x18063C9A0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0039: Expected O, but got I4
			if (oneofName != null)
			{
				if (string.Equals(oneofName, "ToSpawn"))
				{
					int num = (int)(toSpawnCase_ = ToSpawnOneofCase.None);
				}
				if (string.Equals(oneofName, "CustomConditions"))
				{
					customConditions_ = (customConditionsCase_ = CustomConditionsOneofCase.None);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9F")]
		[Cpp2IlInjected.Address(RVA = "0x63CA60", Offset = "0x63B460", VA = "0x18063CA60", Slot = "25")]
		IItemData IItemData.Clone()
		{
			ItemSpawningInVillageRecurringEventItemData itemSpawningInVillageRecurringEventItemData = new ItemSpawningInVillageRecurringEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA0")]
		[Cpp2IlInjected.Address(RVA = "0x63D7C0", Offset = "0x63C1C0", VA = "0x18063D7C0")]
		public static bool IsGridPlaceableItem(Item item)
		{
			//Discarded unreachable code: IL_000e
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
			return gridPlaceableItemData != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA1")]
		[Cpp2IlInjected.Address(RVA = "0x63CAC0", Offset = "0x63B4C0", VA = "0x18063CAC0", Slot = "26")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00ed
			ToSpawnOneofCase toSpawnOneofCase = toSpawnCase_;
			if (toSpawnOneofCase != 0)
			{
				if (toSpawnOneofCase != ToSpawnOneofCase.ItemType || ItemType.itemType_ == Definitions.Items.ItemType.None)
				{
				}
				if (toSpawnCase_ != ToSpawnOneofCase.ItemList && customConditionsCase_ == CustomConditionsOneofCase.None)
				{
					goto IL_00cf;
				}
				if (((RepeatedField<T>)(object)ItemList.items_).Count != 0)
				{
					RepeatedField<Types.ItemAndWeight> items_ = ItemList.items_;
					Predicate<Types.ItemAndWeight> _003C_003E9__129_ = _003C_003Ec._003C_003E9__129_0;
					if (_003C_003E9__129_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((Types.ItemAndWeight x) => (IntPtr)x.itemID_ == (IntPtr)"{il2cpp field on {'constant11' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}");
					}
					if (!((RepeatedField<>)(object)items_).Any<Types.ItemAndWeight>((Predicate<>)(object)_003C_003E9__129_))
					{
						if (customConditionsCase_ == CustomConditionsOneofCase.WeedOverrides)
						{
							RepeatedField<Types.ItemAndWeight> items_2 = ItemList.items_;
							Predicate<Types.ItemAndWeight> predicate = default(Predicate<Types.ItemAndWeight>);
							if (_003C_003Ec._003C_003E9__129_1 == null)
							{
								predicate = (Predicate<Types.ItemAndWeight>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(Types.ItemAndWeight x)
								{
									//Discarded unreachable code: IL_000c
									int itemID_ = x.itemID_;
									bool flag = default(bool);
									return !flag;
								});
							}
							if (((RepeatedField<>)(object)items_2).Any<Types.ItemAndWeight>((Predicate<>)(object)predicate))
							{
								goto IL_00c4;
							}
						}
						goto IL_00cf;
					}
				}
			}
			goto IL_00c4;
			IL_00c4:
			context.AddError("ToSpawn cannot be None");
			goto IL_00cf;
			IL_00cf:
			int num = minNumberOfSpawn_;
			if (maxNumberOfSpawn_ < num)
			{
				context.AddError("MinNumberOfSpawn cannot be higher than MaxNumberOfSpawn");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA2")]
		[Cpp2IlInjected.Address(RVA = "0x63EF40", Offset = "0x63D940", VA = "0x18063EF40")]
		static ItemSpawningInVillageRecurringEventItemData()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
