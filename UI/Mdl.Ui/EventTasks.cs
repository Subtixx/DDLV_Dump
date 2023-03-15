using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000494")]
	public class EventTasks : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40017A7")]
		private List<BattlePassTaskProgress> _battlePassTaskDisplayed = (List<BattlePassTaskProgress>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40017A9")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40017AA")]
		[SerializeField]
		private RectTransform _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40017AB")]
		[SerializeField]
		private RectTransform _viewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40017AC")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40017AD")]
		[SerializeField]
		private RectTransform _premiumLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40017AE")]
		[SerializeField]
		private RectTransform _finishedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40017AF")]
		[SerializeField]
		private TextBase _finishedDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40017B0")]
		[SerializeField]
		private TextBase _finishedTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40017B1")]
		[SerializeField]
		private RecycleBin _recycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40017B2")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40017B3")]
		[SerializeField]
		private RectTransform _completed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40017B4")]
		[SerializeField]
		private EventDisplayManager _eventDisplayManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40017B5")]
		[SerializeField]
		private int _maxTaskToDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40017B6")]
		private int _columnNum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40017B7")]
		private int interval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40017B8")]
		private float nextTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40017B9")]
		private BattlePassSeasonData _battlePassData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40017BA")]
		private bool isInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40017BB")]
		private bool isAllTaskFinished;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40017BC")]
		private Vector2 _oldPosition;

		[Cpp2IlInjected.Token(Token = "0x170004DD")]
		internal List<DreamlightItemModel> DreamlightItemModels
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CDreamlightItemModels_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DC2")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CDreamlightItemModels_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40017A8")]
		public AchievementType AchievementType
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC3")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001DC4")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004DF")]
		private int MaxActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC5")]
			[Cpp2IlInjected.Address(RVA = "0x140D750", Offset = "0x140C150", VA = "0x18140D750")]
			get
			{
				//Discarded unreachable code: IL_0025
				EventDisplayManager eventDisplayManager = _eventDisplayManager;
				BattlePassSeasonData battlePassData = _battlePassData;
				if (eventDisplayManager.isPremiumUnlocked)
				{
					return battlePassData.premiumActiveTaskCount_;
				}
				return battlePassData.freeActiveTaskCount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E0")]
		public bool IsAllTaskFinished
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC6")]
			[Cpp2IlInjected.Address(RVA = "0x7DAE20", Offset = "0x7D9820", VA = "0x1807DAE20")]
			get
			{
				return isAllTaskFinished;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC7")]
		[Cpp2IlInjected.Address(RVA = "0x140BEF0", Offset = "0x140A8F0", VA = "0x18140BEF0")]
		public void Refresh(BattlePassSeasonData battlePassData)
		{
			//Discarded unreachable code: IL_0066
			//IL_0033: Expected O, but got I4
			BattlePassSeasonData battlePassData2 = _battlePassData;
			bool flag = battlePassData.Equals(battlePassData2);
			if (!flag)
			{
				isInitialized = flag;
			}
			if (!isInitialized)
			{
				EventDisplayManager eventDisplayManager = _eventDisplayManager;
				int num = 0;
				if (eventDisplayManager == (UnityEngine.Object)num)
				{
					EventDisplayManager eventDisplayManager2 = (_eventDisplayManager = GetComponentInParent<EventDisplayManager>());
				}
				_battlePassData = battlePassData;
				isInitialized = true;
			}
			RefreshData();
			int fromMove = 0;
			RefreshDisplay((byte)fromMove != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC8")]
		[Cpp2IlInjected.Address(RVA = "0x140B450", Offset = "0x1409E50", VA = "0x18140B450")]
		internal unsafe void RefreshData()
		{
			//Discarded unreachable code: IL_00a9
			//IL_0090: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (!Application.isPlaying || _eventDisplayManager._currentEvent.IsFinished())
			{
				return;
			}
			List<BattlePassTaskItemModel> list = (List<BattlePassTaskItemModel>)(object)new List<T>();
			((List<T>)(object)DreamlightItemModels)?.Clear();
			((List<T>)(object)_battlePassTaskDisplayed).Clear();
			List<DreamlightItemModel> list2 = (DreamlightItemModels = (List<DreamlightItemModel>)(object)new List<T>());
			EventDisplayManager eventDisplayManager = _eventDisplayManager;
			BattlePassSeasonData battlePassData = _battlePassData;
			if (eventDisplayManager.isPremiumUnlocked)
			{
			}
			int freeActiveTaskCount_ = battlePassData.freeActiveTaskCount_;
			if (num < freeActiveTaskCount_)
			{
				if (TryGetNewTaskData(num, out *(BattlePassTaskItemModel*)num))
				{
					((List<T>)(object)list).Add((T)num);
				}
				EventDisplayManager eventDisplayManager2 = _eventDisplayManager;
				num++;
			}
			((List<T>)(object)DreamlightItemModels).AddRange((IEnumerable<>)list);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC9")]
		[Cpp2IlInjected.Address(RVA = "0xE32A70", Offset = "0xE31470", VA = "0x180E32A70")]
		internal void Dispose()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCA")]
		[Cpp2IlInjected.Address(RVA = "0x140B650", Offset = "0x140A050", VA = "0x18140B650")]
		private void RefreshDisplay(bool fromMove = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCB")]
		[Cpp2IlInjected.Address(RVA = "0x140CB90", Offset = "0x140B590", VA = "0x18140CB90")]
		private void UpdateItemView()
		{
			//Discarded unreachable code: IL_020b, IL_0211, IL_0217, IL_021d, IL_0223, IL_0229, IL_022f, IL_0235, IL_023b, IL_0241, IL_0247, IL_024d, IL_0253, IL_0259, IL_025f, IL_0265, IL_026b, IL_0271, IL_0277, IL_027d, IL_0283, IL_0289, IL_028f, IL_0295, IL_029b, IL_02a1, IL_02a7, IL_02ad, IL_02b3, IL_02b9, IL_02bf, IL_02c5, IL_02cb, IL_02d1, IL_02d7, IL_02dd, IL_02e3, IL_02e9, IL_02ef, IL_02f5, IL_02fb, IL_0301, IL_0307, IL_030d, IL_0313, IL_0319, IL_031f, IL_0325, IL_032b, IL_0331, IL_0337, IL_033d, IL_034f
			//IL_0116: Expected O, but got I4
			//IL_013b: Expected O, but got I4
			//IL_018b: Expected O, but got I4
			//IL_01b0: Expected O, but got I4
			DreamlightItem dreamlightItem = default(DreamlightItem);
			bool _003CIsVisible_003Ek__BackingField = default(bool);
			bool flag = default(bool);
			ButtonViewDefault view2 = default(ButtonViewDefault);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = _items.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					RectTransform viewport = _viewport;
					if ((object)dreamlightItem.transform != null)
					{
					}
					dreamlightItem.IsVisible = _003CIsVisible_003Ek__BackingField;
					dreamlightItem.RefreshDisplay();
					TextMeshProUGUI textComponent = dreamlightItem.View.View.Label.TextComponent;
					BattlePassUIGameColors gameColors = _eventDisplayManager._gameColors;
					TextMeshProUGUI textComponent2 = dreamlightItem.View.Progress.TextComponent;
					DreamlightItemView _003CView_003Ek__BackingField = dreamlightItem.View;
					int num4 = 0;
					UIGameColors gameColors2 = UiRoot.Instance._gameColors;
					BattlePassUIGameColors gameColors3 = _eventDisplayManager._gameColors;
					DreamlightItemModel _003CModel_003Ek__BackingField = dreamlightItem.Model;
					if (_003CModel_003Ek__BackingField != null)
					{
						int num5 = 0;
						if (_003CModel_003Ek__BackingField != null && flag)
						{
							ImageHelper icon = dreamlightItem.View.Icon;
							BattlePassUIGameColors gameColors4 = _eventDisplayManager._gameColors;
						}
					}
					AsyncAtlassedIcon asyncAtlassedIcon = dreamlightItem.View.Icon.AsyncAtlassedIcon;
					BattlePassUIGameColors gameColors5 = _eventDisplayManager._gameColors;
					ButtonViewDefault view = dreamlightItem.View.View;
					int num6 = 0;
					if (!(view != (UnityEngine.Object)num6))
					{
						continue;
					}
					TextBase label = dreamlightItem.View.View.Label;
					int num7 = 0;
					if (label != (UnityEngine.Object)num7)
					{
						TextMeshProUGUI textComponent3 = dreamlightItem.View.View.Label.TextComponent;
						DreamlightItemView _003CView_003Ek__BackingField2 = dreamlightItem.View;
						BattlePassUIGameColors gameColors6 = _eventDisplayManager._gameColors;
					}
					ImageHelper background = dreamlightItem.View.View.Background;
					int num8 = 0;
					if (!(background != (UnityEngine.Object)num8))
					{
						continue;
					}
					ImageHelper staticIcon = dreamlightItem.View.View.StaticIcon;
					int num9 = 0;
					if (!(staticIcon != (UnityEngine.Object)num9))
					{
						continue;
					}
					DreamlightItemView _003CView_003Ek__BackingField3 = dreamlightItem.View;
					int num10 = 0;
					UIGameColors gameColors7 = UiRoot.Instance._gameColors;
					BattlePassUIGameColors gameColors8 = _eventDisplayManager._gameColors;
					ImageHelper background2 = dreamlightItem.View.View.Background;
					view2 = dreamlightItem.View.View;
					ImageHelper staticIcon2 = view2.StaticIcon;
				}
				if ((object)view2 == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCC")]
		[Cpp2IlInjected.Address(RVA = "0x140AD60", Offset = "0x1409760", VA = "0x18140AD60")]
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

		[Cpp2IlInjected.Token(Token = "0x6001DCD")]
		[Cpp2IlInjected.Address(RVA = "0x140AE00", Offset = "0x1409800", VA = "0x18140AE00")]
		public void OnViewHighlightAdded(DreamlightItemView view)
		{
			//Discarded unreachable code: IL_00cb
			//IL_0010: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			ButtonViewDefault view2 = view.View;
			int num = 0;
			if (view2 != (UnityEngine.Object)num)
			{
				TextBase label = view.View.Label;
				int num2 = 0;
				if (label != (UnityEngine.Object)num2)
				{
					TextMeshProUGUI textComponent = view.View.Label.TextComponent;
					BattlePassUIGameColors gameColors = _eventDisplayManager._gameColors;
				}
				ImageHelper background = view.View.Background;
				int num3 = 0;
				if (background != (UnityEngine.Object)num3)
				{
					ImageHelper staticIcon = view.View.StaticIcon;
					int num4 = 0;
					if (staticIcon != (UnityEngine.Object)num4)
					{
						int num5 = 0;
						UIGameColors gameColors2 = UiRoot.Instance._gameColors;
						ImageHelper background2 = view.View.Background;
						ImageHelper staticIcon2 = view.View.StaticIcon;
					}
				}
			}
			TextMeshProUGUI textComponent2 = view.Progress.TextComponent;
			int num6 = 0;
			UIGameColors gameColors3 = UiRoot.Instance._gameColors;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCE")]
		[Cpp2IlInjected.Address(RVA = "0x140B120", Offset = "0x1409B20", VA = "0x18140B120")]
		public void OnViewHighlightRemove(DreamlightItemView view)
		{
			//Discarded unreachable code: IL_00ca
			//IL_0010: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			ButtonViewDefault view2 = view.View;
			int num = 0;
			if (view2 != (UnityEngine.Object)num)
			{
				TextBase label = view.View.Label;
				int num2 = 0;
				if (label != (UnityEngine.Object)num2)
				{
					TextMeshProUGUI textComponent = view.View.Label.TextComponent;
					BattlePassUIGameColors gameColors = _eventDisplayManager._gameColors;
					int num3 = 0;
				}
				ImageHelper background = view.View.Background;
				int num4 = 0;
				if (background != (UnityEngine.Object)num4)
				{
					ImageHelper staticIcon = view.View.StaticIcon;
					int num5 = 0;
					if (staticIcon != (UnityEngine.Object)num5)
					{
						BattlePassUIGameColors gameColors2 = _eventDisplayManager._gameColors;
						ImageHelper background2 = view.View.Background;
						ImageHelper staticIcon2 = view.View.StaticIcon;
					}
				}
			}
			TextMeshProUGUI textComponent2 = view.Progress.TextComponent;
			BattlePassUIGameColors gameColors3 = _eventDisplayManager._gameColors;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCF")]
		[Cpp2IlInjected.Address(RVA = "0x140C020", Offset = "0x140AA20", VA = "0x18140C020")]
		public unsafe void Reorder()
		{
			//Discarded unreachable code: IL_0071, IL_0077, IL_007d, IL_0083, IL_0089, IL_008f, IL_0095
			//IL_0069: Expected O, but got I4
			int num = 0;
			List<DreamlightItemModel> list = DreamlightItemModels;
			if (list == null)
			{
				return;
			}
			IEnumerable<DreamlightItemModel> enumerable = (IEnumerable<DreamlightItemModel>)Enumerable.Reverse<DreamlightItemModel>((IEnumerable<>)list);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_002c;
					}
					num++;
				}
				while (enumerable == null)
				{
				}
				goto IL_002c;
			}
			goto IL_0069;
			IL_002c:
			int num3 = 0;
			while (enumerable == null)
			{
			}
			List<DreamlightItemModel> list2 = DreamlightItemModels;
			int index = default(int);
			bool flag = TryGetNewTaskData(index, out *(BattlePassTaskItemModel*)num);
			List<DreamlightItemModel> list3 = DreamlightItemModels;
			if (flag)
			{
				List<DreamlightItemModel> list4 = DreamlightItemModels;
				int index2 = default(int);
				((List<T>)(object)DreamlightItemModels).Insert(index2, (T)num);
			}
			goto IL_0069;
			IL_0069:
			if (enumerable != null)
			{
			}
			int num4 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD0")]
		[Cpp2IlInjected.Address(RVA = "0x140C300", Offset = "0x140AD00", VA = "0x18140C300")]
		public void SetFocus(FocusNavigation focusNav)
		{
			//Discarded unreachable code: IL_000f
			FocusNavigationElement componentInChildren = GetComponentInChildren<FocusNavigationElement>();
			focusNav.SetFocus(componentInChildren);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD1")]
		[Cpp2IlInjected.Address(RVA = "0x140C360", Offset = "0x140AD60", VA = "0x18140C360")]
		private unsafe bool TryGetNewTaskData(int index, out BattlePassTaskItemModel modelData)
		{
			//IL_0099: Expected O, but got I4
			int num = 0;
			BattlePassStatesData battlePassStates_ = SystemRoot.Instance.MetaClient.profile.player_.battlePassStates_;
			if (battlePassStates_ != null)
			{
				EventDisplayManager eventDisplayManager = _eventDisplayManager;
				BattlePassSeasonData battlePassData = _battlePassData;
				if (eventDisplayManager.isPremiumUnlocked)
				{
				}
				int freeActiveTaskCount_ = battlePassData.freeActiveTaskCount_;
				if (index < freeActiveTaskCount_)
				{
					string onlineId_ = battlePassData.onlineId_;
					if (freeActiveTaskCount_ == 0)
					{
						BattlePassSeasonData battlePassData2 = _battlePassData;
						MapField<string, BattlePassProgress> progress_ = battlePassStates_.progress_;
						string onlineId_2 = battlePassData2.onlineId_;
						if (((MapField<TKey, TValue>)(object)progress_).TryGetValue((TKey)onlineId_2, out *(TValue*)num))
						{
							Func<BattlePassTaskProgress, bool> func = (Func<BattlePassTaskProgress, bool>)(object)(Func<T, TResult>)delegate(BattlePassTaskProgress x)
							{
								if ((long)x == 0)
								{
									int num2 = 0;
								}
								List<BattlePassTaskProgress> battlePassTaskDisplayed = _battlePassTaskDisplayed;
								Func<BattlePassTaskProgress, bool> cpp2il__autoParamName__idx_ = (Func<BattlePassTaskProgress, bool>)(object)(Func<T, TResult>)delegate(BattlePassTaskProgress y)
								{
									//Discarded unreachable code: IL_0016
									int _003CIndex_003Ek__BackingField = x.Index;
									return y.Index == _003CIndex_003Ek__BackingField;
								};
								bool flag = ((IEnumerable<>)battlePassTaskDisplayed).Any<BattlePassTaskProgress>((Func<, >)(object)cpp2il__autoParamName__idx_);
								throw new NullReferenceException();
							};
							IEnumerable<BattlePassTaskProgress> enumerable = (IEnumerable<BattlePassTaskProgress>)Enumerable.Where<BattlePassTaskProgress>((IEnumerable<>)num, (Func<, >)(object)func);
							Func<BattlePassTaskProgress, bool> func2 = default(Func<BattlePassTaskProgress, bool>);
							if (_003C_003Ec._003C_003E9__43_1 == null)
							{
								func2 = (Func<BattlePassTaskProgress, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassTaskProgress x) => x.IsActive));
							}
							BattlePassTaskProgress battlePassTaskProgress = default(BattlePassTaskProgress);
							if (Enumerable.FirstOrDefault<BattlePassTaskProgress>((IEnumerable<>)enumerable, (Func<, >)(object)func2) == null)
							{
								Func<BattlePassTaskProgress, bool> func3 = default(Func<BattlePassTaskProgress, bool>);
								if (_003C_003Ec._003C_003E9__43_2 == null)
								{
									func3 = (Func<BattlePassTaskProgress, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassTaskProgress x) => x.IsNotStarted));
								}
								IEnumerable<BattlePassTaskProgress> enumerable2 = (IEnumerable<BattlePassTaskProgress>)Enumerable.Where<BattlePassTaskProgress>((IEnumerable<>)enumerable, (Func<, >)(object)func3);
								Func<BattlePassTaskProgress, int> func4 = default(Func<BattlePassTaskProgress, int>);
								if (_003C_003Ec._003C_003E9__43_3 == null)
								{
									func4 = (Func<BattlePassTaskProgress, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassTaskProgress x) => x.Data.availableOnDay_));
								}
								battlePassTaskProgress = Enumerable.FirstOrDefault<BattlePassTaskProgress>((IEnumerable<>)Enumerable.OrderBy<BattlePassTaskProgress, int>((IEnumerable<>)enumerable2, (Func<, >)(object)func4));
								if (battlePassTaskProgress == null)
								{
									goto IL_0190;
								}
							}
							((List<T>)(object)_battlePassTaskDisplayed).Add((T)battlePassTaskProgress);
							BattlePassTaskItemModel battlePassTaskItemModel = new BattlePassTaskItemModel();
							BattlePassSeasonData battlePassData3 = _eventDisplayManager._currentEvent.battlePassData;
							BattlePassTask _003CData_003Ek__BackingField = battlePassTaskProgress.Data;
							DateTime dateTime = battlePassData3.TaskStartTime(_003CData_003Ek__BackingField);
							EventDisplayManager eventDisplayManager2 = _eventDisplayManager;
							BattlePassTask _003CData_003Ek__BackingField2 = battlePassTaskProgress.Data;
							ObjectiveProgress objective_ = battlePassTaskProgress.objective_;
							bool isClaimed = battlePassTaskProgress.IsClaimed;
							BattlePassTask _003CData_003Ek__BackingField3 = battlePassTaskProgress.Data;
						}
					}
				}
			}
			goto IL_0190;
			IL_0190:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD2")]
		[Cpp2IlInjected.Address(RVA = "0x140D490", Offset = "0x140BE90", VA = "0x18140D490")]
		private void Update()
		{
			//Discarded unreachable code: IL_00bd
			//IL_0058: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			if (_eventDisplayManager._currentEvent.IsFinished() && _finishedContent.gameObject.activeInHierarchy)
			{
				int num = 0;
				float time = Time.time;
				_finishedDesc.Text = "";
				TextBase finishedDesc = _finishedDesc;
				int num2 = 0;
				string format = LocalizationManager.FromStringID("menu.starpath_event_ended_desc", (IResolver)num2);
				Client client = default(Client);
				DateTime serverTime = client.ServerTime;
				DateTime finished = _battlePassData.endDate_.date_.ToDateTime();
				string arg = EventDisplayManager.CalculateCountdown(serverTime, finished);
				string currencyName_ = _battlePassData.currencyName_;
				int num3 = 0;
				string arg2 = LocalizationManager.FromStringID(currencyName_, (IResolver)num3);
				string text2 = (finishedDesc.Text = string.Format(format, arg, arg2));
				nextTime = time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD3")]
		[Cpp2IlInjected.Address(RVA = "0x140D690", Offset = "0x140C090", VA = "0x18140D690")]
		public unsafe EventTasks()
		{
			//IL_0018: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002a: Expected I4, but got I8
			//IL_0043: Expected F4, but got I4
			//IL_003e: Expected native int or pointer, but got O
			int num = 0;
			_maxTaskToDisplay = 6;
			_columnNum = 3;
			interval = 1;
			_oldPosition = Vector2.zero;
			((Vector2*)(IntPtr)_oldPosition)->y = 0f;
			base._002Ector();
		}
	}
}
