using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Characters.Pets;
using Mdl.Gestures;
using Mdl.Graphic;
using Mdl.InputSystem;
using Mdl.Motion;
using Mdl.Systems;
using Mdl.Ui;
using Mdl.Utils;
using Meta;
using Meta.Customization;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A25")]
	public class AvatarCustomization : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x2000A26")]
		public delegate void SaveClothingDesignError(SaveClothingDesign.Types.Result error);

		[Cpp2IlInjected.Token(Token = "0x2000A27")]
		public delegate void DeleteClothingDesignError(DeleteClothingDesign.Types.Result error);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A28")]
		public class SelectionAnimTrigger
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003869")]
			public ClothingItemType clothingType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400386A")]
			public string parameter;

			[Cpp2IlInjected.Token(Token = "0x6002FBD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SelectionAnimTrigger()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A29")]
		public delegate void AvatarReady(AvatarAppearance avatar);

		[Cpp2IlInjected.Token(Token = "0x2000A2A")]
		public delegate void SaveAvatarError(Meta.AvatarCustomization.Types.Result error);

		[Cpp2IlInjected.Token(Token = "0x2000A2B")]
		private enum ZoomAction
		{
			[Cpp2IlInjected.Token(Token = "0x400386C")]
			ZoomIn,
			[Cpp2IlInjected.Token(Token = "0x400386D")]
			ZoomOut,
			[Cpp2IlInjected.Token(Token = "0x400386E")]
			None
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003839")]
		public AssetReference purchasePopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400383A")]
		public float avatarRotationFriction = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400383B")]
		public float avatarRotationSpeed = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400383C")]
		public float avatarRotationGamepadMaxSpeed = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400383D")]
		public float avatarRotateBackAfterSeconds = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400383E")]
		public float avatarRotateBackDuration = 0.8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400383F")]
		public float zoomInDistance = 1.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003840")]
		public float zoomInMaxX = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4003841")]
		public float zoomInMaxY = 1.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003842")]
		public float shadowCascadeSafeDistanceOffset = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003843")]
		public RectTransform inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003844")]
		[SerializeField]
		private float _undoAllPressDelay = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003845")]
		public List<SelectionAnimTrigger> selectionAnimTriggers = (List<SelectionAnimTrigger>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003846")]
		public string happyAnimTrigger = "happy";

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003847")]
		public float holdDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4003848")]
		public float dragTolerance = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400384A")]
		private UnityEngine.Vector3 _startingCameraPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400384B")]
		private Quaternion _startingCameraRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400384C")]
		private UnityEngine.Vector3 _targetCameraPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400384D")]
		private Quaternion _targetCameraRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400384E")]
		private Tween<float> _initCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400384F")]
		private Quaternion _defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4003850")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4003851")]
		private HoldInPlaceGesture _hold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003852")]
		private float _idleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4003853")]
		private Tween<Quaternion> _avatarRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4003854")]
		private bool _enableMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x149")]
		[Cpp2IlInjected.Token(Token = "0x4003855")]
		private bool _zoomedIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14A")]
		[Cpp2IlInjected.Token(Token = "0x4003856")]
		private bool _zoomedInOnAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14B")]
		[Cpp2IlInjected.Token(Token = "0x4003857")]
		private bool _holdWasTrue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4003858")]
		private bool _historyEnabled = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003859")]
		private HistoryStack<AvatarWorkingCopy> _history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400385B")]
		private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400385C")]
		private Toolbox.TemporarySwitchToolScope removeToolScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400385D")]
		private InputAction inputZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400385E")]
		private InputAction inputRotateYaw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400385F")]
		private InputAction inputResetCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003860")]
		private IDisposable overrideControlMapScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003861")]
		private UnityEngine.Vector3 zoomTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4003862")]
		private Quaternion zoomRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4003863")]
		[SerializeField]
		private float avatarRotateTowardsCameraDuration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003864")]
		private UniversalRenderPipelineAsset lwrp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4003865")]
		private UnityEngine.Vector3 m_Cascade4SplitOld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4003866")]
		private float m_Cascade2SplitOld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4003867")]
		private FieldInfo m_Cascade4Split = typeof(UniversalRenderPipelineAsset).GetField("m_Cascade4Split", BindingFlags.Instance | BindingFlags.NonPublic);

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4003868")]
		private FieldInfo m_Cascade2Split = typeof(UniversalRenderPipelineAsset).GetField("m_Cascade2Split", BindingFlags.Instance | BindingFlags.NonPublic);

		[Cpp2IlInjected.Token(Token = "0x170006AB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x70"), Cpp2IlInjected.Token(Token = "0x4003838")]
		public ClothingItemType ClothingType
		{
			[Cpp2IlInjected.Token(Token = "0x6002F6A")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002F6B")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006AC")]
		public float UndoAllPressDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6002F75")]
			[Cpp2IlInjected.Address(RVA = "0x151D8A0", Offset = "0x151C2A0", VA = "0x18151D8A0")]
			get
			{
				return _undoAllPressDelay;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AD")]
		public bool HistoryIsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6002F78")]
			[Cpp2IlInjected.Address(RVA = "0x151D880", Offset = "0x151C280", VA = "0x18151D880")]
			get
			{
				while (_historyEnabled)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F79")]
			[Cpp2IlInjected.Address(RVA = "0xA5C400", Offset = "0xA5AE00", VA = "0x180A5C400")]
			set
			{
				_historyEnabled = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AE")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6002F7C")]
			[Cpp2IlInjected.Address(RVA = "0x151D850", Offset = "0x151C250", VA = "0x18151D850")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000075")]
		public event SaveClothingDesignError OnSaveClothingDesignError
		{
			[Cpp2IlInjected.Token(Token = "0x6002F66")]
			[Cpp2IlInjected.Address(RVA = "0x151D7B0", Offset = "0x151C1B0", VA = "0x18151D7B0")]
			[CompilerGenerated]
			add
			{
				SaveClothingDesignError onSaveClothingDesignError = this.OnSaveClothingDesignError;
				Delegate @delegate = Delegate.Combine(onSaveClothingDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSaveClothingDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002F67")]
			[Cpp2IlInjected.Address(RVA = "0x151DA90", Offset = "0x151C490", VA = "0x18151DA90")]
			[CompilerGenerated]
			remove
			{
				SaveClothingDesignError onSaveClothingDesignError = this.OnSaveClothingDesignError;
				Delegate @delegate = Delegate.Remove(onSaveClothingDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSaveClothingDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000076")]
		public event DeleteClothingDesignError OnDeleteClothingDesignError
		{
			[Cpp2IlInjected.Token(Token = "0x6002F68")]
			[Cpp2IlInjected.Address(RVA = "0x151D670", Offset = "0x151C070", VA = "0x18151D670")]
			[CompilerGenerated]
			add
			{
				DeleteClothingDesignError onDeleteClothingDesignError = this.OnDeleteClothingDesignError;
				Delegate @delegate = Delegate.Combine(onDeleteClothingDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDeleteClothingDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002F69")]
			[Cpp2IlInjected.Address(RVA = "0x151D950", Offset = "0x151C350", VA = "0x18151D950")]
			[CompilerGenerated]
			remove
			{
				DeleteClothingDesignError onDeleteClothingDesignError = this.OnDeleteClothingDesignError;
				Delegate @delegate = Delegate.Remove(onDeleteClothingDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDeleteClothingDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000077")]
		public event AvatarReady OnAvatarReady
		{
			[Cpp2IlInjected.Token(Token = "0x6002F76")]
			[Cpp2IlInjected.Address(RVA = "0x151D5D0", Offset = "0x151BFD0", VA = "0x18151D5D0")]
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
			[Cpp2IlInjected.Token(Token = "0x6002F77")]
			[Cpp2IlInjected.Address(RVA = "0x151D8B0", Offset = "0x151C2B0", VA = "0x18151D8B0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000078")]
		public event SaveAvatarError OnSaveAvatarError
		{
			[Cpp2IlInjected.Token(Token = "0x6002F7A")]
			[Cpp2IlInjected.Address(RVA = "0x151D710", Offset = "0x151C110", VA = "0x18151D710")]
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
			[Cpp2IlInjected.Token(Token = "0x6002F7B")]
			[Cpp2IlInjected.Address(RVA = "0x151D9F0", Offset = "0x151C3F0", VA = "0x18151D9F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002F6C")]
		[Cpp2IlInjected.Address(RVA = "0x1518330", Offset = "0x1516D30", VA = "0x181518330")]
		public Task SaveDesignAsync(Item item, DesignWorkingCopy design, Action onComplete)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6D")]
		[Cpp2IlInjected.Address(RVA = "0x1518330", Offset = "0x1516D30", VA = "0x181518330")]
		[AsyncStateMachine(typeof(_003CSaveDesignAsyncPrivate_003Ed__13))]
		private Task SaveDesignAsyncPrivate(Item item, DesignWorkingCopy design, Action onComplete)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6E")]
		[Cpp2IlInjected.Address(RVA = "0x1515F00", Offset = "0x1514900", VA = "0x181515F00")]
		[AsyncStateMachine(typeof(_003CDeleteDesignAsync_003Ed__14))]
		public Task DeleteDesignAsync(Item item, DesignWorkingCopy design, Action onComplete)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6F")]
		[Cpp2IlInjected.Address(RVA = "0x1515DB0", Offset = "0x15147B0", VA = "0x181515DB0")]
		[AsyncStateMachine(typeof(_003CDeleteDesignAsync_003Ed__15))]
		public Task DeleteDesignAsync(Item item, int designId, Action onComplete)
		{
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F70")]
		[Cpp2IlInjected.Address(RVA = "0x15167A0", Offset = "0x15151A0", VA = "0x1815167A0")]
		public DesignWorkingCopy GetDesignWorkingCopy(bool clone)
		{
			//Discarded unreachable code: IL_0072
			//IL_0039: Expected I4, but got I8
			AvatarAppearance appearance = avatar.appearance;
			ClothingItemType type = ClothingType;
			DesignWorkingCopy currentDesignWorkingCopy = appearance.GetCurrentDesignWorkingCopy(type);
			if (clone)
			{
				new DesignWorkingCopy(currentDesignWorkingCopy).Data.id_ = -1;
			}
			if (string.IsNullOrEmpty(currentDesignWorkingCopy.Data.baseColor_))
			{
				Design _003CData_003Ek__BackingField = currentDesignWorkingCopy.Data;
				Color white = Color.white;
				string text = default(string);
				string text3 = (_003CData_003Ek__BackingField.BaseColor = "#" + text);
			}
			return currentDesignWorkingCopy;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F71")]
		[Cpp2IlInjected.Address(RVA = "0x1519F70", Offset = "0x1518970", VA = "0x181519F70")]
		[AsyncStateMachine(typeof(_003CStartDesignMode_003Ed__17))]
		public Task StartDesignMode(ClothingItemType clothingType, bool forceEditDecals)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F72")]
		[Cpp2IlInjected.Address(RVA = "0x151A5B0", Offset = "0x1518FB0", VA = "0x18151A5B0")]
		[AsyncStateMachine(typeof(_003CStopDesignMode_003Ed__18))]
		public Task StopDesignMode()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F73")]
		[Cpp2IlInjected.Address(RVA = "0x151A090", Offset = "0x1518A90", VA = "0x18151A090")]
		[AsyncStateMachine(typeof(_003CStartEditingDecals_003Ed__19))]
		public Task<Collider> StartEditingDecals()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Collider>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F74")]
		[Cpp2IlInjected.Address(RVA = "0x151A6B0", Offset = "0x15190B0", VA = "0x18151A6B0")]
		public void StopEditingDecals()
		{
			//Discarded unreachable code: IL_004e
			avatar.Collider.enabled = true;
			avatar.Animator.SetTrigger("Exit");
			((HashSet<T>)(object)avatar.appearance._hiddenClothing).Clear();
			AvatarAppearance appearance = avatar.appearance;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7D")]
		[Cpp2IlInjected.Address(RVA = "0x151A1D0", Offset = "0x1518BD0", VA = "0x18151A1D0")]
		private void Start()
		{
			//IL_000f: Expected I4, but got I8
			//IL_000f: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			ulong num2 = default(ulong);
			int automaticRotation = default(int);
			int num = default(int);
			MoveGesture moveGesture = new MoveGesture(inputZone, (Camera)num, (byte)automaticRotation != 0, (byte)num2 != 0);
			int num3 = 0;
			automaticRotation = 0;
			num = 0;
			moveGesture.MaxForce = 1f;
			float num4 = (moveGesture.Friction = avatarRotationFriction);
			_move = moveGesture;
			int num5 = default(int);
			HoldInPlaceGesture holdInPlaceGesture = new HoldInPlaceGesture(inputZone, (Camera)num5);
			num5 = 0;
			float num6 = (holdInPlaceGesture.MinDuration = holdDuration);
			float num7 = (holdInPlaceGesture.DragTolerance = dragTolerance);
			_hold = holdInPlaceGesture;
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num8 = default(int);
			InputActionFloat inputActionFloat = new InputActionFloat("AvatarCustomization_Zoom", trigger, (string)num8, (InputProvider)num3);
			num8 = 0;
			inputZoom = inputActionFloat;
			InputAction inputAction = inputZoom;
			InputActionModifier_ManualDeadzone modifier = new InputActionModifier_ManualDeadzone();
			inputAction.AddModifier(modifier);
			InputTriggerDown trigger2 = new InputTriggerDown();
			int num9 = default(int);
			InputActionFloat inputActionFloat2 = new InputActionFloat("AvatarCustomization_RotateYaw", trigger2, (string)num9, (InputProvider)num3);
			num9 = 0;
			inputRotateYaw = inputActionFloat2;
			InputAction inputAction2 = inputRotateYaw;
			Func<bool> _003C_003E9__83_ = _003C_003Ec._003C_003E9__83_0;
			if (_003C_003E9__83_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<TResult>)(() => Input.InteractingWithTextField);
			}
			InputActionModifier_SuppressIf modifier2 = new InputActionModifier_SuppressIf((Func<>)(object)_003C_003E9__83_);
			inputAction2.AddModifier(modifier2);
			InputTriggerPressed trigger3 = new InputTriggerPressed();
			int num10 = default(int);
			InputActionBool inputActionBool = new InputActionBool("AvatarCustomization_ResetCamera", trigger3, (InputProvider)num10);
			num10 = 0;
			inputResetCamera = inputActionBool;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7E")]
		[Cpp2IlInjected.Address(RVA = "0x1516A50", Offset = "0x1515450", VA = "0x181516A50", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7F")]
		[Cpp2IlInjected.Address(RVA = "0x1519BD0", Offset = "0x15185D0", VA = "0x181519BD0")]
		private unsafe void SetupInitialCameraAndAvatarRotation()
		{
			//Discarded unreachable code: IL_00a2
			//IL_0064: Expected native int or pointer, but got O
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			PlayerAvatar playerAvatar = avatar;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
			Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			PlayerAvatar playerAvatar2 = avatar;
			UnityEngine.Vector3 lookAtPosition = default(UnityEngine.Vector3);
			((UnityEngine.Vector3*)(IntPtr)lookAtPosition)->z = z2;
			Transform _003Ctransform_003Ek__BackingField3 = playerAvatar2.transform;
			Transform _003Ctransform_003Ek__BackingField4 = avatar.transform;
			FindValidPetPosition();
			Transform _003Ctransform_003Ek__BackingField5 = SystemRoot.Instance._avatar.transform;
			AvatarTask().FireAndForgetTask();
			[Cpp2IlInjected.Token(Token = "0x6002FD7")]
			[Cpp2IlInjected.Address(RVA = "0x1BD68E0", Offset = "0x1BD52E0", VA = "0x181BD68E0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass85_0._003C_003CSetupInitialCameraAndAvatarRotation_003Eg__AvatarTask_007C0_003Ed))]
			Task AvatarTask()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F80")]
		[Cpp2IlInjected.Address(RVA = "0x1519AD0", Offset = "0x15184D0", VA = "0x181519AD0")]
		public void SetZoomTargetByName(string targetName)
		{
			//Discarded unreachable code: IL_0035
			NameToCameraTransform clothingCameraMappings = avatar.GetComponent<NameToCameraTransform>();
			Func<(UnityEngine.Vector3, Quaternion)> func = (Func<(UnityEngine.Vector3, Quaternion)>)(object)(Func<TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			this.UpdateZoomTarget((Func<>)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F81")]
		[Cpp2IlInjected.Address(RVA = "0x1518240", Offset = "0x1516C40", VA = "0x181518240")]
		public void ResetZoomTarget()
		{
			//Discarded unreachable code: IL_002e
			NameToCameraTransform clothingCameraMappings = avatar.GetComponent<NameToCameraTransform>();
			Func<(UnityEngine.Vector3, Quaternion)> func = (Func<(UnityEngine.Vector3, Quaternion)>)(object)(Func<TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			this.UpdateZoomTarget((Func<>)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F82")]
		[Cpp2IlInjected.Address(RVA = "0x151B220", Offset = "0x1519C20", VA = "0x18151B220")]
		private void UpdateZoomTarget(Func<(UnityEngine.Vector3, Quaternion)> getZoomDelegate)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F83")]
		[Cpp2IlInjected.Address(RVA = "0x1516950", Offset = "0x1515350", VA = "0x181516950")]
		[AsyncStateMachine(typeof(_003CLoadAvatarAsync_003Ed__89))]
		private Task LoadAvatarAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F84")]
		[Cpp2IlInjected.Address(RVA = "0x1515900", Offset = "0x1514300", VA = "0x181515900")]
		private void AvatarIsReady()
		{
			//Discarded unreachable code: IL_0058
			PlayerAvatar playerAvatar = avatar;
			_historyEnabled = true;
			AvatarAppearance appearance = playerAvatar.appearance;
			if (appearance.IsMale)
			{
			}
			HistoryStack<AvatarWorkingCopy> historyStack = (_history = (HistoryStack<AvatarWorkingCopy>)(object)new HistoryStack<T>((T)new AvatarWorkingCopy(appearance._femaleAvatar)));
			AvatarReady onAvatarReady = this.OnAvatarReady;
			if (onAvatarReady != null)
			{
				AvatarAppearance appearance2 = avatar.appearance;
				onAvatarReady(appearance2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F85")]
		[Cpp2IlInjected.Address(RVA = "0x1517410", Offset = "0x1515E10", VA = "0x181517410", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_00f7
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00db: Expected O, but got F4
			//IL_00f6: Expected O, but got F4
			BaseUiRoot.Instance.ShowLootOfflineMarkers();
			BaseUiRoot.Instance.ShowMailboxMarkers();
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				CameraCollisionSystem system = _003CInstance_003Ek__BackingField.GetSystem<CameraCollisionSystem>();
			}
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				Transform transform = playerCamera.transform;
			}
			_history = (HistoryStack<AvatarWorkingCopy>)num;
			if (overrideControlMapScope != null)
			{
			}
			avatar.Collider.enabled = true;
			avatar.petMaster.UnlockedPet();
			PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
			AvatarAppearance appearance = avatar.appearance;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			avatar.appearance.UnloadAfterCloseAvatarCustomization();
			bool flag = default(bool);
			if (flag)
			{
				int num4 = 0;
				removeToolScope = (Toolbox.TemporarySwitchToolScope)num4;
			}
			float z = m_Cascade4SplitOld.z;
			FieldInfo cascade4Split = m_Cascade4Split;
			UniversalRenderPipelineAsset obj = lwrp;
			cascade4Split.SetValue(obj, z);
			FieldInfo cascade2Split = m_Cascade2Split;
			UniversalRenderPipelineAsset obj2 = lwrp;
			cascade2Split.SetValue(obj2, z);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F86")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F87")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F88")]
		[Cpp2IlInjected.Address(RVA = "0x151B330", Offset = "0x1519D30", VA = "0x18151B330")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F89")]
		[Cpp2IlInjected.Address(RVA = "0x1517980", Offset = "0x1516380", VA = "0x181517980")]
		[Conditional("DEBUG_AVATAR_CUSTOMIZATION")]
		private void OnscreenDebugging()
		{
			//Discarded unreachable code: IL_009f
			//IL_0037: Expected O, but got F4
			//IL_004f: Expected O, but got F4
			//IL_0063: Expected O, but got I4
			//IL_0084: Expected O, but got F4
			Action<string, object> _003C_003E9__95_ = _003C_003Ec._003C_003E9__95_0;
			if (_003C_003E9__95_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T1, T2>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			float z = zoomTarget.z;
			_003C_003E9__95_((T1)"zoomTarget", (T2)z);
			z = _targetCameraPos.z;
			_003C_003E9__95_((T1)"_targetCameraPos", (T2)z);
			Camera camera = SystemRoot.Instance._playerCamera;
			int num = 0;
			if (!(camera != (UnityEngine.Object)num))
			{
			}
			Transform transform = camera.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z2 = vector.z;
			_003C_003E9__95_((T1)"current", (T2)z2);
			NameToCameraTransform component = avatar.GetComponent<NameToCameraTransform>();
			(UnityEngine.Vector3, Quaternion) arg = default((UnityEngine.Vector3, Quaternion));
			_003C_003E9__95_((T1)"eyes", (T2)arg);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8A")]
		[Cpp2IlInjected.Address(RVA = "0x151AF40", Offset = "0x1519940", VA = "0x18151AF40")]
		private void UpdateShadowCascadeSplits()
		{
			//IL_0064: Expected O, but got F4
			Transform transform = playerCamera.transform;
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			Transform transform2 = playerCamera.transform;
			Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			ShadowCascadesOption shadowCascadeOption = lwrp.shadowCascadeOption;
			if (shadowCascadeOption == ShadowCascadesOption.TwoCascades)
			{
				UniversalRenderPipelineAsset obj = lwrp;
				float num = default(float);
				m_Cascade2Split.SetValue(obj, num);
				return;
			}
			while (shadowCascadeOption != ShadowCascadesOption.FourCascades)
			{
			}
			FieldInfo cascade4Split = m_Cascade4Split;
			UniversalRenderPipelineAsset obj2 = lwrp;
			object value = cascade4Split.GetValue(obj2);
			UniversalRenderPipelineAsset universalRenderPipelineAsset = lwrp;
			FieldInfo cascade4Split2 = m_Cascade4Split;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8B")]
		[Cpp2IlInjected.Address(RVA = "0x151C5E0", Offset = "0x151AFE0", VA = "0x18151C5E0")]
		public void ZoomInTowardsTargetPoint()
		{
			Quaternion quaternion = zoomRotation;
			float z = zoomTarget.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8C")]
		[Cpp2IlInjected.Address(RVA = "0x151C630", Offset = "0x151B030", VA = "0x18151C630")]
		private unsafe void ZoomInTowardsTargetPoint(UnityEngine.Vector3 target, Quaternion rotation, float duration = 0.5f)
		{
			//Discarded unreachable code: IL_0113
			//IL_0021: Expected native int or pointer, but got O
			//IL_003e: Expected native int or pointer, but got O
			//IL_006b: Expected native int or pointer, but got O
			//IL_00c9: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			Transform transform = playerCamera.transform;
			Camera camera = playerCamera;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			((UnityEngine.Vector3*)(IntPtr)_startingCameraPos)->z = z;
			Transform transform2 = camera.transform;
			float z2 = target.z;
			((UnityEngine.Vector3*)(IntPtr)_targetCameraPos)->z = z2;
			AvatarAppearance appearance = avatar.appearance;
			if (appearance.IsMale)
			{
				float maleHeadYOffset = appearance.maleHeadYOffset;
				((UnityEngine.Vector3*)(IntPtr)_targetCameraPos)->y = maleHeadYOffset;
			}
			Transform transform3 = playerCamera.transform;
			float z3 = _targetCameraPos.z;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z4 = vector2.z;
			bool flag = default(bool);
			if (!flag)
			{
				Transform transform4 = playerCamera.transform;
				UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
				float z5 = vector3.z;
				UnityEngine.Vector3 vector4 = default(UnityEngine.Vector3);
				float z6 = vector4.z;
				bool flag2 = default(bool);
				if (!flag2)
				{
					goto IL_0107;
				}
			}
			int num = default(int);
			Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num2 = 0;
			Tween<float> initCamera = default(Tween<float>);
			_initCamera = initCamera;
			Tween<float> initCamera2 = _initCamera;
			Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateCamera);
			((Tween<T>)(object)initCamera2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			goto IL_0107;
			IL_0107:
			PostProcessManager.Instance.SetDof(DOFDistance.FAR);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8D")]
		[Cpp2IlInjected.Address(RVA = "0x15168C0", Offset = "0x15152C0", VA = "0x1815168C0")]
		private ZoomAction GetZoomActionFromInput(InputAction a)
		{
			//Discarded unreachable code: IL_0016
			//IL_0009: Invalid comparison between I4 and F4
			float valueFloat = a.GetValueFloat();
			if (!(0f > valueFloat))
			{
				float valueFloat2 = a.GetValueFloat();
				return ZoomAction.None;
			}
			return ZoomAction.ZoomOut;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8E")]
		[Cpp2IlInjected.Address(RVA = "0x151AC30", Offset = "0x1519630", VA = "0x18151AC30")]
		private void UpdateAvatarRotation(Quaternion rotation, float progress)
		{
			//Discarded unreachable code: IL_000d
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F8F")]
		[Cpp2IlInjected.Address(RVA = "0x151AA00", Offset = "0x1519400", VA = "0x18151AA00")]
		[AsyncStateMachine(typeof(_003CTryBuyMissingItems_003Ed__102))]
		public Task<bool> TryBuyMissingItems()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F90")]
		[Cpp2IlInjected.Address(RVA = "0x151A8D0", Offset = "0x15192D0", VA = "0x18151A8D0")]
		[AsyncStateMachine(typeof(_003CTryBuyMissingItemsAndDeliver_003Ed__103))]
		public Task<bool> TryBuyMissingItemsAndDeliver()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F91")]
		[Cpp2IlInjected.Address(RVA = "0x1515C70", Offset = "0x1514670", VA = "0x181515C70")]
		[AsyncStateMachine(typeof(_003CConfirm_003Ed__104))]
		public Task<Meta.AvatarCustomization.Types.Result> Confirm([System.Runtime.InteropServices.Optional] Action onComplete)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Meta.AvatarCustomization.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F92")]
		[Cpp2IlInjected.Address(RVA = "0x1515A70", Offset = "0x1514470", VA = "0x181515A70")]
		[AsyncStateMachine(typeof(_003CCancel_003Ed__105))]
		public Task Cancel()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F93")]
		[Cpp2IlInjected.Address(RVA = "0x151CA10", Offset = "0x151B410", VA = "0x18151CA10")]
		public void ZoomIn(float duration = 1f)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F94")]
		[Cpp2IlInjected.Address(RVA = "0x151CEF0", Offset = "0x151B8F0", VA = "0x18151CEF0")]
		public unsafe void ZoomOut(float duration = 1f)
		{
			//Discarded unreachable code: IL_011b
			//IL_003d: Expected native int or pointer, but got O
			//IL_0071: Expected native int or pointer, but got O
			//IL_00bd: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
			Transform transform = playerCamera.transform;
			Camera camera = playerCamera;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			((UnityEngine.Vector3*)(IntPtr)_startingCameraPos)->z = z;
			Transform transform2 = camera.transform;
			Transform customizationStartCamera = avatar.customizationStartCamera;
			PlayerAvatar playerAvatar = avatar;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			((UnityEngine.Vector3*)(IntPtr)_targetCameraPos)->z = z2;
			Transform customizationStartCamera2 = playerAvatar.customizationStartCamera;
			Transform transform3 = playerCamera.transform;
			float z3 = _targetCameraPos.z;
			bool flag = default(bool);
			if (!flag)
			{
				Transform transform4 = playerCamera.transform;
				bool flag2 = default(bool);
				if (!flag2)
				{
					goto IL_0106;
				}
			}
			int num = default(int);
			Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num2 = 0;
			Tween<float> initCamera = default(Tween<float>);
			_initCamera = initCamera;
			Tween<float> initCamera2 = _initCamera;
			Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateCamera);
			((Tween<T>)(object)initCamera2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			PostProcessManager.Instance.SetDof(DOFDistance.MID);
			goto IL_0106;
			IL_0106:
			Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
			_zoomedIn = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F95")]
		[Cpp2IlInjected.Address(RVA = "0x151AC70", Offset = "0x1519670", VA = "0x18151AC70")]
		private void UpdateCamera(float value, float progress)
		{
			//Discarded unreachable code: IL_0041
			Transform transform = playerCamera.transform;
			float z = _targetCameraPos.z;
			float z2 = _startingCameraPos.z;
			Transform transform2 = playerCamera.transform;
			Quaternion targetCameraRot = _targetCameraRot;
			Quaternion startingCameraRot = _startingCameraRot;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F96")]
		[Cpp2IlInjected.Address(RVA = "0x1518480", Offset = "0x1516E80", VA = "0x181518480")]
		private void SaveHistory()
		{
			//Discarded unreachable code: IL_003d
			if (!_historyEnabled)
			{
				return;
			}
			HistoryStack<AvatarWorkingCopy> history = _history;
			if (history != null)
			{
				AvatarAppearance appearance = avatar.appearance;
				if (appearance.IsMale)
				{
				}
				AvatarWorkingCopy state = new AvatarWorkingCopy(appearance._femaleAvatar);
				((HistoryStack<T>)(object)history).Push((T)state);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F97")]
		[Cpp2IlInjected.Address(RVA = "0x15166B0", Offset = "0x15150B0", VA = "0x1815166B0")]
		private void FlushHistory()
		{
			if (_historyEnabled)
			{
				((HistoryStack<T>)(object)_history)?.Flush();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F98")]
		[Cpp2IlInjected.Address(RVA = "0x1515B70", Offset = "0x1514570", VA = "0x181515B70")]
		private bool CleanHistory(Item item, int designId)
		{
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			if (_historyEnabled)
			{
				HistoryStack<AvatarWorkingCopy> history = _history;
				if (history != null)
				{
					Func<AvatarWorkingCopy, bool> func = (Func<AvatarWorkingCopy, bool>)(object)new Func<T, TResult>(Cleanup);
					return ((HistoryStack<T>)(object)history).Clean((Func<, >)(object)func);
				}
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6002FE9")]
			[Cpp2IlInjected.Address(RVA = "0x1BD6880", Offset = "0x1BD5280", VA = "0x181BD6880")]
			bool Cleanup(AvatarWorkingCopy savedAvatar)
			{
				//Discarded unreachable code: IL_002c
				Item item3 = item2;
				bool flag = savedAvatar.IsWearing(item3);
				if (!flag)
				{
					return flag;
				}
				Item item4 = item2;
				return savedAvatar.GetClothingCustomization(item4) == designId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F99")]
		[Cpp2IlInjected.Address(RVA = "0x151AB30", Offset = "0x1519530", VA = "0x18151AB30")]
		[AsyncStateMachine(typeof(_003CUndo_003Ed__112))]
		public Task Undo()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9A")]
		[Cpp2IlInjected.Address(RVA = "0x1517E70", Offset = "0x1516870", VA = "0x181517E70")]
		[AsyncStateMachine(typeof(_003CRedo_003Ed__113))]
		public Task Redo()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9B")]
		[Cpp2IlInjected.Address(RVA = "0x1515A10", Offset = "0x1514410", VA = "0x181515A10")]
		public bool CanUndo()
		{
			if (_historyEnabled)
			{
				HistoryStack<AvatarWorkingCopy> history = _history;
				if (history != null)
				{
					return ((HistoryStack<T>)(object)history).CanUndo();
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9C")]
		[Cpp2IlInjected.Address(RVA = "0x1519070", Offset = "0x1517A70", VA = "0x181519070")]
		[AsyncStateMachine(typeof(_003CSetGender_003Ed__115))]
		public Task SetGender(bool isMale)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9D")]
		[Cpp2IlInjected.Address(RVA = "0x1518B70", Offset = "0x1517570", VA = "0x181518B70")]
		[AsyncStateMachine(typeof(_003CSetBodyType_003Ed__116))]
		public Task SetBodyType(int bodyTypeIndex)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9E")]
		[Cpp2IlInjected.Address(RVA = "0x1517F70", Offset = "0x1516970", VA = "0x181517F70")]
		[AsyncStateMachine(typeof(_003CRemoveClothes_003Ed__117))]
		public Task RemoveClothes(ClothingItemType clothingType, bool loadCurrent = true)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9F")]
		[Cpp2IlInjected.Address(RVA = "0x1518550", Offset = "0x1516F50", VA = "0x181518550")]
		[AsyncStateMachine(typeof(_003CSelectClothes_003Ed__118))]
		public Task SelectClothes(Item item, bool playAnimation, bool loadCurrent = true)
		{
			int itemID = item.ItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA0")]
		[Cpp2IlInjected.Address(RVA = "0x1518680", Offset = "0x1517080", VA = "0x181518680")]
		[AsyncStateMachine(typeof(_003CSelectClothes_003Ed__119))]
		public Task SelectClothes(Item item, int designId, bool playAnimation, bool loadCurrent = true)
		{
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA1")]
		[Cpp2IlInjected.Address(RVA = "0x1518C80", Offset = "0x1517680", VA = "0x181518C80")]
		[AsyncStateMachine(typeof(_003CSetClothingDesign_003Ed__120))]
		public Task SetClothingDesign(Item item, int designId, bool playAnimation)
		{
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA2")]
		[Cpp2IlInjected.Address(RVA = "0x1516920", Offset = "0x1515320", VA = "0x181516920")]
		public bool IsWearing(ClothingItemType clothingType, out Item item, out int designId)
		{
			//Discarded unreachable code: IL_0014
			return avatar.appearance.IsWearing(clothingType, out item, out designId);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA3")]
		[Cpp2IlInjected.Address(RVA = "0x151AE00", Offset = "0x1519800", VA = "0x18151AE00")]
		private void UpdateClothingDesignId(ClothingItemType clothingType, int designId)
		{
			//Discarded unreachable code: IL_0025
			AvatarAppearance appearance = avatar.appearance;
			Dictionary<ClothingItemType, AvatarAppearance.LoadedClothes> loadedClothes = appearance._loadedClothes;
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<ClothingItemType, AvatarAppearance.LoadedClothes> loadedClothes2 = appearance._loadedClothes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA4")]
		[Cpp2IlInjected.Address(RVA = "0x1517D50", Offset = "0x1516750", VA = "0x181517D50")]
		private void PlaySelectClothesAnimation(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_0051
			List<SelectionAnimTrigger> list = selectionAnimTriggers;
			Predicate<SelectionAnimTrigger> predicate = (Predicate<SelectionAnimTrigger>)(object)(Predicate<T>)delegate(SelectionAnimTrigger a)
			{
				//Discarded unreachable code: IL_0011
				ClothingItemType clothingItemType = clothingType;
				return a.clothingType == clothingItemType;
			};
			SelectionAnimTrigger selectionAnimTrigger = (SelectionAnimTrigger)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			if (selectionAnimTrigger != null)
			{
				Animator animator = avatar.Animator;
				string parameter = selectionAnimTrigger.parameter;
				animator.SetTrigger(parameter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA5")]
		[Cpp2IlInjected.Address(RVA = "0x1518090", Offset = "0x1516A90", VA = "0x181518090")]
		public void RemoveMakeup(MakeupItemType makeupType)
		{
			//Discarded unreachable code: IL_0049
			AvatarAppearance appearance = avatar.appearance;
			int num = 0;
			if (appearance.IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = appearance._femaleAvatar;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			Dictionary<MakeupItemType, AvatarAppearance.LoadedMakeup> loadedMakeup = appearance._loadedMakeup;
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				if (flag3)
				{
				}
				Dictionary<MakeupItemType, AvatarAppearance.LoadedMakeup> loadedMakeup2 = appearance._loadedMakeup;
			}
			appearance.UpdateMakeup();
			SaveHistory();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA6")]
		[Cpp2IlInjected.Address(RVA = "0x15187D0", Offset = "0x15171D0", VA = "0x1815187D0")]
		[AsyncStateMachine(typeof(_003CSelectMakeup_003Ed__125))]
		public Task SelectMakeup(MakeupItem makeupItem)
		{
			int makeupItemID = makeupItem.MakeupItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA7")]
		[Cpp2IlInjected.Address(RVA = "0x1519300", Offset = "0x1517D00", VA = "0x181519300")]
		public void SetMakeupColor1(MakeupItemType type, int index, bool saveHistory = true)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA8")]
		[Cpp2IlInjected.Address(RVA = "0x15194C0", Offset = "0x1517EC0", VA = "0x1815194C0")]
		public void SetMakeupColor2(MakeupItemType type, int index, bool saveHistory = true)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA9")]
		[Cpp2IlInjected.Address(RVA = "0x1519680", Offset = "0x1518080", VA = "0x181519680")]
		public void SetMakeupColor3(MakeupItemType type, int index, bool saveHistory = true)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAA")]
		[Cpp2IlInjected.Address(RVA = "0x1519840", Offset = "0x1518240", VA = "0x181519840")]
		public void SetMakeupOpacity(MakeupItemType type, float opacity, bool saveHistory = true)
		{
			//Discarded unreachable code: IL_0048
			AvatarAppearance appearance = avatar.appearance;
			int num = 0;
			if (appearance.IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = appearance._femaleAvatar;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<MakeupItemType, AvatarAppearance.LoadedMakeup> loadedMakeup = appearance._loadedMakeup;
				bool flag2 = default(bool);
				if (flag2)
				{
					Dictionary<MakeupItemType, AvatarAppearance.LoadedMakeup> loadedMakeup2 = appearance._loadedMakeup;
				}
				appearance.UpdateMakeup();
				if (saveHistory)
				{
					SaveHistory();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAB")]
		[Cpp2IlInjected.Address(RVA = "0x1518F50", Offset = "0x1517950", VA = "0x181518F50")]
		[AsyncStateMachine(typeof(_003CSetFaceType_003Ed__130))]
		public Task SetFaceType(FacePartType facePartType, int index)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAC")]
		[Cpp2IlInjected.Address(RVA = "0x15199B0", Offset = "0x15183B0", VA = "0x1815199B0")]
		[AsyncStateMachine(typeof(_003CSetSkinColor_003Ed__131))]
		public Task SetSkinColor(int skinColorIndex, bool forceSave = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAD")]
		[Cpp2IlInjected.Address(RVA = "0x1518DC0", Offset = "0x15177C0", VA = "0x181518DC0")]
		public void SetEyeColor(int color, bool forceSave = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAE")]
		[Cpp2IlInjected.Address(RVA = "0x1519180", Offset = "0x1517B80", VA = "0x181519180")]
		public void SetHairColor(int hairColorIndex, bool forceSave = false)
		{
			//Discarded unreachable code: IL_0058
			AvatarAppearance appearance = avatar.appearance;
			bool _003CIsMale_003Ek__BackingField = appearance.IsMale;
			if (_003CIsMale_003Ek__BackingField)
			{
			}
			if (appearance._femaleAvatar.Data.hairColorIndex_ != hairColorIndex)
			{
				if (_003CIsMale_003Ek__BackingField)
				{
				}
				appearance._femaleAvatar.Data.hairColorIndex_ = hairColorIndex;
				appearance.ApplyHairColor();
				SaveHistory();
			}
			else if (forceSave)
			{
				SaveHistory();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAF")]
		[Cpp2IlInjected.Address(RVA = "0x1519240", Offset = "0x1517C40", VA = "0x181519240")]
		public void SetHairHightlightColor(int highlightColorIndex, bool forceSave = false)
		{
			//Discarded unreachable code: IL_0058
			AvatarAppearance appearance = avatar.appearance;
			bool _003CIsMale_003Ek__BackingField = appearance.IsMale;
			if (_003CIsMale_003Ek__BackingField)
			{
			}
			if (appearance._femaleAvatar.Data.hairHighlightColor_ != highlightColorIndex)
			{
				if (_003CIsMale_003Ek__BackingField)
				{
				}
				appearance._femaleAvatar.Data.hairHighlightColor_ = highlightColorIndex;
				appearance.ApplyHairColor();
				SaveHistory();
			}
			else if (forceSave)
			{
				SaveHistory();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB0")]
		[Cpp2IlInjected.Address(RVA = "0x15188E0", Offset = "0x15172E0", VA = "0x1815188E0")]
		[AsyncStateMachine(typeof(_003CSetAvatarBodyPreset_003Ed__135))]
		public Task SetAvatarBodyPreset(AvatarBodyPreset presetInfo)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB1")]
		[Cpp2IlInjected.Address(RVA = "0x1518A10", Offset = "0x1517410", VA = "0x181518A10")]
		[AsyncStateMachine(typeof(_003CSetAvatarTransfer_003Ed__136))]
		public Task<AvatarTransfer.Types.Result> SetAvatarTransfer(string avatarCode, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<AvatarTransfer.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB2")]
		[Cpp2IlInjected.Address(RVA = "0x1516710", Offset = "0x1515110", VA = "0x181516710")]
		public (bool, Meta.Customization.Avatar) GetAvatarBodyInfo()
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB3")]
		[Cpp2IlInjected.Address(RVA = "0x1516050", Offset = "0x1514A50", VA = "0x181516050")]
		private void FindValidPetPosition()
		{
			//Discarded unreachable code: IL_011d, IL_0123, IL_0129, IL_012f, IL_0135, IL_013b, IL_0141, IL_0147, IL_014d, IL_0153, IL_0159, IL_015f, IL_0165, IL_016b, IL_0171, IL_0177, IL_017d, IL_0183, IL_0189, IL_018f, IL_0195, IL_019b, IL_01a1, IL_01a7, IL_01ad, IL_01b3, IL_01b9, IL_01bf, IL_01c5, IL_01cb
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Transform customizationPetTransform = avatar.customizationPetTransform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			Transform customizationPetTransform2 = avatar.customizationPetTransform;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			PlayerAvatar playerAvatar = avatar;
			bool flag = default(bool);
			if (!flag)
			{
				Transform customizationPetTransform3 = playerAvatar.customizationPetTransform;
				Transform customizationPetTransform4 = avatar.customizationPetTransform;
				UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
				float z3 = vector3.z;
				PlayerAvatar playerAvatar2 = avatar;
				bool flag2 = default(bool);
				if (!flag2)
				{
					Transform customizationPetTransform5 = playerAvatar2.customizationPetTransform;
					Transform customizationPetTransform6 = avatar.customizationPetTransform;
					UnityEngine.Vector3 vector4 = default(UnityEngine.Vector3);
					float z4 = vector4.z;
					PlayerAvatar playerAvatar3 = avatar;
					bool flag3 = default(bool);
					if (!flag3)
					{
						Transform customizationPetTransform7 = playerAvatar3.customizationPetTransform;
						Transform customizationPetTransform8 = avatar.customizationPetTransform;
						UnityEngine.Vector3 vector5 = default(UnityEngine.Vector3);
						float z5 = vector5.z;
						bool flag4 = default(bool);
						if (flag4)
						{
							PetMaster petMaster = avatar.petMaster;
							Transform customizationPetTransform9 = avatar.customizationPetTransform;
						}
					}
					PetMaster petMaster2 = playerAvatar3.petMaster;
					Transform customizationPetTransform10 = avatar.customizationPetTransform;
				}
				PetMaster petMaster3 = playerAvatar2.petMaster;
				Transform customizationPetTransform11 = avatar.customizationPetTransform;
			}
			PetMaster petMaster4 = playerAvatar.petMaster;
			Transform customizationPetTransform12 = avatar.customizationPetTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB4")]
		[Cpp2IlInjected.Address(RVA = "0x151D380", Offset = "0x151BD80", VA = "0x18151D380")]
		public AvatarCustomization()
		{
		}//Discarded unreachable code: IL_0100

	}
}
