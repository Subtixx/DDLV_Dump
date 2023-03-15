using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000618")]
	public sealed class ItemTypeSelector : IMessage<ItemTypeSelector>, IMessage, IEquatable<ItemTypeSelector>, IDeepCloneable<ItemTypeSelector>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400219E")]
		private static readonly MessageParser<ItemTypeSelector> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400219F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40021A0")]
		public const int ItemTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40021A1")]
		private ItemType itemType_;

		[Cpp2IlInjected.Token(Token = "0x40021A2")]
		public const int RestrictSubTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40021A3")]
		private bool restrictSubType_;

		[Cpp2IlInjected.Token(Token = "0x40021A4")]
		public const int SubTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40021A5")]
		private string subType_ = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40021A6")]
		private GenericEnum _subTypeEnum;

		[Cpp2IlInjected.Token(Token = "0x170012D1")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemTypeSelector> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600490D")]
			[Cpp2IlInjected.Address(RVA = "0x6485F0", Offset = "0x646FF0", VA = "0x1806485F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600490E")]
			[Cpp2IlInjected.Address(RVA = "0x648520", Offset = "0x646F20", VA = "0x180648520")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600490F")]
			[Cpp2IlInjected.Address(RVA = "0x6487D0", Offset = "0x6471D0", VA = "0x1806487D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D4")]
		[DebuggerNonUserCode]
		public ItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6004913")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004914")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D5")]
		[DebuggerNonUserCode]
		public bool RestrictSubType
		{
			[Cpp2IlInjected.Token(Token = "0x6004915")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return restrictSubType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004916")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				restrictSubType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D6")]
		[DebuggerNonUserCode]
		public string SubType
		{
			[Cpp2IlInjected.Token(Token = "0x6004917")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return subType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004918")]
			[Cpp2IlInjected.Address(RVA = "0x6488E0", Offset = "0x6472E0", VA = "0x1806488E0")]
			set
			{
				string text = (subType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D7")]
		public GenericEnum SubTypeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x6004924")]
			[Cpp2IlInjected.Address(RVA = "0x648650", Offset = "0x647050", VA = "0x180648650")]
			get
			{
				//IL_0020: Expected O, but got I4
				bool flag = default(bool);
				if ((long)"{il2cpp array field il2cppMethodInfo->}" != 0 && !flag && !flag)
				{
					int num = 0;
					ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
					object obj = Enum.Parse(itemTypeMetaInfo.SubTypeEnumType, (string)num);
					if (obj == null)
					{
					}
					int num2 = 0;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004910")]
		[Cpp2IlInjected.Address(RVA = "0x6484D0", Offset = "0x646ED0", VA = "0x1806484D0")]
		[DebuggerNonUserCode]
		public ItemTypeSelector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004911")]
		[Cpp2IlInjected.Address(RVA = "0x648420", Offset = "0x646E20", VA = "0x180648420")]
		[DebuggerNonUserCode]
		public ItemTypeSelector(ItemTypeSelector other)
		{
			ItemType itemType = (itemType_ = other.itemType_);
			bool flag = (restrictSubType_ = other.restrictSubType_);
			string text = (subType_ = other.subType_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004912")]
		[Cpp2IlInjected.Address(RVA = "0x647510", Offset = "0x645F10", VA = "0x180647510", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemTypeSelector Clone()
		{
			//Discarded unreachable code: IL_0052
			ItemTypeSelector itemTypeSelector = new ItemTypeSelector();
			itemTypeSelector.subType_ = "";
			ItemType itemType = (itemTypeSelector.itemType_ = itemType_);
			bool flag = (itemTypeSelector.restrictSubType_ = restrictSubType_);
			string text = (itemTypeSelector.subType_ = subType_);
			UnknownFieldSet unknownFieldSet = (itemTypeSelector._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemTypeSelector;
		}

		[Cpp2IlInjected.Token(Token = "0x6004919")]
		[Cpp2IlInjected.Address(RVA = "0x647660", Offset = "0x646060", VA = "0x180647660", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)itemType_ == (IntPtr)typeof(ItemTypeSelector).TypeHandle && (IntPtr)(restrictSubType_ ? 1 : 0) == (IntPtr)typeof(ItemTypeSelector).TypeHandle)
				{
					string text = subType_;
					bool flag = default(bool);
					if (!flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600491A")]
		[Cpp2IlInjected.Address(RVA = "0x6475E0", Offset = "0x645FE0", VA = "0x1806475E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemTypeSelector other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemType itemType = other.itemType_;
				if (itemType_ == itemType)
				{
					bool flag = other.restrictSubType_;
					if (restrictSubType_ == flag)
					{
						string text = other.subType_;
						if (!(subType_ != text))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600491B")]
		[Cpp2IlInjected.Address(RVA = "0x647E70", Offset = "0x646870", VA = "0x180647E70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0042
			if (itemType_ != 0)
			{
			}
			if (restrictSubType_)
			{
			}
			string text = subType_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600491C")]
		[Cpp2IlInjected.Address(RVA = "0x648170", Offset = "0x646B70", VA = "0x180648170", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600491D")]
		[Cpp2IlInjected.Address(RVA = "0x648250", Offset = "0x646C50", VA = "0x180648250", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004f
			if (itemType_ != 0)
			{
			}
			if (restrictSubType_)
			{
				bool value = restrictSubType_;
				output.WriteBool(value);
			}
			if (subType_.m_stringLength != 0)
			{
				string value2 = subType_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600491E")]
		[Cpp2IlInjected.Address(RVA = "0x6473C0", Offset = "0x645DC0", VA = "0x1806473C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0058
			ItemType itemType = itemType_;
			int num = 0;
			if (itemType != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)itemType);
				num2++;
			}
			string text = subType_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
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

		[Cpp2IlInjected.Token(Token = "0x600491F")]
		[Cpp2IlInjected.Address(RVA = "0x647FD0", Offset = "0x6469D0", VA = "0x180647FD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemTypeSelector other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				ItemType itemType = other.itemType_;
				if (itemType != 0)
				{
					itemType_ = itemType;
				}
				bool flag = other.restrictSubType_;
				if (flag)
				{
					restrictSubType_ = flag;
				}
				string text = other.subType_;
				if (text.m_stringLength != 0)
				{
					SubType = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004920")]
		[Cpp2IlInjected.Address(RVA = "0x647F20", Offset = "0x646920", VA = "0x180647F20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(itemType_ = (ItemType)input.ReadInt32());
				}
				bool flag = default(bool);
				if (num == 16)
				{
					flag = (restrictSubType_ = input.ReadBool());
				}
				if (flag)
				{
					string text2 = (SubType = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004921")]
		[Cpp2IlInjected.Address(RVA = "0x647D70", Offset = "0x646770", VA = "0x180647D70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					string text = subType_;
				}
				bool flag = restrictSubType_;
			}
			ItemType itemType = itemType_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004922")]
		[Cpp2IlInjected.Address(RVA = "0x648050", Offset = "0x646A50", VA = "0x180648050", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0032
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_0031: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						SubType = (string)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
				{
					object obj = default(object);
					restrictSubType_ = (byte)(int)obj != 0;
					break;
				}
				}
			}
			else
			{
				object obj2 = default(object);
				itemType_ = (ItemType)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004923")]
		[Cpp2IlInjected.Address(RVA = "0x647490", Offset = "0x645E90", VA = "0x180647490", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_002d: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					SubType = "";
					break;
				case 0:
					restrictSubType_ = false;
					break;
				}
			}
			else
			{
				itemType_ = ItemType.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004925")]
		[Cpp2IlInjected.Address(RVA = "0x647720", Offset = "0x646120", VA = "0x180647720")]
		public IEnumerable<Item> FilterItems(IEnumerable<Item> items)
		{
			if (itemType_ != 0)
			{
				Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)((Item x) => Filter(x));
				return (IEnumerable<Item>)Enumerable.Where<Item>((IEnumerable<>)items, (Func<, >)(object)func);
			}
			return items;
		}

		[Cpp2IlInjected.Token(Token = "0x6004926")]
		[Cpp2IlInjected.Address(RVA = "0x6477E0", Offset = "0x6461E0", VA = "0x1806477E0")]
		public IEnumerable<IItemData> FilterItems(IEnumerable<IItemData> itemsData)
		{
			if (itemType_ != 0)
			{
				bool result = default(bool);
				Func<IItemData, bool> func = (Func<IItemData, bool>)(object)(Func<T, TResult>)((IItemData x) => result);
				return (IEnumerable<IItemData>)Enumerable.Where<IItemData>((IEnumerable<>)itemsData, (Func<, >)(object)func);
			}
			return itemsData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004927")]
		[Cpp2IlInjected.Address(RVA = "0x6479B0", Offset = "0x6463B0", VA = "0x1806479B0")]
		public bool Filter(Item item)
		{
			int itemID = item.ItemID;
			bool flag = restrictSubType_;
			ItemType itemType = itemType_;
			bool flag2 = default(bool);
			if (restrictSubType_ && !flag2)
			{
				string text = subType_;
				if (!flag2)
				{
					int num = (int)itemType_;
					ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
					Type _003CSubTypeEnumType_003Ek__BackingField = itemTypeMetaInfo.SubTypeEnumType;
					string value = subType_;
					object obj = Enum.Parse(_003CSubTypeEnumType_003Ek__BackingField, value);
					if (obj == null)
					{
					}
					int num2 = 0;
					if (obj == null)
					{
						goto IL_0080;
					}
				}
			}
			GenericEnum subTypeEnum = _subTypeEnum;
			ItemType itemType2 = default(ItemType);
			if (itemType2 == itemType)
			{
				if (!flag)
				{
				}
				ItemType itemType3 = default(ItemType);
				int num3 = (int)itemType3;
				ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo2 = default(ItemDatabase.ItemTypeMetaInfo);
				ItemDatabase.ItemTypeMetaInfo.GetSubTypeDelegate _003CGetSubType_003Ek__BackingField = itemTypeMetaInfo2.GetSubType;
			}
			int num4 = 0;
			goto IL_0080;
			IL_0080:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004928")]
		[Cpp2IlInjected.Address(RVA = "0x647C60", Offset = "0x646660", VA = "0x180647C60")]
		public static bool Filter(Item item, ItemType filterType, bool restrictSubType, GenericEnum subType)
		{
			ItemType itemType = default(ItemType);
			if (itemType == filterType)
			{
				if (!restrictSubType)
				{
					return true;
				}
				ItemType itemType2 = default(ItemType);
				int num = (int)itemType2;
				ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
				ItemDatabase.ItemTypeMetaInfo.GetSubTypeDelegate _003CGetSubType_003Ek__BackingField = itemTypeMetaInfo.GetSubType;
				bool result = default(bool);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004929")]
		[Cpp2IlInjected.Address(RVA = "0x6478A0", Offset = "0x6462A0", VA = "0x1806478A0")]
		public static bool Filter(Item item, ItemType filterType, bool restrictSubType, string subType)
		{
			ItemType itemType = default(ItemType);
			if (itemType == filterType)
			{
				if (!restrictSubType)
				{
					return true;
				}
				ItemType itemType2 = default(ItemType);
				int num = (int)itemType2;
				ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
				ItemDatabase.ItemTypeMetaInfo.GetSubTypeDelegate _003CGetSubType_003Ek__BackingField = itemTypeMetaInfo.GetSubType;
				string b = default(string);
				return string.Equals(subType, b);
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600492A")]
		[Cpp2IlInjected.Address(RVA = "0x648310", Offset = "0x646D10", VA = "0x180648310")]
		static ItemTypeSelector()
		{
			Func<ItemTypeSelector> func = default(Func<ItemTypeSelector>);
			_parser = (MessageParser<ItemTypeSelector>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
