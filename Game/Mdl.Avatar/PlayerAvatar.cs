using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Characters.Pets;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Customization;
using Meta.Online;
using Meta.Tracking;
using NodeCanvas.DialogueTrees;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A6D")]
	public class PlayerAvatar : MonoBehaviour, IDialogueActor, ILocation, IRelaxer, IDisneyEntity, IAvatarInfoProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000A6E")]
		public delegate void EnvironmentChanged(SceneData prevScene, SceneData sceneData);

		[Cpp2IlInjected.Token(Token = "0x2000A6F")]
		public enum AvatarTeleportedReason
		{
			[Cpp2IlInjected.Token(Token = "0x400399D")]
			Movement,
			[Cpp2IlInjected.Token(Token = "0x400399E")]
			NewEnvironment,
			[Cpp2IlInjected.Token(Token = "0x400399F")]
			PlayerTask,
			[Cpp2IlInjected.Token(Token = "0x40039A0")]
			PlayerInitialPosition
		}

		[Cpp2IlInjected.Token(Token = "0x2000A70")]
		public delegate void AvatarTeleported(UnityEngine.Vector3 position, AvatarTeleportedReason reason);

		[Cpp2IlInjected.Token(Token = "0x2000A71")]
		public delegate void RewardsGained(IReadOnlyDictionary<int, int> rewards);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003973")]
		public CameraOverrideZone cameraOverrideZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003976")]
		public AudioCharacterController AudioController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400397C")]
		public AvatarAppearance appearance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400397D")]
		public PetMaster petMaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400397E")]
		public Transform navigationStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400397F")]
		public Transform gridEditStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003980")]
		public Transform gridEditLargeStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003981")]
		public Transform customizationStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003982")]
		public Transform customizationCloseUpCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003983")]
		public Transform customizationPetTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003984")]
		public Transform largeCharacterDialogueCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003985")]
		public Transform smallCharacterDialogueCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003986")]
		public float smallCharacterHeightThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4003987")]
		public float dialogueLargeCharacterOffset = 0.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003988")]
		public Transform consummableCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003989")]
		public Transform consummablePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400398A")]
		public Transform orbitLookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400398B")]
		public Transform levelUpStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400398C")]
		public Transform levelUpEndCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400398D")]
		public float maxPathSegmentLength = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400398E")]
		public float directionSmoothingValue = 0.9f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400398F")]
		public string notEnoughManaAnimation = "Sad";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4003990")]
		public string notEnoughManaAnimationStateName = "sad_loop";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4003992")]
		private bool _isTeleportedAtInitialPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4003994")]
		private NavMeshObstacle navMeshObstacle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4003995")]
		private int numberOfGoTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003999")]
		private TaskCompletionSource<bool> movementEnabledTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400399B")]
		private Toolbox.TemporarySwitchToolScope relaxToolScope;

		[Cpp2IlInjected.Token(Token = "0x170006B7")]
		public NavMeshAgent Agent
		{
			[Cpp2IlInjected.Token(Token = "0x6003046")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CAgent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003047")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CAgent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B8")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x6003048")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCollider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003049")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CCollider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B9")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x600304A")]
			[Cpp2IlInjected.Address(RVA = "0x14BD110", Offset = "0x14BBB10", VA = "0x1814BD110")]
			get
			{
				//Discarded unreachable code: IL_000c
				return appearance.Animator;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BA")]
		public CharacterVisualNodes CharacterVisualNodes
		{
			[Cpp2IlInjected.Token(Token = "0x600304B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterVisualNodes_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600304C")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CCharacterVisualNodes_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BB")]
		public RelaxingBehaviour RelaxingBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x600304D")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CRelaxingBehaviour_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600304E")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CRelaxingBehaviour_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BC")]
		public Toolbox Toolbox
		{
			[Cpp2IlInjected.Token(Token = "0x600304F")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CToolbox_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003050")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CToolbox_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BD")]
		public new Transform transform
		{
			[Cpp2IlInjected.Token(Token = "0x6003051")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return _003Ctransform_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003052")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003Ctransform_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BE")]
		public new GameObject gameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6003053")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return _003CgameObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003054")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CgameObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BF")]
		public bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6003055")]
			[Cpp2IlInjected.Address(RVA = "0x14BD300", Offset = "0x14BBD00", VA = "0x1814BD300", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_0023
				//IL_0010: Expected O, but got I4
				AvatarAppearance avatarAppearance = appearance;
				int num = 0;
				bool flag = avatarAppearance != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				return appearance.IsMale;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C0")]
		public GameObject GO
		{
			[Cpp2IlInjected.Token(Token = "0x6003056")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "18")]
			get
			{
				return gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C1")]
		public AvatarAppearance.BodyType BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6003057")]
			[Cpp2IlInjected.Address(RVA = "0x14BD140", Offset = "0x14BBB40", VA = "0x1814BD140", Slot = "19")]
			get
			{
				//IL_0010: Expected O, but got I4
				AvatarAppearance avatarAppearance = appearance;
				int num = 0;
				if (avatarAppearance != (UnityEngine.Object)num)
				{
					return appearance.GetCurrentBodyType();
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C2")]
		public AvatarHairColorConfig HairColorConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6003058")]
			[Cpp2IlInjected.Address(RVA = "0x14BD270", Offset = "0x14BBC70", VA = "0x1814BD270", Slot = "20")]
			get
			{
				//IL_0010: Expected O, but got I4
				AvatarAppearance avatarAppearance = appearance;
				int num = 0;
				if (avatarAppearance != (UnityEngine.Object)num)
				{
					return appearance.hairColorConfig;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C3")]
		public Meta.Customization.Avatar Data
		{
			[Cpp2IlInjected.Token(Token = "0x6003059")]
			[Cpp2IlInjected.Address(RVA = "0x14BD1D0", Offset = "0x14BBBD0", VA = "0x1814BD1D0", Slot = "21")]
			get
			{
				//IL_0010: Expected O, but got I4
				AvatarAppearance avatarAppearance = appearance;
				int num = 0;
				if (avatarAppearance != (UnityEngine.Object)num)
				{
					AvatarWorkingCopy currentAvatar = appearance.CurrentAvatar;
					if (currentAvatar != null)
					{
						return currentAvatar.Data;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C4")]
		public bool IsTeleportedAtInitialPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600305C")]
			[Cpp2IlInjected.Address(RVA = "0x110E750", Offset = "0x110D150", VA = "0x18110E750")]
			get
			{
				return _isTeleportedAtInitialPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C5")]
		public bool AvatarGoingSomewhere
		{
			[Cpp2IlInjected.Token(Token = "0x600305F")]
			[Cpp2IlInjected.Address(RVA = "0x14BD130", Offset = "0x14BBB30", VA = "0x1814BD130")]
			get
			{
				return numberOfGoTo > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C6")]
		string IDialogueActor.name
		{
			[Cpp2IlInjected.Token(Token = "0x6003068")]
			[Cpp2IlInjected.Address(RVA = "0x14BB920", Offset = "0x14BA320", VA = "0x1814BB920", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_001a
				return SystemRoot.Instance.MetaClient.profile.player_.name_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C7")]
		Texture2D IDialogueActor.portrait
		{
			[Cpp2IlInjected.Token(Token = "0x6003069")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C8")]
		Sprite IDialogueActor.portraitSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600306A")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C9")]
		Color IDialogueActor.dialogueColor
		{
			[Cpp2IlInjected.Token(Token = "0x600306B")]
			[Cpp2IlInjected.Address(RVA = "0x12EC580", Offset = "0x12EAF80", VA = "0x1812EC580", Slot = "7")]
			get
			{
				Color white = Color.white;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CA")]
		UnityEngine.Vector3 IDialogueActor.dialoguePosition
		{
			[Cpp2IlInjected.Token(Token = "0x600306C")]
			[Cpp2IlInjected.Address(RVA = "0x14BB860", Offset = "0x14BA260", VA = "0x1814BB860", Slot = "8")]
			get
			{
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
				float z2 = UnityEngine.Vector3.up.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CB")]
		public bool MovementEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600306E")]
			[Cpp2IlInjected.Address(RVA = "0x14BD390", Offset = "0x14BBD90", VA = "0x1814BD390")]
			get
			{
				//Discarded unreachable code: IL_001c
				if (navMeshObstacle.enabled)
				{
					int num = 0;
				}
				return Agent.enabled;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x140"), Cpp2IlInjected.Token(Token = "0x400399A")]
		public float RunSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6003071")]
			[Cpp2IlInjected.Address(RVA = "0x14BD3E0", Offset = "0x14BBDE0", VA = "0x1814BD3E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003072")]
			[Cpp2IlInjected.Address(RVA = "0x14BD710", Offset = "0x14BC110", VA = "0x1814BD710")]
			private set;
		} = 1f;


		[Cpp2IlInjected.Token(Token = "0x14000079")]
		public event EnvironmentChanged OnEnvironmentChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600305A")]
			[Cpp2IlInjected.Address(RVA = "0x14BCFD0", Offset = "0x14BB9D0", VA = "0x1814BCFD0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600305B")]
			[Cpp2IlInjected.Address(RVA = "0x14BD5D0", Offset = "0x14BBFD0", VA = "0x1814BD5D0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007A")]
		public event AvatarTeleported OnAvatarTeleported
		{
			[Cpp2IlInjected.Token(Token = "0x600305D")]
			[Cpp2IlInjected.Address(RVA = "0x14BCF30", Offset = "0x14BB930", VA = "0x1814BCF30")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600305E")]
			[Cpp2IlInjected.Address(RVA = "0x14BD530", Offset = "0x14BBF30", VA = "0x1814BD530")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007B")]
		public event RewardsGained OnRewardsGained
		{
			[Cpp2IlInjected.Token(Token = "0x6003061")]
			[Cpp2IlInjected.Address(RVA = "0x14BD070", Offset = "0x14BBA70", VA = "0x1814BD070")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003062")]
			[Cpp2IlInjected.Address(RVA = "0x14BD670", Offset = "0x14BC070", VA = "0x1814BD670")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007C")]
		public event Action LowManaEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6003064")]
			[Cpp2IlInjected.Address(RVA = "0x14BCDF0", Offset = "0x14BB7F0", VA = "0x1814BCDF0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003065")]
			[Cpp2IlInjected.Address(RVA = "0x14BD3F0", Offset = "0x14BBDF0", VA = "0x1814BD3F0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007D")]
		public event Action NotEnoughManaEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6003066")]
			[Cpp2IlInjected.Address(RVA = "0x14BCE90", Offset = "0x14BB890", VA = "0x1814BCE90")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003067")]
			[Cpp2IlInjected.Address(RVA = "0x14BD490", Offset = "0x14BBE90", VA = "0x1814BD490")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003060")]
		[Cpp2IlInjected.Address(RVA = "0x14BBBE0", Offset = "0x14BA5E0", VA = "0x1814BBBE0")]
		public void NotifyEnvironmentChanged(SceneData prevScene, SceneData newScene)
		{
			this.OnEnvironmentChanged?.Invoke(prevScene, newScene);
		}

		[Cpp2IlInjected.Token(Token = "0x6003063")]
		[Cpp2IlInjected.Address(RVA = "0x14BBC40", Offset = "0x14BA640", VA = "0x1814BBC40")]
		public void NotifyRewardsGained(IReadOnlyDictionary<int, int> rewards)
		{
			this.OnRewardsGained?.Invoke((IReadOnlyDictionary<, >)rewards);
		}

		[Cpp2IlInjected.Token(Token = "0x600306D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		public void PlayAnimation(string aniId, [System.Runtime.InteropServices.Optional] Switch voOverride)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600306F")]
		[Cpp2IlInjected.Address(RVA = "0x14BAD80", Offset = "0x14B9780", VA = "0x1814BAD80")]
		public void ChangeMovementEnabled(bool enabled)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			ChangeMovementEnabled(enabled, (CancellationToken)num).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003070")]
		[Cpp2IlInjected.Address(RVA = "0x14BAE00", Offset = "0x14B9800", VA = "0x1814BAE00")]
		[AsyncStateMachine(typeof(_003CChangeMovementEnabled_003Ed__106))]
		public Task ChangeMovementEnabled(bool enabled, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003073")]
		[Cpp2IlInjected.Address(RVA = "0x14BAC30", Offset = "0x14B9630", VA = "0x1814BAC30")]
		private void Awake()
		{
			Transform transform = (this.transform = base.transform);
			GameObject gameObject = (this.gameObject = base.gameObject);
			NavMeshAgent navMeshAgent = (Agent = GetComponent<NavMeshAgent>());
			NavMeshObstacle navMeshObstacle = (this.navMeshObstacle = GetComponent<NavMeshObstacle>());
			Collider collider = (Collider = GetComponent<Collider>());
			CharacterVisualNodes characterVisualNodes = (CharacterVisualNodes = GetComponent<CharacterVisualNodes>());
			RelaxingBehaviour relaxingBehaviour = (RelaxingBehaviour = GetComponent<RelaxingBehaviour>());
			Toolbox toolbox = (Toolbox = GetComponent<Toolbox>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003074")]
		[Cpp2IlInjected.Address(RVA = "0x14BCB70", Offset = "0x14BB570", VA = "0x1814BCB70")]
		internal void UpdateAvatarDirection(UnityEngine.Vector3 desiredDirection)
		{
			//Discarded unreachable code: IL_0048
			if (!navMeshObstacle.enabled && Agent.enabled && !Agent.updateRotation)
			{
				float z = UnityEngine.Vector3.zero.z;
				float z2 = desiredDirection.z;
				bool flag = default(bool);
				if (flag)
				{
					float z3 = desiredDirection.z;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003075")]
		[Cpp2IlInjected.Address(RVA = "0x14BAF70", Offset = "0x14B9970", VA = "0x1814BAF70")]
		internal void ForceUpdateAvatarDirection(UnityEngine.Vector3 desiredDirection)
		{
			//Discarded unreachable code: IL_0027
			float z = desiredDirection.z;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
				float z2 = desiredDirection.z;
				int num2 = 0;
				float deltaTime = Time.deltaTime;
				Transform transform = this.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003076")]
		[Cpp2IlInjected.Address(RVA = "0x14BAF40", Offset = "0x14B9940", VA = "0x1814BAF40")]
		internal void ForceAvatarRotation(Quaternion desiredRotation)
		{
			//Discarded unreachable code: IL_0008
			Transform transform = this.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003077")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF60", Offset = "0x14BA960", VA = "0x1814BBF60")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00ee
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.CurrentPetChanged value = OnCurrentPetChanged;
					_003CDispatcher_003Ek__BackingField.OnCurrentPetChanged -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffAdded value2 = OnPlayerBuffAdded;
					_003CDispatcher_003Ek__BackingField2.OnPlayerBuffAdded -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffUpdated value3 = OnPlayerBuffUpdated;
					_003CDispatcher_003Ek__BackingField3.OnPlayerBuffUpdated -= value3;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffRemoved value4 = OnPlayerBuffRemoved;
					_003CDispatcher_003Ek__BackingField4.OnPlayerBuffRemoved -= value4;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField5 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.ManaChanged value5 = OnManaChanged;
					_003CDispatcher_003Ek__BackingField5.OnManaChanged -= value5;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003078")]
		[Cpp2IlInjected.Address(RVA = "0x14BB740", Offset = "0x14BA140", VA = "0x1814BB740")]
		[AsyncStateMachine(typeof(_003CInitFromProfile_003Ed__116))]
		public Task InitFromProfile(Profile profile)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003079")]
		[Cpp2IlInjected.Address(RVA = "0x14BC7B0", Offset = "0x14BB1B0", VA = "0x1814BC7B0")]
		private void OnTriggerEnter(Collider other)
		{
			//Discarded unreachable code: IL_002c
			//IL_0015: Expected O, but got I4
			CameraOverrideZone component = other.gameObject.GetComponent<CameraOverrideZone>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				CameraOverrideZone cameraOverrideZone = (this.cameraOverrideZone = other.gameObject.GetComponent<CameraOverrideZone>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600307A")]
		[Cpp2IlInjected.Address(RVA = "0x14BC890", Offset = "0x14BB290", VA = "0x1814BC890")]
		private void OnTriggerExit(Collider other)
		{
			//Discarded unreachable code: IL_001e
			CameraOverrideZone component = other.gameObject.GetComponent<CameraOverrideZone>();
			CameraOverrideZone cameraOverrideZone = this.cameraOverrideZone;
			if (!(component == cameraOverrideZone))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600307B")]
		[Cpp2IlInjected.Address(RVA = "0x14BC960", Offset = "0x14BB360", VA = "0x1814BC960")]
		[AsyncStateMachine(typeof(_003CPrepareMovement_003Ed__119))]
		public Task PrepareMovement(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600307C")]
		[Cpp2IlInjected.Address(RVA = "0x14BB580", Offset = "0x14B9F80", VA = "0x1814BB580")]
		[AsyncStateMachine(typeof(_003CGoToPosition_003Ed__120))]
		public Task<bool> GoToPosition(UnityEngine.Vector3 position, float stoppingDistance, bool teleportOnScreen, CancellationToken ct, bool playerTask = false, bool usePositionForDistanceCheck = false, [System.Runtime.InteropServices.Optional] Action startMovement, [System.Runtime.InteropServices.Optional] Action endMovement, bool allowPartialPath = false)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600307D")]
		[Cpp2IlInjected.Address(RVA = "0x14BCAE0", Offset = "0x14BB4E0", VA = "0x1814BCAE0")]
		public void Teleport(UnityEngine.Vector3 position, AvatarTeleportedReason reason = AvatarTeleportedReason.Movement)
		{
			//Discarded unreachable code: IL_001f
			NavMeshAgent navMeshAgent = Agent;
			float z = position.z;
			if (this.OnAvatarTeleported != null)
			{
				float z2 = position.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600307E")]
		[Cpp2IlInjected.Address(RVA = "0x14BCA80", Offset = "0x14BB480", VA = "0x1814BCA80")]
		public void RaiseAvatarTeleportToInitialPosition()
		{
			//Discarded unreachable code: IL_0021
			AvatarTeleported onAvatarTeleported = this.OnAvatarTeleported;
			_isTeleportedAtInitialPosition = true;
			if (onAvatarTeleported != null)
			{
				Transform transform = this.transform;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600307F")]
		[Cpp2IlInjected.Address(RVA = "0x14BBB80", Offset = "0x14BA580", VA = "0x1814BBB80")]
		public void NotEnoughMana()
		{
			//Discarded unreachable code: IL_003b
			if (!string.IsNullOrEmpty(notEnoughManaAnimation))
			{
				Animator _003CAnimator_003Ek__BackingField = appearance.Animator;
				string trigger = notEnoughManaAnimation;
				_003CAnimator_003Ek__BackingField.SetTrigger(trigger);
			}
			this.NotEnoughManaEvent?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003080")]
		[Cpp2IlInjected.Address(RVA = "0x14BB9F0", Offset = "0x14BA3F0", VA = "0x1814BB9F0")]
		public Task NotEnoughManaAndWaitAnimation(CancellationToken ct)
		{
			AudioController.NoEnergy();
			this.NotEnoughManaEvent?.Invoke();
			Animator _003CAnimator_003Ek__BackingField = appearance.Animator;
			string text = notEnoughManaAnimationStateName;
			AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
			float length = animatorStateInfo.m_Length;
			int loop = animatorStateInfo.m_Loop;
			AvatarAppearance avatarAppearance = appearance;
			bool flag = default(bool);
			if (flag)
			{
				Animator _003CAnimator_003Ek__BackingField2 = avatarAppearance.Animator;
				string animationName = notEnoughManaAnimationStateName;
				return _003CAnimator_003Ek__BackingField2.WaitForAnimationNameToEnd(animationName, ct);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003081")]
		[Cpp2IlInjected.Address(RVA = "0x14BB0B0", Offset = "0x14B9AB0", VA = "0x1814BB0B0", Slot = "12")]
		public string GetLocation()
		{
			//Discarded unreachable code: IL_0021
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003082")]
		[Cpp2IlInjected.Address(RVA = "0x14BB1B0", Offset = "0x14B9BB0", VA = "0x1814BB1B0", Slot = "11")]
		public string GetMapLocation()
		{
			//IL_0055: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			GameObject gameObject = default(GameObject);
			if ((object)gameObject != null && (object)gameObject.GetComponent<Mdl.Environments.Environment>() != null)
			{
				Transform transform = this.transform;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
			}
			int num = 0;
			int num2 = 0;
			if (!((UnityEngine.Object)num != (UnityEngine.Object)num2))
			{
				return GetLocation();
			}
			bool flag = GetLocation().StartsWith("Village");
			Transform transform2 = this.transform;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			GridPosition gridPosition = default(GridPosition);
			int x = gridPosition.X;
			int x2 = gridPosition.X;
			GridData gridData = default(GridData);
			GridFloorType gridFloorType = gridData[x, x2];
			GridFloorType all = GridFloorTypeExtensions.All;
			string text = $"_{all}_{all}_{all}";
			string text2 = "Village" + text;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003083")]
		[Cpp2IlInjected.Address(RVA = "0x14BCC50", Offset = "0x14BB650", VA = "0x1814BCC50")]
		private void UpdateRunSpeedMultiplier()
		{
			//Discarded unreachable code: IL_001f
			int buff = SystemRoot.Instance.MetaClient.profile.player_.GetBuff(BuffType.AvatarMovementSpeedMultiplier);
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003084")]
		[Cpp2IlInjected.Address(RVA = "0x14BC620", Offset = "0x14BB020", VA = "0x1814BC620")]
		private void OnPlayerBuffAdded(BuffOrigin buffOrigin, BuffType buffType, int percentageEffect)
		{
			if (buffType == BuffType.AvatarMovementSpeedMultiplier)
			{
				UpdateRunSpeedMultiplier();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003085")]
		[Cpp2IlInjected.Address(RVA = "0x14BC620", Offset = "0x14BB020", VA = "0x1814BC620")]
		private void OnPlayerBuffUpdated(BuffOrigin buffOrigin, BuffType buffType)
		{
			if (buffType == BuffType.AvatarMovementSpeedMultiplier)
			{
				UpdateRunSpeedMultiplier();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003086")]
		[Cpp2IlInjected.Address(RVA = "0x14BC620", Offset = "0x14BB020", VA = "0x1814BC620")]
		private void OnPlayerBuffRemoved(BuffOrigin buffOrigin, BuffType buffType)
		{
			if (buffType == BuffType.AvatarMovementSpeedMultiplier)
			{
				UpdateRunSpeedMultiplier();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003087")]
		[Cpp2IlInjected.Address(RVA = "0x14BBC60", Offset = "0x14BA660", VA = "0x1814BBC60")]
		private void OnCurrentPetChanged(Item previousPet, Item newPet)
		{
			//Discarded unreachable code: IL_004f
			//IL_004e: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			PetMaster petMaster = this.petMaster;
			PetItemData petItemData = default(PetItemData);
			if (petItemData != null)
			{
			}
			int num = 0;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			if (_003C_003Ec._003C_003E9__131_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SceneData x) => (long)"{il2cpp field on {'constant1' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 1);
			}
			GameObject gameObject = default(GameObject);
			Transform parent = gameObject.transform;
			petMaster.SetPet((string)num, parent);
		}

		[Cpp2IlInjected.Token(Token = "0x6003088")]
		[Cpp2IlInjected.Address(RVA = "0x14BC430", Offset = "0x14BAE30", VA = "0x1814BC430")]
		private void OnManaChanged(int oldValue, int newValue, bool refill, ProfileEventDispatcher.ManaSpentData spendActionData)
		{
			//Discarded unreachable code: IL_005a
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected F4, but got I4
			//IL_0043: Expected F4, but got Unknown
			if (oldValue > newValue)
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
					Client client = default(Client);
					ProfilePlayer player_ = client.profile.player_;
					int level_ = player_.level_;
					int maximumManaAmountForLevel = player_.GetMaximumManaAmountForLevel(level_);
					int num = 0;
					int num2 = 0;
					float num3 = Mathf.Max(0 * 0.01f, num);
					this.LowManaEvent?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003089")]
		[Cpp2IlInjected.Address(RVA = "0x14BC670", Offset = "0x14BB070", VA = "0x1814BC670", Slot = "13")]
		public void OnRelaxStart()
		{
			bool flag = default(bool);
			if (flag)
			{
			}
			Toolbox toolbox = Toolbox;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600308A")]
		[Cpp2IlInjected.Address(RVA = "0x14BC630", Offset = "0x14BB030", VA = "0x1814BC630", Slot = "14")]
		public void OnRelaxEnd()
		{
			//IL_000d: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				relaxToolScope = (Toolbox.TemporarySwitchToolScope)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600308B")]
		[Cpp2IlInjected.Address(RVA = "0x14BCD50", Offset = "0x14BB750", VA = "0x1814BCD50")]
		public PlayerAvatar()
		{
		}
	}
}
