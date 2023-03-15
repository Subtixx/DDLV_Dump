using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003B4")]
	public sealed class FlowerDryingInVillageRecurringEventItemData : IMessage<FlowerDryingInVillageRecurringEventItemData>, IMessage, IEquatable<FlowerDryingInVillageRecurringEventItemData>, IDeepCloneable<FlowerDryingInVillageRecurringEventItemData>, IMessageFieldAccessor, IRecurringEventData, IItemData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400132E")]
		private static readonly MessageParser<FlowerDryingInVillageRecurringEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400132F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001330")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001331")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001332")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001333")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001334")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001335")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001336")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001337")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001338")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001339")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400133A")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400133B")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x400133C")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400133D")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x400133E")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400133F")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x4001340")]
		public const int MinimumNumberOfFlowersToDryFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001341")]
		private int minimumNumberOfFlowersToDry_;

		[Cpp2IlInjected.Token(Token = "0x4001342")]
		public const int MaximumNumberOfFlowersToDryFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001343")]
		private int maximumNumberOfFlowersToDry_;

		[Cpp2IlInjected.Token(Token = "0x4001344")]
		public const int AreaSpecificationFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001345")]
		private SpawnRecurringEventAreaSpecification areaSpecification_;

		[Cpp2IlInjected.Token(Token = "0x4001346")]
		public const int MaximumAmountFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001347")]
		private int maximumAmount_;

		[Cpp2IlInjected.Token(Token = "0x17000AE7")]
		[DebuggerNonUserCode]
		public static MessageParser<FlowerDryingInVillageRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002BC3")]
			[Cpp2IlInjected.Address(RVA = "0x3582440", Offset = "0x3580E40", VA = "0x183582440")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002BC4")]
			[Cpp2IlInjected.Address(RVA = "0x3582370", Offset = "0x3580D70", VA = "0x183582370")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AE9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002BC5")]
			[Cpp2IlInjected.Address(RVA = "0x35824A0", Offset = "0x3580EA0", VA = "0x1835824A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AEA")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002BCA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BCB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AEB")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002BCC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BCD")]
			[Cpp2IlInjected.Address(RVA = "0x3582690", Offset = "0x3581090", VA = "0x183582690")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AEC")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002BCE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "20")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BCF")]
			[Cpp2IlInjected.Address(RVA = "0x35825B0", Offset = "0x3580FB0", VA = "0x1835825B0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AED")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002BD0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD1")]
			[Cpp2IlInjected.Address(RVA = "0x3582620", Offset = "0x3581020", VA = "0x183582620")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AEE")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002BD2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "22")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD3")]
			[Cpp2IlInjected.Address(RVA = "0x3582700", Offset = "0x3581100", VA = "0x183582700")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AEF")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002BD4")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "14")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD5")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF0")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002BD6")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD7")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF1")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002BD8")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "16")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD9")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF2")]
		[DebuggerNonUserCode]
		public int MinimumNumberOfFlowersToDry
		{
			[Cpp2IlInjected.Token(Token = "0x6002BDA")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return minimumNumberOfFlowersToDry_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BDB")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				minimumNumberOfFlowersToDry_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF3")]
		[DebuggerNonUserCode]
		public int MaximumNumberOfFlowersToDry
		{
			[Cpp2IlInjected.Token(Token = "0x6002BDC")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return maximumNumberOfFlowersToDry_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BDD")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				maximumNumberOfFlowersToDry_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF4")]
		[DebuggerNonUserCode]
		public SpawnRecurringEventAreaSpecification AreaSpecification
		{
			[Cpp2IlInjected.Token(Token = "0x6002BDE")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return areaSpecification_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BDF")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				areaSpecification_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF5")]
		[DebuggerNonUserCode]
		public int MaximumAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6002BE0")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return maximumAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BE1")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				maximumAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF6")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002BED")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC6")]
		[Cpp2IlInjected.Address(RVA = "0x3582050", Offset = "0x3580A50", VA = "0x183582050")]
		[DebuggerNonUserCode]
		public FlowerDryingInVillageRecurringEventItemData()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC7")]
		[Cpp2IlInjected.Address(RVA = "0x3581800", Offset = "0x3580200", VA = "0x183581800")]
		private void OnConstruction()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC8")]
		[Cpp2IlInjected.Address(RVA = "0x3582160", Offset = "0x3580B60", VA = "0x183582160")]
		[DebuggerNonUserCode]
		public FlowerDryingInVillageRecurringEventItemData(FlowerDryingInVillageRecurringEventItemData other)
		{
			//IL_00c9: Expected O, but got I4
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			bool flag = other.activeByDefault_;
			int num2 = 0;
			activeByDefault_ = flag;
			RecurringEventIntervalData recurringEventIntervalData2 = other.intervalData_;
			if (recurringEventIntervalData2 != null)
			{
				RecurringEventIntervalData recurringEventIntervalData3 = recurringEventIntervalData2.Clone();
			}
			intervalData_ = (RecurringEventIntervalData)num2;
			bool flag2 = (executeOnAdd_ = other.executeOnAdd_);
			int num3 = (minimumNumberOfFlowersToDry_ = other.minimumNumberOfFlowersToDry_);
			int num4 = (maximumNumberOfFlowersToDry_ = other.maximumNumberOfFlowersToDry_);
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification2 = other.areaSpecification_;
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification3 = default(SpawnRecurringEventAreaSpecification);
			if (spawnRecurringEventAreaSpecification2 != null)
			{
				spawnRecurringEventAreaSpecification3 = spawnRecurringEventAreaSpecification2.Clone();
			}
			areaSpecification_ = spawnRecurringEventAreaSpecification3;
			int num5 = (maximumAmount_ = other.maximumAmount_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC9")]
		[Cpp2IlInjected.Address(RVA = "0x3580D20", Offset = "0x357F720", VA = "0x183580D20", Slot = "10")]
		[DebuggerNonUserCode]
		public FlowerDryingInVillageRecurringEventItemData Clone()
		{
			return new FlowerDryingInVillageRecurringEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE2")]
		[Cpp2IlInjected.Address(RVA = "0x3580EF0", Offset = "0x357F8F0", VA = "0x183580EF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(FlowerDryingInVillageRecurringEventItemData).TypeHandle)
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
									if (flag5 && executeOnAdd_ == flag5 && minimumNumberOfFlowersToDry_ == (flag5 ? 1 : 0) && maximumNumberOfFlowersToDry_ == (flag5 ? 1 : 0))
									{
										bool flag6 = object.Equals(areaSpecification_, other);
										if (flag6 && maximumAmount_ == (flag6 ? 1 : 0))
										{
											return object.Equals(_unknownFields, other);
										}
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

		[Cpp2IlInjected.Token(Token = "0x6002BE3")]
		[Cpp2IlInjected.Address(RVA = "0x3580DE0", Offset = "0x357F7E0", VA = "0x183580DE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FlowerDryingInVillageRecurringEventItemData other)
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
												int num2 = other.minimumNumberOfFlowersToDry_;
												if (minimumNumberOfFlowersToDry_ == num2)
												{
													int num3 = other.maximumNumberOfFlowersToDry_;
													if (maximumNumberOfFlowersToDry_ == num3)
													{
														SpawnRecurringEventAreaSpecification objB2 = other.areaSpecification_;
														if (object.Equals(areaSpecification_, objB2))
														{
															int num4 = other.maximumAmount_;
															if (maximumAmount_ == num4)
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
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE4")]
		[Cpp2IlInjected.Address(RVA = "0x3581200", Offset = "0x357FC00", VA = "0x183581200", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e2
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
			if (minimumNumberOfFlowersToDry_ != 0)
			{
			}
			if (maximumNumberOfFlowersToDry_ != 0)
			{
			}
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = areaSpecification_;
			if (spawnRecurringEventAreaSpecification != null)
			{
				int hashCode6 = spawnRecurringEventAreaSpecification.GetHashCode();
			}
			if (maximumAmount_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE5")]
		[Cpp2IlInjected.Address(RVA = "0x3581C70", Offset = "0x3580670", VA = "0x183581C70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE6")]
		[Cpp2IlInjected.Address(RVA = "0x3581CD0", Offset = "0x35806D0", VA = "0x183581CD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0152
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
			if (minimumNumberOfFlowersToDry_ != 0)
			{
				int value9 = minimumNumberOfFlowersToDry_;
				output.WriteInt32(value9);
			}
			if (maximumNumberOfFlowersToDry_ != 0)
			{
				int value10 = maximumNumberOfFlowersToDry_;
				output.WriteInt32(value10);
			}
			if ((long)areaSpecification_ != 0)
			{
				SpawnRecurringEventAreaSpecification value11 = areaSpecification_;
				output.WriteMessage(value11);
			}
			if (maximumAmount_ != 0)
			{
				int value12 = maximumAmount_;
				output.WriteInt32(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE7")]
		[Cpp2IlInjected.Address(RVA = "0x35808F0", Offset = "0x357F2F0", VA = "0x1835808F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_016b
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
			int num9 = minimumNumberOfFlowersToDry_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = maximumNumberOfFlowersToDry_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = areaSpecification_;
			if (spawnRecurringEventAreaSpecification != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(spawnRecurringEventAreaSpecification);
				num13++;
				num2 += num13;
			}
			int num14 = maximumAmount_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE8")]
		[Cpp2IlInjected.Address(RVA = "0x3581620", Offset = "0x3580020", VA = "0x183581620", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FlowerDryingInVillageRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_0179
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
			int num2 = other.minimumNumberOfFlowersToDry_;
			if (num2 != 0)
			{
				minimumNumberOfFlowersToDry_ = num2;
			}
			int num3 = other.maximumNumberOfFlowersToDry_;
			if (num3 != 0)
			{
				maximumNumberOfFlowersToDry_ = num3;
			}
			if ((long)other.areaSpecification_ != 0)
			{
				SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification2 = default(SpawnRecurringEventAreaSpecification);
				if (areaSpecification_ == null)
				{
					SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
					spawnRecurringEventAreaSpecification2 = areaSpecification_;
				}
				SpawnRecurringEventAreaSpecification other3 = other.areaSpecification_;
				spawnRecurringEventAreaSpecification2.MergeFrom(other3);
			}
			int num4 = other.maximumAmount_;
			if (num4 != 0)
			{
				maximumAmount_ = num4;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE9")]
		[Cpp2IlInjected.Address(RVA = "0x35813C0", Offset = "0x357FDC0", VA = "0x1835813C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_017a
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 48)
			{
				if ((int)num > 72)
				{
					if (num == 80)
					{
						int num2 = (maximumNumberOfFlowersToDry_ = input.ReadInt32());
					}
					SpawnRecurringEventAreaSpecification spawnRecurringEventAreaSpecification = default(SpawnRecurringEventAreaSpecification);
					if (num == 90)
					{
						SpawnRecurringEventAreaSpecification builder = default(SpawnRecurringEventAreaSpecification);
						if (areaSpecification_ == null)
						{
							spawnRecurringEventAreaSpecification = (areaSpecification_ = new SpawnRecurringEventAreaSpecification());
							builder = areaSpecification_;
						}
						input.ReadMessage(builder);
					}
					if ((long)spawnRecurringEventAreaSpecification != 96)
					{
						goto IL_0163;
					}
					int num3 = (maximumAmount_ = input.ReadInt32());
				}
				RecurringEventIntervalData recurringEventIntervalData = default(RecurringEventIntervalData);
				if (num == 58)
				{
					RecurringEventIntervalData builder2 = default(RecurringEventIntervalData);
					if (intervalData_ == null)
					{
						recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
						builder2 = intervalData_;
					}
					input.ReadMessage(builder2);
				}
				bool flag = default(bool);
				if ((long)recurringEventIntervalData == 64)
				{
					flag = (executeOnAdd_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0163;
				}
				int num4 = (minimumNumberOfFlowersToDry_ = input.ReadInt32());
			}
			bool flag2 = default(bool);
			if ((int)num > 26)
			{
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 48)
				{
					goto IL_0163;
				}
				flag2 = (activeByDefault_ = input.ReadBool());
			}
			int num5 = default(int);
			if (flag2)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num5 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_0163;
			IL_0163:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEA")]
		[Cpp2IlInjected.Address(RVA = "0x3581050", Offset = "0x357FA50", VA = "0x183581050", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEB")]
		[Cpp2IlInjected.Address(RVA = "0x3581890", Offset = "0x3580290", VA = "0x183581890", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0039, IL_003a, IL_003b, IL_003c, IL_0044, IL_004a, IL_0050, IL_0056, IL_005c, IL_0062, IL_0068, IL_006e
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEC")]
		[Cpp2IlInjected.Address(RVA = "0x3580B90", Offset = "0x357F590", VA = "0x183580B90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 11)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEE")]
		[Cpp2IlInjected.Address(RVA = "0x3580D20", Offset = "0x357F720", VA = "0x183580D20", Slot = "23")]
		IItemData IItemData.Clone()
		{
			FlowerDryingInVillageRecurringEventItemData flowerDryingInVillageRecurringEventItemData = new FlowerDryingInVillageRecurringEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BEF")]
		[Cpp2IlInjected.Address(RVA = "0x3580D80", Offset = "0x357F780", VA = "0x183580D80", Slot = "24")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001c
			int num = minimumNumberOfFlowersToDry_;
			if (maximumNumberOfFlowersToDry_ < num)
			{
				context.AddError("MinimumNumberOfFlowersToDry cannot be higher than MaximumNumberOfFlowersToDry");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF0")]
		[Cpp2IlInjected.Address(RVA = "0x3581F40", Offset = "0x3580940", VA = "0x183581F40")]
		static FlowerDryingInVillageRecurringEventItemData()
		{
			Func<FlowerDryingInVillageRecurringEventItemData> func = default(Func<FlowerDryingInVillageRecurringEventItemData>);
			_parser = (MessageParser<FlowerDryingInVillageRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
