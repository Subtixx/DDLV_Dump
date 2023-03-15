using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000777")]
	public sealed class CustomEditorOptions : IMessage<CustomEditorOptions>, IMessage, IEquatable<CustomEditorOptions>, IDeepCloneable<CustomEditorOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002517")]
		private static readonly MessageParser<CustomEditorOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002518")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002519")]
		public const int CustomEditorTypeNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400251A")]
		private string customEditorTypeName_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014D5")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomEditorOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600524C")]
			[Cpp2IlInjected.Address(RVA = "0x2D498B0", Offset = "0x2D482B0", VA = "0x182D498B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600524D")]
			[Cpp2IlInjected.Address(RVA = "0x2D497E0", Offset = "0x2D481E0", VA = "0x182D497E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600524E")]
			[Cpp2IlInjected.Address(RVA = "0x2D49910", Offset = "0x2D48310", VA = "0x182D49910", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D8")]
		[DebuggerNonUserCode]
		public string CustomEditorTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6005252")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return customEditorTypeName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005253")]
			[Cpp2IlInjected.Address(RVA = "0x2D49A20", Offset = "0x2D48420", VA = "0x182D49A20")]
			set
			{
				string text = (customEditorTypeName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600524F")]
		[Cpp2IlInjected.Address(RVA = "0x2D49790", Offset = "0x2D48190", VA = "0x182D49790")]
		[DebuggerNonUserCode]
		public CustomEditorOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005250")]
		[Cpp2IlInjected.Address(RVA = "0x2D496F0", Offset = "0x2D480F0", VA = "0x182D496F0")]
		[DebuggerNonUserCode]
		public CustomEditorOptions(CustomEditorOptions other)
		{
			string text = (customEditorTypeName_ = other.customEditorTypeName_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005251")]
		[Cpp2IlInjected.Address(RVA = "0x2D491E0", Offset = "0x2D47BE0", VA = "0x182D491E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomEditorOptions Clone()
		{
			//Discarded unreachable code: IL_0034
			CustomEditorOptions customEditorOptions = new CustomEditorOptions();
			customEditorOptions.customEditorTypeName_ = "";
			string text = (customEditorOptions.customEditorTypeName_ = customEditorTypeName_);
			UnknownFieldSet unknownFieldSet = (customEditorOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customEditorOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6005254")]
		[Cpp2IlInjected.Address(RVA = "0x2D492A0", Offset = "0x2D47CA0", VA = "0x182D492A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = customEditorTypeName_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005255")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomEditorOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.customEditorTypeName_;
				if (!(customEditorTypeName_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005256")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = customEditorTypeName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005257")]
		[Cpp2IlInjected.Address(RVA = "0x2D49580", Offset = "0x2D47F80", VA = "0x182D49580", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005258")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (customEditorTypeName_.m_stringLength != 0)
			{
				string value = customEditorTypeName_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005259")]
		[Cpp2IlInjected.Address(RVA = "0x2D490B0", Offset = "0x2D47AB0", VA = "0x182D490B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = customEditorTypeName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600525A")]
		[Cpp2IlInjected.Address(RVA = "0x2D49460", Offset = "0x2D47E60", VA = "0x182D49460", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomEditorOptions other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.customEditorTypeName_;
				if (text.m_stringLength != 0)
				{
					CustomEditorTypeName = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600525B")]
		[Cpp2IlInjected.Address(RVA = "0x2D493D0", Offset = "0x2D47DD0", VA = "0x182D493D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (CustomEditorTypeName = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600525C")]
		[Cpp2IlInjected.Address(RVA = "0x2D49350", Offset = "0x2D47D50", VA = "0x182D49350", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = customEditorTypeName_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600525D")]
		[Cpp2IlInjected.Address(RVA = "0x2D494C0", Offset = "0x2D47EC0", VA = "0x182D494C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (customEditorTypeName_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600525E")]
		[Cpp2IlInjected.Address(RVA = "0x2D49150", Offset = "0x2D47B50", VA = "0x182D49150", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (customEditorTypeName_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600525F")]
		[Cpp2IlInjected.Address(RVA = "0x2D495E0", Offset = "0x2D47FE0", VA = "0x182D495E0")]
		static CustomEditorOptions()
		{
			Func<CustomEditorOptions> func = default(Func<CustomEditorOptions>);
			_parser = (MessageParser<CustomEditorOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
