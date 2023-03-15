using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003B6")]
	public sealed class ChooseVillageAreaRecurringEventItemData : IMessage<ChooseVillageAreaRecurringEventItemData>, IMessage, IEquatable<ChooseVillageAreaRecurringEventItemData>, IDeepCloneable<ChooseVillageAreaRecurringEventItemData>, IMessageFieldAccessor, IRecurringEventData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x4001349")]
		private static readonly MessageParser<ChooseVillageAreaRecurringEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400134A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400134B")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400134C")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x400134D")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400134E")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400134F")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001350")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001351")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001352")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001353")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001354")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001355")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001356")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x4001357")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001358")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x4001359")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400135A")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x400135B")]
		public const int ItemsToCheckFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x400135C")]
		private static readonly FieldCodec<int> _repeated_itemsToCheck_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400135D")]
		private readonly RepeatedField<int> itemsToCheck_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400135E")]
		public const int MaximumItemPerAreaFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400135F")]
		private int maximumItemPerArea_;

		[Cpp2IlInjected.Token(Token = "0x17000AF7")]
		[DebuggerNonUserCode]
		public static MessageParser<ChooseVillageAreaRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF4")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCC70", Offset = "0x2EBB670", VA = "0x182EBCC70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF5")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCBA0", Offset = "0x2EBB5A0", VA = "0x182EBCBA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AF9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF6")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCCD0", Offset = "0x2EBB6D0", VA = "0x182EBCCD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFA")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BFC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFB")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BFE")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCEC0", Offset = "0x2EBB8C0", VA = "0x182EBCEC0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFC")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "20")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C00")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCDE0", Offset = "0x2EBB7E0", VA = "0x182EBCDE0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFD")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002C01")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C02")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCE50", Offset = "0x2EBB850", VA = "0x182EBCE50")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFE")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002C03")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "22")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C04")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCF30", Offset = "0x2EBB930", VA = "0x182EBCF30")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFF")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002C05")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "14")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C06")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B00")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002C07")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "15")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C08")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B01")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002C09")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "16")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C0A")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B02")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemsToCheck
		{
			[Cpp2IlInjected.Token(Token = "0x6002C0B")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return itemsToCheck_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B03")]
		[DebuggerNonUserCode]
		public int MaximumItemPerArea
		{
			[Cpp2IlInjected.Token(Token = "0x6002C0C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return maximumItemPerArea_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C0D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				maximumItemPerArea_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B04")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002C19")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF7")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC850", Offset = "0x2EBB250", VA = "0x182EBC850")]
		[DebuggerNonUserCode]
		public ChooseVillageAreaRecurringEventItemData()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF8")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC090", Offset = "0x2EBAA90", VA = "0x182EBC090")]
		private void OnConstruction()
		{
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF9")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC970", Offset = "0x2EBB370", VA = "0x182EBC970")]
		[DebuggerNonUserCode]
		public ChooseVillageAreaRecurringEventItemData(ChooseVillageAreaRecurringEventItemData other)
		{
			//IL_00c9: Expected O, but got I4
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
			RepeatedField<int> repeatedField = (itemsToCheck_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemsToCheck_).Clone());
			int num3 = (maximumItemPerArea_ = other.maximumItemPerArea_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BFA")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB680", Offset = "0x2EBA080", VA = "0x182EBB680", Slot = "10")]
		[DebuggerNonUserCode]
		public ChooseVillageAreaRecurringEventItemData Clone()
		{
			return new ChooseVillageAreaRecurringEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB6E0", Offset = "0x2EBA0E0", VA = "0x182EBB6E0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(ChooseVillageAreaRecurringEventItemData).TypeHandle)
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
										RepeatedField<int> repeatedField = itemsToCheck_;
										bool flag6 = default(bool);
										if (flag6 && maximumItemPerArea_ == (flag6 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x6002C0F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB850", Offset = "0x2EBA250", VA = "0x182EBB850", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChooseVillageAreaRecurringEventItemData other)
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
												RepeatedField<int> repeatedField = itemsToCheck_;
												RepeatedField<int> repeatedField2 = other.itemsToCheck_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													int num2 = other.maximumItemPerArea_;
													if (maximumItemPerArea_ == num2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C10")]
		[Cpp2IlInjected.Address(RVA = "0x2EBBB10", Offset = "0x2EBA510", VA = "0x182EBBB10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c7
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
			int hashCode6 = ((RepeatedField<T>)(object)itemsToCheck_).GetHashCode();
			if (maximumItemPerArea_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C11")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC440", Offset = "0x2EBAE40", VA = "0x182EBC440", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C12")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC4A0", Offset = "0x2EBAEA0", VA = "0x182EBC4A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_011e
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
			RepeatedField<int> repeatedField = itemsToCheck_;
			FieldCodec<int> repeated_itemsToCheck_codec = _repeated_itemsToCheck_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemsToCheck_codec);
			if (maximumItemPerArea_ != 0)
			{
				int value9 = maximumItemPerArea_;
				output.WriteInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C13")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB280", Offset = "0x2EB9C80", VA = "0x182EBB280", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected O, but got Unknown
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
			RepeatedField<int> repeatedField = itemsToCheck_;
			FieldCodec<int> repeated_itemsToCheck_codec = _repeated_itemsToCheck_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemsToCheck_codec);
			int num10 = maximumItemPerArea_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				repeatedField = (RepeatedField<int>)(repeatedField + num11);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<int>)(repeatedField + num12);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C14")]
		[Cpp2IlInjected.Address(RVA = "0x2EBBF00", Offset = "0x2EBA900", VA = "0x182EBBF00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChooseVillageAreaRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_012c
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
			RepeatedField<int> repeatedField = itemsToCheck_;
			RepeatedField<int> repeatedField2 = other.itemsToCheck_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num2 = other.maximumItemPerArea_;
			if (num2 != 0)
			{
				maximumItemPerArea_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C15")]
		[Cpp2IlInjected.Address(RVA = "0x2EBBCA0", Offset = "0x2EBA6A0", VA = "0x182EBBCA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0146
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 64)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 80)
						{
							goto IL_012f;
						}
						int num2 = (maximumItemPerArea_ = input.ReadInt32());
					}
					RepeatedField<int> repeatedField = itemsToCheck_;
					FieldCodec<int> repeated_itemsToCheck_codec = _repeated_itemsToCheck_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsToCheck_codec);
				}
				if (num == 48)
				{
					bool flag = (activeByDefault_ = input.ReadBool());
				}
				RecurringEventIntervalData recurringEventIntervalData = default(RecurringEventIntervalData);
				if (num == 58)
				{
					RecurringEventIntervalData builder = default(RecurringEventIntervalData);
					if (intervalData_ == null)
					{
						recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
						builder = intervalData_;
					}
					input.ReadMessage(builder);
				}
				if ((long)recurringEventIntervalData != 64)
				{
					goto IL_012f;
				}
				bool flag2 = (executeOnAdd_ = input.ReadBool());
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_012f;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text6 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_012f;
			IL_012f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C16")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB980", Offset = "0x2EBA380", VA = "0x182EBB980", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C17")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC0F0", Offset = "0x2EBAAF0", VA = "0x182EBC0F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0020, IL_0028, IL_0037, IL_003f, IL_0045, IL_004b, IL_0051, IL_0057, IL_005d, IL_0063
			//IL_000e: Expected I4, but got O
			//IL_002f: Expected O, but got I4
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C18")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB500", Offset = "0x2EB9F00", VA = "0x182EBB500", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_001a
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 9)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB680", Offset = "0x2EBA080", VA = "0x182EBB680", Slot = "23")]
		IItemData IItemData.Clone()
		{
			ChooseVillageAreaRecurringEventItemData chooseVillageAreaRecurringEventItemData = new ChooseVillageAreaRecurringEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC710", Offset = "0x2EBB110", VA = "0x182EBC710")]
		static ChooseVillageAreaRecurringEventItemData()
		{
			Func<ChooseVillageAreaRecurringEventItemData> func = default(Func<ChooseVillageAreaRecurringEventItemData>);
			_parser = (MessageParser<ChooseVillageAreaRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ChooseVillageAreaRecurringEventItemData>)(object)FieldCodec.ForInt32(74u);
			/*Error: Unexpected end of block*/;
		}
	}
}
