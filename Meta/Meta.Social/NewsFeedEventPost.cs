using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BE3")]
	public sealed class NewsFeedEventPost : IMessage<NewsFeedEventPost>, IMessage, IEquatable<NewsFeedEventPost>, IDeepCloneable<NewsFeedEventPost>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002E0F")]
		private static readonly MessageParser<NewsFeedEventPost> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002E10")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002E11")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E12")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002E13")]
		public const int TypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E14")]
		private SocialEventType type_;

		[Cpp2IlInjected.Token(Token = "0x17001175")]
		[DebuggerNonUserCode]
		public static MessageParser<NewsFeedEventPost> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60064FE")]
			[Cpp2IlInjected.Address(RVA = "0x1396280", Offset = "0x1394C80", VA = "0x181396280")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001176")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60064FF")]
			[Cpp2IlInjected.Address(RVA = "0x13961B0", Offset = "0x1394BB0", VA = "0x1813961B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001177")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006500")]
			[Cpp2IlInjected.Address(RVA = "0x13962E0", Offset = "0x1394CE0", VA = "0x1813962E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001178")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6006504")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006505")]
			[Cpp2IlInjected.Address(RVA = "0x13963F0", Offset = "0x1394DF0", VA = "0x1813963F0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001179")]
		[DebuggerNonUserCode]
		public SocialEventType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6006506")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006507")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006501")]
		[Cpp2IlInjected.Address(RVA = "0x13960C0", Offset = "0x1394AC0", VA = "0x1813960C0")]
		[DebuggerNonUserCode]
		public NewsFeedEventPost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6006502")]
		[Cpp2IlInjected.Address(RVA = "0x1396110", Offset = "0x1394B10", VA = "0x181396110")]
		[DebuggerNonUserCode]
		public NewsFeedEventPost(NewsFeedEventPost other)
		{
			string text = (name_ = other.name_);
			SocialEventType socialEventType = (type_ = other.type_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006503")]
		[Cpp2IlInjected.Address(RVA = "0x1395950", Offset = "0x1394350", VA = "0x181395950", Slot = "10")]
		[DebuggerNonUserCode]
		public NewsFeedEventPost Clone()
		{
			//Discarded unreachable code: IL_0042
			NewsFeedEventPost newsFeedEventPost = new NewsFeedEventPost();
			newsFeedEventPost.name_ = "";
			string text = (newsFeedEventPost.name_ = name_);
			SocialEventType socialEventType = (newsFeedEventPost.type_ = type_);
			UnknownFieldSet unknownFieldSet = (newsFeedEventPost._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return newsFeedEventPost;
		}

		[Cpp2IlInjected.Token(Token = "0x6006508")]
		[Cpp2IlInjected.Address(RVA = "0x1395A90", Offset = "0x1394490", VA = "0x181395A90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = name_;
				bool flag = default(bool);
				if (!flag && type_ == (flag ? ((SocialEventType)1) : SocialEventType.PhonePrompt))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006509")]
		[Cpp2IlInjected.Address(RVA = "0x1395A20", Offset = "0x1394420", VA = "0x181395A20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NewsFeedEventPost other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					SocialEventType socialEventType = other.type_;
					if (type_ == socialEventType)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600650A")]
		[Cpp2IlInjected.Address(RVA = "0x1395C10", Offset = "0x1394610", VA = "0x181395C10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0035
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (type_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600650B")]
		[Cpp2IlInjected.Address(RVA = "0x1395EC0", Offset = "0x13948C0", VA = "0x181395EC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600650C")]
		[Cpp2IlInjected.Address(RVA = "0x1395F20", Offset = "0x1394920", VA = "0x181395F20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0038
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			if (type_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600650D")]
		[Cpp2IlInjected.Address(RVA = "0x13957D0", Offset = "0x13941D0", VA = "0x1813957D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_005a
			string text = name_;
			int num = 0;
			int num2 = default(int);
			if (text.m_stringLength != num)
			{
				num2 = CodedOutputStream.ComputeStringSize(text) + 1;
			}
			SocialEventType socialEventType = type_;
			if (socialEventType != 0)
			{
				int num3 = CodedOutputStream.ComputeEnumSize((int)socialEventType);
				num3++;
				num2 += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num2 += num4;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600650E")]
		[Cpp2IlInjected.Address(RVA = "0x1395D40", Offset = "0x1394740", VA = "0x181395D40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NewsFeedEventPost other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				SocialEventType socialEventType = other.type_;
				if (socialEventType != 0)
				{
					type_ = socialEventType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600650F")]
		[Cpp2IlInjected.Address(RVA = "0x1395CA0", Offset = "0x13946A0", VA = "0x181395CA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Name = input.ReadString());
				}
				if (num == 16)
				{
					int num2 = (int)(type_ = (SocialEventType)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006510")]
		[Cpp2IlInjected.Address(RVA = "0x1395B40", Offset = "0x1394540", VA = "0x181395B40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = name_;
			}
			if (fieldNumber == 2)
			{
				SocialEventType socialEventType = type_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006511")]
		[Cpp2IlInjected.Address(RVA = "0x1395DB0", Offset = "0x13947B0", VA = "0x181395DB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (name_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				type_ = (SocialEventType)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006512")]
		[Cpp2IlInjected.Address(RVA = "0x13958A0", Offset = "0x13942A0", VA = "0x1813958A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0028: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				type_ = SocialEventType.PhonePrompt;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006513")]
		[Cpp2IlInjected.Address(RVA = "0x1395FB0", Offset = "0x13949B0", VA = "0x181395FB0")]
		static NewsFeedEventPost()
		{
			Func<NewsFeedEventPost> func = default(Func<NewsFeedEventPost>);
			_parser = (MessageParser<NewsFeedEventPost>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
