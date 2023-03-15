using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200057F")]
	public sealed class ConditionItemData : IMessage<ConditionItemData>, IMessage, IEquatable<ConditionItemData>, IDeepCloneable<ConditionItemData>, IMessageFieldAccessor, IItemData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001DB5")]
		private static readonly MessageParser<ConditionItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001DB6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001DB7")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DB8")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001DB9")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DBA")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DBB")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DBC")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DBD")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DBE")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DBF")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DC0")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DC1")]
		public const int ConditionsFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DC2")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x17001199")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004443")]
			[Cpp2IlInjected.Address(RVA = "0x2078ED0", Offset = "0x20778D0", VA = "0x182078ED0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700119A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004444")]
			[Cpp2IlInjected.Address(RVA = "0x2078DA0", Offset = "0x20777A0", VA = "0x182078DA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700119B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004445")]
			[Cpp2IlInjected.Address(RVA = "0x2078F30", Offset = "0x2077930", VA = "0x182078F30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700119C")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x600444A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x600444B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700119D")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600444C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600444D")]
			[Cpp2IlInjected.Address(RVA = "0x2079120", Offset = "0x2077B20", VA = "0x182079120")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700119E")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600444E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600444F")]
			[Cpp2IlInjected.Address(RVA = "0x2079040", Offset = "0x2077A40", VA = "0x182079040")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700119F")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004450")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004451")]
			[Cpp2IlInjected.Address(RVA = "0x20790B0", Offset = "0x2077AB0", VA = "0x1820790B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A0")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004452")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004453")]
			[Cpp2IlInjected.Address(RVA = "0x2079190", Offset = "0x2077B90", VA = "0x182079190")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A1")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6004454")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004455")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011A2")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004461")]
			[Cpp2IlInjected.Address(RVA = "0x2078E70", Offset = "0x2077870", VA = "0x182078E70", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004446")]
		[Cpp2IlInjected.Address(RVA = "0x2078CD0", Offset = "0x20776D0", VA = "0x182078CD0")]
		[DebuggerNonUserCode]
		public ConditionItemData()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004447")]
		[Cpp2IlInjected.Address(RVA = "0x20785F0", Offset = "0x2076FF0", VA = "0x1820785F0")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004448")]
		[Cpp2IlInjected.Address(RVA = "0x2078B40", Offset = "0x2077540", VA = "0x182078B40")]
		[DebuggerNonUserCode]
		public ConditionItemData(ConditionItemData other)
		{
			//IL_00aa: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			ConditionsList conditionsList2 = other.conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num2 = 0;
			conditions_ = (ConditionsList)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004449")]
		[Cpp2IlInjected.Address(RVA = "0x2077410", Offset = "0x2075E10", VA = "0x182077410", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionItemData Clone()
		{
			//Discarded unreachable code: IL_00c3
			//IL_00ac: Expected O, but got I4
			ConditionItemData conditionItemData = new ConditionItemData();
			conditionItemData.name_ = "";
			conditionItemData.displayName_ = "";
			conditionItemData.iconAddress_ = "";
			conditionItemData.prefabAddress_ = "";
			ConditionsList conditionsList = (conditionItemData.conditions_ = new ConditionsList());
			int num = (conditionItemData.iD_ = iD_);
			string text = (conditionItemData.name_ = name_);
			string text2 = (conditionItemData.displayName_ = displayName_);
			string text3 = (conditionItemData.iconAddress_ = iconAddress_);
			string text4 = (conditionItemData.prefabAddress_ = prefabAddress_);
			ConditionsList conditionsList2 = conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num2 = 0;
			conditionItemData.conditions_ = (ConditionsList)num2;
			UnknownFieldSet unknownFieldSet = (conditionItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004456")]
		[Cpp2IlInjected.Address(RVA = "0x20777F0", Offset = "0x20761F0", VA = "0x1820777F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(ConditionItemData).TypeHandle)
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

		[Cpp2IlInjected.Token(Token = "0x6004457")]
		[Cpp2IlInjected.Address(RVA = "0x2077720", Offset = "0x2076120", VA = "0x182077720", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionItemData other)
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
									ConditionsList objB = other.conditions_;
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

		[Cpp2IlInjected.Token(Token = "0x6004458")]
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
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int hashCode5 = conditionsList.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004459")]
		[Cpp2IlInjected.Address(RVA = "0x2078870", Offset = "0x2077270", VA = "0x182078870", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600445A")]
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
				ConditionsList value6 = conditions_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600445B")]
		[Cpp2IlInjected.Address(RVA = "0x2077140", Offset = "0x2075B40", VA = "0x182077140", Slot = "7")]
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
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(conditionsList);
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

		[Cpp2IlInjected.Token(Token = "0x600445C")]
		[Cpp2IlInjected.Address(RVA = "0x20784A0", Offset = "0x2076EA0", VA = "0x1820784A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionItemData other)
		{
			//Discarded unreachable code: IL_00d4
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
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					conditionsList2 = conditions_;
				}
				ConditionsList other2 = other.conditions_;
				conditionsList2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600445D")]
		[Cpp2IlInjected.Address(RVA = "0x2078310", Offset = "0x2076D10", VA = "0x182078310", Slot = "5")]
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
				ConditionsList builder = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
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

		[Cpp2IlInjected.Token(Token = "0x600445E")]
		[Cpp2IlInjected.Address(RVA = "0x2077D20", Offset = "0x2076720", VA = "0x182077D20", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x600445F")]
		[Cpp2IlInjected.Address(RVA = "0x2078650", Offset = "0x2077050", VA = "0x182078650", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004460")]
		[Cpp2IlInjected.Address(RVA = "0x2077300", Offset = "0x2075D00", VA = "0x182077300", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0014, IL_0015, IL_0017, IL_001b, IL_001f
			//IL_0011: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num <= 5)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004462")]
		[Cpp2IlInjected.Address(RVA = "0x2077710", Offset = "0x2076110", VA = "0x182077710", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ConditionItemData conditionItemData = Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004463")]
		[Cpp2IlInjected.Address(RVA = "0x2077F60", Offset = "0x2076960", VA = "0x182077F60")]
		private static ConditionItemData GetItemData(Item item)
		{
			//Discarded unreachable code: IL_0008
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ConditionItemData result = default(ConditionItemData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004464")]
		[Cpp2IlInjected.Address(RVA = "0x2077C50", Offset = "0x2076650", VA = "0x182077C50")]
		public static bool Evaluate(IEnumerable<int> ids, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0018
			_003CIdsToItems_003Ed__64 _003CIdsToItems_003Ed__ = new _003CIdsToItems_003Ed__64(-2);
			_003CIdsToItems_003Ed__._003C_003E3__ids = ids;
			return ConditionItemData.Evaluate((IEnumerable<>)(object)_003CIdsToItems_003Ed__, profile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6004465")]
		[Cpp2IlInjected.Address(RVA = "0x2077A90", Offset = "0x2076490", VA = "0x182077A90")]
		public static bool Evaluate(IEnumerable<Item> items, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0028
			int num = 0;
			int num2 = 0;
			if (items != null && context != null)
			{
				if ((object)typeof(IEnumerator).TypeHandle != null)
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

		[Cpp2IlInjected.Token(Token = "0x6004466")]
		[Cpp2IlInjected.Address(RVA = "0x2077940", Offset = "0x2076340", VA = "0x182077940")]
		public static bool Evaluate(Item item, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0019
			if ((object)typeof(Item).TypeHandle != null)
			{
				return true;
			}
			ConditionItemData conditionItemData = default(ConditionItemData);
			bool result = default(bool);
			if (conditionItemData != null)
			{
				ConditionsList conditionsList = conditionItemData.conditions_;
				return result;
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004467")]
		[Cpp2IlInjected.Address(RVA = "0x2077910", Offset = "0x2076310", VA = "0x182077910")]
		private bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_000f
			return conditions_.Evaluate(in playerProfile, in worldProfile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6004468")]
		[Cpp2IlInjected.Address(RVA = "0x20781F0", Offset = "0x2076BF0", VA = "0x1820781F0")]
		public static ConditionListener GetMask(IEnumerable<int> ids)
		{
			//Discarded unreachable code: IL_0016
			_003CIdsToItems_003Ed__64 _003CIdsToItems_003Ed__ = new _003CIdsToItems_003Ed__64(-2);
			_003CIdsToItems_003Ed__._003C_003E3__ids = ids;
			return ConditionItemData.GetMask((IEnumerable<>)(object)_003CIdsToItems_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6004469")]
		[Cpp2IlInjected.Address(RVA = "0x2078030", Offset = "0x2076A30", VA = "0x182078030")]
		public static ConditionListener GetMask(IEnumerable<Item> items)
		{
			int num = 0;
			if (items == null || (object)typeof(IEnumerator).TypeHandle != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600446A")]
		[Cpp2IlInjected.Address(RVA = "0x2078170", Offset = "0x2076B70", VA = "0x182078170")]
		public static ConditionListener GetMask(Item item)
		{
			int itemID = item.ItemID;
			ConditionItemData conditionItemData = default(ConditionItemData);
			if (conditionItemData != null)
			{
				return conditionItemData.conditions_.Listener;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600446B")]
		[Cpp2IlInjected.Address(RVA = "0x20782A0", Offset = "0x2076CA0", VA = "0x1820782A0")]
		[IteratorStateMachine(typeof(_003CIdsToItems_003Ed__64))]
		private static IEnumerable<Item> IdsToItems(IEnumerable<int> ids)
		{
			new _003CIdsToItems_003Ed__64(-2)._003C_003E3__ids = ids;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600446C")]
		[Cpp2IlInjected.Address(RVA = "0x20775D0", Offset = "0x2075FD0", VA = "0x1820775D0", Slot = "21")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0046
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				IEnumerable<> allConditions = conditionsList.GetAllConditions<ConditionCommon>();
				Func<ConditionCommon, bool> cpp2il__autoParamName__idx_ = (Func<ConditionCommon, bool>)(object)(Func<T, TResult>)delegate(ConditionCommon x)
				{
					//Discarded unreachable code: IL_0011
					int num = iD_;
					return x.condition_ == num;
				};
				if (allConditions.Any<ConditionCommon>((Func<, >)(object)cpp2il__autoParamName__idx_))
				{
					context.AddInvalidMemberError("Circular condition detected, don't use CommonCondition on him-self", "Conditions");
				}
			}
			else
			{
				context.AddError("Conditions is null (PROG ERROR)");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600446D")]
		[Cpp2IlInjected.Address(RVA = "0x2078A30", Offset = "0x2077430", VA = "0x182078A30")]
		static ConditionItemData()
		{
			Func<ConditionItemData> func = default(Func<ConditionItemData>);
			_parser = (MessageParser<ConditionItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
