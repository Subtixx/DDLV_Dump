using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000487")]
	public sealed class CustomStepPurchaseItem : IMessage<CustomStepPurchaseItem>, IMessage, IEquatable<CustomStepPurchaseItem>, IDeepCloneable<CustomStepPurchaseItem>, IMessageFieldAccessor, IMessageOneofAccessor, IItemSelector, IStepAmount, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000488")]
		public enum LocationOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400185B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400185C")]
			Store = 5,
			[Cpp2IlInjected.Token(Token = "0x400185D")]
			Shop = 6
		}

		[Cpp2IlInjected.Token(Token = "0x400184E")]
		private static readonly MessageParser<CustomStepPurchaseItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400184F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001850")]
		public const int MustPurchaseSpecificItemsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001851")]
		private bool mustPurchaseSpecificItems_;

		[Cpp2IlInjected.Token(Token = "0x4001852")]
		public const int ItemToPurchaseFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001853")]
		private AnyItemSelector itemToPurchase_;

		[Cpp2IlInjected.Token(Token = "0x4001854")]
		public const int ItemToPurchaseAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001855")]
		private StepAmount itemToPurchaseAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001856")]
		public const int StoreFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001857")]
		public const int ShopFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001858")]
		private object location_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001859")]
		private LocationOneofCase locationCase_;

		[Cpp2IlInjected.Token(Token = "0x17000E23")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepPurchaseItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600377F")]
			[Cpp2IlInjected.Address(RVA = "0x31FACD0", Offset = "0x31F96D0", VA = "0x1831FACD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E24")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003780")]
			[Cpp2IlInjected.Address(RVA = "0x31FAC00", Offset = "0x31F9600", VA = "0x1831FAC00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E25")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003781")]
			[Cpp2IlInjected.Address(RVA = "0x31FB910", Offset = "0x31FA310", VA = "0x1831FB910", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E26")]
		[DebuggerNonUserCode]
		public bool MustPurchaseSpecificItems
		{
			[Cpp2IlInjected.Token(Token = "0x6003786")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return mustPurchaseSpecificItems_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003787")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				mustPurchaseSpecificItems_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E27")]
		[DebuggerNonUserCode]
		public AnyItemSelector ItemToPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x6003788")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemToPurchase_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003789")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemToPurchase_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E28")]
		[DebuggerNonUserCode]
		public StepAmount ItemToPurchaseAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600378A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return itemToPurchaseAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600378B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				itemToPurchaseAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E29")]
		[DebuggerNonUserCode]
		public int Store
		{
			[Cpp2IlInjected.Token(Token = "0x600378C")]
			[Cpp2IlInjected.Address(RVA = "0x31FADA0", Offset = "0x31F97A0", VA = "0x1831FADA0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (locationCase_ == LocationOneofCase.Store)
				{
					object obj = location_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x600378D")]
			[Cpp2IlInjected.Address(RVA = "0x31FBA90", Offset = "0x31FA490", VA = "0x1831FBA90")]
			set
			{
				//IL_0014: Expected I4, but got I8
				location_ = typeof(int).TypeHandle;
				locationCase_ = LocationOneofCase.Store;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2A")]
		[DebuggerNonUserCode]
		public string Shop
		{
			[Cpp2IlInjected.Token(Token = "0x600378E")]
			[Cpp2IlInjected.Address(RVA = "0x31FAD30", Offset = "0x31F9730", VA = "0x1831FAD30")]
			get
			{
				if (locationCase_ == LocationOneofCase.Shop)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x600378F")]
			[Cpp2IlInjected.Address(RVA = "0x31FBA20", Offset = "0x31FA420", VA = "0x1831FBA20")]
			set
			{
				//IL_001c: Expected I4, but got I8
				string text = (string)(location_ = ProtoPreconditions.CheckNotNull(value, "value"));
				locationCase_ = LocationOneofCase.Shop;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2B")]
		[DebuggerNonUserCode]
		public LocationOneofCase LocationCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003790")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return locationCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2C")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x600379F")]
			[Cpp2IlInjected.Address(RVA = "0x2D4AD40", Offset = "0x2D49740", VA = "0x182D4AD40", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_000c
				return itemToPurchase_.itemToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2D")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60037A0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return itemToPurchaseAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E2E")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60037A1")]
			[Cpp2IlInjected.Address(RVA = "0x31FAE10", Offset = "0x31F9810", VA = "0x1831FAE10", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_02f5
				string[] array;
				while (true)
				{
					array = new string[24];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[1] = "TargetAmount";
					if ("CurrentAmount" != null && "CurrentAmount" == null)
					{
						continue;
					}
					array[2] = "CurrentAmount";
					if ("Complexity" != null && "Complexity" == null)
					{
						continue;
					}
					array[3] = "Complexity";
					if ("Mood" != null && "Mood" == null)
					{
						continue;
					}
					array[4] = "Mood";
					if ("Sturdiness" != null && "Sturdiness" == null)
					{
						continue;
					}
					array[5] = "Sturdiness";
					if ("Normality" != null && "Normality" == null)
					{
						continue;
					}
					array[6] = "Normality";
					if ("MinRarity" != null && "MinRarity" == null)
					{
						continue;
					}
					array[7] = "MinRarity";
					if ("MaxRarity" != null && "MaxRarity" == null)
					{
						continue;
					}
					array[8] = "MaxRarity";
					if ("Tags" != null && "Tags" == null)
					{
						continue;
					}
					array[9] = "Tags";
					if ("Color" != null && "Color" == null)
					{
						continue;
					}
					array[10] = "Color";
					if ("Style" != null && "Style" == null)
					{
						continue;
					}
					array[11] = "Style";
					if ("Function" != null && "Function" == null)
					{
						continue;
					}
					array[12] = "Function";
					if ("Zone" != null && "Zone" == null)
					{
						continue;
					}
					array[13] = "Zone";
					if ("Universe" != null && "Universe" == null)
					{
						continue;
					}
					array[14] = "Universe";
					if ("Type" != null && "Type" == null)
					{
						continue;
					}
					array[15] = "Type";
					if ("FishLocation" != null && "FishLocation" == null)
					{
						continue;
					}
					array[16] = "FishLocation";
					if ("FishConstraint" != null && "FishConstraint" == null)
					{
						continue;
					}
					array[17] = "FishConstraint";
					if ("CropType" != null && "CropType" == null)
					{
						continue;
					}
					array[18] = "CropType";
					if ("FlowerRarity" != null && "FlowerRarity" == null)
					{
						continue;
					}
					array[19] = "FlowerRarity";
					if ("MealType" != null && "MealType" == null)
					{
						continue;
					}
					array[20] = "MealType";
					if ("IngredientType" != null && "IngredientType" == null)
					{
						continue;
					}
					array[21] = "IngredientType";
					if ("MinUnlockLevel" == null || "MinUnlockLevel" != null)
					{
						array[22] = "MinUnlockLevel";
						if ("MaxUnlockLevel" == null || "MaxUnlockLevel" != null)
						{
							break;
						}
					}
				}
				array[23] = "MaxUnlockLevel";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003782")]
		[Cpp2IlInjected.Address(RVA = "0x31FA9B0", Offset = "0x31F93B0", VA = "0x1831FA9B0")]
		[DebuggerNonUserCode]
		public CustomStepPurchaseItem()
		{
			AnyItemSelector anyItemSelector = (itemToPurchase_ = new AnyItemSelector());
			StepAmount stepAmount = (itemToPurchaseAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003783")]
		[Cpp2IlInjected.Address(RVA = "0x31FA4B0", Offset = "0x31F8EB0", VA = "0x1831FA4B0")]
		private void OnConstruction()
		{
			AnyItemSelector anyItemSelector = (itemToPurchase_ = new AnyItemSelector());
			StepAmount stepAmount = (itemToPurchaseAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003784")]
		[Cpp2IlInjected.Address(RVA = "0x31FAA50", Offset = "0x31F9450", VA = "0x1831FAA50")]
		[DebuggerNonUserCode]
		public CustomStepPurchaseItem(CustomStepPurchaseItem other)
		{
			//IL_004d: Expected O, but got I4
			//IL_0090: Expected I4, but got I8
			AnyItemSelector anyItemSelector = (itemToPurchase_ = new AnyItemSelector());
			StepAmount stepAmount = (itemToPurchaseAmount_ = new StepAmount());
			bool flag = other.mustPurchaseSpecificItems_;
			int num = 0;
			mustPurchaseSpecificItems_ = flag;
			AnyItemSelector anyItemSelector2 = other.itemToPurchase_;
			if (anyItemSelector2 != null)
			{
				AnyItemSelector anyItemSelector3 = anyItemSelector2.Clone();
			}
			itemToPurchase_ = (AnyItemSelector)num;
			StepAmount stepAmount2 = other.itemToPurchaseAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			itemToPurchaseAmount_ = stepAmount3;
			if (other.locationCase_ == LocationOneofCase.Store)
			{
				int store = other.Store;
				location_ = typeof(int).TypeHandle;
				locationCase_ = LocationOneofCase.Store;
			}
			if ((long)typeof(int).TypeHandle == 6)
			{
				string text = (Shop = other.Shop);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003785")]
		[Cpp2IlInjected.Address(RVA = "0x31F9A30", Offset = "0x31F8430", VA = "0x1831F9A30", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepPurchaseItem Clone()
		{
			return new CustomStepPurchaseItem(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003791")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearLocation()
		{
			//IL_0010: Expected O, but got I4
			location_ = (locationCase_ = LocationOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003792")]
		[Cpp2IlInjected.Address(RVA = "0x31F9BE0", Offset = "0x31F85E0", VA = "0x1831F9BE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = default(int);
				if ((IntPtr)(mustPurchaseSpecificItems_ ? 1 : 0) == (IntPtr)typeof(CustomStepPurchaseItem).TypeHandle && object.Equals(itemToPurchase_, other) && object.Equals(itemToPurchaseAmount_, other) && Store == num)
				{
					string text = default(string);
					bool flag = Shop != text;
					if (!flag && locationCase_ == (flag ? ((LocationOneofCase)1) : LocationOneofCase.None))
					{
						return object.Equals(_unknownFields, text);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003793")]
		[Cpp2IlInjected.Address(RVA = "0x31F9D10", Offset = "0x31F8710", VA = "0x1831F9D10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepPurchaseItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.mustPurchaseSpecificItems_;
				if (mustPurchaseSpecificItems_ == flag)
				{
					AnyItemSelector objB = other.itemToPurchase_;
					if (object.Equals(itemToPurchase_, objB))
					{
						StepAmount objB2 = other.itemToPurchaseAmount_;
						if (object.Equals(itemToPurchaseAmount_, objB2))
						{
							int store = Store;
							int store2 = other.Store;
							if (store == store2)
							{
								string shop = Shop;
								string shop2 = other.Shop;
								if (!(shop != shop2))
								{
									LocationOneofCase locationOneofCase = other.locationCase_;
									if (locationCase_ == locationOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003794")]
		[Cpp2IlInjected.Address(RVA = "0x31F9F50", Offset = "0x31F8950", VA = "0x1831F9F50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			bool flag = mustPurchaseSpecificItems_;
			int num = 0;
			if (flag)
			{
			}
			AnyItemSelector anyItemSelector = itemToPurchase_;
			if (anyItemSelector != null)
			{
				int hashCode = anyItemSelector.GetHashCode();
			}
			StepAmount stepAmount = itemToPurchaseAmount_;
			if (stepAmount != null)
			{
				int hashCode2 = stepAmount.GetHashCode();
			}
			if (locationCase_ == LocationOneofCase.Store)
			{
				if (locationCase_ != LocationOneofCase.Store)
				{
				}
				object obj = location_;
			}
			if (locationCase_ == LocationOneofCase.Shop)
			{
				if (locationCase_ != LocationOneofCase.Shop)
				{
				}
				object obj2 = location_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode3 = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003795")]
		[Cpp2IlInjected.Address(RVA = "0x31FA720", Offset = "0x31F9120", VA = "0x1831FA720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003796")]
		[Cpp2IlInjected.Address(RVA = "0x31FA780", Offset = "0x31F9180", VA = "0x1831FA780", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008f
			do
			{
				if (mustPurchaseSpecificItems_)
				{
					bool value = mustPurchaseSpecificItems_;
					output.WriteBool(value);
				}
				if ((long)itemToPurchase_ != 0)
				{
					AnyItemSelector value2 = itemToPurchase_;
					output.WriteMessage(value2);
				}
				if ((long)itemToPurchaseAmount_ != 0)
				{
					StepAmount value3 = itemToPurchaseAmount_;
					output.WriteMessage(value3);
				}
			}
			while (locationCase_ != LocationOneofCase.Store);
			int store = Store;
			output.WriteInt32(store);
			if (locationCase_ == LocationOneofCase.Shop)
			{
				string shop = Shop;
				output.WriteString(shop);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003797")]
		[Cpp2IlInjected.Address(RVA = "0x31F96F0", Offset = "0x31F80F0", VA = "0x1831F96F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			while (true)
			{
				AnyItemSelector anyItemSelector = itemToPurchase_;
				if (anyItemSelector != null)
				{
					int num = CodedOutputStream.ComputeMessageSize(anyItemSelector);
					num++;
				}
				StepAmount stepAmount = itemToPurchaseAmount_;
				if (stepAmount != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num2++;
				}
				int num3 = 0;
				if (locationCase_ == LocationOneofCase.Store)
				{
					if (locationCase_ != LocationOneofCase.Store)
					{
					}
					object obj = location_;
				}
				if (locationCase_ == LocationOneofCase.Shop)
				{
					if (locationCase_ != LocationOneofCase.Shop)
					{
					}
					object obj2 = location_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					return unknownFields.CalculateSize();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003798")]
		[Cpp2IlInjected.Address(RVA = "0x31FA340", Offset = "0x31F8D40", VA = "0x1831FA340", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepPurchaseItem other)
		{
			//Discarded unreachable code: IL_00d9
			if (other == null)
			{
				return;
			}
			bool flag = other.mustPurchaseSpecificItems_;
			if (flag)
			{
				mustPurchaseSpecificItems_ = flag;
			}
			if ((long)other.itemToPurchase_ != 0)
			{
				AnyItemSelector anyItemSelector2 = default(AnyItemSelector);
				if (itemToPurchase_ == null)
				{
					AnyItemSelector anyItemSelector = (itemToPurchase_ = new AnyItemSelector());
					anyItemSelector2 = itemToPurchase_;
				}
				AnyItemSelector other2 = other.itemToPurchase_;
				anyItemSelector2.MergeFrom(other2);
			}
			if ((long)other.itemToPurchaseAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (itemToPurchaseAmount_ == null)
				{
					StepAmount stepAmount = (itemToPurchaseAmount_ = new StepAmount());
					stepAmount2 = itemToPurchaseAmount_;
				}
				StepAmount other3 = other.itemToPurchaseAmount_;
				stepAmount2.MergeFrom(other3);
			}
			int num = default(int);
			if (other.locationCase_ == LocationOneofCase.Store)
			{
				num = (Store = other.Store);
			}
			if (num == 6)
			{
				string text = (Shop = other.Shop);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003799")]
		[Cpp2IlInjected.Address(RVA = "0x31FA1A0", Offset = "0x31F8BA0", VA = "0x1831FA1A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00bc
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					StepAmount stepAmount = itemToPurchaseAmount_;
					if (stepAmount == null)
					{
						StepAmount stepAmount2 = (itemToPurchaseAmount_ = new StepAmount());
					}
					input.ReadMessage(stepAmount);
				}
				int num3 = default(int);
				if (num == 40)
				{
					num3 = (Store = input.ReadInt32());
				}
				if (num3 != 50)
				{
					goto IL_00a5;
				}
				string text2 = (Shop = input.ReadString());
			}
			bool flag = default(bool);
			if (num == 8)
			{
				flag = (mustPurchaseSpecificItems_ = input.ReadBool());
			}
			if (flag)
			{
				AnyItemSelector builder = default(AnyItemSelector);
				if (itemToPurchase_ == null)
				{
					AnyItemSelector anyItemSelector = (itemToPurchase_ = new AnyItemSelector());
					builder = itemToPurchase_;
				}
				input.ReadMessage(builder);
			}
			goto IL_00a5;
			IL_00a5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600379A")]
		[Cpp2IlInjected.Address(RVA = "0x31F9E00", Offset = "0x31F8800", VA = "0x1831F9E00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				bool flag = mustPurchaseSpecificItems_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600379B")]
		[Cpp2IlInjected.Address(RVA = "0x31FA540", Offset = "0x31F8F40", VA = "0x1831FA540", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_001a, IL_0020, IL_0026
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				mustPurchaseSpecificItems_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600379C")]
		[Cpp2IlInjected.Address(RVA = "0x31F98E0", Offset = "0x31F82E0", VA = "0x1831F98E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e
			if (fieldNumber - 1 <= 5)
			{
				mustPurchaseSpecificItems_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600379D")]
		[Cpp2IlInjected.Address(RVA = "0x31FA0F0", Offset = "0x31F8AF0", VA = "0x1831FA0F0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Location"))
			{
				LocationOneofCase locationOneofCase = locationCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600379E")]
		[Cpp2IlInjected.Address(RVA = "0x31F99C0", Offset = "0x31F83C0", VA = "0x1831F99C0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Location"))
			{
				location_ = (locationCase_ = LocationOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037A2")]
		[Cpp2IlInjected.Address(RVA = "0x31F9A90", Offset = "0x31F8490", VA = "0x1831F9A90", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_006d
			if (itemToPurchaseAmount_.IsValueSmallerThen(1) && context.IsMissionStep)
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 1+ in " + missionStepName;
				context.AddInvalidMemberError(message, "ItemToPurchaseAmount");
			}
			if (locationCase_ == LocationOneofCase.Store && Store != 0)
			{
				int store = Store;
				string missionStepName2 = context.MissionStepName;
				string error = "Please change Location.Store since it only support ScroogeGeneralStore in " + missionStepName2;
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037A3")]
		[Cpp2IlInjected.Address(RVA = "0x31FA8A0", Offset = "0x31F92A0", VA = "0x1831FA8A0")]
		static CustomStepPurchaseItem()
		{
			Func<CustomStepPurchaseItem> func = default(Func<CustomStepPurchaseItem>);
			_parser = (MessageParser<CustomStepPurchaseItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
