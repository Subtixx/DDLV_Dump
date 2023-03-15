using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Shops
{
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	public sealed class Shop : IMessage<Shop>, IMessage, IEquatable<Shop>, IDeepCloneable<Shop>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		private static readonly MessageParser<Shop> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public const int SlotsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private static readonly FieldCodec<ShopSlot> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private readonly RepeatedField<ShopSlot> slots_ = (RepeatedField<ShopSlot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public const int FatigueFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private AnyFatigue fatigue_;

		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public const int RefreshCostFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private CurrencyCost refreshCost_;

		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public const int RefreshBaseIncreaseFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private int refreshBaseIncrease_;

		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public const int RefreshIncreasePercentFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private int refreshIncreasePercent_;

		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public const int RefreshIncreaseCapFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private int refreshIncreaseCap_;

		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public const int SupportsDailySellCapFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private bool supportsDailySellCap_;

		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public const int IsDispenserFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private bool isDispenser_;

		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public const int RestrictItemsToCurrentSceneFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private bool restrictItemsToCurrentScene_;

		[Cpp2IlInjected.Token(Token = "0x1700036A")]
		[DebuggerNonUserCode]
		public static MessageParser<Shop> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2F")]
			[Cpp2IlInjected.Address(RVA = "0x38514D0", Offset = "0x384FED0", VA = "0x1838514D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E30")]
			[Cpp2IlInjected.Address(RVA = "0x3851400", Offset = "0x384FE00", VA = "0x183851400")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E31")]
			[Cpp2IlInjected.Address(RVA = "0x3851530", Offset = "0x384FF30", VA = "0x183851530", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036D")]
		[DebuggerNonUserCode]
		public RepeatedField<ShopSlot> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x6000E36")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036E")]
		[DebuggerNonUserCode]
		public AnyFatigue Fatigue
		{
			[Cpp2IlInjected.Token(Token = "0x6000E37")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return fatigue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E38")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				fatigue_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036F")]
		[DebuggerNonUserCode]
		public CurrencyCost RefreshCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000E39")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return refreshCost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E3A")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				refreshCost_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000370")]
		[DebuggerNonUserCode]
		public int RefreshBaseIncrease
		{
			[Cpp2IlInjected.Token(Token = "0x6000E3B")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return refreshBaseIncrease_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E3C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				refreshBaseIncrease_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000371")]
		[DebuggerNonUserCode]
		public int RefreshIncreasePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000E3D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return refreshIncreasePercent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E3E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				refreshIncreasePercent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000372")]
		[DebuggerNonUserCode]
		public int RefreshIncreaseCap
		{
			[Cpp2IlInjected.Token(Token = "0x6000E3F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return refreshIncreaseCap_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E40")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				refreshIncreaseCap_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000373")]
		[DebuggerNonUserCode]
		public bool SupportsDailySellCap
		{
			[Cpp2IlInjected.Token(Token = "0x6000E41")]
			[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
			get
			{
				return supportsDailySellCap_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E42")]
			[Cpp2IlInjected.Address(RVA = "0xA15800", Offset = "0xA14200", VA = "0x180A15800")]
			set
			{
				supportsDailySellCap_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000374")]
		[DebuggerNonUserCode]
		public bool IsDispenser
		{
			[Cpp2IlInjected.Token(Token = "0x6000E43")]
			[Cpp2IlInjected.Address(RVA = "0xBBB1C0", Offset = "0xBB9BC0", VA = "0x180BBB1C0")]
			get
			{
				return isDispenser_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E44")]
			[Cpp2IlInjected.Address(RVA = "0xBBB230", Offset = "0xBB9C30", VA = "0x180BBB230")]
			set
			{
				isDispenser_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000375")]
		[DebuggerNonUserCode]
		public bool RestrictItemsToCurrentScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000E45")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FB40", Offset = "0x1A1E540", VA = "0x181A1FB40")]
			get
			{
				return restrictItemsToCurrentScene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E46")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FCE0", Offset = "0x1A1E6E0", VA = "0x181A1FCE0")]
			set
			{
				restrictItemsToCurrentScene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E32")]
		[Cpp2IlInjected.Address(RVA = "0x38510C0", Offset = "0x384FAC0", VA = "0x1838510C0")]
		[DebuggerNonUserCode]
		public Shop()
		{
			//Discarded unreachable code: IL_0058
			//IL_0028: Expected I4, but got O
			//IL_0032: Expected I4, but got I8
			//IL_0043: Expected I4, but got I8
			//IL_004d: Expected I4, but got I8
			//IL_0057: Expected I4, but got I8
			CurrencyCost currencyCost = new CurrencyCost();
			int num = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			currencyCost.id_ = (int)softCurrencyItem;
			currencyCost.amount_ = 50;
			refreshCost_ = currencyCost;
			refreshBaseIncrease_ = 10;
			refreshIncreasePercent_ = 100;
			refreshIncreaseCap_ = 10;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E33")]
		[Cpp2IlInjected.Address(RVA = "0x38508D0", Offset = "0x384F2D0", VA = "0x1838508D0")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_0045
			//IL_0015: Expected I4, but got O
			//IL_001f: Expected I4, but got I8
			//IL_0030: Expected I4, but got I8
			//IL_003a: Expected I4, but got I8
			//IL_0044: Expected I4, but got I8
			CurrencyCost currencyCost = new CurrencyCost();
			int num = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			currencyCost.id_ = (int)softCurrencyItem;
			currencyCost.amount_ = 50;
			refreshCost_ = currencyCost;
			refreshBaseIncrease_ = 10;
			refreshIncreasePercent_ = 100;
			refreshIncreaseCap_ = 10;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E34")]
		[Cpp2IlInjected.Address(RVA = "0x38511E0", Offset = "0x384FBE0", VA = "0x1838511E0")]
		[DebuggerNonUserCode]
		public Shop(Shop other)
		{
			//IL_0028: Expected I4, but got O
			//IL_0032: Expected I4, but got I8
			//IL_0043: Expected I4, but got I8
			//IL_004d: Expected I4, but got I8
			//IL_0057: Expected I4, but got I8
			//IL_008d: Expected O, but got I4
			CurrencyCost currencyCost = new CurrencyCost();
			int num = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			currencyCost.id_ = (int)softCurrencyItem;
			currencyCost.amount_ = 50;
			refreshCost_ = currencyCost;
			refreshBaseIncrease_ = 10;
			refreshIncreasePercent_ = 100;
			refreshIncreaseCap_ = 10;
			RepeatedField<ShopSlot> repeatedField = (slots_ = (RepeatedField<ShopSlot>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			AnyFatigue anyFatigue = other.fatigue_;
			int num2 = 0;
			if (anyFatigue != null)
			{
				AnyFatigue anyFatigue2 = anyFatigue.Clone();
			}
			fatigue_ = (AnyFatigue)num2;
			CurrencyCost currencyCost2 = other.refreshCost_;
			CurrencyCost currencyCost3 = default(CurrencyCost);
			if (currencyCost2 != null)
			{
				currencyCost3 = currencyCost2.Clone();
			}
			refreshCost_ = currencyCost3;
			int num3 = (refreshBaseIncrease_ = other.refreshBaseIncrease_);
			int num4 = (refreshIncreasePercent_ = other.refreshIncreasePercent_);
			int num5 = (refreshIncreaseCap_ = other.refreshIncreaseCap_);
			bool flag = (supportsDailySellCap_ = other.supportsDailySellCap_);
			bool flag2 = (isDispenser_ = other.isDispenser_);
			bool flag3 = (restrictItemsToCurrentScene_ = other.restrictItemsToCurrentScene_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E35")]
		[Cpp2IlInjected.Address(RVA = "0x384FD90", Offset = "0x384E790", VA = "0x18384FD90", Slot = "10")]
		[DebuggerNonUserCode]
		public Shop Clone()
		{
			return new Shop(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E47")]
		[Cpp2IlInjected.Address(RVA = "0x384FEF0", Offset = "0x384E8F0", VA = "0x18384FEF0", Slot = "0")]
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
				RepeatedField<ShopSlot> repeatedField = slots_;
				bool flag = default(bool);
				if (flag && object.Equals(fatigue_, other))
				{
					bool flag2 = object.Equals(refreshCost_, other);
					if (flag2 && refreshBaseIncrease_ == (flag2 ? 1 : 0) && refreshIncreasePercent_ == (flag2 ? 1 : 0) && refreshIncreaseCap_ == (flag2 ? 1 : 0) && supportsDailySellCap_ == flag2 && isDispenser_ == flag2 && restrictItemsToCurrentScene_ == flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E48")]
		[Cpp2IlInjected.Address(RVA = "0x384FDF0", Offset = "0x384E7F0", VA = "0x18384FDF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Shop other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ShopSlot> repeatedField = slots_;
				RepeatedField<ShopSlot> repeatedField2 = other.slots_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					AnyFatigue objB = other.fatigue_;
					if (object.Equals(fatigue_, objB))
					{
						CurrencyCost objB2 = other.refreshCost_;
						if (object.Equals(refreshCost_, objB2))
						{
							int num = other.refreshBaseIncrease_;
							if (refreshBaseIncrease_ == num)
							{
								int num2 = other.refreshIncreasePercent_;
								if (refreshIncreasePercent_ == num2)
								{
									int num3 = other.refreshIncreaseCap_;
									if (refreshIncreaseCap_ == num3)
									{
										bool flag = other.supportsDailySellCap_;
										if (supportsDailySellCap_ == flag)
										{
											bool flag2 = other.isDispenser_;
											if (isDispenser_ == flag2)
											{
												bool flag3 = other.restrictItemsToCurrentScene_;
												if (restrictItemsToCurrentScene_ == flag3)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E49")]
		[Cpp2IlInjected.Address(RVA = "0x38501D0", Offset = "0x384EBD0", VA = "0x1838501D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0087
			int hashCode = ((RepeatedField<T>)(object)slots_).GetHashCode();
			AnyFatigue anyFatigue = fatigue_;
			if (anyFatigue != null)
			{
				int hashCode2 = anyFatigue.GetHashCode();
			}
			CurrencyCost currencyCost = refreshCost_;
			if (currencyCost != null)
			{
				int hashCode3 = currencyCost.GetHashCode();
			}
			if (refreshBaseIncrease_ != 0)
			{
			}
			if (refreshIncreasePercent_ != 0)
			{
			}
			if (refreshIncreaseCap_ != 0)
			{
			}
			if (supportsDailySellCap_)
			{
			}
			if (isDispenser_)
			{
			}
			if (restrictItemsToCurrentScene_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4A")]
		[Cpp2IlInjected.Address(RVA = "0x3850C80", Offset = "0x384F680", VA = "0x183850C80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4B")]
		[Cpp2IlInjected.Address(RVA = "0x3850CE0", Offset = "0x384F6E0", VA = "0x183850CE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f3
			RepeatedField<ShopSlot> repeatedField = slots_;
			FieldCodec<ShopSlot> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			if ((long)fatigue_ != 0)
			{
				AnyFatigue value = fatigue_;
				output.WriteMessage(value);
			}
			if ((long)refreshCost_ != 0)
			{
				CurrencyCost value2 = refreshCost_;
				output.WriteMessage(value2);
			}
			if (refreshBaseIncrease_ != 0)
			{
				int value3 = refreshBaseIncrease_;
				output.WriteInt32(value3);
			}
			if (refreshIncreasePercent_ != 0)
			{
				int value4 = refreshIncreasePercent_;
				output.WriteInt32(value4);
			}
			if (refreshIncreaseCap_ != 0)
			{
				int value5 = refreshIncreaseCap_;
				output.WriteInt32(value5);
			}
			if (supportsDailySellCap_)
			{
				bool value6 = supportsDailySellCap_;
				output.WriteBool(value6);
			}
			if (isDispenser_)
			{
				bool value7 = isDispenser_;
				output.WriteBool(value7);
			}
			if (restrictItemsToCurrentScene_)
			{
				bool value8 = restrictItemsToCurrentScene_;
				output.WriteBool(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4C")]
		[Cpp2IlInjected.Address(RVA = "0x384FA70", Offset = "0x384E470", VA = "0x18384FA70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0100
			RepeatedField<ShopSlot> repeatedField = slots_;
			FieldCodec<ShopSlot> repeated_slots_codec = _repeated_slots_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			AnyFatigue anyFatigue = fatigue_;
			if (anyFatigue != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(anyFatigue);
				num2++;
				num += num2;
			}
			CurrencyCost currencyCost = refreshCost_;
			if (currencyCost != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(currencyCost);
				num3++;
				num += num3;
			}
			int num4 = refreshBaseIncrease_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			int num6 = refreshIncreasePercent_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			int num8 = refreshIncreaseCap_;
			int num9 = default(int);
			if (num8 != 0)
			{
				num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num += num9;
			}
			if (!supportsDailySellCap_)
			{
				num9 = num;
			}
			if (!isDispenser_)
			{
				num8 = num9;
			}
			if (!restrictItemsToCurrentScene_)
			{
				num = num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num += num10;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4D")]
		[Cpp2IlInjected.Address(RVA = "0x38504E0", Offset = "0x384EEE0", VA = "0x1838504E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Shop other)
		{
			//Discarded unreachable code: IL_0131
			if (other == null)
			{
				return;
			}
			RepeatedField<ShopSlot> repeatedField = slots_;
			RepeatedField<ShopSlot> repeatedField2 = other.slots_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.fatigue_ != 0)
			{
				AnyFatigue anyFatigue = fatigue_;
				if (anyFatigue == null)
				{
					AnyFatigue anyFatigue2 = (fatigue_ = new AnyFatigue());
					AnyFatigue anyFatigue3 = fatigue_;
				}
				AnyFatigue other2 = other.fatigue_;
				anyFatigue.MergeFrom(other2);
			}
			if ((long)other.refreshCost_ != 0)
			{
				CurrencyCost currencyCost2 = default(CurrencyCost);
				if (refreshCost_ == null)
				{
					CurrencyCost currencyCost = (refreshCost_ = new CurrencyCost());
					currencyCost2 = refreshCost_;
				}
				CurrencyCost other3 = other.refreshCost_;
				currencyCost2.MergeFrom(other3);
			}
			int num = other.refreshBaseIncrease_;
			if (num != 0)
			{
				refreshBaseIncrease_ = num;
			}
			int num2 = other.refreshIncreasePercent_;
			if (num2 != 0)
			{
				refreshIncreasePercent_ = num2;
			}
			int num3 = other.refreshIncreaseCap_;
			if (num3 != 0)
			{
				refreshIncreaseCap_ = num3;
			}
			bool flag = other.supportsDailySellCap_;
			if (flag)
			{
				supportsDailySellCap_ = flag;
			}
			bool flag2 = other.isDispenser_;
			if (flag2)
			{
				isDispenser_ = flag2;
			}
			bool flag3 = other.restrictItemsToCurrentScene_;
			if (flag3)
			{
				restrictItemsToCurrentScene_ = flag3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4E")]
		[Cpp2IlInjected.Address(RVA = "0x3850680", Offset = "0x384F080", VA = "0x183850680", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0137
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 32)
			{
				if ((int)num > 48)
				{
					if (num == 56)
					{
						bool flag = (supportsDailySellCap_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 64)
					{
						flag2 = (isDispenser_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_0120;
					}
					bool flag3 = (restrictItemsToCurrentScene_ = input.ReadBool());
				}
				int num2 = default(int);
				if (num == 40)
				{
					num2 = (refreshIncreasePercent_ = input.ReadInt32());
				}
				if (num2 != 48)
				{
					goto IL_0120;
				}
				int num3 = (refreshIncreaseCap_ = input.ReadInt32());
			}
			int num4 = default(int);
			if ((int)num > 18)
			{
				CurrencyCost currencyCost = default(CurrencyCost);
				if (num == 26)
				{
					CurrencyCost builder = default(CurrencyCost);
					if (refreshCost_ == null)
					{
						currencyCost = (refreshCost_ = new CurrencyCost());
						builder = refreshCost_;
					}
					input.ReadMessage(builder);
				}
				if ((long)currencyCost != 32)
				{
					goto IL_0120;
				}
				num4 = (refreshBaseIncrease_ = input.ReadInt32());
			}
			if (num4 == 10)
			{
				RepeatedField<ShopSlot> repeatedField = slots_;
				FieldCodec<ShopSlot> repeated_slots_codec = _repeated_slots_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
			}
			if (num4 == 18)
			{
				AnyFatigue builder2 = default(AnyFatigue);
				if (fatigue_ == null)
				{
					AnyFatigue anyFatigue = (fatigue_ = new AnyFatigue());
					builder2 = fatigue_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_0120;
			IL_0120:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4F")]
		[Cpp2IlInjected.Address(RVA = "0x3850030", Offset = "0x384EA30", VA = "0x183850030", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				RepeatedField<ShopSlot> repeatedField = slots_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E50")]
		[Cpp2IlInjected.Address(RVA = "0x3850990", Offset = "0x384F390", VA = "0x183850990", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0020, IL_0028, IL_0030, IL_0038, IL_0040, IL_0048
			//IL_0017: Expected O, but got I4
			while (fieldNumber - 1 <= 8)
			{
				int num = 0;
				if (value == null || value != null)
				{
					fatigue_ = (AnyFatigue)num;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0x384FC50", Offset = "0x384E650", VA = "0x18384FC50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0013
			if (fieldNumber - 1 <= 8)
			{
				RepeatedField<ShopSlot> repeatedField = slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0x3850310", Offset = "0x384ED10", VA = "0x183850310")]
		public unsafe CurrencyCost GetRefreshCost(int numRefresh)
		{
			//Discarded unreachable code: IL_0094
			int num = 0;
			int amount_ = refreshCost_.amount_;
			int num2 = refreshBaseIncrease_;
			int num3 = Math.Min(numRefresh, numRefresh);
			int num4 = refreshIncreasePercent_;
			amount_ += num2;
			num4 += 100;
			CurrencyCost currencyCost = refreshCost_;
			ulong num5 = num5 + num5;
			Item item = currencyCost.Item;
			int num6 = 0;
			Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			if (*(Item*)item != *(Item*)hardCurrencyItem)
			{
				ulong num7 = num7 + num7;
				num5 += num5;
			}
			CurrencyCost currencyCost2 = new CurrencyCost();
			int id_ = refreshCost_.id_;
			currencyCost2.amount_ = amount_;
			currencyCost2.id_ = id_;
			return currencyCost2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0x3850EF0", Offset = "0x384F8F0", VA = "0x183850EF0")]
		static Shop()
		{
			Func<Shop> func = default(Func<Shop>);
			_parser = (MessageParser<Shop>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ShopSlot> parser = ShopSlot._parser;
			uint num = default(uint);
			_parser = (MessageParser<Shop>)(object)FieldCodec.ForMessage<ShopSlot>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
