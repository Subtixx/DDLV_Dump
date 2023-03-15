using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000844")]
	public sealed class ItemConditionOneOf : IMessage<ItemConditionOneOf>, IMessage, IEquatable<ItemConditionOneOf>, IDeepCloneable<ItemConditionOneOf>, IMessageFieldAccessor, IMessageOneofAccessor, IItemCondition, IReplaceItemCondition, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000845")]
		public enum ConditionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4002905")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4002906")]
			CommonConditions = 5,
			[Cpp2IlInjected.Token(Token = "0x4002907")]
			SubConditions = 10,
			[Cpp2IlInjected.Token(Token = "0x4002908")]
			Item = 29,
			[Cpp2IlInjected.Token(Token = "0x4002909")]
			Items = 30,
			[Cpp2IlInjected.Token(Token = "0x400290A")]
			Type = 50
		}

		[Cpp2IlInjected.Token(Token = "0x40028FA")]
		private static readonly MessageParser<ItemConditionOneOf> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40028FB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40028FC")]
		public const int CommonConditionsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40028FD")]
		public const int SubConditionsFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x40028FE")]
		public const int ItemFieldNumber = 29;

		[Cpp2IlInjected.Token(Token = "0x40028FF")]
		public const int ItemsFieldNumber = 30;

		[Cpp2IlInjected.Token(Token = "0x4002900")]
		public const int TypeFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002901")]
		private object conditions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002902")]
		private ConditionsOneofCase conditionsCase_;

		[Cpp2IlInjected.Token(Token = "0x1700174D")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemConditionOneOf> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005C6C")]
			[Cpp2IlInjected.Address(RVA = "0x22C7E80", Offset = "0x22C6880", VA = "0x1822C7E80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700174E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C6D")]
			[Cpp2IlInjected.Address(RVA = "0x22C7C60", Offset = "0x22C6660", VA = "0x1822C7C60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700174F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C6E")]
			[Cpp2IlInjected.Address(RVA = "0x22C7FA0", Offset = "0x22C69A0", VA = "0x1822C7FA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001750")]
		[DebuggerNonUserCode]
		public ItemConditionCommon CommonConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6005C72")]
			[Cpp2IlInjected.Address(RVA = "0x22C7BA0", Offset = "0x22C65A0", VA = "0x1822C7BA0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005C73")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001751")]
		[DebuggerNonUserCode]
		public ItemConditionsList SubConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6005C74")]
			[Cpp2IlInjected.Address(RVA = "0x22C7EE0", Offset = "0x22C68E0", VA = "0x1822C7EE0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.SubConditions)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005C75")]
			[Cpp2IlInjected.Address(RVA = "0x1D16FC0", Offset = "0x1D159C0", VA = "0x181D16FC0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001752")]
		[DebuggerNonUserCode]
		public ItemConditionItem Item
		{
			[Cpp2IlInjected.Token(Token = "0x6005C76")]
			[Cpp2IlInjected.Address(RVA = "0x22C7DC0", Offset = "0x22C67C0", VA = "0x1822C7DC0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Item)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005C77")]
			[Cpp2IlInjected.Address(RVA = "0x22C8110", Offset = "0x22C6B10", VA = "0x1822C8110")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001753")]
		[DebuggerNonUserCode]
		public ItemConditionItems Items
		{
			[Cpp2IlInjected.Token(Token = "0x6005C78")]
			[Cpp2IlInjected.Address(RVA = "0x22C7E20", Offset = "0x22C6820", VA = "0x1822C7E20")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Items)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005C79")]
			[Cpp2IlInjected.Address(RVA = "0x2093360", Offset = "0x2091D60", VA = "0x182093360")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001754")]
		[DebuggerNonUserCode]
		public ItemConditionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6005C7A")]
			[Cpp2IlInjected.Address(RVA = "0x22C7F40", Offset = "0x22C6940", VA = "0x1822C7F40")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Type)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005C7B")]
			[Cpp2IlInjected.Address(RVA = "0x2093B00", Offset = "0x2092500", VA = "0x182093B00")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001755")]
		[DebuggerNonUserCode]
		public ConditionsOneofCase ConditionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6005C7C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return conditionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001756")]
		IItemCondition IReplaceItemCondition.ReplaceCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6005C8B")]
			[Cpp2IlInjected.Address(RVA = "0x22C61E0", Offset = "0x22C4BE0", VA = "0x1822C61E0", Slot = "18")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001757")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005C8D")]
			[Cpp2IlInjected.Address(RVA = "0x22C7D30", Offset = "0x22C6730", VA = "0x1822C7D30", Slot = "17")]
			get
			{
				if ((object)typeof(IItemCondition).TypeHandle == null || (object)typeof(IItemCondition).TypeHandle == null)
				{
				}
				return "(None)";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001758")]
		[field: Cpp2IlInjected.Token(Token = "0x4002903")]
		public static ConditionsOneofCase DefaultData
		{
			[Cpp2IlInjected.Token(Token = "0x6005C90")]
			[Cpp2IlInjected.Address(RVA = "0x22C7C00", Offset = "0x22C6600", VA = "0x1822C7C00")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005C91")]
			[Cpp2IlInjected.Address(RVA = "0x22C80B0", Offset = "0x22C6AB0", VA = "0x1822C80B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C6F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemConditionOneOf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005C70")]
		[Cpp2IlInjected.Address(RVA = "0x22C7780", Offset = "0x22C6180", VA = "0x1822C7780")]
		[DebuggerNonUserCode]
		public ItemConditionOneOf(ItemConditionOneOf other)
		{
			//IL_003a: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			//IL_015a: Expected I4, but got O
			//IL_0163: Expected I4, but got O
			//IL_0196: Expected I4, but got O
			ConditionsOneofCase conditionsOneofCase = other.conditionsCase_;
			if (conditionsOneofCase > ConditionsOneofCase.SubConditions)
			{
				if (conditionsOneofCase == ConditionsOneofCase.Item)
				{
					ConditionsOneofCase conditionsOneofCase2 = other.conditionsCase_;
					if (other.conditions_ == null)
					{
						throw new InvalidCastException();
					}
					ItemConditionItem itemConditionItem = new ItemConditionItem();
					itemConditionItem.item_ = (int)itemConditionItem;
					itemConditionItem.inversed_ = (byte)(int)itemConditionItem != 0;
					UnknownFieldSet unknownFields = default(UnknownFieldSet);
					itemConditionItem._unknownFields = unknownFields;
					conditions_ = itemConditionItem;
				}
				if (conditionsOneofCase == ConditionsOneofCase.Items)
				{
					ItemConditionItems items = other.Items;
					ItemConditionItems itemConditionItems = new ItemConditionItems();
					RepeatedField<int> repeatedField = (itemConditionItems.items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)items.items_).Clone());
					bool flag = (itemConditionItems.inversed_ = items.inversed_);
					UnknownFieldSet unknownFieldSet = (itemConditionItems._unknownFields = UnknownFieldSet.Clone(items._unknownFields));
					conditions_ = itemConditionItems;
				}
				if (conditionsOneofCase != ConditionsOneofCase.Type)
				{
					goto IL_0196;
				}
				ItemConditionType type = other.Type;
				ItemConditionType itemConditionType = new ItemConditionType
				{
					subType_ = ""
				};
				ItemType itemType = (itemConditionType.itemType_ = type.itemType_);
				bool flag2 = (itemConditionType.restrictSubType_ = type.restrictSubType_);
				string text = (itemConditionType.subType_ = type.subType_);
				bool flag3 = (itemConditionType.inversed_ = type.inversed_);
				UnknownFieldSet unknownFieldSet2 = (itemConditionType._unknownFields = UnknownFieldSet.Clone(type._unknownFields));
				conditions_ = itemConditionType;
			}
			if (conditionsOneofCase == ConditionsOneofCase.CommonConditions)
			{
				ConditionsOneofCase conditionsOneofCase3 = other.conditionsCase_;
				if (other.conditions_ == null)
				{
					throw new InvalidCastException();
				}
				ItemConditionCommon itemConditionCommon = new ItemConditionCommon();
				itemConditionCommon.condition_ = (int)itemConditionCommon;
				itemConditionCommon.inversed_ = (byte)(int)itemConditionCommon != 0;
				UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
				itemConditionCommon._unknownFields = unknownFields2;
				conditions_ = itemConditionCommon;
			}
			if (conditionsOneofCase == ConditionsOneofCase.SubConditions)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = other.SubConditions.Clone());
			}
			goto IL_0196;
			IL_0196:
			UnknownFieldSet unknownFieldSet3 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C71")]
		[Cpp2IlInjected.Address(RVA = "0x22C6080", Offset = "0x22C4A80", VA = "0x1822C6080", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemConditionOneOf Clone()
		{
			return new ItemConditionOneOf(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C7D")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearConditions()
		{
			//IL_0010: Expected O, but got I4
			conditions_ = (conditionsCase_ = ConditionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C7E")]
		[Cpp2IlInjected.Address(RVA = "0x22C6220", Offset = "0x22C4C20", VA = "0x1822C6220", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ItemConditionOneOf)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C7F")]
		[Cpp2IlInjected.Address(RVA = "0x22C6280", Offset = "0x22C4C80", VA = "0x1822C6280", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemConditionOneOf other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
						goto IL_00f6;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					obj2 = other.conditions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ItemConditionsList subConditions = SubConditions;
					ItemConditionsList subConditions2 = other.SubConditions;
					if (object.Equals(subConditions, subConditions2))
					{
						ItemConditionItem item = Item;
						ItemConditionItem item2 = other.Item;
						if (object.Equals(item, item2))
						{
							ItemConditionItems items = Items;
							ItemConditionItems items2 = other.Items;
							if (object.Equals(items, items2))
							{
								ItemConditionType type = Type;
								ItemConditionType type2 = other.Type;
								if (object.Equals(type, type2))
								{
									ConditionsOneofCase conditionsOneofCase = other.conditionsCase_;
									if (conditionsCase_ == conditionsOneofCase)
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										bool flag = object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00f6;
			IL_00f6:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C80")]
		[Cpp2IlInjected.Address(RVA = "0x22C6620", Offset = "0x22C5020", VA = "0x1822C6620", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00bb
			while (true)
			{
				ConditionsOneofCase conditionsOneofCase = conditionsCase_;
				int num = 0;
				if (conditionsOneofCase == ConditionsOneofCase.CommonConditions)
				{
					object obj = conditions_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (conditionsOneofCase != ConditionsOneofCase.SubConditions)
				{
					continue;
				}
				object obj2 = conditions_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (conditionsCase_ != ConditionsOneofCase.Item)
					{
						continue;
					}
					object obj3 = conditions_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (conditionsCase_ != ConditionsOneofCase.Items)
						{
							continue;
						}
						object obj4 = conditions_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (conditionsCase_ == ConditionsOneofCase.Type)
							{
								object obj5 = conditions_;
								if (obj5 == null)
								{
									break;
								}
								int hashCode5 = obj5.GetHashCode();
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode6 = unknownFields.GetHashCode();
							}
							return 1;
						}
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C81")]
		[Cpp2IlInjected.Address(RVA = "0x22C7380", Offset = "0x22C5D80", VA = "0x1822C7380", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C82")]
		[Cpp2IlInjected.Address(RVA = "0x22C73E0", Offset = "0x22C5DE0", VA = "0x1822C73E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00de
			//IL_002f: Expected O, but got I4
			while (true)
			{
				ConditionsOneofCase conditionsOneofCase = conditionsCase_;
				int num = 0;
				if (conditionsOneofCase == ConditionsOneofCase.CommonConditions)
				{
					if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
					{
						object obj = conditions_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (conditionsOneofCase != ConditionsOneofCase.SubConditions)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.SubConditions)
				{
					object obj2 = conditions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.Item)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.Item)
				{
					object obj3 = conditions_;
					if (obj3 != null && obj3 == null)
					{
						break;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.Items)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.Items)
				{
					object obj4 = conditions_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (conditionsCase_ == ConditionsOneofCase.Type && conditionsCase_ == ConditionsOneofCase.Type)
				{
					object obj5 = conditions_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C83")]
		[Cpp2IlInjected.Address(RVA = "0x22C5CF0", Offset = "0x22C46F0", VA = "0x1822C5CF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
			{
				if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (conditionsCase_ == ConditionsOneofCase.SubConditions)
			{
				if (conditionsCase_ != ConditionsOneofCase.SubConditions)
				{
				}
				object obj2 = conditions_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (conditionsCase_ == ConditionsOneofCase.Item)
			{
				if (conditionsCase_ != ConditionsOneofCase.Item)
				{
				}
				object obj3 = conditions_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num4 = default(int);
				num += num4;
			}
			if (conditionsCase_ == ConditionsOneofCase.Items)
			{
				if (conditionsCase_ != ConditionsOneofCase.Items)
				{
				}
				object obj4 = conditions_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num5 = default(int);
				num += num5;
			}
			if (conditionsCase_ == ConditionsOneofCase.Type)
			{
				if (conditionsCase_ == ConditionsOneofCase.Type)
				{
					object obj5 = conditions_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num6 = default(int);
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C84")]
		[Cpp2IlInjected.Address(RVA = "0x22C6950", Offset = "0x22C5350", VA = "0x1822C6950", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemConditionOneOf other)
		{
			//IL_0038: Expected I4, but got O
			//IL_006b: Expected I4, but got O
			//IL_00c9: Expected I4, but got O
			//IL_010c: Expected I4, but got O
			//IL_0199: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			ConditionsOneofCase conditionsOneofCase = other.conditionsCase_;
			ItemConditionType type2 = default(ItemConditionType);
			if (conditionsOneofCase > ConditionsOneofCase.SubConditions)
			{
				if (conditionsOneofCase == ConditionsOneofCase.Item)
				{
					if (Item == null)
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ItemConditionItem());
					}
					ItemConditionItem item = Item;
					ItemConditionItem item2 = other.Item;
				}
				if (conditionsOneofCase == ConditionsOneofCase.Items)
				{
					if (Items == null)
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ItemConditionItems());
					}
					ItemConditionItems items = Items;
					ItemConditionItems items2 = other.Items;
					items.MergeFrom(items2);
					UnknownFieldSet unknownFields = other._unknownFields;
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
					return;
				}
				while (conditionsOneofCase != ConditionsOneofCase.Type)
				{
				}
				if (Type == null)
				{
					conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ItemConditionType());
				}
				ItemConditionType type = Type;
				type2 = other.Type;
				type.MergeFrom(type2);
			}
			UnknownFieldSet unknownFieldSet2 = default(UnknownFieldSet);
			if ((long)type2 == 5)
			{
				if (CommonConditions == null)
				{
					conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ItemConditionCommon());
				}
				ItemConditionCommon commonConditions = CommonConditions;
				ItemConditionCommon commonConditions2 = other.CommonConditions;
				while (commonConditions2 == null)
				{
				}
				int condition_ = commonConditions2.condition_;
				if (condition_ != 0)
				{
					commonConditions.condition_ = condition_;
				}
				bool inversed_ = commonConditions2.inversed_;
				if (inversed_)
				{
					commonConditions.inversed_ = inversed_;
				}
				UnknownFieldSet unknownFields2 = commonConditions2._unknownFields;
				unknownFieldSet2 = (commonConditions._unknownFields = UnknownFieldSet.MergeFrom(commonConditions._unknownFields, unknownFields2));
			}
			while ((long)unknownFieldSet2 != 10)
			{
			}
			if (SubConditions == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ItemConditionsList());
			}
			ItemConditionsList subConditions = SubConditions;
			ItemConditionsList subConditions2 = other.SubConditions;
			subConditions.MergeFrom(subConditions2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C85")]
		[Cpp2IlInjected.Address(RVA = "0x22C6C80", Offset = "0x22C5680", VA = "0x1822C6C80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0067: Expected I4, but got O
			//IL_007a: Expected I4, but got O
			//IL_009e: Expected I4, but got O
			//IL_00f2: Expected I4, but got O
			//IL_014e: Expected I4, but got O
			//IL_019e: Expected I4, but got O
			//IL_01b2: Expected I4, but got O
			//IL_01dc: Expected I4, but got O
			//IL_022c: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 82)
			{
				if (num == 234)
				{
					ItemConditionItem itemConditionItem = new ItemConditionItem();
					if (conditionsCase_ == ConditionsOneofCase.Item)
					{
						if (conditionsCase_ != ConditionsOneofCase.Item)
						{
						}
						object obj = conditions_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
						if (obj != null)
						{
							if ((object)typeof(ItemConditionItem).TypeHandle != null)
							{
								itemConditionItem.item_ = (int)typeof(ItemConditionItem).TypeHandle;
							}
							if ((object)typeof(ItemConditionItem).TypeHandle != null)
							{
								itemConditionItem.inversed_ = (byte)(int)typeof(ItemConditionItem).TypeHandle != 0;
							}
							UnknownFieldSet unknownFields = itemConditionItem._unknownFields;
							UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
							itemConditionItem._unknownFields = unknownFields2;
						}
					}
					input.ReadMessage(itemConditionItem);
					conditions_ = itemConditionItem;
					conditionsCase_ = (ConditionsOneofCase)itemConditionItem;
				}
				if (num == 242)
				{
					ItemConditionItems builder = new ItemConditionItems();
					if (conditionsCase_ == ConditionsOneofCase.Items)
					{
						if (conditionsCase_ != ConditionsOneofCase.Items)
						{
						}
						object obj2 = conditions_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					conditions_ = builder;
					conditionsCase_ = (ConditionsOneofCase)typeof(ItemConditionItems).TypeHandle;
				}
				if ((long)typeof(ItemConditionItems).TypeHandle != 402)
				{
					goto IL_022c;
				}
				ItemConditionType builder2 = new ItemConditionType();
				if (conditionsCase_ == ConditionsOneofCase.Type)
				{
					if (conditionsCase_ != ConditionsOneofCase.Type)
					{
					}
					object obj3 = conditions_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				conditions_ = builder2;
				conditionsCase_ = (ConditionsOneofCase)typeof(ItemConditionType).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
			if (num == 42)
			{
				ItemConditionCommon itemConditionCommon = new ItemConditionCommon();
				if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					if (conditionsCase_ != ConditionsOneofCase.CommonConditions)
					{
					}
					object obj4 = conditions_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
					if (obj4 != null)
					{
						if ((object)typeof(ItemConditionCommon).TypeHandle != null)
						{
							itemConditionCommon.condition_ = (int)typeof(ItemConditionCommon).TypeHandle;
						}
						if ((object)typeof(ItemConditionCommon).TypeHandle != null)
						{
							itemConditionCommon.inversed_ = (byte)(int)typeof(ItemConditionCommon).TypeHandle != 0;
						}
						UnknownFieldSet unknownFields3 = itemConditionCommon._unknownFields;
						itemConditionCommon._unknownFields = unknownFieldSet;
					}
				}
				input.ReadMessage(itemConditionCommon);
				conditions_ = itemConditionCommon;
				conditionsCase_ = (ConditionsOneofCase)unknownFieldSet;
			}
			if ((long)unknownFieldSet == 82)
			{
				ItemConditionsList builder3 = new ItemConditionsList();
				if (conditionsCase_ == ConditionsOneofCase.SubConditions)
				{
					if (conditionsCase_ != ConditionsOneofCase.SubConditions)
					{
					}
					object obj5 = conditions_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				conditions_ = builder3;
				conditionsCase_ = (ConditionsOneofCase)typeof(ItemConditionsList).TypeHandle;
			}
			goto IL_022c;
			IL_022c:
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005C86")]
		[Cpp2IlInjected.Address(RVA = "0x22C64D0", Offset = "0x22C4ED0", VA = "0x1822C64D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 10)
			{
				if (fieldNumber != 29)
				{
					goto IL_0023;
				}
				if (conditionsCase_ == ConditionsOneofCase.Item)
				{
					object obj = conditions_;
					if (obj != null)
					{
						if (obj != null)
						{
							goto IL_0023;
						}
						goto IL_0073;
					}
				}
				goto IL_002f;
			}
			goto IL_003b;
			IL_0062:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0073;
			IL_002f:
			if (fieldNumber == 50)
			{
				ItemConditionType type = Type;
				goto IL_003b;
			}
			goto IL_0062;
			IL_0073:
			throw new InvalidCastException();
			IL_003b:
			if (fieldNumber == 5)
			{
				while (conditionsCase_ != ConditionsOneofCase.CommonConditions)
				{
				}
				object obj2 = conditions_;
				while (obj2 == null)
				{
				}
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if ((long)typeof(ItemConditionCommon).TypeHandle != 10)
			{
			}
			goto IL_0062;
			IL_0023:
			if (fieldNumber == 30)
			{
				ItemConditionItems items = Items;
			}
			goto IL_002f;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C87")]
		[Cpp2IlInjected.Address(RVA = "0x22C7160", Offset = "0x22C5B60", VA = "0x1822C7160", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001e: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			//IL_0049: Expected I4, but got O
			//IL_0078: Expected I4, but got O
			if (fieldNumber > 10)
			{
				switch (fieldNumber)
				{
				case 29:
				{
					int num = 0;
					if (value == null || value != null)
					{
						conditions_ = num;
						conditionsCase_ = (ConditionsOneofCase)typeof(ItemConditionsList).TypeHandle;
						break;
					}
					throw new InvalidCastException();
				}
				case 30:
					if (value == null || value != null)
					{
						conditions_ = value;
						conditionsCase_ = (ConditionsOneofCase)typeof(ItemConditionsList).TypeHandle;
						break;
					}
					throw new InvalidCastException();
				default:
					if (value == null || value != null)
					{
						conditions_ = value;
						break;
					}
					throw new InvalidCastException();
				}
			}
			else if (fieldNumber == 5)
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				conditions_ = value;
				conditionsCase_ = (ConditionsOneofCase)typeof(ItemConditionsList).TypeHandle;
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C88")]
		[Cpp2IlInjected.Address(RVA = "0x22C5FC0", Offset = "0x22C49C0", VA = "0x1822C5FC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0021: Expected O, but got I4
			switch (fieldNumber)
			{
			default:
				if (fieldNumber != 5 && fieldNumber != 10)
				{
					break;
				}
				goto case 29;
			case 29:
			case 30:
			{
				int num = 0;
				conditions_ = num;
				conditionsCase_ = (ConditionsOneofCase)num;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C89")]
		[Cpp2IlInjected.Address(RVA = "0x22C68A0", Offset = "0x22C52A0", VA = "0x1822C68A0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Conditions"))
			{
				ConditionsOneofCase conditionsOneofCase = conditionsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C8A")]
		[Cpp2IlInjected.Address(RVA = "0x22C6010", Offset = "0x22C4A10", VA = "0x1822C6010", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Conditions"))
			{
				conditions_ = (conditionsCase_ = ConditionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C8C")]
		[Cpp2IlInjected.Address(RVA = "0x22C6440", Offset = "0x22C4E40", VA = "0x1822C6440", Slot = "16")]
		public bool Evaluate(Item target)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IItemCondition).TypeHandle != null)
			{
			}
			return (byte)(int)typeof(IItemCondition).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C8E")]
		[Cpp2IlInjected.Address(RVA = "0x22C61E0", Offset = "0x22C4BE0", VA = "0x1822C61E0")]
		public IItemCondition GetOneOfCondition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005C8F")]
		[Cpp2IlInjected.Address(RVA = "0x22C60E0", Offset = "0x22C4AE0", VA = "0x1822C60E0", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0035
			switch (conditionsCase_)
			{
			case ConditionsOneofCase.SubConditions:
				if (conditions_ != null)
				{
					bool flag = default(bool);
					if (!flag)
					{
						context.AddError("Please enter sub-conditions or remove it");
					}
					break;
				}
				throw new InvalidCastException();
			case ConditionsOneofCase.None:
				context.AddError("Please don't leave condition at None");
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C92")]
		[Cpp2IlInjected.Address(RVA = "0x22C7670", Offset = "0x22C6070", VA = "0x1822C7670")]
		static ItemConditionOneOf()
		{
			Func<ItemConditionOneOf> func = default(Func<ItemConditionOneOf>);
			_parser = (MessageParser<ItemConditionOneOf>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
