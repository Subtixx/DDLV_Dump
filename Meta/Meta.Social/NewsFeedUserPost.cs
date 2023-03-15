using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BE0")]
	public sealed class NewsFeedUserPost : IMessage<NewsFeedUserPost>, IMessage, IEquatable<NewsFeedUserPost>, IDeepCloneable<NewsFeedUserPost>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BE1")]
		public delegate void NewFeedInfoEvent(NewsFeedUserPost info);

		[Cpp2IlInjected.Token(Token = "0x4002DF7")]
		private static readonly MessageParser<NewsFeedUserPost> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002DF8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002DF9")]
		public const int EntityIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002DFA")]
		private string entityId_;

		[Cpp2IlInjected.Token(Token = "0x4002DFB")]
		public const int PlayfabIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002DFC")]
		private string playfabId_;

		[Cpp2IlInjected.Token(Token = "0x4002DFD")]
		public const int AvatarFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002DFE")]
		private string avatar_;

		[Cpp2IlInjected.Token(Token = "0x4002DFF")]
		public const int ScoreFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E00")]
		private int score_;

		[Cpp2IlInjected.Token(Token = "0x4002E01")]
		public const int ItemsFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x4002E02")]
		private static readonly FieldCodec<int> _repeated_items_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002E03")]
		private readonly RepeatedField<int> items_;

		[Cpp2IlInjected.Token(Token = "0x4002E04")]
		public const int LikesFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002E05")]
		private int likes_;

		[Cpp2IlInjected.Token(Token = "0x4002E06")]
		public const int LikedByMeFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002E07")]
		private bool likedByMe_;

		[Cpp2IlInjected.Token(Token = "0x4002E08")]
		public const int IsMineFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4002E09")]
		private bool isMine_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002E0C")]
		private bool? OverrideLikedByMe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002E0D")]
		private int OverrideLikesInc;

		[Cpp2IlInjected.Token(Token = "0x17001169")]
		[DebuggerNonUserCode]
		public static MessageParser<NewsFeedUserPost> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60064D0")]
			[Cpp2IlInjected.Address(RVA = "0x139A410", Offset = "0x1398E10", VA = "0x18139A410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60064D1")]
			[Cpp2IlInjected.Address(RVA = "0x139A320", Offset = "0x1398D20", VA = "0x18139A320")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60064D2")]
			[Cpp2IlInjected.Address(RVA = "0x139A470", Offset = "0x1398E70", VA = "0x18139A470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116C")]
		[DebuggerNonUserCode]
		public string EntityId
		{
			[Cpp2IlInjected.Token(Token = "0x60064D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return entityId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60064D7")]
			[Cpp2IlInjected.Address(RVA = "0x139A690", Offset = "0x1399090", VA = "0x18139A690")]
			set
			{
				string text = (entityId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116D")]
		[DebuggerNonUserCode]
		public string PlayfabId
		{
			[Cpp2IlInjected.Token(Token = "0x60064D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return playfabId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60064D9")]
			[Cpp2IlInjected.Address(RVA = "0x139A720", Offset = "0x1399120", VA = "0x18139A720")]
			set
			{
				string text = (playfabId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116E")]
		[DebuggerNonUserCode]
		public string Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x60064DA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return avatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x60064DB")]
			[Cpp2IlInjected.Address(RVA = "0x139A620", Offset = "0x1399020", VA = "0x18139A620")]
			set
			{
				string text = (avatar_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116F")]
		[DebuggerNonUserCode]
		public int Score
		{
			[Cpp2IlInjected.Token(Token = "0x60064DC")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return score_;
			}
			[Cpp2IlInjected.Token(Token = "0x60064DD")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				score_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001170")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60064DE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001171")]
		[DebuggerNonUserCode]
		public int Likes
		{
			[Cpp2IlInjected.Token(Token = "0x60064DF")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return likes_;
			}
			[Cpp2IlInjected.Token(Token = "0x60064E0")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				likes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001172")]
		[DebuggerNonUserCode]
		public bool LikedByMe
		{
			[Cpp2IlInjected.Token(Token = "0x60064E1")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E60", Offset = "0xAE0860", VA = "0x180AE1E60")]
			get
			{
				return likedByMe_;
			}
			[Cpp2IlInjected.Token(Token = "0x60064E2")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E70", Offset = "0xAE0870", VA = "0x180AE1E70")]
			set
			{
				likedByMe_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001173")]
		[DebuggerNonUserCode]
		public bool IsMine
		{
			[Cpp2IlInjected.Token(Token = "0x60064E3")]
			[Cpp2IlInjected.Address(RVA = "0x139A3F0", Offset = "0x1398DF0", VA = "0x18139A3F0")]
			get
			{
				return isMine_;
			}
			[Cpp2IlInjected.Token(Token = "0x60064E4")]
			[Cpp2IlInjected.Address(RVA = "0x139A700", Offset = "0x1399100", VA = "0x18139A700")]
			set
			{
				isMine_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001174")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x46"), Cpp2IlInjected.Token(Token = "0x4002E0A")]
		public bool LikesReady
		{
			[Cpp2IlInjected.Token(Token = "0x60064F0")]
			[Cpp2IlInjected.Address(RVA = "0x139A400", Offset = "0x1398E00", VA = "0x18139A400")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60064F1")]
			[Cpp2IlInjected.Address(RVA = "0x139A710", Offset = "0x1399110", VA = "0x18139A710")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400008D")]
		public event NewFeedInfoEvent OnLikesChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60064F2")]
			[Cpp2IlInjected.Address(RVA = "0x139A280", Offset = "0x1398C80", VA = "0x18139A280")]
			[CompilerGenerated]
			add
			{
				NewFeedInfoEvent onLikesChanged = this.OnLikesChanged;
				Delegate @delegate = Delegate.Combine(onLikesChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLikesChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60064F3")]
			[Cpp2IlInjected.Address(RVA = "0x139A580", Offset = "0x1398F80", VA = "0x18139A580")]
			[CompilerGenerated]
			remove
			{
				NewFeedInfoEvent onLikesChanged = this.OnLikesChanged;
				Delegate @delegate = Delegate.Remove(onLikesChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLikesChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60064D3")]
		[Cpp2IlInjected.Address(RVA = "0x139A1C0", Offset = "0x1398BC0", VA = "0x18139A1C0")]
		[DebuggerNonUserCode]
		public NewsFeedUserPost()
		{
			entityId_ = "";
			playfabId_ = "";
			avatar_ = "";
			items_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60064D4")]
		[Cpp2IlInjected.Address(RVA = "0x139A0E0", Offset = "0x1398AE0", VA = "0x18139A0E0")]
		[DebuggerNonUserCode]
		public NewsFeedUserPost(NewsFeedUserPost other)
		{
			string text = (entityId_ = other.entityId_);
			string text2 = (playfabId_ = other.playfabId_);
			string text3 = (avatar_ = other.avatar_);
			int num = (score_ = other.score_);
			RepeatedField<int> repeatedField = (items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.items_).Clone());
			int num2 = (likes_ = other.likes_);
			bool flag = (likedByMe_ = other.likedByMe_);
			bool flag2 = (isMine_ = other.isMine_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60064D5")]
		[Cpp2IlInjected.Address(RVA = "0x1398EE0", Offset = "0x13978E0", VA = "0x181398EE0", Slot = "10")]
		[DebuggerNonUserCode]
		public NewsFeedUserPost Clone()
		{
			//Discarded unreachable code: IL_009c
			NewsFeedUserPost newsFeedUserPost = new NewsFeedUserPost();
			string text = (newsFeedUserPost.entityId_ = entityId_);
			string text2 = (newsFeedUserPost.playfabId_ = playfabId_);
			string text3 = (newsFeedUserPost.avatar_ = avatar_);
			int num = (newsFeedUserPost.score_ = score_);
			RepeatedField<int> repeatedField = (newsFeedUserPost.items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)items_).Clone());
			int num2 = (newsFeedUserPost.likes_ = likes_);
			bool flag = (newsFeedUserPost.likedByMe_ = likedByMe_);
			bool flag2 = (newsFeedUserPost.isMine_ = isMine_);
			UnknownFieldSet unknownFieldSet = (newsFeedUserPost._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return newsFeedUserPost;
		}

		[Cpp2IlInjected.Token(Token = "0x60064E5")]
		[Cpp2IlInjected.Address(RVA = "0x13990F0", Offset = "0x1397AF0", VA = "0x1813990F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				string text = entityId_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = playfabId_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = avatar_;
						bool flag3 = default(bool);
						if (!flag3 && score_ == (flag3 ? 1 : 0))
						{
							RepeatedField<int> repeatedField = items_;
							bool flag4 = default(bool);
							if (flag4 && likes_ == (flag4 ? 1 : 0) && likedByMe_ == flag4 && isMine_ == flag4)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60064E6")]
		[Cpp2IlInjected.Address(RVA = "0x1398FF0", Offset = "0x13979F0", VA = "0x181398FF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NewsFeedUserPost other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.entityId_;
				if (!(entityId_ != text))
				{
					string text2 = other.playfabId_;
					if (!(playfabId_ != text2))
					{
						string text3 = other.avatar_;
						if (!(avatar_ != text3))
						{
							int num = other.score_;
							if (score_ == num)
							{
								RepeatedField<int> repeatedField = items_;
								RepeatedField<int> repeatedField2 = other.items_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									int num2 = other.likes_;
									if (likes_ == num2)
									{
										bool flag = other.likedByMe_;
										if (likedByMe_ == flag)
										{
											bool flag2 = other.isMine_;
											if (isMine_ == flag2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60064E7")]
		[Cpp2IlInjected.Address(RVA = "0x13993D0", Offset = "0x1397DD0", VA = "0x1813993D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0096
			string text = entityId_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = playfabId_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = avatar_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			if (score_ != 0)
			{
			}
			int hashCode4 = ((RepeatedField<T>)(object)items_).GetHashCode();
			if (likes_ != 0)
			{
			}
			if (likedByMe_)
			{
			}
			if (isMine_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60064E8")]
		[Cpp2IlInjected.Address(RVA = "0x1399D20", Offset = "0x1398720", VA = "0x181399D20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60064E9")]
		[Cpp2IlInjected.Address(RVA = "0x1399D80", Offset = "0x1398780", VA = "0x181399D80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00e5
			if (entityId_.m_stringLength != 0)
			{
				string value = entityId_;
				output.WriteString(value);
			}
			if (playfabId_.m_stringLength != 0)
			{
				string value2 = playfabId_;
				output.WriteString(value2);
			}
			if (avatar_.m_stringLength != 0)
			{
				string value3 = avatar_;
				output.WriteString(value3);
			}
			if (score_ != 0)
			{
				int value4 = score_;
				output.WriteInt32(value4);
			}
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_items_codec);
			if (likes_ != 0)
			{
				int value5 = likes_;
				output.WriteInt32(value5);
			}
			if (likedByMe_)
			{
				bool value6 = likedByMe_;
				output.WriteBool(value6);
			}
			if (isMine_)
			{
				bool value7 = isMine_;
				output.WriteBool(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60064EA")]
		[Cpp2IlInjected.Address(RVA = "0x1398B80", Offset = "0x1397580", VA = "0x181398B80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00e0
			string text = entityId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = playfabId_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = avatar_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			int num5 = score_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6 += 2;
				num += num6;
			}
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_items_codec);
			int num8 = likes_;
			num += num7;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9 += 2;
				num += num9;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num += num10;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60064EB")]
		[Cpp2IlInjected.Address(RVA = "0x1399700", Offset = "0x1398100", VA = "0x181399700", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NewsFeedUserPost other)
		{
			//Discarded unreachable code: IL_00d6
			if (other != null)
			{
				string text = other.entityId_;
				if (text.m_stringLength != 0)
				{
					EntityId = text;
				}
				string text2 = other.playfabId_;
				if (text2.m_stringLength != 0)
				{
					PlayfabId = text2;
				}
				string text3 = other.avatar_;
				if (text3.m_stringLength != 0)
				{
					Avatar = text3;
				}
				int num = other.score_;
				if (num != 0)
				{
					score_ = num;
				}
				RepeatedField<int> repeatedField = items_;
				RepeatedField<int> repeatedField2 = other.items_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num2 = other.likes_;
				if (num2 != 0)
				{
					likes_ = num2;
				}
				bool flag = other.likedByMe_;
				if (flag)
				{
					likedByMe_ = flag;
				}
				bool flag2 = other.isMine_;
				if (flag2)
				{
					isMine_ = flag2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60064EC")]
		[Cpp2IlInjected.Address(RVA = "0x1399520", Offset = "0x1397F20", VA = "0x181399520", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_010e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 128)
			{
				if ((int)num > 138)
				{
					if (num == 160)
					{
						int num2 = (likes_ = input.ReadInt32());
					}
					bool flag = default(bool);
					if (num == 168)
					{
						flag = (likedByMe_ = input.ReadBool());
					}
					if (!flag)
					{
						goto IL_00f7;
					}
					bool flag2 = (isMine_ = input.ReadBool());
				}
				num += 4294967160u;
				if (num != 4294967293u)
				{
					goto IL_00f7;
				}
				RepeatedField<int> repeatedField = items_;
				FieldCodec<int> repeated_items_codec = _repeated_items_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_items_codec);
			}
			int num3 = default(int);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 82)
				{
					text2 = (Avatar = input.ReadString());
				}
				if ((long)text2 != 128)
				{
					goto IL_00f7;
				}
				num3 = (score_ = input.ReadInt32());
			}
			string text4 = default(string);
			if (num3 == 10)
			{
				text4 = (EntityId = input.ReadString());
			}
			if ((long)text4 == 18)
			{
				string text6 = (PlayfabId = input.ReadString());
			}
			goto IL_00f7;
			IL_00f7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60064ED")]
		[Cpp2IlInjected.Address(RVA = "0x1399230", Offset = "0x1397C30", VA = "0x181399230", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 2)
			{
				if (fieldNumber == 10)
				{
					string text = avatar_;
				}
				if (fieldNumber > 6)
				{
					goto IL_002a;
				}
				int num = score_;
			}
			if (fieldNumber == 1)
			{
				string text2 = entityId_;
			}
			if (fieldNumber != 2)
			{
			}
			goto IL_002a;
			IL_002a:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60064EE")]
		[Cpp2IlInjected.Address(RVA = "0x1399950", Offset = "0x1398350", VA = "0x181399950", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0027, IL_002f, IL_0037, IL_004e
			//IL_001a: Expected O, but got I4
			//IL_0026: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			//IL_0036: Expected I4, but got O
			//IL_003f: Expected I4, but got O
			object obj = default(object);
			while (true)
			{
				if (fieldNumber > 2)
				{
					if (fieldNumber == 10)
					{
						int num = 0;
						if (value != null && value == null)
						{
							break;
						}
						Avatar = (string)num;
					}
					else
					{
						while (fieldNumber > 6)
						{
						}
						score_ = (int)obj;
					}
					return;
				}
				if (fieldNumber != 1 || value == null || value != null)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60064EF")]
		[Cpp2IlInjected.Address(RVA = "0x1398D80", Offset = "0x1397780", VA = "0x181398D80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0023, IL_0024, IL_0025, IL_003b
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 10:
				Avatar = "";
				break;
			case 3:
			case 4:
			case 5:
			case 6:
				score_ = 0;
				break;
			case 1:
				EntityId = "";
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60064F4")]
		[Cpp2IlInjected.Address(RVA = "0x1399C20", Offset = "0x1398620", VA = "0x181399C20")]
		public unsafe void SetLikes(int likes, bool likedByMe, bool canRaiseEvent = true)
		{
			//IL_0014: Expected I4, but got O
			//IL_0026: Expected I4, but got O
			int num = likes_;
			int num2 = 0;
			likes_ = (int)typeof(Math).TypeHandle;
			bool? overrideLikedByMe = OverrideLikedByMe;
			bool flag = default(bool);
			if ((object)overrideLikedByMe != null)
			{
				flag = (byte)(int)((Nullable<>*)(&overrideLikedByMe))->value != 0;
			}
			likedByMe_ = flag;
			int num3 = likes_;
			if (num3 == 0 && flag)
			{
				likes_ = 1;
			}
			if (canRaiseEvent && (num != num3 || !LikesReady))
			{
				NewFeedInfoEvent onLikesChanged = this.OnLikesChanged;
				LikesReady = true;
				onLikesChanged?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60064F5")]
		[Cpp2IlInjected.Address(RVA = "0x1399800", Offset = "0x1398200", VA = "0x181399800")]
		public void OverrideLikes(bool likedByMe, int inc)
		{
			//IL_0017: Expected O, but got I4
			//IL_0033: Expected I4, but got O
			int num = 0;
			bool flag = likedByMe_;
			bool flag2 = LikesReady;
			OverrideLikedByMe = (bool?)(object)num;
			OverrideLikesInc = inc;
			int num2 = likes_;
			int num3 = 0;
			likes_ = (int)typeof(Math).TypeHandle;
			bool? overrideLikedByMe = OverrideLikedByMe;
			likedByMe_ = flag;
			int num4 = likes_;
			if (num4 == 0 && flag)
			{
				likes_ = 1;
			}
			if (flag2 && (num2 != num4 || (LikesReady ? 1 : 0) == num))
			{
				NewFeedInfoEvent onLikesChanged = this.OnLikesChanged;
				LikesReady = true;
				onLikesChanged?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60064F6")]
		[Cpp2IlInjected.Address(RVA = "0x1399FA0", Offset = "0x13989A0", VA = "0x181399FA0")]
		static NewsFeedUserPost()
		{
			Func<NewsFeedUserPost> func = default(Func<NewsFeedUserPost>);
			_parser = (MessageParser<NewsFeedUserPost>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<NewsFeedUserPost>)(object)FieldCodec.ForInt32(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
