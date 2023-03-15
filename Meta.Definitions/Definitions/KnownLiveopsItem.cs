using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class KnownLiveopsItem : IMessage<KnownLiveopsItem>, IMessage, IEquatable<KnownLiveopsItem>, IDeepCloneable<KnownLiveopsItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private static readonly MessageParser<KnownLiveopsItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private string id_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public const int VersionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public const int LanguageFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private string language_ = "";

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public const int LastUpdateTimestampFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private ConditionDate lastUpdateTimestamp_;

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		[DebuggerNonUserCode]
		public static MessageParser<KnownLiveopsItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x2740F10", Offset = "0x273F910", VA = "0x182740F10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x2740E40", Offset = "0x273F840", VA = "0x182740E40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2740F70", Offset = "0x273F970", VA = "0x182740F70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[DebuggerNonUserCode]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0x2741080", Offset = "0x273FA80", VA = "0x182741080")]
			set
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0x27410F0", Offset = "0x273FAF0", VA = "0x1827410F0")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		[DebuggerNonUserCode]
		public ConditionDate LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return lastUpdateTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				lastUpdateTimestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2740CF0", Offset = "0x273F6F0", VA = "0x182740CF0")]
		[DebuggerNonUserCode]
		public KnownLiveopsItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2740D50", Offset = "0x273F750", VA = "0x182740D50")]
		[DebuggerNonUserCode]
		public KnownLiveopsItem(KnownLiveopsItem other)
		{
			//IL_0064: Expected O, but got I4
			string text = (id_ = other.id_);
			int num = (version_ = other.version_);
			string text2 = (language_ = other.language_);
			ConditionDate conditionDate = other.lastUpdateTimestamp_;
			if (conditionDate != null)
			{
				ConditionDate conditionDate2 = conditionDate.Clone();
			}
			int num2 = 0;
			lastUpdateTimestamp_ = (ConditionDate)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x2740260", Offset = "0x273EC60", VA = "0x182740260", Slot = "10")]
		[DebuggerNonUserCode]
		public KnownLiveopsItem Clone()
		{
			//Discarded unreachable code: IL_007e
			//IL_0067: Expected O, but got I4
			KnownLiveopsItem knownLiveopsItem = new KnownLiveopsItem();
			knownLiveopsItem.id_ = "";
			knownLiveopsItem.language_ = "";
			string text = (knownLiveopsItem.id_ = id_);
			int num = (knownLiveopsItem.version_ = version_);
			string text2 = (knownLiveopsItem.language_ = language_);
			ConditionDate conditionDate = lastUpdateTimestamp_;
			if (conditionDate != null)
			{
				ConditionDate conditionDate2 = conditionDate.Clone();
			}
			int num2 = 0;
			knownLiveopsItem.lastUpdateTimestamp_ = (ConditionDate)num2;
			UnknownFieldSet unknownFieldSet = (knownLiveopsItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return knownLiveopsItem;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2740420", Offset = "0x273EE20", VA = "0x182740420", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = id_;
				bool flag = default(bool);
				if (!flag && version_ == (flag ? 1 : 0))
				{
					string text2 = language_;
					bool flag2 = default(bool);
					if (!flag2 && object.Equals(lastUpdateTimestamp_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2740380", Offset = "0x273ED80", VA = "0x182740380", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(KnownLiveopsItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.id_;
				if (!(id_ != text))
				{
					int num = other.version_;
					if (version_ == num)
					{
						string text2 = other.language_;
						if (!(language_ != text2))
						{
							ConditionDate objB = other.lastUpdateTimestamp_;
							if (object.Equals(lastUpdateTimestamp_, objB))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x27405F0", Offset = "0x273EFF0", VA = "0x1827405F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0066
			string text = id_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (version_ != 0)
			{
			}
			string text2 = language_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			ConditionDate conditionDate = lastUpdateTimestamp_;
			if (conditionDate != null)
			{
				int hashCode3 = conditionDate.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x2740A90", Offset = "0x273F490", VA = "0x182740A90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x2740AF0", Offset = "0x273F4F0", VA = "0x182740AF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007e
			if (id_.m_stringLength != 0)
			{
				string value = id_;
				output.WriteString(value);
			}
			if (version_ != 0)
			{
				int value2 = version_;
				output.WriteInt32(value2);
			}
			if (language_.m_stringLength != 0)
			{
				string value3 = language_;
				output.WriteString(value3);
			}
			if ((long)lastUpdateTimestamp_ != 0)
			{
				ConditionDate value4 = lastUpdateTimestamp_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x2740070", Offset = "0x273EA70", VA = "0x182740070", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009b
			string text = id_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			int num3 = version_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			string text2 = language_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num += num5;
			}
			ConditionDate conditionDate = lastUpdateTimestamp_;
			if (conditionDate != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(conditionDate);
				num6++;
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x27406C0", Offset = "0x273F0C0", VA = "0x1827406C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(KnownLiveopsItem other)
		{
			//Discarded unreachable code: IL_00a1
			if (other == null)
			{
				return;
			}
			string text = other.id_;
			if (text.m_stringLength != 0)
			{
				Id = text;
			}
			int num = other.version_;
			if (num != 0)
			{
				version_ = num;
			}
			string text2 = other.language_;
			if (text2.m_stringLength != 0)
			{
				Language = text2;
			}
			if ((long)other.lastUpdateTimestamp_ != 0)
			{
				ConditionDate conditionDate2 = default(ConditionDate);
				if (lastUpdateTimestamp_ == null)
				{
					ConditionDate conditionDate = (lastUpdateTimestamp_ = new ConditionDate());
					conditionDate2 = lastUpdateTimestamp_;
				}
				ConditionDate other2 = other.lastUpdateTimestamp_;
				conditionDate2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x27407D0", Offset = "0x273F1D0", VA = "0x1827407D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0098
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					string text2 = (Language = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_0081;
				}
				ConditionDate builder = default(ConditionDate);
				if (lastUpdateTimestamp_ == null)
				{
					ConditionDate conditionDate = (lastUpdateTimestamp_ = new ConditionDate());
					builder = lastUpdateTimestamp_;
				}
				input.ReadMessage(builder);
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (Id = input.ReadString());
			}
			if ((long)text4 == 16)
			{
				int num2 = (version_ = input.ReadInt32());
			}
			goto IL_0081;
			IL_0081:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x2740500", Offset = "0x273EF00", VA = "0x182740500", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						ConditionDate conditionDate = lastUpdateTimestamp_;
					}
					string text = language_;
				}
				int num2 = version_;
			}
			string text2 = id_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x2740910", Offset = "0x273F310", VA = "0x182740910", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
			//IL_0036: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							lastUpdateTimestamp_ = (ConditionDate)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
						if (value == null || value != null)
						{
							break;
						}
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj = default(object);
					version_ = (int)obj;
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x27401B0", Offset = "0x273EBB0", VA = "0x1827401B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0029: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num == 1)
					{
						Language = "";
					}
				}
				else
				{
					version_ = 0;
				}
			}
			else
			{
				Id = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x2740BE0", Offset = "0x273F5E0", VA = "0x182740BE0")]
		static KnownLiveopsItem()
		{
			Func<KnownLiveopsItem> func = default(Func<KnownLiveopsItem>);
			_parser = (MessageParser<KnownLiveopsItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
