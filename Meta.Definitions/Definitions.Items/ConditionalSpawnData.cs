using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003C3")]
	public sealed class ConditionalSpawnData : IMessage<ConditionalSpawnData>, IMessage, IEquatable<ConditionalSpawnData>, IDeepCloneable<ConditionalSpawnData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemSelector, ISpawnHelper, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20003C4")]
		public enum SpawnTypesOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40013DB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40013DC")]
			CraftingMaterialItem,
			[Cpp2IlInjected.Token(Token = "0x40013DD")]
			ConsummableItem,
			[Cpp2IlInjected.Token(Token = "0x40013DE")]
			EphemeralItem,
			[Cpp2IlInjected.Token(Token = "0x40013DF")]
			FlowerItem,
			[Cpp2IlInjected.Token(Token = "0x40013E0")]
			FurnitureItem,
			[Cpp2IlInjected.Token(Token = "0x40013E1")]
			GardenItem,
			[Cpp2IlInjected.Token(Token = "0x40013E2")]
			IngredientItem,
			[Cpp2IlInjected.Token(Token = "0x40013E3")]
			QuestItem,
			[Cpp2IlInjected.Token(Token = "0x40013E4")]
			SeedItem,
			[Cpp2IlInjected.Token(Token = "0x40013E5")]
			LootPresentItem
		}

		[Cpp2IlInjected.Token(Token = "0x40013B7")]
		private static readonly MessageParser<ConditionalSpawnData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40013B8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40013B9")]
		public const int CraftingMaterialItemFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40013BA")]
		public const int ConsummableItemFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40013BB")]
		public const int EphemeralItemFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40013BC")]
		public const int FlowerItemFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40013BD")]
		public const int FurnitureItemFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40013BE")]
		public const int GardenItemFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40013BF")]
		public const int IngredientItemFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x40013C0")]
		public const int QuestItemFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x40013C1")]
		public const int SeedItemFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x40013C2")]
		public const int LootPresentItemFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x40013C3")]
		public const int AmountToSpawnFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40013C4")]
		private StepAmount amountToSpawn_;

		[Cpp2IlInjected.Token(Token = "0x40013C5")]
		public const int SpawnDryFlowerFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40013C6")]
		private bool spawnDryFlower_;

		[Cpp2IlInjected.Token(Token = "0x40013C7")]
		public const int SpawnAllItemsFromSameSourceFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40013C8")]
		private bool spawnAllItemsFromSameSource_;

		[Cpp2IlInjected.Token(Token = "0x40013C9")]
		public const int UseDifferentSourceTypeFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40013CA")]
		private bool useDifferentSourceType_;

		[Cpp2IlInjected.Token(Token = "0x40013CB")]
		public const int SpawnLocationSourceFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40013CC")]
		private LocationSource spawnLocationSource_;

		[Cpp2IlInjected.Token(Token = "0x40013CD")]
		public const int SpawnLocationSourceListFieldNumber = 24;

		[Cpp2IlInjected.Token(Token = "0x40013CE")]
		private static readonly FieldCodec<LocationSource> _repeated_spawnLocationSourceList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40013CF")]
		private readonly RepeatedField<LocationSource> spawnLocationSourceList_;

		[Cpp2IlInjected.Token(Token = "0x40013D0")]
		public const int SpawnRadiusFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40013D1")]
		private StepAmount spawnRadius_;

		[Cpp2IlInjected.Token(Token = "0x40013D2")]
		public const int RewardOverrideFieldNumber = 26;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40013D3")]
		private ItemWithState rewardOverride_;

		[Cpp2IlInjected.Token(Token = "0x40013D4")]
		public const int SpawnAnimatonDataFieldNumber = 27;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40013D5")]
		private LocationSource spawnAnimatonData_;

		[Cpp2IlInjected.Token(Token = "0x40013D6")]
		public const int RemoveWhenDoneFieldNumber = 28;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40013D7")]
		private bool removeWhenDone_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40013D8")]
		private object spawnTypes_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40013D9")]
		private SpawnTypesOneofCase spawnTypesCase_;

		[Cpp2IlInjected.Token(Token = "0x17000B37")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalSpawnData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCA")]
			[Cpp2IlInjected.Address(RVA = "0x24D8E30", Offset = "0x24D7830", VA = "0x1824D8E30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B38")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCB")]
			[Cpp2IlInjected.Address(RVA = "0x24D89D0", Offset = "0x24D73D0", VA = "0x1824D89D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B39")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCC")]
			[Cpp2IlInjected.Address(RVA = "0x24D8F50", Offset = "0x24D7950", VA = "0x1824D8F50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3A")]
		[DebuggerNonUserCode]
		public ItemSelector CraftingMaterialItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD1")]
			[Cpp2IlInjected.Address(RVA = "0x24D8970", Offset = "0x24D7370", VA = "0x1824D8970")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.CraftingMaterialItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CD2")]
			[Cpp2IlInjected.Address(RVA = "0x24D90A0", Offset = "0x24D7AA0", VA = "0x1824D90A0")]
			set
			{
				spawnTypes_ = value;
				bool flag = (byte)(spawnTypesCase_ = ((value != null) ? SpawnTypesOneofCase.CraftingMaterialItem : SpawnTypesOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3B")]
		[DebuggerNonUserCode]
		public ItemSelector ConsummableItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD3")]
			[Cpp2IlInjected.Address(RVA = "0x24D8910", Offset = "0x24D7310", VA = "0x1824D8910")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.ConsummableItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CD4")]
			[Cpp2IlInjected.Address(RVA = "0x24D9060", Offset = "0x24D7A60", VA = "0x1824D9060")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3C")]
		[DebuggerNonUserCode]
		public ItemSelector EphemeralItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD5")]
			[Cpp2IlInjected.Address(RVA = "0x24D8AA0", Offset = "0x24D74A0", VA = "0x1824D8AA0")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.EphemeralItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CD6")]
			[Cpp2IlInjected.Address(RVA = "0x24D90E0", Offset = "0x24D7AE0", VA = "0x1824D90E0")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3D")]
		[DebuggerNonUserCode]
		public ItemSelector FlowerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD7")]
			[Cpp2IlInjected.Address(RVA = "0x24D8B00", Offset = "0x24D7500", VA = "0x1824D8B00")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.FlowerItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CD8")]
			[Cpp2IlInjected.Address(RVA = "0x24D9120", Offset = "0x24D7B20", VA = "0x1824D9120")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3E")]
		[DebuggerNonUserCode]
		public ItemSelector FurnitureItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD9")]
			[Cpp2IlInjected.Address(RVA = "0x24D8B60", Offset = "0x24D7560", VA = "0x1824D8B60")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.FurnitureItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CDA")]
			[Cpp2IlInjected.Address(RVA = "0x24D9160", Offset = "0x24D7B60", VA = "0x1824D9160")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B3F")]
		[DebuggerNonUserCode]
		public SpawnGarden GardenItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDB")]
			[Cpp2IlInjected.Address(RVA = "0x24D8BC0", Offset = "0x24D75C0", VA = "0x1824D8BC0")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.GardenItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CDC")]
			[Cpp2IlInjected.Address(RVA = "0x24D91A0", Offset = "0x24D7BA0", VA = "0x1824D91A0")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B40")]
		[DebuggerNonUserCode]
		public ItemSelector IngredientItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDD")]
			[Cpp2IlInjected.Address(RVA = "0x24D8C20", Offset = "0x24D7620", VA = "0x1824D8C20")]
			get
			{
				if (spawnTypesCase_ == SpawnTypesOneofCase.IngredientItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CDE")]
			[Cpp2IlInjected.Address(RVA = "0x24D91E0", Offset = "0x24D7BE0", VA = "0x1824D91E0")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B41")]
		[DebuggerNonUserCode]
		public ItemSelector QuestItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDF")]
			[Cpp2IlInjected.Address(RVA = "0x24D8E90", Offset = "0x24D7890", VA = "0x1824D8E90")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.QuestItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CE0")]
			[Cpp2IlInjected.Address(RVA = "0x24D9220", Offset = "0x24D7C20", VA = "0x1824D9220")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B42")]
		[DebuggerNonUserCode]
		public ItemSelector SeedItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CE1")]
			[Cpp2IlInjected.Address(RVA = "0x24D8EF0", Offset = "0x24D78F0", VA = "0x1824D8EF0")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.SeedItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CE2")]
			[Cpp2IlInjected.Address(RVA = "0x1D37F50", Offset = "0x1D36950", VA = "0x181D37F50")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B43")]
		[DebuggerNonUserCode]
		public ItemSelector LootPresentItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CE3")]
			[Cpp2IlInjected.Address(RVA = "0x24D8DD0", Offset = "0x24D77D0", VA = "0x1824D8DD0")]
			get
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.LootPresentItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CE4")]
			[Cpp2IlInjected.Address(RVA = "0x1D38150", Offset = "0x1D36B50", VA = "0x181D38150")]
			set
			{
				spawnTypes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B44")]
		[DebuggerNonUserCode]
		public StepAmount AmountToSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6002CE5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "17")]
			get
			{
				return amountToSpawn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CE6")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				amountToSpawn_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B45")]
		[DebuggerNonUserCode]
		public bool SpawnDryFlower
		{
			[Cpp2IlInjected.Token(Token = "0x6002CE7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "23")]
			get
			{
				return spawnDryFlower_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CE8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				spawnDryFlower_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B46")]
		[DebuggerNonUserCode]
		public bool SpawnAllItemsFromSameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6002CE9")]
			[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
			get
			{
				return spawnAllItemsFromSameSource_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CEA")]
			[Cpp2IlInjected.Address(RVA = "0xBA18C0", Offset = "0xBA02C0", VA = "0x180BA18C0")]
			set
			{
				spawnAllItemsFromSameSource_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B47")]
		[DebuggerNonUserCode]
		public bool UseDifferentSourceType
		{
			[Cpp2IlInjected.Token(Token = "0x6002CEB")]
			[Cpp2IlInjected.Address(RVA = "0x1D4C170", Offset = "0x1D4AB70", VA = "0x181D4C170")]
			get
			{
				return useDifferentSourceType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CEC")]
			[Cpp2IlInjected.Address(RVA = "0x1E14550", Offset = "0x1E12F50", VA = "0x181E14550")]
			set
			{
				useDifferentSourceType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B48")]
		[DebuggerNonUserCode]
		public LocationSource SpawnLocationSource
		{
			[Cpp2IlInjected.Token(Token = "0x6002CED")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return spawnLocationSource_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CEE")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				spawnLocationSource_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B49")]
		[DebuggerNonUserCode]
		public RepeatedField<LocationSource> SpawnLocationSourceList
		{
			[Cpp2IlInjected.Token(Token = "0x6002CEF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return spawnLocationSourceList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4A")]
		[DebuggerNonUserCode]
		public StepAmount SpawnRadius
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return spawnRadius_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CF1")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				spawnRadius_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4B")]
		[DebuggerNonUserCode]
		public ItemWithState RewardOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF2")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "22")]
			get
			{
				return rewardOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CF3")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				rewardOverride_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4C")]
		[DebuggerNonUserCode]
		public LocationSource SpawnAnimatonData
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF4")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return spawnAnimatonData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CF5")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				spawnAnimatonData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4D")]
		[DebuggerNonUserCode]
		public bool RemoveWhenDone
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF6")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return removeWhenDone_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CF7")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				removeWhenDone_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4E")]
		[DebuggerNonUserCode]
		public SpawnTypesOneofCase SpawnTypesCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF8")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return spawnTypesCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B4F")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6002D07")]
			[Cpp2IlInjected.Address(RVA = "0x24D8C80", Offset = "0x24D7680", VA = "0x1824D8C80", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0011, IL_0018, IL_001f, IL_0026, IL_002d, IL_0039, IL_0040, IL_0047, IL_004e
				if (spawnTypesCase_ <= SpawnTypesOneofCase.SeedItem)
				{
					return CraftingMaterialItem;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B50")]
		public bool UseMultiSources
		{
			[Cpp2IlInjected.Token(Token = "0x6002D08")]
			[Cpp2IlInjected.Address(RVA = "0x102E8C0", Offset = "0x102D2C0", VA = "0x18102E8C0", Slot = "18")]
			get
			{
				return !spawnAllItemsFromSameSource_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B51")]
		public LocationSource LocationSource
		{
			[Cpp2IlInjected.Token(Token = "0x6002D09")]
			[Cpp2IlInjected.Address(RVA = "0x24D8DB0", Offset = "0x24D77B0", VA = "0x1824D8DB0", Slot = "19")]
			get
			{
				if (!spawnAllItemsFromSameSource_ && useDifferentSourceType_)
				{
					int num = 0;
				}
				return spawnLocationSource_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B52")]
		public List<LocationSource> LocationSourceList
		{
			[Cpp2IlInjected.Token(Token = "0x6002D0A")]
			[Cpp2IlInjected.Address(RVA = "0x24D8D60", Offset = "0x24D7760", VA = "0x1824D8D60", Slot = "20")]
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

		[Cpp2IlInjected.Token(Token = "0x6002CCD")]
		[Cpp2IlInjected.Address(RVA = "0x24D83A0", Offset = "0x24D6DA0", VA = "0x1824D83A0")]
		[DebuggerNonUserCode]
		public ConditionalSpawnData()
		{
			spawnLocationSourceList_ = (RepeatedField<LocationSource>)(object)new RepeatedField<T>();
			base._002Ector();
			StepAmount stepAmount = (amountToSpawn_ = new StepAmount());
			LocationSource locationSource = (spawnLocationSource_ = new LocationSource());
			StepAmount stepAmount2 = (spawnRadius_ = new StepAmount());
			ItemWithState itemWithState = (rewardOverride_ = new ItemWithState());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CCE")]
		[Cpp2IlInjected.Address(RVA = "0x24D7290", Offset = "0x24D5C90", VA = "0x1824D7290")]
		private void OnConstruction()
		{
			StepAmount stepAmount = (amountToSpawn_ = new StepAmount());
			LocationSource locationSource = (spawnLocationSource_ = new LocationSource());
			StepAmount stepAmount2 = (spawnRadius_ = new StepAmount());
			ItemWithState itemWithState = (rewardOverride_ = new ItemWithState());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CCF")]
		[Cpp2IlInjected.Address(RVA = "0x24D84F0", Offset = "0x24D6EF0", VA = "0x1824D84F0")]
		[DebuggerNonUserCode]
		public ConditionalSpawnData(ConditionalSpawnData other)
		{
			//IL_001b: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00d2: Expected O, but got I4
			//IL_01db: Expected I4, but got O
			StepAmount stepAmount = other.amountToSpawn_;
			int num = 0;
			if (stepAmount != null)
			{
				StepAmount stepAmount2 = stepAmount.Clone();
			}
			amountToSpawn_ = (StepAmount)num;
			bool flag = (spawnDryFlower_ = other.spawnDryFlower_);
			bool flag2 = (spawnAllItemsFromSameSource_ = other.spawnAllItemsFromSameSource_);
			bool flag3 = (useDifferentSourceType_ = other.useDifferentSourceType_);
			LocationSource locationSource = other.spawnLocationSource_;
			if (locationSource != null)
			{
				LocationSource locationSource2 = locationSource.Clone();
			}
			spawnLocationSource_ = (LocationSource)num;
			RepeatedField<LocationSource> repeatedField = (spawnLocationSourceList_ = (RepeatedField<LocationSource>)(object)((RepeatedField<T>)(object)other.spawnLocationSourceList_).Clone());
			StepAmount stepAmount3 = other.spawnRadius_;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			spawnRadius_ = (StepAmount)num;
			ItemWithState itemWithState = other.rewardOverride_;
			if (itemWithState != null)
			{
				ItemWithState itemWithState2 = itemWithState.Clone();
			}
			rewardOverride_ = (ItemWithState)num;
			LocationSource locationSource3 = other.spawnAnimatonData_;
			if (locationSource3 != null)
			{
				LocationSource locationSource4 = locationSource3.Clone();
			}
			spawnAnimatonData_ = (LocationSource)num;
			bool flag4 = (removeWhenDone_ = other.removeWhenDone_);
			if (other.spawnTypesCase_ <= SpawnTypesOneofCase.SeedItem)
			{
				bool flag5 = (byte)(spawnTypesCase_ = (((spawnTypes_ = other.CraftingMaterialItem.Clone()) != null) ? SpawnTypesOneofCase.CraftingMaterialItem : SpawnTypesOneofCase.None)) != 0;
				ItemSelector itemSelector = (ItemSelector)(spawnTypes_ = other.ConsummableItem.Clone());
				ItemSelector itemSelector2 = (ItemSelector)(spawnTypes_ = other.EphemeralItem.Clone());
				ItemSelector itemSelector3 = (ItemSelector)(spawnTypes_ = other.FlowerItem.Clone());
				ItemSelector itemSelector4 = (ItemSelector)(spawnTypes_ = other.FurnitureItem.Clone());
				SpawnGarden spawnGarden = (SpawnGarden)(spawnTypes_ = other.GardenItem.Clone());
				ItemSelector itemSelector5 = (ItemSelector)(spawnTypes_ = other.IngredientItem.Clone());
				ItemSelector itemSelector6 = (ItemSelector)(spawnTypes_ = other.QuestItem.Clone());
				ItemSelector itemSelector7 = (ItemSelector)(spawnTypes_ = other.SeedItem.Clone());
				spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = other.LootPresentItem.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD0")]
		[Cpp2IlInjected.Address(RVA = "0x24D4D00", Offset = "0x24D3700", VA = "0x1824D4D00", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalSpawnData Clone()
		{
			return new ConditionalSpawnData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CF9")]
		[Cpp2IlInjected.Address(RVA = "0x1D36160", Offset = "0x1D34B60", VA = "0x181D36160")]
		[DebuggerNonUserCode]
		public void ClearSpawnTypes()
		{
			//IL_0010: Expected O, but got I4
			spawnTypes_ = (spawnTypesCase_ = SpawnTypesOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFA")]
		[Cpp2IlInjected.Address(RVA = "0x24D5440", Offset = "0x24D3E40", VA = "0x1824D5440", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ConditionalSpawnData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFB")]
		[Cpp2IlInjected.Address(RVA = "0x24D54A0", Offset = "0x24D3EA0", VA = "0x1824D54A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalSpawnData other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (spawnTypesCase_ == SpawnTypesOneofCase.CraftingMaterialItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
						goto IL_0288;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.spawnTypesCase_ == SpawnTypesOneofCase.CraftingMaterialItem)
				{
					obj2 = other.spawnTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ItemSelector consummableItem = ConsummableItem;
					ItemSelector consummableItem2 = other.ConsummableItem;
					if (object.Equals(consummableItem, consummableItem2))
					{
						ItemSelector ephemeralItem = EphemeralItem;
						ItemSelector ephemeralItem2 = other.EphemeralItem;
						if (object.Equals(ephemeralItem, ephemeralItem2))
						{
							ItemSelector flowerItem = FlowerItem;
							ItemSelector flowerItem2 = other.FlowerItem;
							if (object.Equals(flowerItem, flowerItem2))
							{
								ItemSelector furnitureItem = FurnitureItem;
								ItemSelector furnitureItem2 = other.FurnitureItem;
								if (object.Equals(furnitureItem, furnitureItem2))
								{
									SpawnGarden gardenItem = GardenItem;
									SpawnGarden gardenItem2 = other.GardenItem;
									if (object.Equals(gardenItem, gardenItem2))
									{
										ItemSelector ingredientItem = IngredientItem;
										ItemSelector ingredientItem2 = other.IngredientItem;
										if (object.Equals(ingredientItem, ingredientItem2))
										{
											ItemSelector questItem = QuestItem;
											ItemSelector questItem2 = other.QuestItem;
											if (object.Equals(questItem, questItem2))
											{
												ItemSelector seedItem = SeedItem;
												ItemSelector seedItem2 = other.SeedItem;
												if (object.Equals(seedItem, seedItem2))
												{
													ItemSelector lootPresentItem = LootPresentItem;
													ItemSelector lootPresentItem2 = other.LootPresentItem;
													if (object.Equals(lootPresentItem, lootPresentItem2))
													{
														StepAmount objB = other.amountToSpawn_;
														if (object.Equals(amountToSpawn_, objB))
														{
															bool flag = other.spawnDryFlower_;
															if (spawnDryFlower_ == flag)
															{
																bool flag2 = other.spawnAllItemsFromSameSource_;
																if (spawnAllItemsFromSameSource_ == flag2)
																{
																	bool flag3 = other.useDifferentSourceType_;
																	if (useDifferentSourceType_ == flag3)
																	{
																		LocationSource objB2 = other.spawnLocationSource_;
																		if (object.Equals(spawnLocationSource_, objB2))
																		{
																			RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
																			RepeatedField<LocationSource> repeatedField2 = other.spawnLocationSourceList_;
																			if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																			{
																				StepAmount objB3 = other.spawnRadius_;
																				if (object.Equals(spawnRadius_, objB3))
																				{
																					ItemWithState objB4 = other.rewardOverride_;
																					if (object.Equals(rewardOverride_, objB4))
																					{
																						LocationSource objB5 = other.spawnAnimatonData_;
																						if (object.Equals(spawnAnimatonData_, objB5))
																						{
																							bool flag4 = other.removeWhenDone_;
																							if (removeWhenDone_ == flag4)
																							{
																								SpawnTypesOneofCase spawnTypesOneofCase = other.spawnTypesCase_;
																								if (spawnTypesCase_ == spawnTypesOneofCase)
																								{
																									UnknownFieldSet unknownFields = other._unknownFields;
																									bool flag5 = object.Equals(_unknownFields, unknownFields);
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
				}
			}
			int num2 = 0;
			goto IL_0288;
			IL_0288:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFC")]
		[Cpp2IlInjected.Address(RVA = "0x24D5A90", Offset = "0x24D4490", VA = "0x1824D5A90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0218
			while (true)
			{
				SpawnTypesOneofCase spawnTypesOneofCase = spawnTypesCase_;
				int num = 0;
				if (spawnTypesOneofCase == SpawnTypesOneofCase.CraftingMaterialItem)
				{
					object obj = spawnTypes_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (spawnTypesOneofCase != SpawnTypesOneofCase.ConsummableItem)
				{
					continue;
				}
				object obj2 = spawnTypes_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (spawnTypesCase_ != SpawnTypesOneofCase.EphemeralItem)
					{
						continue;
					}
					object obj3 = spawnTypes_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (spawnTypesCase_ != SpawnTypesOneofCase.FlowerItem)
						{
							continue;
						}
						object obj4 = spawnTypes_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (spawnTypesCase_ != SpawnTypesOneofCase.FurnitureItem)
							{
								continue;
							}
							object obj5 = spawnTypes_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (spawnTypesCase_ != SpawnTypesOneofCase.GardenItem)
								{
									continue;
								}
								object obj6 = spawnTypes_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (spawnTypesCase_ != SpawnTypesOneofCase.IngredientItem)
									{
										continue;
									}
									object obj7 = spawnTypes_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (spawnTypesCase_ != SpawnTypesOneofCase.QuestItem)
										{
											continue;
										}
										object obj8 = spawnTypes_;
										if (obj8 != null)
										{
											int hashCode8 = obj8.GetHashCode();
											if (spawnTypesCase_ != SpawnTypesOneofCase.SeedItem)
											{
												continue;
											}
											object obj9 = spawnTypes_;
											if (obj9 != null)
											{
												int hashCode9 = obj9.GetHashCode();
												if (spawnTypesCase_ == SpawnTypesOneofCase.LootPresentItem)
												{
													object obj10 = spawnTypes_;
													if (obj10 == null)
													{
														break;
													}
													int hashCode10 = obj10.GetHashCode();
												}
												StepAmount stepAmount = amountToSpawn_;
												if (stepAmount != null)
												{
													int hashCode11 = stepAmount.GetHashCode();
												}
												if (spawnDryFlower_)
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
													int hashCode12 = locationSource.GetHashCode();
												}
												int hashCode13 = ((RepeatedField<T>)(object)spawnLocationSourceList_).GetHashCode();
												StepAmount stepAmount2 = spawnRadius_;
												if (stepAmount2 != null)
												{
													int hashCode14 = stepAmount2.GetHashCode();
												}
												ItemWithState itemWithState = rewardOverride_;
												if (itemWithState != null)
												{
													int hashCode15 = itemWithState.GetHashCode();
												}
												LocationSource locationSource2 = spawnAnimatonData_;
												if (locationSource2 != null)
												{
													int hashCode16 = locationSource2.GetHashCode();
												}
												if (removeWhenDone_)
												{
												}
												UnknownFieldSet unknownFields = _unknownFields;
												if (unknownFields != null)
												{
													int hashCode17 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6002CFD")]
		[Cpp2IlInjected.Address(RVA = "0x24D7A70", Offset = "0x24D6470", VA = "0x1824D7A70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFE")]
		[Cpp2IlInjected.Address(RVA = "0x24D7AD0", Offset = "0x24D64D0", VA = "0x1824D7AD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_02b6
			//IL_002f: Expected O, but got I4
			while (true)
			{
				SpawnTypesOneofCase spawnTypesOneofCase = spawnTypesCase_;
				int num = 0;
				if (spawnTypesOneofCase == SpawnTypesOneofCase.CraftingMaterialItem)
				{
					if (spawnTypesCase_ == SpawnTypesOneofCase.CraftingMaterialItem)
					{
						object obj = spawnTypes_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (spawnTypesOneofCase != SpawnTypesOneofCase.ConsummableItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.ConsummableItem)
				{
					object obj2 = spawnTypes_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (spawnTypesCase_ != SpawnTypesOneofCase.EphemeralItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.EphemeralItem)
				{
					object obj3 = spawnTypes_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (spawnTypesCase_ != SpawnTypesOneofCase.FlowerItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.FlowerItem)
				{
					object obj4 = spawnTypes_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (spawnTypesCase_ != SpawnTypesOneofCase.FurnitureItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.FurnitureItem)
				{
					object obj5 = spawnTypes_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (spawnTypesCase_ != SpawnTypesOneofCase.GardenItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.GardenItem)
				{
					object obj6 = spawnTypes_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (spawnTypesCase_ != SpawnTypesOneofCase.IngredientItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.IngredientItem)
				{
					object obj7 = spawnTypes_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (spawnTypesCase_ != SpawnTypesOneofCase.QuestItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.QuestItem)
				{
					object obj8 = spawnTypes_;
					if (obj8 != null && obj8 == null)
					{
						break;
					}
				}
				if (spawnTypesCase_ != SpawnTypesOneofCase.SeedItem)
				{
					continue;
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.SeedItem)
				{
					object obj9 = spawnTypes_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (spawnTypesCase_ == SpawnTypesOneofCase.LootPresentItem && spawnTypesCase_ == SpawnTypesOneofCase.LootPresentItem)
				{
					object obj10 = spawnTypes_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if ((long)amountToSpawn_ != 0)
				{
					StepAmount value = amountToSpawn_;
					output.WriteMessage(value);
				}
				if (spawnDryFlower_)
				{
					bool value2 = spawnDryFlower_;
					output.WriteBool(value2);
				}
				if (spawnAllItemsFromSameSource_)
				{
					bool value3 = spawnAllItemsFromSameSource_;
					output.WriteBool(value3);
				}
				if (useDifferentSourceType_)
				{
					bool value4 = useDifferentSourceType_;
					output.WriteBool(value4);
				}
				if ((long)spawnLocationSource_ != 0)
				{
					LocationSource value5 = spawnLocationSource_;
					output.WriteMessage(value5);
				}
				RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
				FieldCodec<LocationSource> repeated_spawnLocationSourceList_codec = _repeated_spawnLocationSourceList_codec;
				((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_spawnLocationSourceList_codec);
				if ((long)spawnRadius_ != 0)
				{
					StepAmount value6 = spawnRadius_;
					output.WriteMessage(value6);
				}
				if ((long)rewardOverride_ != 0)
				{
					ItemWithState value7 = rewardOverride_;
					output.WriteMessage(value7);
				}
				if ((long)spawnAnimatonData_ != 0)
				{
					LocationSource value8 = spawnAnimatonData_;
					output.WriteMessage(value8);
				}
				if (removeWhenDone_)
				{
					bool value9 = removeWhenDone_;
					output.WriteBool(value9);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CFF")]
		[Cpp2IlInjected.Address(RVA = "0x24D43C0", Offset = "0x24D2DC0", VA = "0x1824D43C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_02bf
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (spawnTypesCase_ == SpawnTypesOneofCase.CraftingMaterialItem)
			{
				if (spawnTypesCase_ == SpawnTypesOneofCase.CraftingMaterialItem)
				{
					object obj = spawnTypes_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.ConsummableItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.ConsummableItem)
				{
				}
				object obj2 = spawnTypes_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.EphemeralItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.EphemeralItem)
				{
				}
				object obj3 = spawnTypes_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.FlowerItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.FlowerItem)
				{
				}
				object obj4 = spawnTypes_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.FurnitureItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.FurnitureItem)
				{
				}
				object obj5 = spawnTypes_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.GardenItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.GardenItem)
				{
				}
				object obj6 = spawnTypes_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.IngredientItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.IngredientItem)
				{
				}
				object obj7 = spawnTypes_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.QuestItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.QuestItem)
				{
				}
				object obj8 = spawnTypes_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num9 = default(int);
				num += num9;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.SeedItem)
			{
				if (spawnTypesCase_ != SpawnTypesOneofCase.SeedItem)
				{
				}
				object obj9 = spawnTypes_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num10 = default(int);
				num += num10;
			}
			if (spawnTypesCase_ == SpawnTypesOneofCase.LootPresentItem)
			{
				if (spawnTypesCase_ == SpawnTypesOneofCase.LootPresentItem)
				{
					object obj10 = spawnTypes_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num11 = default(int);
				num += num11;
			}
			StepAmount stepAmount = amountToSpawn_;
			if (stepAmount != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num12++;
				num += num12;
			}
			LocationSource locationSource = spawnLocationSource_;
			if (locationSource != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(locationSource);
				num13 += 2;
				num += num13;
			}
			RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
			FieldCodec<LocationSource> repeated_spawnLocationSourceList_codec = _repeated_spawnLocationSourceList_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_spawnLocationSourceList_codec);
			StepAmount stepAmount2 = spawnRadius_;
			num += num14;
			if (stepAmount2 != null)
			{
				int num15 = CodedOutputStream.ComputeMessageSize(stepAmount2);
				num15 += 2;
				num += num15;
			}
			ItemWithState itemWithState = rewardOverride_;
			if (itemWithState != null)
			{
				int num16 = CodedOutputStream.ComputeMessageSize(itemWithState);
				num16 += 2;
				num += num16;
			}
			LocationSource locationSource2 = spawnAnimatonData_;
			if (locationSource2 != null)
			{
				int num17 = CodedOutputStream.ComputeMessageSize(locationSource2);
				num17 += 2;
				num += num17;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num18 = unknownFields.CalculateSize();
				num += num18;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D00")]
		[Cpp2IlInjected.Address(RVA = "0x24D6110", Offset = "0x24D4B10", VA = "0x1824D6110", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalSpawnData other)
		{
			//Discarded unreachable code: IL_03c5
			//IL_0203: Expected I4, but got O
			//IL_0233: Expected I4, but got O
			//IL_0263: Expected I4, but got O
			//IL_0293: Expected I4, but got O
			//IL_02c3: Expected I4, but got O
			//IL_02fc: Expected I4, but got O
			//IL_032c: Expected I4, but got O
			//IL_035c: Expected I4, but got O
			//IL_038c: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.amountToSpawn_ != 0)
			{
				StepAmount stepAmount = amountToSpawn_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (amountToSpawn_ = new StepAmount());
					StepAmount stepAmount3 = amountToSpawn_;
				}
				StepAmount other2 = other.amountToSpawn_;
				stepAmount.MergeFrom(other2);
			}
			bool flag = other.spawnDryFlower_;
			if (flag)
			{
				spawnDryFlower_ = flag;
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
				LocationSource other3 = other.spawnLocationSource_;
				locationSource2.MergeFrom(other3);
			}
			RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
			RepeatedField<LocationSource> repeatedField2 = other.spawnLocationSourceList_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.spawnRadius_ != 0)
			{
				StepAmount stepAmount5 = default(StepAmount);
				if (spawnRadius_ == null)
				{
					StepAmount stepAmount4 = (spawnRadius_ = new StepAmount());
					stepAmount5 = spawnRadius_;
				}
				StepAmount other4 = other.spawnRadius_;
				stepAmount5.MergeFrom(other4);
			}
			if ((long)other.rewardOverride_ != 0)
			{
				ItemWithState itemWithState2 = default(ItemWithState);
				if (rewardOverride_ == null)
				{
					ItemWithState itemWithState = (rewardOverride_ = new ItemWithState());
					itemWithState2 = rewardOverride_;
				}
				ItemWithState other5 = other.rewardOverride_;
				itemWithState2.MergeFrom(other5);
			}
			if ((long)other.spawnAnimatonData_ != 0)
			{
				LocationSource locationSource4 = default(LocationSource);
				if (spawnAnimatonData_ == null)
				{
					LocationSource locationSource3 = (spawnAnimatonData_ = new LocationSource());
					locationSource4 = spawnAnimatonData_;
				}
				LocationSource other6 = other.spawnAnimatonData_;
				locationSource4.MergeFrom(other6);
			}
			bool flag4 = other.removeWhenDone_;
			if (flag4)
			{
				removeWhenDone_ = flag4;
			}
			if (other.spawnTypesCase_ <= SpawnTypesOneofCase.SeedItem)
			{
				if (CraftingMaterialItem == null)
				{
					bool flag5 = (byte)(spawnTypesCase_ = (((spawnTypes_ = new ItemSelector()) != null) ? SpawnTypesOneofCase.CraftingMaterialItem : SpawnTypesOneofCase.None)) != 0;
				}
				ItemSelector craftingMaterialItem = CraftingMaterialItem;
				ItemSelector craftingMaterialItem2 = other.CraftingMaterialItem;
				if (ConsummableItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector consummableItem = ConsummableItem;
				ItemSelector consummableItem2 = other.ConsummableItem;
				if (EphemeralItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector ephemeralItem = EphemeralItem;
				ItemSelector ephemeralItem2 = other.EphemeralItem;
				if (FlowerItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector flowerItem = FlowerItem;
				ItemSelector flowerItem2 = other.FlowerItem;
				if (FurnitureItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector furnitureItem = FurnitureItem;
				ItemSelector furnitureItem2 = other.FurnitureItem;
				if (GardenItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new SpawnGarden());
				}
				SpawnGarden gardenItem = GardenItem;
				SpawnGarden gardenItem2 = other.GardenItem;
				gardenItem.MergeFrom(gardenItem2);
				if (IngredientItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector ingredientItem = IngredientItem;
				ItemSelector ingredientItem2 = other.IngredientItem;
				if (QuestItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector questItem = QuestItem;
				ItemSelector questItem2 = other.QuestItem;
				if (SeedItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector seedItem = SeedItem;
				ItemSelector seedItem2 = other.SeedItem;
				if (LootPresentItem == null)
				{
					spawnTypesCase_ = (SpawnTypesOneofCase)(spawnTypes_ = new ItemSelector());
				}
				ItemSelector lootPresentItem = LootPresentItem;
				ItemSelector lootPresentItem2 = other.LootPresentItem;
				lootPresentItem.MergeFrom(lootPresentItem2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002D01")]
		[Cpp2IlInjected.Address(RVA = "0x24D67D0", Offset = "0x24D51D0", VA = "0x1824D67D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0210: Expected I4, but got O
			//IL_0266: Expected I4, but got O
			//IL_02bf: Expected I4, but got O
			//IL_0313: Expected I4, but got O
			//IL_036a: Expected I4, but got O
			//IL_03cc: Expected I4, but got O
			//IL_0420: Expected I4, but got O
			//IL_0477: Expected I4, but got O
			//IL_051d: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 82)
			{
				if ((int)num > 186)
				{
					if ((int)num > 202)
					{
						if (num == 210)
						{
							ItemWithState itemWithState = rewardOverride_;
							if (itemWithState == null)
							{
								ItemWithState itemWithState2 = (rewardOverride_ = new ItemWithState());
							}
							input.ReadMessage(itemWithState);
						}
						LocationSource locationSource = default(LocationSource);
						if (num == 218)
						{
							LocationSource builder = default(LocationSource);
							if (spawnAnimatonData_ == null)
							{
								locationSource = (spawnAnimatonData_ = new LocationSource());
								builder = spawnAnimatonData_;
							}
							input.ReadMessage(builder);
						}
						if ((long)locationSource != 224)
						{
							goto IL_051d;
						}
						bool flag = (removeWhenDone_ = input.ReadBool());
					}
					if (num == 194)
					{
						RepeatedField<LocationSource> repeatedField = spawnLocationSourceList_;
						FieldCodec<LocationSource> repeated_spawnLocationSourceList_codec = _repeated_spawnLocationSourceList_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_spawnLocationSourceList_codec);
					}
					if (num != 202)
					{
						goto IL_051d;
					}
					StepAmount builder2 = default(StepAmount);
					if (spawnRadius_ == null)
					{
						StepAmount stepAmount = (spawnRadius_ = new StepAmount());
						builder2 = spawnRadius_;
					}
					input.ReadMessage(builder2);
				}
				LocationSource locationSource2 = default(LocationSource);
				if ((int)num > 160)
				{
					bool flag2 = default(bool);
					if (num == 168)
					{
						flag2 = (spawnAllItemsFromSameSource_ = input.ReadBool());
					}
					bool flag3 = default(bool);
					if (flag2)
					{
						flag3 = (useDifferentSourceType_ = input.ReadBool());
					}
					if (!flag3)
					{
						goto IL_051d;
					}
					LocationSource builder3 = default(LocationSource);
					if (spawnLocationSource_ == null)
					{
						locationSource2 = (spawnLocationSource_ = new LocationSource());
						builder3 = spawnLocationSource_;
					}
					input.ReadMessage(builder3);
				}
				StepAmount stepAmount2 = default(StepAmount);
				if ((long)locationSource2 == 90)
				{
					StepAmount builder4 = default(StepAmount);
					if (amountToSpawn_ == null)
					{
						stepAmount2 = (amountToSpawn_ = new StepAmount());
						builder4 = amountToSpawn_;
					}
					input.ReadMessage(builder4);
				}
				if ((long)stepAmount2 != 160)
				{
					goto IL_051d;
				}
				bool flag4 = (spawnDryFlower_ = input.ReadBool());
			}
			if ((int)num > 42)
			{
				if ((int)num > 58)
				{
					if (num == 66)
					{
						ItemSelector builder5 = new ItemSelector();
						if (spawnTypesCase_ == SpawnTypesOneofCase.QuestItem)
						{
							if (spawnTypesCase_ != SpawnTypesOneofCase.QuestItem)
							{
							}
							object obj = spawnTypes_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder5);
						spawnTypes_ = builder5;
						spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
					}
					if ((long)typeof(ItemSelector).TypeHandle == 74)
					{
						ItemSelector builder6 = new ItemSelector();
						if (spawnTypesCase_ == SpawnTypesOneofCase.SeedItem)
						{
							if (spawnTypesCase_ != SpawnTypesOneofCase.SeedItem)
							{
							}
							object obj2 = spawnTypes_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder6);
						spawnTypes_ = builder6;
						spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
					}
					if ((long)typeof(ItemSelector).TypeHandle != 82)
					{
						goto IL_051d;
					}
					ItemSelector builder7 = new ItemSelector();
					if (spawnTypesCase_ == SpawnTypesOneofCase.LootPresentItem)
					{
						if (spawnTypesCase_ != SpawnTypesOneofCase.LootPresentItem)
						{
						}
						object obj3 = spawnTypes_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder7);
					spawnTypes_ = builder7;
					spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
				}
				if ((long)typeof(ItemSelector).TypeHandle == 50)
				{
					SpawnGarden builder8 = new SpawnGarden();
					if (spawnTypesCase_ == SpawnTypesOneofCase.GardenItem)
					{
						if (spawnTypesCase_ != SpawnTypesOneofCase.GardenItem)
						{
						}
						object obj4 = spawnTypes_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder8);
					spawnTypes_ = builder8;
					spawnTypesCase_ = (SpawnTypesOneofCase)typeof(SpawnGarden).TypeHandle;
				}
				if ((long)typeof(SpawnGarden).TypeHandle != 58)
				{
					goto IL_051d;
				}
				ItemSelector builder9 = new ItemSelector();
				if (spawnTypesCase_ == SpawnTypesOneofCase.IngredientItem)
				{
					if (spawnTypesCase_ != SpawnTypesOneofCase.IngredientItem)
					{
					}
					object obj5 = spawnTypes_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder9);
				spawnTypes_ = builder9;
				spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
			}
			if ((long)typeof(ItemSelector).TypeHandle > 18)
			{
				if ((long)typeof(ItemSelector).TypeHandle == 26)
				{
					ItemSelector builder10 = new ItemSelector();
					if (spawnTypesCase_ == SpawnTypesOneofCase.EphemeralItem)
					{
						if (spawnTypesCase_ != SpawnTypesOneofCase.EphemeralItem)
						{
						}
						object obj6 = spawnTypes_;
						if (obj6 != null && obj6 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder10);
					spawnTypes_ = builder10;
					spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
				}
				if ((long)typeof(ItemSelector).TypeHandle == 34)
				{
					ItemSelector builder11 = new ItemSelector();
					if (spawnTypesCase_ == SpawnTypesOneofCase.FlowerItem)
					{
						if (spawnTypesCase_ != SpawnTypesOneofCase.FlowerItem)
						{
						}
						object obj7 = spawnTypes_;
						if (obj7 != null && obj7 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder11);
					spawnTypes_ = builder11;
					spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
				}
				if ((long)typeof(ItemSelector).TypeHandle != 42)
				{
					goto IL_051d;
				}
				ItemSelector builder12 = new ItemSelector();
				if (spawnTypesCase_ == SpawnTypesOneofCase.FurnitureItem)
				{
					if (spawnTypesCase_ != SpawnTypesOneofCase.FurnitureItem)
					{
					}
					object obj8 = spawnTypes_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder12);
				spawnTypes_ = builder12;
				spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
			}
			bool flag5 = default(bool);
			if ((long)typeof(ItemSelector).TypeHandle == 10)
			{
				ItemSelector itemSelector = new ItemSelector();
				if (spawnTypesCase_ == SpawnTypesOneofCase.CraftingMaterialItem)
				{
					if (spawnTypesCase_ != SpawnTypesOneofCase.CraftingMaterialItem)
					{
					}
					object obj9 = spawnTypes_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(itemSelector);
				spawnTypes_ = itemSelector;
				flag5 = (byte)(spawnTypesCase_ = ((itemSelector != null) ? SpawnTypesOneofCase.CraftingMaterialItem : SpawnTypesOneofCase.None)) != 0;
			}
			if (flag5)
			{
				ItemSelector builder13 = new ItemSelector();
				if (spawnTypesCase_ == SpawnTypesOneofCase.ConsummableItem)
				{
					if (spawnTypesCase_ != SpawnTypesOneofCase.ConsummableItem)
					{
					}
					object obj10 = spawnTypes_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder13);
				spawnTypes_ = builder13;
				spawnTypesCase_ = (SpawnTypesOneofCase)typeof(ItemSelector).TypeHandle;
			}
			goto IL_051d;
			IL_051d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002D02")]
		[Cpp2IlInjected.Address(RVA = "0x24D5820", Offset = "0x24D4220", VA = "0x1824D5820", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 27)
			{
				ItemSelector craftingMaterialItem = CraftingMaterialItem;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D03")]
		[Cpp2IlInjected.Address(RVA = "0x24D7380", Offset = "0x24D5D80", VA = "0x1824D7380", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002b, IL_002f, IL_0036, IL_0037, IL_003b, IL_0042, IL_0043, IL_0047, IL_004e, IL_004f, IL_0053, IL_005a, IL_005b, IL_005f, IL_0066, IL_0067, IL_006b, IL_0072, IL_0073, IL_0077, IL_007e, IL_007f, IL_0083, IL_008a, IL_008b, IL_008f, IL_0096, IL_0097, IL_009b, IL_009f, IL_00a0, IL_00a1, IL_00a2, IL_00a6, IL_00aa, IL_00ae, IL_00b5, IL_00b9, IL_00c0, IL_00c4, IL_00cb, IL_00cc, IL_00d8, IL_00de, IL_00e4, IL_00ea, IL_00f0, IL_00f6, IL_00fc, IL_0102, IL_0108, IL_010e, IL_0114
			//IL_001b: Expected O, but got I4
			if (fieldNumber - 1 <= 27)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				spawnTypes_ = num;
				bool flag = (byte)(spawnTypesCase_ = ((num != 0) ? SpawnTypesOneofCase.CraftingMaterialItem : SpawnTypesOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D04")]
		[Cpp2IlInjected.Address(RVA = "0x24D4AC0", Offset = "0x24D34C0", VA = "0x1824D4AC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0018, IL_0029, IL_0031, IL_0039, IL_0072
			//IL_0010: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			if (fieldNumber - 1 <= 27)
			{
				int num = 0;
				spawnTypes_ = num;
				spawnTypesCase_ = (SpawnTypesOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D05")]
		[Cpp2IlInjected.Address(RVA = "0x24D6060", Offset = "0x24D4A60", VA = "0x1824D6060", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "SpawnTypes"))
			{
				SpawnTypesOneofCase spawnTypesOneofCase = spawnTypesCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D06")]
		[Cpp2IlInjected.Address(RVA = "0x24D4C90", Offset = "0x24D3690", VA = "0x1824D4C90", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "SpawnTypes"))
			{
				spawnTypes_ = (spawnTypesCase_ = SpawnTypesOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0B")]
		[Cpp2IlInjected.Address(RVA = "0x24D4D60", Offset = "0x24D3760", VA = "0x1824D4D60", Slot = "24")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_00b6: Expected O, but got I4
			//IL_01c9: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				StepAmount stepAmount = amountToSpawn_;
				int num = 0;
				if (stepAmount.IsValueSmallerThen(1))
				{
					string missionStepName = context.MissionStepName;
					string message = "Should be 1+ in " + missionStepName;
					context.AddInvalidMemberError(message, "AmountToSpawn");
				}
				ItemSelector itemSelector = ItemSelector;
				if (itemSelector != null && itemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.ItemList && (ItemSelector.ItemList.item_.ItemList.useAsFilter_ ? 1 : 0) != num)
				{
					context.AddError("ItemList option 'Keep all items as filter' is not supported in a spawn action");
				}
				if ((spawnAllItemsFromSameSource_ ? 1 : 0) == num)
				{
					if ((useDifferentSourceType_ ? 1 : 0) != num && Enumerable.ToList<LocationSource>((IEnumerable<>)(object)spawnLocationSourceList_) != null)
					{
						if ((spawnAllItemsFromSameSource_ ? 1 : 0) == num && (useDifferentSourceType_ ? 1 : 0) != num)
						{
							List<LocationSource> list = (List<LocationSource>)(object)Enumerable.ToList<LocationSource>((IEnumerable<>)(object)spawnLocationSourceList_);
						}
						if (!Enumerable.Any<LocationSource>((IEnumerable<>)num))
						{
							context.AddInvalidMemberError("Must contain at least one source", "SpawnLocationSourceList");
						}
					}
					if ((spawnAllItemsFromSameSource_ ? 1 : 0) == num)
					{
						goto IL_0100;
					}
				}
				if (amountToSpawn_.IsValueEqualTo(1) || spawnRadius_.IsValueSmallerThen(1))
				{
					context.AddInvalidMemberError("Should be disabled since AmountToSpawn is 1", "SpawnAllItemsFromSameSource");
				}
				goto IL_0100;
				IL_0100:
				if (!spawnRadius_.IsValueGreaterThen(40))
				{
					StepAmount stepAmount2 = spawnRadius_;
					int value = 0;
					if (!stepAmount2.IsValueSmallerThen(value))
					{
						goto IL_0152;
					}
					string missionStepName2 = context.MissionStepName;
				}
				string missionStepName3 = context.MissionStepName;
				string message2 = "Should be 40- in " + missionStepName3;
				context.AddInvalidMemberError(message2, "SpawnRadius");
				goto IL_0152;
				IL_0152:
				if (spawnRadius_.IsValueGreaterThen(5) && this.IsRadiusUseless())
				{
					context.AddInvalidMemberError("Radius is useless in this particular case. Please use 5 or less to avoid code issue.", "SpawnRadius");
				}
				ItemWithState itemWithState = rewardOverride_;
				if (itemWithState != null)
				{
					Item item = itemWithState.Item;
					if (flag)
					{
						if (spawnTypesCase_ == SpawnTypesOneofCase.FurnitureItem)
						{
							int itemID = rewardOverride_.Item.ItemID;
							if (!flag2)
							{
								SpawnTypesOneofCase spawnTypesOneofCase = spawnTypesCase_;
								string message3 = $"Is invalid with {spawnTypesOneofCase}";
								context.AddInvalidMemberError(message3, "RewardOverride");
							}
						}
						return;
					}
				}
				while (spawnTypesCase_ != SpawnTypesOneofCase.ConsummableItem)
				{
				}
				if (spawnTypes_ == null)
				{
					break;
				}
				if (ConsummableItem.Item.item_.Item != 0)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					int item2 = ConsummableItem.Item.item_.Item;
					while (!flag3)
					{
					}
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0C")]
		[Cpp2IlInjected.Address(RVA = "0x24D81D0", Offset = "0x24D6BD0", VA = "0x1824D81D0")]
		static ConditionalSpawnData()
		{
			Func<ConditionalSpawnData> func = default(Func<ConditionalSpawnData>);
			_parser = (MessageParser<ConditionalSpawnData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<LocationSource> parser = LocationSource._parser;
			uint num = default(uint);
			_parser = (MessageParser<ConditionalSpawnData>)(object)FieldCodec.ForMessage<LocationSource>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
