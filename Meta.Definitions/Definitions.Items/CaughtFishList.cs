using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200042C")]
	public sealed class CaughtFishList : IMessage<CaughtFishList>, IMessage, IEquatable<CaughtFishList>, IDeepCloneable<CaughtFishList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40016B0")]
		private static readonly MessageParser<CaughtFishList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40016B1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40016B2")]
		public const int CoughtFishListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40016B3")]
		private static readonly FieldCodec<int> _repeated_coughtFishList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016B4")]
		private readonly RepeatedField<int> coughtFishList_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000D05")]
		[DebuggerNonUserCode]
		public static MessageParser<CaughtFishList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60032F9")]
			[Cpp2IlInjected.Address(RVA = "0x28973D0", Offset = "0x2895DD0", VA = "0x1828973D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D06")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032FA")]
			[Cpp2IlInjected.Address(RVA = "0x2897300", Offset = "0x2895D00", VA = "0x182897300")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D07")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032FB")]
			[Cpp2IlInjected.Address(RVA = "0x2897430", Offset = "0x2895E30", VA = "0x182897430", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D08")]
		[DebuggerNonUserCode]
		public RepeatedField<int> CoughtFishList
		{
			[Cpp2IlInjected.Token(Token = "0x60032FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return coughtFishList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032FC")]
		[Cpp2IlInjected.Address(RVA = "0x2897280", Offset = "0x2895C80", VA = "0x182897280")]
		[DebuggerNonUserCode]
		public CaughtFishList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60032FD")]
		[Cpp2IlInjected.Address(RVA = "0x2897180", Offset = "0x2895B80", VA = "0x182897180")]
		[DebuggerNonUserCode]
		public CaughtFishList(CaughtFishList other)
		{
			RepeatedField<int> repeatedField = (coughtFishList_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.coughtFishList_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032FE")]
		[Cpp2IlInjected.Address(RVA = "0x2896A30", Offset = "0x2895430", VA = "0x182896A30", Slot = "10")]
		[DebuggerNonUserCode]
		public CaughtFishList Clone()
		{
			//Discarded unreachable code: IL_003b
			CaughtFishList caughtFishList = new CaughtFishList();
			RepeatedField<int> repeatedField = (caughtFishList.coughtFishList_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (caughtFishList.coughtFishList_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)coughtFishList_).Clone());
			UnknownFieldSet unknownFieldSet = (caughtFishList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return caughtFishList;
		}

		[Cpp2IlInjected.Token(Token = "0x6003300")]
		[Cpp2IlInjected.Address(RVA = "0x2896BF0", Offset = "0x28955F0", VA = "0x182896BF0", Slot = "0")]
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
				RepeatedField<int> repeatedField = coughtFishList_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003301")]
		[Cpp2IlInjected.Address(RVA = "0x2896B60", Offset = "0x2895560", VA = "0x182896B60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CaughtFishList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = coughtFishList_;
				RepeatedField<int> repeatedField2 = other.coughtFishList_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003302")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)coughtFishList_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6003303")]
		[Cpp2IlInjected.Address(RVA = "0x2896F20", Offset = "0x2895920", VA = "0x182896F20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003304")]
		[Cpp2IlInjected.Address(RVA = "0x2896F80", Offset = "0x2895980", VA = "0x182896F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = coughtFishList_;
			FieldCodec<int> repeated_coughtFishList_codec = _repeated_coughtFishList_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_coughtFishList_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003305")]
		[Cpp2IlInjected.Address(RVA = "0x2896920", Offset = "0x2895320", VA = "0x182896920", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = coughtFishList_;
			FieldCodec<int> repeated_coughtFishList_codec = _repeated_coughtFishList_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_coughtFishList_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003306")]
		[Cpp2IlInjected.Address(RVA = "0x2896D50", Offset = "0x2895750", VA = "0x182896D50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CaughtFishList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = coughtFishList_;
				RepeatedField<int> repeatedField2 = other.coughtFishList_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003307")]
		[Cpp2IlInjected.Address(RVA = "0x2896DD0", Offset = "0x28957D0", VA = "0x182896DD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = coughtFishList_;
				FieldCodec<int> repeated_coughtFishList_codec = _repeated_coughtFishList_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_coughtFishList_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003308")]
		[Cpp2IlInjected.Address(RVA = "0x2896CD0", Offset = "0x28956D0", VA = "0x182896CD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = coughtFishList_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003309")]
		[Cpp2IlInjected.Address(RVA = "0x2896EC0", Offset = "0x28958C0", VA = "0x182896EC0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600330A")]
		[Cpp2IlInjected.Address(RVA = "0x28969D0", Offset = "0x28953D0", VA = "0x1828969D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = coughtFishList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600330B")]
		[Cpp2IlInjected.Address(RVA = "0x2897040", Offset = "0x2895A40", VA = "0x182897040")]
		static CaughtFishList()
		{
			Func<CaughtFishList> func = default(Func<CaughtFishList>);
			_parser = (MessageParser<CaughtFishList>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<CaughtFishList>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
