using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class MiniEventData : IMessage<MiniEventData>, IMessage, IEquatable<MiniEventData>, IDeepCloneable<MiniEventData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly MessageParser<MiniEventData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public const int MetadataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private LiveopsMetadata metadata_;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public const int DescriptionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public const int BannerAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private string bannerAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public const int BackgroundAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private string backgroundAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int EventCurrencyFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int eventCurrency_;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public const int MilestonesFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly FieldCodec<MiniEventMilestoneData> _repeated_milestones_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly RepeatedField<MiniEventMilestoneData> milestones_ = (RepeatedField<MiniEventMilestoneData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[DebuggerNonUserCode]
		public static MessageParser<MiniEventData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E650", Offset = "0x1D2D050", VA = "0x181D2E650")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E580", Offset = "0x1D2CF80", VA = "0x181D2E580")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E6B0", Offset = "0x1D2D0B0", VA = "0x181D2E6B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		[DebuggerNonUserCode]
		public LiveopsMetadata Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return metadata_;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				metadata_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E980", Offset = "0x1D2D380", VA = "0x181D2E980")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E8A0", Offset = "0x1D2D2A0", VA = "0x181D2E8A0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E910", Offset = "0x1D2D310", VA = "0x181D2E910")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		[DebuggerNonUserCode]
		public string BannerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return bannerAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E830", Offset = "0x1D2D230", VA = "0x181D2E830")]
			set
			{
				string text = (bannerAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		[DebuggerNonUserCode]
		public string BackgroundAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return backgroundAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x1D2E7C0", Offset = "0x1D2D1C0", VA = "0x181D2E7C0")]
			set
			{
				string text = (backgroundAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		[DebuggerNonUserCode]
		public int EventCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return eventCurrency_;
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				eventCurrency_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		[DebuggerNonUserCode]
		public RepeatedField<MiniEventMilestoneData> Milestones
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return milestones_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E490", Offset = "0x1D2CE90", VA = "0x181D2E490")]
		[DebuggerNonUserCode]
		public MiniEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E290", Offset = "0x1D2CC90", VA = "0x181D2E290")]
		[DebuggerNonUserCode]
		public MiniEventData(MiniEventData other)
		{
			//IL_0065: Expected O, but got I4
			LiveopsMetadata liveopsMetadata = other.metadata_;
			if (liveopsMetadata != null)
			{
				LiveopsMetadata liveopsMetadata2 = liveopsMetadata.Clone();
			}
			int num = 0;
			metadata_ = (LiveopsMetadata)num;
			string text = (name_ = other.name_);
			string text2 = (description_ = other.description_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (bannerAddress_ = other.bannerAddress_);
			string text5 = (backgroundAddress_ = other.backgroundAddress_);
			int num2 = (eventCurrency_ = other.eventCurrency_);
			RepeatedField<MiniEventMilestoneData> repeatedField = (milestones_ = (RepeatedField<MiniEventMilestoneData>)(object)((RepeatedField<T>)(object)other.milestones_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D100", Offset = "0x1D2BB00", VA = "0x181D2D100", Slot = "10")]
		[DebuggerNonUserCode]
		public MiniEventData Clone()
		{
			return new MiniEventData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D1E0", Offset = "0x1D2BBE0", VA = "0x181D2D1E0", Slot = "0")]
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
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = bannerAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									string text5 = backgroundAddress_;
									bool flag5 = default(bool);
									if (!flag5 && eventCurrency_ == (flag5 ? 1 : 0))
									{
										RepeatedField<MiniEventMilestoneData> repeatedField = milestones_;
										bool flag6 = default(bool);
										if (flag6)
										{
											return object.Equals(_unknownFields, other);
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

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D350", Offset = "0x1D2BD50", VA = "0x181D2D350", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiniEventData other)
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
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.bannerAddress_;
								if (!(bannerAddress_ != text4))
								{
									string text5 = other.backgroundAddress_;
									if (!(backgroundAddress_ != text5))
									{
										int num = other.eventCurrency_;
										if (eventCurrency_ == num)
										{
											RepeatedField<MiniEventMilestoneData> repeatedField = milestones_;
											RepeatedField<MiniEventMilestoneData> repeatedField2 = other.milestones_;
											if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D5E0", Offset = "0x1D2BFE0", VA = "0x181D2D5E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c4
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
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode4 = text3.GetHashCode();
			}
			string text4 = bannerAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode5 = text4.GetHashCode();
			}
			string text5 = backgroundAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			if (eventCurrency_ != 0)
			{
			}
			int hashCode7 = ((RepeatedField<T>)(object)milestones_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1D2DE30", Offset = "0x1D2C830", VA = "0x181D2DE30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1D2DE90", Offset = "0x1D2C890", VA = "0x181D2DE90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f1
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
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (bannerAddress_.m_stringLength != 0)
			{
				string value5 = bannerAddress_;
				output.WriteString(value5);
			}
			if (backgroundAddress_.m_stringLength != 0)
			{
				string value6 = backgroundAddress_;
				output.WriteString(value6);
			}
			if (eventCurrency_ != 0)
			{
				int value7 = eventCurrency_;
				output.WriteInt32(value7);
			}
			RepeatedField<MiniEventMilestoneData> repeatedField = milestones_;
			FieldCodec<MiniEventMilestoneData> repeated_milestones_codec = _repeated_milestones_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_milestones_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1D2CD40", Offset = "0x1D2B740", VA = "0x181D2CD40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_012c
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
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text3);
				num5++;
				num += num5;
			}
			string text4 = bannerAddress_;
			if (text4.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text4);
				num6++;
				num += num6;
			}
			string text5 = backgroundAddress_;
			if (text5.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text5);
				num7++;
				num += num7;
			}
			int num8 = eventCurrency_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num += num9;
			}
			RepeatedField<MiniEventMilestoneData> repeatedField = milestones_;
			FieldCodec<MiniEventMilestoneData> repeated_milestones_codec = _repeated_milestones_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_milestones_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num10;
			if (unknownFields != null)
			{
				int num11 = unknownFields.CalculateSize();
				num += num11;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D9E0", Offset = "0x1D2C3E0", VA = "0x181D2D9E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniEventData other)
		{
			//Discarded unreachable code: IL_0105
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
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.bannerAddress_;
			if (text4.m_stringLength != 0)
			{
				BannerAddress = text4;
			}
			string text5 = other.backgroundAddress_;
			if (text5.m_stringLength != 0)
			{
				BackgroundAddress = text5;
			}
			int num = other.eventCurrency_;
			if (num != 0)
			{
				eventCurrency_ = num;
			}
			RepeatedField<MiniEventMilestoneData> repeatedField = milestones_;
			RepeatedField<MiniEventMilestoneData> repeatedField2 = other.milestones_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D7A0", Offset = "0x1D2C1A0", VA = "0x181D2D7A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0111
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 56)
					{
						int num2 = (eventCurrency_ = input.ReadInt32());
					}
					if (num != 66)
					{
						goto IL_00fa;
					}
					RepeatedField<MiniEventMilestoneData> repeatedField = milestones_;
					FieldCodec<MiniEventMilestoneData> repeated_milestones_codec = _repeated_milestones_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_milestones_codec);
				}
				string text2 = default(string);
				if (num == 42)
				{
					text2 = (BannerAddress = input.ReadString());
				}
				if ((long)text2 != 50)
				{
					goto IL_00fa;
				}
				string text4 = (BackgroundAddress = input.ReadString());
			}
			string text8 = default(string);
			if ((int)num > 18)
			{
				string text6 = default(string);
				if (num == 26)
				{
					text6 = (Description = input.ReadString());
				}
				if ((long)text6 != 34)
				{
					goto IL_00fa;
				}
				text8 = (IconAddress = input.ReadString());
			}
			LiveopsMetadata liveopsMetadata = default(LiveopsMetadata);
			if ((long)text8 == 10)
			{
				LiveopsMetadata builder = default(LiveopsMetadata);
				if (metadata_ == null)
				{
					liveopsMetadata = (metadata_ = new LiveopsMetadata());
					builder = metadata_;
				}
				input.ReadMessage(builder);
			}
			if ((long)liveopsMetadata == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_00fa;
			IL_00fa:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D480", Offset = "0x1D2BE80", VA = "0x181D2D480", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				LiveopsMetadata liveopsMetadata = metadata_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1D2DB70", Offset = "0x1D2C570", VA = "0x181D2DB70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_002a, IL_0032, IL_0043, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				metadata_ = (LiveopsMetadata)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x1D2CFA0", Offset = "0x1D2B9A0", VA = "0x181D2CFA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_0009, IL_000a, IL_000b, IL_000e, IL_000f
			if (fieldNumber - 1 > 7)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D730", Offset = "0x1D2C130", VA = "0x181D2D730")]
		public bool IsValidIndex(int index)
		{
			//Discarded unreachable code: IL_0010
			int num = 0;
			int count = ((RepeatedField<T>)(object)milestones_).Count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D160", Offset = "0x1D2BB60", VA = "0x181D2D160", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (((RepeatedField<T>)(object)milestones_).Count == 0)
			{
				context.AddError("Milestones can't be empty");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E0C0", Offset = "0x1D2CAC0", VA = "0x181D2E0C0")]
		static MiniEventData()
		{
			Func<MiniEventData> func = default(Func<MiniEventData>);
			_parser = (MessageParser<MiniEventData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<MiniEventMilestoneData> parser = MiniEventMilestoneData._parser;
			uint num = default(uint);
			_parser = (MessageParser<MiniEventData>)(object)FieldCodec.ForMessage<MiniEventMilestoneData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
