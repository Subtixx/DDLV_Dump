using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Activities;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui.Photo
{
	[Cpp2IlInjected.Token(Token = "0x200094E")]
	public class PhotoMenuTab : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003701")]
		[SerializeField]
		private GameObject _tabPose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003702")]
		[SerializeField]
		private GameObject _tabEmoji;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003703")]
		[SerializeField]
		private GameObject _tabFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003704")]
		[SerializeField]
		private GameObject _tabFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003705")]
		[SerializeField]
		private MainMenuTabButton _poseTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003706")]
		[SerializeField]
		private MainMenuTabButton _emojiTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003707")]
		[SerializeField]
		private MainMenuTabButton _frameTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003708")]
		[SerializeField]
		private MainMenuTabButton _filterTabButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003709")]
		[SerializeField]
		private TabsContainer _poseTabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400370A")]
		[SerializeField]
		private TabsContainer _emojiTabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400370B")]
		[SerializeField]
		private TabsContainer _frameTabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400370C")]
		[SerializeField]
		private TabsContainer _filterTabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400370D")]
		private PhotoView _photoView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400370E")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400370F")]
		[SerializeField]
		private Sprite _noneIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003710")]
		public List<Sprite> listPoseSelfie;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003711")]
		public List<Sprite> listPoseStanding;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003712")]
		public List<Sprite> listEmoji;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003713")]
		public GameObject tabItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003714")]
		private TabsContainer _currentTabContainer;

		[Cpp2IlInjected.Token(Token = "0x6003A4D")]
		[Cpp2IlInjected.Address(RVA = "0x9C2940", Offset = "0x9C1340", VA = "0x1809C2940")]
		private void Start()
		{
			//Discarded unreachable code: IL_0179, IL_017f, IL_0185, IL_018b, IL_0191
			int num = 0;
			int num2 = 0;
			TabsContainer poseTabsContainer = _poseTabsContainer;
			TabsContainer.TabSelected value = ChangePose;
			poseTabsContainer.OnTabSelected += value;
			TabsContainer emojiTabsContainer = _emojiTabsContainer;
			TabsContainer.TabSelected value2 = ChangeEmoji;
			emojiTabsContainer.OnTabSelected += value2;
			TabsContainer frameTabsContainer = _frameTabsContainer;
			TabsContainer.TabSelected value3 = ChangeFrame;
			frameTabsContainer.OnTabSelected += value3;
			TabsContainer filterTabsContainer = _filterTabsContainer;
			TabsContainer.TabSelected value4 = ChangePhotoEffect;
			filterTabsContainer.OnTabSelected += value4;
			UnityEvent onClicked = _poseTabButton.OnClicked;
			UnityAction call = OnPosePressed;
			onClicked.AddListener(call);
			UnityEvent onClicked2 = _emojiTabButton.OnClicked;
			UnityAction call2 = OnEmojiPressed;
			onClicked2.AddListener(call2);
			UnityEvent onClicked3 = _frameTabButton.OnClicked;
			UnityAction call3 = OnFramePressed;
			onClicked3.AddListener(call3);
			UnityEvent onClicked4 = _filterTabButton.OnClicked;
			UnityAction call4 = OnFilterPressed;
			onClicked4.AddListener(call4);
			int num3 = 0;
			PhotoView photoView = (_photoView = UiRoot.Instance.GetComponentInChildren<PhotoView>());
			ResetTab();
			List<Sprite> list = (List<Sprite>)(object)new List<T>();
			List<PhotoEffectData> listPhotoEffect = _photoView.photoEffect.listPhotoEffect;
			bool flag = default(bool);
			if (flag)
			{
			}
			List<Sprite> list2 = (List<Sprite>)(object)new List<T>();
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num5 = 0;
				Tab tab = default(Tab);
				FocusNavigationElement componentInChildren = tab.GetComponentInChildren<FocusNavigationElement>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A4E")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E70", Offset = "0x9C0870", VA = "0x1809C1E70")]
		private void PopulateTab(TabsContainer tabsContainer, List<Sprite> icons, int selected = 0)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A4F")]
		[Cpp2IlInjected.Address(RVA = "0x9C1240", Offset = "0x9BFC40", VA = "0x1809C1240")]
		private void ChangePhotoEffect(int index)
		{
			//Discarded unreachable code: IL_003a
			_filterTabsContainer.GetTab(index)?.GetComponent<BaseButton>()?.PostWwiseEvent();
			PhotoView photoView = _photoView;
			int index2 = index - 1;
			int isClose = 0;
			photoView.ChangeVisualEffect(index2, (byte)isClose != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A50")]
		[Cpp2IlInjected.Address(RVA = "0x9C11B0", Offset = "0x9BFBB0", VA = "0x1809C11B0")]
		private void ChangeFrame(int index)
		{
			//Discarded unreachable code: IL_0035
			_frameTabsContainer.GetTab(index)?.GetComponent<BaseButton>()?.PostWwiseEvent();
			PhotoView photoView = _photoView;
			int index2 = index - 1;
			photoView.ChangeFrame(index2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A51")]
		[Cpp2IlInjected.Address(RVA = "0x9C1120", Offset = "0x9BFB20", VA = "0x1809C1120")]
		private void ChangeEmoji(int index)
		{
			//Discarded unreachable code: IL_002a
			_emojiTabsContainer.GetTab(index)?.GetComponent<BaseButton>()?.PostWwiseEvent();
			PhotoView photoView = _photoView;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A52")]
		[Cpp2IlInjected.Address(RVA = "0x9C12D0", Offset = "0x9BFCD0", VA = "0x1809C12D0")]
		private void ChangePose(int iconIndex)
		{
			//Discarded unreachable code: IL_0036
			_poseTabsContainer.GetTab(iconIndex)?.GetComponent<BaseButton>()?.PostWwiseEvent();
			PhotoView photoView = _photoView;
			int num = 0;
			if (photoView._mode == (PhotoModeType)num)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A53")]
		[Cpp2IlInjected.Address(RVA = "0x9C1380", Offset = "0x9BFD80", VA = "0x1809C1380")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0105
			TabsContainer poseTabsContainer = _poseTabsContainer;
			TabsContainer.TabSelected value = ChangePose;
			poseTabsContainer.OnTabSelected -= value;
			TabsContainer emojiTabsContainer = _emojiTabsContainer;
			TabsContainer.TabSelected value2 = ChangeEmoji;
			emojiTabsContainer.OnTabSelected -= value2;
			TabsContainer frameTabsContainer = _frameTabsContainer;
			TabsContainer.TabSelected value3 = ChangeFrame;
			frameTabsContainer.OnTabSelected -= value3;
			TabsContainer filterTabsContainer = _filterTabsContainer;
			TabsContainer.TabSelected value4 = ChangePhotoEffect;
			filterTabsContainer.OnTabSelected -= value4;
			UnityEvent onClicked = _poseTabButton.OnClicked;
			UnityAction call = OnPosePressed;
			onClicked.RemoveListener(call);
			UnityEvent onClicked2 = _emojiTabButton.OnClicked;
			UnityAction call2 = OnEmojiPressed;
			onClicked2.RemoveListener(call2);
			UnityEvent onClicked3 = _frameTabButton.OnClicked;
			UnityAction call3 = OnFramePressed;
			onClicked3.RemoveListener(call3);
			UnityEvent onClicked4 = _filterTabButton.OnClicked;
			UnityAction call4 = OnFilterPressed;
			onClicked4.RemoveListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A54")]
		[Cpp2IlInjected.Address(RVA = "0x9C2150", Offset = "0x9C0B50", VA = "0x1809C2150")]
		private void ResetTab()
		{
			//Discarded unreachable code: IL_01e5
			MainMenuTabButton poseTabButton = _poseTabButton;
			bool flag2 = (poseTabButton.IsSelected = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Pose);
			MainMenuTabButton emojiTabButton = _emojiTabButton;
			bool flag4 = (emojiTabButton.IsSelected = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Emoji);
			MainMenuTabButton frameTabButton = _frameTabButton;
			bool flag6 = (frameTabButton.IsSelected = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Frame);
			MainMenuTabButton filterTabButton = _filterTabButton;
			bool flag8 = (filterTabButton.IsSelected = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Filter);
			MainMenuTabButton poseTabButton2 = _poseTabButton;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
			PhotoMenu _003CInstance_003Ek__BackingField = PhotoMenu.Instance;
			int num2 = 0;
			bool flag10 = (poseTabButton2.IsHighlighted = _003CInstance_003Ek__BackingField._currentTab == (PhotoMenuTabs)num2);
			MainMenuTabButton emojiTabButton2 = _emojiTabButton;
			int num3 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
			{
			}
			bool flag12 = (emojiTabButton2.IsHighlighted = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Emoji);
			MainMenuTabButton frameTabButton2 = _frameTabButton;
			int num4 = 0;
			UiRoot instance3 = UiRoot.Instance;
			int useKeyboardAsController3 = 0;
			if (instance3.IsControllerConnected((byte)useKeyboardAsController3 != 0))
			{
			}
			bool flag14 = (frameTabButton2.IsHighlighted = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Frame);
			MainMenuTabButton filterTabButton2 = _filterTabButton;
			int num5 = 0;
			UiRoot instance4 = UiRoot.Instance;
			int useKeyboardAsController4 = 0;
			bool isHighlighted = default(bool);
			if (!instance4.IsControllerConnected((byte)useKeyboardAsController4 != 0))
			{
				isHighlighted = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Filter;
			}
			filterTabButton2.IsHighlighted = isHighlighted;
			GameObject tabPose = _tabPose;
			bool active = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Pose;
			tabPose.SetActive(active);
			GameObject tabEmoji = _tabEmoji;
			bool active2 = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Emoji;
			tabEmoji.SetActive(active2);
			GameObject tabFrame = _tabFrame;
			bool active3 = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Frame;
			tabFrame.SetActive(active3);
			GameObject tabFilter = _tabFilter;
			bool active4 = PhotoMenu.Instance._currentTab == PhotoMenuTabs.Filter;
			tabFilter.SetActive(active4);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A55")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D40", Offset = "0x9C0740", VA = "0x1809C1D40")]
		public void OnPosePressed()
		{
			//Discarded unreachable code: IL_004f
			//IL_000d: Expected I4, but got I8
			PhotoMenu.Instance._currentTab = PhotoMenuTabs.Pose;
			ResetTab();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				TabsContainer poseTabsContainer = _poseTabsContainer;
				int index = 0;
				FocusNavigationElement componentInChildren = poseTabsContainer.GetTab(index).GetComponentInChildren<FocusNavigationElement>();
				_focusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A56")]
		[Cpp2IlInjected.Address(RVA = "0x9C1660", Offset = "0x9C0060", VA = "0x1809C1660")]
		public void OnEmojiPressed()
		{
			//Discarded unreachable code: IL_004f
			//IL_000d: Expected I4, but got I8
			PhotoMenu.Instance._currentTab = PhotoMenuTabs.Emoji;
			ResetTab();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				TabsContainer emojiTabsContainer = _emojiTabsContainer;
				int index = 0;
				FocusNavigationElement componentInChildren = emojiTabsContainer.GetTab(index).GetComponentInChildren<FocusNavigationElement>();
				_focusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A57")]
		[Cpp2IlInjected.Address(RVA = "0x9C1AE0", Offset = "0x9C04E0", VA = "0x1809C1AE0")]
		public void OnFilterPressed()
		{
			//Discarded unreachable code: IL_004f
			//IL_000d: Expected I4, but got I8
			PhotoMenu.Instance._currentTab = PhotoMenuTabs.Filter;
			ResetTab();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				TabsContainer filterTabsContainer = _filterTabsContainer;
				int index = 0;
				FocusNavigationElement componentInChildren = filterTabsContainer.GetTab(index).GetComponentInChildren<FocusNavigationElement>();
				_focusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A58")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C10", Offset = "0x9C0610", VA = "0x1809C1C10")]
		public void OnFramePressed()
		{
			//Discarded unreachable code: IL_004f
			//IL_000d: Expected I4, but got I8
			PhotoMenu.Instance._currentTab = PhotoMenuTabs.Frame;
			ResetTab();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				TabsContainer frameTabsContainer = _frameTabsContainer;
				int index = 0;
				FocusNavigationElement componentInChildren = frameTabsContainer.GetTab(index).GetComponentInChildren<FocusNavigationElement>();
				_focusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A59")]
		[Cpp2IlInjected.Address(RVA = "0x9C28E0", Offset = "0x9C12E0", VA = "0x1809C28E0")]
		internal void SetPoseSelfie(PhotoModePoseSelfie poseSelfie)
		{
			List<Sprite> list = listPoseSelfie;
			TabsContainer poseTabsContainer = _poseTabsContainer;
			this.PopulateTab(poseTabsContainer, (List<>)(object)list, (int)poseSelfie);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5A")]
		[Cpp2IlInjected.Address(RVA = "0x9C2910", Offset = "0x9C1310", VA = "0x1809C2910")]
		internal void SetPoseStanding(PhotoModePoseStanding poseStanding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1790", Offset = "0x9C0190", VA = "0x1809C1790")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0077
			//IL_000f: Expected O, but got I4
			PhotoMenu _003CInstance_003Ek__BackingField = PhotoMenu.Instance;
			int num = 0;
			if (!(_003CInstance_003Ek__BackingField == (Object)num))
			{
				if (PhotoMenu.Instance._currentTab == PhotoMenuTabs.Pose)
				{
					_poseTabButton.IsSelected = true;
				}
				if (PhotoMenu.Instance._currentTab == PhotoMenuTabs.Emoji)
				{
					_emojiTabButton.IsSelected = true;
				}
				if (PhotoMenu.Instance._currentTab == PhotoMenuTabs.Frame)
				{
					_frameTabButton.IsSelected = true;
				}
				if (PhotoMenu.Instance._currentTab == PhotoMenuTabs.Filter)
				{
					_filterTabButton.IsSelected = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3010", Offset = "0x9C1A10", VA = "0x1809C3010")]
		public void resetFocus()
		{
			//Discarded unreachable code: IL_009b
			if (_emojiTabsContainer.TabCount == 0 || _filterTabsContainer.TabCount == 0 || _frameTabsContainer.TabCount == 0 || _poseTabsContainer.TabCount == 0)
			{
				return;
			}
			TabsContainer poseTabsContainer = _poseTabsContainer;
			int index = 0;
			FocusNavigationElement componentInChildren = poseTabsContainer.GetTab(index).GetComponentInChildren<FocusNavigationElement>();
			FocusNavigationElement componentInChildren2 = default(FocusNavigationElement);
			if ((object)componentInChildren == null || (object)componentInChildren == null || (object)componentInChildren == null || (long)componentInChildren == 1)
			{
				if (_photoView._mode != PhotoModeType.Avatar)
				{
				}
				TabsContainer poseTabsContainer2 = _poseTabsContainer;
				int index2 = 0;
				componentInChildren2 = poseTabsContainer2.GetTab(index2).GetComponentInChildren<FocusNavigationElement>();
			}
			_focusNavigation.SetFocus(componentInChildren2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A5D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PhotoMenuTab()
		{
		}
	}
}
