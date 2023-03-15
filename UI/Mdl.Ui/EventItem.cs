using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Common;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000486")]
	public class EventItem : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000487")]
		public enum EventType
		{
			[Cpp2IlInjected.Token(Token = "0x4001733")]
			BattlePass,
			[Cpp2IlInjected.Token(Token = "0x4001734")]
			Micro,
			[Cpp2IlInjected.Token(Token = "0x4001735")]
			Seasonal
		}

		[Cpp2IlInjected.Token(Token = "0x2000488")]
		public delegate void ItemDisplayed(EventItem item, EventItemSubCategory.SubCategoryType type);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001717")]
		[SerializeField]
		internal EventType type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001718")]
		[SerializeField]
		private BaseButton _btnToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001719")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400171A")]
		[SerializeField]
		private Image _arrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400171B")]
		[SerializeField]
		private Image _arrowHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400171C")]
		[SerializeField]
		private Image _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400171D")]
		[SerializeField]
		private Transform _animatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400171E")]
		[SerializeField]
		private GameObject _pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400171F")]
		[SerializeField]
		private RectTransform _detailsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001720")]
		[SerializeField]
		private EventItemSubCategory _description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001721")]
		[SerializeField]
		private EventItemSubCategory _reward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001722")]
		[SerializeField]
		private EventItemSubCategory _duties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001723")]
		[SerializeField]
		private Image _hoverBGRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001724")]
		[SerializeField]
		private Image _hoverBGLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001725")]
		[SerializeField]
		public RedDot _dutiesRedDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001726")]
		[SerializeField]
		public RedDot _descriptionRedDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001727")]
		internal BattlePassSeasonData battlePassData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001728")]
		private Action _onClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001729")]
		private Action _onHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400172B")]
		private bool _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400172C")]
		private bool _isInit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBA")]
		[Cpp2IlInjected.Token(Token = "0x400172D")]
		private bool _isDetailsHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400172E")]
		private float _animatedContentOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400172F")]
		private bool _isCurrentlyViewed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4001730")]
		private bool _isNewestEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4001731")]
		private EventItemSubCategory.SubCategoryType _currentSelectedSub;

		[Cpp2IlInjected.Token(Token = "0x170004D6")]
		public bool IsNewestEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001D55")]
			[Cpp2IlInjected.Address(RVA = "0x13FC7C0", Offset = "0x13FB1C0", VA = "0x1813FC7C0")]
			get
			{
				return _isNewestEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000036")]
		public event ItemDisplayed OnItemDisplayed
		{
			[Cpp2IlInjected.Token(Token = "0x6001D53")]
			[Cpp2IlInjected.Address(RVA = "0x13FC720", Offset = "0x13FB120", VA = "0x1813FC720")]
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
			[Cpp2IlInjected.Token(Token = "0x6001D54")]
			[Cpp2IlInjected.Address(RVA = "0x13FC7D0", Offset = "0x13FB1D0", VA = "0x1813FC7D0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001D56")]
		[Cpp2IlInjected.Address(RVA = "0x13FC330", Offset = "0x13FAD30", VA = "0x1813FC330")]
		private void Start()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = OnClick;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D57")]
		[Cpp2IlInjected.Address(RVA = "0x13FBE00", Offset = "0x13FA800", VA = "0x1813FBE00")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = OnClick;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D58")]
		[Cpp2IlInjected.Address(RVA = "0x13FBEB0", Offset = "0x13FA8B0", VA = "0x1813FBEB0")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_001f
			//IL_001e: Expected F4, but got O
			if (!_isInit)
			{
				Transform animatedContent = _animatedContent;
				_isInit = true;
				Vector2 vector = default(Vector2);
				_animatedContentOX = (float)vector;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D59")]
		[Cpp2IlInjected.Address(RVA = "0x13FC4F0", Offset = "0x13FAEF0", VA = "0x1813FC4F0")]
		internal void UpdateDutiesRedDotState()
		{
			//Discarded unreachable code: IL_004a
			if ((long)battlePassData != 0)
			{
				GameObject gameObject = _dutiesRedDot.gameObject;
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				BattlePassSeasonData battlePassSeasonData = battlePassData;
				RedDotHelper redDotHelper = instance.RedDotHelper;
				string onlineId_ = battlePassSeasonData.onlineId_;
				bool active = redDotHelper.HasBattlePassDutiesToClaim(onlineId_);
				gameObject.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5A")]
		[Cpp2IlInjected.Address(RVA = "0x13FC3E0", Offset = "0x13FADE0", VA = "0x1813FC3E0")]
		internal void UpdateDescriptionRedDotState()
		{
			//Discarded unreachable code: IL_0074
			//IL_006e: Expected O, but got I4
			if ((long)battlePassData != 0)
			{
				GameObject gameObject = _descriptionRedDot.gameObject;
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				BattlePassSeasonData battlePassSeasonData = battlePassData;
				RedDotHelper redDotHelper = instance.RedDotHelper;
				string onlineId_ = battlePassSeasonData.onlineId_;
				bool active = redDotHelper.IsNewBattlePass(onlineId_);
				gameObject.SetActive(active);
				int num2 = 0;
				RedDotHelper redDotHelper2 = UiRoot.Instance.RedDotHelper;
				BattlePassSeasonData battlePassSeasonData2 = battlePassData;
				int num3 = 0;
				redDotHelper2.RemoveBattlePassIsNew(battlePassSeasonData2, (CancellationToken)num3).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5B")]
		[Cpp2IlInjected.Address(RVA = "0x13FC580", Offset = "0x13FAF80", VA = "0x1813FC580")]
		internal void UpdateRedDotState(EventItemSubCategory.SubCategoryType type)
		{
			//Discarded unreachable code: IL_00cd
			//IL_0072: Expected O, but got I4
			if (type == EventItemSubCategory.SubCategoryType.Description)
			{
				if ((long)battlePassData != 0)
				{
					GameObject gameObject = _descriptionRedDot.gameObject;
					int num = 0;
					UiRoot instance = UiRoot.Instance;
					BattlePassSeasonData battlePassSeasonData = battlePassData;
					RedDotHelper redDotHelper = instance.RedDotHelper;
					string onlineId_ = battlePassSeasonData.onlineId_;
					bool active = redDotHelper.IsNewBattlePass(onlineId_);
					gameObject.SetActive(active);
					int num2 = 0;
					RedDotHelper redDotHelper2 = UiRoot.Instance.RedDotHelper;
					BattlePassSeasonData battlePassSeasonData2 = battlePassData;
					int num3 = 0;
					redDotHelper2.RemoveBattlePassIsNew(battlePassSeasonData2, (CancellationToken)num3).FireAndForgetTask();
				}
			}
			else
			{
				while (type != EventItemSubCategory.SubCategoryType.Duties)
				{
				}
				while ((long)battlePassData == 0)
				{
				}
				GameObject gameObject2 = _dutiesRedDot.gameObject;
				int num4 = 0;
				UiRoot instance2 = UiRoot.Instance;
				BattlePassSeasonData battlePassSeasonData3 = battlePassData;
				RedDotHelper redDotHelper3 = instance2.RedDotHelper;
				string onlineId_2 = battlePassSeasonData3.onlineId_;
				bool active2 = redDotHelper3.HasBattlePassDutiesToClaim(onlineId_2);
				gameObject2.SetActive(active2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5C")]
		[Cpp2IlInjected.Address(RVA = "0x13FB6A0", Offset = "0x13FA0A0", VA = "0x1813FB6A0")]
		public void ChangeHoverColor(Color color)
		{
			//Discarded unreachable code: IL_000f
			Image hoverBGLeft = _hoverBGLeft;
			Image hoverBGRight = _hoverBGRight;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5D")]
		[Cpp2IlInjected.Address(RVA = "0x13FB710", Offset = "0x13FA110", VA = "0x1813FB710")]
		public void ChangeSelectedBg(AssetReferenceTexture assetRef)
		{
			//Discarded unreachable code: IL_0053
			AsyncImage backgroundSelected = _description._backgroundSelected;
			string assetGUID = assetRef.AssetGUID;
			backgroundSelected.SetSpriteKey(assetGUID);
			AsyncImage backgroundSelected2 = _reward._backgroundSelected;
			string assetGUID2 = assetRef.AssetGUID;
			backgroundSelected2.SetSpriteKey(assetGUID2);
			AsyncImage backgroundSelected3 = _duties._backgroundSelected;
			string assetGUID3 = assetRef.AssetGUID;
			backgroundSelected3.SetSpriteKey(assetGUID3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5E")]
		[Cpp2IlInjected.Address(RVA = "0x13FB890", Offset = "0x13FA290", VA = "0x1813FB890")]
		public EventItemSubCategory GetEventSub(EventItemSubCategory.SubCategoryType type)
		{
			if (type != 0)
			{
				if (type != 0)
				{
					if (type != EventItemSubCategory.SubCategoryType.Duties)
					{
						int num = 0;
					}
					return _reward;
				}
				return _duties;
			}
			return _description;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5F")]
		[Cpp2IlInjected.Address(RVA = "0x13FC230", Offset = "0x13FAC30", VA = "0x1813FC230")]
		public void SetFocus(FocusNavigation focusNav)
		{
			//Discarded unreachable code: IL_0027
			EventItemSubCategory.SubCategoryType currentSelectedSub = _currentSelectedSub;
			if (currentSelectedSub != 0)
			{
				switch (currentSelectedSub)
				{
				}
			}
			FocusNavigationElement component = _description.GetComponent<FocusNavigationElement>();
			focusNav.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D60")]
		[Cpp2IlInjected.Address(RVA = "0x13FBF30", Offset = "0x13FA930", VA = "0x1813FBF30")]
		internal void Refresh(BattlePassSeasonData battlePassSeasonData, EventType eventType, bool isNewest, [Optional] UnityAction onGamepadClicked)
		{
			//Discarded unreachable code: IL_00be
			//IL_00b2: Expected O, but got I4
			type = eventType;
			battlePassData = battlePassSeasonData;
			string title_ = battlePassSeasonData.title_;
			EventDisplayManager.SetupPlayfabString(_title, title_);
			EventItemSubCategory duties = _duties;
			_isNewestEvent = isNewest;
			duties.OnGamepadClicked.RemoveAllListeners();
			_reward.OnGamepadClicked.RemoveAllListeners();
			_description.OnGamepadClicked.RemoveAllListeners();
			UnityEvent onGamepadClicked2 = _duties.OnGamepadClicked;
			UnityEvent onGamepadClicked3 = _reward.OnGamepadClicked;
			UnityEvent onGamepadClicked4 = _description.OnGamepadClicked;
			int num = 0;
			UpdateRedDotState((EventItemSubCategory.SubCategoryType)num);
			RedDot dutiesRedDot = _dutiesRedDot;
			int num2 = 0;
			GameObject gameObject = dutiesRedDot.gameObject;
			int num3 = 0;
			bool active = UiRoot.Instance.RedDotHelper.HasBattlePassDutiesToClaim((string)num2);
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D61")]
		[Cpp2IlInjected.Address(RVA = "0x13FC210", Offset = "0x13FAC10", VA = "0x1813FC210")]
		public void SelectDetails(EventItemSubCategory sub)
		{
			//Discarded unreachable code: IL_000f
			EventItemSubCategory.SubCategoryType subCategoryType = sub._type;
			SelectDetailsBySubType(subCategoryType);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D62")]
		[Cpp2IlInjected.Address(RVA = "0x13FB8B0", Offset = "0x13FA2B0", VA = "0x1813FB8B0")]
		public bool IsFinished()
		{
			if (type != 0)
			{
				int num = 0;
			}
			DateTime dateTime = battlePassData.finishDate_.date_.ToDateTime();
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D63")]
		[Cpp2IlInjected.Address(RVA = "0x13FB9D0", Offset = "0x13FA3D0", VA = "0x1813FB9D0")]
		public bool IsStarted(bool checkScheduledEvents)
		{
			if (type != 0)
			{
				int num = 0;
			}
			BattlePassSeasonData battlePassSeasonData = default(BattlePassSeasonData);
			if (checkScheduledEvents)
			{
				battlePassSeasonData = battlePassData;
				if (battlePassSeasonData.EnableScheduledEvents)
				{
					return true;
				}
			}
			string minGameVersion_ = battlePassSeasonData.minGameVersion_;
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D64")]
		[Cpp2IlInjected.Address(RVA = "0x13FC130", Offset = "0x13FAB30", VA = "0x1813FC130")]
		internal void SelectDetailsBySubType(EventItemSubCategory.SubCategoryType type)
		{
			//Discarded unreachable code: IL_0060
			RectTransform detailsContainer = _detailsContainer;
			_isCurrentlyViewed = true;
			_currentSelectedSub = type;
			EventItemSubCategory[] componentsInChildren = detailsContainer.GetComponentsInChildren<EventItemSubCategory>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				EventItemSubCategory eventItemSubCategory = componentsInChildren[num];
				bool flag = (eventItemSubCategory._selected = type == eventItemSubCategory._type);
				eventItemSubCategory.RefreshDisplay();
				num++;
			}
			if (this.OnItemDisplayed == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D65")]
		[Cpp2IlInjected.Address(RVA = "0x13FB7F0", Offset = "0x13FA1F0", VA = "0x1813FB7F0")]
		internal void Deselect()
		{
			//Discarded unreachable code: IL_003f
			RectTransform detailsContainer = _detailsContainer;
			_isCurrentlyViewed = false;
			EventItemSubCategory[] componentsInChildren = detailsContainer.GetComponentsInChildren<EventItemSubCategory>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				EventItemSubCategory eventItemSubCategory = componentsInChildren[num];
				eventItemSubCategory._selected = false;
				eventItemSubCategory.RefreshDisplay();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D66")]
		[Cpp2IlInjected.Address(RVA = "0x13FBB30", Offset = "0x13FA530", VA = "0x1813FBB30")]
		public void OnClick()
		{
			//Discarded unreachable code: IL_0106
			RectTransform detailsContainer = _detailsContainer;
			bool flag = (_isDetailsHidden = !_isDetailsHidden);
			GameObject gameObject = detailsContainer.gameObject;
			bool active = !_isDetailsHidden;
			gameObject.SetActive(active);
			FocusNavigationElement component = _description.gameObject.GetComponent<FocusNavigationElement>();
			FocusNavigationElement component2 = _reward.gameObject.GetComponent<FocusNavigationElement>();
			FocusNavigationElement component3 = _duties.gameObject.GetComponent<FocusNavigationElement>();
			component.IgnoreThis = (component2.IgnoreThis = (component3.IgnoreThis = _isDetailsHidden));
			RectTransform rectTransform = _arrow.rectTransform;
			RectTransform rectTransform2 = _arrow.rectTransform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			RectTransform rectTransform3 = _arrowHighlight.rectTransform;
			RectTransform rectTransform4 = _arrow.rectTransform;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			_onClick?.Invoke();
			base.transform.parent.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D67")]
		[Cpp2IlInjected.Address(RVA = "0x13FC2C0", Offset = "0x13FACC0", VA = "0x1813FC2C0")]
		public void SetHighLightMode()
		{
			//Discarded unreachable code: IL_0030
			_arrowHighlight.gameObject.SetActive(value: true);
			_pointer.SetActive(value: true);
			_onHighlight?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D68")]
		[Cpp2IlInjected.Address(RVA = "0x13FC0E0", Offset = "0x13FAAE0", VA = "0x1813FC0E0")]
		public void RemoveHighLightMode()
		{
			//Discarded unreachable code: IL_0026
			GameObject gameObject = _arrowHighlight.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject pointer = _pointer;
			int active2 = 0;
			pointer.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D69")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventItem()
		{
		}
	}
}
