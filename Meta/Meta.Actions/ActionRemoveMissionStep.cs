using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E06")]
	public sealed class ActionRemoveMissionStep : IMessage<ActionRemoveMissionStep>, IMessage, IEquatable<ActionRemoveMissionStep>, IDeepCloneable<ActionRemoveMissionStep>, IMessageFieldAccessor, IAction, IMissionItem, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40038E4")]
		private static readonly MessageParser<ActionRemoveMissionStep> _parser = (MessageParser<ActionRemoveMissionStep>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ActionRemoveMissionStep()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038E5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038E6")]
		public const int MissionIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038E7")]
		private int missionID_;

		[Cpp2IlInjected.Token(Token = "0x40038E8")]
		public const int TargetObjectivesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40038E9")]
		private static readonly FieldCodec<MissionObjectivesIdentifier> _repeated_targetObjectives_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40038EA")]
		private readonly RepeatedField<MissionObjectivesIdentifier> targetObjectives_ = (RepeatedField<MissionObjectivesIdentifier>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001481")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionRemoveMissionStep> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60075D6")]
			[Cpp2IlInjected.Address(RVA = "0x18DC8A0", Offset = "0x18DB2A0", VA = "0x1818DC8A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001482")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60075D7")]
			[Cpp2IlInjected.Address(RVA = "0x18DC5B0", Offset = "0x18DAFB0", VA = "0x1818DC5B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001483")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60075D8")]
			[Cpp2IlInjected.Address(RVA = "0x18DC900", Offset = "0x18DB300", VA = "0x1818DC900", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001484")]
		[DebuggerNonUserCode]
		public int MissionID
		{
			[Cpp2IlInjected.Token(Token = "0x60075DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return missionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60075DD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				missionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001485")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionObjectivesIdentifier> TargetObjectives
		{
			[Cpp2IlInjected.Token(Token = "0x60075DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetObjectives_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001486")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x60075EA")]
			[Cpp2IlInjected.Address(RVA = "0x18DC780", Offset = "0x18DB180", VA = "0x1818DC780", Slot = "16")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001487")]
		private string MissionName
		{
			[Cpp2IlInjected.Token(Token = "0x60075EB")]
			[Cpp2IlInjected.Address(RVA = "0x18DC7E0", Offset = "0x18DB1E0", VA = "0x1818DC7E0")]
			get
			{
				//Discarded unreachable code: IL_001d
				long num = Convert.ToInt64((uint)missionID_);
				string text = default(string);
				return text.Replace("Mission/MissionData/", "");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001488")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60075ED")]
			[Cpp2IlInjected.Address(RVA = "0x18DC680", Offset = "0x18DB080", VA = "0x1818DC680", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_002e
				long num = Convert.ToInt64((uint)missionID_);
				string text = default(string);
				string text2 = text.Replace("Mission/MissionData/", "");
				return "Remove step in " + text2 + "..";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075D9")]
		[Cpp2IlInjected.Address(RVA = "0x18DC530", Offset = "0x18DAF30", VA = "0x1818DC530")]
		[DebuggerNonUserCode]
		public ActionRemoveMissionStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60075DA")]
		[Cpp2IlInjected.Address(RVA = "0x18DC430", Offset = "0x18DAE30", VA = "0x1818DC430")]
		[DebuggerNonUserCode]
		public ActionRemoveMissionStep(ActionRemoveMissionStep other)
		{
			int num = (missionID_ = other.missionID_);
			RepeatedField<MissionObjectivesIdentifier> repeatedField = (targetObjectives_ = (RepeatedField<MissionObjectivesIdentifier>)(object)((RepeatedField<T>)(object)other.targetObjectives_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60075DB")]
		[Cpp2IlInjected.Address(RVA = "0x18DAF30", Offset = "0x18D9930", VA = "0x1818DAF30", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionRemoveMissionStep Clone()
		{
			//Discarded unreachable code: IL_004b
			ActionRemoveMissionStep actionRemoveMissionStep = new ActionRemoveMissionStep();
			RepeatedField<MissionObjectivesIdentifier> repeatedField = (actionRemoveMissionStep.targetObjectives_ = (RepeatedField<MissionObjectivesIdentifier>)(object)new RepeatedField<T>());
			int num = (actionRemoveMissionStep.missionID_ = missionID_);
			RepeatedField<MissionObjectivesIdentifier> repeatedField2 = (actionRemoveMissionStep.targetObjectives_ = (RepeatedField<MissionObjectivesIdentifier>)(object)((RepeatedField<T>)(object)targetObjectives_).Clone());
			UnknownFieldSet unknownFieldSet = (actionRemoveMissionStep._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionRemoveMissionStep;
		}

		[Cpp2IlInjected.Token(Token = "0x60075DF")]
		[Cpp2IlInjected.Address(RVA = "0x18DBC80", Offset = "0x18DA680", VA = "0x1818DBC80", Slot = "0")]
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
				if ((IntPtr)missionID_ == (IntPtr)typeof(ActionRemoveMissionStep).TypeHandle)
				{
					RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60075E0")]
		[Cpp2IlInjected.Address(RVA = "0x18DBBE0", Offset = "0x18DA5E0", VA = "0x1818DBBE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionRemoveMissionStep other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.missionID_;
				if (missionID_ == num)
				{
					RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
					RepeatedField<MissionObjectivesIdentifier> repeatedField2 = other.targetObjectives_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60075E1")]
		[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0029
			if (missionID_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)targetObjectives_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60075E2")]
		[Cpp2IlInjected.Address(RVA = "0x18DC110", Offset = "0x18DAB10", VA = "0x1818DC110", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60075E3")]
		[Cpp2IlInjected.Address(RVA = "0x18DC170", Offset = "0x18DAB70", VA = "0x1818DC170", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (missionID_ != 0)
			{
				int value = missionID_;
				output.WriteInt32(value);
			}
			RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
			FieldCodec<MissionObjectivesIdentifier> repeated_targetObjectives_codec = _repeated_targetObjectives_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_targetObjectives_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60075E4")]
		[Cpp2IlInjected.Address(RVA = "0x18DADD0", Offset = "0x18D97D0", VA = "0x1818DADD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			int num = missionID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
			FieldCodec<MissionObjectivesIdentifier> repeated_targetObjectives_codec = _repeated_targetObjectives_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_targetObjectives_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num2 += num5;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60075E5")]
		[Cpp2IlInjected.Address(RVA = "0x18DBE30", Offset = "0x18DA830", VA = "0x1818DBE30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionRemoveMissionStep other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				int num = other.missionID_;
				if (num != 0)
				{
					missionID_ = num;
				}
				RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
				RepeatedField<MissionObjectivesIdentifier> repeatedField2 = other.targetObjectives_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075E6")]
		[Cpp2IlInjected.Address(RVA = "0x18DBEC0", Offset = "0x18DA8C0", VA = "0x1818DBEC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (missionID_ = input.ReadInt32());
				}
				if (num == 18)
				{
					RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
					FieldCodec<MissionObjectivesIdentifier> repeated_targetObjectives_codec = _repeated_targetObjectives_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_targetObjectives_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60075E7")]
		[Cpp2IlInjected.Address(RVA = "0x18DBD60", Offset = "0x18DA760", VA = "0x1818DBD60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = missionID_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075E8")]
		[Cpp2IlInjected.Address(RVA = "0x18DC040", Offset = "0x18DAA40", VA = "0x1818DC040", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				missionID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075E9")]
		[Cpp2IlInjected.Address(RVA = "0x18DAEC0", Offset = "0x18D98C0", VA = "0x1818DAEC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				missionID_ = 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60075EC")]
		[Cpp2IlInjected.Address(RVA = "0x18DABC0", Offset = "0x18D95C0", VA = "0x1818DABC0", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = missionID_;
			RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
			Func<MissionObjectivesIdentifier, (int, int, int)> _003C_003E9__37_ = _003C_003Ec._003C_003E9__37_0;
			if (_003C_003E9__37_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num2 = 0;
					throw new NullReferenceException();
				};
			}
			List<(int, int, int)> list = (List<(int, int, int)>)(object)Enumerable.ToList<(int, int, int)>(Enumerable.Select<MissionObjectivesIdentifier, (int, int, int)>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__37_));
			Func<MissionObjective, int, string> func = (Func<MissionObjective, int, string>)(object)new Func<T1, T2, TResult>(ObjectiveValidation);
		}

		[Cpp2IlInjected.Token(Token = "0x60075EE")]
		[Cpp2IlInjected.Address(RVA = "0x18DBFC0", Offset = "0x18DA9C0", VA = "0x1818DBFC0")]
		private string ObjectiveValidation(MissionObjective obj, int index)
		{
			RepeatedField<MissionObjectivesIdentifier> repeatedField = targetObjectives_;
			if (repeatedField != null)
			{
				MissionObjectivesIdentifier missionObjectivesIdentifier = Enumerable.ElementAtOrDefault<MissionObjectivesIdentifier>((IEnumerable<>)(object)repeatedField, index);
				if (missionObjectivesIdentifier != null)
				{
					return missionObjectivesIdentifier.ObjectiveValidation(obj);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60075EF")]
		[Cpp2IlInjected.Address(RVA = "0x18DB060", Offset = "0x18D9A60", VA = "0x1818DB060", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60075F0")]
		[Cpp2IlInjected.Address(RVA = "0x18DC260", Offset = "0x18DAC60", VA = "0x1818DC260")]
		static ActionRemoveMissionStep()
		{
			MessageParser<MissionObjectivesIdentifier> parser = MissionObjectivesIdentifier._parser;
			uint num = default(uint);
			_parser = (MessageParser<ActionRemoveMissionStep>)(object)FieldCodec.ForMessage<MissionObjectivesIdentifier>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
