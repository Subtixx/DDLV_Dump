using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Grids;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008DF")]
	public sealed class ObjectiveProgress : IMessage<ObjectiveProgress>, IMessage, IEquatable<ObjectiveProgress>, IDeepCloneable<ObjectiveProgress>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023EF")]
		private static readonly MessageParser<ObjectiveProgress> _parser = (MessageParser<ObjectiveProgress>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ObjectiveProgress()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023F0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023F1")]
		public const int ItemFilterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023F2")]
		private ItemFilter itemFilter_;

		[Cpp2IlInjected.Token(Token = "0x40023F3")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023F4")]
		private int targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x40023F5")]
		public const int CurAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40023F6")]
		private int curAmount_;

		[Cpp2IlInjected.Token(Token = "0x40023F7")]
		public const int ItemIdsCollectedFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40023F8")]
		private static readonly FieldCodec<int> _repeated_itemIdsCollected_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023F9")]
		private readonly RepeatedField<int> itemIdsCollected_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40023FF")]
		private bool hangoutIsStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4002400")]
		private bool hangoutIsPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002401")]
		private DateTime hangoutStartedAt = DateTime.MinValue;

		[Cpp2IlInjected.Token(Token = "0x17000D0A")]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectiveProgress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004CA5")]
			[Cpp2IlInjected.Address(RVA = "0x13A0000", Offset = "0x139EA00", VA = "0x1813A0000")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004CA6")]
			[Cpp2IlInjected.Address(RVA = "0x139FF20", Offset = "0x139E920", VA = "0x18139FF20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004CA7")]
			[Cpp2IlInjected.Address(RVA = "0x13A0060", Offset = "0x139EA60", VA = "0x1813A0060", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0D")]
		[DebuggerNonUserCode]
		public ItemFilter ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6004CAB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CAC")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				itemFilter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0E")]
		[DebuggerNonUserCode]
		public int TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004CAD")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CAE")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				targetAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D0F")]
		[DebuggerNonUserCode]
		public int CurAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004CAF")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return curAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CB0")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				curAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D10")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemIdsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6004CB1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return itemIdsCollected_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D11")]
		private ObjectiveData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6004CBD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CBE")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D12")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6004CBF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CC0")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D13")]
		private ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6004CC1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CDispatcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CC2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CDispatcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D14")]
		private ITransactionContext Context
		{
			[Cpp2IlInjected.Token(Token = "0x6004CC3")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CC4")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D15")]
		private bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6004CE5")]
			[Cpp2IlInjected.Address(RVA = "0x139FFF0", Offset = "0x139E9F0", VA = "0x18139FFF0")]
			get
			{
				int num = targetAmount_;
				return curAmount_ >= num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EventHandler<EventArgs> OnObjectiveCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6004CC5")]
			[Cpp2IlInjected.Address(RVA = "0x139FE80", Offset = "0x139E880", VA = "0x18139FE80")]
			[CompilerGenerated]
			add
			{
				EventHandler<EventArgs> onObjectiveCompleted = this.OnObjectiveCompleted;
				Delegate @delegate = Delegate.Combine(onObjectiveCompleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onObjectiveCompleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004CC6")]
			[Cpp2IlInjected.Address(RVA = "0x13A0170", Offset = "0x139EB70", VA = "0x1813A0170")]
			[CompilerGenerated]
			remove
			{
				EventHandler<EventArgs> onObjectiveCompleted = this.OnObjectiveCompleted;
				Delegate @delegate = Delegate.Remove(onObjectiveCompleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onObjectiveCompleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA8")]
		[Cpp2IlInjected.Address(RVA = "0x139FC50", Offset = "0x139E650", VA = "0x18139FC50")]
		[DebuggerNonUserCode]
		public ObjectiveProgress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA9")]
		[Cpp2IlInjected.Address(RVA = "0x139FD10", Offset = "0x139E710", VA = "0x18139FD10")]
		[DebuggerNonUserCode]
		public ObjectiveProgress(ObjectiveProgress other)
		{
			//IL_003d: Expected O, but got I4
			ItemFilter itemFilter = other.itemFilter_;
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = itemFilter.Clone();
			}
			int num = 0;
			itemFilter_ = (ItemFilter)num;
			int num2 = (targetAmount_ = other.targetAmount_);
			int num3 = (curAmount_ = other.curAmount_);
			RepeatedField<int> repeatedField = (itemIdsCollected_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemIdsCollected_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CAA")]
		[Cpp2IlInjected.Address(RVA = "0x139B990", Offset = "0x139A390", VA = "0x18139B990", Slot = "10")]
		[DebuggerNonUserCode]
		public ObjectiveProgress Clone()
		{
			//Discarded unreachable code: IL_008a
			//IL_003e: Expected O, but got I4
			ObjectiveProgress objectiveProgress = new ObjectiveProgress();
			RepeatedField<int> repeatedField = (objectiveProgress.itemIdsCollected_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			DateTime dateTime = (objectiveProgress.hangoutStartedAt = DateTime.MinValue);
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = itemFilter.Clone();
			}
			int num = 0;
			objectiveProgress.itemFilter_ = (ItemFilter)num;
			int num2 = (objectiveProgress.targetAmount_ = targetAmount_);
			int num3 = (objectiveProgress.curAmount_ = curAmount_);
			RepeatedField<int> repeatedField2 = (objectiveProgress.itemIdsCollected_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)itemIdsCollected_).Clone());
			UnknownFieldSet unknownFieldSet = (objectiveProgress._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return objectiveProgress;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB2")]
		[Cpp2IlInjected.Address(RVA = "0x139BC50", Offset = "0x139A650", VA = "0x18139BC50", Slot = "0")]
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
				bool flag = object.Equals(itemFilter_, other);
				if (flag && targetAmount_ == (flag ? 1 : 0) && curAmount_ == (flag ? 1 : 0))
				{
					RepeatedField<int> repeatedField = itemIdsCollected_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB3")]
		[Cpp2IlInjected.Address(RVA = "0x139BD50", Offset = "0x139A750", VA = "0x18139BD50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ObjectiveProgress other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemFilter objB = other.itemFilter_;
				if (object.Equals(itemFilter_, objB))
				{
					int num = other.targetAmount_;
					if (targetAmount_ == num)
					{
						int num2 = other.curAmount_;
						if (curAmount_ == num2)
						{
							RepeatedField<int> repeatedField = itemIdsCollected_;
							RepeatedField<int> repeatedField2 = other.itemIdsCollected_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB4")]
		[Cpp2IlInjected.Address(RVA = "0x139BF00", Offset = "0x139A900", VA = "0x18139BF00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0048
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				int hashCode = itemFilter.GetHashCode();
			}
			if (targetAmount_ != 0)
			{
			}
			if (curAmount_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)itemIdsCollected_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB5")]
		[Cpp2IlInjected.Address(RVA = "0x139F720", Offset = "0x139E120", VA = "0x18139F720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB6")]
		[Cpp2IlInjected.Address(RVA = "0x139F9D0", Offset = "0x139E3D0", VA = "0x18139F9D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0074
			if ((long)itemFilter_ != 0)
			{
				ItemFilter value = itemFilter_;
				output.WriteMessage(value);
			}
			if (targetAmount_ != 0)
			{
				int value2 = targetAmount_;
				output.WriteInt32(value2);
			}
			if (curAmount_ != 0)
			{
				int value3 = curAmount_;
				output.WriteInt32(value3);
			}
			RepeatedField<int> repeatedField = itemIdsCollected_;
			FieldCodec<int> repeated_itemIdsCollected_codec = _repeated_itemIdsCollected_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemIdsCollected_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB7")]
		[Cpp2IlInjected.Address(RVA = "0x139B6E0", Offset = "0x139A0E0", VA = "0x18139B6E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_008f
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			if (itemFilter != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(itemFilter);
			}
			int num3 = targetAmount_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			int num5 = curAmount_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			RepeatedField<int> repeatedField = itemIdsCollected_;
			FieldCodec<int> repeated_itemIdsCollected_codec = _repeated_itemIdsCollected_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemIdsCollected_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num7;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB8")]
		[Cpp2IlInjected.Address(RVA = "0x139C180", Offset = "0x139AB80", VA = "0x18139C180", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ObjectiveProgress other)
		{
			//Discarded unreachable code: IL_0098
			if (other == null)
			{
				return;
			}
			if ((long)other.itemFilter_ != 0)
			{
				ItemFilter itemFilter = itemFilter_;
				if (itemFilter == null)
				{
					ItemFilter itemFilter2 = (itemFilter_ = new ItemFilter());
				}
				ItemFilter other2 = other.itemFilter_;
				itemFilter.MergeFrom(other2);
			}
			int num = other.targetAmount_;
			if (num != 0)
			{
				targetAmount_ = num;
			}
			int num2 = other.curAmount_;
			if (num2 != 0)
			{
				curAmount_ = num2;
			}
			RepeatedField<int> repeatedField = itemIdsCollected_;
			RepeatedField<int> repeatedField2 = other.itemIdsCollected_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB9")]
		[Cpp2IlInjected.Address(RVA = "0x139C290", Offset = "0x139AC90", VA = "0x18139C290", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (curAmount_ = input.ReadInt32());
				}
				num += 4294967264u;
				if (num != 4294967293u)
				{
					goto IL_0090;
				}
				RepeatedField<int> repeatedField = itemIdsCollected_;
				FieldCodec<int> repeated_itemIdsCollected_codec = _repeated_itemIdsCollected_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemIdsCollected_codec);
			}
			ItemFilter itemFilter = default(ItemFilter);
			if (num == 10)
			{
				ItemFilter builder = default(ItemFilter);
				if (itemFilter_ == null)
				{
					itemFilter = (itemFilter_ = new ItemFilter());
					builder = itemFilter_;
				}
				input.ReadMessage(builder);
			}
			if ((long)itemFilter == 16)
			{
				int num3 = (targetAmount_ = input.ReadInt32());
			}
			goto IL_0090;
			IL_0090:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBA")]
		[Cpp2IlInjected.Address(RVA = "0x139BE10", Offset = "0x139A810", VA = "0x18139BE10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0)
				{
					if (num != 1)
					{
						goto IL_0029;
					}
					RepeatedField<int> repeatedField = itemIdsCollected_;
				}
				int num2 = targetAmount_;
			}
			ItemFilter itemFilter = itemFilter_;
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBB")]
		[Cpp2IlInjected.Address(RVA = "0x139E5C0", Offset = "0x139CFC0", VA = "0x18139E5C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			//IL_0023: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num == 1)
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					object obj = default(object);
					curAmount_ = (int)obj;
				}
				else
				{
					object obj2 = default(object);
					targetAmount_ = (int)obj2;
				}
				return;
			}
			if (value == null || value != null)
			{
				itemFilter_ = (ItemFilter)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBC")]
		[Cpp2IlInjected.Address(RVA = "0x139B8E0", Offset = "0x139A2E0", VA = "0x18139B8E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0030
			//IL_0024: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					RepeatedField<int> repeatedField = itemIdsCollected_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
				curAmount_ = 0;
			}
			else
			{
				targetAmount_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC7")]
		[Cpp2IlInjected.Address(RVA = "0x139E740", Offset = "0x139D140", VA = "0x18139E740")]
		public void Start(ObjectiveData objectiveData, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//IL_001c: Expected O, but got I4
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			Data = objectiveData;
			Profile = profile;
			Dispatcher = dispatcher;
			Context = (ITransactionContext)0;
			ObjectiveData.ObjectiveOneofCase objectiveCase_ = objectiveData.objectiveCase_;
			if ((long)typeof(ProfileEventDispatcher.StoreItemBought).TypeHandle <= 12)
			{
				ProfileEventDispatcher profileEventDispatcher = Dispatcher;
				ProfileEventDispatcher.FishingResultReceived value = OnFishingResultReceived;
				profileEventDispatcher.OnFishingResultReceived += value;
				ProfileEventDispatcher profileEventDispatcher2 = Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
				profileEventDispatcher2.OnCurrencyChanged += value2;
				ProfileEventDispatcher profileEventDispatcher3 = Dispatcher;
				ProfileEventDispatcher.MealCooked value3 = OnMealCooked;
				profileEventDispatcher3.OnMealCooked += value3;
				ProfileEventDispatcher profileEventDispatcher4 = Dispatcher;
				ProfileEventDispatcher.MiningRockEmptied value4 = OnMiningMineral;
				profileEventDispatcher4.OnMiningRockEmptied += value4;
				ProfileEventDispatcher profileEventDispatcher5 = Dispatcher;
				ProfileEventDispatcher.GardeningEvent value5 = OnGardeningHarvest;
				profileEventDispatcher5.OnGardeningEvent += value5;
				ProfileEventDispatcher profileEventDispatcher6 = Dispatcher;
				ProfileEventDispatcher.GardeningEvent value6 = OnGardeningPlant;
				profileEventDispatcher6.OnGardeningEvent += value6;
				ProfileEventDispatcher profileEventDispatcher7 = Dispatcher;
				ProfileEventDispatcher.GridChanged value7 = OnGridChanged;
				profileEventDispatcher7.OnGridChanged += value7;
				return;
			}
			ProfileEventDispatcher.DutyAchRewardCollected dutyAchRewardCollected = default(ProfileEventDispatcher.DutyAchRewardCollected);
			int num = default(int);
			ProfileEventDispatcher profileEventDispatcher8 = default(ProfileEventDispatcher);
			if (objectiveCase_ == ObjectiveData.ObjectiveOneofCase.RoyalDuties)
			{
				profileEventDispatcher8 = Dispatcher;
				dutyAchRewardCollected = OnDutyAchRewardCollected;
				num = 0;
				profileEventDispatcher8.OnDutyAchRewardCollected += dutyAchRewardCollected;
			}
			while ((long)dutyAchRewardCollected > 14)
			{
			}
			profileEventDispatcher8 = (ProfileEventDispatcher)(profileEventDispatcher8 + num);
			ProfileEventDispatcher profileEventDispatcher9 = Dispatcher;
			ProfileEventDispatcher.DiscussionEnded value8 = OnDiscussionEnded;
			profileEventDispatcher9.OnDiscussionEnded += value8;
			ProfileEventDispatcher profileEventDispatcher10 = Dispatcher;
			ProfileEventDispatcher.ItemsGivenToCharacter value9 = OnItemsGivenToCharacter;
			profileEventDispatcher10.OnItemsGivenToCharacter += value9;
			ProfileEventDispatcher profileEventDispatcher11 = Dispatcher;
			ProfileEventDispatcher.RestaurantOrderFulfilled value10 = OnRestaurantOrderFulfilled;
			profileEventDispatcher11.OnRestaurantOrderFulfilled += value10;
			if (Data.PurchaseItem.locationCase_ == CustomStepPurchaseItem.LocationOneofCase.Store)
			{
				ProfileEventDispatcher profileEventDispatcher12 = Dispatcher;
				ProfileEventDispatcher.StoreItemBought value11 = OnStoreItemBought;
				profileEventDispatcher12.OnStoreItemBought += value11;
			}
			ProfileEventDispatcher profileEventDispatcher13 = Dispatcher;
			ProfileEventDispatcher.ShopItemBought value12 = OnShopItemBought;
			profileEventDispatcher13.OnShopItemBought += value12;
			ProfileEventDispatcher profileEventDispatcher14 = Dispatcher;
			ProfileEventDispatcher.CraftingCompleted value13 = OnCraftingCompleted;
			profileEventDispatcher14.OnCraftingCompleted += value13;
			ProfileEventDispatcher profileEventDispatcher15 = Dispatcher;
			ProfileEventDispatcher.CompanionPetted value14 = OnCompanionPetted;
			profileEventDispatcher15.OnCompanionPetted += value14;
			ProfileEventDispatcher profileEventDispatcher16 = Dispatcher;
			ProfileEventDispatcher.PictureTaken value15 = OnPictureTaken;
			profileEventDispatcher16.OnPictureTaken += value15;
			ProfileEventDispatcher profileEventDispatcher17 = Dispatcher;
			ProfileEventDispatcher.HangoutChanged value16 = OnHangoutChanged;
			profileEventDispatcher17.OnHangoutChanged += value16;
			ProfileEventDispatcher profileEventDispatcher18 = Dispatcher;
			ProfileEventDispatcher.CurrentSceneChanged currentSceneChanged = OnCurrentSceneChanged;
			profileEventDispatcher18.OnCurrentSceneChanged += currentSceneChanged;
			if (((Delegate)currentSceneChanged).method_ptr != (IntPtr)0)
			{
				ItemFilter itemFilter = itemFilter_;
				CharacterItemData characterItemData = default(CharacterItemData);
				int iD = characterItemData.ID;
				bool flag = default(bool);
				if (flag)
				{
					HangoutStart();
				}
			}
			HangoutStop();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC8")]
		[Cpp2IlInjected.Address(RVA = "0x139F020", Offset = "0x139DA20", VA = "0x18139F020")]
		public void Stop()
		{
			//Discarded unreachable code: IL_0272
			ProfileEventDispatcher profileEventDispatcher = Dispatcher;
			if (profileEventDispatcher != null)
			{
				ProfileEventDispatcher.FishingResultReceived value = OnFishingResultReceived;
				profileEventDispatcher.OnFishingResultReceived -= value;
				ProfileEventDispatcher profileEventDispatcher2 = Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value2 = OnCurrencyChanged;
				profileEventDispatcher2.OnCurrencyChanged -= value2;
				ProfileEventDispatcher profileEventDispatcher3 = Dispatcher;
				ProfileEventDispatcher.MealCooked value3 = OnMealCooked;
				profileEventDispatcher3.OnMealCooked -= value3;
				ProfileEventDispatcher profileEventDispatcher4 = Dispatcher;
				ProfileEventDispatcher.GardeningEvent value4 = OnGardeningHarvest;
				profileEventDispatcher4.OnGardeningEvent -= value4;
				ProfileEventDispatcher profileEventDispatcher5 = Dispatcher;
				ProfileEventDispatcher.GardeningEvent value5 = OnGardeningPlant;
				profileEventDispatcher5.OnGardeningEvent -= value5;
				ProfileEventDispatcher profileEventDispatcher6 = Dispatcher;
				ProfileEventDispatcher.ItemsGivenToCharacter value6 = OnItemsGivenToCharacter;
				profileEventDispatcher6.OnItemsGivenToCharacter -= value6;
				ProfileEventDispatcher profileEventDispatcher7 = Dispatcher;
				ProfileEventDispatcher.GridChanged value7 = OnGridChanged;
				profileEventDispatcher7.OnGridChanged -= value7;
				ProfileEventDispatcher profileEventDispatcher8 = Dispatcher;
				ProfileEventDispatcher.DutyAchRewardCollected value8 = OnDutyAchRewardCollected;
				profileEventDispatcher8.OnDutyAchRewardCollected -= value8;
				ProfileEventDispatcher profileEventDispatcher9 = Dispatcher;
				ProfileEventDispatcher.ShopItemsSold value9 = OnShopItemsSold;
				profileEventDispatcher9.OnShopItemsSold -= value9;
				ProfileEventDispatcher profileEventDispatcher10 = Dispatcher;
				ProfileEventDispatcher.RestaurantOrderFulfilled value10 = OnRestaurantOrderFulfilled;
				profileEventDispatcher10.OnRestaurantOrderFulfilled -= value10;
				ProfileEventDispatcher profileEventDispatcher11 = Dispatcher;
				ProfileEventDispatcher.DiscussionEnded value11 = OnDiscussionEnded;
				profileEventDispatcher11.OnDiscussionEnded -= value11;
				ProfileEventDispatcher profileEventDispatcher12 = Dispatcher;
				ProfileEventDispatcher.MiningRockEmptied value12 = OnMiningMineral;
				profileEventDispatcher12.OnMiningRockEmptied -= value12;
				ProfileEventDispatcher profileEventDispatcher13 = Dispatcher;
				ProfileEventDispatcher.StoreItemBought value13 = OnStoreItemBought;
				profileEventDispatcher13.OnStoreItemBought -= value13;
				ProfileEventDispatcher profileEventDispatcher14 = Dispatcher;
				ProfileEventDispatcher.ShopItemBought value14 = OnShopItemBought;
				profileEventDispatcher14.OnShopItemBought -= value14;
				ProfileEventDispatcher profileEventDispatcher15 = Dispatcher;
				ProfileEventDispatcher.CraftingCompleted value15 = OnCraftingCompleted;
				profileEventDispatcher15.OnCraftingCompleted -= value15;
				ProfileEventDispatcher profileEventDispatcher16 = Dispatcher;
				ProfileEventDispatcher.CompanionPetted value16 = OnCompanionPetted;
				profileEventDispatcher16.OnCompanionPetted -= value16;
				ProfileEventDispatcher profileEventDispatcher17 = Dispatcher;
				ProfileEventDispatcher.PictureTaken value17 = OnPictureTaken;
				profileEventDispatcher17.OnPictureTaken -= value17;
				ProfileEventDispatcher profileEventDispatcher18 = Dispatcher;
				ProfileEventDispatcher.HangoutChanged value18 = OnHangoutChanged;
				profileEventDispatcher18.OnHangoutChanged -= value18;
				ProfileEventDispatcher profileEventDispatcher19 = Dispatcher;
				ProfileEventDispatcher.CurrentSceneChanged value19 = OnCurrentSceneChanged;
				profileEventDispatcher19.OnCurrentSceneChanged -= value19;
				ProfileEventDispatcher profileEventDispatcher20 = Dispatcher;
				ProfileEventDispatcher.GridChanged value20 = DigTile_OnGridChanged;
				profileEventDispatcher20.OnGridChanged -= value20;
				HangoutStop();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC9")]
		[Cpp2IlInjected.Address(RVA = "0x139C9B0", Offset = "0x139B3B0", VA = "0x18139C9B0")]
		private void OnFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_010e
			//IL_0014: Expected O, but got I4
			//IL_009f: Expected O, but got I4
			int itemID = fishItem.ItemID;
			int? criticalSuccessMinigameID2 = (int?)(object)0;
			HangoutWithCharacter with_ = Data.CatchFish.with_;
			Profile profile = Profile;
			bool flag = default(bool);
			if (!with_.CurrentHangoutCharacterIsValid(profile) || (Data.CatchFish.targetItem_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.FilterGenerator && Data.CatchFish.targetItem_.FilterGenerator.fishLocation_.useField_ && !flag) || !success)
			{
				return;
			}
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int num = 0;
			int num2 = 0;
			((List<T>)(object)list).Add((T)num);
			List<(Item, ItemState)> list2 = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list);
			if (list2 != null)
			{
				int size = ((List<>)(object)list2)._size;
				if (size > 0)
				{
					int incAmount = size * amount;
					UpdateCurrentProgression(incAmount);
				}
			}
			ProfileEventDispatcher profileEventDispatcher = Dispatcher;
			ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
			profileEventDispatcher.OnItemCollectMinigameEnded += value;
			ProfileEventDispatcher profileEventDispatcher2 = Dispatcher;
			ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
			profileEventDispatcher2.OnMinigameItemsCollected += value2;
			[Cpp2IlInjected.Token(Token = "0x6004CEC")]
			[Cpp2IlInjected.Address(RVA = "0x1306640", Offset = "0x1305040", VA = "0x181306640")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				int num3 = default(int);
				int num5 = default(int);
				do
				{
					if (minigame.ID != num3)
					{
						return;
					}
					if (!IsCompleted)
					{
						List<(Item item, ItemState state)> itemList = (List<(Item item, ItemState state)>)(object)new List<T>();
						RepeatedField<ItemInstance> items_ = items.items_;
						Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
						{
							//Discarded unreachable code: IL_003a
							//IL_002f: Expected O, but got I4
							List<(Item, ItemState)> list4 = itemList;
							Item item = x.Item;
							ItemState state_ = x.state_;
							int num6 = 0;
							int itemID2 = item.ItemID;
							int amount_ = x.amount_;
							IEnumerable<(Item, ItemState)> enumerable = (IEnumerable<(Item, ItemState)>)Enumerable.Repeat<(Item, ItemState)>(((Item, ItemState))num6, amount_);
							((List<T>)(object)list4).AddRange((IEnumerable<>)enumerable);
						};
						((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
						ObjectiveProgress objectiveProgress = this;
						List<(Item, ItemState)> list3 = itemList;
						int num4 = 0;
						objectiveProgress.CheckForCompletion((List<>)(object)list3, num4, 1);
						return;
					}
				}
				while (minigame.ID != num5);
				ProfileEventDispatcher profileEventDispatcher3 = Dispatcher;
				ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
				profileEventDispatcher3.OnItemCollectMinigameEnded -= value3;
				ProfileEventDispatcher profileEventDispatcher4 = Dispatcher;
				ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
				profileEventDispatcher4.OnMinigameItemsCollected -= value4;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004CEB")]
			[Cpp2IlInjected.Address(RVA = "0x1306910", Offset = "0x1305310", VA = "0x181306910")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_004c
				int num7 = default(int);
				if (minigame.ID == num7)
				{
					ProfileEventDispatcher profileEventDispatcher5 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value5 = MinigameStopped;
					profileEventDispatcher5.OnItemCollectMinigameEnded -= value5;
					ProfileEventDispatcher profileEventDispatcher6 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value6 = MinigameItemsCollected;
					profileEventDispatcher6.OnMinigameItemsCollected -= value6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CCA")]
		[Cpp2IlInjected.Address(RVA = "0x139C580", Offset = "0x139AF80", VA = "0x18139C580")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_004c
			//IL_001c: Expected O, but got I4
			int itemID = currencyItem.ItemID;
			if (gained <= 0)
			{
				return;
			}
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int num = 0;
			int num2 = 0;
			((List<T>)(object)list).Add((T)num);
			List<(Item, ItemState)> list2 = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list);
			if (list2 != null)
			{
				int size = ((List<>)(object)list2)._size;
				if (size > 0)
				{
					int incAmount = size * gained;
					UpdateCurrentProgression(incAmount);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CCB")]
		[Cpp2IlInjected.Address(RVA = "0x139D750", Offset = "0x139C150", VA = "0x18139D750")]
		private void OnMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			//Discarded unreachable code: IL_006d
			//IL_0023: Expected O, but got I4
			int itemID = mealItem.ItemID;
			bool flag = default(bool);
			int num = default(int);
			if (!flag || num <= 0)
			{
				return;
			}
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int num2 = 0;
			int num3 = 0;
			((List<T>)(object)list).Add((T)num2);
			Func<KeyValuePair<Item, int>, (Item, ItemState)> _003C_003E9__66_ = _003C_003Ec._003C_003E9__66_0;
			if (_003C_003E9__66_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num4 = 0;
					/*Error: Unexpected end of block*/;
				};
			}
			IEnumerable<KeyValuePair<Item, int>> enumerable = (IEnumerable<KeyValuePair<Item, int>>)Enumerable.Select<KeyValuePair<Item, int>, (Item, ItemState)>((IEnumerable<>)ingredients, (Func<, >)(object)_003C_003E9__66_);
			((List<T>)(object)list).AddRange((IEnumerable<>)enumerable);
			if (itemFilter_.ApplyFilter((IEnumerable<>)list) != null)
			{
				UpdateCurrentProgression(1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CCC")]
		[Cpp2IlInjected.Address(RVA = "0x139CF10", Offset = "0x139B910", VA = "0x18139CF10")]
		private void OnGardeningHarvest(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_00b6
			//IL_000d: Expected O, but got I4
			GardeningDetail detail2 = (GardeningDetail)0;
			HangoutWithCharacter with_ = Data.GardeningHarvest.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)this.OnGardeningEvent(gridObject, slotIndex);
			if (list != null)
			{
				List<(Item, ItemState)> list2 = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list);
				if (list2 != null)
				{
					int size = ((List<>)(object)list2)._size;
					if (size > 0)
					{
						UpdateCurrentProgression(size);
					}
				}
			}
			GardeningDetail gardeningDetail = detail2;
			ProfileEventDispatcher profileEventDispatcher = Dispatcher;
			ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
			profileEventDispatcher.OnItemCollectMinigameEnded += value;
			ProfileEventDispatcher profileEventDispatcher2 = Dispatcher;
			ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
			profileEventDispatcher2.OnMinigameItemsCollected += value2;
			[Cpp2IlInjected.Token(Token = "0x6004CF7")]
			[Cpp2IlInjected.Address(RVA = "0x1306B30", Offset = "0x1305530", VA = "0x181306B30")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				GardeningDetail gardeningDetail2 = detail2;
				int num = default(int);
				if (minigame.ID == num)
				{
					if (IsCompleted)
					{
						throw new NullReferenceException();
					}
					List<(Item item, ItemState state)> itemList = (List<(Item item, ItemState state)>)(object)new List<T>();
					RepeatedField<ItemInstance> items_ = items.items_;
					Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
					{
						//Discarded unreachable code: IL_003a
						//IL_002f: Expected O, but got I4
						List<(Item, ItemState)> list4 = itemList;
						Item item = x.Item;
						ItemState state_ = x.state_;
						int num4 = 0;
						int itemID = item.ItemID;
						int amount_ = x.amount_;
						IEnumerable<(Item, ItemState)> enumerable = (IEnumerable<(Item, ItemState)>)Enumerable.Repeat<(Item, ItemState)>(((Item, ItemState))num4, amount_);
						((List<T>)(object)list4).AddRange((IEnumerable<>)enumerable);
					};
					((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
					ObjectiveProgress objectiveProgress = this;
					List<(Item, ItemState)> list3 = itemList;
					int num2 = 0;
					uint num3 = default(uint);
					objectiveProgress.CheckForCompletion((List<>)(object)list3, num2, (int)num3);
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6004CF6")]
			[Cpp2IlInjected.Address(RVA = "0x1306E20", Offset = "0x1305820", VA = "0x181306E20")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_0055
				GardeningDetail gardeningDetail3 = detail2;
				int num5 = default(int);
				if (minigame.ID == num5)
				{
					ProfileEventDispatcher profileEventDispatcher3 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
					profileEventDispatcher3.OnItemCollectMinigameEnded -= value3;
					ProfileEventDispatcher profileEventDispatcher4 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
					profileEventDispatcher4.OnMinigameItemsCollected -= value4;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CCD")]
		[Cpp2IlInjected.Address(RVA = "0x139D130", Offset = "0x139BB30", VA = "0x18139D130")]
		private void OnGardeningPlant(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_0031
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)this.OnGardeningEvent(gridObject, slotIndex);
			if (list == null)
			{
				return;
			}
			List<(Item, ItemState)> list2 = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list);
			if (list2 != null)
			{
				int size = ((List<>)(object)list2)._size;
				if (size > 0)
				{
					UpdateCurrentProgression(size);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CCE")]
		[Cpp2IlInjected.Address(RVA = "0x139CCE0", Offset = "0x139B6E0", VA = "0x18139CCE0")]
		private List<(Item, ItemState)> OnGardeningEvent(GridObject gridObject, int slotIndex)
		{
			//IL_0044: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
			SeedItemData seedItemData = default(SeedItemData);
			if (seedItemData != null && (object)seedItemData.ProducedItem == null)
			{
				int num = 0;
				int num2 = 0;
				int producedAmount_ = seedItemData.producedAmount_;
				return (List<(Item, ItemState)>)(object)Enumerable.ToList<(Item, ItemState)>(Enumerable.Repeat<(Item, ItemState)>(((Item, ItemState))num, producedAmount_));
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CCF")]
		[Cpp2IlInjected.Address(RVA = "0x139D3F0", Offset = "0x139BDF0", VA = "0x18139D3F0")]
		private void OnItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false)
		{
			//Discarded unreachable code: IL_010a
			//IL_0022: Expected O, but got I4
			int itemID = characterItem.ItemID;
			bool alreadyGifted2 = false;
			Item characterItem2 = (Item)itemID;
			bool flag = default(bool);
			if (flag)
			{
				return;
			}
			CustomStepGiftToCharacterItem giftToCharacter = Data.GiftToCharacter;
			Item characterItem3 = characterItem2;
			if (!giftToCharacter.IsValid(characterItem3))
			{
				return;
			}
			Func<KeyValuePair<(Item, ItemState), int>, Item> _003C_003E9__70_ = _003C_003Ec._003C_003E9__70_0;
			if (_003C_003E9__70_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<KeyValuePair<(Item, ItemState), int>, Item>((IEnumerable<>)itemsGiven, (Func<, >)(object)_003C_003E9__70_));
			if (Data.GiftToCharacter.mustBeFavoriteThing_)
			{
				Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0021
					ProfileWorld world_ = Profile.world_;
					bool flag2 = default(bool);
					return (!flag2) ? flag2 : (!alreadyGifted2);
				};
				List<Item> list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Where<Item>((IEnumerable<>)list, (Func<, >)(object)func));
			}
			if (Data.GiftToCharacter.targetItem_.itemSelectorCase_ != 0)
			{
				ItemFilter itemFilter = itemFilter_;
				int num = 0;
				if (itemFilter.GetItemsQuantity((Dictionary<, >)(object)itemsGiven, (byte)num != 0) == 0)
				{
					return;
				}
			}
			if (Data.GiftToCharacter.useDifferentCharacter_)
			{
				Item item = characterItem2;
				if (!AddItemCollected(item))
				{
					return;
				}
			}
			UpdateCurrentProgression(1);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD0")]
		[Cpp2IlInjected.Address(RVA = "0x139D1C0", Offset = "0x139BBC0", VA = "0x18139D1C0")]
		private void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_008b
			//IL_0061: Expected O, but got I4
			int num = (int)operation;
			if (num != 1)
			{
				return;
			}
			HangoutWithCharacter with_ = Data.PickUp.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int itemID = gridObject.ItemID;
			GridState state_ = gridObject.state_;
			num = itemID;
			if (state_ == null || state_.ItemAmountState != null)
			{
			}
			int num2 = 0;
			int num3 = 0;
			((List<T>)(object)list).Add((T)num3);
			List<(Item, ItemState)> list2 = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list);
			if (list2 != null)
			{
				int size = ((List<>)(object)list2)._size;
				if (size > 0)
				{
					UpdateCurrentProgression(size);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD1")]
		[Cpp2IlInjected.Address(RVA = "0x139C870", Offset = "0x139B270", VA = "0x18139C870")]
		private void OnDutyAchRewardCollected(List<AnyReward> rewards, DutyAchItemType dutyAchtype, Item royalDutyItem)
		{
			//Discarded unreachable code: IL_0041
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			if (royalDutyItemData == null)
			{
				return;
			}
			if (Data.RoyalDuties.type_ != 0)
			{
				CustomStepRoyalDuties royalDuties = Data.RoyalDuties;
				DutyType type_ = royalDutyItemData.type_;
				if (royalDuties.type_ != type_)
				{
					return;
				}
			}
			UpdateCurrentProgression(1);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD2")]
		[Cpp2IlInjected.Address(RVA = "0x139E1B0", Offset = "0x139CBB0", VA = "0x18139E1B0")]
		private void OnShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> items, IEnumerable<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_0058, IL_005e, IL_0064, IL_006a
			//IL_0037: Expected O, but got I4
			List<(Item, ItemState)> list;
			uint num2 = default(uint);
			int num3 = default(int);
			Item item = default(Item);
			do
			{
				int num = 0;
				list = (List<(Item, ItemState)>)(object)new List<T>();
				if (list != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_003b;
						}
						num++;
					}
					num3 = 0;
					object syncRoot = ((List<>)(object)list)._syncRoot;
					int itemID = item.ItemID;
					((List<T>)(object)list).Add((T)num3);
					num++;
				}
				goto IL_003b;
				IL_003b:
				if (list != null)
				{
				}
			}
			while (num3 != 0);
			List<(Item, ItemState)> list2 = default(List<(Item, ItemState)>);
			if (list != null && list2 != null && ((List<>)(object)list2)._size <= 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD3")]
		[Cpp2IlInjected.Address(RVA = "0x139E0B0", Offset = "0x139CAB0", VA = "0x18139E0B0")]
		private void OnShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery)
		{
			do
			{
				CustomStepPurchaseItem.LocationOneofCase locationCase_ = Data.PurchaseItem.locationCase_;
				if (locationCase_ == CustomStepPurchaseItem.LocationOneofCase.Store)
				{
					return;
				}
				if (locationCase_ != CustomStepPurchaseItem.LocationOneofCase.Shop)
				{
					break;
				}
				while (locationCase_ != CustomStepPurchaseItem.LocationOneofCase.Shop)
				{
				}
			}
			while (Data.PurchaseItem.Shop == null && Data.PurchaseItem.Shop != shopName);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD4")]
		[Cpp2IlInjected.Address(RVA = "0x139E450", Offset = "0x139CE50", VA = "0x18139E450")]
		private void OnStoreItemBought(Item building, Item item, int displayIdx)
		{
			//Discarded unreachable code: IL_0030
			ObjectiveData objectiveData = Data;
			int itemID = building.ItemID;
			if (objectiveData.PurchaseItem.Store != 0 && Data.PurchaseItem.Store != itemID)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD5")]
		[Cpp2IlInjected.Address(RVA = "0x139E4E0", Offset = "0x139CEE0", VA = "0x18139E4E0")]
		private void PurchaseItemProgress(Item item, int amount)
		{
			//Discarded unreachable code: IL_002e
			if ((object)typeof(Item).TypeHandle != null)
			{
				return;
			}
			if (Data.PurchaseItem.mustPurchaseSpecificItems_)
			{
				ItemFilter itemFilter = itemFilter_;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
			}
			UpdateCurrentProgression(amount);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD6")]
		[Cpp2IlInjected.Address(RVA = "0x139DF50", Offset = "0x139C950", VA = "0x18139DF50")]
		private void OnRestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed)
		{
			//Discarded unreachable code: IL_003f
			if (order.fulfilled_)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = mealServed.Item;
				ObjectiveData objectiveData = Data;
				MealItemData mealItemData = default(MealItemData);
				int starRating_ = mealItemData.starRating_;
				ScalableValue value = objectiveData.ServeRestaurantOrder.MinimumStarRating.Value;
				UpdateCurrentProgression(1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD7")]
		[Cpp2IlInjected.Address(RVA = "0x139C7E0", Offset = "0x139B1E0", VA = "0x18139C7E0")]
		private void OnDiscussionEnded(Item characterItem)
		{
			//Discarded unreachable code: IL_002f
			CustomStepStartDiscussion startDiscussion = Data.StartDiscussion;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && (!Data.StartDiscussion.useDifferentCharacter_ || flag2))
			{
				UpdateCurrentProgression(1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD8")]
		[Cpp2IlInjected.Address(RVA = "0x139C440", Offset = "0x139AE40", VA = "0x18139C440")]
		private void OnCraftingCompleted(Item craftingRecipeItem, int amountOfCraftingDone)
		{
			//Discarded unreachable code: IL_0029
			int itemID = craftingRecipeItem.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				ItemFilter itemFilter = itemFilter_;
				int num = default(int);
				if (num != 0)
				{
					itemID = num;
					UpdateCurrentProgression(itemID);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD9")]
		[Cpp2IlInjected.Address(RVA = "0x139DA20", Offset = "0x139C420", VA = "0x18139DA20")]
		private void OnMiningMineral(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID)
		{
			HangoutWithCharacter with_ = Data.MineMineral.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			if (((RepeatedField<T>)(object)Data.MineMineral.locations_).Count > 0)
			{
				RepeatedField<ActivityDataLocationFilter> locations_ = Data.MineMineral.locations_;
				Predicate<ActivityDataLocationFilter> predicate = (Predicate<ActivityDataLocationFilter>)(object)(Predicate<T>)delegate(ActivityDataLocationFilter x)
				{
					//Discarded unreachable code: IL_000f
					ActivityDataLocationFilter other = location;
					return x.Equals(other);
				};
				if (!((RepeatedField<>)(object)locations_).Any<ActivityDataLocationFilter>((Predicate<>)(object)predicate))
				{
					return;
				}
			}
			if (!Data.MineMineral.acceptMiningFailure_)
			{
				if (success)
				{
					Func<ItemWithState, int> func = (Func<ItemWithState, int>)(object)(Func<T, TResult>)delegate(ItemWithState r)
					{
						//Discarded unreachable code: IL_0015
						ItemFilter itemFilter = itemFilter_;
						Item item = r.Item;
						int result = default(int);
						return result;
					};
					int incAmount = default(int);
					UpdateCurrentProgression(incAmount);
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CDA")]
		[Cpp2IlInjected.Address(RVA = "0x139C430", Offset = "0x139AE30", VA = "0x18139C430")]
		private void OnCompanionPetted(Item companionItem)
		{
			UpdateCurrentProgression(1);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CDB")]
		[Cpp2IlInjected.Address(RVA = "0x139DCB0", Offset = "0x139C6B0", VA = "0x18139DCB0")]
		private void OnPictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType sceneType)
		{
			//Discarded unreachable code: IL_00b7
			CustomStepTakePicture takePicture = Data.TakePicture;
			OptionalField location_ = takePicture.location_;
			if (location_.useField_)
			{
				SceneType scene = location_.Scene;
			}
			List<Item> list2 = default(List<Item>);
			if (takePicture.itemCase_ != 0)
			{
				Func<int, Item> func = default(Func<int, Item>);
				if (_003C_003Ec._003C_003E9__82_0 == null)
				{
					func = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle));
				}
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)itemIds, (Func<, >)(object)func));
				CustomStepTakePicture.ItemOneofCase itemCase_ = takePicture.itemCase_;
				int value_;
				if (itemCase_ != CustomStepTakePicture.ItemOneofCase.TargetGroup)
				{
					if (itemCase_ != CustomStepTakePicture.ItemOneofCase.TargetItem)
					{
						goto IL_00a0;
					}
					value_ = takePicture.amountOfItems_.Value.value_;
				}
				value_ = ((RepeatedField<T>)(object)takePicture.TargetGroup.items_).Count;
				list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Distinct<Item>((IEnumerable<>)list));
				goto IL_00a0;
			}
			goto IL_00af;
			IL_00af:
			UpdateCurrentProgression(1);
			return;
			IL_00a0:
			List<Item> list3 = (List<Item>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list2);
			goto IL_00af;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CDC")]
		[Cpp2IlInjected.Address(RVA = "0x139D360", Offset = "0x139BD60", VA = "0x18139D360")]
		private void OnHangoutChanged(Character hangoutCharacter)
		{
			//Discarded unreachable code: IL_0029
			if (hangoutCharacter != null)
			{
				ItemFilter itemFilter = itemFilter_;
				int iD = hangoutCharacter.Data.ID;
				bool flag = default(bool);
				if (flag)
				{
					HangoutStart();
					return;
				}
			}
			HangoutStop();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CDD")]
		[Cpp2IlInjected.Address(RVA = "0x139C6B0", Offset = "0x139B0B0", VA = "0x18139C6B0")]
		private void OnCurrentSceneChanged(Item previousScene, Item currentScene)
		{
			//Discarded unreachable code: IL_005f
			if (!hangoutIsStarted && !hangoutIsPaused)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = hangoutIsPaused;
			SceneItemData sceneItemData = default(SceneItemData);
			if (sceneItemData.sceneType_ != SceneType.DisneyWorld)
			{
				if (flag && !hangoutIsStarted)
				{
					HangoutStart();
				}
				return;
			}
			while ((object)typeof(ItemDatabase).TypeHandle != null)
			{
			}
			while ((IntPtr)(hangoutIsStarted ? 1 : 0) == (IntPtr)typeof(ItemDatabase).TypeHandle)
			{
			}
			HangoutStop();
			hangoutIsPaused = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CDE")]
		[Cpp2IlInjected.Address(RVA = "0x139C010", Offset = "0x139AA10", VA = "0x18139C010")]
		private unsafe void HangoutStart()
		{
			//Discarded unreachable code: IL_003f
			//IL_002a: Expected O, but got I
			if (!hangoutIsStarted)
			{
				ITransactionContext transactionContext = Context;
				hangoutIsStarted = true;
				ProfileEventDispatcher profileEventDispatcher = Dispatcher;
				hangoutStartedAt = (DateTime)__ldftn(ObjectiveProgress.OnFewMinutesHavePass);
				ProfileEventDispatcher.FewMinutesHavePass value = OnFewMinutesHavePass;
				profileEventDispatcher.OnFewMinutesHavePass += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CDF")]
		[Cpp2IlInjected.Address(RVA = "0x139BFC0", Offset = "0x139A9C0", VA = "0x18139BFC0")]
		private void HangoutPause()
		{
			if (!hangoutIsPaused && hangoutIsStarted)
			{
				HangoutStop();
				hangoutIsPaused = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE0")]
		[Cpp2IlInjected.Address(RVA = "0x139BFF0", Offset = "0x139A9F0", VA = "0x18139BFF0")]
		private void HangoutResume()
		{
			if (hangoutIsPaused && !hangoutIsStarted)
			{
				HangoutStart();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE1")]
		[Cpp2IlInjected.Address(RVA = "0x139C0D0", Offset = "0x139AAD0", VA = "0x18139C0D0")]
		private void HangoutStop()
		{
			//Discarded unreachable code: IL_0032
			if (hangoutIsStarted)
			{
				hangoutIsStarted = false;
				UpdateHangoutProgression();
				ProfileEventDispatcher profileEventDispatcher = Dispatcher;
				ProfileEventDispatcher.FewMinutesHavePass value = OnFewMinutesHavePass;
				profileEventDispatcher.OnFewMinutesHavePass -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE2")]
		[Cpp2IlInjected.Address(RVA = "0x139C9A0", Offset = "0x139B3A0", VA = "0x18139C9A0")]
		private void OnFewMinutesHavePass(ProfileTimerType timerType, int minutesPassed)
		{
			UpdateHangoutProgression();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE3")]
		[Cpp2IlInjected.Address(RVA = "0x139F820", Offset = "0x139E220", VA = "0x18139F820")]
		private void UpdateHangoutProgression()
		{
			//Discarded unreachable code: IL_002c
			ITransactionContext transactionContext = Context;
			int num = 0;
			TimeSpan timeSpan = default(TimeSpan);
			if ((long)timeSpan == 1 || (long)timeSpan != 1 || (long)timeSpan != 1)
			{
			}
			if ((long)(IntPtr)typeof(Math).TypeHandle > 0L)
			{
				DateTime dateTime = default(DateTime);
				hangoutStartedAt = dateTime;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE4")]
		[Cpp2IlInjected.Address(RVA = "0x139BB30", Offset = "0x139A530", VA = "0x18139BB30")]
		private void DigTile_OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions addObjectOptions)
		{
			//Discarded unreachable code: IL_0037
			if (operation == GridChangedOperation.Add && gridObject.ItemID != 0)
			{
				HangoutWithCharacter with_ = Data.DigTile.with_;
				Profile profile = Profile;
				if (with_.CurrentHangoutCharacterIsValid(profile))
				{
					UpdateCurrentProgression(1);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE6")]
		[Cpp2IlInjected.Address(RVA = "0x139B840", Offset = "0x139A240", VA = "0x18139B840")]
		private void CheckForCompletion([Optional] List<(Item item, ItemState state)> items, int incAmount = 0, int multiplier = 1)
		{
			//Discarded unreachable code: IL_002a
			if (items != null)
			{
				List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)itemFilter_.ApplyFilter((IEnumerable<>)items);
				if (list != null && ((List<>)(object)list)._size > 0)
				{
					int incAmount2 = incAmount * multiplier;
					UpdateCurrentProgression(incAmount2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE7")]
		[Cpp2IlInjected.Address(RVA = "0x139F780", Offset = "0x139E180", VA = "0x18139F780")]
		private void UpdateCurrentProgression(int incAmount)
		{
			int num = curAmount_;
			if (this.OnObjectiveCompleted == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE8")]
		[Cpp2IlInjected.Address(RVA = "0x139B610", Offset = "0x139A010", VA = "0x18139B610")]
		private bool AddItemCollected(Item item)
		{
			bool flag = default(bool);
			if (flag)
			{
				RepeatedField<int> repeatedField = itemIdsCollected_;
				bool flag2 = default(bool);
				if (!flag2)
				{
					RepeatedField<int> repeatedField2 = itemIdsCollected_;
					return true;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE9")]
		[Cpp2IlInjected.Address(RVA = "0x139FB10", Offset = "0x139E510", VA = "0x18139FB10")]
		static ObjectiveProgress()
		{
			_parser = (MessageParser<ObjectiveProgress>)(object)FieldCodec.ForInt32(34u);
			/*Error: Unexpected end of block*/;
		}
	}
}
