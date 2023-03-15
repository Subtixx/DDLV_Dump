using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003E4")]
	public sealed class SetItemData : IMessage<SetItemData>, IMessage, IEquatable<SetItemData>, IDeepCloneable<SetItemData>, IMessageFieldAccessor, IItemData, IHasTags, IHasUnlockConditions
	{
		[Cpp2IlInjected.Token(Token = "0x40014FF")]
		private static readonly MessageParser<SetItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001500")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001501")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001502")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001503")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001504")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001505")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001506")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001507")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001508")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001509")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400150A")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400150B")]
		public const int TagsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x400150C")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400150D")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400150E")]
		public const int CatalogVisibilityConditionsFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400150F")]
		private CatalogVisibilityConditions catalogVisibilityConditions_;

		[Cpp2IlInjected.Token(Token = "0x4001510")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000C01")]
		[DebuggerNonUserCode]
		public static MessageParser<SetItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002F19")]
			[Cpp2IlInjected.Address(RVA = "0x384C5B0", Offset = "0x384AFB0", VA = "0x18384C5B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C02")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F1A")]
			[Cpp2IlInjected.Address(RVA = "0x384C4E0", Offset = "0x384AEE0", VA = "0x18384C4E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C03")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F1B")]
			[Cpp2IlInjected.Address(RVA = "0x384C670", Offset = "0x384B070", VA = "0x18384C670", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C04")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002F20")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F21")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C05")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002F22")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F23")]
			[Cpp2IlInjected.Address(RVA = "0x384C860", Offset = "0x384B260", VA = "0x18384C860")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C06")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002F24")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F25")]
			[Cpp2IlInjected.Address(RVA = "0x384C780", Offset = "0x384B180", VA = "0x18384C780")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C07")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002F26")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F27")]
			[Cpp2IlInjected.Address(RVA = "0x384C7F0", Offset = "0x384B1F0", VA = "0x18384C7F0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C08")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002F28")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F29")]
			[Cpp2IlInjected.Address(RVA = "0x384C8D0", Offset = "0x384B2D0", VA = "0x18384C8D0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C09")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002F2A")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "22")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0A")]
		[DebuggerNonUserCode]
		public CatalogVisibilityConditions CatalogVisibilityConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6002F2B")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "23")]
			get
			{
				return catalogVisibilityConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F2C")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				catalogVisibilityConditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0B")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002F38")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0C")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002F39")]
			[Cpp2IlInjected.Address(RVA = "0x384C610", Offset = "0x384B010", VA = "0x18384C610", Slot = "21")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F1C")]
		[Cpp2IlInjected.Address(RVA = "0x384C1A0", Offset = "0x384ABA0", VA = "0x18384C1A0")]
		[DebuggerNonUserCode]
		public SetItemData()
		{
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F1D")]
		[Cpp2IlInjected.Address(RVA = "0x384BA60", Offset = "0x384A460", VA = "0x18384BA60")]
		private void OnConstruction()
		{
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F1E")]
		[Cpp2IlInjected.Address(RVA = "0x384C2C0", Offset = "0x384ACC0", VA = "0x18384C2C0")]
		[DebuggerNonUserCode]
		public SetItemData(SetItemData other)
		{
			//IL_00ce: Expected O, but got I4
			CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			CatalogVisibilityConditions catalogVisibilityConditions2 = other.catalogVisibilityConditions_;
			if (catalogVisibilityConditions2 != null)
			{
				CatalogVisibilityConditions catalogVisibilityConditions3 = catalogVisibilityConditions2.Clone();
			}
			int num2 = 0;
			catalogVisibilityConditions_ = (CatalogVisibilityConditions)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F1F")]
		[Cpp2IlInjected.Address(RVA = "0x384B180", Offset = "0x3849B80", VA = "0x18384B180", Slot = "10")]
		[DebuggerNonUserCode]
		public SetItemData Clone()
		{
			return new SetItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2D")]
		[Cpp2IlInjected.Address(RVA = "0x384B1E0", Offset = "0x3849BE0", VA = "0x18384B1E0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(SetItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									RepeatedField<int> repeatedField = tags_;
									bool flag5 = default(bool);
									if (flag5 && object.Equals(catalogVisibilityConditions_, other))
									{
										return object.Equals(_unknownFields, other);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2E")]
		[Cpp2IlInjected.Address(RVA = "0x384B340", Offset = "0x3849D40", VA = "0x18384B340", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SetItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									RepeatedField<int> repeatedField = tags_;
									RepeatedField<int> repeatedField2 = other.tags_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										CatalogVisibilityConditions objB = other.catalogVisibilityConditions_;
										if (object.Equals(catalogVisibilityConditions_, objB))
										{
											UnknownFieldSet unknownFields = other._unknownFields;
											return object.Equals(_unknownFields, unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2F")]
		[Cpp2IlInjected.Address(RVA = "0x384B590", Offset = "0x3849F90", VA = "0x18384B590", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a9
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			CatalogVisibilityConditions catalogVisibilityConditions = catalogVisibilityConditions_;
			if (catalogVisibilityConditions != null)
			{
				int hashCode6 = catalogVisibilityConditions.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F30")]
		[Cpp2IlInjected.Address(RVA = "0x384BD30", Offset = "0x384A730", VA = "0x18384BD30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F31")]
		[Cpp2IlInjected.Address(RVA = "0x384BD90", Offset = "0x384A790", VA = "0x18384BD90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d3
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if ((long)catalogVisibilityConditions_ != 0)
			{
				CatalogVisibilityConditions value6 = catalogVisibilityConditions_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F32")]
		[Cpp2IlInjected.Address(RVA = "0x384AE20", Offset = "0x3849820", VA = "0x18384AE20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0106
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			CatalogVisibilityConditions catalogVisibilityConditions = catalogVisibilityConditions_;
			num2 += num8;
			if (catalogVisibilityConditions != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(catalogVisibilityConditions);
				num9++;
				num2 += num9;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num2 += num10;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F33")]
		[Cpp2IlInjected.Address(RVA = "0x384B8E0", Offset = "0x384A2E0", VA = "0x18384B8E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SetItemData other)
		{
			//Discarded unreachable code: IL_00ed
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.catalogVisibilityConditions_ != 0)
			{
				CatalogVisibilityConditions catalogVisibilityConditions2 = default(CatalogVisibilityConditions);
				if (catalogVisibilityConditions_ == null)
				{
					CatalogVisibilityConditions catalogVisibilityConditions = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
					catalogVisibilityConditions2 = catalogVisibilityConditions_;
				}
				CatalogVisibilityConditions other2 = other.catalogVisibilityConditions_;
				catalogVisibilityConditions2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002F34")]
		[Cpp2IlInjected.Address(RVA = "0x384B6C0", Offset = "0x384A0C0", VA = "0x18384B6C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00f8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 34)
			{
				goto IL_0080;
			}
			if ((int)num > 48)
			{
				if (num == 50)
				{
					goto IL_0067;
				}
				if (num != 58)
				{
					goto IL_00e1;
				}
				CatalogVisibilityConditions catalogVisibilityConditions = catalogVisibilityConditions_;
				if (catalogVisibilityConditions == null)
				{
					CatalogVisibilityConditions catalogVisibilityConditions2 = (catalogVisibilityConditions_ = new CatalogVisibilityConditions());
				}
				input.ReadMessage(catalogVisibilityConditions);
			}
			string text2 = default(string);
			if (num == 42)
			{
				text2 = (PrefabAddress = input.ReadString());
			}
			if ((long)text2 == 48)
			{
				goto IL_0067;
			}
			goto IL_00e1;
			IL_0067:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_0080;
			IL_00e1:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_0080:
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				if ((long)text4 != 34)
				{
					goto IL_00e1;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num2 = default(int);
			if ((long)text6 == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_00e1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F35")]
		[Cpp2IlInjected.Address(RVA = "0x384B450", Offset = "0x3849E50", VA = "0x18384B450", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F36")]
		[Cpp2IlInjected.Address(RVA = "0x384BAC0", Offset = "0x384A4C0", VA = "0x18384BAC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_001f, IL_0025, IL_002b, IL_0031
			//IL_000d: Expected I4, but got O
			//IL_0019: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F37")]
		[Cpp2IlInjected.Address(RVA = "0x384B040", Offset = "0x3849A40", VA = "0x18384B040", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0017
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 6)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F3A")]
		[Cpp2IlInjected.Address(RVA = "0x384B180", Offset = "0x3849B80", VA = "0x18384B180", Slot = "20")]
		IItemData IItemData.Clone()
		{
			SetItemData setItemData = new SetItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F3B")]
		[Cpp2IlInjected.Address(RVA = "0x384BF80", Offset = "0x384A980", VA = "0x18384BF80")]
		static SetItemData()
		{
			//Discarded unreachable code: IL_0033
			//IL_002b: Expected O, but got I4
			Func<SetItemData> func = default(Func<SetItemData>);
			_parser = (MessageParser<SetItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<SetItemData>)(object)FieldCodec.ForInt32(50u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			ReadOnlyCollection<(TagItemType, int?)> parser = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<SetItemData>)(object)parser;
		}
	}
}
