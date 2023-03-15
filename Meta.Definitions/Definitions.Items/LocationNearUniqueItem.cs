using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000459")]
	public sealed class LocationNearUniqueItem : IMessage<LocationNearUniqueItem>, IMessage, IEquatable<LocationNearUniqueItem>, IDeepCloneable<LocationNearUniqueItem>, IMessageFieldAccessor, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x400179A")]
		private static readonly MessageParser<LocationNearUniqueItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400179B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400179C")]
		public const int ItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400179D")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x400179E")]
		public const int SceneIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400179F")]
		private int sceneID_;

		[Cpp2IlInjected.Token(Token = "0x17000D9F")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationNearUniqueItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003566")]
			[Cpp2IlInjected.Address(RVA = "0x38EB150", Offset = "0x38E9B50", VA = "0x1838EB150")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003567")]
			[Cpp2IlInjected.Address(RVA = "0x38EB020", Offset = "0x38E9A20", VA = "0x1838EB020")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003568")]
			[Cpp2IlInjected.Address(RVA = "0x38EB210", Offset = "0x38E9C10", VA = "0x1838EB210", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA2")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600356C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600356D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA3")]
		[DebuggerNonUserCode]
		public int SceneID
		{
			[Cpp2IlInjected.Token(Token = "0x600356E")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return sceneID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600356F")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				sceneID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA4")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600357B")]
			[Cpp2IlInjected.Address(RVA = "0x38EB0F0", Offset = "0x38E9AF0", VA = "0x1838EB0F0")]
			get
			{
				long num = Convert.ToInt64((uint)itemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA5")]
		public Item SceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x600357C")]
			[Cpp2IlInjected.Address(RVA = "0x38EB1B0", Offset = "0x38E9BB0", VA = "0x1838EB1B0")]
			get
			{
				long num = Convert.ToInt64((uint)sceneID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003569")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationNearUniqueItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600356A")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public LocationNearUniqueItem(LocationNearUniqueItem other)
		{
			int num = (itemID_ = other.itemID_);
			int num2 = (sceneID_ = other.sceneID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600356B")]
		[Cpp2IlInjected.Address(RVA = "0x38EA890", Offset = "0x38E9290", VA = "0x1838EA890", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationNearUniqueItem Clone()
		{
			//Discarded unreachable code: IL_0037
			LocationNearUniqueItem locationNearUniqueItem = new LocationNearUniqueItem();
			int num = (locationNearUniqueItem.itemID_ = itemID_);
			int num2 = (locationNearUniqueItem.sceneID_ = sceneID_);
			UnknownFieldSet unknownFieldSet = (locationNearUniqueItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationNearUniqueItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6003570")]
		[Cpp2IlInjected.Address(RVA = "0x38EA930", Offset = "0x38E9330", VA = "0x1838EA930", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)itemID_ == (IntPtr)typeof(LocationNearUniqueItem).TypeHandle && (IntPtr)sceneID_ == (IntPtr)typeof(LocationNearUniqueItem).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003571")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationNearUniqueItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.itemID_;
				if (itemID_ == num)
				{
					int num2 = other.sceneID_;
					if (sceneID_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003572")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (itemID_ != 0)
				{
				}
				if (sceneID_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003573")]
		[Cpp2IlInjected.Address(RVA = "0x38EAEB0", Offset = "0x38E98B0", VA = "0x1838EAEB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003574")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (itemID_ != 0)
			{
				int value = itemID_;
				output.WriteInt32(value);
			}
			if (sceneID_ != 0)
			{
				int value2 = sceneID_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003575")]
		[Cpp2IlInjected.Address(RVA = "0x38EA7C0", Offset = "0x38E91C0", VA = "0x1838EA7C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = itemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = sceneID_;
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

		[Cpp2IlInjected.Token(Token = "0x6003576")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationNearUniqueItem other)
		{
			if (other != null)
			{
				int num = other.itemID_;
				if (num != 0)
				{
					itemID_ = num;
				}
				int num2 = other.sceneID_;
				if (num2 != 0)
				{
					sceneID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003577")]
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
					int num2 = (itemID_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (sceneID_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003578")]
		[Cpp2IlInjected.Address(RVA = "0x38EA9C0", Offset = "0x38E93C0", VA = "0x1838EA9C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = itemID_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003579")]
		[Cpp2IlInjected.Address(RVA = "0x38EADF0", Offset = "0x38E97F0", VA = "0x1838EADF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				itemID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			sceneID_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x600357A")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				itemID_ = 0;
				break;
			case 2:
				sceneID_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600357D")]
		[Cpp2IlInjected.Address(RVA = "0x38EAB90", Offset = "0x38E9590", VA = "0x1838EAB90")]
		public static bool IsValidUniqueItem(Item item)
		{
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				int num2 = 0;
			}
			if (num == 0)
			{
			}
			if (flag)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
					while (!flag)
					{
					}
					while (!flag)
					{
					}
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					num += num;
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600357E")]
		[Cpp2IlInjected.Address(RVA = "0x38EAA80", Offset = "0x38E9480", VA = "0x1838EAA80")]
		private static bool IsUniqueItem(IItemData data)
		{
			if (!data.IsMissionItem())
			{
				if (data != null)
				{
					int num = 0;
					if (data != null)
					{
						uint num2 = default(uint);
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						bool result = default(bool);
						return result;
					}
				}
				int num3 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600357F")]
		[Cpp2IlInjected.Address(RVA = "0x38EA920", Offset = "0x38E9320", VA = "0x1838EA920", Slot = "14")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_000d: Expected I4, but got I8
			sceneID_ = 1540000000;
		}

		[Cpp2IlInjected.Token(Token = "0x6003580")]
		[Cpp2IlInjected.Address(RVA = "0x38EAF10", Offset = "0x38E9910", VA = "0x1838EAF10")]
		static LocationNearUniqueItem()
		{
			Func<LocationNearUniqueItem> func = default(Func<LocationNearUniqueItem>);
			_parser = (MessageParser<LocationNearUniqueItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
