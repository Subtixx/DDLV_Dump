using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008AE")]
	public sealed class StallData : IGridStateData, IGridUpgradeStateData, IMessage<StallData>, IMessage, IEquatable<StallData>, IDeepCloneable<StallData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002AA8")]
		private static readonly MessageParser<StallData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002AA9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002AAA")]
		public const int UpgradeStateFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AAB")]
		private UpgradeState upgradeState_;

		[Cpp2IlInjected.Token(Token = "0x4002AAC")]
		public const int ShopDataFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AAD")]
		private ShopData shopData_;

		[Cpp2IlInjected.Token(Token = "0x1700185D")]
		[DebuggerNonUserCode]
		public static MessageParser<StallData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006110")]
			[Cpp2IlInjected.Address(RVA = "0x2630E70", Offset = "0x262F870", VA = "0x182630E70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006111")]
			[Cpp2IlInjected.Address(RVA = "0x2630DA0", Offset = "0x262F7A0", VA = "0x182630DA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006112")]
			[Cpp2IlInjected.Address(RVA = "0x2630ED0", Offset = "0x262F8D0", VA = "0x182630ED0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001860")]
		[DebuggerNonUserCode]
		public UpgradeState UpgradeState
		{
			[Cpp2IlInjected.Token(Token = "0x6006116")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get
			{
				return upgradeState_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006117")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "5")]
			set
			{
				upgradeState_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001861")]
		[DebuggerNonUserCode]
		public ShopData ShopData
		{
			[Cpp2IlInjected.Token(Token = "0x6006118")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return shopData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006119")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				shopData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006113")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StallData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6006114")]
		[Cpp2IlInjected.Address(RVA = "0x2630D00", Offset = "0x262F700", VA = "0x182630D00")]
		[DebuggerNonUserCode]
		public StallData(StallData other)
		{
			//IL_0021: Expected O, but got I4
			UpgradeState upgradeState = other.upgradeState_;
			int num = 0;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			upgradeState_ = (UpgradeState)num;
			ShopData shopData = other.shopData_;
			ShopData shopData2 = default(ShopData);
			if (shopData != null)
			{
				shopData2 = shopData.Clone();
			}
			shopData_ = shopData2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006115")]
		[Cpp2IlInjected.Address(RVA = "0x2630640", Offset = "0x262F040", VA = "0x182630640", Slot = "12")]
		[DebuggerNonUserCode]
		public StallData Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			StallData stallData = new StallData();
			UpgradeState upgradeState = upgradeState_;
			int num = 0;
			if (upgradeState != null)
			{
				UpgradeState upgradeState2 = upgradeState.Clone();
			}
			stallData.upgradeState_ = (UpgradeState)num;
			ShopData shopData = shopData_;
			ShopData shopData2 = default(ShopData);
			if (shopData != null)
			{
				shopData2 = shopData.Clone();
			}
			stallData.shopData_ = shopData2;
			UnknownFieldSet unknownFieldSet = (stallData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return stallData;
		}

		[Cpp2IlInjected.Token(Token = "0x600611A")]
		[Cpp2IlInjected.Address(RVA = "0x2630710", Offset = "0x262F110", VA = "0x182630710", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(upgradeState_, other) && object.Equals(shopData_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600611B")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(StallData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				UpgradeState objB = other.upgradeState_;
				if (object.Equals(upgradeState_, objB))
				{
					ShopData objB2 = other.shopData_;
					if (object.Equals(shopData_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600611C")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState != null)
				{
					int hashCode = upgradeState.GetHashCode();
				}
				ShopData shopData = shopData_;
				if (shopData != null)
				{
					int hashCode2 = shopData.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600611D")]
		[Cpp2IlInjected.Address(RVA = "0x2630B90", Offset = "0x262F590", VA = "0x182630B90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600611E")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)upgradeState_ != 0)
			{
				UpgradeState value = upgradeState_;
				output.WriteMessage(value);
			}
			if ((long)shopData_ != 0)
			{
				ShopData value2 = shopData_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600611F")]
		[Cpp2IlInjected.Address(RVA = "0x2630570", Offset = "0x262EF70", VA = "0x182630570", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				UpgradeState upgradeState = upgradeState_;
				num = 0;
				if (upgradeState != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(upgradeState);
				}
				ShopData shopData = shopData_;
				if (shopData != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(shopData);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006120")]
		[Cpp2IlInjected.Address(RVA = "0x2630860", Offset = "0x262F260", VA = "0x182630860", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(StallData other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.upgradeState_ != 0)
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState == null)
				{
					UpgradeState upgradeState2 = (upgradeState_ = new UpgradeState());
					UpgradeState upgradeState3 = upgradeState_;
				}
				UpgradeState other2 = other.upgradeState_;
				upgradeState.MergeFrom(other2);
			}
			if ((long)other.shopData_ != 0)
			{
				ShopData shopData2 = default(ShopData);
				if (shopData_ == null)
				{
					ShopData shopData = (shopData_ = new ShopData());
					shopData2 = shopData_;
				}
				ShopData other3 = other.shopData_;
				shopData2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6006121")]
		[Cpp2IlInjected.Address(RVA = "0x2630990", Offset = "0x262F390", VA = "0x182630990", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				UpgradeState upgradeState = upgradeState_;
				if (upgradeState == null)
				{
					UpgradeState upgradeState2 = (upgradeState_ = new UpgradeState());
				}
				input.ReadMessage(upgradeState);
			}
			if (num == 18)
			{
				ShopData builder = default(ShopData);
				if (shopData_ == null)
				{
					ShopData shopData = (shopData_ = new ShopData());
					builder = shopData_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006122")]
		[Cpp2IlInjected.Address(RVA = "0x26307D0", Offset = "0x262F1D0", VA = "0x1826307D0", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				UpgradeState upgradeState = upgradeState_;
			}
			if (fieldNumber == 2)
			{
				ShopData shopData = shopData_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006123")]
		[Cpp2IlInjected.Address(RVA = "0x2630AD0", Offset = "0x262F4D0", VA = "0x182630AD0", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					upgradeState_ = (UpgradeState)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006124")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006125")]
		[Cpp2IlInjected.Address(RVA = "0x2630BF0", Offset = "0x262F5F0", VA = "0x182630BF0")]
		static StallData()
		{
			Func<StallData> func = default(Func<StallData>);
			_parser = (MessageParser<StallData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
