using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000474")]
	public sealed class TargetBuilding : IMessage<TargetBuilding>, IMessage, IEquatable<TargetBuilding>, IDeepCloneable<TargetBuilding>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount
	{
		[Cpp2IlInjected.Token(Token = "0x2000475")]
		public enum TargetOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001806")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001807")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x4001808")]
			ItemID
		}

		[Cpp2IlInjected.Token(Token = "0x40017FF")]
		private static readonly MessageParser<TargetBuilding> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001800")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001801")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001802")]
		public const int ItemIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001803")]
		private object target_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001804")]
		private TargetOneofCase targetCase_;

		[Cpp2IlInjected.Token(Token = "0x17000DE9")]
		[DebuggerNonUserCode]
		public static MessageParser<TargetBuilding> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600369D")]
			[Cpp2IlInjected.Address(RVA = "0x256B720", Offset = "0x256A120", VA = "0x18256B720")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600369E")]
			[Cpp2IlInjected.Address(RVA = "0x256B530", Offset = "0x2569F30", VA = "0x18256B530")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600369F")]
			[Cpp2IlInjected.Address(RVA = "0x256B830", Offset = "0x256A230", VA = "0x18256B830", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEC")]
		[DebuggerNonUserCode]
		public TargetAnyWithAmount Any
		{
			[Cpp2IlInjected.Token(Token = "0x60036A4")]
			[Cpp2IlInjected.Address(RVA = "0x256B4D0", Offset = "0x2569ED0", VA = "0x18256B4D0")]
			get
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60036A5")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				target_ = value;
				bool flag = (byte)(targetCase_ = ((value != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DED")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60036A6")]
			[Cpp2IlInjected.Address(RVA = "0x256B600", Offset = "0x256A000", VA = "0x18256B600")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetCase_ == TargetOneofCase.ItemID)
				{
					object obj = target_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60036A7")]
			[Cpp2IlInjected.Address(RVA = "0x256B940", Offset = "0x256A340", VA = "0x18256B940")]
			set
			{
				//IL_0014: Expected I4, but got I8
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.ItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEE")]
		[DebuggerNonUserCode]
		public TargetOneofCase TargetCase
		{
			[Cpp2IlInjected.Token(Token = "0x60036A8")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return targetCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DEF")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60036B7")]
			[Cpp2IlInjected.Address(RVA = "0x256B670", Offset = "0x256A070", VA = "0x18256B670")]
			get
			{
				if (targetCase_ == TargetOneofCase.ItemID)
				{
					object obj = target_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF0")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60036B8")]
			[Cpp2IlInjected.Address(RVA = "0x256B780", Offset = "0x256A180", VA = "0x18256B780", Slot = "16")]
			get
			{
				if (targetCase_ != TargetOneofCase.Any)
				{
					return new StepAmount(1);
				}
				if (target_ != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036A0")]
		[Cpp2IlInjected.Address(RVA = "0x256B410", Offset = "0x2569E10", VA = "0x18256B410")]
		[DebuggerNonUserCode]
		public TargetBuilding()
		{
			//IL_0029: Expected I4, but got I8
			TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
			StepAmount stepAmount = (targetAnyWithAmount.targetAmount_ = new StepAmount());
			target_ = targetAnyWithAmount;
			targetCase_ = TargetOneofCase.Any;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A1")]
		[Cpp2IlInjected.Address(RVA = "0x256AF10", Offset = "0x2569910", VA = "0x18256AF10")]
		private void OnConstruction()
		{
			//IL_0023: Expected I4, but got I8
			TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
			StepAmount stepAmount = (targetAnyWithAmount.targetAmount_ = new StepAmount());
			target_ = targetAnyWithAmount;
			targetCase_ = TargetOneofCase.Any;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A2")]
		[Cpp2IlInjected.Address(RVA = "0x256B310", Offset = "0x2569D10", VA = "0x18256B310")]
		[DebuggerNonUserCode]
		public TargetBuilding(TargetBuilding other)
		{
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = other.targetCase_;
				if (other.target_ == null)
				{
					throw new InvalidCastException();
				}
				TargetAnyWithAmount targetAnyWithAmount = default(TargetAnyWithAmount);
				target_ = targetAnyWithAmount;
				bool flag = (byte)(targetCase_ = ((targetAnyWithAmount != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (targetOneofCase == TargetOneofCase.ItemID)
			{
				int num = (ItemID = other.ItemID);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036A3")]
		[Cpp2IlInjected.Address(RVA = "0x256A510", Offset = "0x2568F10", VA = "0x18256A510", Slot = "10")]
		[DebuggerNonUserCode]
		public TargetBuilding Clone()
		{
			//Discarded unreachable code: IL_0064
			TargetBuilding targetBuilding = new TargetBuilding();
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = targetCase_;
				if (target_ == null)
				{
					throw new InvalidCastException();
				}
				TargetAnyWithAmount targetAnyWithAmount = default(TargetAnyWithAmount);
				targetBuilding.target_ = targetAnyWithAmount;
				bool flag = (byte)(targetBuilding.targetCase_ = ((targetAnyWithAmount != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (targetOneofCase == TargetOneofCase.ItemID)
			{
				int num = (targetBuilding.ItemID = ItemID);
			}
			UnknownFieldSet unknownFieldSet = (targetBuilding._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return targetBuilding;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A9")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearTarget()
		{
			//IL_0010: Expected O, but got I4
			target_ = (targetCase_ = TargetOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036AA")]
		[Cpp2IlInjected.Address(RVA = "0x256A770", Offset = "0x2569170", VA = "0x18256A770", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0069: Expected O, but got I4
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (targetCase_ == TargetOneofCase.Any)
					{
						object obj = target_;
						if (obj != null && obj == null)
						{
							goto IL_006e;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(TargetAnyWithAmount).TypeHandle != null && (object)typeof(TargetAnyWithAmount).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						int itemID = ItemID;
						int num2 = 0;
						int num3 = default(int);
						if (itemID == num3 && targetCase_ == (TargetOneofCase)num3)
						{
							bool flag2 = object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num4 = 0;
			goto IL_006e;
			IL_006e:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036AB")]
		[Cpp2IlInjected.Address(RVA = "0x256A650", Offset = "0x2569050", VA = "0x18256A650", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TargetBuilding other)
		{
			//IL_004d: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						goto IL_0090;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.targetCase_ == TargetOneofCase.Any)
				{
					obj2 = other.target_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int itemID = ItemID;
					int itemID2 = other.ItemID;
					if (itemID == itemID2)
					{
						TargetOneofCase targetOneofCase = other.targetCase_;
						if (targetCase_ == targetOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0090;
			IL_0090:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036AC")]
		[Cpp2IlInjected.Address(RVA = "0x256A9E0", Offset = "0x25693E0", VA = "0x18256A9E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004c
			TargetOneofCase targetOneofCase = targetCase_;
			int num = 0;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				object obj = target_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (targetOneofCase == TargetOneofCase.ItemID && targetCase_ == TargetOneofCase.ItemID)
			{
				object obj2 = target_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60036AD")]
		[Cpp2IlInjected.Address(RVA = "0x256B0C0", Offset = "0x2569AC0", VA = "0x18256B0C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60036AE")]
		[Cpp2IlInjected.Address(RVA = "0x256B120", Offset = "0x2569B20", VA = "0x18256B120", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0054
			//IL_002c: Expected O, but got I4
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (targetOneofCase == TargetOneofCase.ItemID)
			{
				int itemID = ItemID;
				output.WriteInt32(itemID);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60036AF")]
		[Cpp2IlInjected.Address(RVA = "0x256A2B0", Offset = "0x2568CB0", VA = "0x18256A2B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0069
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (targetCase_ == TargetOneofCase.Any)
			{
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (targetCase_ == TargetOneofCase.ItemID)
			{
				if (targetCase_ == TargetOneofCase.ItemID)
				{
					object obj2 = target_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B0")]
		[Cpp2IlInjected.Address(RVA = "0x256AD30", Offset = "0x2569730", VA = "0x18256AD30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TargetBuilding other)
		{
			if (other == null)
			{
				return;
			}
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = targetCase_;
				int num = 0;
				if (targetOneofCase2 == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(targetCase_ = (((target_ = new TargetAnyWithAmount()) != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
				}
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj2 = target_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.targetCase_ == TargetOneofCase.Any)
				{
					object obj3 = other.target_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if (targetOneofCase == TargetOneofCase.ItemID)
			{
				int num2 = (ItemID = other.ItemID);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60036B1")]
		[Cpp2IlInjected.Address(RVA = "0x256ABC0", Offset = "0x25695C0", VA = "0x18256ABC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				TargetAnyWithAmount targetAnyWithAmount = new TargetAnyWithAmount();
				if (targetCase_ == TargetOneofCase.Any)
				{
					if (targetCase_ != TargetOneofCase.Any)
					{
					}
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(targetAnyWithAmount);
				target_ = targetAnyWithAmount;
				bool flag = (byte)(targetCase_ = ((targetAnyWithAmount != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (num == 16)
			{
				int num3 = (ItemID = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60036B2")]
		[Cpp2IlInjected.Address(RVA = "0x256A8D0", Offset = "0x25692D0", VA = "0x18256A8D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (targetCase_ == TargetOneofCase.Any)
			{
				object obj = target_;
				if (obj != null)
				{
					if (obj != null)
					{
						goto IL_001c;
					}
					goto IL_0037;
				}
			}
			goto IL_0027;
			IL_001c:
			if (fieldNumber == 2)
			{
				int itemID = ItemID;
			}
			goto IL_0027;
			IL_0037:
			throw new InvalidCastException();
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B3")]
		[Cpp2IlInjected.Address(RVA = "0x256AFD0", Offset = "0x25699D0", VA = "0x18256AFD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002a
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				target_ = num;
				bool flag = (byte)(targetCase_ = ((num != 0) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036B4")]
		[Cpp2IlInjected.Address(RVA = "0x256A410", Offset = "0x2568E10", VA = "0x18256A410", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_0019: Expected O, but got I4
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				targetCase_ = TargetOneofCase.None;
				break;
			case 2:
			{
				int num = default(int);
				target_ = num;
				targetCase_ = TargetOneofCase.ItemID;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036B5")]
		[Cpp2IlInjected.Address(RVA = "0x256AB10", Offset = "0x2569510", VA = "0x18256AB10", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				TargetOneofCase targetOneofCase = targetCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B6")]
		[Cpp2IlInjected.Address(RVA = "0x256A4A0", Offset = "0x2568EA0", VA = "0x18256A4A0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				target_ = (targetCase_ = TargetOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036B9")]
		[Cpp2IlInjected.Address(RVA = "0x256B200", Offset = "0x2569C00", VA = "0x18256B200")]
		static TargetBuilding()
		{
			Func<TargetBuilding> func = default(Func<TargetBuilding>);
			_parser = (MessageParser<TargetBuilding>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
