using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000841")]
	public sealed class SecretCharacterRecurringConditionData : IMessage<SecretCharacterRecurringConditionData>, IMessage, IEquatable<SecretCharacterRecurringConditionData>, IDeepCloneable<SecretCharacterRecurringConditionData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000842")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000843")]
			public sealed class CountersData : IMessage<CountersData>, IMessage, IEquatable<CountersData>, IDeepCloneable<CountersData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002122")]
				private static readonly MessageParser<CountersData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002123")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002124")]
				public const int CropsHarvestedFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002125")]
				private static readonly MapField<int, int>.Codec _map_cropsHarvested_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002126")]
				private readonly MapField<int, int> cropsHarvested_;

				[Cpp2IlInjected.Token(Token = "0x4002127")]
				public const int FishesFishedFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002128")]
				private int fishesFished_;

				[Cpp2IlInjected.Token(Token = "0x4002129")]
				public const int MealsCookedFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400212A")]
				private int mealsCooked_;

				[Cpp2IlInjected.Token(Token = "0x17000B6A")]
				[DebuggerNonUserCode]
				public static MessageParser<CountersData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600454B")]
					[Cpp2IlInjected.Address(RVA = "0x2004920", Offset = "0x2003320", VA = "0x182004920")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B6B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600454C")]
					[Cpp2IlInjected.Address(RVA = "0x20048A0", Offset = "0x20032A0", VA = "0x1820048A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B6C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600454D")]
					[Cpp2IlInjected.Address(RVA = "0x2004980", Offset = "0x2003380", VA = "0x182004980", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B6D")]
				[DebuggerNonUserCode]
				public MapField<int, int> CropsHarvested
				{
					[Cpp2IlInjected.Token(Token = "0x6004551")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B6E")]
				[DebuggerNonUserCode]
				public int FishesFished
				{
					[Cpp2IlInjected.Token(Token = "0x6004552")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004553")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B6F")]
				[DebuggerNonUserCode]
				public int MealsCooked
				{
					[Cpp2IlInjected.Token(Token = "0x6004554")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004555")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600454E")]
				[Cpp2IlInjected.Address(RVA = "0x2004820", Offset = "0x2003220", VA = "0x182004820")]
				[DebuggerNonUserCode]
				public CountersData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600454F")]
				[Cpp2IlInjected.Address(RVA = "0x2004710", Offset = "0x2003110", VA = "0x182004710")]
				[DebuggerNonUserCode]
				public CountersData(CountersData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004550")]
				[Cpp2IlInjected.Address(RVA = "0x2003D00", Offset = "0x2002700", VA = "0x182003D00", Slot = "10")]
				[DebuggerNonUserCode]
				public CountersData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004556")]
				[Cpp2IlInjected.Address(RVA = "0x2003E30", Offset = "0x2002830", VA = "0x182003E30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004557")]
				[Cpp2IlInjected.Address(RVA = "0x2003F20", Offset = "0x2002920", VA = "0x182003F20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CountersData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004558")]
				[Cpp2IlInjected.Address(RVA = "0x2004090", Offset = "0x2002A90", VA = "0x182004090", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004559")]
				[Cpp2IlInjected.Address(RVA = "0x2004400", Offset = "0x2002E00", VA = "0x182004400", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600455A")]
				[Cpp2IlInjected.Address(RVA = "0x2004460", Offset = "0x2002E60", VA = "0x182004460", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600455B")]
				[Cpp2IlInjected.Address(RVA = "0x2003B40", Offset = "0x2002540", VA = "0x182003B40", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600455C")]
				[Cpp2IlInjected.Address(RVA = "0x2004250", Offset = "0x2002C50", VA = "0x182004250", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CountersData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600455D")]
				[Cpp2IlInjected.Address(RVA = "0x2004130", Offset = "0x2002B30", VA = "0x182004130", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600455E")]
				[Cpp2IlInjected.Address(RVA = "0x2003FC0", Offset = "0x20029C0", VA = "0x182003FC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600455F")]
				[Cpp2IlInjected.Address(RVA = "0x20042E0", Offset = "0x2002CE0", VA = "0x1820042E0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004560")]
				[Cpp2IlInjected.Address(RVA = "0x2003C70", Offset = "0x2002670", VA = "0x182003C70", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400210C")]
		private static readonly MessageParser<SecretCharacterRecurringConditionData> _parser = (MessageParser<SecretCharacterRecurringConditionData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new SecretCharacterRecurringConditionData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400210D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400210E")]
		public const int CountersFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400210F")]
		private Types.CountersData counters_;

		[Cpp2IlInjected.Token(Token = "0x4002110")]
		public const int LastVisitFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002111")]
		private Timestamp lastVisit_;

		[Cpp2IlInjected.Token(Token = "0x4002112")]
		public const int LastCheckFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002113")]
		private Timestamp lastCheck_;

		[Cpp2IlInjected.Token(Token = "0x4002114")]
		public const int SpawnedInLocationFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002115")]
		private SecretCharacterLocationFilter spawnedInLocation_;

		[Cpp2IlInjected.Token(Token = "0x4002116")]
		public const int LastCompletedMissionItemIDFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002117")]
		private int lastCompletedMissionItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002118")]
		public const int RemainingNumberOfMissionsToCompleteFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002119")]
		private int remainingNumberOfMissionsToComplete_;

		[Cpp2IlInjected.Token(Token = "0x400211A")]
		public const int IsDiscoveredFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400211B")]
		private bool isDiscovered_;

		[Cpp2IlInjected.Token(Token = "0x400211C")]
		private const string RandomSeedName = "SecretCharacters";

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400211D")]
		private Character character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400211E")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400211F")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002120")]
		private ProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002121")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x17000B60")]
		[DebuggerNonUserCode]
		public static MessageParser<SecretCharacterRecurringConditionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600451A")]
			[Cpp2IlInjected.Address(RVA = "0x1772240", Offset = "0x1770C40", VA = "0x181772240")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B61")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600451B")]
			[Cpp2IlInjected.Address(RVA = "0x1772170", Offset = "0x1770B70", VA = "0x181772170")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B62")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600451C")]
			[Cpp2IlInjected.Address(RVA = "0x17722A0", Offset = "0x1770CA0", VA = "0x1817722A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B63")]
		[DebuggerNonUserCode]
		public Types.CountersData Counters
		{
			[Cpp2IlInjected.Token(Token = "0x6004521")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return counters_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004522")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				counters_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B64")]
		[DebuggerNonUserCode]
		public Timestamp LastVisit
		{
			[Cpp2IlInjected.Token(Token = "0x6004523")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return lastVisit_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004524")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				lastVisit_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B65")]
		[DebuggerNonUserCode]
		public Timestamp LastCheck
		{
			[Cpp2IlInjected.Token(Token = "0x6004525")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return lastCheck_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004526")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				lastCheck_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B66")]
		[DebuggerNonUserCode]
		public SecretCharacterLocationFilter SpawnedInLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6004527")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return spawnedInLocation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004528")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				spawnedInLocation_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B67")]
		[DebuggerNonUserCode]
		public int LastCompletedMissionItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004529")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return lastCompletedMissionItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600452A")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				lastCompletedMissionItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B68")]
		[DebuggerNonUserCode]
		public int RemainingNumberOfMissionsToComplete
		{
			[Cpp2IlInjected.Token(Token = "0x600452B")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return remainingNumberOfMissionsToComplete_;
			}
			[Cpp2IlInjected.Token(Token = "0x600452C")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				remainingNumberOfMissionsToComplete_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B69")]
		[DebuggerNonUserCode]
		public bool IsDiscovered
		{
			[Cpp2IlInjected.Token(Token = "0x600452D")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return isDiscovered_;
			}
			[Cpp2IlInjected.Token(Token = "0x600452E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				isDiscovered_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600451D")]
		[Cpp2IlInjected.Address(RVA = "0x1772100", Offset = "0x1770B00", VA = "0x181772100")]
		[DebuggerNonUserCode]
		public SecretCharacterRecurringConditionData()
		{
			Types.CountersData countersData = (counters_ = new Types.CountersData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600451E")]
		[Cpp2IlInjected.Address(RVA = "0x1770410", Offset = "0x176EE10", VA = "0x181770410")]
		private void OnConstruction()
		{
			Types.CountersData countersData = (counters_ = new Types.CountersData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600451F")]
		[Cpp2IlInjected.Address(RVA = "0x1771FB0", Offset = "0x17709B0", VA = "0x181771FB0")]
		[DebuggerNonUserCode]
		public SecretCharacterRecurringConditionData(SecretCharacterRecurringConditionData other)
		{
			//IL_002e: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			Types.CountersData countersData = (counters_ = new Types.CountersData());
			Types.CountersData countersData2 = other.counters_;
			int num = 0;
			if (countersData2 != null)
			{
				Types.CountersData countersData3 = countersData2.Clone();
			}
			counters_ = (Types.CountersData)num;
			Timestamp timestamp = other.lastVisit_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			lastVisit_ = (Timestamp)num;
			Timestamp timestamp3 = other.lastCheck_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			lastCheck_ = (Timestamp)num;
			SecretCharacterLocationFilter secretCharacterLocationFilter = other.spawnedInLocation_;
			SecretCharacterLocationFilter secretCharacterLocationFilter2 = default(SecretCharacterLocationFilter);
			if (secretCharacterLocationFilter != null)
			{
				secretCharacterLocationFilter2 = secretCharacterLocationFilter.Clone();
			}
			spawnedInLocation_ = secretCharacterLocationFilter2;
			int num2 = (lastCompletedMissionItemID_ = other.lastCompletedMissionItemID_);
			int num3 = (remainingNumberOfMissionsToComplete_ = other.remainingNumberOfMissionsToComplete_);
			bool flag = (isDiscovered_ = other.isDiscovered_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004520")]
		[Cpp2IlInjected.Address(RVA = "0x176E5F0", Offset = "0x176CFF0", VA = "0x18176E5F0", Slot = "10")]
		[DebuggerNonUserCode]
		public SecretCharacterRecurringConditionData Clone()
		{
			//Discarded unreachable code: IL_00ce
			//IL_002f: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			SecretCharacterRecurringConditionData secretCharacterRecurringConditionData = new SecretCharacterRecurringConditionData();
			Types.CountersData countersData = (secretCharacterRecurringConditionData.counters_ = new Types.CountersData());
			Types.CountersData countersData2 = counters_;
			int num = 0;
			if (countersData2 != null)
			{
				Types.CountersData countersData3 = countersData2.Clone();
			}
			secretCharacterRecurringConditionData.counters_ = (Types.CountersData)num;
			Timestamp timestamp = lastVisit_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			secretCharacterRecurringConditionData.lastVisit_ = (Timestamp)num;
			Timestamp timestamp3 = lastCheck_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			secretCharacterRecurringConditionData.lastCheck_ = (Timestamp)num;
			SecretCharacterLocationFilter secretCharacterLocationFilter = spawnedInLocation_;
			SecretCharacterLocationFilter secretCharacterLocationFilter2 = default(SecretCharacterLocationFilter);
			if (secretCharacterLocationFilter != null)
			{
				secretCharacterLocationFilter2 = secretCharacterLocationFilter.Clone();
			}
			secretCharacterRecurringConditionData.spawnedInLocation_ = secretCharacterLocationFilter2;
			int num2 = (secretCharacterRecurringConditionData.lastCompletedMissionItemID_ = lastCompletedMissionItemID_);
			int num3 = (secretCharacterRecurringConditionData.remainingNumberOfMissionsToComplete_ = remainingNumberOfMissionsToComplete_);
			bool flag = (secretCharacterRecurringConditionData.isDiscovered_ = isDiscovered_);
			UnknownFieldSet unknownFieldSet = (secretCharacterRecurringConditionData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return secretCharacterRecurringConditionData;
		}

		[Cpp2IlInjected.Token(Token = "0x600452F")]
		[Cpp2IlInjected.Address(RVA = "0x176EDA0", Offset = "0x176D7A0", VA = "0x18176EDA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(counters_, other) && object.Equals(lastVisit_, other) && object.Equals(lastCheck_, other))
				{
					bool flag = object.Equals(spawnedInLocation_, other);
					if (flag && lastCompletedMissionItemID_ == (flag ? 1 : 0) && remainingNumberOfMissionsToComplete_ == (flag ? 1 : 0) && isDiscovered_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004530")]
		[Cpp2IlInjected.Address(RVA = "0x176ECE0", Offset = "0x176D6E0", VA = "0x18176ECE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SecretCharacterRecurringConditionData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.CountersData objB = other.counters_;
				if (object.Equals(counters_, objB))
				{
					Timestamp objB2 = other.lastVisit_;
					if (object.Equals(lastVisit_, objB2))
					{
						Timestamp objB3 = other.lastCheck_;
						if (object.Equals(lastCheck_, objB3))
						{
							SecretCharacterLocationFilter objB4 = other.spawnedInLocation_;
							if (object.Equals(spawnedInLocation_, objB4))
							{
								int num = other.lastCompletedMissionItemID_;
								if (lastCompletedMissionItemID_ == num)
								{
									int num2 = other.remainingNumberOfMissionsToComplete_;
									if (remainingNumberOfMissionsToComplete_ == num2)
									{
										bool flag = other.isDiscovered_;
										if (isDiscovered_ == flag)
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
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004531")]
		[Cpp2IlInjected.Address(RVA = "0x176F010", Offset = "0x176DA10", VA = "0x18176F010", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Types.CountersData countersData = counters_;
				if (countersData != null)
				{
					int hashCode = countersData.GetHashCode();
				}
				Timestamp timestamp = lastVisit_;
				if (timestamp != null)
				{
					int hashCode2 = timestamp.GetHashCode();
				}
				Timestamp timestamp2 = lastCheck_;
				if (timestamp2 != null)
				{
					int hashCode3 = timestamp2.GetHashCode();
				}
				SecretCharacterLocationFilter secretCharacterLocationFilter = spawnedInLocation_;
				if (secretCharacterLocationFilter != null)
				{
					int hashCode4 = secretCharacterLocationFilter.GetHashCode();
				}
				if (lastCompletedMissionItemID_ != 0)
				{
				}
				if (remainingNumberOfMissionsToComplete_ != 0)
				{
				}
				if (isDiscovered_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004532")]
		[Cpp2IlInjected.Address(RVA = "0x1771570", Offset = "0x176FF70", VA = "0x181771570", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004533")]
		[Cpp2IlInjected.Address(RVA = "0x1771D40", Offset = "0x1770740", VA = "0x181771D40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00c5
			if ((long)counters_ != 0)
			{
				Types.CountersData value = counters_;
				output.WriteMessage(value);
			}
			if ((long)lastVisit_ != 0)
			{
				Timestamp value2 = lastVisit_;
				output.WriteMessage(value2);
			}
			if ((long)lastCheck_ != 0)
			{
				Timestamp value3 = lastCheck_;
				output.WriteMessage(value3);
			}
			if ((long)spawnedInLocation_ != 0)
			{
				SecretCharacterLocationFilter value4 = spawnedInLocation_;
				output.WriteMessage(value4);
			}
			if (lastCompletedMissionItemID_ != 0)
			{
				int value5 = lastCompletedMissionItemID_;
				output.WriteInt32(value5);
			}
			if (remainingNumberOfMissionsToComplete_ != 0)
			{
				int value6 = remainingNumberOfMissionsToComplete_;
				output.WriteInt32(value6);
			}
			if (isDiscovered_)
			{
				bool value7 = isDiscovered_;
				output.WriteBool(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004534")]
		[Cpp2IlInjected.Address(RVA = "0x176E250", Offset = "0x176CC50", VA = "0x18176E250", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.CountersData countersData = counters_;
				num = 0;
				if (countersData != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(countersData);
				}
				Timestamp timestamp = lastVisit_;
				if (timestamp != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(timestamp);
					num3++;
					num += num3;
				}
				Timestamp timestamp2 = lastCheck_;
				if (timestamp2 != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(timestamp2);
					num4++;
					num += num4;
				}
				SecretCharacterLocationFilter secretCharacterLocationFilter = spawnedInLocation_;
				if (secretCharacterLocationFilter != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(secretCharacterLocationFilter);
					num5++;
					num += num5;
				}
				int num6 = lastCompletedMissionItemID_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num += num7;
				}
				int num8 = remainingNumberOfMissionsToComplete_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num += num9;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num10 = unknownFields.CalculateSize();
			return num10 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004535")]
		[Cpp2IlInjected.Address(RVA = "0x176FA80", Offset = "0x176E480", VA = "0x18176FA80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SecretCharacterRecurringConditionData other)
		{
			//Discarded unreachable code: IL_0152
			if (other == null)
			{
				return;
			}
			if ((long)other.counters_ != 0)
			{
				Types.CountersData countersData = counters_;
				if (countersData == null)
				{
					Types.CountersData countersData2 = (counters_ = new Types.CountersData());
					Types.CountersData countersData3 = counters_;
				}
				Types.CountersData other2 = other.counters_;
				countersData.MergeFrom(other2);
			}
			if ((long)other.lastVisit_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastVisit_ == null)
				{
					Timestamp timestamp = (lastVisit_ = new Timestamp());
					timestamp2 = lastVisit_;
				}
				Timestamp other3 = other.lastVisit_;
				timestamp2.MergeFrom(other3);
			}
			if ((long)other.lastCheck_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (lastCheck_ == null)
				{
					Timestamp timestamp3 = (lastCheck_ = new Timestamp());
					timestamp4 = lastCheck_;
				}
				Timestamp other4 = other.lastCheck_;
				timestamp4.MergeFrom(other4);
			}
			if ((long)other.spawnedInLocation_ != 0)
			{
				SecretCharacterLocationFilter secretCharacterLocationFilter2 = default(SecretCharacterLocationFilter);
				if (spawnedInLocation_ == null)
				{
					SecretCharacterLocationFilter secretCharacterLocationFilter = (spawnedInLocation_ = new SecretCharacterLocationFilter());
					secretCharacterLocationFilter2 = spawnedInLocation_;
				}
				SecretCharacterLocationFilter other5 = other.spawnedInLocation_;
				secretCharacterLocationFilter2.MergeFrom(other5);
			}
			int num = other.lastCompletedMissionItemID_;
			if (num != 0)
			{
				lastCompletedMissionItemID_ = num;
			}
			int num2 = other.remainingNumberOfMissionsToComplete_;
			if (num2 != 0)
			{
				remainingNumberOfMissionsToComplete_ = num2;
			}
			bool flag = other.isDiscovered_;
			if (flag)
			{
				isDiscovered_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004536")]
		[Cpp2IlInjected.Address(RVA = "0x176FC80", Offset = "0x176E680", VA = "0x18176FC80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0134
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 40)
				{
					if (num == 48)
					{
						int num2 = (remainingNumberOfMissionsToComplete_ = input.ReadInt32());
					}
					if (num != 56)
					{
						goto IL_011d;
					}
					bool flag = (isDiscovered_ = input.ReadBool());
				}
				SecretCharacterLocationFilter secretCharacterLocationFilter = default(SecretCharacterLocationFilter);
				if (num == 34)
				{
					SecretCharacterLocationFilter builder = default(SecretCharacterLocationFilter);
					if (spawnedInLocation_ == null)
					{
						secretCharacterLocationFilter = (spawnedInLocation_ = new SecretCharacterLocationFilter());
						builder = spawnedInLocation_;
					}
					input.ReadMessage(builder);
				}
				if ((long)secretCharacterLocationFilter != 40)
				{
					goto IL_011d;
				}
				int num3 = (lastCompletedMissionItemID_ = input.ReadInt32());
			}
			Types.CountersData countersData = default(Types.CountersData);
			if (num == 10)
			{
				Types.CountersData builder2 = default(Types.CountersData);
				if (counters_ == null)
				{
					countersData = (counters_ = new Types.CountersData());
					builder2 = counters_;
				}
				input.ReadMessage(builder2);
			}
			Timestamp timestamp = default(Timestamp);
			if ((long)countersData == 18)
			{
				Timestamp builder3 = default(Timestamp);
				if (lastVisit_ == null)
				{
					timestamp = (lastVisit_ = new Timestamp());
					builder3 = lastVisit_;
				}
				input.ReadMessage(builder3);
			}
			if ((long)timestamp == 26)
			{
				Timestamp builder4 = default(Timestamp);
				if (lastCheck_ == null)
				{
					Timestamp timestamp2 = (lastCheck_ = new Timestamp());
					builder4 = lastCheck_;
				}
				input.ReadMessage(builder4);
			}
			goto IL_011d;
			IL_011d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004537")]
		[Cpp2IlInjected.Address(RVA = "0x176EEB0", Offset = "0x176D8B0", VA = "0x18176EEB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				Types.CountersData countersData = counters_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004538")]
		[Cpp2IlInjected.Address(RVA = "0x17707A0", Offset = "0x176F1A0", VA = "0x1817707A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0020, IL_0028, IL_0030, IL_003c, IL_0042, IL_0048
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				counters_ = (Types.CountersData)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004539")]
		[Cpp2IlInjected.Address(RVA = "0x176E550", Offset = "0x176CF50", VA = "0x18176E550", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0005, IL_0007
			if (fieldNumber > 6)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600453A")]
		[Cpp2IlInjected.Address(RVA = "0x176F3F0", Offset = "0x176DDF0", VA = "0x18176F3F0")]
		internal void Init(Character character, in World world, ITransactionContext context)
		{
			//IL_0157: Expected O, but got I4
			IWorldEventDispatcher worldEventDispatcher = world.dispatcher;
			if (worldEventDispatcher == null)
			{
			}
			int num = 0;
			int num2 = 0;
			dispatcher = (ProfileEventDispatcher)worldEventDispatcher;
			this.context = context;
			this.character = character;
			RepeatedField<SecretCharacterRecurringCondition> recurringConditions_ = character.Data.secretCharacterData_.recurringConditions_;
			Predicate<SecretCharacterRecurringCondition> predicate = default(Predicate<SecretCharacterRecurringCondition>);
			if (_003C_003Ec._003C_003E9__64_0 == null)
			{
				predicate = (Predicate<SecretCharacterRecurringCondition>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(SecretCharacterRecurringCondition x)
				{
					//Discarded unreachable code: IL_0014
					SecretCharacterRecurringCondition.ConditionOneofCase conditionCase_ = x.conditionCase_;
					return conditionCase_ == SecretCharacterRecurringCondition.ConditionOneofCase.FruitsHarvested || conditionCase_ == SecretCharacterRecurringCondition.ConditionOneofCase.VegetablesHarvested;
				});
			}
			if (((RepeatedField<>)(object)recurringConditions_).Any<SecretCharacterRecurringCondition>((Predicate<>)(object)predicate))
			{
				ProfileEventDispatcher profileEventDispatcher = dispatcher;
				ProfileEventDispatcher.GardeningEvent value = OnGardeningEvent;
				profileEventDispatcher.OnGardeningEvent += value;
			}
			RepeatedField<SecretCharacterRecurringCondition> recurringConditions_2 = character.Data.secretCharacterData_.recurringConditions_;
			Predicate<SecretCharacterRecurringCondition> predicate2 = default(Predicate<SecretCharacterRecurringCondition>);
			if (_003C_003Ec._003C_003E9__64_1 == null)
			{
				predicate2 = (Predicate<SecretCharacterRecurringCondition>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((SecretCharacterRecurringCondition x) => x.conditionCase_ == SecretCharacterRecurringCondition.ConditionOneofCase.FishesFished));
			}
			if (((RepeatedField<>)(object)recurringConditions_2).Any<SecretCharacterRecurringCondition>((Predicate<>)(object)predicate2))
			{
				ProfileEventDispatcher profileEventDispatcher2 = dispatcher;
				ProfileEventDispatcher.FishingResultReceived value2 = OnFishingResultReceived;
				profileEventDispatcher2.OnFishingResultReceived += value2;
			}
			RepeatedField<SecretCharacterRecurringCondition> recurringConditions_3 = character.Data.secretCharacterData_.recurringConditions_;
			Predicate<SecretCharacterRecurringCondition> predicate3 = default(Predicate<SecretCharacterRecurringCondition>);
			if (_003C_003Ec._003C_003E9__64_2 == null)
			{
				predicate3 = (Predicate<SecretCharacterRecurringCondition>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((SecretCharacterRecurringCondition x) => x.conditionCase_ == SecretCharacterRecurringCondition.ConditionOneofCase.MealsCooked));
			}
			if (((RepeatedField<>)(object)recurringConditions_3).Any<SecretCharacterRecurringCondition>((Predicate<>)(object)predicate3))
			{
				ProfileEventDispatcher profileEventDispatcher3 = dispatcher;
				ProfileEventDispatcher.MealCooked value3 = OnMealCooked;
				profileEventDispatcher3.OnMealCooked += value3;
			}
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)num2;
			Character character2 = this.character;
			CharacterItemData characterItemData = default(CharacterItemData);
			ConditionListener listener = characterItemData.secretCharacterData_.characterUnlockCondition_.Listener;
			if (HasLocationType(SecretCharacterLocationFilter.LocationTypeOneofCase.VillageArea))
			{
			}
			if (HasLocationType(SecretCharacterLocationFilter.LocationTypeOneofCase.Scene))
			{
			}
			ConditionListener listener2 = this.character.Data.secretCharacterData_.preConditions_.Listener;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyUnlockConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x600454A")]
			[Cpp2IlInjected.Address(RVA = "0x1771600", Offset = "0x1770000", VA = "0x181771600")]
			bool HasLocationType(SecretCharacterLocationFilter.LocationTypeOneofCase locationType)
			{
				//Discarded unreachable code: IL_0040
				RepeatedField<SecretCharacterData.Types.LocationTypeWeight> locations_ = this.character.Data.secretCharacterData_.locations_;
				Predicate<SecretCharacterData.Types.LocationTypeWeight> predicate4 = (Predicate<SecretCharacterData.Types.LocationTypeWeight>)(object)(Predicate<T>)delegate(SecretCharacterData.Types.LocationTypeWeight x)
				{
					//Discarded unreachable code: IL_0018
					SecretCharacterLocationFilter locationFilter_ = x.locationFilter_;
					SecretCharacterLocationFilter.LocationTypeOneofCase locationTypeOneofCase = locationType;
					return locationFilter_.locationTypeCase_ == locationTypeOneofCase;
				};
				return ((RepeatedField<>)(object)locations_).Find<SecretCharacterData.Types.LocationTypeWeight>((Predicate<>)(object)predicate4) != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600453B")]
		[Cpp2IlInjected.Address(RVA = "0x176E400", Offset = "0x176CE00", VA = "0x18176E400")]
		internal void Cleanup(ProfileEventDispatcher dispatcher)
		{
			//IL_0056: Expected O, but got I8
			ProfileEventDispatcher.GardeningEvent value = OnGardeningEvent;
			dispatcher.OnGardeningEvent -= value;
			ProfileEventDispatcher.FishingResultReceived value2 = OnFishingResultReceived;
			dispatcher.OnFishingResultReceived -= value2;
			ProfileEventDispatcher.MealCooked value3 = OnMealCooked;
			dispatcher.OnMealCooked -= value3;
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600453C")]
		[Cpp2IlInjected.Address(RVA = "0x176D9C0", Offset = "0x176C3C0", VA = "0x18176D9C0")]
		internal int? CalculateApparitionWeight(SecretCharacterData secretCharacterData, DateTime localTime)
		{
			//Discarded unreachable code: IL_0153, IL_0159, IL_015f, IL_0165, IL_016b, IL_0171, IL_0177, IL_017d, IL_0183, IL_0189, IL_018f
			//IL_00d2: Expected I4, but got I8
			DayOfWeek dayOfWeek = default(DayOfWeek);
			ulong num3 = default(ulong);
			int num5 = default(int);
			int num6 = default(int);
			DayOfWeek dayOfWeek2 = default(DayOfWeek);
			int num8 = default(int);
			DayOfWeek dayOfWeek3 = default(DayOfWeek);
			ulong num10 = default(ulong);
			int num12 = default(int);
			bool flag = default(bool);
			Duration duration = default(Duration);
			TimeSpan timeSpan2 = default(TimeSpan);
			Duration duration2 = default(Duration);
			bool flag2 = default(bool);
			int num13 = default(int);
			int num14 = default(int);
			int num16 = default(int);
			int num15 = default(int);
			int num;
			do
			{
				num = 0;
				if (secretCharacterData.apparitionCase_ == SecretCharacterData.ApparitionOneofCase.SpecificMoment)
				{
					int endHour_ = secretCharacterData.SpecificMoment.time_.endHour_;
					int startHour_ = secretCharacterData.SpecificMoment.time_.startHour_;
					int dayOfTheWeekInt = secretCharacterData.SpecificMoment.DayOfTheWeekInt;
					int num2 = (int)dayOfWeek;
					if (endHour_ < startHour_)
					{
						int dayOfTheWeekInt2 = secretCharacterData.SpecificMoment.DayOfTheWeekInt;
						num3 += num3;
						long num4 = (long)(num3 * 7);
					}
					if (dayOfTheWeekInt != 0)
					{
						dayOfTheWeekInt = num5;
						SecretCharacterData.Types.TimeInterval time_ = secretCharacterData.SpecificMoment.time_;
						dayOfTheWeekInt = num6;
						SecretCharacterData.Types.TimeInterval time_2 = secretCharacterData.SpecificMoment.time_;
						dayOfTheWeekInt = secretCharacterData.SpecificMoment.DayOfTheWeekInt;
						int num7 = (int)dayOfWeek2;
						if (dayOfTheWeekInt != (int)dayOfWeek2)
						{
							dayOfTheWeekInt = num8;
							SecretCharacterData.Types.TimeInterval time_3 = secretCharacterData.SpecificMoment.time_;
						}
						dayOfTheWeekInt = secretCharacterData.SpecificMoment.DayOfTheWeekInt;
						int num9 = (int)(dayOfWeek3 + 1);
						num10 += num10;
						long num11 = (long)(num10 * 7);
						num9 = (int)(num9 - num11);
						if (dayOfTheWeekInt != num11)
						{
							dayOfTheWeekInt = num12;
							SecretCharacterData.Types.TimeInterval time_4 = secretCharacterData.SpecificMoment.time_;
						}
					}
				}
				int baseProbability_ = secretCharacterData.baseProbability_;
				RepeatedField<SecretCharacterRecurringCondition> recurringConditions_ = secretCharacterData.recurringConditions_;
				if (flag)
				{
					if (lastVisit_ == null)
					{
					}
					TimeSpan timeSpan = duration.ToTimeSpan();
					if ((object)timeSpan2 != null)
					{
						TimeSpan timeSpan3 = duration2.ToTimeSpan();
						flag2 = num13 >= num14;
						num16 = num15;
					}
					if (!flag2)
					{
						num++;
					}
					baseProbability_ += num16;
				}
				num++;
				int num17 = 0;
			}
			while (num != 0);
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600453D")]
		[Cpp2IlInjected.Address(RVA = "0x1771740", Offset = "0x1770140", VA = "0x181771740")]
		internal bool UpdateApparition(Item characterItem, SecretCharacterData secretCharacterData, Item sceneItem, in World world, ITransactionContext context)
		{
			//IL_0076: Expected O, but got I4
			Timestamp timestamp = lastCheck_;
			if (timestamp != null)
			{
				DateTime dateTime = timestamp.ToDateTime();
				DateTime dateTime2 = default(DateTime);
				DateTime dateTime3 = default(DateTime);
				if (!(dateTime2 != dateTime3))
				{
					DateTime dateTime4 = lastCheck_.ToDateTime();
					int num = default(int);
					int num2 = default(int);
					if (num == num2)
					{
						goto IL_0046;
					}
				}
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			SceneItemData sceneItemData = default(SceneItemData);
			ProfileWorld profileWorld = default(ProfileWorld);
			List<SecretCharacterData.Types.LocationTypeWeight> listOfPossibleLocations = (List<SecretCharacterData.Types.LocationTypeWeight>)(object)this.GetListOfPossibleLocations(sceneItemData, secretCharacterData, profileWorld);
			goto IL_0046;
			IL_0099:
			int? num3 = default(int?);
			if ((object)num3 != null)
			{
				int seed = new Random(seed).Next(1000);
				int num4 = default(int);
				if (seed < num4 && secretCharacterData.apparitionCase_ == SecretCharacterData.ApparitionOneofCase.SpecificMoment)
				{
					int endHour_ = secretCharacterData.SpecificMoment.time_.endHour_;
					SecretCharacterData.Types.TimeInterval time_ = secretCharacterData.SpecificMoment.time_;
					if (endHour_ < time_.startHour_)
					{
						int num5 = 0;
						int num6 = default(int);
						endHour_ = num6;
						SecretCharacterData.Types.TimeInterval time_2 = secretCharacterData.SpecificMoment.time_;
						if (endHour_ >= time_2.endHour_)
						{
						}
					}
					SecretCharacterData.Types.TimeInterval time_3 = secretCharacterData.SpecificMoment.time_;
					DateTime dateTime5 = default(DateTime);
					TimeSpan timeSpan = default(TimeSpan);
					DateTime dateTime6 = dateTime5 + timeSpan;
				}
			}
			goto IL_0124;
			IL_0124:
			Timestamp timestamp2 = default(Timestamp);
			lastCheck_ = timestamp2;
			throw new NullReferenceException();
			IL_0046:
			int num7 = 0;
			if ((long)lastVisit_ == 0)
			{
				goto IL_0099;
			}
			if (secretCharacterData.apparitionCase_ == SecretCharacterData.ApparitionOneofCase.SpecificMoment)
			{
				DateTime dateTime7 = lastVisit_.ToDateTime();
				TimeSpan timeSpan2 = (DateTime)num7 - dateTime7;
				TimeSpan duration = secretCharacterData.SpecificMoment.time_.Duration;
				if (timeSpan2 > duration)
				{
					goto IL_0099;
				}
			}
			goto IL_0124;
		}

		[Cpp2IlInjected.Token(Token = "0x600453E")]
		[Cpp2IlInjected.Address(RVA = "0x17709E0", Offset = "0x176F3E0", VA = "0x1817709E0")]
		private void StartVisit(Item characterItem, SecretCharacterData secretCharacterData, List<SecretCharacterData.Types.LocationTypeWeight> possibleLocations, DateTime visitStart, in World world, ITransactionContext context, Random random)
		{
			//Discarded unreachable code: IL_01b7, IL_01ce, IL_01da, IL_01e0, IL_01e6, IL_01ec, IL_01f2, IL_01f8, IL_01fe, IL_0204, IL_020a
			//IL_007a: Expected O, but got I4
			//IL_00de: Expected I4, but got I8
			//IL_0174: Expected I4, but got I8
			int num = 0;
			Timestamp timestamp = default(Timestamp);
			lastVisit_ = timestamp;
			SecretCharacterLocationFilter secretCharacterLocationFilter = new SecretCharacterLocationFilter();
			secretCharacterLocationFilter.VillageArea = VillageAreaType.Urban;
			spawnedInLocation_ = secretCharacterLocationFilter;
			if (_003C_003Ec._003C_003E9__68_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SecretCharacterData.Types.LocationTypeWeight x) => x.weight_);
			}
			IOrderedEnumerable<SecretCharacterData.Types.LocationTypeWeight> orderedEnumerable = default(IOrderedEnumerable<SecretCharacterData.Types.LocationTypeWeight>);
			List<SecretCharacterData.Types.LocationTypeWeight> list = (List<SecretCharacterData.Types.LocationTypeWeight>)(object)Enumerable.ToList<SecretCharacterData.Types.LocationTypeWeight>((IEnumerable<>)orderedEnumerable);
			Func<SecretCharacterData.Types.LocationTypeWeight, int> func = default(Func<SecretCharacterData.Types.LocationTypeWeight, int>);
			if (_003C_003Ec._003C_003E9__68_1 == null)
			{
				func = (Func<SecretCharacterData.Types.LocationTypeWeight, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SecretCharacterData.Types.LocationTypeWeight x) => x.weight_));
			}
			int num2 = Enumerable.Sum<SecretCharacterData.Types.LocationTypeWeight>((IEnumerable<>)list, (Func<, >)(object)func);
			bool flag = default(bool);
			if (flag)
			{
				spawnedInLocation_ = (SecretCharacterLocationFilter)0;
			}
			int state_ = 0;
			if (list == null)
			{
				int num3 = default(int);
				int num6 = default(int);
				if (num3 > 0)
				{
					ProfileWorld profileWorld = default(ProfileWorld);
					MissionQueue missionQueue = profileWorld.GetMissionQueue(MissionSlotClass.Secret);
					RepeatedField<MissionSlot> slots_ = missionQueue.slots_;
					Func<MissionSlot, bool> func2 = default(Func<MissionSlot, bool>);
					if (_003C_003Ec._003C_003E9__68_2 == null)
					{
						func2 = (Func<MissionSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSlot x) => (IntPtr)x.missionId_ == (IntPtr)"{il2cpp field on {'constant11' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}"));
					}
					MissionSlot missionSlot = default(MissionSlot);
					if (Enumerable.FirstOrDefault<MissionSlot>((IEnumerable<>)(object)slots_, (Func<, >)(object)func2) == null)
					{
						missionSlot = new MissionSlot();
						missionSlot.class_ = MissionSlotClass.Secret;
						int num4 = (missionSlot.slotId_ = ((RepeatedField<T>)(object)missionQueue.slots_).Count);
						missionSlot.state_ = (MissionSlotState)state_;
						((RepeatedField<T>)(object)missionQueue.slots_).Add((T)missionSlot);
					}
					int num5 = num5 + 1;
					SecretCharacterData.Types.SpecificMomentData specificMomentData = default(SecretCharacterData.Types.SpecificMomentData);
					TimeSpan duration = specificMomentData.time_.Duration;
					DateTime dateTime = default(DateTime);
					Timestamp timestamp2 = (missionSlot.expirationTime_ = (dateTime + duration).ToProto());
					int seed = default(int);
					Random random2 = new Random(seed);
					MultiReward multiReward = new MultiReward();
					MultiReward rewards_ = default(MultiReward);
					missionSlot.rewards_ = rewards_;
					MultiReward additionalRewards_ = default(MultiReward);
					missionSlot.additionalRewards_ = additionalRewards_;
					FriendshipReward friendshipReward = new FriendshipReward();
					friendshipReward.id_ = 0;
					friendshipReward.amount_ = 1;
					RepeatedField<AnyReward> rewards_2 = missionSlot.rewards_.rewards_;
					AnyReward item = AnyReward.From(friendshipReward);
					((RepeatedField<T>)(object)rewards_2).Add((T)item);
					num6 = 0;
					IDisposable disposable = default(IDisposable);
					if (disposable == null)
					{
					}
				}
				Types.CountersData countersData = new Types.CountersData();
				uint num7 = default(uint);
				if (num6 < (int)num7)
				{
					num6 += num6;
					num6++;
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600453F")]
		[Cpp2IlInjected.Address(RVA = "0x1770490", Offset = "0x176EE90", VA = "0x181770490")]
		private void OnGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0095
			//IL_0044: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_007a: Expected I4, but got O
			//IL_0094: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
			SeedItemData seedItemData = default(SeedItemData);
			if (seedItemData != null)
			{
				Item producedItem = seedItemData.ProducedItem;
				CropItemData cropItemData = default(CropItemData);
				if (cropItemData != null)
				{
				}
				uint num = default(uint);
				if (!((MapField<TKey, TValue>)(object)counters_.cropsHarvested_).ContainsKey((TKey)num))
				{
					MapField<int, int> cropsHarvested_ = counters_.cropsHarvested_;
					int num2 = 0;
					((MapField<TKey, TValue>)(object)cropsHarvested_).Add((TKey)num, (TValue)num2);
				}
				MapField<int, int> cropsHarvested_2 = counters_.cropsHarvested_;
				int num3 = (int)((MapField<TKey, TValue>)(object)cropsHarvested_2)[(TKey)num];
				int producedAmount_ = seedItemData.producedAmount_;
				producedAmount_ += num3;
				((MapField<TKey, TValue>)(object)cropsHarvested_2)[(TKey)num] = (TValue)producedAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004540")]
		[Cpp2IlInjected.Address(RVA = "0x1770470", Offset = "0x176EE70", VA = "0x181770470")]
		private void OnFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_000c
			if (success)
			{
				Types.CountersData countersData = counters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004541")]
		[Cpp2IlInjected.Address(RVA = "0x1770720", Offset = "0x176F120", VA = "0x181770720")]
		private void OnMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			//Discarded unreachable code: IL_0010
			bool flag = default(bool);
			ActivityItemType activityItemType = default(ActivityItemType);
			if (flag && activityItemType == ActivityItemType.Meal)
			{
				Types.CountersData countersData = counters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004542")]
		[Cpp2IlInjected.Address(RVA = "0x176E8F0", Offset = "0x176D2F0", VA = "0x18176E8F0")]
		internal void DebugForceVisit(Item characterItem, Item sceneItem, SecretCharacterData secretCharacterData, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0066, IL_006c
			//IL_0016: Expected O, but got I4
			int itemID = characterItem.ItemID;
			int num = 0;
			Item characterItem2 = (Item)itemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<MissionSlot, bool> func = default(Func<MissionSlot, bool>);
			Func<MissionSlot, bool> func2 = func;
			if (func2 == null)
			{
				func = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
				{
					//Discarded unreachable code: IL_001c
					if (x.class_ != MissionSlotClass.Secret)
					{
						int num2 = 0;
					}
					Item item2 = characterItem2;
					return (object)MissionSlot._repeated_itemsToGive_codec == (object)item2;
				};
			}
			ProfileWorld profileWorld = default(ProfileWorld);
			List<MissionSlot> list = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>(profileWorld.GetAllMissionSlot((Func<, >)(object)func2));
			bool flag = default(bool);
			if (flag)
			{
			}
			int seed = default(int);
			Random random = new Random(seed);
			Item item = characterItem2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004543")]
		[Cpp2IlInjected.Address(RVA = "0x176F120", Offset = "0x176DB20", VA = "0x18176F120")]
		private List<SecretCharacterData.Types.LocationTypeWeight> GetListOfPossibleLocations(SceneItemData sceneItemData, SecretCharacterData secretCharacterData, ProfileWorld profileWorld)
		{
			//Discarded unreachable code: IL_005b, IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			//IL_002a: Expected I4, but got O
			List<SecretCharacterData.Types.LocationTypeWeight> list;
			bool flag = default(bool);
			bool flag2 = default(bool);
			int num = default(int);
			do
			{
				list = (List<SecretCharacterData.Types.LocationTypeWeight>)(object)new List<T>();
				RepeatedField<SecretCharacterData.Types.LocationTypeWeight> locations_ = secretCharacterData.locations_;
				if (!flag)
				{
					break;
				}
				if (flag)
				{
					while (!flag2)
					{
					}
					SecretCharacterData.Types.LocationTypeWeight locationTypeWeight = new SecretCharacterData.Types.LocationTypeWeight();
					locationTypeWeight.weight_ = (int)locationTypeWeight;
					SecretCharacterLocationFilter secretCharacterLocationFilter = new SecretCharacterLocationFilter();
					VillageAreaType villageArea = secretCharacterLocationFilter.VillageArea;
					locationTypeWeight.locationFilter_ = secretCharacterLocationFilter;
					((List<T>)(object)list).Add((T)locationTypeWeight);
				}
				while (!flag)
				{
				}
			}
			while (sceneItemData.iD_ != num);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6004544")]
		[Cpp2IlInjected.Address(RVA = "0x176E770", Offset = "0x176D170", VA = "0x18176E770")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			ConditionListener listener = character.Data.secretCharacterData_.characterUnlockCondition_.Listener;
			if (HasLocationType(SecretCharacterLocationFilter.LocationTypeOneofCase.VillageArea))
			{
			}
			if (HasLocationType(SecretCharacterLocationFilter.LocationTypeOneofCase.Scene))
			{
			}
			ConditionListener listener2 = character.Data.secretCharacterData_.preConditions_.Listener;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyUnlockConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x600454A")]
			[Cpp2IlInjected.Address(RVA = "0x1771600", Offset = "0x1770000", VA = "0x181771600")]
			bool HasLocationType(SecretCharacterLocationFilter.LocationTypeOneofCase locationType)
			{
				//Discarded unreachable code: IL_0040
				RepeatedField<SecretCharacterData.Types.LocationTypeWeight> locations_ = character.Data.secretCharacterData_.locations_;
				Predicate<SecretCharacterData.Types.LocationTypeWeight> predicate = (Predicate<SecretCharacterData.Types.LocationTypeWeight>)(object)(Predicate<T>)delegate(SecretCharacterData.Types.LocationTypeWeight x)
				{
					//Discarded unreachable code: IL_0018
					SecretCharacterLocationFilter locationFilter_ = x.locationFilter_;
					SecretCharacterLocationFilter.LocationTypeOneofCase locationTypeOneofCase = locationType;
					return locationFilter_.locationTypeCase_ == locationTypeOneofCase;
				};
				return ((RepeatedField<>)(object)locations_).Find<SecretCharacterData.Types.LocationTypeWeight>((Predicate<>)(object)predicate) != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004545")]
		[Cpp2IlInjected.Address(RVA = "0x13683B0", Offset = "0x1366DB0", VA = "0x1813683B0")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004546")]
		[Cpp2IlInjected.Address(RVA = "0x176FEC0", Offset = "0x176E8C0", VA = "0x18176FEC0")]
		private void OnAnyUnlockConditionChanged(ConditionListener conditionListener)
		{
			//IL_0128: Expected O, but got I4
			RepeatedField<ConditionOneOf> conditions_;
			Predicate<ConditionOneOf> predicate;
			do
			{
				if ((object)this.profile.player_.CurrentScene != null)
				{
					return;
				}
				Character character = this.character;
				if (character.status_ != Character.Types.CharacterStatus.Secret)
				{
					return;
				}
				ConditionsList preConditions_ = character.Data.secretCharacterData_.preConditions_;
				ITransactionContext transactionContext = context;
				Profile profile = this.profile;
				if (!preConditions_.Evaluate(profile, transactionContext))
				{
					return;
				}
				if (this.character.Data.secretCharacterData_.HasCharacterUnlockConditions())
				{
					ConditionsList characterUnlockCondition_ = this.character.Data.secretCharacterData_.characterUnlockCondition_;
					ITransactionContext transactionContext2 = context;
					Profile profile2 = this.profile;
					if (characterUnlockCondition_.Evaluate(profile2, transactionContext2))
					{
						ProfileEventDispatcher profileEventDispatcher = dispatcher;
						ProfileEventDispatcher.GardeningEvent value = OnGardeningEvent;
						profileEventDispatcher.OnGardeningEvent -= value;
						ProfileEventDispatcher.FishingResultReceived value2 = OnFishingResultReceived;
						profileEventDispatcher.OnFishingResultReceived -= value2;
						ProfileEventDispatcher.MealCooked value3 = OnMealCooked;
						profileEventDispatcher.OnMealCooked -= value3;
						eventHandler?.Dispose();
						int num = 0;
						eventHandler = (ConditionEventHandler)num;
						Character character2 = this.character;
						Profile profile3 = this.profile;
						Item item = character2.base_.Item;
						return;
					}
				}
				while ((long)lastCheck_ != 0)
				{
				}
				ConditionListener conditionListener2 = conditionListener;
				if (conditionListener2 == ConditionListener.Area || conditionListener2 == ConditionListener.Scene)
				{
					break;
				}
				conditions_ = this.character.Data.secretCharacterData_.preConditions_.conditions_;
				predicate = (Predicate<ConditionOneOf>)(object)(Predicate<T>)((ConditionOneOf x) => x.Listener == conditionListener);
			}
			while (!((RepeatedField<>)(object)conditions_).Any<ConditionOneOf>((Predicate<>)(object)predicate));
			Item item2 = this.character.base_.Item;
			Character character3 = this.character;
			BaseItem base_ = character3.base_;
			SecretCharacterRecurringConditionData secretCharacterData_ = character3.secretCharacterData_;
			Item item3 = base_.Item;
			Item _003CCurrentScene_003Ek__BackingField = this.profile.player_.CurrentScene;
			ITransactionContext transactionContext3 = context;
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004547")]
		[Cpp2IlInjected.Address(RVA = "0x1771EA0", Offset = "0x17708A0", VA = "0x181771EA0")]
		static SecretCharacterRecurringConditionData()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
