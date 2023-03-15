using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200026F")]
	public sealed class DebugAddItem : IMessage<DebugAddItem>, IMessage, IEquatable<DebugAddItem>, IDeepCloneable<DebugAddItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000270")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000271")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40007E9")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40007EA")]
				[OriginalName("NotDeveloper")]
				NotDeveloper,
				[Cpp2IlInjected.Token(Token = "0x40007EB")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x40007EC")]
				[OriginalName("InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x2000272")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x40007EE")]
				[OriginalName("Default")]
				Default,
				[Cpp2IlInjected.Token(Token = "0x40007EF")]
				[OriginalName("BuyableOnly")]
				BuyableOnly,
				[Cpp2IlInjected.Token(Token = "0x40007F0")]
				[OriginalName("All")]
				All
			}

			[Cpp2IlInjected.Token(Token = "0x2000273")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40007F1")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40007F2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40007F3")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40007F4")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x40007F5")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40007F6")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x40007F7")]
				public const int TryConsummableFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40007F8")]
				private bool tryConsummable_;

				[Cpp2IlInjected.Token(Token = "0x40007F9")]
				public const int TypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40007FA")]
				private Type type_;

				[Cpp2IlInjected.Token(Token = "0x17000480")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600190A")]
					[Cpp2IlInjected.Address(RVA = "0x26487C0", Offset = "0x26471C0", VA = "0x1826487C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000481")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600190B")]
					[Cpp2IlInjected.Address(RVA = "0x2647DE0", Offset = "0x26467E0", VA = "0x182647DE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000482")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600190C")]
					[Cpp2IlInjected.Address(RVA = "0x2649240", Offset = "0x2647C40", VA = "0x182649240", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000483")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001910")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001911")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000484")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6001912")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001913")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000485")]
				[DebuggerNonUserCode]
				public bool TryConsummable
				{
					[Cpp2IlInjected.Token(Token = "0x6001914")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6001915")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000486")]
				[DebuggerNonUserCode]
				public Type Type
				{
					[Cpp2IlInjected.Token(Token = "0x6001916")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(Type);
					}
					[Cpp2IlInjected.Token(Token = "0x6001917")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600190D")]
				[Cpp2IlInjected.Address(RVA = "0x2647A80", Offset = "0x2646480", VA = "0x182647A80")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600190E")]
				[Cpp2IlInjected.Address(RVA = "0x26479F0", Offset = "0x26463F0", VA = "0x1826479F0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600190F")]
				[Cpp2IlInjected.Address(RVA = "0x26443C0", Offset = "0x2642DC0", VA = "0x1826443C0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001918")]
				[Cpp2IlInjected.Address(RVA = "0x2644DF0", Offset = "0x26437F0", VA = "0x182644DF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001919")]
				[Cpp2IlInjected.Address(RVA = "0xAC9070", Offset = "0xAC7A70", VA = "0x180AC9070", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600191A")]
				[Cpp2IlInjected.Address(RVA = "0xAC9450", Offset = "0xAC7E50", VA = "0x180AC9450", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600191B")]
				[Cpp2IlInjected.Address(RVA = "0x2646040", Offset = "0x2644A40", VA = "0x182646040", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600191C")]
				[Cpp2IlInjected.Address(RVA = "0x21196B0", Offset = "0x21180B0", VA = "0x1821196B0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600191D")]
				[Cpp2IlInjected.Address(RVA = "0x2643FF0", Offset = "0x26429F0", VA = "0x182643FF0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600191E")]
				[Cpp2IlInjected.Address(RVA = "0xAC9510", Offset = "0xAC7F10", VA = "0x180AC9510", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600191F")]
				[Cpp2IlInjected.Address(RVA = "0xAC9700", Offset = "0xAC8100", VA = "0x180AC9700", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001920")]
				[Cpp2IlInjected.Address(RVA = "0x26450A0", Offset = "0x2643AA0", VA = "0x1826450A0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001921")]
				[Cpp2IlInjected.Address(RVA = "0x2645ED0", Offset = "0x26448D0", VA = "0x182645ED0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001922")]
				[Cpp2IlInjected.Address(RVA = "0xAC8AC0", Offset = "0xAC74C0", VA = "0x180AC8AC0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001923")]
				[Cpp2IlInjected.Address(RVA = "0x26466E0", Offset = "0x26450E0", VA = "0x1826466E0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000276")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40007FE")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40007FF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000800")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000801")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000802")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000803")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000487")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001929")]
					[Cpp2IlInjected.Address(RVA = "0x2654340", Offset = "0x2652D40", VA = "0x182654340")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000488")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600192A")]
					[Cpp2IlInjected.Address(RVA = "0x2653CE0", Offset = "0x26526E0", VA = "0x182653CE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000489")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600192B")]
					[Cpp2IlInjected.Address(RVA = "0x2654C40", Offset = "0x2653640", VA = "0x182654C40", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700048A")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600192F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001930")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700048B")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001931")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001932")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700048C")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600193E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600193F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600192C")]
				[Cpp2IlInjected.Address(RVA = "0x2653330", Offset = "0x2651D30", VA = "0x182653330")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600192D")]
				[Cpp2IlInjected.Address(RVA = "0x26539C0", Offset = "0x26523C0", VA = "0x1826539C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600192E")]
				[Cpp2IlInjected.Address(RVA = "0x264C810", Offset = "0x264B210", VA = "0x18264C810", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001933")]
				[Cpp2IlInjected.Address(RVA = "0x264D4C0", Offset = "0x264BEC0", VA = "0x18264D4C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001934")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001935")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001936")]
				[Cpp2IlInjected.Address(RVA = "0x26514B0", Offset = "0x264FEB0", VA = "0x1826514B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001937")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001938")]
				[Cpp2IlInjected.Address(RVA = "0x264C200", Offset = "0x264AC00", VA = "0x18264C200", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001939")]
				[Cpp2IlInjected.Address(RVA = "0x264F040", Offset = "0x264DA40", VA = "0x18264F040", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600193A")]
				[Cpp2IlInjected.Address(RVA = "0x264FAE0", Offset = "0x264E4E0", VA = "0x18264FAE0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600193B")]
				[Cpp2IlInjected.Address(RVA = "0x264E870", Offset = "0x264D270", VA = "0x18264E870", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600193C")]
				[Cpp2IlInjected.Address(RVA = "0x26507A0", Offset = "0x264F1A0", VA = "0x1826507A0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600193D")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001940")]
				[Cpp2IlInjected.Address(RVA = "0x2649B30", Offset = "0x2648530", VA = "0x182649B30", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		private static readonly MessageParser<DebugAddItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700047D")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugAddItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60018F8")]
			[Cpp2IlInjected.Address(RVA = "0x18C7FE0", Offset = "0x18C69E0", VA = "0x1818C7FE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60018F9")]
			[Cpp2IlInjected.Address(RVA = "0x18C7F10", Offset = "0x18C6910", VA = "0x1818C7F10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60018FA")]
			[Cpp2IlInjected.Address(RVA = "0x18C8040", Offset = "0x18C6A40", VA = "0x1818C8040", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018FB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugAddItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60018FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugAddItem(DebugAddItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60018FD")]
		[Cpp2IlInjected.Address(RVA = "0x18C7C30", Offset = "0x18C6630", VA = "0x1818C7C30", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugAddItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugAddItem debugAddItem = default(DebugAddItem);
			debugAddItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugAddItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugAddItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60018FE")]
		[Cpp2IlInjected.Address(RVA = "0x18C7CB0", Offset = "0x18C66B0", VA = "0x1818C7CB0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60018FF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugAddItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6001900")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001901")]
		[Cpp2IlInjected.Address(RVA = "0x18C7DA0", Offset = "0x18C67A0", VA = "0x1818C7DA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001902")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001903")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001904")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugAddItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001905")]
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

		[Cpp2IlInjected.Token(Token = "0x6001906")]
		[Cpp2IlInjected.Address(RVA = "0x18C7D30", Offset = "0x18C6730", VA = "0x1818C7D30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001907")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001908")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001909")]
		[Cpp2IlInjected.Address(RVA = "0x18C7E00", Offset = "0x18C6800", VA = "0x1818C7E00")]
		static DebugAddItem()
		{
			Func<DebugAddItem> func = default(Func<DebugAddItem>);
			_parser = (MessageParser<DebugAddItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
