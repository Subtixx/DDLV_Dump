using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B4B")]
	public sealed class SpendEntryTickets : IMessage<SpendEntryTickets>, IMessage, IEquatable<SpendEntryTickets>, IDeepCloneable<SpendEntryTickets>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000B4C")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000B4D")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002BDB")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002BDC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002BDD")]
				public const int ChallengeIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002BDE")]
				private string challengeID_;

				[Cpp2IlInjected.Token(Token = "0x17001065")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB4")]
					[Cpp2IlInjected.Address(RVA = "0x15BE020", Offset = "0x15BCA20", VA = "0x1815BE020")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001066")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB5")]
					[Cpp2IlInjected.Address(RVA = "0x15BDA60", Offset = "0x15BC460", VA = "0x1815BDA60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001067")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB6")]
					[Cpp2IlInjected.Address(RVA = "0x15BE9E0", Offset = "0x15BD3E0", VA = "0x1815BE9E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001068")]
				[DebuggerNonUserCode]
				public string ChallengeID
				{
					[Cpp2IlInjected.Token(Token = "0x6005FBA")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005FBB")]
					[Cpp2IlInjected.Address(RVA = "0x15BEAA0", Offset = "0x15BD4A0", VA = "0x1815BEAA0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005FB7")]
				[Cpp2IlInjected.Address(RVA = "0x15BD760", Offset = "0x15BC160", VA = "0x1815BD760")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FB8")]
				[Cpp2IlInjected.Address(RVA = "0x15BD480", Offset = "0x15BBE80", VA = "0x1815BD480")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FB9")]
				[Cpp2IlInjected.Address(RVA = "0x15B9930", Offset = "0x15B8330", VA = "0x1815B9930", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FBC")]
				[Cpp2IlInjected.Address(RVA = "0x15BA3E0", Offset = "0x15B8DE0", VA = "0x1815BA3E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FBD")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FBE")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FBF")]
				[Cpp2IlInjected.Address(RVA = "0x15BBF30", Offset = "0x15BA930", VA = "0x1815BBF30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC0")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC1")]
				[Cpp2IlInjected.Address(RVA = "0x15B9140", Offset = "0x15B7B40", VA = "0x1815B9140", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC2")]
				[Cpp2IlInjected.Address(RVA = "0x15BB270", Offset = "0x15B9C70", VA = "0x1815BB270", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC3")]
				[Cpp2IlInjected.Address(RVA = "0x15BB5B0", Offset = "0x15B9FB0", VA = "0x1815BB5B0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC4")]
				[Cpp2IlInjected.Address(RVA = "0x15BADA0", Offset = "0x15B97A0", VA = "0x1815BADA0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC5")]
				[Cpp2IlInjected.Address(RVA = "0x15BBB90", Offset = "0x15BA590", VA = "0x1815BBB90", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC6")]
				[Cpp2IlInjected.Address(RVA = "0x15B9800", Offset = "0x15B8200", VA = "0x1815B9800", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000B4F")]
			public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002BE0")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002BE1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002BE2")]
				public const int ItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002BE3")]
				private static readonly FieldCodec<ItemReward> _repeated_items_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002BE4")]
				private readonly RepeatedField<ItemReward> items_;

				[Cpp2IlInjected.Token(Token = "0x17001069")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005FCB")]
					[Cpp2IlInjected.Address(RVA = "0x15C92F0", Offset = "0x15C7CF0", VA = "0x1815C92F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700106A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005FCC")]
					[Cpp2IlInjected.Address(RVA = "0x15C8F70", Offset = "0x15C7970", VA = "0x1815C8F70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700106B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005FCD")]
					[Cpp2IlInjected.Address(RVA = "0x15C9B30", Offset = "0x15C8530", VA = "0x1815C9B30", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700106C")]
				[DebuggerNonUserCode]
				public RepeatedField<ItemReward> Items
				{
					[Cpp2IlInjected.Token(Token = "0x6005FD1")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005FCE")]
				[Cpp2IlInjected.Address(RVA = "0x15C8AD0", Offset = "0x15C74D0", VA = "0x1815C8AD0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FCF")]
				[Cpp2IlInjected.Address(RVA = "0x15C86B0", Offset = "0x15C70B0", VA = "0x1815C86B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD0")]
				[Cpp2IlInjected.Address(RVA = "0x15C3660", Offset = "0x15C2060", VA = "0x1815C3660", Slot = "10")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD2")]
				[Cpp2IlInjected.Address(RVA = "0x15C3D50", Offset = "0x15C2750", VA = "0x1815C3D50", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD3")]
				[Cpp2IlInjected.Address(RVA = "0x15C3E30", Offset = "0x15C2830", VA = "0x1815C3E30", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD4")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD5")]
				[Cpp2IlInjected.Address(RVA = "0x15C6C10", Offset = "0x15C5610", VA = "0x1815C6C10", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD6")]
				[Cpp2IlInjected.Address(RVA = "0x15C6F90", Offset = "0x15C5990", VA = "0x1815C6F90", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD7")]
				[Cpp2IlInjected.Address(RVA = "0x15C2710", Offset = "0x15C1110", VA = "0x1815C2710", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD8")]
				[Cpp2IlInjected.Address(RVA = "0x15C6100", Offset = "0x15C4B00", VA = "0x1815C6100", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FD9")]
				[Cpp2IlInjected.Address(RVA = "0x15C5350", Offset = "0x15C3D50", VA = "0x1815C5350", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FDA")]
				[Cpp2IlInjected.Address(RVA = "0x15C4AE0", Offset = "0x15C34E0", VA = "0x1815C4AE0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FDB")]
				[Cpp2IlInjected.Address(RVA = "0x15C63D0", Offset = "0x15C4DD0", VA = "0x1815C63D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FDC")]
				[Cpp2IlInjected.Address(RVA = "0x15C2F40", Offset = "0x15C1940", VA = "0x1815C2F40", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002BD9")]
		private static readonly MessageParser<SpendEntryTickets> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BDA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001062")]
		[DebuggerNonUserCode]
		public static MessageParser<SpendEntryTickets> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005FA2")]
			[Cpp2IlInjected.Address(RVA = "0xC02890", Offset = "0xC01290", VA = "0x180C02890")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001063")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005FA3")]
			[Cpp2IlInjected.Address(RVA = "0xC027C0", Offset = "0xC011C0", VA = "0x180C027C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001064")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005FA4")]
			[Cpp2IlInjected.Address(RVA = "0xC028F0", Offset = "0xC012F0", VA = "0x180C028F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SpendEntryTickets()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SpendEntryTickets(SpendEntryTickets other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA7")]
		[Cpp2IlInjected.Address(RVA = "0xC024E0", Offset = "0xC00EE0", VA = "0x180C024E0", Slot = "10")]
		[DebuggerNonUserCode]
		public SpendEntryTickets Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SpendEntryTickets spendEntryTickets = default(SpendEntryTickets);
			spendEntryTickets.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (spendEntryTickets._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return spendEntryTickets;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA8")]
		[Cpp2IlInjected.Address(RVA = "0xC02560", Offset = "0xC00F60", VA = "0x180C02560", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6005FA9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SpendEntryTickets other)
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

		[Cpp2IlInjected.Token(Token = "0x6005FAA")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAB")]
		[Cpp2IlInjected.Address(RVA = "0xC02650", Offset = "0xC01050", VA = "0x180C02650", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SpendEntryTickets other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAF")]
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

		[Cpp2IlInjected.Token(Token = "0x6005FB0")]
		[Cpp2IlInjected.Address(RVA = "0xC025E0", Offset = "0xC00FE0", VA = "0x180C025E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FB1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005FB2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005FB3")]
		[Cpp2IlInjected.Address(RVA = "0xC026B0", Offset = "0xC010B0", VA = "0x180C026B0")]
		static SpendEntryTickets()
		{
			Func<SpendEntryTickets> func = default(Func<SpendEntryTickets>);
			_parser = (MessageParser<SpendEntryTickets>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
