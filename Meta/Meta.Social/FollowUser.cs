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
	[Cpp2IlInjected.Token(Token = "0x2000BA3")]
	public sealed class FollowUser : IMessage<FollowUser>, IMessage, IEquatable<FollowUser>, IDeepCloneable<FollowUser>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BA4")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000BA5")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002CFC")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002CFD")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002CFE")]
				[OriginalName("TooManyFollowees")]
				TooManyFollowees = 2,
				[Cpp2IlInjected.Token(Token = "0x4002CFF")]
				[OriginalName("TooManyFollowers")]
				TooManyFollowers = 3,
				[Cpp2IlInjected.Token(Token = "0x4002D00")]
				[OriginalName("CannotFollowSelf")]
				CannotFollowSelf = 4,
				[Cpp2IlInjected.Token(Token = "0x4002D01")]
				[OriginalName("InvalidUser")]
				InvalidUser = 5,
				[Cpp2IlInjected.Token(Token = "0x4002D02")]
				[OriginalName("OverDailyLimit")]
				OverDailyLimit = 6,
				[Cpp2IlInjected.Token(Token = "0x4002D03")]
				[OriginalName("FollowerProfileUpdateFailed")]
				FollowerProfileUpdateFailed = 7,
				[Cpp2IlInjected.Token(Token = "0x4002D04")]
				[OriginalName("FollowerProfileNotFound")]
				FollowerProfileNotFound = 8,
				[Cpp2IlInjected.Token(Token = "0x4002D05")]
				[OriginalName("Error")]
				Error = 100
			}

			[Cpp2IlInjected.Token(Token = "0x2000BA6")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002D06")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002D07")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002D08")]
				public const int PlayfabIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002D09")]
				private string playfabId_;

				[Cpp2IlInjected.Token(Token = "0x4002D0A")]
				public const int TitleIdFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002D0B")]
				private string titleId_;

				[Cpp2IlInjected.Token(Token = "0x4002D0C")]
				public const int UnfollowFieldNumber = 10;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002D0D")]
				private bool unfollow_;

				[Cpp2IlInjected.Token(Token = "0x170010F8")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60062B5")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FE50", Offset = "0x1E7E850", VA = "0x181E7FE50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60062B6")]
					[Cpp2IlInjected.Address(RVA = "0x1E7F810", Offset = "0x1E7E210", VA = "0x181E7F810")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010FA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60062B7")]
					[Cpp2IlInjected.Address(RVA = "0x1E805D0", Offset = "0x1E7EFD0", VA = "0x181E805D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010FB")]
				[DebuggerNonUserCode]
				public string PlayfabId
				{
					[Cpp2IlInjected.Token(Token = "0x60062BB")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60062BC")]
					[Cpp2IlInjected.Address(RVA = "0x1E80B10", Offset = "0x1E7F510", VA = "0x181E80B10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010FC")]
				[DebuggerNonUserCode]
				public string TitleId
				{
					[Cpp2IlInjected.Token(Token = "0x60062BD")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60062BE")]
					[Cpp2IlInjected.Address(RVA = "0x1E80B80", Offset = "0x1E7F580", VA = "0x181E80B80")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010FD")]
				[DebuggerNonUserCode]
				public bool Unfollow
				{
					[Cpp2IlInjected.Token(Token = "0x60062BF")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60062C0")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60062B8")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F4E0", Offset = "0x1E7DEE0", VA = "0x181E7F4E0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062B9")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F140", Offset = "0x1E7DB40", VA = "0x181E7F140")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062BA")]
				[Cpp2IlInjected.Address(RVA = "0x1E79630", Offset = "0x1E78030", VA = "0x181E79630", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60062C1")]
				[Cpp2IlInjected.Address(RVA = "0x1E79FF0", Offset = "0x1E789F0", VA = "0x181E79FF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60062C2")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A4F0", Offset = "0x1E78EF0", VA = "0x181E7A4F0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60062C3")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B130", Offset = "0x1E79B30", VA = "0x181E7B130", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60062C4")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C990", Offset = "0x1E7B390", VA = "0x181E7C990", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60062C5")]
				[Cpp2IlInjected.Address(RVA = "0x1E7D8F0", Offset = "0x1E7C2F0", VA = "0x181E7D8F0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062C6")]
				[Cpp2IlInjected.Address(RVA = "0x1E78A70", Offset = "0x1E77470", VA = "0x181E78A70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60062C7")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B8F0", Offset = "0x1E7A2F0", VA = "0x181E7B8F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062C8")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B7D0", Offset = "0x1E7A1D0", VA = "0x181E7B7D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062C9")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A970", Offset = "0x1E79370", VA = "0x181E7A970", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60062CA")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C0D0", Offset = "0x1E7AAD0", VA = "0x181E7C0D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062CB")]
				[Cpp2IlInjected.Address(RVA = "0x1E791C0", Offset = "0x1E77BC0", VA = "0x181E791C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000BA8")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002D0F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002D10")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002D11")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002D12")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002D13")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002D14")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002D15")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002D16")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x170010FE")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60062D0")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F5E0", Offset = "0x1E8DFE0", VA = "0x181E8F5E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010FF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60062D1")]
					[Cpp2IlInjected.Address(RVA = "0x1E8EAE0", Offset = "0x1E8D4E0", VA = "0x181E8EAE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001100")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60062D2")]
					[Cpp2IlInjected.Address(RVA = "0x1E8FAC0", Offset = "0x1E8E4C0", VA = "0x181E8FAC0", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001101")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60062D6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60062D7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001102")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60062D8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60062D9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001103")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60062DA")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60062DB")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001104")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60062E7")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60062E8")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60062D3")]
				[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062D4")]
				[Cpp2IlInjected.Address(RVA = "0x1E8E7D0", Offset = "0x1E8D1D0", VA = "0x181E8E7D0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062D5")]
				[Cpp2IlInjected.Address(RVA = "0x1E855C0", Offset = "0x1E83FC0", VA = "0x181E855C0", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60062DC")]
				[Cpp2IlInjected.Address(RVA = "0x1E863D0", Offset = "0x1E84DD0", VA = "0x181E863D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60062DD")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60062DE")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60062DF")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B730", Offset = "0x1E8A130", VA = "0x181E8B730", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60062E0")]
				[Cpp2IlInjected.Address(RVA = "0x89B730", Offset = "0x89A130", VA = "0x18089B730", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062E1")]
				[Cpp2IlInjected.Address(RVA = "0x1E84210", Offset = "0x1E82C10", VA = "0x181E84210", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60062E2")]
				[Cpp2IlInjected.Address(RVA = "0x1E887E0", Offset = "0x1E871E0", VA = "0x181E887E0", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062E3")]
				[Cpp2IlInjected.Address(RVA = "0x1E88F90", Offset = "0x1E87990", VA = "0x181E88F90", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062E4")]
				[Cpp2IlInjected.Address(RVA = "0x1E87600", Offset = "0x1E86000", VA = "0x181E87600", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60062E5")]
				[Cpp2IlInjected.Address(RVA = "0x1E8AAF0", Offset = "0x1E894F0", VA = "0x181E8AAF0", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062E6")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60062E9")]
				[Cpp2IlInjected.Address(RVA = "0x1E86E10", Offset = "0x1E85810", VA = "0x181E86E10", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__41))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002CF9")]
		private static readonly MessageParser<FollowUser> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002CFA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170010F5")]
		[DebuggerNonUserCode]
		public static MessageParser<FollowUser> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60062A3")]
			[Cpp2IlInjected.Address(RVA = "0x18075C0", Offset = "0x1805FC0", VA = "0x1818075C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010F6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60062A4")]
			[Cpp2IlInjected.Address(RVA = "0x18074F0", Offset = "0x1805EF0", VA = "0x1818074F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010F7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60062A5")]
			[Cpp2IlInjected.Address(RVA = "0x1807620", Offset = "0x1806020", VA = "0x181807620", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60062A6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FollowUser()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60062A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public FollowUser(FollowUser other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60062A8")]
		[Cpp2IlInjected.Address(RVA = "0x1807210", Offset = "0x1805C10", VA = "0x181807210", Slot = "10")]
		[DebuggerNonUserCode]
		public FollowUser Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			FollowUser followUser = default(FollowUser);
			followUser.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (followUser._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return followUser;
		}

		[Cpp2IlInjected.Token(Token = "0x60062A9")]
		[Cpp2IlInjected.Address(RVA = "0x1807290", Offset = "0x1805C90", VA = "0x181807290", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60062AA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FollowUser other)
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

		[Cpp2IlInjected.Token(Token = "0x60062AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60062AC")]
		[Cpp2IlInjected.Address(RVA = "0x1807380", Offset = "0x1805D80", VA = "0x181807380", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60062AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60062AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60062AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FollowUser other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60062B0")]
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

		[Cpp2IlInjected.Token(Token = "0x60062B1")]
		[Cpp2IlInjected.Address(RVA = "0x1807310", Offset = "0x1805D10", VA = "0x181807310", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60062B2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60062B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60062B4")]
		[Cpp2IlInjected.Address(RVA = "0x18073E0", Offset = "0x1805DE0", VA = "0x1818073E0")]
		static FollowUser()
		{
			Func<FollowUser> func = default(Func<FollowUser>);
			_parser = (MessageParser<FollowUser>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
