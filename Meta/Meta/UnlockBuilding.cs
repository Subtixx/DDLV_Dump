using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004AB")]
	public sealed class UnlockBuilding : IMessage<UnlockBuilding>, IMessage, IEquatable<UnlockBuilding>, IDeepCloneable<UnlockBuilding>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004AC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004AD")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000E7F")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000E80")]
				[OriginalName("AlreadyUnlocked")]
				AlreadyUnlocked,
				[Cpp2IlInjected.Token(Token = "0x4000E81")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000E82")]
				[OriginalName("NotEnoughMana")]
				NotEnoughMana,
				[Cpp2IlInjected.Token(Token = "0x4000E83")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000E84")]
				[OriginalName("NeedUnlockedCharacter")]
				NeedUnlockedCharacter,
				[Cpp2IlInjected.Token(Token = "0x4000E85")]
				[OriginalName("NeedUnlock")]
				NeedUnlock,
				[Cpp2IlInjected.Token(Token = "0x4000E86")]
				[OriginalName("NotEnoughPlayerLevel")]
				NotEnoughPlayerLevel
			}

			[Cpp2IlInjected.Token(Token = "0x20004AE")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E87")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E88")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E89")]
				public const int BuildingIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E8A")]
				private int buildingId_;

				[Cpp2IlInjected.Token(Token = "0x4000E8B")]
				public const int UnlockFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000E8C")]
				private bool unlock_;

				[Cpp2IlInjected.Token(Token = "0x4000E8D")]
				public const int BuyMissingSoftCurrencyWithHardCurrencyFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x4000E8E")]
				private bool buyMissingSoftCurrencyWithHardCurrency_;

				[Cpp2IlInjected.Token(Token = "0x4000E8F")]
				public const int CheatForcedFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x4000E90")]
				private bool cheatForced_;

				[Cpp2IlInjected.Token(Token = "0x4000E91")]
				public const int IsCastleFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x4000E92")]
				private bool isCastle_;

				[Cpp2IlInjected.Token(Token = "0x17000855")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002D71")]
					[Cpp2IlInjected.Address(RVA = "0x1D70DC0", Offset = "0x1D6F7C0", VA = "0x181D70DC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000856")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002D72")]
					[Cpp2IlInjected.Address(RVA = "0x1D70860", Offset = "0x1D6F260", VA = "0x181D70860")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000857")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002D73")]
					[Cpp2IlInjected.Address(RVA = "0x1D71A20", Offset = "0x1D70420", VA = "0x181D71A20", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000858")]
				[DebuggerNonUserCode]
				public int BuildingId
				{
					[Cpp2IlInjected.Token(Token = "0x6002D77")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002D78")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000859")]
				[DebuggerNonUserCode]
				public bool Unlock
				{
					[Cpp2IlInjected.Token(Token = "0x6002D79")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002D7A")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700085A")]
				[DebuggerNonUserCode]
				public bool BuyMissingSoftCurrencyWithHardCurrency
				{
					[Cpp2IlInjected.Token(Token = "0x6002D7B")]
					[Cpp2IlInjected.Address(RVA = "0x63C0F0", Offset = "0x63AAF0", VA = "0x18063C0F0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002D7C")]
					[Cpp2IlInjected.Address(RVA = "0x63C2C0", Offset = "0x63ACC0", VA = "0x18063C2C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700085B")]
				[DebuggerNonUserCode]
				public bool CheatForced
				{
					[Cpp2IlInjected.Token(Token = "0x6002D7D")]
					[Cpp2IlInjected.Address(RVA = "0x17E84B0", Offset = "0x17E6EB0", VA = "0x1817E84B0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002D7E")]
					[Cpp2IlInjected.Address(RVA = "0x17E84D0", Offset = "0x17E6ED0", VA = "0x1817E84D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700085C")]
				[DebuggerNonUserCode]
				public bool IsCastle
				{
					[Cpp2IlInjected.Token(Token = "0x6002D7F")]
					[Cpp2IlInjected.Address(RVA = "0x17E84A0", Offset = "0x17E6EA0", VA = "0x1817E84A0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002D80")]
					[Cpp2IlInjected.Address(RVA = "0x17E84C0", Offset = "0x17E6EC0", VA = "0x1817E84C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002D74")]
				[Cpp2IlInjected.Address(RVA = "0x1D6FF60", Offset = "0x1D6E960", VA = "0x181D6FF60")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D75")]
				[Cpp2IlInjected.Address(RVA = "0x1D70240", Offset = "0x1D6EC40", VA = "0x181D70240")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D76")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A4E0", Offset = "0x1D68EE0", VA = "0x181D6A4E0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D81")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B140", Offset = "0x1D69B40", VA = "0x181D6B140", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D82")]
				[Cpp2IlInjected.Address(RVA = "0x1D6ADE0", Offset = "0x1D697E0", VA = "0x181D6ADE0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D83")]
				[Cpp2IlInjected.Address(RVA = "0x1D6BFA0", Offset = "0x1D6A9A0", VA = "0x181D6BFA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D84")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D590", Offset = "0x1D6BF90", VA = "0x181D6D590", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D85")]
				[Cpp2IlInjected.Address(RVA = "0x1D6EA20", Offset = "0x1D6D420", VA = "0x181D6EA20", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D86")]
				[Cpp2IlInjected.Address(RVA = "0x1D696C0", Offset = "0x1D680C0", VA = "0x181D696C0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D87")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C8A0", Offset = "0x1D6B2A0", VA = "0x181D6C8A0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D88")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C430", Offset = "0x1D6AE30", VA = "0x181D6C430", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D89")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B6D0", Offset = "0x1D6A0D0", VA = "0x181D6B6D0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D8A")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C920", Offset = "0x1D6B320", VA = "0x181D6C920", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D8B")]
				[Cpp2IlInjected.Address(RVA = "0x1D69D00", Offset = "0x1D68700", VA = "0x181D69D00", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D8C")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D930", Offset = "0x1D6C330", VA = "0x181D6D930", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004B0")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E94")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E95")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E96")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E97")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000E98")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000E99")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700085D")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002D91")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F010", Offset = "0x1D7DA10", VA = "0x181D7F010")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700085E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002D92")]
					[Cpp2IlInjected.Address(RVA = "0x1D7E850", Offset = "0x1D7D250", VA = "0x181D7E850")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700085F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002D93")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F7B0", Offset = "0x1D7E1B0", VA = "0x181D7F7B0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000860")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002D97")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002D98")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000861")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002D99")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002D9A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000862")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002DA6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DA7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000863")]
				public bool Unlocked
				{
					[Cpp2IlInjected.Token(Token = "0x6002DA8")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F490", Offset = "0x1D7DE90", VA = "0x181D7F490")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002D94")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E810", Offset = "0x1D7D210", VA = "0x181D7E810")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D95")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E2B0", Offset = "0x1D7CCB0", VA = "0x181D7E2B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D96")]
				[Cpp2IlInjected.Address(RVA = "0x1D771F0", Offset = "0x1D75BF0", VA = "0x181D771F0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D9B")]
				[Cpp2IlInjected.Address(RVA = "0x1D77F10", Offset = "0x1D76910", VA = "0x181D77F10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D9C")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D9D")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D9E")]
				[Cpp2IlInjected.Address(RVA = "0x1D7C040", Offset = "0x1D7AA40", VA = "0x181D7C040", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D9F")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DA0")]
				[Cpp2IlInjected.Address(RVA = "0x1D76120", Offset = "0x1D74B20", VA = "0x181D76120", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DA1")]
				[Cpp2IlInjected.Address(RVA = "0x1D796C0", Offset = "0x1D780C0", VA = "0x181D796C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DA2")]
				[Cpp2IlInjected.Address(RVA = "0x1D79F00", Offset = "0x1D78900", VA = "0x181D79F00", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DA3")]
				[Cpp2IlInjected.Address(RVA = "0x1D785D0", Offset = "0x1D76FD0", VA = "0x181D785D0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002DA4")]
				[Cpp2IlInjected.Address(RVA = "0x1D7BA00", Offset = "0x1D7A400", VA = "0x181D7BA00", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DA5")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DA9")]
				[Cpp2IlInjected.Address(RVA = "0x1D74480", Offset = "0x1D72E80", VA = "0x181D74480", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000E7C")]
		private static readonly MessageParser<UnlockBuilding> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E7D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000852")]
		[DebuggerNonUserCode]
		public static MessageParser<UnlockBuilding> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002D5F")]
			[Cpp2IlInjected.Address(RVA = "0x15D8480", Offset = "0x15D6E80", VA = "0x1815D8480")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000853")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D60")]
			[Cpp2IlInjected.Address(RVA = "0x15D83B0", Offset = "0x15D6DB0", VA = "0x1815D83B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000854")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D61")]
			[Cpp2IlInjected.Address(RVA = "0x15D84E0", Offset = "0x15D6EE0", VA = "0x1815D84E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D62")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UnlockBuilding()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D63")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UnlockBuilding(UnlockBuilding other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D64")]
		[Cpp2IlInjected.Address(RVA = "0x15D80D0", Offset = "0x15D6AD0", VA = "0x1815D80D0", Slot = "10")]
		[DebuggerNonUserCode]
		public UnlockBuilding Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UnlockBuilding unlockBuilding = default(UnlockBuilding);
			unlockBuilding.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (unlockBuilding._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return unlockBuilding;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D65")]
		[Cpp2IlInjected.Address(RVA = "0x15D8150", Offset = "0x15D6B50", VA = "0x1815D8150", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002D66")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnlockBuilding other)
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

		[Cpp2IlInjected.Token(Token = "0x6002D67")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D68")]
		[Cpp2IlInjected.Address(RVA = "0x15D8240", Offset = "0x15D6C40", VA = "0x1815D8240", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D69")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnlockBuilding other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6C")]
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

		[Cpp2IlInjected.Token(Token = "0x6002D6D")]
		[Cpp2IlInjected.Address(RVA = "0x15D81D0", Offset = "0x15D6BD0", VA = "0x1815D81D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002D6F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002D70")]
		[Cpp2IlInjected.Address(RVA = "0x15D82A0", Offset = "0x15D6CA0", VA = "0x1815D82A0")]
		static UnlockBuilding()
		{
			Func<UnlockBuilding> func = default(Func<UnlockBuilding>);
			_parser = (MessageParser<UnlockBuilding>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
