using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004CB")]
	public sealed class CustomStepFinishHouse : IMessage<CustomStepFinishHouse>, IMessage, IEquatable<CustomStepFinishHouse>, IDeepCloneable<CustomStepFinishHouse>, IMessageFieldAccessor, IUniqueItem, IStepAmount, ITargetCharacterOverride, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40019A0")]
		private static readonly MessageParser<CustomStepFinishHouse> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019A1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019A2")]
		public const int HouseFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019A3")]
		private int house_;

		[Cpp2IlInjected.Token(Token = "0x40019A4")]
		public const int HouseOwnerFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40019A5")]
		private int houseOwner_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019A6")]
		private StepAmount stepAmount;

		[Cpp2IlInjected.Token(Token = "0x17000F1B")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepFinishHouse> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003B0A")]
			[Cpp2IlInjected.Address(RVA = "0x34E48D0", Offset = "0x34E32D0", VA = "0x1834E48D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B0B")]
			[Cpp2IlInjected.Address(RVA = "0x34E47A0", Offset = "0x34E31A0", VA = "0x1834E47A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B0C")]
			[Cpp2IlInjected.Address(RVA = "0x34E4BC0", Offset = "0x34E35C0", VA = "0x1834E4BC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1E")]
		[DebuggerNonUserCode]
		public int House
		{
			[Cpp2IlInjected.Token(Token = "0x6003B10")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return house_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B11")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				house_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1F")]
		[DebuggerNonUserCode]
		public int HouseOwner
		{
			[Cpp2IlInjected.Token(Token = "0x6003B12")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return houseOwner_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B13")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				houseOwner_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F20")]
		public Item HouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003B1F")]
			[Cpp2IlInjected.Address(RVA = "0x34E4870", Offset = "0x34E3270", VA = "0x1834E4870")]
			get
			{
				long num = Convert.ToInt64((uint)house_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F21")]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6003B20")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return house_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F22")]
		public (Item? characterItem, bool random) TargetCharacterOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6003B21")]
			[Cpp2IlInjected.Address(RVA = "0x34E4B00", Offset = "0x34E3500", VA = "0x1834E4B00", Slot = "16")]
			get
			{
				int num = 0;
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F23")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B22")]
			[Cpp2IlInjected.Address(RVA = "0x34E4930", Offset = "0x34E3330", VA = "0x1834E4930", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_004a
				StepAmount stepAmount = this.stepAmount;
				if (stepAmount == null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					long num = Convert.ToInt64((uint)house_);
					BuildingItemData buildingItemData = default(BuildingItemData);
					if (buildingItemData == null)
					{
						return stepAmount;
					}
					StepAmount stepAmount2 = (this.stepAmount = new StepAmount());
					ScalableValue scalableValue = default(ScalableValue);
					int num2 = (scalableValue.value_ = ((RepeatedField<T>)(object)buildingItemData.requiredFurnitures_).Count);
				}
				return stepAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B0D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CustomStepFinishHouse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003B0E")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public CustomStepFinishHouse(CustomStepFinishHouse other)
		{
			int num = (house_ = other.house_);
			int num2 = (houseOwner_ = other.houseOwner_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B0F")]
		[Cpp2IlInjected.Address(RVA = "0x34E41F0", Offset = "0x34E2BF0", VA = "0x1834E41F0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepFinishHouse Clone()
		{
			//Discarded unreachable code: IL_0037
			CustomStepFinishHouse customStepFinishHouse = new CustomStepFinishHouse();
			int num = (customStepFinishHouse.house_ = house_);
			int num2 = (customStepFinishHouse.houseOwner_ = houseOwner_);
			UnknownFieldSet unknownFieldSet = (customStepFinishHouse._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepFinishHouse;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B14")]
		[Cpp2IlInjected.Address(RVA = "0x34E4420", Offset = "0x34E2E20", VA = "0x1834E4420", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)house_ == (IntPtr)typeof(CustomStepFinishHouse).TypeHandle && (IntPtr)houseOwner_ == (IntPtr)typeof(CustomStepFinishHouse).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B15")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepFinishHouse other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.house_;
				if (house_ == num)
				{
					int num2 = other.houseOwner_;
					if (houseOwner_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B16")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (house_ != 0)
				{
				}
				if (houseOwner_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B17")]
		[Cpp2IlInjected.Address(RVA = "0x34E4630", Offset = "0x34E3030", VA = "0x1834E4630", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B18")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (house_ != 0)
			{
				int value = house_;
				output.WriteInt32(value);
			}
			if (houseOwner_ != 0)
			{
				int value2 = houseOwner_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B19")]
		[Cpp2IlInjected.Address(RVA = "0x34E4120", Offset = "0x34E2B20", VA = "0x1834E4120", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = house_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = houseOwner_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1A")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepFinishHouse other)
		{
			if (other != null)
			{
				int num = other.house_;
				if (num != 0)
				{
					house_ = num;
				}
				int num2 = other.houseOwner_;
				if (num2 != 0)
				{
					houseOwner_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1B")]
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
					int num2 = (house_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (houseOwner_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1C")]
		[Cpp2IlInjected.Address(RVA = "0x34E44B0", Offset = "0x34E2EB0", VA = "0x1834E44B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = house_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1D")]
		[Cpp2IlInjected.Address(RVA = "0x34E4570", Offset = "0x34E2F70", VA = "0x1834E4570", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				house_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			houseOwner_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1E")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				house_ = 0;
				break;
			case 2:
				houseOwner_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B23")]
		[Cpp2IlInjected.Address(RVA = "0x34E4280", Offset = "0x34E2C80", VA = "0x1834E4280", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0031
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = house_;
			bool flag = default(bool);
			if (!flag)
			{
				string missionStepName = context.MissionStepName;
				string error = "House is required for " + missionStepName;
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B24")]
		[Cpp2IlInjected.Address(RVA = "0x34E4690", Offset = "0x34E3090", VA = "0x1834E4690")]
		static CustomStepFinishHouse()
		{
			Func<CustomStepFinishHouse> func = default(Func<CustomStepFinishHouse>);
			_parser = (MessageParser<CustomStepFinishHouse>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
