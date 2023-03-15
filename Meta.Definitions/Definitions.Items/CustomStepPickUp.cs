using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004C3")]
	public sealed class CustomStepPickUp : IMessage<CustomStepPickUp>, IMessage, IEquatable<CustomStepPickUp>, IDeepCloneable<CustomStepPickUp>, IMessageFieldAccessor, IMessageOneofAccessor, IItemSelector, IStepAmount, IStringTag, ISpawnHelper, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004C4")]
		public enum PickUpTypesOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001986")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001987")]
			FlowerItem,
			[Cpp2IlInjected.Token(Token = "0x4001988")]
			EphemeralItem,
			[Cpp2IlInjected.Token(Token = "0x4001989")]
			IngredientItem,
			[Cpp2IlInjected.Token(Token = "0x400198A")]
			QuestItem
		}

		[Cpp2IlInjected.Token(Token = "0x4001966")]
		private static readonly MessageParser<CustomStepPickUp> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001967")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001968")]
		public const int FlowerItemFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001969")]
		public const int EphemeralItemFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400196A")]
		public const int IngredientItemFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400196B")]
		public const int QuestItemFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400196C")]
		public const int AmountToCollectFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400196D")]
		private StepAmount amountToCollect_;

		[Cpp2IlInjected.Token(Token = "0x400196E")]
		public const int AmountToSpawnFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400196F")]
		private StepAmount amountToSpawn_;

		[Cpp2IlInjected.Token(Token = "0x4001970")]
		public const int UseDifferentItemFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001971")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x4001972")]
		public const int SpawnAllItemsFromSameSourceFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4001973")]
		private bool spawnAllItemsFromSameSource_;

		[Cpp2IlInjected.Token(Token = "0x4001974")]
		public const int UseDifferentSourceTypeFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4001975")]
		private bool useDifferentSourceType_;

		[Cpp2IlInjected.Token(Token = "0x4001976")]
		public const int SpawnLocationSourceFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001977")]
		private LocationSource spawnLocationSource_;

		[Cpp2IlInjected.Token(Token = "0x4001978")]
		public const int SpawnLocationSourceListFieldNumber = 24;

		[Cpp2IlInjected.Token(Token = "0x4001979")]
		private static readonly FieldCodec<LocationSource> _repeated_spawnLocationSourceList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400197A")]
		private readonly RepeatedField<LocationSource> spawnLocationSourceList_ = (RepeatedField<LocationSource>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400197B")]
		public const int SpawnRadiusFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400197C")]
		private StepAmount spawnRadius_;

		[Cpp2IlInjected.Token(Token = "0x400197D")]
		public const int PickupLocationFieldNumber = 26;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400197E")]
		private GridLocationFilter pickupLocation_;

		[Cpp2IlInjected.Token(Token = "0x400197F")]
		public const int WithFieldNumber = 27;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001980")]
		private HangoutWithCharacter with_;

		[Cpp2IlInjected.Token(Token = "0x4001981")]
		public const int RewardOverrideFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001982")]
		private ItemWithState rewardOverride_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001983")]
		private object pickUpTypes_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001984")]
		private PickUpTypesOneofCase pickUpTypesCase_;

		[Cpp2IlInjected.Token(Token = "0x17000EEF")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepPickUp> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003A8A")]
			[Cpp2IlInjected.Address(RVA = "0x31F5D40", Offset = "0x31F4740", VA = "0x1831F5D40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A8B")]
			[Cpp2IlInjected.Address(RVA = "0x31F5AA0", Offset = "0x31F44A0", VA = "0x1831F5AA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A8C")]
			[Cpp2IlInjected.Address(RVA = "0x31F6020", Offset = "0x31F4A20", VA = "0x1831F6020", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF2")]
		[DebuggerNonUserCode]
		public ItemSelector FlowerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A91")]
			[Cpp2IlInjected.Address(RVA = "0x31F5BD0", Offset = "0x31F45D0", VA = "0x1831F5BD0")]
			get
			{
				int num = 0;
				if (pickUpTypesCase_ == PickUpTypesOneofCase.FlowerItem)
				{
					object obj = pickUpTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A92")]
			[Cpp2IlInjected.Address(RVA = "0x31F6170", Offset = "0x31F4B70", VA = "0x1831F6170")]
			set
			{
				pickUpTypes_ = value;
				bool flag = (byte)(pickUpTypesCase_ = ((value != null) ? PickUpTypesOneofCase.FlowerItem : PickUpTypesOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF3")]
		[DebuggerNonUserCode]
		public ItemSelector EphemeralItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A93")]
			[Cpp2IlInjected.Address(RVA = "0x31F5B70", Offset = "0x31F4570", VA = "0x1831F5B70")]
			get
			{
				int num = 0;
				if (pickUpTypesCase_ == PickUpTypesOneofCase.EphemeralItem)
				{
					object obj = pickUpTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A94")]
			[Cpp2IlInjected.Address(RVA = "0x31F6130", Offset = "0x31F4B30", VA = "0x1831F6130")]
			set
			{
				pickUpTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF4")]
		[DebuggerNonUserCode]
		public ItemSelector IngredientItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A95")]
			[Cpp2IlInjected.Address(RVA = "0x31F5C30", Offset = "0x31F4630", VA = "0x1831F5C30")]
			get
			{
				int num = 0;
				if (pickUpTypesCase_ == PickUpTypesOneofCase.IngredientItem)
				{
					object obj = pickUpTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A96")]
			[Cpp2IlInjected.Address(RVA = "0x31F61B0", Offset = "0x31F4BB0", VA = "0x1831F61B0")]
			set
			{
				pickUpTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF5")]
		[DebuggerNonUserCode]
		public ItemSelector QuestItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A97")]
			[Cpp2IlInjected.Address(RVA = "0x31F5DA0", Offset = "0x31F47A0", VA = "0x1831F5DA0")]
			get
			{
				int num = 0;
				if (pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem)
				{
					object obj = pickUpTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A98")]
			[Cpp2IlInjected.Address(RVA = "0x31F61F0", Offset = "0x31F4BF0", VA = "0x1831F61F0")]
			set
			{
				pickUpTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF6")]
		[DebuggerNonUserCode]
		public StepAmount AmountToCollect
		{
			[Cpp2IlInjected.Token(Token = "0x6003A99")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return amountToCollect_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A9A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				amountToCollect_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF7")]
		[DebuggerNonUserCode]
		public StepAmount AmountToSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6003A9B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "19")]
			get
			{
				return amountToSpawn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A9C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				amountToSpawn_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF8")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A9D")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A9E")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF9")]
		[DebuggerNonUserCode]
		public bool SpawnAllItemsFromSameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6003A9F")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return spawnAllItemsFromSameSource_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AA0")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				spawnAllItemsFromSameSource_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFA")]
		[DebuggerNonUserCode]
		public bool UseDifferentSourceType
		{
			[Cpp2IlInjected.Token(Token = "0x6003AA1")]
			[Cpp2IlInjected.Address(RVA = "0xDC7980", Offset = "0xDC6380", VA = "0x180DC7980")]
			get
			{
				return useDifferentSourceType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AA2")]
			[Cpp2IlInjected.Address(RVA = "0xDC79A0", Offset = "0xDC63A0", VA = "0x180DC79A0")]
			set
			{
				useDifferentSourceType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFB")]
		[DebuggerNonUserCode]
		public LocationSource SpawnLocationSource
		{
			[Cpp2IlInjected.Token(Token = "0x6003AA3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return spawnLocationSource_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AA4")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				spawnLocationSource_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFC")]
		[DebuggerNonUserCode]
		public RepeatedField<LocationSource> SpawnLocationSourceList
		{
			[Cpp2IlInjected.Token(Token = "0x6003AA5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return spawnLocationSourceList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFD")]
		[DebuggerNonUserCode]
		public StepAmount SpawnRadius
		{
			[Cpp2IlInjected.Token(Token = "0x6003AA6")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return spawnRadius_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AA7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				spawnRadius_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFE")]
		[DebuggerNonUserCode]
		public GridLocationFilter PickupLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6003AA8")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return pickupLocation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AA9")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				pickupLocation_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EFF")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter With
		{
			[Cpp2IlInjected.Token(Token = "0x6003AAA")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return with_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AAB")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				with_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F00")]
		[DebuggerNonUserCode]
		public ItemWithState RewardOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6003AAC")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "24")]
			get
			{
				return rewardOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AAD")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				rewardOverride_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F01")]
		[DebuggerNonUserCode]
		public PickUpTypesOneofCase PickUpTypesCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003AAE")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return pickUpTypesCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F02")]
		bool ISpawnHelper.SpawnDryFlower
		{
			[Cpp2IlInjected.Token(Token = "0x6003ABD")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "25")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F03")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003ABE")]
			[Cpp2IlInjected.Address(RVA = "0x31F5C90", Offset = "0x31F4690", VA = "0x1831F5C90", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0012, IL_0019, IL_0020
				if (pickUpTypesCase_ != PickUpTypesOneofCase.FlowerItem)
				{
					int num = 0;
				}
				return QuestItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F04")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003ABF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "17")]
			get
			{
				return amountToCollect_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F05")]
		public bool UseMultiSources
		{
			[Cpp2IlInjected.Token(Token = "0x6003AC0")]
			[Cpp2IlInjected.Address(RVA = "0x31F6010", Offset = "0x31F4A10", VA = "0x1831F6010", Slot = "20")]
			get
			{
				return !spawnAllItemsFromSameSource_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F06")]
		public LocationSource LocationSource
		{
			[Cpp2IlInjected.Token(Token = "0x6003AC1")]
			[Cpp2IlInjected.Address(RVA = "0x31F5D20", Offset = "0x31F4720", VA = "0x1831F5D20", Slot = "21")]
			get
			{
				if (!spawnAllItemsFromSameSource_ && useDifferentSourceType_)
				{
					int num = 0;
				}
				return spawnLocationSource_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F07")]
		public List<LocationSource> LocationSourceList
		{
			[Cpp2IlInjected.Token(Token = "0x6003AC2")]
			[Cpp2IlInjected.Address(RVA = "0x31F5CD0", Offset = "0x31F46D0", VA = "0x1831F5CD0", Slot = "22")]
			get
			{
				if (!spawnAllItemsFromSameSource_ && useDifferentSourceType_)
				{
					return (List<LocationSource>)(object)Enumerable.ToList<LocationSource>((IEnumerable<>)(object)spawnLocationSourceList_);
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F08")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003AC3")]
			[Cpp2IlInjected.Address(RVA = "0x31F5E00", Offset = "0x31F4800", VA = "0x1831F5E00", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
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
					if ("CurrentAmount" == null || "CurrentAmount" != null)
					{
						array[2] = "CurrentAmount";
						if ("FlowerRarity" == null || "FlowerRarity" != null)
						{
							break;
						}
					}
				}
				array[3] = "FlowerRarity";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8D")]
		[Cpp2IlInjected.Address(RVA = "0x31F5A20", Offset = "0x31F4420", VA = "0x1831F5A20")]
		[DebuggerNonUserCode]
		public CustomStepPickUp()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8E")]
		[Cpp2IlInjected.Address(RVA = "0x31F4920", Offset = "0x31F3320", VA = "0x1831F4920")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (amountToCollect_ = new StepAmount());
			StepAmount stepAmount2 = (amountToSpawn_ = new StepAmount());
			LocationSource locationSource = (spawnLocationSource_ = new LocationSource());
			StepAmount stepAmount3 = (spawnRadius_ = new StepAmount());
			ItemWithState itemWithState = (rewardOverride_ = new ItemWithState());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.Anywhere = new Empty());
			pickupLocation_ = gridLocationFilter;
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8F")]
		[Cpp2IlInjected.Address(RVA = "0x31F56E0", Offset = "0x31F40E0", VA = "0x1831F56E0")]
		[DebuggerNonUserCode]
		public CustomStepPickUp(CustomStepPickUp other)
		{
			//IL_0034: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			//IL_00d0: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_010a: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			//IL_0160: Expected I4, but got O
			//IL_017d: Expected I4, but got O
			//IL_019a: Expected I4, but got O
			OnConstruction();
			StepAmount stepAmount = other.amountToCollect_;
			int num = 0;
			if (stepAmount != null)
			{
				StepAmount stepAmount2 = stepAmount.Clone();
			}
			amountToCollect_ = (StepAmount)num;
			StepAmount stepAmount3 = other.amountToSpawn_;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			amountToSpawn_ = (StepAmount)num;
			bool flag = (useDifferentItem_ = other.useDifferentItem_);
			bool flag2 = (spawnAllItemsFromSameSource_ = other.spawnAllItemsFromSameSource_);
			bool flag3 = (useDifferentSourceType_ = other.useDifferentSourceType_);
			LocationSource locationSource = other.spawnLocationSource_;
			if (locationSource != null)
			{
				LocationSource locationSource2 = locationSource.Clone();
			}
			spawnLocationSource_ = (LocationSource)num;
			RepeatedField<LocationSource> repeatedField = (spawnLocationSourceList_ = (RepeatedField<LocationSource>)(object)((RepeatedField<T>)(object)other.spawnLocationSourceList_).Clone());
			StepAmount stepAmount5 = other.spawnRadius_;
			if (stepAmount5 != null)
			{
				StepAmount stepAmount6 = stepAmount5.Clone();
			}
			spawnRadius_ = (StepAmount)num;
			GridLocationFilter gridLocationFilter = other.pickupLocation_;
			if (gridLocationFilter != null)
			{
				GridLocationFilter gridLocationFilter2 = gridLocationFilter.Clone();
			}
			pickupLocation_ = (GridLocationFilter)num;
			HangoutWithCharacter hangoutWithCharacter = other.with_;
			if (hangoutWithCharacter != null)
			{
				HangoutWithCharacter hangoutWithCharacter2 = hangoutWithCharacter.Clone();
			}
			with_ = (HangoutWithCharacter)num;
			ItemWithState itemWithState = other.rewardOverride_;
			if (itemWithState != null)
			{
				ItemWithState itemWithState2 = itemWithState.Clone();
			}
			rewardOverride_ = (ItemWithState)num;
			PickUpTypesOneofCase pickUpTypesOneofCase = other.pickUpTypesCase_;
			if (itemWithState != null)
			{
				if (itemWithState != null)
				{
					if (itemWithState != null)
					{
						if (pickUpTypesOneofCase != PickUpTypesOneofCase.FlowerItem)
						{
							goto IL_01c1;
						}
						pickUpTypesCase_ = (PickUpTypesOneofCase)(pickUpTypes_ = other.QuestItem.Clone());
					}
					pickUpTypesCase_ = (PickUpTypesOneofCase)(pickUpTypes_ = other.IngredientItem.Clone());
				}
				pickUpTypesCase_ = (PickUpTypesOneofCase)(pickUpTypes_ = other.EphemeralItem.Clone());
			}
			bool flag4 = (byte)(pickUpTypesCase_ = (((pickUpTypes_ = other.FlowerItem.Clone()) != null) ? PickUpTypesOneofCase.FlowerItem : PickUpTypesOneofCase.None)) != 0;
			goto IL_01c1;
			IL_01c1:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A90")]
		[Cpp2IlInjected.Address(RVA = "0x31F2E00", Offset = "0x31F1800", VA = "0x1831F2E00", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepPickUp Clone()
		{
			return new CustomStepPickUp(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AAF")]
		[Cpp2IlInjected.Address(RVA = "0x31F2DE0", Offset = "0x31F17E0", VA = "0x1831F2DE0")]
		[DebuggerNonUserCode]
		public void ClearPickUpTypes()
		{
			//IL_0010: Expected O, but got I4
			pickUpTypes_ = (pickUpTypesCase_ = PickUpTypesOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB0")]
		[Cpp2IlInjected.Address(RVA = "0x31F36F0", Offset = "0x31F20F0", VA = "0x1831F36F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CustomStepPickUp)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB1")]
		[Cpp2IlInjected.Address(RVA = "0x31F3450", Offset = "0x31F1E50", VA = "0x1831F3450", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepPickUp other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (pickUpTypesCase_ == PickUpTypesOneofCase.FlowerItem)
				{
					object obj = pickUpTypes_;
					if (obj != null && obj == null)
					{
						goto IL_01ef;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.pickUpTypesCase_ == PickUpTypesOneofCase.FlowerItem)
				{
					obj2 = other.pickUpTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ItemSelector ephemeralItem = EphemeralItem;
					ItemSelector ephemeralItem2 = other.EphemeralItem;
					if (object.Equals(ephemeralItem, ephemeralItem2))
					{
						ItemSelector ingredientItem = IngredientItem;
						ItemSelector ingredientItem2 = other.IngredientItem;
						if (object.Equals(ingredientItem, ingredientItem2))
						{
							ItemSelector questItem = QuestItem;
							ItemSelector questItem2 = other.QuestItem;
							if (object.Equals(questItem, questItem2))
							{
								StepAmount objB = other.amountToCollect_;
								if (object.Equals(amountToCollect_, objB))
								{
									StepAmount objB2 = other.amountToSpawn_;
									if (object.Equals(amountToSpawn_, objB2))
									{
										bool flag = other.useDifferentItem_;
										if (useDifferentItem_ == flag)
										{
											bool flag2 = other.spawnAllItemsFromSameSource_;
											if (spawnAllItemsFromSameSource_ == flag2)
											{
												bool flag3 = other.useDifferentSourceType_;
												if (useDifferentSourceType_ == flag3)
												{
													LocationSource objB3 = other.spawnLocationSource_;
													if (object.Equals(spawnLocationSource_, objB3))
													{
														RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
														RepeatedField<LocationSource> repeatedField2 = other.spawnLocationSourceList_;
														if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
														{
															StepAmount objB4 = other.spawnRadius_;
															if (object.Equals(spawnRadius_, objB4))
															{
																GridLocationFilter objB5 = other.pickupLocation_;
																if (object.Equals(pickupLocation_, objB5))
																{
																	HangoutWithCharacter objB6 = other.with_;
																	if (object.Equals(with_, objB6))
																	{
																		ItemWithState objB7 = other.rewardOverride_;
																		if (object.Equals(rewardOverride_, objB7))
																		{
																			PickUpTypesOneofCase pickUpTypesOneofCase = other.pickUpTypesCase_;
																			if (pickUpTypesCase_ == pickUpTypesOneofCase)
																			{
																				UnknownFieldSet unknownFields = other._unknownFields;
																				bool flag4 = object.Equals(_unknownFields, unknownFields);
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
			goto IL_01ef;
			IL_01ef:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB2")]
		[Cpp2IlInjected.Address(RVA = "0x31F3960", Offset = "0x31F2360", VA = "0x1831F3960", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_015e
			while (true)
			{
				PickUpTypesOneofCase pickUpTypesOneofCase = pickUpTypesCase_;
				int num = 0;
				if (pickUpTypesOneofCase == PickUpTypesOneofCase.FlowerItem)
				{
					object obj = pickUpTypes_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (pickUpTypesOneofCase != PickUpTypesOneofCase.EphemeralItem)
				{
					continue;
				}
				object obj2 = pickUpTypes_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (pickUpTypesCase_ != PickUpTypesOneofCase.IngredientItem)
					{
						continue;
					}
					object obj3 = pickUpTypes_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem)
						{
							object obj4 = pickUpTypes_;
							if (obj4 == null)
							{
								break;
							}
							int hashCode4 = obj4.GetHashCode();
						}
						StepAmount stepAmount = amountToCollect_;
						if (stepAmount != null)
						{
							int hashCode5 = stepAmount.GetHashCode();
						}
						StepAmount stepAmount2 = amountToSpawn_;
						if (stepAmount2 != null)
						{
							int hashCode6 = stepAmount2.GetHashCode();
						}
						if (useDifferentItem_)
						{
						}
						if (spawnAllItemsFromSameSource_)
						{
						}
						if (useDifferentSourceType_)
						{
						}
						LocationSource locationSource = spawnLocationSource_;
						if (locationSource != null)
						{
							int hashCode7 = locationSource.GetHashCode();
						}
						int hashCode8 = ((RepeatedField<T>)(object)spawnLocationSourceList_).GetHashCode();
						StepAmount stepAmount3 = spawnRadius_;
						if (stepAmount3 != null)
						{
							int hashCode9 = stepAmount3.GetHashCode();
						}
						GridLocationFilter gridLocationFilter = pickupLocation_;
						if (gridLocationFilter != null)
						{
							int hashCode10 = gridLocationFilter.GetHashCode();
						}
						HangoutWithCharacter hangoutWithCharacter = with_;
						if (hangoutWithCharacter != null)
						{
							int hashCode11 = hangoutWithCharacter.GetHashCode();
						}
						ItemWithState itemWithState = rewardOverride_;
						if (itemWithState != null)
						{
							int hashCode12 = itemWithState.GetHashCode();
						}
						UnknownFieldSet unknownFields = _unknownFields;
						if (unknownFields != null)
						{
							int hashCode13 = unknownFields.GetHashCode();
						}
						return 1;
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB3")]
		[Cpp2IlInjected.Address(RVA = "0x31F5050", Offset = "0x31F3A50", VA = "0x1831F5050", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB4")]
		[Cpp2IlInjected.Address(RVA = "0x31F50B0", Offset = "0x31F3AB0", VA = "0x1831F50B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01d3
			//IL_002f: Expected O, but got I4
			while (true)
			{
				PickUpTypesOneofCase pickUpTypesOneofCase = pickUpTypesCase_;
				int num = 0;
				if (pickUpTypesOneofCase == PickUpTypesOneofCase.FlowerItem)
				{
					if (pickUpTypesCase_ == PickUpTypesOneofCase.FlowerItem)
					{
						object obj = pickUpTypes_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (pickUpTypesOneofCase != PickUpTypesOneofCase.EphemeralItem)
				{
					continue;
				}
				if (pickUpTypesCase_ == PickUpTypesOneofCase.EphemeralItem)
				{
					object obj2 = pickUpTypes_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (pickUpTypesCase_ != PickUpTypesOneofCase.IngredientItem)
				{
					continue;
				}
				if (pickUpTypesCase_ == PickUpTypesOneofCase.IngredientItem)
				{
					object obj3 = pickUpTypes_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem && pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem)
				{
					object obj4 = pickUpTypes_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if ((long)amountToCollect_ != 0)
				{
					StepAmount value = amountToCollect_;
					output.WriteMessage(value);
				}
				if ((long)amountToSpawn_ != 0)
				{
					StepAmount value2 = amountToSpawn_;
					output.WriteMessage(value2);
				}
				if (useDifferentItem_)
				{
					bool value3 = useDifferentItem_;
					output.WriteBool(value3);
				}
				if (spawnAllItemsFromSameSource_)
				{
					bool value4 = spawnAllItemsFromSameSource_;
					output.WriteBool(value4);
				}
				if (useDifferentSourceType_)
				{
					bool value5 = useDifferentSourceType_;
					output.WriteBool(value5);
				}
				if ((long)spawnLocationSource_ != 0)
				{
					LocationSource value6 = spawnLocationSource_;
					output.WriteMessage(value6);
				}
				RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
				FieldCodec<LocationSource> repeated_spawnLocationSourceList_codec = _repeated_spawnLocationSourceList_codec;
				((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_spawnLocationSourceList_codec);
				if ((long)spawnRadius_ != 0)
				{
					StepAmount value7 = spawnRadius_;
					output.WriteMessage(value7);
				}
				if ((long)pickupLocation_ != 0)
				{
					GridLocationFilter value8 = pickupLocation_;
					output.WriteMessage(value8);
				}
				if ((long)with_ != 0)
				{
					HangoutWithCharacter value9 = with_;
					output.WriteMessage(value9);
				}
				if ((long)rewardOverride_ != 0)
				{
					ItemWithState value10 = rewardOverride_;
					output.WriteMessage(value10);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB5")]
		[Cpp2IlInjected.Address(RVA = "0x31F2790", Offset = "0x31F1190", VA = "0x1831F2790", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01dd
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (pickUpTypesCase_ == PickUpTypesOneofCase.FlowerItem)
			{
				if (pickUpTypesCase_ == PickUpTypesOneofCase.FlowerItem)
				{
					object obj = pickUpTypes_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (pickUpTypesCase_ == PickUpTypesOneofCase.EphemeralItem)
			{
				if (pickUpTypesCase_ != PickUpTypesOneofCase.EphemeralItem)
				{
				}
				object obj2 = pickUpTypes_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (pickUpTypesCase_ == PickUpTypesOneofCase.IngredientItem)
			{
				if (pickUpTypesCase_ != PickUpTypesOneofCase.IngredientItem)
				{
				}
				object obj3 = pickUpTypes_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem)
			{
				if (pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem)
				{
					object obj4 = pickUpTypes_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			StepAmount stepAmount = amountToCollect_;
			if (stepAmount != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num6++;
				num += num6;
			}
			StepAmount stepAmount2 = amountToSpawn_;
			if (stepAmount2 != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(stepAmount2);
				num7++;
				num += num7;
			}
			LocationSource locationSource = spawnLocationSource_;
			if (locationSource != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(locationSource);
				num8 += 2;
				num += num8;
			}
			RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
			FieldCodec<LocationSource> repeated_spawnLocationSourceList_codec = _repeated_spawnLocationSourceList_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_spawnLocationSourceList_codec);
			StepAmount stepAmount3 = spawnRadius_;
			num += num9;
			if (stepAmount3 != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(stepAmount3);
				num10 += 2;
				num += num10;
			}
			GridLocationFilter gridLocationFilter = pickupLocation_;
			if (gridLocationFilter != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(gridLocationFilter);
				num11 += 2;
				num += num11;
			}
			HangoutWithCharacter hangoutWithCharacter = with_;
			if (hangoutWithCharacter != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(hangoutWithCharacter);
				num12 += 2;
				num += num12;
			}
			ItemWithState itemWithState = rewardOverride_;
			if (itemWithState != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(itemWithState);
				num13 += 2;
				num += num13;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
				num += num14;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB6")]
		[Cpp2IlInjected.Address(RVA = "0x31F4430", Offset = "0x31F2E30", VA = "0x1831F4430", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepPickUp other)
		{
			//Discarded unreachable code: IL_0314
			//IL_0241: Expected I4, but got O
			//IL_0271: Expected I4, but got O
			//IL_02a1: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.amountToCollect_ != 0)
			{
				StepAmount stepAmount = amountToCollect_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amountToCollect_ = new StepAmount());
					StepAmount stepAmount3 = amountToCollect_;
				}
				StepAmount other2 = other.amountToCollect_;
				stepAmount.MergeFrom(other2);
			}
			if ((long)other.amountToSpawn_ != 0)
			{
				StepAmount stepAmount5 = default(StepAmount);
				if (amountToSpawn_ == null)
				{
					StepAmount stepAmount4 = (amountToSpawn_ = new StepAmount());
					stepAmount5 = amountToSpawn_;
				}
				StepAmount other3 = other.amountToSpawn_;
				stepAmount5.MergeFrom(other3);
			}
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			bool flag2 = other.spawnAllItemsFromSameSource_;
			if (flag2)
			{
				spawnAllItemsFromSameSource_ = flag2;
			}
			bool flag3 = other.useDifferentSourceType_;
			if (flag3)
			{
				useDifferentSourceType_ = flag3;
			}
			if ((long)other.spawnLocationSource_ != 0)
			{
				LocationSource locationSource2 = default(LocationSource);
				if (spawnLocationSource_ == null)
				{
					LocationSource locationSource = (spawnLocationSource_ = new LocationSource());
					locationSource2 = spawnLocationSource_;
				}
				LocationSource other4 = other.spawnLocationSource_;
				locationSource2.MergeFrom(other4);
			}
			RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
			RepeatedField<LocationSource> repeatedField2 = other.spawnLocationSourceList_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.spawnRadius_ != 0)
			{
				StepAmount stepAmount7 = default(StepAmount);
				if (spawnRadius_ == null)
				{
					StepAmount stepAmount6 = (spawnRadius_ = new StepAmount());
					stepAmount7 = spawnRadius_;
				}
				StepAmount other5 = other.spawnRadius_;
				stepAmount7.MergeFrom(other5);
			}
			if ((long)other.pickupLocation_ != 0)
			{
				GridLocationFilter gridLocationFilter2 = default(GridLocationFilter);
				if (pickupLocation_ == null)
				{
					GridLocationFilter gridLocationFilter = (pickupLocation_ = new GridLocationFilter());
					gridLocationFilter2 = pickupLocation_;
				}
				GridLocationFilter other6 = other.pickupLocation_;
				gridLocationFilter2.MergeFrom(other6);
			}
			if ((long)other.with_ != 0)
			{
				HangoutWithCharacter hangoutWithCharacter2 = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					hangoutWithCharacter2 = with_;
				}
				HangoutWithCharacter other7 = other.with_;
				hangoutWithCharacter2.MergeFrom(other7);
			}
			ItemWithState itemWithState2 = default(ItemWithState);
			if ((long)other.rewardOverride_ != 0)
			{
				if (rewardOverride_ == null)
				{
					ItemWithState itemWithState = (rewardOverride_ = new ItemWithState());
					itemWithState2 = rewardOverride_;
				}
				ItemWithState other8 = other.rewardOverride_;
				itemWithState2.MergeFrom(other8);
			}
			PickUpTypesOneofCase pickUpTypesOneofCase = other.pickUpTypesCase_;
			if (itemWithState2 != null)
			{
				if (itemWithState2 != null)
				{
					if (itemWithState2 != null)
					{
						if (pickUpTypesOneofCase != PickUpTypesOneofCase.FlowerItem)
						{
							goto IL_02f4;
						}
						if (QuestItem == null)
						{
							pickUpTypesCase_ = (PickUpTypesOneofCase)(pickUpTypes_ = new ItemSelector());
						}
						ItemSelector questItem = QuestItem;
						ItemSelector questItem2 = other.QuestItem;
					}
					if (IngredientItem == null)
					{
						pickUpTypesCase_ = (PickUpTypesOneofCase)(pickUpTypes_ = new ItemSelector());
					}
					ItemSelector ingredientItem = IngredientItem;
					ItemSelector ingredientItem2 = other.IngredientItem;
				}
				if (EphemeralItem == null)
				{
					pickUpTypesCase_ = (PickUpTypesOneofCase)(pickUpTypes_ = new ItemSelector());
				}
				ItemSelector ephemeralItem = EphemeralItem;
				ItemSelector ephemeralItem2 = other.EphemeralItem;
			}
			if (FlowerItem == null)
			{
				bool flag4 = (byte)(pickUpTypesCase_ = (((pickUpTypes_ = new ItemSelector()) != null) ? PickUpTypesOneofCase.FlowerItem : PickUpTypesOneofCase.None)) != 0;
			}
			ItemSelector flowerItem = FlowerItem;
			ItemSelector flowerItem2 = other.FlowerItem;
			flowerItem.MergeFrom(flowerItem2);
			goto IL_02f4;
			IL_02f4:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB7")]
		[Cpp2IlInjected.Address(RVA = "0x31F3D50", Offset = "0x31F2750", VA = "0x1831F3D50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0228: Expected I4, but got O
			//IL_0304: Expected I4, but got O
			//IL_0355: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 96)
			{
				if ((int)num > 194)
				{
					if ((int)num > 210)
					{
						if (num == 218)
						{
							HangoutWithCharacter hangoutWithCharacter = with_;
							if (hangoutWithCharacter == null)
							{
								HangoutWithCharacter hangoutWithCharacter2 = (with_ = new HangoutWithCharacter());
							}
							input.ReadMessage(hangoutWithCharacter);
						}
						if (num != 242)
						{
							goto IL_0355;
						}
						ItemWithState builder = default(ItemWithState);
						if (rewardOverride_ == null)
						{
							ItemWithState itemWithState = (rewardOverride_ = new ItemWithState());
							builder = rewardOverride_;
						}
						input.ReadMessage(builder);
					}
					StepAmount stepAmount = default(StepAmount);
					if (num == 202)
					{
						StepAmount builder2 = default(StepAmount);
						if (spawnRadius_ == null)
						{
							stepAmount = (spawnRadius_ = new StepAmount());
							builder2 = spawnRadius_;
						}
						input.ReadMessage(builder2);
					}
					if ((long)stepAmount != 210)
					{
						goto IL_0355;
					}
					GridLocationFilter builder3 = default(GridLocationFilter);
					if (pickupLocation_ == null)
					{
						GridLocationFilter gridLocationFilter = (pickupLocation_ = new GridLocationFilter());
						builder3 = pickupLocation_;
					}
					input.ReadMessage(builder3);
				}
				LocationSource locationSource = default(LocationSource);
				if ((int)num > 176)
				{
					if (num == 186)
					{
						LocationSource builder4 = default(LocationSource);
						if (spawnLocationSource_ == null)
						{
							locationSource = (spawnLocationSource_ = new LocationSource());
							builder4 = spawnLocationSource_;
						}
						input.ReadMessage(builder4);
					}
					if ((long)locationSource != 194)
					{
						goto IL_0355;
					}
					RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
					FieldCodec<LocationSource> repeated_spawnLocationSourceList_codec = _repeated_spawnLocationSourceList_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_spawnLocationSourceList_codec);
				}
				bool flag = default(bool);
				if ((long)locationSource == 168)
				{
					flag = (spawnAllItemsFromSameSource_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0355;
				}
				bool flag2 = (useDifferentSourceType_ = input.ReadBool());
			}
			StepAmount stepAmount3 = default(StepAmount);
			if ((int)num > 26)
			{
				bool flag3 = default(bool);
				if ((int)num > 82)
				{
					StepAmount stepAmount2 = default(StepAmount);
					if (num == 90)
					{
						StepAmount builder5 = default(StepAmount);
						if (amountToSpawn_ == null)
						{
							stepAmount2 = (amountToSpawn_ = new StepAmount());
							builder5 = amountToSpawn_;
						}
						input.ReadMessage(builder5);
					}
					if ((long)stepAmount2 != 96)
					{
						goto IL_0355;
					}
					flag3 = (useDifferentItem_ = input.ReadBool());
				}
				if (flag3)
				{
					ItemSelector builder6 = new ItemSelector();
					if (pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem)
					{
						if (pickUpTypesCase_ != PickUpTypesOneofCase.QuestItem)
						{
						}
						object obj = pickUpTypes_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder6);
					pickUpTypes_ = builder6;
					pickUpTypesCase_ = (PickUpTypesOneofCase)typeof(ItemSelector).TypeHandle;
				}
				if ((long)typeof(ItemSelector).TypeHandle != 82)
				{
					goto IL_0355;
				}
				StepAmount builder7 = default(StepAmount);
				if (amountToCollect_ == null)
				{
					stepAmount3 = (amountToCollect_ = new StepAmount());
					builder7 = amountToCollect_;
				}
				input.ReadMessage(builder7);
			}
			bool flag4 = default(bool);
			if ((long)stepAmount3 == 10)
			{
				ItemSelector itemSelector = new ItemSelector();
				if (pickUpTypesCase_ == PickUpTypesOneofCase.FlowerItem)
				{
					if (pickUpTypesCase_ != PickUpTypesOneofCase.FlowerItem)
					{
					}
					object obj2 = pickUpTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(itemSelector);
				pickUpTypes_ = itemSelector;
				flag4 = (byte)(pickUpTypesCase_ = ((itemSelector != null) ? PickUpTypesOneofCase.FlowerItem : PickUpTypesOneofCase.None)) != 0;
			}
			if (flag4)
			{
				ItemSelector builder8 = new ItemSelector();
				if (pickUpTypesCase_ == PickUpTypesOneofCase.EphemeralItem)
				{
					if (pickUpTypesCase_ != PickUpTypesOneofCase.EphemeralItem)
					{
					}
					object obj3 = pickUpTypes_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder8);
				pickUpTypes_ = builder8;
				pickUpTypesCase_ = (PickUpTypesOneofCase)typeof(ItemSelector).TypeHandle;
			}
			if ((long)typeof(ItemSelector).TypeHandle == 26)
			{
				ItemSelector builder9 = new ItemSelector();
				if (pickUpTypesCase_ == PickUpTypesOneofCase.IngredientItem)
				{
					if (pickUpTypesCase_ != PickUpTypesOneofCase.IngredientItem)
					{
					}
					object obj4 = pickUpTypes_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder9);
				pickUpTypes_ = builder9;
				pickUpTypesCase_ = (PickUpTypesOneofCase)typeof(ItemSelector).TypeHandle;
			}
			goto IL_0355;
			IL_0355:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB8")]
		[Cpp2IlInjected.Address(RVA = "0x31F3750", Offset = "0x31F2150", VA = "0x1831F3750", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 26)
			{
				ItemSelector flowerItem = FlowerItem;
			}
			if (fieldNumber == 30)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AB9")]
		[Cpp2IlInjected.Address(RVA = "0x31F4AF0", Offset = "0x31F34F0", VA = "0x1831F4AF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e, IL_0032, IL_0039, IL_0041, IL_0045, IL_004c, IL_0054, IL_0058, IL_005f, IL_0067, IL_006b, IL_0072, IL_007d, IL_0084, IL_008c, IL_008d, IL_008e, IL_0092, IL_0096, IL_009a, IL_00a1, IL_00a5, IL_00ac, IL_00b0, IL_00d7, IL_00dd, IL_00e3, IL_00e9, IL_00ef, IL_00f5
			//IL_001e: Expected O, but got I4
			if (fieldNumber - 1 <= 26)
			{
				int num = 0;
				if (value == null || value != null)
				{
					pickUpTypes_ = num;
					bool flag = (byte)(pickUpTypesCase_ = ((num != 0) ? PickUpTypesOneofCase.FlowerItem : PickUpTypesOneofCase.None)) != 0;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 30)
			{
			}
			if (value == null || value != null)
			{
				rewardOverride_ = (ItemWithState)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003ABA")]
		[Cpp2IlInjected.Address(RVA = "0x31F2BF0", Offset = "0x31F15F0", VA = "0x1831F2BF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0018, IL_0020, IL_0028, IL_0030, IL_0046
			//IL_0010: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			if (fieldNumber - 1 <= 26)
			{
				int num = 0;
				pickUpTypes_ = num;
				pickUpTypesCase_ = (PickUpTypesOneofCase)num;
			}
			else if (fieldNumber == 30)
			{
				int num2 = 0;
				rewardOverride_ = (ItemWithState)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003ABB")]
		[Cpp2IlInjected.Address(RVA = "0x31F3CA0", Offset = "0x31F26A0", VA = "0x1831F3CA0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "PickUpTypes"))
			{
				PickUpTypesOneofCase pickUpTypesOneofCase = pickUpTypesCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003ABC")]
		[Cpp2IlInjected.Address(RVA = "0x31F2D70", Offset = "0x31F1770", VA = "0x1831F2D70", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "PickUpTypes"))
			{
				pickUpTypes_ = (pickUpTypesCase_ = PickUpTypesOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AC4")]
		[Cpp2IlInjected.Address(RVA = "0x31F2E60", Offset = "0x31F1860", VA = "0x1831F2E60", Slot = "26")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0313
			//IL_0143: Expected O, but got I4
			if (pickUpTypesCase_ == PickUpTypesOneofCase.None)
			{
				string missionStepName = context.MissionStepName;
				string error = "Please select a pickup types for " + missionStepName;
				context.AddError(error);
			}
			if ((context.HasParentOfType<AchievementItemData>() || context.HasParentOfType<RoyalDutyItemData>()) && !amountToSpawn_.IsZero())
			{
				context.AddInvalidMemberError("Must be 0", "AmountToSpawn");
			}
			if (!spawnAllItemsFromSameSource_ && useDifferentSourceType_ && Enumerable.ToList<LocationSource>((IEnumerable<>)(object)spawnLocationSourceList_) != null && pickUpTypesCase_ != PickUpTypesOneofCase.QuestItem)
			{
				context.AddInvalidMemberError("Unsupported case: Only QuestItem can have multiple source for now (code issue)", "SpawnLocationSourceList");
			}
			if (context.IsMissionStep)
			{
				StepAmount stepAmount = amountToSpawn_;
				int value = 0;
				if (stepAmount.IsValueSmallerThen(value))
				{
					string missionStepName2 = context.MissionStepName;
					string message = "Should be 0+ in " + missionStepName2;
					context.AddInvalidMemberError(message, "AmountToSpawn");
				}
			}
			if (pickUpTypesCase_ == PickUpTypesOneofCase.QuestItem)
			{
				int value_2 = default(int);
				if (amountToCollect_.stepAmountCase_ == StepAmount.StepAmountOneofCase.Value)
				{
					StepAmount stepAmount2 = amountToSpawn_;
					if (stepAmount2.stepAmountCase_ == StepAmount.StepAmountOneofCase.Value)
					{
						ScalableValue value2 = stepAmount2.Value;
						StepAmount stepAmount3 = amountToCollect_;
						int value_ = value2.value_;
						ScalableValue value3 = stepAmount3.Value;
						if (value_ >= value3.value_)
						{
							goto IL_0152;
						}
						value_2 = amountToCollect_.Value.value_;
					}
				}
				string message2 = $"Should be 'Value' and not '{value_2}' (since it's QuestItem)";
				context.AddInvalidMemberError(message2, "AmountToSpawn");
			}
			goto IL_0152;
			IL_02d2:
			if (spawnRadius_.IsValueGreaterThen(5) && this.IsRadiusUseless())
			{
				string missionStepName3 = context.MissionStepName;
				string message3 = "Radius is useless in this particular case in " + missionStepName3 + ". Please use 5 or less to avoid code issue.";
				context.AddInvalidMemberError(message3, "SpawnRadius");
			}
			return;
			IL_0251:
			context.AddInvalidMemberError("Cannot be used with an Item generator", "UseDifferentItem");
			goto IL_0261;
			IL_0152:
			if (!useDifferentItem_)
			{
				if (!context.IsMissionStep || !amountToCollect_.IsValueSmallerThen(1))
				{
					goto IL_0280;
				}
				string missionStepName4 = context.MissionStepName;
				string text = "Should be 1+ in " + missionStepName4;
			}
			PickUpTypesOneofCase pickUpTypesOneofCase = pickUpTypesCase_;
			PickUpTypesOneofCase pickUpTypesOneofCase2 = default(PickUpTypesOneofCase);
			if (pickUpTypesOneofCase == PickUpTypesOneofCase.QuestItem)
			{
				context.AddInvalidMemberError("Cannot be used with QuestItem", "UseDifferentItem");
				pickUpTypesOneofCase2 = pickUpTypesCase_;
			}
			if (pickUpTypesOneofCase != PickUpTypesOneofCase.QuestItem)
			{
				if (pickUpTypesOneofCase != PickUpTypesOneofCase.QuestItem)
				{
					if (pickUpTypesOneofCase != PickUpTypesOneofCase.QuestItem)
					{
						if (pickUpTypesOneofCase2 != PickUpTypesOneofCase.FlowerItem)
						{
							goto IL_01f7;
						}
						ItemSelector questItem = QuestItem;
					}
					ItemSelector ingredientItem = IngredientItem;
				}
				ItemSelector ephemeralItem = EphemeralItem;
			}
			ItemSelector flowerItem = FlowerItem;
			if (flowerItem == null || flowerItem.itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Item)
			{
				goto IL_01f7;
			}
			goto IL_0251;
			IL_0261:
			if (amountToCollect_.IsValueSmallerThen(2))
			{
				context.AddInvalidMemberError("Must be 2+ when used with UseDifferentItem", "AmountToCollect");
			}
			goto IL_0280;
			IL_01f7:
			PickUpTypesOneofCase pickUpTypesOneofCase3 = pickUpTypesCase_;
			if (flowerItem.itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Item)
			{
				if (flowerItem.itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Item)
				{
					if (flowerItem.itemSelectorCase_ != ItemSelector.ItemSelectorOneofCase.Item)
					{
						if (pickUpTypesOneofCase3 != PickUpTypesOneofCase.FlowerItem)
						{
							goto IL_0261;
						}
						ItemSelector questItem2 = QuestItem;
					}
					ItemSelector ingredientItem2 = IngredientItem;
				}
				ItemSelector ephemeralItem2 = EphemeralItem;
			}
			ItemSelector flowerItem2 = FlowerItem;
			if (flowerItem2 != null && flowerItem2.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.ItemGenerator)
			{
				goto IL_0251;
			}
			goto IL_0261;
			IL_0280:
			if (!spawnRadius_.IsValueGreaterThen(40))
			{
				StepAmount stepAmount4 = spawnRadius_;
				int value4 = 0;
				if (!stepAmount4.IsValueSmallerThen(value4))
				{
					goto IL_02d2;
				}
				string missionStepName5 = context.MissionStepName;
			}
			string missionStepName6 = context.MissionStepName;
			string message4 = "Should be 40- in " + missionStepName6;
			context.AddInvalidMemberError(message4, "SpawnRadius");
			goto IL_02d2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AC5")]
		[Cpp2IlInjected.Address(RVA = "0x31F5510", Offset = "0x31F3F10", VA = "0x1831F5510")]
		static CustomStepPickUp()
		{
			Func<CustomStepPickUp> func = default(Func<CustomStepPickUp>);
			_parser = (MessageParser<CustomStepPickUp>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<LocationSource> parser = LocationSource._parser;
			uint num = default(uint);
			_parser = (MessageParser<CustomStepPickUp>)(object)FieldCodec.ForMessage<LocationSource>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
