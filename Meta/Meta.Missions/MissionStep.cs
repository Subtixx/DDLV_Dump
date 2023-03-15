using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000FF4")]
	public sealed class MissionStep : IMessage<MissionStep>, IMessage, IEquatable<MissionStep>, IDeepCloneable<MissionStep>, IMessageFieldAccessor, IMissionIdentifier
	{
		[Cpp2IlInjected.Token(Token = "0x2000FF5")]
		internal delegate void StepCompletionChangedDelegate(MissionStep step, bool completed);

		[Cpp2IlInjected.Token(Token = "0x2000FF6")]
		internal delegate void StepStatusChangedDelegate(MissionStep step, MissionStepStatus previousStatus, MissionStepStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x4004192")]
		private static readonly MessageParser<MissionStep> _parser = (MessageParser<MissionStep>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionStep()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004193")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004194")]
		public const int SubStepsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4004195")]
		private static readonly FieldCodec<MissionSubStep> _repeated_subSteps_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004196")]
		private readonly RepeatedField<MissionSubStep> subSteps_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004199")]
		internal MissionSlot MissionSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400419C")]
		private MissionSlotStringResolver _stringResolver;

		[Cpp2IlInjected.Token(Token = "0x400419D")]
		public static readonly string GiveItemAniDoneBB;

		[Cpp2IlInjected.Token(Token = "0x17001669")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionStep> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008055")]
			[Cpp2IlInjected.Address(RVA = "0x1A667A0", Offset = "0x1A651A0", VA = "0x181A667A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008056")]
			[Cpp2IlInjected.Address(RVA = "0x1A66680", Offset = "0x1A65080", VA = "0x181A66680")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008057")]
			[Cpp2IlInjected.Address(RVA = "0x1A66930", Offset = "0x1A65330", VA = "0x181A66930", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166C")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionSubStep> SubSteps
		{
			[Cpp2IlInjected.Token(Token = "0x600805B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return subSteps_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4004197")]
		public int StepIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008067")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008068")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700166E")]
		public MissionStepData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6008069")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600806A")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700166F")]
		IMissionIdentifier IMissionIdentifier.IdentifierParent
		{
			[Cpp2IlInjected.Token(Token = "0x600806B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "15")]
			get
			{
				MissionSlot missionSlot = MissionSlot;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001670")]
		int IMissionIdentifier.IdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x600806C")]
			[Cpp2IlInjected.Address(RVA = "0x1A64EE0", Offset = "0x1A638E0", VA = "0x181A64EE0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.stepID_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001671")]
		string IMissionIdentifier.IdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x600806D")]
			[Cpp2IlInjected.Address(RVA = "0x1A64F00", Offset = "0x1A63900", VA = "0x181A64F00", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.stepName_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001672")]
		public string FullIdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x600806E")]
			[Cpp2IlInjected.Address(RVA = "0x1A62CE0", Offset = "0x1A616E0", VA = "0x181A62CE0", Slot = "19")]
			get
			{
				return MissionIdentifier.GetFullIdentifierName(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001673")]
		public string FullIdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x600806F")]
			[Cpp2IlInjected.Address(RVA = "0x1A62CD0", Offset = "0x1A616D0", VA = "0x181A62CD0", Slot = "18")]
			get
			{
				return MissionIdentifier.GetFullIdentifierID(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001674")]
		public IEnumerable<MissionObjective> AllObjectives
		{
			[Cpp2IlInjected.Token(Token = "0x6008070")]
			[Cpp2IlInjected.Address(RVA = "0x1A66420", Offset = "0x1A64E20", VA = "0x181A66420")]
			get
			{
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				Func<MissionSubStep, IEnumerable<MissionObjective>> _003C_003E9__48_ = _003C_003Ec._003C_003E9__48_0;
				if (_003C_003E9__48_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSubStep x)
					{
						RepeatedField<MissionObjective> objectives_ = x.objectives_;
						throw new NullReferenceException();
					};
				}
				return (IEnumerable<MissionObjective>)Enumerable.SelectMany<MissionSubStep, MissionObjective>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__48_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001675")]
		public IEnumerable<MissionObjective> ActiveObjectives
		{
			[Cpp2IlInjected.Token(Token = "0x6008071")]
			[Cpp2IlInjected.Address(RVA = "0x1A662E0", Offset = "0x1A64CE0", VA = "0x181A662E0")]
			get
			{
				IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)this.get_AllObjectives();
				Func<MissionObjective, bool> _003C_003E9__50_ = _003C_003Ec._003C_003E9__50_0;
				if (_003C_003E9__50_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_0010
						MissionStepStatus status_ = x.status_;
						if (status_ == MissionStepStatus.Ongoing)
						{
						}
						return status_ == MissionStepStatus.ReadyToBeCompleted;
					};
				}
				return (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)_003C_003E9__50_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001676")]
		public MissionObjective FakeObjective
		{
			[Cpp2IlInjected.Token(Token = "0x6008074")]
			[Cpp2IlInjected.Address(RVA = "0x1A66750", Offset = "0x1A65150", VA = "0x181A66750")]
			get
			{
				return Enumerable.FirstOrDefault<MissionObjective>(this.get_AllObjectives());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001677")]
		public MissionStepStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6008075")]
			[Cpp2IlInjected.Address(RVA = "0x1A66800", Offset = "0x1A65200", VA = "0x181A66800")]
			get
			{
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				Func<MissionSubStep, MissionStepStatus> _003C_003E9__56_ = _003C_003Ec._003C_003E9__56_0;
				if (_003C_003E9__56_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSubStep x) => x.Status);
				}
				MissionSubStep missionSubStep = Enumerable.Min<MissionSubStep, MissionStepStatus>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__56_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001678")]
		public bool AutoConfirmOnCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x6008078")]
			[Cpp2IlInjected.Address(RVA = "0x1A66550", Offset = "0x1A64F50", VA = "0x181A66550")]
			get
			{
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				Func<MissionSubStep, bool> _003C_003E9__60_ = _003C_003Ec._003C_003E9__60_0;
				if (_003C_003E9__60_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSubStep x) => x.AutoConfirmOnCompletion);
				}
				return ((IEnumerable<>)(object)repeatedField).All<MissionSubStep>((Func<, >)(object)_003C_003E9__60_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A8")]
		internal event StepCompletionChangedDelegate StepCompletionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6008079")]
			[Cpp2IlInjected.Address(RVA = "0x1A661A0", Offset = "0x1A64BA0", VA = "0x181A661A0")]
			[CompilerGenerated]
			add
			{
				StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
				Delegate @delegate = Delegate.Combine(stepCompletionChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != stepCompletionChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600807A")]
			[Cpp2IlInjected.Address(RVA = "0x1A66A40", Offset = "0x1A65440", VA = "0x181A66A40")]
			[CompilerGenerated]
			remove
			{
				StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
				Delegate @delegate = Delegate.Remove(stepCompletionChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != stepCompletionChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A9")]
		internal event StepStatusChangedDelegate StepStatusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600807B")]
			[Cpp2IlInjected.Address(RVA = "0x1A66240", Offset = "0x1A64C40", VA = "0x181A66240")]
			[CompilerGenerated]
			add
			{
				StepStatusChangedDelegate stepStatusChanged = this.StepStatusChanged;
				Delegate @delegate = Delegate.Combine(stepStatusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != stepStatusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600807C")]
			[Cpp2IlInjected.Address(RVA = "0x1A66AE0", Offset = "0x1A654E0", VA = "0x181A66AE0")]
			[CompilerGenerated]
			remove
			{
				StepStatusChangedDelegate stepStatusChanged = this.StepStatusChanged;
				Delegate @delegate = Delegate.Remove(stepStatusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != stepStatusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008058")]
		[Cpp2IlInjected.Address(RVA = "0x1A66120", Offset = "0x1A64B20", VA = "0x181A66120")]
		[DebuggerNonUserCode]
		public MissionStep()
		{
			subSteps_ = (RepeatedField<MissionSubStep>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6008059")]
		[Cpp2IlInjected.Address(RVA = "0x1A66090", Offset = "0x1A64A90", VA = "0x181A66090")]
		[DebuggerNonUserCode]
		public MissionStep(MissionStep other)
		{
			RepeatedField<MissionSubStep> repeatedField = (subSteps_ = (RepeatedField<MissionSubStep>)(object)((RepeatedField<T>)(object)other.subSteps_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600805A")]
		[Cpp2IlInjected.Address(RVA = "0x1A63C00", Offset = "0x1A62600", VA = "0x181A63C00", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionStep Clone()
		{
			//Discarded unreachable code: IL_002e
			MissionStep missionStep = new MissionStep();
			RepeatedField<MissionSubStep> repeatedField = (missionStep.subSteps_ = (RepeatedField<MissionSubStep>)(object)((RepeatedField<T>)(object)subSteps_).Clone());
			UnknownFieldSet unknownFieldSet = (missionStep._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionStep;
		}

		[Cpp2IlInjected.Token(Token = "0x600805C")]
		[Cpp2IlInjected.Address(RVA = "0x1A63D50", Offset = "0x1A62750", VA = "0x181A63D50", Slot = "0")]
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
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600805D")]
		[Cpp2IlInjected.Address(RVA = "0x1A63CC0", Offset = "0x1A626C0", VA = "0x181A63CC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionStep other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				RepeatedField<MissionSubStep> repeatedField2 = other.subSteps_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600805E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)subSteps_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600805F")]
		[Cpp2IlInjected.Address(RVA = "0x1A65D70", Offset = "0x1A64770", VA = "0x181A65D70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008060")]
		[Cpp2IlInjected.Address(RVA = "0x1A65DD0", Offset = "0x1A647D0", VA = "0x181A65DD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<MissionSubStep> repeatedField = subSteps_;
			FieldCodec<MissionSubStep> repeated_subSteps_codec = _repeated_subSteps_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_subSteps_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008061")]
		[Cpp2IlInjected.Address(RVA = "0x1A63AF0", Offset = "0x1A624F0", VA = "0x181A63AF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<MissionSubStep> repeatedField = subSteps_;
			FieldCodec<MissionSubStep> repeated_subSteps_codec = _repeated_subSteps_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_subSteps_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008062")]
		[Cpp2IlInjected.Address(RVA = "0x1A64D70", Offset = "0x1A63770", VA = "0x181A64D70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionStep other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				RepeatedField<MissionSubStep> repeatedField2 = other.subSteps_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008063")]
		[Cpp2IlInjected.Address(RVA = "0x1A64DF0", Offset = "0x1A637F0", VA = "0x181A64DF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<MissionSubStep> repeatedField = subSteps_;
					FieldCodec<MissionSubStep> repeated_subSteps_codec = _repeated_subSteps_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_subSteps_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008064")]
		[Cpp2IlInjected.Address(RVA = "0x1A64560", Offset = "0x1A62F60", VA = "0x181A64560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008065")]
		[Cpp2IlInjected.Address(RVA = "0x1A65740", Offset = "0x1A64140", VA = "0x181A65740", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6008066")]
		[Cpp2IlInjected.Address(RVA = "0x1A63BA0", Offset = "0x1A625A0", VA = "0x181A63BA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008072")]
		[Cpp2IlInjected.Address(RVA = "0x1A63E30", Offset = "0x1A62830", VA = "0x181A63E30")]
		public MissionObjective FirstObjectiveOf(MissionObjectiveData.CustomStepOneofCase custumStep, [Optional] Func<MissionObjective, bool> predicate)
		{
			//Discarded unreachable code: IL_0032
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)this.get_AllObjectives();
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_002e
				//IL_002c: Expected I4, but got O
				MissionObjectiveData missionObjectiveData = x.Data;
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase = custumStep;
				if (missionObjectiveData.customStepCase_ != customStepOneofCase)
				{
					int num = 0;
				}
				Func<MissionObjective, bool> func2 = predicate;
				return (func2 == null) ? true : ((byte)(int)func2((T)x) != 0);
			};
			return Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6008073")]
		[Cpp2IlInjected.Address(RVA = "0x1A63950", Offset = "0x1A62350", VA = "0x181A63950")]
		public MissionSubStep BringItemSubStep(Item targetCharacterItem)
		{
			//IL_0014: Expected O, but got I4
			//IL_0038: Expected I4, but got I8
			int itemID = targetCharacterItem.ItemID;
			Item targetCharacterItem2 = (Item)itemID;
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				Item targetCharacterItem3 = x.TargetCharacterItem;
				throw new NullReferenceException();
			};
			Func<MissionObjective, bool> predicate = func;
			MissionObjectiveData.CustomStepOneofCase custumStep = MissionObjectiveData.CustomStepOneofCase.BringItem;
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)this.get_AllObjectives();
			Func<MissionObjective, bool> func2 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_002e
				//IL_002c: Expected I4, but got O
				MissionObjectiveData missionObjectiveData = x.Data;
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase = custumStep;
				if (missionObjectiveData.customStepCase_ != customStepOneofCase)
				{
					int num = 0;
				}
				Func<MissionObjective, bool> func3 = predicate;
				return (func3 == null) ? true : ((byte)(int)func3((T)x) != 0);
			};
			MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)func2);
			if (missionObjective != null)
			{
				return missionObjective.MissionSubStep;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008076")]
		[Cpp2IlInjected.Address(RVA = "0x1A646A0", Offset = "0x1A630A0", VA = "0x181A646A0")]
		private MissionStepStatus GetStatus(MissionSubStep excluded)
		{
			RepeatedField<MissionSubStep> repeatedField = subSteps_;
			Func<MissionSubStep, bool> func = (Func<MissionSubStep, bool>)(object)(Func<T, TResult>)((MissionSubStep x) => x != excluded);
			IEnumerable<MissionSubStep> enumerable = (IEnumerable<MissionSubStep>)Enumerable.Where<MissionSubStep>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			Func<MissionSubStep, MissionStepStatus> _003C_003E9__57_ = _003C_003Ec._003C_003E9__57_1;
			if (_003C_003E9__57_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSubStep x) => x.Status);
			}
			MissionSubStep missionSubStep = Enumerable.Min<MissionSubStep, MissionStepStatus>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__57_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008077")]
		[Cpp2IlInjected.Address(RVA = "0x1A645E0", Offset = "0x1A62FE0", VA = "0x181A645E0")]
		private MissionStepStatus GetPrevStatus(MissionSubStep subStep, MissionStepStatus objPrevStatus)
		{
			//Discarded unreachable code: IL_000e
			int count = ((RepeatedField<T>)(object)subSteps_).Count;
			MissionStepStatus result = default(MissionStepStatus);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600807D")]
		[Cpp2IlInjected.Address(RVA = "0x1A650D0", Offset = "0x1A63AD0", VA = "0x181A650D0")]
		internal void PreInit(in World world, ITransactionContext context, MissionStepData data, MissionSlot parent, int stepIndex)
		{
			//Discarded unreachable code: IL_00aa
			//IL_000e: Expected O, but got I4
			Data = data;
			MissionSlot = (MissionSlot)0;
			int num = 0;
			StepIndex = 0;
			int num2 = 0;
			int count = ((RepeatedField<T>)(object)subSteps_).Count;
			if (num2 < count)
			{
				MissionSubStep missionSubStep = (MissionSubStep)((RepeatedField<T>)(object)subSteps_)[num];
				MissionSubStepData missionSubStepData = (MissionSubStepData)((RepeatedField<T>)(object)data.subSteps_)[num];
				missionSubStep.MissionStep = this;
				missionSubStep.Data = missionSubStepData;
				int num3 = 0;
				int count2 = ((RepeatedField<T>)(object)missionSubStep.objectives_).Count;
				if (num3 < count2)
				{
					MissionObjective missionObjective = (MissionObjective)((RepeatedField<T>)(object)missionSubStep.objectives_)[num3];
					MissionObjectiveData data2 = (MissionObjectiveData)((RepeatedField<T>)(object)missionSubStepData.objectives_)[num3];
					missionObjective.PreInit(in world, context, data2, missionSubStep);
					num3++;
				}
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600807E")]
		[Cpp2IlInjected.Address(RVA = "0x1A64AB0", Offset = "0x1A634B0", VA = "0x181A64AB0")]
		internal void Init(Random random)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<MissionSubStep> repeatedField = subSteps_;
			Action<MissionSubStep> action = (Action<MissionSubStep>)(object)(Action<T>)delegate(MissionSubStep x)
			{
				//Discarded unreachable code: IL_000f
				Random random2 = random;
				x.Init(random2);
			};
			((RepeatedField<>)(object)repeatedField).ForEach<MissionSubStep>((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x600807F")]
		[Cpp2IlInjected.Address(RVA = "0x1A657A0", Offset = "0x1A641A0", VA = "0x181A657A0")]
		internal void Start(StepCompletionChangedDelegate completionChangedDelegate)
		{
			StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
			int num = 0;
			Delegate @delegate = Delegate.Combine(stepCompletionChanged, completionChangedDelegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != stepCompletionChanged)
				{
				}
				int count = ((RepeatedField<T>)(object)subSteps_).Count;
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				if (num < count)
				{
					MissionSubStep missionSubStep = (MissionSubStep)((RepeatedField<T>)(object)repeatedField)[num];
					MissionSubStep.StepCompletionChangedDelegate onCompletionChanged = OnAnySubStepsCompletionChanged;
					MissionSubStep.StepStatusChangedDelegate onStatusChanged = OnSubStepStatusChanged;
					missionSubStep.Start(onCompletionChanged, onStatusChanged);
					RepeatedField<MissionSubStep> repeatedField2 = subSteps_;
					num++;
				}
				if (_003C_003Ec._003C_003E9__71_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(MissionSubStep x)
					{
						//Discarded unreachable code: IL_001d
						if (!x.Data.skipStepWhenCompleted_)
						{
							int num2 = 0;
						}
						return x.Status >= MissionStepStatus.Completed;
					};
				}
				bool flag = default(bool);
				if (flag)
				{
					ApplySkipWhenCompleted();
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008080")]
		[Cpp2IlInjected.Address(RVA = "0x1A65AA0", Offset = "0x1A644A0", VA = "0x181A65AA0")]
		internal void Stop(StepCompletionChangedDelegate completionChangedDelegate)
		{
			//Discarded unreachable code: IL_0073
			int num = 0;
			if (completionChangedDelegate != null)
			{
				StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
				Delegate @delegate = Delegate.Remove(stepCompletionChanged, completionChangedDelegate);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				while ((object)@delegate != stepCompletionChanged)
				{
				}
			}
			int count = ((RepeatedField<T>)(object)subSteps_).Count;
			if (num < count)
			{
				MissionSubStep missionSubStep = (MissionSubStep)((RepeatedField<T>)(object)subSteps_)[num];
				MissionSubStep.StepCompletionChangedDelegate onCompletionChanged = OnAnySubStepsCompletionChanged;
				MissionSubStep.StepStatusChangedDelegate onStatusChanged = OnSubStepStatusChanged;
				missionSubStep.Stop(onCompletionChanged, onStatusChanged);
				RepeatedField<MissionSubStep> repeatedField = subSteps_;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008081")]
		[Cpp2IlInjected.Address(RVA = "0x1A655F0", Offset = "0x1A63FF0", VA = "0x181A655F0")]
		internal void SetConfirmed()
		{
			RepeatedField<MissionSubStep> repeatedField = subSteps_;
			Action<MissionSubStep> _003C_003E9__73_ = _003C_003Ec._003C_003E9__73_0;
			if (_003C_003E9__73_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionSubStep x)
				{
					//Discarded unreachable code: IL_0007
					x.SetConfirmed();
				};
			}
			((RepeatedField<>)(object)repeatedField).ForEach<MissionSubStep>((Action<>)(object)_003C_003E9__73_);
		}

		[Cpp2IlInjected.Token(Token = "0x6008082")]
		[Cpp2IlInjected.Address(RVA = "0x1A635B0", Offset = "0x1A61FB0", VA = "0x181A635B0")]
		private void ApplySkipWhenCompleted()
		{
			//Discarded unreachable code: IL_0031, IL_0037, IL_003d, IL_0043
			RepeatedField<MissionSubStep> repeatedField = subSteps_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__74_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000c
					MissionStepStatus status_ = x.status_;
					return 0 < 4;
				};
			}
			IEnumerable<MissionObjective> enumerable = default(IEnumerable<MissionObjective>);
			if (enumerable != null)
			{
			}
			if (enumerable == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008083")]
		[Cpp2IlInjected.Address(RVA = "0x1A63F30", Offset = "0x1A62930", VA = "0x181A63F30")]
		public List<DescriptionInfo> GetDescriptions(Localizator localizator, bool all = false)
		{
			//IL_00e7: Expected O, but got I4
			//IL_00e7: Expected O, but got I4
			//IL_00e7: Expected O, but got I4
			List<DescriptionInfo> desc;
			List<DescriptionInfo> list = (desc = (List<DescriptionInfo>)(object)new List<T>());
			int indentation;
			int num = (indentation = 0);
			string stepDescription_ = Data.stepDescription_;
			if (list == null)
			{
				MissionStepData missionStepData = Data;
				if ((missionStepData.showProgressionCount_ ? 1 : 0) != num)
				{
					IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)this.get_AllObjectives();
					Func<MissionObjective, float> _003C_003E9__75_ = _003C_003Ec._003C_003E9__75_1;
					if (_003C_003E9__75_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.ProgressCurrentAmount);
					}
					float num2 = Enumerable.Sum<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)_003C_003E9__75_);
				}
				if ((missionStepData.showProgressionCount_ ? 1 : 0) != num)
				{
					IEnumerable<MissionObjective> allObjectives2 = (IEnumerable<MissionObjective>)this.get_AllObjectives();
					Func<MissionObjective, float> func = default(Func<MissionObjective, float>);
					if (_003C_003Ec._003C_003E9__75_2 == null)
					{
						func = (Func<MissionObjective, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.ProgressTargetAmount));
					}
					float num3 = Enumerable.Sum<MissionObjective>((IEnumerable<>)allObjectives2, (Func<, >)(object)func);
					MissionStepData missionStepData2 = Data;
				}
				int status = (int)Status;
				int num4 = indentation;
				string text = default(string);
				bool flag = default(bool);
				DescriptionInfo descriptionInfo = new DescriptionInfo(text, flag, num4, (MissionObjective)num, (Nullable<>)num, (Nullable<>)num);
				flag = status >= 3;
				List<DescriptionInfo> list2 = desc;
			}
			RepeatedField<MissionSubStep> repeatedField = subSteps_;
			Action<MissionSubStep> action = (Action<MissionSubStep>)(object)(Action<T>)delegate(MissionSubStep x)
			{
				//Discarded unreachable code: IL_0027
				bool flag2 = all;
				Localizator localizator2 = localizator;
				int num5 = indentation;
				List<DescriptionInfo> list3 = desc;
				x.AddDescriptions((List<>)(object)list3, num5, localizator2, flag2);
			};
			((RepeatedField<>)(object)repeatedField).ForEach<MissionSubStep>((Action<>)(object)action);
			if (num > 0)
			{
				if (((RepeatedField<T>)(object)subSteps_).Count == 1)
				{
					RepeatedField<MissionObjective> objectives_ = Enumerable.First<MissionSubStep>((IEnumerable<>)(object)subSteps_).objectives_;
					if (((RepeatedField<T>)(object)objectives_).Count == 1)
					{
						DescriptionInfo descriptionInfo2 = ((IEnumerable<>)(object)objectives_).Last<DescriptionInfo>();
						MissionObjective objective = Enumerable.First<MissionObjective>((IEnumerable<>)(object)Enumerable.First<MissionSubStep>((IEnumerable<>)(object)subSteps_).objectives_);
						descriptionInfo2.SetObjective(objective);
					}
				}
				DescriptionInfo descriptionInfo3 = default(DescriptionInfo);
				descriptionInfo3.SetObjective();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008084")]
		[Cpp2IlInjected.Address(RVA = "0x1A65C70", Offset = "0x1A64670", VA = "0x181A65C70")]
		public MissionSlotStringResolver StringResolver(Localizator localizator)
		{
			//IL_0045: Expected O, but got I4
			MissionSlotStringResolver stringResolver = _stringResolver;
			if (stringResolver == null)
			{
				MissionSlot missionSlot = MissionSlot;
				MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>(this.get_AllObjectives());
				if (missionObjective == null || missionObjective.Data != null)
				{
				}
				int num = 0;
				MissionSlotStringResolver missionSlotStringResolver = default(MissionSlotStringResolver);
				missionSlotStringResolver._missionSlot = missionSlot;
				missionSlotStringResolver._localizator = localizator;
				missionSlotStringResolver._stepName = (string)num;
				_stringResolver = missionSlotStringResolver;
			}
			return stringResolver;
		}

		[Cpp2IlInjected.Token(Token = "0x6008085")]
		[Cpp2IlInjected.Address(RVA = "0x1A653A0", Offset = "0x1A63DA0", VA = "0x181A653A0")]
		public string ResolveString(Localizator localizator, string locId, [Optional] IResolver extraResolver)
		{
			//Discarded unreachable code: IL_0091
			//IL_006b: Expected O, but got I4
			if ((object)typeof(string).TypeHandle == null)
			{
				MissionSlot missionSlot = MissionSlot;
				List<IResolver> list = (List<IResolver>)(object)new List<T>();
				((List<T>)(object)list).Add((T)extraResolver);
				MissionSlotStringResolver stringResolver = _stringResolver;
				if (stringResolver == null)
				{
					MissionSlot missionSlot2 = MissionSlot;
					MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>(this.get_AllObjectives());
					if (missionObjective == null || missionObjective.Data != null)
					{
					}
					int num = 0;
					MissionSlotStringResolver missionSlotStringResolver = default(MissionSlotStringResolver);
					missionSlotStringResolver._missionSlot = missionSlot2;
					missionSlotStringResolver._localizator = localizator;
					missionSlotStringResolver._stepName = (string)num;
					_stringResolver = missionSlotStringResolver;
				}
				((List<T>)(object)list).Add((T)stringResolver);
				MultiResolver multiResolver = new MultiResolver((IReadOnlyCollection<>)list);
				string text = default(string);
				return missionSlot.ResolveXml(text);
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6008086")]
		[Cpp2IlInjected.Address(RVA = "0x1A652F0", Offset = "0x1A63CF0", VA = "0x181A652F0", Slot = "14")]
		public object ResolveKey(Localizator localizator, string key)
		{
			MissionSubStep missionSubStep = Enumerable.FirstOrDefault<MissionSubStep>((IEnumerable<>)(object)subSteps_);
			if (missionSubStep != null)
			{
				MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)missionSubStep.objectives_);
				if (missionObjective != null)
				{
					return missionObjective.ResolveKey(localizator, key);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008087")]
		[Cpp2IlInjected.Address(RVA = "0x1A64F20", Offset = "0x1A63920", VA = "0x181A64F20")]
		private void OnAnySubStepsCompletionChanged(MissionSubStep missionSubStep, bool completed)
		{
			//Discarded unreachable code: IL_004d
			if (((RepeatedField<T>)(object)subSteps_).Count > 1)
			{
				if (completed)
				{
					MissionStepStatus status = Status;
				}
				MissionStepStatus status2 = GetStatus(missionSubStep);
			}
			this.StepCompletionChanged?.Invoke(this, completed);
			if (completed && missionSubStep.Data.skipStepWhenCompleted_)
			{
				ApplySkipWhenCompleted();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008088")]
		[Cpp2IlInjected.Address(RVA = "0x1A64FF0", Offset = "0x1A639F0", VA = "0x181A64FF0")]
		private void OnSubStepStatusChanged(MissionSubStep subStep, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			//Discarded unreachable code: IL_002d
			if (((RepeatedField<T>)(object)subSteps_).Count > 1)
			{
				MissionStepStatus status = GetStatus(subStep);
			}
			MissionStepStatus status2 = Status;
			if (previousStatus != status2 && this.StepStatusChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008089")]
		[Cpp2IlInjected.Address(RVA = "0x1A649B0", Offset = "0x1A633B0", VA = "0x181A649B0")]
		public bool HasCustomStep(MissionObjectiveData.CustomStepOneofCase customStep, [Optional] Func<MissionObjective, bool> predicate)
		{
			//Discarded unreachable code: IL_0032
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)this.get_AllObjectives();
			Func<MissionObjective, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_002e
				//IL_002c: Expected I4, but got O
				MissionObjectiveData missionObjectiveData = x.Data;
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase = customStep;
				if (missionObjectiveData.customStepCase_ != customStepOneofCase)
				{
					int num = 0;
				}
				Func<MissionObjective, bool> func = predicate;
				return (func == null) ? true : ((byte)(int)func((T)x) != 0);
			};
			return ((IEnumerable<>)allObjectives).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x600808A")]
		[Cpp2IlInjected.Address(RVA = "0x1A64880", Offset = "0x1A63280", VA = "0x181A64880")]
		public bool HasActiveCustomStep(MissionObjectiveData.CustomStepOneofCase customStep)
		{
			//Discarded unreachable code: IL_001f
			if (_003C_003Ec._003C_003E9__84_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_0010
					MissionStepStatus status_ = x.status_;
					if (status_ == MissionStepStatus.Ongoing)
					{
					}
					return status_ == MissionStepStatus.ReadyToBeCompleted;
				};
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600808B")]
		[Cpp2IlInjected.Address(RVA = "0x1A64BC0", Offset = "0x1A635C0", VA = "0x181A64BC0")]
		internal bool IsReadyToGiveItems(Item targetCharacterItem)
		{
			//IL_0014: Expected O, but got I4
			//IL_0038: Expected I4, but got I8
			int itemID = targetCharacterItem.ItemID;
			Item targetCharacterItem2 = (Item)itemID;
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				Item targetCharacterItem3 = x.TargetCharacterItem;
				throw new NullReferenceException();
			};
			Func<MissionObjective, bool> predicate = func;
			MissionObjectiveData.CustomStepOneofCase custumStep = MissionObjectiveData.CustomStepOneofCase.BringItem;
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)this.get_AllObjectives();
			Func<MissionObjective, bool> func2 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_002e
				//IL_002c: Expected I4, but got O
				MissionObjectiveData missionObjectiveData = x.Data;
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase = custumStep;
				if (missionObjectiveData.customStepCase_ != customStepOneofCase)
				{
					int num = 0;
				}
				Func<MissionObjective, bool> func3 = predicate;
				return (func3 == null) ? true : ((byte)(int)func3((T)x) != 0);
			};
			MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)allObjectives, (Func<, >)(object)func2);
			if (missionObjective != null)
			{
				MissionSubStep _003CMissionSubStep_003Ek__BackingField = missionObjective.MissionSubStep;
				if (_003CMissionSubStep_003Ek__BackingField != null)
				{
					return _003CMissionSubStep_003Ek__BackingField.Status == MissionStepStatus.ReadyToBeCompleted;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600808C")]
		[Cpp2IlInjected.Address(RVA = "0x1A65E90", Offset = "0x1A64890", VA = "0x181A65E90")]
		static MissionStep()
		{
			MessageParser<MissionSubStep> parser = MissionSubStep._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionStep>)(object)FieldCodec.ForMessage<MissionSubStep>(num, (MessageParser<>)(object)parser);
			_parser = (MessageParser<MissionStep>)(object)"GiveItemAniDone";
			/*Error: Unexpected end of block*/;
		}
	}
}
