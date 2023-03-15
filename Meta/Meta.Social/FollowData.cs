using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BB6")]
	public sealed class FollowData : IMessage<FollowData>, IMessage, IEquatable<FollowData>, IDeepCloneable<FollowData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002D3E")]
		private static readonly MessageParser<FollowData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002D3F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002D40")]
		public const int PlayfabIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D41")]
		private string playfabId_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002D42")]
		public const int TitleIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D43")]
		private string titleId_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002D44")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D45")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002D46")]
		public const int AvatarFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002D47")]
		private string avatar_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002D48")]
		public const int IsFollowingFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002D49")]
		private bool isFollowing_;

		[Cpp2IlInjected.Token(Token = "0x4002D4A")]
		public const int IsFollowerFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4002D4B")]
		private bool isFollower_;

		[Cpp2IlInjected.Token(Token = "0x4002D4C")]
		public const int UrlFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002D4D")]
		private string url_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002D4E")]
		public const int UrlPreviewFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002D4F")]
		private string urlPreview_ = "";

		[Cpp2IlInjected.Token(Token = "0x17001119")]
		[DebuggerNonUserCode]
		public static MessageParser<FollowData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006356")]
			[Cpp2IlInjected.Address(RVA = "0x1806E00", Offset = "0x1805800", VA = "0x181806E00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006357")]
			[Cpp2IlInjected.Address(RVA = "0x1806D30", Offset = "0x1805730", VA = "0x181806D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006358")]
			[Cpp2IlInjected.Address(RVA = "0x1806E60", Offset = "0x1805860", VA = "0x181806E60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111C")]
		[DebuggerNonUserCode]
		public string PlayfabId
		{
			[Cpp2IlInjected.Token(Token = "0x600635C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return playfabId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600635D")]
			[Cpp2IlInjected.Address(RVA = "0x1807050", Offset = "0x1805A50", VA = "0x181807050")]
			set
			{
				string text = (playfabId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111D")]
		[DebuggerNonUserCode]
		public string TitleId
		{
			[Cpp2IlInjected.Token(Token = "0x600635E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return titleId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600635F")]
			[Cpp2IlInjected.Address(RVA = "0x18070C0", Offset = "0x1805AC0", VA = "0x1818070C0")]
			set
			{
				string text = (titleId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111E")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6006360")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006361")]
			[Cpp2IlInjected.Address(RVA = "0x1806FE0", Offset = "0x18059E0", VA = "0x181806FE0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111F")]
		[DebuggerNonUserCode]
		public string Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6006362")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return avatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006363")]
			[Cpp2IlInjected.Address(RVA = "0x1806F70", Offset = "0x1805970", VA = "0x181806F70")]
			set
			{
				string text = (avatar_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001120")]
		[DebuggerNonUserCode]
		public bool IsFollowing
		{
			[Cpp2IlInjected.Token(Token = "0x6006364")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return isFollowing_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006365")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set
			{
				isFollowing_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001121")]
		[DebuggerNonUserCode]
		public bool IsFollower
		{
			[Cpp2IlInjected.Token(Token = "0x6006366")]
			[Cpp2IlInjected.Address(RVA = "0xBA18B0", Offset = "0xBA02B0", VA = "0x180BA18B0")]
			get
			{
				return isFollower_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006367")]
			[Cpp2IlInjected.Address(RVA = "0xBA18E0", Offset = "0xBA02E0", VA = "0x180BA18E0")]
			set
			{
				isFollower_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001122")]
		[DebuggerNonUserCode]
		public string Url
		{
			[Cpp2IlInjected.Token(Token = "0x6006368")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return url_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006369")]
			[Cpp2IlInjected.Address(RVA = "0x18071A0", Offset = "0x1805BA0", VA = "0x1818071A0")]
			set
			{
				string text = (url_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001123")]
		[DebuggerNonUserCode]
		public string UrlPreview
		{
			[Cpp2IlInjected.Token(Token = "0x600636A")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return urlPreview_;
			}
			[Cpp2IlInjected.Token(Token = "0x600636B")]
			[Cpp2IlInjected.Address(RVA = "0x1807130", Offset = "0x1805B30", VA = "0x181807130")]
			set
			{
				string text = (urlPreview_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006359")]
		[Cpp2IlInjected.Address(RVA = "0x1806C80", Offset = "0x1805680", VA = "0x181806C80")]
		[DebuggerNonUserCode]
		public FollowData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600635A")]
		[Cpp2IlInjected.Address(RVA = "0x1806B00", Offset = "0x1805500", VA = "0x181806B00")]
		[DebuggerNonUserCode]
		public FollowData(FollowData other)
		{
			string text = (playfabId_ = other.playfabId_);
			string text2 = (titleId_ = other.titleId_);
			string text3 = (displayName_ = other.displayName_);
			string text4 = (avatar_ = other.avatar_);
			bool flag = (isFollowing_ = other.isFollowing_);
			bool flag2 = (isFollower_ = other.isFollower_);
			string text5 = (url_ = other.url_);
			string text6 = (urlPreview_ = other.urlPreview_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600635B")]
		[Cpp2IlInjected.Address(RVA = "0x1805BE0", Offset = "0x18045E0", VA = "0x181805BE0", Slot = "10")]
		[DebuggerNonUserCode]
		public FollowData Clone()
		{
			//Discarded unreachable code: IL_00d9
			FollowData followData = new FollowData();
			followData.playfabId_ = "";
			followData.titleId_ = "";
			followData.displayName_ = "";
			followData.avatar_ = "";
			followData.url_ = "";
			followData.urlPreview_ = "";
			string text = (followData.playfabId_ = playfabId_);
			string text2 = (followData.titleId_ = titleId_);
			string text3 = (followData.displayName_ = displayName_);
			string text4 = (followData.avatar_ = avatar_);
			bool flag = (followData.isFollowing_ = isFollowing_);
			bool flag2 = (followData.isFollower_ = isFollower_);
			string text5 = (followData.url_ = url_);
			string text6 = (followData.urlPreview_ = urlPreview_);
			UnknownFieldSet unknownFieldSet = (followData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return followData;
		}

		[Cpp2IlInjected.Token(Token = "0x600636C")]
		[Cpp2IlInjected.Address(RVA = "0x1805D90", Offset = "0x1804790", VA = "0x181805D90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = playfabId_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = titleId_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = displayName_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							string text4 = avatar_;
							bool flag4 = default(bool);
							if (!flag4 && isFollowing_ == flag4 && isFollower_ == flag4)
							{
								string text5 = url_;
								bool flag5 = default(bool);
								if (!flag5)
								{
									string text6 = urlPreview_;
									bool flag6 = default(bool);
									if (!flag6)
									{
										return object.Equals(_unknownFields, other);
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

		[Cpp2IlInjected.Token(Token = "0x600636D")]
		[Cpp2IlInjected.Address(RVA = "0x1805ED0", Offset = "0x18048D0", VA = "0x181805ED0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FollowData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.playfabId_;
				if (!(playfabId_ != text))
				{
					string text2 = other.titleId_;
					if (!(titleId_ != text2))
					{
						string text3 = other.displayName_;
						if (!(displayName_ != text3))
						{
							string text4 = other.avatar_;
							if (!(avatar_ != text4))
							{
								bool flag = other.isFollowing_;
								if (isFollowing_ == flag)
								{
									bool flag2 = other.isFollower_;
									if (isFollower_ == flag2)
									{
										string text5 = other.url_;
										if (!(url_ != text5))
										{
											string text6 = other.urlPreview_;
											if (!(urlPreview_ != text6))
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
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600636E")]
		[Cpp2IlInjected.Address(RVA = "0x1806120", Offset = "0x1804B20", VA = "0x181806120", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c5
			string text = playfabId_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = titleId_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = displayName_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = avatar_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (isFollowing_)
			{
			}
			if (isFollower_)
			{
			}
			string text5 = url_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			string text6 = urlPreview_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600636F")]
		[Cpp2IlInjected.Address(RVA = "0x18067C0", Offset = "0x18051C0", VA = "0x1818067C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006370")]
		[Cpp2IlInjected.Address(RVA = "0x1806820", Offset = "0x1805220", VA = "0x181806820", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f4
			if (playfabId_.m_stringLength != 0)
			{
				string value = playfabId_;
				output.WriteString(value);
			}
			if (titleId_.m_stringLength != 0)
			{
				string value2 = titleId_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (avatar_.m_stringLength != 0)
			{
				string value4 = avatar_;
				output.WriteString(value4);
			}
			if (isFollowing_)
			{
				bool value5 = isFollowing_;
				output.WriteBool(value5);
			}
			if (isFollower_)
			{
				bool value6 = isFollower_;
				output.WriteBool(value6);
			}
			if (url_.m_stringLength != 0)
			{
				string value7 = url_;
				output.WriteString(value7);
			}
			if (urlPreview_.m_stringLength != 0)
			{
				string value8 = urlPreview_;
				output.WriteString(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006371")]
		[Cpp2IlInjected.Address(RVA = "0x18058B0", Offset = "0x18042B0", VA = "0x1818058B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00f1
			string text = playfabId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = titleId_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = displayName_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			string text4 = avatar_;
			if (text4.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text4);
				num5++;
				num += num5;
			}
			string text5 = url_;
			if (text5.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text5);
				num6++;
				num += num6;
			}
			string text6 = urlPreview_;
			if (text6.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text6);
				num7++;
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006372")]
		[Cpp2IlInjected.Address(RVA = "0x1806400", Offset = "0x1804E00", VA = "0x181806400", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FollowData other)
		{
			//Discarded unreachable code: IL_00e1
			if (other != null)
			{
				string text = other.playfabId_;
				if (text.m_stringLength != 0)
				{
					PlayfabId = text;
				}
				string text2 = other.titleId_;
				if (text2.m_stringLength != 0)
				{
					TitleId = text2;
				}
				string text3 = other.displayName_;
				if (text3.m_stringLength != 0)
				{
					DisplayName = text3;
				}
				string text4 = other.avatar_;
				if (text4.m_stringLength != 0)
				{
					Avatar = text4;
				}
				bool flag = other.isFollowing_;
				if (flag)
				{
					isFollowing_ = flag;
				}
				bool flag2 = other.isFollower_;
				if (flag2)
				{
					isFollower_ = flag2;
				}
				string text5 = other.url_;
				if (text5.m_stringLength != 0)
				{
					Url = text5;
				}
				string text6 = other.urlPreview_;
				if (text6.m_stringLength != 0)
				{
					UrlPreview = text6;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006373")]
		[Cpp2IlInjected.Address(RVA = "0x1806280", Offset = "0x1804C80", VA = "0x181806280", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ec
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 48)
				{
					if (num == 82)
					{
						string text2 = (Url = input.ReadString());
					}
					if (num != 90)
					{
						goto IL_00d5;
					}
					string text4 = (UrlPreview = input.ReadString());
				}
				bool flag = default(bool);
				if (num == 40)
				{
					flag = (isFollowing_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_00d5;
				}
				bool flag2 = (isFollower_ = input.ReadBool());
			}
			string text8 = default(string);
			if ((int)num > 18)
			{
				string text6 = default(string);
				if (num == 26)
				{
					text6 = (DisplayName = input.ReadString());
				}
				if ((long)text6 != 34)
				{
					goto IL_00d5;
				}
				text8 = (Avatar = input.ReadString());
			}
			string text10 = default(string);
			if ((long)text8 == 10)
			{
				text10 = (PlayfabId = input.ReadString());
			}
			if ((long)text10 == 18)
			{
				string text12 = (TitleId = input.ReadString());
			}
			goto IL_00d5;
			IL_00d5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006374")]
		[Cpp2IlInjected.Address(RVA = "0x1805FC0", Offset = "0x18049C0", VA = "0x181805FC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				string text = playfabId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006375")]
		[Cpp2IlInjected.Address(RVA = "0x1806510", Offset = "0x1804F10", VA = "0x181806510", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0039, IL_003a, IL_003b, IL_0047, IL_004d, IL_0053, IL_0059, IL_005f
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				PlayfabId = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006376")]
		[Cpp2IlInjected.Address(RVA = "0x1805AA0", Offset = "0x18044A0", VA = "0x181805AA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018
			if (fieldNumber - 1 <= 10)
			{
				PlayfabId = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006377")]
		[Cpp2IlInjected.Address(RVA = "0x18069F0", Offset = "0x18053F0", VA = "0x1818069F0")]
		static FollowData()
		{
			Func<FollowData> func = default(Func<FollowData>);
			_parser = (MessageParser<FollowData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
