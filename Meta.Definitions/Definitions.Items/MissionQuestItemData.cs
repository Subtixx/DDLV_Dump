using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000546")]
	public sealed class MissionQuestItemData : IMessage<MissionQuestItemData>, IMessage, IEquatable<MissionQuestItemData>, IDeepCloneable<MissionQuestItemData>, IMessageFieldAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4001CA4")]
		private static readonly MessageParser<MissionQuestItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CA5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CA6")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CA7")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001CA8")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CA9")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CAA")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CAB")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CAC")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001CAD")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CAE")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001CAF")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x170010FA")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionQuestItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60041BB")]
			[Cpp2IlInjected.Address(RVA = "0x29E0D40", Offset = "0x29DF740", VA = "0x1829E0D40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010FB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041BC")]
			[Cpp2IlInjected.Address(RVA = "0x29E0C70", Offset = "0x29DF670", VA = "0x1829E0C70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010FC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041BD")]
			[Cpp2IlInjected.Address(RVA = "0x29E0DA0", Offset = "0x29DF7A0", VA = "0x1829E0DA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010FD")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60041C1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041C2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010FE")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60041C3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041C4")]
			[Cpp2IlInjected.Address(RVA = "0x29E0F90", Offset = "0x29DF990", VA = "0x1829E0F90")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010FF")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60041C5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041C6")]
			[Cpp2IlInjected.Address(RVA = "0x29E0EB0", Offset = "0x29DF8B0", VA = "0x1829E0EB0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001100")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60041C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041C8")]
			[Cpp2IlInjected.Address(RVA = "0x29E0F20", Offset = "0x29DF920", VA = "0x1829E0F20")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001101")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60041C9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041CA")]
			[Cpp2IlInjected.Address(RVA = "0x29E1000", Offset = "0x29DFA00", VA = "0x1829E1000")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001102")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60041D6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041BE")]
		[Cpp2IlInjected.Address(RVA = "0x29E0AD0", Offset = "0x29DF4D0", VA = "0x1829E0AD0")]
		[DebuggerNonUserCode]
		public MissionQuestItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60041BF")]
		[Cpp2IlInjected.Address(RVA = "0x29E0B50", Offset = "0x29DF550", VA = "0x1829E0B50")]
		[DebuggerNonUserCode]
		public MissionQuestItemData(MissionQuestItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041C0")]
		[Cpp2IlInjected.Address(RVA = "0x29E0280", Offset = "0x29DEC80", VA = "0x1829E0280", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionQuestItemData Clone()
		{
			//Discarded unreachable code: IL_0093
			MissionQuestItemData missionQuestItemData = new MissionQuestItemData();
			missionQuestItemData.name_ = "";
			missionQuestItemData.displayName_ = "";
			missionQuestItemData.iconAddress_ = "";
			missionQuestItemData.prefabAddress_ = "";
			int num = (missionQuestItemData.iD_ = iD_);
			string text = (missionQuestItemData.name_ = name_);
			string text2 = (missionQuestItemData.displayName_ = displayName_);
			string text3 = (missionQuestItemData.iconAddress_ = iconAddress_);
			string text4 = (missionQuestItemData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (missionQuestItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionQuestItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x60041CB")]
		[Cpp2IlInjected.Address(RVA = "0x29E03D0", Offset = "0x29DEDD0", VA = "0x1829E03D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(MissionQuestItemData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x60041CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B3B0", Offset = "0x1D39DB0", VA = "0x181D3B3B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionQuestItemData other)
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
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B660", Offset = "0x1D3A060", VA = "0x181D3B660", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0086
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
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60041CE")]
		[Cpp2IlInjected.Address(RVA = "0x29E0960", Offset = "0x29DF360", VA = "0x1829E0960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60041CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BB50", Offset = "0x1D3A550", VA = "0x181D3BB50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_009f
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
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60041D0")]
		[Cpp2IlInjected.Address(RVA = "0x29E0020", Offset = "0x29DEA20", VA = "0x1829E0020", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00c6
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
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num2 += num8;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60041D1")]
		[Cpp2IlInjected.Address(RVA = "0x29E06E0", Offset = "0x29DF0E0", VA = "0x1829E06E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionQuestItemData other)
		{
			//Discarded unreachable code: IL_0098
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
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041D2")]
		[Cpp2IlInjected.Address(RVA = "0x29E05D0", Offset = "0x29DEFD0", VA = "0x1829E05D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0094
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if (num == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_007d;
				}
				string text6 = (PrefabAddress = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_007d;
			IL_007d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60041D3")]
		[Cpp2IlInjected.Address(RVA = "0x29E04D0", Offset = "0x29DEED0", VA = "0x1829E04D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 0 && num == 1)
			{
				string text = prefabAddress_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041D4")]
		[Cpp2IlInjected.Address(RVA = "0x29E07A0", Offset = "0x29DF1A0", VA = "0x1829E07A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_004d
			//IL_0029: Expected O, but got I4
			//IL_004c: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
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
								PrefabAddress = (string)num2;
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
					else if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041D5")]
		[Cpp2IlInjected.Address(RVA = "0x29E01B0", Offset = "0x29DEBB0", VA = "0x1829E01B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0051: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
							PrefabAddress = "";
							break;
						case 0:
							IconAddress = "";
							break;
						}
					}
					else
					{
						DisplayName = "";
					}
				}
				else
				{
					Name = "";
				}
			}
			else
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041D7")]
		[Cpp2IlInjected.Address(RVA = "0x29E0280", Offset = "0x29DEC80", VA = "0x1829E0280", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MissionQuestItemData missionQuestItemData = new MissionQuestItemData();
			missionQuestItemData.name_ = "";
			missionQuestItemData.displayName_ = "";
			missionQuestItemData.iconAddress_ = "";
			missionQuestItemData.prefabAddress_ = "";
			int num = (missionQuestItemData.iD_ = iD_);
			string text = (missionQuestItemData.name_ = name_);
			string text2 = (missionQuestItemData.displayName_ = displayName_);
			string text3 = (missionQuestItemData.iconAddress_ = iconAddress_);
			string text4 = (missionQuestItemData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (missionQuestItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041D8")]
		[Cpp2IlInjected.Address(RVA = "0x29E09C0", Offset = "0x29DF3C0", VA = "0x1829E09C0")]
		static MissionQuestItemData()
		{
			Func<MissionQuestItemData> func = default(Func<MissionQuestItemData>);
			_parser = (MessageParser<MissionQuestItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
