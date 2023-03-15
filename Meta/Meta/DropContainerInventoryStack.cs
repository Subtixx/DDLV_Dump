using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class DropContainerInventoryStack : IMessage<DropContainerInventoryStack>, IMessage, IEquatable<DropContainerInventoryStack>, IDeepCloneable<DropContainerInventoryStack>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000EE")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400032D")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400032E")]
				[OriginalName("InvalidInventory")]
				InvalidInventory,
				[Cpp2IlInjected.Token(Token = "0x400032F")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000330")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000331")]
				[OriginalName("OverLimits")]
				OverLimits,
				[Cpp2IlInjected.Token(Token = "0x4000332")]
				[OriginalName("NotEnoughSpace")]
				NotEnoughSpace
			}

			[Cpp2IlInjected.Token(Token = "0x20000EF")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000333")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000334")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000335")]
				public const int InventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000336")]
				private uint inventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000337")]
				public const int InventoryPositionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000338")]
				private int inventoryPosition_;

				[Cpp2IlInjected.Token(Token = "0x4000339")]
				public const int SimulatingDropFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400033A")]
				private bool simulatingDrop_;

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000ABF")]
					[Cpp2IlInjected.Address(RVA = "0x1E137D0", Offset = "0x1E121D0", VA = "0x181E137D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000AC0")]
					[Cpp2IlInjected.Address(RVA = "0x1E13630", Offset = "0x1E12030", VA = "0x181E13630")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000AC1")]
					[Cpp2IlInjected.Address(RVA = "0x1E14190", Offset = "0x1E12B90", VA = "0x181E14190", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				[DebuggerNonUserCode]
				public uint InventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000AC5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AC6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				[DebuggerNonUserCode]
				public int InventoryPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000AC7")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AC8")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				[DebuggerNonUserCode]
				public bool SimulatingDrop
				{
					[Cpp2IlInjected.Token(Token = "0x6000AC9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000ACA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				internal bool IgnoreLimits
				{
					[Cpp2IlInjected.Token(Token = "0x6000AD6")]
					[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AD7")]
					[Cpp2IlInjected.Address(RVA = "0xBA18C0", Offset = "0xBA02C0", VA = "0x180BA18C0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				internal bool AllowOutdatedAvatarPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6000AD8")]
					[Cpp2IlInjected.Address(RVA = "0x1D4C170", Offset = "0x1D4AB70", VA = "0x181D4C170")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AD9")]
					[Cpp2IlInjected.Address(RVA = "0x1E14550", Offset = "0x1E12F50", VA = "0x181E14550")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000AC2")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AC3")]
				[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AC4")]
				[Cpp2IlInjected.Address(RVA = "0x1E0CF00", Offset = "0x1E0B900", VA = "0x181E0CF00", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000ACB")]
				[Cpp2IlInjected.Address(RVA = "0x1E0E060", Offset = "0x1E0CA60", VA = "0x181E0E060", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000ACC")]
				[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000ACD")]
				[Cpp2IlInjected.Address(RVA = "0x1E0EC90", Offset = "0x1E0D690", VA = "0x181E0EC90", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000ACE")]
				[Cpp2IlInjected.Address(RVA = "0x1E10570", Offset = "0x1E0EF70", VA = "0x181E10570", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000ACF")]
				[Cpp2IlInjected.Address(RVA = "0x1E115D0", Offset = "0x1E0FFD0", VA = "0x181E115D0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AD0")]
				[Cpp2IlInjected.Address(RVA = "0x1E0C8A0", Offset = "0x1E0B2A0", VA = "0x181E0C8A0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000AD1")]
				[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AD2")]
				[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AD3")]
				[Cpp2IlInjected.Address(RVA = "0x1E0E660", Offset = "0x1E0D060", VA = "0x181E0E660", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000AD4")]
				[Cpp2IlInjected.Address(RVA = "0x1E0FD30", Offset = "0x1E0E730", VA = "0x181E0FD30", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AD5")]
				[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000F1")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400033E")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400033F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000340")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000341")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000342")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000343")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000344")]
				public const int WholeStackDroppedFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000345")]
				private bool wholeStackDropped_;

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000ADE")]
					[Cpp2IlInjected.Address(RVA = "0x1E20800", Offset = "0x1E1F200", VA = "0x181E20800")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000ADF")]
					[Cpp2IlInjected.Address(RVA = "0x1E20420", Offset = "0x1E1EE20", VA = "0x181E20420")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000AE0")]
					[Cpp2IlInjected.Address(RVA = "0x1E20D40", Offset = "0x1E1F740", VA = "0x181E20D40", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000AE4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AE5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000AE6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000AE7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				[DebuggerNonUserCode]
				public bool WholeStackDropped
				{
					[Cpp2IlInjected.Token(Token = "0x6000AE8")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AE9")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000AF5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000AF6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000AE1")]
				[Cpp2IlInjected.Address(RVA = "0x1E1F630", Offset = "0x1E1E030", VA = "0x181E1F630")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AE2")]
				[Cpp2IlInjected.Address(RVA = "0x1E1F9C0", Offset = "0x1E1E3C0", VA = "0x181E1F9C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AE3")]
				[Cpp2IlInjected.Address(RVA = "0x1E19040", Offset = "0x1E17A40", VA = "0x181E19040", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000AEA")]
				[Cpp2IlInjected.Address(RVA = "0x1E1A430", Offset = "0x1E18E30", VA = "0x181E1A430", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000AEB")]
				[Cpp2IlInjected.Address(RVA = "0x5CA1B0", Offset = "0x5C8BB0", VA = "0x1805CA1B0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000AEC")]
				[Cpp2IlInjected.Address(RVA = "0x5CA3F0", Offset = "0x5C8DF0", VA = "0x1805CA3F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000AED")]
				[Cpp2IlInjected.Address(RVA = "0x1E1DBA0", Offset = "0x1E1C5A0", VA = "0x181E1DBA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000AEE")]
				[Cpp2IlInjected.Address(RVA = "0x5CA820", Offset = "0x5C9220", VA = "0x1805CA820", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AEF")]
				[Cpp2IlInjected.Address(RVA = "0x1E18A50", Offset = "0x1E17450", VA = "0x181E18A50", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000AF0")]
				[Cpp2IlInjected.Address(RVA = "0x1E1CAB0", Offset = "0x1E1B4B0", VA = "0x181E1CAB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AF1")]
				[Cpp2IlInjected.Address(RVA = "0x1E1BFA0", Offset = "0x1E1A9A0", VA = "0x181E1BFA0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AF2")]
				[Cpp2IlInjected.Address(RVA = "0x1E1ACF0", Offset = "0x1E196F0", VA = "0x181E1ACF0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000AF3")]
				[Cpp2IlInjected.Address(RVA = "0x1E1D390", Offset = "0x1E1BD90", VA = "0x181E1D390", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AF4")]
				[Cpp2IlInjected.Address(RVA = "0x5CA0D0", Offset = "0x5C8AD0", VA = "0x1805CA0D0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AF7")]
				[Cpp2IlInjected.Address(RVA = "0x1E16DC0", Offset = "0x1E157C0", VA = "0x181E16DC0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private static readonly MessageParser<DropContainerInventoryStack> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		[DebuggerNonUserCode]
		public static MessageParser<DropContainerInventoryStack> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAD")]
			[Cpp2IlInjected.Address(RVA = "0x173CA90", Offset = "0x173B490", VA = "0x18173CA90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x173C9C0", Offset = "0x173B3C0", VA = "0x18173C9C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x173CAF0", Offset = "0x173B4F0", VA = "0x18173CAF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DropContainerInventoryStack()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DropContainerInventoryStack(DropContainerInventoryStack other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x173C6E0", Offset = "0x173B0E0", VA = "0x18173C6E0", Slot = "10")]
		[DebuggerNonUserCode]
		public DropContainerInventoryStack Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DropContainerInventoryStack dropContainerInventoryStack = default(DropContainerInventoryStack);
			dropContainerInventoryStack.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (dropContainerInventoryStack._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return dropContainerInventoryStack;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x173C760", Offset = "0x173B160", VA = "0x18173C760", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DropContainerInventoryStack other)
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

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x173C850", Offset = "0x173B250", VA = "0x18173C850", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DropContainerInventoryStack other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
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

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x173C7E0", Offset = "0x173B1E0", VA = "0x18173C7E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x173C8B0", Offset = "0x173B2B0", VA = "0x18173C8B0")]
		static DropContainerInventoryStack()
		{
			Func<DropContainerInventoryStack> func = default(Func<DropContainerInventoryStack>);
			_parser = (MessageParser<DropContainerInventoryStack>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
