using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000545")]
	[RequiredAllNotNull]
	public class ManageRoomPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000546")]
		public class ManageRoomParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001C88")]
			public House.Types.RoomSlot Slot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001C89")]
			internal House.Types.Room CurrentRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001C8A")]
			public int CurrentFloorIndex;

			[Cpp2IlInjected.Token(Token = "0x1700054B")]
			public KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] BoughtRooms
			{
				[Cpp2IlInjected.Token(Token = "0x600224B")]
				[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
				[CompilerGenerated]
				get
				{
					return _003CBoughtRooms_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600224C")]
				[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
				[CompilerGenerated]
				internal set
				{
					_003CBoughtRooms_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700054C")]
			public HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] AddintionalRooms
			{
				[Cpp2IlInjected.Token(Token = "0x600224D")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				[CompilerGenerated]
				get
				{
					return _003CAddintionalRooms_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600224E")]
				[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
				[CompilerGenerated]
				internal set
				{
					_003CAddintionalRooms_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600224F")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public ManageRoomParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001C75")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001C76")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001C77")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001C78")]
		[SerializeField]
		private RectTransform _mcAnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001C79")]
		[SerializeField]
		private ButtonTmPro _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001C7A")]
		[SerializeField]
		private CurrencyItemView _mcConfirmCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001C7B")]
		[SerializeField]
		private GameObject _listRoomsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001C7C")]
		[SerializeField]
		private ListBase _listRooms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001C7D")]
		[SerializeField]
		private InputTextBase _tfInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001C7E")]
		[SerializeField]
		private TextBase _tfCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001C7F")]
		[SerializeField]
		private ShortcutIndicator _backShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001C80")]
		[SerializeField]
		private AK.Wwise.Event selectSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001C81")]
		[SerializeField]
		private AK.Wwise.Event unlockSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001C82")]
		private AK.Wwise.Event buttonSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001C83")]
		private ManageRoomParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001C84")]
		private int initialRoomIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4001C85")]
		private bool _isInFocus = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14D")]
		[Cpp2IlInjected.Token(Token = "0x4001C86")]
		private bool _shouldImmediatelyConfirm;

		[Cpp2IlInjected.Token(Token = "0x1700054A")]
		private string ResetName
		{
			[Cpp2IlInjected.Token(Token = "0x6002233")]
			[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
			[CompilerGenerated]
			get
			{
				return _003CResetName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002234")]
			[Cpp2IlInjected.Address(RVA = "0x976520", Offset = "0x974F20", VA = "0x180976520")]
			[CompilerGenerated]
			set
			{
				_003CResetName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = "";


		[Cpp2IlInjected.Token(Token = "0x6002235")]
		[Cpp2IlInjected.Address(RVA = "0xFAF170", Offset = "0xFADB70", VA = "0x180FAF170", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0124
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnConfirm.ButtonComponent.m_OnClick;
			UnityAction call = OnConfirmClickHandler;
			onClick.AddListener(call);
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			TMP_InputField.SelectionEvent onSelect = ((TMP_InputField)_tfInput).m_OnSelect;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextClicked);
			((UnityEvent<T0>)(object)onSelect).AddListener((UnityAction<>)(object)unityAction2);
			Button.ButtonClickedEvent onClick2 = _btnClose.m_OnClick;
			UnityAction call2 = OnCloseClickHandler;
			onClick2.AddListener(call2);
			ListBase.ListEvents onItemData = _listRooms.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction3);
			ListBase.ListEvents onItemSelect = _listRooms.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction4);
			ListBase.ListEvents onItemTap = _listRooms.m_OnItemTap;
			UnityAction<ListBase.ListEventData> unityAction5 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction5);
			ListBase.ListEvents onItemDeselect = _listRooms.m_OnItemDeselect;
			UnityAction<ListBase.ListEventData> unityAction6 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomDeselectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).AddListener((UnityAction<>)(object)unityAction6);
		}

		[Cpp2IlInjected.Token(Token = "0x6002236")]
		[Cpp2IlInjected.Address(RVA = "0xFAF900", Offset = "0xFAE300", VA = "0x180FAF900", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0124
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnConfirm.ButtonComponent.m_OnClick;
			UnityAction call = OnConfirmClickHandler;
			onClick.RemoveListener(call);
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			TMP_InputField.SelectionEvent onSelect = ((TMP_InputField)_tfInput).m_OnSelect;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextClicked);
			((UnityEvent<T0>)(object)onSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			Button.ButtonClickedEvent onClick2 = _btnClose.m_OnClick;
			UnityAction call2 = OnCloseClickHandler;
			onClick2.RemoveListener(call2);
			ListBase.ListEvents onItemData = _listRooms.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction3);
			ListBase.ListEvents onItemSelect = _listRooms.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction4 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction4);
			ListBase.ListEvents onItemTap = _listRooms.m_OnItemTap;
			UnityAction<ListBase.ListEventData> unityAction5 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction5);
			ListBase.ListEvents onItemDeselect = _listRooms.m_OnItemDeselect;
			UnityAction<ListBase.ListEventData> unityAction6 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnRoomDeselectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).RemoveListener((UnityAction<>)(object)unityAction6);
		}

		[Cpp2IlInjected.Token(Token = "0x6002237")]
		[Cpp2IlInjected.Address(RVA = "0xFAE6C0", Offset = "0xFAD0C0", VA = "0x180FAE6C0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (ManageRoomParam)param;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002238")]
		[Cpp2IlInjected.Address(RVA = "0xFADC90", Offset = "0xFAC690", VA = "0x180FADC90", Slot = "27")]
		public unsafe override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0300
			//IL_0061: Expected I4, but got I8
			//IL_0124: Expected I4, but got I8
			//IL_0220: Expected O, but got I4
			//IL_02c1: Expected O, but got I4
			int num = 0;
			base.OnFocusIn();
			ManageRoomParam param = _param;
			if (param != null)
			{
				House.Types.Room currentRoom = param.CurrentRoom;
				InputTextBase tfInput = _tfInput;
				if (currentRoom == null || currentRoom.name_ == null)
				{
				}
				tfInput.text = "";
				ManageRoomParam param2 = _param;
				if (param2.Slot != (House.Types.RoomSlot)num)
				{
					initialRoomIndex = -1;
					if ((IntPtr)param2.CurrentRoom != (IntPtr)num)
					{
						Client client = default(Client);
						ProfileWorld world_ = client.profile.world_;
						House.Types.Room currentRoom2 = _param.CurrentRoom;
						GridCollection gridCollection_ = world_.gridCollection_;
						uint floorGridID_ = currentRoom2.floorGridID_;
						bool flag = gridCollection_.TryGetGrid(floorGridID_, out *(IGrid*)num);
						ManageRoomParam param3 = _param;
						HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] _003CAddintionalRooms_003Ek__BackingField = param3.AddintionalRooms;
						if (num < _003CAddintionalRooms_003Ek__BackingField.Length)
						{
							string floorGridDataPath_ = param3.AddintionalRooms[num].floorGridDataPath_;
							uint num2 = default(uint);
							if (num < (int)num2)
							{
								num += num;
								num++;
							}
							if (num != 0)
							{
								int length = _param.AddintionalRooms.Length;
								length = (initialRoomIndex = length - num);
							}
							ManageRoomParam param4 = _param;
							num++;
							num += num;
						}
					}
					ulong num3 = default(ulong);
					_listRoomsContainer.SetActive((byte)num3 != 0);
					HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] _003CAddintionalRooms_003Ek__BackingField2 = _param.AddintionalRooms;
					ListBase listRooms = _listRooms;
					int num4 = (listRooms.TotalCount = _003CAddintionalRooms_003Ek__BackingField2.Length);
					LayoutRebuilder.ForceRebuildLayoutImmediate(_listRooms.m_Content);
					ListBase listRooms2 = _listRooms;
					int num6 = (listRooms2.SelectedIndex = initialRoomIndex);
					if (initialRoomIndex >= num)
					{
						goto IL_027b;
					}
					AK.Wwise.Event @event = (buttonSFX = selectSFX);
					GameObject gameObject = _btnConfirm.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					GameObject gameObject2 = _mcConfirmCurrency.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
					_btnConfirm.Label.StringID = "menu.common_button_select";
					_backShortcutIndicator._textBase.StringID = "menu.button_common_close";
					base.IsDataUpToDate = true;
				}
				AK.Wwise.Event event2 = (buttonSFX = selectSFX);
				RectTransform mcContent = _mcContent;
				int num7 = 0;
				Vector2 sizeDelta = mcContent.sizeDelta;
				mcContent.sizeDelta = (Vector2)num7;
				GameObject listRoomsContainer = _listRoomsContainer;
				int active3 = 0;
				listRoomsContainer.SetActive((byte)active3 != 0);
				GameObject gameObject3 = _mcConfirmCurrency.gameObject;
				int active4 = 0;
				gameObject3.SetActive((byte)active4 != 0);
				_btnConfirm.Label.StringID = "menu.common_button_select";
				GameObject gameObject4 = _btnConfirm.gameObject;
				int active5 = 0;
				gameObject4.SetActive((byte)active5 != 0);
				goto IL_027b;
			}
			goto IL_0282;
			IL_0282:
			MenuInputField component = _tfInput.GetComponent<MenuInputField>();
			string text = (component.ResetText = ResetName);
			Image mcBlocker = _mcBlocker;
			Image mcBlocker2 = _mcBlocker;
			int num8 = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcBlocker2, (Color)num8, 0.3f);
			RectTransform mcAnimatedContent = _mcAnimatedContent;
			float z = Vector3.zero.z;
			RectTransform mcAnimatedContent2 = _mcAnimatedContent;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.SetDelay(0.15f);
			SetFocus();
			return;
			IL_027b:
			base.IsDataUpToDate = true;
			goto IL_0282;
		}

		[Cpp2IlInjected.Token(Token = "0x6002239")]
		[Cpp2IlInjected.Address(RVA = "0xFAF0F0", Offset = "0xFADAF0", VA = "0x180FAF0F0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__27))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__27 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__27(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600223A")]
		[Cpp2IlInjected.Address(RVA = "0xFAE3F0", Offset = "0xFACDF0", VA = "0x180FAE3F0")]
		private void OnInputTextChanged(string text)
		{
			//Discarded unreachable code: IL_0069
			//IL_0032: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			InputTextBase tfInput = _tfInput;
			TextBase tfCounter = _tfCounter;
			int stringLength = ((TMP_InputField)tfInput).m_Text.m_stringLength;
			int characterLimit = ((TMP_InputField)_tfInput).m_CharacterLimit;
			string text3 = (tfCounter.Text = $"{stringLength} / {stringLength}");
			if (_param.Slot != 0)
			{
				int selectedIndex = _listRooms.SelectedIndex;
			}
			_btnConfirm.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600223B")]
		[Cpp2IlInjected.Address(RVA = "0xFAE570", Offset = "0xFACF70", VA = "0x180FAE570")]
		public void OnInputTextClicked(string text)
		{
			//Discarded unreachable code: IL_0055
			//IL_0035: Expected I4, but got I8
			//IL_0054: Expected I4, but got I8
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Rewired.Player player = players.GetPlayer(playerId);
			if (player != null)
			{
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnEndEdit);
				int num2 = 0;
				ulong num3 = default(ulong);
				player.AddInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num2, InputActionEventType.ButtonJustPressed, (int)num3);
				Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnEndEdit);
				int num4 = 0;
				ulong num5 = default(ulong);
				player.AddInputEventDelegate((Action<>)(object)action2, (UpdateLoopType)num4, InputActionEventType.ButtonJustPressed, (int)num5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600223C")]
		[Cpp2IlInjected.Address(RVA = "0xFADBB0", Offset = "0xFAC5B0", VA = "0x180FADBB0")]
		private unsafe void OnEndEdit(InputActionEventData obj)
		{
			//Discarded unreachable code: IL_0046
			Rewired.Player player = ((InputActionEventData*)obj)->player;
			Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnEndEdit);
			player.RemoveInputEventDelegate((Action<>)(object)action);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && _param.Slot == House.Types.RoomSlot.Center)
			{
				OnConfirmClickHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600223D")]
		[Cpp2IlInjected.Address(RVA = "0xFADA80", Offset = "0xFAC480", VA = "0x180FADA80")]
		private void OnCloseClickHandler()
		{
			//Discarded unreachable code: IL_0023
			//IL_001a: Expected O, but got I4
			if (_isInFocus)
			{
				_param.AnswerAction((T)1);
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600223E")]
		[Cpp2IlInjected.Address(RVA = "0xFAF530", Offset = "0xFADF30", VA = "0x180FAF530")]
		private void SaveOnExit()
		{
			//Discarded unreachable code: IL_003a
			//IL_002b: Expected O, but got I4
			if (_param.Slot != 0)
			{
				int selectedIndex = _listRooms.SelectedIndex;
				_param.AnswerAction((T)1);
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
			else
			{
				OnConfirmClickHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600223F")]
		[Cpp2IlInjected.Address(RVA = "0xFAF880", Offset = "0xFAE280", VA = "0x180FAF880")]
		private void TryPurchaseAgain(bool purchaseSucceed)
		{
			if (purchaseSucceed)
			{
				CancellationToken cancellationToken = base.CancellationToken;
				ConfirmTask(cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002240")]
		[Cpp2IlInjected.Address(RVA = "0xFADB00", Offset = "0xFAC500", VA = "0x180FADB00")]
		private void OnConfirmClickHandler()
		{
			if (_isInFocus)
			{
				_isInFocus = false;
				CancellationToken cancellationToken = base.CancellationToken;
				ConfirmTask(cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002241")]
		[Cpp2IlInjected.Address(RVA = "0xFAD8A0", Offset = "0xFAC2A0", VA = "0x180FAD8A0")]
		[AsyncStateMachine(typeof(_003CConfirmTask_003Ed__35))]
		private Task ConfirmTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002242")]
		[Cpp2IlInjected.Address(RVA = "0xFAE870", Offset = "0xFAD270", VA = "0x180FAE870")]
		private void OnRoomItemDataHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_013e
			//IL_001b: Expected O, but got I4
			ManageRoomItem component = arg.DisplayObject.GetComponent<ManageRoomItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] _003CAddintionalRooms_003Ek__BackingField = _param.AddintionalRooms;
				int length = _003CAddintionalRooms_003Ek__BackingField.Length;
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData roomData = _003CAddintionalRooms_003Ek__BackingField[length];
				KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] _003CBoughtRooms_003Ek__BackingField = _param.BoughtRooms;
				if (_003CBoughtRooms_003Ek__BackingField.Length == 0)
				{
				}
				KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList> keyValuePair = _003CBoughtRooms_003Ek__BackingField[1];
				Func<string, bool> func = (Func<string, bool>)(object)(Func<T, TResult>)delegate(string x)
				{
					//Discarded unreachable code: IL_0014
					string floorGridDataPath_ = roomData.floorGridDataPath_;
					return string.Equals(x, floorGridDataPath_);
				};
				bool isBought = default(bool);
				component.IsBought = isBought;
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData expansionData = (component.RoomData = roomData);
				Transform transform = component.transform;
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData roomData2 = component.RoomData;
				TextBase tfLabel = component._tfLabel;
				string text = (tfLabel.StringID = roomData2.name_);
				GameObject gameObject = component._mcCurrencyView.gameObject;
				bool active = !component.IsBought;
				gameObject.SetActive(active);
				if (!component.IsBought)
				{
					HouseExpansion.Types.InteriorExpansion.Types.ExpansionData roomData3 = component.RoomData;
					CurrencyItemView mcCurrencyView = component._mcCurrencyView;
					RepeatedField<CurrencyCost> price_ = roomData3.price_;
					int index = 0;
					Item item = ((CurrencyCost)((RepeatedField<T>)(object)price_)[index]).Item;
					RepeatedField<CurrencyCost> price_2 = component.RoomData.price_;
					int index2 = 0;
					CurrencyCost currencyCost = (CurrencyCost)((RepeatedField<T>)(object)price_2)[index2];
				}
				component._refreshBuyButton?.RefreshBuy();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002243")]
		[Cpp2IlInjected.Address(RVA = "0xFAE7A0", Offset = "0xFAD1A0", VA = "0x180FAE7A0")]
		private void OnRoomDeselectHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_0051
			//IL_0015: Expected O, but got I4
			ManageRoomItem component = arg.DisplayObject.GetComponent<ManageRoomItem>();
			int num = 0;
			bool flag = component == (UnityEngine.Object)num;
			if (!flag)
			{
				GameObject mcSelectedBackground = component._mcSelectedBackground;
				component._isSelected = flag;
				int active = 0;
				mcSelectedBackground.SetActive((byte)active != 0);
				GameObject mcBackground = component._mcBackground;
				bool active2 = !component._isSelected;
				mcBackground.SetActive(active2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002244")]
		[Cpp2IlInjected.Address(RVA = "0xFAEC10", Offset = "0xFAD610", VA = "0x180FAEC10")]
		private void OnRoomSelectHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_0177
			//IL_0015: Expected O, but got I4
			//IL_0030: Expected I4, but got I8
			//IL_005e: Expected I4, but got I8
			//IL_009e: Expected I4, but got I8
			ManageRoomItem component = arg.DisplayObject.GetComponent<ManageRoomItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				GameObject mcSelectedBackground = component._mcSelectedBackground;
				component._isSelected = true;
				ulong num2 = default(ulong);
				mcSelectedBackground.SetActive((byte)num2 != 0);
				GameObject mcBackground = component._mcBackground;
				bool active = !component._isSelected;
				mcBackground.SetActive(active);
				ulong num3 = default(ulong);
				_btnConfirm.gameObject.SetActive((byte)num3 != 0);
				int length = _param.AddintionalRooms.Length;
				if (!component.IsBought)
				{
					AK.Wwise.Event @event = (buttonSFX = unlockSFX);
					ulong num4 = default(ulong);
					_mcConfirmCurrency.gameObject.SetActive((byte)num4 != 0);
					ManageRoomParam param = _param;
					CurrencyItemView mcConfirmCurrency = _mcConfirmCurrency;
					RepeatedField<CurrencyCost> price_ = param.AddintionalRooms[length].price_;
					int index = 0;
					Item item = ((CurrencyCost)((RepeatedField<T>)(object)price_)[index]).Item;
					RepeatedField<CurrencyCost> price_2 = _param.AddintionalRooms[length].price_;
					int index2 = 0;
					CurrencyCost currencyCost = (CurrencyCost)((RepeatedField<T>)(object)price_2)[index2];
					_btnConfirm.Label.StringID = "menu.common_unlock";
					LayoutRebuilder.ForceRebuildLayoutImmediate(_btnConfirm.AnimatedContent);
				}
				AK.Wwise.Event event2 = (buttonSFX = selectSFX);
				GameObject gameObject = _mcConfirmCurrency.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
				_btnConfirm.Label.StringID = "menu.common_button_select";
				if (_shouldImmediatelyConfirm)
				{
					_shouldImmediatelyConfirm = false;
					OnConfirmClickHandler();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002245")]
		[Cpp2IlInjected.Address(RVA = "0xFAEFD0", Offset = "0xFAD9D0", VA = "0x180FAEFD0")]
		private void OnRoomTapHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_008d
			//IL_0015: Expected O, but got I4
			ManageRoomItem component = arg.DisplayObject.GetComponent<ManageRoomItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num && !component._isSelected)
			{
				component._button?.PostWwiseEvent();
			}
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = (_shouldImmediatelyConfirm = instance.IsControllerConnected((byte)useKeyboardAsController != 0));
			ListBase listRooms = _listRooms;
			int itemIndex = arg.ItemIndex;
			int selectedIndex = listRooms.SelectedIndex;
			if (itemIndex == selectedIndex && _shouldImmediatelyConfirm)
			{
				_shouldImmediatelyConfirm = false;
				OnConfirmClickHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002246")]
		[Cpp2IlInjected.Address(RVA = "0xFADB90", Offset = "0xFAC590", VA = "0x180FADB90", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6002247")]
		[Cpp2IlInjected.Address(RVA = "0xFAF5E0", Offset = "0xFADFE0", VA = "0x180FAF5E0")]
		private void SetFocus()
		{
			//IL_00cf: Expected F4, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if (base.MenuNavigation.FocusNavigation._focusedElement == null)
				{
				}
				int num2 = 0;
				int index = 0;
				bool flag = default(bool);
				if (flag)
				{
					int selectedIndex = _listRooms.SelectedIndex;
					int rawSelectedIndex = _listRooms._rawSelectedIndex;
					if (_listRooms.m_Content.childCount != 0)
					{
						FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
						Transform child = _listRooms.m_Content.GetChild(index);
						if ((object)child != null)
						{
							FocusNavigationElement component = child.GetComponent<FocusNavigationElement>();
						}
					}
					InputTextBase tfInput = _tfInput;
					MenuNavigation menuNavigation = default(MenuNavigation);
					FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
					FocusNavigationElement component2 = tfInput.GetComponent<FocusNavigationElement>();
					focusNavigation2.SetFocus(component2);
				}
				CanvasGroup component3 = _btnConfirm.GetComponent<CanvasGroup>();
				int num3 = 0;
				component3.alpha = num3;
				return;
			}
			CanvasGroup component4 = _btnConfirm.GetComponent<CanvasGroup>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002248")]
		[Cpp2IlInjected.Address(RVA = "0xFAD9C0", Offset = "0xFAC3C0", VA = "0x180FAD9C0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0043
			//IL_0033: Expected O, but got I4
			if (redirectionType == RedirectionType.GamePromptClose)
			{
				if (_param.Slot != 0)
				{
					int selectedIndex = _listRooms.SelectedIndex;
					_param.AnswerAction((T)1);
					IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
				}
				else
				{
					OnConfirmClickHandler();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002249")]
		[Cpp2IlInjected.Address(RVA = "0xFAFCC0", Offset = "0xFAE6C0", VA = "0x180FAFCC0")]
		public ManageRoomPopup()
		{
		}
	}
}
