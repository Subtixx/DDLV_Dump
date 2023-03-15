using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000507")]
	public sealed class CustomStepGiftToCharacterItem : IMessage<CustomStepGiftToCharacterItem>, IMessage, IEquatable<CustomStepGiftToCharacterItem>, IDeepCloneable<CustomStepGiftToCharacterItem>, IMessageFieldAccessor, IMessageOneofAccessor, IItemSelector, IStepAmount, ITargetCharacterOverride, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000508")]
		public enum TargetOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001AE9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001AEA")]
			CharacterID,
			[Cpp2IlInjected.Token(Token = "0x4001AEB")]
			UniverseTagItemID
		}

		[Cpp2IlInjected.Token(Token = "0x4001ADA")]
		private static readonly MessageParser<CustomStepGiftToCharacterItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001ADB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001ADC")]
		public const int CharacterIDFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001ADD")]
		public const int UniverseTagItemIDFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001ADE")]
		public const int TargetItemFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001ADF")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001AE0")]
		public const int TargetAmountFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AE1")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x4001AE2")]
		public const int MustBeFavoriteThingFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001AE3")]
		private bool mustBeFavoriteThing_;

		[Cpp2IlInjected.Token(Token = "0x4001AE4")]
		public const int UseDifferentCharacterFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4001AE5")]
		private bool useDifferentCharacter_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001AE6")]
		private object target_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001AE7")]
		private TargetOneofCase targetCase_;

		[Cpp2IlInjected.Token(Token = "0x17000FF1")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepGiftToCharacterItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003E33")]
			[Cpp2IlInjected.Address(RVA = "0x34EDF20", Offset = "0x34EC920", VA = "0x1834EDF20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E34")]
			[Cpp2IlInjected.Address(RVA = "0x34EDE50", Offset = "0x34EC850", VA = "0x1834EDE50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003E35")]
			[Cpp2IlInjected.Address(RVA = "0x34EE440", Offset = "0x34ECE40", VA = "0x1834EE440", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF4")]
		[DebuggerNonUserCode]
		public int CharacterID
		{
			[Cpp2IlInjected.Token(Token = "0x6003E3A")]
			[Cpp2IlInjected.Address(RVA = "0x34EDD30", Offset = "0x34EC730", VA = "0x1834EDD30")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetCase_ == TargetOneofCase.CharacterID)
				{
					object obj = target_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E3B")]
			[Cpp2IlInjected.Address(RVA = "0x34EE550", Offset = "0x34ECF50", VA = "0x1834EE550")]
			set
			{
				//IL_0009: Expected I4, but got I8
				targetCase_ = TargetOneofCase.CharacterID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF5")]
		[DebuggerNonUserCode]
		public int UniverseTagItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6003E3C")]
			[Cpp2IlInjected.Address(RVA = "0x34EE230", Offset = "0x34ECC30", VA = "0x1834EE230")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetCase_ == TargetOneofCase.UniverseTagItemID)
				{
					object obj = target_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E3D")]
			[Cpp2IlInjected.Address(RVA = "0x34EE5C0", Offset = "0x34ECFC0", VA = "0x1834EE5C0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.UniverseTagItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF6")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E3E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E3F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF7")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E40")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E41")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF8")]
		[DebuggerNonUserCode]
		public bool MustBeFavoriteThing
		{
			[Cpp2IlInjected.Token(Token = "0x6003E42")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return mustBeFavoriteThing_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E43")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				mustBeFavoriteThing_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF9")]
		[DebuggerNonUserCode]
		public bool UseDifferentCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6003E44")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return useDifferentCharacter_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003E45")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				useDifferentCharacter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFA")]
		[DebuggerNonUserCode]
		public TargetOneofCase TargetCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003E46")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return targetCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFB")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003E55")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "16")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFC")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E56")]
			[Cpp2IlInjected.Address(RVA = "0x34EDDA0", Offset = "0x34EC7A0", VA = "0x1834EDDA0")]
			get
			{
				if (targetCase_ == TargetOneofCase.CharacterID)
				{
					object obj = target_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFD")]
		public Item UniverseTagItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003E57")]
			[Cpp2IlInjected.Address(RVA = "0x34EE2A0", Offset = "0x34ECCA0", VA = "0x1834EE2A0")]
			get
			{
				if (targetCase_ == TargetOneofCase.UniverseTagItemID)
				{
					object obj = target_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFE")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003E58")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFF")]
		public (Item? characterItem, bool random) TargetCharacterOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6003E59")]
			[Cpp2IlInjected.Address(RVA = "0x34EE190", Offset = "0x34ECB90", VA = "0x1834EE190", Slot = "18")]
			get
			{
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					Item item = default(Item);
					int itemID = item.ItemID;
				}
				int num2 = 0;
				int num3 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001000")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003E5A")]
			[Cpp2IlInjected.Address(RVA = "0x34EDF80", Offset = "0x34EC980", VA = "0x1834EDF80", Slot = "19")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("TargetCharacter" != null && "TargetCharacter" == null)
					{
						continue;
					}
					array[0] = "TargetCharacter";
					if ("UniverseTag" != null && "UniverseTag" == null)
					{
						continue;
					}
					array[1] = "UniverseTag";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[2] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[3] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001001")]
		public bool UseAny
		{
			[Cpp2IlInjected.Token(Token = "0x6003E5B")]
			[Cpp2IlInjected.Address(RVA = "0x34EE350", Offset = "0x34ECD50", VA = "0x1834EE350")]
			get
			{
				if (targetCase_ == TargetOneofCase.CharacterID && (object)CharacterItem != null)
				{
					return true;
				}
				if (targetCase_ != TargetOneofCase.UniverseTagItemID)
				{
					int num = 0;
				}
				Item universeTagItem = UniverseTagItem;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E36")]
		[Cpp2IlInjected.Address(RVA = "0x34EDC10", Offset = "0x34EC610", VA = "0x1834EDC10")]
		[DebuggerNonUserCode]
		public CustomStepGiftToCharacterItem()
		{
			//IL_0022: Expected I4, but got I8
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			Item invalid = Item.Invalid;
			targetCase_ = TargetOneofCase.CharacterID;
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E37")]
		[Cpp2IlInjected.Address(RVA = "0x34ED3C0", Offset = "0x34EBDC0", VA = "0x1834ED3C0")]
		private void OnConstruction()
		{
			//IL_001c: Expected I4, but got I8
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			Item invalid = Item.Invalid;
			targetCase_ = TargetOneofCase.CharacterID;
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E38")]
		[Cpp2IlInjected.Address(RVA = "0x34ED9D0", Offset = "0x34EC3D0", VA = "0x1834ED9D0")]
		[DebuggerNonUserCode]
		public CustomStepGiftToCharacterItem(CustomStepGiftToCharacterItem other)
		{
			//IL_0022: Expected I4, but got I8
			//IL_004d: Expected O, but got I4
			//IL_00b0: Expected I4, but got I8
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			Item invalid = Item.Invalid;
			targetCase_ = TargetOneofCase.CharacterID;
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			ItemSelector itemSelector2 = other.targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			targetAmount_ = stepAmount3;
			bool flag = (mustBeFavoriteThing_ = other.mustBeFavoriteThing_);
			bool flag2 = (useDifferentCharacter_ = other.useDifferentCharacter_);
			if (other.targetCase_ == TargetOneofCase.CharacterID)
			{
				int characterID = other.CharacterID;
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.CharacterID;
			}
			if ((long)typeof(int).TypeHandle == 2)
			{
				int num2 = (UniverseTagItemID = other.UniverseTagItemID);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003E39")]
		[Cpp2IlInjected.Address(RVA = "0x34EC7A0", Offset = "0x34EB1A0", VA = "0x1834EC7A0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepGiftToCharacterItem Clone()
		{
			return new CustomStepGiftToCharacterItem(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E47")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearTarget()
		{
			//IL_0010: Expected O, but got I4
			target_ = (targetCase_ = TargetOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E48")]
		[Cpp2IlInjected.Address(RVA = "0x34ECA40", Offset = "0x34EB440", VA = "0x1834ECA40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0039: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int characterID = CharacterID;
				int num = default(int);
				if (characterID == num)
				{
					int universeTagItemID = UniverseTagItemID;
					int num2 = 0;
					characterID = universeTagItemID;
					int num3 = default(int);
					if (characterID == num3 && object.Equals(targetItem_, num2))
					{
						bool flag = object.Equals(targetAmount_, num2);
						if (flag && mustBeFavoriteThing_ == flag && useDifferentCharacter_ == flag && targetCase_ == (flag ? TargetOneofCase.CharacterID : TargetOneofCase.None))
						{
							return object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E49")]
		[Cpp2IlInjected.Address(RVA = "0x34EC950", Offset = "0x34EB350", VA = "0x1834EC950", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepGiftToCharacterItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int characterID = CharacterID;
				int characterID2 = other.CharacterID;
				if (characterID == characterID2)
				{
					characterID = UniverseTagItemID;
					int universeTagItemID = other.UniverseTagItemID;
					if (characterID == universeTagItemID)
					{
						ItemSelector objB = other.targetItem_;
						if (object.Equals(targetItem_, objB))
						{
							StepAmount objB2 = other.targetAmount_;
							if (object.Equals(targetAmount_, objB2))
							{
								bool flag = other.mustBeFavoriteThing_;
								if (mustBeFavoriteThing_ == flag)
								{
									bool flag2 = other.useDifferentCharacter_;
									if (useDifferentCharacter_ == flag2)
									{
										TargetOneofCase targetOneofCase = other.targetCase_;
										if (targetCase_ == targetOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x6003E4A")]
		[Cpp2IlInjected.Address(RVA = "0x34ECCD0", Offset = "0x34EB6D0", VA = "0x1834ECCD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0087
			int num = 0;
			if (targetCase_ == TargetOneofCase.CharacterID)
			{
				if (targetCase_ != TargetOneofCase.CharacterID)
				{
				}
				object obj = target_;
			}
			if (targetCase_ == TargetOneofCase.UniverseTagItemID && targetCase_ == TargetOneofCase.UniverseTagItemID)
			{
				object obj2 = target_;
			}
			ItemSelector itemSelector = targetItem_;
			if (itemSelector != null)
			{
				int hashCode = itemSelector.GetHashCode();
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int hashCode2 = stepAmount.GetHashCode();
			}
			if (mustBeFavoriteThing_)
			{
			}
			if (useDifferentCharacter_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E4B")]
		[Cpp2IlInjected.Address(RVA = "0x34ED710", Offset = "0x34EC110", VA = "0x1834ED710", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E4C")]
		[Cpp2IlInjected.Address(RVA = "0x34ED770", Offset = "0x34EC170", VA = "0x1834ED770", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a7
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.CharacterID)
			{
				int characterID = CharacterID;
				output.WriteInt32(characterID);
			}
			if (targetOneofCase == TargetOneofCase.UniverseTagItemID)
			{
				int universeTagItemID = UniverseTagItemID;
				output.WriteInt32(universeTagItemID);
			}
			if ((long)targetItem_ != 0)
			{
				ItemSelector value = targetItem_;
				output.WriteMessage(value);
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value2 = targetAmount_;
				output.WriteMessage(value2);
			}
			if (mustBeFavoriteThing_)
			{
				bool value3 = mustBeFavoriteThing_;
				output.WriteBool(value3);
			}
			if (useDifferentCharacter_)
			{
				bool value4 = useDifferentCharacter_;
				output.WriteBool(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003E4D")]
		[Cpp2IlInjected.Address(RVA = "0x34EC4C0", Offset = "0x34EAEC0", VA = "0x1834EC4C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a3
			int num = 0;
			if (targetCase_ == TargetOneofCase.CharacterID)
			{
				if (targetCase_ == TargetOneofCase.CharacterID)
				{
					object obj = target_;
				}
				int num2 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (targetCase_ == TargetOneofCase.UniverseTagItemID)
			{
				if (targetCase_ == TargetOneofCase.UniverseTagItemID)
				{
					object obj2 = target_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			ItemSelector itemSelector = targetItem_;
			if (itemSelector != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(itemSelector);
				num4++;
				num += num4;
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num5++;
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

		[Cpp2IlInjected.Token(Token = "0x6003E4E")]
		[Cpp2IlInjected.Address(RVA = "0x34ED090", Offset = "0x34EBA90", VA = "0x1834ED090", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepGiftToCharacterItem other)
		{
			//Discarded unreachable code: IL_00f3
			if (other == null)
			{
				return;
			}
			if ((long)other.targetItem_ != 0)
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetItem_ = new ItemSelector());
					ItemSelector itemSelector3 = targetItem_;
				}
				ItemSelector other2 = other.targetItem_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other3 = other.targetAmount_;
				stepAmount2.MergeFrom(other3);
			}
			bool flag = other.mustBeFavoriteThing_;
			if (flag)
			{
				mustBeFavoriteThing_ = flag;
			}
			bool flag2 = other.useDifferentCharacter_;
			if (flag2)
			{
				useDifferentCharacter_ = flag2;
			}
			int num = default(int);
			if (other.targetCase_ == TargetOneofCase.CharacterID)
			{
				num = (CharacterID = other.CharacterID);
			}
			if (num == 2)
			{
				int num2 = (UniverseTagItemID = other.UniverseTagItemID);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E4F")]
		[Cpp2IlInjected.Address(RVA = "0x34ED210", Offset = "0x34EBC10", VA = "0x1834ED210", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00d2
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if (num == 50)
				{
					StepAmount stepAmount = targetAmount_;
					if (stepAmount == null)
					{
						StepAmount stepAmount2 = (targetAmount_ = new StepAmount());
					}
					input.ReadMessage(stepAmount);
				}
				bool flag = default(bool);
				if (num == 56)
				{
					flag = (mustBeFavoriteThing_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_00bb;
				}
				bool flag2 = (useDifferentCharacter_ = input.ReadBool());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (CharacterID = input.ReadInt32());
			}
			int num5 = default(int);
			if (num3 == 16)
			{
				num5 = (UniverseTagItemID = input.ReadInt32());
			}
			if (num5 == 42)
			{
				ItemSelector builder = default(ItemSelector);
				if (targetItem_ == null)
				{
					ItemSelector itemSelector = (targetItem_ = new ItemSelector());
					builder = targetItem_;
				}
				input.ReadMessage(builder);
			}
			goto IL_00bb;
			IL_00bb:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003E50")]
		[Cpp2IlInjected.Address(RVA = "0x34ECB60", Offset = "0x34EB560", VA = "0x1834ECB60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				int characterID = CharacterID;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E51")]
		[Cpp2IlInjected.Address(RVA = "0x34ED4E0", Offset = "0x34EBEE0", VA = "0x1834ED4E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_0012, IL_001a, IL_0022, IL_0028, IL_002e, IL_0034
			//IL_0011: Expected O, but got I4
			if (fieldNumber - 1 > 7)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E52")]
		[Cpp2IlInjected.Address(RVA = "0x34EC6B0", Offset = "0x34EB0B0", VA = "0x1834EC6B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			if (fieldNumber <= 7)
			{
				int num2 = (CharacterID = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E53")]
		[Cpp2IlInjected.Address(RVA = "0x34ECE80", Offset = "0x34EB880", VA = "0x1834ECE80", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				TargetOneofCase targetOneofCase = targetCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E54")]
		[Cpp2IlInjected.Address(RVA = "0x34EC730", Offset = "0x34EB130", VA = "0x1834EC730", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				target_ = (targetCase_ = TargetOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E5C")]
		[Cpp2IlInjected.Address(RVA = "0x34ECF30", Offset = "0x34EB930", VA = "0x1834ECF30")]
		public unsafe bool IsValid(Item characterItem)
		{
			//Discarded unreachable code: IL_003c
			if (!UseAny)
			{
				TargetOneofCase targetOneofCase = targetCase_;
				if (targetOneofCase != TargetOneofCase.CharacterID)
				{
					if (targetOneofCase != TargetOneofCase.UniverseTagItemID)
					{
						int num = 0;
					}
					CharacterItemData characterItemData = default(CharacterItemData);
					Item universeTag = characterItemData.GetUniverseTag();
					Item universeTagItem = UniverseTagItem;
					return *(Item*)universeTag == *(Item*)universeTagItem;
				}
				Item characterItem2 = CharacterItem;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E5D")]
		[Cpp2IlInjected.Address(RVA = "0x31FC4E0", Offset = "0x31FAEE0", VA = "0x1831FC4E0", Slot = "20")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			targetAmount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003E5E")]
		[Cpp2IlInjected.Address(RVA = "0x34EC800", Offset = "0x34EB200", VA = "0x1834EC800", Slot = "21")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_006b
			if (targetCase_ == TargetOneofCase.None)
			{
				context.AddError("Please select a Target (cannot be none)");
			}
			if (useDifferentCharacter_ && targetCase_ == TargetOneofCase.CharacterID)
			{
				Item characterItem = CharacterItem;
				bool flag = default(bool);
				if (flag)
				{
					context.AddError("UseDifferentCharacter must not be used when you select a specific character");
				}
			}
			ItemSelector itemSelector = targetItem_;
			if (itemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.FilterGenerator && itemSelector.FilterGenerator.type_ != ItemType.ActivityItem)
			{
				context.AddInvalidMemberError("FilterGenerator filter should be ActivityItem", "TargetItem");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003E5F")]
		[Cpp2IlInjected.Address(RVA = "0x34ED8C0", Offset = "0x34EC2C0", VA = "0x1834ED8C0")]
		static CustomStepGiftToCharacterItem()
		{
			Func<CustomStepGiftToCharacterItem> func = default(Func<CustomStepGiftToCharacterItem>);
			_parser = (MessageParser<CustomStepGiftToCharacterItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
