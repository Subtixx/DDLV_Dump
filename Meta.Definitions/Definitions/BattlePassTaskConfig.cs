using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class BattlePassTaskConfig : IMessage<BattlePassTaskConfig>, IMessage, IEquatable<BattlePassTaskConfig>, IDeepCloneable<BattlePassTaskConfig>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly MessageParser<BattlePassTaskConfig> _parser = (MessageParser<BattlePassTaskConfig>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new BattlePassTaskConfig()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public const int TasksFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private static readonly FieldCodec<BattlePassTask> _repeated_tasks_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private readonly RepeatedField<BattlePassTask> tasks_;

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassTaskConfig> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x32E0D10", Offset = "0x32DF710", VA = "0x1832E0D10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x32E0C40", Offset = "0x32DF640", VA = "0x1832E0C40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x32E0D70", Offset = "0x32DF770", VA = "0x1832E0D70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[DebuggerNonUserCode]
		public RepeatedField<BattlePassTask> Tasks
		{
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return tasks_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x32E0BC0", Offset = "0x32DF5C0", VA = "0x1832E0BC0")]
		[DebuggerNonUserCode]
		public BattlePassTaskConfig()
		{
			tasks_ = (RepeatedField<BattlePassTask>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x32E0B30", Offset = "0x32DF530", VA = "0x1832E0B30")]
		[DebuggerNonUserCode]
		public BattlePassTaskConfig(BattlePassTaskConfig other)
		{
			RepeatedField<BattlePassTask> repeatedField = (tasks_ = (RepeatedField<BattlePassTask>)(object)((RepeatedField<T>)(object)other.tasks_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x32DFF00", Offset = "0x32DE900", VA = "0x1832DFF00", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassTaskConfig Clone()
		{
			//Discarded unreachable code: IL_002e
			BattlePassTaskConfig battlePassTaskConfig = new BattlePassTaskConfig();
			RepeatedField<BattlePassTask> repeatedField = (battlePassTaskConfig.tasks_ = (RepeatedField<BattlePassTask>)(object)((RepeatedField<T>)(object)tasks_).Clone());
			UnknownFieldSet unknownFieldSet = (battlePassTaskConfig._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return battlePassTaskConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x32DFFC0", Offset = "0x32DE9C0", VA = "0x1832DFFC0", Slot = "0")]
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
				RepeatedField<BattlePassTask> repeatedField = tasks_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x32E00A0", Offset = "0x32DEAA0", VA = "0x1832E00A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassTaskConfig other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<BattlePassTask> repeatedField = tasks_;
				RepeatedField<BattlePassTask> repeatedField2 = other.tasks_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)tasks_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x32E0840", Offset = "0x32DF240", VA = "0x1832E0840", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x32E08A0", Offset = "0x32DF2A0", VA = "0x1832E08A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<BattlePassTask> repeatedField = tasks_;
			FieldCodec<BattlePassTask> repeated_tasks_codec = _repeated_tasks_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tasks_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x32DFDF0", Offset = "0x32DE7F0", VA = "0x1832DFDF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<BattlePassTask> repeatedField = tasks_;
			FieldCodec<BattlePassTask> repeated_tasks_codec = _repeated_tasks_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tasks_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x32E0580", Offset = "0x32DEF80", VA = "0x1832E0580", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassTaskConfig other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<BattlePassTask> repeatedField = tasks_;
				RepeatedField<BattlePassTask> repeatedField2 = other.tasks_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x32E0490", Offset = "0x32DEE90", VA = "0x1832E0490", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<BattlePassTask> repeatedField = tasks_;
					FieldCodec<BattlePassTask> repeated_tasks_codec = _repeated_tasks_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tasks_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x32E02D0", Offset = "0x32DECD0", VA = "0x1832E02D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<BattlePassTask> repeatedField = tasks_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x32E0600", Offset = "0x32DF000", VA = "0x1832E0600", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x32DFEA0", Offset = "0x32DE8A0", VA = "0x1832DFEA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<BattlePassTask> repeatedField = tasks_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x32E0660", Offset = "0x32DF060", VA = "0x1832E0660")]
		public BattlePassTaskConfigV2 ToServerConfig()
		{
			//Discarded unreachable code: IL_0056
			BattlePassTaskConfigV2 battlePassTaskConfigV = new BattlePassTaskConfigV2();
			List<glPlayFab.Disney.BattlePassTask> list = (battlePassTaskConfigV.Tasks = (List<glPlayFab.Disney.BattlePassTask>)(object)new List<T>());
			List<glPlayFab.Disney.BattlePassTask> _003CTasks_003Ek__BackingField = battlePassTaskConfigV.Tasks;
			RepeatedField<BattlePassTask> repeatedField = tasks_;
			Func<BattlePassTask, glPlayFab.Disney.BattlePassTask> _003C_003E9__28_ = _003C_003Ec._003C_003E9__28_0;
			if (_003C_003E9__28_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassTask x) => x.ToServerTask());
			}
			IEnumerable<BattlePassTask> enumerable = (IEnumerable<BattlePassTask>)Enumerable.Select<BattlePassTask, glPlayFab.Disney.BattlePassTask>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__28_);
			((List<T>)(object)_003CTasks_003Ek__BackingField).AddRange((IEnumerable<>)enumerable);
			return battlePassTaskConfigV;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x32E0130", Offset = "0x32DEB30", VA = "0x1832E0130")]
		public static BattlePassTaskConfig FromServerConfig(BattlePassTaskConfigV2 serverTaskConfig)
		{
			//Discarded unreachable code: IL_0046
			BattlePassTaskConfig battlePassTaskConfig = new BattlePassTaskConfig();
			RepeatedField<BattlePassTask> repeatedField = battlePassTaskConfig.tasks_;
			List<glPlayFab.Disney.BattlePassTask> _003CTasks_003Ek__BackingField = serverTaskConfig.Tasks;
			Func<glPlayFab.Disney.BattlePassTask, BattlePassTask> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
			if (_003C_003E9__29_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((glPlayFab.Disney.BattlePassTask x) => BattlePassTask.FromServerReward(x));
			}
			IEnumerable<glPlayFab.Disney.BattlePassTask> enumerable = (IEnumerable<glPlayFab.Disney.BattlePassTask>)Enumerable.Select<glPlayFab.Disney.BattlePassTask, BattlePassTask>((IEnumerable<>)_003CTasks_003Ek__BackingField, (Func<, >)(object)_003C_003E9__29_);
			((RepeatedField<T>)(object)repeatedField).AddRange((IEnumerable<>)enumerable);
			return battlePassTaskConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x32E0350", Offset = "0x32DED50", VA = "0x1832E0350")]
		public string GetUniqueTaskName()
		{
			//Discarded unreachable code: IL_005d
			string text = default(string);
			string text2 = "Task" + text;
			RepeatedField<BattlePassTask> repeatedField = tasks_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num < count)
			{
				if (string.Equals(((BattlePassTask)((RepeatedField<T>)(object)tasks_)[num]).internalName_, text2))
				{
					string text3 = default(string);
					string text4 = "Task" + text3;
				}
				RepeatedField<BattlePassTask> repeatedField2 = tasks_;
				num++;
			}
			return text2;
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x32E0960", Offset = "0x32DF360", VA = "0x1832E0960")]
		static BattlePassTaskConfig()
		{
			MessageParser<BattlePassTask> parser = BattlePassTask._parser;
			uint num = default(uint);
			_parser = (MessageParser<BattlePassTaskConfig>)(object)FieldCodec.ForMessage<BattlePassTask>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
