using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200054A")]
	public sealed class MissionItemBaseData : IMessage<MissionItemBaseData>, IMessage, IEquatable<MissionItemBaseData>, IDeepCloneable<MissionItemBaseData>, IMessageFieldAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4001CB7")]
		private static readonly MessageParser<MissionItemBaseData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CB8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CB9")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CBA")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001CBB")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CBC")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CBD")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CBE")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CBF")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001CC0")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CC1")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001CC2")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001107")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionItemBaseData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60041F2")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C000", Offset = "0x1D3AA00", VA = "0x181D3C000")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001108")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041F3")]
			[Cpp2IlInjected.Address(RVA = "0x1D3BF30", Offset = "0x1D3A930", VA = "0x181D3BF30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001109")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041F4")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C060", Offset = "0x1D3AA60", VA = "0x181D3C060", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110A")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60041F8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041F9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110B")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60041FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041FB")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C250", Offset = "0x1D3AC50", VA = "0x181D3C250")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110C")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60041FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041FD")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C170", Offset = "0x1D3AB70", VA = "0x181D3C170")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110D")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60041FE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041FF")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C1E0", Offset = "0x1D3ABE0", VA = "0x181D3C1E0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110E")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004200")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004201")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C2C0", Offset = "0x1D3ACC0", VA = "0x181D3C2C0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110F")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600420D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BEB0", Offset = "0x1D3A8B0", VA = "0x181D3BEB0")]
		[DebuggerNonUserCode]
		public MissionItemBaseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60041F6")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BD90", Offset = "0x1D3A790", VA = "0x181D3BD90")]
		[DebuggerNonUserCode]
		public MissionItemBaseData(MissionItemBaseData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041F7")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B260", Offset = "0x1D39C60", VA = "0x181D3B260", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionItemBaseData Clone()
		{
			//Discarded unreachable code: IL_0093
			MissionItemBaseData missionItemBaseData = new MissionItemBaseData();
			missionItemBaseData.name_ = "";
			missionItemBaseData.displayName_ = "";
			missionItemBaseData.iconAddress_ = "";
			missionItemBaseData.prefabAddress_ = "";
			int num = (missionItemBaseData.iD_ = iD_);
			string text = (missionItemBaseData.name_ = name_);
			string text2 = (missionItemBaseData.displayName_ = displayName_);
			string text3 = (missionItemBaseData.iconAddress_ = iconAddress_);
			string text4 = (missionItemBaseData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (missionItemBaseData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionItemBaseData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004202")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B460", Offset = "0x1D39E60", VA = "0x181D3B460", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(MissionItemBaseData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x6004203")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B3B0", Offset = "0x1D39DB0", VA = "0x181D3B3B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionItemBaseData other)
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

		[Cpp2IlInjected.Token(Token = "0x6004204")]
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

		[Cpp2IlInjected.Token(Token = "0x6004205")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BAF0", Offset = "0x1D3A4F0", VA = "0x181D3BAF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004206")]
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

		[Cpp2IlInjected.Token(Token = "0x6004207")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B000", Offset = "0x1D39A00", VA = "0x181D3B000", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6004208")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B760", Offset = "0x1D3A160", VA = "0x181D3B760", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionItemBaseData other)
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

		[Cpp2IlInjected.Token(Token = "0x6004209")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B820", Offset = "0x1D3A220", VA = "0x181D3B820", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x600420A")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B560", Offset = "0x1D39F60", VA = "0x181D3B560", Slot = "11")]
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
							string text = prefabAddress_;
						}
						string text2 = iconAddress_;
					}
					string text3 = displayName_;
				}
				string text4 = name_;
			}
			int num2 = iD_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600420B")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B930", Offset = "0x1D3A330", VA = "0x181D3B930", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600420C")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B190", Offset = "0x1D39B90", VA = "0x181D3B190", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x600420E")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B260", Offset = "0x1D39C60", VA = "0x181D3B260", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MissionItemBaseData missionItemBaseData = new MissionItemBaseData();
			missionItemBaseData.name_ = "";
			missionItemBaseData.displayName_ = "";
			missionItemBaseData.iconAddress_ = "";
			missionItemBaseData.prefabAddress_ = "";
			int num = (missionItemBaseData.iD_ = iD_);
			string text = (missionItemBaseData.name_ = name_);
			string text2 = (missionItemBaseData.displayName_ = displayName_);
			string text3 = (missionItemBaseData.iconAddress_ = iconAddress_);
			string text4 = (missionItemBaseData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (missionItemBaseData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600420F")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BC80", Offset = "0x1D3A680", VA = "0x181D3BC80")]
		static MissionItemBaseData()
		{
			Func<MissionItemBaseData> func = default(Func<MissionItemBaseData>);
			_parser = (MessageParser<MissionItemBaseData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
