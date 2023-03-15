using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003A4")]
	[RequiredAllNotNull]
	public class NewRecipePopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20003A5")]
		public class NewRecipePopupParam : MenuParam
		{
			[Cpp2IlInjected.Token(Token = "0x170003E8")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40011C7")]
			public Item RecipeItem
			{
				[Cpp2IlInjected.Token(Token = "0x600171C")]
				[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600171D")]
				[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x170003E9")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x40011C8")]
			public bool NewRecipe
			{
				[Cpp2IlInjected.Token(Token = "0x600171E")]
				[Cpp2IlInjected.Address(RVA = "0xCCE8B0", Offset = "0xCCD2B0", VA = "0x180CCE8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600171F")]
				[Cpp2IlInjected.Address(RVA = "0xCCE8C0", Offset = "0xCCD2C0", VA = "0x180CCE8C0")]
				internal set;
			}

			[Cpp2IlInjected.Token(Token = "0x6001720")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public NewRecipePopupParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400119F")]
		private Item recipeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40011A0")]
		private bool newRecipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40011A1")]
		private Cookbook _cookbook;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40011A2")]
		private RecipeItemData[] _allReceipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40011A3")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40011A4")]
		[SerializeField]
		private TextBase _tfResultTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40011A5")]
		[SerializeField]
		private SpriteAtlasImage _mcBuffContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40011A6")]
		[SerializeField]
		private TextBase _tfBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40011A7")]
		[SerializeField]
		private SpriteAtlasImage _mcBuffIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40011A8")]
		[SerializeField]
		private Sprite _statGreenSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40011A9")]
		[SerializeField]
		private Sprite _statGraySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40011AA")]
		[SerializeField]
		private Sprite _cookingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40011AB")]
		[SerializeField]
		private Sprite _growingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40011AC")]
		[SerializeField]
		private Sprite _friendshipSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40011AD")]
		[SerializeField]
		private Sprite _fishingSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40011AE")]
		[SerializeField]
		private BaseButton _btnPhoto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40011AF")]
		[SerializeField]
		private BaseButton _btnContinue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40011B0")]
		[SerializeField]
		private AsyncMenu _photoMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40011B1")]
		[SerializeField]
		private ListBase _listUsedIngredients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40011B2")]
		[SerializeField]
		private ListBase _listCookbookIngredients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40011B3")]
		[SerializeField]
		private AsyncAtlassedIcon _cookbookRecipeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40011B4")]
		[SerializeField]
		private GameObject _newRecipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40011B7")]
		private NewRecipePopupParam _newRecipeParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40011B8")]
		private Func<Task> _cameraAnimationTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40011B9")]
		[SerializeField]
		private SlidingPanel _ingredientsSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40011BA")]
		[SerializeField]
		private SlidingPanel _contentSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40011BB")]
		[SerializeField]
		private SlidingPanel _resultSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40011BC")]
		[SerializeField]
		private SlidingPanel _continueSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40011BD")]
		[SerializeField]
		private RectTransform _resultSliderRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40011BE")]
		[SerializeField]
		private RectTransform _resultSliderAnimTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40011BF")]
		[SerializeField]
		private Image[] cookbookGoldenStars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40011C0")]
		[SerializeField]
		private Image[] resultGoldenStars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40011C1")]
		[SerializeField]
		private float goldenStarDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40011C2")]
		[SerializeField]
		private float startDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40011C3")]
		[SerializeField]
		private float bounceDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40011C4")]
		[SerializeField]
		private AnimationCurve bounceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40011C5")]
		[SerializeField]
		private Color StarOnColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40011C6")]
		[SerializeField]
		private AK.Wwise.Event starAppearSfx;

		[Cpp2IlInjected.Token(Token = "0x170003E6")]
		public CookingHistory CookedMeal
		{
			[Cpp2IlInjected.Token(Token = "0x6001709")]
			[Cpp2IlInjected.Address(RVA = "0x739280", Offset = "0x737C80", VA = "0x180739280")]
			[CompilerGenerated]
			get
			{
				return _003CCookedMeal_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600170A")]
			[Cpp2IlInjected.Address(RVA = "0x73A360", Offset = "0x738D60", VA = "0x18073A360")]
			[CompilerGenerated]
			private set
			{
				_003CCookedMeal_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E7")]
		public RecipeItemData RecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600170B")]
			[Cpp2IlInjected.Address(RVA = "0x738AD0", Offset = "0x7374D0", VA = "0x180738AD0")]
			[CompilerGenerated]
			get
			{
				return _003CRecipeItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600170C")]
			[Cpp2IlInjected.Address(RVA = "0x739E70", Offset = "0x738870", VA = "0x180739E70")]
			[CompilerGenerated]
			internal set
			{
				_003CRecipeItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600170D")]
		[Cpp2IlInjected.Address(RVA = "0x129BBF0", Offset = "0x129A5F0", VA = "0x18129BBF0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0070
			((object)this)._002Ector();
			ListBase.ListEvents onItemData = _listUsedIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnUsedIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemData2 = _listCookbookIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCookbookIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction2);
			Button.ButtonClickedEvent onClick = _btnPhoto.ButtonComponent.m_OnClick;
			UnityAction call = onPhotoClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x600170E")]
		[Cpp2IlInjected.Address(RVA = "0x129BE90", Offset = "0x129A890", VA = "0x18129BE90", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0070
			base.UnregisterFocusedListeners();
			ListBase.ListEvents onItemData = _listUsedIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnUsedIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemData2 = _listCookbookIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCookbookIngredientsDataHandler);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction2);
			Button.ButtonClickedEvent onClick = _btnPhoto.ButtonComponent.m_OnClick;
			UnityAction call = onPhotoClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x600170F")]
		[Cpp2IlInjected.Address(RVA = "0x129B090", Offset = "0x1299A90", VA = "0x18129B090", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//IL_0036: Expected I4, but got O
			base.OnPush(stack, param);
			NewRecipePopupParam newRecipePopupParam = new NewRecipePopupParam();
			object obj = (newRecipePopupParam.RecipeItem = (Item)param.Params[0]);
			object obj2 = param.Params[1];
			newRecipePopupParam.NewRecipe = (byte)(int)obj2 != 0;
			_newRecipeParam = newRecipePopupParam;
			object[] @params = param.Params;
			if (@params.Length > 2)
			{
				object obj3 = @params[2];
				if (obj3 != null && obj3 != null)
				{
					_cameraAnimationTask = (Func<Task>)obj3;
				}
			}
			Cookbook cookbook = (_cookbook = SystemRoot.Instance.Client.Profile.player_.cookbook_);
			CookingHistory cookingHistory = (CookedMeal = Enumerable.LastOrDefault<CookingHistory>((IEnumerable<>)(object)SystemRoot.Instance.MetaClient.profile.player_.cookingHistory_));
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item _003CRecipeItem_003Ek__BackingField = _newRecipeParam.RecipeItem;
			RecipeItemData recipeItemData = (RecipeItemData = _003CInstance_003Ek__BackingField.GetItemData<RecipeItemData>(_003CRecipeItem_003Ek__BackingField));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001710")]
		[Cpp2IlInjected.Address(RVA = "0x129AE40", Offset = "0x1299840", VA = "0x18129AE40", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0077
			base.OnFocusIn();
			RecipeItemData recipeItemData = RecipeItemData;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int resultItemID = recipeItemData.ResultItemID;
			_resultSlider.Show(andOpen: true);
			((Task)((Func<TResult>)(object)_cameraAnimationTask)?.Invoke()).FireAndForgetTask();
			float delay = default(float);
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				//IL_0009: Expected O, but got I4
				int num2 = 0;
				if (!(this == (UnityEngine.Object)num2))
				{
					_ingredientsSlider?.Show(andOpen: true);
				}
			}, delay);
			Coroutine coroutine2 = Coroutines.Delay(delegate
			{
				//IL_0009: Expected O, but got I4
				int num = 0;
				if (!(this == (UnityEngine.Object)num))
				{
					_contentSlider?.Show(andOpen: true);
				}
			}, delay);
			RefreshDisplay();
			base.IsDataUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001711")]
		[Cpp2IlInjected.Address(RVA = "0x129B6B0", Offset = "0x129A0B0", VA = "0x18129B6B0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__51))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__51 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__51(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001712")]
		[Cpp2IlInjected.Address(RVA = "0x129B730", Offset = "0x129A130", VA = "0x18129B730")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_018c
			NewRecipePopupParam newRecipeParam = _newRecipeParam;
			GameObject gameObject = _newRecipe;
			bool _003CNewRecipe_003Ek__BackingField = newRecipeParam.NewRecipe;
			gameObject.SetActive(_003CNewRecipe_003Ek__BackingField);
			RecipeItemData recipeItemData = RecipeItemData;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int resultItemID = recipeItemData.ResultItemID;
			GameObject gameObject2 = _mcBuffContent.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			TextBase tfTitle = _tfTitle;
			MealItemData mealItemData = default(MealItemData);
			string text = (tfTitle.StringID = mealItemData.displayName_);
			TextBase tfResultTitle = _tfResultTitle;
			string text2 = (tfResultTitle.StringID = mealItemData.displayName_);
			SpriteAtlasImage mcBuffContent = _mcBuffContent;
			if (mealItemData.starRating_ != 5)
			{
			}
			string text4 = (mcBuffContent.ImageAddress = _statGreenSprite.name);
			int starRating_ = mealItemData.starRating_;
			int num = 0;
			if (starRating_ > 0)
			{
				int s = num;
				Action<float> action = default(Action<float>);
				float delay = default(float);
				Coroutine coroutine = Coroutines.Delay(delegate
				{
					//Discarded unreachable code: IL_0094
					//IL_0010: Expected O, but got I4
					NewRecipePopup newRecipePopup = this;
					int num4 = 0;
					if (!(newRecipePopup == (UnityEngine.Object)num4))
					{
						NewRecipePopup newRecipePopup2 = this;
						AK.Wwise.Event @event = newRecipePopup2.starAppearSfx;
						if (@event != null)
						{
							GameObject gameObject3 = newRecipePopup2.gameObject;
							uint num5 = @event.Post(gameObject3);
						}
						Image[] array = newRecipePopup2.resultGoldenStars;
						int num6 = s;
						array[num6].gameObject.SetActive(value: true);
						Action<float> action2 = default(Action<float>);
						if (action == null)
						{
							action2 = (action = (Action<float>)(object)(Action<T>)delegate(float t)
							{
								//Discarded unreachable code: IL_0093
								//IL_0010: Expected O, but got I4
								NewRecipePopup newRecipePopup3 = this;
								int num8 = 0;
								if (!(newRecipePopup3 == (UnityEngine.Object)num8))
								{
									int num9 = 0;
									VibrationsManager.TriggerMediumImpact();
									Image[] array2 = resultGoldenStars;
									int num10 = s;
									Transform transform = array2[num10].transform;
									float z = Vector3.one.z;
									float num11 = bounceCurve.Evaluate(t);
									NewRecipePopup newRecipePopup4 = this;
									Image[] array3 = newRecipePopup4.resultGoldenStars;
									int num12 = s;
									Image image2 = array3[num12];
									Color color2 = (image2.color = newRecipePopup4.StarOnColor);
								}
							});
						}
						float num7 = bounceDuration;
						Coroutines.Do((Action<>)(object)action2, num7);
					}
				}, delay);
				num++;
			}
			if (num < mealItemData.starRating_)
			{
				Image image = cookbookGoldenStars[num];
				Color color = (image.color = StarOnColor);
				num++;
			}
			AsyncAtlassedIcon cookbookRecipeIcon = _cookbookRecipeIcon;
			RecipeItemData recipeItemData2 = RecipeItemData;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			int resultItemID2 = recipeItemData2.ResultItemID;
			CookingHistory cookingHistory = CookedMeal;
			ListBase listUsedIngredients = _listUsedIngredients;
			int num2 = (listUsedIngredients.TotalCount = ((RepeatedField<T>)(object)cookingHistory.ingredients_).Count);
			RecipeItemData recipeItemData3 = RecipeItemData;
			ListBase listCookbookIngredients = _listCookbookIngredients;
			int num3 = (listCookbookIngredients.TotalCount = ((RepeatedField<T>)(object)recipeItemData3.ingredients_).Count);
		}

		[Cpp2IlInjected.Token(Token = "0x6001713")]
		[Cpp2IlInjected.Address(RVA = "0x129A730", Offset = "0x1299130", VA = "0x18129A730")]
		public void OnCloseClickHandler()
		{
			//Discarded unreachable code: IL_004c
			//IL_0032: Expected O, but got I4
			Button buttonComponent = _btnContinue.ButtonComponent;
			int num = ((buttonComponent.interactable = false) ? 1 : 0);
			int num2 = 0;
			CookingMenu menu = UiRoot.Instance._menuStack.GetMenu<CookingMenu>();
			int num3 = 0;
			if (menu != (UnityEngine.Object)num3)
			{
				RecipeItemData recipeItemData = (menu.PreSelectedRecipeItemData = RecipeItemData);
			}
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x6001714")]
		[Cpp2IlInjected.Address(RVA = "0x129B4C0", Offset = "0x1299EC0", VA = "0x18129B4C0")]
		private void OnUsedIngredientsDataHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_0070
			//IL_0015: Expected O, but got I4
			//IL_005a: Expected I4, but got O
			RecipeIngredientItem component = arg.DisplayObject.GetComponent<RecipeIngredientItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				CookingHistory cookingHistory = CookedMeal;
				int itemIndex = arg.ItemIndex;
				int count = ((RepeatedField<T>)(object)cookingHistory.ingredients_).Count;
				component.IsEmpty = true;
				RepeatedField<int> ingredients_ = CookedMeal.ingredients_;
				int itemIndex2 = arg.ItemIndex;
				int num2 = (int)((RepeatedField<T>)(object)ingredients_)[itemIndex2];
				IItemData _003CIngredientItemData_003Ek__BackingField = default(IItemData);
				component.IngredientItemData = _003CIngredientItemData_003Ek__BackingField;
				component.IsEmpty = false;
				component.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001715")]
		[Cpp2IlInjected.Address(RVA = "0x129A8C0", Offset = "0x12992C0", VA = "0x18129A8C0")]
		private void OnCookbookIngredientsDataHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_00e3
			//IL_001d: Expected O, but got I4
			int num = 0;
			RecipeIngredientItem recipeIngredientItem = default(RecipeIngredientItem);
			if (recipeIngredientItem == (UnityEngine.Object)num)
			{
				return;
			}
			int count = ((RepeatedField<T>)(object)RecipeItemData.ingredients_).Count;
			recipeIngredientItem.IsEmpty = true;
			recipeIngredientItem.IsEmpty = false;
			RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = RecipeItemData.ingredients_;
			RecipeItemData.Types.Ingredient ingredient = default(RecipeItemData.Types.Ingredient);
			RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient.ingredientCase_;
			if (ingredient == null)
			{
				goto IL_00be;
			}
			if (ingredient == null)
			{
				goto IL_00a8;
			}
			if (ingredient == null)
			{
				goto IL_008c;
			}
			if (ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
			{
				Func<ICookingIngredient, bool> func = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate(ICookingIngredient x)
				{
					//Discarded unreachable code: IL_0038
					RecipeItemData recipeItemData = RecipeItemData;
					ListBase.ListEventData listEventData = arg;
					RepeatedField<RecipeItemData.Types.Ingredient> ingredients_5 = recipeItemData.ingredients_;
					int itemIndex = listEventData.ItemIndex;
					Item[] tags = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_5)[itemIndex]).Tags;
					return ItemDataExtensions.HasAllTags((IHasTags)x, (IEnumerable<>)(object)tags);
				};
				IEnumerable<> enumerable = default(IEnumerable<>);
				if (Enumerable.FirstOrDefault<ICookingIngredient>(Enumerable.Where<ICookingIngredient>(enumerable, (Func<, >)(object)func)) != null)
				{
					goto IL_008c;
				}
			}
			goto IL_00dc;
			IL_00dc:
			recipeIngredientItem.RefreshDisplay();
			return;
			IL_008c:
			RepeatedField<RecipeItemData.Types.Ingredient> ingredients_2 = RecipeItemData.ingredients_;
			RecipeItemData.Types.Ingredient ingredient2 = default(RecipeItemData.Types.Ingredient);
			Item item = ingredient2.ItemsList[0];
			goto IL_00a8;
			IL_00a8:
			RepeatedField<RecipeItemData.Types.Ingredient> ingredients_3 = RecipeItemData.ingredients_;
			RecipeItemData.Types.Ingredient ingredient3 = default(RecipeItemData.Types.Ingredient);
			Item? anyItem = (Item?)ingredient3.get_AnyItem();
			goto IL_00be;
			IL_00be:
			RepeatedField<RecipeItemData.Types.Ingredient> ingredients_4 = RecipeItemData.ingredients_;
			RecipeItemData.Types.Ingredient ingredient4 = default(RecipeItemData.Types.Ingredient);
			Item? item2 = (Item?)ingredient4.get_Item();
			IItemData _003CIngredientItemData_003Ek__BackingField = default(IItemData);
			recipeIngredientItem.IngredientItemData = _003CIngredientItemData_003Ek__BackingField;
			goto IL_00dc;
		}

		[Cpp2IlInjected.Token(Token = "0x6001716")]
		[Cpp2IlInjected.Address(RVA = "0x129C030", Offset = "0x129AA30", VA = "0x18129C030")]
		public void onPhotoClickHandler()
		{
			//Discarded unreachable code: IL_0047
			FishingPhotoMenu.FishingPhotoMenuParam fishingPhotoMenuParam = new FishingPhotoMenu.FishingPhotoMenuParam();
			fishingPhotoMenuParam.NearClippingTransition = 2.2f;
			Quaternion quaternion = Quaternion.Euler(5.9f, 25.8f, 167.23f);
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			AsyncMenu photoMenu = _photoMenu;
			menuStack.Push(photoMenu, fishingPhotoMenuParam);
		}

		[Cpp2IlInjected.Token(Token = "0x6001717")]
		[Cpp2IlInjected.Address(RVA = "0x129A5A0", Offset = "0x1298FA0", VA = "0x18129A5A0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_004c
			//IL_0032: Expected O, but got I4
			Button buttonComponent = _btnContinue.ButtonComponent;
			int num = ((buttonComponent.interactable = false) ? 1 : 0);
			int num2 = 0;
			CookingMenu menu = UiRoot.Instance._menuStack.GetMenu<CookingMenu>();
			int num3 = 0;
			if (menu != (UnityEngine.Object)num3)
			{
				RecipeItemData recipeItemData = (menu.PreSelectedRecipeItemData = RecipeItemData);
			}
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x6001718")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public NewRecipePopup()
		{
		}
	}
}
