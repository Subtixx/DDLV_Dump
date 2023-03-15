using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008DD")]
	public sealed class BattlePassTaskProgress : IMessage<BattlePassTaskProgress>, IMessage, IEquatable<BattlePassTaskProgress>, IDeepCloneable<BattlePassTaskProgress>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023E5")]
		private static readonly MessageParser<BattlePassTaskProgress> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023E6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023E7")]
		public const int ObjectiveFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023E8")]
		private ObjectiveProgress objective_;

		[Cpp2IlInjected.Token(Token = "0x40023E9")]
		public const int TaskStateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023EA")]
		private BattlePassTaskState taskState_;

		[Cpp2IlInjected.Token(Token = "0x17000CFD")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassTaskProgress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004C7B")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE330", Offset = "0x1ABCD30", VA = "0x181ABE330")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004C7C")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE200", Offset = "0x1ABCC00", VA = "0x181ABE200")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004C7D")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE390", Offset = "0x1ABCD90", VA = "0x181ABE390", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D00")]
		[DebuggerNonUserCode]
		public ObjectiveProgress Objective
		{
			[Cpp2IlInjected.Token(Token = "0x6004C81")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return objective_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C82")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				objective_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D01")]
		[DebuggerNonUserCode]
		public BattlePassTaskState TaskState
		{
			[Cpp2IlInjected.Token(Token = "0x6004C83")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return taskState_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C84")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				taskState_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D02")]
		private BattlePassProgress BattlePassProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6004C90")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CBattlePassProgress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C91")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CBattlePassProgress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D03")]
		public BattlePassTask Data
		{
			[Cpp2IlInjected.Token(Token = "0x6004C92")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C93")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D04")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x40023ED")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6004C94")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004C95")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000D05")]
		public bool IsNotStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6004C96")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE310", Offset = "0x1ABCD10", VA = "0x181ABE310")]
			get
			{
				return taskState_ == BattlePassTaskState.NotStarted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D06")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6004C98")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE2D0", Offset = "0x1ABCCD0", VA = "0x181ABE2D0")]
			get
			{
				BattlePassTaskState battlePassTaskState = taskState_;
				if (battlePassTaskState == BattlePassTaskState.OnGoing)
				{
					return true;
				}
				return battlePassTaskState == BattlePassTaskState.Completed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D07")]
		public bool IsOnGoing
		{
			[Cpp2IlInjected.Token(Token = "0x6004C99")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE320", Offset = "0x1ABCD20", VA = "0x181ABE320")]
			get
			{
				return taskState_ == BattlePassTaskState.OnGoing;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D08")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6004C9A")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE300", Offset = "0x1ABCD00", VA = "0x181ABE300")]
			get
			{
				return taskState_ == BattlePassTaskState.Completed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D09")]
		public bool IsClaimed
		{
			[Cpp2IlInjected.Token(Token = "0x6004C9B")]
			[Cpp2IlInjected.Address(RVA = "0x1ABE2F0", Offset = "0x1ABCCF0", VA = "0x181ABE2F0")]
			get
			{
				return taskState_ == BattlePassTaskState.CurrencyClaimed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C7E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BattlePassTaskProgress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004C7F")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE180", Offset = "0x1ABCB80", VA = "0x181ABE180")]
		[DebuggerNonUserCode]
		public BattlePassTaskProgress(BattlePassTaskProgress other)
		{
			//IL_0021: Expected O, but got I4
			ObjectiveProgress objectiveProgress = other.objective_;
			if (objectiveProgress != null)
			{
				ObjectiveProgress objectiveProgress2 = objectiveProgress.Clone();
			}
			int num = 0;
			objective_ = (ObjectiveProgress)num;
			BattlePassTaskState battlePassTaskState = (taskState_ = other.taskState_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C80")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD7F0", Offset = "0x1ABC1F0", VA = "0x181ABD7F0", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassTaskProgress Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0021: Expected O, but got I4
			BattlePassTaskProgress battlePassTaskProgress = new BattlePassTaskProgress();
			ObjectiveProgress objectiveProgress = objective_;
			if (objectiveProgress != null)
			{
				ObjectiveProgress objectiveProgress2 = objectiveProgress.Clone();
			}
			int num = 0;
			battlePassTaskProgress.objective_ = (ObjectiveProgress)num;
			BattlePassTaskState battlePassTaskState = (battlePassTaskProgress.taskState_ = taskState_);
			UnknownFieldSet unknownFieldSet = (battlePassTaskProgress._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return battlePassTaskProgress;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C85")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD8A0", Offset = "0x1ABC2A0", VA = "0x181ABD8A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(objective_, other);
				if (flag && taskState_ == (flag ? BattlePassTaskState.NotStarted : BattlePassTaskState.None))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C86")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassTaskProgress other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ObjectiveProgress objB = other.objective_;
				if (object.Equals(objective_, objB))
				{
					BattlePassTaskState battlePassTaskState = other.taskState_;
					if (taskState_ == battlePassTaskState)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C87")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ObjectiveProgress objectiveProgress = objective_;
				if (objectiveProgress != null)
				{
					int hashCode = objectiveProgress.GetHashCode();
				}
				if (taskState_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C88")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDF20", Offset = "0x1ABC920", VA = "0x181ABDF20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C89")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0035
			if ((long)objective_ != 0)
			{
				ObjectiveProgress value = objective_;
				output.WriteMessage(value);
			}
			if (taskState_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8A")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD720", Offset = "0x1ABC120", VA = "0x181ABD720", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ObjectiveProgress objectiveProgress = objective_;
				num = 0;
				if (objectiveProgress != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(objectiveProgress);
				}
				BattlePassTaskState battlePassTaskState = taskState_;
				if (battlePassTaskState != 0)
				{
					int num3 = CodedOutputStream.ComputeEnumSize((int)battlePassTaskState);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8B")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDBA0", Offset = "0x1ABC5A0", VA = "0x181ABDBA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassTaskProgress other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.objective_ != 0)
			{
				ObjectiveProgress objectiveProgress = objective_;
				if (objectiveProgress == null)
				{
					ObjectiveProgress objectiveProgress2 = (objective_ = new ObjectiveProgress());
				}
				ObjectiveProgress other2 = other.objective_;
				objectiveProgress.MergeFrom(other2);
			}
			BattlePassTaskState battlePassTaskState = other.taskState_;
			if (battlePassTaskState != 0)
			{
				taskState_ = battlePassTaskState;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8C")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDAB0", Offset = "0x1ABC4B0", VA = "0x181ABDAB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ObjectiveProgress objectiveProgress = objective_;
				if (objectiveProgress == null)
				{
					ObjectiveProgress objectiveProgress2 = (objective_ = new ObjectiveProgress());
				}
				input.ReadMessage(objectiveProgress);
			}
			if (num == 16)
			{
				int num2 = (int)(taskState_ = (BattlePassTaskState)input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8D")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD950", Offset = "0x1ABC350", VA = "0x181ABD950", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ObjectiveProgress objectiveProgress = objective_;
			}
			if (fieldNumber == 2)
			{
				BattlePassTaskState battlePassTaskState = taskState_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8E")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDDA0", Offset = "0x1ABC7A0", VA = "0x181ABDDA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				objective_ = (ObjectiveProgress)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				taskState_ = (BattlePassTaskState)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C8F")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				taskState_ = BattlePassTaskState.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C97")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDA70", Offset = "0x1ABC470", VA = "0x181ABDA70")]
		public bool IsAvailable(BattlePassSeasonData seasonData, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001b
			if (taskState_ != BattlePassTaskState.NotStarted)
			{
				int num = 0;
			}
			BattlePassTask task = Data;
			return seasonData.TaskIsAvailable(task, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C9C")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDA20", Offset = "0x1ABC420", VA = "0x181ABDA20")]
		internal void Init(BattlePassProgress battlePassProgress, BattlePassTask data, int index)
		{
			BattlePassProgress = battlePassProgress;
			Data = data;
			Index = index;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C9D")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDCB0", Offset = "0x1ABC6B0", VA = "0x181ABDCB0")]
		internal void Resume()
		{
			//Discarded unreachable code: IL_0067
			Stop();
			ObjectiveProgress objectiveProgress = objective_;
			EventHandler<EventArgs> eventHandler = (EventHandler<EventArgs>)(object)new EventHandler<TEventArgs>(OnObjectiveCompleted);
			objectiveProgress.add_OnObjectiveCompleted((EventHandler<>)(object)eventHandler);
			BattlePassTask battlePassTask = Data;
			BattlePassProgress battlePassProgress = BattlePassProgress;
			ObjectiveProgress objectiveProgress2 = objective_;
			ITransactionContext _003CContext_003Ek__BackingField = battlePassProgress.Context;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = battlePassProgress.Dispatcher;
			Profile _003CProfile_003Ek__BackingField = battlePassProgress.Profile;
			ObjectiveData objectiveData = battlePassTask.objective_;
			objectiveProgress2.Start(objectiveData, _003CProfile_003Ek__BackingField, _003CDispatcher_003Ek__BackingField, _003CContext_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C9E")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDE70", Offset = "0x1ABC870", VA = "0x181ABDE70")]
		internal void Stop()
		{
			//Discarded unreachable code: IL_0027
			objective_.Stop();
			ObjectiveProgress objectiveProgress = objective_;
			EventHandler<EventArgs> eventHandler = (EventHandler<EventArgs>)(object)new EventHandler<TEventArgs>(OnObjectiveCompleted);
			objectiveProgress.remove_OnObjectiveCompleted((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C9F")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDF80", Offset = "0x1ABC980", VA = "0x181ABDF80")]
		internal void UpdateTaskState(BattlePassTaskState newTaskState)
		{
			//Discarded unreachable code: IL_0031
			if (taskState_ == newTaskState)
			{
				return;
			}
			BattlePassProgress battlePassProgress = BattlePassProgress;
			taskState_ = newTaskState;
			if (battlePassProgress.Dispatcher != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA0")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDC80", Offset = "0x1ABC680", VA = "0x181ABDC80")]
		private void OnObjectiveCompleted(object sender, EventArgs e)
		{
			Stop();
			UpdateTaskState(BattlePassTaskState.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA1")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE070", Offset = "0x1ABCA70", VA = "0x181ABE070")]
		static BattlePassTaskProgress()
		{
			Func<BattlePassTaskProgress> func = default(Func<BattlePassTaskProgress>);
			_parser = (MessageParser<BattlePassTaskProgress>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
