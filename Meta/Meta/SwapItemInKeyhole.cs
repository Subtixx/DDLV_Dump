using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public sealed class SwapItemInKeyhole : IMessage<SwapItemInKeyhole>, IMessage, IEquatable<SwapItemInKeyhole>, IDeepCloneable<SwapItemInKeyhole>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000143")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400046A")]
				[OriginalName("InvalidKeyhole")]
				InvalidKeyhole,
				[Cpp2IlInjected.Token(Token = "0x400046B")]
				[OriginalName("InvalidSourcePosition")]
				InvalidSourcePosition,
				[Cpp2IlInjected.Token(Token = "0x400046C")]
				[OriginalName("InvalidDestinationPosition")]
				InvalidDestinationPosition,
				[Cpp2IlInjected.Token(Token = "0x400046D")]
				[OriginalName("NotEnoughItems")]
				NotEnoughItems,
				[Cpp2IlInjected.Token(Token = "0x400046E")]
				[OriginalName("NotEnoughSpaceToTransfer")]
				NotEnoughSpaceToTransfer
			}

			[Cpp2IlInjected.Token(Token = "0x2000144")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400046F")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public const int SourceKeyholeGUIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000472")]
				private string sourceKeyholeGUID_;

				[Cpp2IlInjected.Token(Token = "0x4000473")]
				public const int SourcePositionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000474")]
				private int sourcePosition_;

				[Cpp2IlInjected.Token(Token = "0x4000475")]
				public const int DestinationPositionFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000476")]
				private int destinationPosition_;

				[Cpp2IlInjected.Token(Token = "0x4000477")]
				public const int AmountToMoveFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4000478")]
				private static readonly FieldCodec<int?> _single_amountToMove_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000479")]
				private int? amountToMove_;

				[Cpp2IlInjected.Token(Token = "0x1700025B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000DED")]
					[Cpp2IlInjected.Address(RVA = "0x25FB910", Offset = "0x25FA310", VA = "0x1825FB910")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700025C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000DEE")]
					[Cpp2IlInjected.Address(RVA = "0x25FB2F0", Offset = "0x25F9CF0", VA = "0x1825FB2F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700025D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000DEF")]
					[Cpp2IlInjected.Address(RVA = "0x25FC090", Offset = "0x25FAA90", VA = "0x1825FC090", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700025E")]
				[DebuggerNonUserCode]
				public string SourceKeyholeGUID
				{
					[Cpp2IlInjected.Token(Token = "0x6000DF3")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000DF4")]
					[Cpp2IlInjected.Address(RVA = "0x25FC680", Offset = "0x25FB080", VA = "0x1825FC680")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700025F")]
				[DebuggerNonUserCode]
				public int SourcePosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000DF5")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000DF6")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000260")]
				[DebuggerNonUserCode]
				public int DestinationPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000DF7")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000DF8")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000261")]
				[DebuggerNonUserCode]
				public int? AmountToMove
				{
					[Cpp2IlInjected.Token(Token = "0x6000DF9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000DFA")]
					[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000DF0")]
				[Cpp2IlInjected.Address(RVA = "0x25FB210", Offset = "0x25F9C10", VA = "0x1825FB210")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DF1")]
				[Cpp2IlInjected.Address(RVA = "0x25FA6C0", Offset = "0x25F90C0", VA = "0x1825FA6C0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000DF2")]
				[Cpp2IlInjected.Address(RVA = "0x25F4C40", Offset = "0x25F3640", VA = "0x1825F4C40", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DFB")]
				[Cpp2IlInjected.Address(RVA = "0x25F5530", Offset = "0x25F3F30", VA = "0x1825F5530", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DFC")]
				[Cpp2IlInjected.Address(RVA = "0x25F5270", Offset = "0x25F3C70", VA = "0x1825F5270", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DFD")]
				[Cpp2IlInjected.Address(RVA = "0x25F6970", Offset = "0x25F5370", VA = "0x1825F6970", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000DFE")]
				[Cpp2IlInjected.Address(RVA = "0x25F84A0", Offset = "0x25F6EA0", VA = "0x1825F84A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000DFF")]
				[Cpp2IlInjected.Address(RVA = "0x25F9390", Offset = "0x25F7D90", VA = "0x1825F9390", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E00")]
				[Cpp2IlInjected.Address(RVA = "0x25F3FA0", Offset = "0x25F29A0", VA = "0x1825F3FA0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E01")]
				[Cpp2IlInjected.Address(RVA = "0x25F6C60", Offset = "0x25F5660", VA = "0x1825F6C60", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E02")]
				[Cpp2IlInjected.Address(RVA = "0x25F6D30", Offset = "0x25F5730", VA = "0x1825F6D30", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E03")]
				[Cpp2IlInjected.Address(RVA = "0x25F6590", Offset = "0x25F4F90", VA = "0x1825F6590", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E04")]
				[Cpp2IlInjected.Address(RVA = "0x25F8130", Offset = "0x25F6B30", VA = "0x1825F8130", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E05")]
				[Cpp2IlInjected.Address(RVA = "0x25F4780", Offset = "0x25F3180", VA = "0x1825F4780", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E06")]
				[Cpp2IlInjected.Address(RVA = "0x25F8740", Offset = "0x25F7140", VA = "0x1825F8740", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000146")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400047D")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400047E")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400047F")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000480")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000262")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000E0B")]
					[Cpp2IlInjected.Address(RVA = "0x2606380", Offset = "0x2604D80", VA = "0x182606380")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000263")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000E0C")]
					[Cpp2IlInjected.Address(RVA = "0x26060C0", Offset = "0x2604AC0", VA = "0x1826060C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000264")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000E0D")]
					[Cpp2IlInjected.Address(RVA = "0x2606800", Offset = "0x2605200", VA = "0x182606800", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000265")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000E11")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000E12")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000266")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000E13")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000E14")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000267")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000E20")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000E21")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000E0E")]
				[Cpp2IlInjected.Address(RVA = "0x2604DA0", Offset = "0x26037A0", VA = "0x182604DA0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E0F")]
				[Cpp2IlInjected.Address(RVA = "0x2604F50", Offset = "0x2603950", VA = "0x182604F50")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E10")]
				[Cpp2IlInjected.Address(RVA = "0x25FF320", Offset = "0x25FDD20", VA = "0x1825FF320", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E15")]
				[Cpp2IlInjected.Address(RVA = "0x25FFB90", Offset = "0x25FE590", VA = "0x1825FFB90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E16")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E17")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E18")]
				[Cpp2IlInjected.Address(RVA = "0x2603A70", Offset = "0x2602470", VA = "0x182603A70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E19")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E1A")]
				[Cpp2IlInjected.Address(RVA = "0x25FE7E0", Offset = "0x25FD1E0", VA = "0x1825FE7E0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E1B")]
				[Cpp2IlInjected.Address(RVA = "0x2602B10", Offset = "0x2601510", VA = "0x182602B10", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E1C")]
				[Cpp2IlInjected.Address(RVA = "0x2601EA0", Offset = "0x26008A0", VA = "0x182601EA0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E1D")]
				[Cpp2IlInjected.Address(RVA = "0x2601200", Offset = "0x25FFC00", VA = "0x182601200", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E1E")]
				[Cpp2IlInjected.Address(RVA = "0x26038E0", Offset = "0x26022E0", VA = "0x1826038E0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E1F")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E22")]
				[Cpp2IlInjected.Address(RVA = "0x25FDE60", Offset = "0x25FC860", VA = "0x1825FDE60", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private static readonly MessageParser<SwapItemInKeyhole> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		[DebuggerNonUserCode]
		public static MessageParser<SwapItemInKeyhole> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDB")]
			[Cpp2IlInjected.Address(RVA = "0x7879F0", Offset = "0x7863F0", VA = "0x1807879F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDC")]
			[Cpp2IlInjected.Address(RVA = "0x787920", Offset = "0x786320", VA = "0x180787920")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDD")]
			[Cpp2IlInjected.Address(RVA = "0x787A50", Offset = "0x786450", VA = "0x180787A50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SwapItemInKeyhole()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SwapItemInKeyhole(SwapItemInKeyhole other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE0")]
		[Cpp2IlInjected.Address(RVA = "0x787640", Offset = "0x786040", VA = "0x180787640", Slot = "10")]
		[DebuggerNonUserCode]
		public SwapItemInKeyhole Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SwapItemInKeyhole swapItemInKeyhole = default(SwapItemInKeyhole);
			swapItemInKeyhole.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (swapItemInKeyhole._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return swapItemInKeyhole;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE1")]
		[Cpp2IlInjected.Address(RVA = "0x7876C0", Offset = "0x7860C0", VA = "0x1807876C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000DE2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SwapItemInKeyhole other)
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

		[Cpp2IlInjected.Token(Token = "0x6000DE3")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE4")]
		[Cpp2IlInjected.Address(RVA = "0x7877B0", Offset = "0x7861B0", VA = "0x1807877B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SwapItemInKeyhole other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE8")]
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

		[Cpp2IlInjected.Token(Token = "0x6000DE9")]
		[Cpp2IlInjected.Address(RVA = "0x787740", Offset = "0x786140", VA = "0x180787740", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEC")]
		[Cpp2IlInjected.Address(RVA = "0x787810", Offset = "0x786210", VA = "0x180787810")]
		static SwapItemInKeyhole()
		{
			Func<SwapItemInKeyhole> func = default(Func<SwapItemInKeyhole>);
			_parser = (MessageParser<SwapItemInKeyhole>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
