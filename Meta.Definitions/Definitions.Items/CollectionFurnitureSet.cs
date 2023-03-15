using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005A6")]
	public sealed class CollectionFurnitureSet : IMessage<CollectionFurnitureSet>, IMessage, IEquatable<CollectionFurnitureSet>, IDeepCloneable<CollectionFurnitureSet>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001EF4")]
		private static readonly MessageParser<CollectionFurnitureSet> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001EF5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001EF6")]
		public const int ListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001EF7")]
		private static readonly FieldCodec<int> _repeated_list_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001EF8")]
		private readonly RepeatedField<int> list_;

		[Cpp2IlInjected.Token(Token = "0x1700124F")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionFurnitureSet> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60046A8")]
			[Cpp2IlInjected.Address(RVA = "0x2ECA0E0", Offset = "0x2EC8AE0", VA = "0x182ECA0E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001250")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046A9")]
			[Cpp2IlInjected.Address(RVA = "0x2ECA010", Offset = "0x2EC8A10", VA = "0x182ECA010")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001251")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046AA")]
			[Cpp2IlInjected.Address(RVA = "0x2ECA140", Offset = "0x2EC8B40", VA = "0x182ECA140", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001252")]
		[DebuggerNonUserCode]
		public RepeatedField<int> List
		{
			[Cpp2IlInjected.Token(Token = "0x60046AE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046AB")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9F00", Offset = "0x2EC8900", VA = "0x182EC9F00")]
		[DebuggerNonUserCode]
		public CollectionFurnitureSet()
		{
			list_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60046AC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9F80", Offset = "0x2EC8980", VA = "0x182EC9F80")]
		[DebuggerNonUserCode]
		public CollectionFurnitureSet(CollectionFurnitureSet other)
		{
			RepeatedField<int> repeatedField = (list_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.list_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046AD")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9820", Offset = "0x2EC8220", VA = "0x182EC9820", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionFurnitureSet Clone()
		{
			//Discarded unreachable code: IL_002e
			CollectionFurnitureSet collectionFurnitureSet = new CollectionFurnitureSet();
			RepeatedField<int> repeatedField = (collectionFurnitureSet.list_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)list_).Clone());
			UnknownFieldSet unknownFieldSet = (collectionFurnitureSet._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionFurnitureSet;
		}

		[Cpp2IlInjected.Token(Token = "0x60046AF")]
		[Cpp2IlInjected.Address(RVA = "0x2EC98E0", Offset = "0x2EC82E0", VA = "0x182EC98E0", Slot = "0")]
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
				RepeatedField<int> repeatedField = list_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046B0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC99C0", Offset = "0x2EC83C0", VA = "0x182EC99C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionFurnitureSet other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = list_;
				RepeatedField<int> repeatedField2 = other.list_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046B1")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)list_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60046B2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9CA0", Offset = "0x2EC86A0", VA = "0x182EC9CA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60046B3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9D00", Offset = "0x2EC8700", VA = "0x182EC9D00", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = list_;
			FieldCodec<int> repeated_list_codec = _repeated_list_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_list_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60046B4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9710", Offset = "0x2EC8110", VA = "0x182EC9710", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = list_;
			FieldCodec<int> repeated_list_codec = _repeated_list_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_list_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60046B5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9AD0", Offset = "0x2EC84D0", VA = "0x182EC9AD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionFurnitureSet other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = list_;
				RepeatedField<int> repeatedField2 = other.list_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046B6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9B50", Offset = "0x2EC8550", VA = "0x182EC9B50", Slot = "5")]
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
				RepeatedField<int> repeatedField = list_;
				FieldCodec<int> repeated_list_codec = _repeated_list_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_list_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046B7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9A50", Offset = "0x2EC8450", VA = "0x182EC9A50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = list_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60046B8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9C40", Offset = "0x2EC8640", VA = "0x182EC9C40", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60046B9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC97C0", Offset = "0x2EC81C0", VA = "0x182EC97C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046BA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9DC0", Offset = "0x2EC87C0", VA = "0x182EC9DC0")]
		static CollectionFurnitureSet()
		{
			Func<CollectionFurnitureSet> func = default(Func<CollectionFurnitureSet>);
			_parser = (MessageParser<CollectionFurnitureSet>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<CollectionFurnitureSet>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
