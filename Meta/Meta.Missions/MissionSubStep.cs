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
	[Cpp2IlInjected.Token(Token = "0x2000FFE")]
	public sealed class MissionSubStep : IMessage<MissionSubStep>, IMessage, IEquatable<MissionSubStep>, IDeepCloneable<MissionSubStep>, IMessageFieldAccessor, IMissionIdentifier
	{
		[Cpp2IlInjected.Token(Token = "0x2000FFF")]
		internal delegate void StepCompletionChangedDelegate(MissionSubStep subStep, bool completed);

		[Cpp2IlInjected.Token(Token = "0x2001000")]
		internal delegate void StepStatusChangedDelegate(MissionSubStep subStep, MissionStepStatus previousStatus, MissionStepStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x40041B5")]
		private static readonly MessageParser<MissionSubStep> _parser = (MessageParser<MissionSubStep>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionSubStep()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40041B6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40041B7")]
		public const int ObjectivesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40041B8")]
		private static readonly FieldCodec<MissionObjective> _repeated_objectives_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40041B9")]
		private readonly RepeatedField<MissionObjective> objectives_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40041BE")]
		private MissionSlotStringResolver _stringResolver;

		[Cpp2IlInjected.Token(Token = "0x17001679")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionSubStep> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60080AF")]
			[Cpp2IlInjected.Address(RVA = "0x1A69700", Offset = "0x1A68100", VA = "0x181A69700")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60080B0")]
			[Cpp2IlInjected.Address(RVA = "0x1A69610", Offset = "0x1A68010", VA = "0x181A69610")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60080B1")]
			[Cpp2IlInjected.Address(RVA = "0x1A69890", Offset = "0x1A68290", VA = "0x181A69890", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167C")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionObjective> Objectives
		{
			[Cpp2IlInjected.Token(Token = "0x60080B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return objectives_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167D")]
		public MissionSlot MissionSlot
		{
			[Cpp2IlInjected.Token(Token = "0x60080C5")]
			[Cpp2IlInjected.Address(RVA = "0x1A696E0", Offset = "0x1A680E0", VA = "0x181A696E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MissionStep.MissionSlot;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167E")]
		public MissionStep MissionStep
		{
			[Cpp2IlInjected.Token(Token = "0x60080C6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CMissionStep_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60080C7")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CMissionStep_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700167F")]
		public MissionSubStepData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60080C8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60080C9")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001680")]
		IMissionIdentifier IMissionIdentifier.IdentifierParent
		{
			[Cpp2IlInjected.Token(Token = "0x60080CA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "15")]
			get
			{
				MissionStep missionStep = MissionStep;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001681")]
		int IMissionIdentifier.IdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x60080CB")]
			[Cpp2IlInjected.Address(RVA = "0x1A68090", Offset = "0x1A66A90", VA = "0x181A68090", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.subStepID_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001682")]
		string IMissionIdentifier.IdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x60080CC")]
			[Cpp2IlInjected.Address(RVA = "0x1A680B0", Offset = "0x1A66AB0", VA = "0x181A680B0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.stepName_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001683")]
		public string FullIdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x60080CD")]
			[Cpp2IlInjected.Address(RVA = "0x1A62CE0", Offset = "0x1A616E0", VA = "0x181A62CE0", Slot = "19")]
			get
			{
				return MissionIdentifier.GetFullIdentifierName(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001684")]
		public string FullIdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x60080CE")]
			[Cpp2IlInjected.Address(RVA = "0x1A62CD0", Offset = "0x1A616D0", VA = "0x181A62CD0", Slot = "18")]
			get
			{
				return MissionIdentifier.GetFullIdentifierID(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001685")]
		public MissionStepStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x60080CF")]
			[Cpp2IlInjected.Address(RVA = "0x1A69760", Offset = "0x1A68160", VA = "0x181A69760")]
			get
			{
				RepeatedField<MissionObjective> repeatedField = objectives_;
				Func<MissionObjective, MissionStepStatus> _003C_003E9__57_ = _003C_003Ec._003C_003E9__57_0;
				if (_003C_003E9__57_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.status_);
				}
				MissionObjective missionObjective = Enumerable.Min<MissionObjective, MissionStepStatus>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__57_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001686")]
		public bool AutoConfirmOnCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x60080D2")]
			[Cpp2IlInjected.Address(RVA = "0x1A694E0", Offset = "0x1A67EE0", VA = "0x181A694E0")]
			get
			{
				RepeatedField<MissionObjective> repeatedField = objectives_;
				Func<MissionObjective, bool> _003C_003E9__61_ = _003C_003Ec._003C_003E9__61_0;
				if (_003C_003E9__61_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.AutoConfirmOnCompletion);
				}
				return ((IEnumerable<>)(object)repeatedField).All<MissionObjective>((Func<, >)(object)_003C_003E9__61_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000AA")]
		internal event StepCompletionChangedDelegate StepCompletionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60080C1")]
			[Cpp2IlInjected.Address(RVA = "0x1A693A0", Offset = "0x1A67DA0", VA = "0x181A693A0")]
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
			[Cpp2IlInjected.Token(Token = "0x60080C2")]
			[Cpp2IlInjected.Address(RVA = "0x1A699A0", Offset = "0x1A683A0", VA = "0x181A699A0")]
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

		[Cpp2IlInjected.Token(Token = "0x140000AB")]
		internal event StepStatusChangedDelegate StepStatusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60080C3")]
			[Cpp2IlInjected.Address(RVA = "0x1A69440", Offset = "0x1A67E40", VA = "0x181A69440")]
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
			[Cpp2IlInjected.Token(Token = "0x60080C4")]
			[Cpp2IlInjected.Address(RVA = "0x1A69A40", Offset = "0x1A68440", VA = "0x181A69A40")]
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

		[Cpp2IlInjected.Token(Token = "0x60080B2")]
		[Cpp2IlInjected.Address(RVA = "0x1A69320", Offset = "0x1A67D20", VA = "0x181A69320")]
		[DebuggerNonUserCode]
		public MissionSubStep()
		{
			objectives_ = (RepeatedField<MissionObjective>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60080B3")]
		[Cpp2IlInjected.Address(RVA = "0x1A69290", Offset = "0x1A67C90", VA = "0x181A69290")]
		[DebuggerNonUserCode]
		public MissionSubStep(MissionSubStep other)
		{
			RepeatedField<MissionObjective> repeatedField = (objectives_ = (RepeatedField<MissionObjective>)(object)((RepeatedField<T>)(object)other.objectives_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60080B4")]
		[Cpp2IlInjected.Address(RVA = "0x1A67760", Offset = "0x1A66160", VA = "0x181A67760", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionSubStep Clone()
		{
			//Discarded unreachable code: IL_002e
			MissionSubStep missionSubStep = new MissionSubStep();
			RepeatedField<MissionObjective> repeatedField = (missionSubStep.objectives_ = (RepeatedField<MissionObjective>)(object)((RepeatedField<T>)(object)objectives_).Clone());
			UnknownFieldSet unknownFieldSet = (missionSubStep._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionSubStep;
		}

		[Cpp2IlInjected.Token(Token = "0x60080B6")]
		[Cpp2IlInjected.Address(RVA = "0x1A678B0", Offset = "0x1A662B0", VA = "0x181A678B0", Slot = "0")]
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
				RepeatedField<MissionObjective> repeatedField = objectives_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60080B7")]
		[Cpp2IlInjected.Address(RVA = "0x1A67820", Offset = "0x1A66220", VA = "0x181A67820", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionSubStep other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<MissionObjective> repeatedField = objectives_;
				RepeatedField<MissionObjective> repeatedField2 = other.objectives_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60080B8")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)objectives_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60080B9")]
		[Cpp2IlInjected.Address(RVA = "0x1A68FA0", Offset = "0x1A679A0", VA = "0x181A68FA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60080BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A69000", Offset = "0x1A67A00", VA = "0x181A69000", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<MissionObjective> repeatedField = objectives_;
			FieldCodec<MissionObjective> repeated_objectives_codec = _repeated_objectives_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_objectives_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60080BB")]
		[Cpp2IlInjected.Address(RVA = "0x1A67650", Offset = "0x1A66050", VA = "0x181A67650", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<MissionObjective> repeatedField = objectives_;
			FieldCodec<MissionObjective> repeated_objectives_codec = _repeated_objectives_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_objectives_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60080BC")]
		[Cpp2IlInjected.Address(RVA = "0x1A68010", Offset = "0x1A66A10", VA = "0x181A68010", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionSubStep other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<MissionObjective> repeatedField = objectives_;
				RepeatedField<MissionObjective> repeatedField2 = other.objectives_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080BD")]
		[Cpp2IlInjected.Address(RVA = "0x1A67F20", Offset = "0x1A66920", VA = "0x181A67F20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<MissionObjective> repeatedField = objectives_;
					FieldCodec<MissionObjective> repeated_objectives_codec = _repeated_objectives_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_objectives_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080BE")]
		[Cpp2IlInjected.Address(RVA = "0x1A67990", Offset = "0x1A66390", VA = "0x181A67990", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MissionObjective> repeatedField = objectives_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60080BF")]
		[Cpp2IlInjected.Address(RVA = "0x1A68850", Offset = "0x1A67250", VA = "0x181A68850", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60080C0")]
		[Cpp2IlInjected.Address(RVA = "0x1A67700", Offset = "0x1A66100", VA = "0x181A67700", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<MissionObjective> repeatedField = objectives_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080D0")]
		[Cpp2IlInjected.Address(RVA = "0x1A67C10", Offset = "0x1A66610", VA = "0x181A67C10")]
		private MissionStepStatus GetStatus(MissionObjective excluded)
		{
			RepeatedField<MissionObjective> repeatedField = objectives_;
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)((MissionObjective x) => x != excluded);
			IEnumerable<MissionObjective> enumerable = (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			Func<MissionObjective, MissionStepStatus> _003C_003E9__58_ = _003C_003Ec._003C_003E9__58_1;
			if (_003C_003E9__58_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.status_);
			}
			MissionObjective missionObjective = Enumerable.Min<MissionObjective, MissionStepStatus>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__58_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60080D1")]
		[Cpp2IlInjected.Address(RVA = "0x1A67B50", Offset = "0x1A66550", VA = "0x181A67B50")]
		private MissionStepStatus GetPrevStatus(MissionObjective obj, MissionStepStatus objPrevStatus)
		{
			//Discarded unreachable code: IL_000e
			int count = ((RepeatedField<T>)(object)objectives_).Count;
			MissionStepStatus result = default(MissionStepStatus);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60080D3")]
		[Cpp2IlInjected.Address(RVA = "0x1A67DF0", Offset = "0x1A667F0", VA = "0x181A67DF0")]
		public bool HasFollower()
		{
			//Discarded unreachable code: IL_000c
			return Data.isOwnerFollowing_;
		}

		[Cpp2IlInjected.Token(Token = "0x60080D4")]
		[Cpp2IlInjected.Address(RVA = "0x1A67A10", Offset = "0x1A66410", VA = "0x181A67A10")]
		public Item GetFollower()
		{
			//Discarded unreachable code: IL_0037
			MissionSubStepData missionSubStepData = Data;
			if (!missionSubStepData.isOwnerFollowing_)
			{
				return Item.Invalid;
			}
			if ((object)missionSubStepData.FollowerItem != null)
			{
				long num = Convert.ToInt64((uint)MissionStep.MissionSlot.characterId_);
			}
			Item result = default(Item);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60080D5")]
		[Cpp2IlInjected.Address(RVA = "0x1A68340", Offset = "0x1A66D40", VA = "0x181A68340")]
		internal void PreInit(in World world, ITransactionContext context, MissionSubStepData data, MissionStep parent)
		{
			//Discarded unreachable code: IL_0055
			//IL_0007: Expected O, but got I4
			MissionStep = (MissionStep)0;
			Data = data;
			RepeatedField<MissionObjective> repeatedField = objectives_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num < count)
			{
				MissionObjective missionObjective = (MissionObjective)((RepeatedField<T>)(object)objectives_)[num];
				MissionObjectiveData data2 = (MissionObjectiveData)((RepeatedField<T>)(object)data.objectives_)[num];
				missionObjective.PreInit(in world, context, data2, this);
				RepeatedField<MissionObjective> repeatedField2 = objectives_;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A67E10", Offset = "0x1A66810", VA = "0x181A67E10")]
		internal void Init(Random random)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<MissionObjective> repeatedField = objectives_;
			Action<MissionObjective> action = (Action<MissionObjective>)(object)(Action<T>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_000f
				Random random2 = random;
				x.Init(random2);
			};
			((RepeatedField<>)(object)repeatedField).ForEach<MissionObjective>((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60080D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A688B0", Offset = "0x1A672B0", VA = "0x181A688B0")]
		internal void Start(StepCompletionChangedDelegate onCompletionChanged, StepStatusChangedDelegate onStatusChanged)
		{
			StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
			int num = 0;
			Delegate @delegate = Delegate.Combine(stepCompletionChanged, onCompletionChanged);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != stepCompletionChanged)
				{
				}
				StepStatusChangedDelegate stepStatusChanged = this.StepStatusChanged;
				Delegate delegate2 = Delegate.Combine(stepStatusChanged, onStatusChanged);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != stepStatusChanged)
					{
					}
					int count = ((RepeatedField<T>)(object)objectives_).Count;
					RepeatedField<MissionObjective> repeatedField = objectives_;
					if (num < count)
					{
						MissionObjective missionObjective = (MissionObjective)((RepeatedField<T>)(object)repeatedField)[num];
						MissionObjective.StepCompletionChangedDelegate onCompletionChanged2 = OnAnyObjectivesCompletionChanged;
						MissionObjective.StepStatusChangedDelegate onStatusChanged2 = OnObjectiveStatusChanged;
						missionObjective.Start(this, onCompletionChanged2, onStatusChanged2);
						RepeatedField<MissionObjective> repeatedField2 = objectives_;
						num++;
					}
					if (_003C_003Ec._003C_003E9__66_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(MissionObjective x)
						{
							//Discarded unreachable code: IL_001d
							if (!x.Data.skipSubStepWhenCompleted_)
							{
								int num2 = 0;
							}
							return x.status_ >= MissionStepStatus.Completed;
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
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60080D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A68C40", Offset = "0x1A67640", VA = "0x181A68C40")]
		internal void Stop(StepCompletionChangedDelegate onCompletionChanged, StepStatusChangedDelegate onStatusChanged)
		{
			//Discarded unreachable code: IL_0093
			StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
			int num = 0;
			Delegate @delegate = Delegate.Remove(stepCompletionChanged, onCompletionChanged);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != stepCompletionChanged)
				{
				}
				StepStatusChangedDelegate stepStatusChanged = this.StepStatusChanged;
				Delegate delegate2 = Delegate.Remove(stepStatusChanged, onStatusChanged);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != stepStatusChanged)
					{
					}
					int count = ((RepeatedField<T>)(object)objectives_).Count;
					if (num < count)
					{
						MissionObjective missionObjective = (MissionObjective)((RepeatedField<T>)(object)objectives_)[num];
						MissionObjective.StepCompletionChangedDelegate onCompletionChanged2 = OnAnyObjectivesCompletionChanged;
						MissionObjective.StepStatusChangedDelegate onStatusChanged2 = OnObjectiveStatusChanged;
						missionObjective.Stop(onCompletionChanged2, onStatusChanged2);
						RepeatedField<MissionObjective> repeatedField = objectives_;
						num++;
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60080D9")]
		[Cpp2IlInjected.Address(RVA = "0x1A68760", Offset = "0x1A67160", VA = "0x181A68760")]
		internal void SetConfirmed()
		{
			//Discarded unreachable code: IL_000c
			RepeatedField<MissionObjective> repeatedField = objectives_;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080DA")]
		[Cpp2IlInjected.Address(RVA = "0x1A67330", Offset = "0x1A65D30", VA = "0x181A67330")]
		private void ApplySkipWhenCompleted()
		{
			//Discarded unreachable code: IL_006e, IL_0074
			int num = 0;
			RepeatedField<MissionObjective> repeatedField = objectives_;
			Func<MissionObjective, bool> _003C_003E9__69_ = _003C_003Ec._003C_003E9__69_0;
			if (_003C_003E9__69_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000c
					MissionStepStatus status_ = x.status_;
					return 0 < 4;
				};
			}
			IEnumerable<MissionObjective> enumerable = (IEnumerable<MissionObjective>)Enumerable.Where<MissionObjective>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__69_);
			MissionObjective.StepCompletionChangedDelegate stepCompletionChangedDelegate = default(MissionObjective.StepCompletionChangedDelegate);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0062;
					}
					num++;
				}
				stepCompletionChangedDelegate = OnAnyObjectivesCompletionChanged;
				MissionObjective.StepStatusChangedDelegate stepStatusChangedDelegate = OnObjectiveStatusChanged;
				goto IL_0062;
			}
			goto IL_0069;
			IL_0062:
			stepCompletionChangedDelegate += stepCompletionChangedDelegate;
			goto IL_0069;
			IL_0069:
			if (enumerable == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080DB")]
		[Cpp2IlInjected.Address(RVA = "0x1A68E90", Offset = "0x1A67890", VA = "0x181A68E90")]
		public MissionSlotStringResolver StringResolver(Localizator localizator)
		{
			//Discarded unreachable code: IL_005d
			//IL_0053: Expected O, but got I4
			MissionSlotStringResolver stringResolver = _stringResolver;
			if (stringResolver == null)
			{
				MissionStep missionStep = MissionStep;
				RepeatedField<MissionObjective> repeatedField = objectives_;
				MissionSlot missionSlot = missionStep.MissionSlot;
				MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)repeatedField);
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

		[Cpp2IlInjected.Token(Token = "0x60080DC")]
		[Cpp2IlInjected.Address(RVA = "0x1A68500", Offset = "0x1A66F00", VA = "0x181A68500")]
		public string ResolveString(Localizator localizator, string locId, [Optional] IResolver extraResolver)
		{
			//Discarded unreachable code: IL_00a3
			//IL_007d: Expected O, but got I4
			if ((object)typeof(string).TypeHandle == null)
			{
				MissionSlot missionSlot = MissionStep.MissionSlot;
				List<IResolver> list = (List<IResolver>)(object)new List<T>();
				((List<T>)(object)list).Add((T)extraResolver);
				MissionSlotStringResolver stringResolver = _stringResolver;
				if (stringResolver == null)
				{
					MissionStep missionStep = MissionStep;
					RepeatedField<MissionObjective> repeatedField = objectives_;
					MissionSlot missionSlot2 = missionStep.MissionSlot;
					MissionObjective missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)repeatedField);
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

		[Cpp2IlInjected.Token(Token = "0x60080DD")]
		[Cpp2IlInjected.Address(RVA = "0x1A68480", Offset = "0x1A66E80", VA = "0x181A68480", Slot = "14")]
		public object ResolveKey(Localizator localizator, string key)
		{
			MissionObjective missionObjective;
			do
			{
				missionObjective = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)objectives_);
			}
			while (missionObjective == null);
			return missionObjective.ResolveKey(localizator, key);
		}

		[Cpp2IlInjected.Token(Token = "0x60080DE")]
		[Cpp2IlInjected.Address(RVA = "0x1A66B80", Offset = "0x1A65580", VA = "0x181A66B80")]
		internal void AddDescriptions(List<DescriptionInfo> desc, int indentation, Localizator localizator, bool all)
		{
			//IL_00ca: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_01e7: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			RepeatedField<MissionObjective> repeatedField = objectives_;
			Func<MissionObjective, bool> _003C_003E9__74_ = _003C_003Ec._003C_003E9__74_0;
			if (_003C_003E9__74_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.wasSkipped_);
			}
			if (((IEnumerable<>)(object)repeatedField).All<MissionObjective>((Func<, >)(object)_003C_003E9__74_))
			{
				return;
			}
			if (Data.BringItem == null)
			{
			}
			MissionStepStatus status = Status;
			int num = 0;
			bool flag = status >= MissionStepStatus.ReadyToBeCompleted;
			DescriptionInfo descriptionInfo = default(DescriptionInfo);
			if (flag)
			{
				MissionSubStepData.Types.ExtraBringItem bringItem = Data.BringItem;
				string readyDescription_ = bringItem.readyDescription_;
				if (bringItem == null)
				{
					MissionSubStepData missionSubStepData = Data;
					List<DescriptionInfo> list = desc;
					Localizator localizator2 = localizator;
					string readyDescription_2 = missionSubStepData.BringItem.readyDescription_;
					int num2 = 0;
					string text = ResolveString(localizator2, readyDescription_2, (IResolver)num2);
					int status2 = (int)Status;
					int num3 = indentation;
					bool flag2 = default(bool);
					DescriptionInfo item = new DescriptionInfo(text, flag2, num3, (MissionObjective)num, (Nullable<>)num, (Nullable<>)num);
					flag2 = status2 >= 3;
					((List<T>)(object)list).Add((T)item);
					descriptionInfo = ((IEnumerable<>)desc).Last<DescriptionInfo>();
					descriptionInfo.SetObjective();
				}
			}
			if (descriptionInfo == null)
			{
				return;
			}
			string stepDescription_ = Data.stepDescription_;
			int size = default(int);
			if (!flag)
			{
				if (Data.showProgressionCount_)
				{
					RepeatedField<MissionObjective> repeatedField2 = objectives_;
					Func<MissionObjective, float> func = default(Func<MissionObjective, float>);
					if (_003C_003Ec._003C_003E9__74_2 == null)
					{
						func = (Func<MissionObjective, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.ProgressCurrentAmount));
					}
					float num4 = Enumerable.Sum<MissionObjective>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func);
				}
				if (Data.showProgressionCount_)
				{
					RepeatedField<MissionObjective> repeatedField3 = objectives_;
					Func<MissionObjective, float> func2 = default(Func<MissionObjective, float>);
					if (_003C_003Ec._003C_003E9__74_3 == null)
					{
						func2 = (Func<MissionObjective, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.ProgressTargetAmount));
					}
					float num4 = Enumerable.Sum<MissionObjective>((IEnumerable<>)(object)repeatedField3, (Func<, >)(object)func2);
				}
				MissionSubStepData missionSubStepData2 = Data;
				List<DescriptionInfo> list2 = desc;
				string stepDescription_2 = missionSubStepData2.stepDescription_;
				int num5 = 0;
				Localizator localizator3 = localizator;
				string text2 = ResolveString(localizator3, stepDescription_2, (IResolver)num5);
				if (flag)
				{
				}
				bool flag3 = Status >= MissionStepStatus.Completed;
				int num6 = indentation;
				DescriptionInfo item2 = new DescriptionInfo(text2, flag3, num6, (MissionObjective)num, (Nullable<>)num, (Nullable<>)num);
				((List<T>)(object)list2).Add((T)item2);
				size = ((List<>)(object)desc)._size;
			}
			RepeatedField<MissionObjective> repeatedField4 = objectives_;
			Action<MissionObjective> action = (Action<MissionObjective>)(object)(Action<T>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_001f
				Localizator localizator4 = localizator;
				int num7 = indentation;
				List<DescriptionInfo> list4 = desc;
				x.AddDescriptions((List<>)(object)list4, num7, localizator4);
			};
			((RepeatedField<>)(object)repeatedField4).ForEach<MissionObjective>((Action<>)(object)action);
			if (size > 0)
			{
				List<DescriptionInfo> list3 = desc;
				int count = ((RepeatedField<T>)(object)objectives_).Count;
				List<DescriptionInfo> cpp2il__autoParamName__idx_ = desc;
				if (count == 1)
				{
					MissionObjective objective = Enumerable.First<MissionObjective>((IEnumerable<>)(object)objectives_);
					DescriptionInfo descriptionInfo2 = default(DescriptionInfo);
					descriptionInfo2.SetObjective(objective);
					throw new NullReferenceException();
				}
				((IEnumerable<>)cpp2il__autoParamName__idx_).Last<DescriptionInfo>().SetObjective();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080DF")]
		[Cpp2IlInjected.Address(RVA = "0x1A680D0", Offset = "0x1A66AD0", VA = "0x181A680D0")]
		private void OnAnyObjectivesCompletionChanged(MissionObjective objective, bool completed)
		{
			//Discarded unreachable code: IL_008d
			if (((RepeatedField<T>)(object)objectives_).Count > 1)
			{
				if (completed)
				{
					MissionStepStatus status = Status;
				}
				MissionStepStatus status2 = GetStatus(objective);
			}
			this.StepCompletionChanged?.Invoke(this, completed);
			if (completed)
			{
				if (objective.AutoConfirmOnCompletion && objective.status_ == MissionStepStatus.Completed)
				{
					bool flag = objective.ChangeStatus(MissionStepStatus.Confirmed);
					MissionObjective.StepCompletionChangedDelegate onCompletionChanged = OnAnyObjectivesCompletionChanged;
					MissionObjective.StepStatusChangedDelegate onStatusChanged = OnObjectiveStatusChanged;
					objective.Stop(onCompletionChanged, onStatusChanged);
				}
				if (objective.Data.skipSubStepWhenCompleted_)
				{
					ApplySkipWhenCompleted();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080E0")]
		[Cpp2IlInjected.Address(RVA = "0x1A68260", Offset = "0x1A66C60", VA = "0x181A68260")]
		private void OnObjectiveStatusChanged(MissionObjective objective, MissionStepStatus previousStatus, MissionStepStatus newStatus)
		{
			//Discarded unreachable code: IL_002d
			if (((RepeatedField<T>)(object)objectives_).Count > 1)
			{
				MissionStepStatus status = GetStatus(objective);
			}
			MissionStepStatus status2 = Status;
			if (previousStatus != status2 && this.StepStatusChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A690C0", Offset = "0x1A67AC0", VA = "0x181A690C0")]
		static MissionSubStep()
		{
			MessageParser<MissionObjective> parser = MissionObjective._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionSubStep>)(object)FieldCodec.ForMessage<MissionObjective>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
