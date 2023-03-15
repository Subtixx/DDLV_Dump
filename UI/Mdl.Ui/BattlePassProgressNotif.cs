using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using DG.Tweening;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000551")]
	public class BattlePassProgressNotif : CustomButton
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000552")]
		public class BattlePassSeasonAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001CF8")]
			[SerializeField]
			[Proto("Definitions.BattlePassSeasonData, Meta.Definitions")]
			public string EventIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001CF9")]
			public AssetReferenceTexture NotificationBg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001CFA")]
			public AssetReferenceTexture IconBg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001CFB")]
			public AssetReferenceTexture Icon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001CFC")]
			public BattlePassUIGameColors GameColor;

			[Cpp2IlInjected.Token(Token = "0x60022B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public BattlePassSeasonAsset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001CD2")]
		[SerializeField]
		private RectTransform _body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001CD3")]
		[SerializeField]
		private CanvasGroup _shortcutIndicatorCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001CD4")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001CD5")]
		[SerializeField]
		private ImageHelper _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001CD6")]
		[SerializeField]
		private ImageHelper _notifBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001CD7")]
		[SerializeField]
		private ImageHelper[] _iconBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001CD8")]
		[SerializeField]
		private List<BattlePassSeasonAsset> _battlePassAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001CD9")]
		[SerializeField]
		private TextBase _taskLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001CDA")]
		[SerializeField]
		private TextBase _collectLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001CDB")]
		[SerializeField]
		private AK.Wwise.Event _sfxNotif;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001CDC")]
		[SerializeField]
		private GameObject _audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001CDD")]
		[SerializeField]
		private float _showDelay = 0.05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4001CDE")]
		[SerializeField]
		private float _antiSpamCooldownDelay = 150f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001CDF")]
		[SerializeField]
		private float _slideEffectTime = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4001CE0")]
		[SerializeField]
		private float _fadeTime = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001CE1")]
		[SerializeField]
		private float _waitTimeBeforeClosing = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4001CE2")]
		[SerializeField]
		private float _threshold1 = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001CE3")]
		[SerializeField]
		private float _threshold2 = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4001CE4")]
		[SerializeField]
		private float _threshold3 = 0.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001CE5")]
		private string _currentEvent = "";

		[Cpp2IlInjected.Token(Token = "0x4001CE6")]
		private const string _achievementKey = "Achievement";

		[Cpp2IlInjected.Token(Token = "0x4001CE7")]
		private const string _dutyKey = "Duty";

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001CE8")]
		private float _positionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001CE9")]
		private Queue<KeyValuePair<string, BattlePassTaskProgress>> _pendingNotifs = (Queue<KeyValuePair<string, BattlePassTaskProgress>>)(object)new Queue<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001CEA")]
		private List<KeyValuePair<string, BattlePassTaskProgress>> _pendingNotifsList = (List<KeyValuePair<string, BattlePassTaskProgress>>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001CEB")]
		private Coroutine _showDelayCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001CEC")]
		private Coroutine _cooldownCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001CED")]
		private Coroutine _hideCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001CEE")]
		private Coroutine _showCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001CEF")]
		private Coroutine _CountSecCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001CF0")]
		private Sequence _tweenSequence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001CF1")]
		private HashSet<string> _exposedNotifications = (HashSet<string>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001CF2")]
		private bool _isShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C9")]
		[Cpp2IlInjected.Token(Token = "0x4001CF3")]
		private bool _showWhenReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4001CF4")]
		private float _showRemainingTime = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4001CF5")]
		private float _secShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x4001CF6")]
		private float _totalShowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4001CF7")]
		private bool isInCutscene;

		[Cpp2IlInjected.Token(Token = "0x17000559")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6002299")]
			[Cpp2IlInjected.Address(RVA = "0xA61A70", Offset = "0xA60470", VA = "0x180A61A70")]
			get
			{
				return _isShown;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600229A")]
		[Cpp2IlInjected.Address(RVA = "0xA61400", Offset = "0xA5FE00", VA = "0x180A61400")]
		private void Start()
		{
			//Discarded unreachable code: IL_0108
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
					ProfileEventDispatcher.BattlePassTaskUpdate value2 = OnBattlePassTaskUpdate;
					_003CDispatcher_003Ek__BackingField.OnBattlePassTaskUpdate += value2;
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

		[Cpp2IlInjected.Token(Token = "0x600229B")]
		[Cpp2IlInjected.Address(RVA = "0xA60920", Offset = "0xA5F320", VA = "0x180A60920")]
		private void OnMenuChange(IMenu menu)
		{
			if (menu == null)
			{
				return;
			}
			int num = 0;
			if (menu != null && base.gameObject.activeInHierarchy)
			{
				List<KeyValuePair<string, BattlePassTaskProgress>> pendingNotifsList = _pendingNotifsList;
				if (IsNotifStillRelevant())
				{
					throw new NullReferenceException();
				}
				((List<T>)(object)_pendingNotifsList).Clear();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600229C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB60", Offset = "0xA5E560", VA = "0x180A5FB60")]
		private bool IsNotifStillRelevant()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600229D")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5EDF0", VA = "0x180A603F0")]
		protected void OnDestroy()
		{
			//Discarded unreachable code: IL_00d6
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
					ProfileEventDispatcher.BattlePassTaskUpdate value2 = OnBattlePassTaskUpdate;
					_003CDispatcher_003Ek__BackingField.OnBattlePassTaskUpdate -= value2;
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

		[Cpp2IlInjected.Token(Token = "0x600229E")]
		[Cpp2IlInjected.Address(RVA = "0xA606F0", Offset = "0xA5F0F0", VA = "0x180A606F0", Slot = "12")]
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
					List<KeyValuePair<string, BattlePassTaskProgress>> pendingNotifsList = _pendingNotifsList;
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

		[Cpp2IlInjected.Token(Token = "0x600229F")]
		[Cpp2IlInjected.Address(RVA = "0xA606A0", Offset = "0xA5F0A0", VA = "0x180A606A0", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x60022A0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDA0", Offset = "0xA5E7A0", VA = "0x180A5FDA0")]
		private void OnBattlePassTaskUpdate(string battlePassOnlineId, BattlePassTaskProgress taskProgress)
		{
			//Discarded unreachable code: IL_00f9
			//IL_00bf: Expected O, but got I4
			int num = 0;
			if ((int)SystemRoot.Instance.MetaClient.profile.player_.hudApparition_ <= 65536)
			{
				return;
			}
			int num2 = 0;
			if (!UiRoot.Instance.IsBattlePassUnlocked() || taskProgress == null || taskProgress.taskState_ != BattlePassTaskState.Completed)
			{
				return;
			}
			OnlineClient onlineClient = default(OnlineClient);
			List<BattlePassSeasonData> battlePasses = (List<BattlePassSeasonData>)(object)onlineClient.GetBattlePasses();
			Func<BattlePassSeasonData, bool> func = default(Func<BattlePassSeasonData, bool>);
			if (_003C_003Ec._003C_003E9__47_0 == null)
			{
				func = (Func<BattlePassSeasonData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(BattlePassSeasonData x)
				{
					//Discarded unreachable code: IL_0029
					DateTime dateTime = x.endDate_.date_.ToDateTime();
					DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
					return dateTime > serverTime;
				});
			}
			IEnumerable<BattlePassSeasonData> enumerable = (IEnumerable<BattlePassSeasonData>)Enumerable.Where<BattlePassSeasonData>((IEnumerable<>)battlePasses, (Func<, >)(object)func);
			Func<BattlePassSeasonData, bool> func2 = (Func<BattlePassSeasonData, bool>)(object)(Func<T, TResult>)delegate(BattlePassSeasonData x)
			{
				//Discarded unreachable code: IL_0014
				string b = battlePassOnlineId;
				return string.Equals(x.onlineId_, b);
			};
			BattlePassSeasonData battlePassSeasonData = Enumerable.FirstOrDefault<BattlePassSeasonData>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
			if (battlePassSeasonData != null)
			{
				string onlineId_ = battlePassSeasonData.onlineId_;
				((List<T>)(object)_pendingNotifsList).Add((T)num);
				if ((long)_showDelayCoroutine == 0)
				{
					int num3 = 0;
					HudMenu menu = UiRoot.Instance._menuStack.GetMenu<HudMenu>();
					IEnumerator routine = ShowDelay();
					Coroutine coroutine = (_showDelayCoroutine = StartCoroutine(routine));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022A1")]
		[Cpp2IlInjected.Address(RVA = "0xA61210", Offset = "0xA5FC10", VA = "0x180A61210")]
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
				_003CCountSecShown_003Ed__64 _003CCountSecShown_003Ed__ = new _003CCountSecShown_003Ed__64(_003C_003E1__state2);
				_003C_003E1__state2 = 0;
				_003CCountSecShown_003Ed__._003C_003E4__this = this;
				Coroutine coroutine2 = (_CountSecCoroutine = StartCoroutine(_003CCountSecShown_003Ed__));
			}
			else
			{
				_showWhenReady = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022A2")]
		[Cpp2IlInjected.Address(RVA = "0xA60A50", Offset = "0xA5F450", VA = "0x180A60A50")]
		private int SelectIndexToDisplay(out bool isAssetAvailable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022A3")]
		[Cpp2IlInjected.Address(RVA = "0xA611A0", Offset = "0xA5FBA0", VA = "0x180A611A0")]
		[IteratorStateMachine(typeof(_003CShowNotifCoroutine_003Ed__50))]
		private IEnumerator ShowNotifCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CShowNotifCoroutine_003Ed__50 _003CShowNotifCoroutine_003Ed__ = new _003CShowNotifCoroutine_003Ed__50(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowNotifCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA50", Offset = "0xA5E450", VA = "0x180A5FA50")]
		[IteratorStateMachine(typeof(_003CHideNotif_003Ed__51))]
		private IEnumerator HideNotif()
		{
			int _003C_003E1__state = default(int);
			_003CHideNotif_003Ed__51 _003CHideNotif_003Ed__ = new _003CHideNotif_003Ed__51(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CHideNotif_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD90", Offset = "0xA5E790", VA = "0x180A5FD90")]
		private void OnAnimComplete()
		{
			OnHidden(dequeueItem: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60022A6")]
		[Cpp2IlInjected.Address(RVA = "0xA607B0", Offset = "0xA5F1B0", VA = "0x180A607B0")]
		private void OnHidden(bool dequeueItem = false)
		{
			//Discarded unreachable code: IL_0073
			_currentEvent = "";
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

		[Cpp2IlInjected.Token(Token = "0x60022A7")]
		[Cpp2IlInjected.Address(RVA = "0xA601C0", Offset = "0xA5EBC0", VA = "0x180A601C0")]
		public void OnClickedHandler()
		{
			//Discarded unreachable code: IL_00b6
			//IL_00b0: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			int num = 0;
			if ((_isShown ? 1 : 0) != num)
			{
				EventsMenu.EventsMenuParam eventsMenuParam = new EventsMenu.EventsMenuParam();
				eventsMenuParam.ToDuties = true;
				string text = (eventsMenuParam.BattlePassLocalName = _currentEvent);
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
			int num2 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num3 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num4 = 0;
			IMenu bottom = menuStack.Bottom;
			int num5 = 0;
			int num6 = 0;
			CancellationToken ct = default(CancellationToken);
			redirection.RedirectTask(ct, RedirectionType.MenuEvents, (MenuParam)num, (PlayerTaskCollider)num, (ItemFilterData)num, (string)num, (Action)num, (byte)num != 0, (byte)num != 0, (byte)num != 0).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60022A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5F830", Offset = "0xA5E230", VA = "0x180A5F830")]
		private void AddNotifToPendingList(KeyValuePair<string, BattlePassTaskProgress> fullData)
		{
			//Discarded unreachable code: IL_003d
			List<KeyValuePair<string, BattlePassTaskProgress>> pendingNotifsList = _pendingNotifsList;
			if ((long)_showDelayCoroutine == 0)
			{
				int num = 0;
				HudMenu menu = UiRoot.Instance._menuStack.GetMenu<HudMenu>();
				IEnumerator routine = ShowDelay();
				Coroutine coroutine = (_showDelayCoroutine = StartCoroutine(routine));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022A9")]
		[Cpp2IlInjected.Address(RVA = "0xA61130", Offset = "0xA5FB30", VA = "0x180A61130")]
		[IteratorStateMachine(typeof(_003CShowDelay_003Ed__56))]
		private IEnumerator ShowDelay()
		{
			int _003C_003E1__state = default(int);
			_003CShowDelay_003Ed__56 _003CShowDelay_003Ed__ = new _003CShowDelay_003Ed__56(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022AA")]
		[Cpp2IlInjected.Address(RVA = "0xA60D90", Offset = "0xA5F790", VA = "0x180A60D90")]
		private void SetupNotifFromPendingList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F910", Offset = "0xA5E310", VA = "0x180A5F910")]
		[IteratorStateMachine(typeof(_003CAntiSpamCooldown_003Ed__58))]
		private IEnumerator AntiSpamCooldown()
		{
			int _003C_003E1__state = default(int);
			_003CAntiSpamCooldown_003Ed__58 _003CAntiSpamCooldown_003Ed__ = new _003CAntiSpamCooldown_003Ed__58(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAntiSpamCooldown_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5FAC0", Offset = "0xA5E4C0", VA = "0x180A5FAC0")]
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

		[Cpp2IlInjected.Token(Token = "0x60022AD")]
		[Cpp2IlInjected.Address(RVA = "0xA617F0", Offset = "0xA601F0", VA = "0x180A617F0")]
		private bool VerifyThreshold(bool completed, float progress, string id)
		{
			if (completed || progress >= 1f || progress >= _threshold3 || progress >= _threshold2 || !(progress >= _threshold1))
			{
			}
			string key = "achi_" + id + "_100";
			return IsNewThreshold(key);
		}

		[Cpp2IlInjected.Token(Token = "0x60022AE")]
		[Cpp2IlInjected.Address(RVA = "0xA617D0", Offset = "0xA601D0", VA = "0x180A617D0")]
		private bool VerifyBattlePassTaskThreshold(BattlePassTaskProgress taskProgress)
		{
			//Discarded unreachable code: IL_000a
			return taskProgress.taskState_ == BattlePassTaskState.Completed;
		}

		[Cpp2IlInjected.Token(Token = "0x60022AF")]
		[Cpp2IlInjected.Address(RVA = "0xA60C20", Offset = "0xA5F620", VA = "0x180A60C20")]
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

		[Cpp2IlInjected.Token(Token = "0x60022B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F980", Offset = "0xA5E380", VA = "0x180A5F980")]
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

		[Cpp2IlInjected.Token(Token = "0x60022B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9E0", Offset = "0xA5E3E0", VA = "0x180A5F9E0")]
		[IteratorStateMachine(typeof(_003CCountSecShown_003Ed__64))]
		private IEnumerator CountSecShown()
		{
			int _003C_003E1__state = default(int);
			_003CCountSecShown_003Ed__64 _003CCountSecShown_003Ed__ = new _003CCountSecShown_003Ed__64(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCountSecShown_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022B2")]
		[Cpp2IlInjected.Address(RVA = "0xA618E0", Offset = "0xA602E0", VA = "0x180A618E0")]
		public BattlePassProgressNotif()
		{
		}
	}
}
