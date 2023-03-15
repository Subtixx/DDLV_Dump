using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003B1")]
	[RequiredAllNotNull]
	public class RecipeContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001208")]
		[SerializeField]
		private Button _btnRecipes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001209")]
		[SerializeField]
		[Nulllable]
		private RecipesListContent _mcRecipesListContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400120A")]
		[SerializeField]
		private SelectedRecipeContent _mcSelectedRecipeContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400120B")]
		[SerializeField]
		private RectTransform _tabsAndListContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400120C")]
		[SerializeField]
		private float _recipeListSizeClosed = 136f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400120D")]
		[SerializeField]
		private float _recipeListSizeOpened = 858f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400120E")]
		[SerializeField]
		private float _recipeListSizeOpenedSmallHeader = 938f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400120F")]
		[Nulllable]
		[SerializeField]
		private CookingHistoryContent _mcHistoryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001210")]
		[SerializeField]
		private GameObject BtnOpenGamepadIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001211")]
		[SerializeField]
		private GameObject _noRecipeHeader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001212")]
		[SerializeField]
		private Transform _arrowBtnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001213")]
		[SerializeField]
		private Transform _arrowHLClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001214")]
		[SerializeField]
		private AK.Wwise.Event _expandRecipeSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001215")]
		[SerializeField]
		private AK.Wwise.Event _collapseRecipeSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001218")]
		private bool _isListOpen;

		[Cpp2IlInjected.Token(Token = "0x170003EF")]
		private float RecipeListSizeOpened
		{
			[Cpp2IlInjected.Token(Token = "0x6001767")]
			[Cpp2IlInjected.Address(RVA = "0xF36BC0", Offset = "0xF355C0", VA = "0x180F36BC0")]
			get
			{
				//Discarded unreachable code: IL_001e
				if ((long)_mcSelectedRecipeContent.RecipeItemData == 0)
				{
					return _recipeListSizeOpenedSmallHeader;
				}
				return _recipeListSizeOpened;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F0")]
		public RecipesListContent RecipesListContent
		{
			[Cpp2IlInjected.Token(Token = "0x6001768")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _mcRecipesListContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F1")]
		public SelectedRecipeContent SelectedRecipeContent
		{
			[Cpp2IlInjected.Token(Token = "0x6001769")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _mcSelectedRecipeContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F2")]
		public CookingHistoryContent CookingHistoryContent
		{
			[Cpp2IlInjected.Token(Token = "0x600176A")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _mcHistoryContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F3")]
		public bool IsListOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600176F")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEA0", Offset = "0x7D98A0", VA = "0x1807DAEA0")]
			get
			{
				return _isListOpen;
			}
			[Cpp2IlInjected.Token(Token = "0x6001770")]
			[Cpp2IlInjected.Address(RVA = "0xF37070", Offset = "0xF35A70", VA = "0x180F37070")]
			set
			{
				//Discarded unreachable code: IL_006e
				_isListOpen = value;
				_mcRecipesListContent.CanvasGroup.interactable = value;
				CanvasGroup canvasGroup = _mcRecipesListContent.CanvasGroup;
				bool flag = (canvasGroup.blocksRaycasts = _isListOpen);
				int _003C_003E1__state = default(int);
				_003CUpdateGamepadIndicator_003Ed__35 _003CUpdateGamepadIndicator_003Ed__ = new _003CUpdateGamepadIndicator_003Ed__35(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CUpdateGamepadIndicator_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CUpdateGamepadIndicator_003Ed__);
				Transform arrowBtnClose = _arrowBtnClose;
				if (_isListOpen)
				{
				}
				Transform arrowHLClose = _arrowHLClose;
				if (_isListOpen)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event EventHandler<Item> SelectedRecipeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600176B")]
			[Cpp2IlInjected.Address(RVA = "0xF36B20", Offset = "0xF35520", VA = "0x180F36B20")]
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
			[Cpp2IlInjected.Token(Token = "0x600176C")]
			[Cpp2IlInjected.Address(RVA = "0xF36FD0", Offset = "0xF359D0", VA = "0x180F36FD0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event EventHandler OnListChangeState
		{
			[Cpp2IlInjected.Token(Token = "0x600176D")]
			[Cpp2IlInjected.Address(RVA = "0xF36A80", Offset = "0xF35480", VA = "0x180F36A80")]
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
			[Cpp2IlInjected.Token(Token = "0x600176E")]
			[Cpp2IlInjected.Address(RVA = "0xF36F30", Offset = "0xF35930", VA = "0x180F36F30")]
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

		[Cpp2IlInjected.Token(Token = "0x6001771")]
		[Cpp2IlInjected.Address(RVA = "0xF36580", Offset = "0xF34F80", VA = "0x180F36580")]
		private void Start()
		{
			//IL_0015: Expected O, but got I4
			CustomButton component = _btnRecipes.GetComponent<CustomButton>();
			int num = 0;
			if (!(component != (UnityEngine.Object)num))
			{
				Button btnRecipes = _btnRecipes;
			}
			UnityEvent onClicked = component.OnClicked;
			UnityAction call = OnRecipesClickHandler;
			onClicked.AddListener(call);
			SelectedRecipeContent mcSelectedRecipeContent = _mcSelectedRecipeContent;
			SelectedRecipeContent.OnClickDelegate onRemove = mcSelectedRecipeContent.OnRemove;
			SelectedRecipeContent.OnClickDelegate b = onRemoveSelectedRecipe;
			Delegate @delegate = Delegate.Combine(onRemove, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				mcSelectedRecipeContent.OnRemove = (SelectedRecipeContent.OnClickDelegate)@delegate;
				SelectedRecipeContent mcSelectedRecipeContent2 = _mcSelectedRecipeContent;
				SelectedRecipeContent.OnClickDelegate onClick = mcSelectedRecipeContent2.OnClick;
				SelectedRecipeContent.OnClickDelegate b2 = OnRecipesClickHandler;
				Delegate delegate2 = Delegate.Combine(onClick, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcSelectedRecipeContent2.OnClick = (SelectedRecipeContent.OnClickDelegate)delegate2;
					RecipesListContent mcRecipesListContent = _mcRecipesListContent;
					RecipesListContent.OnSelectRecipesListDelegate onSelect = mcRecipesListContent.OnSelect;
					RecipesListContent.OnSelectRecipesListDelegate b3 = OnSelectRecipeHandler;
					Delegate delegate3 = Delegate.Combine(onSelect, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						mcRecipesListContent.OnSelect = (RecipesListContent.OnSelectRecipesListDelegate)delegate3;
						CookingHistoryContent mcHistoryContent = _mcHistoryContent;
						CookingHistoryContent.OnCloseDelegate onClose = mcHistoryContent.OnClose;
						CookingHistoryContent.OnCloseDelegate b4 = OnHistoryCloseHandler;
						Delegate delegate4 = Delegate.Combine(onClose, b4);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							mcHistoryContent.OnClose = (CookingHistoryContent.OnCloseDelegate)delegate4;
							throw new NullReferenceException();
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001772")]
		[Cpp2IlInjected.Address(RVA = "0xF357A0", Offset = "0xF341A0", VA = "0x180F357A0")]
		private void OnDestroy()
		{
			//IL_002c: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CUpdateGamepadIndicator_003Ed__35 _003CUpdateGamepadIndicator_003Ed__ = new _003CUpdateGamepadIndicator_003Ed__35(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateGamepadIndicator_003Ed__._003C_003E4__this = this;
			StopCoroutine(_003CUpdateGamepadIndicator_003Ed__);
			CustomButton component = _btnRecipes.GetComponent<CustomButton>();
			int num = 0;
			if (!(component != (UnityEngine.Object)num))
			{
				Button btnRecipes = _btnRecipes;
			}
			UnityEvent onClicked = component.OnClicked;
			UnityAction call = OnRecipesClickHandler;
			onClicked.RemoveListener(call);
			SelectedRecipeContent mcSelectedRecipeContent = _mcSelectedRecipeContent;
			SelectedRecipeContent.OnClickDelegate onRemove = mcSelectedRecipeContent.OnRemove;
			SelectedRecipeContent.OnClickDelegate value = onRemoveSelectedRecipe;
			Delegate @delegate = Delegate.Remove(onRemove, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				mcSelectedRecipeContent.OnRemove = (SelectedRecipeContent.OnClickDelegate)@delegate;
				SelectedRecipeContent mcSelectedRecipeContent2 = _mcSelectedRecipeContent;
				SelectedRecipeContent.OnClickDelegate onClick = mcSelectedRecipeContent2.OnClick;
				SelectedRecipeContent.OnClickDelegate value2 = OnRecipesClickHandler;
				Delegate delegate2 = Delegate.Remove(onClick, value2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					mcSelectedRecipeContent2.OnClick = (SelectedRecipeContent.OnClickDelegate)delegate2;
					RecipesListContent mcRecipesListContent = _mcRecipesListContent;
					RecipesListContent.OnSelectRecipesListDelegate onSelect = mcRecipesListContent.OnSelect;
					RecipesListContent.OnSelectRecipesListDelegate value3 = OnSelectRecipeHandler;
					Delegate delegate3 = Delegate.Remove(onSelect, value3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						mcRecipesListContent.OnSelect = (RecipesListContent.OnSelectRecipesListDelegate)delegate3;
						CookingHistoryContent mcHistoryContent = _mcHistoryContent;
						CookingHistoryContent.OnCloseDelegate onClose = mcHistoryContent.OnClose;
						CookingHistoryContent.OnCloseDelegate value4 = OnHistoryCloseHandler;
						Delegate delegate4 = Delegate.Remove(onClose, value4);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							mcHistoryContent.OnClose = (CookingHistoryContent.OnCloseDelegate)delegate4;
							throw new NullReferenceException();
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001773")]
		[Cpp2IlInjected.Address(RVA = "0xF368E0", Offset = "0xF352E0", VA = "0x180F368E0")]
		private void UpdateArrows()
		{
			//Discarded unreachable code: IL_003a
			int _003C_003E1__state = default(int);
			_003CUpdateGamepadIndicator_003Ed__35 _003CUpdateGamepadIndicator_003Ed__ = new _003CUpdateGamepadIndicator_003Ed__35(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateGamepadIndicator_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CUpdateGamepadIndicator_003Ed__);
			Transform arrowBtnClose = _arrowBtnClose;
			if (_isListOpen)
			{
			}
			Transform arrowHLClose = _arrowHLClose;
			if (_isListOpen)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001774")]
		[Cpp2IlInjected.Address(RVA = "0xF369F0", Offset = "0xF353F0", VA = "0x180F369F0")]
		[IteratorStateMachine(typeof(_003CUpdateGamepadIndicator_003Ed__35))]
		private IEnumerator UpdateGamepadIndicator()
		{
			int _003C_003E1__state = default(int);
			_003CUpdateGamepadIndicator_003Ed__35 _003CUpdateGamepadIndicator_003Ed__ = new _003CUpdateGamepadIndicator_003Ed__35(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateGamepadIndicator_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001775")]
		[Cpp2IlInjected.Address(RVA = "0xF36330", Offset = "0xF34D30", VA = "0x180F36330")]
		public void RefreshBtnOpenGamepadIndicator()
		{
			//Discarded unreachable code: IL_0051
			if (!_isListOpen && (long)_mcSelectedRecipeContent.RecipeItemData == 0)
			{
				GameObject btnOpenGamepadIndicator = BtnOpenGamepadIndicator;
				int active = 0;
				btnOpenGamepadIndicator.SetActive((byte)active != 0);
				return;
			}
			GameObject btnOpenGamepadIndicator2 = BtnOpenGamepadIndicator;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool active2 = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			btnOpenGamepadIndicator2.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001776")]
		[Cpp2IlInjected.Address(RVA = "0xF36400", Offset = "0xF34E00", VA = "0x180F36400")]
		internal void ShowRecipeButton(bool showRecipeButton)
		{
			//Discarded unreachable code: IL_0012
			_btnRecipes.gameObject.SetActive(showRecipeButton);
		}

		[Cpp2IlInjected.Token(Token = "0x6001777")]
		[Cpp2IlInjected.Address(RVA = "0xF360F0", Offset = "0xF34AF0", VA = "0x180F360F0")]
		public void OnToggleButton()
		{
			//Discarded unreachable code: IL_0105
			//IL_007d: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			if (!_isListOpen)
			{
			}
			AK.Wwise.Event collapseRecipeSfx = _collapseRecipeSfx;
			if (collapseRecipeSfx != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = collapseRecipeSfx.Post(gameObject);
			}
			if (_isListOpen)
			{
				GameObject gameObject2 = default(GameObject);
				if ((long)_mcSelectedRecipeContent.RecipeItemData == 0)
				{
					onCloseRecipeList();
					int num2 = ((IsListOpen = false) ? 1 : 0);
					gameObject2 = _arrowBtnClose.gameObject;
					gameObject2.SetActive(value: true);
					EventHandler onListChangeState = this.OnListChangeState;
					if (onListChangeState != null)
					{
						int num3 = 0;
						onListChangeState(this, (EventArgs)num3);
					}
					return;
				}
				if ((object)gameObject2 != null)
				{
					Transform transform = _mcRecipesListContent.transform;
					float recipeListSizeClosed = _recipeListSizeClosed;
					int num4 = 0;
					int num5 = ((IsListOpen = false) ? 1 : 0);
				}
			}
			IsListOpen = true;
			Transform transform2 = _mcRecipesListContent.transform;
			if ((long)_mcSelectedRecipeContent.RecipeItemData == 0)
			{
			}
			float recipeListSizeOpened = _recipeListSizeOpened;
			int num6 = 0;
			EventHandler onListChangeState2 = this.OnListChangeState;
			if (onListChangeState2 != null)
			{
				int num7 = 0;
				onListChangeState2(this, (EventArgs)num7);
			}
			while (!_isListOpen)
			{
			}
			_mcRecipesListContent.UpdateSelected();
		}

		[Cpp2IlInjected.Token(Token = "0x6001778")]
		[Cpp2IlInjected.Address(RVA = "0xF35D10", Offset = "0xF34710", VA = "0x180F35D10")]
		public void OnSelectRecipeHandler(RecipeItemData itemdata)
		{
			//Discarded unreachable code: IL_0192
			//IL_006d: Expected I4, but got I8
			//IL_00df: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0116: Expected I4, but got I8
			//IL_012f: Expected I4, but got I8
			//IL_0138: Expected O, but got I4
			//IL_0173: Expected I4, but got I8
			GameObject noRecipeHeader = _noRecipeHeader;
			int active = 0;
			noRecipeHeader.SetActive((byte)active != 0);
			GameObject gameObject = _btnRecipes.gameObject;
			int active2 = 0;
			gameObject.SetActive((byte)active2 != 0);
			SelectedRecipeContent mcSelectedRecipeContent = _mcSelectedRecipeContent;
			if (mcSelectedRecipeContent.RecipeItemData != itemdata)
			{
				mcSelectedRecipeContent.RecipeItemData = itemdata;
				Transform transform = _mcSelectedRecipeContent.transform;
				float z = Vector3.zero.z;
				ulong num = default(ulong);
				_mcSelectedRecipeContent.gameObject.SetActive((byte)num != 0);
				_mcSelectedRecipeContent.RefreshDisplay();
				Transform transform2 = _mcSelectedRecipeContent.transform;
				float z2 = Vector3.one.z;
				Transform transform3 = _mcRecipesListContent.transform;
				float recipeListSizeClosed = _recipeListSizeClosed;
				int num2 = 0;
				if (this.SelectedRecipeChanged != null)
				{
					int iD = itemdata.ID;
				}
				int num3 = ((IsListOpen = false) ? 1 : 0);
				EventHandler onListChangeState = this.OnListChangeState;
				if (onListChangeState != null)
				{
					int num4 = 0;
					onListChangeState(this, (EventArgs)num4);
				}
				return;
			}
			GameObject gameObject2 = mcSelectedRecipeContent.gameObject;
			int active3 = 0;
			gameObject2.SetActive((byte)active3 != 0);
			SelectedRecipeContent mcSelectedRecipeContent2 = _mcSelectedRecipeContent;
			int num5 = 0;
			mcSelectedRecipeContent2.RecipeItemData = (RecipeItemData)num5;
			ulong num6 = default(ulong);
			_noRecipeHeader.SetActive((byte)num6 != 0);
			RecipesListContent mcRecipesListContent = _mcRecipesListContent;
			mcRecipesListContent._selectedRecipeIndex = -1;
			mcRecipesListContent._selectedRecipeData = (RecipeItemData)num5;
			int fromFocusChange = 0;
			mcRecipesListContent.RefreshDisplay((byte)fromFocusChange != 0);
			Transform transform4 = _mcRecipesListContent.transform;
			if ((IntPtr)_mcSelectedRecipeContent.RecipeItemData == (IntPtr)num5)
			{
			}
			float recipeListSizeOpened = _recipeListSizeOpened;
			int num7 = 0;
			ulong num8 = default(ulong);
			IsListOpen = (byte)num8 != 0;
			EventHandler<Item> selectedRecipeChanged = this.SelectedRecipeChanged;
			while (selectedRecipeChanged == null)
			{
			}
			Item invalid = Item.Invalid;
			selectedRecipeChanged(this, (TEventArgs)invalid);
		}

		[Cpp2IlInjected.Token(Token = "0x6001779")]
		[Cpp2IlInjected.Address(RVA = "0xF36BF0", Offset = "0xF355F0", VA = "0x180F36BF0")]
		private void onCloseRecipeList()
		{
			//Discarded unreachable code: IL_0098
			if ((long)_mcSelectedRecipeContent.RecipeItemData != 0)
			{
				Transform transform = _mcRecipesListContent.transform;
				float recipeListSizeClosed = _recipeListSizeClosed;
				int num = 0;
			}
			RecipesListContent mcRecipesListContent = _mcRecipesListContent;
			int active = 0;
			GameObject gameObject = mcRecipesListContent.gameObject;
			SelectedRecipeContent mcSelectedRecipeContent = _mcSelectedRecipeContent;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _btnRecipes.gameObject;
			bool active2 = (long)_mcSelectedRecipeContent.RecipeItemData == 0;
			gameObject2.SetActive(active2);
			SelectedRecipeContent mcSelectedRecipeContent2 = _mcSelectedRecipeContent;
			GameObject noRecipeHeader = _noRecipeHeader;
			bool active3 = (long)mcSelectedRecipeContent2.RecipeItemData == 0;
			noRecipeHeader.SetActive(active3);
		}

		[Cpp2IlInjected.Token(Token = "0x600177A")]
		[Cpp2IlInjected.Address(RVA = "0xF363B0", Offset = "0xF34DB0", VA = "0x180F363B0")]
		public void RefreshRecipeButton()
		{
			//Discarded unreachable code: IL_0025
			GameObject gameObject = _btnRecipes.gameObject;
			bool active = (long)_mcSelectedRecipeContent.RecipeItemData == 0;
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x600177B")]
		[Cpp2IlInjected.Address(RVA = "0xF36D20", Offset = "0xF35720", VA = "0x180F36D20")]
		private void onRemoveSelectedRecipe()
		{
			//Discarded unreachable code: IL_00db
			//IL_0096: Expected I4, but got I8
			//IL_00da: Expected O, but got I4
			Transform transform = _mcRecipesListContent.transform;
			if ((long)_mcSelectedRecipeContent.RecipeItemData == 0)
			{
			}
			float recipeListSizeOpened = _recipeListSizeOpened;
			int num = 0;
			_btnRecipes.gameObject.SetActive(value: true);
			GameObject gameObject = _mcSelectedRecipeContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcRecipesListContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_noRecipeHeader.SetActive(value: true);
			int num2 = ((IsListOpen = false) ? 1 : 0);
			RecipesListContent mcRecipesListContent = _mcRecipesListContent;
			mcRecipesListContent._selectedRecipeIndex = -1;
			int fromFocusChange = 0;
			mcRecipesListContent.RefreshDisplay((byte)fromFocusChange != 0);
			EventHandler<Item> selectedRecipeChanged = this.SelectedRecipeChanged;
			if (selectedRecipeChanged != null)
			{
				Item invalid = Item.Invalid;
				selectedRecipeChanged(this, (TEventArgs)invalid);
			}
			EventHandler onListChangeState = this.OnListChangeState;
			if (onListChangeState != null)
			{
				int num3 = 0;
				onListChangeState(this, (EventArgs)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600177C")]
		[Cpp2IlInjected.Address(RVA = "0xF35B80", Offset = "0xF34580", VA = "0x180F35B80")]
		private void OnRecipesClickHandler()
		{
			//Discarded unreachable code: IL_00c4
			//IL_0052: Expected I4, but got I8
			//IL_005b: Expected I4, but got I8
			//IL_00c3: Expected O, but got I4
			if (!_isListOpen)
			{
				Transform transform = _mcRecipesListContent.transform;
				if ((long)_mcSelectedRecipeContent.RecipeItemData == 0)
				{
				}
				float recipeListSizeOpened = _recipeListSizeOpened;
				int num = 0;
				_mcRecipesListContent.gameObject.SetActive(value: true);
				RecipesListContent mcRecipesListContent = _mcRecipesListContent;
				mcRecipesListContent._selectedIndex = 0;
				mcRecipesListContent._currentFocusArea = RecipesListContent.FocusArea.CategoryList;
				if (mcRecipesListContent._forceUpdate)
				{
					mcRecipesListContent.UpdateInfo();
					mcRecipesListContent._forceUpdate = false;
				}
				mcRecipesListContent.UpdateSelected();
				GameObject gameObject = _btnRecipes.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			onCloseRecipeList();
			bool flag2 = (IsListOpen = !_isListOpen);
			EventHandler onListChangeState = this.OnListChangeState;
			if (onListChangeState != null)
			{
				int num2 = 0;
				onListChangeState(this, (EventArgs)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600177D")]
		[Cpp2IlInjected.Address(RVA = "0xF36440", Offset = "0xF34E40", VA = "0x180F36440")]
		private void ShowRecipeList()
		{
			//Discarded unreachable code: IL_0085
			//IL_0046: Expected I4, but got I8
			//IL_004f: Expected I4, but got I8
			Transform transform = _mcRecipesListContent.transform;
			if ((long)_mcSelectedRecipeContent.RecipeItemData == 0)
			{
			}
			float recipeListSizeOpened = _recipeListSizeOpened;
			int num = 0;
			_mcRecipesListContent.gameObject.SetActive(value: true);
			RecipesListContent mcRecipesListContent = _mcRecipesListContent;
			mcRecipesListContent._selectedIndex = 0;
			mcRecipesListContent._currentFocusArea = RecipesListContent.FocusArea.CategoryList;
			if (mcRecipesListContent._forceUpdate)
			{
				mcRecipesListContent.UpdateInfo();
				mcRecipesListContent._forceUpdate = false;
			}
			mcRecipesListContent.UpdateSelected();
			GameObject gameObject = _btnRecipes.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600177E")]
		[Cpp2IlInjected.Address(RVA = "0xF35620", Offset = "0xF34020", VA = "0x180F35620")]
		internal void ForceRefresh()
		{
			//Discarded unreachable code: IL_0065
			_mcHistoryContent.ForceUpdate();
			RecipesListContent mcRecipesListContent = _mcRecipesListContent;
			if (!mcRecipesListContent.gameObject.activeSelf)
			{
				mcRecipesListContent._forceUpdate = true;
			}
			mcRecipesListContent.UpdateInfo();
			int fromFocusChange = 0;
			mcRecipesListContent.RefreshDisplay((byte)fromFocusChange != 0);
			if (_mcSelectedRecipeContent.gameObject.activeSelf)
			{
				Profile profile = SystemRoot.Instance.Client.Profile;
				_mcSelectedRecipeContent.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600177F")]
		[Cpp2IlInjected.Address(RVA = "0xF35B50", Offset = "0xF34550", VA = "0x180F35B50")]
		internal void OnHistoryCloseHandler()
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = _mcHistoryContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001780")]
		[Cpp2IlInjected.Address(RVA = "0xF36310", Offset = "0xF34D10", VA = "0x180F36310")]
		public bool RecipeSelected()
		{
			SelectedRecipeContent mcSelectedRecipeContent = _mcSelectedRecipeContent;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001781")]
		[Cpp2IlInjected.Address(RVA = "0xF36A60", Offset = "0xF35460", VA = "0x180F36A60")]
		public RecipeContent()
		{
		}
	}
}
