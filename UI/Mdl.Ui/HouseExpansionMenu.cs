using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200053D")]
	[RequiredAllNotNull]
	public class HouseExpansionMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200053E")]
		public class HouseExpansionMenuParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001C50")]
			public int NumberOfFloorsInTheHouse;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4001C51")]
			public int CurrentFloorIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001C52")]
			public Action<int> ChooseFloorDelegate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001C53")]
			public HouseExpansionInfo Gizmo;

			[Cpp2IlInjected.Token(Token = "0x6002219")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public HouseExpansionMenuParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001C3D")]
		private House _playerHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001C3E")]
		private House.Types.Floor _currentFloorMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001C3F")]
		private int _numberOfFloorsInTheHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4001C40")]
		private int _currentFloorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001C41")]
		private Action<int> _chooseFloorDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001C42")]
		private HouseExpansion _houseExpansion;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001C43")]
		[SerializeField]
		private GameObject _expansionContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001C44")]
		[SerializeField]
		private HouseExpansionElevatorContent _elevatorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001C45")]
		[SerializeField]
		private ShortcutIndicator _backShortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001C46")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001C47")]
		[SerializeField]
		private CurrencyContent _mcCurrencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001C48")]
		[SerializeField]
		private SlidingPanel _mcLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001C49")]
		[SerializeField]
		private SlidingPanel _mcFloorLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001C4A")]
		[SerializeField]
		private TextBase _tfCurrentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001C4B")]
		[SerializeField]
		private HouseExpansionFloorMap _mcFloorMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001C4C")]
		[SerializeField]
		private HouseExpansionElevatorPanel _mcElevatorPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001C4D")]
		[SerializeField]
		private AK.Wwise.Event _purchaseSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001C4E")]
		[SerializeField]
		private Switch _purchaseSuccededSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001C4F")]
		private float _menuCanvasScaleFactor;

		[Cpp2IlInjected.Token(Token = "0x6002200")]
		[Cpp2IlInjected.Address(RVA = "0xAF1A40", Offset = "0xAF0440", VA = "0x180AF1A40", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_015c
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.AddListener(call);
			HouseExpansionElevatorPanel mcElevatorPanel = _mcElevatorPanel;
			HouseExpansionElevatorPanel.OnFloorAddedDelegate b = OnFloorAddHandler;
			HouseExpansionElevatorPanel.OnFloorAddedDelegate onFloorAdded = mcElevatorPanel.OnFloorAdded;
			int num = 0;
			Delegate @delegate = Delegate.Combine(onFloorAdded, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onFloorAdded)
				{
				}
				HouseExpansionElevatorPanel mcElevatorPanel2 = _mcElevatorPanel;
				HouseExpansionElevatorPanel.OnFloorChangedDelegate b2 = OnFloorChangedHandler;
				HouseExpansionElevatorPanel.OnFloorChangedDelegate onFloorChanged = mcElevatorPanel2.OnFloorChanged;
				Delegate delegate2 = Delegate.Combine(onFloorChanged, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onFloorChanged)
					{
					}
					HouseExpansionElevatorPanel mcElevatorPanel3 = _mcElevatorPanel;
					HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate b3 = OnElevatorCollapsed;
					HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate onFloorPanelCollapsed = mcElevatorPanel3.OnFloorPanelCollapsed;
					Delegate delegate3 = Delegate.Combine(onFloorPanelCollapsed, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						while ((object)delegate3 != onFloorPanelCollapsed)
						{
						}
						HouseExpansionElevatorPanel mcElevatorPanel4 = _mcElevatorPanel;
						HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate b4 = OnElevatorExpanded;
						HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate onFloorPanelExpanded = mcElevatorPanel4.OnFloorPanelExpanded;
						Delegate delegate4 = Delegate.Combine(onFloorPanelExpanded, b4);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							while ((object)delegate4 != onFloorPanelExpanded)
							{
							}
							HouseExpansionFloorMap mcFloorMap = _mcFloorMap;
							HouseExpansionMainRoomContent.OnRefreshRequestedDelegate b5 = OnRefreshRequestedHandler;
							Delegate delegate5 = Delegate.Combine(onFloorPanelExpanded, b5);
							if ((object)delegate5 == null || (object)delegate5 != null)
							{
								mcFloorMap.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate5;
								Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += OnSceneChanged;
								return;
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002201")]
		[Cpp2IlInjected.Address(RVA = "0xAF20D0", Offset = "0xAF0AD0", VA = "0x180AF20D0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_015c
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClickHandler;
			onClick.RemoveListener(call);
			HouseExpansionElevatorPanel mcElevatorPanel = _mcElevatorPanel;
			HouseExpansionElevatorPanel.OnFloorAddedDelegate value = OnFloorAddHandler;
			HouseExpansionElevatorPanel.OnFloorAddedDelegate onFloorAdded = mcElevatorPanel.OnFloorAdded;
			int num = 0;
			Delegate @delegate = Delegate.Remove(onFloorAdded, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onFloorAdded)
				{
				}
				HouseExpansionElevatorPanel mcElevatorPanel2 = _mcElevatorPanel;
				HouseExpansionElevatorPanel.OnFloorChangedDelegate value2 = OnFloorChangedHandler;
				HouseExpansionElevatorPanel.OnFloorChangedDelegate onFloorChanged = mcElevatorPanel2.OnFloorChanged;
				Delegate delegate2 = Delegate.Remove(onFloorChanged, value2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onFloorChanged)
					{
					}
					HouseExpansionElevatorPanel mcElevatorPanel3 = _mcElevatorPanel;
					HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate value3 = OnElevatorCollapsed;
					HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate onFloorPanelCollapsed = mcElevatorPanel3.OnFloorPanelCollapsed;
					Delegate delegate3 = Delegate.Remove(onFloorPanelCollapsed, value3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						while ((object)delegate3 != onFloorPanelCollapsed)
						{
						}
						HouseExpansionElevatorPanel mcElevatorPanel4 = _mcElevatorPanel;
						HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate value4 = OnElevatorExpanded;
						HouseExpansionElevatorPanel.OnFloorPanelColapsedDelegate onFloorPanelExpanded = mcElevatorPanel4.OnFloorPanelExpanded;
						Delegate delegate4 = Delegate.Remove(onFloorPanelExpanded, value4);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							while ((object)delegate4 != onFloorPanelExpanded)
							{
							}
							HouseExpansionFloorMap mcFloorMap = _mcFloorMap;
							HouseExpansionMainRoomContent.OnRefreshRequestedDelegate value5 = OnRefreshRequestedHandler;
							Delegate delegate5 = Delegate.Remove(onFloorPanelExpanded, value5);
							if ((object)delegate5 == null || (object)delegate5 != null)
							{
								mcFloorMap.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate5;
								Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnSceneChanged;
								return;
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002202")]
		[Cpp2IlInjected.Address(RVA = "0xAF11C0", Offset = "0xAEFBC0", VA = "0x180AF11C0")]
		private void OnRefreshRequestedHandler()
		{
			int showAnimation = 0;
			RefreshDisplay((byte)showAnimation != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002203")]
		[Cpp2IlInjected.Address(RVA = "0xAF0DB0", Offset = "0xAEF7B0", VA = "0x180AF0DB0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00e6
			//IL_0028: Expected I4, but got O
			//IL_003c: Expected I4, but got O
			//IL_005e: Expected O, but got I4
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				int num2 = 0;
				if (param == null)
				{
					object obj = param.Params[0];
					_numberOfFloorsInTheHouse = (int)obj;
					object obj2 = param.Params[1];
					_currentFloorIndex = (int)obj2;
					object obj3 = param.Params[2];
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
					_chooseFloorDelegate = (Action<int>)num2;
				}
				_numberOfFloorsInTheHouse = num;
				_currentFloorIndex = num;
				_chooseFloorDelegate = (Action<int>)(object)param;
			}
			House house = (_playerHouse = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_);
			RepeatedField<House.Types.Floor> floors_ = _playerHouse.floors_;
			int currentFloorIndex = _currentFloorIndex;
			House.Types.Floor floor = (_currentFloorMap = (House.Types.Floor)((RepeatedField<T>)(object)floors_)[currentFloorIndex]);
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			int num3 = 0;
			GameObject gameObject = UiRoot.Instance._worldCanvas.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002204")]
		[Cpp2IlInjected.Address(RVA = "0xAF0BD0", Offset = "0xAEF5D0", VA = "0x180AF0BD0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_001e
			base.OnPop();
			int num = 0;
			UiRoot.Instance._worldCanvas.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002205")]
		[Cpp2IlInjected.Address(RVA = "0xAF0B80", Offset = "0xAEF580", VA = "0x180AF0B80", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			base.OnFocusOut(popAfterFocusOut, animate);
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002206")]
		[Cpp2IlInjected.Address(RVA = "0xAF0AD0", Offset = "0xAEF4D0", VA = "0x180AF0AD0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0064
			base.OnFocusIn();
			_elevatorContent.gameObject.SetActive(value: true);
			HouseExpansionElevatorContent elevatorContent = _elevatorContent;
			Action<int> chooseFloorDelegate = _chooseFloorDelegate;
			int currentFloorIndex = _currentFloorIndex;
			int numberOfFloorsInTheHouse = _numberOfFloorsInTheHouse;
			elevatorContent.Init(this, numberOfFloorsInTheHouse, currentFloorIndex, (Action<>)(object)chooseFloorDelegate);
			GameObject expansionContent = _expansionContent;
			int active = 0;
			expansionContent.SetActive((byte)active != 0);
			base.IsDataUpToDate = true;
			int showAnimation = 0;
			RefreshDisplay((byte)showAnimation != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002207")]
		[Cpp2IlInjected.Address(RVA = "0xAF13D0", Offset = "0xAEFDD0", VA = "0x180AF13D0")]
		public void RefreshDisplay(bool showAnimation)
		{
			//Discarded unreachable code: IL_0248
			//IL_0184: Expected I4, but got I8
			//IL_019f: Expected I4, but got I8
			HouseExpansionFloorMap mcFloorMap = _mcFloorMap;
			int currentFloorIndex = _currentFloorIndex;
			House.Types.Floor currentFloorMap = _currentFloorMap;
			mcFloorMap.RefreshFloor(currentFloorMap, currentFloorIndex);
			RefreshCurrentLevel();
			Transform transform = _mcFloorMap.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			MapField<int, House.Types.Floor.Types.AdditionalRoomsList> boughtRooms_ = ((IEnumerable<>)(object)_playerHouse.floors_).Last<House.Types.Floor>().boughtRooms_;
			Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool> func = default(Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>);
			if (_003C_003Ec._003C_003E9__27_0 == null)
			{
				bool result3 = default(bool);
				func = (Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList> x) => result3));
			}
			if (Enumerable.Count<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>(Enumerable.Where<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)boughtRooms_, (Func<, >)(object)func)) > 0)
			{
				MapField<int, House.Types.Floor.Types.AdditionalRoomsList> boughtRooms_2 = ((IEnumerable<>)(object)_playerHouse.floors_).Last<House.Types.Floor>().boughtRooms_;
				Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool> func2 = default(Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>);
				if (_003C_003Ec._003C_003E9__27_1 == null)
				{
					bool result2 = default(bool);
					func2 = (Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList> x) => result2));
				}
				if (Enumerable.Count<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>(Enumerable.Where<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)boughtRooms_2, (Func<, >)(object)func2)) > 0)
				{
					MapField<int, House.Types.Floor.Types.AdditionalRoomsList> boughtRooms_3 = ((IEnumerable<>)(object)_playerHouse.floors_).Last<House.Types.Floor>().boughtRooms_;
					Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool> func3 = default(Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>);
					if (_003C_003Ec._003C_003E9__27_2 == null)
					{
						bool result = default(bool);
						func3 = (Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList> x) => result));
					}
					int num2 = Enumerable.Count<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>(Enumerable.Where<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)boughtRooms_3, (Func<, >)(object)func3));
				}
			}
			uint num3 = default(uint);
			if (num3 == 0)
			{
				SlidingPanel mcLabel = _mcLabel;
				if (mcLabel.isHidden)
				{
					mcLabel.Show((byte)num3 != 0);
				}
				int num4 = 0;
				GameObject gameObject = _mcElevatorPanel.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			HouseExpansionElevatorPanel mcElevatorPanel = _mcElevatorPanel;
			int num5 = 0;
			if ((mcElevatorPanel.isExpanded ? 1 : 0) == num5)
			{
				OnElevatorCollapsed();
			}
			OnElevatorExpanded();
			ulong num6 = default(ulong);
			_mcElevatorPanel.gameObject.SetActive((byte)num6 != 0);
			SlidingPanel mcLabel2 = _mcLabel;
			if (mcLabel2.isHidden)
			{
				ulong num7 = default(ulong);
				mcLabel2.Show((byte)num7 != 0);
			}
			House playerHouse = _playerHouse;
			HouseExpansionElevatorPanel mcElevatorPanel2 = _mcElevatorPanel;
			int currentFloorIndex2 = _currentFloorIndex;
			int count = ((RepeatedField<T>)(object)playerHouse.floors_).Count;
			int count2 = ((RepeatedField<T>)(object)_houseExpansion.interior_.additionalFloorPrice_).Count;
			if (count > count2)
			{
			}
			HouseExpansion.Types.InteriorExpansion interior_ = _houseExpansion.interior_;
			House playerHouse2 = _playerHouse;
			RepeatedField<CurrencyCost> additionalFloorPrice_ = interior_.additionalFloorPrice_;
			int num8 = ((RepeatedField<T>)(object)playerHouse2.floors_).Count - 1;
			CurrencyCost currencyCost = (CurrencyCost)((RepeatedField<T>)(object)additionalFloorPrice_)[num8];
			mcElevatorPanel2.Init(num8, currentFloorIndex2, currencyCost);
			int num9 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002208")]
		[Cpp2IlInjected.Address(RVA = "0xAF05E0", Offset = "0xAEEFE0", VA = "0x180AF05E0")]
		private void OnElevatorExpanded()
		{
			//Discarded unreachable code: IL_00cd
			//IL_0032: Expected O, but got I4
			_mcElevatorPanel.IsInAnimation = true;
			Transform transform = _mcFloorMap.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			RectTransform mapRT = (RectTransform)num;
			Transform transform2 = _mcElevatorPanel.transform;
			if ((object)transform2 != null)
			{
			}
			RectTransform elevatorRT = (RectTransform)transform2;
			Transform transform3 = _mcElevatorPanel.btnExpand.transform;
			SlidingPanel mcFloorLabel = _mcFloorLabel;
			if ((object)transform3 != null)
			{
			}
			if (mcFloorLabel.isHidden || (object)transform3 != null)
			{
				mcFloorLabel.Show(andOpen: true);
			}
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetEase(Ease.OutQuad);
			TweenCallback tweenCallback = default(TweenCallback);
			TweenCallback tweenCallback2 = delegate
			{
				GameObject gameObject = _mcElevatorPanel.btnExpand.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				_mcElevatorPanel.btnCollapse.gameObject.SetActive(value: true);
				int num3 = 0;
				int num4 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(mapRT, -235f, 0.2f, (byte)num4 != 0)).SetEase(Ease.OutQuad);
				int num5 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(elevatorRT, 380f, 0.2f, (byte)num5 != 0)).SetEase(Ease.OutQuad);
				if (tweenCallback == null)
				{
					tweenCallback = delegate
					{
						//Discarded unreachable code: IL_0012
						_mcElevatorPanel.IsInAnimation = false;
					};
				}
				Delegate delegate2 = default(Delegate);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			};
			Delegate @delegate = Delegate.Combine(tweenCallback2, tweenCallback2);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002209")]
		[Cpp2IlInjected.Address(RVA = "0xAF0320", Offset = "0xAEED20", VA = "0x180AF0320")]
		private void OnElevatorCollapsed()
		{
			//Discarded unreachable code: IL_00c8
			//IL_0051: Expected O, but got I4
			_mcElevatorPanel.IsInAnimation = true;
			Transform transform = _mcFloorMap.transform;
			Transform transform2 = _mcElevatorPanel.transform;
			Transform transform3 = _mcElevatorPanel.btnExpand.transform;
			int num = 0;
			if ((object)transform3 != null)
			{
			}
			RectTransform btnExpandRT = (RectTransform)num;
			SlidingPanel mcFloorLabel = _mcFloorLabel;
			if ((object)transform2 != null)
			{
			}
			if ((object)transform != null)
			{
			}
			if (!mcFloorLabel.isOpened)
			{
				if ((object)transform2 != null)
				{
				}
				if ((object)transform == null)
				{
					goto IL_007a;
				}
			}
			mcFloorLabel.Hide();
			goto IL_007a;
			IL_007a:
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetEase(Ease.OutQuad);
			TweenCallback tweenCallback = default(TweenCallback);
			TweenCallback tweenCallback2 = delegate
			{
				_mcElevatorPanel.btnExpand.gameObject.SetActive(value: true);
				GameObject gameObject = _mcElevatorPanel.btnCollapse.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				int num3 = 0;
				int num4 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(btnExpandRT, 65f, 0.15f, (byte)num4 != 0)).SetEase(Ease.OutQuad);
				if (tweenCallback == null)
				{
					tweenCallback = delegate
					{
						//Discarded unreachable code: IL_0012
						_mcElevatorPanel.IsInAnimation = false;
					};
				}
				Delegate delegate2 = default(Delegate);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			};
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				TweenerCore<Vector2, Vector2, VectorOptions> t2 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = t2.SetEase(Ease.OutQuad);
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600220A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1250", Offset = "0xAEFC50", VA = "0x180AF1250")]
		private void RefreshCurrentLevel()
		{
			//Discarded unreachable code: IL_001e, IL_004b, IL_0053
			//IL_0052: Expected O, but got I4
			TextBase tfCurrentLevel = _tfCurrentLevel;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			int currentFloorIndex = _currentFloorIndex;
			currentFloorIndex++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600220B")]
		[Cpp2IlInjected.Address(RVA = "0xAF11D0", Offset = "0xAEFBD0", VA = "0x180AF11D0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__31))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__31 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__31(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600220C")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnSceneChanged(object sender, EventArgs e)
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x600220D")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnCloseClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x600220E")]
		[Cpp2IlInjected.Address(RVA = "0xAF09F0", Offset = "0xAEF3F0", VA = "0x180AF09F0")]
		private void OnFloorChangedHandler(int floor)
		{
			//Discarded unreachable code: IL_0067
			House playerHouse = _playerHouse;
			_currentFloorIndex = floor;
			House.Types.Floor floor2 = (_currentFloorMap = (House.Types.Floor)((RepeatedField<T>)(object)playerHouse.floors_)[floor]);
			HouseExpansionFloorMap mcFloorMap = _mcFloorMap;
			int currentFloorIndex = _currentFloorIndex;
			House.Types.Floor currentFloorMap = _currentFloorMap;
			mcFloorMap.RefreshFloor(currentFloorMap, currentFloorIndex);
			RefreshCurrentLevel();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600220F")]
		[Cpp2IlInjected.Address(RVA = "0xAF0C20", Offset = "0xAEF620", VA = "0x180AF0C20")]
		private void OnPurchaseSuccessfulHandler(bool purchaseSucceed)
		{
			if (purchaseSucceed)
			{
				CancellationToken cancellationToken = base.CancellationToken;
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002210")]
		[Cpp2IlInjected.Address(RVA = "0xAF0870", Offset = "0xAEF270", VA = "0x180AF0870")]
		private void OnFloorAddHandler()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002211")]
		[Cpp2IlInjected.Address(RVA = "0xAF00D0", Offset = "0xAEEAD0", VA = "0x180AF00D0")]
		[AsyncStateMachine(typeof(_003CAddFloorTask_003Ed__37))]
		private Task AddFloorTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002212")]
		[Cpp2IlInjected.Address(RVA = "0xAF0280", Offset = "0xAEEC80", VA = "0x180AF0280", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0052
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				GameObject gameObject = _mcFloorMap._mainRoom._btnExpand.gameObject;
				bool _003CIsExpandable_003Ek__BackingField = _mcFloorMap._mainRoom.IsExpandable;
				gameObject.SetActive(_003CIsExpandable_003Ek__BackingField);
			}
			else
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002213")]
		[Cpp2IlInjected.Address(RVA = "0xAF1EE0", Offset = "0xAF08E0", VA = "0x180AF1EE0")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_00dc
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			HouseExpansionFloorMap mcFloorMap = _mcFloorMap;
			if (!flag)
			{
				GameObject gameObject = mcFloorMap._mainRoom._btnExpand.gameObject;
				HouseExpansionMainRoomContent mainRoom = _mcFloorMap._mainRoom;
			}
			GameObject gameObject2 = mcFloorMap._mainRoom._btnExpand.gameObject;
			if (_mcElevatorPanel.isExpanded)
			{
			}
			bool active = _mcFloorMap._mainRoom.IsExpandable;
			gameObject2.SetActive(active);
			if (!_elevatorContent.gameObject.activeSelf)
			{
				HouseExpansionElevatorPanel mcElevatorPanel = _mcElevatorPanel;
				int num2 = 0;
				if ((mcElevatorPanel.isExpanded ? 1 : 0) == num2)
				{
					HouseExpansionFloorMap mcFloorMap2 = _mcFloorMap;
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					mcFloorMap2.SetFocus(focusNavigation);
				}
				else
				{
					MenuNavigation menuNavigation = default(MenuNavigation);
					FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
				}
			}
			else
			{
				MenuNavigation menuNavigation2 = default(MenuNavigation);
				FocusNavigation focusNavigation3 = menuNavigation2.FocusNavigation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002214")]
		[Cpp2IlInjected.Address(RVA = "0xAF0200", Offset = "0xAEEC00", VA = "0x180AF0200", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0031
			if (redirectionType != RedirectionType.GamePopCurrentMenu)
			{
				return;
			}
			if (!_mcElevatorPanel.isExpanded)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
				return;
			}
			Button button = default(Button);
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			while (onClick == null)
			{
			}
			onClick.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002215")]
		[Cpp2IlInjected.Address(RVA = "0xAF2570", Offset = "0xAF0F70", VA = "0x180AF2570")]
		public void UpdateBackShortcutIndicators(bool active)
		{
			//Discarded unreachable code: IL_0012
			_backShortcutIndicator.gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6002216")]
		[Cpp2IlInjected.Address(RVA = "0xA5C390", Offset = "0xA5AD90", VA = "0x180A5C390")]
		public CurrencyContent GetCurrencyContent()
		{
			return _mcCurrencyContent;
		}

		[Cpp2IlInjected.Token(Token = "0x6002217")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public HouseExpansionMenu()
		{
		}
	}
}
