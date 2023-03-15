using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000C64")]
	public sealed class SetPlayfabAvatar : IMessage<SetPlayfabAvatar>, IMessage, IEquatable<SetPlayfabAvatar>, IDeepCloneable<SetPlayfabAvatar>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C65")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C66")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002FFE")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4002FFF")]
				[OriginalName("PlayFabError")]
				PlayFabError,
				[Cpp2IlInjected.Token(Token = "0x4003000")]
				[OriginalName("OverLimit")]
				OverLimit,
				[Cpp2IlInjected.Token(Token = "0x4003001")]
				[OriginalName("UnknownError")]
				UnknownError,
				[Cpp2IlInjected.Token(Token = "0x4003002")]
				[OriginalName("UnknownImageUploadError")]
				UnknownImageUploadError,
				[Cpp2IlInjected.Token(Token = "0x4003003")]
				[OriginalName("ConnectionError")]
				ConnectionError
			}

			[Cpp2IlInjected.Token(Token = "0x2000C67")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4003004")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003005")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003006")]
				public const int DisplayNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003007")]
				private string displayName_;

				[Cpp2IlInjected.Token(Token = "0x4003008")]
				public const int ScreenshotFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003009")]
				private ByteString screenshot_;

				[Cpp2IlInjected.Token(Token = "0x17001266")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60069C1")]
					[Cpp2IlInjected.Address(RVA = "0x2B51120", Offset = "0x2B4FB20", VA = "0x182B51120")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001267")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60069C2")]
					[Cpp2IlInjected.Address(RVA = "0x2B51040", Offset = "0x2B4FA40", VA = "0x182B51040")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001268")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60069C3")]
					[Cpp2IlInjected.Address(RVA = "0x2B51910", Offset = "0x2B50310", VA = "0x182B51910", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001269")]
				[DebuggerNonUserCode]
				public string DisplayName
				{
					[Cpp2IlInjected.Token(Token = "0x60069C7")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60069C8")]
					[Cpp2IlInjected.Address(RVA = "0x2B51FD0", Offset = "0x2B509D0", VA = "0x182B51FD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700126A")]
				[DebuggerNonUserCode]
				public ByteString Screenshot
				{
					[Cpp2IlInjected.Token(Token = "0x60069C9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60069CA")]
					[Cpp2IlInjected.Address(RVA = "0x2B520C0", Offset = "0x2B50AC0", VA = "0x182B520C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60069C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B50910", Offset = "0x2B4F310", VA = "0x182B50910")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069C5")]
				[Cpp2IlInjected.Address(RVA = "0x2B50680", Offset = "0x2B4F080", VA = "0x182B50680")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A0C0", Offset = "0x2B48AC0", VA = "0x182B4A0C0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60069CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AB80", Offset = "0x2B49580", VA = "0x182B4AB80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60069CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A960", Offset = "0x2B49360", VA = "0x182B4A960", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60069CD")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C0C0", Offset = "0x2B4AAC0", VA = "0x182B4C0C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60069CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E1B0", Offset = "0x2B4CBB0", VA = "0x182B4E1B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60069CF")]
				[Cpp2IlInjected.Address(RVA = "0x2B4F310", Offset = "0x2B4DD10", VA = "0x182B4F310", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B494A0", Offset = "0x2B47EA0", VA = "0x182B494A0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60069D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CE30", Offset = "0x2B4B830", VA = "0x182B4CE30", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069D2")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C490", Offset = "0x2B4AE90", VA = "0x182B4C490", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069D3")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C030", Offset = "0x2B4AA30", VA = "0x182B4C030", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60069D4")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DB00", Offset = "0x2B4C500", VA = "0x182B4DB00", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069D5")]
				[Cpp2IlInjected.Address(RVA = "0x2B49BF0", Offset = "0x2B485F0", VA = "0x182B49BF0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C69")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x400300B")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400300C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400300D")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400300E")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400300F")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003010")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4003011")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003012")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4003013")]
				public const int EntryIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003014")]
				private string entryId_;

				[Cpp2IlInjected.Token(Token = "0x1700126B")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60069DA")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CD40", Offset = "0x2B5B740", VA = "0x182B5CD40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700126C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60069DB")]
					[Cpp2IlInjected.Address(RVA = "0x2B5C9E0", Offset = "0x2B5B3E0", VA = "0x182B5C9E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700126D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60069DC")]
					[Cpp2IlInjected.Address(RVA = "0x2B5D5E0", Offset = "0x2B5BFE0", VA = "0x182B5D5E0", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700126E")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60069E0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60069E1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700126F")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60069E2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60069E3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001270")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60069E4")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60069E5")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001271")]
				[DebuggerNonUserCode]
				public string EntryId
				{
					[Cpp2IlInjected.Token(Token = "0x60069E6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60069E7")]
					[Cpp2IlInjected.Address(RVA = "0x2B5D9A0", Offset = "0x2B5C3A0", VA = "0x182B5D9A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001272")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60069F3")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60069F4")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60069DD")]
				[Cpp2IlInjected.Address(RVA = "0x2B5B780", Offset = "0x2B5A180", VA = "0x182B5B780")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069DE")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BF60", Offset = "0x2B5A960", VA = "0x182B5BF60")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069DF")]
				[Cpp2IlInjected.Address(RVA = "0x2B55790", Offset = "0x2B54190", VA = "0x182B55790", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60069E8")]
				[Cpp2IlInjected.Address(RVA = "0x2B56330", Offset = "0x2B54D30", VA = "0x182B56330", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60069E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B55E50", Offset = "0x2B54850", VA = "0x182B55E50", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60069EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B572E0", Offset = "0x2B55CE0", VA = "0x182B572E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60069EB")]
				[Cpp2IlInjected.Address(RVA = "0x2B5A150", Offset = "0x2B58B50", VA = "0x182B5A150", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60069EC")]
				[Cpp2IlInjected.Address(RVA = "0x2B5A330", Offset = "0x2B58D30", VA = "0x182B5A330", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069ED")]
				[Cpp2IlInjected.Address(RVA = "0x2B54560", Offset = "0x2B52F60", VA = "0x182B54560", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60069EE")]
				[Cpp2IlInjected.Address(RVA = "0x2B57ED0", Offset = "0x2B568D0", VA = "0x182B57ED0", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069EF")]
				[Cpp2IlInjected.Address(RVA = "0x2B573A0", Offset = "0x2B55DA0", VA = "0x182B573A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069F0")]
				[Cpp2IlInjected.Address(RVA = "0x2B56A80", Offset = "0x2B55480", VA = "0x182B56A80", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60069F1")]
				[Cpp2IlInjected.Address(RVA = "0x2B594F0", Offset = "0x2B57EF0", VA = "0x182B594F0", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069F2")]
				[Cpp2IlInjected.Address(RVA = "0x2B549A0", Offset = "0x2B533A0", VA = "0x182B549A0", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60069F5")]
				[Cpp2IlInjected.Address(RVA = "0x2B56560", Offset = "0x2B54F60", VA = "0x182B56560", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__46))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60069F6")]
				[Cpp2IlInjected.Address(RVA = "0x2B590C0", Offset = "0x2B57AC0", VA = "0x182B590C0")]
				[AsyncStateMachine(typeof(_003CPrepareUploadAvatarAsync_003Ed__47))]
				private Task<PrepareUploadUrl.Result> PrepareUploadAvatarAsync(ClientSession clientSession, PrepareUploadUrl.Request request)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002FFB")]
		private static readonly MessageParser<SetPlayfabAvatar> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002FFC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001263")]
		[DebuggerNonUserCode]
		public static MessageParser<SetPlayfabAvatar> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60069AF")]
			[Cpp2IlInjected.Address(RVA = "0x1777960", Offset = "0x1776360", VA = "0x181777960")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001264")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60069B0")]
			[Cpp2IlInjected.Address(RVA = "0x1777890", Offset = "0x1776290", VA = "0x181777890")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001265")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60069B1")]
			[Cpp2IlInjected.Address(RVA = "0x17779C0", Offset = "0x17763C0", VA = "0x1817779C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60069B2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SetPlayfabAvatar()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60069B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SetPlayfabAvatar(SetPlayfabAvatar other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60069B4")]
		[Cpp2IlInjected.Address(RVA = "0x17775B0", Offset = "0x1775FB0", VA = "0x1817775B0", Slot = "10")]
		[DebuggerNonUserCode]
		public SetPlayfabAvatar Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SetPlayfabAvatar setPlayfabAvatar = default(SetPlayfabAvatar);
			setPlayfabAvatar.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (setPlayfabAvatar._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return setPlayfabAvatar;
		}

		[Cpp2IlInjected.Token(Token = "0x60069B5")]
		[Cpp2IlInjected.Address(RVA = "0x1777630", Offset = "0x1776030", VA = "0x181777630", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60069B6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SetPlayfabAvatar other)
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

		[Cpp2IlInjected.Token(Token = "0x60069B7")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60069B8")]
		[Cpp2IlInjected.Address(RVA = "0x1777720", Offset = "0x1776120", VA = "0x181777720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60069B9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60069BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60069BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SetPlayfabAvatar other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60069BC")]
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

		[Cpp2IlInjected.Token(Token = "0x60069BD")]
		[Cpp2IlInjected.Address(RVA = "0x17776B0", Offset = "0x17760B0", VA = "0x1817776B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60069BE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60069BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60069C0")]
		[Cpp2IlInjected.Address(RVA = "0x1777780", Offset = "0x1776180", VA = "0x181777780")]
		static SetPlayfabAvatar()
		{
			Func<SetPlayfabAvatar> func = default(Func<SetPlayfabAvatar>);
			_parser = (MessageParser<SetPlayfabAvatar>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
