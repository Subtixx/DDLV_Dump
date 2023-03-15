using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000989")]
	public sealed class PendingRequests : IMessage<PendingRequests>, IMessage, IEquatable<PendingRequests>, IDeepCloneable<PendingRequests>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027AB")]
		private static readonly MessageParser<PendingRequests> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027AC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027AD")]
		public const int RequestsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40027AE")]
		private static readonly FieldCodec<WrappedRequest> _repeated_requests_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027AF")]
		private readonly RepeatedField<WrappedRequest> requests_ = (RepeatedField<WrappedRequest>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000E81")]
		[DebuggerNonUserCode]
		public static MessageParser<PendingRequests> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60053CC")]
			[Cpp2IlInjected.Address(RVA = "0x7B13F0", Offset = "0x7AFDF0", VA = "0x1807B13F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E82")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60053CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B1320", Offset = "0x7AFD20", VA = "0x1807B1320")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E83")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60053CE")]
			[Cpp2IlInjected.Address(RVA = "0x7B1450", Offset = "0x7AFE50", VA = "0x1807B1450", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E84")]
		[DebuggerNonUserCode]
		public RepeatedField<WrappedRequest> Requests
		{
			[Cpp2IlInjected.Token(Token = "0x60053D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return requests_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B12A0", Offset = "0x7AFCA0", VA = "0x1807B12A0")]
		[DebuggerNonUserCode]
		public PendingRequests()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60053D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B11A0", Offset = "0x7AFBA0", VA = "0x1807B11A0")]
		[DebuggerNonUserCode]
		public PendingRequests(PendingRequests other)
		{
			RepeatedField<WrappedRequest> repeatedField = (requests_ = (RepeatedField<WrappedRequest>)(object)((RepeatedField<T>)(object)other.requests_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60053D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B09C0", Offset = "0x7AF3C0", VA = "0x1807B09C0", Slot = "10")]
		[DebuggerNonUserCode]
		public PendingRequests Clone()
		{
			//Discarded unreachable code: IL_003b
			PendingRequests pendingRequests = new PendingRequests();
			RepeatedField<WrappedRequest> repeatedField = (pendingRequests.requests_ = (RepeatedField<WrappedRequest>)(object)new RepeatedField<T>());
			RepeatedField<WrappedRequest> repeatedField2 = (pendingRequests.requests_ = (RepeatedField<WrappedRequest>)(object)((RepeatedField<T>)(object)requests_).Clone());
			UnknownFieldSet unknownFieldSet = (pendingRequests._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pendingRequests;
		}

		[Cpp2IlInjected.Token(Token = "0x60053D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B80", Offset = "0x7AF580", VA = "0x1807B0B80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<WrappedRequest> repeatedField = requests_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60053D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0AF0", Offset = "0x7AF4F0", VA = "0x1807B0AF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PendingRequests other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<WrappedRequest> repeatedField = requests_;
				RepeatedField<WrappedRequest> repeatedField2 = other.requests_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60053D5")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)requests_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60053D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EB0", Offset = "0x7AF8B0", VA = "0x1807B0EB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60053D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F10", Offset = "0x7AF910", VA = "0x1807B0F10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<WrappedRequest> repeatedField = requests_;
			FieldCodec<WrappedRequest> repeated_requests_codec = _repeated_requests_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_requests_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60053D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B08B0", Offset = "0x7AF2B0", VA = "0x1807B08B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<WrappedRequest> repeatedField = requests_;
			FieldCodec<WrappedRequest> repeated_requests_codec = _repeated_requests_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_requests_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60053D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0DD0", Offset = "0x7AF7D0", VA = "0x1807B0DD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PendingRequests other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<WrappedRequest> repeatedField = requests_;
				RepeatedField<WrappedRequest> repeatedField2 = other.requests_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0CE0", Offset = "0x7AF6E0", VA = "0x1807B0CE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<WrappedRequest> repeatedField = requests_;
					FieldCodec<WrappedRequest> repeated_requests_codec = _repeated_requests_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_requests_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C60", Offset = "0x7AF660", VA = "0x1807B0C60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<WrappedRequest> repeatedField = requests_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E50", Offset = "0x7AF850", VA = "0x1807B0E50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0960", Offset = "0x7AF360", VA = "0x1807B0960", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<WrappedRequest> repeatedField = requests_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B0FD0", Offset = "0x7AF9D0", VA = "0x1807B0FD0")]
		static PendingRequests()
		{
			Func<PendingRequests> func = default(Func<PendingRequests>);
			_parser = (MessageParser<PendingRequests>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<WrappedRequest> parser = WrappedRequest._parser;
			uint num = default(uint);
			_parser = (MessageParser<PendingRequests>)(object)FieldCodec.ForMessage<WrappedRequest>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
