using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class Login : IMessage<Login>, IMessage, IEquatable<Login>, IDeepCloneable<Login>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				[OriginalName("LoadProfileError")]
				LoadProfileError = 1,
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				[OriginalName("Unknown")]
				Unknown = 10
			}

			[Cpp2IlInjected.Token(Token = "0x200008F")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				public const int CredentialFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private Credential credential_;

				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public const int ClientSessionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				private string clientSession_;

				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public const int DeviceInfoFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				private DeviceInfo deviceInfo_;

				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public const int ForceLoginToPlayFabFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private bool forceLoginToPlayFab_;

				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public const int LocalTimeOffsetFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				private Duration localTimeOffset_;

				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public const int ResetProfileFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				private bool resetProfile_;

				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public const int IsDevFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				private bool isDev_;

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60006C9")]
					[Cpp2IlInjected.Address(RVA = "0x1E431B0", Offset = "0x1E41BB0", VA = "0x181E431B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60006CA")]
					[Cpp2IlInjected.Address(RVA = "0x1E42E90", Offset = "0x1E41890", VA = "0x181E42E90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60006CB")]
					[Cpp2IlInjected.Address(RVA = "0x1E43630", Offset = "0x1E42030", VA = "0x181E43630", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				[DebuggerNonUserCode]
				public Credential Credential
				{
					[Cpp2IlInjected.Token(Token = "0x60006CF")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60006D0")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				[DebuggerNonUserCode]
				public string ClientSession
				{
					[Cpp2IlInjected.Token(Token = "0x60006D1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60006D2")]
					[Cpp2IlInjected.Address(RVA = "0x1E43870", Offset = "0x1E42270", VA = "0x181E43870")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				[DebuggerNonUserCode]
				public DeviceInfo DeviceInfo
				{
					[Cpp2IlInjected.Token(Token = "0x60006D3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60006D4")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				[DebuggerNonUserCode]
				public bool ForceLoginToPlayFab
				{
					[Cpp2IlInjected.Token(Token = "0x60006D5")]
					[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60006D6")]
					[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				[DebuggerNonUserCode]
				public Duration LocalTimeOffset
				{
					[Cpp2IlInjected.Token(Token = "0x60006D7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60006D8")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				[DebuggerNonUserCode]
				public bool ResetProfile
				{
					[Cpp2IlInjected.Token(Token = "0x60006D9")]
					[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60006DA")]
					[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				[DebuggerNonUserCode]
				public bool IsDev
				{
					[Cpp2IlInjected.Token(Token = "0x60006DB")]
					[Cpp2IlInjected.Address(RVA = "0xE3A5E0", Offset = "0xE38FE0", VA = "0x180E3A5E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60006DC")]
					[Cpp2IlInjected.Address(RVA = "0x11B5150", Offset = "0x11B3B50", VA = "0x1811B5150")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60006CC")]
				[Cpp2IlInjected.Address(RVA = "0x1E426E0", Offset = "0x1E410E0", VA = "0x181E426E0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006CD")]
				[Cpp2IlInjected.Address(RVA = "0x1E42B20", Offset = "0x1E41520", VA = "0x181E42B20")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006CE")]
				[Cpp2IlInjected.Address(RVA = "0x1E3DCF0", Offset = "0x1E3C6F0", VA = "0x181E3DCF0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60006DD")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E250", Offset = "0x1E3CC50", VA = "0x181E3E250", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60006DE")]
				[Cpp2IlInjected.Address(RVA = "0x1E3DFA0", Offset = "0x1E3C9A0", VA = "0x181E3DFA0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60006DF")]
				[Cpp2IlInjected.Address(RVA = "0x1E3EF70", Offset = "0x1E3D970", VA = "0x181E3EF70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60006E0")]
				[Cpp2IlInjected.Address(RVA = "0x1E40CF0", Offset = "0x1E3F6F0", VA = "0x181E40CF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60006E1")]
				[Cpp2IlInjected.Address(RVA = "0x1E414E0", Offset = "0x1E3FEE0", VA = "0x181E414E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006E2")]
				[Cpp2IlInjected.Address(RVA = "0x1E3CD10", Offset = "0x1E3B710", VA = "0x181E3CD10", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60006E3")]
				[Cpp2IlInjected.Address(RVA = "0x1E3FAC0", Offset = "0x1E3E4C0", VA = "0x181E3FAC0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006E4")]
				[Cpp2IlInjected.Address(RVA = "0x1E3F270", Offset = "0x1E3DC70", VA = "0x181E3F270", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006E5")]
				[Cpp2IlInjected.Address(RVA = "0x1E3ED00", Offset = "0x1E3D700", VA = "0x181E3ED00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60006E6")]
				[Cpp2IlInjected.Address(RVA = "0x1E403C0", Offset = "0x1E3EDC0", VA = "0x181E403C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006E7")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D5F0", Offset = "0x1E3BFF0", VA = "0x181E3D5F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000091")]
			public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40001EE")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40001F0")]
				public const int ServerSessionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001F1")]
				private string serverSession_;

				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public const int LoadProfileResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				private LoadAndInitProfileResult loadProfileResult_;

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60006EC")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C1F0", Offset = "0x1E4ABF0", VA = "0x181E4C1F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60006ED")]
					[Cpp2IlInjected.Address(RVA = "0x1E4BDF0", Offset = "0x1E4A7F0", VA = "0x181E4BDF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60006EE")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C450", Offset = "0x1E4AE50", VA = "0x181E4C450", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60006F2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60006F3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				[DebuggerNonUserCode]
				public string ServerSession
				{
					[Cpp2IlInjected.Token(Token = "0x60006F4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60006F5")]
					[Cpp2IlInjected.Address(RVA = "0x1E4CA70", Offset = "0x1E4B470", VA = "0x181E4CA70")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				[DebuggerNonUserCode]
				public LoadAndInitProfileResult LoadProfileResult
				{
					[Cpp2IlInjected.Token(Token = "0x60006F6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60006F7")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60006EF")]
				[Cpp2IlInjected.Address(RVA = "0x1E4B600", Offset = "0x1E4A000", VA = "0x181E4B600")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006F0")]
				[Cpp2IlInjected.Address(RVA = "0x1E4BAD0", Offset = "0x1E4A4D0", VA = "0x181E4BAD0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006F1")]
				[Cpp2IlInjected.Address(RVA = "0x1E46C50", Offset = "0x1E45650", VA = "0x181E46C50", Slot = "10")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60006F8")]
				[Cpp2IlInjected.Address(RVA = "0x1E47540", Offset = "0x1E45F40", VA = "0x181E47540", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60006F9")]
				[Cpp2IlInjected.Address(RVA = "0x1E470E0", Offset = "0x1E45AE0", VA = "0x181E470E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60006FA")]
				[Cpp2IlInjected.Address(RVA = "0x1E47FE0", Offset = "0x1E469E0", VA = "0x181E47FE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60006FB")]
				[Cpp2IlInjected.Address(RVA = "0x1E49BB0", Offset = "0x1E485B0", VA = "0x181E49BB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60006FC")]
				[Cpp2IlInjected.Address(RVA = "0x1E4A7F0", Offset = "0x1E491F0", VA = "0x181E4A7F0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006FD")]
				[Cpp2IlInjected.Address(RVA = "0x1E465C0", Offset = "0x1E44FC0", VA = "0x181E465C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60006FE")]
				[Cpp2IlInjected.Address(RVA = "0x1E48900", Offset = "0x1E47300", VA = "0x181E48900", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006FF")]
				[Cpp2IlInjected.Address(RVA = "0x1E48270", Offset = "0x1E46C70", VA = "0x181E48270", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000700")]
				[Cpp2IlInjected.Address(RVA = "0x1E47D40", Offset = "0x1E46740", VA = "0x181E47D40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000701")]
				[Cpp2IlInjected.Address(RVA = "0x1E49180", Offset = "0x1E47B80", VA = "0x181E49180", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000702")]
				[Cpp2IlInjected.Address(RVA = "0x1E467F0", Offset = "0x1E451F0", VA = "0x181E467F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private static readonly MessageParser<Login> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[DebuggerNonUserCode]
		public static MessageParser<Login> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x18B31B0", Offset = "0x18B1BB0", VA = "0x1818B31B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x18B3010", Offset = "0x18B1A10", VA = "0x1818B3010")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0x18B3270", Offset = "0x18B1C70", VA = "0x1818B3270", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Login()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public Login(Login other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x18B2A50", Offset = "0x18B1450", VA = "0x1818B2A50", Slot = "10")]
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

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x18B2B50", Offset = "0x18B1550", VA = "0x1818B2B50", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
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

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x18B2D30", Offset = "0x18B1730", VA = "0x1818B2D30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
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

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
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

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x18B2C50", Offset = "0x18B1650", VA = "0x1818B2C50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x18B2F00", Offset = "0x18B1900", VA = "0x1818B2F00")]
		static Login()
		{
			Func<Login> func = default(Func<Login>);
			_parser = (MessageParser<Login>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
