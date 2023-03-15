using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Shops;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000882")]
	public sealed class Shop : IMessage<Shop>, IMessage, IEquatable<Shop>, IDeepCloneable<Shop>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000883")]
		public enum LimitsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400223B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400223C")]
			Fishing = 6,
			[Cpp2IlInjected.Token(Token = "0x400223D")]
			Gardening = 7
		}

		[Cpp2IlInjected.Token(Token = "0x400222E")]
		private static readonly MessageParser<Shop> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400222F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002230")]
		public const int ShopNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002231")]
		private string shopName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002232")]
		public const int DataFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002233")]
		private ShopData data_;

		[Cpp2IlInjected.Token(Token = "0x4002234")]
		public const int FishingFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4002235")]
		public const int GardeningFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002236")]
		private object limits_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002237")]
		private LimitsOneofCase limitsCase_;

		[Cpp2IlInjected.Token(Token = "0x17000BE9")]
		[DebuggerNonUserCode]
		public static MessageParser<Shop> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60047D8")]
			[Cpp2IlInjected.Address(RVA = "0x177C7A0", Offset = "0x177B1A0", VA = "0x18177C7A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047D9")]
			[Cpp2IlInjected.Address(RVA = "0x177C550", Offset = "0x177AF50", VA = "0x18177C550")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047DA")]
			[Cpp2IlInjected.Address(RVA = "0x177C8A0", Offset = "0x177B2A0", VA = "0x18177C8A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEC")]
		[DebuggerNonUserCode]
		public string ShopName
		{
			[Cpp2IlInjected.Token(Token = "0x60047DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return shopName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60047E0")]
			[Cpp2IlInjected.Address(RVA = "0x177CA30", Offset = "0x177B430", VA = "0x18177CA30")]
			set
			{
				string text = (shopName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BED")]
		[DebuggerNonUserCode]
		public ShopData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60047E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return data_;
			}
			[Cpp2IlInjected.Token(Token = "0x60047E2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				data_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEE")]
		[DebuggerNonUserCode]
		public LimitsFishing Fishing
		{
			[Cpp2IlInjected.Token(Token = "0x60047E3")]
			[Cpp2IlInjected.Address(RVA = "0x177C680", Offset = "0x177B080", VA = "0x18177C680")]
			get
			{
				int num = 0;
				if (limitsCase_ == LimitsOneofCase.Fishing)
				{
					object obj = limits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047E4")]
			[Cpp2IlInjected.Address(RVA = "0x177C9B0", Offset = "0x177B3B0", VA = "0x18177C9B0")]
			set
			{
				limits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEF")]
		[DebuggerNonUserCode]
		public LimitsGardening Gardening
		{
			[Cpp2IlInjected.Token(Token = "0x60047E5")]
			[Cpp2IlInjected.Address(RVA = "0x177C6E0", Offset = "0x177B0E0", VA = "0x18177C6E0")]
			get
			{
				int num = 0;
				if (limitsCase_ == LimitsOneofCase.Gardening)
				{
					object obj = limits_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047E6")]
			[Cpp2IlInjected.Address(RVA = "0x177C9F0", Offset = "0x177B3F0", VA = "0x18177C9F0")]
			set
			{
				limits_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF0")]
		[DebuggerNonUserCode]
		public LimitsOneofCase LimitsCase
		{
			[Cpp2IlInjected.Token(Token = "0x60047E7")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return limitsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF1")]
		[field: Cpp2IlInjected.Token(Token = "0x4002238")]
		public static Definitions.Shops.Shop Empty
		{
			[Cpp2IlInjected.Token(Token = "0x60047F6")]
			[Cpp2IlInjected.Address(RVA = "0x177C620", Offset = "0x177B020", VA = "0x18177C620")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF2")]
		public ProtoDatabase ProtoDb
		{
			[Cpp2IlInjected.Token(Token = "0x60047F7")]
			[Cpp2IlInjected.Address(RVA = "0x177C800", Offset = "0x177B200", VA = "0x18177C800")]
			get
			{
				return ProtoDatabase.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF3")]
		public Definitions.Shops.Shop Definition
		{
			[Cpp2IlInjected.Token(Token = "0x60047F8")]
			[Cpp2IlInjected.Address(RVA = "0x177C3D0", Offset = "0x177ADD0", VA = "0x18177C3D0")]
			get
			{
				//Discarded unreachable code: IL_0010
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
				}
				return Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF4")]
		[field: Cpp2IlInjected.Token(Token = "0x4002239")]
		public static CurrencyCost InvalidRefreshCost
		{
			[Cpp2IlInjected.Token(Token = "0x60047F9")]
			[Cpp2IlInjected.Address(RVA = "0x177C740", Offset = "0x177B140", VA = "0x18177C740")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60047DB")]
		[Cpp2IlInjected.Address(RVA = "0x177C330", Offset = "0x177AD30", VA = "0x18177C330")]
		[DebuggerNonUserCode]
		public Shop()
		{
			ShopData shopData = (data_ = new ShopData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047DC")]
		[Cpp2IlInjected.Address(RVA = "0x177BA40", Offset = "0x177A440", VA = "0x18177BA40")]
		private void OnConstruction()
		{
			ShopData shopData = (data_ = new ShopData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047DD")]
		[Cpp2IlInjected.Address(RVA = "0x177C120", Offset = "0x177AB20", VA = "0x18177C120")]
		[DebuggerNonUserCode]
		public Shop(Shop other)
		{
			//IL_0048: Expected O, but got I4
			//IL_0092: Expected I4, but got O
			ShopData shopData = (data_ = new ShopData());
			string text = (shopName_ = other.shopName_);
			ShopData shopData2 = other.data_;
			int num = 0;
			if (shopData2 != null)
			{
				ShopData shopData3 = shopData2.Clone();
			}
			data_ = (ShopData)num;
			LimitsFishing limitsFishing = default(LimitsFishing);
			if (other.limitsCase_ == LimitsOneofCase.Fishing)
			{
				LimitsOneofCase limitsOneofCase = other.limitsCase_;
				if (other.limits_ == null)
				{
					throw new InvalidCastException();
				}
				limits_ = limitsFishing;
			}
			if ((long)limitsFishing == 7)
			{
				LimitsOneofCase limitsOneofCase2 = other.limitsCase_;
				if (other.limits_ == null)
				{
					throw new InvalidCastException();
				}
				LimitsGardening limitsGardening = default(LimitsGardening);
				limits_ = limitsGardening;
				limitsCase_ = (LimitsOneofCase)limitsGardening;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047DE")]
		[Cpp2IlInjected.Address(RVA = "0x1779A40", Offset = "0x1778440", VA = "0x181779A40", Slot = "10")]
		[DebuggerNonUserCode]
		public Shop Clone()
		{
			return new Shop(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60047E8")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearLimits()
		{
			//IL_0010: Expected O, but got I4
			limits_ = (limitsCase_ = LimitsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047E9")]
		[Cpp2IlInjected.Address(RVA = "0x1779AA0", Offset = "0x17784A0", VA = "0x181779AA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = shopName_;
				bool flag = default(bool);
				LimitsFishing objB = default(LimitsFishing);
				if (!flag && object.Equals(data_, other) && object.Equals(Fishing, objB))
				{
					LimitsGardening objB2 = default(LimitsGardening);
					bool flag2 = object.Equals(Gardening, objB2);
					if (flag2 && limitsCase_ == (flag2 ? ((LimitsOneofCase)1) : LimitsOneofCase.None))
					{
						return object.Equals(_unknownFields, objB2);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047EA")]
		[Cpp2IlInjected.Address(RVA = "0x1779BD0", Offset = "0x17785D0", VA = "0x181779BD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Shop other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.shopName_;
				if (!(shopName_ != text))
				{
					ShopData objB = other.data_;
					if (object.Equals(data_, objB))
					{
						LimitsFishing fishing = Fishing;
						LimitsFishing fishing2 = other.Fishing;
						if (object.Equals(fishing, fishing2))
						{
							LimitsGardening gardening = Gardening;
							LimitsGardening gardening2 = other.Gardening;
							if (object.Equals(gardening, gardening2))
							{
								LimitsOneofCase limitsOneofCase = other.limitsCase_;
								if (limitsCase_ == limitsOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047EB")]
		[Cpp2IlInjected.Address(RVA = "0x177A910", Offset = "0x1779310", VA = "0x18177A910", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0086
			LimitsOneofCase limitsOneofCase;
			do
			{
				string text = shopName_;
				if (text.m_stringLength != 0)
				{
					int hashCode = text.GetHashCode();
				}
				ShopData shopData = data_;
				if (shopData != null)
				{
					int hashCode2 = shopData.GetHashCode();
				}
				limitsOneofCase = limitsCase_;
				int num = 0;
			}
			while (limitsOneofCase != LimitsOneofCase.Fishing);
			object obj = limits_;
			if (obj != null)
			{
				int hashCode3 = obj.GetHashCode();
				if (limitsCase_ == LimitsOneofCase.Gardening)
				{
					object obj2 = limits_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode4 = obj2.GetHashCode();
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode5 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047EC")]
		[Cpp2IlInjected.Address(RVA = "0x177BC60", Offset = "0x177A660", VA = "0x18177BC60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60047ED")]
		[Cpp2IlInjected.Address(RVA = "0x177BDB0", Offset = "0x177A7B0", VA = "0x18177BDB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0097
			LimitsOneofCase limitsOneofCase;
			do
			{
				if (shopName_.m_stringLength != 0)
				{
					string value = shopName_;
					output.WriteString(value);
				}
				if ((long)data_ != 0)
				{
					ShopData value2 = data_;
					output.WriteMessage(value2);
				}
				limitsOneofCase = limitsCase_;
				int num = 0;
			}
			while (limitsOneofCase != LimitsOneofCase.Fishing);
			if (limitsCase_ == LimitsOneofCase.Fishing)
			{
				object obj = limits_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (limitsCase_ == LimitsOneofCase.Gardening && limitsCase_ == LimitsOneofCase.Gardening)
			{
				object obj2 = limits_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60047EE")]
		[Cpp2IlInjected.Address(RVA = "0x17796A0", Offset = "0x17780A0", VA = "0x1817796A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ae
			string text = shopName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			ShopData shopData = data_;
			if (shopData != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(shopData);
				num3++;
				num += num3;
			}
			if (limitsCase_ == LimitsOneofCase.Fishing)
			{
				if (limitsCase_ != LimitsOneofCase.Fishing)
				{
				}
				object obj = limits_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (limitsCase_ == LimitsOneofCase.Gardening)
			{
				if (limitsCase_ == LimitsOneofCase.Gardening)
				{
					object obj2 = limits_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60047EF")]
		[Cpp2IlInjected.Address(RVA = "0x177B2B0", Offset = "0x1779CB0", VA = "0x18177B2B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Shop other)
		{
			//Discarded unreachable code: IL_0140
			//IL_0107: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			string text = other.shopName_;
			if (text.m_stringLength != 0)
			{
				ShopName = text;
			}
			if ((long)other.data_ != 0)
			{
				ShopData shopData2 = default(ShopData);
				if (data_ == null)
				{
					ShopData shopData = (data_ = new ShopData());
					shopData2 = data_;
				}
				ShopData other2 = other.data_;
				shopData2.MergeFrom(other2);
			}
			if (other.limitsCase_ == LimitsOneofCase.Fishing)
			{
				LimitsOneofCase limitsOneofCase = limitsCase_;
				object obj = default(object);
				if (limitsOneofCase == LimitsOneofCase.Fishing)
				{
					obj = limits_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					LimitsFishing limitsFishing = (LimitsFishing)(limits_ = new LimitsFishing());
					limitsCase_ = limitsOneofCase;
				}
				if (limitsCase_ == LimitsOneofCase.Fishing)
				{
					object obj2 = limits_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.limitsCase_ == LimitsOneofCase.Fishing)
				{
					object obj3 = other.limits_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(LimitsFishing).TypeHandle == 7)
			{
				if (Gardening == null)
				{
					limitsCase_ = (LimitsOneofCase)(limits_ = new LimitsGardening());
				}
				LimitsGardening gardening = Gardening;
				LimitsGardening gardening2 = other.Gardening;
				gardening.MergeFrom(gardening2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60047F0")]
		[Cpp2IlInjected.Address(RVA = "0x177B580", Offset = "0x1779F80", VA = "0x18177B580", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00ac: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 50)
				{
					LimitsFishing limitsFishing = new LimitsFishing();
					if (limitsCase_ == LimitsOneofCase.Fishing)
					{
						if (limitsCase_ != LimitsOneofCase.Fishing)
						{
						}
						object obj = limits_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(limitsFishing);
					limits_ = limitsFishing;
					limitsCase_ = (LimitsOneofCase)limitsFishing;
				}
				if (num != 58)
				{
					goto IL_00f2;
				}
				LimitsGardening builder = new LimitsGardening();
				if (limitsCase_ == LimitsOneofCase.Gardening)
				{
					if (limitsCase_ != LimitsOneofCase.Gardening)
					{
					}
					object obj2 = limits_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				limits_ = builder;
				limitsCase_ = (LimitsOneofCase)typeof(LimitsGardening).TypeHandle;
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (ShopName = input.ReadString());
			}
			if ((long)text2 == 18)
			{
				ShopData builder2 = default(ShopData);
				if (data_ == null)
				{
					ShopData shopData = (data_ = new ShopData());
					builder2 = data_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00f2;
			IL_00f2:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60047F1")]
		[Cpp2IlInjected.Address(RVA = "0x177A720", Offset = "0x1779120", VA = "0x18177A720", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			while (true)
			{
				if (fieldNumber <= 6)
				{
					string text = shopName_;
					ShopData shopData = data_;
					LimitsFishing fishing = Fishing;
					LimitsGardening gardening = Gardening;
				}
				ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
				if (fieldNumber <= 6)
				{
				}
				if (fieldNumber <= 6)
				{
				}
				if (fieldNumber <= 6)
				{
				}
				if (fieldNumber <= 6)
				{
				}
				if (fieldNumber <= 6)
				{
				}
				if (fieldNumber <= 6)
				{
				}
				if (fieldNumber <= 6)
				{
					/*Error: Could not find block for branch target IL_004d*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047F2")]
		[Cpp2IlInjected.Address(RVA = "0x177BAA0", Offset = "0x177A4A0", VA = "0x18177BAA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_001c, IL_0020, IL_0024, IL_0029, IL_002d, IL_0031, IL_0032, IL_003e, IL_0044
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				ShopName = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047F3")]
		[Cpp2IlInjected.Address(RVA = "0x17798F0", Offset = "0x17782F0", VA = "0x1817798F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012
			//IL_001b: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				ShopName = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047F4")]
		[Cpp2IlInjected.Address(RVA = "0x177ADB0", Offset = "0x17797B0", VA = "0x18177ADB0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Limits"))
			{
				LimitsOneofCase limitsOneofCase = limitsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047F5")]
		[Cpp2IlInjected.Address(RVA = "0x17799D0", Offset = "0x17783D0", VA = "0x1817799D0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Limits"))
			{
				limits_ = (limitsCase_ = LimitsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047FA")]
		[Cpp2IlInjected.Address(RVA = "0x177AE60", Offset = "0x1779860", VA = "0x18177AE60")]
		public CurrencyCost GetRefreshCost(ProfileWorld profileWorld, Item stallItem, ShopData shopData)
		{
			int num = 0;
			UpgradeData upgradeData = default(UpgradeData);
			if (upgradeData != null)
			{
			}
			if (upgradeData != null && upgradeData != null)
			{
				Definitions.Shops.Shop definition = Definition;
				int numRefresh_ = shopData.numRefresh_;
				CurrencyCost refreshCost = definition.GetRefreshCost(numRefresh_);
				CurrencyCost result = default(CurrencyCost);
				return result;
			}
			int numRefresh = 0;
			Definitions.Shops.Shop shop = default(Definitions.Shops.Shop);
			CurrencyCost refreshCost2 = shop.GetRefreshCost(numRefresh);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047FB")]
		[Cpp2IlInjected.Address(RVA = "0x177B210", Offset = "0x1779C10", VA = "0x18177B210")]
		private int GetUpgradeDiscount(ProfileWorld profileWorld, Item stallItem)
		{
			UpgradeData upgradeData = default(UpgradeData);
			while (true)
			{
				int num = 0;
				if (upgradeData != null)
				{
				}
				if (upgradeData == null)
				{
					/*Error: Could not find block for branch target IL_000a*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047FC")]
		[Cpp2IlInjected.Address(RVA = "0x177AF70", Offset = "0x1779970", VA = "0x18177AF70")]
		private UpgradeData GetUpgradeData(ProfileWorld profileWorld, Item stallItem, [Optional] IBuildingUpgradable buildingUpgradable)
		{
			if ((object)typeof(Item).TypeHandle == null)
			{
				if ((object)typeof(Item).TypeHandle != null)
				{
					Item invalid = Item.Invalid;
					StallBuildingItemData itemData = GetItemData(invalid);
					if (itemData == null)
					{
						goto IL_0030;
					}
					int iD = itemData.ID;
				}
				GridCollection gridCollection_ = profileWorld.gridCollection_;
				goto IL_0030;
			}
			StallBuildingItemData stallBuildingItemData = default(StallBuildingItemData);
			if (buildingUpgradable == null && stallBuildingItemData == null)
			{
				goto IL_0067;
			}
			goto IL_006a;
			IL_006a:
			throw new NullReferenceException();
			IL_0030:
			int num = 0;
			StallBuildingItemData stallBuildingItemData2 = default(StallBuildingItemData);
			if (num != 0 && num != 0 && (buildingUpgradable != null || stallBuildingItemData2 != null))
			{
				int iD_ = stallBuildingItemData2.iD_;
				int useLowerLast = 0;
				return stallBuildingItemData2.GetUpgradeData(iD_, (byte)useLowerLast != 0);
			}
			goto IL_0067;
			IL_0067:
			int num2 = 0;
			goto IL_006a;
		}

		[Cpp2IlInjected.Token(Token = "0x60047FD")]
		[Cpp2IlInjected.Address(RVA = "0x177A800", Offset = "0x1779200", VA = "0x18177A800")]
		private GridObject GetGridObject(ProfileWorld profileWorld, Item stallItem)
		{
			if ((object)typeof(Item).TypeHandle != null)
			{
				Item invalid = Item.Invalid;
				StallBuildingItemData itemData = GetItemData(invalid);
				if (itemData != null)
				{
					int iD = itemData.ID;
				}
			}
			GridCollection gridCollection_ = profileWorld.gridCollection_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047FE")]
		[Cpp2IlInjected.Address(RVA = "0x177AA80", Offset = "0x1779480", VA = "0x18177AA80")]
		private StallBuildingItemData GetItemData(Item stallItem)
		{
			//Discarded unreachable code: IL_0034
			bool flag = default(bool);
			if (!flag)
			{
				IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<StallBuildingItemData>(ItemType.Building);
				Func<StallBuildingItemData, bool> func = (Func<StallBuildingItemData, bool>)(object)(Func<T, TResult>)delegate(StallBuildingItemData building)
				{
					//Discarded unreachable code: IL_0014
					string b = shopName_;
					return string.Equals(building.shopData_, b);
				};
				return Enumerable.FirstOrDefault<StallBuildingItemData>(Enumerable.Where<StallBuildingItemData>(allByType, (Func<, >)(object)func));
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			StallBuildingItemData result = default(StallBuildingItemData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60047FF")]
		[Cpp2IlInjected.Address(RVA = "0x1779870", Offset = "0x1778270", VA = "0x181779870")]
		public bool CanRefresh(DateTime now, ShopData shopData)
		{
			if (shopData != null)
			{
				AnyFatigue fatigue_ = Definition.fatigue_;
				if (fatigue_ != null)
				{
					DateTime lastRefreshDateTime = shopData.LastRefreshDateTime;
					return fatigue_.CanRefresh(lastRefreshDateTime, now);
				}
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004800")]
		[Cpp2IlInjected.Address(RVA = "0x177B9A0", Offset = "0x177A3A0", VA = "0x18177B9A0")]
		public DateTime NextAutoRefresh(DateTime now)
		{
			//Discarded unreachable code: IL_001e
			return Definition.fatigue_?.NextAutoRefresh(now) ?? DateTime.MinValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6004801")]
		[Cpp2IlInjected.Address(RVA = "0x1779CD0", Offset = "0x17786D0", VA = "0x181779CD0")]
		public bool GenerateSlots(in Player player, in World world, Item stallItem, ShopData shopData, int slotId = 0)
		{
			//IL_0045: Expected I4, but got I8
			//IL_0111: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			List<int> list;
			UpgradeData upgradeData = default(UpgradeData);
			StallBuildingItemData stallBuildingItemData = default(StallBuildingItemData);
			Definitions.Activities.ShopSlot shopSlot;
			ulong num4 = default(ulong);
			LootTableItemData lootTableItemData = default(LootTableItemData);
			int id_;
			do
			{
				int num = 0;
				int num2 = 0;
				list = (List<int>)(object)new List<T>();
				ProfileWorld section = world.Section;
				if (upgradeData != null)
				{
				}
				if (upgradeData == null)
				{
					int count = ((RepeatedField<T>)(object)Definition.slots_).Count;
				}
				int num3 = 0;
				if (stallBuildingItemData != null)
				{
				}
				shopSlot = new Definitions.Activities.ShopSlot();
				shopSlot.slotId_ = (int)num4;
				if (10 <= 0)
				{
					break;
				}
				if (lootTableItemData != null)
				{
					MultiItemInstance multiItemInstance = new MultiItemInstance();
					LootTable rewards_ = lootTableItemData.rewards_;
					int num5 = 0;
					ItemInstance itemInstance = Enumerable.FirstOrDefault<ItemInstance>((IEnumerable<>)(object)multiItemInstance.items_);
					if (itemInstance != null)
					{
						ItemAmount itemAmount = itemInstance.ItemAmount;
					}
					shopSlot.item_ = (ItemAmount)(object)itemInstance;
					ItemAmount item_ = shopSlot.item_;
					if (item_ != null)
					{
						RepeatedField<Definitions.Shops.ShopSlot> slots_ = Definition.slots_;
						int slotId_ = shopSlot.slotId_;
						if (((Definitions.Shops.ShopSlot)((RepeatedField<T>)(object)slots_)[slotId_]).HasLimit)
						{
							RepeatedField<Definitions.Shops.ShopSlot> slots_2 = Definition.slots_;
							int slotId_2 = shopSlot.slotId_;
							int limitAmount = ((Definitions.Shops.ShopSlot)((RepeatedField<T>)(object)slots_2)[slotId_2]).LimitAmount;
						}
						item_.amount_ = -1;
					}
				}
				ItemAmount item_2 = shopSlot.item_;
				if (item_2 == null)
				{
					break;
				}
				id_ = item_2.id_;
			}
			while (((List<T>)(object)list).Contains((T)id_));
			if ((long)shopSlot.item_ != 0)
			{
				RepeatedField<Definitions.Shops.ShopSlot> slots_3 = Definition.slots_;
				int slotId_3 = shopSlot.slotId_;
				if (!((Definitions.Shops.ShopSlot)((RepeatedField<T>)(object)slots_3)[slotId_3]).HasLimit)
				{
					int id_2 = shopSlot.item_.id_;
					((List<T>)(object)list).Add((T)id_2);
				}
			}
			Random random = default(Random);
			int num6 = random.Next();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004802")]
		[Cpp2IlInjected.Address(RVA = "0x177BCC0", Offset = "0x177A6C0", VA = "0x18177BCC0")]
		public bool TryGetslot(int slotId, ShopData shopData, out Definitions.Activities.ShopSlot slot)
		{
			int count = ((RepeatedField<T>)(object)shopData.slots_).Count;
			if (slotId < count)
			{
				Definitions.Activities.ShopSlot shopSlot = (Definitions.Activities.ShopSlot)((RepeatedField<T>)(object)shopData.slots_)[slotId];
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004803")]
		[Cpp2IlInjected.Address(RVA = "0x177ACE0", Offset = "0x17796E0", VA = "0x18177ACE0")]
		public int GetNumSlots(ProfileWorld profileWorld, Item stallItem)
		{
			//Discarded unreachable code: IL_001b
			UpgradeData upgradeData = default(UpgradeData);
			do
			{
				int num = 0;
				if (upgradeData != null)
				{
				}
			}
			while (upgradeData != null);
			return ((RepeatedField<T>)(object)Definition.slots_).Count;
		}

		[Cpp2IlInjected.Token(Token = "0x6004804")]
		[Cpp2IlInjected.Address(RVA = "0x177B820", Offset = "0x177A220", VA = "0x18177B820")]
		public bool MustResetDailySell(DateTime now)
		{
			//Discarded unreachable code: IL_0041
			if (Definition.supportsDailySellCap_ && limitsCase_ == LimitsOneofCase.Gardening)
			{
				object obj = limits_;
				if (obj != null)
				{
					if (obj != null)
					{
						if (1L == 0L)
						{
						}
						if (limits_ != null)
						{
							int num = 0;
							DateTime dateTime = default(DateTime);
							return dateTime < now;
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004805")]
		[Cpp2IlInjected.Address(RVA = "0x177A6A0", Offset = "0x17790A0", VA = "0x18177A6A0")]
		public int GetDailySell(DateTime now)
		{
			if (MustResetDailySell(now) || limits_ != null)
			{
				return 0;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004806")]
		[Cpp2IlInjected.Address(RVA = "0x1779160", Offset = "0x1777B60", VA = "0x181779160")]
		public unsafe int AddToDailySell(ProfileWorld profileWorld, DateTime now, CurrencyCost price, float sellCapMultiplier)
		{
			//Discarded unreachable code: IL_00d8, IL_00e5, IL_0112
			//IL_0047: Expected I4, but got O
			//IL_006e: Expected O, but got I4
			//IL_0078: Expected I4, but got O
			//IL_00d8: Expected I4, but got O
			int num = 0;
			if ((Definition.supportsDailySellCap_ ? 1 : 0) != num)
			{
				bool flag = default(bool);
				if (flag)
				{
					if (limitsCase_ == LimitsOneofCase.Gardening && (object)typeof(LimitsGardening).TypeHandle != null && (object)typeof(LimitsGardening).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					limitsCase_ = (LimitsOneofCase)(limits_ = new LimitsGardening());
					bool flag2 = default(bool);
					if (flag2)
					{
					}
					if (limitsCase_ == LimitsOneofCase.Gardening && (object)typeof(LimitsGardening).TypeHandle != null && (object)typeof(LimitsGardening).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					Timestamp timestamp = ((DateTime)num).ToProto();
					((int*)num)->m_value = (int)timestamp;
					if ((object)typeof(LimitsGardening).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
				}
				if (limits_ != null)
				{
					ulong num2 = default(ulong);
					if (num2 != 0 || limitsCase_ != LimitsOneofCase.Gardening)
					{
					}
					object obj = limits_;
					if (obj == null || obj != null)
					{
						ulong num3 = default(ulong);
						if (num3 == 0)
						{
							LimitsOneofCase limitsOneofCase = limitsCase_;
						}
						if (limits_ != null && limits_ != null)
						{
							return (int)typeof(LimitsGardening).TypeHandle;
						}
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			while (price != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004807")]
		[Cpp2IlInjected.Address(RVA = "0x177A2B0", Offset = "0x1778CB0", VA = "0x18177A2B0")]
		public int GetDailySellLimit(ProfileWorld profileWorld, float sellCapMultiplier)
		{
			//Discarded unreachable code: IL_0096, IL_009c
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num2 = default(uint);
			UpgradeData upgradeData = default(UpgradeData);
			int num3 = default(int);
			uint num4 = default(uint);
			int num;
			do
			{
				num = 0;
				if ((Definition.supportsDailySellCap_ ? 1 : 0) == num)
				{
					return -1;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Func<StallBuildingItemData, bool> func = (Func<StallBuildingItemData, bool>)(object)(Func<T, TResult>)delegate(StallBuildingItemData building)
				{
					//Discarded unreachable code: IL_0014
					string b = shopName_;
					return string.Equals(building.shopData_, b);
				};
				IEnumerable<StallBuildingItemData> enumerable2 = (IEnumerable<StallBuildingItemData>)Enumerable.Where<StallBuildingItemData>(enumerable, (Func<, >)(object)func);
				if (enumerable2 != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_006a;
						}
						num++;
					}
					if (upgradeData != null)
					{
						BenefitsGardeningData gardening = upgradeData.Gardening;
						if (gardening != null)
						{
							num3 = gardening.sellCap_;
							num++;
						}
					}
					num += (int)num4;
					goto IL_006a;
				}
				goto IL_007c;
				IL_007c:
				num++;
				if (enumerable2 != null)
				{
				}
				continue;
				IL_006a:
				num3 += num3;
				num4 += 312;
				goto IL_007c;
			}
			while (num != 0);
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004808")]
		[Cpp2IlInjected.Address(RVA = "0x177BF40", Offset = "0x177A940", VA = "0x18177BF40")]
		static Shop()
		{
			//IL_002a: Expected I4, but got O
			//IL_0037: Expected I4, but got I8
			Func<Shop> func = default(Func<Shop>);
			_parser = (MessageParser<Shop>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<Shop>)(object)new Definitions.Shops.Shop();
			CurrencyCost currencyCost = new CurrencyCost();
			int num = 0;
			Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			currencyCost.id_ = (int)hardCurrencyItem;
			currencyCost.amount_ = 9999;
			_parser = (MessageParser<Shop>)(object)currencyCost;
			throw new NullReferenceException();
		}
	}
}
