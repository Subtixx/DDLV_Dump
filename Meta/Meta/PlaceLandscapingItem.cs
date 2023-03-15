using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public sealed class PlaceLandscapingItem : IMessage<PlaceLandscapingItem>, IMessage, IEquatable<PlaceLandscapingItem>, IDeepCloneable<PlaceLandscapingItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000112")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40003A7")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40003A8")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x40003A9")]
				[OriginalName("VillageAreaLocked")]
				VillageAreaLocked,
				[Cpp2IlInjected.Token(Token = "0x40003AA")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x40003AB")]
				[OriginalName("OverLimits")]
				OverLimits,
				[Cpp2IlInjected.Token(Token = "0x40003AC")]
				[OriginalName("Occupied")]
				Occupied
			}

			[Cpp2IlInjected.Token(Token = "0x2000113")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40003AD")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003AE")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40003AF")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003B0")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x40003B1")]
				public const int GridIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40003B2")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				public const int PosXFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				private int posX_;

				[Cpp2IlInjected.Token(Token = "0x40003B5")]
				public const int PosYFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40003B6")]
				private int posY_;

				[Cpp2IlInjected.Token(Token = "0x40003B7")]
				public const int OrientationFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40003B8")]
				private GridOrientation orientation_;

				[Cpp2IlInjected.Token(Token = "0x40003B9")]
				public const int ClearAreaFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40003BA")]
				private bool clearArea_;

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000C07")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4460", Offset = "0x1DC2E60", VA = "0x181DC4460")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C08")]
					[Cpp2IlInjected.Address(RVA = "0x1DC3F50", Offset = "0x1DC2950", VA = "0x181DC3F50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C09")]
					[Cpp2IlInjected.Address(RVA = "0x1DC47D0", Offset = "0x1DC31D0", VA = "0x181DC47D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000C0D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C0E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000C0F")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C10")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				[DebuggerNonUserCode]
				public int PosX
				{
					[Cpp2IlInjected.Token(Token = "0x6000C11")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C12")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				[DebuggerNonUserCode]
				public int PosY
				{
					[Cpp2IlInjected.Token(Token = "0x6000C13")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C14")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				[DebuggerNonUserCode]
				public GridOrientation Orientation
				{
					[Cpp2IlInjected.Token(Token = "0x6000C15")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(GridOrientation);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C16")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				[DebuggerNonUserCode]
				public bool ClearArea
				{
					[Cpp2IlInjected.Token(Token = "0x6000C17")]
					[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C18")]
					[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000C0A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C0B")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3E00", Offset = "0x1DC2800", VA = "0x181DC3E00")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C0C")]
				[Cpp2IlInjected.Address(RVA = "0x1DBFA70", Offset = "0x1DBE470", VA = "0x181DBFA70", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C19")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0440", Offset = "0x1DBEE40", VA = "0x181DC0440", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C1A")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A7F0", Offset = "0x1D691F0", VA = "0x181D6A7F0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C1B")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0FB0", Offset = "0x1DBF9B0", VA = "0x181DC0FB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C1C")]
				[Cpp2IlInjected.Address(RVA = "0x1DC2450", Offset = "0x1DC0E50", VA = "0x181DC2450", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C1D")]
				[Cpp2IlInjected.Address(RVA = "0x1DC2E10", Offset = "0x1DC1810", VA = "0x181DC2E10", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C1E")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF610", Offset = "0x1DBE010", VA = "0x181DBF610", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C1F")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C780", Offset = "0x1D6B180", VA = "0x181D6C780", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C20")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C600", Offset = "0x1D6B000", VA = "0x181D6C600", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C21")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0B20", Offset = "0x1DBF520", VA = "0x181DC0B20", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C22")]
				[Cpp2IlInjected.Address(RVA = "0x1DC21D0", Offset = "0x1DC0BD0", VA = "0x181DC21D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C23")]
				[Cpp2IlInjected.Address(RVA = "0x1D69D40", Offset = "0x1D68740", VA = "0x181D69D40", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000115")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40003BC")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003BD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40003BE")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003BF")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40003C0")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40003C1")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40003C2")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40003C3")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000C28")]
					[Cpp2IlInjected.Address(RVA = "0x1DCEF10", Offset = "0x1DCD910", VA = "0x181DCEF10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C29")]
					[Cpp2IlInjected.Address(RVA = "0x1DCEB70", Offset = "0x1DCD570", VA = "0x181DCEB70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000C2A")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF0F0", Offset = "0x1DCDAF0", VA = "0x181DCF0F0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000C2E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C2F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000C30")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000C31")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000C32")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C33")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000C3F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000C40")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000C2B")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE200", Offset = "0x1DCCC00", VA = "0x181DCE200")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C2C")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE240", Offset = "0x1DCCC40", VA = "0x181DCE240")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C2D")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8810", Offset = "0x1DC7210", VA = "0x181DC8810", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C34")]
				[Cpp2IlInjected.Address(RVA = "0x1DC95D0", Offset = "0x1DC7FD0", VA = "0x181DC95D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C35")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C36")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C37")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCD20", Offset = "0x1DCB720", VA = "0x181DCCD20", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C38")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCEA0", Offset = "0x1DCB8A0", VA = "0x181DCCEA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C39")]
				[Cpp2IlInjected.Address(RVA = "0x1DC80D0", Offset = "0x1DC6AD0", VA = "0x181DC80D0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C3A")]
				[Cpp2IlInjected.Address(RVA = "0x1DCBD00", Offset = "0x1DCA700", VA = "0x181DCBD00", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C3B")]
				[Cpp2IlInjected.Address(RVA = "0x1DCAE40", Offset = "0x1DC9840", VA = "0x181DCAE40", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C3C")]
				[Cpp2IlInjected.Address(RVA = "0x1DCA340", Offset = "0x1DC8D40", VA = "0x181DCA340", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000C3D")]
				[Cpp2IlInjected.Address(RVA = "0x1DCC1F0", Offset = "0x1DCABF0", VA = "0x181DCC1F0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C3E")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C41")]
				[Cpp2IlInjected.Address(RVA = "0x1DC70A0", Offset = "0x1DC5AA0", VA = "0x181DC70A0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly MessageParser<PlaceLandscapingItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		[DebuggerNonUserCode]
		public static MessageParser<PlaceLandscapingItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF5")]
			[Cpp2IlInjected.Address(RVA = "0x7B8DC0", Offset = "0x7B77C0", VA = "0x1807B8DC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF6")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B76F0", VA = "0x1807B8CF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF7")]
			[Cpp2IlInjected.Address(RVA = "0x7B8E20", Offset = "0x7B7820", VA = "0x1807B8E20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PlaceLandscapingItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PlaceLandscapingItem(PlaceLandscapingItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A10", Offset = "0x7B7410", VA = "0x1807B8A10", Slot = "10")]
		[DebuggerNonUserCode]
		public PlaceLandscapingItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PlaceLandscapingItem placeLandscapingItem = default(PlaceLandscapingItem);
			placeLandscapingItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (placeLandscapingItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return placeLandscapingItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A90", Offset = "0x7B7490", VA = "0x1807B8A90", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PlaceLandscapingItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B80", Offset = "0x7B7580", VA = "0x1807B8B80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PlaceLandscapingItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
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

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B10", Offset = "0x7B7510", VA = "0x1807B8B10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BE0", Offset = "0x7B75E0", VA = "0x1807B8BE0")]
		static PlaceLandscapingItem()
		{
			Func<PlaceLandscapingItem> func = default(Func<PlaceLandscapingItem>);
			_parser = (MessageParser<PlaceLandscapingItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
