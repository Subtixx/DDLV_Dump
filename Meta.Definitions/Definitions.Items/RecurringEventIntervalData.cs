using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200038A")]
	public sealed class RecurringEventIntervalData : IMessage<RecurringEventIntervalData>, IMessage, IEquatable<RecurringEventIntervalData>, IDeepCloneable<RecurringEventIntervalData>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200038B")]
		public enum IntervalOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001244")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001245")]
			Duration,
			[Cpp2IlInjected.Token(Token = "0x4001246")]
			TimeOfDay
		}

		[Cpp2IlInjected.Token(Token = "0x200038C")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200038D")]
			public sealed class DurationData : IMessage<DurationData>, IMessage, IEquatable<DurationData>, IDeepCloneable<DurationData>, IMessageFieldAccessor, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x4001247")]
				private static readonly MessageParser<DurationData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001248")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001249")]
				public const int MinFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400124A")]
				private Duration min_;

				[Cpp2IlInjected.Token(Token = "0x400124B")]
				public const int MaxFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400124C")]
				private Duration max_;

				[Cpp2IlInjected.Token(Token = "0x17000A60")]
				[DebuggerNonUserCode]
				public static MessageParser<DurationData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60029BC")]
					[Cpp2IlInjected.Address(RVA = "0x236CE20", Offset = "0x236B820", VA = "0x18236CE20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A61")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60029BD")]
					[Cpp2IlInjected.Address(RVA = "0x236CDA0", Offset = "0x236B7A0", VA = "0x18236CDA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A62")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60029BE")]
					[Cpp2IlInjected.Address(RVA = "0x236CE80", Offset = "0x236B880", VA = "0x18236CE80", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A63")]
				[DebuggerNonUserCode]
				public Duration Min
				{
					[Cpp2IlInjected.Token(Token = "0x60029C3")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60029C4")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A64")]
				[DebuggerNonUserCode]
				public Duration Max
				{
					[Cpp2IlInjected.Token(Token = "0x60029C5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60029C6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60029BF")]
				[Cpp2IlInjected.Address(RVA = "0x236CD10", Offset = "0x236B710", VA = "0x18236CD10")]
				[DebuggerNonUserCode]
				public DurationData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029C0")]
				[Cpp2IlInjected.Address(RVA = "0x236C930", Offset = "0x236B330", VA = "0x18236C930")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029C1")]
				[Cpp2IlInjected.Address(RVA = "0x236CC70", Offset = "0x236B670", VA = "0x18236CC70")]
				[DebuggerNonUserCode]
				public DurationData(DurationData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029C2")]
				[Cpp2IlInjected.Address(RVA = "0x236C2D0", Offset = "0x236ACD0", VA = "0x18236C2D0", Slot = "10")]
				[DebuggerNonUserCode]
				public DurationData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029C7")]
				[Cpp2IlInjected.Address(RVA = "0x236C590", Offset = "0x236AF90", VA = "0x18236C590", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60029C8")]
				[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(DurationData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60029C9")]
				[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60029CA")]
				[Cpp2IlInjected.Address(RVA = "0x236CA70", Offset = "0x236B470", VA = "0x18236CA70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029CB")]
				[Cpp2IlInjected.Address(RVA = "0x236CAD0", Offset = "0x236B4D0", VA = "0x18236CAD0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029CC")]
				[Cpp2IlInjected.Address(RVA = "0x236C1D0", Offset = "0x236ABD0", VA = "0x18236C1D0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60029CD")]
				[Cpp2IlInjected.Address(RVA = "0x236C6E0", Offset = "0x236B0E0", VA = "0x18236C6E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(DurationData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029CE")]
				[Cpp2IlInjected.Address(RVA = "0x236C800", Offset = "0x236B200", VA = "0x18236C800", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029CF")]
				[Cpp2IlInjected.Address(RVA = "0x236C650", Offset = "0x236B050", VA = "0x18236C650", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029D0")]
				[Cpp2IlInjected.Address(RVA = "0x236C9C0", Offset = "0x236B3C0", VA = "0x18236C9C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029D1")]
				[Cpp2IlInjected.Address(RVA = "0x236C2A0", Offset = "0x236ACA0", VA = "0x18236C2A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029D2")]
				[Cpp2IlInjected.Address(RVA = "0x236C3A0", Offset = "0x236ADA0", VA = "0x18236C3A0", Slot = "14")]
				void IDataValidation.DataValidation(DataValidation.Context context)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200038F")]
			public sealed class TimeOfDayData : IMessage<TimeOfDayData>, IMessage, IEquatable<TimeOfDayData>, IDeepCloneable<TimeOfDayData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400124E")]
				private static readonly MessageParser<TimeOfDayData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400124F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001250")]
				public const int DayFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001251")]
				private DayOfTheWeek day_;

				[Cpp2IlInjected.Token(Token = "0x4001252")]
				public const int HourFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001253")]
				private int hour_;

				[Cpp2IlInjected.Token(Token = "0x17000A65")]
				[DebuggerNonUserCode]
				public static MessageParser<TimeOfDayData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60029D7")]
					[Cpp2IlInjected.Address(RVA = "0x237BEE0", Offset = "0x237A8E0", VA = "0x18237BEE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A66")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60029D8")]
					[Cpp2IlInjected.Address(RVA = "0x237BE60", Offset = "0x237A860", VA = "0x18237BE60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A67")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60029D9")]
					[Cpp2IlInjected.Address(RVA = "0x237BF40", Offset = "0x237A940", VA = "0x18237BF40", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A68")]
				[DebuggerNonUserCode]
				public DayOfTheWeek Day
				{
					[Cpp2IlInjected.Token(Token = "0x60029DD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(DayOfTheWeek);
					}
					[Cpp2IlInjected.Token(Token = "0x60029DE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A69")]
				[DebuggerNonUserCode]
				public int Hour
				{
					[Cpp2IlInjected.Token(Token = "0x60029DF")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60029E0")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60029DA")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public TimeOfDayData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029DB")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public TimeOfDayData(TimeOfDayData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029DC")]
				[Cpp2IlInjected.Address(RVA = "0x237BA10", Offset = "0x237A410", VA = "0x18237BA10", Slot = "10")]
				[DebuggerNonUserCode]
				public TimeOfDayData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029E1")]
				[Cpp2IlInjected.Address(RVA = "0x237BAA0", Offset = "0x237A4A0", VA = "0x18237BAA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60029E2")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TimeOfDayData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60029E3")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60029E4")]
				[Cpp2IlInjected.Address(RVA = "0x237BCF0", Offset = "0x237A6F0", VA = "0x18237BCF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029E5")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029E6")]
				[Cpp2IlInjected.Address(RVA = "0x237B940", Offset = "0x237A340", VA = "0x18237B940", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60029E7")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TimeOfDayData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029E8")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029E9")]
				[Cpp2IlInjected.Address(RVA = "0x237BB30", Offset = "0x237A530", VA = "0x18237BB30", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029EA")]
				[Cpp2IlInjected.Address(RVA = "0x237BC20", Offset = "0x237A620", VA = "0x18237BC20", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029EB")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000391")]
			public sealed class TimeOfDayDataList : IMessage<TimeOfDayDataList>, IMessage, IEquatable<TimeOfDayDataList>, IDeepCloneable<TimeOfDayDataList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001255")]
				private static readonly MessageParser<TimeOfDayDataList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001256")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001257")]
				public const int TimeOfDayFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4001258")]
				private static readonly FieldCodec<TimeOfDayData> _repeated_timeOfDay_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001259")]
				private readonly RepeatedField<TimeOfDayData> timeOfDay_;

				[Cpp2IlInjected.Token(Token = "0x17000A6A")]
				[DebuggerNonUserCode]
				public static MessageParser<TimeOfDayDataList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60029F0")]
					[Cpp2IlInjected.Address(RVA = "0x237B820", Offset = "0x237A220", VA = "0x18237B820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A6B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60029F1")]
					[Cpp2IlInjected.Address(RVA = "0x237B7A0", Offset = "0x237A1A0", VA = "0x18237B7A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A6C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60029F2")]
					[Cpp2IlInjected.Address(RVA = "0x237B880", Offset = "0x237A280", VA = "0x18237B880", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A6D")]
				[DebuggerNonUserCode]
				public RepeatedField<TimeOfDayData> TimeOfDay
				{
					[Cpp2IlInjected.Token(Token = "0x60029F6")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60029F3")]
				[Cpp2IlInjected.Address(RVA = "0x237B720", Offset = "0x237A120", VA = "0x18237B720")]
				[DebuggerNonUserCode]
				public TimeOfDayDataList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029F4")]
				[Cpp2IlInjected.Address(RVA = "0x237B690", Offset = "0x237A090", VA = "0x18237B690")]
				[DebuggerNonUserCode]
				public TimeOfDayDataList(TimeOfDayDataList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029F5")]
				[Cpp2IlInjected.Address(RVA = "0x237AA70", Offset = "0x2379470", VA = "0x18237AA70", Slot = "10")]
				[DebuggerNonUserCode]
				public TimeOfDayDataList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029F7")]
				[Cpp2IlInjected.Address(RVA = "0x237ABC0", Offset = "0x23795C0", VA = "0x18237ABC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60029F8")]
				[Cpp2IlInjected.Address(RVA = "0x237AB30", Offset = "0x2379530", VA = "0x18237AB30", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TimeOfDayDataList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60029F9")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60029FA")]
				[Cpp2IlInjected.Address(RVA = "0x237B3A0", Offset = "0x2379DA0", VA = "0x18237B3A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60029FB")]
				[Cpp2IlInjected.Address(RVA = "0x237B400", Offset = "0x2379E00", VA = "0x18237B400", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029FC")]
				[Cpp2IlInjected.Address(RVA = "0x237A960", Offset = "0x2379360", VA = "0x18237A960", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60029FD")]
				[Cpp2IlInjected.Address(RVA = "0x237B1D0", Offset = "0x2379BD0", VA = "0x18237B1D0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TimeOfDayDataList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029FE")]
				[Cpp2IlInjected.Address(RVA = "0x237B250", Offset = "0x2379C50", VA = "0x18237B250", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60029FF")]
				[Cpp2IlInjected.Address(RVA = "0x237ACA0", Offset = "0x23796A0", VA = "0x18237ACA0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002A00")]
				[Cpp2IlInjected.Address(RVA = "0x237B340", Offset = "0x2379D40", VA = "0x18237B340", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A01")]
				[Cpp2IlInjected.Address(RVA = "0x237AA10", Offset = "0x2379410", VA = "0x18237AA10", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A02")]
				[Cpp2IlInjected.Address(RVA = "0x237AD20", Offset = "0x2379720", VA = "0x18237AD20")]
				public TimeOfDayData GetNextTimeOfDay(DateTime localNow)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400123D")]
		private static readonly MessageParser<RecurringEventIntervalData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400123E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400123F")]
		public const int DurationFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001240")]
		public const int TimeOfDayFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001241")]
		private object interval_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001242")]
		private IntervalOneofCase intervalCase_;

		[Cpp2IlInjected.Token(Token = "0x17000A5A")]
		[DebuggerNonUserCode]
		public static MessageParser<RecurringEventIntervalData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60029A0")]
			[Cpp2IlInjected.Address(RVA = "0x2DA97B0", Offset = "0x2DA81B0", VA = "0x182DA97B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A5B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60029A1")]
			[Cpp2IlInjected.Address(RVA = "0x2DA9680", Offset = "0x2DA8080", VA = "0x182DA9680")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A5C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60029A2")]
			[Cpp2IlInjected.Address(RVA = "0x2DA9870", Offset = "0x2DA8270", VA = "0x182DA9870", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A5D")]
		[DebuggerNonUserCode]
		public Types.DurationData Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60029A7")]
			[Cpp2IlInjected.Address(RVA = "0x2DA9750", Offset = "0x2DA8150", VA = "0x182DA9750")]
			get
			{
				int num = 0;
				if (intervalCase_ == IntervalOneofCase.Duration)
				{
					object obj = interval_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60029A8")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				interval_ = value;
				bool flag = (byte)(intervalCase_ = ((value != null) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A5E")]
		[DebuggerNonUserCode]
		public Types.TimeOfDayDataList TimeOfDay
		{
			[Cpp2IlInjected.Token(Token = "0x60029A9")]
			[Cpp2IlInjected.Address(RVA = "0x2DA9810", Offset = "0x2DA8210", VA = "0x182DA9810")]
			get
			{
				int num = 0;
				if (intervalCase_ == IntervalOneofCase.TimeOfDay)
				{
					object obj = interval_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60029AA")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				interval_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A5F")]
		[DebuggerNonUserCode]
		public IntervalOneofCase IntervalCase
		{
			[Cpp2IlInjected.Token(Token = "0x60029AB")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return intervalCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029A3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9450", Offset = "0x2DA7E50", VA = "0x182DA9450")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData()
		{
			bool flag = (byte)(intervalCase_ = (((interval_ = new Types.DurationData()) != null) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60029A4")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9050", Offset = "0x2DA7A50", VA = "0x182DA9050")]
		private void OnConstruction()
		{
			bool flag = (byte)(intervalCase_ = (((interval_ = new Types.DurationData()) != null) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60029A5")]
		[Cpp2IlInjected.Address(RVA = "0x2DA94C0", Offset = "0x2DA7EC0", VA = "0x182DA94C0")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData(RecurringEventIntervalData other)
		{
			//IL_007f: Expected I4, but got O
			Types.DurationData durationData = (Types.DurationData)(interval_ = new Types.DurationData());
			int num = 0;
			bool flag = (byte)(intervalCase_ = ((durationData != null) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
			IntervalOneofCase intervalOneofCase = other.intervalCase_;
			if (intervalOneofCase == IntervalOneofCase.Duration)
			{
				IntervalOneofCase intervalOneofCase2 = other.intervalCase_;
				if (other.interval_ == null)
				{
					throw new InvalidCastException();
				}
				Types.DurationData durationData2 = default(Types.DurationData);
				interval_ = durationData2;
				bool flag2 = (byte)(intervalCase_ = ((durationData2 != null) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
			}
			if (intervalOneofCase == IntervalOneofCase.TimeOfDay)
			{
				IntervalOneofCase intervalOneofCase3 = other.intervalCase_;
				if (other.interval_ == null)
				{
					throw new InvalidCastException();
				}
				Types.TimeOfDayDataList timeOfDayDataList = default(Types.TimeOfDayDataList);
				interval_ = timeOfDayDataList;
				intervalCase_ = (IntervalOneofCase)timeOfDayDataList;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029A6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8370", Offset = "0x2DA6D70", VA = "0x182DA8370", Slot = "10")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData Clone()
		{
			return new RecurringEventIntervalData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60029AC")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearInterval()
		{
			//IL_0010: Expected O, but got I4
			interval_ = (intervalCase_ = IntervalOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60029AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8500", Offset = "0x2DA6F00", VA = "0x182DA8500", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (intervalCase_ == IntervalOneofCase.Duration)
					{
						object obj = interval_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(Types.DurationData).TypeHandle != null && (object)typeof(Types.DurationData).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						Types.TimeOfDayDataList objB = default(Types.TimeOfDayDataList);
						bool flag2 = object.Equals(TimeOfDay, objB);
						if (flag2 && intervalCase_ == (flag2 ? IntervalOneofCase.Duration : IntervalOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0071;
			IL_0071:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029AE")]
		[Cpp2IlInjected.Address(RVA = "0x2DA83D0", Offset = "0x2DA6DD0", VA = "0x182DA83D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RecurringEventIntervalData other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (intervalCase_ == IntervalOneofCase.Duration)
				{
					object obj = interval_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.intervalCase_ == IntervalOneofCase.Duration)
				{
					obj2 = other.interval_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					Types.TimeOfDayDataList timeOfDay = TimeOfDay;
					Types.TimeOfDayDataList timeOfDay2 = other.TimeOfDay;
					if (object.Equals(timeOfDay, timeOfDay2))
					{
						IntervalOneofCase intervalOneofCase = other.intervalCase_;
						if (intervalCase_ == intervalOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0099;
			IL_0099:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029AF")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8780", Offset = "0x2DA7180", VA = "0x182DA8780", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			IntervalOneofCase intervalOneofCase = intervalCase_;
			int num = 0;
			if (intervalOneofCase == IntervalOneofCase.Duration)
			{
				object obj = interval_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (intervalOneofCase == IntervalOneofCase.TimeOfDay)
			{
				object obj2 = interval_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA91B0", Offset = "0x2DA7BB0", VA = "0x182DA91B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60029B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9210", Offset = "0x2DA7C10", VA = "0x182DA9210", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			IntervalOneofCase intervalOneofCase = intervalCase_;
			int num = 0;
			if (intervalOneofCase == IntervalOneofCase.Duration)
			{
				if (intervalCase_ == IntervalOneofCase.Duration)
				{
					object obj = interval_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (intervalOneofCase == IntervalOneofCase.TimeOfDay && intervalCase_ == IntervalOneofCase.TimeOfDay)
			{
				object obj2 = interval_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60029B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DA81B0", Offset = "0x2DA6BB0", VA = "0x182DA81B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (intervalCase_ == IntervalOneofCase.Duration)
			{
				if (intervalCase_ == IntervalOneofCase.Duration)
				{
					object obj = interval_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (intervalCase_ == IntervalOneofCase.TimeOfDay)
			{
				if (intervalCase_ == IntervalOneofCase.TimeOfDay)
				{
					object obj2 = interval_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8E00", Offset = "0x2DA7800", VA = "0x182DA8E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RecurringEventIntervalData other)
		{
			//IL_00dd: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.intervalCase_ == IntervalOneofCase.Duration)
			{
				IntervalOneofCase intervalOneofCase = intervalCase_;
				int num = 0;
				if (intervalOneofCase == IntervalOneofCase.Duration)
				{
					object obj = interval_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(intervalCase_ = (((interval_ = new Types.DurationData()) != null) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
				}
				if (intervalCase_ == IntervalOneofCase.Duration)
				{
					object obj2 = interval_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.intervalCase_ == IntervalOneofCase.Duration)
				{
					object obj3 = other.interval_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(Types.TimeOfDayDataList).TypeHandle != 2)
			{
			}
			if (TimeOfDay == null)
			{
				intervalCase_ = (IntervalOneofCase)(interval_ = new Types.TimeOfDayDataList());
			}
			Types.TimeOfDayDataList other2 = default(Types.TimeOfDayDataList);
			TimeOfDay.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029B4")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8C00", Offset = "0x2DA7600", VA = "0x182DA8C00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.DurationData durationData = new Types.DurationData();
				if (intervalCase_ == IntervalOneofCase.Duration)
				{
					if (intervalCase_ != IntervalOneofCase.Duration)
					{
					}
					object obj = interval_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(durationData);
				interval_ = durationData;
				bool flag = (byte)(intervalCase_ = ((durationData != null) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				Types.TimeOfDayDataList builder = new Types.TimeOfDayDataList();
				if (intervalCase_ == IntervalOneofCase.TimeOfDay)
				{
					if (intervalCase_ != IntervalOneofCase.TimeOfDay)
					{
					}
					object obj2 = interval_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				interval_ = builder;
				intervalCase_ = (IntervalOneofCase)typeof(Types.TimeOfDayDataList).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60029B5")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8670", Offset = "0x2DA7070", VA = "0x182DA8670", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (intervalCase_ == IntervalOneofCase.Duration)
			{
				object obj = interval_;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					goto IL_001c;
				}
			}
			goto IL_0038;
			IL_0038:
			object obj2 = default(object);
			return obj2;
			IL_001c:
			if (fieldNumber == 2)
			{
				if (intervalCase_ == IntervalOneofCase.TimeOfDay)
				{
					obj2 = interval_;
					if (obj2 != null && obj2 == null)
					{
						goto IL_0040;
					}
				}
				goto IL_0038;
			}
			goto IL_0040;
			IL_0040:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA90C0", Offset = "0x2DA7AC0", VA = "0x182DA90C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0043: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				interval_ = num;
				bool flag = (byte)(intervalCase_ = ((num != 0) ? IntervalOneofCase.Duration : IntervalOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				interval_ = value;
				intervalCase_ = (IntervalOneofCase)typeof(Types.TimeOfDayDataList).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B7")]
		[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1 || fieldNumber == 2)
			{
				intervalCase_ = IntervalOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8B50", Offset = "0x2DA7550", VA = "0x182DA8B50", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Interval"))
			{
				IntervalOneofCase intervalOneofCase = intervalCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60029B9")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8300", Offset = "0x2DA6D00", VA = "0x182DA8300", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Interval"))
			{
				interval_ = (intervalCase_ = IntervalOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029BA")]
		[Cpp2IlInjected.Address(RVA = "0x2DA88B0", Offset = "0x2DA72B0", VA = "0x182DA88B0")]
		public TimeSpan GetMaxTimeBetweenExecutions()
		{
			IntervalOneofCase intervalOneofCase = intervalCase_;
			if (intervalOneofCase == IntervalOneofCase.Duration)
			{
				IntervalOneofCase intervalOneofCase2 = intervalCase_;
				TimeSpan result = default(TimeSpan);
				if (interval_ != null)
				{
					return result;
				}
				throw new InvalidCastException();
			}
			while (intervalOneofCase != IntervalOneofCase.TimeOfDay)
			{
			}
			IntervalOneofCase intervalOneofCase3 = intervalCase_;
			if (interval_ != null)
			{
				int num = default(int);
				if (num == 1)
				{
					RepeatedField<Types.TimeOfDayData> timeOfDay_ = TimeOfDay.timeOfDay_;
					int index = 0;
					if (((Types.TimeOfDayData)((RepeatedField<T>)(object)timeOfDay_)[index]).day_ != 0)
					{
						RepeatedField<Types.TimeOfDayData> timeOfDay_2 = TimeOfDay.timeOfDay_;
						int index2 = 0;
						if (((Types.TimeOfDayData)((RepeatedField<T>)(object)timeOfDay_2)[index2]).day_ != DayOfTheWeek.EveryDayUtc)
						{
							goto IL_007e;
						}
					}
					TimeSpan result2 = default(TimeSpan);
					return result2;
				}
				goto IL_007e;
			}
			throw new InvalidCastException();
			IL_007e:
			int count = ((RepeatedField<T>)(object)TimeOfDay.timeOfDay_).Count;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9340", Offset = "0x2DA7D40", VA = "0x182DA9340")]
		static RecurringEventIntervalData()
		{
			Func<RecurringEventIntervalData> func = default(Func<RecurringEventIntervalData>);
			_parser = (MessageParser<RecurringEventIntervalData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
