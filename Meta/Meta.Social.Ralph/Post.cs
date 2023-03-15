using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DD8")]
	public sealed class Post : IMessage<Post>, IMessage, IEquatable<Post>, IDeepCloneable<Post>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40037ED")]
		private static readonly MessageParser<Post> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40037EE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40037EF")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037F0")]
		private string iD_ = "";

		[Cpp2IlInjected.Token(Token = "0x40037F1")]
		public const int PlayerIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037F2")]
		private string playerID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40037F3")]
		public const int PictureFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037F4")]
		private Picture picture_;

		[Cpp2IlInjected.Token(Token = "0x40037F5")]
		public const int PostDateFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037F6")]
		private Timestamp postDate_;

		[Cpp2IlInjected.Token(Token = "0x170013DF")]
		[DebuggerNonUserCode]
		public static MessageParser<Post> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600733B")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A50", Offset = "0x7C0450", VA = "0x1807C1A50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600733C")]
			[Cpp2IlInjected.Address(RVA = "0x7C1980", Offset = "0x7C0380", VA = "0x1807C1980")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600733D")]
			[Cpp2IlInjected.Address(RVA = "0x7C1AB0", Offset = "0x7C04B0", VA = "0x1807C1AB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E2")]
		[DebuggerNonUserCode]
		public string ID
		{
			[Cpp2IlInjected.Token(Token = "0x6007341")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007342")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BC0", Offset = "0x7C05C0", VA = "0x1807C1BC0")]
			set
			{
				string text = (iD_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E3")]
		[DebuggerNonUserCode]
		public string PlayerID
		{
			[Cpp2IlInjected.Token(Token = "0x6007343")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return playerID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007344")]
			[Cpp2IlInjected.Address(RVA = "0x7C1C30", Offset = "0x7C0630", VA = "0x1807C1C30")]
			set
			{
				string text = (playerID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E4")]
		[DebuggerNonUserCode]
		public Picture Picture
		{
			[Cpp2IlInjected.Token(Token = "0x6007345")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return picture_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007346")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				picture_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E5")]
		[DebuggerNonUserCode]
		public Timestamp PostDate
		{
			[Cpp2IlInjected.Token(Token = "0x6007347")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return postDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007348")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				postDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600733E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1920", Offset = "0x7C0320", VA = "0x1807C1920")]
		[DebuggerNonUserCode]
		public Post()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600733F")]
		[Cpp2IlInjected.Address(RVA = "0x7C17D0", Offset = "0x7C01D0", VA = "0x1807C17D0")]
		[DebuggerNonUserCode]
		public Post(Post other)
		{
			//IL_0054: Expected O, but got I4
			string text = (iD_ = other.iD_);
			string text2 = (playerID_ = other.playerID_);
			Picture picture = other.picture_;
			int num = 0;
			if (picture != null)
			{
				Picture picture2 = new Picture(picture);
			}
			picture_ = (Picture)num;
			Timestamp timestamp = other.postDate_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			postDate_ = timestamp2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007340")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C80", Offset = "0x7BF680", VA = "0x1807C0C80", Slot = "10")]
		[DebuggerNonUserCode]
		public Post Clone()
		{
			//Discarded unreachable code: IL_008b
			//IL_0056: Expected O, but got I4
			Post post = new Post();
			post.iD_ = "";
			post.playerID_ = "";
			string text = (post.iD_ = iD_);
			string text2 = (post.playerID_ = playerID_);
			Picture picture = picture_;
			int num = 0;
			if (picture != null)
			{
				Picture picture2 = new Picture(picture);
			}
			post.picture_ = (Picture)num;
			Timestamp timestamp = postDate_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			post.postDate_ = timestamp2;
			UnknownFieldSet unknownFieldSet = (post._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return post;
		}

		[Cpp2IlInjected.Token(Token = "0x6007349")]
		[Cpp2IlInjected.Address(RVA = "0x7C0EA0", Offset = "0x7BF8A0", VA = "0x1807C0EA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = iD_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = playerID_;
					bool flag2 = default(bool);
					if (!flag2 && object.Equals(picture_, other) && object.Equals(postDate_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600734A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E00", Offset = "0x7BF800", VA = "0x1807C0E00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Post other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.iD_;
				if (!(iD_ != text))
				{
					string text2 = other.playerID_;
					if (!(playerID_ != text2))
					{
						Picture objB = other.picture_;
						if (object.Equals(picture_, objB))
						{
							Timestamp objB2 = other.postDate_;
							if (object.Equals(postDate_, objB2))
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

		[Cpp2IlInjected.Token(Token = "0x600734B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7BFA40", VA = "0x1807C1040", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0072
			string text = iD_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = playerID_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			Picture picture = picture_;
			if (picture != null)
			{
				int hashCode3 = picture.GetHashCode();
			}
			Timestamp timestamp = postDate_;
			if (timestamp != null)
			{
				int hashCode4 = timestamp.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600734C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1560", Offset = "0x7BFF60", VA = "0x1807C1560", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600734D")]
		[Cpp2IlInjected.Address(RVA = "0x7C15C0", Offset = "0x7BFFC0", VA = "0x1807C15C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0080
			if (iD_.m_stringLength != 0)
			{
				string value = iD_;
				output.WriteString(value);
			}
			if (playerID_.m_stringLength != 0)
			{
				string value2 = playerID_;
				output.WriteString(value2);
			}
			if ((long)picture_ != 0)
			{
				Picture value3 = picture_;
				output.WriteMessage(value3);
			}
			if ((long)postDate_ != 0)
			{
				Timestamp value4 = postDate_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600734E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BF480", VA = "0x1807C0A80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009b
			string text = iD_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = playerID_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			Picture picture = picture_;
			if (picture != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(picture);
				num4++;
				num += num4;
			}
			Timestamp timestamp = postDate_;
			if (timestamp != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(timestamp);
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

		[Cpp2IlInjected.Token(Token = "0x600734F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1100", Offset = "0x7BFB00", VA = "0x1807C1100", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Post other)
		{
			//Discarded unreachable code: IL_00c9
			if (other == null)
			{
				return;
			}
			string text = other.iD_;
			if (text.m_stringLength != 0)
			{
				ID = text;
			}
			string text2 = other.playerID_;
			if (text2.m_stringLength != 0)
			{
				PlayerID = text2;
			}
			if ((long)other.picture_ != 0)
			{
				Picture picture2 = default(Picture);
				if (picture_ == null)
				{
					Picture picture = (picture_ = new Picture());
					picture2 = picture_;
				}
				Picture other2 = other.picture_;
				picture2.MergeFrom(other2);
			}
			if ((long)other.postDate_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (postDate_ == null)
				{
					Timestamp timestamp = (postDate_ = new Timestamp());
					timestamp2 = postDate_;
				}
				Timestamp other3 = other.postDate_;
				timestamp2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6007350")]
		[Cpp2IlInjected.Address(RVA = "0x7C1270", Offset = "0x7BFC70", VA = "0x1807C1270", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ab
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					Picture picture = picture_;
					if (picture == null)
					{
						Picture picture2 = (picture_ = new Picture());
					}
					input.ReadMessage(picture);
				}
				if (num != 34)
				{
					goto IL_0094;
				}
				Timestamp builder = default(Timestamp);
				if (postDate_ == null)
				{
					Timestamp timestamp = (postDate_ = new Timestamp());
					builder = postDate_;
				}
				input.ReadMessage(builder);
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (ID = input.ReadString());
			}
			if ((long)text2 == 18)
			{
				string text4 = (PlayerID = input.ReadString());
			}
			goto IL_0094;
			IL_0094:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6007351")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F90", Offset = "0x7BF990", VA = "0x1807C0F90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = postDate_;
				Picture picture = picture_;
				string text = playerID_;
				string text2 = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007352")]
		[Cpp2IlInjected.Address(RVA = "0x7C1400", Offset = "0x7BFE00", VA = "0x1807C1400", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
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
							postDate_ = (Timestamp)num2;
							return;
						}
						throw new InvalidCastException();
					}
					default:
						return;
					case 0:
						break;
					}
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007353")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BC0", Offset = "0x7BF5C0", VA = "0x1807C0BC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num == 0 || num == 1)
				{
					PlayerID = "";
				}
			}
			else
			{
				ID = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007354")]
		[Cpp2IlInjected.Address(RVA = "0x7C16C0", Offset = "0x7C00C0", VA = "0x1807C16C0")]
		static Post()
		{
			Func<Post> func = default(Func<Post>);
			_parser = (MessageParser<Post>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
