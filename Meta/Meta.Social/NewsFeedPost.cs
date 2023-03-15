using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using PlayFab.EconomyModels;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BE5")]
	public sealed class NewsFeedPost : IMessage<NewsFeedPost>, IMessage, IEquatable<NewsFeedPost>, IDeepCloneable<NewsFeedPost>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BE6")]
		public enum TypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4002E27")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4002E28")]
			UserPost = 6,
			[Cpp2IlInjected.Token(Token = "0x4002E29")]
			EventPost = 7
		}

		[Cpp2IlInjected.Token(Token = "0x4002E16")]
		private static readonly MessageParser<NewsFeedPost> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002E17")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002E18")]
		public const int ItemIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E19")]
		private string itemId_;

		[Cpp2IlInjected.Token(Token = "0x4002E1A")]
		public const int DisplayNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E1B")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x4002E1C")]
		public const int UrlFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E1D")]
		private string url_;

		[Cpp2IlInjected.Token(Token = "0x4002E1E")]
		public const int UrlPreviewFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E1F")]
		private string urlPreview_;

		[Cpp2IlInjected.Token(Token = "0x4002E20")]
		public const int DateFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002E21")]
		private Timestamp date_;

		[Cpp2IlInjected.Token(Token = "0x4002E22")]
		public const int UserPostFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4002E23")]
		public const int EventPostFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002E24")]
		private object type_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002E25")]
		private TypeOneofCase typeCase_;

		[Cpp2IlInjected.Token(Token = "0x1700117A")]
		[DebuggerNonUserCode]
		public static MessageParser<NewsFeedPost> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006517")]
			[Cpp2IlInjected.Address(RVA = "0x1398770", Offset = "0x1397170", VA = "0x181398770")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700117B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006518")]
			[Cpp2IlInjected.Address(RVA = "0x1398640", Offset = "0x1397040", VA = "0x181398640")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700117C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006519")]
			[Cpp2IlInjected.Address(RVA = "0x1398830", Offset = "0x1397230", VA = "0x181398830", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700117D")]
		[DebuggerNonUserCode]
		public string ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600651D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemId_;
			}
			[Cpp2IlInjected.Token(Token = "0x600651E")]
			[Cpp2IlInjected.Address(RVA = "0x13989F0", Offset = "0x13973F0", VA = "0x1813989F0")]
			set
			{
				string text = (itemId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700117E")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600651F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006520")]
			[Cpp2IlInjected.Address(RVA = "0x1398940", Offset = "0x1397340", VA = "0x181398940")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700117F")]
		[DebuggerNonUserCode]
		public string Url
		{
			[Cpp2IlInjected.Token(Token = "0x6006521")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return url_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006522")]
			[Cpp2IlInjected.Address(RVA = "0x1398AD0", Offset = "0x13974D0", VA = "0x181398AD0")]
			set
			{
				string text = (url_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001180")]
		[DebuggerNonUserCode]
		public string UrlPreview
		{
			[Cpp2IlInjected.Token(Token = "0x6006523")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return urlPreview_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006524")]
			[Cpp2IlInjected.Address(RVA = "0x1398A60", Offset = "0x1397460", VA = "0x181398A60")]
			set
			{
				string text = (urlPreview_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001181")]
		[DebuggerNonUserCode]
		public Timestamp Date
		{
			[Cpp2IlInjected.Token(Token = "0x6006525")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return date_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006526")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				date_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001182")]
		[DebuggerNonUserCode]
		public NewsFeedUserPost UserPost
		{
			[Cpp2IlInjected.Token(Token = "0x6006527")]
			[Cpp2IlInjected.Address(RVA = "0x13987D0", Offset = "0x13971D0", VA = "0x1813987D0")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.UserPost)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6006528")]
			[Cpp2IlInjected.Address(RVA = "0x1398B40", Offset = "0x1397540", VA = "0x181398B40")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001183")]
		[DebuggerNonUserCode]
		public NewsFeedEventPost EventPost
		{
			[Cpp2IlInjected.Token(Token = "0x6006529")]
			[Cpp2IlInjected.Address(RVA = "0x1398710", Offset = "0x1397110", VA = "0x181398710")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.EventPost)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600652A")]
			[Cpp2IlInjected.Address(RVA = "0x13989B0", Offset = "0x13973B0", VA = "0x1813989B0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001184")]
		[DebuggerNonUserCode]
		public TypeOneofCase TypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x600652B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return typeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600651A")]
		[Cpp2IlInjected.Address(RVA = "0x1398280", Offset = "0x1396C80", VA = "0x181398280")]
		[DebuggerNonUserCode]
		public NewsFeedPost()
		{
			itemId_ = "";
			displayName_ = "";
			url_ = "";
			urlPreview_ = "";
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600651B")]
		[Cpp2IlInjected.Address(RVA = "0x1398300", Offset = "0x1396D00", VA = "0x181398300")]
		[DebuggerNonUserCode]
		public NewsFeedPost(NewsFeedPost other)
		{
			//IL_0059: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00a4: Expected I4, but got O
			//IL_00b6: Expected I4, but got O
			//IL_00bf: Expected I4, but got O
			//IL_00c8: Expected I4, but got O
			//IL_0110: Expected O, but got I4
			//IL_011c: Expected I4, but got O
			string text = (itemId_ = other.itemId_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (url_ = other.url_);
			string text4 = (urlPreview_ = other.urlPreview_);
			Timestamp timestamp = other.date_;
			int num = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			date_ = (Timestamp)num;
			UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
			if (other.typeCase_ == TypeOneofCase.UserPost)
			{
				TypeOneofCase typeOneofCase = other.typeCase_;
				if (other.type_ == null)
				{
					throw new InvalidCastException();
				}
				NewsFeedUserPost newsFeedUserPost = new NewsFeedUserPost();
				int num2 = 0;
				newsFeedUserPost.entityId_ = (string)num2;
				newsFeedUserPost.playfabId_ = (string)num2;
				newsFeedUserPost.avatar_ = (string)num2;
				newsFeedUserPost.score_ = (int)newsFeedUserPost;
				RepeatedField<> repeatedField = default(RepeatedField<>);
				newsFeedUserPost.items_ = (RepeatedField<int>)(object)repeatedField;
				newsFeedUserPost.likes_ = (int)repeatedField;
				newsFeedUserPost.likedByMe_ = (byte)(int)repeatedField != 0;
				newsFeedUserPost.isMine_ = (byte)(int)repeatedField != 0;
				newsFeedUserPost._unknownFields = unknownFieldSet;
				type_ = newsFeedUserPost;
			}
			if ((long)unknownFieldSet == 7)
			{
				TypeOneofCase typeOneofCase2 = other.typeCase_;
				if (other.type_ == null)
				{
					throw new InvalidCastException();
				}
				NewsFeedEventPost newsFeedEventPost = new NewsFeedEventPost();
				newsFeedEventPost.name_ = "";
				int num3 = 0;
				newsFeedEventPost.name_ = (string)num3;
				newsFeedEventPost.type_ = (SocialEventType)"";
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				newsFeedEventPost._unknownFields = unknownFields;
				type_ = newsFeedEventPost;
			}
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600651C")]
		[Cpp2IlInjected.Address(RVA = "0x1396890", Offset = "0x1395290", VA = "0x181396890", Slot = "10")]
		[DebuggerNonUserCode]
		public NewsFeedPost Clone()
		{
			return new NewsFeedPost(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600652C")]
		[Cpp2IlInjected.Address(RVA = "0x1396870", Offset = "0x1395270", VA = "0x181396870")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
			//IL_0010: Expected O, but got I4
			type_ = (typeCase_ = TypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600652D")]
		[Cpp2IlInjected.Address(RVA = "0x13968F0", Offset = "0x13952F0", VA = "0x1813968F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = itemId_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = displayName_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = url_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							string text4 = urlPreview_;
							bool flag4 = default(bool);
							NewsFeedUserPost objB = default(NewsFeedUserPost);
							if (!flag4 && object.Equals(date_, other) && object.Equals(UserPost, objB))
							{
								NewsFeedEventPost objB2 = default(NewsFeedEventPost);
								bool flag5 = object.Equals(EventPost, objB2);
								if (flag5 && typeCase_ == (flag5 ? ((TypeOneofCase)1) : TypeOneofCase.None))
								{
									return object.Equals(_unknownFields, objB2);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600652E")]
		[Cpp2IlInjected.Address(RVA = "0x1396A70", Offset = "0x1395470", VA = "0x181396A70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NewsFeedPost other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.itemId_;
				if (!(itemId_ != text))
				{
					string text2 = other.displayName_;
					if (!(displayName_ != text2))
					{
						string text3 = other.url_;
						if (!(url_ != text3))
						{
							string text4 = other.urlPreview_;
							if (!(urlPreview_ != text4))
							{
								Timestamp objB = other.date_;
								if (object.Equals(date_, objB))
								{
									NewsFeedUserPost userPost = UserPost;
									NewsFeedUserPost userPost2 = other.UserPost;
									if (object.Equals(userPost, userPost2))
									{
										NewsFeedEventPost eventPost = EventPost;
										NewsFeedEventPost eventPost2 = other.EventPost;
										if (object.Equals(eventPost, eventPost2))
										{
											TypeOneofCase typeOneofCase = other.typeCase_;
											if (typeCase_ == typeOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x600652F")]
		[Cpp2IlInjected.Address(RVA = "0x1396CA0", Offset = "0x13956A0", VA = "0x181396CA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00da
			TypeOneofCase typeOneofCase;
			do
			{
				string text = itemId_;
				if (text.m_stringLength != 0)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = displayName_;
				if (text2.m_stringLength != 0)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = url_;
				if (text3.m_stringLength != 0)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = urlPreview_;
				if (text4.m_stringLength != 0)
				{
					int hashCode4 = text4.GetHashCode();
				}
				Timestamp timestamp = date_;
				if (timestamp != null)
				{
					int hashCode5 = timestamp.GetHashCode();
				}
				typeOneofCase = typeCase_;
				int num = 0;
			}
			while (typeOneofCase != TypeOneofCase.UserPost);
			object obj = type_;
			if (obj != null)
			{
				int hashCode6 = obj.GetHashCode();
				if (typeCase_ == TypeOneofCase.EventPost)
				{
					object obj2 = type_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode7 = obj2.GetHashCode();
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode8 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006530")]
		[Cpp2IlInjected.Address(RVA = "0x1397EE0", Offset = "0x13968E0", VA = "0x181397EE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006531")]
		[Cpp2IlInjected.Address(RVA = "0x1397F40", Offset = "0x1396940", VA = "0x181397F40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f3
			TypeOneofCase typeOneofCase;
			do
			{
				if (itemId_.m_stringLength != 0)
				{
					string value = itemId_;
					output.WriteString(value);
				}
				if (displayName_.m_stringLength != 0)
				{
					string value2 = displayName_;
					output.WriteString(value2);
				}
				if (url_.m_stringLength != 0)
				{
					string value3 = url_;
					output.WriteString(value3);
				}
				if (urlPreview_.m_stringLength != 0)
				{
					string value4 = urlPreview_;
					output.WriteString(value4);
				}
				if ((long)date_ != 0)
				{
					Timestamp value5 = date_;
					output.WriteMessage(value5);
				}
				typeOneofCase = typeCase_;
				int num = 0;
			}
			while (typeOneofCase != TypeOneofCase.UserPost);
			if (typeCase_ == TypeOneofCase.UserPost)
			{
				object obj = type_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (typeCase_ == TypeOneofCase.EventPost && typeCase_ == TypeOneofCase.EventPost)
			{
				object obj2 = type_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006532")]
		[Cpp2IlInjected.Address(RVA = "0x1396460", Offset = "0x1394E60", VA = "0x181396460", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0120
			string text = itemId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = url_;
			if (text3.m_stringLength != num)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			string text4 = urlPreview_;
			if (text4.m_stringLength != num)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text4);
				num5++;
				num += num5;
			}
			Timestamp timestamp = date_;
			if (timestamp != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(timestamp);
				num6++;
				num += num6;
			}
			if (typeCase_ == TypeOneofCase.UserPost)
			{
				if (typeCase_ != TypeOneofCase.UserPost)
				{
				}
				object obj = type_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (typeCase_ == TypeOneofCase.EventPost)
			{
				if (typeCase_ == TypeOneofCase.EventPost)
				{
					object obj2 = type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num += num9;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006533")]
		[Cpp2IlInjected.Address(RVA = "0x1397240", Offset = "0x1395C40", VA = "0x181397240", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NewsFeedPost other)
		{
			//Discarded unreachable code: IL_01e2
			//IL_0158: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			string text = other.itemId_;
			if (text.m_stringLength != 0)
			{
				ItemId = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.url_;
			if (text3.m_stringLength != 0)
			{
				Url = text3;
			}
			string text4 = other.urlPreview_;
			if (text4.m_stringLength != 0)
			{
				UrlPreview = text4;
			}
			if ((long)other.date_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (date_ == null)
				{
					Timestamp timestamp = (date_ = new Timestamp());
					timestamp2 = date_;
				}
				Timestamp other2 = other.date_;
				timestamp2.MergeFrom(other2);
			}
			if (other.typeCase_ == TypeOneofCase.UserPost)
			{
				TypeOneofCase typeOneofCase = typeCase_;
				object obj = default(object);
				if (typeOneofCase == TypeOneofCase.UserPost)
				{
					obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					NewsFeedUserPost newsFeedUserPost = (NewsFeedUserPost)(type_ = new NewsFeedUserPost());
					typeCase_ = typeOneofCase;
				}
				if (typeCase_ == TypeOneofCase.UserPost)
				{
					object obj2 = type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.typeCase_ == TypeOneofCase.UserPost)
				{
					object obj3 = other.type_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(NewsFeedUserPost).TypeHandle == 7)
			{
				if (EventPost == null)
				{
					typeCase_ = (TypeOneofCase)(type_ = new NewsFeedEventPost());
				}
				NewsFeedEventPost eventPost = EventPost;
				NewsFeedEventPost eventPost2 = other.EventPost;
				if (eventPost2 != null)
				{
					string name_ = eventPost2.name_;
					if (name_.m_stringLength != 0)
					{
						eventPost.Name = name_;
					}
					SocialEventType socialEventType = eventPost2.type_;
					if (socialEventType != 0)
					{
						eventPost.type_ = socialEventType;
					}
					UnknownFieldSet unknownFields = eventPost2._unknownFields;
					UnknownFieldSet unknownFieldSet = (eventPost._unknownFields = UnknownFieldSet.MergeFrom(eventPost._unknownFields, unknownFields));
				}
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6006534")]
		[Cpp2IlInjected.Address(RVA = "0x1396F30", Offset = "0x1395930", VA = "0x181396F30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0066: Expected I4, but got O
			//IL_00b5: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 50)
					{
						NewsFeedUserPost newsFeedUserPost = new NewsFeedUserPost();
						if (typeCase_ == TypeOneofCase.UserPost)
						{
							if (typeCase_ != TypeOneofCase.UserPost)
							{
							}
							object obj = type_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(newsFeedUserPost);
						type_ = newsFeedUserPost;
						typeCase_ = (TypeOneofCase)newsFeedUserPost;
					}
					if (num != 58)
					{
						goto IL_0141;
					}
					NewsFeedEventPost builder = new NewsFeedEventPost();
					if (typeCase_ == TypeOneofCase.EventPost)
					{
						if (typeCase_ != TypeOneofCase.EventPost)
						{
						}
						object obj2 = type_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					type_ = builder;
					typeCase_ = (TypeOneofCase)typeof(NewsFeedEventPost).TypeHandle;
				}
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (UrlPreview = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_0141;
				}
				Timestamp builder2 = default(Timestamp);
				if (date_ == null)
				{
					Timestamp timestamp = (date_ = new Timestamp());
					builder2 = date_;
				}
				input.ReadMessage(builder2);
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (ItemId = input.ReadString());
			}
			string text6 = default(string);
			if ((long)text4 == 18)
			{
				text6 = (DisplayName = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (Url = input.ReadString());
			}
			goto IL_0141;
			IL_0141:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006535")]
		[Cpp2IlInjected.Address(RVA = "0x1396BB0", Offset = "0x13955B0", VA = "0x181396BB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 6)
			{
				string text = itemId_;
				string text2 = displayName_;
				string text3 = url_;
				string text4 = urlPreview_;
				Timestamp timestamp = date_;
				NewsFeedUserPost userPost = UserPost;
				NewsFeedEventPost eventPost = EventPost;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			long num = num + num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006536")]
		[Cpp2IlInjected.Address(RVA = "0x1397C50", Offset = "0x1396650", VA = "0x181397C50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_001c, IL_0020, IL_0021, IL_0025, IL_0029, IL_002a, IL_002e, IL_0032, IL_0033, IL_0037, IL_003b, IL_003f, IL_0044, IL_0048, IL_004c, IL_004d, IL_0059, IL_005f, IL_0065, IL_006b, IL_0071
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				ItemId = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006537")]
		[Cpp2IlInjected.Address(RVA = "0x13966F0", Offset = "0x13950F0", VA = "0x1813966F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0014
			if (fieldNumber - 1 <= 6)
			{
				ItemId = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006538")]
		[Cpp2IlInjected.Address(RVA = "0x1396E80", Offset = "0x1395880", VA = "0x181396E80", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				TypeOneofCase typeOneofCase = typeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006539")]
		[Cpp2IlInjected.Address(RVA = "0x1396800", Offset = "0x1395200", VA = "0x181396800", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				type_ = (typeCase_ = TypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600653A")]
		[Cpp2IlInjected.Address(RVA = "0x13978D0", Offset = "0x13962D0", VA = "0x1813978D0")]
		public static NewsFeedPost NewUserPost(CatalogItem item, KnownProfiles knowProfiles, bool isMine = false)
		{
			if (knowProfiles != null)
			{
				KnownProfileInfo creatorInfo = knowProfiles.GetCreatorInfo(item);
			}
			NewsFeedPost result = default(NewsFeedPost);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600653B")]
		[Cpp2IlInjected.Address(RVA = "0x1397960", Offset = "0x1396360", VA = "0x181397960")]
		public static NewsFeedPost NewUserPost(CatalogItem item, KnownProfileInfo info, bool isMine = false)
		{
			//IL_0039: Expected O, but got I4
			//IL_00a0: Expected I4, but got I8
			//IL_00c1: Expected I4, but got I8
			if (item != null && info != null)
			{
				NewsFeedPost newsFeedPost = new NewsFeedPost();
				string text = (newsFeedPost.ItemId = item.Id);
				string text2 = (newsFeedPost.DisplayName = info.DisplayName);
				int num = 0;
				string text4 = (newsFeedPost.UrlPreview = (newsFeedPost.Url = item.GetScreenshotUrl((string)num)));
				DateTime dateTime = default(DateTime);
				Timestamp timestamp = (newsFeedPost.date_ = dateTime.ToProto());
				NewsFeedUserPost newsFeedUserPost = new NewsFeedUserPost();
				string text5 = (newsFeedUserPost.PlayfabId = info.PlayfabId);
				string text6 = (newsFeedUserPost.EntityId = info.EntityId);
				string text7 = (newsFeedUserPost.Avatar = info.AvatarUrl);
				newsFeedUserPost.likes_ = 0;
				newsFeedUserPost.likedByMe_ = false;
				newsFeedUserPost.isMine_ = isMine;
				newsFeedPost.type_ = newsFeedUserPost;
				newsFeedPost.typeCase_ = TypeOneofCase.UserPost;
				string contentType = item.ContentType;
				if (text7 != null)
				{
					PostProperties postProperties = PlayFabSysHttp.DeserializeObject<PostProperties>(item.DisplayProperties.ToString());
					if (postProperties != null && postProperties.Items != null)
					{
						RepeatedField<int> items_ = newsFeedPost.UserPost.items_;
						List<int> _003CItems_003Ek__BackingField = postProperties.Items;
						((RepeatedField<T>)(object)items_).AddRange((IEnumerable<>)_003CItems_003Ek__BackingField);
					}
				}
				return newsFeedPost;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600653C")]
		[Cpp2IlInjected.Address(RVA = "0x13975B0", Offset = "0x1395FB0", VA = "0x1813975B0")]
		public static NewsFeedPost NewEventPost(CatalogItem item, string name, string displayName, SocialEventType eventType)
		{
			//Discarded unreachable code: IL_00c5
			//IL_0046: Expected O, but got I4
			//IL_00c3: Expected I4, but got I8
			if (item == null)
			{
				int num = 0;
			}
			NewsFeedPost newsFeedPost = new NewsFeedPost();
			string text = (newsFeedPost.itemId_ = ProtoPreconditions.CheckNotNull(item.Id, "value"));
			string text2 = (newsFeedPost.displayName_ = ProtoPreconditions.CheckNotNull(displayName, "value"));
			int num2 = 0;
			string text3 = (newsFeedPost.urlPreview_ = ProtoPreconditions.CheckNotNull(newsFeedPost.url_ = ProtoPreconditions.CheckNotNull(item.GetScreenshotUrl((string)num2), "value"), "value"));
			DateTime dateTime = default(DateTime);
			Timestamp timestamp = (newsFeedPost.date_ = dateTime.ToProto());
			NewsFeedEventPost newsFeedEventPost = new NewsFeedEventPost();
			newsFeedEventPost.name_ = "";
			string text4 = (newsFeedEventPost.name_ = ProtoPreconditions.CheckNotNull(name, "value"));
			newsFeedEventPost.type_ = eventType;
			newsFeedPost.type_ = newsFeedEventPost;
			newsFeedPost.typeCase_ = TypeOneofCase.EventPost;
			return newsFeedPost;
		}

		[Cpp2IlInjected.Token(Token = "0x600653D")]
		[Cpp2IlInjected.Address(RVA = "0x1398170", Offset = "0x1396B70", VA = "0x181398170")]
		static NewsFeedPost()
		{
			Func<NewsFeedPost> func = default(Func<NewsFeedPost>);
			_parser = (MessageParser<NewsFeedPost>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
