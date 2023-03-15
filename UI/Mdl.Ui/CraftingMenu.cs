using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Mdl.Buildings;
using Mdl.InputSystem;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003CA")]
	public class CraftingMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001283")]
		[SerializeField]
		private RectTransform _recipeListHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001284")]
		[SerializeField]
		private CanvasGroup _recipeListHolderGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001285")]
		[SerializeField]
		private RectTransform _recipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001286")]
		[SerializeField]
		private CanvasGroup _recipeGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001287")]
		[SerializeField]
		private RectTransform _recipeItemRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001288")]
		[SerializeField]
		private CanvasGroup _recipeItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001289")]
		[SerializeField]
		private RectTransform _recipeItemDecoRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400128A")]
		[SerializeField]
		private CanvasGroup _recipeItemDecoGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400128B")]
		[SerializeField]
		private RectTransform _successRecipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400128C")]
		[SerializeField]
		private CanvasGroup _successRecipeGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400128D")]
		[SerializeField]
		private RectTransform _successRecipeBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400128E")]
		[SerializeField]
		private CanvasGroup _successRecipeBackgroundGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400128F")]
		[SerializeField]
		private RectTransform _successRecipeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001290")]
		[SerializeField]
		private CanvasGroup _successRecipeButtonGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001291")]
		[SerializeField]
		private RectTransform _successItemRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001292")]
		[SerializeField]
		private RectTransform _successItemDecoTopRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001293")]
		[SerializeField]
		private RectTransform _successItemDecoBottomRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001294")]
		[SerializeField]
		private NavigationBar _navigationBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001295")]
		[SerializeField]
		private LoopVerticalScrollRect _recipesScrollList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4001296")]
		[SerializeField]
		private GameObject _recipesEmptyMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4001297")]
		[SerializeField]
		private AsyncAtlassedIcon _recipeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4001298")]
		[SerializeField]
		private TextBase _recipeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4001299")]
		[SerializeField]
		private BaseButton _recipeCountMinusButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400129A")]
		[SerializeField]
		private BaseButton _recipeCountPlusButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400129B")]
		[SerializeField]
		private TextBase _recipeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400129C")]
		[SerializeField]
		private ListBase _recipeIngredients;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400129D")]
		[SerializeField]
		private CustomButton _recipeCraftButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400129E")]
		[SerializeField]
		private AsyncAtlassedIcon _successRecipeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400129F")]
		[SerializeField]
		private TextBase _successRecipeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40012A0")]
		[SerializeField]
		private StarRanking _successStarRanking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40012A1")]
		[SerializeField]
		private TextBase _successItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40012A2")]
		[SerializeField]
		private AK.Wwise.Event _craftSuccessSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40012A3")]
		[SerializeField]
		private AK.Wwise.Event _incrementObjectSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40012A4")]
		[SerializeField]
		private AK.Wwise.Event _decrementObjectSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40012A5")]
		[SerializeField]
		private AK.Wwise.Event _recipesListInSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40012A6")]
		[SerializeField]
		public AK.Wwise.Event _craftJingle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40012A7")]
		[SerializeField]
		public AK.Wwise.Event _craftStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40012A8")]
		[SerializeField]
		public AK.Wwise.Event _craftInventoryFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40012A9")]
		[SerializeField]
		public AK.Wwise.Event _craftStopSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40012AA")]
		private List<(CraftingRecipeItemData data, int maxCraft)> _allRecipes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40012AB")]
		private List<Item> _recipesToSetAsSeen = (List<Item>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40012AC")]
		private int _selectedRecipeIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40012AD")]
		private GameObject _selectedRecipeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40012AE")]
		private int _selectedRecipeAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40012AF")]
		private FocusNavigationElement _nextFocusItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40012B0")]
		private float _previousAxisX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40012B1")]
		private ITagData _lastTagSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40012B2")]
		protected InputAction _inputActionIncrementStick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40012B3")]
		protected InputAction _inputActionDecrementStick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40012B4")]
		private InputAction _inputActionIncrementDpad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40012B5")]
		private InputAction _inputActionDecrementDpad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40012B6")]
		[SerializeField]
		private float _holdDurationBeforePress = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
		[Cpp2IlInjected.Token(Token = "0x40012B7")]
		[SerializeField]
		private float _holdClickRepetitionInterval = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40012B8")]
		[SerializeField]
		private float _holdClickFastRepetitionInterval = 0.07f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x40012B9")]
		private int _repetitionAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40012BA")]
		private float _buttonHeldDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40012BB")]
		private bool _subtractButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E5")]
		[Cpp2IlInjected.Token(Token = "0x40012BC")]
		private bool _addButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E6")]
		[Cpp2IlInjected.Token(Token = "0x40012BD")]
		private bool _justPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E7")]
		[Cpp2IlInjected.Token(Token = "0x40012BE")]
		private bool _inWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x40012BF")]
		private Coroutine _waitForUpdateAndFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x40012C0")]
		private int maxItemsCraftedAtOnce = 99;

		[Cpp2IlInjected.Token(Token = "0x170003FF")]
		private CraftingRecipeItemData SelectedData
		{
			[Cpp2IlInjected.Token(Token = "0x6001808")]
			[Cpp2IlInjected.Address(RVA = "0x14B8B90", Offset = "0x14B7590", VA = "0x1814B8B90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000400")]
		private int SelectedCraftMax
		{
			[Cpp2IlInjected.Token(Token = "0x6001809")]
			[Cpp2IlInjected.Address(RVA = "0x14B8B40", Offset = "0x14B7540", VA = "0x1814B8B40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600180A")]
		[Cpp2IlInjected.Address(RVA = "0x14B77C0", Offset = "0x14B61C0", VA = "0x1814B77C0")]
		private bool SelectedMaxCraftIsOK(int recipeAmount)
		{
			//Discarded unreachable code: IL_0002, IL_0004
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600180B")]
		[Cpp2IlInjected.Address(RVA = "0x14B5000", Offset = "0x14B3A00", VA = "0x1814B5000", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0149, IL_014f, IL_0155, IL_015b, IL_0161
			//IL_001a: Expected F4, but got I4
			//IL_0040: Expected F4, but got I4
			//IL_0054: Expected F4, but got I4
			int num = 0;
			base.OnPush(stack, param);
			CanvasGroup recipeListHolderGroup = _recipeListHolderGroup;
			int num2 = 0;
			recipeListHolderGroup.alpha = num2;
			CanvasGroup recipeListHolderGroup2 = _recipeListHolderGroup;
			int num3 = ((recipeListHolderGroup2.blocksRaycasts = false) ? 1 : 0);
			CanvasGroup recipeGroup = _recipeGroup;
			int num4 = 0;
			recipeGroup.alpha = num4;
			CanvasGroup successRecipeGroup = _successRecipeGroup;
			int num5 = 0;
			successRecipeGroup.alpha = num5;
			CanvasGroup successRecipeGroup2 = _successRecipeGroup;
			int num6 = ((successRecipeGroup2.blocksRaycasts = false) ? 1 : 0);
			AK.Wwise.Event recipesListInSFX = _recipesListInSFX;
			if (recipesListInSFX != null)
			{
				GameObject gameObject = base.gameObject;
				uint num7 = recipesListInSFX.Post(gameObject);
			}
			Dictionary<string, Action> dictionary = (Dictionary<string, Action>)(object)new Dictionary<TKey, TValue>();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<CraftingRecipeTypeTagItemData, int> func = default(Func<CraftingRecipeTypeTagItemData, int>);
			if (_003C_003Ec._003C_003E9__67_0 == null)
			{
				func = (Func<CraftingRecipeTypeTagItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CraftingRecipeTypeTagItemData x) => x.sortPriority_));
			}
			IEnumerable<> enumerable = default(IEnumerable<>);
			IOrderedEnumerable<CraftingRecipeTypeTagItemData> orderedEnumerable = (IOrderedEnumerable<CraftingRecipeTypeTagItemData>)Enumerable.OrderBy<CraftingRecipeTypeTagItemData, int>(enumerable, (Func<, >)(object)func);
			if (orderedEnumerable != null)
			{
				_003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass67_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				uint num8 = default(uint);
				if (num < (int)num8)
				{
					num += num;
					if (num == (int)num8)
					{
						num += num;
						num += num;
						goto IL_0124;
					}
					num++;
				}
				CS_0024_003C_003E8__locals0.tagItemData = (ITagData)(object)CS_0024_003C_003E8__locals0;
				ITagData tagItemData = CS_0024_003C_003E8__locals0.tagItemData;
				uint num9 = default(uint);
				if (num < (int)num9)
				{
					num += num;
					num++;
				}
				Action action = delegate
				{
					//Discarded unreachable code: IL_0016
					CraftingMenu _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
					ITagData tagItemData2 = CS_0024_003C_003E8__locals0.tagItemData;
					_003C_003E4__this.RefreshRecipes(tagItemData2);
				};
				throw new NullReferenceException();
			}
			goto IL_0124;
			IL_0124:
			if (orderedEnumerable != null)
			{
				int num10 = 0;
			}
			int num11 = 0;
			SystemRoot.Instance._avatar.Animator.SetTrigger("Crafting");
		}

		[Cpp2IlInjected.Token(Token = "0x600180C")]
		[Cpp2IlInjected.Address(RVA = "0x14B61F0", Offset = "0x14B4BF0", VA = "0x1814B61F0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__68))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__68 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__68(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600180D")]
		[Cpp2IlInjected.Address(RVA = "0x14B4EA0", Offset = "0x14B38A0", VA = "0x1814B4EA0", Slot = "28")]
		public override void OnFocusOut(bool popAfterPreFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0031
			base.OnFocusOut(popAfterPreFocusOut, animate);
			AK.Wwise.Event @event = closeSFX;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			Coroutine waitForUpdateAndFocus = _waitForUpdateAndFocus;
			if (waitForUpdateAndFocus != null)
			{
				StopCoroutine(waitForUpdateAndFocus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600180E")]
		[Cpp2IlInjected.Address(RVA = "0x14B7220", Offset = "0x14B5C20", VA = "0x1814B7220", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//IL_011d: Expected O, but got I4
			//IL_0142: Expected O, but got I4
			//IL_0164: Expected O, but got I4
			//IL_0186: Expected O, but got I4
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_recipesScrollList).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_recipesScrollList).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemSelect);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemData2 = _recipeIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnIngredientItemData);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction3);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CraftingCompleted value = ShowSuccess;
			_003CDispatcher_003Ek__BackingField.OnCraftingCompleted += value;
			BaseButton recipeCountPlusButton = _recipeCountPlusButton;
			BaseButton.OnBaseButtonPress value2 = OnAddPressedHandler;
			recipeCountPlusButton.OnPress += value2;
			BaseButton recipeCountPlusButton2 = _recipeCountPlusButton;
			BaseButton.OnBaseButtonRelease value3 = OnAddReleasedHandler;
			recipeCountPlusButton2.OnRelease += value3;
			BaseButton recipeCountMinusButton = _recipeCountMinusButton;
			BaseButton.OnBaseButtonPress value4 = OnSubtractPressedHandler;
			recipeCountMinusButton.OnPress += value4;
			BaseButton recipeCountMinusButton2 = _recipeCountMinusButton;
			BaseButton.OnBaseButtonRelease value5 = OnSubtractReleasedHandler;
			recipeCountMinusButton2.OnRelease += value5;
			InputTriggerDown trigger = new InputTriggerDown();
			int num = default(int);
			InputActionBool inputActionIncrementDpad = new InputActionBool("[DPad Right]", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			_inputActionIncrementDpad = inputActionIncrementDpad;
			InputTriggerDown trigger2 = new InputTriggerDown();
			int num3 = default(int);
			InputActionBool inputActionDecrementDpad = new InputActionBool("[DPad Left]", trigger2, (InputProvider)num3);
			num3 = 0;
			_inputActionDecrementDpad = inputActionDecrementDpad;
			InputTriggerDown trigger3 = new InputTriggerDown();
			int num4 = default(int);
			InputActionBool inputActionIncrementStick = new InputActionBool("[LStick Right]", trigger3, (InputProvider)num4);
			num4 = 0;
			_inputActionIncrementStick = inputActionIncrementStick;
			InputTriggerDown trigger4 = new InputTriggerDown();
			int num5 = default(int);
			InputActionBool inputActionDecrementStick = new InputActionBool("[LStick Left]", trigger4, (InputProvider)num5);
			num5 = 0;
			_inputActionDecrementStick = inputActionDecrementStick;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600180F")]
		[Cpp2IlInjected.Address(RVA = "0x14B8030", Offset = "0x14B6A30", VA = "0x1814B8030", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0109
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_recipesScrollList).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemData);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_recipesScrollList).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnRecipeItemSelect);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemData2 = _recipeIngredients.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnIngredientItemData);
			((UnityEvent<T0>)(object)onItemData2).RemoveListener((UnityAction<>)(object)unityAction3);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CraftingCompleted value = ShowSuccess;
			_003CDispatcher_003Ek__BackingField.OnCraftingCompleted -= value;
			BaseButton recipeCountPlusButton = _recipeCountPlusButton;
			BaseButton.OnBaseButtonPress value2 = OnAddPressedHandler;
			recipeCountPlusButton.OnPress -= value2;
			BaseButton recipeCountPlusButton2 = _recipeCountPlusButton;
			BaseButton.OnBaseButtonRelease value3 = OnAddReleasedHandler;
			recipeCountPlusButton2.OnRelease -= value3;
			BaseButton recipeCountMinusButton = _recipeCountMinusButton;
			BaseButton.OnBaseButtonPress value4 = OnSubtractPressedHandler;
			recipeCountMinusButton.OnPress -= value4;
			BaseButton recipeCountMinusButton2 = _recipeCountMinusButton;
			BaseButton.OnBaseButtonRelease value5 = OnSubtractReleasedHandler;
			recipeCountMinusButton2.OnRelease -= value5;
		}

		[Cpp2IlInjected.Token(Token = "0x6001810")]
		[Cpp2IlInjected.Address(RVA = "0x14B84B0", Offset = "0x14B6EB0", VA = "0x1814B84B0")]
		private void Update()
		{
			//IL_0198: Invalid comparison between I4 and F4
			float deltaTime;
			InputAction[] array;
			InputAction inputActionDecrementDpad;
			while (true)
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[4];
				InputAction inputActionIncrementStick = _inputActionIncrementStick;
				if (inputActionIncrementStick != null && array == null)
				{
					continue;
				}
				array[0] = inputActionIncrementStick;
				InputAction inputActionDecrementStick = _inputActionDecrementStick;
				if (inputActionDecrementStick != null && array == null)
				{
					continue;
				}
				array[1] = inputActionDecrementStick;
				InputAction inputActionIncrementDpad = _inputActionIncrementDpad;
				if (inputActionIncrementDpad == null || array != null)
				{
					array[2] = inputActionIncrementDpad;
					inputActionDecrementDpad = _inputActionDecrementDpad;
					if (inputActionDecrementDpad == null || array != null)
					{
						break;
					}
				}
			}
			array[3] = inputActionDecrementDpad;
			InputAction.UpdateAll(deltaTime, array);
			if (_recipeCountMinusButton.ButtonComponent.IsInteractable() && _recipeCountPlusButton.ButtonComponent.IsInteractable())
			{
				bool subtractButtonPressed = _subtractButtonPressed;
				if (subtractButtonPressed || _addButtonPressed != subtractButtonPressed || _inputActionIncrementStick.IsTriggered != subtractButtonPressed || _inputActionDecrementStick.IsTriggered != subtractButtonPressed || _inputActionIncrementDpad.IsTriggered != subtractButtonPressed || _inputActionDecrementDpad.IsTriggered != subtractButtonPressed)
				{
					if (_repetitionAmount > 0)
					{
						int selectedRecipeAmount = _selectedRecipeAmount;
						if ((selectedRecipeAmount == maxItemsCraftedAtOnce && (_addButtonPressed || _inputActionIncrementStick.IsTriggered || _inputActionIncrementDpad.IsTriggered)) || (selectedRecipeAmount == 1 && (subtractButtonPressed || _inputActionDecrementStick.IsTriggered != subtractButtonPressed || _inputActionDecrementDpad.IsTriggered != subtractButtonPressed)))
						{
							return;
						}
					}
					float buttonHeldDuration = _buttonHeldDuration;
					int num2 = 0;
					float deltaTime2 = Time.deltaTime;
					int num3 = 0;
					_buttonHeldDuration = buttonHeldDuration;
					if (!((float)num3 >= buttonHeldDuration))
					{
						if (_justPressed)
						{
							return;
						}
						float holdDurationBeforePress = _holdDurationBeforePress;
						if (_justPressed)
						{
							_buttonHeldDuration = holdDurationBeforePress;
						}
						_justPressed = true;
						if (!_subtractButtonPressed && !_inputActionDecrementStick.IsTriggered && !_inputActionDecrementDpad.IsTriggered)
						{
							if (!_addButtonPressed && !_inputActionIncrementStick.IsTriggered && !_inputActionIncrementDpad.IsTriggered)
							{
								return;
							}
							IncrementAmount();
						}
						DecrementAmount();
					}
					if (!_subtractButtonPressed && !_inputActionDecrementStick.IsTriggered && !_inputActionDecrementDpad.IsTriggered)
					{
						if (!_addButtonPressed && !_inputActionIncrementStick.IsTriggered && !_inputActionIncrementDpad.IsTriggered)
						{
							goto IL_0278;
						}
						IncrementAmount();
					}
					DecrementAmount();
					goto IL_0278;
				}
			}
			throw new NullReferenceException();
			IL_0278:
			float num4 = (_buttonHeldDuration = _holdClickRepetitionInterval);
		}

		[Cpp2IlInjected.Token(Token = "0x6001811")]
		[Cpp2IlInjected.Address(RVA = "0x14B8420", Offset = "0x14B6E20", VA = "0x1814B8420")]
		private void UnselectRecipe()
		{
			//Discarded unreachable code: IL_0039
			//IL_0019: Expected I4, but got I8
			LoopVerticalScrollRect recipesScrollList = _recipesScrollList;
			int num = 0;
			_selectedRecipeIndex = -1;
			int[] array2 = (recipesScrollList.SelectedIndexes = new int[num]);
			_recipesScrollList.RefreshCells();
			RefreshSelectedRecipe();
		}

		[Cpp2IlInjected.Token(Token = "0x6001812")]
		[Cpp2IlInjected.Address(RVA = "0x14B6270", Offset = "0x14B4C70", VA = "0x1814B6270")]
		private void RefillRecipes()
		{
			List<(CraftingRecipeItemData, int)> allRecipes = _allRecipes;
			Func<(CraftingRecipeItemData, int), bool> _003C_003E9__74_ = _003C_003Ec._003C_003E9__74_0;
			if (_003C_003E9__74_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0015
					Profile profile = SystemRoot.Instance.MetaClient.profile;
					bool flag = default(bool);
					return !flag;
				};
			}
			IOrderedEnumerable<(CraftingRecipeItemData, int)> orderedEnumerable = (IOrderedEnumerable<(CraftingRecipeItemData, int)>)Enumerable.OrderByDescending<(CraftingRecipeItemData, int), bool>((IEnumerable<>)allRecipes, (Func<, >)(object)_003C_003E9__74_);
			bool result = default(bool);
			Func<(CraftingRecipeItemData, int), bool> func = (Func<(CraftingRecipeItemData, int), bool>)(object)(Func<T, TResult>)(((CraftingRecipeItemData data, int maxCraft) x) => result);
			List<(CraftingRecipeItemData, int)> list = (_allRecipes = (List<(CraftingRecipeItemData data, int maxCraft)>)(object)Enumerable.ToList<(CraftingRecipeItemData, int)>((IEnumerable<>)Enumerable.ThenByDescending<(CraftingRecipeItemData, int), bool>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func)));
			List<(CraftingRecipeItemData, int)> allRecipes2 = _allRecipes;
			LoopVerticalScrollRect recipesScrollList = _recipesScrollList;
			int num = (recipesScrollList.totalCount = ((List<>)(object)allRecipes2)._size);
			LoopVerticalScrollRect recipesScrollList2 = _recipesScrollList;
			int offset = 0;
			recipesScrollList2.RefillCells(offset);
			List<(CraftingRecipeItemData, int)> allRecipes3 = _allRecipes;
			GameObject recipesEmptyMessage = _recipesEmptyMessage;
			bool active = !Enumerable.Any<(CraftingRecipeItemData, int)>((IEnumerable<>)allRecipes3);
			recipesEmptyMessage.SetActive(active);
			UnselectRecipe();
			Coroutine waitForUpdateAndFocus = _waitForUpdateAndFocus;
			_inWait = true;
			if (waitForUpdateAndFocus != null)
			{
				StopCoroutine(waitForUpdateAndFocus);
			}
			int _003C_003E1__state = default(int);
			_003CWaitThenForceUpdateThenFocus_003Ed__76 _003CWaitThenForceUpdateThenFocus_003Ed__ = new _003CWaitThenForceUpdateThenFocus_003Ed__76(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitThenForceUpdateThenFocus_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_waitForUpdateAndFocus = StartCoroutine(_003CWaitThenForceUpdateThenFocus_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001813")]
		[Cpp2IlInjected.Address(RVA = "0x14B6CB0", Offset = "0x14B56B0", VA = "0x1814B6CB0")]
		private void RefreshRecipes()
		{
			//Discarded unreachable code: IL_0036
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			List<(CraftingRecipeItemData, int)> list = (_allRecipes = (List<(CraftingRecipeItemData data, int maxCraft)>)(object)profile.GetAvailableCraftingRecipesInfo((ITransactionContext)_003CTransactionContext_003Ek__BackingField));
			RefillRecipes();
		}

		[Cpp2IlInjected.Token(Token = "0x6001814")]
		[Cpp2IlInjected.Address(RVA = "0x14B8A20", Offset = "0x14B7420", VA = "0x1814B8A20")]
		[IteratorStateMachine(typeof(_003CWaitThenForceUpdateThenFocus_003Ed__76))]
		private IEnumerator WaitThenForceUpdateThenFocus()
		{
			int _003C_003E1__state = default(int);
			_003CWaitThenForceUpdateThenFocus_003Ed__76 _003CWaitThenForceUpdateThenFocus_003Ed__ = new _003CWaitThenForceUpdateThenFocus_003Ed__76(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitThenForceUpdateThenFocus_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001815")]
		[Cpp2IlInjected.Address(RVA = "0x14B6A50", Offset = "0x14B5450", VA = "0x1814B6A50")]
		private void RefreshRecipes(ITagData tag)
		{
			//Discarded unreachable code: IL_0071
			ITagData tagData = (_lastTagSelected = tag);
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			List<(CraftingRecipeItemData, int)> availableCraftingRecipesInfo = (List<(CraftingRecipeItemData, int)>)(object)profile.GetAvailableCraftingRecipesInfo((ITransactionContext)_003CTransactionContext_003Ek__BackingField);
			Func<(CraftingRecipeItemData, int), bool> func = (Func<(CraftingRecipeItemData, int), bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				ITagData tagData2 = tag;
				bool result = default(bool);
				return result;
			};
			List<(CraftingRecipeItemData, int)> list = (_allRecipes = (List<(CraftingRecipeItemData data, int maxCraft)>)(object)Enumerable.ToList<(CraftingRecipeItemData, int)>(Enumerable.Where<(CraftingRecipeItemData, int)>((IEnumerable<>)availableCraftingRecipesInfo, (Func<, >)(object)func)));
			RefillRecipes();
		}

		[Cpp2IlInjected.Token(Token = "0x6001816")]
		[Cpp2IlInjected.Address(RVA = "0x14B6580", Offset = "0x14B4F80", VA = "0x1814B6580")]
		private void RefreshQuestRecipes()
		{
			//Discarded unreachable code: IL_007d
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			List<(CraftingRecipeItemData, int)> availableCraftingRecipesInfo = (List<(CraftingRecipeItemData, int)>)(object)profile.GetAvailableCraftingRecipesInfo((ITransactionContext)_003CTransactionContext_003Ek__BackingField);
			IEnumerable<ProfileWorld.FilterInfo> quests = (IEnumerable<ProfileWorld.FilterInfo>)SystemRoot.Instance.MetaClient.profile.world_.GetFiltersCraftInfo();
			Func<(CraftingRecipeItemData, int), bool> func = (Func<(CraftingRecipeItemData, int), bool>)(object)(Func<T, TResult>)delegate
			{
				IEnumerable<ProfileWorld.FilterInfo> cpp2il__autoParamName__idx_ = quests;
				Func<MissionObjective, bool> func2 = default(Func<MissionObjective, bool>);
				(CraftingRecipeItemData data, int maxCraft) recipe2 = default((CraftingRecipeItemData data, int maxCraft));
				Func<ProfileWorld.FilterInfo, bool> cpp2il__autoParamName__idx_2 = (Func<ProfileWorld.FilterInfo, bool>)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo quest)
				{
					//Discarded unreachable code: IL_002e
					List<MissionObjective> _003CObjectives_003Ek__BackingField = quest.Objectives;
					Func<MissionObjective, bool> func3 = func2;
					if (func3 == null)
					{
						func2 = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
						{
							//Discarded unreachable code: IL_002f
							//IL_0022: Expected O, but got I4
							ItemFilter itemFilter_ = obj.itemFilter_;
							Item[] array = new Item[1];
							int price = ((BattlePassReward)recipe2).Price;
							array[0] = (Item)price;
							return Enumerable.Any<Item>((IEnumerable<>)itemFilter_.ApplyFilter((IEnumerable<>)(object)array));
						};
					}
					return ((IEnumerable<>)_003CObjectives_003Ek__BackingField).Any<MissionObjective>((Func<, >)(object)func3);
				};
				if (((IEnumerable<>)cpp2il__autoParamName__idx_).Any<ProfileWorld.FilterInfo>((Func<, >)(object)cpp2il__autoParamName__idx_2))
				{
					return true;
				}
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				(CraftingRecipeItemData, int) tuple = recipe2;
				IEnumerable<ProfileWorld.FilterInfo> enumerable = default(IEnumerable<ProfileWorld.FilterInfo>);
				bool flag = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)enumerable);
				throw new NullReferenceException();
			};
			List<(CraftingRecipeItemData, int)> list = (_allRecipes = (List<(CraftingRecipeItemData data, int maxCraft)>)(object)Enumerable.ToList<(CraftingRecipeItemData, int)>(Enumerable.Where<(CraftingRecipeItemData, int)>((IEnumerable<>)availableCraftingRecipesInfo, (Func<, >)(object)func)));
			RefillRecipes();
		}

		[Cpp2IlInjected.Token(Token = "0x6001817")]
		[Cpp2IlInjected.Address(RVA = "0x14B5690", Offset = "0x14B4090", VA = "0x1814B5690")]
		private void OnRecipeItemData(ListEventData item)
		{
			//Discarded unreachable code: IL_00b4
			//IL_0076: Expected O, but got I4
			CraftingRecipeItem component = item.DisplayObject.GetComponent<CraftingRecipeItem>();
			List<(CraftingRecipeItemData, int)> allRecipes = _allRecipes;
			int itemIndex = item.ItemIndex;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			num += num;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			bool flag = default(bool);
			bool _003CIsNew_003Ek__BackingField = !flag;
			if (!flag)
			{
				List<Item> recipesToSetAsSeen = _recipesToSetAsSeen;
				bool flag2 = default(bool);
				if (!flag2)
				{
					List<Item> recipesToSetAsSeen2 = _recipesToSetAsSeen;
				}
			}
			CraftingRecipeItemItemModel craftingRecipeItemItemModel = new CraftingRecipeItemItemModel();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData _003CItemData_003Ek__BackingField = default(IItemData);
			((ItemSlotModel)craftingRecipeItemItemModel).ItemData = _003CItemData_003Ek__BackingField;
			craftingRecipeItemItemModel.CraftingRecipeItemData = (CraftingRecipeItemData)0;
			craftingRecipeItemItemModel.IsNew = _003CIsNew_003Ek__BackingField;
			bool _003CIsUnlocked_003Ek__BackingField = default(bool);
			craftingRecipeItemItemModel.IsUnlocked = _003CIsUnlocked_003Ek__BackingField;
			int itemIndex2 = item.ItemIndex;
			bool flag3 = (craftingRecipeItemItemModel.IsSelected = _selectedRecipeIndex == itemIndex2);
			component.Model = craftingRecipeItemItemModel;
			component.RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001818")]
		[Cpp2IlInjected.Address(RVA = "0x14B3AB0", Offset = "0x14B24B0", VA = "0x1814B3AB0")]
		private int GetAvailableCrafts()
		{
			int num = maxItemsCraftedAtOnce;
			IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Range(1, num);
			bool result = default(bool);
			Func<int, bool> func = (Func<int, bool>)(object)(Func<T, TResult>)((int x) => result);
			return Enumerable.LastOrDefault<int>(Enumerable.TakeWhile<int>((IEnumerable<>)enumerable, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x6001819")]
		[Cpp2IlInjected.Address(RVA = "0x14B3830", Offset = "0x14B2230", VA = "0x1814B3830")]
		private bool CanCraft(int recipeAmount)
		{
			//Discarded unreachable code: IL_0005
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600181A")]
		[Cpp2IlInjected.Address(RVA = "0x14B3DA0", Offset = "0x14B27A0", VA = "0x1814B3DA0")]
		private bool HasEnoughIngredients(CraftingRecipeItemData recipe, int recipeAmount)
		{
			//Discarded unreachable code: IL_00c2, IL_00c8, IL_00ce, IL_00d4, IL_00da, IL_00e0, IL_00e6, IL_00ec, IL_00f2, IL_00f8, IL_00fe, IL_0104, IL_010a, IL_0110, IL_0116, IL_011c, IL_0122
			//IL_0045: Expected O, but got I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			bool flag = default(bool);
			ICollection<> collection = default(ICollection<>);
			bool flag2 = default(bool);
			ItemType itemType = default(ItemType);
			int num;
			while (true)
			{
				num = 0;
				int num2 = 0;
				_003C_003Ec__DisplayClass82_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass82_0();
				ProfilePlayer profilePlayer = (CS_0024_003C_003E8__locals0.playerSection = SystemRoot.Instance.MetaClient.profile.player_);
				RepeatedField<CraftingRecipeItemData.Types.Ingredient> ingredients_ = recipe.ingredients_;
				if (flag)
				{
					_003C_003Ec__DisplayClass82_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass82_1();
					CS_0024_003C_003E8__locals1.ingredient = (CraftingRecipeItemData.Types.Ingredient)0;
					_003C_003Ec__DisplayClass82_1 _003C_003Ec__DisplayClass82_ = (_003C_003Ec__DisplayClass82_1)(CS_0024_003C_003E8__locals1 * recipeAmount);
					Func<ContainerInventory, bool> _003C_003E9__ = CS_0024_003C_003E8__locals0._003C_003E9__0;
					if (_003C_003E9__ == null)
					{
						Func<ContainerInventory, bool> func = (CS_0024_003C_003E8__locals0._003C_003E9__0 = (Func<ContainerInventory, bool>)(object)(Func<T, TResult>)delegate(ContainerInventory x)
						{
							if (x.belongsToPlayer_)
							{
								ContainerInventory backpack = CS_0024_003C_003E8__locals0.playerSection.Backpack;
								if (x != backpack)
								{
									ContainerInventory homeStorage = CS_0024_003C_003E8__locals0.playerSection.HomeStorage;
									return x != homeStorage;
								}
							}
							int num5 = 0;
							throw new NullReferenceException();
						});
					}
					IEnumerable<ContainerInventory> enumerable = (IEnumerable<ContainerInventory>)Enumerable.Where<ContainerInventory>((IEnumerable<>)collection, (Func<, >)(object)_003C_003E9__);
					Func<ContainerInventory, int> func2 = (Func<ContainerInventory, int>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000e
						Item item = CS_0024_003C_003E8__locals1.ingredient.Item;
						int result = default(int);
						return result;
					};
					int num3 = Enumerable.Sum<ContainerInventory>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
					if (flag2)
					{
					}
					if (itemType == ItemType.Currency)
					{
					}
					num += num;
					num += num3;
					int num4 = 0;
					num++;
				}
				num++;
				if (CS_0024_003C_003E8__locals0 == null)
				{
					break;
				}
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600181B")]
		[Cpp2IlInjected.Address(RVA = "0x14B4370", Offset = "0x14B2D70", VA = "0x1814B4370")]
		private bool HasEnoughSpaceInBackpack(CraftingRecipeItemData recipe, int recipeAmount)
		{
			//Discarded unreachable code: IL_0056, IL_005c
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = recipe.result_.Item;
			IBackpackItem backpackItem = default(IBackpackItem);
			if (backpackItem != null)
			{
				ContainerInventory containerInventory = SystemRoot.Instance.MetaClient.profile.Backpack.Clone();
				RepeatedField<CraftingRecipeItemData.Types.Ingredient> ingredients_ = recipe.ingredients_;
				bool flag = default(bool);
				if (flag)
				{
					int num2 = default(int);
					while (num2 <= 0)
					{
					}
				}
				int num3 = 0;
				ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
				if (canAddResult == ContainerInventory.CanAddResult.InventoryFull)
				{
					int num4 = 0;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600181C")]
		[Cpp2IlInjected.Address(RVA = "0x14B59F0", Offset = "0x14B43F0", VA = "0x1814B59F0")]
		private void OnRecipeItemSelect(ListEventData item)
		{
			//Discarded unreachable code: IL_00f0
			//IL_0072: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			int num = (_selectedRecipeIndex = item.ItemIndex);
			GameObject gameObject = (_selectedRecipeItem = item.DisplayObject);
			_recipesScrollList.RefreshCells();
			RefreshSelectedRecipe();
			CraftingRecipeItem component = item.DisplayObject.GetComponent<CraftingRecipeItem>();
			if (component.IsNew)
			{
				List<(CraftingRecipeItemData, int)> allRecipes = _allRecipes;
				List<Item> recipesToSetAsSeen = _recipesToSetAsSeen;
				int selectedRecipeIndex = _selectedRecipeIndex;
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num2 += num2;
				int price = ((BattlePassReward)num2).Price;
				Client metaClient = SystemRoot.Instance.MetaClient;
				SetCraftingRecipeAsSeen.Types.Request request = new SetCraftingRecipeAsSeen.Types.Request();
				List<(CraftingRecipeItemData, int)> allRecipes2 = _allRecipes;
				int selectedRecipeIndex2 = _selectedRecipeIndex;
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num3 += num3;
				int num4 = (request.craftingRecipeItemID_ = ((BattlePassReward)num3).Price);
				int num5 = 0;
				metaClient.SetCraftingRecipeAsSeen(request, (CancellationToken)num5).FireAndForgetTask();
				int num6 = ((component.IsNew = false) ? 1 : 0);
			}
			SystemRoot.Instance._avatar.Animator.SetTrigger("CraftSelect");
		}

		[Cpp2IlInjected.Token(Token = "0x600181D")]
		[Cpp2IlInjected.Address(RVA = "0x14B6FC0", Offset = "0x14B59C0", VA = "0x1814B6FC0")]
		private void RefreshSelectedRecipe()
		{
			//Discarded unreachable code: IL_0063
			//IL_0041: Expected I4, but got I8
			if (_selectedRecipeIndex >= 0)
			{
				AnimateRecipeIn();
				List<(CraftingRecipeItemData, int)> allRecipes = _allRecipes;
				int selectedRecipeIndex = _selectedRecipeIndex;
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num += num;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				AsyncAtlassedIcon recipeIcon = _recipeIcon;
				_selectedRecipeAmount = 1;
				TextBase recipeName = _recipeName;
				int totalCount = default(int);
				_recipeIngredients.TotalCount = totalCount;
				RefreshRecipeDetailsSize();
				RefreshSelectedRecipeAmount();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600181E")]
		[Cpp2IlInjected.Address(RVA = "0x14B6860", Offset = "0x14B5260", VA = "0x1814B6860")]
		private void RefreshRecipeDetailsSize()
		{
			//Discarded unreachable code: IL_0072
			//IL_0071: Expected O, but got I4
			GridLayoutGroup component = _recipeIngredients.m_Content.GetComponent<GridLayoutGroup>();
			Vector2 offsetMax = _recipeIngredients.m_Content.offsetMax;
			int top = ((LayoutGroup)component).m_Padding.top;
			Vector2 offsetMin = _recipeIngredients.m_Content.offsetMin;
			int bottom = ((LayoutGroup)component).m_Padding.bottom;
			ListBase recipeIngredients = _recipeIngredients;
			RectTransform recipe = _recipe;
			int num = 0;
			Vector2 sizeDelta = recipe.sizeDelta;
			recipe.sizeDelta = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x600181F")]
		[Cpp2IlInjected.Address(RVA = "0x14B6E20", Offset = "0x14B5820", VA = "0x1814B6E20")]
		private void RefreshSelectedRecipeAmount()
		{
			//Discarded unreachable code: IL_009a
			TextBase recipeCount = _recipeCount;
			int selectedRecipeAmount = _selectedRecipeAmount;
			string text = default(string);
			recipeCount.Text = text;
			int selectedRecipeAmount2 = _selectedRecipeAmount;
			CustomButton recipeCraftButton = _recipeCraftButton;
			bool isActivated = (recipeCraftButton.IsInteractable = CanCraft(selectedRecipeAmount2));
			recipeCraftButton.IsActivated = isActivated;
			BaseButton recipeCountMinusButton = _recipeCountMinusButton;
			Button buttonComponent = recipeCountMinusButton.ButtonComponent;
			bool isActive = (buttonComponent.interactable = CanCraft(2));
			recipeCountMinusButton.IsActive = isActive;
			BaseButton recipeCountPlusButton = _recipeCountPlusButton;
			Button buttonComponent2 = recipeCountPlusButton.ButtonComponent;
			bool isActive2 = (buttonComponent2.interactable = CanCraft(2));
			recipeCountPlusButton.IsActive = isActive2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001820")]
		[Cpp2IlInjected.Address(RVA = "0x14B4F00", Offset = "0x14B3900", VA = "0x1814B4F00")]
		private void OnIngredientItemData(ListBase.ListEventData item)
		{
			//Discarded unreachable code: IL_0040
			CraftingIngredientItem component = item.DisplayObject.GetComponent<CraftingIngredientItem>();
			List<(CraftingRecipeItemData, int)> allRecipes = _allRecipes;
			int selectedRecipeIndex = _selectedRecipeIndex;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			num += num;
			int itemIndex = item.ItemIndex;
			int selectedRecipeAmount = _selectedRecipeAmount;
			CraftingRecipeItemData.Types.Ingredient ingredient = default(CraftingRecipeItemData.Types.Ingredient);
			component.Init(ingredient, selectedRecipeAmount);
		}

		[Cpp2IlInjected.Token(Token = "0x6001821")]
		[Cpp2IlInjected.Address(RVA = "0x14B5D60", Offset = "0x14B4760", VA = "0x1814B5D60")]
		private void OnSubtractPressedHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_0029
			if (_recipeCountMinusButton.ButtonComponent.IsInteractable())
			{
				float num = (_buttonHeldDuration = _holdDurationBeforePress);
				_subtractButtonPressed = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001822")]
		[Cpp2IlInjected.Address(RVA = "0x14B5DC0", Offset = "0x14B47C0", VA = "0x1814B5DC0")]
		private void OnSubtractReleasedHandler(BaseButton button)
		{
			_subtractButtonPressed = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001823")]
		[Cpp2IlInjected.Address(RVA = "0x14B4890", Offset = "0x14B3290", VA = "0x1814B4890")]
		private void OnAddPressedHandler(BaseButton button)
		{
			//Discarded unreachable code: IL_0029
			if (_recipeCountPlusButton.ButtonComponent.IsInteractable())
			{
				float num = (_buttonHeldDuration = _holdDurationBeforePress);
				_addButtonPressed = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001824")]
		[Cpp2IlInjected.Address(RVA = "0x14B48F0", Offset = "0x14B32F0", VA = "0x1814B48F0")]
		private void OnAddReleasedHandler(BaseButton button)
		{
			_addButtonPressed = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001825")]
		[Cpp2IlInjected.Address(RVA = "0x14B4740", Offset = "0x14B3140", VA = "0x1814B4740")]
		private void IncrementAmount()
		{
			//Discarded unreachable code: IL_009c
			//IL_0049: Expected O, but got I4
			//IL_0065: Expected I4, but got I8
			int selectedRecipeAmount = _selectedRecipeAmount;
			int num = 0;
			int availableCrafts = GetAvailableCrafts();
			if (selectedRecipeAmount < availableCrafts)
			{
				List<(CraftingRecipeItemData, int)> allRecipes = _allRecipes;
				int selectedRecipeIndex = _selectedRecipeIndex;
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				int selectedRecipeAmount2 = _selectedRecipeAmount;
				num2 += num2;
				selectedRecipeAmount2++;
				if (HasEnoughSpaceInBackpack((CraftingRecipeItemData)num, selectedRecipeAmount2))
				{
				}
				int num3 = 0;
				IDesignerHost activeDesigner = ((IDesignerEventService)UiRoot.Instance).ActiveDesigner;
			}
			else
			{
				_selectedRecipeAmount = 1;
				AK.Wwise.Event incrementObjectSFX = _incrementObjectSFX;
				if (incrementObjectSFX != null)
				{
					GameObject gameObject = _recipeCountPlusButton.gameObject;
					uint num4 = incrementObjectSFX.Post(gameObject);
				}
				RefreshSelectedRecipeAmount();
				_recipeIngredients.RefreshCells();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001826")]
		[Cpp2IlInjected.Address(RVA = "0x14B3950", Offset = "0x14B2350", VA = "0x1814B3950")]
		private void DecrementAmount()
		{
			//Discarded unreachable code: IL_0091
			//IL_0040: Expected O, but got I4
			int selectedRecipeAmount = _selectedRecipeAmount;
			if (selectedRecipeAmount != 1)
			{
			}
			int num = 0;
			int availableCrafts = GetAvailableCrafts();
			selectedRecipeAmount = availableCrafts;
			if (availableCrafts <= 0)
			{
				return;
			}
			List<(CraftingRecipeItemData, int)> allRecipes = _allRecipes;
			int selectedRecipeIndex = _selectedRecipeIndex;
			int num2 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			num2 += num2;
			if (HasEnoughSpaceInBackpack((CraftingRecipeItemData)num, selectedRecipeAmount))
			{
				_selectedRecipeAmount = selectedRecipeAmount;
				AK.Wwise.Event decrementObjectSFX = _decrementObjectSFX;
				if (decrementObjectSFX != null)
				{
					GameObject gameObject = _recipeCountMinusButton.gameObject;
					uint num3 = decrementObjectSFX.Post(gameObject);
				}
				RefreshSelectedRecipeAmount();
				_recipeIngredients.RefreshCells();
			}
			else
			{
				int num4 = 0;
				IDesignerHost activeDesigner = ((IDesignerEventService)UiRoot.Instance).ActiveDesigner;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001827")]
		[Cpp2IlInjected.Address(RVA = "0x14B4BC0", Offset = "0x14B35C0", VA = "0x1814B4BC0")]
		public void OnCraftButtonClicked()
		{
			//Discarded unreachable code: IL_0056
			CustomButton recipeCraftButton = _recipeCraftButton;
			int num = ((recipeCraftButton.IsInteractable = false) ? 1 : 0);
			Button buttonComponent = _recipeCountMinusButton.ButtonComponent;
			int num2 = ((buttonComponent.interactable = false) ? 1 : 0);
			Button buttonComponent2 = _recipeCountPlusButton.ButtonComponent;
			int num3 = ((buttonComponent2.interactable = false) ? 1 : 0);
			_subtractButtonPressed = false;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001828")]
		[Cpp2IlInjected.Address(RVA = "0x14B5DD0", Offset = "0x14B47D0", VA = "0x1814B5DD0")]
		public void OnSuccesContinueButtonClicked()
		{
			//Discarded unreachable code: IL_0115
			//IL_0060: Expected F4, but got I4
			float alpha = _successRecipeButtonGroup.alpha;
			AK.Wwise.Event craftStopSFX = _craftStopSFX;
			GameObject gameObject = base.gameObject;
			uint num = craftStopSFX.Post(gameObject);
			UnselectRecipe();
			float alpha2 = _successRecipeGroup.alpha;
			int num2 = 0;
			CanvasGroup successRecipeGroup = _successRecipeGroup;
			int num3 = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(successRecipeGroup, (float)num3, 0.2f);
			CanvasGroup successRecipeGroup2 = _successRecipeGroup;
			int num4 = ((successRecipeGroup2.blocksRaycasts = false) ? 1 : 0);
			RectTransform successRecipe = _successRecipe;
			int num5 = 0;
			float initY;
			Vector3 vector = default(Vector3);
			float num6 = (initY = vector.y);
			TweenerCore<Vector3, Vector3, VectorOptions> t = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_successRecipe, num6, 0.2f, (byte)num5 != 0);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_0016
				RectTransform successRecipe2 = _successRecipe;
				float num9 = initY;
				int num10 = 0;
			};
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.OnComplete(action);
			Coroutine coroutine = Coroutines.Delay(AnimateRecipeListHolderIn, 0.5f);
			Animator animator = SystemRoot.Instance._avatar.Animator;
			int value = 0;
			animator.SetBool("isCrafting", (byte)value != 0);
			Stall _003CCurrentStall_003Ek__BackingField = SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall;
			int num7 = 0;
			int num8 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001829")]
		[Cpp2IlInjected.Address(RVA = "0x14B4900", Offset = "0x14B3300", VA = "0x1814B4900")]
		public void OnCloseButtonClicked()
		{
			//Discarded unreachable code: IL_0053, IL_0054
			PopSelf();
			Animator animator = SystemRoot.Instance._avatar.Animator;
			int value = 0;
			animator.SetBool("isCrafting", (byte)value != 0);
			Stall _003CCurrentStall_003Ek__BackingField = SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall;
			int num = 0;
			int num2 = 0;
			SystemRoot.Instance._avatar.Animator.SetTrigger("Exit");
		}

		[Cpp2IlInjected.Token(Token = "0x600182A")]
		[Cpp2IlInjected.Address(RVA = "0x14B7C40", Offset = "0x14B6640", VA = "0x1814B7C40")]
		private void ShowSuccess(Item craftingRecipeItem, int amountOfCraftingDone)
		{
			//Discarded unreachable code: IL_0098
			AK.Wwise.Event craftSuccessSFX = _craftSuccessSFX;
			GameObject gameObject = base.gameObject;
			uint num = craftSuccessSFX.Post(gameObject);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			CraftingRecipeItemData craftingRecipeItemData = default(CraftingRecipeItemData);
			Item item = craftingRecipeItemData.result_.Item;
			AsyncAtlassedIcon successRecipeIcon = _successRecipeIcon;
			TextBase successRecipeName = _successRecipeName;
			CraftingRecipeItemData.Types.ResultInstance result_ = craftingRecipeItemData.result_;
			string text = default(string);
			_successItemCount.Text = text;
			_successItemCount.transform.RebuildLayout();
			_successItemCount.transform.parent.RebuildLayout();
			int num2 = 0;
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				AnimateSuccessRecipeIn();
			}, 0.5f);
		}

		[Cpp2IlInjected.Token(Token = "0x600182B")]
		[Cpp2IlInjected.Address(RVA = "0x14B4DA0", Offset = "0x14B37A0", VA = "0x1814B4DA0")]
		[AsyncStateMachine(typeof(_003COnCraft_003Ed__99))]
		private Task OnCraft()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600182C")]
		[Cpp2IlInjected.Address(RVA = "0x14B3600", Offset = "0x14B2000", VA = "0x1814B3600")]
		private void Animate(bool animIn, RectTransform rect, CanvasGroup group, float xOffset)
		{
			//Discarded unreachable code: IL_008c
			int num = 0;
			float alpha = group.alpha;
			if (animIn)
			{
			}
			group.blocksRaycasts = animIn;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(group, 1f, 0.2f);
			RectTransform rectTransform = rect;
			if (animIn)
			{
				RectTransform rectTransform2 = rect;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				if (animIn)
				{
				}
			}
			int num2 = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> t = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX((Transform)rect, alpha, 0.2f, (byte)num2 != 0);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_001c
				RectTransform rectTransform3 = rect;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				int num3 = 0;
				SetFocus();
			};
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.OnComplete(action);
		}

		[Cpp2IlInjected.Token(Token = "0x600182D")]
		[Cpp2IlInjected.Address(RVA = "0x14B2CF0", Offset = "0x14B16F0", VA = "0x1814B2CF0")]
		private void AnimateRecipeListHolderIn()
		{
			AK.Wwise.Event recipesListInSFX = _recipesListInSFX;
			if (recipesListInSFX != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = recipesListInSFX.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600182E")]
		[Cpp2IlInjected.Address(RVA = "0x14B2D60", Offset = "0x14B1760", VA = "0x1814B2D60")]
		private void AnimateRecipeListHolderOut()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600182F")]
		[Cpp2IlInjected.Address(RVA = "0x14B2820", Offset = "0x14B1220", VA = "0x1814B2820")]
		private void AnimateRecipeIn()
		{
			//Discarded unreachable code: IL_01c0
			//IL_0010: Invalid comparison between F4 and I4
			//IL_0049: Expected F4, but got I4
			//IL_006f: Expected F4, but got I4
			//IL_00d3: Expected F4, but got I4
			//IL_0153: Expected F4, but got I4
			float alpha = _recipeGroup.alpha;
			int num = 0;
			if (!(alpha > (float)num))
			{
				_inWait = true;
				int num2 = 0;
				Sequence sequence = DOTween.Sequence();
				RectTransform recipe = _recipe;
				RectTransform recipe2 = _recipe;
				RectTransform recipe3 = _recipe;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				Sequence sequence2 = sequence.Insert(num3, t);
				TweenerCore<float, float, FloatOptions> t2 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_recipeGroup, 1f, 0.2f);
				int num4 = 0;
				Sequence sequence3 = sequence.Insert(num4, t2);
				_recipeGroup.blocksRaycasts = true;
				RectTransform recipeItemRect = _recipeItemRect;
				RectTransform recipeItemRect2 = _recipeItemRect;
				int num5 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> t3 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_recipeItemRect, 0.2f, 0.4f, (byte)num5 != 0)).SetEase(Ease.OutQuad);
				Sequence sequence4 = sequence.Insert(0.1f, t3);
				CanvasGroup recipeItemGroup = _recipeItemGroup;
				int num6 = 0;
				recipeItemGroup.alpha = num6;
				TweenerCore<float, float, FloatOptions> t4 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_recipeItemGroup, 1f, 0.4f);
				Sequence sequence5 = sequence.Insert(0.1f, t4);
				RectTransform recipeItemDecoRect = _recipeItemDecoRect;
				RectTransform recipeItemDecoRect2 = _recipeItemDecoRect;
				RectTransform recipeItemDecoRect3 = _recipeItemDecoRect;
				int num7 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> t5 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)recipeItemDecoRect3, 0.2f, 0.4f, (byte)num7 != 0)).SetEase(Ease.OutQuad);
				Sequence sequence6 = sequence.Insert(0.1f, t5);
				CanvasGroup recipeItemDecoGroup = _recipeItemDecoGroup;
				int num8 = 0;
				recipeItemDecoGroup.alpha = num8;
				TweenerCore<float, float, FloatOptions> t6 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_recipeItemDecoGroup, 1f, 0.4f);
				Sequence sequence7 = sequence.Insert(0.1f, t6);
				TweenCallback action = delegate
				{
					_inWait = false;
					SetFocus();
				};
				Sequence sequence8 = sequence.OnComplete(action);
				_recipeCraftButton.IsInteractable = true;
				_recipeCountMinusButton.ButtonComponent.interactable = true;
				_recipeCountPlusButton.ButtonComponent.interactable = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001830")]
		[Cpp2IlInjected.Address(RVA = "0x14B2DA0", Offset = "0x14B17A0", VA = "0x1814B2DA0")]
		private void AnimateRecipeOut()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001831")]
		[Cpp2IlInjected.Address(RVA = "0x14B2DE0", Offset = "0x14B17E0", VA = "0x1814B2DE0")]
		internal void AnimateSuccessRecipeIn()
		{
			//IL_0010: Invalid comparison between F4 and I4
			//IL_0032: Expected O, but got I4
			//IL_0062: Expected F4, but got I4
			//IL_0076: Expected F4, but got I4
			//IL_00a3: Expected F4, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00e6: Expected O, but got I4
			//IL_0129: Expected F4, but got I4
			//IL_015f: Expected O, but got I4
			//IL_017a: Expected O, but got I4
			//IL_01b0: Expected F4, but got I4
			float alpha = _successRecipeGroup.alpha;
			int num = 0;
			if (!(alpha > (float)num))
			{
				RectTransform rectTransform = _successRecipeName.RectTransform;
				int num2 = 0;
				Vector2 sizeDelta = rectTransform.sizeDelta;
				rectTransform.sizeDelta = (Vector2)num2;
				_successRecipeGroup.alpha = 1f;
				_successRecipeGroup.blocksRaycasts = true;
				CanvasGroup successRecipeBackgroundGroup = _successRecipeBackgroundGroup;
				int num3 = 0;
				successRecipeBackgroundGroup.alpha = num3;
				CanvasGroup successRecipeButtonGroup = _successRecipeButtonGroup;
				int num4 = 0;
				successRecipeButtonGroup.alpha = num4;
				RectTransform successItemRect = _successItemRect;
				RectTransform successItemRect2 = _successItemRect;
				int num5 = 0;
				RectTransform successItemRect3 = _successItemRect;
				int num6 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)successItemRect3, (float)num, 0.2f, (byte)num6 != 0);
				Vector2 sizeDelta2 = _successRecipeBackground.sizeDelta;
				RectTransform successRecipeBackground = _successRecipeBackground;
				int num7 = 0;
				Vector2 sizeDelta3 = successRecipeBackground.sizeDelta;
				successRecipeBackground.sizeDelta = (Vector2)num7;
				int num8 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOSizeDelta(_successRecipeBackground, (Vector2)num7, 0.3f, (byte)num8 != 0);
				TweenerCore<float, float, FloatOptions> tweenerCore3 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_successRecipeBackgroundGroup, 1f, 0.2f);
				RectTransform successItemDecoTopRect = _successItemDecoTopRect;
				RectTransform successItemDecoTopRect2 = _successItemDecoTopRect;
				RectTransform successItemDecoTopRect3 = _successItemDecoTopRect;
				int num9 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)successItemDecoTopRect3, (float)num, 0.3f, (byte)num9 != 0)).SetDelay(0.3f);
				Vector2 sizeDelta4 = _successItemDecoBottomRect.sizeDelta;
				RectTransform successItemDecoBottomRect = _successItemDecoBottomRect;
				int num10 = 0;
				Vector2 sizeDelta5 = successItemDecoBottomRect.sizeDelta;
				successItemDecoBottomRect.sizeDelta = (Vector2)num10;
				RectTransform successItemDecoBottomRect2 = _successItemDecoBottomRect;
				int num11 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOSizeDelta(successItemDecoBottomRect2, (Vector2)num10, 0.3f, (byte)num11 != 0)).SetDelay(0.3f);
				RectTransform successRecipeButton = _successRecipeButton;
				RectTransform successRecipeButton2 = _successRecipeButton;
				RectTransform successRecipeButton3 = _successRecipeButton;
				int num12 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore6 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)successRecipeButton3, (float)num, 0.2f, (byte)num12 != 0)).SetDelay(0.525f);
				TweenerCore<float, float, FloatOptions> t = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_successRecipeButtonGroup, 1f, 0.2f)).SetDelay(0.525f);
				TweenCallback action = SetFocus;
				TweenerCore<float, float, FloatOptions> tweenerCore7 = t.OnComplete(action);
				ITagData lastTagSelected = _lastTagSelected;
				if (lastTagSelected == null)
				{
					Profile profile = SystemRoot.Instance.MetaClient.profile;
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
					List<(CraftingRecipeItemData, int)> list = (_allRecipes = (List<(CraftingRecipeItemData data, int maxCraft)>)(object)profile.GetAvailableCraftingRecipesInfo((ITransactionContext)_003CTransactionContext_003Ek__BackingField));
					RefillRecipes();
					throw new NullReferenceException();
				}
				RefreshRecipes(lastTagSelected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001832")]
		[Cpp2IlInjected.Address(RVA = "0x14B3480", Offset = "0x14B1E80", VA = "0x1814B3480")]
		internal void AnimateSuccessRecipeOut()
		{
			//Discarded unreachable code: IL_0090
			//IL_002e: Expected F4, but got I4
			float alpha = _successRecipeGroup.alpha;
			CanvasGroup successRecipeGroup = _successRecipeGroup;
			int num = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(successRecipeGroup, (float)num, 0.2f);
			CanvasGroup successRecipeGroup2 = _successRecipeGroup;
			int num2 = ((successRecipeGroup2.blocksRaycasts = false) ? 1 : 0);
			RectTransform successRecipe = _successRecipe;
			int num3 = 0;
			float initY;
			Vector3 vector = default(Vector3);
			float num4 = (initY = vector.y);
			TweenerCore<Vector3, Vector3, VectorOptions> t = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_successRecipe, num4, 0.2f, (byte)num3 != 0);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_0016
				RectTransform successRecipe2 = _successRecipe;
				float num5 = initY;
				int num6 = 0;
			};
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.OnComplete(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6001833")]
		[Cpp2IlInjected.Address(RVA = "0x14B4BA0", Offset = "0x14B35A0", VA = "0x1814B4BA0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001834")]
		[Cpp2IlInjected.Address(RVA = "0x14B7890", Offset = "0x14B6290", VA = "0x1814B7890")]
		private void SetFocus()
		{
			//IL_0069: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			if (!(_recipeGroup.alpha >= 1f))
			{
				if (!(_successRecipeGroup.alpha >= 1f))
				{
					float alpha = _recipeListHolderGroup.alpha;
					LoopVerticalScrollRect recipesScrollList = _recipesScrollList;
					GameObject selectedRecipeItem = _selectedRecipeItem;
					int num2 = 0;
					if (!(selectedRecipeItem != (UnityEngine.Object)num2))
					{
						int firstVisibleItemIndex = _recipesScrollList.GetFirstVisibleItemIndex();
						int childCount = ((LoopScrollRect)_recipesScrollList).m_Content.childCount;
						if (firstVisibleItemIndex < childCount)
						{
							FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
							FocusNavigationElement component = ((LoopScrollRect)_recipesScrollList).m_Content.GetChild(firstVisibleItemIndex).GetComponent<FocusNavigationElement>();
							focusNavigation.SetFocus(component);
							LoopVerticalScrollRect recipesScrollList2 = _recipesScrollList;
							int num3 = 0;
							int num4 = 0;
							recipesScrollList2.ScrollToCell(firstVisibleItemIndex, 1000f, (Action)num4);
						}
						else
						{
							firstVisibleItemIndex = childCount;
							Debug.LogWarning($"[UI] CraftingMenu#SetFocus Invalid index to set focus: {firstVisibleItemIndex} childCount={childCount}", this);
						}
						return;
					}
					MenuNavigation menuNavigation = base.MenuNavigation;
					FocusNavigationElement component2 = _selectedRecipeItem.GetComponent<FocusNavigationElement>();
				}
				MenuNavigation menuNavigation2 = base.MenuNavigation;
				RectTransform successRecipeButton = _successRecipeButton;
				FocusNavigation focusNavigation2 = menuNavigation2.FocusNavigation;
				FocusNavigationElement component3 = successRecipeButton.GetComponent<FocusNavigationElement>();
				focusNavigation2.SetFocus(component3);
				return;
			}
			MenuNavigation menuNavigation3 = base.MenuNavigation;
			CustomButton recipeCraftButton = _recipeCraftButton;
			FocusNavigation focusNavigation3 = menuNavigation3.FocusNavigation;
			if (recipeCraftButton.isActiveAndEnabled)
			{
				CustomButton recipeCraftButton2 = _recipeCraftButton;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001835")]
		[Cpp2IlInjected.Address(RVA = "0x14B3C00", Offset = "0x14B2600", VA = "0x1814B3C00", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_00ce, IL_00d5
			//IL_0078: Invalid comparison between F4 and I4
			if (redirectionType > RedirectionType.GamePopCurrentMenu)
			{
				if (redirectionType == RedirectionType.GameTabLeft)
				{
					if (!_inWait)
					{
						_navigationBar.SelectPrevious();
					}
				}
				else
				{
					while (redirectionType != RedirectionType.GameTabRight)
					{
					}
					while (_inWait)
					{
					}
					_navigationBar.SelectNext();
				}
				return;
			}
			if (redirectionType != RedirectionType.MenuNavGoBackward)
			{
				while (redirectionType != RedirectionType.GamePopCurrentMenu)
				{
				}
			}
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			int num2 = 0;
			if (flag && !(_recipeGroup.alpha <= (float)num2))
			{
				CanvasGroup recipeGroup = _recipeGroup;
				float alpha = recipeGroup.alpha;
				while ((object)recipeGroup != null)
				{
				}
				UnselectRecipe();
				return;
			}
			float alpha2 = _successRecipeGroup.alpha;
			float alpha3 = _recipeListHolderGroup.alpha;
			CanvasGroup recipeListHolderGroup = _recipeListHolderGroup;
			float alpha4 = recipeListHolderGroup.alpha;
			while ((object)recipeListHolderGroup != null)
			{
			}
			OnCloseButtonClicked();
		}

		[Cpp2IlInjected.Token(Token = "0x6001836")]
		[Cpp2IlInjected.Address(RVA = "0x14B8A90", Offset = "0x14B7490", VA = "0x1814B8A90")]
		public CraftingMenu()
		{
		}//IL_001d: Expected I4, but got I8
		//IL_0048: Expected I4, but got I8

	}
}
