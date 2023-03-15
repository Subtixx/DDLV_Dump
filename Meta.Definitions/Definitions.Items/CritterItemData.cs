using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003D4")]
	public sealed class CritterItemData : IMessage<CritterItemData>, IMessage, IEquatable<CritterItemData>, IDeepCloneable<CritterItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IProtobufDefaultData, IItemGeneratorOwner, ICustomStepOwner, IItemSelector, ICollectionItem, IOnlineAvailability, IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x20003D5")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003D6")]
			public sealed class DailyScheduleData : IMessage<DailyScheduleData>, IMessage, IEquatable<DailyScheduleData>, IDeepCloneable<DailyScheduleData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20003D7")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x20003D8")]
					public sealed class Data : IMessage<Data>, IMessage, IEquatable<Data>, IDeepCloneable<Data>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001477")]
						private static readonly MessageParser<Data> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001478")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001479")]
						public const int StartFieldNumber = 1;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x400147A")]
						private int start_;

						[Cpp2IlInjected.Token(Token = "0x400147B")]
						public const int EndFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
						[Cpp2IlInjected.Token(Token = "0x400147C")]
						private int end_;

						[Cpp2IlInjected.Token(Token = "0x17000BB2")]
						[DebuggerNonUserCode]
						public static MessageParser<Data> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x6002E41")]
							[Cpp2IlInjected.Address(RVA = "0x236BFF0", Offset = "0x236A9F0", VA = "0x18236BFF0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000BB3")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002E42")]
							[Cpp2IlInjected.Address(RVA = "0x236BE90", Offset = "0x236A890", VA = "0x18236BE90")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000BB4")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002E43")]
							[Cpp2IlInjected.Address(RVA = "0x236C110", Offset = "0x236AB10", VA = "0x18236C110", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000BB5")]
						[DebuggerNonUserCode]
						public int Start
						{
							[Cpp2IlInjected.Token(Token = "0x6002E47")]
							[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
							get
							{
								return default(int);
							}
							[Cpp2IlInjected.Token(Token = "0x6002E48")]
							[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000BB6")]
						[DebuggerNonUserCode]
						public int End
						{
							[Cpp2IlInjected.Token(Token = "0x6002E49")]
							[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
							get
							{
								return default(int);
							}
							[Cpp2IlInjected.Token(Token = "0x6002E4A")]
							[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6002E44")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public Data()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002E45")]
						[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
						[DebuggerNonUserCode]
						public Data(Data other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002E46")]
						[Cpp2IlInjected.Address(RVA = "0x236B670", Offset = "0x236A070", VA = "0x18236B670", Slot = "10")]
						[DebuggerNonUserCode]
						public Data Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002E4B")]
						[Cpp2IlInjected.Address(RVA = "0x236B700", Offset = "0x236A100", VA = "0x18236B700", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6002E4C")]
						[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(Data other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6002E4D")]
						[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002E4E")]
						[Cpp2IlInjected.Address(RVA = "0x236BC10", Offset = "0x236A610", VA = "0x18236BC10", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002E4F")]
						[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002E50")]
						[Cpp2IlInjected.Address(RVA = "0x236B410", Offset = "0x2369E10", VA = "0x18236B410", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002E51")]
						[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(Data other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002E52")]
						[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002E53")]
						[Cpp2IlInjected.Address(RVA = "0x236B830", Offset = "0x236A230", VA = "0x18236B830", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002E54")]
						[Cpp2IlInjected.Address(RVA = "0x236BAF0", Offset = "0x236A4F0", VA = "0x18236BAF0", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002E55")]
						[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4001472")]
				private static readonly MessageParser<DailyScheduleData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001473")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001474")]
				public const int ScheduleFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4001475")]
				private static readonly FieldCodec<Types.Data> _repeated_schedule_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001476")]
				private readonly RepeatedField<Types.Data> schedule_;

				[Cpp2IlInjected.Token(Token = "0x17000BAE")]
				[DebuggerNonUserCode]
				public static MessageParser<DailyScheduleData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002E2E")]
					[Cpp2IlInjected.Address(RVA = "0x293BD80", Offset = "0x293A780", VA = "0x18293BD80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000BAF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E2F")]
					[Cpp2IlInjected.Address(RVA = "0x293BD00", Offset = "0x293A700", VA = "0x18293BD00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000BB0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E30")]
					[Cpp2IlInjected.Address(RVA = "0x293BDE0", Offset = "0x293A7E0", VA = "0x18293BDE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000BB1")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.Data> Schedule
				{
					[Cpp2IlInjected.Token(Token = "0x6002E34")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002E31")]
				[Cpp2IlInjected.Address(RVA = "0x293BC80", Offset = "0x293A680", VA = "0x18293BC80")]
				[DebuggerNonUserCode]
				public DailyScheduleData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E32")]
				[Cpp2IlInjected.Address(RVA = "0x293BB80", Offset = "0x293A580", VA = "0x18293BB80")]
				[DebuggerNonUserCode]
				public DailyScheduleData(DailyScheduleData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E33")]
				[Cpp2IlInjected.Address(RVA = "0x293B3A0", Offset = "0x2939DA0", VA = "0x18293B3A0", Slot = "10")]
				[DebuggerNonUserCode]
				public DailyScheduleData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E35")]
				[Cpp2IlInjected.Address(RVA = "0x293B560", Offset = "0x2939F60", VA = "0x18293B560", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E36")]
				[Cpp2IlInjected.Address(RVA = "0x293B4D0", Offset = "0x2939ED0", VA = "0x18293B4D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(DailyScheduleData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E37")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E38")]
				[Cpp2IlInjected.Address(RVA = "0x293B890", Offset = "0x293A290", VA = "0x18293B890", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E39")]
				[Cpp2IlInjected.Address(RVA = "0x293B8F0", Offset = "0x293A2F0", VA = "0x18293B8F0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E3A")]
				[Cpp2IlInjected.Address(RVA = "0x293B290", Offset = "0x2939C90", VA = "0x18293B290", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E3B")]
				[Cpp2IlInjected.Address(RVA = "0x293B7B0", Offset = "0x293A1B0", VA = "0x18293B7B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(DailyScheduleData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E3C")]
				[Cpp2IlInjected.Address(RVA = "0x293B6C0", Offset = "0x293A0C0", VA = "0x18293B6C0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E3D")]
				[Cpp2IlInjected.Address(RVA = "0x293B640", Offset = "0x293A040", VA = "0x18293B640", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E3E")]
				[Cpp2IlInjected.Address(RVA = "0x293B830", Offset = "0x293A230", VA = "0x18293B830", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E3F")]
				[Cpp2IlInjected.Address(RVA = "0x293B340", Offset = "0x2939D40", VA = "0x18293B340", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001449")]
		private static readonly MessageParser<CritterItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400144A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400144B")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400144C")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x400144D")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400144E")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400144F")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001450")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001451")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001452")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001453")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001454")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001455")]
		public const int LocationFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001456")]
		private VillageAreaType location_;

		[Cpp2IlInjected.Token(Token = "0x4001457")]
		public const int DailyScheduleFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001458")]
		private static readonly FieldCodec<Types.DailyScheduleData> _repeated_dailySchedule_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001459")]
		private readonly RepeatedField<Types.DailyScheduleData> dailySchedule_ = (RepeatedField<Types.DailyScheduleData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400145A")]
		public const int ItemTypeWantedFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400145B")]
		private ActivityItemType itemTypeWanted_;

		[Cpp2IlInjected.Token(Token = "0x400145C")]
		public const int LikeItemFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400145D")]
		private ItemSelector likeItem_;

		[Cpp2IlInjected.Token(Token = "0x400145E")]
		public const int FavoriteItemFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400145F")]
		private ItemSelector favoriteItem_;

		[Cpp2IlInjected.Token(Token = "0x4001460")]
		public const int FavoriteItemDescriptionFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001461")]
		private string favoriteItemDescription_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001462")]
		public const int NumberOfFeedingBeforeRewardsFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001463")]
		private int numberOfFeedingBeforeRewards_;

		[Cpp2IlInjected.Token(Token = "0x4001464")]
		public const int NumberOfFeedingBeforeUnlockFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001465")]
		private int numberOfFeedingBeforeUnlock_;

		[Cpp2IlInjected.Token(Token = "0x4001466")]
		public const int LikeRewardLootTableItemIDFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001467")]
		private int likeRewardLootTableItemID_;

		[Cpp2IlInjected.Token(Token = "0x4001468")]
		public const int FavoriteRewardLootTableItemIDFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001469")]
		private int favoriteRewardLootTableItemID_;

		[Cpp2IlInjected.Token(Token = "0x400146A")]
		public const int BefriendingPetRewardItemIDFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400146B")]
		private int befriendingPetRewardItemID_;

		[Cpp2IlInjected.Token(Token = "0x400146C")]
		public const int IsUnavailableForGeneratorFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400146D")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x400146E")]
		public const int IsSyncOnlineItemFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
		[Cpp2IlInjected.Token(Token = "0x400146F")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4001470")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001471")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x17000B92")]
		[DebuggerNonUserCode]
		public static MessageParser<CritterItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002DE9")]
			[Cpp2IlInjected.Address(RVA = "0x328CCC0", Offset = "0x328B6C0", VA = "0x18328CCC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B93")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002DEA")]
			[Cpp2IlInjected.Address(RVA = "0x328CB30", Offset = "0x328B530", VA = "0x18328CB30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B94")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002DEB")]
			[Cpp2IlInjected.Address(RVA = "0x328CD20", Offset = "0x328B720", VA = "0x18328CD20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B95")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002DF0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DF1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B96")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002DF2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DF3")]
			[Cpp2IlInjected.Address(RVA = "0x328CF90", Offset = "0x328B990", VA = "0x18328CF90")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B97")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002DF4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DF5")]
			[Cpp2IlInjected.Address(RVA = "0x328CE30", Offset = "0x328B830", VA = "0x18328CE30")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B98")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002DF6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DF7")]
			[Cpp2IlInjected.Address(RVA = "0x328CF10", Offset = "0x328B910", VA = "0x18328CF10")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B99")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002DF8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DF9")]
			[Cpp2IlInjected.Address(RVA = "0x328D000", Offset = "0x328BA00", VA = "0x18328D000")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B9A")]
		[DebuggerNonUserCode]
		public VillageAreaType Location
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFA")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DFB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B9B")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.DailyScheduleData> DailySchedule
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFC")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return dailySchedule_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B9C")]
		[DebuggerNonUserCode]
		public ActivityItemType ItemTypeWanted
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFD")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return itemTypeWanted_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DFE")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				itemTypeWanted_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B9D")]
		[DebuggerNonUserCode]
		public ItemSelector LikeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFF")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return likeItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E00")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				likeItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B9E")]
		[DebuggerNonUserCode]
		public ItemSelector FavoriteItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002E01")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return favoriteItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E02")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				favoriteItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B9F")]
		[DebuggerNonUserCode]
		public string FavoriteItemDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6002E03")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return favoriteItemDescription_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E04")]
			[Cpp2IlInjected.Address(RVA = "0x328CEA0", Offset = "0x328B8A0", VA = "0x18328CEA0")]
			set
			{
				string text = (favoriteItemDescription_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA0")]
		[DebuggerNonUserCode]
		public int NumberOfFeedingBeforeRewards
		{
			[Cpp2IlInjected.Token(Token = "0x6002E05")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050")]
			get
			{
				return numberOfFeedingBeforeRewards_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E06")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				numberOfFeedingBeforeRewards_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA1")]
		[DebuggerNonUserCode]
		public int NumberOfFeedingBeforeUnlock
		{
			[Cpp2IlInjected.Token(Token = "0x6002E07")]
			[Cpp2IlInjected.Address(RVA = "0xDD7040", Offset = "0xDD5A40", VA = "0x180DD7040")]
			get
			{
				return numberOfFeedingBeforeUnlock_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E08")]
			[Cpp2IlInjected.Address(RVA = "0xDD7100", Offset = "0xDD5B00", VA = "0x180DD7100")]
			set
			{
				numberOfFeedingBeforeUnlock_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA2")]
		[DebuggerNonUserCode]
		public int LikeRewardLootTableItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002E09")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return likeRewardLootTableItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E0A")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				likeRewardLootTableItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA3")]
		[DebuggerNonUserCode]
		public int FavoriteRewardLootTableItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0B")]
			[Cpp2IlInjected.Address(RVA = "0xAE8600", Offset = "0xAE7000", VA = "0x180AE8600")]
			get
			{
				return favoriteRewardLootTableItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E0C")]
			[Cpp2IlInjected.Address(RVA = "0x1525600", Offset = "0x1524000", VA = "0x181525600")]
			set
			{
				favoriteRewardLootTableItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA4")]
		[DebuggerNonUserCode]
		public int BefriendingPetRewardItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0D")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get
			{
				return befriendingPetRewardItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E0E")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0")]
			set
			{
				befriendingPetRewardItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA5")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6002E0F")]
			[Cpp2IlInjected.Address(RVA = "0x20E3CD0", Offset = "0x20E26D0", VA = "0x1820E3CD0", Slot = "30")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E10")]
			[Cpp2IlInjected.Address(RVA = "0x328CF80", Offset = "0x328B980", VA = "0x18328CF80", Slot = "31")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA6")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002E11")]
			[Cpp2IlInjected.Address(RVA = "0x261F050", Offset = "0x261DA50", VA = "0x18261F050", Slot = "28")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E12")]
			[Cpp2IlInjected.Address(RVA = "0x2481010", Offset = "0x247FA10", VA = "0x182481010", Slot = "29")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA7")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002E13")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E14")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA8")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002E20")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "26")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA9")]
		public Item FavoriteRewardLootTableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002E21")]
			[Cpp2IlInjected.Address(RVA = "0x328CC00", Offset = "0x328B600", VA = "0x18328CC00")]
			get
			{
				long num = Convert.ToInt64((uint)favoriteRewardLootTableItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E22")]
			[Cpp2IlInjected.Address(RVA = "0x1525600", Offset = "0x1524000", VA = "0x181525600")]
			set
			{
				//IL_0007: Expected I4, but got O
				favoriteRewardLootTableItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BAA")]
		public Item LikeRewardLootTableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002E23")]
			[Cpp2IlInjected.Address(RVA = "0x328CC60", Offset = "0x328B660", VA = "0x18328CC60")]
			get
			{
				long num = Convert.ToInt64((uint)likeRewardLootTableItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E24")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				//IL_0007: Expected I4, but got O
				likeRewardLootTableItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BAB")]
		public Item BefriendingPetRewardItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002E25")]
			[Cpp2IlInjected.Address(RVA = "0x328CAD0", Offset = "0x328B4D0", VA = "0x18328CAD0")]
			get
			{
				long num = Convert.ToInt64((uint)befriendingPetRewardItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E26")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0")]
			set
			{
				//IL_0007: Expected I4, but got O
				befriendingPetRewardItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BAC")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6002E27")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "25")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BAD")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6002E28")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "27")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEC")]
		[Cpp2IlInjected.Address(RVA = "0x328C980", Offset = "0x328B380", VA = "0x18328C980")]
		[DebuggerNonUserCode]
		public CritterItemData()
		{
			ItemSelector itemSelector = (likeItem_ = new ItemSelector());
			ItemSelector itemSelector2 = (favoriteItem_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DED")]
		[Cpp2IlInjected.Address(RVA = "0x328B9A0", Offset = "0x328A3A0", VA = "0x18328B9A0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (likeItem_ = new ItemSelector());
			ItemSelector itemSelector2 = (favoriteItem_ = new ItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEE")]
		[Cpp2IlInjected.Address(RVA = "0x328C690", Offset = "0x328B090", VA = "0x18328C690")]
		[DebuggerNonUserCode]
		public CritterItemData(CritterItemData other)
		{
			//IL_0108: Expected O, but got I4
			ItemSelector itemSelector = (likeItem_ = new ItemSelector());
			ItemSelector itemSelector2 = (favoriteItem_ = new ItemSelector());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			VillageAreaType villageAreaType = (location_ = other.location_);
			RepeatedField<Types.DailyScheduleData> repeatedField = (dailySchedule_ = (RepeatedField<Types.DailyScheduleData>)(object)((RepeatedField<T>)(object)other.dailySchedule_).Clone());
			ActivityItemType activityItemType = other.itemTypeWanted_;
			int num2 = 0;
			itemTypeWanted_ = activityItemType;
			ItemSelector itemSelector3 = other.likeItem_;
			if (itemSelector3 != null)
			{
				ItemSelector itemSelector4 = itemSelector3.Clone();
			}
			likeItem_ = (ItemSelector)num2;
			ItemSelector itemSelector5 = other.favoriteItem_;
			ItemSelector itemSelector6 = default(ItemSelector);
			if (itemSelector5 != null)
			{
				itemSelector6 = itemSelector5.Clone();
			}
			favoriteItem_ = itemSelector6;
			string text5 = (favoriteItemDescription_ = other.favoriteItemDescription_);
			int num3 = (numberOfFeedingBeforeRewards_ = other.numberOfFeedingBeforeRewards_);
			int num4 = (numberOfFeedingBeforeUnlock_ = other.numberOfFeedingBeforeUnlock_);
			int num5 = (likeRewardLootTableItemID_ = other.likeRewardLootTableItemID_);
			int num6 = (favoriteRewardLootTableItemID_ = other.favoriteRewardLootTableItemID_);
			int num7 = (befriendingPetRewardItemID_ = other.befriendingPetRewardItemID_);
			bool flag = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag2 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			uint num8 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEF")]
		[Cpp2IlInjected.Address(RVA = "0x328A640", Offset = "0x3289040", VA = "0x18328A640", Slot = "10")]
		[DebuggerNonUserCode]
		public CritterItemData Clone()
		{
			return new CritterItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E15")]
		[Cpp2IlInjected.Address(RVA = "0x328ABB0", Offset = "0x32895B0", VA = "0x18328ABB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CritterItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E16")]
		[Cpp2IlInjected.Address(RVA = "0x328A9E0", Offset = "0x32893E0", VA = "0x18328A9E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CritterItemData other)
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
									VillageAreaType villageAreaType = other.location_;
									if (location_ == villageAreaType)
									{
										RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
										RepeatedField<Types.DailyScheduleData> repeatedField2 = other.dailySchedule_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											ActivityItemType activityItemType = other.itemTypeWanted_;
											if (itemTypeWanted_ == activityItemType)
											{
												ItemSelector objB = other.likeItem_;
												if (object.Equals(likeItem_, objB))
												{
													ItemSelector objB2 = other.favoriteItem_;
													if (object.Equals(favoriteItem_, objB2))
													{
														string text5 = other.favoriteItemDescription_;
														if (!(favoriteItemDescription_ != text5))
														{
															int num2 = other.numberOfFeedingBeforeRewards_;
															if (numberOfFeedingBeforeRewards_ == num2)
															{
																int num3 = other.numberOfFeedingBeforeUnlock_;
																if (numberOfFeedingBeforeUnlock_ == num3)
																{
																	int num4 = other.likeRewardLootTableItemID_;
																	if (likeRewardLootTableItemID_ == num4)
																	{
																		int num5 = other.favoriteRewardLootTableItemID_;
																		if (favoriteRewardLootTableItemID_ == num5)
																		{
																			int num6 = other.befriendingPetRewardItemID_;
																			if (befriendingPetRewardItemID_ == num6)
																			{
																				bool flag = other.isUnavailableForGenerator_;
																				if (isUnavailableForGenerator_ == flag)
																				{
																					bool flag2 = other.isSyncOnlineItem_;
																					if (isSyncOnlineItem_ == flag2)
																					{
																						uint num7 = other.glotID_;
																						if (glotID_ == num7)
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
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E17")]
		[Cpp2IlInjected.Address(RVA = "0x328AEB0", Offset = "0x32898B0", VA = "0x18328AEB0", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_0173
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
			if (location_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text4)->ResultCode;
			}
			int hashCode5 = ((RepeatedField<T>)(object)dailySchedule_).GetHashCode();
			if (itemTypeWanted_ != 0)
			{
			}
			ItemSelector itemSelector = likeItem_;
			if (itemSelector != null)
			{
				int hashCode6 = itemSelector.GetHashCode();
			}
			ItemSelector itemSelector2 = favoriteItem_;
			if (itemSelector2 != null)
			{
				int hashCode7 = itemSelector2.GetHashCode();
			}
			string text5 = favoriteItemDescription_;
			if (text5.m_stringLength != 0)
			{
				int hashCode8 = text5.GetHashCode();
			}
			if (numberOfFeedingBeforeRewards_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (numberOfFeedingBeforeUnlock_ != 0)
			{
				Result resultCode3 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (likeRewardLootTableItemID_ != 0)
			{
				Result resultCode4 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (favoriteRewardLootTableItemID_ != 0)
			{
				Result resultCode5 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (befriendingPetRewardItemID_ != 0)
			{
				Result resultCode6 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (isUnavailableForGenerator_)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (glotID_ != 0)
			{
				Result resultCode7 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E18")]
		[Cpp2IlInjected.Address(RVA = "0x328C040", Offset = "0x328AA40", VA = "0x18328C040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E19")]
		[Cpp2IlInjected.Address(RVA = "0x328C0A0", Offset = "0x328AAA0", VA = "0x18328C0A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01e7
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
			if (location_ != 0)
			{
			}
			RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
			FieldCodec<Types.DailyScheduleData> repeated_dailySchedule_codec = _repeated_dailySchedule_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_dailySchedule_codec);
			if (itemTypeWanted_ != 0)
			{
			}
			if ((long)likeItem_ != 0)
			{
				ItemSelector value6 = likeItem_;
				output.WriteMessage(value6);
			}
			if ((long)favoriteItem_ != 0)
			{
				ItemSelector value7 = favoriteItem_;
				output.WriteMessage(value7);
			}
			if (favoriteItemDescription_.m_stringLength != 0)
			{
				string value8 = favoriteItemDescription_;
				output.WriteString(value8);
			}
			if (numberOfFeedingBeforeRewards_ != 0)
			{
				int value9 = numberOfFeedingBeforeRewards_;
				output.WriteInt32(value9);
			}
			if (numberOfFeedingBeforeUnlock_ != 0)
			{
				int value10 = numberOfFeedingBeforeUnlock_;
				output.WriteInt32(value10);
			}
			if (likeRewardLootTableItemID_ != 0)
			{
				int value11 = likeRewardLootTableItemID_;
				output.WriteInt32(value11);
			}
			if (favoriteRewardLootTableItemID_ != 0)
			{
				int value12 = favoriteRewardLootTableItemID_;
				output.WriteInt32(value12);
			}
			if (befriendingPetRewardItemID_ != 0)
			{
				int value13 = befriendingPetRewardItemID_;
				output.WriteInt32(value13);
			}
			if (isUnavailableForGenerator_)
			{
				bool value14 = isUnavailableForGenerator_;
				output.WriteBool(value14);
			}
			if (isSyncOnlineItem_)
			{
				bool value15 = isSyncOnlineItem_;
				output.WriteBool(value15);
			}
			if (glotID_ != 0)
			{
				uint value16 = glotID_;
				output.WriteUInt32(value16);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1A")]
		[Cpp2IlInjected.Address(RVA = "0x3289F70", Offset = "0x3288970", VA = "0x183289F70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0256
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
			VillageAreaType villageAreaType = location_;
			if (villageAreaType != 0)
			{
				int num8 = CodedOutputStream.ComputeEnumSize((int)villageAreaType);
				num8++;
				num2 += num8;
			}
			RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
			FieldCodec<Types.DailyScheduleData> repeated_dailySchedule_codec = _repeated_dailySchedule_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_dailySchedule_codec);
			ActivityItemType activityItemType = itemTypeWanted_;
			num2 += num9;
			if (activityItemType != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)activityItemType);
				num10++;
				num2 += num10;
			}
			ItemSelector itemSelector = likeItem_;
			if (itemSelector != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(itemSelector);
				num11++;
				num2 += num11;
			}
			ItemSelector itemSelector2 = favoriteItem_;
			if (itemSelector2 != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(itemSelector2);
				num12++;
				num2 += num12;
			}
			string text5 = favoriteItemDescription_;
			if (text5.m_stringLength != 0)
			{
				int num13 = CodedOutputStream.ComputeStringSize(text5);
				num13++;
				num2 += num13;
			}
			int num14 = numberOfFeedingBeforeRewards_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			int num16 = numberOfFeedingBeforeUnlock_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeInt32Size(num16);
				num17++;
				num2 += num17;
			}
			int num18 = likeRewardLootTableItemID_;
			if (num18 != 0)
			{
				int num19 = CodedOutputStream.ComputeInt32Size(num18);
				num19++;
				num2 += num19;
			}
			int num20 = favoriteRewardLootTableItemID_;
			if (num20 != 0)
			{
				int num21 = CodedOutputStream.ComputeInt32Size(num20);
				num21 += 2;
				num2 += num21;
			}
			int num22 = befriendingPetRewardItemID_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeInt32Size(num22);
				num23 += 2;
				num2 += num23;
			}
			uint num24 = glotID_;
			if (num24 != 0)
			{
				int num25 = CodedOutputStream.ComputeUInt32Size(num24);
				num25 += 2;
				num2 += num25;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num26 = unknownFields.CalculateSize();
				num2 += num26;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1B")]
		[Cpp2IlInjected.Address(RVA = "0x328B380", Offset = "0x3289D80", VA = "0x18328B380", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CritterItemData other)
		{
			//Discarded unreachable code: IL_0216
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
			VillageAreaType villageAreaType = other.location_;
			if (villageAreaType != 0)
			{
				location_ = villageAreaType;
			}
			RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
			RepeatedField<Types.DailyScheduleData> repeatedField2 = other.dailySchedule_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			ActivityItemType activityItemType = other.itemTypeWanted_;
			if (activityItemType != 0)
			{
				itemTypeWanted_ = activityItemType;
			}
			if ((long)other.likeItem_ != 0)
			{
				ItemSelector itemSelector2 = default(ItemSelector);
				if (likeItem_ == null)
				{
					ItemSelector itemSelector = (likeItem_ = new ItemSelector());
					itemSelector2 = likeItem_;
				}
				ItemSelector other2 = other.likeItem_;
				itemSelector2.MergeFrom(other2);
			}
			if ((long)other.favoriteItem_ != 0)
			{
				ItemSelector itemSelector4 = default(ItemSelector);
				if (favoriteItem_ == null)
				{
					ItemSelector itemSelector3 = (favoriteItem_ = new ItemSelector());
					itemSelector4 = favoriteItem_;
				}
				ItemSelector other3 = other.favoriteItem_;
				itemSelector4.MergeFrom(other3);
			}
			string text5 = other.favoriteItemDescription_;
			if (text5.m_stringLength != 0)
			{
				FavoriteItemDescription = text5;
			}
			int num2 = other.numberOfFeedingBeforeRewards_;
			if (num2 != 0)
			{
				numberOfFeedingBeforeRewards_ = num2;
			}
			int num3 = other.numberOfFeedingBeforeUnlock_;
			if (num3 != 0)
			{
				numberOfFeedingBeforeUnlock_ = num3;
			}
			int num4 = other.likeRewardLootTableItemID_;
			if (num4 != 0)
			{
				likeRewardLootTableItemID_ = num4;
			}
			int num5 = other.favoriteRewardLootTableItemID_;
			if (num5 != 0)
			{
				favoriteRewardLootTableItemID_ = num5;
			}
			int num6 = other.befriendingPetRewardItemID_;
			if (num6 != 0)
			{
				befriendingPetRewardItemID_ = num6;
			}
			bool flag = other.isUnavailableForGenerator_;
			if (flag)
			{
				isUnavailableForGenerator_ = flag;
			}
			bool flag2 = other.isSyncOnlineItem_;
			if (flag2)
			{
				isSyncOnlineItem_ = flag2;
			}
			uint num7 = other.glotID_;
			if (num7 != 0)
			{
				glotID_ = num7;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1C")]
		[Cpp2IlInjected.Address(RVA = "0x328B5F0", Offset = "0x3289FF0", VA = "0x18328B5F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0256
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 82)
			{
				if ((int)num > 120)
				{
					if ((int)num > 136)
					{
						if (num == 160)
						{
							bool flag = (isUnavailableForGenerator_ = input.ReadBool());
						}
						bool flag2 = default(bool);
						if (num == 168)
						{
							flag2 = (isSyncOnlineItem_ = input.ReadBool());
						}
						if (!flag2)
						{
							goto IL_023f;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 128)
					{
						num3 = (favoriteRewardLootTableItemID_ = input.ReadInt32());
					}
					if (num3 != 136)
					{
						goto IL_023f;
					}
					int num4 = (befriendingPetRewardItemID_ = input.ReadInt32());
				}
				int num7 = default(int);
				if ((int)num > 98)
				{
					int num5 = default(int);
					if (num == 104)
					{
						num5 = (numberOfFeedingBeforeRewards_ = input.ReadInt32());
					}
					int num6 = default(int);
					if (num5 == 112)
					{
						num6 = (numberOfFeedingBeforeUnlock_ = input.ReadInt32());
					}
					if (num6 != 120)
					{
						goto IL_023f;
					}
					num7 = (likeRewardLootTableItemID_ = input.ReadInt32());
				}
				ItemSelector itemSelector = default(ItemSelector);
				if (num7 == 90)
				{
					ItemSelector builder = default(ItemSelector);
					if (favoriteItem_ == null)
					{
						itemSelector = (favoriteItem_ = new ItemSelector());
						builder = favoriteItem_;
					}
					input.ReadMessage(builder);
				}
				if ((long)itemSelector != 98)
				{
					goto IL_023f;
				}
				string text2 = (FavoriteItemDescription = input.ReadString());
			}
			int num9 = default(int);
			if ((int)num > 34)
			{
				ItemSelector itemSelector2 = default(ItemSelector);
				if ((int)num > 48)
				{
					if (num == 58)
					{
						RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
						FieldCodec<Types.DailyScheduleData> repeated_dailySchedule_codec = _repeated_dailySchedule_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_dailySchedule_codec);
					}
					int num8 = default(int);
					if (num == 72)
					{
						num8 = (int)(itemTypeWanted_ = (ActivityItemType)input.ReadInt32());
					}
					if (num8 != 82)
					{
						goto IL_023f;
					}
					ItemSelector builder2 = default(ItemSelector);
					if (likeItem_ == null)
					{
						itemSelector2 = (likeItem_ = new ItemSelector());
						builder2 = likeItem_;
					}
					input.ReadMessage(builder2);
				}
				string text4 = default(string);
				if ((long)itemSelector2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 48)
				{
					goto IL_023f;
				}
				num9 = (int)(location_ = (VillageAreaType)input.ReadInt32());
			}
			string text8 = default(string);
			if (num9 > 18)
			{
				string text6 = default(string);
				if (num9 == 26)
				{
					text6 = (DisplayName = input.ReadString());
				}
				if ((long)text6 != 34)
				{
					goto IL_023f;
				}
				text8 = (IconAddress = input.ReadString());
			}
			int num10 = default(int);
			if ((long)text8 == 8)
			{
				num10 = (iD_ = input.ReadInt32());
			}
			if (num10 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_023f;
			IL_023f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002E1D")]
		[Cpp2IlInjected.Address(RVA = "0x328AC10", Offset = "0x3289610", VA = "0x18328AC10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 20)
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

		[Cpp2IlInjected.Token(Token = "0x6002E1E")]
		[Cpp2IlInjected.Address(RVA = "0x328BA30", Offset = "0x328A430", VA = "0x18328BA30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_001c, IL_001d, IL_001e, IL_001f, IL_002f, IL_0037, IL_003f, IL_0047, IL_0048, IL_0055, IL_005d, IL_0065, IL_006d, IL_0075, IL_007d, IL_0085, IL_009d, IL_00a3, IL_00a9, IL_00af, IL_00b5, IL_00bb
			//IL_0011: Expected I4, but got O
			//IL_001b: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_009c: Expected I4, but got O
			if (fieldNumber - 1 <= 20)
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

		[Cpp2IlInjected.Token(Token = "0x6002E1F")]
		[Cpp2IlInjected.Address(RVA = "0x328A3C0", Offset = "0x3288DC0", VA = "0x18328A3C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0033
			//IL_0010: Expected I4, but got I8
			//IL_0032: Expected I4, but got I8
			if (fieldNumber - 1 <= 20)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E29")]
		[Cpp2IlInjected.Address(RVA = "0x328B120", Offset = "0x3289B20", VA = "0x18328B120")]
		public bool IsPresent(IProfileWorld world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0053
			int num = 0;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			RepeatedField<Types.DailyScheduleData> repeatedField = dailySchedule_;
			DayOfWeek dayOfWeek = default(DayOfWeek);
			int index = (int)dayOfWeek;
			RepeatedField<Types.DailyScheduleData.Types.Data> schedule_ = ((Types.DailyScheduleData)((RepeatedField<T>)(object)repeatedField)[index]).schedule_;
			bool flag = default(bool);
			if (flag)
			{
				int num4 = 0;
				num2++;
				num4 += num4;
				num2 += 328;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2A")]
		[Cpp2IlInjected.Address(RVA = "0x328A640", Offset = "0x3289040", VA = "0x18328A640", Slot = "20")]
		IItemData IItemData.Clone()
		{
			CritterItemData critterItemData = new CritterItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2B")]
		[Cpp2IlInjected.Address(RVA = "0x328A730", Offset = "0x3289130", VA = "0x18328A730", Slot = "23")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c, IL_0082
			//IL_004c: Expected I4, but got I8
			int num = 0;
			Types.DailyScheduleData.Types.Data data = default(Types.DailyScheduleData.Types.Data);
			if (Enum.GetValues(typeof(DayOfWeek)).GetEnumerator() != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				Types.DailyScheduleData dailyScheduleData = new Types.DailyScheduleData();
				RepeatedField<Types.DailyScheduleData.Types.Data> schedule_ = dailyScheduleData.schedule_;
				data = new Types.DailyScheduleData.Types.Data();
				data.start_ = num;
				data.end_ = 24;
				((RepeatedField<T>)(object)schedule_).Add((T)data);
				((RepeatedField<T>)(object)dailySchedule_).Add((T)dailyScheduleData);
				dailyScheduleData = (Types.DailyScheduleData)(object)((object)dailyScheduleData + (object)dailyScheduleData);
			}
			if (data == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2C")]
		[Cpp2IlInjected.Address(RVA = "0x328A6A0", Offset = "0x32890A0", VA = "0x18328A6A0", Slot = "24")]
		(ItemType, ActivityItemType?) IItemGeneratorOwner.GetItemGeneratorParameters()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E2D")]
		[Cpp2IlInjected.Address(RVA = "0x328C4C0", Offset = "0x328AEC0", VA = "0x18328C4C0")]
		static CritterItemData()
		{
			Func<CritterItemData> func = default(Func<CritterItemData>);
			_parser = (MessageParser<CritterItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.DailyScheduleData> parser = Types.DailyScheduleData._parser;
			uint num = default(uint);
			_parser = (MessageParser<CritterItemData>)(object)FieldCodec.ForMessage<Types.DailyScheduleData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
