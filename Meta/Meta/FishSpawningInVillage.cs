using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000857")]
	public sealed class FishSpawningInVillage : IMessage<FishSpawningInVillage>, IMessage, IEquatable<FishSpawningInVillage>, IDeepCloneable<FishSpawningInVillage>, IMessageFieldAccessor, IRecurringEvent
	{
		[Cpp2IlInjected.Token(Token = "0x400217C")]
		private static readonly MessageParser<FishSpawningInVillage> _parser = (MessageParser<FishSpawningInVillage>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new FishSpawningInVillage()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400217D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400217E")]
		public const int RecurringEventItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400217F")]
		private int recurringEventItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002180")]
		public const int NextOccurrenceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002181")]
		private Timestamp nextOccurrence_;

		[Cpp2IlInjected.Token(Token = "0x4002182")]
		public const int EndDateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002183")]
		private Timestamp endDate_;

		[Cpp2IlInjected.Token(Token = "0x17000B8C")]
		[DebuggerNonUserCode]
		public static MessageParser<FishSpawningInVillage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60045FC")]
			[Cpp2IlInjected.Address(RVA = "0x1800400", Offset = "0x17FEE00", VA = "0x181800400")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045FD")]
			[Cpp2IlInjected.Address(RVA = "0x1800290", Offset = "0x17FEC90", VA = "0x181800290")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60045FE")]
			[Cpp2IlInjected.Address(RVA = "0x18004C0", Offset = "0x17FEEC0", VA = "0x1818004C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B8F")]
		[DebuggerNonUserCode]
		public int RecurringEventItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004602")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recurringEventItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004603")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recurringEventItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B90")]
		[DebuggerNonUserCode]
		public Timestamp NextOccurrence
		{
			[Cpp2IlInjected.Token(Token = "0x6004604")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return nextOccurrence_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004605")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "16")]
			set
			{
				nextOccurrence_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B91")]
		[DebuggerNonUserCode]
		public Timestamp EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6004606")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004607")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "18")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B92")]
		public Item RecurringEventItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004613")]
			[Cpp2IlInjected.Address(RVA = "0x1800460", Offset = "0x17FEE60", VA = "0x181800460", Slot = "14")]
			get
			{
				long num = Convert.ToInt64((uint)recurringEventItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B93")]
		private static ItemDatabase ItemDatabase
		{
			[Cpp2IlInjected.Token(Token = "0x6004614")]
			[Cpp2IlInjected.Address(RVA = "0x1800360", Offset = "0x17FED60", VA = "0x181800360")]
			get
			{
				return ItemDatabase.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60045FF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FishSpawningInVillage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004600")]
		[Cpp2IlInjected.Address(RVA = "0x7B0570", Offset = "0x7AEF70", VA = "0x1807B0570")]
		[DebuggerNonUserCode]
		public FishSpawningInVillage(FishSpawningInVillage other)
		{
			//IL_002f: Expected O, but got I4
			int num = (recurringEventItemID_ = other.recurringEventItemID_);
			Timestamp timestamp = other.nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = other.endDate_;
			Timestamp timestamp4 = default(Timestamp);
			if (timestamp3 != null)
			{
				timestamp4 = timestamp3.Clone();
			}
			endDate_ = timestamp4;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004601")]
		[Cpp2IlInjected.Address(RVA = "0x17FE800", Offset = "0x17FD200", VA = "0x1817FE800", Slot = "10")]
		[DebuggerNonUserCode]
		public FishSpawningInVillage Clone()
		{
			//Discarded unreachable code: IL_0065
			//IL_0030: Expected O, but got I4
			FishSpawningInVillage fishSpawningInVillage = new FishSpawningInVillage();
			int num = (fishSpawningInVillage.recurringEventItemID_ = recurringEventItemID_);
			Timestamp timestamp = nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			fishSpawningInVillage.nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = endDate_;
			Timestamp timestamp4 = default(Timestamp);
			if (timestamp3 != null)
			{
				timestamp4 = timestamp3.Clone();
			}
			fishSpawningInVillage.endDate_ = timestamp4;
			UnknownFieldSet unknownFieldSet = (fishSpawningInVillage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fishSpawningInVillage;
		}

		[Cpp2IlInjected.Token(Token = "0x6004608")]
		[Cpp2IlInjected.Address(RVA = "0x17FE9E0", Offset = "0x17FD3E0", VA = "0x1817FE9E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)recurringEventItemID_ == (IntPtr)typeof(FishSpawningInVillage).TypeHandle && object.Equals(nextOccurrence_, other) && object.Equals(endDate_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004609")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFD0", Offset = "0x7AD9D0", VA = "0x1807AEFD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FishSpawningInVillage other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.recurringEventItemID_;
				if (recurringEventItemID_ == num)
				{
					Timestamp objB = other.nextOccurrence_;
					if (object.Equals(nextOccurrence_, objB))
					{
						Timestamp objB2 = other.endDate_;
						if (object.Equals(endDate_, objB2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600460A")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC70", Offset = "0x7AE670", VA = "0x1807AFC70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (recurringEventItemID_ != 0)
				{
				}
				Timestamp timestamp = nextOccurrence_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				Timestamp timestamp2 = endDate_;
				if (timestamp2 != null)
				{
					int hashCode2 = timestamp2.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600460B")]
		[Cpp2IlInjected.Address(RVA = "0x17FFFE0", Offset = "0x17FE9E0", VA = "0x1817FFFE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600460C")]
		[Cpp2IlInjected.Address(RVA = "0x7B03B0", Offset = "0x7AEDB0", VA = "0x1807B03B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005c
			if (recurringEventItemID_ != 0)
			{
				int value = recurringEventItemID_;
				output.WriteInt32(value);
			}
			if ((long)nextOccurrence_ != 0)
			{
				Timestamp value2 = nextOccurrence_;
				output.WriteMessage(value2);
			}
			if ((long)endDate_ != 0)
			{
				Timestamp value3 = endDate_;
				output.WriteMessage(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600460D")]
		[Cpp2IlInjected.Address(RVA = "0x17FE700", Offset = "0x17FD100", VA = "0x1817FE700", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = recurringEventItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				Timestamp timestamp = nextOccurrence_;
				if (timestamp != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(timestamp);
					num4++;
					num2 += num4;
				}
				Timestamp timestamp2 = endDate_;
				if (timestamp2 != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(timestamp2);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600460E")]
		[Cpp2IlInjected.Address(RVA = "0x17FF8D0", Offset = "0x17FE2D0", VA = "0x1817FF8D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishSpawningInVillage other)
		{
			//Discarded unreachable code: IL_00ab
			if (other == null)
			{
				return;
			}
			int num = other.recurringEventItemID_;
			if (num != 0)
			{
				recurringEventItemID_ = num;
			}
			if ((long)other.nextOccurrence_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (nextOccurrence_ == null)
				{
					Timestamp timestamp = (nextOccurrence_ = new Timestamp());
					timestamp2 = nextOccurrence_;
				}
				Timestamp other2 = other.nextOccurrence_;
				timestamp2.MergeFrom(other2);
			}
			if ((long)other.endDate_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (endDate_ == null)
				{
					Timestamp timestamp3 = (endDate_ = new Timestamp());
					timestamp4 = endDate_;
				}
				Timestamp other3 = other.endDate_;
				timestamp4.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600460F")]
		[Cpp2IlInjected.Address(RVA = "0x17FF790", Offset = "0x17FE190", VA = "0x1817FF790", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num2 = (recurringEventItemID_ = input.ReadInt32());
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 18)
			{
				Timestamp builder = default(Timestamp);
				if (nextOccurrence_ == null)
				{
					timestamp = (nextOccurrence_ = new Timestamp());
					builder = nextOccurrence_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 26)
			{
				Timestamp builder2 = default(Timestamp);
				if (endDate_ == null)
				{
					Timestamp timestamp2 = (endDate_ = new Timestamp());
					builder2 = endDate_;
				}
				input.ReadMessage(builder2);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004610")]
		[Cpp2IlInjected.Address(RVA = "0x17FF2B0", Offset = "0x17FDCB0", VA = "0x1817FF2B0", Slot = "11")]
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
					Timestamp timestamp = endDate_;
				}
				Timestamp timestamp2 = nextOccurrence_;
			}
			int num2 = recurringEventItemID_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004611")]
		[Cpp2IlInjected.Address(RVA = "0x17FFEE0", Offset = "0x17FE8E0", VA = "0x1817FFEE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0032
			//IL_0021: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						endDate_ = (Timestamp)num2;
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
			object obj = default(object);
			recurringEventItemID_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x6004612")]
		[Cpp2IlInjected.Address(RVA = "0x7AEEB0", Offset = "0x7AD8B0", VA = "0x1807AEEB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004615")]
		[Cpp2IlInjected.Address(RVA = "0x17FEAB0", Offset = "0x17FD4B0", VA = "0x1817FEAB0")]
		public void Execute(in World world, ITransactionContext context, Random random)
		{
			//Discarded unreachable code: IL_01b6
			//IL_0076: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			int num = 0;
			ItemDatabase itemDatabase = ItemDatabase;
			int num2 = recurringEventItemID_;
			FishSpawningInVillageRecurringEventItemData fishSpawningInVillageRecurringEventItemData = default(FishSpawningInVillageRecurringEventItemData);
			OptionalField location_ = fishSpawningInVillageRecurringEventItemData.location_;
			int num3 = 0;
			if ((location_.useField_ ? 1 : 0) == num3)
			{
				ICollection<Village.Types.VillageArea> values = (ICollection<Village.Types.VillageArea>)((MapField<TKey, TValue>)(object)world.Section.village_.areas_).get_Values();
				Func<Village.Types.VillageArea, bool> _003C_003E9__42_ = _003C_003Ec._003C_003E9__42_0;
				if (_003C_003E9__42_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Village.Types.VillageArea x) => x.unlocked_);
				}
				IEnumerable<Village.Types.VillageArea> enumerable = (IEnumerable<Village.Types.VillageArea>)Enumerable.Where<Village.Types.VillageArea>((IEnumerable<>)values, (Func<, >)(object)_003C_003E9__42_);
				Func<Village.Types.VillageArea, int> func = (Func<Village.Types.VillageArea, int>)(object)new Func<T, TResult>(GetNumberOfNormalBodiesOfWaterInArea);
				int num4 = 0;
				int num5 = Enumerable.Sum<Village.Types.VillageArea>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			}
			Village village_ = world.Section.village_;
			OptionalField location_2 = fishSpawningInVillageRecurringEventItemData.location_;
			MapField<int, Village.Types.VillageArea> areas_ = village_.areas_;
			int villageArea2 = (int)location_2.VillageArea;
			RepeatedField<BodyOfWater> bodiesOfWater_ = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)areas_)[(TKey)villageArea2]).bodiesOfWater_;
			Func<BodyOfWater, bool> _003C_003E9__42_2 = _003C_003Ec._003C_003E9__42_2;
			if (_003C_003E9__42_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BodyOfWater x) => (IntPtr)x.requestedFishItemID_ == (IntPtr)"{il2cpp field on {'constant11' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}");
			}
			int num6 = Enumerable.Count<BodyOfWater>((IEnumerable<>)(object)bodiesOfWater_, (Func<, >)(object)_003C_003E9__42_2);
			MapField<uint, PendingFish> pendingFishes_ = world.Section.pendingFishes_;
			OptionalField location_3 = fishSpawningInVillageRecurringEventItemData.location_;
			OptionalField eventLocation = location_3;
			ICollection<PendingFish> values2 = (ICollection<PendingFish>)((MapField<TKey, TValue>)(object)pendingFishes_).get_Values();
			Func<PendingFish, bool> func2 = (Func<PendingFish, bool>)(object)(Func<T, TResult>)delegate(PendingFish pendingFish)
			{
				//Discarded unreachable code: IL_0021
				if (pendingFish.isSpecific_)
				{
					int num9 = 0;
				}
				OptionalField optionalLocation = eventLocation;
				ActivityDataLocationFilter location_4 = pendingFish.location_;
				return OptionallyMatchVillageArea(optionalLocation, location_4);
			};
			int num7 = Enumerable.Count<PendingFish>((IEnumerable<>)values2, (Func<, >)(object)func2);
			int maxNumberOfPendingFishes_ = fishSpawningInVillageRecurringEventItemData.maxNumberOfPendingFishes_;
			if (num7 < num7)
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				MapField<int, Village.Types.VillageArea> areas_2 = world.Section.village_.areas_;
				VillageAreaType locationFromEvent = FishSpawningInVillage.GetLocationFromEvent(random, fishSpawningInVillageRecurringEventItemData, (MapField<, >)(object)areas_2);
				string currentWeather_ = world.Section.currentWeather_;
				FishRippleRarity fishRippleRarity = default(FishRippleRarity);
				int rarity_ = (int)fishRippleRarity;
				PendingFish pendingFish2 = new PendingFish();
				pendingFish2.rarity_ = (FishRippleRarity)rarity_;
				ActivityDataLocationFilter activityDataLocationFilter = (pendingFish2.location_ = new ActivityDataLocationFilter());
				ProfileWorld section = world.Section;
				IWorldEventDispatcher dispatcher = world.dispatcher;
				uint num8 = section.AddPendingFish(pendingFish2, dispatcher);
			}
			[Cpp2IlInjected.Token(Token = "0x600461E")]
			[Cpp2IlInjected.Address(RVA = "0x1800040", Offset = "0x17FEA40", VA = "0x181800040")]
			static int GetNumberOfNormalBodiesOfWaterInArea(Village.Types.VillageArea villageArea)
			{
				//Discarded unreachable code: IL_002e
				RepeatedField<BodyOfWater> bodiesOfWater_2 = villageArea.bodiesOfWater_;
				Func<BodyOfWater, bool> _003C_003E9__42_3 = _003C_003Ec._003C_003E9__42_2;
				if (_003C_003E9__42_3 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BodyOfWater x) => (IntPtr)x.requestedFishItemID_ == (IntPtr)"{il2cpp field on {'constant11' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}");
				}
				return Enumerable.Count<BodyOfWater>((IEnumerable<>)(object)bodiesOfWater_2, (Func<, >)(object)_003C_003E9__42_3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004616")]
		[Cpp2IlInjected.Address(RVA = "0x17FF670", Offset = "0x17FE070", VA = "0x1817FF670")]
		public TimeSpan GetMaxIntervalToFullyExecute(in World world)
		{
			//Discarded unreachable code: IL_002a
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected I4, but got Unknown
			int num = 0;
			ItemDatabase itemDatabase = ItemDatabase;
			int num2 = recurringEventItemID_;
			FishSpawningInVillageRecurringEventItemData fishSpawningInVillageRecurringEventItemData = default(FishSpawningInVillageRecurringEventItemData);
			TimeSpan maxTimeBetweenExecutions = fishSpawningInVillageRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
			int num3 = fishSpawningInVillageRecurringEventItemData.maxNumberOfPendingFishes_ * maxTimeBetweenExecutions;
			return maxTimeBetweenExecutions;
		}

		[Cpp2IlInjected.Token(Token = "0x6004617")]
		[Cpp2IlInjected.Address(RVA = "0x17FFA80", Offset = "0x17FE480", VA = "0x1817FFA80")]
		private static FishRippleRarity SelectWeightedRandomValidFishingRippleRarity(FishingData fishingData, Random random, DateTime localTime, VillageAreaType location, string weather)
		{
			//Discarded unreachable code: IL_0102
			//IL_000f: Expected O, but got I4
			string weather2 = (string)0;
			int num = 0;
			ItemDatabase itemDatabase = ItemDatabase;
			Func<FishingDataItemData, bool> _003C_003E9__44_ = _003C_003Ec._003C_003E9__44_0;
			if (_003C_003E9__44_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishingDataItemData fish) => !fish.isHidden_);
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			IEnumerable<FishingDataItemData> enumerable2 = (IEnumerable<FishingDataItemData>)Enumerable.Where<FishingDataItemData>(enumerable, (Func<, >)(object)_003C_003E9__44_);
			Func<FishingDataItemData, bool> func = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData fish)
			{
				//Discarded unreachable code: IL_000f
				VillageAreaType location2 = location;
				return fish.IsSpawnableInLocation(location2);
			};
			IEnumerable<FishingDataItemData> enumerable3 = (IEnumerable<FishingDataItemData>)Enumerable.Where<FishingDataItemData>((IEnumerable<>)enumerable2, (Func<, >)(object)func);
			Func<FishingDataItemData, bool> func2 = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData fish)
			{
				//Discarded unreachable code: IL_000f
				DateTime localTime2 = localTime;
				return fish.CanAppearAtLocalTime(localTime2);
			};
			IEnumerable<FishingDataItemData> enumerable4 = (IEnumerable<FishingDataItemData>)Enumerable.Where<FishingDataItemData>((IEnumerable<>)enumerable3, (Func<, >)(object)func2);
			Func<FishingDataItemData, bool> func3 = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData fish)
			{
				//Discarded unreachable code: IL_000f
				string weather3 = weather2;
				return fish.CanAppearInWeather(weather3);
			};
			IEnumerable<FishingDataItemData> validFish = (IEnumerable<FishingDataItemData>)Enumerable.Where<FishingDataItemData>((IEnumerable<>)enumerable4, (Func<, >)(object)func3);
			RepeatedField<FishingData.Types.FishRippleRarityData> rippleRarityData_ = fishingData.rippleRarityData_;
			Func<FishingData.Types.FishRippleRarityData, bool> func4 = (Func<FishingData.Types.FishRippleRarityData, bool>)(object)(Func<T, TResult>)delegate(FishingData.Types.FishRippleRarityData x)
			{
				//Discarded unreachable code: IL_006f
				FishingData fishingData2 = fishingData;
				FishRippleRarity rippleRarity_ = x.rippleRarity_;
				IEnumerable<FishingData.Types.FishRarityData> rarityContents = (IEnumerable<FishingData.Types.FishRarityData>)fishingData2.GetRarityContents(rippleRarity_);
				Func<FishingData.Types.FishRarityData, FishRarity> _003C_003E9__44_2 = _003C_003Ec._003C_003E9__44_6;
				if (_003C_003E9__44_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishingData.Types.FishRarityData y) => y.fishRarity_);
				}
				IEnumerable<FishRarity> allowedFishRarities = (IEnumerable<FishRarity>)Enumerable.Select<FishingData.Types.FishRarityData, FishRarity>((IEnumerable<>)rarityContents, (Func<, >)(object)_003C_003E9__44_2);
				IEnumerable<FishingDataItemData> cpp2il__autoParamName__idx_ = validFish;
				Func<FishingDataItemData, bool> cpp2il__autoParamName__idx_2 = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData fish)
				{
					//Discarded unreachable code: IL_0014
					FishRarity rarity_ = fish.rarity_;
					return Enumerable.Contains<FishRarity>((IEnumerable<>)allowedFishRarities, rarity_);
				};
				return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<FishingDataItemData>((Func<, >)(object)cpp2il__autoParamName__idx_2);
			};
			IEnumerable<FishingData.Types.FishRippleRarityData> enumerable5 = (IEnumerable<FishingData.Types.FishRippleRarityData>)Enumerable.Where<FishingData.Types.FishRippleRarityData>((IEnumerable<>)(object)rippleRarityData_, (Func<, >)(object)func4);
			Func<FishingData.Types.FishRippleRarityData, int> func5 = default(Func<FishingData.Types.FishRippleRarityData, int>);
			if (_003C_003Ec._003C_003E9__44_5 == null)
			{
				func5 = (Func<FishingData.Types.FishRippleRarityData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FishingData.Types.FishRippleRarityData f) => f.weight_));
			}
			return RewardUtil.WeightedRandom<FishingData.Types.FishRippleRarityData>((IEnumerable<>)enumerable5, random, (Func<, >)(object)func5).rippleRarity_;
		}

		[Cpp2IlInjected.Token(Token = "0x6004618")]
		[Cpp2IlInjected.Address(RVA = "0x17FE8E0", Offset = "0x17FD2E0", VA = "0x1817FE8E0")]
		private static int CountMatchingPendingFishForLocation(MapField<uint, PendingFish> pendingFishes, OptionalField eventLocation)
		{
			//Discarded unreachable code: IL_0029
			ICollection<PendingFish> values = (ICollection<PendingFish>)((MapField<TKey, TValue>)(object)pendingFishes).get_Values();
			Func<PendingFish, bool> func = (Func<PendingFish, bool>)(object)(Func<T, TResult>)delegate(PendingFish pendingFish)
			{
				//Discarded unreachable code: IL_0021
				if (pendingFish.isSpecific_)
				{
					int num = 0;
				}
				OptionalField optionalLocation = eventLocation;
				ActivityDataLocationFilter location_ = pendingFish.location_;
				return OptionallyMatchVillageArea(optionalLocation, location_);
			};
			return Enumerable.Count<PendingFish>((IEnumerable<>)values, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6004619")]
		[Cpp2IlInjected.Address(RVA = "0x17FF390", Offset = "0x17FDD90", VA = "0x1817FF390")]
		private static VillageAreaType GetLocationFromEvent(Random random, FishSpawningInVillageRecurringEventItemData recurringEventData, MapField<int, Village.Types.VillageArea> villageAreasMap)
		{
			OptionalField location_ = recurringEventData.location_;
			if (!location_.useField_)
			{
				Func<KeyValuePair<int, Village.Types.VillageArea>, bool> _003C_003E9__46_ = _003C_003Ec._003C_003E9__46_0;
				if (_003C_003E9__46_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				IEnumerable<KeyValuePair<int, Village.Types.VillageArea>> enumerable = (IEnumerable<KeyValuePair<int, Village.Types.VillageArea>>)Enumerable.Where<KeyValuePair<int, Village.Types.VillageArea>>((IEnumerable<>)(object)villageAreasMap, (Func<, >)(object)_003C_003E9__46_);
				Func<KeyValuePair<int, Village.Types.VillageArea>, VillageAreaType> func = default(Func<KeyValuePair<int, Village.Types.VillageArea>, VillageAreaType>);
				if (_003C_003Ec._003C_003E9__46_1 == null)
				{
					func = (Func<KeyValuePair<int, Village.Types.VillageArea>, VillageAreaType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				IEnumerable<KeyValuePair<int, Village.Types.VillageArea>> enumerable2 = (IEnumerable<KeyValuePair<int, Village.Types.VillageArea>>)Enumerable.Select<KeyValuePair<int, Village.Types.VillageArea>, VillageAreaType>((IEnumerable<>)enumerable, (Func<, >)(object)func);
				RepeatedField<VillageAreaType> exclusionList_ = recurringEventData.exclusionList_;
				VillageAreaType[] array = Enumerable.Except<VillageAreaType>((IEnumerable<>)enumerable2, (IEnumerable<>)(object)exclusionList_).ToArray<VillageAreaType>();
				int length = array.Length;
				int num = random.Next(length);
				return array[num];
			}
			VillageAreaType villageArea = location_.VillageArea;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600461A")]
		[Cpp2IlInjected.Address(RVA = "0x17FFA10", Offset = "0x17FE410", VA = "0x1817FFA10")]
		private static bool OptionallyMatchVillageArea(OptionalField optionalLocation, ActivityDataLocationFilter pendingFishLocation)
		{
			//Discarded unreachable code: IL_0029
			if (optionalLocation.useField_)
			{
				if (pendingFishLocation.locationTypeCase_ != ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea)
				{
					int num = 0;
				}
				int villageArea = (int)pendingFishLocation.VillageArea;
				VillageAreaType villageArea2 = optionalLocation.VillageArea;
				return villageArea == (int)villageArea2;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600461B")]
		[Cpp2IlInjected.Address(RVA = "0x1800180", Offset = "0x17FEB80", VA = "0x181800180")]
		static FishSpawningInVillage()
		{
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600461C")]
		[Cpp2IlInjected.Address(RVA = "0x17FFA00", Offset = "0x17FE400", VA = "0x1817FFA00", Slot = "19")]
		void IRecurringEvent.Execute(in World world, ITransactionContext context, Random random)
		{
			Execute(in world, context, random);
		}

		[Cpp2IlInjected.Token(Token = "0x600461D")]
		[Cpp2IlInjected.Address(RVA = "0x17FF670", Offset = "0x17FE070", VA = "0x1817FF670", Slot = "20")]
		TimeSpan IRecurringEvent.GetMaxIntervalToFullyExecute(in World world)
		{
			//Discarded unreachable code: IL_002a
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected I4, but got Unknown
			int num = 0;
			ItemDatabase itemDatabase = ItemDatabase;
			int num2 = recurringEventItemID_;
			FishSpawningInVillageRecurringEventItemData fishSpawningInVillageRecurringEventItemData = default(FishSpawningInVillageRecurringEventItemData);
			TimeSpan maxTimeBetweenExecutions = fishSpawningInVillageRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
			int num3 = fishSpawningInVillageRecurringEventItemData.maxNumberOfPendingFishes_ * maxTimeBetweenExecutions;
			return maxTimeBetweenExecutions;
		}
	}
}
