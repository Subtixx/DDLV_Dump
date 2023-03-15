using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000299")]
	public sealed class DefaultItemData : IMessage<DefaultItemData>, IMessage, IEquatable<DefaultItemData>, IDeepCloneable<DefaultItemData>, IMessageFieldAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4000A5D")]
		private static readonly MessageParser<DefaultItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A5E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000A5F")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A60")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000A61")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A62")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A63")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A64")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A65")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A66")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A67")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000A68")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000575")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60019EA")]
			[Cpp2IlInjected.Address(RVA = "0x356FD20", Offset = "0x356E720", VA = "0x18356FD20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000576")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60019EB")]
			[Cpp2IlInjected.Address(RVA = "0x356FC50", Offset = "0x356E650", VA = "0x18356FC50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000577")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60019EC")]
			[Cpp2IlInjected.Address(RVA = "0x356FD80", Offset = "0x356E780", VA = "0x18356FD80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000578")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60019F0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019F1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000579")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60019F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019F3")]
			[Cpp2IlInjected.Address(RVA = "0x356FF70", Offset = "0x356E970", VA = "0x18356FF70")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057A")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60019F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019F5")]
			[Cpp2IlInjected.Address(RVA = "0x356FE90", Offset = "0x356E890", VA = "0x18356FE90")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057B")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60019F6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019F7")]
			[Cpp2IlInjected.Address(RVA = "0x356FF00", Offset = "0x356E900", VA = "0x18356FF00")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057C")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60019F8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019F9")]
			[Cpp2IlInjected.Address(RVA = "0x356FFE0", Offset = "0x356E9E0", VA = "0x18356FFE0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057D")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001A05")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019ED")]
		[Cpp2IlInjected.Address(RVA = "0x356FBD0", Offset = "0x356E5D0", VA = "0x18356FBD0")]
		[DebuggerNonUserCode]
		public DefaultItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60019EE")]
		[Cpp2IlInjected.Address(RVA = "0x356FAB0", Offset = "0x356E4B0", VA = "0x18356FAB0")]
		[DebuggerNonUserCode]
		public DefaultItemData(DefaultItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019EF")]
		[Cpp2IlInjected.Address(RVA = "0x356F260", Offset = "0x356DC60", VA = "0x18356F260", Slot = "10")]
		[DebuggerNonUserCode]
		public DefaultItemData Clone()
		{
			//Discarded unreachable code: IL_0093
			DefaultItemData defaultItemData = new DefaultItemData();
			defaultItemData.name_ = "";
			defaultItemData.displayName_ = "";
			defaultItemData.iconAddress_ = "";
			defaultItemData.prefabAddress_ = "";
			int num = (defaultItemData.iD_ = iD_);
			string text = (defaultItemData.name_ = name_);
			string text2 = (defaultItemData.displayName_ = displayName_);
			string text3 = (defaultItemData.iconAddress_ = iconAddress_);
			string text4 = (defaultItemData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (defaultItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return defaultItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x60019FA")]
		[Cpp2IlInjected.Address(RVA = "0x356F3B0", Offset = "0x356DDB0", VA = "0x18356F3B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(DefaultItemData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x60019FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B3B0", Offset = "0x1D39DB0", VA = "0x181D3B3B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x60019FC")]
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

		[Cpp2IlInjected.Token(Token = "0x60019FD")]
		[Cpp2IlInjected.Address(RVA = "0x356F940", Offset = "0x356E340", VA = "0x18356F940", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60019FE")]
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

		[Cpp2IlInjected.Token(Token = "0x60019FF")]
		[Cpp2IlInjected.Address(RVA = "0x356F000", Offset = "0x356DA00", VA = "0x18356F000", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A00")]
		[Cpp2IlInjected.Address(RVA = "0x356F5B0", Offset = "0x356DFB0", VA = "0x18356F5B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x6001A01")]
		[Cpp2IlInjected.Address(RVA = "0x356F670", Offset = "0x356E070", VA = "0x18356F670", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A02")]
		[Cpp2IlInjected.Address(RVA = "0x356F4B0", Offset = "0x356DEB0", VA = "0x18356F4B0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A03")]
		[Cpp2IlInjected.Address(RVA = "0x356F780", Offset = "0x356E180", VA = "0x18356F780", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A04")]
		[Cpp2IlInjected.Address(RVA = "0x356F190", Offset = "0x356DB90", VA = "0x18356F190", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A06")]
		[Cpp2IlInjected.Address(RVA = "0x356F260", Offset = "0x356DC60", VA = "0x18356F260", Slot = "20")]
		IItemData IItemData.Clone()
		{
			DefaultItemData defaultItemData = new DefaultItemData();
			defaultItemData.name_ = "";
			defaultItemData.displayName_ = "";
			defaultItemData.iconAddress_ = "";
			defaultItemData.prefabAddress_ = "";
			int num = (defaultItemData.iD_ = iD_);
			string text = (defaultItemData.name_ = name_);
			string text2 = (defaultItemData.displayName_ = displayName_);
			string text3 = (defaultItemData.iconAddress_ = iconAddress_);
			string text4 = (defaultItemData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (defaultItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A07")]
		[Cpp2IlInjected.Address(RVA = "0x356F9A0", Offset = "0x356E3A0", VA = "0x18356F9A0")]
		static DefaultItemData()
		{
			Func<DefaultItemData> func = default(Func<DefaultItemData>);
			_parser = (MessageParser<DefaultItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
