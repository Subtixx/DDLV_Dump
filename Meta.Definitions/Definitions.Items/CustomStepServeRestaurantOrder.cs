using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000485")]
	public sealed class CustomStepServeRestaurantOrder : IMessage<CustomStepServeRestaurantOrder>, IMessage, IEquatable<CustomStepServeRestaurantOrder>, IDeepCloneable<CustomStepServeRestaurantOrder>, IMessageFieldAccessor, IStepAmount, IMinStarRatingReq, IStringTag, IBuildingMapMarker
	{
		[Cpp2IlInjected.Token(Token = "0x4001847")]
		private static readonly MessageParser<CustomStepServeRestaurantOrder> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001848")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001849")]
		public const int AmountFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400184A")]
		private StepAmount amount_;

		[Cpp2IlInjected.Token(Token = "0x400184B")]
		public const int MinimumStarRatingFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400184C")]
		private StepAmount minimumStarRating_;

		[Cpp2IlInjected.Token(Token = "0x17000E1B")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepServeRestaurantOrder> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003760")]
			[Cpp2IlInjected.Address(RVA = "0x31FFE30", Offset = "0x31FE830", VA = "0x1831FFE30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003761")]
			[Cpp2IlInjected.Address(RVA = "0x31FFD60", Offset = "0x31FE760", VA = "0x1831FFD60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003762")]
			[Cpp2IlInjected.Address(RVA = "0x3200030", Offset = "0x31FEA30", VA = "0x183200030", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1E")]
		[DebuggerNonUserCode]
		public StepAmount Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003767")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003768")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				amount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E1F")]
		[DebuggerNonUserCode]
		public StepAmount MinimumStarRating
		{
			[Cpp2IlInjected.Token(Token = "0x6003769")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return minimumStarRating_;
			}
			[Cpp2IlInjected.Token(Token = "0x600376A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				minimumStarRating_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E20")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003776")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return amount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E21")]
		public StepAmount MinStarRatingReq
		{
			[Cpp2IlInjected.Token(Token = "0x6003777")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return minimumStarRating_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E22")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003778")]
			[Cpp2IlInjected.Address(RVA = "0x31FFE90", Offset = "0x31FE890", VA = "0x1831FFE90", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[0] = "TargetAmount";
					if ("CurrentAmount" == null || "CurrentAmount" != null)
					{
						array[1] = "CurrentAmount";
						if ("MinimumStarRating" == null || "MinimumStarRating" != null)
						{
							break;
						}
					}
				}
				array[2] = "MinimumStarRating";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003763")]
		[Cpp2IlInjected.Address(RVA = "0x31FFCD0", Offset = "0x31FE6D0", VA = "0x1831FFCD0")]
		[DebuggerNonUserCode]
		public CustomStepServeRestaurantOrder()
		{
			StepAmount stepAmount = (amount_ = new StepAmount());
			StepAmount stepAmount2 = (minimumStarRating_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003764")]
		[Cpp2IlInjected.Address(RVA = "0x31FF900", Offset = "0x31FE300", VA = "0x1831FF900")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (amount_ = new StepAmount());
			StepAmount stepAmount2 = (minimumStarRating_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003765")]
		[Cpp2IlInjected.Address(RVA = "0x31FFBB0", Offset = "0x31FE5B0", VA = "0x1831FFBB0")]
		[DebuggerNonUserCode]
		public CustomStepServeRestaurantOrder(CustomStepServeRestaurantOrder other)
		{
			//IL_003c: Expected O, but got I4
			StepAmount stepAmount = (amount_ = new StepAmount());
			StepAmount stepAmount2 = (minimumStarRating_ = new StepAmount());
			StepAmount stepAmount3 = other.amount_;
			int num = 0;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			amount_ = (StepAmount)num;
			StepAmount stepAmount5 = other.minimumStarRating_;
			StepAmount stepAmount6 = default(StepAmount);
			if (stepAmount5 != null)
			{
				stepAmount6 = stepAmount5.Clone();
			}
			minimumStarRating_ = stepAmount6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003766")]
		[Cpp2IlInjected.Address(RVA = "0x31FF340", Offset = "0x31FDD40", VA = "0x1831FF340", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepServeRestaurantOrder Clone()
		{
			//Discarded unreachable code: IL_0073
			//IL_003e: Expected O, but got I4
			CustomStepServeRestaurantOrder customStepServeRestaurantOrder = new CustomStepServeRestaurantOrder();
			StepAmount stepAmount = (customStepServeRestaurantOrder.amount_ = new StepAmount());
			StepAmount stepAmount2 = (customStepServeRestaurantOrder.minimumStarRating_ = new StepAmount());
			StepAmount stepAmount3 = amount_;
			int num = 0;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			customStepServeRestaurantOrder.amount_ = (StepAmount)num;
			StepAmount stepAmount5 = minimumStarRating_;
			StepAmount stepAmount6 = default(StepAmount);
			if (stepAmount5 != null)
			{
				stepAmount6 = stepAmount5.Clone();
			}
			customStepServeRestaurantOrder.minimumStarRating_ = stepAmount6;
			UnknownFieldSet unknownFieldSet = (customStepServeRestaurantOrder._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepServeRestaurantOrder;
		}

		[Cpp2IlInjected.Token(Token = "0x600376B")]
		[Cpp2IlInjected.Address(RVA = "0x31FF560", Offset = "0x31FDF60", VA = "0x1831FF560", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(amount_, other) && object.Equals(minimumStarRating_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600376C")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepServeRestaurantOrder other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				StepAmount objB = other.amount_;
				if (object.Equals(amount_, objB))
				{
					StepAmount objB2 = other.minimumStarRating_;
					if (object.Equals(minimumStarRating_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600376D")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				StepAmount stepAmount = amount_;
				if (stepAmount != null)
				{
					int hashCode = stepAmount.GetHashCode();
				}
				StepAmount stepAmount2 = minimumStarRating_;
				if (stepAmount2 != null)
				{
					int hashCode2 = stepAmount2.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600376E")]
		[Cpp2IlInjected.Address(RVA = "0x31FFA40", Offset = "0x31FE440", VA = "0x1831FFA40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600376F")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)amount_ != 0)
			{
				StepAmount value = amount_;
				output.WriteMessage(value);
			}
			if ((long)minimumStarRating_ != 0)
			{
				StepAmount value2 = minimumStarRating_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003770")]
		[Cpp2IlInjected.Address(RVA = "0x31FF270", Offset = "0x31FDC70", VA = "0x1831FF270", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				StepAmount stepAmount = amount_;
				num = 0;
				if (stepAmount != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(stepAmount);
				}
				StepAmount stepAmount2 = minimumStarRating_;
				if (stepAmount2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount2);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003771")]
		[Cpp2IlInjected.Address(RVA = "0x31FF6B0", Offset = "0x31FE0B0", VA = "0x1831FF6B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepServeRestaurantOrder other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.amount_ != 0)
			{
				StepAmount stepAmount = amount_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amount_ = new StepAmount());
					StepAmount stepAmount3 = amount_;
				}
				StepAmount other2 = other.amount_;
				stepAmount.MergeFrom(other2);
			}
			if ((long)other.minimumStarRating_ != 0)
			{
				StepAmount stepAmount5 = default(StepAmount);
				if (minimumStarRating_ == null)
				{
					StepAmount stepAmount4 = (minimumStarRating_ = new StepAmount());
					stepAmount5 = minimumStarRating_;
				}
				StepAmount other3 = other.minimumStarRating_;
				stepAmount5.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003772")]
		[Cpp2IlInjected.Address(RVA = "0x31FF7D0", Offset = "0x31FE1D0", VA = "0x1831FF7D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				StepAmount stepAmount = amount_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amount_ = new StepAmount());
				}
				input.ReadMessage(stepAmount);
			}
			if (num == 18)
			{
				StepAmount builder = default(StepAmount);
				if (minimumStarRating_ == null)
				{
					StepAmount stepAmount3 = (minimumStarRating_ = new StepAmount());
					builder = minimumStarRating_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003773")]
		[Cpp2IlInjected.Address(RVA = "0x31FF620", Offset = "0x31FE020", VA = "0x1831FF620", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				StepAmount stepAmount = amount_;
			}
			if (fieldNumber == 2)
			{
				StepAmount stepAmount2 = minimumStarRating_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003774")]
		[Cpp2IlInjected.Address(RVA = "0x31FF990", Offset = "0x31FE390", VA = "0x1831FF990", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					amount_ = (StepAmount)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003775")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003779")]
		[Cpp2IlInjected.Address(RVA = "0x31FF4A0", Offset = "0x31FDEA0", VA = "0x1831FF4A0")]
		public List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_0015
			List<Item> list = (List<Item>)(object)new List<T>();
			Item restaurant = BuildingItem.Restaurant;
			((List<T>)(object)list).Add((T)restaurant);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x600377A")]
		[Cpp2IlInjected.Address(RVA = "0x31FFAA0", Offset = "0x31FE4A0", VA = "0x1831FFAA0")]
		static CustomStepServeRestaurantOrder()
		{
			Func<CustomStepServeRestaurantOrder> func = default(Func<CustomStepServeRestaurantOrder>);
			_parser = (MessageParser<CustomStepServeRestaurantOrder>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600377B")]
		[Cpp2IlInjected.Address(RVA = "0x31FF4A0", Offset = "0x31FDEA0", VA = "0x1831FF4A0", Slot = "17")]
		List<Item> IBuildingMapMarker.GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_0015
			List<Item> list = (List<Item>)(object)new List<T>();
			Item restaurant = BuildingItem.Restaurant;
			((List<T>)(object)list).Add((T)restaurant);
			return list;
		}
	}
}
