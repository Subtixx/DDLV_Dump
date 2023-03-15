using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000728")]
	public sealed class FurnitureSupportType : IHasTags, IMessage<FurnitureSupportType>, IMessage, IEquatable<FurnitureSupportType>, IDeepCloneable<FurnitureSupportType>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000729")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200072A")]
			public sealed class AreaFilterData : IMessage<AreaFilterData>, IMessage, IEquatable<AreaFilterData>, IDeepCloneable<AreaFilterData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40023F0")]
				private static readonly MessageParser<AreaFilterData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40023F1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40023F2")]
				public const int MinAreaSizeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40023F3")]
				private AreaSize minAreaSize_;

				[Cpp2IlInjected.Token(Token = "0x40023F4")]
				public const int MaxAreaSizeFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40023F5")]
				private AreaSize maxAreaSize_;

				[Cpp2IlInjected.Token(Token = "0x40023F6")]
				public const int MainPrefabAddressFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40023F7")]
				private string mainPrefabAddress_;

				[Cpp2IlInjected.Token(Token = "0x17001441")]
				[DebuggerNonUserCode]
				public static MessageParser<AreaFilterData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004F6E")]
					[Cpp2IlInjected.Address(RVA = "0x2939620", Offset = "0x2938020", VA = "0x182939620")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001442")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004F6F")]
					[Cpp2IlInjected.Address(RVA = "0x29395A0", Offset = "0x2937FA0", VA = "0x1829395A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001443")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004F70")]
					[Cpp2IlInjected.Address(RVA = "0x2939680", Offset = "0x2938080", VA = "0x182939680", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001444")]
				[DebuggerNonUserCode]
				public AreaSize MinAreaSize
				{
					[Cpp2IlInjected.Token(Token = "0x6004F74")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004F75")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001445")]
				[DebuggerNonUserCode]
				public AreaSize MaxAreaSize
				{
					[Cpp2IlInjected.Token(Token = "0x6004F76")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004F77")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001446")]
				[DebuggerNonUserCode]
				public string MainPrefabAddress
				{
					[Cpp2IlInjected.Token(Token = "0x6004F78")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004F79")]
					[Cpp2IlInjected.Address(RVA = "0x2939740", Offset = "0x2938140", VA = "0x182939740")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004F71")]
				[Cpp2IlInjected.Address(RVA = "0x2939550", Offset = "0x2937F50", VA = "0x182939550")]
				[DebuggerNonUserCode]
				public AreaFilterData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F72")]
				[Cpp2IlInjected.Address(RVA = "0x2939460", Offset = "0x2937E60", VA = "0x182939460")]
				[DebuggerNonUserCode]
				public AreaFilterData(AreaFilterData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F73")]
				[Cpp2IlInjected.Address(RVA = "0x2938AD0", Offset = "0x29374D0", VA = "0x182938AD0", Slot = "10")]
				[DebuggerNonUserCode]
				public AreaFilterData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004F7A")]
				[Cpp2IlInjected.Address(RVA = "0x2938C80", Offset = "0x2937680", VA = "0x182938C80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F7B")]
				[Cpp2IlInjected.Address(RVA = "0x2938BF0", Offset = "0x29375F0", VA = "0x182938BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(AreaFilterData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F7C")]
				[Cpp2IlInjected.Address(RVA = "0x2938E00", Offset = "0x2937800", VA = "0x182938E00", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F7D")]
				[Cpp2IlInjected.Address(RVA = "0x2939230", Offset = "0x2937C30", VA = "0x182939230", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004F7E")]
				[Cpp2IlInjected.Address(RVA = "0x2939290", Offset = "0x2937C90", VA = "0x182939290", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F7F")]
				[Cpp2IlInjected.Address(RVA = "0x2938950", Offset = "0x2937350", VA = "0x182938950", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F80")]
				[Cpp2IlInjected.Address(RVA = "0x2938FF0", Offset = "0x29379F0", VA = "0x182938FF0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(AreaFilterData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F81")]
				[Cpp2IlInjected.Address(RVA = "0x2938EA0", Offset = "0x29378A0", VA = "0x182938EA0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F82")]
				[Cpp2IlInjected.Address(RVA = "0x2938D60", Offset = "0x2937760", VA = "0x182938D60", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004F83")]
				[Cpp2IlInjected.Address(RVA = "0x2939130", Offset = "0x2937B30", VA = "0x182939130", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F84")]
				[Cpp2IlInjected.Address(RVA = "0x2938A50", Offset = "0x2937450", VA = "0x182938A50", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40023E7")]
		public static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x40023E8")]
		private static readonly MessageParser<FurnitureSupportType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023E9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023EA")]
		public const int TagsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023EB")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023EC")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40023ED")]
		public const int FilterDataFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40023EE")]
		private static readonly FieldCodec<Types.AreaFilterData> _repeated_filterData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023EF")]
		private readonly RepeatedField<Types.AreaFilterData> filterData_ = (RepeatedField<Types.AreaFilterData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700143B")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004F59")]
			[Cpp2IlInjected.Address(RVA = "0x21876A0", Offset = "0x21860A0", VA = "0x1821876A0", Slot = "4")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143C")]
		[DebuggerNonUserCode]
		public static MessageParser<FurnitureSupportType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F5A")]
			[Cpp2IlInjected.Address(RVA = "0x2187640", Offset = "0x2186040", VA = "0x182187640")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F5B")]
			[Cpp2IlInjected.Address(RVA = "0x2187570", Offset = "0x2185F70", VA = "0x182187570")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F5C")]
			[Cpp2IlInjected.Address(RVA = "0x2187700", Offset = "0x2186100", VA = "0x182187700", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143F")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6004F60")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "5")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001440")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.AreaFilterData> FilterData
		{
			[Cpp2IlInjected.Token(Token = "0x6004F61")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return filterData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5D")]
		[Cpp2IlInjected.Address(RVA = "0x2187330", Offset = "0x2185D30", VA = "0x182187330")]
		[DebuggerNonUserCode]
		public FurnitureSupportType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5E")]
		[Cpp2IlInjected.Address(RVA = "0x21873F0", Offset = "0x2185DF0", VA = "0x1821873F0")]
		[DebuggerNonUserCode]
		public FurnitureSupportType(FurnitureSupportType other)
		{
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			RepeatedField<Types.AreaFilterData> repeatedField2 = (filterData_ = (RepeatedField<Types.AreaFilterData>)(object)((RepeatedField<T>)(object)other.filterData_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5F")]
		[Cpp2IlInjected.Address(RVA = "0x2186890", Offset = "0x2185290", VA = "0x182186890", Slot = "12")]
		[DebuggerNonUserCode]
		public FurnitureSupportType Clone()
		{
			//Discarded unreachable code: IL_005f
			FurnitureSupportType furnitureSupportType = new FurnitureSupportType();
			RepeatedField<int> repeatedField = (furnitureSupportType.tags_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<Types.AreaFilterData> repeatedField2 = (furnitureSupportType.filterData_ = (RepeatedField<Types.AreaFilterData>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField3 = (furnitureSupportType.tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)tags_).Clone());
			RepeatedField<Types.AreaFilterData> repeatedField4 = (furnitureSupportType.filterData_ = (RepeatedField<Types.AreaFilterData>)(object)((RepeatedField<T>)(object)filterData_).Clone());
			UnknownFieldSet unknownFieldSet = (furnitureSupportType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return furnitureSupportType;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F62")]
		[Cpp2IlInjected.Address(RVA = "0x2186A40", Offset = "0x2185440", VA = "0x182186A40", Slot = "0")]
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
					RepeatedField<Types.AreaFilterData> repeatedField2 = filterData_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F63")]
		[Cpp2IlInjected.Address(RVA = "0x2186B40", Offset = "0x2185540", VA = "0x182186B40", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(FurnitureSupportType other)
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
					RepeatedField<Types.AreaFilterData> repeatedField3 = filterData_;
					RepeatedField<Types.AreaFilterData> repeatedField4 = other.filterData_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F64")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((RepeatedField<T>)(object)tags_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)filterData_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F65")]
		[Cpp2IlInjected.Address(RVA = "0x2186F40", Offset = "0x2185940", VA = "0x182186F40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F66")]
		[Cpp2IlInjected.Address(RVA = "0x2186FA0", Offset = "0x21859A0", VA = "0x182186FA0", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			RepeatedField<Types.AreaFilterData> repeatedField2 = filterData_;
			FieldCodec<Types.AreaFilterData> repeated_filterData_codec = _repeated_filterData_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_filterData_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F67")]
		[Cpp2IlInjected.Address(RVA = "0x2186730", Offset = "0x2185130", VA = "0x182186730", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			RepeatedField<Types.AreaFilterData> repeatedField2 = filterData_;
			FieldCodec<Types.AreaFilterData> repeated_filterData_codec = _repeated_filterData_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_filterData_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<int>)(repeatedField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F68")]
		[Cpp2IlInjected.Address(RVA = "0x2186DF0", Offset = "0x21857F0", VA = "0x182186DF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(FurnitureSupportType other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<int> repeatedField = tags_;
				RepeatedField<int> repeatedField2 = other.tags_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<Types.AreaFilterData> repeatedField3 = filterData_;
				RepeatedField<Types.AreaFilterData> repeatedField4 = other.filterData_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F69")]
		[Cpp2IlInjected.Address(RVA = "0x2186C90", Offset = "0x2185690", VA = "0x182186C90", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0062
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((long)input != 4294967293L)
			{
				if (num == 18)
				{
					RepeatedField<Types.AreaFilterData> repeatedField = filterData_;
					FieldCodec<Types.AreaFilterData> repeated_filterData_codec = _repeated_filterData_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_filterData_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
			RepeatedField<int> repeatedField2 = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6A")]
		[Cpp2IlInjected.Address(RVA = "0x2186C00", Offset = "0x2185600", VA = "0x182186C00", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = tags_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.AreaFilterData> repeatedField2 = filterData_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6B")]
		[Cpp2IlInjected.Address(RVA = "0x2186E90", Offset = "0x2185890", VA = "0x182186E90", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			switch (fieldNumber)
			{
			default:
				return;
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			case 2:
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6C")]
		[Cpp2IlInjected.Address(RVA = "0x2186820", Offset = "0x2185220", VA = "0x182186820", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.AreaFilterData> repeatedField = filterData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6D")]
		[Cpp2IlInjected.Address(RVA = "0x2187090", Offset = "0x2185A90", VA = "0x182187090")]
		static FurnitureSupportType()
		{
			//Discarded unreachable code: IL_004f
			//IL_0011: Expected O, but got I4
			(TagItemType, int?)[] CS_0024_003C_003E8__locals0 = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)CS_0024_003C_003E8__locals0)[1] = (ValueTuple<, >)num;
			usedTagTypes = CS_0024_003C_003E8__locals0;
			usedTagTypes = ((TagItemType tagType, int? limit)[])(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new FurnitureSupportType()));
			usedTagTypes = ((TagItemType tagType, int? limit)[])(object)FieldCodec.ForInt32(10u);
			MessageParser<Types.AreaFilterData> parser = Types.AreaFilterData._parser;
			uint num2 = default(uint);
			usedTagTypes = ((TagItemType tagType, int? limit)[])(object)FieldCodec.ForMessage<Types.AreaFilterData>(num2, (MessageParser<>)(object)parser);
		}
	}
}
