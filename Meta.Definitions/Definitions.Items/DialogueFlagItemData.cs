using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000551")]
	public sealed class DialogueFlagItemData : IMessage<DialogueFlagItemData>, IMessage, IEquatable<DialogueFlagItemData>, IDeepCloneable<DialogueFlagItemData>, IMessageFieldAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4001CE4")]
		private static readonly MessageParser<DialogueFlagItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CE5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CE6")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CE7")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001CE8")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CE9")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CEA")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CEB")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CEC")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001CED")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CEE")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001CEF")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001124")]
		[DebuggerNonUserCode]
		public static MessageParser<DialogueFlagItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600425C")]
			[Cpp2IlInjected.Address(RVA = "0x35743A0", Offset = "0x3572DA0", VA = "0x1835743A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001125")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600425D")]
			[Cpp2IlInjected.Address(RVA = "0x35742D0", Offset = "0x3572CD0", VA = "0x1835742D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001126")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600425E")]
			[Cpp2IlInjected.Address(RVA = "0x3574400", Offset = "0x3572E00", VA = "0x183574400", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001127")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004262")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004263")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001128")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004264")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004265")]
			[Cpp2IlInjected.Address(RVA = "0x35745F0", Offset = "0x3572FF0", VA = "0x1835745F0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001129")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004266")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004267")]
			[Cpp2IlInjected.Address(RVA = "0x3574510", Offset = "0x3572F10", VA = "0x183574510")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700112A")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004268")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004269")]
			[Cpp2IlInjected.Address(RVA = "0x3574580", Offset = "0x3572F80", VA = "0x183574580")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700112B")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600426A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600426B")]
			[Cpp2IlInjected.Address(RVA = "0x3574660", Offset = "0x3573060", VA = "0x183574660")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700112C")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004277")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600425F")]
		[Cpp2IlInjected.Address(RVA = "0x3574250", Offset = "0x3572C50", VA = "0x183574250")]
		[DebuggerNonUserCode]
		public DialogueFlagItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004260")]
		[Cpp2IlInjected.Address(RVA = "0x3574130", Offset = "0x3572B30", VA = "0x183574130")]
		[DebuggerNonUserCode]
		public DialogueFlagItemData(DialogueFlagItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004261")]
		[Cpp2IlInjected.Address(RVA = "0x35738E0", Offset = "0x35722E0", VA = "0x1835738E0", Slot = "10")]
		[DebuggerNonUserCode]
		public DialogueFlagItemData Clone()
		{
			//Discarded unreachable code: IL_0093
			DialogueFlagItemData dialogueFlagItemData = new DialogueFlagItemData();
			dialogueFlagItemData.name_ = "";
			dialogueFlagItemData.displayName_ = "";
			dialogueFlagItemData.iconAddress_ = "";
			dialogueFlagItemData.prefabAddress_ = "";
			int num = (dialogueFlagItemData.iD_ = iD_);
			string text = (dialogueFlagItemData.name_ = name_);
			string text2 = (dialogueFlagItemData.displayName_ = displayName_);
			string text3 = (dialogueFlagItemData.iconAddress_ = iconAddress_);
			string text4 = (dialogueFlagItemData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (dialogueFlagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return dialogueFlagItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600426C")]
		[Cpp2IlInjected.Address(RVA = "0x3573A30", Offset = "0x3572430", VA = "0x183573A30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(DialogueFlagItemData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x600426D")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B3B0", Offset = "0x1D39DB0", VA = "0x181D3B3B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DialogueFlagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x600426E")]
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

		[Cpp2IlInjected.Token(Token = "0x600426F")]
		[Cpp2IlInjected.Address(RVA = "0x3573FC0", Offset = "0x35729C0", VA = "0x183573FC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004270")]
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

		[Cpp2IlInjected.Token(Token = "0x6004271")]
		[Cpp2IlInjected.Address(RVA = "0x3573680", Offset = "0x3572080", VA = "0x183573680", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6004272")]
		[Cpp2IlInjected.Address(RVA = "0x3573C30", Offset = "0x3572630", VA = "0x183573C30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DialogueFlagItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x6004273")]
		[Cpp2IlInjected.Address(RVA = "0x3573CF0", Offset = "0x35726F0", VA = "0x183573CF0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x6004274")]
		[Cpp2IlInjected.Address(RVA = "0x3573B30", Offset = "0x3572530", VA = "0x183573B30", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6004275")]
		[Cpp2IlInjected.Address(RVA = "0x3573E00", Offset = "0x3572800", VA = "0x183573E00", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004276")]
		[Cpp2IlInjected.Address(RVA = "0x3573810", Offset = "0x3572210", VA = "0x183573810", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6004278")]
		[Cpp2IlInjected.Address(RVA = "0x35738E0", Offset = "0x35722E0", VA = "0x1835738E0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			DialogueFlagItemData dialogueFlagItemData = new DialogueFlagItemData();
			dialogueFlagItemData.name_ = "";
			dialogueFlagItemData.displayName_ = "";
			dialogueFlagItemData.iconAddress_ = "";
			dialogueFlagItemData.prefabAddress_ = "";
			int num = (dialogueFlagItemData.iD_ = iD_);
			string text = (dialogueFlagItemData.name_ = name_);
			string text2 = (dialogueFlagItemData.displayName_ = displayName_);
			string text3 = (dialogueFlagItemData.iconAddress_ = iconAddress_);
			string text4 = (dialogueFlagItemData.prefabAddress_ = prefabAddress_);
			UnknownFieldSet unknownFieldSet = (dialogueFlagItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004279")]
		[Cpp2IlInjected.Address(RVA = "0x3574020", Offset = "0x3572A20", VA = "0x183574020")]
		static DialogueFlagItemData()
		{
			Func<DialogueFlagItemData> func = default(Func<DialogueFlagItemData>);
			_parser = (MessageParser<DialogueFlagItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
