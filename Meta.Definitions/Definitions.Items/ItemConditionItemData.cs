using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000582")]
	public sealed class ItemConditionItemData : IMessage<ItemConditionItemData>, IMessage, IEquatable<ItemConditionItemData>, IDeepCloneable<ItemConditionItemData>, IMessageFieldAccessor, IItemData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001DCA")]
		private static readonly MessageParser<ItemConditionItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001DCB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001DCC")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DCD")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001DCE")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DCF")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DD0")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DD1")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DD2")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DD3")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DD4")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DD5")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DD6")]
		public const int ConditionsFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DD7")]
		private ItemConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x170011A5")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemConditionItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600447B")]
			[Cpp2IlInjected.Address(RVA = "0x22C42A0", Offset = "0x22C2CA0", VA = "0x1822C42A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600447C")]
			[Cpp2IlInjected.Address(RVA = "0x22C4170", Offset = "0x22C2B70", VA = "0x1822C4170")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600447D")]
			[Cpp2IlInjected.Address(RVA = "0x22C4300", Offset = "0x22C2D00", VA = "0x1822C4300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A8")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004482")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004483")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A9")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004484")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004485")]
			[Cpp2IlInjected.Address(RVA = "0x22C44F0", Offset = "0x22C2EF0", VA = "0x1822C44F0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011AA")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004486")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004487")]
			[Cpp2IlInjected.Address(RVA = "0x22C4410", Offset = "0x22C2E10", VA = "0x1822C4410")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011AB")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004488")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004489")]
			[Cpp2IlInjected.Address(RVA = "0x22C4480", Offset = "0x22C2E80", VA = "0x1822C4480")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011AC")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600448A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600448B")]
			[Cpp2IlInjected.Address(RVA = "0x22C4560", Offset = "0x22C2F60", VA = "0x1822C4560")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011AD")]
		[DebuggerNonUserCode]
		public ItemConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x600448C")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x600448D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011AE")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004499")]
			[Cpp2IlInjected.Address(RVA = "0x22C4240", Offset = "0x22C2C40", VA = "0x1822C4240", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600447E")]
		[Cpp2IlInjected.Address(RVA = "0x22C3F10", Offset = "0x22C2910", VA = "0x1822C3F10")]
		[DebuggerNonUserCode]
		public ItemConditionItemData()
		{
			ItemConditionsList itemConditionsList = (conditions_ = new ItemConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600447F")]
		[Cpp2IlInjected.Address(RVA = "0x22C3B20", Offset = "0x22C2520", VA = "0x1822C3B20")]
		private void OnConstruction()
		{
			ItemConditionsList itemConditionsList = (conditions_ = new ItemConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004480")]
		[Cpp2IlInjected.Address(RVA = "0x22C3FE0", Offset = "0x22C29E0", VA = "0x1822C3FE0")]
		[DebuggerNonUserCode]
		public ItemConditionItemData(ItemConditionItemData other)
		{
			//IL_00aa: Expected O, but got I4
			ItemConditionsList itemConditionsList = (conditions_ = new ItemConditionsList());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			ItemConditionsList itemConditionsList2 = other.conditions_;
			if (itemConditionsList2 != null)
			{
				ItemConditionsList itemConditionsList3 = itemConditionsList2.Clone();
			}
			int num2 = 0;
			conditions_ = (ItemConditionsList)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004481")]
		[Cpp2IlInjected.Address(RVA = "0x22C2A50", Offset = "0x22C1450", VA = "0x1822C2A50", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemConditionItemData Clone()
		{
			//Discarded unreachable code: IL_00c3
			//IL_00ac: Expected O, but got I4
			ItemConditionItemData itemConditionItemData = new ItemConditionItemData();
			itemConditionItemData.name_ = "";
			itemConditionItemData.displayName_ = "";
			itemConditionItemData.iconAddress_ = "";
			itemConditionItemData.prefabAddress_ = "";
			ItemConditionsList itemConditionsList = (itemConditionItemData.conditions_ = new ItemConditionsList());
			int num = (itemConditionItemData.iD_ = iD_);
			string text = (itemConditionItemData.name_ = name_);
			string text2 = (itemConditionItemData.displayName_ = displayName_);
			string text3 = (itemConditionItemData.iconAddress_ = iconAddress_);
			string text4 = (itemConditionItemData.prefabAddress_ = prefabAddress_);
			ItemConditionsList itemConditionsList2 = conditions_;
			if (itemConditionsList2 != null)
			{
				ItemConditionsList itemConditionsList3 = itemConditionsList2.Clone();
			}
			int num2 = 0;
			itemConditionItemData.conditions_ = (ItemConditionsList)num2;
			UnknownFieldSet unknownFieldSet = (itemConditionItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemConditionItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600448E")]
		[Cpp2IlInjected.Address(RVA = "0x22C2D60", Offset = "0x22C1760", VA = "0x1822C2D60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(ItemConditionItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && object.Equals(conditions_, other))
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600448F")]
		[Cpp2IlInjected.Address(RVA = "0x2077720", Offset = "0x2076120", VA = "0x182077720", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemConditionItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									ItemConditionsList objB = other.conditions_;
									if (object.Equals(conditions_, objB))
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										return object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004490")]
		[Cpp2IlInjected.Address(RVA = "0x2077E50", Offset = "0x2076850", VA = "0x182077E50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_009c
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			ItemConditionsList itemConditionsList = conditions_;
			if (itemConditionsList != null)
			{
				int hashCode5 = itemConditionsList.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004491")]
		[Cpp2IlInjected.Address(RVA = "0x22C3DA0", Offset = "0x22C27A0", VA = "0x1822C3DA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004492")]
		[Cpp2IlInjected.Address(RVA = "0x20788D0", Offset = "0x20772D0", VA = "0x1820788D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ba
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if ((long)conditions_ != 0)
			{
				ItemConditionsList value6 = conditions_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004493")]
		[Cpp2IlInjected.Address(RVA = "0x22C2780", Offset = "0x22C1180", VA = "0x1822C2780", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00e7
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			ItemConditionsList itemConditionsList = conditions_;
			if (itemConditionsList != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(itemConditionsList);
				num8++;
				num2 += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num2 += num9;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004494")]
		[Cpp2IlInjected.Address(RVA = "0x22C3960", Offset = "0x22C2360", VA = "0x1822C3960", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemConditionItemData other)
		{
			//Discarded unreachable code: IL_0125
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			if (other.conditions_ != null)
			{
				ItemConditionsList itemConditionsList2 = default(ItemConditionsList);
				ItemConditionsList itemConditionsList3 = default(ItemConditionsList);
				if (conditions_ == null)
				{
					ItemConditionsList itemConditionsList = (conditions_ = new ItemConditionsList());
					itemConditionsList2 = conditions_;
					itemConditionsList3 = other.conditions_;
				}
				if (itemConditionsList3 != null)
				{
					BoolOperator operator_ = itemConditionsList3.operator_;
					if (operator_ != 0)
					{
						itemConditionsList2.operator_ = operator_;
					}
					RepeatedField<ItemConditionOneOf> repeatedField = itemConditionsList2.conditions_;
					RepeatedField<ItemConditionOneOf> repeatedField2 = itemConditionsList3.conditions_;
					((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
					UnknownFieldSet unknownFields = itemConditionsList3._unknownFields;
					UnknownFieldSet unknownFieldSet = (itemConditionsList2._unknownFields = UnknownFieldSet.MergeFrom(itemConditionsList2._unknownFields, unknownFields));
				}
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6004495")]
		[Cpp2IlInjected.Address(RVA = "0x22C37D0", Offset = "0x22C21D0", VA = "0x1822C37D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_00ad;
				}
				ItemConditionsList builder = default(ItemConditionsList);
				if (conditions_ == null)
				{
					ItemConditionsList itemConditionsList = (conditions_ = new ItemConditionsList());
					builder = conditions_;
				}
				input.ReadMessage(builder);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num2 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_00ad;
			IL_00ad:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004496")]
		[Cpp2IlInjected.Address(RVA = "0x22C3560", Offset = "0x22C1F60", VA = "0x1822C3560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004497")]
		[Cpp2IlInjected.Address(RVA = "0x22C3B80", Offset = "0x22C2580", VA = "0x1822C3B80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_001f, IL_0025, IL_002b, IL_0031
			//IL_000d: Expected I4, but got O
			//IL_0019: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004498")]
		[Cpp2IlInjected.Address(RVA = "0x22C2940", Offset = "0x22C1340", VA = "0x1822C2940", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600449A")]
		[Cpp2IlInjected.Address(RVA = "0x22C2D50", Offset = "0x22C1750", VA = "0x1822C2D50", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ItemConditionItemData itemConditionItemData = Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600449B")]
		[Cpp2IlInjected.Address(RVA = "0x22C3690", Offset = "0x22C2090", VA = "0x1822C3690")]
		private static ItemConditionItemData GetItemData(Item item)
		{
			//Discarded unreachable code: IL_0008
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ItemConditionItemData result = default(ItemConditionItemData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600449C")]
		[Cpp2IlInjected.Address(RVA = "0x22C2E80", Offset = "0x22C1880", VA = "0x1822C2E80")]
		public static bool Evaluate(IEnumerable<int> ids, Item target)
		{
			//Discarded unreachable code: IL_000f
			new _003CIdsToItems_003Ed__61(-2)._003C_003E3__ids = ids;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600449D")]
		[Cpp2IlInjected.Address(RVA = "0x22C2F40", Offset = "0x22C1940", VA = "0x1822C2F40")]
		public static bool Evaluate(IEnumerable<Item> items, Item target)
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			int num2 = 0;
			if (items != null)
			{
				if ((object)typeof(ItemConditionItemData).TypeHandle != null)
				{
					bool flag = default(bool);
					while (flag)
					{
					}
					int num3 = 0;
					num2++;
				}
				if (num2 + 1 == 0)
				{
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600449E")]
		[Cpp2IlInjected.Address(RVA = "0x22C30E0", Offset = "0x22C1AE0", VA = "0x1822C30E0")]
		public static bool Evaluate(Item item, Item target)
		{
			ItemConditionItemData itemConditionItemData = default(ItemConditionItemData);
			while (true)
			{
				if ((object)typeof(Item).TypeHandle != null)
				{
					return true;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (itemConditionItemData != null)
				{
					ItemConditionsList itemConditionsList = itemConditionItemData.conditions_;
					if (((RepeatedField<T>)(object)itemConditionsList.conditions_).Count == 0)
					{
						break;
					}
					RepeatedField<ItemConditionOneOf> repeatedField = itemConditionsList.conditions_;
					int num = 0;
					int count = ((RepeatedField<T>)(object)repeatedField).Count;
					if (num >= count)
					{
						break;
					}
					ItemConditionOneOf itemConditionOneOf = (ItemConditionOneOf)((RepeatedField<T>)(object)itemConditionsList.conditions_)[num];
					if ((object)typeof(IItemCondition).TypeHandle != null)
					{
					}
					int num2 = 0;
					BoolOperator operator_ = itemConditionsList.operator_;
					if (num2 != 0)
					{
						continue;
					}
					if (operator_ != 0)
					{
						break;
					}
				}
				if (0 == 1)
				{
				}
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600449F")]
		[Cpp2IlInjected.Address(RVA = "0x22C33D0", Offset = "0x22C1DD0", VA = "0x1822C33D0")]
		private bool Evaluate(Item target)
		{
			ItemConditionsList itemConditionsList = conditions_;
			if (((RepeatedField<T>)(object)itemConditionsList.conditions_).Count != 0)
			{
				RepeatedField<ItemConditionOneOf> repeatedField = itemConditionsList.conditions_;
				int num = 0;
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				if (num < count)
				{
					ItemConditionOneOf itemConditionOneOf = (ItemConditionOneOf)((RepeatedField<T>)(object)itemConditionsList.conditions_)[num];
					if ((object)typeof(IItemCondition).TypeHandle != null)
					{
					}
					int num2 = 0;
					BoolOperator operator_ = itemConditionsList.operator_;
					if ((num2 == 0 && operator_ != 0) || operator_ != BoolOperator.Or)
					{
						RepeatedField<ItemConditionOneOf> repeatedField2 = itemConditionsList.conditions_;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044A0")]
		[Cpp2IlInjected.Address(RVA = "0x22C3760", Offset = "0x22C2160", VA = "0x1822C3760")]
		[IteratorStateMachine(typeof(_003CIdsToItems_003Ed__61))]
		private static IEnumerable<Item> IdsToItems(IEnumerable<int> ids)
		{
			new _003CIdsToItems_003Ed__61(-2)._003C_003E3__ids = ids;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044A1")]
		[Cpp2IlInjected.Address(RVA = "0x22C2C10", Offset = "0x22C1610", VA = "0x1822C2C10", Slot = "21")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0046
			ItemConditionsList itemConditionsList = conditions_;
			if (itemConditionsList != null)
			{
				IEnumerable<ItemConditionCommon> allConditions = (IEnumerable<ItemConditionCommon>)itemConditionsList.GetAllConditions<ItemConditionCommon>();
				Func<ItemConditionCommon, bool> cpp2il__autoParamName__idx_ = (Func<ItemConditionCommon, bool>)(object)(Func<T, TResult>)delegate(ItemConditionCommon x)
				{
					//Discarded unreachable code: IL_0011
					int num = iD_;
					return x.condition_ == num;
				};
				if (((IEnumerable<>)allConditions).Any<ItemConditionCommon>((Func<, >)(object)cpp2il__autoParamName__idx_))
				{
					context.AddInvalidMemberError("Circular condition detected, don't use CommonCondition on him-self", "Conditions");
				}
			}
			else
			{
				context.AddError("Conditions is null (PROG ERROR)");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044A2")]
		[Cpp2IlInjected.Address(RVA = "0x22C3E00", Offset = "0x22C2800", VA = "0x1822C3E00")]
		static ItemConditionItemData()
		{
			Func<ItemConditionItemData> func = default(Func<ItemConditionItemData>);
			_parser = (MessageParser<ItemConditionItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
