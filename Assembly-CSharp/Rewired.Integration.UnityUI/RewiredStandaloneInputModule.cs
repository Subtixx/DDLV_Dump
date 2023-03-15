using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Rewired.Components;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public class PlayerSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public int playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			public List<Rewired.Components.PlayerMouse> playerMice;

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x1E96F80", Offset = "0x1E95980", VA = "0x181E96F80")]
			public PlayerSetting()
			{
				playerMice = (List<Rewired.Components.PlayerMouse>)(object)new List<T>();
				base._002Ector();
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x1E97000", Offset = "0x1E95A00", VA = "0x181E97000")]
			private PlayerSetting(PlayerSetting other)
			{
				//Discarded unreachable code: IL_0043
				List<Rewired.Components.PlayerMouse> list = (playerMice = (List<Rewired.Components.PlayerMouse>)(object)new List<T>());
				if (other == null)
				{
					ArgumentNullException ex = new ArgumentNullException("other");
					/*Error: Unexpected end of block*/;
				}
				int num = (playerId = other.playerId);
				List<Rewired.Components.PlayerMouse> list2 = (playerMice = (List<Rewired.Components.PlayerMouse>)(object)new List<T>());
				bool flag = default(bool);
				if (other.playerMice != null && flag)
				{
					List<Rewired.Components.PlayerMouse> list3 = playerMice;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x1E96F20", Offset = "0x1E95920", VA = "0x181E96F20")]
			public PlayerSetting Clone()
			{
				return new PlayerSetting(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		[SerializeField]
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
		private InputManager_Base rewiredInputManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		[SerializeField]
		[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
		private bool useAllRewiredGamePlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		[SerializeField]
		[Tooltip("Allow the Rewired System Player to control the UI.")]
		private bool useRewiredSystemPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		[SerializeField]
		[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
		private int[] rewiredPlayerIds = new int[1];

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		[SerializeField]
		[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
		private bool usePlayingPlayersOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		[SerializeField]
		[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
		private List<Rewired.Components.PlayerMouse> playerMice = (List<Rewired.Components.PlayerMouse>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		[SerializeField]
		[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
		private bool moveOneElementPerAxisPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		[SerializeField]
		[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
		private bool setActionsById;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		[SerializeField]
		[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
		private int horizontalActionId = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		[SerializeField]
		[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
		private int verticalActionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		[SerializeField]
		[Tooltip("Id of the Action used to submit.")]
		private int submitActionId = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		[SerializeField]
		[Tooltip("Id of the Action used to cancel.")]
		private int cancelActionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		[SerializeField]
		[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
		private string m_HorizontalAxis = "UIHorizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		[SerializeField]
		[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
		private string m_VerticalAxis = "UIVertical";

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		[SerializeField]
		[Tooltip("Name of the action used to submit.")]
		private string m_SubmitButton = "UISubmit";

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		[SerializeField]
		[Tooltip("Name of the action used to cancel.")]
		private string m_CancelButton = "UICancel";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		[SerializeField]
		[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
		private float m_InputActionsPerSecond = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		[SerializeField]
		[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
		private float m_RepeatDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements.")]
		private bool m_allowMouseInput = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
		private bool m_allowMouseInputIfTouchSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDA")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		[SerializeField]
		[Tooltip("Allows touch input to be used to select elements.")]
		private bool m_allowTouchInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDB")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		[SerializeField]
		[Tooltip("Deselects the current selection on mouse/touch click when the pointer is not over a selectable object.")]
		private bool m_deselectIfBackgroundClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		[SerializeField]
		[Tooltip("Deselects the current selection on mouse/touch click before selecting the next object.")]
		private bool m_deselectBeforeSelecting = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		[SerializeField]
		[Tooltip("Forces the module to always be active.")]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		private bool m_ForceModuleActive;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private int[] playerIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private bool recompiling;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool isTouchSupported;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private double m_PrevActionTime;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private Vector2 m_LastMoveVector;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private int m_ConsecutiveMoveCount;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private bool m_HasFocus = true;

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public InputManager_Base RewiredInputManager
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return rewiredInputManager;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				rewiredInputManager = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		public bool UseAllRewiredGamePlayers
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xAE8610", Offset = "0xAE7010", VA = "0x180AE8610")]
			get
			{
				return useAllRewiredGamePlayers;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0C20", Offset = "0x1E9F620", VA = "0x181EA0C20")]
			set
			{
				bool flag = useAllRewiredGamePlayers;
				useAllRewiredGamePlayers = value;
				if (value != flag)
				{
					SetupRewiredVars();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		public bool UseRewiredSystemPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xAE85F0", Offset = "0xAE6FF0", VA = "0x180AE85F0")]
			get
			{
				return useRewiredSystemPlayer;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0C40", Offset = "0x1E9F640", VA = "0x181EA0C40")]
			set
			{
				bool flag = useRewiredSystemPlayer;
				useRewiredSystemPlayer = value;
				if (value != flag)
				{
					SetupRewiredVars();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		public int[] RewiredPlayerIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0410", Offset = "0x1E9EE10", VA = "0x181EA0410")]
			get
			{
				int[] array = rewiredPlayerIds;
				if ((object)typeof(int[]).TypeHandle == null)
				{
					return (int[])typeof(int[]).TypeHandle;
				}
				if ((object)typeof(int[]).TypeHandle != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x1EA09D0", Offset = "0x1E9F3D0", VA = "0x181EA09D0")]
			set
			{
				//Discarded unreachable code: IL_0029
				if (value != null)
				{
					if ((object)typeof(int[]).TypeHandle == null)
					{
						goto IL_001b;
					}
					if ((object)typeof(int[]).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
				}
				int[] array = new int[0];
				goto IL_001b;
				IL_001b:
				rewiredPlayerIds = array;
				SetupRewiredVars();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public bool UsePlayingPlayersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330")]
			get
			{
				return usePlayingPlayersOnly;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x102A930", Offset = "0x1029330", VA = "0x18102A930")]
			set
			{
				usePlayingPlayersOnly = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public List<Rewired.Components.PlayerMouse> PlayerMice
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x1EA03A0", Offset = "0x1E9EDA0", VA = "0x181EA03A0")]
			get
			{
				//IL_000b: Expected I4, but got O
				return (List<Rewired.Components.PlayerMouse>)(object)new List<T>((int)playerMice);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0910", Offset = "0x1E9F310", VA = "0x181EA0910")]
			set
			{
				//IL_0006: Expected I4, but got O
				List<Rewired.Components.PlayerMouse> list = (List<Rewired.Components.PlayerMouse>)(object)new List<T>((int)value);
				if (value != null)
				{
				}
				playerMice = list;
				SetupRewiredVars();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		public bool MoveOneElementPerAxisPress
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0F0", Offset = "0xA8CAF0", VA = "0x180A8E0F0")]
			get
			{
				return moveOneElementPerAxisPress;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xAEDA40", Offset = "0xAEC440", VA = "0x180AEDA40")]
			set
			{
				moveOneElementPerAxisPress = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		public bool allowMouseInput
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x12AAE10", Offset = "0x12A9810", VA = "0x1812AAE10")]
			get
			{
				return m_allowMouseInput;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x12AAE20", Offset = "0x12A9820", VA = "0x1812AAE20")]
			set
			{
				m_allowMouseInput = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public bool allowMouseInputIfTouchSupported
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x1EA04A0", Offset = "0x1E9EEA0", VA = "0x181EA04A0")]
			get
			{
				return m_allowMouseInputIfTouchSupported;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0DE0", Offset = "0x1E9F7E0", VA = "0x181EA0DE0")]
			set
			{
				m_allowMouseInputIfTouchSupported = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		public bool allowTouchInput
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x1EA04B0", Offset = "0x1E9EEB0", VA = "0x181EA04B0")]
			get
			{
				return m_allowTouchInput;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0DF0", Offset = "0x1E9F7F0", VA = "0x181EA0DF0")]
			set
			{
				m_allowTouchInput = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		public bool deselectIfBackgroundClicked
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x1EA04C0", Offset = "0x1E9EEC0", VA = "0x181EA04C0")]
			get
			{
				return m_deselectIfBackgroundClicked;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0F30", Offset = "0x1E9F930", VA = "0x181EA0F30")]
			set
			{
				m_deselectIfBackgroundClicked = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		private bool deselectBeforeSelecting
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC60", Offset = "0x7D9660", VA = "0x1807DAC60")]
			get
			{
				return m_deselectBeforeSelecting;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x7DB450", Offset = "0x7D9E50", VA = "0x1807DB450")]
			set
			{
				m_deselectBeforeSelecting = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public bool SetActionsById
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x1525170", Offset = "0x1523B70", VA = "0x181525170")]
			get
			{
				return setActionsById;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0A90", Offset = "0x1E9F490", VA = "0x181EA0A90")]
			set
			{
				if (setActionsById != value)
				{
					setActionsById = value;
					SetupRewiredVars();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		public int HorizontalActionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0390", Offset = "0x1E9ED90", VA = "0x181EA0390")]
			get
			{
				return horizontalActionId;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x1EA07A0", Offset = "0x1E9F1A0", VA = "0x181EA07A0")]
			set
			{
				//Discarded unreachable code: IL_003c
				if (value != horizontalActionId)
				{
					horizontalActionId = value;
					int num = 0;
					if (ReInput.mapping.GetAction(value) != null)
					{
						int num2 = 0;
						InputAction action = ReInput.mapping.GetAction(value);
					}
					string text = (m_HorizontalAxis = string.Empty);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		public int VerticalActionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get
			{
				return verticalActionId;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0C60", Offset = "0x1E9F660", VA = "0x181EA0C60")]
			set
			{
				//Discarded unreachable code: IL_003c
				if (value != verticalActionId)
				{
					verticalActionId = value;
					int num = 0;
					if (ReInput.mapping.GetAction(value) != null)
					{
						int num2 = 0;
						InputAction action = ReInput.mapping.GetAction(value);
					}
					string text = (m_VerticalAxis = string.Empty);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public int SubmitActionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xF3A7C0", Offset = "0xF391C0", VA = "0x180F3A7C0")]
			get
			{
				return submitActionId;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0AB0", Offset = "0x1E9F4B0", VA = "0x181EA0AB0")]
			set
			{
				//Discarded unreachable code: IL_003c
				if (value != submitActionId)
				{
					submitActionId = value;
					int num = 0;
					if (ReInput.mapping.GetAction(value) != null)
					{
						int num2 = 0;
						InputAction action = ReInput.mapping.GetAction(value);
					}
					string text = (m_SubmitButton = string.Empty);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public int CancelActionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x9D1840", Offset = "0x9D0240", VA = "0x1809D1840")]
			get
			{
				return cancelActionId;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0630", Offset = "0x1E9F030", VA = "0x181EA0630")]
			set
			{
				//Discarded unreachable code: IL_003c
				if (value != cancelActionId)
				{
					cancelActionId = value;
					int num = 0;
					if (ReInput.mapping.GetAction(value) != null)
					{
						int num2 = 0;
						InputAction action = ReInput.mapping.GetAction(value);
					}
					string text = (m_CancelButton = string.Empty);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		protected override bool isMouseSupported
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x1EA04E0", Offset = "0x1E9EEE0", VA = "0x181EA04E0", Slot = "26")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		private bool isTouchAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x1EA04B0", Offset = "0x1E9EEB0", VA = "0x181EA04B0")]
			get
			{
				return m_allowTouchInput;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		[Obsolete]
		public bool allowActivationOnMobileDevice
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0490", Offset = "0x1E9EE90", VA = "0x181EA0490")]
			get
			{
				return m_ForceModuleActive;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0DD0", Offset = "0x1E9F7D0", VA = "0x181EA0DD0")]
			set
			{
				m_ForceModuleActive = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		public bool forceModuleActive
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0490", Offset = "0x1E9EE90", VA = "0x181EA0490")]
			get
			{
				return m_ForceModuleActive;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0DD0", Offset = "0x1E9F7D0", VA = "0x181EA0DD0")]
			set
			{
				m_ForceModuleActive = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public float inputActionsPerSecond
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x1EA04D0", Offset = "0x1E9EED0", VA = "0x181EA04D0")]
			get
			{
				return m_InputActionsPerSecond;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1070", Offset = "0x1E9FA70", VA = "0x181EA1070")]
			set
			{
				m_InputActionsPerSecond = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public float repeatDelay
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0620", Offset = "0x1E9F020", VA = "0x181EA0620")]
			get
			{
				return m_RepeatDelay;
			}
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1080", Offset = "0x1E9FA80", VA = "0x181EA1080")]
			set
			{
				m_RepeatDelay = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public string horizontalAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return m_HorizontalAxis;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0F40", Offset = "0x1E9F940", VA = "0x181EA0F40")]
			set
			{
				//Discarded unreachable code: IL_002c
				if (!string.Equals(m_HorizontalAxis, value))
				{
					m_HorizontalAxis = value;
					int num = 0;
					int num2 = (horizontalActionId = ReInput.mapping.GetActionId(value));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		public string verticalAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return m_VerticalAxis;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x1EA11C0", Offset = "0x1E9FBC0", VA = "0x181EA11C0")]
			set
			{
				//Discarded unreachable code: IL_002c
				if (!string.Equals(m_VerticalAxis, value))
				{
					m_VerticalAxis = value;
					int num = 0;
					int num2 = (verticalActionId = ReInput.mapping.GetActionId(value));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public string submitButton
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return m_SubmitButton;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1090", Offset = "0x1E9FA90", VA = "0x181EA1090")]
			set
			{
				//Discarded unreachable code: IL_002c
				if (!string.Equals(m_SubmitButton, value))
				{
					m_SubmitButton = value;
					int num = 0;
					int num2 = (submitActionId = ReInput.mapping.GetActionId(value));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public string cancelButton
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return m_CancelButton;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0E00", Offset = "0x1E9F800", VA = "0x181EA0E00")]
			set
			{
				//Discarded unreachable code: IL_002c
				if (!string.Equals(m_CancelButton, value))
				{
					m_CancelButton = value;
					int num = 0;
					int num2 = (cancelActionId = ReInput.mapping.GetActionId(value));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1EA00F0", Offset = "0x1E9EAF0", VA = "0x181EA00F0")]
		private RewiredStandaloneInputModule()
		{
			//IL_0024: Expected I4, but got I8
			//IL_002d: Expected I4, but got I8
			base.m_MouseInputSourcesList = (List<IMouseInputSource>)(object)new List<T>();
			base.m_PlayerPointerData = (Dictionary<int, Dictionary<int, PlayerPointerEventData>[]>)(object)new Dictionary<TKey, TValue>();
			base.m_MouseState = new MouseState
			{
				m_TrackedButtons = (List<ButtonState>)(object)new List<T>()
			};
			((BaseInputModule)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B430", Offset = "0x1E99E30", VA = "0x181E9B430", Slot = "4")]
		protected override void Awake()
		{
			//Discarded unreachable code: IL_0048
			//IL_0014: Expected I4, but got O
			//IL_0024: Expected O, but got I4
			((object)this)._002Ector();
			RewiredPointerInputModule.UnityInputSource unityInputSource = base.defaultInputSource;
			isTouchSupported = (byte)(int)unityInputSource != 0;
			TouchInputModule component = GetComponent<TouchInputModule>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int num2 = ((component.enabled = false) ? 1 : 0);
			}
			ReInput.InitializedEvent += OnRewiredInitialized;
			InitializeRewired();
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FF80", Offset = "0x1E9E980", VA = "0x181E9FF80", Slot = "24")]
		public override void UpdateModule()
		{
			if (recompiling)
			{
				recompiling = false;
				InitializeRewired();
				if (recompiling)
				{
					return;
				}
			}
			if (!m_HasFocus)
			{
				bool flag = ShouldIgnoreEventsOnNoFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F6F0", Offset = "0x1E9E0F0", VA = "0x181E9F6F0", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			//IL_00d1: Expected F4, but got I4
			//IL_00d1: Expected F4, but got I4
			//IL_00ef: Expected F4, but got I4
			//IL_00ef: Expected F4, but got I4
			//IL_028b: Expected I4, but got I8
			int actionId4 = default(int);
			uint num10 = default(uint);
			bool result = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				bool flag = base.ShouldActivateModule();
				if (!flag || recompiling || !flag)
				{
					break;
				}
				int[] array = playerIds;
				int num3 = 0;
				int num4 = 0;
				if (num3 < array.Length)
				{
					int num5 = 0;
					ReInput.PlayerHelper players = ReInput.players;
					int playerId = playerIds[num3];
					Player player = players.GetPlayer(playerId);
					if (player != null && ((usePlayingPlayersOnly ? 1 : 0) == num3 || player.isPlaying))
					{
						int actionId = submitActionId;
						bool buttonDown = player.GetButtonDown(actionId);
						int num6 = 0;
						int actionId2 = cancelActionId;
						bool buttonDown2 = player.GetButtonDown(actionId2);
						int actionId3 = horizontalActionId;
						if ((moveOneElementPerAxisPress ? 1 : 0) == num3)
						{
							float axis = player.GetAxis(actionId3);
							bool flag2 = Mathf.Approximately(num4, num4);
							actionId4 = verticalActionId;
							float axis2 = player.GetAxis(actionId4);
							bool flag3 = Mathf.Approximately(num4, num4);
						}
						if (player.GetButtonDown(actionId4))
						{
						}
						int actionId5 = horizontalActionId;
						bool negativeButtonDown = player.GetNegativeButtonDown(actionId5);
						int actionId6 = verticalActionId;
						if (player.GetButtonDown(actionId6))
						{
						}
						int actionId7 = verticalActionId;
						bool negativeButtonDown2 = player.GetNegativeButtonDown(actionId7);
					}
					int[] array2 = playerIds;
					num3++;
				}
				if (isMouseSupported)
				{
					int[] array3 = playerIds;
					if (num3 < array3.Length)
					{
						int playerId2 = array3[num3];
						int num7 = 0;
						Player player2 = ReInput.players.GetPlayer(playerId2);
						if (player2 != null && ((usePlayingPlayersOnly ? 1 : 0) == num3 || player2.isPlaying) && GetMouseInputSourceCount(playerId2) > 0)
						{
							if (GetMouseInputSource(playerId2, num3) != null && num > num4)
							{
								goto IL_01cd;
							}
							num3++;
						}
						int[] array4 = playerIds;
						num3++;
					}
					int num8 = 0;
					goto IL_01cd;
				}
				goto IL_0252;
				IL_01cd:
				int[] array5 = playerIds;
				if (num3 < array5.Length)
				{
					int playerId3 = array5[num3];
					int num9 = 0;
					Player player3 = ReInput.players.GetPlayer(playerId3);
					if (player3 != null && ((usePlayingPlayersOnly ? 1 : 0) == num3 || player3.isPlaying) && GetMouseInputSourceCount(playerId3) > 0)
					{
						IMouseInputSource mouseInputSource = GetMouseInputSource(playerId3, num3);
						if (mouseInputSource != null && mouseInputSource != null)
						{
							goto IL_0252;
						}
						num3++;
					}
					int[] array6 = playerIds;
					num3++;
					while (array6 != null)
					{
					}
				}
				goto IL_0252;
				IL_0252:
				if ((m_allowTouchInput ? 1 : 0) != num3)
				{
					RewiredPointerInputModule.UnityInputSource unityInputSource = base.defaultInputSource;
					if ((long)num3 < (long)(IntPtr)unityInputSource)
					{
						if (base.__m_DefaultInputSource == null)
						{
							RewiredPointerInputModule.UnityInputSource unityInputSource2 = new RewiredPointerInputModule.UnityInputSource();
							unityInputSource2.m_LastUpdatedFrame = -1;
							base.__m_DefaultInputSource = unityInputSource2;
						}
						if (num3 < (int)num10)
						{
							num3 += num3;
							num3++;
						}
						int num11 = 0;
						num11 += num11;
						num3++;
						if (base.defaultInputSource != null)
						{
							continue;
						}
					}
				}
				return result;
			}
			int num12 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B350", Offset = "0x1E99D50", VA = "0x181E9B350", Slot = "23")]
		public override void ActivateModule()
		{
			//Discarded unreachable code: IL_0055
			//IL_002d: Expected O, but got I4
			if (m_HasFocus || !ShouldIgnoreEventsOnNoFocus())
			{
				((object)this)._002Ector();
				GameObject currentSelected = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
				int num = 0;
				GameObject firstSelected = default(GameObject);
				if (currentSelected == (UnityEngine.Object)num)
				{
					firstSelected = ((BaseInputModule)this).m_EventSystem.m_FirstSelected;
				}
				EventSystem eventSystem = ((BaseInputModule)this).m_EventSystem;
				BaseEventData baseEventData = GetBaseEventData();
				eventSystem.SetSelectedGameObject(firstSelected, baseEventData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B870", Offset = "0x1E9A270", VA = "0x181E9B870", Slot = "22")]
		public override void DeactivateModule()
		{
			((object)this)._002Ector();
			ClearSelection();
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E9E070", Offset = "0x1E9CA70", VA = "0x181E9E070", Slot = "17")]
		public override void Process()
		{
			//Discarded unreachable code: IL_00b7
			//IL_0047: Expected O, but got I4
			if ((m_HasFocus || !ShouldIgnoreEventsOnNoFocus()) && base.enabled && base.gameObject.activeInHierarchy)
			{
				GameObject currentSelected = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
				int num = 0;
				if (!(currentSelected == (UnityEngine.Object)num))
				{
					BaseEventData baseEventData = GetBaseEventData();
					GameObject currentSelected2 = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
					ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler = ExecuteEvents.s_UpdateSelectedHandler;
					bool flag = ExecuteEvents.Execute<IUpdateSelectedHandler>(currentSelected2, baseEventData, (ExecuteEvents.EventFunction<>)(object)s_UpdateSelectedHandler);
					bool used = baseEventData.used;
				}
				int num2 = 0;
				if (((BaseInputModule)this).m_EventSystem.m_sendNavigationEvents && num2 == 0 && !SendMoveEventToSelectedObject())
				{
					bool flag2 = SendSubmitEventToSelectedObject();
				}
				if (!ProcessTouchEvents() && isMouseSupported)
				{
					ProcessMouseEvents();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1E9D460", Offset = "0x1E9BE60", VA = "0x181E9D460")]
		private bool ProcessTouchEvents()
		{
			//IL_0035: Expected I4, but got I8
			//IL_0078: Expected I4, but got I8
			//IL_00e1: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			if ((m_allowTouchInput ? 1 : 0) != num)
			{
				int num3 = 0;
				RewiredPointerInputModule.UnityInputSource _m_DefaultInputSource = base.__m_DefaultInputSource;
				if (_m_DefaultInputSource == null)
				{
					RewiredPointerInputModule.UnityInputSource unityInputSource = new RewiredPointerInputModule.UnityInputSource();
					unityInputSource.m_LastUpdatedFrame = -1;
					base.__m_DefaultInputSource = unityInputSource;
				}
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					num3++;
				}
				int num5 = ((ITouchInputSource)_m_DefaultInputSource).touchCount;
				if (num3 < num5)
				{
					RewiredPointerInputModule.UnityInputSource unityInputSource2 = default(RewiredPointerInputModule.UnityInputSource);
					if (base.__m_DefaultInputSource == null)
					{
						unityInputSource2 = new RewiredPointerInputModule.UnityInputSource();
						unityInputSource2.m_LastUpdatedFrame = -1;
						base.__m_DefaultInputSource = unityInputSource2;
					}
					uint num6 = default(uint);
					if (num3 < (int)num6)
					{
						num3 += num3;
						num3++;
					}
					PlayerPointerEventData playerPointerEventData = default(PlayerPointerEventData);
					if (unityInputSource2 != null)
					{
						RemovePointerData(playerPointerEventData);
						num3++;
						playerPointerEventData = (PlayerPointerEventData)(object)((object)playerPointerEventData + (object)playerPointerEventData);
						playerPointerEventData = (PlayerPointerEventData)(object)((object)playerPointerEventData + (object)playerPointerEventData);
					}
					ProcessMove(playerPointerEventData);
					ProcessDrag(playerPointerEventData);
					num3++;
				}
				if (base.__m_DefaultInputSource == null)
				{
					RewiredPointerInputModule.UnityInputSource unityInputSource3 = new RewiredPointerInputModule.UnityInputSource();
					unityInputSource3.m_LastUpdatedFrame = -1;
					base.__m_DefaultInputSource = unityInputSource3;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1E9D850", Offset = "0x1E9C250", VA = "0x181E9D850")]
		private unsafe void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			//Discarded unreachable code: IL_0259
			//IL_0037: Expected F4, but got I4
			//IL_0032: Expected native int or pointer, but got O
			//IL_0062: Expected native int or pointer, but got O
			//IL_0091: Expected O, but got F4
			//IL_00a6: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			//IL_0101: Expected I4, but got I8
			//IL_010f: Expected I4, but got I8
			//IL_014a: Expected O, but got I4
			//IL_01ac: Expected O, but got I4
			//IL_01ca: Expected O, but got I4
			//IL_01d5: Expected O, but got I4
			//IL_01e9: Expected O, but got I4
			//IL_020e: Expected O, but got I4
			//IL_0222: Expected O, but got I4
			//IL_0235: Expected O, but got I4
			//IL_0258: Expected O, but got I4
			RaycastResult _003CpointerCurrentRaycast_003Ek__BackingField = pointerEvent.pointerCurrentRaycast;
			if (pressed)
			{
				int num = 0;
				pointerEvent.eligibleForClick = true;
				Vector2 vector = (pointerEvent.delta = Vector2.zero);
				Vector2 _003Cposition_003Ek__BackingField = pointerEvent.position;
				((Vector2*)(IntPtr)pointerEvent.delta)->y = 0f;
				float y = pointerEvent.position.y;
				pointerEvent.pressPosition = _003Cposition_003Ek__BackingField;
				RaycastResult _003CpointerCurrentRaycast_003Ek__BackingField2 = pointerEvent.pointerCurrentRaycast;
				pointerEvent.useDragThreshold = true;
				((Vector2*)(IntPtr)pointerEvent.pressPosition)->y = y;
				float distance = pointerEvent.pointerCurrentRaycast.distance;
				pointerEvent.pointerPressRaycast = _003CpointerCurrentRaycast_003Ek__BackingField2;
				int sortingOrder = pointerEvent.pointerCurrentRaycast.sortingOrder;
				pointerEvent.pointerPressRaycast = (RaycastResult)distance;
				Vector3 worldNormal = pointerEvent.pointerCurrentRaycast.worldNormal;
				pointerEvent.pointerPressRaycast = (RaycastResult)sortingOrder;
				pointerEvent.pointerPressRaycast = (RaycastResult)worldNormal;
				GameObject _003CpointerEnter_003Ek__BackingField = pointerEvent.pointerEnter;
				bool flag = default(bool);
				if (flag)
				{
					pointerEvent.pointerEnter = (GameObject)_003CpointerCurrentRaycast_003Ek__BackingField;
				}
				int num2 = 0;
				GameObject gameObject = default(GameObject);
				if (gameObject == (UnityEngine.Object)num2)
				{
				}
				int num3 = 0;
				double unscaledTime = ReInput.time.unscaledTime;
				GameObject _003ClastPress_003Ek__BackingField = pointerEvent.lastPress;
				GameObject gameObject2 = default(GameObject);
				bool flag2 = gameObject2 == _003ClastPress_003Ek__BackingField;
				if (!flag2)
				{
					pointerEvent.clickCount = 1;
				}
				if ((flag2 ? 1 : 0) <= (false ? 1 : 0))
				{
					pointerEvent.clickCount = 1;
				}
				pointerEvent.clickTime = (float)unscaledTime;
				pointerEvent.pointerPress = gameObject2;
				pointerEvent.rawPointerPress = (GameObject)_003CpointerCurrentRaycast_003Ek__BackingField;
				pointerEvent.clickTime = (float)unscaledTime;
				GameObject _003CpointerDrag_003Ek__BackingField = default(GameObject);
				pointerEvent.pointerDrag = _003CpointerDrag_003Ek__BackingField;
				GameObject _003CpointerDrag_003Ek__BackingField2 = pointerEvent.pointerDrag;
				int num4 = 0;
				if (_003CpointerDrag_003Ek__BackingField2 != (UnityEngine.Object)num4)
				{
					GameObject _003CpointerDrag_003Ek__BackingField3 = pointerEvent.pointerDrag;
				}
			}
			if (released)
			{
				GameObject pointerPress = pointerEvent.m_PointerPress;
				ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler = ExecuteEvents.s_PointerUpHandler;
				bool flag3 = ExecuteEvents.Execute<IPointerUpHandler>(pointerPress, pointerEvent, (ExecuteEvents.EventFunction<>)(object)s_PointerUpHandler);
				GameObject gameObject3 = default(GameObject);
				if (pointerEvent.m_PointerPress == gameObject3 && pointerEvent.eligibleForClick)
				{
					GameObject pointerPress2 = pointerEvent.m_PointerPress;
				}
				GameObject _003CpointerDrag_003Ek__BackingField4 = pointerEvent.pointerDrag;
				int num5 = 0;
				if (!(_003CpointerDrag_003Ek__BackingField4 != (UnityEngine.Object)num5) || pointerEvent.dragging)
				{
				}
				pointerEvent.eligibleForClick = false;
				int num6 = 0;
				pointerEvent.pointerPress = (GameObject)num6;
				int num7 = 0;
				pointerEvent.rawPointerPress = (GameObject)num7;
				GameObject _003CpointerDrag_003Ek__BackingField5 = pointerEvent.pointerDrag;
				int num8 = 0;
				if (_003CpointerDrag_003Ek__BackingField5 != (UnityEngine.Object)num8 && (pointerEvent.dragging ? 1 : 0) != num7)
				{
					GameObject _003CpointerDrag_003Ek__BackingField6 = pointerEvent.pointerDrag;
				}
				pointerEvent.dragging = (byte)num7 != 0;
				pointerEvent.pointerDrag = (GameObject)num7;
				GameObject _003CpointerDrag_003Ek__BackingField7 = pointerEvent.pointerDrag;
				int num9 = 0;
				if (_003CpointerDrag_003Ek__BackingField7 != (UnityEngine.Object)num9)
				{
					GameObject _003CpointerDrag_003Ek__BackingField8 = pointerEvent.pointerDrag;
				}
				pointerEvent.pointerDrag = (GameObject)num7;
				GameObject _003CpointerEnter_003Ek__BackingField2 = pointerEvent.pointerEnter;
				ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler = ExecuteEvents.s_PointerExitHandler;
				GameObject gameObject4 = ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>(_003CpointerEnter_003Ek__BackingField2, pointerEvent, (ExecuteEvents.EventFunction<>)(object)s_PointerExitHandler);
				pointerEvent.pointerEnter = (GameObject)num7;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1E9E6F0", Offset = "0x1E9D0F0", VA = "0x181E9E6F0")]
		private bool SendSubmitEventToSelectedObject()
		{
			//IL_0015: Expected O, but got I4
			GameObject currentSelected = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
			int num = 0;
			bool flag = currentSelected == (UnityEngine.Object)num;
			BaseEventData baseEventData;
			if (!flag && recompiling == flag)
			{
				baseEventData = GetBaseEventData();
				int[] array = playerIds;
				int num2 = 0;
				if (num2 < array.Length)
				{
					int num3 = 0;
					ReInput.PlayerHelper players = ReInput.players;
					int playerId = playerIds[num2];
					Player player = players.GetPlayer(playerId);
					if (player != null && (!usePlayingPlayersOnly || player.isPlaying))
					{
						int actionId = submitActionId;
						if (player.GetButtonDown(actionId))
						{
							goto IL_00bb;
						}
						int actionId2 = cancelActionId;
						if (player.GetButtonDown(actionId2))
						{
							goto IL_00cf;
						}
					}
					int[] array2 = playerIds;
					num2++;
					goto IL_00bb;
				}
				goto IL_00c8;
			}
			goto IL_00cf;
			IL_00cf:
			throw new NullReferenceException();
			IL_00c8:
			return baseEventData.used;
			IL_00bb:
			GameObject currentSelected2 = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
			goto IL_00c8;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BCF0", Offset = "0x1E9A6F0", VA = "0x181E9BCF0")]
		private Vector2 GetRawMoveVector()
		{
			//Discarded unreachable code: IL_0197
			//IL_009c: Expected F4, but got I4
			//IL_009c: Expected F4, but got I4
			//IL_00a8: Expected F4, but got I4
			//IL_00a8: Expected F4, but got I4
			int num = 0;
			if ((recompiling ? 1 : 0) == num)
			{
				Vector2 zero = Vector2.zero;
				int num2 = 0;
				int[] array = playerIds;
				int num3 = 0;
				if (num2 < array.Length)
				{
					int num4 = 0;
					ReInput.PlayerHelper players = ReInput.players;
					int playerId = playerIds[num2];
					Player player = players.GetPlayer(playerId);
					if (player != null && (!usePlayingPlayersOnly || player.isPlaying))
					{
						int actionId = horizontalActionId;
						float axis = player.GetAxis(actionId);
						int actionId2 = verticalActionId;
						float axis2 = player.GetAxis(actionId2);
						if (Mathf.Approximately(num3, num3))
						{
						}
						if (Mathf.Approximately(num3, num3))
						{
						}
						int actionId3 = horizontalActionId;
						int actionId6 = default(int);
						if (!moveOneElementPerAxisPress)
						{
							bool button = player.GetButton(actionId3);
							int actionId4 = horizontalActionId;
							if (!button || num3 > num3)
							{
							}
							if (!player.GetNegativeButton(actionId4) || num3 > num3)
							{
							}
							int actionId5 = verticalActionId;
							bool button2 = player.GetButton(actionId5);
							actionId6 = verticalActionId;
							if (!button2 || num3 > num3)
							{
							}
							bool negativeButton = player.GetNegativeButton(actionId6);
						}
						bool buttonDown = player.GetButtonDown(actionId6);
						int actionId7 = horizontalActionId;
						if (!buttonDown || num3 > num3)
						{
						}
						if (!player.GetNegativeButtonDown(actionId7) || num3 > num3)
						{
						}
						int actionId8 = verticalActionId;
						bool buttonDown2 = player.GetButtonDown(actionId8);
						int actionId9 = verticalActionId;
						if (!buttonDown2 || num3 > num3)
						{
						}
						if (player.GetNegativeButtonDown(actionId9) && num3 <= num3)
						{
						}
					}
					int[] array2 = playerIds;
					num2++;
				}
			}
			return Vector2.zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1E9E330", Offset = "0x1E9CD30", VA = "0x181E9E330")]
		private unsafe bool SendMoveEventToSelectedObject()
		{
			//IL_00d7: Expected O, but got I4
			//IL_00e3: Expected F4, but got I4
			//IL_00de: Expected native int or pointer, but got O
			if (!recompiling)
			{
				int num = 0;
				double unscaledTime = ReInput.time.unscaledTime;
				Vector2 rawMoveVector = GetRawMoveVector();
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (!flag || !flag2)
				{
					goto IL_0036;
				}
				int num2 = (m_ConsecutiveMoveCount = 0);
			}
			int num3 = 0;
			goto IL_0036;
			IL_0036:
			int consecutiveMoveCount = 0;
			ulong num4 = default(ulong);
			AxisEventData axisEventData = default(AxisEventData);
			if (num4 != 0)
			{
				MoveDirection _003CmoveDir_003Ek__BackingField = axisEventData.moveDir;
				if (_003CmoveDir_003Ek__BackingField == MoveDirection.Up)
				{
				}
				if ((ulong)((_003CmoveDir_003Ek__BackingField == MoveDirection.Down) ? 1 : 0) == num4 && _003CmoveDir_003Ek__BackingField != 0)
				{
				}
			}
			ulong num5 = default(ulong);
			if (num5 == 0)
			{
				float num6 = m_RepeatDelay;
				if (m_ConsecutiveMoveCount == 1)
				{
				}
				while (num5 == 0)
				{
				}
			}
			if (axisEventData == null)
			{
			}
			if (axisEventData.moveDir == MoveDirection.None)
			{
				m_ConsecutiveMoveCount = consecutiveMoveCount;
			}
			GameObject currentSelected = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
			ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler = ExecuteEvents.s_MoveHandler;
			bool flag3 = ExecuteEvents.Execute<IMoveHandler>(currentSelected, axisEventData, (ExecuteEvents.EventFunction<>)(object)s_MoveHandler);
			int consecutiveMoveCount2 = m_ConsecutiveMoveCount;
			if (consecutiveMoveCount2 == 0 || num4 == 0)
			{
				int num7 = (m_ConsecutiveMoveCount = consecutiveMoveCount2 + 1);
			}
			m_LastMoveVector = (Vector2)0;
			((Vector2*)(IntPtr)m_LastMoveVector)->y = 0f;
			bool used = axisEventData.used;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B590", Offset = "0x1E99F90", VA = "0x181E9B590")]
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
			//Discarded unreachable code: IL_00a8
			int num = 0;
			int[] array = playerIds;
			if (num >= array.Length)
			{
				return;
			}
			int num2 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = playerIds[num];
			Player player = players.GetPlayer(playerId);
			if (player != null && (!usePlayingPlayersOnly || player.isPlaying))
			{
				int actionId = horizontalActionId;
				if (player.GetButtonDown(actionId))
				{
				}
				int actionId2 = horizontalActionId;
				bool negativeButtonDown = player.GetNegativeButtonDown(actionId2);
				int actionId3 = verticalActionId;
				if (player.GetButtonDown(actionId3))
				{
				}
				int actionId4 = verticalActionId;
				bool negativeButtonDown2 = player.GetNegativeButtonDown(actionId4);
			}
			int[] array2 = playerIds;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1E9CC30", Offset = "0x1E9B630", VA = "0x181E9CC30")]
		private void ProcessMouseEvents()
		{
			//Discarded unreachable code: IL_009e
			int[] array = playerIds;
			int num = 0;
			int num2 = 0;
			if (num2 >= array.Length)
			{
				return;
			}
			int num3 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = playerIds[num];
			Player player = players.GetPlayer(playerId);
			if (player != null && (!usePlayingPlayersOnly || player.isPlaying))
			{
				int playerId2 = playerIds[num];
				int mouseInputSourceCount = GetMouseInputSourceCount(playerId2);
				int num4 = 0;
				if (mouseInputSourceCount > 0)
				{
					int playerId3 = playerIds[num];
					ProcessMouseEvent(playerId3, num4);
					num4++;
				}
			}
			int[] array2 = playerIds;
			num++;
			num2 = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C860", Offset = "0x1E9B260", VA = "0x181E9C860")]
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
			//Discarded unreachable code: IL_0150
			//IL_0123: Expected F4, but got I4
			//IL_0123: Expected F4, but got I4
			int num = 0;
			MouseState mousePointerEventData = GetMousePointerEventData(playerId, pointerIndex);
			if (mousePointerEventData == null)
			{
				return;
			}
			int button = 0;
			MouseButtonEventData eventData = mousePointerEventData.GetButtonState(button).m_EventData;
			ProcessMousePress(eventData);
			PlayerPointerEventData buttonData = eventData.buttonData;
			ProcessMove(buttonData);
			PlayerPointerEventData buttonData2 = eventData.buttonData;
			ProcessDrag(buttonData2);
			MouseButtonEventData eventData2 = mousePointerEventData.GetButtonState(1).m_EventData;
			ProcessMousePress(eventData2);
			PlayerPointerEventData buttonData3 = mousePointerEventData.GetButtonState(1).m_EventData.buttonData;
			ProcessDrag(buttonData3);
			MouseButtonEventData eventData3 = mousePointerEventData.GetButtonState(2).m_EventData;
			ProcessMousePress(eventData3);
			PlayerPointerEventData buttonData4 = mousePointerEventData.GetButtonState(2).m_EventData.buttonData;
			ProcessDrag(buttonData4);
			IMouseInputSource mouseInputSource = GetMouseInputSource(playerId, pointerIndex);
			if (mouseInputSource != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				uint num3 = default(uint);
				if ((long)(int)num3 < (long)(IntPtr)mouseInputSource)
				{
					MouseButtonEventData eventData4 = mousePointerEventData.GetButtonState((int)num3).m_EventData;
					ProcessMousePress(eventData4);
					PlayerPointerEventData buttonData5 = mousePointerEventData.GetButtonState((int)num3).m_EventData.buttonData;
					ProcessDrag(buttonData5);
					num3++;
					buttonData5 = (PlayerPointerEventData)(object)((object)buttonData5 + (object)buttonData5);
				}
				PlayerPointerEventData buttonData6 = eventData.buttonData;
				int num4 = 0;
				if (!Mathf.Approximately(num, num4))
				{
					RaycastResult _003CpointerCurrentRaycast_003Ek__BackingField = ((PointerEventData)eventData.buttonData).pointerCurrentRaycast;
					PlayerPointerEventData buttonData7 = eventData.buttonData;
					ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler = ExecuteEvents.s_ScrollHandler;
					GameObject gameObject = default(GameObject);
					GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IScrollHandler>(gameObject, buttonData7, (ExecuteEvents.EventFunction<>)(object)s_ScrollHandler);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1E9E970", Offset = "0x1E9D370", VA = "0x181E9E970")]
		private bool SendUpdateEventToSelectedObject()
		{
			//IL_0015: Expected O, but got I4
			GameObject currentSelected = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
			int num = 0;
			if (!(currentSelected == (UnityEngine.Object)num))
			{
				BaseEventData baseEventData = GetBaseEventData();
				GameObject currentSelected2 = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
				ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler = ExecuteEvents.s_UpdateSelectedHandler;
				bool flag = ExecuteEvents.Execute<IUpdateSelectedHandler>(currentSelected2, baseEventData, (ExecuteEvents.EventFunction<>)(object)s_UpdateSelectedHandler);
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1E9CDC0", Offset = "0x1E9B7C0", VA = "0x181E9CDC0")]
		private unsafe void ProcessMousePress(MouseButtonEventData data)
		{
			//Discarded unreachable code: IL_0221
			//IL_006c: Expected F4, but got I4
			//IL_0067: Expected native int or pointer, but got O
			//IL_0098: Expected native int or pointer, but got O
			//IL_00c7: Expected O, but got F4
			//IL_00dc: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			//IL_0123: Expected I4, but got I8
			//IL_0131: Expected I4, but got I8
			//IL_016c: Expected O, but got I4
			//IL_01c0: Expected O, but got I4
			//IL_01d5: Expected O, but got I4
			//IL_01e0: Expected O, but got I4
			//IL_01f4: Expected O, but got I4
			//IL_020f: Expected O, but got I4
			//IL_0220: Expected O, but got I4
			PlayerPointerEventData buttonData = data.buttonData;
			int _003CinputSourceIndex_003Ek__BackingField = buttonData.inputSourceIndex;
			int _003CplayerId_003Ek__BackingField = buttonData.playerId;
			if (GetMouseInputSource(_003CplayerId_003Ek__BackingField, _003CinputSourceIndex_003Ek__BackingField) == null)
			{
				return;
			}
			RaycastResult _003CpointerCurrentRaycast_003Ek__BackingField = ((PointerEventData)buttonData).pointerCurrentRaycast;
			PointerEventData.FramePressState buttonState = data.buttonState;
			if (buttonState == PointerEventData.FramePressState.Pressed || buttonState == PointerEventData.FramePressState.PressedAndReleased)
			{
				int num = 0;
				((PointerEventData)buttonData).eligibleForClick = true;
				Vector2 vector = (((PointerEventData)buttonData).delta = Vector2.zero);
				Vector2 _003Cposition_003Ek__BackingField = ((PointerEventData)buttonData).position;
				((Vector2*)(IntPtr)((PointerEventData)buttonData).delta)->y = 0f;
				float y = ((PointerEventData)buttonData).position.y;
				((PointerEventData)buttonData).pressPosition = _003Cposition_003Ek__BackingField;
				RaycastResult _003CpointerCurrentRaycast_003Ek__BackingField2 = ((PointerEventData)buttonData).pointerCurrentRaycast;
				((PointerEventData)buttonData).useDragThreshold = true;
				((Vector2*)(IntPtr)((PointerEventData)buttonData).pressPosition)->y = y;
				float distance = ((PointerEventData)buttonData).pointerCurrentRaycast.distance;
				((PointerEventData)buttonData).pointerPressRaycast = _003CpointerCurrentRaycast_003Ek__BackingField2;
				int sortingOrder = ((PointerEventData)buttonData).pointerCurrentRaycast.sortingOrder;
				((PointerEventData)buttonData).pointerPressRaycast = (RaycastResult)distance;
				Vector3 worldNormal = ((PointerEventData)buttonData).pointerCurrentRaycast.worldNormal;
				((PointerEventData)buttonData).pointerPressRaycast = (RaycastResult)sortingOrder;
				((PointerEventData)buttonData).pointerPressRaycast = (RaycastResult)worldNormal;
				int num2 = 0;
				GameObject gameObject = default(GameObject);
				if (gameObject == (UnityEngine.Object)num2)
				{
				}
				int num3 = 0;
				double unscaledTime = ReInput.time.unscaledTime;
				GameObject _003ClastPress_003Ek__BackingField = ((PointerEventData)buttonData).lastPress;
				bool flag = gameObject == _003ClastPress_003Ek__BackingField;
				if (!flag)
				{
					((PointerEventData)buttonData).clickCount = 1;
				}
				if ((flag ? 1 : 0) <= (false ? 1 : 0))
				{
					((PointerEventData)buttonData).clickCount = 1;
				}
				((PointerEventData)buttonData).clickTime = (float)unscaledTime;
				buttonData.pointerPress = gameObject;
				((PointerEventData)buttonData).rawPointerPress = (GameObject)_003CpointerCurrentRaycast_003Ek__BackingField;
				((PointerEventData)buttonData).clickTime = (float)unscaledTime;
				GameObject _003CpointerDrag_003Ek__BackingField = default(GameObject);
				((PointerEventData)buttonData).pointerDrag = _003CpointerDrag_003Ek__BackingField;
				GameObject _003CpointerDrag_003Ek__BackingField2 = ((PointerEventData)buttonData).pointerDrag;
				int num4 = 0;
				if (_003CpointerDrag_003Ek__BackingField2 != (UnityEngine.Object)num4)
				{
					GameObject _003CpointerDrag_003Ek__BackingField3 = ((PointerEventData)buttonData).pointerDrag;
				}
			}
			PointerEventData.FramePressState buttonState2 = data.buttonState;
			if (buttonState2 == PointerEventData.FramePressState.Released || buttonState2 == PointerEventData.FramePressState.PressedAndReleased)
			{
				GameObject pointerPress = ((PointerEventData)buttonData).m_PointerPress;
				GameObject gameObject2 = default(GameObject);
				if (((PointerEventData)buttonData).m_PointerPress == gameObject2)
				{
					GameObject pointerPress2 = ((PointerEventData)buttonData).m_PointerPress;
				}
				GameObject _003CpointerDrag_003Ek__BackingField4 = ((PointerEventData)buttonData).pointerDrag;
				int num5 = 0;
				if (_003CpointerDrag_003Ek__BackingField4 != (UnityEngine.Object)num5)
				{
				}
				((PointerEventData)buttonData).eligibleForClick = false;
				int num6 = 0;
				buttonData.pointerPress = (GameObject)num6;
				int num7 = 0;
				((PointerEventData)buttonData).rawPointerPress = (GameObject)num7;
				GameObject _003CpointerDrag_003Ek__BackingField5 = ((PointerEventData)buttonData).pointerDrag;
				int num8 = 0;
				if (_003CpointerDrag_003Ek__BackingField5 != (UnityEngine.Object)num8)
				{
					GameObject _003CpointerDrag_003Ek__BackingField6 = ((PointerEventData)buttonData).pointerDrag;
				}
				((PointerEventData)buttonData).dragging = (byte)num7 != 0;
				((PointerEventData)buttonData).pointerDrag = (GameObject)num7;
				bool flag2 = default(bool);
				if (flag2)
				{
					int num9 = 0;
					HandlePointerExitAndEnter(buttonData, (GameObject)num9);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C040", Offset = "0x1E9AA40", VA = "0x181E9C040")]
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			//IL_0042: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			if (m_deselectIfBackgroundClicked && m_deselectBeforeSelecting)
			{
				GameObject eventHandler = ExecuteEvents.GetEventHandler<ISelectHandler>(currentOverGo);
				EventSystem eventSystem = ((BaseInputModule)this).m_EventSystem;
			}
			GameObject eventHandler2 = ExecuteEvents.GetEventHandler<ISelectHandler>(currentOverGo);
			if (!m_deselectIfBackgroundClicked)
			{
				if (!m_deselectBeforeSelecting)
				{
					return;
				}
				int num = 0;
				if (eventHandler2 != (UnityEngine.Object)num)
				{
					GameObject currentSelected = ((BaseInputModule)this).m_EventSystem.m_CurrentSelected;
					if (eventHandler2 != currentSelected)
					{
						EventSystem eventSystem2 = ((BaseInputModule)this).m_EventSystem;
						int num2 = 0;
						eventSystem2.SetSelectedGameObject((GameObject)num2, pointerEvent);
					}
				}
				return;
			}
			bool flag = default(bool);
			while (!flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C6B0", Offset = "0x1E9B0B0", VA = "0x181E9C6B0")]
		private void OnApplicationFocus(bool hasFocus)
		{
			m_HasFocus = hasFocus;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FEA0", Offset = "0x1E9E8A0", VA = "0x181E9FEA0")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			//Discarded unreachable code: IL_000d, IL_000f
			int num = 0;
			return ReInput.configuration.ignoreInputWhenAppNotInFocus;
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C6C0", Offset = "0x1E9B0C0", VA = "0x181E9C6C0", Slot = "8")]
		protected override void OnDestroy()
		{
			((object)this)._002Ector();
			ReInput.InitializedEvent -= OnRewiredInitialized;
			ReInput.ShutDownEvent -= OnRewiredShutDown;
			ReInput.EditorRecompileEvent -= OnEditorRecompile;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C4A0", Offset = "0x1E9AEA0", VA = "0x181E9C4A0", Slot = "27")]
		protected override bool IsDefaultPlayer(int playerId)
		{
			if ((long)playerIds != 0)
			{
				int num = 0;
				int num2 = 0;
				int[] array = playerIds;
				if (num2 < array.Length)
				{
					int num3 = 0;
					ReInput.PlayerHelper players = ReInput.players;
					int playerId2 = playerIds[num2];
					Player player = players.GetPlayer(playerId2);
					if (player != null && (num >= 1 || !usePlayingPlayersOnly || player.isPlaying) && (num >= 2 || player.controllers.hasMouse))
					{
						goto IL_007e;
					}
					num2++;
				}
				num++;
			}
			int num4 = 0;
			goto IL_007e;
			IL_007e:
			int[] array2 = playerIds;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C2A0", Offset = "0x1E9ACA0", VA = "0x181E9C2A0")]
		private void InitializeRewired()
		{
			//Discarded unreachable code: IL_004b
			ReInput.ShutDownEvent -= OnRewiredShutDown;
			ReInput.ShutDownEvent += OnRewiredShutDown;
			ReInput.EditorRecompileEvent -= OnEditorRecompile;
			ReInput.EditorRecompileEvent += OnEditorRecompile;
			SetupRewiredVars();
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F020", Offset = "0x1E9DA20", VA = "0x181E9F020")]
		private void SetupRewiredVars()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1E9EE50", Offset = "0x1E9D850", VA = "0x181E9EE50")]
		private void SetUpRewiredPlayerMice()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1E9EAE0", Offset = "0x1E9D4E0", VA = "0x181E9EAE0")]
		private void SetUpRewiredActions()
		{
			//Discarded unreachable code: IL_01b2
			//IL_004a: Expected I4, but got I8
			//IL_0090: Expected I4, but got I8
			//IL_00d6: Expected I4, but got I8
			//IL_011c: Expected I4, but got I8
			if (setActionsById)
			{
				int num = 0;
				ReInput.MappingHelper mapping = ReInput.mapping;
				int actionId = horizontalActionId;
				InputAction action = mapping.GetAction(actionId);
				if (action != null)
				{
				}
				string text = (m_HorizontalAxis = string.Empty);
				if (action == null)
				{
					horizontalActionId = -1;
				}
				int num2 = 0;
				ReInput.MappingHelper mapping2 = ReInput.mapping;
				int actionId2 = verticalActionId;
				InputAction action2 = mapping2.GetAction(actionId2);
				if (action2 != null)
				{
				}
				string text2 = (m_VerticalAxis = string.Empty);
				if (action2 == null)
				{
					verticalActionId = -1;
				}
				int num3 = 0;
				ReInput.MappingHelper mapping3 = ReInput.mapping;
				int actionId3 = submitActionId;
				InputAction action3 = mapping3.GetAction(actionId3);
				if (action3 != null)
				{
				}
				string text3 = (m_SubmitButton = string.Empty);
				if (action3 == null)
				{
					submitActionId = -1;
				}
				int num4 = 0;
				ReInput.MappingHelper mapping4 = ReInput.mapping;
				int actionId4 = cancelActionId;
				InputAction action4 = mapping4.GetAction(actionId4);
				if (action4 != null)
				{
				}
				string text4 = (m_CancelButton = string.Empty);
				if (action4 == null)
				{
					cancelActionId = -1;
				}
			}
			else
			{
				int num5 = 0;
				ReInput.MappingHelper mapping5 = ReInput.mapping;
				string text5 = m_HorizontalAxis;
				int actionId5 = mapping5.GetActionId(text5);
				int num6 = 0;
				horizontalActionId = actionId5;
				ReInput.MappingHelper mapping6 = ReInput.mapping;
				string text6 = m_VerticalAxis;
				int actionId6 = mapping6.GetActionId(text6);
				int num7 = 0;
				verticalActionId = actionId6;
				ReInput.MappingHelper mapping7 = ReInput.mapping;
				string text7 = m_SubmitButton;
				int actionId7 = mapping7.GetActionId(text7);
				int num8 = 0;
				submitActionId = actionId7;
				ReInput.MappingHelper mapping8 = ReInput.mapping;
				string text8 = m_CancelButton;
				int num9 = (cancelActionId = mapping8.GetActionId(text8));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BAB0", Offset = "0x1E9A4B0", VA = "0x181E9BAB0")]
		private bool GetButton(Player player, int actionId)
		{
			//Discarded unreachable code: IL_0008
			return player.GetButton(actionId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BA70", Offset = "0x1E9A470", VA = "0x181E9BA70")]
		private bool GetButtonDown(Player player, int actionId)
		{
			//Discarded unreachable code: IL_0008
			return player.GetButtonDown(actionId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BCB0", Offset = "0x1E9A6B0", VA = "0x181E9BCB0")]
		private bool GetNegativeButton(Player player, int actionId)
		{
			//Discarded unreachable code: IL_0008
			return player.GetNegativeButton(actionId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BC70", Offset = "0x1E9A670", VA = "0x181E9BC70")]
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			//Discarded unreachable code: IL_0008
			return player.GetNegativeButtonDown(actionId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BA30", Offset = "0x1E9A430", VA = "0x181E9BA30")]
		private float GetAxis(Player player, int actionId)
		{
			//Discarded unreachable code: IL_0008
			return player.GetAxis(actionId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B740", Offset = "0x1E9A140", VA = "0x181E9B740")]
		private void CheckEditorRecompile()
		{
			if (recompiling)
			{
				recompiling = false;
				InitializeRewired();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C7E0", Offset = "0x1E9B1E0", VA = "0x181E9C7E0")]
		private void OnEditorRecompile()
		{
			//Discarded unreachable code: IL_002b
			recompiling = true;
			int[] array = playerIds;
			int length = array.Length;
			int index = 0;
			Array.Clear(array, index, length);
			((List<T>)(object)base.m_MouseInputSourcesList).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B810", Offset = "0x1E9A210", VA = "0x181E9B810")]
		private void ClearRewiredVars()
		{
			//Discarded unreachable code: IL_0024
			int[] array = playerIds;
			int length = array.Length;
			int index = 0;
			Array.Clear(array, index, length);
			((List<T>)(object)base.m_MouseInputSourcesList).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B890", Offset = "0x1E9A290", VA = "0x181E9B890")]
		private bool DidAnyMouseMove()
		{
			int[] array = playerIds;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (num2 < array.Length)
			{
				int playerId = array[num];
				int num4 = 0;
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null && (!usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = GetMouseInputSourceCount(playerId);
					int num5 = 0;
					if (mouseInputSourceCount > 0)
					{
						if (GetMouseInputSource(playerId, num5) != null)
						{
						}
						num5++;
					}
				}
				int[] array2 = playerIds;
				num++;
				num2 = num;
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1E9BAF0", Offset = "0x1E9A4F0", VA = "0x181E9BAF0")]
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			int[] array = playerIds;
			int num = 0;
			int num2 = 0;
			if (num2 < array.Length)
			{
				int playerId = array[num];
				int num3 = 0;
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null && (!usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = GetMouseInputSourceCount(playerId);
					int num4 = 0;
					if (mouseInputSourceCount > 0)
					{
						IMouseInputSource mouseInputSource = GetMouseInputSource(playerId, num4);
						if (mouseInputSource != null && mouseInputSource != null)
						{
							goto IL_007e;
						}
						num4++;
					}
				}
				int[] array2 = playerIds;
				num++;
				num2 = num;
				goto IL_007e;
			}
			throw new NullReferenceException();
			IL_007e:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1E9C850", Offset = "0x1E9B250", VA = "0x181E9C850")]
		private void OnRewiredInitialized()
		{
			InitializeRewired();
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B810", Offset = "0x1E9A210", VA = "0x181E9B810")]
		private void OnRewiredShutDown()
		{
			//Discarded unreachable code: IL_0024
			int[] array = playerIds;
			int length = array.Length;
			int index = 0;
			Array.Clear(array, index, length);
			((List<T>)(object)base.m_MouseInputSourcesList).Clear();
		}
	}
}
