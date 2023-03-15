using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	public sealed class AddItemToKeyhole : IMessage<AddItemToKeyhole>, IMessage, IEquatable<AddItemToKeyhole>, IDeepCloneable<AddItemToKeyhole>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000133")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000426")]
				[OriginalName("InvalidSourceInventory")]
				InvalidSourceInventory,
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				[OriginalName("InvalidSourcePosition")]
				InvalidSourcePosition,
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				[OriginalName("InvalidDestinationKeyhole")]
				InvalidDestinationKeyhole,
				[Cpp2IlInjected.Token(Token = "0x4000429")]
				[OriginalName("InvalidDestinationPosition")]
				InvalidDestinationPosition,
				[Cpp2IlInjected.Token(Token = "0x400042A")]
				[OriginalName("KeyholeAlreadyCompleted")]
				KeyholeAlreadyCompleted,
				[Cpp2IlInjected.Token(Token = "0x400042B")]
				[OriginalName("NotEnoughItems")]
				NotEnoughItems,
				[Cpp2IlInjected.Token(Token = "0x400042C")]
				[OriginalName("NotEnoughSpaceToTransfer")]
				NotEnoughSpaceToTransfer
			}

			[Cpp2IlInjected.Token(Token = "0x2000134")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400042D")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400042E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400042F")]
				public const int SourceInventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000430")]
				private uint sourceInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000431")]
				public const int SourcePositionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000432")]
				private int sourcePosition_;

				[Cpp2IlInjected.Token(Token = "0x4000433")]
				public const int DestinationKeyholeGUIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000434")]
				private string destinationKeyholeGUID_;

				[Cpp2IlInjected.Token(Token = "0x4000435")]
				public const int DestinationPositionFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4000436")]
				private static readonly FieldCodec<int?> _single_destinationPosition_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000437")]
				private int? destinationPosition_;

				[Cpp2IlInjected.Token(Token = "0x4000438")]
				public const int AmountToMoveFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x4000439")]
				private static readonly FieldCodec<int?> _single_amountToMove_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400043A")]
				private int? amountToMove_;

				[Cpp2IlInjected.Token(Token = "0x17000239")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000D4B")]
					[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E900", VA = "0x18075FF00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700023A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000D4C")]
					[Cpp2IlInjected.Address(RVA = "0x75FD00", Offset = "0x75E700", VA = "0x18075FD00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700023B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000D4D")]
					[Cpp2IlInjected.Address(RVA = "0x760080", Offset = "0x75EA80", VA = "0x180760080", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700023C")]
				[DebuggerNonUserCode]
				public uint SourceInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000D51")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000D52")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700023D")]
				[DebuggerNonUserCode]
				public int SourcePosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000D53")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000D54")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700023E")]
				[DebuggerNonUserCode]
				public string DestinationKeyholeGUID
				{
					[Cpp2IlInjected.Token(Token = "0x6000D55")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000D56")]
					[Cpp2IlInjected.Address(RVA = "0x760380", Offset = "0x75ED80", VA = "0x180760380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700023F")]
				[DebuggerNonUserCode]
				public int? DestinationPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000D57")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000D58")]
					[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000240")]
				[DebuggerNonUserCode]
				public int? AmountToMove
				{
					[Cpp2IlInjected.Token(Token = "0x6000D59")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000D5A")]
					[Cpp2IlInjected.Address(RVA = "0x6E5AD0", Offset = "0x6E44D0", VA = "0x1806E5AD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000D4E")]
				[Cpp2IlInjected.Address(RVA = "0x75FB20", Offset = "0x75E520", VA = "0x18075FB20")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D4F")]
				[Cpp2IlInjected.Address(RVA = "0x75FB80", Offset = "0x75E580", VA = "0x18075FB80")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D50")]
				[Cpp2IlInjected.Address(RVA = "0x75DEF0", Offset = "0x75C8F0", VA = "0x18075DEF0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000D5B")]
				[Cpp2IlInjected.Address(RVA = "0x75E380", Offset = "0x75CD80", VA = "0x18075E380", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D5C")]
				[Cpp2IlInjected.Address(RVA = "0x75E1F0", Offset = "0x75CBF0", VA = "0x18075E1F0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D5D")]
				[Cpp2IlInjected.Address(RVA = "0x75E7C0", Offset = "0x75D1C0", VA = "0x18075E7C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D5E")]
				[Cpp2IlInjected.Address(RVA = "0x75EF60", Offset = "0x75D960", VA = "0x18075EF60", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000D5F")]
				[Cpp2IlInjected.Address(RVA = "0x75F4D0", Offset = "0x75DED0", VA = "0x18075F4D0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D60")]
				[Cpp2IlInjected.Address(RVA = "0x75DB30", Offset = "0x75C530", VA = "0x18075DB30", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D61")]
				[Cpp2IlInjected.Address(RVA = "0x75E8E0", Offset = "0x75D2E0", VA = "0x18075E8E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D62")]
				[Cpp2IlInjected.Address(RVA = "0x75E9E0", Offset = "0x75D3E0", VA = "0x18075E9E0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D63")]
				[Cpp2IlInjected.Address(RVA = "0x75E600", Offset = "0x75D000", VA = "0x18075E600", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000D64")]
				[Cpp2IlInjected.Address(RVA = "0x75EC50", Offset = "0x75D650", VA = "0x18075EC50", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D65")]
				[Cpp2IlInjected.Address(RVA = "0x75DDA0", Offset = "0x75C7A0", VA = "0x18075DDA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D66")]
				[Cpp2IlInjected.Address(RVA = "0x75EFC0", Offset = "0x75D9C0", VA = "0x18075EFC0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000136")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400043C")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400043D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400043E")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400043F")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000440")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000441")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000241")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000D6B")]
					[Cpp2IlInjected.Address(RVA = "0x763BA0", Offset = "0x7625A0", VA = "0x180763BA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000242")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000D6C")]
					[Cpp2IlInjected.Address(RVA = "0x763AC0", Offset = "0x7624C0", VA = "0x180763AC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000243")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000D6D")]
					[Cpp2IlInjected.Address(RVA = "0x763D80", Offset = "0x762780", VA = "0x180763D80", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000244")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000D71")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000D72")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000245")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000D73")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000D74")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000246")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000D80")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000D81")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000D6E")]
				[Cpp2IlInjected.Address(RVA = "0x7638C0", Offset = "0x7622C0", VA = "0x1807638C0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D6F")]
				[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x761D40", VA = "0x180763340")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D70")]
				[Cpp2IlInjected.Address(RVA = "0x761510", Offset = "0x75FF10", VA = "0x180761510", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000D75")]
				[Cpp2IlInjected.Address(RVA = "0x761A60", Offset = "0x760460", VA = "0x180761A60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D76")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D77")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D78")]
				[Cpp2IlInjected.Address(RVA = "0x762BD0", Offset = "0x7615D0", VA = "0x180762BD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000D79")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D7A")]
				[Cpp2IlInjected.Address(RVA = "0x761290", Offset = "0x75FC90", VA = "0x180761290", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000D7B")]
				[Cpp2IlInjected.Address(RVA = "0x762370", Offset = "0x760D70", VA = "0x180762370", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D7C")]
				[Cpp2IlInjected.Address(RVA = "0x762710", Offset = "0x761110", VA = "0x180762710", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D7D")]
				[Cpp2IlInjected.Address(RVA = "0x761D70", Offset = "0x760770", VA = "0x180761D70", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000D7E")]
				[Cpp2IlInjected.Address(RVA = "0x762960", Offset = "0x761360", VA = "0x180762960", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D7F")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000D82")]
				[Cpp2IlInjected.Address(RVA = "0x760DA0", Offset = "0x75F7A0", VA = "0x180760DA0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly MessageParser<AddItemToKeyhole> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		[DebuggerNonUserCode]
		public static MessageParser<AddItemToKeyhole> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000D39")]
			[Cpp2IlInjected.Address(RVA = "0x18E5B30", Offset = "0x18E4530", VA = "0x1818E5B30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000D3A")]
			[Cpp2IlInjected.Address(RVA = "0x18E5A60", Offset = "0x18E4460", VA = "0x1818E5A60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000D3B")]
			[Cpp2IlInjected.Address(RVA = "0x18E5B90", Offset = "0x18E4590", VA = "0x1818E5B90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AddItemToKeyhole()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public AddItemToKeyhole(AddItemToKeyhole other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3E")]
		[Cpp2IlInjected.Address(RVA = "0x18E5780", Offset = "0x18E4180", VA = "0x1818E5780", Slot = "10")]
		[DebuggerNonUserCode]
		public AddItemToKeyhole Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			AddItemToKeyhole addItemToKeyhole = default(AddItemToKeyhole);
			addItemToKeyhole.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (addItemToKeyhole._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return addItemToKeyhole;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3F")]
		[Cpp2IlInjected.Address(RVA = "0x18E5800", Offset = "0x18E4200", VA = "0x1818E5800", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000D40")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AddItemToKeyhole other)
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

		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D42")]
		[Cpp2IlInjected.Address(RVA = "0x18E58F0", Offset = "0x18E42F0", VA = "0x1818E58F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AddItemToKeyhole other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D46")]
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

		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x18E5880", Offset = "0x18E4280", VA = "0x1818E5880", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4A")]
		[Cpp2IlInjected.Address(RVA = "0x18E5950", Offset = "0x18E4350", VA = "0x1818E5950")]
		static AddItemToKeyhole()
		{
			Func<AddItemToKeyhole> func = default(Func<AddItemToKeyhole>);
			_parser = (MessageParser<AddItemToKeyhole>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
