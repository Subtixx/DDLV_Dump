using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Buildings;
using Mdl.Ftue;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000399")]
	public class CookingStation : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200039A")]
		private class ListCountComparer : IComparer<List<ICookingIngredient>>
		{
			[Cpp2IlInjected.Token(Token = "0x4001184")]
			public static readonly ListCountComparer Instance;

			[Cpp2IlInjected.Token(Token = "0x60016F0")]
			[Cpp2IlInjected.Address(RVA = "0xA16000", Offset = "0xA14A00", VA = "0x180A16000", Slot = "4")]
			public int Compare(List<ICookingIngredient> x, List<ICookingIngredient> y)
			{
				//Discarded unreachable code: IL_0010
				int size = ((List<>)(object)x)._size;
				int size2 = ((List<>)(object)y)._size;
				int result = default(int);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60016F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ListCountComparer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60016F2")]
			[Cpp2IlInjected.Address(RVA = "0xA16060", Offset = "0xA14A60", VA = "0x180A16060")]
			static ListCountComparer()
			{
				ListCountComparer listCountComparer = new ListCountComparer();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001166")]
		[SerializeField]
		private SelectedIngredientsContent _selectedIngredientsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001167")]
		[SerializeField]
		private CookingIngredientsContent _mcIngredientsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001168")]
		[SerializeField]
		private CookingCategorySelector _mcCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001169")]
		[SerializeField]
		private RecipeContent _recipeContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400116A")]
		[SerializeField]
		private CustomButton _btnStartCooking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400116B")]
		[SerializeField]
		private GameObject _mcButtonContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400116C")]
		[SerializeField]
		private AsyncAtlassedIcon _cookButtonIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400116D")]
		[SerializeField]
		private TextBase _cookButtonAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400116E")]
		[SerializeField]
		private CanvasGroup _cookButtonContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400116F")]
		[Nulllable]
		[SerializeField]
		private CookingHistoryContent _mcHistoryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001170")]
		[SerializeField]
		private BaseButton _btnHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001171")]
		[SerializeField]
		private BaseButton _btnAutofill;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001172")]
		[SerializeField]
		private RectTransform _missingIngredientsWarning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001173")]
		[SerializeField]
		private RectTransform _selectRecipeWarning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001174")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001175")]
		[SerializeField]
		private float _autoFillDelay = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001176")]
		[SerializeField]
		private RectTransform _mcCookSelectedRecipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001177")]
		[SerializeField]
		[Header("Start Button Animation")]
		private Vector3 _btnScaleUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4001178")]
		[SerializeField]
		private float _animUpDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001179")]
		[SerializeField]
		private float _animDownDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400117A")]
		[SerializeField]
		private float _animPauseDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400117B")]
		[SerializeField]
		private Ease _easeType = Ease.InOutCubic;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400117C")]
		[SerializeField]
		private LoopType _loopType = LoopType.Yoyo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400117D")]
		public Action OnHistoryShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001180")]
		internal bool IsInCookingAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001181")]
		private CancellationToken _cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001182")]
		private Tween _startCookSelectedRecipeTween;

		[Cpp2IlInjected.Token(Token = "0x170003E3")]
		public CookingHistoryContent HistoryContent
		{
			[Cpp2IlInjected.Token(Token = "0x60016D5")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return _mcHistoryContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E4")]
		public CookingStall CookingStall
		{
			[Cpp2IlInjected.Token(Token = "0x60016D6")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			[CompilerGenerated]
			get
			{
				return _003CCookingStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60016D7")]
			[Cpp2IlInjected.Address(RVA = "0x11049F0", Offset = "0x11033F0", VA = "0x1811049F0")]
			[CompilerGenerated]
			private set
			{
				_003CCookingStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xF0"), Cpp2IlInjected.Token(Token = "0x4001183")]
		public bool IsAutoFilling
		{
			[Cpp2IlInjected.Token(Token = "0x60016DA")]
			[Cpp2IlInjected.Address(RVA = "0x110E5C0", Offset = "0x110CFC0", VA = "0x18110E5C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60016DB")]
			[Cpp2IlInjected.Address(RVA = "0x14B2070", Offset = "0x14B0A70", VA = "0x1814B2070")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event EventHandler<bool> ChangeCookingMenuVisibilityEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60016D8")]
			[Cpp2IlInjected.Address(RVA = "0x14B1F30", Offset = "0x14B0930", VA = "0x1814B1F30")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60016D9")]
			[Cpp2IlInjected.Address(RVA = "0x14B1FD0", Offset = "0x14B09D0", VA = "0x1814B1FD0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016DC")]
		[Cpp2IlInjected.Address(RVA = "0x14AFA70", Offset = "0x14AE470", VA = "0x1814AFA70")]
		public void Init(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0098
			//IL_0017: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			_cancellationToken = ct;
			CanvasGroup canvasGroup = _canvasGroup;
			int num = 0;
			if (canvasGroup == (UnityEngine.Object)num)
			{
				CanvasGroup canvasGroup2 = (_canvasGroup = GetComponent<CanvasGroup>());
			}
			Stall _003CCurrentStall_003Ek__BackingField = SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall;
			if ((object)_003CCurrentStall_003Ek__BackingField == null)
			{
			}
			int num2 = 0;
			CookingStall = (CookingStall)_003CCurrentStall_003Ek__BackingField;
			CookingStall cookingStall = CookingStall;
			RecipeContent recipeContent = _recipeContent;
			FtueStep currentTutorialStep = cookingStall._currentTutorialStep;
			int num3 = 0;
			bool showRecipeButton = currentTutorialStep == (UnityEngine.Object)num3;
			recipeContent.ShowRecipeButton(showRecipeButton);
			int canCook = 0;
			RefreshCookingButton((byte)canCook != 0);
			Item invalid = Item.Invalid;
			RefreshAutofillButton(invalid);
			IsAutoFilling = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60016DD")]
		[Cpp2IlInjected.Address(RVA = "0x14B1930", Offset = "0x14B0330", VA = "0x1814B1930")]
		private void Start()
		{
			//Discarded unreachable code: IL_00d6
			UnityEvent onClicked = _btnStartCooking.OnClicked;
			UnityAction call = OnStartCookingClickHandler;
			onClicked.AddListener(call);
			UnityEvent onHighlighted = _btnStartCooking.OnHighlighted;
			UnityAction call2 = OnStartCookingHighlighted;
			onHighlighted.AddListener(call2);
			UnityEvent onDehighlighted = _btnStartCooking.OnDehighlighted;
			UnityAction call3 = OnStartCookingDehighlighted;
			onDehighlighted.AddListener(call3);
			Button.ButtonClickedEvent onClick = _btnHistory.ButtonComponent.m_OnClick;
			UnityAction call4 = OnHistoryClickHandler;
			onClick.AddListener(call4);
			Button.ButtonClickedEvent onClick2 = _btnAutofill.ButtonComponent.m_OnClick;
			UnityAction call5 = OnAutofillClickHandler;
			onClick2.AddListener(call5);
			RecipeContent recipeContent = _recipeContent;
			EventHandler<Item> eventHandler = (EventHandler<Item>)(object)new EventHandler<TEventArgs>(SelectedRecipeChanged);
			recipeContent.add_SelectedRecipeChanged((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x60016DE")]
		[Cpp2IlInjected.Address(RVA = "0x14AFF70", Offset = "0x14AE970", VA = "0x1814AFF70")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00d6
			UnityEvent onClicked = _btnStartCooking.OnClicked;
			UnityAction call = OnStartCookingClickHandler;
			onClicked.RemoveListener(call);
			UnityEvent onHighlighted = _btnStartCooking.OnHighlighted;
			UnityAction call2 = OnStartCookingHighlighted;
			onHighlighted.RemoveListener(call2);
			UnityEvent onDehighlighted = _btnStartCooking.OnDehighlighted;
			UnityAction call3 = OnStartCookingDehighlighted;
			onDehighlighted.RemoveListener(call3);
			Button.ButtonClickedEvent onClick = _btnHistory.ButtonComponent.m_OnClick;
			UnityAction call4 = OnHistoryClickHandler;
			onClick.RemoveListener(call4);
			Button.ButtonClickedEvent onClick2 = _btnAutofill.ButtonComponent.m_OnClick;
			UnityAction call5 = OnAutofillClickHandler;
			onClick2.RemoveListener(call5);
			RecipeContent recipeContent = _recipeContent;
			EventHandler<Item> eventHandler = (EventHandler<Item>)(object)new EventHandler<TEventArgs>(SelectedRecipeChanged);
			recipeContent.remove_SelectedRecipeChanged((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x60016DF")]
		[Cpp2IlInjected.Address(RVA = "0x14B0200", Offset = "0x14AEC00", VA = "0x1814B0200")]
		public void OnHistoryClickHandler()
		{
			//Discarded unreachable code: IL_0059
			bool activeSelf = _mcHistoryContent.gameObject.activeSelf;
			CookingHistoryContent mcHistoryContent = _mcHistoryContent;
			if (!activeSelf)
			{
				mcHistoryContent.gameObject.SetActive(value: true);
				_mcHistoryContent.Init();
			}
			GameObject gameObject = mcHistoryContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			OnHistoryShown?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60016E0")]
		[Cpp2IlInjected.Address(RVA = "0x14AFD00", Offset = "0x14AE700", VA = "0x1814AFD00")]
		public void OnAutofillClickHandler()
		{
			if (!IsAutoFilling)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016E1")]
		[Cpp2IlInjected.Address(RVA = "0x14AFE60", Offset = "0x14AE860", VA = "0x1814AFE60")]
		[AsyncStateMachine(typeof(_003COnAutofillClickTask_003Ed__45))]
		private Task OnAutofillClickTask()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60016E2")]
		[Cpp2IlInjected.Address(RVA = "0x14B02B0", Offset = "0x14AECB0", VA = "0x1814B02B0")]
		public void OnStartCookingClickHandler()
		{
			//Discarded unreachable code: IL_003d
			CustomButton btnStartCooking = _btnStartCooking;
			if (_mcButtonContent.activeSelf)
			{
				CustomButton btnStartCooking2 = _btnStartCooking;
				int num = ((btnStartCooking2.IsInteractable = false) ? 1 : 0);
				CancellationToken cancellationToken = _cancellationToken;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016E3")]
		[Cpp2IlInjected.Address(RVA = "0x14B1810", Offset = "0x14B0210", VA = "0x1814B1810")]
		[AsyncStateMachine(typeof(_003CStartCookingTask_003Ed__48))]
		private Task StartCookingTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60016E4")]
		[Cpp2IlInjected.Address(RVA = "0x14B0470", Offset = "0x14AEE70", VA = "0x1814B0470")]
		private void OnStartCookingDehighlighted()
		{
			//Discarded unreachable code: IL_004e
			_btnStartCooking.View?.Background?.SetAlpha(1f);
			_btnStartCooking.View?.Label?.SetColorRGB(14935807);
		}

		[Cpp2IlInjected.Token(Token = "0x60016E5")]
		[Cpp2IlInjected.Address(RVA = "0x14B04F0", Offset = "0x14AEEF0", VA = "0x1814B04F0")]
		private void OnStartCookingHighlighted()
		{
			//Discarded unreachable code: IL_004f
			//IL_0024: Expected F4, but got I4
			ButtonViewDefault view = _btnStartCooking.View;
			if ((object)view != null)
			{
				ImageHelper background = view.Background;
				if ((object)background != null)
				{
					int num = 0;
					background.SetAlpha(num);
				}
			}
			_btnStartCooking.View?.Label?.SetColorRGB(3885165);
		}

		[Cpp2IlInjected.Token(Token = "0x60016E6")]
		[Cpp2IlInjected.Address(RVA = "0x14B0F90", Offset = "0x14AF990", VA = "0x1814B0F90")]
		public unsafe void RefreshCookingButton(bool canCook)
		{
			//IL_0117: Expected O, but got I4
			//IL_01cd: Expected O, but got I4
			//IL_02ab: Expected O, but got I4
			CustomButton btnStartCooking = _btnStartCooking;
			int num = 0;
			CanvasGroup component = btnStartCooking.GetComponent<CanvasGroup>();
			CanvasGroup cookButtonContainer = _cookButtonContainer;
			if (canCook)
			{
			}
			cookButtonContainer.alpha = 0.8f;
			component.alpha = 0.8f;
			_btnStartCooking.GetComponent<FocusNavigationElement>().IgnoreThis = canCook;
			ButtonViewDefault view = _btnStartCooking.View;
			if ((object)view != null)
			{
				TextBase label = view.Label;
				if ((object)label != null)
				{
					CustomButton btnStartCooking2 = _btnStartCooking;
					label.SetColorRGB(14935807);
				}
			}
			_btnStartCooking.View?.StaticIcon?.gameObject.SetActive(canCook);
			_btnStartCooking.View?.Background?.gameObject.SetActive(canCook);
			bool flag = ProtoDatabase.Instance.TryGet("Cooking", out *(CookingData*)num);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon cookButtonIcon = _cookButtonIcon;
			string text = default(string);
			_cookButtonAmount.Text = text;
			RefreshStartCookingLabel component2 = _btnStartCooking.GetComponent<RefreshStartCookingLabel>();
			int num2 = 0;
			bool value;
			if (component2 != (UnityEngine.Object)num2)
			{
				IItemData _003CItemData_003Ek__BackingField = ((Stall)CookingStall).ItemData;
				CookingStationInteraction cookingStationInteraction = default(CookingStationInteraction);
				if (_003CItemData_003Ek__BackingField != null && _003CItemData_003Ek__BackingField != null && cookingStationInteraction != null)
				{
					bool noCombustibleSpent_ = cookingStationInteraction.noCombustibleSpent_;
				}
				value = num == 0;
				component2.Refresh(value);
			}
			CustomButton btnStartCooking3 = _btnStartCooking;
			value = (btnStartCooking3.IsActivated = canCook);
			CustomButton btnStartCooking4 = _btnStartCooking;
			value = (btnStartCooking4.IsInteractable = canCook);
			if (canCook && (IntPtr)_recipeContent._mcSelectedRecipeContent.RecipeItemData != (IntPtr)num)
			{
				RecipeItemData chosenRecipeFromIngredients = CookingStall.GetChosenRecipeFromIngredients();
				RecipeItemData _003CRecipeItemData_003Ek__BackingField = _recipeContent._mcSelectedRecipeContent.RecipeItemData;
				if (chosenRecipeFromIngredients.Equals(_003CRecipeItemData_003Ek__BackingField))
				{
					if (chosenRecipeFromIngredients != null)
					{
					}
					_startCookSelectedRecipeTween = (Tween)num;
					int num3 = 0;
					Sequence s = DOTween.Sequence();
					float z = _btnScaleUp.z;
					RectTransform mcCookSelectedRecipe = _mcCookSelectedRecipe;
					TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					Sequence sequence = s.Append(t);
					RectTransform mcCookSelectedRecipe2 = _mcCookSelectedRecipe;
					float z2 = Vector3.one.z;
					TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					Sequence s2 = sequence.Append(t2);
					float animPauseDuration = _animPauseDuration;
					Sequence t3 = s2.AppendInterval(animPauseDuration);
					Ease easeType = _easeType;
					Sequence t4 = t3.SetEase(easeType);
					LoopType loopType = _loopType;
					Sequence sequence2 = (Sequence)(_startCookSelectedRecipeTween = t4.SetLoops(-1, loopType));
					TweenCallback tweenCallback = delegate
					{
						//Discarded unreachable code: IL_0024
						RectTransform mcCookSelectedRecipe5 = _mcCookSelectedRecipe;
						float z5 = Vector3.one.z;
						_mcCookSelectedRecipe.gameObject.SetActive(value: true);
					};
					Tween tween = ((Tween)sequence).OnStart(tweenCallback);
					TweenCallback action = delegate
					{
						RectTransform mcCookSelectedRecipe4 = _mcCookSelectedRecipe;
						float z4 = Vector3.one.z;
						GameObject gameObject2 = _mcCookSelectedRecipe.gameObject;
						int active2 = 0;
						gameObject2.SetActive((byte)active2 != 0);
						throw new NullReferenceException();
					};
					Tween tween2 = ((Tween)sequence).OnComplete(action);
					return;
				}
			}
			Tween startCookSelectedRecipeTween = _startCookSelectedRecipeTween;
			if (startCookSelectedRecipeTween != null)
			{
				int complete = 0;
				startCookSelectedRecipeTween.Kill((byte)complete != 0);
				_startCookSelectedRecipeTween = (Tween)num;
			}
			RectTransform mcCookSelectedRecipe3 = _mcCookSelectedRecipe;
			float z3 = Vector3.one.z;
			GameObject gameObject = _mcCookSelectedRecipe.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016E7")]
		[Cpp2IlInjected.Address(RVA = "0x14B05B0", Offset = "0x14AEFB0", VA = "0x1814B05B0")]
		public void RefreshAutofillButton(Item selectedRecipe)
		{
			//Discarded unreachable code: IL_007c, IL_0081, IL_0092, IL_0096, IL_009c, IL_01e5, IL_01eb, IL_01f1, IL_01f7, IL_01fd, IL_0203, IL_0209, IL_020f
			//IL_003b: Expected I4, but got O
			//IL_008c: Expected I4, but got O
			int num;
			Button button = default(Button);
			bool flag2 = default(bool);
			RecipeItemData recipeItemData = default(RecipeItemData);
			bool flag3 = default(bool);
			Item? item2 = default(Item?);
			RecipeItemData.Types.Ingredient ingredient = default(RecipeItemData.Types.Ingredient);
			List<ICookingIngredient> list2 = default(List<ICookingIngredient>);
			int num7 = default(int);
			Button button2 = default(Button);
			bool flag4 = default(bool);
			while (true)
			{
				num = 0;
				int num2 = 0;
				int num3 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num4 = 0;
				int num5 = ((button.interactable = false) ? 1 : 0);
				if (!flag2 || recipeItemData == null)
				{
					break;
				}
				List<ICookingIngredient> list = (List<ICookingIngredient>)(object)new List<T>((int)_mcIngredientsContent._allIngredientItems);
				Dictionary<RecipeItemData.Types.Ingredient, int> dictionary = (Dictionary<RecipeItemData.Types.Ingredient, int>)(object)new Dictionary<TKey, TValue>();
				int count = ((RepeatedField<T>)(object)recipeItemData.ingredients_).Count;
				if (num < count)
				{
					RecipeItemData.Types.Ingredient ingredient2 = (RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)recipeItemData.ingredients_)[num];
					Item? item = (Item?)ingredient2.get_Item();
					Item invalid = Item.Invalid;
					throw new NullReferenceException();
				}
				if (flag3)
				{
					item2 = (Item?)ingredient.get_Item();
					Item invalid2 = Item.Invalid;
					int num6 = 0;
					if (ingredient.ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
					{
						Func<ICookingIngredient, bool> func = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_0031
							Item? item3 = (Item?)ingredient.get_Item();
							Item item4 = default(Item);
							if ((object)typeof(SystemRoot).TypeHandle != (object)item4)
							{
								int num10 = 0;
							}
							ProfilePlayer player_2 = SystemRoot.Instance.Client.Profile.player_;
							int num11 = default(int);
							return num11 > 0;
						};
						list2 = (List<ICookingIngredient>)(object)Enumerable.ToList<ICookingIngredient>(Enumerable.Where<ICookingIngredient>((IEnumerable<>)list, (Func<, >)(object)func));
						int inventoryAmount = num;
						Action<ICookingIngredient> action = (Action<ICookingIngredient>)(object)(Action<T>)delegate
						{
							//Discarded unreachable code: IL_0028
							int num8 = inventoryAmount;
							ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
							int num9 = default(int);
							inventoryAmount = num9 + num8;
						};
						((List<T>)(object)list2).ForEach((Action<>)(object)action);
						num7 = 0;
					}
					Func<ICookingIngredient, bool> func2 = (Func<ICookingIngredient, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass52_0)(object)list2)._003CRefreshAutofillButton_003Eb__1);
					List<ICookingIngredient> list3 = (List<ICookingIngredient>)(object)Enumerable.ToList<ICookingIngredient>(Enumerable.Where<ICookingIngredient>((IEnumerable<>)list, (Func<, >)(object)func2));
					new _003C_003Ec__DisplayClass52_2().inventoryAmount = num;
				}
				if (item2 == null)
				{
					if (num7 == 0)
					{
					}
					Selectable selectOnUp = ((Selectable)button2).m_Navigation.m_SelectOnUp;
					bool flag6 = (button2.interactable = !flag4);
					break;
				}
			}
			CanvasGroup canvasGroup = default(CanvasGroup);
			canvasGroup.alpha = 0.8f;
			GameObject gameObject = _missingIngredientsWarning.gameObject;
			SelectedRecipeContent mcSelectedRecipeContent = _recipeContent._mcSelectedRecipeContent;
			if ((long)mcSelectedRecipeContent.RecipeItemData != 0)
			{
				bool flag7 = mcSelectedRecipeContent.IsAllIngredientsAdded();
			}
			gameObject.SetActive((byte)num != 0);
			GameObject gameObject2 = _selectRecipeWarning.gameObject;
			bool active = (long)_recipeContent._mcSelectedRecipeContent.RecipeItemData == 0;
			gameObject2.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x60016E8")]
		[Cpp2IlInjected.Address(RVA = "0x14B17A0", Offset = "0x14B01A0", VA = "0x1814B17A0")]
		private void SelectedRecipeChanged(object sender, Item e)
		{
			//Discarded unreachable code: IL_0033
			CookingStall.SelectedRecipe = e;
			Item _003CSelectedRecipe_003Ek__BackingField = CookingStall.SelectedRecipe;
			RefreshAutofillButton(_003CSelectedRecipe_003Ek__BackingField);
			bool canStartCooking = CookingStall.CanStartCooking;
			RefreshCookingButton(canStartCooking);
		}

		[Cpp2IlInjected.Token(Token = "0x60016E9")]
		[Cpp2IlInjected.Address(RVA = "0x14B0560", Offset = "0x14AEF60", VA = "0x1814B0560")]
		public void PreSelectRecipe(RecipeItemData itemdata)
		{
			//Discarded unreachable code: IL_001b
			if (!_recipeContent.RecipeSelected())
			{
				_recipeContent.OnSelectRecipeHandler(itemdata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016EA")]
		[Cpp2IlInjected.Address(RVA = "0x14B1EB0", Offset = "0x14B08B0", VA = "0x1814B1EB0")]
		public CookingStation()
		{
		}//IL_0036: Expected I4, but got I8
		//IL_003f: Expected I4, but got I8

	}
}
