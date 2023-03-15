using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000335")]
	public sealed class PointOfInterestItemData : IMessage<PointOfInterestItemData>, IMessage, IEquatable<PointOfInterestItemData>, IDeepCloneable<PointOfInterestItemData>, IMessageFieldAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x400103C")]
		private static readonly MessageParser<PointOfInterestItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400103D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400103E")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400103F")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001040")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001041")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001042")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001043")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001044")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001045")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000922")]
		[DebuggerNonUserCode]
		public static MessageParser<PointOfInterestItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600252E")]
			[Cpp2IlInjected.Address(RVA = "0x287AE50", Offset = "0x2879850", VA = "0x18287AE50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000923")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600252F")]
			[Cpp2IlInjected.Address(RVA = "0x287AD80", Offset = "0x2879780", VA = "0x18287AD80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000924")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002530")]
			[Cpp2IlInjected.Address(RVA = "0x287AEF0", Offset = "0x28798F0", VA = "0x18287AEF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000925")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002534")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002535")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000926")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002536")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002537")]
			[Cpp2IlInjected.Address(RVA = "0x287B0E0", Offset = "0x2879AE0", VA = "0x18287B0E0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000927")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002538")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002539")]
			[Cpp2IlInjected.Address(RVA = "0x287B000", Offset = "0x2879A00", VA = "0x18287B000")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000928")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600253A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600253B")]
			[Cpp2IlInjected.Address(RVA = "0x287B070", Offset = "0x2879A70", VA = "0x18287B070")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000929")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002547")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700092A")]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002548")]
			[Cpp2IlInjected.Address(RVA = "0x287AEB0", Offset = "0x28798B0", VA = "0x18287AEB0", Slot = "19")]
			get
			{
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002531")]
		[Cpp2IlInjected.Address(RVA = "0x287AD10", Offset = "0x2879710", VA = "0x18287AD10")]
		[DebuggerNonUserCode]
		public PointOfInterestItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002532")]
		[Cpp2IlInjected.Address(RVA = "0x287AC10", Offset = "0x2879610", VA = "0x18287AC10")]
		[DebuggerNonUserCode]
		public PointOfInterestItemData(PointOfInterestItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002533")]
		[Cpp2IlInjected.Address(RVA = "0x287A230", Offset = "0x2878C30", VA = "0x18287A230", Slot = "10")]
		[DebuggerNonUserCode]
		public PointOfInterestItemData Clone()
		{
			//Discarded unreachable code: IL_0078
			PointOfInterestItemData pointOfInterestItemData = new PointOfInterestItemData();
			pointOfInterestItemData.name_ = "";
			pointOfInterestItemData.displayName_ = "";
			pointOfInterestItemData.iconAddress_ = "";
			int num = (pointOfInterestItemData.iD_ = iD_);
			string text = (pointOfInterestItemData.name_ = name_);
			string text2 = (pointOfInterestItemData.displayName_ = displayName_);
			string text3 = (pointOfInterestItemData.iconAddress_ = iconAddress_);
			UnknownFieldSet unknownFieldSet = (pointOfInterestItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pointOfInterestItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600253C")]
		[Cpp2IlInjected.Address(RVA = "0x287A400", Offset = "0x2878E00", VA = "0x18287A400", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(PointOfInterestItemData).TypeHandle)
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
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600253D")]
		[Cpp2IlInjected.Address(RVA = "0x287A360", Offset = "0x2878D60", VA = "0x18287A360", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PointOfInterestItemData other)
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

		[Cpp2IlInjected.Token(Token = "0x600253E")]
		[Cpp2IlInjected.Address(RVA = "0x287A5D0", Offset = "0x2878FD0", VA = "0x18287A5D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006b
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
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600253F")]
		[Cpp2IlInjected.Address(RVA = "0x287A9A0", Offset = "0x28793A0", VA = "0x18287A9A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002540")]
		[Cpp2IlInjected.Address(RVA = "0x287AA00", Offset = "0x2879400", VA = "0x18287AA00", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0081
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
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002541")]
		[Cpp2IlInjected.Address(RVA = "0x287A030", Offset = "0x2878A30", VA = "0x18287A030", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a0
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
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002542")]
		[Cpp2IlInjected.Address(RVA = "0x287A790", Offset = "0x2879190", VA = "0x18287A790", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PointOfInterestItemData other)
		{
			//Discarded unreachable code: IL_007e
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
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002543")]
		[Cpp2IlInjected.Address(RVA = "0x287A6A0", Offset = "0x28790A0", VA = "0x18287A6A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0079
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
				if (num != 34)
				{
					goto IL_0062;
				}
				string text4 = (IconAddress = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text6 = (Name = input.ReadString());
			}
			goto IL_0062;
			IL_0062:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002544")]
		[Cpp2IlInjected.Address(RVA = "0x287A4E0", Offset = "0x2878EE0", VA = "0x18287A4E0", Slot = "11")]
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
						string text = iconAddress_;
					}
					string text2 = displayName_;
				}
				string text3 = name_;
			}
			int num2 = iD_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002545")]
		[Cpp2IlInjected.Address(RVA = "0x287A830", Offset = "0x2879230", VA = "0x18287A830", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0040
			//IL_0025: Expected O, but got I4
			//IL_003f: Expected I4, but got O
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
							IconAddress = (string)num2;
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
			else
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002546")]
		[Cpp2IlInjected.Address(RVA = "0x287A180", Offset = "0x2878B80", VA = "0x18287A180", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0041: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						IconAddress = "";
						break;
					case 0:
						DisplayName = "";
						break;
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

		[Cpp2IlInjected.Token(Token = "0x6002549")]
		[Cpp2IlInjected.Address(RVA = "0x287A230", Offset = "0x2878C30", VA = "0x18287A230", Slot = "20")]
		IItemData IItemData.Clone()
		{
			PointOfInterestItemData pointOfInterestItemData = new PointOfInterestItemData();
			pointOfInterestItemData.name_ = "";
			pointOfInterestItemData.displayName_ = "";
			pointOfInterestItemData.iconAddress_ = "";
			int num = (pointOfInterestItemData.iD_ = iD_);
			string text = (pointOfInterestItemData.name_ = name_);
			string text2 = (pointOfInterestItemData.displayName_ = displayName_);
			string text3 = (pointOfInterestItemData.iconAddress_ = iconAddress_);
			UnknownFieldSet unknownFieldSet = (pointOfInterestItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600254A")]
		[Cpp2IlInjected.Address(RVA = "0x287AB00", Offset = "0x2879500", VA = "0x18287AB00")]
		static PointOfInterestItemData()
		{
			Func<PointOfInterestItemData> func = default(Func<PointOfInterestItemData>);
			_parser = (MessageParser<PointOfInterestItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
