using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Mdl.Buildings;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000385")]
	[RequiredAllNotNull]
	public class CookingIngredientsContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000386")]
		public delegate void OnSelectedIngredientsChangedDelegate(IItemData item);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001106")]
		private List<ICookingIngredient> _activePantry = (List<ICookingIngredient>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001107")]
		private ICookingIngredient[] _allIngredientItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001108")]
		private ItemState ingredientState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001109")]
		private ListInventory _pantry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400110A")]
		private CookingStall cookingStall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400110B")]
		public OnSelectedIngredientsChangedDelegate OnSelectedIngredientsChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400110C")]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400110D")]
		[SerializeField]
		private Button _btnNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400110E")]
		[SerializeField]
		private Button _btnPrevious;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400110F")]
		[SerializeField]
		private int currentPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001110")]
		[SerializeField]
		private int totalPages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001111")]
		[Nulllable]
		public SelectedIngredientsContent SelectedIngredientContent;

		[Cpp2IlInjected.Token(Token = "0x4001112")]
		private const int ITEM_IN_PAGE = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001113")]
		[SerializeField]
		private List<CookingIngredientItem> _listIngredients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001114")]
		[SerializeField]
		[ItemID]
		[Header("Cooking tags")]
		[Tooltip("Tag for the quest cooking recipes")]
		[ItemID(ItemType.Tag)]
		private int _cookingQuestTagID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001115")]
		[SerializeField]
		[ItemID]
		[Tooltip("Tag for the golden potato")]
		[ItemID(ItemType.Tag)]
		private int _cookingSecretTagID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001116")]
		private Filter _cookingQuestFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001117")]
		private Filter _cookingSecretFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001118")]
		private bool _showBackpackItems;

		[Cpp2IlInjected.Token(Token = "0x170003D8")]
		public List<ICookingIngredient> ActivePantry
		{
			[Cpp2IlInjected.Token(Token = "0x6001669")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _activePantry;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D9")]
		public ICookingIngredient[] AllIngredientsItem
		{
			[Cpp2IlInjected.Token(Token = "0x600166A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _allIngredientItems;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DA")]
		public ItemState IngredientState
		{
			[Cpp2IlInjected.Token(Token = "0x600166B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return ingredientState;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600166C")]
		[Cpp2IlInjected.Address(RVA = "0x14AABE0", Offset = "0x14A95E0", VA = "0x1814AABE0")]
		public void Init(bool showBackpackItems)
		{
			//Discarded unreachable code: IL_0147, IL_014d, IL_0153, IL_0159, IL_015f, IL_016b
			//IL_007f: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_00d6: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			//IL_00e7: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<CookingIngredientTypeTagItemData, int> _003C_003E9__26_ = _003C_003Ec._003C_003E9__26_0;
			if (_003C_003E9__26_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CookingIngredientTypeTagItemData x) => x.sortPriority_);
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			IOrderedEnumerable<CookingIngredientTypeTagItemData> orderedEnumerable = (IOrderedEnumerable<CookingIngredientTypeTagItemData>)Enumerable.OrderBy<CookingIngredientTypeTagItemData, int>(enumerable, (Func<, >)(object)_003C_003E9__26_);
			IngredientTypeFilter ingredientTypeFilter = default(IngredientTypeFilter);
			int price = default(int);
			if (orderedEnumerable != null)
			{
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					if (num3 == (int)num4)
					{
						goto IL_00a1;
					}
					num3++;
				}
				if (num3 != _cookingQuestTagID)
				{
					while (num3 != _cookingSecretTagID)
					{
					}
					ingredientTypeFilter = new IngredientTypeFilter();
					int num5 = 0;
					((Filter)ingredientTypeFilter).Order = num3;
					ingredientTypeFilter.displayName = (string)num5;
					ingredientTypeFilter.IconAddress = (string)num5;
					price = ((BattlePassReward)num3).Price;
					ingredientTypeFilter.IngredientType = (Item)price;
					_cookingSecretFilter = ingredientTypeFilter;
					goto IL_00a1;
				}
				goto IL_00b2;
			}
			goto IL_00ef;
			IL_00a1:
			ingredientTypeFilter = (IngredientTypeFilter)(object)((object)ingredientTypeFilter + (object)ingredientTypeFilter);
			price += 312;
			goto IL_00b2;
			IL_00ef:
			if (orderedEnumerable != null)
			{
			}
			ListInventory pantry = SystemRoot.Instance.Client.Profile.Pantry;
			if ((object)SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall == null)
			{
			}
			int num6 = 0;
			int num7 = 0;
			bool flag = default(bool);
			Delegate @delegate = default(Delegate);
			if (!flag || (object)@delegate == null || (object)@delegate != null)
			{
				UnityAction a = default(UnityAction);
				SelectedIngredientsContent.OnRemoveIngredientDelegate b = default(SelectedIngredientsContent.OnRemoveIngredientDelegate);
				Delegate delegate2 = Delegate.Combine(a, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
			IL_00b2:
			IngredientTypeFilter ingredientTypeFilter2 = new IngredientTypeFilter();
			int num8 = 0;
			((Filter)ingredientTypeFilter2).Order = num3;
			ingredientTypeFilter2.displayName = (string)num8;
			ingredientTypeFilter2.IconAddress = (string)num8;
			int price2 = ((BattlePassReward)num3).Price;
			ingredientTypeFilter2.IngredientType = (Item)price2;
			_cookingQuestFilter = ingredientTypeFilter2;
			goto IL_00ef;
		}

		[Cpp2IlInjected.Token(Token = "0x600166D")]
		[Cpp2IlInjected.Address(RVA = "0x14ABCC0", Offset = "0x14AA6C0", VA = "0x1814ABCC0")]
		public void RefreshAllIngredient()
		{
			//IL_0016: Expected O, but got I4
			int num = 0;
			ingredientState = (ItemState)num;
			if ((_showBackpackItems ? 1 : 0) == num)
			{
				MapField<int, ListInventory.Types.Data> inventory_ = _pantry.inventory_;
				Func<KeyValuePair<int, ListInventory.Types.Data>, bool> _003C_003E9__27_ = _003C_003Ec._003C_003E9__27_0;
				if (_003C_003E9__27_ == null)
				{
					bool result3 = default(bool);
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, ListInventory.Types.Data> x) => result3);
				}
				IEnumerable<KeyValuePair<int, ListInventory.Types.Data>> enumerable = (IEnumerable<KeyValuePair<int, ListInventory.Types.Data>>)Enumerable.Where<KeyValuePair<int, ListInventory.Types.Data>>((IEnumerable<>)(object)inventory_, (Func<, >)(object)_003C_003E9__27_);
				Func<KeyValuePair<int, ListInventory.Types.Data>, ICookingIngredient> func = default(Func<KeyValuePair<int, ListInventory.Types.Data>, ICookingIngredient>);
				if (_003C_003Ec._003C_003E9__27_1 == null)
				{
					func = (Func<KeyValuePair<int, ListInventory.Types.Data>, ICookingIngredient>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0008
						ItemDatabase _003CInstance_003Ek__BackingField5 = ItemDatabase.Instance;
						ICookingIngredient result2 = default(ICookingIngredient);
						return result2;
					});
				}
				IEnumerable<KeyValuePair<int, ListInventory.Types.Data>> enumerable2 = (IEnumerable<KeyValuePair<int, ListInventory.Types.Data>>)Enumerable.Select<KeyValuePair<int, ListInventory.Types.Data>, ICookingIngredient>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			}
			IItemData _003CItemData_003Ek__BackingField = ((Stall)cookingStall).ItemData;
			CookingStationInteraction cookingStationInteraction = default(CookingStationInteraction);
			if (_003CItemData_003Ek__BackingField != null && _003CItemData_003Ek__BackingField != null && cookingStationInteraction != null)
			{
				bool restrictMealsToCurrentScene_ = cookingStationInteraction.restrictMealsToCurrentScene_;
				ItemState itemState = new ItemState();
				Meta.Online.Client client = default(Meta.Online.Client);
				ProfilePlayer player_ = client.profile.player_;
				ingredientState = itemState;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> cpp2il__autoParamName__idx_ = default(IEnumerable<>);
			RecipeItemData[] allRecipes = cpp2il__autoParamName__idx_.ToArray<RecipeItemData>();
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			Func<ICookingIngredient, bool> func2 = (Func<ICookingIngredient, bool>)(object)new Func<T, TResult>(ShouldUseAsIngredient);
			IEnumerable<> enumerable3 = default(IEnumerable<>);
			IEnumerable<ICookingIngredient> enumerable4 = (IEnumerable<ICookingIngredient>)Enumerable.Where<ICookingIngredient>(enumerable3, (Func<, >)(object)func2);
			Func<ICookingIngredient, int> func3 = default(Func<ICookingIngredient, int>);
			if (_003C_003Ec._003C_003E9__27_2 == null)
			{
				func3 = (Func<ICookingIngredient, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_000d
					ItemDatabase _003CInstance_003Ek__BackingField4 = ItemDatabase.Instance;
					CookingIngredientTypeTagItemData cookingIngredientTypeTagItemData = default(CookingIngredientTypeTagItemData);
					return cookingIngredientTypeTagItemData.sortPriority_;
				});
			}
			IOrderedEnumerable<ICookingIngredient> orderedEnumerable = (IOrderedEnumerable<ICookingIngredient>)Enumerable.OrderBy<ICookingIngredient, int>((IEnumerable<>)enumerable4, (Func<, >)(object)func3);
			Func<ICookingIngredient, string> func4 = default(Func<ICookingIngredient, string>);
			if (_003C_003Ec._003C_003E9__27_3 == null)
			{
				func4 = (Func<ICookingIngredient, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0008
					ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
					string result = default(string);
					return result;
				});
			}
			ICookingIngredient[] array = (_allIngredientItems = ((IEnumerable<>)Enumerable.ThenBy<ICookingIngredient, string>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func4)).ToArray<ICookingIngredient>());
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6001689")]
			[Cpp2IlInjected.Address(RVA = "0xA232E0", Offset = "0xA21CE0", VA = "0x180A232E0")]
			bool ShouldUseAsIngredient(ICookingIngredient ingredient)
			{
				_003C_003Ec__DisplayClass27_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_1();
				CS_0024_003C_003E8__locals0.ingredient = ingredient;
				ICookingIngredient ingredient2 = CS_0024_003C_003E8__locals0.ingredient;
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
				if (CS_0024_003C_003E8__locals0 != null)
				{
					Profile profile = SystemRoot.Instance.Client.Profile;
					ICookingIngredient ingredient3 = CS_0024_003C_003E8__locals0.ingredient;
					ProfilePlayer player_2 = profile.player_;
					CookingIngredientsContent cookingIngredientsContent = this;
					int num4 = default(int);
					if (num4 > 0)
					{
						if (CS_0024_003C_003E8__locals0.ingredient != null && num4 == 0)
						{
							throw new InvalidCastException();
						}
						bool flag = default(bool);
						Predicate<RecipeItemData> predicate = default(Predicate<RecipeItemData>);
						if (flag)
						{
							RecipeItemData[] array2 = allRecipes;
							predicate = (Predicate<RecipeItemData>)(object)(Predicate<T>)delegate(RecipeItemData x)
							{
								//Discarded unreachable code: IL_002e
								RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = x.ingredients_;
								Func<RecipeItemData.Types.Ingredient, bool> _003C_003E9__ = CS_0024_003C_003E8__locals0._003C_003E9__6;
								if (_003C_003E9__ == null)
								{
									Func<RecipeItemData.Types.Ingredient, bool> func5 = (CS_0024_003C_003E8__locals0._003C_003E9__6 = (Func<RecipeItemData.Types.Ingredient, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData.Types.Ingredient x)
									{
										Item? item = (Item?)x.get_Item();
										ICookingIngredient ingredient4 = CS_0024_003C_003E8__locals0.ingredient;
										int num5 = 0;
										throw new NullReferenceException();
									});
								}
								return ((IEnumerable<>)(object)ingredients_).Any<RecipeItemData.Types.Ingredient>((Func<, >)(object)_003C_003E9__);
							};
							RecipeItemData recipeItemData = default(RecipeItemData);
							if (recipeItemData == null)
							{
								goto IL_008a;
							}
						}
						predicate += predicate;
					}
				}
				goto IL_008a;
				IL_008a:
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600166E")]
		[Cpp2IlInjected.Address(RVA = "0x14AB4F0", Offset = "0x14A9EF0", VA = "0x1814AB4F0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_008f
			int num = 0;
			Button.ButtonClickedEvent onClick = _btnNext.m_OnClick;
			UnityAction call = OnNextClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnPrevious.m_OnClick;
			UnityAction call2 = OnPrevoiusClickHandler;
			onClick2.RemoveListener(call2);
			CookingStall cookingStall = this.cookingStall;
			EventHandler<Item> eventHandler = (EventHandler<Item>)(object)new EventHandler<TEventArgs>(AddIngredientHandler);
			cookingStall.remove_IngredientEnteredPotEvent((EventHandler<>)(object)eventHandler);
			List<CookingIngredientItem> listIngredients = _listIngredients;
			bool flag = default(bool);
			if (flag)
			{
				Action<Item> action = (Action<Item>)(object)new Action<T>(OnIngredientSelected);
				Delegate @delegate = default(Delegate);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600166F")]
		[Cpp2IlInjected.Address(RVA = "0x14ABB30", Offset = "0x14AA530", VA = "0x1814ABB30")]
		private void OnNextClickHandler()
		{
			RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x6001670")]
		[Cpp2IlInjected.Address(RVA = "0x14ABB40", Offset = "0x14AA540", VA = "0x1814ABB40")]
		private void OnPrevoiusClickHandler()
		{
			RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x6001671")]
		[Cpp2IlInjected.Address(RVA = "0x14ABB50", Offset = "0x14AA550", VA = "0x1814ABB50")]
		internal void RefreshActivePantry(Filter filter)
		{
			//Discarded unreachable code: IL_0072
			//IL_0014: Expected I4, but got I8
			((List<T>)(object)_activePantry).Clear();
			currentPage = 0;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			bool flag = default(bool);
			if (flag)
			{
				Filter cookingSecretFilter = _cookingSecretFilter;
				bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)cookingSecretFilter);
			}
			int num = 0;
			ICookingIngredient[] allIngredientItems = _allIngredientItems;
			int num2 = 0;
			List<> list = (List<>)(object)(_activePantry = (List<ICookingIngredient>)(object)FilterUtil.Filter<ICookingIngredient>((IEnumerable<>)(object)allIngredientItems, (IEnumerable<>)hashSet, (FilterUtil.FilterCombineMode)num2, (FilterUtil.FilterCombineMode)num));
			List<ICookingIngredient> activePantry = _activePantry;
			float f = default(float);
			int num3 = (totalPages = Mathf.CeilToInt(f));
			RefreshList();
		}

		[Cpp2IlInjected.Token(Token = "0x6001672")]
		[Cpp2IlInjected.Address(RVA = "0x14AC8D0", Offset = "0x14AB2D0", VA = "0x1814AC8D0")]
		private void RefreshList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001673")]
		[Cpp2IlInjected.Address(RVA = "0x14AB8E0", Offset = "0x14AA2E0", VA = "0x1814AB8E0")]
		public void OnIngredientSelected(Item item)
		{
			//Discarded unreachable code: IL_0069
			int itemID = item.ItemID;
			if (CanvasGroup.interactable)
			{
				if (Enumerable.Count<Item>(SelectedIngredientContent.get_SelectedIngredientList()) < 5)
				{
					CancellationToken cancellationToken = GetComponentInParent<Menu>().CancellationToken;
					int num = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				else
				{
					int num2 = 0;
					GenericAlert genericAlert = UiRoot.Instance._genericAlert;
					int skipLocManager = 0;
					int showCloseButton = 0;
					genericAlert.Alert("cooking.cooking_ingredient_number_exeeded_desc", "cooking.cooking_ingredient_number_exeeded_title", (byte)showCloseButton != 0, (byte)skipLocManager != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001674")]
		[Cpp2IlInjected.Address(RVA = "0x14AA140", Offset = "0x14A8B40", VA = "0x1814AA140")]
		[AsyncStateMachine(typeof(_003CAddIngredientAutomaticallyTask_003Ed__34))]
		public Task AddIngredientAutomaticallyTask(Item item, CancellationToken ct, bool animate = false)
		{
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001675")]
		[Cpp2IlInjected.Address(RVA = "0x14AA380", Offset = "0x14A8D80", VA = "0x1814AA380")]
		[AsyncStateMachine(typeof(_003CAddIngredientTask_003Ed__35))]
		private Task AddIngredientTask(Item item, CancellationToken ct)
		{
			int itemID = item.ItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001676")]
		[Cpp2IlInjected.Address(RVA = "0x14AB7C0", Offset = "0x14AA1C0", VA = "0x1814AB7C0")]
		private void OnIngredientRemoved(Item removedIngredient, bool animate = true)
		{
			//Discarded unreachable code: IL_0026
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			CookingStall cookingStall = this.cookingStall;
			RefreshInventoryAmounts();
			IItemData item = default(IItemData);
			OnSelectedIngredientsChanged?.Invoke(item);
		}

		[Cpp2IlInjected.Token(Token = "0x6001677")]
		[Cpp2IlInjected.Address(RVA = "0x14AA270", Offset = "0x14A8C70", VA = "0x1814AA270")]
		private void AddIngredientHandler(object sender, Item item)
		{
			//Discarded unreachable code: IL_0026
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			SelectedIngredientsContent selectedIngredientContent = SelectedIngredientContent;
			RefreshInventoryAmounts();
			IItemData item2 = default(IItemData);
			OnSelectedIngredientsChanged?.Invoke(item2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001678")]
		[Cpp2IlInjected.Address(RVA = "0x14AC460", Offset = "0x14AAE60", VA = "0x1814AC460")]
		private void RefreshButtons()
		{
			//Discarded unreachable code: IL_003c
			GameObject gameObject = _btnNext.gameObject;
			int num = totalPages;
			bool active = currentPage < num;
			gameObject.SetActive(active);
			Button btnPrevious = _btnPrevious;
			int active2 = 0;
			btnPrevious.gameObject.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001679")]
		[Cpp2IlInjected.Address(RVA = "0x14AC4D0", Offset = "0x14AAED0", VA = "0x1814AC4D0")]
		private void RefreshInventoryAmounts()
		{
			//Discarded unreachable code: IL_00b8, IL_00be, IL_00c4, IL_00ca, IL_00d0, IL_00d6, IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106, IL_010c
			//IL_001f: Expected O, but got I4
			bool flag = default(bool);
			Mdl.Online.Client client = default(Mdl.Online.Client);
			bool flag2 = default(bool);
			string text = default(string);
			while (true)
			{
				int num = 0;
				List<CookingIngredientItem> listIngredients = _listIngredients;
				if (!flag)
				{
					break;
				}
				CookingIngredientItem item = (CookingIngredientItem)0;
				if (item.ItemData != null)
				{
					if (_showBackpackItems)
					{
						ProfilePlayer player_ = client.Profile.player_;
						IItemData itemData = item.ItemData;
					}
					ListInventory pantry = _pantry;
					if (flag2)
					{
					}
					IEnumerable<Item> selectedIngredientList = (IEnumerable<Item>)SelectedIngredientContent.get_SelectedIngredientList();
					Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
					{
						IItemData itemData2 = item.ItemData;
						throw new NullReferenceException();
					};
					int num2 = Enumerable.Count<Item>((IEnumerable<>)selectedIngredientList, (Func<, >)(object)func);
					TextBase amountTextAsset = item.AmountTextAsset;
					num -= num2;
					amountTextAsset.Text = text;
					if ((object)item.AmountTextAsset.transform == null)
					{
					}
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600167A")]
		[Cpp2IlInjected.Address(RVA = "0x14AA490", Offset = "0x14A8E90", VA = "0x1814AA490")]
		public List<ICookingIngredient> GetAvailableIngredients()
		{
			//Discarded unreachable code: IL_00dc
			List<ICookingIngredient> list = (List<ICookingIngredient>)(object)new List<T>();
			ICookingIngredient[] allIngredientItems = _allIngredientItems;
			int num = 0;
			int num2 = 0;
			if (num < allIngredientItems.Length)
			{
				num = num2;
				ICookingIngredient item = allIngredientItems[num2];
				ICookingIngredient cookingIngredient = item;
				bool flag = default(bool);
				if (flag)
				{
					if (_showBackpackItems)
					{
						Mdl.Online.Client client = default(Mdl.Online.Client);
						Profile profile = client.Profile;
						ICookingIngredient cookingIngredient2 = item;
						ProfilePlayer player_ = profile.player_;
					}
					ICookingIngredient cookingIngredient3 = item;
					ListInventory pantry = _pantry;
					bool flag2 = default(bool);
					if (flag2)
					{
					}
					int num3 = 0;
					IEnumerable<Item> selectedIngredientList = (IEnumerable<Item>)SelectedIngredientContent.get_SelectedIngredientList();
					Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000d
						//IL_000d: Expected I4, but got O
						ICookingIngredient cookingIngredient4 = item;
						return (byte)(int)typeof(Item).TypeHandle != 0;
					};
					int num4 = Enumerable.Count<Item>((IEnumerable<>)selectedIngredientList, (Func<, >)(object)func);
					num3 -= num4;
					if (num3 > 0)
					{
						ICookingIngredient item2 = item;
						((List<T>)(object)list).Add((T)item2);
					}
				}
				num2++;
				num = num2;
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x600167B")]
		[Cpp2IlInjected.Address(RVA = "0x14AA7F0", Offset = "0x14A91F0", VA = "0x1814AA7F0")]
		public RectTransform GetNextIngredientForTutorial()
		{
			//Discarded unreachable code: IL_00af, IL_00b5, IL_00bb, IL_00c1, IL_00c7, IL_00cd, IL_00d3, IL_00d9, IL_00df, IL_00e5, IL_00eb, IL_00f1, IL_00f7
			//IL_001f: Expected O, but got I4
			int num = 0;
			List<CookingIngredientItem> listIngredients = _listIngredients;
			bool flag = default(bool);
			if (flag)
			{
				CookingIngredientItem item = (CookingIngredientItem)0;
				if (_showBackpackItems)
				{
					Mdl.Online.Client client = default(Mdl.Online.Client);
					ProfilePlayer player_ = client.Profile.player_;
					IItemData itemData = item.ItemData;
				}
				ListInventory pantry = _pantry;
				IItemData itemData2 = item.ItemData;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				IEnumerable<Item> selectedIngredientList = (IEnumerable<Item>)SelectedIngredientContent.get_SelectedIngredientList();
				Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
				{
					IItemData itemData3 = item.ItemData;
					throw new NullReferenceException();
				};
				int num2 = Enumerable.Count<Item>((IEnumerable<>)selectedIngredientList, (Func<, >)(object)func);
				while (num <= num2)
				{
				}
				if ((object)item.transform != null)
				{
				}
				num++;
			}
			if (num + 1 != 0)
			{
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600167C")]
		[Cpp2IlInjected.Address(RVA = "0x14AD020", Offset = "0x14ABA20", VA = "0x1814AD020")]
		public CookingIngredientsContent()
		{
		}
	}
}
