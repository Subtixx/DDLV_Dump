using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class DebugLogManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static DebugLogManager instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		[HideInInspector]
		[Header("Properties")]
		private bool singleton = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		[HideInInspector]
		private float minimumHeight = 200f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		[HideInInspector]
		private bool enablePopup = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[HideInInspector]
		[SerializeField]
		private bool startInPopupMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[HideInInspector]
		[SerializeField]
		private bool startMinimized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		[HideInInspector]
		private bool toggleWithKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[HideInInspector]
		[SerializeField]
		private KeyCode toggleKey = KeyCode.BackQuote;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		[HideInInspector]
		private bool clearCommandAfterExecution = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		[HideInInspector]
		private int commandHistorySize = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		[HideInInspector]
		private bool receiveLogcatLogsInAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[HideInInspector]
		[SerializeField]
		private string logcatArguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		private int maxLogLength = 10000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		[Header("Visuals")]
		private GameObject logItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		private Sprite infoLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		private Sprite warningLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		private Sprite errorLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private Dictionary<LogType, Sprite> logSpriteRepresentations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		private Color collapseButtonNormalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		private Color collapseButtonSelectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		private Color filterButtonsNormalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		[SerializeField]
		private Color filterButtonsSelectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[SerializeField]
		[Header("Internal References")]
		private RectTransform logWindowTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private RectTransform canvasTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		private RectTransform logItemsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		private InputField commandInputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		private InputField emailAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		private InputField emailPassword;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		private Image collapseButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		private Image filterInfoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		private Image filterWarningButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		private Image filterErrorButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		private Text infoEntryCountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		private Text warningEntryCountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		private Text errorEntryCountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		private GameObject snapToBottomButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		private CanvasGroup logWindowCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		private DebugLogPopup popupManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		private ScrollRect logItemsScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		private DebugLogRecycledListView recycledListView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private int infoEntryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private int warningEntryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private int errorEntryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private bool isLogWindowVisible = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14D")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private bool screenDimensionsChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14E")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private bool isCollapseOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private DebugLogFilter logFilter = DebugLogFilter.All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private bool snapToBottom = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private List<DebugLogEntry> collapsedLogEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private Dictionary<DebugLogEntry, int> collapsedLogEntriesMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private DebugLogIndexList uncollapsedLogEntriesIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private DebugLogIndexList indicesOfListEntriesToShow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private DynamicCircularBuffer<QueuedDebugLogEntry> queuedLogEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private object logEntriesLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private List<DebugLogEntry> pooledLogEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private List<DebugLogItem> pooledLogItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private CircularBuffer<string> commandHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private int commandHistoryIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private PointerEventData nullPointerEventData;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x112FCC0", Offset = "0x112E6C0", VA = "0x18112FCC0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00cf, IL_00d5, IL_00db, IL_00e1, IL_00e7
			//IL_000f: Expected O, but got I4
			//IL_01ed: Expected O, but got I4
			DebugLogManager debugLogManager = instance;
			int num = 0;
			if (!(debugLogManager == (UnityEngine.Object)num))
			{
				DebugLogManager debugLogManager2 = instance;
				if (this != debugLogManager2)
				{
					UnityEngine.Object.Destroy(base.gameObject);
					return;
				}
			}
			else
			{
				instance = this;
				if (singleton)
				{
					UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
				}
			}
			List<DebugLogEntry> list = (pooledLogEntries = (List<DebugLogEntry>)(object)new List<T>(16));
			List<DebugLogItem> list2 = (pooledLogItems = (List<DebugLogItem>)(object)new List<T>(16));
			DynamicCircularBuffer<QueuedDebugLogEntry> dynamicCircularBuffer = (queuedLogEntries = (DynamicCircularBuffer<QueuedDebugLogEntry>)(object)new DynamicCircularBuffer<T>(16));
			CircularBuffer<string> circularBuffer = (commandHistory = (CircularBuffer<string>)(object)new CircularBuffer<T>(commandHistorySize));
			object obj = (logEntriesLock = new object());
			Transform transform = GetComponentInParent<Canvas>().transform;
			int num2 = 0;
			if ((object)transform == null || (object)transform != null)
			{
				canvasTR = (RectTransform)transform;
				Dictionary<LogType, Sprite> dictionary = (Dictionary<LogType, Sprite>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x11320E0", Offset = "0x1130AE0", VA = "0x1811320E0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00a8
			//IL_0058: Expected O, but got I4
			Application.logMessageReceivedThreaded -= ReceivedLog;
			Application.logMessageReceivedThreaded += ReceivedLog;
			InputField inputField = commandInputField;
			InputField.OnValidateInput onValidateInput = inputField.m_OnValidateInput;
			InputField.OnValidateInput value = OnValidateCommand;
			Delegate @delegate = Delegate.Remove(onValidateInput, value);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				inputField.onValidateInput = (InputField.OnValidateInput)num;
				InputField.OnValidateInput onValidateInput2 = commandInputField.m_OnValidateInput;
				InputField.OnValidateInput b = OnValidateCommand;
				Delegate delegate2 = Delegate.Combine(onValidateInput2, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					Action<string> action = (Action<string>)(object)new Action<T>(CallReflection);
					DebugLogConsole.AddCommand<string>("call", "Reflection call. \nexamples => \n\"call Mdl.Grid.GridEditMode.IsDecorChallengeEditMode\"\n\"call Mdl.Ui.PlayerProgression.Percent=0.5\"\n\"call Mdl.Ui.PlayerProgression.SetProgression(5,100,true)\"\n", (Action<>)(object)action);
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1131E80", Offset = "0x1130880", VA = "0x181131E80")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0074
			//IL_0055: Expected O, but got I4
			if (!(instance != this))
			{
				Application.logMessageReceivedThreaded -= ReceivedLog;
				InputField inputField = commandInputField;
				InputField.OnValidateInput onValidateInput = inputField.m_OnValidateInput;
				InputField.OnValidateInput value = OnValidateCommand;
				Delegate @delegate = Delegate.Remove(onValidateInput, value);
				int num = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				inputField.onValidateInput = (InputField.OnValidateInput)num;
				if (!string.IsNullOrEmpty("call"))
				{
					bool flag = ((Dictionary<TKey, TValue>)(object)DebugLogConsole.methods).Remove((TKey)"call");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1133900", Offset = "0x1132300", VA = "0x181133900")]
		private void Start()
		{
			//Discarded unreachable code: IL_0039
			if (enablePopup)
			{
			}
			if (!startMinimized)
			{
				ShowLogWindow();
			}
			ShowPopup();
			GameObject gameObject = popupManager.gameObject;
			bool active = enablePopup;
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1132370", Offset = "0x1130D70", VA = "0x181132370")]
		private void OnRectTransformDimensionsChange()
		{
			screenDimensionsChanged = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x11319A0", Offset = "0x11303A0", VA = "0x1811319A0")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_01e1
			//IL_0199: Expected O, but got I8
			//IL_01ae: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int _003CCount_003Ek__BackingField = ((DynamicCircularBuffer<>)(object)queuedLogEntries).Count;
			if (_003CCount_003Ek__BackingField > 0)
			{
				int num3 = 0;
				if (num3 < _003CCount_003Ek__BackingField)
				{
					object obj = logEntriesLock;
					DynamicCircularBuffer<QueuedDebugLogEntry> dynamicCircularBuffer = queuedLogEntries;
					Monitor.Exit(obj);
					num3++;
				}
			}
			if (screenDimensionsChanged)
			{
				if (!isLogWindowVisible)
				{
					popupManager.OnViewportDimensionsChanged();
				}
				recycledListView.OnViewportDimensionsChanged();
				screenDimensionsChanged = false;
			}
			ScrollRect scrollRect = logItemsScrollRect;
			if (!snapToBottom)
			{
				float verticalNormalizedPosition = scrollRect.verticalNormalizedPosition;
				bool activeSelf = snapToBottomButton.activeSelf;
				int num4 = 0;
				if (!(verticalNormalizedPosition <= 1E-06f))
				{
				}
				if ((activeSelf ? 1 : 0) == num4)
				{
					goto IL_00cc;
				}
				bool activeSelf2 = snapToBottomButton.activeSelf;
			}
			if (snapToBottomButton.activeSelf)
			{
				GameObject gameObject = snapToBottomButton;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			goto IL_00cc;
			IL_00cc:
			if (toggleWithKey)
			{
				int num5 = (int)toggleKey;
				bool flag = default(bool);
				if (flag)
				{
					int num6 = 0;
					if ((isLogWindowVisible ? 1 : 0) == num6)
					{
						ShowLogWindow();
					}
					ShowPopup();
				}
			}
			if (!isLogWindowVisible || !commandInputField.m_AllowInput)
			{
				return;
			}
			bool flag2 = default(bool);
			InputField inputField = default(InputField);
			if (!flag2)
			{
				bool flag3 = default(bool);
				if (flag3)
				{
					int num7 = commandHistoryIndex;
					CircularBuffer<string> circularBuffer = commandHistory;
					if (num7 != -1)
					{
						num7 = (commandHistoryIndex = num7 + 1);
						int _003CCount_003Ek__BackingField2 = ((CircularBuffer<>)(object)circularBuffer).Count;
					}
					int index = (commandHistoryIndex = ((CircularBuffer<>)(object)circularBuffer).Count);
					inputField = commandInputField;
					string text2 = (inputField.text = (string)((CircularBuffer<T>)(object)circularBuffer)[index]);
				}
				return;
			}
			TextGenerator inputTextCache = inputField.m_InputTextCache;
			int num8 = default(int);
			if ((long)inputTextCache != -1)
			{
				inputField.m_InputTextCache = inputTextCache;
				inputField.m_InputTextCache = (TextGenerator)0;
				num8 = 0;
			}
			UIVertex[] cursorVerts = inputField.m_CursorVerts;
			inputField.m_InputTextCache = (TextGenerator)num8;
			UIVertex[] cursorVerts2 = inputField.m_CursorVerts;
			while ((long)num8 >= (long)(IntPtr)"{il2cpp array field local61->}")
			{
			}
			AnimationTriggers animationTriggers = ((Selectable)inputField).m_AnimationTriggers;
			AnimationTriggers animationTriggers2 = ((Selectable)inputField).m_AnimationTriggers;
			string text3 = default(string);
			int stringLength = text3.m_stringLength;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x11337F0", Offset = "0x11321F0", VA = "0x1811337F0")]
		public void ShowLogWindow()
		{
			//Discarded unreachable code: IL_0047
			logWindowCanvasGroup.interactable = true;
			logWindowCanvasGroup.blocksRaycasts = true;
			logWindowCanvasGroup.alpha = 1f;
			popupManager.Hide();
			recycledListView.OnLogEntriesUpdated(updateAllVisibleItemContents: true);
			isLogWindowVisible = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1133880", Offset = "0x1132280", VA = "0x181133880")]
		public void ShowPopup()
		{
			//Discarded unreachable code: IL_0057
			//IL_0034: Expected F4, but got I4
			//IL_004f: Expected I4, but got I8
			CanvasGroup canvasGroup = logWindowCanvasGroup;
			int num = ((canvasGroup.interactable = false) ? 1 : 0);
			CanvasGroup canvasGroup2 = logWindowCanvasGroup;
			int num2 = ((canvasGroup2.blocksRaycasts = false) ? 1 : 0);
			CanvasGroup canvasGroup3 = logWindowCanvasGroup;
			int num3 = 0;
			canvasGroup3.alpha = num3;
			popupManager.Show();
			commandHistoryIndex = -1;
			isLogWindowVisible = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1132380", Offset = "0x1130D80", VA = "0x181132380")]
		public char OnValidateCommand(string text, int charIndex, char addedChar)
		{
			//Discarded unreachable code: IL_0002, IL_000b, IL_001b, IL_0024, IL_0036, IL_0046, IL_0052, IL_006f, IL_0071, IL_0079, IL_0080, IL_0084
			//IL_0062: Expected I4, but got I8
			return addedChar;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1132C70", Offset = "0x1131670", VA = "0x181132C70")]
		private unsafe void ReceivedLog(string logString, string stackTrace, LogType logType)
		{
			//Discarded unreachable code: IL_00c9
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected I4, but got Unknown
			//IL_00c1: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int stringLength = logString.m_stringLength;
			int num4 = maxLogLength;
			if (stackTrace != null)
			{
				int stringLength2 = stackTrace.m_stringLength;
				if (num2 <= num4)
				{
					goto IL_00a5;
				}
				num4 -= logString;
				if (stringLength < num4)
				{
					num4 -= stringLength;
				}
				int startIndex = 0;
				if (stringLength2 < num4)
				{
					num4 -= stringLength2;
				}
				string text = logString.Substring(startIndex, num4);
				int length = 0;
				string text2 = text + "<truncated>";
				int startIndex2 = 0;
				string text3 = stackTrace.Substring(startIndex2, length) + "<truncated>\n";
			}
			if (stringLength > num4)
			{
				num4 += -11;
				int startIndex3 = 0;
				string text4 = logString.Substring(startIndex3, num4) + "<truncated>";
			}
			goto IL_00a5;
			IL_00a5:
			object obj = logEntriesLock;
			Monitor.Enter(obj, ref *(bool*)num3);
			((DynamicCircularBuffer<T>)(object)queuedLogEntries).Add((T)num);
			Monitor.Exit(obj);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1132760", Offset = "0x1131160", VA = "0x181132760")]
		private void ProcessLog(QueuedDebugLogEntry queuedLogEntry)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x11337E0", Offset = "0x11321E0", VA = "0x1811337E0")]
		public void SetSnapToBottom(bool snapToBottom)
		{
			this.snapToBottom = snapToBottom;
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x1133960", Offset = "0x1132360", VA = "0x181133960")]
		public void ValidateScrollPosition()
		{
			//Discarded unreachable code: IL_000d
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)logItemsScrollRect).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1131990", Offset = "0x1130390", VA = "0x181131990")]
		public void HideButtonPressed()
		{
			ShowPopup();
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1130F10", Offset = "0x112F910", VA = "0x181130F10")]
		public void ClearButtonPressed()
		{
			//Discarded unreachable code: IL_008f
			Text text = infoEntryCountText;
			int size = 0;
			snapToBottom = true;
			infoEntryCount = size;
			errorEntryCount = size;
			text.text = "0";
			warningEntryCountText.text = "0";
			errorEntryCountText.text = "0";
			((List<T>)(object)collapsedLogEntries).Clear();
			((Dictionary<TKey, TValue>)(object)collapsedLogEntriesMap).Clear();
			uncollapsedLogEntriesIndices.size = size;
			indicesOfListEntriesToShow.size = size;
			recycledListView.DeselectSelectedLogItem();
			recycledListView.OnLogEntriesUpdated(updateAllVisibleItemContents: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1131070", Offset = "0x112FA70", VA = "0x181131070")]
		public void CollapseButtonPressed()
		{
			//Discarded unreachable code: IL_0053
			bool flag = isCollapseOn;
			snapToBottom = true;
			bool flag2 = (isCollapseOn = !flag);
			Image image = collapseButton;
			if (!flag)
			{
			}
			Color color2 = (image.color = collapseButtonNormalColor);
			DebugLogRecycledListView debugLogRecycledListView = recycledListView;
			bool flag3 = (debugLogRecycledListView.isCollapseOn = isCollapseOn);
			FilterLogs();
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1131170", Offset = "0x112FB70", VA = "0x181131170")]
		public void FilterLogButtonPressed()
		{
			//Discarded unreachable code: IL_0025
			Image image = filterInfoButton;
			if (logFilter == DebugLogFilter.Info)
			{
			}
			Color color2 = (image.color = filterButtonsSelectedColor);
			FilterLogs();
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x11316C0", Offset = "0x11300C0", VA = "0x1811316C0")]
		public void FilterWarningButtonPressed()
		{
			//Discarded unreachable code: IL_0025
			Image image = filterWarningButton;
			if (logFilter == DebugLogFilter.Warning)
			{
			}
			Color color2 = (image.color = filterButtonsSelectedColor);
			FilterLogs();
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x1131100", Offset = "0x112FB00", VA = "0x181131100")]
		public void FilterErrorButtonPressed()
		{
			//Discarded unreachable code: IL_0025
			Image image = filterErrorButton;
			if (logFilter == DebugLogFilter.Error)
			{
			}
			Color color2 = (image.color = filterButtonsSelectedColor);
			FilterLogs();
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1132E80", Offset = "0x1131880", VA = "0x181132E80")]
		public void Resize(BaseEventData dat)
		{
			//Discarded unreachable code: IL_005b
			//IL_0040: Expected F4, but got I4
			int num = 0;
			if (dat != null)
			{
				int num2 = 0;
				if (dat != null)
				{
					RectTransform rectTransform = logWindowTR;
					RectTransform rectTransform2 = canvasTR;
					Vector2 anchorMin = logWindowTR.anchorMin;
					Vector2 sizeDelta = canvasTR.sizeDelta;
					float num3 = Mathf.Max(0f, 1f);
					logWindowTR.anchorMin = anchorMin;
					recycledListView.OnViewportDimensionsChanged();
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x11311E0", Offset = "0x112FBE0", VA = "0x1811311E0")]
		private void FilterLogs()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x1131730", Offset = "0x1130130", VA = "0x181131730")]
		public string GetAllLogs()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x1130430", Offset = "0x112EE30", VA = "0x181130430")]
		public unsafe void CallReflection(string signature)
		{
			//Discarded unreachable code: IL_0307, IL_030d, IL_0313, IL_0319, IL_031f, IL_0325, IL_032b, IL_0331, IL_0337, IL_033d, IL_0343, IL_0349, IL_034f, IL_0355, IL_035b, IL_0361, IL_0367, IL_036d, IL_0373, IL_0379, IL_037f, IL_0385, IL_038b, IL_0391, IL_0397, IL_039d, IL_03a3, IL_03a9, IL_03af, IL_03b5, IL_03bb, IL_03c1, IL_03c7, IL_03cd, IL_03d3
			//IL_0164: Expected O, but got I4
			//IL_0181: Expected O, but got I4
			//IL_0196: Expected O, but got I4
			//IL_01da: Expected I4, but got I8
			//IL_01e8: Expected O, but got I4
			//IL_0216: Expected O, but got I4
			//IL_0233: Expected O, but got I4
			//IL_0250: Expected O, but got I4
			//IL_02a6: Expected O, but got I4
			int num = 0;
			int stringLength = signature.m_stringLength;
			int num2 = stringLength - 1;
			int num3 = default(int);
			if (num3 == num2)
			{
				int startIndex = 0;
				string text = signature.Substring(startIndex, stringLength);
			}
			string text2 = default(string);
			if (signature.Contains("="))
			{
				char[] array = new char[1];
				uint num4 = default(uint);
				array[0] = (char)num4;
				string[] array2 = signature.Split(array);
				int length = array2.Length;
				text2 = array2[0];
				string text3 = array2[1];
			}
			uint value = default(uint);
			int length2 = text2.LastIndexOf((char)value);
			int startIndex2 = 0;
			string text4 = text2.Substring(startIndex2, length2);
			int num8 = default(int);
			if (text2.Contains("("))
			{
				uint value2 = default(uint);
				int num5 = text2.LastIndexOf((char)value2);
				uint value3 = default(uint);
				int num6 = text2.LastIndexOf((char)value3);
				uint value4 = default(uint);
				int num7 = text2.LastIndexOf((char)value4);
				num6 -= num7;
				int length3 = num6 - 1;
				num8 = num5 + 1;
				string text5 = text2.Substring(num8, length3);
			}
			int startIndex3 = text2.LastIndexOf((char)num8) + 1;
			string text6 = text2.Substring(startIndex3);
			if (text2.Contains("("))
			{
				uint value5 = default(uint);
				int startIndex4 = text2.LastIndexOf((char)value5);
				string text7 = text2.Substring(startIndex4).Replace("(", "").Replace(")", "");
				char[] array3 = new char[1];
				uint num9 = default(uint);
				array3[0] = (char)num9;
				string[] array4 = text7.Split(array3);
			}
			int num10 = 0;
			List<object> list = (List<object>)(object)new List<T>();
			int num11 = 0;
			Type type = default(Type);
			if (list.Equals(num11))
			{
				int num12 = 0;
				Assembly assembly = default(Assembly);
				type = assembly.GetType(text4);
				int num13 = 0;
				if (!(type != (Type)num13))
				{
					num12++;
				}
				int num14 = 0;
				if (((object)type).Equals((object)num14))
				{
					Debug.Log(text4 + " doesn't exist");
				}
			}
			int num15 = 0;
			Scene scene = base.gameObject.scene;
			int num16 = 0;
			GameObject[] array5 = default(GameObject[]);
			Component componentInChildren = default(Component);
			if (num16 < array5.Length)
			{
				ulong num17 = default(ulong);
				componentInChildren = array5[num16].GetComponentInChildren(type, (byte)num17 != 0);
				int num18 = 0;
				if (!(componentInChildren != (UnityEngine.Object)num18))
				{
					num16++;
				}
			}
			string text8 = text6 + " couldn't be found";
			FieldInfo field = type.GetField(text6);
			int num19 = 0;
			MethodInfo method = default(MethodInfo);
			if (!(field != (FieldInfo)num19))
			{
				PropertyInfo property = type.GetProperty(text6);
				int num20 = 0;
				if (!(property != (PropertyInfo)num20))
				{
					method = type.GetMethod(text6);
					int num21 = 0;
					if (!(method != (MethodInfo)num21))
					{
						goto IL_02ff;
					}
					ParameterInfo[] parameters = method.GetParameters();
					if (parameters != null && parameters.Length != 0)
					{
						int num22 = 0;
						int num23 = 0;
						if (num23 < parameters.Length)
						{
							ParameterInfo parameterInfo = parameters[num23];
							if (num10 != 0)
							{
								if (num10 != 0)
								{
								}
								Type parameterType = parameterInfo.ParameterType;
								object item = Convert.ChangeType(num22, parameterType);
								((List<T>)(object)list).Add((T)item);
							}
							num22++;
							num23++;
						}
						object[] array6 = (object[])(object)((List<T>)(object)list).ToArray();
					}
					object obj = default(object);
					if (obj != null)
					{
						goto IL_02dc;
					}
				}
				if ((object)method != null)
				{
					((List<T>)(object)list).Clear();
					object obj2 = default(object);
					if (obj2 == null)
					{
					}
				}
				goto IL_02dc;
			}
			goto IL_02e5;
			IL_02ff:
			string message = default(string);
			Debug.Log(message);
			return;
			IL_02dc:
			object obj3 = default(object);
			string text9 = obj3.ToString();
			goto IL_02e5;
			IL_02e5:
			object obj4 = default(object);
			if ((object)method == null || obj4 != null)
			{
			}
			string text10 = ((int*)((List<T>)(object)list).System_002ECollections_002EIList_002EAdd((object)componentInChildren))->ToString();
			goto IL_02ff;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x1133160", Offset = "0x1131B60", VA = "0x181133160")]
		public void SaveLogsToFile()
		{
			//Discarded unreachable code: IL_0047
			int num = 0;
			DateTime now = DateTime.Now;
			string text = default(string);
			string text2 = text + ".txt";
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			if (_003CSave_003Ek__BackingField != null)
			{
				string allLogs = instance.GetAllLogs();
				_003CSave_003Ek__BackingField.WriteAllText(text2, allLogs);
			}
			Debug.Log("Logs saved to: " + text2);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1133320", Offset = "0x1131D20", VA = "0x181133320")]
		public void SendLogsToEmail()
		{
			//Discarded unreachable code: IL_0103, IL_0109, IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139
			//IL_00c8: Expected I4, but got I8
			int num = 0;
			MailMessage mailMessage = new MailMessage();
			MailAddress mailAddress = (mailMessage.from = new MailAddress(emailAddress.m_Text));
			MailAddressCollection to = mailMessage.to;
			string text = emailAddress.m_Text;
			to.Add(text);
			int num2 = 0;
			DateTime now = DateTime.Now;
			string text2 = default(string);
			string text4 = (mailMessage.Subject = "LOG " + text2);
			string text5 = (mailMessage.Body = instance.GetAllLogs());
			SmtpClient smtpClient = new SmtpClient("mail01.sds.gameloft.org");
			smtpClient.Port = 25;
			string text6 = emailAddress.m_Text;
			string text7 = emailPassword.m_Text;
			NetworkCredential networkCredential = (NetworkCredential)(smtpClient.Credentials = new NetworkCredential(text6, text7));
			int num3 = ((smtpClient.UseDefaultCredentials = false) ? 1 : 0);
			ulong num4 = default(ulong);
			smtpClient.EnableSsl = (byte)num4 != 0;
			RemoteCertificateValidationCallback _003C_003E9__83_ = _003C_003Ec._003C_003E9__83_0;
			if (_003C_003E9__83_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RemoteCertificateValidationCallback)((object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true);
			}
			ServicePointManager.ServerCertificateValidationCallback = _003C_003E9__83_;
			smtpClient.Send(mailMessage);
			Debug.Log("Logs sent to email");
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1133070", Offset = "0x1131A70", VA = "0x181133070")]
		public void SaveLogsToClipboard()
		{
			//Discarded unreachable code: IL_001a
			GUIUtility.systemCopyBuffer = instance.GetAllLogs();
			Debug.Log("Logs copied to clipboard");
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1132560", Offset = "0x1130F60", VA = "0x181132560")]
		public void PoolLogItem(DebugLogItem logItem)
		{
			//Discarded unreachable code: IL_001d
			GameObject gameObject = logItem.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			((List<T>)(object)pooledLogItems).Add((T)logItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x11325E0", Offset = "0x1130FE0", VA = "0x1811325E0")]
		public DebugLogItem PopLogItem()
		{
			//Discarded unreachable code: IL_003f
			int size = ((List<>)(object)pooledLogItems)._size;
			GameObject original = logItemPrefab;
			RectTransform parent = logItemsContainer;
			int worldPositionStays = 0;
			DebugLogItem component = UnityEngine.Object.Instantiate(original, parent, (byte)worldPositionStays != 0).GetComponent<DebugLogItem>();
			DebugLogRecycledListView debugLogRecycledListView = (component.manager = recycledListView);
			return component;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x11339A0", Offset = "0x11323A0", VA = "0x1811339A0")]
		public DebugLogManager()
		{
		}//IL_0023: Expected I4, but got I8
		//IL_0034: Expected I4, but got I8
		//IL_0041: Expected I4, but got I8
		//IL_0051: Expected I4, but got I8
		//IL_0068: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static DebugLogManager()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
