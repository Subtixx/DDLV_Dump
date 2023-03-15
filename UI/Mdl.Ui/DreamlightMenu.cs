using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000445")]
	public class DreamlightMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000446")]
		internal enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x40015B2")]
			RoyalDuty,
			[Cpp2IlInjected.Token(Token = "0x40015B3")]
			Achievement,
			[Cpp2IlInjected.Token(Token = "0x40015B4")]
			StarPath
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400159D")]
		private DreamlightTabButton _selectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400159E")]
		internal DreamlightMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40015A0")]
		[SerializeField]
		private ImageHelper _currenyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40015A1")]
		[SerializeField]
		private TextBase _currenyAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40015A2")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40015A3")]
		[SerializeField]
		private RectTransform _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40015A4")]
		[SerializeField]
		private RectTransform _viewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40015A5")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40015A6")]
		[SerializeField]
		private GameObject _tabsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40015A7")]
		[SerializeField]
		private DreamlightTabButton[] _tabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40015A8")]
		[SerializeField]
		private ParticleSystem _dreamlightVfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40015A9")]
		[SerializeField]
		private Image[] _dreamlightGlowBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40015AA")]
		[SerializeField]
		private RecycleBin _recycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40015AB")]
		private Coroutine _focusCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40015AC")]
		public int FocusedItemIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40015AD")]
		public bool IsOnTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40015AE")]
		[SerializeField]
		[Header("Fill the field below to adjust size for Switch")]
		private int _switchFontMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40015AF")]
		[SerializeField]
		private int _switchFontMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40015B0")]
		private Vector2 _oldPosition;

		[Cpp2IlInjected.Token(Token = "0x17000487")]
		private DreamlightMenuModel _model
		{
			[Cpp2IlInjected.Token(Token = "0x6001BA5")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			[CompilerGenerated]
			get
			{
				return _003C_model_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BA6")]
			[Cpp2IlInjected.Address(RVA = "0x9765D0", Offset = "0x974FD0", VA = "0x1809765D0")]
			[CompilerGenerated]
			set
			{
				_003C_model_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new DreamlightMenuModel();


		[Cpp2IlInjected.Token(Token = "0x17000488")]
		public DreamlightTabButton SelectedTab
		{
			[Cpp2IlInjected.Token(Token = "0x6001BA7")]
			[Cpp2IlInjected.Address(RVA = "0x975DD0", Offset = "0x9747D0", VA = "0x180975DD0")]
			get
			{
				return _selectedTab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000489")]
		public RectTransform Items
		{
			[Cpp2IlInjected.Token(Token = "0x6001BA8")]
			[Cpp2IlInjected.Address(RVA = "0x738C10", Offset = "0x737610", VA = "0x180738C10")]
			get
			{
				return _items;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048A")]
		[HideInInspector]
		public bool AdjustForSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6001BA9")]
			[Cpp2IlInjected.Address(RVA = "0xF20290", Offset = "0xF1EC90", VA = "0x180F20290")]
			get
			{
				if (_switchFontMin == -1)
				{
					int num = 0;
				}
				return _switchFontMax != -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAA")]
		[Cpp2IlInjected.Address(RVA = "0xF1DC30", Offset = "0xF1C630", VA = "0x180F1DC30", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_008e
			//IL_0029: Expected O, but got I4
			//IL_0036: Expected I4, but got I8
			base.OnPush(stack, param);
			int num = 0;
			UiRoot.Instance.UpdateCursorBehaviorForUI();
			int num2 = 0;
			if (param != null)
			{
				int num3 = 0;
				if (param != null)
				{
					int num4 = 0;
				}
			}
			_param = (DreamlightMenuParam)num2;
			ulong num5 = default(ulong);
			_tabsHolder.SetActive((byte)num5 != 0);
			SystemRoot.Instance.GetSystem<AudioManager>().PushGameState(AudioManager.GameState.MainMenu);
			base.Background.GetComponent<MainMenuBackground>().SetLeftWidth(438f);
			DreamlightTabButton[] tabs = _tabs;
			Action<DreamlightTabButton> action = default(Action<DreamlightTabButton>);
			if (_003C_003Ec._003C_003E9__43_0 == null)
			{
				action = (Action<DreamlightTabButton>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(DreamlightTabButton x)
				{
					//Discarded unreachable code: IL_0018
					x.RedDot.CheckState(refresh: true);
					x.RedDot.AddToRealTimeUpdate();
				});
			}
			MoreLinq.ForEach<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAB")]
		[Cpp2IlInjected.Address(RVA = "0xF1D4C0", Offset = "0xF1BEC0", VA = "0x180F1D4C0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0171
			//IL_00b4: Expected O, but got I8
			//IL_0100: Expected O, but got I4
			//IL_0170: Expected I4, but got I8
			base.OnFocusIn();
			DreamlightTabButton[] tabs = _tabs;
			int num = 0;
			int num2 = 0;
			int length = tabs.Length;
			if (num < length)
			{
				if (AdjustForSwitch)
				{
					int switchFontMax = _switchFontMax;
					DreamlightTabButton dreamlightTabButton = tabs[num2];
					int switchFontMin = _switchFontMin;
					dreamlightTabButton._switchFontMax = switchFontMax;
					dreamlightTabButton._switchFontMin = switchFontMin;
					dreamlightTabButton.UpdateDisplay();
				}
				num2++;
			}
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
			DreamlightTabButton dreamlightTabButton2 = default(DreamlightTabButton);
			if ((long)_param != 0)
			{
				DreamlightTabButton[] tabs2 = _tabs;
				Func<DreamlightTabButton, bool> func = (Func<DreamlightTabButton, bool>)(object)(Func<T, TResult>)delegate(DreamlightTabButton x)
				{
					//Discarded unreachable code: IL_0016
					AchievementType achievementType = _param.AchievementType;
					return x.AchievementType == achievementType;
				};
				int num4 = MoreLinq.FindIndex<DreamlightTabButton>((IEnumerable<>)(object)tabs2, (Func<, >)(object)func);
				dreamlightTabButton2 = tabs2[num4];
			}
			_param = (DreamlightMenuParam)0;
			((Menu)this).IsDataUpToDate = true;
			GameObject gameObject = _tabs[0].gameObject;
			uint phases = default(uint);
			bool active = SystemRoot.Instance.MetaClient.profile.player_.HasHudApparition(phases);
			gameObject.SetActive(active);
			int num5 = 0;
			DreamlightTabButton tab = default(DreamlightTabButton);
			if (dreamlightTabButton2 == (UnityEngine.Object)num5)
			{
				DreamlightTabButton[] tabs3 = _tabs;
				Func<DreamlightTabButton, bool> func2 = default(Func<DreamlightTabButton, bool>);
				if (_003C_003Ec._003C_003E9__30_1 == null)
				{
					func2 = (Func<DreamlightTabButton, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DreamlightTabButton x) => x.gameObject.activeSelf));
				}
				int num6 = MoreLinq.FindIndex<DreamlightTabButton>((IEnumerable<>)(object)tabs3, (Func<, >)(object)func2);
				tab = tabs3[num6];
			}
			int fromMove = 0;
			SelectTab(tab, (byte)fromMove != 0);
			int num7 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
			{
				ulong num8 = default(ulong);
				SetFocus((byte)num8 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAC")]
		[Cpp2IlInjected.Address(RVA = "0xF1EB90", Offset = "0xF1D590", VA = "0x180F1EB90", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0077
			((object)this)._002Ector();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.AchievementSetUpdated value2 = RefreshRedDot;
			_003CDispatcher_003Ek__BackingField2.OnAchievementSetUpdated += value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.DutySlotUpdated value3 = RefreshRedDot;
			_003CDispatcher_003Ek__BackingField3.OnDutySlotUpdated += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAD")]
		[Cpp2IlInjected.Address(RVA = "0xF1FCB0", Offset = "0xF1E6B0", VA = "0x180F1FCB0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0077
			base.UnregisterFocusedListeners();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
			_003CDispatcher_003Ek__BackingField.OnCurrencyChanged -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.AchievementSetUpdated value2 = RefreshRedDot;
			_003CDispatcher_003Ek__BackingField2.OnAchievementSetUpdated -= value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.DutySlotUpdated value3 = RefreshRedDot;
			_003CDispatcher_003Ek__BackingField3.OnDutySlotUpdated -= value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAE")]
		[Cpp2IlInjected.Address(RVA = "0xF1D910", Offset = "0xF1C310", VA = "0x180F1D910", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_001a
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BAF")]
		[Cpp2IlInjected.Address(RVA = "0xF1DA00", Offset = "0xF1C400", VA = "0x180F1DA00", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_008d
			//IL_0027: Expected O, but got I4
			Coroutine focusCoroutine = _focusCoroutine;
			if (focusCoroutine != null)
			{
				StopCoroutine(focusCoroutine);
			}
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num = 0;
			focusNavigation.FocusedElement = (ISupportsFocusNavigation)num;
			DreamlightTabButton[] tabs = _tabs;
			Action<DreamlightTabButton> action = default(Action<DreamlightTabButton>);
			if (_003C_003Ec._003C_003E9__34_0 == null)
			{
				action = (Action<DreamlightTabButton>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(DreamlightTabButton x)
				{
					//Discarded unreachable code: IL_000c
					x.RedDot.RemoveFromRealTimeUpdate();
				});
			}
			MoreLinq.ForEach<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Action<>)(object)action);
			base.OnPop();
			DreamlightMenuModel dreamlightMenuModel = _model;
			RecycleBin recycleBin = _recycleBin;
			RectTransform items = _items;
			Type typeFromHandle = typeof(DreamlightItem);
			recycleBin.SendChildrenToBin(items, typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB0")]
		[Cpp2IlInjected.Address(RVA = "0xF1EE40", Offset = "0xF1D840", VA = "0x180F1EE40")]
		public void Reorder()
		{
			//Discarded unreachable code: IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00ea
			int num = 0;
			IEnumerable<DreamlightItem> enumerable = (IEnumerable<DreamlightItem>)Enumerable.AsEnumerable<DreamlightItem>((IEnumerable<>)(object)_items.GetComponentsInChildren<DreamlightItem>());
			Func<DreamlightItem, bool> _003C_003E9__35_ = _003C_003Ec._003C_003E9__35_0;
			if (_003C_003E9__35_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DreamlightItem x) => !x.Model.IsMilestoneEnded());
			}
			IOrderedEnumerable<DreamlightItem> orderedEnumerable = (IOrderedEnumerable<DreamlightItem>)Enumerable.OrderByDescending<DreamlightItem, bool>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__35_);
			Func<DreamlightItem, bool> func = default(Func<DreamlightItem, bool>);
			if (_003C_003Ec._003C_003E9__35_1 == null)
			{
				func = (Func<DreamlightItem, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DreamlightItem x) => x.Model.IsClaimable()));
			}
			IOrderedEnumerable<DreamlightItem> orderedEnumerable2 = (IOrderedEnumerable<DreamlightItem>)Enumerable.ThenByDescending<DreamlightItem, bool>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func);
			int num3 = default(int);
			if (orderedEnumerable2 != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0086;
					}
					num++;
				}
				num3 = 0;
				Transform transform = default(Transform);
				transform.SetAsLastSibling();
				goto IL_0086;
			}
			goto IL_008d;
			IL_008d:
			if (orderedEnumerable2 != null)
			{
				int num4 = 0;
			}
			int num5 = default(int);
			if (num5 > 0)
			{
				int num6 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					MenuNavigation menuNavigation = default(MenuNavigation);
					FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
					int num7 = 0;
					Transform transform2 = default(Transform);
					FocusNavigationElement component = transform2.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
			return;
			IL_0086:
			num3 += num3;
			goto IL_008d;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB1")]
		[Cpp2IlInjected.Address(RVA = "0xF1F2A0", Offset = "0xF1DCA0", VA = "0x180F1F2A0")]
		public void SelectTab(DreamlightTabButton tab)
		{
			int fromMove = 0;
			SelectTab(tab, (byte)fromMove != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB2")]
		[Cpp2IlInjected.Address(RVA = "0xF1F2B0", Offset = "0xF1DCB0", VA = "0x180F1F2B0")]
		public void SelectTab(DreamlightTabButton tab, bool fromMove = false)
		{
			//Discarded unreachable code: IL_00e4
			//IL_0026: Expected O, but got I4
			//IL_0059: Expected I4, but got I8
			//IL_00ac: Expected O, but got I4
			//IL_00dc: Expected I4, but got I8
			bool flag = default(bool);
			if (!flag)
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num = 0;
				focusNavigation.SetFocus((FocusNavigationElement)num);
				IEnumerator routine = SetDelayedFocus(fromMove);
				Coroutine coroutine = (_focusCoroutine = StartCoroutine(routine));
			}
			DreamlightTabButton[] tabs = _tabs;
			FocusedItemIndex = -1;
			Func<DreamlightTabButton, bool> func = (Func<DreamlightTabButton, bool>)(object)(Func<T, TResult>)delegate(DreamlightTabButton x)
			{
				DreamlightTabButton dreamlightTabButton = tab;
				return x != dreamlightTabButton;
			};
			IEnumerable<DreamlightTabButton> enumerable = (IEnumerable<DreamlightTabButton>)Enumerable.Where<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Func<, >)(object)func);
			Action<DreamlightTabButton> _003C_003E9__37_ = _003C_003Ec._003C_003E9__37_1;
			if (_003C_003E9__37_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(DreamlightTabButton x)
				{
					//Discarded unreachable code: IL_000a
					int num5 = ((x.IsHighlighted = false) ? 1 : 0);
				};
			}
			MoreLinq.ForEach<DreamlightTabButton>((IEnumerable<>)enumerable, (Action<>)(object)_003C_003E9__37_);
			bool flag2 = default(bool);
			if (flag2)
			{
				int num2 = 0;
			}
			_selectedTab = (DreamlightTabButton)flag2;
			ulong num3 = default(ulong);
			bool flag3 = default(bool);
			if (num3 != (ulong)(flag3 ? 1 : 0))
			{
				_model.AchievementType = (flag3 ? AchievementType.Foraging : AchievementType.None);
				_model.RefreshData();
				ulong num4 = default(ulong);
				_items.gameObject.SetActive((byte)num4 != 0);
				RefreshDisplay(fromMove);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB3")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1CA20", VA = "0x180F1E020")]
		private void RefreshDisplay(bool fromMove = false)
		{
			//Discarded unreachable code: IL_024a, IL_0250, IL_0256, IL_025c, IL_0262, IL_0268, IL_026e, IL_0274, IL_027a, IL_0280, IL_0286, IL_028c, IL_0292, IL_0298, IL_029e
			//IL_0021: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_011e: Expected I4, but got I8
			//IL_0139: Expected O, but got I4
			//IL_01bd: Expected F4, but got I4
			//IL_0246: Expected O, but got I4
			int num = 0;
			RectTransform content = _scrollRect.m_Content;
			int num2 = 0;
			Vector2 anchoredPosition = content.anchoredPosition;
			int num3 = 0;
			content.anchoredPosition = (Vector2)num2;
			int childCount = _items.childCount;
			int childCount2 = _items.childCount;
			int num4 = Enumerable.Count<DreamlightItemModel>((IEnumerable<>)_model.DreamlightItemModels);
			childCount2 -= num4;
			RectTransform items = _items;
			int index = items.childCount - 1;
			DreamlightItem component = items.GetChild(index).GetComponent<DreamlightItem>();
			component.IsVisible = (byte)num != 0;
			component.ReleaseView();
			component.Model = (DreamlightItemModel)num;
			RecycleBin recycleBin = _recycleBin;
			GameObject trash = component.gameObject;
			recycleBin.SendToBin(trash);
			DreamlightMenuModel dreamlightMenuModel = _model;
			IEnumerable<DreamlightItemModel> _003CDreamlightItemModels_003Ek__BackingField = dreamlightMenuModel.DreamlightItemModels;
			uint num5 = default(uint);
			if (num < (int)num5)
			{
				num += num;
				num++;
			}
			DreamlightItem component2 = default(DreamlightItem);
			FocusNavigationElement focusNavigationElement3 = default(FocusNavigationElement);
			if (dreamlightMenuModel != null)
			{
				uint num6 = default(uint);
				if (num < (int)num6)
				{
					num += num;
					if (num == (int)num6)
					{
						goto IL_01e2;
					}
					num++;
				}
				int childCount3 = _items.childCount;
				RecycleBin recycleBin2 = _recycleBin;
				Type typeFromHandle = typeof(DreamlightItem);
				RectTransform items2 = _items;
				ulong num7 = default(ulong);
				recycleBin2.FindReusableOrNew(typeFromHandle, items2).SetActive((byte)num7 != 0);
				component2 = _items.GetChild(num).GetComponent<DreamlightItem>();
				component2.Model = (DreamlightItemModel)num;
				FocusNavigation focusNavigation = (component2.FocusNavigation = base.MenuNavigation.FocusNavigation);
				FocusNavigationElement focusNavigationElement = component2.FocusNavigationElement;
				GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)(focusNavigationElement.LayoutGroup = _items.GetComponent<GridLayoutGroup>());
				FocusNavigationElement focusNavigationElement2 = component2.FocusNavigationElement;
				ScrollRect scrollRect = (focusNavigationElement2.ScrollRect = _scrollRect);
				component2.FocusNavigationElement.UsetAltLogicForScrolling = true;
				bool flag = (component2.IsInFirstRow = num < 4);
				int num8 = Enumerable.Count<DreamlightItemModel>((IEnumerable<>)_model.DreamlightItemModels);
				int num9 = Mathf.FloorToInt(num3);
				bool flag2 = (component2.IsInLastRow = num >= num9);
				focusNavigationElement3 = component2.FocusNavigationElement;
				focusNavigationElement3 = (FocusNavigationElement)(object)((object)focusNavigationElement3 + (object)focusNavigationElement3);
				goto IL_01e2;
			}
			goto IL_021c;
			IL_01e2:
			focusNavigationElement3 = (FocusNavigationElement)(object)((object)focusNavigationElement3 + (object)focusNavigationElement3);
			int num10 = 0;
			RectTransform viewport = _viewport;
			if ((object)component2.transform != null)
			{
			}
			bool _003CIsVisible_003Ek__BackingField = default(bool);
			component2.IsVisible = _003CIsVisible_003Ek__BackingField;
			RecycleBin recycleBin3 = (component2.RecycleBin = _recycleBin);
			num++;
			goto IL_021c;
			IL_021c:
			int num11 = 0;
			if (dreamlightMenuModel != null)
			{
				int num12 = 0;
			}
			int num13 = 0;
			Item dreamDustCurrencyItem = CurrencyItem.DreamDustCurrencyItem;
			MenuNavigation menuNavigation = default(MenuNavigation);
			FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
			int num14 = 0;
			focusNavigation2.SetFocus((FocusNavigationElement)num14);
			int num15 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB4")]
		[Cpp2IlInjected.Address(RVA = "0xF1F670", Offset = "0xF1E070", VA = "0x180F1F670")]
		[IteratorStateMachine(typeof(_003CSetDelayedFocus_003Ed__39))]
		private IEnumerator SetDelayedFocus(bool fromMove = false)
		{
			int _003C_003E1__state = default(int);
			_003CSetDelayedFocus_003Ed__39 _003CSetDelayedFocus_003Ed__ = new _003CSetDelayedFocus_003Ed__39(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetDelayedFocus_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB5")]
		[Cpp2IlInjected.Address(RVA = "0xF1F6E0", Offset = "0xF1E0E0", VA = "0x180F1F6E0")]
		private void SetFocus(bool fromFocusIn = false)
		{
			//Discarded unreachable code: IL_0162
			//IL_00c0: Expected O, but got I4
			if (FocusedItemIndex != -1 && _items.childCount > FocusedItemIndex && !fromFocusIn)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				RectTransform items = _items;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				int focusedItemIndex = FocusedItemIndex;
				FocusNavigationElement component = items.GetChild(focusedItemIndex).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
			if ((long)base.MenuNavigation.FocusNavigation._focusedElement == 0 && !fromFocusIn)
			{
				FocusNavigation focusNavigation2 = base.MenuNavigation.FocusNavigation;
				DreamlightItem anyVisibleItem = GetAnyVisibleItem();
				FocusNavigationElement component2 = default(FocusNavigationElement);
				if ((object)anyVisibleItem != null)
				{
					component2 = anyVisibleItem.GetComponent<FocusNavigationElement>();
				}
				focusNavigation2.SetFocus(component2);
			}
			if ((long)base.MenuNavigation.FocusNavigation._focusedElement == 0)
			{
				DreamlightTabButton selectedTab = _selectedTab;
				int num = 0;
				if (selectedTab != (UnityEngine.Object)num)
				{
					MenuNavigation menuNavigation2 = base.MenuNavigation;
					DreamlightTabButton selectedTab2 = _selectedTab;
					FocusNavigation focusNavigation3 = menuNavigation2.FocusNavigation;
					FocusNavigationElement component3 = selectedTab2.GetComponent<FocusNavigationElement>();
					focusNavigation3.SetFocus(component3);
				}
			}
			if ((long)base.MenuNavigation.FocusNavigation._focusedElement != 0)
			{
				return;
			}
			DreamlightTabButton[] tabs = _tabs;
			Func<DreamlightTabButton, bool> func = default(Func<DreamlightTabButton, bool>);
			if (_003C_003Ec._003C_003E9__40_0 == null)
			{
				func = (Func<DreamlightTabButton, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DreamlightTabButton x) => x.gameObject.activeSelf));
			}
			int num2 = MoreLinq.FindIndex<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Func<, >)(object)func);
			DreamlightTabButton dreamlightTabButton = tabs[num2];
			FocusNavigation focusNavigation4 = base.MenuNavigation.FocusNavigation;
			FocusNavigationElement component4 = dreamlightTabButton.GetComponent<FocusNavigationElement>();
			focusNavigation4.SetFocus(component4);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB6")]
		[Cpp2IlInjected.Address(RVA = "0xF1FF60", Offset = "0xF1E960", VA = "0x180F1FF60")]
		private void UpdateItemView()
		{
			//Discarded unreachable code: IL_0053, IL_0059, IL_006b
			int num = 0;
			IEnumerator enumerator = _items.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				RectTransform viewport = _viewport;
				DreamlightItem dreamlightItem = default(DreamlightItem);
				if ((object)dreamlightItem.transform != null)
				{
				}
				dreamlightItem.IsVisible = flag;
				dreamlightItem.RefreshDisplay();
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB7")]
		[Cpp2IlInjected.Address(RVA = "0xF1CA80", Offset = "0xF1B480", VA = "0x180F1CA80")]
		internal DreamlightItem GetAnyVisibleItem()
		{
			//Discarded unreachable code: IL_0045, IL_004b, IL_005d
			int num = 0;
			IEnumerator enumerator = _items.GetEnumerator();
			DreamlightItem dreamlightItem = default(DreamlightItem);
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				while (!dreamlightItem.IsVisible)
				{
				}
				num++;
			}
			num++;
			if ((object)dreamlightItem != null)
			{
			}
			if (num != 0)
			{
				return dreamlightItem;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB8")]
		[Cpp2IlInjected.Address(RVA = "0xF1E930", Offset = "0xF1D330", VA = "0x180F1E930")]
		private void RefreshRedDot(Item achievementItem, bool generated = false)
		{
			DreamlightTabButton[] tabs = _tabs;
			Action<DreamlightTabButton> _003C_003E9__43_ = _003C_003Ec._003C_003E9__43_0;
			if (_003C_003E9__43_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(DreamlightTabButton x)
				{
					//Discarded unreachable code: IL_0018
					x.RedDot.CheckState(refresh: true);
					x.RedDot.AddToRealTimeUpdate();
				};
			}
			MoreLinq.ForEach<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Action<>)(object)_003C_003E9__43_);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BB9")]
		[Cpp2IlInjected.Address(RVA = "0xF1EA60", Offset = "0xF1D460", VA = "0x180F1EA60")]
		private void RefreshRedDot(int slotId, bool generated = false)
		{
			DreamlightTabButton[] tabs = _tabs;
			Action<DreamlightTabButton> _003C_003E9__44_ = _003C_003Ec._003C_003E9__44_0;
			if (_003C_003E9__44_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(DreamlightTabButton x)
				{
					//Discarded unreachable code: IL_0018
					x.RedDot.CheckState(refresh: true);
					x.RedDot.AddToRealTimeUpdate();
				};
			}
			MoreLinq.ForEach<DreamlightTabButton>((IEnumerable<>)(object)tabs, (Action<>)(object)_003C_003E9__44_);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BBA")]
		[Cpp2IlInjected.Address(RVA = "0xF1CE80", Offset = "0xF1B880", VA = "0x180F1CE80")]
		private void OnCurrencyChanged(Item currencyItem, int gained, [Optional] AddDetail detail)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001BBB")]
		[Cpp2IlInjected.Address(RVA = "0xF1CE30", Offset = "0xF1B830", VA = "0x180F1CE30", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0025
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int focus = 0;
				SetFocus((byte)focus != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BBC")]
		[Cpp2IlInjected.Address(RVA = "0xF1DF80", Offset = "0xF1C980", VA = "0x180F1DF80")]
		public unsafe void OnScroll(Vector2 delta)
		{
			//Discarded unreachable code: IL_0043
			//IL_0015: Expected O, but got I4
			//IL_003b: Expected F4, but got I4
			//IL_0036: Expected native int or pointer, but got O
			RectTransform items = _items;
			int num = 0;
			if (!(Vector2.Distance(items.anchoredPosition, (Vector2)num) <= 1f))
			{
				Vector2 vector = (_oldPosition = _items.anchoredPosition);
				((Vector2*)(IntPtr)_oldPosition)->y = 0f;
				UpdateItemView();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BBD")]
		[Cpp2IlInjected.Address(RVA = "0xF1CCB0", Offset = "0xF1B6B0", VA = "0x180F1CCB0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0071
			//IL_0067: Expected O, but got I4
			//IL_006f: Expected I4, but got I8
			if (redirectionType > RedirectionType.MainMenuGoToMap)
			{
				if ((long)typeof(FocusNavigationDreamlightItemElement).TypeHandle > 1 && redirectionType == RedirectionType.GamePopCurrentMenu)
				{
					PopSelf();
				}
				return;
			}
			while (redirectionType == RedirectionType.MenuAchievementToggle)
			{
			}
			while ((long)typeof(FocusNavigationDreamlightItemElement).TypeHandle > 6)
			{
			}
			ISupportsFocusNavigation focusedElement = base.MenuNavigation.FocusNavigation._focusedElement;
			while (focusedElement == null)
			{
			}
			int num = 0;
			while (focusedElement == null)
			{
			}
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			int num2 = 0;
			focusNavigation.SetFocus((FocusNavigationElement)num2);
			ulong num3 = default(ulong);
			SetFocus((byte)num3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BBE")]
		[Cpp2IlInjected.Address(RVA = "0xF201E0", Offset = "0xF1EBE0", VA = "0x180F201E0")]
		public unsafe DreamlightMenu()
		{
			//IL_001f: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			//IL_0041: Expected F4, but got I4
			//IL_003c: Expected native int or pointer, but got O
			int num = 0;
			FocusedItemIndex = -1;
			_switchFontMin = -1;
			_oldPosition = Vector2.zero;
			((Vector2*)(IntPtr)_oldPosition)->y = 0f;
			base._002Ector();
		}
	}
}
