using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class StoreContentItem : IMessage<StoreContentItem>, IMessage, IEquatable<StoreContentItem>, IDeepCloneable<StoreContentItem>, IMessageFieldAccessor, IStoreContentType
	{
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private static readonly MessageParser<StoreContentItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public const int QuantityFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private int quantity_;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public const int AvailablePricesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private static readonly FieldCodec<ContentPrice> _repeated_availablePrices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private readonly RepeatedField<ContentPrice> availablePrices_;

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreContentItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x2637250", Offset = "0x2635C50", VA = "0x182637250")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x2636D60", Offset = "0x2635760", VA = "0x182636D60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x26372F0", Offset = "0x2635CF0", VA = "0x1826372F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		[DebuggerNonUserCode]
		public int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return quantity_;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				quantity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		[DebuggerNonUserCode]
		public RepeatedField<ContentPrice> AvailablePrices
		{
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return availablePrices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x2637230", Offset = "0x2635C30", VA = "0x182637230", Slot = "14")]
			get
			{
				int num = item_;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x2637100", Offset = "0x2635B00", VA = "0x182637100", Slot = "15")]
			get
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)item_);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public List<StoreContent.ItemReward> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x2636F50", Offset = "0x2635950", VA = "0x182636F50", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0022
				List<StoreContent.ItemReward> result = (List<StoreContent.ItemReward>)(object)new List<T>();
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)item_);
				int num2 = quantity_;
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public List<ContentPrice> Prices
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x26372B0", Offset = "0x2635CB0", VA = "0x1826372B0", Slot = "17")]
			get
			{
				return (List<ContentPrice>)(object)Enumerable.ToList<ContentPrice>((IEnumerable<>)(object)availablePrices_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x2636E30", Offset = "0x2635830", VA = "0x182636E30", Slot = "19")]
			get
			{
				long num = Convert.ToInt64((uint)item_);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public Item ItemInstance
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x2636EF0", Offset = "0x26358F0", VA = "0x182636EF0")]
			get
			{
				long num = Convert.ToInt64((uint)item_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2636CE0", Offset = "0x26356E0", VA = "0x182636CE0")]
		[DebuggerNonUserCode]
		public StoreContentItem()
		{
			//IL_001c: Expected I4, but got I8
			availablePrices_ = (RepeatedField<ContentPrice>)(object)new RepeatedField<T>();
			base._002Ector();
			quantity_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			quantity_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2636C40", Offset = "0x2635640", VA = "0x182636C40")]
		[DebuggerNonUserCode]
		public StoreContentItem(StoreContentItem other)
		{
			int num = (item_ = other.item_);
			int num2 = (quantity_ = other.quantity_);
			RepeatedField<ContentPrice> repeatedField = (availablePrices_ = (RepeatedField<ContentPrice>)(object)((RepeatedField<T>)(object)other.availablePrices_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2636300", Offset = "0x2634D00", VA = "0x182636300", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreContentItem Clone()
		{
			//Discarded unreachable code: IL_004c
			StoreContentItem storeContentItem = new StoreContentItem();
			int num = (storeContentItem.item_ = item_);
			int num2 = (storeContentItem.quantity_ = quantity_);
			RepeatedField<ContentPrice> repeatedField = (storeContentItem.availablePrices_ = (RepeatedField<ContentPrice>)(object)((RepeatedField<T>)(object)availablePrices_).Clone());
			UnknownFieldSet unknownFieldSet = (storeContentItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeContentItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2636470", Offset = "0x2634E70", VA = "0x182636470", Slot = "0")]
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
				if ((IntPtr)item_ == (IntPtr)typeof(StoreContentItem).TypeHandle && (IntPtr)quantity_ == (IntPtr)typeof(StoreContentItem).TypeHandle)
				{
					RepeatedField<ContentPrice> repeatedField = availablePrices_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x26363D0", Offset = "0x2634DD0", VA = "0x1826363D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreContentItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.item_;
				if (item_ == num)
				{
					int num2 = other.quantity_;
					if (quantity_ == num2)
					{
						RepeatedField<ContentPrice> repeatedField = availablePrices_;
						RepeatedField<ContentPrice> repeatedField2 = other.availablePrices_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x17C3010", Offset = "0x17C1A10", VA = "0x1817C3010", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0032
			if (item_ != 0)
			{
			}
			if (quantity_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)availablePrices_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2636900", Offset = "0x2635300", VA = "0x182636900", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2636960", Offset = "0x2635360", VA = "0x182636960", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			if (item_ != 0)
			{
				int value = item_;
				output.WriteInt32(value);
			}
			if (quantity_ != 0)
			{
				int value2 = quantity_;
				output.WriteInt32(value2);
			}
			RepeatedField<ContentPrice> repeatedField = availablePrices_;
			FieldCodec<ContentPrice> repeated_availablePrices_codec = _repeated_availablePrices_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_availablePrices_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2636140", Offset = "0x2634B40", VA = "0x182636140", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_006e
			int num = item_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = quantity_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			RepeatedField<ContentPrice> repeatedField = availablePrices_;
			FieldCodec<ContentPrice> repeated_availablePrices_codec = _repeated_availablePrices_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_availablePrices_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num6;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2636750", Offset = "0x2635150", VA = "0x182636750", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreContentItem other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				int num = other.item_;
				if (num != 0)
				{
					item_ = num;
				}
				int num2 = other.quantity_;
				if (num2 != 0)
				{
					quantity_ = num2;
				}
				RepeatedField<ContentPrice> repeatedField = availablePrices_;
				RepeatedField<ContentPrice> repeatedField2 = other.availablePrices_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2636630", Offset = "0x2635030", VA = "0x182636630", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0066
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (item_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (quantity_ = input.ReadInt32());
				}
				if (num3 == 26)
				{
					RepeatedField<ContentPrice> repeatedField = availablePrices_;
					FieldCodec<ContentPrice> repeated_availablePrices_codec = _repeated_availablePrices_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_availablePrices_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2636560", Offset = "0x2634F60", VA = "0x182636560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				RepeatedField<ContentPrice> repeatedField = availablePrices_;
			}
			int num2 = item_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x26367E0", Offset = "0x26351E0", VA = "0x1826367E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0020
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num == 1)
				{
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					/*Error: Unexpected end of block*/;
				}
				object obj = default(object);
				quantity_ = (int)obj;
			}
			else
			{
				object obj2 = default(object);
				item_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2636270", Offset = "0x2634C70", VA = "0x182636270", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_002b
			//IL_0020: Expected I4, but got I8
			//IL_002a: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					RepeatedField<ContentPrice> repeatedField = availablePrices_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
				quantity_ = 0;
			}
			else
			{
				item_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2636A70", Offset = "0x2635470", VA = "0x182636A70")]
		static StoreContentItem()
		{
			Func<StoreContentItem> func = default(Func<StoreContentItem>);
			_parser = (MessageParser<StoreContentItem>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ContentPrice> parser = ContentPrice._parser;
			uint num = default(uint);
			_parser = (MessageParser<StoreContentItem>)(object)FieldCodec.ForMessage<ContentPrice>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
