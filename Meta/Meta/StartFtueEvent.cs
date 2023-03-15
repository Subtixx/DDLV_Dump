using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004C6")]
	public sealed class StartFtueEvent : IMessage<StartFtueEvent>, IMessage, IEquatable<StartFtueEvent>, IDeepCloneable<StartFtueEvent>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004C7")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004C8")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000EE8")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000EE9")]
				[OriginalName("AlreadyDone")]
				AlreadyDone,
				[Cpp2IlInjected.Token(Token = "0x4000EEA")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000EEB")]
				[OriginalName("ProfileIsNull")]
				ProfileIsNull
			}

			[Cpp2IlInjected.Token(Token = "0x20004C9")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000EEC")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000EED")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000EEE")]
				public const int FtueItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000EEF")]
				private int ftueItemID_;

				[Cpp2IlInjected.Token(Token = "0x1700088E")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002E86")]
					[Cpp2IlInjected.Address(RVA = "0x15BDFC0", Offset = "0x15BC9C0", VA = "0x1815BDFC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700088F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E87")]
					[Cpp2IlInjected.Address(RVA = "0x15BDD60", Offset = "0x15BC760", VA = "0x1815BDD60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000890")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E88")]
					[Cpp2IlInjected.Address(RVA = "0x15BE920", Offset = "0x15BD320", VA = "0x1815BE920", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000891")]
				[DebuggerNonUserCode]
				public int FtueItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6002E8C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002E8D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002E89")]
				[Cpp2IlInjected.Address(RVA = "0x15BD7F0", Offset = "0x15BC1F0", VA = "0x1815BD7F0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E8A")]
				[Cpp2IlInjected.Address(RVA = "0x15BD5A0", Offset = "0x15BBFA0", VA = "0x1815BD5A0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E8B")]
				[Cpp2IlInjected.Address(RVA = "0x15B9C20", Offset = "0x15B8620", VA = "0x1815B9C20", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E8E")]
				[Cpp2IlInjected.Address(RVA = "0x15BA2C0", Offset = "0x15B8CC0", VA = "0x1815BA2C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E8F")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E90")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E91")]
				[Cpp2IlInjected.Address(RVA = "0x15BBFF0", Offset = "0x15BA9F0", VA = "0x1815BBFF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E92")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E93")]
				[Cpp2IlInjected.Address(RVA = "0x15B9450", Offset = "0x15B7E50", VA = "0x1815B9450", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E94")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E95")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E96")]
				[Cpp2IlInjected.Address(RVA = "0x15BA890", Offset = "0x15B9290", VA = "0x1815BA890", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002E97")]
				[Cpp2IlInjected.Address(RVA = "0x15BBA90", Offset = "0x15BA490", VA = "0x1815BBA90", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E98")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002E99")]
				[Cpp2IlInjected.Address(RVA = "0x15BC290", Offset = "0x15BAC90", VA = "0x1815BC290", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004CB")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000EF1")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000EF2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000EF3")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000EF4")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000EF5")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000EF6")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000892")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002E9E")]
					[Cpp2IlInjected.Address(RVA = "0x15C94D0", Offset = "0x15C7ED0", VA = "0x1815C94D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000893")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002E9F")]
					[Cpp2IlInjected.Address(RVA = "0x15C8EF0", Offset = "0x15C78F0", VA = "0x1815C8EF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000894")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002EA0")]
					[Cpp2IlInjected.Address(RVA = "0x15C9530", Offset = "0x15C7F30", VA = "0x1815C9530", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000895")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002EA4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002EA5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000896")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002EA6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002EA7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000897")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002EB3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002EB4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002EA1")]
				[Cpp2IlInjected.Address(RVA = "0x15C8A50", Offset = "0x15C7450", VA = "0x1815C8A50")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EA2")]
				[Cpp2IlInjected.Address(RVA = "0x15C7BB0", Offset = "0x15C65B0", VA = "0x1815C7BB0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EA3")]
				[Cpp2IlInjected.Address(RVA = "0x15C2FA0", Offset = "0x15C19A0", VA = "0x1815C2FA0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EA8")]
				[Cpp2IlInjected.Address(RVA = "0x15C41A0", Offset = "0x15C2BA0", VA = "0x1815C41A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EA9")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EAA")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EAB")]
				[Cpp2IlInjected.Address(RVA = "0x15C6C70", Offset = "0x15C5670", VA = "0x1815C6C70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EAC")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EAD")]
				[Cpp2IlInjected.Address(RVA = "0x15C2960", Offset = "0x15C1360", VA = "0x1815C2960", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002EAE")]
				[Cpp2IlInjected.Address(RVA = "0x15C5750", Offset = "0x15C4150", VA = "0x1815C5750", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EAF")]
				[Cpp2IlInjected.Address(RVA = "0x15C5E70", Offset = "0x15C4870", VA = "0x1815C5E70", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EB0")]
				[Cpp2IlInjected.Address(RVA = "0x15C4B60", Offset = "0x15C3560", VA = "0x1815C4B60", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002EB1")]
				[Cpp2IlInjected.Address(RVA = "0x15C65D0", Offset = "0x15C4FD0", VA = "0x1815C65D0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EB2")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002EB5")]
				[Cpp2IlInjected.Address(RVA = "0x15C1460", Offset = "0x15BFE60", VA = "0x1815C1460", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000EE5")]
		private static readonly MessageParser<StartFtueEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000EE6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700088B")]
		[DebuggerNonUserCode]
		public static MessageParser<StartFtueEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002E74")]
			[Cpp2IlInjected.Address(RVA = "0xC037F0", Offset = "0xC021F0", VA = "0x180C037F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700088C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E75")]
			[Cpp2IlInjected.Address(RVA = "0xC03720", Offset = "0xC02120", VA = "0x180C03720")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700088D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E76")]
			[Cpp2IlInjected.Address(RVA = "0xC03850", Offset = "0xC02250", VA = "0x180C03850", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E77")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StartFtueEvent()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E78")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StartFtueEvent(StartFtueEvent other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E79")]
		[Cpp2IlInjected.Address(RVA = "0xC03440", Offset = "0xC01E40", VA = "0x180C03440", Slot = "10")]
		[DebuggerNonUserCode]
		public StartFtueEvent Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StartFtueEvent startFtueEvent = default(StartFtueEvent);
			startFtueEvent.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (startFtueEvent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return startFtueEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E7A")]
		[Cpp2IlInjected.Address(RVA = "0xC034C0", Offset = "0xC01EC0", VA = "0x180C034C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E7B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StartFtueEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x6002E7C")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E7D")]
		[Cpp2IlInjected.Address(RVA = "0xC035B0", Offset = "0xC01FB0", VA = "0x180C035B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E7E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E7F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E80")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StartFtueEvent other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E81")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E82")]
		[Cpp2IlInjected.Address(RVA = "0xC03540", Offset = "0xC01F40", VA = "0x180C03540", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E83")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E84")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E85")]
		[Cpp2IlInjected.Address(RVA = "0xC03610", Offset = "0xC02010", VA = "0x180C03610")]
		static StartFtueEvent()
		{
			Func<StartFtueEvent> func = default(Func<StartFtueEvent>);
			_parser = (MessageParser<StartFtueEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
