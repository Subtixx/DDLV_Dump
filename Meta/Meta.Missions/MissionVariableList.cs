using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200102E")]
	public sealed class MissionVariableList : IMessage<MissionVariableList>, IMessage, IEquatable<MissionVariableList>, IDeepCloneable<MissionVariableList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400429B")]
		private static readonly MessageParser<MissionVariableList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400429C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400429D")]
		public const int VariablesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400429E")]
		private static readonly FieldCodec<MissionVariable> _repeated_variables_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400429F")]
		private readonly RepeatedField<MissionVariable> variables_;

		[Cpp2IlInjected.Token(Token = "0x170016BC")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionVariableList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600832D")]
			[Cpp2IlInjected.Address(RVA = "0x1A6C5D0", Offset = "0x1A6AFD0", VA = "0x181A6C5D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600832E")]
			[Cpp2IlInjected.Address(RVA = "0x1A6C500", Offset = "0x1A6AF00", VA = "0x181A6C500")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600832F")]
			[Cpp2IlInjected.Address(RVA = "0x1A6C630", Offset = "0x1A6B030", VA = "0x181A6C630", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BF")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionVariable> Variables
		{
			[Cpp2IlInjected.Token(Token = "0x6008333")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return variables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008330")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C3F0", Offset = "0x1A6ADF0", VA = "0x181A6C3F0")]
		[DebuggerNonUserCode]
		public MissionVariableList()
		{
			variables_ = (RepeatedField<MissionVariable>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6008331")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C470", Offset = "0x1A6AE70", VA = "0x181A6C470")]
		[DebuggerNonUserCode]
		public MissionVariableList(MissionVariableList other)
		{
			RepeatedField<MissionVariable> repeatedField = (variables_ = (RepeatedField<MissionVariable>)(object)((RepeatedField<T>)(object)other.variables_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008332")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BC80", Offset = "0x1A6A680", VA = "0x181A6BC80", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionVariableList Clone()
		{
			//Discarded unreachable code: IL_002e
			MissionVariableList missionVariableList = new MissionVariableList();
			RepeatedField<MissionVariable> repeatedField = (missionVariableList.variables_ = (RepeatedField<MissionVariable>)(object)((RepeatedField<T>)(object)variables_).Clone());
			UnknownFieldSet unknownFieldSet = (missionVariableList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionVariableList;
		}

		[Cpp2IlInjected.Token(Token = "0x6008334")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BD40", Offset = "0x1A6A740", VA = "0x181A6BD40", Slot = "0")]
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
				RepeatedField<MissionVariable> repeatedField = variables_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008335")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BE20", Offset = "0x1A6A820", VA = "0x181A6BE20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionVariableList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<MissionVariable> repeatedField = variables_;
				RepeatedField<MissionVariable> repeatedField2 = other.variables_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008336")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)variables_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6008337")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C100", Offset = "0x1A6AB00", VA = "0x181A6C100", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008338")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C160", Offset = "0x1A6AB60", VA = "0x181A6C160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<MissionVariable> repeatedField = variables_;
			FieldCodec<MissionVariable> repeated_variables_codec = _repeated_variables_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_variables_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008339")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BB70", Offset = "0x1A6A570", VA = "0x181A6BB70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<MissionVariable> repeatedField = variables_;
			FieldCodec<MissionVariable> repeated_variables_codec = _repeated_variables_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_variables_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600833A")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C020", Offset = "0x1A6AA20", VA = "0x181A6C020", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionVariableList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<MissionVariable> repeatedField = variables_;
				RepeatedField<MissionVariable> repeatedField2 = other.variables_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600833B")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BF30", Offset = "0x1A6A930", VA = "0x181A6BF30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<MissionVariable> repeatedField = variables_;
					FieldCodec<MissionVariable> repeated_variables_codec = _repeated_variables_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_variables_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600833C")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BEB0", Offset = "0x1A6A8B0", VA = "0x181A6BEB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MissionVariable> repeatedField = variables_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600833D")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C0A0", Offset = "0x1A6AAA0", VA = "0x181A6C0A0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600833E")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BC20", Offset = "0x1A6A620", VA = "0x181A6BC20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<MissionVariable> repeatedField = variables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600833F")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C220", Offset = "0x1A6AC20", VA = "0x181A6C220")]
		static MissionVariableList()
		{
			Func<MissionVariableList> func = default(Func<MissionVariableList>);
			_parser = (MessageParser<MissionVariableList>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<MissionVariable> parser = MissionVariable._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionVariableList>)(object)FieldCodec.ForMessage<MissionVariable>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
