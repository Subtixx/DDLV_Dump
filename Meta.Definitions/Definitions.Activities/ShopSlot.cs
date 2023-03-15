using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008AA")]
	[DebuggerDisplay("{DebugDisplay,nq}")]
	public sealed class ShopSlot : IMessage<ShopSlot>, IMessage, IEquatable<ShopSlot>, IDeepCloneable<ShopSlot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002A91")]
		private static readonly MessageParser<ShopSlot> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A92")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A93")]
		public const int SlotIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A94")]
		private int slotId_;

		[Cpp2IlInjected.Token(Token = "0x4002A95")]
		public const int ItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A96")]
		private ItemAmount item_;

		[Cpp2IlInjected.Token(Token = "0x4002A97")]
		public const int MaxAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A98")]
		private int maxAmount_;

		[Cpp2IlInjected.Token(Token = "0x4002A99")]
		public const int RegenFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A9A")]
		private Duration regen_;

		[Cpp2IlInjected.Token(Token = "0x1700184A")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60060D0")]
			[Cpp2IlInjected.Address(RVA = "0x384F560", Offset = "0x384DF60", VA = "0x18384F560")]
			get
			{
				//Discarded unreachable code: IL_000c
				return item_.DebugDisplay;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184B")]
		public bool HasLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60060D2")]
			[Cpp2IlInjected.Address(RVA = "0x384F740", Offset = "0x384E140", VA = "0x18384F740")]
			get
			{
				//Discarded unreachable code: IL_0012
				return item_.amount_ != -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184C")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60060D3")]
			[Cpp2IlInjected.Address(RVA = "0x2A310B0", Offset = "0x2A2FAB0", VA = "0x182A310B0")]
			get
			{
				return (long)item_ == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184D")]
		[DebuggerNonUserCode]
		public static MessageParser<ShopSlot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60060D4")]
			[Cpp2IlInjected.Address(RVA = "0x384F7F0", Offset = "0x384E1F0", VA = "0x18384F7F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60060D5")]
			[Cpp2IlInjected.Address(RVA = "0x384F650", Offset = "0x384E050", VA = "0x18384F650")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700184F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60060D6")]
			[Cpp2IlInjected.Address(RVA = "0x384F960", Offset = "0x384E360", VA = "0x18384F960", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001850")]
		[DebuggerNonUserCode]
		public int SlotId
		{
			[Cpp2IlInjected.Token(Token = "0x60060DA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return slotId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60060DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				slotId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001851")]
		[DebuggerNonUserCode]
		public ItemAmount Item
		{
			[Cpp2IlInjected.Token(Token = "0x60060DC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x60060DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001852")]
		[DebuggerNonUserCode]
		public int MaxAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60060DE")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return maxAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60060DF")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				maxAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001853")]
		[DebuggerNonUserCode]
		public Duration Regen
		{
			[Cpp2IlInjected.Token(Token = "0x60060E0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return regen_;
			}
			[Cpp2IlInjected.Token(Token = "0x60060E1")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				regen_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60060D1")]
		[Cpp2IlInjected.Address(RVA = "0x384E360", Offset = "0x384CD60", VA = "0x18384E360")]
		public void Clear()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60060D7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ShopSlot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60060D8")]
		[Cpp2IlInjected.Address(RVA = "0x384F400", Offset = "0x384DE00", VA = "0x18384F400")]
		[DebuggerNonUserCode]
		public ShopSlot(ShopSlot other)
		{
			//IL_002f: Expected O, but got I4
			int num = (slotId_ = other.slotId_);
			ItemAmount itemAmount = other.item_;
			int num2 = 0;
			if (itemAmount != null)
			{
				ItemAmount itemAmount2 = itemAmount.Clone();
			}
			item_ = (ItemAmount)num2;
			int num3 = (maxAmount_ = other.maxAmount_);
			Duration duration = other.regen_;
			Duration duration2 = default(Duration);
			if (duration != null)
			{
				duration2 = duration.Clone();
			}
			regen_ = duration2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60060D9")]
		[Cpp2IlInjected.Address(RVA = "0x384E460", Offset = "0x384CE60", VA = "0x18384E460", Slot = "10")]
		[DebuggerNonUserCode]
		public ShopSlot Clone()
		{
			//Discarded unreachable code: IL_0075
			//IL_0030: Expected O, but got I4
			ShopSlot shopSlot = new ShopSlot();
			int num = (shopSlot.slotId_ = slotId_);
			ItemAmount itemAmount = item_;
			int num2 = 0;
			if (itemAmount != null)
			{
				ItemAmount itemAmount2 = itemAmount.Clone();
			}
			shopSlot.item_ = (ItemAmount)num2;
			int num3 = (shopSlot.maxAmount_ = maxAmount_);
			Duration duration = regen_;
			Duration duration2 = default(Duration);
			if (duration != null)
			{
				duration2 = duration.Clone();
			}
			shopSlot.regen_ = duration2;
			UnknownFieldSet unknownFieldSet = (shopSlot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return shopSlot;
		}

		[Cpp2IlInjected.Token(Token = "0x60060E2")]
		[Cpp2IlInjected.Address(RVA = "0x384E540", Offset = "0x384CF40", VA = "0x18384E540", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)slotId_ == (IntPtr)typeof(ShopSlot).TypeHandle)
				{
					bool flag = object.Equals(item_, other);
					if (flag && maxAmount_ == (flag ? 1 : 0) && object.Equals(regen_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60060E3")]
		[Cpp2IlInjected.Address(RVA = "0x2122330", Offset = "0x2120D30", VA = "0x182122330", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ShopSlot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.slotId_;
				if (slotId_ == num)
				{
					ItemAmount objB = other.item_;
					if (object.Equals(item_, objB))
					{
						int num2 = other.maxAmount_;
						if (maxAmount_ == num2)
						{
							Duration objB2 = other.regen_;
							if (object.Equals(regen_, objB2))
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

		[Cpp2IlInjected.Token(Token = "0x60060E4")]
		[Cpp2IlInjected.Address(RVA = "0x384E880", Offset = "0x384D280", VA = "0x18384E880", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (slotId_ != 0)
				{
				}
				ItemAmount itemAmount = item_;
				if (itemAmount != null)
				{
					int hashCode = itemAmount.GetHashCode();
				}
				if (maxAmount_ != 0)
				{
				}
				Duration duration = regen_;
				if (duration != null)
				{
					int hashCode2 = duration.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60060E5")]
		[Cpp2IlInjected.Address(RVA = "0x384F0A0", Offset = "0x384DAA0", VA = "0x18384F0A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60060E6")]
		[Cpp2IlInjected.Address(RVA = "0x2126A00", Offset = "0x2125400", VA = "0x182126A00", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0076
			if (slotId_ != 0)
			{
				int value = slotId_;
				output.WriteInt32(value);
			}
			if ((long)item_ != 0)
			{
				ItemAmount value2 = item_;
				output.WriteMessage(value2);
			}
			if (maxAmount_ != 0)
			{
				int value3 = maxAmount_;
				output.WriteInt32(value3);
			}
			if ((long)regen_ != 0)
			{
				Duration value4 = regen_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60060E7")]
		[Cpp2IlInjected.Address(RVA = "0x384E130", Offset = "0x384CB30", VA = "0x18384E130", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = slotId_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				ItemAmount itemAmount = item_;
				if (itemAmount != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(itemAmount);
					num4++;
					num2 += num4;
				}
				int num5 = maxAmount_;
				if (num5 != 0)
				{
					int num6 = CodedOutputStream.ComputeInt32Size(num5);
					num6++;
					num2 += num6;
				}
				Duration duration = regen_;
				if (duration != null)
				{
					int num7 = CodedOutputStream.ComputeMessageSize(duration);
					num7++;
					num2 += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60060E8")]
		[Cpp2IlInjected.Address(RVA = "0x384EB10", Offset = "0x384D510", VA = "0x18384EB10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ShopSlot other)
		{
			//Discarded unreachable code: IL_00c0
			if (other == null)
			{
				return;
			}
			int num = other.slotId_;
			if (num != 0)
			{
				slotId_ = num;
			}
			if ((long)other.item_ != 0)
			{
				ItemAmount itemAmount2 = default(ItemAmount);
				if (item_ == null)
				{
					ItemAmount itemAmount = (item_ = new ItemAmount());
					itemAmount2 = item_;
				}
				ItemAmount other2 = other.item_;
				itemAmount2.MergeFrom(other2);
			}
			int num2 = other.maxAmount_;
			if (num2 != 0)
			{
				maxAmount_ = num2;
			}
			if ((long)other.regen_ != 0)
			{
				Duration duration2 = default(Duration);
				if (regen_ == null)
				{
					Duration duration = (regen_ = new Duration());
					duration2 = regen_;
				}
				Duration other3 = other.regen_;
				duration2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60060E9")]
		[Cpp2IlInjected.Address(RVA = "0x384EC50", Offset = "0x384D650", VA = "0x18384EC50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ad
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					int num2 = (maxAmount_ = input.ReadInt32());
				}
				if (num != 34)
				{
					goto IL_0096;
				}
				Duration builder = default(Duration);
				if (regen_ == null)
				{
					Duration duration = (regen_ = new Duration());
					builder = regen_;
				}
				input.ReadMessage(builder);
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (slotId_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				ItemAmount builder2 = default(ItemAmount);
				if (item_ == null)
				{
					ItemAmount itemAmount = (item_ = new ItemAmount());
					builder2 = item_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_0096;
			IL_0096:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60060EA")]
		[Cpp2IlInjected.Address(RVA = "0x384E790", Offset = "0x384D190", VA = "0x18384E790", Slot = "11")]
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
					Duration duration = regen_;
				}
				ItemAmount itemAmount = item_;
			}
			int num2 = slotId_;
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60060EB")]
		[Cpp2IlInjected.Address(RVA = "0x384EE00", Offset = "0x384D800", VA = "0x18384EE00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003e
			//IL_0025: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_003d: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							regen_ = (Duration)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
					{
						object obj = default(object);
						maxAmount_ = (int)obj;
						break;
					}
					}
					return;
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			object obj2 = default(object);
			slotId_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x60060EC")]
		[Cpp2IlInjected.Address(RVA = "0x2120A30", Offset = "0x211F430", VA = "0x182120A30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60060ED")]
		[Cpp2IlInjected.Address(RVA = "0x384F190", Offset = "0x384DB90", VA = "0x18384F190")]
		static ShopSlot()
		{
			Func<ShopSlot> func = default(Func<ShopSlot>);
			_parser = (MessageParser<ShopSlot>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
