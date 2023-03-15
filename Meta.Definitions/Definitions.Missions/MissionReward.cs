using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Character;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000256")]
	public sealed class MissionReward : IMessage<MissionReward>, IMessage, IEquatable<MissionReward>, IDeepCloneable<MissionReward>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000257")]
		public enum FriendshipOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000957")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000958")]
			FriendshipOverride
		}

		[Cpp2IlInjected.Token(Token = "0x400094E")]
		private static readonly MessageParser<MissionReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400094F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000950")]
		public const int FriendshipOverrideFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000951")]
		public const int CurrencyFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000952")]
		private static readonly FieldCodec<MissionCurrencyReward> _repeated_currency_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000953")]
		private readonly RepeatedField<MissionCurrencyReward> currency_ = (RepeatedField<MissionCurrencyReward>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000954")]
		private object friendship_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000955")]
		private FriendshipOneofCase friendshipCase_;

		[Cpp2IlInjected.Token(Token = "0x170004F1")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001648")]
			[Cpp2IlInjected.Address(RVA = "0x29E2DE0", Offset = "0x29E17E0", VA = "0x1829E2DE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001649")]
			[Cpp2IlInjected.Address(RVA = "0x29E2CB0", Offset = "0x29E16B0", VA = "0x1829E2CB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600164A")]
			[Cpp2IlInjected.Address(RVA = "0x29E2E40", Offset = "0x29E1840", VA = "0x1829E2E40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F4")]
		[DebuggerNonUserCode]
		public MissionRewardRange FriendshipOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600164E")]
			[Cpp2IlInjected.Address(RVA = "0x29E2D80", Offset = "0x29E1780", VA = "0x1829E2D80")]
			get
			{
				int num = 0;
				if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					object obj = friendship_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600164F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE120", Offset = "0x7FCB20", VA = "0x1807FE120")]
			set
			{
				friendship_ = value;
				bool flag = (byte)(friendshipCase_ = ((value != null) ? FriendshipOneofCase.FriendshipOverride : FriendshipOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F5")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionCurrencyReward> Currency
		{
			[Cpp2IlInjected.Token(Token = "0x6001650")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return currency_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F6")]
		[DebuggerNonUserCode]
		public FriendshipOneofCase FriendshipCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001651")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return friendshipCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600164B")]
		[Cpp2IlInjected.Address(RVA = "0x29E2C30", Offset = "0x29E1630", VA = "0x1829E2C30")]
		[DebuggerNonUserCode]
		public MissionReward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600164C")]
		[Cpp2IlInjected.Address(RVA = "0x29E2A60", Offset = "0x29E1460", VA = "0x1829E2A60")]
		[DebuggerNonUserCode]
		public MissionReward(MissionReward other)
		{
			//IL_0045: Expected I4, but got O
			//IL_004c: Expected I4, but got O
			RepeatedField<MissionCurrencyReward> repeatedField = (currency_ = (RepeatedField<MissionCurrencyReward>)(object)((RepeatedField<T>)(object)other.currency_).Clone());
			if (other.friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
			{
				if (other.friendship_ == null)
				{
					throw new InvalidCastException();
				}
				MissionRewardRange missionRewardRange = new MissionRewardRange();
				missionRewardRange.min_ = (int)missionRewardRange;
				missionRewardRange.max_ = (int)missionRewardRange;
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				missionRewardRange._unknownFields = unknownFields;
				friendship_ = missionRewardRange;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600164D")]
		[Cpp2IlInjected.Address(RVA = "0x29E19C0", Offset = "0x29E03C0", VA = "0x1829E19C0", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionReward Clone()
		{
			return new MissionReward(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001652")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearFriendship()
		{
			//IL_0010: Expected O, but got I4
			friendship_ = (friendshipCase_ = FriendshipOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001653")]
		[Cpp2IlInjected.Address(RVA = "0x29E1B60", Offset = "0x29E0560", VA = "0x1829E1B60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0 && (IntPtr)num != (IntPtr)this)
			{
				if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					object obj = friendship_;
					if (obj != null && obj == null)
					{
						goto IL_0061;
					}
				}
				if (1L == 0L)
				{
				}
				if ((object)typeof(MissionRewardRange).TypeHandle != null && (object)typeof(MissionRewardRange).TypeHandle == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<MissionCurrencyReward> repeatedField = currency_;
					bool flag2 = default(bool);
					if (flag2 && friendshipCase_ == (flag2 ? FriendshipOneofCase.FriendshipOverride : FriendshipOneofCase.None))
					{
						UnknownFieldSet unknownFields = _unknownFields;
					}
				}
			}
			int num2 = 0;
			goto IL_0061;
			IL_0061:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001654")]
		[Cpp2IlInjected.Address(RVA = "0x29E1A20", Offset = "0x29E0420", VA = "0x1829E1A20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionReward other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					object obj = friendship_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					obj2 = other.friendship_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					RepeatedField<MissionCurrencyReward> repeatedField = currency_;
					RepeatedField<MissionCurrencyReward> repeatedField2 = other.currency_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						FriendshipOneofCase friendshipOneofCase = other.friendshipCase_;
						if (friendshipCase_ == friendshipOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0099;
			IL_0099:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001655")]
		[Cpp2IlInjected.Address(RVA = "0x29E1F60", Offset = "0x29E0960", VA = "0x1829E1F60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0040
			if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
			{
				object obj = friendship_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)currency_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001656")]
		[Cpp2IlInjected.Address(RVA = "0x29E2700", Offset = "0x29E1100", VA = "0x1829E2700", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001657")]
		[Cpp2IlInjected.Address(RVA = "0x29E2760", Offset = "0x29E1160", VA = "0x1829E2760", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0055
			//IL_002a: Expected O, but got I4
			if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
			{
				int num = 0;
				if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					object obj = friendship_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			RepeatedField<MissionCurrencyReward> repeatedField = currency_;
			FieldCodec<MissionCurrencyReward> repeated_currency_codec = _repeated_currency_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_currency_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001658")]
		[Cpp2IlInjected.Address(RVA = "0x29E1790", Offset = "0x29E0190", VA = "0x1829E1790", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0064
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
			{
				if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					object obj = friendship_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			RepeatedField<MissionCurrencyReward> repeatedField = currency_;
			FieldCodec<MissionCurrencyReward> repeated_currency_codec = _repeated_currency_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_currency_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001659")]
		[Cpp2IlInjected.Address(RVA = "0x29E2200", Offset = "0x29E0C00", VA = "0x1829E2200", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionReward other)
		{
			//Discarded unreachable code: IL_00e0
			if (other == null)
			{
				return;
			}
			RepeatedField<MissionCurrencyReward> repeatedField = currency_;
			RepeatedField<MissionCurrencyReward> repeatedField2 = other.currency_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if (other.friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
			{
				FriendshipOneofCase friendshipOneofCase = friendshipCase_;
				int num = 0;
				if (friendshipOneofCase == FriendshipOneofCase.FriendshipOverride)
				{
					object obj = friendship_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(friendshipCase_ = (((friendship_ = new MissionRewardRange()) != null) ? FriendshipOneofCase.FriendshipOverride : FriendshipOneofCase.None)) != 0;
				}
				if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					object obj2 = friendship_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				object obj3 = default(object);
				if (other.friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					obj3 = other.friendship_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj3 != null)
				{
					if ((object)typeof(MissionRewardRange).TypeHandle != null)
					{
					}
					if ((object)typeof(MissionRewardRange).TypeHandle == null)
					{
					}
				}
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600165A")]
		[Cpp2IlInjected.Address(RVA = "0x29E2420", Offset = "0x29E0E20", VA = "0x1829E2420", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0051: Expected I4, but got O
			//IL_005c: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				MissionRewardRange missionRewardRange = new MissionRewardRange();
				if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
				{
					if (friendshipCase_ != FriendshipOneofCase.FriendshipOverride)
					{
					}
					object obj = friendship_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
					if (obj != null)
					{
						if (obj != null)
						{
							missionRewardRange.min_ = (int)obj;
						}
						if (obj != null)
						{
							missionRewardRange.max_ = (int)obj;
						}
						UnknownFieldSet unknownFields = missionRewardRange._unknownFields;
						UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
						missionRewardRange._unknownFields = unknownFields2;
					}
				}
				input.ReadMessage(missionRewardRange);
				friendship_ = missionRewardRange;
				bool flag = (byte)(friendshipCase_ = ((missionRewardRange != null) ? FriendshipOneofCase.FriendshipOverride : FriendshipOneofCase.None)) != 0;
			}
			if (num == 26)
			{
				RepeatedField<MissionCurrencyReward> repeatedField = currency_;
				FieldCodec<MissionCurrencyReward> repeated_currency_codec = _repeated_currency_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_currency_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600165B")]
		[Cpp2IlInjected.Address(RVA = "0x29E1E90", Offset = "0x29E0890", VA = "0x1829E1E90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (friendshipCase_ == FriendshipOneofCase.FriendshipOverride)
			{
				object obj = friendship_;
				if (obj != null)
				{
					if (obj != null)
					{
						goto IL_001c;
					}
					goto IL_0037;
				}
			}
			goto IL_0027;
			IL_001c:
			if (fieldNumber == 3)
			{
				RepeatedField<MissionCurrencyReward> repeatedField = currency_;
			}
			goto IL_0027;
			IL_0037:
			throw new InvalidCastException();
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
		}

		[Cpp2IlInjected.Token(Token = "0x600165C")]
		[Cpp2IlInjected.Address(RVA = "0x29E2620", Offset = "0x29E1020", VA = "0x1829E2620", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					friendship_ = num;
					bool flag = (byte)(friendshipCase_ = ((num != 0) ? FriendshipOneofCase.FriendshipOverride : FriendshipOneofCase.None)) != 0;
					return;
				}
			}
			else
			{
				while (fieldNumber != 3)
				{
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600165D")]
		[Cpp2IlInjected.Address(RVA = "0x29E18D0", Offset = "0x29E02D0", VA = "0x1829E18D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				friendship_ = num;
				friendshipCase_ = (FriendshipOneofCase)num;
				return;
			}
			while (fieldNumber != 3)
			{
			}
			RepeatedField<MissionCurrencyReward> repeatedField = currency_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600165E")]
		[Cpp2IlInjected.Address(RVA = "0x29E2040", Offset = "0x29E0A40", VA = "0x1829E2040", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Friendship"))
			{
				FriendshipOneofCase friendshipOneofCase = friendshipCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600165F")]
		[Cpp2IlInjected.Address(RVA = "0x29E1950", Offset = "0x29E0350", VA = "0x1829E1950", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Friendship"))
			{
				friendship_ = (friendshipCase_ = FriendshipOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001660")]
		[Cpp2IlInjected.Address(RVA = "0x29E20F0", Offset = "0x29E0AF0", VA = "0x1829E20F0")]
		public static XpRewardTable GetXpRewardTable(int missionCount)
		{
			//Discarded unreachable code: IL_000f
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			XpRewardTable result = default(XpRewardTable);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001661")]
		[Cpp2IlInjected.Address(RVA = "0x29E1CE0", Offset = "0x29E06E0", VA = "0x1829E1CE0")]
		public int GetAmount(int missionIndex, int missionCount, int maxLevelXP)
		{
			//Discarded unreachable code: IL_0024
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			XpRewardTable xpRewardTable = default(XpRewardTable);
			if (flag && xpRewardTable != null)
			{
				return ((XpWeight)((RepeatedField<T>)(object)xpRewardTable.weights_)[missionCount]).GetAmount(xpRewardTable, maxLevelXP);
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001662")]
		[Cpp2IlInjected.Address(RVA = "0x29E2890", Offset = "0x29E1290", VA = "0x1829E2890")]
		static MissionReward()
		{
			Func<MissionReward> func = default(Func<MissionReward>);
			_parser = (MessageParser<MissionReward>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<MissionCurrencyReward> parser = MissionCurrencyReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionReward>)(object)FieldCodec.ForMessage<MissionCurrencyReward>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
