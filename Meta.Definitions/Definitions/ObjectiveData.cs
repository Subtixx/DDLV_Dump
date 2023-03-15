using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class ObjectiveData : IMessage<ObjectiveData>, IMessage, IEquatable<ObjectiveData>, IDeepCloneable<ObjectiveData>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, ICustomStepOwner, IItemSelector, IItemGeneratorOwner, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public enum ObjectiveOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			CatchFish = 21,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			CollectCurrency = 22,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			CookMeal = 23,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			MineMineral = 24,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			GardeningHarvest = 28,
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			GardeningPlant = 29,
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			PickUp = 31,
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			SellItem = 33,
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			RoyalDuties = 41,
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			StartDiscussion = 48,
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			GiftToCharacter = 49,
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			ServeRestaurantOrder = 56,
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			PurchaseItem = 57,
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			CraftItem = 58,
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			PetCompanion = 59,
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			TakePicture = 60,
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			HangoutWithCharacter = 61,
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			DigTile = 62
		}

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly MessageParser<ObjectiveData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public const int CatchFishFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public const int CollectCurrencyFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public const int CookMealFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public const int MineMineralFieldNumber = 24;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public const int GardeningHarvestFieldNumber = 28;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public const int GardeningPlantFieldNumber = 29;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public const int PickUpFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public const int SellItemFieldNumber = 33;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const int RoyalDutiesFieldNumber = 41;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public const int StartDiscussionFieldNumber = 48;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public const int GiftToCharacterFieldNumber = 49;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public const int ServeRestaurantOrderFieldNumber = 56;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public const int PurchaseItemFieldNumber = 57;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public const int CraftItemFieldNumber = 58;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public const int PetCompanionFieldNumber = 59;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public const int TakePictureFieldNumber = 60;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int HangoutWithCharacterFieldNumber = 61;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const int DigTileFieldNumber = 62;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private object objective_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private ObjectiveOneofCase objectiveCase_;

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectiveData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x2981260", Offset = "0x297FC60", VA = "0x182981260")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2980E90", Offset = "0x297F890", VA = "0x182980E90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x2981680", Offset = "0x2980080", VA = "0x182981680", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[DebuggerNonUserCode]
		public CustomStepCatchFish CatchFish
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2980D10", Offset = "0x297F710", VA = "0x182980D10")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.CatchFish)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2028E40", Offset = "0x2027840", VA = "0x182028E40")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		[DebuggerNonUserCode]
		public CustomStepCollectCurrency CollectCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2980D70", Offset = "0x297F770", VA = "0x182980D70")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.CollectCurrency)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x2028E00", Offset = "0x2027800", VA = "0x182028E00")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[DebuggerNonUserCode]
		public CustomStepCookMeal CookMeal
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x2980DD0", Offset = "0x297F7D0", VA = "0x182980DD0")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.CookMeal)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x2981790", Offset = "0x2980190", VA = "0x182981790")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[DebuggerNonUserCode]
		public CustomStepMineMineral MineMineral
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x2981200", Offset = "0x297FC00", VA = "0x182981200")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.MineMineral)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x2981890", Offset = "0x2980290", VA = "0x182981890")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[DebuggerNonUserCode]
		public CustomStepGardeningHarvest GardeningHarvest
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x2980FC0", Offset = "0x297F9C0", VA = "0x182980FC0")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.GardeningHarvest)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x2981810", Offset = "0x2980210", VA = "0x182981810")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[DebuggerNonUserCode]
		public CustomStepGardeningPlant GardeningPlant
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x2981020", Offset = "0x297FA20", VA = "0x182981020")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.GardeningPlant)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x22C8110", Offset = "0x22C6B10", VA = "0x1822C8110")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[DebuggerNonUserCode]
		public CustomStepPickUp PickUp
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x2981320", Offset = "0x297FD20", VA = "0x182981320")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.PickUp)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x29818D0", Offset = "0x29802D0", VA = "0x1829818D0")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		[DebuggerNonUserCode]
		public CustomStepSellItem SellItem
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x2981440", Offset = "0x297FE40", VA = "0x182981440")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.SellItem)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x2981910", Offset = "0x2980310", VA = "0x182981910")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[DebuggerNonUserCode]
		public CustomStepRoyalDuties RoyalDuties
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x29813E0", Offset = "0x297FDE0", VA = "0x1829813E0")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.RoyalDuties)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x2093600", Offset = "0x2092000", VA = "0x182093600")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[DebuggerNonUserCode]
		public CustomStepStartDiscussion StartDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x2981500", Offset = "0x297FF00", VA = "0x182981500")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.StartDiscussion)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x2981950", Offset = "0x2980350", VA = "0x182981950")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		[DebuggerNonUserCode]
		public CustomStepGiftToCharacterItem GiftToCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x2981080", Offset = "0x297FA80", VA = "0x182981080")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.GiftToCharacter)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x2981850", Offset = "0x2980250", VA = "0x182981850")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DebuggerNonUserCode]
		public CustomStepServeRestaurantOrder ServeRestaurantOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x29814A0", Offset = "0x297FEA0", VA = "0x1829814A0")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.ServeRestaurantOrder)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2093640", Offset = "0x2092040", VA = "0x182093640")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[DebuggerNonUserCode]
		public CustomStepPurchaseItem PurchaseItem
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x2981380", Offset = "0x297FD80", VA = "0x182981380")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.PurchaseItem)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x2093680", Offset = "0x2092080", VA = "0x182093680")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DebuggerNonUserCode]
		public CustomStepCraftItem CraftItem
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x2980E30", Offset = "0x297F830", VA = "0x182980E30")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.CraftItem)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x20936C0", Offset = "0x20920C0", VA = "0x1820936C0")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		[DebuggerNonUserCode]
		public CustomStepPetCompanion PetCompanion
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x29812C0", Offset = "0x297FCC0", VA = "0x1829812C0")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.PetCompanion)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2093700", Offset = "0x2092100", VA = "0x182093700")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		[DebuggerNonUserCode]
		public CustomStepTakePicture TakePicture
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2981620", Offset = "0x2980020", VA = "0x182981620")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.TakePicture)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x1E38140", Offset = "0x1E36B40", VA = "0x181E38140")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		[DebuggerNonUserCode]
		public CustomStepHangoutWithCharacter HangoutWithCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x29810E0", Offset = "0x297FAE0", VA = "0x1829810E0")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.HangoutWithCharacter)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x2093740", Offset = "0x2092140", VA = "0x182093740")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[DebuggerNonUserCode]
		public CustomStepDigTile DigTile
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x2980F60", Offset = "0x297F960", VA = "0x182980F60")]
			get
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.DigTile)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x29817D0", Offset = "0x29801D0", VA = "0x1829817D0")]
			set
			{
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[DebuggerNonUserCode]
		public ObjectiveOneofCase ObjectiveCase
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return objectiveCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x2981140", Offset = "0x297FB40", VA = "0x182981140", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_0018
				if ((object)typeof(IItemSelector).TypeHandle != null)
				{
					int num = 0;
					num += num;
					num++;
					return (ItemSelector)typeof(IItemSelector).TypeHandle;
				}
				return (ItemSelector)typeof(IItemSelector).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x2981560", Offset = "0x297FF60", VA = "0x182981560", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0018
				if ((object)typeof(IStepAmount).TypeHandle != null)
				{
					int num = 0;
					num += num;
					num++;
					return (StepAmount)typeof(IStepAmount).TypeHandle;
				}
				return (StepAmount)typeof(IStepAmount).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ObjectiveData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2980790", Offset = "0x297F190", VA = "0x182980790")]
		[DebuggerNonUserCode]
		public ObjectiveData(ObjectiveData other)
		{
			//IL_019d: Expected I4, but got O
			ObjectiveOneofCase objectiveOneofCase = other.objectiveCase_;
			CustomStepCatchFish customStepCatchFish = (CustomStepCatchFish)(objective_ = other.CatchFish.Clone());
			CustomStepCollectCurrency customStepCollectCurrency = (CustomStepCollectCurrency)(objective_ = other.CollectCurrency.Clone());
			CustomStepCookMeal customStepCookMeal = (CustomStepCookMeal)(objective_ = other.CookMeal.Clone());
			CustomStepMineMineral customStepMineMineral = (CustomStepMineMineral)(objective_ = other.MineMineral.Clone());
			CustomStepGardeningHarvest customStepGardeningHarvest = (CustomStepGardeningHarvest)(objective_ = other.GardeningHarvest.Clone());
			CustomStepGardeningPlant customStepGardeningPlant = (CustomStepGardeningPlant)(objective_ = other.GardeningPlant.Clone());
			CustomStepPickUp customStepPickUp = (CustomStepPickUp)(objective_ = other.PickUp.Clone());
			CustomStepSellItem customStepSellItem = (CustomStepSellItem)(objective_ = other.SellItem.Clone());
			if (objectiveOneofCase == ObjectiveOneofCase.RoyalDuties)
			{
				ObjectiveOneofCase objectiveOneofCase2 = other.objectiveCase_;
				if (other.objective_ == null)
				{
					throw new InvalidCastException();
				}
				CustomStepRoyalDuties customStepRoyalDuties = default(CustomStepRoyalDuties);
				objective_ = customStepRoyalDuties;
			}
			if (objectiveOneofCase <= (ObjectiveOneofCase)14)
			{
				CustomStepStartDiscussion customStepStartDiscussion = (CustomStepStartDiscussion)(objective_ = other.StartDiscussion.Clone());
				CustomStepGiftToCharacterItem customStepGiftToCharacterItem = (CustomStepGiftToCharacterItem)(objective_ = other.GiftToCharacter.Clone());
				CustomStepServeRestaurantOrder customStepServeRestaurantOrder = (CustomStepServeRestaurantOrder)(objective_ = other.ServeRestaurantOrder.Clone());
				CustomStepPurchaseItem customStepPurchaseItem = (CustomStepPurchaseItem)(objective_ = other.PurchaseItem.Clone());
				CustomStepCraftItem customStepCraftItem = (CustomStepCraftItem)(objective_ = other.CraftItem.Clone());
				CustomStepPetCompanion customStepPetCompanion = (CustomStepPetCompanion)(objective_ = other.PetCompanion.Clone());
				CustomStepTakePicture customStepTakePicture = (CustomStepTakePicture)(objective_ = other.TakePicture.Clone());
				CustomStepHangoutWithCharacter customStepHangoutWithCharacter = (CustomStepHangoutWithCharacter)(objective_ = other.HangoutWithCharacter.Clone());
				objectiveCase_ = (ObjectiveOneofCase)(objective_ = other.DigTile.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x297B2C0", Offset = "0x2979CC0", VA = "0x18297B2C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ObjectiveData Clone()
		{
			return new ObjectiveData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearObjective()
		{
			//IL_0010: Expected O, but got I4
			objective_ = (objectiveCase_ = ObjectiveOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x297C140", Offset = "0x297AB40", VA = "0x18297C140", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ObjectiveData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x297C1A0", Offset = "0x297ABA0", VA = "0x18297C1A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ObjectiveData other)
		{
			//IL_0055: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (objectiveCase_ == ObjectiveOneofCase.CatchFish)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
						goto IL_028b;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.objectiveCase_ == ObjectiveOneofCase.CatchFish)
				{
					obj2 = other.objective_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					CustomStepCollectCurrency collectCurrency = CollectCurrency;
					CustomStepCollectCurrency collectCurrency2 = other.CollectCurrency;
					if (object.Equals(collectCurrency, collectCurrency2))
					{
						CustomStepCookMeal cookMeal = CookMeal;
						CustomStepCookMeal cookMeal2 = other.CookMeal;
						if (object.Equals(cookMeal, cookMeal2))
						{
							CustomStepMineMineral mineMineral = MineMineral;
							CustomStepMineMineral mineMineral2 = other.MineMineral;
							if (object.Equals(mineMineral, mineMineral2))
							{
								CustomStepGardeningHarvest gardeningHarvest = GardeningHarvest;
								CustomStepGardeningHarvest gardeningHarvest2 = other.GardeningHarvest;
								if (object.Equals(gardeningHarvest, gardeningHarvest2))
								{
									CustomStepGardeningPlant gardeningPlant = GardeningPlant;
									CustomStepGardeningPlant gardeningPlant2 = other.GardeningPlant;
									if (object.Equals(gardeningPlant, gardeningPlant2))
									{
										CustomStepPickUp pickUp = PickUp;
										CustomStepPickUp pickUp2 = other.PickUp;
										if (object.Equals(pickUp, pickUp2))
										{
											CustomStepSellItem sellItem = SellItem;
											CustomStepSellItem sellItem2 = other.SellItem;
											if (object.Equals(sellItem, sellItem2))
											{
												CustomStepRoyalDuties royalDuties = RoyalDuties;
												CustomStepRoyalDuties royalDuties2 = other.RoyalDuties;
												if (object.Equals(royalDuties, royalDuties2))
												{
													CustomStepStartDiscussion startDiscussion = StartDiscussion;
													CustomStepStartDiscussion startDiscussion2 = other.StartDiscussion;
													if (object.Equals(startDiscussion, startDiscussion2))
													{
														CustomStepGiftToCharacterItem giftToCharacter = GiftToCharacter;
														CustomStepGiftToCharacterItem giftToCharacter2 = other.GiftToCharacter;
														if (object.Equals(giftToCharacter, giftToCharacter2))
														{
															CustomStepServeRestaurantOrder serveRestaurantOrder = ServeRestaurantOrder;
															CustomStepServeRestaurantOrder serveRestaurantOrder2 = other.ServeRestaurantOrder;
															if (object.Equals(serveRestaurantOrder, serveRestaurantOrder2))
															{
																CustomStepPurchaseItem purchaseItem = PurchaseItem;
																CustomStepPurchaseItem purchaseItem2 = other.PurchaseItem;
																if (object.Equals(purchaseItem, purchaseItem2))
																{
																	CustomStepCraftItem craftItem = CraftItem;
																	CustomStepCraftItem craftItem2 = other.CraftItem;
																	if (object.Equals(craftItem, craftItem2))
																	{
																		CustomStepPetCompanion petCompanion = PetCompanion;
																		CustomStepPetCompanion petCompanion2 = other.PetCompanion;
																		if (object.Equals(petCompanion, petCompanion2))
																		{
																			CustomStepTakePicture takePicture = TakePicture;
																			CustomStepTakePicture takePicture2 = other.TakePicture;
																			if (object.Equals(takePicture, takePicture2))
																			{
																				CustomStepHangoutWithCharacter hangoutWithCharacter = HangoutWithCharacter;
																				CustomStepHangoutWithCharacter hangoutWithCharacter2 = other.HangoutWithCharacter;
																				if (object.Equals(hangoutWithCharacter, hangoutWithCharacter2))
																				{
																					CustomStepDigTile digTile = DigTile;
																					CustomStepDigTile digTile2 = other.DigTile;
																					if (object.Equals(digTile, digTile2))
																					{
																						ObjectiveOneofCase objectiveOneofCase = other.objectiveCase_;
																						if (objectiveCase_ == objectiveOneofCase)
																						{
																							UnknownFieldSet unknownFields = other._unknownFields;
																							bool flag = object.Equals(_unknownFields, unknownFields);
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
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_028b;
			IL_028b:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x297C810", Offset = "0x297B210", VA = "0x18297C810", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_02b0
			while (true)
			{
				ObjectiveOneofCase objectiveOneofCase = objectiveCase_;
				int num = 0;
				if (objectiveOneofCase == ObjectiveOneofCase.CatchFish)
				{
					object obj = objective_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (objectiveOneofCase != ObjectiveOneofCase.CollectCurrency)
				{
					continue;
				}
				object obj2 = objective_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (objectiveCase_ != ObjectiveOneofCase.CookMeal)
					{
						continue;
					}
					object obj3 = objective_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (objectiveCase_ != ObjectiveOneofCase.MineMineral)
						{
							continue;
						}
						object obj4 = objective_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (objectiveCase_ != ObjectiveOneofCase.GardeningHarvest)
							{
								continue;
							}
							object obj5 = objective_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (objectiveCase_ != ObjectiveOneofCase.GardeningPlant)
								{
									continue;
								}
								object obj6 = objective_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (objectiveCase_ != ObjectiveOneofCase.PickUp)
									{
										continue;
									}
									object obj7 = objective_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (objectiveCase_ != ObjectiveOneofCase.SellItem)
										{
											continue;
										}
										object obj8 = objective_;
										if (obj8 != null)
										{
											int hashCode8 = obj8.GetHashCode();
											if (objectiveCase_ != ObjectiveOneofCase.RoyalDuties)
											{
												continue;
											}
											object obj9 = objective_;
											if (obj9 != null)
											{
												int hashCode9 = obj9.GetHashCode();
												if (objectiveCase_ != ObjectiveOneofCase.StartDiscussion)
												{
													continue;
												}
												object obj10 = objective_;
												if (obj10 != null)
												{
													int hashCode10 = obj10.GetHashCode();
													if (objectiveCase_ != ObjectiveOneofCase.GiftToCharacter)
													{
														continue;
													}
													object obj11 = objective_;
													if (obj11 != null)
													{
														int hashCode11 = obj11.GetHashCode();
														if (objectiveCase_ != ObjectiveOneofCase.ServeRestaurantOrder)
														{
															continue;
														}
														object obj12 = objective_;
														if (obj12 != null)
														{
															int hashCode12 = obj12.GetHashCode();
															if (objectiveCase_ != ObjectiveOneofCase.PurchaseItem)
															{
																continue;
															}
															object obj13 = objective_;
															if (obj13 != null)
															{
																int hashCode13 = obj13.GetHashCode();
																if (objectiveCase_ != ObjectiveOneofCase.CraftItem)
																{
																	continue;
																}
																object obj14 = objective_;
																if (obj14 != null)
																{
																	int hashCode14 = obj14.GetHashCode();
																	if (objectiveCase_ != ObjectiveOneofCase.PetCompanion)
																	{
																		continue;
																	}
																	object obj15 = objective_;
																	if (obj15 != null)
																	{
																		int hashCode15 = obj15.GetHashCode();
																		if (objectiveCase_ != ObjectiveOneofCase.TakePicture)
																		{
																			continue;
																		}
																		object obj16 = objective_;
																		if (obj16 != null)
																		{
																			int hashCode16 = obj16.GetHashCode();
																			if (objectiveCase_ != ObjectiveOneofCase.HangoutWithCharacter)
																			{
																				continue;
																			}
																			object obj17 = objective_;
																			if (obj17 != null)
																			{
																				int hashCode17 = obj17.GetHashCode();
																				if (objectiveCase_ == ObjectiveOneofCase.DigTile)
																				{
																					object obj18 = objective_;
																					if (obj18 == null)
																					{
																						break;
																					}
																					int hashCode18 = obj18.GetHashCode();
																				}
																				UnknownFieldSet unknownFields = _unknownFields;
																				if (unknownFields != null)
																				{
																					int hashCode19 = unknownFields.GetHashCode();
																				}
																				return 1;
																			}
																		}
																		throw new InvalidCastException();
																	}
																	throw new InvalidCastException();
																}
																throw new InvalidCastException();
															}
															throw new InvalidCastException();
														}
														throw new InvalidCastException();
													}
													throw new InvalidCastException();
												}
												throw new InvalidCastException();
											}
											throw new InvalidCastException();
										}
										throw new InvalidCastException();
									}
									throw new InvalidCastException();
								}
								throw new InvalidCastException();
							}
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x297F1D0", Offset = "0x297DBD0", VA = "0x18297F1D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x297FDC0", Offset = "0x297E7C0", VA = "0x18297FDC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0322
			//IL_0031: Expected O, but got I4
			while (true)
			{
				ObjectiveOneofCase objectiveOneofCase = objectiveCase_;
				int num = 0;
				if (objectiveOneofCase == ObjectiveOneofCase.CatchFish)
				{
					if (objectiveCase_ == ObjectiveOneofCase.CatchFish)
					{
						object obj = objective_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (objectiveOneofCase != ObjectiveOneofCase.CollectCurrency)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.CollectCurrency)
				{
					object obj2 = objective_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.CookMeal)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.CookMeal)
				{
					object obj3 = objective_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.MineMineral)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.MineMineral)
				{
					object obj4 = objective_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.GardeningHarvest)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.GardeningHarvest)
				{
					object obj5 = objective_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.GardeningPlant)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.GardeningPlant)
				{
					object obj6 = objective_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.PickUp)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.PickUp)
				{
					object obj7 = objective_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.SellItem)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.SellItem)
				{
					object obj8 = objective_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.RoyalDuties)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.RoyalDuties)
				{
					object obj9 = objective_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.StartDiscussion)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.StartDiscussion)
				{
					object obj10 = objective_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.GiftToCharacter)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.GiftToCharacter)
				{
					object obj11 = objective_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.ServeRestaurantOrder)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.ServeRestaurantOrder)
				{
					object obj12 = objective_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.PurchaseItem)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.PurchaseItem)
				{
					object obj13 = objective_;
					if (obj13 != null && obj13 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.CraftItem)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.CraftItem)
				{
					object obj14 = objective_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.PetCompanion)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.PetCompanion)
				{
					object obj15 = objective_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.TakePicture)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.TakePicture)
				{
					object obj16 = objective_;
					if (obj16 != null && obj16 == null)
					{
						break;
					}
				}
				if (objectiveCase_ != ObjectiveOneofCase.HangoutWithCharacter)
				{
					continue;
				}
				if (objectiveCase_ == ObjectiveOneofCase.HangoutWithCharacter)
				{
					object obj17 = objective_;
					if (obj17 != null && obj17 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (objectiveCase_ == ObjectiveOneofCase.DigTile && objectiveCase_ == ObjectiveOneofCase.DigTile)
				{
					object obj18 = objective_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x297A800", Offset = "0x2979200", VA = "0x18297A800", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002e: Expected O, but got I4
			int num = 0;
			if (objectiveCase_ == ObjectiveOneofCase.CatchFish)
			{
				if (objectiveCase_ == ObjectiveOneofCase.CatchFish)
				{
					object obj = objective_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (objectiveCase_ == ObjectiveOneofCase.CollectCurrency)
			{
				if (objectiveCase_ != ObjectiveOneofCase.CollectCurrency)
				{
				}
				object obj2 = objective_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num3 = default(int);
				num += num3;
			}
			if (objectiveCase_ == ObjectiveOneofCase.CookMeal)
			{
				if (objectiveCase_ != ObjectiveOneofCase.CookMeal)
				{
				}
				object obj3 = objective_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num4 = default(int);
				num += num4;
			}
			if (objectiveCase_ == ObjectiveOneofCase.MineMineral)
			{
				if (objectiveCase_ != ObjectiveOneofCase.MineMineral)
				{
				}
				object obj4 = objective_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num5 = default(int);
				num += num5;
			}
			if (objectiveCase_ == ObjectiveOneofCase.GardeningHarvest)
			{
				if (objectiveCase_ != ObjectiveOneofCase.GardeningHarvest)
				{
				}
				object obj5 = objective_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num6 = default(int);
				num += num6;
			}
			if (objectiveCase_ == ObjectiveOneofCase.GardeningPlant)
			{
				if (objectiveCase_ != ObjectiveOneofCase.GardeningPlant)
				{
				}
				object obj6 = objective_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num7 = default(int);
				num += num7;
			}
			if (objectiveCase_ == ObjectiveOneofCase.PickUp)
			{
				if (objectiveCase_ != ObjectiveOneofCase.PickUp)
				{
				}
				object obj7 = objective_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num8 = default(int);
				num += num8;
			}
			if (objectiveCase_ == ObjectiveOneofCase.SellItem)
			{
				if (objectiveCase_ != ObjectiveOneofCase.SellItem)
				{
				}
				object obj8 = objective_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num9 = default(int);
				num += num9;
			}
			if (objectiveCase_ == ObjectiveOneofCase.RoyalDuties)
			{
				if (objectiveCase_ != ObjectiveOneofCase.RoyalDuties)
				{
				}
				object obj9 = objective_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num10 = default(int);
				num += num10;
			}
			if (objectiveCase_ == ObjectiveOneofCase.StartDiscussion)
			{
				if (objectiveCase_ != ObjectiveOneofCase.StartDiscussion)
				{
				}
				object obj10 = objective_;
				if (obj10 != null && obj10 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num11 = default(int);
				num += num11;
			}
			if (objectiveCase_ == ObjectiveOneofCase.GiftToCharacter)
			{
				if (objectiveCase_ != ObjectiveOneofCase.GiftToCharacter)
				{
				}
				object obj11 = objective_;
				if (obj11 != null && obj11 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num12 = default(int);
				num += num12;
			}
			if (objectiveCase_ == ObjectiveOneofCase.ServeRestaurantOrder)
			{
				if (objectiveCase_ != ObjectiveOneofCase.ServeRestaurantOrder)
				{
				}
				object obj12 = objective_;
				if (obj12 != null && obj12 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num13 = default(int);
				num += num13;
			}
			if (objectiveCase_ == ObjectiveOneofCase.PurchaseItem)
			{
				if (objectiveCase_ != ObjectiveOneofCase.PurchaseItem)
				{
				}
				object obj13 = objective_;
				if (obj13 != null && obj13 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num14 = default(int);
				num += num14;
			}
			if (objectiveCase_ == ObjectiveOneofCase.CraftItem)
			{
				if (objectiveCase_ != ObjectiveOneofCase.CraftItem)
				{
				}
				object obj14 = objective_;
				if (obj14 != null && obj14 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num15 = default(int);
				num += num15;
			}
			if (objectiveCase_ == ObjectiveOneofCase.PetCompanion)
			{
				if (objectiveCase_ != ObjectiveOneofCase.PetCompanion)
				{
				}
				object obj15 = objective_;
				if (obj15 != null && obj15 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num16 = default(int);
				num += num16;
			}
			if (objectiveCase_ == ObjectiveOneofCase.TakePicture)
			{
				if (objectiveCase_ != ObjectiveOneofCase.TakePicture)
				{
				}
				object obj16 = objective_;
				if (obj16 != null && obj16 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num17 = default(int);
				num += num17;
			}
			if (objectiveCase_ == ObjectiveOneofCase.HangoutWithCharacter)
			{
				if (objectiveCase_ != ObjectiveOneofCase.HangoutWithCharacter)
				{
				}
				object obj17 = objective_;
				if (obj17 != null && obj17 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num18 = default(int);
				num += num18;
			}
			if (objectiveCase_ == ObjectiveOneofCase.DigTile)
			{
				if (objectiveCase_ == ObjectiveOneofCase.DigTile)
				{
					object obj18 = objective_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num19 = default(int);
				num += num19;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num20 = unknownFields.CalculateSize();
				num += num20;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x297D140", Offset = "0x297BB40", VA = "0x18297D140", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ObjectiveData other)
		{
			//Discarded unreachable code: IL_0054, IL_005d, IL_0074, IL_008a, IL_00a1, IL_00b7, IL_00ce, IL_00e4, IL_00fb, IL_0111, IL_0128, IL_013e, IL_0155, IL_016b, IL_0182, IL_0197, IL_01a0, IL_01b7, IL_01cb, IL_01d3, IL_01e3, IL_01fa, IL_0210, IL_0227, IL_023d, IL_0254, IL_026a, IL_0281, IL_0297, IL_02ae, IL_02c4, IL_02db, IL_02f1, IL_0308, IL_031e, IL_0335, IL_034b, IL_0362
			//IL_0021: Expected I4, but got O
			//IL_0074: Expected I4, but got O
			//IL_00a1: Expected I4, but got O
			//IL_00ce: Expected I4, but got O
			//IL_00fb: Expected I4, but got O
			//IL_0128: Expected I4, but got O
			//IL_0155: Expected I4, but got O
			//IL_0182: Expected I4, but got O
			//IL_01b7: Expected I4, but got O
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected O, but got Unknown
			//IL_01fa: Expected I4, but got O
			//IL_0227: Expected I4, but got O
			//IL_0254: Expected I4, but got O
			//IL_0281: Expected I4, but got O
			//IL_02ae: Expected I4, but got O
			//IL_02db: Expected I4, but got O
			//IL_0308: Expected I4, but got O
			//IL_0335: Expected I4, but got O
			//IL_0362: Expected I4, but got O
			if (other != null)
			{
				if (CatchFish == null)
				{
					objectiveCase_ = (ObjectiveOneofCase)(objective_ = new CustomStepCatchFish());
				}
				CustomStepCatchFish catchFish = CatchFish;
				CustomStepCatchFish catchFish2 = other.CatchFish;
				catchFish.MergeFrom(catchFish2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x297DB70", Offset = "0x297C570", VA = "0x18297DB70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_007d: Expected I4, but got O
			//IL_00ce: Expected I4, but got O
			//IL_012a: Expected I4, but got O
			//IL_017e: Expected I4, but got O
			//IL_01da: Expected I4, but got O
			//IL_023a: Expected I4, but got O
			//IL_0296: Expected I4, but got O
			//IL_02ef: Expected I4, but got O
			//IL_034b: Expected I4, but got O
			//IL_03b7: Expected I4, but got O
			//IL_0410: Expected I4, but got O
			//IL_046c: Expected I4, but got O
			//IL_04c5: Expected I4, but got O
			//IL_0521: Expected I4, but got O
			//IL_058b: Expected I4, but got O
			//IL_05e7: Expected I4, but got O
			//IL_0640: Expected I4, but got O
			//IL_0699: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 330)
			{
				if ((int)num > 458)
				{
					if ((int)num > 474)
					{
						if (num == 482)
						{
							CustomStepTakePicture customStepTakePicture = new CustomStepTakePicture();
							if (objectiveCase_ == ObjectiveOneofCase.TakePicture)
							{
								if (objectiveCase_ != ObjectiveOneofCase.TakePicture)
								{
								}
								object obj = objective_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(customStepTakePicture);
							objective_ = customStepTakePicture;
							objectiveCase_ = (ObjectiveOneofCase)customStepTakePicture;
						}
						if (num == 490)
						{
							CustomStepHangoutWithCharacter builder = new CustomStepHangoutWithCharacter();
							if (objectiveCase_ == ObjectiveOneofCase.HangoutWithCharacter)
							{
								if (objectiveCase_ != ObjectiveOneofCase.HangoutWithCharacter)
								{
								}
								object obj2 = objective_;
								if (obj2 != null && obj2 == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(builder);
							objective_ = builder;
							objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepHangoutWithCharacter).TypeHandle;
						}
						if ((long)typeof(CustomStepHangoutWithCharacter).TypeHandle != 498)
						{
							goto IL_0699;
						}
						CustomStepDigTile builder2 = new CustomStepDigTile();
						if (objectiveCase_ == ObjectiveOneofCase.DigTile)
						{
							if (objectiveCase_ != ObjectiveOneofCase.DigTile)
							{
							}
							object obj3 = objective_;
							if (obj3 != null && obj3 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder2);
						objective_ = builder2;
						objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepDigTile).TypeHandle;
					}
					if (num == 466)
					{
						CustomStepCraftItem builder3 = new CustomStepCraftItem();
						if (objectiveCase_ == ObjectiveOneofCase.CraftItem)
						{
							if (objectiveCase_ != ObjectiveOneofCase.CraftItem)
							{
							}
							object obj4 = objective_;
							if (obj4 != null && obj4 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder3);
						objective_ = builder3;
						objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepCraftItem).TypeHandle;
					}
					if ((long)typeof(CustomStepCraftItem).TypeHandle != 474)
					{
						goto IL_0699;
					}
					CustomStepPetCompanion builder4 = new CustomStepPetCompanion();
					if (objectiveCase_ == ObjectiveOneofCase.PetCompanion)
					{
						if (objectiveCase_ != ObjectiveOneofCase.PetCompanion)
						{
						}
						object obj5 = objective_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder4);
					objective_ = builder4;
					objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepPetCompanion).TypeHandle;
				}
				if ((int)num > 394)
				{
					if (num == 450)
					{
						CustomStepServeRestaurantOrder builder5 = new CustomStepServeRestaurantOrder();
						if (objectiveCase_ == ObjectiveOneofCase.ServeRestaurantOrder)
						{
							if (objectiveCase_ != ObjectiveOneofCase.ServeRestaurantOrder)
							{
							}
							object obj6 = objective_;
							if (obj6 != null && obj6 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder5);
						objective_ = builder5;
						objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepServeRestaurantOrder).TypeHandle;
					}
					if ((long)typeof(CustomStepServeRestaurantOrder).TypeHandle != 458)
					{
						goto IL_0699;
					}
					CustomStepPurchaseItem builder6 = new CustomStepPurchaseItem();
					if (objectiveCase_ == ObjectiveOneofCase.PurchaseItem)
					{
						if (objectiveCase_ != ObjectiveOneofCase.PurchaseItem)
						{
						}
						object obj7 = objective_;
						if (obj7 != null && obj7 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder6);
					objective_ = builder6;
					objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepPurchaseItem).TypeHandle;
				}
				if ((long)typeof(CustomStepPurchaseItem).TypeHandle == 386)
				{
					CustomStepStartDiscussion builder7 = new CustomStepStartDiscussion();
					if (objectiveCase_ == ObjectiveOneofCase.StartDiscussion)
					{
						if (objectiveCase_ != ObjectiveOneofCase.StartDiscussion)
						{
						}
						object obj8 = objective_;
						if (obj8 != null && obj8 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder7);
					objective_ = builder7;
					objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepStartDiscussion).TypeHandle;
				}
				if ((long)typeof(CustomStepStartDiscussion).TypeHandle != 394)
				{
					goto IL_0699;
				}
				CustomStepGiftToCharacterItem builder8 = new CustomStepGiftToCharacterItem();
				if (objectiveCase_ == ObjectiveOneofCase.GiftToCharacter)
				{
					if (objectiveCase_ != ObjectiveOneofCase.GiftToCharacter)
					{
					}
					object obj9 = objective_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder8);
				objective_ = builder8;
				objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepGiftToCharacterItem).TypeHandle;
			}
			if ((int)num > 194)
			{
				if ((int)num > 234)
				{
					if (num == 250)
					{
						CustomStepPickUp builder9 = new CustomStepPickUp();
						if (objectiveCase_ == ObjectiveOneofCase.PickUp)
						{
							if (objectiveCase_ != ObjectiveOneofCase.PickUp)
							{
							}
							object obj10 = objective_;
							if (obj10 != null && obj10 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder9);
						objective_ = builder9;
						objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepPickUp).TypeHandle;
					}
					if ((long)typeof(CustomStepPickUp).TypeHandle == 266)
					{
						CustomStepSellItem builder10 = new CustomStepSellItem();
						if (objectiveCase_ == ObjectiveOneofCase.SellItem)
						{
							if (objectiveCase_ != ObjectiveOneofCase.SellItem)
							{
							}
							object obj11 = objective_;
							if (obj11 != null && obj11 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder10);
						objective_ = builder10;
						objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepSellItem).TypeHandle;
					}
					if ((long)typeof(CustomStepSellItem).TypeHandle != 330)
					{
						goto IL_0699;
					}
					CustomStepRoyalDuties builder11 = new CustomStepRoyalDuties();
					if (objectiveCase_ == ObjectiveOneofCase.RoyalDuties)
					{
						if (objectiveCase_ != ObjectiveOneofCase.RoyalDuties)
						{
						}
						object obj12 = objective_;
						if (obj12 != null && obj12 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder11);
					objective_ = builder11;
					objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepRoyalDuties).TypeHandle;
				}
				if ((long)typeof(CustomStepRoyalDuties).TypeHandle == 226)
				{
					CustomStepGardeningHarvest builder12 = new CustomStepGardeningHarvest();
					if (objectiveCase_ == ObjectiveOneofCase.GardeningHarvest)
					{
						if (objectiveCase_ != ObjectiveOneofCase.GardeningHarvest)
						{
						}
						object obj13 = objective_;
						if (obj13 != null && obj13 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder12);
					objective_ = builder12;
					objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepGardeningHarvest).TypeHandle;
				}
				if ((long)typeof(CustomStepGardeningHarvest).TypeHandle != 234)
				{
					goto IL_0699;
				}
				CustomStepGardeningPlant builder13 = new CustomStepGardeningPlant();
				if (objectiveCase_ == ObjectiveOneofCase.GardeningPlant)
				{
					if (objectiveCase_ != ObjectiveOneofCase.GardeningPlant)
					{
					}
					object obj14 = objective_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder13);
				objective_ = builder13;
				objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepGardeningPlant).TypeHandle;
			}
			if ((long)typeof(CustomStepGardeningPlant).TypeHandle > 178)
			{
				if ((long)typeof(CustomStepGardeningPlant).TypeHandle == 186)
				{
					CustomStepCookMeal builder14 = new CustomStepCookMeal();
					if (objectiveCase_ == ObjectiveOneofCase.CookMeal)
					{
						if (objectiveCase_ != ObjectiveOneofCase.CookMeal)
						{
						}
						object obj15 = objective_;
						if (obj15 != null && obj15 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder14);
					objective_ = builder14;
					objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepCookMeal).TypeHandle;
				}
				if ((long)typeof(CustomStepCookMeal).TypeHandle != 194)
				{
					goto IL_0699;
				}
				CustomStepMineMineral builder15 = new CustomStepMineMineral();
				if (objectiveCase_ == ObjectiveOneofCase.MineMineral)
				{
					if (objectiveCase_ != ObjectiveOneofCase.MineMineral)
					{
					}
					object obj16 = objective_;
					if (obj16 != null && obj16 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder15);
				objective_ = builder15;
				objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepMineMineral).TypeHandle;
			}
			if ((long)typeof(CustomStepMineMineral).TypeHandle == 170)
			{
				CustomStepCatchFish builder16 = new CustomStepCatchFish();
				if (objectiveCase_ == ObjectiveOneofCase.CatchFish)
				{
					if (objectiveCase_ != ObjectiveOneofCase.CatchFish)
					{
					}
					object obj17 = objective_;
					if (obj17 != null && obj17 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder16);
				objective_ = builder16;
				objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepCatchFish).TypeHandle;
			}
			if ((long)typeof(CustomStepCatchFish).TypeHandle == 178)
			{
				CustomStepCollectCurrency builder17 = new CustomStepCollectCurrency();
				if (objectiveCase_ == ObjectiveOneofCase.CollectCurrency)
				{
					if (objectiveCase_ != ObjectiveOneofCase.CollectCurrency)
					{
					}
					object obj18 = objective_;
					if (obj18 != null && obj18 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder17);
				objective_ = builder17;
				objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepCollectCurrency).TypeHandle;
			}
			goto IL_0699;
			IL_0699:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x297C5A0", Offset = "0x297AFA0", VA = "0x18297C5A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			CustomStepCatchFish catchFish = CatchFish;
			CustomStepCollectCurrency collectCurrency = CollectCurrency;
			CustomStepCookMeal cookMeal = CookMeal;
			CustomStepMineMineral mineMineral = MineMineral;
			CustomStepGardeningHarvest gardeningHarvest = GardeningHarvest;
			CustomStepGardeningPlant gardeningPlant = GardeningPlant;
			CustomStepPickUp pickUp = PickUp;
			CustomStepSellItem sellItem = SellItem;
			if (fieldNumber == 41)
			{
				while (objectiveCase_ != ObjectiveOneofCase.RoyalDuties)
				{
				}
				object obj = objective_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_00c1;
				}
			}
			if ((long)typeof(CustomStepRoyalDuties).TypeHandle <= 14)
			{
				CustomStepStartDiscussion startDiscussion = StartDiscussion;
				CustomStepGiftToCharacterItem giftToCharacter = GiftToCharacter;
				CustomStepServeRestaurantOrder serveRestaurantOrder = ServeRestaurantOrder;
				CustomStepPurchaseItem purchaseItem = PurchaseItem;
				CustomStepCraftItem craftItem = CraftItem;
				CustomStepPetCompanion petCompanion = PetCompanion;
				CustomStepTakePicture takePicture = TakePicture;
				CustomStepHangoutWithCharacter hangoutWithCharacter = HangoutWithCharacter;
				CustomStepDigTile digTile = DigTile;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_00c1;
			IL_00c1:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x297EA60", Offset = "0x297D460", VA = "0x18297EA60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e, IL_0032, IL_0039, IL_0041, IL_0045, IL_004c, IL_0054, IL_0058, IL_005f, IL_0067, IL_006b, IL_0072, IL_007a, IL_007e, IL_0085, IL_008d, IL_0091, IL_0098, IL_00a0, IL_00a4, IL_00ab, IL_00e9, IL_00ed, IL_00f4, IL_00fc, IL_0100, IL_0107, IL_010f, IL_0113, IL_011a, IL_0122, IL_0126, IL_012d, IL_0135, IL_0139, IL_0140, IL_0148, IL_014c, IL_0153, IL_015b, IL_015f, IL_0166, IL_016e, IL_0172, IL_0176, IL_017e, IL_018a, IL_0190, IL_0196, IL_019c, IL_01a2, IL_01a8, IL_01ae, IL_01c0, IL_01c6, IL_01cc, IL_01d2, IL_01d8, IL_01de, IL_01e4
			//IL_0022: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_00d5: Expected I4, but got O
			if ((long)typeof(CustomStepTakePicture).TypeHandle <= 12)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				objective_ = num;
				objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepTakePicture).TypeHandle;
			}
			else if (fieldNumber == 41)
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				objective_ = value;
				objectiveCase_ = (ObjectiveOneofCase)typeof(CustomStepTakePicture).TypeHandle;
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				objective_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x297B170", Offset = "0x2979B70", VA = "0x18297B170", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_001d
			//IL_0015: Expected O, but got I4
			while (fieldNumber == 41)
			{
			}
			if (fieldNumber <= 14)
			{
				int num = 0;
				int num2 = 0;
				objective_ = num;
				objectiveCase_ = (ObjectiveOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x297D090", Offset = "0x297BA90", VA = "0x18297D090", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Objective"))
			{
				ObjectiveOneofCase objectiveOneofCase = objectiveCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x297B250", Offset = "0x2979C50", VA = "0x18297B250", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Objective"))
			{
				objective_ = (objectiveCase_ = ObjectiveOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x297D040", Offset = "0x297BA40", VA = "0x18297D040", Slot = "18")]
		public (ItemType, ActivityItemType?) GetItemGeneratorParameters()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x297C0E0", Offset = "0x297AAE0", VA = "0x18297C0E0", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0015
			if (objectiveCase_ == ObjectiveOneofCase.None)
			{
				context.AddError("Please select an Objective type (None is invalid)");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x297B320", Offset = "0x2979D20", VA = "0x18297B320")]
		public void DataValidation(string featureName, string varName, DataValidation.Context context)
		{
			ObjectiveOneofCase objectiveOneofCase = objectiveCase_;
			if (objectiveOneofCase > ObjectiveOneofCase.SellItem)
			{
				if (objectiveOneofCase == ObjectiveOneofCase.RoyalDuties)
				{
					ObjectiveOneofCase objectiveOneofCase2 = objectiveCase_;
					object obj = objective_;
					int num = 0;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if ((long)"CollectCurrency" > 14)
				{
					goto IL_01ae;
				}
				StepAmount targetAmount_ = StartDiscussion.targetAmount_;
				int num2 = 0;
				CustomStepGiftToCharacterItem customStepGiftToCharacterItem = default(CustomStepGiftToCharacterItem);
				StepAmount targetAmount_2 = customStepGiftToCharacterItem.targetAmount_;
				int num3 = 0;
				CustomStepServeRestaurantOrder customStepServeRestaurantOrder = default(CustomStepServeRestaurantOrder);
				StepAmount amount_ = customStepServeRestaurantOrder.amount_;
				int num4 = 0;
				CustomStepPurchaseItem customStepPurchaseItem = default(CustomStepPurchaseItem);
				StepAmount itemToPurchaseAmount_ = customStepPurchaseItem.itemToPurchaseAmount_;
				int num5 = 0;
				CustomStepCraftItem customStepCraftItem = default(CustomStepCraftItem);
				StepAmount amountToCraft_ = customStepCraftItem.amountToCraft_;
				int num6 = 0;
				CustomStepPetCompanion customStepPetCompanion = default(CustomStepPetCompanion);
				StepAmount targetAmount_3 = customStepPetCompanion.targetAmount_;
				int num7 = 0;
				int num8 = 0;
				CustomStepTakePicture customStepTakePicture = default(CustomStepTakePicture);
				if (customStepTakePicture.itemCase_ == CustomStepTakePicture.ItemOneofCase.TargetItem)
				{
				}
				CustomStepTakePicture customStepTakePicture2 = default(CustomStepTakePicture);
				if (!customStepTakePicture2.IsReallyUsingDifferentItem())
				{
					return;
				}
				CustomStepTakePicture customStepTakePicture3 = default(CustomStepTakePicture);
				if (customStepTakePicture3.itemCase_ != CustomStepTakePicture.ItemOneofCase.TargetDifferent)
				{
				}
				int num9 = 0;
				string text = " Objective: " + " Objective: " + "TargetDifferent is not supported";
				CustomStepHangoutWithCharacter customStepHangoutWithCharacter = default(CustomStepHangoutWithCharacter);
				ItemSelector targetCharacter_ = customStepHangoutWithCharacter.targetCharacter_;
				int num10 = 0;
				ValidateItemSelector("HangoutWithCharacter", "TargetCharacter", targetCharacter_);
				int num11 = 0;
			}
			if (objectiveOneofCase == ObjectiveOneofCase.None)
			{
				return;
			}
			int num20 = default(int);
			if ((long)"CollectCurrency" <= 12)
			{
				if (CatchFish.conditionType_.typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
				{
					CatchFishConditionWeight totalWeight = CatchFish.conditionType_.TotalWeight;
					int num12 = 0;
					return;
				}
				CustomStepCatchFish customStepCatchFish = default(CustomStepCatchFish);
				CatchFishConditionAmount amount = customStepCatchFish.conditionType_.Amount;
				int num13 = 0;
				CustomStepCollectCurrency customStepCollectCurrency = default(CustomStepCollectCurrency);
				StepAmount targetAmount_4 = customStepCollectCurrency.targetAmount_;
				int num14 = 0;
				CustomStepCookMeal customStepCookMeal = default(CustomStepCookMeal);
				StepAmount amountToCook_ = customStepCookMeal.amountToCook_;
				int num15 = 0;
				CustomStepMineMineral customStepMineMineral = default(CustomStepMineMineral);
				StepAmount targetAmount_5 = customStepMineMineral.targetAmount_;
				int num16 = 0;
				CustomStepGardeningHarvest customStepGardeningHarvest = default(CustomStepGardeningHarvest);
				StepAmount amount_2 = customStepGardeningHarvest.amount_;
				int num17 = 0;
				CustomStepGardeningPlant customStepGardeningPlant = default(CustomStepGardeningPlant);
				StepAmount amount_3 = customStepGardeningPlant.amount_;
				int num18 = 0;
				CustomStepPickUp customStepPickUp = default(CustomStepPickUp);
				CustomStepPickUp.PickUpTypesOneofCase pickUpTypesCase_ = customStepPickUp.pickUpTypesCase_;
				if (customStepPickUp != null && customStepPickUp != null && customStepPickUp != null && pickUpTypesCase_ == CustomStepPickUp.PickUpTypesOneofCase.FlowerItem)
				{
					string text2 = " Objective: " + " Objective: " + "PickUp of type QuestItem must not be used";
				}
				CustomStepPickUp customStepPickUp2 = default(CustomStepPickUp);
				StepAmount amountToCollect_ = customStepPickUp2.amountToCollect_;
				int num19 = 0;
				num20 = 0;
			}
			goto IL_01ae;
			IL_01ae:
			CustomStepSellItem arg = default(CustomStepSellItem);
			string text3 = $"Type {arg} has no data validation code";
			string text4 = " Objective: " + " Objective: " + text3;
			while (num20 != 0)
			{
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x297F230", Offset = "0x297DC30", VA = "0x18297F230")]
			void AddError(string error)
			{
				//Discarded unreachable code: IL_0013
				string text5 = cpp2il__autoParamName__idx_1.varName + " Objective: " + error;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x297F2B0", Offset = "0x297DCB0", VA = "0x18297F2B0")]
			void ValidateItemSelector(string typeName, string variableName, ItemSelector itemSelector)
			{
				//IL_005e: Expected O, but got I4
				//IL_0155: Expected O, but got I4
				//Could not transform parameter 3: unsupported argument pattern
				object[] array2;
				string featureName3;
				while (true)
				{
					ItemSelector.ItemSelectorOneofCase itemSelectorCase_ = itemSelector.itemSelectorCase_;
					if (itemSelector != null)
					{
						if (itemSelector != null && (itemSelector == null || itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Item))
						{
							return;
						}
						object[] array = new object[4];
						if (typeName == null || array != null)
						{
							array[0] = typeName;
							if (variableName == null || array != null)
							{
								array[1] = variableName;
								ItemSelector.ItemSelectorOneofCase itemSelectorCase_2 = itemSelector.itemSelectorCase_;
								if (itemSelectorCase_2 == ItemSelector.ItemSelectorOneofCase.None || itemSelectorCase_2 != 0)
								{
									array[2] = itemSelectorCase_2;
									string featureName2 = cpp2il__autoParamName__idx_3.featureName;
									if (featureName2 == null || itemSelectorCase_2 != 0)
									{
										array[3] = featureName2;
										AddError(string.Format("{0} {1} of type {2} is not supported for {3}", array));
										return;
									}
								}
							}
						}
					}
					else
					{
						MissionItemGenerator itemList = itemSelector.ItemList;
						GeneratorItemList itemList2 = itemList.item_.ItemList;
						if (itemList2 == null || !Enumerable.Any<GeneratorWeightedItem>((IEnumerable<>)(object)itemList2.list_) || itemList.item_.ItemList.useAsFilter_)
						{
							GeneratorItemIngredientList itemList3 = itemList.itemIngredient_.ItemList;
							while (itemList3 == null)
							{
							}
							if (!Enumerable.Any<GeneratorWeightedItemIngredient>((IEnumerable<>)(object)itemList3.list_) || itemList.itemIngredient_.ItemList.useAsFilter_)
							{
								continue;
							}
						}
						array2 = new object[4];
						if (typeName == null || array2 != null)
						{
							array2[0] = typeName;
							if (variableName == null || array2 != null)
							{
								array2[1] = variableName;
								ItemSelector.ItemSelectorOneofCase itemSelectorCase_3 = itemSelector.itemSelectorCase_;
								if (itemSelectorCase_3 == ItemSelector.ItemSelectorOneofCase.None || itemSelectorCase_3 != 0)
								{
									array2[2] = itemSelectorCase_3;
									featureName3 = cpp2il__autoParamName__idx_3.featureName;
									if (featureName3 == null || itemSelectorCase_3 != 0)
									{
										break;
									}
								}
							}
						}
					}
				}
				array2[3] = featureName3;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2980680", Offset = "0x297F080", VA = "0x182980680")]
		static ObjectiveData()
		{
			Func<ObjectiveData> func = default(Func<ObjectiveData>);
			_parser = (MessageParser<ObjectiveData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
