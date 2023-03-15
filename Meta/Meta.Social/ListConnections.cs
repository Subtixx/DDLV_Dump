using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BCF")]
	public sealed class ListConnections : IMessage<ListConnections>, IMessage, IEquatable<ListConnections>, IDeepCloneable<ListConnections>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BD0")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000BD1")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002DAC")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002DAD")]
				[OriginalName("Error")]
				Error = 100
			}

			[Cpp2IlInjected.Token(Token = "0x2000BD2")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002DAE")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002DAF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002DB0")]
				public const int TypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002DB1")]
				private ConnectionType type_;

				[Cpp2IlInjected.Token(Token = "0x4002DB2")]
				public const int InfosFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4002DB3")]
				private ConnectionInfos infos_;

				[Cpp2IlInjected.Token(Token = "0x4002DB4")]
				public const int FedIdsFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4002DB5")]
				private static readonly FieldCodec<string> _repeated_fedIds_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002DB6")]
				private readonly RepeatedField<string> fedIds_;

				[Cpp2IlInjected.Token(Token = "0x4002DB7")]
				public const int IndexesFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4002DB8")]
				private static readonly FieldCodec<int> _repeated_indexes_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002DB9")]
				private readonly RepeatedField<int> indexes_;

				[Cpp2IlInjected.Token(Token = "0x4002DBA")]
				public const int StartIndexFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002DBB")]
				private int startIndex_;

				[Cpp2IlInjected.Token(Token = "0x4002DBC")]
				public const int CountFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x4002DBD")]
				private int count_;

				[Cpp2IlInjected.Token(Token = "0x17001145")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600643A")]
					[Cpp2IlInjected.Address(RVA = "0x1E43150", Offset = "0x1E41B50", VA = "0x181E43150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001146")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600643B")]
					[Cpp2IlInjected.Address(RVA = "0x1E42F90", Offset = "0x1E41990", VA = "0x181E42F90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001147")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600643C")]
					[Cpp2IlInjected.Address(RVA = "0x1E43570", Offset = "0x1E41F70", VA = "0x181E43570", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001148")]
				[DebuggerNonUserCode]
				public ConnectionType Type
				{
					[Cpp2IlInjected.Token(Token = "0x6006441")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(ConnectionType);
					}
					[Cpp2IlInjected.Token(Token = "0x6006442")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001149")]
				[DebuggerNonUserCode]
				public ConnectionInfos Infos
				{
					[Cpp2IlInjected.Token(Token = "0x6006443")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(ConnectionInfos);
					}
					[Cpp2IlInjected.Token(Token = "0x6006444")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700114A")]
				[DebuggerNonUserCode]
				public RepeatedField<string> FedIds
				{
					[Cpp2IlInjected.Token(Token = "0x6006445")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700114B")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Indexes
				{
					[Cpp2IlInjected.Token(Token = "0x6006446")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700114C")]
				[DebuggerNonUserCode]
				public int StartIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6006447")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006448")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700114D")]
				[DebuggerNonUserCode]
				public int Count
				{
					[Cpp2IlInjected.Token(Token = "0x6006449")]
					[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600644A")]
					[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600643D")]
				[Cpp2IlInjected.Address(RVA = "0x1E427A0", Offset = "0x1E411A0", VA = "0x181E427A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600643E")]
				[Cpp2IlInjected.Address(RVA = "0x1E40270", Offset = "0x1E3EC70", VA = "0x181E40270")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600643F")]
				[Cpp2IlInjected.Address(RVA = "0x1E42980", Offset = "0x1E41380", VA = "0x181E42980")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006440")]
				[Cpp2IlInjected.Address(RVA = "0x1E3DB20", Offset = "0x1E3C520", VA = "0x181E3DB20", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600644B")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E120", Offset = "0x1E3CB20", VA = "0x181E3E120", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600644C")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E740", Offset = "0x1E3D140", VA = "0x181E3E740", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600644D")]
				[Cpp2IlInjected.Address(RVA = "0x1E3F170", Offset = "0x1E3DB70", VA = "0x181E3F170", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600644E")]
				[Cpp2IlInjected.Address(RVA = "0x1E40D50", Offset = "0x1E3F750", VA = "0x181E40D50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600644F")]
				[Cpp2IlInjected.Address(RVA = "0x1E418B0", Offset = "0x1E402B0", VA = "0x181E418B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006450")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D180", Offset = "0x1E3BB80", VA = "0x181E3D180", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006451")]
				[Cpp2IlInjected.Address(RVA = "0x1E3FFE0", Offset = "0x1E3E9E0", VA = "0x181E3FFE0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006452")]
				[Cpp2IlInjected.Address(RVA = "0x1E3FE10", Offset = "0x1E3E810", VA = "0x181E3FE10", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006453")]
				[Cpp2IlInjected.Address(RVA = "0x1E3EA70", Offset = "0x1E3D470", VA = "0x181E3EA70", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006454")]
				[Cpp2IlInjected.Address(RVA = "0x1E40620", Offset = "0x1E3F020", VA = "0x181E40620", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006455")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D350", Offset = "0x1E3BD50", VA = "0x181E3D350", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000BD4")]
			public sealed class Response : IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002DBF")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002DC0")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002DC1")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002DC2")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002DC3")]
				public const int ConnectionsFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4002DC4")]
				private static readonly FieldCodec<Connection> _repeated_connections_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002DC5")]
				private readonly RepeatedField<Connection> connections_;

				[Cpp2IlInjected.Token(Token = "0x4002DC6")]
				public const int TotalCountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002DC7")]
				private int totalCount_;

				[Cpp2IlInjected.Token(Token = "0x1700114E")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600645A")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C3D0", Offset = "0x1E4ADD0", VA = "0x181E4C3D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700114F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600645B")]
					[Cpp2IlInjected.Address(RVA = "0x1E4BFF0", Offset = "0x1E4A9F0", VA = "0x181E4BFF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001150")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600645C")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C810", Offset = "0x1E4B210", VA = "0x181E4C810", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001151")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006460")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006461")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001152")]
				[DebuggerNonUserCode]
				public RepeatedField<Connection> Connections
				{
					[Cpp2IlInjected.Token(Token = "0x6006462")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001153")]
				[DebuggerNonUserCode]
				public int TotalCount
				{
					[Cpp2IlInjected.Token(Token = "0x6006463")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006464")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600645D")]
				[Cpp2IlInjected.Address(RVA = "0x1E4BA50", Offset = "0x1E4A450", VA = "0x181E4BA50")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600645E")]
				[Cpp2IlInjected.Address(RVA = "0x1E4B650", Offset = "0x1E4A050", VA = "0x181E4B650")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600645F")]
				[Cpp2IlInjected.Address(RVA = "0x1E46EC0", Offset = "0x1E458C0", VA = "0x181E46EC0", Slot = "10")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006465")]
				[Cpp2IlInjected.Address(RVA = "0x1E46FF0", Offset = "0x1E459F0", VA = "0x181E46FF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006466")]
				[Cpp2IlInjected.Address(RVA = "0x1E476D0", Offset = "0x1E460D0", VA = "0x181E476D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006467")]
				[Cpp2IlInjected.Address(RVA = "0x1E481D0", Offset = "0x1E46BD0", VA = "0x181E481D0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006468")]
				[Cpp2IlInjected.Address(RVA = "0x1E49AF0", Offset = "0x1E484F0", VA = "0x181E49AF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006469")]
				[Cpp2IlInjected.Address(RVA = "0x1E4AAB0", Offset = "0x1E494B0", VA = "0x181E4AAB0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600646A")]
				[Cpp2IlInjected.Address(RVA = "0x1E463C0", Offset = "0x1E44DC0", VA = "0x181E463C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600646B")]
				[Cpp2IlInjected.Address(RVA = "0x1E490F0", Offset = "0x1E47AF0", VA = "0x181E490F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600646C")]
				[Cpp2IlInjected.Address(RVA = "0x1E48AE0", Offset = "0x1E474E0", VA = "0x181E48AE0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600646D")]
				[Cpp2IlInjected.Address(RVA = "0x1E47EF0", Offset = "0x1E468F0", VA = "0x181E47EF0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600646E")]
				[Cpp2IlInjected.Address(RVA = "0x1E496C0", Offset = "0x1E480C0", VA = "0x181E496C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600646F")]
				[Cpp2IlInjected.Address(RVA = "0x1E46880", Offset = "0x1E45280", VA = "0x181E46880", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002DA9")]
		private static readonly MessageParser<ListConnections> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002DAA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001142")]
		[DebuggerNonUserCode]
		public static MessageParser<ListConnections> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006428")]
			[Cpp2IlInjected.Address(RVA = "0x18A64D0", Offset = "0x18A4ED0", VA = "0x1818A64D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001143")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006429")]
			[Cpp2IlInjected.Address(RVA = "0x18A6400", Offset = "0x18A4E00", VA = "0x1818A6400")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001144")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600642A")]
			[Cpp2IlInjected.Address(RVA = "0x18A6530", Offset = "0x18A4F30", VA = "0x1818A6530", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600642B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ListConnections()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600642C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ListConnections(ListConnections other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600642D")]
		[Cpp2IlInjected.Address(RVA = "0x18A6120", Offset = "0x18A4B20", VA = "0x1818A6120", Slot = "10")]
		[DebuggerNonUserCode]
		public ListConnections Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ListConnections listConnections = default(ListConnections);
			listConnections.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (listConnections._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return listConnections;
		}

		[Cpp2IlInjected.Token(Token = "0x600642E")]
		[Cpp2IlInjected.Address(RVA = "0x18A61A0", Offset = "0x18A4BA0", VA = "0x1818A61A0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600642F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ListConnections other)
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

		[Cpp2IlInjected.Token(Token = "0x6006430")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006431")]
		[Cpp2IlInjected.Address(RVA = "0x18A6290", Offset = "0x18A4C90", VA = "0x1818A6290", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006432")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006433")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006434")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ListConnections other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006435")]
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

		[Cpp2IlInjected.Token(Token = "0x6006436")]
		[Cpp2IlInjected.Address(RVA = "0x18A6220", Offset = "0x18A4C20", VA = "0x1818A6220", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006437")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006438")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006439")]
		[Cpp2IlInjected.Address(RVA = "0x18A62F0", Offset = "0x18A4CF0", VA = "0x1818A62F0")]
		static ListConnections()
		{
			Func<ListConnections> func = default(Func<ListConnections>);
			_parser = (MessageParser<ListConnections>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
