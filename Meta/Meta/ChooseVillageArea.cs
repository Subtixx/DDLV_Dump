using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000863")]
	public sealed class ChooseVillageArea : IMessage<ChooseVillageArea>, IMessage, IEquatable<ChooseVillageArea>, IDeepCloneable<ChooseVillageArea>, IMessageFieldAccessor, IRecurringEvent
	{
		[Cpp2IlInjected.Token(Token = "0x40021B1")]
		private static readonly MessageParser<ChooseVillageArea> _parser = (MessageParser<ChooseVillageArea>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ChooseVillageArea()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40021B2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40021B3")]
		public const int RecurringEventItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40021B4")]
		private int recurringEventItemID_;

		[Cpp2IlInjected.Token(Token = "0x40021B5")]
		public const int NextOccurrenceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40021B6")]
		private Timestamp nextOccurrence_;

		[Cpp2IlInjected.Token(Token = "0x40021B7")]
		public const int EndDateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40021B8")]
		private Timestamp endDate_;

		[Cpp2IlInjected.Token(Token = "0x40021B9")]
		public const int ChosenVillageAreaFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40021BA")]
		private VillageAreaType chosenVillageArea_;

		[Cpp2IlInjected.Token(Token = "0x17000BA2")]
		[DebuggerNonUserCode]
		public static MessageParser<ChooseVillageArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004681")]
			[Cpp2IlInjected.Address(RVA = "0x727240", Offset = "0x725C40", VA = "0x180727240")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004682")]
			[Cpp2IlInjected.Address(RVA = "0x727170", Offset = "0x725B70", VA = "0x180727170")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004683")]
			[Cpp2IlInjected.Address(RVA = "0x727300", Offset = "0x725D00", VA = "0x180727300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA5")]
		[DebuggerNonUserCode]
		public int RecurringEventItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004687")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recurringEventItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004688")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recurringEventItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA6")]
		[DebuggerNonUserCode]
		public Timestamp NextOccurrence
		{
			[Cpp2IlInjected.Token(Token = "0x6004689")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return nextOccurrence_;
			}
			[Cpp2IlInjected.Token(Token = "0x600468A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "16")]
			set
			{
				nextOccurrence_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA7")]
		[DebuggerNonUserCode]
		public Timestamp EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x600468B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x600468C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "18")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA8")]
		[DebuggerNonUserCode]
		public VillageAreaType ChosenVillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x600468D")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return chosenVillageArea_;
			}
			[Cpp2IlInjected.Token(Token = "0x600468E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				chosenVillageArea_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BA9")]
		public Item RecurringEventItem
		{
			[Cpp2IlInjected.Token(Token = "0x600469A")]
			[Cpp2IlInjected.Address(RVA = "0x7272A0", Offset = "0x725CA0", VA = "0x1807272A0", Slot = "14")]
			get
			{
				long num = Convert.ToInt64((uint)recurringEventItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004684")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ChooseVillageArea()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004685")]
		[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0")]
		[DebuggerNonUserCode]
		public ChooseVillageArea(ChooseVillageArea other)
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
			VillageAreaType villageAreaType = (chosenVillageArea_ = other.chosenVillageArea_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004686")]
		[Cpp2IlInjected.Address(RVA = "0x725D00", Offset = "0x724700", VA = "0x180725D00", Slot = "10")]
		[DebuggerNonUserCode]
		public ChooseVillageArea Clone()
		{
			//Discarded unreachable code: IL_0075
			//IL_0030: Expected O, but got I4
			ChooseVillageArea chooseVillageArea = new ChooseVillageArea();
			int num = (chooseVillageArea.recurringEventItemID_ = recurringEventItemID_);
			Timestamp timestamp = nextOccurrence_;
			int num2 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			chooseVillageArea.nextOccurrence_ = (Timestamp)num2;
			Timestamp timestamp3 = endDate_;
			Timestamp timestamp4 = default(Timestamp);
			if (timestamp3 != null)
			{
				timestamp4 = timestamp3.Clone();
			}
			chooseVillageArea.endDate_ = timestamp4;
			VillageAreaType villageAreaType = (chooseVillageArea.chosenVillageArea_ = chosenVillageArea_);
			UnknownFieldSet unknownFieldSet = (chooseVillageArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return chooseVillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x600468F")]
		[Cpp2IlInjected.Address(RVA = "0x725E70", Offset = "0x724870", VA = "0x180725E70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)recurringEventItemID_ == (IntPtr)typeof(ChooseVillageArea).TypeHandle && object.Equals(nextOccurrence_, other))
				{
					bool flag = object.Equals(endDate_, other);
					if (flag && chosenVillageArea_ == (flag ? VillageAreaType.Wetland : VillageAreaType.Beach))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004690")]
		[Cpp2IlInjected.Address(RVA = "0x725DE0", Offset = "0x7247E0", VA = "0x180725DE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChooseVillageArea other)
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
							VillageAreaType villageAreaType = other.chosenVillageArea_;
							if (chosenVillageArea_ == villageAreaType)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004691")]
		[Cpp2IlInjected.Address(RVA = "0x726880", Offset = "0x725280", VA = "0x180726880", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
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
				if (chosenVillageArea_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004692")]
		[Cpp2IlInjected.Address(RVA = "0x726E70", Offset = "0x725870", VA = "0x180726E70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004693")]
		[Cpp2IlInjected.Address(RVA = "0x726ED0", Offset = "0x7258D0", VA = "0x180726ED0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0065
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
			if (chosenVillageArea_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004694")]
		[Cpp2IlInjected.Address(RVA = "0x725B80", Offset = "0x724580", VA = "0x180725B80", Slot = "7")]
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
				VillageAreaType villageAreaType = chosenVillageArea_;
				if (villageAreaType != 0)
				{
					int num6 = CodedOutputStream.ComputeEnumSize((int)villageAreaType);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004695")]
		[Cpp2IlInjected.Address(RVA = "0x726A70", Offset = "0x725470", VA = "0x180726A70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChooseVillageArea other)
		{
			//Discarded unreachable code: IL_00c0
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
			VillageAreaType villageAreaType = other.chosenVillageArea_;
			if (villageAreaType != 0)
			{
				chosenVillageArea_ = villageAreaType;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004696")]
		[Cpp2IlInjected.Address(RVA = "0x726BA0", Offset = "0x7255A0", VA = "0x180726BA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					Timestamp timestamp = endDate_;
					if (timestamp == null)
					{
						Timestamp timestamp2 = (endDate_ = new Timestamp());
					}
					input.ReadMessage(timestamp);
				}
				if (num != 32)
				{
					goto IL_0091;
				}
				int num2 = (int)(chosenVillageArea_ = (VillageAreaType)input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (recurringEventItemID_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				Timestamp builder = default(Timestamp);
				if (nextOccurrence_ == null)
				{
					Timestamp timestamp3 = (nextOccurrence_ = new Timestamp());
					builder = nextOccurrence_;
				}
				input.ReadMessage(builder);
			}
			goto IL_0091;
			IL_0091:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004697")]
		[Cpp2IlInjected.Address(RVA = "0x726780", Offset = "0x725180", VA = "0x180726780", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num != 1)
					{
						goto IL_0029;
					}
					Timestamp timestamp = endDate_;
				}
				Timestamp timestamp2 = nextOccurrence_;
			}
			int num2 = recurringEventItemID_;
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004698")]
		[Cpp2IlInjected.Address(RVA = "0x726D10", Offset = "0x725710", VA = "0x180726D10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003e
			//IL_001b: Expected I4, but got O
			//IL_002d: Expected O, but got I4
			//IL_003d: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj = default(object);
						chosenVillageArea_ = (VillageAreaType)obj;
						break;
					}
					case 0:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							endDate_ = (Timestamp)num2;
							break;
						}
						throw new InvalidCastException();
					}
					}
					return;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj2 = default(object);
			recurringEventItemID_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004699")]
		[Cpp2IlInjected.Address(RVA = "0x725CB0", Offset = "0x7246B0", VA = "0x180725CB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				chosenVillageArea_ = VillageAreaType.Beach;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600469B")]
		[Cpp2IlInjected.Address(RVA = "0x725F40", Offset = "0x724940", VA = "0x180725F40")]
		public void Execute(in World world, ITransactionContext context, Random random)
		{
			//Discarded unreachable code: IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139, IL_013f
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected I4, but got Unknown
			//IL_0096: Expected O, but got I4
			int num;
			List<(VillageAreaType, IGrid, int)> list;
			bool flag = default(bool);
			bool flag2 = default(bool);
			ChooseVillageAreaRecurringEventItemData chooseVillageAreaRecurringEventItemData = default(ChooseVillageAreaRecurringEventItemData);
			Func<int, Item> func = default(Func<int, Item>);
			do
			{
				num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num2 = recurringEventItemID_;
				list = (List<(VillageAreaType, IGrid, int)>)(object)new List<T>();
				MapField<int, Village.Types.VillageArea> areas_ = world.Section.village_.areas_;
				if (!flag)
				{
					continue;
				}
				GridCollection gridCollection_ = world.Section.gridCollection_;
				while (!flag2)
				{
				}
				int maximumItemPerArea_ = chooseVillageAreaRecurringEventItemData.maximumItemPerArea_;
				RepeatedField<int> itemsToCheck_ = chooseVillageAreaRecurringEventItemData.itemsToCheck_;
				if (_003C_003Ec._003C_003E9__45_2 == null)
				{
					func = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle));
				}
				IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)(object)itemsToCheck_, (Func<, >)(object)func);
				maximumItemPerArea_ -= enumerable;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				((List<T>)(object)list).Add((T)num4);
			}
			while (num != 0);
			Func<(VillageAreaType, IGrid, int), int> func2 = default(Func<(VillageAreaType, IGrid, int), int>);
			if (_003C_003Ec._003C_003E9__45_0 == null)
			{
				func2 = (Func<(VillageAreaType, IGrid, int), int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			(VillageAreaType, IGrid, int)[] array = ((IEnumerable<>)Enumerable.OrderBy<(VillageAreaType, IGrid, int), int>((IEnumerable<>)list, (Func<, >)(object)func2)).ToArray<(VillageAreaType, IGrid, int)>();
			Func<(VillageAreaType, IGrid, int), int> func3 = default(Func<(VillageAreaType, IGrid, int), int>);
			if (_003C_003Ec._003C_003E9__45_1 == null)
			{
				func3 = (Func<(VillageAreaType, IGrid, int), int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			if (Enumerable.Sum<(VillageAreaType, IGrid, int)>((IEnumerable<>)(object)array, (Func<, >)(object)func3) != 0)
			{
				int num6 = 0;
				int num7 = 0;
				int length = array.Length;
				if (num7 < length)
				{
					num6++;
					num7 = num6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600469C")]
		[Cpp2IlInjected.Address(RVA = "0x726940", Offset = "0x725340", VA = "0x180726940")]
		public TimeSpan GetMaxIntervalToFullyExecute(in World world)
		{
			//Discarded unreachable code: IL_0019
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = recurringEventItemID_;
			ChooseVillageAreaRecurringEventItemData chooseVillageAreaRecurringEventItemData = default(ChooseVillageAreaRecurringEventItemData);
			return chooseVillageAreaRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
		}

		[Cpp2IlInjected.Token(Token = "0x600469D")]
		[Cpp2IlInjected.Address(RVA = "0x726FB0", Offset = "0x7259B0", VA = "0x180726FB0")]
		static ChooseVillageArea()
		{
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600469E")]
		[Cpp2IlInjected.Address(RVA = "0x726D00", Offset = "0x725700", VA = "0x180726D00", Slot = "19")]
		void IRecurringEvent.Execute(in World world, ITransactionContext context, Random random)
		{
			Execute(in world, context, random);
		}

		[Cpp2IlInjected.Token(Token = "0x600469F")]
		[Cpp2IlInjected.Address(RVA = "0x726940", Offset = "0x725340", VA = "0x180726940", Slot = "20")]
		TimeSpan IRecurringEvent.GetMaxIntervalToFullyExecute(in World world)
		{
			//Discarded unreachable code: IL_0019
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = recurringEventItemID_;
			ChooseVillageAreaRecurringEventItemData chooseVillageAreaRecurringEventItemData = default(ChooseVillageAreaRecurringEventItemData);
			return chooseVillageAreaRecurringEventItemData.intervalData_.GetMaxTimeBetweenExecutions();
		}
	}
}
