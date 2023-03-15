using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Tools
{
	[Cpp2IlInjected.Token(Token = "0x20008D2")]
	public class JIRAMenu : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40034A3")]
		[SerializeField]
		private Canvas _canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40034A4")]
		[SerializeField]
		private InputField _summaryInputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40034A5")]
		[SerializeField]
		private InputField _descriptionInputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40034A6")]
		[SerializeField]
		private Dropdown _severityDropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40034A7")]
		[SerializeField]
		private Dropdown _probabilityDropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40034A8")]
		[SerializeField]
		private Button _submitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40034A9")]
		[SerializeField]
		private Button _cancelButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40034AA")]
		private Texture2D screenshot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40034AC")]
		private IDisposable overrideControls;

		[Cpp2IlInjected.Token(Token = "0x170007D3")]
		public static JIRAMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6003775")]
			[Cpp2IlInjected.Address(RVA = "0x13276D0", Offset = "0x13260D0", VA = "0x1813276D0")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003776")]
			[Cpp2IlInjected.Address(RVA = "0x1327710", Offset = "0x1326110", VA = "0x181327710")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003777")]
		[Cpp2IlInjected.Address(RVA = "0x13275C0", Offset = "0x1325FC0", VA = "0x1813275C0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0083
			string text = _descriptionInputField.m_Text;
			string empty = string.Empty;
			if (text != empty)
			{
				string text2 = _summaryInputField.m_Text;
				string empty2 = string.Empty;
				if (text2 != empty2 && _severityDropdown.m_Value != 0 && _probabilityDropdown.m_Value != 0)
				{
					Button submitButton = _submitButton;
				}
			}
			Button submitButton2 = _submitButton;
			int num = ((submitButton2.interactable = false) ? 1 : 0);
			bool activeSelf = _canvas.gameObject.activeSelf;
		}

		[Cpp2IlInjected.Token(Token = "0x6003778")]
		[Cpp2IlInjected.Address(RVA = "0x1326D70", Offset = "0x1325770", VA = "0x181326D70")]
		private void Awake()
		{
			Instance = this;
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003779")]
		[Cpp2IlInjected.Address(RVA = "0x13271C0", Offset = "0x1325BC0", VA = "0x1813271C0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0047
			Button.ButtonClickedEvent onClick = _submitButton.m_OnClick;
			UnityAction call = SubmitJIRA;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _cancelButton.m_OnClick;
			UnityAction call2 = Cancel;
			onClick2.AddListener(call2);
			Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x600377A")]
		[Cpp2IlInjected.Address(RVA = "0x1326E10", Offset = "0x1325810", VA = "0x181326E10")]
		private void Cancel()
		{
			//IL_0073: Expected O, but got I8
			InputField summaryInputField = _summaryInputField;
			string text = (summaryInputField.text = string.Empty);
			_descriptionInputField.text = "";
			Dropdown severityDropdown = _severityDropdown;
			int num2 = (severityDropdown.value = 0);
			Dropdown probabilityDropdown = _probabilityDropdown;
			int num4 = (probabilityDropdown.value = 0);
			GameObject gameObject = _canvas.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			if (overrideControls != null)
			{
			}
			overrideControls = (IDisposable)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600377B")]
		[Cpp2IlInjected.Address(RVA = "0x1326F20", Offset = "0x1325920", VA = "0x181326F20")]
		private void Open()
		{
			//Discarded unreachable code: IL_009f
			_severityDropdown.ClearOptions();
			Dropdown severityDropdown = _severityDropdown;
			List<string> list = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)JIRA.Severity).get_Keys());
			severityDropdown.AddOptions((List<>)(object)list);
			_probabilityDropdown.ClearOptions();
			Dropdown probabilityDropdown = _probabilityDropdown;
			List<string> list2 = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)JIRA.Probability).get_Keys());
			probabilityDropdown.AddOptions((List<>)(object)list2);
			Button submitButton = _submitButton;
			int num = ((submitButton.interactable = false) ? 1 : 0);
			PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (PlayerNavigation.TemporaryOverrideScope)(overrideControls = SystemRoot.Instance.GetSystem<PlayerNavigation>().OverrideAllScope());
			int _003C_003E1__state = default(int);
			_003CTakeScreenshot_003Ed__18 _003CTakeScreenshot_003Ed__ = new _003CTakeScreenshot_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTakeScreenshot_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CTakeScreenshot_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x600377C")]
		[Cpp2IlInjected.Address(RVA = "0x1327550", Offset = "0x1325F50", VA = "0x181327550")]
		[IteratorStateMachine(typeof(_003CTakeScreenshot_003Ed__18))]
		private IEnumerator TakeScreenshot()
		{
			int _003C_003E1__state = default(int);
			_003CTakeScreenshot_003Ed__18 _003CTakeScreenshot_003Ed__ = new _003CTakeScreenshot_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTakeScreenshot_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600377D")]
		[Cpp2IlInjected.Address(RVA = "0x13272C0", Offset = "0x1325CC0", VA = "0x1813272C0")]
		private void SubmitJIRA()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600377E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public JIRAMenu()
		{
		}
	}
}
