using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000311")]
	public sealed class PlantSeed : IMessage<PlantSeed>, IMessage, IEquatable<PlantSeed>, IDeepCloneable<PlantSeed>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000312")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000313")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400097B")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400097C")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x400097D")]
				[OriginalName("NotEnoughSeeds")]
				NotEnoughSeeds,
				[Cpp2IlInjected.Token(Token = "0x400097E")]
				[OriginalName("NotEnoughMana")]
				NotEnoughMana,
				[Cpp2IlInjected.Token(Token = "0x400097F")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000980")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId,
				[Cpp2IlInjected.Token(Token = "0x4000981")]
				[OriginalName("InvalidSlotIndex")]
				InvalidSlotIndex,
				[Cpp2IlInjected.Token(Token = "0x4000982")]
				[OriginalName("InvalidGarden")]
				InvalidGarden,
				[Cpp2IlInjected.Token(Token = "0x4000983")]
				[OriginalName("Occupied")]
				Occupied,
				[Cpp2IlInjected.Token(Token = "0x4000984")]
				[OriginalName("MissionSeedRealmRestriction")]
				MissionSeedRealmRestriction
			}

			[Cpp2IlInjected.Token(Token = "0x2000314")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000985")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000986")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000987")]
				public const int SeedItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000988")]
				private int seedItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000989")]
				public const int GridIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400098A")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x400098B")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400098C")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x400098D")]
				public const int SlotIndexFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400098E")]
				private int slotIndex_;

				[Cpp2IlInjected.Token(Token = "0x17000584")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001EAF")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4400", Offset = "0x1DC2E00", VA = "0x181DC4400")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000585")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001EB0")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4250", Offset = "0x1DC2C50", VA = "0x181DC4250")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000586")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001EB1")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4650", Offset = "0x1DC3050", VA = "0x181DC4650", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000587")]
				[DebuggerNonUserCode]
				public int SeedItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001EB5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001EB6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000588")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6001EB7")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001EB8")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000589")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6001EB9")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001EBA")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700058A")]
				[DebuggerNonUserCode]
				public int SlotIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6001EBB")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001EBC")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001EB2")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3C80", Offset = "0x1DC2680", VA = "0x181DC3C80")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EB3")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3D30", Offset = "0x1DC2730", VA = "0x181DC3D30")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EB4")]
				[Cpp2IlInjected.Address(RVA = "0x1DBFEF0", Offset = "0x1DBE8F0", VA = "0x181DBFEF0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001EBD")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0050", Offset = "0x1DBEA50", VA = "0x181DC0050", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001EBE")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3E50", Offset = "0x1BF2850", VA = "0x181BF3E50", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001EBF")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0E00", Offset = "0x1DBF800", VA = "0x181DC0E00", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC0")]
				[Cpp2IlInjected.Address(RVA = "0x1DC2570", Offset = "0x1DC0F70", VA = "0x181DC2570", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC1")]
				[Cpp2IlInjected.Address(RVA = "0x1DC2D30", Offset = "0x1DC1730", VA = "0x181DC2D30", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC2")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF090", Offset = "0x1DBDA90", VA = "0x181DBF090", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC3")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4020", Offset = "0x1BF2A20", VA = "0x181BF4020", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC4")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4090", Offset = "0x1BF2A90", VA = "0x181BF4090", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC5")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0CA0", Offset = "0x1DBF6A0", VA = "0x181DC0CA0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC6")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1980", Offset = "0x1DC0380", VA = "0x181DC1980", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC7")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3CE0", Offset = "0x1BF26E0", VA = "0x181BF3CE0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EC8")]
				[Cpp2IlInjected.Address(RVA = "0x1DC2730", Offset = "0x1DC1130", VA = "0x181DC2730", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000316")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000990")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000991")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000992")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000993")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000994")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000995")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700058B")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001ECD")]
					[Cpp2IlInjected.Address(RVA = "0x1DCEDF0", Offset = "0x1DCD7F0", VA = "0x181DCEDF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700058C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001ECE")]
					[Cpp2IlInjected.Address(RVA = "0x1DCEC70", Offset = "0x1DCD670", VA = "0x181DCEC70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700058D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001ECF")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF330", Offset = "0x1DCDD30", VA = "0x181DCF330", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700058E")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001ED3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001ED4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700058F")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001ED5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001ED6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000590")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001EE2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001EE3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001ED0")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE510", Offset = "0x1DCCF10", VA = "0x181DCE510")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001ED1")]
				[Cpp2IlInjected.Address(RVA = "0x1DCDF10", Offset = "0x1DCC910", VA = "0x181DCDF10")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001ED2")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8C90", Offset = "0x1DC7690", VA = "0x181DC8C90", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001ED7")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9260", Offset = "0x1DC7C60", VA = "0x181DC9260", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001ED8")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001ED9")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001EDA")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCD80", Offset = "0x1DCB780", VA = "0x181DCCD80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001EDB")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EDC")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8360", Offset = "0x1DC6D60", VA = "0x181DC8360", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001EDD")]
				[Cpp2IlInjected.Address(RVA = "0x1DCBA10", Offset = "0x1DCA410", VA = "0x181DCBA10", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EDE")]
				[Cpp2IlInjected.Address(RVA = "0x1DCB920", Offset = "0x1DCA320", VA = "0x181DCB920", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EDF")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9D60", Offset = "0x1DC8760", VA = "0x181DC9D60", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001EE0")]
				[Cpp2IlInjected.Address(RVA = "0x1DCC610", Offset = "0x1DCB010", VA = "0x181DCC610", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EE1")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001EE4")]
				[Cpp2IlInjected.Address(RVA = "0x1DC5030", Offset = "0x1DC3A30", VA = "0x181DC5030", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000978")]
		private static readonly MessageParser<PlantSeed> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000979")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000581")]
		[DebuggerNonUserCode]
		public static MessageParser<PlantSeed> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001E9C")]
			[Cpp2IlInjected.Address(RVA = "0x7B9E60", Offset = "0x7B8860", VA = "0x1807B9E60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000582")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E9D")]
			[Cpp2IlInjected.Address(RVA = "0x7B9D90", Offset = "0x7B8790", VA = "0x1807B9D90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000583")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E9E")]
			[Cpp2IlInjected.Address(RVA = "0x7B9EC0", Offset = "0x7B88C0", VA = "0x1807B9EC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PlantSeed()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PlantSeed(PlantSeed other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9450", Offset = "0x7B7E50", VA = "0x1807B9450", Slot = "10")]
		[DebuggerNonUserCode]
		public PlantSeed Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PlantSeed plantSeed = default(PlantSeed);
			plantSeed.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (plantSeed._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return plantSeed;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA2")]
		[Cpp2IlInjected.Address(RVA = "0x7B94D0", Offset = "0x7B7ED0", VA = "0x1807B94D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PlantSeed other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA4")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA5")]
		[Cpp2IlInjected.Address(RVA = "0x7B95C0", Offset = "0x7B7FC0", VA = "0x1807B95C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PlantSeed other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EA9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAA")]
		[Cpp2IlInjected.Address(RVA = "0x7B9550", Offset = "0x7B7F50", VA = "0x1807B9550", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAD")]
		[Cpp2IlInjected.Address(RVA = "0x7B9620", Offset = "0x7B8020", VA = "0x1807B9620")]
		public unsafe static Types.Result Validate(Types.Request request, in Player player, in World world, ITransactionContext transactionContext)
		{
			//IL_0135: Expected I4, but got O
			int num = 0;
			int seedItemID_ = request.seedItemID_;
			ItemType itemType = default(ItemType);
			ActivityItemType activityItemType = default(ActivityItemType);
			if (itemType == ItemType.ActivityItem && activityItemType == ActivityItemType.Seed)
			{
				GridCollection gridCollection_ = world.Section.gridCollection_;
				uint gridID_ = request.gridID_;
				if (gridCollection_.TryGetGrid(gridID_, out *(IGridInternal*)num))
				{
					Village village_ = world.Section.village_;
					uint gridID_2 = request.gridID_;
					if (village_.IsVillageGridID(gridID_2))
					{
						ProfileWorld section = world.Section;
						uint gridID_3 = request.gridID_;
						if (!section.IsGridUnlocked(gridID_3))
						{
							goto IL_0144;
						}
					}
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					GardenData gardenData = default(GardenData);
					if (num != 0 && num != 0 && gardenData != null)
					{
						int slotIndex_ = request.slotIndex_;
						GardenData gardenData2 = default(GardenData);
						int count = ((RepeatedField<T>)(object)gardenData2.slots_).Count;
						if (slotIndex_ < count)
						{
							GardenData gardenData3 = default(GardenData);
							RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData3.slots_;
							int slotIndex_2 = request.slotIndex_;
							Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_)[slotIndex_2]).PlantedSeedItem;
							bool flag = default(bool);
							if (!flag)
							{
								ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
								SeedItemData seedItemData = default(SeedItemData);
								int itemID = seedItemData.ProducedItem.ItemID;
								CropItemData cropItemData = default(CropItemData);
								if (cropItemData != null)
								{
									itemID += itemID;
								}
								GardenItemData gardenItemData = default(GardenItemData);
								uint num3 = default(uint);
								if (gardenItemData.cropType_ == (CropType)num3)
								{
									if (seedItemData.IsLocationRestricted)
									{
										GridLocationFilter missionSeedLocationRestriction = seedItemData.MissionSeedLocationRestriction;
										bool flag2 = default(bool);
										if (flag2)
										{
										}
									}
									int num4 = 0;
									(int, int) tuple = default((int, int));
									int num5 = (int)((ValueTuple<, >*)(&tuple))->Item1;
									bool flag3 = default(bool);
									bool flag4 = default(bool);
									bool flag5 = default(bool);
									if (flag3 && !flag4 && flag5)
									{
									}
								}
							}
						}
					}
				}
			}
			goto IL_0144;
			IL_0144:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EAE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C80", Offset = "0x7B8680", VA = "0x1807B9C80")]
		static PlantSeed()
		{
			Func<PlantSeed> func = default(Func<PlantSeed>);
			_parser = (MessageParser<PlantSeed>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
