using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000479")]
	public sealed class StoreBuyItem : IMessage<StoreBuyItem>, IMessage, IEquatable<StoreBuyItem>, IDeepCloneable<StoreBuyItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200047A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200047B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000DEA")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000DEB")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000DEC")]
				[OriginalName("InvalidBuilding")]
				InvalidBuilding,
				[Cpp2IlInjected.Token(Token = "0x4000DED")]
				[OriginalName("StoreNotFound")]
				StoreNotFound,
				[Cpp2IlInjected.Token(Token = "0x4000DEE")]
				[OriginalName("BuildingLocked")]
				BuildingLocked,
				[Cpp2IlInjected.Token(Token = "0x4000DEF")]
				[OriginalName("InvalidDisplay")]
				InvalidDisplay,
				[Cpp2IlInjected.Token(Token = "0x4000DF0")]
				[OriginalName("InvalidSlot")]
				InvalidSlot,
				[Cpp2IlInjected.Token(Token = "0x4000DF1")]
				[OriginalName("SlotUnavailable")]
				SlotUnavailable,
				[Cpp2IlInjected.Token(Token = "0x4000DF2")]
				[OriginalName("InventoryFull")]
				InventoryFull,
				[Cpp2IlInjected.Token(Token = "0x4000DF3")]
				[OriginalName("NoPriceForItem")]
				NoPriceForItem,
				[Cpp2IlInjected.Token(Token = "0x4000DF4")]
				[OriginalName("MaximumOwnedReached")]
				MaximumOwnedReached
			}

			[Cpp2IlInjected.Token(Token = "0x200047C")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000DF5")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000DF6")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000DF7")]
				public const int BuildingItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000DF8")]
				private int buildingItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000DF9")]
				public const int DisplayIndexFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000DFA")]
				private int displayIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000DFB")]
				public const int SlotIndexFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000DFC")]
				private int slotIndex_;

				[Cpp2IlInjected.Token(Token = "0x17000800")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002BAA")]
					[Cpp2IlInjected.Address(RVA = "0x25FBA90", Offset = "0x25FA490", VA = "0x1825FBA90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000801")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002BAB")]
					[Cpp2IlInjected.Address(RVA = "0x25FB270", Offset = "0x25F9C70", VA = "0x1825FB270")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000802")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002BAC")]
					[Cpp2IlInjected.Address(RVA = "0x25FC2D0", Offset = "0x25FACD0", VA = "0x1825FC2D0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000803")]
				[DebuggerNonUserCode]
				public int BuildingItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002BB0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002BB1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000804")]
				[DebuggerNonUserCode]
				public int DisplayIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6002BB2")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002BB3")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000805")]
				[DebuggerNonUserCode]
				public int SlotIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6002BB4")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002BB5")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002BAD")]
				[Cpp2IlInjected.Address(RVA = "0x25FB130", Offset = "0x25F9B30", VA = "0x1825FB130")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BAE")]
				[Cpp2IlInjected.Address(RVA = "0x25FA640", Offset = "0x25F9040", VA = "0x1825FA640")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BAF")]
				[Cpp2IlInjected.Address(RVA = "0x25F4B90", Offset = "0x25F3590", VA = "0x1825F4B90", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002BB6")]
				[Cpp2IlInjected.Address(RVA = "0x25F5DB0", Offset = "0x25F47B0", VA = "0x1825F5DB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BB7")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BB8")]
				[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C20F0", VA = "0x1825C36F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BB9")]
				[Cpp2IlInjected.Address(RVA = "0x25F8500", Offset = "0x25F6F00", VA = "0x1825F8500", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002BBA")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BBB")]
				[Cpp2IlInjected.Address(RVA = "0x25F3D00", Offset = "0x25F2700", VA = "0x1825F3D00", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BBC")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BBD")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BBE")]
				[Cpp2IlInjected.Address(RVA = "0x25F61A0", Offset = "0x25F4BA0", VA = "0x1825F61A0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002BBF")]
				[Cpp2IlInjected.Address(RVA = "0x25F7950", Offset = "0x25F6350", VA = "0x1825F7950", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BC0")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BC1")]
				[Cpp2IlInjected.Address(RVA = "0x25F8BB0", Offset = "0x25F75B0", VA = "0x1825F8BB0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200047E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000DFE")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000DFF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E00")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E01")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000E02")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000E03")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000806")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002BC6")]
					[Cpp2IlInjected.Address(RVA = "0x26062C0", Offset = "0x2604CC0", VA = "0x1826062C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000807")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002BC7")]
					[Cpp2IlInjected.Address(RVA = "0x26061C0", Offset = "0x2604BC0", VA = "0x1826061C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000808")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002BC8")]
					[Cpp2IlInjected.Address(RVA = "0x2606BC0", Offset = "0x26055C0", VA = "0x182606BC0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000809")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002BCC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002BCD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700080A")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002BCE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002BCF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700080B")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002BDB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002BDC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002BC9")]
				[Cpp2IlInjected.Address(RVA = "0x2605890", Offset = "0x2604290", VA = "0x182605890")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BCA")]
				[Cpp2IlInjected.Address(RVA = "0x2604DE0", Offset = "0x26037E0", VA = "0x182604DE0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BCB")]
				[Cpp2IlInjected.Address(RVA = "0x25FFA30", Offset = "0x25FE430", VA = "0x1825FFA30", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD0")]
				[Cpp2IlInjected.Address(RVA = "0x2600390", Offset = "0x25FED90", VA = "0x182600390", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD1")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD2")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD3")]
				[Cpp2IlInjected.Address(RVA = "0x2603CB0", Offset = "0x26026B0", VA = "0x182603CB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD4")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD5")]
				[Cpp2IlInjected.Address(RVA = "0x25FE5B0", Offset = "0x25FCFB0", VA = "0x1825FE5B0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD6")]
				[Cpp2IlInjected.Address(RVA = "0x2601F90", Offset = "0x2600990", VA = "0x182601F90", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD7")]
				[Cpp2IlInjected.Address(RVA = "0x26014E0", Offset = "0x25FFEE0", VA = "0x1826014E0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD8")]
				[Cpp2IlInjected.Address(RVA = "0x2600D90", Offset = "0x25FF790", VA = "0x182600D90", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002BD9")]
				[Cpp2IlInjected.Address(RVA = "0x26032B0", Offset = "0x2601CB0", VA = "0x1826032B0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BDA")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002BDD")]
				[Cpp2IlInjected.Address(RVA = "0x25FC760", Offset = "0x25FB160", VA = "0x1825FC760", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000DE7")]
		private static readonly MessageParser<StoreBuyItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000DE8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170007FD")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreBuyItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002B98")]
			[Cpp2IlInjected.Address(RVA = "0xC0A2B0", Offset = "0xC08CB0", VA = "0x180C0A2B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B99")]
			[Cpp2IlInjected.Address(RVA = "0xC0A1E0", Offset = "0xC08BE0", VA = "0x180C0A1E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B9A")]
			[Cpp2IlInjected.Address(RVA = "0xC0A310", Offset = "0xC08D10", VA = "0x180C0A310", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B9B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StoreBuyItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B9C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StoreBuyItem(StoreBuyItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B9D")]
		[Cpp2IlInjected.Address(RVA = "0xC09F00", Offset = "0xC08900", VA = "0x180C09F00", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreBuyItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StoreBuyItem storeBuyItem = default(StoreBuyItem);
			storeBuyItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (storeBuyItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeBuyItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B9E")]
		[Cpp2IlInjected.Address(RVA = "0xC09F80", Offset = "0xC08980", VA = "0x180C09F80", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002B9F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreBuyItem other)
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

		[Cpp2IlInjected.Token(Token = "0x6002BA0")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA1")]
		[Cpp2IlInjected.Address(RVA = "0xC0A070", Offset = "0xC08A70", VA = "0x180C0A070", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreBuyItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA5")]
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

		[Cpp2IlInjected.Token(Token = "0x6002BA6")]
		[Cpp2IlInjected.Address(RVA = "0xC0A000", Offset = "0xC08A00", VA = "0x180C0A000", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA9")]
		[Cpp2IlInjected.Address(RVA = "0xC0A0D0", Offset = "0xC08AD0", VA = "0x180C0A0D0")]
		static StoreBuyItem()
		{
			Func<StoreBuyItem> func = default(Func<StoreBuyItem>);
			_parser = (MessageParser<StoreBuyItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
