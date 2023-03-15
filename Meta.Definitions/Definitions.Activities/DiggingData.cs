using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000877")]
	public sealed class DiggingData : IVillageAreaLootTableUser, IMessage<DiggingData>, IMessage, IEquatable<DiggingData>, IDeepCloneable<DiggingData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40029CF")]
		private static readonly MessageParser<DiggingData> _parser = (MessageParser<DiggingData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new DiggingData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40029D0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40029D1")]
		public const int ProbabilityToDropRewardFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029D2")]
		private int probabilityToDropReward_;

		[Cpp2IlInjected.Token(Token = "0x40029D3")]
		public const int RewardPerVillageAreaFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40029D4")]
		private static readonly MapField<int, int>.Codec _map_rewardPerVillageArea_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40029D5")]
		private readonly MapField<int, int> rewardPerVillageArea_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40029D6")]
		public const int SamePositionCooldownFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40029D7")]
		private Duration samePositionCooldown_;

		[Cpp2IlInjected.Token(Token = "0x40029D8")]
		public const int RewardMinDistanceFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40029D9")]
		private int rewardMinDistance_;

		[Cpp2IlInjected.Token(Token = "0x40029DA")]
		public const int RewardMaxDistanceFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40029DB")]
		private int rewardMaxDistance_;

		[Cpp2IlInjected.Token(Token = "0x40029DC")]
		public const int RewardInFrontOfDistanceFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40029DD")]
		private int rewardInFrontOfDistance_;

		[Cpp2IlInjected.Token(Token = "0x40029DE")]
		public const int NumberOfDrawsWithBuffFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40029DF")]
		private int numberOfDrawsWithBuff_;

		[Cpp2IlInjected.Token(Token = "0x40029E0")]
		public const int NumberOfDrawsWithoutBuffFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40029E1")]
		private int numberOfDrawsWithoutBuff_;

		[Cpp2IlInjected.Token(Token = "0x170017D1")]
		[DebuggerNonUserCode]
		public static MessageParser<DiggingData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005EA6")]
			[Cpp2IlInjected.Address(RVA = "0x2C3F2F0", Offset = "0x2C3DCF0", VA = "0x182C3F2F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005EA7")]
			[Cpp2IlInjected.Address(RVA = "0x2C3F220", Offset = "0x2C3DC20", VA = "0x182C3F220")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005EA8")]
			[Cpp2IlInjected.Address(RVA = "0x2C3F350", Offset = "0x2C3DD50", VA = "0x182C3F350", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D4")]
		[DebuggerNonUserCode]
		public int ProbabilityToDropReward
		{
			[Cpp2IlInjected.Token(Token = "0x6005EAC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return probabilityToDropReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005EAD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				probabilityToDropReward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D5")]
		[DebuggerNonUserCode]
		public MapField<int, int> RewardPerVillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6005EAE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return rewardPerVillageArea_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D6")]
		[DebuggerNonUserCode]
		public Duration SamePositionCooldown
		{
			[Cpp2IlInjected.Token(Token = "0x6005EAF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return samePositionCooldown_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005EB0")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				samePositionCooldown_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D7")]
		[DebuggerNonUserCode]
		public int RewardMinDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6005EB1")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return rewardMinDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005EB2")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				rewardMinDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D8")]
		[DebuggerNonUserCode]
		public int RewardMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6005EB3")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return rewardMaxDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005EB4")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				rewardMaxDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D9")]
		[DebuggerNonUserCode]
		public int RewardInFrontOfDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6005EB5")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return rewardInFrontOfDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005EB6")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				rewardInFrontOfDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DA")]
		[DebuggerNonUserCode]
		public int NumberOfDrawsWithBuff
		{
			[Cpp2IlInjected.Token(Token = "0x6005EB7")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return numberOfDrawsWithBuff_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005EB8")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				numberOfDrawsWithBuff_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DB")]
		[DebuggerNonUserCode]
		public int NumberOfDrawsWithoutBuff
		{
			[Cpp2IlInjected.Token(Token = "0x6005EB9")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return numberOfDrawsWithoutBuff_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005EBA")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				numberOfDrawsWithoutBuff_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005EA5")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E580", Offset = "0x2C3CF80", VA = "0x182C3E580", Slot = "4")]
		public IEnumerable<(VillageAreaType, Item)> GetVillageAreaLootTables()
		{
			MapField<int, int> mapField = rewardPerVillageArea_;
			Func<KeyValuePair<int, int>, (VillageAreaType, Item)> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			return (IEnumerable<(VillageAreaType, Item)>)Enumerable.Select<KeyValuePair<int, int>, (VillageAreaType, Item)>((IEnumerable<>)(object)mapField, (Func<, >)(object)_003C_003E9__0_);
		}

		[Cpp2IlInjected.Token(Token = "0x6005EA9")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F050", Offset = "0x2C3DA50", VA = "0x182C3F050")]
		[DebuggerNonUserCode]
		public DiggingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005EAA")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F0D0", Offset = "0x2C3DAD0", VA = "0x182C3F0D0")]
		[DebuggerNonUserCode]
		public DiggingData(DiggingData other)
		{
			//IL_0052: Expected O, but got I4
			int num = (probabilityToDropReward_ = other.probabilityToDropReward_);
			MapField<int, int> mapField = (rewardPerVillageArea_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.rewardPerVillageArea_).Clone());
			Duration duration = other.samePositionCooldown_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			int num2 = 0;
			samePositionCooldown_ = (Duration)num2;
			int num3 = (rewardMinDistance_ = other.rewardMinDistance_);
			int num4 = (rewardMaxDistance_ = other.rewardMaxDistance_);
			int num5 = (rewardInFrontOfDistance_ = other.rewardInFrontOfDistance_);
			int num6 = (numberOfDrawsWithBuff_ = other.numberOfDrawsWithBuff_);
			int num7 = (numberOfDrawsWithoutBuff_ = other.numberOfDrawsWithoutBuff_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005EAB")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DFA0", Offset = "0x2C3C9A0", VA = "0x182C3DFA0", Slot = "11")]
		[DebuggerNonUserCode]
		public DiggingData Clone()
		{
			//Discarded unreachable code: IL_00bc
			//IL_0055: Expected O, but got I4
			DiggingData diggingData = new DiggingData();
			MapField<int, int> mapField = (diggingData.rewardPerVillageArea_ = (MapField<int, int>)(object)new MapField<TKey, TValue>());
			int num = (diggingData.probabilityToDropReward_ = probabilityToDropReward_);
			MapField<int, int> mapField2 = (diggingData.rewardPerVillageArea_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)rewardPerVillageArea_).Clone());
			Duration duration = samePositionCooldown_;
			if (duration != null)
			{
				Duration duration2 = duration.Clone();
			}
			int num2 = 0;
			diggingData.samePositionCooldown_ = (Duration)num2;
			int num3 = (diggingData.rewardMinDistance_ = rewardMinDistance_);
			int num4 = (diggingData.rewardMaxDistance_ = rewardMaxDistance_);
			int num5 = (diggingData.rewardInFrontOfDistance_ = rewardInFrontOfDistance_);
			int num6 = (diggingData.numberOfDrawsWithBuff_ = numberOfDrawsWithBuff_);
			int num7 = (diggingData.numberOfDrawsWithoutBuff_ = numberOfDrawsWithoutBuff_);
			UnknownFieldSet unknownFieldSet = (diggingData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return diggingData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EBB")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E210", Offset = "0x2C3CC10", VA = "0x182C3E210", Slot = "0")]
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
				if ((IntPtr)probabilityToDropReward_ == (IntPtr)typeof(DiggingData).TypeHandle)
				{
					MapField<int, int> mapField = rewardPerVillageArea_;
					bool flag = default(bool);
					if (flag)
					{
						bool flag2 = object.Equals(samePositionCooldown_, other);
						if (flag2 && rewardMinDistance_ == (flag2 ? 1 : 0) && rewardMaxDistance_ == (flag2 ? 1 : 0) && rewardInFrontOfDistance_ == (flag2 ? 1 : 0) && numberOfDrawsWithBuff_ == (flag2 ? 1 : 0) && numberOfDrawsWithoutBuff_ == (flag2 ? 1 : 0))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005EBC")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E120", Offset = "0x2C3CB20", VA = "0x182C3E120", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(DiggingData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.probabilityToDropReward_;
				if (probabilityToDropReward_ == num)
				{
					MapField<int, int> mapField = rewardPerVillageArea_;
					MapField<int, int> mapField2 = other.rewardPerVillageArea_;
					if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
					{
						Duration objB = other.samePositionCooldown_;
						if (object.Equals(samePositionCooldown_, objB))
						{
							int num2 = other.rewardMinDistance_;
							if (rewardMinDistance_ == num2)
							{
								int num3 = other.rewardMaxDistance_;
								if (rewardMaxDistance_ == num3)
								{
									int num4 = other.rewardInFrontOfDistance_;
									if (rewardInFrontOfDistance_ == num4)
									{
										int num5 = other.numberOfDrawsWithBuff_;
										if (numberOfDrawsWithBuff_ == num5)
										{
											int num6 = other.numberOfDrawsWithoutBuff_;
											if (numberOfDrawsWithoutBuff_ == num6)
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
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005EBD")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E460", Offset = "0x2C3CE60", VA = "0x182C3E460", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006c
			if (probabilityToDropReward_ != 0)
			{
			}
			int hashCode = ((MapField<TKey, TValue>)(object)rewardPerVillageArea_).GetHashCode();
			Duration duration = samePositionCooldown_;
			if (duration != null)
			{
				int hashCode2 = duration.GetHashCode();
			}
			if (rewardMinDistance_ != 0)
			{
			}
			if (rewardMaxDistance_ != 0)
			{
			}
			if (rewardInFrontOfDistance_ != 0)
			{
			}
			if (numberOfDrawsWithBuff_ != 0)
			{
			}
			if (numberOfDrawsWithoutBuff_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EBE")]
		[Cpp2IlInjected.Address(RVA = "0x2C3EC70", Offset = "0x2C3D670", VA = "0x182C3EC70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005EBF")]
		[Cpp2IlInjected.Address(RVA = "0x2C3ECD0", Offset = "0x2C3D6D0", VA = "0x182C3ECD0", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d8
			if (probabilityToDropReward_ != 0)
			{
				int value = probabilityToDropReward_;
				output.WriteInt32(value);
			}
			MapField<int, int> mapField = rewardPerVillageArea_;
			MapField<int, int>.Codec map_rewardPerVillageArea_codec = _map_rewardPerVillageArea_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_rewardPerVillageArea_codec);
			if ((long)samePositionCooldown_ != 0)
			{
				Duration value2 = samePositionCooldown_;
				output.WriteMessage(value2);
			}
			if (rewardMinDistance_ != 0)
			{
				int value3 = rewardMinDistance_;
				output.WriteInt32(value3);
			}
			if (rewardMaxDistance_ != 0)
			{
				int value4 = rewardMaxDistance_;
				output.WriteInt32(value4);
			}
			if (rewardInFrontOfDistance_ != 0)
			{
				int value5 = rewardInFrontOfDistance_;
				output.WriteInt32(value5);
			}
			if (numberOfDrawsWithBuff_ != 0)
			{
				int value6 = numberOfDrawsWithBuff_;
				output.WriteInt32(value6);
			}
			if (numberOfDrawsWithoutBuff_ != 0)
			{
				int value7 = numberOfDrawsWithoutBuff_;
				output.WriteInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005EC0")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DC40", Offset = "0x2C3C640", VA = "0x182C3DC40", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0114
			int num = probabilityToDropReward_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			MapField<int, int> mapField = rewardPerVillageArea_;
			MapField<int, int>.Codec map_rewardPerVillageArea_codec = _map_rewardPerVillageArea_codec;
			int num4 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_rewardPerVillageArea_codec);
			Duration duration = samePositionCooldown_;
			num2 += num4;
			if (duration != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(duration);
				num5++;
				num2 += num5;
			}
			int num6 = rewardMinDistance_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			int num8 = rewardMaxDistance_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			int num10 = rewardInFrontOfDistance_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = numberOfDrawsWithBuff_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			int num14 = numberOfDrawsWithoutBuff_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EC1")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E8A0", Offset = "0x2C3D2A0", VA = "0x182C3E8A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(DiggingData other)
		{
			//Discarded unreachable code: IL_00f1
			if (other == null)
			{
				return;
			}
			int num = other.probabilityToDropReward_;
			if (num != 0)
			{
				probabilityToDropReward_ = num;
			}
			MapField<int, int> mapField = rewardPerVillageArea_;
			MapField<int, int> mapField2 = other.rewardPerVillageArea_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			if ((long)other.samePositionCooldown_ != 0)
			{
				Duration duration2 = default(Duration);
				if (samePositionCooldown_ == null)
				{
					Duration duration = (samePositionCooldown_ = new Duration());
					duration2 = samePositionCooldown_;
				}
				Duration other2 = other.samePositionCooldown_;
				duration2.MergeFrom(other2);
			}
			int num2 = other.rewardMinDistance_;
			if (num2 != 0)
			{
				rewardMinDistance_ = num2;
			}
			int num3 = other.rewardMaxDistance_;
			if (num3 != 0)
			{
				rewardMaxDistance_ = num3;
			}
			int num4 = other.rewardInFrontOfDistance_;
			if (num4 != 0)
			{
				rewardInFrontOfDistance_ = num4;
			}
			int num5 = other.numberOfDrawsWithBuff_;
			if (num5 != 0)
			{
				numberOfDrawsWithBuff_ = num5;
			}
			int num6 = other.numberOfDrawsWithoutBuff_;
			if (num6 != 0)
			{
				numberOfDrawsWithoutBuff_ = num6;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005EC2")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E6B0", Offset = "0x2C3D0B0", VA = "0x182C3E6B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0109
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 32)
			{
				if ((int)num > 48)
				{
					if (num == 56)
					{
						int num2 = (numberOfDrawsWithBuff_ = input.ReadInt32());
					}
					if (num != 64)
					{
						goto IL_00f2;
					}
					int num3 = (numberOfDrawsWithoutBuff_ = input.ReadInt32());
				}
				int num4 = default(int);
				if (num == 40)
				{
					num4 = (rewardMaxDistance_ = input.ReadInt32());
				}
				if (num4 != 48)
				{
					goto IL_00f2;
				}
				int num5 = (rewardInFrontOfDistance_ = input.ReadInt32());
			}
			int num6 = default(int);
			if ((int)num > 18)
			{
				Duration duration = default(Duration);
				if (num == 26)
				{
					Duration builder = default(Duration);
					if (samePositionCooldown_ == null)
					{
						duration = (samePositionCooldown_ = new Duration());
						builder = samePositionCooldown_;
					}
					input.ReadMessage(builder);
				}
				if ((long)duration != 32)
				{
					goto IL_00f2;
				}
				num6 = (rewardMinDistance_ = input.ReadInt32());
			}
			int num7 = default(int);
			if (num6 == 8)
			{
				num7 = (probabilityToDropReward_ = input.ReadInt32());
			}
			if (num7 == 18)
			{
				MapField<int, int> mapField = rewardPerVillageArea_;
				MapField<int, int>.Codec map_rewardPerVillageArea_codec = _map_rewardPerVillageArea_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_rewardPerVillageArea_codec);
			}
			goto IL_00f2;
			IL_00f2:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005EC3")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E340", Offset = "0x2C3CD40", VA = "0x182C3E340", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				int num = probabilityToDropReward_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EC4")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E9D0", Offset = "0x2C3D3D0", VA = "0x182C3E9D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_001d, IL_0025, IL_002d, IL_0035, IL_003d
			//IL_000d: Expected I4, but got O
			//IL_0015: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				object obj = default(object);
				probabilityToDropReward_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005EC5")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DE70", Offset = "0x2C3C870", VA = "0x182C3DE70", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0015
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 7)
			{
				probabilityToDropReward_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005EC6")]
		[Cpp2IlInjected.Address(RVA = "0x2C3EEB0", Offset = "0x2C3D8B0", VA = "0x182C3EEB0")]
		static DiggingData()
		{
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<DiggingData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			/*Error: Unexpected end of block*/;
		}
	}
}
