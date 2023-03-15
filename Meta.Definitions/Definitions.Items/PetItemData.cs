using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003D2")]
	public sealed class PetItemData : IMessage<PetItemData>, IMessage, IEquatable<PetItemData>, IDeepCloneable<PetItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasTags, IOnlineAvailability, IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x4001432")]
		private static readonly MessageParser<PetItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001433")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001434")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001435")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001436")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001437")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001438")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001439")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400143A")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400143B")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400143C")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400143D")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400143E")]
		public const int TagsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x400143F")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001440")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001441")]
		public const int IsUnavailableForGeneratorFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001442")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4001443")]
		public const int IsSyncOnlineItemFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4001444")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4001445")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001446")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4001447")]
		private static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000B84")]
		[DebuggerNonUserCode]
		public static MessageParser<PetItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC0")]
			[Cpp2IlInjected.Address(RVA = "0x36ACCB0", Offset = "0x36AB6B0", VA = "0x1836ACCB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B85")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC1")]
			[Cpp2IlInjected.Address(RVA = "0x36ACBE0", Offset = "0x36AB5E0", VA = "0x1836ACBE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B86")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC2")]
			[Cpp2IlInjected.Address(RVA = "0x36ACD70", Offset = "0x36AB770", VA = "0x1836ACD70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B87")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DC7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B88")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DC9")]
			[Cpp2IlInjected.Address(RVA = "0x36ACF60", Offset = "0x36AB960", VA = "0x1836ACF60")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B89")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002DCA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DCB")]
			[Cpp2IlInjected.Address(RVA = "0x36ACE80", Offset = "0x36AB880", VA = "0x1836ACE80")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8A")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002DCC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DCD")]
			[Cpp2IlInjected.Address(RVA = "0x36ACEF0", Offset = "0x36AB8F0", VA = "0x1836ACEF0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8B")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002DCE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DCF")]
			[Cpp2IlInjected.Address(RVA = "0x36ACFD0", Offset = "0x36AB9D0", VA = "0x1836ACFD0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8C")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002DD0")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "24")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8D")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6002DD1")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70", Slot = "27")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DD2")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90", Slot = "28")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8E")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002DD3")]
			[Cpp2IlInjected.Address(RVA = "0x162F5B0", Offset = "0x162DFB0", VA = "0x18162F5B0", Slot = "25")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DD4")]
			[Cpp2IlInjected.Address(RVA = "0x162F980", Offset = "0x162E380", VA = "0x18162F980", Slot = "26")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8F")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002DD5")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DD6")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B90")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002DE2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B91")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002DE3")]
			[Cpp2IlInjected.Address(RVA = "0x36ACD10", Offset = "0x36AB710", VA = "0x1836ACD10", Slot = "23")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC3")]
		[Cpp2IlInjected.Address(RVA = "0x36AC940", Offset = "0x36AB340", VA = "0x1836AC940")]
		[DebuggerNonUserCode]
		public PetItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC4")]
		[Cpp2IlInjected.Address(RVA = "0x36ACA10", Offset = "0x36AB410", VA = "0x1836ACA10")]
		[DebuggerNonUserCode]
		public PetItemData(PetItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			bool flag = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag2 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			uint num2 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC5")]
		[Cpp2IlInjected.Address(RVA = "0x36AB840", Offset = "0x36AA240", VA = "0x1836AB840", Slot = "10")]
		[DebuggerNonUserCode]
		public PetItemData Clone()
		{
			return new PetItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD7")]
		[Cpp2IlInjected.Address(RVA = "0x36AB8A0", Offset = "0x36AA2A0", VA = "0x1836AB8A0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(PetItemData).TypeHandle)
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
									if (flag5 && isUnavailableForGenerator_ == flag5 && isSyncOnlineItem_ == flag5 && glotID_ == (flag5 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6002DD8")]
		[Cpp2IlInjected.Address(RVA = "0x36ABA00", Offset = "0x36AA400", VA = "0x1836ABA00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PetItemData other)
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
										bool flag = other.isUnavailableForGenerator_;
										if (isUnavailableForGenerator_ == flag)
										{
											bool flag2 = other.isSyncOnlineItem_;
											if (isSyncOnlineItem_ == flag2)
											{
												uint num2 = other.glotID_;
												if (glotID_ == num2)
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
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DD9")]
		[Cpp2IlInjected.Address(RVA = "0x36ABCF0", Offset = "0x36AA6F0", VA = "0x1836ABCF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b1
			int num = 0;
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
			if (isUnavailableForGenerator_)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DDA")]
		[Cpp2IlInjected.Address(RVA = "0x36AC490", Offset = "0x36AAE90", VA = "0x1836AC490", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DDB")]
		[Cpp2IlInjected.Address(RVA = "0x36AC4F0", Offset = "0x36AAEF0", VA = "0x1836AC4F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0104
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
			if (isUnavailableForGenerator_)
			{
				bool value6 = isUnavailableForGenerator_;
				output.WriteBool(value6);
			}
			if (isSyncOnlineItem_)
			{
				bool value7 = isSyncOnlineItem_;
				output.WriteBool(value7);
			}
			if (glotID_ != 0)
			{
				uint value8 = glotID_;
				output.WriteUInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DDC")]
		[Cpp2IlInjected.Address(RVA = "0x36AB490", Offset = "0x36A9E90", VA = "0x1836AB490", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
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
			uint num9 = glotID_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeUInt32Size(num9);
				num10 += 2;
				repeatedField = (RepeatedField<int>)(repeatedField + num10);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num11 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<int>)(repeatedField + num11);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DDD")]
		[Cpp2IlInjected.Address(RVA = "0x36ABE60", Offset = "0x36AA860", VA = "0x1836ABE60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PetItemData other)
		{
			//Discarded unreachable code: IL_00f1
			if (other != null)
			{
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
				bool flag = other.isUnavailableForGenerator_;
				if (flag)
				{
					isUnavailableForGenerator_ = flag;
				}
				bool flag2 = other.isSyncOnlineItem_;
				if (flag2)
				{
					isSyncOnlineItem_ = flag2;
				}
				uint num2 = other.glotID_;
				if (num2 != 0)
				{
					glotID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DDE")]
		[Cpp2IlInjected.Address(RVA = "0x36ABF80", Offset = "0x36AA980", VA = "0x1836ABF80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0113
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 50)
				{
					if (num == 120)
					{
						bool flag = (isUnavailableForGenerator_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 128)
					{
						flag2 = (isSyncOnlineItem_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_00fc;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				num += 4294967248u;
				if (num != 4294967293u)
				{
					goto IL_00fc;
				}
				RepeatedField<int> repeatedField = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_00fc;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text6 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_00fc;
			IL_00fc:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002DDF")]
		[Cpp2IlInjected.Address(RVA = "0x36ABB20", Offset = "0x36AA520", VA = "0x1836ABB20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 15)
			{
				if (fieldNumber == 16)
				{
					bool flag = isSyncOnlineItem_;
				}
				if (fieldNumber != 999)
				{
					goto IL_0032;
				}
				uint num = glotID_;
			}
			if (fieldNumber - 1 <= 5)
			{
				int num2 = iD_;
			}
			if (fieldNumber != 15)
			{
			}
			goto IL_0032;
			IL_0032:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DE0")]
		[Cpp2IlInjected.Address(RVA = "0x36AC170", Offset = "0x36AAB70", VA = "0x1836AC170", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0030, IL_0031, IL_0032, IL_0033, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061
			//IL_0011: Expected I4, but got O
			//IL_0021: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			do
			{
				if (fieldNumber > 15)
				{
					if (fieldNumber == 16)
					{
						isSyncOnlineItem_ = (byte)(int)obj != 0;
						return;
					}
					while (fieldNumber != 999)
					{
					}
					glotID_ = (uint)(int)obj2;
					return;
				}
				if (fieldNumber - 1 <= 5)
				{
					iD_ = (int)obj3;
					return;
				}
			}
			while ((object)tags_ != (object)typeof(string).TypeHandle);
			isUnavailableForGenerator_ = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DE1")]
		[Cpp2IlInjected.Address(RVA = "0x36AB6D0", Offset = "0x36AA0D0", VA = "0x1836AB6D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0034, IL_0035, IL_0036, IL_0037, IL_0040
			//IL_0023: Expected I4, but got I8
			//IL_0033: Expected I4, but got I8
			if (fieldNumber > 15)
			{
				switch (fieldNumber)
				{
				case 16:
					isSyncOnlineItem_ = false;
					break;
				case 999:
					glotID_ = 0u;
					break;
				}
			}
			else if (fieldNumber - 1 <= 5)
			{
				iD_ = 0;
			}
			else if (fieldNumber != 15)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DE4")]
		[Cpp2IlInjected.Address(RVA = "0x36AB840", Offset = "0x36AA240", VA = "0x1836AB840", Slot = "20")]
		IItemData IItemData.Clone()
		{
			PetItemData petItemData = new PetItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DE5")]
		[Cpp2IlInjected.Address(RVA = "0x36AC740", Offset = "0x36AB140", VA = "0x1836AC740")]
		static PetItemData()
		{
			//Discarded unreachable code: IL_0032
			//IL_002b: Expected O, but got I4
			Func<PetItemData> func = default(Func<PetItemData>);
			_parser = (MessageParser<PetItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<PetItemData>)(object)FieldCodec.ForInt32(50u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<PetItemData>)(object)array;
		}
	}
}
