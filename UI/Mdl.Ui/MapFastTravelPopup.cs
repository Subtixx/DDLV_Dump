using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Navigation;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000629")]
	public class MapFastTravelPopup : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002248")]
		private MapMenu _mapMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002249")]
		private bool _isGamepadConnected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400224A")]
		private FocusNavigationElement _focusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400224B")]
		[SerializeField]
		private NavigationBar _tabNavigationBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400224C")]
		[SerializeField]
		private MapFastTravelToggleButton[] _fastTravelButtons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400224D")]
		[SerializeField]
		private GameObject _fastTravelsVillagesHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400224E")]
		[SerializeField]
		private GameObject _fastTravelsReamlsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400224F")]
		[SerializeField]
		private RectTransform _doors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002250")]
		[SerializeField]
		private CastleDoorItem _prefabDoor;

		[Cpp2IlInjected.Token(Token = "0x600282B")]
		[Cpp2IlInjected.Address(RVA = "0xFB1580", Offset = "0xFAFF80", VA = "0x180FB1580", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0058, IL_006a, IL_007e, IL_0087
			base.OnPush(stack, param);
			int num = 0;
			_mapMenu = (MapMenu)typeof(MapFastTravelPopupArgs).TypeHandle;
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = (_isGamepadConnected = instance.IsControllerConnected((byte)useKeyboardAsController != 0));
			List<(NavigationBarButton, Action)> buttons = _tabNavigationBar._buttons;
			Dictionary<string, Action> dictionary = (Dictionary<string, Action>)(object)new Dictionary<TKey, TValue>();
			Action action = OnSelectVillagesTab;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600282C")]
		[Cpp2IlInjected.Address(RVA = "0xFB1570", Offset = "0xFAFF70", VA = "0x180FB1570", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600282D")]
		[Cpp2IlInjected.Address(RVA = "0xFB1450", Offset = "0xFAFE50", VA = "0x180FB1450")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_0040
			AK.Wwise.Event @event = closeSFX;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			PopSelf();
			int num2 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			Type typeFromHandle = typeof(HudMenu);
			menuStack.PopAllAbove(typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600282E")]
		[Cpp2IlInjected.Address(RVA = "0xFB1D00", Offset = "0xFB0700", VA = "0x180FB1D00")]
		private void OnSelectVillagesTab()
		{
			//Discarded unreachable code: IL_0088
			_fastTravelsVillagesHolder.SetActive(value: true);
			GameObject fastTravelsReamlsHolder = _fastTravelsReamlsHolder;
			int active = 0;
			fastTravelsReamlsHolder.SetActive((byte)active != 0);
			RefreshVillagesButtons();
			if (_isGamepadConnected)
			{
				ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
				if (focusedElement == null)
				{
				}
				int num = 0;
				_focusedElement = (FocusNavigationElement)focusedElement;
				MenuNavigation menuNavigation = base.MenuNavigation;
				GameObject fastTravelsVillagesHolder = _fastTravelsVillagesHolder;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				Transform transform = fastTravelsVillagesHolder.transform;
				int index = 0;
				FocusNavigationElement component = transform.GetChild(index).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600282F")]
		[Cpp2IlInjected.Address(RVA = "0xFB1870", Offset = "0xFB0270", VA = "0x180FB1870")]
		private void OnSelectRealmsTab()
		{
			//Discarded unreachable code: IL_0160, IL_0166, IL_016c, IL_0172, IL_0178, IL_017e, IL_0184, IL_0196
			//IL_015f: Expected O, but got I4
			int num = 0;
			_fastTravelsReamlsHolder.SetActive(value: true);
			GameObject fastTravelsVillagesHolder = _fastTravelsVillagesHolder;
			int active = 0;
			fastTravelsVillagesHolder.SetActive((byte)active != 0);
			if (_doors.childCount == 0)
			{
				RefreshCastleDoors();
			}
			if ((_isGamepadConnected ? 1 : 0) == num || _doors.childCount <= 0)
			{
				return;
			}
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			if (focusedElement == null)
			{
			}
			int num2 = 0;
			_focusedElement = (FocusNavigationElement)focusedElement;
			Transform transform = _fastTravelsReamlsHolder.transform;
			int index = 0;
			if ((transform.GetChild(index).GetComponent<CastleDoorItem>()._isLocked ? 1 : 0) == num)
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				RectTransform doors = _doors;
				int index2 = 0;
				FocusNavigationElement component = doors.GetChild(index2).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
				return;
			}
			int num3 = 0;
			IEnumerator enumerator = _fastTravelsReamlsHolder.transform.GetEnumerator();
			MenuNavigation menuNavigation = default(MenuNavigation);
			if (enumerator != null)
			{
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				CastleDoorItem castleDoorItem = default(CastleDoorItem);
				if (castleDoorItem._isLocked)
				{
					num++;
				}
				FocusNavigationElement focusNavigationElement = (_focusedElement = _doors.GetChild(num).GetComponent<FocusNavigationElement>());
				menuNavigation = base.MenuNavigation;
				FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
				FocusNavigationElement focusedElement2 = _focusedElement;
				focusNavigation2.SetFocus(focusedElement2);
			}
			if ((object)menuNavigation != null)
			{
			}
			ulong num6 = default(ulong);
			while (num6 != 0)
			{
			}
			MenuNavigation menuNavigation2 = default(MenuNavigation);
			FocusNavigation focusNavigation3 = menuNavigation2.FocusNavigation;
			int num7 = 0;
			focusNavigation3.SetFocus((FocusNavigationElement)num7);
		}

		[Cpp2IlInjected.Token(Token = "0x6002830")]
		[Cpp2IlInjected.Address(RVA = "0xFB27F0", Offset = "0xFB11F0", VA = "0x180FB27F0")]
		private void RefreshVillagesButtons()
		{
			//Discarded unreachable code: IL_0109, IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139, IL_013f, IL_0145
			//IL_0024: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_00d9: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			Func<MapFastTravelToggleButton, bool> func2 = default(Func<MapFastTravelToggleButton, bool>);
			while (true)
			{
				int num = 0;
				List<FastTravelDestination> fastTravelPods = _mapMenu._fastTravelPods;
				if (!flag)
				{
					break;
				}
				FastTravelDestination fastTravelPod = (FastTravelDestination)0;
				MapFastTravelToggleButton[] fastTravelButtons = _fastTravelButtons;
				Func<MapFastTravelToggleButton, bool> func = (Func<MapFastTravelToggleButton, bool>)(object)(Func<T, TResult>)delegate(MapFastTravelToggleButton b)
				{
					//Discarded unreachable code: IL_001a
					FastTravelDestination fastTravelDestination = fastTravelPod;
					int itemID = b.ItemID;
					Item item = fastTravelDestination.Item;
					return (IntPtr)itemID == (IntPtr)item;
				};
				MapFastTravelToggleButton mapFastTravelToggleButton = Enumerable.FirstOrDefault<MapFastTravelToggleButton>((IEnumerable<>)(object)fastTravelButtons, (Func<, >)(object)func);
				bool isSelected = mapFastTravelToggleButton._isSelected;
				if (!flag2)
				{
					int num2 = 0;
					if (!(mapFastTravelToggleButton != (UnityEngine.Object)num2))
					{
						continue;
					}
					if ((object)mapFastTravelToggleButton != null)
					{
						MapMenuParams param = _mapMenu._param;
						if (param == null || !(param.FastTravelOrigin == (UnityEngine.Object)(object)fastTravelButtons))
						{
							Action action = OnCloseClicked;
						}
					}
				}
				MapFastTravelToggleButton[] fastTravelButtons2 = _fastTravelButtons;
				if (_003C_003Ec._003C_003E9__14_1 == null)
				{
					func2 = (Func<MapFastTravelToggleButton, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MapFastTravelToggleButton b) => b.Destination == MapFastTravelToggleButton.DestinationType.Plaza));
				}
				MapFastTravelToggleButton mapFastTravelToggleButton2 = Enumerable.FirstOrDefault<MapFastTravelToggleButton>((IEnumerable<>)(object)fastTravelButtons2, (Func<, >)(object)func2);
				int num3 = 0;
				if (mapFastTravelToggleButton2 != (UnityEngine.Object)num3 && _mapMenu._mcWishingWellItem.gameObject.activeSelf)
				{
					Action action2 = OnCloseClicked;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002831")]
		[Cpp2IlInjected.Address(RVA = "0xFB1E70", Offset = "0xFB0870", VA = "0x180FB1E70")]
		private unsafe void RefreshCastleDoors()
		{
			//Discarded unreachable code: IL_01a4, IL_01aa, IL_01b0, IL_01b6, IL_01bc, IL_01c2, IL_01c8, IL_01ce, IL_01da, IL_01e0, IL_01e6, IL_01ec, IL_01f2, IL_01f8, IL_01fe, IL_0204, IL_020a, IL_0210, IL_0216, IL_021c, IL_0222, IL_0228, IL_022e, IL_0234, IL_0240
			//IL_008f: Expected I8, but got I4
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_00f4: Expected I4, but got I8
			IOrderedEnumerable<WorldData.Types.World> orderedEnumerable = default(IOrderedEnumerable<WorldData.Types.World>);
			uint num3 = default(uint);
			Client client = default(Client);
			uint num4 = default(uint);
			int num5 = default(int);
			CastleDoorItem castleDoorItem = default(CastleDoorItem);
			IEnumerator enumerator = default(IEnumerator);
			CastleDoorItem castleDoorItem2 = default(CastleDoorItem);
			ulong num9 = default(ulong);
			int num10 = default(int);
			Transform transform = default(Transform);
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			Transform transform2 = default(Transform);
			int num11 = default(int);
			Transform transform3 = default(Transform);
			FocusNavigationElement component5 = default(FocusNavigationElement);
			Transform transform4 = default(Transform);
			while (true)
			{
				int num = 0;
				if (!ProtoDatabase.Instance.TryGet("Worlds", out *(WorldData*)num))
				{
					return;
				}
				if (_003C_003Ec._003C_003E9__15_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((WorldData.Types.World x) => x.unlockAtLevel_);
				}
				int num2 = 0;
				if (orderedEnumerable != null)
				{
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_00c1;
						}
						num2++;
					}
					if (!client.profile.settings_.isDev_)
					{
					}
					if (num == (int)num4)
					{
						num++;
						num5 = 0;
						num += 4;
					}
					CastleDoorItem prefabDoor = _prefabDoor;
					RectTransform component = castleDoorItem.GetComponent<RectTransform>();
					long num6 = num5 * 340;
					castleDoorItem = (CastleDoorItem)(castleDoorItem + num6);
					castleDoorItem.Index = num;
					castleDoorItem.Row = num;
					castleDoorItem.Col = num5;
					castleDoorItem.RefreshDisplay((WorldData.Types.World)num2);
					num++;
					num5++;
					goto IL_00c1;
				}
				goto IL_00c5;
				IL_00c5:
				if (orderedEnumerable != null)
				{
					int num7 = 0;
				}
				if (num == 0)
				{
					if (enumerator != null)
					{
						int num8 = 0;
						if (enumerator == null)
						{
							break;
						}
						castleDoorItem2.gameObject.SetActive((byte)num9 != 0);
						if (castleDoorItem2.Index + 1 < num10)
						{
							int _003CIndex_003Ek__BackingField = castleDoorItem2.Index;
							_003CIndex_003Ek__BackingField++;
							FocusNavigationElement component2 = transform.GetComponent<FocusNavigationElement>();
							focusNavigationElement.AssignNext(FocusDirection.Right, component2);
						}
						if (castleDoorItem2.Index > 0)
						{
							FocusNavigationElement component3 = transform2.GetComponent<FocusNavigationElement>();
							int direction = 0;
							focusNavigationElement.AssignNext((FocusDirection)direction, component3);
						}
						int _003CIndex_003Ek__BackingField2 = castleDoorItem2.Index;
						int _003CIndex_003Ek__BackingField3 = castleDoorItem2.Index;
						if (_003CIndex_003Ek__BackingField2 == num11)
						{
						}
						_003CIndex_003Ek__BackingField3 += num;
						FocusNavigationElement component4 = transform3.GetComponent<FocusNavigationElement>();
						focusNavigationElement.AssignNext(FocusDirection.Down, component4);
						int _003CIndex_003Ek__BackingField4 = castleDoorItem2.Index;
						_003CIndex_003Ek__BackingField4 -= num;
						component5 = transform4.GetComponent<FocusNavigationElement>();
						focusNavigationElement.AssignNext(FocusDirection.Up, component5);
					}
					if ((object)component5 != null)
					{
					}
					if (num == 0)
					{
						return;
					}
					continue;
				}
				throw new NullReferenceException();
				IL_00c1:
				num2 += num2;
				goto IL_00c5;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002832")]
		[Cpp2IlInjected.Address(RVA = "0xFB1520", Offset = "0xFAFF20", VA = "0x180FB1520", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0026
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = (_isGamepadConnected = instance.IsControllerConnected((byte)useKeyboardAsController != 0));
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6002833")]
		[Cpp2IlInjected.Address(RVA = "0xFB2D30", Offset = "0xFB1730", VA = "0x180FB2D30")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_00e5
			//IL_0096: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			if (!_isGamepadConnected)
			{
				return;
			}
			if (!_fastTravelsReamlsHolder.activeSelf)
			{
				if (_fastTravelsVillagesHolder.activeSelf)
				{
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					Transform transform = _fastTravelsVillagesHolder.transform;
					int index = 0;
					FocusNavigationElement component = transform.GetChild(index).GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
				return;
			}
			Transform transform2 = _fastTravelsReamlsHolder.transform;
			int index2 = 0;
			if (!transform2.GetChild(index2).GetComponent<CastleDoorItem>()._isLocked)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
			}
			FocusNavigationElement focusedElement = _focusedElement;
			int num = 0;
			if (focusedElement != (UnityEngine.Object)num && _focusedElement.gameObject.activeSelf)
			{
				FocusNavigation focusNavigation2 = base.MenuNavigation.FocusNavigation;
				FocusNavigationElement focusedElement2 = _focusedElement;
				focusNavigation2.SetFocus(focusedElement2);
			}
			else
			{
				FocusNavigation focusNavigation3 = base.MenuNavigation.FocusNavigation;
				int num2 = 0;
				focusNavigation3.SetFocus((FocusNavigationElement)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002834")]
		[Cpp2IlInjected.Address(RVA = "0xFB13B0", Offset = "0xFAFDB0", VA = "0x180FB13B0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_005b
			if (redirectionType > RedirectionType.GamePromptClose)
			{
				if (redirectionType == RedirectionType.GamePromptGoBackward)
				{
					goto IL_003b;
				}
				if (redirectionType != RedirectionType.GameTabLeft)
				{
					if (redirectionType != RedirectionType.GameTabRight)
					{
						return;
					}
					goto IL_0043;
				}
			}
			else if ((object)this != null)
			{
				if ((object)this != null)
				{
					if ((object)this != null && (long)this != 1)
					{
						while (redirectionType != RedirectionType.GamePromptClose)
						{
						}
					}
					goto IL_003b;
				}
				goto IL_0043;
			}
			_tabNavigationBar.SelectPrevious();
			return;
			IL_0043:
			_tabNavigationBar.SelectNext();
			return;
			IL_003b:
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002835")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF70", Offset = "0xE19970", VA = "0x180E1AF70")]
		public MapFastTravelPopup()
		{
		}
	}
}
