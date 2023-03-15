using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2001111")]
	public sealed class CollectionSet : IMessage<CollectionSet>, IMessage, IEquatable<CollectionSet>, IDeepCloneable<CollectionSet>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004654")]
		private ProfileEventDispatcher Dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004655")]
		private ProfilePlayer Player;

		[Cpp2IlInjected.Token(Token = "0x4004656")]
		private static readonly MessageParser<CollectionSet> _parser = (MessageParser<CollectionSet>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CollectionSet()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004657")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004658")]
		public const int GroupDataFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4004659")]
		private static readonly FieldCodec<CollectionSetGroup> _repeated_groupData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400465A")]
		private readonly RepeatedField<CollectionSetGroup> groupData_;

		[Cpp2IlInjected.Token(Token = "0x400465B")]
		public const int CollectionDefinitionIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400465C")]
		private int collectionDefinitionID_;

		[Cpp2IlInjected.Token(Token = "0x1700186B")]
		private IPlayerEventDispatcher PlayerDispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6008B1F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186C")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionSet> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008B27")]
			[Cpp2IlInjected.Address(RVA = "0x167D900", Offset = "0x167C300", VA = "0x18167D900")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008B28")]
			[Cpp2IlInjected.Address(RVA = "0x167D830", Offset = "0x167C230", VA = "0x18167D830")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008B29")]
			[Cpp2IlInjected.Address(RVA = "0x167D960", Offset = "0x167C360", VA = "0x18167D960", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186F")]
		[DebuggerNonUserCode]
		public RepeatedField<CollectionSetGroup> GroupData
		{
			[Cpp2IlInjected.Token(Token = "0x6008B2D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return groupData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001870")]
		[DebuggerNonUserCode]
		public int CollectionDefinitionID
		{
			[Cpp2IlInjected.Token(Token = "0x6008B2E")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return collectionDefinitionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008B2F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				collectionDefinitionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B20")]
		[Cpp2IlInjected.Address(RVA = "0x167D0F0", Offset = "0x167BAF0", VA = "0x18167D0F0")]
		internal void Start(ProfileEventDispatcher dispatcher, ProfilePlayer player)
		{
			//Discarded unreachable code: IL_00d2
			RepeatedField<CollectionSetGroup> repeatedField = groupData_;
			Func<CollectionSetGroup, bool> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_0;
			if (_003C_003E9__4_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CollectionSetGroup x) => x.state_ == SetState.NotComplete);
			}
			if (Enumerable.Count<CollectionSetGroup>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__4_) != 0)
			{
				Dispatcher = dispatcher;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded itemAdded = OnItemAdded;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.CritterUpdated value = OnCritterUnlocked;
				dispatcher3.OnCritterUnlocked += value;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value2 = OnMemoryShardAdded;
				dispatcher4.OnMemoryShardAdded += value2;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value3 = OnCharacterUnlocked;
				dispatcher5.OnCharacterUnlocked += value3;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.RecipeAdded value4 = OnRecipeAdded;
				dispatcher6.OnRecipeAdded += value4;
				Player = player;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B21")]
		[Cpp2IlInjected.Address(RVA = "0x167CF20", Offset = "0x167B920", VA = "0x18167CF20")]
		private void OnRecipeAdded(Item recipeItem, InvActionType reason = InvActionType.None)
		{
			//Discarded unreachable code: IL_0012
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			RecipeItemData recipeItemData = default(RecipeItemData);
			if (recipeItemData != null)
			{
				int resultItemID = recipeItemData.ResultItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B22")]
		[Cpp2IlInjected.Address(RVA = "0x167C720", Offset = "0x167B120", VA = "0x18167C720")]
		private void OnCharacterUnlocked(Item item)
		{
			CheckItem(item);
		}

		[Cpp2IlInjected.Token(Token = "0x6008B23")]
		[Cpp2IlInjected.Address(RVA = "0x167C7B0", Offset = "0x167B1B0", VA = "0x18167C7B0")]
		private unsafe void OnMemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail)
		{
			//Discarded unreachable code: IL_021a
			//IL_008e: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00d1: Expected I4, but got O
			//IL_00fb: Expected O, but got I8
			//IL_00fb: Expected O, but got I4
			//IL_013b: Expected I4, but got I8
			int itemID = memoryShardItem.ItemID;
			ProfilePlayer player = Player;
			if (player == null)
			{
				return;
			}
			MapField<int, int> memoryShards_ = player.memoryShards_;
			Func<KeyValuePair<int, int>, bool> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
			if (_003C_003E9__7_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(KeyValuePair<int, int> x)
				{
					//Discarded unreachable code: IL_0017
					//IL_000d: Expected I4, but got O
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					int num6 = (int)((KeyValuePair<, >*)(&x))->key;
					MemoryShardItemData memoryShardItemData2 = default(MemoryShardItemData);
					int completedShardFlag2 = memoryShardItemData2.CompletedShardFlag;
					bool result = default(bool);
					return result;
				};
			}
			IEnumerable<KeyValuePair<int, int>> enumerable = (IEnumerable<KeyValuePair<int, int>>)Enumerable.Where<KeyValuePair<int, int>>((IEnumerable<>)(object)memoryShards_, (Func<, >)(object)_003C_003E9__7_);
			RepeatedField<CollectionSetGroup> repeatedField = groupData_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			RepeatedField<CollectionSetGroup> repeatedField2 = groupData_;
			if (num < count)
			{
				CollectionSetGroup collectionSetGroup = (CollectionSetGroup)((RepeatedField<T>)(object)repeatedField2)[num];
				if (collectionSetGroup.state_ == SetState.NotComplete && ((MapField<TKey, TValue>)(object)collectionSetGroup.groupsCollectionItems_).ContainsKey((TKey)itemID) && ((MapField<TKey, TValue>)(object)collectionSetGroup.groupsCollectionItems_)[(TKey)itemID] == null && ((MapField<TKey, TValue>)(object)Player.memoryShards_).ContainsKey((TKey)itemID))
				{
					int num2 = (int)((MapField<TKey, TValue>)(object)Player.memoryShards_)[(TKey)itemID];
					MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
					int completedShardFlag = memoryShardItemData.CompletedShardFlag;
					if (num2 == completedShardFlag)
					{
						MapField<int, bool> groupsCollectionItems_ = collectionSetGroup.groupsCollectionItems_;
						collectionSetGroup.NeedsUpdate = true;
						ulong num3 = default(ulong);
						((MapField<TKey, TValue>)(object)groupsCollectionItems_)[(TKey)itemID] = (TValue)num3;
						MapField<int, bool> groupsCollectionItems_2 = collectionSetGroup.groupsCollectionItems_;
						Func<KeyValuePair<int, bool>, bool> func = default(Func<KeyValuePair<int, bool>, bool>);
						if (_003C_003Ec._003C_003E9__7_2 == null)
						{
							func = (Func<KeyValuePair<int, bool>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
							});
						}
						if (((IEnumerable<>)(object)groupsCollectionItems_2).All<KeyValuePair<int, bool>>((Func<, >)(object)func))
						{
							collectionSetGroup.state_ = SetState.Completed;
						}
						ProfileEventDispatcher dispatcher = Dispatcher;
						int num4 = collectionDefinitionID_;
					}
				}
				RepeatedField<CollectionSetGroup> repeatedField3 = groupData_;
				num++;
			}
			if (_003C_003Ec._003C_003E9__7_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CollectionSetGroup x) => x.state_ == SetState.NotComplete);
			}
			int num5 = default(int);
			if (num5 == 0)
			{
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value = OnItemAdded;
				dispatcher2.OnItemAdded -= value;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.CritterUpdated value2 = OnCritterUnlocked;
				dispatcher3.OnCritterUnlocked -= value2;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value3 = OnMemoryShardAdded;
				dispatcher4.OnMemoryShardAdded -= value3;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value4 = OnCharacterUnlocked;
				dispatcher5.OnCharacterUnlocked -= value4;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.RecipeAdded value5 = OnRecipeAdded;
				dispatcher6.OnRecipeAdded -= value5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B24")]
		[Cpp2IlInjected.Address(RVA = "0x167C770", Offset = "0x167B170", VA = "0x18167C770")]
		private void OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			//Discarded unreachable code: IL_0008
			int itemID = item.ItemID;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B25")]
		[Cpp2IlInjected.Address(RVA = "0x167C730", Offset = "0x167B130", VA = "0x18167C730")]
		private void OnCritterUnlocked(Critter critter)
		{
			//Discarded unreachable code: IL_0008
			Item critterItem = critter.CritterItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B26")]
		[Cpp2IlInjected.Address(RVA = "0x167BBF0", Offset = "0x167A5F0", VA = "0x18167BBF0")]
		private void CheckItem(Item item, InvActionType reason = InvActionType.None)
		{
			//Discarded unreachable code: IL_01ad
			//IL_004e: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_007f: Expected O, but got I8
			//IL_007f: Expected O, but got I4
			//IL_00bf: Expected I4, but got I8
			int itemID = item.ItemID;
			RepeatedField<CollectionSetGroup> repeatedField = groupData_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			RepeatedField<CollectionSetGroup> repeatedField2 = groupData_;
			if (num < count)
			{
				CollectionSetGroup collectionSetGroup = (CollectionSetGroup)((RepeatedField<T>)(object)repeatedField2)[num];
				if (collectionSetGroup.state_ == SetState.NotComplete && ((MapField<TKey, TValue>)(object)collectionSetGroup.groupsCollectionItems_).ContainsKey((TKey)itemID) && ((MapField<TKey, TValue>)(object)collectionSetGroup.groupsCollectionItems_)[(TKey)itemID] == null)
				{
					MapField<int, bool> groupsCollectionItems_ = collectionSetGroup.groupsCollectionItems_;
					collectionSetGroup.NeedsUpdate = true;
					ulong num2 = default(ulong);
					((MapField<TKey, TValue>)(object)groupsCollectionItems_)[(TKey)itemID] = (TValue)num2;
					MapField<int, bool> groupsCollectionItems_2 = collectionSetGroup.groupsCollectionItems_;
					Func<KeyValuePair<int, bool>, bool> _003C_003E9__10_ = _003C_003Ec._003C_003E9__10_1;
					if (_003C_003E9__10_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						};
					}
					if (((IEnumerable<>)(object)groupsCollectionItems_2).All<KeyValuePair<int, bool>>((Func<, >)(object)_003C_003E9__10_))
					{
						collectionSetGroup.state_ = SetState.Completed;
					}
					ProfileEventDispatcher dispatcher = Dispatcher;
					int num3 = collectionDefinitionID_;
					bool flag = reason == InvActionType.ConsumeItem;
				}
				RepeatedField<CollectionSetGroup> repeatedField3 = groupData_;
				num++;
			}
			Func<CollectionSetGroup, bool> func = default(Func<CollectionSetGroup, bool>);
			if (_003C_003Ec._003C_003E9__10_0 == null)
			{
				func = (Func<CollectionSetGroup, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CollectionSetGroup x) => x.state_ == SetState.NotComplete));
			}
			if (Enumerable.Count<CollectionSetGroup>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func) == 0)
			{
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value = OnItemAdded;
				dispatcher2.OnItemAdded -= value;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.CritterUpdated value2 = OnCritterUnlocked;
				dispatcher3.OnCritterUnlocked -= value2;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value3 = OnMemoryShardAdded;
				dispatcher4.OnMemoryShardAdded -= value3;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value4 = OnCharacterUnlocked;
				dispatcher5.OnCharacterUnlocked -= value4;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.RecipeAdded value5 = OnRecipeAdded;
				dispatcher6.OnRecipeAdded -= value5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B2A")]
		[Cpp2IlInjected.Address(RVA = "0x167D7B0", Offset = "0x167C1B0", VA = "0x18167D7B0")]
		[DebuggerNonUserCode]
		public CollectionSet()
		{
			groupData_ = (RepeatedField<CollectionSetGroup>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B2B")]
		[Cpp2IlInjected.Address(RVA = "0x167D720", Offset = "0x167C120", VA = "0x18167D720")]
		[DebuggerNonUserCode]
		public CollectionSet(CollectionSet other)
		{
			RepeatedField<CollectionSetGroup> repeatedField = (groupData_ = (RepeatedField<CollectionSetGroup>)(object)((RepeatedField<T>)(object)other.groupData_).Clone());
			int num = (collectionDefinitionID_ = other.collectionDefinitionID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B2C")]
		[Cpp2IlInjected.Address(RVA = "0x167C200", Offset = "0x167AC00", VA = "0x18167C200", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionSet Clone()
		{
			//Discarded unreachable code: IL_003c
			CollectionSet collectionSet = new CollectionSet();
			RepeatedField<CollectionSetGroup> repeatedField = (collectionSet.groupData_ = (RepeatedField<CollectionSetGroup>)(object)((RepeatedField<T>)(object)groupData_).Clone());
			int num = (collectionSet.collectionDefinitionID_ = collectionDefinitionID_);
			UnknownFieldSet unknownFieldSet = (collectionSet._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionSet;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B30")]
		[Cpp2IlInjected.Address(RVA = "0x167C360", Offset = "0x167AD60", VA = "0x18167C360", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<CollectionSetGroup> repeatedField = groupData_;
				bool flag = default(bool);
				if (flag && collectionDefinitionID_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B31")]
		[Cpp2IlInjected.Address(RVA = "0x167C2C0", Offset = "0x167ACC0", VA = "0x18167C2C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionSet other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<CollectionSetGroup> repeatedField = groupData_;
				RepeatedField<CollectionSetGroup> repeatedField2 = other.groupData_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.collectionDefinitionID_;
					if (collectionDefinitionID_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B32")]
		[Cpp2IlInjected.Address(RVA = "0x167C510", Offset = "0x167AF10", VA = "0x18167C510", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			int hashCode = ((RepeatedField<T>)(object)groupData_).GetHashCode();
			if (collectionDefinitionID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B33")]
		[Cpp2IlInjected.Address(RVA = "0x167D410", Offset = "0x167BE10", VA = "0x18167D410", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008B34")]
		[Cpp2IlInjected.Address(RVA = "0x167D470", Offset = "0x167BE70", VA = "0x18167D470", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			RepeatedField<CollectionSetGroup> repeatedField = groupData_;
			FieldCodec<CollectionSetGroup> repeated_groupData_codec = _repeated_groupData_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_groupData_codec);
			if (collectionDefinitionID_ != 0)
			{
				int value = collectionDefinitionID_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008B35")]
		[Cpp2IlInjected.Address(RVA = "0x167BB00", Offset = "0x167A500", VA = "0x18167BB00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			RepeatedField<CollectionSetGroup> repeatedField = groupData_;
			FieldCodec<CollectionSetGroup> repeated_groupData_codec = _repeated_groupData_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_groupData_codec);
			int num2 = collectionDefinitionID_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B36")]
		[Cpp2IlInjected.Address(RVA = "0x167C590", Offset = "0x167AF90", VA = "0x18167C590", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionSet other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				RepeatedField<CollectionSetGroup> repeatedField = groupData_;
				RepeatedField<CollectionSetGroup> repeatedField2 = other.groupData_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.collectionDefinitionID_;
				if (num != 0)
				{
					collectionDefinitionID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B37")]
		[Cpp2IlInjected.Address(RVA = "0x167C620", Offset = "0x167B020", VA = "0x18167C620", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0052
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<CollectionSetGroup> repeatedField = groupData_;
					FieldCodec<CollectionSetGroup> repeated_groupData_codec = _repeated_groupData_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_groupData_codec);
				}
				if (num == 16)
				{
					int num2 = (collectionDefinitionID_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B38")]
		[Cpp2IlInjected.Address(RVA = "0x167C440", Offset = "0x167AE40", VA = "0x18167C440", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<CollectionSetGroup> repeatedField = groupData_;
			}
			if (fieldNumber == 2)
			{
				int num = collectionDefinitionID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B39")]
		[Cpp2IlInjected.Address(RVA = "0x167D020", Offset = "0x167BA20", VA = "0x18167D020", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0010
			//IL_000f: Expected I4, but got O
			switch (fieldNumber)
			{
			case 2:
			{
				object obj = default(object);
				collectionDefinitionID_ = (int)obj;
				break;
			}
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B3A")]
		[Cpp2IlInjected.Address(RVA = "0x167C190", Offset = "0x167AB90", VA = "0x18167C190", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				RepeatedField<CollectionSetGroup> repeatedField = groupData_;
			}
			if (fieldNumber == 2)
			{
				collectionDefinitionID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B3B")]
		[Cpp2IlInjected.Address(RVA = "0x167D550", Offset = "0x167BF50", VA = "0x18167D550")]
		static CollectionSet()
		{
			MessageParser<CollectionSetGroup> parser = CollectionSetGroup._parser;
			uint num = default(uint);
			_parser = (MessageParser<CollectionSet>)(object)FieldCodec.ForMessage<CollectionSetGroup>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
