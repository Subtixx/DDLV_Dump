using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class MegaEventData : IMessage<MegaEventData>, IMessage, IEquatable<MegaEventData>, IDeepCloneable<MegaEventData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly MessageParser<MegaEventData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public const int MetadataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private LiveopsMetadata metadata_;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public const int TitleFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private string title_ = "";

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public const int SubtitleFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private string subtitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public const int RewardDurationFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Duration rewardDuration_;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public const int ChaptersFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly FieldCodec<MegaEventChapterData> _repeated_chapters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly RepeatedField<MegaEventChapterData> chapters_ = (RepeatedField<MegaEventChapterData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		[DebuggerNonUserCode]
		public static MessageParser<MegaEventData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x3072C30", Offset = "0x3071630", VA = "0x183072C30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x3072B60", Offset = "0x3071560", VA = "0x183072B60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x3072C90", Offset = "0x3071690", VA = "0x183072C90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[DebuggerNonUserCode]
		public LiveopsMetadata Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return metadata_;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				metadata_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x3072E10", Offset = "0x3071810", VA = "0x183072E10")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		[DebuggerNonUserCode]
		public string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return subtitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x3072DA0", Offset = "0x30717A0", VA = "0x183072DA0")]
			set
			{
				string text = (subtitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		[DebuggerNonUserCode]
		public Duration RewardDuration
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return rewardDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				rewardDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		[DebuggerNonUserCode]
		public RepeatedField<MegaEventChapterData> Chapters
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return chapters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x3072880", Offset = "0x3071280", VA = "0x183072880")]
		[DebuggerNonUserCode]
		public MegaEventData()
		{
			Duration duration = (rewardDuration_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3072170", Offset = "0x3070B70", VA = "0x183072170")]
		private void OnConstruction()
		{
			Duration duration = (rewardDuration_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3072970", Offset = "0x3071370", VA = "0x183072970")]
		[DebuggerNonUserCode]
		public MegaEventData(MegaEventData other)
		{
			//IL_0052: Expected O, but got I4
			Duration duration = (rewardDuration_ = new Duration());
			LiveopsMetadata liveopsMetadata = other.metadata_;
			int num = 0;
			if (liveopsMetadata != null)
			{
				LiveopsMetadata liveopsMetadata2 = liveopsMetadata.Clone();
			}
			metadata_ = (LiveopsMetadata)num;
			string text = (title_ = other.title_);
			string text2 = (subtitle_ = other.subtitle_);
			Duration duration2 = other.rewardDuration_;
			Duration duration3 = default(Duration);
			if (duration2 != null)
			{
				duration3 = duration2.Clone();
			}
			rewardDuration_ = duration3;
			RepeatedField<MegaEventChapterData> repeatedField = (chapters_ = (RepeatedField<MegaEventChapterData>)(object)((RepeatedField<T>)(object)other.chapters_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3071840", Offset = "0x3070240", VA = "0x183071840", Slot = "10")]
		[DebuggerNonUserCode]
		public MegaEventData Clone()
		{
			return new MegaEventData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x30718A0", Offset = "0x30702A0", VA = "0x1830718A0", Slot = "0")]
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
					string text = title_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = subtitle_;
						bool flag2 = default(bool);
						if (!flag2 && object.Equals(rewardDuration_, other))
						{
							RepeatedField<MegaEventChapterData> repeatedField = chapters_;
							bool flag3 = default(bool);
							if (flag3)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x30719D0", Offset = "0x30703D0", VA = "0x1830719D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MegaEventData other)
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
					string text = other.title_;
					if (!(title_ != text))
					{
						string text2 = other.subtitle_;
						if (!(subtitle_ != text2))
						{
							Duration objB2 = other.rewardDuration_;
							if (object.Equals(rewardDuration_, objB2))
							{
								RepeatedField<MegaEventChapterData> repeatedField = chapters_;
								RepeatedField<MegaEventChapterData> repeatedField2 = other.chapters_;
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
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x3071C20", Offset = "0x3070620", VA = "0x183071C20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_007f
			LiveopsMetadata liveopsMetadata = metadata_;
			if (liveopsMetadata != null)
			{
				int hashCode = liveopsMetadata.GetHashCode();
			}
			string text = title_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			string text2 = subtitle_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			Duration duration = rewardDuration_;
			if (duration != null)
			{
				int hashCode4 = duration.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)chapters_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x30724D0", Offset = "0x3070ED0", VA = "0x1830724D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3072530", Offset = "0x3070F30", VA = "0x183072530", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0099
			if ((long)metadata_ != 0)
			{
				LiveopsMetadata value = metadata_;
				output.WriteMessage(value);
			}
			if (title_.m_stringLength != 0)
			{
				string value2 = title_;
				output.WriteString(value2);
			}
			if (subtitle_.m_stringLength != 0)
			{
				string value3 = subtitle_;
				output.WriteString(value3);
			}
			if ((long)rewardDuration_ != 0)
			{
				Duration value4 = rewardDuration_;
				output.WriteMessage(value4);
			}
			RepeatedField<MegaEventChapterData> repeatedField = chapters_;
			FieldCodec<MegaEventChapterData> repeated_chapters_codec = _repeated_chapters_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_chapters_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3071460", Offset = "0x306FE60", VA = "0x183071460", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ba
			LiveopsMetadata liveopsMetadata = metadata_;
			int num = 0;
			if (liveopsMetadata != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(liveopsMetadata);
			}
			string text = title_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = subtitle_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			Duration duration = rewardDuration_;
			if (duration != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(duration);
				num5++;
				num += num5;
			}
			RepeatedField<MegaEventChapterData> repeatedField = chapters_;
			FieldCodec<MegaEventChapterData> repeated_chapters_codec = _repeated_chapters_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_chapters_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num6;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3071FE0", Offset = "0x30709E0", VA = "0x183071FE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MegaEventData other)
		{
			//Discarded unreachable code: IL_00e8
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
					LiveopsMetadata liveopsMetadata3 = metadata_;
				}
				LiveopsMetadata other2 = other.metadata_;
				liveopsMetadata.MergeFrom(other2);
			}
			string text = other.title_;
			if (text.m_stringLength != 0)
			{
				Title = text;
			}
			string text2 = other.subtitle_;
			if (text2.m_stringLength != 0)
			{
				Subtitle = text2;
			}
			if ((long)other.rewardDuration_ != 0)
			{
				Duration duration2 = default(Duration);
				if (rewardDuration_ == null)
				{
					Duration duration = (rewardDuration_ = new Duration());
					duration2 = rewardDuration_;
				}
				Duration other3 = other.rewardDuration_;
				duration2.MergeFrom(other3);
			}
			RepeatedField<MegaEventChapterData> repeatedField = chapters_;
			RepeatedField<MegaEventChapterData> repeatedField2 = other.chapters_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x3071DE0", Offset = "0x30707E0", VA = "0x183071DE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00d0
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (Subtitle = input.ReadString());
				}
				Duration duration = default(Duration);
				if (num == 34)
				{
					Duration builder = default(Duration);
					if (rewardDuration_ == null)
					{
						duration = (rewardDuration_ = new Duration());
						builder = rewardDuration_;
					}
					input.ReadMessage(builder);
				}
				if ((long)duration != 42)
				{
					goto IL_00b9;
				}
				RepeatedField<MegaEventChapterData> repeatedField = chapters_;
				FieldCodec<MegaEventChapterData> repeated_chapters_codec = _repeated_chapters_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_chapters_codec);
			}
			LiveopsMetadata liveopsMetadata = default(LiveopsMetadata);
			if (num == 10)
			{
				LiveopsMetadata builder2 = default(LiveopsMetadata);
				if (metadata_ == null)
				{
					liveopsMetadata = (metadata_ = new LiveopsMetadata());
					builder2 = metadata_;
				}
				input.ReadMessage(builder2);
			}
			if ((long)liveopsMetadata == 18)
			{
				string text4 = (Title = input.ReadString());
			}
			goto IL_00b9;
			IL_00b9:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3071B60", Offset = "0x3070560", VA = "0x183071B60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MegaEventChapterData> repeatedField = chapters_;
				Duration duration = rewardDuration_;
				string text = subtitle_;
				string text2 = title_;
				LiveopsMetadata liveopsMetadata = metadata_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x3072310", Offset = "0x3070D10", VA = "0x183072310", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0029: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num == 0 || num != 1)
						{
							int num2 = 0;
							if (value == null || value != null)
							{
								rewardDuration_ = (Duration)num2;
								return;
							}
						}
						else
						{
							InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						}
						throw new InvalidCastException();
					}
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				return;
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x3071760", Offset = "0x3070160", VA = "0x183071760", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0038
			int num = fieldNumber - 1;
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						RepeatedField<MegaEventChapterData> repeatedField = chapters_;
						break;
					}
					case 0:
						break;
					default:
						return;
					}
				}
				Subtitle = "";
			}
			else
			{
				Title = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x3071D00", Offset = "0x3070700", VA = "0x183071D00")]
		public MegaEventState GetState(DateTime serverTime, DateTime startTime, DateTime endTime)
		{
			DateTime dateTime = OpenTime(startTime);
			if (!(serverTime < dateTime))
			{
				DateTime dateTime2 = RewardTime(endTime);
				bool flag = serverTime < dateTime2;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x3071AC0", Offset = "0x30704C0", VA = "0x183071AC0")]
		public TimeSpan EventDuration(DateTime startTime, DateTime endTime)
		{
			DateTime dateTime = RewardTime(endTime);
			DateTime dateTime2 = OpenTime(startTime);
			return dateTime - dateTime2;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x30721D0", Offset = "0x3070BD0", VA = "0x1830721D0")]
		public DateTime OpenTime(DateTime startTime)
		{
			//Discarded unreachable code: IL_0023
			RepeatedField<MegaEventChapterData> repeatedField = chapters_;
			int index = 0;
			TimeSpan timeSpan = ((MegaEventChapterData)((RepeatedField<T>)(object)repeatedField)[index]).openDelay_.ToTimeSpan();
			return startTime + timeSpan;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x3071610", Offset = "0x3070010", VA = "0x183071610")]
		public DateTime ChapterOpenTime(DateTime startTime, int chapterIndex)
		{
			//Discarded unreachable code: IL_001f
			TimeSpan timeSpan = ((MegaEventChapterData)((RepeatedField<T>)(object)chapters_)[chapterIndex]).openDelay_.ToTimeSpan();
			return startTime + timeSpan;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x30716E0", Offset = "0x30700E0", VA = "0x1830716E0")]
		public DateTime ChapterOpenTime(DateTime startTime, MegaEventChapterData chapterData)
		{
			//Discarded unreachable code: IL_0014
			TimeSpan timeSpan = chapterData.openDelay_.ToTimeSpan();
			return startTime + timeSpan;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x3072290", Offset = "0x3070C90", VA = "0x183072290")]
		public DateTime RewardTime(DateTime endTime)
		{
			//Discarded unreachable code: IL_0014
			TimeSpan timeSpan = rewardDuration_.ToTimeSpan();
			return endTime - timeSpan;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x30726B0", Offset = "0x30710B0", VA = "0x1830726B0")]
		static MegaEventData()
		{
			Func<MegaEventData> func = default(Func<MegaEventData>);
			_parser = (MessageParser<MegaEventData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<MegaEventChapterData> parser = MegaEventChapterData._parser;
			uint num = default(uint);
			_parser = (MessageParser<MegaEventData>)(object)FieldCodec.ForMessage<MegaEventChapterData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
