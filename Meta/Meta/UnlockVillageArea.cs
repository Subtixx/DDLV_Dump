using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200024E")]
	public sealed class UnlockVillageArea : IMessage<UnlockVillageArea>, IMessage, IEquatable<UnlockVillageArea>, IDeepCloneable<UnlockVillageArea>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200024F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000250")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000795")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000796")]
				[OriginalName("InvalidArea")]
				InvalidArea,
				[Cpp2IlInjected.Token(Token = "0x4000797")]
				[OriginalName("AlreadyUnlocked")]
				AlreadyUnlocked,
				[Cpp2IlInjected.Token(Token = "0x4000798")]
				[OriginalName("NotRightLevel")]
				NotRightLevel,
				[Cpp2IlInjected.Token(Token = "0x4000799")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x400079A")]
				[OriginalName("NotEnoughMana")]
				NotEnoughMana,
				[Cpp2IlInjected.Token(Token = "0x400079B")]
				[OriginalName("NotEnoughCharacter")]
				NotEnoughCharacter,
				[Cpp2IlInjected.Token(Token = "0x400079C")]
				[OriginalName("NotADeveloper")]
				NotAdeveloper
			}

			[Cpp2IlInjected.Token(Token = "0x2000251")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400079D")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400079E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400079F")]
				public const int AreaTypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40007A0")]
				private VillageAreaType areaType_;

				[Cpp2IlInjected.Token(Token = "0x40007A1")]
				public const int CheatForcedFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40007A2")]
				private bool cheatForced_;

				[Cpp2IlInjected.Token(Token = "0x1700044A")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60017E2")]
					[Cpp2IlInjected.Address(RVA = "0x1D70BE0", Offset = "0x1D6F5E0", VA = "0x181D70BE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700044B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60017E3")]
					[Cpp2IlInjected.Address(RVA = "0x1D707E0", Offset = "0x1D6F1E0", VA = "0x181D707E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700044C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60017E4")]
					[Cpp2IlInjected.Address(RVA = "0x1D71AE0", Offset = "0x1D704E0", VA = "0x181D71AE0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700044D")]
				[DebuggerNonUserCode]
				public VillageAreaType AreaType
				{
					[Cpp2IlInjected.Token(Token = "0x60017E8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(VillageAreaType);
					}
					[Cpp2IlInjected.Token(Token = "0x60017E9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700044E")]
				[DebuggerNonUserCode]
				public bool CheatForced
				{
					[Cpp2IlInjected.Token(Token = "0x60017EA")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60017EB")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60017E5")]
				[Cpp2IlInjected.Address(RVA = "0x1D70030", Offset = "0x1D6EA30", VA = "0x181D70030")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60017E6")]
				[Cpp2IlInjected.Address(RVA = "0x1D6FD70", Offset = "0x1D6E770", VA = "0x181D6FD70")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60017E7")]
				[Cpp2IlInjected.Address(RVA = "0x1D69E40", Offset = "0x1D68840", VA = "0x181D69E40", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60017EC")]
				[Cpp2IlInjected.Address(RVA = "0x1D6AF70", Offset = "0x1D69970", VA = "0x181D6AF70", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60017ED")]
				[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60017EE")]
				[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60017EF")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D830", Offset = "0x1D6C230", VA = "0x181D6D830", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60017F0")]
				[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60017F1")]
				[Cpp2IlInjected.Address(RVA = "0x1D69630", Offset = "0x1D68030", VA = "0x181D69630", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60017F2")]
				[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60017F3")]
				[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60017F4")]
				[Cpp2IlInjected.Address(RVA = "0x1D6BA60", Offset = "0x1D6A460", VA = "0x181D6BA60", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60017F5")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D2E0", Offset = "0x1D6BCE0", VA = "0x181D6D2E0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60017F6")]
				[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60017F7")]
				[Cpp2IlInjected.Address(RVA = "0x1D6E350", Offset = "0x1D6CD50", VA = "0x181D6E350", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000253")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40007A4")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40007A5")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40007A6")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40007A7")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40007A8")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40007A9")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700044F")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60017FD")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F130", Offset = "0x1D7DB30", VA = "0x181D7F130")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000450")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60017FE")]
					[Cpp2IlInjected.Address(RVA = "0x1D7EED0", Offset = "0x1D7D8D0", VA = "0x181D7EED0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000451")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60017FF")]
					[Cpp2IlInjected.Address(RVA = "0x1D7FE70", Offset = "0x1D7E870", VA = "0x181D7FE70", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000452")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001803")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001804")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000453")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001805")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001806")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000454")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6001812")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000455")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001813")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001814")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001800")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E100", Offset = "0x1D7CB00", VA = "0x181D7E100")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001801")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E180", Offset = "0x1D7CB80", VA = "0x181D7E180")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001802")]
				[Cpp2IlInjected.Address(RVA = "0x1D76E50", Offset = "0x1D75850", VA = "0x181D76E50", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001807")]
				[Cpp2IlInjected.Address(RVA = "0x1D77AE0", Offset = "0x1D764E0", VA = "0x181D77AE0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001808")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001809")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600180A")]
				[Cpp2IlInjected.Address(RVA = "0x1D7BFE0", Offset = "0x1D7A9E0", VA = "0x181D7BFE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600180B")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600180C")]
				[Cpp2IlInjected.Address(RVA = "0x1D762C0", Offset = "0x1D74CC0", VA = "0x181D762C0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600180D")]
				[Cpp2IlInjected.Address(RVA = "0x1D7A650", Offset = "0x1D79050", VA = "0x181D7A650", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600180E")]
				[Cpp2IlInjected.Address(RVA = "0x1D79C30", Offset = "0x1D78630", VA = "0x181D79C30", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600180F")]
				[Cpp2IlInjected.Address(RVA = "0x1D78340", Offset = "0x1D76D40", VA = "0x181D78340", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001810")]
				[Cpp2IlInjected.Address(RVA = "0x1D7B860", Offset = "0x1D7A260", VA = "0x181D7B860", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001811")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001815")]
				[Cpp2IlInjected.Address(RVA = "0x1D73EB0", Offset = "0x1D728B0", VA = "0x181D73EB0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private static readonly MessageParser<UnlockVillageArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000447")]
		[DebuggerNonUserCode]
		public static MessageParser<UnlockVillageArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60017D0")]
			[Cpp2IlInjected.Address(RVA = "0x15D93E0", Offset = "0x15D7DE0", VA = "0x1815D93E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000448")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017D1")]
			[Cpp2IlInjected.Address(RVA = "0x15D9310", Offset = "0x15D7D10", VA = "0x1815D9310")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000449")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017D2")]
			[Cpp2IlInjected.Address(RVA = "0x15D9440", Offset = "0x15D7E40", VA = "0x1815D9440", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017D3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UnlockVillageArea()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60017D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UnlockVillageArea(UnlockVillageArea other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017D5")]
		[Cpp2IlInjected.Address(RVA = "0x15D9030", Offset = "0x15D7A30", VA = "0x1815D9030", Slot = "10")]
		[DebuggerNonUserCode]
		public UnlockVillageArea Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UnlockVillageArea unlockVillageArea = default(UnlockVillageArea);
			unlockVillageArea.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (unlockVillageArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return unlockVillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x60017D6")]
		[Cpp2IlInjected.Address(RVA = "0x15D90B0", Offset = "0x15D7AB0", VA = "0x1815D90B0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60017D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnlockVillageArea other)
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

		[Cpp2IlInjected.Token(Token = "0x60017D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60017D9")]
		[Cpp2IlInjected.Address(RVA = "0x15D91A0", Offset = "0x15D7BA0", VA = "0x1815D91A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60017DA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60017DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60017DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnlockVillageArea other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017DD")]
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

		[Cpp2IlInjected.Token(Token = "0x60017DE")]
		[Cpp2IlInjected.Address(RVA = "0x15D9130", Offset = "0x15D7B30", VA = "0x1815D9130", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017E1")]
		[Cpp2IlInjected.Address(RVA = "0x15D9200", Offset = "0x15D7C00", VA = "0x1815D9200")]
		static UnlockVillageArea()
		{
			Func<UnlockVillageArea> func = default(Func<UnlockVillageArea>);
			_parser = (MessageParser<UnlockVillageArea>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
