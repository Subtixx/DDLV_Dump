using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Scene;
using LeoLuz;
using Mdl.Cheats;
using Mdl.Systems;
using Meta.Util;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C70")]
	[CreateAssetMenu]
	public class PlayerNavigationConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000C71")]
		public class SceneTypeSpeedLimit
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40045A4")]
			public SceneType SceneType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40045A5")]
			public float SpeedLimit;

			[Cpp2IlInjected.Token(Token = "0x6003993")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SceneTypeSpeedLimit()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004577")]
		public ControlSchemeType defaultControls = ControlSchemeType.ThirdPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004578")]
		public ControlSchemeType defaultHookedControls = ControlSchemeType.ThirdPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004579")]
		[Tooltip("Run speed of character in units/s")]
		public float runSpeed = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400457A")]
		[Tooltip("Walk speed of character in units/s")]
		public float walkSpeed = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400457B")]
		[Range(0f, 1f)]
		[Tooltip("Proportion of axis amount at which the character starts to speed up. Note: cannot be 1.")]
		public float speedUpPoint = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400457C")]
		[Tooltip("Maximum acceleration of character in units/s^2")]
		public float acceleration = 8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400457D")]
		[Tooltip("Maximum deceleration of character in units/s^2")]
		public float deceleration = 8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400457E")]
		[Tooltip("Maximum angular speed of character in degrees/s")]
		public float angularSpeed = 120f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400457F")]
		[Tooltip("Maximum tap duration in seconds")]
		public float tapDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4004580")]
		[Tooltip("Maximum touch drag in ui local space (ui resolution reference)")]
		public float tapDragTolerance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004581")]
		[Tooltip("Minimum hold in place duration in seconds")]
		public float holdInPlaceDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4004582")]
		[Tooltip("Minimum hold in place drag in ui local space (ui resolution reference)")]
		public float holdInPlaceDragTolerance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004583")]
		public float swipeMinDistance = 500f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4004584")]
		public float swipeMinSpeed = 1000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004585")]
		public float switchModeMaxTouchTime = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4004586")]
		public float switchModeDragSpeed = 100f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004587")]
		public float idleTimeToSwitch = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4004588")]
		public float idleTimeToSwitchWithQueue = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004589")]
		public bool allowMoveAxesInHookedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400458A")]
		public bool allowWheelZoomInHookedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x400458B")]
		public bool allowSwitchingControls = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x400458C")]
		public bool allowWalkActionInHookedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400458D")]
		public bool allowMoveWithTwoFingers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400458E")]
		public int maxTasksInQueue = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400458F")]
		[InputAxesListDropdown(false)]
		public string horizontalAxis = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4004590")]
		[InputAxesListDropdown(false)]
		public string verticalAxis = "Vertical";

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4004591")]
		public float zoomInAtDistance = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4004592")]
		public List<SceneTypeSpeedLimit> sceneTypeSpeedLimits = (List<SceneTypeSpeedLimit>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4004593")]
		public bool useCameraFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4004594")]
		public Rect cameraFollowWalkRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4004595")]
		public float cameraFollowCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4004596")]
		public Rect cameraFollowTeleportRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4004597")]
		public bool manualAvatarRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4004598")]
		public float hookedMovementDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4004599")]
		public float interactionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400459A")]
		public float interactionRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400459B")]
		public float characterInteractionRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400459C")]
		public float characterInteractionAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400459D")]
		public int maxNumberOfInteractionInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400459E")]
		public string runTurnAnimatorParameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400459F")]
		public float runTurnMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40045A0")]
		public float runTurnSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40045A1")]
		public float hardStopThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40045A2")]
		public float hardTurnMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40045A3")]
		public float hardTurnFailSafeDuration;

		[Cpp2IlInjected.Token(Token = "0x6003990")]
		[Cpp2IlInjected.Address(RVA = "0x14C09C0", Offset = "0x14BF3C0", VA = "0x1814C09C0")]
		public float GetSpeedLimit(SceneType sceneType)
		{
			//Discarded unreachable code: IL_0040
			List<SceneTypeSpeedLimit> list = sceneTypeSpeedLimits;
			Func<SceneTypeSpeedLimit, bool> func = (Func<SceneTypeSpeedLimit, bool>)(object)(Func<T, TResult>)delegate(SceneTypeSpeedLimit x)
			{
				//Discarded unreachable code: IL_0011
				SceneType sceneType2 = sceneType;
				return x.SceneType == sceneType2;
			};
			return Enumerable.FirstOrDefault<SceneTypeSpeedLimit>((IEnumerable<>)list, (Func<, >)(object)func)?.SpeedLimit ?? runSpeed;
		}

		[Cpp2IlInjected.Token(Token = "0x6003991")]
		[Cpp2IlInjected.Address(RVA = "0x14C0AD0", Offset = "0x14BF4D0", VA = "0x1814C0AD0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Navigation\\PlayerNavigationConfig.cs", 110)]
		public void TracePlayerNav()
		{
			//Discarded unreachable code: IL_0010
			SystemRoot.Instance.GetSystem<PlayerNavigation>().DebugTraceInfo();
		}

		[Cpp2IlInjected.Token(Token = "0x6003992")]
		[Cpp2IlInjected.Address(RVA = "0x14C0BA0", Offset = "0x14BF5A0", VA = "0x1814C0BA0")]
		public PlayerNavigationConfig()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0012: Expected I4, but got I8
			//IL_00d2: Expected I4, but got I8
			//IL_011f: Expected O, but got I4
			//IL_0138: Expected O, but got I4
			//IL_0174: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			useCameraFollow = true;
			int num3 = 0;
			cameraFollowCenterOffset = 5f;
			cameraFollowWalkRect = (Rect)num;
			manualAvatarRotation = true;
			hookedMovementDelay = 1f;
			cameraFollowTeleportRect = (Rect)num3;
			interactionOffset = 1f;
			interactionRadius = 5f;
			characterInteractionRadius = 3f;
			characterInteractionAngle = 45f;
			maxNumberOfInteractionInfos = -1;
			runTurnAnimatorParameter = "RunTurn";
			runTurnMaxAngle = 90f;
			runTurnSmoothing = 0.9f;
			hardStopThreshold = 0.5f;
			hardTurnMinAngle = 125f;
			hardTurnFailSafeDuration = 0.6f;
			base._002Ector();
		}
	}
}
