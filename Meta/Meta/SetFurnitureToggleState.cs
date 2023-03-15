using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public sealed class SetFurnitureToggleState : IMessage<SetFurnitureToggleState>, IMessage, IEquatable<SetFurnitureToggleState>, IDeepCloneable<SetFurnitureToggleState>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200014A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200014B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000486")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000487")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000488")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId
			}

			[Cpp2IlInjected.Token(Token = "0x200014C")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000489")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400048A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400048B")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400048C")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x400048D")]
				public const int GridObjectIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x400048F")]
				public const int ValueFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000490")]
				private static readonly FieldCodec<bool?> _single_value_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000491")]
				private bool? value_;

				[Cpp2IlInjected.Token(Token = "0x1700026B")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000E3C")]
					[Cpp2IlInjected.Address(RVA = "0x2B51480", Offset = "0x2B4FE80", VA = "0x182B51480")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700026C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000E3D")]
					[Cpp2IlInjected.Address(RVA = "0x2B50A40", Offset = "0x2B4F440", VA = "0x182B50A40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700026D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000E3E")]
					[Cpp2IlInjected.Address(RVA = "0x2B51850", Offset = "0x2B50250", VA = "0x182B51850", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700026E")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000E42")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000E43")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700026F")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000E44")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000E45")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000270")]
				[DebuggerNonUserCode]
				public bool? Value
				{
					[Cpp2IlInjected.Token(Token = "0x6000E46")]
					[Cpp2IlInjected.Address(RVA = "0x20B19F0", Offset = "0x20B03F0", VA = "0x1820B19F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000E47")]
					[Cpp2IlInjected.Address(RVA = "0x20B1C30", Offset = "0x20B0630", VA = "0x1820B1C30")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000E3F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E40")]
				[Cpp2IlInjected.Address(RVA = "0x2B504D0", Offset = "0x2B4EED0", VA = "0x182B504D0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E41")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A730", Offset = "0x2B49130", VA = "0x182B4A730", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E48")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AD20", Offset = "0x2B49720", VA = "0x182B4AD20", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E49")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B030", Offset = "0x2B49A30", VA = "0x182B4B030", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E4A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C160", Offset = "0x2B4AB60", VA = "0x182B4C160", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E4B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4E270", Offset = "0x2B4CC70", VA = "0x182B4E270", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E4C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4EE80", Offset = "0x2B4D880", VA = "0x182B4EE80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E4D")]
				[Cpp2IlInjected.Address(RVA = "0x2B49920", Offset = "0x2B48320", VA = "0x182B49920", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E4E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CEB0", Offset = "0x2B4B8B0", VA = "0x182B4CEB0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E4F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C540", Offset = "0x2B4AF40", VA = "0x182B4C540", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E50")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B780", Offset = "0x2B4A180", VA = "0x182B4B780", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E51")]
				[Cpp2IlInjected.Address(RVA = "0x2B4D6F0", Offset = "0x2B4C0F0", VA = "0x182B4D6F0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E52")]
				[Cpp2IlInjected.Address(RVA = "0x2B49DA0", Offset = "0x2B487A0", VA = "0x182B49DA0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200014E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000493")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000494")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000495")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000496")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000497")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000498")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000271")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000E57")]
					[Cpp2IlInjected.Address(RVA = "0x2B5CC20", Offset = "0x2B5B620", VA = "0x182B5CC20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000272")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000E58")]
					[Cpp2IlInjected.Address(RVA = "0x2B5C4E0", Offset = "0x2B5AEE0", VA = "0x182B5C4E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000273")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000E59")]
					[Cpp2IlInjected.Address(RVA = "0x2B5D460", Offset = "0x2B5BE60", VA = "0x182B5D460", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000274")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000E5D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000E5E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000275")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000E5F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000E60")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000276")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000E6C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000E6D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000E5A")]
				[Cpp2IlInjected.Address(RVA = "0x2B5BA20", Offset = "0x2B5A420", VA = "0x182B5BA20")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E5B")]
				[Cpp2IlInjected.Address(RVA = "0x2B5C0B0", Offset = "0x2B5AAB0", VA = "0x182B5C0B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E5C")]
				[Cpp2IlInjected.Address(RVA = "0x2B553A0", Offset = "0x2B53DA0", VA = "0x182B553A0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E61")]
				[Cpp2IlInjected.Address(RVA = "0x2B55C20", Offset = "0x2B54620", VA = "0x182B55C20", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E62")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E63")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E64")]
				[Cpp2IlInjected.Address(RVA = "0x2B5A090", Offset = "0x2B58A90", VA = "0x182B5A090", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E65")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E66")]
				[Cpp2IlInjected.Address(RVA = "0x2B54760", Offset = "0x2B53160", VA = "0x182B54760", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000E67")]
				[Cpp2IlInjected.Address(RVA = "0x2B57940", Offset = "0x2B56340", VA = "0x182B57940", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E68")]
				[Cpp2IlInjected.Address(RVA = "0x2B58C90", Offset = "0x2B57690", VA = "0x182B58C90", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E69")]
				[Cpp2IlInjected.Address(RVA = "0x2B56EF0", Offset = "0x2B558F0", VA = "0x182B56EF0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E6A")]
				[Cpp2IlInjected.Address(RVA = "0x2B597D0", Offset = "0x2B581D0", VA = "0x182B597D0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E6B")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000E6E")]
				[Cpp2IlInjected.Address(RVA = "0x2B524B0", Offset = "0x2B50EB0", VA = "0x182B524B0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private static readonly MessageParser<SetFurnitureToggleState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		[DebuggerNonUserCode]
		public static MessageParser<SetFurnitureToggleState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2A")]
			[Cpp2IlInjected.Address(RVA = "0x1775FC0", Offset = "0x17749C0", VA = "0x181775FC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2B")]
			[Cpp2IlInjected.Address(RVA = "0x1775EF0", Offset = "0x17748F0", VA = "0x181775EF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2C")]
			[Cpp2IlInjected.Address(RVA = "0x1776020", Offset = "0x1774A20", VA = "0x181776020", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SetFurnitureToggleState()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SetFurnitureToggleState(SetFurnitureToggleState other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2F")]
		[Cpp2IlInjected.Address(RVA = "0x1775C10", Offset = "0x1774610", VA = "0x181775C10", Slot = "10")]
		[DebuggerNonUserCode]
		public SetFurnitureToggleState Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SetFurnitureToggleState setFurnitureToggleState = default(SetFurnitureToggleState);
			setFurnitureToggleState.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (setFurnitureToggleState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return setFurnitureToggleState;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E30")]
		[Cpp2IlInjected.Address(RVA = "0x1775C90", Offset = "0x1774690", VA = "0x181775C90", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000E31")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SetFurnitureToggleState other)
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

		[Cpp2IlInjected.Token(Token = "0x6000E32")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E33")]
		[Cpp2IlInjected.Address(RVA = "0x1775D80", Offset = "0x1774780", VA = "0x181775D80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E34")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E35")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E36")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SetFurnitureToggleState other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E37")]
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

		[Cpp2IlInjected.Token(Token = "0x6000E38")]
		[Cpp2IlInjected.Address(RVA = "0x1775D10", Offset = "0x1774710", VA = "0x181775D10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E39")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3B")]
		[Cpp2IlInjected.Address(RVA = "0x1775DE0", Offset = "0x17747E0", VA = "0x181775DE0")]
		static SetFurnitureToggleState()
		{
			Func<SetFurnitureToggleState> func = default(Func<SetFurnitureToggleState>);
			_parser = (MessageParser<SetFurnitureToggleState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
