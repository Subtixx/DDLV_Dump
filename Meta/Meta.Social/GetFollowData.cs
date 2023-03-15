using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BD7")]
	public sealed class GetFollowData : IMessage<GetFollowData>, IMessage, IEquatable<GetFollowData>, IDeepCloneable<GetFollowData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BD8")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000BD9")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002DCD")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002DCE")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002DCF")]
				[OriginalName("NoFriendsFound")]
				NoFriendsFound = 2,
				[Cpp2IlInjected.Token(Token = "0x4002DD0")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000BDA")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002DD1")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002DD2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002DD3")]
				public const int GetFollowingsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002DD4")]
				private bool getFollowings_;

				[Cpp2IlInjected.Token(Token = "0x4002DD5")]
				public const int GetFollowersFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
				[Cpp2IlInjected.Token(Token = "0x4002DD6")]
				private bool getFollowers_;

				[Cpp2IlInjected.Token(Token = "0x17001157")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006489")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FEB0", Offset = "0x1E7E8B0", VA = "0x181E7FEB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001158")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600648A")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FA10", Offset = "0x1E7E410", VA = "0x181E7FA10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001159")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600648B")]
					[Cpp2IlInjected.Address(RVA = "0x1E80390", Offset = "0x1E7ED90", VA = "0x181E80390", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115A")]
				[DebuggerNonUserCode]
				public bool GetFollowings
				{
					[Cpp2IlInjected.Token(Token = "0x600648F")]
					[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006490")]
					[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115B")]
				[DebuggerNonUserCode]
				public bool GetFollowers
				{
					[Cpp2IlInjected.Token(Token = "0x6006491")]
					[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006492")]
					[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600648C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600648D")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F0E0", Offset = "0x1E7DAE0", VA = "0x181E7F0E0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600648E")]
				[Cpp2IlInjected.Address(RVA = "0x1E795A0", Offset = "0x1E77FA0", VA = "0x181E795A0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006493")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A1F0", Offset = "0x1E78BF0", VA = "0x181E7A1F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006494")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A3D0", Offset = "0x1E78DD0", VA = "0x181E7A3D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006495")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B000", Offset = "0x1E79A00", VA = "0x181E7B000", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006496")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C8D0", Offset = "0x1E7B2D0", VA = "0x181E7C8D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006497")]
				[Cpp2IlInjected.Address(RVA = "0x1E7DE60", Offset = "0x1E7C860", VA = "0x181E7DE60", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006498")]
				[Cpp2IlInjected.Address(RVA = "0x1E78E70", Offset = "0x1E77870", VA = "0x181E78E70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006499")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B890", Offset = "0x1E7A290", VA = "0x181E7B890", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600649A")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BD50", Offset = "0x1E7A750", VA = "0x181E7BD50", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600649B")]
				[Cpp2IlInjected.Address(RVA = "0x1E7AE40", Offset = "0x1E79840", VA = "0x181E7AE40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600649C")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BEF0", Offset = "0x1E7A8F0", VA = "0x181E7BEF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600649D")]
				[Cpp2IlInjected.Address(RVA = "0x1E79060", Offset = "0x1E77A60", VA = "0x181E79060", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000BDC")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002DD8")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002DD9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002DDA")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002DDB")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002DDC")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002DDD")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002DDE")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002DDF")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002DE0")]
				public const int FollowingsFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4002DE1")]
				private static readonly FieldCodec<FollowData> _repeated_followings_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002DE2")]
				private readonly RepeatedField<FollowData> followings_;

				[Cpp2IlInjected.Token(Token = "0x4002DE3")]
				public const int FollowerIdsFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x4002DE4")]
				private static readonly FieldCodec<string> _repeated_followerIds_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4002DE5")]
				private readonly RepeatedField<string> followerIds_;

				[Cpp2IlInjected.Token(Token = "0x4002DE6")]
				public const int FollowingTotalFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4002DE7")]
				private int followingTotal_;

				[Cpp2IlInjected.Token(Token = "0x4002DE8")]
				public const int FollowerTotalFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
				[Cpp2IlInjected.Token(Token = "0x4002DE9")]
				private int followerTotal_;

				[Cpp2IlInjected.Token(Token = "0x4002DEA")]
				public const int FollowingOnlyFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4002DEB")]
				private int followingOnly_;

				[Cpp2IlInjected.Token(Token = "0x4002DEC")]
				public const int FollowerOnlyFieldNumber = 9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
				[Cpp2IlInjected.Token(Token = "0x4002DED")]
				private int followerOnly_;

				[Cpp2IlInjected.Token(Token = "0x1700115C")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60064A2")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F220", Offset = "0x1E8DC20", VA = "0x181E8F220")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60064A3")]
					[Cpp2IlInjected.Address(RVA = "0x1E8ECE0", Offset = "0x1E8D6E0", VA = "0x181E8ECE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60064A4")]
					[Cpp2IlInjected.Address(RVA = "0x1E8FDC0", Offset = "0x1E8E7C0", VA = "0x181E8FDC0", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115F")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60064A8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60064A9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001160")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60064AA")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60064AB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001161")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60064AC")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60064AD")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001162")]
				[DebuggerNonUserCode]
				public RepeatedField<FollowData> Followings
				{
					[Cpp2IlInjected.Token(Token = "0x60064AE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001163")]
				[DebuggerNonUserCode]
				public RepeatedField<string> FollowerIds
				{
					[Cpp2IlInjected.Token(Token = "0x60064AF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001164")]
				[DebuggerNonUserCode]
				public int FollowingTotal
				{
					[Cpp2IlInjected.Token(Token = "0x60064B0")]
					[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60064B1")]
					[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001165")]
				[DebuggerNonUserCode]
				public int FollowerTotal
				{
					[Cpp2IlInjected.Token(Token = "0x60064B2")]
					[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60064B3")]
					[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001166")]
				[DebuggerNonUserCode]
				public int FollowingOnly
				{
					[Cpp2IlInjected.Token(Token = "0x60064B4")]
					[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60064B5")]
					[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001167")]
				[DebuggerNonUserCode]
				public int FollowerOnly
				{
					[Cpp2IlInjected.Token(Token = "0x60064B6")]
					[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60064B7")]
					[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001168")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60064C3")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60064C4")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60064A5")]
				[Cpp2IlInjected.Address(RVA = "0x1E8DAB0", Offset = "0x1E8C4B0", VA = "0x181E8DAB0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60064A6")]
				[Cpp2IlInjected.Address(RVA = "0x1E8D440", Offset = "0x1E8BE40", VA = "0x181E8D440")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60064A7")]
				[Cpp2IlInjected.Address(RVA = "0x1E85560", Offset = "0x1E83F60", VA = "0x181E85560", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60064B8")]
				[Cpp2IlInjected.Address(RVA = "0x1E86620", Offset = "0x1E85020", VA = "0x181E86620", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60064B9")]
				[Cpp2IlInjected.Address(RVA = "0x1E86780", Offset = "0x1E85180", VA = "0x181E86780", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60064BA")]
				[Cpp2IlInjected.Address(RVA = "0x1E87DE0", Offset = "0x1E867E0", VA = "0x181E87DE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60064BB")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B3D0", Offset = "0x1E89DD0", VA = "0x181E8B3D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60064BC")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B9B0", Offset = "0x1E8A3B0", VA = "0x181E8B9B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60064BD")]
				[Cpp2IlInjected.Address(RVA = "0x1E84590", Offset = "0x1E82F90", VA = "0x181E84590", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60064BE")]
				[Cpp2IlInjected.Address(RVA = "0x1E899B0", Offset = "0x1E883B0", VA = "0x181E899B0", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60064BF")]
				[Cpp2IlInjected.Address(RVA = "0x1E89590", Offset = "0x1E87F90", VA = "0x181E89590", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60064C0")]
				[Cpp2IlInjected.Address(RVA = "0x1E874A0", Offset = "0x1E85EA0", VA = "0x181E874A0", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60064C1")]
				[Cpp2IlInjected.Address(RVA = "0x1E8ACF0", Offset = "0x1E896F0", VA = "0x181E8ACF0", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60064C2")]
				[Cpp2IlInjected.Address(RVA = "0x1E84E20", Offset = "0x1E83820", VA = "0x181E84E20", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60064C5")]
				[Cpp2IlInjected.Address(RVA = "0x1E86F50", Offset = "0x1E85950", VA = "0x181E86F50", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__71))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002DCA")]
		private static readonly MessageParser<GetFollowData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002DCB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001154")]
		[DebuggerNonUserCode]
		public static MessageParser<GetFollowData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006477")]
			[Cpp2IlInjected.Address(RVA = "0x1D04480", Offset = "0x1D02E80", VA = "0x181D04480")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001155")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006478")]
			[Cpp2IlInjected.Address(RVA = "0x1D043B0", Offset = "0x1D02DB0", VA = "0x181D043B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001156")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006479")]
			[Cpp2IlInjected.Address(RVA = "0x1D044E0", Offset = "0x1D02EE0", VA = "0x181D044E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600647A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GetFollowData()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600647B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GetFollowData(GetFollowData other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600647C")]
		[Cpp2IlInjected.Address(RVA = "0x1D040D0", Offset = "0x1D02AD0", VA = "0x181D040D0", Slot = "10")]
		[DebuggerNonUserCode]
		public GetFollowData Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GetFollowData getFollowData = default(GetFollowData);
			getFollowData.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (getFollowData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return getFollowData;
		}

		[Cpp2IlInjected.Token(Token = "0x600647D")]
		[Cpp2IlInjected.Address(RVA = "0x1D04150", Offset = "0x1D02B50", VA = "0x181D04150", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600647E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GetFollowData other)
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

		[Cpp2IlInjected.Token(Token = "0x600647F")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006480")]
		[Cpp2IlInjected.Address(RVA = "0x1D04240", Offset = "0x1D02C40", VA = "0x181D04240", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006481")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006482")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006483")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GetFollowData other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006484")]
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

		[Cpp2IlInjected.Token(Token = "0x6006485")]
		[Cpp2IlInjected.Address(RVA = "0x1D041D0", Offset = "0x1D02BD0", VA = "0x181D041D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006486")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006487")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006488")]
		[Cpp2IlInjected.Address(RVA = "0x1D042A0", Offset = "0x1D02CA0", VA = "0x181D042A0")]
		static GetFollowData()
		{
			Func<GetFollowData> func = default(Func<GetFollowData>);
			_parser = (MessageParser<GetFollowData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
