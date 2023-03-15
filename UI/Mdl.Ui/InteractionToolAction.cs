using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200056C")]
	public class InteractionToolAction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D91")]
		[SerializeField]
		private GameObject _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D92")]
		[SerializeField]
		private GameObject _secondContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D93")]
		[SerializeField]
		private TextBase _label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D94")]
		[SerializeField]
		private TextBase _secondLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D95")]
		[SerializeField]
		private GameObject _gamepadShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D96")]
		[SerializeField]
		private GameObject _secondGamepadShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001D97")]
		[SerializeField]
		private GameObject _mouseIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D98")]
		[SerializeField]
		private GameObject _secondMouseIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D99")]
		[SerializeField]
		private GameObject _secondGamepadHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001D9A")]
		[SerializeField]
		private VerticalLayoutGroup _safeAreaLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001D9B")]
		[SerializeField]
		[Header("Localized string for each Tool Type")]
		private string _wateringCan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001D9C")]
		[SerializeField]
		private string _fishingRod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001D9D")]
		[SerializeField]
		private string _gardeningShovel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001D9E")]
		[SerializeField]
		private string _pickaxe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001D9F")]
		[SerializeField]
		private string _cameraTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001DA0")]
		[SerializeField]
		private string _hold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001DA1")]
		private bool _isConsole;

		[Cpp2IlInjected.Token(Token = "0x17000581")]
		private Toolbox _toolbox
		{
			[Cpp2IlInjected.Token(Token = "0x6002380")]
			[Cpp2IlInjected.Address(RVA = "0xD273A0", Offset = "0xD25DA0", VA = "0x180D273A0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					return _003CInstance_003Ek__BackingField._avatar.Toolbox;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002381")]
		[Cpp2IlInjected.Address(RVA = "0xD26CE0", Offset = "0xD256E0", VA = "0x180D26CE0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00b0
			//IL_0027: Expected O, but got I4
			int num = 0;
			bool flag = (_isConsole = InputDetectionHelper.IsConsole());
			Toolbox.ToolType currentToolType = _toolbox._currentToolType;
			int num2 = 0;
			UpdateToolAction(num2, currentToolType);
			Toolbox toolbox = _toolbox;
			EventHandler<Toolbox.ToolType> eventHandler = (EventHandler<Toolbox.ToolType>)(object)new EventHandler<TEventArgs>(UpdateToolAction);
			toolbox.add_CurrentToolChanged((EventHandler<>)(object)eventHandler);
			bool flag2 = default(bool);
			if (flag2)
			{
				Action action = OnFishingStart;
				Action action2 = OnFishingStop;
			}
			if (!_isConsole)
			{
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				EventHandler value = OnControllerChanged;
				instance.OnNewInputReceived += value;
			}
			int _003C_003E1__state = default(int);
			_003CRefreshShortcutsCoroutine_003Ed__20 _003CRefreshShortcutsCoroutine_003Ed__ = new _003CRefreshShortcutsCoroutine_003Ed__20(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshShortcutsCoroutine_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CRefreshShortcutsCoroutine_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002382")]
		[Cpp2IlInjected.Address(RVA = "0xD27060", Offset = "0xD25A60", VA = "0x180D27060")]
		[IteratorStateMachine(typeof(_003CRefreshShortcutsCoroutine_003Ed__20))]
		private IEnumerator RefreshShortcutsCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CRefreshShortcutsCoroutine_003Ed__20 _003CRefreshShortcutsCoroutine_003Ed__ = new _003CRefreshShortcutsCoroutine_003Ed__20(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshShortcutsCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002383")]
		[Cpp2IlInjected.Address(RVA = "0xD26A70", Offset = "0xD25470", VA = "0x180D26A70")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_007c
			//IL_0010: Expected O, but got I4
			Toolbox toolbox = _toolbox;
			int num = 0;
			if (toolbox != (UnityEngine.Object)num)
			{
				Toolbox toolbox2 = _toolbox;
				EventHandler<Toolbox.ToolType> eventHandler = (EventHandler<Toolbox.ToolType>)(object)new EventHandler<TEventArgs>(UpdateToolAction);
				toolbox2.remove_CurrentToolChanged((EventHandler<>)(object)eventHandler);
			}
			bool flag = default(bool);
			if (flag)
			{
				Action action = OnFishingStart;
				Action action2 = OnFishingStop;
			}
			if (!_isConsole)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				EventHandler value = OnControllerChanged;
				instance.OnNewInputReceived -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002384")]
		[Cpp2IlInjected.Address(RVA = "0xD268C0", Offset = "0xD252C0", VA = "0x180D268C0")]
		private void OnControllerChanged(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_00a8
			//IL_00a7: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
			string text = default(string);
			Debug.Log("InteractionToolAction - OnControllerChanged: isControllerConnected = " + text);
			GameObject gamepadShortcut = _gamepadShortcut;
			GameObject secondGamepadShortcut = _secondGamepadShortcut;
			bool active = default(bool);
			_mouseIcon.SetActive(active);
			bool active2 = default(bool);
			_secondMouseIcon.SetActive(active2);
			int num2 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			bool flag = instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0);
			if (!flag && _isConsole == flag)
			{
				VerticalLayoutGroup safeAreaLayout = _safeAreaLayout;
			}
			_safeAreaLayout.spacing = -35f;
			Toolbox.ToolType currentToolType = _toolbox._currentToolType;
			int num3 = 0;
			UpdateToolAction(num3, currentToolType);
		}

		[Cpp2IlInjected.Token(Token = "0x6002385")]
		[Cpp2IlInjected.Address(RVA = "0xD270D0", Offset = "0xD25AD0", VA = "0x180D270D0")]
		private void SetLayoutForGamepad()
		{
			//Discarded unreachable code: IL_0041
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			if (!flag && _isConsole == flag)
			{
				_safeAreaLayout.spacing = -45f;
			}
			else
			{
				_safeAreaLayout.spacing = -35f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002386")]
		[Cpp2IlInjected.Address(RVA = "0xD27140", Offset = "0xD25B40", VA = "0x180D27140")]
		private void UpdateToolAction(object sender, Toolbox.ToolType currentTool)
		{
			//Discarded unreachable code: IL_0037, IL_0051, IL_00de, IL_0143, IL_015d, IL_0177
			//IL_000e: Expected I4, but got I8
			//IL_006d: Expected O, but got I4
			//IL_00ba: Expected I4, but got I8
			//IL_0111: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			ulong num = default(ulong);
			_content.SetActive((byte)num != 0);
			GameObject secondContent = _secondContent;
			int active = 0;
			secondContent.SetActive((byte)active != 0);
			if (currentTool <= Toolbox.ToolType.CameraTool)
			{
				GameObject content = _content;
				int active2 = 0;
				content.SetActive((byte)active2 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002387")]
		[Cpp2IlInjected.Address(RVA = "0xD27020", Offset = "0xD25A20", VA = "0x180D27020")]
		private void OnFishingStop()
		{
			//Discarded unreachable code: IL_0020
			//IL_0017: Expected O, but got I4
			TextBase secondLabel = _secondLabel;
			string fishingRod = _fishingRod;
			int num = 0;
			string text2 = (secondLabel.Text = LocalizationManager.FromStringID(fishingRod, (IResolver)num));
		}

		[Cpp2IlInjected.Token(Token = "0x6002388")]
		[Cpp2IlInjected.Address(RVA = "0xD26FC0", Offset = "0xD259C0", VA = "0x180D26FC0")]
		private void OnFishingStart()
		{
			//Discarded unreachable code: IL_001d
			//IL_0014: Expected O, but got I4
			TextBase secondLabel = _secondLabel;
			int num = 0;
			string text2 = (secondLabel.Text = LocalizationManager.FromStringID("menu.fishing_pull", (IResolver)num));
		}

		[Cpp2IlInjected.Token(Token = "0x6002389")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InteractionToolAction()
		{
		}
	}
}
