using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004EE")]
	public sealed class TrackClaimedFoundersPack : IMessage<TrackClaimedFoundersPack>, IMessage, IEquatable<TrackClaimedFoundersPack>, IDeepCloneable<TrackClaimedFoundersPack>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004EF")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004F0")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000F52")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000F53")]
				[OriginalName("InvalidName")]
				InvalidName,
				[Cpp2IlInjected.Token(Token = "0x4000F54")]
				[OriginalName("AlreadyTracked")]
				AlreadyTracked
			}

			[Cpp2IlInjected.Token(Token = "0x20004F1")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F55")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F56")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F57")]
				public const int FoundersPackNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F58")]
				private string foundersPackName_;

				[Cpp2IlInjected.Token(Token = "0x4000F59")]
				public const int FoundersPackOnlineIdFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000F5A")]
				private string foundersPackOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x170008D3")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003000")]
					[Cpp2IlInjected.Address(RVA = "0xD090A0", Offset = "0xD07AA0", VA = "0x180D090A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008D4")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003001")]
					[Cpp2IlInjected.Address(RVA = "0xD08F40", Offset = "0xD07940", VA = "0x180D08F40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008D5")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003002")]
					[Cpp2IlInjected.Address(RVA = "0xD091C0", Offset = "0xD07BC0", VA = "0x180D091C0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008D6")]
				[DebuggerNonUserCode]
				public string FoundersPackName
				{
					[Cpp2IlInjected.Token(Token = "0x6003006")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003007")]
					[Cpp2IlInjected.Address(RVA = "0xD09280", Offset = "0xD07C80", VA = "0x180D09280")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008D7")]
				[DebuggerNonUserCode]
				public string FoundersPackOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6003008")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003009")]
					[Cpp2IlInjected.Address(RVA = "0xD092F0", Offset = "0xD07CF0", VA = "0x180D092F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003003")]
				[Cpp2IlInjected.Address(RVA = "0xD08DF0", Offset = "0xD077F0", VA = "0x180D08DF0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003004")]
				[Cpp2IlInjected.Address(RVA = "0xD08E60", Offset = "0xD07860", VA = "0x180D08E60")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003005")]
				[Cpp2IlInjected.Address(RVA = "0xD08430", Offset = "0xD06E30", VA = "0x180D08430", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600300A")]
				[Cpp2IlInjected.Address(RVA = "0xD085D0", Offset = "0xD06FD0", VA = "0x180D085D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600300B")]
				[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600300C")]
				[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600300D")]
				[Cpp2IlInjected.Address(RVA = "0xD08AF0", Offset = "0xD074F0", VA = "0x180D08AF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600300E")]
				[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600300F")]
				[Cpp2IlInjected.Address(RVA = "0xD08180", Offset = "0xD06B80", VA = "0x180D08180", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003010")]
				[Cpp2IlInjected.Address(RVA = "0xD087D0", Offset = "0xD071D0", VA = "0x180D087D0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003011")]
				[Cpp2IlInjected.Address(RVA = "0xD08850", Offset = "0xD07250", VA = "0x180D08850", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003012")]
				[Cpp2IlInjected.Address(RVA = "0xD08740", Offset = "0xD07140", VA = "0x180D08740", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003013")]
				[Cpp2IlInjected.Address(RVA = "0xD08900", Offset = "0xD07300", VA = "0x180D08900", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003014")]
				[Cpp2IlInjected.Address(RVA = "0xD08300", Offset = "0xD06D00", VA = "0x180D08300", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003015")]
				[Cpp2IlInjected.Address(RVA = "0xD08B50", Offset = "0xD07550", VA = "0x180D08B50", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004F3")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000F5C")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000F5D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000F5E")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000F5F")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000F60")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000F61")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170008D8")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600301A")]
					[Cpp2IlInjected.Address(RVA = "0xD0C920", Offset = "0xD0B320", VA = "0x180D0C920")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008D9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600301B")]
					[Cpp2IlInjected.Address(RVA = "0xD0C6E0", Offset = "0xD0B0E0", VA = "0x180D0C6E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008DA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600301C")]
					[Cpp2IlInjected.Address(RVA = "0xD0C980", Offset = "0xD0B380", VA = "0x180D0C980", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008DB")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6003020")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6003021")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008DC")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6003022")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003023")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170008DD")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600302F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6003030")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600301D")]
				[Cpp2IlInjected.Address(RVA = "0xD0C180", Offset = "0xD0AB80", VA = "0x180D0C180")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600301E")]
				[Cpp2IlInjected.Address(RVA = "0xD0C1C0", Offset = "0xD0ABC0", VA = "0x180D0C1C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600301F")]
				[Cpp2IlInjected.Address(RVA = "0xD09D30", Offset = "0xD08730", VA = "0x180D09D30", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003024")]
				[Cpp2IlInjected.Address(RVA = "0xD0A3E0", Offset = "0xD08DE0", VA = "0x180D0A3E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003025")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003026")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003027")]
				[Cpp2IlInjected.Address(RVA = "0xD0BA80", Offset = "0xD0A480", VA = "0x180D0BA80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003028")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003029")]
				[Cpp2IlInjected.Address(RVA = "0xD09B90", Offset = "0xD08590", VA = "0x180D09B90", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600302A")]
				[Cpp2IlInjected.Address(RVA = "0xD0AA80", Offset = "0xD09480", VA = "0x180D0AA80", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600302B")]
				[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD099A0", VA = "0x180D0AFA0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600302C")]
				[Cpp2IlInjected.Address(RVA = "0xD0A6C0", Offset = "0xD090C0", VA = "0x180D0A6C0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600302D")]
				[Cpp2IlInjected.Address(RVA = "0xD0B6F0", Offset = "0xD0A0F0", VA = "0x180D0B6F0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600302E")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003031")]
				[Cpp2IlInjected.Address(RVA = "0xD097C0", Offset = "0xD081C0", VA = "0x180D097C0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000F4F")]
		private static readonly MessageParser<TrackClaimedFoundersPack> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F50")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170008D0")]
		[DebuggerNonUserCode]
		public static MessageParser<TrackClaimedFoundersPack> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002FE8")]
			[Cpp2IlInjected.Address(RVA = "0x78B120", Offset = "0x789B20", VA = "0x18078B120")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002FE9")]
			[Cpp2IlInjected.Address(RVA = "0x78B050", Offset = "0x789A50", VA = "0x18078B050")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002FEA")]
			[Cpp2IlInjected.Address(RVA = "0x78B180", Offset = "0x789B80", VA = "0x18078B180", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FEB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TrackClaimedFoundersPack()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FEC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public TrackClaimedFoundersPack(TrackClaimedFoundersPack other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FED")]
		[Cpp2IlInjected.Address(RVA = "0x78AB60", Offset = "0x789560", VA = "0x18078AB60", Slot = "10")]
		[DebuggerNonUserCode]
		public TrackClaimedFoundersPack Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			TrackClaimedFoundersPack trackClaimedFoundersPack = default(TrackClaimedFoundersPack);
			trackClaimedFoundersPack.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (trackClaimedFoundersPack._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return trackClaimedFoundersPack;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FEE")]
		[Cpp2IlInjected.Address(RVA = "0x78ABE0", Offset = "0x7895E0", VA = "0x18078ABE0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002FEF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TrackClaimedFoundersPack other)
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

		[Cpp2IlInjected.Token(Token = "0x6002FF0")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF1")]
		[Cpp2IlInjected.Address(RVA = "0x78ADE0", Offset = "0x7897E0", VA = "0x18078ADE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TrackClaimedFoundersPack other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF5")]
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

		[Cpp2IlInjected.Token(Token = "0x6002FF6")]
		[Cpp2IlInjected.Address(RVA = "0x78AC60", Offset = "0x789660", VA = "0x18078AC60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF9")]
		[Cpp2IlInjected.Address(RVA = "0x78AD20", Offset = "0x789720", VA = "0x18078AD20")]
		public static bool IsValidName(string friendlyName)
		{
			if (friendlyName != null && friendlyName.StartsWith("FoundersPack"))
			{
				return true;
			}
			if (friendlyName != null)
			{
				return friendlyName.StartsWith("MoonstonePack");
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FFA")]
		[Cpp2IlInjected.Address(RVA = "0x78ACD0", Offset = "0x7896D0", VA = "0x18078ACD0")]
		public static bool IsValidMoonstonePack(string friendlyName)
		{
			if (friendlyName != null)
			{
				return friendlyName.StartsWith("MoonstonePack");
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FFB")]
		[Cpp2IlInjected.Address(RVA = "0x78A890", Offset = "0x789290", VA = "0x18078A890")]
		public static void AddClaimdata(Profile player, string ID)
		{
			//Discarded unreachable code: IL_0012
			((RepeatedField<T>)(object)player.gameInfo_.historys_).Add((T)ID);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FFC")]
		[Cpp2IlInjected.Address(RVA = "0x78AEB0", Offset = "0x7898B0", VA = "0x18078AEB0")]
		public static bool ValidHistory(Profile player, string ID)
		{
			//Discarded unreachable code: IL_0015
			return !((RepeatedField<T>)(object)player.gameInfo_.historys_).Contains((T)ID);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FFD")]
		[Cpp2IlInjected.Address(RVA = "0x78A900", Offset = "0x789300", VA = "0x18078A900")]
		public static void AddClaimedFoundersPack(in Player player, ITransactionContext transactionContext, string foundersPackName, string transactionID, bool isAccurate)
		{
			//Discarded unreachable code: IL_0055
			do
			{
				if (foundersPackName.EndsWith("_OnlineRecipe"))
				{
					int stringLength = foundersPackName.m_stringLength;
					int startIndex = 0;
					string text = foundersPackName.Substring(startIndex, stringLength);
				}
			}
			while (!foundersPackName.EndsWith("_OnlineKey"));
			int stringLength2 = foundersPackName.m_stringLength;
			int startIndex2 = 0;
			bool flag = default(bool);
			if (foundersPackName.Substring(startIndex2, stringLength2) == null && !flag)
			{
				IPlayerEventDispatcher dispatcher = player.dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FFE")]
		[Cpp2IlInjected.Address(RVA = "0x78AF40", Offset = "0x789940", VA = "0x18078AF40")]
		static TrackClaimedFoundersPack()
		{
			Func<TrackClaimedFoundersPack> func = default(Func<TrackClaimedFoundersPack>);
			_parser = (MessageParser<TrackClaimedFoundersPack>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
