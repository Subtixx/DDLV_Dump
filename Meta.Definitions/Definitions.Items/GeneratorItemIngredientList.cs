using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000427")]
	public sealed class GeneratorItemIngredientList : IMessage<GeneratorItemIngredientList>, IMessage, IEquatable<GeneratorItemIngredientList>, IDeepCloneable<GeneratorItemIngredientList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400169D")]
		private static readonly MessageParser<GeneratorItemIngredientList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400169E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400169F")]
		public const int UseAsFilterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016A0")]
		private bool useAsFilter_;

		[Cpp2IlInjected.Token(Token = "0x40016A1")]
		public const int ListFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40016A2")]
		private static readonly FieldCodec<GeneratorWeightedItemIngredient> _repeated_list_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016A3")]
		private readonly RepeatedField<GeneratorWeightedItemIngredient> list_;

		[Cpp2IlInjected.Token(Token = "0x17000CFA")]
		[DebuggerNonUserCode]
		public static MessageParser<GeneratorItemIngredientList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60032C4")]
			[Cpp2IlInjected.Address(RVA = "0x2194ED0", Offset = "0x21938D0", VA = "0x182194ED0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032C5")]
			[Cpp2IlInjected.Address(RVA = "0x2194E00", Offset = "0x2193800", VA = "0x182194E00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032C6")]
			[Cpp2IlInjected.Address(RVA = "0x2194F30", Offset = "0x2193930", VA = "0x182194F30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFD")]
		[DebuggerNonUserCode]
		public bool UseAsFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60032CA")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useAsFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x60032CB")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useAsFilter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFE")]
		[DebuggerNonUserCode]
		public RepeatedField<GeneratorWeightedItemIngredient> List
		{
			[Cpp2IlInjected.Token(Token = "0x60032CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032C7")]
		[Cpp2IlInjected.Address(RVA = "0x2194D80", Offset = "0x2193780", VA = "0x182194D80")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredientList()
		{
			list_ = (RepeatedField<GeneratorWeightedItemIngredient>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60032C8")]
		[Cpp2IlInjected.Address(RVA = "0x2194CF0", Offset = "0x21936F0", VA = "0x182194CF0")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredientList(GeneratorItemIngredientList other)
		{
			bool flag = (useAsFilter_ = other.useAsFilter_);
			RepeatedField<GeneratorWeightedItemIngredient> repeatedField = (list_ = (RepeatedField<GeneratorWeightedItemIngredient>)(object)((RepeatedField<T>)(object)other.list_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032C9")]
		[Cpp2IlInjected.Address(RVA = "0x2194460", Offset = "0x2192E60", VA = "0x182194460", Slot = "10")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredientList Clone()
		{
			//Discarded unreachable code: IL_003c
			GeneratorItemIngredientList generatorItemIngredientList = new GeneratorItemIngredientList();
			bool flag = (generatorItemIngredientList.useAsFilter_ = useAsFilter_);
			RepeatedField<GeneratorWeightedItemIngredient> repeatedField = (generatorItemIngredientList.list_ = (RepeatedField<GeneratorWeightedItemIngredient>)(object)((RepeatedField<T>)(object)list_).Clone());
			UnknownFieldSet unknownFieldSet = (generatorItemIngredientList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return generatorItemIngredientList;
		}

		[Cpp2IlInjected.Token(Token = "0x60032CD")]
		[Cpp2IlInjected.Address(RVA = "0x21945C0", Offset = "0x2192FC0", VA = "0x1821945C0", Slot = "0")]
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
				if ((IntPtr)(useAsFilter_ ? 1 : 0) == (IntPtr)typeof(GeneratorItemIngredientList).TypeHandle)
				{
					RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
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

		[Cpp2IlInjected.Token(Token = "0x60032CE")]
		[Cpp2IlInjected.Address(RVA = "0x2194520", Offset = "0x2192F20", VA = "0x182194520", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GeneratorItemIngredientList other)
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
					RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
					RepeatedField<GeneratorWeightedItemIngredient> repeatedField2 = other.list_;
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

		[Cpp2IlInjected.Token(Token = "0x60032CF")]
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

		[Cpp2IlInjected.Token(Token = "0x60032D0")]
		[Cpp2IlInjected.Address(RVA = "0x21949D0", Offset = "0x21933D0", VA = "0x1821949D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60032D1")]
		[Cpp2IlInjected.Address(RVA = "0x2194A30", Offset = "0x2193430", VA = "0x182194A30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (useAsFilter_)
			{
				bool value = useAsFilter_;
				output.WriteBool(value);
			}
			RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
			FieldCodec<GeneratorWeightedItemIngredient> repeated_list_codec = _repeated_list_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_list_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60032D2")]
		[Cpp2IlInjected.Address(RVA = "0x2194330", Offset = "0x2192D30", VA = "0x182194330", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
			FieldCodec<GeneratorWeightedItemIngredient> repeated_list_codec = _repeated_list_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_list_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<GeneratorWeightedItemIngredient>)(repeatedField + num2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032D3")]
		[Cpp2IlInjected.Address(RVA = "0x2194870", Offset = "0x2193270", VA = "0x182194870", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GeneratorItemIngredientList other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				bool flag = other.useAsFilter_;
				if (flag)
				{
					useAsFilter_ = flag;
				}
				RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
				RepeatedField<GeneratorWeightedItemIngredient> repeatedField2 = other.list_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032D4")]
		[Cpp2IlInjected.Address(RVA = "0x2194770", Offset = "0x2193170", VA = "0x182194770", Slot = "5")]
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
					RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
					FieldCodec<GeneratorWeightedItemIngredient> repeated_list_codec = _repeated_list_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_list_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032D5")]
		[Cpp2IlInjected.Address(RVA = "0x21946A0", Offset = "0x21930A0", VA = "0x1821946A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = useAsFilter_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032D6")]
		[Cpp2IlInjected.Address(RVA = "0x2194900", Offset = "0x2193300", VA = "0x182194900", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60032D7")]
		[Cpp2IlInjected.Address(RVA = "0x21943F0", Offset = "0x2192DF0", VA = "0x1821943F0", Slot = "13")]
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
			RepeatedField<GeneratorWeightedItemIngredient> repeatedField = list_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032D8")]
		[Cpp2IlInjected.Address(RVA = "0x2194B20", Offset = "0x2193520", VA = "0x182194B20")]
		static GeneratorItemIngredientList()
		{
			Func<GeneratorItemIngredientList> func = default(Func<GeneratorItemIngredientList>);
			_parser = (MessageParser<GeneratorItemIngredientList>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<GeneratorWeightedItemIngredient> parser = GeneratorWeightedItemIngredient._parser;
			uint num = default(uint);
			_parser = (MessageParser<GeneratorItemIngredientList>)(object)FieldCodec.ForMessage<GeneratorWeightedItemIngredient>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
