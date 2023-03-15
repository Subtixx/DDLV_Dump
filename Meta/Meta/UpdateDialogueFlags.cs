using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000406")]
	public sealed class UpdateDialogueFlags : IMessage<UpdateDialogueFlags>, IMessage, IEquatable<UpdateDialogueFlags>, IDeepCloneable<UpdateDialogueFlags>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000407")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000408")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000C86")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000C87")]
				[OriginalName("NoChanges")]
				NoChanges
			}

			[Cpp2IlInjected.Token(Token = "0x2000409")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C88")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C89")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C8A")]
				public const int FlagChangesFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4000C8B")]
				private static readonly MapField<int, bool>.Codec _map_flagChanges_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C8C")]
				private readonly MapField<int, bool> flagChanges_;

				[Cpp2IlInjected.Token(Token = "0x4000C8D")]
				public const int IsOverrideFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C8E")]
				private bool isOverride_;

				[Cpp2IlInjected.Token(Token = "0x4000C8F")]
				public const int ApplyOverrideFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x4000C90")]
				private bool applyOverride_;

				[Cpp2IlInjected.Token(Token = "0x1700072B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002773")]
					[Cpp2IlInjected.Address(RVA = "0x1D70D00", Offset = "0x1D6F700", VA = "0x181D70D00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700072C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002774")]
					[Cpp2IlInjected.Address(RVA = "0x1D70560", Offset = "0x1D6EF60", VA = "0x181D70560")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700072D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002775")]
					[Cpp2IlInjected.Address(RVA = "0x1D717E0", Offset = "0x1D701E0", VA = "0x181D717E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700072E")]
				[DebuggerNonUserCode]
				public MapField<int, bool> FlagChanges
				{
					[Cpp2IlInjected.Token(Token = "0x6002779")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700072F")]
				[DebuggerNonUserCode]
				public bool IsOverride
				{
					[Cpp2IlInjected.Token(Token = "0x600277A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600277B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000730")]
				[DebuggerNonUserCode]
				public bool ApplyOverride
				{
					[Cpp2IlInjected.Token(Token = "0x600277C")]
					[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600277D")]
					[Cpp2IlInjected.Address(RVA = "0xBA18C0", Offset = "0xBA02C0", VA = "0x180BA18C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002776")]
				[Cpp2IlInjected.Address(RVA = "0x1D700B0", Offset = "0x1D6EAB0", VA = "0x181D700B0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002777")]
				[Cpp2IlInjected.Address(RVA = "0x1D70440", Offset = "0x1D6EE40", VA = "0x181D70440")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002778")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A410", Offset = "0x1D68E10", VA = "0x181D6A410", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600277E")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A9B0", Offset = "0x1D693B0", VA = "0x181D6A9B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600277F")]
				[Cpp2IlInjected.Address(RVA = "0x1D6AB20", Offset = "0x1D69520", VA = "0x181D6AB20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002780")]
				[Cpp2IlInjected.Address(RVA = "0x1D6BE10", Offset = "0x1D6A810", VA = "0x181D6BE10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002781")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D3B0", Offset = "0x1D6BDB0", VA = "0x181D6D3B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002782")]
				[Cpp2IlInjected.Address(RVA = "0x1D6E700", Offset = "0x1D6D100", VA = "0x181D6E700", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002783")]
				[Cpp2IlInjected.Address(RVA = "0x1D69770", Offset = "0x1D68170", VA = "0x181D69770", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002784")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C800", Offset = "0x1D6B200", VA = "0x181D6C800", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002785")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C310", Offset = "0x1D6AD10", VA = "0x181D6C310", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002786")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B300", Offset = "0x1D69D00", VA = "0x181D6B300", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002787")]
				[Cpp2IlInjected.Address(RVA = "0x1D6CDD0", Offset = "0x1D6B7D0", VA = "0x181D6CDD0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002788")]
				[Cpp2IlInjected.Address(RVA = "0x1D69DB0", Offset = "0x1D687B0", VA = "0x181D69DB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200040B")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C92")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C93")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C94")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C95")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000C96")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C97")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000731")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600278D")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F070", Offset = "0x1D7DA70", VA = "0x181D7F070")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000732")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600278E")]
					[Cpp2IlInjected.Address(RVA = "0x1D7ED50", Offset = "0x1D7D750", VA = "0x181D7ED50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000733")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600278F")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F570", Offset = "0x1D7DF70", VA = "0x181D7F570", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000734")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002793")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002794")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000735")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002795")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002796")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000736")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60027A2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60027A3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002790")]
				[Cpp2IlInjected.Address(RVA = "0x1D7D9E0", Offset = "0x1D7C3E0", VA = "0x181D7D9E0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002791")]
				[Cpp2IlInjected.Address(RVA = "0x1D7D790", Offset = "0x1D7C190", VA = "0x181D7D790")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002792")]
				[Cpp2IlInjected.Address(RVA = "0x1D76530", Offset = "0x1D74F30", VA = "0x181D76530", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002797")]
				[Cpp2IlInjected.Address(RVA = "0x1D77B90", Offset = "0x1D76590", VA = "0x181D77B90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002798")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002799")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600279A")]
				[Cpp2IlInjected.Address(RVA = "0x1D7BDA0", Offset = "0x1D7A7A0", VA = "0x181D7BDA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600279B")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600279C")]
				[Cpp2IlInjected.Address(RVA = "0x1D761F0", Offset = "0x1D74BF0", VA = "0x181D761F0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600279D")]
				[Cpp2IlInjected.Address(RVA = "0x1D7A410", Offset = "0x1D78E10", VA = "0x181D7A410", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600279E")]
				[Cpp2IlInjected.Address(RVA = "0x1D79A50", Offset = "0x1D78450", VA = "0x181D79A50", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600279F")]
				[Cpp2IlInjected.Address(RVA = "0x1D78910", Offset = "0x1D77310", VA = "0x181D78910", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027A0")]
				[Cpp2IlInjected.Address(RVA = "0x1D7B250", Offset = "0x1D79C50", VA = "0x181D7B250", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027A1")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027A4")]
				[Cpp2IlInjected.Address(RVA = "0x1D74D20", Offset = "0x1D73720", VA = "0x181D74D20", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000C83")]
		private static readonly MessageParser<UpdateDialogueFlags> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C84")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000728")]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateDialogueFlags> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002761")]
			[Cpp2IlInjected.Address(RVA = "0x15DA340", Offset = "0x15D8D40", VA = "0x1815DA340")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000729")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002762")]
			[Cpp2IlInjected.Address(RVA = "0x15DA270", Offset = "0x15D8C70", VA = "0x1815DA270")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700072A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002763")]
			[Cpp2IlInjected.Address(RVA = "0x15DA3A0", Offset = "0x15D8DA0", VA = "0x1815DA3A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002764")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UpdateDialogueFlags()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002765")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UpdateDialogueFlags(UpdateDialogueFlags other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002766")]
		[Cpp2IlInjected.Address(RVA = "0x15D9F90", Offset = "0x15D8990", VA = "0x1815D9F90", Slot = "10")]
		[DebuggerNonUserCode]
		public UpdateDialogueFlags Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UpdateDialogueFlags updateDialogueFlags = default(UpdateDialogueFlags);
			updateDialogueFlags.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (updateDialogueFlags._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return updateDialogueFlags;
		}

		[Cpp2IlInjected.Token(Token = "0x6002767")]
		[Cpp2IlInjected.Address(RVA = "0x15DA010", Offset = "0x15D8A10", VA = "0x1815DA010", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002768")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpdateDialogueFlags other)
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

		[Cpp2IlInjected.Token(Token = "0x6002769")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600276A")]
		[Cpp2IlInjected.Address(RVA = "0x15DA100", Offset = "0x15D8B00", VA = "0x1815DA100", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600276B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600276C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600276D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateDialogueFlags other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600276E")]
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

		[Cpp2IlInjected.Token(Token = "0x600276F")]
		[Cpp2IlInjected.Address(RVA = "0x15DA090", Offset = "0x15D8A90", VA = "0x1815DA090", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002770")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002771")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002772")]
		[Cpp2IlInjected.Address(RVA = "0x15DA160", Offset = "0x15D8B60", VA = "0x1815DA160")]
		static UpdateDialogueFlags()
		{
			Func<UpdateDialogueFlags> func = default(Func<UpdateDialogueFlags>);
			_parser = (MessageParser<UpdateDialogueFlags>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
