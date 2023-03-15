using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007E1")]
	public sealed class ProfileLimits : IMessage<ProfileLimits>, IMessage, IEquatable<ProfileLimits>, IDeepCloneable<ProfileLimits>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F5C")]
		private static readonly MessageParser<ProfileLimits> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F5D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F5E")]
		public const int AddFriendFieldNumber = 120;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F5F")]
		private LimitedAction addFriend_;

		[Cpp2IlInjected.Token(Token = "0x4001F60")]
		public const int RemoveFriendFieldNumber = 121;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F61")]
		private LimitedAction removeFriend_;

		[Cpp2IlInjected.Token(Token = "0x4001F62")]
		public const int FollowUserFieldNumber = 122;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F63")]
		private LimitedAction followUser_;

		[Cpp2IlInjected.Token(Token = "0x4001F64")]
		public const int UnfollowUserFieldNumber = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F65")]
		private LimitedAction unfollowUser_;

		[Cpp2IlInjected.Token(Token = "0x4001F66")]
		public const int PostPictureFieldNumber = 124;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001F67")]
		private LimitedAction postPicture_;

		[Cpp2IlInjected.Token(Token = "0x4001F68")]
		public const int DeliverItemFieldNumber = 140;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001F69")]
		private LimitedAction deliverItem_;

		[Cpp2IlInjected.Token(Token = "0x17000A84")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfileLimits> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004143")]
			[Cpp2IlInjected.Address(RVA = "0x961AA0", Offset = "0x9604A0", VA = "0x180961AA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A85")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004144")]
			[Cpp2IlInjected.Address(RVA = "0x9619D0", Offset = "0x9603D0", VA = "0x1809619D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A86")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004145")]
			[Cpp2IlInjected.Address(RVA = "0x961B00", Offset = "0x960500", VA = "0x180961B00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A87")]
		[DebuggerNonUserCode]
		public LimitedAction AddFriend
		{
			[Cpp2IlInjected.Token(Token = "0x6004149")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return addFriend_;
			}
			[Cpp2IlInjected.Token(Token = "0x600414A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				addFriend_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A88")]
		[DebuggerNonUserCode]
		public LimitedAction RemoveFriend
		{
			[Cpp2IlInjected.Token(Token = "0x600414B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return removeFriend_;
			}
			[Cpp2IlInjected.Token(Token = "0x600414C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				removeFriend_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A89")]
		[DebuggerNonUserCode]
		public LimitedAction FollowUser
		{
			[Cpp2IlInjected.Token(Token = "0x600414D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return followUser_;
			}
			[Cpp2IlInjected.Token(Token = "0x600414E")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				followUser_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8A")]
		[DebuggerNonUserCode]
		public LimitedAction UnfollowUser
		{
			[Cpp2IlInjected.Token(Token = "0x600414F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return unfollowUser_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004150")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				unfollowUser_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8B")]
		[DebuggerNonUserCode]
		public LimitedAction PostPicture
		{
			[Cpp2IlInjected.Token(Token = "0x6004151")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return postPicture_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004152")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				postPicture_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A8C")]
		[DebuggerNonUserCode]
		public LimitedAction DeliverItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004153")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return deliverItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004154")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				deliverItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004146")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ProfileLimits()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004147")]
		[Cpp2IlInjected.Address(RVA = "0x961890", Offset = "0x960290", VA = "0x180961890")]
		[DebuggerNonUserCode]
		public ProfileLimits(ProfileLimits other)
		{
			//IL_0021: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			LimitedAction limitedAction = other.addFriend_;
			int num = 0;
			if (limitedAction != null)
			{
				LimitedAction limitedAction2 = limitedAction.Clone();
			}
			addFriend_ = (LimitedAction)num;
			LimitedAction limitedAction3 = other.removeFriend_;
			if (limitedAction3 != null)
			{
				LimitedAction limitedAction4 = limitedAction3.Clone();
			}
			removeFriend_ = (LimitedAction)num;
			LimitedAction limitedAction5 = other.followUser_;
			if (limitedAction5 != null)
			{
				LimitedAction limitedAction6 = limitedAction5.Clone();
			}
			followUser_ = (LimitedAction)num;
			LimitedAction limitedAction7 = other.unfollowUser_;
			if (limitedAction7 != null)
			{
				LimitedAction limitedAction8 = limitedAction7.Clone();
			}
			unfollowUser_ = (LimitedAction)num;
			LimitedAction limitedAction9 = other.postPicture_;
			if (limitedAction9 != null)
			{
				LimitedAction limitedAction10 = limitedAction9.Clone();
			}
			postPicture_ = (LimitedAction)num;
			LimitedAction limitedAction11 = other.deliverItem_;
			LimitedAction limitedAction12 = default(LimitedAction);
			if (limitedAction11 != null)
			{
				limitedAction12 = limitedAction11.Clone();
			}
			deliverItem_ = limitedAction12;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004148")]
		[Cpp2IlInjected.Address(RVA = "0x960B20", Offset = "0x95F520", VA = "0x180960B20", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfileLimits Clone()
		{
			return new ProfileLimits(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004155")]
		[Cpp2IlInjected.Address(RVA = "0x960C60", Offset = "0x95F660", VA = "0x180960C60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(addFriend_, other) && object.Equals(removeFriend_, other) && object.Equals(followUser_, other) && object.Equals(unfollowUser_, other) && object.Equals(postPicture_, other) && object.Equals(deliverItem_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004156")]
		[Cpp2IlInjected.Address(RVA = "0x960B80", Offset = "0x95F580", VA = "0x180960B80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfileLimits other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				LimitedAction objB = other.addFriend_;
				if (object.Equals(addFriend_, objB))
				{
					LimitedAction objB2 = other.removeFriend_;
					if (object.Equals(removeFriend_, objB2))
					{
						LimitedAction objB3 = other.followUser_;
						if (object.Equals(followUser_, objB3))
						{
							LimitedAction objB4 = other.unfollowUser_;
							if (object.Equals(unfollowUser_, objB4))
							{
								LimitedAction objB5 = other.postPicture_;
								if (object.Equals(postPicture_, objB5))
								{
									LimitedAction objB6 = other.deliverItem_;
									if (object.Equals(deliverItem_, objB6))
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

		[Cpp2IlInjected.Token(Token = "0x6004157")]
		[Cpp2IlInjected.Address(RVA = "0x960E60", Offset = "0x95F860", VA = "0x180960E60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				LimitedAction limitedAction = addFriend_;
				if (limitedAction != null)
				{
					int hashCode = limitedAction.GetHashCode();
				}
				LimitedAction limitedAction2 = removeFriend_;
				if (limitedAction2 != null)
				{
					int hashCode2 = limitedAction2.GetHashCode();
				}
				LimitedAction limitedAction3 = followUser_;
				if (limitedAction3 != null)
				{
					int hashCode3 = limitedAction3.GetHashCode();
				}
				LimitedAction limitedAction4 = unfollowUser_;
				if (limitedAction4 != null)
				{
					int hashCode4 = limitedAction4.GetHashCode();
				}
				LimitedAction limitedAction5 = postPicture_;
				if (limitedAction5 != null)
				{
					int hashCode5 = limitedAction5.GetHashCode();
				}
				LimitedAction limitedAction6 = deliverItem_;
				if (limitedAction6 != null)
				{
					int hashCode6 = limitedAction6.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004158")]
		[Cpp2IlInjected.Address(RVA = "0x9615D0", Offset = "0x95FFD0", VA = "0x1809615D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004159")]
		[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960030", VA = "0x180961630", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b0
			if ((long)addFriend_ != 0)
			{
				LimitedAction value = addFriend_;
				output.WriteMessage(value);
			}
			if ((long)removeFriend_ != 0)
			{
				LimitedAction value2 = removeFriend_;
				output.WriteMessage(value2);
			}
			if ((long)followUser_ != 0)
			{
				LimitedAction value3 = followUser_;
				output.WriteMessage(value3);
			}
			if ((long)unfollowUser_ != 0)
			{
				LimitedAction value4 = unfollowUser_;
				output.WriteMessage(value4);
			}
			if ((long)postPicture_ != 0)
			{
				LimitedAction value5 = postPicture_;
				output.WriteMessage(value5);
			}
			if ((long)deliverItem_ != 0)
			{
				LimitedAction value6 = deliverItem_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600415A")]
		[Cpp2IlInjected.Address(RVA = "0x9608D0", Offset = "0x95F2D0", VA = "0x1809608D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				LimitedAction limitedAction = addFriend_;
				num = 0;
				if (limitedAction != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(limitedAction);
				}
				LimitedAction limitedAction2 = removeFriend_;
				if (limitedAction2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(limitedAction2);
					num3 += 2;
					num += num3;
				}
				LimitedAction limitedAction3 = followUser_;
				if (limitedAction3 != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(limitedAction3);
					num4 += 2;
					num += num4;
				}
				LimitedAction limitedAction4 = unfollowUser_;
				if (limitedAction4 != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(limitedAction4);
					num5 += 2;
					num += num5;
				}
				LimitedAction limitedAction5 = postPicture_;
				if (limitedAction5 != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(limitedAction5);
					num6 += 2;
					num += num6;
				}
				LimitedAction limitedAction6 = deliverItem_;
				if (limitedAction6 != null)
				{
					int num7 = CodedOutputStream.ComputeMessageSize(limitedAction6);
					num7 += 2;
					num += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600415B")]
		[Cpp2IlInjected.Address(RVA = "0x960F50", Offset = "0x95F950", VA = "0x180960F50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfileLimits other)
		{
			//Discarded unreachable code: IL_018b
			if (other == null)
			{
				return;
			}
			if ((long)other.addFriend_ != 0)
			{
				LimitedAction limitedAction = addFriend_;
				if (limitedAction == null)
				{
					LimitedAction limitedAction2 = (addFriend_ = new LimitedAction());
					LimitedAction limitedAction3 = addFriend_;
				}
				LimitedAction other2 = other.addFriend_;
				limitedAction.MergeFrom(other2);
			}
			if ((long)other.removeFriend_ != 0)
			{
				LimitedAction limitedAction5 = default(LimitedAction);
				if (removeFriend_ == null)
				{
					LimitedAction limitedAction4 = (removeFriend_ = new LimitedAction());
					limitedAction5 = removeFriend_;
				}
				LimitedAction other3 = other.removeFriend_;
				limitedAction5.MergeFrom(other3);
			}
			if ((long)other.followUser_ != 0)
			{
				LimitedAction limitedAction7 = default(LimitedAction);
				if (followUser_ == null)
				{
					LimitedAction limitedAction6 = (followUser_ = new LimitedAction());
					limitedAction7 = followUser_;
				}
				LimitedAction other4 = other.followUser_;
				limitedAction7.MergeFrom(other4);
			}
			if ((long)other.unfollowUser_ != 0)
			{
				LimitedAction limitedAction9 = default(LimitedAction);
				if (unfollowUser_ == null)
				{
					LimitedAction limitedAction8 = (unfollowUser_ = new LimitedAction());
					limitedAction9 = unfollowUser_;
				}
				LimitedAction other5 = other.unfollowUser_;
				limitedAction9.MergeFrom(other5);
			}
			if ((long)other.postPicture_ != 0)
			{
				LimitedAction limitedAction11 = default(LimitedAction);
				if (postPicture_ == null)
				{
					LimitedAction limitedAction10 = (postPicture_ = new LimitedAction());
					limitedAction11 = postPicture_;
				}
				LimitedAction other6 = other.postPicture_;
				limitedAction11.MergeFrom(other6);
			}
			if ((long)other.deliverItem_ != 0)
			{
				LimitedAction limitedAction13 = default(LimitedAction);
				if (deliverItem_ == null)
				{
					LimitedAction limitedAction12 = (deliverItem_ = new LimitedAction());
					limitedAction13 = deliverItem_;
				}
				LimitedAction other7 = other.deliverItem_;
				limitedAction13.MergeFrom(other7);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600415C")]
		[Cpp2IlInjected.Address(RVA = "0x9611C0", Offset = "0x95FBC0", VA = "0x1809611C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0155
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 978)
			{
				if (num == 986)
				{
					LimitedAction limitedAction = unfollowUser_;
					if (limitedAction == null)
					{
						LimitedAction limitedAction2 = (unfollowUser_ = new LimitedAction());
					}
					input.ReadMessage(limitedAction);
				}
				LimitedAction limitedAction3 = default(LimitedAction);
				if (num == 994)
				{
					LimitedAction builder = default(LimitedAction);
					if (postPicture_ == null)
					{
						limitedAction3 = (postPicture_ = new LimitedAction());
						builder = postPicture_;
					}
					input.ReadMessage(builder);
				}
				if ((long)limitedAction3 != 1122)
				{
					goto IL_013e;
				}
				LimitedAction builder2 = default(LimitedAction);
				if (deliverItem_ == null)
				{
					LimitedAction limitedAction4 = (deliverItem_ = new LimitedAction());
					builder2 = deliverItem_;
				}
				input.ReadMessage(builder2);
			}
			LimitedAction limitedAction5 = default(LimitedAction);
			if (num == 962)
			{
				LimitedAction builder3 = default(LimitedAction);
				if (addFriend_ == null)
				{
					limitedAction5 = (addFriend_ = new LimitedAction());
					builder3 = addFriend_;
				}
				input.ReadMessage(builder3);
			}
			LimitedAction limitedAction6 = default(LimitedAction);
			if ((long)limitedAction5 == 970)
			{
				LimitedAction builder4 = default(LimitedAction);
				if (removeFriend_ == null)
				{
					limitedAction6 = (removeFriend_ = new LimitedAction());
					builder4 = removeFriend_;
				}
				input.ReadMessage(builder4);
			}
			if ((long)limitedAction6 == 978)
			{
				LimitedAction builder5 = default(LimitedAction);
				if (followUser_ == null)
				{
					LimitedAction limitedAction7 = (followUser_ = new LimitedAction());
					builder5 = followUser_;
				}
				input.ReadMessage(builder5);
			}
			goto IL_013e;
			IL_013e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600415D")]
		[Cpp2IlInjected.Address(RVA = "0x960D80", Offset = "0x95F780", VA = "0x180960D80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 140)
			{
				LimitedAction limitedAction = deliverItem_;
				LimitedAction limitedAction2 = postPicture_;
				LimitedAction limitedAction3 = unfollowUser_;
				LimitedAction limitedAction4 = followUser_;
				LimitedAction limitedAction5 = removeFriend_;
				LimitedAction limitedAction6 = addFriend_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600415E")]
		[Cpp2IlInjected.Address(RVA = "0x961430", Offset = "0x95FE30", VA = "0x180961430", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_002f: Expected O, but got I4
			if (value != null)
			{
				if (value != null)
				{
					if (value != null)
					{
						if (value != null)
						{
							if ((long)value != 1)
							{
								if (fieldNumber == 140)
								{
									int num = 0;
									if (value != null && value == null)
									{
										throw new InvalidCastException();
									}
									deliverItem_ = (LimitedAction)num;
								}
								return;
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
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600415F")]
		[Cpp2IlInjected.Address(RVA = "0x960A80", Offset = "0x95F480", VA = "0x180960A80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 140)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004160")]
		[Cpp2IlInjected.Address(RVA = "0x961780", Offset = "0x960180", VA = "0x180961780")]
		static ProfileLimits()
		{
			Func<ProfileLimits> func = default(Func<ProfileLimits>);
			_parser = (MessageParser<ProfileLimits>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
