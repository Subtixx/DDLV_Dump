using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200027C")]
	public sealed class ItemState : IMessage<ItemState>, IMessage, IEquatable<ItemState>, IDeepCloneable<ItemState>, IMessageFieldAccessor, IMessageOneofAccessor, IHasSceneRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x200027D")]
		public enum StateOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40009D7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40009D8")]
			MealData,
			[Cpp2IlInjected.Token(Token = "0x40009D9")]
			MemoryShardIndex,
			[Cpp2IlInjected.Token(Token = "0x40009DA")]
			ConsummableData,
			[Cpp2IlInjected.Token(Token = "0x40009DB")]
			LootPresentData,
			[Cpp2IlInjected.Token(Token = "0x40009DC")]
			SceneRestriction
		}

		[Cpp2IlInjected.Token(Token = "0x40009CD")]
		private static readonly MessageParser<ItemState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009CE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009CF")]
		public const int MealDataFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40009D0")]
		public const int MemoryShardIndexFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40009D1")]
		public const int ConsummableDataFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40009D2")]
		public const int LootPresentDataFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40009D3")]
		public const int SceneRestrictionFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009D4")]
		private object state_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009D5")]
		private StateOneofCase stateCase_;

		[Cpp2IlInjected.Token(Token = "0x17000538")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60017A9")]
			[Cpp2IlInjected.Address(RVA = "0x641950", Offset = "0x640350", VA = "0x180641950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000539")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017AA")]
			[Cpp2IlInjected.Address(RVA = "0x641750", Offset = "0x640150", VA = "0x180641750")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60017AB")]
			[Cpp2IlInjected.Address(RVA = "0x641B60", Offset = "0x640560", VA = "0x180641B60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053B")]
		[DebuggerNonUserCode]
		public MealData MealData
		{
			[Cpp2IlInjected.Token(Token = "0x60017AF")]
			[Cpp2IlInjected.Address(RVA = "0x641880", Offset = "0x640280", VA = "0x180641880")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.MealData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60017B0")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				state_ = value;
				bool flag = (byte)(stateCase_ = ((value != null) ? StateOneofCase.MealData : StateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053C")]
		[DebuggerNonUserCode]
		public int MemoryShardIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60017B1")]
			[Cpp2IlInjected.Address(RVA = "0x6418E0", Offset = "0x6402E0", VA = "0x1806418E0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (stateCase_ == StateOneofCase.MemoryShardIndex)
				{
					object obj = state_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60017B2")]
			[Cpp2IlInjected.Address(RVA = "0x641C70", Offset = "0x640670", VA = "0x180641C70")]
			set
			{
				//IL_0014: Expected I4, but got I8
				state_ = typeof(int).TypeHandle;
				stateCase_ = StateOneofCase.MemoryShardIndex;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053D")]
		[DebuggerNonUserCode]
		public ItemInstance ConsummableData
		{
			[Cpp2IlInjected.Token(Token = "0x60017B3")]
			[Cpp2IlInjected.Address(RVA = "0x6416F0", Offset = "0x6400F0", VA = "0x1806416F0")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.ConsummableData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60017B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053E")]
		[DebuggerNonUserCode]
		public MultiItemInstance LootPresentData
		{
			[Cpp2IlInjected.Token(Token = "0x60017B5")]
			[Cpp2IlInjected.Address(RVA = "0x641820", Offset = "0x640220", VA = "0x180641820")]
			get
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.LootPresentData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60017B6")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053F")]
		[DebuggerNonUserCode]
		public int SceneRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60017B7")]
			[Cpp2IlInjected.Address(RVA = "0x641AF0", Offset = "0x6404F0", VA = "0x180641AF0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (stateCase_ == StateOneofCase.SceneRestriction)
				{
					object obj = state_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60017B8")]
			[Cpp2IlInjected.Address(RVA = "0x641CE0", Offset = "0x6406E0", VA = "0x180641CE0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				state_ = typeof(int).TypeHandle;
				stateCase_ = StateOneofCase.SceneRestriction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000540")]
		[DebuggerNonUserCode]
		public StateOneofCase StateCase
		{
			[Cpp2IlInjected.Token(Token = "0x60017B9")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return stateCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000541")]
		public Item? SceneRestrictionItem
		{
			[Cpp2IlInjected.Token(Token = "0x60017C8")]
			[Cpp2IlInjected.Address(RVA = "0x6419B0", Offset = "0x6403B0", VA = "0x1806419B0", Slot = "16")]
			get
			{
				if (stateCase_ != StateOneofCase.SceneRestriction)
				{
					int num = 0;
					if ((object)typeof(Item).TypeHandle == null)
					{
					}
					num += num;
					num++;
					num += 312;
				}
				long num2 = Convert.ToInt64((uint)SceneRestriction);
				int num3 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017AC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60017AD")]
		[Cpp2IlInjected.Address(RVA = "0x641580", Offset = "0x63FF80", VA = "0x180641580")]
		[DebuggerNonUserCode]
		public ItemState(ItemState other)
		{
			//IL_0049: Expected I4, but got O
			//IL_0063: Expected I4, but got O
			StateOneofCase stateOneofCase = other.stateCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (other != null)
						{
							if (stateOneofCase != StateOneofCase.MealData)
							{
								goto IL_009a;
							}
							int num = (SceneRestriction = other.SceneRestriction);
						}
						stateCase_ = (StateOneofCase)(state_ = other.LootPresentData.Clone());
					}
					stateCase_ = (StateOneofCase)(state_ = other.ConsummableData.Clone());
				}
				int num2 = (MemoryShardIndex = other.MemoryShardIndex);
			}
			bool flag = (byte)(stateCase_ = (((state_ = other.MealData.Clone()) != null) ? StateOneofCase.MealData : StateOneofCase.None)) != 0;
			goto IL_009a;
			IL_009a:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017AE")]
		[Cpp2IlInjected.Address(RVA = "0x640130", Offset = "0x63EB30", VA = "0x180640130", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemState Clone()
		{
			//Discarded unreachable code: IL_00b4
			//IL_0049: Expected I4, but got O
			//IL_0066: Expected I4, but got O
			ItemState itemState = new ItemState();
			StateOneofCase stateOneofCase = stateCase_;
			if (this != null)
			{
				if (this != null)
				{
					if (this != null)
					{
						if (this != null)
						{
							if (stateOneofCase != StateOneofCase.MealData)
							{
								goto IL_009d;
							}
							int num = (itemState.SceneRestriction = SceneRestriction);
						}
						itemState.stateCase_ = (StateOneofCase)(itemState.state_ = LootPresentData.Clone());
					}
					itemState.stateCase_ = (StateOneofCase)(itemState.state_ = ConsummableData.Clone());
				}
				int num2 = (itemState.MemoryShardIndex = MemoryShardIndex);
			}
			bool flag = (byte)(itemState.stateCase_ = (((itemState.state_ = MealData.Clone()) != null) ? StateOneofCase.MealData : StateOneofCase.None)) != 0;
			goto IL_009d;
			IL_009d:
			UnknownFieldSet unknownFieldSet = (itemState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemState;
		}

		[Cpp2IlInjected.Token(Token = "0x60017BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearState()
		{
			//IL_0010: Expected O, but got I4
			state_ = (stateCase_ = StateOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017BB")]
		[Cpp2IlInjected.Address(RVA = "0x6405C0", Offset = "0x63EFC0", VA = "0x1806405C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ItemState)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60017BC")]
		[Cpp2IlInjected.Address(RVA = "0x640420", Offset = "0x63EE20", VA = "0x180640420", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemState other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (stateCase_ == StateOneofCase.MealData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
						goto IL_00ea;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.stateCase_ == StateOneofCase.MealData)
				{
					obj2 = other.state_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int memoryShardIndex = MemoryShardIndex;
					int memoryShardIndex2 = other.MemoryShardIndex;
					if (memoryShardIndex == memoryShardIndex2)
					{
						ItemInstance consummableData = ConsummableData;
						ItemInstance consummableData2 = other.ConsummableData;
						if (object.Equals(consummableData, consummableData2))
						{
							MultiItemInstance lootPresentData = LootPresentData;
							MultiItemInstance lootPresentData2 = other.LootPresentData;
							if (object.Equals(lootPresentData, lootPresentData2))
							{
								int sceneRestriction = SceneRestriction;
								int sceneRestriction2 = other.SceneRestriction;
								if (sceneRestriction == sceneRestriction2)
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
			int num2 = 0;
			goto IL_00ea;
			IL_00ea:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017BD")]
		[Cpp2IlInjected.Address(RVA = "0x640740", Offset = "0x63F140", VA = "0x180640740", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a7
			while (true)
			{
				StateOneofCase stateOneofCase = stateCase_;
				int num = 0;
				if (stateOneofCase == StateOneofCase.MealData)
				{
					object obj = state_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (stateOneofCase == StateOneofCase.MemoryShardIndex)
				{
					if (stateCase_ != StateOneofCase.MemoryShardIndex)
					{
					}
					object obj2 = state_;
				}
				if (stateCase_ != StateOneofCase.ConsummableData)
				{
					continue;
				}
				object obj3 = state_;
				if (obj3 != null)
				{
					int hashCode2 = obj3.GetHashCode();
					if (stateCase_ == StateOneofCase.LootPresentData)
					{
						object obj4 = state_;
						if (obj4 == null)
						{
							break;
						}
						int hashCode3 = obj4.GetHashCode();
						if (stateCase_ == StateOneofCase.SceneRestriction && stateCase_ == StateOneofCase.SceneRestriction)
						{
							object obj5 = state_;
						}
						UnknownFieldSet unknownFields = _unknownFields;
						if (unknownFields != null)
						{
							int hashCode4 = unknownFields.GetHashCode();
						}
						return 1;
					}
					continue;
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017BE")]
		[Cpp2IlInjected.Address(RVA = "0x641200", Offset = "0x63FC00", VA = "0x180641200", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60017BF")]
		[Cpp2IlInjected.Address(RVA = "0x641260", Offset = "0x63FC60", VA = "0x180641260", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b8
			//IL_002f: Expected O, but got I4
			while (true)
			{
				StateOneofCase stateOneofCase = stateCase_;
				int num = 0;
				if (stateOneofCase == StateOneofCase.MealData)
				{
					if (stateCase_ == StateOneofCase.MealData)
					{
						object obj = state_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (stateOneofCase != StateOneofCase.MemoryShardIndex)
				{
					continue;
				}
				int memoryShardIndex = MemoryShardIndex;
				output.WriteInt32(memoryShardIndex);
				if (stateCase_ != StateOneofCase.ConsummableData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.ConsummableData)
				{
					object obj2 = state_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (stateCase_ != StateOneofCase.LootPresentData)
				{
					continue;
				}
				if (stateCase_ == StateOneofCase.LootPresentData)
				{
					object obj3 = state_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stateCase_ == StateOneofCase.SceneRestriction)
				{
					int sceneRestriction = SceneRestriction;
					output.WriteInt32(sceneRestriction);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017C0")]
		[Cpp2IlInjected.Address(RVA = "0x63FD60", Offset = "0x63E760", VA = "0x18063FD60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ec
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (stateCase_ == StateOneofCase.MealData)
			{
				if (stateCase_ == StateOneofCase.MealData)
				{
					object obj = state_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (stateCase_ == StateOneofCase.MemoryShardIndex)
			{
				if (stateCase_ != StateOneofCase.MemoryShardIndex)
				{
				}
				object obj2 = state_;
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (stateCase_ == StateOneofCase.ConsummableData)
			{
				if (stateCase_ != StateOneofCase.ConsummableData)
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
			if (stateCase_ == StateOneofCase.LootPresentData)
			{
				if (stateCase_ != StateOneofCase.LootPresentData)
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
			if (stateCase_ == StateOneofCase.SceneRestriction)
			{
				if (stateCase_ == StateOneofCase.SceneRestriction)
				{
					object obj5 = state_;
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60017C1")]
		[Cpp2IlInjected.Address(RVA = "0x640A80", Offset = "0x63F480", VA = "0x180640A80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemState other)
		{
			//Discarded unreachable code: IL_0119
			//IL_0056: Expected I4, but got O
			//IL_008d: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			StateOneofCase stateOneofCase = other.stateCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (other != null)
						{
							if (stateOneofCase != StateOneofCase.MealData)
							{
								goto IL_00f9;
							}
							int num = (SceneRestriction = other.SceneRestriction);
						}
						if (LootPresentData == null)
						{
							stateCase_ = (StateOneofCase)(state_ = new MultiItemInstance());
						}
						MultiItemInstance lootPresentData = LootPresentData;
						MultiItemInstance lootPresentData2 = other.LootPresentData;
						lootPresentData.MergeFrom(lootPresentData2);
					}
					if (ConsummableData == null)
					{
						stateCase_ = (StateOneofCase)(state_ = new ItemInstance());
					}
					ItemInstance consummableData = ConsummableData;
					ItemInstance consummableData2 = other.ConsummableData;
					consummableData.MergeFrom(consummableData2);
				}
				int num2 = (MemoryShardIndex = other.MemoryShardIndex);
			}
			if (MealData == null)
			{
				bool flag = (byte)(stateCase_ = (((state_ = new MealData()) != null) ? StateOneofCase.MealData : StateOneofCase.None)) != 0;
			}
			MealData mealData = MealData;
			MealData mealData2 = other.MealData;
			mealData.MergeFrom(mealData2);
			goto IL_00f9;
			IL_00f9:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60017C2")]
		[Cpp2IlInjected.Address(RVA = "0x640CC0", Offset = "0x63F6C0", VA = "0x180640CC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00a9: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					ItemInstance itemInstance = new ItemInstance();
					if (stateCase_ == StateOneofCase.ConsummableData)
					{
						if (stateCase_ != StateOneofCase.ConsummableData)
						{
						}
						object obj = state_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(itemInstance);
					state_ = itemInstance;
					stateCase_ = (StateOneofCase)itemInstance;
				}
				if (num == 34)
				{
					MultiItemInstance builder = new MultiItemInstance();
					if (stateCase_ == StateOneofCase.LootPresentData)
					{
						if (stateCase_ != StateOneofCase.LootPresentData)
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
					stateCase_ = (StateOneofCase)typeof(MultiItemInstance).TypeHandle;
				}
				if ((long)typeof(MultiItemInstance).TypeHandle != 40)
				{
					goto IL_012f;
				}
				int num3 = (SceneRestriction = input.ReadInt32());
			}
			bool flag = default(bool);
			if (num == 10)
			{
				MealData mealData = new MealData();
				if (stateCase_ == StateOneofCase.MealData)
				{
					if (stateCase_ != StateOneofCase.MealData)
					{
					}
					object obj3 = state_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(mealData);
				state_ = mealData;
				flag = (byte)(stateCase_ = ((mealData != null) ? StateOneofCase.MealData : StateOneofCase.None)) != 0;
			}
			if (flag)
			{
				int num5 = (MemoryShardIndex = input.ReadInt32());
			}
			goto IL_012f;
			IL_012f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60017C3")]
		[Cpp2IlInjected.Address(RVA = "0x640620", Offset = "0x63F020", VA = "0x180640620", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							int sceneRestriction = SceneRestriction;
						}
						MultiItemInstance lootPresentData = LootPresentData;
					}
					ItemInstance consummableData = ConsummableData;
				}
				int memoryShardIndex = MemoryShardIndex;
			}
			MealData mealData = MealData;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017C4")]
		[Cpp2IlInjected.Address(RVA = "0x640FE0", Offset = "0x63F9E0", VA = "0x180640FE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_002a: Expected O, but got I4
			//IL_0035: Expected I4, but got O
			//IL_0050: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0)
				{
					return;
				}
				if (num != 0)
				{
					switch (num)
					{
					case 0:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							state_ = num2;
							stateCase_ = (StateOneofCase)typeof(MultiItemInstance).TypeHandle;
							break;
						}
						throw new InvalidCastException();
					}
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					state_ = value;
					stateCase_ = (StateOneofCase)typeof(MultiItemInstance).TypeHandle;
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				state_ = value;
				bool flag = (byte)(stateCase_ = ((value != null) ? StateOneofCase.MealData : StateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017C5")]
		[Cpp2IlInjected.Address(RVA = "0x640050", Offset = "0x63EA50", VA = "0x180640050", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_0021: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num2 = (SceneRestriction = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017C6")]
		[Cpp2IlInjected.Address(RVA = "0x6409D0", Offset = "0x63F3D0", VA = "0x1806409D0", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60017C7")]
		[Cpp2IlInjected.Address(RVA = "0x6400C0", Offset = "0x63EAC0", VA = "0x1806400C0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "State"))
			{
				state_ = (stateCase_ = StateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017C9")]
		[Cpp2IlInjected.Address(RVA = "0x6402D0", Offset = "0x63ECD0", VA = "0x1806402D0")]
		public static bool Equals(ItemState a, ItemState b)
		{
			int num = 0;
			if (a != null)
			{
			}
			StateOneofCase stateOneofCase = default(StateOneofCase);
			if (b != null)
			{
				stateOneofCase = b.stateCase_;
			}
			if (num == (int)stateOneofCase)
			{
				switch (num)
				{
				default:
					return a.Equals(b);
				case 1:
				{
					Item? sceneRestrictionItem = (Item?)a.MealData.get_SceneRestrictionItem();
					Item? sceneRestrictionItem2 = (Item?)b.MealData.get_SceneRestrictionItem();
					break;
				}
				case 0:
					break;
				}
				return true;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017CA")]
		[Cpp2IlInjected.Address(RVA = "0x641470", Offset = "0x63FE70", VA = "0x180641470")]
		static ItemState()
		{
			Func<ItemState> func = default(Func<ItemState>);
			_parser = (MessageParser<ItemState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
