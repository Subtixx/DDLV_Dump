using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000587")]
	public sealed class UniqueTagsFilter : IMessage<UniqueTagsFilter>, IMessage, IEquatable<UniqueTagsFilter>, IDeepCloneable<UniqueTagsFilter>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000588")]
		public enum FilterOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001DF5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001DF6")]
			UniqueTagsPerItemType,
			[Cpp2IlInjected.Token(Token = "0x4001DF7")]
			UniqueTagsPerGroup
		}

		[Cpp2IlInjected.Token(Token = "0x2000589")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200058A")]
			public sealed class TagList : IMessage<TagList>, IMessage, IEquatable<TagList>, IDeepCloneable<TagList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001DF8")]
				private static readonly MessageParser<TagList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001DF9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001DFA")]
				public const int TagsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4001DFB")]
				private static readonly FieldCodec<int> _repeated_tags_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001DFC")]
				private readonly RepeatedField<int> tags_;

				[Cpp2IlInjected.Token(Token = "0x170011C1")]
				[DebuggerNonUserCode]
				public static MessageParser<TagList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60044EE")]
					[Cpp2IlInjected.Address(RVA = "0x2379640", Offset = "0x2378040", VA = "0x182379640")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60044EF")]
					[Cpp2IlInjected.Address(RVA = "0x23795C0", Offset = "0x2377FC0", VA = "0x1823795C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60044F0")]
					[Cpp2IlInjected.Address(RVA = "0x23796A0", Offset = "0x23780A0", VA = "0x1823796A0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C4")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Tags
				{
					[Cpp2IlInjected.Token(Token = "0x60044F4")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60044F1")]
				[Cpp2IlInjected.Address(RVA = "0x2379540", Offset = "0x2377F40", VA = "0x182379540")]
				[DebuggerNonUserCode]
				public TagList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60044F2")]
				[Cpp2IlInjected.Address(RVA = "0x23794B0", Offset = "0x2377EB0", VA = "0x1823794B0")]
				[DebuggerNonUserCode]
				public TagList(TagList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60044F3")]
				[Cpp2IlInjected.Address(RVA = "0x2378DD0", Offset = "0x23777D0", VA = "0x182378DD0", Slot = "10")]
				[DebuggerNonUserCode]
				public TagList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60044F5")]
				[Cpp2IlInjected.Address(RVA = "0x2378F20", Offset = "0x2377920", VA = "0x182378F20", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60044F6")]
				[Cpp2IlInjected.Address(RVA = "0x2378E90", Offset = "0x2377890", VA = "0x182378E90", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TagList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60044F7")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60044F8")]
				[Cpp2IlInjected.Address(RVA = "0x2379250", Offset = "0x2377C50", VA = "0x182379250", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60044F9")]
				[Cpp2IlInjected.Address(RVA = "0x23792B0", Offset = "0x2377CB0", VA = "0x1823792B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60044FA")]
				[Cpp2IlInjected.Address(RVA = "0x2378CC0", Offset = "0x23776C0", VA = "0x182378CC0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60044FB")]
				[Cpp2IlInjected.Address(RVA = "0x2379080", Offset = "0x2377A80", VA = "0x182379080", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TagList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60044FC")]
				[Cpp2IlInjected.Address(RVA = "0x2379100", Offset = "0x2377B00", VA = "0x182379100", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60044FD")]
				[Cpp2IlInjected.Address(RVA = "0x2379000", Offset = "0x2377A00", VA = "0x182379000", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60044FE")]
				[Cpp2IlInjected.Address(RVA = "0x23791F0", Offset = "0x2377BF0", VA = "0x1823791F0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60044FF")]
				[Cpp2IlInjected.Address(RVA = "0x2378D70", Offset = "0x2377770", VA = "0x182378D70", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001DEE")]
		private static readonly MessageParser<UniqueTagsFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001DEF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001DF0")]
		public const int UniqueTagsPerItemTypeFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001DF1")]
		public const int UniqueTagsPerGroupFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DF2")]
		private object filter_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DF3")]
		private FilterOneofCase filterCase_;

		[Cpp2IlInjected.Token(Token = "0x170011BB")]
		[DebuggerNonUserCode]
		public static MessageParser<UniqueTagsFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60044D4")]
			[Cpp2IlInjected.Address(RVA = "0x35551D0", Offset = "0x3553BD0", VA = "0x1835551D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011BC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60044D5")]
			[Cpp2IlInjected.Address(RVA = "0x3555100", Offset = "0x3553B00", VA = "0x183555100")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011BD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60044D6")]
			[Cpp2IlInjected.Address(RVA = "0x3555300", Offset = "0x3553D00", VA = "0x183555300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011BE")]
		[DebuggerNonUserCode]
		public TagItemType UniqueTagsPerItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60044DA")]
			[Cpp2IlInjected.Address(RVA = "0x3555290", Offset = "0x3553C90", VA = "0x183555290")]
			get
			{
				if (filterCase_ == FilterOneofCase.UniqueTagsPerItemType)
				{
					object obj = filter_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60044DB")]
			[Cpp2IlInjected.Address(RVA = "0x3555410", Offset = "0x3553E10", VA = "0x183555410")]
			set
			{
				//IL_0016: Expected I4, but got I8
				filter_ = typeof(TagItemType).TypeHandle;
				filterCase_ = FilterOneofCase.UniqueTagsPerItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011BF")]
		[DebuggerNonUserCode]
		public Types.TagList UniqueTagsPerGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60044DC")]
			[Cpp2IlInjected.Address(RVA = "0x3555230", Offset = "0x3553C30", VA = "0x183555230")]
			get
			{
				int num = 0;
				if (filterCase_ == FilterOneofCase.UniqueTagsPerGroup)
				{
					object obj = filter_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60044DD")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				filter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011C0")]
		[DebuggerNonUserCode]
		public FilterOneofCase FilterCase
		{
			[Cpp2IlInjected.Token(Token = "0x60044DE")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return filterCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044D7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UniqueTagsFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60044D8")]
		[Cpp2IlInjected.Address(RVA = "0x3554FD0", Offset = "0x35539D0", VA = "0x183554FD0")]
		[DebuggerNonUserCode]
		public UniqueTagsFilter(UniqueTagsFilter other)
		{
			//IL_002c: Expected I4, but got I8
			//IL_004e: Expected I4, but got O
			FilterOneofCase filterOneofCase = other.filterCase_;
			if (filterOneofCase == FilterOneofCase.UniqueTagsPerItemType)
			{
				int uniqueTagsPerItemType = (int)other.UniqueTagsPerItemType;
				filter_ = typeof(TagItemType).TypeHandle;
				filterCase_ = FilterOneofCase.UniqueTagsPerItemType;
			}
			if (filterOneofCase == FilterOneofCase.UniqueTagsPerGroup)
			{
				FilterOneofCase filterOneofCase2 = other.filterCase_;
				if (other.filter_ == null)
				{
					throw new InvalidCastException();
				}
				Types.TagList tagList = default(Types.TagList);
				filter_ = tagList;
				filterCase_ = (FilterOneofCase)tagList;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044D9")]
		[Cpp2IlInjected.Address(RVA = "0x35543D0", Offset = "0x3552DD0", VA = "0x1835543D0", Slot = "10")]
		[DebuggerNonUserCode]
		public UniqueTagsFilter Clone()
		{
			//Discarded unreachable code: IL_0067
			//IL_002c: Expected I4, but got I8
			//IL_0050: Expected I4, but got O
			UniqueTagsFilter uniqueTagsFilter = new UniqueTagsFilter();
			FilterOneofCase filterOneofCase = filterCase_;
			if (filterOneofCase == FilterOneofCase.UniqueTagsPerItemType)
			{
				int uniqueTagsPerItemType = (int)UniqueTagsPerItemType;
				uniqueTagsFilter.filter_ = typeof(TagItemType).TypeHandle;
				uniqueTagsFilter.filterCase_ = FilterOneofCase.UniqueTagsPerItemType;
			}
			if (filterOneofCase == FilterOneofCase.UniqueTagsPerGroup)
			{
				FilterOneofCase filterOneofCase2 = filterCase_;
				if (filter_ == null)
				{
					throw new InvalidCastException();
				}
				Types.TagList tagList = default(Types.TagList);
				uniqueTagsFilter.filter_ = tagList;
				uniqueTagsFilter.filterCase_ = (FilterOneofCase)tagList;
			}
			UnknownFieldSet unknownFieldSet = (uniqueTagsFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return uniqueTagsFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60044DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearFilter()
		{
			//IL_0010: Expected O, but got I4
			filter_ = (filterCase_ = FilterOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044E0")]
		[Cpp2IlInjected.Address(RVA = "0x35545E0", Offset = "0x3552FE0", VA = "0x1835545E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				TagItemType tagItemType = default(TagItemType);
				if (UniqueTagsPerItemType == tagItemType)
				{
					Types.TagList objB = default(Types.TagList);
					bool flag = object.Equals(UniqueTagsPerGroup, objB);
					if (flag && filterCase_ == (flag ? FilterOneofCase.UniqueTagsPerItemType : FilterOneofCase.None))
					{
						return object.Equals(_unknownFields, objB);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044E1")]
		[Cpp2IlInjected.Address(RVA = "0x3554530", Offset = "0x3552F30", VA = "0x183554530", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UniqueTagsFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int uniqueTagsPerItemType = (int)UniqueTagsPerItemType;
				TagItemType uniqueTagsPerItemType2 = other.UniqueTagsPerItemType;
				if (uniqueTagsPerItemType == (int)uniqueTagsPerItemType2)
				{
					Types.TagList uniqueTagsPerGroup = UniqueTagsPerGroup;
					Types.TagList uniqueTagsPerGroup2 = other.UniqueTagsPerGroup;
					if (object.Equals(uniqueTagsPerGroup, uniqueTagsPerGroup2))
					{
						FilterOneofCase filterOneofCase = other.filterCase_;
						if (filterCase_ == filterOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x60044E2")]
		[Cpp2IlInjected.Address(RVA = "0x35547E0", Offset = "0x35531E0", VA = "0x1835547E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004e
			int num = 0;
			if (filterCase_ == FilterOneofCase.UniqueTagsPerItemType)
			{
				if (filterCase_ != FilterOneofCase.UniqueTagsPerItemType)
				{
				}
				object obj = filter_;
			}
			if (filterCase_ == FilterOneofCase.UniqueTagsPerGroup)
			{
				object obj2 = filter_;
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

		[Cpp2IlInjected.Token(Token = "0x60044E3")]
		[Cpp2IlInjected.Address(RVA = "0x3554D80", Offset = "0x3553780", VA = "0x183554D80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60044E4")]
		[Cpp2IlInjected.Address(RVA = "0x3554DE0", Offset = "0x35537E0", VA = "0x183554DE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0048
			FilterOneofCase filterOneofCase = filterCase_;
			if (filterOneofCase == FilterOneofCase.UniqueTagsPerItemType)
			{
				int uniqueTagsPerItemType = (int)UniqueTagsPerItemType;
				output.WriteInt32(uniqueTagsPerItemType);
			}
			if (filterOneofCase == FilterOneofCase.UniqueTagsPerGroup && filterCase_ == FilterOneofCase.UniqueTagsPerGroup)
			{
				object obj = filter_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60044E5")]
		[Cpp2IlInjected.Address(RVA = "0x3554170", Offset = "0x3552B70", VA = "0x183554170", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (filterCase_ == FilterOneofCase.UniqueTagsPerItemType)
			{
				if (filterCase_ == FilterOneofCase.UniqueTagsPerItemType)
				{
					object obj = filter_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			if (filterCase_ == FilterOneofCase.UniqueTagsPerGroup)
			{
				if (filterCase_ == FilterOneofCase.UniqueTagsPerGroup)
				{
					object obj2 = filter_;
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

		[Cpp2IlInjected.Token(Token = "0x60044E6")]
		[Cpp2IlInjected.Address(RVA = "0x35549C0", Offset = "0x35533C0", VA = "0x1835549C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UniqueTagsFilter other)
		{
			if (other == null)
			{
				return;
			}
			if (other.filterCase_ == FilterOneofCase.UniqueTagsPerItemType)
			{
				TagItemType uniqueTagsPerItemType = other.UniqueTagsPerItemType;
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(Types.TagList).TypeHandle != 2)
			{
			}
			Types.TagList tagList = default(Types.TagList);
			if (tagList == null)
			{
				Types.TagList tagList2 = new Types.TagList();
			}
			Types.TagList uniqueTagsPerGroup = other.UniqueTagsPerGroup;
			Types.TagList tagList3 = default(Types.TagList);
			tagList3.MergeFrom(uniqueTagsPerGroup);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044E7")]
		[Cpp2IlInjected.Address(RVA = "0x3554AD0", Offset = "0x35534D0", VA = "0x183554AD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0022: Expected O, but got I4
			//IL_002b: Expected I4, but got I8
			//IL_0071: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = input.ReadInt32();
				filter_ = num2;
				filterCase_ = FilterOneofCase.UniqueTagsPerItemType;
			}
			if (num == 18)
			{
				Types.TagList builder = new Types.TagList();
				if (filterCase_ == FilterOneofCase.UniqueTagsPerGroup)
				{
					if (filterCase_ != FilterOneofCase.UniqueTagsPerGroup)
					{
					}
					object obj = filter_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				filter_ = builder;
				filterCase_ = (FilterOneofCase)typeof(Types.TagList).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60044E8")]
		[Cpp2IlInjected.Address(RVA = "0x35546D0", Offset = "0x35530D0", VA = "0x1835546D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				TagItemType uniqueTagsPerItemType = UniqueTagsPerItemType;
			}
			if (fieldNumber == 2)
			{
				while (filterCase_ != FilterOneofCase.UniqueTagsPerGroup)
				{
				}
				object obj = filter_;
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

		[Cpp2IlInjected.Token(Token = "0x60044E9")]
		[Cpp2IlInjected.Address(RVA = "0x3554C50", Offset = "0x3553650", VA = "0x183554C50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0018: Expected I4, but got I8
			//IL_0037: Expected I4, but got O
			if (fieldNumber == 1)
			{
				filter_ = typeof(TagItemType).TypeHandle;
				filterCase_ = FilterOneofCase.UniqueTagsPerItemType;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				filter_ = value;
				filterCase_ = (FilterOneofCase)typeof(Types.TagList).TypeHandle;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044EA")]
		[Cpp2IlInjected.Address(RVA = "0x35542D0", Offset = "0x3552CD0", VA = "0x1835542D0", Slot = "13")]
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
				TagItemType tagItemType = default(TagItemType);
				filter_ = tagItemType;
				filterCase_ = FilterOneofCase.UniqueTagsPerItemType;
				break;
			}
			case 2:
				filterCase_ = FilterOneofCase.None;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044EB")]
		[Cpp2IlInjected.Address(RVA = "0x3554910", Offset = "0x3553310", VA = "0x183554910", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Filter"))
			{
				FilterOneofCase filterOneofCase = filterCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044EC")]
		[Cpp2IlInjected.Address(RVA = "0x3554360", Offset = "0x3552D60", VA = "0x183554360", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Filter"))
			{
				filter_ = (filterCase_ = FilterOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044ED")]
		[Cpp2IlInjected.Address(RVA = "0x3554EC0", Offset = "0x35538C0", VA = "0x183554EC0")]
		static UniqueTagsFilter()
		{
			Func<UniqueTagsFilter> func = default(Func<UniqueTagsFilter>);
			_parser = (MessageParser<UniqueTagsFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
