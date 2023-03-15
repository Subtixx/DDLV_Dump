using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003B0")]
	public sealed class FishSpawningInVillageRecurringEventItemData : IMessage<FishSpawningInVillageRecurringEventItemData>, IMessage, IEquatable<FishSpawningInVillageRecurringEventItemData>, IDeepCloneable<FishSpawningInVillageRecurringEventItemData>, IMessageFieldAccessor, IRecurringEventData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x40012F4")]
		private static readonly MessageParser<FishSpawningInVillageRecurringEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40012F5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40012F6")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40012F7")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40012F8")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40012F9")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40012FA")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40012FB")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40012FC")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40012FD")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40012FE")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40012FF")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001300")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001301")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x4001302")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001303")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x4001304")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001305")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x4001306")]
		public const int LocationFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001307")]
		private OptionalField location_;

		[Cpp2IlInjected.Token(Token = "0x4001308")]
		public const int ExclusionListFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4001309")]
		private static readonly FieldCodec<VillageAreaType> _repeated_exclusionList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400130A")]
		private readonly RepeatedField<VillageAreaType> exclusionList_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400130B")]
		public const int MaxNumberOfPendingFishesFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400130C")]
		private int maxNumberOfPendingFishes_;

		[Cpp2IlInjected.Token(Token = "0x17000AC6")]
		[DebuggerNonUserCode]
		public static MessageParser<FishSpawningInVillageRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002B61")]
			[Cpp2IlInjected.Address(RVA = "0x357AEB0", Offset = "0x35798B0", VA = "0x18357AEB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B62")]
			[Cpp2IlInjected.Address(RVA = "0x357ADE0", Offset = "0x35797E0", VA = "0x18357ADE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002B63")]
			[Cpp2IlInjected.Address(RVA = "0x357AF10", Offset = "0x3579910", VA = "0x18357AF10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC9")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002B68")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B69")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ACA")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002B6A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B6B")]
			[Cpp2IlInjected.Address(RVA = "0x357B100", Offset = "0x3579B00", VA = "0x18357B100")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ACB")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002B6C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "20")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B6D")]
			[Cpp2IlInjected.Address(RVA = "0x357B020", Offset = "0x3579A20", VA = "0x18357B020")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ACC")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002B6E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B6F")]
			[Cpp2IlInjected.Address(RVA = "0x357B090", Offset = "0x3579A90", VA = "0x18357B090")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ACD")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002B70")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "22")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B71")]
			[Cpp2IlInjected.Address(RVA = "0x357B170", Offset = "0x3579B70", VA = "0x18357B170")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ACE")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002B72")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "14")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B73")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ACF")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002B74")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B75")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD0")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002B76")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "16")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B77")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD1")]
		[DebuggerNonUserCode]
		public OptionalField Location
		{
			[Cpp2IlInjected.Token(Token = "0x6002B78")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B79")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD2")]
		[DebuggerNonUserCode]
		public RepeatedField<VillageAreaType> ExclusionList
		{
			[Cpp2IlInjected.Token(Token = "0x6002B7A")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return exclusionList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD3")]
		[DebuggerNonUserCode]
		public int MaxNumberOfPendingFishes
		{
			[Cpp2IlInjected.Token(Token = "0x6002B7B")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return maxNumberOfPendingFishes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B7C")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				maxNumberOfPendingFishes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD4")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002B88")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B64")]
		[Cpp2IlInjected.Address(RVA = "0x357AC70", Offset = "0x3579670", VA = "0x18357AC70")]
		[DebuggerNonUserCode]
		public FishSpawningInVillageRecurringEventItemData()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			OptionalField optionalField = new OptionalField
			{
				useField_ = false
			};
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			location_ = optionalField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B65")]
		[Cpp2IlInjected.Address(RVA = "0x357A060", Offset = "0x3578A60", VA = "0x18357A060")]
		private void OnConstruction()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = false;
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			location_ = optionalField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B66")]
		[Cpp2IlInjected.Address(RVA = "0x357A9D0", Offset = "0x35793D0", VA = "0x18357A9D0")]
		[DebuggerNonUserCode]
		public FishSpawningInVillageRecurringEventItemData(FishSpawningInVillageRecurringEventItemData other)
		{
			//IL_00f1: Expected O, but got I4
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			OptionalField optionalField = new OptionalField
			{
				useField_ = false
			};
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			location_ = optionalField;
			int num2 = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			bool flag = other.activeByDefault_;
			int num3 = 0;
			activeByDefault_ = flag;
			RecurringEventIntervalData recurringEventIntervalData2 = other.intervalData_;
			if (recurringEventIntervalData2 != null)
			{
				RecurringEventIntervalData recurringEventIntervalData3 = recurringEventIntervalData2.Clone();
			}
			intervalData_ = (RecurringEventIntervalData)num3;
			bool flag2 = (executeOnAdd_ = other.executeOnAdd_);
			OptionalField optionalField2 = other.location_;
			OptionalField optionalField3 = default(OptionalField);
			if (optionalField2 != null)
			{
				optionalField3 = optionalField2.Clone();
			}
			location_ = optionalField3;
			RepeatedField<VillageAreaType> repeatedField = (exclusionList_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)other.exclusionList_).Clone());
			int num4 = (maxNumberOfPendingFishes_ = other.maxNumberOfPendingFishes_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B67")]
		[Cpp2IlInjected.Address(RVA = "0x3579540", Offset = "0x3577F40", VA = "0x183579540", Slot = "10")]
		[DebuggerNonUserCode]
		public FishSpawningInVillageRecurringEventItemData Clone()
		{
			return new FishSpawningInVillageRecurringEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7D")]
		[Cpp2IlInjected.Address(RVA = "0x35796F0", Offset = "0x35780F0", VA = "0x1835796F0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(FishSpawningInVillageRecurringEventItemData).TypeHandle)
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
									if (flag5 && executeOnAdd_ == flag5 && object.Equals(location_, other))
									{
										RepeatedField<VillageAreaType> repeatedField = exclusionList_;
										bool flag6 = default(bool);
										if (flag6 && maxNumberOfPendingFishes_ == (flag6 ? 1 : 0))
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7E")]
		[Cpp2IlInjected.Address(RVA = "0x35795A0", Offset = "0x3577FA0", VA = "0x1835795A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FishSpawningInVillageRecurringEventItemData other)
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
												OptionalField objB2 = other.location_;
												if (object.Equals(location_, objB2))
												{
													RepeatedField<VillageAreaType> repeatedField = exclusionList_;
													RepeatedField<VillageAreaType> repeatedField2 = other.exclusionList_;
													if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
													{
														int num2 = other.maxNumberOfPendingFishes_;
														if (maxNumberOfPendingFishes_ == num2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7F")]
		[Cpp2IlInjected.Address(RVA = "0x3579A20", Offset = "0x3578420", VA = "0x183579A20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00dd
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
			OptionalField optionalField = location_;
			if (optionalField != null)
			{
				int hashCode6 = optionalField.GetHashCode();
			}
			int hashCode7 = ((RepeatedField<T>)(object)exclusionList_).GetHashCode();
			if (maxNumberOfPendingFishes_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B80")]
		[Cpp2IlInjected.Address(RVA = "0x357A4B0", Offset = "0x3578EB0", VA = "0x18357A4B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B81")]
		[Cpp2IlInjected.Address(RVA = "0x357A510", Offset = "0x3578F10", VA = "0x18357A510", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0139
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
			if ((long)location_ != 0)
			{
				OptionalField value9 = location_;
				output.WriteMessage(value9);
			}
			RepeatedField<VillageAreaType> repeatedField = exclusionList_;
			FieldCodec<VillageAreaType> repeated_exclusionList_codec = _repeated_exclusionList_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_exclusionList_codec);
			if (maxNumberOfPendingFishes_ != 0)
			{
				int value10 = maxNumberOfPendingFishes_;
				output.WriteInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B82")]
		[Cpp2IlInjected.Address(RVA = "0x3579100", Offset = "0x3577B00", VA = "0x183579100", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0148
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
			OptionalField optionalField = location_;
			if (optionalField != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(optionalField);
				num9++;
				num2 += num9;
			}
			RepeatedField<VillageAreaType> repeatedField = exclusionList_;
			FieldCodec<VillageAreaType> repeated_exclusionList_codec = _repeated_exclusionList_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_exclusionList_codec);
			int num11 = maxNumberOfPendingFishes_;
			num2 += num10;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B83")]
		[Cpp2IlInjected.Address(RVA = "0x3579BC0", Offset = "0x35785C0", VA = "0x183579BC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishSpawningInVillageRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_0168
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
			if ((long)other.location_ != 0)
			{
				OptionalField optionalField2 = default(OptionalField);
				if (location_ == null)
				{
					OptionalField optionalField = (location_ = new OptionalField());
					optionalField2 = location_;
				}
				OptionalField other3 = other.location_;
				optionalField2.MergeFrom(other3);
			}
			RepeatedField<VillageAreaType> repeatedField = exclusionList_;
			RepeatedField<VillageAreaType> repeatedField2 = other.exclusionList_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num2 = other.maxNumberOfPendingFishes_;
			if (num2 != 0)
			{
				maxNumberOfPendingFishes_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002B84")]
		[Cpp2IlInjected.Address(RVA = "0x3579DB0", Offset = "0x35787B0", VA = "0x183579DB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_016d
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 48)
			{
				if ((int)num > 74)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 88)
						{
							goto IL_0156;
						}
						int num2 = (maxNumberOfPendingFishes_ = input.ReadInt32());
					}
					RepeatedField<VillageAreaType> repeatedField = exclusionList_;
					FieldCodec<VillageAreaType> repeated_exclusionList_codec = _repeated_exclusionList_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_exclusionList_codec);
				}
				if (num == 58)
				{
					RecurringEventIntervalData recurringEventIntervalData = intervalData_;
					if (recurringEventIntervalData == null)
					{
						RecurringEventIntervalData recurringEventIntervalData2 = (intervalData_ = new RecurringEventIntervalData());
					}
					input.ReadMessage(recurringEventIntervalData);
				}
				bool flag = default(bool);
				if (num == 64)
				{
					flag = (executeOnAdd_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0156;
				}
				OptionalField builder = default(OptionalField);
				if (location_ == null)
				{
					OptionalField optionalField = (location_ = new OptionalField());
					builder = location_;
				}
				input.ReadMessage(builder);
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
					goto IL_0156;
				}
				flag2 = (activeByDefault_ = input.ReadBool());
			}
			int num3 = default(int);
			if (flag2)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num3 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_0156;
			IL_0156:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002B85")]
		[Cpp2IlInjected.Address(RVA = "0x3579880", Offset = "0x3578280", VA = "0x183579880", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B86")]
		[Cpp2IlInjected.Address(RVA = "0x357A110", Offset = "0x3578B10", VA = "0x18357A110", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0039, IL_003a, IL_0042, IL_0048, IL_004e, IL_0054, IL_005a, IL_0060, IL_0066, IL_006c
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B87")]
		[Cpp2IlInjected.Address(RVA = "0x35793A0", Offset = "0x3577DA0", VA = "0x1835793A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_001a
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 10)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B89")]
		[Cpp2IlInjected.Address(RVA = "0x3579540", Offset = "0x3577F40", VA = "0x183579540", Slot = "23")]
		IItemData IItemData.Clone()
		{
			FishSpawningInVillageRecurringEventItemData fishSpawningInVillageRecurringEventItemData = new FishSpawningInVillageRecurringEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B8A")]
		[Cpp2IlInjected.Address(RVA = "0x357A7B0", Offset = "0x35791B0", VA = "0x18357A7B0")]
		static FishSpawningInVillageRecurringEventItemData()
		{
			Func<FishSpawningInVillageRecurringEventItemData> func = default(Func<FishSpawningInVillageRecurringEventItemData>);
			MessageParser<FishSpawningInVillageRecurringEventItemData> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<FishSpawningInVillageRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<VillageAreaType, int> func2 = (Func<VillageAreaType, int>)(object)(Func<T, TResult>)((VillageAreaType x) => (int)x);
			Func<int, VillageAreaType> func3 = (Func<int, VillageAreaType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<FishSpawningInVillageRecurringEventItemData>)(object)FieldCodec.ForEnum<VillageAreaType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
