using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008B8")]
	public sealed class WeedController : IMessage<WeedController>, IMessage, IEquatable<WeedController>, IDeepCloneable<WeedController>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002312")]
		private static readonly MessageParser<WeedController> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002313")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002314")]
		public const int LastMinigameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002315")]
		private Timestamp lastMinigame_;

		[Cpp2IlInjected.Token(Token = "0x4002316")]
		private const string RandomSeedName = "WeedController";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002319")]
		private WeedControllerData weedControllerData;

		[Cpp2IlInjected.Token(Token = "0x17000C78")]
		[DebuggerNonUserCode]
		public static MessageParser<WeedController> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5C")]
			[Cpp2IlInjected.Address(RVA = "0x15E82E0", Offset = "0x15E6CE0", VA = "0x1815E82E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C79")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5D")]
			[Cpp2IlInjected.Address(RVA = "0x15E8210", Offset = "0x15E6C10", VA = "0x1815E8210")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5E")]
			[Cpp2IlInjected.Address(RVA = "0x15E8340", Offset = "0x15E6D40", VA = "0x1815E8340", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7B")]
		[DebuggerNonUserCode]
		public Timestamp LastMinigame
		{
			[Cpp2IlInjected.Token(Token = "0x6004A63")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return lastMinigame_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A64")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				lastMinigame_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002317")]
		internal bool ForceTreasure
		{
			[Cpp2IlInjected.Token(Token = "0x6004A70")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004A71")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x21"), Cpp2IlInjected.Token(Token = "0x4002318")]
		internal bool ForceMinigame
		{
			[Cpp2IlInjected.Token(Token = "0x6004A72")]
			[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004A73")]
			[Cpp2IlInjected.Address(RVA = "0xBA18C0", Offset = "0xBA02C0", VA = "0x180BA18C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A5F")]
		[Cpp2IlInjected.Address(RVA = "0x15E80D0", Offset = "0x15E6AD0", VA = "0x1815E80D0")]
		[DebuggerNonUserCode]
		public WeedController()
		{
			Timestamp timestamp = (lastMinigame_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A60")]
		[Cpp2IlInjected.Address(RVA = "0x15E6F40", Offset = "0x15E5940", VA = "0x1815E6F40")]
		private void OnConstruction()
		{
			Timestamp timestamp = (lastMinigame_ = new Timestamp());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A61")]
		[Cpp2IlInjected.Address(RVA = "0x15E8140", Offset = "0x15E6B40", VA = "0x1815E8140")]
		[DebuggerNonUserCode]
		public WeedController(WeedController other)
		{
			//IL_002e: Expected O, but got I4
			Timestamp timestamp = (lastMinigame_ = new Timestamp());
			Timestamp timestamp2 = other.lastMinigame_;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			int num = 0;
			lastMinigame_ = (Timestamp)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A62")]
		[Cpp2IlInjected.Address(RVA = "0x15E6B60", Offset = "0x15E5560", VA = "0x1815E6B60", Slot = "10")]
		[DebuggerNonUserCode]
		public WeedController Clone()
		{
			//Discarded unreachable code: IL_0047
			//IL_0030: Expected O, but got I4
			WeedController weedController = new WeedController();
			Timestamp timestamp = (weedController.lastMinigame_ = new Timestamp());
			Timestamp timestamp2 = lastMinigame_;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			int num = 0;
			weedController.lastMinigame_ = (Timestamp)num;
			UnknownFieldSet unknownFieldSet = (weedController._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return weedController;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A65")]
		[Cpp2IlInjected.Address(RVA = "0x15E6C60", Offset = "0x15E5660", VA = "0x1815E6C60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(lastMinigame_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A66")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WeedController other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.lastMinigame_;
				if (object.Equals(lastMinigame_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A67")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = lastMinigame_;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A68")]
		[Cpp2IlInjected.Address(RVA = "0x15E7D60", Offset = "0x15E6760", VA = "0x1815E7D60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A69")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)lastMinigame_ != 0)
			{
				Timestamp value = lastMinigame_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A6A")]
		[Cpp2IlInjected.Address(RVA = "0x15E6AC0", Offset = "0x15E54C0", VA = "0x1815E6AC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = lastMinigame_;
				num = 0;
				if (timestamp != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A6B")]
		[Cpp2IlInjected.Address(RVA = "0x15E6D90", Offset = "0x15E5790", VA = "0x1815E6D90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WeedController other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.lastMinigame_ != 0)
			{
				Timestamp timestamp = lastMinigame_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastMinigame_ = new Timestamp());
				}
				Timestamp other2 = other.lastMinigame_;
				timestamp.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004A6C")]
		[Cpp2IlInjected.Address(RVA = "0x15E6E60", Offset = "0x15E5860", VA = "0x1815E6E60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Timestamp timestamp = lastMinigame_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastMinigame_ = new Timestamp());
				}
				input.ReadMessage(timestamp);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004A6D")]
		[Cpp2IlInjected.Address(RVA = "0x15E6D10", Offset = "0x15E5710", VA = "0x1815E6D10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = lastMinigame_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A6E")]
		[Cpp2IlInjected.Address(RVA = "0x15E7CE0", Offset = "0x15E66E0", VA = "0x1815E7CE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				lastMinigame_ = (Timestamp)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A6F")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A74")]
		[Cpp2IlInjected.Address(RVA = "0x15E6FA0", Offset = "0x15E59A0", VA = "0x1815E6FA0")]
		internal void PullWeed(IGrid grid, GridObject gridObject, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_01bd
			//IL_0167: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			int num6 = default(int);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			MultiReward multiReward = default(MultiReward);
			bool flag6 = default(bool);
			ItemReward itemReward = default(ItemReward);
			bool flag7 = default(bool);
			Timestamp timestamp = default(Timestamp);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				Random random = new Random(player.Section.GetRandomSeed("WeedController"));
				int num5 = 0;
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					WeedData weedData = state_.WeedData;
					if (weedData != null)
					{
						WeedData.DataOneofCase dataCase_ = weedData.dataCase_;
					}
					if (num2 != 2)
					{
						int itemID = gridObject.state_.WeedData.Treasure.Item.ItemID;
						ItemState state_2 = gridObject.state_.WeedData.Treasure.state_;
						GridPosition position = gridObject.Position;
						if (!flag)
						{
							break;
						}
					}
				}
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				int itemID2 = gridObject.ItemID;
				if (!flag2)
				{
					break;
				}
				if (!flag3)
				{
					int treasureDefaultProbability_ = this.weedControllerData.treasureDefaultProbability_;
					Item invalid = Item.Invalid;
					GridState state_3 = gridObject.state_;
					if (state_3 != null)
					{
						WeedData weedData2 = state_3.WeedData;
						if (weedData2 != null)
						{
							WeedData.DataOneofCase dataCase_2 = weedData2.dataCase_;
						}
						if (num2 != 1)
						{
							if (gridObject.state_.WeedData.LootOverride.treasureProbability_ > num2)
							{
								WeedData.Types.TreasureLootOverride lootOverride = gridObject.state_.WeedData.LootOverride;
							}
							int lootTable_ = gridObject.state_.WeedData.LootOverride.lootTable_;
						}
					}
					if ((ForceTreasure ? 1 : 0) == num2)
					{
						num6 = random.Next(100);
						if (num6 >= treasureDefaultProbability_)
						{
							break;
						}
					}
					if (num6 == 0 || flag4)
					{
					}
					if (!flag5)
					{
						break;
					}
					int num7 = 0;
					new RewardGenerationParameters().RewardAppearanceCondition = (RewardAppearanceCondition?)(object)num2;
					RepeatedField<AnyReward> rewards_ = multiReward.rewards_;
					if (flag6)
					{
						int itemID3 = itemReward.Item.ItemID;
						ItemState state_4 = itemReward.state_;
						GridPosition position2 = gridObject.Position;
						while (!flag7)
						{
						}
					}
					if (num2 != 0)
					{
						continue;
					}
				}
				lastMinigame_ = timestamp;
				WeedControllerData weedControllerData = this.weedControllerData;
				break;
			}
			ProfilePlayer profilePlayer = default(ProfilePlayer);
			profilePlayer.AdvanceRandomSeed("WeedController");
		}

		[Cpp2IlInjected.Token(Token = "0x6004A75")]
		[Cpp2IlInjected.Address(RVA = "0x15E7FC0", Offset = "0x15E69C0", VA = "0x1815E7FC0")]
		static WeedController()
		{
			Func<WeedController> func = default(Func<WeedController>);
			_parser = (MessageParser<WeedController>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
