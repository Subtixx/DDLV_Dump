using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Keyholes
{
	[Cpp2IlInjected.Token(Token = "0x2000270")]
	public sealed class Keyhole : IMessage<Keyhole>, IMessage, IEquatable<Keyhole>, IDeepCloneable<Keyhole>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40009A0")]
		private static readonly MessageParser<Keyhole> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009A1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009A2")]
		public const int ContentFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40009A3")]
		private static readonly FieldCodec<KeyholeContent> _repeated_content_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009A4")]
		private readonly RepeatedField<KeyholeContent> content_ = (RepeatedField<KeyholeContent>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40009A5")]
		public const int GUIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009A6")]
		private string gUID_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700051F")]
		[DebuggerNonUserCode]
		public static MessageParser<Keyhole> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600172D")]
			[Cpp2IlInjected.Address(RVA = "0x273FE90", Offset = "0x273E890", VA = "0x18273FE90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000520")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600172E")]
			[Cpp2IlInjected.Address(RVA = "0x273FDC0", Offset = "0x273E7C0", VA = "0x18273FDC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000521")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600172F")]
			[Cpp2IlInjected.Address(RVA = "0x273FEF0", Offset = "0x273E8F0", VA = "0x18273FEF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000522")]
		[DebuggerNonUserCode]
		public RepeatedField<KeyholeContent> Content
		{
			[Cpp2IlInjected.Token(Token = "0x6001733")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return content_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000523")]
		[DebuggerNonUserCode]
		public string GUID
		{
			[Cpp2IlInjected.Token(Token = "0x6001734")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return gUID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001735")]
			[Cpp2IlInjected.Address(RVA = "0x2740000", Offset = "0x273EA00", VA = "0x182740000")]
			set
			{
				string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001730")]
		[Cpp2IlInjected.Address(RVA = "0x273FD20", Offset = "0x273E720", VA = "0x18273FD20")]
		[DebuggerNonUserCode]
		public Keyhole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001731")]
		[Cpp2IlInjected.Address(RVA = "0x273FBF0", Offset = "0x273E5F0", VA = "0x18273FBF0")]
		[DebuggerNonUserCode]
		public Keyhole(Keyhole other)
		{
			RepeatedField<KeyholeContent> repeatedField = (content_ = (RepeatedField<KeyholeContent>)(object)((RepeatedField<T>)(object)other.content_).Clone());
			string text = (gUID_ = other.gUID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001732")]
		[Cpp2IlInjected.Address(RVA = "0x273F240", Offset = "0x273DC40", VA = "0x18273F240", Slot = "10")]
		[DebuggerNonUserCode]
		public Keyhole Clone()
		{
			//Discarded unreachable code: IL_0056
			Keyhole keyhole = new Keyhole();
			RepeatedField<KeyholeContent> repeatedField = (keyhole.content_ = (RepeatedField<KeyholeContent>)(object)new RepeatedField<T>());
			keyhole.gUID_ = "";
			RepeatedField<KeyholeContent> repeatedField2 = (keyhole.content_ = (RepeatedField<KeyholeContent>)(object)((RepeatedField<T>)(object)content_).Clone());
			string text = (keyhole.gUID_ = gUID_);
			UnknownFieldSet unknownFieldSet = (keyhole._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return keyhole;
		}

		[Cpp2IlInjected.Token(Token = "0x6001736")]
		[Cpp2IlInjected.Address(RVA = "0x273F3A0", Offset = "0x273DDA0", VA = "0x18273F3A0", Slot = "0")]
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
				RepeatedField<KeyholeContent> repeatedField = content_;
				bool flag = default(bool);
				if (flag)
				{
					string text = gUID_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001737")]
		[Cpp2IlInjected.Address(RVA = "0x273F490", Offset = "0x273DE90", VA = "0x18273F490", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Keyhole other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<KeyholeContent> repeatedField = content_;
				RepeatedField<KeyholeContent> repeatedField2 = other.content_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					string text = other.gUID_;
					if (!(gUID_ != text))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001738")]
		[Cpp2IlInjected.Address(RVA = "0x273F5D0", Offset = "0x273DFD0", VA = "0x18273F5D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003c
			int hashCode = ((RepeatedField<T>)(object)content_).GetHashCode();
			string text = gUID_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6001739")]
		[Cpp2IlInjected.Address(RVA = "0x273F8D0", Offset = "0x273E2D0", VA = "0x18273F8D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600173A")]
		[Cpp2IlInjected.Address(RVA = "0x273F930", Offset = "0x273E330", VA = "0x18273F930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0044
			RepeatedField<KeyholeContent> repeatedField = content_;
			FieldCodec<KeyholeContent> repeated_content_codec = _repeated_content_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_content_codec);
			if (gUID_.m_stringLength != 0)
			{
				string value = gUID_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600173B")]
		[Cpp2IlInjected.Address(RVA = "0x273F0B0", Offset = "0x273DAB0", VA = "0x18273F0B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			RepeatedField<KeyholeContent> repeatedField = content_;
			FieldCodec<KeyholeContent> repeated_content_codec = _repeated_content_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_content_codec);
			string text = gUID_;
			if (text.m_stringLength != 0)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
				num += num2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600173C")]
		[Cpp2IlInjected.Address(RVA = "0x273F760", Offset = "0x273E160", VA = "0x18273F760", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Keyhole other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<KeyholeContent> repeatedField = content_;
				RepeatedField<KeyholeContent> repeatedField2 = other.content_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				string text = other.gUID_;
				if (text.m_stringLength != 0)
				{
					GUID = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600173D")]
		[Cpp2IlInjected.Address(RVA = "0x273F650", Offset = "0x273E050", VA = "0x18273F650", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0052
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<KeyholeContent> repeatedField = content_;
					FieldCodec<KeyholeContent> repeated_content_codec = _repeated_content_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_content_codec);
				}
				if (num == 18)
				{
					string text2 = (GUID = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600173E")]
		[Cpp2IlInjected.Address(RVA = "0x273F540", Offset = "0x273DF40", VA = "0x18273F540", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<KeyholeContent> repeatedField = content_;
			}
			if (fieldNumber == 2)
			{
				string text = gUID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600173F")]
		[Cpp2IlInjected.Address(RVA = "0x273F800", Offset = "0x273E200", VA = "0x18273F800", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			switch (fieldNumber)
			{
			case 2:
			{
				int num = 0;
				if (value == null || value != null)
				{
					GUID = (string)num;
					break;
				}
				throw new InvalidCastException();
			}
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001740")]
		[Cpp2IlInjected.Address(RVA = "0x273F1B0", Offset = "0x273DBB0", VA = "0x18273F1B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_001b
			if (fieldNumber == 1)
			{
				RepeatedField<KeyholeContent> repeatedField = content_;
			}
			if (fieldNumber == 2)
			{
				GUID = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001741")]
		[Cpp2IlInjected.Address(RVA = "0x273FA20", Offset = "0x273E420", VA = "0x18273FA20")]
		static Keyhole()
		{
			Func<Keyhole> func = default(Func<Keyhole>);
			_parser = (MessageParser<Keyhole>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<KeyholeContent> parser = KeyholeContent._parser;
			uint num = default(uint);
			_parser = (MessageParser<Keyhole>)(object)FieldCodec.ForMessage<KeyholeContent>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
