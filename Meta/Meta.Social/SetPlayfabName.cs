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
	[Cpp2IlInjected.Token(Token = "0x2000B91")]
	public sealed class SetPlayfabName : IMessage<SetPlayfabName>, IMessage, IEquatable<SetPlayfabName>, IDeepCloneable<SetPlayfabName>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000B92")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000B93")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002CC6")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002CC7")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002CC8")]
				[OriginalName("OnCooldown")]
				OnCooldown = 2,
				[Cpp2IlInjected.Token(Token = "0x4002CC9")]
				[OriginalName("ProfanityDetected")]
				ProfanityDetected = 3,
				[Cpp2IlInjected.Token(Token = "0x4002CCA")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000B94")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002CCB")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002CCC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002CCD")]
				public const int UserNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002CCE")]
				private string userName_;

				[Cpp2IlInjected.Token(Token = "0x170010DC")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600621D")]
					[Cpp2IlInjected.Address(RVA = "0x2B511E0", Offset = "0x2B4FBE0", VA = "0x182B511E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010DD")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600621E")]
					[Cpp2IlInjected.Address(RVA = "0x2B50FC0", Offset = "0x2B4F9C0", VA = "0x182B50FC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010DE")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600621F")]
					[Cpp2IlInjected.Address(RVA = "0x2B51610", Offset = "0x2B50010", VA = "0x182B51610", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010DF")]
				[DebuggerNonUserCode]
				public string UserName
				{
					[Cpp2IlInjected.Token(Token = "0x6006223")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006224")]
					[Cpp2IlInjected.Address(RVA = "0x2B52130", Offset = "0x2B50B30", VA = "0x182B52130")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006220")]
				[Cpp2IlInjected.Address(RVA = "0x2B50760", Offset = "0x2B4F160", VA = "0x182B50760")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006221")]
				[Cpp2IlInjected.Address(RVA = "0x2B509A0", Offset = "0x2B4F3A0", VA = "0x182B509A0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006222")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A5F0", Offset = "0x2B48FF0", VA = "0x182B4A5F0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006225")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B510", Offset = "0x2B49F10", VA = "0x182B4B510", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006226")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006227")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006228")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E210", Offset = "0x2B4CC10", VA = "0x182B4E210", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006229")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600622A")]
				[Cpp2IlInjected.Address(RVA = "0x2B49090", Offset = "0x2B47A90", VA = "0x182B49090", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600622B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CB80", Offset = "0x2B4B580", VA = "0x182B4CB80", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600622C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4D060", Offset = "0x2B4BA60", VA = "0x182B4D060", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600622D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BC00", Offset = "0x2B4A600", VA = "0x182B4BC00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600622E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DC10", Offset = "0x2B4C610", VA = "0x182B4DC10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600622F")]
				[Cpp2IlInjected.Address(RVA = "0x2B49DD0", Offset = "0x2B487D0", VA = "0x182B49DD0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000B96")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002CD0")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002CD1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002CD2")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002CD3")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002CD4")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002CD5")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002CD6")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002CD7")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002CD8")]
				public const int UgcItemIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002CD9")]
				private string ugcItemId_;

				[Cpp2IlInjected.Token(Token = "0x170010E0")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006234")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CE00", Offset = "0x2B5B800", VA = "0x182B5CE00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006235")]
					[Cpp2IlInjected.Address(RVA = "0x2B5C460", Offset = "0x2B5AE60", VA = "0x182B5C460")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006236")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CFE0", Offset = "0x2B5B9E0", VA = "0x182B5CFE0", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E3")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600623A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600623B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E4")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600623C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600623D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E5")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x600623E")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600623F")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E6")]
				[DebuggerNonUserCode]
				public string UgcItemId
				{
					[Cpp2IlInjected.Token(Token = "0x6006240")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006241")]
					[Cpp2IlInjected.Address(RVA = "0x2B5DA10", Offset = "0x2B5C410", VA = "0x182B5DA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E7")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x600624D")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600624E")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006237")]
				[Cpp2IlInjected.Address(RVA = "0x2B5B9D0", Offset = "0x2B5A3D0", VA = "0x182B5B9D0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006238")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BB60", Offset = "0x2B5A560", VA = "0x182B5BB60")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006239")]
				[Cpp2IlInjected.Address(RVA = "0x2B54E80", Offset = "0x2B53880", VA = "0x182B54E80", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006242")]
				[Cpp2IlInjected.Address(RVA = "0x2B55D80", Offset = "0x2B54780", VA = "0x182B55D80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006243")]
				[Cpp2IlInjected.Address(RVA = "0x2B55E50", Offset = "0x2B54850", VA = "0x182B55E50", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006244")]
				[Cpp2IlInjected.Address(RVA = "0x2B572E0", Offset = "0x2B55CE0", VA = "0x182B572E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006245")]
				[Cpp2IlInjected.Address(RVA = "0x2B59F10", Offset = "0x2B58910", VA = "0x182B59F10", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006246")]
				[Cpp2IlInjected.Address(RVA = "0x2B5A330", Offset = "0x2B58D30", VA = "0x182B5A330", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006247")]
				[Cpp2IlInjected.Address(RVA = "0x2B54360", Offset = "0x2B52D60", VA = "0x182B54360", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006248")]
				[Cpp2IlInjected.Address(RVA = "0x2B58690", Offset = "0x2B57090", VA = "0x182B58690", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006249")]
				[Cpp2IlInjected.Address(RVA = "0x2B58F90", Offset = "0x2B57990", VA = "0x182B58F90", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600624A")]
				[Cpp2IlInjected.Address(RVA = "0x2B56D20", Offset = "0x2B55720", VA = "0x182B56D20", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600624B")]
				[Cpp2IlInjected.Address(RVA = "0x2B59360", Offset = "0x2B57D60", VA = "0x182B59360", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600624C")]
				[Cpp2IlInjected.Address(RVA = "0x2B54900", Offset = "0x2B53300", VA = "0x182B54900", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600624F")]
				[Cpp2IlInjected.Address(RVA = "0x2B566B0", Offset = "0x2B550B0", VA = "0x182B566B0", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__46))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002CC3")]
		private static readonly MessageParser<SetPlayfabName> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002CC4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170010D9")]
		[DebuggerNonUserCode]
		public static MessageParser<SetPlayfabName> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600620B")]
			[Cpp2IlInjected.Address(RVA = "0x1777E80", Offset = "0x1776880", VA = "0x181777E80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600620C")]
			[Cpp2IlInjected.Address(RVA = "0x1777DB0", Offset = "0x17767B0", VA = "0x181777DB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600620D")]
			[Cpp2IlInjected.Address(RVA = "0x1777EE0", Offset = "0x17768E0", VA = "0x181777EE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600620E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SetPlayfabName()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600620F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SetPlayfabName(SetPlayfabName other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006210")]
		[Cpp2IlInjected.Address(RVA = "0x1777AD0", Offset = "0x17764D0", VA = "0x181777AD0", Slot = "10")]
		[DebuggerNonUserCode]
		public SetPlayfabName Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SetPlayfabName setPlayfabName = default(SetPlayfabName);
			setPlayfabName.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (setPlayfabName._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return setPlayfabName;
		}

		[Cpp2IlInjected.Token(Token = "0x6006211")]
		[Cpp2IlInjected.Address(RVA = "0x1777B50", Offset = "0x1776550", VA = "0x181777B50", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006212")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SetPlayfabName other)
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

		[Cpp2IlInjected.Token(Token = "0x6006213")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006214")]
		[Cpp2IlInjected.Address(RVA = "0x1777C40", Offset = "0x1776640", VA = "0x181777C40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006215")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006216")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006217")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SetPlayfabName other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006218")]
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

		[Cpp2IlInjected.Token(Token = "0x6006219")]
		[Cpp2IlInjected.Address(RVA = "0x1777BD0", Offset = "0x17765D0", VA = "0x181777BD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600621A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600621B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600621C")]
		[Cpp2IlInjected.Address(RVA = "0x1777CA0", Offset = "0x17766A0", VA = "0x181777CA0")]
		static SetPlayfabName()
		{
			Func<SetPlayfabName> func = default(Func<SetPlayfabName>);
			_parser = (MessageParser<SetPlayfabName>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
