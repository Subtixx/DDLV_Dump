using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008D6")]
	public sealed class MiniEventProgress : IMessage<MiniEventProgress>, IMessage, IEquatable<MiniEventProgress>, IDeepCloneable<MiniEventProgress>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023AE")]
		private static readonly MessageParser<MiniEventProgress> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023AF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023B0")]
		public const int CurrentMilestoneIdxFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023B1")]
		private int currentMilestoneIdx_;

		[Cpp2IlInjected.Token(Token = "0x40023B2")]
		public const int CurrentObjectiveFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023B3")]
		private ObjectiveProgress currentObjective_;

		[Cpp2IlInjected.Token(Token = "0x40023B4")]
		public const int MilestoneStatesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40023B5")]
		private static readonly FieldCodec<MilestoneState> _repeated_milestoneStates_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023B6")]
		private readonly RepeatedField<MilestoneState> milestoneStates_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40023BA")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40023BB")]
		private MiniEventData data;

		[Cpp2IlInjected.Token(Token = "0x17000CD8")]
		[DebuggerNonUserCode]
		public static MessageParser<MiniEventProgress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004BE8")]
			[Cpp2IlInjected.Address(RVA = "0x7F6990", Offset = "0x7F5390", VA = "0x1807F6990")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004BE9")]
			[Cpp2IlInjected.Address(RVA = "0x7F68C0", Offset = "0x7F52C0", VA = "0x1807F68C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004BEA")]
			[Cpp2IlInjected.Address(RVA = "0x7F69F0", Offset = "0x7F53F0", VA = "0x1807F69F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDB")]
		[DebuggerNonUserCode]
		public int CurrentMilestoneIdx
		{
			[Cpp2IlInjected.Token(Token = "0x6004BEE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return currentMilestoneIdx_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BEF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				currentMilestoneIdx_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDC")]
		[DebuggerNonUserCode]
		public ObjectiveProgress CurrentObjective
		{
			[Cpp2IlInjected.Token(Token = "0x6004BF0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return currentObjective_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BF1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				currentObjective_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDD")]
		[DebuggerNonUserCode]
		public RepeatedField<MilestoneState> MilestoneStates
		{
			[Cpp2IlInjected.Token(Token = "0x6004BF2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return milestoneStates_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDE")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6004BFE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BFF")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDF")]
		private ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6004C00")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CDispatcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C01")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CDispatcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE0")]
		private ITransactionContext Context
		{
			[Cpp2IlInjected.Token(Token = "0x6004C02")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C03")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004C04")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return name;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C05")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B10", Offset = "0x7F5510", VA = "0x1807F6B10")]
			set
			{
				if (name != value)
				{
					name = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE2")]
		public MiniEventData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6004C06")]
			[Cpp2IlInjected.Address(RVA = "0x7F67D0", Offset = "0x7F51D0", VA = "0x1807F67D0")]
			get
			{
				//Discarded unreachable code: IL_0013
				MiniEventData miniEventData = data;
				if (miniEventData == null)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				}
				return miniEventData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x40023BC")]
		public DateTime EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6004C07")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004C08")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B00", Offset = "0x7F5500", VA = "0x1807F6B00")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE4")]
		private MiniEventMilestoneData CurrentMilestone
		{
			[Cpp2IlInjected.Token(Token = "0x6004C09")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentMilestone_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C0A")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CCurrentMilestone_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BEB")]
		[Cpp2IlInjected.Address(RVA = "0x7F6690", Offset = "0x7F5090", VA = "0x1807F6690")]
		[DebuggerNonUserCode]
		public MiniEventProgress()
		{
			milestoneStates_ = (RepeatedField<MilestoneState>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BEC")]
		[Cpp2IlInjected.Address(RVA = "0x7F6710", Offset = "0x7F5110", VA = "0x1807F6710")]
		[DebuggerNonUserCode]
		public MiniEventProgress(MiniEventProgress other)
		{
			//IL_0029: Expected O, but got I4
			int num = (currentMilestoneIdx_ = other.currentMilestoneIdx_);
			ObjectiveProgress objectiveProgress = other.currentObjective_;
			if (objectiveProgress != null)
			{
				ObjectiveProgress objectiveProgress2 = objectiveProgress.Clone();
			}
			int num2 = 0;
			currentObjective_ = (ObjectiveProgress)num2;
			RepeatedField<MilestoneState> repeatedField = (milestoneStates_ = (RepeatedField<MilestoneState>)(object)((RepeatedField<T>)(object)other.milestoneStates_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BED")]
		[Cpp2IlInjected.Address(RVA = "0x7F5200", Offset = "0x7F3C00", VA = "0x1807F5200", Slot = "10")]
		[DebuggerNonUserCode]
		public MiniEventProgress Clone()
		{
			//Discarded unreachable code: IL_005d
			//IL_0031: Expected O, but got I4
			MiniEventProgress miniEventProgress = new MiniEventProgress();
			int num = (miniEventProgress.currentMilestoneIdx_ = currentMilestoneIdx_);
			ObjectiveProgress objectiveProgress = currentObjective_;
			if (objectiveProgress != null)
			{
				ObjectiveProgress objectiveProgress2 = objectiveProgress.Clone();
			}
			int num2 = 0;
			miniEventProgress.currentObjective_ = (ObjectiveProgress)num2;
			RepeatedField<MilestoneState> repeatedField = (miniEventProgress.milestoneStates_ = (RepeatedField<MilestoneState>)(object)((RepeatedField<T>)(object)milestoneStates_).Clone());
			UnknownFieldSet unknownFieldSet = (miniEventProgress._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return miniEventProgress;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF3")]
		[Cpp2IlInjected.Address(RVA = "0x7F5350", Offset = "0x7F3D50", VA = "0x1807F5350", Slot = "0")]
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
				if ((IntPtr)currentMilestoneIdx_ == (IntPtr)typeof(MiniEventProgress).TypeHandle && object.Equals(currentObjective_, other))
				{
					RepeatedField<MilestoneState> repeatedField = milestoneStates_;
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

		[Cpp2IlInjected.Token(Token = "0x6004BF4")]
		[Cpp2IlInjected.Address(RVA = "0x7F5440", Offset = "0x7F3E40", VA = "0x1807F5440", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiniEventProgress other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.currentMilestoneIdx_;
				if (currentMilestoneIdx_ == num)
				{
					ObjectiveProgress objB = other.currentObjective_;
					if (object.Equals(currentObjective_, objB))
					{
						RepeatedField<MilestoneState> repeatedField = milestoneStates_;
						RepeatedField<MilestoneState> repeatedField2 = other.milestoneStates_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF5")]
		[Cpp2IlInjected.Address(RVA = "0x7F55D0", Offset = "0x7F3FD0", VA = "0x1807F55D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003f
			if (currentMilestoneIdx_ != 0)
			{
			}
			ObjectiveProgress objectiveProgress = currentObjective_;
			if (objectiveProgress != null)
			{
				int hashCode = objectiveProgress.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)milestoneStates_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF6")]
		[Cpp2IlInjected.Address(RVA = "0x7F6230", Offset = "0x7F4C30", VA = "0x1807F6230", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF7")]
		[Cpp2IlInjected.Address(RVA = "0x7F6360", Offset = "0x7F4D60", VA = "0x1807F6360", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005b
			if (currentMilestoneIdx_ != 0)
			{
				int value = currentMilestoneIdx_;
				output.WriteInt32(value);
			}
			if ((long)currentObjective_ != 0)
			{
				ObjectiveProgress value2 = currentObjective_;
				output.WriteMessage(value2);
			}
			RepeatedField<MilestoneState> repeatedField = milestoneStates_;
			FieldCodec<MilestoneState> repeated_milestoneStates_codec = _repeated_milestoneStates_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_milestoneStates_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF8")]
		[Cpp2IlInjected.Address(RVA = "0x7F5030", Offset = "0x7F3A30", VA = "0x1807F5030", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_006e
			int num = currentMilestoneIdx_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			ObjectiveProgress objectiveProgress = currentObjective_;
			if (objectiveProgress != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(objectiveProgress);
				num4++;
				num2 += num4;
			}
			RepeatedField<MilestoneState> repeatedField = milestoneStates_;
			FieldCodec<MilestoneState> repeated_milestoneStates_codec = _repeated_milestoneStates_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_milestoneStates_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num5;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num2 += num6;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF9")]
		[Cpp2IlInjected.Address(RVA = "0x7F5A30", Offset = "0x7F4430", VA = "0x1807F5A30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniEventProgress other)
		{
			//Discarded unreachable code: IL_0088
			if (other == null)
			{
				return;
			}
			int num = other.currentMilestoneIdx_;
			if (num != 0)
			{
				currentMilestoneIdx_ = num;
			}
			if ((long)other.currentObjective_ != 0)
			{
				ObjectiveProgress objectiveProgress2 = default(ObjectiveProgress);
				if (currentObjective_ == null)
				{
					ObjectiveProgress objectiveProgress = (currentObjective_ = new ObjectiveProgress());
					objectiveProgress2 = currentObjective_;
				}
				ObjectiveProgress other2 = other.currentObjective_;
				objectiveProgress2.MergeFrom(other2);
			}
			RepeatedField<MilestoneState> repeatedField = milestoneStates_;
			RepeatedField<MilestoneState> repeatedField2 = other.milestoneStates_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004BFA")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B30", Offset = "0x7F4530", VA = "0x1807F5B30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_008d
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				num += 4294967272u;
				if (num != 4294967293u)
				{
					goto IL_0076;
				}
				RepeatedField<MilestoneState> repeatedField = milestoneStates_;
				FieldCodec<MilestoneState> repeated_milestoneStates_codec = _repeated_milestoneStates_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_milestoneStates_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (currentMilestoneIdx_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				ObjectiveProgress builder = default(ObjectiveProgress);
				if (currentObjective_ == null)
				{
					ObjectiveProgress objectiveProgress = (currentObjective_ = new ObjectiveProgress());
					builder = currentObjective_;
				}
				input.ReadMessage(builder);
			}
			goto IL_0076;
			IL_0076:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004BFB")]
		[Cpp2IlInjected.Address(RVA = "0x7F54F0", Offset = "0x7F3EF0", VA = "0x1807F54F0", Slot = "11")]
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
					RepeatedField<MilestoneState> repeatedField = milestoneStates_;
				}
				ObjectiveProgress objectiveProgress = currentObjective_;
			}
			int num2 = currentMilestoneIdx_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BFC")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E70", Offset = "0x7F4870", VA = "0x1807F5E70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002a
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						currentObjective_ = (ObjectiveProgress)num2;
						return;
					}
				}
				else
				{
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				}
				throw new InvalidCastException();
			}
			object obj = default(object);
			currentMilestoneIdx_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BFD")]
		[Cpp2IlInjected.Address(RVA = "0x7F5160", Offset = "0x7F3B60", VA = "0x1807F5160", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0021
			//IL_0020: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					RepeatedField<MilestoneState> repeatedField = milestoneStates_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
			}
			currentMilestoneIdx_ = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C0B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6050", Offset = "0x7F4A50", VA = "0x1807F6050")]
		public void Start(string name, DateTime endDate, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0061
			//IL_000e: Expected O, but got I4
			//IL_0015: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			Profile = profile;
			Dispatcher = (ProfileEventDispatcher)0;
			Context = (ITransactionContext)0;
			bool flag = this.name != name;
			int num = 0;
			if (flag)
			{
				this.name = name;
				data = (MiniEventData)num;
			}
			EndDate = endDate;
			if (Data != null)
			{
				RepeatedField<MilestoneState> repeatedField = milestoneStates_;
				currentMilestoneIdx_ = num;
				((RepeatedField<T>)(object)repeatedField).Clear();
				InitMilestone();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C0C")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F47B0", VA = "0x1807F5DB0")]
		public void Resume(string name, DateTime endDate, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//IL_000e: Expected O, but got I4
			//IL_0015: Expected O, but got I4
			Profile = profile;
			Dispatcher = (ProfileEventDispatcher)0;
			Context = (ITransactionContext)0;
			if (this.name != name)
			{
				this.name = name;
			}
			EndDate = endDate;
			if (Data != null)
			{
				ResumeMilestone();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C0D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6220", Offset = "0x7F4C20", VA = "0x1807F6220")]
		public void Stop()
		{
			StopMilestone();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C0E")]
		[Cpp2IlInjected.Address(RVA = "0x7F59C0", Offset = "0x7F43C0", VA = "0x1807F59C0")]
		public bool IsValidIndex(int index)
		{
			//Discarded unreachable code: IL_0010
			int num = 0;
			int count = ((RepeatedField<T>)(object)milestoneStates_).Count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C0F")]
		[Cpp2IlInjected.Address(RVA = "0x7F5670", Offset = "0x7F4070", VA = "0x1807F5670")]
		public MilestoneState GetState(int index)
		{
			//IL_001d: Expected I4, but got O
			int count = ((RepeatedField<T>)(object)milestoneStates_).Count;
			if (index < count)
			{
				return (MilestoneState)((RepeatedField<T>)(object)milestoneStates_)[index];
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C10")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FA0", Offset = "0x7F49A0", VA = "0x1807F5FA0")]
		public bool SetState(int index, MilestoneState newState)
		{
			int count = ((RepeatedField<T>)(object)milestoneStates_).Count;
			if (index < count)
			{
				RepeatedField<MilestoneState> repeatedField = milestoneStates_;
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C11")]
		[Cpp2IlInjected.Address(RVA = "0x7F5980", Offset = "0x7F4380", VA = "0x1807F5980")]
		public bool IsClaimed(int index)
		{
			return GetState(index) == MilestoneState.RewardsClaimed;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C12")]
		[Cpp2IlInjected.Address(RVA = "0x7F59A0", Offset = "0x7F43A0", VA = "0x1807F59A0")]
		public bool IsReadyToClaim(int index)
		{
			return GetState(index) == MilestoneState.Completed;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C13")]
		[Cpp2IlInjected.Address(RVA = "0x7F6290", Offset = "0x7F4C90", VA = "0x1807F6290")]
		private bool UpdateCurrentMilestone()
		{
			//IL_0009: Expected O, but got I8
			CurrentMilestone = (MiniEventMilestoneData)0;
			int num = currentMilestoneIdx_;
			int count = ((RepeatedField<T>)(object)data.milestones_).Count;
			if (num < count)
			{
				RepeatedField<MiniEventMilestoneData> milestones_ = data.milestones_;
				int index = currentMilestoneIdx_;
				MiniEventMilestoneData miniEventMilestoneData = (CurrentMilestone = (MiniEventMilestoneData)((RepeatedField<T>)(object)milestones_)[index]);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C14")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CB0", Offset = "0x7F46B0", VA = "0x1807F5CB0")]
		private void NextMilestone()
		{
			InitMilestone();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C15")]
		[Cpp2IlInjected.Address(RVA = "0x7F5710", Offset = "0x7F4110", VA = "0x1807F5710")]
		private void InitMilestone()
		{
			//Discarded unreachable code: IL_00eb
			//IL_0077: Expected I4, but got I8
			//IL_0077: Expected I4, but got I8
			//IL_008a: Expected I4, but got I8
			//IL_00b1: Expected I4, but got I8
			//IL_00b1: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			if (UpdateCurrentMilestone())
			{
				Random random = new Random(Profile.player_.GetRandomSeed("MiniEventRandomSeed"));
				ObjectiveProgress objectiveProgress = new ObjectiveProgress();
				ItemSelector itemSelector = CurrentMilestone.objective_.ItemSelector;
				MiniEventMilestoneData miniEventMilestoneData = CurrentMilestone;
				Profile profile = Profile;
				string name_ = miniEventMilestoneData.name_;
				string debugName = "InitMilestone:" + name_;
				int onlySeedCrop = 0;
				ulong num = default(ulong);
				ulong num2 = default(ulong);
				ItemFilter itemFilter = (objectiveProgress.itemFilter_ = ItemFilter.New(itemSelector, profile, random, (byte)onlySeedCrop != 0, (byte)num != 0, (byte)num2 != 0, debugName));
				objectiveProgress.curAmount_ = 0;
				StepAmount stepAmount = CurrentMilestone.objective_.StepAmount;
				if (stepAmount != null)
				{
					int num3 = 0;
					ulong num4 = default(ulong);
					int amount = stepAmount.GetAmount(random, 1, (Func<, >)num3, (byte)num4 != 0);
				}
				objectiveProgress.targetAmount_ = 1;
				currentObjective_ = objectiveProgress;
				Profile.player_.AdvanceRandomSeed("MiniEventRandomSeed");
				((RepeatedField<T>)(object)milestoneStates_).Add((T)2);
				ResumeMilestone();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C16")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CC0", Offset = "0x7F46C0", VA = "0x1807F5CC0")]
		private void ResumeMilestone()
		{
			//Discarded unreachable code: IL_0061
			if (UpdateCurrentMilestone())
			{
				ObjectiveProgress objectiveProgress = currentObjective_;
				EventHandler<EventArgs> eventHandler = (EventHandler<EventArgs>)(object)new EventHandler<TEventArgs>(OnObjectiveCompleted);
				objectiveProgress.add_OnObjectiveCompleted((EventHandler<>)(object)eventHandler);
				MiniEventMilestoneData miniEventMilestoneData = CurrentMilestone;
				ObjectiveProgress objectiveProgress2 = currentObjective_;
				ITransactionContext context = Context;
				ProfileEventDispatcher dispatcher = Dispatcher;
				Profile profile = Profile;
				ObjectiveData objective_ = miniEventMilestoneData.objective_;
				objectiveProgress2.Start(objective_, profile, dispatcher, context);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C17")]
		[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F3CE0", VA = "0x1807F52E0")]
		private void CompleteMilestone()
		{
			//Discarded unreachable code: IL_0024
			//IL_001d: Expected O, but got I4
			StopMilestone();
			RepeatedField<MilestoneState> repeatedField = milestoneStates_;
			int index = currentMilestoneIdx_;
			((RepeatedField<T>)(object)repeatedField)[index] = (T)3;
			InitMilestone();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C18")]
		[Cpp2IlInjected.Address(RVA = "0x7F6150", Offset = "0x7F4B50", VA = "0x1807F6150")]
		private void StopMilestone()
		{
			//IL_002f: Expected O, but got I8
			currentObjective_.Stop();
			ObjectiveProgress objectiveProgress = currentObjective_;
			EventHandler<EventArgs> eventHandler = (EventHandler<EventArgs>)(object)new EventHandler<TEventArgs>(OnObjectiveCompleted);
			objectiveProgress.remove_OnObjectiveCompleted((EventHandler<>)(object)eventHandler);
			currentObjective_ = (ObjectiveProgress)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C19")]
		[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F3CE0", VA = "0x1807F52E0")]
		private void OnObjectiveCompleted(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0024
			//IL_001d: Expected O, but got I4
			StopMilestone();
			RepeatedField<MilestoneState> repeatedField = milestoneStates_;
			int index = currentMilestoneIdx_;
			((RepeatedField<T>)(object)repeatedField)[index] = (T)3;
			InitMilestone();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C1A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6470", Offset = "0x7F4E70", VA = "0x1807F6470")]
		static MiniEventProgress()
		{
			Func<MiniEventProgress> func = default(Func<MiniEventProgress>);
			MessageParser<MiniEventProgress> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<MiniEventProgress>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<MilestoneState, int> func2 = (Func<MilestoneState, int>)(object)(Func<T, TResult>)((MilestoneState x) => (int)x);
			Func<int, MilestoneState> func3 = (Func<int, MilestoneState>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<MiniEventProgress>)(object)FieldCodec.ForEnum<MilestoneState>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
