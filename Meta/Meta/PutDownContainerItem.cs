using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class PutDownContainerItem : IMessage<PutDownContainerItem>, IMessage, IEquatable<PutDownContainerItem>, IDeepCloneable<PutDownContainerItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000301")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000302")]
				[OriginalName("InvalidInventory")]
				InvalidInventory,
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[OriginalName("OverLimits")]
				OverLimits,
				[Cpp2IlInjected.Token(Token = "0x4000306")]
				[OriginalName("Occupied")]
				Occupied
			}

			[Cpp2IlInjected.Token(Token = "0x20000E6")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20000E7")]
				public enum ItemSelectorOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x400031A")]
					None = 0,
					[Cpp2IlInjected.Token(Token = "0x400031B")]
					Item = 2,
					[Cpp2IlInjected.Token(Token = "0x400031C")]
					ContainerInventoryPosition = 3
				}

				[Cpp2IlInjected.Token(Token = "0x4000307")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000309")]
				public const int InventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400030A")]
				private uint inventoryID_;

				[Cpp2IlInjected.Token(Token = "0x400030B")]
				public const int ItemFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x400030C")]
				public const int ContainerInventoryPositionFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x400030D")]
				public const int GridIDFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400030E")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x400030F")]
				public const int PosXFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				private int posX_;

				[Cpp2IlInjected.Token(Token = "0x4000311")]
				public const int PosYFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000312")]
				private int posY_;

				[Cpp2IlInjected.Token(Token = "0x4000313")]
				public const int OrientationFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000314")]
				private GridOrientation orientation_;

				[Cpp2IlInjected.Token(Token = "0x4000315")]
				public const int ClearAreaFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000316")]
				private bool clearArea_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				private object itemSelector_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				private ItemSelectorOneofCase itemSelectorCase_;

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000A60")]
					[Cpp2IlInjected.Address(RVA = "0x2C12A30", Offset = "0x2C11430", VA = "0x182C12A30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000A61")]
					[Cpp2IlInjected.Address(RVA = "0x2C12710", Offset = "0x2C11110", VA = "0x182C12710")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000A62")]
					[Cpp2IlInjected.Address(RVA = "0x2C12D30", Offset = "0x2C11730", VA = "0x182C12D30", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				[DebuggerNonUserCode]
				public uint InventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000A66")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A67")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				[DebuggerNonUserCode]
				public ItemInstance Item
				{
					[Cpp2IlInjected.Token(Token = "0x6000A68")]
					[Cpp2IlInjected.Address(RVA = "0x2C12910", Offset = "0x2C11310", VA = "0x182C12910")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000A69")]
					[Cpp2IlInjected.Address(RVA = "0x2C137C0", Offset = "0x2C121C0", VA = "0x182C137C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				[DebuggerNonUserCode]
				public int ContainerInventoryPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000A6A")]
					[Cpp2IlInjected.Address(RVA = "0x2C123A0", Offset = "0x2C10DA0", VA = "0x182C123A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A6B")]
					[Cpp2IlInjected.Address(RVA = "0x2C13590", Offset = "0x2C11F90", VA = "0x182C13590")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000A6C")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A6D")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				[DebuggerNonUserCode]
				public int PosX
				{
					[Cpp2IlInjected.Token(Token = "0x6000A6E")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A6F")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				[DebuggerNonUserCode]
				public int PosY
				{
					[Cpp2IlInjected.Token(Token = "0x6000A70")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A71")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				[DebuggerNonUserCode]
				public GridOrientation Orientation
				{
					[Cpp2IlInjected.Token(Token = "0x6000A72")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(GridOrientation);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A73")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				[DebuggerNonUserCode]
				public bool ClearArea
				{
					[Cpp2IlInjected.Token(Token = "0x6000A74")]
					[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A75")]
					[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				[DebuggerNonUserCode]
				public ItemSelectorOneofCase ItemSelectorCase
				{
					[Cpp2IlInjected.Token(Token = "0x6000A76")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(ItemSelectorOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000A63")]
				[Cpp2IlInjected.Address(RVA = "0x2C11C30", Offset = "0x2C10630", VA = "0x182C11C30")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A64")]
				[Cpp2IlInjected.Address(RVA = "0x2C12160", Offset = "0x2C10B60", VA = "0x182C12160")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A65")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C040", Offset = "0x2C0AA40", VA = "0x182C0C040", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000A77")]
				[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
				[DebuggerNonUserCode]
				public void ClearItemSelector()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A78")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C6F0", Offset = "0x2C0B0F0", VA = "0x182C0C6F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A79")]
				[Cpp2IlInjected.Address(RVA = "0x2C0CF10", Offset = "0x2C0B910", VA = "0x182C0CF10", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A7A")]
				[Cpp2IlInjected.Address(RVA = "0x2C0DB80", Offset = "0x2C0C580", VA = "0x182C0DB80", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A7B")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F520", Offset = "0x2C0DF20", VA = "0x182C0F520", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000A7C")]
				[Cpp2IlInjected.Address(RVA = "0x2C109E0", Offset = "0x2C0F3E0", VA = "0x182C109E0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A7D")]
				[Cpp2IlInjected.Address(RVA = "0x2C0B760", Offset = "0x2C0A160", VA = "0x182C0B760", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A7E")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E0D0", Offset = "0x2C0CAD0", VA = "0x182C0E0D0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A7F")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E500", Offset = "0x2C0CF00", VA = "0x182C0E500", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A80")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D3A0", Offset = "0x2C0BDA0", VA = "0x182C0D3A0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000A81")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E820", Offset = "0x2C0D220", VA = "0x182C0E820", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A82")]
				[Cpp2IlInjected.Address(RVA = "0x2C0BD20", Offset = "0x2C0A720", VA = "0x182C0BD20", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A83")]
				[Cpp2IlInjected.Address(RVA = "0x2C0DD50", Offset = "0x2C0C750", VA = "0x182C0DD50", Slot = "16")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x2C0BDF0", Offset = "0x2C0A7F0", VA = "0x182C0BDF0", Slot = "17")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F840", Offset = "0x2C0E240", VA = "0x182C0F840", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000E9")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400031F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000320")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000321")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000323")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000325")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000326")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000A8B")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E6F0", Offset = "0x2C1D0F0", VA = "0x182C1E6F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000A8C")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E330", Offset = "0x2C1CD30", VA = "0x182C1E330")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000A8D")]
					[Cpp2IlInjected.Address(RVA = "0x2C1EAB0", Offset = "0x2C1D4B0", VA = "0x182C1EAB0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000A91")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A92")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000A93")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000A94")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000A95")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000A96")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000AA2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AA3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8E")]
				[Cpp2IlInjected.Address(RVA = "0x2C1DDA0", Offset = "0x2C1C7A0", VA = "0x182C1DDA0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8F")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D0B0", Offset = "0x2C1BAB0", VA = "0x182C1D0B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A90")]
				[Cpp2IlInjected.Address(RVA = "0x2C177A0", Offset = "0x2C161A0", VA = "0x182C177A0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000A97")]
				[Cpp2IlInjected.Address(RVA = "0x2C17FE0", Offset = "0x2C169E0", VA = "0x182C17FE0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A98")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A99")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9A")]
				[Cpp2IlInjected.Address(RVA = "0x2C1BFA0", Offset = "0x2C1A9A0", VA = "0x182C1BFA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9B")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCEA0", Offset = "0x1DCB8A0", VA = "0x181DCCEA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9C")]
				[Cpp2IlInjected.Address(RVA = "0x2C16E40", Offset = "0x2C15840", VA = "0x182C16E40", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x2C19AE0", Offset = "0x2C184E0", VA = "0x182C19AE0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x2C19750", Offset = "0x2C18150", VA = "0x182C19750", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9F")]
				[Cpp2IlInjected.Address(RVA = "0x2C19270", Offset = "0x2C17C70", VA = "0x182C19270", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA0")]
				[Cpp2IlInjected.Address(RVA = "0x2C1B9A0", Offset = "0x2C1A3A0", VA = "0x182C1B9A0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA1")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x2C15C70", Offset = "0x2C14670", VA = "0x182C15C70", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static readonly MessageParser<PutDownContainerItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		[DebuggerNonUserCode]
		public static MessageParser<PutDownContainerItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x148CB00", Offset = "0x148B500", VA = "0x18148CB00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x148CA30", Offset = "0x148B430", VA = "0x18148CA30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x148CB60", Offset = "0x148B560", VA = "0x18148CB60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PutDownContainerItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PutDownContainerItem(PutDownContainerItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x148C750", Offset = "0x148B150", VA = "0x18148C750", Slot = "10")]
		[DebuggerNonUserCode]
		public PutDownContainerItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PutDownContainerItem putDownContainerItem = default(PutDownContainerItem);
			putDownContainerItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (putDownContainerItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return putDownContainerItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x148C7D0", Offset = "0x148B1D0", VA = "0x18148C7D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PutDownContainerItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x148C8C0", Offset = "0x148B2C0", VA = "0x18148C8C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PutDownContainerItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
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

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x148C850", Offset = "0x148B250", VA = "0x18148C850", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0x148C920", Offset = "0x148B320", VA = "0x18148C920")]
		static PutDownContainerItem()
		{
			Func<PutDownContainerItem> func = default(Func<PutDownContainerItem>);
			_parser = (MessageParser<PutDownContainerItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
