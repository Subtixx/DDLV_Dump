using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B5B")]
	public sealed class Login : IMessage<Login>, IMessage, IEquatable<Login>, IDeepCloneable<Login>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000B5C")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000B5D")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002BFF")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002C00")]
				[OriginalName("ReplayError")]
				ReplayError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002C01")]
				[OriginalName("MissingServerConfig")]
				MissingServerConfig = 2,
				[Cpp2IlInjected.Token(Token = "0x4002C02")]
				[OriginalName("ReconnectToNewServer")]
				ReconnectToNewServer = 3,
				[Cpp2IlInjected.Token(Token = "0x4002C03")]
				[OriginalName("UnknownError")]
				UnknownError = 99
			}

			[Cpp2IlInjected.Token(Token = "0x2000B5E")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002C04")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002C05")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002C06")]
				public const int LocalTimeOffsetFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002C07")]
				private Duration localTimeOffset_;

				[Cpp2IlInjected.Token(Token = "0x4002C08")]
				public const int ClientFileDescriptorsFieldNumber = 10;

				[Cpp2IlInjected.Token(Token = "0x4002C09")]
				private static readonly FieldCodec<FileDesc> _repeated_clientFileDescriptors_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002C0A")]
				private readonly RepeatedField<FileDesc> clientFileDescriptors_;

				[Cpp2IlInjected.Token(Token = "0x4002C0B")]
				public const int PendingActionsFieldNumber = 11;

				[Cpp2IlInjected.Token(Token = "0x4002C0C")]
				private static readonly FieldCodec<WrappedRequest> _repeated_pendingActions_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002C0D")]
				private readonly RepeatedField<WrappedRequest> pendingActions_;

				[Cpp2IlInjected.Token(Token = "0x17001080")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006051")]
					[Cpp2IlInjected.Address(RVA = "0x1E432D0", Offset = "0x1E41CD0", VA = "0x181E432D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001081")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006052")]
					[Cpp2IlInjected.Address(RVA = "0x1E43010", Offset = "0x1E41A10", VA = "0x181E43010")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001082")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006053")]
					[Cpp2IlInjected.Address(RVA = "0x1E436F0", Offset = "0x1E420F0", VA = "0x181E436F0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001083")]
				[DebuggerNonUserCode]
				public Duration LocalTimeOffset
				{
					[Cpp2IlInjected.Token(Token = "0x6006057")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006058")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001084")]
				[DebuggerNonUserCode]
				public RepeatedField<FileDesc> ClientFileDescriptors
				{
					[Cpp2IlInjected.Token(Token = "0x6006059")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001085")]
				[DebuggerNonUserCode]
				public RepeatedField<WrappedRequest> PendingActions
				{
					[Cpp2IlInjected.Token(Token = "0x600605A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006054")]
				[Cpp2IlInjected.Address(RVA = "0x1E425C0", Offset = "0x1E40FC0", VA = "0x181E425C0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006055")]
				[Cpp2IlInjected.Address(RVA = "0x1E42420", Offset = "0x1E40E20", VA = "0x181E42420")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006056")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D860", Offset = "0x1E3C260", VA = "0x181E3D860", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600605B")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E430", Offset = "0x1E3CE30", VA = "0x181E3E430", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600605C")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E360", Offset = "0x1E3CD60", VA = "0x181E3E360", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600605D")]
				[Cpp2IlInjected.Address(RVA = "0x1E3EEC0", Offset = "0x1E3D8C0", VA = "0x181E3EEC0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600605E")]
				[Cpp2IlInjected.Address(RVA = "0x1E40C90", Offset = "0x1E3F690", VA = "0x181E40C90", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600605F")]
				[Cpp2IlInjected.Address(RVA = "0x1E41650", Offset = "0x1E40050", VA = "0x181E41650", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006060")]
				[Cpp2IlInjected.Address(RVA = "0x1E3CE70", Offset = "0x1E3B870", VA = "0x181E3CE70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006061")]
				[Cpp2IlInjected.Address(RVA = "0x1E3F8D0", Offset = "0x1E3E2D0", VA = "0x181E3F8D0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006062")]
				[Cpp2IlInjected.Address(RVA = "0x1E3F560", Offset = "0x1E3DF60", VA = "0x181E3F560", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006063")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E8D0", Offset = "0x1E3D2D0", VA = "0x181E3E8D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006064")]
				[Cpp2IlInjected.Address(RVA = "0x1E40A50", Offset = "0x1E3F450", VA = "0x181E40A50", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006065")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D560", Offset = "0x1E3BF60", VA = "0x181E3D560", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000B60")]
			public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlinePayload
			{
				[Cpp2IlInjected.Token(Token = "0x4002C0F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002C10")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002C11")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002C12")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002C13")]
				public const int ProfileFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002C14")]
				private Profile profile_;

				[Cpp2IlInjected.Token(Token = "0x4002C15")]
				public const int CrmFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002C16")]
				private string crm_;

				[Cpp2IlInjected.Token(Token = "0x4002C17")]
				public const int SemFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002C18")]
				private string sem_;

				[Cpp2IlInjected.Token(Token = "0x4002C19")]
				public const int ServerTimeFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4002C1A")]
				private Timestamp serverTime_;

				[Cpp2IlInjected.Token(Token = "0x4002C1B")]
				public const int OutOfDateFilesFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x4002C1C")]
				private static readonly FieldCodec<FileDesc> _repeated_outOfDateFiles_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4002C1D")]
				private readonly RepeatedField<FileDesc> outOfDateFiles_;

				[Cpp2IlInjected.Token(Token = "0x4002C1E")]
				public const int NumReplayErrorsFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4002C1F")]
				private int numReplayErrors_;

				[Cpp2IlInjected.Token(Token = "0x4002C20")]
				public const int OnlineProfileFieldNumber = 10;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4002C21")]
				private OnlineProfile onlineProfile_;

				[Cpp2IlInjected.Token(Token = "0x17001086")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600606A")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C250", Offset = "0x1E4AC50", VA = "0x181E4C250")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001087")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600606B")]
					[Cpp2IlInjected.Address(RVA = "0x1E4BEF0", Offset = "0x1E4A8F0", VA = "0x181E4BEF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001088")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600606C")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C8D0", Offset = "0x1E4B2D0", VA = "0x181E4C8D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001089")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006070")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006071")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700108A")]
				[DebuggerNonUserCode]
				public Profile Profile
				{
					[Cpp2IlInjected.Token(Token = "0x6006072")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006073")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700108B")]
				[DebuggerNonUserCode]
				public string Crm
				{
					[Cpp2IlInjected.Token(Token = "0x6006074")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006075")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C990", Offset = "0x1E4B390", VA = "0x181E4C990")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700108C")]
				[DebuggerNonUserCode]
				public string Sem
				{
					[Cpp2IlInjected.Token(Token = "0x6006076")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006077")]
					[Cpp2IlInjected.Address(RVA = "0x1E4CA00", Offset = "0x1E4B400", VA = "0x181E4CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700108D")]
				[DebuggerNonUserCode]
				public Timestamp ServerTime
				{
					[Cpp2IlInjected.Token(Token = "0x6006078")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006079")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700108E")]
				[DebuggerNonUserCode]
				public RepeatedField<FileDesc> OutOfDateFiles
				{
					[Cpp2IlInjected.Token(Token = "0x600607A")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700108F")]
				[DebuggerNonUserCode]
				public int NumReplayErrors
				{
					[Cpp2IlInjected.Token(Token = "0x600607B")]
					[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600607C")]
					[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001090")]
				[DebuggerNonUserCode]
				public OnlineProfile OnlineProfile
				{
					[Cpp2IlInjected.Token(Token = "0x600607D")]
					[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600607E")]
					[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001091")]
				public IReadOnlyDictionary<string, Statistic> Statistics
				{
					[Cpp2IlInjected.Token(Token = "0x600608A")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C430", Offset = "0x1E4AE30", VA = "0x181E4C430", Slot = "14")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001092")]
				public IReadOnlyDictionary<int, Amount> Items
				{
					[Cpp2IlInjected.Token(Token = "0x600608B")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C170", Offset = "0x1E4AB70", VA = "0x181E4C170", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001093")]
				public IReadOnlyDictionary<int, Amount> Currencies
				{
					[Cpp2IlInjected.Token(Token = "0x600608C")]
					[Cpp2IlInjected.Address(RVA = "0x1556C10", Offset = "0x1555610", VA = "0x181556C10", Slot = "16")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600606D")]
				[Cpp2IlInjected.Address(RVA = "0x1E4BB90", Offset = "0x1E4A590", VA = "0x181E4BB90")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600606E")]
				[Cpp2IlInjected.Address(RVA = "0x1E4B760", Offset = "0x1E4A160", VA = "0x181E4B760")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600606F")]
				[Cpp2IlInjected.Address(RVA = "0x1E46910", Offset = "0x1E45310", VA = "0x181E46910", Slot = "10")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600607F")]
				[Cpp2IlInjected.Address(RVA = "0x1E47210", Offset = "0x1E45C10", VA = "0x181E47210", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006080")]
				[Cpp2IlInjected.Address(RVA = "0x1E47370", Offset = "0x1E45D70", VA = "0x181E47370", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006081")]
				[Cpp2IlInjected.Address(RVA = "0x1E48090", Offset = "0x1E46A90", VA = "0x181E48090", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006082")]
				[Cpp2IlInjected.Address(RVA = "0x1E49C10", Offset = "0x1E48610", VA = "0x181E49C10", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006083")]
				[Cpp2IlInjected.Address(RVA = "0x1E4A8B0", Offset = "0x1E492B0", VA = "0x181E4A8B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006084")]
				[Cpp2IlInjected.Address(RVA = "0x1E45ED0", Offset = "0x1E448D0", VA = "0x181E45ED0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006085")]
				[Cpp2IlInjected.Address(RVA = "0x1E48C00", Offset = "0x1E47600", VA = "0x181E48C00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006086")]
				[Cpp2IlInjected.Address(RVA = "0x1E48670", Offset = "0x1E47070", VA = "0x181E48670", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006087")]
				[Cpp2IlInjected.Address(RVA = "0x1E47A40", Offset = "0x1E46440", VA = "0x181E47A40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006088")]
				[Cpp2IlInjected.Address(RVA = "0x1E492B0", Offset = "0x1E47CB0", VA = "0x181E492B0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006089")]
				[Cpp2IlInjected.Address(RVA = "0x1E466C0", Offset = "0x1E450C0", VA = "0x181E466C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002BFC")]
		private static readonly MessageParser<Login> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BFD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700107D")]
		[DebuggerNonUserCode]
		public static MessageParser<Login> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600603F")]
			[Cpp2IlInjected.Address(RVA = "0x18B3210", Offset = "0x18B1C10", VA = "0x1818B3210")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006040")]
			[Cpp2IlInjected.Address(RVA = "0x18B30E0", Offset = "0x18B1AE0", VA = "0x1818B30E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006041")]
			[Cpp2IlInjected.Address(RVA = "0x18B3380", Offset = "0x18B1D80", VA = "0x1818B3380", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006042")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Login()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006043")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public Login(Login other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006044")]
		[Cpp2IlInjected.Address(RVA = "0x18B2AD0", Offset = "0x18B14D0", VA = "0x1818B2AD0", Slot = "10")]
		[DebuggerNonUserCode]
		public Login Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			Login login = default(Login);
			login.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (login._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return login;
		}

		[Cpp2IlInjected.Token(Token = "0x6006045")]
		[Cpp2IlInjected.Address(RVA = "0x18B2BD0", Offset = "0x18B15D0", VA = "0x1818B2BD0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006046")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Login other)
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

		[Cpp2IlInjected.Token(Token = "0x6006047")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006048")]
		[Cpp2IlInjected.Address(RVA = "0x18B2D90", Offset = "0x18B1790", VA = "0x1818B2D90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006049")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600604A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600604B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Login other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600604C")]
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

		[Cpp2IlInjected.Token(Token = "0x600604D")]
		[Cpp2IlInjected.Address(RVA = "0x18B2CC0", Offset = "0x18B16C0", VA = "0x1818B2CC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600604E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600604F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006050")]
		[Cpp2IlInjected.Address(RVA = "0x18B2DF0", Offset = "0x18B17F0", VA = "0x1818B2DF0")]
		static Login()
		{
			Func<Login> func = default(Func<Login>);
			_parser = (MessageParser<Login>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
