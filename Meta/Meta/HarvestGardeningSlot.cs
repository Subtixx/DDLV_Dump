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
	[Cpp2IlInjected.Token(Token = "0x2000321")]
	public sealed class HarvestGardeningSlot : IMessage<HarvestGardeningSlot>, IMessage, IEquatable<HarvestGardeningSlot>, IDeepCloneable<HarvestGardeningSlot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000322")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000323")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40009B5")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40009B6")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x40009B7")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId,
				[Cpp2IlInjected.Token(Token = "0x40009B8")]
				[OriginalName("InvalidSlotIndex")]
				InvalidSlotIndex,
				[Cpp2IlInjected.Token(Token = "0x40009B9")]
				[OriginalName("InvalidContainerInventory")]
				InvalidContainerInventory,
				[Cpp2IlInjected.Token(Token = "0x40009BA")]
				[OriginalName("InventoryFull")]
				InventoryFull,
				[Cpp2IlInjected.Token(Token = "0x40009BB")]
				[OriginalName("ProductionNotReady")]
				ProductionNotReady,
				[Cpp2IlInjected.Token(Token = "0x40009BC")]
				[OriginalName("MissionSeedBlockedHarvest")]
				MissionSeedBlockedHarvest,
				[Cpp2IlInjected.Token(Token = "0x40009BD")]
				[OriginalName("BurningStateCooldown")]
				BurningStateCooldown
			}

			[Cpp2IlInjected.Token(Token = "0x2000324")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40009BE")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40009BF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40009C0")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40009C1")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x40009C2")]
				public const int GridObjectIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40009C3")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x40009C4")]
				public const int SlotIndexFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40009C5")]
				private int slotIndex_;

				[Cpp2IlInjected.Token(Token = "0x40009C6")]
				public const int ContainerInventoryIDFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40009C7")]
				private uint containerInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x170005A4")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001F4F")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE5F0", Offset = "0x1BFCFF0", VA = "0x181BFE5F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005A5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001F50")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE2D0", Offset = "0x1BFCCD0", VA = "0x181BFE2D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005A6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001F51")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE7D0", Offset = "0x1BFD1D0", VA = "0x181BFE7D0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005A7")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6001F55")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001F56")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005A8")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6001F57")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001F58")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005A9")]
				[DebuggerNonUserCode]
				public int SlotIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6001F59")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001F5A")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005AA")]
				[DebuggerNonUserCode]
				public uint ContainerInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6001F5B")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001F5C")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001F52")]
				[Cpp2IlInjected.Address(RVA = "0x1BFDD40", Offset = "0x1BFC740", VA = "0x181BFDD40")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F53")]
				[Cpp2IlInjected.Address(RVA = "0x1BFE100", Offset = "0x1BFCB00", VA = "0x181BFE100")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F54")]
				[Cpp2IlInjected.Address(RVA = "0x1BF98B0", Offset = "0x1BF82B0", VA = "0x181BF98B0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001F5D")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9B30", Offset = "0x1BF8530", VA = "0x181BF9B30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F5E")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3E50", Offset = "0x1BF2850", VA = "0x181BF3E50", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F5F")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA730", Offset = "0x1BF9130", VA = "0x181BFA730", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F60")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB6D0", Offset = "0x1BFA0D0", VA = "0x181BFB6D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001F61")]
				[Cpp2IlInjected.Address(RVA = "0x1BFD380", Offset = "0x1BFBD80", VA = "0x181BFD380", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F62")]
				[Cpp2IlInjected.Address(RVA = "0x1BF8F40", Offset = "0x1BF7940", VA = "0x181BF8F40", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F63")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4020", Offset = "0x1BF2A20", VA = "0x181BF4020", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F64")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4090", Offset = "0x1BF2A90", VA = "0x181BF4090", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F65")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA400", Offset = "0x1BF8E00", VA = "0x181BFA400", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001F66")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB250", Offset = "0x1BF9C50", VA = "0x181BFB250", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F67")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3CE0", Offset = "0x1BF26E0", VA = "0x181BF3CE0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F68")]
				[Cpp2IlInjected.Address(RVA = "0x1BFCFB0", Offset = "0x1BFB9B0", VA = "0x181BFCFB0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000326")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40009C9")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40009CA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40009CB")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40009CC")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40009CD")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40009CE")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40009CF")]
				public const int AmountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40009D0")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x170005AB")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001F6D")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A820", Offset = "0x1C09220", VA = "0x181C0A820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005AC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001F6E")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A6C0", Offset = "0x1C090C0", VA = "0x181C0A6C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005AD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001F6F")]
					[Cpp2IlInjected.Address(RVA = "0x1C0AA00", Offset = "0x1C09400", VA = "0x181C0AA00", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005AE")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001F73")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001F74")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005AF")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001F75")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001F76")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B0")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6001F77")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001F78")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B1")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001F84")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001F85")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001F70")]
				[Cpp2IlInjected.Address(RVA = "0x1C09830", Offset = "0x1C08230", VA = "0x181C09830")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F71")]
				[Cpp2IlInjected.Address(RVA = "0x1C09D40", Offset = "0x1C08740", VA = "0x181C09D40")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F72")]
				[Cpp2IlInjected.Address(RVA = "0x1C04C00", Offset = "0x1C03600", VA = "0x181C04C00", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001F79")]
				[Cpp2IlInjected.Address(RVA = "0x1C053A0", Offset = "0x1C03DA0", VA = "0x181C053A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F7A")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F7B")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F7C")]
				[Cpp2IlInjected.Address(RVA = "0x1C07D10", Offset = "0x1C06710", VA = "0x181C07D10", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001F7D")]
				[Cpp2IlInjected.Address(RVA = "0x89B730", Offset = "0x89A130", VA = "0x18089B730", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F7E")]
				[Cpp2IlInjected.Address(RVA = "0x1C03CA0", Offset = "0x1C026A0", VA = "0x181C03CA0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F7F")]
				[Cpp2IlInjected.Address(RVA = "0x1C07250", Offset = "0x1C05C50", VA = "0x181C07250", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F80")]
				[Cpp2IlInjected.Address(RVA = "0x1C06400", Offset = "0x1C04E00", VA = "0x181C06400", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F81")]
				[Cpp2IlInjected.Address(RVA = "0x1C05990", Offset = "0x1C04390", VA = "0x181C05990", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001F82")]
				[Cpp2IlInjected.Address(RVA = "0x1C073A0", Offset = "0x1C05DA0", VA = "0x181C073A0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F83")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F86")]
				[Cpp2IlInjected.Address(RVA = "0x1C00C10", Offset = "0x1BFF610", VA = "0x181C00C10", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001F87")]
				[Cpp2IlInjected.Address(RVA = "0x1C087E0", Offset = "0x1C071E0", VA = "0x181C087E0")]
				internal static void UpdatePostHarvestState(IGridInternal grid, GridObject gridObject, int slotIndex, SeedItemData seedItemData, in Player player, in World world, ITransactionContext context)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F88")]
				[Cpp2IlInjected.Address(RVA = "0x1C08900", Offset = "0x1C07300", VA = "0x181C08900")]
				private static void UpdateProduction(GardenData.Types.GardeningSlot gardeningSlot, SeedItemData seedItemData, in Player player, ITransactionContext context)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001F89")]
				[Cpp2IlInjected.Address(RVA = "0x1C08330", Offset = "0x1C06D30", VA = "0x181C08330")]
				private static void UpdateGardeningSlotState(IGridInternal grid, GridObject gridObject, int slotIndex, SeedItemData seedItemData, in Player player, in World world, ITransactionContext context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40009B2")]
		private static readonly MessageParser<HarvestGardeningSlot> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009B3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170005A1")]
		[DebuggerNonUserCode]
		public static MessageParser<HarvestGardeningSlot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001F3B")]
			[Cpp2IlInjected.Address(RVA = "0x17042E0", Offset = "0x1702CE0", VA = "0x1817042E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F3C")]
			[Cpp2IlInjected.Address(RVA = "0x1704210", Offset = "0x1702C10", VA = "0x181704210")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F3D")]
			[Cpp2IlInjected.Address(RVA = "0x1704340", Offset = "0x1702D40", VA = "0x181704340", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public HarvestGardeningSlot()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public HarvestGardeningSlot(HarvestGardeningSlot other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F40")]
		[Cpp2IlInjected.Address(RVA = "0x1703960", Offset = "0x1702360", VA = "0x181703960", Slot = "10")]
		[DebuggerNonUserCode]
		public HarvestGardeningSlot Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			HarvestGardeningSlot harvestGardeningSlot = default(HarvestGardeningSlot);
			harvestGardeningSlot.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (harvestGardeningSlot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return harvestGardeningSlot;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F41")]
		[Cpp2IlInjected.Address(RVA = "0x17039E0", Offset = "0x17023E0", VA = "0x1817039E0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F42")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HarvestGardeningSlot other)
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

		[Cpp2IlInjected.Token(Token = "0x6001F43")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F44")]
		[Cpp2IlInjected.Address(RVA = "0x1703AD0", Offset = "0x17024D0", VA = "0x181703AD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F45")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F46")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F47")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HarvestGardeningSlot other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F48")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F49")]
		[Cpp2IlInjected.Address(RVA = "0x1703A60", Offset = "0x1702460", VA = "0x181703A60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4C")]
		[Cpp2IlInjected.Address(RVA = "0x1703730", Offset = "0x1702130", VA = "0x181703730")]
		private static bool ApplyBuff(in Player player, Item item, ref int amount)
		{
			ItemType itemType = default(ItemType);
			ActivityItemType activityItemType = default(ActivityItemType);
			if (itemType == ItemType.ActivityItem && activityItemType == ActivityItemType.Crop)
			{
				CropItemData cropItemData = default(CropItemData);
				if (cropItemData.cropType_ != 0)
				{
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_004b;
					}
					ProfilePlayer section = player.Section;
				}
				ProfilePlayer section2 = player.Section;
				int num = default(int);
				uint maxValue = default(uint);
				if (num > 0 && new Random(player.Section.GetRandomSeed("Harvesting")).Next((int)maxValue) >= num)
				{
				}
			}
			goto IL_004b;
			IL_004b:
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4D")]
		[Cpp2IlInjected.Address(RVA = "0x1703B30", Offset = "0x1702530", VA = "0x181703B30")]
		public unsafe static Types.Result Validate(Types.Request request, in Player player, in World world, ITransactionContext transactionContext)
		{
			//IL_00e7: Expected O, but got I4
			//IL_0168: Expected O, but got I4
			int num = 0;
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
						goto IL_019f;
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
						if (((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_)[slotIndex_2]).Harvest != null)
						{
							MapField<uint, ContainerInventory> containerInventories_ = player.Section.containerInventories_;
							uint containerInventoryID_ = request.containerInventoryID_;
							if (((MapField<TKey, TValue>)(object)containerInventories_).TryGetValue((TKey)containerInventoryID_, out *(TValue*)num))
							{
								GardenData gardenData4 = default(GardenData);
								RepeatedField<GardenData.Types.GardeningSlot> slots_2 = gardenData4.slots_;
								int slotIndex_3 = request.slotIndex_;
								Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_2)[slotIndex_3]).PlantedSeedItem;
								GardenData gardenData5 = default(GardenData);
								RepeatedField<GardenData.Types.GardeningSlot> slots_3 = gardenData5.slots_;
								int slotIndex_4 = request.slotIndex_;
								TreeAndBushData harvest = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_3)[slotIndex_4]).Harvest;
								ProfileWorld section2 = world.Section;
								Village village_2 = world.Section.village_;
								uint gridID_4 = request.gridID_;
								bool inVillage = village_2.IsVillageGridID(gridID_4);
								int num3 = 0;
								DateTime endOfGrowthTime = harvest.GetEndOfGrowthTime((SeedItemData)num3, section2, transactionContext, inVillage);
								if (!(endOfGrowthTime > endOfGrowthTime))
								{
									int num4 = 0;
									SeedItemData seedItemData = default(SeedItemData);
									if (seedItemData.IsMissionItem() && (seedItemData.missionSeedBlockHarvest_ ? 1 : 0) != num)
									{
										num4 += num4;
										uint num5 = num5 + 552;
									}
								}
							}
						}
					}
				}
			}
			goto IL_019f;
			IL_019f:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4E")]
		[Cpp2IlInjected.Address(RVA = "0x1704100", Offset = "0x1702B00", VA = "0x181704100")]
		static HarvestGardeningSlot()
		{
			Func<HarvestGardeningSlot> func = default(Func<HarvestGardeningSlot>);
			_parser = (MessageParser<HarvestGardeningSlot>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
