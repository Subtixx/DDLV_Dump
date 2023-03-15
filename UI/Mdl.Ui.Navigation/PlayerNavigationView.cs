using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Ftue;
using Mdl.Ftue.Cutscenes;
using Mdl.Navigation;
using Mdl.Navigation.ControlSchemes;
using Mdl.Systems;
using Meta.Util;
using UnityEngine;

namespace Mdl.Ui.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000957")]
	public class PlayerNavigationView : MonoBehaviour, IFtueElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003794")]
		[SerializeField]
		private PlayerNavigation _navigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003795")]
		[SerializeField]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003796")]
		[SerializeField]
		private VirtualJoystick _joystick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003797")]
		[SerializeField]
		private VirtualJoystickTutorial _joystickTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003798")]
		[SerializeField]
		private VirtualJoystick _fullscreenJoystick;

		[Cpp2IlInjected.Token(Token = "0x6003ACC")]
		[Cpp2IlInjected.Address(RVA = "0xE10030", Offset = "0xE0EA30", VA = "0x180E10030")]
		private void Start()
		{
			Cutscene.OnStartedPlaying += OnCutsceneStart;
			Cutscene.OnFinishedPlaying += OnCutsceneFinished;
			PlayerNavigation navigation = _navigation;
			PlayerNavigation.TaskQueued value = TaskQueued;
			navigation.OnTaskQueued += value;
			PlayerNavigation navigation2 = _navigation;
			PlayerNavigation.ControlSchemeChanged value2 = SetControlScheme;
			navigation2.OnControlSchemeChanged += value2;
			PlayerNavigation navigation3 = _navigation;
			PlayerNavigation.ControlChanged value3 = UpdateJoystick;
			navigation3.OnControlChanged += value3;
			Input.RegisterAxisMobile(_playerConfig.verticalAxis);
			Input.RegisterAxisMobile(_playerConfig.horizontalAxis);
			PlayerNavigationConfig playerConfig = _playerConfig;
			VirtualJoystick fullscreenJoystick = _fullscreenJoystick;
			string text = (fullscreenJoystick.horizontalAxis = playerConfig.horizontalAxis);
			PlayerNavigationConfig playerConfig2 = _playerConfig;
			VirtualJoystick fullscreenJoystick2 = _fullscreenJoystick;
			string text2 = (fullscreenJoystick2.verticalAxis = playerConfig2.verticalAxis);
			IControlScheme _003CControlScheme_003Ek__BackingField = _navigation.ControlScheme;
			VirtualJoystick fullscreenJoystick3 = _fullscreenJoystick;
			Transform transform = (fullscreenJoystick3.center3DTransform = SystemRoot.Instance._avatar.transform);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003ACD")]
		[Cpp2IlInjected.Address(RVA = "0xE0FA20", Offset = "0xE0E420", VA = "0x180E0FA20")]
		private void Awake()
		{
			FtueEventListener.RegisterElement(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003ACE")]
		[Cpp2IlInjected.Address(RVA = "0xE0FC20", Offset = "0xE0E620", VA = "0x180E0FC20")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_007e
			FtueEventListener.UnregisterElement(this);
			Cutscene.OnStartedPlaying -= OnCutsceneStart;
			Cutscene.OnFinishedPlaying -= OnCutsceneFinished;
			PlayerNavigation navigation = _navigation;
			PlayerNavigation.TaskQueued value = TaskQueued;
			navigation.OnTaskQueued -= value;
			PlayerNavigation navigation2 = _navigation;
			PlayerNavigation.ControlSchemeChanged value2 = SetControlScheme;
			navigation2.OnControlSchemeChanged -= value2;
			PlayerNavigation navigation3 = _navigation;
			PlayerNavigation.ControlChanged value3 = UpdateJoystick;
			navigation3.OnControlChanged -= value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003ACF")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0")]
		private void OnCutsceneStart(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD0")]
		[Cpp2IlInjected.Address(RVA = "0xE0FBF0", Offset = "0xE0E5F0", VA = "0x180E0FBF0")]
		private void OnCutsceneFinished(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_000d
			base.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD1")]
		[Cpp2IlInjected.Address(RVA = "0xE0FE40", Offset = "0xE0E840", VA = "0x180E0FE40")]
		private void SetControlScheme(ControlSchemeType controlScheme)
		{
			//Discarded unreachable code: IL_0057
			_fullscreenJoystick.Release();
			_joystick.Release();
			GameObject gameObject = _joystick.gameObject;
			bool active = controlScheme == ControlSchemeType.Vpad;
			gameObject.SetActive(active);
			VirtualJoystick fullscreenJoystick = _fullscreenJoystick;
			if (controlScheme != ControlSchemeType.HookedCamera)
			{
			}
			bool flag2 = (fullscreenJoystick.enabled = _playerConfig.allowMoveAxesInHookedMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD2")]
		[Cpp2IlInjected.Address(RVA = "0xE103C0", Offset = "0xE0EDC0", VA = "0x180E103C0")]
		private void UpdateJoystick(bool controlOverriden)
		{
			//Discarded unreachable code: IL_004f
			if (!controlOverriden)
			{
				IControlScheme _003CControlScheme_003Ek__BackingField = _navigation.ControlScheme;
				return;
			}
			_fullscreenJoystick.Release();
			_joystick.Release();
			GameObject gameObject = _joystick.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			VirtualJoystick fullscreenJoystick = _fullscreenJoystick;
			int num = ((fullscreenJoystick.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD3")]
		[Cpp2IlInjected.Address(RVA = "0xE0FA80", Offset = "0xE0E480", VA = "0x180E0FA80")]
		private void InitConfig()
		{
			PlayerNavigationConfig playerConfig = _playerConfig;
			VirtualJoystick fullscreenJoystick = _fullscreenJoystick;
			string text = (fullscreenJoystick.horizontalAxis = playerConfig.horizontalAxis);
			PlayerNavigationConfig playerConfig2 = _playerConfig;
			VirtualJoystick fullscreenJoystick2 = _fullscreenJoystick;
			string text2 = (fullscreenJoystick2.verticalAxis = playerConfig2.verticalAxis);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD4")]
		[Cpp2IlInjected.Address(RVA = "0xE103A0", Offset = "0xE0EDA0", VA = "0x180E103A0")]
		private void TaskQueued(PlayerTask task, int index)
		{
			//Discarded unreachable code: IL_000c
			_fullscreenJoystick.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD6")]
		[Cpp2IlInjected.Address(RVA = "0xE0FED0", Offset = "0xE0E8D0", VA = "0x180E0FED0", Slot = "4")]
		public bool ShouldActivateFtue(FtueStep step)
		{
			if ((object)step == null)
			{
				return 0 != 0;
			}
			int num = 0;
			return (object)step != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD7")]
		[Cpp2IlInjected.Address(RVA = "0xE0F900", Offset = "0xE0E300", VA = "0x180E0F900", Slot = "5")]
		[AsyncStateMachine(typeof(_003CActivateFtue_003Ed__16))]
		public Task ActivateFtue(FtueStep step, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD8")]
		[Cpp2IlInjected.Address(RVA = "0xE0FE20", Offset = "0xE0E820", VA = "0x180E0FE20")]
		private void RemoveTutorialStep()
		{
			//Discarded unreachable code: IL_000c
			_joystickTutorial.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD9")]
		[Cpp2IlInjected.Address(RVA = "0xE0FF50", Offset = "0xE0E950", VA = "0x180E0FF50")]
		private void ShowTutorialStep()
		{
			//Discarded unreachable code: IL_0050
			VirtualJoystickTutorial joystickTutorial = _joystickTutorial;
			VirtualJoystick joystick = _joystick;
			joystickTutorial.Show(joystick);
			VirtualJoystick joystick2 = _joystick;
			VirtualJoystick.OnJoystickChangeStateDelegate value = JoystickStateChanged;
			joystick2.OnJoystickChangeState -= value;
			VirtualJoystick joystick3 = _joystick;
			VirtualJoystick.OnJoystickChangeStateDelegate value2 = JoystickStateChanged;
			joystick3.OnJoystickChangeState += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADA")]
		[Cpp2IlInjected.Address(RVA = "0xE0FAE0", Offset = "0xE0E4E0", VA = "0x180E0FAE0")]
		private void JoystickStateChanged(bool active)
		{
			//Discarded unreachable code: IL_0060
			if (!active)
			{
				VirtualJoystickTutorial joystickTutorial = _joystickTutorial;
				VirtualJoystick joystick = _joystick;
				joystickTutorial.Show(joystick);
				VirtualJoystick joystick2 = _joystick;
				VirtualJoystick.OnJoystickChangeStateDelegate value = JoystickStateChanged;
				joystick2.OnJoystickChangeState -= value;
				VirtualJoystick joystick3 = _joystick;
				VirtualJoystick.OnJoystickChangeStateDelegate value2 = JoystickStateChanged;
				joystick3.OnJoystickChangeState += value2;
			}
			else
			{
				_joystickTutorial.Hide();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlayerNavigationView()
		{
		}
	}
}
