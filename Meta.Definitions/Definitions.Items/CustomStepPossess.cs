using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200048F")]
	public sealed class CustomStepPossess : IMessage<CustomStepPossess>, IMessage, IEquatable<CustomStepPossess>, IDeepCloneable<CustomStepPossess>, IMessageFieldAccessor, IItemSelector, IStepAmount, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400187D")]
		private static readonly MessageParser<CustomStepPossess> _parser = (MessageParser<CustomStepPossess>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CustomStepPossess()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400187E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400187F")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001880")]
		private ItemSelector item_;

		[Cpp2IlInjected.Token(Token = "0x4001881")]
		public const int ItemAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001882")]
		private StepAmount itemAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001883")]
		public const int IncludeStorageFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001884")]
		private bool includeStorage_;

		[Cpp2IlInjected.Token(Token = "0x4001885")]
		public const int UseDifferentItemFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4001886")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x4001887")]
		public const int AutoConfirmFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4001888")]
		private bool autoConfirm_;

		[Cpp2IlInjected.Token(Token = "0x4001889")]
		private static readonly HashSet<ItemType> supportedTypes;

		[Cpp2IlInjected.Token(Token = "0x17000E44")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepPossess> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60037F2")]
			[Cpp2IlInjected.Address(RVA = "0x31F8A80", Offset = "0x31F7480", VA = "0x1831F8A80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E45")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037F3")]
			[Cpp2IlInjected.Address(RVA = "0x31F89B0", Offset = "0x31F73B0", VA = "0x1831F89B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E46")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60037F4")]
			[Cpp2IlInjected.Address(RVA = "0x31F95E0", Offset = "0x31F7FE0", VA = "0x1831F95E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E47")]
		[DebuggerNonUserCode]
		public ItemSelector Item
		{
			[Cpp2IlInjected.Token(Token = "0x60037F9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x60037FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E48")]
		[DebuggerNonUserCode]
		public StepAmount ItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60037FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60037FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E49")]
		[DebuggerNonUserCode]
		public bool IncludeStorage
		{
			[Cpp2IlInjected.Token(Token = "0x60037FD")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return includeStorage_;
			}
			[Cpp2IlInjected.Token(Token = "0x60037FE")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				includeStorage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4A")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x60037FF")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003800")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4B")]
		[DebuggerNonUserCode]
		public bool AutoConfirm
		{
			[Cpp2IlInjected.Token(Token = "0x6003801")]
			[Cpp2IlInjected.Address(RVA = "0xDC7980", Offset = "0xDC6380", VA = "0x180DC7980")]
			get
			{
				return autoConfirm_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003802")]
			[Cpp2IlInjected.Address(RVA = "0xDC79A0", Offset = "0xDC63A0", VA = "0x180DC79A0")]
			set
			{
				autoConfirm_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4C")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x600380E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return item_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4D")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600380F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "15")]
			get
			{
				return itemAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E4E")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003810")]
			[Cpp2IlInjected.Address(RVA = "0x31F8AE0", Offset = "0x31F74E0", VA = "0x1831F8AE0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x60037F5")]
		[Cpp2IlInjected.Address(RVA = "0x31F8910", Offset = "0x31F7310", VA = "0x1831F8910")]
		[DebuggerNonUserCode]
		public CustomStepPossess()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037F6")]
		[Cpp2IlInjected.Address(RVA = "0x31F8100", Offset = "0x31F6B00", VA = "0x1831F8100")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60037F7")]
		[Cpp2IlInjected.Address(RVA = "0x31F87C0", Offset = "0x31F71C0", VA = "0x1831F87C0")]
		[DebuggerNonUserCode]
		public CustomStepPossess(CustomStepPossess other)
		{
			//IL_003c: Expected O, but got I4
			ItemSelector itemSelector = (item_ = new ItemSelector());
			StepAmount stepAmount = (itemAmount_ = new StepAmount());
			ItemSelector itemSelector2 = other.item_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			item_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.itemAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			itemAmount_ = stepAmount3;
			bool flag = (includeStorage_ = other.includeStorage_);
			bool flag2 = (useDifferentItem_ = other.useDifferentItem_);
			bool flag3 = (autoConfirm_ = other.autoConfirm_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037F8")]
		[Cpp2IlInjected.Address(RVA = "0x31F7170", Offset = "0x31F5B70", VA = "0x1831F7170", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepPossess Clone()
		{
			//Discarded unreachable code: IL_00a3
			//IL_003e: Expected O, but got I4
			CustomStepPossess customStepPossess = new CustomStepPossess();
			ItemSelector itemSelector = (customStepPossess.item_ = new ItemSelector());
			StepAmount stepAmount = (customStepPossess.itemAmount_ = new StepAmount());
			ItemSelector itemSelector2 = item_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			customStepPossess.item_ = (ItemSelector)num;
			StepAmount stepAmount2 = itemAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepPossess.itemAmount_ = stepAmount3;
			bool flag = (customStepPossess.includeStorage_ = includeStorage_);
			bool flag2 = (customStepPossess.useDifferentItem_ = useDifferentItem_);
			bool flag3 = (customStepPossess.autoConfirm_ = autoConfirm_);
			UnknownFieldSet unknownFieldSet = (customStepPossess._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepPossess;
		}

		[Cpp2IlInjected.Token(Token = "0x6003803")]
		[Cpp2IlInjected.Address(RVA = "0x31F7AE0", Offset = "0x31F64E0", VA = "0x1831F7AE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(item_, other))
				{
					bool flag = object.Equals(itemAmount_, other);
					if (flag && includeStorage_ == flag && useDifferentItem_ == flag && autoConfirm_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003804")]
		[Cpp2IlInjected.Address(RVA = "0x31F7A40", Offset = "0x31F6440", VA = "0x1831F7A40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepPossess other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.item_;
				if (object.Equals(item_, objB))
				{
					StepAmount objB2 = other.itemAmount_;
					if (object.Equals(itemAmount_, objB2))
					{
						bool flag = other.includeStorage_;
						if (includeStorage_ == flag)
						{
							bool flag2 = other.useDifferentItem_;
							if (useDifferentItem_ == flag2)
							{
								bool flag3 = other.autoConfirm_;
								if (autoConfirm_ == flag3)
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

		[Cpp2IlInjected.Token(Token = "0x6003805")]
		[Cpp2IlInjected.Address(RVA = "0x31F7CB0", Offset = "0x31F66B0", VA = "0x1831F7CB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = item_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = itemAmount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				if (includeStorage_)
				{
				}
				if (useDifferentItem_)
				{
				}
				if (autoConfirm_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003806")]
		[Cpp2IlInjected.Address(RVA = "0x31F8360", Offset = "0x31F6D60", VA = "0x1831F8360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003807")]
		[Cpp2IlInjected.Address(RVA = "0x31F8500", Offset = "0x31F6F00", VA = "0x1831F8500", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008f
			if ((long)item_ != 0)
			{
				ItemSelector value = item_;
				output.WriteMessage(value);
			}
			if ((long)itemAmount_ != 0)
			{
				StepAmount value2 = itemAmount_;
				output.WriteMessage(value2);
			}
			if (includeStorage_)
			{
				bool value3 = includeStorage_;
				output.WriteBool(value3);
			}
			if (useDifferentItem_)
			{
				bool value4 = useDifferentItem_;
				output.WriteBool(value4);
			}
			if (autoConfirm_)
			{
				bool value5 = autoConfirm_;
				output.WriteBool(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003808")]
		[Cpp2IlInjected.Address(RVA = "0x31F6EA0", Offset = "0x31F58A0", VA = "0x1831F6EA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = item_;
				num = 0;
				if (itemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
				}
				StepAmount stepAmount = itemAmount_;
				if (stepAmount != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003809")]
		[Cpp2IlInjected.Address(RVA = "0x31F7E30", Offset = "0x31F6830", VA = "0x1831F7E30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepPossess other)
		{
			//Discarded unreachable code: IL_00da
			if (other == null)
			{
				return;
			}
			if ((long)other.item_ != 0)
			{
				ItemSelector itemSelector = item_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (item_ = new ItemSelector());
					ItemSelector itemSelector3 = item_;
				}
				ItemSelector other2 = other.item_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.itemAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (itemAmount_ == null)
				{
					StepAmount stepAmount = (itemAmount_ = new StepAmount());
					stepAmount2 = itemAmount_;
				}
				StepAmount other3 = other.itemAmount_;
				stepAmount2.MergeFrom(other3);
			}
			bool flag = other.includeStorage_;
			if (flag)
			{
				includeStorage_ = flag;
			}
			bool flag2 = other.useDifferentItem_;
			if (flag2)
			{
				useDifferentItem_ = flag2;
			}
			bool flag3 = other.autoConfirm_;
			if (flag3)
			{
				autoConfirm_ = flag3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600380A")]
		[Cpp2IlInjected.Address(RVA = "0x31F7F80", Offset = "0x31F6980", VA = "0x1831F7F80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					bool flag = (includeStorage_ = input.ReadBool());
				}
				bool flag2 = default(bool);
				if (num == 32)
				{
					flag2 = (useDifferentItem_ = input.ReadBool());
				}
				if (!flag2)
				{
					goto IL_00ad;
				}
				bool flag3 = (autoConfirm_ = input.ReadBool());
			}
			ItemSelector itemSelector = default(ItemSelector);
			if (num == 10)
			{
				ItemSelector builder = default(ItemSelector);
				if (item_ == null)
				{
					itemSelector = (item_ = new ItemSelector());
					builder = item_;
				}
				input.ReadMessage(builder);
			}
			if ((long)itemSelector == 18)
			{
				StepAmount builder2 = default(StepAmount);
				if (itemAmount_ == null)
				{
					StepAmount stepAmount = (itemAmount_ = new StepAmount());
					builder2 = itemAmount_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00ad;
			IL_00ad:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600380B")]
		[Cpp2IlInjected.Address(RVA = "0x31F7BC0", Offset = "0x31F65C0", VA = "0x1831F7BC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num != 0 && num != 1)
					{
						goto IL_002d;
					}
					bool flag = includeStorage_;
				}
				StepAmount stepAmount = itemAmount_;
			}
			ItemSelector itemSelector = item_;
			goto IL_002d;
			IL_002d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600380C")]
		[Cpp2IlInjected.Address(RVA = "0x31F81A0", Offset = "0x31F6BA0", VA = "0x1831F81A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			//IL_0043: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							autoConfirm_ = (byte)(int)obj2 != 0;
							break;
						}
						case 0:
						{
							object obj = default(object);
							useDifferentItem_ = (byte)(int)obj != 0;
							break;
						}
						}
					}
					else
					{
						object obj3 = default(object);
						includeStorage_ = (byte)(int)obj3 != 0;
					}
				}
				else
				{
					int num2 = 0;
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					itemAmount_ = (StepAmount)num2;
				}
				return;
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600380D")]
		[Cpp2IlInjected.Address(RVA = "0x31F7120", Offset = "0x31F5B20", VA = "0x1831F7120", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0014
			if (fieldNumber == 1)
			{
				autoConfirm_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003811")]
		[Cpp2IlInjected.Address(RVA = "0x31F8190", Offset = "0x31F6B90", VA = "0x1831F8190", Slot = "17")]
		public void SetDefaultData()
		{
			autoConfirm_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003812")]
		[Cpp2IlInjected.Address(RVA = "0x31F7D90", Offset = "0x31F6790", VA = "0x1831F7D90")]
		public static bool IsValidPossessItemType(Item item)
		{
			//Discarded unreachable code: IL_0008
			HashSet<ItemType> hashSet = supportedTypes;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003813")]
		[Cpp2IlInjected.Address(RVA = "0x31F6F90", Offset = "0x31F5990", VA = "0x1831F6F90")]
		public bool CanIncludeStorage()
		{
			IEnumerable<Item> cpp2il__autoParamName__idx_ = (IEnumerable<Item>)item_.SelectedItems();
			Func<Item, bool> _003C_003E9__57_ = _003C_003Ec._003C_003E9__57_0;
			if (_003C_003E9__57_ == null)
			{
				ItemType itemType = default(ItemType);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => itemType == ItemType.ActivityItem);
			}
			if (!((IEnumerable<>)cpp2il__autoParamName__idx_).Any<Item>((Func<, >)(object)_003C_003E9__57_))
			{
				MissionItemGenerator filterGenerator = item_.FilterGenerator;
				if (filterGenerator == null || filterGenerator.type_ != ItemType.ActivityItem)
				{
					return item_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Variable;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003814")]
		[Cpp2IlInjected.Address(RVA = "0x31F72F0", Offset = "0x31F5CF0", VA = "0x1831F72F0", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0258
			//IL_0143: Expected O, but got I4
			//IL_0186: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			int num = 0;
			if ((autoConfirm_ ? 1 : 0) == num)
			{
				ItemSelector itemSelector = item_;
				if (itemSelector != null)
				{
					MissionItemGenerator item = itemSelector.Item;
					if (item != null)
					{
						GeneratorItem generatorItem = item.item_;
						if (generatorItem != null)
						{
							int item2 = generatorItem.Item;
						}
					}
				}
				ItemSelector itemSelector2 = item_;
				if (itemSelector2 != null)
				{
					MissionItemGenerator item3 = itemSelector2.Item;
					if (item3 != null)
					{
						GeneratorItemIngredient itemIngredient_ = item3.itemIngredient_;
						if (itemIngredient_ != null)
						{
							int item4 = itemIngredient_.Item;
						}
					}
				}
				ItemSelector itemSelector3 = item_;
				if (itemSelector3 != null)
				{
					MissionItemGenerator itemList = itemSelector3.ItemList;
					if (itemList != null)
					{
						GeneratorItem generatorItem2 = itemList.item_;
						if (generatorItem2 != null)
						{
							GeneratorItemList itemList2 = generatorItem2.ItemList;
							if (itemList2 != null)
							{
								RepeatedField<GeneratorWeightedItem> list_ = itemList2.list_;
								if (list_ != null && Enumerable.FirstOrDefault<GeneratorWeightedItem>((IEnumerable<>)(object)list_) == null)
								{
								}
							}
						}
					}
				}
				ItemSelector itemSelector4 = item_;
				if (itemSelector4 != null)
				{
					MissionItemGenerator itemList3 = itemSelector4.ItemList;
					if (itemList3 != null)
					{
						GeneratorItemIngredient itemIngredient_2 = itemList3.itemIngredient_;
						if (itemIngredient_2 != null)
						{
							GeneratorItemIngredientList itemList4 = itemIngredient_2.ItemList;
							if (itemList4 != null)
							{
								RepeatedField<GeneratorWeightedItemIngredient> list_2 = itemList4.list_;
								if (list_2 != null && Enumerable.FirstOrDefault<GeneratorWeightedItemIngredient>((IEnumerable<>)(object)list_2) == null)
								{
								}
							}
						}
					}
				}
			}
			ItemSelector itemSelector5 = item_;
			if (itemSelector5.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item)
			{
				int item5 = itemSelector5.Item.item_.Item;
				ItemType itemType = default(ItemType);
				ActivityItemType activityItemType = default(ActivityItemType);
				if (itemType == ItemType.ActivityItem && activityItemType == ActivityItemType.LootPresent)
				{
					ActivityItemType activityItemType2 = default(ActivityItemType);
					string text = $"{activityItemType2} is not allowed";
				}
			}
			ItemSelector itemSelector6 = item_;
			if (itemSelector6.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.FilterGenerator && itemSelector6.FilterGenerator.type_ == ItemType.ActivityItem && item_.FilterGenerator.activityItemType_ == ActivityItemType.LootPresent)
			{
				ActivityItemType activityItemType3 = default(ActivityItemType);
				string text2 = $"{activityItemType3} is not allowed";
			}
			if (!useDifferentItem_)
			{
				if (!itemAmount_.IsValueSmallerThen(1))
				{
					goto IL_01d9;
				}
				string text3 = default(string);
				string text4 = "Should be 1+ in " + text3;
			}
			if (item_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item || itemAmount_.IsValueSmallerThen(2))
			{
				string text5 = default(string);
				string text6 = "Cannot be enabled when targeting specific Item in " + text5;
			}
			goto IL_01d9;
			IL_01d9:
			if (!includeStorage_)
			{
				return;
			}
			IEnumerable<Item> cpp2il__autoParamName__idx_ = (IEnumerable<Item>)item_.SelectedItems();
			Func<Item, bool> cpp2il__autoParamName__idx_2 = default(Func<Item, bool>);
			if (_003C_003Ec._003C_003E9__57_0 == null)
			{
				ItemType itemType3 = default(ItemType);
				cpp2il__autoParamName__idx_2 = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => itemType3 == ItemType.ActivityItem));
			}
			if (!((IEnumerable<>)cpp2il__autoParamName__idx_).Any<Item>((Func<, >)(object)cpp2il__autoParamName__idx_2))
			{
				MissionItemGenerator filterGenerator = item_.FilterGenerator;
				if ((filterGenerator == null || filterGenerator.type_ != ItemType.ActivityItem) && item_.itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Variable)
				{
					ItemType itemType2 = default(ItemType);
					string text7 = $"Should be used only with {itemType2}";
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003815")]
		[Cpp2IlInjected.Address(RVA = "0x31F8610", Offset = "0x31F7010", VA = "0x1831F8610")]
		static CustomStepPossess()
		{
			ItemType[] array = new ItemType[8];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			_parser = (MessageParser<CustomStepPossess>)(object)new HashSet<T>((IEqualityComparer<>)(object)array);
			/*Error: Unexpected end of block*/;
		}
	}
}
