using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000420")]
	public sealed class GeneratorItemList : IMessage<GeneratorItemList>, IMessage, IEquatable<GeneratorItemList>, IDeepCloneable<GeneratorItemList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001683")]
		private static readonly MessageParser<GeneratorItemList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001684")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001685")]
		public const int UseAsFilterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001686")]
		private bool useAsFilter_;

		[Cpp2IlInjected.Token(Token = "0x4001687")]
		public const int ListFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001688")]
		private static readonly FieldCodec<GeneratorWeightedItem> _repeated_list_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001689")]
		private readonly RepeatedField<GeneratorWeightedItem> list_;

		[Cpp2IlInjected.Token(Token = "0x17000CEA")]
		[DebuggerNonUserCode]
		public static MessageParser<GeneratorItemList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003275")]
			[Cpp2IlInjected.Address(RVA = "0x2196E70", Offset = "0x2195870", VA = "0x182196E70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CEB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003276")]
			[Cpp2IlInjected.Address(RVA = "0x2196DA0", Offset = "0x21957A0", VA = "0x182196DA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CEC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003277")]
			[Cpp2IlInjected.Address(RVA = "0x2196ED0", Offset = "0x21958D0", VA = "0x182196ED0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CED")]
		[DebuggerNonUserCode]
		public bool UseAsFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600327B")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useAsFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x600327C")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useAsFilter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CEE")]
		[DebuggerNonUserCode]
		public RepeatedField<GeneratorWeightedItem> List
		{
			[Cpp2IlInjected.Token(Token = "0x600327D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003278")]
		[Cpp2IlInjected.Address(RVA = "0x2196D20", Offset = "0x2195720", VA = "0x182196D20")]
		[DebuggerNonUserCode]
		public GeneratorItemList()
		{
			list_ = (RepeatedField<GeneratorWeightedItem>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6003279")]
		[Cpp2IlInjected.Address(RVA = "0x2196C90", Offset = "0x2195690", VA = "0x182196C90")]
		[DebuggerNonUserCode]
		public GeneratorItemList(GeneratorItemList other)
		{
			bool flag = (useAsFilter_ = other.useAsFilter_);
			RepeatedField<GeneratorWeightedItem> repeatedField = (list_ = (RepeatedField<GeneratorWeightedItem>)(object)((RepeatedField<T>)(object)other.list_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600327A")]
		[Cpp2IlInjected.Address(RVA = "0x2196400", Offset = "0x2194E00", VA = "0x182196400", Slot = "10")]
		[DebuggerNonUserCode]
		public GeneratorItemList Clone()
		{
			//Discarded unreachable code: IL_003c
			GeneratorItemList generatorItemList = new GeneratorItemList();
			bool flag = (generatorItemList.useAsFilter_ = useAsFilter_);
			RepeatedField<GeneratorWeightedItem> repeatedField = (generatorItemList.list_ = (RepeatedField<GeneratorWeightedItem>)(object)((RepeatedField<T>)(object)list_).Clone());
			UnknownFieldSet unknownFieldSet = (generatorItemList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return generatorItemList;
		}

		[Cpp2IlInjected.Token(Token = "0x600327E")]
		[Cpp2IlInjected.Address(RVA = "0x21964C0", Offset = "0x2194EC0", VA = "0x1821964C0", Slot = "0")]
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
				if ((IntPtr)(useAsFilter_ ? 1 : 0) == (IntPtr)typeof(GeneratorItemList).TypeHandle)
				{
					RepeatedField<GeneratorWeightedItem> repeatedField = list_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600327F")]
		[Cpp2IlInjected.Address(RVA = "0x21965A0", Offset = "0x2194FA0", VA = "0x1821965A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GeneratorItemList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useAsFilter_;
				if (useAsFilter_ == flag)
				{
					RepeatedField<GeneratorWeightedItem> repeatedField = list_;
					RepeatedField<GeneratorWeightedItem> repeatedField2 = other.list_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003280")]
		[Cpp2IlInjected.Address(RVA = "0x78BEE0", Offset = "0x78A8E0", VA = "0x18078BEE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002a
			if (useAsFilter_)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)list_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003281")]
		[Cpp2IlInjected.Address(RVA = "0x2196970", Offset = "0x2195370", VA = "0x182196970", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003282")]
		[Cpp2IlInjected.Address(RVA = "0x21969D0", Offset = "0x21953D0", VA = "0x1821969D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (useAsFilter_)
			{
				bool value = useAsFilter_;
				output.WriteBool(value);
			}
			RepeatedField<GeneratorWeightedItem> repeatedField = list_;
			FieldCodec<GeneratorWeightedItem> repeated_list_codec = _repeated_list_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_list_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003283")]
		[Cpp2IlInjected.Address(RVA = "0x21962D0", Offset = "0x2194CD0", VA = "0x1821962D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			RepeatedField<GeneratorWeightedItem> repeatedField = list_;
			FieldCodec<GeneratorWeightedItem> repeated_list_codec = _repeated_list_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_list_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<GeneratorWeightedItem>)(repeatedField + num2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003284")]
		[Cpp2IlInjected.Address(RVA = "0x2196710", Offset = "0x2195110", VA = "0x182196710", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GeneratorItemList other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				bool flag = other.useAsFilter_;
				if (flag)
				{
					useAsFilter_ = flag;
				}
				RepeatedField<GeneratorWeightedItem> repeatedField = list_;
				RepeatedField<GeneratorWeightedItem> repeatedField2 = other.list_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003285")]
		[Cpp2IlInjected.Address(RVA = "0x21967A0", Offset = "0x21951A0", VA = "0x1821967A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (useAsFilter_ = input.ReadBool());
				}
				if (num == 18)
				{
					RepeatedField<GeneratorWeightedItem> repeatedField = list_;
					FieldCodec<GeneratorWeightedItem> repeated_list_codec = _repeated_list_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_list_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003286")]
		[Cpp2IlInjected.Address(RVA = "0x2196640", Offset = "0x2195040", VA = "0x182196640", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = useAsFilter_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<GeneratorWeightedItem> repeatedField = list_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003287")]
		[Cpp2IlInjected.Address(RVA = "0x21968A0", Offset = "0x21952A0", VA = "0x1821968A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				useAsFilter_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003288")]
		[Cpp2IlInjected.Address(RVA = "0x2196390", Offset = "0x2194D90", VA = "0x182196390", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				useAsFilter_ = false;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003289")]
		[Cpp2IlInjected.Address(RVA = "0x2196AC0", Offset = "0x21954C0", VA = "0x182196AC0")]
		static GeneratorItemList()
		{
			Func<GeneratorItemList> func = default(Func<GeneratorItemList>);
			_parser = (MessageParser<GeneratorItemList>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<GeneratorWeightedItem> parser = GeneratorWeightedItem._parser;
			uint num = default(uint);
			_parser = (MessageParser<GeneratorItemList>)(object)FieldCodec.ForMessage<GeneratorWeightedItem>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
