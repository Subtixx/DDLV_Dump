using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.InputSystem;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000345")]
	public class SkinPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000346")]
		internal class SkinPopupParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000F67")]
			public CharacterSkinItemData[] Skins;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000F68")]
			public CharacterManager.CharacterInstance CharacterInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000F69")]
			public CharacterItemData CharacterItemData;

			[Cpp2IlInjected.Token(Token = "0x60014A2")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public SkinPopupParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000F5A")]
		[SerializeField]
		private CollectionItem _itemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000F5B")]
		[SerializeField]
		private GameObject _itemContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000F5C")]
		[SerializeField]
		private float _desiredWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000F5D")]
		[SerializeField]
		private float _desiredHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000F5E")]
		[SerializeField]
		private FocusNavigationElement _selectBtnNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000F5F")]
		[SerializeField]
		private AK.Wwise.Event _selectSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000F60")]
		[SerializeField]
		private string _befriendStringId = "menu.collection_befriend";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000F61")]
		[SerializeField]
		private string _conditionStoryStringId = "menu.collection_condition_story";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000F62")]
		[SerializeField]
		private string _conditionEventStringId = "menu.collection_condition_event";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000F63")]
		private SkinPopupParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000F64")]
		private CollectionMenu collectionMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000F65")]
		private CollectionItem _currentSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000F66")]
		private InputAction _gamepadAction;

		[Cpp2IlInjected.Token(Token = "0x17000389")]
		private bool _isCharacterLock
		{
			[Cpp2IlInjected.Token(Token = "0x6001492")]
			[Cpp2IlInjected.Address(RVA = "0x15F4770", Offset = "0x15F3170", VA = "0x1815F4770")]
			get
			{
				//Discarded unreachable code: IL_0014
				return !CharacterManager.IsCharacterUnlocked(_param.CharacterInstance);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001493")]
		[Cpp2IlInjected.Address(RVA = "0x15F3430", Offset = "0x15F1E30", VA = "0x1815F3430", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0073
			//IL_001a: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			base.OnPush(stack, param);
			InputTriggerReleased trigger = new InputTriggerReleased();
			int num = default(int);
			InputActionBool gamepadAction = new InputActionBool("[ A ]", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			_gamepadAction = gamepadAction;
			if (param != null)
			{
				int num3 = 0;
			}
			_param = (SkinPopupParam)num2;
			int num4 = 0;
			CollectionMenu collectionMenu = (this.collectionMenu = UiRoot.Instance._menuStack.GetMenu<CollectionMenu>());
			this.collectionMenu.SetMouseBlock(value: true);
			this.collectionMenu.MenuNavigation.FocusNavigation.IsPaused = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001494")]
		[Cpp2IlInjected.Address(RVA = "0x15F3900", Offset = "0x15F2300", VA = "0x1815F3900", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChange;
			focusNavigation.OnFocusChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001495")]
		[Cpp2IlInjected.Address(RVA = "0x15F43E0", Offset = "0x15F2DE0", VA = "0x1815F43E0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0027
			base.UnregisterFocusedListeners();
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChange;
			focusNavigation.OnFocusChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001496")]
		[Cpp2IlInjected.Address(RVA = "0x15F3210", Offset = "0x15F1C10", VA = "0x1815F3210")]
		private void OnFocusChange(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0034
			//IL_0028: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			int num = 0;
			if (focusedElement != null)
			{
				int num2 = 0;
				if (focusedElement == null)
				{
				}
			}
			int num3 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num3)
			{
				ToggleSelectBtn((byte)num3 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001497")]
		[Cpp2IlInjected.Address(RVA = "0x15F3330", Offset = "0x15F1D30", VA = "0x1815F3330", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0029
			base.OnFocusIn();
			if (!CharacterManager.IsCharacterUnlocked(_param.CharacterInstance))
			{
				int value = 0;
				ToggleSelectBtn((byte)value != 0);
			}
			SetupContent();
		}

		[Cpp2IlInjected.Token(Token = "0x6001498")]
		[Cpp2IlInjected.Address(RVA = "0x15F4310", Offset = "0x15F2D10", VA = "0x1815F4310")]
		private void ToggleSelectBtn(bool value)
		{
			//Discarded unreachable code: IL_0039
			CanvasGroup component = _selectBtnNav.GetComponent<CanvasGroup>();
			if (value)
			{
			}
			component.alpha = 0.5f;
			_selectBtnNav.GetComponent<TextButton>().IsInteractable = value;
			_selectBtnNav.IgnoreThis = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001499")]
		[Cpp2IlInjected.Address(RVA = "0x15F39B0", Offset = "0x15F23B0", VA = "0x1815F39B0")]
		private void SetupContent()
		{
			//IL_0133: Expected I4, but got I8
			//IL_018b: Expected I4, but got I8
			//IL_0343: Expected I4, but got I8
			//IL_0383: Expected I4, but got I8
			//IL_03be: Expected I4, but got I8
			ulong num2 = default(ulong);
			ulong num4 = default(ulong);
			CharacterSkinItemData characterSkinItemData = default(CharacterSkinItemData);
			CharacterSkinItemData characterSkinItemData2 = default(CharacterSkinItemData);
			CharacterSkinItemData characterSkinItemData3 = default(CharacterSkinItemData);
			bool flag2 = default(bool);
			CharacterSkinItemData characterSkinItemData4 = default(CharacterSkinItemData);
			string conditionEventStringId = default(string);
			ulong num7 = default(ulong);
			ulong num9 = default(ulong);
			ulong num10 = default(ulong);
			while (true)
			{
				GameObject itemContent = _itemContent;
				CollectionItem itemPrefab = _itemPrefab;
				Transform parent = itemContent.transform;
				CollectionItem collectionItem = UnityEngine.Object.Instantiate(itemPrefab, parent);
				CharacterItemData characterItemData = _param.CharacterItemData;
				CollectionItemModel collectionItemModel = new CollectionItemModel();
				((ItemSlotModel)collectionItemModel).ItemData = characterItemData;
				collectionItemModel.IsForSkinPopup = true;
				collectionItem.Model = collectionItemModel;
				string defaultSkinIconAddress_ = characterItemData.defaultSkinIconAddress_;
				if (collectionItemModel == null)
				{
					CollectionItemModel _003CModel_003Ek__BackingField = collectionItem.Model;
					ItemSlotModel.AlternateDataClass alternateDataClass = new ItemSlotModel.AlternateDataClass();
					string text = (alternateDataClass.DisplayName = characterItemData.displayName_);
					string text2 = (alternateDataClass.IconAddress = characterItemData.defaultSkinIconAddress_);
					_003CModel_003Ek__BackingField.AlternateData = alternateDataClass;
				}
				FocusNavigationElement component = collectionItem.GetComponent<FocusNavigationElement>();
				Transform transform = (component.FreeContainer = base.transform);
				FocusNavigationElement[] links = component.Links;
				FocusNavigationElement selectBtnNav = _selectBtnNav;
				if ((object)selectBtnNav != null && (object)transform == null)
				{
					continue;
				}
				links[3] = selectBtnNav;
				if (!CharacterManager.IsCharacterUnlocked(_param.CharacterInstance))
				{
					collectionItem.RefreshDisplay();
					ItemSlot _003CView_003Ek__BackingField = collectionItem.View;
					int num = ((_003CView_003Ek__BackingField.IsInteractable = false) ? 1 : 0);
					ItemSlot _003CView_003Ek__BackingField2 = collectionItem.View;
					string text3 = (_003CView_003Ek__BackingField2._overrideText = _befriendStringId);
					collectionItem.View.RefreshDisplay();
					collectionItem.View.ToggleLock((byte)num2 != 0);
				}
				collectionItem.Model.IsCollected = true;
				collectionItem.RefreshDisplay();
				ItemSlot _003CView_003Ek__BackingField3 = collectionItem.View;
				UnityEvent unityEvent = (_003CView_003Ek__BackingField3.OnPressed = _003CView_003Ek__BackingField3.OnClicked);
				CharacterManager.CharacterInstance characterInstance = _param.CharacterInstance;
				int num3 = 0;
				if (characterInstance == null || characterInstance.ActiveCharacterSkin == null)
				{
					collectionItem.View.IsSelected = (byte)num4 != 0;
					_currentSelection = collectionItem;
					int num5 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						FocusNavigation focusNavigation = base.FocusNavigation;
						FocusNavigationElement focusNavigationElement = collectionItem.FocusNavigationElement;
						focusNavigation.SetFocus(focusNavigationElement);
					}
				}
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				CharacterSkinItemData[] skins = _param.Skins;
				if (num3 >= skins.Length)
				{
					break;
				}
				GameObject itemContent2 = _itemContent;
				CollectionItem itemPrefab2 = _itemPrefab;
				Transform parent2 = itemContent2.transform;
				CollectionItem collectionItem2 = UnityEngine.Object.Instantiate(itemPrefab2, parent2);
				CollectionItemModel collectionItemModel2 = new CollectionItemModel();
				ItemSlotModel.AlternateDataClass alternateDataClass2 = new ItemSlotModel.AlternateDataClass();
				CharacterSkinItemData[] skins2 = _param.Skins;
				string text4 = (alternateDataClass2.DisplayName = characterSkinItemData.displayName_);
				CharacterSkinItemData[] skins3 = _param.Skins;
				string text5 = (alternateDataClass2.IconAddress = characterSkinItemData2.iconAddress_);
				collectionItemModel2.AlternateData = alternateDataClass2;
				collectionItemModel2.IsForSkinPopup = true;
				collectionItem2.Model = collectionItemModel2;
				FocusNavigationElement component2 = collectionItem2.GetComponent<FocusNavigationElement>();
				Transform transform2 = (component2.FreeContainer = base.transform);
				FocusNavigationElement[] links2 = component2.Links;
				FocusNavigationElement selectBtnNav2 = _selectBtnNav;
				if ((object)selectBtnNav2 != null && (object)transform2 == null)
				{
					continue;
				}
				links2[3] = selectBtnNav2;
				ListInventory skins4 = profile.Skins;
				CharacterSkinItemData[] skins5 = _param.Skins;
				Item item = characterSkinItemData3.Item;
				if (!flag2)
				{
					collectionItem2.RefreshDisplay();
					ItemSlot _003CView_003Ek__BackingField4 = collectionItem2.View;
					int num6 = ((_003CView_003Ek__BackingField4.IsInteractable = false) ? 1 : 0);
					CharacterSkinItemData[] skins6 = _param.Skins;
					if (characterSkinItemData4.ActivatedBy == CharacterSkinItemData.ActivationMode.Normal)
					{
						conditionEventStringId = _conditionEventStringId;
					}
					collectionItem2.View._overrideText = conditionEventStringId;
					collectionItem2.View.RefreshDisplay();
					collectionItem2.View.ToggleLock((byte)num7 != 0);
				}
				collectionItem2.Model.IsCollected = true;
				collectionItem2.RefreshDisplay();
				if (_isCharacterLock)
				{
					ItemSlot _003CView_003Ek__BackingField5 = collectionItem2.View;
					int num8 = ((_003CView_003Ek__BackingField5.IsInteractable = false) ? 1 : 0);
					collectionItem2.View.IsLock = (byte)num9 != 0;
				}
				ItemSlot _003CView_003Ek__BackingField6 = collectionItem2.View;
				UnityEvent unityEvent2 = (_003CView_003Ek__BackingField6.OnPressed = _003CView_003Ek__BackingField6.OnClicked);
				if (num3 != 0)
				{
					CharacterSkinItemData[] skins7 = _param.Skins;
					collectionItem2.View.IsSelected = (byte)num10 != 0;
					_currentSelection = collectionItem2;
				}
				SkinPopupParam param = _param;
				num3++;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600149A")]
		[Cpp2IlInjected.Address(RVA = "0x15F4490", Offset = "0x15F2E90", VA = "0x1815F4490")]
		private void Update()
		{
			//IL_007d: Expected O, but got I4
			CollectionItem collectionItem = default(CollectionItem);
			while (true)
			{
				if ((long)_param == 0)
				{
					return;
				}
				int num = 0;
				float deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[1];
				InputAction gamepadAction = _gamepadAction;
				if (gamepadAction != null && array == null)
				{
					continue;
				}
				array[0] = gamepadAction;
				InputAction.UpdateAll(deltaTime, array);
				if (!_gamepadAction.IsTriggered || _isCharacterLock)
				{
					return;
				}
				ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
				if (focusedElement != null)
				{
					int num2 = 0;
					if (focusedElement == null)
					{
					}
				}
				int num3 = 0;
				if (collectionItem != (UnityEngine.Object)num3)
				{
					break;
				}
				OnClickSelect();
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600149B")]
		[Cpp2IlInjected.Address(RVA = "0x15F3130", Offset = "0x15F1B30", VA = "0x1815F3130", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0057
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && _itemContent.transform.childCount > 0)
			{
				FocusNavigation focusNavigation = base.FocusNavigation;
				Transform transform = _itemContent.transform;
				int index = 0;
				FocusNavigationElement component = transform.GetChild(index).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600149C")]
		[Cpp2IlInjected.Address(RVA = "0x15F2E20", Offset = "0x15F1820", VA = "0x1815F2E20")]
		private CharacterSkinItemData GetActiveSkin()
		{
			CharacterManager.CharacterInstance characterInstance = _param.CharacterInstance;
			if (characterInstance != null)
			{
				return characterInstance.ActiveCharacterSkin;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600149D")]
		[Cpp2IlInjected.Address(RVA = "0x15F33D0", Offset = "0x15F1DD0", VA = "0x1815F33D0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_002d
			base.OnPop();
			CollectionMenu collectionMenu = this.collectionMenu;
			int mouseBlock = 0;
			collectionMenu.SetMouseBlock((byte)mouseBlock != 0);
			this.collectionMenu.MenuNavigation.FocusNavigation.IsPaused = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600149E")]
		[Cpp2IlInjected.Address(RVA = "0x15F2E60", Offset = "0x15F1860", VA = "0x1815F2E60", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GenericAlertNo || redirectionType == RedirectionType.GamePromptClose)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600149F")]
		[Cpp2IlInjected.Address(RVA = "0x15F35F0", Offset = "0x15F1FF0", VA = "0x1815F35F0")]
		public void OnSkinClick()
		{
			//Discarded unreachable code: IL_00b6, IL_00bc, IL_00c2, IL_00c8, IL_00ce, IL_00d4, IL_00da, IL_00ec
			//IL_005a: Expected O, but got I4
			IEnumerator enumerator = _itemContent.transform.GetEnumerator();
			CollectionItem currentSelection2 = default(CollectionItem);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				CollectionItem collectionItem = default(CollectionItem);
				collectionItem.View.IsSelected = true;
				collectionItem.View.OnSelected.Invoke();
				CollectionItem currentSelection = _currentSelection;
				int num3 = 0;
				if (currentSelection != (UnityEngine.Object)num3 && _currentSelection != collectionItem)
				{
					AK.Wwise.Event selectSfx = _selectSfx;
					if (selectSfx != null)
					{
						GameObject gameObject = collectionItem.gameObject;
						uint num4 = selectSfx.Post(gameObject);
					}
					currentSelection2 = _currentSelection;
					ItemSlot _003CView_003Ek__BackingField = currentSelection2.View;
					int num5 = ((_003CView_003Ek__BackingField.IsSelected = false) ? 1 : 0);
				}
				_currentSelection = collectionItem;
			}
			if ((object)currentSelection2 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A0")]
		[Cpp2IlInjected.Address(RVA = "0x15F2E90", Offset = "0x15F1890", VA = "0x1815F2E90")]
		public void OnClickSelect()
		{
			//Discarded unreachable code: IL_007d
			if (CharacterManager.IsCharacterUnlocked(_param.CharacterInstance))
			{
				int siblingIndex = _currentSelection.transform.GetSiblingIndex();
				if (siblingIndex != 0)
				{
					Item item = _param.Skins[siblingIndex].Item;
				}
				Item invalid = Item.Invalid;
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				int iD = _param.CharacterItemData.ID;
				Task<bool> asyncTask = default(Task<bool>);
				asyncTask.FireAndForgetTask();
			}
			PopSelf();
			IExtenderProvider[] extenderProviders = ((IExtenderListService)collectionMenu).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60014A1")]
		[Cpp2IlInjected.Address(RVA = "0x15F46E0", Offset = "0x15F30E0", VA = "0x1815F46E0")]
		public SkinPopup()
		{
		}
	}
}
