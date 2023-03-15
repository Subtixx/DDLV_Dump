using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000429")]
	public sealed class GeneratorItemIngredient : IMessage<GeneratorItemIngredient>, IMessage, IEquatable<GeneratorItemIngredient>, IDeepCloneable<GeneratorItemIngredient>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200042A")]
		public enum DefinitionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40016AC")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40016AD")]
			Item,
			[Cpp2IlInjected.Token(Token = "0x40016AE")]
			ItemList
		}

		[Cpp2IlInjected.Token(Token = "0x40016A5")]
		private static readonly MessageParser<GeneratorItemIngredient> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40016A6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40016A7")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40016A8")]
		public const int ItemListFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016A9")]
		private object definitions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016AA")]
		private DefinitionsOneofCase definitionsCase_;

		[Cpp2IlInjected.Token(Token = "0x17000CFF")]
		[DebuggerNonUserCode]
		public static MessageParser<GeneratorItemIngredient> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60032DC")]
			[Cpp2IlInjected.Address(RVA = "0x21960F0", Offset = "0x2194AF0", VA = "0x1821960F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D00")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032DD")]
			[Cpp2IlInjected.Address(RVA = "0x2195F50", Offset = "0x2194950", VA = "0x182195F50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D01")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60032DE")]
			[Cpp2IlInjected.Address(RVA = "0x2196150", Offset = "0x2194B50", VA = "0x182196150", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D02")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x60032E2")]
			[Cpp2IlInjected.Address(RVA = "0x2196080", Offset = "0x2194A80", VA = "0x182196080")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (definitionsCase_ == DefinitionsOneofCase.Item)
				{
					object obj = definitions_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60032E3")]
			[Cpp2IlInjected.Address(RVA = "0x2196260", Offset = "0x2194C60", VA = "0x182196260")]
			set
			{
				//IL_0014: Expected I4, but got I8
				definitions_ = typeof(int).TypeHandle;
				definitionsCase_ = DefinitionsOneofCase.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D03")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredientList ItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60032E4")]
			[Cpp2IlInjected.Address(RVA = "0x2196020", Offset = "0x2194A20", VA = "0x182196020")]
			get
			{
				int num = 0;
				if (definitionsCase_ == DefinitionsOneofCase.ItemList)
				{
					object obj = definitions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60032E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				definitions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D04")]
		[DebuggerNonUserCode]
		public DefinitionsOneofCase DefinitionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x60032E6")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return definitionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032DF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60032E0")]
		[Cpp2IlInjected.Address(RVA = "0x2195D80", Offset = "0x2194780", VA = "0x182195D80")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredient(GeneratorItemIngredient other)
		{
			//IL_002c: Expected I4, but got I8
			//IL_004d: Expected I4, but got O
			//IL_006d: Expected I4, but got I8
			DefinitionsOneofCase definitionsOneofCase = other.definitionsCase_;
			if (definitionsOneofCase == DefinitionsOneofCase.Item)
			{
				int item = other.Item;
				definitions_ = typeof(int).TypeHandle;
				definitionsCase_ = DefinitionsOneofCase.Item;
			}
			if (definitionsOneofCase == DefinitionsOneofCase.ItemList)
			{
				DefinitionsOneofCase definitionsOneofCase2 = other.definitionsCase_;
				if (other.definitions_ == null)
				{
					throw new InvalidCastException();
				}
				GeneratorItemIngredientList generatorItemIngredientList = new GeneratorItemIngredientList();
				generatorItemIngredientList.useAsFilter_ = (byte)(int)generatorItemIngredientList != 0;
				RepeatedField<> list_ = default(RepeatedField<>);
				generatorItemIngredientList.list_ = (RepeatedField<GeneratorWeightedItemIngredient>)(object)list_;
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				generatorItemIngredientList._unknownFields = unknownFields;
				definitions_ = generatorItemIngredientList;
				definitionsCase_ = DefinitionsOneofCase.ItemList;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032E1")]
		[Cpp2IlInjected.Address(RVA = "0x21952A0", Offset = "0x2193CA0", VA = "0x1821952A0", Slot = "10")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredient Clone()
		{
			return new GeneratorItemIngredient(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60032E7")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearDefinitions()
		{
			//IL_0010: Expected O, but got I4
			definitions_ = (definitionsCase_ = DefinitionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032E8")]
		[Cpp2IlInjected.Address(RVA = "0x21953B0", Offset = "0x2193DB0", VA = "0x1821953B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = default(int);
				if (Item == num)
				{
					GeneratorItemIngredientList objB = default(GeneratorItemIngredientList);
					bool flag = object.Equals(ItemList, objB);
					if (flag && definitionsCase_ == (flag ? DefinitionsOneofCase.Item : DefinitionsOneofCase.None))
					{
						return object.Equals(_unknownFields, objB);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032E9")]
		[Cpp2IlInjected.Address(RVA = "0x2195300", Offset = "0x2193D00", VA = "0x182195300", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GeneratorItemIngredient other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int item = Item;
				int item2 = other.Item;
				if (item == item2)
				{
					GeneratorItemIngredientList itemList = ItemList;
					GeneratorItemIngredientList itemList2 = other.ItemList;
					if (object.Equals(itemList, itemList2))
					{
						DefinitionsOneofCase definitionsOneofCase = other.definitionsCase_;
						if (definitionsCase_ == definitionsOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032EA")]
		[Cpp2IlInjected.Address(RVA = "0x21955B0", Offset = "0x2193FB0", VA = "0x1821955B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004e
			int num = 0;
			if (definitionsCase_ == DefinitionsOneofCase.Item)
			{
				if (definitionsCase_ != DefinitionsOneofCase.Item)
				{
				}
				object obj = definitions_;
			}
			if (definitionsCase_ == DefinitionsOneofCase.ItemList)
			{
				object obj2 = definitions_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60032EB")]
		[Cpp2IlInjected.Address(RVA = "0x2195B30", Offset = "0x2194530", VA = "0x182195B30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60032EC")]
		[Cpp2IlInjected.Address(RVA = "0x2195B90", Offset = "0x2194590", VA = "0x182195B90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0048
			DefinitionsOneofCase definitionsOneofCase = definitionsCase_;
			if (definitionsOneofCase == DefinitionsOneofCase.Item)
			{
				int item = Item;
				output.WriteInt32(item);
			}
			if (definitionsOneofCase == DefinitionsOneofCase.ItemList && definitionsCase_ == DefinitionsOneofCase.ItemList)
			{
				object obj = definitions_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60032ED")]
		[Cpp2IlInjected.Address(RVA = "0x2195040", Offset = "0x2193A40", VA = "0x182195040", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (definitionsCase_ == DefinitionsOneofCase.Item)
			{
				if (definitionsCase_ == DefinitionsOneofCase.Item)
				{
					object obj = definitions_;
				}
				int num2 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (definitionsCase_ == DefinitionsOneofCase.ItemList)
			{
				if (definitionsCase_ == DefinitionsOneofCase.ItemList)
				{
					object obj2 = definitions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60032EE")]
		[Cpp2IlInjected.Address(RVA = "0x21958F0", Offset = "0x21942F0", VA = "0x1821958F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GeneratorItemIngredient other)
		{
			if (other == null)
			{
				return;
			}
			if (other.definitionsCase_ != DefinitionsOneofCase.Item)
			{
				while ((long)typeof(GeneratorItemIngredientList).TypeHandle != 2)
				{
				}
				GeneratorItemIngredientList generatorItemIngredientList = default(GeneratorItemIngredientList);
				if (generatorItemIngredientList == null)
				{
					GeneratorItemIngredientList generatorItemIngredientList2 = new GeneratorItemIngredientList();
				}
				GeneratorItemIngredientList itemList = other.ItemList;
				GeneratorItemIngredientList generatorItemIngredientList3 = default(GeneratorItemIngredientList);
				generatorItemIngredientList3.MergeFrom(itemList);
				throw new NullReferenceException();
			}
			int num = (Item = other.Item);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60032EF")]
		[Cpp2IlInjected.Address(RVA = "0x2195790", Offset = "0x2194190", VA = "0x182195790", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0068: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num3 = (Item = input.ReadInt32());
			}
			if (num == 18)
			{
				GeneratorItemIngredientList builder = new GeneratorItemIngredientList();
				if (definitionsCase_ == DefinitionsOneofCase.ItemList)
				{
					if (definitionsCase_ != DefinitionsOneofCase.ItemList)
					{
					}
					object obj = definitions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				definitions_ = builder;
				definitionsCase_ = (DefinitionsOneofCase)typeof(GeneratorItemIngredientList).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60032F0")]
		[Cpp2IlInjected.Address(RVA = "0x21954A0", Offset = "0x2193EA0", VA = "0x1821954A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int item = Item;
			}
			if (fieldNumber == 2)
			{
				while (definitionsCase_ != DefinitionsOneofCase.ItemList)
				{
				}
				object obj = definitions_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_0037;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
			IL_0037:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032F1")]
		[Cpp2IlInjected.Address(RVA = "0x2195A00", Offset = "0x2194400", VA = "0x182195A00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0018: Expected I4, but got I8
			//IL_0037: Expected I4, but got O
			if (fieldNumber == 1)
			{
				definitions_ = typeof(int).TypeHandle;
				definitionsCase_ = DefinitionsOneofCase.Item;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				definitions_ = value;
				definitionsCase_ = (DefinitionsOneofCase)typeof(int).TypeHandle;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032F2")]
		[Cpp2IlInjected.Address(RVA = "0x21951A0", Offset = "0x2193BA0", VA = "0x1821951A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				int num = default(int);
				definitions_ = num;
				definitionsCase_ = DefinitionsOneofCase.Item;
				break;
			}
			case 2:
				definitionsCase_ = DefinitionsOneofCase.None;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032F3")]
		[Cpp2IlInjected.Address(RVA = "0x21956E0", Offset = "0x21940E0", VA = "0x1821956E0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Definitions"))
			{
				DefinitionsOneofCase definitionsOneofCase = definitionsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032F4")]
		[Cpp2IlInjected.Address(RVA = "0x2195230", Offset = "0x2193C30", VA = "0x182195230", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Definitions"))
			{
				definitions_ = (definitionsCase_ = DefinitionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032F5")]
		[Cpp2IlInjected.Address(RVA = "0x2195C70", Offset = "0x2194670", VA = "0x182195C70")]
		static GeneratorItemIngredient()
		{
			Func<GeneratorItemIngredient> func = default(Func<GeneratorItemIngredient>);
			_parser = (MessageParser<GeneratorItemIngredient>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
