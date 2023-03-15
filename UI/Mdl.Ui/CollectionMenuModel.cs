using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Systems;
using Meta.Collections;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002F5")]
	public class CollectionMenuModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E63")]
		private IEnumerable<IGrouping<CollectionSubMenu, CollectionInfo>> _collectionInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000E64")]
		public Dictionary<CollectionSubMenu, CollectionModel> CollectionModels = (Dictionary<CollectionSubMenu, CollectionModel>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E65")]
		public Action<CollectionItem, bool> OnTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000E66")]
		public Action OnTooltipPart2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E67")]
		public Action OnSkinShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E68")]
		public Action<CollectionItem> OnMemoryShards;

		[Cpp2IlInjected.Token(Token = "0x600132E")]
		[Cpp2IlInjected.Address(RVA = "0x113BA60", Offset = "0x113A460", VA = "0x18113BA60")]
		internal unsafe void RefreshData()
		{
			//Discarded unreachable code: IL_037e, IL_0386, IL_0387, IL_038d, IL_0393, IL_0399, IL_039f, IL_03a5, IL_03ab, IL_03b1, IL_03b7, IL_03bd, IL_03c3, IL_03c9, IL_03cf, IL_03d5, IL_03db, IL_03e7, IL_03f3, IL_03f9, IL_03ff, IL_0405, IL_040b, IL_0411, IL_0417, IL_041d, IL_0423, IL_0435, IL_043b, IL_0441, IL_0447, IL_044d, IL_0453, IL_0459
			//IL_009a: Expected I4, but got O
			//IL_0134: Expected F4, but got I4
			//IL_012f: Expected native int or pointer, but got O
			//IL_01e1: Expected F4, but got I4
			//IL_01dc: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if ((IntPtr)_collectionInfos == (IntPtr)num2)
			{
				List<CollectionInfo> collectionsInfo = (List<CollectionInfo>)(object)SystemRoot.Instance.MetaClient.profile.player_.GetCollectionsInfo();
				Func<CollectionInfo, CollectionSubMenu> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
				if (_003C_003E9__6_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CollectionInfo x) => x.Submenu);
				}
				IEnumerable<> enumerable = (IEnumerable<>)(_collectionInfos = (IEnumerable<IGrouping<CollectionSubMenu, CollectionInfo>>)Enumerable.GroupBy<CollectionInfo, CollectionSubMenu>((IEnumerable<>)collectionsInfo, (Func<, >)(object)_003C_003E9__6_));
			}
			((Dictionary<TKey, TValue>)(object)CollectionModels).Clear();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<IGrouping<CollectionSubMenu, CollectionInfo>> collectionInfos = _collectionInfos;
			CollectionModel collectionModel = new CollectionModel();
			collectionModel.CollectionItemTab = (CollectionSubMenu)(collectionModel.CollectionGroupModels = (List<CollectionItemGroupModel>)(object)new List<T>());
			CollectionItemGroupModel collectionItemGroupModel = new CollectionItemGroupModel();
			collectionItemGroupModel.MenuModel = this;
			Vector2 vector2 = default(Vector2);
			List<CollectionItemModel> list3 = default(List<CollectionItemModel>);
			if (collectionItemGroupModel != null)
			{
				CollectionSetItemData _003CCollectionSetItemData_003Ek__BackingField = default(CollectionSetItemData);
				collectionItemGroupModel.CollectionSetItemData = _003CCollectionSetItemData_003Ek__BackingField;
				List<CollectionInfo> _003CCollectionInfos_003Ek__BackingField = collectionItemGroupModel.CollectionInfos;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					if (flag2)
					{
						if (collectionItemGroupModel.CollectionSetItemData.submenu_ > CollectionSubMenu.Fish)
						{
							List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField = collectionItemGroupModel.CollectionItemModels;
							CollectionItemModel collectionItemModel = new CollectionItemModel();
							collectionItemModel.MenuModel = this;
							collectionItemModel.IsCollected = false;
							if (collectionItemGroupModel.CollectionSetItemData.submenu_ == CollectionSubMenu.FurnitureSets)
							{
							}
							int num5 = 0;
							Vector2 vector = (collectionItemModel.IconScale = Vector2.one);
							((Vector2*)(IntPtr)collectionItemModel.IconScale)->y = 0f;
							int num6 = (collectionItemModel.SetSortPriority = collectionItemGroupModel.CollectionSetItemData.sortPriority_);
							((List<T>)(object)_003CCollectionItemModels_003Ek__BackingField).Add((T)collectionItemModel);
							if (collectionItemGroupModel.CollectionSetItemData.submenu_ == CollectionSubMenu.Characters)
							{
								CollectionItemModel collectionItemModel2 = ((IEnumerable<>)collectionItemGroupModel.CollectionItemModels).Last<CollectionItemModel>();
								CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
								if (collectionItemModel2 != null && characterInstance != null)
								{
									int num7 = (collectionItemModel2.CharLevel = characterInstance.MetaCharacter.friendshipLevel_);
								}
							}
						}
						List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField2 = collectionItemGroupModel.CollectionItemModels;
						CollectionItemModel collectionItemModel3 = new CollectionItemModel();
						collectionItemModel3.MenuModel = this;
						collectionItemModel3.IsCollected = false;
						if (collectionItemGroupModel.CollectionSetItemData.submenu_ == CollectionSubMenu.FurnitureSets)
						{
						}
						int num8 = 0;
						vector2 = (collectionItemModel3.IconScale = Vector2.one);
						((Vector2*)(IntPtr)collectionItemModel3.IconScale)->y = 0f;
						int num9 = (collectionItemModel3.SetSortPriority = collectionItemGroupModel.CollectionSetItemData.sortPriority_);
						((List<T>)(object)_003CCollectionItemModels_003Ek__BackingField2).Add((T)collectionItemModel3);
					}
					if ((object)vector2 != null)
					{
						throw new NullReferenceException();
					}
				}
				if ((object)vector2 != null)
				{
					throw new NullReferenceException();
				}
				bool flag3 = ((List<T>)(object)collectionModel.CollectionGroupModels).Contains((T)collectionItemGroupModel);
				if (!flag3)
				{
					((List<T>)(object)collectionModel.CollectionGroupModels).Add((T)collectionItemGroupModel);
				}
				int num10 = 0;
				CollectionItemGroupModel collectionItemGroupModel2 = default(CollectionItemGroupModel);
				if ((flag3 ? 1 : 0) <= (true ? 1 : 0))
				{
					List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField3 = collectionItemGroupModel.CollectionItemModels;
					Func<CollectionItemModel, string> func = default(Func<CollectionItemModel, string>);
					if (_003C_003Ec._003C_003E9__6_2 == null)
					{
						func = (Func<CollectionItemModel, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CollectionItemModel x)
						{
							IItemData _003CItemData_003Ek__BackingField3 = ((ItemSlotModel)x).ItemData;
							throw new NullReferenceException();
						});
					}
					List<CollectionItemModel> list = (collectionItemGroupModel.CollectionItemModels = (List<CollectionItemModel>)(object)Enumerable.ToList<CollectionItemModel>((IEnumerable<>)Enumerable.OrderBy<CollectionItemModel, string>((IEnumerable<>)_003CCollectionItemModels_003Ek__BackingField3, (Func<, >)(object)func)));
					collectionItemGroupModel2 = new CollectionItemGroupModel();
				}
				List<CollectionItemModel> list2 = (collectionItemGroupModel2.CollectionItemModels = (List<CollectionItemModel>)(object)Enumerable.ToList<CollectionItemModel>(CollectionMenuModel.SortItemByPriorityAndLocalizedName((IEnumerable<>)collectionItemGroupModel2.CollectionItemModels)));
				List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField4 = collectionItemGroupModel2.CollectionItemModels;
				Func<CollectionItemModel, bool> func2 = default(Func<CollectionItemModel, bool>);
				if (_003C_003Ec._003C_003E9__6_1 == null)
				{
					func2 = (Func<CollectionItemModel, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CollectionItemModel x)
					{
						//Discarded unreachable code: IL_0016
						int num13 = 0;
						RedDotHelper redDotHelper2 = UiRoot.Instance.RedDotHelper;
						IItemData _003CItemData_003Ek__BackingField2 = ((ItemSlotModel)x).ItemData;
						bool result3 = default(bool);
						return result3;
					});
				}
				list3 = (collectionItemGroupModel2.CollectionItemModels = (List<CollectionItemModel>)(object)Enumerable.ToList<CollectionItemModel>((IEnumerable<>)Enumerable.OrderByDescending<CollectionItemModel, bool>((IEnumerable<>)_003CCollectionItemModels_003Ek__BackingField4, (Func<, >)(object)func2)));
			}
			if (collectionItemGroupModel != null)
			{
			}
			if ((object)vector2 == null)
			{
				int num11 = 0;
				if ((long)list3 <= 10)
				{
					List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField = collectionModel.CollectionGroupModels;
					Comparison<CollectionItemGroupModel> comparison = default(Comparison<CollectionItemGroupModel>);
					if (_003C_003Ec._003C_003E9__6_3 == null)
					{
						comparison = (Comparison<CollectionItemGroupModel>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Comparison<T>)delegate(CollectionItemGroupModel x, CollectionItemGroupModel y)
						{
							//Discarded unreachable code: IL_001a
							int sortPriority_ = x.CollectionSetItemData.sortPriority_;
							int sortPriority_2 = y.CollectionSetItemData.sortPriority_;
							int result2 = default(int);
							return result2;
						});
					}
					((List<T>)(object)_003CCollectionGroupModels_003Ek__BackingField).Sort((Comparison<>)(object)comparison);
					List<CollectionItemGroupModel> _003CCollectionGroupModels_003Ek__BackingField2 = collectionModel.CollectionGroupModels;
					bool flag4 = default(bool);
					if (flag4)
					{
						IEnumerable<CollectionItemModel> enumerable2 = default(IEnumerable<CollectionItemModel>);
						List<CollectionItemModel> list4 = (List<CollectionItemModel>)(object)Enumerable.ToList<CollectionItemModel>((IEnumerable<>)enumerable2);
						if (_003C_003Ec._003C_003E9__6_4 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CollectionItemModel x)
							{
								//Discarded unreachable code: IL_0016
								int num12 = 0;
								RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
								IItemData _003CItemData_003Ek__BackingField = ((ItemSlotModel)x).ItemData;
								bool result = default(bool);
								return result;
							};
						}
						IOrderedEnumerable<CollectionItemModel> orderedEnumerable = default(IOrderedEnumerable<CollectionItemModel>);
						List<CollectionItemModel> list5 = (List<CollectionItemModel>)(object)Enumerable.ToList<CollectionItemModel>((IEnumerable<>)orderedEnumerable);
					}
					if ((object)vector2 != null)
					{
						throw new NullReferenceException();
					}
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600132F")]
		[Cpp2IlInjected.Address(RVA = "0x113CD30", Offset = "0x113B730", VA = "0x18113CD30")]
		internal void Release()
		{
			//Discarded unreachable code: IL_000c
			((Dictionary<TKey, TValue>)(object)CollectionModels).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6001330")]
		[Cpp2IlInjected.Address(RVA = "0x113CD80", Offset = "0x113B780", VA = "0x18113CD80")]
		private static IEnumerable<CollectionItemModel> SortItemByPriorityAndLocalizedName(IEnumerable<CollectionItemModel> data)
		{
			Func<CollectionItemModel, SortItem> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_0;
			if (_003C_003E9__8_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CollectionItemModel x)
				{
					//Discarded unreachable code: IL_001d
					SortItem sortItem = new SortItem();
					IItemData _003CItemData_003Ek__BackingField = ((ItemSlotModel)x).ItemData;
					sortItem.StringId = (string)(object)sortItem;
					sortItem.ItemModel = x;
					return sortItem;
				};
			}
			IEnumerable<CollectionItemModel> enumerable = (IEnumerable<CollectionItemModel>)Enumerable.Select<CollectionItemModel, SortItem>((IEnumerable<>)data, (Func<, >)(object)_003C_003E9__8_);
			Func<SortItem, int> func = default(Func<SortItem, int>);
			if (_003C_003Ec._003C_003E9__8_1 == null)
			{
				func = (Func<SortItem, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SortItem x) => x.ItemModel.SetSortPriority));
			}
			IOrderedEnumerable<SortItem> orderedEnumerable = (IOrderedEnumerable<SortItem>)Enumerable.OrderBy<SortItem, int>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			Func<SortItem, string> func2 = default(Func<SortItem, string>);
			if (_003C_003Ec._003C_003E9__8_2 == null)
			{
				func2 = (Func<SortItem, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SortItem x) => x.GetLocalizedString()));
			}
			IOrderedEnumerable<SortItem> orderedEnumerable2 = (IOrderedEnumerable<SortItem>)Enumerable.ThenBy<SortItem, string>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func2);
			Func<SortItem, CollectionItemModel> func3 = default(Func<SortItem, CollectionItemModel>);
			if (_003C_003Ec._003C_003E9__8_3 == null)
			{
				func3 = (Func<SortItem, CollectionItemModel>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SortItem x) => x.ItemModel));
			}
			return (IEnumerable<CollectionItemModel>)Enumerable.Select<SortItem, CollectionItemModel>((IEnumerable<>)orderedEnumerable2, (Func<, >)(object)func3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001331")]
		[Cpp2IlInjected.Address(RVA = "0x113B470", Offset = "0x1139E70", VA = "0x18113B470")]
		private void DebugItemSort()
		{
			//Discarded unreachable code: IL_0099, IL_00b7, IL_00bd, IL_00c3, IL_00c9, IL_00cf, IL_00d5, IL_00db, IL_00e1, IL_00e7
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int stackTraceType = 0;
			Application.SetStackTraceLogType(LogType.Log, (StackTraceLogType)stackTraceType);
			Debug.Log(" --- BEGIN SORT DEBUG ---");
			Dictionary<CollectionSubMenu, CollectionModel> collectionModels = CollectionModels;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			if (flag && flag2 && flag3)
			{
				object[] array = new object[4];
				if (array == null)
				{
					throw new IndexOutOfRangeException();
				}
				if (array != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[1] = array;
				if (array != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[2] = array;
				string text = default(string);
				if (text != null && text == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[3] = text;
				Debug.Log(string.Format(" --- Set Name {0}, Sort priority: {1}, Item Type: {2}, Item Localized Name: {3}", array));
			}
			Debug.Log(" --- END SORT DEBUG ---");
		}

		[Cpp2IlInjected.Token(Token = "0x6001332")]
		[Cpp2IlInjected.Address(RVA = "0x113D170", Offset = "0x113BB70", VA = "0x18113D170")]
		public CollectionMenuModel()
		{
		}
	}
}
