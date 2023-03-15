using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003C3")]
	[RequiredAllNotNull]
	public class SelectedRecipeContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003C4")]
		public delegate void OnClickDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001263")]
		public OnClickDelegate OnRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001264")]
		public OnClickDelegate OnClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001265")]
		public OnClickDelegate OnHistoryOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001266")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001267")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001268")]
		[SerializeField]
		private RectTransform _listIngredients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001269")]
		[SerializeField]
		private RecipeIngredientItem _ingredientPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400126A")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400126B")]
		[SerializeField]
		private StarComponent _mcStar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400126C")]
		[SerializeField]
		private GameObject _questMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400126D")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400126E")]
		[Nulllable]
		[SerializeField]
		private CookingStation _mcCookingStation;

		[Cpp2IlInjected.Token(Token = "0x170003FE")]
		public RecipeItemData RecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60017EB")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CRecipeItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60017EC")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			internal set
			{
				_003CRecipeItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017ED")]
		[Cpp2IlInjected.Address(RVA = "0x125F370", Offset = "0x125DD70", VA = "0x18125F370")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0041
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = button.m_OnClick;
			UnityAction call2 = OnClickHandler;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60017EE")]
		[Cpp2IlInjected.Address(RVA = "0x125F560", Offset = "0x125DF60", VA = "0x18125F560")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0041
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = button.m_OnClick;
			UnityAction call2 = OnClickHandler;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60017EF")]
		[Cpp2IlInjected.Address(RVA = "0xF182C0", Offset = "0xF16CC0", VA = "0x180F182C0")]
		private void OnHistoryClickHandler()
		{
			OnHistoryOpen?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F0")]
		[Cpp2IlInjected.Address(RVA = "0xF182A0", Offset = "0xF16CA0", VA = "0x180F182A0")]
		private void OnClickHandler()
		{
			OnClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F1")]
		[Cpp2IlInjected.Address(RVA = "0x125F520", Offset = "0x125DF20", VA = "0x18125F520")]
		internal void OnCloseClickHandler()
		{
			//IL_0009: Expected O, but got I8
			RecipeItemData = (RecipeItemData)0;
			OnRemove?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F2")]
		[Cpp2IlInjected.Address(RVA = "0x125F460", Offset = "0x125DE60", VA = "0x18125F460")]
		public bool IsAllIngredientsAdded()
		{
			if ((long)RecipeItemData != 0)
			{
				RectTransform listIngredients = _listIngredients;
				int num = 0;
				int childCount = listIngredients.childCount;
				if (num < childCount)
				{
					if (!_listIngredients.GetChild(num).GetComponent<RecipeIngredientItem>().IsAdded)
					{
						goto IL_0045;
					}
					RectTransform listIngredients2 = _listIngredients;
					num++;
				}
				return true;
			}
			goto IL_0045;
			IL_0045:
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017F3")]
		[Cpp2IlInjected.Address(RVA = "0x125F660", Offset = "0x125E060", VA = "0x18125F660")]
		public void RefreshCheckmarks()
		{
			//Discarded unreachable code: IL_00a3, IL_00a9, IL_00af, IL_00b5, IL_00bb
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			List<RecipeIngredientItem> list = (List<RecipeIngredientItem>)(object)new List<T>();
			int childCount = _listIngredients.childCount;
			if (num3 < childCount)
			{
				RecipeIngredientItem component = _listIngredients.GetChild(num3).GetComponent<RecipeIngredientItem>();
				((List<T>)(object)list).Add((T)component);
				num3++;
				RectTransform listIngredients = _listIngredients;
			}
			Func<RecipeIngredientItem, bool> func = default(Func<RecipeIngredientItem, bool>);
			if (_003C_003Ec._003C_003E9__23_0 == null)
			{
				func = (Func<RecipeIngredientItem, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RecipeIngredientItem recipeIngredientItem) => recipeIngredientItem.Ingredient.ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID));
			}
			List<RecipeIngredientItem> list2 = (List<RecipeIngredientItem>)(object)Enumerable.ToList<RecipeIngredientItem>((IEnumerable<>)Enumerable.OrderByDescending<RecipeIngredientItem, bool>((IEnumerable<>)list, (Func<, >)(object)func));
			List<Item> list3 = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)_mcCookingStation.CookingStall.selectedIngredients);
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
					num3++;
				}
				((List<T>)(object)list3).RemoveAt(num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017F4")]
		[Cpp2IlInjected.Address(RVA = "0x125FA30", Offset = "0x125E430", VA = "0x18125FA30")]
		public void RefreshCounter(IItemData itemData, int added)
		{
			//Discarded unreachable code: IL_0061
			//IL_0031: Expected O, but got I4
			RectTransform listIngredients = _listIngredients;
			int num = 0;
			int childCount = listIngredients.childCount;
			if (num < childCount)
			{
				RecipeIngredientItem component = _listIngredients.GetChild(num).GetComponent<RecipeIngredientItem>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2 && component.IngredientItemData == itemData)
				{
					int num3 = (component.IngredientAddedCount = Mathf.Max(0, added));
					component.RefreshDisplay();
				}
				RectTransform listIngredients2 = _listIngredients;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017F5")]
		[Cpp2IlInjected.Address(RVA = "0x125FB60", Offset = "0x125E560", VA = "0x18125FB60")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0241, IL_0253
			//IL_0056: Expected O, but got I4
			//IL_0073: Expected I4, but got I8
			int num = 0;
			if ((IntPtr)RecipeItemData == (IntPtr)num)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int resultItemID = RecipeItemData.ResultItemID;
			MealItemData mealItemData = default(MealItemData);
			MealItemData mealdata = mealItemData;
			TextBase tfName = _tfName;
			MealItemData mealItemData2 = mealdata;
			int num2 = 0;
			string text2 = (tfName.Text = LocalizationManager.FromStringID(mealItemData2.displayName_, (IResolver)num2));
			ulong num3 = default(ulong);
			_mcIcon.gameObject.SetActive((byte)num3 != 0);
			AsyncAtlassedIcon mcIcon = _mcIcon;
			string iconAddress_ = mealdata.iconAddress_;
			bool flag = mcIcon.SetIcon(iconAddress_);
			StarComponent mcStar = _mcStar;
			int num4 = (mcStar.Star = mealdata.starRating_);
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)_mcCookingStation.CookingStall.selectedIngredients);
			IEnumerator enumerator = _listIngredients.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num6 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			int num7 = 0;
			if ((object)gameObject != null)
			{
			}
			int i = num7;
			int num8 = default(int);
			if (num7 >= num8)
			{
				return;
			}
			RecipeIngredientItem recipeIngredientItem = default(RecipeIngredientItem);
			Transform transform = recipeIngredientItem.transform;
			int num9 = 0;
			Vector2 zero = Vector2.zero;
			int num10 = i;
			RecipeItemData.Types.Ingredient ingredient = default(RecipeItemData.Types.Ingredient);
			recipeIngredientItem.Ingredient = ingredient;
			RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient.ingredientCase_;
			if (ingredient == null)
			{
				goto IL_01b2;
			}
			if (ingredient == null)
			{
				goto IL_019d;
			}
			if (ingredient == null)
			{
				goto IL_0182;
			}
			if (ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
			{
				Func<ICookingIngredient, bool> func = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate(ICookingIngredient x)
				{
					//Discarded unreachable code: IL_0032
					RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = RecipeItemData.ingredients_;
					int index = i;
					Item[] tags = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_)[index]).Tags;
					return ItemDataExtensions.HasAllTags((IHasTags)x, (IEnumerable<>)(object)tags);
				};
				IEnumerable<> enumerable = default(IEnumerable<>);
				if (Enumerable.FirstOrDefault<ICookingIngredient>(Enumerable.Where<ICookingIngredient>(enumerable, (Func<, >)(object)func)) != null)
				{
					goto IL_0182;
				}
			}
			goto IL_01d0;
			IL_019d:
			int num11 = 0;
			int num12 = i;
			RecipeItemData.Types.Ingredient ingredient2 = default(RecipeItemData.Types.Ingredient);
			Item? anyItem = (Item?)ingredient2.get_AnyItem();
			goto IL_01b2;
			IL_01d0:
			recipeIngredientItem.IsAdded = false;
			Client client = default(Client);
			IEnumerable<ProfileWorld.FilterInfo> filtersMealInfo = (IEnumerable<ProfileWorld.FilterInfo>)client.profile.world_.GetFiltersMealInfo();
			Func<ProfileWorld.FilterInfo, bool> func2 = default(Func<ProfileWorld.FilterInfo, bool>);
			Func<ProfileWorld.FilterInfo, bool> cpp2il__autoParamName__idx_ = default(Func<ProfileWorld.FilterInfo, bool>);
			if (func2 == null)
			{
				cpp2il__autoParamName__idx_ = (func2 = (Func<ProfileWorld.FilterInfo, bool>)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo x)
				{
					//Discarded unreachable code: IL_002e
					List<MissionObjective> _003CObjectives_003Ek__BackingField = x.Objectives;
					Func<MissionObjective, bool> func3 = default(Func<MissionObjective, bool>);
					Func<MissionObjective, bool> func4 = func3;
					if (func4 == null)
					{
						func3 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
						{
							//IL_0036: Expected O, but got I4
							ItemFilter itemFilter_ = obj.itemFilter_;
							if (itemFilter_ != null && (long)itemFilter_.data_ != 0)
							{
								(Item, ItemState)[] array = new(Item, ItemState)[1];
								int iD = mealdata.ID;
								int num18 = 0;
								int num19 = 0;
								((ValueTuple<, >[])(object)array)[0] = (ValueTuple<, >)num18;
								return Enumerable.Any<(Item, ItemState)>((IEnumerable<>)itemFilter_.ApplyFilter((IEnumerable<>)(object)array));
							}
							int num20 = 0;
							throw new NullReferenceException();
						};
					}
					return ((IEnumerable<>)_003CObjectives_003Ek__BackingField).Any<MissionObjective>((Func<, >)(object)func4);
				});
			}
			bool flag2 = ((IEnumerable<>)filtersMealInfo).Any<ProfileWorld.FilterInfo>((Func<, >)(object)cpp2il__autoParamName__idx_);
			recipeIngredientItem.RefreshDisplay();
			Transform transform2 = recipeIngredientItem.transform.transform;
			int num13 = 0;
			Vector2 one = Vector2.one;
			return;
			IL_01b2:
			int num14 = 0;
			int num15 = i;
			RecipeItemData.Types.Ingredient ingredient3 = default(RecipeItemData.Types.Ingredient);
			Item? item = (Item?)ingredient3.get_Item();
			IItemData _003CIngredientItemData_003Ek__BackingField = default(IItemData);
			recipeIngredientItem.IngredientItemData = _003CIngredientItemData_003Ek__BackingField;
			goto IL_01d0;
			IL_0182:
			int num16 = 0;
			int num17 = i;
			RecipeItemData.Types.Ingredient ingredient4 = default(RecipeItemData.Types.Ingredient);
			Item item2 = ingredient4.ItemsList[0];
			goto IL_019d;
		}

		[Cpp2IlInjected.Token(Token = "0x60017F6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SelectedRecipeContent()
		{
		}
	}
}
