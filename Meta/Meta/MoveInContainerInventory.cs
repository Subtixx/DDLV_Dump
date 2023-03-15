using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public sealed class MoveInContainerInventory : IMessage<MoveInContainerInventory>, IMessage, IEquatable<MoveInContainerInventory>, IDeepCloneable<MoveInContainerInventory>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200011A")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40003CA")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40003CB")]
				[OriginalName("InvalidSourceInventory")]
				InvalidSourceInventory,
				[Cpp2IlInjected.Token(Token = "0x40003CC")]
				[OriginalName("InvalidSourcePosition")]
				InvalidSourcePosition,
				[Cpp2IlInjected.Token(Token = "0x40003CD")]
				[OriginalName("InvalidDestinationInventory")]
				InvalidDestinationInventory,
				[Cpp2IlInjected.Token(Token = "0x40003CE")]
				[OriginalName("InvalidDestinationPosition")]
				InvalidDestinationPosition,
				[Cpp2IlInjected.Token(Token = "0x40003CF")]
				[OriginalName("NotEnoughItems")]
				NotEnoughItems,
				[Cpp2IlInjected.Token(Token = "0x40003D0")]
				[OriginalName("NotEnoughSpaceToTransfer")]
				NotEnoughSpaceToTransfer
			}

			[Cpp2IlInjected.Token(Token = "0x200011B")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40003D1")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003D2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40003D3")]
				public const int SourceInventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003D4")]
				private uint sourceInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x40003D5")]
				public const int SourcePositionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40003D6")]
				private int sourcePosition_;

				[Cpp2IlInjected.Token(Token = "0x40003D7")]
				public const int DestinationInventoryIDFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x40003D8")]
				private static readonly FieldCodec<uint?> _single_destinationInventoryID_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40003D9")]
				private uint? destinationInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x40003DA")]
				public const int DestinationPositionFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x40003DB")]
				private static readonly FieldCodec<int?> _single_destinationPosition_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40003DC")]
				private int? destinationPosition_;

				[Cpp2IlInjected.Token(Token = "0x40003DD")]
				public const int AmountToMoveFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x40003DE")]
				private static readonly FieldCodec<int?> _single_amountToMove_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40003DF")]
				private int? amountToMove_;

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000C5C")]
					[Cpp2IlInjected.Address(RVA = "0x25CC1B0", Offset = "0x25CABB0", VA = "0x1825CC1B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C5D")]
					[Cpp2IlInjected.Address(RVA = "0x25CC0D0", Offset = "0x25CAAD0", VA = "0x1825CC0D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C5E")]
					[Cpp2IlInjected.Address(RVA = "0x25CCCF0", Offset = "0x25CB6F0", VA = "0x1825CCCF0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				[DebuggerNonUserCode]
				public uint SourceInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000C62")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C63")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				[DebuggerNonUserCode]
				public int SourcePosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000C64")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C65")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000211")]
				[DebuggerNonUserCode]
				public uint? DestinationInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000C66")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000C67")]
					[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000212")]
				[DebuggerNonUserCode]
				public int? DestinationPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000C68")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000C69")]
					[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000213")]
				[DebuggerNonUserCode]
				public int? AmountToMove
				{
					[Cpp2IlInjected.Token(Token = "0x6000C6A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000C6B")]
					[Cpp2IlInjected.Address(RVA = "0x6E5AD0", Offset = "0x6E44D0", VA = "0x1806E5AD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000C5F")]
				[Cpp2IlInjected.Address(RVA = "0x25CB5E0", Offset = "0x25C9FE0", VA = "0x1825CB5E0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C60")]
				[Cpp2IlInjected.Address(RVA = "0x25CB9B0", Offset = "0x25CA3B0", VA = "0x1825CB9B0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C61")]
				[Cpp2IlInjected.Address(RVA = "0x25C50E0", Offset = "0x25C3AE0", VA = "0x1825C50E0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C6C")]
				[Cpp2IlInjected.Address(RVA = "0x25C6030", Offset = "0x25C4A30", VA = "0x1825C6030", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C6D")]
				[Cpp2IlInjected.Address(RVA = "0x25C5A20", Offset = "0x25C4420", VA = "0x1825C5A20", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C6E")]
				[Cpp2IlInjected.Address(RVA = "0x25C7100", Offset = "0x25C5B00", VA = "0x1825C7100", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C6F")]
				[Cpp2IlInjected.Address(RVA = "0x25C89C0", Offset = "0x25C73C0", VA = "0x1825C89C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C70")]
				[Cpp2IlInjected.Address(RVA = "0x25C9EA0", Offset = "0x25C88A0", VA = "0x1825C9EA0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C71")]
				[Cpp2IlInjected.Address(RVA = "0x25C4A70", Offset = "0x25C3470", VA = "0x1825C4A70", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C72")]
				[Cpp2IlInjected.Address(RVA = "0x25C7240", Offset = "0x25C5C40", VA = "0x1825C7240", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C73")]
				[Cpp2IlInjected.Address(RVA = "0x25C7830", Offset = "0x25C6230", VA = "0x1825C7830", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C74")]
				[Cpp2IlInjected.Address(RVA = "0x25C6640", Offset = "0x25C5040", VA = "0x1825C6640", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C75")]
				[Cpp2IlInjected.Address(RVA = "0x25C7B30", Offset = "0x25C6530", VA = "0x1825C7B30", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C76")]
				[Cpp2IlInjected.Address(RVA = "0x25C4D90", Offset = "0x25C3790", VA = "0x1825C4D90", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C77")]
				[Cpp2IlInjected.Address(RVA = "0x25C8C00", Offset = "0x25C7600", VA = "0x1825C8C00", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200011D")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40003E1")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003E2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40003E3")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003E4")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40003E5")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40003E6")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000214")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000C7C")]
					[Cpp2IlInjected.Address(RVA = "0x25D6A00", Offset = "0x25D5400", VA = "0x1825D6A00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000215")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C7D")]
					[Cpp2IlInjected.Address(RVA = "0x25D6620", Offset = "0x25D5020", VA = "0x1825D6620")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000216")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C7E")]
					[Cpp2IlInjected.Address(RVA = "0x25D7360", Offset = "0x25D5D60", VA = "0x1825D7360", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000217")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000C82")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C83")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000218")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000C84")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000C85")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000219")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000C91")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C92")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000C7F")]
				[Cpp2IlInjected.Address(RVA = "0x25D52D0", Offset = "0x25D3CD0", VA = "0x1825D52D0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C80")]
				[Cpp2IlInjected.Address(RVA = "0x25D5190", Offset = "0x25D3B90", VA = "0x1825D5190")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C81")]
				[Cpp2IlInjected.Address(RVA = "0x25D03E0", Offset = "0x25CEDE0", VA = "0x1825D03E0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C86")]
				[Cpp2IlInjected.Address(RVA = "0x25D0A60", Offset = "0x25CF460", VA = "0x1825D0A60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C87")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C88")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C89")]
				[Cpp2IlInjected.Address(RVA = "0x25D40B0", Offset = "0x25D2AB0", VA = "0x1825D40B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C8A")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C8B")]
				[Cpp2IlInjected.Address(RVA = "0x25CF180", Offset = "0x25CDB80", VA = "0x1825CF180", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C8C")]
				[Cpp2IlInjected.Address(RVA = "0x25D2170", Offset = "0x25D0B70", VA = "0x1825D2170", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C8D")]
				[Cpp2IlInjected.Address(RVA = "0x25D3320", Offset = "0x25D1D20", VA = "0x1825D3320", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C8E")]
				[Cpp2IlInjected.Address(RVA = "0x25D1220", Offset = "0x25CFC20", VA = "0x1825D1220", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C8F")]
				[Cpp2IlInjected.Address(RVA = "0x25D35D0", Offset = "0x25D1FD0", VA = "0x1825D35D0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C90")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C93")]
				[Cpp2IlInjected.Address(RVA = "0x25CDBF0", Offset = "0x25CC5F0", VA = "0x1825CDBF0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private static readonly MessageParser<MoveInContainerInventory> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[DebuggerNonUserCode]
		public static MessageParser<MoveInContainerInventory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x1394AC0", Offset = "0x13934C0", VA = "0x181394AC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0x13949F0", Offset = "0x13933F0", VA = "0x1813949F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x1394B20", Offset = "0x1393520", VA = "0x181394B20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MoveInContainerInventory()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public MoveInContainerInventory(MoveInContainerInventory other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x1394710", Offset = "0x1393110", VA = "0x181394710", Slot = "10")]
		[DebuggerNonUserCode]
		public MoveInContainerInventory Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			MoveInContainerInventory moveInContainerInventory = default(MoveInContainerInventory);
			moveInContainerInventory.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (moveInContainerInventory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return moveInContainerInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x1394790", Offset = "0x1393190", VA = "0x181394790", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MoveInContainerInventory other)
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

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x1394880", Offset = "0x1393280", VA = "0x181394880", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MoveInContainerInventory other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
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

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x1394810", Offset = "0x1393210", VA = "0x181394810", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x13948E0", Offset = "0x13932E0", VA = "0x1813948E0")]
		static MoveInContainerInventory()
		{
			Func<MoveInContainerInventory> func = default(Func<MoveInContainerInventory>);
			_parser = (MessageParser<MoveInContainerInventory>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
