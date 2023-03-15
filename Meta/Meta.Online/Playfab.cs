using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E33")]
	public sealed class Playfab : IMessage<Playfab>, IMessage, IEquatable<Playfab>, IDeepCloneable<Playfab>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400396C")]
		private static readonly MessageParser<Playfab> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400396D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400396E")]
		public const int TitleIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400396F")]
		private string titleId_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003970")]
		public const int DeveloperSecretKeyFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003971")]
		private string developerSecretKey_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014D1")]
		[DebuggerNonUserCode]
		public static MessageParser<Playfab> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007789")]
			[Cpp2IlInjected.Address(RVA = "0x7BD410", Offset = "0x7BBE10", VA = "0x1807BD410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600778A")]
			[Cpp2IlInjected.Address(RVA = "0x7BD340", Offset = "0x7BBD40", VA = "0x1807BD340")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600778B")]
			[Cpp2IlInjected.Address(RVA = "0x7BD470", Offset = "0x7BBE70", VA = "0x1807BD470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D4")]
		[DebuggerNonUserCode]
		public string TitleId
		{
			[Cpp2IlInjected.Token(Token = "0x600778F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return titleId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007790")]
			[Cpp2IlInjected.Address(RVA = "0x7BD5F0", Offset = "0x7BBFF0", VA = "0x1807BD5F0")]
			set
			{
				string text = (titleId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D5")]
		[DebuggerNonUserCode]
		public string DeveloperSecretKey
		{
			[Cpp2IlInjected.Token(Token = "0x6007791")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return developerSecretKey_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007792")]
			[Cpp2IlInjected.Address(RVA = "0x7BD580", Offset = "0x7BBF80", VA = "0x1807BD580")]
			set
			{
				string text = (developerSecretKey_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600778C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2E0", Offset = "0x7BBCE0", VA = "0x1807BD2E0")]
		[DebuggerNonUserCode]
		public Playfab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600778D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD210", Offset = "0x7BBC10", VA = "0x1807BD210")]
		[DebuggerNonUserCode]
		public Playfab(Playfab other)
		{
			string text = (titleId_ = other.titleId_);
			string text2 = (developerSecretKey_ = other.developerSecretKey_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600778E")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA60", Offset = "0x7BB460", VA = "0x1807BCA60", Slot = "10")]
		[DebuggerNonUserCode]
		public Playfab Clone()
		{
			//Discarded unreachable code: IL_004d
			Playfab playfab = new Playfab();
			playfab.titleId_ = "";
			playfab.developerSecretKey_ = "";
			string text = (playfab.titleId_ = titleId_);
			string text2 = (playfab.developerSecretKey_ = developerSecretKey_);
			UnknownFieldSet unknownFieldSet = (playfab._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return playfab;
		}

		[Cpp2IlInjected.Token(Token = "0x6007793")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB60", Offset = "0x7BB560", VA = "0x1807BCB60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = titleId_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = developerSecretKey_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007794")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Playfab other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.titleId_;
				if (!(titleId_ != text))
				{
					string text2 = other.developerSecretKey_;
					if (!(developerSecretKey_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007795")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = titleId_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = developerSecretKey_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6007796")]
		[Cpp2IlInjected.Address(RVA = "0x7BD000", Offset = "0x7BBA00", VA = "0x1807BD000", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007797")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (titleId_.m_stringLength != 0)
			{
				string value = titleId_;
				output.WriteString(value);
			}
			if (developerSecretKey_.m_stringLength != 0)
			{
				string value2 = developerSecretKey_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007798")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8D0", Offset = "0x7BB2D0", VA = "0x1807BC8D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = titleId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = developerSecretKey_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
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

		[Cpp2IlInjected.Token(Token = "0x6007799")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE70", Offset = "0x7BB870", VA = "0x1807BCE70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Playfab other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.titleId_;
				if (text.m_stringLength != 0)
				{
					TitleId = text;
				}
				string text2 = other.developerSecretKey_;
				if (text2.m_stringLength != 0)
				{
					DeveloperSecretKey = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600779A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCDC0", Offset = "0x7BB7C0", VA = "0x1807BCDC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (TitleId = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (DeveloperSecretKey = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600779B")]
		[Cpp2IlInjected.Address(RVA = "0x7BCCA0", Offset = "0x7BB6A0", VA = "0x1807BCCA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = titleId_;
			}
			if (fieldNumber == 2)
			{
				string text2 = developerSecretKey_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600779C")]
		[Cpp2IlInjected.Address(RVA = "0x7BCEF0", Offset = "0x7BB8F0", VA = "0x1807BCEF0", Slot = "12")]
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
				string text = (titleId_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600779D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9B0", Offset = "0x7BB3B0", VA = "0x1807BC9B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (titleId_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				DeveloperSecretKey = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600779E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD100", Offset = "0x7BBB00", VA = "0x1807BD100")]
		static Playfab()
		{
			Func<Playfab> func = default(Func<Playfab>);
			_parser = (MessageParser<Playfab>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
