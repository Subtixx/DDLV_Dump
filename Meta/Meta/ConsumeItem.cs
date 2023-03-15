using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public sealed class ConsumeItem : IMessage<ConsumeItem>, IMessage, IEquatable<ConsumeItem>, IDeepCloneable<ConsumeItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000183")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400054E")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400054F")]
				[OriginalName("InvalidContainerInventoryID")]
				InvalidContainerInventoryId,
				[Cpp2IlInjected.Token(Token = "0x4000550")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000551")]
				[OriginalName("InventoryFull")]
				InventoryFull,
				[Cpp2IlInjected.Token(Token = "0x4000552")]
				[OriginalName("MemoryShardAlreadyCollected")]
				MemoryShardAlreadyCollected,
				[Cpp2IlInjected.Token(Token = "0x4000553")]
				[OriginalName("CraftingRecipeAlreadyUnlocked")]
				CraftingRecipeAlreadyUnlocked
			}

			[Cpp2IlInjected.Token(Token = "0x2000184")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000554")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000555")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000556")]
				public const int ContainerInventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000557")]
				private uint containerInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000558")]
				public const int InventoryPositionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000559")]
				private int inventoryPosition_;

				[Cpp2IlInjected.Token(Token = "0x170002E0")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001070")]
					[Cpp2IlInjected.Address(RVA = "0x1F07D50", Offset = "0x1F06750", VA = "0x181F07D50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001071")]
					[Cpp2IlInjected.Address(RVA = "0x1F07850", Offset = "0x1F06250", VA = "0x181F07850")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001072")]
					[Cpp2IlInjected.Address(RVA = "0x1F08230", Offset = "0x1F06C30", VA = "0x181F08230", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E3")]
				[DebuggerNonUserCode]
				public uint ContainerInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6001076")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001077")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E4")]
				[DebuggerNonUserCode]
				public int InventoryPosition
				{
					[Cpp2IlInjected.Token(Token = "0x6001078")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001079")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001073")]
				[Cpp2IlInjected.Address(RVA = "0x1F07590", Offset = "0x1F05F90", VA = "0x181F07590")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001074")]
				[Cpp2IlInjected.Address(RVA = "0x1F07080", Offset = "0x1F05A80", VA = "0x181F07080")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001075")]
				[Cpp2IlInjected.Address(RVA = "0x1F02D60", Offset = "0x1F01760", VA = "0x181F02D60", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600107A")]
				[Cpp2IlInjected.Address(RVA = "0x1F03310", Offset = "0x1F01D10", VA = "0x181F03310", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600107B")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600107C")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600107D")]
				[Cpp2IlInjected.Address(RVA = "0x1F04950", Offset = "0x1F03350", VA = "0x181F04950", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600107E")]
				[Cpp2IlInjected.Address(RVA = "0x15BC890", Offset = "0x15BB290", VA = "0x1815BC890", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600107F")]
				[Cpp2IlInjected.Address(RVA = "0x1F01B80", Offset = "0x1F00580", VA = "0x181F01B80", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001080")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001081")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001082")]
				[Cpp2IlInjected.Address(RVA = "0x1F039E0", Offset = "0x1F023E0", VA = "0x181F039E0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001083")]
				[Cpp2IlInjected.Address(RVA = "0x1F04270", Offset = "0x1F02C70", VA = "0x181F04270", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001084")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001085")]
				[Cpp2IlInjected.Address(RVA = "0x1F04CB0", Offset = "0x1F036B0", VA = "0x181F04CB0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000186")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400055B")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400055C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400055D")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400055E")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400055F")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000560")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170002E5")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600108A")]
					[Cpp2IlInjected.Address(RVA = "0x1F15D60", Offset = "0x1F14760", VA = "0x181F15D60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600108B")]
					[Cpp2IlInjected.Address(RVA = "0x1F15960", Offset = "0x1F14360", VA = "0x181F15960")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600108C")]
					[Cpp2IlInjected.Address(RVA = "0x1F160C0", Offset = "0x1F14AC0", VA = "0x181F160C0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E8")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001090")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001091")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002E9")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001092")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001093")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002EA")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600109F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60010A0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600108D")]
				[Cpp2IlInjected.Address(RVA = "0x1F14D00", Offset = "0x1F13700", VA = "0x181F14D00")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600108E")]
				[Cpp2IlInjected.Address(RVA = "0x1F15070", Offset = "0x1F13A70", VA = "0x181F15070")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600108F")]
				[Cpp2IlInjected.Address(RVA = "0x1F0F9D0", Offset = "0x1F0E3D0", VA = "0x181F0F9D0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001094")]
				[Cpp2IlInjected.Address(RVA = "0x1F103D0", Offset = "0x1F0EDD0", VA = "0x181F103D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001095")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001096")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001097")]
				[Cpp2IlInjected.Address(RVA = "0x1F135B0", Offset = "0x1F11FB0", VA = "0x181F135B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001098")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001099")]
				[Cpp2IlInjected.Address(RVA = "0x1F0ED10", Offset = "0x1F0D710", VA = "0x181F0ED10", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600109A")]
				[Cpp2IlInjected.Address(RVA = "0x1F12030", Offset = "0x1F10A30", VA = "0x181F12030", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600109B")]
				[Cpp2IlInjected.Address(RVA = "0x1F11F40", Offset = "0x1F10940", VA = "0x181F11F40", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600109C")]
				[Cpp2IlInjected.Address(RVA = "0x1F10D50", Offset = "0x1F0F750", VA = "0x181F10D50", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600109D")]
				[Cpp2IlInjected.Address(RVA = "0x1F12C20", Offset = "0x1F11620", VA = "0x181F12C20", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600109E")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60010A1")]
				[Cpp2IlInjected.Address(RVA = "0x1F087C0", Offset = "0x1F071C0", VA = "0x181F087C0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public const string GeneratorRandomName = "LootPresentGeneratorRandom";

			[Cpp2IlInjected.Token(Token = "0x600106E")]
			[Cpp2IlInjected.Address(RVA = "0x99C4B0", Offset = "0x99AEB0", VA = "0x18099C4B0")]
			public static bool GetLootPresentRewards(in PlayerProfile playerProfile, in WorldProfile worldProfile, Item item, ItemState state, Random random, out MultiItemInstance rewardItems, out MultiReward multiReward, out int boxIndex)
			{
				int num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				LootPresentItemData lootPresentItemData = default(LootPresentItemData);
				if (lootPresentItemData != null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
					int lootTableItemID = lootPresentItemData.LootTableItemID;
					LootTableItemData lootTableItemData = default(LootTableItemData);
					if (lootTableItemData != null || state != null)
					{
						goto IL_0026;
					}
				}
				int num2 = 0;
				goto IL_0026;
				IL_0026:
				if (false)
				{
				}
				MultiItemInstance multiItemInstance = new MultiItemInstance();
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600106F")]
			[Cpp2IlInjected.Address(RVA = "0x99C3B0", Offset = "0x99ADB0", VA = "0x18099C3B0")]
			private static bool CanAddItemsInBackpack(ProfilePlayer profilePlayer, uint inventoryID, int inventoryPosition, MultiItemInstance rewardItems)
			{
				//Discarded unreachable code: IL_002e
				//IL_002d: Expected O, but got I4
				//IL_002d: Expected O, but got I4
				ContainerInventory containerInventory = profilePlayer.Backpack.Clone();
				MultiItemInstance items = rewardItems.Clone();
				if (inventoryID == containerInventory.iD_)
				{
				}
				int num = 0;
				int num2 = 0;
				return containerInventory.TryToAddItems(items, (ProfileEventDispatcher)num2, (InventoryFullResolution)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private static readonly MessageParser<ConsumeItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		[DebuggerNonUserCode]
		public static MessageParser<ConsumeItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600105C")]
			[Cpp2IlInjected.Address(RVA = "0x168D710", Offset = "0x168C110", VA = "0x18168D710")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600105D")]
			[Cpp2IlInjected.Address(RVA = "0x168D640", Offset = "0x168C040", VA = "0x18168D640")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600105E")]
			[Cpp2IlInjected.Address(RVA = "0x168D770", Offset = "0x168C170", VA = "0x18168D770", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600105F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConsumeItem()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001060")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ConsumeItem(ConsumeItem other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001061")]
		[Cpp2IlInjected.Address(RVA = "0x168D360", Offset = "0x168BD60", VA = "0x18168D360", Slot = "10")]
		[DebuggerNonUserCode]
		public ConsumeItem Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ConsumeItem consumeItem = default(ConsumeItem);
			consumeItem.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (consumeItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return consumeItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6001062")]
		[Cpp2IlInjected.Address(RVA = "0x168D3E0", Offset = "0x168BDE0", VA = "0x18168D3E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001063")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConsumeItem other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001064")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001065")]
		[Cpp2IlInjected.Address(RVA = "0x168D4D0", Offset = "0x168BED0", VA = "0x18168D4D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001066")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001067")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001068")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConsumeItem other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001069")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600106A")]
		[Cpp2IlInjected.Address(RVA = "0x168D460", Offset = "0x168BE60", VA = "0x18168D460", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600106B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600106C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600106D")]
		[Cpp2IlInjected.Address(RVA = "0x168D530", Offset = "0x168BF30", VA = "0x18168D530")]
		static ConsumeItem()
		{
			Func<ConsumeItem> func = default(Func<ConsumeItem>);
			_parser = (MessageParser<ConsumeItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
