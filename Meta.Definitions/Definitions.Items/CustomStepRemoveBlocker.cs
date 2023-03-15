using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200048A")]
	public sealed class CustomStepRemoveBlocker : IMessage<CustomStepRemoveBlocker>, IMessage, IEquatable<CustomStepRemoveBlocker>, IDeepCloneable<CustomStepRemoveBlocker>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400185F")]
		private static readonly MessageParser<CustomStepRemoveBlocker> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001860")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001861")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001862")]
		private ItemSelector item_;

		[Cpp2IlInjected.Token(Token = "0x4001863")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001864")]
		private StepAmount amount_;

		[Cpp2IlInjected.Token(Token = "0x4001865")]
		public const int FilterFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001866")]
		private GridLocationFilter filter_;

		[Cpp2IlInjected.Token(Token = "0x4001867")]
		public const int DisableAutoSkipFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001868")]
		private bool disableAutoSkip_;

		[Cpp2IlInjected.Token(Token = "0x17000E2F")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepRemoveBlocker> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60037A7")]
			[Cpp2IlInjected.Address(RVA = "0x31FCC80", Offset = "0x31FB680", VA = "0x1831FCC80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E30")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037A8")]
			[Cpp2IlInjected.Address(RVA = "0x31FCBB0", Offset = "0x31FB5B0", VA = "0x1831FCBB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E31")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037A9")]
			[Cpp2IlInjected.Address(RVA = "0x31FCE80", Offset = "0x31FB880", VA = "0x1831FCE80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E32")]
		[DebuggerNonUserCode]
		public ItemSelector Item
		{
			[Cpp2IlInjected.Token(Token = "0x60037AE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x60037AF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E33")]
		[DebuggerNonUserCode]
		public StepAmount Amount
		{
			[Cpp2IlInjected.Token(Token = "0x60037B0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60037B1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E34")]
		[DebuggerNonUserCode]
		public GridLocationFilter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x60037B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return filter_;
			}
			[Cpp2IlInjected.Token(Token = "0x60037B3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				filter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E35")]
		[DebuggerNonUserCode]
		public bool DisableAutoSkip
		{
			[Cpp2IlInjected.Token(Token = "0x60037B4")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return disableAutoSkip_;
			}
			[Cpp2IlInjected.Token(Token = "0x60037B5")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				disableAutoSkip_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E36")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60037C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return item_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E37")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60037C2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return amount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E38")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60037C3")]
			[Cpp2IlInjected.Address(RVA = "0x31FCCE0", Offset = "0x31FB6E0", VA = "0x1831FCCE0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[1] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[2] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037AA")]
		[Cpp2IlInjected.Address(RVA = "0x31FCA90", Offset = "0x31FB490", VA = "0x1831FCA90")]
		[DebuggerNonUserCode]
		public CustomStepRemoveBlocker()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.AnywhereInTheVillage = new Empty());
			filter_ = gridLocationFilter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037AB")]
		[Cpp2IlInjected.Address(RVA = "0x31FC3D0", Offset = "0x31FADD0", VA = "0x1831FC3D0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.AnywhereInTheVillage = new Empty());
			filter_ = gridLocationFilter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037AC")]
		[Cpp2IlInjected.Address(RVA = "0x31FC8C0", Offset = "0x31FB2C0", VA = "0x1831FC8C0")]
		[DebuggerNonUserCode]
		public CustomStepRemoveBlocker(CustomStepRemoveBlocker other)
		{
			//IL_005b: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (amount_ = new StepAmount());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.AnywhereInTheVillage = new Empty());
			filter_ = gridLocationFilter;
			ItemSelector itemSelector2 = other.item_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			item_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.amount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			amount_ = (StepAmount)num;
			GridLocationFilter gridLocationFilter2 = other.filter_;
			GridLocationFilter gridLocationFilter3 = default(GridLocationFilter);
			if (gridLocationFilter2 != null)
			{
				gridLocationFilter3 = gridLocationFilter2.Clone();
			}
			filter_ = gridLocationFilter3;
			bool flag = (disableAutoSkip_ = other.disableAutoSkip_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037AD")]
		[Cpp2IlInjected.Address(RVA = "0x31FBC60", Offset = "0x31FA660", VA = "0x1831FBC60", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepRemoveBlocker Clone()
		{
			return new CustomStepRemoveBlocker(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60037B6")]
		[Cpp2IlInjected.Address(RVA = "0x31FBD60", Offset = "0x31FA760", VA = "0x1831FBD60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(item_, other) && object.Equals(amount_, other))
				{
					bool flag = object.Equals(filter_, other);
					if (flag && disableAutoSkip_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037B7")]
		[Cpp2IlInjected.Address(RVA = "0x31FBE40", Offset = "0x31FA840", VA = "0x1831FBE40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepRemoveBlocker other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.item_;
				if (object.Equals(item_, objB))
				{
					StepAmount objB2 = other.amount_;
					if (object.Equals(amount_, objB2))
					{
						GridLocationFilter objB3 = other.filter_;
						if (object.Equals(filter_, objB3))
						{
							bool flag = other.disableAutoSkip_;
							if (disableAutoSkip_ == flag)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037B8")]
		[Cpp2IlInjected.Address(RVA = "0x31FBFD0", Offset = "0x31FA9D0", VA = "0x1831FBFD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = item_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = amount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				GridLocationFilter gridLocationFilter = filter_;
				if (gridLocationFilter != null)
				{
					int hashCode3 = gridLocationFilter.GetHashCode();
				}
				if (disableAutoSkip_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60037B9")]
		[Cpp2IlInjected.Address(RVA = "0x31FC670", Offset = "0x31FB070", VA = "0x1831FC670", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60037BA")]
		[Cpp2IlInjected.Address(RVA = "0x31FC6D0", Offset = "0x31FB0D0", VA = "0x1831FC6D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0078
			if ((long)item_ != 0)
			{
				ItemSelector value = item_;
				output.WriteMessage(value);
			}
			if ((long)amount_ != 0)
			{
				StepAmount value2 = amount_;
				output.WriteMessage(value2);
			}
			if ((long)filter_ != 0)
			{
				GridLocationFilter value3 = filter_;
				output.WriteMessage(value3);
			}
			if (disableAutoSkip_)
			{
				bool value4 = disableAutoSkip_;
				output.WriteBool(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60037BB")]
		[Cpp2IlInjected.Address(RVA = "0x31FBB00", Offset = "0x31FA500", VA = "0x1831FBB00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = item_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				StepAmount stepAmount = amount_;
				if (stepAmount != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num3++;
					num += num3;
				}
				GridLocationFilter gridLocationFilter = filter_;
				if (gridLocationFilter != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(gridLocationFilter);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60037BC")]
		[Cpp2IlInjected.Address(RVA = "0x31FC090", Offset = "0x31FAA90", VA = "0x1831FC090", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepRemoveBlocker other)
		{
			//Discarded unreachable code: IL_00ec
			if (other == null)
			{
				return;
			}
			if ((long)other.item_ != 0)
			{
				ItemSelector itemSelector = item_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (item_ = new ItemSelector());
					ItemSelector itemSelector3 = item_;
				}
				ItemSelector other2 = other.item_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.amount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amount_ == null)
				{
					StepAmount stepAmount = (amount_ = new StepAmount());
					stepAmount2 = amount_;
				}
				StepAmount other3 = other.amount_;
				stepAmount2.MergeFrom(other3);
			}
			if ((long)other.filter_ != 0)
			{
				GridLocationFilter gridLocationFilter2 = default(GridLocationFilter);
				if (filter_ == null)
				{
					GridLocationFilter gridLocationFilter = (filter_ = new GridLocationFilter());
					gridLocationFilter2 = filter_;
				}
				GridLocationFilter other4 = other.filter_;
				gridLocationFilter2.MergeFrom(other4);
			}
			bool flag = other.disableAutoSkip_;
			if (flag)
			{
				disableAutoSkip_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60037BD")]
		[Cpp2IlInjected.Address(RVA = "0x31FC220", Offset = "0x31FAC20", VA = "0x1831FC220", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c3
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					GridLocationFilter gridLocationFilter = filter_;
					if (gridLocationFilter == null)
					{
						GridLocationFilter gridLocationFilter2 = (filter_ = new GridLocationFilter());
					}
					input.ReadMessage(gridLocationFilter);
				}
				if (num != 32)
				{
					goto IL_00ac;
				}
				bool flag = (disableAutoSkip_ = input.ReadBool());
			}
			ItemSelector itemSelector = default(ItemSelector);
			if (num == 10)
			{
				ItemSelector builder = default(ItemSelector);
				if (item_ == null)
				{
					itemSelector = (item_ = new ItemSelector());
					builder = item_;
				}
				input.ReadMessage(builder);
			}
			if ((long)itemSelector == 18)
			{
				StepAmount builder2 = default(StepAmount);
				if (amount_ == null)
				{
					StepAmount stepAmount = (amount_ = new StepAmount());
					builder2 = amount_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00ac;
			IL_00ac:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60037BE")]
		[Cpp2IlInjected.Address(RVA = "0x31FBEE0", Offset = "0x31FA8E0", VA = "0x1831FBEE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						bool flag = disableAutoSkip_;
					}
					GridLocationFilter gridLocationFilter = filter_;
				}
				StepAmount stepAmount = amount_;
			}
			ItemSelector itemSelector = item_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037BF")]
		[Cpp2IlInjected.Address(RVA = "0x31FC510", Offset = "0x31FAF10", VA = "0x1831FC510", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			//IL_002d: Expected O, but got I4
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
						disableAutoSkip_ = (byte)(int)obj != 0;
						break;
					}
					case 0:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							filter_ = (GridLocationFilter)num2;
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
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037C0")]
		[Cpp2IlInjected.Address(RVA = "0x31FBC10", Offset = "0x31FA610", VA = "0x1831FBC10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				disableAutoSkip_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037C4")]
		[Cpp2IlInjected.Address(RVA = "0x31FC4E0", Offset = "0x31FAEE0", VA = "0x1831FC4E0", Slot = "17")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			amount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60037C5")]
		[Cpp2IlInjected.Address(RVA = "0x31FBCC0", Offset = "0x31FA6C0", VA = "0x1831FBCC0", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_002f
			if (amount_.IsValueSmallerThen(1))
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 1+ in " + missionStepName;
				context.AddInvalidMemberError(message, "Amount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037C6")]
		[Cpp2IlInjected.Address(RVA = "0x31FC7B0", Offset = "0x31FB1B0", VA = "0x1831FC7B0")]
		static CustomStepRemoveBlocker()
		{
			Func<CustomStepRemoveBlocker> func = default(Func<CustomStepRemoveBlocker>);
			_parser = (MessageParser<CustomStepRemoveBlocker>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
