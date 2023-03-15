using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public sealed class RemoveItemFromKeyhole : IMessage<RemoveItemFromKeyhole>, IMessage, IEquatable<RemoveItemFromKeyhole>, IDeepCloneable<RemoveItemFromKeyhole>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200013A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200013B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000447")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000448")]
				[OriginalName("InvalidSourceKeyhole")]
				InvalidSourceKeyhole,
				[Cpp2IlInjected.Token(Token = "0x4000449")]
				[OriginalName("InvalidSourcePosition")]
				InvalidSourcePosition,
				[Cpp2IlInjected.Token(Token = "0x400044A")]
				[OriginalName("InvalidDestinationInventory")]
				InvalidDestinationInventory,
				[Cpp2IlInjected.Token(Token = "0x400044B")]
				[OriginalName("InvalidDestinationPosition")]
				InvalidDestinationPosition,
				[Cpp2IlInjected.Token(Token = "0x400044C")]
				[OriginalName("NotEnoughItems")]
				NotEnoughItems,
				[Cpp2IlInjected.Token(Token = "0x400044D")]
				[OriginalName("NotEnoughSpaceToTransfer")]
				NotEnoughSpaceToTransfer
			}

			[Cpp2IlInjected.Token(Token = "0x200013C")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400044E")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400044F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000450")]
				public const int DestinationInventoryIDFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4000451")]
				private static readonly FieldCodec<uint?> _single_destinationInventoryID_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000452")]
				private uint? destinationInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000453")]
				public const int DestinationPositionFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4000454")]
				private static readonly FieldCodec<int?> _single_destinationPosition_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000455")]
				private int? destinationPosition_;

				[Cpp2IlInjected.Token(Token = "0x4000456")]
				public const int SourceKeyholeGUIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000457")]
				private string sourceKeyholeGUID_;

				[Cpp2IlInjected.Token(Token = "0x4000458")]
				public const int SourcePositionFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000459")]
				private int sourcePosition_;

				[Cpp2IlInjected.Token(Token = "0x400045A")]
				public const int AmountToMoveFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x400045B")]
				private static readonly FieldCodec<int?> _single_amountToMove_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x400045C")]
				private int? amountToMove_;

				[Cpp2IlInjected.Token(Token = "0x1700024A")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000D9C")]
					[Cpp2IlInjected.Address(RVA = "0x200C550", Offset = "0x200AF50", VA = "0x18200C550")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000D9D")]
					[Cpp2IlInjected.Address(RVA = "0x200BF30", Offset = "0x200A930", VA = "0x18200BF30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000D9E")]
					[Cpp2IlInjected.Address(RVA = "0x200C8B0", Offset = "0x200B2B0", VA = "0x18200C8B0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024D")]
				[DebuggerNonUserCode]
				public uint? DestinationInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000DA2")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000DA3")]
					[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024E")]
				[DebuggerNonUserCode]
				public int? DestinationPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000DA4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000DA5")]
					[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700024F")]
				[DebuggerNonUserCode]
				public string SourceKeyholeGUID
				{
					[Cpp2IlInjected.Token(Token = "0x6000DA6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000DA7")]
					[Cpp2IlInjected.Address(RVA = "0x200CF20", Offset = "0x200B920", VA = "0x18200CF20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000250")]
				[DebuggerNonUserCode]
				public int SourcePosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000DA8")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000DA9")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000251")]
				[DebuggerNonUserCode]
				public int? AmountToMove
				{
					[Cpp2IlInjected.Token(Token = "0x6000DAA")]
					[Cpp2IlInjected.Address(RVA = "0x200BB20", Offset = "0x200A520", VA = "0x18200BB20")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000DAB")]
					[Cpp2IlInjected.Address(RVA = "0xEFF4D0", Offset = "0xEFDED0", VA = "0x180EFF4D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000D9F")]
				[Cpp2IlInjected.Address(RVA = "0x200B6D0", Offset = "0x200A0D0", VA = "0x18200B6D0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DA0")]
				[Cpp2IlInjected.Address(RVA = "0x200B980", Offset = "0x200A380", VA = "0x18200B980")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DA1")]
				[Cpp2IlInjected.Address(RVA = "0x2005890", Offset = "0x2004290", VA = "0x182005890", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DAC")]
				[Cpp2IlInjected.Address(RVA = "0x2006930", Offset = "0x2005330", VA = "0x182006930", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DAD")]
				[Cpp2IlInjected.Address(RVA = "0x2006500", Offset = "0x2004F00", VA = "0x182006500", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DAE")]
				[Cpp2IlInjected.Address(RVA = "0x2007710", Offset = "0x2006110", VA = "0x182007710", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DAF")]
				[Cpp2IlInjected.Address(RVA = "0x20095D0", Offset = "0x2007FD0", VA = "0x1820095D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB0")]
				[Cpp2IlInjected.Address(RVA = "0x200A380", Offset = "0x2008D80", VA = "0x18200A380", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB1")]
				[Cpp2IlInjected.Address(RVA = "0x2004B10", Offset = "0x2003510", VA = "0x182004B10", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB2")]
				[Cpp2IlInjected.Address(RVA = "0x2007BC0", Offset = "0x20065C0", VA = "0x182007BC0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB3")]
				[Cpp2IlInjected.Address(RVA = "0x2007950", Offset = "0x2006350", VA = "0x182007950", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB4")]
				[Cpp2IlInjected.Address(RVA = "0x2007430", Offset = "0x2005E30", VA = "0x182007430", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB5")]
				[Cpp2IlInjected.Address(RVA = "0x20089A0", Offset = "0x20073A0", VA = "0x1820089A0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB6")]
				[Cpp2IlInjected.Address(RVA = "0x2005530", Offset = "0x2003F30", VA = "0x182005530", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DB7")]
				[Cpp2IlInjected.Address(RVA = "0x2009EC0", Offset = "0x20088C0", VA = "0x182009EC0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200013E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400045F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000460")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000461")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000462")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000252")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000DBC")]
					[Cpp2IlInjected.Address(RVA = "0x2019B80", Offset = "0x2018580", VA = "0x182019B80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000253")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000DBD")]
					[Cpp2IlInjected.Address(RVA = "0x2019360", Offset = "0x2017D60", VA = "0x182019360")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000254")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000DBE")]
					[Cpp2IlInjected.Address(RVA = "0x201A060", Offset = "0x2018A60", VA = "0x18201A060", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000255")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000DC2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000DC3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000256")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000DC4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000DC5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000257")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000DD1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000DD2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000DBF")]
				[Cpp2IlInjected.Address(RVA = "0x20187B0", Offset = "0x20171B0", VA = "0x1820187B0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DC0")]
				[Cpp2IlInjected.Address(RVA = "0x2018DD0", Offset = "0x20177D0", VA = "0x182018DD0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DC1")]
				[Cpp2IlInjected.Address(RVA = "0x2010AE0", Offset = "0x200F4E0", VA = "0x182010AE0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DC6")]
				[Cpp2IlInjected.Address(RVA = "0x20122C0", Offset = "0x2010CC0", VA = "0x1820122C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DC7")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DC8")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DC9")]
				[Cpp2IlInjected.Address(RVA = "0x20165D0", Offset = "0x2014FD0", VA = "0x1820165D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DCA")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DCB")]
				[Cpp2IlInjected.Address(RVA = "0x200F960", Offset = "0x200E360", VA = "0x18200F960", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DCC")]
				[Cpp2IlInjected.Address(RVA = "0x2014E20", Offset = "0x2013820", VA = "0x182014E20", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DCD")]
				[Cpp2IlInjected.Address(RVA = "0x2015150", Offset = "0x2013B50", VA = "0x182015150", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DCE")]
				[Cpp2IlInjected.Address(RVA = "0x2013090", Offset = "0x2011A90", VA = "0x182013090", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DCF")]
				[Cpp2IlInjected.Address(RVA = "0x2016000", Offset = "0x2014A00", VA = "0x182016000", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DD0")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DD3")]
				[Cpp2IlInjected.Address(RVA = "0x200F700", Offset = "0x200E100", VA = "0x18200F700", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private static readonly MessageParser<RemoveItemFromKeyhole> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		[DebuggerNonUserCode]
		public static MessageParser<RemoveItemFromKeyhole> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000D8A")]
			[Cpp2IlInjected.Address(RVA = "0x5C9960", Offset = "0x5C8360", VA = "0x1805C9960")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000D8B")]
			[Cpp2IlInjected.Address(RVA = "0x5C9890", Offset = "0x5C8290", VA = "0x1805C9890")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000D8C")]
			[Cpp2IlInjected.Address(RVA = "0x5C99C0", Offset = "0x5C83C0", VA = "0x1805C99C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D8D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public RemoveItemFromKeyhole()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D8E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public RemoveItemFromKeyhole(RemoveItemFromKeyhole other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D8F")]
		[Cpp2IlInjected.Address(RVA = "0x5C95B0", Offset = "0x5C7FB0", VA = "0x1805C95B0", Slot = "10")]
		[DebuggerNonUserCode]
		public RemoveItemFromKeyhole Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			RemoveItemFromKeyhole removeItemFromKeyhole = default(RemoveItemFromKeyhole);
			removeItemFromKeyhole.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (removeItemFromKeyhole._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return removeItemFromKeyhole;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D90")]
		[Cpp2IlInjected.Address(RVA = "0x5C9630", Offset = "0x5C8030", VA = "0x1805C9630", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000D91")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RemoveItemFromKeyhole other)
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

		[Cpp2IlInjected.Token(Token = "0x6000D92")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D93")]
		[Cpp2IlInjected.Address(RVA = "0x5C9720", Offset = "0x5C8120", VA = "0x1805C9720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D94")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D95")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D96")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveItemFromKeyhole other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
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

		[Cpp2IlInjected.Token(Token = "0x6000D98")]
		[Cpp2IlInjected.Address(RVA = "0x5C96B0", Offset = "0x5C80B0", VA = "0x1805C96B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D99")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9B")]
		[Cpp2IlInjected.Address(RVA = "0x5C9780", Offset = "0x5C8180", VA = "0x1805C9780")]
		static RemoveItemFromKeyhole()
		{
			Func<RemoveItemFromKeyhole> func = default(Func<RemoveItemFromKeyhole>);
			_parser = (MessageParser<RemoveItemFromKeyhole>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
