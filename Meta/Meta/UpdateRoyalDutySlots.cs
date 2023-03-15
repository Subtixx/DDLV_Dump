using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Duties;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000570")]
	public sealed class UpdateRoyalDutySlots : IMessage<UpdateRoyalDutySlots>, IMessage, IEquatable<UpdateRoyalDutySlots>, IDeepCloneable<UpdateRoyalDutySlots>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000571")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000572")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40010A9")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40010AA")]
				[OriginalName("Error")]
				Error,
				[Cpp2IlInjected.Token(Token = "0x40010AB")]
				[OriginalName("NotReady")]
				NotReady
			}

			[Cpp2IlInjected.Token(Token = "0x2000573")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40010AC")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40010AD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x170009B1")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60034A6")]
					[Cpp2IlInjected.Address(RVA = "0x1D71000", Offset = "0x1D6FA00", VA = "0x181D71000")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60034A7")]
					[Cpp2IlInjected.Address(RVA = "0x1D70960", Offset = "0x1D6F360", VA = "0x181D70960")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60034A8")]
					[Cpp2IlInjected.Address(RVA = "0x1D718A0", Offset = "0x1D702A0", VA = "0x181D718A0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60034A9")]
				[Cpp2IlInjected.Address(RVA = "0x1D701B0", Offset = "0x1D6EBB0", VA = "0x181D701B0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034AA")]
				[Cpp2IlInjected.Address(RVA = "0x1D703D0", Offset = "0x1D6EDD0", VA = "0x181D703D0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034AB")]
				[Cpp2IlInjected.Address(RVA = "0x1D69F70", Offset = "0x1D68970", VA = "0x181D69F70", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60034AC")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A930", Offset = "0x1D69330", VA = "0x181D6A930", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60034AD")]
				[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60034AE")]
				[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60034AF")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D410", Offset = "0x1D6BE10", VA = "0x181D6D410", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60034B0")]
				[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034B1")]
				[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60034B2")]
				[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034B3")]
				[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034B4")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B900", Offset = "0x1D6A300", VA = "0x181D6B900", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60034B5")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034B6")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034B7")]
				[Cpp2IlInjected.Address(RVA = "0x1D6DED0", Offset = "0x1D6C8D0", VA = "0x181D6DED0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000575")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40010AF")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40010B0")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40010B1")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40010B2")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40010B3")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40010B4")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170009B4")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60034BC")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F310", Offset = "0x1D7DD10", VA = "0x181D7F310")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60034BD")]
					[Cpp2IlInjected.Address(RVA = "0x1D7E9D0", Offset = "0x1D7D3D0", VA = "0x181D7E9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60034BE")]
					[Cpp2IlInjected.Address(RVA = "0x1D7FB70", Offset = "0x1D7E570", VA = "0x181D7FB70", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B7")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60034C2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60034C3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B8")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60034C4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60034C5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B9")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60034D1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60034D2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60034BF")]
				[Cpp2IlInjected.Address(RVA = "0x1D7DB20", Offset = "0x1D7C520", VA = "0x181D7DB20")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034C0")]
				[Cpp2IlInjected.Address(RVA = "0x1D7E6F0", Offset = "0x1D7D0F0", VA = "0x181D7E6F0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034C1")]
				[Cpp2IlInjected.Address(RVA = "0x1D77360", Offset = "0x1D75D60", VA = "0x181D77360", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60034C6")]
				[Cpp2IlInjected.Address(RVA = "0x1D77A30", Offset = "0x1D76430", VA = "0x181D77A30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60034C7")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60034C8")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60034C9")]
				[Cpp2IlInjected.Address(RVA = "0x1D7C100", Offset = "0x1D7AB00", VA = "0x181D7C100", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60034CA")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034CB")]
				[Cpp2IlInjected.Address(RVA = "0x1D75B70", Offset = "0x1D74570", VA = "0x181D75B70", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60034CC")]
				[Cpp2IlInjected.Address(RVA = "0x1D7A8E0", Offset = "0x1D792E0", VA = "0x181D7A8E0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034CD")]
				[Cpp2IlInjected.Address(RVA = "0x1D7A560", Offset = "0x1D78F60", VA = "0x181D7A560", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034CE")]
				[Cpp2IlInjected.Address(RVA = "0x1D786A0", Offset = "0x1D770A0", VA = "0x181D786A0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60034CF")]
				[Cpp2IlInjected.Address(RVA = "0x1D7B6C0", Offset = "0x1D7A0C0", VA = "0x181D7B6C0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034D0")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60034D3")]
				[Cpp2IlInjected.Address(RVA = "0x1D742A0", Offset = "0x1D72CA0", VA = "0x181D742A0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60034D4")]
				[Cpp2IlInjected.Address(RVA = "0x1D7C460", Offset = "0x1D7AE60", VA = "0x181D7C460")]
				private void UpdateRoyalDutySlots(RepeatedField<DutySlot> slots, in Player player, ITransactionContext transactionContext)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40010A6")]
		private static readonly MessageParser<UpdateRoyalDutySlots> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40010A7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170009AE")]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateRoyalDutySlots> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003494")]
			[Cpp2IlInjected.Address(RVA = "0x15DBE60", Offset = "0x15DA860", VA = "0x1815DBE60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009AF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003495")]
			[Cpp2IlInjected.Address(RVA = "0x15DBD90", Offset = "0x15DA790", VA = "0x1815DBD90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009B0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003496")]
			[Cpp2IlInjected.Address(RVA = "0x15DBEC0", Offset = "0x15DA8C0", VA = "0x1815DBEC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003497")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UpdateRoyalDutySlots()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6003498")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UpdateRoyalDutySlots(UpdateRoyalDutySlots other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003499")]
		[Cpp2IlInjected.Address(RVA = "0x15DBAB0", Offset = "0x15DA4B0", VA = "0x1815DBAB0", Slot = "10")]
		[DebuggerNonUserCode]
		public UpdateRoyalDutySlots Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UpdateRoyalDutySlots updateRoyalDutySlots = default(UpdateRoyalDutySlots);
			updateRoyalDutySlots.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (updateRoyalDutySlots._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return updateRoyalDutySlots;
		}

		[Cpp2IlInjected.Token(Token = "0x600349A")]
		[Cpp2IlInjected.Address(RVA = "0x15DBB30", Offset = "0x15DA530", VA = "0x1815DBB30", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600349B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpdateRoyalDutySlots other)
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

		[Cpp2IlInjected.Token(Token = "0x600349C")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600349D")]
		[Cpp2IlInjected.Address(RVA = "0x15DBC20", Offset = "0x15DA620", VA = "0x1815DBC20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600349E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600349F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60034A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateRoyalDutySlots other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034A1")]
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

		[Cpp2IlInjected.Token(Token = "0x60034A2")]
		[Cpp2IlInjected.Address(RVA = "0x15DBBB0", Offset = "0x15DA5B0", VA = "0x1815DBBB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034A3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034A5")]
		[Cpp2IlInjected.Address(RVA = "0x15DBC80", Offset = "0x15DA680", VA = "0x1815DBC80")]
		static UpdateRoyalDutySlots()
		{
			Func<UpdateRoyalDutySlots> func = default(Func<UpdateRoyalDutySlots>);
			_parser = (MessageParser<UpdateRoyalDutySlots>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
