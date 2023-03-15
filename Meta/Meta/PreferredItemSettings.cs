using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000830")]
	public sealed class PreferredItemSettings : IMessage<PreferredItemSettings>, IMessage, IEquatable<PreferredItemSettings>, IDeepCloneable<PreferredItemSettings>, IMessageFieldAccessor, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x2000831")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000832")]
			public sealed class ProfileOverride : IMessage<ProfileOverride>, IMessage, IEquatable<ProfileOverride>, IDeepCloneable<ProfileOverride>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40020B3")]
				private static readonly MessageParser<ProfileOverride> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40020B4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40020B5")]
				public const int ConditionsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40020B6")]
				private ConditionsList conditions_;

				[Cpp2IlInjected.Token(Token = "0x40020B7")]
				public const int PreferredItemsProfileItemIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40020B8")]
				private int preferredItemsProfileItemID_;

				[Cpp2IlInjected.Token(Token = "0x17000B33")]
				[DebuggerNonUserCode]
				public static MessageParser<ProfileOverride> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600446E")]
					[Cpp2IlInjected.Address(RVA = "0x1DBEF10", Offset = "0x1DBD910", VA = "0x181DBEF10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B34")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600446F")]
					[Cpp2IlInjected.Address(RVA = "0x1DBEE90", Offset = "0x1DBD890", VA = "0x181DBEE90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B35")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004470")]
					[Cpp2IlInjected.Address(RVA = "0x1DBEFD0", Offset = "0x1DBD9D0", VA = "0x181DBEFD0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B36")]
				[DebuggerNonUserCode]
				public ConditionsList Conditions
				{
					[Cpp2IlInjected.Token(Token = "0x6004475")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004476")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B37")]
				[DebuggerNonUserCode]
				public int PreferredItemsProfileItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6004477")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004478")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B38")]
				public Item PreferredItemsProfileItem
				{
					[Cpp2IlInjected.Token(Token = "0x6004484")]
					[Cpp2IlInjected.Address(RVA = "0x1DBEF70", Offset = "0x1DBD970", VA = "0x181DBEF70")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004471")]
				[Cpp2IlInjected.Address(RVA = "0x1DBEE20", Offset = "0x1DBD820", VA = "0x181DBEE20")]
				[DebuggerNonUserCode]
				public ProfileOverride()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004472")]
				[Cpp2IlInjected.Address(RVA = "0x1DBEAB0", Offset = "0x1DBD4B0", VA = "0x181DBEAB0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004473")]
				[Cpp2IlInjected.Address(RVA = "0x1DBED50", Offset = "0x1DBD750", VA = "0x181DBED50")]
				[DebuggerNonUserCode]
				public ProfileOverride(ProfileOverride other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004474")]
				[Cpp2IlInjected.Address(RVA = "0x1DBE660", Offset = "0x1DBD060", VA = "0x181DBE660", Slot = "10")]
				[DebuggerNonUserCode]
				public ProfileOverride Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004479")]
				[Cpp2IlInjected.Address(RVA = "0x1DBE760", Offset = "0x1DBD160", VA = "0x181DBE760", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600447A")]
				[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ProfileOverride other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600447B")]
				[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600447C")]
				[Cpp2IlInjected.Address(RVA = "0x1DBEBE0", Offset = "0x1DBD5E0", VA = "0x181DBEBE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600447D")]
				[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600447E")]
				[Cpp2IlInjected.Address(RVA = "0x1DBE590", Offset = "0x1DBCF90", VA = "0x181DBE590", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600447F")]
				[Cpp2IlInjected.Address(RVA = "0x1DBE9D0", Offset = "0x1DBD3D0", VA = "0x181DBE9D0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ProfileOverride other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004480")]
				[Cpp2IlInjected.Address(RVA = "0x1DBE8E0", Offset = "0x1DBD2E0", VA = "0x181DBE8E0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004481")]
				[Cpp2IlInjected.Address(RVA = "0x1DBE810", Offset = "0x1DBD210", VA = "0x181DBE810", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004482")]
				[Cpp2IlInjected.Address(RVA = "0x1DBEB10", Offset = "0x1DBD510", VA = "0x181DBEB10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004483")]
				[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40020A8")]
		private static readonly MessageParser<PreferredItemSettings> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40020A9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40020AA")]
		public const int AreasToDifficultyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40020AB")]
		private static readonly FieldCodec<PreferredDifficultyToArea> _repeated_areasToDifficulty_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40020AC")]
		private readonly RepeatedField<PreferredDifficultyToArea> areasToDifficulty_ = (RepeatedField<PreferredDifficultyToArea>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40020AD")]
		public const int FirstDailyGiftFriendshipBonusFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40020AE")]
		private int firstDailyGiftFriendshipBonus_;

		[Cpp2IlInjected.Token(Token = "0x40020AF")]
		public const int ProfileOverridesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40020B0")]
		private static readonly FieldCodec<Types.ProfileOverride> _repeated_profileOverrides_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40020B1")]
		private readonly RepeatedField<Types.ProfileOverride> profileOverrides_ = (RepeatedField<Types.ProfileOverride>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40020B2")]
		private Dictionary<VillageAreaType, int> orderedAreas;

		[Cpp2IlInjected.Token(Token = "0x17000B2D")]
		[DebuggerNonUserCode]
		public static MessageParser<PreferredItemSettings> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004456")]
			[Cpp2IlInjected.Address(RVA = "0x7C3FD0", Offset = "0x7C29D0", VA = "0x1807C3FD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004457")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F00", Offset = "0x7C2900", VA = "0x1807C3F00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004458")]
			[Cpp2IlInjected.Address(RVA = "0x7C4030", Offset = "0x7C2A30", VA = "0x1807C4030", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B30")]
		[DebuggerNonUserCode]
		public RepeatedField<PreferredDifficultyToArea> AreasToDifficulty
		{
			[Cpp2IlInjected.Token(Token = "0x600445C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return areasToDifficulty_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B31")]
		[DebuggerNonUserCode]
		public int FirstDailyGiftFriendshipBonus
		{
			[Cpp2IlInjected.Token(Token = "0x600445D")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return firstDailyGiftFriendshipBonus_;
			}
			[Cpp2IlInjected.Token(Token = "0x600445E")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				firstDailyGiftFriendshipBonus_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B32")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ProfileOverride> ProfileOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x600445F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return profileOverrides_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004459")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E40", Offset = "0x7C2840", VA = "0x1807C3E40")]
		[DebuggerNonUserCode]
		public PreferredItemSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600445A")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB0", Offset = "0x7C26B0", VA = "0x1807C3CB0")]
		[DebuggerNonUserCode]
		public PreferredItemSettings(PreferredItemSettings other)
		{
			RepeatedField<PreferredDifficultyToArea> repeatedField = (areasToDifficulty_ = (RepeatedField<PreferredDifficultyToArea>)(object)((RepeatedField<T>)(object)other.areasToDifficulty_).Clone());
			int num = (firstDailyGiftFriendshipBonus_ = other.firstDailyGiftFriendshipBonus_);
			RepeatedField<Types.ProfileOverride> repeatedField2 = (profileOverrides_ = (RepeatedField<Types.ProfileOverride>)(object)((RepeatedField<T>)(object)other.profileOverrides_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600445B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C10", Offset = "0x7C1610", VA = "0x1807C2C10", Slot = "10")]
		[DebuggerNonUserCode]
		public PreferredItemSettings Clone()
		{
			//Discarded unreachable code: IL_006f
			PreferredItemSettings preferredItemSettings = new PreferredItemSettings();
			RepeatedField<PreferredDifficultyToArea> repeatedField = (preferredItemSettings.areasToDifficulty_ = (RepeatedField<PreferredDifficultyToArea>)(object)new RepeatedField<T>());
			RepeatedField<Types.ProfileOverride> repeatedField2 = (preferredItemSettings.profileOverrides_ = (RepeatedField<Types.ProfileOverride>)(object)new RepeatedField<T>());
			RepeatedField<PreferredDifficultyToArea> repeatedField3 = (preferredItemSettings.areasToDifficulty_ = (RepeatedField<PreferredDifficultyToArea>)(object)((RepeatedField<T>)(object)areasToDifficulty_).Clone());
			int num = (preferredItemSettings.firstDailyGiftFriendshipBonus_ = firstDailyGiftFriendshipBonus_);
			RepeatedField<Types.ProfileOverride> repeatedField4 = (preferredItemSettings.profileOverrides_ = (RepeatedField<Types.ProfileOverride>)(object)((RepeatedField<T>)(object)profileOverrides_).Clone());
			UnknownFieldSet unknownFieldSet = (preferredItemSettings._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return preferredItemSettings;
		}

		[Cpp2IlInjected.Token(Token = "0x6004460")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FA0", Offset = "0x7C19A0", VA = "0x1807C2FA0", Slot = "0")]
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
				RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
				bool flag = default(bool);
				if (flag && firstDailyGiftFriendshipBonus_ == (flag ? 1 : 0))
				{
					RepeatedField<Types.ProfileOverride> repeatedField2 = profileOverrides_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004461")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EE0", Offset = "0x7C18E0", VA = "0x1807C2EE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PreferredItemSettings other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
				RepeatedField<PreferredDifficultyToArea> repeatedField2 = other.areasToDifficulty_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.firstDailyGiftFriendshipBonus_;
					if (firstDailyGiftFriendshipBonus_ == num)
					{
						RepeatedField<Types.ProfileOverride> repeatedField3 = profileOverrides_;
						RepeatedField<Types.ProfileOverride> repeatedField4 = other.profileOverrides_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004462")]
		[Cpp2IlInjected.Address(RVA = "0x7C3190", Offset = "0x7C1B90", VA = "0x1807C3190", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003a
			int hashCode = ((RepeatedField<T>)(object)areasToDifficulty_).GetHashCode();
			if (firstDailyGiftFriendshipBonus_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)profileOverrides_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004463")]
		[Cpp2IlInjected.Address(RVA = "0x7C3870", Offset = "0x7C2270", VA = "0x1807C3870", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004464")]
		[Cpp2IlInjected.Address(RVA = "0x7C38D0", Offset = "0x7C22D0", VA = "0x1807C38D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
			FieldCodec<PreferredDifficultyToArea> repeated_areasToDifficulty_codec = _repeated_areasToDifficulty_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_areasToDifficulty_codec);
			if (firstDailyGiftFriendshipBonus_ != 0)
			{
				int value = firstDailyGiftFriendshipBonus_;
				output.WriteInt32(value);
			}
			RepeatedField<Types.ProfileOverride> repeatedField2 = profileOverrides_;
			FieldCodec<Types.ProfileOverride> repeated_profileOverrides_codec = _repeated_profileOverrides_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_profileOverrides_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004465")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A40", Offset = "0x7C1440", VA = "0x1807C2A40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0073
			RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
			FieldCodec<PreferredDifficultyToArea> repeated_areasToDifficulty_codec = _repeated_areasToDifficulty_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_areasToDifficulty_codec);
			int num2 = firstDailyGiftFriendshipBonus_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			RepeatedField<Types.ProfileOverride> repeatedField2 = profileOverrides_;
			FieldCodec<Types.ProfileOverride> repeated_profileOverrides_codec = _repeated_profileOverrides_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_profileOverrides_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004466")]
		[Cpp2IlInjected.Address(RVA = "0x7C3520", Offset = "0x7C1F20", VA = "0x1807C3520", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PreferredItemSettings other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
				RepeatedField<PreferredDifficultyToArea> repeatedField2 = other.areasToDifficulty_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.firstDailyGiftFriendshipBonus_;
				if (num != 0)
				{
					firstDailyGiftFriendshipBonus_ = num;
				}
				RepeatedField<Types.ProfileOverride> repeatedField3 = profileOverrides_;
				RepeatedField<Types.ProfileOverride> repeatedField4 = other.profileOverrides_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004467")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C1FD0", VA = "0x1807C35D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0070
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
					FieldCodec<PreferredDifficultyToArea> repeated_areasToDifficulty_codec = _repeated_areasToDifficulty_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_areasToDifficulty_codec);
				}
				int num2 = default(int);
				if (num == 16)
				{
					num2 = (firstDailyGiftFriendshipBonus_ = input.ReadInt32());
				}
				if (num2 == 26)
				{
					RepeatedField<Types.ProfileOverride> repeatedField2 = profileOverrides_;
					FieldCodec<Types.ProfileOverride> repeated_profileOverrides_codec = _repeated_profileOverrides_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_profileOverrides_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004468")]
		[Cpp2IlInjected.Address(RVA = "0x7C30B0", Offset = "0x7C1AB0", VA = "0x1807C30B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					RepeatedField<Types.ProfileOverride> repeatedField = profileOverrides_;
				}
				int num2 = firstDailyGiftFriendshipBonus_;
			}
			RepeatedField<PreferredDifficultyToArea> repeatedField2 = areasToDifficulty_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004469")]
		[Cpp2IlInjected.Address(RVA = "0x7C3740", Offset = "0x7C2140", VA = "0x1807C3740", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					object obj = default(object);
					firstDailyGiftFriendshipBonus_ = (int)obj;
					return;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600446A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B90", Offset = "0x7C1590", VA = "0x1807C2B90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num == 1)
				{
					firstDailyGiftFriendshipBonus_ = 0;
				}
				return;
			}
			RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600446B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DC0", Offset = "0x7C17C0", VA = "0x1807C2DC0", Slot = "14")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//Discarded unreachable code: IL_005d
			//IL_0016: Expected I4, but got I8
			//IL_0033: Expected I4, but got I8
			//IL_0053: Expected I4, but got I8
			RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
			PreferredDifficultyToArea preferredDifficultyToArea = new PreferredDifficultyToArea();
			preferredDifficultyToArea.difficulty_ = PreferredItemDifficulty.Low;
			((RepeatedField<T>)(object)repeatedField).Add((T)preferredDifficultyToArea);
			RepeatedField<PreferredDifficultyToArea> repeatedField2 = areasToDifficulty_;
			PreferredDifficultyToArea preferredDifficultyToArea2 = new PreferredDifficultyToArea();
			preferredDifficultyToArea2.difficulty_ = PreferredItemDifficulty.Medium;
			((RepeatedField<T>)(object)repeatedField2).Add((T)preferredDifficultyToArea2);
			RepeatedField<PreferredDifficultyToArea> repeatedField3 = areasToDifficulty_;
			PreferredDifficultyToArea preferredDifficultyToArea3 = new PreferredDifficultyToArea();
			preferredDifficultyToArea3.difficulty_ = PreferredItemDifficulty.High;
			((RepeatedField<T>)(object)repeatedField3).Add((T)preferredDifficultyToArea3);
		}

		[Cpp2IlInjected.Token(Token = "0x600446C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3230", Offset = "0x7C1C30", VA = "0x1807C3230")]
		public Dictionary<VillageAreaType, int> GetOrderedAreas()
		{
			//Discarded unreachable code: IL_0051, IL_0057, IL_005d, IL_0063
			//IL_0039: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if ((IntPtr)orderedAreas != (IntPtr)num2)
				{
					break;
				}
				Dictionary<VillageAreaType, int> dictionary = (orderedAreas = (Dictionary<VillageAreaType, int>)(object)new Dictionary<TKey, TValue>());
				HashSet<VillageAreaType> hashSet = (HashSet<VillageAreaType>)(object)new HashSet<T>();
				RepeatedField<PreferredDifficultyToArea> repeatedField = areasToDifficulty_;
				if (!flag || !flag2)
				{
					break;
				}
				if (((HashSet<T>)(object)hashSet).Add((T)num2))
				{
					Dictionary<VillageAreaType, int> dictionary2 = orderedAreas;
					throw new NullReferenceException();
				}
			}
			return orderedAreas;
		}

		[Cpp2IlInjected.Token(Token = "0x600446D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A20", Offset = "0x7C2420", VA = "0x1807C3A20")]
		static PreferredItemSettings()
		{
			Func<PreferredItemSettings> func = default(Func<PreferredItemSettings>);
			_parser = (MessageParser<PreferredItemSettings>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<PreferredDifficultyToArea> parser = PreferredDifficultyToArea._parser;
			uint num = default(uint);
			_parser = (MessageParser<PreferredItemSettings>)(object)FieldCodec.ForMessage<PreferredDifficultyToArea>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.ProfileOverride> parser2 = Types.ProfileOverride._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<PreferredItemSettings>)(object)FieldCodec.ForMessage<Types.ProfileOverride>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
