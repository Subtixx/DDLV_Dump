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
	[Cpp2IlInjected.Token(Token = "0x2000B6D")]
	public sealed class AutoRedeemFoundersPack : IMessage<AutoRedeemFoundersPack>, IMessage, IEquatable<AutoRedeemFoundersPack>, IDeepCloneable<AutoRedeemFoundersPack>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000B6E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000B6F")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002C4C")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4002C4D")]
				[OriginalName("CouldNotFetchPacks")]
				CouldNotFetchPacks,
				[Cpp2IlInjected.Token(Token = "0x4002C4E")]
				[OriginalName("NotAllPacksFounds")]
				NotAllPacksFounds,
				[Cpp2IlInjected.Token(Token = "0x4002C4F")]
				[OriginalName("AutoAwardedPackNotFound")]
				AutoAwardedPackNotFound,
				[Cpp2IlInjected.Token(Token = "0x4002C50")]
				[OriginalName("FailedGrantingPack")]
				FailedGrantingPack,
				[Cpp2IlInjected.Token(Token = "0x4002C51")]
				[OriginalName("FailedUpdatingGlobalKey")]
				FailedUpdatingGlobalKey,
				[Cpp2IlInjected.Token(Token = "0x4002C52")]
				[OriginalName("CouldNotFetchUserKey")]
				CouldNotFetchUserKey,
				[Cpp2IlInjected.Token(Token = "0x4002C53")]
				[OriginalName("CouldNotFetchInventory")]
				CouldNotFetchInventory,
				[Cpp2IlInjected.Token(Token = "0x4002C54")]
				[OriginalName("CouldNotParseUserKey")]
				CouldNotParseUserKey,
				[Cpp2IlInjected.Token(Token = "0x4002C55")]
				[OriginalName("CouldNotUpgradeUserKey")]
				CouldNotUpgradeUserKey,
				[Cpp2IlInjected.Token(Token = "0x4002C56")]
				[OriginalName("Error")]
				Error,
				[Cpp2IlInjected.Token(Token = "0x4002C57")]
				[OriginalName("PlayFabError")]
				PlayFabError,
				[Cpp2IlInjected.Token(Token = "0x4002C58")]
				[OriginalName("UnknownError")]
				UnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x2000B70")]
			public enum RedeemType
			{
				[Cpp2IlInjected.Token(Token = "0x4002C5A")]
				[OriginalName("Undefined")]
				Undefined,
				[Cpp2IlInjected.Token(Token = "0x4002C5B")]
				[OriginalName("GlobalKeyCachedValue")]
				GlobalKeyCachedValue,
				[Cpp2IlInjected.Token(Token = "0x4002C5C")]
				[OriginalName("AutoAwarded")]
				AutoAwarded,
				[Cpp2IlInjected.Token(Token = "0x4002C5D")]
				[OriginalName("AlreadyInInventory")]
				AlreadyInInventory
			}

			[Cpp2IlInjected.Token(Token = "0x2000B71")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002C5E")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002C5F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x170010A7")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60060F9")]
					[Cpp2IlInjected.Address(RVA = "0x2033970", Offset = "0x2032370", VA = "0x182033970")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010A8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60060FA")]
					[Cpp2IlInjected.Address(RVA = "0x20337F0", Offset = "0x20321F0", VA = "0x1820337F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010A9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60060FB")]
					[Cpp2IlInjected.Address(RVA = "0x2033B50", Offset = "0x2032550", VA = "0x182033B50", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60060FC")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060FD")]
				[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60060FE")]
				[Cpp2IlInjected.Address(RVA = "0x2032850", Offset = "0x2031250", VA = "0x182032850", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60060FF")]
				[Cpp2IlInjected.Address(RVA = "0x2032960", Offset = "0x2031360", VA = "0x182032960", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006100")]
				[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006101")]
				[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006102")]
				[Cpp2IlInjected.Address(RVA = "0x2032DE0", Offset = "0x20317E0", VA = "0x182032DE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006103")]
				[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006104")]
				[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006105")]
				[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006106")]
				[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006107")]
				[Cpp2IlInjected.Address(RVA = "0x2032A70", Offset = "0x2031470", VA = "0x182032A70", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006108")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006109")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000B73")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002C61")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002C62")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002C63")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002C64")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002C65")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002C66")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002C67")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002C68")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002C69")]
				public const int ActivePackFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002C6A")]
				private string activePack_;

				[Cpp2IlInjected.Token(Token = "0x4002C6B")]
				public const int RedeemTypeFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4002C6C")]
				private RedeemType redeemType_;

				[Cpp2IlInjected.Token(Token = "0x170010AA")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600610E")]
					[Cpp2IlInjected.Address(RVA = "0x2036880", Offset = "0x2035280", VA = "0x182036880")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010AB")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600610F")]
					[Cpp2IlInjected.Address(RVA = "0x2036780", Offset = "0x2035180", VA = "0x182036780")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010AC")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006110")]
					[Cpp2IlInjected.Address(RVA = "0x2036B20", Offset = "0x2035520", VA = "0x182036B20", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010AD")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006114")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006115")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010AE")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006116")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006117")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010AF")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006118")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006119")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010B0")]
				[DebuggerNonUserCode]
				public string ActivePack
				{
					[Cpp2IlInjected.Token(Token = "0x600611A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600611B")]
					[Cpp2IlInjected.Address(RVA = "0x2036BE0", Offset = "0x20355E0", VA = "0x182036BE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010B1")]
				[DebuggerNonUserCode]
				public RedeemType RedeemType
				{
					[Cpp2IlInjected.Token(Token = "0x600611C")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(RedeemType);
					}
					[Cpp2IlInjected.Token(Token = "0x600611D")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010B2")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006129")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600612A")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006111")]
				[Cpp2IlInjected.Address(RVA = "0x20362C0", Offset = "0x2034CC0", VA = "0x1820362C0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006112")]
				[Cpp2IlInjected.Address(RVA = "0x2036430", Offset = "0x2034E30", VA = "0x182036430")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006113")]
				[Cpp2IlInjected.Address(RVA = "0x20347C0", Offset = "0x20331C0", VA = "0x1820347C0", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600611E")]
				[Cpp2IlInjected.Address(RVA = "0x2034CB0", Offset = "0x20336B0", VA = "0x182034CB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600611F")]
				[Cpp2IlInjected.Address(RVA = "0x2034B70", Offset = "0x2033570", VA = "0x182034B70", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006120")]
				[Cpp2IlInjected.Address(RVA = "0x2035250", Offset = "0x2033C50", VA = "0x182035250", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006121")]
				[Cpp2IlInjected.Address(RVA = "0x2035DC0", Offset = "0x20347C0", VA = "0x182035DC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006122")]
				[Cpp2IlInjected.Address(RVA = "0x2035E80", Offset = "0x2034880", VA = "0x182035E80", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006123")]
				[Cpp2IlInjected.Address(RVA = "0x2034370", Offset = "0x2032D70", VA = "0x182034370", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006124")]
				[Cpp2IlInjected.Address(RVA = "0x2035640", Offset = "0x2034040", VA = "0x182035640", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006125")]
				[Cpp2IlInjected.Address(RVA = "0x2035770", Offset = "0x2034170", VA = "0x182035770", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006126")]
				[Cpp2IlInjected.Address(RVA = "0x2034F90", Offset = "0x2033990", VA = "0x182034F90", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006127")]
				[Cpp2IlInjected.Address(RVA = "0x2035AB0", Offset = "0x20344B0", VA = "0x182035AB0", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006128")]
				[Cpp2IlInjected.Address(RVA = "0x20345B0", Offset = "0x2032FB0", VA = "0x1820345B0", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600612B")]
				[Cpp2IlInjected.Address(RVA = "0x2034A70", Offset = "0x2033470", VA = "0x182034A70")]
				[AsyncStateMachine(typeof(_003CDoDebugLocalEntitlementsAsync_003Ed__51))]
				private Task DoDebugLocalEntitlementsAsync(ClientSession session, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600612C")]
				[Cpp2IlInjected.Address(RVA = "0x2034E40", Offset = "0x2033840", VA = "0x182034E40", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__52))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002C49")]
		private static readonly MessageParser<AutoRedeemFoundersPack> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002C4A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170010A4")]
		[DebuggerNonUserCode]
		public static MessageParser<AutoRedeemFoundersPack> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60060E7")]
			[Cpp2IlInjected.Address(RVA = "0x18ED020", Offset = "0x18EBA20", VA = "0x1818ED020")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60060E8")]
			[Cpp2IlInjected.Address(RVA = "0x18ECF50", Offset = "0x18EB950", VA = "0x1818ECF50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010A6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60060E9")]
			[Cpp2IlInjected.Address(RVA = "0x18ED080", Offset = "0x18EBA80", VA = "0x1818ED080", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60060EA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AutoRedeemFoundersPack()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60060EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public AutoRedeemFoundersPack(AutoRedeemFoundersPack other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60060EC")]
		[Cpp2IlInjected.Address(RVA = "0x18ECC70", Offset = "0x18EB670", VA = "0x1818ECC70", Slot = "10")]
		[DebuggerNonUserCode]
		public AutoRedeemFoundersPack Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			AutoRedeemFoundersPack autoRedeemFoundersPack = default(AutoRedeemFoundersPack);
			autoRedeemFoundersPack.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (autoRedeemFoundersPack._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return autoRedeemFoundersPack;
		}

		[Cpp2IlInjected.Token(Token = "0x60060ED")]
		[Cpp2IlInjected.Address(RVA = "0x18ECCF0", Offset = "0x18EB6F0", VA = "0x1818ECCF0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60060EE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AutoRedeemFoundersPack other)
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

		[Cpp2IlInjected.Token(Token = "0x60060EF")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60060F0")]
		[Cpp2IlInjected.Address(RVA = "0x18ECDE0", Offset = "0x18EB7E0", VA = "0x1818ECDE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60060F1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60060F2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60060F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AutoRedeemFoundersPack other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60060F4")]
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

		[Cpp2IlInjected.Token(Token = "0x60060F5")]
		[Cpp2IlInjected.Address(RVA = "0x18ECD70", Offset = "0x18EB770", VA = "0x1818ECD70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60060F6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60060F7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60060F8")]
		[Cpp2IlInjected.Address(RVA = "0x18ECE40", Offset = "0x18EB840", VA = "0x1818ECE40")]
		static AutoRedeemFoundersPack()
		{
			Func<AutoRedeemFoundersPack> func = default(Func<AutoRedeemFoundersPack>);
			_parser = (MessageParser<AutoRedeemFoundersPack>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
