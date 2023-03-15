using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x20007A6")]
	public sealed class ChildrenEnumOption : IMessage<ChildrenEnumOption>, IMessage, IEquatable<ChildrenEnumOption>, IDeepCloneable<ChildrenEnumOption>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002658")]
		private static readonly MessageParser<ChildrenEnumOption> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002659")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400265A")]
		public const int ChildFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400265B")]
		private string child_ = "";

		[Cpp2IlInjected.Token(Token = "0x400265C")]
		public const int ChoicesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400265D")]
		private static readonly FieldCodec<string> _repeated_choices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400265E")]
		private readonly RepeatedField<string> choices_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400265F")]
		public const int EnumRenamesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4002660")]
		private static readonly FieldCodec<ChoiceRenameMessage> _repeated_enumRenames_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002661")]
		private readonly RepeatedField<ChoiceRenameMessage> enumRenames_ = (RepeatedField<ChoiceRenameMessage>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001557")]
		[DebuggerNonUserCode]
		public static MessageParser<ChildrenEnumOption> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005456")]
			[Cpp2IlInjected.Address(RVA = "0x28A61D0", Offset = "0x28A4BD0", VA = "0x1828A61D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001558")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005457")]
			[Cpp2IlInjected.Address(RVA = "0x28A6100", Offset = "0x28A4B00", VA = "0x1828A6100")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001559")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005458")]
			[Cpp2IlInjected.Address(RVA = "0x28A6230", Offset = "0x28A4C30", VA = "0x1828A6230", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700155A")]
		[DebuggerNonUserCode]
		public string Child
		{
			[Cpp2IlInjected.Token(Token = "0x600545C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return child_;
			}
			[Cpp2IlInjected.Token(Token = "0x600545D")]
			[Cpp2IlInjected.Address(RVA = "0x28A6340", Offset = "0x28A4D40", VA = "0x1828A6340")]
			set
			{
				string text = (child_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700155B")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Choices
		{
			[Cpp2IlInjected.Token(Token = "0x600545E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return choices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700155C")]
		[DebuggerNonUserCode]
		public RepeatedField<ChoiceRenameMessage> EnumRenames
		{
			[Cpp2IlInjected.Token(Token = "0x600545F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return enumRenames_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005459")]
		[Cpp2IlInjected.Address(RVA = "0x28A6020", Offset = "0x28A4A20", VA = "0x1828A6020")]
		[DebuggerNonUserCode]
		public ChildrenEnumOption()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600545A")]
		[Cpp2IlInjected.Address(RVA = "0x28A5E70", Offset = "0x28A4870", VA = "0x1828A5E70")]
		[DebuggerNonUserCode]
		public ChildrenEnumOption(ChildrenEnumOption other)
		{
			string text = (child_ = other.child_);
			RepeatedField<string> repeatedField = (choices_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.choices_).Clone());
			RepeatedField<ChoiceRenameMessage> repeatedField2 = (enumRenames_ = (RepeatedField<ChoiceRenameMessage>)(object)((RepeatedField<T>)(object)other.enumRenames_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600545B")]
		[Cpp2IlInjected.Address(RVA = "0x28A5320", Offset = "0x28A3D20", VA = "0x1828A5320", Slot = "10")]
		[DebuggerNonUserCode]
		public ChildrenEnumOption Clone()
		{
			//Discarded unreachable code: IL_007a
			ChildrenEnumOption childrenEnumOption = new ChildrenEnumOption();
			childrenEnumOption.child_ = "";
			RepeatedField<string> repeatedField = (childrenEnumOption.choices_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			RepeatedField<ChoiceRenameMessage> repeatedField2 = (childrenEnumOption.enumRenames_ = (RepeatedField<ChoiceRenameMessage>)(object)new RepeatedField<T>());
			string text = (childrenEnumOption.child_ = child_);
			RepeatedField<string> repeatedField3 = (childrenEnumOption.choices_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)choices_).Clone());
			RepeatedField<ChoiceRenameMessage> repeatedField4 = (childrenEnumOption.enumRenames_ = (RepeatedField<ChoiceRenameMessage>)(object)((RepeatedField<T>)(object)enumRenames_).Clone());
			UnknownFieldSet unknownFieldSet = (childrenEnumOption._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return childrenEnumOption;
		}

		[Cpp2IlInjected.Token(Token = "0x6005460")]
		[Cpp2IlInjected.Address(RVA = "0x28A5500", Offset = "0x28A3F00", VA = "0x1828A5500", Slot = "0")]
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
				string text = child_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<string> repeatedField = choices_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<ChoiceRenameMessage> repeatedField2 = enumRenames_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005461")]
		[Cpp2IlInjected.Address(RVA = "0x28A5620", Offset = "0x28A4020", VA = "0x1828A5620", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChildrenEnumOption other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.child_;
				if (!(child_ != text))
				{
					RepeatedField<string> repeatedField = choices_;
					RepeatedField<string> repeatedField2 = other.choices_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						RepeatedField<ChoiceRenameMessage> repeatedField3 = enumRenames_;
						RepeatedField<ChoiceRenameMessage> repeatedField4 = other.enumRenames_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005462")]
		[Cpp2IlInjected.Address(RVA = "0x17C4750", Offset = "0x17C3150", VA = "0x1817C4750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004b
			string text = child_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)choices_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)enumRenames_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode3;
		}

		[Cpp2IlInjected.Token(Token = "0x6005463")]
		[Cpp2IlInjected.Address(RVA = "0x28A5AF0", Offset = "0x28A44F0", VA = "0x1828A5AF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005464")]
		[Cpp2IlInjected.Address(RVA = "0x28A5B50", Offset = "0x28A4550", VA = "0x1828A5B50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			if (child_.m_stringLength != 0)
			{
				string value = child_;
				output.WriteString(value);
			}
			RepeatedField<string> repeatedField = choices_;
			FieldCodec<string> repeated_choices_codec = _repeated_choices_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_choices_codec);
			RepeatedField<ChoiceRenameMessage> repeatedField2 = enumRenames_;
			FieldCodec<ChoiceRenameMessage> repeated_enumRenames_codec = _repeated_enumRenames_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_enumRenames_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005465")]
		[Cpp2IlInjected.Address(RVA = "0x28A5140", Offset = "0x28A3B40", VA = "0x1828A5140", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			string text = child_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<string> repeatedField = choices_;
			FieldCodec<string> repeated_choices_codec = _repeated_choices_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_choices_codec);
			RepeatedField<ChoiceRenameMessage> repeatedField2 = enumRenames_;
			FieldCodec<ChoiceRenameMessage> repeated_enumRenames_codec = _repeated_enumRenames_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_enumRenames_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<string>)(repeatedField + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005466")]
		[Cpp2IlInjected.Address(RVA = "0x28A5790", Offset = "0x28A4190", VA = "0x1828A5790", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChildrenEnumOption other)
		{
			//Discarded unreachable code: IL_0067
			if (other != null)
			{
				string text = other.child_;
				if (text.m_stringLength != 0)
				{
					Child = text;
				}
				RepeatedField<string> repeatedField = choices_;
				RepeatedField<string> repeatedField2 = other.choices_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<ChoiceRenameMessage> repeatedField3 = enumRenames_;
				RepeatedField<ChoiceRenameMessage> repeatedField4 = other.enumRenames_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005467")]
		[Cpp2IlInjected.Address(RVA = "0x28A5850", Offset = "0x28A4250", VA = "0x1828A5850", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0071
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Child = input.ReadString());
				}
				if (num == 18)
				{
					RepeatedField<string> repeatedField = choices_;
					FieldCodec<string> repeated_choices_codec = _repeated_choices_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_choices_codec);
				}
				if (num == 26)
				{
					RepeatedField<ChoiceRenameMessage> repeatedField2 = enumRenames_;
					FieldCodec<ChoiceRenameMessage> repeated_enumRenames_codec = _repeated_enumRenames_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_enumRenames_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005468")]
		[Cpp2IlInjected.Address(RVA = "0x28A56F0", Offset = "0x28A40F0", VA = "0x1828A56F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ChoiceRenameMessage> repeatedField = enumRenames_;
				RepeatedField<string> repeatedField2 = choices_;
				string text = child_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005469")]
		[Cpp2IlInjected.Address(RVA = "0x28A59D0", Offset = "0x28A43D0", VA = "0x1828A59D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			while (true)
			{
				int num = fieldNumber - 1;
				if (num != 0)
				{
					switch (num)
					{
					case 0:
						continue;
					case 1:
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					}
				}
				break;
			}
			int num2 = 0;
			if (value == null || value != null)
			{
				Child = (string)num2;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600546A")]
		[Cpp2IlInjected.Address(RVA = "0x28A5280", Offset = "0x28A3C80", VA = "0x1828A5280", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0023
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 1)
				{
					return;
				}
				RepeatedField<string> repeatedField = choices_;
			}
			Child = "";
		}

		[Cpp2IlInjected.Token(Token = "0x600546B")]
		[Cpp2IlInjected.Address(RVA = "0x28A5C80", Offset = "0x28A4680", VA = "0x1828A5C80")]
		static ChildrenEnumOption()
		{
			Func<ChildrenEnumOption> func = default(Func<ChildrenEnumOption>);
			_parser = (MessageParser<ChildrenEnumOption>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ChildrenEnumOption>)(object)FieldCodec.ForString(18u);
			MessageParser<ChoiceRenameMessage> parser = ChoiceRenameMessage._parser;
			uint num = default(uint);
			_parser = (MessageParser<ChildrenEnumOption>)(object)FieldCodec.ForMessage<ChoiceRenameMessage>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
