using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004CD")]
	public sealed class CustomStepExpandHouse : IMessage<CustomStepExpandHouse>, IMessage, IEquatable<CustomStepExpandHouse>, IDeepCloneable<CustomStepExpandHouse>, IMessageFieldAccessor, IStepAmount, IBuildingMapMarker, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004CE")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004CF")]
			public enum ExpandType
			{
				[Cpp2IlInjected.Token(Token = "0x40019AF")]
				[OriginalName("ExpandType_Any")]
				Any,
				[Cpp2IlInjected.Token(Token = "0x40019B0")]
				[OriginalName("ExpandType_ExpandMainRoom")]
				ExpandMainRoom,
				[Cpp2IlInjected.Token(Token = "0x40019B1")]
				[OriginalName("ExpandType_AddRoom")]
				AddRoom,
				[Cpp2IlInjected.Token(Token = "0x40019B2")]
				[OriginalName("ExpandType_AddFloor")]
				AddFloor,
				[Cpp2IlInjected.Token(Token = "0x40019B3")]
				[OriginalName("ExpandType_ReachNumberOfRoom")]
				ReachNumberOfRoom,
				[Cpp2IlInjected.Token(Token = "0x40019B4")]
				[OriginalName("ExpandType_ReachNumberOfFloor")]
				ReachNumberOfFloor
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40019A8")]
		private static readonly MessageParser<CustomStepExpandHouse> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019A9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019AA")]
		public const int ActionTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019AB")]
		private Types.ExpandType actionType_;

		[Cpp2IlInjected.Token(Token = "0x40019AC")]
		public const int AmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40019AD")]
		private int amount_;

		[Cpp2IlInjected.Token(Token = "0x17000F24")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepExpandHouse> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003B28")]
			[Cpp2IlInjected.Address(RVA = "0x34E18D0", Offset = "0x34E02D0", VA = "0x1834E18D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F25")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B29")]
			[Cpp2IlInjected.Address(RVA = "0x34E17B0", Offset = "0x34E01B0", VA = "0x1834E17B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F26")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B2A")]
			[Cpp2IlInjected.Address(RVA = "0x34E1AB0", Offset = "0x34E04B0", VA = "0x1834E1AB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F27")]
		[DebuggerNonUserCode]
		public Types.ExpandType ActionType
		{
			[Cpp2IlInjected.Token(Token = "0x6003B2E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return actionType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B2F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				actionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F28")]
		[DebuggerNonUserCode]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B30")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B31")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F29")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B3D")]
			[Cpp2IlInjected.Address(RVA = "0x34E1930", Offset = "0x34E0330", VA = "0x1834E1930", Slot = "14")]
			get
			{
				return new StepAmount(amount_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2A")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003B3F")]
			[Cpp2IlInjected.Address(RVA = "0x34E1990", Offset = "0x34E0390", VA = "0x1834E1990", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0041
				string[] array;
				while (true)
				{
					array = new string[2];
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[0] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[1] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2B")]
		public ExpandHouseEventType EventToListen
		{
			[Cpp2IlInjected.Token(Token = "0x6003B40")]
			[Cpp2IlInjected.Address(RVA = "0x34E1880", Offset = "0x34E0280", VA = "0x1834E1880")]
			get
			{
				if (actionType_ <= Types.ExpandType.ReachNumberOfFloor)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B2B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CustomStepExpandHouse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003B2C")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public CustomStepExpandHouse(CustomStepExpandHouse other)
		{
			Types.ExpandType expandType = (actionType_ = other.actionType_);
			int num = (amount_ = other.amount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B2D")]
		[Cpp2IlInjected.Address(RVA = "0x34E11E0", Offset = "0x34DFBE0", VA = "0x1834E11E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepExpandHouse Clone()
		{
			//Discarded unreachable code: IL_0037
			CustomStepExpandHouse customStepExpandHouse = new CustomStepExpandHouse();
			Types.ExpandType expandType = (customStepExpandHouse.actionType_ = actionType_);
			int num = (customStepExpandHouse.amount_ = amount_);
			UnknownFieldSet unknownFieldSet = (customStepExpandHouse._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepExpandHouse;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B32")]
		[Cpp2IlInjected.Address(RVA = "0x34E13F0", Offset = "0x34DFDF0", VA = "0x1834E13F0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)actionType_ == (IntPtr)typeof(CustomStepExpandHouse).TypeHandle && (IntPtr)amount_ == (IntPtr)typeof(CustomStepExpandHouse).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B33")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepExpandHouse other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.ExpandType expandType = other.actionType_;
				if (actionType_ == expandType)
				{
					int num = other.amount_;
					if (amount_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B34")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (actionType_ != 0)
				{
				}
				if (amount_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B35")]
		[Cpp2IlInjected.Address(RVA = "0x34E1640", Offset = "0x34E0040", VA = "0x1834E1640", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B36")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (actionType_ != 0)
			{
			}
			if (amount_ != 0)
			{
				int value = amount_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B37")]
		[Cpp2IlInjected.Address(RVA = "0x34E1110", Offset = "0x34DFB10", VA = "0x1834E1110", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.ExpandType expandType = actionType_;
				num = 0;
				if (expandType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)expandType);
				}
				int num3 = amount_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B38")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepExpandHouse other)
		{
			if (other != null)
			{
				Types.ExpandType expandType = other.actionType_;
				if (expandType != 0)
				{
					actionType_ = expandType;
				}
				int num = other.amount_;
				if (num != 0)
				{
					amount_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B39")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(actionType_ = (Types.ExpandType)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (amount_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B3A")]
		[Cpp2IlInjected.Address(RVA = "0x34E1480", Offset = "0x34DFE80", VA = "0x1834E1480", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.ExpandType expandType = actionType_;
			}
			if (fieldNumber == 2)
			{
				int num = amount_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B3B")]
		[Cpp2IlInjected.Address(RVA = "0x34E1570", Offset = "0x34DFF70", VA = "0x1834E1570", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				actionType_ = (Types.ExpandType)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			amount_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B3C")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				actionType_ = Types.ExpandType.Any;
				break;
			case 2:
				amount_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B3E")]
		[Cpp2IlInjected.Address(RVA = "0x34E12D0", Offset = "0x34DFCD0", VA = "0x1834E12D0")]
		public List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_001d
			List<Item> result = (List<Item>)(object)new List<T>();
			IProfileWorld section = world.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B41")]
		[Cpp2IlInjected.Address(RVA = "0x34E1270", Offset = "0x34DFC70", VA = "0x1834E1270", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_000c
			context.AddError("Amount must have positive value");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B42")]
		[Cpp2IlInjected.Address(RVA = "0x34E16A0", Offset = "0x34E00A0", VA = "0x1834E16A0")]
		static CustomStepExpandHouse()
		{
			Func<CustomStepExpandHouse> func = default(Func<CustomStepExpandHouse>);
			_parser = (MessageParser<CustomStepExpandHouse>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B43")]
		[Cpp2IlInjected.Address(RVA = "0x34E12D0", Offset = "0x34DFCD0", VA = "0x1834E12D0", Slot = "15")]
		List<Item> IBuildingMapMarker.GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_001d
			List<Item> result = (List<Item>)(object)new List<T>();
			IProfileWorld section = world.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return result;
		}
	}
}
