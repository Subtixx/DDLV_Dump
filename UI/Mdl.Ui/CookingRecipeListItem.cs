using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000396")]
	[RequiredAllNotNull]
	public class CookingRecipeListItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400114E")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400114F")]
		[SerializeField]
		private StarComponent _mcStar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001150")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001151")]
		[SerializeField]
		private SpriteAtlasImage _mcBuffContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001152")]
		[SerializeField]
		private TextBase _tfBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001153")]
		[SerializeField]
		private SpriteAtlasImage _mcBuffIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001154")]
		[SerializeField]
		private Sprite _statGreenSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001155")]
		[SerializeField]
		private Sprite _statGraySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001156")]
		[SerializeField]
		private Sprite _cookingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001157")]
		[SerializeField]
		private Sprite _growingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001158")]
		[SerializeField]
		private Sprite _friendshipSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001159")]
		[SerializeField]
		private Sprite _fishingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400115A")]
		[SerializeField]
		private ListBase _listIngredients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400115B")]
		[SerializeField]
		private GameObject _questMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400115C")]
		[SerializeField]
		private GameObject _selectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400115D")]
		[SerializeField]
		private GameObject _normalBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400115E")]
		[SerializeField]
		private GameObject _highlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400115F")]
		[SerializeField]
		private GameObject _selectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001160")]
		protected bool _isSelected;

		[Cpp2IlInjected.Token(Token = "0x170003E1")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60016C5")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x60016C6")]
			[Cpp2IlInjected.Address(RVA = "0x14AFA20", Offset = "0x14AE420", VA = "0x1814AFA20")]
			set
			{
				//Discarded unreachable code: IL_002c
				_isSelected = value;
				_selectedBg.SetActive(value);
				GameObject normalBg = _normalBg;
				bool active = !_isSelected;
				normalBg.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E2")]
		public RecipeItemData RecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60016C7")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			[CompilerGenerated]
			get
			{
				return _003CRecipeItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60016C8")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			[CompilerGenerated]
			internal set
			{
				_003CRecipeItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016C9")]
		[Cpp2IlInjected.Address(RVA = "0x14AEED0", Offset = "0x14AD8D0", VA = "0x1814AEED0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0021
			ListBase.ListEvents onItemData = _listIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60016CA")]
		[Cpp2IlInjected.Address(RVA = "0x14AEF90", Offset = "0x14AD990", VA = "0x1814AEF90")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			ListBase.ListEvents onItemData = _listIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60016CB")]
		[Cpp2IlInjected.Address(RVA = "0x14AF050", Offset = "0x14ADA50", VA = "0x1814AF050")]
		private void OnIngredientsDataHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_00cf
			//IL_001d: Expected O, but got I4
			int num = 0;
			RecipeIngredientItem recipeIngredientItem = default(RecipeIngredientItem);
			if (recipeIngredientItem == (UnityEngine.Object)num)
			{
				return;
			}
			RecipeItemData.Types.Ingredient ingredient = (RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[num];
			RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient.ingredientCase_;
			if (ingredient == null)
			{
				goto IL_00a8;
			}
			if (ingredient == null)
			{
				goto IL_0090;
			}
			if (ingredient == null)
			{
				goto IL_0072;
			}
			if (ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
			{
				Func<ICookingIngredient, bool> func = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate(ICookingIngredient x)
				{
					//Discarded unreachable code: IL_0038
					RecipeItemData recipeItemData = RecipeItemData;
					ListBase.ListEventData listEventData = arg;
					RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = recipeItemData.ingredients_;
					int itemIndex = listEventData.ItemIndex;
					Item[] tags = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_)[itemIndex]).Tags;
					return ItemDataExtensions.HasAllTags((IHasTags)x, (IEnumerable<>)(object)tags);
				};
				IEnumerable<> enumerable = default(IEnumerable<>);
				if (Enumerable.FirstOrDefault<ICookingIngredient>(Enumerable.Where<ICookingIngredient>(enumerable, (Func<, >)(object)func)) != null)
				{
					goto IL_0072;
				}
			}
			goto IL_00c8;
			IL_00c8:
			recipeIngredientItem.RefreshDisplay();
			return;
			IL_0072:
			Item item = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[num]).ItemsList[0];
			goto IL_0090;
			IL_0090:
			Item? anyItem = (Item?)((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[num]).get_AnyItem();
			goto IL_00a8;
			IL_00a8:
			Item? item2 = (Item?)((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[num]).get_Item();
			IItemData _003CIngredientItemData_003Ek__BackingField = default(IItemData);
			recipeIngredientItem.IngredientItemData = _003CIngredientItemData_003Ek__BackingField;
			goto IL_00c8;
		}

		[Cpp2IlInjected.Token(Token = "0x60016CC")]
		[Cpp2IlInjected.Address(RVA = "0x14AF6C0", Offset = "0x14AE0C0", VA = "0x1814AF6C0")]
		public void refreshDisplay(IEnumerable<ProfileWorld.FilterInfo> mealQuests)
		{
			//Discarded unreachable code: IL_0113
			GameObject gameObject = _mcBuffContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			RecipeItemData recipeItemData = RecipeItemData;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int resultItemID = recipeItemData.ResultItemID;
			TextBase tfName = _tfName;
			MealItemData mealItemData = default(MealItemData);
			string text = (tfName.StringID = mealItemData.displayName_);
			RecipeItemData recipeItemData2 = RecipeItemData;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			int resultItemID2 = recipeItemData2.ResultItemID;
			MealItemData mealItemData2 = default(MealItemData);
			MealItemData mealdata = mealItemData2;
			_mcIcon.gameObject.SetActive(value: true);
			MealItemData mealItemData3 = mealdata;
			AsyncAtlassedIcon mcIcon = _mcIcon;
			string iconAddress_ = mealItemData3.iconAddress_;
			bool flag = mcIcon.SetIcon(iconAddress_);
			MealItemData mealItemData4 = mealdata;
			StarComponent mcStar = _mcStar;
			int num = (mcStar.Star = mealItemData4.starRating_);
			RecipeItemData recipeItemData3 = RecipeItemData;
			ListBase listIngredients = _listIngredients;
			int num2 = (listIngredients.TotalCount = ((RepeatedField<T>)(object)recipeItemData3.ingredients_).Count);
			GameObject questMarker = _questMarker;
			Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
			Func<ProfileWorld.FilterInfo, bool> cpp2il__autoParamName__idx_ = (Func<ProfileWorld.FilterInfo, bool>)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo x)
			{
				//Discarded unreachable code: IL_002e
				List<MissionObjective> _003CObjectives_003Ek__BackingField = x.Objectives;
				Func<MissionObjective, bool> func2 = func;
				if (func2 == null)
				{
					func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
					{
						//IL_0036: Expected O, but got I4
						ItemFilter itemFilter_ = obj.itemFilter_;
						if (itemFilter_ != null && (long)itemFilter_.data_ != 0)
						{
							(Item, ItemState)[] array = new(Item, ItemState)[1];
							int iD = mealdata.ID;
							int num3 = 0;
							int num4 = 0;
							((ValueTuple<, >[])(object)array)[0] = (ValueTuple<, >)num3;
							return Enumerable.Any<(Item, ItemState)>((IEnumerable<>)itemFilter_.ApplyFilter((IEnumerable<>)(object)array));
						}
						int num5 = 0;
						throw new NullReferenceException();
					};
				}
				return ((IEnumerable<>)_003CObjectives_003Ek__BackingField).Any<MissionObjective>((Func<, >)(object)func2);
			};
			bool active2 = ((IEnumerable<>)mealQuests).Any<ProfileWorld.FilterInfo>((Func<, >)(object)cpp2il__autoParamName__idx_);
			questMarker.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x60016CD")]
		[Cpp2IlInjected.Address(RVA = "0x14AF560", Offset = "0x14ADF60", VA = "0x1814AF560")]
		public void RefreshSelected()
		{
			//Discarded unreachable code: IL_002e
			GameObject selectedBg = _selectedBg;
			bool isSelected = _isSelected;
			selectedBg.SetActive(isSelected);
			GameObject normalBg = _normalBg;
			bool active = !_isSelected;
			normalBg.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x60016CE")]
		[Cpp2IlInjected.Address(RVA = "0x14AF5B0", Offset = "0x14ADFB0", VA = "0x1814AF5B0")]
		public void SetHighlight(bool isHighlighted)
		{
			//IL_0010: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			GameObject highlightBg = _highlightBg;
			int num = 0;
			if (highlightBg != (UnityEngine.Object)num)
			{
				_highlightBg.SetActive(isHighlighted);
			}
			GameObject selectedHighlightBg = _selectedHighlightBg;
			int num2 = 0;
			if (selectedHighlightBg != (UnityEngine.Object)num2)
			{
				if (!isHighlighted || !_isSelected)
				{
					throw new NullReferenceException();
				}
				_selectedHighlightBg.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016CF")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CookingRecipeListItem()
		{
		}
	}
}
