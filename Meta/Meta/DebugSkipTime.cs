using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000266")]
	public sealed class DebugSkipTime : IMessage<DebugSkipTime>, IMessage, IEquatable<DebugSkipTime>, IDeepCloneable<DebugSkipTime>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000267")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000268")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40007CF")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40007D0")]
				[OriginalName("NotDeveloper")]
				NotDeveloper,
				[Cpp2IlInjected.Token(Token = "0x40007D1")]
				[OriginalName("InvalidTimer")]
				InvalidTimer
			}

			[Cpp2IlInjected.Token(Token = "0x2000269")]
			public enum TimerType
			{
				[Cpp2IlInjected.Token(Token = "0x40007D3")]
				[OriginalName("Gameplay")]
				Gameplay,
				[Cpp2IlInjected.Token(Token = "0x40007D4")]
				[OriginalName("Online")]
				Online
			}

			[Cpp2IlInjected.Token(Token = "0x200026A")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40007D5")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40007D6")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40007D7")]
				public const int TimeToSkipFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40007D8")]
				private Duration timeToSkip_;

				[Cpp2IlInjected.Token(Token = "0x40007D9")]
				public const int ResetSkipTimeFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40007DA")]
				private bool resetSkipTime_;

				[Cpp2IlInjected.Token(Token = "0x40007DB")]
				public const int TimerTypeFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40007DC")]
				private TimerType timerType_;

				[Cpp2IlInjected.Token(Token = "0x17000471")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60018BD")]
					[Cpp2IlInjected.Address(RVA = "0x211B8A0", Offset = "0x211A2A0", VA = "0x18211B8A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000472")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60018BE")]
					[Cpp2IlInjected.Address(RVA = "0x211B700", Offset = "0x211A100", VA = "0x18211B700")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000473")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60018BF")]
					[Cpp2IlInjected.Address(RVA = "0x211C680", Offset = "0x211B080", VA = "0x18211C680", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000474")]
				[DebuggerNonUserCode]
				public Duration TimeToSkip
				{
					[Cpp2IlInjected.Token(Token = "0x60018C3")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60018C4")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000475")]
				[DebuggerNonUserCode]
				public bool ResetSkipTime
				{
					[Cpp2IlInjected.Token(Token = "0x60018C5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60018C6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000476")]
				[DebuggerNonUserCode]
				public TimerType TimerType
				{
					[Cpp2IlInjected.Token(Token = "0x60018C7")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(TimerType);
					}
					[Cpp2IlInjected.Token(Token = "0x60018C8")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60018C0")]
				[Cpp2IlInjected.Address(RVA = "0x211ACB0", Offset = "0x21196B0", VA = "0x18211ACB0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018C1")]
				[Cpp2IlInjected.Address(RVA = "0x211AB90", Offset = "0x2119590", VA = "0x18211AB90")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018C2")]
				[Cpp2IlInjected.Address(RVA = "0x2115B90", Offset = "0x2114590", VA = "0x182115B90", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60018C9")]
				[Cpp2IlInjected.Address(RVA = "0x2116E90", Offset = "0x2115890", VA = "0x182116E90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60018CA")]
				[Cpp2IlInjected.Address(RVA = "0x21169E0", Offset = "0x21153E0", VA = "0x1821169E0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60018CB")]
				[Cpp2IlInjected.Address(RVA = "0x2117C20", Offset = "0x2116620", VA = "0x182117C20", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60018CC")]
				[Cpp2IlInjected.Address(RVA = "0x2118EA0", Offset = "0x21178A0", VA = "0x182118EA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60018CD")]
				[Cpp2IlInjected.Address(RVA = "0x2119600", Offset = "0x2118000", VA = "0x182119600", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018CE")]
				[Cpp2IlInjected.Address(RVA = "0x21152F0", Offset = "0x2113CF0", VA = "0x1821152F0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60018CF")]
				[Cpp2IlInjected.Address(RVA = "0x2117CD0", Offset = "0x21166D0", VA = "0x182117CD0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018D0")]
				[Cpp2IlInjected.Address(RVA = "0x2117EE0", Offset = "0x21168E0", VA = "0x182117EE0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018D1")]
				[Cpp2IlInjected.Address(RVA = "0x2117970", Offset = "0x2116370", VA = "0x182117970", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60018D2")]
				[Cpp2IlInjected.Address(RVA = "0x21185A0", Offset = "0x2116FA0", VA = "0x1821185A0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018D3")]
				[Cpp2IlInjected.Address(RVA = "0x2115AA0", Offset = "0x21144A0", VA = "0x182115AA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018D4")]
				[Cpp2IlInjected.Address(RVA = "0x2119310", Offset = "0x2117D10", VA = "0x182119310", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200026C")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40007DE")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40007DF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40007E0")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40007E1")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40007E2")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40007E3")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000477")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60018D9")]
					[Cpp2IlInjected.Address(RVA = "0x2129820", Offset = "0x2128220", VA = "0x182129820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000478")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60018DA")]
					[Cpp2IlInjected.Address(RVA = "0x2128F20", Offset = "0x2127920", VA = "0x182128F20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000479")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60018DB")]
					[Cpp2IlInjected.Address(RVA = "0x2129E80", Offset = "0x2128880", VA = "0x182129E80", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700047A")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60018DF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60018E0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700047B")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60018E1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60018E2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700047C")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60018EE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60018EF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60018DC")]
				[Cpp2IlInjected.Address(RVA = "0x21281F0", Offset = "0x2126BF0", VA = "0x1821281F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018DD")]
				[Cpp2IlInjected.Address(RVA = "0x21282F0", Offset = "0x2126CF0", VA = "0x1821282F0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018DE")]
				[Cpp2IlInjected.Address(RVA = "0x21216E0", Offset = "0x21200E0", VA = "0x1821216E0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60018E3")]
				[Cpp2IlInjected.Address(RVA = "0x2122120", Offset = "0x2120B20", VA = "0x182122120", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60018E4")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60018E5")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60018E6")]
				[Cpp2IlInjected.Address(RVA = "0x21264C0", Offset = "0x2124EC0", VA = "0x1821264C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60018E7")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018E8")]
				[Cpp2IlInjected.Address(RVA = "0x2120420", Offset = "0x211EE20", VA = "0x182120420", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60018E9")]
				[Cpp2IlInjected.Address(RVA = "0x21248D0", Offset = "0x21232D0", VA = "0x1821248D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018EA")]
				[Cpp2IlInjected.Address(RVA = "0x2123740", Offset = "0x2122140", VA = "0x182123740", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018EB")]
				[Cpp2IlInjected.Address(RVA = "0x2122D30", Offset = "0x2121730", VA = "0x182122D30", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60018EC")]
				[Cpp2IlInjected.Address(RVA = "0x2125FF0", Offset = "0x21249F0", VA = "0x182125FF0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018ED")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60018F0")]
				[Cpp2IlInjected.Address(RVA = "0x211E670", Offset = "0x211D070", VA = "0x18211E670", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		private static readonly MessageParser<DebugSkipTime> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700046E")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugSkipTime> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60018AB")]
			[Cpp2IlInjected.Address(RVA = "0x1A16750", Offset = "0x1A15150", VA = "0x181A16750")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60018AC")]
			[Cpp2IlInjected.Address(RVA = "0x1A16680", Offset = "0x1A15080", VA = "0x181A16680")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000470")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60018AD")]
			[Cpp2IlInjected.Address(RVA = "0x1A167B0", Offset = "0x1A151B0", VA = "0x181A167B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018AE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugSkipTime()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60018AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugSkipTime(DebugSkipTime other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60018B0")]
		[Cpp2IlInjected.Address(RVA = "0x1A163A0", Offset = "0x1A14DA0", VA = "0x181A163A0", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugSkipTime Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugSkipTime debugSkipTime = default(DebugSkipTime);
			debugSkipTime.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugSkipTime._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugSkipTime;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B1")]
		[Cpp2IlInjected.Address(RVA = "0x1A16420", Offset = "0x1A14E20", VA = "0x181A16420", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60018B2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugSkipTime other)
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

		[Cpp2IlInjected.Token(Token = "0x60018B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B4")]
		[Cpp2IlInjected.Address(RVA = "0x1A16510", Offset = "0x1A14F10", VA = "0x181A16510", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60018B5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60018B6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugSkipTime other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018B8")]
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

		[Cpp2IlInjected.Token(Token = "0x60018B9")]
		[Cpp2IlInjected.Address(RVA = "0x1A164A0", Offset = "0x1A14EA0", VA = "0x181A164A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60018BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60018BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60018BC")]
		[Cpp2IlInjected.Address(RVA = "0x1A16570", Offset = "0x1A14F70", VA = "0x181A16570")]
		static DebugSkipTime()
		{
			Func<DebugSkipTime> func = default(Func<DebugSkipTime>);
			_parser = (MessageParser<DebugSkipTime>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
