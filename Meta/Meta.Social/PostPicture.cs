using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Social.Ralph;
using PlayFab.EconomyModels;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000C51")]
	public sealed class PostPicture : IMessage<PostPicture>, IMessage, IEquatable<PostPicture>, IDeepCloneable<PostPicture>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C52")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C53")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002FAD")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4002FAE")]
				[OriginalName("PlayFabError")]
				PlayFabError,
				[Cpp2IlInjected.Token(Token = "0x4002FAF")]
				[OriginalName("OverLimit")]
				OverLimit,
				[Cpp2IlInjected.Token(Token = "0x4002FB0")]
				[OriginalName("UnknownImageUploadError")]
				UnknownImageUploadError,
				[Cpp2IlInjected.Token(Token = "0x4002FB1")]
				[OriginalName("MissingImage")]
				MissingImage,
				[Cpp2IlInjected.Token(Token = "0x4002FB2")]
				[OriginalName("CannotCreateItem")]
				CannotCreateItem,
				[Cpp2IlInjected.Token(Token = "0x4002FB3")]
				[OriginalName("EventExpired")]
				EventExpired,
				[Cpp2IlInjected.Token(Token = "0x4002FB4")]
				[OriginalName("EventLimitReached")]
				EventLimitReached,
				[Cpp2IlInjected.Token(Token = "0x4002FB5")]
				[OriginalName("EventParticipationFailed")]
				EventParticipationFailed,
				[Cpp2IlInjected.Token(Token = "0x4002FB6")]
				[OriginalName("ConnectionError")]
				ConnectionError,
				[Cpp2IlInjected.Token(Token = "0x4002FB7")]
				[OriginalName("UnknownError")]
				UnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x2000C54")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002FB8")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002FB9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002FBA")]
				public const int RecipeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002FBB")]
				private PictureRecipe recipe_;

				[Cpp2IlInjected.Token(Token = "0x4002FBC")]
				public const int ApplyToEventFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002FBD")]
				private bool applyToEvent_;

				[Cpp2IlInjected.Token(Token = "0x17001247")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006920")]
					[Cpp2IlInjected.Address(RVA = "0x1DC44C0", Offset = "0x1DC2EC0", VA = "0x181DC44C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001248")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006921")]
					[Cpp2IlInjected.Address(RVA = "0x1DC41D0", Offset = "0x1DC2BD0", VA = "0x181DC41D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001249")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006922")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4710", Offset = "0x1DC3110", VA = "0x181DC4710", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700124A")]
				[DebuggerNonUserCode]
				public PictureRecipe Recipe
				{
					[Cpp2IlInjected.Token(Token = "0x6006926")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006927")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700124B")]
				[DebuggerNonUserCode]
				public bool ApplyToEvent
				{
					[Cpp2IlInjected.Token(Token = "0x6006928")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006929")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006923")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3DC0", Offset = "0x1DC27C0", VA = "0x181DC3DC0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006924")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3EB0", Offset = "0x1DC28B0", VA = "0x181DC3EB0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006925")]
				[Cpp2IlInjected.Address(RVA = "0x1DBFBA0", Offset = "0x1DBE5A0", VA = "0x181DBFBA0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600692A")]
				[Cpp2IlInjected.Address(RVA = "0x1DBFFA0", Offset = "0x1DBE9A0", VA = "0x181DBFFA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600692B")]
				[Cpp2IlInjected.Address(RVA = "0x1807960", Offset = "0x1806360", VA = "0x181807960", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600692C")]
				[Cpp2IlInjected.Address(RVA = "0x1807AA0", Offset = "0x18064A0", VA = "0x181807AA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600692D")]
				[Cpp2IlInjected.Address(RVA = "0x1DC24B0", Offset = "0x1DC0EB0", VA = "0x181DC24B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600692E")]
				[Cpp2IlInjected.Address(RVA = "0x1807E30", Offset = "0x1806830", VA = "0x181807E30", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600692F")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF780", Offset = "0x1DBE180", VA = "0x181DBF780", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006930")]
				[Cpp2IlInjected.Address(RVA = "0x1DC18A0", Offset = "0x1DC02A0", VA = "0x181DC18A0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006931")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1700", Offset = "0x1DC0100", VA = "0x181DC1700", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006932")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0A50", Offset = "0x1DBF450", VA = "0x181DC0A50", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006933")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1FE0", Offset = "0x1DC09E0", VA = "0x181DC1FE0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006934")]
				[Cpp2IlInjected.Address(RVA = "0x18077D0", Offset = "0x18061D0", VA = "0x1818077D0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006935")]
				[Cpp2IlInjected.Address(RVA = "0x1DC2690", Offset = "0x1DC1090", VA = "0x181DC2690", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C56")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002FBF")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002FC0")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002FC1")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002FC2")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002FC3")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002FC4")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002FC5")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002FC6")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002FC7")]
				public const int EntryIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002FC8")]
				private string entryId_;

				[Cpp2IlInjected.Token(Token = "0x4002FC9")]
				public const int EventTicketRemainingFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4002FCA")]
				private int eventTicketRemaining_;

				[Cpp2IlInjected.Token(Token = "0x4002FCB")]
				public const int NewsFeedPostFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4002FCC")]
				private NewsFeedPost newsFeedPost_;

				[Cpp2IlInjected.Token(Token = "0x1700124C")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600693A")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF090", Offset = "0x1DCDA90", VA = "0x181DCF090")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700124D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600693B")]
					[Cpp2IlInjected.Address(RVA = "0x1DCEAF0", Offset = "0x1DCD4F0", VA = "0x181DCEAF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700124E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600693C")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF3F0", Offset = "0x1DCDDF0", VA = "0x181DCF3F0", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700124F")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006940")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006941")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001250")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006942")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006943")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001251")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006944")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006945")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001252")]
				[DebuggerNonUserCode]
				public string EntryId
				{
					[Cpp2IlInjected.Token(Token = "0x6006946")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006947")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF6F0", Offset = "0x1DCE0F0", VA = "0x181DCF6F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001253")]
				[DebuggerNonUserCode]
				public int EventTicketRemaining
				{
					[Cpp2IlInjected.Token(Token = "0x6006948")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006949")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001254")]
				[DebuggerNonUserCode]
				public NewsFeedPost NewsFeedPost
				{
					[Cpp2IlInjected.Token(Token = "0x600694A")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600694B")]
					[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001255")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006957")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006958")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001256")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006959")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600695A")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600693D")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE550", Offset = "0x1DCCF50", VA = "0x181DCE550")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600693E")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE040", Offset = "0x1DCCA40", VA = "0x181DCE040")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600693F")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8AA0", Offset = "0x1DC74A0", VA = "0x181DC8AA0", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600694C")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9690", Offset = "0x1DC8090", VA = "0x181DC9690", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600694D")]
				[Cpp2IlInjected.Address(RVA = "0x1DC90D0", Offset = "0x1DC7AD0", VA = "0x181DC90D0", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600694E")]
				[Cpp2IlInjected.Address(RVA = "0x1DCA6F0", Offset = "0x1DC90F0", VA = "0x181DCA6F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600694F")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCBA0", Offset = "0x1DCB5A0", VA = "0x181DCCBA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006950")]
				[Cpp2IlInjected.Address(RVA = "0x1DCD1D0", Offset = "0x1DCBBD0", VA = "0x181DCD1D0", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006951")]
				[Cpp2IlInjected.Address(RVA = "0x1DC7C60", Offset = "0x1DC6660", VA = "0x181DC7C60", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006952")]
				[Cpp2IlInjected.Address(RVA = "0x1DCB2D0", Offset = "0x1DC9CD0", VA = "0x181DCB2D0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006953")]
				[Cpp2IlInjected.Address(RVA = "0x1DCBB50", Offset = "0x1DCA550", VA = "0x181DCBB50", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006954")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9FF0", Offset = "0x1DC89F0", VA = "0x181DC9FF0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006955")]
				[Cpp2IlInjected.Address(RVA = "0x1DCC3F0", Offset = "0x1DCADF0", VA = "0x181DCC3F0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006956")]
				[Cpp2IlInjected.Address(RVA = "0x1DC86D0", Offset = "0x1DC70D0", VA = "0x181DC86D0", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600695B")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9960", Offset = "0x1DC8360", VA = "0x181DC9960", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__59))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600695C")]
				[Cpp2IlInjected.Address(RVA = "0x1DC5D10", Offset = "0x1DC4710", VA = "0x181DC5D10", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600695D")]
				[Cpp2IlInjected.Address(RVA = "0x1DCBE40", Offset = "0x1DCA840", VA = "0x181DCBE40")]
				[AsyncStateMachine(typeof(_003CPreparePostPictureAsync_003Ed__61))]
				private Task<PrepareUploadUrl.Result> PreparePostPictureAsync(ClientSession clientSession, PrepareUploadUrl.Request request)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600695E")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8DF0", Offset = "0x1DC77F0", VA = "0x181DC8DF0")]
				private CatalogItem CreatePostItem(ClientSession clientSession, EntityKey entity, string playfabId, string imageId, string imageUrl, string thumbId, string thumbUrl, List<int> items, List<string> tags)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002FAA")]
		private static readonly MessageParser<PostPicture> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002FAB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001244")]
		[DebuggerNonUserCode]
		public static MessageParser<PostPicture> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600690E")]
			[Cpp2IlInjected.Address(RVA = "0x7C0800", Offset = "0x7BF200", VA = "0x1807C0800")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001245")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600690F")]
			[Cpp2IlInjected.Address(RVA = "0x7C0600", Offset = "0x7BF000", VA = "0x1807C0600")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001246")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006910")]
			[Cpp2IlInjected.Address(RVA = "0x7C0970", Offset = "0x7BF370", VA = "0x1807C0970", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006911")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PostPicture()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006912")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PostPicture(PostPicture other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006913")]
		[Cpp2IlInjected.Address(RVA = "0x7C00C0", Offset = "0x7BEAC0", VA = "0x1807C00C0", Slot = "10")]
		[DebuggerNonUserCode]
		public PostPicture Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PostPicture postPicture = default(PostPicture);
			postPicture.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (postPicture._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return postPicture;
		}

		[Cpp2IlInjected.Token(Token = "0x6006914")]
		[Cpp2IlInjected.Address(RVA = "0x7C01C0", Offset = "0x7BEBC0", VA = "0x1807C01C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006915")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PostPicture other)
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

		[Cpp2IlInjected.Token(Token = "0x6006916")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006917")]
		[Cpp2IlInjected.Address(RVA = "0x7C0320", Offset = "0x7BED20", VA = "0x1807C0320", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006918")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006919")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600691A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PostPicture other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600691B")]
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

		[Cpp2IlInjected.Token(Token = "0x600691C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0240", Offset = "0x7BEC40", VA = "0x1807C0240", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600691D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600691E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600691F")]
		[Cpp2IlInjected.Address(RVA = "0x7C03E0", Offset = "0x7BEDE0", VA = "0x1807C03E0")]
		static PostPicture()
		{
			Func<PostPicture> func = default(Func<PostPicture>);
			_parser = (MessageParser<PostPicture>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
