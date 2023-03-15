using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000510")]
	public sealed class AddPlayerHouseFloor : IMessage<AddPlayerHouseFloor>, IMessage, IEquatable<AddPlayerHouseFloor>, IDeepCloneable<AddPlayerHouseFloor>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000511")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000512")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000FAF")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000FB0")]
				[OriginalName("FirstFloorNotCompleted")]
				FirstFloorNotCompleted,
				[Cpp2IlInjected.Token(Token = "0x4000FB1")]
				[OriginalName("MaxFloorReached")]
				MaxFloorReached,
				[Cpp2IlInjected.Token(Token = "0x4000FB2")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000FB3")]
				[OriginalName("NeedUpgrade")]
				NeedUpgrade
			}

			[Cpp2IlInjected.Token(Token = "0x2000513")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000FB4")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FB5")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x1700090B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600312E")]
					[Cpp2IlInjected.Address(RVA = "0x75FF60", Offset = "0x75E960", VA = "0x18075FF60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700090C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600312F")]
					[Cpp2IlInjected.Address(RVA = "0x75FE80", Offset = "0x75E880", VA = "0x18075FE80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700090D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003130")]
					[Cpp2IlInjected.Address(RVA = "0x7602C0", Offset = "0x75ECC0", VA = "0x1807602C0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003131")]
				[Cpp2IlInjected.Address(RVA = "0x75FC50", Offset = "0x75E650", VA = "0x18075FC50")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003132")]
				[Cpp2IlInjected.Address(RVA = "0x75FC90", Offset = "0x75E690", VA = "0x18075FC90")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003133")]
				[Cpp2IlInjected.Address(RVA = "0x75DE50", Offset = "0x75C850", VA = "0x18075DE50", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003134")]
				[Cpp2IlInjected.Address(RVA = "0x75E0E0", Offset = "0x75CAE0", VA = "0x18075E0E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003135")]
				[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003136")]
				[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003137")]
				[Cpp2IlInjected.Address(RVA = "0x75EEA0", Offset = "0x75D8A0", VA = "0x18075EEA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003138")]
				[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003139")]
				[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600313A")]
				[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600313B")]
				[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600313C")]
				[Cpp2IlInjected.Address(RVA = "0x75E4E0", Offset = "0x75CEE0", VA = "0x18075E4E0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600313D")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600313E")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600313F")]
				[Cpp2IlInjected.Address(RVA = "0x75F1B0", Offset = "0x75DBB0", VA = "0x18075F1B0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000515")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000FB7")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000FB8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000FB9")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000FBA")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000FBB")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000FBC")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700090E")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003144")]
					[Cpp2IlInjected.Address(RVA = "0x763C00", Offset = "0x762600", VA = "0x180763C00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700090F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003145")]
					[Cpp2IlInjected.Address(RVA = "0x7639C0", Offset = "0x7623C0", VA = "0x1807639C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000910")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003146")]
					[Cpp2IlInjected.Address(RVA = "0x763E40", Offset = "0x762840", VA = "0x180763E40", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000911")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600314A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600314B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000912")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600314C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600314D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000913")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6003159")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600315A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003147")]
				[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762280", VA = "0x180763880")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003148")]
				[Cpp2IlInjected.Address(RVA = "0x7634C0", Offset = "0x761EC0", VA = "0x1807634C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003149")]
				[Cpp2IlInjected.Address(RVA = "0x7613D0", Offset = "0x75FDD0", VA = "0x1807613D0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600314E")]
				[Cpp2IlInjected.Address(RVA = "0x761B10", Offset = "0x760510", VA = "0x180761B10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600314F")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003150")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003151")]
				[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761690", VA = "0x180762C90", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003152")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003153")]
				[Cpp2IlInjected.Address(RVA = "0x7611C0", Offset = "0x75FBC0", VA = "0x1807611C0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003154")]
				[Cpp2IlInjected.Address(RVA = "0x762150", Offset = "0x760B50", VA = "0x180762150", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003155")]
				[Cpp2IlInjected.Address(RVA = "0x762620", Offset = "0x761020", VA = "0x180762620", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003156")]
				[Cpp2IlInjected.Address(RVA = "0x761F10", Offset = "0x760910", VA = "0x180761F10", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003157")]
				[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761500", VA = "0x180762B00", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003158")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600315B")]
				[Cpp2IlInjected.Address(RVA = "0x7603F0", Offset = "0x75EDF0", VA = "0x1807603F0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000FAB")]
		private static readonly MessageParser<AddPlayerHouseFloor> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000FAC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000FAD")]
		public static readonly Item InvisibleDoorItem;

		[Cpp2IlInjected.Token(Token = "0x17000908")]
		[DebuggerNonUserCode]
		public static MessageParser<AddPlayerHouseFloor> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600311C")]
			[Cpp2IlInjected.Address(RVA = "0x18E63B0", Offset = "0x18E4DB0", VA = "0x1818E63B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000909")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600311D")]
			[Cpp2IlInjected.Address(RVA = "0x18E62E0", Offset = "0x18E4CE0", VA = "0x1818E62E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700090A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600311E")]
			[Cpp2IlInjected.Address(RVA = "0x18E6410", Offset = "0x18E4E10", VA = "0x1818E6410", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600311F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AddPlayerHouseFloor()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6003120")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public AddPlayerHouseFloor(AddPlayerHouseFloor other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003121")]
		[Cpp2IlInjected.Address(RVA = "0x18E5FB0", Offset = "0x18E49B0", VA = "0x1818E5FB0", Slot = "10")]
		[DebuggerNonUserCode]
		public AddPlayerHouseFloor Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			AddPlayerHouseFloor addPlayerHouseFloor = default(AddPlayerHouseFloor);
			addPlayerHouseFloor.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (addPlayerHouseFloor._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return addPlayerHouseFloor;
		}

		[Cpp2IlInjected.Token(Token = "0x6003122")]
		[Cpp2IlInjected.Address(RVA = "0x18E6030", Offset = "0x18E4A30", VA = "0x1818E6030", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003123")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AddPlayerHouseFloor other)
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

		[Cpp2IlInjected.Token(Token = "0x6003124")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003125")]
		[Cpp2IlInjected.Address(RVA = "0x18E6120", Offset = "0x18E4B20", VA = "0x1818E6120", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003126")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003127")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003128")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AddPlayerHouseFloor other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003129")]
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

		[Cpp2IlInjected.Token(Token = "0x600312A")]
		[Cpp2IlInjected.Address(RVA = "0x18E60B0", Offset = "0x18E4AB0", VA = "0x1818E60B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600312B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600312C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600312D")]
		[Cpp2IlInjected.Address(RVA = "0x18E6180", Offset = "0x18E4B80", VA = "0x1818E6180")]
		static AddPlayerHouseFloor()
		{
			Func<AddPlayerHouseFloor> func = default(Func<AddPlayerHouseFloor>);
			InvisibleDoorItem = (Item)(_parser = (MessageParser<AddPlayerHouseFloor>)(object)new MessageParser<T>((Func<>)(object)func));
		}
	}
}
