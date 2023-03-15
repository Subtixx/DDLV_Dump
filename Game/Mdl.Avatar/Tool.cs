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
using Gameloft.Common;
using Mdl.Activities;
using Mdl.CameraFeedback;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000ABC")]
	public abstract class Tool : GridObjectStateUser
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003B3F")]
		[SerializeField]
		private Toolbox.ToolAttachmentPointType _attachmentPointType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003B40")]
		[SerializeField]
		private GameObject _visualGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003B41")]
		[SerializeField]
		private Transform _gridObjectVisualTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003B42")]
		[SerializeField]
		private AssetReferenceT<ToolAnimations> _femaleAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003B43")]
		[SerializeField]
		private AssetReferenceT<ToolAnimations> _maleAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003B44")]
		[SerializeField]
		private AssetReferenceT<ToolAnimations> _femaleGownAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003B45")]
		[SerializeField]
		private AssetReferenceT<ToolAnimations> _maleGownAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003B46")]
		[SerializeField]
		private ToolAnimations _defaultAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003B47")]
		private AssetReferenceT<ToolAnimations> loadedAnimations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003B48")]
		private Task _animationsLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003B49")]
		private bool _loadMaleAnimations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4003B4A")]
		private bool _loadGownAnimations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003B4B")]
		[SerializeField]
		private AK.Wwise.Event _equipSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003B4C")]
		[SerializeField]
		private AK.Wwise.Event _unequipSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003B4D")]
		[SerializeField]
		private GameObject _equipHandVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003B4E")]
		[SerializeField]
		private GameObject _unequipHandVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003B4F")]
		[SerializeField]
		private AssetReferenceGameObject _equipFemaleAvatarVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003B50")]
		[SerializeField]
		private AssetReferenceGameObject _unequipFemaleAvatarVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003B51")]
		[SerializeField]
		private AssetReferenceGameObject _equipMaleAvatarVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003B52")]
		[SerializeField]
		private AssetReferenceGameObject _unequipMaleAvatarVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003B53")]
		[SerializeField]
		private string _equipAnimationEvent = "action";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003B54")]
		[SerializeField]
		private string _unequipAnimationEvent = "action";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003B55")]
		[SerializeField]
		private string _equipLayerName = "EquipToolMovement";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003B56")]
		private int equipLayerIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4003B57")]
		[SerializeField]
		private string _equipTagName = "Equip";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4003B58")]
		[SerializeField]
		private bool _useToolLayer = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4003B59")]
		[SerializeField]
		protected BuffType _buffType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4003B5A")]
		[SerializeField]
		private AssetReferenceGameObject _buffVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4003B5B")]
		[SerializeField]
		private string _buffVFXEndTrigger = "out";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4003B5C")]
		private GameObject buffVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4003B5D")]
		[SerializeField]
		private AssetReferenceMaterial _buffMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4003B61")]
		private Task useToolTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4003B62")]
		private Collider collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003B63")]
		private PlayerTaskCollider playerTaskCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4003B64")]
		private AttentionVFX attentionVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4003B65")]
		private Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x4003B66")]
		protected static readonly GameObject[] NoPreviewGameObjects = new GameObject[0];

		[Cpp2IlInjected.Token(Token = "0x4003B67")]
		protected static readonly Vector3[] NoPreviewPositions;

		[Cpp2IlInjected.Token(Token = "0x4003B68")]
		private static readonly ProfilerMarker s_previewIsValidBlocker;

		[Cpp2IlInjected.Token(Token = "0x170006E0")]
		public Toolbox.ToolAttachmentPointType AttachmentPointType
		{
			[Cpp2IlInjected.Token(Token = "0x6003176")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return _attachmentPointType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E1")]
		public bool UseToolLayer
		{
			[Cpp2IlInjected.Token(Token = "0x6003179")]
			[Cpp2IlInjected.Address(RVA = "0x110E5C0", Offset = "0x110CFC0", VA = "0x18110E5C0")]
			get
			{
				return _useToolLayer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E2")]
		public abstract Toolbox.ToolType ToolType
		{
			[Cpp2IlInjected.Token(Token = "0x600317A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E3")]
		public bool IsUsingTool
		{
			[Cpp2IlInjected.Token(Token = "0x600317D")]
			[Cpp2IlInjected.Address(RVA = "0x13D8AC0", Offset = "0x13D74C0", VA = "0x1813D8AC0")]
			get
			{
				Task task = useToolTask;
				if (task == null)
				{
					int num = 0;
				}
				return !task.IsCompleted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x120"), Cpp2IlInjected.Token(Token = "0x4003B5F")]
		public bool IsEquippingTool
		{
			[Cpp2IlInjected.Token(Token = "0x600317E")]
			[Cpp2IlInjected.Address(RVA = "0xD2D610", Offset = "0xD2C010", VA = "0x180D2D610")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600317F")]
			[Cpp2IlInjected.Address(RVA = "0xD2D660", Offset = "0xD2C060", VA = "0x180D2D660")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x121"), Cpp2IlInjected.Token(Token = "0x4003B60")]
		public bool IsUnequippingTool
		{
			[Cpp2IlInjected.Token(Token = "0x6003180")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D00", Offset = "0x12F2700", VA = "0x1812F3D00")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003181")]
			[Cpp2IlInjected.Address(RVA = "0x13D8C20", Offset = "0x13D7620", VA = "0x1813D8C20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E6")]
		protected static (IEnumerable<GameObject>, IEnumerable<Vector3>) NoPreview
		{
			[Cpp2IlInjected.Token(Token = "0x6003183")]
			[Cpp2IlInjected.Address(RVA = "0x13D8AF0", Offset = "0x13D74F0", VA = "0x1813D8AF0")]
			get
			{
				int num = 0;
				GameObject[] noPreviewGameObjects = NoPreviewGameObjects;
				Vector3[] noPreviewPositions = NoPreviewPositions;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E7")]
		protected virtual bool EnableDebugLog
		{
			[Cpp2IlInjected.Token(Token = "0x6003185")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "11")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000080")]
		internal event EventHandler<GameObject> ToolInteractedWithObjectEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600317B")]
			[Cpp2IlInjected.Address(RVA = "0x13D8A20", Offset = "0x13D7420", VA = "0x1813D8A20")]
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
			[Cpp2IlInjected.Token(Token = "0x600317C")]
			[Cpp2IlInjected.Address(RVA = "0x13D8B80", Offset = "0x13D7580", VA = "0x1813D8B80")]
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

		[Cpp2IlInjected.Token(Token = "0x6003177")]
		[Cpp2IlInjected.Address(RVA = "0x13D6C30", Offset = "0x13D5630", VA = "0x1813D6C30")]
		public (AssetReferenceT<ToolAnimations>, AssetReferenceT<ToolAnimations>) GetAnimations(bool isMale)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003178")]
		[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
		public ToolAnimations GetDefaults()
		{
			return _defaultAnimation;
		}

		[Cpp2IlInjected.Token(Token = "0x6003182")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract Task<bool> UseTool(PlayerAvatar avatar);

		[Cpp2IlInjected.Token(Token = "0x6003184")]
		[Cpp2IlInjected.Address(RVA = "0x13D6CB0", Offset = "0x13D56B0", VA = "0x1813D6CB0", Slot = "10")]
		public virtual (IEnumerable<GameObject>, IEnumerable<Vector3>) GetToolPreview(PlayerAvatar avatar)
		{
			int num = 0;
			GameObject[] noPreviewGameObjects = NoPreviewGameObjects;
			Vector3[] noPreviewPositions = NoPreviewPositions;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003186")]
		[Cpp2IlInjected.Address(RVA = "0x13D8150", Offset = "0x13D6B50", VA = "0x1813D8150", Slot = "5")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_0152
			//IL_0016: Expected O, but got I4
			base.Start();
			GridObjectScript component = GetComponent<GridObjectScript>();
			int num = 0;
			if (component == (UnityEngine.Object)num || (long)component.GridObject == 0)
			{
				bool flag = default(bool);
				if (flag)
				{
					Collider collider = this.collider;
					int num2 = ((collider.enabled = false) ? 1 : 0);
				}
				bool flag3 = default(bool);
				if (flag3)
				{
					PlayerTaskCollider playerTaskCollider = this.playerTaskCollider;
					int num3 = ((playerTaskCollider.enabled = false) ? 1 : 0);
				}
				bool flag5 = default(bool);
				if (flag5)
				{
					AttentionVFX attentionVFX = this.attentionVFX;
					int num4 = ((attentionVFX.enabled = false) ? 1 : 0);
				}
				if (_buffType != 0 && (_buffVFXPrefab.RuntimeKeyIsValid() || _buffMaterial.RuntimeKeyIsValid()))
				{
					Client client = default(Client);
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
					ProfileEventDispatcher.PlayerBuffAdded value = Dispatcher_OnPlayerBuffAdded;
					_003CDispatcher_003Ek__BackingField.OnPlayerBuffAdded += value;
					Client client2 = default(Client);
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client2.Dispatcher;
					ProfileEventDispatcher.PlayerBuffRemoved value2 = Dispatcher_OnPlayerBuffRemoved;
					_003CDispatcher_003Ek__BackingField2.OnPlayerBuffRemoved += value2;
					if (_buffMaterial.RuntimeKeyIsValid())
					{
						Renderer[] array = (renderers = GetComponentsInChildren<Renderer>());
					}
					Client client3 = default(Client);
					ProfilePlayer player_ = client3.profile.player_;
					BuffType buffType = _buffType;
					if (player_.GetBuff(buffType) > 0)
					{
						LoadBuffVFXAndMaterialAsync().FireAndForgetTask();
					}
				}
			}
			Animator animator = SystemRoot.Instance._avatar.Animator;
			string equipLayerName = _equipLayerName;
			int num5 = (equipLayerIndex = animator.GetLayerIndex(equipLayerName));
		}

		[Cpp2IlInjected.Token(Token = "0x6003187")]
		[Cpp2IlInjected.Address(RVA = "0x13D74F0", Offset = "0x13D5EF0", VA = "0x1813D74F0", Slot = "6")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0073
			base.OnDestroy();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffAdded value = Dispatcher_OnPlayerBuffAdded;
					_003CDispatcher_003Ek__BackingField.OnPlayerBuffAdded -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffRemoved value2 = Dispatcher_OnPlayerBuffRemoved;
					_003CDispatcher_003Ek__BackingField2.OnPlayerBuffRemoved -= value2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003188")]
		[Cpp2IlInjected.Address(RVA = "0x13D7900", Offset = "0x13D6300", VA = "0x1813D7900")]
		internal void Prepare(Toolbox toolbox)
		{
			//Discarded unreachable code: IL_0121
			//IL_00c7: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Task animationsLoadTask = default(Task);
			_animationsLoadTask = animationsLoadTask;
			GameObject gameObject = base.gameObject;
			string text2 = (gameObject.name = base.gameObject.name.Replace("(Clone)", ""));
			GameObject gameObject2 = base.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			Transform transform = base.transform;
			Toolbox.ToolAttachmentPointType attachmentPointType = _attachmentPointType;
			Toolbox._003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new Toolbox._003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals0.toolAttachmentPointType = attachmentPointType;
			Toolbox.ToolAttachmentPoint[] toolAttachmentPoints = toolbox._toolAttachmentPoints;
			Func<Toolbox.ToolAttachmentPoint, bool> func = (Func<Toolbox.ToolAttachmentPoint, bool>)(object)(Func<T, TResult>)delegate(Toolbox.ToolAttachmentPoint x)
			{
				//Discarded unreachable code: IL_0011
				Toolbox.ToolAttachmentPointType toolAttachmentPointType = CS_0024_003C_003E8__locals0.toolAttachmentPointType;
				return x.attachmentPointType == toolAttachmentPointType;
			};
			Toolbox.ToolAttachmentPoint toolAttachmentPoint = Enumerable.FirstOrDefault<Toolbox.ToolAttachmentPoint>((IEnumerable<>)(object)toolAttachmentPoints, (Func<, >)(object)func);
			Transform parent = default(Transform);
			if (toolAttachmentPoint == null || (object)toolAttachmentPoint.transform == null)
			{
				parent = toolbox.transform;
			}
			transform.parent = parent;
			Transform transform2 = base.transform;
			int num3 = 0;
			Vector3 zero = Vector3.zero;
			transform2.localPosition = (Vector3)num3;
			Transform transform3 = base.transform;
			int num4 = 0;
			Quaternion identity = Quaternion.identity;
			transform3.localRotation = (Quaternion)num4;
			Renderer[] componentsInChildren = GetComponentsInChildren<Renderer>();
			int length = componentsInChildren.Length;
			if (num < length)
			{
				GameObject gameObject3 = componentsInChildren[num].gameObject;
				int num6 = (gameObject3.layer = LayerMask.NameToLayer("Player"));
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003189")]
		[Cpp2IlInjected.Address(RVA = "0x13D8750", Offset = "0x13D7150", VA = "0x1813D8750")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__68))]
		internal Task Use(PlayerAvatar avatar)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600318A")]
		[Cpp2IlInjected.Address(RVA = "0x13D7250", Offset = "0x13D5C50", VA = "0x1813D7250")]
		[AsyncStateMachine(typeof(_003CLoadAnimationsAsync_003Ed__69))]
		private Task LoadAnimationsAsync()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600318B")]
		[Cpp2IlInjected.Address(RVA = "0x13D6A70", Offset = "0x13D5470", VA = "0x1813D6A70")]
		internal void Equip(PlayerAvatar _avatar, bool _sendTrigger, CancellationToken _ct)
		{
			PlayerAvatar playerAvatar = _avatar;
			AvatarAppearance avatarAppearance = default(AvatarAppearance);
			if (avatarAppearance.GetAnimControllerType() == AvatarAppearance.AnimControllerType.Navigation && _avatar.appearance.IsAnimControllerTypeLoaded())
			{
				CancellationToken ct2 = _ct;
				bool sendTrigger2 = _sendTrigger;
				PlayerAvatar avatar2 = _avatar;
				EquipTool(avatar2, sendTrigger2, ct2).FireAndForgetTask();
				return;
			}
			AvatarAppearance appearance = _avatar.appearance;
			AvatarAppearance.AnimControllerTypeChanged value = ChangeAvatarAnimationsForTool;
			appearance.AnimControllerTypeChangedEvent += value;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x60031A4")]
			[Cpp2IlInjected.Address(RVA = "0x14230C0", Offset = "0x1421AC0", VA = "0x1814230C0")]
			void ChangeAvatarAnimationsForTool(AvatarAppearance.AnimControllerType animControllerType)
			{
				//Discarded unreachable code: IL_0032
				if (animControllerType == AvatarAppearance.AnimControllerType.Navigation)
				{
					AvatarAppearance appearance2 = _avatar.appearance;
					AvatarAppearance.AnimControllerTypeChanged value2 = ChangeAvatarAnimationsForTool;
					appearance2.AnimControllerTypeChangedEvent -= value2;
					bool flag = default(bool);
					if (!flag)
					{
						int num = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
					}
				}
			}
			[Cpp2IlInjected.Token(Token = "0x60031A5")]
			[Cpp2IlInjected.Address(RVA = "0x14232E0", Offset = "0x1421CE0", VA = "0x1814232E0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass70_0._003C_003CEquip_003Eg__EquipTool_007C1_003Ed))]
			Task EquipTool(PlayerAvatar avatar, bool sendTrigger, CancellationToken ct)
			{
				int num2 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600318C")]
		[Cpp2IlInjected.Address(RVA = "0x13D8610", Offset = "0x13D7010", VA = "0x1813D8610")]
		[AsyncStateMachine(typeof(_003CUnEquip_003Ed__71))]
		internal Task UnEquip(PlayerAvatar avatar, bool sendTrigger, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600318D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		protected virtual void OnUnequipped()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600318E")]
		[Cpp2IlInjected.Address(RVA = "0x13D77E0", Offset = "0x13D61E0", VA = "0x1813D77E0")]
		[AsyncStateMachine(typeof(_003CPlayUseAnimation_003Ed__73))]
		protected Task PlayUseAnimation(PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600318F")]
		[Cpp2IlInjected.Address(RVA = "0x13D6D90", Offset = "0x13D5790", VA = "0x1813D6D90", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_00c3
			//IL_0010: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			Collider collider = this.collider;
			int num = 0;
			if (collider != (UnityEngine.Object)num)
			{
				this.collider.enabled = true;
			}
			PlayerTaskCollider playerTaskCollider = this.playerTaskCollider;
			int num2 = 0;
			if (playerTaskCollider != (UnityEngine.Object)num2)
			{
				this.playerTaskCollider.enabled = true;
			}
			AttentionVFX attentionVFX = this.attentionVFX;
			int num3 = 0;
			if (attentionVFX != (UnityEngine.Object)num3)
			{
				this.attentionVFX.enabled = true;
			}
			GameObject visualGameObject = _visualGameObject;
			int num4 = 0;
			if (visualGameObject != (UnityEngine.Object)num4)
			{
				Transform gridObjectVisualTransform = _gridObjectVisualTransform;
				int num5 = 0;
				if (gridObjectVisualTransform != (UnityEngine.Object)num5)
				{
					Transform transform = _visualGameObject.transform;
					Transform gridObjectVisualTransform2 = _gridObjectVisualTransform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Transform transform2 = _visualGameObject.transform;
					Transform gridObjectVisualTransform3 = _gridObjectVisualTransform;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003190")]
		[Cpp2IlInjected.Address(RVA = "0x13D6FD0", Offset = "0x13D59D0", VA = "0x1813D6FD0")]
		protected static bool IsValidBlocker(Item item, ToolItemType toolItemType)
		{
			//Discarded unreachable code: IL_0044, IL_004a, IL_0050, IL_0056, IL_005c
			int num = 0;
			ProfilerMarker profilerMarker = s_previewIsValidBlocker;
			bool flag = default(bool);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			if (flag && furnitureItemType == FurnitureItemType.Blocker)
			{
				FurnitureBlockerItemData furnitureBlockerItemData = default(FurnitureBlockerItemData);
				Item toolItem = furnitureBlockerItemData.ToolItem;
				ToolItemType toolItemType2 = default(ToolItemType);
				if (toolItemType2 == toolItemType)
				{
					Client client = default(Client);
					ProfilePlayer player_ = client.profile.player_;
					Item upgradeItem = furnitureBlockerItemData.UpgradeItem;
				}
				int num2 = 0;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003191")]
		[Cpp2IlInjected.Address(RVA = "0x13D7CF0", Offset = "0x13D66F0", VA = "0x1813D7CF0")]
		[AsyncStateMachine(typeof(_003CRemoveBlocker_003Ed__77))]
		protected Task RemoveBlocker(Vector3 originPosition, uint gridID, uint gridObjectID, CancellationToken ct, [System.Runtime.InteropServices.Optional] RewardSpawnAnimationData rewardSpawnAnimationDataOverride)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003192")]
		[Cpp2IlInjected.Address(RVA = "0x13D7780", Offset = "0x13D6180", VA = "0x1813D7780")]
		protected void OnToolInteractedWithObject(GameObject gameObject)
		{
			((EventHandler<TEventArgs>)(object)this.ToolInteractedWithObjectEvent)?.Invoke((object)this, (TEventArgs)gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003193")]
		[Cpp2IlInjected.Address(RVA = "0x13D6920", Offset = "0x13D5320", VA = "0x1813D6920")]
		protected void AddTrauma(Camera playerCamera, float trauma)
		{
			//Discarded unreachable code: IL_001b
			//IL_0010: Expected O, but got I4
			CameraFeedbackUnscaledTraumaScreenshake component = playerCamera.GetComponent<CameraFeedbackUnscaledTraumaScreenshake>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				component.AddTrauma(trauma);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003194")]
		[Cpp2IlInjected.Address(RVA = "0x13D69D0", Offset = "0x13D53D0", VA = "0x1813D69D0")]
		private void Dispatcher_OnPlayerBuffAdded(BuffOrigin buffOrigin, BuffType buffType, int percentageEffect)
		{
			if (buffType == _buffType)
			{
				LoadBuffVFXAndMaterialAsync().FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003195")]
		[Cpp2IlInjected.Address(RVA = "0x13D7480", Offset = "0x13D5E80", VA = "0x1813D7480")]
		private void LoadBuffVFXAndMaterial()
		{
			LoadBuffVFXAndMaterialAsync().FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003196")]
		[Cpp2IlInjected.Address(RVA = "0x13D7360", Offset = "0x13D5D60", VA = "0x1813D7360", Slot = "13")]
		[AsyncStateMachine(typeof(_003CLoadBuffVFXAndMaterialAsync_003Ed__82))]
		protected virtual Task LoadBuffVFXAndMaterialAsync()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003197")]
		[Cpp2IlInjected.Address(RVA = "0x13D6A50", Offset = "0x13D5450", VA = "0x1813D6A50")]
		private void Dispatcher_OnPlayerBuffRemoved(BuffOrigin buffOrigin, BuffType buffType)
		{
			if (buffType == _buffType)
			{
				Toolbox.ToolType toolType = ToolType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003198")]
		[Cpp2IlInjected.Address(RVA = "0x13D7E60", Offset = "0x13D6860", VA = "0x1813D7E60", Slot = "14")]
		protected virtual void RemoveBuffVFXAndMaterial()
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			if (flag && flag2 && flag3)
			{
				string buffVFXEndTrigger = _buffVFXEndTrigger;
				if (!flag3)
				{
					GameObject gameObject = default(GameObject);
					DestroyOnEnable destroyOnEnable = gameObject.AddComponent<DestroyOnEnable>();
				}
			}
			if (!_buffMaterial.RuntimeKeyIsValid())
			{
				return;
			}
			Renderer[] array = renderers;
			int num = 0;
			int num2 = 0;
			int length = array.Length;
			if (num2 < length)
			{
				Renderer renderer = array[num];
				Material[] sharedMaterialArray = renderer.GetSharedMaterialArray();
				UnityEngine.Object asset = _buffMaterial.Asset;
				if ((object)asset == null)
				{
					int num3 = 0;
				}
				int num4 = 0;
				if ((object)asset == null)
				{
					throw new InvalidCastException();
				}
				IEnumerable<Material> enumerable = default(IEnumerable<Material>);
				Material[] materialArray = Enumerable.Except<Material>((IEnumerable<>)(object)sharedMaterialArray, (IEnumerable<>)enumerable).ToArray<Material>();
				renderer.SetMaterialArray(materialArray);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003199")]
		[Cpp2IlInjected.Address(RVA = "0x13D8950", Offset = "0x13D7350", VA = "0x1813D8950")]
		protected Tool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600319A")]
		[Cpp2IlInjected.Address(RVA = "0x13D8870", Offset = "0x13D7270", VA = "0x1813D8870")]
		static Tool()
		{
			//IL_0030: Expected O, but got I
			NoPreviewGameObjects = (GameObject[])(object)new Vector3[0];
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			s_previewIsValidBlocker = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("IsValidBlocker", categoryId, (MarkerFlags)flags, metadataCount);
		}
	}
}
