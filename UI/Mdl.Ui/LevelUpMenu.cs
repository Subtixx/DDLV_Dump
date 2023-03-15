using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Character;
using Definitions.Items;
using Definitions.Rewards;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Graphic.Weather;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005F6")]
	public class LevelUpMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20005F7")]
		public class ProfessionSelectionParam
		{
			[Cpp2IlInjected.Token(Token = "0x170005F5")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002141")]
			public Item CharacterItem
			{
				[Cpp2IlInjected.Token(Token = "0x600274C")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600274D")]
			[Cpp2IlInjected.Address(RVA = "0xAFD3A0", Offset = "0xAFBDA0", VA = "0x180AFD3A0")]
			public ProfessionSelectionParam(Item characterItem)
			{
				//IL_0014: Expected O, but got I4
				int itemID = characterItem.ItemID;
				base._002Ector();
				CharacterItem = (Item)itemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20005F8")]
		public enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x4002143")]
			Reset,
			[Cpp2IlInjected.Token(Token = "0x4002144")]
			CharacterLevelUpBeforeProfession,
			[Cpp2IlInjected.Token(Token = "0x4002145")]
			CharacterLevelUpAfterProfession,
			[Cpp2IlInjected.Token(Token = "0x4002146")]
			CharacterLevelUpProfessionSelection,
			[Cpp2IlInjected.Token(Token = "0x4002147")]
			PlayerLevelUp,
			[Cpp2IlInjected.Token(Token = "0x4002148")]
			CharacterProfessionSelectionOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002118")]
		private Phase _currentPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4002119")]
		private bool _characterWasEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400211A")]
		private Mdl.Characters.Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400211B")]
		private Meta.Character _characterData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400211C")]
		private Transform _characterTargetToLookAtOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400211D")]
		private Transform _avatarTargetToLookAtOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400211E")]
		private LookAtBehaviour _characterLookAtBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400211F")]
		private LookAtBehaviour _avatarLookAtBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002120")]
		private AddedFriendshipSummary _friendshipSummary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002121")]
		private ProfessionSelectionParam _professionSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002122")]
		private List<FriendshipLevel> _friendshipLevels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002123")]
		private CharacterLevelRewardItem _currentCharacterLevelReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002124")]
		private bool _isInProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x4002125")]
		private bool _isInAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4002126")]
		private ProfessionButton _selectedProfession;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4002127")]
		private ProfessionButton _currentlySelectedProfession;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4002128")]
		private ProfessionButton[] _professionButtonList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4002129")]
		private Coroutine _waitingForAnyKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400212A")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400212B")]
		[SerializeField]
		private CustomElement _friendship;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400212C")]
		[SerializeField]
		private RecycleBin _recycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400212D")]
		[SerializeField]
		private RectTransform _characterLevelRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400212E")]
		[SerializeField]
		private HorizontalLayoutGroup _characterLevelRewardsLayoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400212F")]
		[SerializeField]
		private RectTransform _playerLevelRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4002130")]
		[SerializeField]
		private RectTransform _progressTotal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4002131")]
		[SerializeField]
		private RectTransform _progressCurrent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4002132")]
		[SerializeField]
		private RectTransform _progressAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4002133")]
		[SerializeField]
		private RectTransform _professions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4002134")]
		[SerializeField]
		private RectTransform _professionsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4002135")]
		[SerializeField]
		private TextBase _professionDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4002136")]
		[SerializeField]
		private CustomElement _professionBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4002137")]
		[SerializeField]
		private TextMeshProUGUI _pressAnyKeyLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4002138")]
		[SerializeField]
		private RectTransformHelper _bgRectHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4002139")]
		[SerializeField]
		private CustomButton _continue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400213A")]
		[SerializeField]
		private GameObject _continueShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400213B")]
		[SerializeField]
		[Header("Bg Offset")]
		private float _offsetTop = -45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x400213C")]
		[SerializeField]
		private float _offsetBottom = -85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400213D")]
		public UnityEvent[] OnPhases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400213E")]
		private bool _professionChoosed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400213F")]
		private Toolbox.TemporarySwitchToolScope removeToolScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4002140")]
		private IDisposable activeCameraModifiers;

		[Cpp2IlInjected.Token(Token = "0x6002727")]
		[Cpp2IlInjected.Address(RVA = "0x13299A0", Offset = "0x13283A0", VA = "0x1813299A0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0078
			//IL_0011: Expected O, but got I4
			//IL_0018: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			base.OnPush(stack, param);
			int num = 0;
			_friendshipSummary = (AddedFriendshipSummary)num;
			_professionSelection = (ProfessionSelectionParam)num;
			if (param != null)
			{
				object obj = param.Params[0];
				if (obj == null)
				{
				}
				int num2 = 0;
				_friendshipSummary = (AddedFriendshipSummary)obj;
				if ((IntPtr)_friendshipSummary == (IntPtr)num)
				{
					object obj2 = param.Params[0];
					if (obj2 != null)
					{
						int num3 = 0;
					}
					_professionSelection = (ProfessionSelectionParam)obj2;
				}
			}
			Transform anchor = SystemRoot.Instance._playerCamera.transform;
			int num4 = 0;
			WeatherController.SetAnchor(anchor, (Vector3)num4);
		}

		[Cpp2IlInjected.Token(Token = "0x6002728")]
		[Cpp2IlInjected.Address(RVA = "0x1328E00", Offset = "0x1327800", VA = "0x181328E00", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0113
			//IL_0060: Expected O, but got I4
			base.OnFocusIn();
			AddedFriendshipSummary friendshipSummary = _friendshipSummary;
			if (friendshipSummary == null && _professionSelection == friendshipSummary)
			{
				return;
			}
			if (_professionSelection != null)
			{
			}
			Item _003CCharacterItem_003Ek__BackingField = friendshipSummary.CharacterItem;
			int num = 0;
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
			bool active = default(bool);
			if (characterInstance != null)
			{
				active = characterInstance.Active;
			}
			_characterWasEnable = active;
			if (characterInstance != null)
			{
			}
			int num2 = 0;
			_character = (Mdl.Characters.Character)num2;
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			Meta.Character characterData = default(Meta.Character);
			_characterData = characterData;
			if ((IntPtr)_professionSelection == (IntPtr)num)
			{
				AddedFriendshipSummary friendshipSummary2 = _friendshipSummary;
				if ((friendshipSummary2.CharacterLevelUp ? 1 : 0) != num || (friendshipSummary2.PlayerLevelUp ? 1 : 0) != num)
				{
					bool flag = _characterData.Profession != null;
				}
			}
			SetPhase(Phase.CharacterProfessionSelectionOnly);
			((Menu)this).IsDataUpToDate = true;
			if ((long)_professionSelection == 0)
			{
				AddedFriendshipSummary friendshipSummary3 = _friendshipSummary;
				if (friendshipSummary3.PlayerLevelUp)
				{
					int _003CPreviousPlayerXP_003Ek__BackingField = friendshipSummary3.PreviousPlayerXP;
					int num3 = 0;
				}
			}
			UnityEvent onClicked = _continue.OnClicked;
			UnityAction call = ContinueButtonClick;
			onClicked.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002729")]
		[Cpp2IlInjected.Address(RVA = "0x1329270", Offset = "0x1327C70", VA = "0x181329270", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_009b
			//IL_0017: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				removeToolScope = (Toolbox.TemporarySwitchToolScope)num;
			}
			IDisposable disposable = activeCameraModifiers;
			int num2 = 0;
			if (disposable != null)
			{
				activeCameraModifiers = (IDisposable)num2;
			}
			UnityEvent onClicked = _continue.OnClicked;
			UnityAction call = ContinueButtonClick;
			onClicked.RemoveListener(call);
			ProfessionButton[] professionButtonList = _professionButtonList;
			if (professionButtonList != null)
			{
				int length = professionButtonList.Length;
				if (num2 < length)
				{
					ProfessionButton.NewHighlightEvent highlightEvent = professionButtonList[num2].HighlightEvent;
					UnityAction<ProfessionButton> unityAction = (UnityAction<ProfessionButton>)(object)new UnityAction<T0>(ClearProfessionHighlight);
					((UnityEvent<T0>)(object)highlightEvent).RemoveListener((UnityAction<>)(object)unityAction);
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600272A")]
		[Cpp2IlInjected.Address(RVA = "0x1329480", Offset = "0x1327E80", VA = "0x181329480", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_00f7
			//IL_0027: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0087: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CAllowButtonClick_003Ed__52 _003CAllowButtonClick_003Ed__ = new _003CAllowButtonClick_003Ed__52(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAllowButtonClick_003Ed__._003C_003E4__this = this;
			StopCoroutine(_003CAllowButtonClick_003Ed__);
			LookAtBehaviour characterLookAtBehaviour = _characterLookAtBehaviour;
			int num = 0;
			if (characterLookAtBehaviour != (UnityEngine.Object)num)
			{
				LookAtBehaviour characterLookAtBehaviour2 = _characterLookAtBehaviour;
				Transform transform = (characterLookAtBehaviour2.Target = _characterTargetToLookAtOrigin);
			}
			LookAtBehaviour avatarLookAtBehaviour = _avatarLookAtBehaviour;
			int num2 = 0;
			if (avatarLookAtBehaviour != (UnityEngine.Object)num2)
			{
				LookAtBehaviour avatarLookAtBehaviour2 = _avatarLookAtBehaviour;
				Transform transform2 = (avatarLookAtBehaviour2.Target = _avatarTargetToLookAtOrigin);
			}
			Mdl.Characters.Character character = _character;
			int num3 = 0;
			if (character != (UnityEngine.Object)num3)
			{
				if (_currentPhase != Phase.CharacterProfessionSelectionOnly)
				{
					Mdl.Characters.Character character2 = _character;
					int num4 = ((character2.TalkingToRequestor = false) ? 1 : 0);
				}
				GameObject _003CgameObject_003Ek__BackingField = _character.gameObject;
				bool characterWasEnable = _characterWasEnable;
				_003CgameObject_003Ek__BackingField.SetActive(characterWasEnable);
			}
			int cull = 0;
			CullAvatar((byte)cull != 0);
			int num5 = 0;
			UiRoot.Instance.StopForceAllowShortcuts();
			int num6 = 0;
			WeatherController.ResetAnchor();
			base.OnPop();
			_recycleBin.Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x600272B")]
		[Cpp2IlInjected.Address(RVA = "0x132C030", Offset = "0x132AA30", VA = "0x18132C030")]
		private void SetPhase(Phase phase)
		{
			_isInProgress = true;
			_currentPhase = phase;
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600272C")]
		[Cpp2IlInjected.Address(RVA = "0x132A730", Offset = "0x1329130", VA = "0x18132A730")]
		private void RefreshData()
		{
			//Discarded unreachable code: IL_002d, IL_0038, IL_0052, IL_006b, IL_007e, IL_009e, IL_00d9, IL_0144, IL_0171, IL_018b, IL_01a4, IL_01b7
			//IL_00d1: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_011d: Expected O, but got I4
			if (_currentPhase == Phase.CharacterLevelUpBeforeProfession)
			{
				Dictionary<TextType, string> _003CTexts_003Ek__BackingField = _friendship.Texts;
				Client client = default(Client);
				int level_ = client.profile.player_.level_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600272D")]
		[Cpp2IlInjected.Address(RVA = "0x132AD10", Offset = "0x1329710", VA = "0x18132AD10")]
		private void RefreshDisplay()
		{
			//Discarded unreachable code: IL_000a, IL_0036, IL_003c, IL_004f, IL_0109, IL_0133, IL_013a, IL_0155, IL_015a, IL_0162
			//IL_0020: Expected I4, but got I8
			//IL_004c: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00c8: Expected I4, but got I8
			//IL_011b: Expected I4, but got I8
			if (_currentPhase == Phase.CharacterLevelUpBeforeProfession)
			{
				CanvasGroup component = _professions.GetComponent<CanvasGroup>();
				int num = 0;
				if (component != (UnityEngine.Object)num)
				{
					int num2 = ((component.blocksRaycasts = false) ? 1 : 0);
					int num3 = ((component.interactable = false) ? 1 : 0);
				}
				ulong num4 = default(ulong);
				_professions.gameObject.SetActive((byte)num4 != 0);
				RefreshProfessions();
				_continue.GetComponent<CanvasGroup>().alpha = 0.5f;
				CustomButton @continue = _continue;
				int num5 = ((@continue.IsInteractable = false) ? 1 : 0);
				_continue.GetComponent<FocusNavigationElement>().IgnoreThis = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600272E")]
		[Cpp2IlInjected.Address(RVA = "0x132BE80", Offset = "0x132A880", VA = "0x18132BE80")]
		private void SetBgOffset()
		{
			//Discarded unreachable code: IL_0042
			//IL_0010: Expected O, but got I4
			RectTransformHelper bgRectHelper = _bgRectHelper;
			int num = 0;
			if (bgRectHelper != (UnityEngine.Object)num)
			{
				RectTransformHelper bgRectHelper2 = _bgRectHelper;
				float num2 = (bgRectHelper2.OffSetTop = _offsetTop);
				RectTransformHelper bgRectHelper3 = _bgRectHelper;
				float num3 = (bgRectHelper3.OffSetBottom = _offsetBottom);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600272F")]
		[Cpp2IlInjected.Address(RVA = "0x1329E00", Offset = "0x1328800", VA = "0x181329E00")]
		[AsyncStateMachine(typeof(_003CPlayAnimations_003Ed__51))]
		private Task PlayAnimations(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002730")]
		[Cpp2IlInjected.Address(RVA = "0x13281F0", Offset = "0x1326BF0", VA = "0x1813281F0")]
		[IteratorStateMachine(typeof(_003CAllowButtonClick_003Ed__52))]
		private IEnumerator AllowButtonClick()
		{
			int _003C_003E1__state = default(int);
			_003CAllowButtonClick_003Ed__52 _003CAllowButtonClick_003Ed__ = new _003CAllowButtonClick_003Ed__52(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAllowButtonClick_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002731")]
		[Cpp2IlInjected.Address(RVA = "0x132B450", Offset = "0x1329E50", VA = "0x18132B450")]
		private void RefreshProfessions()
		{
			//Discarded unreachable code: IL_022a, IL_026a, IL_0276, IL_027c, IL_0282, IL_0288, IL_028e, IL_0294, IL_029a, IL_02a0, IL_02a6, IL_02ac, IL_02b2, IL_02b8, IL_02be, IL_02c4, IL_02ca, IL_02d0, IL_02d6, IL_02dc, IL_02e2, IL_02e8, IL_02ee
			//IL_0012: Expected O, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected I4, but got Unknown
			//IL_011a: Expected I4, but got I8
			//IL_014e: Expected O, but got I4
			//IL_0269: Expected O, but got I4
			uint num3 = default(uint);
			uint num4 = default(uint);
			ulong num5 = default(ulong);
			int num6 = default(int);
			while (true)
			{
				int num = 0;
				RectTransform professionsContent = _professionsContent;
				int num2 = 0;
				if (professionsContent == (UnityEngine.Object)num2)
				{
					return;
				}
				ProfessionButton[] array = (_professionButtonList = new ProfessionButton[(object)_characterData.get_AvailableProfessions()]);
				int childCount = _professionsContent.childCount;
				ICollection<ProfessionItemData> availableProfessions = (ICollection<ProfessionItemData>)_characterData.get_AvailableProfessions();
				childCount -= availableProfessions;
				RectTransform professions = _professions;
				int index = _professionsContent.childCount - 1;
				ProfessionButton component = professions.GetChild(index).GetComponent<ProfessionButton>();
				component.Release();
				RecycleBin recycleBin = _recycleBin;
				GameObject trash = component.gameObject;
				recycleBin.SendToBin(trash);
				ICollection<ProfessionItemData> availableProfessions2 = (ICollection<ProfessionItemData>)_characterData.get_AvailableProfessions();
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (availableProfessions2 != null)
				{
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_0224;
						}
						num++;
					}
					int childCount2 = _professionsContent.childCount;
					RecycleBin recycleBin2 = _recycleBin;
					Type typeFromHandle = typeof(ProfessionButton);
					RectTransform professionsContent2 = _professionsContent;
					recycleBin2.FindReusableOrNew(typeFromHandle, professionsContent2).SetActive((byte)num5 != 0);
					ProfessionButton item = _professionsContent.GetChild(num).GetComponent<ProfessionButton>();
					ProfessionButton professionButton = item;
					ProfessionButtonModel professionButtonModel = new ProfessionButtonModel();
					professionButtonModel.ProfessionItemData = (ProfessionItemData)num;
					((CustomButton)professionButton).Model = professionButtonModel;
					ProfessionButton professionButton2 = item;
					TextBase textBase = (professionButton2.Description = _professionDesc);
					UnityEvent onHighlighted = item.OnHighlighted;
					UnityAction call = delegate
					{
						//Discarded unreachable code: IL_0016
						LevelUpMenu levelUpMenu2 = this;
						ProfessionButton item3 = item;
						levelUpMenu2.SelectProfession(item3);
					};
					onHighlighted.AddListener(call);
					UnityEvent onDehighlighted = item.OnDehighlighted;
					UnityAction call2 = delegate
					{
						//IL_0009: Expected O, but got I4
						int num7 = 0;
						SelectProfession((ProfessionButton)num7);
					};
					onDehighlighted.AddListener(call2);
					UnityEvent onClicked = item.OnClicked;
					UnityAction call3 = delegate
					{
						//Discarded unreachable code: IL_0016
						LevelUpMenu levelUpMenu = this;
						ProfessionButton item2 = item;
						levelUpMenu.ConfirmProfession(item2);
					};
					onClicked.AddListener(call3);
					item.RefreshDisplay();
					FocusNavigationElement component2 = item.GetComponent<FocusNavigationElement>();
					RectTransform rectTransform = (RectTransform)(component2.FreeContainer = _content);
					ProfessionButton[] professionButtonList = _professionButtonList;
					if ((object)item != null && (object)component2 == null)
					{
						break;
					}
					goto IL_0224;
				}
				if (availableProfessions2 != null)
				{
					num6 = 0;
				}
				if (num == 0)
				{
					((RectTransform)num6).RebuildLayout();
					return;
				}
				continue;
				IL_0224:
				throw new IndexOutOfRangeException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002732")]
		[Cpp2IlInjected.Address(RVA = "0x13286A0", Offset = "0x13270A0", VA = "0x1813286A0")]
		private void ConfirmProfession(ProfessionButton item)
		{
			//Discarded unreachable code: IL_006f
			ProfessionButton[] professionButtonList = _professionButtonList;
			int num = 0;
			int length = professionButtonList.Length;
			if (num < length)
			{
				ProfessionButton professionButton = professionButtonList[num];
				if (professionButton != item)
				{
					professionButton.GetComponent<ProfessionButtonStateHandler>().RemoveSelection();
				}
				num++;
			}
			_currentlySelectedProfession = item;
			_continue.GetComponent<CanvasGroup>().alpha = 1f;
			_continue.IsInteractable = true;
			_continue.GetComponent<FocusNavigationElement>().IgnoreThis = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002733")]
		[Cpp2IlInjected.Address(RVA = "0x1328840", Offset = "0x1327240", VA = "0x181328840")]
		private void ContinueButtonClick()
		{
			//IL_0010: Expected O, but got I4
			ProfessionButton currentlySelectedProfession = _currentlySelectedProfession;
			int num = 0;
			if (currentlySelectedProfession != (UnityEngine.Object)num && _currentPhase == (Phase)(-3))
			{
				ApplyProfession();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002734")]
		[Cpp2IlInjected.Address(RVA = "0x1328260", Offset = "0x1326C60", VA = "0x181328260")]
		private void ApplyProfession()
		{
			//Discarded unreachable code: IL_0056
			if (!_isInAnimation)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				CharacterItemData data = _characterData.Data;
				int iD = data.ID;
				CustomButtonModel _003CModel_003Ek__BackingField = ((CustomButton)_currentlySelectedProfession).Model;
				int num = 0;
				int num2 = 0;
				int iD2 = data.ID;
				Task<bool> asyncTask = default(Task<bool>);
				asyncTask.FireAndForgetTask();
				_isInProgress = false;
				OnScreenClicked();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002735")]
		[Cpp2IlInjected.Address(RVA = "0x132BC80", Offset = "0x132A680", VA = "0x18132BC80")]
		private void SelectProfession(ProfessionButton item)
		{
			//Discarded unreachable code: IL_00a1
			//IL_0033: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			if (_professionChoosed || _selectedProfession == item)
			{
				return;
			}
			TweenComponent component = _professionDesc.GetComponent<TweenComponent>();
			int num = 0;
			if (item != (UnityEngine.Object)num)
			{
				goto IL_0087;
			}
			ProfessionButton selectedProfession = _selectedProfession;
			int num2 = 0;
			if (selectedProfession != (UnityEngine.Object)num2)
			{
				ProfessionButton currentlySelectedProfession = _currentlySelectedProfession;
				int num3 = 0;
				if (currentlySelectedProfession != (UnityEngine.Object)num3)
				{
					ProfessionButton selectedProfession2 = _selectedProfession;
					ProfessionButton currentlySelectedProfession2 = _currentlySelectedProfession;
					if (selectedProfession2 != currentlySelectedProfession2)
					{
						_currentlySelectedProfession.UpdateDescritpion();
						goto IL_0087;
					}
				}
			}
			goto IL_0099;
			IL_0087:
			component.Kill(1);
			int index = 0;
			component.PlayTween(index);
			goto IL_0099;
			IL_0099:
			_selectedProfession = item;
		}

		[Cpp2IlInjected.Token(Token = "0x6002736")]
		[Cpp2IlInjected.Address(RVA = "0x1328490", Offset = "0x1326E90", VA = "0x181328490")]
		private void ClearProfessionHighlight(ProfessionButton button)
		{
			//Discarded unreachable code: IL_0036
			ProfessionButton[] professionButtonList = _professionButtonList;
			int num = 0;
			int length = professionButtonList.Length;
			if (num < length)
			{
				ProfessionButton professionButton = professionButtonList[num];
				if (professionButton != button)
				{
					professionButton.GetComponent<ProfessionButtonStateHandler>().ClearState();
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002737")]
		[Cpp2IlInjected.Address(RVA = "0x132B070", Offset = "0x1329A70", VA = "0x18132B070")]
		private void RefreshPlayerLevelRewards()
		{
			//Discarded unreachable code: IL_0109, IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_012d, IL_0133
			//IL_00c4: Expected I4, but got I8
			//IL_00e6: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int childCount = _playerLevelRewards.childCount;
			int count = ((RepeatedField<T>)(object)_friendshipSummary.PlayerLevelUpRewards.rewards_).Count;
			childCount -= count;
			RectTransform playerLevelRewards = _playerLevelRewards;
			int index = playerLevelRewards.childCount - 1;
			RewardItem component = playerLevelRewards.GetChild(index).GetComponent<RewardItem>();
			component.Release();
			RecycleBin recycleBin = _recycleBin;
			GameObject trash = component.gameObject;
			recycleBin.SendToBin(trash);
			RepeatedField<AnyReward> rewards_ = _friendshipSummary.PlayerLevelUpRewards.rewards_;
			bool flag = default(bool);
			if (flag)
			{
				int childCount2 = _playerLevelRewards.childCount;
				RecycleBin recycleBin2 = _recycleBin;
				Type typeFromHandle = typeof(RewardItem);
				RectTransform playerLevelRewards2 = _playerLevelRewards;
				ulong num4 = default(ulong);
				recycleBin2.FindReusableOrNew(typeFromHandle, playerLevelRewards2).SetActive((byte)num4 != 0);
				RewardItem component2 = _playerLevelRewards.GetChild(num3).GetComponent<RewardItem>();
				RewardItemModel rewardItemModel = new RewardItemModel();
				rewardItemModel.Reward = (AnyReward)num2;
				((CustomButton)component2).Model = rewardItemModel;
				((CustomButton)component2).Model.Init(component2);
				component2.RefreshDisplay();
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002738")]
		[Cpp2IlInjected.Address(RVA = "0x1329F20", Offset = "0x1328920", VA = "0x181329F20")]
		private void RefreshCharacterLevelRewards()
		{
			//Discarded unreachable code: IL_018a, IL_0190, IL_0196, IL_019c, IL_01a2, IL_01a8, IL_01ae, IL_01b4, IL_01ba, IL_01c0, IL_01c6, IL_01cc
			//IL_00ae: Expected I4, but got I8
			//IL_00d0: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int childCount = _characterLevelRewards.childCount;
			List<FriendshipLevel> friendshipLevels = _friendshipLevels;
			int num4 = childCount - 1;
			RectTransform characterLevelRewards = _characterLevelRewards;
			int index = characterLevelRewards.childCount - 1;
			CharacterLevelRewardItem component = characterLevelRewards.GetChild(index).GetComponent<CharacterLevelRewardItem>();
			component.Release();
			RecycleBin recycleBin = _recycleBin;
			GameObject trash = component.gameObject;
			recycleBin.SendToBin(trash);
			List<FriendshipLevel> friendshipLevels2 = _friendshipLevels;
			bool flag = default(bool);
			if (flag)
			{
				int childCount2 = _characterLevelRewards.childCount;
				RecycleBin recycleBin2 = _recycleBin;
				Type typeFromHandle = typeof(CharacterLevelRewardItem);
				RectTransform characterLevelRewards2 = _characterLevelRewards;
				ulong num5 = default(ulong);
				recycleBin2.FindReusableOrNew(typeFromHandle, characterLevelRewards2).SetActive((byte)num5 != 0);
				CharacterLevelRewardItem component2 = _characterLevelRewards.GetChild(num3).GetComponent<CharacterLevelRewardItem>();
				CharacterLevelRewardItemModel characterLevelRewardItemModel = new CharacterLevelRewardItemModel();
				characterLevelRewardItemModel.FriendshipLevel = (FriendshipLevel)num2;
				Meta.Character character = (characterLevelRewardItemModel.Character = _characterData);
				bool flag2 = (characterLevelRewardItemModel.IsFinalReward = ((List<>)(object)_friendshipLevels)._size == num3);
				((CustomElement)component2).Model = characterLevelRewardItemModel;
				component2.RefreshDisplay();
				List<FriendshipLevel> friendshipLevels3 = _friendshipLevels;
				Meta.Character characterData = _characterData;
				if ((IntPtr)friendshipLevels3 == (IntPtr)characterData.friendshipLevel_)
				{
					_currentCharacterLevelReward = component2;
				}
				num3++;
			}
			int num6 = default(int);
			if (num6 > 0)
			{
				int num7 = 0;
				Vector2 vector = default(Vector2);
				if ((long)(IntPtr)vector > (long)num7)
				{
				}
				int num8 = 0;
				Transform transform = default(Transform);
				if ((object)transform != null)
				{
				}
				int num9 = default(int);
				bool flag3 = num9 > 1;
				int num10 = num10 - (flag3 ? 1 : 0);
				Transform transform2 = default(Transform);
				if ((object)transform2 != null)
				{
				}
				int num11 = 0;
				int num12 = 0;
				int childCount3 = transform2.childCount;
				if (num3 != childCount3)
				{
				}
				Transform child = transform2.GetChild(num3);
				int num13 = 0;
				int num14 = Mathf.Max(0, -1);
				Transform transform3 = default(Transform);
				if ((object)transform3 == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002739")]
		[Cpp2IlInjected.Address(RVA = "0x13288D0", Offset = "0x13272D0", VA = "0x1813288D0")]
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

		[Cpp2IlInjected.Token(Token = "0x600273A")]
		[Cpp2IlInjected.Address(RVA = "0x132C1B0", Offset = "0x132ABB0", VA = "0x18132C1B0")]
		private void StartCameraModifiersForTarget(GameObject targetObject)
		{
			//Discarded unreachable code: IL_003f
			//IL_0012: Expected O, but got I8
			if (activeCameraModifiers != null)
			{
				activeCameraModifiers = (IDisposable)0;
			}
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			GameObject _003CgameObject_003Ek__BackingField = avatar.gameObject;
			CameraModifierCollection cameraModifierCollection = (CameraModifierCollection)(activeCameraModifiers = _003CInstance_003Ek__BackingField._playerCamera.StartModifiers<HideObstructorsForCutscene, CameraCollisionModifier>(_003CgameObject_003Ek__BackingField));
		}

		[Cpp2IlInjected.Token(Token = "0x600273B")]
		[Cpp2IlInjected.Address(RVA = "0x132C370", Offset = "0x132AD70", VA = "0x18132C370")]
		private void StopCameraModifiers()
		{
			//IL_0012: Expected O, but got I8
			if (activeCameraModifiers != null)
			{
				activeCameraModifiers = (IDisposable)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600273C")]
		[Cpp2IlInjected.Address(RVA = "0x1328580", Offset = "0x1326F80", VA = "0x181328580")]
		[AsyncStateMachine(typeof(_003CCloseTask_003Ed__64))]
		private Task CloseTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600273D")]
		[Cpp2IlInjected.Address(RVA = "0x132BF30", Offset = "0x132A930", VA = "0x18132BF30")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0069
			Phase currentPhase = _currentPhase;
			if ((currentPhase == Phase.CharacterLevelUpProfessionSelection || currentPhase == Phase.CharacterProfessionSelectionOnly) && !_isInAnimation && _professions.gameObject.activeSelf && _professions.childCount > 0)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				RectTransform professionsContent = _professionsContent;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				int index = 0;
				FocusNavigationElement component = professionsContent.GetChild(index).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600273E")]
		[Cpp2IlInjected.Address(RVA = "0x1328BC0", Offset = "0x13275C0", VA = "0x181328BC0")]
		private void KillPressAnyKeyLabelFadeInFadeOut()
		{
			//IL_0028: Expected F4, but got I4
			TextMeshProUGUI pressAnyKeyLabel = _pressAnyKeyLabel;
			int complete = 0;
			int num = DOTween.Kill(pressAnyKeyLabel, (byte)complete != 0);
			TextMeshProUGUI pressAnyKeyLabel2 = _pressAnyKeyLabel;
			int num2 = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade((UnityEngine.UI.Graphic)pressAnyKeyLabel2, 1f, (float)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600273F")]
		[Cpp2IlInjected.Address(RVA = "0x1328C40", Offset = "0x1327640", VA = "0x181328C40", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_00db
			do
			{
				base.OnControllerChanged();
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				CustomButton @continue = _continue;
				if (!flag)
				{
					if (@continue.gameObject.activeSelf)
					{
						GameObject continueShortcut = _continueShortcut;
						int active = 0;
						continueShortcut.SetActive((byte)active != 0);
					}
					return;
				}
				if (@continue.gameObject.activeSelf)
				{
					_continueShortcut.SetActive(value: true);
				}
				Phase currentPhase = _currentPhase;
				if (currentPhase != Phase.CharacterLevelUpProfessionSelection)
				{
					while (currentPhase != Phase.CharacterProfessionSelectionOnly)
					{
					}
				}
				while (_isInAnimation)
				{
				}
			}
			while (!_professions.gameObject.activeSelf || _professions.childCount <= 0);
			MenuNavigation menuNavigation = base.MenuNavigation;
			RectTransform professionsContent = _professionsContent;
			FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
			int index = 0;
			FocusNavigationElement component = professionsContent.GetChild(index).GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6002740")]
		[Cpp2IlInjected.Address(RVA = "0x13296D0", Offset = "0x13280D0", VA = "0x1813296D0")]
		public void OnPressAnyKeyAnimationCompleted()
		{
			//Discarded unreachable code: IL_0052
			//IL_0048: Expected F4, but got I4
			Action action = delegate
			{
				OnScreenClicked();
			};
			int _003C_003E1__state = default(int);
			_003CWaitForAnyInputsCoroutine_003Ed__74 _003CWaitForAnyInputsCoroutine_003Ed__ = new _003CWaitForAnyInputsCoroutine_003Ed__74(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForAnyInputsCoroutine_003Ed__._003C_003E4__this = this;
			_003CWaitForAnyInputsCoroutine_003Ed__.action = action;
			int num = 0;
			Coroutine coroutine = (_waitingForAnyKey = StartCoroutine(_003CWaitForAnyInputsCoroutine_003Ed__));
			TweenerCore<Color, Color, ColorOptions> tweenerCore = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade((UnityEngine.UI.Graphic)_pressAnyKeyLabel, 0.15f, (float)num)).SetLoops(-1, (LoopType)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002741")]
		[Cpp2IlInjected.Address(RVA = "0x13298D0", Offset = "0x13282D0", VA = "0x1813298D0")]
		public void OnProgressAnimationCompleted()
		{
			//Discarded unreachable code: IL_0031
			//IL_0010: Expected O, but got I4
			CharacterLevelRewardItem currentCharacterLevelReward = _currentCharacterLevelReward;
			int num = 0;
			if (currentCharacterLevelReward != (UnityEngine.Object)num)
			{
				_currentCharacterLevelReward.GetComponent<TweenComponent>().PlayTweenAll();
			}
			int num2 = 0;
			IDesignerHost activeDesigner = ((IDesignerEventService)UiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x6002742")]
		[Cpp2IlInjected.Address(RVA = "0x1329810", Offset = "0x1328210", VA = "0x181329810")]
		public void OnProfessionAnimationCompleted()
		{
			//Discarded unreachable code: IL_0031
			//IL_001e: Expected O, but got I4
			RectTransform professions = _professions;
			_isInAnimation = false;
			CanvasGroup component = professions.GetComponent<CanvasGroup>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				component.blocksRaycasts = true;
				component.interactable = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002743")]
		[Cpp2IlInjected.Address(RVA = "0x1329470", Offset = "0x1327E70", VA = "0x181329470")]
		public void OnPhaseCompleted()
		{
			_isInProgress = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002744")]
		[Cpp2IlInjected.Address(RVA = "0x1329C30", Offset = "0x1328630", VA = "0x181329C30")]
		public void OnScreenClicked()
		{
			if (_isInProgress || _isInAnimation)
			{
				return;
			}
			Phase currentPhase = _currentPhase;
			if (_isInAnimation && _isInAnimation)
			{
				if (!_isInAnimation)
				{
					goto IL_0055;
				}
				if (!_isInAnimation)
				{
					goto IL_0063;
				}
				if (currentPhase != Phase.CharacterLevelUpBeforeProfession)
				{
					return;
				}
			}
			if (_characterData.CanSelectProfession())
			{
				throw new NullReferenceException();
			}
			goto IL_0055;
			IL_0063:
			int num = 0;
			IMenu bottom = UiRoot.Instance._menuStack.Bottom;
			int num2 = 0;
			int num3 = 0;
			CancellationToken ct = default(CancellationToken);
			CloseTask(ct).FireAndForgetTask();
			return;
			IL_0055:
			if (_friendshipSummary.PlayerLevelUp)
			{
				return;
			}
			goto IL_0063;
		}

		[Cpp2IlInjected.Token(Token = "0x6002745")]
		[Cpp2IlInjected.Address(RVA = "0x1328B00", Offset = "0x1327500", VA = "0x181328B00", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//IL_0033: Expected O, but got I4
			if (redirectionType != RedirectionType.GenericAlertYes)
			{
				if ((long)typeof(UnityEngine.Object).TypeHandle <= 2)
				{
					OnScreenClicked();
					return;
				}
				if (redirectionType != RedirectionType.GamePopCurrentMenu)
				{
					return;
				}
			}
			ProfessionButton currentlySelectedProfession = _currentlySelectedProfession;
			int num = 0;
			if (currentlySelectedProfession != (UnityEngine.Object)num && _currentPhase == (Phase)(-3))
			{
				ApplyProfession();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002746")]
		[Cpp2IlInjected.Address(RVA = "0x132C590", Offset = "0x132AF90", VA = "0x18132C590")]
		[IteratorStateMachine(typeof(_003CWaitForAnyInputsCoroutine_003Ed__74))]
		private IEnumerator WaitForAnyInputsCoroutine(Action action)
		{
			int _003C_003E1__state = default(int);
			_003CWaitForAnyInputsCoroutine_003Ed__74 _003CWaitForAnyInputsCoroutine_003Ed__ = new _003CWaitForAnyInputsCoroutine_003Ed__74(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForAnyInputsCoroutine_003Ed__._003C_003E4__this = this;
			_003CWaitForAnyInputsCoroutine_003Ed__.action = action;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002747")]
		[Cpp2IlInjected.Address(RVA = "0x132C620", Offset = "0x132B020", VA = "0x18132C620")]
		public LevelUpMenu()
		{
		}
	}
}
