using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000585")]
	public sealed class LootTableItemData : IMessage<LootTableItemData>, IMessage, IEquatable<LootTableItemData>, IDeepCloneable<LootTableItemData>, IMessageFieldAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4001DDF")]
		private static readonly MessageParser<LootTableItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001DE0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001DE1")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DE2")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001DE3")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DE4")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DE5")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DE6")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DE7")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DE8")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DE9")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DEA")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001DEB")]
		public const int RewardsFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DEC")]
		private LootTable rewards_;

		[Cpp2IlInjected.Token(Token = "0x170011B1")]
		[DebuggerNonUserCode]
		public static MessageParser<LootTableItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60044B0")]
			[Cpp2IlInjected.Address(RVA = "0x38FA800", Offset = "0x38F9200", VA = "0x1838FA800")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60044B1")]
			[Cpp2IlInjected.Address(RVA = "0x38FA730", Offset = "0x38F9130", VA = "0x1838FA730")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60044B2")]
			[Cpp2IlInjected.Address(RVA = "0x38FA860", Offset = "0x38F9260", VA = "0x1838FA860", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B4")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60044B7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044B8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B5")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60044B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044BA")]
			[Cpp2IlInjected.Address(RVA = "0x38FAA50", Offset = "0x38F9450", VA = "0x1838FAA50")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B6")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60044BB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044BC")]
			[Cpp2IlInjected.Address(RVA = "0x38FA970", Offset = "0x38F9370", VA = "0x1838FA970")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B7")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60044BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044BE")]
			[Cpp2IlInjected.Address(RVA = "0x38FA9E0", Offset = "0x38F93E0", VA = "0x1838FA9E0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B8")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60044BF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044C0")]
			[Cpp2IlInjected.Address(RVA = "0x38FAAC0", Offset = "0x38F94C0", VA = "0x1838FAAC0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B9")]
		[DebuggerNonUserCode]
		public LootTable Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60044C1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return rewards_;
			}
			[Cpp2IlInjected.Token(Token = "0x60044C2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				rewards_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011BA")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60044CE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60044B3")]
		[Cpp2IlInjected.Address(RVA = "0x38FA440", Offset = "0x38F8E40", VA = "0x1838FA440")]
		[DebuggerNonUserCode]
		public LootTableItemData()
		{
			LootTable lootTable = (rewards_ = new LootTable());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044B4")]
		[Cpp2IlInjected.Address(RVA = "0x38FA050", Offset = "0x38F8A50", VA = "0x1838FA050")]
		private void OnConstruction()
		{
			LootTable lootTable = (rewards_ = new LootTable());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044B5")]
		[Cpp2IlInjected.Address(RVA = "0x38FA510", Offset = "0x38F8F10", VA = "0x1838FA510")]
		[DebuggerNonUserCode]
		public LootTableItemData(LootTableItemData other)
		{
			//IL_00d6: Expected O, but got I4
			LootTable lootTable = (rewards_ = new LootTable());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			LootTable lootTable2 = other.rewards_;
			if (lootTable2 != null)
			{
				LootTable lootTable3 = new LootTable();
				RepeatedField<SubLootTable> repeatedField = (lootTable3.subLootTables_ = (RepeatedField<SubLootTable>)(object)((RepeatedField<T>)(object)lootTable2.subLootTables_).Clone());
				UnknownFieldSet unknownFieldSet = (lootTable3._unknownFields = UnknownFieldSet.Clone(lootTable2._unknownFields));
			}
			int num2 = 0;
			rewards_ = (LootTable)num2;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60044B6")]
		[Cpp2IlInjected.Address(RVA = "0x38F9A60", Offset = "0x38F8460", VA = "0x1838F9A60", Slot = "10")]
		[DebuggerNonUserCode]
		public LootTableItemData Clone()
		{
			return new LootTableItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60044C3")]
		[Cpp2IlInjected.Address(RVA = "0x38F9AC0", Offset = "0x38F84C0", VA = "0x1838F9AC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(LootTableItemData).TypeHandle)
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
								if (!flag4 && object.Equals(rewards_, other))
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

		[Cpp2IlInjected.Token(Token = "0x60044C4")]
		[Cpp2IlInjected.Address(RVA = "0x2077720", Offset = "0x2076120", VA = "0x182077720", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootTableItemData other)
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
									LootTable objB = other.rewards_;
									if (object.Equals(rewards_, objB))
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

		[Cpp2IlInjected.Token(Token = "0x60044C5")]
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
			LootTable lootTable = rewards_;
			if (lootTable != null)
			{
				int hashCode5 = lootTable.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60044C6")]
		[Cpp2IlInjected.Address(RVA = "0x38FA2D0", Offset = "0x38F8CD0", VA = "0x1838FA2D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60044C7")]
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
			if ((long)rewards_ != 0)
			{
				LootTable value6 = rewards_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60044C8")]
		[Cpp2IlInjected.Address(RVA = "0x38F9790", Offset = "0x38F8190", VA = "0x1838F9790", Slot = "7")]
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
			LootTable lootTable = rewards_;
			if (lootTable != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(lootTable);
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

		[Cpp2IlInjected.Token(Token = "0x60044C9")]
		[Cpp2IlInjected.Address(RVA = "0x38F9EA0", Offset = "0x38F88A0", VA = "0x1838F9EA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootTableItemData other)
		{
			//Discarded unreachable code: IL_010b
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
			if (other.rewards_ != null)
			{
				LootTable lootTable2 = default(LootTable);
				LootTable lootTable3 = default(LootTable);
				if (rewards_ == null)
				{
					LootTable lootTable = (rewards_ = new LootTable());
					lootTable2 = rewards_;
					lootTable3 = other.rewards_;
				}
				if (lootTable3 != null)
				{
					RepeatedField<SubLootTable> subLootTables_ = lootTable2.subLootTables_;
					RepeatedField<SubLootTable> subLootTables_2 = lootTable3.subLootTables_;
					((RepeatedField<T>)(object)subLootTables_).Add((IEnumerable<>)(object)subLootTables_2);
					UnknownFieldSet unknownFields = lootTable3._unknownFields;
					UnknownFieldSet unknownFieldSet = (lootTable2._unknownFields = UnknownFieldSet.MergeFrom(lootTable2._unknownFields, unknownFields));
				}
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x60044CA")]
		[Cpp2IlInjected.Address(RVA = "0x38F9D10", Offset = "0x38F8710", VA = "0x1838F9D10", Slot = "5")]
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
				LootTable builder = default(LootTable);
				if (rewards_ == null)
				{
					LootTable lootTable = (rewards_ = new LootTable());
					builder = rewards_;
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

		[Cpp2IlInjected.Token(Token = "0x60044CB")]
		[Cpp2IlInjected.Address(RVA = "0x38F9BE0", Offset = "0x38F85E0", VA = "0x1838F9BE0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60044CC")]
		[Cpp2IlInjected.Address(RVA = "0x38FA0B0", Offset = "0x38F8AB0", VA = "0x1838FA0B0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60044CD")]
		[Cpp2IlInjected.Address(RVA = "0x38F9950", Offset = "0x38F8350", VA = "0x1838F9950", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x60044CF")]
		[Cpp2IlInjected.Address(RVA = "0x38F9A60", Offset = "0x38F8460", VA = "0x1838F9A60", Slot = "20")]
		IItemData IItemData.Clone()
		{
			LootTableItemData lootTableItemData = new LootTableItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60044D0")]
		[Cpp2IlInjected.Address(RVA = "0x38FA330", Offset = "0x38F8D30", VA = "0x1838FA330")]
		static LootTableItemData()
		{
			Func<LootTableItemData> func = default(Func<LootTableItemData>);
			_parser = (MessageParser<LootTableItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
