using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Activities;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Buildings;
using Mdl.Dialogues;
using Mdl.Environments;
using Mdl.Items;
using Mdl.Missions;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AI;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x200084B")]
	public class Character : MonoBehaviour, IDialogueActor, IPlayerTaskData, IPlayerTaskProvider, IRelaxer, INpc, IVariable, IDisneyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x200084C")]
		public enum DebugForceBehaviourType
		{
			[Cpp2IlInjected.Token(Token = "0x4002EAF")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002EB0")]
			Sit,
			[Cpp2IlInjected.Token(Token = "0x4002EB1")]
			Fish
		}

		[Cpp2IlInjected.Token(Token = "0x4002E4B")]
		public const int DefaultAvoidancePriority = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E4E")]
		public Vector3 spawnFallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002E4F")]
		public NpcBodyType bodyType = NpcBodyType.MediumBiped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002E50")]
		public MotivationConfig freeTimeMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002E51")]
		public MotivationConfig giveQuestMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002E52")]
		public MotivationConfig holdStallMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002E53")]
		public MotivationConfig followMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002E54")]
		public MotivationConfig moveToMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002E55")]
		public MotivationConfig hangoutMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002E56")]
		public MotivationConfig fishingMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002E57")]
		public MotivationConfig inRealmMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002E58")]
		public BehaviourTree inRealmBehaviourTree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002E59")]
		public MotivationConfig debugForceSitMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002E5A")]
		public MotivationConfig debugForceFishMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002E5B")]
		public bool debugShouldResetMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002E5C")]
		public Transform levelUpStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002E5D")]
		public Transform levelUpEndCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002E5E")]
		public AssetReference friendshipGainedVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002E5F")]
		public AssetReference normalGiftFriendshipGainedVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002E60")]
		[SerializeField]
		private List<GameObject> visualGameObjects = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xFA")]
		[Cpp2IlInjected.Token(Token = "0x4002E6B")]
		private bool _isHangingOutWithAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFB")]
		[Cpp2IlInjected.Token(Token = "0x4002E6C")]
		private bool blinkModeInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002E6D")]
		private BlinkMode blinkMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002E6E")]
		private bool shown = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
		[Cpp2IlInjected.Token(Token = "0x4002E6F")]
		public bool PreventVisitHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002E71")]
		private GameObject characterToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002E72")]
		private bool runToFollowCharacter = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x121")]
		[Cpp2IlInjected.Token(Token = "0x4002E73")]
		private bool runToMoveToTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002E76")]
		private int _talkingToRequestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4002E77")]
		private bool? _navMeshStatusWhenEnablingTalkingToRequestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002E79")]
		[SerializeField]
		private PlayerTaskDefinition _talkTask;

		[Cpp2IlInjected.Token(Token = "0x4002E7C")]
		private const float NormalConversationDistance = 3f;

		[Cpp2IlInjected.Token(Token = "0x4002E7D")]
		private const float WaterGroundConversationDistance = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002E7F")]
		private bool runToConversationPartner = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002E84")]
		private DebugForceBehaviourType _debugForceBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002E87")]
		public Character OtherCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4002E88")]
		public bool UseRunAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4002E89")]
		public float walkSpeed = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4002E8A")]
		public float runSpeed = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4002E8B")]
		public bool UseLoopingEmotionAnimations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A5")]
		[Cpp2IlInjected.Token(Token = "0x4002E8C")]
		public bool UseLoopingWOL = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A6")]
		[Cpp2IlInjected.Token(Token = "0x4002E8D")]
		public bool UseSittingWOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A7")]
		[Cpp2IlInjected.Token(Token = "0x4002E8E")]
		public bool UsingWalkEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4002E8F")]
		public bool HasSelfieAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A9")]
		[Cpp2IlInjected.Token(Token = "0x4002E90")]
		public bool CanTalkWhileSeated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AA")]
		[Cpp2IlInjected.Token(Token = "0x4002E91")]
		public bool CanSelfieWhileSeated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AB")]
		[Cpp2IlInjected.Token(Token = "0x4002E92")]
		public bool CanGiveWhileSeated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4002E93")]
		public float MinSecondsBetweenAvatarReaction = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4002E94")]
		public float MaxSecondsBetweenAvatarReaction = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4002E95")]
		private Meta.Character _metaCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4002E96")]
		private bool hadPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4002E98")]
		private CancellationTokenSource reactToSelfieCTS = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4002E99")]
		private DateTime nextAvatarReaction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4002E9A")]
		public Vector3? RewardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4002E9B")]
		public Vector3 RewardSourcePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4002E9C")]
		private int moveBoolHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4002E9D")]
		private int runFloatHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4002E9E")]
		private AudioEmitterCullingManager cullingScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4002E9F")]
		private bool lastIsRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4002EA0")]
		[Header("Audio")]
		public AK.Wwise.Switch ipSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4002EA1")]
		public AK.Wwise.Switch characterSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4002EA2")]
		public AK.Wwise.Switch skinVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4002EA3")]
		public bool isUsingMoveSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4002EA4")]
		public AK.Wwise.Event moveSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4002EA5")]
		public AK.Wwise.Event stopSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4002EA6")]
		public GameObject audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4002EA7")]
		private float prevSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4002EAB")]
		private Func<Character, MissionSlot, System.Threading.Tasks.Task> OnPreferredDialogueCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4002EAC")]
		private CharacterState postponedRestoreState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4002EAD")]
		private bool postponedRestoreTransform;

		[Cpp2IlInjected.Token(Token = "0x1700056A")]
		private CharacterManager Manager
		{
			[Cpp2IlInjected.Token(Token = "0x60025B5")]
			[Cpp2IlInjected.Address(RVA = "0x12F3900", Offset = "0x12F2300", VA = "0x1812F3900")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<CharacterManager>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002E4C")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60025B6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60025B7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700056C")]
		public CharacterItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60025B8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056D")]
		public NpcBodyType BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x60025BA")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500", Slot = "14")]
			get
			{
				return bodyType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056E")]
		public MotivationConfig FreeTimeMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x60025BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "15")]
			get
			{
				return freeTimeMotivation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056F")]
		public Animator AnimatorComponent
		{
			[Cpp2IlInjected.Token(Token = "0x60025BC")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			[CompilerGenerated]
			get
			{
				return _003CAnimatorComponent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025BD")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			[CompilerGenerated]
			private set
			{
				_003CAnimatorComponent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000570")]
		public GameObject Animator
		{
			[Cpp2IlInjected.Token(Token = "0x60025BE")]
			[Cpp2IlInjected.Address(RVA = "0x12F24C0", Offset = "0x12F0EC0", VA = "0x1812F24C0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return AnimatorComponent.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000571")]
		public CharacterVisualNodes CharacterVisualNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60025BF")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterVisualNodes_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025C0")]
			[Cpp2IlInjected.Address(RVA = "0x11049F0", Offset = "0x11033F0", VA = "0x1811049F0")]
			[CompilerGenerated]
			private set
			{
				_003CCharacterVisualNodes_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000572")]
		public NavMeshAgent NavMeshAgentComponent
		{
			[Cpp2IlInjected.Token(Token = "0x60025C1")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			[CompilerGenerated]
			get
			{
				return _003CNavMeshAgentComponent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025C2")]
			[Cpp2IlInjected.Address(RVA = "0x976600", Offset = "0x975000", VA = "0x180976600")]
			[CompilerGenerated]
			private set
			{
				_003CNavMeshAgentComponent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000573")]
		public GameObject NavMeshAgent
		{
			[Cpp2IlInjected.Token(Token = "0x60025C3")]
			[Cpp2IlInjected.Address(RVA = "0x12F3AD0", Offset = "0x12F24D0", VA = "0x1812F3AD0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return NavMeshAgentComponent.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000574")]
		public BehaviourTreeOwner BehaviorTreeOwnerComponent
		{
			[Cpp2IlInjected.Token(Token = "0x60025C4")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			[CompilerGenerated]
			get
			{
				return _003CBehaviorTreeOwnerComponent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025C5")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			[CompilerGenerated]
			private set
			{
				_003CBehaviorTreeOwnerComponent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000575")]
		public new Transform transform
		{
			[Cpp2IlInjected.Token(Token = "0x60025C6")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return _003Ctransform_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025C7")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			[CompilerGenerated]
			private set
			{
				_003Ctransform_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000576")]
		public new GameObject gameObject
		{
			[Cpp2IlInjected.Token(Token = "0x60025C8")]
			[Cpp2IlInjected.Address(RVA = "0x7393C0", Offset = "0x737DC0", VA = "0x1807393C0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return _003CgameObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025C9")]
			[Cpp2IlInjected.Address(RVA = "0x976540", Offset = "0x974F40", VA = "0x180976540")]
			[CompilerGenerated]
			private set
			{
				_003CgameObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000577")]
		[field: Cpp2IlInjected.Token(Token = "0x4002E67")]
		internal static bool StopAllCharacterAIs
		{
			[Cpp2IlInjected.Token(Token = "0x60025CC")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D40", Offset = "0x12F2740", VA = "0x1812F3D40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60025CD")]
			[Cpp2IlInjected.Address(RVA = "0x12F42E0", Offset = "0x12F2CE0", VA = "0x1812F42E0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000578")]
		public bool CharacterAIStopped
		{
			[Cpp2IlInjected.Token(Token = "0x60025CE")]
			[Cpp2IlInjected.Address(RVA = "0x12F28A0", Offset = "0x12F12A0", VA = "0x1812F28A0")]
			get
			{
				return StopAllCharacterAIs;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000579")]
		internal RelaxingBehaviour RelaxingBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x60025CF")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			[CompilerGenerated]
			get
			{
				return _003CRelaxingBehaviour_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025D0")]
			[Cpp2IlInjected.Address(RVA = "0xE269B0", Offset = "0xE253B0", VA = "0x180E269B0")]
			[CompilerGenerated]
			private set
			{
				_003CRelaxingBehaviour_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xF8"), Cpp2IlInjected.Token(Token = "0x4002E69")]
		public bool IsInSelfieCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60025D1")]
			[Cpp2IlInjected.Address(RVA = "0xF32FF0", Offset = "0xF319F0", VA = "0x180F32FF0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60025D2")]
			[Cpp2IlInjected.Address(RVA = "0xF33000", Offset = "0xF31A00", VA = "0x180F33000")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700057B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xF9"), Cpp2IlInjected.Token(Token = "0x4002E6A")]
		public bool IsQuestGiver
		{
			[Cpp2IlInjected.Token(Token = "0x60025D3")]
			[Cpp2IlInjected.Address(RVA = "0x12F3520", Offset = "0x12F1F20", VA = "0x1812F3520")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60025D4")]
			[Cpp2IlInjected.Address(RVA = "0x12F41F0", Offset = "0x12F2BF0", VA = "0x1812F41F0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700057C")]
		public bool IsInRealm
		{
			[Cpp2IlInjected.Token(Token = "0x60025D5")]
			[Cpp2IlInjected.Address(RVA = "0x12F3180", Offset = "0x12F1B80", VA = "0x1812F3180")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (MetaCharacter == null)
				{
				}
				return MetaCharacter.InRealm;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057D")]
		public bool CanHangoutWithPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60025D6")]
			[Cpp2IlInjected.Address(RVA = "0x12F2870", Offset = "0x12F1270", VA = "0x1812F2870")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MetaCharacter.CanHangoutWithPlayer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057E")]
		public bool IsHangingOutWithAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x60025D7")]
			[Cpp2IlInjected.Address(RVA = "0x12F32E0", Offset = "0x12F1CE0", VA = "0x1812F32E0")]
			get
			{
				return _isHangingOutWithAvatar;
			}
			[Cpp2IlInjected.Token(Token = "0x60025D8")]
			[Cpp2IlInjected.Address(RVA = "0x12F41D0", Offset = "0x12F2BD0", VA = "0x1812F41D0")]
			set
			{
				_isHangingOutWithAvatar = value;
				if (!value)
				{
					UnregisterAvatarTeleport();
				}
				else
				{
					RegisterAvatarTeleport();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057F")]
		public bool IsAquatic
		{
			[Cpp2IlInjected.Token(Token = "0x60025D9")]
			[Cpp2IlInjected.Address(RVA = "0x12F3200", Offset = "0x12F1C00", VA = "0x1812F3200")]
			get
			{
				//IL_0010: Expected O, but got I4
				NavMeshAreaHelper component = GetComponent<NavMeshAreaHelper>();
				int num = 0;
				bool flag = component == (UnityEngine.Object)num;
				if (!flag && component._canWalkOnLand == flag)
				{
					return component._canWalkInWater;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000580")]
		public bool HasAquaticHouse
		{
			[Cpp2IlInjected.Token(Token = "0x60025DA")]
			[Cpp2IlInjected.Address(RVA = "0x12F2E30", Offset = "0x12F1830", VA = "0x1812F2E30")]
			get
			{
				int house = MetaCharacter.Data.House;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				BuildingItemData buildingItemData = default(BuildingItemData);
				if (buildingItemData != null)
				{
					house = buildingItemData.gridAreaData_.AcceptedFloorTypesFlag;
					bool result = default(bool);
					return result;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000581")]
		private BlinkMode BlinkMode
		{
			[Cpp2IlInjected.Token(Token = "0x60025DB")]
			[Cpp2IlInjected.Address(RVA = "0x12F2790", Offset = "0x12F1190", VA = "0x1812F2790")]
			get
			{
				if (!blinkModeInitialized)
				{
					blinkModeInitialized = true;
					BlinkMode blinkMode = (this.blinkMode = GetComponent<BlinkMode>());
				}
				return this.blinkMode;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000582")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x60025DC")]
			[Cpp2IlInjected.Address(RVA = "0x12F3770", Offset = "0x12F2170", VA = "0x1812F3770")]
			get
			{
				//Discarded unreachable code: IL_006a
				//IL_0039: Expected O, but got I4
				if (!shown)
				{
					int num = 0;
				}
				if (!blinkModeInitialized)
				{
					blinkModeInitialized = true;
					BlinkMode blinkMode = (this.blinkMode = GetComponent<BlinkMode>());
				}
				BlinkMode blinkMode2 = this.blinkMode;
				int num2 = 0;
				if (blinkMode2 == (UnityEngine.Object)num2)
				{
					return true;
				}
				if (!blinkModeInitialized)
				{
					blinkModeInitialized = true;
					BlinkMode blinkMode3 = (this.blinkMode = GetComponent<BlinkMode>());
				}
				return this.blinkMode.shown;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000583")]
		public bool IsHouseInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x60025E1")]
			[Cpp2IlInjected.Address(RVA = "0x12F32F0", Offset = "0x12F1CF0", VA = "0x1812F32F0")]
			get
			{
				//Discarded unreachable code: IL_0028
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				CharacterItemData characterItemData = Data;
				ProfileWorld world_ = profile.world_;
				int house = characterItemData.House;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000584")]
		public IResolver Resolver
		{
			[Cpp2IlInjected.Token(Token = "0x60025E2")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			[CompilerGenerated]
			get
			{
				return _003CResolver_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025E3")]
			[Cpp2IlInjected.Address(RVA = "0x83E110", Offset = "0x83CB10", VA = "0x18083E110")]
			[CompilerGenerated]
			set
			{
				_003CResolver_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000585")]
		private bool IsRunning
		{
			[Cpp2IlInjected.Token(Token = "0x60025E5")]
			[Cpp2IlInjected.Address(RVA = "0x12F3530", Offset = "0x12F1F30", VA = "0x1812F3530")]
			get
			{
				//Discarded unreachable code: IL_00a1
				//IL_0010: Expected O, but got I4
				//IL_002f: Expected O, but got I4
				GameObject gameObject = characterToFollow;
				int num = 0;
				if (!(gameObject != (UnityEngine.Object)num) || !runToFollowCharacter)
				{
					GameObject gameObject2 = ConversationPartner;
					int num2 = 0;
					bool flag = gameObject2 != (UnityEngine.Object)num2;
					if (flag && runToConversationPartner)
					{
						if (flag)
						{
						}
						Transform transform = ConversationPartner.transform;
						Vector3 vector = default(Vector3);
						float z = vector.z;
						Transform transform2 = this.transform;
						Vector3 vector2 = default(Vector3);
						float z2 = vector2.z;
						if ((object)vector2 != null)
						{
							goto IL_009d;
						}
					}
					if ((!runToMoveToTarget || (!IsMovingToTargetPosition && !IsMovingToTargetObject)) && (!IsFollowingAvatar() || !runToFollowCharacter))
					{
						return true;
					}
				}
				goto IL_009d;
				IL_009d:
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000586")]
		public GameObject CharacterToFollow
		{
			[Cpp2IlInjected.Token(Token = "0x60025E6")]
			[Cpp2IlInjected.Address(RVA = "0xA5C390", Offset = "0xA5AD90", VA = "0x180A5C390")]
			get
			{
				return characterToFollow;
			}
			[Cpp2IlInjected.Token(Token = "0x60025E7")]
			[Cpp2IlInjected.Address(RVA = "0x12F3E10", Offset = "0x12F2810", VA = "0x1812F3E10")]
			set
			{
				//Discarded unreachable code: IL_00a5
				//IL_0019: Expected O, but got I4
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				characterToFollow = value;
				int num2 = 0;
				if (!(value != (UnityEngine.Object)num2))
				{
					UnregisterAvatarTeleport();
					CharacterManager characterManager = default(CharacterManager);
					characterManager.NotifyOverrideCharacterSchedule(this);
				}
				RegisterAvatarTeleport();
				GameObject gameObject = this.gameObject;
				WorkingAtAShop = false;
				int num3 = 0;
				if (!gameObject.activeSelf)
				{
					this.gameObject.SetActive(value: true);
					int num4 = 0;
					bool flag2 = default(bool);
					if (flag2)
					{
						Vector3 vector = default(Vector3);
						float z = vector.z;
						bool flag3 = default(bool);
						if (flag3)
						{
						}
						Vector3 vector2 = default(Vector3);
						float z2 = vector2.z;
					}
				}
				bool isRunning = IsRunning;
				NavMeshAgent navMeshAgent = NavMeshAgentComponent;
				lastIsRunning = isRunning;
				if (isRunning)
				{
				}
				float num6 = (navMeshAgent.speed = walkSpeed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000587")]
		public bool RunToFollowCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60025E8")]
			[Cpp2IlInjected.Address(RVA = "0xD2D610", Offset = "0xD2C010", VA = "0x180D2D610")]
			get
			{
				return runToFollowCharacter;
			}
			[Cpp2IlInjected.Token(Token = "0x60025E9")]
			[Cpp2IlInjected.Address(RVA = "0x12F4210", Offset = "0x12F2C10", VA = "0x1812F4210")]
			set
			{
				//Discarded unreachable code: IL_0039
				if (runToFollowCharacter != value)
				{
					runToFollowCharacter = value;
					bool isRunning = IsRunning;
					NavMeshAgent navMeshAgent = NavMeshAgentComponent;
					lastIsRunning = isRunning;
					if (isRunning)
					{
					}
					float num2 = (navMeshAgent.speed = walkSpeed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000588")]
		public bool IsMovingToTargetPosition
		{
			[Cpp2IlInjected.Token(Token = "0x60025EA")]
			[Cpp2IlInjected.Address(RVA = "0x12F34A0", Offset = "0x12F1EA0", VA = "0x1812F34A0")]
			get
			{
				Blackboard component;
				do
				{
					component = GetComponent<Blackboard>();
				}
				while ((object)component == null);
				return component.GetValue<bool>("moveToTargetPosition");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000589")]
		public bool RunToMoveToTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60025ED")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D00", Offset = "0x12F2700", VA = "0x1812F3D00")]
			get
			{
				return runToMoveToTarget;
			}
			[Cpp2IlInjected.Token(Token = "0x60025EE")]
			[Cpp2IlInjected.Address(RVA = "0x12F4270", Offset = "0x12F2C70", VA = "0x1812F4270")]
			set
			{
				//Discarded unreachable code: IL_0039
				if (runToMoveToTarget != value)
				{
					runToMoveToTarget = value;
					bool isRunning = IsRunning;
					NavMeshAgent navMeshAgent = NavMeshAgentComponent;
					lastIsRunning = isRunning;
					if (isRunning)
					{
					}
					float num2 = (navMeshAgent.speed = walkSpeed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058A")]
		public bool IsMovingToTargetObject
		{
			[Cpp2IlInjected.Token(Token = "0x60025F1")]
			[Cpp2IlInjected.Address(RVA = "0x12F33F0", Offset = "0x12F1DF0", VA = "0x1812F33F0")]
			get
			{
				//IL_0022: Expected O, but got I4
				//IL_0022: Expected O, but got I4
				Blackboard component = GetComponent<Blackboard>();
				if ((object)component != null)
				{
					GameObject value = component.GetValue<GameObject>("moveToTarget");
				}
				int num = 0;
				int num2 = 0;
				return (UnityEngine.Object)num != (UnityEngine.Object)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058B")]
		public GameObject CharacterRequestor
		{
			[Cpp2IlInjected.Token(Token = "0x60025F4")]
			[Cpp2IlInjected.Address(RVA = "0x12F2910", Offset = "0x12F1310", VA = "0x1812F2910")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterRequestor_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025F5")]
			[Cpp2IlInjected.Address(RVA = "0x12F3DE0", Offset = "0x12F27E0", VA = "0x1812F3DE0")]
			[CompilerGenerated]
			set
			{
				_003CCharacterRequestor_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058C")]
		public CharacterAttractedToAvatarState AttractedState
		{
			[Cpp2IlInjected.Token(Token = "0x60025F6")]
			[Cpp2IlInjected.Address(RVA = "0x9762E0", Offset = "0x974CE0", VA = "0x1809762E0")]
			[CompilerGenerated]
			get
			{
				return _003CAttractedState_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025F7")]
			[Cpp2IlInjected.Address(RVA = "0x12F3DD0", Offset = "0x12F27D0", VA = "0x1812F3DD0")]
			[CompilerGenerated]
			set
			{
				_003CAttractedState_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058D")]
		public bool IsAttracted
		{
			[Cpp2IlInjected.Token(Token = "0x60025F8")]
			[Cpp2IlInjected.Address(RVA = "0x12F32A0", Offset = "0x12F1CA0", VA = "0x1812F32A0")]
			get
			{
				//Discarded unreachable code: IL_000f
				return AttractedState.attractionCount > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058E")]
		public bool TalkingToRequestor
		{
			[Cpp2IlInjected.Token(Token = "0x60025F9")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D80", Offset = "0x12F2780", VA = "0x1812F3D80")]
			get
			{
				return _talkingToRequestor > 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60025FA")]
			[Cpp2IlInjected.Address(RVA = "0x12F4320", Offset = "0x12F2D20", VA = "0x1812F4320")]
			set
			{
				//Discarded unreachable code: IL_003a, IL_0067, IL_0073
				//IL_0039: Expected O, but got I4
				//IL_004d: Expected O, but got I4
				int talkingToRequestor = _talkingToRequestor;
				int num = (_talkingToRequestor = Mathf.Max(0, value ? 1 : 0));
				bool flag = talkingToRequestor > 0;
				if (num > 0 != flag)
				{
					bool flag2 = default(bool);
					NavMeshAgentComponent.enabled = flag2;
					int num2 = 0;
					_navMeshStatusWhenEnablingTalkingToRequestor = (bool?)(object)num2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x13E"), Cpp2IlInjected.Token(Token = "0x4002E78")]
		public bool IsBusy
		{
			[Cpp2IlInjected.Token(Token = "0x60025FB")]
			[Cpp2IlInjected.Address(RVA = "0x12F32D0", Offset = "0x12F1CD0", VA = "0x1812F32D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60025FC")]
			[Cpp2IlInjected.Address(RVA = "0x12F41C0", Offset = "0x12F2BC0", VA = "0x1812F41C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000590")]
		public NpcDiscussionItemData ConversationData
		{
			[Cpp2IlInjected.Token(Token = "0x60025FD")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			[CompilerGenerated]
			get
			{
				return _003CConversationData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60025FE")]
			[Cpp2IlInjected.Address(RVA = "0x9765D0", Offset = "0x974FD0", VA = "0x1809765D0")]
			[CompilerGenerated]
			set
			{
				_003CConversationData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000591")]
		public GameObject ConversationPartner
		{
			[Cpp2IlInjected.Token(Token = "0x60025FF")]
			[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
			[CompilerGenerated]
			get
			{
				return _003CConversationPartner_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002600")]
			[Cpp2IlInjected.Address(RVA = "0x976520", Offset = "0x974F20", VA = "0x180976520")]
			[CompilerGenerated]
			set
			{
				_003CConversationPartner_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000592")]
		public float ConversationDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6002601")]
			[Cpp2IlInjected.Address(RVA = "0x12F2940", Offset = "0x12F1340", VA = "0x1812F2940")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject gameObject = ConversationPartner;
				int num = 0;
				if (gameObject != (UnityEngine.Object)num)
				{
					GameObject gameObject2 = ConversationPartner;
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (flag && IsAquatic == flag2)
					{
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000593")]
		public bool HasConversationPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002602")]
			[Cpp2IlInjected.Address(RVA = "0x12F2F80", Offset = "0x12F1980", VA = "0x1812F2F80")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000594")]
		public Vector3 GetConversationPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002603")]
			[Cpp2IlInjected.Address(RVA = "0x12F2CB0", Offset = "0x12F16B0", VA = "0x1812F2CB0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000595")]
		public Vector3? ConversationPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002604")]
			[Cpp2IlInjected.Address(RVA = "0x12F2A30", Offset = "0x12F1430", VA = "0x1812F2A30")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6002605")]
			[Cpp2IlInjected.Address(RVA = "0x12F4190", Offset = "0x12F2B90", VA = "0x1812F4190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000596")]
		public bool RunToConversationPartner
		{
			[Cpp2IlInjected.Token(Token = "0x6002606")]
			[Cpp2IlInjected.Address(RVA = "0x12F3B70", Offset = "0x12F2570", VA = "0x1812F3B70")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject gameObject = ConversationPartner;
				int num = 0;
				bool flag = gameObject != (UnityEngine.Object)num;
				if (flag && runToConversationPartner)
				{
					if (flag)
					{
					}
					Transform transform = ConversationPartner.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Transform transform2 = this.transform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002607")]
			[Cpp2IlInjected.Address(RVA = "0x12F4200", Offset = "0x12F2C00", VA = "0x1812F4200")]
			set
			{
				runToConversationPartner = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000597")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x169"), Cpp2IlInjected.Token(Token = "0x4002E80")]
		public bool WaitingForConversationPartner
		{
			[Cpp2IlInjected.Token(Token = "0x6002608")]
			[Cpp2IlInjected.Address(RVA = "0x12F3DA0", Offset = "0x12F27A0", VA = "0x1812F3DA0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002609")]
			[Cpp2IlInjected.Address(RVA = "0x12F4480", Offset = "0x12F2E80", VA = "0x1812F4480")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000598")]
		public GameObject Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x600260A")]
			[Cpp2IlInjected.Address(RVA = "0x12F26D0", Offset = "0x12F10D0", VA = "0x1812F26D0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance._avatar.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000599")]
		public PlayerAvatar AvatarComponent
		{
			[Cpp2IlInjected.Token(Token = "0x600260B")]
			[Cpp2IlInjected.Address(RVA = "0x12F2680", Offset = "0x12F1080", VA = "0x1812F2680")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Avatar.GetComponent<PlayerAvatar>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x16A"), Cpp2IlInjected.Token(Token = "0x4002E81")]
		public bool ShouldBeCloseToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600260C")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D10", Offset = "0x12F2710", VA = "0x1812F3D10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600260D")]
			[Cpp2IlInjected.Address(RVA = "0x12F42D0", Offset = "0x12F2CD0", VA = "0x1812F42D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700059B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x16B"), Cpp2IlInjected.Token(Token = "0x4002E82")]
		public bool WorkingAtAShop
		{
			[Cpp2IlInjected.Token(Token = "0x600260E")]
			[Cpp2IlInjected.Address(RVA = "0x12F3DC0", Offset = "0x12F27C0", VA = "0x1812F3DC0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600260F")]
			[Cpp2IlInjected.Address(RVA = "0x12F4490", Offset = "0x12F2E90", VA = "0x1812F4490")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700059C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x16C"), Cpp2IlInjected.Token(Token = "0x4002E83")]
		public bool ExecutingRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6002610")]
			[Cpp2IlInjected.Address(RVA = "0x12F2CA0", Offset = "0x12F16A0", VA = "0x1812F2CA0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002611")]
			[Cpp2IlInjected.Address(RVA = "0x12F41B0", Offset = "0x12F2BB0", VA = "0x1812F41B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700059D")]
		public DebugForceBehaviourType DebugForceBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x6002612")]
			[Cpp2IlInjected.Address(RVA = "0x12F2BE0", Offset = "0x12F15E0", VA = "0x1812F2BE0")]
			get
			{
				//IL_001b: Expected O, but got I4
				switch (_debugForceBehaviour)
				{
				case DebugForceBehaviourType.Sit:
				{
					MotivationConfig motivationConfig = debugForceSitMotivation;
					int num = 0;
					if (motivationConfig != (UnityEngine.Object)num)
					{
						return _debugForceBehaviour;
					}
					break;
				}
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002613")]
			[Cpp2IlInjected.Address(RVA = "0x12F41A0", Offset = "0x12F2BA0", VA = "0x1812F41A0")]
			set
			{
				_debugForceBehaviour = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059E")]
		public bool ShouldForceDebugBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x6002614")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D20", Offset = "0x12F2720", VA = "0x1812F3D20")]
			get
			{
				return DebugForceBehaviour != DebugForceBehaviourType.None;
			}
			[Cpp2IlInjected.Token(Token = "0x6002615")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700059F")]
		public Stall MyStall
		{
			[Cpp2IlInjected.Token(Token = "0x6002617")]
			[Cpp2IlInjected.Address(RVA = "0x739280", Offset = "0x737C80", VA = "0x180739280")]
			[CompilerGenerated]
			get
			{
				return _003CMyStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002618")]
			[Cpp2IlInjected.Address(RVA = "0x73A360", Offset = "0x738D60", VA = "0x18073A360")]
			[CompilerGenerated]
			private set
			{
				_003CMyStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A0")]
		public unsafe Vector3 CharacterSize
		{
			[Cpp2IlInjected.Token(Token = "0x6002619")]
			[Cpp2IlInjected.Address(RVA = "0x12F2920", Offset = "0x12F1320", VA = "0x1812F2920")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600261A")]
			[Cpp2IlInjected.Address(RVA = "0x12F3DF0", Offset = "0x12F27F0", VA = "0x1812F3DF0")]
			[CompilerGenerated]
			private set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)_003CCharacterSize_003Ek__BackingField)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A1")]
		public float WalkSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600261B")]
			[Cpp2IlInjected.Address(RVA = "0x12F3DB0", Offset = "0x12F27B0", VA = "0x1812F3DB0", Slot = "16")]
			get
			{
				return walkSpeed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A2")]
		public float RunSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x600261C")]
			[Cpp2IlInjected.Address(RVA = "0x12F3B60", Offset = "0x12F2560", VA = "0x1812F3B60", Slot = "17")]
			get
			{
				return runSpeed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A3")]
		public bool CanDoGiveAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x600261D")]
			[Cpp2IlInjected.Address(RVA = "0x12F2800", Offset = "0x12F1200", VA = "0x1812F2800")]
			get
			{
				//Discarded unreachable code: IL_001a
				if (CanGiveWhileSeated)
				{
					return true;
				}
				return !RelaxingBehaviour.Relaxing;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A4")]
		public Meta.Character MetaCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x600261E")]
			[Cpp2IlInjected.Address(RVA = "0x12F39C0", Offset = "0x12F23C0", VA = "0x1812F39C0")]
			get
			{
				//Discarded unreachable code: IL_0038
				Meta.Character metaCharacter = _metaCharacter;
				if (metaCharacter == null)
				{
					ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
					Item item = Item;
					Meta.Character character = (_metaCharacter = world_.GetCharacter(item));
				}
				return metaCharacter;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C1"), Cpp2IlInjected.Token(Token = "0x4002E97")]
		public bool TraversingLink
		{
			[Cpp2IlInjected.Token(Token = "0x600261F")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D90", Offset = "0x12F2790", VA = "0x1812F3D90", Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002620")]
			[Cpp2IlInjected.Address(RVA = "0x12F4470", Offset = "0x12F2E70", VA = "0x1812F4470", Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170005A6")]
		public int CurrentAvoidancePriority
		{
			[Cpp2IlInjected.Token(Token = "0x6002621")]
			[Cpp2IlInjected.Address(RVA = "0x12F2A40", Offset = "0x12F1440", VA = "0x1812F2A40")]
			get
			{
				//Discarded unreachable code: IL_000c
				return NavMeshAgentComponent.avoidancePriority;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A7")]
		public GameObject CharacterAudioEmitterObj
		{
			[Cpp2IlInjected.Token(Token = "0x6002622")]
			[Cpp2IlInjected.Address(RVA = "0x12F28E0", Offset = "0x12F12E0", VA = "0x1812F28E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return cullingScript.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A8")]
		internal bool HasSpecificLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6002630")]
			[Cpp2IlInjected.Address(RVA = "0x12F2FC0", Offset = "0x12F19C0", VA = "0x1812F2FC0")]
			get
			{
				//Discarded unreachable code: IL_0022
				CharacterItemData characterItemData = Data;
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client metaClient2 = SystemRoot.Instance.MetaClient;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A9")]
		public bool InRealm
		{
			[Cpp2IlInjected.Token(Token = "0x600263A")]
			[Cpp2IlInjected.Address(RVA = "0x12F3180", Offset = "0x12F1B80", VA = "0x1812F3180")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (MetaCharacter == null)
				{
				}
				return MetaCharacter.InRealm;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AA")]
		public bool InVillage
		{
			[Cpp2IlInjected.Token(Token = "0x600263B")]
			[Cpp2IlInjected.Address(RVA = "0x12F31C0", Offset = "0x12F1BC0", VA = "0x1812F31C0")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (MetaCharacter == null)
				{
				}
				return MetaCharacter.InVillage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AB")]
		public bool IsUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600263C")]
			[Cpp2IlInjected.Address(RVA = "0x12F38C0", Offset = "0x12F22C0", VA = "0x1812F38C0")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (MetaCharacter == null)
				{
				}
				return MetaCharacter.IsUnlocked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AC")]
		public bool InEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600263D")]
			[Cpp2IlInjected.Address(RVA = "0x12F3140", Offset = "0x12F1B40", VA = "0x1812F3140")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (MetaCharacter == null)
				{
				}
				return MetaCharacter.InEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AD")]
		public bool DiscussedWithTheAvatarToday
		{
			[Cpp2IlInjected.Token(Token = "0x600263E")]
			[Cpp2IlInjected.Address(RVA = "0x12F2C80", Offset = "0x12F1680", VA = "0x1812F2C80")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MetaCharacter.discussedWithTheAvatarToday_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AE")]
		public bool CanGiftItem
		{
			[Cpp2IlInjected.Token(Token = "0x600263F")]
			[Cpp2IlInjected.Address(RVA = "0x12F2840", Offset = "0x12F1240", VA = "0x1812F2840")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MetaCharacter.CanGiftItem();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AF")]
		public bool AreSwitcherButtonsUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6002640")]
			[Cpp2IlInjected.Address(RVA = "0x12F24F0", Offset = "0x12F0EF0", VA = "0x1812F24F0")]
			get
			{
				//Discarded unreachable code: IL_0030
				Meta.Character metaCharacter = MetaCharacter;
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				return metaCharacter.AreSwitcherButtonsUnlocked(profile, _003CTransactionContext_003Ek__BackingField);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B0")]
		string IDialogueActor.name
		{
			[Cpp2IlInjected.Token(Token = "0x6002641")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB50", Offset = "0x7D9550", VA = "0x1807DAB50", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.displayName_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B1")]
		Texture2D IDialogueActor.portrait
		{
			[Cpp2IlInjected.Token(Token = "0x6002642")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B2")]
		Sprite IDialogueActor.portraitSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6002643")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B3")]
		Color IDialogueActor.dialogueColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002644")]
			[Cpp2IlInjected.Address(RVA = "0x12EC580", Offset = "0x12EAF80", VA = "0x1812EC580", Slot = "7")]
			get
			{
				Color white = Color.white;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B4")]
		Vector3 IDialogueActor.dialoguePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002645")]
			[Cpp2IlInjected.Address(RVA = "0x12EC5B0", Offset = "0x12EAFB0", VA = "0x1812EC5B0", Slot = "8")]
			get
			{
				GameObject gameObject = default(GameObject);
				Transform transform = gameObject.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B5")]
		public MissionSlot PreferredDialogueSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6002646")]
			[Cpp2IlInjected.Address(RVA = "0xCA8F30", Offset = "0xCA7930", VA = "0x180CA8F30")]
			[CompilerGenerated]
			get
			{
				return _003CPreferredDialogueSlot_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002647")]
			[Cpp2IlInjected.Address(RVA = "0xCA91A0", Offset = "0xCA7BA0", VA = "0x180CA91A0")]
			[CompilerGenerated]
			private set
			{
				_003CPreferredDialogueSlot_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B6")]
		public DialogueTree PreferredDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x6002648")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BF0", Offset = "0xCA75F0", VA = "0x180CA8BF0")]
			[CompilerGenerated]
			get
			{
				return _003CPreferredDialogue_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002649")]
			[Cpp2IlInjected.Address(RVA = "0xCA9190", Offset = "0xCA7B90", VA = "0x180CA9190")]
			[CompilerGenerated]
			private set
			{
				_003CPreferredDialogue_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B7")]
		public IBlackboard PreferredBlackboard
		{
			[Cpp2IlInjected.Token(Token = "0x600264A")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BC0", Offset = "0xCA75C0", VA = "0x180CA8BC0")]
			[CompilerGenerated]
			get
			{
				return _003CPreferredBlackboard_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600264B")]
			[Cpp2IlInjected.Address(RVA = "0xCA9180", Offset = "0xCA7B80", VA = "0x180CA9180")]
			[CompilerGenerated]
			private set
			{
				_003CPreferredBlackboard_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B8")]
		private ICollection<ProfessionItemData> AvailableProfessions
		{
			[Cpp2IlInjected.Token(Token = "0x6002662")]
			[Cpp2IlInjected.Address(RVA = "0x12F2650", Offset = "0x12F1050", VA = "0x1812F2650")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (ICollection<ProfessionItemData>)MetaCharacter.get_AvailableProfessions();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B9")]
		private int ProfessionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6002663")]
			[Cpp2IlInjected.Address(RVA = "0x12F3B00", Offset = "0x12F2500", VA = "0x1812F3B00")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MetaCharacter.GetProfessionLevel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BA")]
		private ProfessionItemData Profession
		{
			[Cpp2IlInjected.Token(Token = "0x6002664")]
			[Cpp2IlInjected.Address(RVA = "0x12F3B30", Offset = "0x12F2530", VA = "0x1812F3B30")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MetaCharacter.Profession;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BB")]
		public unsafe CharacterState CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x6002669")]
			[Cpp2IlInjected.Address(RVA = "0x12F2A70", Offset = "0x12F1470", VA = "0x1812F2A70")]
			get
			{
				//Discarded unreachable code: IL_007e
				//IL_0015: Expected native int or pointer, but got O
				//IL_0056: Expected F4, but got I4
				//IL_0051: Expected native int or pointer, but got O
				Transform transform = this.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				CharacterState characterState = default(CharacterState);
				((Vector3*)(IntPtr)characterState.position)->z = z;
				bool flag = (characterState.isTalkingToRequestor = _talkingToRequestor > 0);
				if (characterState.isMovingToTargetPosition = IsMovingToTargetPosition)
				{
					Blackboard component = GetComponent<Blackboard>();
					((Vector3*)(IntPtr)characterState.targetPosition)->z = 0f;
					float num = (characterState.moveToKeepDistance = component.GetValue<float>("moveToKeepDistance"));
					bool flag2 = (characterState.runToMoveToTarget = runToMoveToTarget);
				}
				return characterState;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025CA")]
		[Cpp2IlInjected.Address(RVA = "0x12EA5F0", Offset = "0x12E8FF0", VA = "0x1812EA5F0")]
		public void EnableAI(bool enabled)
		{
			//Discarded unreachable code: IL_0019, IL_0023
			//IL_0022: Expected O, but got I4
			BehaviorTreeOwnerComponent.enabled = enabled;
			NavMeshAgentComponent.enabled = enabled;
		}

		[Cpp2IlInjected.Token(Token = "0x60025CB")]
		[Cpp2IlInjected.Address(RVA = "0x12EA6B0", Offset = "0x12E90B0", VA = "0x1812EA6B0")]
		public void EnableNavMeshAgent(bool enabled)
		{
			//Discarded unreachable code: IL_000d, IL_0017
			//IL_0016: Expected O, but got I4
			NavMeshAgentComponent.enabled = enabled;
		}

		[Cpp2IlInjected.Token(Token = "0x60025DD")]
		[Cpp2IlInjected.Address(RVA = "0x12EAB20", Offset = "0x12E9520", VA = "0x1812EAB20")]
		public void ForceVisibility(bool? forcedVisibility)
		{
			//Discarded unreachable code: IL_005c
			//IL_002e: Expected O, but got I4
			if (!blinkModeInitialized)
			{
				blinkModeInitialized = true;
				BlinkMode blinkMode = (this.blinkMode = GetComponent<BlinkMode>());
			}
			BlinkMode blinkMode2 = this.blinkMode;
			int num = 0;
			if (blinkMode2 != (UnityEngine.Object)num)
			{
				if (!blinkModeInitialized)
				{
					blinkModeInitialized = true;
					BlinkMode blinkMode3 = (this.blinkMode = GetComponent<BlinkMode>());
				}
				this.blinkMode.ForcedVisibility = forcedVisibility;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025DE")]
		[Cpp2IlInjected.Address(RVA = "0x12EEDE0", Offset = "0x12ED7E0", VA = "0x1812EEDE0")]
		public void Show()
		{
			if (!shown)
			{
				ChangeVisibility(show: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025DF")]
		[Cpp2IlInjected.Address(RVA = "0x12EBAA0", Offset = "0x12EA4A0", VA = "0x1812EBAA0")]
		public void Hide()
		{
			if (shown)
			{
				int show = 0;
				ChangeVisibility((byte)show != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025E0")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F40", Offset = "0x12E8940", VA = "0x1812E9F40")]
		private void ChangeVisibility(bool show)
		{
			//Discarded unreachable code: IL_0070, IL_0076
			int num = 0;
			shown = show;
			if ((blinkModeInitialized ? 1 : 0) == num)
			{
				blinkModeInitialized = true;
				BlinkMode blinkMode = (this.blinkMode = GetComponent<BlinkMode>());
			}
			bool flag = default(bool);
			if (!flag)
			{
				List<GameObject> list = visualGameObjects;
				bool flag2 = default(bool);
				if (flag2)
				{
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
				}
			}
			blinkModeInitialized = true;
			BlinkMode blinkMode2 = (this.blinkMode = GetComponent<BlinkMode>());
			bool flag4 = default(bool);
			if (flag4)
			{
				blinkModeInitialized = true;
				BlinkMode blinkMode3 = (this.blinkMode = GetComponent<BlinkMode>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025E4")]
		[Cpp2IlInjected.Address(RVA = "0x12EBD60", Offset = "0x12EA760", VA = "0x1812EBD60")]
		public bool IsFollowingAvatar()
		{
			//IL_0019: Expected O, but got I4
			if (!_isHangingOutWithAvatar)
			{
				GameObject avatar = Avatar;
				int num = 0;
				if (avatar != (UnityEngine.Object)num)
				{
					GameObject gameObject = characterToFollow;
					GameObject avatar2 = Avatar;
					if (gameObject == avatar2)
					{
						goto IL_0037;
					}
				}
				int num2 = 0;
			}
			goto IL_0037;
			IL_0037:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60025EB")]
		[Cpp2IlInjected.Address(RVA = "0x12EC230", Offset = "0x12EAC30", VA = "0x1812EC230")]
		public void MoveToTargetPosition(Vector3 position, float distance, bool running = false, bool cancelHangoutAudio = true, bool cancelHangoutTemporary = false)
		{
			//Discarded unreachable code: IL_00db
			//IL_0013: Expected O, but got I4
			//IL_0026: Expected O, but got F4
			//IL_0033: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			Blackboard component = GetComponent<Blackboard>();
			bool flag = default(bool);
			component["moveToTargetPosition"] = flag;
			float z = position.z;
			component["targetPosition"] = z;
			bool flag2 = default(bool);
			component["resetMoveToTargetPositionOnArrival"] = flag2;
			component["moveToKeepDistance"] = flag2;
			if (runToMoveToTarget != running)
			{
				runToMoveToTarget = running;
				bool isRunning = IsRunning;
				NavMeshAgent navMeshAgent = NavMeshAgentComponent;
				lastIsRunning = isRunning;
				if (isRunning)
				{
				}
				float num2 = (navMeshAgent.speed = walkSpeed);
			}
			bool isRunning2 = IsRunning;
			NavMeshAgent navMeshAgent2 = NavMeshAgentComponent;
			lastIsRunning = isRunning2;
			if (isRunning2)
			{
			}
			float num4 = (navMeshAgent2.speed = walkSpeed);
			int num5 = 0;
			CharacterToFollow = (GameObject)num5;
			WorkingAtAShop = false;
			if (_isHangingOutWithAvatar)
			{
				HangoutSystem system = SystemRoot.Instance.GetSystem<HangoutSystem>();
				System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025EC")]
		[Cpp2IlInjected.Address(RVA = "0x12E9DA0", Offset = "0x12E87A0", VA = "0x1812E9DA0")]
		public void CancelMoveToTargetPosition()
		{
			//Discarded unreachable code: IL_009a
			//IL_0013: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			Blackboard component = GetComponent<Blackboard>();
			bool flag = default(bool);
			component["moveToTargetPosition"] = flag;
			bool flag2 = default(bool);
			component["resetMoveToTargetPositionOnArrival"] = flag2;
			component["moveToKeepDistance"] = flag2;
			if (runToMoveToTarget)
			{
				runToMoveToTarget = false;
				bool isRunning = IsRunning;
				NavMeshAgent navMeshAgent = NavMeshAgentComponent;
				lastIsRunning = isRunning;
				if (isRunning)
				{
				}
				float num2 = (navMeshAgent.speed = walkSpeed);
			}
			bool isRunning2 = IsRunning;
			NavMeshAgent navMeshAgent2 = NavMeshAgentComponent;
			lastIsRunning = isRunning2;
			if (isRunning2)
			{
			}
			float num4 = (navMeshAgent2.speed = walkSpeed);
		}

		[Cpp2IlInjected.Token(Token = "0x60025EF")]
		[Cpp2IlInjected.Address(RVA = "0x12EC0A0", Offset = "0x12EAAA0", VA = "0x1812EC0A0")]
		[AsyncStateMachine(typeof(_003CMoveToTargetPositionAsync_003Ed__131))]
		public System.Threading.Tasks.Task MoveToTargetPositionAsync(Vector3 position, bool running, Action<bool> previousResetMoveToTargetPositionOnArrival, bool restoreFollowAfterReachingPosition, CancellationToken ct, float closeEnoughDistance = 1f, bool cancelHangoutAudio = true, bool cancelHangoutTemporary = false)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025F0")]
		[Cpp2IlInjected.Address(RVA = "0x12EE400", Offset = "0x12ECE00", VA = "0x1812EE400")]
		public void ResetMoveToTargetPosition(bool? previousResetMoveToTargetPositionOnArrival)
		{
			//Discarded unreachable code: IL_0020
			//IL_0013: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			Blackboard component = GetComponent<Blackboard>();
			bool flag = default(bool);
			component["moveToTargetPosition"] = flag;
			bool flag2 = default(bool);
			component["resetMoveToTargetPositionOnArrival"] = flag2;
		}

		[Cpp2IlInjected.Token(Token = "0x60025F2")]
		[Cpp2IlInjected.Address(RVA = "0x12EBF30", Offset = "0x12EA930", VA = "0x1812EBF30")]
		[AsyncStateMachine(typeof(_003CMoveToTargetAsync_003Ed__135))]
		public System.Threading.Tasks.Task MoveToTargetAsync(GameObject target, float distance, bool running, Action<bool> previousResetMoveToTargetOnArrival, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60025F3")]
		[Cpp2IlInjected.Address(RVA = "0x12EE500", Offset = "0x12ECF00", VA = "0x1812EE500")]
		public void ResetMoveToTarget(bool? previousResetMoveToTargetOnArrival)
		{
			//Discarded unreachable code: IL_002e
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			Blackboard component = GetComponent<Blackboard>();
			int num = 0;
			component["moveToTarget"] = num;
			bool flag = default(bool);
			component["resetMoveToTargetOnArrival"] = flag;
			component["moveToKeepDistance"] = component;
		}

		[Cpp2IlInjected.Token(Token = "0x6002616")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD80", Offset = "0x12E9780", VA = "0x1812EAD80")]
		public MotivationConfig GetForcedBehaviour()
		{
			switch (DebugForceBehaviour)
			{
			case DebugForceBehaviourType.Sit:
				return debugForceSitMotivation;
			case DebugForceBehaviourType.Fish:
				return debugForceFishMotivation;
			default:
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002623")]
		[Cpp2IlInjected.Address(RVA = "0x12E94B0", Offset = "0x12E7EB0", VA = "0x1812E94B0")]
		private unsafe void Awake()
		{
			//Discarded unreachable code: IL_00c6
			//IL_006b: Expected O, but got I4
			//IL_0098: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			Transform transform = (this.transform = base.transform);
			GameObject gameObject = (this.gameObject = base.gameObject);
			Item item = (Item = GetComponent<ItemScript>().Item);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item2 = Item;
			CharacterItemData characterItemData = (Data = _003CInstance_003Ek__BackingField.GetItemData<CharacterItemData>(item2));
			SkinnedMeshRenderer componentInChildren = GetComponentInChildren<SkinnedMeshRenderer>();
			int num3 = 0;
			if (!(componentInChildren != (UnityEngine.Object)num3))
			{
				Item arg = Item;
				Debug.LogError($"The GameObject of {arg} does not have SkinnedMeshRenderer");
			}
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)CharacterSize)->z = z;
			int num4 = (moveBoolHash = UnityEngine.Animator.StringToHash("Move"));
			int num5 = (runFloatHash = UnityEngine.Animator.StringToHash("Run"));
		}

		[Cpp2IlInjected.Token(Token = "0x6002624")]
		[Cpp2IlInjected.Address(RVA = "0x12F0C80", Offset = "0x12EF680", VA = "0x1812F0C80")]
		private void Start()
		{
			Animator animator = (AnimatorComponent = gameObject.GetComponentInChildren<Animator>());
			SetDefaultAnimatorVariables();
			CharacterVisualNodes characterVisualNodes = (CharacterVisualNodes = gameObject.GetComponent<CharacterVisualNodes>());
			NavMeshAgent navMeshAgent = (NavMeshAgentComponent = gameObject.GetComponentInChildren<NavMeshAgent>());
			BehaviourTreeOwner behaviourTreeOwner = (BehaviorTreeOwnerComponent = gameObject.GetComponent<BehaviourTreeOwner>());
			RelaxingBehaviour relaxingBehaviour = (RelaxingBehaviour = GetComponent<RelaxingBehaviour>());
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			bool flag = QuestGiver(profile);
			AK.Wwise.Switch @switch = characterSwitch;
			IsQuestGiver = flag;
			GameObject value = audioEmitter;
			@switch.SetValue(value);
			AK.Wwise.Switch switch2 = ipSwitch;
			GameObject value2 = audioEmitter;
			switch2.SetValue(value2);
			AK.Wwise.Switch switch3 = skinVariation;
			GameObject value3 = audioEmitter;
			switch3.SetValue(value3);
			AudioEmitterCullingManager audioEmitterCullingManager = (cullingScript = audioEmitter.GetComponent<AudioEmitterCullingManager>());
			CharacterAttractedToAvatarState characterAttractedToAvatarState = (AttractedState = gameObject.GetComponent<CharacterAttractedToAvatarState>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002625")]
		[Cpp2IlInjected.Address(RVA = "0x12ED7B0", Offset = "0x12EC1B0", VA = "0x1812ED7B0")]
		private unsafe bool QuestGiver(Profile profile)
		{
			//Discarded unreachable code: IL_0063, IL_0069, IL_006f, IL_0075, IL_007b, IL_0081
			ICollection<MissionQueue> values;
			int num4 = default(int);
			MissionSlot slot = default(MissionSlot);
			MissionSlot missionSlot = default(MissionSlot);
			int num;
			while (true)
			{
				num = 0;
				int num2 = 0;
				values = (ICollection<MissionQueue>)((MapField<TKey, TValue>)(object)profile.world_.missionSlots_).get_Values();
				if (values == null)
				{
					break;
				}
				int num3 = 0;
				while (num4 <= 0)
				{
				}
				int num5 = 0;
				if (CharacterUtil.QuestIsActive(slot))
				{
					Item item = Item;
					int num6 = 0;
					Item characterItem = missionSlot.CharacterItem;
					if (*(Item*)item == *(Item*)characterItem)
					{
						num++;
						break;
					}
				}
			}
			num++;
			if (values != null)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002626")]
		[Cpp2IlInjected.Address(RVA = "0x12EC710", Offset = "0x12EB110", VA = "0x1812EC710")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0043
			//IL_0010: Expected O, but got I4
			NavMeshAgent navMeshAgent = NavMeshAgentComponent;
			int num = 0;
			if (navMeshAgent != (UnityEngine.Object)num)
			{
				bool isRunning = IsRunning;
				NavMeshAgent navMeshAgent2 = NavMeshAgentComponent;
				lastIsRunning = isRunning;
				if (isRunning)
				{
				}
				float num3 = (navMeshAgent2.speed = walkSpeed);
			}
			SetDefaultAnimatorVariables();
		}

		[Cpp2IlInjected.Token(Token = "0x6002627")]
		[Cpp2IlInjected.Address(RVA = "0x12EC620", Offset = "0x12EB020", VA = "0x1812EC620")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_002f
			//IL_001b: Expected O, but got I4
			AkSoundEngine.StopAll(gameObject);
			Animator animator = AnimatorComponent;
			int num = 0;
			if (animator != (UnityEngine.Object)num)
			{
				AkSoundEngine.StopAll(AnimatorComponent.gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002628")]
		[Cpp2IlInjected.Address(RVA = "0x12F1D70", Offset = "0x12F0770", VA = "0x1812F1D70")]
		private void Update()
		{
			//Discarded unreachable code: IL_024a
			//IL_007f: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			//IL_01df: Expected O, but got I4
			CharacterState characterState = postponedRestoreState;
			int num = 0;
			if (characterState != null)
			{
				if (postponedRestoreTransform)
				{
					Transform transform = this.transform;
					float z = characterState.position.z;
					Transform transform2 = this.transform;
					Quaternion quaternion = (transform2.rotation = characterState.rotation);
				}
				if ((characterState.isTalkingToRequestor ? 1 : 0) != num)
				{
					TalkingToRequestor = true;
					SystemRoot.Instance.GetSystem<DialogueSystem>().SetCurrentDialogueActor(this);
				}
				if ((characterState.isMovingToTargetPosition ? 1 : 0) != num)
				{
					float z2 = characterState.targetPosition.z;
				}
				postponedRestoreState = (CharacterState)num;
			}
			if (NavMeshAgentComponent.enabled && NavMeshAgentComponent.isOnOffMeshLink && (TraversingLink ? 1 : 0) == num)
			{
				UnityEngine.Object navMeshOwner = NavMeshAgentComponent.navMeshOwner;
				int num2 = 0;
				if ((object)navMeshOwner != null)
				{
					int num3 = 0;
					if ((object)navMeshOwner != null)
					{
						bool flag = default(bool);
						if (flag)
						{
							System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
							asyncTask.FireAndForgetTask();
						}
						goto IL_00d3;
					}
				}
				throw new InvalidCastException();
			}
			goto IL_00d3;
			IL_00d3:
			bool flag2 = lastIsRunning;
			bool isRunning = IsRunning;
			if (flag2 != isRunning)
			{
				bool isRunning2 = IsRunning;
				NavMeshAgent navMeshAgent = NavMeshAgentComponent;
				lastIsRunning = isRunning2;
				if (isRunning2)
				{
				}
				float num5 = (navMeshAgent.speed = walkSpeed);
			}
			NavMeshAgent navMeshAgent2 = NavMeshAgentComponent;
			Vector3 vector = default(Vector3);
			float z3 = vector.z;
			AudioEmitterCullingManager audioEmitterCullingManager = cullingScript;
			int num6 = 0;
			bool flag3 = audioEmitterCullingManager == (UnityEngine.Object)num6;
			int num7 = 0;
			float num10 = default(float);
			float num8;
			if (flag3 || cullingScript.isInsideCollider)
			{
				if (isUsingMoveSfx)
				{
					if (isUsingMoveSfx || isUsingMoveSfx)
					{
						num8 = prevSpeed;
						if (!isUsingMoveSfx)
						{
							AK.Wwise.Event @event = moveSfx;
							GameObject gameObject = audioEmitter;
							uint num9 = @event.Post(gameObject);
						}
					}
					prevSpeed = num10;
				}
				GameObject in_gameObjectID = audioEmitter;
				float num5 = num10;
				AKRESULT aKRESULT = AkSoundEngine.SetRTPCValue("RTPC_Char_Npc_Speed", num5, in_gameObjectID);
			}
			int value = default(int);
			bool flag4 = default(bool);
			if (!UseRunAnimation)
			{
				GameObject gameObject2 = characterToFollow;
				value = 0;
				int num11 = 0;
				flag4 = gameObject2 != (UnityEngine.Object)num11;
				if (!flag4 && _isHangingOutWithAvatar == flag4)
				{
					goto IL_020f;
				}
			}
			float num12 = walkSpeed;
			if (_isHangingOutWithAvatar == flag4)
			{
			}
			num8 = num10;
			float num13 = Mathf.Clamp01(num8);
			goto IL_020f;
			IL_020f:
			Animator animator = AnimatorComponent;
			int id = moveBoolHash;
			animator.SetBool(id, (byte)value != 0);
			Animator animator2 = AnimatorComponent;
			int id2 = runFloatHash;
			num12 = num13;
			animator2.SetFloat(id2, num12);
		}

		[Cpp2IlInjected.Token(Token = "0x6002629")]
		[Cpp2IlInjected.Address(RVA = "0x12F1BD0", Offset = "0x12F05D0", VA = "0x1812F1BD0")]
		private void UpdateAudio(float speed)
		{
			//IL_0010: Expected O, but got I4
			AudioEmitterCullingManager audioEmitterCullingManager = cullingScript;
			int num = 0;
			if (!(audioEmitterCullingManager == (UnityEngine.Object)num) && !cullingScript.isInsideCollider)
			{
				return;
			}
			if (isUsingMoveSfx)
			{
				if (isUsingMoveSfx)
				{
					throw new NullReferenceException();
				}
				if (isUsingMoveSfx)
				{
					AK.Wwise.Event @event = stopSfx;
					GameObject gameObject = audioEmitter;
					uint num2 = @event.Post(gameObject);
				}
				prevSpeed = speed;
			}
			GameObject in_gameObjectID = audioEmitter;
			AKRESULT aKRESULT = AkSoundEngine.SetRTPCValue("RTPC_Char_Npc_Speed", speed, in_gameObjectID);
		}

		[Cpp2IlInjected.Token(Token = "0x600262A")]
		[Cpp2IlInjected.Address(RVA = "0x12F1D20", Offset = "0x12F0720", VA = "0x1812F1D20")]
		private void UpdateSpeed()
		{
			//Discarded unreachable code: IL_0028
			bool isRunning = IsRunning;
			NavMeshAgent navMeshAgent = NavMeshAgentComponent;
			lastIsRunning = isRunning;
			if (isRunning)
			{
			}
			float num2 = (navMeshAgent.speed = walkSpeed);
		}

		[Cpp2IlInjected.Token(Token = "0x600262B")]
		[Cpp2IlInjected.Address(RVA = "0x12EC610", Offset = "0x12EB010", VA = "0x1812EC610")]
		private void OnDestroy()
		{
			UnregisterAvatarTeleport();
		}

		[Cpp2IlInjected.Token(Token = "0x600262C")]
		[Cpp2IlInjected.Address(RVA = "0x12EE0B0", Offset = "0x12ECAB0", VA = "0x1812EE0B0")]
		private void RegisterAvatarTeleport()
		{
			//Discarded unreachable code: IL_0048
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				PlayerAvatar.AvatarTeleported value = Character_OnAvatarTeleported;
				avatar.OnAvatarTeleported -= value;
				PlayerAvatar.AvatarTeleported value2 = Character_OnAvatarTeleported;
				avatar.OnAvatarTeleported += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600262D")]
		[Cpp2IlInjected.Address(RVA = "0x12F1A00", Offset = "0x12F0400", VA = "0x1812F1A00")]
		private void UnregisterAvatarTeleport()
		{
			//Discarded unreachable code: IL_0032
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				PlayerAvatar.AvatarTeleported value = Character_OnAvatarTeleported;
				avatar.OnAvatarTeleported -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600262E")]
		[Cpp2IlInjected.Address(RVA = "0x12EA260", Offset = "0x12E8C60", VA = "0x1812EA260")]
		private void Character_OnAvatarTeleported(Vector3 position, PlayerAvatar.AvatarTeleportedReason reason)
		{
			//Discarded unreachable code: IL_005f
			//IL_0046: Expected O, but got I4
			int num = 0;
			if (!IsFollowingAvatar())
			{
				return;
			}
			if (reason == PlayerAvatar.AvatarTeleportedReason.PlayerTask)
			{
				PlayerNavigation playerNavigation = default(PlayerNavigation);
				PlayerTask currentTask = playerNavigation.CurrentTask;
				if ((object)currentTask != null)
				{
					PlayerTaskCollider _003CTaskCollider_003Ek__BackingField = currentTask.TaskCollider;
					if ((object)_003CTaskCollider_003Ek__BackingField != null)
					{
						GameObject gameObject = _003CTaskCollider_003Ek__BackingField.gameObject;
					}
				}
				int num2 = 0;
				GameObject gameObject2 = this.gameObject;
				if ((UnityEngine.Object)num2 == gameObject2)
				{
					return;
				}
			}
			float z = position.z;
			bool flag = default(bool);
			if (flag)
			{
			}
			float z2 = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600262F")]
		[Cpp2IlInjected.Address(RVA = "0x12EBAC0", Offset = "0x12EA4C0", VA = "0x1812EBAC0")]
		internal void InitAI([System.Runtime.InteropServices.Optional] BehaviourTree behaviourTreeOverride)
		{
			//Discarded unreachable code: IL_00ad, IL_00b3, IL_00b9, IL_00bf, IL_00c5, IL_00cb, IL_00d1
			//IL_0009: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			BehaviourTreeOwner behaviourTreeOwner2 = default(BehaviourTreeOwner);
			while (true)
			{
				int num = 0;
				if (!(behaviourTreeOverride != (UnityEngine.Object)num))
				{
					if (MetaCharacter == null || !MetaCharacter.InRealm)
					{
						break;
					}
					BehaviourTree behaviourTree = inRealmBehaviourTree;
					int num2 = 0;
					if (!(behaviourTree != (UnityEngine.Object)num2))
					{
						break;
					}
				}
				Graph graph = ((GraphOwner<T>)(object)BehaviorTreeOwnerComponent).graph;
				int num3 = 0;
				bool flag = graph == (UnityEngine.Object)num3;
				BehaviourTreeOwner behaviourTreeOwner = BehaviorTreeOwnerComponent;
				if (!flag)
				{
					Graph graph2 = ((GraphOwner<T>)(object)behaviourTreeOwner).graph;
					behaviourTreeOwner2 = BehaviorTreeOwnerComponent;
					BehaviourTree newGraph = UnityEngine.Object.Instantiate(behaviourTreeOverride);
					((GraphOwner<T>)(object)behaviourTreeOwner2).SwitchBehaviour((T)(object)newGraph);
					UnityEngine.Object.Destroy(graph2);
					break;
				}
			}
			BehaviourTree behaviourTree2 = (BehaviourTree)(((GraphOwner<T>)(object)behaviourTreeOwner2).graph = UnityEngine.Object.Instantiate(Manager.behaviourTree));
			BehaviorTreeOwnerComponent.enabled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002631")]
		[Cpp2IlInjected.Address(RVA = "0x12EAF10", Offset = "0x12E9910", VA = "0x1812EAF10")]
		internal unsafe bool GetSpecificLocationPosition(out Vector3 validPosition, out bool fixPosition, int maxFindValidPositionTries = 1)
		{
			int num = 0;
			int num2 = 0;
			return GetSpecificLocationPosition(out validPosition, out fixPosition, out *(Quaternion?*)num2, maxFindValidPositionTries);
		}

		[Cpp2IlInjected.Token(Token = "0x6002632")]
		[Cpp2IlInjected.Address(RVA = "0x12EAF40", Offset = "0x12E9940", VA = "0x1812EAF40")]
		internal bool GetSpecificLocationPosition(out Vector3 validPosition, out bool fixPosition, out Quaternion? rotation, int maxFindValidPositionTries = 1)
		{
			//IL_001f: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			int num = 0;
			float z = Vector3.zero.z;
			int num2 = 0;
			int num3 = 0;
			validPosition.z = z;
			System.Runtime.CompilerServices.Unsafe.As<Quaternion?, Nullable<>>(ref rotation).value = (T)num3;
			CharacterItemData characterItemData = Data;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool flag = default(bool);
			if (flag)
			{
				MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
				bool flag2 = default(bool);
				if (flag2)
				{
					int num4 = 0;
					int num5 = 0;
					System.Runtime.CompilerServices.Unsafe.As<Quaternion?, Nullable<>>(ref rotation).value = (T)num4;
					bool result = default(bool);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002633")]
		[Cpp2IlInjected.Address(RVA = "0x12EA8A0", Offset = "0x12E92A0", VA = "0x1812EA8A0")]
		public bool FindValidPosition(Vector3 targetPosition, out Vector3 validPosition, int maxFindValidPositionTries = 1)
		{
			//Discarded unreachable code: IL_006a
			//IL_0050: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			int num = 0;
			float num2 = (validPosition.z = Vector3.zero.z);
			Transform transform = this.transform;
			num++;
			NavMeshAgent navMeshAgent = NavMeshAgentComponent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int walkableMask = navMeshAgent.walkableMask;
			string arg = base.name;
			int num3 = default(int);
			string text = $"{arg} (Try: {num3}/{num3})";
			string text2 = base.name;
			float z2 = targetPosition.z;
			bool flag = default(bool);
			if (!flag)
			{
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6002634")]
		[Cpp2IlInjected.Address(RVA = "0x12EF200", Offset = "0x12EDC00", VA = "0x1812EF200")]
		internal bool SpawnAtSpecificLocation()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002635")]
		[Cpp2IlInjected.Address(RVA = "0x12EF7E0", Offset = "0x12EE1E0", VA = "0x1812EF7E0")]
		internal unsafe void SpawnOutside([System.Runtime.InteropServices.Optional] BaseEnvironmentDoor origin)
		{
			//Discarded unreachable code: IL_0269, IL_026e, IL_027d
			//IL_0096: Expected O, but got I4
			//IL_00da: Expected I4, but got I8
			//IL_0102: Expected O, but got I4
			//IL_010e: Expected I4, but got I8
			//IL_0191: Expected O, but got I4
			//IL_01c5: Expected I4, but got I8
			//IL_01e6: Expected I4, but got I8
			//IL_01ff: Expected I4, but got I8
			//IL_028d: Expected I4, but got O
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			ulong num8 = default(ulong);
			ItemScript itemScript = default(ItemScript);
			GameObject gameObject2 = default(GameObject);
			ulong num10 = default(ulong);
			ItemScript itemScript2 = default(ItemScript);
			GoBehaviourSystem goBehaviourSystem = default(GoBehaviourSystem);
			IEnumerable<MissionSlot> cpp2il__autoParamName__idx_2 = default(IEnumerable<MissionSlot>);
			MissionManager missionManager = default(MissionManager);
			Vector3 vector = default(Vector3);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			GoBehaviourSystem goBehaviourSystem2 = default(GoBehaviourSystem);
			GameObject gameObject3 = default(GameObject);
			ulong num14 = default(ulong);
			ulong num15 = default(ulong);
			Vector3 vector2 = default(Vector3);
			GameObject gameObject4 = default(GameObject);
			ulong num16 = default(ulong);
			Func<WaterSpawn, bool> func4 = default(Func<WaterSpawn, bool>);
			Vector3 vector3 = default(Vector3);
			Client client = default(Client);
			Meta.Character character = default(Meta.Character);
			Meta.Character character2 = default(Meta.Character);
			SceneData sceneData = default(SceneData);
			GameObject gameObject5 = default(GameObject);
			Func<VillageArea, bool> func5 = default(Func<VillageArea, bool>);
			Meta.Character character3 = default(Meta.Character);
			SceneData sceneData2 = default(SceneData);
			GameObject gameObject6 = default(GameObject);
			SceneData sceneData3 = default(SceneData);
			GameObject gameObject7 = default(GameObject);
			Func<VillageArea, bool> func6 = default(Func<VillageArea, bool>);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				CharacterItemData characterItemData = Data;
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				Client metaClient = SystemRoot.Instance.MetaClient;
				int canOverride = 0;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = metaClient.TransactionContext;
				ScheduleType currentSchedule = characterItemData.GetCurrentSchedule(profile, _003CTransactionContext_003Ek__BackingField, (byte)canOverride != 0);
				int num5 = (int)currentSchedule;
				if (currentSchedule == ScheduleType.SpecificLocation && SpawnAtSpecificLocation())
				{
					return;
				}
				if (MetaCharacter.InEvent)
				{
					continue;
				}
				if (MetaCharacter.InVillage || MetaCharacter.status_ == Meta.Character.Types.CharacterStatus.Unlocked)
				{
					int num6 = 0;
					if (origin != (UnityEngine.Object)num6)
					{
						break;
					}
					_003C_003Ec__DisplayClass277_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass277_0();
					int num7 = 0;
					if (_003C_003Ec._003C_003E9__277_1 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SceneData x) => (long)"{il2cpp field on {'constant1' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 1);
					}
					if (flag && !IsAquatic)
					{
						ItemScript[] componentsInChildren = gameObject.GetComponentsInChildren<ItemScript>((byte)num8 != 0);
						Func<ItemScript, bool> func = (Func<ItemScript, bool>)(object)(Func<T, TResult>)delegate(ItemScript x)
						{
							Item item5 = x.Item;
							throw new NullReferenceException();
						};
						itemScript = Enumerable.FirstOrDefault<ItemScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
					}
					int num9 = 0;
					if (itemScript == (UnityEngine.Object)num9)
					{
						ItemScript[] componentsInChildren2 = gameObject2.GetComponentsInChildren<ItemScript>((byte)num10 != 0);
						Func<ItemScript, bool> func2 = (Func<ItemScript, bool>)(object)(Func<T, TResult>)delegate(ItemScript x)
						{
							Item item4 = x.Item;
							int house = Data.House;
							throw new NullReferenceException();
						};
						itemScript2 = Enumerable.FirstOrDefault<ItemScript>((IEnumerable<>)(object)componentsInChildren2, (Func<, >)(object)func2);
					}
					int iD = Data.ID;
					int num11 = 0;
					if ((object)goBehaviourSystem != null)
					{
						Item pickaxeToolItem = goBehaviourSystem.PickaxeToolItem;
					}
					Item item = (CS_0024_003C_003E8__locals0.pickaxeItem = Item.Invalid);
					List<Vector3> list = (List<Vector3>)(object)new List<T>();
					if (!IsAquatic)
					{
						Func<MissionSlot, bool> cpp2il__autoParamName__idx_ = (Func<MissionSlot, bool>)(object)(Func<T, TResult>)delegate(MissionSlot x)
						{
							//IL_002a: Expected O, but got I4
							if (x.IsMissionStarted)
							{
								MissionStep currentStep = x.CurrentStep;
								if (currentStep != null)
								{
									MissionStepData missionStepData = currentStep.Data;
									int num19 = 0;
									if (missionStepData.HasCustomStep(MissionObjectiveData.CustomStepOneofCase.FollowCharacter, (Func<, >)num19))
									{
										Client client2 = default(Client);
										ProfilePlayer player_ = client2.profile.player_;
										Item pickaxeItem = CS_0024_003C_003E8__locals0.pickaxeItem;
										return !player_.IsToolUnlocked(pickaxeItem);
									}
								}
							}
							int num20 = 0;
							throw new NullReferenceException();
						};
						if (!((IEnumerable<>)cpp2il__autoParamName__idx_2).Any<MissionSlot>((Func<, >)(object)cpp2il__autoParamName__idx_))
						{
							int num12 = 0;
							if (!(itemScript2 != (UnityEngine.Object)num12))
							{
								if (missionManager.TryGetLocationPosition("WishingWell", out *(Vector3*)num))
								{
									float z = vector.z;
								}
								if (flag2)
								{
									while (!flag3)
									{
									}
									num4++;
								}
								num4++;
								if (CS_0024_003C_003E8__locals0 != null)
								{
									continue;
								}
								if (num4 == 0)
								{
								}
								goto IL_02ca;
							}
						}
						int num13 = 0;
						Item wellItem;
						Item item2 = (wellItem = goBehaviourSystem2.WellItem);
						int itemID = item2.ItemID;
						ItemScript[] componentsInChildren3 = gameObject3.GetComponentsInChildren<ItemScript>((byte)num14 != 0);
						Func<ItemScript, bool> func3 = (Func<ItemScript, bool>)(object)(Func<T, TResult>)delegate(ItemScript x)
						{
							Item item3 = x.Item;
							throw new NullReferenceException();
						};
						Transform destination = Enumerable.FirstOrDefault<ItemScript>((IEnumerable<>)(object)componentsInChildren3, (Func<, >)(object)func3).GetComponentInChildren<PlayerTaskCollider>((byte)num15 != 0).Destination;
						float z2 = vector2.z;
					}
					WaterSpawn[] componentsInChildren4 = gameObject4.GetComponentsInChildren<WaterSpawn>((byte)num16 != 0);
					if (_003C_003Ec._003C_003E9__277_5 == null)
					{
						func4 = (Func<WaterSpawn, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((WaterSpawn x) => x.IsAvailable()));
					}
					WaterSpawn waterSpawn = Enumerable.Where<WaterSpawn>((IEnumerable<>)(object)componentsInChildren4, (Func<, >)(object)func4).RandomElement<WaterSpawn>();
					Transform transform = waterSpawn.transform;
					float z3 = vector3.z;
					CharacterSpawnTracker spawnCounts = Manager.SpawnCounts;
					WaterSpawnConfig config = waterSpawn.Config;
					Dictionary<object, int> spawnCounts2 = spawnCounts.spawnCounts;
					throw new NullReferenceException();
				}
				goto IL_02ca;
				IL_02ca:
				DateTime localTime = client.LocalTime;
				if (!character.IsSecretCharacterVisiting(localTime))
				{
					return;
				}
				int num17 = 0;
				if (character2.secretCharacterData_.spawnedInLocation_.locationTypeCase_ == SecretCharacterLocationFilter.LocationTypeOneofCase.VillageArea)
				{
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					VillageEnvironment component = gameObject5.GetComponent<VillageEnvironment>();
				}
				if ((long)func5 != 2)
				{
					return;
				}
				SecretCharacterLocationFilter spawnedInLocation_ = character3.secretCharacterData_.spawnedInLocation_;
				int num18 = 0;
				int scene = spawnedInLocation_.Scene;
				AsyncOperation operation2 = sceneData2.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig2 = sceneData2.EditCameraConfig;
				SceneItemData villageSceneItemData = gameObject6.GetComponent<VillageEnvironment>().VillageSceneItemData;
				if (scene != villageSceneItemData.iD_)
				{
					return;
				}
				string cameraConfig_ = villageSceneItemData.cameraConfig_;
				AsyncOperation operation3 = sceneData3.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig3 = sceneData3.EditCameraConfig;
				VillageArea[] villageAreas = gameObject7.GetComponent<VillageEnvironment>().villageAreas;
				if (_003C_003Ec._003C_003E9__277_8 == null)
				{
					func6 = (Func<VillageArea, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VillageArea x) => x._areaType == VillageAreaType.Urban));
				}
				VillageArea villageArea = Enumerable.FirstOrDefault<VillageArea>((IEnumerable<>)(object)villageAreas, (Func<, >)(object)func6);
				return;
			}
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002636")]
		[Cpp2IlInjected.Address(RVA = "0x12EF450", Offset = "0x12EDE50", VA = "0x1812EF450")]
		internal void SpawnInside()
		{
			//Discarded unreachable code: IL_00ae
			int num = 0;
			CharacterItemData characterItemData = Data;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			int canOverride = 0;
			if (characterItemData.GetCurrentSchedule(profile, _003CTransactionContext_003Ek__BackingField, (byte)canOverride != 0) != ScheduleType.SpecificLocation || !SpawnAtSpecificLocation())
			{
				PlayerAvatar avatar = default(PlayerAvatar);
				if (IsFollowingAvatar())
				{
					avatar = SystemRoot.Instance._avatar;
					Transform transform = avatar.transform;
				}
				if (avatar.maxPathSegmentLength == 0f)
				{
				}
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				GameObject gameObject = default(GameObject);
				Transform transform2 = gameObject.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002637")]
		[Cpp2IlInjected.Address(RVA = "0x12EEE00", Offset = "0x12ED800", VA = "0x1812EEE00")]
		internal void SpawnAtShop()
		{
			//Discarded unreachable code: IL_00d6
			//IL_003a: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_009d: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			GameObject gameObject = default(GameObject);
			Stall[] componentsInChildren = gameObject.GetComponentsInChildren<Stall>();
			int num = 0;
			MyStall = (Stall)num;
			int length = componentsInChildren.Length;
			Stall stall;
			if (num < length)
			{
				stall = componentsInChildren[num];
				ItemScript component = stall.GetComponent<ItemScript>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					Item item = component.Item;
					StallBuildingItemData stallBuildingItemData = default(StallBuildingItemData);
					if (stallBuildingItemData != null)
					{
						CharacterItemData characterItemData = Data;
						RepeatedField<int> employeeItemIDs_ = stallBuildingItemData.employeeItemIDs_;
						int iD = characterItemData.ID;
						if (((RepeatedField<T>)(object)employeeItemIDs_).Contains((T)iD))
						{
							goto IL_00a6;
						}
					}
				}
				num++;
				goto IL_00a6;
			}
			goto IL_00ae;
			IL_00ae:
			int num3 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num3)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform = this.transform;
				WorkingAtAShop = true;
			}
			return;
			IL_00a6:
			MyStall = stall;
			goto IL_00ae;
		}

		[Cpp2IlInjected.Token(Token = "0x6002638")]
		[Cpp2IlInjected.Address(RVA = "0x12ECA40", Offset = "0x12EB440", VA = "0x1812ECA40")]
		internal bool PickValidPosition(Vector3 sourcePos, out Vector3 validPosition, PlayerAvatar.AvatarTeleportedReason onAvatarTeleported, bool reachable = true)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002639")]
		[Cpp2IlInjected.Address(RVA = "0x12EC7D0", Offset = "0x12EB1D0", VA = "0x1812EC7D0")]
		internal Vector3 PickPositionNear(Vector3 sourcePos)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				num2++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600264C")]
		[Cpp2IlInjected.Address(RVA = "0x12EE630", Offset = "0x12ED030", VA = "0x1812EE630")]
		public void ResetPreferredDialogue()
		{
			//IL_0012: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			this.SetPreferredDialogue((MissionSlot)num4, (DialogueTree)num3, (IBlackboard)num2, (Func<, , >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600264D")]
		[Cpp2IlInjected.Address(RVA = "0x12EEAE0", Offset = "0x12ED4E0", VA = "0x1812EEAE0")]
		public void SetPreferredDialogue(MissionSlot slot, DialogueTree dialogueTree, IBlackboard bb, [System.Runtime.InteropServices.Optional] Func<Character, MissionSlot, System.Threading.Tasks.Task> onComplete)
		{
			//Discarded unreachable code: IL_0089
			//IL_0010: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			DialogueTree dialogueTree2 = PreferredDialogue;
			int num = 0;
			if (dialogueTree2 != (UnityEngine.Object)num)
			{
				DialogueSystem system = SystemRoot.Instance.GetSystem<DialogueSystem>();
				AsyncEventHandler<DialogueInstance> asyncEventHandler = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(PreferredDialogueStartedEvent);
				system.remove_NewDialogueStartedEvent((AsyncEventHandler<>)(object)asyncEventHandler);
			}
			PreferredDialogueSlot = slot;
			PreferredDialogue = dialogueTree;
			PreferredBlackboard = bb;
			OnPreferredDialogueCompleted = (Func<Character, MissionSlot, System.Threading.Tasks.Task>)0;
			DialogueTree dialogueTree3 = PreferredDialogue;
			int num2 = 0;
			if (dialogueTree3 != (UnityEngine.Object)num2)
			{
				DialogueSystem system2 = SystemRoot.Instance.GetSystem<DialogueSystem>();
				AsyncEventHandler<DialogueInstance> asyncEventHandler2 = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(PreferredDialogueStartedEvent);
				system2.add_NewDialogueStartedEvent((AsyncEventHandler<>)(object)asyncEventHandler2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600264E")]
		[Cpp2IlInjected.Address(RVA = "0x12ED560", Offset = "0x12EBF60", VA = "0x1812ED560")]
		private System.Threading.Tasks.Task PreferredDialogueStartedEvent(object sender, DialogueInstance e)
		{
			//Discarded unreachable code: IL_0051
			DialogueTree dialogueTree = e.DialogueTree;
			DialogueTree dialogueTree2 = PreferredDialogue;
			if (dialogueTree == dialogueTree2)
			{
				AsyncEventHandler<DialogueInstance> asyncEventHandler = (AsyncEventHandler<DialogueInstance>)(object)new AsyncEventHandler<T>(PreferredDialogueStartedEvent);
				int num = 0;
				if (sender != null)
				{
					int num2 = 0;
					if (sender != null)
					{
						AsyncEventHandler value = PreferredDialogueFinishedEvent;
						e.OnDialogueFinished += value;
						goto IL_0048;
					}
				}
				throw new InvalidCastException();
			}
			goto IL_0048;
			IL_0048:
			int num3 = 0;
			return System.Threading.Tasks.Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600264F")]
		[Cpp2IlInjected.Address(RVA = "0x12ED440", Offset = "0x12EBE40", VA = "0x1812ED440")]
		[AsyncStateMachine(typeof(_003CPreferredDialogueFinishedEvent_003Ed__330))]
		private System.Threading.Tasks.Task PreferredDialogueFinishedEvent(object sender, EventArgs e)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002650")]
		[Cpp2IlInjected.Address(RVA = "0x12EE2B0", Offset = "0x12ECCB0", VA = "0x1812EE2B0")]
		public void ResetBlackboardDialogue()
		{
			//Discarded unreachable code: IL_0064
			Blackboard component = GetComponent<Blackboard>();
			Variable variable = component.RemoveVariable("slot_id");
			Variable variable2 = component.RemoveVariable("slot_class");
			Variable variable3 = component.RemoveVariable("item");
			Variable variable4 = component.RemoveVariable("amount");
			Variable variable5 = component.RemoveVariable("itemlist");
			Variable variable6 = component.RemoveVariable("cost");
			string giveItemAniDoneBB = MissionStep.GiveItemAniDoneBB;
			Variable variable7 = component.RemoveVariable(giveItemAniDoneBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6002651")]
		[Cpp2IlInjected.Address(RVA = "0x12EB270", Offset = "0x12E9C70", VA = "0x1812EB270", Slot = "11")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__332))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__332(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002652")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "20")]
		public bool Set(string name, object o)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002653")]
		[Cpp2IlInjected.Address(RVA = "0x12EB2E0", Offset = "0x12E9CE0", VA = "0x1812EB2E0", Slot = "21")]
		public bool Get(string name, out object o)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002654")]
		[Cpp2IlInjected.Address(RVA = "0x12EE9A0", Offset = "0x12ED3A0", VA = "0x1812EE9A0")]
		private void SetDefaultAnimatorVariables()
		{
			//Discarded unreachable code: IL_0088
			//IL_0010: Expected O, but got I4
			Animator animator = AnimatorComponent;
			int num = 0;
			if (animator != (UnityEngine.Object)num)
			{
				Animator animator2 = AnimatorComponent;
				bool useLoopingEmotionAnimations = UseLoopingEmotionAnimations;
				animator2.SetBool("Looping", useLoopingEmotionAnimations);
				Animator animator3 = AnimatorComponent;
				bool useLoopingWOL = UseLoopingWOL;
				animator3.SetBool("LoopingWOL", useLoopingWOL);
				Animator animator4 = AnimatorComponent;
				bool useSittingWOL = UseSittingWOL;
				animator4.SetBool("SittingWOL", useSittingWOL);
				Animator animator5 = AnimatorComponent;
				bool usingWalkEnd = UsingWalkEnd;
				animator5.SetBool("UsingWalkEnd", usingWalkEnd);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002655")]
		[Cpp2IlInjected.Address(RVA = "0x12EBF00", Offset = "0x12EA900", VA = "0x1812EBF00", Slot = "12")]
		void IRelaxer.OnRelaxStart()
		{
			//Discarded unreachable code: IL_0011
			NavMeshAgent navMeshAgent = NavMeshAgentComponent;
			int num2 = (navMeshAgent.avoidancePriority = 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002656")]
		[Cpp2IlInjected.Address(RVA = "0x12EBED0", Offset = "0x12EA8D0", VA = "0x1812EBED0", Slot = "13")]
		void IRelaxer.OnRelaxEnd()
		{
			//Discarded unreachable code: IL_000e
			NavMeshAgentComponent.avoidancePriority = 50;
		}

		[Cpp2IlInjected.Token(Token = "0x6002657")]
		[Cpp2IlInjected.Address(RVA = "0x12EDC50", Offset = "0x12EC650", VA = "0x1812EDC50")]
		public void ReactToSelfie(Camera camera, PlayerAvatar avatar, ViewMargins viewMargins, float minDistance, float maxDistance, float floorHeight, float cameraMinPitch, float cameraMaxPitch, float cameraMaxHeight, bool dontMove)
		{
			CapsuleCollider component = GetComponent<CapsuleCollider>();
			float height = component.height;
			Vector3 center = component.center;
			Transform transform = this.transform;
			float z = center.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			float z3 = Vector3.up.z;
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag)
			{
				if ((CanSelfieWhileSeated ? 1 : 0) != num)
				{
				}
				flag2 = (RelaxingBehaviour.Relaxing ? 1 : 0) == num;
			}
			if (flag2 != IsInSelfieCamera)
			{
				IsInSelfieCamera = flag2;
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				System.Threading.Tasks.Task task = default(System.Threading.Tasks.Task);
				if (flag2)
				{
					reactToSelfieCTS = (CancellationTokenSource)(object)task;
					int num2 = 0;
					throw new NullReferenceException();
				}
				reactToSelfieCTS = cancellationTokenSource;
				CancellationToken ct = default(CancellationToken);
				task = StopReactingToSelfieAsync(1000, ct);
				task.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002658")]
		[Cpp2IlInjected.Address(RVA = "0x12EDAB0", Offset = "0x12EC4B0", VA = "0x1812EDAB0")]
		[AsyncStateMachine(typeof(_003CReactToSelfieAsync_003Ed__339))]
		private System.Threading.Tasks.Task ReactToSelfieAsync(Camera camera, PlayerAvatar avatar, float headHeight, float floorHeight, float cameraMinPitch, float cameraMaxPitch, float cameraMaxHeight, bool dontMove, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002659")]
		[Cpp2IlInjected.Address(RVA = "0x12EA750", Offset = "0x12E9150", VA = "0x1812EA750")]
		[AsyncStateMachine(typeof(_003CFaceCameraAndSmile_003Ed__340))]
		public System.Threading.Tasks.Task FaceCameraAndSmile(Camera camera, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600265A")]
		[Cpp2IlInjected.Address(RVA = "0x12F0F40", Offset = "0x12EF940", VA = "0x1812F0F40")]
		[AsyncStateMachine(typeof(_003CStopReactingToSelfieAsync_003Ed__341))]
		private System.Threading.Tasks.Task StopReactingToSelfieAsync(int delay, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600265B")]
		[Cpp2IlInjected.Address(RVA = "0x12F1080", Offset = "0x12EFA80", VA = "0x1812F1080")]
		public void StopReactingToSelfie()
		{
			//Discarded unreachable code: IL_0048
			if (IsInSelfieCamera)
			{
				CancellationTokenSource cancellationTokenSource = reactToSelfieCTS;
				IsInSelfieCamera = false;
				cancellationTokenSource.Cancel();
				CancellationTokenSource cancellationTokenSource2 = (reactToSelfieCTS = new CancellationTokenSource());
				CancellationToken token = reactToSelfieCTS.Token;
				StopReactingToSelfieAsync(1000, token).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600265C")]
		[Cpp2IlInjected.Address(RVA = "0x12F1180", Offset = "0x12EFB80", VA = "0x1812F1180")]
		public unsafe bool TeleportCharacter(Vector3 position, bool checkNavMesh = true)
		{
			//IL_0010: Expected O, but got I4
			//IL_0068: Expected O, but got F4
			//IL_007f: Expected F4, but got I4
			//IL_007a: Expected native int or pointer, but got O
			NavMeshAreaHelper component = GetComponent<NavMeshAreaHelper>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				component.SetAreaMask();
			}
			if (checkNavMesh)
			{
				NavMeshAgent navMeshAgent = NavMeshAgentComponent;
				int num2 = 0;
				int agentTypeID = navMeshAgent.agentTypeID;
				int walkableMask = NavMeshAgentComponent.walkableMask;
				bool flag = default(bool);
				bool flag2 = default(bool);
				int num4 = default(int);
				if (!flag && !flag2)
				{
					string name_ = Data.name_;
					float z = position.z;
					string message = $"TeleportCharacter: It was impossible to teleport \"{name_}\" to this position {z}";
					int num3 = 0;
					Debug.LogError(message);
					num4 = 0;
				}
				((Vector3*)(IntPtr)position)->z = num4;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600265D")]
		[Cpp2IlInjected.Address(RVA = "0x12EBE40", Offset = "0x12EA840", VA = "0x1812EBE40")]
		public bool IsInFrustum(Plane[] frustumPlanes)
		{
			//Discarded unreachable code: IL_0009
			Collider component = GetComponent<Collider>();
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600265E")]
		[Cpp2IlInjected.Address(RVA = "0x12EAC60", Offset = "0x12E9660", VA = "0x1812EAC60")]
		[AsyncStateMachine(typeof(_003CFriendshipGained_003Ed__345))]
		public System.Threading.Tasks.Task FriendshipGained(FriendshipSource friendshipSource)
		{
			int num = 0;
			int num2 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600265F")]
		[Cpp2IlInjected.Address(RVA = "0x12E9770", Offset = "0x12E8170", VA = "0x1812E9770")]
		internal bool CanReactToAvatar()
		{
			if (MetaCharacter.InVillage && !RelaxingBehaviour.Relaxing && !TraversingLink)
			{
				Client client = default(Client);
				DateTime serverTime = client.ServerTime;
				DateTime dateTime = nextAvatarReaction;
				return serverTime >= dateTime;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002660")]
		[Cpp2IlInjected.Address(RVA = "0x12EE820", Offset = "0x12ED220", VA = "0x1812EE820")]
		internal void ScheduleNextAvatarReaction()
		{
			//Discarded unreachable code: IL_003d
			//IL_002a: Expected F8, but got I4
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			float maxSecondsBetweenAvatarReaction = MaxSecondsBetweenAvatarReaction;
			float num = UnityEngine.Random.Range(MinSecondsBetweenAvatarReaction, maxSecondsBetweenAvatarReaction);
			TimeSpan timeSpan = TimeSpan.FromSeconds(0.0);
			DateTime dateTime = (nextAvatarReaction = serverTime + timeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6002661")]
		[Cpp2IlInjected.Address(RVA = "0x12E9890", Offset = "0x12E8290", VA = "0x1812E9890")]
		private bool CanSelectProfession()
		{
			//Discarded unreachable code: IL_000c
			return MetaCharacter.CanSelectProfession();
		}

		[Cpp2IlInjected.Token(Token = "0x6002665")]
		[Cpp2IlInjected.Address(RVA = "0x12EADC0", Offset = "0x12E97C0", VA = "0x1812EADC0")]
		public unsafe CharacterRestaurantOrder GetRestaurantOrder()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<CharacterRestaurantOrder> characterRestaurantOrders_ = SystemRoot.Instance.MetaClient.profile.world_.characterRestaurantOrders_;
			Func<CharacterRestaurantOrder, bool> func = (Func<CharacterRestaurantOrder, bool>)(object)(Func<T, TResult>)delegate(CharacterRestaurantOrder x)
			{
				//Discarded unreachable code: IL_0016
				Item characterItem = x.CharacterItem;
				Item item = Item;
				return *(Item*)characterItem == *(Item*)item;
			};
			return Enumerable.FirstOrDefault<CharacterRestaurantOrder>((IEnumerable<>)(object)characterRestaurantOrders_, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6002666")]
		[Cpp2IlInjected.Address(RVA = "0x12E9D80", Offset = "0x12E8780", VA = "0x1812E9D80")]
		public bool CanServeRestaurantOrder()
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002667")]
		[Cpp2IlInjected.Address(RVA = "0x12E98C0", Offset = "0x12E82C0", VA = "0x1812E98C0")]
		public unsafe bool CanServeRestaurantOrder(out CharacterRestaurantOrder order)
		{
			int num = 0;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			RestaurantEnvironment component = gameObject.GetComponent<RestaurantEnvironment>();
			Item characterItem = Item;
			if (component.IsCustomerOfRestaurant(characterItem))
			{
				RepeatedField<CharacterRestaurantOrder> characterRestaurantOrders_ = SystemRoot.Instance.MetaClient.profile.world_.characterRestaurantOrders_;
				Func<CharacterRestaurantOrder, bool> func = (Func<CharacterRestaurantOrder, bool>)(object)(Func<T, TResult>)delegate(CharacterRestaurantOrder x)
				{
					//Discarded unreachable code: IL_0016
					Item characterItem2 = x.CharacterItem;
					Item item2 = Item;
					return *(Item*)characterItem2 == *(Item*)item2;
				};
				CharacterRestaurantOrder characterRestaurantOrder = Enumerable.FirstOrDefault<CharacterRestaurantOrder>((IEnumerable<>)(object)characterRestaurantOrders_, (Func<, >)(object)func);
				Item item = default(Item);
				Item orderItem = item;
				Client client = default(Client);
				RepeatedField<ContainerInventory.Types.Slot> inventory_ = client.profile.Backpack.inventory_;
				Func<ContainerInventory.Types.Slot, bool> cpp2il__autoParamName__idx_ = (Func<ContainerInventory.Types.Slot, bool>)(object)(Func<T, TResult>)delegate(ContainerInventory.Types.Slot x)
				{
					if (x != null)
					{
						int itemID = x.ItemID;
					}
					int num2 = 0;
					/*Error: Unexpected end of block*/;
				};
				if (((IEnumerable<>)(object)inventory_).Any<ContainerInventory.Types.Slot>((Func<, >)(object)cpp2il__autoParamName__idx_))
				{
					return true;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002668")]
		[Cpp2IlInjected.Address(RVA = "0x12ED310", Offset = "0x12EBD10", VA = "0x1812ED310", Slot = "10")]
		public void PlayAnimation(string aniId, [System.Runtime.InteropServices.Optional] AK.Wwise.Switch overrideVO)
		{
			//Discarded unreachable code: IL_002e
			//IL_0015: Expected O, but got I4
			Animator componentInChildren = transform.GetComponentInChildren<Animator>();
			int num = 0;
			bool flag = componentInChildren != (UnityEngine.Object)num;
			if (flag && !flag)
			{
				componentInChildren.SetTrigger(aniId);
				AudioManager audioManager = default(AudioManager);
				audioManager.PlayDialogueGenExp(aniId, overrideVO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600266A")]
		[Cpp2IlInjected.Address(RVA = "0x12ED770", Offset = "0x12EC170", VA = "0x1812ED770")]
		public void PrepareRestoreState(CharacterState state, bool restoreTransform)
		{
			postponedRestoreState = state;
			postponedRestoreTransform = restoreTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x600266B")]
		[Cpp2IlInjected.Address(RVA = "0x12EA410", Offset = "0x12E8E10", VA = "0x1812EA410")]
		private void DoRestoreState()
		{
			//Discarded unreachable code: IL_0081
			//IL_0080: Expected O, but got I4
			CharacterState characterState = postponedRestoreState;
			if (characterState != null)
			{
				if (postponedRestoreTransform)
				{
					Transform transform = this.transform;
					float z = characterState.position.z;
					Transform transform2 = this.transform;
					Quaternion quaternion = (transform2.rotation = characterState.rotation);
				}
				if (characterState.isTalkingToRequestor)
				{
					TalkingToRequestor = true;
					SystemRoot.Instance.GetSystem<DialogueSystem>().SetCurrentDialogueActor(this);
				}
				int num = 0;
				if ((characterState.isMovingToTargetPosition ? 1 : 0) != num)
				{
					float z2 = characterState.targetPosition.z;
				}
				postponedRestoreState = (CharacterState)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600266C")]
		[Cpp2IlInjected.Address(RVA = "0x12EE660", Offset = "0x12ED060", VA = "0x1812EE660")]
		public void RestoreState(CharacterState state, bool restoreTransform)
		{
			//Discarded unreachable code: IL_0063
			if (restoreTransform)
			{
				Transform transform = this.transform;
				float z = state.position.z;
				Transform transform2 = this.transform;
				Quaternion quaternion = (transform2.rotation = state.rotation);
			}
			if (state.isTalkingToRequestor)
			{
				TalkingToRequestor = true;
				SystemRoot.Instance.GetSystem<DialogueSystem>().SetCurrentDialogueActor(this);
			}
			if (state.isMovingToTargetPosition)
			{
				float z2 = state.targetPosition.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600266D")]
		[Cpp2IlInjected.Address(RVA = "0x12F2390", Offset = "0x12F0D90", VA = "0x1812F2390")]
		public Character()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
