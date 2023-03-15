using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class DeviceInfo : IMessage<DeviceInfo>, IMessage, IEquatable<DeviceInfo>, IDeepCloneable<DeviceInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly MessageParser<DeviceInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public const int DeviceTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private DeviceType deviceType_;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public const int DeviceIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private string deviceID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public const int DeviceModelFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private string deviceModel_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public const int DeviceNameFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private string deviceName_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public static MessageParser<DeviceInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x35733C0", Offset = "0x3571DC0", VA = "0x1835733C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x35732F0", Offset = "0x3571CF0", VA = "0x1835732F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3573420", Offset = "0x3571E20", VA = "0x183573420", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public DeviceType DeviceType
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return deviceType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				deviceType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public string DeviceID
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return deviceID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x3573530", Offset = "0x3571F30", VA = "0x183573530")]
			set
			{
				string text = (deviceID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public string DeviceModel
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return deviceModel_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x35735A0", Offset = "0x3571FA0", VA = "0x1835735A0")]
			set
			{
				string text = (deviceModel_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public string DeviceName
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return deviceName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x3573610", Offset = "0x3572010", VA = "0x183573610")]
			set
			{
				string text = (deviceName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3573180", Offset = "0x3571B80", VA = "0x183573180")]
		[DebuggerNonUserCode]
		public DeviceInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x35731F0", Offset = "0x3571BF0", VA = "0x1835731F0")]
		[DebuggerNonUserCode]
		public DeviceInfo(DeviceInfo other)
		{
			DeviceType deviceType = (deviceType_ = other.deviceType_);
			string text = (deviceID_ = other.deviceID_);
			string text2 = (deviceModel_ = other.deviceModel_);
			string text3 = (deviceName_ = other.deviceName_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3572A10", Offset = "0x3571410", VA = "0x183572A10", Slot = "10")]
		[DebuggerNonUserCode]
		public DeviceInfo Clone()
		{
			//Discarded unreachable code: IL_0078
			DeviceInfo deviceInfo = new DeviceInfo();
			deviceInfo.deviceID_ = "";
			deviceInfo.deviceModel_ = "";
			deviceInfo.deviceName_ = "";
			DeviceType deviceType = (deviceInfo.deviceType_ = deviceType_);
			string text = (deviceInfo.deviceID_ = deviceID_);
			string text2 = (deviceInfo.deviceModel_ = deviceModel_);
			string text3 = (deviceInfo.deviceName_ = deviceName_);
			UnknownFieldSet unknownFieldSet = (deviceInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return deviceInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3572B40", Offset = "0x3571540", VA = "0x183572B40", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)deviceType_ == (IntPtr)typeof(DeviceInfo).TypeHandle)
				{
					string text = deviceID_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = deviceModel_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = deviceName_;
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

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x287A360", Offset = "0x2878D60", VA = "0x18287A360", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DeviceInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				DeviceType deviceType = other.deviceType_;
				if (deviceType_ == deviceType)
				{
					string text = other.deviceID_;
					if (!(deviceID_ != text))
					{
						string text2 = other.deviceModel_;
						if (!(deviceModel_ != text2))
						{
							string text3 = other.deviceName_;
							if (!(deviceName_ != text3))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x287A5D0", Offset = "0x2878FD0", VA = "0x18287A5D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006b
			if (deviceType_ != 0)
			{
			}
			string text = deviceID_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = deviceModel_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = deviceName_;
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

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3573010", Offset = "0x3571A10", VA = "0x183573010", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x287AA00", Offset = "0x2879400", VA = "0x18287AA00", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0070
			if (deviceType_ != 0)
			{
			}
			if (deviceID_.m_stringLength != 0)
			{
				string value = deviceID_;
				output.WriteString(value);
			}
			if (deviceModel_.m_stringLength != 0)
			{
				string value2 = deviceModel_;
				output.WriteString(value2);
			}
			if (deviceName_.m_stringLength != 0)
			{
				string value3 = deviceName_;
				output.WriteString(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3572810", Offset = "0x3571210", VA = "0x183572810", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a0
			DeviceType deviceType = deviceType_;
			int num = 0;
			if (deviceType != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)deviceType);
			}
			string text = deviceID_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = deviceModel_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			string text3 = deviceName_;
			if (text3.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text3);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3572E00", Offset = "0x3571800", VA = "0x183572E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DeviceInfo other)
		{
			//Discarded unreachable code: IL_007e
			if (other != null)
			{
				DeviceType deviceType = other.deviceType_;
				if (deviceType != 0)
				{
					deviceType_ = deviceType;
				}
				string text = other.deviceID_;
				if (text.m_stringLength != 0)
				{
					DeviceID = text;
				}
				string text2 = other.deviceModel_;
				if (text2.m_stringLength != 0)
				{
					DeviceModel = text2;
				}
				string text3 = other.deviceName_;
				if (text3.m_stringLength != 0)
				{
					DeviceName = text3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3572D10", Offset = "0x3571710", VA = "0x183572D10", Slot = "5")]
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
					string text2 = (DeviceModel = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_0062;
				}
				string text4 = (DeviceName = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(deviceType_ = (DeviceType)input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text6 = (DeviceID = input.ReadString());
			}
			goto IL_0062;
			IL_0062:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3572C20", Offset = "0x3571620", VA = "0x183572C20", Slot = "11")]
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
						string text = deviceName_;
					}
					string text2 = deviceModel_;
				}
				string text3 = deviceID_;
			}
			DeviceType deviceType = deviceType_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3572EA0", Offset = "0x35718A0", VA = "0x183572EA0", Slot = "12")]
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
							DeviceName = (string)num2;
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
				deviceType_ = (DeviceType)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3572960", Offset = "0x3571360", VA = "0x183572960", Slot = "13")]
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
						DeviceName = "";
						break;
					case 0:
						DeviceModel = "";
						break;
					}
				}
				else
				{
					DeviceID = "";
				}
			}
			else
			{
				deviceType_ = DeviceType.Unknown;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3573070", Offset = "0x3571A70", VA = "0x183573070")]
		static DeviceInfo()
		{
			Func<DeviceInfo> func = default(Func<DeviceInfo>);
			_parser = (MessageParser<DeviceInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
