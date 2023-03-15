using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public sealed class UpdateGridObjectTransform : IMessage<UpdateGridObjectTransform>, IMessage, IEquatable<UpdateGridObjectTransform>, IDeepCloneable<UpdateGridObjectTransform>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200015A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200015B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x40004B7")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId,
				[Cpp2IlInjected.Token(Token = "0x40004B8")]
				[OriginalName("InvalidTransform")]
				InvalidTransform
			}

			[Cpp2IlInjected.Token(Token = "0x200015C")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40004B9")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40004BA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40004BB")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				public const int GridObjectIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40004BE")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x40004BF")]
				public const int NewXFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004C0")]
				private int newX_;

				[Cpp2IlInjected.Token(Token = "0x40004C1")]
				public const int NewYFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40004C2")]
				private int newY_;

				[Cpp2IlInjected.Token(Token = "0x40004C3")]
				public const int NewOrientationFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004C4")]
				private GridOrientation newOrientation_;

				[Cpp2IlInjected.Token(Token = "0x40004C5")]
				public const int ClearAreaFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40004C6")]
				private bool clearArea_;

				[Cpp2IlInjected.Token(Token = "0x17000289")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000ED4")]
					[Cpp2IlInjected.Address(RVA = "0x1D70FA0", Offset = "0x1D6F9A0", VA = "0x181D70FA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700028A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000ED5")]
					[Cpp2IlInjected.Address(RVA = "0x1D708E0", Offset = "0x1D6F2E0", VA = "0x181D708E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700028B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000ED6")]
					[Cpp2IlInjected.Address(RVA = "0x1D71960", Offset = "0x1D70360", VA = "0x181D71960", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700028C")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000EDA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000EDB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700028D")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000EDC")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000EDD")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700028E")]
				[DebuggerNonUserCode]
				public int NewX
				{
					[Cpp2IlInjected.Token(Token = "0x6000EDE")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000EDF")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700028F")]
				[DebuggerNonUserCode]
				public int NewY
				{
					[Cpp2IlInjected.Token(Token = "0x6000EE0")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000EE1")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000290")]
				[DebuggerNonUserCode]
				public GridOrientation NewOrientation
				{
					[Cpp2IlInjected.Token(Token = "0x6000EE2")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(GridOrientation);
					}
					[Cpp2IlInjected.Token(Token = "0x6000EE3")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000291")]
				[DebuggerNonUserCode]
				public bool ClearArea
				{
					[Cpp2IlInjected.Token(Token = "0x6000EE4")]
					[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000EE5")]
					[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000ED7")]
				[Cpp2IlInjected.Address(RVA = "0x1D70070", Offset = "0x1D6EA70", VA = "0x181D70070")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000ED8")]
				[Cpp2IlInjected.Address(RVA = "0x1D6FFA0", Offset = "0x1D6E9A0", VA = "0x181D6FFA0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000ED9")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A350", Offset = "0x1D68D50", VA = "0x181D6A350", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000EE6")]
				[Cpp2IlInjected.Address(RVA = "0x1D6AD30", Offset = "0x1D69730", VA = "0x181D6AD30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000EE7")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A7F0", Offset = "0x1D691F0", VA = "0x181D6A7F0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000EE8")]
				[Cpp2IlInjected.Address(RVA = "0x1D6BEB0", Offset = "0x1D6A8B0", VA = "0x181D6BEB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000EE9")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D770", Offset = "0x1D6C170", VA = "0x181D6D770", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000EEA")]
				[Cpp2IlInjected.Address(RVA = "0x1D6E8F0", Offset = "0x1D6D2F0", VA = "0x181D6E8F0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000EEB")]
				[Cpp2IlInjected.Address(RVA = "0x1D693F0", Offset = "0x1D67DF0", VA = "0x181D693F0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000EEC")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C780", Offset = "0x1D6B180", VA = "0x181D6C780", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000EED")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C600", Offset = "0x1D6B000", VA = "0x181D6C600", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000EEE")]
				[Cpp2IlInjected.Address(RVA = "0x1D6BCB0", Offset = "0x1D6A6B0", VA = "0x181D6BCB0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000EEF")]
				[Cpp2IlInjected.Address(RVA = "0x1D6CBB0", Offset = "0x1D6B5B0", VA = "0x181D6CBB0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000EF0")]
				[Cpp2IlInjected.Address(RVA = "0x1D69D40", Offset = "0x1D68740", VA = "0x181D69D40", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000EF1")]
				[Cpp2IlInjected.Address(RVA = "0x1D6DC40", Offset = "0x1D6C640", VA = "0x181D6DC40", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200015E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40004CA")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004CB")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40004CC")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004CD")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000292")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000EF6")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F0D0", Offset = "0x1D7DAD0", VA = "0x181D7F0D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000293")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000EF7")]
					[Cpp2IlInjected.Address(RVA = "0x1D7EE50", Offset = "0x1D7D850", VA = "0x181D7EE50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000294")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000EF8")]
					[Cpp2IlInjected.Address(RVA = "0x1D7FDB0", Offset = "0x1D7E7B0", VA = "0x181D7FDB0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000295")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000EFC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000EFD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000296")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000EFE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000EFF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000297")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000F0B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F0C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000EF9")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E4F0", Offset = "0x1D7CEF0", VA = "0x181D7E4F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000EFA")]
				[Cpp2IlInjected.Address(RVA = "0x1D7D510", Offset = "0x1D7BF10", VA = "0x181D7D510")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000EFB")]
				[Cpp2IlInjected.Address(RVA = "0x1D767D0", Offset = "0x1D751D0", VA = "0x181D767D0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F00")]
				[Cpp2IlInjected.Address(RVA = "0x1D77DA0", Offset = "0x1D767A0", VA = "0x181D77DA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F01")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F02")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F03")]
				[Cpp2IlInjected.Address(RVA = "0x1D7BEC0", Offset = "0x1D7A8C0", VA = "0x181D7BEC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F04")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F05")]
				[Cpp2IlInjected.Address(RVA = "0x1D75DE0", Offset = "0x1D747E0", VA = "0x181D75DE0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F06")]
				[Cpp2IlInjected.Address(RVA = "0x1D7AD50", Offset = "0x1D79750", VA = "0x181D7AD50", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F07")]
				[Cpp2IlInjected.Address(RVA = "0x1D7AEB0", Offset = "0x1D798B0", VA = "0x181D7AEB0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F08")]
				[Cpp2IlInjected.Address(RVA = "0x1D78770", Offset = "0x1D77170", VA = "0x181D78770", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F09")]
				[Cpp2IlInjected.Address(RVA = "0x1D7B5F0", Offset = "0x1D79FF0", VA = "0x181D7B5F0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F0A")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F0D")]
				[Cpp2IlInjected.Address(RVA = "0x1D72280", Offset = "0x1D70C80", VA = "0x181D72280", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private static readonly MessageParser<UpdateGridObjectTransform> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateGridObjectTransform> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000EC2")]
			[Cpp2IlInjected.Address(RVA = "0x15DA860", Offset = "0x15D9260", VA = "0x1815DA860")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000EC3")]
			[Cpp2IlInjected.Address(RVA = "0x15DA790", Offset = "0x15D9190", VA = "0x1815DA790")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000EC4")]
			[Cpp2IlInjected.Address(RVA = "0x15DA8C0", Offset = "0x15D92C0", VA = "0x1815DA8C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UpdateGridObjectTransform()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UpdateGridObjectTransform(UpdateGridObjectTransform other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC7")]
		[Cpp2IlInjected.Address(RVA = "0x15DA4B0", Offset = "0x15D8EB0", VA = "0x1815DA4B0", Slot = "10")]
		[DebuggerNonUserCode]
		public UpdateGridObjectTransform Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UpdateGridObjectTransform updateGridObjectTransform = default(UpdateGridObjectTransform);
			updateGridObjectTransform.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (updateGridObjectTransform._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return updateGridObjectTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC8")]
		[Cpp2IlInjected.Address(RVA = "0x15DA530", Offset = "0x15D8F30", VA = "0x1815DA530", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000EC9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpdateGridObjectTransform other)
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

		[Cpp2IlInjected.Token(Token = "0x6000ECA")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECB")]
		[Cpp2IlInjected.Address(RVA = "0x15DA620", Offset = "0x15D9020", VA = "0x1815DA620", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateGridObjectTransform other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECF")]
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

		[Cpp2IlInjected.Token(Token = "0x6000ED0")]
		[Cpp2IlInjected.Address(RVA = "0x15DA5B0", Offset = "0x15D8FB0", VA = "0x1815DA5B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED3")]
		[Cpp2IlInjected.Address(RVA = "0x15DA680", Offset = "0x15D9080", VA = "0x1815DA680")]
		static UpdateGridObjectTransform()
		{
			Func<UpdateGridObjectTransform> func = default(Func<UpdateGridObjectTransform>);
			_parser = (MessageParser<UpdateGridObjectTransform>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
