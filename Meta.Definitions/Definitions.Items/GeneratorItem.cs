using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000422")]
	public sealed class GeneratorItem : IMessage<GeneratorItem>, IMessage, IEquatable<GeneratorItem>, IDeepCloneable<GeneratorItem>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000423")]
		public enum DefinitionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001692")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001693")]
			Item,
			[Cpp2IlInjected.Token(Token = "0x4001694")]
			ItemList
		}

		[Cpp2IlInjected.Token(Token = "0x400168B")]
		private static readonly MessageParser<GeneratorItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400168C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400168D")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400168E")]
		public const int ItemListFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400168F")]
		private object definitions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001690")]
		private DefinitionsOneofCase definitionsCase_;

		[Cpp2IlInjected.Token(Token = "0x17000CEF")]
		[DebuggerNonUserCode]
		public static MessageParser<GeneratorItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600328D")]
			[Cpp2IlInjected.Address(RVA = "0x2198090", Offset = "0x2196A90", VA = "0x182198090")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600328E")]
			[Cpp2IlInjected.Address(RVA = "0x2197EF0", Offset = "0x21968F0", VA = "0x182197EF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600328F")]
			[Cpp2IlInjected.Address(RVA = "0x21980F0", Offset = "0x2196AF0", VA = "0x1821980F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF2")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003293")]
			[Cpp2IlInjected.Address(RVA = "0x2198020", Offset = "0x2196A20", VA = "0x182198020")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (definitionsCase_ == DefinitionsOneofCase.Item)
				{
					object obj = definitions_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003294")]
			[Cpp2IlInjected.Address(RVA = "0x2198200", Offset = "0x2196C00", VA = "0x182198200")]
			set
			{
				//IL_0014: Expected I4, but got I8
				definitions_ = typeof(int).TypeHandle;
				definitionsCase_ = DefinitionsOneofCase.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF3")]
		[DebuggerNonUserCode]
		public GeneratorItemList ItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6003295")]
			[Cpp2IlInjected.Address(RVA = "0x2197FC0", Offset = "0x21969C0", VA = "0x182197FC0")]
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
			[Cpp2IlInjected.Token(Token = "0x6003296")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				definitions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF4")]
		[DebuggerNonUserCode]
		public DefinitionsOneofCase DefinitionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003297")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return definitionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003290")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GeneratorItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003291")]
		[Cpp2IlInjected.Address(RVA = "0x2197D20", Offset = "0x2196720", VA = "0x182197D20")]
		[DebuggerNonUserCode]
		public GeneratorItem(GeneratorItem other)
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
				GeneratorItemList generatorItemList = new GeneratorItemList();
				generatorItemList.useAsFilter_ = (byte)(int)generatorItemList != 0;
				RepeatedField<> list_ = default(RepeatedField<>);
				generatorItemList.list_ = (RepeatedField<GeneratorWeightedItem>)(object)list_;
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				generatorItemList._unknownFields = unknownFields;
				definitions_ = generatorItemList;
				definitionsCase_ = DefinitionsOneofCase.ItemList;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003292")]
		[Cpp2IlInjected.Address(RVA = "0x2197240", Offset = "0x2195C40", VA = "0x182197240", Slot = "10")]
		[DebuggerNonUserCode]
		public GeneratorItem Clone()
		{
			return new GeneratorItem(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003298")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearDefinitions()
		{
			//IL_0010: Expected O, but got I4
			definitions_ = (definitionsCase_ = DefinitionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003299")]
		[Cpp2IlInjected.Address(RVA = "0x21972A0", Offset = "0x2195CA0", VA = "0x1821972A0", Slot = "0")]
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
					GeneratorItemList objB = default(GeneratorItemList);
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

		[Cpp2IlInjected.Token(Token = "0x600329A")]
		[Cpp2IlInjected.Address(RVA = "0x2197390", Offset = "0x2195D90", VA = "0x182197390", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GeneratorItem other)
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
					GeneratorItemList itemList = ItemList;
					GeneratorItemList itemList2 = other.ItemList;
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

		[Cpp2IlInjected.Token(Token = "0x600329B")]
		[Cpp2IlInjected.Address(RVA = "0x2197550", Offset = "0x2195F50", VA = "0x182197550", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x600329C")]
		[Cpp2IlInjected.Address(RVA = "0x2197AD0", Offset = "0x21964D0", VA = "0x182197AD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600329D")]
		[Cpp2IlInjected.Address(RVA = "0x2197B30", Offset = "0x2196530", VA = "0x182197B30", Slot = "6")]
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

		[Cpp2IlInjected.Token(Token = "0x600329E")]
		[Cpp2IlInjected.Address(RVA = "0x2196FE0", Offset = "0x21959E0", VA = "0x182196FE0", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x600329F")]
		[Cpp2IlInjected.Address(RVA = "0x2197730", Offset = "0x2196130", VA = "0x182197730", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GeneratorItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.definitionsCase_ != DefinitionsOneofCase.Item)
			{
				while ((long)typeof(GeneratorItemList).TypeHandle != 2)
				{
				}
				GeneratorItemList generatorItemList = default(GeneratorItemList);
				if (generatorItemList == null)
				{
					GeneratorItemList generatorItemList2 = new GeneratorItemList();
				}
				GeneratorItemList itemList = other.ItemList;
				GeneratorItemList generatorItemList3 = default(GeneratorItemList);
				generatorItemList3.MergeFrom(itemList);
				throw new NullReferenceException();
			}
			int num = (Item = other.Item);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60032A0")]
		[Cpp2IlInjected.Address(RVA = "0x2197840", Offset = "0x2196240", VA = "0x182197840", Slot = "5")]
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
				GeneratorItemList builder = new GeneratorItemList();
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
				definitionsCase_ = (DefinitionsOneofCase)typeof(GeneratorItemList).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60032A1")]
		[Cpp2IlInjected.Address(RVA = "0x2197440", Offset = "0x2195E40", VA = "0x182197440", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60032A2")]
		[Cpp2IlInjected.Address(RVA = "0x21979A0", Offset = "0x21963A0", VA = "0x1821979A0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60032A3")]
		[Cpp2IlInjected.Address(RVA = "0x2197140", Offset = "0x2195B40", VA = "0x182197140", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x60032A4")]
		[Cpp2IlInjected.Address(RVA = "0x2197680", Offset = "0x2196080", VA = "0x182197680", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60032A5")]
		[Cpp2IlInjected.Address(RVA = "0x21971D0", Offset = "0x2195BD0", VA = "0x1821971D0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Definitions"))
			{
				definitions_ = (definitionsCase_ = DefinitionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032A6")]
		[Cpp2IlInjected.Address(RVA = "0x2197C10", Offset = "0x2196610", VA = "0x182197C10")]
		static GeneratorItem()
		{
			Func<GeneratorItem> func = default(Func<GeneratorItem>);
			_parser = (MessageParser<GeneratorItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
