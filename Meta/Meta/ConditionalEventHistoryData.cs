using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;
using Meta.Missions;
using Meta.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008F7")]
	public sealed class ConditionalEventHistoryData : IMessage<ConditionalEventHistoryData>, IMessage, IEquatable<ConditionalEventHistoryData>, IDeepCloneable<ConditionalEventHistoryData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002451")]
		private static readonly MessageParser<ConditionalEventHistoryData> _parser = (MessageParser<ConditionalEventHistoryData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ConditionalEventHistoryData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002452")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002453")]
		public const int ActiveEventsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002454")]
		private static readonly MapField<int, ConditionalEventState>.Codec _map_activeEvents_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002455")]
		private readonly MapField<int, ConditionalEventState> activeEvents_ = (MapField<int, ConditionalEventState>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002456")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002457")]
		private ProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002458")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002459")]
		private List<ConditionalEventItemData> events = (List<ConditionalEventItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400245A")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x17000D3D")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalEventHistoryData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004DC4")]
			[Cpp2IlInjected.Address(RVA = "0x16865A0", Offset = "0x1684FA0", VA = "0x1816865A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DC5")]
			[Cpp2IlInjected.Address(RVA = "0x16864D0", Offset = "0x1684ED0", VA = "0x1816864D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D3F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004DC6")]
			[Cpp2IlInjected.Address(RVA = "0x1686600", Offset = "0x1685000", VA = "0x181686600", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D40")]
		[DebuggerNonUserCode]
		public MapField<int, ConditionalEventState> ActiveEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6004DCA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return activeEvents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC7")]
		[Cpp2IlInjected.Address(RVA = "0x1686410", Offset = "0x1684E10", VA = "0x181686410")]
		[DebuggerNonUserCode]
		public ConditionalEventHistoryData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC8")]
		[Cpp2IlInjected.Address(RVA = "0x16862D0", Offset = "0x1684CD0", VA = "0x1816862D0")]
		[DebuggerNonUserCode]
		public ConditionalEventHistoryData(ConditionalEventHistoryData other)
		{
			MapField<int, ConditionalEventState> mapField = (activeEvents_ = (MapField<int, ConditionalEventState>)(object)((MapField<TKey, TValue>)(object)other.activeEvents_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC9")]
		[Cpp2IlInjected.Address(RVA = "0x1683DF0", Offset = "0x16827F0", VA = "0x181683DF0", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalEventHistoryData Clone()
		{
			//Discarded unreachable code: IL_004a
			ConditionalEventHistoryData conditionalEventHistoryData = new ConditionalEventHistoryData();
			MapField<int, ConditionalEventState> mapField = (conditionalEventHistoryData.activeEvents_ = (MapField<int, ConditionalEventState>)(object)new MapField<TKey, TValue>());
			List<ConditionalEventItemData> list = (conditionalEventHistoryData.events = (List<ConditionalEventItemData>)(object)new List<T>());
			MapField<int, ConditionalEventState> mapField2 = (conditionalEventHistoryData.activeEvents_ = (MapField<int, ConditionalEventState>)(object)((MapField<TKey, TValue>)(object)activeEvents_).Clone());
			UnknownFieldSet unknownFieldSet = (conditionalEventHistoryData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionalEventHistoryData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DCB")]
		[Cpp2IlInjected.Address(RVA = "0x1685000", Offset = "0x1683A00", VA = "0x181685000", Slot = "0")]
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
				MapField<int, ConditionalEventState> mapField = activeEvents_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DCC")]
		[Cpp2IlInjected.Address(RVA = "0x1684F70", Offset = "0x1683970", VA = "0x181684F70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalEventHistoryData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<int, ConditionalEventState> mapField = activeEvents_;
				MapField<int, ConditionalEventState> mapField2 = other.activeEvents_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DCD")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((MapField<TKey, TValue>)(object)activeEvents_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DCE")]
		[Cpp2IlInjected.Address(RVA = "0x1685B40", Offset = "0x1684540", VA = "0x181685B40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DCF")]
		[Cpp2IlInjected.Address(RVA = "0x1685FE0", Offset = "0x16849E0", VA = "0x181685FE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<int, ConditionalEventState> mapField = activeEvents_;
			MapField<int, ConditionalEventState>.Codec map_activeEvents_codec = _map_activeEvents_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_activeEvents_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD0")]
		[Cpp2IlInjected.Address(RVA = "0x1683CE0", Offset = "0x16826E0", VA = "0x181683CE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<int, ConditionalEventState> mapField = activeEvents_;
			MapField<int, ConditionalEventState>.Codec map_activeEvents_codec = _map_activeEvents_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_activeEvents_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD1")]
		[Cpp2IlInjected.Address(RVA = "0x1685970", Offset = "0x1684370", VA = "0x181685970", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalEventHistoryData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<int, ConditionalEventState> mapField = activeEvents_;
				MapField<int, ConditionalEventState> mapField2 = other.activeEvents_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD2")]
		[Cpp2IlInjected.Address(RVA = "0x16859F0", Offset = "0x16843F0", VA = "0x1816859F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<int, ConditionalEventState> mapField = activeEvents_;
					MapField<int, ConditionalEventState>.Codec map_activeEvents_codec = _map_activeEvents_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_activeEvents_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD3")]
		[Cpp2IlInjected.Address(RVA = "0x1685310", Offset = "0x1683D10", VA = "0x181685310", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<int, ConditionalEventState> mapField = activeEvents_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD4")]
		[Cpp2IlInjected.Address(RVA = "0x1685AE0", Offset = "0x16844E0", VA = "0x181685AE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD5")]
		[Cpp2IlInjected.Address(RVA = "0x1683D90", Offset = "0x1682790", VA = "0x181683D90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<int, ConditionalEventState> mapField = activeEvents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD6")]
		[Cpp2IlInjected.Address(RVA = "0x1685390", Offset = "0x1683D90", VA = "0x181685390")]
		public void Initialize(Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00ea
			//IL_001a: Expected O, but got I4
			int num = 0;
			eventHandler?.Unregister();
			eventHandler = (ConditionEventHandler)num;
			this.profile = profile;
			this.dispatcher = dispatcher;
			this.context = context;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> enumerable = default(IEnumerable<>);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0060;
					}
					num++;
				}
				MapField<int, ConditionalEventState> mapField = activeEvents_;
				bool flag = default(bool);
				while (flag)
				{
				}
				List<ConditionalEventItemData> list = events;
				goto IL_0060;
			}
			goto IL_0064;
			IL_0060:
			enumerable = (IEnumerable<>)(object)((object)enumerable + (object)enumerable);
			goto IL_0064;
			IL_0064:
			if (enumerable != null)
			{
			}
			if (_003C_003Ec._003C_003E9__32_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ConditionalEventItemData x) => x.priority_);
			}
			Func<ConditionalEventItemData, int> func = default(Func<ConditionalEventItemData, int>);
			if (_003C_003Ec._003C_003E9__32_1 == null)
			{
				func = (Func<ConditionalEventItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ConditionalEventItemData x) => x.iD_));
			}
			IOrderedEnumerable<ConditionalEventItemData> orderedEnumerable = default(IOrderedEnumerable<ConditionalEventItemData>);
			List<ConditionalEventItemData> list2 = (events = (List<ConditionalEventItemData>)(object)Enumerable.ToList<ConditionalEventItemData>((IEnumerable<>)Enumerable.ThenBy<ConditionalEventItemData, int>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func)));
			if (func != null)
			{
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD7")]
		[Cpp2IlInjected.Address(RVA = "0x1683F60", Offset = "0x1682960", VA = "0x181683F60")]
		private void CreateEventHandler(ConditionListener mask)
		{
			//IL_001f: Expected O, but got I4
			if (dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = Evaluate;
			}
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD8")]
		[Cpp2IlInjected.Address(RVA = "0x1684010", Offset = "0x1682A10", VA = "0x181684010")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Unregister();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD9")]
		[Cpp2IlInjected.Address(RVA = "0x16850E0", Offset = "0x1683AE0", VA = "0x1816850E0")]
		private unsafe void Evaluate(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_0055, IL_005b, IL_0061, IL_0067, IL_006d, IL_0073
			//IL_0022: Expected O, but got I4
			int num = 0;
			List<ConditionalEventItemData> list = events;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = ((MapField<TKey, TValue>)(object)activeEvents_).TryGetValue((TKey)conditionListener, out *(TValue*)num);
				bool flag4 = default(bool);
				while (flag4)
				{
				}
				ITransactionContext transactionContext = context;
				Profile profile = this.profile;
				bool flag5 = default(bool);
				while (flag3 == flag5)
				{
				}
				if (!flag5)
				{
					MapField<int, ConditionalEventState> mapField = activeEvents_;
				}
				MapField<int, ConditionalEventState> mapField2 = activeEvents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDA")]
		[Cpp2IlInjected.Address(RVA = "0x1684040", Offset = "0x1682A40", VA = "0x181684040")]
		private ConditionalEventState DoAction(ConditionalEventItemData conditionalEvent)
		{
			ConditionalEventItemData.ActionOneofCase actionCase_ = conditionalEvent.actionCase_;
			if (conditionalEvent != null)
			{
				if (conditionalEvent != null)
				{
					if (conditionalEvent != null)
					{
						if (actionCase_ != (ConditionalEventItemData.ActionOneofCase)1)
						{
							int num = 0;
						}
						ConditionalEventState conditionalEventState = DoExpandGrid(conditionalEvent);
					}
					ConditionalEventState conditionalEventState2 = DoRecurringEvent(conditionalEvent);
				}
				MapField<string, Timestamp> timestamps_ = profile.player_.timestamps_;
				ConditionalTimestampData timestamp = conditionalEvent.Timestamp;
				ITransactionContext transactionContext = context;
				string timestamp_ = timestamp.timestamp_;
				Timestamp value = default(Timestamp);
				((MapField<TKey, TValue>)(object)timestamps_)[(TKey)timestamp_] = (TValue)value;
				ConditionalEventState conditionalEventState3 = new ConditionalEventState();
			}
			ConditionalEventState conditionalEventState4 = DoSpawn(conditionalEvent);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDB")]
		[Cpp2IlInjected.Address(RVA = "0x1685BE0", Offset = "0x16845E0", VA = "0x181685BE0")]
		private void UndoAction(ConditionalEventItemData conditionalEvent, ConditionalEventState conditionalEventState)
		{
			//Discarded unreachable code: IL_0030
			ConditionalEventItemData.ActionOneofCase actionCase_ = conditionalEvent.actionCase_;
			if (conditionalEvent != null)
			{
				if (conditionalEvent != null && actionCase_ == (ConditionalEventItemData.ActionOneofCase)1)
				{
					uint recurringEventID_ = conditionalEventState.RecurringEventState.recurringEventID_;
				}
			}
			else
			{
				SpawnActionState spawnState = conditionalEventState.SpawnState;
				UndoSpawn(conditionalEvent, spawnState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDC")]
		[Cpp2IlInjected.Address(RVA = "0x16847F0", Offset = "0x16831F0", VA = "0x1816847F0")]
		private ConditionalEventState DoSpawn(ConditionalEventItemData conditionalEvent)
		{
			//Discarded unreachable code: IL_01af, IL_01b5, IL_01bb, IL_01c1, IL_01c7, IL_01cd
			//IL_00b0: Expected I4, but got I8
			ulong num5 = default(ulong);
			string debugName2 = default(string);
			bool flag = default(bool);
			ConditionalEventState conditionalEventState = default(ConditionalEventState);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				ConditionalSpawnData spawn = conditionalEvent.Spawn;
				Random random = new Random(this.profile.player_.GetRandomSeed("ConditionalSpawn"));
				StepAmount amountToSpawn_ = spawn.amountToSpawn_;
				Func<IScalableValue, int> func = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
				int num3 = 0;
				int amount = amountToSpawn_.GetAmount(random, num3, (Func<, >)(object)func, (byte)num2 != 0);
				StepAmount spawnRadius_ = spawn.spawnRadius_;
				Func<IScalableValue, int> func2 = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
				int num4 = 0;
				int amount2 = spawnRadius_.GetAmount(random, num4, (Func<, >)(object)func2, (byte)num2 != 0);
				ItemSelector itemSelector = spawn.ItemSelector;
				Profile profile = this.profile;
				string name_ = conditionalEvent.name_;
				string debugName = "DoSpawn ConditionalEvent:" + name_;
				int onlySeedCrop = 0;
				ItemFilter itemFilter = ItemFilter.New(itemSelector, profile, random, (byte)onlySeedCrop != 0, (byte)num2 != 0, (byte)num5 != 0, debugName);
				Profile profile2 = this.profile;
				ProfileEventDispatcher profileEventDispatcher = dispatcher;
				ITransactionContext transactionContext = context;
				SpawnHelper spawnHelper = new SpawnHelper(profile2, profileEventDispatcher, transactionContext, spawn, itemFilter, debugName2);
				GridAddObjectOptions gridAddObjectOptions = new GridAddObjectOptions();
				gridAddObjectOptions.IgnoreRewardSpawnAnimation = true;
				LocationSource locationSource = (gridAddObjectOptions.RewardSpawnAnimationLocation = spawn.spawnAnimatonData_);
				if (spawnHelper.AddMissingItemsToGrid(random, true, amount, amount2, gridAddObjectOptions) == null)
				{
					break;
				}
				this.profile.player_.AdvanceRandomSeed("ConditionalSpawn");
				SpawnActionState spawnActionState = new SpawnActionState();
				if (flag)
				{
					RepeatedField<GridObjectAddress> spawnedObjects_ = spawnActionState.spawnedObjects_;
					GridObjectAddress item = new GridObjectAddress(flag ? 1u : 0u, flag ? 1u : 0u);
					((RepeatedField<T>)(object)spawnedObjects_).Add((T)item);
					while (spawn.spawnTypesCase_ != ConditionalSpawnData.SpawnTypesOneofCase.GardenItem)
					{
					}
					int itemID = spawn.GardenItem.SeedItem.ItemID;
					ITransactionContext transactionContext2 = context;
				}
				if (spawnHelper == null)
				{
					conditionalEventState.actionState_ = spawnActionState;
					bool flag2 = (byte)(conditionalEventState.actionStateCase_ = ((spawnActionState != null) ? ConditionalEventState.ActionStateOneofCase.SpawnState : ConditionalEventState.ActionStateOneofCase.None)) != 0;
					return conditionalEventState;
				}
			}
			ConditionalEventState conditionalEventState2 = default(ConditionalEventState);
			SpawnActionState spawnActionState2 = (SpawnActionState)(conditionalEventState2.actionState_ = new SpawnActionState());
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6004DE3")]
			[Cpp2IlInjected.Address(RVA = "0x1685BA0", Offset = "0x16845A0", VA = "0x181685BA0")]
			int ScaleFunc(IScalableValue value)
			{
				//Discarded unreachable code: IL_0019
				int level_ = this.profile.player_.level_;
				return MissionUtil.ResolveScalableValue(value, level_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDD")]
		[Cpp2IlInjected.Address(RVA = "0x1685D80", Offset = "0x1684780", VA = "0x181685D80")]
		private void UndoSpawn(ConditionalEventItemData conditionalEvent, SpawnActionState spawnState)
		{
			//Discarded unreachable code: IL_004e, IL_0054, IL_005a
			//IL_0030: Expected I4, but got O
			//IL_0039: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if ((conditionalEvent.Spawn.removeWhenDone_ ? 1 : 0) != num3)
			{
				RepeatedField<GridObjectAddress> spawnedObjects_ = spawnState.spawnedObjects_;
				bool flag = default(bool);
				if (flag)
				{
					RemoveFromGrid.Types.Request request = new RemoveFromGrid.Types.Request();
					request.gridID_ = (uint)(int)request;
					request.gridObjectID_ = (uint)(int)request;
					request.Automatic = true;
					new RemoveFromGrid.Types.Response().request_ = request;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDE")]
		[Cpp2IlInjected.Address(RVA = "0x1684E40", Offset = "0x1683840", VA = "0x181684E40")]
		private ConditionalEventState DoTimestamp(ConditionalEventItemData conditionalEvent)
		{
			//Discarded unreachable code: IL_0035
			MapField<string, Timestamp> timestamps_ = profile.player_.timestamps_;
			ConditionalTimestampData timestamp = conditionalEvent.Timestamp;
			ITransactionContext transactionContext = context;
			string timestamp_ = timestamp.timestamp_;
			Timestamp value = default(Timestamp);
			((MapField<TKey, TValue>)(object)timestamps_)[(TKey)timestamp_] = (TValue)value;
			return new ConditionalEventState();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDF")]
		[Cpp2IlInjected.Address(RVA = "0x1684370", Offset = "0x1682D70", VA = "0x181684370")]
		private ConditionalEventState DoRecurringEvent(ConditionalEventItemData conditionalEvent)
		{
			//Discarded unreachable code: IL_00dd
			//IL_00da: Expected I4, but got I8
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int recurringEventItemID_ = conditionalEvent.RecurringEvent.recurringEventItemID_;
			IRecurringEventData recurringEventData = default(IRecurringEventData);
			RecurringEvent recurringEvent = RecurringEvent.Create(recurringEventData);
			ConditionalRecurringEvent recurringEvent2 = conditionalEvent.RecurringEvent;
			ConditionalRecurringEvent.EndOneofCase endCase_ = recurringEvent2.endCase_;
			if (recurringEvent2 != null)
			{
				if (recurringEvent2 != null)
				{
					if (endCase_ != (ConditionalRecurringEvent.EndOneofCase)1)
					{
						goto IL_00b0;
					}
					IRecurringEvent @event = recurringEvent.Event;
					ITransactionContext transactionContext = context;
					TimeSpan timeSpan = conditionalEvent.RecurringEvent.Duration.ToTimeSpan();
					DateTime dateTime = default(DateTime);
					Timestamp timestamp = dateTime.ToProto();
				}
				IRecurringEvent event2 = recurringEvent.Event;
				ProfileWorld world_ = profile.world_;
				DateTime localTime = conditionalEvent.RecurringEvent.DateLocal.ToDateTime();
				Timestamp timestamp2 = world_.GetServerTime(localTime).ToProto();
			}
			IRecurringEvent event3 = recurringEvent.Event;
			Timestamp dateUTC = conditionalEvent.RecurringEvent.DateUTC;
			goto IL_00b0;
			IL_00b0:
			ConditionalEventState conditionalEventState = new ConditionalEventState();
			RecurringEventActionState recurringEventActionState = new RecurringEventActionState();
			uint recurringEventID_ = default(uint);
			recurringEventActionState.recurringEventID_ = recurringEventID_;
			conditionalEventState.actionState_ = recurringEventActionState;
			conditionalEventState.actionStateCase_ = ConditionalEventState.ActionStateOneofCase.RecurringEventState;
			return conditionalEventState;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE0")]
		[Cpp2IlInjected.Address(RVA = "0x1685CF0", Offset = "0x16846F0", VA = "0x181685CF0")]
		private void UndoRecurringEvent(ConditionalEventItemData conditionalEvent, RecurringEventActionState recurringEventState)
		{
			//Discarded unreachable code: IL_0008
			uint recurringEventID_ = recurringEventState.recurringEventID_;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE1")]
		[Cpp2IlInjected.Address(RVA = "0x16841C0", Offset = "0x1682BC0", VA = "0x1816841C0")]
		private unsafe ConditionalEventState DoExpandGrid(ConditionalEventItemData conditionalEvent)
		{
			//Discarded unreachable code: IL_0062
			int num = 0;
			if (conditionalEvent.ExpandGrid.gridCase_ == ConditionalExpandGrid.GridOneofCase.VillageArea)
			{
				Village village_ = profile.world_.village_;
				int villageArea = (int)conditionalEvent.ExpandGrid.VillageArea;
				bool flag = default(bool);
				if (flag && profile.world_.gridCollection_.TryGetGrid((uint)villageArea, out *(IGridInternal*)num) && conditionalEvent.ExpandGrid != null)
				{
					ConditionalExpandGrid expandGrid = conditionalEvent.ExpandGrid;
				}
			}
			return new ConditionalEventState();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE2")]
		[Cpp2IlInjected.Address(RVA = "0x16860A0", Offset = "0x1684AA0", VA = "0x1816860A0")]
		static ConditionalEventHistoryData()
		{
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<ConditionalEventState> parser = ConditionalEventState._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<ConditionalEventState>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<ConditionalEventHistoryData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
