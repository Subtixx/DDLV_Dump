using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000394")]
	public sealed class SpawnRecurringEventAreaSpecification : IMessage<SpawnRecurringEventAreaSpecification>, IMessage, IEquatable<SpawnRecurringEventAreaSpecification>, IDeepCloneable<SpawnRecurringEventAreaSpecification>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000395")]
		public enum AreaSpecificationOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001266")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001267")]
			SpecificAreas,
			[Cpp2IlInjected.Token(Token = "0x4001268")]
			FromChooseVillageAreaEvent
		}

		[Cpp2IlInjected.Token(Token = "0x2000396")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000397")]
			public sealed class AreaList : IMessage<AreaList>, IMessage, IEquatable<AreaList>, IDeepCloneable<AreaList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001269")]
				private static readonly MessageParser<AreaList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400126A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400126B")]
				public const int AreasFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400126C")]
				private static readonly FieldCodec<VillageAreaType> _repeated_areas_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400126D")]
				private readonly RepeatedField<VillageAreaType> areas_;

				[Cpp2IlInjected.Token(Token = "0x17000A74")]
				[DebuggerNonUserCode]
				public static MessageParser<AreaList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002A27")]
					[Cpp2IlInjected.Address(RVA = "0x236A370", Offset = "0x2368D70", VA = "0x18236A370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A75")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002A28")]
					[Cpp2IlInjected.Address(RVA = "0x236A2F0", Offset = "0x2368CF0", VA = "0x18236A2F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A76")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002A29")]
					[Cpp2IlInjected.Address(RVA = "0x236A3D0", Offset = "0x2368DD0", VA = "0x18236A3D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A77")]
				[DebuggerNonUserCode]
				public RepeatedField<VillageAreaType> Areas
				{
					[Cpp2IlInjected.Token(Token = "0x6002A2D")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002A2A")]
				[Cpp2IlInjected.Address(RVA = "0x236A270", Offset = "0x2368C70", VA = "0x18236A270")]
				[DebuggerNonUserCode]
				public AreaList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A2B")]
				[Cpp2IlInjected.Address(RVA = "0x236A1E0", Offset = "0x2368BE0", VA = "0x18236A1E0")]
				[DebuggerNonUserCode]
				public AreaList(AreaList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A2C")]
				[Cpp2IlInjected.Address(RVA = "0x2369A20", Offset = "0x2368420", VA = "0x182369A20", Slot = "10")]
				[DebuggerNonUserCode]
				public AreaList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002A2E")]
				[Cpp2IlInjected.Address(RVA = "0x2369AE0", Offset = "0x23684E0", VA = "0x182369AE0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A2F")]
				[Cpp2IlInjected.Address(RVA = "0x2369BC0", Offset = "0x23685C0", VA = "0x182369BC0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(AreaList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A30")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A31")]
				[Cpp2IlInjected.Address(RVA = "0x2369EA0", Offset = "0x23688A0", VA = "0x182369EA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002A32")]
				[Cpp2IlInjected.Address(RVA = "0x2369F00", Offset = "0x2368900", VA = "0x182369F00", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A33")]
				[Cpp2IlInjected.Address(RVA = "0x2369910", Offset = "0x2368310", VA = "0x182369910", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A34")]
				[Cpp2IlInjected.Address(RVA = "0x2369DC0", Offset = "0x23687C0", VA = "0x182369DC0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(AreaList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A35")]
				[Cpp2IlInjected.Address(RVA = "0x2369CD0", Offset = "0x23686D0", VA = "0x182369CD0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A36")]
				[Cpp2IlInjected.Address(RVA = "0x2369C50", Offset = "0x2368650", VA = "0x182369C50", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002A37")]
				[Cpp2IlInjected.Address(RVA = "0x2369E40", Offset = "0x2368840", VA = "0x182369E40", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A38")]
				[Cpp2IlInjected.Address(RVA = "0x23699C0", Offset = "0x23683C0", VA = "0x1823699C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000399")]
			public sealed class ChooseVillageAreaEvent : IMessage<ChooseVillageAreaEvent>, IMessage, IEquatable<ChooseVillageAreaEvent>, IDeepCloneable<ChooseVillageAreaEvent>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x200039A")]
				public enum SpawnWhenEqualToOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4001279")]
					None = 0,
					[Cpp2IlInjected.Token(Token = "0x400127A")]
					VillageArea = 3
				}

				[Cpp2IlInjected.Token(Token = "0x400126F")]
				private static readonly MessageParser<ChooseVillageAreaEvent> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001270")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001271")]
				public const int ChooseVillageAreaEventItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001272")]
				private int chooseVillageAreaEventItemID_;

				[Cpp2IlInjected.Token(Token = "0x4001273")]
				public const int UseChooseVillageAreaMaximumAmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001274")]
				private bool useChooseVillageAreaMaximumAmount_;

				[Cpp2IlInjected.Token(Token = "0x4001275")]
				public const int VillageAreaFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001276")]
				private object spawnWhenEqualTo_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001277")]
				private SpawnWhenEqualToOneofCase spawnWhenEqualToCase_;

				[Cpp2IlInjected.Token(Token = "0x17000A78")]
				[DebuggerNonUserCode]
				public static MessageParser<ChooseVillageAreaEvent> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002A3F")]
					[Cpp2IlInjected.Address(RVA = "0x236B210", Offset = "0x2369C10", VA = "0x18236B210")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A79")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002A40")]
					[Cpp2IlInjected.Address(RVA = "0x236B190", Offset = "0x2369B90", VA = "0x18236B190")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A7A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002A41")]
					[Cpp2IlInjected.Address(RVA = "0x236B2E0", Offset = "0x2369CE0", VA = "0x18236B2E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A7B")]
				[DebuggerNonUserCode]
				public int ChooseVillageAreaEventItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002A45")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002A46")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A7C")]
				[DebuggerNonUserCode]
				public bool UseChooseVillageAreaMaximumAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6002A47")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002A48")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A7D")]
				[DebuggerNonUserCode]
				public VillageAreaType VillageArea
				{
					[Cpp2IlInjected.Token(Token = "0x6002A49")]
					[Cpp2IlInjected.Address(RVA = "0x236B270", Offset = "0x2369C70", VA = "0x18236B270")]
					get
					{
						return default(VillageAreaType);
					}
					[Cpp2IlInjected.Token(Token = "0x6002A4A")]
					[Cpp2IlInjected.Address(RVA = "0x236B3A0", Offset = "0x2369DA0", VA = "0x18236B3A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A7E")]
				[DebuggerNonUserCode]
				public SpawnWhenEqualToOneofCase SpawnWhenEqualToCase
				{
					[Cpp2IlInjected.Token(Token = "0x6002A4B")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(SpawnWhenEqualToOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A7F")]
				public Item ChooseVillageAreaEventItem
				{
					[Cpp2IlInjected.Token(Token = "0x6002A5A")]
					[Cpp2IlInjected.Address(RVA = "0x236B130", Offset = "0x2369B30", VA = "0x18236B130")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002A42")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ChooseVillageAreaEvent()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A43")]
				[Cpp2IlInjected.Address(RVA = "0x236B070", Offset = "0x2369A70", VA = "0x18236B070")]
				[DebuggerNonUserCode]
				public ChooseVillageAreaEvent(ChooseVillageAreaEvent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A44")]
				[Cpp2IlInjected.Address(RVA = "0x236A6A0", Offset = "0x23690A0", VA = "0x18236A6A0", Slot = "10")]
				[DebuggerNonUserCode]
				public ChooseVillageAreaEvent Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002A4C")]
				[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
				[DebuggerNonUserCode]
				public void ClearSpawnWhenEqualTo()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A4D")]
				[Cpp2IlInjected.Address(RVA = "0x236A820", Offset = "0x2369220", VA = "0x18236A820", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A4E")]
				[Cpp2IlInjected.Address(RVA = "0x236A790", Offset = "0x2369190", VA = "0x18236A790", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ChooseVillageAreaEvent other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A4F")]
				[Cpp2IlInjected.Address(RVA = "0x236AA00", Offset = "0x2369400", VA = "0x18236AA00", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A50")]
				[Cpp2IlInjected.Address(RVA = "0x236AE40", Offset = "0x2369840", VA = "0x18236AE40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002A51")]
				[Cpp2IlInjected.Address(RVA = "0x236AEA0", Offset = "0x23698A0", VA = "0x18236AEA0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A52")]
				[Cpp2IlInjected.Address(RVA = "0x236A490", Offset = "0x2368E90", VA = "0x18236A490", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A53")]
				[Cpp2IlInjected.Address(RVA = "0x236ABA0", Offset = "0x23695A0", VA = "0x18236ABA0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ChooseVillageAreaEvent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A54")]
				[Cpp2IlInjected.Address(RVA = "0x236AC20", Offset = "0x2369620", VA = "0x18236AC20", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A55")]
				[Cpp2IlInjected.Address(RVA = "0x236A8F0", Offset = "0x23692F0", VA = "0x18236A8F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002A56")]
				[Cpp2IlInjected.Address(RVA = "0x236AD10", Offset = "0x2369710", VA = "0x18236AD10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A57")]
				[Cpp2IlInjected.Address(RVA = "0x236A5B0", Offset = "0x2368FB0", VA = "0x18236A5B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002A58")]
				[Cpp2IlInjected.Address(RVA = "0x236AAF0", Offset = "0x23694F0", VA = "0x18236AAF0", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002A59")]
				[Cpp2IlInjected.Address(RVA = "0x236A630", Offset = "0x2369030", VA = "0x18236A630", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400125F")]
		private static readonly MessageParser<SpawnRecurringEventAreaSpecification> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001260")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001261")]
		public const int SpecificAreasFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001262")]
		public const int FromChooseVillageAreaEventFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001263")]
		private object areaSpecification_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001264")]
		private AreaSpecificationOneofCase areaSpecificationCase_;

		[Cpp2IlInjected.Token(Token = "0x17000A6E")]
		[DebuggerNonUserCode]
		public static MessageParser<SpawnRecurringEventAreaSpecification> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002A0D")]
			[Cpp2IlInjected.Address(RVA = "0x262D1F0", Offset = "0x262BBF0", VA = "0x18262D1F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A6F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002A0E")]
			[Cpp2IlInjected.Address(RVA = "0x262D0C0", Offset = "0x262BAC0", VA = "0x18262D0C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A70")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002A0F")]
			[Cpp2IlInjected.Address(RVA = "0x262D2B0", Offset = "0x262BCB0", VA = "0x18262D2B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A71")]
		[DebuggerNonUserCode]
		public Types.AreaList SpecificAreas
		{
			[Cpp2IlInjected.Token(Token = "0x6002A13")]
			[Cpp2IlInjected.Address(RVA = "0x262D250", Offset = "0x262BC50", VA = "0x18262D250")]
			get
			{
				int num = 0;
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					object obj = areaSpecification_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A14")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				areaSpecification_ = value;
				bool flag = (byte)(areaSpecificationCase_ = ((value != null) ? AreaSpecificationOneofCase.SpecificAreas : AreaSpecificationOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A72")]
		[DebuggerNonUserCode]
		public Types.ChooseVillageAreaEvent FromChooseVillageAreaEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002A15")]
			[Cpp2IlInjected.Address(RVA = "0x262D190", Offset = "0x262BB90", VA = "0x18262D190")]
			get
			{
				int num = 0;
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
				{
					object obj = areaSpecification_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A16")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				areaSpecification_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A73")]
		[DebuggerNonUserCode]
		public AreaSpecificationOneofCase AreaSpecificationCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002A17")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return areaSpecificationCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A10")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SpawnRecurringEventAreaSpecification()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002A11")]
		[Cpp2IlInjected.Address(RVA = "0x262CF60", Offset = "0x262B960", VA = "0x18262CF60")]
		[DebuggerNonUserCode]
		public SpawnRecurringEventAreaSpecification(SpawnRecurringEventAreaSpecification other)
		{
			//IL_005c: Expected I4, but got O
			AreaSpecificationOneofCase areaSpecificationOneofCase = other.areaSpecificationCase_;
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.SpecificAreas)
			{
				AreaSpecificationOneofCase areaSpecificationOneofCase2 = other.areaSpecificationCase_;
				if (other.areaSpecification_ == null)
				{
					throw new InvalidCastException();
				}
				Types.AreaList areaList = default(Types.AreaList);
				areaSpecification_ = areaList;
				bool flag = (byte)(areaSpecificationCase_ = ((areaList != null) ? AreaSpecificationOneofCase.SpecificAreas : AreaSpecificationOneofCase.None)) != 0;
			}
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
			{
				AreaSpecificationOneofCase areaSpecificationOneofCase3 = other.areaSpecificationCase_;
				if (other.areaSpecification_ == null)
				{
					throw new InvalidCastException();
				}
				Types.ChooseVillageAreaEvent chooseVillageAreaEvent = default(Types.ChooseVillageAreaEvent);
				areaSpecification_ = chooseVillageAreaEvent;
				areaSpecificationCase_ = (AreaSpecificationOneofCase)chooseVillageAreaEvent;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A12")]
		[Cpp2IlInjected.Address(RVA = "0x262C060", Offset = "0x262AA60", VA = "0x18262C060", Slot = "10")]
		[DebuggerNonUserCode]
		public SpawnRecurringEventAreaSpecification Clone()
		{
			//Discarded unreachable code: IL_0075
			//IL_005e: Expected I4, but got O
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = new SpawnRecurringEventAreaSpecification();
			AreaSpecificationOneofCase areaSpecificationOneofCase = areaSpecificationCase_;
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.SpecificAreas)
			{
				AreaSpecificationOneofCase areaSpecificationOneofCase2 = areaSpecificationCase_;
				if (areaSpecification_ == null)
				{
					throw new InvalidCastException();
				}
				Types.AreaList areaList = default(Types.AreaList);
				spawnRecurringEventAreaSpecification.areaSpecification_ = areaList;
				bool flag = (byte)(spawnRecurringEventAreaSpecification.areaSpecificationCase_ = ((areaList != null) ? AreaSpecificationOneofCase.SpecificAreas : AreaSpecificationOneofCase.None)) != 0;
			}
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
			{
				AreaSpecificationOneofCase areaSpecificationOneofCase3 = areaSpecificationCase_;
				if (areaSpecification_ == null)
				{
					throw new InvalidCastException();
				}
				Types.ChooseVillageAreaEvent chooseVillageAreaEvent = default(Types.ChooseVillageAreaEvent);
				spawnRecurringEventAreaSpecification.areaSpecification_ = chooseVillageAreaEvent;
				spawnRecurringEventAreaSpecification.areaSpecificationCase_ = (AreaSpecificationOneofCase)chooseVillageAreaEvent;
			}
			UnknownFieldSet unknownFieldSet = (spawnRecurringEventAreaSpecification._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return spawnRecurringEventAreaSpecification;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A18")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearAreaSpecification()
		{
			//IL_0010: Expected O, but got I4
			areaSpecification_ = (areaSpecificationCase_ = AreaSpecificationOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A19")]
		[Cpp2IlInjected.Address(RVA = "0x262C1F0", Offset = "0x262ABF0", VA = "0x18262C1F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
					{
						object obj = areaSpecification_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(Types.AreaList).TypeHandle != null && (object)typeof(Types.AreaList).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						Types.ChooseVillageAreaEvent objB = default(Types.ChooseVillageAreaEvent);
						bool flag2 = object.Equals(FromChooseVillageAreaEvent, objB);
						if (flag2 && areaSpecificationCase_ == (flag2 ? AreaSpecificationOneofCase.SpecificAreas : AreaSpecificationOneofCase.None))
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

		[Cpp2IlInjected.Token(Token = "0x6002A1A")]
		[Cpp2IlInjected.Address(RVA = "0x262C360", Offset = "0x262AD60", VA = "0x18262C360", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SpawnRecurringEventAreaSpecification other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					object obj = areaSpecification_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					obj2 = other.areaSpecification_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					Types.ChooseVillageAreaEvent fromChooseVillageAreaEvent = FromChooseVillageAreaEvent;
					Types.ChooseVillageAreaEvent fromChooseVillageAreaEvent2 = other.FromChooseVillageAreaEvent;
					if (object.Equals(fromChooseVillageAreaEvent, fromChooseVillageAreaEvent2))
					{
						AreaSpecificationOneofCase areaSpecificationOneofCase = other.areaSpecificationCase_;
						if (areaSpecificationCase_ == areaSpecificationOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x6002A1B")]
		[Cpp2IlInjected.Address(RVA = "0x262C5A0", Offset = "0x262AFA0", VA = "0x18262C5A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			AreaSpecificationOneofCase areaSpecificationOneofCase = areaSpecificationCase_;
			int num = 0;
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.SpecificAreas)
			{
				object obj = areaSpecification_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
			{
				object obj2 = areaSpecification_;
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

		[Cpp2IlInjected.Token(Token = "0x6002A1C")]
		[Cpp2IlInjected.Address(RVA = "0x262CCC0", Offset = "0x262B6C0", VA = "0x18262CCC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1D")]
		[Cpp2IlInjected.Address(RVA = "0x262CD20", Offset = "0x262B720", VA = "0x18262CD20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			AreaSpecificationOneofCase areaSpecificationOneofCase = areaSpecificationCase_;
			int num = 0;
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.SpecificAreas)
			{
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					object obj = areaSpecification_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (areaSpecificationOneofCase == AreaSpecificationOneofCase.FromChooseVillageAreaEvent && areaSpecificationCase_ == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
			{
				object obj2 = areaSpecification_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1E")]
		[Cpp2IlInjected.Address(RVA = "0x262BEA0", Offset = "0x262A8A0", VA = "0x18262BEA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
			{
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					object obj = areaSpecification_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (areaSpecificationCase_ == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
			{
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
				{
					object obj2 = areaSpecification_;
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

		[Cpp2IlInjected.Token(Token = "0x6002A1F")]
		[Cpp2IlInjected.Address(RVA = "0x262C980", Offset = "0x262B380", VA = "0x18262C980", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SpawnRecurringEventAreaSpecification other)
		{
			//IL_00dd: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
			{
				AreaSpecificationOneofCase areaSpecificationOneofCase = areaSpecificationCase_;
				int num = 0;
				if (areaSpecificationOneofCase == AreaSpecificationOneofCase.SpecificAreas)
				{
					object obj = areaSpecification_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(areaSpecificationCase_ = (((areaSpecification_ = new Types.AreaList()) != null) ? AreaSpecificationOneofCase.SpecificAreas : AreaSpecificationOneofCase.None)) != 0;
				}
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					object obj2 = areaSpecification_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					object obj3 = other.areaSpecification_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(Types.ChooseVillageAreaEvent).TypeHandle != 2)
			{
			}
			if (FromChooseVillageAreaEvent == null)
			{
				areaSpecificationCase_ = (AreaSpecificationOneofCase)(areaSpecification_ = new Types.ChooseVillageAreaEvent());
			}
			Types.ChooseVillageAreaEvent other2 = default(Types.ChooseVillageAreaEvent);
			FromChooseVillageAreaEvent.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A20")]
		[Cpp2IlInjected.Address(RVA = "0x262C780", Offset = "0x262B180", VA = "0x18262C780", Slot = "5")]
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
				Types.AreaList areaList = new Types.AreaList();
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
				{
					if (areaSpecificationCase_ != AreaSpecificationOneofCase.SpecificAreas)
					{
					}
					object obj = areaSpecification_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(areaList);
				areaSpecification_ = areaList;
				bool flag = (byte)(areaSpecificationCase_ = ((areaList != null) ? AreaSpecificationOneofCase.SpecificAreas : AreaSpecificationOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				Types.ChooseVillageAreaEvent builder = new Types.ChooseVillageAreaEvent();
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
				{
					if (areaSpecificationCase_ != AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
					{
					}
					object obj2 = areaSpecification_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				areaSpecification_ = builder;
				areaSpecificationCase_ = (AreaSpecificationOneofCase)typeof(Types.ChooseVillageAreaEvent).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002A21")]
		[Cpp2IlInjected.Address(RVA = "0x262C490", Offset = "0x262AE90", VA = "0x18262C490", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (areaSpecificationCase_ == AreaSpecificationOneofCase.SpecificAreas)
			{
				object obj = areaSpecification_;
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
				if (areaSpecificationCase_ == AreaSpecificationOneofCase.FromChooseVillageAreaEvent)
				{
					obj2 = areaSpecification_;
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

		[Cpp2IlInjected.Token(Token = "0x6002A22")]
		[Cpp2IlInjected.Address(RVA = "0x262CBD0", Offset = "0x262B5D0", VA = "0x18262CBD0", Slot = "12")]
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
				areaSpecification_ = num;
				bool flag = (byte)(areaSpecificationCase_ = ((num != 0) ? AreaSpecificationOneofCase.SpecificAreas : AreaSpecificationOneofCase.None)) != 0;
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
				areaSpecification_ = value;
				areaSpecificationCase_ = (AreaSpecificationOneofCase)typeof(Types.ChooseVillageAreaEvent).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A23")]
		[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1 || fieldNumber == 2)
			{
				areaSpecificationCase_ = AreaSpecificationOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A24")]
		[Cpp2IlInjected.Address(RVA = "0x262C6D0", Offset = "0x262B0D0", VA = "0x18262C6D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "AreaSpecification"))
			{
				AreaSpecificationOneofCase areaSpecificationOneofCase = areaSpecificationCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A25")]
		[Cpp2IlInjected.Address(RVA = "0x262BFF0", Offset = "0x262A9F0", VA = "0x18262BFF0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "AreaSpecification"))
			{
				areaSpecification_ = (areaSpecificationCase_ = AreaSpecificationOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A26")]
		[Cpp2IlInjected.Address(RVA = "0x262CE50", Offset = "0x262B850", VA = "0x18262CE50")]
		static SpawnRecurringEventAreaSpecification()
		{
			Func<SpawnRecurringEventAreaSpecification> func = default(Func<SpawnRecurringEventAreaSpecification>);
			_parser = (MessageParser<SpawnRecurringEventAreaSpecification>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
