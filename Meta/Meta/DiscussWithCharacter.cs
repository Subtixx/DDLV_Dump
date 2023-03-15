using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	public sealed class DiscussWithCharacter : IMessage<DiscussWithCharacter>, IMessage, IEquatable<DiscussWithCharacter>, IDeepCloneable<DiscussWithCharacter>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200022F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000230")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000746")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000747")]
				[OriginalName("DoesNotOwn")]
				DoesNotOwn,
				[Cpp2IlInjected.Token(Token = "0x4000748")]
				[OriginalName("InvalidDiscussion")]
				InvalidDiscussion,
				[Cpp2IlInjected.Token(Token = "0x4000749")]
				[OriginalName("AlreadyDiscussedToday")]
				AlreadyDiscussedToday
			}

			[Cpp2IlInjected.Token(Token = "0x2000231")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400074A")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400074B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400074C")]
				public const int CharacterIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400074D")]
				private int characterID_;

				[Cpp2IlInjected.Token(Token = "0x400074E")]
				public const int DiscussionIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400074F")]
				private int discussionID_;

				[Cpp2IlInjected.Token(Token = "0x4000750")]
				public const int FriendshipChoicesFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000751")]
				private static readonly FieldCodec<FriendshipChoice> _repeated_friendshipChoices_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000752")]
				private readonly RepeatedField<FriendshipChoice> friendshipChoices_;

				[Cpp2IlInjected.Token(Token = "0x17000414")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60016BD")]
					[Cpp2IlInjected.Address(RVA = "0x1E138F0", Offset = "0x1E122F0", VA = "0x181E138F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000415")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60016BE")]
					[Cpp2IlInjected.Address(RVA = "0x1E13530", Offset = "0x1E11F30", VA = "0x181E13530")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000416")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60016BF")]
					[Cpp2IlInjected.Address(RVA = "0x1E140D0", Offset = "0x1E12AD0", VA = "0x181E140D0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000417")]
				[DebuggerNonUserCode]
				public int CharacterID
				{
					[Cpp2IlInjected.Token(Token = "0x60016C3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60016C4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000418")]
				[DebuggerNonUserCode]
				public int DiscussionID
				{
					[Cpp2IlInjected.Token(Token = "0x60016C5")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60016C6")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000419")]
				[DebuggerNonUserCode]
				public RepeatedField<FriendshipChoice> FriendshipChoices
				{
					[Cpp2IlInjected.Token(Token = "0x60016C7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60016C0")]
				[Cpp2IlInjected.Address(RVA = "0x1E12AB0", Offset = "0x1E114B0", VA = "0x181E12AB0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016C1")]
				[Cpp2IlInjected.Address(RVA = "0x1E12D10", Offset = "0x1E11710", VA = "0x181E12D10")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016C2")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D370", Offset = "0x1E0BD70", VA = "0x181E0D370", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60016C8")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D720", Offset = "0x1E0C120", VA = "0x181E0D720", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60016C9")]
				[Cpp2IlInjected.Address(RVA = "0x1E0D810", Offset = "0x1E0C210", VA = "0x181E0D810", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60016CA")]
				[Cpp2IlInjected.Address(RVA = "0x17C3010", Offset = "0x17C1A10", VA = "0x1817C3010", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60016CB")]
				[Cpp2IlInjected.Address(RVA = "0x1E10750", Offset = "0x1E0F150", VA = "0x181E10750", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60016CC")]
				[Cpp2IlInjected.Address(RVA = "0x1E118F0", Offset = "0x1E102F0", VA = "0x181E118F0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016CD")]
				[Cpp2IlInjected.Address(RVA = "0x1E0C2A0", Offset = "0x1E0ACA0", VA = "0x181E0C2A0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60016CE")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F550", Offset = "0x1E0DF50", VA = "0x181E0F550", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016CF")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F0C0", Offset = "0x1E0DAC0", VA = "0x181E0F0C0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016D0")]
				[Cpp2IlInjected.Address(RVA = "0x1E0E100", Offset = "0x1E0CB00", VA = "0x181E0E100", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60016D1")]
				[Cpp2IlInjected.Address(RVA = "0x1E0F790", Offset = "0x1E0E190", VA = "0x181E0F790", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016D2")]
				[Cpp2IlInjected.Address(RVA = "0x1E0CC10", Offset = "0x1E0B610", VA = "0x181E0CC10", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016D3")]
				[Cpp2IlInjected.Address(RVA = "0x1E10BD0", Offset = "0x1E0F5D0", VA = "0x181E10BD0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000233")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000754")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000755")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000756")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000757")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000758")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000759")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x400075A")]
				public const int LastDiscussionDateFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400075B")]
				private Timestamp lastDiscussionDate_;

				[Cpp2IlInjected.Token(Token = "0x1700041A")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60016D8")]
					[Cpp2IlInjected.Address(RVA = "0x1E204A0", Offset = "0x1E1EEA0", VA = "0x181E204A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700041B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60016D9")]
					[Cpp2IlInjected.Address(RVA = "0x1E20120", Offset = "0x1E1EB20", VA = "0x181E20120")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700041C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60016DA")]
					[Cpp2IlInjected.Address(RVA = "0x1E21280", Offset = "0x1E1FC80", VA = "0x181E21280", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700041D")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60016DE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60016DF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700041E")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60016E0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60016E1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700041F")]
				[DebuggerNonUserCode]
				public Timestamp LastDiscussionDate
				{
					[Cpp2IlInjected.Token(Token = "0x60016E2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60016E3")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000420")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60016EF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60016F0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60016DB")]
				[Cpp2IlInjected.Address(RVA = "0x1E1F530", Offset = "0x1E1DF30", VA = "0x181E1F530")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016DC")]
				[Cpp2IlInjected.Address(RVA = "0x1E1EEF0", Offset = "0x1E1D8F0", VA = "0x181E1EEF0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016DD")]
				[Cpp2IlInjected.Address(RVA = "0x1E19AC0", Offset = "0x1E184C0", VA = "0x181E19AC0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60016E4")]
				[Cpp2IlInjected.Address(RVA = "0x1E19D20", Offset = "0x1E18720", VA = "0x181E19D20", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60016E5")]
				[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60016E6")]
				[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60016E7")]
				[Cpp2IlInjected.Address(RVA = "0x1E1DA20", Offset = "0x1E1C420", VA = "0x181E1DA20", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60016E8")]
				[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016E9")]
				[Cpp2IlInjected.Address(RVA = "0x1E18880", Offset = "0x1E17280", VA = "0x181E18880", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60016EA")]
				[Cpp2IlInjected.Address(RVA = "0x1E1B230", Offset = "0x1E19C30", VA = "0x181E1B230", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016EB")]
				[Cpp2IlInjected.Address(RVA = "0x1E1CBD0", Offset = "0x1E1B5D0", VA = "0x181E1CBD0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016EC")]
				[Cpp2IlInjected.Address(RVA = "0x1E1A5A0", Offset = "0x1E18FA0", VA = "0x181E1A5A0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60016ED")]
				[Cpp2IlInjected.Address(RVA = "0x1E1D200", Offset = "0x1E1BC00", VA = "0x181E1D200", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016EE")]
				[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60016F1")]
				[Cpp2IlInjected.Address(RVA = "0x1E16910", Offset = "0x1E15310", VA = "0x181E16910", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private static readonly MessageParser<DiscussWithCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000411")]
		[DebuggerNonUserCode]
		public static MessageParser<DiscussWithCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60016AB")]
			[Cpp2IlInjected.Address(RVA = "0x1738F70", Offset = "0x1737970", VA = "0x181738F70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000412")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016AC")]
			[Cpp2IlInjected.Address(RVA = "0x1738EA0", Offset = "0x17378A0", VA = "0x181738EA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60016AD")]
			[Cpp2IlInjected.Address(RVA = "0x1738FD0", Offset = "0x17379D0", VA = "0x181738FD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016AE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DiscussWithCharacter()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60016AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DiscussWithCharacter(DiscussWithCharacter other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016B0")]
		[Cpp2IlInjected.Address(RVA = "0x1738BC0", Offset = "0x17375C0", VA = "0x181738BC0", Slot = "10")]
		[DebuggerNonUserCode]
		public DiscussWithCharacter Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DiscussWithCharacter discussWithCharacter = default(DiscussWithCharacter);
			discussWithCharacter.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (discussWithCharacter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return discussWithCharacter;
		}

		[Cpp2IlInjected.Token(Token = "0x60016B1")]
		[Cpp2IlInjected.Address(RVA = "0x1738C40", Offset = "0x1737640", VA = "0x181738C40", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60016B2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DiscussWithCharacter other)
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

		[Cpp2IlInjected.Token(Token = "0x60016B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60016B4")]
		[Cpp2IlInjected.Address(RVA = "0x1738D30", Offset = "0x1737730", VA = "0x181738D30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60016B5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60016B6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60016B7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DiscussWithCharacter other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B8")]
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

		[Cpp2IlInjected.Token(Token = "0x60016B9")]
		[Cpp2IlInjected.Address(RVA = "0x1738CC0", Offset = "0x17376C0", VA = "0x181738CC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016BC")]
		[Cpp2IlInjected.Address(RVA = "0x1738D90", Offset = "0x1737790", VA = "0x181738D90")]
		static DiscussWithCharacter()
		{
			Func<DiscussWithCharacter> func = default(Func<DiscussWithCharacter>);
			_parser = (MessageParser<DiscussWithCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
