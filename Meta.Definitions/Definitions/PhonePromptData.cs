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
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class PhonePromptData : IMessage<PhonePromptData>, IMessage, IEquatable<PhonePromptData>, IDeepCloneable<PhonePromptData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly MessageParser<PhonePromptData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public const int MetadataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private LiveopsMetadata metadata_;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public const int DescriptionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public const int BackgroundAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private string backgroundAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public const int ParticipationMaxCountFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private int participationMaxCount_;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public const int BonusMultiplierFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private float bonusMultiplier_;

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[DebuggerNonUserCode]
		public static MessageParser<PhonePromptData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0x36AE410", Offset = "0x36ACE10", VA = "0x1836AE410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0x36AE340", Offset = "0x36ACD40", VA = "0x1836AE340")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x36AE470", Offset = "0x36ACE70", VA = "0x1836AE470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		[DebuggerNonUserCode]
		public LiveopsMetadata Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return metadata_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				metadata_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x36AE660", Offset = "0x36AD060", VA = "0x1836AE660")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x36AE5F0", Offset = "0x36ACFF0", VA = "0x1836AE5F0")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		[DebuggerNonUserCode]
		public string BackgroundAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return backgroundAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x36AE580", Offset = "0x36ACF80", VA = "0x1836AE580")]
			set
			{
				string text = (backgroundAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		[DebuggerNonUserCode]
		public int ParticipationMaxCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return participationMaxCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				participationMaxCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		[DebuggerNonUserCode]
		public float BonusMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0x823CD0", Offset = "0x8226D0", VA = "0x180823CD0")]
			get
			{
				return bonusMultiplier_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0x824260", Offset = "0x822C60", VA = "0x180824260")]
			set
			{
				bonusMultiplier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x36AE2D0", Offset = "0x36ACCD0", VA = "0x1836AE2D0")]
		[DebuggerNonUserCode]
		public PhonePromptData()
		{
			//IL_002a: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x36AE1A0", Offset = "0x36ACBA0", VA = "0x1836AE1A0")]
		[DebuggerNonUserCode]
		public PhonePromptData(PhonePromptData other)
		{
			//IL_002a: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
			LiveopsMetadata liveopsMetadata = other.metadata_;
			if (liveopsMetadata != null)
			{
				LiveopsMetadata liveopsMetadata2 = liveopsMetadata.Clone();
			}
			int num2 = 0;
			metadata_ = (LiveopsMetadata)num2;
			string text = (name_ = other.name_);
			string text2 = (description_ = other.description_);
			string text3 = (backgroundAddress_ = other.backgroundAddress_);
			int num3 = (participationMaxCount_ = other.participationMaxCount_);
			float num4 = (bonusMultiplier_ = other.bonusMultiplier_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x36AD2D0", Offset = "0x36ABCD0", VA = "0x1836AD2D0", Slot = "10")]
		[DebuggerNonUserCode]
		public PhonePromptData Clone()
		{
			//Discarded unreachable code: IL_00ae
			//IL_002a: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			PhonePromptData phonePromptData = default(PhonePromptData);
			phonePromptData.name_ = "";
			phonePromptData.description_ = "";
			phonePromptData.backgroundAddress_ = "";
			int num = 0;
			phonePromptData.DataValidation((DataValidation.Context)num);
			LiveopsMetadata liveopsMetadata = metadata_;
			if (liveopsMetadata != null)
			{
				LiveopsMetadata liveopsMetadata2 = liveopsMetadata.Clone();
			}
			int num2 = 0;
			phonePromptData.metadata_ = (LiveopsMetadata)num2;
			string text = (phonePromptData.name_ = name_);
			string text2 = (phonePromptData.description_ = description_);
			string text3 = (phonePromptData.backgroundAddress_ = backgroundAddress_);
			int num3 = (phonePromptData.participationMaxCount_ = participationMaxCount_);
			float num4 = (phonePromptData.bonusMultiplier_ = bonusMultiplier_);
			UnknownFieldSet unknownFieldSet = (phonePromptData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return phonePromptData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x36AD430", Offset = "0x36ABE30", VA = "0x1836AD430", Slot = "0")]
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
							string text3 = backgroundAddress_;
							bool flag3 = default(bool);
							if (!flag3 && participationMaxCount_ == (flag3 ? 1 : 0))
							{
								UnknownFieldSet unknownFields = _unknownFields;
								bool result = default(bool);
								return result;
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x36AD5A0", Offset = "0x36ABFA0", VA = "0x1836AD5A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PhonePromptData other)
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
							string text3 = other.backgroundAddress_;
							if (!(backgroundAddress_ != text3))
							{
								int num = other.participationMaxCount_;
								if (participationMaxCount_ == num)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x36AD830", Offset = "0x36AC230", VA = "0x1836AD830", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_009b
			//IL_0081: Expected O, but got I4
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
			string text3 = backgroundAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode4 = text3.GetHashCode();
			}
			int num = participationMaxCount_;
			int num2 = default(int);
			if (num != 0)
			{
				num2 = 0;
			}
			if (num != 0)
			{
				int hashCode5 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num2);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0x36ADED0", Offset = "0x36AC8D0", VA = "0x1836ADED0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x36ADF30", Offset = "0x36AC930", VA = "0x1836ADF30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b0
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
			if (backgroundAddress_.m_stringLength != 0)
			{
				string value4 = backgroundAddress_;
				output.WriteString(value4);
			}
			if (participationMaxCount_ != 0)
			{
				int value5 = participationMaxCount_;
				output.WriteInt32(value5);
			}
			if (output != null)
			{
				float value6 = bonusMultiplier_;
				output.WriteFloat(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x36AD040", Offset = "0x36ABA40", VA = "0x1836AD040", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00c5
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
			string text3 = backgroundAddress_;
			if (text3.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text3);
				num5++;
				num += num5;
			}
			int num6 = participationMaxCount_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			num += 5;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x36ADB70", Offset = "0x36AC570", VA = "0x1836ADB70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PhonePromptData other)
		{
			//Discarded unreachable code: IL_00cd
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
			string text3 = other.backgroundAddress_;
			if (text3.m_stringLength != 0)
			{
				BackgroundAddress = text3;
			}
			int num = other.participationMaxCount_;
			if (num != 0)
			{
				participationMaxCount_ = num;
			}
			float num2 = other.bonusMultiplier_;
			if (num != 0)
			{
				bonusMultiplier_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x36AD9F0", Offset = "0x36AC3F0", VA = "0x1836AD9F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c5
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (BackgroundAddress = input.ReadString());
				}
				int num2 = default(int);
				if (num == 40)
				{
					num2 = (participationMaxCount_ = input.ReadInt32());
				}
				if (num2 != 53)
				{
					goto IL_00ae;
				}
				float num3 = (bonusMultiplier_ = input.ReadFloat());
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
			string text4 = default(string);
			if ((long)liveopsMetadata == 18)
			{
				text4 = (Name = input.ReadString());
			}
			if ((long)text4 == 26)
			{
				string text6 = (Description = input.ReadString());
			}
			goto IL_00ae;
			IL_00ae:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x36AD6D0", Offset = "0x36AC0D0", VA = "0x1836AD6D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				LiveopsMetadata liveopsMetadata = metadata_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x36ADCB0", Offset = "0x36AC6B0", VA = "0x1836ADCB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_0023, IL_002b, IL_0037, IL_003d, IL_0043, IL_0049
			//IL_0017: Expected O, but got I4
			//IL_002a: Expected F4, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				metadata_ = (LiveopsMetadata)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x36AD1D0", Offset = "0x36ABBD0", VA = "0x1836AD1D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_0009
			if (fieldNumber - 1 > 5)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x36AE090", Offset = "0x36ACA90", VA = "0x1836AE090")]
		static PhonePromptData()
		{
			Func<PhonePromptData> func = default(Func<PhonePromptData>);
			_parser = (MessageParser<PhonePromptData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
