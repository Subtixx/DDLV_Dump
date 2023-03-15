using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200036E")]
	[RequiredAllNotNull]
	public class CookbookItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400109D")]
		[SerializeField]
		private Image _mcIconBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400109E")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400109F")]
		[SerializeField]
		private TextBase _tfQuestionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40010A0")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010A1")]
		[SerializeField]
		private StarComponent _mcStar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40010A2")]
		[SerializeField]
		private SpriteAtlasImage _mcBuffContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40010A3")]
		[SerializeField]
		private TextBase _tfBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40010A4")]
		[SerializeField]
		private SpriteAtlasImage _mcBuffIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40010A5")]
		[SerializeField]
		private Sprite _cookingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40010A6")]
		[SerializeField]
		private Sprite _growingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40010A7")]
		[SerializeField]
		private Sprite _friendshipSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40010A8")]
		[SerializeField]
		private Sprite _fishingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40010A9")]
		[SerializeField]
		private LayoutElement _layout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40010AA")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40010AB")]
		[SerializeField]
		private ListBase _listIngredients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40010AC")]
		[SerializeField]
		private Sprite _statGreenSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40010AD")]
		[SerializeField]
		private Sprite _statGraySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40010AE")]
		private List<Item> _missigIngredients;

		[Cpp2IlInjected.Token(Token = "0x170003CC")]
		public RecipeItemData RecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60015ED")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			[CompilerGenerated]
			get
			{
				return _003CRecipeItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60015EE")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACE0", Offset = "0xA596E0", VA = "0x180A5ACE0")]
			[CompilerGenerated]
			internal set
			{
				_003CRecipeItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB0"), Cpp2IlInjected.Token(Token = "0x40010B0")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60015EF")]
			[Cpp2IlInjected.Address(RVA = "0x1195B30", Offset = "0x1194530", VA = "0x181195B30")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60015F0")]
			[Cpp2IlInjected.Address(RVA = "0x1339830", Offset = "0x1338230", VA = "0x181339830")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x60015F1")]
		[Cpp2IlInjected.Address(RVA = "0x14A3AF0", Offset = "0x14A24F0", VA = "0x1814A3AF0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0021
			ListBase.ListEvents onItemData = _listIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60015F2")]
		[Cpp2IlInjected.Address(RVA = "0x14A3BB0", Offset = "0x14A25B0", VA = "0x1814A3BB0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			ListBase.ListEvents onItemData = _listIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60015F3")]
		[Cpp2IlInjected.Address(RVA = "0x14A3C70", Offset = "0x14A2670", VA = "0x1814A3C70")]
		private void OnIngredientsDataHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_00db
			//IL_001d: Expected O, but got I4
			//IL_003d: Expected I4, but got I8
			//IL_008d: Expected I4, but got I8
			//IL_00ac: Expected I4, but got I8
			//IL_00c5: Expected I4, but got I8
			int num = 0;
			RecipeIngredientItem recipeIngredientItem = default(RecipeIngredientItem);
			if (recipeIngredientItem == (UnityEngine.Object)num)
			{
				return;
			}
			RectTransform component = recipeIngredientItem.GetComponent<RectTransform>();
			ulong num2 = default(ulong);
			RecipeItemData.Types.Ingredient ingredient = (RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[(int)num2];
			RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient.ingredientCase_;
			if (ingredient == null)
			{
				goto IL_00b3;
			}
			if (ingredient == null)
			{
				goto IL_009a;
			}
			if (ingredient == null)
			{
				goto IL_007b;
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
					goto IL_007b;
				}
			}
			goto IL_00d4;
			IL_00d4:
			recipeIngredientItem.RefreshDisplay();
			return;
			IL_007b:
			Item item = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[(int)num2]).ItemsList[0];
			goto IL_009a;
			IL_009a:
			Item? anyItem = (Item?)((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[(int)num2]).get_AnyItem();
			goto IL_00b3;
			IL_00b3:
			Item? item2 = (Item?)((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)RecipeItemData.ingredients_)[(int)num2]).get_Item();
			IItemData _003CIngredientItemData_003Ek__BackingField = default(IItemData);
			recipeIngredientItem.IngredientItemData = _003CIngredientItemData_003Ek__BackingField;
			goto IL_00d4;
		}

		[Cpp2IlInjected.Token(Token = "0x60015F4")]
		[Cpp2IlInjected.Address(RVA = "0x14A41C0", Offset = "0x14A2BC0", VA = "0x1814A41C0")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0186
			//IL_0103: Expected O, but got I4
			RecipeItemData recipeItemData = RecipeItemData;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int resultItemID = recipeItemData.ResultItemID;
			GameObject gameObject = _mcBuffContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			SpriteAtlasImage mcBuffContent = _mcBuffContent;
			MealItemData mealItemData = default(MealItemData);
			if (mealItemData.starRating_ != 5)
			{
			}
			string text2 = (mcBuffContent.ImageAddress = _statGreenSprite.name);
			Cookbook cookbook_ = SystemRoot.Instance.MetaClient.profile.player_.cookbook_;
			int iD = RecipeItemData.ID;
			bool flag = default(bool);
			if (!flag)
			{
				GameObject gameObject2 = _mcIcon.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				_tfTitle.Text = "????";
				_tfQuestionMark.gameObject.SetActive(value: true);
				Image mcIconBg = _mcIconBg;
				int num = 0;
				StarComponent mcStar = _mcStar;
			}
			GameObject gameObject3 = _tfQuestionMark.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			string displayName_ = mealItemData.displayName_;
			TextBase tfTitle = _tfTitle;
			int num2 = 0;
			string text4 = (tfTitle.Text = LocalizationManager.FromStringID(displayName_, (IResolver)num2));
			_mcIcon.gameObject.SetActive(value: true);
			AsyncAtlassedIcon mcIcon = _mcIcon;
			string iconAddress_ = mealItemData.iconAddress_;
			bool flag2 = mcIcon.SetIcon(iconAddress_);
			Image mcIconBg2 = _mcIconBg;
			int num3 = 0;
			StarComponent mcStar2 = _mcStar;
			int num4 = (mcStar2.Star = mealItemData.starRating_);
			RecipeItemData recipeItemData2 = RecipeItemData;
			ListBase listIngredients = _listIngredients;
			int num5 = (listIngredients.TotalCount = ((RepeatedField<T>)(object)recipeItemData2.ingredients_).Count);
		}

		[Cpp2IlInjected.Token(Token = "0x60015F5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CookbookItem()
		{
		}
	}
}
