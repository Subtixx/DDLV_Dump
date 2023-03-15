using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Rewards;
using Definitions.Util;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000337")]
	public sealed class CharacterItemData : IMessage<CharacterItemData>, IMessage, IEquatable<CharacterItemData>, IDeepCloneable<CharacterItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasTags, IGenericBuyable, IDreamDustConvertible, IDataValidation, IHasItemDependencies, IProtobufDefaultData, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x2000338")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000339")]
			public sealed class DailyScheduleData : IMessage<DailyScheduleData>, IMessage, IEquatable<DailyScheduleData>, IDeepCloneable<DailyScheduleData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x200033A")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x200033B")]
					public sealed class Data : IMessage<Data>, IMessage, IEquatable<Data>, IDeepCloneable<Data>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x400108A")]
						private static readonly MessageParser<Data> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x400108B")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x400108C")]
						public const int TypeFieldNumber = 1;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x400108D")]
						private ScheduleType type_;

						[Cpp2IlInjected.Token(Token = "0x400108E")]
						public const int StartFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
						[Cpp2IlInjected.Token(Token = "0x400108F")]
						private int start_;

						[Cpp2IlInjected.Token(Token = "0x4001090")]
						public const int EndFieldNumber = 3;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001091")]
						private int end_;

						[Cpp2IlInjected.Token(Token = "0x17000955")]
						[DebuggerNonUserCode]
						public static MessageParser<Data> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60025C0")]
							[Cpp2IlInjected.Address(RVA = "0x236BF90", Offset = "0x236A990", VA = "0x18236BF90")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000956")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60025C1")]
							[Cpp2IlInjected.Address(RVA = "0x236BF10", Offset = "0x236A910", VA = "0x18236BF10")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000957")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60025C2")]
							[Cpp2IlInjected.Address(RVA = "0x236C050", Offset = "0x236AA50", VA = "0x18236C050", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000958")]
						[DebuggerNonUserCode]
						public ScheduleType Type
						{
							[Cpp2IlInjected.Token(Token = "0x60025C6")]
							[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
							get
							{
								return default(ScheduleType);
							}
							[Cpp2IlInjected.Token(Token = "0x60025C7")]
							[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000959")]
						[DebuggerNonUserCode]
						public int Start
						{
							[Cpp2IlInjected.Token(Token = "0x60025C8")]
							[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
							get
							{
								return default(int);
							}
							[Cpp2IlInjected.Token(Token = "0x60025C9")]
							[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700095A")]
						[DebuggerNonUserCode]
						public int End
						{
							[Cpp2IlInjected.Token(Token = "0x60025CA")]
							[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
							get
							{
								return default(int);
							}
							[Cpp2IlInjected.Token(Token = "0x60025CB")]
							[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60025C3")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public Data()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60025C4")]
						[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
						[DebuggerNonUserCode]
						public Data(Data other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60025C5")]
						[Cpp2IlInjected.Address(RVA = "0x236B5E0", Offset = "0x2369FE0", VA = "0x18236B5E0", Slot = "10")]
						[DebuggerNonUserCode]
						public Data Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60025CC")]
						[Cpp2IlInjected.Address(RVA = "0x236B790", Offset = "0x236A190", VA = "0x18236B790", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60025CD")]
						[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(Data other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60025CE")]
						[Cpp2IlInjected.Address(RVA = "0x180B0C0", Offset = "0x1809AC0", VA = "0x18180B0C0", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60025CF")]
						[Cpp2IlInjected.Address(RVA = "0x236BBB0", Offset = "0x236A5B0", VA = "0x18236BBB0", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60025D0")]
						[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60025D1")]
						[Cpp2IlInjected.Address(RVA = "0x236B4E0", Offset = "0x2369EE0", VA = "0x18236B4E0", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60025D2")]
						[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(Data other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60025D3")]
						[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60025D4")]
						[Cpp2IlInjected.Address(RVA = "0x236B8F0", Offset = "0x236A2F0", VA = "0x18236B8F0", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60025D5")]
						[Cpp2IlInjected.Address(RVA = "0x236B9D0", Offset = "0x236A3D0", VA = "0x18236B9D0", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60025D6")]
						[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4001085")]
				private static readonly MessageParser<DailyScheduleData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001086")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001087")]
				public const int ScheduleFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4001088")]
				private static readonly FieldCodec<Types.Data> _repeated_schedule_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001089")]
				private readonly RepeatedField<Types.Data> schedule_;

				[Cpp2IlInjected.Token(Token = "0x17000951")]
				[DebuggerNonUserCode]
				public static MessageParser<DailyScheduleData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60025AD")]
					[Cpp2IlInjected.Address(RVA = "0x9D30B0", Offset = "0x9D1AB0", VA = "0x1809D30B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000952")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60025AE")]
					[Cpp2IlInjected.Address(RVA = "0x9D3030", Offset = "0x9D1A30", VA = "0x1809D3030")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000953")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60025AF")]
					[Cpp2IlInjected.Address(RVA = "0x9D3110", Offset = "0x9D1B10", VA = "0x1809D3110", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000954")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.Data> Schedule
				{
					[Cpp2IlInjected.Token(Token = "0x60025B3")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60025B0")]
				[Cpp2IlInjected.Address(RVA = "0x9D2FB0", Offset = "0x9D19B0", VA = "0x1809D2FB0")]
				[DebuggerNonUserCode]
				public DailyScheduleData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60025B1")]
				[Cpp2IlInjected.Address(RVA = "0x9D2EB0", Offset = "0x9D18B0", VA = "0x1809D2EB0")]
				[DebuggerNonUserCode]
				public DailyScheduleData(DailyScheduleData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60025B2")]
				[Cpp2IlInjected.Address(RVA = "0x9D26D0", Offset = "0x9D10D0", VA = "0x1809D26D0", Slot = "10")]
				[DebuggerNonUserCode]
				public DailyScheduleData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60025B4")]
				[Cpp2IlInjected.Address(RVA = "0x9D2890", Offset = "0x9D1290", VA = "0x1809D2890", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60025B5")]
				[Cpp2IlInjected.Address(RVA = "0x9D2800", Offset = "0x9D1200", VA = "0x1809D2800", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(DailyScheduleData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60025B6")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60025B7")]
				[Cpp2IlInjected.Address(RVA = "0x9D2BC0", Offset = "0x9D15C0", VA = "0x1809D2BC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60025B8")]
				[Cpp2IlInjected.Address(RVA = "0x9D2C20", Offset = "0x9D1620", VA = "0x1809D2C20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60025B9")]
				[Cpp2IlInjected.Address(RVA = "0x9D25C0", Offset = "0x9D0FC0", VA = "0x1809D25C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60025BA")]
				[Cpp2IlInjected.Address(RVA = "0x9D2AE0", Offset = "0x9D14E0", VA = "0x1809D2AE0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(DailyScheduleData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60025BB")]
				[Cpp2IlInjected.Address(RVA = "0x9D29F0", Offset = "0x9D13F0", VA = "0x1809D29F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60025BC")]
				[Cpp2IlInjected.Address(RVA = "0x9D2970", Offset = "0x9D1370", VA = "0x1809D2970", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60025BD")]
				[Cpp2IlInjected.Address(RVA = "0x9D2B60", Offset = "0x9D1560", VA = "0x1809D2B60", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60025BE")]
				[Cpp2IlInjected.Address(RVA = "0x9D2670", Offset = "0x9D1070", VA = "0x1809D2670", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001047")]
		private static readonly MessageParser<CharacterItemData> _parser = (MessageParser<CharacterItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CharacterItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001048")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001049")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400104A")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x400104B")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400104C")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x400104D")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400104E")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x400104F")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001050")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4001051")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001052")]
		private string prefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4001053")]
		public const int IsDebugFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001054")]
		private bool isDebug_;

		[Cpp2IlInjected.Token(Token = "0x4001055")]
		public const int TagsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001056")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001057")]
		private readonly RepeatedField<int> tags_;

		[Cpp2IlInjected.Token(Token = "0x4001058")]
		public const int HouseFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001059")]
		private int house_;

		[Cpp2IlInjected.Token(Token = "0x400105A")]
		public const int DescriptionFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400105B")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x400105C")]
		public const int UnlockConditionFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400105D")]
		private CharacterUnlockCondition unlockCondition_;

		[Cpp2IlInjected.Token(Token = "0x400105E")]
		public const int SecretCharacterDataFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400105F")]
		private SecretCharacterData secretCharacterData_;

		[Cpp2IlInjected.Token(Token = "0x4001060")]
		public const int DailyScheduleFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4001061")]
		private static readonly FieldCodec<Types.DailyScheduleData> _repeated_dailySchedule_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001062")]
		private readonly RepeatedField<Types.DailyScheduleData> dailySchedule_;

		[Cpp2IlInjected.Token(Token = "0x4001063")]
		public const int ForcedAvailableScheduleTypesFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4001064")]
		private static readonly FieldCodec<ScheduleType> _repeated_forcedAvailableScheduleTypes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001065")]
		private readonly RepeatedField<ScheduleType> forcedAvailableScheduleTypes_;

		[Cpp2IlInjected.Token(Token = "0x4001066")]
		public const int OverrideSchedulesFieldNumber = 18;

		[Cpp2IlInjected.Token(Token = "0x4001067")]
		private static readonly FieldCodec<OverrideScheduleData> _repeated_overrideSchedules_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001068")]
		private readonly RepeatedField<OverrideScheduleData> overrideSchedules_;

		[Cpp2IlInjected.Token(Token = "0x4001069")]
		public const int DefaultCurrencyItemIDFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400106A")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x400106B")]
		public const int DreamDustOverrideValueFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400106C")]
		private int dreamDustOverrideValue_;

		[Cpp2IlInjected.Token(Token = "0x400106D")]
		public const int PreferredItemDifficultiesFieldNumber = 19;

		[Cpp2IlInjected.Token(Token = "0x400106E")]
		private static readonly FieldCodec<PreferredItemDifficulty> _repeated_preferredItemDifficulties_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400106F")]
		private readonly RepeatedField<PreferredItemDifficulty> preferredItemDifficulties_;

		[Cpp2IlInjected.Token(Token = "0x4001070")]
		public const int PreferedItemsProfileItemIDFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001071")]
		private int preferedItemsProfileItemID_;

		[Cpp2IlInjected.Token(Token = "0x4001072")]
		public const int SignatureItemsFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x4001073")]
		private static readonly FieldCodec<int> _repeated_signatureItems_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001074")]
		private readonly RepeatedField<int> signatureItems_;

		[Cpp2IlInjected.Token(Token = "0x4001075")]
		public const int CanHangoutWithPlayerFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001076")]
		private bool canHangoutWithPlayer_;

		[Cpp2IlInjected.Token(Token = "0x4001077")]
		public const int ForbiddenProfessionsFieldNumber = 26;

		[Cpp2IlInjected.Token(Token = "0x4001078")]
		private static readonly FieldCodec<int> _repeated_forbiddenProfessions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001079")]
		private readonly RepeatedField<int> forbiddenProfessions_;

		[Cpp2IlInjected.Token(Token = "0x400107A")]
		public const int SwitcherUnlockConditionsFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400107B")]
		private ConditionsList switcherUnlockConditions_;

		[Cpp2IlInjected.Token(Token = "0x400107C")]
		public const int DisableSleepConditionsFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400107D")]
		private ConditionsList disableSleepConditions_;

		[Cpp2IlInjected.Token(Token = "0x400107E")]
		public const int IsFemaleFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400107F")]
		private bool isFemale_;

		[Cpp2IlInjected.Token(Token = "0x4001080")]
		public const int DefaultSkinIconAddressFieldNumber = 33;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001081")]
		private string defaultSkinIconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4001082")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001083")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001084")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x1700092B")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600254E")]
			[Cpp2IlInjected.Address(RVA = "0x289ED20", Offset = "0x289D720", VA = "0x18289ED20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700092C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600254F")]
			[Cpp2IlInjected.Address(RVA = "0x289EB30", Offset = "0x289D530", VA = "0x18289EB30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700092D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002550")]
			[Cpp2IlInjected.Address(RVA = "0x289EE40", Offset = "0x289D840", VA = "0x18289EE40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700092E")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002555")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002556")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700092F")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002557")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002558")]
			[Cpp2IlInjected.Address(RVA = "0x289F110", Offset = "0x289DB10", VA = "0x18289F110")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000930")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002559")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600255A")]
			[Cpp2IlInjected.Address(RVA = "0x289F030", Offset = "0x289DA30", VA = "0x18289F030")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000931")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600255B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600255C")]
			[Cpp2IlInjected.Address(RVA = "0x289F0A0", Offset = "0x289DAA0", VA = "0x18289F0A0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000932")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600255D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600255E")]
			[Cpp2IlInjected.Address(RVA = "0x289F180", Offset = "0x289DB80", VA = "0x18289F180")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000933")]
		[DebuggerNonUserCode]
		public bool IsDebug
		{
			[Cpp2IlInjected.Token(Token = "0x600255F")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return isDebug_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002560")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				isDebug_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000934")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002561")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "24")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000935")]
		[DebuggerNonUserCode]
		public int House
		{
			[Cpp2IlInjected.Token(Token = "0x6002562")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return house_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002563")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				house_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000936")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6002564")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002565")]
			[Cpp2IlInjected.Address(RVA = "0x289EFC0", Offset = "0x289D9C0", VA = "0x18289EFC0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000937")]
		[DebuggerNonUserCode]
		public CharacterUnlockCondition UnlockCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6002566")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return unlockCondition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002567")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				unlockCondition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000938")]
		[DebuggerNonUserCode]
		public SecretCharacterData SecretCharacterData
		{
			[Cpp2IlInjected.Token(Token = "0x6002568")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return secretCharacterData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002569")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				secretCharacterData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000939")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.DailyScheduleData> DailySchedule
		{
			[Cpp2IlInjected.Token(Token = "0x600256A")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return dailySchedule_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700093A")]
		[DebuggerNonUserCode]
		public RepeatedField<ScheduleType> ForcedAvailableScheduleTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600256B")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return forcedAvailableScheduleTypes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700093B")]
		[DebuggerNonUserCode]
		public RepeatedField<OverrideScheduleData> OverrideSchedules
		{
			[Cpp2IlInjected.Token(Token = "0x600256C")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return overrideSchedules_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700093C")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600256D")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600256E")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700093D")]
		[DebuggerNonUserCode]
		public int DreamDustOverrideValue
		{
			[Cpp2IlInjected.Token(Token = "0x600256F")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8CAA0", VA = "0x180A8E0A0", Slot = "28")]
			get
			{
				return dreamDustOverrideValue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002570")]
			[Cpp2IlInjected.Address(RVA = "0x125C200", Offset = "0x125AC00", VA = "0x18125C200")]
			set
			{
				dreamDustOverrideValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700093E")]
		[DebuggerNonUserCode]
		public RepeatedField<PreferredItemDifficulty> PreferredItemDifficulties
		{
			[Cpp2IlInjected.Token(Token = "0x6002571")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return preferredItemDifficulties_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700093F")]
		[DebuggerNonUserCode]
		public int PreferedItemsProfileItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002572")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return preferedItemsProfileItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002573")]
			[Cpp2IlInjected.Address(RVA = "0x1373C40", Offset = "0x1372640", VA = "0x181373C40")]
			set
			{
				preferedItemsProfileItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000940")]
		[DebuggerNonUserCode]
		public RepeatedField<int> SignatureItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002574")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return signatureItems_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000941")]
		[DebuggerNonUserCode]
		public bool CanHangoutWithPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6002575")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0")]
			get
			{
				return canHangoutWithPlayer_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002576")]
			[Cpp2IlInjected.Address(RVA = "0x7DB480", Offset = "0x7D9E80", VA = "0x1807DB480")]
			set
			{
				canHangoutWithPlayer_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000942")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ForbiddenProfessions
		{
			[Cpp2IlInjected.Token(Token = "0x6002577")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return forbiddenProfessions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000943")]
		[DebuggerNonUserCode]
		public ConditionsList SwitcherUnlockConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6002578")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return switcherUnlockConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002579")]
			[Cpp2IlInjected.Address(RVA = "0x9766B0", Offset = "0x9750B0", VA = "0x1809766B0")]
			set
			{
				switcherUnlockConditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000944")]
		[DebuggerNonUserCode]
		public ConditionsList DisableSleepConditions
		{
			[Cpp2IlInjected.Token(Token = "0x600257A")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return disableSleepConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x600257B")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			set
			{
				disableSleepConditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000945")]
		[DebuggerNonUserCode]
		public bool IsFemale
		{
			[Cpp2IlInjected.Token(Token = "0x600257C")]
			[Cpp2IlInjected.Address(RVA = "0xD3CD40", Offset = "0xD3B740", VA = "0x180D3CD40")]
			get
			{
				return isFemale_;
			}
			[Cpp2IlInjected.Token(Token = "0x600257D")]
			[Cpp2IlInjected.Address(RVA = "0xD3CEF0", Offset = "0xD3B8F0", VA = "0x180D3CEF0")]
			set
			{
				isFemale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000946")]
		[DebuggerNonUserCode]
		public string DefaultSkinIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600257E")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return defaultSkinIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600257F")]
			[Cpp2IlInjected.Address(RVA = "0x289EF50", Offset = "0x289D950", VA = "0x18289EF50")]
			set
			{
				string text = (defaultSkinIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000947")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002580")]
			[Cpp2IlInjected.Address(RVA = "0x1406560", Offset = "0x1404F60", VA = "0x181406560", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002581")]
			[Cpp2IlInjected.Address(RVA = "0x14066E0", Offset = "0x14050E0", VA = "0x1814066E0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000948")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600258D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "34")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000949")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x600258E")]
			[Cpp2IlInjected.Address(RVA = "0x289EB20", Offset = "0x289D520", VA = "0x18289EB20", Slot = "35")]
			get
			{
				return (long)usedTagTypes == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700094A")]
		public Item HouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x600258F")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				int num = house_;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002590")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				//IL_0007: Expected I4, but got O
				house_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700094B")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002591")]
			[Cpp2IlInjected.Address(RVA = "0x289EC00", Offset = "0x289D600", VA = "0x18289EC00", Slot = "30")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700094C")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6002592")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "31")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700094D")]
		public unsafe List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6002593")]
			[Cpp2IlInjected.Address(RVA = "0x289EC60", Offset = "0x289D660", VA = "0x18289EC60", Slot = "32")]
			get
			{
				//IL_0013: Expected O, but got I4
				RepeatedField<int> repeatedField = signatureItems_;
				int num = default(int);
				Func<int, Item> func = (Func<int, Item>)(object)new Func<T, TResult>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, Item>*/)(&Item.New));
				num = 0;
				return (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700094E")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002594")]
			[Cpp2IlInjected.Address(RVA = "0x289EDE0", Offset = "0x289D7E0", VA = "0x18289EDE0", Slot = "23")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700094F")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002597")]
			[Cpp2IlInjected.Address(RVA = "0x2899C00", Offset = "0x2898600", VA = "0x182899C00", Slot = "26")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000950")]
		public Item PreferredItemsProfileItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002598")]
			[Cpp2IlInjected.Address(RVA = "0x289ED80", Offset = "0x289D780", VA = "0x18289ED80")]
			get
			{
				long num = Convert.ToInt64((uint)preferedItemsProfileItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002551")]
		[Cpp2IlInjected.Address(RVA = "0x289E510", Offset = "0x289CF10", VA = "0x18289E510")]
		[DebuggerNonUserCode]
		public CharacterItemData()
		{
			name_ = "";
			displayName_ = "";
			iconAddress_ = "";
			prefabAddress_ = "";
			tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			description_ = "";
			dailySchedule_ = (RepeatedField<Types.DailyScheduleData>)(object)new RepeatedField<T>();
			forcedAvailableScheduleTypes_ = (RepeatedField<ScheduleType>)(object)new RepeatedField<T>();
			overrideSchedules_ = (RepeatedField<OverrideScheduleData>)(object)new RepeatedField<T>();
			preferredItemDifficulties_ = (RepeatedField<PreferredItemDifficulty>)(object)new RepeatedField<T>();
			signatureItems_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			forbiddenProfessions_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			defaultSkinIconAddress_ = "";
			base._002Ector();
			ConditionsList conditionsList = (switcherUnlockConditions_ = new ConditionsList());
			ConditionsList conditionsList2 = (disableSleepConditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002552")]
		[Cpp2IlInjected.Address(RVA = "0x289C8C0", Offset = "0x289B2C0", VA = "0x18289C8C0")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (switcherUnlockConditions_ = new ConditionsList());
			ConditionsList conditionsList2 = (disableSleepConditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002553")]
		[Cpp2IlInjected.Address(RVA = "0x289E800", Offset = "0x289D200", VA = "0x18289E800")]
		[DebuggerNonUserCode]
		public CharacterItemData(CharacterItemData other)
		{
			//IL_00be: Expected O, but got I4
			//IL_019a: Expected O, but got I4
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			bool flag = (isDebug_ = other.isDebug_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			int num2 = (house_ = other.house_);
			string text5 = (description_ = other.description_);
			CharacterUnlockCondition characterUnlockCondition = other.unlockCondition_;
			int num3 = 0;
			unlockCondition_ = characterUnlockCondition;
			SecretCharacterData secretCharacterData = other.secretCharacterData_;
			if (secretCharacterData != null)
			{
				SecretCharacterData secretCharacterData2 = secretCharacterData.Clone();
			}
			secretCharacterData_ = (SecretCharacterData)num3;
			RepeatedField<Types.DailyScheduleData> repeatedField2 = (dailySchedule_ = (RepeatedField<Types.DailyScheduleData>)(object)((RepeatedField<T>)(object)other.dailySchedule_).Clone());
			RepeatedField<ScheduleType> repeatedField3 = (forcedAvailableScheduleTypes_ = (RepeatedField<ScheduleType>)(object)((RepeatedField<T>)(object)other.forcedAvailableScheduleTypes_).Clone());
			RepeatedField<OverrideScheduleData> repeatedField4 = (overrideSchedules_ = (RepeatedField<OverrideScheduleData>)(object)((RepeatedField<T>)(object)other.overrideSchedules_).Clone());
			int num4 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			int num5 = (dreamDustOverrideValue_ = other.dreamDustOverrideValue_);
			RepeatedField<PreferredItemDifficulty> repeatedField5 = (preferredItemDifficulties_ = (RepeatedField<PreferredItemDifficulty>)(object)((RepeatedField<T>)(object)other.preferredItemDifficulties_).Clone());
			int num6 = (preferedItemsProfileItemID_ = other.preferedItemsProfileItemID_);
			RepeatedField<int> repeatedField6 = (signatureItems_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.signatureItems_).Clone());
			bool flag2 = (canHangoutWithPlayer_ = other.canHangoutWithPlayer_);
			RepeatedField<int> repeatedField7 = (forbiddenProfessions_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.forbiddenProfessions_).Clone());
			ConditionsList conditionsList = other.switcherUnlockConditions_;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			switcherUnlockConditions_ = (ConditionsList)num3;
			ConditionsList conditionsList3 = other.disableSleepConditions_;
			ConditionsList conditionsList4 = default(ConditionsList);
			if (conditionsList3 != null)
			{
				conditionsList4 = conditionsList3.Clone();
			}
			disableSleepConditions_ = conditionsList4;
			bool flag3 = (isFemale_ = other.isFemale_);
			string text6 = (defaultSkinIconAddress_ = other.defaultSkinIconAddress_);
			uint num7 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002554")]
		[Cpp2IlInjected.Address(RVA = "0x2898590", Offset = "0x2896F90", VA = "0x182898590", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterItemData Clone()
		{
			return new CharacterItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002582")]
		[Cpp2IlInjected.Address(RVA = "0x289A260", Offset = "0x2898C60", VA = "0x18289A260", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CharacterItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002583")]
		[Cpp2IlInjected.Address(RVA = "0x2899F20", Offset = "0x2898920", VA = "0x182899F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterItemData other)
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
									bool flag = other.isDebug_;
									if ((IntPtr)usedTagTypes == (IntPtr)(flag ? 1 : 0))
									{
										RepeatedField<int> repeatedField = tags_;
										RepeatedField<int> repeatedField2 = other.tags_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											int num2 = other.house_;
											if (house_ == num2)
											{
												string text5 = other.description_;
												if (!(description_ != text5))
												{
													CharacterUnlockCondition characterUnlockCondition = other.unlockCondition_;
													if (unlockCondition_ == characterUnlockCondition)
													{
														SecretCharacterData objB = other.secretCharacterData_;
														if (object.Equals(secretCharacterData_, objB))
														{
															RepeatedField<Types.DailyScheduleData> repeatedField3 = dailySchedule_;
															RepeatedField<Types.DailyScheduleData> repeatedField4 = other.dailySchedule_;
															if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
															{
																RepeatedField<ScheduleType> repeatedField5 = forcedAvailableScheduleTypes_;
																RepeatedField<ScheduleType> repeatedField6 = other.forcedAvailableScheduleTypes_;
																if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
																{
																	RepeatedField<OverrideScheduleData> repeatedField7 = overrideSchedules_;
																	RepeatedField<OverrideScheduleData> repeatedField8 = other.overrideSchedules_;
																	if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
																	{
																		int num3 = other.defaultCurrencyItemID_;
																		if (defaultCurrencyItemID_ == num3)
																		{
																			int num4 = other.dreamDustOverrideValue_;
																			if (dreamDustOverrideValue_ == num4)
																			{
																				RepeatedField<PreferredItemDifficulty> repeatedField9 = preferredItemDifficulties_;
																				RepeatedField<PreferredItemDifficulty> repeatedField10 = other.preferredItemDifficulties_;
																				if (((RepeatedField<T>)(object)repeatedField9).Equals((RepeatedField<>)(object)repeatedField10))
																				{
																					int num5 = other.preferedItemsProfileItemID_;
																					if (preferedItemsProfileItemID_ == num5)
																					{
																						RepeatedField<int> repeatedField11 = signatureItems_;
																						RepeatedField<int> repeatedField12 = other.signatureItems_;
																						if (((RepeatedField<T>)(object)repeatedField11).Equals((RepeatedField<>)(object)repeatedField12))
																						{
																							bool flag2 = other.canHangoutWithPlayer_;
																							if (canHangoutWithPlayer_ == flag2)
																							{
																								RepeatedField<int> repeatedField13 = forbiddenProfessions_;
																								RepeatedField<int> repeatedField14 = other.forbiddenProfessions_;
																								if (((RepeatedField<T>)(object)repeatedField13).Equals((RepeatedField<>)(object)repeatedField14))
																								{
																									ConditionsList objB2 = other.switcherUnlockConditions_;
																									if (object.Equals(switcherUnlockConditions_, objB2))
																									{
																										ConditionsList objB3 = other.disableSleepConditions_;
																										if (object.Equals(disableSleepConditions_, objB3))
																										{
																											bool flag3 = other.isFemale_;
																											if (isFemale_ == flag3)
																											{
																												string text6 = other.defaultSkinIconAddress_;
																												if (!(defaultSkinIconAddress_ != text6))
																												{
																													uint num6 = other.glotID_;
																													if (glotID_ == num6)
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
								}
							}
						}
					}
				}
			}
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002584")]
		[Cpp2IlInjected.Address(RVA = "0x289A9F0", Offset = "0x28993F0", VA = "0x18289A9F0", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_01c1
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
			if (isDebug_)
			{
			}
			int hashCode5 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (house_ != 0)
			{
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			if (unlockCondition_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			SecretCharacterData secretCharacterData = secretCharacterData_;
			if (secretCharacterData != null)
			{
				int hashCode7 = secretCharacterData.GetHashCode();
			}
			int hashCode8 = ((RepeatedField<T>)(object)dailySchedule_).GetHashCode();
			int hashCode9 = ((RepeatedField<T>)(object)forcedAvailableScheduleTypes_).GetHashCode();
			int hashCode10 = ((RepeatedField<T>)(object)overrideSchedules_).GetHashCode();
			if (defaultCurrencyItemID_ != 0)
			{
			}
			if (dreamDustOverrideValue_ != 0)
			{
			}
			int hashCode11 = ((RepeatedField<T>)(object)preferredItemDifficulties_).GetHashCode();
			if (preferedItemsProfileItemID_ != 0)
			{
			}
			int hashCode12 = ((RepeatedField<T>)(object)signatureItems_).GetHashCode();
			if (canHangoutWithPlayer_)
			{
			}
			int hashCode13 = ((RepeatedField<T>)(object)forbiddenProfessions_).GetHashCode();
			ConditionsList conditionsList = switcherUnlockConditions_;
			if (conditionsList != null)
			{
				int hashCode14 = conditionsList.GetHashCode();
			}
			ConditionsList conditionsList2 = disableSleepConditions_;
			if (conditionsList2 != null)
			{
				int hashCode15 = conditionsList2.GetHashCode();
			}
			if (isFemale_)
			{
			}
			string text6 = defaultSkinIconAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode16 = text6.GetHashCode();
			}
			if (glotID_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text6)->ResultCode;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode17 = unknownFields.GetHashCode();
			}
			return hashCode10;
		}

		[Cpp2IlInjected.Token(Token = "0x6002585")]
		[Cpp2IlInjected.Address(RVA = "0x289D190", Offset = "0x289BB90", VA = "0x18289D190", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002586")]
		[Cpp2IlInjected.Address(RVA = "0x289D8B0", Offset = "0x289C2B0", VA = "0x18289D8B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_02af
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
			if ((long)usedTagTypes != 0)
			{
				bool value6 = isDebug_;
				output.WriteBool(value6);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (house_ != 0)
			{
				int value7 = house_;
				output.WriteInt32(value7);
			}
			if (description_.m_stringLength != 0)
			{
				string value8 = description_;
				output.WriteString(value8);
			}
			if (unlockCondition_ != 0)
			{
			}
			if ((long)secretCharacterData_ != 0)
			{
				SecretCharacterData value9 = secretCharacterData_;
				output.WriteMessage(value9);
			}
			RepeatedField<Types.DailyScheduleData> repeatedField2 = dailySchedule_;
			FieldCodec<Types.DailyScheduleData> repeated_dailySchedule_codec = _repeated_dailySchedule_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_dailySchedule_codec);
			RepeatedField<ScheduleType> repeatedField3 = forcedAvailableScheduleTypes_;
			FieldCodec<ScheduleType> repeated_forcedAvailableScheduleTypes_codec = _repeated_forcedAvailableScheduleTypes_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_forcedAvailableScheduleTypes_codec);
			if (defaultCurrencyItemID_ != 0)
			{
				int value10 = defaultCurrencyItemID_;
				output.WriteInt32(value10);
			}
			if (dreamDustOverrideValue_ != 0)
			{
				int value11 = dreamDustOverrideValue_;
				output.WriteInt32(value11);
			}
			RepeatedField<OverrideScheduleData> repeatedField4 = overrideSchedules_;
			FieldCodec<OverrideScheduleData> repeated_overrideSchedules_codec = _repeated_overrideSchedules_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_overrideSchedules_codec);
			RepeatedField<PreferredItemDifficulty> repeatedField5 = preferredItemDifficulties_;
			FieldCodec<PreferredItemDifficulty> repeated_preferredItemDifficulties_codec = _repeated_preferredItemDifficulties_codec;
			((RepeatedField<T>)(object)repeatedField5).WriteTo(output, (FieldCodec<>)(object)repeated_preferredItemDifficulties_codec);
			if (preferedItemsProfileItemID_ != 0)
			{
				int value12 = preferedItemsProfileItemID_;
				output.WriteInt32(value12);
			}
			RepeatedField<int> repeatedField6 = signatureItems_;
			FieldCodec<int> repeated_signatureItems_codec = _repeated_signatureItems_codec;
			((RepeatedField<T>)(object)repeatedField6).WriteTo(output, (FieldCodec<>)(object)repeated_signatureItems_codec);
			if (canHangoutWithPlayer_)
			{
				bool value13 = canHangoutWithPlayer_;
				output.WriteBool(value13);
			}
			RepeatedField<int> repeatedField7 = forbiddenProfessions_;
			FieldCodec<int> repeated_forbiddenProfessions_codec = _repeated_forbiddenProfessions_codec;
			((RepeatedField<T>)(object)repeatedField7).WriteTo(output, (FieldCodec<>)(object)repeated_forbiddenProfessions_codec);
			if ((long)switcherUnlockConditions_ != 0)
			{
				ConditionsList value14 = switcherUnlockConditions_;
				output.WriteMessage(value14);
			}
			if ((long)disableSleepConditions_ != 0)
			{
				ConditionsList value15 = disableSleepConditions_;
				output.WriteMessage(value15);
			}
			if (isFemale_)
			{
				bool value16 = isFemale_;
				output.WriteBool(value16);
			}
			if (defaultSkinIconAddress_.m_stringLength != 0)
			{
				string value17 = defaultSkinIconAddress_;
				output.WriteString(value17);
			}
			if (glotID_ != 0)
			{
				uint value18 = glotID_;
				output.WriteUInt32(value18);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002587")]
		[Cpp2IlInjected.Address(RVA = "0x2897C00", Offset = "0x2896600", VA = "0x182897C00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected O, but got Unknown
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected O, but got Unknown
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Expected O, but got Unknown
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Expected O, but got Unknown
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
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			int num9 = house_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text5);
				num11++;
			}
			CharacterUnlockCondition characterUnlockCondition = unlockCondition_;
			if (characterUnlockCondition != 0)
			{
				int num12 = CodedOutputStream.ComputeEnumSize((int)characterUnlockCondition);
				num12++;
			}
			SecretCharacterData secretCharacterData = secretCharacterData_;
			if (secretCharacterData != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(secretCharacterData);
				num13++;
			}
			RepeatedField<Types.DailyScheduleData> repeatedField2 = dailySchedule_;
			FieldCodec<Types.DailyScheduleData> repeated_dailySchedule_codec = _repeated_dailySchedule_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_dailySchedule_codec);
			RepeatedField<ScheduleType> repeatedField3 = forcedAvailableScheduleTypes_;
			FieldCodec<ScheduleType> repeated_forcedAvailableScheduleTypes_codec = _repeated_forcedAvailableScheduleTypes_codec;
			int num15 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_forcedAvailableScheduleTypes_codec);
			RepeatedField<OverrideScheduleData> repeatedField4 = overrideSchedules_;
			FieldCodec<OverrideScheduleData> repeated_overrideSchedules_codec = _repeated_overrideSchedules_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_overrideSchedules_codec);
			int num17 = defaultCurrencyItemID_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18 += 2;
			}
			int num19 = dreamDustOverrideValue_;
			if (num19 != 0)
			{
				int num20 = CodedOutputStream.ComputeInt32Size(num19);
				num20 += 2;
			}
			RepeatedField<PreferredItemDifficulty> repeatedField5 = preferredItemDifficulties_;
			FieldCodec<PreferredItemDifficulty> repeated_preferredItemDifficulties_codec = _repeated_preferredItemDifficulties_codec;
			int num21 = ((RepeatedField<T>)(object)repeatedField5).CalculateSize((FieldCodec<>)(object)repeated_preferredItemDifficulties_codec);
			int num22 = preferedItemsProfileItemID_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeInt32Size(num22);
				num23 += 2;
			}
			RepeatedField<int> repeatedField6 = signatureItems_;
			FieldCodec<int> repeated_signatureItems_codec = _repeated_signatureItems_codec;
			int num24 = ((RepeatedField<T>)(object)repeatedField6).CalculateSize((FieldCodec<>)(object)repeated_signatureItems_codec);
			RepeatedField<int> repeatedField7 = forbiddenProfessions_;
			FieldCodec<int> repeated_forbiddenProfessions_codec = _repeated_forbiddenProfessions_codec;
			int num25 = ((RepeatedField<T>)(object)repeatedField7).CalculateSize((FieldCodec<>)(object)repeated_forbiddenProfessions_codec);
			ConditionsList conditionsList = switcherUnlockConditions_;
			if (conditionsList != null)
			{
				int num26 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num26 += 2;
				repeatedField6 = (RepeatedField<int>)(repeatedField6 + num26);
			}
			ConditionsList conditionsList2 = disableSleepConditions_;
			if (conditionsList2 != null)
			{
				int num27 = CodedOutputStream.ComputeMessageSize(conditionsList2);
				num27 += 2;
				repeatedField6 = (RepeatedField<int>)(repeatedField6 + num27);
			}
			string text6 = defaultSkinIconAddress_;
			if (text6.m_stringLength != 0)
			{
				int num28 = CodedOutputStream.ComputeStringSize(text6);
				num28 += 2;
				repeatedField6 = (RepeatedField<int>)(repeatedField6 + num28);
			}
			uint num29 = glotID_;
			if (num29 != 0)
			{
				int num30 = CodedOutputStream.ComputeUInt32Size(num29);
				num30 += 2;
				repeatedField6 = (RepeatedField<int>)(repeatedField6 + num30);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num31 = unknownFields.CalculateSize();
				repeatedField6 = (RepeatedField<int>)(repeatedField6 + num31);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002588")]
		[Cpp2IlInjected.Address(RVA = "0x289C4C0", Offset = "0x289AEC0", VA = "0x18289C4C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterItemData other)
		{
			//Discarded unreachable code: IL_02ed
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
			bool flag = other.isDebug_;
			if (flag)
			{
				isDebug_ = flag;
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num2 = other.house_;
			if (num2 != 0)
			{
				house_ = num2;
			}
			string text5 = other.description_;
			if (text5.m_stringLength != 0)
			{
				Description = text5;
			}
			CharacterUnlockCondition characterUnlockCondition = other.unlockCondition_;
			if (characterUnlockCondition != 0)
			{
				unlockCondition_ = characterUnlockCondition;
			}
			if ((long)other.secretCharacterData_ != 0)
			{
				SecretCharacterData secretCharacterData2 = default(SecretCharacterData);
				if (secretCharacterData_ == null)
				{
					SecretCharacterData secretCharacterData = (secretCharacterData_ = new SecretCharacterData());
					secretCharacterData2 = secretCharacterData_;
				}
				SecretCharacterData other2 = other.secretCharacterData_;
				secretCharacterData2.MergeFrom(other2);
			}
			RepeatedField<Types.DailyScheduleData> repeatedField3 = dailySchedule_;
			RepeatedField<Types.DailyScheduleData> repeatedField4 = other.dailySchedule_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<ScheduleType> repeatedField5 = forcedAvailableScheduleTypes_;
			RepeatedField<ScheduleType> repeatedField6 = other.forcedAvailableScheduleTypes_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			RepeatedField<OverrideScheduleData> repeatedField7 = overrideSchedules_;
			RepeatedField<OverrideScheduleData> repeatedField8 = other.overrideSchedules_;
			((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
			int num3 = other.defaultCurrencyItemID_;
			if (num3 != 0)
			{
				defaultCurrencyItemID_ = num3;
			}
			int num4 = other.dreamDustOverrideValue_;
			if (num4 != 0)
			{
				dreamDustOverrideValue_ = num4;
			}
			RepeatedField<PreferredItemDifficulty> repeatedField9 = preferredItemDifficulties_;
			RepeatedField<PreferredItemDifficulty> repeatedField10 = other.preferredItemDifficulties_;
			((RepeatedField<T>)(object)repeatedField9).Add((IEnumerable<>)(object)repeatedField10);
			int num5 = other.preferedItemsProfileItemID_;
			if (num5 != 0)
			{
				preferedItemsProfileItemID_ = num5;
			}
			RepeatedField<int> repeatedField11 = signatureItems_;
			RepeatedField<int> repeatedField12 = other.signatureItems_;
			((RepeatedField<T>)(object)repeatedField11).Add((IEnumerable<>)(object)repeatedField12);
			bool flag2 = other.canHangoutWithPlayer_;
			if (flag2)
			{
				canHangoutWithPlayer_ = flag2;
			}
			RepeatedField<int> repeatedField13 = forbiddenProfessions_;
			RepeatedField<int> repeatedField14 = other.forbiddenProfessions_;
			((RepeatedField<T>)(object)repeatedField13).Add((IEnumerable<>)(object)repeatedField14);
			if ((long)other.switcherUnlockConditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (switcherUnlockConditions_ == null)
				{
					ConditionsList conditionsList = (switcherUnlockConditions_ = new ConditionsList());
					conditionsList2 = switcherUnlockConditions_;
				}
				ConditionsList other3 = other.switcherUnlockConditions_;
				conditionsList2.MergeFrom(other3);
			}
			if ((long)other.disableSleepConditions_ != 0)
			{
				ConditionsList conditionsList4 = default(ConditionsList);
				if (disableSleepConditions_ == null)
				{
					ConditionsList conditionsList3 = (disableSleepConditions_ = new ConditionsList());
					conditionsList4 = disableSleepConditions_;
				}
				ConditionsList other4 = other.disableSleepConditions_;
				conditionsList4.MergeFrom(other4);
			}
			bool flag3 = other.isFemale_;
			if (flag3)
			{
				isFemale_ = flag3;
			}
			string text6 = other.defaultSkinIconAddress_;
			if (text6.m_stringLength != 0)
			{
				DefaultSkinIconAddress = text6;
			}
			uint num6 = other.glotID_;
			if (num6 != 0)
			{
				glotID_ = num6;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002589")]
		[Cpp2IlInjected.Address(RVA = "0x289BDA0", Offset = "0x289A7A0", VA = "0x18289BDA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_03d7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 122)
			{
				goto IL_021f;
			}
			if ((int)num <= 170)
			{
				goto IL_0138;
			}
			if ((int)num > 242)
			{
				if ((int)num > 256)
				{
					if (num == 266)
					{
						string text2 = (DefaultSkinIconAddress = input.ReadString());
					}
					if (num != 7992)
					{
						goto IL_03c0;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				ConditionsList conditionsList = default(ConditionsList);
				if (num == 250)
				{
					ConditionsList builder = default(ConditionsList);
					if (disableSleepConditions_ == null)
					{
						conditionsList = (disableSleepConditions_ = new ConditionsList());
						builder = disableSleepConditions_;
					}
					input.ReadMessage(builder);
				}
				if ((long)conditionsList != 256)
				{
					goto IL_03c0;
				}
				bool flag = (isFemale_ = input.ReadBool());
			}
			ConditionsList conditionsList2 = default(ConditionsList);
			if ((int)num > 208)
			{
				if (num == 210)
				{
					goto IL_011f;
				}
				if (num != 242)
				{
					goto IL_03c0;
				}
				ConditionsList builder2 = default(ConditionsList);
				if (switcherUnlockConditions_ == null)
				{
					conditionsList2 = (switcherUnlockConditions_ = new ConditionsList());
					builder2 = switcherUnlockConditions_;
				}
				input.ReadMessage(builder2);
			}
			bool flag2 = default(bool);
			if ((long)conditionsList2 == 200)
			{
				flag2 = (canHangoutWithPlayer_ = input.ReadBool());
			}
			if (flag2)
			{
				goto IL_011f;
			}
			goto IL_03c0;
			IL_0138:
			int num3 = default(int);
			if ((int)num > 152)
			{
				if ((int)num > 160)
				{
					num += 4294967128u;
					if (num != 4294967293u)
					{
						goto IL_03c0;
					}
					RepeatedField<int> repeatedField = signatureItems_;
					FieldCodec<int> repeated_signatureItems_codec = _repeated_signatureItems_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_signatureItems_codec);
				}
				if (num == 154)
				{
					goto IL_01d1;
				}
				if (num != 160)
				{
					goto IL_03c0;
				}
				num3 = (preferedItemsProfileItemID_ = input.ReadInt32());
			}
			if (num3 <= 136)
			{
				goto IL_01ea;
			}
			if (num3 == 146)
			{
				RepeatedField<OverrideScheduleData> repeatedField2 = overrideSchedules_;
				FieldCodec<OverrideScheduleData> repeated_overrideSchedules_codec = _repeated_overrideSchedules_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_overrideSchedules_codec);
			}
			if (num3 == 152)
			{
				goto IL_01d1;
			}
			goto IL_03c0;
			IL_037b:
			string text3 = default(string);
			int num4 = default(int);
			if ((long)text3 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			string text5 = default(string);
			if (num4 == 18)
			{
				text5 = (Name = input.ReadString());
			}
			if ((long)text5 == 26)
			{
				string text7 = (DisplayName = input.ReadString());
			}
			goto IL_03c0;
			IL_034e:
			bool flag3 = default(bool);
			string text9 = default(string);
			if (flag3)
			{
				text9 = (IconAddress = input.ReadString());
			}
			if ((long)text9 == 42)
			{
				text3 = (PrefabAddress = input.ReadString());
				goto IL_037b;
			}
			goto IL_03c0;
			IL_011f:
			RepeatedField<int> repeatedField3 = forbiddenProfessions_;
			FieldCodec<int> repeated_forbiddenProfessions_codec = _repeated_forbiddenProfessions_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_forbiddenProfessions_codec);
			goto IL_0138;
			IL_0335:
			RepeatedField<int> repeatedField4 = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_034e;
			IL_01ea:
			int num5 = default(int);
			if (num3 == 128)
			{
				num5 = (defaultCurrencyItemID_ = input.ReadInt32());
			}
			if (num5 == 136)
			{
				int num6 = (dreamDustOverrideValue_ = input.ReadInt32());
				goto IL_021f;
			}
			goto IL_03c0;
			IL_01d1:
			RepeatedField<PreferredItemDifficulty> repeatedField5 = preferredItemDifficulties_;
			FieldCodec<PreferredItemDifficulty> repeated_preferredItemDifficulties_codec = _repeated_preferredItemDifficulties_codec;
			((RepeatedField<T>)(object)repeatedField5).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_preferredItemDifficulties_codec);
			goto IL_01ea;
			IL_03c0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_021f:
			int num8 = default(int);
			if ((int)num > 56)
			{
				SecretCharacterData secretCharacterData = default(SecretCharacterData);
				if ((int)num > 96)
				{
					if ((int)num > 114)
					{
						num += 4294967176u;
						if (num != 4294967293u)
						{
							goto IL_03c0;
						}
						RepeatedField<ScheduleType> repeatedField6 = forcedAvailableScheduleTypes_;
						FieldCodec<ScheduleType> repeated_forcedAvailableScheduleTypes_codec = _repeated_forcedAvailableScheduleTypes_codec;
						((RepeatedField<T>)(object)repeatedField6).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_forcedAvailableScheduleTypes_codec);
					}
					if (num == 106)
					{
						SecretCharacterData builder3 = default(SecretCharacterData);
						if (secretCharacterData_ == null)
						{
							secretCharacterData = (secretCharacterData_ = new SecretCharacterData());
							builder3 = secretCharacterData_;
						}
						input.ReadMessage(builder3);
					}
					if ((long)secretCharacterData != 114)
					{
						goto IL_03c0;
					}
					RepeatedField<Types.DailyScheduleData> repeatedField7 = dailySchedule_;
					FieldCodec<Types.DailyScheduleData> repeated_dailySchedule_codec = _repeated_dailySchedule_codec;
					((RepeatedField<T>)(object)repeatedField7).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_dailySchedule_codec);
				}
				int num7 = default(int);
				if ((long)secretCharacterData > 64)
				{
					string text12 = default(string);
					if ((long)secretCharacterData == 90)
					{
						text12 = (Description = input.ReadString());
					}
					if ((long)text12 != 96)
					{
						goto IL_03c0;
					}
					num7 = (int)(unlockCondition_ = (CharacterUnlockCondition)input.ReadInt32());
				}
				if (num7 == 58)
				{
					goto IL_0335;
				}
				if (num7 != 64)
				{
					goto IL_03c0;
				}
				num8 = (house_ = input.ReadInt32());
			}
			if (num8 <= 26)
			{
				goto IL_037b;
			}
			if (num8 <= 42)
			{
				goto IL_034e;
			}
			if (num8 == 48)
			{
				flag3 = (isDebug_ = input.ReadBool());
			}
			if (flag3)
			{
				goto IL_0335;
			}
			goto IL_03c0;
		}

		[Cpp2IlInjected.Token(Token = "0x600258A")]
		[Cpp2IlInjected.Address(RVA = "0x289A640", Offset = "0x2899040", VA = "0x18289A640", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 32)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
				uint num2 = glotID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600258B")]
		[Cpp2IlInjected.Address(RVA = "0x289C950", Offset = "0x289B350", VA = "0x18289C950", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_002c, IL_0034, IL_003c, IL_003d, IL_004a, IL_0052, IL_005a, IL_0062, IL_006a, IL_0072, IL_007a, IL_0082, IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab, IL_00b1
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0092: Expected I4, but got O
			if (fieldNumber - 1 <= 32)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x600258C")]
		[Cpp2IlInjected.Address(RVA = "0x2898270", Offset = "0x2896C70", VA = "0x182898270", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0033
			//IL_0010: Expected I4, but got I8
			//IL_0032: Expected I4, but got I8
			if (fieldNumber - 1 <= 32)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002595")]
		[Cpp2IlInjected.Address(RVA = "0x289B8D0", Offset = "0x289A2D0", VA = "0x18289B8D0")]
		public Item GetUniverseTag()
		{
			IEnumerable<Item> itemTags = (IEnumerable<Item>)ItemDataExtensions.GetItemTags((IHasTags)this);
			Func<Item, bool> _003C_003E9__170_ = _003C_003Ec._003C_003E9__170_0;
			if (_003C_003E9__170_ == null)
			{
				TagItemType tagItemType = default(TagItemType);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => tagItemType == TagItemType.Universe);
			}
			return Enumerable.FirstOrDefault<Item>((IEnumerable<>)itemTags, (Func<, >)(object)_003C_003E9__170_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002596")]
		[Cpp2IlInjected.Address(RVA = "0x289B6D0", Offset = "0x289A0D0", VA = "0x18289B6D0")]
		public ITagData GetUniverseITagData()
		{
			//Discarded unreachable code: IL_0037
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<Item> itemTags = (IEnumerable<Item>)ItemDataExtensions.GetItemTags((IHasTags)this);
			Func<Item, bool> _003C_003E9__170_ = _003C_003Ec._003C_003E9__170_0;
			if (_003C_003E9__170_ == null)
			{
				TagItemType tagItemType = default(TagItemType);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => tagItemType == TagItemType.Universe);
			}
			Item item = Enumerable.FirstOrDefault<Item>((IEnumerable<>)itemTags, (Func<, >)(object)_003C_003E9__170_);
			ITagData result = default(ITagData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002599")]
		[Cpp2IlInjected.Address(RVA = "0x289A5B0", Offset = "0x2898FB0", VA = "0x18289A5B0")]
		public ScheduleType GetCurrentSchedule(IProfile profile, ITransactionContext context, bool canOverride = true)
		{
			ScheduleType result = default(ScheduleType);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600259A")]
		[Cpp2IlInjected.Address(RVA = "0x289A2C0", Offset = "0x2898CC0", VA = "0x18289A2C0")]
		public ScheduleType GetCurrentSchedule(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, bool canOverride = true)
		{
			//Discarded unreachable code: IL_0050
			int num = 0;
			RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
			DayOfWeek dayOfWeek = default(DayOfWeek);
			int index = (int)dayOfWeek;
			RepeatedField<Types.DailyScheduleData.Types.Data> schedule_ = ((Types.DailyScheduleData)((RepeatedField<T>)(object)repeatedField)[index]).schedule_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (flag2)
				{
				}
			}
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			IProfileWorld profileWorld = (IProfileWorld)(object)((object)profileWorld + (object)profileWorld);
			num2 += 408;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600259B")]
		[Cpp2IlInjected.Address(RVA = "0x289D1F0", Offset = "0x289BBF0", VA = "0x18289D1F0")]
		public bool TryGetOverrideSchedule(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out OverrideScheduleData data)
		{
			//Discarded unreachable code: IL_0027, IL_002d
			int num = 0;
			int num2 = 0;
			RepeatedField<OverrideScheduleData> repeatedField = overrideSchedules_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600259C")]
		[Cpp2IlInjected.Address(RVA = "0x289D3C0", Offset = "0x289BDC0", VA = "0x18289D3C0")]
		public bool TryGetSpecificLocationOverride(IProfile profile, ITransactionContext context, out LocationSource locationSource, out bool fixPosition, out bool forceRotation)
		{
			RepeatedField<OverrideScheduleData> repeatedField = overrideSchedules_;
			Func<OverrideScheduleData, bool> func = (Func<OverrideScheduleData, bool>)(object)(Func<T, TResult>)delegate(OverrideScheduleData s)
			{
				//Discarded unreachable code: IL_002a
				if (s.schedule_ != ScheduleType.SpecificLocation)
				{
					int num2 = 0;
				}
				ConditionsList conditions_ = s.conditions_;
				ITransactionContext context2 = context;
				IProfile profile2 = profile;
				return conditions_.Evaluate(profile2, context2);
			};
			OverrideScheduleData overrideScheduleData = Enumerable.FirstOrDefault<OverrideScheduleData>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (overrideScheduleData != null)
			{
			}
			int num = 0;
			if (overrideScheduleData != null)
			{
				bool isFixedPosition = overrideScheduleData.IsFixedPosition;
			}
			if (overrideScheduleData != null)
			{
				bool isForcedRotation = overrideScheduleData.IsForcedRotation;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600259D")]
		[Cpp2IlInjected.Address(RVA = "0x289BA90", Offset = "0x289A490", VA = "0x18289BA90")]
		public bool IsSpecificLocationOverrideAffectedBy(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_007a, IL_0080, IL_0086
			int num = (int)conditionListener;
			int num2 = 0;
			int num3 = 0;
			RepeatedField<OverrideScheduleData> repeatedField = overrideSchedules_;
			Func<OverrideScheduleData, bool> _003C_003E9__180_ = _003C_003Ec._003C_003E9__180_0;
			if (_003C_003E9__180_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((OverrideScheduleData s) => s.schedule_ == ScheduleType.SpecificLocation);
			}
			IEnumerable<OverrideScheduleData> enumerable = (IEnumerable<OverrideScheduleData>)Enumerable.Where<OverrideScheduleData>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__180_);
			if (enumerable != null)
			{
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					if (num3 == (int)num4)
					{
						goto IL_0058;
					}
					num3++;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				num3++;
				goto IL_0058;
			}
			goto IL_0064;
			IL_0064:
			num3++;
			if (enumerable != null)
			{
			}
			if (num3 != 0)
			{
			}
			int num5 = 0;
			throw new NullReferenceException();
			IL_0058:
			num += num;
			num3 += 312;
			goto IL_0064;
		}

		[Cpp2IlInjected.Token(Token = "0x600259E")]
		[Cpp2IlInjected.Address(RVA = "0x2897BD0", Offset = "0x28965D0", VA = "0x182897BD0")]
		public bool AreSwitcherButtonsUnlocked(IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_000e
			return switcherUnlockConditions_.Evaluate(profile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600259F")]
		[Cpp2IlInjected.Address(RVA = "0x289BA10", Offset = "0x289A410", VA = "0x18289BA10")]
		public bool IsSleepDisabled(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			if (!disableSleepConditions_.IsEmpty)
			{
				return disableSleepConditions_.Evaluate(in playerProfile, in worldProfile, context);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A0")]
		[Cpp2IlInjected.Address(RVA = "0x289AD80", Offset = "0x2899780", VA = "0x18289AD80")]
		public unsafe bool GetNextTimeForScheduleType(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, ScheduleType scheduleType, out DateTime nextTime)
		{
			//Discarded unreachable code: IL_0083, IL_0089, IL_0095
			DayOfWeek dayOfWeek = default(DayOfWeek);
			bool flag = default(bool);
			int num3 = default(int);
			DayOfWeek dayOfWeek2 = default(DayOfWeek);
			Types.DailyScheduleData dailyScheduleData = default(Types.DailyScheduleData);
			bool flag2 = default(bool);
			int num6 = default(int);
			int num8 = default(int);
			int num10 = default(int);
			while (true)
			{
				int num = 0;
				if (IsSleepDisabled(in playerProfile, in worldProfile, context))
				{
					int num2 = 0;
				}
				RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
				int index = (int)dayOfWeek;
				RepeatedField<Types.DailyScheduleData.Types.Data> schedule_ = ((Types.DailyScheduleData)((RepeatedField<T>)(object)repeatedField)[index]).schedule_;
				if (flag)
				{
					while ((long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile) <= (long)num3)
					{
					}
					num++;
				}
				num++;
				int num4 = 0;
				if (num != 0)
				{
					break;
				}
				if (num != 0)
				{
				}
				int num5 = (int)dayOfWeek2;
				RepeatedField<Types.DailyScheduleData.Types.Data> schedule_2 = dailyScheduleData.schedule_;
				if (flag2)
				{
					int num7 = num6;
					int num9 = num8;
					num10++;
				}
				num10++;
				if (num == 0)
				{
					while (num10 == 0)
					{
					}
					int num11 = num10 - 1;
					throw new NullReferenceException();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A1")]
		[Cpp2IlInjected.Address(RVA = "0x289A970", Offset = "0x2899370", VA = "0x18289A970")]
		[IteratorStateMachine(typeof(_003CGetGiftEffectOnPreferredItems_003Ed__184))]
		public IEnumerable<PreferredItemStatus> GetGiftEffectOnPreferredItems(Item item, IEnumerable<Item> preferredItems)
		{
			//IL_001d: Expected O, but got I4
			int itemID = item.ItemID;
			_003CGetGiftEffectOnPreferredItems_003Ed__184 _003CGetGiftEffectOnPreferredItems_003Ed__ = new _003CGetGiftEffectOnPreferredItems_003Ed__184(-2);
			_003CGetGiftEffectOnPreferredItems_003Ed__._003C_003E3__preferredItems = preferredItems;
			_003CGetGiftEffectOnPreferredItems_003Ed__._003C_003E3__item = (Item)itemID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A2")]
		[Cpp2IlInjected.Address(RVA = "0x289B370", Offset = "0x2899D70", VA = "0x18289B370")]
		public static PreferredItemCategory GetPreferredItemCategory(Item item)
		{
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.ActivityItem)
			{
				ActivityItemType activityItemType = default(ActivityItemType);
				if (activityItemType > ActivityItemType.Ingredient)
				{
					if (activityItemType == ActivityItemType.Mineral)
					{
					}
					if (activityItemType != ActivityItemType.CraftingMaterial)
					{
						goto IL_0069;
					}
				}
				int num = (int)activityItemType;
				if (activityItemType != 0 && activityItemType != 0)
				{
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (activityItemType != 0)
					{
						if (num == 1 || num == 0 || (num != 0 && (num == 0 || num == 1)))
						{
							MealItemData mealItemData = default(MealItemData);
							Item mealTypeItem = mealItemData.MealTypeItem;
							MealTypeTagItemData mealTypeTagItemData = default(MealTypeTagItemData);
							return mealTypeTagItemData.preferredItemCategory_;
						}
					}
					else if (!flag && !flag2)
					{
						CropItemData cropItemData = default(CropItemData);
						if (cropItemData.cropType_ == CropType.Fruit)
						{
						}
						uint num2 = default(uint);
						if (num2 != 1)
						{
						}
					}
				}
			}
			goto IL_0069;
			IL_0069:
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A3")]
		[Cpp2IlInjected.Address(RVA = "0x289B2C0", Offset = "0x2899CC0", VA = "0x18289B2C0")]
		public static string GetPreferredItemCategoryAsString(Item item)
		{
			//Discarded unreachable code: IL_000e
			//IL_000d: Expected O, but got I4
			int itemID = item.ItemID;
			PreferredItemCategory preferredItemCategory = default(PreferredItemCategory);
			return ((Enum)preferredItemCategory).ToString();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A4")]
		[Cpp2IlInjected.Address(RVA = "0x28985F0", Offset = "0x2896FF0", VA = "0x1828985F0")]
		public bool DEBUG_IsAquatic()
		{
			//Discarded unreachable code: IL_0014
			List<Item> list = (List<Item>)(object)new List<T>();
			long num = Convert.ToInt64(10000053u);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025A5")]
		[Cpp2IlInjected.Address(RVA = "0x2898740", Offset = "0x2897140", VA = "0x182898740")]
		public static bool DEBUG_IsAquatic(Item npcItem)
		{
			//Discarded unreachable code: IL_0014
			List<Item> list = (List<Item>)(object)new List<T>();
			long num = Convert.ToInt64(10000053u);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025A6")]
		[Cpp2IlInjected.Address(RVA = "0x2898860", Offset = "0x2897260", VA = "0x182898860", Slot = "29")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_03ed, IL_03f3, IL_03f9, IL_03ff, IL_0405
			//IL_00e3: Expected O, but got I4
			//IL_01f8: Expected O, but got I4
			//IL_0238: Expected O, but got I4
			//IL_025c: Expected O, but got I4
			//IL_02e7: Expected O, but got I4
			//IL_033e: Expected O, but got I4
			//IL_03c8: Expected O, but got I4
			TagItemType tagItemType = default(TagItemType);
			IEnumerable<> cpp2il__autoParamName__idx_2 = default(IEnumerable<>);
			bool result2 = default(bool);
			MissionItemData missionItemData = default(MissionItemData);
			Func<SubLootTable, IEnumerable<ItemWithState>> func = default(Func<SubLootTable, IEnumerable<ItemWithState>>);
			Func<ItemWithState, bool> func2 = default(Func<ItemWithState, bool>);
			Func<ItemWithState, Item> func3 = default(Func<ItemWithState, Item>);
			List<Item> list = default(List<Item>);
			bool flag = default(bool);
			uint num5 = default(uint);
			uint num6 = default(uint);
			bool flag2 = default(bool);
			DayOfWeek dayOfWeek = default(DayOfWeek);
			bool flag3 = default(bool);
			IEnumerable<int> enumerable3 = default(IEnumerable<int>);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			bool flag4 = default(bool);
			int num11 = default(int);
			Func<Item, bool> func5 = default(Func<Item, bool>);
			bool flag6 = default(bool);
			ClothingItemType clothingItemType = default(ClothingItemType);
			int num15 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				context.AddInvalidMemberError("Cannot be None", "House");
				int refValue = 0;
				int value = dreamDustOverrideValue_;
				context.RequireGreaterOrEqual(value, refValue, "DreamDustOverrideValue");
				IEnumerable<Item> itemTags = (IEnumerable<Item>)ItemDataExtensions.GetItemTags((IHasTags)this);
				Func<Item, bool> _003C_003E9__189_ = _003C_003Ec._003C_003E9__189_0;
				if (_003C_003E9__189_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => tagItemType == TagItemType.Universe);
				}
				if (Enumerable.Count<Item>((IEnumerable<>)itemTags, (Func<, >)(object)_003C_003E9__189_) != 1 || !IsValidCharacterItemName())
				{
					context.AddError("Character required one and only universe tag");
				}
				if ((IntPtr)usedTagTypes == (IntPtr)num)
				{
					if (unlockCondition_ == CharacterUnlockCondition.StoryReward)
					{
						Func<MissionItemData, bool> cpp2il__autoParamName__idx_ = (Func<MissionItemData, bool>)(object)(Func<T, TResult>)delegate(MissionItemData x)
						{
							int ownerCharacter = x.OwnerCharacter;
							int num20 = iD_;
							throw new NullReferenceException();
						};
						if (cpp2il__autoParamName__idx_2.Any<MissionItemData>((Func<, >)(object)cpp2il__autoParamName__idx_))
						{
							Func<MissionItemData, bool> cpp2il__autoParamName__idx_3 = (Func<MissionItemData, bool>)(object)(Func<T, TResult>)((MissionItemData x) => result2);
							if (!cpp2il__autoParamName__idx_2.Any<MissionItemData>((Func<, >)(object)cpp2il__autoParamName__idx_3))
							{
								string arg = name_;
								CharacterUnlockCondition characterUnlockCondition = unlockCondition_;
								string message = string.Format("{0} is never unlocked ({1}), use 'UnlockCharacter' step in one mission or change {2}", arg, characterUnlockCondition, "UnlockCondition");
								context.AddInvalidMemberError(message, "UnlockCondition");
							}
						}
					}
					if (((RepeatedField<T>)(object)signatureItems_).Count != 0)
					{
						int count = ((RepeatedField<T>)(object)signatureItems_).Count;
						int num4 = iD_;
						if (missionItemData != null)
						{
							LootTable additionnalRewards_ = missionItemData.additionnalRewards_;
							if (additionnalRewards_ != null)
							{
								RepeatedField<SubLootTable> subLootTables_ = additionnalRewards_.subLootTables_;
								if (subLootTables_ != null)
								{
									if (_003C_003Ec._003C_003E9__189_7 == null)
									{
										func = (Func<SubLootTable, IEnumerable<ItemWithState>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(SubLootTable x)
										{
											RepeatedField<ItemWithState> items_ = x.items_;
											throw new NullReferenceException();
										});
									}
									IEnumerable<SubLootTable> enumerable = (IEnumerable<SubLootTable>)Enumerable.SelectMany<SubLootTable, ItemWithState>((IEnumerable<>)(object)subLootTables_, (Func<, >)(object)func);
									if (_003C_003Ec._003C_003E9__189_8 == null)
									{
										func2 = (Func<ItemWithState, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemWithState x)
										{
											if (x == null)
											{
												int num19 = 0;
											}
											Item item2 = x.Item;
											bool result = default(bool);
											return result;
										});
									}
									IEnumerable<ItemWithState> enumerable2 = (IEnumerable<ItemWithState>)Enumerable.Where<ItemWithState>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
									if (_003C_003Ec._003C_003E9__189_9 == null)
									{
										func3 = (Func<ItemWithState, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemWithState x) => x.Item));
									}
									if (Enumerable.ToList<Item>(Enumerable.Select<ItemWithState, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func3)) != null)
									{
										goto IL_01da;
									}
								}
							}
							list = (List<Item>)(object)new List<T>();
							goto IL_01da;
						}
						goto IL_0247;
					}
					goto IL_02e9;
				}
				goto IL_02f9;
				IL_02f9:
				List<string> list2 = (List<string>)(object)new List<T>();
				RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
				if (flag)
				{
					num5++;
					bool[] array = Enumerable.Repeat<bool>(false, (int)num6).ToArray<bool>();
					if (flag2)
					{
						if ((long)"{il2cpp array field local106->}" == 0)
						{
						}
						string item = $"{dayOfWeek}";
						((List<T>)(object)list2).Add((T)item);
					}
					if (num5 != 0)
					{
						break;
					}
				}
				if (num5 != 0)
				{
					continue;
				}
				if (Enumerable.Any<string>((IEnumerable<>)list2))
				{
					string text = string.Join(", ", (IEnumerable<>)list2);
					string text2 = "There is overlap in the schedule: " + text;
				}
				if (_003C_003Ec._003C_003E9__189_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((OverrideScheduleData x) => x.schedule_ == ScheduleType.Any);
				}
				if (flag3)
				{
				}
				int num7 = Enumerable.Count<int>((IEnumerable<>)enumerable3);
				if (num8 != num7)
				{
				}
				if (num9 != 3)
				{
					string text3 = string.Format("{0} must contain {1} difficulties", "PreferredItemDifficulties", num10);
				}
				if (_003C_003Ec._003C_003E9__189_3 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((PreferredItemDifficulty x) => x == PreferredItemDifficulty.None);
				}
				if (!flag4)
				{
				}
				return;
				IL_0247:
				RepeatedField<int> repeatedField2 = signatureItems_;
				Func<int, Item> func4 = (Func<int, Item>)(object)new Func<T, TResult>(num11, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, Item>*/)(&Item.New));
				num11 = 0;
				IEnumerable<int> enumerable4 = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func4);
				if (_003C_003Ec._003C_003E9__189_6 == null)
				{
					func5 = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => (!flag6) ? flag6 : (clothingItemType == ClothingItemType.CloFullbody)));
				}
				int num12 = Enumerable.Count<Item>((IEnumerable<>)enumerable4, (Func<, >)(object)func5);
				int num13 = iD_;
				if ((num12 != 0 || iD_ != 0 || iD_ != 0 || iD_ != 0 || iD_ != 0 || num12 == 1) && num12 != 1)
				{
					int num14 = iD_;
					string text4 = $"Please ask a programmer to do a ProfileUpdate to give the new Signature Item if last village mission is completed for {num14}";
					goto IL_02e9;
				}
				goto IL_02f9;
				IL_02e9:
				context.AddInvalidMemberError("Must contain 1 or 2 items", "SignatureItems");
				goto IL_02f9;
				IL_01da:
				List<Item> lastMissionRewards = list;
				RepeatedField<int> repeatedField3 = signatureItems_;
				Func<int, Item> func6 = (Func<int, Item>)(object)new Func<T, TResult>(num15, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, Item>*/)(&Item.New));
				num15 = 0;
				IEnumerable<int> cpp2il__autoParamName__idx_4 = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField3, (Func<, >)(object)func6);
				Func<Item, bool> cpp2il__autoParamName__idx_5 = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_000c
					List<Item> list3 = lastMissionRewards;
					bool flag5 = default(bool);
					return !flag5;
				};
				if (((IEnumerable<>)cpp2il__autoParamName__idx_4).Any<Item>((Func<, >)(object)cpp2il__autoParamName__idx_5))
				{
					int iD = missionItemData.ID;
					string message2 = $"Signature is missing from AdditionnalRewards of {iD}\nWrong mission?? Be sure the true last mission is 'Village' and have the highest Friendship requirement";
					context.AddInvalidMemberError(message2, "SignatureItems");
				}
				goto IL_0247;
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60025AA")]
			[Cpp2IlInjected.Address(RVA = "0x289D5F0", Offset = "0x289BFF0", VA = "0x18289D5F0")]
			unsafe bool IsValidCharacterItemName()
			{
				//IL_0036: Expected O, but got I4
				string text5 = name_;
				char[] array2 = new char[1];
				array2[0] = '!';
				string[] array3 = text5.Split(array2);
				if (Enumerable.Count<string>((IEnumerable<>)(object)array3) == 2)
				{
					int num16 = default(int);
					Func<string, bool> cpp2il__autoParamName__idx_6 = (Func<string, bool>)(object)new Func<T, TResult>(num16, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<string, bool>*/)(&string.IsNullOrEmpty));
					num16 = 0;
					if (!((IEnumerable<>)(object)array3).Any<string>((Func<, >)(object)cpp2il__autoParamName__idx_6))
					{
						ITagData universeITagData = GetUniverseITagData();
						int num17 = 0;
						if (universeITagData != null)
						{
						}
						if (num17 == 0)
						{
							if (universeITagData != null)
							{
							}
							if (num17 != 0)
							{
								string text6 = array3[0];
								if (num17 != 0)
								{
									goto IL_0084;
								}
							}
							if (universeITagData != null)
							{
							}
							if (num17 == 0)
							{
								goto IL_0086;
							}
							string text7 = array3[0];
						}
						goto IL_0084;
					}
				}
				goto IL_0086;
				IL_0084:
				return true;
				IL_0086:
				int num18 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A7")]
		[Cpp2IlInjected.Address(RVA = "0x2898590", Offset = "0x2896F90", VA = "0x182898590", Slot = "20")]
		IItemData IItemData.Clone()
		{
			CharacterItemData characterItemData = new CharacterItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60025A8")]
		[Cpp2IlInjected.Address(RVA = "0x2899C60", Offset = "0x2898660", VA = "0x182899C60", Slot = "33")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//Discarded unreachable code: IL_0051, IL_0057, IL_005d
			int num = 0;
			canHangoutWithPlayer_ = true;
			if (Enum.GetValues(typeof(DayOfWeek)).GetEnumerator() != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
				Types.DailyScheduleData dailyScheduleData = new Types.DailyScheduleData();
				((RepeatedField<T>)(object)repeatedField).Add((T)dailyScheduleData);
				dailyScheduleData = (Types.DailyScheduleData)(object)((object)dailyScheduleData + (object)dailyScheduleData);
			}
			num++;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A9")]
		[Cpp2IlInjected.Address(RVA = "0x289DF20", Offset = "0x289C920", VA = "0x18289DF20")]
		static CharacterItemData()
		{
			//Discarded unreachable code: IL_00e7
			//IL_00df: Expected O, but got I4
			_parser = (MessageParser<CharacterItemData>)(object)FieldCodec.ForInt32(58u);
			MessageParser<Types.DailyScheduleData> parser = Types.DailyScheduleData._parser;
			uint num = default(uint);
			_parser = (MessageParser<CharacterItemData>)(object)FieldCodec.ForMessage<Types.DailyScheduleData>(num, (MessageParser<>)(object)parser);
			Func<ScheduleType, int> func = (Func<ScheduleType, int>)(object)(Func<T, TResult>)((ScheduleType x) => (int)x);
			Func<int, ScheduleType> func2 = (Func<int, ScheduleType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num2 = default(uint);
			_parser = (MessageParser<CharacterItemData>)(object)FieldCodec.ForEnum<ScheduleType>(num2, (Func<, >)(object)func, (Func<, >)(object)func2);
			MessageParser<OverrideScheduleData> parser2 = OverrideScheduleData._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<CharacterItemData>)(object)FieldCodec.ForMessage<OverrideScheduleData>(num3, (MessageParser<>)(object)parser2);
			Func<PreferredItemDifficulty, int> func3 = (Func<PreferredItemDifficulty, int>)(object)(Func<T, TResult>)((PreferredItemDifficulty x) => (int)x);
			Func<int, PreferredItemDifficulty> func4 = (Func<int, PreferredItemDifficulty>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num4 = default(uint);
			_parser = (MessageParser<CharacterItemData>)(object)FieldCodec.ForEnum<PreferredItemDifficulty>(num4, (Func<, >)(object)func3, (Func<, >)(object)func4);
			uint num5 = default(uint);
			_parser = (MessageParser<CharacterItemData>)(object)FieldCodec.ForInt32(num5);
			uint num6 = default(uint);
			_parser = (MessageParser<CharacterItemData>)(object)FieldCodec.ForInt32(num6);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num7 = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num7;
			ReadOnlyCollection<(TagItemType, int?)> parser3 = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<CharacterItemData>)(object)parser3;
		}
	}
}
