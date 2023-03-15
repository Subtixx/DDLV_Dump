using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public sealed class SwitchGridObjectGrid : IMessage<SwitchGridObjectGrid>, IMessage, IEquatable<SwitchGridObjectGrid>, IDeepCloneable<SwitchGridObjectGrid>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000162")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000163")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40004D3")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40004D4")]
				[OriginalName("InvalidOldGrid")]
				InvalidOldGrid,
				[Cpp2IlInjected.Token(Token = "0x40004D5")]
				[OriginalName("InvalidOldGridObjectID")]
				InvalidOldGridObjectId,
				[Cpp2IlInjected.Token(Token = "0x40004D6")]
				[OriginalName("InvalidNewGrid")]
				InvalidNewGrid,
				[Cpp2IlInjected.Token(Token = "0x40004D7")]
				[OriginalName("InvalidTransform")]
				InvalidTransform
			}

			[Cpp2IlInjected.Token(Token = "0x2000164")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40004D8")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40004D9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40004DA")]
				public const int OldGridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004DB")]
				private uint oldGridID_;

				[Cpp2IlInjected.Token(Token = "0x40004DC")]
				public const int OldGridObjectIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40004DD")]
				private uint oldGridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x40004DE")]
				public const int NewGridIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004DF")]
				private uint newGridID_;

				[Cpp2IlInjected.Token(Token = "0x40004E0")]
				public const int NewXFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40004E1")]
				private int newX_;

				[Cpp2IlInjected.Token(Token = "0x40004E2")]
				public const int NewYFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004E3")]
				private int newY_;

				[Cpp2IlInjected.Token(Token = "0x40004E4")]
				public const int NewOrientationFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40004E5")]
				private GridOrientation newOrientation_;

				[Cpp2IlInjected.Token(Token = "0x40004E6")]
				public const int ClearAreaFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40004E7")]
				private bool clearArea_;

				[Cpp2IlInjected.Token(Token = "0x1700029B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000F27")]
					[Cpp2IlInjected.Address(RVA = "0x25FB970", Offset = "0x25FA370", VA = "0x1825FB970")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700029C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000F28")]
					[Cpp2IlInjected.Address(RVA = "0x25FB670", Offset = "0x25FA070", VA = "0x1825FB670")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700029D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000F29")]
					[Cpp2IlInjected.Address(RVA = "0x25FBE50", Offset = "0x25FA850", VA = "0x1825FBE50", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700029E")]
				[DebuggerNonUserCode]
				public uint OldGridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F2D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F2E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700029F")]
				[DebuggerNonUserCode]
				public uint OldGridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F2F")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F30")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A0")]
				[DebuggerNonUserCode]
				public uint NewGridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F31")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F32")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A1")]
				[DebuggerNonUserCode]
				public int NewX
				{
					[Cpp2IlInjected.Token(Token = "0x6000F33")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F34")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A2")]
				[DebuggerNonUserCode]
				public int NewY
				{
					[Cpp2IlInjected.Token(Token = "0x6000F35")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F36")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A3")]
				[DebuggerNonUserCode]
				public GridOrientation NewOrientation
				{
					[Cpp2IlInjected.Token(Token = "0x6000F37")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(GridOrientation);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F38")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A4")]
				[DebuggerNonUserCode]
				public bool ClearArea
				{
					[Cpp2IlInjected.Token(Token = "0x6000F39")]
					[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F3A")]
					[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000F2A")]
				[Cpp2IlInjected.Address(RVA = "0x25FA780", Offset = "0x25F9180", VA = "0x1825FA780")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F2B")]
				[Cpp2IlInjected.Address(RVA = "0x25FB170", Offset = "0x25F9B70", VA = "0x1825FB170")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F2C")]
				[Cpp2IlInjected.Address(RVA = "0x25F4FF0", Offset = "0x25F39F0", VA = "0x1825F4FF0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F3B")]
				[Cpp2IlInjected.Address(RVA = "0x25F5850", Offset = "0x25F4250", VA = "0x1825F5850", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F3C")]
				[Cpp2IlInjected.Address(RVA = "0x25F5D50", Offset = "0x25F4750", VA = "0x1825F5D50", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F3D")]
				[Cpp2IlInjected.Address(RVA = "0x25F6A60", Offset = "0x25F5460", VA = "0x1825F6A60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F3E")]
				[Cpp2IlInjected.Address(RVA = "0x25F85C0", Offset = "0x25F6FC0", VA = "0x1825F85C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F3F")]
				[Cpp2IlInjected.Address(RVA = "0x25F9230", Offset = "0x25F7C30", VA = "0x1825F9230", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F40")]
				[Cpp2IlInjected.Address(RVA = "0x25F4320", Offset = "0x25F2D20", VA = "0x1825F4320", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F41")]
				[Cpp2IlInjected.Address(RVA = "0x25F74C0", Offset = "0x25F5EC0", VA = "0x1825F74C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F42")]
				[Cpp2IlInjected.Address(RVA = "0x25F7550", Offset = "0x25F5F50", VA = "0x1825F7550", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F43")]
				[Cpp2IlInjected.Address(RVA = "0x25F66A0", Offset = "0x25F50A0", VA = "0x1825F66A0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F44")]
				[Cpp2IlInjected.Address(RVA = "0x25F76E0", Offset = "0x25F60E0", VA = "0x1825F76E0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F45")]
				[Cpp2IlInjected.Address(RVA = "0x25F4940", Offset = "0x25F3340", VA = "0x1825F4940", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F46")]
				[Cpp2IlInjected.Address(RVA = "0x25F8840", Offset = "0x25F7240", VA = "0x1825F8840", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000166")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40004E9")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40004EA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40004EB")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004EC")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40004ED")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004EE")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170002A5")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000F4B")]
					[Cpp2IlInjected.Address(RVA = "0x2606440", Offset = "0x2604E40", VA = "0x182606440")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000F4C")]
					[Cpp2IlInjected.Address(RVA = "0x2605F40", Offset = "0x2604940", VA = "0x182605F40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000F4D")]
					[Cpp2IlInjected.Address(RVA = "0x2606B00", Offset = "0x2605500", VA = "0x182606B00", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A8")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000F51")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F52")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002A9")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000F53")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000F54")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002AA")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000F60")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F61")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000F4E")]
				[Cpp2IlInjected.Address(RVA = "0x2605610", Offset = "0x2604010", VA = "0x182605610")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F4F")]
				[Cpp2IlInjected.Address(RVA = "0x26050C0", Offset = "0x2603AC0", VA = "0x1826050C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F50")]
				[Cpp2IlInjected.Address(RVA = "0x25FF000", Offset = "0x25FDA00", VA = "0x1825FF000", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F55")]
				[Cpp2IlInjected.Address(RVA = "0x25FFC40", Offset = "0x25FE640", VA = "0x1825FFC40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F56")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F57")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F58")]
				[Cpp2IlInjected.Address(RVA = "0x2603A10", Offset = "0x2602410", VA = "0x182603A10", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F59")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F5A")]
				[Cpp2IlInjected.Address(RVA = "0x25FE4E0", Offset = "0x25FCEE0", VA = "0x1825FE4E0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F5B")]
				[Cpp2IlInjected.Address(RVA = "0x2602870", Offset = "0x2601270", VA = "0x182602870", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F5C")]
				[Cpp2IlInjected.Address(RVA = "0x2601A20", Offset = "0x2600420", VA = "0x182601A20", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F5D")]
				[Cpp2IlInjected.Address(RVA = "0x2600CC0", Offset = "0x25FF6C0", VA = "0x182600CC0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F5E")]
				[Cpp2IlInjected.Address(RVA = "0x26031E0", Offset = "0x2601BE0", VA = "0x1826031E0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F5F")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F62")]
				[Cpp2IlInjected.Address(RVA = "0x25FDFA0", Offset = "0x25FC9A0", VA = "0x1825FDFA0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private static readonly MessageParser<SwitchGridObjectGrid> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		[DebuggerNonUserCode]
		public static MessageParser<SwitchGridObjectGrid> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F15")]
			[Cpp2IlInjected.Address(RVA = "0x787F10", Offset = "0x786910", VA = "0x180787F10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F16")]
			[Cpp2IlInjected.Address(RVA = "0x787E40", Offset = "0x786840", VA = "0x180787E40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F17")]
			[Cpp2IlInjected.Address(RVA = "0x787F70", Offset = "0x786970", VA = "0x180787F70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SwitchGridObjectGrid()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SwitchGridObjectGrid(SwitchGridObjectGrid other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0x787B60", Offset = "0x786560", VA = "0x180787B60", Slot = "10")]
		[DebuggerNonUserCode]
		public SwitchGridObjectGrid Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SwitchGridObjectGrid switchGridObjectGrid = default(SwitchGridObjectGrid);
			switchGridObjectGrid.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (switchGridObjectGrid._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return switchGridObjectGrid;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x787BE0", Offset = "0x7865E0", VA = "0x180787BE0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SwitchGridObjectGrid other)
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

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1E")]
		[Cpp2IlInjected.Address(RVA = "0x787CD0", Offset = "0x7866D0", VA = "0x180787CD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F20")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F21")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SwitchGridObjectGrid other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F22")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F23")]
		[Cpp2IlInjected.Address(RVA = "0x787C60", Offset = "0x786660", VA = "0x180787C60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F24")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F25")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F26")]
		[Cpp2IlInjected.Address(RVA = "0x787D30", Offset = "0x786730", VA = "0x180787D30")]
		static SwitchGridObjectGrid()
		{
			Func<SwitchGridObjectGrid> func = default(Func<SwitchGridObjectGrid>);
			_parser = (MessageParser<SwitchGridObjectGrid>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
