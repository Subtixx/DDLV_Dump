using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000867")]
	public sealed class FriendshipLevel : IMessage<FriendshipLevel>, IMessage, IEquatable<FriendshipLevel>, IDeepCloneable<FriendshipLevel>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002974")]
		private static readonly MessageParser<FriendshipLevel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002975")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002976")]
		public const int LevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002977")]
		private int level_;

		[Cpp2IlInjected.Token(Token = "0x4002978")]
		public const int XPFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002979")]
		private int xP_;

		[Cpp2IlInjected.Token(Token = "0x400297A")]
		public const int Tier1RewardFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400297B")]
		private static readonly FieldCodec<ItemReward> _repeated_tier1Reward_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400297C")]
		private readonly RepeatedField<ItemReward> tier1Reward_ = (RepeatedField<ItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400297D")]
		public const int Tier2RewardFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400297E")]
		private static readonly FieldCodec<ItemReward> _repeated_tier2Reward_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400297F")]
		private readonly RepeatedField<ItemReward> tier2Reward_ = (RepeatedField<ItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002980")]
		public const int Tier3RewardFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002981")]
		private static readonly FieldCodec<ItemReward> _repeated_tier3Reward_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002982")]
		private readonly RepeatedField<ItemReward> tier3Reward_ = (RepeatedField<ItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002983")]
		public const int LevelRewardFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4002984")]
		private static readonly FieldCodec<ItemReward> _repeated_levelReward_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002985")]
		private readonly RepeatedField<ItemReward> levelReward_ = (RepeatedField<ItemReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700179E")]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipLevel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005DDD")]
			[Cpp2IlInjected.Address(RVA = "0x343A440", Offset = "0x3438E40", VA = "0x18343A440")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DDE")]
			[Cpp2IlInjected.Address(RVA = "0x343A370", Offset = "0x3438D70", VA = "0x18343A370")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DDF")]
			[Cpp2IlInjected.Address(RVA = "0x343A4A0", Offset = "0x3438EA0", VA = "0x18343A4A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A1")]
		[DebuggerNonUserCode]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6005DE3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return level_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005DE4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				level_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A2")]
		[DebuggerNonUserCode]
		public int XP
		{
			[Cpp2IlInjected.Token(Token = "0x6005DE5")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return xP_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005DE6")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				xP_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A3")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemReward> Tier1Reward
		{
			[Cpp2IlInjected.Token(Token = "0x6005DE7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return tier1Reward_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A4")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemReward> Tier2Reward
		{
			[Cpp2IlInjected.Token(Token = "0x6005DE8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return tier2Reward_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A5")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemReward> Tier3Reward
		{
			[Cpp2IlInjected.Token(Token = "0x6005DE9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return tier3Reward_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A6")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemReward> LevelReward
		{
			[Cpp2IlInjected.Token(Token = "0x6005DEA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return levelReward_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DE0")]
		[Cpp2IlInjected.Address(RVA = "0x343A050", Offset = "0x3438A50", VA = "0x18343A050")]
		[DebuggerNonUserCode]
		public FriendshipLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005DE1")]
		[Cpp2IlInjected.Address(RVA = "0x343A150", Offset = "0x3438B50", VA = "0x18343A150")]
		[DebuggerNonUserCode]
		public FriendshipLevel(FriendshipLevel other)
		{
			int num = (level_ = other.level_);
			int num2 = (xP_ = other.xP_);
			RepeatedField<ItemReward> repeatedField = (tier1Reward_ = (RepeatedField<ItemReward>)(object)((RepeatedField<T>)(object)other.tier1Reward_).Clone());
			RepeatedField<ItemReward> repeatedField2 = (tier2Reward_ = (RepeatedField<ItemReward>)(object)((RepeatedField<T>)(object)other.tier2Reward_).Clone());
			RepeatedField<ItemReward> repeatedField3 = (tier3Reward_ = (RepeatedField<ItemReward>)(object)((RepeatedField<T>)(object)other.tier3Reward_).Clone());
			RepeatedField<ItemReward> repeatedField4 = (levelReward_ = (RepeatedField<ItemReward>)(object)((RepeatedField<T>)(object)other.levelReward_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DE2")]
		[Cpp2IlInjected.Address(RVA = "0x34390C0", Offset = "0x3437AC0", VA = "0x1834390C0", Slot = "10")]
		[DebuggerNonUserCode]
		public FriendshipLevel Clone()
		{
			return new FriendshipLevel(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DEB")]
		[Cpp2IlInjected.Address(RVA = "0x3439230", Offset = "0x3437C30", VA = "0x183439230", Slot = "0")]
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
				if ((IntPtr)level_ == (IntPtr)typeof(FriendshipLevel).TypeHandle && (IntPtr)xP_ == (IntPtr)typeof(FriendshipLevel).TypeHandle)
				{
					RepeatedField<ItemReward> repeatedField = tier1Reward_;
					bool flag = default(bool);
					if (flag)
					{
						RepeatedField<ItemReward> repeatedField2 = tier2Reward_;
						bool flag2 = default(bool);
						if (flag2)
						{
							RepeatedField<ItemReward> repeatedField3 = tier3Reward_;
							bool flag3 = default(bool);
							if (flag3)
							{
								RepeatedField<ItemReward> repeatedField4 = levelReward_;
								bool flag4 = default(bool);
								if (flag4)
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DEC")]
		[Cpp2IlInjected.Address(RVA = "0x3439120", Offset = "0x3437B20", VA = "0x183439120", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipLevel other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.level_;
				if (level_ == num)
				{
					int num2 = other.xP_;
					if (xP_ == num2)
					{
						RepeatedField<ItemReward> repeatedField = tier1Reward_;
						RepeatedField<ItemReward> repeatedField2 = other.tier1Reward_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							RepeatedField<ItemReward> repeatedField3 = tier2Reward_;
							RepeatedField<ItemReward> repeatedField4 = other.tier2Reward_;
							if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
							{
								RepeatedField<ItemReward> repeatedField5 = tier3Reward_;
								RepeatedField<ItemReward> repeatedField6 = other.tier3Reward_;
								if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
								{
									RepeatedField<ItemReward> repeatedField7 = levelReward_;
									RepeatedField<ItemReward> repeatedField8 = other.levelReward_;
									if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DED")]
		[Cpp2IlInjected.Address(RVA = "0x34394B0", Offset = "0x3437EB0", VA = "0x1834394B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0068
			if (level_ != 0)
			{
			}
			if (xP_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)tier1Reward_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)tier2Reward_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)tier3Reward_).GetHashCode();
			RepeatedField<ItemReward> repeatedField = levelReward_;
			hashCode = hashCode3;
			int hashCode4 = ((RepeatedField<T>)(object)repeatedField).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			hashCode2 = hashCode4;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DEE")]
		[Cpp2IlInjected.Address(RVA = "0x3439B10", Offset = "0x3438510", VA = "0x183439B10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DEF")]
		[Cpp2IlInjected.Address(RVA = "0x3439B70", Offset = "0x3438570", VA = "0x183439B70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a4
			if (level_ != 0)
			{
				int value = level_;
				output.WriteInt32(value);
			}
			if (xP_ != 0)
			{
				int value2 = xP_;
				output.WriteInt32(value2);
			}
			RepeatedField<ItemReward> repeatedField = tier1Reward_;
			FieldCodec<ItemReward> repeated_tier1Reward_codec = _repeated_tier1Reward_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tier1Reward_codec);
			RepeatedField<ItemReward> repeatedField2 = tier2Reward_;
			FieldCodec<ItemReward> repeated_tier2Reward_codec = _repeated_tier2Reward_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_tier2Reward_codec);
			RepeatedField<ItemReward> repeatedField3 = tier3Reward_;
			FieldCodec<ItemReward> repeated_tier3Reward_codec = _repeated_tier3Reward_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_tier3Reward_codec);
			RepeatedField<ItemReward> repeatedField4 = levelReward_;
			FieldCodec<ItemReward> repeated_levelReward_codec = _repeated_levelReward_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_levelReward_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF0")]
		[Cpp2IlInjected.Address(RVA = "0x3438E50", Offset = "0x3437850", VA = "0x183438E50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00b7
			int num = level_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = xP_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			RepeatedField<ItemReward> repeatedField = tier1Reward_;
			FieldCodec<ItemReward> repeated_tier1Reward_codec = _repeated_tier1Reward_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tier1Reward_codec);
			RepeatedField<ItemReward> repeatedField2 = tier2Reward_;
			FieldCodec<ItemReward> repeated_tier2Reward_codec = _repeated_tier2Reward_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_tier2Reward_codec);
			RepeatedField<ItemReward> repeatedField3 = tier3Reward_;
			FieldCodec<ItemReward> repeated_tier3Reward_codec = _repeated_tier3Reward_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_tier3Reward_codec);
			RepeatedField<ItemReward> repeatedField4 = levelReward_;
			FieldCodec<ItemReward> repeated_levelReward_codec = _repeated_levelReward_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_levelReward_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num2 += num10;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF1")]
		[Cpp2IlInjected.Address(RVA = "0x34395C0", Offset = "0x3437FC0", VA = "0x1834395C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipLevel other)
		{
			//Discarded unreachable code: IL_00ab
			if (other != null)
			{
				int num = other.level_;
				if (num != 0)
				{
					level_ = num;
				}
				int num2 = other.xP_;
				if (num2 != 0)
				{
					xP_ = num2;
				}
				RepeatedField<ItemReward> repeatedField = tier1Reward_;
				RepeatedField<ItemReward> repeatedField2 = other.tier1Reward_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<ItemReward> repeatedField3 = tier2Reward_;
				RepeatedField<ItemReward> repeatedField4 = other.tier2Reward_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<ItemReward> repeatedField5 = tier3Reward_;
				RepeatedField<ItemReward> repeatedField6 = other.tier3Reward_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				RepeatedField<ItemReward> repeatedField7 = levelReward_;
				RepeatedField<ItemReward> repeatedField8 = other.levelReward_;
				((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF2")]
		[Cpp2IlInjected.Address(RVA = "0x34396B0", Offset = "0x34380B0", VA = "0x1834396B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00cd
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					RepeatedField<ItemReward> repeatedField = tier2Reward_;
					FieldCodec<ItemReward> repeated_tier2Reward_codec = _repeated_tier2Reward_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tier2Reward_codec);
				}
				if (num == 42)
				{
					RepeatedField<ItemReward> repeatedField2 = tier3Reward_;
					FieldCodec<ItemReward> repeated_tier3Reward_codec = _repeated_tier3Reward_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tier3Reward_codec);
				}
				if (num != 50)
				{
					goto IL_00b6;
				}
				RepeatedField<ItemReward> repeatedField3 = levelReward_;
				FieldCodec<ItemReward> repeated_levelReward_codec = _repeated_levelReward_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_levelReward_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (level_ = input.ReadInt32());
			}
			int num3 = default(int);
			if (num2 == 16)
			{
				num3 = (xP_ = input.ReadInt32());
			}
			if (num3 == 26)
			{
				RepeatedField<ItemReward> repeatedField4 = tier1Reward_;
				FieldCodec<ItemReward> repeated_tier1Reward_codec = _repeated_tier1Reward_codec;
				((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tier1Reward_codec);
			}
			goto IL_00b6;
			IL_00b6:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF3")]
		[Cpp2IlInjected.Address(RVA = "0x3439390", Offset = "0x3437D90", VA = "0x183439390", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = level_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF4")]
		[Cpp2IlInjected.Address(RVA = "0x34398F0", Offset = "0x34382F0", VA = "0x1834398F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				level_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF5")]
		[Cpp2IlInjected.Address(RVA = "0x3439000", Offset = "0x3437A00", VA = "0x183439000", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				level_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF6")]
		[Cpp2IlInjected.Address(RVA = "0x3439D10", Offset = "0x3438710", VA = "0x183439D10")]
		static FriendshipLevel()
		{
			Func<FriendshipLevel> func = default(Func<FriendshipLevel>);
			_parser = (MessageParser<FriendshipLevel>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ItemReward> parser = ItemReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<FriendshipLevel>)(object)FieldCodec.ForMessage<ItemReward>(num, (MessageParser<>)(object)parser);
			MessageParser<ItemReward> parser2 = ItemReward._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<FriendshipLevel>)(object)FieldCodec.ForMessage<ItemReward>(num2, (MessageParser<>)(object)parser2);
			MessageParser<ItemReward> parser3 = ItemReward._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<FriendshipLevel>)(object)FieldCodec.ForMessage<ItemReward>(num3, (MessageParser<>)(object)parser3);
			MessageParser<ItemReward> parser4 = ItemReward._parser;
			uint num4 = default(uint);
			_parser = (MessageParser<FriendshipLevel>)(object)FieldCodec.ForMessage<ItemReward>(num4, (MessageParser<>)(object)parser4);
			/*Error: Unexpected end of block*/;
		}
	}
}
