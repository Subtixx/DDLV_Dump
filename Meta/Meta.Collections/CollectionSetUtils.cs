using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf.Collections;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2001113")]
	public class CollectionSetUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6008B45")]
		[Cpp2IlInjected.Address(RVA = "0x167A740", Offset = "0x1679140", VA = "0x18167A740")]
		public unsafe static void GenerateCollectionSets(ProfilePlayer player, ProfileEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_00de, IL_00e4, IL_00ea, IL_00f0, IL_00f6, IL_00fc, IL_0102, IL_0108, IL_010e, IL_0114, IL_011a, IL_0120, IL_0126
			//IL_0037: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			int num = 0;
			List<CollectionSetItemData> list = (List<CollectionSetItemData>)(object)Enumerable.ToList<CollectionSetItemData>(ItemDatabase.Instance.GetAllByType<CollectionSetItemData>(ItemType.CollectionSet));
			int num2 = 0;
			HashSet<Item> newProfileDefaultItems = (HashSet<Item>)(object)CollectionSetUtils.GetNewProfileDefaultItems();
			bool flag = default(bool);
			if (flag)
			{
				CollectionSetItemData colSetData = (CollectionSetItemData)0;
				int num3 = 0;
				CollectionGroup collectionGroup = default(CollectionGroup);
				CollectionSetGroup newGroup = CollectionSetUtils.GetNewGroup(collectionGroup, (HashSet<>)(object)newProfileDefaultItems);
				RepeatedField<CollectionSet> collectionSets_ = player.collectionSets_;
				Predicate<CollectionSet> predicate = (Predicate<CollectionSet>)(object)(Predicate<T>)delegate(CollectionSet x)
				{
					//Discarded unreachable code: IL_0016
					int iD_ = colSetData.iD_;
					return x.collectionDefinitionID_ == iD_;
				};
				if (!ProtoExtensions.TryFindValue<CollectionSet>((RepeatedField<>)(object)collectionSets_, (Predicate<>)(object)predicate, ref *(CollectionSet*)num))
				{
					CollectionSet collectionSet = new CollectionSet();
					ProfilePlayer player2 = collectionSet.Player;
					newGroup.state_ = (SetState)num;
					newGroup.groupIndex_ = num;
					int num4 = default(int);
					string text2 = (newGroup.GroupName = $"{collectionSet} {num4}");
					((RepeatedField<T>)(object)collectionSet.groupData_).Add((T)newGroup);
					((RepeatedField<T>)(object)player.collectionSets_).Add((T)collectionSet);
				}
				CollectionSetGroup collectionSetGroup = Enumerable.FirstOrDefault<CollectionSetGroup>((IEnumerable<>)num);
				if (collectionSetGroup != null && UpdateGroup(collectionSetGroup, newGroup))
				{
					collectionSetGroup.state_ = (SetState)num;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B46")]
		[Cpp2IlInjected.Address(RVA = "0x167B940", Offset = "0x167A340", VA = "0x18167B940")]
		private static bool UpdateGroup(CollectionSetGroup curCollection, CollectionSetGroup newCollection)
		{
			//Discarded unreachable code: IL_0028, IL_002e, IL_0034
			int num = 0;
			MapField<int, bool> groupsCollectionItems_ = newCollection.groupsCollectionItems_;
			bool flag = default(bool);
			if (flag)
			{
				MapField<int, bool> groupsCollectionItems_2 = curCollection.groupsCollectionItems_;
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				MapField<int, bool> groupsCollectionItems_3 = curCollection.groupsCollectionItems_;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B47")]
		[Cpp2IlInjected.Address(RVA = "0x167AE90", Offset = "0x1679890", VA = "0x18167AE90")]
		public static HashSet<Item> GetNewProfileDefaultItems()
		{
			//Discarded unreachable code: IL_01ea
			HashSet<Item> hashSet = (HashSet<Item>)(object)new HashSet<T>();
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<(Item, ItemState), int> dictionary = default(Dictionary<(Item, ItemState), int>);
				Dictionary<(Item, ItemState), int>.KeyCollection keys = (Dictionary<(Item, ItemState), int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary).get_Keys();
				Func<(Item, ItemState), Item> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				IEnumerable<(Item, ItemState)> enumerable = (IEnumerable<(Item, ItemState)>)Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)(object)keys, (Func<, >)(object)_003C_003E9__2_);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable);
				Dictionary<(Item, ItemState), int> dictionary2 = default(Dictionary<(Item, ItemState), int>);
				Dictionary<(Item, ItemState), int>.KeyCollection keys2 = (Dictionary<(Item, ItemState), int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary2).get_Keys();
				Func<(Item, ItemState), Item> func = default(Func<(Item, ItemState), Item>);
				if (_003C_003Ec._003C_003E9__2_1 == null)
				{
					func = (Func<(Item, ItemState), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				IEnumerable<(Item, ItemState)> enumerable2 = (IEnumerable<(Item, ItemState)>)Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)(object)keys2, (Func<, >)(object)func);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable2);
				Dictionary<(Item, ItemState), int> dictionary3 = default(Dictionary<(Item, ItemState), int>);
				Dictionary<(Item, ItemState), int>.KeyCollection keys3 = (Dictionary<(Item, ItemState), int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary3).get_Keys();
				Func<(Item, ItemState), Item> func2 = default(Func<(Item, ItemState), Item>);
				if (_003C_003Ec._003C_003E9__2_2 == null)
				{
					func2 = (Func<(Item, ItemState), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				IEnumerable<(Item, ItemState)> enumerable3 = (IEnumerable<(Item, ItemState)>)Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)(object)keys3, (Func<, >)(object)func2);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable3);
				Dictionary<(Item, ItemState), int> dictionary4 = default(Dictionary<(Item, ItemState), int>);
				Dictionary<(Item, ItemState), int>.KeyCollection keys4 = (Dictionary<(Item, ItemState), int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary4).get_Keys();
				Func<(Item, ItemState), Item> func3 = default(Func<(Item, ItemState), Item>);
				if (_003C_003Ec._003C_003E9__2_3 == null)
				{
					func3 = (Func<(Item, ItemState), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				IEnumerable<(Item, ItemState)> enumerable4 = (IEnumerable<(Item, ItemState)>)Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)(object)keys4, (Func<, >)(object)func3);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable4);
				Dictionary<(Item, ItemState), int> dictionary5 = default(Dictionary<(Item, ItemState), int>);
				Dictionary<(Item, ItemState), int>.KeyCollection keys5 = (Dictionary<(Item, ItemState), int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary5).get_Keys();
				Func<(Item, ItemState), Item> func4 = default(Func<(Item, ItemState), Item>);
				if (_003C_003Ec._003C_003E9__2_4 == null)
				{
					func4 = (Func<(Item, ItemState), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				IEnumerable<(Item, ItemState)> enumerable5 = (IEnumerable<(Item, ItemState)>)Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)(object)keys5, (Func<, >)(object)func4);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable5);
				Dictionary<(Item, ItemState), int> dictionary6 = default(Dictionary<(Item, ItemState), int>);
				Dictionary<(Item, ItemState), int>.KeyCollection keys6 = (Dictionary<(Item, ItemState), int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary6).get_Keys();
				Func<(Item, ItemState), Item> func5 = default(Func<(Item, ItemState), Item>);
				if (_003C_003Ec._003C_003E9__2_5 == null)
				{
					func5 = (Func<(Item, ItemState), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				IEnumerable<(Item, ItemState)> enumerable6 = (IEnumerable<(Item, ItemState)>)Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)(object)keys6, (Func<, >)(object)func5);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable6);
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Func<CharacterItemData, bool> func6 = default(Func<CharacterItemData, bool>);
				if (_003C_003Ec._003C_003E9__2_6 == null)
				{
					func6 = (Func<CharacterItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CharacterItemData x) => x.unlockCondition_ == CharacterUnlockCondition.Automatic));
				}
				IEnumerable<> enumerable7 = default(IEnumerable<>);
				IEnumerable<CharacterItemData> enumerable8 = (IEnumerable<CharacterItemData>)Enumerable.Where<CharacterItemData>(enumerable7, (Func<, >)(object)func6);
				Func<CharacterItemData, Item> func7 = default(Func<CharacterItemData, Item>);
				if (_003C_003Ec._003C_003E9__2_7 == null)
				{
					func7 = (Func<CharacterItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CharacterItemData x)
					{
						int iD = x.ID;
						throw new NullReferenceException();
					});
				}
				IEnumerable<CharacterItemData> enumerable9 = (IEnumerable<CharacterItemData>)Enumerable.Select<CharacterItemData, Item>((IEnumerable<>)enumerable8, (Func<, >)(object)func7);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable9);
			}
			return hashSet;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B48")]
		[Cpp2IlInjected.Address(RVA = "0x167AC30", Offset = "0x1679630", VA = "0x18167AC30")]
		private static CollectionSetGroup GetNewGroup(CollectionGroup group, HashSet<Item> defaultItems)
		{
			//Discarded unreachable code: IL_002b, IL_0031, IL_0037, IL_003d
			int num = 0;
			CollectionSetGroup collectionSetGroup = new CollectionSetGroup();
			int num2 = 0;
			List<int> itemsInGroup = (List<int>)(object)group.GetItemsInGroup((byte)num2 != 0);
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				MapField<int, bool> groupsCollectionItems_ = collectionSetGroup.groupsCollectionItems_;
			}
			return collectionSetGroup;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B49")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionSetUtils()
		{
		}
	}
}
