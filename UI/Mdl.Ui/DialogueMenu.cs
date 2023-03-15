using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Google.Protobuf.Collections;
using Mdl.Characters;
using Mdl.Dialogues;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using NodeCanvas.DialogueTrees;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200041D")]
	[RequiredAllNotNull]
	public class DialogueMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200041E")]
		private class InternalCancellationToken
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40014EB")]
			private bool _isCancelled;

			[Cpp2IlInjected.Token(Token = "0x6001AD4")]
			[Cpp2IlInjected.Address(RVA = "0xA28AC0", Offset = "0xA274C0", VA = "0x180A28AC0")]
			public void Cancel()
			{
				_isCancelled = true;
			}

			[Cpp2IlInjected.Token(Token = "0x6001AD5")]
			[Cpp2IlInjected.Address(RVA = "0xA28AD0", Offset = "0xA274D0", VA = "0x180A28AD0")]
			public static bool IsCancelled(InternalCancellationToken ct)
			{
				if (ct != null)
				{
					return ct._isCancelled;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6001AD6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public InternalCancellationToken()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200041F")]
		public class DialogueMenuParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40014EC")]
			public DialogueInstance DialogueInstance;

			[Cpp2IlInjected.Token(Token = "0x6001AD7")]
			[Cpp2IlInjected.Address(RVA = "0xA284E0", Offset = "0xA26EE0", VA = "0x180A284E0")]
			public DialogueMenuParam(DialogueInstance dialogueInstance)
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
				DialogueInstance = dialogueInstance;
				/*Error: Unexpected end of block*/;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000420")]
		public class SubtitleDelays
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40014ED")]
			public float characterDelay = 0.05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40014EE")]
			public float sentenceDelay = 0.5f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40014EF")]
			public float commaDelay = 0.1f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40014F0")]
			public float finalDelay = 1.2f;

			[Cpp2IlInjected.Token(Token = "0x6001AD8")]
			[Cpp2IlInjected.Address(RVA = "0xA29150", Offset = "0xA27B50", VA = "0x180A29150")]
			public SubtitleDelays()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40014B5")]
		private DialogueInstance _dialogueInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40014B6")]
		private AudioSource _localSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40014B7")]
		private SubtitlesRequestInfo _currentSubtitleInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40014B8")]
		private CharacterFriendshipBar _characterFriendshipBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40014B9")]
		private bool _showAnimationDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40014BA")]
		private List<Item> _currencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40014BB")]
		private bool _didAccept;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40014BC")]
		private CurrencyCost _cost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40014BD")]
		private bool _selectLastOnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x40014BE")]
		private bool _dialogueEnded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40014BF")]
		private CharacterQuestMarker _questMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40014C0")]
		private Coroutine _highlightThenClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40014C2")]
		[SerializeField]
		private float _delayBetweenHighlightAndAutoClick = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40014C3")]
		[SerializeField]
		private RectTransform _trashBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40014C4")]
		[SerializeField]
		private CharacterFriendshipBar _characterFriendshipBarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40014C5")]
		[SerializeField]
		private ListBase _listCurrencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40014C6")]
		[SerializeField]
		private SlidingPanel _currenciesSlidingPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40014C7")]
		[SerializeField]
		private List<Transform> playerUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40014C8")]
		[SerializeField]
		private List<Transform> npcUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40014C9")]
		[Header("Input Options")]
		public bool skipOnInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x40014CA")]
		public bool waitForInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40014CB")]
		[SerializeField]
		private RectTransform _subtitleContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40014CC")]
		[SerializeField]
		private CanvasGroup _subtitleCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40014CD")]
		[SerializeField]
		private RectTransform _subtitlesRegularPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40014CE")]
		[SerializeField]
		private RectTransform _subtitlesWithOptionsPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40014CF")]
		[Header("Subtitles")]
		public RectTransform subtitlesGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40014D0")]
		public TextBase actorSpeech;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40014D1")]
		public TextBase actorName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40014D2")]
		public SubtitleDelays subtitleDelays = new SubtitleDelays();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40014D3")]
		[SerializeField]
		[Header("PlayerSubtitles")]
		private RectTransform playerDialogueGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40014D4")]
		[SerializeField]
		private RectTransform playerSpeechContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40014D5")]
		public TextBase instigatorSpeech;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40014D6")]
		public TextBase instigatorName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40014D7")]
		[Header("Multiple Choice")]
		public RectTransform optionsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40014D8")]
		public DialogueButton optionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40014D9")]
		private Dictionary<DialogueButton, int> cachedButtons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40014DA")]
		private bool isWaitingChoice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40014DB")]
		private ButtonTmPro _currentHighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40014DC")]
		private bool _sentenceBeingDisplayed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F1")]
		[Cpp2IlInjected.Token(Token = "0x40014DD")]
		private bool _forceOptionsHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40014DE")]
		[SerializeField]
		[Header("Arrow animation")]
		private Transform _arrowTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40014DF")]
		[SerializeField]
		private float _arrowDistanceY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40014E0")]
		[SerializeField]
		private float _arrowAnimDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40014E1")]
		[SerializeField]
		private AnimationCurve _arrowAnimationCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40014E2")]
		private Tween _arrowTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40014E3")]
		[SerializeField]
		private DialogBonusAnimation _animatePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40014E4")]
		[Header("Sound")]
		public AK.Wwise.Event _sfxSkipDlgEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40014E5")]
		public AK.Wwise.Event _sfxPurchaseItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40014E6")]
		public Switch _purchaseSuccededSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40014E7")]
		public AK.Wwise.Event _sfxNPCText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40014E8")]
		public AK.Wwise.Event _sfxMCText;

		[Cpp2IlInjected.Token(Token = "0x40014E9")]
		private const int SFX_TEXT_TRIGGER_COUNT = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40014EA")]
		[SerializeField]
		[Header("Cheat")]
		private TextBase _cheatLabel;

		[Cpp2IlInjected.Token(Token = "0x17000450")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x128"), Cpp2IlInjected.Token(Token = "0x40014C1")]
		public bool HasGiftGiven
		{
			[Cpp2IlInjected.Token(Token = "0x6001AA9")]
			[Cpp2IlInjected.Address(RVA = "0x897F00", Offset = "0x896900", VA = "0x180897F00")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001AAA")]
			[Cpp2IlInjected.Address(RVA = "0x8987B0", Offset = "0x8971B0", VA = "0x1808987B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000451")]
		private AudioSource localSource
		{
			[Cpp2IlInjected.Token(Token = "0x6001AAB")]
			[Cpp2IlInjected.Address(RVA = "0x12BE350", Offset = "0x12BCD50", VA = "0x1812BE350")]
			get
			{
				//Discarded unreachable code: IL_0019
				bool flag = default(bool);
				if (flag)
				{
				}
				return _localSource = base.gameObject.AddComponent<AudioSource>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAC")]
		[Cpp2IlInjected.Address(RVA = "0x12BC2B0", Offset = "0x12BACB0", VA = "0x1812BC2B0", Slot = "25")]
		public override void OnPush(MenuStack stack, MenuParam param)
		{
			//Discarded unreachable code: IL_00c7
			_forceOptionsHidden = false;
			base.OnPush(stack, param);
			int num = 0;
			UiRoot.Instance._worldCanvas.Hide();
			MenuNavigation menuNavigation = base.MenuNavigation;
			int num2 = 0;
			menuNavigation.UpdateCursor();
			if (param != null)
			{
				int num3 = 0;
				if (param != null)
				{
					int num4 = 0;
					int num5 = 0;
					_dialogueInstance = (DialogueInstance)(object)param;
				}
			}
			Tween arrowTween = _arrowTween;
			if (arrowTween != null)
			{
				int complete = 0;
				arrowTween.Kill((byte)complete != 0);
			}
			float arrowAnimDuration = _arrowAnimDuration;
			int num6 = 0;
			float arrowDistanceY = _arrowDistanceY;
			TweenerCore<Vector3, Vector3, VectorOptions> t = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(_arrowTransform, arrowDistanceY, arrowAnimDuration, (byte)num6 != 0);
			AnimationCurve arrowAnimationCurve = _arrowAnimationCurve;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(arrowAnimationCurve);
			TweenerCore<Vector3, Vector3, VectorOptions> arrowTween2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			_arrowTween = arrowTween2;
			Tween tween = _arrowTween.Pause();
			GameObject gameObject = _arrowTransform.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAD")]
		[Cpp2IlInjected.Address(RVA = "0x12BBE30", Offset = "0x12BA830", VA = "0x1812BBE30", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0049
			//IL_0048: Expected O, but got I8
			base.OnFocusOut(popAfterFocusOut, animate);
			Tween arrowTween = _arrowTween;
			int complete = 0;
			arrowTween.Kill((byte)complete != 0);
			if (popAfterFocusOut)
			{
				int num = 0;
				UiRoot.Instance._worldCanvas.Show();
			}
			Coroutine highlightThenClick = _highlightThenClick;
			if (highlightThenClick != null)
			{
				StopCoroutine(highlightThenClick);
				_highlightThenClick = (Coroutine)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAE")]
		[Cpp2IlInjected.Address(RVA = "0x12BB760", Offset = "0x12BA160", VA = "0x1812BB760", Slot = "27")]
		public override void OnFocusIn()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAF")]
		[Cpp2IlInjected.Address(RVA = "0x12BCC10", Offset = "0x12BB610", VA = "0x1812BCC10", Slot = "37")]
		public override void PopSelf()
		{
			//Discarded unreachable code: IL_007a
			//IL_0010: Expected O, but got I4
			CharacterQuestMarker questMarker = _questMarker;
			int num = 0;
			if (questMarker != (UnityEngine.Object)num)
			{
				_questMarker.gameObject.SetActive(value: true);
			}
			if (_stack.Top == null)
			{
				int num2 = 0;
			}
			int num3 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				Tween arrowTween = _arrowTween;
				int complete = 0;
				arrowTween.Kill((byte)complete != 0);
				int num4 = 0;
				UiRoot.Instance._worldCanvas.Show();
				MenuStack stack = _stack;
				stack.Kill(this);
			}
			else
			{
				MenuStack stack = default(MenuStack);
				stack.Pop();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB0")]
		[Cpp2IlInjected.Address(RVA = "0x12BCDB0", Offset = "0x12BB7B0", VA = "0x1812BCDB0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__66))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__66 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__66(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB1")]
		[Cpp2IlInjected.Address(RVA = "0x12BCE30", Offset = "0x12BB830", VA = "0x1812BCE30", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_00af
			((object)this)._002Ector();
			DialogueInstance dialogueInstance = _dialogueInstance;
			if (dialogueInstance != null)
			{
				AsyncEventHandler value = OnDialogueFinished;
				dialogueInstance.OnDialogueFinished += value;
				DialogueInstance dialogueInstance2 = _dialogueInstance;
				EventHandler<SubtitlesRequestInfo> eventHandler = (EventHandler<SubtitlesRequestInfo>)(object)new EventHandler<TEventArgs>(OnSubtitlesRequest);
				dialogueInstance2.add_OnSubtitleRequest((EventHandler<>)(object)eventHandler);
				DialogueInstance dialogueInstance3 = _dialogueInstance;
				EventHandler<MultipleChoiceRequestInfo> eventHandler2 = (EventHandler<MultipleChoiceRequestInfo>)(object)new EventHandler<TEventArgs>(OnMultipleChoiceRequest);
				dialogueInstance3.add_OnMultipleChoiceRequest((EventHandler<>)(object)eventHandler2);
			}
			int num = 0;
			UnityEvent<AddedFriendshipSummary> onFriendshipAdded = UiRoot.Instance.Dispatcher.OnFriendshipAdded;
			UnityAction<AddedFriendshipSummary> unityAction = (UnityAction<AddedFriendshipSummary>)(object)new UnityAction<T0>(OnFriendshipChanged);
			((UnityEvent<T0>)(object)onFriendshipAdded).AddListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemData = _listCurrencies.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB2")]
		[Cpp2IlInjected.Address(RVA = "0x12BE040", Offset = "0x12BCA40", VA = "0x1812BE040", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_009b
			base.UnregisterFocusedListeners();
			DialogueInstance dialogueInstance = _dialogueInstance;
			if (dialogueInstance != null)
			{
				AsyncEventHandler value = OnDialogueFinished;
				dialogueInstance.OnDialogueFinished -= value;
				DialogueInstance dialogueInstance2 = _dialogueInstance;
				EventHandler<SubtitlesRequestInfo> eventHandler = (EventHandler<SubtitlesRequestInfo>)(object)new EventHandler<TEventArgs>(OnSubtitlesRequest);
				dialogueInstance2.remove_OnSubtitleRequest((EventHandler<>)(object)eventHandler);
				DialogueInstance dialogueInstance3 = _dialogueInstance;
				EventHandler<MultipleChoiceRequestInfo> eventHandler2 = (EventHandler<MultipleChoiceRequestInfo>)(object)new EventHandler<TEventArgs>(OnMultipleChoiceRequest);
				dialogueInstance3.remove_OnMultipleChoiceRequest((EventHandler<>)(object)eventHandler2);
			}
			int num = 0;
			UnityEvent<AddedFriendshipSummary> onFriendshipAdded = UiRoot.Instance.Dispatcher.OnFriendshipAdded;
			UnityAction<AddedFriendshipSummary> unityAction = (UnityAction<AddedFriendshipSummary>)(object)new UnityAction<T0>(OnFriendshipChanged);
			((UnityEvent<T0>)(object)onFriendshipAdded).RemoveListener((UnityAction<>)(object)unityAction);
			_listCurrencies.m_OnItemData.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB3")]
		[Cpp2IlInjected.Address(RVA = "0x12BB600", Offset = "0x12BA000", VA = "0x1812BB600")]
		private Task OnDialogueFinished(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0059
			//IL_001d: Expected O, but got I4
			ClearOptionButtons();
			CharacterFriendshipBar characterFriendshipBar = _characterFriendshipBar;
			_dialogueEnded = true;
			int num = 0;
			if (characterFriendshipBar != (UnityEngine.Object)num && _characterFriendshipBar.gameObject.activeInHierarchy)
			{
				CharacterFriendshipBar characterFriendshipBar2 = _characterFriendshipBar;
				if (characterFriendshipBar2._animateFriendship)
				{
					Action onAnimationDone = default(Action);
					characterFriendshipBar2.OnAnimationDone = onAnimationDone;
				}
			}
			PopSelf();
			int num2 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB4")]
		[Cpp2IlInjected.Address(RVA = "0x12BC500", Offset = "0x12BAF00", VA = "0x1812BC500")]
		private void OnSubtitlesRequest(object sender, SubtitlesRequestInfo info)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB5")]
		[Cpp2IlInjected.Address(RVA = "0x12BBEC0", Offset = "0x12BA8C0", VA = "0x1812BBEC0")]
		private void OnFriendshipChanged(AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_00c4
			//IL_0044: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_00c3: Expected I4, but got I8
			ulong num3 = default(ulong);
			while (addedFriendshipSummary.FriendshipGained > 0 && addedFriendshipSummary.FriendshipSource <= FriendshipSource.Gift)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				Item _003CCharacterItem_003Ek__BackingField = addedFriendshipSummary.CharacterItem;
				Mdl.Characters.Character character = system.GetCharacter(_003CCharacterItem_003Ek__BackingField);
				CharacterFriendshipBar characterFriendshipBar = _characterFriendshipBar;
				int num = 0;
				if (characterFriendshipBar == (UnityEngine.Object)num)
				{
					CharacterFriendshipBar characterFriendshipBarPrefab = _characterFriendshipBarPrefab;
					Transform parent = base.transform;
					CharacterFriendshipBar characterFriendshipBar2 = (_characterFriendshipBar = UnityEngine.Object.Instantiate(characterFriendshipBarPrefab, parent));
				}
				CharacterFriendshipBar characterFriendshipBar3 = _characterFriendshipBar;
				GameObject headIcon = character.CharacterVisualNodes.HeadIcon;
				CancellationToken cancellationToken = base.CancellationToken;
				int num2 = 0;
				object[] array = new object[2];
				if (array != null)
				{
					array[0] = addedFriendshipSummary;
					if (array != null)
					{
						array[1] = character;
						characterFriendshipBar3.Init(headIcon, (byte)num3 != 0, (Nullable<>)num2, array);
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB6")]
		[Cpp2IlInjected.Address(RVA = "0x12BB320", Offset = "0x12B9D20", VA = "0x1812BB320")]
		private void OnCurrencyChanged(Item currencyItem, int gained)
		{
			//Discarded unreachable code: IL_004a
			ListBase listCurrencies = _listCurrencies;
			int num = 0;
			if (num < listCurrencies._totalCount)
			{
				FreemiumCurrencyItem component = listCurrencies.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>();
				if ((object)component.CurrencyItem == null)
				{
					ListBase listCurrencies2 = _listCurrencies;
					num++;
				}
				int amount = component._amount;
				amount = (component.AnimatedAmount = amount + gained);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB7")]
		[Cpp2IlInjected.Address(RVA = "0x12BD460", Offset = "0x12BBE60", VA = "0x1812BD460")]
		private void ShowSwitcherFriendship(bool show, bool selectLastOnCancel = false)
		{
			//Discarded unreachable code: IL_021d, IL_0223, IL_0229, IL_022f, IL_0235, IL_023b, IL_0241, IL_0247, IL_024d, IL_0253, IL_0259, IL_025f
			//IL_0043: Expected O, but got I4
			//IL_0131: Expected O, but got I4
			//IL_0131: Expected O, but got I4
			//IL_016d: Expected I4, but got I8
			//IL_0181: Expected O, but got I4
			//IL_01f1: Expected O, but got I4
			//IL_01f1: Expected I4, but got I8
			//IL_0206: Expected O, but got I4
			uint num7 = default(uint);
			uint num9 = default(uint);
			bool flag = default(bool);
			Client client = default(Client);
			bool flag2 = default(bool);
			ProfessionItemData professionItemData = default(ProfessionItemData);
			ProfessionItemData professionItemData2 = default(ProfessionItemData);
			int num11 = default(int);
			ProfessionStatFormulaItemData professionStatFormulaItemData = default(ProfessionStatFormulaItemData);
			ulong num13 = default(ulong);
			ulong num16 = default(ulong);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				_selectLastOnCancel = selectLastOnCancel;
				GameObject gameObject = _cheatLabel.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				if (show)
				{
					Mdl.Characters.Character character = GetCharacter();
					int num5 = 0;
					if (character == (UnityEngine.Object)num5)
					{
						return;
					}
					int num6 = 0;
					UiRoot instance = UiRoot.Instance;
					num7 += 20;
					num7 += num7;
					int num8 = 0;
					UiRoot instance2 = UiRoot.Instance;
					num9 += 20;
					num9 += num9;
					if ((object)instance2 != null)
					{
						Meta.Character metaCharacter = character.MetaCharacter;
						List<string> list = (List<string>)(object)new List<T>();
						if ((object)instance != null && metaCharacter.Profession != null)
						{
							RepeatedField<ProfessionItemData.Types.HangoutBuffData> hangoutBuffs_ = metaCharacter.Profession.hangoutBuffs_;
							if (flag)
							{
								int num10 = 0;
								RepeatedField<Meta.Character> characters_ = client.Profile.world_.characters_;
								if (flag2)
								{
									while (professionItemData == null)
									{
									}
									if (metaCharacter.Profession == null)
									{
										continue;
									}
									int iD = professionItemData2.ID;
									if (metaCharacter.Profession.ID == 0)
									{
										continue;
									}
									num10 += num11;
								}
								int professionLevel = metaCharacter.GetProfessionLevel();
								float num12 = professionStatFormulaItemData.CalculateBuffModifier(professionLevel, num10);
								string item = $"Buff {professionLevel}: {professionLevel}";
								((List<T>)(object)list).Add((T)item);
							}
						}
						TextBase cheatLabel = _cheatLabel;
						string text2 = (cheatLabel.Text = string.Join("\n", (IEnumerable<>)list));
						_cheatLabel.gameObject.SetActive((byte)num13 != 0);
					}
					CharacterFriendshipBar characterFriendshipBar = _characterFriendshipBar;
					int num14 = 0;
					if (characterFriendshipBar != (UnityEngine.Object)num14)
					{
						return;
					}
					CharacterFriendshipBar characterFriendshipBarPrefab = _characterFriendshipBarPrefab;
					Transform parent = base.transform;
					CharacterFriendshipBar characterFriendshipBar2 = (_characterFriendshipBar = UnityEngine.Object.Instantiate(characterFriendshipBarPrefab, parent));
					CharacterFriendshipBar characterFriendshipBar3 = _characterFriendshipBar;
					GameObject headIcon = character.CharacterVisualNodes.HeadIcon;
					CancellationToken cancellationToken = base.CancellationToken;
					int num15 = 0;
					object[] array = new object[2];
					if (array != null)
					{
						array[1] = character;
						characterFriendshipBar3.Init(headIcon, (byte)num16 != 0, (Nullable<>)num15, array);
						return;
					}
				}
				else
				{
					CharacterFriendshipBar characterFriendshipBar4 = _characterFriendshipBar;
					int num17 = 0;
					if (characterFriendshipBar4 != (UnityEngine.Object)num17)
					{
						break;
					}
				}
			}
			_characterFriendshipBar.AnimateOut();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB8")]
		[Cpp2IlInjected.Address(RVA = "0x12BA6E0", Offset = "0x12B90E0", VA = "0x1812BA6E0")]
		private Mdl.Characters.Character GetCharacter()
		{
			List<DialogueTree.ActorParameter> actorParameters = _dialogueInstance.DialogueTree._actorParameters;
			Func<DialogueTree.ActorParameter, bool> func = (Func<DialogueTree.ActorParameter, bool>)(object)(Func<T, TResult>)delegate(DialogueTree.ActorParameter x)
			{
				//Discarded unreachable code: IL_0020
				IDialogueActor actor = x.actor;
				DialogueInstance dialogueInstance = _dialogueInstance;
				return actor != dialogueInstance.Instigator;
			};
			IDialogueActor characterActor = Enumerable.FirstOrDefault<DialogueTree.ActorParameter>((IEnumerable<>)actorParameters, (Func<, >)(object)func).actor;
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int num = 0;
			IEnumerable<CharacterManager.CharacterInstance> characterInstances = (IEnumerable<CharacterManager.CharacterInstance>)system.GetCharacterInstances((byte)num != 0);
			Func<CharacterManager.CharacterInstance, bool> func2 = (Func<CharacterManager.CharacterInstance, bool>)(object)(Func<T, TResult>)delegate(CharacterManager.CharacterInstance x)
			{
				//Discarded unreachable code: IL_0011
				IDialogueActor dialogueActor = characterActor;
				return x.Character == dialogueActor;
			};
			CharacterManager.CharacterInstance characterInstance = Enumerable.FirstOrDefault<CharacterManager.CharacterInstance>((IEnumerable<>)characterInstances, (Func<, >)(object)func2);
			if (characterInstance != null)
			{
				return characterInstance.Character;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB9")]
		[Cpp2IlInjected.Address(RVA = "0x12BA530", Offset = "0x12B8F30", VA = "0x1812BA530")]
		private CharacterItemData GetCharacter(string actorName)
		{
			//Discarded unreachable code: IL_0034
			IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<CharacterItemData>(ItemType.Character);
			Func<CharacterItemData, bool> func = (Func<CharacterItemData, bool>)(object)(Func<T, TResult>)delegate(CharacterItemData x)
			{
				//Discarded unreachable code: IL_0034
				string name_ = x.name_;
				char[] array = new char[1];
				array[0] = '!';
				string a = ((IEnumerable<>)(object)name_.Split(array)).Last<string>();
				string b = actorName;
				return string.Equals(a, b);
			};
			return Enumerable.FirstOrDefault<CharacterItemData>(Enumerable.Where<CharacterItemData>(allByType, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABA")]
		[Cpp2IlInjected.Address(RVA = "0x12BAD40", Offset = "0x12B9740", VA = "0x1812BAD40")]
		[IteratorStateMachine(typeof(_003CInternal_OnSubtitlesRequestInfo_003Ed__76))]
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info)
		{
			int _003C_003E1__state = default(int);
			_003CInternal_OnSubtitlesRequestInfo_003Ed__76 _003CInternal_OnSubtitlesRequestInfo_003Ed__ = new _003CInternal_OnSubtitlesRequestInfo_003Ed__76(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CInternal_OnSubtitlesRequestInfo_003Ed__._003C_003E4__this = this;
			_003CInternal_OnSubtitlesRequestInfo_003Ed__.info = info;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABB")]
		[Cpp2IlInjected.Address(RVA = "0x12BADD0", Offset = "0x12B97D0", VA = "0x1812BADD0")]
		private bool IsAnyActionButtonTriggered()
		{
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				if (!Input.GetMouseButtonDown(0) && !Input.GetButtonDown(88))
				{
					return Input.GetKeyDown(KeyCode.E);
				}
				return true;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABC")]
		[Cpp2IlInjected.Address(RVA = "0x12BAED0", Offset = "0x12B98D0", VA = "0x1812BAED0")]
		private bool IsAnyCancelButtonTriggered(bool checkCancelButtons)
		{
			if (checkCancelButtons)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int ignoreThrobber = 0;
				if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
				{
					if (Input.GetButtonDown(14))
					{
						return true;
					}
					return Input.GetKeyDown(KeyCode.Escape);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABD")]
		[Cpp2IlInjected.Address(RVA = "0x12B9FA0", Offset = "0x12B89A0", VA = "0x1812B9FA0")]
		[IteratorStateMachine(typeof(_003CCheckInput_003Ed__79))]
		private IEnumerator CheckInput(Action onInputActivated, bool checkCancelButtons = false, [System.Runtime.InteropServices.Optional] InternalCancellationToken ct)
		{
			int _003C_003E1__state = default(int);
			_003CCheckInput_003Ed__79 _003CCheckInput_003Ed__ = new _003CCheckInput_003Ed__79(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCheckInput_003Ed__._003C_003E4__this = this;
			_003CCheckInput_003Ed__.onInputActivated = onInputActivated;
			_003CCheckInput_003Ed__.ct = ct;
			_003CCheckInput_003Ed__.checkCancelButtons = checkCancelButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABE")]
		[Cpp2IlInjected.Address(RVA = "0x12BC210", Offset = "0x12BAC10", VA = "0x1812BC210")]
		private void OnMultipleChoiceRequest(object sender, MultipleChoiceRequestInfo info)
		{
			//Discarded unreachable code: IL_0020
			int _003C_003E1__state = default(int);
			_003CInternal_MultipleChoiceRequest_003Ed__81 _003CInternal_MultipleChoiceRequest_003Ed__ = new _003CInternal_MultipleChoiceRequest_003Ed__81(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CInternal_MultipleChoiceRequest_003Ed__._003C_003E4__this = this;
			_003CInternal_MultipleChoiceRequest_003Ed__.info = info;
			Coroutine coroutine = StartCoroutine(_003CInternal_MultipleChoiceRequest_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABF")]
		[Cpp2IlInjected.Address(RVA = "0x12BABF0", Offset = "0x12B95F0", VA = "0x1812BABF0")]
		[IteratorStateMachine(typeof(_003CInternal_MultipleChoiceRequest_003Ed__81))]
		private IEnumerator Internal_MultipleChoiceRequest(MultipleChoiceRequestInfo info)
		{
			int _003C_003E1__state = default(int);
			_003CInternal_MultipleChoiceRequest_003Ed__81 _003CInternal_MultipleChoiceRequest_003Ed__ = new _003CInternal_MultipleChoiceRequest_003Ed__81(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CInternal_MultipleChoiceRequest_003Ed__._003C_003E4__this = this;
			_003CInternal_MultipleChoiceRequest_003Ed__.info = info;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC0")]
		[Cpp2IlInjected.Address(RVA = "0x12B9950", Offset = "0x12B8350", VA = "0x1812B9950")]
		private void AnimateXp(Transform btn, int bonusXp)
		{
			//Discarded unreachable code: IL_0183
			//IL_0060: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_0103: Expected O, but got I4
			//IL_0134: Expected O, but got I4
			DialogBonusAnimation animatePrefab = _animatePrefab;
			Transform parent = base.gameObject.transform;
			DialogBonusAnimation animate = UnityEngine.Object.Instantiate(animatePrefab, parent);
			DialogBonusAnimation dialogBonusAnimation = animate;
			Image mcAnimateBg = dialogBonusAnimation._mcAnimateBg;
			int num = 0;
			int num2 = 0;
			Transform transform = dialogBonusAnimation._mcAnimateBg.transform;
			int num3 = 0;
			Vector3 zero = Vector3.zero;
			transform.localScale = (Vector3)num3;
			string text = default(string);
			dialogBonusAnimation._tfXpBonus.Text = text;
			Transform transform2 = animate.transform;
			Transform transform3 = animate.transform;
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			Transform transform4 = animate._mcAnimateBg.transform;
			int num4 = 0;
			Vector3 one = Vector3.one;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(transform4, (Vector3)num4, 0.3f)).SetDelay(0.3f);
			TweenerCore<Color, Color, ColorOptions> tweenerCore3 = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(animate._mcAnimateBg, (Color)num4, 0.15f)).SetDelay(0.3f);
			TweenerCore<Color, Color, ColorOptions> tweenerCore4 = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(animate._mcAnimateBg, (Color)num4, 0.25f)).SetDelay(0.5f);
			Transform transform5 = animate.transform;
			int num5 = 0;
			Vector3 zero2 = Vector3.zero;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore5 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(transform5, (Vector3)num5, 0.2f)).SetDelay(0.8f);
			TweenerCore<Vector2, Vector2, VectorOptions> t2 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore6 = t2.SetDelay(0.8f);
			TweenerCore<Vector2, Vector2, VectorOptions> t3 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore7 = t3.SetDelay(0.9f);
			TweenerCore<Vector2, Vector2, VectorOptions> t4 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore8 = t4.SetDelay(0.8f);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0011
				UnityEngine.Object.Destroy(animate.gameObject);
			};
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC1")]
		[Cpp2IlInjected.Address(RVA = "0x12BA330", Offset = "0x12B8D30", VA = "0x1812BA330")]
		[IteratorStateMachine(typeof(_003CCountDown_003Ed__83))]
		private IEnumerator CountDown(MultipleChoiceRequestInfo info)
		{
			int _003C_003E1__state = default(int);
			_003CCountDown_003Ed__83 _003CCountDown_003Ed__ = new _003CCountDown_003Ed__83(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCountDown_003Ed__._003C_003E4__this = this;
			_003CCountDown_003Ed__.info = info;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC2")]
		[Cpp2IlInjected.Address(RVA = "0x12BA3C0", Offset = "0x12B8DC0", VA = "0x1812BA3C0")]
		private void Finalize(MultipleChoiceRequestInfo info, int index)
		{
			//Discarded unreachable code: IL_007c
			//IL_007b: Expected O, but got I4
			RectTransform root = optionsGroup;
			isWaitingChoice = false;
			RectTransformUtilities.SetAlpha(root, 1f);
			GameObject gameObject = optionsGroup.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = playerDialogueGroup.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			if (info.showLastStatement)
			{
				GameObject gameObject3 = subtitlesGroup.gameObject;
				int active3 = 0;
				gameObject3.SetActive((byte)active3 != 0);
			}
			int num = 0;
			VibrationsManager.TriggerSelection();
			info.SelectOption((T)index);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC3")]
		[Cpp2IlInjected.Address(RVA = "0x12BAC80", Offset = "0x12B9680", VA = "0x1812BAC80")]
		[IteratorStateMachine(typeof(_003CInternal_OnPlayerDialogueRequestInfo_003Ed__85))]
		private IEnumerator Internal_OnPlayerDialogueRequestInfo(string text, bool continueDialogue, [System.Runtime.InteropServices.Optional] SubtitlesRequestInfo info)
		{
			int _003C_003E1__state = default(int);
			_003CInternal_OnPlayerDialogueRequestInfo_003Ed__85 _003CInternal_OnPlayerDialogueRequestInfo_003Ed__ = new _003CInternal_OnPlayerDialogueRequestInfo_003Ed__85(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CInternal_OnPlayerDialogueRequestInfo_003Ed__._003C_003E4__this = this;
			_003CInternal_OnPlayerDialogueRequestInfo_003Ed__.text = text;
			_003CInternal_OnPlayerDialogueRequestInfo_003Ed__.info = info;
			_003CInternal_OnPlayerDialogueRequestInfo_003Ed__.continueDialogue = continueDialogue;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC4")]
		[Cpp2IlInjected.Address(RVA = "0x12BA4D0", Offset = "0x12B8ED0", VA = "0x1812BA4D0")]
		public void ForceHideOptions()
		{
			//Discarded unreachable code: IL_001f
			RectTransform rectTransform = optionsGroup;
			_forceOptionsHidden = true;
			GameObject gameObject = rectTransform.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC5")]
		[Cpp2IlInjected.Address(RVA = "0x12BA060", Offset = "0x12B8A60", VA = "0x1812BA060")]
		private void ClearOptionButtons()
		{
			//Discarded unreachable code: IL_00a5, IL_00ab, IL_00b1, IL_00b7
			//IL_000d: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			_currentHighlighted = (ButtonTmPro)num3;
			int selectLastOnCancel = 0;
			int show = 0;
			ShowSwitcherFriendship((byte)show != 0, (byte)selectLastOnCancel != 0);
			Dictionary<DialogueButton, int> dictionary = cachedButtons;
			if (dictionary != null && ((Dictionary<TKey, TValue>)(object)dictionary).Count > 0)
			{
				Dictionary<DialogueButton, int>.KeyCollection keys = (Dictionary<DialogueButton, int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)cachedButtons).get_Keys();
				bool flag = default(bool);
				if (flag)
				{
					Transform transform = default(Transform);
					RectTransform rectTransform = (RectTransform)(transform.parentInternal = _trashBin);
					int active = 0;
					GameObject gameObject = default(GameObject);
					gameObject.SetActive((byte)active != 0);
					GameObject obj = default(GameObject);
					UnityEngine.Object.Destroy(obj);
				}
			}
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation componentInChildren = GetComponentInChildren<FocusNavigation>();
				int num5 = 0;
				if (componentInChildren != (UnityEngine.Object)num5)
				{
					int num6 = 0;
					componentInChildren.SetFocus((FocusNavigationElement)num6);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC6")]
		[Cpp2IlInjected.Address(RVA = "0x12BE260", Offset = "0x12BCC60", VA = "0x1812BE260")]
		[IteratorStateMachine(typeof(_003CUpdateDialogueContainerPosition_003Ed__88))]
		private IEnumerator UpdateDialogueContainerPosition()
		{
			int _003C_003E1__state = default(int);
			_003CUpdateDialogueContainerPosition_003Ed__88 _003CUpdateDialogueContainerPosition_003Ed__ = new _003CUpdateDialogueContainerPosition_003Ed__88(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateDialogueContainerPosition_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC7")]
		[Cpp2IlInjected.Address(RVA = "0x12BB080", Offset = "0x12B9A80", VA = "0x1812BB080", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_008e
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			base.OnControllerChanged();
			ulong num = default(ulong);
			FocusNavigation componentInChildren = GetComponentInChildren<FocusNavigation>((byte)num != 0);
			int num2 = 0;
			if (!(componentInChildren != (UnityEngine.Object)num2))
			{
				return;
			}
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				Dictionary<DialogueButton, int> dictionary = cachedButtons;
				if (dictionary != null && ((Dictionary<TKey, TValue>)(object)dictionary).Count > 0)
				{
					if ((long)componentInChildren._focusedElement != 0)
					{
						return;
					}
					if (_003C_003Ec._003C_003E9__89_0 == null)
					{
						bool result = default(bool);
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<DialogueButton, int> x) => result);
					}
					bool flag = default(bool);
					if (flag)
					{
					}
					int num4 = 0;
					componentInChildren.SetFocus((FocusNavigationElement)num4);
					return;
				}
			}
			int num5 = 0;
			componentInChildren.SetFocus((FocusNavigationElement)num5);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC8")]
		[Cpp2IlInjected.Address(RVA = "0x12BB450", Offset = "0x12B9E50", VA = "0x1812BB450")]
		private void OnCurrencyItemData(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC9")]
		[Cpp2IlInjected.Address(RVA = "0x12BA950", Offset = "0x12B9350", VA = "0x1812BA950", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//IL_0097: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			if ((long)_highlightThenClick != 0 || _sentenceBeingDisplayed)
			{
				return;
			}
			if ((object)typeof(UnityEngine.Object).TypeHandle != null)
			{
				if ((object)typeof(UnityEngine.Object).TypeHandle == null)
				{
					goto IL_0056;
				}
				if ((long)typeof(UnityEngine.Object).TypeHandle != 1)
				{
					return;
				}
			}
			Dictionary<DialogueButton, int> dictionary = cachedButtons;
			if (dictionary != null)
			{
				Dictionary<DialogueButton, int>.KeyCollection keys = (Dictionary<DialogueButton, int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary).get_Keys();
				if (keys != null && (object)Enumerable.LastOrDefault<DialogueButton>((IEnumerable<>)(object)keys) != null)
				{
					goto IL_0056;
				}
			}
			goto IL_0099;
			IL_0056:
			if ((long)_cost == 0)
			{
				return;
			}
			Dictionary<DialogueButton, int> dictionary2 = cachedButtons;
			if (dictionary2 != null)
			{
				Dictionary<DialogueButton, int>.KeyCollection keys2 = (Dictionary<DialogueButton, int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary2).get_Keys();
				if (keys2 != null && (object)Enumerable.FirstOrDefault<DialogueButton>((IEnumerable<>)(object)keys2) == null)
				{
				}
			}
			ButtonTmPro currentHighlighted = _currentHighlighted;
			int num = 0;
			bool flag = currentHighlighted == (UnityEngine.Object)num;
			goto IL_0099;
			IL_0099:
			int num2 = 0;
			if ((_selectLastOnCancel || (long)_cost != 0) && _currentHighlighted != (UnityEngine.Object)num2 && IsHighlightable((ButtonTmPro)num2))
			{
				IEnumerator routine = HighlightThenClick((ButtonTmPro)num2);
				Coroutine coroutine = (_highlightThenClick = StartCoroutine(routine));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACA")]
		[Cpp2IlInjected.Address(RVA = "0x12BAB60", Offset = "0x12B9560", VA = "0x1812BAB60")]
		[IteratorStateMachine(typeof(_003CHighlightThenClick_003Ed__92))]
		private IEnumerator HighlightThenClick(ButtonTmPro button)
		{
			int _003C_003E1__state = default(int);
			_003CHighlightThenClick_003Ed__92 _003CHighlightThenClick_003Ed__ = new _003CHighlightThenClick_003Ed__92(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CHighlightThenClick_003Ed__._003C_003E4__this = this;
			_003CHighlightThenClick_003Ed__.button = button;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACB")]
		[Cpp2IlInjected.Address(RVA = "0x12BAFC0", Offset = "0x12B99C0", VA = "0x1812BAFC0")]
		private bool IsHighlightable(ButtonTmPro button)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (button != (UnityEngine.Object)num && button.gameObject.activeInHierarchy)
			{
				return button.Selectable;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACC")]
		[Cpp2IlInjected.Address(RVA = "0x12BCBA0", Offset = "0x12BB5A0", VA = "0x1812BCBA0")]
		private void PlayArrowAnimation()
		{
			//Discarded unreachable code: IL_001e
			_arrowTransform.gameObject.SetActive(value: true);
			Tween tween = _arrowTween.Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACD")]
		[Cpp2IlInjected.Address(RVA = "0x12BDDF0", Offset = "0x12BC7F0", VA = "0x1812BDDF0")]
		private void StopArrowAnimation()
		{
			//Discarded unreachable code: IL_0022
			Tween tween = _arrowTween.Pause();
			GameObject gameObject = _arrowTransform.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACE")]
		[Cpp2IlInjected.Address(RVA = "0x12BD290", Offset = "0x12BBC90", VA = "0x1812BD290")]
		public void ShowPlayerUI()
		{
			//Discarded unreachable code: IL_0024, IL_002a, IL_0030, IL_0036
			List<Transform> list = playerUI;
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject = default(GameObject);
				gameObject.SetActive(value: true);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				int active = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACF")]
		[Cpp2IlInjected.Address(RVA = "0x12BD0C0", Offset = "0x12BBAC0", VA = "0x1812BD0C0")]
		public void ShowNpcUI()
		{
			//Discarded unreachable code: IL_0024, IL_002a, IL_0030, IL_0036
			List<Transform> list = playerUI;
			bool flag = default(bool);
			if (flag)
			{
				int active = 0;
				GameObject gameObject = default(GameObject);
				gameObject.SetActive((byte)active != 0);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD0")]
		[Cpp2IlInjected.Address(RVA = "0x12BDE60", Offset = "0x12BC860", VA = "0x1812BDE60")]
		private void StopHighlightCoroutine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD1")]
		[Cpp2IlInjected.Address(RVA = "0x12BE2D0", Offset = "0x12BCCD0", VA = "0x1812BE2D0")]
		public DialogueMenu()
		{
		}
	}
}
