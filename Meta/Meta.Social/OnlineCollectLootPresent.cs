using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000D01")]
	public sealed class OnlineCollectLootPresent : IMessage<OnlineCollectLootPresent>, IMessage, IEquatable<OnlineCollectLootPresent>, IDeepCloneable<OnlineCollectLootPresent>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000D02")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000D03")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40032D7")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x40032D8")]
				[OriginalName("InvalidGrid")]
				InvalidGrid = 1,
				[Cpp2IlInjected.Token(Token = "0x40032D9")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId = 2,
				[Cpp2IlInjected.Token(Token = "0x40032DA")]
				[OriginalName("InvalidItem")]
				InvalidItem = 3,
				[Cpp2IlInjected.Token(Token = "0x40032DB")]
				[OriginalName("PlayFabError")]
				PlayFabError = 4,
				[Cpp2IlInjected.Token(Token = "0x40032DC")]
				[OriginalName("OnlineGrantRewardsFailure")]
				OnlineGrantRewardsFailure = 5,
				[Cpp2IlInjected.Token(Token = "0x40032DD")]
				[OriginalName("OnlineRewardsNotFound")]
				OnlineRewardsNotFound = 6,
				[Cpp2IlInjected.Token(Token = "0x40032DE")]
				[OriginalName("UnknownOnlineError")]
				UnknownOnlineError = 10,
				[Cpp2IlInjected.Token(Token = "0x40032DF")]
				[OriginalName("UnknownError")]
				UnknownError = 20
			}

			[Cpp2IlInjected.Token(Token = "0x2000D04")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x40032E0")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40032E1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40032E2")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40032E3")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x40032E4")]
				public const int GridObjectIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40032E5")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x170013A2")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006F85")]
					[Cpp2IlInjected.Address(RVA = "0x25CC150", Offset = "0x25CAB50", VA = "0x1825CC150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013A3")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006F86")]
					[Cpp2IlInjected.Address(RVA = "0x25CC050", Offset = "0x25CAA50", VA = "0x1825CC050")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013A4")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006F87")]
					[Cpp2IlInjected.Address(RVA = "0x25CCC30", Offset = "0x25CB630", VA = "0x1825CCC30", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013A5")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6006F8B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6006F8C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013A6")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6006F8D")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6006F8E")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006F88")]
				[Cpp2IlInjected.Address(RVA = "0x25CB230", Offset = "0x25C9C30", VA = "0x1825CB230")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F89")]
				[Cpp2IlInjected.Address(RVA = "0x25CB470", Offset = "0x25C9E70", VA = "0x1825CB470")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F8A")]
				[Cpp2IlInjected.Address(RVA = "0x25C56C0", Offset = "0x25C40C0", VA = "0x1825C56C0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006F8F")]
				[Cpp2IlInjected.Address(RVA = "0x25C62F0", Offset = "0x25C4CF0", VA = "0x1825C62F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F90")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F91")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F92")]
				[Cpp2IlInjected.Address(RVA = "0x25C8780", Offset = "0x25C7180", VA = "0x1825C8780", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006F93")]
				[Cpp2IlInjected.Address(RVA = "0x108E870", Offset = "0x108D270", VA = "0x18108E870", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F94")]
				[Cpp2IlInjected.Address(RVA = "0x25C4610", Offset = "0x25C3010", VA = "0x1825C4610", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F95")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F96")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F97")]
				[Cpp2IlInjected.Address(RVA = "0x25C68E0", Offset = "0x25C52E0", VA = "0x1825C68E0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006F98")]
				[Cpp2IlInjected.Address(RVA = "0x25C7EB0", Offset = "0x25C68B0", VA = "0x1825C7EB0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F99")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F9A")]
				[Cpp2IlInjected.Address(RVA = "0x25C9390", Offset = "0x25C7D90", VA = "0x1825C9390", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000D06")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x40032E7")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40032E8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40032E9")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40032EA")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40032EB")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40032EC")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40032ED")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40032EE")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x40032EF")]
				public const int RewardsFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40032F0")]
				private MultiItemInstance rewards_;

				[Cpp2IlInjected.Token(Token = "0x170013A7")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006F9F")]
					[Cpp2IlInjected.Address(RVA = "0x25D66A0", Offset = "0x25D50A0", VA = "0x1825D66A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013A8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006FA0")]
					[Cpp2IlInjected.Address(RVA = "0x25D6220", Offset = "0x25D4C20", VA = "0x1825D6220")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013A9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006FA1")]
					[Cpp2IlInjected.Address(RVA = "0x25D71E0", Offset = "0x25D5BE0", VA = "0x1825D71E0", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013AA")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006FA5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006FA6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013AB")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006FA7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006FA8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013AC")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006FA9")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006FAA")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013AD")]
				[DebuggerNonUserCode]
				public MultiItemInstance Rewards
				{
					[Cpp2IlInjected.Token(Token = "0x6006FAB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006FAC")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013AE")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006FB8")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013AF")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006FB9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006FBA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013B0")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006FBB")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006FBC")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006FA2")]
				[Cpp2IlInjected.Address(RVA = "0x25D6020", Offset = "0x25D4A20", VA = "0x1825D6020")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006FA3")]
				[Cpp2IlInjected.Address(RVA = "0x25D5E80", Offset = "0x25D4880", VA = "0x1825D5E80")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006FA4")]
				[Cpp2IlInjected.Address(RVA = "0x25CFE20", Offset = "0x25CE820", VA = "0x1825CFE20", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006FAD")]
				[Cpp2IlInjected.Address(RVA = "0x25D08C0", Offset = "0x25CF2C0", VA = "0x1825D08C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006FAE")]
				[Cpp2IlInjected.Address(RVA = "0x2122330", Offset = "0x2120D30", VA = "0x182122330", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006FAF")]
				[Cpp2IlInjected.Address(RVA = "0x2123680", Offset = "0x2122080", VA = "0x182123680", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB0")]
				[Cpp2IlInjected.Address(RVA = "0x25D4110", Offset = "0x25D2B10", VA = "0x1825D4110", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB1")]
				[Cpp2IlInjected.Address(RVA = "0x2126A00", Offset = "0x2125400", VA = "0x182126A00", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB2")]
				[Cpp2IlInjected.Address(RVA = "0x25CEDE0", Offset = "0x25CD7E0", VA = "0x1825CEDE0", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB3")]
				[Cpp2IlInjected.Address(RVA = "0x25D1FD0", Offset = "0x25D09D0", VA = "0x1825D1FD0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB4")]
				[Cpp2IlInjected.Address(RVA = "0x25D2790", Offset = "0x25D1190", VA = "0x1825D2790", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB5")]
				[Cpp2IlInjected.Address(RVA = "0x25D1800", Offset = "0x25D0200", VA = "0x1825D1800", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB6")]
				[Cpp2IlInjected.Address(RVA = "0x25D36A0", Offset = "0x25D20A0", VA = "0x1825D36A0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006FB7")]
				[Cpp2IlInjected.Address(RVA = "0x2120A30", Offset = "0x211F430", VA = "0x182120A30", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006FBD")]
				[Cpp2IlInjected.Address(RVA = "0x25D0EF0", Offset = "0x25CF8F0", VA = "0x1825D0EF0", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__51))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006FBE")]
				[Cpp2IlInjected.Address(RVA = "0x25CDE20", Offset = "0x25CC820", VA = "0x1825CDE20", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40032D4")]
		private static readonly MessageParser<OnlineCollectLootPresent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40032D5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700139F")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineCollectLootPresent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006F73")]
			[Cpp2IlInjected.Address(RVA = "0x13A8D20", Offset = "0x13A7720", VA = "0x1813A8D20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013A0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006F74")]
			[Cpp2IlInjected.Address(RVA = "0x13A8C50", Offset = "0x13A7650", VA = "0x1813A8C50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013A1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006F75")]
			[Cpp2IlInjected.Address(RVA = "0x13A8D80", Offset = "0x13A7780", VA = "0x1813A8D80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006F76")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public OnlineCollectLootPresent()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006F77")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public OnlineCollectLootPresent(OnlineCollectLootPresent other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006F78")]
		[Cpp2IlInjected.Address(RVA = "0x13A8970", Offset = "0x13A7370", VA = "0x1813A8970", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineCollectLootPresent Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			OnlineCollectLootPresent onlineCollectLootPresent = default(OnlineCollectLootPresent);
			onlineCollectLootPresent.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (onlineCollectLootPresent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return onlineCollectLootPresent;
		}

		[Cpp2IlInjected.Token(Token = "0x6006F79")]
		[Cpp2IlInjected.Address(RVA = "0x13A89F0", Offset = "0x13A73F0", VA = "0x1813A89F0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006F7A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineCollectLootPresent other)
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

		[Cpp2IlInjected.Token(Token = "0x6006F7B")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006F7C")]
		[Cpp2IlInjected.Address(RVA = "0x13A8AE0", Offset = "0x13A74E0", VA = "0x1813A8AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006F7D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006F7E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006F7F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineCollectLootPresent other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006F80")]
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

		[Cpp2IlInjected.Token(Token = "0x6006F81")]
		[Cpp2IlInjected.Address(RVA = "0x13A8A70", Offset = "0x13A7470", VA = "0x1813A8A70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006F82")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006F83")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006F84")]
		[Cpp2IlInjected.Address(RVA = "0x13A8B40", Offset = "0x13A7540", VA = "0x1813A8B40")]
		static OnlineCollectLootPresent()
		{
			Func<OnlineCollectLootPresent> func = default(Func<OnlineCollectLootPresent>);
			_parser = (MessageParser<OnlineCollectLootPresent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
