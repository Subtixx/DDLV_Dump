using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000857")]
	public sealed class FriendshipData : IDataValidation, IMessage<FriendshipData>, IMessage, IEquatable<FriendshipData>, IDeepCloneable<FriendshipData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002943")]
		private static readonly MessageParser<FriendshipData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002944")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002945")]
		public const int FriendshipLevelsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002946")]
		private static readonly FieldCodec<FriendshipLevel> _repeated_friendshipLevels_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002947")]
		private readonly RepeatedField<FriendshipLevel> friendshipLevels_ = (RepeatedField<FriendshipLevel>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002948")]
		public const int CharacterIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002949")]
		private int characterId_;

		[Cpp2IlInjected.Token(Token = "0x400294A")]
		public const int DiscussionFriendshipFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400294B")]
		private int discussionFriendship_;

		[Cpp2IlInjected.Token(Token = "0x400294C")]
		public const int GiftFriendshipFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400294D")]
		private int giftFriendship_;

		[Cpp2IlInjected.Token(Token = "0x1700177E")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005D2F")]
			[Cpp2IlInjected.Address(RVA = "0x34377D0", Offset = "0x34361D0", VA = "0x1834377D0")]
			get
			{
				long num = Convert.ToInt64((uint)characterId_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700177F")]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005D31")]
			[Cpp2IlInjected.Address(RVA = "0x3437900", Offset = "0x3436300", VA = "0x183437900")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001780")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D32")]
			[Cpp2IlInjected.Address(RVA = "0x3437830", Offset = "0x3436230", VA = "0x183437830")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001781")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005D33")]
			[Cpp2IlInjected.Address(RVA = "0x3437960", Offset = "0x3436360", VA = "0x183437960", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001782")]
		[DebuggerNonUserCode]
		public RepeatedField<FriendshipLevel> FriendshipLevels
		{
			[Cpp2IlInjected.Token(Token = "0x6005D37")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return friendshipLevels_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001783")]
		[DebuggerNonUserCode]
		public int CharacterId
		{
			[Cpp2IlInjected.Token(Token = "0x6005D38")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return characterId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D39")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				characterId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001784")]
		[DebuggerNonUserCode]
		public int DiscussionFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6005D3A")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return discussionFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D3B")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				discussionFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001785")]
		[DebuggerNonUserCode]
		public int GiftFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6005D3C")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return giftFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D3D")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				giftFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D30")]
		[Cpp2IlInjected.Address(RVA = "0x3436BB0", Offset = "0x34355B0", VA = "0x183436BB0", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001f
			if (((RepeatedField<T>)(object)friendshipLevels_).Count == 0)
			{
				context.AddInvalidMemberError("Cannot be empty", "FriendshipLevels");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D34")]
		[Cpp2IlInjected.Address(RVA = "0x3437640", Offset = "0x3436040", VA = "0x183437640")]
		[DebuggerNonUserCode]
		public FriendshipData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005D35")]
		[Cpp2IlInjected.Address(RVA = "0x34376C0", Offset = "0x34360C0", VA = "0x1834376C0")]
		[DebuggerNonUserCode]
		public FriendshipData(FriendshipData other)
		{
			RepeatedField<FriendshipLevel> repeatedField = (friendshipLevels_ = (RepeatedField<FriendshipLevel>)(object)((RepeatedField<T>)(object)other.friendshipLevels_).Clone());
			int num = (characterId_ = other.characterId_);
			int num2 = (discussionFriendship_ = other.discussionFriendship_);
			int num3 = (giftFriendship_ = other.giftFriendship_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D36")]
		[Cpp2IlInjected.Address(RVA = "0x3436A70", Offset = "0x3435470", VA = "0x183436A70", Slot = "11")]
		[DebuggerNonUserCode]
		public FriendshipData Clone()
		{
			//Discarded unreachable code: IL_006b
			FriendshipData friendshipData = new FriendshipData();
			RepeatedField<FriendshipLevel> repeatedField = (friendshipData.friendshipLevels_ = (RepeatedField<FriendshipLevel>)(object)new RepeatedField<T>());
			RepeatedField<FriendshipLevel> repeatedField2 = (friendshipData.friendshipLevels_ = (RepeatedField<FriendshipLevel>)(object)((RepeatedField<T>)(object)friendshipLevels_).Clone());
			int num = (friendshipData.characterId_ = characterId_);
			int num2 = (friendshipData.discussionFriendship_ = discussionFriendship_);
			int num3 = (friendshipData.giftFriendship_ = giftFriendship_);
			UnknownFieldSet unknownFieldSet = (friendshipData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return friendshipData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D3E")]
		[Cpp2IlInjected.Address(RVA = "0x3436CF0", Offset = "0x34356F0", VA = "0x183436CF0", Slot = "0")]
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
				RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
				bool flag = default(bool);
				if (flag && characterId_ == (flag ? 1 : 0) && discussionFriendship_ == (flag ? 1 : 0) && giftFriendship_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D3F")]
		[Cpp2IlInjected.Address(RVA = "0x3436C40", Offset = "0x3435640", VA = "0x183436C40", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
				RepeatedField<FriendshipLevel> repeatedField2 = other.friendshipLevels_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.characterId_;
					if (characterId_ == num)
					{
						int num2 = other.discussionFriendship_;
						if (discussionFriendship_ == num2)
						{
							int num3 = other.giftFriendship_;
							if (giftFriendship_ == num3)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D40")]
		[Cpp2IlInjected.Address(RVA = "0x3436EC0", Offset = "0x34358C0", VA = "0x183436EC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003d
			int hashCode = ((RepeatedField<T>)(object)friendshipLevels_).GetHashCode();
			if (characterId_ != 0)
			{
			}
			if (discussionFriendship_ != 0)
			{
			}
			if (giftFriendship_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D41")]
		[Cpp2IlInjected.Address(RVA = "0x34372D0", Offset = "0x3435CD0", VA = "0x1834372D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D42")]
		[Cpp2IlInjected.Address(RVA = "0x3437330", Offset = "0x3435D30", VA = "0x183437330", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0072
			RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
			FieldCodec<FriendshipLevel> repeated_friendshipLevels_codec = _repeated_friendshipLevels_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_friendshipLevels_codec);
			if (characterId_ != 0)
			{
				int value = characterId_;
				output.WriteInt32(value);
			}
			if (discussionFriendship_ != 0)
			{
				int value2 = discussionFriendship_;
				output.WriteInt32(value2);
			}
			if (giftFriendship_ != 0)
			{
				int value3 = giftFriendship_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D43")]
		[Cpp2IlInjected.Address(RVA = "0x3436860", Offset = "0x3435260", VA = "0x183436860", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0096
			RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
			FieldCodec<FriendshipLevel> repeated_friendshipLevels_codec = _repeated_friendshipLevels_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_friendshipLevels_codec);
			int num2 = characterId_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			int num4 = discussionFriendship_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			int num6 = giftFriendship_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
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

		[Cpp2IlInjected.Token(Token = "0x6005D44")]
		[Cpp2IlInjected.Address(RVA = "0x34370C0", Offset = "0x3435AC0", VA = "0x1834370C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipData other)
		{
			//Discarded unreachable code: IL_0072
			if (other != null)
			{
				RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
				RepeatedField<FriendshipLevel> repeatedField2 = other.friendshipLevels_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.characterId_;
				if (num != 0)
				{
					characterId_ = num;
				}
				int num2 = other.discussionFriendship_;
				if (num2 != 0)
				{
					discussionFriendship_ = num2;
				}
				int num3 = other.giftFriendship_;
				if (num3 != 0)
				{
					giftFriendship_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D45")]
		[Cpp2IlInjected.Address(RVA = "0x3436F80", Offset = "0x3435980", VA = "0x183436F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0087
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (discussionFriendship_ = input.ReadInt32());
				}
				if (num != 32)
				{
					goto IL_0070;
				}
				int num3 = (giftFriendship_ = input.ReadInt32());
			}
			if (num == 10)
			{
				RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
				FieldCodec<FriendshipLevel> repeated_friendshipLevels_codec = _repeated_friendshipLevels_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_friendshipLevels_codec);
			}
			if (num == 16)
			{
				int num4 = (characterId_ = input.ReadInt32());
			}
			goto IL_0070;
			IL_0070:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005D46")]
		[Cpp2IlInjected.Address(RVA = "0x3436DE0", Offset = "0x34357E0", VA = "0x183436DE0", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0 && num != 1)
				{
					goto IL_0022;
				}
				int num2 = characterId_;
			}
			RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
			goto IL_0022;
			IL_0022:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D47")]
		[Cpp2IlInjected.Address(RVA = "0x3437160", Offset = "0x3435B60", VA = "0x183437160", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			//IL_0023: Expected I4, but got O
			//IL_002b: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj2 = default(object);
						giftFriendship_ = (int)obj2;
						break;
					}
					case 0:
					{
						object obj = default(object);
						discussionFriendship_ = (int)obj;
						break;
					}
					}
				}
				else
				{
					object obj3 = default(object);
					characterId_ = (int)obj3;
				}
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D48")]
		[Cpp2IlInjected.Address(RVA = "0x34369C0", Offset = "0x34353C0", VA = "0x1834369C0", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_001d: Expected I4, but got I8
			//IL_0027: Expected I4, but got I8
			//IL_0031: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						giftFriendship_ = 0;
						break;
					case 0:
						discussionFriendship_ = 0;
						break;
					}
				}
				else
				{
					characterId_ = 0;
				}
				return;
			}
			RepeatedField<FriendshipLevel> repeatedField = friendshipLevels_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D49")]
		[Cpp2IlInjected.Address(RVA = "0x3437470", Offset = "0x3435E70", VA = "0x183437470")]
		static FriendshipData()
		{
			Func<FriendshipData> func = default(Func<FriendshipData>);
			_parser = (MessageParser<FriendshipData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<FriendshipLevel> parser = FriendshipLevel._parser;
			uint num = default(uint);
			_parser = (MessageParser<FriendshipData>)(object)FieldCodec.ForMessage<FriendshipLevel>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
