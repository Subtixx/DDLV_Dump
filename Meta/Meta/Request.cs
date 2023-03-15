using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200081E")]
	public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002063")]
		private static readonly MessageParser<Request> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002064")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002065")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002066")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x4002067")]
		public const int LastCompletedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002068")]
		private Timestamp lastCompleted_;

		[Cpp2IlInjected.Token(Token = "0x4002069")]
		public const int StartedFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400206A")]
		private bool started_;

		[Cpp2IlInjected.Token(Token = "0x17000B1C")]
		[DebuggerNonUserCode]
		public static MessageParser<Request> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60043C9")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB30", Offset = "0x5C9530", VA = "0x1805CAB30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60043CA")]
			[Cpp2IlInjected.Address(RVA = "0x5CAA60", Offset = "0x5C9460", VA = "0x1805CAA60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60043CB")]
			[Cpp2IlInjected.Address(RVA = "0x5CABA0", Offset = "0x5C95A0", VA = "0x1805CABA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1F")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60043CF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043D0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B20")]
		[DebuggerNonUserCode]
		public Timestamp LastCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60043D1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastCompleted_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastCompleted_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B21")]
		[DebuggerNonUserCode]
		public bool Started
		{
			[Cpp2IlInjected.Token(Token = "0x60043D3")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return started_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043D4")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				started_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043CC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Request()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60043CD")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9E0", Offset = "0x5C93E0", VA = "0x1805CA9E0")]
		[DebuggerNonUserCode]
		public Request(Request other)
		{
			//IL_002f: Expected O, but got I4
			int num = (id_ = other.id_);
			Timestamp timestamp = other.lastCompleted_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num2 = 0;
			lastCompleted_ = (Timestamp)num2;
			bool flag = (started_ = other.started_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60043CE")]
		[Cpp2IlInjected.Address(RVA = "0x5CA100", Offset = "0x5C8B00", VA = "0x1805CA100", Slot = "10")]
		[DebuggerNonUserCode]
		public Request Clone()
		{
			//Discarded unreachable code: IL_0058
			//IL_0031: Expected O, but got I4
			Request request = new Request();
			int num = (request.id_ = id_);
			Timestamp timestamp = lastCompleted_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num2 = 0;
			request.lastCompleted_ = (Timestamp)num2;
			bool flag = (request.started_ = started_);
			UnknownFieldSet unknownFieldSet = (request._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return request;
		}

		[Cpp2IlInjected.Token(Token = "0x60043D5")]
		[Cpp2IlInjected.Address(RVA = "0x5CA230", Offset = "0x5C8C30", VA = "0x1805CA230", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)id_ == (IntPtr)typeof(Request).TypeHandle)
				{
					bool flag = object.Equals(lastCompleted_, other);
					if (flag && started_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60043D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CA1B0", Offset = "0x5C8BB0", VA = "0x1805CA1B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Request other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.id_;
				if (id_ == num)
				{
					Timestamp objB = other.lastCompleted_;
					if (object.Equals(lastCompleted_, objB))
					{
						bool flag = other.started_;
						if (started_ == flag)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60043D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CA3F0", Offset = "0x5C8DF0", VA = "0x1805CA3F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (id_ != 0)
				{
				}
				Timestamp timestamp = lastCompleted_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				if (started_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60043D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CA7C0", Offset = "0x5C91C0", VA = "0x1805CA7C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60043D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CA820", Offset = "0x5C9220", VA = "0x1805CA820", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005a
			if (id_ != 0)
			{
				int value = id_;
				output.WriteInt32(value);
			}
			if ((long)lastCompleted_ != 0)
			{
				Timestamp value2 = lastCompleted_;
				output.WriteMessage(value2);
			}
			if (started_)
			{
				bool value3 = started_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60043DA")]
		[Cpp2IlInjected.Address(RVA = "0x5C9FF0", Offset = "0x5C89F0", VA = "0x1805C9FF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = id_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				Timestamp timestamp = lastCompleted_;
				if (timestamp != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(timestamp);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60043DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5B0", Offset = "0x5C8FB0", VA = "0x1805CA5B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Request other)
		{
			//Discarded unreachable code: IL_0084
			if (other == null)
			{
				return;
			}
			int num = other.id_;
			if (num != 0)
			{
				id_ = num;
			}
			if ((long)other.lastCompleted_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastCompleted_ == null)
				{
					Timestamp timestamp = (lastCompleted_ = new Timestamp());
					timestamp2 = lastCompleted_;
				}
				Timestamp other2 = other.lastCompleted_;
				timestamp2.MergeFrom(other2);
			}
			bool flag = other.started_;
			if (flag)
			{
				started_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60043DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CA4A0", Offset = "0x5C8EA0", VA = "0x1805CA4A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0077
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (id_ = input.ReadInt32());
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (lastCompleted_ == null)
				{
					timestamp = (lastCompleted_ = new Timestamp());
					builder = lastCompleted_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 24)
			{
				bool flag = (started_ = input.ReadBool());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60043DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2F0", Offset = "0x5C8CF0", VA = "0x1805CA2F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					bool flag = started_;
				}
				Timestamp timestamp = lastCompleted_;
			}
			int num2 = id_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60043DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CA690", Offset = "0x5C9090", VA = "0x1805CA690", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002f
			//IL_0017: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					started_ = (byte)(int)obj != 0;
					return;
				}
				default:
					return;
				case 0:
					break;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				lastCompleted_ = (Timestamp)value;
			}
			object obj2 = default(object);
			id_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x60043DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0D0", Offset = "0x5C8AD0", VA = "0x1805CA0D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				started_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8D0", Offset = "0x5C92D0", VA = "0x1805CA8D0")]
		static Request()
		{
			Func<Request> func = default(Func<Request>);
			_parser = (MessageParser<Request>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
