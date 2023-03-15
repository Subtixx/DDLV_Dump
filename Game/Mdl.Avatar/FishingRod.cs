using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using Meta.Grids;
using UnityEngine;
using UnityEngine.Animations;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A9C")]
	internal class FishingRod : Tool
	{
		[Cpp2IlInjected.Token(Token = "0x2000A9D")]
		private enum BobberState
		{
			[Cpp2IlInjected.Token(Token = "0x4003A71")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4003A72")]
			WaitingForThrow,
			[Cpp2IlInjected.Token(Token = "0x4003A73")]
			Throw,
			[Cpp2IlInjected.Token(Token = "0x4003A74")]
			WaitingForBite
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003A4F")]
		[SerializeField]
		private float _minCheckDistance = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4003A50")]
		[SerializeField]
		private float _maxCheckDistance = 6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003A51")]
		[SerializeField]
		private float _obstacleRaycastHeight = 2.4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4003A52")]
		[SerializeField]
		private float _targetMovementPressDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003A53")]
		[SerializeField]
		private AnimationCurve _targetMovementCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003A54")]
		[SerializeField]
		private Vector3 _bobberInactiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003A55")]
		[SerializeField]
		private Transform _bobberGridObjectVisualPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003A56")]
		[SerializeField]
		private FishingTarget _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003A57")]
		[SerializeField]
		private GameObject _hookSplashVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003A58")]
		[SerializeField]
		private GameObject _hookBuffedSplashVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003A59")]
		[SerializeField]
		private float _throwDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4003A5A")]
		[SerializeField]
		private AnimationCurve _bobberThrowAnimationCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4003A5B")]
		[SerializeField]
		private AnimationCurve _bobberWaitAnimationCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003A5C")]
		[SerializeField]
		private GameObject _buffedBobberVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003A5D")]
		private GameObject buffedBobberVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4003A5E")]
		[SerializeField]
		private GameObject _fishingLinePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4003A5F")]
		private FishingLine fishingLine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4003A60")]
		[SerializeField]
		private GameObject _fishingGroundFailureVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4003A61")]
		[SerializeField]
		private GameObject _fishingWaterFailureVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4003A62")]
		[SerializeField]
		private float _minimumTimeToCast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4003A63")]
		[ItemID]
		[SerializeField]
		private int[] gameplayTagsToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4003A65")]
		private float waterSurfaceOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4003A66")]
		private BobberState bobberState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4003A67")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4003A68")]
		private bool playedSplash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4003A69")]
		private Transform hookAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4003A6A")]
		private Transform hook;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4003A6B")]
		private AnimationEventDispatcher animationEventDispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4003A6C")]
		private Transform fishingLineAttachStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4003A6D")]
		private Transform fishingLineAttachEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4003A6E")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4003A6F")]
		private Transform buffVFXAttachPoint;

		[Cpp2IlInjected.Token(Token = "0x170006D8")]
		public override Toolbox.ToolType ToolType
		{
			[Cpp2IlInjected.Token(Token = "0x60030F7")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "8")]
			get
			{
				return Toolbox.ToolType.FishingRod;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D9")]
		public float FishingLineTension
		{
			[Cpp2IlInjected.Token(Token = "0x60030F8")]
			[Cpp2IlInjected.Address(RVA = "0x1378E40", Offset = "0x1377840", VA = "0x181378E40")]
			get
			{
				//Discarded unreachable code: IL_0021
				//IL_0010: Expected O, but got I4
				FishingLine fishingLine = this.fishingLine;
				int num = 0;
				if (!(fishingLine != (UnityEngine.Object)num))
				{
					int num2 = 0;
				}
				return this.fishingLine.tension;
			}
			[Cpp2IlInjected.Token(Token = "0x60030F9")]
			[Cpp2IlInjected.Address(RVA = "0x1379030", Offset = "0x1377A30", VA = "0x181379030")]
			set
			{
				//Discarded unreachable code: IL_0020
				//IL_0010: Expected O, but got I4
				FishingLine fishingLine = this.fishingLine;
				int num = 0;
				if (fishingLine != (UnityEngine.Object)num)
				{
					this.fishingLine.tension = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DA")]
		public Transform HookRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60030FA")]
			[Cpp2IlInjected.Address(RVA = "0x1378ED0", Offset = "0x13778D0", VA = "0x181378ED0")]
			[CompilerGenerated]
			get
			{
				return _003CHookRoot_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60030FB")]
			[Cpp2IlInjected.Address(RVA = "0x13790C0", Offset = "0x1377AC0", VA = "0x1813790C0")]
			[CompilerGenerated]
			private set
			{
				_003CHookRoot_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DB")]
		public Vector3 WaterSurfacePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60030FC")]
			[Cpp2IlInjected.Address(RVA = "0x1378EE0", Offset = "0x13778E0", VA = "0x181378EE0")]
			get
			{
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					float z = Vector3.zero.z;
				}
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				Vector3 vector3 = default(Vector3);
				float z4 = vector3.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030FD")]
		[Cpp2IlInjected.Address(RVA = "0x1378530", Offset = "0x1376F30", VA = "0x181378530", Slot = "5")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_01d3
			//IL_0016: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			//IL_0087: Expected O, but got I4
			//IL_00fe: Expected O, but got I4
			//IL_0112: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0190: Expected O, but got I4
			base.Start();
			Toolbox componentInParent = GetComponentInParent<Toolbox>();
			int num = 0;
			if (componentInParent == (UnityEngine.Object)num)
			{
				return;
			}
			int toolAttachmentPointType = 0;
			Transform toolAttachment = componentInParent.GetToolAttachment((Toolbox.ToolAttachmentPointType)toolAttachmentPointType);
			NodeAnchor[] componentsInChildren = GetComponentsInChildren<NodeAnchor>();
			Func<NodeAnchor, bool> _003C_003E9__44_ = _003C_003Ec._003C_003E9__44_0;
			if (_003C_003E9__44_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NodeAnchor x) => string.Equals(x.AnchorName, "HookRoot"));
			}
			NodeAnchor nodeAnchor = Enumerable.FirstOrDefault<NodeAnchor>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)_003C_003E9__44_);
			int num2 = 0;
			if ((object)nodeAnchor != null)
			{
				Transform transform = nodeAnchor.transform;
			}
			HookRoot = (Transform)num2;
			Transform transform2 = HookRoot;
			int num3 = 0;
			if (transform2 != (UnityEngine.Object)num3)
			{
				Transform transform3 = HookRoot;
				int index = 0;
				Transform transform4 = (hook = transform3.GetChild(index));
				Transform transform5 = hook;
				float z = Vector3.zero.z;
			}
			Func<NodeAnchor, bool> func = default(Func<NodeAnchor, bool>);
			if (_003C_003Ec._003C_003E9__44_1 == null)
			{
				func = (Func<NodeAnchor, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NodeAnchor x) => string.Equals(x.AnchorName, "RopeAttachStart")));
			}
			NodeAnchor nodeAnchor2 = Enumerable.FirstOrDefault<NodeAnchor>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
			if ((object)nodeAnchor2 != null)
			{
				Transform transform6 = nodeAnchor2.transform;
			}
			hookAnchor = (Transform)num2;
			PositionConstraint componentInChildren = GetComponentInChildren<PositionConstraint>();
			int num4 = 0;
			int num5 = componentInChildren.AddSource((ConstraintSource)num4);
			RotationConstraint componentInChildren2 = GetComponentInChildren<RotationConstraint>();
			int num6 = 0;
			int num7 = componentInChildren2.AddSource((ConstraintSource)num6);
			bool flag = default(bool);
			if (flag)
			{
				AnimationEventDispatcher animationEventDispatcher = this.animationEventDispatcher;
				AnimationEventDispatcher.AnimationEventHandler value = OnAvatarAnimationEvent;
				animationEventDispatcher.AnimationEvent += value;
			}
			Func<NodeAnchor, bool> func2 = default(Func<NodeAnchor, bool>);
			if (_003C_003Ec._003C_003E9__44_2 == null)
			{
				func2 = (Func<NodeAnchor, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NodeAnchor x) => string.Equals(x.AnchorName, "RopeAttachStart")));
			}
			NodeAnchor nodeAnchor3 = Enumerable.FirstOrDefault<NodeAnchor>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func2);
			if ((object)nodeAnchor3 != null)
			{
				Transform transform7 = nodeAnchor3.transform;
			}
			fishingLineAttachStart = (Transform)num2;
			Func<NodeAnchor, bool> func3 = default(Func<NodeAnchor, bool>);
			if (_003C_003Ec._003C_003E9__44_3 == null)
			{
				func3 = (Func<NodeAnchor, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NodeAnchor x) => string.Equals(x.AnchorName, "RopeAttachEnd")));
			}
			NodeAnchor nodeAnchor4 = Enumerable.FirstOrDefault<NodeAnchor>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func3);
			Transform transform8 = default(Transform);
			if ((object)nodeAnchor4 != null)
			{
				transform8 = nodeAnchor4.transform;
			}
			fishingLineAttachEnd = transform8;
		}

		[Cpp2IlInjected.Token(Token = "0x60030FE")]
		[Cpp2IlInjected.Address(RVA = "0x1377D60", Offset = "0x1376760", VA = "0x181377D60")]
		private unsafe void LateUpdate()
		{
			//Discarded unreachable code: IL_013c
			//IL_00d6: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			//IL_010f: Expected native int or pointer, but got O
			//IL_0136: Expected native int or pointer, but got O
			BobberState bobberState = this.bobberState;
			if (bobberState != 0)
			{
				if (bobberState != 0)
				{
					if (bobberState != 0)
					{
						if (bobberState != BobberState.WaitingForThrow)
						{
							goto IL_00d6;
						}
						Transform transform = hook;
						int num = 0;
						AnimationCurve bobberWaitAnimationCurve = _bobberWaitAnimationCurve;
						float time = Time.time;
						float num2 = bobberWaitAnimationCurve.Evaluate(time);
					}
					float value = timer;
					AnimationCurve bobberThrowAnimationCurve = _bobberThrowAnimationCurve;
					float time2 = Mathf.Clamp01(value);
					float num3 = bobberThrowAnimationCurve.Evaluate(time2);
					Transform transform2 = hook;
				}
				Transform transform3 = hookAnchor;
				Transform transform4 = hook;
			}
			Transform transform5 = HookRoot;
			Transform transform6 = transform5.transform;
			Transform transform7 = fishingLineAttachStart;
			Vector3 position = transform5.position;
			Transform transform8 = fishingLineAttachStart;
			Vector3 position2 = transform5.position;
			Transform transform9 = fishingLineAttachEnd;
			Vector3 localPosition = transform5.localPosition;
			Transform transform10 = hook;
			int num4 = 0;
			Vector3 zero = Vector3.zero;
			transform10.localPosition = (Vector3)num4;
			goto IL_00d6;
			IL_00d6:
			FishingLine fishingLine = this.fishingLine;
			int num5 = 0;
			if (fishingLine != (UnityEngine.Object)num5)
			{
				Transform transform11 = fishingLineAttachStart;
				FishingLine fishingLine2 = this.fishingLine;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				((Vector3*)(IntPtr)fishingLine2.lineStart)->z = z;
				Transform transform12 = fishingLineAttachEnd;
				FishingLine fishingLine3 = this.fishingLine;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				((Vector3*)(IntPtr)fishingLine3.lineEnd)->z = z2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030FF")]
		[Cpp2IlInjected.Address(RVA = "0x1378280", Offset = "0x1376C80", VA = "0x181378280", Slot = "6")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0035
			//IL_0016: Expected O, but got I4
			base.OnDestroy();
			AnimationEventDispatcher animationEventDispatcher = this.animationEventDispatcher;
			int num = 0;
			if (animationEventDispatcher != (UnityEngine.Object)num)
			{
				AnimationEventDispatcher animationEventDispatcher2 = this.animationEventDispatcher;
				AnimationEventDispatcher.AnimationEventHandler value = OnAvatarAnimationEvent;
				animationEventDispatcher2.AnimationEvent -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003100")]
		[Cpp2IlInjected.Address(RVA = "0x1378360", Offset = "0x1376D60", VA = "0x181378360")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = _target.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003101")]
		[Cpp2IlInjected.Address(RVA = "0x1378C20", Offset = "0x1377620", VA = "0x181378C20", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUseTool_003Ed__48))]
		protected override Task<bool> UseTool(PlayerAvatar avatar)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003102")]
		[Cpp2IlInjected.Address(RVA = "0x1377BF0", Offset = "0x13765F0", VA = "0x181377BF0", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_0061
			//IL_0017: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			base.InitWithGridObject(gridObject);
			Transform bobberGridObjectVisualPosition = _bobberGridObjectVisualPosition;
			int num = 0;
			if (bobberGridObjectVisualPosition != (UnityEngine.Object)num)
			{
				Transform transform = HookRoot;
				int num2 = 0;
				if (transform != (UnityEngine.Object)num2)
				{
					Transform transform2 = HookRoot.transform;
					Transform bobberGridObjectVisualPosition2 = _bobberGridObjectVisualPosition;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Transform transform3 = HookRoot.transform;
					Transform bobberGridObjectVisualPosition3 = _bobberGridObjectVisualPosition;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003103")]
		[Cpp2IlInjected.Address(RVA = "0x1378460", Offset = "0x1376E60", VA = "0x181378460")]
		internal void RemoveFishingLine()
		{
			//Discarded unreachable code: IL_002d
			//IL_0010: Expected O, but got I4
			//IL_002c: Expected O, but got I8
			FishingLine fishingLine = this.fishingLine;
			int num = 0;
			if (fishingLine != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(this.fishingLine.gameObject);
				this.fishingLine = (FishingLine)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003104")]
		[Cpp2IlInjected.Address(RVA = "0x1377AD0", Offset = "0x13764D0", VA = "0x181377AD0")]
		internal void HideBobber()
		{
			//Discarded unreachable code: IL_005b
			//IL_0010: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_005a: Expected I4, but got I8
			Transform transform = HookRoot;
			int num = 0;
			if (transform != (UnityEngine.Object)num)
			{
				Transform transform2 = HookRoot;
				float z = _bobberInactiveOffset.z;
			}
			Transform transform3 = hook;
			int num2 = 0;
			if (transform3 != (UnityEngine.Object)num2)
			{
				Transform transform4 = hook;
				float z2 = Vector3.zero.z;
			}
			bobberState = BobberState.None;
		}

		[Cpp2IlInjected.Token(Token = "0x6003105")]
		[Cpp2IlInjected.Address(RVA = "0x13781B0", Offset = "0x1376BB0", VA = "0x1813781B0")]
		private void OnAvatarAnimationEvent(string eventName, AnimationEventDispatcher.AnimationEventArgs args)
		{
			//Discarded unreachable code: IL_0042
			//IL_002f: Expected F4, but got I4
			//IL_0041: Expected I4, but got I8
			if (eventName == null)
			{
				return;
			}
			if ("FishingCastSpeed" != null)
			{
				if (bobberState == BobberState.WaitingForThrow)
				{
					Animator animator = avatar.Animator;
					int num = 0;
					animator.SetFloat("FishingCastSpeed", num);
				}
			}
			else if ("FishingCastSpeed" != null)
			{
				bobberState = BobberState.Throw;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003106")]
		[Cpp2IlInjected.Address(RVA = "0x13780B0", Offset = "0x1376AB0", VA = "0x1813780B0", Slot = "13")]
		[AsyncStateMachine(typeof(_003CLoadBuffVFXAndMaterialAsync_003Ed__53))]
		protected override Task LoadBuffVFXAndMaterialAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003107")]
		[Cpp2IlInjected.Address(RVA = "0x13783A0", Offset = "0x1376DA0", VA = "0x1813783A0", Slot = "14")]
		protected override void RemoveBuffVFXAndMaterial()
		{
			//IL_0016: Expected O, but got I4
			//IL_002d: Expected O, but got I8
			base.RemoveBuffVFXAndMaterial();
			GameObject gameObject = buffedBobberVFXInstance;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(buffedBobberVFXInstance);
				buffedBobberVFXInstance = (GameObject)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003108")]
		[Cpp2IlInjected.Address(RVA = "0x1378D50", Offset = "0x1377750", VA = "0x181378D50")]
		public unsafe FishingRod()
		{
			//IL_0054: Expected native int or pointer, but got O
			float z = Vector3.up.z;
			_throwDuration = 0.4f;
			_minimumTimeToCast = 0.4f;
			((Vector3*)(IntPtr)_bobberInactiveOffset)->z = z;
			base._002Ector();
		}
	}
}
