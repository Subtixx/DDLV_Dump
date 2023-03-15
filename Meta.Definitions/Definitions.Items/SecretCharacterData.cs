using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200031C")]
	public sealed class SecretCharacterData : IMessage<SecretCharacterData>, IMessage, IEquatable<SecretCharacterData>, IDeepCloneable<SecretCharacterData>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200031D")]
		public enum ApparitionOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000FDD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000FDE")]
			SpecificMoment,
			[Cpp2IlInjected.Token(Token = "0x4000FDF")]
			Always
		}

		[Cpp2IlInjected.Token(Token = "0x200031E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200031F")]
			public sealed class SpecificMomentData : IMessage<SpecificMomentData>, IMessage, IEquatable<SpecificMomentData>, IDeepCloneable<SpecificMomentData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000FE0")]
				private static readonly MessageParser<SpecificMomentData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FE1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000FE2")]
				public const int DayOfTheWeekIntFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000FE3")]
				private int dayOfTheWeekInt_;

				[Cpp2IlInjected.Token(Token = "0x4000FE4")]
				public const int TimeFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000FE5")]
				private TimeInterval time_;

				[Cpp2IlInjected.Token(Token = "0x170008E7")]
				[DebuggerNonUserCode]
				public static MessageParser<SpecificMomentData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002439")]
					[Cpp2IlInjected.Address(RVA = "0x2375370", Offset = "0x2373D70", VA = "0x182375370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008E8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600243A")]
					[Cpp2IlInjected.Address(RVA = "0x23752F0", Offset = "0x2373CF0", VA = "0x1823752F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008E9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600243B")]
					[Cpp2IlInjected.Address(RVA = "0x23753D0", Offset = "0x2373DD0", VA = "0x1823753D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008EA")]
				[DebuggerNonUserCode]
				public int DayOfTheWeekInt
				{
					[Cpp2IlInjected.Token(Token = "0x6002440")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002441")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008EB")]
				[DebuggerNonUserCode]
				public TimeInterval Time
				{
					[Cpp2IlInjected.Token(Token = "0x6002442")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002443")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008EC")]
				public DayOfTheWeekFlag DayOfTheWeek
				{
					[Cpp2IlInjected.Token(Token = "0x600244F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(DayOfTheWeekFlag);
					}
					[Cpp2IlInjected.Token(Token = "0x6002450")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600243C")]
				[Cpp2IlInjected.Address(RVA = "0x2375140", Offset = "0x2373B40", VA = "0x182375140")]
				[DebuggerNonUserCode]
				public SpecificMomentData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600243D")]
				[Cpp2IlInjected.Address(RVA = "0x2374E90", Offset = "0x2373890", VA = "0x182374E90")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600243E")]
				[Cpp2IlInjected.Address(RVA = "0x23751B0", Offset = "0x2373BB0", VA = "0x1823751B0")]
				[DebuggerNonUserCode]
				public SpecificMomentData(SpecificMomentData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600243F")]
				[Cpp2IlInjected.Address(RVA = "0x23749A0", Offset = "0x23733A0", VA = "0x1823749A0", Slot = "10")]
				[DebuggerNonUserCode]
				public SpecificMomentData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002444")]
				[Cpp2IlInjected.Address(RVA = "0x2374B10", Offset = "0x2373510", VA = "0x182374B10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002445")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(SpecificMomentData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002446")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002447")]
				[Cpp2IlInjected.Address(RVA = "0x2374FD0", Offset = "0x23739D0", VA = "0x182374FD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002448")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002449")]
				[Cpp2IlInjected.Address(RVA = "0x23748D0", Offset = "0x23732D0", VA = "0x1823748D0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600244A")]
				[Cpp2IlInjected.Address(RVA = "0x2374C90", Offset = "0x2373690", VA = "0x182374C90", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(SpecificMomentData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600244B")]
				[Cpp2IlInjected.Address(RVA = "0x2374DA0", Offset = "0x23737A0", VA = "0x182374DA0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600244C")]
				[Cpp2IlInjected.Address(RVA = "0x2374BC0", Offset = "0x23735C0", VA = "0x182374BC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600244D")]
				[Cpp2IlInjected.Address(RVA = "0x2374F00", Offset = "0x2373900", VA = "0x182374F00", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600244E")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000321")]
			public sealed class TimeInterval : IMessage<TimeInterval>, IMessage, IEquatable<TimeInterval>, IDeepCloneable<TimeInterval>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000FE7")]
				private static readonly MessageParser<TimeInterval> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FE8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000FE9")]
				public const int StartHourFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000FEA")]
				private int startHour_;

				[Cpp2IlInjected.Token(Token = "0x4000FEB")]
				public const int EndHourFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000FEC")]
				private int endHour_;

				[Cpp2IlInjected.Token(Token = "0x170008ED")]
				[DebuggerNonUserCode]
				public static MessageParser<TimeInterval> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002455")]
					[Cpp2IlInjected.Address(RVA = "0x237A840", Offset = "0x2379240", VA = "0x18237A840")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008EE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002456")]
					[Cpp2IlInjected.Address(RVA = "0x237A6E0", Offset = "0x23790E0", VA = "0x18237A6E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008EF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002457")]
					[Cpp2IlInjected.Address(RVA = "0x237A8A0", Offset = "0x23792A0", VA = "0x18237A8A0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F0")]
				[DebuggerNonUserCode]
				public int StartHour
				{
					[Cpp2IlInjected.Token(Token = "0x600245B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600245C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F1")]
				[DebuggerNonUserCode]
				public int EndHour
				{
					[Cpp2IlInjected.Token(Token = "0x600245D")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600245E")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F2")]
				public TimeSpan Duration
				{
					[Cpp2IlInjected.Token(Token = "0x600246A")]
					[Cpp2IlInjected.Address(RVA = "0x237A760", Offset = "0x2379160", VA = "0x18237A760")]
					get
					{
						return default(TimeSpan);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002458")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public TimeInterval()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002459")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public TimeInterval(TimeInterval other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600245A")]
				[Cpp2IlInjected.Address(RVA = "0x237A2D0", Offset = "0x2378CD0", VA = "0x18237A2D0", Slot = "10")]
				[DebuggerNonUserCode]
				public TimeInterval Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600245F")]
				[Cpp2IlInjected.Address(RVA = "0x237A360", Offset = "0x2378D60", VA = "0x18237A360", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002460")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TimeInterval other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002461")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002462")]
				[Cpp2IlInjected.Address(RVA = "0x237A570", Offset = "0x2378F70", VA = "0x18237A570", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002463")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002464")]
				[Cpp2IlInjected.Address(RVA = "0x237A200", Offset = "0x2378C00", VA = "0x18237A200", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002465")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TimeInterval other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002466")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002467")]
				[Cpp2IlInjected.Address(RVA = "0x237A3F0", Offset = "0x2378DF0", VA = "0x18237A3F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002468")]
				[Cpp2IlInjected.Address(RVA = "0x237A4B0", Offset = "0x2378EB0", VA = "0x18237A4B0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002469")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000323")]
			public sealed class LocationTypeWeight : IMessage<LocationTypeWeight>, IMessage, IEquatable<LocationTypeWeight>, IDeepCloneable<LocationTypeWeight>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000FEE")]
				private static readonly MessageParser<LocationTypeWeight> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FEF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000FF0")]
				public const int LocationFilterFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000FF1")]
				private SecretCharacterLocationFilter locationFilter_;

				[Cpp2IlInjected.Token(Token = "0x4000FF2")]
				public const int WeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000FF3")]
				private int weight_;

				[Cpp2IlInjected.Token(Token = "0x170008F3")]
				[DebuggerNonUserCode]
				public static MessageParser<LocationTypeWeight> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600246F")]
					[Cpp2IlInjected.Address(RVA = "0x23728A0", Offset = "0x23712A0", VA = "0x1823728A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F4")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002470")]
					[Cpp2IlInjected.Address(RVA = "0x2372820", Offset = "0x2371220", VA = "0x182372820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F5")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002471")]
					[Cpp2IlInjected.Address(RVA = "0x2372900", Offset = "0x2371300", VA = "0x182372900", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F6")]
				[DebuggerNonUserCode]
				public SecretCharacterLocationFilter LocationFilter
				{
					[Cpp2IlInjected.Token(Token = "0x6002475")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002476")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008F7")]
				[DebuggerNonUserCode]
				public int Weight
				{
					[Cpp2IlInjected.Token(Token = "0x6002477")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002478")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002472")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public LocationTypeWeight()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002473")]
				[Cpp2IlInjected.Address(RVA = "0x23727A0", Offset = "0x23711A0", VA = "0x1823727A0")]
				[DebuggerNonUserCode]
				public LocationTypeWeight(LocationTypeWeight other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002474")]
				[Cpp2IlInjected.Address(RVA = "0x2372160", Offset = "0x2370B60", VA = "0x182372160", Slot = "10")]
				[DebuggerNonUserCode]
				public LocationTypeWeight Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002479")]
				[Cpp2IlInjected.Address(RVA = "0x2372210", Offset = "0x2370C10", VA = "0x182372210", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600247A")]
				[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(LocationTypeWeight other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600247B")]
				[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600247C")]
				[Cpp2IlInjected.Address(RVA = "0x2372630", Offset = "0x2371030", VA = "0x182372630", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600247D")]
				[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600247E")]
				[Cpp2IlInjected.Address(RVA = "0x2372090", Offset = "0x2370A90", VA = "0x182372090", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600247F")]
				[Cpp2IlInjected.Address(RVA = "0x2372480", Offset = "0x2370E80", VA = "0x182372480", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(LocationTypeWeight other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002480")]
				[Cpp2IlInjected.Address(RVA = "0x2372390", Offset = "0x2370D90", VA = "0x182372390", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002481")]
				[Cpp2IlInjected.Address(RVA = "0x23722C0", Offset = "0x2370CC0", VA = "0x1823722C0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002482")]
				[Cpp2IlInjected.Address(RVA = "0x2372560", Offset = "0x2370F60", VA = "0x182372560", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002483")]
				[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000FC1")]
		private static readonly MessageParser<SecretCharacterData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000FC2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000FC3")]
		public const int SpecificMomentFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000FC4")]
		public const int AlwaysFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000FC5")]
		public const int BaseProbabilityFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000FC6")]
		private int baseProbability_;

		[Cpp2IlInjected.Token(Token = "0x4000FC7")]
		public const int MaxProbabilityFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000FC8")]
		private int maxProbability_;

		[Cpp2IlInjected.Token(Token = "0x4000FC9")]
		public const int PreConditionsFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000FCA")]
		private ConditionsList preConditions_;

		[Cpp2IlInjected.Token(Token = "0x4000FCB")]
		public const int RecurringConditionsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4000FCC")]
		private static readonly FieldCodec<SecretCharacterRecurringCondition> _repeated_recurringConditions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000FCD")]
		private readonly RepeatedField<SecretCharacterRecurringCondition> recurringConditions_;

		[Cpp2IlInjected.Token(Token = "0x4000FCE")]
		public const int LocationsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4000FCF")]
		private static readonly FieldCodec<Types.LocationTypeWeight> _repeated_locations_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000FD0")]
		private readonly RepeatedField<Types.LocationTypeWeight> locations_;

		[Cpp2IlInjected.Token(Token = "0x4000FD1")]
		public const int CharacterUnlockConditionFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000FD2")]
		private ConditionsList characterUnlockCondition_;

		[Cpp2IlInjected.Token(Token = "0x4000FD3")]
		public const int NumberOfMissionsToCompleteFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000FD4")]
		private int numberOfMissionsToComplete_;

		[Cpp2IlInjected.Token(Token = "0x4000FD5")]
		public const int MissionsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000FD6")]
		private static readonly FieldCodec<int> _repeated_missions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000FD7")]
		private readonly RepeatedField<int> missions_;

		[Cpp2IlInjected.Token(Token = "0x4000FD8")]
		public const int BehaviourTreeAddressFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000FD9")]
		private string behaviourTreeAddress_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000FDA")]
		private object apparition_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000FDB")]
		private ApparitionOneofCase apparitionCase_;

		[Cpp2IlInjected.Token(Token = "0x170008D8")]
		[DebuggerNonUserCode]
		public static MessageParser<SecretCharacterData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600240D")]
			[Cpp2IlInjected.Address(RVA = "0x3840650", Offset = "0x383F050", VA = "0x183840650")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600240E")]
			[Cpp2IlInjected.Address(RVA = "0x3840580", Offset = "0x383EF80", VA = "0x183840580")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008DA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600240F")]
			[Cpp2IlInjected.Address(RVA = "0x3840710", Offset = "0x383F110", VA = "0x183840710", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008DB")]
		[DebuggerNonUserCode]
		public Types.SpecificMomentData SpecificMoment
		{
			[Cpp2IlInjected.Token(Token = "0x6002414")]
			[Cpp2IlInjected.Address(RVA = "0x38406B0", Offset = "0x383F0B0", VA = "0x1838406B0")]
			get
			{
				int num = 0;
				if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					object obj = apparition_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002415")]
			[Cpp2IlInjected.Address(RVA = "0x24D90A0", Offset = "0x24D7AA0", VA = "0x1824D90A0")]
			set
			{
				apparition_ = value;
				bool flag = (byte)(apparitionCase_ = ((value != null) ? ApparitionOneofCase.SpecificMoment : ApparitionOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008DC")]
		[DebuggerNonUserCode]
		public Empty Always
		{
			[Cpp2IlInjected.Token(Token = "0x6002416")]
			[Cpp2IlInjected.Address(RVA = "0x3840520", Offset = "0x383EF20", VA = "0x183840520")]
			get
			{
				int num = 0;
				if (apparitionCase_ == ApparitionOneofCase.Always)
				{
					object obj = apparition_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002417")]
			[Cpp2IlInjected.Address(RVA = "0x24D9060", Offset = "0x24D7A60", VA = "0x1824D9060")]
			set
			{
				apparition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008DD")]
		[DebuggerNonUserCode]
		public int BaseProbability
		{
			[Cpp2IlInjected.Token(Token = "0x6002418")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return baseProbability_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002419")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				baseProbability_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008DE")]
		[DebuggerNonUserCode]
		public int MaxProbability
		{
			[Cpp2IlInjected.Token(Token = "0x600241A")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return maxProbability_;
			}
			[Cpp2IlInjected.Token(Token = "0x600241B")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				maxProbability_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008DF")]
		[DebuggerNonUserCode]
		public ConditionsList PreConditions
		{
			[Cpp2IlInjected.Token(Token = "0x600241C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return preConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x600241D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				preConditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E0")]
		[DebuggerNonUserCode]
		public RepeatedField<SecretCharacterRecurringCondition> RecurringConditions
		{
			[Cpp2IlInjected.Token(Token = "0x600241E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return recurringConditions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E1")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.LocationTypeWeight> Locations
		{
			[Cpp2IlInjected.Token(Token = "0x600241F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return locations_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E2")]
		[DebuggerNonUserCode]
		public ConditionsList CharacterUnlockCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6002420")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return characterUnlockCondition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002421")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				characterUnlockCondition_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E3")]
		[DebuggerNonUserCode]
		public int NumberOfMissionsToComplete
		{
			[Cpp2IlInjected.Token(Token = "0x6002422")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return numberOfMissionsToComplete_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002423")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				numberOfMissionsToComplete_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E4")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Missions
		{
			[Cpp2IlInjected.Token(Token = "0x6002424")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return missions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E5")]
		[DebuggerNonUserCode]
		public string BehaviourTreeAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002425")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return behaviourTreeAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002426")]
			[Cpp2IlInjected.Address(RVA = "0x3840820", Offset = "0x383F220", VA = "0x183840820")]
			set
			{
				string text = (behaviourTreeAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008E6")]
		[DebuggerNonUserCode]
		public ApparitionOneofCase ApparitionCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002427")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return apparitionCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002410")]
		[Cpp2IlInjected.Address(RVA = "0x3840340", Offset = "0x383ED40", VA = "0x183840340")]
		[DebuggerNonUserCode]
		public SecretCharacterData()
		{
			//IL_007d: Expected I4, but got I8
			recurringConditions_ = (RepeatedField<SecretCharacterRecurringCondition>)(object)new RepeatedField<T>();
			locations_ = (RepeatedField<Types.LocationTypeWeight>)(object)new RepeatedField<T>();
			missions_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			behaviourTreeAddress_ = "";
			base._002Ector();
			bool flag = (byte)(apparitionCase_ = (((apparition_ = new Types.SpecificMomentData()) != null) ? ApparitionOneofCase.SpecificMoment : ApparitionOneofCase.None)) != 0;
			ConditionsList conditionsList = (preConditions_ = new ConditionsList());
			ConditionsList conditionsList2 = (characterUnlockCondition_ = new ConditionsList());
			numberOfMissionsToComplete_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002411")]
		[Cpp2IlInjected.Address(RVA = "0x383F5C0", Offset = "0x383DFC0", VA = "0x18383F5C0")]
		private void OnConstruction()
		{
			//IL_003f: Expected I4, but got I8
			bool flag = (byte)(apparitionCase_ = (((apparition_ = new Types.SpecificMomentData()) != null) ? ApparitionOneofCase.SpecificMoment : ApparitionOneofCase.None)) != 0;
			ConditionsList conditionsList = (preConditions_ = new ConditionsList());
			ConditionsList conditionsList2 = (characterUnlockCondition_ = new ConditionsList());
			numberOfMissionsToComplete_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002412")]
		[Cpp2IlInjected.Address(RVA = "0x38400D0", Offset = "0x383EAD0", VA = "0x1838400D0")]
		[DebuggerNonUserCode]
		public SecretCharacterData(SecretCharacterData other)
		{
			//IL_0038: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_0110: Expected I4, but got O
			int num = other.baseProbability_;
			int num2 = 0;
			baseProbability_ = num;
			int num3 = (maxProbability_ = other.maxProbability_);
			ConditionsList conditionsList = other.preConditions_;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			preConditions_ = (ConditionsList)num2;
			RepeatedField<SecretCharacterRecurringCondition> repeatedField = (recurringConditions_ = (RepeatedField<SecretCharacterRecurringCondition>)(object)((RepeatedField<T>)(object)other.recurringConditions_).Clone());
			RepeatedField<Types.LocationTypeWeight> repeatedField2 = (locations_ = (RepeatedField<Types.LocationTypeWeight>)(object)((RepeatedField<T>)(object)other.locations_).Clone());
			ConditionsList conditionsList3 = other.characterUnlockCondition_;
			if (conditionsList3 != null)
			{
				ConditionsList conditionsList4 = conditionsList3.Clone();
			}
			characterUnlockCondition_ = (ConditionsList)num2;
			int num4 = (numberOfMissionsToComplete_ = other.numberOfMissionsToComplete_);
			RepeatedField<int> repeatedField3 = (missions_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.missions_).Clone());
			string text = (behaviourTreeAddress_ = other.behaviourTreeAddress_);
			Types.SpecificMomentData specificMomentData = default(Types.SpecificMomentData);
			if (other.apparitionCase_ == ApparitionOneofCase.SpecificMoment)
			{
				ApparitionOneofCase apparitionOneofCase = other.apparitionCase_;
				if (other.apparition_ == null)
				{
					throw new InvalidCastException();
				}
				apparition_ = specificMomentData;
				bool flag = (byte)(apparitionCase_ = ((specificMomentData != null) ? ApparitionOneofCase.SpecificMoment : ApparitionOneofCase.None)) != 0;
			}
			if ((long)specificMomentData == 2)
			{
				ApparitionOneofCase apparitionOneofCase2 = other.apparitionCase_;
				if (other.apparition_ == null)
				{
					throw new InvalidCastException();
				}
				Empty empty = default(Empty);
				apparition_ = empty;
				apparitionCase_ = (ApparitionOneofCase)empty;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002413")]
		[Cpp2IlInjected.Address(RVA = "0x383E2C0", Offset = "0x383CCC0", VA = "0x18383E2C0", Slot = "10")]
		[DebuggerNonUserCode]
		public SecretCharacterData Clone()
		{
			return new SecretCharacterData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002428")]
		[Cpp2IlInjected.Address(RVA = "0x1D36160", Offset = "0x1D34B60", VA = "0x181D36160")]
		[DebuggerNonUserCode]
		public void ClearApparition()
		{
			//IL_0010: Expected O, but got I4
			apparition_ = (apparitionCase_ = ApparitionOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002429")]
		[Cpp2IlInjected.Address(RVA = "0x383E850", Offset = "0x383D250", VA = "0x18383E850", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((SecretCharacterData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600242A")]
		[Cpp2IlInjected.Address(RVA = "0x383E610", Offset = "0x383D010", VA = "0x18383E610", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SecretCharacterData other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					object obj = apparition_;
					if (obj != null && obj == null)
					{
						goto IL_0183;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					obj2 = other.apparition_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					Empty always = Always;
					Empty always2 = other.Always;
					if (object.Equals(always, always2))
					{
						int num2 = other.baseProbability_;
						if (baseProbability_ == num2)
						{
							int num3 = other.maxProbability_;
							if (maxProbability_ == num3)
							{
								ConditionsList objB = other.preConditions_;
								if (object.Equals(preConditions_, objB))
								{
									RepeatedField<SecretCharacterRecurringCondition> repeatedField = recurringConditions_;
									RepeatedField<SecretCharacterRecurringCondition> repeatedField2 = other.recurringConditions_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										RepeatedField<Types.LocationTypeWeight> repeatedField3 = locations_;
										RepeatedField<Types.LocationTypeWeight> repeatedField4 = other.locations_;
										if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
										{
											ConditionsList objB2 = other.characterUnlockCondition_;
											if (object.Equals(characterUnlockCondition_, objB2))
											{
												int num4 = other.numberOfMissionsToComplete_;
												if (numberOfMissionsToComplete_ == num4)
												{
													RepeatedField<int> repeatedField5 = missions_;
													RepeatedField<int> repeatedField6 = other.missions_;
													if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
													{
														string text = other.behaviourTreeAddress_;
														if (!(behaviourTreeAddress_ != text))
														{
															ApparitionOneofCase apparitionOneofCase = other.apparitionCase_;
															if (apparitionCase_ == apparitionOneofCase)
															{
																UnknownFieldSet unknownFields = other._unknownFields;
																bool flag = object.Equals(_unknownFields, unknownFields);
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
			goto IL_0183;
			IL_0183:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600242B")]
		[Cpp2IlInjected.Address(RVA = "0x383EA40", Offset = "0x383D440", VA = "0x18383EA40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e5
			ApparitionOneofCase apparitionOneofCase = apparitionCase_;
			int num = 0;
			if (apparitionOneofCase == ApparitionOneofCase.SpecificMoment)
			{
				object obj = apparition_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (apparitionOneofCase == ApparitionOneofCase.Always)
			{
				object obj2 = apparition_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			if (baseProbability_ != 0)
			{
			}
			if (maxProbability_ != 0)
			{
			}
			ConditionsList conditionsList = preConditions_;
			if (conditionsList != null)
			{
				int hashCode3 = conditionsList.GetHashCode();
			}
			int hashCode4 = ((RepeatedField<T>)(object)recurringConditions_).GetHashCode();
			int hashCode5 = ((RepeatedField<T>)(object)locations_).GetHashCode();
			ConditionsList conditionsList2 = characterUnlockCondition_;
			if (conditionsList2 != null)
			{
				int hashCode6 = conditionsList2.GetHashCode();
			}
			if (numberOfMissionsToComplete_ != 0)
			{
			}
			int hashCode7 = ((RepeatedField<T>)(object)missions_).GetHashCode();
			string text = behaviourTreeAddress_;
			if (text.m_stringLength != 0)
			{
				int hashCode8 = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return hashCode5;
		}

		[Cpp2IlInjected.Token(Token = "0x600242C")]
		[Cpp2IlInjected.Address(RVA = "0x383FA70", Offset = "0x383E470", VA = "0x18383FA70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600242D")]
		[Cpp2IlInjected.Address(RVA = "0x383FAD0", Offset = "0x383E4D0", VA = "0x18383FAD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_014e
			//IL_002f: Expected O, but got I4
			ApparitionOneofCase apparitionOneofCase = apparitionCase_;
			int num = 0;
			if (apparitionOneofCase == ApparitionOneofCase.SpecificMoment)
			{
				if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					object obj = apparition_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (apparitionOneofCase == ApparitionOneofCase.Always && apparitionCase_ == ApparitionOneofCase.Always)
			{
				object obj2 = apparition_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (baseProbability_ != 0)
			{
				int value = baseProbability_;
				output.WriteInt32(value);
			}
			if (maxProbability_ != 0)
			{
				int value2 = maxProbability_;
				output.WriteInt32(value2);
			}
			if ((long)preConditions_ != 0)
			{
				ConditionsList value3 = preConditions_;
				output.WriteMessage(value3);
			}
			RepeatedField<SecretCharacterRecurringCondition> repeatedField = recurringConditions_;
			FieldCodec<SecretCharacterRecurringCondition> repeated_recurringConditions_codec = _repeated_recurringConditions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_recurringConditions_codec);
			RepeatedField<Types.LocationTypeWeight> repeatedField2 = locations_;
			FieldCodec<Types.LocationTypeWeight> repeated_locations_codec = _repeated_locations_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_locations_codec);
			if (numberOfMissionsToComplete_ != 0)
			{
				int value4 = numberOfMissionsToComplete_;
				output.WriteInt32(value4);
			}
			RepeatedField<int> repeatedField3 = missions_;
			FieldCodec<int> repeated_missions_codec = _repeated_missions_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_missions_codec);
			if (behaviourTreeAddress_.m_stringLength != 0)
			{
				string value5 = behaviourTreeAddress_;
				output.WriteString(value5);
			}
			if ((long)characterUnlockCondition_ != 0)
			{
				ConditionsList value6 = characterUnlockCondition_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600242E")]
		[Cpp2IlInjected.Address(RVA = "0x383DD70", Offset = "0x383C770", VA = "0x18383DD70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected O, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected O, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			int num = 0;
			if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
			{
				if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					object obj = apparition_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (apparitionCase_ == ApparitionOneofCase.Always)
			{
				if (apparitionCase_ == ApparitionOneofCase.Always)
				{
					object obj2 = apparition_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			int num4 = baseProbability_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			int num6 = maxProbability_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			ConditionsList conditionsList = preConditions_;
			if (conditionsList != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num8++;
				num += num8;
			}
			RepeatedField<SecretCharacterRecurringCondition> repeatedField = recurringConditions_;
			FieldCodec<SecretCharacterRecurringCondition> repeated_recurringConditions_codec = _repeated_recurringConditions_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_recurringConditions_codec);
			RepeatedField<Types.LocationTypeWeight> repeatedField2 = locations_;
			FieldCodec<Types.LocationTypeWeight> repeated_locations_codec = _repeated_locations_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_locations_codec);
			ConditionsList conditionsList2 = characterUnlockCondition_;
			if (conditionsList2 != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(conditionsList2);
				num11++;
				repeatedField = (RepeatedField<SecretCharacterRecurringCondition>)(repeatedField + num11);
			}
			int num12 = numberOfMissionsToComplete_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				repeatedField = (RepeatedField<SecretCharacterRecurringCondition>)(repeatedField + num13);
			}
			RepeatedField<int> repeatedField3 = missions_;
			FieldCodec<int> repeated_missions_codec = _repeated_missions_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_missions_codec);
			string text = behaviourTreeAddress_;
			repeatedField = (RepeatedField<SecretCharacterRecurringCondition>)(repeatedField + num14);
			if (text.m_stringLength != 0)
			{
				int num15 = CodedOutputStream.ComputeStringSize(text);
				num15++;
				repeatedField = (RepeatedField<SecretCharacterRecurringCondition>)(repeatedField + num15);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<SecretCharacterRecurringCondition>)(repeatedField + num16);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600242F")]
		[Cpp2IlInjected.Address(RVA = "0x383ED60", Offset = "0x383D760", VA = "0x18383ED60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SecretCharacterData other)
		{
			//Discarded unreachable code: IL_020b
			//IL_01d2: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			int num = other.baseProbability_;
			if (num != 0)
			{
				baseProbability_ = num;
			}
			int num2 = other.maxProbability_;
			if (num2 != 0)
			{
				maxProbability_ = num2;
			}
			if ((long)other.preConditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (preConditions_ == null)
				{
					ConditionsList conditionsList = (preConditions_ = new ConditionsList());
					conditionsList2 = preConditions_;
				}
				ConditionsList other2 = other.preConditions_;
				conditionsList2.MergeFrom(other2);
			}
			RepeatedField<SecretCharacterRecurringCondition> repeatedField = recurringConditions_;
			RepeatedField<SecretCharacterRecurringCondition> repeatedField2 = other.recurringConditions_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<Types.LocationTypeWeight> repeatedField3 = locations_;
			RepeatedField<Types.LocationTypeWeight> repeatedField4 = other.locations_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			if ((long)other.characterUnlockCondition_ != 0)
			{
				ConditionsList conditionsList4 = default(ConditionsList);
				if (characterUnlockCondition_ == null)
				{
					ConditionsList conditionsList3 = (characterUnlockCondition_ = new ConditionsList());
					conditionsList4 = characterUnlockCondition_;
				}
				ConditionsList other3 = other.characterUnlockCondition_;
				conditionsList4.MergeFrom(other3);
			}
			int num3 = other.numberOfMissionsToComplete_;
			if (num3 != 0)
			{
				numberOfMissionsToComplete_ = num3;
			}
			RepeatedField<int> repeatedField5 = missions_;
			RepeatedField<int> repeatedField6 = other.missions_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			string text = other.behaviourTreeAddress_;
			if (text.m_stringLength != 0)
			{
				BehaviourTreeAddress = text;
			}
			if (other.apparitionCase_ == ApparitionOneofCase.SpecificMoment)
			{
				object obj = default(object);
				if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					obj = apparition_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					bool flag = (byte)(apparitionCase_ = (((apparition_ = new Types.SpecificMomentData()) != null) ? ApparitionOneofCase.SpecificMoment : ApparitionOneofCase.None)) != 0;
				}
				if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					object obj2 = apparition_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					object obj3 = other.apparition_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(Types.SpecificMomentData).TypeHandle == 2)
			{
				if (Always == null)
				{
					apparitionCase_ = (ApparitionOneofCase)(apparition_ = new Empty());
				}
				Empty always = Always;
				Empty always2 = other.Always;
				always.MergeFrom(always2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002430")]
		[Cpp2IlInjected.Address(RVA = "0x383F120", Offset = "0x383DB20", VA = "0x18383F120", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_01d0: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 50)
			{
				goto IL_00bf;
			}
			if ((int)num > 72)
			{
				if (num == 74)
				{
					goto IL_00a6;
				}
				if (num == 82)
				{
					string text2 = (BehaviourTreeAddress = input.ReadString());
				}
				if (num != 98)
				{
					goto IL_01eb;
				}
				ConditionsList builder = default(ConditionsList);
				if (characterUnlockCondition_ == null)
				{
					ConditionsList conditionsList = (characterUnlockCondition_ = new ConditionsList());
					builder = characterUnlockCondition_;
				}
				input.ReadMessage(builder);
			}
			if (num == 58)
			{
				RepeatedField<Types.LocationTypeWeight> repeatedField = locations_;
				FieldCodec<Types.LocationTypeWeight> repeated_locations_codec = _repeated_locations_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_locations_codec);
			}
			int num2 = default(int);
			if (num == 64)
			{
				num2 = (numberOfMissionsToComplete_ = input.ReadInt32());
			}
			if (num2 == 72)
			{
				goto IL_00a6;
			}
			goto IL_01eb;
			IL_01eb:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_00bf:
			ConditionsList conditionsList2 = default(ConditionsList);
			if ((int)num > 24)
			{
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (maxProbability_ = input.ReadInt32());
				}
				if (num3 == 42)
				{
					ConditionsList builder2 = default(ConditionsList);
					if (preConditions_ == null)
					{
						conditionsList2 = (preConditions_ = new ConditionsList());
						builder2 = preConditions_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)conditionsList2 != 50)
				{
					goto IL_01eb;
				}
				RepeatedField<SecretCharacterRecurringCondition> repeatedField2 = recurringConditions_;
				FieldCodec<SecretCharacterRecurringCondition> repeated_recurringConditions_codec = _repeated_recurringConditions_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_recurringConditions_codec);
			}
			bool flag = default(bool);
			if ((long)conditionsList2 == 10)
			{
				Types.SpecificMomentData specificMomentData = new Types.SpecificMomentData();
				if (apparitionCase_ == ApparitionOneofCase.SpecificMoment)
				{
					if (apparitionCase_ != ApparitionOneofCase.SpecificMoment)
					{
					}
					object obj = apparition_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(specificMomentData);
				apparition_ = specificMomentData;
				flag = (byte)(apparitionCase_ = ((specificMomentData != null) ? ApparitionOneofCase.SpecificMoment : ApparitionOneofCase.None)) != 0;
			}
			if (flag)
			{
				Empty builder3 = new Empty();
				if (apparitionCase_ == ApparitionOneofCase.Always)
				{
					if (apparitionCase_ != ApparitionOneofCase.Always)
					{
					}
					object obj2 = apparition_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				apparition_ = builder3;
				apparitionCase_ = (ApparitionOneofCase)typeof(Empty).TypeHandle;
			}
			if ((long)typeof(Empty).TypeHandle == 24)
			{
				int num4 = (baseProbability_ = input.ReadInt32());
			}
			goto IL_01eb;
			IL_00a6:
			RepeatedField<int> repeatedField3 = missions_;
			FieldCodec<int> repeated_missions_codec = _repeated_missions_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_missions_codec);
			goto IL_00bf;
		}

		[Cpp2IlInjected.Token(Token = "0x6002431")]
		[Cpp2IlInjected.Address(RVA = "0x383E8B0", Offset = "0x383D2B0", VA = "0x18383E8B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				Types.SpecificMomentData specificMoment = SpecificMoment;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002432")]
		[Cpp2IlInjected.Address(RVA = "0x383F690", Offset = "0x383E090", VA = "0x18383F690", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028, IL_002c, IL_0030, IL_0031, IL_0032, IL_0033, IL_0037, IL_003b, IL_003c, IL_0040, IL_0044, IL_0045, IL_0049, IL_004d, IL_0059, IL_005f
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				apparition_ = num;
				bool flag = (byte)(apparitionCase_ = ((num != 0) ? ApparitionOneofCase.SpecificMoment : ApparitionOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002433")]
		[Cpp2IlInjected.Address(RVA = "0x383E100", Offset = "0x383CB00", VA = "0x18383E100", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0018, IL_0022, IL_002c, IL_003f, IL_004b, IL_0057
			//IL_0010: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = 0;
				apparition_ = num;
				apparitionCase_ = (ApparitionOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002434")]
		[Cpp2IlInjected.Address(RVA = "0x383EC80", Offset = "0x383D680", VA = "0x18383EC80", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Apparition"))
			{
				ApparitionOneofCase apparitionOneofCase = apparitionCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002435")]
		[Cpp2IlInjected.Address(RVA = "0x383E250", Offset = "0x383CC50", VA = "0x18383E250", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Apparition"))
			{
				apparition_ = (apparitionCase_ = ApparitionOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002436")]
		[Cpp2IlInjected.Address(RVA = "0x383ED30", Offset = "0x383D730", VA = "0x18383ED30")]
		public bool HasCharacterUnlockConditions()
		{
			//Discarded unreachable code: IL_000f
			return !characterUnlockCondition_.IsEmpty;
		}

		[Cpp2IlInjected.Token(Token = "0x6002437")]
		[Cpp2IlInjected.Address(RVA = "0x383E320", Offset = "0x383CD20", VA = "0x18383E320", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003d, IL_0043, IL_0049, IL_004f, IL_0055
			//IL_0027: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			int num = 0;
			RepeatedField<int> repeatedField = missions_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (!flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				string error = $"SecretData mission {flag} should not be part of any quest ({flag})";
				context.AddError(error);
			}
			context.AddError("SecretData missions cannot contain (none)");
		}

		[Cpp2IlInjected.Token(Token = "0x6002438")]
		[Cpp2IlInjected.Address(RVA = "0x383FE20", Offset = "0x383E820", VA = "0x18383FE20")]
		static SecretCharacterData()
		{
			Func<SecretCharacterData> func = default(Func<SecretCharacterData>);
			_parser = (MessageParser<SecretCharacterData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<SecretCharacterRecurringCondition> parser = SecretCharacterRecurringCondition._parser;
			uint num = default(uint);
			_parser = (MessageParser<SecretCharacterData>)(object)FieldCodec.ForMessage<SecretCharacterRecurringCondition>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.LocationTypeWeight> parser2 = Types.LocationTypeWeight._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<SecretCharacterData>)(object)FieldCodec.ForMessage<Types.LocationTypeWeight>(num2, (MessageParser<>)(object)parser2);
			_parser = (MessageParser<SecretCharacterData>)(object)FieldCodec.ForInt32(74u);
			/*Error: Unexpected end of block*/;
		}
	}
}
