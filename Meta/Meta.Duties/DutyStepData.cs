using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010D3")]
	public sealed class DutyStepData : IMessage<DutyStepData>, IMessage, IEquatable<DutyStepData>, IDeepCloneable<DutyStepData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004541")]
		private static readonly MessageParser<DutyStepData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004542")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004543")]
		public const int ItemFilterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004544")]
		private ItemFilter itemFilter_;

		[Cpp2IlInjected.Token(Token = "0x4004545")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004546")]
		private int targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x4004547")]
		public const int CurAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4004548")]
		private int curAmount_;

		[Cpp2IlInjected.Token(Token = "0x170017A0")]
		[DebuggerNonUserCode]
		public static MessageParser<DutyStepData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600885E")]
			[Cpp2IlInjected.Address(RVA = "0x174A410", Offset = "0x1748E10", VA = "0x18174A410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600885F")]
			[Cpp2IlInjected.Address(RVA = "0x174A340", Offset = "0x1748D40", VA = "0x18174A340")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008860")]
			[Cpp2IlInjected.Address(RVA = "0x174A470", Offset = "0x1748E70", VA = "0x18174A470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A3")]
		[DebuggerNonUserCode]
		public ItemFilter ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6008864")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008865")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				itemFilter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A4")]
		[DebuggerNonUserCode]
		public int TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008866")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008867")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				targetAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017A5")]
		[DebuggerNonUserCode]
		public int CurAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008868")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return curAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008869")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				curAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008861")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DutyStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008862")]
		[Cpp2IlInjected.Address(RVA = "0x174A2C0", Offset = "0x1748CC0", VA = "0x18174A2C0")]
		[DebuggerNonUserCode]
		public DutyStepData(DutyStepData other)
		{
			//IL_0021: Expected O, but got I4
			ItemFilter itemFilter = other.itemFilter_;
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = itemFilter.Clone();
			}
			int num = 0;
			itemFilter_ = (ItemFilter)num;
			int num2 = (targetAmount_ = other.targetAmount_);
			int num3 = (curAmount_ = other.curAmount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008863")]
		[Cpp2IlInjected.Address(RVA = "0x1749A30", Offset = "0x1748430", VA = "0x181749A30", Slot = "10")]
		[DebuggerNonUserCode]
		public DutyStepData Clone()
		{
			//Discarded unreachable code: IL_0058
			//IL_0021: Expected O, but got I4
			DutyStepData dutyStepData = new DutyStepData();
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = itemFilter.Clone();
			}
			int num = 0;
			dutyStepData.itemFilter_ = (ItemFilter)num;
			int num2 = (dutyStepData.targetAmount_ = targetAmount_);
			int num3 = (dutyStepData.curAmount_ = curAmount_);
			UnknownFieldSet unknownFieldSet = (dutyStepData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return dutyStepData;
		}

		[Cpp2IlInjected.Token(Token = "0x600886A")]
		[Cpp2IlInjected.Address(RVA = "0x1749B60", Offset = "0x1748560", VA = "0x181749B60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(itemFilter_, other);
				if (flag && targetAmount_ == (flag ? 1 : 0) && curAmount_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600886B")]
		[Cpp2IlInjected.Address(RVA = "0x1749AE0", Offset = "0x17484E0", VA = "0x181749AE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DutyStepData other)
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
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600886C")]
		[Cpp2IlInjected.Address(RVA = "0x1749CF0", Offset = "0x17486F0", VA = "0x181749CF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
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
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600886D")]
		[Cpp2IlInjected.Address(RVA = "0x174A0A0", Offset = "0x1748AA0", VA = "0x18174A0A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600886E")]
		[Cpp2IlInjected.Address(RVA = "0x174A100", Offset = "0x1748B00", VA = "0x18174A100", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005a
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
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600886F")]
		[Cpp2IlInjected.Address(RVA = "0x17498F0", Offset = "0x17482F0", VA = "0x1817498F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2 = default(int);
			UnknownFieldSet unknownFields;
			do
			{
				ItemFilter itemFilter = itemFilter_;
				int num = 0;
				if (itemFilter != null)
				{
					num2 = CodedOutputStream.ComputeMessageSize(itemFilter) + 1;
				}
				int num3 = targetAmount_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num2 += num4;
				}
				int num5 = curAmount_;
				if (num5 != 0)
				{
					int num6 = CodedOutputStream.ComputeInt32Size(num5);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008870")]
		[Cpp2IlInjected.Address(RVA = "0x1749EA0", Offset = "0x17488A0", VA = "0x181749EA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DutyStepData other)
		{
			//Discarded unreachable code: IL_007f
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
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6008871")]
		[Cpp2IlInjected.Address(RVA = "0x1749D90", Offset = "0x1748790", VA = "0x181749D90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0071
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemFilter itemFilter = itemFilter_;
				if (itemFilter == null)
				{
					ItemFilter itemFilter2 = (itemFilter_ = new ItemFilter());
				}
				input.ReadMessage(itemFilter);
			}
			int num2 = default(int);
			if (num == 16)
			{
				num2 = (targetAmount_ = input.ReadInt32());
			}
			if (num2 == 24)
			{
				int num3 = (curAmount_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008872")]
		[Cpp2IlInjected.Address(RVA = "0x1749C20", Offset = "0x1748620", VA = "0x181749C20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 1)
				{
					goto IL_001e;
				}
				int num2 = targetAmount_;
			}
			ItemFilter itemFilter = itemFilter_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008873")]
		[Cpp2IlInjected.Address(RVA = "0x1749F80", Offset = "0x1748980", VA = "0x181749F80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					curAmount_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					targetAmount_ = (int)obj;
					break;
				}
				}
				return;
			}
			if (value == null || value != null)
			{
				itemFilter_ = (ItemFilter)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008874")]
		[Cpp2IlInjected.Address(RVA = "0x17499F0", Offset = "0x17483F0", VA = "0x1817499F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				curAmount_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008875")]
		[Cpp2IlInjected.Address(RVA = "0x174A1B0", Offset = "0x1748BB0", VA = "0x18174A1B0")]
		static DutyStepData()
		{
			Func<DutyStepData> func = default(Func<DutyStepData>);
			_parser = (MessageParser<DutyStepData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
