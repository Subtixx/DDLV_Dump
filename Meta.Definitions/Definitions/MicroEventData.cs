using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class MicroEventData : IMessage<MicroEventData>, IMessage, IEquatable<MicroEventData>, IDeepCloneable<MicroEventData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly MessageParser<MicroEventData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public const int MetadataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private LiveopsMetadata metadata_;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public const int DescriptionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public const int TagFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private string tag_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public const int IconAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public const int BuffTypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private BuffType buffType_;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public const int BuffPercentageEffectFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int buffPercentageEffect_;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[DebuggerNonUserCode]
		public static MessageParser<MicroEventData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x1D28890", Offset = "0x1D27290", VA = "0x181D28890")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x1D287C0", Offset = "0x1D271C0", VA = "0x181D287C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x1D288F0", Offset = "0x1D272F0", VA = "0x181D288F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		[DebuggerNonUserCode]
		public LiveopsMetadata Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return metadata_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				metadata_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x1D28AE0", Offset = "0x1D274E0", VA = "0x181D28AE0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x1D28A00", Offset = "0x1D27400", VA = "0x181D28A00")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[DebuggerNonUserCode]
		public string Tag
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return tag_;
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x1D28B50", Offset = "0x1D27550", VA = "0x181D28B50")]
			set
			{
				string text = (tag_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x1D28A70", Offset = "0x1D27470", VA = "0x181D28A70")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		[DebuggerNonUserCode]
		public BuffType BuffType
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return buffType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				buffType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[DebuggerNonUserCode]
		public int BuffPercentageEffect
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return buffPercentageEffect_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				buffPercentageEffect_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1D28740", Offset = "0x1D27140", VA = "0x181D28740")]
		[DebuggerNonUserCode]
		public MicroEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1D285F0", Offset = "0x1D26FF0", VA = "0x181D285F0")]
		[DebuggerNonUserCode]
		public MicroEventData(MicroEventData other)
		{
			//IL_004d: Expected O, but got I4
			LiveopsMetadata liveopsMetadata = other.metadata_;
			if (liveopsMetadata != null)
			{
				LiveopsMetadata liveopsMetadata2 = liveopsMetadata.Clone();
			}
			int num = 0;
			metadata_ = (LiveopsMetadata)num;
			string text = (name_ = other.name_);
			string text2 = (description_ = other.description_);
			string text3 = (tag_ = other.tag_);
			string text4 = (iconAddress_ = other.iconAddress_);
			BuffType buffType = (buffType_ = other.buffType_);
			int num2 = (buffPercentageEffect_ = other.buffPercentageEffect_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1D27790", Offset = "0x1D26190", VA = "0x181D27790", Slot = "10")]
		[DebuggerNonUserCode]
		public MicroEventData Clone()
		{
			//Discarded unreachable code: IL_00c4
			//IL_004d: Expected O, but got I4
			MicroEventData microEventData = new MicroEventData();
			microEventData.name_ = "";
			microEventData.description_ = "";
			microEventData.tag_ = "";
			microEventData.iconAddress_ = "";
			LiveopsMetadata liveopsMetadata = metadata_;
			if (liveopsMetadata != null)
			{
				LiveopsMetadata liveopsMetadata2 = liveopsMetadata.Clone();
			}
			int num = 0;
			microEventData.metadata_ = (LiveopsMetadata)num;
			string text = (microEventData.name_ = name_);
			string text2 = (microEventData.description_ = description_);
			string text3 = (microEventData.tag_ = tag_);
			string text4 = (microEventData.iconAddress_ = iconAddress_);
			BuffType buffType = (microEventData.buffType_ = buffType_);
			int num2 = (microEventData.buffPercentageEffect_ = buffPercentageEffect_);
			UnknownFieldSet unknownFieldSet = (microEventData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return microEventData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1D27910", Offset = "0x1D26310", VA = "0x181D27910", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(metadata_, other))
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = description_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = tag_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = iconAddress_;
								bool flag4 = default(bool);
								if (!flag4 && buffType_ == (flag4 ? BuffType.FriendshipGained : BuffType.None) && buffPercentageEffect_ == (flag4 ? 1 : 0))
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1D27A30", Offset = "0x1D26430", VA = "0x181D27A30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MicroEventData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				LiveopsMetadata objB = other.metadata_;
				if (object.Equals(metadata_, objB))
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.description_;
						if (!(description_ != text2))
						{
							string text3 = other.tag_;
							if (!(tag_ != text3))
							{
								string text4 = other.iconAddress_;
								if (!(iconAddress_ != text4))
								{
									BuffType buffType = other.buffType_;
									if (buffType_ == buffType)
									{
										int num = other.buffPercentageEffect_;
										if (buffPercentageEffect_ == num)
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
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1D27C60", Offset = "0x1D26660", VA = "0x181D27C60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a7
			int num = 0;
			LiveopsMetadata liveopsMetadata = metadata_;
			if (liveopsMetadata != null)
			{
				int hashCode = liveopsMetadata.GetHashCode();
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			string text2 = description_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			string text3 = tag_;
			if (text3.m_stringLength != 0)
			{
				int hashCode4 = text3.GetHashCode();
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode5 = text4.GetHashCode();
			}
			if (buffType_ != 0)
			{
			}
			if (buffPercentageEffect_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1D282F0", Offset = "0x1D26CF0", VA = "0x181D282F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1D28350", Offset = "0x1D26D50", VA = "0x181D28350", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00c3
			if ((long)metadata_ != 0)
			{
				LiveopsMetadata value = metadata_;
				output.WriteMessage(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (description_.m_stringLength != 0)
			{
				string value3 = description_;
				output.WriteString(value3);
			}
			if (tag_.m_stringLength != 0)
			{
				string value4 = tag_;
				output.WriteString(value4);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value5 = iconAddress_;
				output.WriteString(value5);
			}
			if (buffType_ != 0)
			{
			}
			if (buffPercentageEffect_ != 0)
			{
				int value6 = buffPercentageEffect_;
				output.WriteInt32(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1D27480", Offset = "0x1D25E80", VA = "0x181D27480", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0108
			LiveopsMetadata liveopsMetadata = metadata_;
			int num = 0;
			if (liveopsMetadata != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(liveopsMetadata);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = description_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			string text3 = tag_;
			if (text3.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text3);
				num5++;
				num += num5;
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text4);
				num6++;
				num += num6;
			}
			BuffType buffType = buffType_;
			if (buffType != 0)
			{
				int num7 = CodedOutputStream.ComputeEnumSize((int)buffType);
				num7++;
				num += num7;
			}
			int num8 = buffPercentageEffect_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num += num9;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num += num10;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1D27D90", Offset = "0x1D26790", VA = "0x181D27D90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MicroEventData other)
		{
			//Discarded unreachable code: IL_00e7
			if (other == null)
			{
				return;
			}
			if ((long)other.metadata_ != 0)
			{
				LiveopsMetadata liveopsMetadata = metadata_;
				if (liveopsMetadata == null)
				{
					LiveopsMetadata liveopsMetadata2 = (metadata_ = new LiveopsMetadata());
				}
				LiveopsMetadata other2 = other.metadata_;
				liveopsMetadata.MergeFrom(other2);
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.description_;
			if (text2.m_stringLength != 0)
			{
				Description = text2;
			}
			string text3 = other.tag_;
			if (text3.m_stringLength != 0)
			{
				Tag = text3;
			}
			string text4 = other.iconAddress_;
			if (text4.m_stringLength != 0)
			{
				IconAddress = text4;
			}
			BuffType buffType = other.buffType_;
			if (buffType != 0)
			{
				buffType_ = buffType;
			}
			int num = other.buffPercentageEffect_;
			if (num != 0)
			{
				buffPercentageEffect_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1D27EE0", Offset = "0x1D268E0", VA = "0x181D27EE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00e6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 48)
					{
						int num2 = (int)(buffType_ = (BuffType)input.ReadInt32());
					}
					if (num != 56)
					{
						goto IL_00cf;
					}
					int num3 = (buffPercentageEffect_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (Tag = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_00cf;
				}
				string text4 = (IconAddress = input.ReadString());
			}
			LiveopsMetadata liveopsMetadata = default(LiveopsMetadata);
			if (num == 10)
			{
				LiveopsMetadata builder = default(LiveopsMetadata);
				if (metadata_ == null)
				{
					liveopsMetadata = (metadata_ = new LiveopsMetadata());
					builder = metadata_;
				}
				input.ReadMessage(builder);
			}
			string text6 = default(string);
			if ((long)liveopsMetadata == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (Description = input.ReadString());
			}
			goto IL_00cf;
			IL_00cf:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1D27B00", Offset = "0x1D26500", VA = "0x181D27B00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				LiveopsMetadata liveopsMetadata = metadata_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1D28080", Offset = "0x1D26A80", VA = "0x181D28080", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0039, IL_0045, IL_004b, IL_0051, IL_0057, IL_005d
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				metadata_ = (LiveopsMetadata)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1D27670", Offset = "0x1D26070", VA = "0x181D27670", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0009, IL_000a, IL_000b, IL_000c, IL_000e, IL_0012, IL_0016, IL_001a
			int num = fieldNumber - 1;
			if (num > 6)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1D284E0", Offset = "0x1D26EE0", VA = "0x181D284E0")]
		static MicroEventData()
		{
			Func<MicroEventData> func = default(Func<MicroEventData>);
			_parser = (MessageParser<MicroEventData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
