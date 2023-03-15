using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Gestures;
using Mdl.Motion;
using Mdl.Systems;
using Meta;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x200054E")]
	public class FurnitureCustomization : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x200054F")]
		public delegate void SaveFurnitureDesignError(SaveFurnitureDesign.Types.Result error);

		[Cpp2IlInjected.Token(Token = "0x2000550")]
		public delegate void DeleteFurnitureDesignError(DeleteFurnitureDesign.Types.Result error);

		[Cpp2IlInjected.Token(Token = "0x2000551")]
		public delegate void SaveFurnitureError(Meta.FurnitureCustomization.Types.Result error);

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002101")]
		public FurnitureAppearance furniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002102")]
		public float furnitureRotationFriction = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4002103")]
		public float furnitureRotationSpeed = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002104")]
		public float furnitureRotateBackAfterSeconds = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4002105")]
		public float furnitureRotateBackDuration = 0.8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002106")]
		public float zoomInDistance = 1.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4002107")]
		public float zoomInMaxX = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002108")]
		public float zoomInMaxY = 1.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002109")]
		public RectTransform inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400210A")]
		public float holdDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400210B")]
		public float dragTolerance = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400210C")]
		private UnityEngine.Vector3 _startingCameraPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400210D")]
		private Quaternion _startingCameraRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400210E")]
		private UnityEngine.Vector3 _targetCameraPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400210F")]
		private Quaternion _targetCameraRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002110")]
		private Tween<float> _initCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002111")]
		private Quaternion _defaultRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002112")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002113")]
		private HoldInPlaceGesture _hold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002114")]
		private float _idleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002115")]
		private Tween<Quaternion> _furnitureRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002116")]
		private bool _enableMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
		[Cpp2IlInjected.Token(Token = "0x4002117")]
		private bool _zoomedIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11A")]
		[Cpp2IlInjected.Token(Token = "0x4002118")]
		private bool _zoomedInOnFurniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11B")]
		[Cpp2IlInjected.Token(Token = "0x4002119")]
		private bool _holdWasTrue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400211A")]
		private int _cameraCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400211C")]
		private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x1700032C")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x60017C2")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAC0", Offset = "0x8B94C0", VA = "0x1808BAAC0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000036")]
		public event SaveFurnitureDesignError OnSaveFurnitureDesignError
		{
			[Cpp2IlInjected.Token(Token = "0x60017B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BA980", Offset = "0x8B9380", VA = "0x1808BA980")]
			[CompilerGenerated]
			add
			{
				SaveFurnitureDesignError onSaveFurnitureDesignError = this.OnSaveFurnitureDesignError;
				Delegate @delegate = Delegate.Combine(onSaveFurnitureDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSaveFurnitureDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60017B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB90", Offset = "0x8B9590", VA = "0x1808BAB90")]
			[CompilerGenerated]
			remove
			{
				SaveFurnitureDesignError onSaveFurnitureDesignError = this.OnSaveFurnitureDesignError;
				Delegate @delegate = Delegate.Remove(onSaveFurnitureDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSaveFurnitureDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000037")]
		public event DeleteFurnitureDesignError OnDeleteFurnitureDesignError
		{
			[Cpp2IlInjected.Token(Token = "0x60017B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8E0", Offset = "0x8B92E0", VA = "0x1808BA8E0")]
			[CompilerGenerated]
			add
			{
				DeleteFurnitureDesignError onDeleteFurnitureDesignError = this.OnDeleteFurnitureDesignError;
				Delegate @delegate = Delegate.Combine(onDeleteFurnitureDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDeleteFurnitureDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60017B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAF0", Offset = "0x8B94F0", VA = "0x1808BAAF0")]
			[CompilerGenerated]
			remove
			{
				DeleteFurnitureDesignError onDeleteFurnitureDesignError = this.OnDeleteFurnitureDesignError;
				Delegate @delegate = Delegate.Remove(onDeleteFurnitureDesignError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDeleteFurnitureDesignError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000038")]
		public event SaveFurnitureError OnSaveFurnitureError
		{
			[Cpp2IlInjected.Token(Token = "0x60017C0")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA20", Offset = "0x8B9420", VA = "0x1808BAA20")]
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
			[Cpp2IlInjected.Token(Token = "0x60017C1")]
			[Cpp2IlInjected.Address(RVA = "0x8BAC30", Offset = "0x8B9630", VA = "0x1808BAC30")]
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

		[Cpp2IlInjected.Token(Token = "0x60017B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B8CE0", Offset = "0x8B76E0", VA = "0x1808B8CE0")]
		[AsyncStateMachine(typeof(_003CSetDesignAsync_003Ed__8))]
		public Task SetDesignAsync(FurnitureItem furnitureItem, int designId, Action onComplete)
		{
			int furnitureItemID = furnitureItem.FurnitureItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60017B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B89E0", Offset = "0x8B73E0", VA = "0x1808B89E0")]
		[AsyncStateMachine(typeof(_003CSaveDesignAsync_003Ed__9))]
		public Task SaveDesignAsync(FurnitureItem furnitureItem, DesignWorkingCopy design, Action onComplete)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60017B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8890", Offset = "0x8B7290", VA = "0x1808B8890")]
		[AsyncStateMachine(typeof(_003CSaveDesignAsyncPrivate_003Ed__10))]
		private Task SaveDesignAsyncPrivate(FurnitureItem furnitureItem, DesignWorkingCopy design, Action onComplete)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60017B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8140", Offset = "0x8B6B40", VA = "0x1808B8140")]
		[AsyncStateMachine(typeof(_003CDeleteDesignAsync_003Ed__11))]
		public Task DeleteDesignAsync(FurnitureItem furnitureItem, DesignWorkingCopy design, Action onComplete)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60017BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FF0", Offset = "0x8B69F0", VA = "0x1808B7FF0")]
		[AsyncStateMachine(typeof(_003CDeleteDesignAsync_003Ed__12))]
		public Task DeleteDesignAsync(FurnitureItem furnitureItem, int designId, Action onComplete)
		{
			int furnitureItemID = furnitureItem.FurnitureItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60017BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B6C90", VA = "0x1808B8290")]
		public DesignWorkingCopy GetDesignWorkingCopy(bool clone)
		{
			//Discarded unreachable code: IL_003f
			//IL_003d: Expected I4, but got I8
			IDesign currentDesign = furniture.GetCurrentDesign();
			if (currentDesign == null)
			{
				DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy();
			}
			DesignWorkingCopy source = new DesignWorkingCopy(currentDesign);
			DesignWorkingCopy designWorkingCopy2 = default(DesignWorkingCopy);
			if (clone)
			{
				designWorkingCopy2 = new DesignWorkingCopy(source);
				designWorkingCopy2.Data.id_ = -1;
			}
			return designWorkingCopy2;
		}

		[Cpp2IlInjected.Token(Token = "0x60017BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E30", Offset = "0x8B7830", VA = "0x1808B8E30")]
		[AsyncStateMachine(typeof(_003CStartDesignMode_003Ed__14))]
		public Task StartDesignMode(bool forceEditDecals)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60017BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B9240", Offset = "0x8B7C40", VA = "0x1808B9240")]
		public void StopDesignMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8F40", Offset = "0x8B7940", VA = "0x1808B8F40")]
		public Collider StartEditingDecals()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B93D0", Offset = "0x8B7DD0", VA = "0x1808B93D0")]
		public void StopEditingDecals([Optional] Action callback)
		{
			//Discarded unreachable code: IL_0017
			furniture.holder.defaultCollider.enabled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60017C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9140", Offset = "0x8B7B40", VA = "0x1808B9140")]
		private void Start()
		{
			//IL_000f: Expected I4, but got I8
			//IL_000f: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			ulong num2 = default(ulong);
			int automaticRotation = default(int);
			int num = default(int);
			MoveGesture moveGesture = new MoveGesture(inputZone, (Camera)num, (byte)automaticRotation != 0, (byte)num2 != 0);
			automaticRotation = 0;
			num = 0;
			moveGesture.MaxForce = 1f;
			float num3 = (moveGesture.Friction = furnitureRotationFriction);
			_move = moveGesture;
			int num4 = default(int);
			HoldInPlaceGesture holdInPlaceGesture = new HoldInPlaceGesture(inputZone, (Camera)num4);
			num4 = 0;
			float num5 = (holdInPlaceGesture.MinDuration = holdDuration);
			float num6 = (holdInPlaceGesture.DragTolerance = dragTolerance);
			_hold = holdInPlaceGesture;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8380", Offset = "0x8B6D80", VA = "0x1808B8380", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_00f3
			Camera camera;
			string[] array;
			do
			{
				int cullingMask = playerCamera.cullingMask;
				camera = playerCamera;
				_cameraCullingMask = cullingMask;
				int cullingMask2 = camera.cullingMask;
				array = new string[1];
			}
			while ("Player" != null && array == null);
			array[0] = "Player";
			int num = (camera.cullingMask = LayerMask.GetMask(array));
			float z = UnityEngine.Vector3.forward.z;
			FurnitureAppearance furnitureAppearance = furniture;
			_enableMove = true;
			_zoomedInOnFurniture = false;
			Transform transform = furnitureAppearance.transform;
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z2 = vector.z;
			Transform transform2 = furniture.transform;
			Quaternion quaternion = (transform2.rotation = _defaultRotation);
			furniture.holder.defaultCollider.enabled = true;
			FurnitureAppearance furnitureAppearance2 = furniture;
			Profile profile = (furnitureAppearance2._currentProfile = SystemRoot.Instance.MetaClient.profile);
			Zoom();
		}

		[Cpp2IlInjected.Token(Token = "0x60017C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B86E0", Offset = "0x8B70E0", VA = "0x1808B86E0", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_008e
			//IL_0058: Expected O, but got I8
			Camera camera = playerCamera;
			int num = (camera.cullingMask = _cameraCullingMask);
			Collider defaultCollider = furniture.holder.defaultCollider;
			int num2 = ((defaultCollider.enabled = false) ? 1 : 0);
			FurnitureAppearance furnitureAppearance = furniture;
			Coroutine loadingCoroutine = furnitureAppearance._loadingCoroutine;
			if (loadingCoroutine != null)
			{
				furnitureAppearance.StopCoroutine(loadingCoroutine);
				furnitureAppearance._loadingCoroutine = (Coroutine)0;
			}
			furnitureAppearance.decalRenderingTool.StopProjector();
			furnitureAppearance.UnloadAllFurniture();
			FurnitureAppearance furnitureAppearance2 = furniture;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			furnitureAppearance2.RefreshAllDecals(profile);
		}

		[Cpp2IlInjected.Token(Token = "0x60017C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B95F0", Offset = "0x8B7FF0", VA = "0x1808B95F0")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8870", Offset = "0x8B7270", VA = "0x1808B8870")]
		public void RefreshAllDecals(Profile profile)
		{
			//Discarded unreachable code: IL_000d
			furniture.RefreshAllDecals(profile);
		}

		[Cpp2IlInjected.Token(Token = "0x60017CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B95A0", Offset = "0x8B7FA0", VA = "0x1808B95A0")]
		private void UpdateFurnitureRotation(Quaternion rotation, float progress)
		{
			//Discarded unreachable code: IL_000d
			Transform transform = furniture.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x60017CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B30", Offset = "0x8B7530", VA = "0x1808B8B30")]
		public void SelectFurniture(FurnitureItem furnitureItem)
		{
			//Discarded unreachable code: IL_009b
			//IL_0024: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0072: Expected I4, but got I8
			FurnitureAppearance furnitureAppearance;
			int itemID;
			Item item = default(Item);
			do
			{
				furnitureAppearance = this.furniture;
				itemID = item.ItemID;
				if (((MapField<TKey, TValue>)(object)furnitureAppearance._currentProfile.player_.furnitureData_).ContainsKey((TKey)itemID))
				{
					Furniture furniture = (Furniture)((MapField<TKey, TValue>)(object)furnitureAppearance._currentProfile.player_.furnitureData_)[(TKey)itemID];
				}
				int num = 0;
				furnitureAppearance._originalFurniture = (IFurniture)num;
			}
			while (furnitureAppearance._originalFurniture != null);
			Furniture furniture2 = new Furniture();
			furniture2.furnitureItem_ = itemID;
			furniture2.currentDesign_ = -1;
			furnitureAppearance._originalFurniture = furniture2;
			FurnitureWorkingCopy furnitureWorkingCopy = (furnitureAppearance.CurrentFurniture = new FurnitureWorkingCopy(furnitureAppearance._originalFurniture));
			int designOnly = 0;
			furnitureAppearance.LoadCurrent((byte)designOnly != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60017CC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3F0", Offset = "0x8B8DF0", VA = "0x1808BA3F0")]
		public unsafe void Zoom(float duration = 1f)
		{
			//Discarded unreachable code: IL_0129
			//IL_004c: Expected native int or pointer, but got O
			//IL_0080: Expected native int or pointer, but got O
			//IL_00dd: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			Transform transform = furniture.transform;
			Transform transform2 = furniture.transform;
			Quaternion quaternion = (transform2.rotation = _defaultRotation);
			Transform transform3 = playerCamera.transform;
			Camera camera = playerCamera;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			((UnityEngine.Vector3*)(IntPtr)_startingCameraPos)->z = z;
			Transform transform4 = camera.transform;
			Transform customizationStartCamera = furniture.customizationStartCamera;
			FurnitureAppearance furnitureAppearance = furniture;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			((UnityEngine.Vector3*)(IntPtr)_targetCameraPos)->z = z2;
			Transform customizationStartCamera2 = furnitureAppearance.customizationStartCamera;
			Transform transform5 = playerCamera.transform;
			float z3 = _targetCameraPos.z;
			UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
			float z4 = vector3.z;
			bool flag = default(bool);
			if (!flag)
			{
				Transform transform6 = playerCamera.transform;
				Quaternion targetCameraRot = _targetCameraRot;
				bool flag2 = default(bool);
				if (!flag2)
				{
					goto IL_011b;
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
			goto IL_011b;
			IL_011b:
			Transform transform7 = furniture.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x60017CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B9410", Offset = "0x8B7E10", VA = "0x1808B9410")]
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

		[Cpp2IlInjected.Token(Token = "0x60017CE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA820", Offset = "0x8B9220", VA = "0x1808BA820")]
		public FurnitureCustomization()
		{
		}
	}
}
