using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000849")]
	public sealed class RecurringEvent : IMessage<RecurringEvent>, IMessage, IEquatable<RecurringEvent>, IDeepCloneable<RecurringEvent>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200084A")]
		public enum EventDataOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4002144")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002145")]
			ItemSpawningInVillage,
			[Cpp2IlInjected.Token(Token = "0x4002146")]
			FishSpawningInVillage,
			[Cpp2IlInjected.Token(Token = "0x4002147")]
			WildCropsSpawningInVillage,
			[Cpp2IlInjected.Token(Token = "0x4002148")]
			FlowerSpawningInVillage,
			[Cpp2IlInjected.Token(Token = "0x4002149")]
			FlowerDryingInVillage,
			[Cpp2IlInjected.Token(Token = "0x400214A")]
			ChooseVillageArea,
			[Cpp2IlInjected.Token(Token = "0x400214B")]
			MiningRockTurningSpecial,
			[Cpp2IlInjected.Token(Token = "0x400214C")]
			PendingFishUpgrade
		}

		[Cpp2IlInjected.Token(Token = "0x4002137")]
		private static readonly MessageParser<RecurringEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002138")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002139")]
		public const int ItemSpawningInVillageFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400213A")]
		public const int FishSpawningInVillageFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400213B")]
		public const int WildCropsSpawningInVillageFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400213C")]
		public const int FlowerSpawningInVillageFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400213D")]
		public const int FlowerDryingInVillageFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x400213E")]
		public const int ChooseVillageAreaFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x400213F")]
		public const int MiningRockTurningSpecialFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4002140")]
		public const int PendingFishUpgradeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002141")]
		private object eventData_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002142")]
		private EventDataOneofCase eventDataCase_;

		[Cpp2IlInjected.Token(Token = "0x17000B70")]
		[DebuggerNonUserCode]
		public static MessageParser<RecurringEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004574")]
			[Cpp2IlInjected.Address(RVA = "0x5C5AA0", Offset = "0x5C44A0", VA = "0x1805C5AA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B71")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004575")]
			[Cpp2IlInjected.Address(RVA = "0x5C5780", Offset = "0x5C4180", VA = "0x1805C5780")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B72")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004576")]
			[Cpp2IlInjected.Address(RVA = "0x5C5BC0", Offset = "0x5C45C0", VA = "0x1805C5BC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B73")]
		[DebuggerNonUserCode]
		public ItemSpawningInVillage ItemSpawningInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x600457A")]
			[Cpp2IlInjected.Address(RVA = "0x5C59E0", Offset = "0x5C43E0", VA = "0x1805C59E0")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.ItemSpawningInVillage)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600457B")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				eventData_ = value;
				bool flag = (byte)(eventDataCase_ = ((value != null) ? EventDataOneofCase.ItemSpawningInVillage : EventDataOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B74")]
		[DebuggerNonUserCode]
		public FishSpawningInVillage FishSpawningInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x600457C")]
			[Cpp2IlInjected.Address(RVA = "0x5C58C0", Offset = "0x5C42C0", VA = "0x1805C58C0")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.FishSpawningInVillage)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600457D")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				eventData_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B75")]
		[DebuggerNonUserCode]
		public WildCropsSpawningInVillage WildCropsSpawningInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x600457E")]
			[Cpp2IlInjected.Address(RVA = "0x5C5B60", Offset = "0x5C4560", VA = "0x1805C5B60")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.WildCropsSpawningInVillage)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600457F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				eventData_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B76")]
		[DebuggerNonUserCode]
		public FlowerSpawningInVillage FlowerSpawningInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6004580")]
			[Cpp2IlInjected.Address(RVA = "0x5C5980", Offset = "0x5C4380", VA = "0x1805C5980")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.FlowerSpawningInVillage)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004581")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				eventData_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B77")]
		[DebuggerNonUserCode]
		public FlowerDryingInVillage FlowerDryingInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6004582")]
			[Cpp2IlInjected.Address(RVA = "0x5C5920", Offset = "0x5C4320", VA = "0x1805C5920")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.FlowerDryingInVillage)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004583")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				eventData_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B78")]
		[DebuggerNonUserCode]
		public ChooseVillageArea ChooseVillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6004584")]
			[Cpp2IlInjected.Address(RVA = "0x5C5720", Offset = "0x5C4120", VA = "0x1805C5720")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.ChooseVillageArea)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004585")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				eventData_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B79")]
		[DebuggerNonUserCode]
		public MiningRockTurningSpecial MiningRockTurningSpecial
		{
			[Cpp2IlInjected.Token(Token = "0x6004586")]
			[Cpp2IlInjected.Address(RVA = "0x5C5A40", Offset = "0x5C4440", VA = "0x1805C5A40")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.MiningRockTurningSpecial)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004587")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E10", Offset = "0x5C4810", VA = "0x1805C5E10")]
			set
			{
				eventData_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7A")]
		[DebuggerNonUserCode]
		public PendingFishUpgrade PendingFishUpgrade
		{
			[Cpp2IlInjected.Token(Token = "0x6004588")]
			[Cpp2IlInjected.Address(RVA = "0x5C5B00", Offset = "0x5C4500", VA = "0x1805C5B00")]
			get
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.PendingFishUpgrade)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004589")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E50", Offset = "0x5C4850", VA = "0x1805C5E50")]
			set
			{
				eventData_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7B")]
		[DebuggerNonUserCode]
		public EventDataOneofCase EventDataCase
		{
			[Cpp2IlInjected.Token(Token = "0x600458A")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return eventDataCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B7C")]
		public IRecurringEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6004599")]
			[Cpp2IlInjected.Address(RVA = "0x5C5850", Offset = "0x5C4250", VA = "0x1805C5850")]
			get
			{
				if (eventData_ == null)
				{
					int num = 0;
				}
				while ((object)typeof(IRecurringEvent).TypeHandle != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004577")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public RecurringEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004578")]
		[Cpp2IlInjected.Address(RVA = "0x5C54B0", Offset = "0x5C3EB0", VA = "0x1805C54B0")]
		[DebuggerNonUserCode]
		public RecurringEvent(RecurringEvent other)
		{
			//IL_00cb: Expected I4, but got O
			if (other.eventDataCase_ <= EventDataOneofCase.MiningRockTurningSpecial)
			{
				bool flag = (byte)(eventDataCase_ = (((eventData_ = other.ItemSpawningInVillage.Clone()) != null) ? EventDataOneofCase.ItemSpawningInVillage : EventDataOneofCase.None)) != 0;
				FishSpawningInVillage fishSpawningInVillage = (FishSpawningInVillage)(eventData_ = other.FishSpawningInVillage.Clone());
				WildCropsSpawningInVillage wildCropsSpawningInVillage = (WildCropsSpawningInVillage)(eventData_ = other.WildCropsSpawningInVillage.Clone());
				FlowerSpawningInVillage flowerSpawningInVillage = (FlowerSpawningInVillage)(eventData_ = other.FlowerSpawningInVillage.Clone());
				FlowerDryingInVillage flowerDryingInVillage = (FlowerDryingInVillage)(eventData_ = other.FlowerDryingInVillage.Clone());
				ChooseVillageArea chooseVillageArea = (ChooseVillageArea)(eventData_ = other.ChooseVillageArea.Clone());
				MiningRockTurningSpecial miningRockTurningSpecial = (MiningRockTurningSpecial)(eventData_ = other.MiningRockTurningSpecial.Clone());
				eventDataCase_ = (EventDataOneofCase)(eventData_ = other.PendingFishUpgrade.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004579")]
		[Cpp2IlInjected.Address(RVA = "0x5C3350", Offset = "0x5C1D50", VA = "0x1805C3350", Slot = "10")]
		[DebuggerNonUserCode]
		public RecurringEvent Clone()
		{
			return new RecurringEvent(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600458B")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearEventData()
		{
			//IL_0010: Expected O, but got I4
			eventData_ = (eventDataCase_ = EventDataOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600458C")]
		[Cpp2IlInjected.Address(RVA = "0x5C3840", Offset = "0x5C2240", VA = "0x1805C3840", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((RecurringEvent)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600458D")]
		[Cpp2IlInjected.Address(RVA = "0x5C38A0", Offset = "0x5C22A0", VA = "0x1805C38A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RecurringEvent other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (eventDataCase_ == EventDataOneofCase.ItemSpawningInVillage)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
						goto IL_0153;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.eventDataCase_ == EventDataOneofCase.ItemSpawningInVillage)
				{
					obj2 = other.eventData_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					FishSpawningInVillage fishSpawningInVillage = FishSpawningInVillage;
					FishSpawningInVillage fishSpawningInVillage2 = other.FishSpawningInVillage;
					if (object.Equals(fishSpawningInVillage, fishSpawningInVillage2))
					{
						WildCropsSpawningInVillage wildCropsSpawningInVillage = WildCropsSpawningInVillage;
						WildCropsSpawningInVillage wildCropsSpawningInVillage2 = other.WildCropsSpawningInVillage;
						if (object.Equals(wildCropsSpawningInVillage, wildCropsSpawningInVillage2))
						{
							FlowerSpawningInVillage flowerSpawningInVillage = FlowerSpawningInVillage;
							FlowerSpawningInVillage flowerSpawningInVillage2 = other.FlowerSpawningInVillage;
							if (object.Equals(flowerSpawningInVillage, flowerSpawningInVillage2))
							{
								FlowerDryingInVillage flowerDryingInVillage = FlowerDryingInVillage;
								FlowerDryingInVillage flowerDryingInVillage2 = other.FlowerDryingInVillage;
								if (object.Equals(flowerDryingInVillage, flowerDryingInVillage2))
								{
									ChooseVillageArea chooseVillageArea = ChooseVillageArea;
									ChooseVillageArea chooseVillageArea2 = other.ChooseVillageArea;
									if (object.Equals(chooseVillageArea, chooseVillageArea2))
									{
										MiningRockTurningSpecial miningRockTurningSpecial = MiningRockTurningSpecial;
										MiningRockTurningSpecial miningRockTurningSpecial2 = other.MiningRockTurningSpecial;
										if (object.Equals(miningRockTurningSpecial, miningRockTurningSpecial2))
										{
											PendingFishUpgrade pendingFishUpgrade = PendingFishUpgrade;
											PendingFishUpgrade pendingFishUpgrade2 = other.PendingFishUpgrade;
											if (object.Equals(pendingFishUpgrade, pendingFishUpgrade2))
											{
												EventDataOneofCase eventDataOneofCase = other.eventDataCase_;
												if (eventDataCase_ == eventDataOneofCase)
												{
													UnknownFieldSet unknownFields = other._unknownFields;
													bool flag = object.Equals(_unknownFields, unknownFields);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0153;
			IL_0153:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600458E")]
		[Cpp2IlInjected.Address(RVA = "0x5C3BF0", Offset = "0x5C25F0", VA = "0x1805C3BF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0126
			while (true)
			{
				EventDataOneofCase eventDataOneofCase = eventDataCase_;
				int num = 0;
				if (eventDataOneofCase == EventDataOneofCase.ItemSpawningInVillage)
				{
					object obj = eventData_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (eventDataOneofCase != EventDataOneofCase.FishSpawningInVillage)
				{
					continue;
				}
				object obj2 = eventData_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (eventDataCase_ != EventDataOneofCase.WildCropsSpawningInVillage)
					{
						continue;
					}
					object obj3 = eventData_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (eventDataCase_ != EventDataOneofCase.FlowerSpawningInVillage)
						{
							continue;
						}
						object obj4 = eventData_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (eventDataCase_ != EventDataOneofCase.FlowerDryingInVillage)
							{
								continue;
							}
							object obj5 = eventData_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (eventDataCase_ != EventDataOneofCase.ChooseVillageArea)
								{
									continue;
								}
								object obj6 = eventData_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (eventDataCase_ != EventDataOneofCase.MiningRockTurningSpecial)
									{
										continue;
									}
									object obj7 = eventData_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (eventDataCase_ == EventDataOneofCase.PendingFishUpgrade)
										{
											object obj8 = eventData_;
											if (obj8 == null)
											{
												break;
											}
											int hashCode8 = obj8.GetHashCode();
										}
										UnknownFieldSet unknownFields = _unknownFields;
										if (unknownFields != null)
										{
											int hashCode9 = unknownFields.GetHashCode();
										}
										return 1;
									}
								}
								throw new InvalidCastException();
							}
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600458F")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F50", Offset = "0x5C3950", VA = "0x1805C4F50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004590")]
		[Cpp2IlInjected.Address(RVA = "0x5C4FB0", Offset = "0x5C39B0", VA = "0x1805C4FB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0154
			//IL_002f: Expected O, but got I4
			while (true)
			{
				EventDataOneofCase eventDataOneofCase = eventDataCase_;
				int num = 0;
				if (eventDataOneofCase == EventDataOneofCase.ItemSpawningInVillage)
				{
					if (eventDataCase_ == EventDataOneofCase.ItemSpawningInVillage)
					{
						object obj = eventData_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (eventDataOneofCase != EventDataOneofCase.FishSpawningInVillage)
				{
					continue;
				}
				if (eventDataCase_ == EventDataOneofCase.FishSpawningInVillage)
				{
					object obj2 = eventData_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (eventDataCase_ != EventDataOneofCase.WildCropsSpawningInVillage)
				{
					continue;
				}
				if (eventDataCase_ == EventDataOneofCase.WildCropsSpawningInVillage)
				{
					object obj3 = eventData_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (eventDataCase_ != EventDataOneofCase.FlowerSpawningInVillage)
				{
					continue;
				}
				if (eventDataCase_ == EventDataOneofCase.FlowerSpawningInVillage)
				{
					object obj4 = eventData_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (eventDataCase_ != EventDataOneofCase.FlowerDryingInVillage)
				{
					continue;
				}
				if (eventDataCase_ == EventDataOneofCase.FlowerDryingInVillage)
				{
					object obj5 = eventData_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (eventDataCase_ != EventDataOneofCase.ChooseVillageArea)
				{
					continue;
				}
				if (eventDataCase_ == EventDataOneofCase.ChooseVillageArea)
				{
					object obj6 = eventData_;
					if (obj6 != null && obj6 == null)
					{
						break;
					}
				}
				if (eventDataCase_ != EventDataOneofCase.MiningRockTurningSpecial)
				{
					continue;
				}
				if (eventDataCase_ == EventDataOneofCase.MiningRockTurningSpecial)
				{
					object obj7 = eventData_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (eventDataCase_ == EventDataOneofCase.PendingFishUpgrade && eventDataCase_ == EventDataOneofCase.PendingFishUpgrade)
				{
					object obj8 = eventData_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004591")]
		[Cpp2IlInjected.Address(RVA = "0x5C2E00", Offset = "0x5C1800", VA = "0x1805C2E00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (eventDataCase_ == EventDataOneofCase.ItemSpawningInVillage)
			{
				if (eventDataCase_ == EventDataOneofCase.ItemSpawningInVillage)
				{
					object obj = eventData_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (eventDataCase_ == EventDataOneofCase.FishSpawningInVillage)
			{
				if (eventDataCase_ != EventDataOneofCase.FishSpawningInVillage)
				{
				}
				object obj2 = eventData_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (eventDataCase_ == EventDataOneofCase.WildCropsSpawningInVillage)
			{
				if (eventDataCase_ != EventDataOneofCase.WildCropsSpawningInVillage)
				{
				}
				object obj3 = eventData_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (eventDataCase_ == EventDataOneofCase.FlowerSpawningInVillage)
			{
				if (eventDataCase_ != EventDataOneofCase.FlowerSpawningInVillage)
				{
				}
				object obj4 = eventData_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (eventDataCase_ == EventDataOneofCase.FlowerDryingInVillage)
			{
				if (eventDataCase_ != EventDataOneofCase.FlowerDryingInVillage)
				{
				}
				object obj5 = eventData_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (eventDataCase_ == EventDataOneofCase.ChooseVillageArea)
			{
				if (eventDataCase_ != EventDataOneofCase.ChooseVillageArea)
				{
				}
				object obj6 = eventData_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (eventDataCase_ == EventDataOneofCase.MiningRockTurningSpecial)
			{
				if (eventDataCase_ != EventDataOneofCase.MiningRockTurningSpecial)
				{
				}
				object obj7 = eventData_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			if (eventDataCase_ == EventDataOneofCase.PendingFishUpgrade)
			{
				if (eventDataCase_ == EventDataOneofCase.PendingFishUpgrade)
				{
					object obj8 = eventData_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num9 = default(int);
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

		[Cpp2IlInjected.Token(Token = "0x6004592")]
		[Cpp2IlInjected.Address(RVA = "0x5C4070", Offset = "0x5C2A70", VA = "0x1805C4070", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RecurringEvent other)
		{
			//Discarded unreachable code: IL_0067, IL_0070, IL_0087, IL_009d, IL_00b4, IL_00ca, IL_00e1, IL_00f7, IL_010e, IL_0124, IL_013b, IL_0151, IL_0168, IL_017e, IL_0195
			//IL_0087: Expected I4, but got O
			//IL_00b4: Expected I4, but got O
			//IL_00e1: Expected I4, but got O
			//IL_010e: Expected I4, but got O
			//IL_013b: Expected I4, but got O
			//IL_0168: Expected I4, but got O
			//IL_0195: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.eventDataCase_ <= EventDataOneofCase.MiningRockTurningSpecial)
			{
				if (ItemSpawningInVillage == null)
				{
					bool flag = (byte)(eventDataCase_ = (((eventData_ = new ItemSpawningInVillage()) != null) ? EventDataOneofCase.ItemSpawningInVillage : EventDataOneofCase.None)) != 0;
				}
				ItemSpawningInVillage itemSpawningInVillage = ItemSpawningInVillage;
				ItemSpawningInVillage itemSpawningInVillage2 = other.ItemSpawningInVillage;
				itemSpawningInVillage.MergeFrom(itemSpawningInVillage2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004593")]
		[Cpp2IlInjected.Address(RVA = "0x5C4520", Offset = "0x5C2F20", VA = "0x1805C4520", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0066: Expected I4, but got O
			//IL_00b5: Expected I4, but got O
			//IL_0104: Expected I4, but got O
			//IL_015b: Expected I4, but got O
			//IL_01b3: Expected I4, but got O
			//IL_020a: Expected I4, but got O
			//IL_02b0: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						MiningRockTurningSpecial miningRockTurningSpecial = new MiningRockTurningSpecial();
						if (eventDataCase_ == EventDataOneofCase.MiningRockTurningSpecial)
						{
							if (eventDataCase_ != EventDataOneofCase.MiningRockTurningSpecial)
							{
							}
							object obj = eventData_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(miningRockTurningSpecial);
						eventData_ = miningRockTurningSpecial;
						eventDataCase_ = (EventDataOneofCase)miningRockTurningSpecial;
					}
					if (num != 66)
					{
						goto IL_02b0;
					}
					PendingFishUpgrade builder = new PendingFishUpgrade();
					if (eventDataCase_ == EventDataOneofCase.PendingFishUpgrade)
					{
						if (eventDataCase_ != EventDataOneofCase.PendingFishUpgrade)
						{
						}
						object obj2 = eventData_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					eventData_ = builder;
					eventDataCase_ = (EventDataOneofCase)typeof(PendingFishUpgrade).TypeHandle;
				}
				if (num == 42)
				{
					FlowerDryingInVillage builder2 = new FlowerDryingInVillage();
					if (eventDataCase_ == EventDataOneofCase.FlowerDryingInVillage)
					{
						if (eventDataCase_ != EventDataOneofCase.FlowerDryingInVillage)
						{
						}
						object obj3 = eventData_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					eventData_ = builder2;
					eventDataCase_ = (EventDataOneofCase)typeof(FlowerDryingInVillage).TypeHandle;
				}
				if ((long)typeof(FlowerDryingInVillage).TypeHandle != 50)
				{
					goto IL_02b0;
				}
				ChooseVillageArea builder3 = new ChooseVillageArea();
				if (eventDataCase_ == EventDataOneofCase.ChooseVillageArea)
				{
					if (eventDataCase_ != EventDataOneofCase.ChooseVillageArea)
					{
					}
					object obj4 = eventData_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				eventData_ = builder3;
				eventDataCase_ = (EventDataOneofCase)typeof(ChooseVillageArea).TypeHandle;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					WildCropsSpawningInVillage builder4 = new WildCropsSpawningInVillage();
					if (eventDataCase_ == EventDataOneofCase.WildCropsSpawningInVillage)
					{
						if (eventDataCase_ != EventDataOneofCase.WildCropsSpawningInVillage)
						{
						}
						object obj5 = eventData_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder4);
					eventData_ = builder4;
					eventDataCase_ = (EventDataOneofCase)typeof(WildCropsSpawningInVillage).TypeHandle;
				}
				if ((long)typeof(WildCropsSpawningInVillage).TypeHandle != 34)
				{
					goto IL_02b0;
				}
				FlowerSpawningInVillage builder5 = new FlowerSpawningInVillage();
				if (eventDataCase_ == EventDataOneofCase.FlowerSpawningInVillage)
				{
					if (eventDataCase_ != EventDataOneofCase.FlowerSpawningInVillage)
					{
					}
					object obj6 = eventData_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder5);
				eventData_ = builder5;
				eventDataCase_ = (EventDataOneofCase)typeof(FlowerSpawningInVillage).TypeHandle;
			}
			bool flag = default(bool);
			if ((long)typeof(FlowerSpawningInVillage).TypeHandle == 10)
			{
				ItemSpawningInVillage itemSpawningInVillage = new ItemSpawningInVillage();
				if (eventDataCase_ == EventDataOneofCase.ItemSpawningInVillage)
				{
					if (eventDataCase_ != EventDataOneofCase.ItemSpawningInVillage)
					{
					}
					object obj7 = eventData_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(itemSpawningInVillage);
				eventData_ = itemSpawningInVillage;
				flag = (byte)(eventDataCase_ = ((itemSpawningInVillage != null) ? EventDataOneofCase.ItemSpawningInVillage : EventDataOneofCase.None)) != 0;
			}
			if (flag)
			{
				FishSpawningInVillage builder6 = new FishSpawningInVillage();
				if (eventDataCase_ == EventDataOneofCase.FishSpawningInVillage)
				{
					if (eventDataCase_ != EventDataOneofCase.FishSpawningInVillage)
					{
					}
					object obj8 = eventData_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder6);
				eventData_ = builder6;
				eventDataCase_ = (EventDataOneofCase)typeof(FishSpawningInVillage).TypeHandle;
			}
			goto IL_02b0;
			IL_02b0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004594")]
		[Cpp2IlInjected.Address(RVA = "0x5C3AE0", Offset = "0x5C24E0", VA = "0x1805C3AE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 7)
			{
				ItemSpawningInVillage itemSpawningInVillage = ItemSpawningInVillage;
				FishSpawningInVillage fishSpawningInVillage = FishSpawningInVillage;
				WildCropsSpawningInVillage wildCropsSpawningInVillage = WildCropsSpawningInVillage;
				FlowerSpawningInVillage flowerSpawningInVillage = FlowerSpawningInVillage;
				FlowerDryingInVillage flowerDryingInVillage = FlowerDryingInVillage;
				ChooseVillageArea chooseVillageArea = ChooseVillageArea;
				MiningRockTurningSpecial miningRockTurningSpecial = MiningRockTurningSpecial;
				PendingFishUpgrade pendingFishUpgrade = PendingFishUpgrade;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004595")]
		[Cpp2IlInjected.Address(RVA = "0x5C4BF0", Offset = "0x5C35F0", VA = "0x1805C4BF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002a, IL_002e, IL_0032, IL_0033, IL_0037, IL_003b, IL_003c, IL_0040, IL_0044, IL_0045, IL_0049, IL_004d, IL_004e, IL_0052, IL_0056, IL_0057, IL_005b, IL_005f, IL_0060, IL_0064, IL_0068, IL_0069, IL_0075, IL_007b, IL_0081, IL_0087, IL_008d, IL_0093
			//IL_001a: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				eventData_ = num;
				bool flag = (byte)(eventDataCase_ = ((num != 0) ? EventDataOneofCase.ItemSpawningInVillage : EventDataOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004596")]
		[Cpp2IlInjected.Address(RVA = "0x5C3270", Offset = "0x5C1C70", VA = "0x1805C3270", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber <= 7)
			{
				int num = 0;
				eventData_ = num;
				eventDataCase_ = (EventDataOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004597")]
		[Cpp2IlInjected.Address(RVA = "0x5C3FC0", Offset = "0x5C29C0", VA = "0x1805C3FC0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "EventData"))
			{
				EventDataOneofCase eventDataOneofCase = eventDataCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004598")]
		[Cpp2IlInjected.Address(RVA = "0x5C32E0", Offset = "0x5C1CE0", VA = "0x1805C32E0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "EventData"))
			{
				eventData_ = (eventDataCase_ = EventDataOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600459A")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1DB0", VA = "0x1805C33B0")]
		public static RecurringEvent Create(IRecurringEventData recurringEventData)
		{
			//Discarded unreachable code: IL_00a3
			//IL_001b: Expected I4, but got O
			//IL_002b: Expected I4, but got O
			//IL_003b: Expected I4, but got O
			//IL_004b: Expected I4, but got O
			//IL_005b: Expected I4, but got O
			//IL_006b: Expected I4, but got O
			//IL_007b: Expected I4, but got O
			//IL_008b: Expected I4, but got O
			RecurringEvent recurringEvent = new RecurringEvent();
			RecurringEventType recurringEventType = default(RecurringEventType);
			if (recurringEventType <= RecurringEventType.PendingFishUpgrade)
			{
				ItemSpawningInVillage itemSpawningInVillage = new ItemSpawningInVillage();
				itemSpawningInVillage.recurringEventItemID_ = (int)itemSpawningInVillage;
				FishSpawningInVillage fishSpawningInVillage = new FishSpawningInVillage();
				fishSpawningInVillage.recurringEventItemID_ = (int)fishSpawningInVillage;
				WildCropsSpawningInVillage wildCropsSpawningInVillage = new WildCropsSpawningInVillage();
				wildCropsSpawningInVillage.recurringEventItemID_ = (int)wildCropsSpawningInVillage;
				FlowerSpawningInVillage flowerSpawningInVillage = new FlowerSpawningInVillage();
				flowerSpawningInVillage.recurringEventItemID_ = (int)flowerSpawningInVillage;
				FlowerDryingInVillage flowerDryingInVillage = new FlowerDryingInVillage();
				flowerDryingInVillage.recurringEventItemID_ = (int)flowerDryingInVillage;
				ChooseVillageArea chooseVillageArea = new ChooseVillageArea();
				chooseVillageArea.recurringEventItemID_ = (int)chooseVillageArea;
				MiningRockTurningSpecial miningRockTurningSpecial = new MiningRockTurningSpecial();
				miningRockTurningSpecial.recurringEventItemID_ = (int)miningRockTurningSpecial;
				PendingFishUpgrade pendingFishUpgrade = new PendingFishUpgrade();
				pendingFishUpgrade.recurringEventItemID_ = (int)pendingFishUpgrade;
				recurringEvent.eventData_ = pendingFishUpgrade;
				uint num = default(uint);
				recurringEvent.eventDataCase_ = (EventDataOneofCase)num;
				return recurringEvent;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600459B")]
		[Cpp2IlInjected.Address(RVA = "0x5C53A0", Offset = "0x5C3DA0", VA = "0x1805C53A0")]
		static RecurringEvent()
		{
			Func<RecurringEvent> func = default(Func<RecurringEvent>);
			_parser = (MessageParser<RecurringEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
