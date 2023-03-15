using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DF8")]
	public sealed class ActionFixTargetAmount : IMessage<ActionFixTargetAmount>, IMessage, IEquatable<ActionFixTargetAmount>, IDeepCloneable<ActionFixTargetAmount>, IMessageFieldAccessor, IAction, IMissionItem, IMissionStepName, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40038A3")]
		private static readonly MessageParser<ActionFixTargetAmount> _parser = (MessageParser<ActionFixTargetAmount>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ActionFixTargetAmount()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40038A4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40038A5")]
		public const int MissionIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038A6")]
		private int missionID_;

		[Cpp2IlInjected.Token(Token = "0x40038A7")]
		public const int StepNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40038A8")]
		private string stepName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40038A9")]
		public const int AmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40038AA")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x40038AB")]
		public const int PrevAmountFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40038AC")]
		private int prevAmount_;

		[Cpp2IlInjected.Token(Token = "0x40038AD")]
		public const int TargetedItemIDFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40038AE")]
		private int targetedItemID_;

		[Cpp2IlInjected.Token(Token = "0x17001445")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionFixTargetAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60074F0")]
			[Cpp2IlInjected.Address(RVA = "0x1E303D0", Offset = "0x1E2EDD0", VA = "0x181E303D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001446")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60074F1")]
			[Cpp2IlInjected.Address(RVA = "0x1E301E0", Offset = "0x1E2EBE0", VA = "0x181E301E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001447")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60074F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E30490", Offset = "0x1E2EE90", VA = "0x181E30490", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001448")]
		[DebuggerNonUserCode]
		public int MissionID
		{
			[Cpp2IlInjected.Token(Token = "0x60074F6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return missionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074F7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				missionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001449")]
		[DebuggerNonUserCode]
		public string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x60074F8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
			get
			{
				return stepName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074F9")]
			[Cpp2IlInjected.Address(RVA = "0x1E305A0", Offset = "0x1E2EFA0", VA = "0x181E305A0", Slot = "18")]
			set
			{
				string text = (stepName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144A")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x60074FA")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074FB")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144B")]
		[DebuggerNonUserCode]
		public int PrevAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60074FC")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return prevAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074FD")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				prevAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144C")]
		[DebuggerNonUserCode]
		public int TargetedItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60074FE")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return targetedItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074FF")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				targetedItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144D")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600750B")]
			[Cpp2IlInjected.Address(RVA = "0x1E30370", Offset = "0x1E2ED70", VA = "0x181E30370", Slot = "16")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144E")]
		public Item TargetedItem
		{
			[Cpp2IlInjected.Token(Token = "0x600750C")]
			[Cpp2IlInjected.Address(RVA = "0x1E30430", Offset = "0x1E2EE30", VA = "0x181E30430")]
			get
			{
				long num = Convert.ToInt64((uint)targetedItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700144F")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600750E")]
			[Cpp2IlInjected.Address(RVA = "0x1E302B0", Offset = "0x1E2ECB0", VA = "0x181E302B0", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				int num2 = amount_;
				string text = default(string);
				return $"ActionFixTargetAmount for {text} at {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074F3")]
		[Cpp2IlInjected.Address(RVA = "0x1E300E0", Offset = "0x1E2EAE0", VA = "0x181E300E0")]
		[DebuggerNonUserCode]
		public ActionFixTargetAmount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60074F4")]
		[Cpp2IlInjected.Address(RVA = "0x1E30130", Offset = "0x1E2EB30", VA = "0x181E30130")]
		[DebuggerNonUserCode]
		public ActionFixTargetAmount(ActionFixTargetAmount other)
		{
			int num = (missionID_ = other.missionID_);
			string text = (stepName_ = other.stepName_);
			int num2 = (amount_ = other.amount_);
			int num3 = (prevAmount_ = other.prevAmount_);
			int num4 = (targetedItemID_ = other.targetedItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60074F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EEA0", Offset = "0x1E2D8A0", VA = "0x181E2EEA0", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionFixTargetAmount Clone()
		{
			//Discarded unreachable code: IL_0072
			ActionFixTargetAmount actionFixTargetAmount = new ActionFixTargetAmount();
			actionFixTargetAmount.stepName_ = "";
			int num = (actionFixTargetAmount.missionID_ = missionID_);
			string text = (actionFixTargetAmount.stepName_ = stepName_);
			int num2 = (actionFixTargetAmount.amount_ = amount_);
			int num3 = (actionFixTargetAmount.prevAmount_ = prevAmount_);
			int num4 = (actionFixTargetAmount.targetedItemID_ = targetedItemID_);
			UnknownFieldSet unknownFieldSet = (actionFixTargetAmount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionFixTargetAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6007500")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F430", Offset = "0x1E2DE30", VA = "0x181E2F430", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)missionID_ == (IntPtr)typeof(ActionFixTargetAmount).TypeHandle)
				{
					string text = stepName_;
					bool flag = default(bool);
					if (!flag && amount_ == (flag ? 1 : 0) && prevAmount_ == (flag ? 1 : 0) && targetedItemID_ == (flag ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007501")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F500", Offset = "0x1E2DF00", VA = "0x181E2F500", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionFixTargetAmount other)
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
					string text = other.stepName_;
					if (!(stepName_ != text))
					{
						int num2 = other.amount_;
						if (amount_ == num2)
						{
							int num3 = other.prevAmount_;
							if (prevAmount_ == num3)
							{
								int num4 = other.targetedItemID_;
								if (targetedItemID_ == num4)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007502")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F680", Offset = "0x1E2E080", VA = "0x181E2F680", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0050
			if (missionID_ != 0)
			{
			}
			string text = stepName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (amount_ != 0)
			{
			}
			if (prevAmount_ != 0)
			{
			}
			if (targetedItemID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6007503")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FE30", Offset = "0x1E2E830", VA = "0x181E2FE30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007504")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FEC0", Offset = "0x1E2E8C0", VA = "0x181E2FEC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0090
			if (missionID_ != 0)
			{
				int value = missionID_;
				output.WriteInt32(value);
			}
			if (stepName_.m_stringLength != 0)
			{
				string value2 = stepName_;
				output.WriteString(value2);
			}
			if (amount_ != 0)
			{
				int value3 = amount_;
				output.WriteInt32(value3);
			}
			if (prevAmount_ != 0)
			{
				int value4 = prevAmount_;
				output.WriteInt32(value4);
			}
			if (targetedItemID_ != 0)
			{
				int value5 = targetedItemID_;
				output.WriteInt32(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007505")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EC90", Offset = "0x1E2D690", VA = "0x181E2EC90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00b7
			int num = missionID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = stepName_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			int num5 = amount_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num2 += num6;
			}
			int num7 = prevAmount_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num2 += num8;
			}
			int num9 = targetedItemID_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num11 = unknownFields.CalculateSize();
				num2 += num11;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6007506")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F850", Offset = "0x1E2E250", VA = "0x181E2F850", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionFixTargetAmount other)
		{
			//Discarded unreachable code: IL_0089
			if (other != null)
			{
				int num = other.missionID_;
				if (num != 0)
				{
					missionID_ = num;
				}
				string text = other.stepName_;
				if (text.m_stringLength != 0)
				{
					StepName = text;
				}
				int num2 = other.amount_;
				if (num2 != 0)
				{
					amount_ = num2;
				}
				int num3 = other.prevAmount_;
				if (num3 != 0)
				{
					prevAmount_ = num3;
				}
				int num4 = other.targetedItemID_;
				if (num4 != 0)
				{
					targetedItemID_ = num4;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007507")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F760", Offset = "0x1E2E160", VA = "0x181E2F760", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					int num2 = (amount_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (prevAmount_ = input.ReadInt32());
				}
				if (num3 != 40)
				{
					goto IL_007b;
				}
				int num4 = (targetedItemID_ = input.ReadInt32());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (missionID_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text2 = (StepName = input.ReadString());
			}
			goto IL_007b;
			IL_007b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6007508")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F590", Offset = "0x1E2DF90", VA = "0x181E2F590", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0 && num != 0 && num != 1)
				{
					goto IL_0026;
				}
				string text = stepName_;
			}
			int num2 = missionID_;
			goto IL_0026;
			IL_0026:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007509")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FC70", Offset = "0x1E2E670", VA = "0x181E2FC70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0042
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							targetedItemID_ = (int)obj2;
							break;
						}
						case 0:
						{
							object obj = default(object);
							prevAmount_ = (int)obj;
							break;
						}
						}
					}
					else
					{
						object obj3 = default(object);
						amount_ = (int)obj3;
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj4 = default(object);
				missionID_ = (int)obj4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600750A")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EDF0", Offset = "0x1E2D7F0", VA = "0x181E2EDF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			//IL_004b: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
							targetedItemID_ = 0;
							break;
						case 0:
							prevAmount_ = 0;
							break;
						}
					}
					else
					{
						amount_ = 0;
					}
				}
				else
				{
					StepName = "";
				}
			}
			else
			{
				missionID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600750D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EB80", Offset = "0x1E2D580", VA = "0x181E2EB80", Slot = "14")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			int num = missionID_;
			Func<MissionObjective, string> func = (Func<MissionObjective, string>)(object)new Func<T, TResult>(ObjectiveValidation);
		}

		[Cpp2IlInjected.Token(Token = "0x600750F")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F420", Offset = "0x1E2DE20", VA = "0x181E2F420", Slot = "19")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0019: Expected I4, but got I8
			amount_ = 1;
			prevAmount_ = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6007510")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F8E0", Offset = "0x1E2E2E0", VA = "0x181E2F8E0")]
		private string ObjectiveValidation(MissionObjective obj)
		{
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			int num = prevAmount_;
			if (num > 0)
			{
				int targetAmountInt = obj.TargetAmountInt;
				if (num != targetAmountInt)
				{
					int targetAmountInt2 = obj.TargetAmountInt;
					int num2 = prevAmount_;
					return $"Previous value was {targetAmountInt2} instead of {targetAmountInt2}";
				}
			}
			int num3 = targetedItemID_;
			bool flag = default(bool);
			if (flag)
			{
				IEnumerable<Item> enumerable = (IEnumerable<Item>)obj.itemFilter_.SelectedItems();
				long num4 = Convert.ToInt64((uint)targetedItemID_);
				bool flag2 = default(bool);
				if (!flag2)
				{
					Item targetedItem = TargetedItem;
					IEnumerable<Item> enumerable2 = (IEnumerable<Item>)obj.itemFilter_.SelectedItems();
					Func<Item, string> func = default(Func<Item, string>);
					if (_003C_003Ec._003C_003E9__56_0 == null)
					{
						string result = default(string);
						func = (Func<Item, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => result));
					}
					IEnumerable<Item> enumerable3 = (IEnumerable<Item>)Enumerable.Select<Item, string>((IEnumerable<>)enumerable2, (Func<, >)(object)func);
					string arg = string.Join(", ", (IEnumerable<>)enumerable3);
					return $"Objective don't target {targetedItem}.. Targets:{arg}";
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007511")]
		[Cpp2IlInjected.Address(RVA = "0x1E2EF80", Offset = "0x1E2D980", VA = "0x181E2EF80", Slot = "20")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0115
			//IL_00a4: Expected O, but got I4
			bool flag = default(bool);
			IEnumerable<MissionObjectiveData> enumerable = default(IEnumerable<MissionObjectiveData>);
			uint num3 = default(uint);
			bool flag2 = default(bool);
			string text4 = default(string);
			do
			{
				int num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num2 = missionID_;
				if (!flag)
				{
					continue;
				}
				Func<MissionObjectiveData, bool> func = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
				{
					//Discarded unreachable code: IL_0014
					string b = stepName_;
					return string.Equals(x.stepName_, b);
				};
				MissionObjectiveData missionObjectiveData = Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
				if (missionObjectiveData != null)
				{
					IStepAmount getIStepAmount = missionObjectiveData.GetIStepAmount;
					if (getIStepAmount != null)
					{
						if (num < (int)num3)
						{
							num += num;
							num++;
						}
						if (getIStepAmount != null)
						{
							int num4 = amount_;
							flag2 = (byte)((flag2 ? 1u : 0u) + (flag2 ? 1u : 0u)) != 0;
							num += 312;
						}
						bool flag3 = num == 1;
						if (num != (flag3 ? 1 : 0))
						{
							MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
							if (num <= 50)
							{
							}
							if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.MakeGarden || customStepCase_ == MissionObjectiveData.CustomStepOneofCase.Possess)
							{
								continue;
							}
							string text = $"{num} is not supported (yet?). Ask jfroux is really needed";
						}
					}
					string text2 = stepName_;
					string text3 = "Must be same has amount in " + text2;
				}
				int num5 = missionID_;
				string message = "Cannot found this step in " + text4;
				context.AddInvalidMemberError(message, "StepName");
			}
			while (prevAmount_ != 0);
			context.AddInvalidMemberError("Cannot be 0 (use -1 for any value)", "PrevAmount");
			if (prevAmount_ == amount_)
			{
				context.AddError("PrevAmount and Amount must be different");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007512")]
		[Cpp2IlInjected.Address(RVA = "0x1E2FFD0", Offset = "0x1E2E9D0", VA = "0x181E2FFD0")]
		static ActionFixTargetAmount()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
