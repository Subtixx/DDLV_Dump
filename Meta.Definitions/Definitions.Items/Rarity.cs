using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000412")]
	public sealed class Rarity : IMessage<Rarity>, IMessage, IEquatable<Rarity>, IDeepCloneable<Rarity>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000413")]
		public enum DefinitionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001641")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001642")]
			Value,
			[Cpp2IlInjected.Token(Token = "0x4001643")]
			Range
		}

		[Cpp2IlInjected.Token(Token = "0x400163A")]
		private static readonly MessageParser<Rarity> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400163B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400163C")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400163D")]
		public const int RangeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400163E")]
		private object definitions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400163F")]
		private DefinitionsOneofCase definitionsCase_;

		[Cpp2IlInjected.Token(Token = "0x17000CC1")]
		[DebuggerNonUserCode]
		public static MessageParser<Rarity> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60031C7")]
			[Cpp2IlInjected.Address(RVA = "0x2DA36D0", Offset = "0x2DA20D0", VA = "0x182DA36D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031C8")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3600", Offset = "0x2DA2000", VA = "0x182DA3600")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031C9")]
			[Cpp2IlInjected.Address(RVA = "0x2DA37F0", Offset = "0x2DA21F0", VA = "0x182DA37F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC4")]
		[DebuggerNonUserCode]
		public ScalableValue Value
		{
			[Cpp2IlInjected.Token(Token = "0x60031CD")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3790", Offset = "0x2DA2190", VA = "0x182DA3790")]
			get
			{
				int num = 0;
				if (definitionsCase_ == DefinitionsOneofCase.Value)
				{
					object obj = definitions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031CE")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				definitions_ = value;
				bool flag = (byte)(definitionsCase_ = ((value != null) ? DefinitionsOneofCase.Value : DefinitionsOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC5")]
		[DebuggerNonUserCode]
		public Range Range
		{
			[Cpp2IlInjected.Token(Token = "0x60031CF")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3730", Offset = "0x2DA2130", VA = "0x182DA3730")]
			get
			{
				int num = 0;
				if (definitionsCase_ == DefinitionsOneofCase.Range)
				{
					object obj = definitions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031D0")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				definitions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC6")]
		[DebuggerNonUserCode]
		public DefinitionsOneofCase DefinitionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x60031D1")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return definitionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031CA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Rarity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60031CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA32E0", Offset = "0x2DA1CE0", VA = "0x182DA32E0")]
		[DebuggerNonUserCode]
		public Rarity(Rarity other)
		{
			//IL_0031: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_004f: Expected I4, but got I8
			//IL_0088: Expected I4, but got O
			//IL_0091: Expected I4, but got O
			//IL_00a3: Expected O, but got I4
			//IL_00b8: Expected I4, but got O
			//IL_00c1: Expected I4, but got O
			//IL_00ed: Expected I4, but got I8
			DefinitionsOneofCase definitionsOneofCase = other.definitionsCase_;
			if (definitionsOneofCase == DefinitionsOneofCase.Value)
			{
				DefinitionsOneofCase definitionsOneofCase2 = other.definitionsCase_;
				if (other.definitions_ == null)
				{
					throw new InvalidCastException();
				}
				ScalableValue scalableValue = new ScalableValue();
				scalableValue.value_ = (int)scalableValue;
				scalableValue.scalingScript_ = (int)scalableValue;
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				scalableValue._unknownFields = unknownFields;
				definitions_ = scalableValue;
				definitionsCase_ = DefinitionsOneofCase.Value;
			}
			if (definitionsOneofCase == DefinitionsOneofCase.Range)
			{
				DefinitionsOneofCase definitionsOneofCase3 = other.definitionsCase_;
				object obj = other.definitions_;
				int num = 0;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				Range range = new Range();
				ScalableValue scalableValue2 = new ScalableValue();
				scalableValue2.value_ = (int)scalableValue2;
				scalableValue2.scalingScript_ = (int)scalableValue2;
				UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
				scalableValue2._unknownFields = unknownFields2;
				range.min_ = (ScalableValue)num;
				ScalableValue scalableValue3 = default(ScalableValue);
				if (num != 0)
				{
					scalableValue3 = new ScalableValue();
					scalableValue3.value_ = (int)scalableValue3;
					scalableValue3.scalingScript_ = (int)scalableValue3;
					UnknownFieldSet unknownFields3 = default(UnknownFieldSet);
					scalableValue3._unknownFields = unknownFields3;
				}
				range.max_ = scalableValue3;
				UnknownFieldSet unknownFields4 = default(UnknownFieldSet);
				range._unknownFields = unknownFields4;
				definitions_ = range;
				definitionsCase_ = DefinitionsOneofCase.Range;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2490", Offset = "0x2DA0E90", VA = "0x182DA2490", Slot = "10")]
		[DebuggerNonUserCode]
		public Rarity Clone()
		{
			return new Rarity(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60031D2")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearDefinitions()
		{
			//IL_0010: Expected O, but got I4
			definitions_ = (definitionsCase_ = DefinitionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA24F0", Offset = "0x2DA0EF0", VA = "0x182DA24F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (definitionsCase_ == DefinitionsOneofCase.Value)
					{
						object obj = definitions_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(ScalableValue).TypeHandle != null && (object)typeof(ScalableValue).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						Range objB = default(Range);
						bool flag2 = object.Equals(Range, objB);
						if (flag2 && definitionsCase_ == (flag2 ? DefinitionsOneofCase.Value : DefinitionsOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0071;
			IL_0071:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D4")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2660", Offset = "0x2DA1060", VA = "0x182DA2660", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Rarity other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (definitionsCase_ == DefinitionsOneofCase.Value)
				{
					object obj = definitions_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.definitionsCase_ == DefinitionsOneofCase.Value)
				{
					obj2 = other.definitions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					Range range = Range;
					Range range2 = other.Range;
					if (object.Equals(range, range2))
					{
						DefinitionsOneofCase definitionsOneofCase = other.definitionsCase_;
						if (definitionsCase_ == definitionsOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0099;
			IL_0099:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DA28A0", Offset = "0x2DA12A0", VA = "0x182DA28A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			DefinitionsOneofCase definitionsOneofCase = definitionsCase_;
			int num = 0;
			if (definitionsOneofCase == DefinitionsOneofCase.Value)
			{
				object obj = definitions_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (definitionsOneofCase == DefinitionsOneofCase.Range)
			{
				object obj2 = definitions_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60031D6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3040", Offset = "0x2DA1A40", VA = "0x182DA3040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60031D7")]
		[Cpp2IlInjected.Address(RVA = "0x2DA30A0", Offset = "0x2DA1AA0", VA = "0x182DA30A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			DefinitionsOneofCase definitionsOneofCase = definitionsCase_;
			int num = 0;
			if (definitionsOneofCase == DefinitionsOneofCase.Value)
			{
				if (definitionsCase_ == DefinitionsOneofCase.Value)
				{
					object obj = definitions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (definitionsOneofCase == DefinitionsOneofCase.Range && definitionsCase_ == DefinitionsOneofCase.Range)
			{
				object obj2 = definitions_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60031D8")]
		[Cpp2IlInjected.Address(RVA = "0x2DA22D0", Offset = "0x2DA0CD0", VA = "0x182DA22D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (definitionsCase_ == DefinitionsOneofCase.Value)
			{
				if (definitionsCase_ == DefinitionsOneofCase.Value)
				{
					object obj = definitions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (definitionsCase_ == DefinitionsOneofCase.Range)
			{
				if (definitionsCase_ == DefinitionsOneofCase.Range)
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

		[Cpp2IlInjected.Token(Token = "0x60031D9")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2A80", Offset = "0x2DA1480", VA = "0x182DA2A80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Rarity other)
		{
			//IL_00f5: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.definitionsCase_ == DefinitionsOneofCase.Value)
			{
				DefinitionsOneofCase definitionsOneofCase = definitionsCase_;
				int num = 0;
				if (definitionsOneofCase == DefinitionsOneofCase.Value)
				{
					object obj = definitions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(definitionsCase_ = (((definitions_ = new ScalableValue()) != null) ? DefinitionsOneofCase.Value : DefinitionsOneofCase.None)) != 0;
				}
				if (definitionsCase_ == DefinitionsOneofCase.Value)
				{
					object obj2 = definitions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				object obj3 = default(object);
				if (other.definitionsCase_ == DefinitionsOneofCase.Value)
				{
					obj3 = other.definitions_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj3 != null)
				{
					if ((object)typeof(ScalableValue).TypeHandle != null)
					{
					}
					if ((object)typeof(ScalableValue).TypeHandle == null)
					{
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(ScalableValue).TypeHandle != 2)
			{
			}
			if (Range == null)
			{
				definitionsCase_ = (DefinitionsOneofCase)(definitions_ = new Range());
			}
			Range other2 = default(Range);
			Range.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031DA")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2D00", Offset = "0x2DA1700", VA = "0x182DA2D00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0059: Expected I4, but got O
			//IL_006c: Expected I4, but got O
			//IL_00e6: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ScalableValue scalableValue = new ScalableValue();
				if (definitionsCase_ == DefinitionsOneofCase.Value)
				{
					if (definitionsCase_ != DefinitionsOneofCase.Value)
					{
					}
					object obj = definitions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
					if (obj != null)
					{
						if ((object)typeof(ScalableValue).TypeHandle != null)
						{
							scalableValue.value_ = (int)typeof(ScalableValue).TypeHandle;
						}
						if ((object)typeof(ScalableValue).TypeHandle != null)
						{
							scalableValue.scalingScript_ = (int)typeof(ScalableValue).TypeHandle;
						}
						UnknownFieldSet unknownFields = scalableValue._unknownFields;
						UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
						scalableValue._unknownFields = unknownFields2;
					}
				}
				input.ReadMessage(scalableValue);
				definitions_ = scalableValue;
				bool flag = (byte)(definitionsCase_ = ((scalableValue != null) ? DefinitionsOneofCase.Value : DefinitionsOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				Range builder = new Range();
				if (definitionsCase_ == DefinitionsOneofCase.Range)
				{
					if (definitionsCase_ != DefinitionsOneofCase.Range)
					{
					}
					object obj2 = definitions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				definitions_ = builder;
				definitionsCase_ = (DefinitionsOneofCase)typeof(Range).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60031DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2790", Offset = "0x2DA1190", VA = "0x182DA2790", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (definitionsCase_ == DefinitionsOneofCase.Value)
			{
				object obj = definitions_;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					goto IL_001c;
				}
			}
			goto IL_0038;
			IL_0038:
			object obj2 = default(object);
			return obj2;
			IL_001c:
			if (fieldNumber == 2)
			{
				if (definitionsCase_ == DefinitionsOneofCase.Range)
				{
					obj2 = definitions_;
					if (obj2 != null && obj2 == null)
					{
						goto IL_0040;
					}
				}
				goto IL_0038;
			}
			goto IL_0040;
			IL_0040:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031DC")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2F50", Offset = "0x2DA1950", VA = "0x182DA2F50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0043: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				definitions_ = num;
				bool flag = (byte)(definitionsCase_ = ((num != 0) ? DefinitionsOneofCase.Value : DefinitionsOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				definitions_ = value;
				definitionsCase_ = (DefinitionsOneofCase)typeof(ScalableValue).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031DD")]
		[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1 || fieldNumber == 2)
			{
				definitionsCase_ = DefinitionsOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031DE")]
		[Cpp2IlInjected.Address(RVA = "0x2DA29D0", Offset = "0x2DA13D0", VA = "0x182DA29D0", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60031DF")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2420", Offset = "0x2DA0E20", VA = "0x182DA2420", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Definitions"))
			{
				definitions_ = (definitionsCase_ = DefinitionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031E0")]
		[Cpp2IlInjected.Address(RVA = "0x2DA31D0", Offset = "0x2DA1BD0", VA = "0x182DA31D0")]
		static Rarity()
		{
			Func<Rarity> func = default(Func<Rarity>);
			_parser = (MessageParser<Rarity>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
