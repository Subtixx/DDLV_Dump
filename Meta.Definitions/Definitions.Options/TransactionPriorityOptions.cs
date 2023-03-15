using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x20007AA")]
	public sealed class TransactionPriorityOptions : IMessage<TransactionPriorityOptions>, IMessage, IEquatable<TransactionPriorityOptions>, IDeepCloneable<TransactionPriorityOptions>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007AB")]
		public enum ChoicesOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4002670")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002671")]
			Value,
			[Cpp2IlInjected.Token(Token = "0x4002672")]
			Dynamic
		}

		[Cpp2IlInjected.Token(Token = "0x20007AC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20007AD")]
			public enum Priority
			{
				[Cpp2IlInjected.Token(Token = "0x4002674")]
				[OriginalName("Priority_High")]
				High,
				[Cpp2IlInjected.Token(Token = "0x4002675")]
				[OriginalName("Priority_Normal")]
				Normal,
				[Cpp2IlInjected.Token(Token = "0x4002676")]
				[OriginalName("Priority_Low")]
				Low
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002669")]
		private static readonly MessageParser<TransactionPriorityOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400266A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400266B")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400266C")]
		public const int DynamicFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400266D")]
		private object choices_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400266E")]
		private ChoicesOneofCase choicesCase_;

		[Cpp2IlInjected.Token(Token = "0x17001561")]
		[DebuggerNonUserCode]
		public static MessageParser<TransactionPriorityOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005485")]
			[Cpp2IlInjected.Address(RVA = "0x354D900", Offset = "0x354C300", VA = "0x18354D900")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001562")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005486")]
			[Cpp2IlInjected.Address(RVA = "0x354D7C0", Offset = "0x354C1C0", VA = "0x18354D7C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001563")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005487")]
			[Cpp2IlInjected.Address(RVA = "0x354D9D0", Offset = "0x354C3D0", VA = "0x18354D9D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001564")]
		[DebuggerNonUserCode]
		public Types.Priority Value
		{
			[Cpp2IlInjected.Token(Token = "0x600548B")]
			[Cpp2IlInjected.Address(RVA = "0x354D960", Offset = "0x354C360", VA = "0x18354D960")]
			get
			{
				if (choicesCase_ == ChoicesOneofCase.Value)
				{
					object obj = choices_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600548C")]
			[Cpp2IlInjected.Address(RVA = "0x354DB50", Offset = "0x354C550", VA = "0x18354DB50")]
			set
			{
				//IL_0016: Expected I4, but got I8
				choices_ = typeof(Types.Priority).TypeHandle;
				choicesCase_ = ChoicesOneofCase.Value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001565")]
		[DebuggerNonUserCode]
		public bool Dynamic
		{
			[Cpp2IlInjected.Token(Token = "0x600548D")]
			[Cpp2IlInjected.Address(RVA = "0x354D890", Offset = "0x354C290", VA = "0x18354D890")]
			get
			{
				if (choicesCase_ == ChoicesOneofCase.Dynamic)
				{
					object obj = choices_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600548E")]
			[Cpp2IlInjected.Address(RVA = "0x354DAE0", Offset = "0x354C4E0", VA = "0x18354DAE0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				choices_ = typeof(bool).TypeHandle;
				choicesCase_ = ChoicesOneofCase.Dynamic;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001566")]
		[DebuggerNonUserCode]
		public ChoicesOneofCase ChoicesCase
		{
			[Cpp2IlInjected.Token(Token = "0x600548F")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return choicesCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005488")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TransactionPriorityOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005489")]
		[Cpp2IlInjected.Address(RVA = "0x354D6F0", Offset = "0x354C0F0", VA = "0x18354D6F0")]
		[DebuggerNonUserCode]
		public TransactionPriorityOptions(TransactionPriorityOptions other)
		{
			//IL_002c: Expected I4, but got I8
			ChoicesOneofCase choicesOneofCase = other.choicesCase_;
			if (choicesOneofCase == ChoicesOneofCase.Value)
			{
				int value = (int)other.Value;
				choices_ = typeof(Types.Priority).TypeHandle;
				choicesCase_ = ChoicesOneofCase.Value;
			}
			if (choicesOneofCase == ChoicesOneofCase.Dynamic)
			{
				bool flag = (Dynamic = other.Dynamic);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600548A")]
		[Cpp2IlInjected.Address(RVA = "0x354CCE0", Offset = "0x354B6E0", VA = "0x18354CCE0", Slot = "10")]
		[DebuggerNonUserCode]
		public TransactionPriorityOptions Clone()
		{
			//Discarded unreachable code: IL_0055
			//IL_002c: Expected I4, but got I8
			TransactionPriorityOptions transactionPriorityOptions = new TransactionPriorityOptions();
			ChoicesOneofCase choicesOneofCase = choicesCase_;
			if (choicesOneofCase == ChoicesOneofCase.Value)
			{
				int value = (int)Value;
				transactionPriorityOptions.choices_ = typeof(Types.Priority).TypeHandle;
				transactionPriorityOptions.choicesCase_ = ChoicesOneofCase.Value;
			}
			if (choicesOneofCase == ChoicesOneofCase.Dynamic)
			{
				bool flag = (transactionPriorityOptions.Dynamic = Dynamic);
			}
			UnknownFieldSet unknownFieldSet = (transactionPriorityOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return transactionPriorityOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6005490")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearChoices()
		{
			//IL_0010: Expected O, but got I4
			choices_ = (choicesCase_ = ChoicesOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005491")]
		[Cpp2IlInjected.Address(RVA = "0x354CDE0", Offset = "0x354B7E0", VA = "0x18354CDE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0037: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.Priority priority = default(Types.Priority);
				if (Value == priority)
				{
					bool dynamic = Dynamic;
					int num = 0;
					bool flag = default(bool);
					if (dynamic == flag && choicesCase_ == (flag ? ChoicesOneofCase.Value : ChoicesOneofCase.None))
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005492")]
		[Cpp2IlInjected.Address(RVA = "0x354CEC0", Offset = "0x354B8C0", VA = "0x18354CEC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TransactionPriorityOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int value = (int)Value;
				Types.Priority value2 = other.Value;
				if (value == (int)value2)
				{
					bool dynamic = Dynamic;
					bool dynamic2 = other.Dynamic;
					if (dynamic == dynamic2)
					{
						ChoicesOneofCase choicesOneofCase = other.choicesCase_;
						if (choicesCase_ == choicesOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x6005493")]
		[Cpp2IlInjected.Address(RVA = "0x354D050", Offset = "0x354BA50", VA = "0x18354D050", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (choicesCase_ == ChoicesOneofCase.Value)
			{
				if (choicesCase_ == ChoicesOneofCase.Value)
				{
					object obj = choices_;
				}
				System.Net.Http.Headers.Token.Type type = (System.Net.Http.Headers.Token)num;
			}
			if (choicesCase_ == ChoicesOneofCase.Dynamic)
			{
				if (choicesCase_ != ChoicesOneofCase.Dynamic)
				{
					int num2 = 0;
				}
				object obj2 = choices_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005494")]
		[Cpp2IlInjected.Address(RVA = "0x354D4E0", Offset = "0x354BEE0", VA = "0x18354D4E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005495")]
		[Cpp2IlInjected.Address(RVA = "0x354D540", Offset = "0x354BF40", VA = "0x18354D540", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003e
			ChoicesOneofCase choicesOneofCase = choicesCase_;
			if (choicesOneofCase == ChoicesOneofCase.Value)
			{
				int value = (int)Value;
				output.WriteInt32(value);
			}
			if (choicesOneofCase == ChoicesOneofCase.Dynamic)
			{
				bool dynamic = Dynamic;
				output.WriteBool(dynamic);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005496")]
		[Cpp2IlInjected.Address(RVA = "0x354CB00", Offset = "0x354B500", VA = "0x18354CB00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			if (choicesCase_ == ChoicesOneofCase.Value)
			{
				if (choicesCase_ == ChoicesOneofCase.Value)
				{
					object obj = choices_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005497")]
		[Cpp2IlInjected.Address(RVA = "0x354D330", Offset = "0x354BD30", VA = "0x18354D330", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TransactionPriorityOptions other)
		{
			if (other != null)
			{
				ChoicesOneofCase choicesOneofCase = other.choicesCase_;
				if (choicesOneofCase == ChoicesOneofCase.Value)
				{
					Types.Priority value = other.Value;
				}
				if (choicesOneofCase == ChoicesOneofCase.Dynamic)
				{
					bool flag = (Dynamic = other.Dynamic);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005498")]
		[Cpp2IlInjected.Address(RVA = "0x354D240", Offset = "0x354BC40", VA = "0x18354D240", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			//IL_001f: Expected O, but got I4
			//IL_0028: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = input.ReadInt32();
					choices_ = num2;
					choicesCase_ = ChoicesOneofCase.Value;
				}
				if (num == 16)
				{
					bool flag2 = (Dynamic = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005499")]
		[Cpp2IlInjected.Address(RVA = "0x354CF60", Offset = "0x354B960", VA = "0x18354CF60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.Priority value = Value;
			}
			if (fieldNumber == 2)
			{
				bool dynamic = Dynamic;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600549A")]
		[Cpp2IlInjected.Address(RVA = "0x354D3B0", Offset = "0x354BDB0", VA = "0x18354D3B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001e
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				choices_ = typeof(Types.Priority).TypeHandle;
				choicesCase_ = ChoicesOneofCase.Value;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600549B")]
		[Cpp2IlInjected.Address(RVA = "0x354CBF0", Offset = "0x354B5F0", VA = "0x18354CBF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				Types.Priority priority = default(Types.Priority);
				choices_ = priority;
				choicesCase_ = ChoicesOneofCase.Value;
				break;
			}
			case 2:
			{
				int num = ((Dynamic = false) ? 1 : 0);
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600549C")]
		[Cpp2IlInjected.Address(RVA = "0x354D190", Offset = "0x354BB90", VA = "0x18354D190", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Choices"))
			{
				ChoicesOneofCase choicesOneofCase = choicesCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600549D")]
		[Cpp2IlInjected.Address(RVA = "0x354CC70", Offset = "0x354B670", VA = "0x18354CC70", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Choices"))
			{
				choices_ = (choicesCase_ = ChoicesOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600549E")]
		[Cpp2IlInjected.Address(RVA = "0x354D5E0", Offset = "0x354BFE0", VA = "0x18354D5E0")]
		static TransactionPriorityOptions()
		{
			Func<TransactionPriorityOptions> func = default(Func<TransactionPriorityOptions>);
			_parser = (MessageParser<TransactionPriorityOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
