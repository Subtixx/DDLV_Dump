using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.Audio;
using Mdl.Characters;
using Mdl.Graphic.Weather;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000606")]
	public class ProfessionChangedMenu : TemplateMenu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002176")]
		[SerializeField]
		[Header("Visuals")]
		private ImageHelper _professionIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002177")]
		[SerializeField]
		private TextBase _professionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002178")]
		[SerializeField]
		private TextBase _professionDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002179")]
		[SerializeField]
		[Header("Components")]
		private PressAnyKey _pressAnyKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400217A")]
		[SerializeField]
		[Header("Audio")]
		private AK.Wwise.Event changeProfessionJingleStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400217B")]
		[SerializeField]
		private AK.Wwise.Event changeProfessionJingleStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400217C")]
		private LevelUpMenu.ProfessionSelectionParam _professionSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400217D")]
		private Mdl.Characters.Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400217E")]
		private Meta.Character _characterData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400217F")]
		private Transform _characterTargetToLookAtOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002180")]
		private LookAtBehaviour _characterLookAtBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002181")]
		private bool _characterWasEnable;

		[Cpp2IlInjected.Token(Token = "0x6002783")]
		[Cpp2IlInjected.Address(RVA = "0xE1CB80", Offset = "0xE1B580", VA = "0x180E1CB80", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_006b
			//IL_0030: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			base.OnPush(stack, param);
			AK.Wwise.Event @event = changeProfessionJingleStart;
			GameObject gameObject = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
			uint num = @event.Post(gameObject);
			int num2 = 0;
			_professionSelection = (LevelUpMenu.ProfessionSelectionParam)num2;
			if (param != null)
			{
				if (param.Params[0] != null)
				{
					int num3 = 0;
				}
				_professionSelection = (LevelUpMenu.ProfessionSelectionParam)num2;
			}
			Transform anchor = SystemRoot.Instance._playerCamera.transform;
			int num4 = 0;
			WeatherController.SetAnchor(anchor, (Vector3)num4);
		}

		[Cpp2IlInjected.Token(Token = "0x6002784")]
		[Cpp2IlInjected.Address(RVA = "0xE1C400", Offset = "0xE1AE00", VA = "0x180E1C400", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0146
			//IL_0039: Expected I4, but got O
			//IL_0048: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			base.OnFocusIn();
			LevelUpMenu.ProfessionSelectionParam professionSelection = _professionSelection;
			if (professionSelection != null)
			{
				Item _003CCharacterItem_003Ek__BackingField = professionSelection.CharacterItem;
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
				if (characterInstance != null)
				{
					bool active = characterInstance.Active;
				}
				_characterWasEnable = (byte)(int)characterInstance != 0;
				if (characterInstance != null)
				{
				}
				int num = 0;
				_character = (Mdl.Characters.Character)num;
				Client client = default(Client);
				ProfileWorld world_ = client.profile.world_;
				Meta.Character characterData = default(Meta.Character);
				_characterData = characterData;
				Meta.Character characterData2 = _characterData;
				ImageHelper professionIcon = _professionIcon;
				string text = (professionIcon.IconAddress = characterData2.Profession.iconAddress_);
				_professionIcon.Load();
				Meta.Character characterData3 = _characterData;
				TextBase professionName = _professionName;
				string displayName_ = characterData3.Profession.displayName_;
				int num2 = 0;
				string text3 = (professionName.StringID = LocalizationManager.FromStringID(displayName_, (IResolver)num2));
				Meta.Character characterData4 = _characterData;
				TextBase professionDesc = _professionDesc;
				string description_ = characterData4.Profession.description_;
				int num3 = 0;
				string text5 = (professionDesc.StringID = LocalizationManager.FromStringID(description_, (IResolver)num3));
				((Menu)this).IsDataUpToDate = true;
				UnityEvent onAnyKeyPressed = _pressAnyKey.OnAnyKeyPressed;
				UnityAction call = ContinueButtonClick;
				onAnyKeyPressed.AddListener(call);
				_pressAnyKey.StartCheckForAnyInput();
				CancellationToken cancellationToken = base.CancellationToken;
				int num4 = 0;
				int num5 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002785")]
		[Cpp2IlInjected.Address(RVA = "0xE1C8C0", Offset = "0xE1B2C0", VA = "0x180E1C8C0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_002b
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
			UnityEvent onAnyKeyPressed = _pressAnyKey.OnAnyKeyPressed;
			UnityAction call = ContinueButtonClick;
			onAnyKeyPressed.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002786")]
		[Cpp2IlInjected.Address(RVA = "0xE1C970", Offset = "0xE1B370", VA = "0x180E1C970", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_009c
			//IL_0031: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			AK.Wwise.Event @event = changeProfessionJingleStop;
			GameObject gameObject = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
			uint num = @event.Post(gameObject);
			LookAtBehaviour characterLookAtBehaviour = _characterLookAtBehaviour;
			int num2 = 0;
			if (characterLookAtBehaviour != (UnityEngine.Object)num2)
			{
				LookAtBehaviour characterLookAtBehaviour2 = _characterLookAtBehaviour;
				Transform transform = (characterLookAtBehaviour2.Target = _characterTargetToLookAtOrigin);
			}
			Mdl.Characters.Character character = _character;
			int num3 = 0;
			if (character != (UnityEngine.Object)num3)
			{
				GameObject _003CgameObject_003Ek__BackingField = _character.gameObject;
				bool characterWasEnable = _characterWasEnable;
				_003CgameObject_003Ek__BackingField.SetActive(characterWasEnable);
			}
			int cull = 0;
			CullAvatar((byte)cull != 0);
			int num4 = 0;
			WeatherController.ResetAnchor();
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6002787")]
		[Cpp2IlInjected.Address(RVA = "0xE1CE30", Offset = "0xE1B830", VA = "0x180E1CE30")]
		[AsyncStateMachine(typeof(_003CPlayAnimations_003Ed__16))]
		private Task PlayAnimations(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002788")]
		[Cpp2IlInjected.Address(RVA = "0xE1C1D0", Offset = "0xE1ABD0", VA = "0x180E1C1D0")]
		private void CullAvatar(bool cull)
		{
			string[] array;
			do
			{
				array = new string[1];
			}
			while ("Player" != null && array == null);
			array[0] = "Player";
			int mask = LayerMask.GetMask(array);
			if (!cull)
			{
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				int num = (playerCamera.cullingMask = playerCamera.cullingMask);
				return;
			}
			int cullingMask2 = SystemRoot.Instance._playerCamera.cullingMask;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002789")]
		[Cpp2IlInjected.Address(RVA = "0xE1BFA0", Offset = "0xE1A9A0", VA = "0x180E1BFA0")]
		private void ContinueButtonClick()
		{
			//Discarded unreachable code: IL_002a
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu bottom = menuStack.Bottom;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600278A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BE80", Offset = "0xE1A880", VA = "0x180E1BE80")]
		[AsyncStateMachine(typeof(_003CCloseTask_003Ed__19))]
		private Task CloseTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600278B")]
		[Cpp2IlInjected.Address(RVA = "0xE1CF50", Offset = "0xE1B950", VA = "0x180E1CF50")]
		public void RefreshVisuals()
		{
			//Discarded unreachable code: IL_0091
			//IL_0051: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			ImageHelper professionIcon = _professionIcon;
			string text = (professionIcon.IconAddress = _characterData.Profession.iconAddress_);
			_professionIcon.Load();
			Meta.Character characterData = _characterData;
			TextBase professionName = _professionName;
			string displayName_ = characterData.Profession.displayName_;
			int num = 0;
			string text3 = (professionName.StringID = LocalizationManager.FromStringID(displayName_, (IResolver)num));
			Meta.Character characterData2 = _characterData;
			TextBase professionDesc = _professionDesc;
			string description_ = characterData2.Profession.description_;
			int num2 = 0;
			string text5 = (professionDesc.StringID = LocalizationManager.FromStringID(description_, (IResolver)num2));
		}

		[Cpp2IlInjected.Token(Token = "0x600278C")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF70", Offset = "0xE19970", VA = "0x180E1AF70")]
		public ProfessionChangedMenu()
		{
		}
	}
}
