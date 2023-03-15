using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200088C")]
	public sealed class CharacterRestaurantOrder : IMessage<CharacterRestaurantOrder>, IMessage, IEquatable<CharacterRestaurantOrder>, IDeepCloneable<CharacterRestaurantOrder>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400225C")]
		private static readonly MessageParser<CharacterRestaurantOrder> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400225D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400225E")]
		public const int CharacterItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400225F")]
		private int characterItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002260")]
		public const int MealItemIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002261")]
		private int mealItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002262")]
		public const int ExpirationTimeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002263")]
		private Timestamp expirationTime_;

		[Cpp2IlInjected.Token(Token = "0x4002264")]
		public const int FulfilledFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002265")]
		private bool fulfilled_;

		[Cpp2IlInjected.Token(Token = "0x17000C07")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterRestaurantOrder> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004861")]
			[Cpp2IlInjected.Address(RVA = "0x71B3A0", Offset = "0x719DA0", VA = "0x18071B3A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C08")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004862")]
			[Cpp2IlInjected.Address(RVA = "0x71B270", Offset = "0x719C70", VA = "0x18071B270")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C09")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004863")]
			[Cpp2IlInjected.Address(RVA = "0x71B400", Offset = "0x719E00", VA = "0x18071B400", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0A")]
		[DebuggerNonUserCode]
		public int CharacterItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004868")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return characterItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004869")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				characterItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0B")]
		[DebuggerNonUserCode]
		public int MealItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600486A")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return mealItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600486B")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				mealItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0C")]
		[DebuggerNonUserCode]
		public Timestamp ExpirationTime
		{
			[Cpp2IlInjected.Token(Token = "0x600486C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return expirationTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x600486D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				expirationTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0D")]
		[DebuggerNonUserCode]
		public bool Fulfilled
		{
			[Cpp2IlInjected.Token(Token = "0x600486E")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return fulfilled_;
			}
			[Cpp2IlInjected.Token(Token = "0x600486F")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				fulfilled_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0E")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x600487B")]
			[Cpp2IlInjected.Address(RVA = "0x71B210", Offset = "0x719C10", VA = "0x18071B210")]
			get
			{
				long num = Convert.ToInt64((uint)characterItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600487C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				characterItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C0F")]
		public Item MealItem
		{
			[Cpp2IlInjected.Token(Token = "0x600487D")]
			[Cpp2IlInjected.Address(RVA = "0x71B340", Offset = "0x719D40", VA = "0x18071B340")]
			get
			{
				long num = Convert.ToInt64((uint)mealItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600487E")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				//IL_0007: Expected I4, but got O
				mealItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004864")]
		[Cpp2IlInjected.Address(RVA = "0x71B0C0", Offset = "0x719AC0", VA = "0x18071B0C0")]
		[DebuggerNonUserCode]
		public CharacterRestaurantOrder()
		{
			Timestamp timestamp = (expirationTime_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004865")]
		[Cpp2IlInjected.Address(RVA = "0x71AC90", Offset = "0x719690", VA = "0x18071AC90")]
		private void OnConstruction()
		{
			Timestamp timestamp = (expirationTime_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004866")]
		[Cpp2IlInjected.Address(RVA = "0x71B130", Offset = "0x719B30", VA = "0x18071B130")]
		[DebuggerNonUserCode]
		public CharacterRestaurantOrder(CharacterRestaurantOrder other)
		{
			//IL_004d: Expected O, but got I4
			Timestamp timestamp = (expirationTime_ = new Timestamp());
			int num = (characterItemID_ = other.characterItemID_);
			int num2 = (mealItemID_ = other.mealItemID_);
			Timestamp timestamp2 = other.expirationTime_;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			int num3 = 0;
			expirationTime_ = (Timestamp)num3;
			bool flag = (fulfilled_ = other.fulfilled_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004867")]
		[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719060", VA = "0x18071A660", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterRestaurantOrder Clone()
		{
			//Discarded unreachable code: IL_0077
			//IL_0050: Expected O, but got I4
			CharacterRestaurantOrder characterRestaurantOrder = new CharacterRestaurantOrder();
			Timestamp timestamp = (characterRestaurantOrder.expirationTime_ = new Timestamp());
			int num = (characterRestaurantOrder.characterItemID_ = characterItemID_);
			int num2 = (characterRestaurantOrder.mealItemID_ = mealItemID_);
			Timestamp timestamp2 = expirationTime_;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			int num3 = 0;
			characterRestaurantOrder.expirationTime_ = (Timestamp)num3;
			bool flag = (characterRestaurantOrder.fulfilled_ = fulfilled_);
			UnknownFieldSet unknownFieldSet = (characterRestaurantOrder._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return characterRestaurantOrder;
		}

		[Cpp2IlInjected.Token(Token = "0x6004870")]
		[Cpp2IlInjected.Address(RVA = "0x71A7F0", Offset = "0x7191F0", VA = "0x18071A7F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)characterItemID_ == (IntPtr)typeof(CharacterRestaurantOrder).TypeHandle && (IntPtr)mealItemID_ == (IntPtr)typeof(CharacterRestaurantOrder).TypeHandle)
				{
					bool flag = object.Equals(expirationTime_, other);
					if (flag && fulfilled_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004871")]
		[Cpp2IlInjected.Address(RVA = "0x71A770", Offset = "0x719170", VA = "0x18071A770", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterRestaurantOrder other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.characterItemID_;
				if (characterItemID_ == num)
				{
					int num2 = other.mealItemID_;
					if (mealItemID_ == num2)
					{
						Timestamp objB = other.expirationTime_;
						if (object.Equals(expirationTime_, objB))
						{
							bool flag = other.fulfilled_;
							if (fulfilled_ == flag)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004872")]
		[Cpp2IlInjected.Address(RVA = "0x71A9C0", Offset = "0x7193C0", VA = "0x18071A9C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (characterItemID_ != 0)
				{
				}
				if (mealItemID_ != 0)
				{
				}
				Timestamp timestamp = expirationTime_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				if (fulfilled_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004873")]
		[Cpp2IlInjected.Address(RVA = "0x71AE70", Offset = "0x719870", VA = "0x18071AE70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004874")]
		[Cpp2IlInjected.Address(RVA = "0x71AED0", Offset = "0x7198D0", VA = "0x18071AED0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0074
			if (characterItemID_ != 0)
			{
				int value = characterItemID_;
				output.WriteInt32(value);
			}
			if (mealItemID_ != 0)
			{
				int value2 = mealItemID_;
				output.WriteInt32(value2);
			}
			if ((long)expirationTime_ != 0)
			{
				Timestamp value3 = expirationTime_;
				output.WriteMessage(value3);
			}
			if (fulfilled_)
			{
				bool value4 = fulfilled_;
				output.WriteBool(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004875")]
		[Cpp2IlInjected.Address(RVA = "0x71A510", Offset = "0x718F10", VA = "0x18071A510", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = characterItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = mealItemID_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				Timestamp timestamp = expirationTime_;
				if (timestamp != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(timestamp);
					num6++;
					num2 += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004876")]
		[Cpp2IlInjected.Address(RVA = "0x71AA80", Offset = "0x719480", VA = "0x18071AA80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterRestaurantOrder other)
		{
			//Discarded unreachable code: IL_0098
			if (other == null)
			{
				return;
			}
			int num = other.characterItemID_;
			if (num != 0)
			{
				characterItemID_ = num;
			}
			int num2 = other.mealItemID_;
			if (num2 != 0)
			{
				mealItemID_ = num2;
			}
			if ((long)other.expirationTime_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (expirationTime_ == null)
				{
					Timestamp timestamp = (expirationTime_ = new Timestamp());
					timestamp2 = expirationTime_;
				}
				Timestamp other2 = other.expirationTime_;
				timestamp2.MergeFrom(other2);
			}
			bool flag = other.fulfilled_;
			if (flag)
			{
				fulfilled_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004877")]
		[Cpp2IlInjected.Address(RVA = "0x71AB70", Offset = "0x719570", VA = "0x18071AB70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0090
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					Timestamp timestamp = expirationTime_;
					if (timestamp == null)
					{
						Timestamp timestamp2 = (expirationTime_ = new Timestamp());
					}
					input.ReadMessage(timestamp);
				}
				if (num != 32)
				{
					goto IL_0079;
				}
				bool flag = (fulfilled_ = input.ReadBool());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (characterItemID_ = input.ReadInt32());
			}
			if (num2 == 16)
			{
				int num3 = (mealItemID_ = input.ReadInt32());
			}
			goto IL_0079;
			IL_0079:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004878")]
		[Cpp2IlInjected.Address(RVA = "0x71A8B0", Offset = "0x7192B0", VA = "0x18071A8B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0029;
					}
					bool flag = fulfilled_;
				}
				Timestamp timestamp = expirationTime_;
			}
			int num2 = characterItemID_;
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004879")]
		[Cpp2IlInjected.Address(RVA = "0x71ACF0", Offset = "0x7196F0", VA = "0x18071ACF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003b
			//IL_001b: Expected I4, but got O
			//IL_0032: Expected I4, but got O
			//IL_003a: Expected I4, but got O
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
						fulfilled_ = (byte)(int)obj != 0;
						return;
					}
					default:
						return;
					case 0:
						break;
					}
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					expirationTime_ = (Timestamp)value;
				}
				object obj2 = default(object);
				mealItemID_ = (int)obj2;
			}
			else
			{
				object obj3 = default(object);
				characterItemID_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600487A")]
		[Cpp2IlInjected.Address(RVA = "0x71A620", Offset = "0x719020", VA = "0x18071A620", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				fulfilled_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600487F")]
		[Cpp2IlInjected.Address(RVA = "0x71AFB0", Offset = "0x7199B0", VA = "0x18071AFB0")]
		static CharacterRestaurantOrder()
		{
			Func<CharacterRestaurantOrder> func = default(Func<CharacterRestaurantOrder>);
			_parser = (MessageParser<CharacterRestaurantOrder>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
