using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class MiniEventMilestoneData : IMessage<MiniEventMilestoneData>, IMessage, IEquatable<MiniEventMilestoneData>, IDeepCloneable<MiniEventMilestoneData>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public enum RewardOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			Currency = 5,
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			Item = 6
		}

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly MessageParser<MiniEventMilestoneData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public const int DescriptionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public const int ContainerAddressFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private string containerAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public const int ObjectiveFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private ObjectiveData objective_;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public const int CurrencyFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public const int ItemFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private object reward_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private RewardOneofCase rewardCase_;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		[DebuggerNonUserCode]
		public static MessageParser<MiniEventMilestoneData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x1D30500", Offset = "0x1D2EF00", VA = "0x181D30500")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x1D303D0", Offset = "0x1D2EDD0", VA = "0x181D303D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x1D30560", Offset = "0x1D2EF60", VA = "0x181D30560", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x1D307D0", Offset = "0x1D2F1D0", VA = "0x181D307D0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x1D30720", Offset = "0x1D2F120", VA = "0x181D30720")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		[DebuggerNonUserCode]
		public string ContainerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return containerAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x1D30670", Offset = "0x1D2F070", VA = "0x181D30670")]
			set
			{
				string text = (containerAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		[DebuggerNonUserCode]
		public ObjectiveData Objective
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return objective_;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				objective_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		[DebuggerNonUserCode]
		public CurrencyCost Currency
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1D30370", Offset = "0x1D2ED70", VA = "0x181D30370")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Currency)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x1D306E0", Offset = "0x1D2F0E0", VA = "0x181D306E0")]
			set
			{
				reward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		[DebuggerNonUserCode]
		public ItemAmount Item
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x1D304A0", Offset = "0x1D2EEA0", VA = "0x181D304A0")]
			get
			{
				int num = 0;
				if (rewardCase_ == RewardOneofCase.Item)
				{
					object obj = reward_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x1D30790", Offset = "0x1D2F190", VA = "0x181D30790")]
			set
			{
				reward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[DebuggerNonUserCode]
		public RewardOneofCase RewardCase
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return rewardCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1D30050", Offset = "0x1D2EA50", VA = "0x181D30050")]
		[DebuggerNonUserCode]
		public MiniEventMilestoneData()
		{
			ObjectiveData objectiveData = (objective_ = new ObjectiveData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FA40", Offset = "0x1D2E440", VA = "0x181D2FA40")]
		private void OnConstruction()
		{
			ObjectiveData objectiveData = (objective_ = new ObjectiveData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1D30110", Offset = "0x1D2EB10", VA = "0x181D30110")]
		[DebuggerNonUserCode]
		public MiniEventMilestoneData(MiniEventMilestoneData other)
		{
			//IL_007f: Expected O, but got I4
			//IL_00c9: Expected I4, but got O
			ObjectiveData objectiveData = (objective_ = new ObjectiveData());
			string text = (name_ = other.name_);
			string text2 = (description_ = other.description_);
			string text3 = (containerAddress_ = other.containerAddress_);
			ObjectiveData objectiveData2 = other.objective_;
			int num = 0;
			if (objectiveData2 != null)
			{
				ObjectiveData objectiveData3 = objectiveData2.Clone();
			}
			objective_ = (ObjectiveData)num;
			CurrencyCost currencyCost = default(CurrencyCost);
			if (other.rewardCase_ == RewardOneofCase.Currency)
			{
				RewardOneofCase rewardOneofCase = other.rewardCase_;
				if (other.reward_ == null)
				{
					throw new InvalidCastException();
				}
				reward_ = currencyCost;
			}
			if ((long)currencyCost == 6)
			{
				RewardOneofCase rewardOneofCase2 = other.rewardCase_;
				if (other.reward_ == null)
				{
					throw new InvalidCastException();
				}
				ItemAmount itemAmount = default(ItemAmount);
				reward_ = itemAmount;
				rewardCase_ = (RewardOneofCase)itemAmount;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EDA0", Offset = "0x1D2D7A0", VA = "0x181D2EDA0", Slot = "10")]
		[DebuggerNonUserCode]
		public MiniEventMilestoneData Clone()
		{
			return new MiniEventMilestoneData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA40", Offset = "0x1D0C440", VA = "0x181D0DA40")]
		[DebuggerNonUserCode]
		public void ClearReward()
		{
			//IL_0010: Expected O, but got I4
			reward_ = (rewardCase_ = RewardOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EFB0", Offset = "0x1D2D9B0", VA = "0x181D2EFB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = name_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = description_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = containerAddress_;
						bool flag3 = default(bool);
						CurrencyCost objB = default(CurrencyCost);
						if (!flag3 && object.Equals(objective_, other) && object.Equals(Currency, objB))
						{
							ItemAmount objB2 = default(ItemAmount);
							bool flag4 = object.Equals(Item, objB2);
							if (flag4 && rewardCase_ == (flag4 ? ((RewardOneofCase)1) : RewardOneofCase.None))
							{
								return object.Equals(_unknownFields, objB2);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EE80", Offset = "0x1D2D880", VA = "0x181D2EE80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiniEventMilestoneData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					string text2 = other.description_;
					if (!(description_ != text2))
					{
						string text3 = other.containerAddress_;
						if (!(containerAddress_ != text3))
						{
							ObjectiveData objB = other.objective_;
							if (object.Equals(objective_, objB))
							{
								CurrencyCost currency = Currency;
								CurrencyCost currency2 = other.Currency;
								if (object.Equals(currency, currency2))
								{
									ItemAmount item = Item;
									ItemAmount item2 = other.Item;
									if (object.Equals(item, item2))
									{
										RewardOneofCase rewardOneofCase = other.rewardCase_;
										if (rewardCase_ == rewardOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D2F200", Offset = "0x1D2DC00", VA = "0x181D2F200", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00bc
			RewardOneofCase rewardOneofCase;
			do
			{
				string text = name_;
				if (text.m_stringLength != 0)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = description_;
				if (text2.m_stringLength != 0)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = containerAddress_;
				if (text3.m_stringLength != 0)
				{
					int hashCode3 = text3.GetHashCode();
				}
				ObjectiveData objectiveData = objective_;
				if (objectiveData != null)
				{
					int hashCode4 = objectiveData.GetHashCode();
				}
				rewardOneofCase = rewardCase_;
				int num = 0;
			}
			while (rewardOneofCase != RewardOneofCase.Currency);
			object obj = reward_;
			if (obj != null)
			{
				int hashCode5 = obj.GetHashCode();
				if (rewardCase_ == RewardOneofCase.Item)
				{
					object obj2 = reward_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode6 = obj2.GetHashCode();
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode7 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FCE0", Offset = "0x1D2E6E0", VA = "0x181D2FCE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FD40", Offset = "0x1D2E740", VA = "0x181D2FD40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d2
			RewardOneofCase rewardOneofCase;
			do
			{
				if (name_.m_stringLength != 0)
				{
					string value = name_;
					output.WriteString(value);
				}
				if (description_.m_stringLength != 0)
				{
					string value2 = description_;
					output.WriteString(value2);
				}
				if (containerAddress_.m_stringLength != 0)
				{
					string value3 = containerAddress_;
					output.WriteString(value3);
				}
				if ((long)objective_ != 0)
				{
					ObjectiveData value4 = objective_;
					output.WriteMessage(value4);
				}
				rewardOneofCase = rewardCase_;
				int num = 0;
			}
			while (rewardOneofCase != RewardOneofCase.Currency);
			if (rewardCase_ == RewardOneofCase.Currency)
			{
				object obj = reward_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (rewardCase_ == RewardOneofCase.Item && rewardCase_ == RewardOneofCase.Item)
			{
				object obj2 = reward_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D2E9F0", Offset = "0x1D2D3F0", VA = "0x181D2E9F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00fa
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = description_;
			if (text2.m_stringLength != num)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = containerAddress_;
			if (text3.m_stringLength != num)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			ObjectiveData objectiveData = objective_;
			if (objectiveData != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(objectiveData);
				num5++;
				num += num5;
			}
			if (rewardCase_ == RewardOneofCase.Currency)
			{
				if (rewardCase_ != RewardOneofCase.Currency)
				{
				}
				object obj = reward_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (rewardCase_ == RewardOneofCase.Item)
			{
				if (rewardCase_ == RewardOneofCase.Item)
				{
					object obj2 = reward_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D2F740", Offset = "0x1D2E140", VA = "0x181D2F740", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniEventMilestoneData other)
		{
			//Discarded unreachable code: IL_0172
			//IL_0139: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.description_;
			if (text2.m_stringLength != 0)
			{
				Description = text2;
			}
			string text3 = other.containerAddress_;
			if (text3.m_stringLength != 0)
			{
				ContainerAddress = text3;
			}
			if ((long)other.objective_ != 0)
			{
				ObjectiveData objectiveData2 = default(ObjectiveData);
				if (objective_ == null)
				{
					ObjectiveData objectiveData = (objective_ = new ObjectiveData());
					objectiveData2 = objective_;
				}
				ObjectiveData other2 = other.objective_;
				objectiveData2.MergeFrom(other2);
			}
			if (other.rewardCase_ == RewardOneofCase.Currency)
			{
				RewardOneofCase rewardOneofCase = rewardCase_;
				object obj = default(object);
				if (rewardOneofCase == RewardOneofCase.Currency)
				{
					obj = reward_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					CurrencyCost currencyCost = (CurrencyCost)(reward_ = new CurrencyCost());
					rewardCase_ = rewardOneofCase;
				}
				if (rewardCase_ == RewardOneofCase.Currency)
				{
					object obj2 = reward_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.rewardCase_ == RewardOneofCase.Currency)
				{
					object obj3 = other.reward_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(CurrencyCost).TypeHandle == 6)
			{
				if (Item == null)
				{
					rewardCase_ = (RewardOneofCase)(reward_ = new ItemAmount());
				}
				ItemAmount item = Item;
				ItemAmount item2 = other.Item;
				item.MergeFrom(item2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D2F460", Offset = "0x1D2DE60", VA = "0x181D2F460", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0089: Expected I4, but got O
			//IL_00e0: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					ObjectiveData objectiveData = objective_;
					if (objectiveData == null)
					{
						ObjectiveData objectiveData2 = (objective_ = new ObjectiveData());
					}
					input.ReadMessage(objectiveData);
				}
				if (num == 42)
				{
					CurrencyCost builder = new CurrencyCost();
					if (rewardCase_ == RewardOneofCase.Currency)
					{
						if (rewardCase_ != RewardOneofCase.Currency)
						{
						}
						object obj = reward_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					reward_ = builder;
					rewardCase_ = (RewardOneofCase)typeof(CurrencyCost).TypeHandle;
				}
				if ((long)typeof(CurrencyCost).TypeHandle != 50)
				{
					goto IL_0126;
				}
				ItemAmount builder2 = new ItemAmount();
				if (rewardCase_ == RewardOneofCase.Item)
				{
					if (rewardCase_ != RewardOneofCase.Item)
					{
					}
					object obj2 = reward_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				reward_ = builder2;
				rewardCase_ = (RewardOneofCase)typeof(ItemAmount).TypeHandle;
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (Name = input.ReadString());
			}
			string text4 = default(string);
			if ((long)text2 == 18)
			{
				text4 = (Description = input.ReadString());
			}
			if ((long)text4 == 26)
			{
				string text6 = (ContainerAddress = input.ReadString());
			}
			goto IL_0126;
			IL_0126:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D2F110", Offset = "0x1D2DB10", VA = "0x181D2F110", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 5)
			{
				string text = name_;
				string text2 = description_;
				string text3 = containerAddress_;
				ObjectiveData objectiveData = objective_;
				CurrencyCost currency = Currency;
				ItemAmount item = Item;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FAA0", Offset = "0x1D2E4A0", VA = "0x181D2FAA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_001c, IL_0020, IL_0021, IL_0025, IL_0029, IL_002a, IL_002e, IL_0032, IL_0036, IL_003b, IL_003f, IL_0043, IL_0044, IL_0050, IL_0056, IL_005c, IL_0062
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				Name = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EC40", Offset = "0x1D2D640", VA = "0x181D2EC40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013
			if (fieldNumber - 1 <= 5)
			{
				Name = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D2F3B0", Offset = "0x1D2DDB0", VA = "0x181D2F3B0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Reward"))
			{
				RewardOneofCase rewardOneofCase = rewardCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D2ED30", Offset = "0x1D2D730", VA = "0x181D2ED30", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Reward"))
			{
				reward_ = (rewardCase_ = RewardOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EE00", Offset = "0x1D2D800", VA = "0x181D2EE00", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0017
			objective_.DataValidation("Mini-Event", "Milestone", context);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FF40", Offset = "0x1D2E940", VA = "0x181D2FF40")]
		static MiniEventMilestoneData()
		{
			Func<MiniEventMilestoneData> func = default(Func<MiniEventMilestoneData>);
			_parser = (MessageParser<MiniEventMilestoneData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
