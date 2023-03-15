using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003BE")]
	public sealed class PendingFishUpgradeRecurringEventItemData : IMessage<PendingFishUpgradeRecurringEventItemData>, IMessage, IEquatable<PendingFishUpgradeRecurringEventItemData>, IDeepCloneable<PendingFishUpgradeRecurringEventItemData>, IMessageFieldAccessor, IRecurringEventData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4001385")]
		private static readonly MessageParser<PendingFishUpgradeRecurringEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001386")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001387")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001388")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001389")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400138A")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400138B")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400138C")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400138D")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400138E")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400138F")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001390")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001391")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001392")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x4001393")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001394")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x4001395")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001396")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x17000B1A")]
		[DebuggerNonUserCode]
		public static MessageParser<PendingFishUpgradeRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002C6B")]
			[Cpp2IlInjected.Address(RVA = "0x36AB160", Offset = "0x36A9B60", VA = "0x1836AB160")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C6C")]
			[Cpp2IlInjected.Address(RVA = "0x36AB090", Offset = "0x36A9A90", VA = "0x1836AB090")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C6D")]
			[Cpp2IlInjected.Address(RVA = "0x36AB1C0", Offset = "0x36A9BC0", VA = "0x1836AB1C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1D")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002C72")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C73")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1E")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002C74")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C75")]
			[Cpp2IlInjected.Address(RVA = "0x36AB3B0", Offset = "0x36A9DB0", VA = "0x1836AB3B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B1F")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002C76")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "20")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C77")]
			[Cpp2IlInjected.Address(RVA = "0x36AB2D0", Offset = "0x36A9CD0", VA = "0x1836AB2D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B20")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002C78")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C79")]
			[Cpp2IlInjected.Address(RVA = "0x36AB340", Offset = "0x36A9D40", VA = "0x1836AB340")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B21")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002C7A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "22")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C7B")]
			[Cpp2IlInjected.Address(RVA = "0x36AB420", Offset = "0x36A9E20", VA = "0x1836AB420")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B22")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002C7C")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "14")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C7D")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B23")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002C7E")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C7F")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B24")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002C80")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "16")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C81")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B25")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002C8D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C6E")]
		[Cpp2IlInjected.Address(RVA = "0x36AAE20", Offset = "0x36A9820", VA = "0x1836AAE20")]
		[DebuggerNonUserCode]
		public PendingFishUpgradeRecurringEventItemData()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C6F")]
		[Cpp2IlInjected.Address(RVA = "0x36AA990", Offset = "0x36A9390", VA = "0x1836AA990")]
		private void OnConstruction()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C70")]
		[Cpp2IlInjected.Address(RVA = "0x36AAEF0", Offset = "0x36A98F0", VA = "0x1836AAEF0")]
		[DebuggerNonUserCode]
		public PendingFishUpgradeRecurringEventItemData(PendingFishUpgradeRecurringEventItemData other)
		{
			//IL_00ba: Expected O, but got I4
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			bool flag = (activeByDefault_ = other.activeByDefault_);
			RecurringEventIntervalData recurringEventIntervalData2 = other.intervalData_;
			if (recurringEventIntervalData2 != null)
			{
				RecurringEventIntervalData recurringEventIntervalData3 = recurringEventIntervalData2.Clone();
			}
			int num2 = 0;
			intervalData_ = (RecurringEventIntervalData)num2;
			bool flag2 = (executeOnAdd_ = other.executeOnAdd_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C71")]
		[Cpp2IlInjected.Address(RVA = "0x36AA1F0", Offset = "0x36A8BF0", VA = "0x1836AA1F0", Slot = "10")]
		[DebuggerNonUserCode]
		public PendingFishUpgradeRecurringEventItemData Clone()
		{
			//Discarded unreachable code: IL_00e3
			//IL_00bc: Expected O, but got I4
			PendingFishUpgradeRecurringEventItemData pendingFishUpgradeRecurringEventItemData = new PendingFishUpgradeRecurringEventItemData();
			pendingFishUpgradeRecurringEventItemData.name_ = "";
			pendingFishUpgradeRecurringEventItemData.displayName_ = "";
			pendingFishUpgradeRecurringEventItemData.iconAddress_ = "";
			pendingFishUpgradeRecurringEventItemData.prefabAddress_ = "";
			RecurringEventIntervalData recurringEventIntervalData = (pendingFishUpgradeRecurringEventItemData.intervalData_ = new RecurringEventIntervalData());
			int num = (pendingFishUpgradeRecurringEventItemData.iD_ = iD_);
			string text = (pendingFishUpgradeRecurringEventItemData.name_ = name_);
			string text2 = (pendingFishUpgradeRecurringEventItemData.displayName_ = displayName_);
			string text3 = (pendingFishUpgradeRecurringEventItemData.iconAddress_ = iconAddress_);
			string text4 = (pendingFishUpgradeRecurringEventItemData.prefabAddress_ = prefabAddress_);
			bool flag = (pendingFishUpgradeRecurringEventItemData.activeByDefault_ = activeByDefault_);
			RecurringEventIntervalData recurringEventIntervalData2 = intervalData_;
			if (recurringEventIntervalData2 != null)
			{
				RecurringEventIntervalData recurringEventIntervalData3 = recurringEventIntervalData2.Clone();
			}
			int num2 = 0;
			pendingFishUpgradeRecurringEventItemData.intervalData_ = (RecurringEventIntervalData)num2;
			bool flag2 = (pendingFishUpgradeRecurringEventItemData.executeOnAdd_ = executeOnAdd_);
			UnknownFieldSet unknownFieldSet = (pendingFishUpgradeRecurringEventItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pendingFishUpgradeRecurringEventItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C82")]
		[Cpp2IlInjected.Address(RVA = "0x36AA3D0", Offset = "0x36A8DD0", VA = "0x1836AA3D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(PendingFishUpgradeRecurringEventItemData).TypeHandle)
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
								if (!flag4 && activeByDefault_ == flag4)
								{
									bool flag5 = object.Equals(intervalData_, other);
									if (flag5 && executeOnAdd_ == flag5)
									{
										return object.Equals(_unknownFields, other);
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C83")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9CE0", Offset = "0x2DA86E0", VA = "0x182DA9CE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PendingFishUpgradeRecurringEventItemData other)
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
									bool flag = other.activeByDefault_;
									if (activeByDefault_ == flag)
									{
										RecurringEventIntervalData objB = other.intervalData_;
										if (object.Equals(intervalData_, objB))
										{
											bool flag2 = other.executeOnAdd_;
											if (executeOnAdd_ == flag2)
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
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C84")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA060", Offset = "0x2DA8A60", VA = "0x182DAA060", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b1
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
			if (activeByDefault_)
			{
			}
			RecurringEventIntervalData recurringEventIntervalData = intervalData_;
			if (recurringEventIntervalData != null)
			{
				int hashCode5 = recurringEventIntervalData.GetHashCode();
			}
			if (executeOnAdd_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C85")]
		[Cpp2IlInjected.Address(RVA = "0x36AACB0", Offset = "0x36A96B0", VA = "0x1836AACB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C86")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA8B0", Offset = "0x2DA92B0", VA = "0x182DAA8B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ec
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
			if (activeByDefault_)
			{
				bool value6 = activeByDefault_;
				output.WriteBool(value6);
			}
			if ((long)intervalData_ != 0)
			{
				RecurringEventIntervalData value7 = intervalData_;
				output.WriteMessage(value7);
			}
			if (executeOnAdd_)
			{
				bool value8 = executeOnAdd_;
				output.WriteBool(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C87")]
		[Cpp2IlInjected.Address(RVA = "0x36A9EF0", Offset = "0x36A88F0", VA = "0x1836A9EF0", Slot = "7")]
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
			RecurringEventIntervalData recurringEventIntervalData = intervalData_;
			if (recurringEventIntervalData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(recurringEventIntervalData);
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

		[Cpp2IlInjected.Token(Token = "0x6002C88")]
		[Cpp2IlInjected.Address(RVA = "0x36AA830", Offset = "0x36A9230", VA = "0x1836AA830", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PendingFishUpgradeRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_00fe
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
			bool flag = other.activeByDefault_;
			if (flag)
			{
				activeByDefault_ = flag;
			}
			if ((long)other.intervalData_ != 0)
			{
				RecurringEventIntervalData recurringEventIntervalData2 = default(RecurringEventIntervalData);
				if (intervalData_ == null)
				{
					RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
					recurringEventIntervalData2 = intervalData_;
				}
				RecurringEventIntervalData other2 = other.intervalData_;
				recurringEventIntervalData2.MergeFrom(other2);
			}
			bool flag2 = other.executeOnAdd_;
			if (flag2)
			{
				executeOnAdd_ = flag2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C89")]
		[Cpp2IlInjected.Address(RVA = "0x36AA670", Offset = "0x36A9070", VA = "0x1836AA670", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0100
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 48)
				{
					if (num == 58)
					{
						RecurringEventIntervalData recurringEventIntervalData = intervalData_;
						if (recurringEventIntervalData == null)
						{
							RecurringEventIntervalData recurringEventIntervalData2 = (intervalData_ = new RecurringEventIntervalData());
						}
						input.ReadMessage(recurringEventIntervalData);
					}
					if (num != 64)
					{
						goto IL_00e9;
					}
					bool flag = (executeOnAdd_ = input.ReadBool());
				}
				string text2 = default(string);
				if (num == 42)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				if ((long)text2 != 48)
				{
					goto IL_00e9;
				}
				bool flag2 = (activeByDefault_ = input.ReadBool());
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				if ((long)text4 != 34)
				{
					goto IL_00e9;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num2 = default(int);
			if ((long)text6 == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_00e9;
			IL_00e9:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8A")]
		[Cpp2IlInjected.Address(RVA = "0x36AA500", Offset = "0x36A8F00", VA = "0x1836AA500", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8B")]
		[Cpp2IlInjected.Address(RVA = "0x36AA9F0", Offset = "0x36A93F0", VA = "0x1836AA9F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_001f, IL_0027, IL_0036, IL_003c, IL_0042, IL_0048, IL_004e, IL_0054, IL_005a
			//IL_000d: Expected I4, but got O
			//IL_002e: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8C")]
		[Cpp2IlInjected.Address(RVA = "0x36AA0C0", Offset = "0x36A8AC0", VA = "0x1836AA0C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 7)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8E")]
		[Cpp2IlInjected.Address(RVA = "0x36AA3C0", Offset = "0x36A8DC0", VA = "0x1836AA3C0", Slot = "23")]
		IItemData IItemData.Clone()
		{
			PendingFishUpgradeRecurringEventItemData pendingFishUpgradeRecurringEventItemData = Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8F")]
		[Cpp2IlInjected.Address(RVA = "0x36AAD10", Offset = "0x36A9710", VA = "0x1836AAD10")]
		static PendingFishUpgradeRecurringEventItemData()
		{
			Func<PendingFishUpgradeRecurringEventItemData> func = default(Func<PendingFishUpgradeRecurringEventItemData>);
			_parser = (MessageParser<PendingFishUpgradeRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
