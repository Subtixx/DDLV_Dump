using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x200072D")]
	public sealed class TrimmingSupportType : IHasTags, IMessage<TrimmingSupportType>, IMessage, IEquatable<TrimmingSupportType>, IDeepCloneable<TrimmingSupportType>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023FA")]
		public static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x40023FB")]
		private static readonly MessageParser<TrimmingSupportType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023FC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023FD")]
		public const int TagsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023FE")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023FF")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002400")]
		public const int MainPrefabAddressFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002401")]
		private string mainPrefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001447")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004F8C")]
			[Cpp2IlInjected.Address(RVA = "0x3553AD0", Offset = "0x35524D0", VA = "0x183553AD0", Slot = "4")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001448")]
		[DebuggerNonUserCode]
		public static MessageParser<TrimmingSupportType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F8D")]
			[Cpp2IlInjected.Address(RVA = "0x3553A70", Offset = "0x3552470", VA = "0x183553A70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001449")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F8E")]
			[Cpp2IlInjected.Address(RVA = "0x35539A0", Offset = "0x35523A0", VA = "0x1835539A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F8F")]
			[Cpp2IlInjected.Address(RVA = "0x3553B30", Offset = "0x3552530", VA = "0x183553B30", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144B")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6004F93")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "5")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144C")]
		[DebuggerNonUserCode]
		public string MainPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004F94")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return mainPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F95")]
			[Cpp2IlInjected.Address(RVA = "0x3553C40", Offset = "0x3552640", VA = "0x183553C40")]
			set
			{
				string text = (mainPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F90")]
		[Cpp2IlInjected.Address(RVA = "0x3553900", Offset = "0x3552300", VA = "0x183553900")]
		[DebuggerNonUserCode]
		public TrimmingSupportType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F91")]
		[Cpp2IlInjected.Address(RVA = "0x35537D0", Offset = "0x35521D0", VA = "0x1835537D0")]
		[DebuggerNonUserCode]
		public TrimmingSupportType(TrimmingSupportType other)
		{
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			string text = (mainPrefabAddress_ = other.mainPrefabAddress_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F92")]
		[Cpp2IlInjected.Address(RVA = "0x3552E90", Offset = "0x3551890", VA = "0x183552E90", Slot = "12")]
		[DebuggerNonUserCode]
		public TrimmingSupportType Clone()
		{
			//Discarded unreachable code: IL_0056
			TrimmingSupportType trimmingSupportType = new TrimmingSupportType();
			RepeatedField<int> repeatedField = (trimmingSupportType.tags_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			trimmingSupportType.mainPrefabAddress_ = "";
			RepeatedField<int> repeatedField2 = (trimmingSupportType.tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)tags_).Clone());
			string text = (trimmingSupportType.mainPrefabAddress_ = mainPrefabAddress_);
			UnknownFieldSet unknownFieldSet = (trimmingSupportType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return trimmingSupportType;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F96")]
		[Cpp2IlInjected.Address(RVA = "0x3552FF0", Offset = "0x35519F0", VA = "0x183552FF0", Slot = "0")]
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
				RepeatedField<int> repeatedField = tags_;
				bool flag = default(bool);
				if (flag)
				{
					string text = mainPrefabAddress_;
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

		[Cpp2IlInjected.Token(Token = "0x6004F97")]
		[Cpp2IlInjected.Address(RVA = "0x35530E0", Offset = "0x3551AE0", VA = "0x1835530E0", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(TrimmingSupportType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = tags_;
				RepeatedField<int> repeatedField2 = other.tags_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					string text = other.mainPrefabAddress_;
					if (!(mainPrefabAddress_ != text))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F98")]
		[Cpp2IlInjected.Address(RVA = "0x273F5D0", Offset = "0x273DFD0", VA = "0x18273F5D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003c
			int hashCode = ((RepeatedField<T>)(object)tags_).GetHashCode();
			string text = mainPrefabAddress_;
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

		[Cpp2IlInjected.Token(Token = "0x6004F99")]
		[Cpp2IlInjected.Address(RVA = "0x35534A0", Offset = "0x3551EA0", VA = "0x1835534A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9A")]
		[Cpp2IlInjected.Address(RVA = "0x3553500", Offset = "0x3551F00", VA = "0x183553500", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0044
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (mainPrefabAddress_.m_stringLength != 0)
			{
				string value = mainPrefabAddress_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9B")]
		[Cpp2IlInjected.Address(RVA = "0x3552D00", Offset = "0x3551700", VA = "0x183552D00", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			string text = mainPrefabAddress_;
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

		[Cpp2IlInjected.Token(Token = "0x6004F9C")]
		[Cpp2IlInjected.Address(RVA = "0x3553220", Offset = "0x3551C20", VA = "0x183553220", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(TrimmingSupportType other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<int> repeatedField = tags_;
				RepeatedField<int> repeatedField2 = other.tags_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				string text = other.mainPrefabAddress_;
				if (text.m_stringLength != 0)
				{
					MainPrefabAddress = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9D")]
		[Cpp2IlInjected.Address(RVA = "0x35532C0", Offset = "0x3551CC0", VA = "0x1835532C0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0059
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((long)input != 4294967293L)
			{
				if (num == 18)
				{
					string text2 = (MainPrefabAddress = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9E")]
		[Cpp2IlInjected.Address(RVA = "0x3553190", Offset = "0x3551B90", VA = "0x183553190", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = tags_;
			}
			if (fieldNumber == 2)
			{
				string text = mainPrefabAddress_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9F")]
		[Cpp2IlInjected.Address(RVA = "0x35533D0", Offset = "0x3551DD0", VA = "0x1835533D0", Slot = "14")]
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
					MainPrefabAddress = (string)num;
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

		[Cpp2IlInjected.Token(Token = "0x6004FA0")]
		[Cpp2IlInjected.Address(RVA = "0x3552E00", Offset = "0x3551800", VA = "0x183552E00", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_001b
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = tags_;
			}
			if (fieldNumber == 2)
			{
				MainPrefabAddress = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA1")]
		[Cpp2IlInjected.Address(RVA = "0x35535F0", Offset = "0x3551FF0", VA = "0x1835535F0")]
		static TrimmingSupportType()
		{
			//Discarded unreachable code: IL_003b
			//IL_0011: Expected O, but got I4
			(TagItemType, int?)[] CS_0024_003C_003E8__locals0 = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)CS_0024_003C_003E8__locals0)[1] = (ValueTuple<, >)num;
			usedTagTypes = CS_0024_003C_003E8__locals0;
			usedTagTypes = ((TagItemType tagType, int? limit)[])(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new TrimmingSupportType()));
			usedTagTypes = ((TagItemType tagType, int? limit)[])(object)FieldCodec.ForInt32(10u);
		}
	}
}
