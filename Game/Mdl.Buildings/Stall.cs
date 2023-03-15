using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.RewiredConsts;
using Mdl.Systems;
using Rewired;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009C3")]
	public abstract class Stall : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40035D1")]
		public bool NeedEmployee = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40035D2")]
		[SerializeField]
		private Transform _employeePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40035D3")]
		[SerializeField]
		private Transform _employeeTeleportPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40035D4")]
		public float MinDistanceToTeleportEmployee;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40035D5")]
		public float EmployeeRunKeepDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40035D6")]
		[SerializeField]
		private bool _teleportEmployeeBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40035D7")]
		[SerializeField]
		private string _employeeStartInteractionAnimationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40035D8")]
		[SerializeField]
		private string _employeeEndInteractionAnimationTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40035D9")]
		[SerializeField]
		private string _employeeEndInteractionEventName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40035DA")]
		[SerializeField]
		private Transform _cameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40035DB")]
		[SerializeField]
		private bool _useFade;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40035DC")]
		[SerializeField]
		private float _fadeDurationInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40035DD")]
		private Task initialFadeTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40035DE")]
		[SerializeField]
		private string avatarAnimationLayerWhileInteracting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40035DF")]
		[SerializeField]
		private float navMeshCheckDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40035E0")]
		[SerializeField]
		private bool _needAvatarReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40035E1")]
		[ActionIdProperty(typeof(Category))]
		public int[] ControlMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40035E2")]
		public AssetReference DialogueToPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40035E3")]
		public AssetReference MenuToOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40035E4")]
		public List<GameObject> ToEnableWhenInteracting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40035E5")]
		public List<GameObject> ToDisableWhenInteracting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40035E6")]
		protected ItemScript itemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40035E8")]
		private CharacterManager characterManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40035EA")]
		private CharacterManager.CharacterInstance currentEmployeeInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40035EB")]
		private (Vector3 position, Quaternion rotation)? employeePreviousTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40035EC")]
		private bool? previousResetMoveToTargetOnArrival;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40035EE")]
		public AK.Wwise.Event _sfxStartInteraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40035EF")]
		public AK.Wwise.Event _sfxStopInteraction;

		[Cpp2IlInjected.Token(Token = "0x1700068E")]
		public Transform EmployeePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _employeePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068F")]
		public Transform EmployeeTeleportPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _employeeTeleportPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000690")]
		public Transform CameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002DBA")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _cameraPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000691")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6002DBB")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DBC")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			[CompilerGenerated]
			private set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000692")]
		public PlayerTaskCollider PlayerTaskCollider
		{
			[Cpp2IlInjected.Token(Token = "0x6002DBD")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			[CompilerGenerated]
			get
			{
				return _003CPlayerTaskCollider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DBE")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			[CompilerGenerated]
			private set
			{
				_003CPlayerTaskCollider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000693")]
		public Character CurrentEmployee
		{
			[Cpp2IlInjected.Token(Token = "0x6002DBF")]
			[Cpp2IlInjected.Address(RVA = "0xF5C590", Offset = "0xF5AF90", VA = "0x180F5C590")]
			get
			{
				CharacterManager.CharacterInstance characterInstance;
				do
				{
					characterInstance = currentEmployeeInstance;
				}
				while (characterInstance == null);
				return characterInstance.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000694")]
		public GridObjectScript GridObjectScript
		{
			[Cpp2IlInjected.Token(Token = "0x6002DC0")]
			[Cpp2IlInjected.Address(RVA = "0x7389F0", Offset = "0x7373F0", VA = "0x1807389F0")]
			[CompilerGenerated]
			get
			{
				return _003CGridObjectScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DC1")]
			[Cpp2IlInjected.Address(RVA = "0x739E50", Offset = "0x738850", VA = "0x180739E50")]
			[CompilerGenerated]
			private set
			{
				_003CGridObjectScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC2")]
		[Cpp2IlInjected.Address(RVA = "0xF5B9C0", Offset = "0xF5A3C0", VA = "0x180F5B9C0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0040
			//IL_001e: Expected O, but got I4
			ItemScript itemScript = (this.itemScript = GetComponentInParent<ItemScript>());
			ItemScript itemScript2 = this.itemScript;
			int num = 0;
			if (itemScript2 != (UnityEngine.Object)num)
			{
				ItemScript itemScript3 = this.itemScript;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = itemScript3.Item;
				IItemData itemData = default(IItemData);
				ItemData = itemData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC3")]
		[Cpp2IlInjected.Address(RVA = "0xF5C360", Offset = "0xF5AD60", VA = "0x180F5C360", Slot = "4")]
		protected virtual void Start()
		{
			GridObjectScript gridObjectScript = (GridObjectScript = GetComponentInParent<GridObjectScript>());
			CharacterManager characterManager = (this.characterManager = SystemRoot.Instance.GetSystem<CharacterManager>());
			PlayerTaskCollider playerTaskCollider = (PlayerTaskCollider = GetComponent<PlayerTaskCollider>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		protected virtual void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		internal virtual void Init()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC6")]
		[Cpp2IlInjected.Address(RVA = "0xF5BC90", Offset = "0xF5A690", VA = "0x180F5BC90", Slot = "7")]
		protected virtual void CustomEmployeeSetup(Character employee, bool startInteraction)
		{
			//Discarded unreachable code: IL_0014
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (employee != (UnityEngine.Object)num)
			{
				employee.TalkingToRequestor = startInteraction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		protected virtual void CustomSetup(bool startInteraction)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC8")]
		[Cpp2IlInjected.Address(RVA = "0xF5BB30", Offset = "0xF5A530", VA = "0x180F5BB30", Slot = "9")]
		[AsyncStateMachine(typeof(_003CCanInteract_003Ed__54))]
		public virtual Task<bool> CanInteract(PlayerTask task, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC9")]
		[Cpp2IlInjected.Address(RVA = "0xF5C230", Offset = "0xF5AC30", VA = "0x180F5C230")]
		[AsyncStateMachine(typeof(_003CStartInteraction_003Ed__55))]
		internal Task StartInteraction(PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCA")]
		[Cpp2IlInjected.Address(RVA = "0xF5BE20", Offset = "0xF5A820", VA = "0x180F5BE20")]
		[AsyncStateMachine(typeof(_003CInteract_003Ed__56))]
		internal Task Interact(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCB")]
		[Cpp2IlInjected.Address(RVA = "0xF5BD20", Offset = "0xF5A720", VA = "0x180F5BD20", Slot = "10")]
		protected virtual IEnumerable<Item> GetEmployeeItems()
		{
			Item[] array = default(Item[]);
			while (true)
			{
				IItemData itemData = ItemData;
				if (itemData != null && itemData != null && array == null)
				{
					/*Error: Could not find block for branch target IL_0013*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCC")]
		[Cpp2IlInjected.Address(RVA = "0xF5C0C0", Offset = "0xF5AAC0", VA = "0x180F5C0C0")]
		[AsyncStateMachine(typeof(_003CSetupInteraction_003Ed__58))]
		private Task SetupInteraction(PlayerAvatar avatar, CharacterManager.CharacterInstance employeeInstance, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCD")]
		[Cpp2IlInjected.Address(RVA = "0xF5BF70", Offset = "0xF5A970", VA = "0x180F5BF70")]
		[AsyncStateMachine(typeof(_003CResetInteraction_003Ed__59))]
		private Task ResetInteraction(PlayerAvatar avatar, Character employee, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DCE")]
		[Cpp2IlInjected.Address(RVA = "0xF5C490", Offset = "0xF5AE90", VA = "0x180F5C490")]
		protected Stall()
		{
			int num = 0;
			MinDistanceToTeleportEmployee = 10f;
			EmployeeRunKeepDistance = 0.5f;
			_fadeDurationInSeconds = 0.5f;
			navMeshCheckDistance = 0.5f;
			ControlMaps = new int[num];
			ToEnableWhenInteracting = (List<GameObject>)(object)new List<T>();
			ToDisableWhenInteracting = (List<GameObject>)(object)new List<T>();
			base._002Ector();
		}
	}
}
