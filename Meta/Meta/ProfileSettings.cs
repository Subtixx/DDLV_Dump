using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000929")]
	public sealed class ProfileSettings : IMessage<ProfileSettings>, IMessage, IEquatable<ProfileSettings>, IDeepCloneable<ProfileSettings>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002543")]
		private static readonly MessageParser<ProfileSettings> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002544")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002545")]
		public const int FriendCodeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002546")]
		private string friendCode_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002547")]
		public const int LanguageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002548")]
		private string language_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002549")]
		public const int CountryFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400254A")]
		private string country_ = "";

		[Cpp2IlInjected.Token(Token = "0x400254B")]
		public const int AvatarUrlFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400254C")]
		private string avatarUrl_ = "";

		[Cpp2IlInjected.Token(Token = "0x400254D")]
		public const int BirthDateFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400254E")]
		private Timestamp birthDate_;

		[Cpp2IlInjected.Token(Token = "0x400254F")]
		public const int IsDevFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002550")]
		private bool isDev_;

		[Cpp2IlInjected.Token(Token = "0x17000DAC")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfileSettings> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004FDC")]
			[Cpp2IlInjected.Address(RVA = "0x1473600", Offset = "0x1472000", VA = "0x181473600")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DAD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FDD")]
			[Cpp2IlInjected.Address(RVA = "0x1473530", Offset = "0x1471F30", VA = "0x181473530")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DAE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FDE")]
			[Cpp2IlInjected.Address(RVA = "0x1473660", Offset = "0x1472060", VA = "0x181473660", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DAF")]
		[DebuggerNonUserCode]
		public string FriendCode
		{
			[Cpp2IlInjected.Token(Token = "0x6004FE2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return friendCode_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FE3")]
			[Cpp2IlInjected.Address(RVA = "0x1473850", Offset = "0x1472250", VA = "0x181473850")]
			set
			{
				string text = (friendCode_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB0")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x6004FE4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FE5")]
			[Cpp2IlInjected.Address(RVA = "0x14738C0", Offset = "0x14722C0", VA = "0x1814738C0")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB1")]
		[DebuggerNonUserCode]
		public string Country
		{
			[Cpp2IlInjected.Token(Token = "0x6004FE6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return country_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FE7")]
			[Cpp2IlInjected.Address(RVA = "0x14737E0", Offset = "0x14721E0", VA = "0x1814737E0")]
			set
			{
				string text = (country_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB2")]
		[DebuggerNonUserCode]
		public string AvatarUrl
		{
			[Cpp2IlInjected.Token(Token = "0x6004FE8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return avatarUrl_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FE9")]
			[Cpp2IlInjected.Address(RVA = "0x1473770", Offset = "0x1472170", VA = "0x181473770")]
			set
			{
				string text = (avatarUrl_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB3")]
		[DebuggerNonUserCode]
		public Timestamp BirthDate
		{
			[Cpp2IlInjected.Token(Token = "0x6004FEA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return birthDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FEB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				birthDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB4")]
		[DebuggerNonUserCode]
		public bool IsDev
		{
			[Cpp2IlInjected.Token(Token = "0x6004FEC")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return isDev_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FED")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				isDev_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FDF")]
		[Cpp2IlInjected.Address(RVA = "0x14734B0", Offset = "0x1471EB0", VA = "0x1814734B0")]
		[DebuggerNonUserCode]
		public ProfileSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE0")]
		[Cpp2IlInjected.Address(RVA = "0x1473360", Offset = "0x1471D60", VA = "0x181473360")]
		[DebuggerNonUserCode]
		public ProfileSettings(ProfileSettings other)
		{
			//IL_008b: Expected O, but got I4
			string text = (friendCode_ = other.friendCode_);
			string text2 = (language_ = other.language_);
			string text3 = (country_ = other.country_);
			string text4 = (avatarUrl_ = other.avatarUrl_);
			Timestamp timestamp = other.birthDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			birthDate_ = (Timestamp)num;
			bool flag = (isDev_ = other.isDev_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE1")]
		[Cpp2IlInjected.Address(RVA = "0x14725F0", Offset = "0x1470FF0", VA = "0x1814725F0", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfileSettings Clone()
		{
			//Discarded unreachable code: IL_00b4
			//IL_008d: Expected O, but got I4
			ProfileSettings profileSettings = new ProfileSettings();
			profileSettings.friendCode_ = "";
			profileSettings.language_ = "";
			profileSettings.country_ = "";
			profileSettings.avatarUrl_ = "";
			string text = (profileSettings.friendCode_ = friendCode_);
			string text2 = (profileSettings.language_ = language_);
			string text3 = (profileSettings.country_ = country_);
			string text4 = (profileSettings.avatarUrl_ = avatarUrl_);
			Timestamp timestamp = birthDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num = 0;
			profileSettings.birthDate_ = (Timestamp)num;
			bool flag = (profileSettings.isDev_ = isDev_);
			UnknownFieldSet unknownFieldSet = (profileSettings._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return profileSettings;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FEE")]
		[Cpp2IlInjected.Address(RVA = "0x1472760", Offset = "0x1471160", VA = "0x181472760", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = friendCode_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = language_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = country_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							string text4 = avatarUrl_;
							bool flag4 = default(bool);
							if (!flag4)
							{
								bool flag5 = object.Equals(birthDate_, other);
								if (flag5 && isDev_ == flag5)
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

		[Cpp2IlInjected.Token(Token = "0x6004FEF")]
		[Cpp2IlInjected.Address(RVA = "0x1472870", Offset = "0x1471270", VA = "0x181472870", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfileSettings other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.friendCode_;
				if (!(friendCode_ != text))
				{
					string text2 = other.language_;
					if (!(language_ != text2))
					{
						string text3 = other.country_;
						if (!(country_ != text3))
						{
							string text4 = other.avatarUrl_;
							if (!(avatarUrl_ != text4))
							{
								Timestamp objB = other.birthDate_;
								if (object.Equals(birthDate_, objB))
								{
									bool flag = other.isDev_;
									if (isDev_ == flag)
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										return object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF0")]
		[Cpp2IlInjected.Address(RVA = "0x1472A80", Offset = "0x1471480", VA = "0x181472A80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_009c
			string text = friendCode_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = language_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = country_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = avatarUrl_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			Timestamp timestamp = birthDate_;
			if (timestamp != null)
			{
				int hashCode5 = timestamp.GetHashCode();
			}
			if (isDev_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF1")]
		[Cpp2IlInjected.Address(RVA = "0x1473080", Offset = "0x1471A80", VA = "0x181473080", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF2")]
		[Cpp2IlInjected.Address(RVA = "0x14730E0", Offset = "0x1471AE0", VA = "0x1814730E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ba
			if (friendCode_.m_stringLength != 0)
			{
				string value = friendCode_;
				output.WriteString(value);
			}
			if (language_.m_stringLength != 0)
			{
				string value2 = language_;
				output.WriteString(value2);
			}
			if (country_.m_stringLength != 0)
			{
				string value3 = country_;
				output.WriteString(value3);
			}
			if (avatarUrl_.m_stringLength != 0)
			{
				string value4 = avatarUrl_;
				output.WriteString(value4);
			}
			if ((long)birthDate_ != 0)
			{
				Timestamp value5 = birthDate_;
				output.WriteMessage(value5);
			}
			if (isDev_)
			{
				bool value6 = isDev_;
				output.WriteBool(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF3")]
		[Cpp2IlInjected.Address(RVA = "0x1472340", Offset = "0x1470D40", VA = "0x181472340", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00c6
			string text = friendCode_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = language_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = country_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			string text4 = avatarUrl_;
			if (text4.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text4);
				num5++;
				num += num5;
			}
			Timestamp timestamp = birthDate_;
			if (timestamp != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(timestamp);
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

		[Cpp2IlInjected.Token(Token = "0x6004FF4")]
		[Cpp2IlInjected.Address(RVA = "0x1472B90", Offset = "0x1471590", VA = "0x181472B90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfileSettings other)
		{
			//Discarded unreachable code: IL_00d4
			if (other == null)
			{
				return;
			}
			string text = other.friendCode_;
			if (text.m_stringLength != 0)
			{
				FriendCode = text;
			}
			string text2 = other.language_;
			if (text2.m_stringLength != 0)
			{
				Language = text2;
			}
			string text3 = other.country_;
			if (text3.m_stringLength != 0)
			{
				Country = text3;
			}
			string text4 = other.avatarUrl_;
			if (text4.m_stringLength != 0)
			{
				AvatarUrl = text4;
			}
			if ((long)other.birthDate_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (birthDate_ == null)
				{
					Timestamp timestamp = (birthDate_ = new Timestamp());
					timestamp2 = birthDate_;
				}
				Timestamp other2 = other.birthDate_;
				timestamp2.MergeFrom(other2);
			}
			bool flag = other.isDev_;
			if (flag)
			{
				isDev_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF5")]
		[Cpp2IlInjected.Address(RVA = "0x1472CE0", Offset = "0x14716E0", VA = "0x181472CE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (AvatarUrl = input.ReadString());
				}
				Timestamp timestamp = default(Timestamp);
				if (num == 50)
				{
					Timestamp builder = default(Timestamp);
					if (birthDate_ == null)
					{
						timestamp = (birthDate_ = new Timestamp());
						builder = birthDate_;
					}
					input.ReadMessage(builder);
				}
				if ((long)timestamp != 56)
				{
					goto IL_00b0;
				}
				bool flag = (isDev_ = input.ReadBool());
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (FriendCode = input.ReadString());
			}
			string text6 = default(string);
			if ((long)text4 == 18)
			{
				text6 = (Language = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (Country = input.ReadString());
			}
			goto IL_00b0;
			IL_00b0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF6")]
		[Cpp2IlInjected.Address(RVA = "0x1472940", Offset = "0x1471340", VA = "0x181472940", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				string text = friendCode_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF7")]
		[Cpp2IlInjected.Address(RVA = "0x1472E60", Offset = "0x1471860", VA = "0x181472E60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_001b, IL_002a, IL_0036, IL_003c, IL_0042, IL_0048
			//IL_0017: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				FriendCode = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF8")]
		[Cpp2IlInjected.Address(RVA = "0x14724E0", Offset = "0x1470EE0", VA = "0x1814724E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0014
			if (fieldNumber - 1 <= 6)
			{
				FriendCode = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF9")]
		[Cpp2IlInjected.Address(RVA = "0x1473250", Offset = "0x1471C50", VA = "0x181473250")]
		static ProfileSettings()
		{
			Func<ProfileSettings> func = default(Func<ProfileSettings>);
			_parser = (MessageParser<ProfileSettings>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
