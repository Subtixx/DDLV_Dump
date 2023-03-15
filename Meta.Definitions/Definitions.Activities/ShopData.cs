using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008AC")]
	public sealed class ShopData : IMessage<ShopData>, IMessage, IEquatable<ShopData>, IDeepCloneable<ShopData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A9C")]
		private static readonly MessageParser<ShopData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A9D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A9E")]
		public const int LastRefreshFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A9F")]
		private Timestamp lastRefresh_;

		[Cpp2IlInjected.Token(Token = "0x4002AA0")]
		public const int NumRefreshFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AA1")]
		private int numRefresh_;

		[Cpp2IlInjected.Token(Token = "0x4002AA2")]
		public const int SlotsFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4002AA3")]
		private static readonly FieldCodec<ShopSlot> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AA4")]
		private readonly RepeatedField<ShopSlot> slots_ = (RepeatedField<ShopSlot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002AA5")]
		public const int SeedFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002AA6")]
		private int seed_;

		[Cpp2IlInjected.Token(Token = "0x17001854")]
		public static DateTime MinDateTime
		{
			[Cpp2IlInjected.Token(Token = "0x60060F1")]
			[Cpp2IlInjected.Address(RVA = "0x384DF70", Offset = "0x384C970", VA = "0x18384DF70")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001855")]
		public DateTime LastRefreshDateTime
		{
			[Cpp2IlInjected.Token(Token = "0x60060F2")]
			[Cpp2IlInjected.Address(RVA = "0x384DED0", Offset = "0x384C8D0", VA = "0x18384DED0")]
			get
			{
				Timestamp timestamp = lastRefresh_;
				if (timestamp != null)
				{
					return timestamp.ToDateTime();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001856")]
		[DebuggerNonUserCode]
		public static MessageParser<ShopData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60060F3")]
			[Cpp2IlInjected.Address(RVA = "0x384DFC0", Offset = "0x384C9C0", VA = "0x18384DFC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001857")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60060F4")]
			[Cpp2IlInjected.Address(RVA = "0x384DE00", Offset = "0x384C800", VA = "0x18384DE00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001858")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60060F5")]
			[Cpp2IlInjected.Address(RVA = "0x384E020", Offset = "0x384CA20", VA = "0x18384E020", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001859")]
		[DebuggerNonUserCode]
		public Timestamp LastRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60060FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return lastRefresh_;
			}
			[Cpp2IlInjected.Token(Token = "0x60060FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				lastRefresh_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185A")]
		[DebuggerNonUserCode]
		public int NumRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60060FC")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return numRefresh_;
			}
			[Cpp2IlInjected.Token(Token = "0x60060FD")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				numRefresh_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185B")]
		[DebuggerNonUserCode]
		public RepeatedField<ShopSlot> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x60060FE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185C")]
		[DebuggerNonUserCode]
		public int Seed
		{
			[Cpp2IlInjected.Token(Token = "0x60060FF")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return seed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006100")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				seed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60060F6")]
		[Cpp2IlInjected.Address(RVA = "0x384DCD0", Offset = "0x384C6D0", VA = "0x18384DCD0")]
		[DebuggerNonUserCode]
		public ShopData()
		{
			//IL_0019: Expected O, but got I4
			Timestamp timestamp = (lastRefresh_ = ((DateTime)0).ToProto());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60060F7")]
		[Cpp2IlInjected.Address(RVA = "0x384D530", Offset = "0x384BF30", VA = "0x18384D530")]
		private void OnConstruction()
		{
			//IL_0006: Expected O, but got I4
			Timestamp timestamp = (lastRefresh_ = ((DateTime)0).ToProto());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60060F8")]
		[Cpp2IlInjected.Address(RVA = "0x384DAF0", Offset = "0x384C4F0", VA = "0x18384DAF0")]
		[DebuggerNonUserCode]
		public ShopData(ShopData other)
		{
			//IL_001b: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			int num = 0;
			Timestamp timestamp = (lastRefresh_ = ((DateTime)num).ToProto());
			Timestamp timestamp2 = other.lastRefresh_;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			lastRefresh_ = (Timestamp)num;
			int num2 = (numRefresh_ = other.numRefresh_);
			RepeatedField<ShopSlot> repeatedField = (slots_ = (RepeatedField<ShopSlot>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			int num3 = (seed_ = other.seed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60060F9")]
		[Cpp2IlInjected.Address(RVA = "0x384CEC0", Offset = "0x384B8C0", VA = "0x18384CEC0", Slot = "10")]
		[DebuggerNonUserCode]
		public ShopData Clone()
		{
			return new ShopData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006101")]
		[Cpp2IlInjected.Address(RVA = "0x384CF20", Offset = "0x384B920", VA = "0x18384CF20", Slot = "0")]
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
				bool flag = object.Equals(lastRefresh_, other);
				if (flag && numRefresh_ == (flag ? 1 : 0))
				{
					RepeatedField<ShopSlot> repeatedField = slots_;
					bool flag2 = default(bool);
					if (flag2 && seed_ == (flag2 ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006102")]
		[Cpp2IlInjected.Address(RVA = "0x384D020", Offset = "0x384BA20", VA = "0x18384D020", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ShopData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.lastRefresh_;
				if (object.Equals(lastRefresh_, objB))
				{
					int num = other.numRefresh_;
					if (numRefresh_ == num)
					{
						RepeatedField<ShopSlot> repeatedField = slots_;
						RepeatedField<ShopSlot> repeatedField2 = other.slots_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							int num2 = other.seed_;
							if (seed_ == num2)
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

		[Cpp2IlInjected.Token(Token = "0x6006103")]
		[Cpp2IlInjected.Address(RVA = "0x384D1D0", Offset = "0x384BBD0", VA = "0x18384D1D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0048
			Timestamp timestamp = lastRefresh_;
			if (timestamp != null)
			{
				int hashCode = timestamp.GetHashCode();
			}
			if (numRefresh_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)slots_).GetHashCode();
			if (seed_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006104")]
		[Cpp2IlInjected.Address(RVA = "0x384D780", Offset = "0x384C180", VA = "0x18384D780", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006105")]
		[Cpp2IlInjected.Address(RVA = "0x384D7E0", Offset = "0x384C1E0", VA = "0x18384D7E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0074
			if ((long)lastRefresh_ != 0)
			{
				Timestamp value = lastRefresh_;
				output.WriteMessage(value);
			}
			if (numRefresh_ != 0)
			{
				int value2 = numRefresh_;
				output.WriteInt32(value2);
			}
			RepeatedField<ShopSlot> repeatedField = slots_;
			FieldCodec<ShopSlot> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			if (seed_ != 0)
			{
				int value3 = seed_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006106")]
		[Cpp2IlInjected.Address(RVA = "0x384CCB0", Offset = "0x384B6B0", VA = "0x18384CCB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_008f
			Timestamp timestamp = lastRefresh_;
			int num = 0;
			if (timestamp != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
			}
			int num3 = numRefresh_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			RepeatedField<ShopSlot> repeatedField = slots_;
			FieldCodec<ShopSlot> repeated_slots_codec = _repeated_slots_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			int num6 = seed_;
			num += num5;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006107")]
		[Cpp2IlInjected.Address(RVA = "0x384D290", Offset = "0x384BC90", VA = "0x18384D290", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ShopData other)
		{
			//Discarded unreachable code: IL_0098
			if (other == null)
			{
				return;
			}
			if ((long)other.lastRefresh_ != 0)
			{
				Timestamp timestamp = lastRefresh_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastRefresh_ = new Timestamp());
				}
				Timestamp other2 = other.lastRefresh_;
				timestamp.MergeFrom(other2);
			}
			int num = other.numRefresh_;
			if (num != 0)
			{
				numRefresh_ = num;
			}
			RepeatedField<ShopSlot> repeatedField = slots_;
			RepeatedField<ShopSlot> repeatedField2 = other.slots_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num2 = other.seed_;
			if (num2 != 0)
			{
				seed_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6006108")]
		[Cpp2IlInjected.Address(RVA = "0x384D3A0", Offset = "0x384BDA0", VA = "0x18384D3A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a1
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					RepeatedField<ShopSlot> repeatedField = slots_;
					FieldCodec<ShopSlot> repeated_slots_codec = _repeated_slots_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
				}
				if (num != 32)
				{
					goto IL_008a;
				}
				int num2 = (seed_ = input.ReadInt32());
			}
			Timestamp timestamp = default(Timestamp);
			if (num == 10)
			{
				Timestamp builder = default(Timestamp);
				if (lastRefresh_ == null)
				{
					timestamp = (lastRefresh_ = new Timestamp());
					builder = lastRefresh_;
				}
				input.ReadMessage(builder);
			}
			if ((long)timestamp == 16)
			{
				int num3 = (numRefresh_ = input.ReadInt32());
			}
			goto IL_008a;
			IL_008a:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006109")]
		[Cpp2IlInjected.Address(RVA = "0x384D0E0", Offset = "0x384BAE0", VA = "0x18384D0E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num != 1)
					{
						goto IL_0029;
					}
					RepeatedField<ShopSlot> repeatedField = slots_;
				}
				int num2 = numRefresh_;
			}
			Timestamp timestamp = lastRefresh_;
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600610A")]
		[Cpp2IlInjected.Address(RVA = "0x384D600", Offset = "0x384C000", VA = "0x18384D600", Slot = "12")]
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
					switch (num)
					{
					case 1:
					{
						object obj = default(object);
						seed_ = (int)obj;
						break;
					}
					case 0:
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					}
				}
				else
				{
					object obj2 = default(object);
					numRefresh_ = (int)obj2;
				}
				return;
			}
			if (value == null || value != null)
			{
				lastRefresh_ = (Timestamp)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600610B")]
		[Cpp2IlInjected.Address(RVA = "0x384CE10", Offset = "0x384B810", VA = "0x18384CE10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0030
			//IL_001d: Expected I4, but got I8
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
					seed_ = 0;
					return;
				case 0:
					break;
				default:
					return;
				}
				RepeatedField<ShopSlot> repeatedField = slots_;
			}
			numRefresh_ = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600610C")]
		[Cpp2IlInjected.Address(RVA = "0x384D920", Offset = "0x384C320", VA = "0x18384D920")]
		static ShopData()
		{
			Func<ShopData> func = default(Func<ShopData>);
			_parser = (MessageParser<ShopData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ShopSlot> parser = ShopSlot._parser;
			uint num = default(uint);
			_parser = (MessageParser<ShopData>)(object)FieldCodec.ForMessage<ShopSlot>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
