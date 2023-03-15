using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200049B")]
	public sealed class ConvertToDreamDust : IMessage<ConvertToDreamDust>, IMessage, IEquatable<ConvertToDreamDust>, IDeepCloneable<ConvertToDreamDust>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200049C")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200049D")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000E55")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4000E56")]
				[OriginalName("InvalidItem")]
				InvalidItem = 2
			}

			[Cpp2IlInjected.Token(Token = "0x200049E")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E57")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E58")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E59")]
				public const int ItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4000E5A")]
				private static readonly FieldCodec<ItemAmount> _repeated_items_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E5B")]
				private readonly RepeatedField<ItemAmount> items_;

				[Cpp2IlInjected.Token(Token = "0x17000839")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002CDE")]
					[Cpp2IlInjected.Address(RVA = "0x1F07C30", Offset = "0x1F06630", VA = "0x181F07C30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700083A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002CDF")]
					[Cpp2IlInjected.Address(RVA = "0x1F07950", Offset = "0x1F06350", VA = "0x181F07950")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700083B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002CE0")]
					[Cpp2IlInjected.Address(RVA = "0x1F07FF0", Offset = "0x1F069F0", VA = "0x181F07FF0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700083C")]
				[DebuggerNonUserCode]
				public RepeatedField<ItemAmount> Items
				{
					[Cpp2IlInjected.Token(Token = "0x6002CE4")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE1")]
				[Cpp2IlInjected.Address(RVA = "0x1F07100", Offset = "0x1F05B00", VA = "0x181F07100")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE2")]
				[Cpp2IlInjected.Address(RVA = "0x1F07330", Offset = "0x1F05D30", VA = "0x181F07330")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE3")]
				[Cpp2IlInjected.Address(RVA = "0x1F02940", Offset = "0x1F01340", VA = "0x181F02940", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE5")]
				[Cpp2IlInjected.Address(RVA = "0x1F03230", Offset = "0x1F01C30", VA = "0x181F03230", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE6")]
				[Cpp2IlInjected.Address(RVA = "0x1F03430", Offset = "0x1F01E30", VA = "0x181F03430", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE7")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE8")]
				[Cpp2IlInjected.Address(RVA = "0x1F04B90", Offset = "0x1F03590", VA = "0x181F04B90", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002CE9")]
				[Cpp2IlInjected.Address(RVA = "0x1F06400", Offset = "0x1F04E00", VA = "0x181F06400", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CEA")]
				[Cpp2IlInjected.Address(RVA = "0x1F01930", Offset = "0x1F00330", VA = "0x181F01930", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002CEB")]
				[Cpp2IlInjected.Address(RVA = "0x1F03D40", Offset = "0x1F02740", VA = "0x181F03D40", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CEC")]
				[Cpp2IlInjected.Address(RVA = "0x1F03ED0", Offset = "0x1F028D0", VA = "0x181F03ED0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CED")]
				[Cpp2IlInjected.Address(RVA = "0x1F036C0", Offset = "0x1F020C0", VA = "0x181F036C0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002CEE")]
				[Cpp2IlInjected.Address(RVA = "0x1F04150", Offset = "0x1F02B50", VA = "0x181F04150", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CEF")]
				[Cpp2IlInjected.Address(RVA = "0x1F027A0", Offset = "0x1F011A0", VA = "0x181F027A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004A0")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000E5D")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000E5E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000E5F")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000E60")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000E61")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000E62")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000E63")]
				public const int DreamDustAmountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000E64")]
				private int dreamDustAmount_;

				[Cpp2IlInjected.Token(Token = "0x4000E65")]
				public const int UnconvertedItemsFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4000E66")]
				private static readonly FieldCodec<ItemAmount> _repeated_unconvertedItems_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000E67")]
				private readonly RepeatedField<ItemAmount> unconvertedItems_;

				[Cpp2IlInjected.Token(Token = "0x1700083D")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002CF4")]
					[Cpp2IlInjected.Address(RVA = "0x1F15AC0", Offset = "0x1F144C0", VA = "0x181F15AC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700083E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002CF5")]
					[Cpp2IlInjected.Address(RVA = "0x1F157E0", Offset = "0x1F141E0", VA = "0x181F157E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700083F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002CF6")]
					[Cpp2IlInjected.Address(RVA = "0x1F16180", Offset = "0x1F14B80", VA = "0x181F16180", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000840")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002CFA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002CFB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000841")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002CFC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002CFD")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000842")]
				[DebuggerNonUserCode]
				public int DreamDustAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6002CFE")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002CFF")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000843")]
				[DebuggerNonUserCode]
				public RepeatedField<ItemAmount> UnconvertedItems
				{
					[Cpp2IlInjected.Token(Token = "0x6002D00")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000844")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002D0C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002D0D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002CF7")]
				[Cpp2IlInjected.Address(RVA = "0x1F14FA0", Offset = "0x1F139A0", VA = "0x181F14FA0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CF8")]
				[Cpp2IlInjected.Address(RVA = "0x1F14A20", Offset = "0x1F13420", VA = "0x181F14A20")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002CF9")]
				[Cpp2IlInjected.Address(RVA = "0x1F0F5D0", Offset = "0x1F0DFD0", VA = "0x181F0F5D0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D01")]
				[Cpp2IlInjected.Address(RVA = "0x1F102D0", Offset = "0x1F0ECD0", VA = "0x181F102D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D02")]
				[Cpp2IlInjected.Address(RVA = "0x1F10000", Offset = "0x1F0EA00", VA = "0x181F10000", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D03")]
				[Cpp2IlInjected.Address(RVA = "0x1C05FB0", Offset = "0x1C049B0", VA = "0x181C05FB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D04")]
				[Cpp2IlInjected.Address(RVA = "0x1F136D0", Offset = "0x1F120D0", VA = "0x181F136D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D05")]
				[Cpp2IlInjected.Address(RVA = "0x1F139C0", Offset = "0x1F123C0", VA = "0x181F139C0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D06")]
				[Cpp2IlInjected.Address(RVA = "0x1F0EF80", Offset = "0x1F0D980", VA = "0x181F0EF80", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002D07")]
				[Cpp2IlInjected.Address(RVA = "0x1F12270", Offset = "0x1F10C70", VA = "0x181F12270", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D08")]
				[Cpp2IlInjected.Address(RVA = "0x1F11110", Offset = "0x1F0FB10", VA = "0x181F11110", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D09")]
				[Cpp2IlInjected.Address(RVA = "0x1F10900", Offset = "0x1F0F300", VA = "0x181F10900", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002D0A")]
				[Cpp2IlInjected.Address(RVA = "0x1F130B0", Offset = "0x1F11AB0", VA = "0x181F130B0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D0B")]
				[Cpp2IlInjected.Address(RVA = "0x1F0F250", Offset = "0x1F0DC50", VA = "0x181F0F250", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002D0E")]
				[Cpp2IlInjected.Address(RVA = "0x1F08470", Offset = "0x1F06E70", VA = "0x181F08470", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000E52")]
		private static readonly MessageParser<ConvertToDreamDust> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E53")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000836")]
		[DebuggerNonUserCode]
		public static MessageParser<ConvertToDreamDust> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCC")]
			[Cpp2IlInjected.Address(RVA = "0x18B9FD0", Offset = "0x18B89D0", VA = "0x1818B9FD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000837")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCD")]
			[Cpp2IlInjected.Address(RVA = "0x18B9F00", Offset = "0x18B8900", VA = "0x1818B9F00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000838")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCE")]
			[Cpp2IlInjected.Address(RVA = "0x18BA030", Offset = "0x18B8A30", VA = "0x1818BA030", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CCF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConvertToDreamDust()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ConvertToDreamDust(ConvertToDreamDust other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD1")]
		[Cpp2IlInjected.Address(RVA = "0x18B9C20", Offset = "0x18B8620", VA = "0x1818B9C20", Slot = "10")]
		[DebuggerNonUserCode]
		public ConvertToDreamDust Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ConvertToDreamDust convertToDreamDust = default(ConvertToDreamDust);
			convertToDreamDust.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (convertToDreamDust._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return convertToDreamDust;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD2")]
		[Cpp2IlInjected.Address(RVA = "0x18B9CA0", Offset = "0x18B86A0", VA = "0x1818B9CA0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002CD3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConvertToDreamDust other)
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

		[Cpp2IlInjected.Token(Token = "0x6002CD4")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD5")]
		[Cpp2IlInjected.Address(RVA = "0x18B9D90", Offset = "0x18B8790", VA = "0x1818B9D90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConvertToDreamDust other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD9")]
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

		[Cpp2IlInjected.Token(Token = "0x6002CDA")]
		[Cpp2IlInjected.Address(RVA = "0x18B9D20", Offset = "0x18B8720", VA = "0x1818B9D20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CDB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002CDC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002CDD")]
		[Cpp2IlInjected.Address(RVA = "0x18B9DF0", Offset = "0x18B87F0", VA = "0x1818B9DF0")]
		static ConvertToDreamDust()
		{
			Func<ConvertToDreamDust> func = default(Func<ConvertToDreamDust>);
			_parser = (MessageParser<ConvertToDreamDust>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
