using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Ui.Cache;
using Meta;
using Meta.Duties;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200054A")]
	public class AchievementProgressNotif : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001C97")]
		[SerializeField]
		private RectTransform _body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001C98")]
		[SerializeField]
		private HudCollectionReminder _collectionReminder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001C99")]
		[SerializeField]
		private BattlePassProgressNotif _battlePassProgressNotif;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001C9A")]
		[SerializeField]
		private CanvasGroup _shortcutIndicatorCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001C9B")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001C9C")]
		[SerializeField]
		private GameObject _progressStateRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001C9D")]
		[SerializeField]
		private GameObject _collectStateRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001C9E")]
		[SerializeField]
		private ImageHelper _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001C9F")]
		[SerializeField]
		private ImageHelper _iconCollected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001CA0")]
		[SerializeField]
		private TextBase _label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001CA1")]
		[SerializeField]
		private TMP_Text _progressText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001CA2")]
		[SerializeField]
		private Slider _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001CA3")]
		[SerializeField]
		private AK.Wwise.Event _sfxNotif;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001CA4")]
		[SerializeField]
		private GameObject _audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001CA5")]
		[SerializeField]
		private float _showDelay = 0.05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4001CA6")]
		[SerializeField]
		private float _antiSpamCooldownDelay = 150f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001CA7")]
		[SerializeField]
		private float _slideEffectTime = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4001CA8")]
		[SerializeField]
		private float _fadeTime = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001CA9")]
		[SerializeField]
		private float _waitTimeBeforeClosing = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4001CAA")]
		[SerializeField]
		private float _threshold1 = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001CAB")]
		[SerializeField]
		private float _threshold2 = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x4001CAC")]
		[SerializeField]
		private float _threshold3 = 0.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001CAD")]
		private AchievementType _currentPopup;

		[Cpp2IlInjected.Token(Token = "0x4001CAE")]
		private const string _achievementKey = "Achievement";

		[Cpp2IlInjected.Token(Token = "0x4001CAF")]
		private const string _dutyKey = "Duty";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x4001CB0")]
		private float _positionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001CB1")]
		private Queue<KeyValuePair<bool, KeyValuePair<string, object>>> _pendingNotifs = (Queue<KeyValuePair<bool, KeyValuePair<string, object>>>)(object)new Queue<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001CB2")]
		private List<KeyValuePair<bool, KeyValuePair<string, object>>> _pendingNotifsList = (List<KeyValuePair<bool, KeyValuePair<string, object>>>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001CB3")]
		private Coroutine _showDelayCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001CB4")]
		private Coroutine _cooldownCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001CB5")]
		private Coroutine _hideCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001CB6")]
		private Coroutine _showCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001CB7")]
		private Coroutine _CountSecCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001CB8")]
		private Sequence _tweenSequence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4001CB9")]
		private HashSet<string> _exposedNotifications = (HashSet<string>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4001CBA")]
		private bool _isShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D9")]
		[Cpp2IlInjected.Token(Token = "0x4001CBB")]
		private bool _showWhenReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x4001CBC")]
		private float _showRemainingTime = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4001CBD")]
		private float _secShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x4001CBE")]
		private float _totalShowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4001CBF")]
		private bool isInCutscene;

		[Cpp2IlInjected.Token(Token = "0x600225A")]
		[Cpp2IlInjected.Address(RVA = "0x87B170", Offset = "0x879B70", VA = "0x18087B170")]
		private void Start()
		{
			//Discarded unreachable code: IL_0130
			base.transform.parent.RebuildLayout();
			float num = (_totalShowTime = _slideEffectTime);
			Transform transform = base.transform;
			ImageHelper icon = _icon;
			AsyncAtlassedIcon asyncAtlassedIcon = (icon.AsyncAtlassedIcon = icon.GetComponent<AsyncAtlassedIcon>());
			int num2 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			MenuStack.CurrentMenuChanged value = OnMenuChange;
			menuStack.OnCurrentMenuChanged += value;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.AchievementSetUpdated value2 = OnAchievementUpdated;
					_003CDispatcher_003Ek__BackingField.OnAchievementSetUpdated += value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.DutySlotUpdated value3 = OnDutySlotUpdated;
					_003CDispatcher_003Ek__BackingField2.OnDutySlotUpdated += value3;
				}
			}
			int num3 = 0;
			UnityEvent cutSceneOnGoingEvent = UiRoot.Instance.CutSceneOnGoingEvent;
			UnityAction call = delegate
			{
				isInCutscene = true;
			};
			cutSceneOnGoingEvent.AddListener(call);
			int num4 = 0;
			UnityEvent cutSceneOverEvent = UiRoot.Instance.CutSceneOverEvent;
			UnityAction call2 = delegate
			{
				isInCutscene = false;
			};
			cutSceneOverEvent.AddListener(call2);
			int visibility = 0;
			SetVisibility((byte)visibility != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600225B")]
		[Cpp2IlInjected.Address(RVA = "0x879D50", Offset = "0x878750", VA = "0x180879D50")]
		private void OnMenuChange(IMenu menu)
		{
			if (menu == null)
			{
				return;
			}
			int num = 0;
			if (menu != null && base.gameObject.activeInHierarchy)
			{
				List<KeyValuePair<bool, KeyValuePair<string, object>>> pendingNotifsList = _pendingNotifsList;
				if (IsNotifStillRelevant())
				{
					throw new NullReferenceException();
				}
				((List<T>)(object)_pendingNotifsList).Clear();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600225C")]
		[Cpp2IlInjected.Address(RVA = "0x8786F0", Offset = "0x8770F0", VA = "0x1808786F0")]
		private bool IsNotifStillRelevant()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600225D")]
		[Cpp2IlInjected.Address(RVA = "0x879370", Offset = "0x877D70", VA = "0x180879370")]
		protected void OnDestroy()
		{
			//Discarded unreachable code: IL_00fe
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			MenuStack.CurrentMenuChanged value = OnMenuChange;
			menuStack.OnCurrentMenuChanged -= value;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.AchievementSetUpdated value2 = OnAchievementUpdated;
					_003CDispatcher_003Ek__BackingField.OnAchievementSetUpdated -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.DutySlotUpdated value3 = OnDutySlotUpdated;
					_003CDispatcher_003Ek__BackingField2.OnDutySlotUpdated -= value3;
				}
			}
			Coroutine showDelayCoroutine = _showDelayCoroutine;
			if (showDelayCoroutine != null)
			{
				StopCoroutine(showDelayCoroutine);
			}
			Coroutine showCoroutine = _showCoroutine;
			if (showCoroutine != null)
			{
				StopCoroutine(showCoroutine);
			}
			Coroutine hideCoroutine = _hideCoroutine;
			if (hideCoroutine != null)
			{
				StopCoroutine(hideCoroutine);
			}
			Coroutine cooldownCoroutine = _cooldownCoroutine;
			if (cooldownCoroutine != null)
			{
				StopCoroutine(cooldownCoroutine);
			}
			Coroutine countSecCoroutine = _CountSecCoroutine;
			if (countSecCoroutine != null)
			{
				StopCoroutine(countSecCoroutine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600225E")]
		[Cpp2IlInjected.Address(RVA = "0x879B40", Offset = "0x878540", VA = "0x180879B40", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_0058
			//IL_0024: Invalid comparison between F4 and I4
			base.OnEnable();
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			if (!_showWhenReady)
			{
				float showRemainingTime = _showRemainingTime;
				int num2 = 0;
				if (!(showRemainingTime > (float)num2))
				{
					List<KeyValuePair<bool, KeyValuePair<string, object>>> pendingNotifsList = _pendingNotifsList;
					if (!IsNotifStillRelevant())
					{
						return;
					}
					IEnumerator routine = ShowDelay();
					Coroutine coroutine = (_showDelayCoroutine = StartCoroutine(routine));
				}
			}
			ShowNotif();
		}

		[Cpp2IlInjected.Token(Token = "0x600225F")]
		[Cpp2IlInjected.Address(RVA = "0x8796E0", Offset = "0x8780E0", VA = "0x1808796E0", Slot = "13")]
		protected override void OnDisable()
		{
			base.OnDisable();
			int num = 0;
			if (Application.isPlaying)
			{
				int dequeueItem = 0;
				OnHidden((byte)dequeueItem != 0);
				Sequence tweenSequence = _tweenSequence;
				if (tweenSequence != null)
				{
					int complete = 0;
					tweenSequence.Kill((byte)complete != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002260")]
		[Cpp2IlInjected.Address(RVA = "0x878A00", Offset = "0x877400", VA = "0x180878A00")]
		private void OnAchievementUpdated(Item achItem, bool milestonePassed)
		{
			//Discarded unreachable code: IL_00ec
			//IL_001c: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00c4: Expected F4, but got I4
			//IL_00eb: Expected O, but got I4
			int itemID = achItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Item achItem2 = (Item)itemID;
			if ((int)SystemRoot.Instance.MetaClient.profile.player_.hudApparition_ <= 65536)
			{
				return;
			}
			RepeatedField<AchievementData> achievementsData_ = SystemRoot.Instance.MetaClient.profile.player_.achievementsData_;
			Func<AchievementData, bool> func = (Func<AchievementData, bool>)(object)(Func<T, TResult>)delegate(AchievementData x)
			{
				//Discarded unreachable code: IL_0011
				Item item = achItem2;
				return (IntPtr)x.achievementID_ == (IntPtr)item;
			};
			AchievementData achievementData = Enumerable.FirstOrDefault<AchievementData>((IEnumerable<>)(object)achievementsData_, (Func<, >)(object)func);
			if (achievementData == null)
			{
				return;
			}
			int curAmountDisplay = achievementData.CurAmountDisplay;
			int currentMilestoneDisplay = achievementData.CurrentMilestoneDisplay;
			int achievementID_ = achievementData.achievementID_;
			AchievementState state_ = achievementData.state_;
			string id = $"{currentMilestoneDisplay}_{currentMilestoneDisplay}";
			bool completed = state_ == AchievementState.Completed;
			int num4 = 0;
			if (VerifyThreshold(completed, currentMilestoneDisplay, id))
			{
				if (achievementData.state_ == (AchievementState)num4)
				{
					int curAmount_ = achievementData.curAmount_;
					int currentMilestone = achievementData.CurrentMilestone;
				}
				this.AddNotifToPendingList((KeyValuePair<, >)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002261")]
		[Cpp2IlInjected.Address(RVA = "0x879730", Offset = "0x878130", VA = "0x180879730")]
		private void OnDutySlotUpdated(int slotID, bool generated)
		{
			//Discarded unreachable code: IL_00c5
			//IL_0099: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_00ae: Expected F4, but got I4
			//IL_00c4: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if ((int)SystemRoot.Instance.MetaClient.profile.player_.hudApparition_ > 32768 && (int)SystemRoot.Instance.MetaClient.profile.player_.hudApparition_ > 65536)
			{
				Client client = default(Client);
				DutySlot dutySlot = (DutySlot)((RepeatedField<T>)(object)client.profile.player_.GetRoyalDutiesList().slots_)[slotID];
				DutyStepData stepData_ = dutySlot.stepData_;
				DutySlotState state_ = dutySlot.state_;
				int targetAmount_ = stepData_.targetAmount_;
				int dutyId_ = dutySlot.dutyId_;
				string id = $"{slotID}_{dutyId_}";
				bool completed = state_ == DutySlotState.Completed;
				if (VerifyThreshold(completed, dutyId_, id))
				{
					bool flag = dutySlot.state_ == DutySlotState.Completed;
					this.AddNotifToPendingList((KeyValuePair<, >)num3);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002262")]
		[Cpp2IlInjected.Address(RVA = "0x87AF80", Offset = "0x879980", VA = "0x18087AF80")]
		private void ShowNotif()
		{
			//Discarded unreachable code: IL_00be
			//IL_0033: Expected O, but got I4
			if (_isShown)
			{
				return;
			}
			if (base.isActiveAndEnabled)
			{
				AK.Wwise.Event sfxNotif = _sfxNotif;
				if (sfxNotif != null)
				{
					GameObject audioEmitter = _audioEmitter;
					int num = 0;
					if (audioEmitter != (UnityEngine.Object)num)
					{
					}
					GameObject gameObject = base.gameObject;
					uint num2 = sfxNotif.Post(gameObject);
				}
				SetVisibility(value: true);
				Coroutine showCoroutine = _showCoroutine;
				_isShown = true;
				if (showCoroutine != null)
				{
					StopCoroutine(showCoroutine);
				}
				int _003C_003E1__state = default(int);
				_003CShowNotifCoroutine_003Ed__50 _003CShowNotifCoroutine_003Ed__ = new _003CShowNotifCoroutine_003Ed__50(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CShowNotifCoroutine_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_showCoroutine = StartCoroutine(_003CShowNotifCoroutine_003Ed__));
				int _003C_003E1__state2 = default(int);
				_003CCountSecShown_003Ed__68 _003CCountSecShown_003Ed__ = new _003CCountSecShown_003Ed__68(_003C_003E1__state2);
				_003C_003E1__state2 = 0;
				_003CCountSecShown_003Ed__._003C_003E4__this = this;
				Coroutine coroutine2 = (_CountSecCoroutine = StartCoroutine(_003CCountSecShown_003Ed__));
			}
			else
			{
				_showWhenReady = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002263")]
		[Cpp2IlInjected.Address(RVA = "0x87AF10", Offset = "0x879910", VA = "0x18087AF10")]
		[IteratorStateMachine(typeof(_003CShowNotifCoroutine_003Ed__50))]
		private IEnumerator ShowNotifCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CShowNotifCoroutine_003Ed__50 _003CShowNotifCoroutine_003Ed__ = new _003CShowNotifCoroutine_003Ed__50(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowNotifCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002264")]
		[Cpp2IlInjected.Address(RVA = "0x8785E0", Offset = "0x876FE0", VA = "0x1808785E0")]
		[IteratorStateMachine(typeof(_003CHideNotif_003Ed__51))]
		private IEnumerator HideNotif()
		{
			int _003C_003E1__state = default(int);
			_003CHideNotif_003Ed__51 _003CHideNotif_003Ed__ = new _003CHideNotif_003Ed__51(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CHideNotif_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002265")]
		[Cpp2IlInjected.Address(RVA = "0x878E10", Offset = "0x877810", VA = "0x180878E10")]
		private void OnAnimComplete()
		{
			OnHidden(dequeueItem: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002266")]
		[Cpp2IlInjected.Address(RVA = "0x879C00", Offset = "0x878600", VA = "0x180879C00")]
		private void OnHidden(bool dequeueItem = false)
		{
			//Discarded unreachable code: IL_0071
			//IL_0009: Expected I4, but got I8
			_currentPopup = AchievementType.None;
			if (!dequeueItem)
			{
				float secShown = _secShown;
			}
			((Queue<T>)(object)_pendingNotifs).Clear();
			Coroutine countSecCoroutine = _CountSecCoroutine;
			if (countSecCoroutine != null)
			{
				StopCoroutine(countSecCoroutine);
			}
			Transform transform = base.transform;
			float positionX = _positionX;
			Transform transform2 = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			int visibility = 0;
			SetVisibility((byte)visibility != 0);
			_isShown = false;
			_showRemainingTime = -1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002267")]
		[Cpp2IlInjected.Address(RVA = "0x878E20", Offset = "0x877820", VA = "0x180878E20")]
		public void OnClickedHandler()
		{
			//IL_00b7: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			int num2 = 0;
			if ((_isShown ? 1 : 0) != num2)
			{
				DreamlightMenuParam dreamlightMenuParam = new DreamlightMenuParam();
				AchievementType achievementType = (dreamlightMenuParam.AchievementType = _currentPopup);
				Coroutine showDelayCoroutine = _showDelayCoroutine;
				if (showDelayCoroutine != null)
				{
					StopCoroutine(showDelayCoroutine);
				}
				Coroutine showCoroutine = _showCoroutine;
				if (showCoroutine != null)
				{
					StopCoroutine(showCoroutine);
				}
				Coroutine hideCoroutine = _hideCoroutine;
				if (hideCoroutine != null)
				{
					StopCoroutine(hideCoroutine);
				}
				OnHidden(dequeueItem: true);
			}
			int num3 = 0;
			WorldUI worldCanvas = UiRoot.Instance._worldCanvas;
			Type typeFromHandle = typeof(ItemSelector);
			InfoGizmo gizmoByType = worldCanvas.GetGizmoByType(typeFromHandle);
			if ((object)gizmoByType == null)
			{
			}
			int num4 = 0;
			int num5 = 0;
			if (!(gizmoByType == (UnityEngine.Object)num5))
			{
				return;
			}
			if (flag)
			{
				BattlePassProgressNotif battlePassProgressNotif = _battlePassProgressNotif;
				if ((battlePassProgressNotif._isShown ? 1 : 0) != num2)
				{
					battlePassProgressNotif.OnClicked?.Invoke();
					return;
				}
			}
			HudCollectionReminder collectionReminder = _collectionReminder;
			CollectionMenu.CollectionMenuParam collectionMenuParam = new CollectionMenu.CollectionMenuParam();
			CollectionSubMenu collectionSubMenu = (collectionMenuParam.SelectedTab = _collectionReminder.CollectionReminderSelectedTab);
			int num6 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num7 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num8 = 0;
			IMenu bottom = menuStack.Bottom;
			int num9 = 0;
			int num10 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			_collectionReminder.Hide();
			int num11 = 0;
			RedirectionManager redirection2 = UiRoot.Instance.Redirection;
			int num12 = 0;
			MenuStack menuStack2 = UiRoot.Instance._menuStack;
			int num13 = 0;
			IMenu bottom2 = menuStack2.Bottom;
			int num14 = 0;
			int num15 = 0;
			Task asyncTask2 = default(Task);
			asyncTask2.FireAndForgetTask();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002268")]
		[Cpp2IlInjected.Address(RVA = "0x87A190", Offset = "0x878B90", VA = "0x18087A190")]
		private void SetupAchievementForDisplay(AchievementData achievement)
		{
			//Discarded unreachable code: IL_01c2
			//IL_008a: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00cf: Expected F4, but got I4
			//IL_00dc: Expected F4, but got I4
			//IL_00e9: Expected F4, but got I4
			//IL_0146: Expected O, but got I4
			//IL_014e: Expected O, but got I4
			//IL_0156: Expected O, but got I4
			int num = 0;
			if (achievement.state_ <= AchievementState.Completed)
			{
				int curAmountDisplay = achievement.CurAmountDisplay;
				int currentMilestoneDisplay = achievement.CurrentMilestoneDisplay;
				if (curAmountDisplay == 0)
				{
					return;
				}
				GameObject progressStateRoot = _progressStateRoot;
				if (curAmountDisplay != currentMilestoneDisplay)
				{
					progressStateRoot.SetActive(value: true);
					GameObject collectStateRoot = _collectStateRoot;
					int active = 0;
					collectStateRoot.SetActive((byte)active != 0);
					AsyncAtlassedIcon asyncAtlassedIcon = _icon.AsyncAtlassedIcon;
					string iconAddress_ = achievement.ItemData.iconAddress_;
					asyncAtlassedIcon.Release();
					if (iconAddress_ != null)
					{
						asyncAtlassedIcon.Key = iconAddress_;
						asyncAtlassedIcon.Acquire();
					}
					asyncAtlassedIcon._currentData = (AtlassedIcon)num;
					asyncAtlassedIcon.Key = (string)num;
					asyncAtlassedIcon.AssetReference = (AssetReferenceTexture)num;
					TMP_Text progressText = _progressText;
					string text = default(string);
					string text2 = default(string);
					string text4 = (progressText.text = text + "/" + text2);
					Slider slider = _slider;
					int num2 = 0;
					slider.minValue = num2;
					_slider.maxValue = num2;
					_slider.value = num2;
					TextBase label = _label;
				}
				int active2 = 0;
				progressStateRoot.SetActive((byte)active2 != 0);
				_collectStateRoot.SetActive(value: true);
				AsyncAtlassedIcon asyncAtlassedIcon2 = _iconCollected.AsyncAtlassedIcon;
				string iconAddress_2 = achievement.ItemData.iconAddress_;
				asyncAtlassedIcon2.Release();
				if (iconAddress_2 != null)
				{
					asyncAtlassedIcon2.Key = iconAddress_2;
					asyncAtlassedIcon2.Acquire();
				}
				asyncAtlassedIcon2._currentData = (AtlassedIcon)num;
				asyncAtlassedIcon2.Key = (string)num;
				asyncAtlassedIcon2.AssetReference = (AssetReferenceTexture)num;
				_label.ColorKey = UIGameColors.GameColorName.AchievementNotifCompleted;
			}
			TextBase label2 = _label;
			string title_ = achievement.ItemData.title_;
			string text6 = (label2.StringID = achievement.ResolveString(title_));
			AchievementType achievementType = (_currentPopup = achievement.ItemData.type_);
			ShowNotif();
			IEnumerator routine = AntiSpamCooldown();
			Coroutine coroutine = (_cooldownCoroutine = StartCoroutine(routine));
		}

		[Cpp2IlInjected.Token(Token = "0x6002269")]
		[Cpp2IlInjected.Address(RVA = "0x87A530", Offset = "0x878F30", VA = "0x18087A530")]
		private void SetupDutyForDisplay(DutySlot duty)
		{
			//Discarded unreachable code: IL_01d9
			//IL_007d: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_0108: Expected O, but got I4
			//IL_0110: Expected O, but got I4
			//IL_0118: Expected O, but got I4
			//IL_014d: Expected F4, but got I4
			//IL_015a: Expected F4, but got I4
			//IL_0167: Expected F4, but got I4
			//IL_0182: Expected I4, but got I8
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int dutyId_ = duty.dutyId_;
			DutySlotState state_ = duty.state_;
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			if (state_ != DutySlotState.OnGoing)
			{
				if (state_ != DutySlotState.Completed)
				{
					goto IL_0174;
				}
				GameObject progressStateRoot = _progressStateRoot;
				int active = 0;
				progressStateRoot.SetActive((byte)active != 0);
				_collectStateRoot.SetActive(value: true);
				AsyncAtlassedIcon asyncAtlassedIcon = _iconCollected.AsyncAtlassedIcon;
				string iconAddress_ = royalDutyItemData.iconAddress_;
				asyncAtlassedIcon.Release();
				if (iconAddress_ != null)
				{
					asyncAtlassedIcon.Key = iconAddress_;
					asyncAtlassedIcon.Acquire();
				}
				asyncAtlassedIcon._currentData = (AtlassedIcon)num;
				asyncAtlassedIcon.Key = (string)num;
				asyncAtlassedIcon.AssetReference = (AssetReferenceTexture)num;
				TextBase label = _label;
			}
			DutyStepData stepData_ = duty.stepData_;
			int curAmount_ = stepData_.curAmount_;
			int targetAmount_ = stepData_.targetAmount_;
			_progressStateRoot.SetActive(value: true);
			GameObject collectStateRoot = _collectStateRoot;
			int active2 = 0;
			collectStateRoot.SetActive((byte)active2 != 0);
			AsyncAtlassedIcon asyncAtlassedIcon2 = _icon.AsyncAtlassedIcon;
			string iconAddress_2 = royalDutyItemData.iconAddress_;
			asyncAtlassedIcon2.Release();
			if (iconAddress_2 != null)
			{
				asyncAtlassedIcon2.Key = iconAddress_2;
				asyncAtlassedIcon2.Acquire();
			}
			asyncAtlassedIcon2._currentData = (AtlassedIcon)num;
			asyncAtlassedIcon2.Key = (string)num;
			asyncAtlassedIcon2.AssetReference = (AssetReferenceTexture)num;
			TMP_Text progressText = _progressText;
			string text = default(string);
			string text2 = default(string);
			string text4 = (progressText.text = text + "/" + text2);
			Slider slider = _slider;
			int num2 = 0;
			slider.minValue = num2;
			_slider.maxValue = num2;
			_slider.value = num2;
			_label.ColorKey = UIGameColors.GameColorName.OffWhite;
			goto IL_0174;
			IL_0174:
			_label._parseCustomXml = TextBase.CustomXmlOption.ParseOff;
			TextBase label2 = _label;
			string description_ = royalDutyItemData.description_;
			string text6 = (label2.StringID = duty.ResolveString(description_));
			_currentPopup = (AchievementType)num;
			ShowNotif();
			int _003C_003E1__state = default(int);
			_003CAntiSpamCooldown_003Ed__61 _003CAntiSpamCooldown_003Ed__ = new _003CAntiSpamCooldown_003Ed__61(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAntiSpamCooldown_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_cooldownCoroutine = StartCoroutine(_003CAntiSpamCooldown_003Ed__));
		}

		[Cpp2IlInjected.Token(Token = "0x600226A")]
		[Cpp2IlInjected.Address(RVA = "0x8783B0", Offset = "0x876DB0", VA = "0x1808783B0")]
		private void AddNotifToPendingList(KeyValuePair<bool, KeyValuePair<string, object>> fullData)
		{
			//Discarded unreachable code: IL_003d
			List<KeyValuePair<bool, KeyValuePair<string, object>>> pendingNotifsList = _pendingNotifsList;
			if ((long)_showDelayCoroutine == 0)
			{
				int num = 0;
				HudMenu menu = UiRoot.Instance._menuStack.GetMenu<HudMenu>();
				IEnumerator routine = ShowDelay();
				Coroutine coroutine = (_showDelayCoroutine = StartCoroutine(routine));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600226B")]
		[Cpp2IlInjected.Address(RVA = "0x87AEA0", Offset = "0x8798A0", VA = "0x18087AEA0")]
		[IteratorStateMachine(typeof(_003CShowDelay_003Ed__58))]
		private IEnumerator ShowDelay()
		{
			int _003C_003E1__state = default(int);
			_003CShowDelay_003Ed__58 _003CShowDelay_003Ed__ = new _003CShowDelay_003Ed__58(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600226C")]
		[Cpp2IlInjected.Address(RVA = "0x879E80", Offset = "0x878880", VA = "0x180879E80")]
		private int SelectIndexToDisplay(out bool isReadyToBeClaimed)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600226D")]
		[Cpp2IlInjected.Address(RVA = "0x87A9E0", Offset = "0x8793E0", VA = "0x18087A9E0")]
		private void SetupNotifFromPendingList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600226E")]
		[Cpp2IlInjected.Address(RVA = "0x8784A0", Offset = "0x876EA0", VA = "0x1808784A0")]
		[IteratorStateMachine(typeof(_003CAntiSpamCooldown_003Ed__61))]
		private IEnumerator AntiSpamCooldown()
		{
			int _003C_003E1__state = default(int);
			_003CAntiSpamCooldown_003Ed__61 _003CAntiSpamCooldown_003Ed__ = new _003CAntiSpamCooldown_003Ed__61(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAntiSpamCooldown_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600226F")]
		[Cpp2IlInjected.Address(RVA = "0x878650", Offset = "0x877050", VA = "0x180878650")]
		private bool IsNewThreshold(string key)
		{
			//Discarded unreachable code: IL_0020
			if (((HashSet<T>)(object)_exposedNotifications).Contains((T)key))
			{
				int num = 0;
			}
			bool flag = ((HashSet<T>)(object)_exposedNotifications).Add((T)key);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002270")]
		[Cpp2IlInjected.Address(RVA = "0x87B800", Offset = "0x87A200", VA = "0x18087B800")]
		private bool VerifyThreshold(bool completed, float progress, string id)
		{
			if (completed || progress >= 1f || progress >= _threshold3 || progress >= _threshold2 || !(progress >= _threshold1))
			{
			}
			string key = "achi_" + id + "_100";
			return IsNewThreshold(key);
		}

		[Cpp2IlInjected.Token(Token = "0x6002271")]
		[Cpp2IlInjected.Address(RVA = "0x87B600", Offset = "0x87A000", VA = "0x18087B600")]
		private bool VerifyAchievementThreshold(AchievementData achievement)
		{
			//Discarded unreachable code: IL_003c
			//IL_0028: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_003b: Expected F4, but got I4
			int curAmountDisplay = achievement.CurAmountDisplay;
			int currentMilestoneDisplay = achievement.CurrentMilestoneDisplay;
			int achievementID_ = achievement.achievementID_;
			AchievementState state_ = achievement.state_;
			string id = $"{currentMilestoneDisplay}_{currentMilestoneDisplay}";
			bool completed = state_ == AchievementState.Completed;
			return VerifyThreshold(completed, currentMilestoneDisplay, id);
		}

		[Cpp2IlInjected.Token(Token = "0x6002272")]
		[Cpp2IlInjected.Address(RVA = "0x87B700", Offset = "0x87A100", VA = "0x18087B700")]
		private bool VerifyDutyThreshold(DutySlot duty)
		{
			//Discarded unreachable code: IL_003c
			//IL_0028: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_003b: Expected F4, but got I4
			DutyStepData stepData_ = duty.stepData_;
			DutySlotState state_ = duty.state_;
			int targetAmount_ = stepData_.targetAmount_;
			int dutyId_ = duty.dutyId_;
			string id = $"{dutyId_}_{dutyId_}";
			bool completed = state_ == DutySlotState.Completed;
			return VerifyThreshold(completed, dutyId_, id);
		}

		[Cpp2IlInjected.Token(Token = "0x6002273")]
		[Cpp2IlInjected.Address(RVA = "0x87A020", Offset = "0x878A20", VA = "0x18087A020")]
		private void SetVisibility(bool value)
		{
			//Discarded unreachable code: IL_0056
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			if (!value || (object)transform != null)
			{
			}
			_body.gameObject.SetActive(value);
			CanvasGroup shortcutIndicatorCanvasGroup = _shortcutIndicatorCanvasGroup;
			if (value)
			{
			}
			shortcutIndicatorCanvasGroup.alpha = 1f;
			base.transform.parent.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6002274")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876F10", VA = "0x180878510")]
		private void ClearAllCoroutine()
		{
			Coroutine showDelayCoroutine = _showDelayCoroutine;
			if (showDelayCoroutine != null)
			{
				StopCoroutine(showDelayCoroutine);
			}
			Coroutine showCoroutine = _showCoroutine;
			if (showCoroutine != null)
			{
				StopCoroutine(showCoroutine);
			}
			Coroutine hideCoroutine = _hideCoroutine;
			if (hideCoroutine != null)
			{
				StopCoroutine(hideCoroutine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002275")]
		[Cpp2IlInjected.Address(RVA = "0x878570", Offset = "0x876F70", VA = "0x180878570")]
		[IteratorStateMachine(typeof(_003CCountSecShown_003Ed__68))]
		private IEnumerator CountSecShown()
		{
			int _003C_003E1__state = default(int);
			_003CCountSecShown_003Ed__68 _003CCountSecShown_003Ed__ = new _003CCountSecShown_003Ed__68(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCountSecShown_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002276")]
		[Cpp2IlInjected.Address(RVA = "0x87B8F0", Offset = "0x87A2F0", VA = "0x18087B8F0")]
		public AchievementProgressNotif()
		{
		}
	}
}
