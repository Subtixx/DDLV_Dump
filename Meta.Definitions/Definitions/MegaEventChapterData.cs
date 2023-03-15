using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class MegaEventChapterData : IMessage<MegaEventChapterData>, IMessage, IEquatable<MegaEventChapterData>, IDeepCloneable<MegaEventChapterData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private static readonly MessageParser<MegaEventChapterData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public const int OpenDelayFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Duration openDelay_;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public const int NodePosFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private MegaEventNodePos nodePos_;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public const int CharacterIdFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int characterId_;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public const int RequestsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private static readonly FieldCodec<MegaEventRequestData> _repeated_requests_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly RepeatedField<MegaEventRequestData> requests_ = (RepeatedField<MegaEventRequestData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		[DebuggerNonUserCode]
		public static MessageParser<MegaEventChapterData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x3071280", Offset = "0x306FC80", VA = "0x183071280")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x30711B0", Offset = "0x306FBB0", VA = "0x1830711B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x30712E0", Offset = "0x306FCE0", VA = "0x1830712E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x30713F0", Offset = "0x306FDF0", VA = "0x1830713F0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[DebuggerNonUserCode]
		public Duration OpenDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return openDelay_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				openDelay_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		[DebuggerNonUserCode]
		public MegaEventNodePos NodePos
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return nodePos_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				nodePos_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		[DebuggerNonUserCode]
		public int CharacterId
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return characterId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				characterId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		[DebuggerNonUserCode]
		public RepeatedField<MegaEventRequestData> Requests
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return requests_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3071150", Offset = "0x306FB50", VA = "0x183071150")]
			get
			{
				long num = Convert.ToInt64((uint)characterId_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x3070EC0", Offset = "0x306F8C0", VA = "0x183070EC0")]
		[DebuggerNonUserCode]
		public MegaEventChapterData()
		{
			Duration duration = (openDelay_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x30708E0", Offset = "0x306F2E0", VA = "0x1830708E0")]
		private void OnConstruction()
		{
			Duration duration = (openDelay_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x3070FA0", Offset = "0x306F9A0", VA = "0x183070FA0")]
		[DebuggerNonUserCode]
		public MegaEventChapterData(MegaEventChapterData other)
		{
			//IL_0057: Expected O, but got I4
			Duration duration = (openDelay_ = new Duration());
			string text = (name_ = other.name_);
			Duration duration2 = other.openDelay_;
			if (duration2 != null)
			{
				Duration duration3 = duration2.Clone();
			}
			int num = 0;
			openDelay_ = (Duration)num;
			MegaEventNodePos megaEventNodePos = (nodePos_ = other.nodePos_);
			int num2 = (characterId_ = other.characterId_);
			RepeatedField<MegaEventRequestData> repeatedField = (requests_ = (RepeatedField<MegaEventRequestData>)(object)((RepeatedField<T>)(object)other.requests_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x3070040", Offset = "0x306EA40", VA = "0x183070040", Slot = "10")]
		[DebuggerNonUserCode]
		public MegaEventChapterData Clone()
		{
			//Discarded unreachable code: IL_00a6
			//IL_005a: Expected O, but got I4
			MegaEventChapterData megaEventChapterData = new MegaEventChapterData();
			megaEventChapterData.name_ = "";
			RepeatedField<MegaEventRequestData> repeatedField = (megaEventChapterData.requests_ = (RepeatedField<MegaEventRequestData>)(object)new RepeatedField<T>());
			Duration duration = (megaEventChapterData.openDelay_ = new Duration());
			string text = (megaEventChapterData.name_ = name_);
			Duration duration2 = openDelay_;
			if (duration2 != null)
			{
				Duration duration3 = duration2.Clone();
			}
			int num = 0;
			megaEventChapterData.openDelay_ = (Duration)num;
			MegaEventNodePos megaEventNodePos = (megaEventChapterData.nodePos_ = nodePos_);
			int num2 = (megaEventChapterData.characterId_ = characterId_);
			RepeatedField<MegaEventRequestData> repeatedField2 = (megaEventChapterData.requests_ = (RepeatedField<MegaEventRequestData>)(object)((RepeatedField<T>)(object)requests_).Clone());
			UnknownFieldSet unknownFieldSet = (megaEventChapterData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return megaEventChapterData;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x3070220", Offset = "0x306EC20", VA = "0x183070220", Slot = "0")]
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
				string text = name_;
				bool flag = default(bool);
				if (!flag)
				{
					bool flag2 = object.Equals(openDelay_, other);
					if (flag2 && nodePos_ == (flag2 ? MegaEventNodePos.Middle : MegaEventNodePos.Bottom) && characterId_ == (flag2 ? 1 : 0))
					{
						RepeatedField<MegaEventRequestData> repeatedField = requests_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x3070330", Offset = "0x306ED30", VA = "0x183070330", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MegaEventChapterData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					Duration objB = other.openDelay_;
					if (object.Equals(openDelay_, objB))
					{
						MegaEventNodePos megaEventNodePos = other.nodePos_;
						if (nodePos_ == megaEventNodePos)
						{
							int num = other.characterId_;
							if (characterId_ == num)
							{
								RepeatedField<MegaEventRequestData> repeatedField = requests_;
								RepeatedField<MegaEventRequestData> repeatedField2 = other.requests_;
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x3070520", Offset = "0x306EF20", VA = "0x183070520", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0063
			int num = 0;
			string text = name_;
			if (text.m_stringLength != num)
			{
				int hashCode = text.GetHashCode();
			}
			Duration duration = openDelay_;
			if (duration != null)
			{
				int hashCode2 = duration.GetHashCode();
			}
			if (nodePos_ != 0)
			{
			}
			if (characterId_ != 0)
			{
			}
			int hashCode3 = ((RepeatedField<T>)(object)requests_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x3070B20", Offset = "0x306F520", VA = "0x183070B20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x3070B80", Offset = "0x306F580", VA = "0x183070B80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0082
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			if ((long)openDelay_ != 0)
			{
				Duration value2 = openDelay_;
				output.WriteMessage(value2);
			}
			if (nodePos_ != 0)
			{
			}
			if (characterId_ != 0)
			{
				int value3 = characterId_;
				output.WriteInt32(value3);
			}
			RepeatedField<MegaEventRequestData> repeatedField = requests_;
			FieldCodec<MegaEventRequestData> repeated_requests_codec = _repeated_requests_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_requests_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x306FDC0", Offset = "0x306E7C0", VA = "0x18306FDC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00b5
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			Duration duration = openDelay_;
			if (duration != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(duration);
				num3++;
				num += num3;
			}
			MegaEventNodePos megaEventNodePos = nodePos_;
			if (megaEventNodePos != 0)
			{
				int num4 = CodedOutputStream.ComputeEnumSize((int)megaEventNodePos);
				num4++;
				num += num4;
			}
			int num5 = characterId_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			RepeatedField<MegaEventRequestData> repeatedField = requests_;
			FieldCodec<MegaEventRequestData> repeated_requests_codec = _repeated_requests_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_requests_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num7;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x3070600", Offset = "0x306F000", VA = "0x183070600", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MegaEventChapterData other)
		{
			//Discarded unreachable code: IL_00b7
			if (other == null)
			{
				return;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			if ((long)other.openDelay_ != 0)
			{
				Duration duration2 = default(Duration);
				if (openDelay_ == null)
				{
					Duration duration = (openDelay_ = new Duration());
					duration2 = openDelay_;
				}
				Duration other2 = other.openDelay_;
				duration2.MergeFrom(other2);
			}
			MegaEventNodePos megaEventNodePos = other.nodePos_;
			if (megaEventNodePos != 0)
			{
				nodePos_ = megaEventNodePos;
			}
			int num = other.characterId_;
			if (num != 0)
			{
				characterId_ = num;
			}
			RepeatedField<MegaEventRequestData> repeatedField = requests_;
			RepeatedField<MegaEventRequestData> repeatedField2 = other.requests_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x3070720", Offset = "0x306F120", VA = "0x183070720", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					int num2 = (int)(nodePos_ = (MegaEventNodePos)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (characterId_ = input.ReadInt32());
				}
				if (num3 != 42)
				{
					goto IL_009f;
				}
				RepeatedField<MegaEventRequestData> repeatedField = requests_;
				FieldCodec<MegaEventRequestData> repeated_requests_codec = _repeated_requests_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_requests_codec);
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (Name = input.ReadString());
			}
			if ((long)text2 == 18)
			{
				Duration builder = default(Duration);
				if (openDelay_ == null)
				{
					Duration duration = (openDelay_ = new Duration());
					builder = openDelay_;
				}
				input.ReadMessage(builder);
			}
			goto IL_009f;
			IL_009f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x3070400", Offset = "0x306EE00", VA = "0x183070400", Slot = "11")]
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
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							RepeatedField<MegaEventRequestData> repeatedField = requests_;
						}
						int num2 = characterId_;
					}
					MegaEventNodePos megaEventNodePos = nodePos_;
				}
				Duration duration = openDelay_;
			}
			string text = name_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x3070940", Offset = "0x306F340", VA = "0x183070940", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0)
					{
						object obj = default(object);
						nodePos_ = (MegaEventNodePos)obj;
						return;
					}
					if (num == 0 || num != 1)
					{
						object obj2 = default(object);
						characterId_ = (int)obj2;
						return;
					}
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				}
				else if (value == null || value != null)
				{
					openDelay_ = (Duration)value;
					goto IL_0037;
				}
				throw new InvalidCastException();
			}
			goto IL_0037;
			IL_0037:
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x306FF60", Offset = "0x306E960", VA = "0x18306FF60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_003f
			//IL_0028: Expected I4, but got I8
			//IL_0032: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						RepeatedField<MegaEventRequestData> repeatedField = requests_;
						break;
					}
					case 0:
						break;
					default:
						return;
					}
					characterId_ = 0;
				}
				else
				{
					nodePos_ = MegaEventNodePos.Bottom;
				}
			}
			else
			{
				Name = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x3070CF0", Offset = "0x306F6F0", VA = "0x183070CF0")]
		static MegaEventChapterData()
		{
			Func<MegaEventChapterData> func = default(Func<MegaEventChapterData>);
			_parser = (MessageParser<MegaEventChapterData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<MegaEventRequestData> parser = MegaEventRequestData._parser;
			uint num = default(uint);
			_parser = (MessageParser<MegaEventChapterData>)(object)FieldCodec.ForMessage<MegaEventRequestData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
