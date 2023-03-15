using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001071")]
	public sealed class GridState : IMessage<GridState>, IMessage, IEquatable<GridState>, IDeepCloneable<GridState>, IMessageFieldAccessor, IMessageOneofAccessor, IHasItemDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x2001072")]
		public enum StateOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40043C5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40043C6")]
			SubGrid,
			[Cpp2IlInjected.Token(Token = "0x40043C7")]
			ItemAmountState,
			[Cpp2IlInjected.Token(Token = "0x40043C8")]
			GardenData,
			[Cpp2IlInjected.Token(Token = "0x40043C9")]
			FlowerData,
			[Cpp2IlInjected.Token(Token = "0x40043CA")]
			HouseData,
			[Cpp2IlInjected.Token(Token = "0x40043CB")]
			StallData,
			[Cpp2IlInjected.Token(Token = "0x40043CC")]
			FishingStallData,
			[Cpp2IlInjected.Token(Token = "0x40043CD")]
			WeedData,
			[Cpp2IlInjected.Token(Token = "0x40043CE")]
			PictureFrameGridData,
			[Cpp2IlInjected.Token(Token = "0x40043CF")]
			GardenStallData,
			[Cpp2IlInjected.Token(Token = "0x40043D0")]
			Storage,
			[Cpp2IlInjected.Token(Token = "0x40043D1")]
			BlockerData,
			[Cpp2IlInjected.Token(Token = "0x40043D2")]
			Keyhole,
			[Cpp2IlInjected.Token(Token = "0x40043D3")]
			Toggle,
			[Cpp2IlInjected.Token(Token = "0x40043D4")]
			Index
		}

		[Cpp2IlInjected.Token(Token = "0x40043B0")]
		private static readonly MessageParser<GridState> _parser = (MessageParser<GridState>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new GridState()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40043B1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40043B2")]
		public const int SubGridFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40043B3")]
		public const int ItemAmountStateFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40043B4")]
		public const int GardenDataFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40043B5")]
		public const int FlowerDataFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40043B6")]
		public const int HouseDataFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40043B7")]
		public const int StallDataFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40043B8")]
		public const int FishingStallDataFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x40043B9")]
		public const int WeedDataFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x40043BA")]
		public const int PictureFrameGridDataFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x40043BB")]
		public const int GardenStallDataFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x40043BC")]
		public const int StorageFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x40043BD")]
		public const int BlockerDataFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x40043BE")]
		public const int KeyholeFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x40043BF")]
		public const int ToggleFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x40043C0")]
		public const int IndexFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40043C1")]
		private object state_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40043C2")]
		private StateOneofCase stateCase_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40043C3")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x17001718")]
		[DebuggerNonUserCode]
		public static MessageParser<GridState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008522")]
			[Cpp2IlInjected.Address(RVA = "0x1D16B60", Offset = "0x1D15560", VA = "0x181D16B60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001719")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008523")]
			[Cpp2IlInjected.Address(RVA = "0x1D162B0", Offset = "0x1D14CB0", VA = "0x181D162B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008524")]
			[Cpp2IlInjected.Address(RVA = "0x1D16E70", Offset = "0x1D15870", VA = "0x181D16E70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171B")]
		[DebuggerNonUserCode]
		public SubGrid SubGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6008528")]
			[Cpp2IlInjected.Address(RVA = "0x1D16D50", Offset = "0x1D15750", VA = "0x181D16D50")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.SubGrid)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008529")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				state_ = value;
				bool flag = (byte)(stateCase_ = ((value != null) ? StateOneofCase.SubGrid : StateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171C")]
		[DebuggerNonUserCode]
		public AmountWithState ItemAmountState
		{
			[Cpp2IlInjected.Token(Token = "0x600852A")]
			[Cpp2IlInjected.Address(RVA = "0x1D16640", Offset = "0x1D15040", VA = "0x181D16640")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.ItemAmountState)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600852B")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171D")]
		[DebuggerNonUserCode]
		public GardenData GardenData
		{
			[Cpp2IlInjected.Token(Token = "0x600852C")]
			[Cpp2IlInjected.Address(RVA = "0x1D164C0", Offset = "0x1D14EC0", VA = "0x181D164C0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.GardenData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600852D")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171E")]
		[DebuggerNonUserCode]
		public FlowerData FlowerData
		{
			[Cpp2IlInjected.Token(Token = "0x600852E")]
			[Cpp2IlInjected.Address(RVA = "0x1D16460", Offset = "0x1D14E60", VA = "0x181D16460")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.FlowerData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600852F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171F")]
		[DebuggerNonUserCode]
		public HouseData HouseData
		{
			[Cpp2IlInjected.Token(Token = "0x6008530")]
			[Cpp2IlInjected.Address(RVA = "0x1D16580", Offset = "0x1D14F80", VA = "0x181D16580")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.HouseData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008531")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001720")]
		[DebuggerNonUserCode]
		public StallData StallData
		{
			[Cpp2IlInjected.Token(Token = "0x6008532")]
			[Cpp2IlInjected.Address(RVA = "0x1D16C20", Offset = "0x1D15620", VA = "0x181D16C20")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.StallData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008533")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001721")]
		[DebuggerNonUserCode]
		public FishingStallData FishingStallData
		{
			[Cpp2IlInjected.Token(Token = "0x6008534")]
			[Cpp2IlInjected.Address(RVA = "0x1D16400", Offset = "0x1D14E00", VA = "0x181D16400")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.FishingStallData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008535")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E10", Offset = "0x5C4810", VA = "0x1805C5E10")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001722")]
		[DebuggerNonUserCode]
		public WeedData WeedData
		{
			[Cpp2IlInjected.Token(Token = "0x6008536")]
			[Cpp2IlInjected.Address(RVA = "0x1D16E10", Offset = "0x1D15810", VA = "0x181D16E10")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.WeedData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008537")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E50", Offset = "0x5C4850", VA = "0x1805C5E50")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001723")]
		[DebuggerNonUserCode]
		public PictureFrameGridData PictureFrameGridData
		{
			[Cpp2IlInjected.Token(Token = "0x6008538")]
			[Cpp2IlInjected.Address(RVA = "0x1D16BC0", Offset = "0x1D155C0", VA = "0x181D16BC0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.PictureFrameGridData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008539")]
			[Cpp2IlInjected.Address(RVA = "0x1D17080", Offset = "0x1D15A80", VA = "0x181D17080")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001724")]
		[DebuggerNonUserCode]
		public GardenStallData GardenStallData
		{
			[Cpp2IlInjected.Token(Token = "0x600853A")]
			[Cpp2IlInjected.Address(RVA = "0x1D16520", Offset = "0x1D14F20", VA = "0x181D16520")]
			get
			{
				if (stateCase_ == StateOneofCase.GardenStallData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600853B")]
			[Cpp2IlInjected.Address(RVA = "0x1D16FC0", Offset = "0x1D159C0", VA = "0x181D16FC0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001725")]
		[DebuggerNonUserCode]
		public StorageGridData Storage
		{
			[Cpp2IlInjected.Token(Token = "0x600853C")]
			[Cpp2IlInjected.Address(RVA = "0x1D16CF0", Offset = "0x1D156F0", VA = "0x181D16CF0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.Storage)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600853D")]
			[Cpp2IlInjected.Address(RVA = "0x1D174F0", Offset = "0x1D15EF0", VA = "0x181D174F0")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001726")]
		[DebuggerNonUserCode]
		public BlockerData BlockerData
		{
			[Cpp2IlInjected.Token(Token = "0x600853E")]
			[Cpp2IlInjected.Address(RVA = "0x1D16250", Offset = "0x1D14C50", VA = "0x181D16250")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.BlockerData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600853F")]
			[Cpp2IlInjected.Address(RVA = "0x1D16F80", Offset = "0x1D15980", VA = "0x181D16F80")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001727")]
		[DebuggerNonUserCode]
		public KeyholeGridData Keyhole
		{
			[Cpp2IlInjected.Token(Token = "0x6008540")]
			[Cpp2IlInjected.Address(RVA = "0x1D16B00", Offset = "0x1D15500", VA = "0x181D16B00")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.Keyhole)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008541")]
			[Cpp2IlInjected.Address(RVA = "0x1D17040", Offset = "0x1D15A40", VA = "0x181D17040")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001728")]
		[DebuggerNonUserCode]
		public ToggleGridData Toggle
		{
			[Cpp2IlInjected.Token(Token = "0x6008542")]
			[Cpp2IlInjected.Address(RVA = "0x1D16DB0", Offset = "0x1D157B0", VA = "0x181D16DB0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.Toggle)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008543")]
			[Cpp2IlInjected.Address(RVA = "0x1D17530", Offset = "0x1D15F30", VA = "0x181D17530")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001729")]
		[DebuggerNonUserCode]
		public IndexGridData Index
		{
			[Cpp2IlInjected.Token(Token = "0x6008544")]
			[Cpp2IlInjected.Address(RVA = "0x1D165E0", Offset = "0x1D14FE0", VA = "0x181D165E0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.Index)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008545")]
			[Cpp2IlInjected.Address(RVA = "0x1D17000", Offset = "0x1D15A00", VA = "0x181D17000")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172A")]
		[DebuggerNonUserCode]
		public StateOneofCase StateCase
		{
			[Cpp2IlInjected.Token(Token = "0x6008546")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return stateCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172B")]
		public IGridStateData StateData
		{
			[Cpp2IlInjected.Token(Token = "0x6008555")]
			[Cpp2IlInjected.Address(RVA = "0x1D16C80", Offset = "0x1D15680", VA = "0x181D16C80")]
			get
			{
				if (state_ == null)
				{
					int num = 0;
				}
				while ((object)typeof(IGridStateData).TypeHandle != null)
				{
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008556")]
			[Cpp2IlInjected.Address(RVA = "0x1D170C0", Offset = "0x1D15AC0", VA = "0x181D170C0")]
			set
			{
				//IL_001d: Expected I4, but got I8
				//IL_0032: Expected I4, but got I8
				//IL_00d6: Expected O, but got I4
				int num = 0;
				if (value != null)
				{
					if (value != null)
					{
						state_ = value;
						stateCase_ = StateOneofCase.SubGrid;
						return;
					}
					if (value != null)
					{
						state_ = value;
						stateCase_ = StateOneofCase.ItemAmountState;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
					if (value != null)
					{
						state_ = value;
						return;
					}
				}
				else
				{
					state_ = num;
					stateCase_ = (StateOneofCase)num;
				}
				ArgumentException ex = new ArgumentException("Unknown type, please add a case");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172C")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6008557")]
			[Cpp2IlInjected.Address(RVA = "0x1D16380", Offset = "0x1D14D80", VA = "0x181D16380", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0010
				//IL_000e: Expected O, but got I4
				List<ItemType> list = (List<ItemType>)(object)new List<T>();
				((List<T>)(object)list).Add((T)5);
				return list;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172D")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6008558")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "17")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172E")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6008559")]
			[Cpp2IlInjected.Address(RVA = "0x1D166A0", Offset = "0x1D150A0", VA = "0x181D166A0", Slot = "18")]
			get
			{
				BlockerData blockerData = default(BlockerData);
				MultiItemInstance multiItemInstance = default(MultiItemInstance);
				while (true)
				{
					if ((long)itemDependencies == 0)
					{
						List<Item> list = (itemDependencies = (List<Item>)(object)new List<T>());
						if (stateCase_ != StateOneofCase.ItemAmountState)
						{
							while ((long)typeof(_003C_003Ec).TypeHandle != 12)
							{
							}
							if ((long)BlockerData.treasure_ == 0)
							{
								continue;
							}
							ItemWithState treasure_ = BlockerData.treasure_;
							int num = 0;
							if ((IntPtr)treasure_.state_ == (IntPtr)num)
							{
								Item item = BlockerData.treasure_.Item;
								int itemID = BlockerData.treasure_.Item.ItemID;
							}
							if (blockerData.treasure_.state_.LootPresentData == null)
							{
								continue;
							}
							MultiItemInstance lootPresentData = BlockerData.treasure_.state_.LootPresentData;
							if (_003C_003Ec._003C_003E9__100_1 == null)
							{
								Func<ItemInstance, Item> func = (Func<ItemInstance, Item>)(object)(Func<T, TResult>)((ItemInstance x) => x.Item);
								throw new NullReferenceException();
							}
							continue;
						}
						StateOneofCase stateOneofCase = stateCase_;
						object obj = state_;
						if (obj == null)
						{
							break;
						}
						if (obj != null && multiItemInstance != null)
						{
							RepeatedField<ItemInstance> items_ = ItemAmountState.state_.LootPresentData.items_;
							Func<ItemInstance, Item> _003C_003E9__100_ = _003C_003Ec._003C_003E9__100_0;
							if (_003C_003E9__100_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemInstance x) => x.Item);
							}
							IEnumerable<ItemInstance> enumerable = (IEnumerable<ItemInstance>)Enumerable.Select<ItemInstance, Item>((IEnumerable<>)(object)items_, (Func<, >)(object)_003C_003E9__100_);
						}
					}
					return (List<Item>)typeof(_003C_003Ec).TypeHandle;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008525")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GridState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008526")]
		[Cpp2IlInjected.Address(RVA = "0x1D15E20", Offset = "0x1D14820", VA = "0x181D15E20")]
		[DebuggerNonUserCode]
		public GridState(GridState other)
		{
			//IL_015f: Expected I4, but got O
			if (other.stateCase_ <= StateOneofCase.Toggle)
			{
				bool flag = (byte)(stateCase_ = (((state_ = other.SubGrid.Clone()) != null) ? StateOneofCase.SubGrid : StateOneofCase.None)) != 0;
				AmountWithState amountWithState = (AmountWithState)(state_ = other.ItemAmountState.Clone());
				GardenData gardenData = (GardenData)(state_ = other.GardenData.Clone());
				FlowerData flowerData = (FlowerData)(state_ = other.FlowerData.Clone());
				HouseData houseData = (HouseData)(state_ = other.HouseData.Clone());
				StallData stallData = (StallData)(state_ = other.StallData.Clone());
				FishingStallData fishingStallData = (FishingStallData)(state_ = other.FishingStallData.Clone());
				WeedData weedData = (WeedData)(state_ = other.WeedData.Clone());
				PictureFrameGridData pictureFrameGridData = (PictureFrameGridData)(state_ = other.PictureFrameGridData.Clone());
				GardenStallData gardenStallData = (GardenStallData)(state_ = other.GardenStallData.Clone());
				StorageGridData storageGridData = (StorageGridData)(state_ = other.Storage.Clone());
				BlockerData blockerData = (BlockerData)(state_ = other.BlockerData.Clone());
				KeyholeGridData keyholeGridData = (KeyholeGridData)(state_ = other.Keyhole.Clone());
				ToggleGridData toggleGridData = (ToggleGridData)(state_ = other.Toggle.Clone());
				stateCase_ = (StateOneofCase)(state_ = other.Index.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008527")]
		[Cpp2IlInjected.Address(RVA = "0x1D12B30", Offset = "0x1D11530", VA = "0x181D12B30", Slot = "10")]
		[DebuggerNonUserCode]
		public GridState Clone()
		{
			return new GridState(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008547")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearState()
		{
			//IL_0010: Expected O, but got I4
			state_ = (stateCase_ = StateOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008548")]
		[Cpp2IlInjected.Address(RVA = "0x1D12B90", Offset = "0x1D11590", VA = "0x181D12B90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((GridState)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6008549")]
		[Cpp2IlInjected.Address(RVA = "0x1D12BF0", Offset = "0x1D115F0", VA = "0x181D12BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridState other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.SubGrid)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
						goto IL_022c;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.stateCase_ == StateOneofCase.SubGrid)
				{
					obj2 = other.state_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					AmountWithState itemAmountState = ItemAmountState;
					AmountWithState itemAmountState2 = other.ItemAmountState;
					if (object.Equals(itemAmountState, itemAmountState2))
					{
						GardenData gardenData = GardenData;
						GardenData gardenData2 = other.GardenData;
						if (object.Equals(gardenData, gardenData2))
						{
							FlowerData flowerData = FlowerData;
							FlowerData flowerData2 = other.FlowerData;
							if (object.Equals(flowerData, flowerData2))
							{
								HouseData houseData = HouseData;
								HouseData houseData2 = other.HouseData;
								if (object.Equals(houseData, houseData2))
								{
									StallData stallData = StallData;
									StallData stallData2 = other.StallData;
									if (object.Equals(stallData, stallData2))
									{
										FishingStallData fishingStallData = FishingStallData;
										FishingStallData fishingStallData2 = other.FishingStallData;
										if (object.Equals(fishingStallData, fishingStallData2))
										{
											WeedData weedData = WeedData;
											WeedData weedData2 = other.WeedData;
											if (object.Equals(weedData, weedData2))
											{
												PictureFrameGridData pictureFrameGridData = PictureFrameGridData;
												PictureFrameGridData pictureFrameGridData2 = other.PictureFrameGridData;
												if (object.Equals(pictureFrameGridData, pictureFrameGridData2))
												{
													GardenStallData gardenStallData = GardenStallData;
													GardenStallData gardenStallData2 = other.GardenStallData;
													if (object.Equals(gardenStallData, gardenStallData2))
													{
														StorageGridData storage = Storage;
														StorageGridData storage2 = other.Storage;
														if (object.Equals(storage, storage2))
														{
															BlockerData blockerData = BlockerData;
															BlockerData blockerData2 = other.BlockerData;
															if (object.Equals(blockerData, blockerData2))
															{
																KeyholeGridData keyhole = Keyhole;
																KeyholeGridData keyhole2 = other.Keyhole;
																if (object.Equals(keyhole, keyhole2))
																{
																	ToggleGridData toggle = Toggle;
																	ToggleGridData toggle2 = other.Toggle;
																	if (object.Equals(toggle, toggle2))
																	{
																		IndexGridData index = Index;
																		IndexGridData index2 = other.Index;
																		if (object.Equals(index, index2))
																		{
																			StateOneofCase stateOneofCase = other.stateCase_;
																			if (stateCase_ == stateOneofCase)
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
			int num2 = 0;
			goto IL_022c;
			IL_022c:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600854A")]
		[Cpp2IlInjected.Address(RVA = "0x1D130F0", Offset = "0x1D11AF0", VA = "0x181D130F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0233
			while (true)
			{
				StateOneofCase stateOneofCase = stateCase_;
				int num = 0;
				if (stateOneofCase == StateOneofCase.SubGrid)
				{
					object obj = state_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (stateOneofCase != StateOneofCase.ItemAmountState)
				{
					continue;
				}
				object obj2 = state_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (stateCase_ != StateOneofCase.GardenData)
					{
						continue;
					}
					object obj3 = state_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (stateCase_ != StateOneofCase.FlowerData)
						{
							continue;
						}
						object obj4 = state_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (stateCase_ != StateOneofCase.HouseData)
							{
								continue;
							}
							object obj5 = state_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (stateCase_ != StateOneofCase.StallData)
								{
									continue;
								}
								object obj6 = state_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (stateCase_ != StateOneofCase.FishingStallData)
									{
										continue;
									}
									object obj7 = state_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (stateCase_ != StateOneofCase.WeedData)
										{
											continue;
										}
										object obj8 = state_;
										if (obj8 != null)
										{
											int hashCode8 = obj8.GetHashCode();
											if (stateCase_ != StateOneofCase.PictureFrameGridData)
											{
												continue;
											}
											object obj9 = state_;
											if (obj9 != null)
											{
												int hashCode9 = obj9.GetHashCode();
												if (stateCase_ != StateOneofCase.GardenStallData)
												{
													continue;
												}
												object obj10 = state_;
												if (obj10 != null)
												{
													int hashCode10 = obj10.GetHashCode();
													if (stateCase_ != StateOneofCase.Storage)
													{
														continue;
													}
													object obj11 = state_;
													if (obj11 != null)
													{
														int hashCode11 = obj11.GetHashCode();
														if (stateCase_ != StateOneofCase.BlockerData)
														{
															continue;
														}
														object obj12 = state_;
														if (obj12 != null)
														{
															int hashCode12 = obj12.GetHashCode();
															if (stateCase_ != StateOneofCase.Keyhole)
															{
																continue;
															}
															object obj13 = state_;
															if (obj13 != null)
															{
																int hashCode13 = obj13.GetHashCode();
																if (stateCase_ != StateOneofCase.Toggle)
																{
																	continue;
																}
																object obj14 = state_;
																if (obj14 != null)
																{
																	int hashCode14 = obj14.GetHashCode();
																	if (stateCase_ == StateOneofCase.Index)
																	{
																		object obj15 = state_;
																		if (obj15 == null)
																		{
																			break;
																		}
																		int hashCode15 = obj15.GetHashCode();
																	}
																	UnknownFieldSet unknownFields = _unknownFields;
																	if (unknownFields != null)
																	{
																		int hashCode16 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x600854B")]
		[Cpp2IlInjected.Address(RVA = "0x1D15440", Offset = "0x1D13E40", VA = "0x181D15440", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600854C")]
		[Cpp2IlInjected.Address(RVA = "0x1D155E0", Offset = "0x1D13FE0", VA = "0x181D155E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_028b
			//IL_002f: Expected O, but got I4
			while (true)
			{
				StateOneofCase stateOneofCase = stateCase_;
				int num = 0;
				if (stateOneofCase == StateOneofCase.SubGrid)
				{
					if (stateCase_ == StateOneofCase.SubGrid)
					{
						object obj = state_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (stateOneofCase != StateOneofCase.ItemAmountState)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.ItemAmountState)
				{
					object obj2 = state_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.GardenData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.GardenData)
				{
					object obj3 = state_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.FlowerData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.FlowerData)
				{
					object obj4 = state_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.HouseData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.HouseData)
				{
					object obj5 = state_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.StallData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.StallData)
				{
					object obj6 = state_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.FishingStallData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.FishingStallData)
				{
					object obj7 = state_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.WeedData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.WeedData)
				{
					object obj8 = state_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.PictureFrameGridData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.PictureFrameGridData)
				{
					object obj9 = state_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.GardenStallData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.GardenStallData)
				{
					object obj10 = state_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.Storage)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.Storage)
				{
					object obj11 = state_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.BlockerData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.BlockerData)
				{
					object obj12 = state_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ != StateOneofCase.Keyhole)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.Keyhole)
				{
					object obj13 = state_;
					if (obj13 != null && obj13 == null)
					{
						break;
					}
				}
				if (stateCase_ != StateOneofCase.Toggle)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.Toggle)
				{
					object obj14 = state_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ == StateOneofCase.Index && stateCase_ == StateOneofCase.Index)
				{
					object obj15 = state_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600854D")]
		[Cpp2IlInjected.Address(RVA = "0x1D12250", Offset = "0x1D10C50", VA = "0x181D12250", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (stateCase_ == StateOneofCase.SubGrid)
			{
				if (stateCase_ == StateOneofCase.SubGrid)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (stateCase_ == StateOneofCase.ItemAmountState)
			{
				if (stateCase_ != StateOneofCase.ItemAmountState)
				{
				}
				object obj2 = state_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (stateCase_ == StateOneofCase.GardenData)
			{
				if (stateCase_ != StateOneofCase.GardenData)
				{
				}
				object obj3 = state_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (stateCase_ == StateOneofCase.FlowerData)
			{
				if (stateCase_ != StateOneofCase.FlowerData)
				{
				}
				object obj4 = state_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (stateCase_ == StateOneofCase.HouseData)
			{
				if (stateCase_ != StateOneofCase.HouseData)
				{
				}
				object obj5 = state_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (stateCase_ == StateOneofCase.StallData)
			{
				if (stateCase_ != StateOneofCase.StallData)
				{
				}
				object obj6 = state_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (stateCase_ == StateOneofCase.FishingStallData)
			{
				if (stateCase_ != StateOneofCase.FishingStallData)
				{
				}
				object obj7 = state_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			if (stateCase_ == StateOneofCase.WeedData)
			{
				if (stateCase_ != StateOneofCase.WeedData)
				{
				}
				object obj8 = state_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num9 = default(int);
				num += num9;
			}
			if (stateCase_ == StateOneofCase.PictureFrameGridData)
			{
				if (stateCase_ != StateOneofCase.PictureFrameGridData)
				{
				}
				object obj9 = state_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num10 = default(int);
				num += num10;
			}
			if (stateCase_ == StateOneofCase.GardenStallData)
			{
				if (stateCase_ != StateOneofCase.GardenStallData)
				{
				}
				object obj10 = state_;
				if (obj10 != null && obj10 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num11 = default(int);
				num += num11;
			}
			if (stateCase_ == StateOneofCase.Storage)
			{
				if (stateCase_ != StateOneofCase.Storage)
				{
				}
				object obj11 = state_;
				if (obj11 != null && obj11 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num12 = default(int);
				num += num12;
			}
			if (stateCase_ == StateOneofCase.BlockerData)
			{
				if (stateCase_ != StateOneofCase.BlockerData)
				{
				}
				object obj12 = state_;
				if (obj12 != null && obj12 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num13 = default(int);
				num += num13;
			}
			if (stateCase_ == StateOneofCase.Keyhole)
			{
				if (stateCase_ != StateOneofCase.Keyhole)
				{
				}
				object obj13 = state_;
				if (obj13 != null && obj13 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num14 = default(int);
				num += num14;
			}
			if (stateCase_ == StateOneofCase.Toggle)
			{
				if (stateCase_ != StateOneofCase.Toggle)
				{
				}
				object obj14 = state_;
				if (obj14 != null && obj14 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num15 = default(int);
				num += num15;
			}
			if (stateCase_ == StateOneofCase.Index)
			{
				if (stateCase_ == StateOneofCase.Index)
				{
					object obj15 = state_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num16 = default(int);
				num += num16;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
				num += num17;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600854E")]
		[Cpp2IlInjected.Address(RVA = "0x1D145F0", Offset = "0x1D12FF0", VA = "0x181D145F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridState other)
		{
			//Discarded unreachable code: IL_0068, IL_0071, IL_0088, IL_009e, IL_00b5, IL_00cb, IL_00e2, IL_00f8, IL_010f, IL_0125, IL_013c, IL_0152, IL_0169, IL_017f, IL_0196, IL_01ac, IL_01c3, IL_01d9, IL_01f0, IL_0206, IL_021d, IL_0233, IL_024a, IL_0260, IL_0277, IL_028d, IL_02a4, IL_02ba, IL_02d1
			//IL_0088: Expected I4, but got O
			//IL_00b5: Expected I4, but got O
			//IL_00e2: Expected I4, but got O
			//IL_010f: Expected I4, but got O
			//IL_013c: Expected I4, but got O
			//IL_0169: Expected I4, but got O
			//IL_0196: Expected I4, but got O
			//IL_01c3: Expected I4, but got O
			//IL_01f0: Expected I4, but got O
			//IL_021d: Expected I4, but got O
			//IL_024a: Expected I4, but got O
			//IL_0277: Expected I4, but got O
			//IL_02a4: Expected I4, but got O
			//IL_02d1: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.stateCase_ <= StateOneofCase.Toggle)
			{
				if (SubGrid == null)
				{
					bool flag = (byte)(stateCase_ = (((state_ = new SubGrid()) != null) ? StateOneofCase.SubGrid : StateOneofCase.None)) != 0;
				}
				SubGrid subGrid = SubGrid;
				SubGrid subGrid2 = other.SubGrid;
				subGrid.MergeFrom(subGrid2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600854F")]
		[Cpp2IlInjected.Address(RVA = "0x1D139A0", Offset = "0x1D123A0", VA = "0x181D139A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0071: Expected I4, but got O
			//IL_00c2: Expected I4, but got O
			//IL_0113: Expected I4, but got O
			//IL_016c: Expected I4, but got O
			//IL_01c6: Expected I4, but got O
			//IL_021f: Expected I4, but got O
			//IL_0273: Expected I4, but got O
			//IL_02cc: Expected I4, but got O
			//IL_032d: Expected I4, but got O
			//IL_0384: Expected I4, but got O
			//IL_03d8: Expected I4, but got O
			//IL_042f: Expected I4, but got O
			//IL_04d8: Expected I4, but got O
			//IL_052c: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 90)
				{
					if ((int)num > 106)
					{
						if (num == 114)
						{
							ToggleGridData toggleGridData = new ToggleGridData();
							if (stateCase_ == StateOneofCase.Toggle)
							{
								if (stateCase_ != StateOneofCase.Toggle)
								{
								}
								object obj = state_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(toggleGridData);
							state_ = toggleGridData;
							stateCase_ = (StateOneofCase)toggleGridData;
						}
						if (num != 122)
						{
							goto IL_052c;
						}
						IndexGridData builder = new IndexGridData();
						if (stateCase_ == StateOneofCase.Index)
						{
							if (stateCase_ != StateOneofCase.Index)
							{
							}
							object obj2 = state_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						state_ = builder;
						stateCase_ = (StateOneofCase)typeof(IndexGridData).TypeHandle;
					}
					if (num == 98)
					{
						BlockerData builder2 = new BlockerData();
						if (stateCase_ == StateOneofCase.BlockerData)
						{
							if (stateCase_ != StateOneofCase.BlockerData)
							{
							}
							object obj3 = state_;
							if (obj3 != null && obj3 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder2);
						state_ = builder2;
						stateCase_ = (StateOneofCase)typeof(BlockerData).TypeHandle;
					}
					if ((long)typeof(BlockerData).TypeHandle != 106)
					{
						goto IL_052c;
					}
					KeyholeGridData builder3 = new KeyholeGridData();
					if (stateCase_ == StateOneofCase.Keyhole)
					{
						if (stateCase_ != StateOneofCase.Keyhole)
						{
						}
						object obj4 = state_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					state_ = builder3;
					stateCase_ = (StateOneofCase)typeof(KeyholeGridData).TypeHandle;
				}
				if ((int)num > 74)
				{
					if (num == 82)
					{
						GardenStallData builder4 = new GardenStallData();
						if (stateCase_ == StateOneofCase.GardenStallData)
						{
							if (stateCase_ != StateOneofCase.GardenStallData)
							{
							}
							object obj5 = state_;
							if (obj5 != null && obj5 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder4);
						state_ = builder4;
						stateCase_ = (StateOneofCase)typeof(GardenStallData).TypeHandle;
					}
					if ((long)typeof(GardenStallData).TypeHandle != 90)
					{
						goto IL_052c;
					}
					StorageGridData builder5 = new StorageGridData();
					if (stateCase_ == StateOneofCase.Storage)
					{
						if (stateCase_ != StateOneofCase.Storage)
						{
						}
						object obj6 = state_;
						if (obj6 != null && obj6 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder5);
					state_ = builder5;
					stateCase_ = (StateOneofCase)typeof(StorageGridData).TypeHandle;
				}
				if ((long)typeof(StorageGridData).TypeHandle == 66)
				{
					WeedData builder6 = new WeedData();
					if (stateCase_ == StateOneofCase.WeedData)
					{
						if (stateCase_ != StateOneofCase.WeedData)
						{
						}
						object obj7 = state_;
						if (obj7 != null && obj7 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder6);
					state_ = builder6;
					stateCase_ = (StateOneofCase)typeof(WeedData).TypeHandle;
				}
				if ((long)typeof(WeedData).TypeHandle != 74)
				{
					goto IL_052c;
				}
				PictureFrameGridData builder7 = new PictureFrameGridData();
				if (stateCase_ == StateOneofCase.PictureFrameGridData)
				{
					if (stateCase_ != StateOneofCase.PictureFrameGridData)
					{
					}
					object obj8 = state_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder7);
				state_ = builder7;
				stateCase_ = (StateOneofCase)typeof(PictureFrameGridData).TypeHandle;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 50)
					{
						StallData builder8 = new StallData();
						if (stateCase_ == StateOneofCase.StallData)
						{
							if (stateCase_ != StateOneofCase.StallData)
							{
							}
							object obj9 = state_;
							if (obj9 != null && obj9 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder8);
						state_ = builder8;
						stateCase_ = (StateOneofCase)typeof(StallData).TypeHandle;
					}
					if ((long)typeof(StallData).TypeHandle != 58)
					{
						goto IL_052c;
					}
					FishingStallData builder9 = new FishingStallData();
					if (stateCase_ == StateOneofCase.FishingStallData)
					{
						if (stateCase_ != StateOneofCase.FishingStallData)
						{
						}
						object obj10 = state_;
						if (obj10 != null && obj10 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder9);
					state_ = builder9;
					stateCase_ = (StateOneofCase)typeof(FishingStallData).TypeHandle;
				}
				if ((long)typeof(FishingStallData).TypeHandle == 34)
				{
					FlowerData builder10 = new FlowerData();
					if (stateCase_ == StateOneofCase.FlowerData)
					{
						if (stateCase_ != StateOneofCase.FlowerData)
						{
						}
						object obj11 = state_;
						if (obj11 != null && obj11 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder10);
					state_ = builder10;
					stateCase_ = (StateOneofCase)typeof(FlowerData).TypeHandle;
				}
				if ((long)typeof(FlowerData).TypeHandle != 42)
				{
					goto IL_052c;
				}
				HouseData builder11 = new HouseData();
				if (stateCase_ == StateOneofCase.HouseData)
				{
					if (stateCase_ != StateOneofCase.HouseData)
					{
					}
					object obj12 = state_;
					if (obj12 != null && obj12 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder11);
				state_ = builder11;
				stateCase_ = (StateOneofCase)typeof(HouseData).TypeHandle;
			}
			bool flag = default(bool);
			if ((long)typeof(HouseData).TypeHandle == 10)
			{
				SubGrid subGrid = new SubGrid();
				if (stateCase_ == StateOneofCase.SubGrid)
				{
					if (stateCase_ != StateOneofCase.SubGrid)
					{
					}
					object obj13 = state_;
					if (obj13 != null && obj13 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(subGrid);
				state_ = subGrid;
				flag = (byte)(stateCase_ = ((subGrid != null) ? StateOneofCase.SubGrid : StateOneofCase.None)) != 0;
			}
			if (flag)
			{
				AmountWithState builder12 = new AmountWithState();
				if (stateCase_ == StateOneofCase.ItemAmountState)
				{
					if (stateCase_ != StateOneofCase.ItemAmountState)
					{
					}
					object obj14 = state_;
					if (obj14 != null && obj14 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder12);
				state_ = builder12;
				stateCase_ = (StateOneofCase)typeof(AmountWithState).TypeHandle;
			}
			if ((long)typeof(AmountWithState).TypeHandle == 26)
			{
				GardenData builder13 = new GardenData();
				if (stateCase_ == StateOneofCase.GardenData)
				{
					if (stateCase_ != StateOneofCase.GardenData)
					{
					}
					object obj15 = state_;
					if (obj15 != null && obj15 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder13);
				state_ = builder13;
				stateCase_ = (StateOneofCase)typeof(GardenData).TypeHandle;
			}
			goto IL_052c;
			IL_052c:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008550")]
		[Cpp2IlInjected.Address(RVA = "0x1D12F70", Offset = "0x1D11970", VA = "0x181D12F70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 14)
			{
				SubGrid subGrid = SubGrid;
				AmountWithState itemAmountState = ItemAmountState;
				GardenData gardenData = GardenData;
				FlowerData flowerData = FlowerData;
				HouseData houseData = HouseData;
				StallData stallData = StallData;
				FishingStallData fishingStallData = FishingStallData;
				WeedData weedData = WeedData;
				PictureFrameGridData pictureFrameGridData = PictureFrameGridData;
				GardenStallData gardenStallData = GardenStallData;
				StorageGridData storage = Storage;
				BlockerData blockerData = BlockerData;
				KeyholeGridData keyhole = Keyhole;
				ToggleGridData toggle = Toggle;
				IndexGridData index = Index;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008551")]
		[Cpp2IlInjected.Address(RVA = "0x1D14E40", Offset = "0x1D13840", VA = "0x181D14E40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002b, IL_002f, IL_0036, IL_0037, IL_003b, IL_0042, IL_0043, IL_0047, IL_004e, IL_004f, IL_0053, IL_005a, IL_005b, IL_005f, IL_0066, IL_0067, IL_006b, IL_0072, IL_0073, IL_0077, IL_007e, IL_007f, IL_0083, IL_008a, IL_008b, IL_008f, IL_0096, IL_0097, IL_009b, IL_009f, IL_00a0, IL_00a4, IL_00a8, IL_00a9, IL_00ad, IL_00b1, IL_00b2, IL_00b6, IL_00ba, IL_00bb, IL_00bf, IL_00c3, IL_00c4, IL_00d0, IL_00d6, IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106, IL_010c, IL_0112, IL_0118
			//IL_001b: Expected O, but got I4
			if (fieldNumber - 1 <= 14)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				state_ = num;
				bool flag = (byte)(stateCase_ = ((num != 0) ? StateOneofCase.SubGrid : StateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008552")]
		[Cpp2IlInjected.Address(RVA = "0x1D12A30", Offset = "0x1D11430", VA = "0x181D12A30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000e: Expected O, but got I4
			if (fieldNumber <= 14)
			{
				int num = 0;
				state_ = num;
				stateCase_ = (StateOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008553")]
		[Cpp2IlInjected.Address(RVA = "0x1D137D0", Offset = "0x1D121D0", VA = "0x181D137D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "State"))
			{
				StateOneofCase stateOneofCase = stateCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008554")]
		[Cpp2IlInjected.Address(RVA = "0x1D12AC0", Offset = "0x1D114C0", VA = "0x181D12AC0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "State"))
			{
				state_ = (stateCase_ = StateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600855A")]
		[Cpp2IlInjected.Address(RVA = "0x1D13880", Offset = "0x1D12280", VA = "0x181D13880")]
		public UpgradeState GetUpgradeState()
		{
			object obj = state_;
			int num = 0;
			if (obj == null)
			{
			}
			if ((object)typeof(IGridStateData).TypeHandle != null && (object)typeof(IGridStateData).TypeHandle != null)
			{
				if ((long)num < (long)(IntPtr)typeof(IGridUpgradeStateData).TypeHandle)
				{
					num += num;
					num++;
				}
				num += 312;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600855B")]
		[Cpp2IlInjected.Address(RVA = "0x1D154A0", Offset = "0x1D13EA0", VA = "0x181D154A0")]
		public bool TryGetUpgradeLevel(out int level)
		{
			object obj = state_;
			int num = 0;
			if (obj == null)
			{
			}
			if ((object)typeof(IGridStateData).TypeHandle != null)
			{
				if ((object)typeof(IGridStateData).TypeHandle != null)
				{
					num += num;
					num++;
					if (num != 0)
					{
						num += 312;
					}
				}
				level.m_value = num;
				return num != 0;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600855C")]
		[Cpp2IlInjected.Address(RVA = "0x1D15D10", Offset = "0x1D14710", VA = "0x181D15D10")]
		static GridState()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
