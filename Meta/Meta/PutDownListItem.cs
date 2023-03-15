using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public sealed class PutDownListItem : IMessage<PutDownListItem>, IMessage, IEquatable<PutDownListItem>, IDeepCloneable<PutDownListItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000102")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000368")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				[OriginalName("InvalidInventory")]
				InvalidInventory,
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				[OriginalName("OverLimits")]
				OverLimits,
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				[OriginalName("Occupied")]
				Occupied
			}

			[Cpp2IlInjected.Token(Token = "0x2000103")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400036E")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400036F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000370")]
				public const int InventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000371")]
				private uint inventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public const int ItemIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public const int GridIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public const int PosXFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				private int posX_;

				[Cpp2IlInjected.Token(Token = "0x4000378")]
				public const int PosYFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				private int posY_;

				[Cpp2IlInjected.Token(Token = "0x400037A")]
				public const int OrientationFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				private GridOrientation orientation_;

				[Cpp2IlInjected.Token(Token = "0x400037C")]
				public const int ClearAreaFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				private bool clearArea_;

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000B61")]
					[Cpp2IlInjected.Address(RVA = "0x2C12970", Offset = "0x2C11370", VA = "0x182C12970")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B62")]
					[Cpp2IlInjected.Address(RVA = "0x2C12810", Offset = "0x2C11210", VA = "0x182C12810")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B63")]
					[Cpp2IlInjected.Address(RVA = "0x2C13030", Offset = "0x2C11A30", VA = "0x182C13030", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				[DebuggerNonUserCode]
				public uint InventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000B67")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B68")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000B69")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B6A")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000B6B")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B6C")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				[DebuggerNonUserCode]
				public int PosX
				{
					[Cpp2IlInjected.Token(Token = "0x6000B6D")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B6E")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				[DebuggerNonUserCode]
				public int PosY
				{
					[Cpp2IlInjected.Token(Token = "0x6000B6F")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B70")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				[DebuggerNonUserCode]
				public GridOrientation Orientation
				{
					[Cpp2IlInjected.Token(Token = "0x6000B71")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(GridOrientation);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B72")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				[DebuggerNonUserCode]
				public bool ClearArea
				{
					[Cpp2IlInjected.Token(Token = "0x6000B73")]
					[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B74")]
					[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B64")]
				[Cpp2IlInjected.Address(RVA = "0x2C11F50", Offset = "0x2C10950", VA = "0x182C11F50")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B65")]
				[Cpp2IlInjected.Address(RVA = "0x2C11E30", Offset = "0x2C10830", VA = "0x182C11E30")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B66")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C3B0", Offset = "0x2C0ADB0", VA = "0x182C0C3B0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B75")]
				[Cpp2IlInjected.Address(RVA = "0x2C0CDD0", Offset = "0x2C0B7D0", VA = "0x182C0CDD0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B76")]
				[Cpp2IlInjected.Address(RVA = "0x25F5D50", Offset = "0x25F4750", VA = "0x1825F5D50", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B77")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D9A0", Offset = "0x2C0C3A0", VA = "0x182C0D9A0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B78")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F3A0", Offset = "0x2C0DDA0", VA = "0x182C0F3A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B79")]
				[Cpp2IlInjected.Address(RVA = "0x2C10BC0", Offset = "0x2C0F5C0", VA = "0x182C10BC0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7A")]
				[Cpp2IlInjected.Address(RVA = "0x2C0B0A0", Offset = "0x2C09AA0", VA = "0x182C0B0A0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7B")]
				[Cpp2IlInjected.Address(RVA = "0x25F74C0", Offset = "0x25F5EC0", VA = "0x1825F74C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7C")]
				[Cpp2IlInjected.Address(RVA = "0x25F7550", Offset = "0x25F5F50", VA = "0x1825F7550", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7D")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D700", Offset = "0x2C0C100", VA = "0x182C0D700", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7E")]
				[Cpp2IlInjected.Address(RVA = "0x2C0EDE0", Offset = "0x2C0D7E0", VA = "0x182C0EDE0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7F")]
				[Cpp2IlInjected.Address(RVA = "0x25F4940", Offset = "0x25F3340", VA = "0x1825F4940", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B80")]
				[Cpp2IlInjected.Address(RVA = "0x2C0FFE0", Offset = "0x2C0E9E0", VA = "0x182C0FFE0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000105")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000382")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000384")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000385")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000386")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000B86")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E7B0", Offset = "0x2C1D1B0", VA = "0x182C1E7B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B87")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E430", Offset = "0x2C1CE30", VA = "0x182C1E430")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B88")]
					[Cpp2IlInjected.Address(RVA = "0x2C1EC30", Offset = "0x2C1D630", VA = "0x182C1EC30", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000B8C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B8D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000B8E")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000B8F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000B90")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B91")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000B9D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B9E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B89")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D410", Offset = "0x2C1BE10", VA = "0x182C1D410")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B8A")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D6C0", Offset = "0x2C1C0C0", VA = "0x182C1D6C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B8B")]
				[Cpp2IlInjected.Address(RVA = "0x2C17DB0", Offset = "0x2C167B0", VA = "0x182C17DB0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B92")]
				[Cpp2IlInjected.Address(RVA = "0x2C186F0", Offset = "0x2C170F0", VA = "0x182C186F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B93")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B94")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B95")]
				[Cpp2IlInjected.Address(RVA = "0x2C1BD00", Offset = "0x2C1A700", VA = "0x182C1BD00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B96")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCEA0", Offset = "0x1DCB8A0", VA = "0x181DCCEA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B97")]
				[Cpp2IlInjected.Address(RVA = "0x2C16F40", Offset = "0x2C15940", VA = "0x182C16F40", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B98")]
				[Cpp2IlInjected.Address(RVA = "0x2C19E60", Offset = "0x2C18860", VA = "0x182C19E60", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B99")]
				[Cpp2IlInjected.Address(RVA = "0x2C19BE0", Offset = "0x2C185E0", VA = "0x182C19BE0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9A")]
				[Cpp2IlInjected.Address(RVA = "0x2C190B0", Offset = "0x2C17AB0", VA = "0x182C190B0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9B")]
				[Cpp2IlInjected.Address(RVA = "0x2C1B5E0", Offset = "0x2C19FE0", VA = "0x182C1B5E0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9C")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9F")]
				[Cpp2IlInjected.Address(RVA = "0x2C152E0", Offset = "0x2C13CE0", VA = "0x182C152E0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private static readonly MessageParser<PutDownListItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		[DebuggerNonUserCode]
		public static MessageParser<PutDownListItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x148D020", Offset = "0x148BA20", VA = "0x18148D020")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0x148CF50", Offset = "0x148B950", VA = "0x18148CF50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x148D080", Offset = "0x148BA80", VA = "0x18148D080", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PutDownListItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PutDownListItem(PutDownListItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x148CC70", Offset = "0x148B670", VA = "0x18148CC70", Slot = "10")]
		[DebuggerNonUserCode]
		public PutDownListItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PutDownListItem putDownListItem = default(PutDownListItem);
			putDownListItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (putDownListItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return putDownListItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x148CCF0", Offset = "0x148B6F0", VA = "0x18148CCF0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PutDownListItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x148CDE0", Offset = "0x148B7E0", VA = "0x18148CDE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PutDownListItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
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

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x148CD70", Offset = "0x148B770", VA = "0x18148CD70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x148CE40", Offset = "0x148B840", VA = "0x18148CE40")]
		static PutDownListItem()
		{
			Func<PutDownListItem> func = default(Func<PutDownListItem>);
			_parser = (MessageParser<PutDownListItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
