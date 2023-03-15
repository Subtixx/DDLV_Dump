using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Characters;
using Mdl.Graphic.Weather;
using Mdl.Systems;
using mdl.UI;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002E7")]
	[RequiredAllNotNull]
	public class CharacterSummonMenu : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000E0D")]
		private CharacterSummonMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000E0E")]
		private MapCameraTransform _positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000E0F")]
		[Nulllable]
		[SerializeField]
		private Camera _mcCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000E10")]
		[SerializeField]
		private CharacterSummonEffect _vfxSummon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000E11")]
		[Space]
		public Vector3 SpawnedCharacter_Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000E12")]
		public Vector3 SpawnedCharacter_Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000E13")]
		[SerializeField]
		private AK.Wwise.Event _unlockCharacterEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000E14")]
		[Space]
		public bool IsDebugMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000E16")]
		private CancellationTokenSource autoPopSelfCTS;

		[Cpp2IlInjected.Token(Token = "0x1700033A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x111"), Cpp2IlInjected.Token(Token = "0x4000E15")]
		private bool MustRestoreCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60012B1")]
			[Cpp2IlInjected.Address(RVA = "0xFFEDD0", Offset = "0xFFD7D0", VA = "0x180FFEDD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012B2")]
			[Cpp2IlInjected.Address(RVA = "0xFFEDE0", Offset = "0xFFD7E0", VA = "0x180FFEDE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60012AF")]
		[Cpp2IlInjected.Address(RVA = "0xFFDAA0", Offset = "0xFFC4A0", VA = "0x180FFDAA0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_01a4, IL_01aa, IL_01b0, IL_01b6, IL_01bc, IL_01ce
			//IL_00ee: Expected O, but got I4
			//IL_013e: Expected F4, but got I4
			//IL_0180: Expected O, but got I4
			Vector3 vector = default(Vector3);
			Transform transform3 = default(Transform);
			GameObject gameObject = default(GameObject);
			while (true)
			{
				int num = 0;
				base.OnPush(stack, param);
				int num2 = 0;
				UiRoot.Instance._worldCanvas.Hide();
				int num3 = 0;
				CutSceneSkipper cutSceneSkipper = UiRoot.Instance.CutSceneSkipper;
				Action callback = OnCutsceneCancelled;
				cutSceneSkipper.Show(callback);
				if (param == null)
				{
				}
				int num4 = 0;
				_param = (CharacterSummonMenuParam)param;
				CharacterSummonMenuParam param2 = _param;
				if (param2 == null)
				{
					return;
				}
				Item characterItem = param2.CharacterItem;
				SetupSound(characterItem);
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				int num5 = ((playerCamera.enabled = false) ? 1 : 0);
				Camera playerCamera2 = SystemRoot.Instance._playerCamera;
				Transform parent = SystemRoot.Instance.transform;
				Camera camera = (_mcCamera = UnityEngine.Object.Instantiate(playerCamera2, parent));
				MapCameraTransform mapCameraTransform = (_positions = UnityEngine.Object.FindObjectOfType<MapCameraTransform>());
				Transform newCharacterSpawningTransform = _positions.NewCharacterSpawningTransform;
				float z = vector.z;
				Transform newCharacterSpawningTransform2 = _positions.NewCharacterSpawningTransform;
				int num6 = 0;
				WeatherController.SetAnchor(newCharacterSpawningTransform2, (Vector3)num6);
				AkAudioListener component = _mcCamera.GetComponent<AkAudioListener>();
				int isDefaultListener = 0;
				component.SetIsDefaultListener((byte)isDefaultListener != 0);
				int num7 = ((component.enabled = false) ? 1 : 0);
				Transform transform = _mcCamera.transform;
				Transform transform2 = _mcCamera.transform;
				int num8 = 0;
				Quaternion quaternion = Quaternion.Euler(z, -1f, num8);
				IEnumerator enumerator = SystemRoot.Instance._playerCamera.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num9 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num10 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					AkAudioListener component2 = transform3.GetComponent<AkAudioListener>();
					int num11 = 0;
					if (!(component2 != (UnityEngine.Object)num11))
					{
						continue;
					}
					gameObject = component2.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				if ((object)gameObject != null)
				{
					int num12 = 0;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012B0")]
		[Cpp2IlInjected.Address(RVA = "0xFFE780", Offset = "0xFFD180", VA = "0x180FFE780")]
		private void SetupCharacter()
		{
			//Discarded unreachable code: IL_0082
			//IL_0028: Expected O, but got I4
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			Item characterItem = _param.CharacterItem;
			Character character = system.GetCharacter(characterItem);
			int num = 0;
			if (character != (UnityEngine.Object)num)
			{
				character.TalkingToRequestor = true;
				int num2 = 0;
				character.EnableNavMeshAgent((byte)num2 != 0);
				Transform transform = character.gameObject.transform;
				Transform newCharacterSpawningTransform = _positions.NewCharacterSpawningTransform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform2 = character.gameObject.transform;
				Transform newCharacterSpawningTransform2 = _positions.NewCharacterSpawningTransform;
			}
			MustRestoreCharacter = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60012B3")]
		[Cpp2IlInjected.Address(RVA = "0xFFE540", Offset = "0xFFCF40", VA = "0x180FFE540")]
		private void RestoreCharacter()
		{
			//Discarded unreachable code: IL_007b
			//IL_0028: Expected O, but got I4
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			Item characterItem = _param.CharacterItem;
			Character character = system.GetCharacter(characterItem);
			int num = 0;
			if (character != (UnityEngine.Object)num)
			{
				if (!character.gameObject.activeSelf)
				{
					character.gameObject.SetActive(value: true);
				}
				character.AnimatorComponent.enabled = true;
				int num2 = ((character.TalkingToRequestor = false) ? 1 : 0);
				character.EnableNavMeshAgent(enabled: true);
			}
			SystemRoot.Instance._playerCamera.enabled = true;
			MustRestoreCharacter = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60012B4")]
		[Cpp2IlInjected.Address(RVA = "0xFFE9C0", Offset = "0xFFD3C0", VA = "0x180FFE9C0")]
		private void SetupSound(Item characterItem)
		{
			//Discarded unreachable code: IL_0085
			//IL_0014: Expected O, but got I4
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int num = 0;
			Character character = default(Character);
			if (!(character == (UnityEngine.Object)num))
			{
				Switch ipSwitch = character.ipSwitch;
				GameObject value = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
				ipSwitch.SetValue(value);
				Switch characterSwitch = character.characterSwitch;
				GameObject value2 = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
				characterSwitch.SetValue(value2);
				SystemRoot.Instance.GetSystem<AudioManager>().PushLocation(AudioManager.Location.CharactersUnlock);
				AK.Wwise.Event unlockCharacterEvent = _unlockCharacterEvent;
				GameObject gameObject = base.gameObject;
				uint num2 = unlockCharacterEvent.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012B5")]
		[Cpp2IlInjected.Address(RVA = "0xFFD5E0", Offset = "0xFFBFE0", VA = "0x180FFD5E0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_00ed, IL_00f3, IL_00f9, IL_00ff, IL_0111
			//IL_0069: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00d0: Expected O, but got I4
			Transform transform = default(Transform);
			GameObject gameObject = default(GameObject);
			while (true)
			{
				int num = 0;
				base.OnPop();
				int num2 = 0;
				UiRoot.Instance.CutSceneSkipper.Hide();
				if ((MustRestoreCharacter ? 1 : 0) != num)
				{
					RestoreCharacter();
				}
				SystemRoot.Instance.GetSystem<AudioManager>().PopLocation();
				int num3 = 0;
				WeatherController.ResetAnchor();
				int num4 = 0;
				Canvas component = UiRoot.Instance._menuStack.GetComponent<Canvas>();
				int num5 = (int)(component.renderMode = RenderMode.ScreenSpaceOverlay);
				int num6 = 0;
				component.worldCamera = (Camera)num6;
				Camera mcCamera = _mcCamera;
				int num7 = 0;
				if (mcCamera != (UnityEngine.Object)num7)
				{
					UnityEngine.Object.Destroy(_mcCamera.gameObject);
				}
				IEnumerator enumerator = SystemRoot.Instance._playerCamera.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num8 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num9 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					AkAudioListener component2 = transform.GetComponent<AkAudioListener>();
					int num10 = 0;
					if (!(component2 != (UnityEngine.Object)num10))
					{
						continue;
					}
					gameObject = component2.gameObject;
					gameObject.SetActive(value: true);
				}
				if ((object)gameObject == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012B6")]
		[Cpp2IlInjected.Address(RVA = "0xFFD4B0", Offset = "0xFFBEB0", VA = "0x180FFD4B0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0046
			base.OnFocusIn();
			RefreshDisplay();
			SetupCharacter();
			CharacterSummonEffect vfxSummon = _vfxSummon;
			Action callback = OnAfterSummonEffect;
			vfxSummon.Play(callback);
			base.IsDataUpToDate = true;
			if ((long)_param == 0)
			{
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012B7")]
		[Cpp2IlInjected.Address(RVA = "0xFFD590", Offset = "0xFFBF90", VA = "0x180FFD590", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_001f
			base.OnFocusOut(popAfterFocusOut, animate);
			if (popAfterFocusOut)
			{
				int num = 0;
				UiRoot.Instance._worldCanvas.Show();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012B8")]
		[Cpp2IlInjected.Address(RVA = "0x869280", Offset = "0x867C80", VA = "0x180869280", Slot = "29")]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			return base.PreFocusOut(popAfterPreFocusOut);
		}

		[Cpp2IlInjected.Token(Token = "0x60012B9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60012BA")]
		[Cpp2IlInjected.Address(RVA = "0xE1AEF0", Offset = "0xE198F0", VA = "0x180E1AEF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			base.UnregisterFocusedListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x60012BB")]
		[Cpp2IlInjected.Address(RVA = "0xFFE230", Offset = "0xFFCC30", VA = "0x180FFE230")]
		private void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00f2
			//IL_00d9: Expected O, but got I4
			bool flag = default(bool);
			if (_param == null || !flag)
			{
				return;
			}
			CharacterSummonMenuParam param = _param;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Character)
			{
				Item characterItem = _param.CharacterItem;
				CharacterManager characterManager = default(CharacterManager);
				Character character = characterManager.GetCharacter(characterItem);
				Camera mcCamera = _mcCamera;
				CharacterSummonEffect vfxSummon = _vfxSummon;
				Transform parent = mcCamera.transform.parent;
				MapCameraTransform positions = _positions;
				vfxSummon._container = parent;
				vfxSummon._character = character;
				vfxSummon._positions = positions;
				Transform transform = vfxSummon.transform;
				Transform transform3 = (transform.parentInternal = vfxSummon._character.CharacterVisualNodes.Chest.transform);
				Transform transform4 = vfxSummon.transform;
				float z = Vector3.zero.z;
				Transform transform5 = vfxSummon.transform;
				float z2 = Vector3.zero.z;
				int num = 0;
				if (character != (UnityEngine.Object)num)
				{
					GameObject _003CgameObject_003Ek__BackingField = character.gameObject;
					int active = 0;
					_003CgameObject_003Ek__BackingField.SetActive((byte)active != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012BC")]
		[Cpp2IlInjected.Address(RVA = "0xFFD360", Offset = "0xFFBD60", VA = "0x180FFD360")]
		internal void PlayAnimation()
		{
			//Discarded unreachable code: IL_0022
			SetupCharacter();
			CharacterSummonEffect vfxSummon = _vfxSummon;
			Action callback = OnAfterSummonEffect;
			vfxSummon.Play(callback);
		}

		[Cpp2IlInjected.Token(Token = "0x60012BD")]
		[Cpp2IlInjected.Address(RVA = "0xFFD360", Offset = "0xFFBD60", VA = "0x180FFD360")]
		private void OnCharacterSummon()
		{
			//Discarded unreachable code: IL_0022
			SetupCharacter();
			CharacterSummonEffect vfxSummon = _vfxSummon;
			Action callback = OnAfterSummonEffect;
			vfxSummon.Play(callback);
		}

		[Cpp2IlInjected.Token(Token = "0x60012BE")]
		[Cpp2IlInjected.Address(RVA = "0xFFD400", Offset = "0xFFBE00", VA = "0x180FFD400")]
		private void OnCutsceneCancelled()
		{
			//Discarded unreachable code: IL_0045
			//IL_0032: Expected I4, but got I8
			if (!autoPopSelfCTS.IsCancellationRequested)
			{
				autoPopSelfCTS.Cancel();
				CharacterSummonEffect vfxSummon = _vfxSummon;
				if (vfxSummon._vfxCnt > 0)
				{
					vfxSummon._vfxCnt = 0;
					vfxSummon.CleanUp();
				}
				CleanSummonEffect();
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012BF")]
		[Cpp2IlInjected.Address(RVA = "0xFFCFC0", Offset = "0xFFB9C0", VA = "0x180FFCFC0")]
		private void OnAfterSummonEffect()
		{
			//Discarded unreachable code: IL_0074
			//IL_0028: Expected O, but got I4
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			Item characterItem = _param.CharacterItem;
			Character character = system.GetCharacter(characterItem);
			int num = 0;
			if (character != (UnityEngine.Object)num)
			{
				character.gameObject.SetActive(value: true);
				character.AnimatorComponent.SetTrigger("Celebrate");
				SystemRoot.Instance.GetSystem<AudioManager>().PlayCharacterVO(character, "Celebrate");
				CancellationToken token = autoPopSelfCTS.Token;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012C0")]
		[Cpp2IlInjected.Address(RVA = "0xFFCCF0", Offset = "0xFFB6F0", VA = "0x180FFCCF0")]
		[AsyncStateMachine(typeof(_003CAutomaticPopSelfFlowAsync_003Ed__28))]
		private Task AutomaticPopSelfFlowAsync(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60012C1")]
		[Cpp2IlInjected.Address(RVA = "0xFFCE10", Offset = "0xFFB810", VA = "0x180FFCE10")]
		private void CleanSummonEffect()
		{
			//Discarded unreachable code: IL_0077
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			CharacterSummonEffect vfxSummon = _vfxSummon;
			int num = 0;
			if (!(vfxSummon != (UnityEngine.Object)num))
			{
				return;
			}
			GameObject gameObject = _vfxSummon.gameObject;
			int num2 = 0;
			if (gameObject != (UnityEngine.Object)num2)
			{
				CharacterSummonEffect vfxSummon2 = _vfxSummon;
				GameObject vfxFireworks = vfxSummon2.VfxFireworks;
				int num3 = 0;
				if (vfxFireworks != (UnityEngine.Object)num3 && vfxSummon2.VfxFireworks.activeSelf)
				{
					UnityEngine.Object.Destroy(vfxSummon2.VfxFireworks);
				}
				UnityEngine.Object.Destroy(_vfxSummon.gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012C2")]
		[Cpp2IlInjected.Address(RVA = "0xFFED00", Offset = "0xFFD700", VA = "0x180FFED00")]
		public unsafe CharacterSummonMenu()
		{
			//IL_000c: Expected F4, but got I8
			//IL_0007: Expected native int or pointer, but got O
			ulong num = default(ulong);
			((Vector3*)(IntPtr)SpawnedCharacter_Rotation)->z = (long)num;
			autoPopSelfCTS = new CancellationTokenSource();
			base._002Ector();
		}
	}
}
