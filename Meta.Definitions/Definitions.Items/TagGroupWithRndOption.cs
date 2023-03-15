using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004DC")]
	public sealed class TagGroupWithRndOption : IMessage<TagGroupWithRndOption>, IMessage, IEquatable<TagGroupWithRndOption>, IDeepCloneable<TagGroupWithRndOption>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40019DC")]
		private static readonly MessageParser<TagGroupWithRndOption> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019DD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019DE")]
		public const int UseRandomFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019DF")]
		private bool useRandom_;

		[Cpp2IlInjected.Token(Token = "0x40019E0")]
		public const int TagsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40019E1")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019E2")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40019E3")]
		public const int TagTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40019E4")]
		private TagItemType tagType_;

		[Cpp2IlInjected.Token(Token = "0x17000F4B")]
		[DebuggerNonUserCode]
		public static MessageParser<TagGroupWithRndOption> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003BC0")]
			[Cpp2IlInjected.Address(RVA = "0x2562860", Offset = "0x2561260", VA = "0x182562860")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F4C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003BC1")]
			[Cpp2IlInjected.Address(RVA = "0x2562790", Offset = "0x2561190", VA = "0x182562790")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F4D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003BC2")]
			[Cpp2IlInjected.Address(RVA = "0x25628C0", Offset = "0x25612C0", VA = "0x1825628C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F4E")]
		[DebuggerNonUserCode]
		public bool UseRandom
		{
			[Cpp2IlInjected.Token(Token = "0x6003BC6")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useRandom_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BC7")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useRandom_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F4F")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6003BC8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F50")]
		[DebuggerNonUserCode]
		public TagItemType TagType
		{
			[Cpp2IlInjected.Token(Token = "0x6003BC9")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return tagType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BCA")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				tagType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2562600", Offset = "0x2561000", VA = "0x182562600")]
		[DebuggerNonUserCode]
		public TagGroupWithRndOption()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2562680", Offset = "0x2561080", VA = "0x182562680")]
		[DebuggerNonUserCode]
		public TagGroupWithRndOption(TagGroupWithRndOption other)
		{
			bool flag = (useRandom_ = other.useRandom_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			TagItemType tagItemType = (tagType_ = other.tagType_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2561C00", Offset = "0x2560600", VA = "0x182561C00", Slot = "10")]
		[DebuggerNonUserCode]
		public TagGroupWithRndOption Clone()
		{
			//Discarded unreachable code: IL_005b
			TagGroupWithRndOption tagGroupWithRndOption = new TagGroupWithRndOption();
			RepeatedField<int> repeatedField = (tagGroupWithRndOption.tags_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			bool flag = (tagGroupWithRndOption.useRandom_ = useRandom_);
			RepeatedField<int> repeatedField2 = (tagGroupWithRndOption.tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)tags_).Clone());
			TagItemType tagItemType = (tagGroupWithRndOption.tagType_ = tagType_);
			UnknownFieldSet unknownFieldSet = (tagGroupWithRndOption._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return tagGroupWithRndOption;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2561DD0", Offset = "0x25607D0", VA = "0x182561DD0", Slot = "0")]
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
				if ((IntPtr)(useRandom_ ? 1 : 0) == (IntPtr)typeof(TagGroupWithRndOption).TypeHandle)
				{
					RepeatedField<int> repeatedField = tags_;
					bool flag = default(bool);
					if (flag && tagType_ == (flag ? TagItemType.ApparelType : TagItemType.ApparelStyle))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2561D30", Offset = "0x2560730", VA = "0x182561D30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TagGroupWithRndOption other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useRandom_;
				if (useRandom_ == flag)
				{
					RepeatedField<int> repeatedField = tags_;
					RepeatedField<int> repeatedField2 = other.tags_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						TagItemType tagItemType = other.tagType_;
						if (tagType_ == tagItemType)
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

		[Cpp2IlInjected.Token(Token = "0x6003BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2561FC0", Offset = "0x25609C0", VA = "0x182561FC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0036
			if (useRandom_)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (tagType_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2562350", Offset = "0x2560D50", VA = "0x182562350", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003BCF")]
		[Cpp2IlInjected.Address(RVA = "0x25623B0", Offset = "0x2560DB0", VA = "0x1825623B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0048
			if (useRandom_)
			{
				bool value = useRandom_;
				output.WriteBool(value);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (tagType_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2561A70", Offset = "0x2560470", VA = "0x182561A70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			TagItemType tagItemType = tagType_;
			if (tagItemType != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)tagItemType);
				num2++;
				repeatedField = (RepeatedField<int>)(repeatedField + num2);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<int>)(repeatedField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD1")]
		[Cpp2IlInjected.Address(RVA = "0x25621A0", Offset = "0x2560BA0", VA = "0x1825621A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TagGroupWithRndOption other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				bool flag = other.useRandom_;
				if (flag)
				{
					useRandom_ = flag;
				}
				RepeatedField<int> repeatedField = tags_;
				RepeatedField<int> repeatedField2 = other.tags_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				TagItemType tagItemType = other.tagType_;
				if (tagItemType != 0)
				{
					tagType_ = tagItemType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2562080", Offset = "0x2560A80", VA = "0x182562080", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0073
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 18)
				{
					goto IL_0045;
				}
				if (num != 24)
				{
					goto IL_005c;
				}
				int num2 = (int)(tagType_ = (TagItemType)input.ReadInt32());
			}
			if (num == 8)
			{
				bool flag = (useRandom_ = input.ReadBool());
			}
			if (num == 16)
			{
				goto IL_0045;
			}
			goto IL_005c;
			IL_005c:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_0045:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_005c;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2561EC0", Offset = "0x25608C0", VA = "0x182561EC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					TagItemType tagItemType = tagType_;
				}
				RepeatedField<int> repeatedField = tags_;
			}
			bool flag = useRandom_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2562230", Offset = "0x2560C30", VA = "0x182562230", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0020
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					tagType_ = (TagItemType)obj;
					break;
				}
				case 0:
				{
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					/*Error: Unexpected end of block*/;
				}
				}
			}
			else
			{
				object obj2 = default(object);
				useRandom_ = (byte)(int)obj2 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2561B70", Offset = "0x2560570", VA = "0x182561B70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0029
			//IL_0019: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					tagType_ = TagItemType.ApparelStyle;
					return;
				case 0:
					break;
				default:
					return;
				}
				RepeatedField<int> repeatedField = tags_;
			}
			useRandom_ = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2562060", Offset = "0x2560A60", VA = "0x182562060")]
		public bool IsRandom(int mask, ref int randomFieldIndex)
		{
			while (useRandom_)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD7")]
		[Cpp2IlInjected.Address(RVA = "0x25624C0", Offset = "0x2560EC0", VA = "0x1825624C0")]
		static TagGroupWithRndOption()
		{
			Func<TagGroupWithRndOption> func = default(Func<TagGroupWithRndOption>);
			_parser = (MessageParser<TagGroupWithRndOption>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<TagGroupWithRndOption>)(object)FieldCodec.ForInt32(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
