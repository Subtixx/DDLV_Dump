using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005AB")]
	public sealed class CollectionClothingSet : IMessage<CollectionClothingSet>, IMessage, IEquatable<CollectionClothingSet>, IDeepCloneable<CollectionClothingSet>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F05")]
		private static readonly MessageParser<CollectionClothingSet> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F06")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F07")]
		public const int ListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F08")]
		private static readonly FieldCodec<int> _repeated_list_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F09")]
		private readonly RepeatedField<int> list_;

		[Cpp2IlInjected.Token(Token = "0x17001259")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionClothingSet> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60046DB")]
			[Cpp2IlInjected.Address(RVA = "0x2EC66C0", Offset = "0x2EC50C0", VA = "0x182EC66C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700125A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046DC")]
			[Cpp2IlInjected.Address(RVA = "0x2EC65F0", Offset = "0x2EC4FF0", VA = "0x182EC65F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700125B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046DD")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6720", Offset = "0x2EC5120", VA = "0x182EC6720", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700125C")]
		[DebuggerNonUserCode]
		public RepeatedField<int> List
		{
			[Cpp2IlInjected.Token(Token = "0x60046E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046DE")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6570", Offset = "0x2EC4F70", VA = "0x182EC6570")]
		[DebuggerNonUserCode]
		public CollectionClothingSet()
		{
			list_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60046DF")]
		[Cpp2IlInjected.Address(RVA = "0x2EC64E0", Offset = "0x2EC4EE0", VA = "0x182EC64E0")]
		[DebuggerNonUserCode]
		public CollectionClothingSet(CollectionClothingSet other)
		{
			RepeatedField<int> repeatedField = (list_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.list_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046E0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5E00", Offset = "0x2EC4800", VA = "0x182EC5E00", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionClothingSet Clone()
		{
			//Discarded unreachable code: IL_002e
			CollectionClothingSet collectionClothingSet = new CollectionClothingSet();
			RepeatedField<int> repeatedField = (collectionClothingSet.list_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)list_).Clone());
			UnknownFieldSet unknownFieldSet = (collectionClothingSet._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionClothingSet;
		}

		[Cpp2IlInjected.Token(Token = "0x60046E2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5F50", Offset = "0x2EC4950", VA = "0x182EC5F50", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60046E3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5EC0", Offset = "0x2EC48C0", VA = "0x182EC5EC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionClothingSet other)
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

		[Cpp2IlInjected.Token(Token = "0x60046E4")]
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

		[Cpp2IlInjected.Token(Token = "0x60046E5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6280", Offset = "0x2EC4C80", VA = "0x182EC6280", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60046E6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC62E0", Offset = "0x2EC4CE0", VA = "0x182EC62E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = list_;
			FieldCodec<int> repeated_list_codec = _repeated_list_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_list_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60046E7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5CF0", Offset = "0x2EC46F0", VA = "0x182EC5CF0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60046E8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC61A0", Offset = "0x2EC4BA0", VA = "0x182EC61A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionClothingSet other)
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

		[Cpp2IlInjected.Token(Token = "0x60046E9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC60B0", Offset = "0x2EC4AB0", VA = "0x182EC60B0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60046EA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6030", Offset = "0x2EC4A30", VA = "0x182EC6030", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60046EB")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6220", Offset = "0x2EC4C20", VA = "0x182EC6220", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60046EC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5DA0", Offset = "0x2EC47A0", VA = "0x182EC5DA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046ED")]
		[Cpp2IlInjected.Address(RVA = "0x2EC63A0", Offset = "0x2EC4DA0", VA = "0x182EC63A0")]
		static CollectionClothingSet()
		{
			Func<CollectionClothingSet> func = default(Func<CollectionClothingSet>);
			_parser = (MessageParser<CollectionClothingSet>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<CollectionClothingSet>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
